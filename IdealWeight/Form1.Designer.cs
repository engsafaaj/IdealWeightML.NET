namespace IdealWeight
{
    partial class IdealForm
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
            label1 = new Label();
            numericUpDownAge = new NumericUpDown();
            label2 = new Label();
            comboBoxGender = new ComboBox();
            label3 = new Label();
            numericUpDownHegiht = new NumericUpDown();
            numericUpDownWeight = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            textBoxBMI = new TextBox();
            label6 = new Label();
            comboBoxPAL = new ComboBox();
            buttonStart = new Button();
            textBoxResult = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHegiht).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWeight).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(33, 33);
            label1.Name = "label1";
            label1.Size = new Size(61, 32);
            label1.TabIndex = 0;
            label1.Text = "Age:";
            // 
            // numericUpDownAge
            // 
            numericUpDownAge.Font = new Font("Segoe UI", 14F);
            numericUpDownAge.Location = new Point(33, 77);
            numericUpDownAge.Margin = new Padding(4);
            numericUpDownAge.Maximum = new decimal(new int[] { 150, 0, 0, 0 });
            numericUpDownAge.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownAge.Name = "numericUpDownAge";
            numericUpDownAge.Size = new Size(357, 39);
            numericUpDownAge.TabIndex = 1;
            numericUpDownAge.Value = new decimal(new int[] { 25, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(33, 128);
            label2.Name = "label2";
            label2.Size = new Size(97, 32);
            label2.TabIndex = 0;
            label2.Text = "Gender:";
            // 
            // comboBoxGender
            // 
            comboBoxGender.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGender.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Items.AddRange(new object[] { "Male", "Female" });
            comboBoxGender.Location = new Point(33, 172);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(357, 39);
            comboBoxGender.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(33, 223);
            label3.Name = "label3";
            label3.Size = new Size(144, 32);
            label3.TabIndex = 0;
            label3.Text = "Height (cm):";
            // 
            // numericUpDownHegiht
            // 
            numericUpDownHegiht.Font = new Font("Segoe UI", 14F);
            numericUpDownHegiht.Location = new Point(33, 267);
            numericUpDownHegiht.Margin = new Padding(4);
            numericUpDownHegiht.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            numericUpDownHegiht.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownHegiht.Name = "numericUpDownHegiht";
            numericUpDownHegiht.Size = new Size(357, 39);
            numericUpDownHegiht.TabIndex = 1;
            numericUpDownHegiht.Value = new decimal(new int[] { 175, 0, 0, 0 });
            numericUpDownHegiht.ValueChanged += numericUpDownHegiht_ValueChanged;
            // 
            // numericUpDownWeight
            // 
            numericUpDownWeight.Font = new Font("Segoe UI", 14F);
            numericUpDownWeight.Location = new Point(33, 362);
            numericUpDownWeight.Margin = new Padding(4);
            numericUpDownWeight.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            numericUpDownWeight.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownWeight.Name = "numericUpDownWeight";
            numericUpDownWeight.Size = new Size(357, 39);
            numericUpDownWeight.TabIndex = 1;
            numericUpDownWeight.Value = new decimal(new int[] { 74, 0, 0, 0 });
            numericUpDownWeight.ValueChanged += numericUpDownWeight_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(33, 318);
            label4.Name = "label4";
            label4.Size = new Size(144, 32);
            label4.TabIndex = 0;
            label4.Text = "Weight (Kg):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(33, 413);
            label5.Name = "label5";
            label5.Size = new Size(56, 32);
            label5.TabIndex = 0;
            label5.Text = "BMI";
            // 
            // textBoxBMI
            // 
            textBoxBMI.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxBMI.Location = new Point(33, 457);
            textBoxBMI.Name = "textBoxBMI";
            textBoxBMI.ReadOnly = true;
            textBoxBMI.Size = new Size(352, 39);
            textBoxBMI.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F);
            label6.Location = new Point(33, 508);
            label6.Name = "label6";
            label6.Size = new Size(293, 32);
            label6.TabIndex = 0;
            label6.Text = "Physical Activity Level: 1-4";
            // 
            // comboBoxPAL
            // 
            comboBoxPAL.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPAL.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxPAL.FormattingEnabled = true;
            comboBoxPAL.Items.AddRange(new object[] { "1", "2", "3", "4" });
            comboBoxPAL.Location = new Point(33, 552);
            comboBoxPAL.Name = "comboBoxPAL";
            comboBoxPAL.Size = new Size(357, 39);
            comboBoxPAL.TabIndex = 2;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(33, 603);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(362, 62);
            buttonStart.TabIndex = 4;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // textBoxResult
            // 
            textBoxResult.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxResult.Location = new Point(33, 677);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(362, 61);
            textBoxResult.TabIndex = 3;
            // 
            // IdealForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 750);
            Controls.Add(buttonStart);
            Controls.Add(textBoxResult);
            Controls.Add(textBoxBMI);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBoxPAL);
            Controls.Add(label6);
            Controls.Add(comboBoxGender);
            Controls.Add(label2);
            Controls.Add(numericUpDownWeight);
            Controls.Add(numericUpDownHegiht);
            Controls.Add(numericUpDownAge);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "IdealForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ideal Weight";
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHegiht).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWeight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown numericUpDownAge;
        private Label label2;
        private ComboBox comboBoxGender;
        private Label label3;
        private NumericUpDown numericUpDownHegiht;
        private NumericUpDown numericUpDownWeight;
        private Label label4;
        private Label label5;
        private TextBox textBoxBMI;
        private Label label6;
        private ComboBox comboBoxPAL;
        private Button buttonStart;
        private TextBox textBoxResult;
    }
}
