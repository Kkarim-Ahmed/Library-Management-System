using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Managment__System
{
    public partial class Sign_up : Form
    {
        public static double Mem()
        {
            using (Process currentprocess = Process.GetCurrentProcess())
            {
                long memoryBits = currentprocess.WorkingSet64;
                return Math.Round(memoryBits / (1024.0), 2);
            }
            ;
        }

        public Sign_up()
        {
            InitializeComponent();
        }

        private void ADD_NMember_Click(object sender, EventArgs e)
        {
            NewMember nMember = new NewMember(NMember_name.Text, NMemebr_phone.Text, NMember_depart.Text);
            nMember.Sign(nMember.Name, nMember.PhoneNumber, nMember.depart);
            MessageBox.Show("Done");
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label4.Text = $"Memory usage : {Mem().ToString()}";
        }
    }
}
