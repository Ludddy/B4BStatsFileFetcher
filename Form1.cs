using Microsoft.VisualBasic.Devices;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Windows.Forms.Design;
using System.IO;
using System.Text;

namespace B4BStatsFileFetcher
{
    public partial class B4BFileFetcherForm : Form
    {

        public B4BFileFetcherForm()
        {
            InitializeComponent();
        }

        private void B4BFileFetcherForm_Load(object sender, EventArgs e)
        {
            string sMachineName = System.Environment.MachineName.ToString();
            string sUserName = System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString();
            string subUserName = sUserName.Substring(sUserName.IndexOf("\\") + 1, sUserName.Length - (sUserName.IndexOf("\\") + 1 ) );
            textBox1.Text = @"\\" + sMachineName + @"\Users\" + subUserName + @"\AppData\Local\Back4Blood\Steam\Saved\SaveGames";
        }

    private void OpenFolder(string folderPath)
    {

            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                Arguments = @"" + textBox1.Text.ToString(),
                FileName = "explorer.exe",
                WorkingDirectory = @"" + textBox1.Text.ToString()
            };

            Process.Start(startInfo);
    }

private void button1_Click(object sender, EventArgs e)
        {
            string sfilePath = @"" + textBox1.Text;
            OpenFolder(sfilePath);
        }


    }
}