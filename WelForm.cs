using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRIMS
{
    public partial class WelForm : Form
    {
        public WelForm()
        {
            InitializeComponent();
            FormsData fd = new FormsData();
            labelWel.Text=fd.getWords();
            this.Refresh();
        }
    }
}
