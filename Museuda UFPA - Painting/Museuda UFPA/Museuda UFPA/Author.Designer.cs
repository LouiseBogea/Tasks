namespace UFPA
{
    partial class Author
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
            this.lblAuthor = new System.Windows.Forms.Label();
            this.checkListAuthors = new System.Windows.Forms.CheckedListBox();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.lblAuthorName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.metroRadioButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.SuspendLayout();
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.ForeColor = System.Drawing.Color.White;
            this.lblAuthor.Location = new System.Drawing.Point(16, 71);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(79, 20);
            this.lblAuthor.TabIndex = 85;
            this.lblAuthor.Text = "Author(s)";
            // 
            // checkListAuthors
            // 
            this.checkListAuthors.FormattingEnabled = true;
            this.checkListAuthors.Location = new System.Drawing.Point(100, 71);
            this.checkListAuthors.Margin = new System.Windows.Forms.Padding(4);
            this.checkListAuthors.Name = "checkListAuthors";
            this.checkListAuthors.ScrollAlwaysVisible = true;
            this.checkListAuthors.Size = new System.Drawing.Size(209, 225);
            this.checkListAuthors.TabIndex = 86;
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Location = new System.Drawing.Point(100, 39);
            this.txtAuthorName.Margin = new System.Windows.Forms.Padding(4);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(209, 22);
            this.txtAuthorName.TabIndex = 87;
            this.txtAuthorName.TextChanged += new System.EventHandler(this.txtAuthorName_TextChanged);
            // 
            // lblAuthorName
            // 
            this.lblAuthorName.AutoSize = true;
            this.lblAuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthorName.ForeColor = System.Drawing.Color.White;
            this.lblAuthorName.Location = new System.Drawing.Point(32, 41);
            this.lblAuthorName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuthorName.Name = "lblAuthorName";
            this.lblAuthorName.Size = new System.Drawing.Size(53, 20);
            this.lblAuthorName.TabIndex = 88;
            this.lblAuthorName.Text = "Name";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(211, 305);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 89;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // metroRadioButton1
            // 
            this.metroRadioButton1.AutoSize = true;
            this.metroRadioButton1.Location = new System.Drawing.Point(53, 315);
            this.metroRadioButton1.Name = "metroRadioButton1";
            this.metroRadioButton1.Size = new System.Drawing.Size(137, 17);
            this.metroRadioButton1.TabIndex = 90;
            this.metroRadioButton1.Text = "metroRadioButton1";
            this.metroRadioButton1.UseSelectable = true;
            // 
            // Author
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 421);
            this.Controls.Add(this.metroRadioButton1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblAuthorName);
            this.Controls.Add(this.txtAuthorName);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.checkListAuthors);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Author";
            this.Text = "Author";
            this.Load += new System.EventHandler(this.Author_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.CheckedListBox checkListAuthors;
        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.Label lblAuthorName;
        private System.Windows.Forms.Button btnSave;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton1;
    }
}