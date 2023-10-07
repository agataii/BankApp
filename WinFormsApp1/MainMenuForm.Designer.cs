namespace WinFormsApp1
{
    partial class MainMenuForm
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
            this._transferButton = new System.Windows.Forms.Button();
            this._balanceValueText = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(135, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "БАНК";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // _transferButton
            // 
            this._transferButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this._transferButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._transferButton.ForeColor = System.Drawing.Color.White;
            this._transferButton.Location = new System.Drawing.Point(115, 187);
            this._transferButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._transferButton.Name = "_transferButton";
            this._transferButton.Size = new System.Drawing.Size(184, 73);
            this._transferButton.TabIndex = 1;
            this._transferButton.Text = "ПЕРЕВОДЫ";
            this._transferButton.UseVisualStyleBackColor = false;
            this._transferButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // _balanceValueText
            // 
            this._balanceValueText.AutoSize = true;
            this._balanceValueText.BackColor = System.Drawing.Color.DeepSkyBlue;
            this._balanceValueText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._balanceValueText.ForeColor = System.Drawing.Color.White;
            this._balanceValueText.Location = new System.Drawing.Point(190, 99);
            this._balanceValueText.Name = "_balanceValueText";
            this._balanceValueText.Size = new System.Drawing.Size(120, 28);
            this._balanceValueText.TabIndex = 7;
            this._balanceValueText.Text = "*BALANCE*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "БАЛАНС";
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(439, 615);
            this.Controls.Add(this._balanceValueText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._transferButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainMenuForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button _transferButton;
        private Label _balanceValueText;
        private Label label3;
    }
}