namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox6 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PlayerName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.KillsLabelCount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.RetreatsLabelCount = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DeathsLabelCount = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.MadeRetreatLabel = new System.Windows.Forms.Label();
            this.KillButtonPlus = new System.Windows.Forms.Button();
            this.KillButtonMinus = new System.Windows.Forms.Button();
            this.RetreatButtonPlus = new System.Windows.Forms.Button();
            this.RetreatButtonMinus = new System.Windows.Forms.Button();
            this.DeathButtonPlus = new System.Windows.Forms.Button();
            this.DeathButtonMinus = new System.Windows.Forms.Button();
            this.MadeRetreatPlus = new System.Windows.Forms.Button();
            this.MadeRetreatMinus = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Names = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.two = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.one = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Corbel", 32F);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(582, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "Luminar Training System";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Corbel", 13F);
            this.listBox1.ForeColor = System.Drawing.Color.Silver;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 27;
            this.listBox1.Location = new System.Drawing.Point(32, 93);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(288, 243);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox6
            // 
            this.listBox6.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.listBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox6.Font = new System.Drawing.Font("Corbel", 12F);
            this.listBox6.ForeColor = System.Drawing.Color.Silver;
            this.listBox6.FormattingEnabled = true;
            this.listBox6.ItemHeight = 24;
            this.listBox6.Location = new System.Drawing.Point(664, 563);
            this.listBox6.Name = "listBox6";
            this.listBox6.Size = new System.Drawing.Size(959, 216);
            this.listBox6.TabIndex = 6;
            this.listBox6.SelectedIndexChanged += new System.EventHandler(this.listBox6_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Corbel", 10F);
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(32, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Remove Selected Player";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Corbel", 10F);
            this.button2.ForeColor = System.Drawing.Color.Silver;
            this.button2.Location = new System.Drawing.Point(12, 383);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 27);
            this.button2.TabIndex = 8;
            this.button2.Text = "Add Player";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Corbel", 12F);
            this.textBox1.ForeColor = System.Drawing.Color.Silver;
            this.textBox1.Location = new System.Drawing.Point(134, 383);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(268, 25);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Corbel", 9F);
            this.textBox2.ForeColor = System.Drawing.Color.Silver;
            this.textBox2.Location = new System.Drawing.Point(366, 95);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(393, 79);
            this.textBox2.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SteelBlue;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Corbel", 11F);
            this.button3.ForeColor = System.Drawing.Color.Silver;
            this.button3.Location = new System.Drawing.Point(1170, 342);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(199, 37);
            this.button3.TabIndex = 11;
            this.button3.Text = "Reset Current Round";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SteelBlue;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Corbel", 9F);
            this.button4.ForeColor = System.Drawing.Color.Silver;
            this.button4.Location = new System.Drawing.Point(345, 180);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(205, 34);
            this.button4.TabIndex = 12;
            this.button4.Text = "Enter Warning for Selected";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.SteelBlue;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Corbel", 9F);
            this.button6.ForeColor = System.Drawing.Color.Silver;
            this.button6.Location = new System.Drawing.Point(556, 180);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(225, 34);
            this.button6.TabIndex = 14;
            this.button6.Text = "Remove Warning for Selected";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.SteelBlue;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Corbel", 11F);
            this.button7.ForeColor = System.Drawing.Color.Silver;
            this.button7.Location = new System.Drawing.Point(452, 220);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(174, 34);
            this.button7.TabIndex = 15;
            this.button7.Text = "Add Personal Note";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Corbel", 18F);
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(12, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 37);
            this.label2.TabIndex = 16;
            this.label2.Text = "Current Selected Luminar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Corbel", 18F);
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(12, 450);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 37);
            this.label3.TabIndex = 17;
            this.label3.Text = "Name:";
            // 
            // PlayerName
            // 
            this.PlayerName.AutoSize = true;
            this.PlayerName.BackColor = System.Drawing.Color.Transparent;
            this.PlayerName.Font = new System.Drawing.Font("Corbel", 18F);
            this.PlayerName.ForeColor = System.Drawing.Color.Silver;
            this.PlayerName.Location = new System.Drawing.Point(12, 487);
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Size = new System.Drawing.Size(65, 37);
            this.PlayerName.TabIndex = 18;
            this.PlayerName.Text = "N/A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Corbel", 18F);
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(12, 524);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 37);
            this.label5.TabIndex = 19;
            this.label5.Text = "Kills:";
            // 
            // KillsLabelCount
            // 
            this.KillsLabelCount.AutoSize = true;
            this.KillsLabelCount.BackColor = System.Drawing.Color.Transparent;
            this.KillsLabelCount.Font = new System.Drawing.Font("Corbel", 18F);
            this.KillsLabelCount.ForeColor = System.Drawing.Color.Silver;
            this.KillsLabelCount.Location = new System.Drawing.Point(53, 563);
            this.KillsLabelCount.Name = "KillsLabelCount";
            this.KillsLabelCount.Size = new System.Drawing.Size(32, 37);
            this.KillsLabelCount.TabIndex = 20;
            this.KillsLabelCount.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Corbel", 18F);
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(12, 598);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 37);
            this.label7.TabIndex = 21;
            this.label7.Text = "Retreats:";
            // 
            // RetreatsLabelCount
            // 
            this.RetreatsLabelCount.AutoSize = true;
            this.RetreatsLabelCount.BackColor = System.Drawing.Color.Transparent;
            this.RetreatsLabelCount.Font = new System.Drawing.Font("Corbel", 18F);
            this.RetreatsLabelCount.ForeColor = System.Drawing.Color.Silver;
            this.RetreatsLabelCount.Location = new System.Drawing.Point(53, 635);
            this.RetreatsLabelCount.Name = "RetreatsLabelCount";
            this.RetreatsLabelCount.Size = new System.Drawing.Size(32, 37);
            this.RetreatsLabelCount.TabIndex = 22;
            this.RetreatsLabelCount.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Corbel", 18F);
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(11, 672);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 37);
            this.label9.TabIndex = 23;
            this.label9.Text = "Deaths:";
            // 
            // DeathsLabelCount
            // 
            this.DeathsLabelCount.AutoSize = true;
            this.DeathsLabelCount.BackColor = System.Drawing.Color.Transparent;
            this.DeathsLabelCount.Font = new System.Drawing.Font("Corbel", 18F);
            this.DeathsLabelCount.ForeColor = System.Drawing.Color.Silver;
            this.DeathsLabelCount.Location = new System.Drawing.Point(55, 711);
            this.DeathsLabelCount.Name = "DeathsLabelCount";
            this.DeathsLabelCount.Size = new System.Drawing.Size(32, 37);
            this.DeathsLabelCount.TabIndex = 24;
            this.DeathsLabelCount.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Corbel", 18F);
            this.label11.ForeColor = System.Drawing.Color.Silver;
            this.label11.Location = new System.Drawing.Point(12, 746);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(206, 37);
            this.label11.TabIndex = 25;
            this.label11.Text = "Made Retreats:";
            // 
            // MadeRetreatLabel
            // 
            this.MadeRetreatLabel.AutoSize = true;
            this.MadeRetreatLabel.BackColor = System.Drawing.Color.Transparent;
            this.MadeRetreatLabel.Font = new System.Drawing.Font("Corbel", 18F);
            this.MadeRetreatLabel.ForeColor = System.Drawing.Color.Silver;
            this.MadeRetreatLabel.Location = new System.Drawing.Point(53, 786);
            this.MadeRetreatLabel.Name = "MadeRetreatLabel";
            this.MadeRetreatLabel.Size = new System.Drawing.Size(32, 37);
            this.MadeRetreatLabel.TabIndex = 26;
            this.MadeRetreatLabel.Text = "0";
            // 
            // KillButtonPlus
            // 
            this.KillButtonPlus.BackColor = System.Drawing.Color.Green;
            this.KillButtonPlus.FlatAppearance.BorderSize = 0;
            this.KillButtonPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KillButtonPlus.Font = new System.Drawing.Font("Corbel", 12F);
            this.KillButtonPlus.ForeColor = System.Drawing.Color.Silver;
            this.KillButtonPlus.Location = new System.Drawing.Point(95, 573);
            this.KillButtonPlus.Name = "KillButtonPlus";
            this.KillButtonPlus.Size = new System.Drawing.Size(29, 29);
            this.KillButtonPlus.TabIndex = 27;
            this.KillButtonPlus.Text = "+";
            this.KillButtonPlus.UseVisualStyleBackColor = false;
            this.KillButtonPlus.Click += new System.EventHandler(this.KillButtonPlus_Click);
            // 
            // KillButtonMinus
            // 
            this.KillButtonMinus.BackColor = System.Drawing.Color.Maroon;
            this.KillButtonMinus.FlatAppearance.BorderSize = 0;
            this.KillButtonMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KillButtonMinus.Font = new System.Drawing.Font("Corbel", 12F);
            this.KillButtonMinus.ForeColor = System.Drawing.Color.Silver;
            this.KillButtonMinus.Location = new System.Drawing.Point(18, 569);
            this.KillButtonMinus.Name = "KillButtonMinus";
            this.KillButtonMinus.Size = new System.Drawing.Size(29, 29);
            this.KillButtonMinus.TabIndex = 28;
            this.KillButtonMinus.Text = "-";
            this.KillButtonMinus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.KillButtonMinus.UseVisualStyleBackColor = false;
            this.KillButtonMinus.Click += new System.EventHandler(this.KillButtonMinus_Click);
            // 
            // RetreatButtonPlus
            // 
            this.RetreatButtonPlus.BackColor = System.Drawing.Color.Green;
            this.RetreatButtonPlus.FlatAppearance.BorderSize = 0;
            this.RetreatButtonPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RetreatButtonPlus.Font = new System.Drawing.Font("Corbel", 12F);
            this.RetreatButtonPlus.ForeColor = System.Drawing.Color.Silver;
            this.RetreatButtonPlus.Location = new System.Drawing.Point(95, 645);
            this.RetreatButtonPlus.Name = "RetreatButtonPlus";
            this.RetreatButtonPlus.Size = new System.Drawing.Size(29, 29);
            this.RetreatButtonPlus.TabIndex = 29;
            this.RetreatButtonPlus.Text = "+";
            this.RetreatButtonPlus.UseVisualStyleBackColor = false;
            this.RetreatButtonPlus.Click += new System.EventHandler(this.RetreatButtonPlus_Click);
            // 
            // RetreatButtonMinus
            // 
            this.RetreatButtonMinus.BackColor = System.Drawing.Color.Maroon;
            this.RetreatButtonMinus.FlatAppearance.BorderSize = 0;
            this.RetreatButtonMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RetreatButtonMinus.Font = new System.Drawing.Font("Corbel", 12F);
            this.RetreatButtonMinus.ForeColor = System.Drawing.Color.Silver;
            this.RetreatButtonMinus.Location = new System.Drawing.Point(19, 643);
            this.RetreatButtonMinus.Name = "RetreatButtonMinus";
            this.RetreatButtonMinus.Size = new System.Drawing.Size(29, 29);
            this.RetreatButtonMinus.TabIndex = 30;
            this.RetreatButtonMinus.Text = "-";
            this.RetreatButtonMinus.UseVisualStyleBackColor = false;
            this.RetreatButtonMinus.Click += new System.EventHandler(this.RetreatButtonMinus_Click);
            // 
            // DeathButtonPlus
            // 
            this.DeathButtonPlus.BackColor = System.Drawing.Color.Green;
            this.DeathButtonPlus.FlatAppearance.BorderSize = 0;
            this.DeathButtonPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeathButtonPlus.Font = new System.Drawing.Font("Corbel", 12F);
            this.DeathButtonPlus.ForeColor = System.Drawing.Color.Silver;
            this.DeathButtonPlus.Location = new System.Drawing.Point(95, 714);
            this.DeathButtonPlus.Name = "DeathButtonPlus";
            this.DeathButtonPlus.Size = new System.Drawing.Size(29, 29);
            this.DeathButtonPlus.TabIndex = 31;
            this.DeathButtonPlus.Text = "+";
            this.DeathButtonPlus.UseVisualStyleBackColor = false;
            this.DeathButtonPlus.Click += new System.EventHandler(this.DeathButtonPlus_Click);
            // 
            // DeathButtonMinus
            // 
            this.DeathButtonMinus.BackColor = System.Drawing.Color.Maroon;
            this.DeathButtonMinus.FlatAppearance.BorderSize = 0;
            this.DeathButtonMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeathButtonMinus.Font = new System.Drawing.Font("Corbel", 12F);
            this.DeathButtonMinus.ForeColor = System.Drawing.Color.Silver;
            this.DeathButtonMinus.Location = new System.Drawing.Point(19, 714);
            this.DeathButtonMinus.Name = "DeathButtonMinus";
            this.DeathButtonMinus.Size = new System.Drawing.Size(29, 29);
            this.DeathButtonMinus.TabIndex = 32;
            this.DeathButtonMinus.Text = "-";
            this.DeathButtonMinus.UseVisualStyleBackColor = false;
            this.DeathButtonMinus.Click += new System.EventHandler(this.DeathButtonMinus_Click);
            // 
            // MadeRetreatPlus
            // 
            this.MadeRetreatPlus.BackColor = System.Drawing.Color.Green;
            this.MadeRetreatPlus.FlatAppearance.BorderSize = 0;
            this.MadeRetreatPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MadeRetreatPlus.Font = new System.Drawing.Font("Corbel", 12F);
            this.MadeRetreatPlus.ForeColor = System.Drawing.Color.Silver;
            this.MadeRetreatPlus.Location = new System.Drawing.Point(95, 793);
            this.MadeRetreatPlus.Name = "MadeRetreatPlus";
            this.MadeRetreatPlus.Size = new System.Drawing.Size(29, 29);
            this.MadeRetreatPlus.TabIndex = 33;
            this.MadeRetreatPlus.Text = "+";
            this.MadeRetreatPlus.UseVisualStyleBackColor = false;
            this.MadeRetreatPlus.Click += new System.EventHandler(this.MadeRetreatPlus_Click);
            // 
            // MadeRetreatMinus
            // 
            this.MadeRetreatMinus.BackColor = System.Drawing.Color.Maroon;
            this.MadeRetreatMinus.FlatAppearance.BorderSize = 0;
            this.MadeRetreatMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MadeRetreatMinus.Font = new System.Drawing.Font("Corbel", 12F);
            this.MadeRetreatMinus.ForeColor = System.Drawing.Color.Silver;
            this.MadeRetreatMinus.Location = new System.Drawing.Point(19, 793);
            this.MadeRetreatMinus.Name = "MadeRetreatMinus";
            this.MadeRetreatMinus.Size = new System.Drawing.Size(29, 29);
            this.MadeRetreatMinus.TabIndex = 34;
            this.MadeRetreatMinus.Text = "-";
            this.MadeRetreatMinus.UseVisualStyleBackColor = false;
            this.MadeRetreatMinus.Click += new System.EventHandler(this.MadeRetreatMinus_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Names,
            this.two,
            this.one,
            this.columnHeader1});
            this.listView1.Font = new System.Drawing.Font("Corbel", 10F);
            this.listView1.ForeColor = System.Drawing.Color.Silver;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(801, 93);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(772, 241);
            this.listView1.TabIndex = 40;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Names
            // 
            this.Names.Text = "Player Names";
            this.Names.Width = 150;
            // 
            // two
            // 
            this.two.Text = "Round K/D/R/M";
            this.two.Width = 150;
            // 
            // one
            // 
            this.one.Text = "Total K/D/R/M";
            this.one.Width = 150;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Warnings";
            this.columnHeader1.Width = 80;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1658, 1055);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.MadeRetreatMinus);
            this.Controls.Add(this.MadeRetreatPlus);
            this.Controls.Add(this.DeathButtonMinus);
            this.Controls.Add(this.DeathButtonPlus);
            this.Controls.Add(this.RetreatButtonMinus);
            this.Controls.Add(this.RetreatButtonPlus);
            this.Controls.Add(this.KillButtonMinus);
            this.Controls.Add(this.KillButtonPlus);
            this.Controls.Add(this.MadeRetreatLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DeathsLabelCount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.RetreatsLabelCount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.KillsLabelCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PlayerName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox6);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label PlayerName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label KillsLabelCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label RetreatsLabelCount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label DeathsLabelCount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label MadeRetreatLabel;
        private System.Windows.Forms.Button KillButtonPlus;
        private System.Windows.Forms.Button KillButtonMinus;
        private System.Windows.Forms.Button RetreatButtonPlus;
        private System.Windows.Forms.Button RetreatButtonMinus;
        private System.Windows.Forms.Button DeathButtonPlus;
        private System.Windows.Forms.Button DeathButtonMinus;
        private System.Windows.Forms.Button MadeRetreatPlus;
        private System.Windows.Forms.Button MadeRetreatMinus;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Names;
        private System.Windows.Forms.ColumnHeader two;
        private System.Windows.Forms.ColumnHeader one;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}

