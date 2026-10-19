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
            this.btnWorkouts = new Material3.WinForms.Controls.MaterialButton();
            this.btnPrograms = new Material3.WinForms.Controls.MaterialButton();
            this.btnExercises = new Material3.WinForms.Controls.MaterialButton();
            this.btnResults = new Material3.WinForms.Controls.MaterialButton();
            this.btnLogout = new Material3.WinForms.Controls.MaterialButton();
            this.workoutDiaryDBDataSet1 = new WorkoutDiary.WorkoutDiaryDBDataSet();
            this.exercisesTableAdapter1 = new WorkoutDiary.WorkoutDiaryDBDataSetTableAdapters.ExercisesTableAdapter();
            this.cardWelcome = new Material3.WinForms.Controls.MaterialCard();
            this.materialLabel3 = new Material3.WinForms.Controls.MaterialLabel();
            this.materialLabel4 = new Material3.WinForms.Controls.MaterialLabel();
            this.cardWorkoutCount = new Material3.WinForms.Controls.MaterialCard();
            this.cardExerciseCount = new Material3.WinForms.Controls.MaterialCard();
            this.MaterialCard = new Material3.WinForms.Controls.MaterialCard();
            this.materialLabel1 = new Material3.WinForms.Controls.MaterialLabel();
            this.lblWorkoutCount = new Material3.WinForms.Controls.MaterialLabel();
            this.lblExerciseTitle = new Material3.WinForms.Controls.MaterialLabel();
            this.lblExerciseCount = new Material3.WinForms.Controls.MaterialLabel();
            this.materialLabel2 = new Material3.WinForms.Controls.MaterialLabel();
            this.lblLastWorkout = new Material3.WinForms.Controls.MaterialLabel();
            this.materialLabel5 = new Material3.WinForms.Controls.MaterialLabel();
            this.dgvRecentWorkouts = new System.Windows.Forms.DataGridView();
            this.cardRecentWorkouts = new Material3.WinForms.Controls.MaterialCard();
            this.plnBrand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workoutDiaryDBDataSet1)).BeginInit();
            this.cardWelcome.SuspendLayout();
            this.cardWorkoutCount.SuspendLayout();
            this.cardExerciseCount.SuspendLayout();
            this.MaterialCard.SuspendLayout();
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
            // cardWelcome
            // 
            this.cardWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cardWelcome.BackColor = System.Drawing.Color.White;
            this.cardWelcome.Controls.Add(this.materialLabel3);
            this.cardWelcome.Controls.Add(this.materialLabel4);
            this.cardWelcome.CornerRadius = 12;
            this.cardWelcome.Location = new System.Drawing.Point(280, 25);
            this.cardWelcome.Name = "cardWelcome";
            this.cardWelcome.Padding = new System.Windows.Forms.Padding(16);
            this.cardWelcome.Size = new System.Drawing.Size(897, 120);
            this.cardWelcome.TabIndex = 4;
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
            this.materialLabel4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(101)))), ((int)(((byte)(121)))));
            this.materialLabel4.Location = new System.Drawing.Point(28, 68);
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(600, 30);
            this.materialLabel4.TabIndex = 5;
            this.materialLabel4.Text = "Твой прогресс начинаетя здесь";
            // 
            // cardWorkoutCount
            // 
            this.cardWorkoutCount.BackColor = System.Drawing.Color.White;
            this.cardWorkoutCount.Controls.Add(this.lblWorkoutCount);
            this.cardWorkoutCount.Controls.Add(this.materialLabel1);
            this.cardWorkoutCount.CornerRadius = 12;
            this.cardWorkoutCount.Location = new System.Drawing.Point(280, 171);
            this.cardWorkoutCount.Name = "cardWorkoutCount";
            this.cardWorkoutCount.Padding = new System.Windows.Forms.Padding(16);
            this.cardWorkoutCount.Size = new System.Drawing.Size(230, 130);
            this.cardWorkoutCount.TabIndex = 5;
            // 
            // cardExerciseCount
            // 
            this.cardExerciseCount.BackColor = System.Drawing.Color.White;
            this.cardExerciseCount.Controls.Add(this.lblExerciseCount);
            this.cardExerciseCount.Controls.Add(this.lblExerciseTitle);
            this.cardExerciseCount.CornerRadius = 12;
            this.cardExerciseCount.Location = new System.Drawing.Point(530, 170);
            this.cardExerciseCount.Name = "cardExerciseCount";
            this.cardExerciseCount.Padding = new System.Windows.Forms.Padding(16);
            this.cardExerciseCount.Size = new System.Drawing.Size(230, 130);
            this.cardExerciseCount.TabIndex = 6;
            // 
            // MaterialCard
            // 
            this.MaterialCard.BackColor = System.Drawing.Color.White;
            this.MaterialCard.Controls.Add(this.lblLastWorkout);
            this.MaterialCard.Controls.Add(this.materialLabel2);
            this.MaterialCard.CornerRadius = 12;
            this.MaterialCard.Location = new System.Drawing.Point(780, 170);
            this.MaterialCard.Name = "MaterialCard";
            this.MaterialCard.Padding = new System.Windows.Forms.Padding(16);
            this.MaterialCard.Size = new System.Drawing.Size(230, 130);
            this.MaterialCard.TabIndex = 6;
            // 
            // materialLabel1
            // 
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(101)))), ((int)(((byte)(121)))));
            this.materialLabel1.Location = new System.Drawing.Point(15, 15);
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(190, 30);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Тренировки";
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
            // lblExerciseTitle
            // 
            this.lblExerciseTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblExerciseTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblExerciseTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(101)))), ((int)(((byte)(121)))));
            this.lblExerciseTitle.Location = new System.Drawing.Point(15, 15);
            this.lblExerciseTitle.Name = "lblExerciseTitle";
            this.lblExerciseTitle.Size = new System.Drawing.Size(190, 30);
            this.lblExerciseTitle.TabIndex = 2;
            this.lblExerciseTitle.Text = "Упражнения";
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
            // materialLabel2
            // 
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(101)))), ((int)(((byte)(121)))));
            this.materialLabel2.Location = new System.Drawing.Point(15, 15);
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(200, 30);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Последняя тренировка";
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
            // materialLabel5
            // 
            this.materialLabel5.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel5.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.materialLabel5.Location = new System.Drawing.Point(280, 330);
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(450, 40);
            this.materialLabel5.TabIndex = 7;
            this.materialLabel5.Text = "Последние тренировки";
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
            this.dgvRecentWorkouts.Location = new System.Drawing.Point(280, 380);
            this.dgvRecentWorkouts.MultiSelect = false;
            this.dgvRecentWorkouts.Name = "dgvRecentWorkouts";
            this.dgvRecentWorkouts.ReadOnly = true;
            this.dgvRecentWorkouts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecentWorkouts.Size = new System.Drawing.Size(892, 325);
            this.dgvRecentWorkouts.TabIndex = 8;
            // 
            // cardRecentWorkouts
            // 
            this.cardRecentWorkouts.BackColor = System.Drawing.Color.White;
            this.cardRecentWorkouts.CornerRadius = 12;
            this.cardRecentWorkouts.Location = new System.Drawing.Point(299, 406);
            this.cardRecentWorkouts.Name = "cardRecentWorkouts";
            this.cardRecentWorkouts.Padding = new System.Windows.Forms.Padding(16);
            this.cardRecentWorkouts.Size = new System.Drawing.Size(850, 280);
            this.cardRecentWorkouts.TabIndex = 10;
            // 
            // FrmAthlete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1184, 717);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.MaterialCard);
            this.Controls.Add(this.cardExerciseCount);
            this.Controls.Add(this.cardWorkoutCount);
            this.Controls.Add(this.cardWelcome);
            this.Controls.Add(this.plnBrand);
            this.Controls.Add(this.dgvRecentWorkouts);
            this.Controls.Add(this.cardRecentWorkouts);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "FrmAthlete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Дневник тренировок - Спортсмен";
            this.Load += new System.EventHandler(this.FrmAthlete_Load);
            this.plnBrand.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.workoutDiaryDBDataSet1)).EndInit();
            this.cardWelcome.ResumeLayout(false);
            this.cardWorkoutCount.ResumeLayout(false);
            this.cardExerciseCount.ResumeLayout(false);
            this.MaterialCard.ResumeLayout(false);
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
        private Material3.WinForms.Controls.MaterialCard cardWelcome;
        private Material3.WinForms.Controls.MaterialLabel materialLabel3;
        private Material3.WinForms.Controls.MaterialLabel materialLabel4;
        private Material3.WinForms.Controls.MaterialCard cardWorkoutCount;
        private Material3.WinForms.Controls.MaterialLabel lblWorkoutCount;
        private Material3.WinForms.Controls.MaterialLabel materialLabel1;
        private Material3.WinForms.Controls.MaterialCard cardExerciseCount;
        private Material3.WinForms.Controls.MaterialCard MaterialCard;
        private Material3.WinForms.Controls.MaterialLabel lblExerciseCount;
        private Material3.WinForms.Controls.MaterialLabel lblExerciseTitle;
        private Material3.WinForms.Controls.MaterialLabel materialLabel2;
        private Material3.WinForms.Controls.MaterialLabel lblLastWorkout;
        private Material3.WinForms.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.DataGridView dgvRecentWorkouts;
        private Material3.WinForms.Controls.MaterialCard cardRecentWorkouts;
    }
}