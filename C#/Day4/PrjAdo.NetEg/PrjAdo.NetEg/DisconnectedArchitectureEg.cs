using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;


namespace PrjAdo.NetEg
{
    class DAL
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
        public void DisplayRegion()
        {
            con = GetConnection();

            SqlDataAdapter da;
            da = new SqlDataAdapter("select * from Region", con);
            DataSet ds = new DataSet();//--->Collection of tables
            //Putiing the tble inside dataset

            da.Fill(ds, "NWREGION");

            //reading the table ino from dataset

            DataTable dt;
            dt = ds.Tables["NWREGION"];

            foreach(DataRow row in dt.Rows)
            {
                foreach(DataColumn col in dt.Columns)
                {
                    Console.Write(row[col]);
                    Console.Write(" ");
                }
                Console.WriteLine(" ");
            }

            //adding one moretable to dataset:shipper

           /* Console.WriteLine("-------------------");
            Console.WriteLine("--------Shipper Table-----------");
            da = new SqlDataAdapter("select * from Shippers", con);
            da.Fill(ds, "NWSHIPPER");

            DataTable dt1 = ds.Tables["NWSHIPPER"];

            foreach(DataRow row in dt1.Rows)
            {
                foreach(DataColumn col in dt1.Columns)
                {
                    Console.Write(row[col]);
                    Console.Write(" ");
                }
                Console.WriteLine(" ");
            }*/

            //inserting new row in region table in dataset

            //Insert, Update, Delete Operations

            SqlCommandBuilder scb = new SqlCommandBuilder(da);
            da.Fill(ds);

            //Inseting or ADDING a new row 
            //creating a new row in NWREGION in dataset
            DataRow row1 = ds.Tables["NWREGION"].NewRow();
            row1["RegionID"] = 14;
            row1["RegionDescription"] = "asdfghfdfsdg";

            //Adding row to datatable in dataset
            ds.Tables["NWREGION"].Rows.Add(row1);

            da.Update(ds, "NWREGION");
            Console.WriteLine("-----------------");

            dt = ds.Tables["NWREGION"];

            foreach (DataRow dataRow in dt.Rows)
            {
                foreach (DataColumn dataColumn in dt.Columns)
                {
                    Console.Write(dataRow[dataColumn]);
                    Console.Write(" ");
                }
                Console.WriteLine(" ");
            }


        }
    }
    class DisconnectedArchitectureEg
    {
       static void Main()
        {
            DAL d = new DAL();
            d.DisplayRegion();
        }
    }
}
