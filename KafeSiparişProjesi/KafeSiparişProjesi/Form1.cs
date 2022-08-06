namespace KafeSiparişProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void espressoPlusButton_Click(object sender, EventArgs e)
        {
            int espressoCount = Convert.ToInt32(espressoCountLabel.Text);
            espressoCount++;
            espressoCountLabel.Text = Convert.ToString(espressoCount);
        }

        private void cappuccinoPlusButton_Click(object sender, EventArgs e)
        {
            int cappuccinoCount = Convert.ToInt32(cappuccinoCountLabel.Text);
            cappuccinoCount++;
            cappuccinoCountLabel.Text = Convert.ToString(cappuccinoCount);
        }

        private void espressoSourButton_Click(object sender, EventArgs e)
        {
            int espressoCount = Convert.ToInt32(espressoCountLabel.Text);
            if (espressoCount>=1)
            {
                espressoCount--;
            }
            espressoCountLabel.Text = Convert.ToString(espressoCount);
        }

        private void türkKahvesiPlusButton_Click(object sender, EventArgs e)
        {
            int türkKahvesiCount = Convert.ToInt32(türkKahvesiCountLabel.Text);
            türkKahvesiCount++;
            türkKahvesiCountLabel.Text = Convert.ToString(türkKahvesiCount);
        }

        private void mochaPlusButton_Click(object sender, EventArgs e)
        {
            int mochaCount = Convert.ToInt32(mochaCountLabel.Text);
            mochaCount++;
            mochaCountLabel.Text = Convert.ToString(mochaCount);
        }
    }
}