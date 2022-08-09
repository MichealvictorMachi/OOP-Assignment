using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment
{
    public class RegProceedures
    {
       
        
            public string NewCampRegistration()
            {
                Console.WriteLine(" New Camp Registration: Please enter your first name");
                string firstName = Console.ReadLine();
                Console.WriteLine("Please enter your last name");
                string LastName = Console.ReadLine();
                Console.WriteLine("please enter your age");
                int age = Convert.ToInt32(Console.ReadLine());
                Random CampCode = new Random();
                int codeGen = CampCode.Next(10, 200);
                string Code = firstName + "-" + codeGen;
                return "Welcome " + firstName + ", your Registration Number is " + CampCode;
            }
        
        public string MedicalRegistration()
        {
            Console.WriteLine("Medical Registration: Please enter your full name");
            string fullName = Console.ReadLine();
            Console.WriteLine("Please enter your Bgroup");
            string Bgroup = Console.ReadLine();
            Console.WriteLine("Please enter your Genotype");
            string Genotype = Console.ReadLine();
            Random MedId = new Random();
            int MedCodegen = MedId.Next(300, 10000);
            string Id = fullName + "-" + MedCodegen;
            return "Welcome " + fullName + ", your Medical ID Number is " + MedId;
        }
            
                      
        public string BankRegistration()
        {
            Console.WriteLine(" Bank Registration: Please enter your full name");
            string fullName = Console.ReadLine();;
            Console.WriteLine("Please enter your BVN Number");
            int BVN = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your NIN Number");
            string NIN = Console.ReadLine();
            Random AccountNum = new Random();
            int MedCodegen = AccountNum.Next(300, 10000);
            string Id = fullName + "-" + MedCodegen;
            return "Welcome " + fullName + ", your Medical ID Number is " + AccountNum;
        }
    }

















}
