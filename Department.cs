using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringmethods
{
    public class Department
    {
        public string Name { get; set; }
        public Worker[] workers=new Worker[0];
        
        public void AddWorker(Worker worker)
        {
            Array.Resize(ref workers, workers.Length+1);
            workers[workers.Length-1] = worker;
        }
        public Worker[] SearchWorker(string name)
        {
            Worker[] wantedworker = new Worker[0];
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].Name.ToUpper()==name.ToUpper())
                {
                    Array.Resize(ref wantedworker, wantedworker.Length + 1);
                    wantedworker[wantedworker.Length - 1] = workers[i];
                }
            }
            return wantedworker;
        }
        public void ShowAllWorkers()
        {
            foreach (Worker worker in workers)
            {
                Console.WriteLine($"{worker.Name} ");
            }
        }
    }
}
