namespace Vista
{
    partial class FrmMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.btnAnotaciones = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnCitas = new System.Windows.Forms.Button();
            this.btnExpedientes = new System.Windows.Forms.Button();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelHour = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.timerControl = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.panelMenu.Controls.Add(this.labelTitle);
            this.panelMenu.Controls.Add(this.pictureBoxLogo);
            this.panelMenu.Controls.Add(this.btnAnotaciones);
            this.panelMenu.Controls.Add(this.btnClientes);
            this.panelMenu.Controls.Add(this.btnCitas);
            this.panelMenu.Controls.Add(this.btnExpedientes);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(122, 485);
            this.panelMenu.TabIndex = 1;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelTitle.Location = new System.Drawing.Point(20, 143);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(88, 18);
            this.labelTitle.TabIndex = 6;
            this.labelTitle.Text = "LawyerSoft";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::Vista.Properties.Resources.Notepad_Bloc_notes_2;
            this.pictureBoxLogo.Location = new System.Drawing.Point(5, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(112, 128);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 5;
            this.pictureBoxLogo.TabStop = false;
            // 
            // btnAnotaciones
            // 
            this.btnAnotaciones.BackColor = System.Drawing.Color.Transparent;
            this.btnAnotaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnotaciones.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnAnotaciones.ForeColor = System.Drawing.Color.Black;
            this.btnAnotaciones.Image = global::Vista.Properties.Resources.Edit_16x16;
            this.btnAnotaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnotaciones.Location = new System.Drawing.Point(10, 372);
            this.btnAnotaciones.Name = "btnAnotaciones";
            this.btnAnotaciones.Size = new System.Drawing.Size(96, 45);
            this.btnAnotaciones.TabIndex = 4;
            this.btnAnotaciones.Text = "Anotaciones";
            this.btnAnotaciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnotaciones.UseVisualStyleBackColor = false;
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.Transparent;
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnClientes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.Black;
            this.btnClientes.Image = global::Vista.Properties.Resources.User_16x16;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(10, 219);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(96, 45);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnCitas
            // 
            this.btnCitas.BackColor = System.Drawing.Color.Transparent;
            this.btnCitas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCitas.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnCitas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCitas.ForeColor = System.Drawing.Color.Black;
            this.btnCitas.Image = global::Vista.Properties.Resources.Calendar_16x16;
            this.btnCitas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCitas.Location = new System.Drawing.Point(10, 321);
            this.btnCitas.Name = "btnCitas";
            this.btnCitas.Size = new System.Drawing.Size(96, 45);
            this.btnCitas.TabIndex = 3;
            this.btnCitas.Text = "Citas";
            this.btnCitas.UseVisualStyleBackColor = false;
            // 
            // btnExpedientes
            // 
            this.btnExpedientes.BackColor = System.Drawing.Color.Transparent;
            this.btnExpedientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExpedientes.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnExpedientes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpedientes.ForeColor = System.Drawing.Color.Black;
            this.btnExpedientes.Image = global::Vista.Properties.Resources.Folder_16x16;
            this.btnExpedientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExpedientes.Location = new System.Drawing.Point(10, 270);
            this.btnExpedientes.Name = "btnExpedientes";
            this.btnExpedientes.Size = new System.Drawing.Size(96, 45);
            this.btnExpedientes.TabIndex = 2;
            this.btnExpedientes.Text = "Expedientes";
            this.btnExpedientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExpedientes.UseVisualStyleBackColor = false;
            this.btnExpedientes.Click += new System.EventHandler(this.btnExpedientes_Click);
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.panelInfo.Controls.Add(this.labelDate);
            this.panelInfo.Controls.Add(this.labelHour);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfo.Location = new System.Drawing.Point(122, 0);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(750, 35);
            this.panelInfo.TabIndex = 2;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelDate.Location = new System.Drawing.Point(5, 9);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(80, 17);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "dd/mm/yyyy";
            // 
            // labelHour
            // 
            this.labelHour.AutoSize = true;
            this.labelHour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelHour.Location = new System.Drawing.Point(88, 9);
            this.labelHour.Name = "labelHour";
            this.labelHour.Size = new System.Drawing.Size(39, 17);
            this.labelHour.TabIndex = 1;
            this.labelHour.Text = "00:00";
            // 
            // panelDesktop
            // 
            this.panelDesktop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(122, 35);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(750, 450);
            this.panelDesktop.TabIndex = 3;
            // 
            // timerControl
            // 
            this.timerControl.Enabled = true;
            this.timerControl.Tick += new System.EventHandler(this.timerControl_Tick);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(872, 485);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LawyerSoft";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnExpedientes;
        private System.Windows.Forms.Button btnCitas;
        private System.Windows.Forms.Button btnAnotaciones;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelHour;
        private System.Windows.Forms.Timer timerControl;
    }
}