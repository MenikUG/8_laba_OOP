namespace _8_laba_OOP
{
    partial class laba8
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Узел0");
            this.panel_drawing = new System.Windows.Forms.Panel();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.menu = new System.Windows.Forms.ToolStrip();
            this.drawellipse = new System.Windows.Forms.ToolStripButton();
            this.drawsquare = new System.Windows.Forms.ToolStripButton();
            this.drawline = new System.Windows.Forms.ToolStripButton();
            this.Clear = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_select_color = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btn_group = new System.Windows.Forms.Button();
            this.btn_ungroup = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btn_sticky = new System.Windows.Forms.Button();
            this.panel_drawing.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_drawing
            // 
            this.panel_drawing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_drawing.BackColor = System.Drawing.SystemColors.Info;
            this.panel_drawing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_drawing.Controls.Add(this.btn_sticky);
            this.panel_drawing.Location = new System.Drawing.Point(12, 12);
            this.panel_drawing.Name = "panel_drawing";
            this.panel_drawing.Size = new System.Drawing.Size(626, 539);
            this.panel_drawing.TabIndex = 0;
            this.panel_drawing.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_drawing_MouseClick);
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(150, 451);
            // 
            // menu
            // 
            this.menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.menu.AutoSize = false;
            this.menu.Dock = System.Windows.Forms.DockStyle.None;
            this.menu.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drawellipse,
            this.drawsquare,
            this.drawline,
            this.Clear});
            this.menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menu.Location = new System.Drawing.Point(650, 87);
            this.menu.Name = "menu";
            this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menu.Size = new System.Drawing.Size(124, 122);
            this.menu.TabIndex = 0;
            this.menu.Text = "Меню";
            // 
            // drawellipse
            // 
            this.drawellipse.Checked = true;
            this.drawellipse.CheckOnClick = true;
            this.drawellipse.CheckState = System.Windows.Forms.CheckState.Checked;
            this.drawellipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawellipse.Image = global::_8_laba_OOP.Properties.Resources.ellipse;
            this.drawellipse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawellipse.Name = "drawellipse";
            this.drawellipse.Size = new System.Drawing.Size(54, 54);
            this.drawellipse.Text = "Круг";
            this.drawellipse.Click += new System.EventHandler(this.drawellipse_Click);
            // 
            // drawsquare
            // 
            this.drawsquare.CheckOnClick = true;
            this.drawsquare.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawsquare.Image = global::_8_laba_OOP.Properties.Resources.square;
            this.drawsquare.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawsquare.Name = "drawsquare";
            this.drawsquare.Size = new System.Drawing.Size(54, 54);
            this.drawsquare.Text = "Квадрат";
            this.drawsquare.Click += new System.EventHandler(this.drawsquare_Click);
            // 
            // drawline
            // 
            this.drawline.CheckOnClick = true;
            this.drawline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawline.Image = global::_8_laba_OOP.Properties.Resources.line;
            this.drawline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawline.Name = "drawline";
            this.drawline.Size = new System.Drawing.Size(54, 54);
            this.drawline.Text = "Отрезок";
            this.drawline.Click += new System.EventHandler(this.drawline_Click);
            // 
            // Clear
            // 
            this.Clear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Clear.Image = global::_8_laba_OOP.Properties.Resources.delete;
            this.Clear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(54, 54);
            this.Clear.Text = "Стереть";
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(644, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 78);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите фигуру, которую хотите отобразить на панели";
            // 
            // btn_select_color
            // 
            this.btn_select_color.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_select_color.BackColor = System.Drawing.Color.White;
            this.btn_select_color.Location = new System.Drawing.Point(644, 218);
            this.btn_select_color.Name = "btn_select_color";
            this.btn_select_color.Size = new System.Drawing.Size(130, 62);
            this.btn_select_color.TabIndex = 2;
            this.btn_select_color.Text = "Цвет";
            this.btn_select_color.UseVisualStyleBackColor = false;
            this.btn_select_color.Click += new System.EventHandler(this.btn_select_color_Click);
            // 
            // colorDialog1
            // 
            this.colorDialog1.Color = System.Drawing.Color.White;
            // 
            // btn_group
            // 
            this.btn_group.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_group.BackColor = System.Drawing.Color.Transparent;
            this.btn_group.Location = new System.Drawing.Point(644, 286);
            this.btn_group.Name = "btn_group";
            this.btn_group.Size = new System.Drawing.Size(130, 62);
            this.btn_group.TabIndex = 3;
            this.btn_group.Text = "Сгруппировать";
            this.btn_group.UseVisualStyleBackColor = false;
            this.btn_group.Click += new System.EventHandler(this.btn_group_Click);
            // 
            // btn_ungroup
            // 
            this.btn_ungroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ungroup.BackColor = System.Drawing.Color.Transparent;
            this.btn_ungroup.Location = new System.Drawing.Point(644, 354);
            this.btn_ungroup.Name = "btn_ungroup";
            this.btn_ungroup.Size = new System.Drawing.Size(130, 62);
            this.btn_ungroup.TabIndex = 4;
            this.btn_ungroup.Text = "Разгруппировать";
            this.btn_ungroup.UseVisualStyleBackColor = false;
            this.btn_ungroup.Click += new System.EventHandler(this.btn_ungroup_Click);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.BackColor = System.Drawing.Color.Transparent;
            this.btn_save.Location = new System.Drawing.Point(644, 422);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(130, 62);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "SAVE";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_load
            // 
            this.btn_load.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_load.BackColor = System.Drawing.Color.Transparent;
            this.btn_load.Location = new System.Drawing.Point(644, 490);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(130, 62);
            this.btn_load.TabIndex = 6;
            this.btn_load.Text = "LOAD";
            this.btn_load.UseVisualStyleBackColor = false;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(781, 9);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Узел0";
            treeNode1.Text = "Узел0";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treeView1.Size = new System.Drawing.Size(205, 543);
            this.treeView1.TabIndex = 7;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // btn_sticky
            // 
            this.btn_sticky.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sticky.BackColor = System.Drawing.Color.Transparent;
            this.btn_sticky.Location = new System.Drawing.Point(491, 12);
            this.btn_sticky.Name = "btn_sticky";
            this.btn_sticky.Size = new System.Drawing.Size(130, 62);
            this.btn_sticky.TabIndex = 4;
            this.btn_sticky.Text = "Липкий";
            this.btn_sticky.UseVisualStyleBackColor = false;
            this.btn_sticky.Click += new System.EventHandler(this.btn_sticky_Click);
            // 
            // laba8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 564);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_ungroup);
            this.Controls.Add(this.btn_group);
            this.Controls.Add(this.btn_select_color);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.panel_drawing);
            this.KeyPreview = true;
            this.Name = "laba8";
            this.Text = "8 Laba OOP";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.laba8_KeyDown);
            this.panel_drawing.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStrip menu;
        private System.Windows.Forms.ToolStripButton drawellipse;
        private System.Windows.Forms.ToolStripButton drawsquare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.ToolStripButton drawline;
        private System.Windows.Forms.Button btn_select_color;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel panel_drawing;
        private System.Windows.Forms.Button btn_group;
        private System.Windows.Forms.Button btn_ungroup;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.ToolStripButton Clear;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btn_sticky;
    }
}

