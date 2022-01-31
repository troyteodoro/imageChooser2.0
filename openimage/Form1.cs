using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace openimage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Load_Image_Click(object sender, EventArgs e)
        {
            OpenFileDialog imagefileopen = new OpenFileDialog();
            imagefileopen.Filter = "Image Files(*.jpg;*.jpeg; *.gif; *.bmp; *.png)|*.jpg;*.jpeg; *.gif; *.bmp ; *.png";
            if (imagefileopen.ShowDialog() == DialogResult.OK)
            {
                OpenImageDisplay.Image = new Bitmap(imagefileopen.FileName);
                OpenImageDisplay.Size = OpenImageDisplay.Image.Size;
            }
        }
        private Bitmap MakeGrayscale(Bitmap original)
        {
            try
            {
                Bitmap newBitmap = new Bitmap(original.Width, original.Height);
                for (int i = 0; i < original.Width; i++)
                {
                    for (int j = 0; j < original.Height; j++)
                    {
                        //get the pixels from the original image
                        Color originalColor = original.GetPixel(i, j);
                        //create the gray scale version of each pixel
                        int grayScale = (int)((originalColor.R * 0.3) + (originalColor.G * 0.59) + (originalColor.B * 0.11));
                        Color newColor = Color.FromArgb(grayScale, grayScale, grayScale);
                        newBitmap.SetPixel(i, j, newColor);
                    }
                }
                return newBitmap;
            }
            catch
            {
                throw new NotImplementedException();
            }

        }
        private void Gray_Scale_Click(object sender, EventArgs e)
        {
            Form form2 = new Gray_Scale();
            Bitmap imageInstance = (Bitmap)OpenImageDisplay.Image;
            Bitmap imageInstance1 = new Bitmap(imageInstance.Width, imageInstance.Height);
            if (imageInstance != null)
            {
                imageInstance1 = MakeGrayscale(imageInstance);
                PictureBox tempPict = new PictureBox();
                tempPict.Size = imageInstance1.Size;
                form2.Controls.Add(tempPict);
                tempPict.Image = imageInstance1;
                form2.Show();
            }
        }
        private Bitmap MakeRed(Bitmap original)
        {
            try
            {
                Bitmap redBitmap = new Bitmap(original.Width, original.Height);
                for (int i = 0; i < original.Width; i++)
                {
                    for (int j = 0; j < original.Height; j++)
                    {
                        //get the pixels from the original image
                        Color originalColor = original.GetPixel(i, j);
                        //create the Red scale version of each pixel
                        Color redColor = Color.FromArgb(originalColor.R, originalColor.R, originalColor.R);
                        redBitmap.SetPixel(i, j, redColor);
                    }
                }
                return redBitmap;
            }
            catch
            {
                throw new NotImplementedException();
            }

        }

        private void Red_Scale_Click(object sender, EventArgs e)
        {
            Form form3 = new Red_Scale();
            Bitmap imageInstance = (Bitmap)OpenImageDisplay.Image;
            Bitmap imageInstance1 = new Bitmap(imageInstance.Width, imageInstance.Height);
            if (imageInstance != null)
            {
                imageInstance1 = MakeRed(imageInstance);
                PictureBox tempPict = new PictureBox();
                tempPict.Size = imageInstance1.Size;
                form3.Controls.Add(tempPict);
                tempPict.Image = imageInstance1;
                form3.Show();
            }
        }
        private Bitmap MakeGreen(Bitmap original)
        {
            try
            {
                Bitmap greenBitmap = new Bitmap(original.Width, original.Height);
                for (int i = 0; i < original.Width; i++)
                {
                    for (int j = 0; j < original.Height; j++)
                    {
                        //get the pixels from the original image
                        Color originalColor = original.GetPixel(i, j);
                        //create the Red scale version of each pixel
                        Color greenColor = Color.FromArgb(originalColor.G, originalColor.G, originalColor.G);
                        greenBitmap.SetPixel(i, j, greenColor);
                    }
                }
                return greenBitmap;
            }
            catch
            {
                throw new NotImplementedException();
            }

        }

        private void Green_Scale_Click(object sender, EventArgs e)
        {
            Form form4 = new Green_Scale();
            Bitmap imageInstance = (Bitmap)OpenImageDisplay.Image;
            Bitmap imageInstance1 = new Bitmap(imageInstance.Width, imageInstance.Height);
            if (imageInstance != null)
            {
                imageInstance1 = MakeGreen(imageInstance);
                PictureBox tempPict = new PictureBox();
                tempPict.Size = imageInstance1.Size;
                form4.Controls.Add(tempPict);
                tempPict.Image = imageInstance1;
                form4.Show();
            }
        }
        private Bitmap MakeBlue(Bitmap original)
        {
            try
            {
                Bitmap blueBitmap = new Bitmap(original.Width, original.Height);
                for (int i = 0; i < original.Width; i++)
                {
                    for (int j = 0; j < original.Height; j++)
                    {
                        //get the pixels from the original image
                        Color originalColor = original.GetPixel(i, j);
                        //create the Red scale version of each pixel
                        Color blueColor = Color.FromArgb(originalColor.B, originalColor.B, originalColor.B);
                        blueBitmap.SetPixel(i, j, blueColor);
                    }
                }
                return blueBitmap;
            }
            catch
            {
                throw new NotImplementedException();
            }

        }
        private void Blue_Scale_Click(object sender, EventArgs e)
        {
            Form form5 = new Blue_Scale();
            Bitmap imageInstance = (Bitmap)OpenImageDisplay.Image;
            Bitmap imageInstance1 = new Bitmap(imageInstance.Width, imageInstance.Height);
            if (imageInstance != null)
            {
                imageInstance1 = MakeBlue(imageInstance);
                PictureBox tempPict = new PictureBox();
                tempPict.Size = imageInstance1.Size;
                form5.Controls.Add(tempPict);
                tempPict.Image = imageInstance1;
                form5.Show();
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
