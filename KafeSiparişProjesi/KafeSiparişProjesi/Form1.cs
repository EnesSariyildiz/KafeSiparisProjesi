namespace KafeSiparişProjesi
{
    public partial class Form1 : Form
    {
        public object Form2 { get; private set; }

        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true; // Formun içinde form açılabilir yapmak için.
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

        private void cappuccinoSourButton_Click(object sender, EventArgs e)
        {
            int cappuccinoSourButton = Convert.ToInt32(cappuccinoCountLabel.Text);
            if (cappuccinoSourButton >= 1)
            {
                cappuccinoSourButton--;
            }
            cappuccinoCountLabel.Text = Convert.ToString(cappuccinoSourButton);
        }

        private void türkKahvesiSourButton_Click(object sender, EventArgs e)
        {
            int türkKahvesiSourButton = Convert.ToInt32(türkKahvesiCountLabel.Text);
            if (türkKahvesiSourButton >= 1)
            {
                türkKahvesiSourButton--;
            }
            türkKahvesiCountLabel.Text = Convert.ToString(türkKahvesiSourButton);
        }

        private void mochaSourButton_Click(object sender, EventArgs e)
        {
            int mochaSourButton = Convert.ToInt32(mochaCountLabel.Text);
            if (mochaSourButton >= 1)
            {
                mochaSourButton--;
            }
            mochaCountLabel.Text = Convert.ToString(mochaSourButton);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cappuccinoCountLabel.Text = "0";
            espressoCountLabel.Text = "0";
            türkKahvesiCountLabel.Text = "0";
            mochaCountLabel.Text = "0";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();


            /* İlk denediğim yöntem.
            Form2 form2 = new Form2(); // Açılmasını istediğim formu burada tanıtıyorum.
            Form2 MdiParent = this; // Bu form parent olarak yani yeni sayfa şekilde açılması için yazılan kod.
            Form2.Show(); // Açılmasını istediğim form açılıyor.
            */

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}