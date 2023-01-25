
namespace TrialDemo
{
    partial class ActivationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMacAddress = new System.Windows.Forms.TextBox();
            this.buttonActivation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(62, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(821, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your key to upgrade Pro Version";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(88, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "Key";
            // 
            // textBoxKey
            // 
            this.textBoxKey.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxKey.Location = new System.Drawing.Point(88, 271);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(779, 47);
            this.textBoxKey.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(88, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 41);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mac Address";
            // 
            // textBoxMacAddress
            // 
            this.textBoxMacAddress.Enabled = false;
            this.textBoxMacAddress.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMacAddress.Location = new System.Drawing.Point(88, 165);
            this.textBoxMacAddress.Name = "textBoxMacAddress";
            this.textBoxMacAddress.Size = new System.Drawing.Size(779, 47);
            this.textBoxMacAddress.TabIndex = 2;
            // 
            // buttonActivation
            // 
            this.buttonActivation.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonActivation.Location = new System.Drawing.Point(169, 380);
            this.buttonActivation.Name = "buttonActivation";
            this.buttonActivation.Size = new System.Drawing.Size(613, 55);
            this.buttonActivation.TabIndex = 3;
            this.buttonActivation.Text = "Active";
            this.buttonActivation.UseVisualStyleBackColor = true;
            this.buttonActivation.Click += new System.EventHandler(this.buttonActivation_Click);
            // 
            // ActivationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 452);
            this.Controls.Add(this.buttonActivation);
            this.Controls.Add(this.textBoxMacAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ActivationForm";
            this.Padding = new System.Windows.Forms.Padding(12, 14, 12, 14);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ActivationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMacAddress;
        private System.Windows.Forms.Button buttonActivation;
    }
}
