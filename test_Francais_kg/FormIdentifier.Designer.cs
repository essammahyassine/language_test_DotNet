namespace test_Francais_kg
{
    partial class FormIdentifier
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
            this.textBPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX17 = new DevComponents.DotNetBar.LabelX();
            this.textBLoguin = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX15 = new DevComponents.DotNetBar.LabelX();
            this.buttonX5 = new DevComponents.DotNetBar.ButtonX();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.SuspendLayout();
            // 
            // textBPassword
            // 
            this.textBPassword.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBPassword.Border.Class = "TextBoxBorder";
            this.textBPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBPassword.DisabledBackColor = System.Drawing.Color.White;
            this.textBPassword.ForeColor = System.Drawing.Color.Black;
            this.textBPassword.Location = new System.Drawing.Point(18, 91);
            this.textBPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBPassword.Name = "textBPassword";
            this.textBPassword.PasswordChar = '*';
            this.textBPassword.PreventEnterBeep = true;
            this.textBPassword.Size = new System.Drawing.Size(368, 30);
            this.textBPassword.TabIndex = 48;
            // 
            // labelX17
            // 
            this.labelX17.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX17.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX17.ForeColor = System.Drawing.Color.Black;
            this.labelX17.Location = new System.Drawing.Point(18, 64);
            this.labelX17.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelX17.Name = "labelX17";
            this.labelX17.Size = new System.Drawing.Size(142, 27);
            this.labelX17.TabIndex = 47;
            this.labelX17.Text = "Password";
            // 
            // textBLoguin
            // 
            this.textBLoguin.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBLoguin.Border.Class = "TextBoxBorder";
            this.textBLoguin.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBLoguin.DisabledBackColor = System.Drawing.Color.White;
            this.textBLoguin.ForeColor = System.Drawing.Color.Black;
            this.textBLoguin.Location = new System.Drawing.Point(18, 27);
            this.textBLoguin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBLoguin.Name = "textBLoguin";
            this.textBLoguin.PreventEnterBeep = true;
            this.textBLoguin.Size = new System.Drawing.Size(368, 30);
            this.textBLoguin.TabIndex = 46;
            // 
            // labelX15
            // 
            this.labelX15.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX15.ForeColor = System.Drawing.Color.Black;
            this.labelX15.Location = new System.Drawing.Point(18, -3);
            this.labelX15.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelX15.Name = "labelX15";
            this.labelX15.Size = new System.Drawing.Size(142, 27);
            this.labelX15.TabIndex = 45;
            this.labelX15.Text = "Login";
            // 
            // buttonX5
            // 
            this.buttonX5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX5.Location = new System.Drawing.Point(125, 136);
            this.buttonX5.Name = "buttonX5";
            this.buttonX5.Size = new System.Drawing.Size(136, 28);
            this.buttonX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX5.TabIndex = 49;
            this.buttonX5.Text = "Connecter";
            this.buttonX5.Click += new System.EventHandler(this.buttonX5_Click);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.Teal);
            // 
            // FormIdentifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 176);
            this.Controls.Add(this.buttonX5);
            this.Controls.Add(this.textBPassword);
            this.Controls.Add(this.labelX17);
            this.Controls.Add(this.textBLoguin);
            this.Controls.Add(this.labelX15);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "FormIdentifier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Identification";
            this.Load += new System.EventHandler(this.FormIdentifier_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX textBPassword;
        private DevComponents.DotNetBar.LabelX labelX17;
        private DevComponents.DotNetBar.Controls.TextBoxX textBLoguin;
        private DevComponents.DotNetBar.LabelX labelX15;
        private DevComponents.DotNetBar.ButtonX buttonX5;
        private DevComponents.DotNetBar.StyleManager styleManager1;
    }
}