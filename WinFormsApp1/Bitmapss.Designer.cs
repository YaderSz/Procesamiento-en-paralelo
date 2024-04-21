namespace WinFormsApp1
{
    partial class Bitmapss
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnProcess = new Button();
            picOriginal = new PictureBox();
            picGray = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picOriginal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picGray).BeginInit();
            SuspendLayout();
            // 
            // btnProcess
            // 
            btnProcess.BackColor = SystemColors.ActiveBorder;
            btnProcess.Location = new Point(163, 149);
            btnProcess.Name = "btnProcess";
            btnProcess.Size = new Size(168, 68);
            btnProcess.TabIndex = 0;
            btnProcess.Text = "Procesar Imagenes";
            btnProcess.UseVisualStyleBackColor = false;
            btnProcess.Click += btnProcess_Click;
            // 
            // picOriginal
            // 
            picOriginal.BackColor = SystemColors.ActiveCaptionText;
            picOriginal.Location = new Point(27, 289);
            picOriginal.Name = "picOriginal";
            picOriginal.Size = new Size(150, 150);
            picOriginal.SizeMode = PictureBoxSizeMode.Zoom;
            picOriginal.TabIndex = 1;
            picOriginal.TabStop = false;
            // 
            // picGray
            // 
            picGray.BackColor = SystemColors.ActiveCaptionText;
            picGray.Location = new Point(319, 289);
            picGray.Name = "picGray";
            picGray.Size = new Size(150, 150);
            picGray.SizeMode = PictureBoxSizeMode.Zoom;
            picGray.TabIndex = 2;
            picGray.TabStop = false;
            // 
            // Bitmapss
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(516, 505);
            Controls.Add(picGray);
            Controls.Add(picOriginal);
            Controls.Add(btnProcess);
            Name = "Bitmapss";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picOriginal).EndInit();
            ((System.ComponentModel.ISupportInitialize)picGray).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnProcess;
        private PictureBox picOriginal;
        private PictureBox picGray;
    }
}
