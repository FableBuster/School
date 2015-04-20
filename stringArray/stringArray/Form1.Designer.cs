namespace stringArray
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
            this.listBoxArrays = new System.Windows.Forms.ListBox();
            this.btnAddWhile = new System.Windows.Forms.Button();
            this.btnForLoop = new System.Windows.Forms.Button();
            this.btnCleanListBox = new System.Windows.Forms.Button();
            this.btnSintPiet = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxArrays
            // 
            this.listBoxArrays.FormattingEnabled = true;
            this.listBoxArrays.ItemHeight = 16;
            this.listBoxArrays.Location = new System.Drawing.Point(13, 13);
            this.listBoxArrays.Name = "listBoxArrays";
            this.listBoxArrays.Size = new System.Drawing.Size(254, 628);
            this.listBoxArrays.TabIndex = 0;
            // 
            // btnAddWhile
            // 
            this.btnAddWhile.Location = new System.Drawing.Point(288, 13);
            this.btnAddWhile.Name = "btnAddWhile";
            this.btnAddWhile.Size = new System.Drawing.Size(183, 33);
            this.btnAddWhile.TabIndex = 1;
            this.btnAddWhile.Text = "Add While Loop";
            this.btnAddWhile.UseVisualStyleBackColor = true;
            this.btnAddWhile.Click += new System.EventHandler(this.btnAddWhile_Click);
            // 
            // btnForLoop
            // 
            this.btnForLoop.Location = new System.Drawing.Point(288, 52);
            this.btnForLoop.Name = "btnForLoop";
            this.btnForLoop.Size = new System.Drawing.Size(183, 33);
            this.btnForLoop.TabIndex = 2;
            this.btnForLoop.Text = "Add For Loop";
            this.btnForLoop.UseVisualStyleBackColor = true;
            this.btnForLoop.Click += new System.EventHandler(this.btnForLoop_Click);
            // 
            // btnCleanListBox
            // 
            this.btnCleanListBox.Location = new System.Drawing.Point(288, 211);
            this.btnCleanListBox.Name = "btnCleanListBox";
            this.btnCleanListBox.Size = new System.Drawing.Size(183, 34);
            this.btnCleanListBox.TabIndex = 3;
            this.btnCleanListBox.Text = "Clean ListBox";
            this.btnCleanListBox.UseVisualStyleBackColor = true;
            this.btnCleanListBox.Click += new System.EventHandler(this.btnCleanListBox_Click);
            // 
            // btnSintPiet
            // 
            this.btnSintPiet.Location = new System.Drawing.Point(288, 91);
            this.btnSintPiet.Name = "btnSintPiet";
            this.btnSintPiet.Size = new System.Drawing.Size(183, 34);
            this.btnSintPiet.TabIndex = 4;
            this.btnSintPiet.Text = "Add SintPiet Array[10]";
            this.btnSintPiet.UseVisualStyleBackColor = true;
            this.btnSintPiet.Click += new System.EventHandler(this.btnSintPiet_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(288, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add SintPiet Array[30]";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddAll
            // 
            this.btnAddAll.Location = new System.Drawing.Point(288, 171);
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.Size = new System.Drawing.Size(183, 34);
            this.btnAddAll.TabIndex = 6;
            this.btnAddAll.Text = "Add All Arrays";
            this.btnAddAll.UseVisualStyleBackColor = true;
            this.btnAddAll.Click += new System.EventHandler(this.btnAddAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 654);
            this.Controls.Add(this.btnAddAll);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSintPiet);
            this.Controls.Add(this.btnCleanListBox);
            this.Controls.Add(this.btnForLoop);
            this.Controls.Add(this.btnAddWhile);
            this.Controls.Add(this.listBoxArrays);
            this.Name = "Form1";
            this.Text = "SE12 - Opdracht Arrays ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxArrays;
        private System.Windows.Forms.Button btnAddWhile;
        private System.Windows.Forms.Button btnForLoop;
        private System.Windows.Forms.Button btnCleanListBox;
        private System.Windows.Forms.Button btnSintPiet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAddAll;
    }
}

