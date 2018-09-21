using System;
using System.Data.SqlClient;

namespace Ado_Joins
{
    class ADOJOIN

    {
        static SqlConnection con = null;
        static void Connection()
        {
            try
            {

                string str = @"Data Source=DESKTOP-KUEO82L\LAXMAN;Initial Catalog=Laxman;Integrated Security=True";
                con = new SqlConnection(str);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Somthing wrong : " + ex);
            }
        }
        static void InnerJoin()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM PERSON P INNER JOIN PERSON1 A ON P.pID = A.pID;", con);
                SqlDataReader reader = cmd.ExecuteReader();
                Console.WriteLine(".......................INNER JOIN.......................");
                Console.WriteLine();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.Write(reader.GetName(i) + " ");
                }
                Console.WriteLine();
                Console.WriteLine("===========================================================================================");
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.Write(reader[i] + "\t");
                    }
                    Console.Write("\n");
                }
                Console.WriteLine("===========================================================================================");
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR :" + ex);
            }
            finally
            {
                con.Close();
            }
        }
        static void SelfJoin()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * from PERSON P inner join PERSON1 P2 on P.pID = P2.pID;", con);
                SqlDataReader reader = cmd.ExecuteReader();
                Console.WriteLine(".......................SELF JOIN.......................");
                Console.WriteLine();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.Write(reader.GetName(i) + " ");
                }
                Console.WriteLine();
                Console.WriteLine("===========================================================================================");
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.Write(reader[i] + "\t");
                    }
                    Console.Write("\n");
                }
                Console.WriteLine("===========================================================================================");
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR :" + ex);
            }
            finally
            {
                con.Close();
            }
        }
        static void LeftOuterJoin()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM PERSON P LEFT OUTER JOIN PERSON1 A ON P.pID = A.pID", con);
                SqlDataReader reader = cmd.ExecuteReader();
                Console.WriteLine(".......................LEFT OUTER JOIN.......................");
                Console.WriteLine();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.Write(reader.GetName(i) + " ");
                }
                Console.WriteLine();
                Console.WriteLine("===========================================================================================");
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.Write(reader[i] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("===========================================================================================");
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex);
            }
            finally
            {
                con.Close();
            }
        }
        static void RightOuterJoin()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM PERSON P RIGHT OUTER JOIN PERSON1 A ON P.pID = A.pID", con);
                SqlDataReader reader = cmd.ExecuteReader();
                Console.WriteLine(".......................RIGHT OUTER JOIN.......................");
                Console.WriteLine();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.Write(reader.GetName(i) + " ");
                }
                Console.WriteLine();
                Console.WriteLine("===========================================================================================");
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.Write(reader[i] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("===========================================================================================");
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex);
            }
            finally
            {
                con.Close();
            }
        }
        static void FullOuterJoin()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM PERSON P FULL OUTER JOIN PERSON1 A ON P.pID = A.pID", con);
                SqlDataReader reader = cmd.ExecuteReader();
                Console.WriteLine(".......................FULL OUTER JOIN.......................");
                Console.WriteLine();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.Write(reader.GetName(i) + " ");
                }
                Console.WriteLine();
                Console.WriteLine("===========================================================================================");
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.Write(reader[i] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("===========================================================================================");
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex);
            }
            finally
            {
                con.Close();
                Console.Read();
            }
        }
        static void Main(string[] args)
        {
            Connection();
            InnerJoin();
            SelfJoin();
            LeftOuterJoin();
            RightOuterJoin();
            FullOuterJoin();
            Console.ReadKey();
        }
    }
}