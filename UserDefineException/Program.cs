using System;

namespace UserDefineException
{

    class MyException : Exception
    {
        public MyException(String str)
        {
            Console.WriteLine("User Define Exception");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new Exception("SHAMBHU");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught here" + e.ToString());
            }
            Console.WriteLine("LAST STATEMENT");
        }
       
    }
}
