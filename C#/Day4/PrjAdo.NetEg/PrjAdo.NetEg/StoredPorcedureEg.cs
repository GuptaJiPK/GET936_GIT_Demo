using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace PrjAdo.NetEg
{
    class DataAccessLayer
    {
        SqlConnection con = null;
        SqlCommand cmd = null;

        public SqlConnection GetConnection()
        {
            con = new SqlConnection(

                   "Data Source = DESKTOP-97CN9B7; Initial Catalog = Northwind; Integrated Security = true");
            con.Open();
            return con;
        }

        //CProcedureWithoutParameter

        internal void CallTenMostExpensiveProduct()
        {
            try
            {
                con = GetConnection();
                //Procedure name in SqlServer
                cmd = new SqlCommand("Ten Most Expensive Products",con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine(dr[0] + " " + dr[1]);

                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                con.Close();
            }
        }
        internal void CallCustOrdersOrders(string cid)
        {
            try
            {
                con = GetConnection();
                cmd = new SqlCommand("CustOrdersOrders", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CustomerId", cid);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine(dr[0] + " " + dr[1]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                con.Close();
            }
        }
    }

    
    class StoredPorcedureEg
    {
        /*static void Main()
        {
            DataAccessLayer spobject = new DataAccessLayer();
            spobject.CallTenMostExpensiveProduct();

            Console.WriteLine("Enter the Customer Id:");
            string cid = Console.ReadLine();
            spobject.CallCustOrdersOrders(cid);
     
        }*/
        static void Main()
        {
            DataAccessLayer dataAccessLayer = new DataAccessLayer();
            Console.WriteLine("Enter \n1.Ten Most Expensive Products.   2.CustOrdersOrders");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    dataAccessLayer.CallTenMostExpensiveProducts();
                    break;
                case 2:
                    Console.WriteLine("Enter the CustomerId");
                    string cid = Console.ReadLine();
                    dataAccessLayer.CallCustOrdersOrders(cid);
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
    }
}
