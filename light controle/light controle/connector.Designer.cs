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
            this.portcombobox = new System.Windows.Forms.ComboBox();
            this.connect = new System.Windows.Forms.Button();
            this.disconnect = new System.Windows.Forms.Button();
            this.Offbutton = new System.Windows.Forms.Button();
            this.Onbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // portcombobox
            // 
            this.portcombobox.FormattingEnabled = true;
            this.portcombobox.Location = new System.Drawing.Point(29, 39);
            this.portcombobox.Name = "portcombobox";
            this.portcombobox.Size = new System.Drawing.Size(222, 21);
            this.portcombobox.TabIndex = 0;
            this.portcombobox.SelectedIndexChanged += new System.EventHandler(this.connect_Click);
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
            this.Offbutton.Location = new System.Drawing.Point(161, 166);
            this.Offbutton.Name = "Offbutton";
            this.Offbutton.Size = new System.Drawing.Size(90, 35);
            this.Offbutton.TabIndex = 3;
            this.Offbutton.Text = "off";
            this.Offbutton.UseVisualStyleBackColor = true;
            this.Offbutton.Click += new System.EventHandler(this.Offbutton_Click);
            // 
            // Onbutton
            // 
            this.Onbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Onbutton.Location = new System.Drawing.Point(26, 166);
            this.Onbutton.Name = "Onbutton";
            this.Onbutton.Size = new System.Drawing.Size(90, 35);
            this.Onbutton.TabIndex = 4;
            this.Onbutton.Text = "On";
            this.Onbutton.UseVisualStyleBackColor = true;
            this.Onbutton.Click += new System.EventHandler(this.Onbutton_Click);
            // 
            // connector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Onbutton);
            this.Controls.Add(this.Offbutton);
            this.Controls.Add(this.disconnect);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.portcombobox);
            this.Name = "connector";
            this.Text = "light switch beta";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox portcombobox;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Button disconnect;
        private System.Windows.Forms.Button Offbutton;
        private System.Windows.Forms.Button Onbutton;
    }
}