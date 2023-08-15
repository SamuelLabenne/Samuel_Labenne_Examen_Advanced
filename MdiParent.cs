namespace Samuel_Labenne_Examen_Advanced
{
    public partial class MdiParent : Form
    {

        public MdiParent()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            TabsForm child = new TabsForm();
            child.MdiParent = this;
            child.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNewEvent_Click(object sender, EventArgs e)
        {
            NewEventForm child = new NewEventForm();
            child.MdiParent = this;
            child.Show();
        }
    }
}