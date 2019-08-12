namespace BattleScreen
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSapsans = new System.Windows.Forms.TabPage();
            this.tabLastochkas = new System.Windows.Forms.TabPage();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.txtPersonalLogin = new System.Windows.Forms.TextBox();
            this.txtPersonalPassword = new System.Windows.Forms.TextBox();
            this.txtPathToPlink = new System.Windows.Forms.TextBox();
            this.lblPersonalLogin = new System.Windows.Forms.Label();
            this.lblPersonalPassword = new System.Windows.Forms.Label();
            this.lblPathToPlink = new System.Windows.Forms.Label();
            this.listSapsansList = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtPassengerTrainNumber = new System.Windows.Forms.TextBox();
            this.txtPassengerMAC = new System.Windows.Forms.TextBox();
            this.lblPassengerData = new System.Windows.Forms.Label();
            this.txtPassengerVagon = new System.Windows.Forms.TextBox();
            this.txtPassengerPlace = new System.Windows.Forms.TextBox();
            this.lblPassengerMAC = new System.Windows.Forms.Label();
            this.lblPassengerTrainNumber = new System.Windows.Forms.Label();
            this.lblPassengerVagon = new System.Windows.Forms.Label();
            this.lblPassengerPlace = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabSapsans.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSapsans);
            this.tabControl1.Controls.Add(this.tabLastochkas);
            this.tabControl1.Controls.Add(this.tabSettings);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 663);
            this.tabControl1.TabIndex = 0;
            // 
            // tabSapsans
            // 
            this.tabSapsans.Controls.Add(this.lblPassengerPlace);
            this.tabSapsans.Controls.Add(this.lblPassengerVagon);
            this.tabSapsans.Controls.Add(this.lblPassengerTrainNumber);
            this.tabSapsans.Controls.Add(this.lblPassengerMAC);
            this.tabSapsans.Controls.Add(this.txtPassengerPlace);
            this.tabSapsans.Controls.Add(this.txtPassengerVagon);
            this.tabSapsans.Controls.Add(this.lblPassengerData);
            this.tabSapsans.Controls.Add(this.txtPassengerMAC);
            this.tabSapsans.Controls.Add(this.txtPassengerTrainNumber);
            this.tabSapsans.Controls.Add(this.textBox2);
            this.tabSapsans.Controls.Add(this.textBox1);
            this.tabSapsans.Controls.Add(this.listSapsansList);
            this.tabSapsans.Location = new System.Drawing.Point(4, 22);
            this.tabSapsans.Name = "tabSapsans";
            this.tabSapsans.Padding = new System.Windows.Forms.Padding(3);
            this.tabSapsans.Size = new System.Drawing.Size(792, 637);
            this.tabSapsans.TabIndex = 0;
            this.tabSapsans.Text = "Сапсаны";
            this.tabSapsans.UseVisualStyleBackColor = true;
            // 
            // tabLastochkas
            // 
            this.tabLastochkas.Location = new System.Drawing.Point(4, 22);
            this.tabLastochkas.Name = "tabLastochkas";
            this.tabLastochkas.Padding = new System.Windows.Forms.Padding(3);
            this.tabLastochkas.Size = new System.Drawing.Size(792, 637);
            this.tabLastochkas.TabIndex = 1;
            this.tabLastochkas.Text = "Ласточки(WIP)";
            this.tabLastochkas.UseVisualStyleBackColor = true;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.lblPathToPlink);
            this.tabSettings.Controls.Add(this.lblPersonalPassword);
            this.tabSettings.Controls.Add(this.lblPersonalLogin);
            this.tabSettings.Controls.Add(this.txtPathToPlink);
            this.tabSettings.Controls.Add(this.txtPersonalPassword);
            this.tabSettings.Controls.Add(this.txtPersonalLogin);
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(792, 637);
            this.tabSettings.TabIndex = 2;
            this.tabSettings.Text = "Настройки";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // txtPersonalLogin
            // 
            this.txtPersonalLogin.Location = new System.Drawing.Point(141, 16);
            this.txtPersonalLogin.Name = "txtPersonalLogin";
            this.txtPersonalLogin.Size = new System.Drawing.Size(223, 20);
            this.txtPersonalLogin.TabIndex = 0;
            // 
            // txtPersonalPassword
            // 
            this.txtPersonalPassword.Location = new System.Drawing.Point(141, 42);
            this.txtPersonalPassword.Name = "txtPersonalPassword";
            this.txtPersonalPassword.Size = new System.Drawing.Size(223, 20);
            this.txtPersonalPassword.TabIndex = 1;
            // 
            // txtPathToPlink
            // 
            this.txtPathToPlink.Location = new System.Drawing.Point(141, 68);
            this.txtPathToPlink.Name = "txtPathToPlink";
            this.txtPathToPlink.Size = new System.Drawing.Size(467, 20);
            this.txtPathToPlink.TabIndex = 2;
            // 
            // lblPersonalLogin
            // 
            this.lblPersonalLogin.AutoSize = true;
            this.lblPersonalLogin.Location = new System.Drawing.Point(8, 19);
            this.lblPersonalLogin.Name = "lblPersonalLogin";
            this.lblPersonalLogin.Size = new System.Drawing.Size(38, 13);
            this.lblPersonalLogin.TabIndex = 3;
            this.lblPersonalLogin.Text = "Логин";
            // 
            // lblPersonalPassword
            // 
            this.lblPersonalPassword.AutoSize = true;
            this.lblPersonalPassword.Location = new System.Drawing.Point(8, 45);
            this.lblPersonalPassword.Name = "lblPersonalPassword";
            this.lblPersonalPassword.Size = new System.Drawing.Size(45, 13);
            this.lblPersonalPassword.TabIndex = 4;
            this.lblPersonalPassword.Text = "Пароль";
            // 
            // lblPathToPlink
            // 
            this.lblPathToPlink.AutoSize = true;
            this.lblPathToPlink.Location = new System.Drawing.Point(8, 71);
            this.lblPathToPlink.Name = "lblPathToPlink";
            this.lblPathToPlink.Size = new System.Drawing.Size(85, 13);
            this.lblPathToPlink.TabIndex = 5;
            this.lblPathToPlink.Text = "Путь к plink.exe";
            // 
            // listSapsansList
            // 
            this.listSapsansList.FormattingEnabled = true;
            this.listSapsansList.Items.AddRange(new object[] {
            "ЭВС1",
            "ЭВС2",
            "ЭВС3",
            "ЭВС4",
            "ЭВС5",
            "ЭВС6",
            "ЭВС7",
            "ЭВС8",
            "ЭВС9",
            "ЭВС10",
            "ЭВС11",
            "ЭВС12",
            "ЭВС13",
            "ЭВС14",
            "ЭВС15",
            "ЭВС16"});
            this.listSapsansList.Location = new System.Drawing.Point(114, 8);
            this.listSapsansList.Name = "listSapsansList";
            this.listSapsansList.Size = new System.Drawing.Size(100, 17);
            this.listSapsansList.TabIndex = 0;
            this.listSapsansList.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(383, 8);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(403, 600);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 614);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(780, 20);
            this.textBox2.TabIndex = 2;
            // 
            // txtPassengerTrainNumber
            // 
            this.txtPassengerTrainNumber.Location = new System.Drawing.Point(114, 94);
            this.txtPassengerTrainNumber.Name = "txtPassengerTrainNumber";
            this.txtPassengerTrainNumber.Size = new System.Drawing.Size(100, 20);
            this.txtPassengerTrainNumber.TabIndex = 3;
            this.txtPassengerTrainNumber.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // txtPassengerMAC
            // 
            this.txtPassengerMAC.Location = new System.Drawing.Point(114, 68);
            this.txtPassengerMAC.Name = "txtPassengerMAC";
            this.txtPassengerMAC.Size = new System.Drawing.Size(100, 20);
            this.txtPassengerMAC.TabIndex = 4;
            // 
            // lblPassengerData
            // 
            this.lblPassengerData.AutoSize = true;
            this.lblPassengerData.Location = new System.Drawing.Point(111, 40);
            this.lblPassengerData.Name = "lblPassengerData";
            this.lblPassengerData.Size = new System.Drawing.Size(107, 13);
            this.lblPassengerData.TabIndex = 5;
            this.lblPassengerData.Text = "Данные пассажира";
            this.lblPassengerData.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPassengerData.Click += new System.EventHandler(this.Label1_Click);
            // 
            // txtPassengerVagon
            // 
            this.txtPassengerVagon.Location = new System.Drawing.Point(114, 120);
            this.txtPassengerVagon.Name = "txtPassengerVagon";
            this.txtPassengerVagon.Size = new System.Drawing.Size(100, 20);
            this.txtPassengerVagon.TabIndex = 6;
            // 
            // txtPassengerPlace
            // 
            this.txtPassengerPlace.Location = new System.Drawing.Point(114, 146);
            this.txtPassengerPlace.Name = "txtPassengerPlace";
            this.txtPassengerPlace.Size = new System.Drawing.Size(100, 20);
            this.txtPassengerPlace.TabIndex = 7;
            // 
            // lblPassengerMAC
            // 
            this.lblPassengerMAC.AutoSize = true;
            this.lblPassengerMAC.Location = new System.Drawing.Point(3, 71);
            this.lblPassengerMAC.Name = "lblPassengerMAC";
            this.lblPassengerMAC.Size = new System.Drawing.Size(30, 13);
            this.lblPassengerMAC.TabIndex = 8;
            this.lblPassengerMAC.Text = "MAC";
            this.lblPassengerMAC.Click += new System.EventHandler(this.Label2_Click);
            // 
            // lblPassengerTrainNumber
            // 
            this.lblPassengerTrainNumber.AutoSize = true;
            this.lblPassengerTrainNumber.Location = new System.Drawing.Point(3, 97);
            this.lblPassengerTrainNumber.Name = "lblPassengerTrainNumber";
            this.lblPassengerTrainNumber.Size = new System.Drawing.Size(32, 13);
            this.lblPassengerTrainNumber.TabIndex = 9;
            this.lblPassengerTrainNumber.Text = "Рейс";
            this.lblPassengerTrainNumber.Click += new System.EventHandler(this.Label3_Click);
            // 
            // lblPassengerVagon
            // 
            this.lblPassengerVagon.AutoSize = true;
            this.lblPassengerVagon.Location = new System.Drawing.Point(3, 123);
            this.lblPassengerVagon.Name = "lblPassengerVagon";
            this.lblPassengerVagon.Size = new System.Drawing.Size(37, 13);
            this.lblPassengerVagon.TabIndex = 10;
            this.lblPassengerVagon.Text = "Вагон";
            // 
            // lblPassengerPlace
            // 
            this.lblPassengerPlace.AutoSize = true;
            this.lblPassengerPlace.Location = new System.Drawing.Point(3, 149);
            this.lblPassengerPlace.Name = "lblPassengerPlace";
            this.lblPassengerPlace.Size = new System.Drawing.Size(39, 13);
            this.lblPassengerPlace.TabIndex = 11;
            this.lblPassengerPlace.Text = "Место";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 663);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabSapsans.ResumeLayout(false);
            this.tabSapsans.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSapsans;
        private System.Windows.Forms.TabPage tabLastochkas;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.ListBox listSapsansList;
        private System.Windows.Forms.Label lblPathToPlink;
        private System.Windows.Forms.Label lblPersonalPassword;
        private System.Windows.Forms.Label lblPersonalLogin;
        private System.Windows.Forms.TextBox txtPathToPlink;
        private System.Windows.Forms.TextBox txtPersonalPassword;
        private System.Windows.Forms.TextBox txtPersonalLogin;
        private System.Windows.Forms.TextBox txtPassengerMAC;
        private System.Windows.Forms.TextBox txtPassengerTrainNumber;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblPassengerData;
        private System.Windows.Forms.Label lblPassengerTrainNumber;
        private System.Windows.Forms.Label lblPassengerMAC;
        private System.Windows.Forms.TextBox txtPassengerPlace;
        private System.Windows.Forms.TextBox txtPassengerVagon;
        private System.Windows.Forms.Label lblPassengerPlace;
        private System.Windows.Forms.Label lblPassengerVagon;
    }
}

