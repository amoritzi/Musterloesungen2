using Personalverwaltung.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;



namespace Personalverwaltung.Controller
{
    class PersonenController
    {
        string connString = @"Data Source=(local)\SQLEXPRESS;" +
                               "Initial Catalog=Personalverwaltung;" +
                               "Integrated Security=sspi";

        Person person = new Person();

        public List<Person> personenliste = new List<Person>();
        

        public Person ErfassenPerson()
        {
            person.Name = MainForm.PName;
            person.Vorname = MainForm.Vorname;
            person.Strasse = MainForm.Strasse;
            person.PLZ = MainForm.PLZ;
            person.Ort = MainForm.Ort;
            person.Telefon = MainForm.Telefon;

            return person;
        }

        public Person ErfassenMutPerson()
        {
            person.ID = Convert.ToInt32(MainForm.updateID);
            person.Name = MainForm.PName;
            person.Vorname = MainForm.Vorname;
            person.Strasse = MainForm.Strasse;
            person.PLZ = MainForm.PLZ;
            person.Ort = MainForm.Ort;
            person.Telefon = MainForm.Telefon;

            return person;
        }
        public void SchreibenPerson()
        {
            using (SqlConnection con = new SqlConnection(connString))
            {
                SqlCommand cmd = SetPerson(person);
                con.Open();
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
            }
        }

        public void MutierenPerson()
        {
            using (SqlConnection con = new SqlConnection(connString))
            {
                SqlCommand cmd = UpdatePerson(person);
                con.Open();
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
            }
        }
        
        public void LoeschenPerson()
        {
            using (SqlConnection con = new SqlConnection(connString))
            {
                SqlCommand cmd = DeletePerson();
                con.Open();
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
            }
        }

        private SqlCommand SetPerson(Person pers)
        {
            string insertStr = @"INSERT INTO Persons" +
                "(Name, Vorname, Strasse, PLZ, Ort, Telefon)" +
                "VALUES (@Name, @Vorname, @Strasse, @PLZ, @Ort, @Telefon)";
            SqlCommand cmd = new SqlCommand(insertStr);
            cmd.Parameters.AddWithValue("@Name", pers.Name);
            cmd.Parameters.AddWithValue("@Vorname", pers.Vorname);
            cmd.Parameters.AddWithValue("@Strasse", pers.Strasse);
            cmd.Parameters.AddWithValue("@PLZ", pers.PLZ);
            cmd.Parameters.AddWithValue("@Ort", pers.Ort);
            cmd.Parameters.AddWithValue("@Telefon", pers.Telefon);
            return cmd;
        }

        public SqlCommand DeletePerson()
        {
            string delID = MainForm.deleteID;
            string deleteStr = string.Format("Delete from Persons where ID = '{0}'", delID);
            SqlCommand cmd = new SqlCommand(deleteStr);
            return cmd;
        }

        public SqlCommand UpdatePerson(Person pers)
        {
           string updID = MainForm.updateID;

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "UPDATE Persons SET [Name] = @Name, [Vorname] = @Vorname," +
                "[Strasse] = @Strasse, [PLZ] = @PLZ, [Ort] = @Ort, [Telefon] = @Telefon WHERE [ID] = @ID";
            cmd.Parameters.AddWithValue("@Name", pers.Name);
            cmd.Parameters.AddWithValue("@Vorname", pers.Vorname);
            cmd.Parameters.AddWithValue("@Strasse", pers.Strasse);
            cmd.Parameters.AddWithValue("@PLZ", pers.PLZ);
            cmd.Parameters.AddWithValue("@Ort", pers.Ort);
            cmd.Parameters.AddWithValue("@Telefon", pers.Telefon);
            cmd.Parameters.AddWithValue("@ID", updID);
            return cmd;
        }

        public void ReadData(string connString, string queryString)
        {
            using (SqlConnection con = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand(queryString, con);
                con.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                  var personenliste = (reader.ToString());

                }
            }
        }

    }
}


