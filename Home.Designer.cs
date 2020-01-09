namespace Textile_Asia
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton23 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton16 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton18 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuSeparator4 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuFlatButton19 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton24 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton20 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton21 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton25 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton22 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton27 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton26 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.userControl11 = new Textile_Asia.UserControl1();
            this.bunifuTransition2 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox9);
            this.bunifuTransition2.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 42);
            this.panel1.TabIndex = 12;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = global::Textile_Asia.Properties.Resources.icons8_menu_filled_24;
            this.pictureBox2.Location = new System.Drawing.Point(15, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox9
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox9, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.pictureBox9, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox9.Image = global::Textile_Asia.Properties.Resources.Close1;
            this.pictureBox9.Location = new System.Drawing.Point(992, 6);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(30, 30);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox9.TabIndex = 3;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.panel1;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition1.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(158)))), ((int)(((byte)(227)))));
            this.panel3.Controls.Add(this.bunifuFlatButton23);
            this.panel3.Controls.Add(this.bunifuFlatButton16);
            this.panel3.Controls.Add(this.bunifuFlatButton18);
            this.panel3.Controls.Add(this.bunifuSeparator4);
            this.panel3.Controls.Add(this.bunifuSeparator3);
            this.panel3.Controls.Add(this.bunifuFlatButton19);
            this.panel3.Controls.Add(this.bunifuFlatButton24);
            this.panel3.Controls.Add(this.bunifuFlatButton20);
            this.panel3.Controls.Add(this.bunifuFlatButton21);
            this.panel3.Controls.Add(this.bunifuFlatButton25);
            this.panel3.Controls.Add(this.bunifuFlatButton22);
            this.panel3.Controls.Add(this.bunifuFlatButton27);
            this.panel3.Controls.Add(this.bunifuFlatButton26);
            this.bunifuTransition2.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(222, 669);
            this.panel3.TabIndex = 15;
            // 
            // bunifuFlatButton23
            // 
            this.bunifuFlatButton23.Activecolor = System.Drawing.Color.White;
            this.bunifuFlatButton23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(158)))), ((int)(((byte)(227)))));
            this.bunifuFlatButton23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuFlatButton23.BorderRadius = 0;
            this.bunifuFlatButton23.ButtonText = "           Speakers";
            this.bunifuFlatButton23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition2.SetDecoration(this.bunifuFlatButton23, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton23, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton23.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(158)))), ((int)(((byte)(227)))));
            this.bunifuFlatButton23.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton23.Iconimage = global::Textile_Asia.Properties.Resources.icons8_lecturer_30;
            this.bunifuFlatButton23.Iconimage_right = null;
            this.bunifuFlatButton23.Iconimage_right_Selected = null;
            this.bunifuFlatButton23.Iconimage_Selected = null;
            this.bunifuFlatButton23.IconMarginLeft = 0;
            this.bunifuFlatButton23.IconMarginRight = 0;
            this.bunifuFlatButton23.IconRightVisible = true;
            this.bunifuFlatButton23.IconRightZoom = 0D;
            this.bunifuFlatButton23.IconVisible = true;
            this.bunifuFlatButton23.IconZoom = 34D;
            this.bunifuFlatButton23.IsTab = false;
            this.bunifuFlatButton23.Location = new System.Drawing.Point(0, 246);
            this.bunifuFlatButton23.Name = "bunifuFlatButton23";
            this.bunifuFlatButton23.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(158)))), ((int)(((byte)(227)))));
            this.bunifuFlatButton23.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(190)))), ((int)(((byte)(225)))));
            this.bunifuFlatButton23.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton23.selected = false;
            this.bunifuFlatButton23.Size = new System.Drawing.Size(222, 48);
            this.bunifuFlatButton23.TabIndex = 26;
            this.bunifuFlatButton23.Text = "           Speakers";
            this.bunifuFlatButton23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton23.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton23.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton16
            // 
            this.bunifuFlatButton16.Activecolor = System.Drawing.Color.White;
            this.bunifuFlatButton16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(158)))), ((int)(((byte)(227)))));
            this.bunifuFlatButton16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuFlatButton16.BorderRadius = 0;
            this.bunifuFlatButton16.ButtonText = "           About";
            this.bunifuFlatButton16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition2.SetDecoration(this.bunifuFlatButton16, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton16, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton16.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(158)))), ((int)(((byte)(227)))));
            this.bunifuFlatButton16.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton16.Iconimage = global::Textile_Asia.Properties.Resources.icons8_about_35;
            this.bunifuFlatButton16.Iconimage_right = null;
            this.bunifuFlatButton16.Iconimage_right_Selected = null;
            this.bunifuFlatButton16.Iconimage_Selected = null;
            this.bunifuFlatButton16.IconMarginLeft = 0;
            this.bunifuFlatButton16.IconMarginRight = 0;
            this.bunifuFlatButton16.IconRightVisible = true;
            this.bunifuFlatButton16.IconRightZoom = 0D;
            this.bunifuFlatButton16.IconVisible = true;
            this.bunifuFlatButton16.IconZoom = 34D;
            this.bunifuFlatButton16.IsTab = false;
            this.bunifuFlatButton16.Location = new System.Drawing.Point(0, 548);
            this.bunifuFlatButton16.Name = "bunifuFlatButton16";
            this.bunifuFlatButton16.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(158)))), ((int)(((byte)(227)))));
            this.bunifuFlatButton16.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(190)))), ((int)(((byte)(225)))));
            this.bunifuFlatButton16.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton16.selected = false;
            this.bunifuFlatButton16.Size = new System.Drawing.Size(222, 48);
            this.bunifuFlatButton16.TabIndex = 20;
            this.bunifuFlatButton16.Text = "           About";
            this.bunifuFlatButton16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton16.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton16.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton18
            // 
            this.bunifuFlatButton18.Activecolor = System.Drawing.Color.White;
            this.bunifuFlatButton18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(158)))), ((int)(((byte)(227)))));
            this.bunifuFlatButton18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuFlatButton18.BorderRadius = 0;
            this.bunifuFlatButton18.ButtonText = "           Floor Plans";
            this.bunifuFlatButton18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition2.SetDecoration(this.bunifuFlatButton18, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton18, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton18.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(158)))), ((int)(((byte)(227)))));
            this.bunifuFlatButton18.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton18.Iconimage = global::Textile_Asia.Properties.Resources.icons8_floor_plan_filled_35;
            this.bunifuFlatButton18.Iconimage_right = null;
            this.bunifuFlatButton18.Iconimage_right_Selected = null;
            this.bunifuFlatButton18.Iconimage_Selected = null;
            this.bunifuFlatButton18.IconMarginLeft = 0;
            this.bunifuFlatButton18.IconMarginRight = 0;
            this.bunifuFlatButton18.IconRightVisible = true;
            this.bunifuFlatButton18.IconRightZoom = 0D;
            this.bunifuFlatButton18.IconVisible = true;
            this.bunifuFlatButton18.IconZoom = 34D;
            this.bunifuFlatButton18.IsTab = false;
            this.bunifuFlatButton18.Location = new System.Drawing.Point(0, 497);
            this.bunifuFlatButton18.Name = "bunifuFlatButton18";
            this.bunifuFlatButton18.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(158)))), ((int)(((byte)(227)))));
            this.bunifuFlatButton18.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(190)))), ((int)(((byte)(225)))));
            this.bunifuFlatButton18.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton18.selected = false;
            this.bunifuFlatButton18.Size = new System.Drawing.Size(222, 48);
            this.bunifuFlatButton18.TabIndex = 19;
            this.bunifuFlatButton18.Text = "           Floor Plans";
            this.bunifuFlatButton18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton18.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton18.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuSeparator4
            // 
            this.bunifuSeparator4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition2.SetDecoration(this.bunifuSeparator4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuSeparator4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator4.LineThickness = 1;
            this.bunifuSeparator4.Location = new System.Drawing.Point(0, 293);
            this.bunifuSeparator4.Margin = new System.Windows.Forms.Padding(1);
            this.bunifuSeparator4.Name = "bunifuSeparator4";
            this.bunifuSeparator4.Size = new System.Drawing.Size(222, 2);
            this.bunifuSeparator4.TabIndex = 21;
            this.bunifuSeparator4.Transparency = 255;
            this.bunifuSeparator4.Vertical = false;
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition2.SetDecoration(this.bunifuSeparator3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuSeparator3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(1, 444);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(222, 2);
            this.bunifuSeparator3.TabIndex = 18;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = false;
            // 
            // bunifuFlatButton19
            // 
            this.bunifuFlatButton19.Activecolor = System.Drawing.Color.White;
            this.bunifuFlatButton19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(158)))), ((int)(((byte)(227)))));
            this.bunifuFlatButton19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuFlatButton19.BorderRadius = 0;
            this.bunifuFlatButton19.ButtonText = "           My Schedule";
            this.bunifuFlatButton19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition2.SetDecoration(this.bunifuFlatButton19, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton19, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton19.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(158)))), ((int)(((byte)(227)))));
            this.bunifuFlatButton19.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton19.Iconimage = global::Textile_Asia.Properties.Resources.icons8_schedule_filled_35;
            this.bunifuFlatButton19.Iconimage_right = null;
            this.bunifuFlatButton19.Iconimage_right_Selected = null;
            this.bunifuFlatButton19.Iconimage_Selected = null;
            this.bunifuFlatButton19.IconMarginLeft = 0;
            this.bunifuFlatButton19.IconMarginRight = 0;
            this.bunifuFlatButton19.IconRightVisible = true;
            this.bunifuFlatButton19.IconRightZoom = 0D;
            this.bunifuFlatButton19.IconVisible = true;
            this.bunifuFlatButton19.IconZoom = 34D;
            this.bunifuFlatButton19.IsTab = false;
            this.bunifuFlatButton19.Location = new System.Drawing.Point(0, 446);
            this.bunifuFlatButton19.Name = "bunifuFlatButton19";
            this.bunifuFlatButton19.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(158)))), ((int)(((byte)(227)))));
            this.bunifuFlatButton19.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(190)))), ((int)(((byte)(225)))));
            this.bunifuFlatButton19.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton19.selected = false;
            this.bunifuFlatButton19.Size = new System.Drawing.Size(222, 48);
            this.bunifuFlatButton19.TabIndex = 17;
            this.bunifuFlatButton19.Text = "           My Schedule";
            this.bunifuFlatButton19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton19.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton19.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton24
            // 
            this.bunifuFlatButton24.Activecolor = System.Drawing.Color.White;
            this.bunifuFlatButton24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(158)))), ((int)(((byte)(227)))));
            this.bunifuFlatButton24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuFlatButton24.BorderRadius = 0;
            this.bunifuFlatButton24.ButtonText = "           Conferences";
            this.bunifuFlatButton24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition2.SetDecoration(this.bunifuFlatButton24, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton24, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton24.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(158)))), ((int)(((byte)(227)))));
            this.bunifuFlatButton24.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton24.Iconimage = global::Textile_Asia.Properties.Resources.icons8_conference_filled_35;
            this.bunifuFlatButton24.Iconimage_right = null;
            this.bunifuFlatButton24.Iconimage_right_Selected = null;
            this.bunifuFlatButton24.Iconimage_Selected = null;
            this.bunifuFlatButton24.IconMarginLeft = 0;
            this.bunifuFlatButton24.IconMarginRight = 0;
            this.bunifuFlatButton24.IconRightVisible = true;
            this.bunifuFlatButton24.IconRightZoom = 0D;
            this.bunifuFlatButton24.IconVisible = true;
            this.bunifuFlatButton24.IconZoom = 34D;
            this.bunifuFlatButton24.IsTab = false;
            this.bunifuFlatButton24.Location = new System.Drawing.Point(0, 195);
            this.bunifuFlatButton24.Name = "bunifuFlatButton24";
            this.bunifuFlatButton24.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(158)))), ((int)(((byte)(227)))));
            this.bunifuFlatButton24.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(190)))), ((int)(((byte)(225)))));
            this.bunifuFlatButton24.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton24.selected = false;
            this.bunifuFlatButton24.Size = new System.Drawing.Size(222, 48);
            this.bunifuFlatButton24.TabIndex = 25;
            this.bunifuFlatButton24.Text = "           Conferences";
            this.bunifuFlatButton24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton24.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton24.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton20
            // 
            this.bunifuFlatButton20.Activecolor = System.Drawing.Color.White;
            this.bunifuFlatButton20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(158)))), ((int)(((byte)(227)))));
            this.bunifuFlatButton20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuFlatButton20.BorderRadius = 0;
            this.bunifuFlatButton20.ButtonText = "           Gallery";
            this.bunifuFlatButton20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition2.SetDecoration(this.bunifuFlatButton20, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton20, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton20.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(158)))), ((int)(((byte)(227)))));
            this.bunifuFlatButton20.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton20.Iconimage = global::Textile_Asia.Properties.Resources.icons8_picture_35;
            this.bunifuFlatButton20.Iconimage_right = null;
            this.bunifuFlatButton20.Iconimage_right_Selected = null;
            this.bunifuFlatButton20.Iconimage_Selected = null;
            this.bunifuFlatButton20.IconMarginLeft = 0;
            this.bunifuFlatButton20.IconMarginRight = 0;
            this.bunifuFlatButton20.IconRightVisible = true;
            this.bunifuFlatButton20.IconRightZoom = 0D;
            this.bunifuFlatButton20.IconVisible = true;
            this.bunifuFlatButton20.IconZoom = 34D;
            this.bunifuFlatButton20.IsTab = false;
            this.bunifuFlatButton20.Location = new System.Drawing.Point(0, 397);
            this.bunifuFlatButton20.Name = "bunifuFlatButton20";
            this.bunifuFlatButton20.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(158)))), ((int)(((byte)(227)))));
            this.bunifuFlatButton20.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(190)))), ((int)(((byte)(225)))));
            this.bunifuFlatButton20.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton20.selected = false;
            this.bunifuFlatButton20.Size = new System.Drawing.Size(222, 48);
            this.bunifuFlatButton20.TabIndex = 16;
            this.bunifuFlatButton20.Text = "           Gallery";
            this.bunifuFlatButton20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton20.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton20.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton21
            // 
            this.bunifuFlatButton21.Activecolor = System.Drawing.Color.White;
            this.bunifuFlatButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(158)))), ((int)(((byte)(227)))));
            this.bunifuFlatButton21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuFlatButton21.BorderRadius = 0;
            this.bunifuFlatButton21.ButtonText = "           Social Media";
            this.bunifuFlatButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition2.SetDecoration(this.bunifuFlatButton21, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton21, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton21.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(158)))), ((int)(((byte)(227)))));
            this.bunifuFlatButton21.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton21.Iconimage = global::Textile_Asia.Properties.Resources.icons8_share_filled_35;
            this.bunifuFlatButton21.Iconimage_right = null;
            this.bunifuFlatButton21.Iconimage_right_Selected = null;
            this.bunifuFlatButton21.Iconimage_Selected = null;
            this.bunifuFlatButton21.IconMarginLeft = 0;
            this.bunifuFlatButton21.IconMarginRight = 0;
            this.bunifuFlatButton21.IconRightVisible = true;
            this.bunifuFlatButton21.IconRightZoom = 0D;
            this.bunifuFlatButton21.IconVisible = true;
            this.bunifuFlatButton21.IconZoom = 34D;
            this.bunifuFlatButton21.IsTab = false;
            this.bunifuFlatButton21.Location = new System.Drawing.Point(0, 346);
            this.bunifuFlatButton21.Name = "bunifuFlatButton21";
            this.bunifuFlatButton21.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(158)))), ((int)(((byte)(227)))));
            this.bunifuFlatButton21.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(190)))), ((int)(((byte)(225)))));
            this.bunifuFlatButton21.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton21.selected = false;
            this.bunifuFlatButton21.Size = new System.Drawing.Size(222, 48);
            this.bunifuFlatButton21.TabIndex = 15;
            this.bunifuFlatButton21.Text = "           Social Media";
            this.bunifuFlatButton21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton21.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton21.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton25
            // 
            this.bunifuFlatButton25.Activecolor = System.Drawing.Color.White;
            this.bunifuFlatButton25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(158)))), ((int)(((byte)(227)))));
            this.bunifuFlatButton25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuFlatButton25.BorderRadius = 0;
            this.bunifuFlatButton25.ButtonText = "           Exhibitors";
            this.bunifuFlatButton25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition2.SetDecoration(this.bunifuFlatButton25, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton25, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton25.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(158)))), ((int)(((byte)(227)))));
            this.bunifuFlatButton25.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton25.Iconimage = global::Textile_Asia.Properties.Resources.icons8_handshake_35;
            this.bunifuFlatButton25.Iconimage_right = null;
            this.bunifuFlatButton25.Iconimage_right_Selected = null;
            this.bunifuFlatButton25.Iconimage_Selected = null;
            this.bunifuFlatButton25.IconMarginLeft = 0;
            this.bunifuFlatButton25.IconMarginRight = 0;
            this.bunifuFlatButton25.IconRightVisible = true;
            this.bunifuFlatButton25.IconRightZoom = 0D;
            this.bunifuFlatButton25.IconVisible = true;
            this.bunifuFlatButton25.IconZoom = 34D;
            this.bunifuFlatButton25.IsTab = false;
            this.bunifuFlatButton25.Location = new System.Drawing.Point(0, 144);
            this.bunifuFlatButton25.Name = "bunifuFlatButton25";
            this.bunifuFlatButton25.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(158)))), ((int)(((byte)(227)))));
            this.bunifuFlatButton25.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(190)))), ((int)(((byte)(225)))));
            this.bunifuFlatButton25.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton25.selected = false;
            this.bunifuFlatButton25.Size = new System.Drawing.Size(222, 48);
            this.bunifuFlatButton25.TabIndex = 24;
            this.bunifuFlatButton25.Text = "           Exhibitors";
            this.bunifuFlatButton25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton25.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton25.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton22
            // 
            this.bunifuFlatButton22.Activecolor = System.Drawing.Color.White;
            this.bunifuFlatButton22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(158)))), ((int)(((byte)(227)))));
            this.bunifuFlatButton22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuFlatButton22.BorderRadius = 0;
            this.bunifuFlatButton22.ButtonText = "           Registration";
            this.bunifuFlatButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition2.SetDecoration(this.bunifuFlatButton22, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton22, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton22.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(158)))), ((int)(((byte)(227)))));
            this.bunifuFlatButton22.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton22.Iconimage = global::Textile_Asia.Properties.Resources.icons8_registration_35;
            this.bunifuFlatButton22.Iconimage_right = null;
            this.bunifuFlatButton22.Iconimage_right_Selected = null;
            this.bunifuFlatButton22.Iconimage_Selected = null;
            this.bunifuFlatButton22.IconMarginLeft = 0;
            this.bunifuFlatButton22.IconMarginRight = 0;
            this.bunifuFlatButton22.IconRightVisible = true;
            this.bunifuFlatButton22.IconRightZoom = 0D;
            this.bunifuFlatButton22.IconVisible = true;
            this.bunifuFlatButton22.IconZoom = 34D;
            this.bunifuFlatButton22.IsTab = false;
            this.bunifuFlatButton22.Location = new System.Drawing.Point(0, 295);
            this.bunifuFlatButton22.Name = "bunifuFlatButton22";
            this.bunifuFlatButton22.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(158)))), ((int)(((byte)(227)))));
            this.bunifuFlatButton22.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(190)))), ((int)(((byte)(225)))));
            this.bunifuFlatButton22.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton22.selected = false;
            this.bunifuFlatButton22.Size = new System.Drawing.Size(222, 48);
            this.bunifuFlatButton22.TabIndex = 14;
            this.bunifuFlatButton22.Text = "           Registration";
            this.bunifuFlatButton22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton22.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton22.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton27
            // 
            this.bunifuFlatButton27.Activecolor = System.Drawing.Color.White;
            this.bunifuFlatButton27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(158)))), ((int)(((byte)(227)))));
            this.bunifuFlatButton27.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuFlatButton27.BorderRadius = 0;
            this.bunifuFlatButton27.ButtonText = "           Home";
            this.bunifuFlatButton27.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition2.SetDecoration(this.bunifuFlatButton27, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton27, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton27.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(158)))), ((int)(((byte)(227)))));
            this.bunifuFlatButton27.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton27.Iconimage = global::Textile_Asia.Properties.Resources.icons8_home_30__1_;
            this.bunifuFlatButton27.Iconimage_right = null;
            this.bunifuFlatButton27.Iconimage_right_Selected = null;
            this.bunifuFlatButton27.Iconimage_Selected = null;
            this.bunifuFlatButton27.IconMarginLeft = 0;
            this.bunifuFlatButton27.IconMarginRight = 0;
            this.bunifuFlatButton27.IconRightVisible = true;
            this.bunifuFlatButton27.IconRightZoom = 0D;
            this.bunifuFlatButton27.IconVisible = true;
            this.bunifuFlatButton27.IconZoom = 32D;
            this.bunifuFlatButton27.IsTab = false;
            this.bunifuFlatButton27.Location = new System.Drawing.Point(0, 42);
            this.bunifuFlatButton27.Name = "bunifuFlatButton27";
            this.bunifuFlatButton27.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(158)))), ((int)(((byte)(227)))));
            this.bunifuFlatButton27.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(190)))), ((int)(((byte)(225)))));
            this.bunifuFlatButton27.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton27.selected = false;
            this.bunifuFlatButton27.Size = new System.Drawing.Size(222, 48);
            this.bunifuFlatButton27.TabIndex = 22;
            this.bunifuFlatButton27.Text = "           Home";
            this.bunifuFlatButton27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton27.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton27.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton27.Click += new System.EventHandler(this.bunifuFlatButton27_Click);
            // 
            // bunifuFlatButton26
            // 
            this.bunifuFlatButton26.Activecolor = System.Drawing.Color.White;
            this.bunifuFlatButton26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(158)))), ((int)(((byte)(227)))));
            this.bunifuFlatButton26.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuFlatButton26.BorderRadius = 0;
            this.bunifuFlatButton26.ButtonText = "           The Event";
            this.bunifuFlatButton26.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition2.SetDecoration(this.bunifuFlatButton26, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton26, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton26.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(158)))), ((int)(((byte)(227)))));
            this.bunifuFlatButton26.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton26.Iconimage = global::Textile_Asia.Properties.Resources.icons8_event_filled_30;
            this.bunifuFlatButton26.Iconimage_right = null;
            this.bunifuFlatButton26.Iconimage_right_Selected = null;
            this.bunifuFlatButton26.Iconimage_Selected = null;
            this.bunifuFlatButton26.IconMarginLeft = 0;
            this.bunifuFlatButton26.IconMarginRight = 0;
            this.bunifuFlatButton26.IconRightVisible = true;
            this.bunifuFlatButton26.IconRightZoom = 0D;
            this.bunifuFlatButton26.IconVisible = true;
            this.bunifuFlatButton26.IconZoom = 34D;
            this.bunifuFlatButton26.IsTab = false;
            this.bunifuFlatButton26.Location = new System.Drawing.Point(0, 93);
            this.bunifuFlatButton26.Name = "bunifuFlatButton26";
            this.bunifuFlatButton26.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(158)))), ((int)(((byte)(227)))));
            this.bunifuFlatButton26.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(190)))), ((int)(((byte)(225)))));
            this.bunifuFlatButton26.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton26.selected = false;
            this.bunifuFlatButton26.Size = new System.Drawing.Size(222, 48);
            this.bunifuFlatButton26.TabIndex = 23;
            this.bunifuFlatButton26.Text = "           The Event";
            this.bunifuFlatButton26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton26.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton26.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.Color.AliceBlue;
            this.bunifuTransition1.SetDecoration(this.userControl11, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.userControl11, BunifuAnimatorNS.DecorationType.None);
            this.userControl11.Location = new System.Drawing.Point(314, 61);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(521, 558);
            this.userControl11.TabIndex = 13;
            this.userControl11.Load += new System.EventHandler(this.userControl11_Load_1);
            // 
            // bunifuTransition2
            // 
            this.bunifuTransition2.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.bunifuTransition2.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 1F;
            this.bunifuTransition2.DefaultAnimation = animation4;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1024, 711);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.panel1);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox9;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private UserControl1 userControl11;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton23;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton16;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton18;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator4;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton19;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton24;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton20;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton21;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton25;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton22;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton27;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton26;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition2;
    }
}