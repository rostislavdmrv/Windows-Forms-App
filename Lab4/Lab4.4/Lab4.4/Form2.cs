using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4._4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            label1.Text = webBrowser1.DocumentTitle;
            textBox1.Text = webBrowser1.Url.ToString();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            webBrowser1.GoBack();
            webBrowser1.GoForward();
            webBrowser1.Refresh();
            webBrowser1.GoHome();
            webBrowser1.Stop();

        }
    }
}
