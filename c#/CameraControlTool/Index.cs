using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CameraControlTool
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            FormCameraControlTool f2 = new FormCameraControlTool(); //this is the change, code for redirect  
            f2.ShowDialog();
            
        }

        private void buttonIdentifier_Click(object sender, EventArgs e)
        {
            Identifier f3 = new Identifier(); //this is the change, code for redirect  
            f3.ShowDialog();
        }
    }
}
