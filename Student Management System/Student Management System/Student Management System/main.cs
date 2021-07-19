using System;

namespace Student_Management_System
{
    class main
    {
        static void Main(string[] args)
        {
            try
            {
                University pucit = new University(101, "PUCIT");

                pucit.ADDSTUDENT();
                pucit.ADDSTUDENT();
                pucit.storeIntoDatabase();

                pucit.Delete(14);
                pucit.Update(15, "Abc", "aaa@gmail.com", 3.8);
                pucit.GetFromDatabase();
            }
            catch
            {
                Console.WriteLine("ENTER CORRECT DATA TYPE COMPATIBLE VALUES");
            }
        }
    }
}
