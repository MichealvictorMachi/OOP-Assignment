using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment
{
    internal abstract class RegReq
    {
        string fullName;
        int age;
        string medResult;
        string bankDetails;
        string schId;

        public void nyscRegCriteria()
        {

        }
    }
         //inheritance
    class CampReq : RegReq
    {
        public string firstName;
        public string lastName;
    }
    class Bankreg : RegReq
    {
                //polymorphism
        public string Bankreq(int BVN, string NIN)
        {
            return "Account Num";
        }
        public string Bankreq(string studentId, string BVN)
        {
            return "Account Num";
        }
        public string Bankreq(string BVN)
        {
            return "Account Num";
        }

    }
    class MedicalReg : RegReq
    {
        
    }
}
