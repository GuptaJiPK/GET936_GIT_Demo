using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;//1.Installl the pkg

namespace PrjAdo.NetEg
{
    class Shipper
    {
        public int ShipperId { get; set; }
        public string Companyname { get; set; }
        public string Phone { get; set; }

        #region GetShipper
        public void GetShipper()
        {
            Console.WriteLine("Enter the Shipper or company name:");
            Companyname = Console.ReadLine();
            Console.WriteLine("Engter the phone number");
            Phone = Console.ReadLine();
        }

        #endregion
        public void LooseShipper()
        {
            Console.WriteLine("Enter the Shippernaem or company name");
            Companyname = Console.ReadLine();
        }
        public void EditShipper()
        {
            Console.WriteLine("enter the shiper id:");
            ShipperId = Convert.ToInt32(Console.ReadLine());
            GetShipper();

        }

    }

    class ConnectedArchitectureEg
    {
        static void Main()
        {
            //2. Cretae sql Connection object

            SqlConnection con = null;

            //creating command object

            SqlCommand cmd = null;

            try
            {
                //3. Window Authentication
                con = new SqlConnection(

                  "Data Source = DESKTOP-97CN9B7; Initial Catalog = Northwind; Integrated Security = true");

                //Sql server authentication

                // con = new SqlConnection(

                // "Data Source= DESKTOP-U8J1M3C\\MSSQLSERVER01;Initial Catalog=Northwind;User ID=sa;Password=newuser123#");


                //4.
                con.Open();

                //creating object of shipper class
                Shipper shipper = new Shipper();

                //calling Get shipper method

                //Insertion

                /*shipper.GetShipper();
                cmd = new SqlCommand("insert into Shippers(CompanyName,Phone) values(@cname,@phone)", con);
                cmd.Parameters.AddWithValue("@cname", shipper.Companyname);
                cmd.Parameters.AddWithValue("@phone", shipper.Phone);
                int i = cmd.ExecuteNonQuery();
                Console.WriteLine("No of Rows Affected: {0}", i);*/

                //Deletion
                //Calling  Loose ShipperMethod
                shipper.LooseShipper();
                cmd = new SqlCommand("delete from Shippers where CompanyName=@cname", con);
                cmd.Parameters.AddWithValue("@cname", shipper.Companyname);
                int i = cmd.ExecuteNonQuery();//return int
                Console.WriteLine("No of rows affetcte:{0}", i);
                cmd.Parameters.Clear();

                //Select

                /* SqlDataReader dr;
                 cmd = new SqlCommand("select * from Shippers",con);
                 dr = cmd.ExecuteReader();
                 while (dr.Read())
                 {
                     Console.WriteLine(dr[0] + " " + dr[1] + " "+dr[2]);
                     Console.WriteLine(dr["CompanyName"] + " " + dr["Phone"]);
                 }*/

                //Update
                /* #region ShipperUpdate

                 shipper.EditShipper();

                 cmd = new SqlCommand("update Shippers set CpmapnyName=@cname Phone=@phone where ShipperID=@id", con);
                 cmd.Parameters.AddWithValue("@id", shipper.ShipperId);
                 cmd.Parameters.AddWithValue("@cname", shipper.Companyname);
                 cmd.Parameters.AddWithValue("@phone", shipper.Phone);

                 int i = cmd.ExecuteNonQuery();

                 Console.WriteLine("No of rows updated is {0}", i);
                 #endregion*/

                /*update in region table from northwind*/
                //Scalar Vaue
                /* cmd= new SqlCommand("select count(ShipperId) from Shippers", con);
                 Console.WriteLine("Total shipper:{0}", Convert.ToInt32(cmd.ExecuteScalar()));*/



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
}
