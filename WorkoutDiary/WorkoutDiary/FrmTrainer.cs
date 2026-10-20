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
    public partial class FrmTrainer : Form
    {
        private int userId;

        public FrmTrainer(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void FrmTrainer_Load(object sender, EventArgs e)
        {

        }
    }
}
