namespace PoolSensorEmulator
{
    partial class PoolSensorEmulator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GenerateInfiniteRandomValues = new System.Windows.Forms.Button();
            this.poolIdLabel = new System.Windows.Forms.Label();
            this.poolIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.panelManualValues = new System.Windows.Forms.Panel();
            this.phNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SendOneMessageWithValueButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.generateInfiniteValuesPanel = new System.Windows.Forms.Panel();
            this.numberOfMessagesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.randomValueTemperature = new System.Windows.Forms.Label();
            this.randomValuePh = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.temperatureNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.poolIdNumericUpDown)).BeginInit();
            this.panelManualValues.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phNumericUpDown)).BeginInit();
            this.generateInfiniteValuesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfMessagesNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // GenerateInfiniteRandomValues
            // 
            this.GenerateInfiniteRandomValues.Location = new System.Drawing.Point(10, 67);
            this.GenerateInfiniteRandomValues.Name = "GenerateInfiniteRandomValues";
            this.GenerateInfiniteRandomValues.Size = new System.Drawing.Size(228, 23);
            this.GenerateInfiniteRandomValues.TabIndex = 0;
            this.GenerateInfiniteRandomValues.Text = "Send messages";
            this.GenerateInfiniteRandomValues.UseVisualStyleBackColor = true;
            this.GenerateInfiniteRandomValues.Click += new System.EventHandler(this.GenerateInfiniteRandomValuesClick);
            // 
            // poolIdLabel
            // 
            this.poolIdLabel.AutoSize = true;
            this.poolIdLabel.Location = new System.Drawing.Point(9, 20);
            this.poolIdLabel.Name = "poolIdLabel";
            this.poolIdLabel.Size = new System.Drawing.Size(45, 13);
            this.poolIdLabel.TabIndex = 1;
            this.poolIdLabel.Text = "Pool ID:";
            // 
            // poolIdNumericUpDown
            // 
            this.poolIdNumericUpDown.Location = new System.Drawing.Point(93, 18);
            this.poolIdNumericUpDown.Name = "poolIdNumericUpDown";
            this.poolIdNumericUpDown.Size = new System.Drawing.Size(75, 20);
            this.poolIdNumericUpDown.TabIndex = 2;
            this.poolIdNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panelManualValues
            // 
            this.panelManualValues.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelManualValues.Controls.Add(this.temperatureNumericUpDown);
            this.panelManualValues.Controls.Add(this.phNumericUpDown);
            this.panelManualValues.Controls.Add(this.SendOneMessageWithValueButton);
            this.panelManualValues.Controls.Add(this.label3);
            this.panelManualValues.Controls.Add(this.label2);
            this.panelManualValues.Controls.Add(this.label1);
            this.panelManualValues.Location = new System.Drawing.Point(12, 58);
            this.panelManualValues.Name = "panelManualValues";
            this.panelManualValues.Size = new System.Drawing.Size(260, 162);
            this.panelManualValues.TabIndex = 3;
            // 
            // phNumericUpDown
            // 
            this.phNumericUpDown.DecimalPlaces = 1;
            this.phNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.phNumericUpDown.Location = new System.Drawing.Point(80, 51);
            this.phNumericUpDown.Maximum = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.phNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.phNumericUpDown.Name = "phNumericUpDown";
            this.phNumericUpDown.Size = new System.Drawing.Size(75, 20);
            this.phNumericUpDown.TabIndex = 6;
            this.phNumericUpDown.Value = new decimal(new int[] {
            70,
            0,
            0,
            65536});
            // 
            // SendOneMessageWithValueButton
            // 
            this.SendOneMessageWithValueButton.Location = new System.Drawing.Point(80, 125);
            this.SendOneMessageWithValueButton.Name = "SendOneMessageWithValueButton";
            this.SendOneMessageWithValueButton.Size = new System.Drawing.Size(75, 23);
            this.SendOneMessageWithValueButton.TabIndex = 5;
            this.SendOneMessageWithValueButton.Text = "Send";
            this.SendOneMessageWithValueButton.UseVisualStyleBackColor = true;
            this.SendOneMessageWithValueButton.Click += new System.EventHandler(this.SendOneMessageWithValueButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "temperature:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "pH:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Send one message with specified values";
            // 
            // generateInfiniteValuesPanel
            // 
            this.generateInfiniteValuesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.generateInfiniteValuesPanel.Controls.Add(this.numberOfMessagesNumericUpDown);
            this.generateInfiniteValuesPanel.Controls.Add(this.label7);
            this.generateInfiniteValuesPanel.Controls.Add(this.label4);
            this.generateInfiniteValuesPanel.Controls.Add(this.randomValueTemperature);
            this.generateInfiniteValuesPanel.Controls.Add(this.randomValuePh);
            this.generateInfiniteValuesPanel.Controls.Add(this.label6);
            this.generateInfiniteValuesPanel.Controls.Add(this.label5);
            this.generateInfiniteValuesPanel.Controls.Add(this.GenerateInfiniteRandomValues);
            this.generateInfiniteValuesPanel.Location = new System.Drawing.Point(12, 248);
            this.generateInfiniteValuesPanel.Name = "generateInfiniteValuesPanel";
            this.generateInfiniteValuesPanel.Size = new System.Drawing.Size(260, 176);
            this.generateInfiniteValuesPanel.TabIndex = 4;
            // 
            // numberOfMessagesNumericUpDown
            // 
            this.numberOfMessagesNumericUpDown.Location = new System.Drawing.Point(95, 29);
            this.numberOfMessagesNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numberOfMessagesNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfMessagesNumericUpDown.Name = "numberOfMessagesNumericUpDown";
            this.numberOfMessagesNumericUpDown.Size = new System.Drawing.Size(76, 20);
            this.numberOfMessagesNumericUpDown.TabIndex = 8;
            this.numberOfMessagesNumericUpDown.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "# of messages:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Generate random values";
            // 
            // randomValueTemperature
            // 
            this.randomValueTemperature.AutoSize = true;
            this.randomValueTemperature.Location = new System.Drawing.Point(96, 136);
            this.randomValueTemperature.Name = "randomValueTemperature";
            this.randomValueTemperature.Size = new System.Drawing.Size(16, 13);
            this.randomValueTemperature.TabIndex = 5;
            this.randomValueTemperature.Text = "---";
            // 
            // randomValuePh
            // 
            this.randomValuePh.AutoSize = true;
            this.randomValuePh.Location = new System.Drawing.Point(96, 110);
            this.randomValuePh.Name = "randomValuePh";
            this.randomValuePh.Size = new System.Drawing.Size(16, 13);
            this.randomValuePh.TabIndex = 4;
            this.randomValuePh.Text = "---";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "temperature:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "pH:";
            // 
            // temperatureNumericUpDown
            // 
            this.temperatureNumericUpDown.DecimalPlaces = 1;
            this.temperatureNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.temperatureNumericUpDown.Location = new System.Drawing.Point(79, 85);
            this.temperatureNumericUpDown.Maximum = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.temperatureNumericUpDown.Name = "temperatureNumericUpDown";
            this.temperatureNumericUpDown.Size = new System.Drawing.Size(75, 20);
            this.temperatureNumericUpDown.TabIndex = 7;
            this.temperatureNumericUpDown.Value = new decimal(new int[] {
            240,
            0,
            0,
            65536});
            // 
            // PoolSensorEmulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 446);
            this.Controls.Add(this.generateInfiniteValuesPanel);
            this.Controls.Add(this.panelManualValues);
            this.Controls.Add(this.poolIdNumericUpDown);
            this.Controls.Add(this.poolIdLabel);
            this.Name = "PoolSensorEmulator";
            this.Text = "Pool sensor Emulator";
            ((System.ComponentModel.ISupportInitialize)(this.poolIdNumericUpDown)).EndInit();
            this.panelManualValues.ResumeLayout(false);
            this.panelManualValues.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phNumericUpDown)).EndInit();
            this.generateInfiniteValuesPanel.ResumeLayout(false);
            this.generateInfiniteValuesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfMessagesNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenerateInfiniteRandomValues;
        private System.Windows.Forms.Label poolIdLabel;
        private System.Windows.Forms.NumericUpDown poolIdNumericUpDown;
        private System.Windows.Forms.Panel panelManualValues;
        private System.Windows.Forms.Button SendOneMessageWithValueButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel generateInfiniteValuesPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label randomValueTemperature;
        private System.Windows.Forms.Label randomValuePh;
        private System.Windows.Forms.NumericUpDown numberOfMessagesNumericUpDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown phNumericUpDown;
        private System.Windows.Forms.NumericUpDown temperatureNumericUpDown;
    }
}

