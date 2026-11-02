namespace Pizza_Project
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnOrderForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOrderForm
            // 
            this.btnOrderForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnOrderForm.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnOrderForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOrderForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderForm.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderForm.Location = new System.Drawing.Point(232, 421);
            this.btnOrderForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrderForm.Name = "btnOrderForm";
            this.btnOrderForm.Size = new System.Drawing.Size(134, 32);
            this.btnOrderForm.TabIndex = 0;
            this.btnOrderForm.Text = "Order Now ! ";
            this.btnOrderForm.UseVisualStyleBackColor = false;
            this.btnOrderForm.Click += new System.EventHandler(this.btnOrderForm_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1251, 591);
            this.Controls.Add(this.btnOrderForm);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMain";
            this.Text = "Pizza Restaurant";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOrderForm;
    }
}

