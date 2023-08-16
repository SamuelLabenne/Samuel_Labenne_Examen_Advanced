using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Samuel_Labenne_Examen_Advanced
{
    public partial class NewEventForm : Form


    {
       

        BindingSource eventBindingSource = new BindingSource();
        BindingSource peopleBindingSource = new BindingSource();
        BindingSource inviteBindingSource = new BindingSource();


        static string info = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\..\", "EventsDBB.mdf"));
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;" +
                                     $"AttachDbFilename={info};" +
                                    "Integrated Security=True;" +
                                    "Connect Timeout=30";

        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;" +
                                     $"AttachDbFilename={info};" +
                                    "Integrated Security=True;" +
                                    "Connect Timeout=30");

        SqlCommand command;


        public NewEventForm()
        {
            InitializeComponent();
            
        }





        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                Event ev = new Event { Name = tbName.Text, Description = tbDescription.Text, Location = tbLocation.Text, Date = dateTimePicker1.Value, Invited = comboBox1.Text };
                var p = (Person)comboBox1.SelectedItem;
                Invite invite = new Invite { PersonId = p.Id, EventId = ev.Id };

                string insertEventQuery = "INSERT INTO Events (Name, Description, Location, Date, Invited) " +
                                          "VALUES (@Name, @Description, @Location, @Date, @Invited)";

                using (SqlCommand command = new SqlCommand(insertEventQuery, connection))
                {
                    command.Parameters.AddWithValue("@Name", ev.Name);
                    command.Parameters.AddWithValue("@Description", ev.Description);
                    command.Parameters.AddWithValue("@Location", ev.Location);
                    command.Parameters.AddWithValue("@Date", ev.Date);
                    command.Parameters.AddWithValue("@Invited", ev.Invited);

                    command.ExecuteNonQuery();
                }

                //createInvite(invite.PersonId, invite.EventId);

                //MessageBox.Show("Event inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
               
                MessageBox.Show("An error occurred while submitting the event", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }



        private void createInvite(int a, int b)

        {
            string insertInviteQuery = "INSERT INTO Invites (PersonId, EventId) VALUES (@PersonId, @EventId)";
            using (SqlCommand command = new SqlCommand(insertInviteQuery, connection))
            {
                command.Parameters.AddWithValue("@PersonId", a);
                command.Parameters.AddWithValue("@EventId", b);

                command.ExecuteNonQuery();
            }
            
            connection.Close();

        }

    

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void NewEventForm_Load(object sender, EventArgs e)
        {


            try
            {
                EventsDAO eventsDAO = new EventsDAO();

                eventsDAO.people = eventsDAO.getAllPeople();

                if (eventsDAO.people.Count == 1)
                {
                    eventsDAO.populateList();
                }

                peopleBindingSource.DataSource = eventsDAO.people;
                comboBox1.DataSource = eventsDAO.people;
                comboBox1.ValueMember = "Id";
                comboBox1.DisplayMember = "Name";
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("An error occurred while loading the form", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
