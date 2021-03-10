using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadExam19
{
    class Program
    {
        public static object key = new object();
        public static void DoctorTreatment()
        {
            lock (key)
            {
                Monitor.Enter(key);
                Console.WriteLine("Waiting for my turn...");
                Monitor.Wait(key);
                Console.WriteLine("Getting treated ");
                Monitor.Exit(key);
            }
        }

        public static void NurseCheck()
        {
            lock (key)
            {
                Monitor.Enter(key);
                Console.WriteLine("Nurse is checking...");
                Thread.Sleep(5000);
                Monitor.Pulse(key);
                Console.WriteLine("Next patient please! ");
                Monitor.Exit(key);
            }
        }
        static void Main(string[] args)
        {
            new Thread(() => { DoctorTreatment(); }).Start();


            Thread.Sleep(100);
            new Thread(() => { NurseCheck(); }).Start();
           

            
        }
    }
}
