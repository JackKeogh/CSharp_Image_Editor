using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Effects
{
    public partial class Form1 : Form
    {
        private string m_current_image;
        private Bitmap m_image = null;

        public Form1()
        {
            InitializeComponent();

            Populate_Color_Boxes();
        }

        public void Populate_Color_Boxes()
        {
            ArrayList ColorList = new ArrayList();
            Type colorType = typeof(Color);
            PropertyInfo[] propInfoList = colorType.GetProperties(BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Public);

            foreach (PropertyInfo c in propInfoList)
            {
                ChangeFrom.Items.Add(c.Name);
                ChangeTo.Items.Add(c.Name);
            }
        }

        public static Bitmap Resize_Bitmap(Image target, Size new_size)
        {
            return new Bitmap(target, new_size);
        }

        public bool CheckColor(Color a, Color b, decimal threshold = 50)
        {
            int red = a.R - b.R;
            int blue = a.B - b.B;
            int green = a.G - b.G;

            return ((red * red) + (blue * blue) + (green * green)) <= (threshold * threshold);
        }

        private void FileNameBtn01_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Choose An Image";
            fileDialog.Filter = "Image Files| *.png";
            fileDialog.InitialDirectory = @"C:\";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                FileNameTextBox.Text = fileDialog.FileName;
            }
        }

        private void FileNameBtn02_Click(object sender, EventArgs e)
        {
            if (FileNameTextBox.Text == "")
            {
                return;
            }
            if (m_current_image != FileNameTextBox.Text)
            {
                m_image = new Bitmap(FileNameTextBox.Text, true);

                Bitmap display = new Bitmap(m_image, ImageDisplay.Size);

                ImageDisplay.Image = display;

                m_current_image = FileNameTextBox.Text;
            }
        }

        private void ChangeColorBtn_Click(object sender, EventArgs e)
        {
            if (m_image == null)
            {
                MessageBox.Show("No file open to change color of.", "Cannot Change Color", MessageBoxButtons.OK);
                return;
            }

            Color from = Color.FromName(ChangeFrom.Text);
            Color to = Color.FromName(ChangeTo.Text);

            for (int i = 0; i < m_image.Width; i++)
            {
                for (int j = 0; j < m_image.Height; j++)
                {
                    Color pixel = m_image.GetPixel(i, j);

                    if (CheckColor(pixel, from, ColorThreshold.Value))
                    {
                        pixel = to;
                    }

                    m_image.SetPixel(i, j, pixel);
                }
            }

            Bitmap display = new Bitmap(m_image, ImageDisplay.Size);

            ImageDisplay.Image = display;
        }

        private void BlurBtn_Click(object sender, EventArgs e)
        {
            if (m_image == null)
            {
                MessageBox.Show("No image to blur.", "Cannot Blur", MessageBoxButtons.OK);
                return;
            }

            int avgR = 0, avgB = 0, avgG = 0;
            int num_of_pixels = 0;
            int width = (int)BlurBlockWidth.Value;
            int height = (int)BlurBlockHeight.Value;

            for (int i = 0; i < m_image.Width; i += width)
            {
                for (int j = 0; j < m_image.Height; j += height)
                {
                    num_of_pixels = 0;
                    avgR = 0;
                    avgB = 0;
                    avgG = 0;

                    for (int x = i; x < i + width && x < m_image.Width; x++)
                    {
                        for (int y = j; y < j + height && y < m_image.Height; y++)
                        {
                            num_of_pixels++;

                            Color pixel = m_image.GetPixel(x, y);
                            avgR += pixel.R;
                            avgB += pixel.B;
                            avgG += pixel.G;
                        }
                    }

                    avgR /= num_of_pixels;
                    avgB /= num_of_pixels;
                    avgG /= num_of_pixels;


                    for (int x = i; x < i + width && x < m_image.Width; x++)
                    {
                        for (int y = j; y < j + height && y < m_image.Height; y++)
                        {
                            Color pixel = Color.FromArgb(avgR, avgG, avgB);
                            m_image.SetPixel(x, y, pixel);
                        }
                    }
                }
            }

            Bitmap display = new Bitmap(m_image, ImageDisplay.Size);

            ImageDisplay.Image = display;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int avgR = 0, avgB = 0, avgG = 0;
            int num_of_pixels = 0;
            int width = 5;
            int height = 5;

            for (int i = 0; i < m_image.Width; i += width)
            {
                for (int j = 0; j < m_image.Height; j += height)
                {
                    num_of_pixels = 0;
                    avgR = 0;
                    avgB = 0;
                    avgG = 0;

                    for (int x = i; x < i + width && x < m_image.Width; x++)
                    {
                        for (int y = j; y < j + height && y < m_image.Height; y++)
                        {
                            num_of_pixels++;

                            Color pixel = m_image.GetPixel(x, y);
                            avgR += pixel.R;
                            avgB += pixel.B;
                            avgG += pixel.G;
                        }
                    }

                    avgR /= num_of_pixels;
                    avgB /= num_of_pixels;
                    avgG /= num_of_pixels;


                    for (int x = i; x < i + width && x < m_image.Width; x++)
                    {
                        for (int y = j; y < j + height && y < m_image.Height; y++)
                        {
                            Color pixel = Color.FromArgb(avgR, avgG, avgB);
                            m_image.SetPixel(x, y, pixel);
                        }
                    }
                }
            }

            Bitmap display = new Bitmap(m_image, ImageDisplay.Size);

            ImageDisplay.Image = display;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (m_image != null)
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Title = "Save Image";
                dialog.Filter = "PNG Image | *.png";
                dialog.InitialDirectory = @"C:\";

                if (dialog.ShowDialog() == DialogResult.OK && dialog.FileName != "")
                {
                    if (System.IO.File.Exists(dialog.FileName))
                    {
                        System.IO.File.Delete(dialog.FileName);
                    }

                    System.IO.FileStream fs = (System.IO.FileStream)dialog.OpenFile();
                    m_image.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
                }

            }
            else
            {
                MessageBox.Show("No file open to save.", "Cannot Save", MessageBoxButtons.OK);
            }
        }
    }
}
