using System;
using MySql.Data.MySqlClient;

namespace binitalab3
{
    class question9
    {
        static string connectionString = "SERVER=localhost;DATABASE=binita;UID=root;PASSWORD=";

        //static void Main(string[] args)
        //{
        //    int choice;

        //    do
        //    {
        //        Console.Clear();
        //        Console.WriteLine("CRUD Operations on MySQL Database");
        //        Console.WriteLine("1. Create Student");
        //        Console.WriteLine("2. Read Students");
        //        Console.WriteLine("3. Update Student");
        //        Console.WriteLine("4. Delete Student");
        //        Console.WriteLine("5. Exit");
        //        Console.Write("Enter your choice: ");
        //        choice = int.Parse(Console.ReadLine());

        //        switch (choice)
        //        {
        //            case 1:
        //                CreateStudent();
        //                break;
        //            case 2:
        //                ReadStudents();
        //                break;
        //            case 3:
        //                UpdateStudent();
        //                break;
        //            case 4:
        //                DeleteStudent();
        //                break;
        //            case 5:
        //                Console.WriteLine("Exiting...");
        //                break;
        //            default:
        //                Console.WriteLine("Invalid choice. Please try again.");
        //                break;
        //        }

        //        Console.WriteLine("\nPress any key to continue...");
        //        Console.ReadKey();
        //        Console.Read();

        //    } while (choice != 5);
        //}

        static void CreateStudent()
        {
            try
            {
                Console.Write("Enter Roll No: ");
                int roll = int.Parse(Console.ReadLine());
                Console.Write("Enter Name: ");
                string name = Console.ReadLine();
                Console.Write("Enter Semester: ");
                int sem = int.Parse(Console.ReadLine());

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO student (roll, name, sem) VALUES (@roll, @name, @sem)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@roll", roll);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@sem", sem);
                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            Console.WriteLine("Student created successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Error creating student.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        static void ReadStudents()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM student";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            Console.WriteLine("\nStudents in Database:");
                            while (reader.Read())
                            {
                                Console.WriteLine($"Roll No: {reader["roll"]}, Name: {reader["name"]}, Semester: {reader["sem"]}");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        static void UpdateStudent()
        {
            try
            {
                Console.Write("Enter Roll No to update: ");
                int roll = int.Parse(Console.ReadLine());

                Console.Write("Enter new Name: ");
                string newName = Console.ReadLine();
                Console.Write("Enter new Semester: ");
                int newSem = int.Parse(Console.ReadLine());

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE student SET name = @name, sem = @sem WHERE roll = @roll";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", newName);
                        cmd.Parameters.AddWithValue("@sem", newSem);
                        cmd.Parameters.AddWithValue("@roll", roll);
                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            Console.WriteLine("Student updated successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Student not found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        static void DeleteStudent()
        {
            try
            {
                Console.Write("Enter Roll No to delete: ");
                int roll = int.Parse(Console.ReadLine());

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM student WHERE roll = @roll";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@roll", roll);
                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            Console.WriteLine("Student deleted successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Student not found.");
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
