using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Samuel_Labenne_Examen_Advanced
{
    internal class EventsDAO
    {
        
        static string info = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\..\", "EventsDBB.mdf"));
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;" +
                                     $"AttachDbFilename={info};" +
                                    "Integrated Security=True;" +
                                    "Connect Timeout=30";

        public List<Event> events = new List<Event>();
        public List<Person> people = new List<Person>();
        public List<Invite> invites = new List<Invite>();

        public List<Event> getAllEvents()
        {
            List<Event> events = new List<Event>();

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("SELECT Id, Name, Description, Location, Date, Invited FROM Events", connection);

            connection.Open();



            
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    events.Add(new Event()
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Description = reader.GetString(2),
                        Location = reader.GetString(3),
                        Date = reader.GetDateTime(4),
                        Invited = reader.GetString(5),
                    });

                }

                connection.Close();

                return events;
            }
        }

        public void populateList()
        {
            List<Person> people = new List<Person>{
                new Person { Name = "John", Age = 22 },
                new Person { Name = "Marcus", Age = 32 },
                new Person { Name = "Ella", Age = 51 }
            };


            using (SqlConnection connection = new SqlConnection(connectionString))
            {


                SqlCommand command = new SqlCommand("insert into People values(@Name,@Age)", connection); 
                
                connection.Open();

                foreach (Person person in people)
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@Name", person.Name);
                    command.Parameters.AddWithValue("@Age", person.Age);
                    command.ExecuteNonQuery();

                }

            }

        }

        public List<Person> getAllPeople()
        {
            List<Person> people = new List<Person>();

           

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("SELECT Id, Name, Age FROM People", connection);

            connection.Open();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    people.Add(new Person()
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Age = reader.GetInt32(2)
                    });

                }

                connection.Close();

                return people;
            }
        }
        public List<Invite> getAllInvites()
        {
            List<Invite> invites = new List<Invite>();



            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("SELECT Id, PersonId, EventId FROM Invites", connection);

            connection.Open();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    invites.Add(new Invite()
                    {
                        Id = reader.GetInt32(0),
                        PersonId = reader.GetInt32(0),
                        EventId = reader.GetInt32(2)
                    });

                }

                connection.Close();

                return invites;
            }
        }
    }
}
