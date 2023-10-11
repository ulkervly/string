namespace stringmethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker();
            worker.Name = "Name";
            worker.Surname = "Test";
            worker.Experience = 1;

            Worker worker1 = new Worker();
            worker1.Name = "Ad";
            worker1.Surname = "Test1";
            worker1.Experience = 2;

            Department department = new Department();
            department.Name = "Muhasibatliq";

            department.AddWorker(worker1);


           department.ShowAllWorkers();
        
            Worker[] workers = department.SearchWorker("isci");
            foreach (Worker wantedbook in workers)
            {
                Console.WriteLine(wantedbook.Name);
            }

        }
    }
}