
namespace easy_translator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.borderlessform = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.translateBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.name = new Guna.UI.WinForms.GunaLabel();
            this.textbox = new Guna.UI.WinForms.GunaTextBox();
            this.header = new Guna.UI.WinForms.GunaLabel();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.gunaSeparator2 = new Guna.UI.WinForms.GunaSeparator();
            this.gunaResizeControl1 = new Guna.UI.WinForms.GunaResizeControl();
            this.SuspendLayout();
            // 
            // borderlessform
            // 
            this.borderlessform.AnimateWindow = true;
            this.borderlessform.BorderRadius = 1;
            this.borderlessform.ContainerControl = this;
            this.borderlessform.DockIndicatorTransparencyValue = 0.6D;
            this.borderlessform.ResizeForm = false;
            this.borderlessform.TransparentWhileDrag = true;
            // 
            // translateBtn
            // 
            this.translateBtn.Animated = true;
            this.translateBtn.BorderColor = System.Drawing.Color.Transparent;
            this.translateBtn.BorderRadius = 2;
            this.translateBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.translateBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.translateBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.translateBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.translateBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.translateBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.translateBtn.ForeColor = System.Drawing.Color.White;
            this.translateBtn.Location = new System.Drawing.Point(201, 435);
            this.translateBtn.Name = "translateBtn";
            this.translateBtn.Size = new System.Drawing.Size(189, 38);
            this.translateBtn.TabIndex = 0;
            this.translateBtn.Text = "translate";
            this.translateBtn.Click += new System.EventHandler(this.translateBtn_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(12, 9);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(132, 19);
            this.name.TabIndex = 1;
            this.name.Text = "Easy translator";
            // 
            // textbox
            // 
            this.textbox.BackColor = System.Drawing.Color.Transparent;
            this.textbox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.textbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.textbox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.textbox.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.textbox.Font = new System.Drawing.Font("Rubik", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.textbox.Location = new System.Drawing.Point(135, 206);
            this.textbox.MultiLine = true;
            this.textbox.Name = "textbox";
            this.textbox.PasswordChar = '\0';
            this.textbox.Radius = 4;
            this.textbox.Size = new System.Drawing.Size(324, 142);
            this.textbox.TabIndex = 2;
            this.textbox.Text = "that`s a sample text to translate";
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.header.ForeColor = System.Drawing.Color.White;
            this.header.Location = new System.Drawing.Point(131, 173);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(110, 19);
            this.header.TabIndex = 3;
            this.header.Text = "Write it here";
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(100, 50);
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(100, 50);
            this.guna2ImageButton1.Location = new System.Drawing.Point(222, 59);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(100, 50);
            this.guna2ImageButton1.Size = new System.Drawing.Size(54, 50);
            this.guna2ImageButton1.TabIndex = 4;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.LineColor = System.Drawing.Color.RoyalBlue;
            this.gunaSeparator1.Location = new System.Drawing.Point(222, 109);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(54, 8);
            this.gunaSeparator1.TabIndex = 5;
            // 
            // guna2ImageButton2
            // 
            this.guna2ImageButton2.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.HoverState.ImageSize = new System.Drawing.Size(70, 40);
            this.guna2ImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton2.Image")));
            this.guna2ImageButton2.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton2.ImageRotate = 0F;
            this.guna2ImageButton2.ImageSize = new System.Drawing.Size(70, 40);
            this.guna2ImageButton2.Location = new System.Drawing.Point(315, 59);
            this.guna2ImageButton2.Name = "guna2ImageButton2";
            this.guna2ImageButton2.PressedState.ImageSize = new System.Drawing.Size(70, 40);
            this.guna2ImageButton2.Size = new System.Drawing.Size(54, 50);
            this.guna2ImageButton2.TabIndex = 6;
            this.guna2ImageButton2.Click += new System.EventHandler(this.guna2ImageButton2_Click);
            // 
            // gunaSeparator2
            // 
            this.gunaSeparator2.LineColor = System.Drawing.Color.RoyalBlue;
            this.gunaSeparator2.Location = new System.Drawing.Point(315, 109);
            this.gunaSeparator2.Name = "gunaSeparator2";
            this.gunaSeparator2.Size = new System.Drawing.Size(54, 8);
            this.gunaSeparator2.TabIndex = 7;
            this.gunaSeparator2.Visible = false;
            // 
            // gunaResizeControl1
            // 
            this.gunaResizeControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaResizeControl1.ForeColor = System.Drawing.Color.Gray;
            this.gunaResizeControl1.ForeColorDepth = 255;
            this.gunaResizeControl1.Location = new System.Drawing.Point(562, 4);
            this.gunaResizeControl1.Name = "gunaResizeControl1";
            this.gunaResizeControl1.Size = new System.Drawing.Size(26, 24);
            this.gunaResizeControl1.TabIndex = 8;
            this.gunaResizeControl1.TargetControl = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(590, 499);
            this.Controls.Add(this.gunaResizeControl1);
            this.Controls.Add(this.gunaSeparator2);
            this.Controls.Add(this.guna2ImageButton2);
            this.Controls.Add(this.gunaSeparator1);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.header);
            this.Controls.Add(this.textbox);
            this.Controls.Add(this.name);
            this.Controls.Add(this.translateBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm borderlessform;
        private Guna.UI2.WinForms.Guna2GradientButton translateBtn;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI.WinForms.GunaLabel header;
        private Guna.UI.WinForms.GunaTextBox textbox;
        private Guna.UI.WinForms.GunaLabel name;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator2;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private Guna.UI.WinForms.GunaResizeControl gunaResizeControl1;
    }
}

