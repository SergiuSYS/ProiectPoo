using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPoo.UI
{
    public partial class Form2 : Form
    {
        private User Mainuser;
        public Form2(User mainuser)
        {
            InitializeComponent();
            Mainuser = mainuser;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            if (mainuser.IsAdmin == false)
            {
                button2.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void makeComanda1_Load(object sender, EventArgs e)
        {

        }
    }
}
