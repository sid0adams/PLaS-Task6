namespace ReflectionApp
{
    partial class GetInt
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
            this.NameInput = new System.Windows.Forms.Label();
            this.inp = new System.Windows.Forms.NumericUpDown();
            this.OkBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inp)).BeginInit();
            this.SuspendLayout();
            // 
            // NameInput
            // 
            this.NameInput.AutoSize = true;
            this.NameInput.Location = new System.Drawing.Point(12, 15);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(18, 13);
            this.NameInput.TabIndex = 0;
            this.NameInput.Text = "int";
            // 
            // inp
            // 
            this.inp.Location = new System.Drawing.Point(89, 13);
            this.inp.Name = "inp";
            this.inp.Size = new System.Drawing.Size(120, 20);
            this.inp.TabIndex = 1;
            // 
            // OkBtn
            // 
            this.OkBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkBtn.Location = new System.Drawing.Point(215, 10);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 23);
            this.OkBtn.TabIndex = 2;
            this.OkBtn.Text = "ok";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // GetInt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 53);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.inp);
            this.Controls.Add(this.NameInput);
            this.Name = "GetInt";
            this.Text = "GetInt";
            this.Load += new System.EventHandler(this.GetInt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameInput;
        private System.Windows.Forms.NumericUpDown inp;
        private System.Windows.Forms.Button OkBtn;
    }
}