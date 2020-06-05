using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex3_8
{
    public partial class ListView : Form
    {
        public ListView()
        {
            InitializeComponent();
            new AllSong(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    public class AllSong
    {
        private ListView ListView1;
        public AllSong(ListView a)
        {
            ListView1 = a;
        }
        public void searchSong(string id, string name, string singer)
        {

        }
    }
    public class HitSong
    {
        private ListView ListView1;
        public HitSong(ListView a)
        {
            ListView1 = a;
        }
        public void searchSong(string id, string name, string singer)
        {

        }
    }
    public class NewSong
    {
        private ListView ListView1;
        public NewSong(ListView a)
        {
            ListView1 = a;
        }
        public void searchSong(string id, string name, string singer)
        {

        }
    }
}
