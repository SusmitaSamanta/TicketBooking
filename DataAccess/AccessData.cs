using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Apttus.Assignment.FamilyMembers1;
using Apttus.Assignment.FamilyMembers1.enums;

namespace Apttus.Assignment.DataAccess
{
    public class AccessData : IAccessData
    {
        public List<Members> GetMembers()
        {

            List<Members> members = new List<Members>();
            string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DatabaseforMembers.mdf;Integrated Security=True";
            //@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Data\MovieTicket\TicketDetail\Database.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            Console.WriteLine("for retrieving data");
            string query = "select * from Members";
            SqlCommand cmd1 = new SqlCommand(query, con);
            var reader = cmd1.ExecuteReader();

            while (reader.Read())
            {
               // reader.GetValue(0)
                var d_name = reader.GetString(0);
                var d_age = (int)reader.GetInt32(1);
                var d_role = ((String)reader.GetValue(2)).Trim();
                var d_gender = ((Gender)reader.GetValue(3));
                switch (d_role)
                {
                    case "Mother":
                        members.Add(new Mother(d_name, d_age, d_role));
                        break;

                    case "Father":
                        members.Add(new Father(d_name, d_age, d_role));
                        break;

                    case "GrandMother":
                        members.Add(new GrandMother(d_name, d_age, d_role));
                        break;

                    case "GrandFather":
                        members.Add(new GrandFather(d_name, d_age, d_role));
                        break;

                    case "Son":
                        members.Add(new Son(d_name, d_age, d_role));
                        break;
                }

            }
            con.Close();
            return members;
            
        }
    }
}