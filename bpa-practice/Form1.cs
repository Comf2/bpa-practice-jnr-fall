using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace bpa_practice
{
    public partial class Form1 : Form
    {
        //TODO: Refactor old scripts to be best for study
        private readonly ArrayManiplulation am = new ArrayManiplulation();
        private readonly GetRelPath grp = new GetRelPath();
        private readonly ListManiplulation lm = new ListManiplulation();
        public Form1()
        {
            InitializeComponent();
            
        }


       

       
        private void button1_Click(object sender, EventArgs e)
        {
           
            grp.LogAllTextFiles();
        }

        private void ArrayManiplulation_Click(object sender, EventArgs e)
        {
            am.accessArrays();
        }

        private void ListManiplulation_Click(object sender, EventArgs e)
        {
            lm.maniplulateList();
        }
    }
}
