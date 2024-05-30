namespace slide10
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
            this.chklbDanhSach = new System.Windows.Forms.CheckedListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnAddrange = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnRemoveAt = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCheckedIndices = new System.Windows.Forms.Button();
            this.btnCheckedItems = new System.Windows.Forms.Button();
            this.btnGetItemChecked = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chklbDanhSach
            // 
            this.chklbDanhSach.FormattingEnabled = true;
            this.chklbDanhSach.Items.AddRange(new object[] {
            "san pham 1",
            "san pham 2",
            "3",
            "4",
            "5",
            "6"});
            this.chklbDanhSach.Location = new System.Drawing.Point(37, 31);
            this.chklbDanhSach.Name = "chklbDanhSach";
            this.chklbDanhSach.Size = new System.Drawing.Size(120, 94);
            this.chklbDanhSach.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(184, 31);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(184, 61);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnAddrange
            // 
            this.btnAddrange.Location = new System.Drawing.Point(184, 91);
            this.btnAddrange.Name = "btnAddrange";
            this.btnAddrange.Size = new System.Drawing.Size(75, 23);
            this.btnAddrange.TabIndex = 3;
            this.btnAddrange.Text = "Addrange";
            this.btnAddrange.UseVisualStyleBackColor = true;
            this.btnAddrange.Click += new System.EventHandler(this.btnAddrange_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(184, 132);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(75, 23);
            this.btnCount.TabIndex = 4;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(184, 172);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnRemoveAt
            // 
            this.btnRemoveAt.Location = new System.Drawing.Point(294, 31);
            this.btnRemoveAt.Name = "btnRemoveAt";
            this.btnRemoveAt.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveAt.TabIndex = 6;
            this.btnRemoveAt.Text = "RemoveAt";
            this.btnRemoveAt.UseVisualStyleBackColor = true;
            this.btnRemoveAt.Click += new System.EventHandler(this.btnRemoveAt_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(294, 60);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCheckedIndices
            // 
            this.btnCheckedIndices.Location = new System.Drawing.Point(294, 90);
            this.btnCheckedIndices.Name = "btnCheckedIndices";
            this.btnCheckedIndices.Size = new System.Drawing.Size(88, 23);
            this.btnCheckedIndices.TabIndex = 8;
            this.btnCheckedIndices.Text = "CheckedIndices";
            this.btnCheckedIndices.UseVisualStyleBackColor = true;
            this.btnCheckedIndices.Click += new System.EventHandler(this.btnCheckedIndices_Click);
            // 
            // btnCheckedItems
            // 
            this.btnCheckedItems.Location = new System.Drawing.Point(294, 131);
            this.btnCheckedItems.Name = "btnCheckedItems";
            this.btnCheckedItems.Size = new System.Drawing.Size(97, 23);
            this.btnCheckedItems.TabIndex = 9;
            this.btnCheckedItems.Text = "CheckedItems";
            this.btnCheckedItems.UseVisualStyleBackColor = true;
            this.btnCheckedItems.Click += new System.EventHandler(this.btnCheckedItems_Click);
            // 
            // btnGetItemChecked
            // 
            this.btnGetItemChecked.Location = new System.Drawing.Point(294, 172);
            this.btnGetItemChecked.Name = "btnGetItemChecked";
            this.btnGetItemChecked.Size = new System.Drawing.Size(105, 23);
            this.btnGetItemChecked.TabIndex = 10;
            this.btnGetItemChecked.Text = "GetItemChecked";
            this.btnGetItemChecked.UseVisualStyleBackColor = true;
            this.btnGetItemChecked.Click += new System.EventHandler(this.btnGetItemChecked_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 261);
            this.Controls.Add(this.btnGetItemChecked);
            this.Controls.Add(this.btnCheckedItems);
            this.Controls.Add(this.btnCheckedIndices);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRemoveAt);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnAddrange);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.chklbDanhSach);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chklbDanhSach;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnAddrange;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnRemoveAt;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCheckedIndices;
        private System.Windows.Forms.Button btnCheckedItems;
        private System.Windows.Forms.Button btnGetItemChecked;
    }
}

