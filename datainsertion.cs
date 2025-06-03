using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class datainsertion : Form
    {
        private string imageFolderPath;
        public datainsertion()
        {
            InitializeComponent();
            SetupImageDirectory();
        }
        private void SetupImageDirectory()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            imageFolderPath = Path.Combine(desktopPath, "ImagesFolder");

            if (!Directory.Exists(imageFolderPath))
            {
                Directory.CreateDirectory(imageFolderPath);
            }
        }
        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", imageFolderPath);
        }

        private void btnAddImages_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Multiselect = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (string file in openFileDialog.FileNames)
                    {
                        string destPath = Path.Combine(imageFolderPath, Path.GetFileName(file));
                        if (!File.Exists(destPath))
                        {
                            File.Copy(file, destPath);
                        }
                    }
                }
            }
        }
    }
}
// Created by CHAIMAE HAKAM