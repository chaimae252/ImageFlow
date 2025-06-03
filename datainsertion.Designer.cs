namespace WinFormsApp2
{
    partial class datainsertion
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
            btnOpenFolder = new Button();
            btnAddImages = new Button();
            SuspendLayout();
            // 
            // btnOpenFolder
            // 
            btnOpenFolder.Anchor = AnchorStyles.None;
            btnOpenFolder.BackColor = Color.Black;
            btnOpenFolder.FlatAppearance.BorderColor = Color.DarkOrange;
            btnOpenFolder.FlatAppearance.BorderSize = 0;
            btnOpenFolder.FlatStyle = FlatStyle.Flat;
            btnOpenFolder.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOpenFolder.ForeColor = Color.Tomato;
            btnOpenFolder.Location = new Point(289, 167);
            btnOpenFolder.Name = "btnOpenFolder";
            btnOpenFolder.Size = new Size(222, 47);
            btnOpenFolder.TabIndex = 4;
            btnOpenFolder.Text = "Open Image Folder";
            btnOpenFolder.UseVisualStyleBackColor = false;
            btnOpenFolder.Click += btnOpenFolder_Click;
            // 
            // btnAddImages
            // 
            btnAddImages.Anchor = AnchorStyles.None;
            btnAddImages.BackColor = Color.Black;
            btnAddImages.FlatStyle = FlatStyle.Popup;
            btnAddImages.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddImages.ForeColor = Color.Tomato;
            btnAddImages.Location = new Point(289, 236);
            btnAddImages.Name = "btnAddImages";
            btnAddImages.Size = new Size(222, 47);
            btnAddImages.TabIndex = 3;
            btnAddImages.Text = "Add Images";
            btnAddImages.UseVisualStyleBackColor = false;
            btnAddImages.Click += btnAddImages_Click;
            // 
            // datainsertion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOpenFolder);
            Controls.Add(btnAddImages);
            Name = "datainsertion";
            Text = "ImageInput";
            ResumeLayout(false);
        }

        #endregion

        private Button btnOpenFolder;
        private Button btnAddImages;
    }
}