namespace Samuel_Labenne_Examen_Advanced
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Form2 child = new Form2();
            child.Show();
        }
    }
}