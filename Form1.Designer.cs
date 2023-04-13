namespace Drawing
{
    partial class Form1
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.btnBY = new System.Windows.Forms.Button();
            this.btnChooseColor = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.tbPenThickness = new System.Windows.Forms.TextBox();
            this.btnPenThickness = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnRectan = new System.Windows.Forms.Button();
            this.btnFill = new System.Windows.Forms.Button();
            this.btnPen = new System.Windows.Forms.Button();
            this.btnEraser = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnColor3 = new System.Windows.Forms.Button();
            this.btnColor2 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Choose_an_object = new System.Windows.Forms.Label();
            this.Choose_end_point = new System.Windows.Forms.Label();
            this.lbScope = new System.Windows.Forms.Label();
            this.lbArea = new System.Windows.Forms.Label();
            this.canvasPic = new System.Windows.Forms.PictureBox();
            this.gbAnimate = new System.Windows.Forms.GroupBox();
            this.btnRightAnimate = new System.Windows.Forms.Button();
            this.btnLeftAnimate = new System.Windows.Forms.Button();
            this.btnBottomAnimate = new System.Windows.Forms.Button();
            this.btnTopAnimate = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvasPic)).BeginInit();
            this.gbAnimate.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.topPanel.Controls.Add(this.btnBY);
            this.topPanel.Controls.Add(this.btnChooseColor);
            this.topPanel.Controls.Add(this.btnLoad);
            this.topPanel.Controls.Add(this.btnDelete);
            this.topPanel.Controls.Add(this.btnOK);
            this.topPanel.Controls.Add(this.tbPenThickness);
            this.topPanel.Controls.Add(this.btnPenThickness);
            this.topPanel.Controls.Add(this.btnSquare);
            this.topPanel.Controls.Add(this.btnLine);
            this.topPanel.Controls.Add(this.btnClear);
            this.topPanel.Controls.Add(this.btnCircle);
            this.topPanel.Controls.Add(this.btnRectan);
            this.topPanel.Controls.Add(this.btnFill);
            this.topPanel.Controls.Add(this.btnPen);
            this.topPanel.Controls.Add(this.btnEraser);
            this.topPanel.Controls.Add(this.btnMove);
            this.topPanel.Controls.Add(this.btnColor);
            this.topPanel.Controls.Add(this.btnSave);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1308, 82);
            this.topPanel.TabIndex = 0;
            // 
            // btnBY
            // 
            this.btnBY.BackColor = System.Drawing.Color.GhostWhite;
            this.btnBY.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBY.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBY.FlatAppearance.BorderSize = 2;
            this.btnBY.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnBY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBY.ForeColor = System.Drawing.Color.Black;
            this.btnBY.Location = new System.Drawing.Point(417, 16);
            this.btnBY.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBY.Name = "btnBY";
            this.btnBY.Size = new System.Drawing.Size(77, 55);
            this.btnBY.TabIndex = 20;
            this.btnBY.Text = "BY BY";
            this.btnBY.UseVisualStyleBackColor = false;
            this.btnBY.Click += new System.EventHandler(this.btnAnimate_Click);
            // 
            // btnChooseColor
            // 
            this.btnChooseColor.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnChooseColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChooseColor.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.btnChooseColor.FlatAppearance.BorderSize = 2;
            this.btnChooseColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseColor.ForeColor = System.Drawing.Color.Black;
            this.btnChooseColor.Image = global::Drawing.Properties.Resources.icons8_color_wheel_50;
            this.btnChooseColor.Location = new System.Drawing.Point(857, 15);
            this.btnChooseColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChooseColor.Name = "btnChooseColor";
            this.btnChooseColor.Size = new System.Drawing.Size(67, 57);
            this.btnChooseColor.TabIndex = 19;
            this.btnChooseColor.UseVisualStyleBackColor = false;
            this.btnChooseColor.Click += new System.EventHandler(this.btnChooseColor_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.GhostWhite;
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.FlatAppearance.BorderSize = 2;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLoad.Location = new System.Drawing.Point(1164, 7);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(67, 32);
            this.btnLoad.TabIndex = 18;
            this.btnLoad.Text = "Load";
            this.btnLoad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.GhostWhite;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.FlatAppearance.BorderSize = 2;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(503, 16);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(77, 55);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.GhostWhite;
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Location = new System.Drawing.Point(1095, 48);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(43, 28);
            this.btnOK.TabIndex = 16;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Visible = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tbPenThickness
            // 
            this.tbPenThickness.BackColor = System.Drawing.Color.GhostWhite;
            this.tbPenThickness.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPenThickness.Location = new System.Drawing.Point(1080, 14);
            this.tbPenThickness.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPenThickness.Name = "tbPenThickness";
            this.tbPenThickness.Size = new System.Drawing.Size(73, 22);
            this.tbPenThickness.TabIndex = 15;
            this.tbPenThickness.Text = "Pen size...";
            this.tbPenThickness.Visible = false;
            // 
            // btnPenThickness
            // 
            this.btnPenThickness.BackColor = System.Drawing.Color.GhostWhite;
            this.btnPenThickness.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPenThickness.FlatAppearance.BorderSize = 2;
            this.btnPenThickness.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPenThickness.ForeColor = System.Drawing.Color.Black;
            this.btnPenThickness.Image = global::Drawing.Properties.Resources.icons8_line_width_31;
            this.btnPenThickness.Location = new System.Drawing.Point(1012, 23);
            this.btnPenThickness.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPenThickness.Name = "btnPenThickness";
            this.btnPenThickness.Size = new System.Drawing.Size(51, 44);
            this.btnPenThickness.TabIndex = 14;
            this.btnPenThickness.UseVisualStyleBackColor = false;
            this.btnPenThickness.Click += new System.EventHandler(this.btnPenThickness_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.BackColor = System.Drawing.Color.GhostWhite;
            this.btnSquare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSquare.FlatAppearance.BorderSize = 2;
            this.btnSquare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSquare.ForeColor = System.Drawing.Color.Black;
            this.btnSquare.Image = global::Drawing.Properties.Resources.icons8_maximize_button_50;
            this.btnSquare.Location = new System.Drawing.Point(9, 15);
            this.btnSquare.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(67, 55);
            this.btnSquare.TabIndex = 13;
            this.btnSquare.UseVisualStyleBackColor = false;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnLine
            // 
            this.btnLine.BackColor = System.Drawing.Color.GhostWhite;
            this.btnLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLine.FlatAppearance.BorderSize = 2;
            this.btnLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLine.Image = global::Drawing.Properties.Resources.icons8_line_40;
            this.btnLine.Location = new System.Drawing.Point(240, 15);
            this.btnLine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(67, 55);
            this.btnLine.TabIndex = 12;
            this.btnLine.UseVisualStyleBackColor = false;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.GhostWhite;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 2;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClear.Location = new System.Drawing.Point(1164, 43);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(67, 32);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.BackColor = System.Drawing.Color.GhostWhite;
            this.btnCircle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCircle.FlatAppearance.BorderSize = 2;
            this.btnCircle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCircle.ForeColor = System.Drawing.Color.Black;
            this.btnCircle.Image = global::Drawing.Properties.Resources.icons8_circle_40;
            this.btnCircle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCircle.Location = new System.Drawing.Point(165, 15);
            this.btnCircle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(67, 55);
            this.btnCircle.TabIndex = 10;
            this.btnCircle.UseVisualStyleBackColor = false;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnRectan
            // 
            this.btnRectan.BackColor = System.Drawing.Color.GhostWhite;
            this.btnRectan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRectan.FlatAppearance.BorderSize = 2;
            this.btnRectan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRectan.ForeColor = System.Drawing.Color.Black;
            this.btnRectan.Image = global::Drawing.Properties.Resources.icons8_rectangular_50;
            this.btnRectan.Location = new System.Drawing.Point(84, 15);
            this.btnRectan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRectan.Name = "btnRectan";
            this.btnRectan.Size = new System.Drawing.Size(73, 55);
            this.btnRectan.TabIndex = 9;
            this.btnRectan.UseVisualStyleBackColor = false;
            this.btnRectan.Click += new System.EventHandler(this.btnRectan_Click);
            // 
            // btnFill
            // 
            this.btnFill.BackColor = System.Drawing.Color.GhostWhite;
            this.btnFill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFill.FlatAppearance.BorderSize = 2;
            this.btnFill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnFill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFill.Image = global::Drawing.Properties.Resources.fill;
            this.btnFill.Location = new System.Drawing.Point(692, 15);
            this.btnFill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(67, 55);
            this.btnFill.TabIndex = 0;
            this.btnFill.UseVisualStyleBackColor = false;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // btnPen
            // 
            this.btnPen.BackColor = System.Drawing.Color.GhostWhite;
            this.btnPen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPen.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPen.FlatAppearance.BorderSize = 2;
            this.btnPen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPen.ForeColor = System.Drawing.Color.Black;
            this.btnPen.Image = global::Drawing.Properties.Resources.draw;
            this.btnPen.Location = new System.Drawing.Point(767, 15);
            this.btnPen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPen.Name = "btnPen";
            this.btnPen.Size = new System.Drawing.Size(64, 55);
            this.btnPen.TabIndex = 8;
            this.btnPen.UseVisualStyleBackColor = false;
            this.btnPen.Click += new System.EventHandler(this.btnPen_Click);
            // 
            // btnEraser
            // 
            this.btnEraser.BackColor = System.Drawing.Color.GhostWhite;
            this.btnEraser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEraser.FlatAppearance.BorderSize = 2;
            this.btnEraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEraser.ForeColor = System.Drawing.Color.Black;
            this.btnEraser.Image = global::Drawing.Properties.Resources.icons8_erase_38;
            this.btnEraser.Location = new System.Drawing.Point(620, 15);
            this.btnEraser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEraser.Name = "btnEraser";
            this.btnEraser.Size = new System.Drawing.Size(64, 55);
            this.btnEraser.TabIndex = 7;
            this.btnEraser.UseVisualStyleBackColor = false;
            this.btnEraser.Click += new System.EventHandler(this.btnEraser_Click);
            // 
            // btnMove
            // 
            this.btnMove.BackColor = System.Drawing.Color.GhostWhite;
            this.btnMove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMove.FlatAppearance.BorderSize = 2;
            this.btnMove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMove.Location = new System.Drawing.Point(332, 15);
            this.btnMove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(77, 55);
            this.btnMove.TabIndex = 2;
            this.btnMove.Text = "Move";
            this.btnMove.UseVisualStyleBackColor = false;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.Black;
            this.btnColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColor.FlatAppearance.BorderColor = System.Drawing.Color.GhostWhite;
            this.btnColor.FlatAppearance.BorderSize = 2;
            this.btnColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor.ForeColor = System.Drawing.Color.Black;
            this.btnColor.Location = new System.Drawing.Point(945, 30);
            this.btnColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(35, 32);
            this.btnColor.TabIndex = 1;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.GhostWhite;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Image = global::Drawing.Properties.Resources.save_file_30;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.Location = new System.Drawing.Point(1239, 7);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(59, 69);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnColor3
            // 
            this.btnColor3.Location = new System.Drawing.Point(0, 0);
            this.btnColor3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnColor3.Name = "btnColor3";
            this.btnColor3.Size = new System.Drawing.Size(100, 28);
            this.btnColor3.TabIndex = 19;
            // 
            // btnColor2
            // 
            this.btnColor2.Location = new System.Drawing.Point(0, 0);
            this.btnColor2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnColor2.Name = "btnColor2";
            this.btnColor2.Size = new System.Drawing.Size(100, 28);
            this.btnColor2.TabIndex = 20;
            // 
            // Choose_an_object
            // 
            this.Choose_an_object.AutoSize = true;
            this.Choose_an_object.BackColor = System.Drawing.Color.MediumPurple;
            this.Choose_an_object.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Choose_an_object.Location = new System.Drawing.Point(564, 103);
            this.Choose_an_object.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Choose_an_object.Name = "Choose_an_object";
            this.Choose_an_object.Size = new System.Drawing.Size(112, 16);
            this.Choose_an_object.TabIndex = 15;
            this.Choose_an_object.Text = "Choose an object";
            this.Choose_an_object.Visible = false;
            // 
            // Choose_end_point
            // 
            this.Choose_end_point.AutoSize = true;
            this.Choose_end_point.BackColor = System.Drawing.Color.DarkViolet;
            this.Choose_end_point.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Choose_end_point.Location = new System.Drawing.Point(564, 103);
            this.Choose_end_point.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Choose_end_point.Name = "Choose_end_point";
            this.Choose_end_point.Size = new System.Drawing.Size(112, 16);
            this.Choose_end_point.TabIndex = 16;
            this.Choose_end_point.Text = "Choose end point";
            this.Choose_end_point.Visible = false;
            // 
            // lbScope
            // 
            this.lbScope.AutoSize = true;
            this.lbScope.BackColor = System.Drawing.Color.Silver;
            this.lbScope.ForeColor = System.Drawing.Color.Black;
            this.lbScope.Location = new System.Drawing.Point(1076, 103);
            this.lbScope.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbScope.Name = "lbScope";
            this.lbScope.Size = new System.Drawing.Size(60, 16);
            this.lbScope.TabIndex = 17;
            this.lbScope.Text = "Scope = ";
            // 
            // lbArea
            // 
            this.lbArea.AutoSize = true;
            this.lbArea.BackColor = System.Drawing.Color.Silver;
            this.lbArea.ForeColor = System.Drawing.Color.Black;
            this.lbArea.Location = new System.Drawing.Point(1075, 140);
            this.lbArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbArea.Name = "lbArea";
            this.lbArea.Size = new System.Drawing.Size(49, 16);
            this.lbArea.TabIndex = 18;
            this.lbArea.Text = "Area = ";
            // 
            // canvasPic
            // 
            this.canvasPic.BackColor = System.Drawing.Color.White;
            this.canvasPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvasPic.Location = new System.Drawing.Point(0, 82);
            this.canvasPic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.canvasPic.Name = "canvasPic";
            this.canvasPic.Size = new System.Drawing.Size(1308, 509);
            this.canvasPic.TabIndex = 1;
            this.canvasPic.TabStop = false;
            this.canvasPic.Paint += new System.Windows.Forms.PaintEventHandler(this.canvasPic_Paint);
            this.canvasPic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.canvasPic_MouseClick);
            this.canvasPic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvasPic_MouseDown);
            this.canvasPic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvasPic_MouseMove);
            this.canvasPic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvasPic_MouseUp);
            // 
            // gbAnimate
            // 
            this.gbAnimate.BackColor = System.Drawing.Color.Silver;
            this.gbAnimate.Controls.Add(this.btnRightAnimate);
            this.gbAnimate.Controls.Add(this.btnLeftAnimate);
            this.gbAnimate.Controls.Add(this.btnBottomAnimate);
            this.gbAnimate.Controls.Add(this.btnTopAnimate);
            this.gbAnimate.Location = new System.Drawing.Point(1076, 212);
            this.gbAnimate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbAnimate.Name = "gbAnimate";
            this.gbAnimate.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbAnimate.Size = new System.Drawing.Size(140, 198);
            this.gbAnimate.TabIndex = 21;
            this.gbAnimate.TabStop = false;
            this.gbAnimate.Text = "Option Animation";
            this.gbAnimate.Visible = false;
            // 
            // btnRightAnimate
            // 
            this.btnRightAnimate.BackColor = System.Drawing.Color.GhostWhite;
            this.btnRightAnimate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRightAnimate.FlatAppearance.BorderSize = 2;
            this.btnRightAnimate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRightAnimate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRightAnimate.Location = new System.Drawing.Point(31, 159);
            this.btnRightAnimate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRightAnimate.Name = "btnRightAnimate";
            this.btnRightAnimate.Size = new System.Drawing.Size(83, 32);
            this.btnRightAnimate.TabIndex = 22;
            this.btnRightAnimate.Text = "Right";
            this.btnRightAnimate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRightAnimate.UseVisualStyleBackColor = false;
            this.btnRightAnimate.Visible = false;
            this.btnRightAnimate.Click += new System.EventHandler(this.btnRightAnimate_Click);
            // 
            // btnLeftAnimate
            // 
            this.btnLeftAnimate.BackColor = System.Drawing.Color.GhostWhite;
            this.btnLeftAnimate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLeftAnimate.FlatAppearance.BorderSize = 2;
            this.btnLeftAnimate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeftAnimate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLeftAnimate.Location = new System.Drawing.Point(31, 119);
            this.btnLeftAnimate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLeftAnimate.Name = "btnLeftAnimate";
            this.btnLeftAnimate.Size = new System.Drawing.Size(83, 32);
            this.btnLeftAnimate.TabIndex = 21;
            this.btnLeftAnimate.Text = "Left";
            this.btnLeftAnimate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLeftAnimate.UseVisualStyleBackColor = false;
            this.btnLeftAnimate.Visible = false;
            this.btnLeftAnimate.Click += new System.EventHandler(this.btnLeftAnimate_Click);
            // 
            // btnBottomAnimate
            // 
            this.btnBottomAnimate.BackColor = System.Drawing.Color.GhostWhite;
            this.btnBottomAnimate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBottomAnimate.FlatAppearance.BorderSize = 2;
            this.btnBottomAnimate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBottomAnimate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBottomAnimate.Location = new System.Drawing.Point(31, 80);
            this.btnBottomAnimate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBottomAnimate.Name = "btnBottomAnimate";
            this.btnBottomAnimate.Size = new System.Drawing.Size(83, 32);
            this.btnBottomAnimate.TabIndex = 20;
            this.btnBottomAnimate.Text = "Bottom";
            this.btnBottomAnimate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBottomAnimate.UseVisualStyleBackColor = false;
            this.btnBottomAnimate.Visible = false;
            this.btnBottomAnimate.Click += new System.EventHandler(this.btnBottomAnimate_Click);
            // 
            // btnTopAnimate
            // 
            this.btnTopAnimate.BackColor = System.Drawing.Color.GhostWhite;
            this.btnTopAnimate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTopAnimate.FlatAppearance.BorderSize = 2;
            this.btnTopAnimate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopAnimate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTopAnimate.Location = new System.Drawing.Point(31, 41);
            this.btnTopAnimate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTopAnimate.Name = "btnTopAnimate";
            this.btnTopAnimate.Size = new System.Drawing.Size(83, 32);
            this.btnTopAnimate.TabIndex = 19;
            this.btnTopAnimate.Text = "Top";
            this.btnTopAnimate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTopAnimate.UseVisualStyleBackColor = false;
            this.btnTopAnimate.Visible = false;
            this.btnTopAnimate.Click += new System.EventHandler(this.btnTopAnimate_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 591);
            this.Controls.Add(this.gbAnimate);
            this.Controls.Add(this.lbArea);
            this.Controls.Add(this.lbScope);
            this.Controls.Add(this.Choose_end_point);
            this.Controls.Add(this.Choose_an_object);
            this.Controls.Add(this.canvasPic);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.btnColor3);
            this.Controls.Add(this.btnColor2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Drawing App";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvasPic)).EndInit();
            this.gbAnimate.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnColor3;
        private System.Windows.Forms.Button btnColor2;
        private System.Windows.Forms.Button btnEraser;
        private System.Windows.Forms.Button btnPen;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnRectan;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.PictureBox canvasPic;
        private System.Windows.Forms.Label Choose_an_object;
        private System.Windows.Forms.Label Choose_end_point;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Label lbScope;
        private System.Windows.Forms.Label lbArea;
        private System.Windows.Forms.Button btnPenThickness;
        private System.Windows.Forms.TextBox tbPenThickness;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnChooseColor;
        private System.Windows.Forms.GroupBox gbAnimate;
        private System.Windows.Forms.Button btnRightAnimate;
        private System.Windows.Forms.Button btnLeftAnimate;
        private System.Windows.Forms.Button btnBottomAnimate;
        private System.Windows.Forms.Button btnTopAnimate;
        private System.Windows.Forms.Button btnBY;
        private System.Windows.Forms.Timer timer1;
    }
}

