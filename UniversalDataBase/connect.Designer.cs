namespace UniversalDataBase
{
    partial class connect
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
            this.usuario = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.driver = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.host = new System.Windows.Forms.TextBox();
            this.puerto = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.service = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // usuario
            // 
            this.usuario.Location = new System.Drawing.Point(88, 72);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(100, 20);
            this.usuario.TabIndex = 0;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(88, 98);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(100, 20);
            this.password.TabIndex = 1;
            // 
            // driver
            // 
            this.driver.FormattingEnabled = true;
            this.driver.Items.AddRange(new object[] {
            "Teradata",
            "SQL Server",
            "Oracle"});
            this.driver.Location = new System.Drawing.Point(26, 43);
            this.driver.Name = "driver";
            this.driver.Size = new System.Drawing.Size(257, 21);
            this.driver.TabIndex = 2;
            this.driver.Text = "Driver";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Host";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Puerto";
            // 
            // host
            // 
            this.host.Location = new System.Drawing.Point(88, 125);
            this.host.Name = "host";
            this.host.Size = new System.Drawing.Size(100, 20);
            this.host.TabIndex = 7;
            // 
            // puerto
            // 
            this.puerto.Location = new System.Drawing.Point(88, 177);
            this.puerto.Name = "puerto";
            this.puerto.Size = new System.Drawing.Size(61, 20);
            this.puerto.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Abrir conexión";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // service
            // 
            this.service.Location = new System.Drawing.Point(88, 151);
            this.service.Name = "service";
            this.service.Size = new System.Drawing.Size(100, 20);
            this.service.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "SID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nombre";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(88, 16);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(195, 20);
            this.nombre.TabIndex = 13;
            // 
            // connect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 243);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.service);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.puerto);
            this.Controls.Add(this.host);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.driver);
            this.Controls.Add(this.password);
            this.Controls.Add(this.usuario);
            this.Name = "connect";
            this.Text = "Connect";
            this.Load += new System.EventHandler(this.connect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.ComboBox driver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox host;
        private System.Windows.Forms.TextBox puerto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox service;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nombre;
    }
}