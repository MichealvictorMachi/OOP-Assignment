using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment
{
        //Derived Interface method
    internal interface ICamprules : INyscRules
    {
        public string CampRegistration(string firstName, string lastName, int age);
        public string BankRegistration(int BVN, string name, int NIN);
        public string MedicalRegistration(string bGroup, string genotype, int age, string name);
        public bool MedicalAilmentCheck(string allegies, string medications);
    }
    
 
    
        
    
}
