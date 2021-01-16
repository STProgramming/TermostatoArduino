using System.IO.Ports;

namespace Domus
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.StatusText = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearcherResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(402, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(435, 104);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // StatusText
            // 
            this.StatusText.AutoSize = true;
            this.StatusText.Font = new System.Drawing.Font("Quicksand Book", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusText.Location = new System.Drawing.Point(197, 320);
            this.StatusText.Name = "StatusText";
            this.StatusText.Size = new System.Drawing.Size(845, 42);
            this.StatusText.TabIndex = 1;
            this.StatusText.Text = "Here output the status of researching sensor";
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SearchButton.Location = new System.Drawing.Point(444, 467);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(348, 60);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "searching for sensor";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearcherResult
            // 
            this.SearcherResult.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearcherResult.AutoSize = true;
            this.SearcherResult.Font = new System.Drawing.Font("Quicksand Book", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearcherResult.Location = new System.Drawing.Point(462, 384);
            this.SearcherResult.Name = "SearcherResult";
            this.SearcherResult.Size = new System.Drawing.Size(313, 24);
            this.SearcherResult.TabIndex = 3;
            this.SearcherResult.Text = "here the result/searching/for";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1220, 704);
            this.Controls.Add(this.SearcherResult);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.StatusText);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Quicksand Book", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label StatusText;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label SearcherResult;
    }
}

