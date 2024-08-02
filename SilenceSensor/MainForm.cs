using NAudio.CoreAudioApi;

namespace SilenceSensor
{
    public partial class MainForm : Form
    {
        private MMDeviceCollection? devices;
        public MainForm()
        {
            InitializeComponent();
            numSensorCount.ValueChanged += NumSensorCount_ValueChanged;

            // Set padding for grpSensors
            grpSensors.Padding = new Padding(10); // Adjust the padding value as needed
            LoadAudioDevices();
        }

        private void LoadAudioDevices()
        {
            using (MMDeviceEnumerator enumerator = new MMDeviceEnumerator())
            {
                devices = enumerator.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active);
            }
        }

        private void NumSensorCount_ValueChanged(object sender, EventArgs e)
        {
            int sensorCount = (int)numSensorCount.Value;
            CreateSensorGroupBoxes(sensorCount);
            OnSensorCountChanged(sensorCount);
        }

        private void CreateSensorGroupBoxes(int count)
        {
            // Clear existing group boxes inside grpSensors
            grpSensors.Controls.Clear();

            // Define margin between group boxes
            const int margin = 25;
            const int maxPerRow = 3; // Maximum number of GroupBoxes per row

            for (int i = 0; i < count; i++)
            {
                GroupBox groupBox = new GroupBox
                {
                    Text = $"Sensor {i + 1}",
                    Width = 240, // Increased width to accommodate the wider TextBox
                    Height = 120,
                    Top = (i / maxPerRow) * (100 + margin),
                    Left = (i % maxPerRow) * (240 + margin) // Adjusted for new width
                };

                // Create and add a Label
                Label label = new Label
                {
                    Text = "Sensor Name:",
                    Top = 20,
                    Left = 10,
                    Width = 80
                };
                groupBox.Controls.Add(label);

                // Create and add a TextBox with increased width
                TextBox textBox = new TextBox
                {
                    Top = 20,
                    Left = 100,
                    Width = 120 // Increased width
                };
                groupBox.Controls.Add(textBox);

                ComboBox comboBox = new ComboBox
                {
                    Top = 50,
                    Left = 10,
                    Width = 220,
                    DisplayMember = "FriendlyName",
                };
                if (devices != null)
                {
                    foreach (var device in devices)
                    {
                        comboBox.Items.Add(device);
                    }
                }
                groupBox.Controls.Add(comboBox);

                NAudio.Gui.VolumeMeter volumeMeter = new NAudio.Gui.VolumeMeter
                {
                    Top = 80,
                    Left = 10,
                    Width = 220,
                    Height = 30
                };
                groupBox.Controls.Add(volumeMeter);

                // Add the new group box to grpSensors
                grpSensors.Controls.Add(groupBox);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            numSensorCount.Value = Properties.Settings.Default.numSensorCount;
            CreateSensorGroupBoxes((int)numSensorCount.Value);
        }

        private void OnSensorCountChanged(int newCount)
        {
            Properties.Settings.Default.numSensorCount = newCount;
            Properties.Settings.Default.Save();
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void SaveSettings()
        {
            Properties.Settings.Default.Save();
        }
    }
}
