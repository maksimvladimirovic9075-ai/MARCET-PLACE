namespace wb
{
    partial class UserForm
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
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnCart = new System.Windows.Forms.Button();
            this.btnFavorites = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblLogo = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnFilters = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelCatalog = new System.Windows.Forms.Panel();
            this.panelCategories = new System.Windows.Forms.Panel();
            this.flowCategories = new System.Windows.Forms.FlowLayoutPanel();
            this.btnElectronucs = new System.Windows.Forms.Button();
            this.btnClothes = new System.Windows.Forms.Button();
            this.btnShoes = new System.Windows.Forms.Button();
            this.btnHomeGoods = new System.Windows.Forms.Button();
            this.lblCategoriesSubtitle = new System.Windows.Forms.Label();
            this.lblCategoriesTitle = new System.Windows.Forms.Label();
            this.panelFavorites = new System.Windows.Forms.Panel();
            this.lblFavoritesEmpty = new System.Windows.Forms.Label();
            this.flowFavorites = new System.Windows.Forms.FlowLayoutPanel();
            this.lblFavoritesSubtitle = new System.Windows.Forms.Label();
            this.lblFavoritesTitle = new System.Windows.Forms.Label();
            this.panelCart = new System.Windows.Forms.Panel();
            this.panelCartSummary = new System.Windows.Forms.Panel();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.lblOrderTitle = new System.Windows.Forms.Label();
            this.lblCartCount = new System.Windows.Forms.Label();
            this.lblCartTotal = new System.Windows.Forms.Label();
            this.btnCartMinus = new System.Windows.Forms.Button();
            this.btnCartRemove = new System.Windows.Forms.Button();
            this.btnCartPlus = new System.Windows.Forms.Button();
            this.dvgCart = new System.Windows.Forms.DataGridView();
            this.colCartProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCartPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCartQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCartSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCartSubtitle = new System.Windows.Forms.Label();
            this.lblCartTitle = new System.Windows.Forms.Label();
            this.panelProfile = new System.Windows.Forms.Panel();
            this.lblPrifileTitle = new System.Windows.Forms.Label();
            this.panelProfileInfo = new System.Windows.Forms.Panel();
            this.dvgOrders = new System.Windows.Forms.DataGridView();
            this.lblOrdersTitle = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblPersonalInfo = new System.Windows.Forms.Label();
            this.lblProfileName = new System.Windows.Forms.Label();
            this.lblProfileEmail = new System.Windows.Forms.Label();
            this.lblProfileRole = new System.Windows.Forms.Label();
            this.panelHome = new System.Windows.Forms.Panel();
            this.flowProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.panelSidebar.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelCategories.SuspendLayout();
            this.flowCategories.SuspendLayout();
            this.panelFavorites.SuspendLayout();
            this.panelCart.SuspendLayout();
            this.panelCartSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCart)).BeginInit();
            this.panelProfile.SuspendLayout();
            this.panelProfileInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgOrders)).BeginInit();
            this.panelHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.White;
            this.panelSidebar.Controls.Add(this.panel1);
            this.panelSidebar.Controls.Add(this.btnProfile);
            this.panelSidebar.Controls.Add(this.btnCart);
            this.panelSidebar.Controls.Add(this.btnFavorites);
            this.panelSidebar.Controls.Add(this.btnCategories);
            this.panelSidebar.Controls.Add(this.btnHome);
            this.panelSidebar.Controls.Add(this.lblLogo);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Margin = new System.Windows.Forms.Padding(4);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(238, 864);
            this.panelSidebar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(238, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 760);
            this.panel1.TabIndex = 5;
            // 
            // btnProfile
            // 
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnProfile.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnProfile.Location = new System.Drawing.Point(12, 324);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(204, 48);
            this.btnProfile.TabIndex = 5;
            this.btnProfile.Text = "Профиль";
            this.btnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnCart
            // 
            this.btnCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCart.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCart.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnCart.Location = new System.Drawing.Point(12, 268);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(204, 48);
            this.btnCart.TabIndex = 4;
            this.btnCart.Text = "Корзина";
            this.btnCart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCart.UseVisualStyleBackColor = true;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // btnFavorites
            // 
            this.btnFavorites.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFavorites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFavorites.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFavorites.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnFavorites.Location = new System.Drawing.Point(12, 212);
            this.btnFavorites.Name = "btnFavorites";
            this.btnFavorites.Size = new System.Drawing.Size(204, 48);
            this.btnFavorites.TabIndex = 3;
            this.btnFavorites.Text = "Избранное";
            this.btnFavorites.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFavorites.UseVisualStyleBackColor = true;
            this.btnFavorites.Click += new System.EventHandler(this.btnFavorites_Click);
            // 
            // btnCategories
            // 
            this.btnCategories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategories.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCategories.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnCategories.Location = new System.Drawing.Point(12, 156);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(204, 48);
            this.btnCategories.TabIndex = 2;
            this.btnCategories.Text = "Категории";
            this.btnCategories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategories.UseVisualStyleBackColor = true;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHome.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnHome.Location = new System.Drawing.Point(12, 100);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(204, 48);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Главная";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.BackColor = System.Drawing.Color.White;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI Black", 35.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(45)))), ((int)(((byte)(220)))));
            this.lblLogo.Location = new System.Drawing.Point(24, 12);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(110, 62);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "WB";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.btnSearch);
            this.panelTop.Controls.Add(this.btnFilters);
            this.panelTop.Controls.Add(this.button2);
            this.panelTop.Controls.Add(this.txtSearch);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(238, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1027, 92);
            this.panelTop.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(45)))), ((int)(((byte)(220)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(735, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 29);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Найти";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            this.btnSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSearch_KeyDown);
            // 
            // btnFilters
            // 
            this.btnFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(45)))), ((int)(((byte)(220)))));
            this.btnFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilters.ForeColor = System.Drawing.Color.White;
            this.btnFilters.Location = new System.Drawing.Point(25, 59);
            this.btnFilters.Name = "btnFilters";
            this.btnFilters.Size = new System.Drawing.Size(75, 27);
            this.btnFilters.TabIndex = 1;
            this.btnFilters.Text = "Фильтры";
            this.btnFilters.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(96, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 27);
            this.button2.TabIndex = 2;
            this.button2.Text = "По популярности";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSearch.Location = new System.Drawing.Point(25, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(700, 29);
            this.txtSearch.TabIndex = 0;
            // 
            // panelContent
            // 
            this.panelContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContent.Controls.Add(this.panelCatalog);
            this.panelContent.Controls.Add(this.panelCategories);
            this.panelContent.Controls.Add(this.panelFavorites);
            this.panelContent.Controls.Add(this.panelCart);
            this.panelContent.Controls.Add(this.panelProfile);
            this.panelContent.Controls.Add(this.panelHome);
            this.panelContent.Location = new System.Drawing.Point(241, 95);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1024, 769);
            this.panelContent.TabIndex = 3;
            // 
            // panelCatalog
            // 
            this.panelCatalog.AutoScroll = true;
            this.panelCatalog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(253)))));
            this.panelCatalog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCatalog.Location = new System.Drawing.Point(0, 0);
            this.panelCatalog.Name = "panelCatalog";
            this.panelCatalog.Size = new System.Drawing.Size(1024, 769);
            this.panelCatalog.TabIndex = 15;
            this.panelCatalog.Visible = false;
            // 
            // panelCategories
            // 
            this.panelCategories.Controls.Add(this.flowCategories);
            this.panelCategories.Controls.Add(this.lblCategoriesSubtitle);
            this.panelCategories.Controls.Add(this.lblCategoriesTitle);
            this.panelCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCategories.Location = new System.Drawing.Point(0, 0);
            this.panelCategories.Name = "panelCategories";
            this.panelCategories.Size = new System.Drawing.Size(1024, 769);
            this.panelCategories.TabIndex = 14;
            // 
            // flowCategories
            // 
            this.flowCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowCategories.AutoScroll = true;
            this.flowCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.flowCategories.Controls.Add(this.btnElectronucs);
            this.flowCategories.Controls.Add(this.btnClothes);
            this.flowCategories.Controls.Add(this.btnShoes);
            this.flowCategories.Controls.Add(this.btnHomeGoods);
            this.flowCategories.Location = new System.Drawing.Point(25, 120);
            this.flowCategories.Name = "flowCategories";
            this.flowCategories.Padding = new System.Windows.Forms.Padding(5);
            this.flowCategories.Size = new System.Drawing.Size(900, 480);
            this.flowCategories.TabIndex = 3;
            // 
            // btnElectronucs
            // 
            this.btnElectronucs.BackColor = System.Drawing.Color.White;
            this.btnElectronucs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnElectronucs.FlatAppearance.BorderSize = 0;
            this.btnElectronucs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElectronucs.Font = new System.Drawing.Font("Segoe UI Black", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnElectronucs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(80)))), ((int)(((byte)(164)))));
            this.btnElectronucs.Location = new System.Drawing.Point(15, 15);
            this.btnElectronucs.Margin = new System.Windows.Forms.Padding(10);
            this.btnElectronucs.Name = "btnElectronucs";
            this.btnElectronucs.Size = new System.Drawing.Size(260, 150);
            this.btnElectronucs.TabIndex = 1;
            this.btnElectronucs.Text = "ЭЛЕКТРОНИКА";
            this.btnElectronucs.UseVisualStyleBackColor = false;
            this.btnElectronucs.Click += new System.EventHandler(this.btnElectronucs_Click);
            // 
            // btnClothes
            // 
            this.btnClothes.BackColor = System.Drawing.Color.White;
            this.btnClothes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClothes.FlatAppearance.BorderSize = 0;
            this.btnClothes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClothes.Font = new System.Drawing.Font("Segoe UI Black", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClothes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(80)))), ((int)(((byte)(164)))));
            this.btnClothes.Location = new System.Drawing.Point(295, 15);
            this.btnClothes.Margin = new System.Windows.Forms.Padding(10);
            this.btnClothes.Name = "btnClothes";
            this.btnClothes.Size = new System.Drawing.Size(260, 150);
            this.btnClothes.TabIndex = 2;
            this.btnClothes.Text = "ОДЕЖДА";
            this.btnClothes.UseVisualStyleBackColor = false;
            this.btnClothes.Click += new System.EventHandler(this.btnClothes_Click);
            // 
            // btnShoes
            // 
            this.btnShoes.BackColor = System.Drawing.Color.White;
            this.btnShoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShoes.FlatAppearance.BorderSize = 0;
            this.btnShoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShoes.Font = new System.Drawing.Font("Segoe UI Black", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShoes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(80)))), ((int)(((byte)(164)))));
            this.btnShoes.Location = new System.Drawing.Point(575, 15);
            this.btnShoes.Margin = new System.Windows.Forms.Padding(10);
            this.btnShoes.Name = "btnShoes";
            this.btnShoes.Size = new System.Drawing.Size(260, 150);
            this.btnShoes.TabIndex = 3;
            this.btnShoes.Text = "ОБУВЬ";
            this.btnShoes.UseVisualStyleBackColor = false;
            this.btnShoes.Click += new System.EventHandler(this.btnShoes_Click);
            // 
            // btnHomeGoods
            // 
            this.btnHomeGoods.BackColor = System.Drawing.Color.White;
            this.btnHomeGoods.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHomeGoods.FlatAppearance.BorderSize = 0;
            this.btnHomeGoods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomeGoods.Font = new System.Drawing.Font("Segoe UI Black", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHomeGoods.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(80)))), ((int)(((byte)(164)))));
            this.btnHomeGoods.Location = new System.Drawing.Point(15, 185);
            this.btnHomeGoods.Margin = new System.Windows.Forms.Padding(10);
            this.btnHomeGoods.Name = "btnHomeGoods";
            this.btnHomeGoods.Size = new System.Drawing.Size(260, 150);
            this.btnHomeGoods.TabIndex = 4;
            this.btnHomeGoods.Text = "ТОВАРЫ ДЛЯ ДОМА";
            this.btnHomeGoods.UseVisualStyleBackColor = false;
            this.btnHomeGoods.Click += new System.EventHandler(this.btnHomeGoods_Click);
            // 
            // lblCategoriesSubtitle
            // 
            this.lblCategoriesSubtitle.AutoSize = true;
            this.lblCategoriesSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(130)))));
            this.lblCategoriesSubtitle.Location = new System.Drawing.Point(32, 72);
            this.lblCategoriesSubtitle.Name = "lblCategoriesSubtitle";
            this.lblCategoriesSubtitle.Size = new System.Drawing.Size(229, 17);
            this.lblCategoriesSubtitle.TabIndex = 2;
            this.lblCategoriesSubtitle.Text = "Выберите интересующий вас раздел";
            // 
            // lblCategoriesTitle
            // 
            this.lblCategoriesTitle.AutoSize = true;
            this.lblCategoriesTitle.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCategoriesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.lblCategoriesTitle.Location = new System.Drawing.Point(30, 25);
            this.lblCategoriesTitle.Name = "lblCategoriesTitle";
            this.lblCategoriesTitle.Size = new System.Drawing.Size(160, 37);
            this.lblCategoriesTitle.TabIndex = 1;
            this.lblCategoriesTitle.Text = "Категории";
            // 
            // panelFavorites
            // 
            this.panelFavorites.Controls.Add(this.lblFavoritesEmpty);
            this.panelFavorites.Controls.Add(this.flowFavorites);
            this.panelFavorites.Controls.Add(this.lblFavoritesSubtitle);
            this.panelFavorites.Controls.Add(this.lblFavoritesTitle);
            this.panelFavorites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFavorites.Location = new System.Drawing.Point(0, 0);
            this.panelFavorites.Name = "panelFavorites";
            this.panelFavorites.Size = new System.Drawing.Size(1024, 769);
            this.panelFavorites.TabIndex = 13;
            // 
            // lblFavoritesEmpty
            // 
            this.lblFavoritesEmpty.AutoSize = true;
            this.lblFavoritesEmpty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFavoritesEmpty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(150)))));
            this.lblFavoritesEmpty.Location = new System.Drawing.Point(40, 145);
            this.lblFavoritesEmpty.Name = "lblFavoritesEmpty";
            this.lblFavoritesEmpty.Size = new System.Drawing.Size(261, 21);
            this.lblFavoritesEmpty.TabIndex = 4;
            this.lblFavoritesEmpty.Text = "Здесь пока нет избранных товаров";
            this.lblFavoritesEmpty.Visible = false;
            // 
            // flowFavorites
            // 
            this.flowFavorites.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowFavorites.AutoScroll = true;
            this.flowFavorites.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.flowFavorites.Location = new System.Drawing.Point(25, 120);
            this.flowFavorites.Name = "flowFavorites";
            this.flowFavorites.Padding = new System.Windows.Forms.Padding(8);
            this.flowFavorites.Size = new System.Drawing.Size(900, 480);
            this.flowFavorites.TabIndex = 3;
            // 
            // lblFavoritesSubtitle
            // 
            this.lblFavoritesSubtitle.AutoSize = true;
            this.lblFavoritesSubtitle.Location = new System.Drawing.Point(32, 72);
            this.lblFavoritesSubtitle.Name = "lblFavoritesSubtitle";
            this.lblFavoritesSubtitle.Size = new System.Drawing.Size(144, 17);
            this.lblFavoritesSubtitle.TabIndex = 2;
            this.lblFavoritesSubtitle.Text = "Сохранненные товары";
            // 
            // lblFavoritesTitle
            // 
            this.lblFavoritesTitle.AutoSize = true;
            this.lblFavoritesTitle.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFavoritesTitle.Location = new System.Drawing.Point(30, 25);
            this.lblFavoritesTitle.Name = "lblFavoritesTitle";
            this.lblFavoritesTitle.Size = new System.Drawing.Size(168, 37);
            this.lblFavoritesTitle.TabIndex = 1;
            this.lblFavoritesTitle.Text = "Избранное";
            // 
            // panelCart
            // 
            this.panelCart.Controls.Add(this.panelCartSummary);
            this.panelCart.Controls.Add(this.btnCartMinus);
            this.panelCart.Controls.Add(this.btnCartRemove);
            this.panelCart.Controls.Add(this.btnCartPlus);
            this.panelCart.Controls.Add(this.dvgCart);
            this.panelCart.Controls.Add(this.lblCartSubtitle);
            this.panelCart.Controls.Add(this.lblCartTitle);
            this.panelCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCart.Location = new System.Drawing.Point(0, 0);
            this.panelCart.Name = "panelCart";
            this.panelCart.Size = new System.Drawing.Size(1024, 769);
            this.panelCart.TabIndex = 12;
            // 
            // panelCartSummary
            // 
            this.panelCartSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCartSummary.BackColor = System.Drawing.Color.White;
            this.panelCartSummary.Controls.Add(this.btnCheckout);
            this.panelCartSummary.Controls.Add(this.lblOrderTitle);
            this.panelCartSummary.Controls.Add(this.lblCartCount);
            this.panelCartSummary.Controls.Add(this.lblCartTotal);
            this.panelCartSummary.Location = new System.Drawing.Point(635, 125);
            this.panelCartSummary.Name = "panelCartSummary";
            this.panelCartSummary.Size = new System.Drawing.Size(275, 250);
            this.panelCartSummary.TabIndex = 7;
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(80)))), ((int)(((byte)(164)))));
            this.btnCheckout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckout.FlatAppearance.BorderSize = 0;
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckout.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.Location = new System.Drawing.Point(20, 175);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(235, 45);
            this.btnCheckout.TabIndex = 4;
            this.btnCheckout.Text = "Оформить заказ";
            this.btnCheckout.UseVisualStyleBackColor = false;
            // 
            // lblOrderTitle
            // 
            this.lblOrderTitle.AutoSize = true;
            this.lblOrderTitle.Location = new System.Drawing.Point(20, 20);
            this.lblOrderTitle.Name = "lblOrderTitle";
            this.lblOrderTitle.Size = new System.Drawing.Size(69, 17);
            this.lblOrderTitle.TabIndex = 3;
            this.lblOrderTitle.Text = "Ваш заказ";
            // 
            // lblCartCount
            // 
            this.lblCartCount.Location = new System.Drawing.Point(20, 75);
            this.lblCartCount.Name = "lblCartCount";
            this.lblCartCount.Size = new System.Drawing.Size(220, 25);
            this.lblCartCount.TabIndex = 2;
            this.lblCartCount.Text = "Товаров: 0";
            // 
            // lblCartTotal
            // 
            this.lblCartTotal.Location = new System.Drawing.Point(20, 115);
            this.lblCartTotal.Name = "lblCartTotal";
            this.lblCartTotal.Size = new System.Drawing.Size(220, 30);
            this.lblCartTotal.TabIndex = 1;
            this.lblCartTotal.Text = "Итого: 0";
            // 
            // btnCartMinus
            // 
            this.btnCartMinus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCartMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(80)))), ((int)(((byte)(164)))));
            this.btnCartMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCartMinus.FlatAppearance.BorderSize = 0;
            this.btnCartMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCartMinus.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCartMinus.ForeColor = System.Drawing.Color.White;
            this.btnCartMinus.Location = new System.Drawing.Point(80, 570);
            this.btnCartMinus.Name = "btnCartMinus";
            this.btnCartMinus.Size = new System.Drawing.Size(45, 48);
            this.btnCartMinus.TabIndex = 6;
            this.btnCartMinus.Text = "-";
            this.btnCartMinus.UseVisualStyleBackColor = false;
            // 
            // btnCartRemove
            // 
            this.btnCartRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCartRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(80)))), ((int)(((byte)(164)))));
            this.btnCartRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCartRemove.FlatAppearance.BorderSize = 0;
            this.btnCartRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCartRemove.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCartRemove.ForeColor = System.Drawing.Color.White;
            this.btnCartRemove.Location = new System.Drawing.Point(140, 570);
            this.btnCartRemove.Name = "btnCartRemove";
            this.btnCartRemove.Size = new System.Drawing.Size(138, 48);
            this.btnCartRemove.TabIndex = 5;
            this.btnCartRemove.Text = "Удалить товар";
            this.btnCartRemove.UseVisualStyleBackColor = false;
            // 
            // btnCartPlus
            // 
            this.btnCartPlus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCartPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(80)))), ((int)(((byte)(164)))));
            this.btnCartPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCartPlus.FlatAppearance.BorderSize = 0;
            this.btnCartPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCartPlus.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCartPlus.ForeColor = System.Drawing.Color.White;
            this.btnCartPlus.Location = new System.Drawing.Point(25, 570);
            this.btnCartPlus.Name = "btnCartPlus";
            this.btnCartPlus.Size = new System.Drawing.Size(45, 48);
            this.btnCartPlus.TabIndex = 4;
            this.btnCartPlus.Text = "+";
            this.btnCartPlus.UseVisualStyleBackColor = false;
            // 
            // dvgCart
            // 
            this.dvgCart.AllowUserToAddRows = false;
            this.dvgCart.AllowUserToDeleteRows = false;
            this.dvgCart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgCart.BackgroundColor = System.Drawing.Color.White;
            this.dvgCart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvgCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCartProduct,
            this.colCartPrice,
            this.colCartQuantity,
            this.colCartSum});
            this.dvgCart.Location = new System.Drawing.Point(25, 125);
            this.dvgCart.MultiSelect = false;
            this.dvgCart.Name = "dvgCart";
            this.dvgCart.ReadOnly = true;
            this.dvgCart.RowHeadersVisible = false;
            this.dvgCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgCart.Size = new System.Drawing.Size(590, 440);
            this.dvgCart.TabIndex = 3;
            // 
            // colCartProduct
            // 
            this.colCartProduct.HeaderText = "Товар";
            this.colCartProduct.Name = "colCartProduct";
            this.colCartProduct.ReadOnly = true;
            // 
            // colCartPrice
            // 
            this.colCartPrice.HeaderText = "Цена";
            this.colCartPrice.Name = "colCartPrice";
            this.colCartPrice.ReadOnly = true;
            // 
            // colCartQuantity
            // 
            this.colCartQuantity.HeaderText = "Количество";
            this.colCartQuantity.Name = "colCartQuantity";
            this.colCartQuantity.ReadOnly = true;
            // 
            // colCartSum
            // 
            this.colCartSum.HeaderText = "Сумма";
            this.colCartSum.Name = "colCartSum";
            this.colCartSum.ReadOnly = true;
            // 
            // lblCartSubtitle
            // 
            this.lblCartSubtitle.AutoSize = true;
            this.lblCartSubtitle.Location = new System.Drawing.Point(32, 72);
            this.lblCartSubtitle.Name = "lblCartSubtitle";
            this.lblCartSubtitle.Size = new System.Drawing.Size(252, 17);
            this.lblCartSubtitle.TabIndex = 2;
            this.lblCartSubtitle.Text = "Проверьте товары перед оформлением";
            // 
            // lblCartTitle
            // 
            this.lblCartTitle.AutoSize = true;
            this.lblCartTitle.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCartTitle.Location = new System.Drawing.Point(30, 25);
            this.lblCartTitle.Name = "lblCartTitle";
            this.lblCartTitle.Size = new System.Drawing.Size(116, 21);
            this.lblCartTitle.TabIndex = 1;
            this.lblCartTitle.Text = "Моя корзина";
            // 
            // panelProfile
            // 
            this.panelProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.panelProfile.Controls.Add(this.lblPrifileTitle);
            this.panelProfile.Controls.Add(this.panelProfileInfo);
            this.panelProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProfile.Location = new System.Drawing.Point(0, 0);
            this.panelProfile.Name = "panelProfile";
            this.panelProfile.Size = new System.Drawing.Size(1024, 769);
            this.panelProfile.TabIndex = 11;
            // 
            // lblPrifileTitle
            // 
            this.lblPrifileTitle.Location = new System.Drawing.Point(30, 25);
            this.lblPrifileTitle.Name = "lblPrifileTitle";
            this.lblPrifileTitle.Size = new System.Drawing.Size(350, 40);
            this.lblPrifileTitle.TabIndex = 3;
            this.lblPrifileTitle.Text = "Мой профиль";
            // 
            // panelProfileInfo
            // 
            this.panelProfileInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProfileInfo.BackColor = System.Drawing.Color.White;
            this.panelProfileInfo.Controls.Add(this.dvgOrders);
            this.panelProfileInfo.Controls.Add(this.lblOrdersTitle);
            this.panelProfileInfo.Controls.Add(this.btnLogout);
            this.panelProfileInfo.Controls.Add(this.lblPersonalInfo);
            this.panelProfileInfo.Controls.Add(this.lblProfileName);
            this.panelProfileInfo.Controls.Add(this.lblProfileEmail);
            this.panelProfileInfo.Controls.Add(this.lblProfileRole);
            this.panelProfileInfo.Location = new System.Drawing.Point(30, 90);
            this.panelProfileInfo.Name = "panelProfileInfo";
            this.panelProfileInfo.Size = new System.Drawing.Size(870, 220);
            this.panelProfileInfo.TabIndex = 2;
            // 
            // dvgOrders
            // 
            this.dvgOrders.AllowUserToAddRows = false;
            this.dvgOrders.AllowUserToDeleteRows = false;
            this.dvgOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgOrders.BackgroundColor = System.Drawing.Color.White;
            this.dvgOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgOrders.Location = new System.Drawing.Point(30, 390);
            this.dvgOrders.Name = "dvgOrders";
            this.dvgOrders.ReadOnly = true;
            this.dvgOrders.RowHeadersVisible = false;
            this.dvgOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgOrders.Size = new System.Drawing.Size(870, 210);
            this.dvgOrders.TabIndex = 7;
            // 
            // lblOrdersTitle
            // 
            this.lblOrdersTitle.AutoSize = true;
            this.lblOrdersTitle.Location = new System.Drawing.Point(30, 340);
            this.lblOrdersTitle.Name = "lblOrdersTitle";
            this.lblOrdersTitle.Size = new System.Drawing.Size(103, 17);
            this.lblOrdersTitle.TabIndex = 6;
            this.lblOrdersTitle.Text = "Исторя заказов";
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(80)))), ((int)(((byte)(164)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(640, 155);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(190, 42);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Выйти из аккаунта";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblPersonalInfo
            // 
            this.lblPersonalInfo.Location = new System.Drawing.Point(20, 15);
            this.lblPersonalInfo.Name = "lblPersonalInfo";
            this.lblPersonalInfo.Size = new System.Drawing.Size(300, 35);
            this.lblPersonalInfo.TabIndex = 1;
            this.lblPersonalInfo.Text = "Личные данные";
            // 
            // lblProfileName
            // 
            this.lblProfileName.Location = new System.Drawing.Point(20, 65);
            this.lblProfileName.Name = "lblProfileName";
            this.lblProfileName.Size = new System.Drawing.Size(500, 28);
            this.lblProfileName.TabIndex = 2;
            this.lblProfileName.Text = "Имя: ";
            // 
            // lblProfileEmail
            // 
            this.lblProfileEmail.Location = new System.Drawing.Point(20, 105);
            this.lblProfileEmail.Name = "lblProfileEmail";
            this.lblProfileEmail.Size = new System.Drawing.Size(500, 28);
            this.lblProfileEmail.TabIndex = 3;
            this.lblProfileEmail.Text = "Email: ";
            // 
            // lblProfileRole
            // 
            this.lblProfileRole.Location = new System.Drawing.Point(20, 145);
            this.lblProfileRole.Name = "lblProfileRole";
            this.lblProfileRole.Size = new System.Drawing.Size(500, 28);
            this.lblProfileRole.TabIndex = 4;
            this.lblProfileRole.Text = "Роль: покупатель";
            // 
            // panelHome
            // 
            this.panelHome.Controls.Add(this.flowProducts);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHome.Location = new System.Drawing.Point(0, 0);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(1024, 769);
            this.panelHome.TabIndex = 10;
            // 
            // flowProducts
            // 
            this.flowProducts.AutoScroll = true;
            this.flowProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowProducts.Location = new System.Drawing.Point(0, 0);
            this.flowProducts.Name = "flowProducts";
            this.flowProducts.Padding = new System.Windows.Forms.Padding(12);
            this.flowProducts.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowProducts.Size = new System.Drawing.Size(1024, 769);
            this.flowProducts.TabIndex = 1;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1265, 864);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelSidebar);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1281, 903);
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WB - Каталог товаров";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.panelCategories.ResumeLayout(false);
            this.panelCategories.PerformLayout();
            this.flowCategories.ResumeLayout(false);
            this.panelFavorites.ResumeLayout(false);
            this.panelFavorites.PerformLayout();
            this.panelCart.ResumeLayout(false);
            this.panelCart.PerformLayout();
            this.panelCartSummary.ResumeLayout(false);
            this.panelCartSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCart)).EndInit();
            this.panelProfile.ResumeLayout(false);
            this.panelProfileInfo.ResumeLayout(false);
            this.panelProfileInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgOrders)).EndInit();
            this.panelHome.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Button btnFavorites;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnFilters;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelCatalog;
        private System.Windows.Forms.Panel panelCategories;
        private System.Windows.Forms.Panel panelFavorites;
        private System.Windows.Forms.Panel panelCart;
        private System.Windows.Forms.Panel panelProfile;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.FlowLayoutPanel flowProducts;
        private System.Windows.Forms.FlowLayoutPanel flowCategories;
        private System.Windows.Forms.Label lblCategoriesSubtitle;
        private System.Windows.Forms.Label lblCategoriesTitle;
        private System.Windows.Forms.Button btnElectronucs;
        private System.Windows.Forms.Button btnClothes;
        private System.Windows.Forms.Button btnShoes;
        private System.Windows.Forms.Button btnHomeGoods;
        private System.Windows.Forms.Label lblFavoritesSubtitle;
        private System.Windows.Forms.Label lblFavoritesTitle;
        private System.Windows.Forms.Label lblFavoritesEmpty;
        private System.Windows.Forms.FlowLayoutPanel flowFavorites;
        private System.Windows.Forms.DataGridView dvgCart;
        private System.Windows.Forms.Label lblCartSubtitle;
        private System.Windows.Forms.Label lblCartTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCartProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCartPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCartQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCartSum;
        private System.Windows.Forms.Button btnCartMinus;
        private System.Windows.Forms.Button btnCartRemove;
        private System.Windows.Forms.Button btnCartPlus;
        private System.Windows.Forms.Panel panelCartSummary;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Label lblOrderTitle;
        private System.Windows.Forms.Label lblCartCount;
        private System.Windows.Forms.Label lblCartTotal;
        private System.Windows.Forms.Panel panelProfileInfo;
        private System.Windows.Forms.Label lblPrifileTitle;
        private System.Windows.Forms.DataGridView dvgOrders;
        private System.Windows.Forms.Label lblOrdersTitle;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblPersonalInfo;
        private System.Windows.Forms.Label lblProfileName;
        private System.Windows.Forms.Label lblProfileEmail;
        private System.Windows.Forms.Label lblProfileRole;
    }
}