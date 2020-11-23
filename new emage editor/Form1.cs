using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace new_emage_editor
{
    public partial class Form1 : Form
    {
        Image img;
        Rectangle Rect = new Rectangle();
        Point xy;
        Point x1y1;

        Boolean mouseDown = false;
        OpenFileDialog ofd = new OpenFileDialog();


        public Form1()
        {
            InitializeComponent();
        }


        void openImage()
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                file = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Image = file;
                opened = true;
            }
        }

        Image file;
        Boolean opened = false;


        void saveImage()
        {
            if (opened)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Images|*.png;*.bmp;*.jpg";
                ImageFormat format = ImageFormat.Png;
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string ext = Path.GetExtension(sfd.FileName);
                    switch (ext)
                    {
                        case ".jpg":
                            format = ImageFormat.Jpeg;
                            break;
                        case ".bmp":
                            format = ImageFormat.Bmp;
                            break;
                    }
                    pictureBox2.Image.Save(sfd.FileName, format);
                }

            }

            else { MessageBox.Show("no image loaded, first upload file"); }
        }


        void reload()
        {

            if (!opened)
            {
                MessageBox.Show("open an image then apply changes");
            }
            else
            {
                if (opened)
                {
                    file = Image.FromFile(openFileDialog1.FileName);
                    pictureBox2.Image = file;
                    opened = true;
                }
            }
        }
        void filter()
        {
            img = pictureBox1.Image;
            Bitmap bmpInverted = new Bitmap(img.Width, img.Height);
            ImageAttributes ia = new ImageAttributes();
            ColorMatrix cmpicture = new ColorMatrix(new float[][]
            {
                new float[] {0,0,1,0,0},
                new float[] {0,1,0,0,0},
                new float[] {0,0,0,0,0},
                new float[] {0,0,0,1,0},
                new float[] {0,0,1,0,1} });

            ia.SetColorMatrix(cmpicture);
            Graphics grps = Graphics.FromImage(bmpInverted);
            grps.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height),0,0,img.Width,img.Height, GraphicsUnit.Pixel, ia);
            grps.Dispose();
            pictureBox2.Image = bmpInverted;
        }


        void filter1()
        {
            img = pictureBox1.Image;
            Bitmap bmpInverted = new Bitmap(img.Width, img.Height);
            ImageAttributes ia = new ImageAttributes();
            ColorMatrix cmpicture = new ColorMatrix(new float[][]
            {
                new float[] {1,0,0,0,0},
                new float[] {0,1,1,0,0},
                new float[] {0,0,0,0,0},
                new float[] {0,0,0,1,0},
                new float[] {0,0,0,0,1} });

            ia.SetColorMatrix(cmpicture);
            Graphics grps = Graphics.FromImage(bmpInverted);
            grps.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
            grps.Dispose();
            pictureBox2.Image = bmpInverted;
        }


        void filter2()
        {
            img = pictureBox1.Image;
            Bitmap bmpInverted = new Bitmap(img.Width, img.Height);
            ImageAttributes ia = new ImageAttributes();
            ColorMatrix cmpicture = new ColorMatrix(new float[][]
            {
                new float[] {.3f,.3f,.3f,0,0},
                new float[] {.59f,.59f,.59f,0,0},
                new float[] {.11f,.11f,.11f,0,0},
                new float[] {0,0,0,1,0},
                new float[] {0,0,0,0,1} });

            ia.SetColorMatrix(cmpicture);
            Graphics grps = Graphics.FromImage(bmpInverted);
            grps.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
            grps.Dispose();
            pictureBox2.Image = bmpInverted;
        }


        void filter3()
        {
            img = pictureBox1.Image;
            Bitmap bmpInverted = new Bitmap(img.Width, img.Height);
            ImageAttributes ia = new ImageAttributes();
            ColorMatrix cmpicture = new ColorMatrix(new float[][]
            {
                new float[] {1,1,0,0,0,0},
                new float[] {0,0,1,0,0},
                new float[] {0,0,0,0,0},
                new float[] {0,0,0,1,0},
                new float[] {0,0,0,0,1} });

            ia.SetColorMatrix(cmpicture);
            Graphics grps = Graphics.FromImage(bmpInverted);
            grps.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
            grps.Dispose();
            pictureBox2.Image = bmpInverted;
        }


        void filter4()
        {
            img = pictureBox1.Image;
            Bitmap bmpInverted = new Bitmap(img.Width, img.Height);
            ImageAttributes ia = new ImageAttributes();
            ColorMatrix cmpicture = new ColorMatrix(new float[][]
            {
                new float[] {1,1,1,0,0},
                new float[] {0,0,1,1,0},
                new float[] {0,0,0,0,0},
                new float[] {0,0,0,1,0},
                new float[] {0,0,0,0,1} });

            ia.SetColorMatrix(cmpicture);
            Graphics grps = Graphics.FromImage(bmpInverted);
            grps.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
            grps.Dispose();
            pictureBox2.Image = bmpInverted;
        }


        void filter5()
        {
            img = pictureBox1.Image;
            Bitmap bmpInverted = new Bitmap(img.Width, img.Height);
            ImageAttributes ia = new ImageAttributes();
            ColorMatrix cmpicture = new ColorMatrix(new float[][]
            {
                new float[] {.53f,.39f,0,0,0},
                new float[] {.769f+0.3f,.986f,.534f,0,0},
                new float[] {.189f,.168f,0,0,0},
                new float[] {0,0,0,1,0},
                new float[] {0,0,0,0,1} });

            ia.SetColorMatrix(cmpicture);
            Graphics grps = Graphics.FromImage(bmpInverted);
            grps.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
            grps.Dispose();
            pictureBox2.Image = bmpInverted;
        }


        void sepia()
        {
            img = pictureBox1.Image;
            Bitmap bmpInverted = new Bitmap(img.Width, img.Height);
            ImageAttributes ia = new ImageAttributes();
            ColorMatrix cmpicture = new ColorMatrix(new float[][]
            {
                new float[] {.393f,.349f,272f,0,0},
                new float[] {.769f,.686f,.534f,0,0},
                new float[] {.189f,.168f,131f,0,0},
                new float[] {0,0,0,1,0},
                new float[] {0,0,0,0,1} });

            ia.SetColorMatrix(cmpicture);
            Graphics grps = Graphics.FromImage(bmpInverted);
            grps.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
            grps.Dispose();
            pictureBox2.Image = bmpInverted;
        }


        void contrast()
        {
            float contrast = 0;
            contrast = 0.2f * trackBar2.Value;
            img = pictureBox1.Image;
            Bitmap bmpInverted = new Bitmap(img.Width, img.Height);
            ImageAttributes ia = new ImageAttributes();
            ColorMatrix cmpicture = new ColorMatrix(new float[][]
            {
                new float[] {contrast,0f,0f,0f,0f},
                new float[] {0f,contrast,0f,0f,0f},
                new float[] {0f,0f,contrast,0f,0f},
                new float[] {0f,0f,0f,1f,0f},
                new float[] {0.001f,0.001f,0.001f,0f,1f} });

            ia.SetColorMatrix(cmpicture);
            Graphics grps = Graphics.FromImage(bmpInverted);
            grps.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
            grps.Dispose();
            pictureBox2.Image = bmpInverted;
        }


        void hue()
        {
            img = pictureBox1.Image;
            Bitmap bmpInverted = new Bitmap(img.Width, img.Height);
            ImageAttributes ia = new ImageAttributes();
            ColorMatrix cmpicture = new ColorMatrix(new float[][]
            {
                new float[] {1,0,(trackBar1.Value),0,0,0,0},
                new float[] {0,1,0,0,0},
                new float[] {0,0,0,0,0},
                new float[] {0,0,0,1,0},
                new float[] {0,0,0,0,1} });

            ia.SetColorMatrix(cmpicture);
            Graphics grps = Graphics.FromImage(bmpInverted);
            grps.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
            grps.Dispose();
            pictureBox2.Image = bmpInverted;
        }

        void bright()
        {
            img = pictureBox1.Image;
            float fvalue = trackBar3.Value / 50f; 
            Bitmap bmpInverted = new Bitmap(img.Width, img.Height);
            ImageAttributes ia = new ImageAttributes();
            ColorMatrix cmpicture = new ColorMatrix(new float[][]
            {
                new float[] {1,0,0,0,0},
                new float[] {0,1,0,0,0},
                new float[] {0,0,1,0,0},
                new float[] {0,0,0,0,0},
                new float[] {fvalue,fvalue,fvalue,1,1} });

            ia.SetColorMatrix(cmpicture);
            Graphics grps = Graphics.FromImage(bmpInverted);
            grps.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
            grps.Dispose();
            pictureBox2.Image = bmpInverted;
        }


       

        private void button7_Click(object sender, EventArgs e)
        {
            openImage();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            trackBar1.Value = 0;
            trackBar2.Value = 0;
            trackBar3.Value = 0;
            reload();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            saveImage();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            reload();
            bright();
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            reload();
            filter1();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            reload();
            filter();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            reload();
            filter2();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            reload();
            filter3();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            reload();
            filter4();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reload();
            sepia();
            
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            reload();
            contrast();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            reload();
            hue();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            reload();
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }

        
        new Image Resize(Image image, int width, int height)
        {
            Bitmap bmp = new Bitmap(width, height);
            Graphics grphic = Graphics.FromImage(bmp);
            grphic.DrawImage(image, 0, 0, width, height);
            grphic.Dispose();
            return bmp;

        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            xy = e.Location;
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseDown == true)
            {
                x1y1 = e.Location;
                Refresh();
            }
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            if(mouseDown == true)
            {
                x1y1 = e.Location;
                mouseDown = false;

                if (Rect != null)
                {
                    Bitmap bitm = new Bitmap(pictureBox2.Image, pictureBox2.Width, pictureBox2.Height);
                    Bitmap crop = new Bitmap(Rect.Width, Rect.Height);
                    Graphics g = Graphics.FromImage(crop);
                    g.DrawImage(bitm, 0, 0, Rect, GraphicsUnit.Pixel);
                    pictureBox2.Show();
                    pictureBox2.Image = crop;
                }

            }
        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            if (Rect != null)
            {
                e.Graphics.DrawRectangle(Pens.Aqua, GetRect());
            }
        }

        private Rectangle GetRect()
        {
            Rect = new Rectangle();
            Rect.X = Math.Min(xy.X, x1y1.X);
            Rect.Y = Math.Min(xy.Y, x1y1.Y);
            Rect.Width = Math.Abs(xy.X - x1y1.X);
            Rect.Height = Math.Abs(xy.Y - x1y1.Y);
            return Rect;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            reload();
            GetRect();
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            reload();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            reload();

            pictureBox2.Image = pictureBox1.Image;
            pictureBox2.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
            pictureBox2.Image.RotateFlip(RotateFlipType.Rotate90FlipX);
            pictureBox2.Refresh();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            reload();
            filter5();
        }
    }
}
