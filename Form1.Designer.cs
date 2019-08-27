using System;
using System.Collections;

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
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblPassengerPlace = new System.Windows.Forms.Label();
            this.lblPassengerVagon = new System.Windows.Forms.Label();
            this.lblPassengerTrainNumber = new System.Windows.Forms.Label();
            this.lblPassengerMAC = new System.Windows.Forms.Label();
            this.txtPassengerPlace = new System.Windows.Forms.TextBox();
            this.txtPassengerVagon = new System.Windows.Forms.TextBox();
            this.lblPassengerData = new System.Windows.Forms.Label();
            this.txtPassengerMAC = new System.Windows.Forms.TextBox();
            this.txtPassengerTrainNumber = new System.Windows.Forms.TextBox();
            this.txtCommandConsole = new System.Windows.Forms.TextBox();
            this.txtMainConsole = new System.Windows.Forms.TextBox();
            this.listSapsansList = new System.Windows.Forms.ListBox();
            this.tabLastochkas = new System.Windows.Forms.TabPage();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.lblPersonalPassword = new System.Windows.Forms.Label();
            this.lblPersonalLogin = new System.Windows.Forms.Label();
            this.txtPersonalPassword = new System.Windows.Forms.TextBox();
            this.txtPersonalLogin = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
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
            this.tabSapsans.Controls.Add(this.button13);
            this.tabSapsans.Controls.Add(this.button12);
            this.tabSapsans.Controls.Add(this.button11);
            this.tabSapsans.Controls.Add(this.button10);
            this.tabSapsans.Controls.Add(this.button9);
            this.tabSapsans.Controls.Add(this.button8);
            this.tabSapsans.Controls.Add(this.button7);
            this.tabSapsans.Controls.Add(this.button6);
            this.tabSapsans.Controls.Add(this.button5);
            this.tabSapsans.Controls.Add(this.button4);
            this.tabSapsans.Controls.Add(this.button3);
            this.tabSapsans.Controls.Add(this.button2);
            this.tabSapsans.Controls.Add(this.button1);
            this.tabSapsans.Controls.Add(this.btnConnect);
            this.tabSapsans.Controls.Add(this.lblPassengerPlace);
            this.tabSapsans.Controls.Add(this.lblPassengerVagon);
            this.tabSapsans.Controls.Add(this.lblPassengerTrainNumber);
            this.tabSapsans.Controls.Add(this.lblPassengerMAC);
            this.tabSapsans.Controls.Add(this.txtPassengerPlace);
            this.tabSapsans.Controls.Add(this.txtPassengerVagon);
            this.tabSapsans.Controls.Add(this.lblPassengerData);
            this.tabSapsans.Controls.Add(this.txtPassengerMAC);
            this.tabSapsans.Controls.Add(this.txtPassengerTrainNumber);
            this.tabSapsans.Controls.Add(this.txtCommandConsole);
            this.tabSapsans.Controls.Add(this.txtMainConsole);
            this.tabSapsans.Controls.Add(this.listSapsansList);
            this.tabSapsans.Location = new System.Drawing.Point(4, 22);
            this.tabSapsans.Name = "tabSapsans";
            this.tabSapsans.Padding = new System.Windows.Forms.Padding(3);
            this.tabSapsans.Size = new System.Drawing.Size(792, 637);
            this.tabSapsans.TabIndex = 0;
            this.tabSapsans.Text = "Сапсаны";
            this.tabSapsans.UseVisualStyleBackColor = true;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(246, 8);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(116, 23);
            this.btnConnect.TabIndex = 12;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
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
            // lblPassengerVagon
            // 
            this.lblPassengerVagon.AutoSize = true;
            this.lblPassengerVagon.Location = new System.Drawing.Point(3, 123);
            this.lblPassengerVagon.Name = "lblPassengerVagon";
            this.lblPassengerVagon.Size = new System.Drawing.Size(37, 13);
            this.lblPassengerVagon.TabIndex = 10;
            this.lblPassengerVagon.Text = "Вагон";
            // 
            // lblPassengerTrainNumber
            // 
            this.lblPassengerTrainNumber.AutoSize = true;
            this.lblPassengerTrainNumber.Location = new System.Drawing.Point(3, 97);
            this.lblPassengerTrainNumber.Name = "lblPassengerTrainNumber";
            this.lblPassengerTrainNumber.Size = new System.Drawing.Size(32, 13);
            this.lblPassengerTrainNumber.TabIndex = 9;
            this.lblPassengerTrainNumber.Text = "Рейс";
            // 
            // lblPassengerMAC
            // 
            this.lblPassengerMAC.AutoSize = true;
            this.lblPassengerMAC.Location = new System.Drawing.Point(3, 71);
            this.lblPassengerMAC.Name = "lblPassengerMAC";
            this.lblPassengerMAC.Size = new System.Drawing.Size(30, 13);
            this.lblPassengerMAC.TabIndex = 8;
            this.lblPassengerMAC.Text = "MAC";
            // 
            // txtPassengerPlace
            // 
            this.txtPassengerPlace.Location = new System.Drawing.Point(114, 146);
            this.txtPassengerPlace.Name = "txtPassengerPlace";
            this.txtPassengerPlace.Size = new System.Drawing.Size(100, 20);
            this.txtPassengerPlace.TabIndex = 7;
            // 
            // txtPassengerVagon
            // 
            this.txtPassengerVagon.Location = new System.Drawing.Point(114, 120);
            this.txtPassengerVagon.Name = "txtPassengerVagon";
            this.txtPassengerVagon.Size = new System.Drawing.Size(100, 20);
            this.txtPassengerVagon.TabIndex = 6;
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
            // 
            // txtPassengerMAC
            // 
            this.txtPassengerMAC.Location = new System.Drawing.Point(114, 68);
            this.txtPassengerMAC.Name = "txtPassengerMAC";
            this.txtPassengerMAC.Size = new System.Drawing.Size(100, 20);
            this.txtPassengerMAC.TabIndex = 4;
            // 
            // txtPassengerTrainNumber
            // 
            this.txtPassengerTrainNumber.Location = new System.Drawing.Point(114, 94);
            this.txtPassengerTrainNumber.Name = "txtPassengerTrainNumber";
            this.txtPassengerTrainNumber.Size = new System.Drawing.Size(100, 20);
            this.txtPassengerTrainNumber.TabIndex = 3;
            // 
            // txtCommandConsole
            // 
            this.txtCommandConsole.Location = new System.Drawing.Point(6, 614);
            this.txtCommandConsole.Name = "txtCommandConsole";
            this.txtCommandConsole.Size = new System.Drawing.Size(780, 20);
            this.txtCommandConsole.TabIndex = 2;
            this.txtCommandConsole.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCommandConsole_KeyPress);
            // 
            // txtMainConsole
            // 
            this.txtMainConsole.Location = new System.Drawing.Point(383, 8);
            this.txtMainConsole.Multiline = true;
            this.txtMainConsole.Name = "txtMainConsole";
            this.txtMainConsole.ReadOnly = true;
            this.txtMainConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMainConsole.Size = new System.Drawing.Size(403, 600);
            this.txtMainConsole.TabIndex = 1;
            // 
            // listSapsansList
            // 
            this.listSapsansList.FormattingEnabled = true;
            this.listSapsansList.Location = new System.Drawing.Point(114, 8);
            this.listSapsansList.Name = "listSapsansList";
            this.listSapsansList.Size = new System.Drawing.Size(100, 17);
            this.listSapsansList.TabIndex = 0;
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
            this.tabSettings.Controls.Add(this.lblPersonalPassword);
            this.tabSettings.Controls.Add(this.lblPersonalLogin);
            this.tabSettings.Controls.Add(this.txtPersonalPassword);
            this.tabSettings.Controls.Add(this.txtPersonalLogin);
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(792, 637);
            this.tabSettings.TabIndex = 2;
            this.tabSettings.Text = "Настройки";
            this.tabSettings.UseVisualStyleBackColor = true;
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
            // lblPersonalLogin
            // 
            this.lblPersonalLogin.AutoSize = true;
            this.lblPersonalLogin.Location = new System.Drawing.Point(8, 19);
            this.lblPersonalLogin.Name = "lblPersonalLogin";
            this.lblPersonalLogin.Size = new System.Drawing.Size(38, 13);
            this.lblPersonalLogin.TabIndex = 3;
            this.lblPersonalLogin.Text = "Логин";
            // 
            // txtPersonalPassword
            // 
            this.txtPersonalPassword.Location = new System.Drawing.Point(141, 42);
            this.txtPersonalPassword.Name = "txtPersonalPassword";
            this.txtPersonalPassword.PasswordChar = '*';
            this.txtPersonalPassword.Size = new System.Drawing.Size(223, 20);
            this.txtPersonalPassword.TabIndex = 1;
            // 
            // txtPersonalLogin
            // 
            this.txtPersonalLogin.Location = new System.Drawing.Point(141, 16);
            this.txtPersonalLogin.Name = "txtPersonalLogin";
            this.txtPersonalLogin.PasswordChar = '*';
            this.txtPersonalLogin.Size = new System.Drawing.Size(223, 20);
            this.txtPersonalLogin.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(148, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(269, 194);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 35);
            this.button3.TabIndex = 14;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(27, 250);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 35);
            this.button4.TabIndex = 15;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(148, 250);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 35);
            this.button5.TabIndex = 16;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(269, 250);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 35);
            this.button6.TabIndex = 17;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(27, 308);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 35);
            this.button7.TabIndex = 18;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(148, 308);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 35);
            this.button8.TabIndex = 19;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(269, 308);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 35);
            this.button9.TabIndex = 20;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(8, 372);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 35);
            this.button10.TabIndex = 21;
            this.button10.Text = "button10";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(102, 372);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 35);
            this.button11.TabIndex = 22;
            this.button11.Text = "button11";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(196, 372);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 35);
            this.button12.TabIndex = 23;
            this.button12.Text = "button12";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(287, 372);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 35);
            this.button13.TabIndex = 24;
            this.button13.Text = "button13";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 663);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "BattleScreen Alpha";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Label lblPersonalPassword;
        private System.Windows.Forms.Label lblPersonalLogin;
        private System.Windows.Forms.TextBox txtPersonalPassword;
        private System.Windows.Forms.TextBox txtPersonalLogin;
        private System.Windows.Forms.TextBox txtPassengerMAC;
        private System.Windows.Forms.TextBox txtPassengerTrainNumber;
        private System.Windows.Forms.TextBox txtCommandConsole;
        private System.Windows.Forms.TextBox txtMainConsole;
        private System.Windows.Forms.Label lblPassengerData;
        private System.Windows.Forms.Label lblPassengerTrainNumber;
        private System.Windows.Forms.Label lblPassengerMAC;
        private System.Windows.Forms.TextBox txtPassengerPlace;
        private System.Windows.Forms.TextBox txtPassengerVagon;
        private System.Windows.Forms.Label lblPassengerPlace;
        private System.Windows.Forms.Label lblPassengerVagon;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
    }
}

