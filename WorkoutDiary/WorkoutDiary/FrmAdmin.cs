using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkoutDiary
{
    public partial class FrmAdmin : Form
    {
        private int userId;

        public FrmAdmin(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
