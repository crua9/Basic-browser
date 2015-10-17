using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tech_Reviews_and_Help
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            webBrowser1.Navigate("https://www.youtube.com/user/TechRHelp");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //GoToSite
        private void GoToSite()
        {
            webBrowser1.Navigate(textBox1.Text);
            textBox1.Enabled = false;
            Go.Enabled = false;
        }
        // Go button
        private void Go_Click(object sender, EventArgs e)
        {
            GoToSite();
        }

        private void Forward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }
        //hacking
        private void Hacking_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/playlist?list=PLioOFeHwQV5wT-55UfUP2w14miGVeg15h");
        }

        private void Coding_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/playlist?list=PLioOFeHwQV5wqTf9S43CmwNml4UBXYqkT");
        }

        private void Windows_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/playlist?list=PLioOFeHwQV5yqxT4gO7nGrX04hW2lXoy4");
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            textBox1.Enabled = true;
            Go.Enabled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)ConsoleKey.Enter) 
            {
                Go_Click(null, null);
            }
        }

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            if (e.CurrentProgress > 0 && e.MaximumProgress > 0)
            {
                toolStripProgressBar1.ProgressBar.Value = (int)(e.CurrentProgress * 100 / e.MaximumProgress);
                textBox1.Text = webBrowser1.Url.ToString();
                toolStripStatusLabel3.Text = webBrowser1.Url.ToString();           
                     }
        }

        private void payPalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://techreviewsandhelp.com/l2u5");
        }

        private void patreonToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
            webBrowser1.Navigate("https://www.patreon.com/user?u=381858&ty=h");
        }

        private void youTubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/user/TechRHelp");
        }

        private void gitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://github.com/crua9/Basic-browser");
        }

        private void videoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://youtu.be/mBzFE8NlhUU");
        }
    }

}
