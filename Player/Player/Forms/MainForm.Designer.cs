
namespace Player
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ElipseForm = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.TrackPage = new Player.Pages.CurrentTrackPage();
            this.TrackListPage = new Player.Pages.ListPage();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.SuspendLayout();
            // 
            // ElipseForm
            // 
            this.ElipseForm.BorderRadius = 0;
            this.ElipseForm.TargetControl = this;
            // 
            // TrackPage
            // 
            this.TrackPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.TrackPage.Location = new System.Drawing.Point(290, 0);
            this.TrackPage.Name = "TrackPage";
            this.TrackPage.Padding = new System.Windows.Forms.Padding(10);
            this.TrackPage.Size = new System.Drawing.Size(240, 420);
            this.TrackPage.TabIndex = 2;
            // 
            // TrackListPage
            // 
            this.TrackListPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(122)))), ((int)(((byte)(223)))));
            this.TrackListPage.Location = new System.Drawing.Point(0, 0);
            this.TrackListPage.Name = "TrackListPage";
            this.TrackListPage.Padding = new System.Windows.Forms.Padding(10);
            this.TrackListPage.Size = new System.Drawing.Size(290, 420);
            this.TrackListPage.TabIndex = 1;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.TrackPage;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 420);
            this.Controls.Add(this.TrackPage);
            this.Controls.Add(this.TrackListPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse ElipseForm;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Pages.ListPage TrackListPage;
        private Pages.CurrentTrackPage TrackPage;
    }
}

