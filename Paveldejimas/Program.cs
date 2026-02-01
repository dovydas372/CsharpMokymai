namespace Paveldejimas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Human human = new Human("Jonas", "Jonaitis", 2001);
            //Human human = new Human();
            human.Name = "Jonas";
            human.LastName = "Jonaitis";
            human.BirthYear = 2001;
            //Console.WriteLine(human.GetAge());

            Employee employee = new Employee("Mantas", "Mantaitis", 1997, 2000);
            //employee.Name = "Mantas";
            //employee.BirthYear = 1997;
            //employee.Salary = 2000;
            Console.WriteLine(employee.GetAge());

            //Customer customer = new Customer();
            //customer.BirthYear = 1992;
            //customer.OrderCount = 15;
            //customer.Name = "Karolis";
            // Polimorfizmas, jeigu kazkur dalyvauja tevas, gali automatiskai dalyvauti ir jo vaikas, nes jis yra tas pats plius extra
            // reiskias, jis tures viska ka turi tevas, del to problemu naudoti ji vietoje tevo nekils
            //PrintDetails(human);
            //PrintDetails(employee);

            //human.PrintDetails();
            //employee.PrintDetails();
            //customer.PrintDetails();
            //PrintDetails(employee);
            //PrintDetails(customer);

        }
        static void PrintDetails(Human human)
        {
            //Console.WriteLine(human.GetAge());
            human.PrintDetails();


        }
    }
}
