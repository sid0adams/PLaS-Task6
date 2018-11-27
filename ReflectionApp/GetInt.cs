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
    public partial class GetInt : Form
    {
        public string NameL { get; set; }
        public GetInt(string name)
        {
            InitializeComponent();
            NameL = name;
        }
        public int Value { get; private set; }
        private void OkBtn_Click(object sender, EventArgs e)
        {
            Value = (int)inp.Value;
        }

        private void GetInt_Load(object sender, EventArgs e)
        {
            NameInput.Text = NameL;
        }
    }
}
