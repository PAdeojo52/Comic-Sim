namespace Comic_Sim
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
            this.newGame = new System.Windows.Forms.Button();
            this.loadGame = new System.Windows.Forms.Button();
            this.options = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // newGame
            // 
            this.newGame.Location = new System.Drawing.Point(49, 63);
            this.newGame.Name = "newGame";
            this.newGame.Size = new System.Drawing.Size(75, 67);
            this.newGame.TabIndex = 0;
            this.newGame.Text = "New Game";
            this.newGame.UseVisualStyleBackColor = true;
            this.newGame.Click += new System.EventHandler(this.button1_Click);
            // 
            // loadGame
            // 
            this.loadGame.Location = new System.Drawing.Point(49, 174);
            this.loadGame.Name = "loadGame";
            this.loadGame.Size = new System.Drawing.Size(75, 67);
            this.loadGame.TabIndex = 1;
            this.loadGame.Text = "Load Game";
            this.loadGame.UseVisualStyleBackColor = true;
            this.loadGame.Click += new System.EventHandler(this.loadGame_Click);
            // 
            // options
            // 
            this.options.Location = new System.Drawing.Point(49, 279);
            this.options.Name = "options";
            this.options.Size = new System.Drawing.Size(75, 67);
            this.options.TabIndex = 2;
            this.options.Text = "Options";
            this.options.UseVisualStyleBackColor = true;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(49, 383);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 67);
            this.exit.TabIndex = 3;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(256, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(500, 48);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Comic Sims ";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 636);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.options);
            this.Controls.Add(this.loadGame);
            this.Controls.Add(this.newGame);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newGame;
        private System.Windows.Forms.Button loadGame;
        private System.Windows.Forms.Button options;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TextBox textBox1;
    }
}

