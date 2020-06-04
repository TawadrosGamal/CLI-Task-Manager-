using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operating_System_Project_1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        private void loadProcess()
        {
            ls1.Items.Clear();
            DateTime lastTime;
            TimeSpan lastTotalProcessorTime;


            DateTime curTime;
            TimeSpan curTotalProcessorTime;
          
            Process[] processes = Process.GetProcesses();
            DateTime[] lsttime = new DateTime[processes.Length];
            TimeSpan[] lsttotal = new TimeSpan[processes.Length];
            string[] d = new string[processes.Length];
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


                for (int b = 0; b < d.Length; b++) {
                    try
                    {
                        curTime = DateTime.Now;
                        curTotalProcessorTime = processes[b].TotalProcessorTime;
                        double CPUUsage = (curTotalProcessorTime.TotalMilliseconds - lsttotal[b].TotalMilliseconds) / curTime.Subtract(lsttime[b]).TotalMilliseconds / Convert.ToDouble(Environment.ProcessorCount);
                        d[b] = CPUUsage.ToString()+"%";
                    }
                    catch (Exception s)
                    {
                        d[b] = s.Message.ToString();
                    }
                }

            
            for (int i = 0; i < processes.Length; i++)
            {
                
                ListViewItem item = new ListViewItem(processes[i].ProcessName);
                
                item.SubItems.Add(processes[i].Id.ToString());
                item.SubItems.Add(d[i]);

                item.Tag = processes[i];
                ls1.Items.Add(item);
                
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            loadProcess();
        }

        private void St_btn_Click(object sender, EventArgs e)
        { try
            {
                if (txt1.Text[txt1.Text.Length-1] == 'e' && txt1.Text[txt1.Text.Length - 2] == 'x' && txt1.Text[txt1.Text.Length - 3] == 'e' &&
                    txt1.Text[txt1.Text.Length - 4] == '.')
                {
                    Process pp = new Process();
                    pp.StartInfo.FileName = txt1.Text;
                    pp.Start();
                    loadProcess();
                }
                else
                {
                    Process p = new Process();
                    string path = txt1.Text + ".exe";
                    p.StartInfo.FileName = path;
                    p.Start();
                    loadProcess();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message + " please enter the process name ");
            }
            }

        private void Ed_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt1.Text.Length > 0)
                {
                    Process[] processes2 = Process.GetProcesses();
                    for (int i = 0; i < processes2.Length; i++)
                    {
                        if (processes2[i].ProcessName == txt1.Text)
                        {
                            processes2[i].Kill();
                            loadProcess();
                        }
                    }
                }
                else
                {
                    ListViewItem item = ls1.SelectedItems[0];
                    Process p2 = (Process)item.Tag;
                    p2.Kill();
                    loadProcess();
                }
                }
            
            catch(Exception z)
            {
                MessageBox.Show(z.Message);
            }


            
            }

        private void Rd1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                
                
                    ListViewItem item = ls1.SelectedItems[0];
                    Process p2 = (Process)item.Tag;
                    p2.PriorityClass = ProcessPriorityClass.Idle;
                    loadProcess();
                MessageBox.Show("the process's priority has changed successfully");
                
            }

            catch (Exception z1)
            {
                MessageBox.Show(z1.Message);
            }


        }

        private void Rd2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
              
                
                    ListViewItem item = ls1.SelectedItems[0];
                    Process p2 = (Process)item.Tag;
                    p2.PriorityClass = ProcessPriorityClass.Normal;
                    loadProcess();
                MessageBox.Show("the process's priority has changed successfully");
            }

            catch (Exception z2)
            {
                MessageBox.Show(z2.Message);
            }

        }

        private void Rd3_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                
                    ListViewItem item = ls1.SelectedItems[0];
                    Process p2 = (Process)item.Tag;
                    p2.PriorityClass = ProcessPriorityClass.High;
                    loadProcess();
                MessageBox.Show("the process's priority has changed successfully");
            }

            catch (Exception z3)
            {
                MessageBox.Show(z3.Message);
            }

        }

        private void Rd4_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                
                    ListViewItem item = ls1.SelectedItems[0];
                    Process p2 = (Process)item.Tag;
                    p2.PriorityClass = ProcessPriorityClass.RealTime;
                    loadProcess();
                MessageBox.Show("the process's priority has changed successfully");
            }

            catch (Exception z4)
            {
                MessageBox.Show(z4.Message);
            }

        }
    }
}
