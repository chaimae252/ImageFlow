using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private string imageFolderPath;
        private string[] imageFiles;
        private int currentImageIndex = 0;

        public Form1(string folderPath)
        {
            InitializeComponent();
            InitializeCustomComponents();
            this.imageFolderPath = folderPath;
            LoadImages();
        }

        private void InitializeCustomComponents()
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            timer1.Interval = 9000;
            timer1.Tick += Timer1_Tick;
        }

        private void LoadImages()
        {
            string[] supportedExtensions = new[] { "*.jpg", "*.jpeg", "*.png", "*.bmp" };
            List<string> allImageFiles = new List<string>();

            foreach (string ext in supportedExtensions)
            {
                allImageFiles.AddRange(Directory.GetFiles(imageFolderPath, ext));
            }

            imageFiles = allImageFiles.OrderBy(f => f).ToArray();

            if (imageFiles.Length > 0)
            {
                currentImageIndex = 0;
                DisplayCurrentImage();
                timer1.Start();
            }
            else
            {
                MessageBox.Show($"No images found in the folder: {imageFolderPath}\nPlease add images to this folder.");
            }
        }

        private void DisplayCurrentImage()
        {
            if (imageFiles.Length > 0)
            {
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Dispose();
                }

                pictureBox1.Image = Image.FromFile(imageFiles[currentImageIndex]);
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            currentImageIndex = (currentImageIndex + 1) % imageFiles.Length;
            DisplayCurrentImage();
        }
    }
}
// Created by CHAIMAE HAKAM