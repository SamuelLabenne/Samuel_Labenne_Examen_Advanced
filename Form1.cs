namespace Samuel_Labenne_Examen_Advanced
{
    public partial class Form1 : Form
    {
        BindingSource eventBindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EventsDAO eventsDAO = new EventsDAO();
            Event e1 = new Event
            { Id = 1,
            Name = "testevent"
            };
            Event e2 = new Event
            {
                Id = 2,
                Name = "testeventzzz"
            };
            
            eventsDAO.events.Add(e1);
            eventsDAO.events.Add(e2);

            eventBindingSource.DataSource = eventsDAO.events;

            dataGridView1.DataSource = eventsDAO.events;

        } 
    }
}