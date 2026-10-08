namespace Lab_6_OOP_Generic_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Skapar medarbetare
            Employe employe1 = new Employe("Johan", 104, "Male", 32000);

            Employe employe2 = new Employe("Sara", 103, "Kvinna", 35000);

            Employe employe3 = new Employe("Ali", 102, "Male", 29000);

            Employe employe4 = new Employe("Emma", 101, "Kvinna", 38000);

            Employe employe5 = new Employe("Erik", 100, "Male", 31000);

            // Skapar stack 
            Stack<Employe> employesStack = new Stack<Employe>();
            employesStack.Push(employe1);
            employesStack.Push(employe2);
            employesStack.Push(employe3);
            employesStack.Push(employe4);
            employesStack.Push(employe5);
            
            //går igenom stacken + skriver ut varje medarbetare
            foreach (Employe employe in employesStack)
            {
                // 
                Console.WriteLine($"Items left in the Stack = {employesStack.Count} ");
                Console.WriteLine($"{employe.Id} - {employe.Name} - {employe.Gender} - {employe.Salary}");
            }

            Console.WriteLine("-----------------------------");



            
            // pop tar bort medarbetare från employestack och sparar de i removedemploye + fortsätter så länge stacken inte är tom.
            
            while (employesStack.Count > 0)
            {
                Employe removedEmploye = employesStack.Pop();
                Console.WriteLine("Retrive Using Pop Method");
                Console.WriteLine($"{removedEmploye.Id} - {removedEmploye.Name} - {removedEmploye.Gender} - {removedEmploye.Salary}");
                Console.WriteLine($"Items left in the stack = {employesStack.Count} ");

                
            }


            Console.WriteLine("-----------------------------");

            //Stacken är tom efter pop, så lägger tollbaka de
            Console.WriteLine("Retrive Using Peek Method");

            employesStack.Push(employe1);
            employesStack.Push(employe2);
            employesStack.Push(employe3);
            employesStack.Push(employe4);
            employesStack.Push(employe5);

            //peek körs 2 gng och visar översta personen utan att ta bort den. Det är därför Erik visas 2 gng
            for (int i = 0; i < 2; i++)
            {
                Employe topEmploye = employesStack.Peek();

                Console.WriteLine($"{topEmploye.Id} - {topEmploye.Name} - {topEmploye.Gender} - {topEmploye.Salary}");
                Console.WriteLine($"Items left in the stack = {employesStack.Count} ");
            }


            Console.WriteLine("-----------------------------");
            
            //Kollar om emp3 finns i stacken alltså Ali

            if (employesStack.Contains(employe3))
            {
                Console.WriteLine($"{employe3.Id} - {employe3.Name}, is in the stack");
            }
            else
            {
                Console.WriteLine($"{employe3.Id} - {employe3.Name} is not in the Stack!");
            }

            Console.WriteLine("-----------------------------");
            Console.WriteLine("-----------------------------");

            //skapar en lista med samma 5 medarbetare
            List<Employe> employeList = new List<Employe>();
            employeList.Add(employe1);
            employeList.Add(employe2);
            employeList.Add(employe3);
            employeList.Add(employe4);
            employeList.Add(employe5);

            //kollar om emp2 finns i listan, alltså Sara 
            if (employeList.Contains(employe2))
            {
                Console.WriteLine("Employe2 object exists in the list");

            }
            else
            {
                Console.WriteLine("Employe2 object does not exists in the list");
            }

            Console.WriteLine();

            //find hittar den första personen i listan med manligt kön. det blir Johan pga först i listan.
            Employe? foundEmploye = employeList.Find(employe => employe.Gender == "Male");

            //skriver ut pers om find hittar någon
            if (foundEmploye != null)
            {
                Console.WriteLine($"ID = {foundEmploye.Id}, Name = {foundEmploye.Name}, Gender = {foundEmploye.Gender}, Salary = {foundEmploye.Salary}");
            }

            Console.WriteLine();
            
            // findall skapar en lista med alla som har manligt kön 
            List<Employe> genderEmploye = employeList.FindAll(employe => employe.Gender == "Male");
            
            //skriver ut pers med manligt kön i den nya listan.
            foreach (Employe employe in genderEmploye)
            {
                Console.WriteLine($"ID = {employe.Id}, Name = {employe.Name}, Gender = {employe.Gender}, Salary = {employe.Salary}");
            }

            
        }
    }
}
