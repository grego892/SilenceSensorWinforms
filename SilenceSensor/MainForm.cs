namespace SilenceSensor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            numSensorCount.ValueChanged += NumSensorCount_ValueChanged;

            // Set padding for grpSensors
            grpSensors.Padding = new Padding(10); // Adjust the padding value as needed
        }

        private void NumSensorCount_ValueChanged(object sender, EventArgs e)
        {
            CreateSensorGroupBoxes((int)numSensorCount.Value);
        }

        private void CreateSensorGroupBoxes(int count)
        {
            // Clear existing group boxes inside grpSensors
            grpSensors.Controls.Clear();

            // Define margin between group boxes
            int margin = 10;
            int maxPerRow = 3; // Maximum number of GroupBoxes per row

            for (int i = 0; i < count; i++)
            {
                GroupBox groupBox = new GroupBox
                {
                    Text = $"Sensor {i + 1}",
                    Width = 200,
                    Height = 100,
                    Top = (i / maxPerRow) * (100 + margin),
                    Left = (i % maxPerRow) * (200 + margin)
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

                // Create and add a TextBox
                TextBox textBox = new TextBox
                {
                    Top = 20,
                    Left = 100,
                    Width = 80
                };
                groupBox.Controls.Add(textBox);

                // Add the new group box to grpSensors
                grpSensors.Controls.Add(groupBox);
            }
        }
    }
}

