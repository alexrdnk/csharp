using System.Data;
using System.Windows.Forms;

namespace Home_Accounting
{
    partial class HomeAcc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeAcc));
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.AccNameText = new System.Windows.Forms.Label();
            this.AccNameBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.NameText = new System.Windows.Forms.Label();
            this.BalanceBox = new System.Windows.Forms.TextBox();
            this.BalanceText = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.AccDataList = new System.Windows.Forms.DataGridView();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SearchText = new System.Windows.Forms.Label();
            this.ExitBox = new System.Windows.Forms.PictureBox();
            this.LogoText = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccDataList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(56, 20);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(167, 159);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 1;
            this.pictureBoxLogo.TabStop = false;
            // 
            // AccNameText
            // 
            this.AccNameText.AutoSize = true;
            this.AccNameText.BackColor = System.Drawing.Color.Transparent;
            this.AccNameText.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccNameText.ForeColor = System.Drawing.SystemColors.GrayText;
            this.AccNameText.Location = new System.Drawing.Point(145, 442);
            this.AccNameText.Name = "AccNameText";
            this.AccNameText.Size = new System.Drawing.Size(129, 26);
            this.AccNameText.TabIndex = 2;
            this.AccNameText.Text = "Account ID";
            // 
            // AccNameBox
            // 
            this.AccNameBox.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccNameBox.Location = new System.Drawing.Point(285, 442);
            this.AccNameBox.Name = "AccNameBox";
            this.AccNameBox.ReadOnly = true;
            this.AccNameBox.Size = new System.Drawing.Size(186, 31);
            this.AccNameBox.TabIndex = 3;
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBox.Location = new System.Drawing.Point(285, 525);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(186, 31);
            this.NameBox.TabIndex = 5;
            // 
            // NameText
            // 
            this.NameText.AutoSize = true;
            this.NameText.BackColor = System.Drawing.Color.Transparent;
            this.NameText.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameText.ForeColor = System.Drawing.SystemColors.GrayText;
            this.NameText.Location = new System.Drawing.Point(193, 528);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(65, 26);
            this.NameText.TabIndex = 4;
            this.NameText.Text = "Name";
            // 
            // BalanceBox
            // 
            this.BalanceBox.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceBox.Location = new System.Drawing.Point(285, 615);
            this.BalanceBox.Name = "BalanceBox";
            this.BalanceBox.Size = new System.Drawing.Size(186, 31);
            this.BalanceBox.TabIndex = 7;
            // 
            // BalanceText
            // 
            this.BalanceText.AutoSize = true;
            this.BalanceText.BackColor = System.Drawing.Color.Transparent;
            this.BalanceText.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceText.ForeColor = System.Drawing.SystemColors.GrayText;
            this.BalanceText.Location = new System.Drawing.Point(178, 618);
            this.BalanceText.Name = "BalanceText";
            this.BalanceText.Size = new System.Drawing.Size(96, 26);
            this.BalanceText.TabIndex = 6;
            this.BalanceText.Text = "Balance";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonAdd.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdd.Location = new System.Drawing.Point(608, 956);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(134, 50);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonUpdate.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonUpdate.Location = new System.Drawing.Point(903, 956);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(134, 50);
            this.buttonUpdate.TabIndex = 9;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.IndianRed;
            this.buttonDelete.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDelete.Location = new System.Drawing.Point(1196, 956);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(134, 50);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // AccDataList
            // 
            this.AccDataList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AccDataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccDataList.Location = new System.Drawing.Point(550, 182);
            this.AccDataList.Name = "AccDataList";
            this.AccDataList.RowHeadersWidth = 51;
            this.AccDataList.RowTemplate.Height = 45;
            this.AccDataList.Size = new System.Drawing.Size(1426, 716);
            this.AccDataList.TabIndex = 11;
            this.AccDataList.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.AccDataList_RowHeaderMouseClick);
            // 
            // SearchBox
            // 
            this.SearchBox.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.Location = new System.Drawing.Point(813, 120);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(501, 32);
            this.SearchBox.TabIndex = 13;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // SearchText
            // 
            this.SearchText.AutoSize = true;
            this.SearchText.BackColor = System.Drawing.Color.Transparent;
            this.SearchText.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchText.ForeColor = System.Drawing.SystemColors.GrayText;
            this.SearchText.Location = new System.Drawing.Point(704, 123);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(87, 26);
            this.SearchText.TabIndex = 12;
            this.SearchText.Text = "Search";
            // 
            // ExitBox
            // 
            this.ExitBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ExitBox.Image = ((System.Drawing.Image)(resources.GetObject("ExitBox.Image")));
            this.ExitBox.Location = new System.Drawing.Point(1926, 33);
            this.ExitBox.Name = "ExitBox";
            this.ExitBox.Size = new System.Drawing.Size(40, 40);
            this.ExitBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ExitBox.TabIndex = 14;
            this.ExitBox.TabStop = false;
            this.ExitBox.Click += new System.EventHandler(this.ExitBox_Click);
            // 
            // LogoText
            // 
            this.LogoText.AutoSize = true;
            this.LogoText.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoText.ForeColor = System.Drawing.Color.Ivory;
            this.LogoText.Location = new System.Drawing.Point(249, 76);
            this.LogoText.Name = "LogoText";
            this.LogoText.Size = new System.Drawing.Size(252, 35);
            this.LogoText.TabIndex = 15;
            this.LogoText.Text = "My Accounting";
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.Goldenrod;
            this.ClearButton.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClearButton.Location = new System.Drawing.Point(307, 696);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(134, 50);
            this.ClearButton.TabIndex = 16;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // HomeAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1942, 1080);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.LogoText);
            this.Controls.Add(this.ExitBox);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.SearchText);
            this.Controls.Add(this.AccDataList);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.BalanceBox);
            this.Controls.Add(this.BalanceText);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.AccNameBox);
            this.Controls.Add(this.AccNameText);
            this.Controls.Add(this.pictureBoxLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeAcc";
            this.Text = "Home Accounting";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccDataList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label AccNameText;
        private System.Windows.Forms.TextBox AccNameBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label NameText;
        private System.Windows.Forms.TextBox BalanceBox;
        private System.Windows.Forms.Label BalanceText;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridView AccDataList;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label SearchText;
        private System.Windows.Forms.PictureBox ExitBox;
        private System.Windows.Forms.Label LogoText;
        private Button ClearButton;
    }
}

