namespace XO
{
    partial class XO_AI_3x3
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
            panel1 = new Panel();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
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
            AIgame_3x3 = new Button();
            button10 = new Button();
            label9 = new Label();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
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
            size_3x3.Size = new Size(224, 30);
            size_3x3.Text = "3х3";
            // 
            // size_4x4
            // 
            size_4x4.Name = "size_4x4";
            size_4x4.Size = new Size(224, 30);
            size_4x4.Text = "4х4";
            size_4x4.Click += size_4x4_Click;
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
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(69, 120);
            panel1.Name = "panel1";
            panel1.Size = new Size(671, 595);
            panel1.TabIndex = 24;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 96F, FontStyle.Regular, GraphicsUnit.Point);
            button9.Location = new Point(447, 396);
            button9.Name = "button9";
            button9.Size = new Size(216, 190);
            button9.TabIndex = 22;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 96F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(225, 396);
            button8.Name = "button8";
            button8.Size = new Size(216, 190);
            button8.TabIndex = 21;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 96F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(3, 396);
            button7.Name = "button7";
            button7.Size = new Size(216, 190);
            button7.TabIndex = 20;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 96F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(447, 200);
            button6.Name = "button6";
            button6.Size = new Size(216, 190);
            button6.TabIndex = 19;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 96F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(225, 200);
            button5.Name = "button5";
            button5.Size = new Size(216, 190);
            button5.TabIndex = 18;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 96F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(3, 200);
            button4.Name = "button4";
            button4.Size = new Size(216, 190);
            button4.TabIndex = 17;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 96F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(447, 4);
            button3.Name = "button3";
            button3.Size = new Size(216, 190);
            button3.TabIndex = 16;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 96F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(225, 3);
            button2.Name = "button2";
            button2.Size = new Size(216, 190);
            button2.TabIndex = 15;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 96F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(3, 4);
            button1.Name = "button1";
            button1.Size = new Size(216, 190);
            button1.TabIndex = 14;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(lblPlayerO);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(lblPlayerX);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(pl2);
            panel2.Controls.Add(pl1);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(824, 73);
            panel2.Name = "panel2";
            panel2.Size = new Size(479, 381);
            panel2.TabIndex = 26;
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
            panel3.Location = new Point(824, 460);
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
            panel4.Controls.Add(AIgame_3x3);
            panel4.Controls.Add(button10);
            panel4.Controls.Add(label9);
            panel4.Location = new Point(825, 553);
            panel4.Name = "panel4";
            panel4.Size = new Size(479, 162);
            panel4.TabIndex = 29;
            // 
            // AIgame_3x3
            // 
            AIgame_3x3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AIgame_3x3.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            AIgame_3x3.ForeColor = Color.Gray;
            AIgame_3x3.Location = new Point(241, 80);
            AIgame_3x3.Name = "AIgame_3x3";
            AIgame_3x3.Size = new Size(232, 75);
            AIgame_3x3.TabIndex = 34;
            AIgame_3x3.Text = "Комп'ютер";
            AIgame_3x3.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button10.BackColor = Color.White;
            button10.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            button10.ForeColor = Color.Black;
            button10.Location = new Point(3, 80);
            button10.Name = "button10";
            button10.Size = new Size(232, 75);
            button10.TabIndex = 25;
            button10.Text = "Людина";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
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
            // XO_AI_3x3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1368, 741);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(title_name);
            Controls.Add(menuStrip1);
            Name = "XO_AI_3x3";
            Text = "XO_AI_3x3";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
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
        private Panel panel1;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
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
        private Button AIgame_3x3;
        private Button button10;
        private Label label9;
    }
}