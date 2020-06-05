using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex3_8
{
    public partial class Screen : Form
    {
        public ChromiumWebBrowser browser;
        public Screen()
        {
            InitializeComponent();

            CefSharpSettings.LegacyJavascriptBindingEnabled = true;
            Cef.Initialize(new CefSettings());
            browser = new ChromiumWebBrowser("about:blank");
            browser.Dock = DockStyle.Fill;
            string html = null;
            string file = "ex3_8.assets.youtube-player.html";
            using (var s = Assembly.GetExecutingAssembly().GetManifestResourceStream(file))
            using (var r = new StreamReader(s))
                html = r.ReadToEnd();
            browser.LoadHtml(html);
            Controls.Add(browser);

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
        }

        private void Screen_Load(object sender, EventArgs e)
        {
            
            //webBrowser1.DocumentText = html;
            //Console.WriteLine(html);
        }
    }
}
