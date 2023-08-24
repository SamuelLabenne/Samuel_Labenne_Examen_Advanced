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
            foreach (Form c in this.MdiChildren)
            {
                c.Close();
            }

            TabsForm child = new TabsForm();
            child.MdiParent = this;
            child.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNewEvent_Click(object sender, EventArgs e)
        {
            foreach (Form c in this.MdiChildren)
            {
                c.Close();
            }
            NewEventForm child = new NewEventForm();
            child.MdiParent = this;
            child.Show();
        }
    }
}