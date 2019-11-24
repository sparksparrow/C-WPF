using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_2._0_WF_Zaur
{
    
    public partial class Task11 : Form
    {       
        List<string> History = new List<string>();
        public Task11()
        {
            InitializeComponent();
            MinimumSize = new Size(1100, 670);
            webBrowser.ScriptErrorsSuppressed = true;
            webBrowser.Url = new Uri("https://www.google.com/");
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void WebBrowser_UrlLoaded(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (e.Url.ToString().Contains("spf")||e.Url.ToString() == "about:blank")
                return;
            History.Add(e.Url.Scheme.ToString() + "://" + e.Url.Authority.ToString() + e.Url.AbsolutePath.ToString() + e.Url.Query.ToString() + "\r\n");  //e.Url.ToString();
        }
            

        private void Work_Click(object sender, EventArgs e)
        {
            BrowserHistory history = new BrowserHistory(History);
            history.ShowDialog();            
        }

        private void Back_Click(object sender, EventArgs e)
        {
            if (webBrowser.CanGoBack)
                webBrowser.GoBack();
            else
                MessageBox.Show("Невозможно!");
        }

        private void Forward_Click(object sender, EventArgs e)
        {
            if (webBrowser.CanGoForward)
                webBrowser.GoForward();
            else
                MessageBox.Show("Невозможно!");
        }

        private void Js_Click(object sender, EventArgs e)
        {
            if (webBrowser.DocumentText.Contains("<script"))
                MessageBox.Show("java-script найден!");
            else
                MessageBox.Show("java-script не найден!");
        }
    }
}
