using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dotNETSpy.Controls;

namespace dotNETSpy
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            MainMenuStrip.Renderer = new AppToolStripRenderer();
        }
    }
}
