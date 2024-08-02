namespace SilenceSensor
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpSensorCount = new GroupBox();
            numSensorCount = new NumericUpDown();
            grpSensors = new GroupBox();
            btnSaveSettings = new Button();
            grpSensorCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSensorCount).BeginInit();
            SuspendLayout();
            // 
            // grpSensorCount
            // 
            grpSensorCount.Controls.Add(numSensorCount);
            grpSensorCount.Location = new Point(12, 12);
            grpSensorCount.Name = "grpSensorCount";
            grpSensorCount.Size = new Size(123, 57);
            grpSensorCount.TabIndex = 0;
            grpSensorCount.TabStop = false;
            grpSensorCount.Text = "Amount of Sensors";
            // 
            // numSensorCount
            // 
            numSensorCount.Location = new Point(6, 22);
            numSensorCount.Name = "numSensorCount";
            numSensorCount.Size = new Size(53, 23);
            numSensorCount.TabIndex = 0;
            // 
            // grpSensors
            // 
            grpSensors.AutoSize = true;
            grpSensors.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            grpSensors.Location = new Point(12, 75);
            grpSensors.Margin = new Padding(3, 300, 3, 3);
            grpSensors.MinimumSize = new Size(200, 100);
            grpSensors.Name = "grpSensors";
            grpSensors.Size = new Size(200, 100);
            grpSensors.TabIndex = 1;
            grpSensors.TabStop = false;
            grpSensors.Text = "Sensors";
            // 
            // btnSaveSettings
            // 
            btnSaveSettings.Location = new Point(158, 34);
            btnSaveSettings.Name = "btnSaveSettings";
            btnSaveSettings.Size = new Size(75, 23);
            btnSaveSettings.TabIndex = 2;
            btnSaveSettings.Text = "Save Settings";
            btnSaveSettings.UseVisualStyleBackColor = true;
            btnSaveSettings.Click += btnSaveSettings_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(792, 407);
            Controls.Add(btnSaveSettings);
            Controls.Add(grpSensors);
            Controls.Add(grpSensorCount);
            Name = "MainForm";
            Text = "Silence Sensor";
            Load += MainForm_Load;
            grpSensorCount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numSensorCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpSensorCount;
        private NumericUpDown numSensorCount;
        private GroupBox grpSensors;
        private Button btnSaveSettings;
    }
}
