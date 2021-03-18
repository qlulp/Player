
namespace Player.Controls
{
    partial class Track
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Track));
            this.TrackName = new System.Windows.Forms.Label();
            this.Artist = new System.Windows.Forms.Label();
            this.PlayPauseButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Line = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TrackName
            // 
            this.TrackName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TrackName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TrackName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TrackName.ForeColor = System.Drawing.Color.White;
            this.TrackName.Location = new System.Drawing.Point(46, 4);
            this.TrackName.Name = "TrackName";
            this.TrackName.Size = new System.Drawing.Size(184, 19);
            this.TrackName.TabIndex = 10;
            this.TrackName.Text = "Aur Ho";
            this.TrackName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Track_MouseDown);
            // 
            // Artist
            // 
            this.Artist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Artist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Artist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Artist.ForeColor = System.Drawing.Color.LightGray;
            this.Artist.Location = new System.Drawing.Point(46, 23);
            this.Artist.Name = "Artist";
            this.Artist.Size = new System.Drawing.Size(184, 17);
            this.Artist.TabIndex = 12;
            this.Artist.Text = "A. R. Rahaman";
            this.Artist.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Artist.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Track_MouseDown);
            // 
            // PlayPauseButton
            // 
            this.PlayPauseButton.BackColor = System.Drawing.Color.Transparent;
            this.PlayPauseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(237)))));
            this.PlayPauseButton.CheckedState.Parent = this.PlayPauseButton;
            this.PlayPauseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayPauseButton.CustomImages.Parent = this.PlayPauseButton;
            this.PlayPauseButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.PlayPauseButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayPauseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(123)))), ((int)(((byte)(202)))));
            this.PlayPauseButton.HoverState.Parent = this.PlayPauseButton;
            this.PlayPauseButton.Image = ((System.Drawing.Image)(resources.GetObject("PlayPauseButton.Image")));
            this.PlayPauseButton.ImageOffset = new System.Drawing.Point(1, 0);
            this.PlayPauseButton.ImageSize = new System.Drawing.Size(10, 10);
            this.PlayPauseButton.Location = new System.Drawing.Point(10, 10);
            this.PlayPauseButton.Name = "PlayPauseButton";
            this.PlayPauseButton.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.PlayPauseButton.ShadowDecoration.Depth = 20;
            this.PlayPauseButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PlayPauseButton.ShadowDecoration.Parent = this.PlayPauseButton;
            this.PlayPauseButton.Size = new System.Drawing.Size(24, 24);
            this.PlayPauseButton.TabIndex = 13;
            // 
            // Line
            // 
            this.Line.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(119)))), ((int)(((byte)(217)))));
            this.Line.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Line.Location = new System.Drawing.Point(0, 43);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(263, 2);
            this.Line.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(236, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Track
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Line);
            this.Controls.Add(this.PlayPauseButton);
            this.Controls.Add(this.Artist);
            this.Controls.Add(this.TrackName);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(300, 45);
            this.MinimumSize = new System.Drawing.Size(263, 45);
            this.Name = "Track";
            this.Size = new System.Drawing.Size(263, 45);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Track_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private new System.Windows.Forms.Label TrackName;
        private System.Windows.Forms.Label Artist;
        private Guna.UI2.WinForms.Guna2CircleButton PlayPauseButton;
        private System.Windows.Forms.Panel Line;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
