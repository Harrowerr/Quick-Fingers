
namespace quick_fingers_game
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textbox_expression = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textbox_guess = new System.Windows.Forms.TextBox();
            this.button_confirm_guess = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_7 = new System.Windows.Forms.Button();
            this.button_dot = new System.Windows.Forms.Button();
            this.button_0 = new System.Windows.Forms.Button();
            this.button_backspace = new System.Windows.Forms.Button();
            this.button_start_new_game = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_incorrect_guesses = new System.Windows.Forms.Label();
            this.label_correct_guesses = new System.Windows.Forms.Label();
            this.label_remaining_time = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Solve the following expression";
            // 
            // textbox_expression
            // 
            this.textbox_expression.Enabled = false;
            this.textbox_expression.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textbox_expression.Location = new System.Drawing.Point(40, 50);
            this.textbox_expression.Name = "textbox_expression";
            this.textbox_expression.ReadOnly = true;
            this.textbox_expression.Size = new System.Drawing.Size(270, 26);
            this.textbox_expression.TabIndex = 1;
            this.textbox_expression.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(25, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Solution";
            // 
            // textbox_guess
            // 
            this.textbox_guess.Enabled = false;
            this.textbox_guess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textbox_guess.Location = new System.Drawing.Point(40, 130);
            this.textbox_guess.Name = "textbox_guess";
            this.textbox_guess.ReadOnly = true;
            this.textbox_guess.Size = new System.Drawing.Size(189, 26);
            this.textbox_guess.TabIndex = 3;
            this.textbox_guess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_confirm_guess
            // 
            this.button_confirm_guess.Enabled = false;
            this.button_confirm_guess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_confirm_guess.Location = new System.Drawing.Point(235, 131);
            this.button_confirm_guess.Name = "button_confirm_guess";
            this.button_confirm_guess.Size = new System.Drawing.Size(75, 26);
            this.button_confirm_guess.TabIndex = 4;
            this.button_confirm_guess.Text = "Confirm";
            this.button_confirm_guess.UseVisualStyleBackColor = true;
            this.button_confirm_guess.Click += new System.EventHandler(this.button_confirm_guess_Click);
            // 
            // button_1
            // 
            this.button_1.Enabled = false;
            this.button_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_1.Location = new System.Drawing.Point(40, 185);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(66, 25);
            this.button_1.TabIndex = 5;
            this.button_1.Text = "1";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new System.EventHandler(this.button_1_Click);
            // 
            // button_2
            // 
            this.button_2.Enabled = false;
            this.button_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_2.Location = new System.Drawing.Point(140, 185);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(66, 25);
            this.button_2.TabIndex = 6;
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = true;
            this.button_2.Click += new System.EventHandler(this.button_2_Click);
            // 
            // button_3
            // 
            this.button_3.Enabled = false;
            this.button_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_3.Location = new System.Drawing.Point(240, 185);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(66, 25);
            this.button_3.TabIndex = 7;
            this.button_3.Text = "3";
            this.button_3.UseVisualStyleBackColor = true;
            this.button_3.Click += new System.EventHandler(this.button_3_Click);
            // 
            // button_6
            // 
            this.button_6.Enabled = false;
            this.button_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_6.Location = new System.Drawing.Point(240, 225);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(66, 25);
            this.button_6.TabIndex = 10;
            this.button_6.Text = "6";
            this.button_6.UseVisualStyleBackColor = true;
            this.button_6.Click += new System.EventHandler(this.button_6_Click);
            // 
            // button_5
            // 
            this.button_5.Enabled = false;
            this.button_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_5.Location = new System.Drawing.Point(140, 225);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(66, 25);
            this.button_5.TabIndex = 9;
            this.button_5.Text = "5";
            this.button_5.UseVisualStyleBackColor = true;
            this.button_5.Click += new System.EventHandler(this.button_5_Click);
            // 
            // button_4
            // 
            this.button_4.Enabled = false;
            this.button_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_4.Location = new System.Drawing.Point(40, 225);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(66, 25);
            this.button_4.TabIndex = 8;
            this.button_4.Text = "4";
            this.button_4.UseVisualStyleBackColor = true;
            this.button_4.Click += new System.EventHandler(this.button_4_Click);
            // 
            // button_9
            // 
            this.button_9.Enabled = false;
            this.button_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_9.Location = new System.Drawing.Point(240, 265);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(66, 25);
            this.button_9.TabIndex = 13;
            this.button_9.Text = "9";
            this.button_9.UseVisualStyleBackColor = true;
            this.button_9.Click += new System.EventHandler(this.button_9_Click);
            // 
            // button_8
            // 
            this.button_8.Enabled = false;
            this.button_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_8.Location = new System.Drawing.Point(140, 265);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(66, 25);
            this.button_8.TabIndex = 12;
            this.button_8.Text = "8";
            this.button_8.UseVisualStyleBackColor = true;
            this.button_8.Click += new System.EventHandler(this.button_8_Click);
            // 
            // button_7
            // 
            this.button_7.Enabled = false;
            this.button_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_7.Location = new System.Drawing.Point(40, 265);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(66, 25);
            this.button_7.TabIndex = 11;
            this.button_7.Text = "7";
            this.button_7.UseVisualStyleBackColor = true;
            this.button_7.Click += new System.EventHandler(this.button_7_Click);
            // 
            // button_dot
            // 
            this.button_dot.Enabled = false;
            this.button_dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_dot.Location = new System.Drawing.Point(240, 305);
            this.button_dot.Name = "button_dot";
            this.button_dot.Size = new System.Drawing.Size(66, 25);
            this.button_dot.TabIndex = 16;
            this.button_dot.Text = ".";
            this.button_dot.UseVisualStyleBackColor = true;
            this.button_dot.Click += new System.EventHandler(this.button_dot_Click);
            // 
            // button_0
            // 
            this.button_0.Enabled = false;
            this.button_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_0.Location = new System.Drawing.Point(140, 305);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(66, 25);
            this.button_0.TabIndex = 15;
            this.button_0.Text = "0";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new System.EventHandler(this.button_0_Click);
            // 
            // button_backspace
            // 
            this.button_backspace.Enabled = false;
            this.button_backspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_backspace.Location = new System.Drawing.Point(40, 305);
            this.button_backspace.Name = "button_backspace";
            this.button_backspace.Size = new System.Drawing.Size(66, 25);
            this.button_backspace.TabIndex = 14;
            this.button_backspace.Text = "←";
            this.button_backspace.UseVisualStyleBackColor = true;
            this.button_backspace.Click += new System.EventHandler(this.button_backspace_Click);
            // 
            // button_start_new_game
            // 
            this.button_start_new_game.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_start_new_game.Location = new System.Drawing.Point(363, 50);
            this.button_start_new_game.Name = "button_start_new_game";
            this.button_start_new_game.Size = new System.Drawing.Size(206, 26);
            this.button_start_new_game.TabIndex = 2;
            this.button_start_new_game.Text = "Start a new game";
            this.button_start_new_game.UseVisualStyleBackColor = true;
            this.button_start_new_game.Click += new System.EventHandler(this.button_start_new_game_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_incorrect_guesses);
            this.groupBox1.Controls.Add(this.label_correct_guesses);
            this.groupBox1.Controls.Add(this.label_remaining_time);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(363, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 200);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Result";
            // 
            // label_incorrect_guesses
            // 
            this.label_incorrect_guesses.AutoSize = true;
            this.label_incorrect_guesses.Location = new System.Drawing.Point(145, 139);
            this.label_incorrect_guesses.Name = "label_incorrect_guesses";
            this.label_incorrect_guesses.Size = new System.Drawing.Size(16, 17);
            this.label_incorrect_guesses.TabIndex = 5;
            this.label_incorrect_guesses.Text = "0";
            // 
            // label_correct_guesses
            // 
            this.label_correct_guesses.AutoSize = true;
            this.label_correct_guesses.Location = new System.Drawing.Point(145, 99);
            this.label_correct_guesses.Name = "label_correct_guesses";
            this.label_correct_guesses.Size = new System.Drawing.Size(16, 17);
            this.label_correct_guesses.TabIndex = 4;
            this.label_correct_guesses.Text = "0";
            // 
            // label_remaining_time
            // 
            this.label_remaining_time.AutoSize = true;
            this.label_remaining_time.Location = new System.Drawing.Point(145, 59);
            this.label_remaining_time.Name = "label_remaining_time";
            this.label_remaining_time.Size = new System.Drawing.Size(36, 17);
            this.label_remaining_time.TabIndex = 3;
            this.label_remaining_time.Text = "0:00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Incorrect guesses:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Correct guesses:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Remaining time:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 360);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_start_new_game);
            this.Controls.Add(this.button_dot);
            this.Controls.Add(this.button_0);
            this.Controls.Add(this.button_backspace);
            this.Controls.Add(this.button_9);
            this.Controls.Add(this.button_8);
            this.Controls.Add(this.button_7);
            this.Controls.Add(this.button_6);
            this.Controls.Add(this.button_5);
            this.Controls.Add(this.button_4);
            this.Controls.Add(this.button_3);
            this.Controls.Add(this.button_2);
            this.Controls.Add(this.button_1);
            this.Controls.Add(this.button_confirm_guess);
            this.Controls.Add(this.textbox_guess);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textbox_expression);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Quick Fingers";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textbox_expression;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textbox_guess;
        private System.Windows.Forms.Button button_confirm_guess;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Button button_6;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button_4;
        private System.Windows.Forms.Button button_9;
        private System.Windows.Forms.Button button_8;
        private System.Windows.Forms.Button button_7;
        private System.Windows.Forms.Button button_dot;
        private System.Windows.Forms.Button button_0;
        private System.Windows.Forms.Button button_backspace;
        private System.Windows.Forms.Button button_start_new_game;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_incorrect_guesses;
        private System.Windows.Forms.Label label_correct_guesses;
        private System.Windows.Forms.Label label_remaining_time;
        private System.Windows.Forms.Timer timer1;
    }
}

