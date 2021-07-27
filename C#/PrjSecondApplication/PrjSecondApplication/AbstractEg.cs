using System;
using System.Collections.Generic;
using System.Text;



namespace PrjSecondApplication
{

    abstract class RBI
    {
        internal string rule = "Customer should have aadhar card";
        //Abstract method;
        abstract public int HomeLoan();
        abstract public int EduLoan();

        //Non Abstract Method

        internal void Rules()
        {
            Console.WriteLine("Rules to be followed by all banks:{0}", rule);
        }
    }

    abstract class SBI : RBI
    {
        //SBI abstract method
        abstract public void SBICustomer();

        //RBI Abstract Method

        public override int HomeLoan()
        {
            return 8;
        }

        public override int EduLoan()
        {
            return 10;
        }
    }

    class SBIBranch : SBI
    {
        public override void SBICustomer()
        {
            Console.WriteLine("It has 1 lakh customer");
        }
    }

     class AbstractEg
    {
        static void Main()
        {
            //object cant be created for abstract class
            //RBI r=new RBI();
            /*SBI sbiobj = new SBI;
            Console.WriteLine("Sbi Home Loan:{0}", sbiobj.HomeLoan());
            Console.WriteLine("Sbi Edu Loan:{0}", sbiobj.EduLoan());

            sbiobj.Rules();

            SBIBranch sBIBranchobj = new SBIBranch();
            Console.WriteLine("SbiEduLoan:{0}",sBIBranchobj.EduLoan());
            Console.WriteLine("SbiHomeLoan:{0}", sBIBranchobj.HomeLoan());
            sBIBranchobj.SBICustomer();
            sBIBranchobj.Rules();*/

            //runtime polymorphism

            //reference of parent class

            //reference of parent class
            RBI rbiobj = new SBIBranch();
            //Object of child class 
            Console.WriteLine("SbiHomeLoan:{0}", rbiobj.EduLoan());
            Console.WriteLine("SbiEDULoan:{0}", rbiobj.HomeLoan());



            SBI sbiobj = new SBIBranch();
            sbiobj.SBICustomer();



            sbiobj.Rules();
            rbiobj.Rules();
        }
    }
}