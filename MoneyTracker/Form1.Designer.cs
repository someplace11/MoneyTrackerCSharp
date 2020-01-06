namespace MoneyTracker
{
    partial class MoneyTracker
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
            this.inputDate = new System.Windows.Forms.DateTimePicker();
            this.inputTransNote = new System.Windows.Forms.TextBox();
            this.inputCard = new System.Windows.Forms.ComboBox();
            this.inputAmount = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCard = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblTransNote = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.lbDisplay = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // inputDate
            // 
            this.inputDate.CustomFormat = "";
            this.inputDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.inputDate.Location = new System.Drawing.Point(115, 12);
            this.inputDate.Name = "inputDate";
            this.inputDate.Size = new System.Drawing.Size(200, 22);
            this.inputDate.TabIndex = 0;
            // 
            // inputTransNote
            // 
            this.inputTransNote.Location = new System.Drawing.Point(482, 58);
            this.inputTransNote.Name = "inputTransNote";
            this.inputTransNote.Size = new System.Drawing.Size(195, 22);
            this.inputTransNote.TabIndex = 3;
            // 
            // inputCard
            // 
            this.inputCard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputCard.FormattingEnabled = true;
            this.inputCard.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.inputCard.Items.AddRange(new object[] {
            "1234",
            "5678",
            "9101"});
            this.inputCard.Location = new System.Drawing.Point(482, 12);
            this.inputCard.Name = "inputCard";
            this.inputCard.Size = new System.Drawing.Size(195, 24);
            this.inputCard.TabIndex = 1;
            // 
            // inputAmount
            // 
            this.inputAmount.Location = new System.Drawing.Point(115, 58);
            this.inputAmount.Name = "inputAmount";
            this.inputAmount.Size = new System.Drawing.Size(200, 22);
            this.inputAmount.TabIndex = 2;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(12, 12);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(83, 17);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Select date:";
            // 
            // lblCard
            // 
            this.lblCard.AutoSize = true;
            this.lblCard.Location = new System.Drawing.Point(393, 12);
            this.lblCard.Name = "lblCard";
            this.lblCard.Size = new System.Drawing.Size(83, 17);
            this.lblCard.TabIndex = 5;
            this.lblCard.Text = "Select card:";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(12, 61);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(97, 17);
            this.lblAmount.TabIndex = 6;
            this.lblAmount.Text = "Enter amount:";
            // 
            // lblTransNote
            // 
            this.lblTransNote.AutoSize = true;
            this.lblTransNote.Location = new System.Drawing.Point(357, 58);
            this.lblTransNote.Name = "lblTransNote";
            this.lblTransNote.Size = new System.Drawing.Size(119, 17);
            this.lblTransNote.TabIndex = 7;
            this.lblTransNote.Text = "Transaction note:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(261, 118);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(185, 30);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit...";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(261, 164);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(185, 30);
            this.btnShow.TabIndex = 8;
            this.btnShow.Text = "Show All...";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // lbDisplay
            // 
            this.lbDisplay.FormattingEnabled = true;
            this.lbDisplay.ItemHeight = 16;
            this.lbDisplay.Location = new System.Drawing.Point(15, 219);
            this.lbDisplay.Name = "lbDisplay";
            this.lbDisplay.Size = new System.Drawing.Size(662, 212);
            this.lbDisplay.TabIndex = 9;
            // 
            // MoneyTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 450);
            this.Controls.Add(this.lbDisplay);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblTransNote);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblCard);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.inputAmount);
            this.Controls.Add(this.inputCard);
            this.Controls.Add(this.inputTransNote);
            this.Controls.Add(this.inputDate);
            this.Name = "MoneyTracker";
            this.Text = "Money Tracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker inputDate;
        private System.Windows.Forms.TextBox inputTransNote;
        private System.Windows.Forms.ComboBox inputCard;
        private System.Windows.Forms.TextBox inputAmount;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCard;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblTransNote;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.ListBox lbDisplay;
    }
}

