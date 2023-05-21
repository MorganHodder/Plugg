namespace SlutprovPlugg
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
            this.lblName = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxLength = new System.Windows.Forms.TextBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.tbxWidth = new System.Windows.Forms.TextBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lbxRooms = new System.Windows.Forms.ListBox();
            this.btnLargest = new System.Windows.Forms.Button();
            this.tbxLargest = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(36, 32);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Namn";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(99, 29);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(156, 20);
            this.tbxName.TabIndex = 1;
            // 
            // tbxLength
            // 
            this.tbxLength.Location = new System.Drawing.Point(99, 55);
            this.tbxLength.Name = "tbxLength";
            this.tbxLength.Size = new System.Drawing.Size(156, 20);
            this.tbxLength.TabIndex = 3;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(36, 58);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(57, 13);
            this.lblLength.TabIndex = 2;
            this.lblLength.Text = "Längd (m):";
            // 
            // tbxWidth
            // 
            this.tbxWidth.Location = new System.Drawing.Point(99, 81);
            this.tbxWidth.Name = "tbxWidth";
            this.tbxWidth.Size = new System.Drawing.Size(156, 20);
            this.tbxWidth.TabIndex = 5;
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(36, 84);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(55, 13);
            this.lblWidth.TabIndex = 4;
            this.lblWidth.Text = "Bredd (m):";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(99, 107);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Lägg Till";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(180, 107);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Ta Bort";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lbxRooms
            // 
            this.lbxRooms.FormattingEnabled = true;
            this.lbxRooms.Location = new System.Drawing.Point(39, 136);
            this.lbxRooms.Name = "lbxRooms";
            this.lbxRooms.Size = new System.Drawing.Size(216, 173);
            this.lbxRooms.TabIndex = 8;
            // 
            // btnLargest
            // 
            this.btnLargest.Location = new System.Drawing.Point(39, 316);
            this.btnLargest.Name = "btnLargest";
            this.btnLargest.Size = new System.Drawing.Size(75, 23);
            this.btnLargest.TabIndex = 9;
            this.btnLargest.Text = "Största Rum";
            this.btnLargest.UseVisualStyleBackColor = true;
            this.btnLargest.Click += new System.EventHandler(this.btnLargest_Click);
            // 
            // tbxLargest
            // 
            this.tbxLargest.Location = new System.Drawing.Point(39, 346);
            this.tbxLargest.Name = "tbxLargest";
            this.tbxLargest.Size = new System.Drawing.Size(216, 20);
            this.tbxLargest.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 450);
            this.Controls.Add(this.tbxLargest);
            this.Controls.Add(this.btnLargest);
            this.Controls.Add(this.lbxRooms);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbxWidth);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.tbxLength);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxLength;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.TextBox tbxWidth;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListBox lbxRooms;
        private System.Windows.Forms.Button btnLargest;
        private System.Windows.Forms.TextBox tbxLargest;
    }
}

