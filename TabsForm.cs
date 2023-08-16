using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Samuel_Labenne_Examen_Advanced
{
    public partial class TabsForm : Form
    {
        BindingSource eventBindingSource = new BindingSource();
        BindingSource peopleBindingSource = new BindingSource();
        BindingSource inviteBindingSource = new BindingSource();
        //int id;

        public TabsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EventsDAO eventsDAO = new EventsDAO();
            eventsDAO.EventsRetrieved += EventsDAO_EventsRetrieved;

            

            eventsDAO.events = eventsDAO.getAllEvents();


            eventBindingSource.DataSource = eventsDAO.events;

            dataGridView1.DataSource = eventsDAO.events;
        }
        private void EventsDAO_EventsRetrieved(object sender, EventArgs e)
            {
                MessageBox.Show("Events retrieved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        private void button3_Click(object sender, EventArgs e)
        {
            EventsDAO eventsDAO = new EventsDAO();

            eventsDAO.people = eventsDAO.getAllPeople();


            peopleBindingSource.DataSource = eventsDAO.people;

            dataGridView2.DataSource = eventsDAO.people;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           /* if(e.RowIndex > 0) {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            }*/
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TabsForm_Load(object sender, EventArgs e)
        {

        }

        private void btnInvites_Click(object sender, EventArgs e)
        {
            EventsDAO eventsDAO = new EventsDAO();

            eventsDAO.invites = eventsDAO.getAllInvites();


            inviteBindingSource.DataSource = eventsDAO.invites;

            dataGridView3.DataSource = eventsDAO.invites;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

    }
}
