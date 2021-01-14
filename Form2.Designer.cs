
namespace WindowsDesktopClientForApi
{
    partial class Form2
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
            this.label6 = new System.Windows.Forms.Label();
            this.quanatityTypeBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ingredientStoredBox = new System.Windows.Forms.TextBox();
            this.ingredientNameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.quantityBox = new System.Windows.Forms.NumericUpDown();
            this.ingredientUseByBox = new System.Windows.Forms.DateTimePicker();
            this.resultText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.quantityBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(270, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 28;
            this.label6.Text = "Quantity type:";
            // 
            // quanatityTypeBox
            // 
            this.quanatityTypeBox.Location = new System.Drawing.Point(358, 272);
            this.quanatityTypeBox.Name = "quanatityTypeBox";
            this.quanatityTypeBox.Size = new System.Drawing.Size(218, 23);
            this.quanatityTypeBox.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "Quantity:";
            // 
            // ingredientStoredBox
            // 
            this.ingredientStoredBox.Location = new System.Drawing.Point(358, 185);
            this.ingredientStoredBox.Name = "ingredientStoredBox";
            this.ingredientStoredBox.Size = new System.Drawing.Size(218, 23);
            this.ingredientStoredBox.TabIndex = 23;
            // 
            // ingredientNameBox
            // 
            this.ingredientNameBox.Location = new System.Drawing.Point(358, 156);
            this.ingredientNameBox.Name = "ingredientNameBox";
            this.ingredientNameBox.Size = new System.Drawing.Size(218, 23);
            this.ingredientNameBox.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Ingredient use by date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Ingredient stored in:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ingredient name:";
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(358, 318);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(97, 50);
            this.createButton.TabIndex = 29;
            this.createButton.Text = "Add new ingredient";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // quantityBox
            // 
            this.quantityBox.Location = new System.Drawing.Point(359, 244);
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.Size = new System.Drawing.Size(120, 23);
            this.quantityBox.TabIndex = 30;
            // 
            // ingredientUseByBox
            // 
            this.ingredientUseByBox.Location = new System.Drawing.Point(358, 215);
            this.ingredientUseByBox.Name = "ingredientUseByBox";
            this.ingredientUseByBox.Size = new System.Drawing.Size(200, 23);
            this.ingredientUseByBox.TabIndex = 31;
            // 
            // resultText
            // 
            this.resultText.AutoSize = true;
            this.resultText.Location = new System.Drawing.Point(281, 65);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(0, 15);
            this.resultText.TabIndex = 32;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.ingredientUseByBox);
            this.Controls.Add(this.quantityBox);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.quanatityTypeBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ingredientStoredBox);
            this.Controls.Add(this.ingredientNameBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.quantityBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox quanatityTypeBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ingredientStoredBox;
        private System.Windows.Forms.TextBox ingredientNameBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.NumericUpDown quantityBox;
        private System.Windows.Forms.DateTimePicker ingredientUseByBox;
        private System.Windows.Forms.Label resultText;
    }
}