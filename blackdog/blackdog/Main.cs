using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using System;
using System.Windows.Forms;

namespace blackdog
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void commit_Click(object sender, EventArgs e)
        {
            try
            {
                this.result.AppendText("=====================欢迎使用黑狗自动化娱乐软件！=====================\r\n");
                ScriptEngine engine = Python.CreateEngine();
                ScriptScope scope = engine.CreateScope();

                ScriptSource script = engine.CreateScriptSourceFromFile(@"F:\VisualStudio2015\Projects\blackdog\blackdog\Script.py");

                var dates = script.Execute(scope);
                this.result.AppendText("program is over!!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void usernames_TextChanged(object sender, EventArgs e)
        {

        }

        private void logs_TextChanged(object sender, EventArgs e)
        {

        }

        private void moods_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
