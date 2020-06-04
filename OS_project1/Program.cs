using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace OS_project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to My Task Manager (@____@)");
            Console.WriteLine("type command help to get a list of comands");
            int i = 1;
            
            while (i>0)
            {
                Console.Write(">>>>>>");
              string s= Console.ReadLine().ToLower();
                string []x = s.Split(' ');

                if (s == "help" || x[0] == "help")
                {
                    try
                    {
                        showcomands();
                    }
                    catch (Exception    )
                    {
                        Console.WriteLine("enter the command in this form : help ");
                       
                    }
                    
                }
                else if (s == "list" || x[0] == "list")
                {
                    try
                    {
                        listproccess();
                    }
                    catch (Exception q)
                    {

                        Console.WriteLine(q.Message.ToString());
                        Console.WriteLine("enter the command in this form : list processes ");
                    }
                    
                }
                else if (x[0] == "kill")
                {
                    try
                    {
                        killprocess(x[1]);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("enter the command in this form : kill id");
                    }
                }
               
                
                else if (x[0] == "chpriority")
                {
                    try
                    {
                        changepriority(x[1], x[2]);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("enter the command in this form : chpriority id priorityclass ");
                    }
                }
                else if (s == "exit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("invalid command please type help for commands syntx");
                }
            }
        }

        private static void changepriority(string s, string x)
        {
            try
            {
                Process p = Process.GetProcessById(Convert.ToInt32(s));
                if (x == "abovenormal")
                {
                    p.PriorityClass = ProcessPriorityClass.AboveNormal;
                    Console.WriteLine("process prioirty has changed successifully");
                }
                else if (x == "belownormal")
                {
                    p.PriorityClass = ProcessPriorityClass.BelowNormal;
                    Console.WriteLine("process prioirty has changed successifully");

                }
                else if (x == "high")
                {
                    p.PriorityClass = ProcessPriorityClass.High;
                    Console.WriteLine("process prioirty has changed successifully");

                }
                else if (x == "idle")
                {
                    p.PriorityClass = ProcessPriorityClass.Idle;
                    Console.WriteLine("process prioirty has changed successifully");

                }
                else if (x == "normal")
                {
                    p.PriorityClass = ProcessPriorityClass.Normal;
                    Console.WriteLine("process prioirty has changed successifully");

                }
                else if (x == "realtime")
                {
                    p.PriorityClass = ProcessPriorityClass.RealTime;
                    Console.WriteLine("process prioirty has changed successifully");
                }
                else
                    Console.WriteLine("enter a valid priority class");
            }catch(Exception dd)
            {
                Console.WriteLine(dd.Message.ToString());
            }
        }

        private static void killprocess(string x)
        {
            try
            {
                Process p = Process.GetProcessById(Convert.ToInt32(x));
                p.Kill();
                Console.WriteLine("process has been killed successfully");
            }
            catch(Exception s)
            {
                Console.WriteLine(s.Message.ToString());
            }
        }

        private static void listproccess()
        {
            DateTime lastTime;
            TimeSpan lastTotalProcessorTime;
            DateTime curTime;
            TimeSpan curTotalProcessorTime;
            Process[] processes = Process.GetProcesses();
            DateTime[] lsttime = new DateTime[processes.Length];
            TimeSpan[] lsttotal = new TimeSpan[processes.Length];
            string[] d = new string[processes.Length];
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("|   processName                          | processID|      Cpu Usage       |");
            for (int j = 0; j < d.Length; j++)
            {
                try
                {
                    lastTime = DateTime.Now;
                    lastTotalProcessorTime = processes[j].TotalProcessorTime;
                    lsttime[j] = lastTime;
                    lsttotal[j] = lastTotalProcessorTime;

                }
                catch (Exception)
                {

                    continue;
                }
            }
            Thread.Sleep(500);
           
            for (int b = 0; b < d.Length; b++)
            {
                try
                {
                    curTime = DateTime.Now;
                    curTotalProcessorTime = processes[b].TotalProcessorTime;
                    double CPUUsage = ((curTotalProcessorTime.TotalMilliseconds - lsttotal[b].TotalMilliseconds) / curTime.Subtract(lsttime[b]).TotalMilliseconds / Convert.ToDouble(Environment.ProcessorCount))*100;
                    d[b] = CPUUsage.ToString();
                }
                catch (Exception )
                {
                    d[b] = "Acess is denied";

                }
            }
            int maxnum = 0;
            int maxnum1 = 0;
            int maxnum2 = 0;
            for (int a = 0; a < processes.Length ; a++)
            {
                if (processes[a].ProcessName.Length >= maxnum)
                {
                    maxnum = processes[a].ProcessName.Length;
                }
                if (processes[a].Id.ToString().Length >= maxnum1)
                {
                    maxnum1 = processes[a].Id.ToString().Length;
                }
                if (d[a].Length >= maxnum2)
                {
                    maxnum2 = d[a].Length;
                }
            }
            for (int i = 0; i < processes.Length; i++)
            {
                Console.WriteLine("----------------------------------------------------------------------------");
                if (d[i] == "Acess is denied")
                { Console.ForegroundColor = ConsoleColor.Red; }
                else if (Convert.ToDouble( d[i]) > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
            
                string z = processes[i].ProcessName.ToString();
                string zz = processes[i].Id.ToString();
                if (d[i].Length < maxnum2)
                {
                    if (d[i][0] == 'A')
                    {
                        d[i] += " ";
                    }
                   
                    else
                        d[i] += "%";
                    for (int f = 0; f < maxnum2-1 - d[i].Length; f++)
                    {
                        d[i] += " ";
                    }

                }
                if (processes[i].Id.ToString().Length < maxnum1)
                {

                    for (int f = 0; f < maxnum1 - processes[i].Id.ToString().Length; f++)
                    {
                        zz += " ";
                    }

                }
                if (processes[i].ProcessName.Length < maxnum)
                {
                    
                    for (int f = 0; f < maxnum - processes[i].ProcessName.Length; f++)
                    {
                        z += " ";
                    }
                    
                }
                    Console.Write("|  " + z + "|  " + zz + "   |" + d[i]);

                if (d[i][0] == 'A')
                {
                    Console.WriteLine("      |");
                    
                }
                else if (d[i][1] == '.')
                {
                    Console.WriteLine("     |");
                }
                else
                {
                    Console.WriteLine("             |");
                    
                }
               

                Console.ResetColor();

            }
            Console.ResetColor();
            Console.WriteLine("----------------------------------------------------------------------------");

        }

        private static void showcomands()
        {
            Console.WriteLine(" command list to list all current proccess in the operating system ");
            Console.WriteLine(" command kill to kill the required proccess from it's id");
            Console.WriteLine(" command chpriority to change the priority of the required process from it's id by providing the desired priority");
            Console.WriteLine(" command exit to close the terminal ");
        }
    }
}
