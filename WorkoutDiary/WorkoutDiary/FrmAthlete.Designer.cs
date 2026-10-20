namespace WorkoutDiary
{
    partial class FrmAthlete
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBrand = new Material3.WinForms.Controls.MaterialLabel();
            this.plnBrand = new Material3.WinForms.Controls.MaterialRoundedPanel();
            this.btnLogout = new Material3.WinForms.Controls.MaterialButton();
            this.btnResults = new Material3.WinForms.Controls.MaterialButton();
            this.btnExercises = new Material3.WinForms.Controls.MaterialButton();
            this.btnPrograms = new Material3.WinForms.Controls.MaterialButton();
            this.btnWorkouts = new Material3.WinForms.Controls.MaterialButton();
            this.workoutDiaryDBDataSet1 = new WorkoutDiary.WorkoutDiaryDBDataSet();
            this.exercisesTableAdapter1 = new WorkoutDiary.WorkoutDiaryDBDataSetTableAdapters.ExercisesTableAdapter();
            this.panelContent = new System.Windows.Forms.Panel();
            this.pagePrograms = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.materialCard1 = new Material3.WinForms.Controls.MaterialCard();
            this.lblPersonalInfo = new Material3.WinForms.Controls.MaterialLabel();
            this.lblProfileLogin = new Material3.WinForms.Controls.MaterialLabel();
            this.materialLabel6 = new Material3.WinForms.Controls.MaterialLabel();
            this.materialLabel7 = new Material3.WinForms.Controls.MaterialLabel();
            this.materialLabel8 = new Material3.WinForms.Controls.MaterialLabel();
            this.pageResults = new System.Windows.Forms.Panel();
            this.pageWorkouts = new System.Windows.Forms.Panel();
            this.pageHome = new System.Windows.Forms.Panel();
            this.materialLabel5 = new Material3.WinForms.Controls.MaterialLabel();
            this.MaterialCard = new Material3.WinForms.Controls.MaterialCard();
            this.lblLastWorkout = new Material3.WinForms.Controls.MaterialLabel();
            this.materialLabel2 = new Material3.WinForms.Controls.MaterialLabel();
            this.cardExerciseCount = new Material3.WinForms.Controls.MaterialCard();
            this.lblExerciseCount = new Material3.WinForms.Controls.MaterialLabel();
            this.lblExerciseTitle = new Material3.WinForms.Controls.MaterialLabel();
            this.cardWorkoutCount = new Material3.WinForms.Controls.MaterialCard();
            this.lblWorkoutCount = new Material3.WinForms.Controls.MaterialLabel();
            this.materialLabel1 = new Material3.WinForms.Controls.MaterialLabel();
            this.cardWelcome = new Material3.WinForms.Controls.MaterialCard();
            this.materialLabel3 = new Material3.WinForms.Controls.MaterialLabel();
            this.materialLabel4 = new Material3.WinForms.Controls.MaterialLabel();
            this.dgvRecentWorkouts = new System.Windows.Forms.DataGridView();
            this.cardRecentWorkouts = new Material3.WinForms.Controls.MaterialCard();
            this.pageExercises = new System.Windows.Forms.Panel();
            this.plnBrand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workoutDiaryDBDataSet1)).BeginInit();
            this.panelContent.SuspendLayout();
            this.pagePrograms.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.pageResults.SuspendLayout();
            this.pageWorkouts.SuspendLayout();
            this.pageHome.SuspendLayout();
            this.MaterialCard.SuspendLayout();
            this.cardExerciseCount.SuspendLayout();
            this.cardWorkoutCount.SuspendLayout();
            this.cardWelcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentWorkouts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBrand
            // 
            this.lblBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(35)))), ((int)(((byte)(83)))));
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBrand.Location = new System.Drawing.Point(7, 8);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(230, 77);
            this.lblBrand.TabIndex = 0;
            this.lblBrand.Text = "WORKOUT DIARY";
            this.lblBrand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // plnBrand
            // 
            this.plnBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(35)))), ((int)(((byte)(85)))));
            this.plnBrand.Controls.Add(this.btnLogout);
            this.plnBrand.Controls.Add(this.btnResults);
            this.plnBrand.Controls.Add(this.btnExercises);
            this.plnBrand.Controls.Add(this.btnPrograms);
            this.plnBrand.Controls.Add(this.btnWorkouts);
            this.plnBrand.Controls.Add(this.lblBrand);
            this.plnBrand.ForeColor = System.Drawing.Color.White;
            this.plnBrand.Location = new System.Drawing.Point(-3, 1);
            this.plnBrand.Name = "plnBrand";
            this.plnBrand.Size = new System.Drawing.Size(254, 716);
            this.plnBrand.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(70)))), ((int)(((byte)(165)))));
            this.btnLogout.CornerRadius = 12;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(196)))), ((int)(((byte)(214)))));
            this.btnLogout.Glyph = "info";
            this.btnLogout.Location = new System.Drawing.Point(11, 653);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(104, 45);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Выйти";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Variant = Material3.WinForms.Controls.MaterialButtonVariant.Outlined;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnResults
            // 
            this.btnResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(70)))), ((int)(((byte)(165)))));
            this.btnResults.CornerRadius = 12;
            this.btnResults.FlatAppearance.BorderSize = 0;
            this.btnResults.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnResults.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResults.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnResults.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(196)))), ((int)(((byte)(214)))));
            this.btnResults.Glyph = "check";
            this.btnResults.Location = new System.Drawing.Point(15, 290);
            this.btnResults.Name = "btnResults";
            this.btnResults.Size = new System.Drawing.Size(220, 45);
            this.btnResults.TabIndex = 4;
            this.btnResults.Text = "Мои результаты";
            this.btnResults.UseVisualStyleBackColor = false;
            this.btnResults.Variant = Material3.WinForms.Controls.MaterialButtonVariant.Outlined;
            this.btnResults.Click += new System.EventHandler(this.btnResults_Click);
            // 
            // btnExercises
            // 
            this.btnExercises.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(70)))), ((int)(((byte)(165)))));
            this.btnExercises.CornerRadius = 12;
            this.btnExercises.FlatAppearance.BorderSize = 0;
            this.btnExercises.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExercises.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExercises.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExercises.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExercises.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(196)))), ((int)(((byte)(214)))));
            this.btnExercises.Glyph = "check_circle";
            this.btnExercises.Location = new System.Drawing.Point(15, 170);
            this.btnExercises.Name = "btnExercises";
            this.btnExercises.Size = new System.Drawing.Size(220, 45);
            this.btnExercises.TabIndex = 3;
            this.btnExercises.Text = "Упражнения";
            this.btnExercises.UseVisualStyleBackColor = false;
            this.btnExercises.Variant = Material3.WinForms.Controls.MaterialButtonVariant.Outlined;
            this.btnExercises.Click += new System.EventHandler(this.btnExercises_Click);
            // 
            // btnPrograms
            // 
            this.btnPrograms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(70)))), ((int)(((byte)(165)))));
            this.btnPrograms.CornerRadius = 12;
            this.btnPrograms.FlatAppearance.BorderSize = 0;
            this.btnPrograms.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPrograms.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPrograms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrograms.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPrograms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(196)))), ((int)(((byte)(214)))));
            this.btnPrograms.Glyph = "play_arrow_filled";
            this.btnPrograms.Location = new System.Drawing.Point(15, 230);
            this.btnPrograms.Name = "btnPrograms";
            this.btnPrograms.Size = new System.Drawing.Size(220, 45);
            this.btnPrograms.TabIndex = 2;
            this.btnPrograms.Text = "Программы тренировок";
            this.btnPrograms.UseVisualStyleBackColor = false;
            this.btnPrograms.Variant = Material3.WinForms.Controls.MaterialButtonVariant.Outlined;
            this.btnPrograms.Click += new System.EventHandler(this.btnPrograms_Click);
            // 
            // btnWorkouts
            // 
            this.btnWorkouts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(70)))), ((int)(((byte)(165)))));
            this.btnWorkouts.CornerRadius = 12;
            this.btnWorkouts.FlatAppearance.BorderSize = 0;
            this.btnWorkouts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnWorkouts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnWorkouts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkouts.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnWorkouts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(196)))), ((int)(((byte)(214)))));
            this.btnWorkouts.Glyph = "deployed_code";
            this.btnWorkouts.Location = new System.Drawing.Point(15, 110);
            this.btnWorkouts.Name = "btnWorkouts";
            this.btnWorkouts.Size = new System.Drawing.Size(220, 45);
            this.btnWorkouts.TabIndex = 1;
            this.btnWorkouts.Text = "Мои тренировки";
            this.btnWorkouts.UseVisualStyleBackColor = false;
            this.btnWorkouts.Variant = Material3.WinForms.Controls.MaterialButtonVariant.Outlined;
            this.btnWorkouts.Click += new System.EventHandler(this.btnWorkouts_Click);
            // 
            // workoutDiaryDBDataSet1
            // 
            this.workoutDiaryDBDataSet1.DataSetName = "WorkoutDiaryDBDataSet";
            this.workoutDiaryDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // exercisesTableAdapter1
            // 
            this.exercisesTableAdapter1.ClearBeforeFill = true;
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.pageExercises);
            this.panelContent.Controls.Add(this.pageWorkouts);
            this.panelContent.Controls.Add(this.pageResults);
            this.panelContent.Controls.Add(this.pagePrograms);
            this.panelContent.Location = new System.Drawing.Point(257, 1);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(930, 716);
            this.panelContent.TabIndex = 11;
            // 
            // pagePrograms
            // 
            this.pagePrograms.Controls.Add(this.label2);
            this.pagePrograms.Location = new System.Drawing.Point(0, 0);
            this.pagePrograms.Name = "pagePrograms";
            this.pagePrograms.Size = new System.Drawing.Size(937, 724);
            this.pagePrograms.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 30);
            this.label2.TabIndex = 21;
            this.label2.Text = "Программы тренировок";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.White;
            this.materialCard1.Controls.Add(this.materialLabel8);
            this.materialCard1.Controls.Add(this.materialLabel7);
            this.materialCard1.Controls.Add(this.materialLabel6);
            this.materialCard1.Controls.Add(this.lblProfileLogin);
            this.materialCard1.Controls.Add(this.lblPersonalInfo);
            this.materialCard1.CornerRadius = 18;
            this.materialCard1.Location = new System.Drawing.Point(28, 28);
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(16);
            this.materialCard1.Size = new System.Drawing.Size(313, 197);
            this.materialCard1.TabIndex = 25;
            // 
            // lblPersonalInfo
            // 
            this.lblPersonalInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblPersonalInfo.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPersonalInfo.Location = new System.Drawing.Point(56, 16);
            this.lblPersonalInfo.Name = "lblPersonalInfo";
            this.lblPersonalInfo.Size = new System.Drawing.Size(197, 36);
            this.lblPersonalInfo.TabIndex = 0;
            this.lblPersonalInfo.Text = "Личные данные";
            // 
            // lblProfileLogin
            // 
            this.lblProfileLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblProfileLogin.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfileLogin.Location = new System.Drawing.Point(20, 150);
            this.lblProfileLogin.Name = "lblProfileLogin";
            this.lblProfileLogin.Size = new System.Drawing.Size(100, 23);
            this.lblProfileLogin.TabIndex = 1;
            this.lblProfileLogin.Text = "Login:";
            this.lblProfileLogin.Click += new System.EventHandler(this.materialLabel6_Click);
            // 
            // materialLabel6
            // 
            this.materialLabel6.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel6.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel6.Location = new System.Drawing.Point(20, 75);
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(100, 23);
            this.materialLabel6.TabIndex = 2;
            this.materialLabel6.Text = "ФИО:";
            // 
            // materialLabel7
            // 
            this.materialLabel7.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel7.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel7.Location = new System.Drawing.Point(20, 100);
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(100, 23);
            this.materialLabel7.TabIndex = 3;
            this.materialLabel7.Text = "Пароль: ";
            // 
            // materialLabel8
            // 
            this.materialLabel8.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel8.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel8.Location = new System.Drawing.Point(20, 125);
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(100, 23);
            this.materialLabel8.TabIndex = 4;
            this.materialLabel8.Text = "Роль:";
            // 
            // pageResults
            // 
            this.pageResults.Controls.Add(this.materialCard1);
            this.pageResults.Location = new System.Drawing.Point(-4, -4);
            this.pageResults.Name = "pageResults";
            this.pageResults.Size = new System.Drawing.Size(938, 724);
            this.pageResults.TabIndex = 28;
            // 
            // pageWorkouts
            // 
            this.pageWorkouts.Controls.Add(this.pageHome);
            this.pageWorkouts.Location = new System.Drawing.Point(2, 0);
            this.pageWorkouts.Name = "pageWorkouts";
            this.pageWorkouts.Size = new System.Drawing.Size(927, 716);
            this.pageWorkouts.TabIndex = 29;
            // 
            // pageHome
            // 
            this.pageHome.Controls.Add(this.materialLabel5);
            this.pageHome.Controls.Add(this.MaterialCard);
            this.pageHome.Controls.Add(this.cardExerciseCount);
            this.pageHome.Controls.Add(this.cardWorkoutCount);
            this.pageHome.Controls.Add(this.cardWelcome);
            this.pageHome.Controls.Add(this.dgvRecentWorkouts);
            this.pageHome.Controls.Add(this.cardRecentWorkouts);
            this.pageHome.Location = new System.Drawing.Point(8, 8);
            this.pageHome.Name = "pageHome";
            this.pageHome.Size = new System.Drawing.Size(927, 716);
            this.pageHome.TabIndex = 2;
            // 
            // materialLabel5
            // 
            this.materialLabel5.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel5.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.materialLabel5.Location = new System.Drawing.Point(14, 321);
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(450, 40);
            this.materialLabel5.TabIndex = 15;
            this.materialLabel5.Text = "Последние тренировки";
            // 
            // MaterialCard
            // 
            this.MaterialCard.BackColor = System.Drawing.Color.White;
            this.MaterialCard.Controls.Add(this.lblLastWorkout);
            this.MaterialCard.Controls.Add(this.materialLabel2);
            this.MaterialCard.CornerRadius = 12;
            this.MaterialCard.Location = new System.Drawing.Point(514, 161);
            this.MaterialCard.Name = "MaterialCard";
            this.MaterialCard.Padding = new System.Windows.Forms.Padding(16);
            this.MaterialCard.Size = new System.Drawing.Size(230, 130);
            this.MaterialCard.TabIndex = 13;
            // 
            // lblLastWorkout
            // 
            this.lblLastWorkout.BackColor = System.Drawing.Color.Transparent;
            this.lblLastWorkout.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLastWorkout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(70)))), ((int)(((byte)(165)))));
            this.lblLastWorkout.Location = new System.Drawing.Point(15, 55);
            this.lblLastWorkout.Name = "lblLastWorkout";
            this.lblLastWorkout.Size = new System.Drawing.Size(200, 50);
            this.lblLastWorkout.TabIndex = 3;
            this.lblLastWorkout.Text = "Пока нет данных";
            // 
            // materialLabel2
            // 
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(101)))), ((int)(((byte)(121)))));
            this.materialLabel2.Location = new System.Drawing.Point(15, 15);
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(200, 30);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Последняя тренировка";
            // 
            // cardExerciseCount
            // 
            this.cardExerciseCount.BackColor = System.Drawing.Color.White;
            this.cardExerciseCount.Controls.Add(this.lblExerciseCount);
            this.cardExerciseCount.Controls.Add(this.lblExerciseTitle);
            this.cardExerciseCount.CornerRadius = 12;
            this.cardExerciseCount.Location = new System.Drawing.Point(264, 161);
            this.cardExerciseCount.Name = "cardExerciseCount";
            this.cardExerciseCount.Padding = new System.Windows.Forms.Padding(16);
            this.cardExerciseCount.Size = new System.Drawing.Size(230, 130);
            this.cardExerciseCount.TabIndex = 14;
            // 
            // lblExerciseCount
            // 
            this.lblExerciseCount.BackColor = System.Drawing.Color.Transparent;
            this.lblExerciseCount.Font = new System.Drawing.Font("Segoe UI Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblExerciseCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(70)))), ((int)(((byte)(165)))));
            this.lblExerciseCount.Location = new System.Drawing.Point(15, 55);
            this.lblExerciseCount.Name = "lblExerciseCount";
            this.lblExerciseCount.Size = new System.Drawing.Size(190, 50);
            this.lblExerciseCount.TabIndex = 2;
            this.lblExerciseCount.Text = "0";
            // 
            // lblExerciseTitle
            // 
            this.lblExerciseTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblExerciseTitle.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExerciseTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(101)))), ((int)(((byte)(121)))));
            this.lblExerciseTitle.Location = new System.Drawing.Point(15, 15);
            this.lblExerciseTitle.Name = "lblExerciseTitle";
            this.lblExerciseTitle.Size = new System.Drawing.Size(190, 30);
            this.lblExerciseTitle.TabIndex = 2;
            this.lblExerciseTitle.Text = "Упражнения";
            // 
            // cardWorkoutCount
            // 
            this.cardWorkoutCount.BackColor = System.Drawing.Color.White;
            this.cardWorkoutCount.Controls.Add(this.lblWorkoutCount);
            this.cardWorkoutCount.Controls.Add(this.materialLabel1);
            this.cardWorkoutCount.CornerRadius = 12;
            this.cardWorkoutCount.Location = new System.Drawing.Point(14, 162);
            this.cardWorkoutCount.Name = "cardWorkoutCount";
            this.cardWorkoutCount.Padding = new System.Windows.Forms.Padding(16);
            this.cardWorkoutCount.Size = new System.Drawing.Size(230, 130);
            this.cardWorkoutCount.TabIndex = 12;
            // 
            // lblWorkoutCount
            // 
            this.lblWorkoutCount.BackColor = System.Drawing.Color.Transparent;
            this.lblWorkoutCount.Font = new System.Drawing.Font("Segoe UI Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWorkoutCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(70)))), ((int)(((byte)(165)))));
            this.lblWorkoutCount.Location = new System.Drawing.Point(15, 55);
            this.lblWorkoutCount.Name = "lblWorkoutCount";
            this.lblWorkoutCount.Size = new System.Drawing.Size(190, 50);
            this.lblWorkoutCount.TabIndex = 1;
            this.lblWorkoutCount.Text = "0";
            // 
            // materialLabel1
            // 
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(101)))), ((int)(((byte)(121)))));
            this.materialLabel1.Location = new System.Drawing.Point(15, 15);
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(190, 30);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Тренировки";
            // 
            // cardWelcome
            // 
            this.cardWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cardWelcome.BackColor = System.Drawing.Color.White;
            this.cardWelcome.Controls.Add(this.materialLabel3);
            this.cardWelcome.Controls.Add(this.materialLabel4);
            this.cardWelcome.CornerRadius = 12;
            this.cardWelcome.Location = new System.Drawing.Point(14, 16);
            this.cardWelcome.Name = "cardWelcome";
            this.cardWelcome.Padding = new System.Windows.Forms.Padding(16);
            this.cardWelcome.Size = new System.Drawing.Size(900, 120);
            this.cardWelcome.TabIndex = 11;
            // 
            // materialLabel3
            // 
            this.materialLabel3.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel3.Font = new System.Drawing.Font("Segoe UI Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.materialLabel3.Location = new System.Drawing.Point(25, 20);
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(550, 50);
            this.materialLabel3.TabIndex = 5;
            this.materialLabel3.Text = "Добро пожаловать!";
            // 
            // materialLabel4
            // 
            this.materialLabel4.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel4.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(101)))), ((int)(((byte)(121)))));
            this.materialLabel4.Location = new System.Drawing.Point(28, 68);
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(600, 30);
            this.materialLabel4.TabIndex = 5;
            this.materialLabel4.Text = "Твой прогресс начинаетя здесь";
            // 
            // dgvRecentWorkouts
            // 
            this.dgvRecentWorkouts.AllowUserToAddRows = false;
            this.dgvRecentWorkouts.AllowUserToDeleteRows = false;
            this.dgvRecentWorkouts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRecentWorkouts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecentWorkouts.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecentWorkouts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecentWorkouts.Location = new System.Drawing.Point(14, 371);
            this.dgvRecentWorkouts.MultiSelect = false;
            this.dgvRecentWorkouts.Name = "dgvRecentWorkouts";
            this.dgvRecentWorkouts.ReadOnly = true;
            this.dgvRecentWorkouts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecentWorkouts.Size = new System.Drawing.Size(895, 328);
            this.dgvRecentWorkouts.TabIndex = 16;
            // 
            // cardRecentWorkouts
            // 
            this.cardRecentWorkouts.BackColor = System.Drawing.Color.White;
            this.cardRecentWorkouts.CornerRadius = 12;
            this.cardRecentWorkouts.Location = new System.Drawing.Point(33, 397);
            this.cardRecentWorkouts.Name = "cardRecentWorkouts";
            this.cardRecentWorkouts.Padding = new System.Windows.Forms.Padding(16);
            this.cardRecentWorkouts.Size = new System.Drawing.Size(850, 280);
            this.cardRecentWorkouts.TabIndex = 17;
            // 
            // pageExercises
            // 
            this.pageExercises.Location = new System.Drawing.Point(-3, -4);
            this.pageExercises.Name = "pageExercises";
            this.pageExercises.Size = new System.Drawing.Size(937, 724);
            this.pageExercises.TabIndex = 30;
            // 
            // FrmAthlete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1184, 717);
            this.Controls.Add(this.plnBrand);
            this.Controls.Add(this.panelContent);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "FrmAthlete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Дневник тренировок - Спортсмен";
            this.Load += new System.EventHandler(this.FrmAthlete_Load);
            this.plnBrand.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.workoutDiaryDBDataSet1)).EndInit();
            this.panelContent.ResumeLayout(false);
            this.pagePrograms.ResumeLayout(false);
            this.pagePrograms.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.pageResults.ResumeLayout(false);
            this.pageWorkouts.ResumeLayout(false);
            this.pageHome.ResumeLayout(false);
            this.MaterialCard.ResumeLayout(false);
            this.cardExerciseCount.ResumeLayout(false);
            this.cardWorkoutCount.ResumeLayout(false);
            this.cardWelcome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentWorkouts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Material3.WinForms.Controls.MaterialLabel lblBrand;
        private Material3.WinForms.Controls.MaterialRoundedPanel plnBrand;
        private Material3.WinForms.Controls.MaterialButton btnLogout;
        private Material3.WinForms.Controls.MaterialButton btnResults;
        private Material3.WinForms.Controls.MaterialButton btnExercises;
        private Material3.WinForms.Controls.MaterialButton btnPrograms;
        private Material3.WinForms.Controls.MaterialButton btnWorkouts;
        private WorkoutDiaryDBDataSet workoutDiaryDBDataSet1;
        private WorkoutDiaryDBDataSetTableAdapters.ExercisesTableAdapter exercisesTableAdapter1;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel pagePrograms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pageWorkouts;
        private System.Windows.Forms.Panel pageHome;
        private Material3.WinForms.Controls.MaterialLabel materialLabel5;
        private Material3.WinForms.Controls.MaterialCard MaterialCard;
        private Material3.WinForms.Controls.MaterialLabel lblLastWorkout;
        private Material3.WinForms.Controls.MaterialLabel materialLabel2;
        private Material3.WinForms.Controls.MaterialCard cardExerciseCount;
        private Material3.WinForms.Controls.MaterialLabel lblExerciseCount;
        private Material3.WinForms.Controls.MaterialLabel lblExerciseTitle;
        private Material3.WinForms.Controls.MaterialCard cardWorkoutCount;
        private Material3.WinForms.Controls.MaterialLabel lblWorkoutCount;
        private Material3.WinForms.Controls.MaterialLabel materialLabel1;
        private Material3.WinForms.Controls.MaterialCard cardWelcome;
        private Material3.WinForms.Controls.MaterialLabel materialLabel3;
        private Material3.WinForms.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.DataGridView dgvRecentWorkouts;
        private Material3.WinForms.Controls.MaterialCard cardRecentWorkouts;
        private System.Windows.Forms.Panel pageResults;
        private Material3.WinForms.Controls.MaterialCard materialCard1;
        private Material3.WinForms.Controls.MaterialLabel materialLabel8;
        private Material3.WinForms.Controls.MaterialLabel materialLabel7;
        private Material3.WinForms.Controls.MaterialLabel materialLabel6;
        private Material3.WinForms.Controls.MaterialLabel lblProfileLogin;
        private Material3.WinForms.Controls.MaterialLabel lblPersonalInfo;
        private System.Windows.Forms.Panel pageExercises;
    }
}