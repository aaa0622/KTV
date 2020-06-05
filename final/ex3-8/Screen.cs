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
        public Screen()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
        }

        private void Screen_Load(object sender, EventArgs e)
        {
           
            string html = null;
            using (var s = Assembly.GetExecutingAssembly()
                .GetManifestResourceStream("ex3_8.assets.youtube-player.html"))
            using (var r = new StreamReader(s))
                html = r.ReadToEnd();

            var embed = @"
<html>
<head>
<meta http-equiv='X-UA-Compatible' content='IE=Edge'/>
</head>
<body style='height: 100vh; margin: 0px; overflow:hidden'>
<iframe style='width: 100%; height: 100%; margin: 0px' src='https://k8188219.github.io/CS151webPractice/' frameborder='0' allow='autoplay; encrypted-media' allowfullscreen></iframe>
</body>
</html>
";
            // this.webBrowser1.DocumentText = html;
            //webBrowser1.DocumentText = html;
            //Console.WriteLine(html);
        }
    }
}
