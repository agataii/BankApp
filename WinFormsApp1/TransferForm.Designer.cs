namespace WinFormsApp1
{
    partial class TransferForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this._inputValue = new System.Windows.Forms.TextBox();
            this._infoText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._balanceValueText = new System.Windows.Forms.Label();
            this._backButton = new System.Windows.Forms.Button();
            this._transferListView = new System.Windows.Forms.ListView();
            this.Date = new System.Windows.Forms.ColumnHeader();
            this.value = new System.Windows.Forms.ColumnHeader();
            this.Target = new System.Windows.Forms.ColumnHeader();
            this._listViewClear = new System.Windows.Forms.Button();
            this._transferTargetInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(111, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "ПЕРЕВОДЫ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(133, 371);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 55);
            this.button1.TabIndex = 2;
            this.button1.Text = "ПЕРЕВЕСТИ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "СУММА";
            // 
            // _inputValue
            // 
            this._inputValue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._inputValue.Location = new System.Drawing.Point(64, 324);
            this._inputValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._inputValue.Name = "_inputValue";
            this._inputValue.PlaceholderText = "Введите сумму";
            this._inputValue.Size = new System.Drawing.Size(303, 39);
            this._inputValue.TabIndex = 4;
            this._inputValue.TextChanged += new System.EventHandler(this._inputValue_TextChanged);
            // 
            // _infoText
            // 
            this._infoText.BackColor = System.Drawing.Color.DeepSkyBlue;
            this._infoText.ForeColor = System.Drawing.Color.White;
            this._infoText.Location = new System.Drawing.Point(19, 693);
            this._infoText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._infoText.Name = "_infoText";
            this._infoText.ReadOnly = true;
            this._infoText.Size = new System.Drawing.Size(411, 27);
            this._infoText.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "БАЛАНС";
            // 
            // _balanceValueText
            // 
            this._balanceValueText.AutoSize = true;
            this._balanceValueText.BackColor = System.Drawing.Color.DeepSkyBlue;
            this._balanceValueText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._balanceValueText.ForeColor = System.Drawing.Color.White;
            this._balanceValueText.Location = new System.Drawing.Point(198, 115);
            this._balanceValueText.Name = "_balanceValueText";
            this._balanceValueText.Size = new System.Drawing.Size(120, 28);
            this._balanceValueText.TabIndex = 6;
            this._balanceValueText.Text = "*BALANCE*";
            // 
            // _backButton
            // 
            this._backButton.BackColor = System.Drawing.Color.Black;
            this._backButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._backButton.ForeColor = System.Drawing.Color.White;
            this._backButton.Location = new System.Drawing.Point(14, 16);
            this._backButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._backButton.Name = "_backButton";
            this._backButton.Size = new System.Drawing.Size(50, 57);
            this._backButton.TabIndex = 7;
            this._backButton.Text = "<";
            this._backButton.UseVisualStyleBackColor = false;
            this._backButton.Click += new System.EventHandler(this._backButton_Click);
            // 
            // _transferListView
            // 
            this._transferListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Date,
            this.value,
            this.Target});
            this._transferListView.Location = new System.Drawing.Point(64, 433);
            this._transferListView.Name = "_transferListView";
            this._transferListView.Size = new System.Drawing.Size(303, 253);
            this._transferListView.TabIndex = 8;
            this._transferListView.UseCompatibleStateImageBehavior = false;
            this._transferListView.View = System.Windows.Forms.View.Details;
            // 
            // Date
            // 
            this.Date.Text = "Дата";
            this.Date.Width = 80;
            // 
            // value
            // 
            this.value.Text = "Сумма";
            this.value.Width = 90;
            // 
            // Target
            // 
            this.Target.Text = "Кому";
            this.Target.Width = 130;
            // 
            // _listViewClear
            // 
            this._listViewClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._listViewClear.Location = new System.Drawing.Point(315, 371);
            this._listViewClear.Name = "_listViewClear";
            this._listViewClear.Size = new System.Drawing.Size(52, 55);
            this._listViewClear.TabIndex = 9;
            this._listViewClear.Text = "X";
            this._listViewClear.UseVisualStyleBackColor = true;
            this._listViewClear.Click += new System.EventHandler(this.ListViewClear_Click);
            // 
            // _transferTargetInput
            // 
            this._transferTargetInput.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._transferTargetInput.Location = new System.Drawing.Point(64, 210);
            this._transferTargetInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._transferTargetInput.Name = "_transferTargetInput";
            this._transferTargetInput.PlaceholderText = "Введите номер карты";
            this._transferTargetInput.Size = new System.Drawing.Size(303, 39);
            this._transferTargetInput.TabIndex = 4;
            this._transferTargetInput.TextChanged += new System.EventHandler(this._inputValue_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "КОМУ";
            // 
            // TransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(439, 741);
            this.Controls.Add(this._listViewClear);
            this.Controls.Add(this._transferListView);
            this.Controls.Add(this._backButton);
            this.Controls.Add(this._balanceValueText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._infoText);
            this.Controls.Add(this._transferTargetInput);
            this.Controls.Add(this._inputValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TransferForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TransferForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label2;
        private TextBox _inputValue;
        private TextBox _infoText;
        private Label label3;
        private Label _balanceValueText; // _balanceValueText.Text = _account.Balance
        private Button _backButton;
        private ListView _transferListView;
        private ColumnHeader Date;
        private ColumnHeader value;
        private Button _listViewClear;
        private ColumnHeader Target;
        private TextBox _transferTargetInput;
        private Label label4;
    }
}