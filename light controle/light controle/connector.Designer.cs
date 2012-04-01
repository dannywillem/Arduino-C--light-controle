namespace light_controle
{
    partial class connector
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
            this.portcombobox = new System.Windows.Forms.ComboBox();
            this.connect = new System.Windows.Forms.Button();
            this.disconnect = new System.Windows.Forms.Button();
            this.Offbutton = new System.Windows.Forms.Button();
            this.Onbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Statusbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ledbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.port = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // portcombobox
            // 
            this.portcombobox.FormattingEnabled = true;
            this.portcombobox.Location = new System.Drawing.Point(29, 39);
            this.portcombobox.Name = "portcombobox";
            this.portcombobox.Size = new System.Drawing.Size(222, 21);
            this.portcombobox.TabIndex = 0;
            // 
            // connect
            // 
            this.connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connect.Location = new System.Drawing.Point(29, 67);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(87, 35);
            this.connect.TabIndex = 1;
            this.connect.Text = "connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // disconnect
            // 
            this.disconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disconnect.Location = new System.Drawing.Point(160, 67);
            this.disconnect.Name = "disconnect";
            this.disconnect.Size = new System.Drawing.Size(90, 35);
            this.disconnect.TabIndex = 2;
            this.disconnect.Text = "disconnect";
            this.disconnect.UseVisualStyleBackColor = true;
            this.disconnect.Click += new System.EventHandler(this.disconnect_Click);
            // 
            // Offbutton
            // 
            this.Offbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Offbutton.Location = new System.Drawing.Point(161, 108);
            this.Offbutton.Name = "Offbutton";
            this.Offbutton.Size = new System.Drawing.Size(90, 35);
            this.Offbutton.TabIndex = 3;
            this.Offbutton.Text = "Off";
            this.Offbutton.UseVisualStyleBackColor = true;
            this.Offbutton.Click += new System.EventHandler(this.Offbutton_Click);
            // 
            // Onbutton
            // 
            this.Onbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Onbutton.Location = new System.Drawing.Point(29, 108);
            this.Onbutton.Name = "Onbutton";
            this.Onbutton.Size = new System.Drawing.Size(90, 35);
            this.Onbutton.TabIndex = 4;
            this.Onbutton.Text = "On";
            this.Onbutton.UseVisualStyleBackColor = true;
            this.Onbutton.Click += new System.EventHandler(this.Onbutton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(29, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "On/Off";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Statusbox
            // 
            this.Statusbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Statusbox.ForeColor = System.Drawing.Color.Black;
            this.Statusbox.Location = new System.Drawing.Point(172, 194);
            this.Statusbox.Name = "Statusbox";
            this.Statusbox.ReadOnly = true;
            this.Statusbox.Size = new System.Drawing.Size(100, 24);
            this.Statusbox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Connect status:";
            // 
            // ledbox
            // 
            this.ledbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ledbox.Location = new System.Drawing.Point(172, 224);
            this.ledbox.Name = "ledbox";
            this.ledbox.ReadOnly = true;
            this.ledbox.Size = new System.Drawing.Size(100, 24);
            this.ledbox.TabIndex = 8;
            this.ledbox.TextChanged += new System.EventHandler(this.ledbox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Led is:";
            // 
            // port
            // 
            this.port.PortName = "COM4";
            // 
            // connector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ledbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Statusbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Onbutton);
            this.Controls.Add(this.Offbutton);
            this.Controls.Add(this.disconnect);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.portcombobox);
            this.Name = "connector";
            this.Text = "light switch beta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox portcombobox;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Button disconnect;
        private System.Windows.Forms.Button Offbutton;
        private System.Windows.Forms.Button Onbutton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Statusbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ledbox;
        private System.Windows.Forms.Label label2;
        private System.IO.Ports.SerialPort port;
    }
}