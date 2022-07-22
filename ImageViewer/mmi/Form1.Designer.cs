
namespace mmi
{
    partial class frm_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_add = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_clear = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_start = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_stop = new System.Windows.Forms.ToolStripButton();
            this.btn_multi = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.lbl_name = new System.Windows.Forms.ToolStripLabel();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.lsnames = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.singleModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slideShowModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pa_photos = new System.Windows.Forms.Panel();
            this.pic_box_single = new System.Windows.Forms.PictureBox();
            this.ls_paths = new System.Windows.Forms.ListBox();
            this.my_time = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.pa_photos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_box_single)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_add,
            this.toolStripSeparator1,
            this.btn_clear,
            this.toolStripSeparator2,
            this.btn_start,
            this.toolStripSeparator3,
            this.btn_stop,
            this.btn_multi,
            this.toolStripSeparator4,
            this.lbl_name});
            this.toolStrip1.Location = new System.Drawing.Point(0, 474);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1024, 35);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "s";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btn_add
            // 
            this.btn_add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_add.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(132, 32);
            this.btn_add.Text = "Add Photos";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // btn_clear
            // 
            this.btn_clear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_clear.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Image = ((System.Drawing.Image)(resources.GetObject("btn_clear.Image")));
            this.btn_clear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(66, 32);
            this.btn_clear.Text = "Clear";
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            this.toolStripSeparator2.Visible = false;
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.Red;
            this.btn_start.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_start.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.ForeColor = System.Drawing.Color.White;
            this.btn_start.Image = ((System.Drawing.Image)(resources.GetObject("btn_start.Image")));
            this.btn_start.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(76, 36);
            this.btn_start.Text = "Start";
            this.btn_start.Visible = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 35);
            // 
            // btn_stop
            // 
            this.btn_stop.BackColor = System.Drawing.Color.Red;
            this.btn_stop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_stop.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stop.ForeColor = System.Drawing.Color.White;
            this.btn_stop.Image = ((System.Drawing.Image)(resources.GetObject("btn_stop.Image")));
            this.btn_stop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(73, 36);
            this.btn_stop.Text = "Stop";
            this.btn_stop.Visible = false;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_multi
            // 
            this.btn_multi.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_multi.BackColor = System.Drawing.Color.Red;
            this.btn_multi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_multi.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_multi.ForeColor = System.Drawing.Color.White;
            this.btn_multi.Image = ((System.Drawing.Image)(resources.GetObject("btn_multi.Image")));
            this.btn_multi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_multi.Name = "btn_multi";
            this.btn_multi.Size = new System.Drawing.Size(179, 36);
            this.btn_multi.Text = "Show Pictures";
            this.btn_multi.Visible = false;
            this.btn_multi.Click += new System.EventHandler(this.btn_multi_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 35);
            // 
            // lbl_name
            // 
            this.lbl_name.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lbl_name.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lbl_name.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(0, 32);
            this.lbl_name.Visible = false;
            this.lbl_name.Click += new System.EventHandler(this.lbl_name_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // lsnames
            // 
            this.lsnames.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lsnames.Dock = System.Windows.Forms.DockStyle.Left;
            this.lsnames.FormattingEnabled = true;
            this.lsnames.ItemHeight = 29;
            this.lsnames.Location = new System.Drawing.Point(0, 0);
            this.lsnames.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lsnames.Name = "lsnames";
            this.lsnames.Size = new System.Drawing.Size(402, 474);
            this.lsnames.TabIndex = 3;
            this.lsnames.SelectedIndexChanged += new System.EventHandler(this.lsnames_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.White;
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.singleModeToolStripMenuItem,
            this.multiToolStripMenuItem,
            this.slideShowModeToolStripMenuItem,
            this.changeModeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(239, 144);
            // 
            // singleModeToolStripMenuItem
            // 
            this.singleModeToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.singleModeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singleModeToolStripMenuItem.Name = "singleModeToolStripMenuItem";
            this.singleModeToolStripMenuItem.Size = new System.Drawing.Size(238, 28);
            this.singleModeToolStripMenuItem.Text = "Single mode";
            this.singleModeToolStripMenuItem.Click += new System.EventHandler(this.singleModeToolStripMenuItem_Click);
            // 
            // multiToolStripMenuItem
            // 
            this.multiToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.multiToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiToolStripMenuItem.Name = "multiToolStripMenuItem";
            this.multiToolStripMenuItem.Size = new System.Drawing.Size(238, 28);
            this.multiToolStripMenuItem.Text = "Multi-Images mode";
            this.multiToolStripMenuItem.Click += new System.EventHandler(this.multiToolStripMenuItem_Click);
            // 
            // slideShowModeToolStripMenuItem
            // 
            this.slideShowModeToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.slideShowModeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slideShowModeToolStripMenuItem.Name = "slideShowModeToolStripMenuItem";
            this.slideShowModeToolStripMenuItem.Size = new System.Drawing.Size(238, 28);
            this.slideShowModeToolStripMenuItem.Text = "Slide Show mode";
            this.slideShowModeToolStripMenuItem.Click += new System.EventHandler(this.slideShowModeToolStripMenuItem_Click);
            // 
            // changeModeToolStripMenuItem
            // 
            this.changeModeToolStripMenuItem.Name = "changeModeToolStripMenuItem";
            this.changeModeToolStripMenuItem.Size = new System.Drawing.Size(238, 28);
            this.changeModeToolStripMenuItem.Text = "Change Mode";
            this.changeModeToolStripMenuItem.Visible = false;
            this.changeModeToolStripMenuItem.Click += new System.EventHandler(this.changeModeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(238, 28);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // pa_photos
            // 
            this.pa_photos.AutoScroll = true;
            this.pa_photos.Controls.Add(this.pic_box_single);
            this.pa_photos.Controls.Add(this.ls_paths);
            this.pa_photos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pa_photos.Location = new System.Drawing.Point(402, 0);
            this.pa_photos.Name = "pa_photos";
            this.pa_photos.Size = new System.Drawing.Size(622, 474);
            this.pa_photos.TabIndex = 7;
            // 
            // pic_box_single
            // 
            this.pic_box_single.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_box_single.Location = new System.Drawing.Point(0, 0);
            this.pic_box_single.Name = "pic_box_single";
            this.pic_box_single.Size = new System.Drawing.Size(622, 474);
            this.pic_box_single.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_box_single.TabIndex = 0;
            this.pic_box_single.TabStop = false;
            this.pic_box_single.Click += new System.EventHandler(this.pic_box_single_Click);
            // 
            // ls_paths
            // 
            this.ls_paths.FormattingEnabled = true;
            this.ls_paths.ItemHeight = 29;
            this.ls_paths.Location = new System.Drawing.Point(43, 0);
            this.ls_paths.Name = "ls_paths";
            this.ls_paths.Size = new System.Drawing.Size(402, 410);
            this.ls_paths.TabIndex = 9;
            this.ls_paths.Visible = false;
            // 
            // my_time
            // 
            this.my_time.Interval = 500;
            this.my_time.Tick += new System.EventHandler(this.my_time_Tick);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 509);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.pa_photos);
            this.Controls.Add(this.lsnames);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frm_main";
            this.Text = "Right Click to select mode";
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.pa_photos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_box_single)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_add;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_clear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_start;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btn_stop;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.ListBox lsnames;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem singleModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem slideShowModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel pa_photos;
        private System.Windows.Forms.PictureBox pic_box_single;
        private System.Windows.Forms.ToolStripButton btn_multi;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel lbl_name;
        private System.Windows.Forms.ListBox ls_paths;
        private System.Windows.Forms.Timer my_time;
        private System.Windows.Forms.ToolStripMenuItem changeModeToolStripMenuItem;
    }
}

