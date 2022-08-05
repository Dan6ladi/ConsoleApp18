namespace ConsoleApp18
{
    internal interface IStudyVisaAdmissionRules
    {
        public int transcript { get; set; }

        public double Discipline(double grade, double studyGap);

        public bool PassPort(string PassPortType);

    }
    internal class Canada : IStudyVisaAdmissionRules
    {
        public int transcript { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        static void Main(string[] args)
        {
            Canada canada = new Canada();
            Console.WriteLine("welcome to the canadian Embassy. ibrahim");
            string name = Console.ReadLine();
            Console.WriteLine("Congratulations you just got Admitted!");
        }

        public bool PassPort(string PassPortType)
        {
            return true;
        }

        public double Discipline(double grade, double studyGap)
        {
            double Discipline = grade * studyGap;
            return Discipline;

        }
    }
}