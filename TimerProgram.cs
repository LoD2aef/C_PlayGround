using System;
using System.Threading;
using System.Threading.Tasks;

namespace WinFormServer {
    class TimerProgram {
        private Timer SysThrTimer;
        private int count = 0;

        public void SetUpTimer(TimeSpan alertTime) {
            // Try 1 Call methode each 5 sec
            //DateTime currTime = DateTime.Now;
            //TimeSpan timeToGo = alertTime - currTime.TimeOfDay;
            //if (timeToGo < TimeSpan.Zero) {
            //    Console.WriteLine("time already passed");
            //    return;
            //}
            //SysThrTimer = new Timer(x => {
            //    TempMethode();
            //}, null, timeToGo, TimeSpan.FromSeconds(5));
            // Try 2 Call only one time the method
            //Task WaitTask = Task.Delay(alertTime - DateTime.Now.TimeOfDay);
            //WaitTask.ContinueWith(x => TempMethode());
            //WaitTask.Start();
            // Try 3 does the same as Try 1 but less lines
            //if (alertTime < DateTime.Now.TimeOfDay) { Console.WriteLine("EER"); return; } 
            //SysThrTimer = new Timer(TempMethode, null, (alertTime - DateTime.Now.TimeOfDay), TimeSpan.FromSeconds(5));
            // Try 4 same as Try 3 but using lamda to call method
            //if (alertTime < DateTime.Now.TimeOfDay) { Console.WriteLine("EER"); return; }
            //SysThrTimer = new Timer(x => { TempMethode(); }, null, (alertTime - DateTime.Now.TimeOfDay), TimeSpan.FromSeconds(5));
            // Try 5
            SysThrTimer = new Timer(new TimerCallback(TimeMethode), null, 1000, 1000);
        }
        public void StopTimerMethod() {
            SysThrTimer.Change(Timeout.Infinite, Timeout.Infinite);
        }

        private void TempMethode(object state) { // method for Try 3
            count++;
            Console.WriteLine($"Timers Excuted {count}. It's {DateTime.Now.ToLongTimeString()}");
        }

        private void TempMethode() {
            count++;
            Console.WriteLine($"Timers Excuted {count}. It's {DateTime.Now.ToLongTimeString()}");
        }
        private void TimeMethode(object state) { // method for Try 3 and 5
            count++;
            Console.WriteLine($"Timers Excuted {count}. It's {DateTime.Now.ToLongTimeString()}");
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId.ToString());
            Thread.Sleep(500);
        }
        public void PlayWithTimeFormAndStuff() {
            TimeSpan tiks = new TimeSpan(110000000);
            TimeSpan ts = new TimeSpan(2, 11, 22, 33);
            DateTime dt = new DateTime(2020, 10, 20);
            DateTime newDate = dt.Add(ts);
            DateTime newDateTiks = newDate.Add(tiks);
            TimeSpan CurrTime = DateTime.Now.TimeOfDay;
            Console.WriteLine("Tiks :" + tiks + " Ts :" + ts + " Dt :" + dt + " Nd :" + newDate + " Ndt :" + newDateTiks);
        }
    }
}
