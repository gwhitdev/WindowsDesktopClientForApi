
namespace WindowsDesktopClientForApi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstIngredients = new System.Windows.Forms.ListBox();
            this.ingredientName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ingredientNameBox = new System.Windows.Forms.TextBox();
            this.ingredientStoredBox = new System.Windows.Forms.TextBox();
            this.ingredientUseByBox = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.quantityBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.quanatityTypeBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ingredientsChangedButton = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingredients";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAdd.Location = new System.Drawing.Point(433, 312);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(123, 52);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Get Ingredients";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstIngredients
            // 
            this.lstIngredients.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lstIngredients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstIngredients.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstIngredients.FormattingEnabled = true;
            this.lstIngredients.ItemHeight = 37;
            this.lstIngredients.Location = new System.Drawing.Point(433, 21);
            this.lstIngredients.Name = "lstIngredients";
            this.lstIngredients.Size = new System.Drawing.Size(248, 259);
            this.lstIngredients.TabIndex = 2;
            this.lstIngredients.SelectedIndexChanged += new System.EventHandler(this.lstIngredients_SelectedIndexChanged);
            // 
            // ingredientName
            // 
            this.ingredientName.AutoSize = true;
            this.ingredientName.Location = new System.Drawing.Point(293, -42);
            this.ingredientName.Name = "ingredientName";
            this.ingredientName.Size = new System.Drawing.Size(0, 15);
            this.ingredientName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ingredient name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ingredient stored in:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ingredient use by date:";
            // 
            // ingredientNameBox
            // 
            this.ingredientNameBox.Enabled = false;
            this.ingredientNameBox.Location = new System.Drawing.Point(152, 75);
            this.ingredientNameBox.Name = "ingredientNameBox";
            this.ingredientNameBox.ReadOnly = true;
            this.ingredientNameBox.Size = new System.Drawing.Size(218, 23);
            this.ingredientNameBox.TabIndex = 9;
            // 
            // ingredientStoredBox
            // 
            this.ingredientStoredBox.Enabled = false;
            this.ingredientStoredBox.Location = new System.Drawing.Point(152, 104);
            this.ingredientStoredBox.Name = "ingredientStoredBox";
            this.ingredientStoredBox.ReadOnly = true;
            this.ingredientStoredBox.Size = new System.Drawing.Size(218, 23);
            this.ingredientStoredBox.TabIndex = 10;
            // 
            // ingredientUseByBox
            // 
            this.ingredientUseByBox.Enabled = false;
            this.ingredientUseByBox.Location = new System.Drawing.Point(152, 133);
            this.ingredientUseByBox.Name = "ingredientUseByBox";
            this.ingredientUseByBox.ReadOnly = true;
            this.ingredientUseByBox.Size = new System.Drawing.Size(218, 23);
            this.ingredientUseByBox.TabIndex = 11;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(584, 314);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(97, 50);
            this.createButton.TabIndex = 12;
            this.createButton.Text = "Add new ingredient";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(303, 312);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(67, 36);
            this.deleteButton.TabIndex = 13;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(205, 312);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(78, 36);
            this.updateButton.TabIndex = 14;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // quantityBox
            // 
            this.quantityBox.Enabled = false;
            this.quantityBox.Location = new System.Drawing.Point(152, 162);
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.ReadOnly = true;
            this.quantityBox.Size = new System.Drawing.Size(218, 23);
            this.quantityBox.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Quantity:";
            // 
            // quanatityTypeBox
            // 
            this.quanatityTypeBox.Enabled = false;
            this.quanatityTypeBox.Location = new System.Drawing.Point(152, 191);
            this.quanatityTypeBox.Name = "quanatityTypeBox";
            this.quanatityTypeBox.ReadOnly = true;
            this.quanatityTypeBox.Size = new System.Drawing.Size(218, 23);
            this.quanatityTypeBox.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Quantity type:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 366);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(718, 22);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // ingredientsChangedButton
            // 
            this.ingredientsChangedButton.Location = new System.Drawing.Point(50, 300);
            this.ingredientsChangedButton.Name = "ingredientsChangedButton";
            this.ingredientsChangedButton.Size = new System.Drawing.Size(69, 47);
            this.ingredientsChangedButton.TabIndex = 20;
            this.ingredientsChangedButton.Text = "Have Changed";
            this.ingredientsChangedButton.UseVisualStyleBackColor = true;
            this.ingredientsChangedButton.Click += new System.EventHandler(this.ingredientsChangedButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 388);
            this.Controls.Add(this.ingredientsChangedButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.quanatityTypeBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.quantityBox);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.ingredientUseByBox);
            this.Controls.Add(this.ingredientStoredBox);
            this.Controls.Add(this.ingredientNameBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ingredientName);
            this.Controls.Add(this.lstIngredients);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ingredients";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstIngredients;
        private System.Windows.Forms.Label ingredientName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ingredientNameBox;
        private System.Windows.Forms.TextBox ingredientStoredBox;
        private System.Windows.Forms.TextBox ingredientUseByBox;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox quantityBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox quanatityTypeBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button ingredientsChangedButton;
    }
}

