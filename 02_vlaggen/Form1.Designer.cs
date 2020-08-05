namespace _02_vlaggen
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
            this.imageBox = new System.Windows.Forms.WebBrowser();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.btn_guess = new System.Windows.Forms.Button();
            this.resizeSvg = new System.Windows.Forms.Button();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.btn_Start = new System.Windows.Forms.Button();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // imageBox
            // 
            this.imageBox.AllowWebBrowserDrop = false;
            this.imageBox.IsWebBrowserContextMenuEnabled = false;
            this.imageBox.Location = new System.Drawing.Point(12, 12);
            this.imageBox.MinimumSize = new System.Drawing.Size(20, 20);
            this.imageBox.Name = "imageBox";
            this.imageBox.ScrollBarsEnabled = false;
            this.imageBox.Size = new System.Drawing.Size(507, 263);
            this.imageBox.TabIndex = 0;
            this.imageBox.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // btn_prev
            // 
            this.btn_prev.BackColor = System.Drawing.Color.Indigo;
            this.btn_prev.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_prev.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prev.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_prev.Location = new System.Drawing.Point(12, 281);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(75, 67);
            this.btn_prev.TabIndex = 1;
            this.btn_prev.Text = "prev";
            this.btn_prev.UseVisualStyleBackColor = false;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.Indigo;
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_next.Location = new System.Drawing.Point(444, 281);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 67);
            this.btn_next.TabIndex = 2;
            this.btn_next.Text = "next";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(93, 281);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(345, 31);
            this.textBox.TabIndex = 3;
            this.textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // btn_guess
            // 
            this.btn_guess.BackColor = System.Drawing.Color.Indigo;
            this.btn_guess.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_guess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guess.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_guess.Location = new System.Drawing.Point(93, 318);
            this.btn_guess.Name = "btn_guess";
            this.btn_guess.Size = new System.Drawing.Size(345, 30);
            this.btn_guess.TabIndex = 4;
            this.btn_guess.Text = "guess";
            this.btn_guess.UseVisualStyleBackColor = false;
            this.btn_guess.Click += new System.EventHandler(this.btn_guess_Click);
            // 
            // resizeSvg
            // 
            this.resizeSvg.BackColor = System.Drawing.Color.Indigo;
            this.resizeSvg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resizeSvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resizeSvg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resizeSvg.Location = new System.Drawing.Point(526, 281);
            this.resizeSvg.Name = "resizeSvg";
            this.resizeSvg.Size = new System.Drawing.Size(132, 67);
            this.resizeSvg.TabIndex = 5;
            this.resizeSvg.Text = "Resize SVG";
            this.resizeSvg.UseVisualStyleBackColor = false;
            this.resizeSvg.Click += new System.EventHandler(this.resizeSvg_Click);
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Total.Location = new System.Drawing.Point(523, 12);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(103, 16);
            this.lbl_Total.TabIndex = 6;
            this.lbl_Total.Text = "Total Images:";
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.Color.Indigo;
            this.btn_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Start.Location = new System.Drawing.Point(12, 12);
            this.btn_Start.Margin = new System.Windows.Forms.Padding(1);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(507, 263);
            this.btn_Start.TabIndex = 7;
            this.btn_Start.Text = "&START";
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Status.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Status.Location = new System.Drawing.Point(523, 121);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(19, 16);
            this.lbl_Status.TabIndex = 8;
            this.lbl_Status.Text = "H";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(523, 216);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(53, 16);
            this.lblScore.TabIndex = 10;
            this.lblScore.Text = "Score:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(744, 357);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.resizeSvg);
            this.Controls.Add(this.btn_guess);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_prev);
            this.Controls.Add(this.imageBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "PictureTrainer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser imageBox;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button btn_guess;
        private System.Windows.Forms.Button resizeSvg;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Label lblScore;
    }
}

