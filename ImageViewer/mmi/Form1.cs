using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections.Specialized;
using System.Security.Cryptography.X509Certificates;
namespace mmi
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }
        private void frm_main_Load(object sender, EventArgs e)
        {

        }
     
       public bool single = false;
        //*add photos to list box*//
        private void btn_add_Click(object sender, EventArgs e)
        {
            ofd.Title = ("Select Photos");
            ofd.Multiselect = true;
            lsnames.SelectionMode = SelectionMode.One;
            ofd.Filter = "Images|*.jpg;*.png;*.gif;*.bmp;*.jpeg";
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (string x in ofd.FileNames)
                {
                    bool flag = false;
                    foreach (string y in ls_paths.Items)
                    {
                        // MessageBox.Show(x);
                        if (Path.GetFileName(x) == y)
                        {
                            flag = true;
                            break;
                        }
                    }
                    if (!flag)
                    {
                        lsnames.Items.Add(Path.GetFileName(x));
                        ls_paths.Items.Add(x);
                    }

                }

            }
        }
        //////////////////////////////////////////
        private void btn_clear_Click(object sender, EventArgs e)
        {
            if(lsnames.Items.Count>0)
            {
                lsnames.SelectionMode = SelectionMode.One;
                lsnames.Items.Clear();
                ls_paths.Items.Clear();
                btn_start.Visible = false;
                btn_stop.Visible = false;
                btn_multi.Visible = false;
                lbl_name.Visible = false;
                pic_box_single.Image = new PictureBox().Image;
                
                try
                {
                    int n = this.pa_photos.Controls.Count;
                    if (n > 0)
                    {
                        for (int i = 0; i < n; i++)
                        {
                            this.pa_photos.Controls[0].Dispose();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

       
        
        private void singleModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lsnames.Items.Count > 0)
            {
                singleModeToolStripMenuItem.Visible = true;
                multiToolStripMenuItem.Visible = false;
                slideShowModeToolStripMenuItem.Visible = false;
                changeModeToolStripMenuItem.Visible = true;

                this.Text = "Single Mode";
                single = true;
                lsnames.SelectionMode = SelectionMode.One;
                pa_photos.Visible = true;
                pic_box_single.Visible = true;
                pa_photos.Controls.Clear();
                lbl_name.Visible = false;
                btn_start.Visible = false;
                btn_stop.Visible = false;
                btn_multi.Visible = false;
              //  statusBar1.Hide();

                PictureBox image = new PictureBox();

                image.SizeMode = PictureBoxSizeMode.StretchImage;
                image.BorderStyle = BorderStyle.Fixed3D;
                //  image.Size = pa_photos.Size;
                image.Dock = DockStyle.Fill;
            }
            else
            {
                MessageBox.Show("please select photos");
            }


        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      

        private void lsnames_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            try
            {

                if (single)
                {
                    if (lsnames.Items.Count > 0)
                    {


                        pa_photos.Controls.Clear();
                        for (int i = 0; i < lsnames.Items.Count; i++)
                        {
                            if (lsnames.GetSelected(i))
                            {

                                PictureBox image = new PictureBox();
                                string path = ls_paths.Items[lsnames.SelectedIndex].ToString();
                                image.SizeMode = PictureBoxSizeMode.StretchImage;
                                image.BorderStyle = BorderStyle.Fixed3D;
                                //  image.Size = pa_photos.Size;
                                image.Dock = DockStyle.Fill;
                                //  string path = ls_paths.Items[i].ToString();
                                image.Image = Image.FromFile(path);
                                this.pa_photos.Controls.Add(image);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("please select photos");
                    }
                }
                //if (single)
                //{
                //    if (lsnames.Items.Count > 0)
                //    {
                //        pa_photos.Visible = true;
                //        pic_box_single.Visible = true;
                //        MessageBox.Show("as");
                //        pic_box_single.Image = new PictureBox().Image;
                        
                //        pic_box_single.Image = Image.FromFile(path);
                //    }
                //}
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lbl_name_Click(object sender, EventArgs e)
        {

        }

        private void multiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lsnames.Items.Count > 0)
            {
                singleModeToolStripMenuItem.Visible = false;
                multiToolStripMenuItem.Visible = true;
                slideShowModeToolStripMenuItem.Visible = false;
                changeModeToolStripMenuItem.Visible = true;

                this.Text = "Multi-Picture Mode";
                pa_photos.Controls.Clear();

                lsnames.SelectionMode = SelectionMode.MultiExtended;
                single = false;
                btn_multi.Visible = true;
                pa_photos.Visible = true;
                pic_box_single.Visible = false;
                btn_start.Visible = false;
                btn_stop.Visible = false;
                lbl_name.Visible = false;
               // statusBar1.Hide();

            }
            else
            {
                MessageBox.Show("please select photos");
            }

        }

        private void btn_multi_Click(object sender, EventArgs e)
        {
            try
            {
               
                int n = this.pa_photos.Controls.Count;
                if(n>0)
                {
                    for(int i=0;i<n;i++)
                    {
                        this.pa_photos.Controls[0].Dispose();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                int t = 25, l = 25, count = 1;
                for(int i=0;i< lsnames.Items.Count;i++)
                {
                    if (lsnames.GetSelected(i))
                    {


                        string path = ls_paths.Items[i].ToString();

                        PictureBox image = new PictureBox();

                        image.SizeMode = PictureBoxSizeMode.StretchImage;
                        image.BorderStyle = BorderStyle.Fixed3D;
                        image.Size = new Size(210, 210);
                        image.Left = l;
                        image.Top = t;

                        if (count == 5)
                        {
                            t += 220;
                            l = 25;
                            count = 0;
                        }
                        else
                        {
                            l += 220;
                        }
                        count++;
                        image.Image = Image.FromFile(path);
                        this.pa_photos.Controls.Add(image);
                       // lsnames.SelectedItem=false;
                    }
                    else
                    {
                        continue;
                    }

                   
                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        ///////////////////////////////////////////////////////////
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        int i = 0;
        private void slideShowModeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (lsnames.Items.Count > 0)
            {
                singleModeToolStripMenuItem.Visible = false;
                multiToolStripMenuItem.Visible = false;
                slideShowModeToolStripMenuItem.Visible = true;
                changeModeToolStripMenuItem.Visible = true;

                this.Text = "Slide Show Mode";
                single = false;
                pa_photos.Controls.Clear();
                lsnames.SelectionMode = SelectionMode.One;
                btn_multi.Visible = false;
                pa_photos.Visible = true;
                pic_box_single.Visible = true;
                btn_start.Visible = true;
                btn_stop.Visible = true;
                // lbl_name.Visible = true;
               


                pic_box_single.Image = new PictureBox().Image;
                i = 0;
            }
            else
            {
                MessageBox.Show("please select photos");
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            my_time.Enabled = true;
            try
            {
                if(i>=ls_paths.Items.Count)
                {
                    i = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            my_time.Enabled = false;
        }

        private void my_time_Tick(object sender, EventArgs e)
        {
            try
            {
                if (i >= lsnames.Items.Count)
                { i = 0; }
                pa_photos.Controls.Clear();
                if(i<lsnames.Items.Count)
                {
                    lsnames.SetSelected(i, true);
                    PictureBox image = new PictureBox();
                    string path = ls_paths.Items[i].ToString();
                    image.SizeMode = PictureBoxSizeMode.StretchImage;
                    image.BorderStyle = BorderStyle.Fixed3D;
                    //  image.Size = pa_photos.Size;
                    image.Dock = DockStyle.Fill;
                    //  string path = ls_paths.Items[i].ToString();
                    image.Image = Image.FromFile(path);
                    this.pa_photos.Controls.Add(image);
                    // lblname.Visible = true;
                    //statusBar1.Show();
                    lbl_name.Text = lsnames.Items[i].ToString();
                    i++;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblname_Click(object sender, EventArgs e)
        {

        }

        private void lblname_PanelClick(object sender, StatusBarPanelClickEventArgs e)
        {

        }

        private void changeModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            single = false;
            singleModeToolStripMenuItem.Visible = true;
            multiToolStripMenuItem.Visible = true;
            slideShowModeToolStripMenuItem.Visible = true;
            changeModeToolStripMenuItem.Visible = false;

            this.Text = "Right Click to select mode";
            lsnames.SelectionMode = SelectionMode.One;


            pa_photos.Controls.Clear();

            btn_start.Visible = false;
            btn_stop.Visible = false;
            btn_multi.Visible = false;
            lbl_name.Visible = false;
            my_time.Enabled = false;

        }

        private void pic_box_single_Click(object sender, EventArgs e)
        {

        }
    }
}
