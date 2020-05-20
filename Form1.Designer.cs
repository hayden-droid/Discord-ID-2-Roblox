namespace DiscordID2Roblox
{
    partial class Form1
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
            this.Input = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.userPicture = new System.Windows.Forms.PictureBox();
            this.userId = new MaterialSkin.Controls.MaterialLabel();
            this.userName = new MaterialSkin.Controls.MaterialLabel();
            this.Btn = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.Depth = 0;
            this.Input.Hint = "";
            this.Input.Location = new System.Drawing.Point(12, 76);
            this.Input.MouseState = MaterialSkin.MouseState.HOVER;
            this.Input.Name = "Input";
            this.Input.PasswordChar = '\0';
            this.Input.SelectedText = "";
            this.Input.SelectionLength = 0;
            this.Input.SelectionStart = 0;
            this.Input.Size = new System.Drawing.Size(206, 23);
            this.Input.TabIndex = 0;
            this.Input.Text = "Discord ID";
            this.Input.UseSystemPasswordChar = false;
            // 
            // userPicture
            // 
            this.userPicture.Location = new System.Drawing.Point(12, 120);
            this.userPicture.Name = "userPicture";
            this.userPicture.Size = new System.Drawing.Size(206, 126);
            this.userPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPicture.TabIndex = 1;
            this.userPicture.TabStop = false;
            // 
            // userId
            // 
            this.userId.AutoSize = true;
            this.userId.Depth = 0;
            this.userId.Font = new System.Drawing.Font("Roboto", 11F);
            this.userId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.userId.Location = new System.Drawing.Point(72, 272);
            this.userId.MouseState = MaterialSkin.MouseState.HOVER;
            this.userId.Name = "userId";
            this.userId.Size = new System.Drawing.Size(54, 19);
            this.userId.TabIndex = 2;
            this.userId.Text = "UserID";
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Depth = 0;
            this.userName.Font = new System.Drawing.Font("Roboto", 11F);
            this.userName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.userName.Location = new System.Drawing.Point(70, 301);
            this.userName.MouseState = MaterialSkin.MouseState.HOVER;
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(77, 19);
            this.userName.TabIndex = 3;
            this.userName.Text = "Username";
            // 
            // Btn
            // 
            this.Btn.Depth = 0;
            this.Btn.Location = new System.Drawing.Point(74, 335);
            this.Btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn.Name = "Btn";
            this.Btn.Primary = true;
            this.Btn.Size = new System.Drawing.Size(75, 23);
            this.Btn.TabIndex = 4;
            this.Btn.Text = "Check";
            this.Btn.UseVisualStyleBackColor = true;
            this.Btn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 370);
            this.Controls.Add(this.Btn);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.userId);
            this.Controls.Add(this.userPicture);
            this.Controls.Add(this.Input);
            this.Name = "Form1";
            this.Text = "Discord ID to Roblox User";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField Input;
        private System.Windows.Forms.PictureBox userPicture;
        private MaterialSkin.Controls.MaterialLabel userId;
        private MaterialSkin.Controls.MaterialLabel userName;
        private MaterialSkin.Controls.MaterialRaisedButton Btn;
    }
}

