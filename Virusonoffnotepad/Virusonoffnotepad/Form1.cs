using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace Virusonoffnotepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnScan_Click(object sender, EventArgs e)
        {

        }

        private void btnKillVirus_Click(object sender, EventArgs e)
        {
        
                
                //tạo mới ₫ối tượng quản lý Process.
             Process myProcess = new Process();
            try
            {
                //thiết lập ₫ường dẫn file cần chạy
                myProcess.StartInfo.FileName = "C:\\Windows\\notepad.exe";
                //kích hoạt process
                for (int i = 0; i <= 100; i++)
                {
                    myProcess.Start();
                    Thread.Sleep(500);
                    Process[] plist = Process.GetProcesses();
                    //hiển thị tên, ID của từng process
                    foreach (Process process in plist)
                    {

                        if (process.ProcessName.Contains("Notepad"))
                        {
                            Process proc = Process.GetProcessById(process.Id);
                            //xóa process
                            proc.Kill();

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        
        
    }
}
