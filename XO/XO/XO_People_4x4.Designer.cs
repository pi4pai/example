namespace XO
{
    partial class XO_People_4x4
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
            menuStrip1 = new MenuStrip();
            Menu = new ToolStripMenuItem();
            size_game = new ToolStripMenuItem();
            size_3x3 = new ToolStripMenuItem();
            size_4x4 = new ToolStripMenuItem();
            change_color = new ToolStripMenuItem();
            background_color = new ToolStripMenuItem();
            Text_style = new ToolStripMenuItem();
            exit = new ToolStripMenuItem();
            title_name = new Label();
            panel2 = new Panel();
            label7 = new Label();
            lblPlayerO = new Label();
            label8 = new Label();
            lblPlayerX = new Label();
            label6 = new Label();
            label5 = new Label();
            pl2 = new Label();
            pl1 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            newgame = new Button();
            reset = new Button();
            panel4 = new Panel();
            AIgame_4x4 = new Button();
            button10 = new Button();
            label9 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { Menu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1368, 33);
            menuStrip1.TabIndex = 13;
            menuStrip1.Text = "menuStrip1";
            // 
            // Menu
            // 
            Menu.DropDownItems.AddRange(new ToolStripItem[] { size_game, change_color, exit });
            Menu.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Menu.Name = "Menu";
            Menu.Size = new Size(91, 29);
            Menu.Text = "Меню";
            // 
            // size_game
            // 
            size_game.DropDownItems.AddRange(new ToolStripItem[] { size_3x3, size_4x4 });
            size_game.Name = "size_game";
            size_game.Size = new Size(317, 30);
            size_game.Text = "Розмірність поля гри";
            // 
            // size_3x3
            // 
            size_3x3.Name = "size_3x3";
            size_3x3.Size = new Size(133, 30);
            size_3x3.Text = "3х3";
            size_3x3.Click += size_3x3_Click;
            // 
            // size_4x4
            // 
            size_4x4.Name = "size_4x4";
            size_4x4.Size = new Size(133, 30);
            size_4x4.Text = "4х4";
            // 
            // change_color
            // 
            change_color.DropDownItems.AddRange(new ToolStripItem[] { background_color, Text_style });
            change_color.Name = "change_color";
            change_color.Size = new Size(317, 30);
            change_color.Text = "Зміна інтерфейсу";
            // 
            // background_color
            // 
            background_color.Name = "background_color";
            background_color.Size = new Size(157, 30);
            background_color.Text = "Фон";
            background_color.Click += background_color_Click;
            // 
            // Text_style
            // 
            Text_style.Name = "Text_style";
            Text_style.Size = new Size(157, 30);
            Text_style.Text = "Текст";
            Text_style.Click += Text_style_Click;
            // 
            // exit
            // 
            exit.Name = "exit";
            exit.Size = new Size(317, 30);
            exit.Text = "Вийти з гри";
            exit.Click += exit_Click;
            // 
            // title_name
            // 
            title_name.AutoSize = true;
            title_name.Font = new Font("Times New Roman", 45F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            title_name.ForeColor = Color.WhiteSmoke;
            title_name.Location = new Point(0, 33);
            title_name.Name = "title_name";
            title_name.Size = new Size(820, 84);
            title_name.TabIndex = 14;
            title_name.Text = "Гра Хрестики - Нулики";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(lblPlayerO);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(lblPlayerX);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(pl2);
            panel2.Controls.Add(pl1);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(842, 62);
            panel2.Name = "panel2";
            panel2.Size = new Size(479, 381);
            panel2.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.WhiteSmoke;
            label7.Location = new Point(92, 304);
            label7.Name = "label7";
            label7.Size = new Size(281, 47);
            label7.TabIndex = 47;
            label7.Text = "Хід гравця: Х ";
            // 
            // lblPlayerO
            // 
            lblPlayerO.BackColor = Color.White;
            lblPlayerO.BorderStyle = BorderStyle.Fixed3D;
            lblPlayerO.FlatStyle = FlatStyle.Flat;
            lblPlayerO.Font = new Font("Times New Roman", 48F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlayerO.ForeColor = Color.Black;
            lblPlayerO.Location = new Point(332, 189);
            lblPlayerO.Name = "lblPlayerO";
            lblPlayerO.Size = new Size(74, 91);
            lblPlayerO.TabIndex = 31;
            lblPlayerO.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.FlatStyle = FlatStyle.Flat;
            label8.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.WhiteSmoke;
            label8.Location = new Point(213, 166);
            label8.Name = "label8";
            label8.Size = new Size(0, 45);
            label8.TabIndex = 30;
            // 
            // lblPlayerX
            // 
            lblPlayerX.BackColor = Color.White;
            lblPlayerX.BorderStyle = BorderStyle.Fixed3D;
            lblPlayerX.FlatStyle = FlatStyle.Flat;
            lblPlayerX.Font = new Font("Times New Roman", 48F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlayerX.ForeColor = Color.Black;
            lblPlayerX.Location = new Point(66, 189);
            lblPlayerX.Name = "lblPlayerX";
            lblPlayerX.Size = new Size(74, 91);
            lblPlayerX.TabIndex = 29;
            lblPlayerX.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(341, 125);
            label6.Name = "label6";
            label6.Size = new Size(51, 45);
            label6.TabIndex = 28;
            label6.Text = "О";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(77, 125);
            label5.Name = "label5";
            label5.Size = new Size(49, 45);
            label5.TabIndex = 27;
            label5.Text = "Х";
            // 
            // pl2
            // 
            pl2.AutoSize = true;
            pl2.FlatStyle = FlatStyle.Flat;
            pl2.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            pl2.ForeColor = Color.WhiteSmoke;
            pl2.Location = new Point(281, 60);
            pl2.Name = "pl2";
            pl2.Size = new Size(168, 45);
            pl2.TabIndex = 26;
            pl2.Text = "Гравець";
            // 
            // pl1
            // 
            pl1.AutoSize = true;
            pl1.FlatStyle = FlatStyle.Flat;
            pl1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            pl1.ForeColor = Color.WhiteSmoke;
            pl1.Location = new Point(14, 60);
            pl1.Name = "pl1";
            pl1.Size = new Size(168, 45);
            pl1.TabIndex = 25;
            pl1.Text = "Гравець";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(125, 0);
            label2.Name = "label2";
            label2.Size = new Size(214, 53);
            label2.TabIndex = 24;
            label2.Text = "Рахунок:";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(newgame);
            panel3.Controls.Add(reset);
            panel3.Location = new Point(841, 449);
            panel3.Name = "panel3";
            panel3.Size = new Size(480, 87);
            panel3.TabIndex = 28;
            // 
            // newgame
            // 
            newgame.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            newgame.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            newgame.ForeColor = Color.Black;
            newgame.Location = new Point(241, 3);
            newgame.Name = "newgame";
            newgame.Size = new Size(232, 75);
            newgame.TabIndex = 24;
            newgame.Text = "Нова гра";
            newgame.UseVisualStyleBackColor = true;
            newgame.Click += newgame_Click;
            // 
            // reset
            // 
            reset.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            reset.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            reset.ForeColor = Color.Black;
            reset.Location = new Point(3, 3);
            reset.Name = "reset";
            reset.Size = new Size(232, 75);
            reset.TabIndex = 23;
            reset.Text = "Скинути";
            reset.UseVisualStyleBackColor = true;
            reset.Click += reset_Click;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(AIgame_4x4);
            panel4.Controls.Add(button10);
            panel4.Controls.Add(label9);
            panel4.Location = new Point(841, 542);
            panel4.Name = "panel4";
            panel4.Size = new Size(479, 162);
            panel4.TabIndex = 29;
            // 
            // AIgame_4x4
            // 
            AIgame_4x4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AIgame_4x4.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            AIgame_4x4.ForeColor = Color.Black;
            AIgame_4x4.Location = new Point(241, 80);
            AIgame_4x4.Name = "AIgame_4x4";
            AIgame_4x4.Size = new Size(232, 75);
            AIgame_4x4.TabIndex = 34;
            AIgame_4x4.Text = "Комп'ютер";
            AIgame_4x4.UseVisualStyleBackColor = true;
            AIgame_4x4.Click += AIgame_4x4_Click;
            // 
            // button10
            // 
            button10.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button10.BackColor = Color.White;
            button10.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            button10.ForeColor = Color.Gray;
            button10.Location = new Point(3, 80);
            button10.Name = "button10";
            button10.Size = new Size(232, 75);
            button10.TabIndex = 25;
            button10.Text = "Людина";
            button10.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.FlatStyle = FlatStyle.Flat;
            label9.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.WhiteSmoke;
            label9.Location = new Point(24, 0);
            label9.Name = "label9";
            label9.Size = new Size(439, 53);
            label9.TabIndex = 33;
            label9.Text = "Оберіть суперника:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(7, 6);
            button1.Name = "button1";
            button1.Size = new Size(155, 145);
            button1.TabIndex = 30;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(168, 6);
            button2.Name = "button2";
            button2.Size = new Size(155, 145);
            button2.TabIndex = 31;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(329, 6);
            button3.Name = "button3";
            button3.Size = new Size(155, 145);
            button3.TabIndex = 32;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(490, 6);
            button4.Name = "button4";
            button4.Size = new Size(155, 145);
            button4.TabIndex = 33;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(7, 157);
            button5.Name = "button5";
            button5.Size = new Size(155, 145);
            button5.TabIndex = 34;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(168, 157);
            button6.Name = "button6";
            button6.Size = new Size(155, 145);
            button6.TabIndex = 35;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(329, 157);
            button7.Name = "button7";
            button7.Size = new Size(155, 145);
            button7.TabIndex = 36;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(490, 157);
            button8.Name = "button8";
            button8.Size = new Size(155, 145);
            button8.TabIndex = 37;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            button9.Location = new Point(7, 308);
            button9.Name = "button9";
            button9.Size = new Size(155, 145);
            button9.TabIndex = 38;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button11
            // 
            button11.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            button11.Location = new Point(168, 308);
            button11.Name = "button11";
            button11.Size = new Size(155, 145);
            button11.TabIndex = 39;
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            button12.Location = new Point(329, 308);
            button12.Name = "button12";
            button12.Size = new Size(155, 145);
            button12.TabIndex = 40;
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            button13.Location = new Point(490, 308);
            button13.Name = "button13";
            button13.Size = new Size(155, 145);
            button13.TabIndex = 41;
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // button14
            // 
            button14.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            button14.Location = new Point(7, 459);
            button14.Name = "button14";
            button14.Size = new Size(155, 145);
            button14.TabIndex = 42;
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // button15
            // 
            button15.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            button15.Location = new Point(168, 459);
            button15.Name = "button15";
            button15.Size = new Size(155, 145);
            button15.TabIndex = 43;
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // button16
            // 
            button16.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            button16.Location = new Point(329, 459);
            button16.Name = "button16";
            button16.Size = new Size(155, 145);
            button16.TabIndex = 44;
            button16.UseVisualStyleBackColor = true;
            button16.Click += button16_Click;
            // 
            // button17
            // 
            button17.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            button17.Location = new Point(490, 459);
            button17.Name = "button17";
            button17.Size = new Size(155, 145);
            button17.TabIndex = 45;
            button17.UseVisualStyleBackColor = true;
            button17.Click += button17_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(button17);
            panel1.Controls.Add(button16);
            panel1.Controls.Add(button15);
            panel1.Controls.Add(button14);
            panel1.Controls.Add(button13);
            panel1.Controls.Add(button12);
            panel1.Controls.Add(button11);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(53, 120);
            panel1.Name = "panel1";
            panel1.Size = new Size(655, 614);
            panel1.TabIndex = 46;
            // 
            // XO_People_4x4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1368, 741);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(title_name);
            Controls.Add(menuStrip1);
            Name = "XO_People_4x4";
            Text = "XO_People_4x4";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem Menu;
        private ToolStripMenuItem size_game;
        private ToolStripMenuItem size_3x3;
        private ToolStripMenuItem size_4x4;
        private ToolStripMenuItem change_color;
        private ToolStripMenuItem background_color;
        private ToolStripMenuItem Text_style;
        private ToolStripMenuItem exit;
        private Label title_name;
        private Panel panel2;
        private Label lblPlayerO;
        private Label label8;
        private Label lblPlayerX;
        private Label label6;
        private Label label5;
        private Label pl2;
        private Label pl1;
        private Label label2;
        private Panel panel3;
        private Button newgame;
        private Button reset;
        private Panel panel4;
        private Button AIgame_4x4;
        private Button button10;
        private Label label9;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Panel panel1;
        private Label label7;
    }
}