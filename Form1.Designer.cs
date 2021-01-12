
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
            this.ingredientKeptAt = new System.Windows.Forms.Label();
            this.ingredientUseByDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingredients";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAdd.Location = new System.Drawing.Point(509, 418);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(233, 104);
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
            this.lstIngredients.Location = new System.Drawing.Point(108, 45);
            this.lstIngredients.Name = "lstIngredients";
            this.lstIngredients.Size = new System.Drawing.Size(248, 370);
            this.lstIngredients.TabIndex = 2;
            this.lstIngredients.SelectedIndexChanged += new System.EventHandler(this.lstIngredients_SelectedIndexChanged);
            // 
            // ingredientName
            // 
            this.ingredientName.AutoSize = true;
            this.ingredientName.Location = new System.Drawing.Point(451, 46);
            this.ingredientName.Name = "ingredientName";
            this.ingredientName.Size = new System.Drawing.Size(0, 15);
            this.ingredientName.TabIndex = 3;
            this.ingredientName.Click += new System.EventHandler(this.label2_Click);
            // 
            // ingredientKeptAt
            // 
            this.ingredientKeptAt.AutoSize = true;
            this.ingredientKeptAt.Location = new System.Drawing.Point(451, 99);
            this.ingredientKeptAt.Name = "ingredientKeptAt";
            this.ingredientKeptAt.Size = new System.Drawing.Size(0, 15);
            this.ingredientKeptAt.TabIndex = 4;
            // 
            // ingredientUseByDate
            // 
            this.ingredientUseByDate.AutoSize = true;
            this.ingredientUseByDate.Location = new System.Drawing.Point(451, 151);
            this.ingredientUseByDate.Name = "ingredientUseByDate";
            this.ingredientUseByDate.Size = new System.Drawing.Size(117, 15);
            this.ingredientUseByDate.TabIndex = 5;
            this.ingredientUseByDate.Text = "ingredientUseByDate";
            this.ingredientUseByDate.Click += new System.EventHandler(this.ingredientUseByDate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 685);
            this.Controls.Add(this.ingredientUseByDate);
            this.Controls.Add(this.ingredientKeptAt);
            this.Controls.Add(this.ingredientName);
            this.Controls.Add(this.lstIngredients);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ingredients";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstIngredients;
        private System.Windows.Forms.Label ingredientName;
        private System.Windows.Forms.Label ingredientKeptAt;
        private System.Windows.Forms.Label ingredientUseByDate;
    }
}

