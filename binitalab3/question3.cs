using System;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace binitalab3
{
    internal class question3
    {
        public void AddStudent()
        {
            try
            {
                int roll = int.Parse(Console.ReadLine());
                string name = Console.ReadLine();
                int semester = int.Parse(Console.ReadLine());
                MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=binita;UID=root;PASSWORD=");
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("insert into student(roll,name,sem) values(@r,@n,@s)", conn);
                cmd.Parameters.AddWithValue("@r", roll);
                cmd.Parameters.AddWithValue("@n", name);
                cmd.Parameters.AddWithValue("@s", semester);
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    Console.WriteLine("Insert success");
                }
                else
                {
                    Console.WriteLine("Insert failed");
                }
                conn.Close();
            }
            catch (MySqlException mex)
            {
                Console.WriteLine("Database error: " + mex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public void ListStudent()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=binita;UID=root;PASSWORD=");
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from student", conn);
                MySqlDataAdapter mda = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                mda.Fill(dt);
                if (dt.Rows.Count != 0)
                {
                    Console.WriteLine("roll \t\t Name \t\t Semester");
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string roll = dt.Rows[i]["roll"].ToString();
                        string name = dt.Rows[i]["name"].ToString();
                        string semester = dt.Rows[i]["sem"].ToString();
                        Console.WriteLine($"{roll} \t\t  {name} \t{semester}");

                    }
                }
                else
                {
                    Console.WriteLine("Data not found");
                }
                conn.Close();
            }
            catch (MySqlException mex)
            {
                Console.WriteLine("Database error: " + mex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        //static void Main(string[] args)
        //{
        //    int option;
        //    Console.WriteLine("Select Option : \n 1. Insert \t 2. Select");
        //    option = int.Parse(Console.ReadLine());
        //    question3 demo= new question3();
        //    switch (option)
        //    {
        //        case 1:
        //            demo.AddStudent();
        //            break;
        //        case 2:
        //            demo.ListStudent();
        //            break;
        //    }
        //    Console.ReadKey();
        //    Console.Read();
        //}
    }
}

