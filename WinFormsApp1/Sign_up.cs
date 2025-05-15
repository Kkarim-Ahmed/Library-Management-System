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
using UserNamespace;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


   

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

        private void InitializeComboBox()
        {
            // Set ComboBox data source to the list of books (or members)
            NMember_depart.DataSource = OldMember.DepartList;


            // Enable AutoComplete for ComboBox
            NMember_depart.AutoCompleteMode = AutoCompleteMode.SuggestAppend;  // Suggest matching items as the user types
            NMember_depart.AutoCompleteSource = AutoCompleteSource.ListItems; // Use the list items as suggestions
        }

        public Sign_up()
        {

            InitializeComponent();
            InitializeComboBox();


        }

        private void ADD_NMember_Click(object sender, EventArgs e)
        {
            OldMember nMember = new OldMember(NMember_name.Text, NMemebr_phone.Text, NMember_depart.Text);
            OldMember.Add_Users_csv(nMember);
            MessageBox.Show("Done");
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label4.Text = $"Memory usage : {Mem().ToString()}";
        }

        private void NMember_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void NMemebr_phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void b_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NMemebr_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)&& !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
