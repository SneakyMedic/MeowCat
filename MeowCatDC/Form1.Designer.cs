namespace MeowCatDC
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.urlbox = new System.Windows.Forms.TextBox();
            this.getButton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.addbox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ac = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.idbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.clearall = new System.Windows.Forms.Button();
            this.statuslabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 79);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(699, 290);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // urlbox
            // 
            this.urlbox.Location = new System.Drawing.Point(12, 25);
            this.urlbox.Name = "urlbox";
            this.urlbox.Size = new System.Drawing.Size(657, 20);
            this.urlbox.TabIndex = 1;
            this.urlbox.Text = "http://localhost:80";
            this.urlbox.TextChanged += new System.EventHandler(this.urlbox_TextChanged);
            // 
            // getButton
            // 
            this.getButton.Location = new System.Drawing.Point(675, 25);
            this.getButton.Name = "getButton";
            this.getButton.Size = new System.Drawing.Size(75, 21);
            this.getButton.TabIndex = 2;
            this.getButton.Text = "Get";
            this.getButton.UseVisualStyleBackColor = true;
            this.getButton.Click += new System.EventHandler(this.getButton_Click);
            // 
            // delButton
            // 
            this.delButton.Location = new System.Drawing.Point(717, 206);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(68, 48);
            this.delButton.TabIndex = 3;
            this.delButton.Text = "Delete Selected";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // addbox
            // 
            this.addbox.Location = new System.Drawing.Point(13, 383);
            this.addbox.Name = "addbox";
            this.addbox.Size = new System.Drawing.Size(698, 20);
            this.addbox.TabIndex = 4;
            this.addbox.TextChanged += new System.EventHandler(this.addbox_TextChanged);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(717, 383);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(55, 20);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Notes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Server";
            // 
            // ac
            // 
            this.ac.Location = new System.Drawing.Point(675, 52);
            this.ac.Name = "ac";
            this.ac.Size = new System.Drawing.Size(75, 21);
            this.ac.TabIndex = 8;
            this.ac.Text = "AC";
            this.ac.UseVisualStyleBackColor = true;
            this.ac.Click += new System.EventHandler(this.ac_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(13, 409);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 9;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // idbox
            // 
            this.idbox.Location = new System.Drawing.Point(143, 51);
            this.idbox.Name = "idbox";
            this.idbox.Size = new System.Drawing.Size(526, 20);
            this.idbox.TabIndex = 10;
            this.idbox.Text = "note/hello";
            this.idbox.TextChanged += new System.EventHandler(this.idbox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "ID";
            // 
            // clearall
            // 
            this.clearall.Location = new System.Drawing.Point(717, 152);
            this.clearall.Name = "clearall";
            this.clearall.Size = new System.Drawing.Size(68, 48);
            this.clearall.TabIndex = 12;
            this.clearall.Text = "Clear All";
            this.clearall.UseVisualStyleBackColor = true;
            this.clearall.Click += new System.EventHandler(this.clearall_Click);
            // 
            // statuslabel
            // 
            this.statuslabel.AutoSize = true;
            this.statuslabel.Location = new System.Drawing.Point(595, 425);
            this.statuslabel.Name = "statuslabel";
            this.statuslabel.Size = new System.Drawing.Size(63, 13);
            this.statuslabel.TabIndex = 13;
            this.statuslabel.Text = "Status: N/A";
            this.statuslabel.Click += new System.EventHandler(this.statuslabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 447);
            this.Controls.Add(this.statuslabel);
            this.Controls.Add(this.clearall);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idbox);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.ac);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.addbox);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.getButton);
            this.Controls.Add(this.urlbox);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "MeowCat Desktop Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox urlbox;
        private System.Windows.Forms.Button getButton;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.TextBox addbox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ac;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox idbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button clearall;
        private System.Windows.Forms.Label statuslabel;
    }
}

