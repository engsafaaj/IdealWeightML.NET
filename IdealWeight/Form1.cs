namespace IdealWeight
{
    public partial class IdealForm : Form
    {
        public IdealForm()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            CalBMI();
            //Load sample data
            var sampleData = new MLModel1.ModelInput()
            {
                Age = (float)numericUpDownAge.Value,
                Gender = comboBoxGender.SelectedItem.ToString(),
                Height = (float)numericUpDownHegiht.Value,
                Weight = (float)numericUpDownWeight.Value,
                BMI = (float)Convert.ToDecimal(textBoxBMI.Text),
                PhysicalActivityLevel = (float)Convert.ToDecimal(comboBoxPAL.SelectedItem),
            };

            //Load model and predict output
            var result = MLModel1.Predict(sampleData);
            textBoxResult.Text = result.PredictedLabel;
        }

        private void CalBMI()
        {
            var Wegiht = numericUpDownWeight.Value;
            var Height = numericUpDownHegiht.Value / 100;
            textBoxBMI.Text = (Wegiht / (Height * Height)).ToString();
        }

        private void numericUpDownHegiht_ValueChanged(object sender, EventArgs e)
        {
            CalBMI();
        }

        private void numericUpDownWeight_ValueChanged(object sender, EventArgs e)
        {
            CalBMI();
        }
    }
}
