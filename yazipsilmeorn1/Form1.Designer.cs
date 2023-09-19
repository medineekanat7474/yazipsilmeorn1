namespace yazipsilmeorn1
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
            this.btnyaz = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.txtYazsil = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnyaz
            // 
            this.btnyaz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnyaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnyaz.Location = new System.Drawing.Point(33, 100);
            this.btnyaz.Name = "btnyaz";
            this.btnyaz.Size = new System.Drawing.Size(75, 49);
            this.btnyaz.TabIndex = 0;
            this.btnyaz.Text = "yaz";
            this.btnyaz.UseVisualStyleBackColor = false;
            this.btnyaz.Click += new System.EventHandler(this.btnyaz_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.Location = new System.Drawing.Point(33, 155);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(75, 46);
            this.btnsil.TabIndex = 1;
            this.btnsil.Text = "sil";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // txtYazsil
            // 
            this.txtYazsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYazsil.Location = new System.Drawing.Point(131, 138);
            this.txtYazsil.Name = "txtYazsil";
            this.txtYazsil.Size = new System.Drawing.Size(216, 22);
            this.txtYazsil.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtYazsil);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnyaz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnyaz;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.TextBox txtYazsil;
    }
}

