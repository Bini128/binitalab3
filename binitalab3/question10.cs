using System;
using MySql.Data.MySqlClient;

namespace binitalab3
{
    class question10
    {
        static string connectionString = "SERVER=localhost;DATABASE=binita;UID=root;PASSWORD=";

        static void Main(string[] args)
        {
            SaveTourismInfo();
        }

        static void SaveTourismInfo()
        {
            try
            {
                Console.Write("Enter Title of the Tour Destination: ");
                string title = Console.ReadLine();

                Console.Write("Enter Description of the Tour Destination: ");
                string description = Console.ReadLine();

                Console.Write("Enter Duration of the Tour (in days): ");
                int duration = int.Parse(Console.ReadLine());

                DateTime createdDate = DateTime.Now;

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO tour_destination (title, description, duration, CreatedDate) VALUES (@title, @description, @duration, @createdDate)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@title", title);
                        cmd.Parameters.AddWithValue("@description", description);
                        cmd.Parameters.AddWithValue("@duration", duration);
                        cmd.Parameters.AddWithValue("@createdDate", createdDate);

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            Console.WriteLine("Tour Destination saved successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Error saving the tour destination.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}

