using System;
using MySql.Data.MySqlClient;

namespace binitalab3
{
    internal class question4
    {
        static void EditRecord()
        {
            try
            {
                Console.Write("Enter the Roll No you want to edit: ");
                int roll = int.Parse(Console.ReadLine());

                Console.Write("Enter new Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter new Semester: ");
                int sem = int.Parse(Console.ReadLine());

                using (MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=binita;UID=root;PASSWORD="))
                {
                    conn.Open(); 

                    string query = "UPDATE student SET name = @name, sem = @sem WHERE roll = @roll";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@roll", roll);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@sem", sem);

                        int rowsAffected = cmd.ExecuteNonQuery();  
                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Record updated successfully.");
                        }
                        else
                        {
                            Console.WriteLine("No record found with the given Roll No.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        static void DeleteRecord()
        {
            try
            {
                Console.Write("Enter the Roll No you want to delete: ");
                int roll = int.Parse(Console.ReadLine());

                using (MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=binita;UID=root;PASSWORD="))
                {
                    conn.Open();  

                    string query = "DELETE FROM student WHERE roll = @roll";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@roll", roll);

                        int rowsAffected = cmd.ExecuteNonQuery();  
                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Record deleted successfully.");
                        }
                        else
                        {
                            Console.WriteLine("No record found with the given Roll No.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Choose an operation:");
        //    Console.WriteLine("1. Edit (Update) Record");
        //    Console.WriteLine("2. Delete Record");
        //    int choice = int.Parse(Console.ReadLine());

        //    switch (choice)
        //    {
        //        case 1:
        //            EditRecord();
        //            break;
        //        case 2:
        //            DeleteRecord();
        //            break;
        //        default:
        //            Console.WriteLine("Invalid choice.");
        //            break;
        //    }

        //    Console.Read();
        //    Console.ReadKey();
        //}
    }
}
