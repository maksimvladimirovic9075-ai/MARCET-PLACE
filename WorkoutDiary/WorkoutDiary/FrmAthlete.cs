using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkoutDiary.WorkoutDiaryDBDataSetTableAdapters;

namespace WorkoutDiary
{
    public partial class FrmAthlete : Form
    {

        
        private int userId;

    
        private readonly ExerciseProgressTableAdapter progressAdapter = new ExerciseProgressTableAdapter();
        private readonly UsersTableAdapter usersAdapter = new UsersTableAdapter();
        private readonly SetsTableAdapter setsAdapter = new SetsTableAdapter();

       

        private void LoadExerciseProgress()
        {
            dvgExerciseProgress.DataSource = progressAdapter.GetProgress(userId);
        }

        public FrmAthlete(int id)
        {
            InitializeComponent();
            userId = id;

            LoadPersonalInfo();
            LoadStatistics();
            LoadExerciseProgress();
            pageHome.BringToFront();


            userId = id;
            try
            {
                //LoadRecentWorkouts();
                //MessageBox.Show("История тренировок загружена");

                LoadWorkoutCount();
                LoadLastWorkout();
                LoadExerciseCount();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка загрузки");
                throw;
            }
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
            this.btnWorkouts.Click += new System.EventHandler(this.btnWorkouts_Click_1);
            LoadPersonalInfo();
            LoadStatistics();
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workoutDiaryDBDataSet1.ProgramExercisesView". При необходимости она может быть перемещена или удалена.
            this.programExercisesViewTableAdapter.Fill(this.workoutDiaryDBDataSet1.ProgramExercisesView);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workoutDiaryDBDataSet1.ProgramView". При необходимости она может быть перемещена или удалена.
            this.programViewTableAdapter.Fill(this.workoutDiaryDBDataSet1.ProgramView);

        }
        private void lblLastWorkout_Click(object sender, EventArgs e)
        {

        }
      
        private void btnExercises_Click(object sender, EventArgs e)
        {
            pageExercises.BringToFront();
        }
        private void btnPrograms_Click(object sender, EventArgs e)
        {
            pagePrograms.BringToFront();
          
        }
        private void btnResults_Click(object sender, EventArgs e)
        {
            pageResults.BringToFront();
            
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblFullNameTitle_Click(object sender, EventArgs e)
        {

        }

        private void LoadPersonalInfo()
        {
            var users = usersAdapter.GetUserInfo(userId);

            if (users == null || users.Count == 0)
                return;

            var user = users[0];
            lblFullNameTitle.Text = user.FullName;
            lblLoginTitle.Text = user.Login;
            lblRoleTitle.Text = user.Role;
            lblPasswordValue.Text = "защищён";

            lblFullNameTitle.Text = "ФИО: " + user.FullName;
            lblLoginTitle.Text = "Login: " + user.Login;
            lblRoleTitle.Text = "Роль: " + user.Role;
            lblPasswordValue.Text = "Пароль: защищён";
        }

        private void LoadStatistics()
        {
            lblTotalSetsValue.Text =
                Convert.ToInt32(setsAdapter.GetTotalSets(userId)).ToString();

            lblTotalVolumeValue.Text =
                Convert.ToDecimal(setsAdapter.GetTotalVolume(userId)).ToString("0.##");

            lblUniquercisesValue.Text =
                Convert.ToInt32(setsAdapter.GetExerciseCount(userId)).ToString();
        }


        
        private void btnWorkouts_Click_1(object sender, EventArgs e)
        {
            pageWorkouts.BringToFront();
        }
    }
}
