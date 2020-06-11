using CefSharp;
using CefSharp.Enums;
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
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0112) // WM_SYSCOMMAND
            {
                // Check your window state here
                if (m.WParam == new IntPtr(0xF030)) // Maximize event - SC_MAXIMIZE from Winuser.h
                {
                    this.FormBorderStyle = FormBorderStyle.None;
                }
                if (m.WParam == new IntPtr(0xF120)) // Restore event - SC_RESTORE from Winuser.h
                {
                    this.FormBorderStyle = FormBorderStyle.FixedSingle;
                }

                
            }
            base.WndProc(ref m);
        }
        public ChromiumWebBrowser browser;
        public Screen()
        {
            InitializeComponent();
            
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

        private void Screen_Load(object sender, EventArgs e)
        {
            
        }

        private void Screen_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
