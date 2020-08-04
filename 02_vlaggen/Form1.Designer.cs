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
            this.btn_prev.Location = new System.Drawing.Point(12, 281);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(75, 67);
            this.btn_prev.TabIndex = 1;
            this.btn_prev.Text = "btn_prev";
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(444, 281);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 67);
            this.btn_next.TabIndex = 2;
            this.btn_next.Text = "btn_next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(93, 281);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(345, 31);
            this.textBox.TabIndex = 3;
            // 
            // btn_guess
            // 
            this.btn_guess.Location = new System.Drawing.Point(93, 318);
            this.btn_guess.Name = "btn_guess";
            this.btn_guess.Size = new System.Drawing.Size(345, 30);
            this.btn_guess.TabIndex = 4;
            this.btn_guess.Text = "btn_guess";
            this.btn_guess.UseVisualStyleBackColor = true;
            this.btn_guess.Click += new System.EventHandler(this.btn_guess_Click);
            // 
            // resizeSvg
            // 
            this.resizeSvg.Location = new System.Drawing.Point(546, 222);
            this.resizeSvg.Name = "resizeSvg";
            this.resizeSvg.Size = new System.Drawing.Size(114, 61);
            this.resizeSvg.TabIndex = 5;
            this.resizeSvg.Text = "Resize SVG";
            this.resizeSvg.UseVisualStyleBackColor = true;
            this.resizeSvg.Click += new System.EventHandler(this.resizeSvg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(672, 357);
            this.Controls.Add(this.resizeSvg);
            this.Controls.Add(this.btn_guess);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_prev);
            this.Controls.Add(this.imageBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

