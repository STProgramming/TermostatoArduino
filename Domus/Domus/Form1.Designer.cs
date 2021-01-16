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
            this.StatusDialogue = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.ManuallyBtn = new System.Windows.Forms.Button();
            this.AllPortsBox = new System.Windows.Forms.ComboBox();
            this.AgreeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StatusDialogue
            // 
            this.StatusDialogue.AutoSize = true;
            this.StatusDialogue.Font = new System.Drawing.Font("Quicksand Book", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusDialogue.Location = new System.Drawing.Point(422, 166);
            this.StatusDialogue.Name = "StatusDialogue";
            this.StatusDialogue.Size = new System.Drawing.Size(378, 42);
            this.StatusDialogue.TabIndex = 0;
            this.StatusDialogue.Text = "Select the port first";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(226, 270);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(770, 31);
            this.progressBar1.TabIndex = 1;
            // 
            // ManuallyBtn
            // 
            this.ManuallyBtn.Location = new System.Drawing.Point(458, 355);
            this.ManuallyBtn.Name = "ManuallyBtn";
            this.ManuallyBtn.Size = new System.Drawing.Size(306, 35);
            this.ManuallyBtn.TabIndex = 3;
            this.ManuallyBtn.Text = "Manually";
            this.ManuallyBtn.UseVisualStyleBackColor = true;
            this.ManuallyBtn.Click += new System.EventHandler(this.ManuallyBtn_Click);
            // 
            // AllPortsBox
            // 
            this.AllPortsBox.FormattingEnabled = true;
            this.AllPortsBox.Location = new System.Drawing.Point(458, 440);
            this.AllPortsBox.Name = "AllPortsBox";
            this.AllPortsBox.Size = new System.Drawing.Size(306, 37);
            this.AllPortsBox.TabIndex = 4;
            this.AllPortsBox.Visible = false;
            this.AllPortsBox.SelectedIndexChanged += new System.EventHandler(this.AllPortsBox_SelectedIndexChanged);
            string[] ports = SerialPort.GetPortNames();
            foreach(string port in ports)
            {
                AllPortsBox.Items.Add(port);
            }
            // 
            // AgreeBtn
            // 
            this.AgreeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AgreeBtn.Location = new System.Drawing.Point(474, 523);
            this.AgreeBtn.Name = "AgreeBtn";
            this.AgreeBtn.Size = new System.Drawing.Size(274, 37);
            this.AgreeBtn.TabIndex = 5;
            this.AgreeBtn.Text = "OK";
            this.AgreeBtn.UseVisualStyleBackColor = true;
            this.AgreeBtn.Visible = false;
            this.AgreeBtn.Click += new System.EventHandler(this.AgreeBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 681);
            this.Controls.Add(this.AgreeBtn);
            this.Controls.Add(this.AllPortsBox);
            this.Controls.Add(this.ManuallyBtn);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.StatusDialogue);
            this.Font = new System.Drawing.Font("Quicksand Book", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StatusDialogue;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button ManuallyBtn;
        private System.Windows.Forms.ComboBox AllPortsBox;
        private System.Windows.Forms.Button AgreeBtn;
    }
}

