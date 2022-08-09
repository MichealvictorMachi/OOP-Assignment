namespace OOP_Assignment
{
    internal class NyscCampers
    {
        static void Main(string[] args)
        {
            var registration = new RegProceedures();
            registration.NewCampRegistration();
            registration.MedicalRegistration();
            registration.BankRegistration();

            Bankreg bankreg = new Bankreg();
            Bankreg.ReferenceEquals(registration, bankreg);

            MedicalReg medreg = new MedicalReg();
            medreg.nyscRegCriteria();

            
            
            Console.WriteLine("Welcome To Your Service Year");
        }
    }
}