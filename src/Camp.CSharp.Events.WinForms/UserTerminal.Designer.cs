
namespace Camp.CSharp.Events.WinForms
{
    partial class UserTerminal
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
            if(disposing && (components != null))
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
            this.btn_Withdraw = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btn_Replenishment = new System.Windows.Forms.Button();
            this.lbl_Welcome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Withdraw
            // 
            this.btn_Withdraw.Location = new System.Drawing.Point(23, 136);
            this.btn_Withdraw.Name = "btn_Withdraw";
            this.btn_Withdraw.Size = new System.Drawing.Size(75, 23);
            this.btn_Withdraw.TabIndex = 0;
            this.btn_Withdraw.Text = "Withdraw";
            this.btn_Withdraw.UseVisualStyleBackColor = true;
            this.btn_Withdraw.Click += new System.EventHandler(this.btn_Withdraw_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(23, 68);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(225, 23);
            this.numericUpDown1.TabIndex = 1;
            // 
            // btn_Replenishment
            // 
            this.btn_Replenishment.Location = new System.Drawing.Point(147, 136);
            this.btn_Replenishment.Name = "btn_Replenishment";
            this.btn_Replenishment.Size = new System.Drawing.Size(101, 23);
            this.btn_Replenishment.TabIndex = 2;
            this.btn_Replenishment.Text = "Replenishment";
            this.btn_Replenishment.UseVisualStyleBackColor = true;
            this.btn_Replenishment.Click += new System.EventHandler(this.btn_Replenishment_Click);
            // 
            // lbl_Welcome
            // 
            this.lbl_Welcome.AutoSize = true;
            this.lbl_Welcome.Location = new System.Drawing.Point(23, 23);
            this.lbl_Welcome.Name = "lbl_Welcome";
            this.lbl_Welcome.Size = new System.Drawing.Size(57, 15);
            this.lbl_Welcome.TabIndex = 3;
            this.lbl_Welcome.Text = "Welcome";
            // 
            // UserTerminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 317);
            this.Controls.Add(this.lbl_Welcome);
            this.Controls.Add(this.btn_Replenishment);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btn_Withdraw);
            this.Name = "UserTerminal";
            this.Text = "UserTerminal";
            this.Load += new System.EventHandler(this.UserTerminal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Withdraw;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btn_Replenishment;
        private System.Windows.Forms.Label lbl_Welcome;
    }
}