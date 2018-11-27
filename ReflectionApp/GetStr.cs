using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReflectionApp
{
    public partial class GetStr : Form
    {
        public string NameL { get; set; }
        public GetStr(string name)
        {
            InitializeComponent();
            NameL = name;
        }
        public string Value { get; private set; }
        private void OkBtn_Click(object sender, EventArgs e)
        {
            Value = input.Text;
        }

        private void GetStr_Load(object sender, EventArgs e)
        {
            NameLabel.Text = NameL;
        }
    }
}
