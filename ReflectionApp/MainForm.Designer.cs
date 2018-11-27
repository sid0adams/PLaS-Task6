namespace ReflectionApp
{
    partial class MainForm
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.OpenBtn = new System.Windows.Forms.Button();
            this.ClassList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PropertiesList = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.InterfacesList = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MethodsList = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ConstructorsList = new System.Windows.Forms.ListBox();
            this.constr = new System.Windows.Forms.Button();
            this.MethodsBtn = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "Dll|*.dll|all |*.*";
            // 
            // OpenBtn
            // 
            this.OpenBtn.Location = new System.Drawing.Point(13, 13);
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(75, 23);
            this.OpenBtn.TabIndex = 0;
            this.OpenBtn.Text = "Open";
            this.OpenBtn.UseVisualStyleBackColor = true;
            this.OpenBtn.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // ClassList
            // 
            this.ClassList.FormattingEnabled = true;
            this.ClassList.Location = new System.Drawing.Point(13, 69);
            this.ClassList.Name = "ClassList";
            this.ClassList.Size = new System.Drawing.Size(120, 329);
            this.ClassList.TabIndex = 1;
            this.ClassList.SelectedIndexChanged += new System.EventHandler(this.ClassList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Class";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Properties";
            // 
            // PropertiesList
            // 
            this.PropertiesList.FormattingEnabled = true;
            this.PropertiesList.Location = new System.Drawing.Point(139, 69);
            this.PropertiesList.Name = "PropertiesList";
            this.PropertiesList.Size = new System.Drawing.Size(338, 134);
            this.PropertiesList.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Interfaces";
            // 
            // InterfacesList
            // 
            this.InterfacesList.FormattingEnabled = true;
            this.InterfacesList.Location = new System.Drawing.Point(139, 260);
            this.InterfacesList.Name = "InterfacesList";
            this.InterfacesList.Size = new System.Drawing.Size(338, 134);
            this.InterfacesList.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(556, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Methods";
            // 
            // MethodsList
            // 
            this.MethodsList.FormattingEnabled = true;
            this.MethodsList.Location = new System.Drawing.Point(556, 260);
            this.MethodsList.Name = "MethodsList";
            this.MethodsList.Size = new System.Drawing.Size(301, 134);
            this.MethodsList.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(556, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Constructors";
            // 
            // ConstructorsList
            // 
            this.ConstructorsList.FormattingEnabled = true;
            this.ConstructorsList.Location = new System.Drawing.Point(556, 69);
            this.ConstructorsList.Name = "ConstructorsList";
            this.ConstructorsList.Size = new System.Drawing.Size(301, 134);
            this.ConstructorsList.TabIndex = 7;
            // 
            // constr
            // 
            this.constr.Location = new System.Drawing.Point(864, 69);
            this.constr.Name = "constr";
            this.constr.Size = new System.Drawing.Size(75, 23);
            this.constr.TabIndex = 11;
            this.constr.Text = "New Object";
            this.constr.UseVisualStyleBackColor = true;
            this.constr.Click += new System.EventHandler(this.constr_Click);
            // 
            // MethodsBtn
            // 
            this.MethodsBtn.Location = new System.Drawing.Point(864, 260);
            this.MethodsBtn.Name = "MethodsBtn";
            this.MethodsBtn.Size = new System.Drawing.Size(75, 23);
            this.MethodsBtn.TabIndex = 12;
            this.MethodsBtn.Text = "Methods run";
            this.MethodsBtn.UseVisualStyleBackColor = true;
            this.MethodsBtn.Click += new System.EventHandler(this.MethodsBtn_Click);
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Location = new System.Drawing.Point(864, 290);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(10, 13);
            this.output.TabIndex = 13;
            this.output.Text = " ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 450);
            this.Controls.Add(this.output);
            this.Controls.Add(this.MethodsBtn);
            this.Controls.Add(this.constr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MethodsList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ConstructorsList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InterfacesList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PropertiesList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClassList);
            this.Controls.Add(this.OpenBtn);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button OpenBtn;
        private System.Windows.Forms.ListBox ClassList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox PropertiesList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox InterfacesList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox MethodsList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox ConstructorsList;
        private System.Windows.Forms.Button constr;
        private System.Windows.Forms.Button MethodsBtn;
        private System.Windows.Forms.Label output;
    }
}

