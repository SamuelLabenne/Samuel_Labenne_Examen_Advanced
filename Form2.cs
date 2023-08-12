using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Samuel_Labenne_Examen_Advanced
{
    public partial class Form2 : Form
    {
        BindingSource eventBindingSource = new BindingSource();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EventsDAO eventsDAO = new EventsDAO();
            Event e1 = new Event
            {
                Id = 1,
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

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
