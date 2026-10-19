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
    public partial class FrmAthlete : Form
    {
        public FrmAthlete()
        {
            InitializeComponent();
        }
        private int userId;

        private void LoadRecentWorkouts()
        {
            var adapter =
                new WorkoutDiaryDBDataSetTableAdapters.WorkoutsTableAdapter();

            dgvRecentWorkouts.DataSource =
                adapter.GetRecentWorkouts(userId);
        }

        public FrmAthlete(int id)
        {
            InitializeComponent();
            userId = id;
            LoadRecentWorkouts();   
            LoadWorkoutCount();
            LoadLastWorkout();
            LoadExerciseCount();
        }

        private void LoadExerciseCount()
        {
            var adapter =
                new WorkoutDiaryDBDataSetTableAdapters.SetsTableAdapter();

            lblExerciseCount.Text =
                adapter.GetExerciseCount(userId).ToString();
        }

        private void LoadLastWorkout()
        {
            var adapter =
                new WorkoutDiaryDBDataSetTableAdapters.WorkoutsTableAdapter();

            object result = adapter.GetLastWorkoutDate(userId);

            if (result == null || result == DBNull.Value)
                lblLastWorkout.Text = "Пока нет данных";
            else
                lblLastWorkout.Text =
                    Convert.ToDateTime(result).ToString("dd.MM.yyyy");
        }

        private void LoadWorkoutCount()
        {
            var adapter =
                new WorkoutDiaryDBDataSetTableAdapters.WorkoutsTableAdapter();

            lblWorkoutCount.Text =
                adapter.GetWorkoutCount(userId).ToString();
        }

        private void FrmAthlete_Load(object sender, EventArgs e)
        {

        }
    }
}
