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
        public event EventHandler EventsRetrieved;
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

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT Id, Name, Description, Location, Date, Invited FROM Events", connection);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Event ev = new Event
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Description = reader.GetString(2),
                                Location = reader.GetString(3),
                                Date = reader.GetDateTime(4),
                                Invited = reader.GetString(5)
                            };

                            events.Add(ev);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("An error occurred while retrieving events", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            EventsRetrieved?.Invoke(this, EventArgs.Empty);

            return events;
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
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT Id, Name, Age FROM People", connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    return Enumerable.Range(0, int.MaxValue)
                                     .Select(_ => reader.Read() ? new Person
                                     {
                                         Id = reader.GetInt32(0),
                                         Name = reader.GetString(1),
                                         Age = reader.GetInt32(2)
                                     } : null)
                                     .TakeWhile(p => p != null)
                                     .ToList();
                }
            }
        }

        public List<Tuple<string, string>> GetPeopleAndEventsByInvites()
        {
            List<Tuple<string, string>> results = new List<Tuple<string, string>>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT P.Name AS PersonName, E.Name AS EventName " +
                                                    "FROM Invites I " +
                                                    "INNER JOIN People P ON I.PersonId = P.Id " +
                                                    "INNER JOIN Events E ON I.EventId = E.Id", connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string personName = reader.GetString(reader.GetOrdinal("PersonName"));
                        string eventName = reader.GetString(reader.GetOrdinal("EventName"));

                        results.Add(Tuple.Create(personName, eventName));
                    }
                }
            }

            return results;
        }
        public List<Invite> getAllInvites()
        {
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();




                SqlCommand command = new SqlCommand("SELECT Id, PersonId, EventId FROM Invites", connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    return Enumerable.Range(0, int.MaxValue)
                                     .Select(_ => reader.Read() ? new Invite
                                     {
                                         Id = reader.GetInt32(0),
                                         PersonId = reader.GetInt32(1),
                                         EventId = reader.GetInt32(2)
                                     } : null)
                                     .TakeWhile(i => i != null)
                                     .ToList();
                }
            }
        }
    }
}

