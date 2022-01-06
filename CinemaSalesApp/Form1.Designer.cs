namespace CinemaSalesApp
{
    partial class cinemaSalesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cinemaSalesForm));
            this.megaCinemaPictureBox = new System.Windows.Forms.PictureBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.cashierNameLabel = new System.Windows.Forms.Label();
            this.cashierNameTextBox = new System.Windows.Forms.TextBox();
            this.adultLabel = new System.Windows.Forms.Label();
            this.childLabel = new System.Windows.Forms.Label();
            this.studentLabel = new System.Windows.Forms.Label();
            this.adultCountTextBox = new System.Windows.Forms.TextBox();
            this.studentCountTextBox = new System.Windows.Forms.TextBox();
            this.childCountTextBox = new System.Windows.Forms.TextBox();
            this.ticketCountGroupBox = new System.Windows.Forms.GroupBox();
            this.buttonsControlPanel = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.summaryButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.cashierSummaryGroupBox = new System.Windows.Forms.GroupBox();
            this.avgTransationsSummaryAmount = new System.Windows.Forms.Label();
            this.avgTransationsValueLabel = new System.Windows.Forms.Label();
            this.totalReceiptsSummaryAmount = new System.Windows.Forms.Label();
            this.totalTicketsSoldSummaryCount = new System.Windows.Forms.Label();
            this.cashierNameSummaryValue = new System.Windows.Forms.Label();
            this.totalReceiptsSummaryLabel = new System.Windows.Forms.Label();
            this.totalTicketsSoldSummaryLabel = new System.Windows.Forms.Label();
            this.cashierNameSummaryLabel = new System.Windows.Forms.Label();
            this.totalCashiersLabel = new System.Windows.Forms.Label();
            this.totalCashiersCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.megaCinemaPictureBox)).BeginInit();
            this.ticketCountGroupBox.SuspendLayout();
            this.buttonsControlPanel.SuspendLayout();
            this.cashierSummaryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // megaCinemaPictureBox
            // 
            this.megaCinemaPictureBox.Image = global::CinemaSalesApp.Properties.Resources.Mega_Cinema_logo1;
            this.megaCinemaPictureBox.Location = new System.Drawing.Point(27, 33);
            this.megaCinemaPictureBox.Name = "megaCinemaPictureBox";
            this.megaCinemaPictureBox.Size = new System.Drawing.Size(414, 132);
            this.megaCinemaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.megaCinemaPictureBox.TabIndex = 0;
            this.megaCinemaPictureBox.TabStop = false;
            // 
            // enterButton
            // 
            this.enterButton.BackColor = System.Drawing.Color.Navy;
            this.enterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.enterButton.Location = new System.Drawing.Point(192, 266);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(89, 37);
            this.enterButton.TabIndex = 1;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = false;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // cashierNameLabel
            // 
            this.cashierNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierNameLabel.Location = new System.Drawing.Point(54, 50);
            this.cashierNameLabel.Name = "cashierNameLabel";
            this.cashierNameLabel.Size = new System.Drawing.Size(128, 27);
            this.cashierNameLabel.TabIndex = 2;
            this.cashierNameLabel.Text = "Cashier Name";
            this.cashierNameLabel.Visible = false;
            // 
            // cashierNameTextBox
            // 
            this.cashierNameTextBox.Location = new System.Drawing.Point(233, 50);
            this.cashierNameTextBox.Name = "cashierNameTextBox";
            this.cashierNameTextBox.Size = new System.Drawing.Size(155, 22);
            this.cashierNameTextBox.TabIndex = 3;
            this.cashierNameTextBox.Visible = false;
            // 
            // adultLabel
            // 
            this.adultLabel.AutoSize = true;
            this.adultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adultLabel.Location = new System.Drawing.Point(83, 33);
            this.adultLabel.Name = "adultLabel";
            this.adultLabel.Size = new System.Drawing.Size(52, 20);
            this.adultLabel.TabIndex = 4;
            this.adultLabel.Text = "Adult";
            this.adultLabel.Visible = false;
            // 
            // childLabel
            // 
            this.childLabel.AutoSize = true;
            this.childLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.childLabel.Location = new System.Drawing.Point(84, 110);
            this.childLabel.Name = "childLabel";
            this.childLabel.Size = new System.Drawing.Size(52, 20);
            this.childLabel.TabIndex = 5;
            this.childLabel.Text = "Child";
            this.childLabel.Visible = false;
            // 
            // studentLabel
            // 
            this.studentLabel.AutoSize = true;
            this.studentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentLabel.Location = new System.Drawing.Point(66, 70);
            this.studentLabel.Name = "studentLabel";
            this.studentLabel.Size = new System.Drawing.Size(73, 20);
            this.studentLabel.TabIndex = 6;
            this.studentLabel.Text = "Student";
            this.studentLabel.Visible = false;
            // 
            // adultCountTextBox
            // 
            this.adultCountTextBox.Location = new System.Drawing.Point(224, 31);
            this.adultCountTextBox.Name = "adultCountTextBox";
            this.adultCountTextBox.Size = new System.Drawing.Size(73, 24);
            this.adultCountTextBox.TabIndex = 7;
            this.adultCountTextBox.Text = "0";
            this.adultCountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.adultCountTextBox.Visible = false;
            // 
            // studentCountTextBox
            // 
            this.studentCountTextBox.Location = new System.Drawing.Point(224, 70);
            this.studentCountTextBox.Name = "studentCountTextBox";
            this.studentCountTextBox.Size = new System.Drawing.Size(73, 24);
            this.studentCountTextBox.TabIndex = 8;
            this.studentCountTextBox.Text = "0";
            this.studentCountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.studentCountTextBox.Visible = false;
            // 
            // childCountTextBox
            // 
            this.childCountTextBox.Location = new System.Drawing.Point(224, 110);
            this.childCountTextBox.Name = "childCountTextBox";
            this.childCountTextBox.Size = new System.Drawing.Size(73, 24);
            this.childCountTextBox.TabIndex = 9;
            this.childCountTextBox.Text = "0";
            this.childCountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.childCountTextBox.Visible = false;
            // 
            // ticketCountGroupBox
            // 
            this.ticketCountGroupBox.Controls.Add(this.adultLabel);
            this.ticketCountGroupBox.Controls.Add(this.childCountTextBox);
            this.ticketCountGroupBox.Controls.Add(this.childLabel);
            this.ticketCountGroupBox.Controls.Add(this.studentCountTextBox);
            this.ticketCountGroupBox.Controls.Add(this.studentLabel);
            this.ticketCountGroupBox.Controls.Add(this.adultCountTextBox);
            this.ticketCountGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketCountGroupBox.Location = new System.Drawing.Point(27, 113);
            this.ticketCountGroupBox.Name = "ticketCountGroupBox";
            this.ticketCountGroupBox.Size = new System.Drawing.Size(420, 146);
            this.ticketCountGroupBox.TabIndex = 10;
            this.ticketCountGroupBox.TabStop = false;
            this.ticketCountGroupBox.Text = "Tickets";
            this.ticketCountGroupBox.Visible = false;
            // 
            // buttonsControlPanel
            // 
            this.buttonsControlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buttonsControlPanel.Controls.Add(this.exitButton);
            this.buttonsControlPanel.Controls.Add(this.summaryButton);
            this.buttonsControlPanel.Controls.Add(this.clearButton);
            this.buttonsControlPanel.Controls.Add(this.calculateButton);
            this.buttonsControlPanel.Location = new System.Drawing.Point(27, 287);
            this.buttonsControlPanel.Name = "buttonsControlPanel";
            this.buttonsControlPanel.Size = new System.Drawing.Size(420, 80);
            this.buttonsControlPanel.TabIndex = 11;
            this.buttonsControlPanel.Visible = false;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Navy;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitButton.Location = new System.Drawing.Point(318, 21);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(89, 33);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Visible = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // summaryButton
            // 
            this.summaryButton.BackColor = System.Drawing.Color.Navy;
            this.summaryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summaryButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.summaryButton.Location = new System.Drawing.Point(217, 21);
            this.summaryButton.Name = "summaryButton";
            this.summaryButton.Size = new System.Drawing.Size(89, 33);
            this.summaryButton.TabIndex = 2;
            this.summaryButton.Text = "Summary";
            this.summaryButton.UseVisualStyleBackColor = false;
            this.summaryButton.Visible = false;
            this.summaryButton.Click += new System.EventHandler(this.summaryButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Navy;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clearButton.Location = new System.Drawing.Point(113, 21);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(89, 33);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Visible = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.AutoSize = true;
            this.calculateButton.BackColor = System.Drawing.Color.Navy;
            this.calculateButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.calculateButton.Location = new System.Drawing.Point(10, 21);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(89, 33);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Visible = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // cashierSummaryGroupBox
            // 
            this.cashierSummaryGroupBox.AutoSize = true;
            this.cashierSummaryGroupBox.Controls.Add(this.totalCashiersCount);
            this.cashierSummaryGroupBox.Controls.Add(this.totalCashiersLabel);
            this.cashierSummaryGroupBox.Controls.Add(this.avgTransationsSummaryAmount);
            this.cashierSummaryGroupBox.Controls.Add(this.avgTransationsValueLabel);
            this.cashierSummaryGroupBox.Controls.Add(this.totalReceiptsSummaryAmount);
            this.cashierSummaryGroupBox.Controls.Add(this.totalTicketsSoldSummaryCount);
            this.cashierSummaryGroupBox.Controls.Add(this.cashierNameSummaryValue);
            this.cashierSummaryGroupBox.Controls.Add(this.totalReceiptsSummaryLabel);
            this.cashierSummaryGroupBox.Controls.Add(this.totalTicketsSoldSummaryLabel);
            this.cashierSummaryGroupBox.Controls.Add(this.cashierNameSummaryLabel);
            this.cashierSummaryGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierSummaryGroupBox.Location = new System.Drawing.Point(27, 396);
            this.cashierSummaryGroupBox.Name = "cashierSummaryGroupBox";
            this.cashierSummaryGroupBox.Size = new System.Drawing.Size(420, 193);
            this.cashierSummaryGroupBox.TabIndex = 12;
            this.cashierSummaryGroupBox.TabStop = false;
            this.cashierSummaryGroupBox.Text = "Cashier Summary Data";
            this.cashierSummaryGroupBox.Visible = false;
            // 
            // avgTransationsSummaryAmount
            // 
            this.avgTransationsSummaryAmount.AutoSize = true;
            this.avgTransationsSummaryAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.avgTransationsSummaryAmount.Location = new System.Drawing.Point(258, 152);
            this.avgTransationsSummaryAmount.Name = "avgTransationsSummaryAmount";
            this.avgTransationsSummaryAmount.Size = new System.Drawing.Size(2, 20);
            this.avgTransationsSummaryAmount.TabIndex = 7;
            this.avgTransationsSummaryAmount.Visible = false;
            // 
            // avgTransationsValueLabel
            // 
            this.avgTransationsValueLabel.AutoSize = true;
            this.avgTransationsValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgTransationsValueLabel.Location = new System.Drawing.Point(27, 152);
            this.avgTransationsValueLabel.Name = "avgTransationsValueLabel";
            this.avgTransationsValueLabel.Size = new System.Drawing.Size(198, 20);
            this.avgTransationsValueLabel.TabIndex = 6;
            this.avgTransationsValueLabel.Text = "Avg Transations Value";
            this.avgTransationsValueLabel.Visible = false;
            // 
            // totalReceiptsSummaryAmount
            // 
            this.totalReceiptsSummaryAmount.AutoSize = true;
            this.totalReceiptsSummaryAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalReceiptsSummaryAmount.Location = new System.Drawing.Point(258, 118);
            this.totalReceiptsSummaryAmount.Name = "totalReceiptsSummaryAmount";
            this.totalReceiptsSummaryAmount.Size = new System.Drawing.Size(2, 20);
            this.totalReceiptsSummaryAmount.TabIndex = 5;
            this.totalReceiptsSummaryAmount.Visible = false;
            // 
            // totalTicketsSoldSummaryCount
            // 
            this.totalTicketsSoldSummaryCount.AutoSize = true;
            this.totalTicketsSoldSummaryCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalTicketsSoldSummaryCount.Location = new System.Drawing.Point(258, 78);
            this.totalTicketsSoldSummaryCount.Name = "totalTicketsSoldSummaryCount";
            this.totalTicketsSoldSummaryCount.Size = new System.Drawing.Size(2, 20);
            this.totalTicketsSoldSummaryCount.TabIndex = 4;
            this.totalTicketsSoldSummaryCount.Visible = false;
            // 
            // cashierNameSummaryValue
            // 
            this.cashierNameSummaryValue.AutoSize = true;
            this.cashierNameSummaryValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cashierNameSummaryValue.Location = new System.Drawing.Point(258, 46);
            this.cashierNameSummaryValue.Name = "cashierNameSummaryValue";
            this.cashierNameSummaryValue.Size = new System.Drawing.Size(2, 20);
            this.cashierNameSummaryValue.TabIndex = 3;
            this.cashierNameSummaryValue.Visible = false;
            // 
            // totalReceiptsSummaryLabel
            // 
            this.totalReceiptsSummaryLabel.AutoSize = true;
            this.totalReceiptsSummaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalReceiptsSummaryLabel.Location = new System.Drawing.Point(27, 119);
            this.totalReceiptsSummaryLabel.Name = "totalReceiptsSummaryLabel";
            this.totalReceiptsSummaryLabel.Size = new System.Drawing.Size(131, 20);
            this.totalReceiptsSummaryLabel.TabIndex = 2;
            this.totalReceiptsSummaryLabel.Text = "Total Receipts";
            this.totalReceiptsSummaryLabel.Visible = false;
            // 
            // totalTicketsSoldSummaryLabel
            // 
            this.totalTicketsSoldSummaryLabel.AutoSize = true;
            this.totalTicketsSoldSummaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTicketsSoldSummaryLabel.Location = new System.Drawing.Point(27, 82);
            this.totalTicketsSoldSummaryLabel.Name = "totalTicketsSoldSummaryLabel";
            this.totalTicketsSoldSummaryLabel.Size = new System.Drawing.Size(161, 20);
            this.totalTicketsSoldSummaryLabel.TabIndex = 1;
            this.totalTicketsSoldSummaryLabel.Text = "Total Tickets Sold";
            this.totalTicketsSoldSummaryLabel.Visible = false;
            // 
            // cashierNameSummaryLabel
            // 
            this.cashierNameSummaryLabel.AutoSize = true;
            this.cashierNameSummaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierNameSummaryLabel.Location = new System.Drawing.Point(27, 46);
            this.cashierNameSummaryLabel.Name = "cashierNameSummaryLabel";
            this.cashierNameSummaryLabel.Size = new System.Drawing.Size(128, 20);
            this.cashierNameSummaryLabel.TabIndex = 0;
            this.cashierNameSummaryLabel.Text = "Cashier Name";
            this.cashierNameSummaryLabel.Visible = false;
            // 
            // totalCashiersLabel
            // 
            this.totalCashiersLabel.AutoSize = true;
            this.totalCashiersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCashiersLabel.Location = new System.Drawing.Point(27, 45);
            this.totalCashiersLabel.Name = "totalCashiersLabel";
            this.totalCashiersLabel.Size = new System.Drawing.Size(132, 20);
            this.totalCashiersLabel.TabIndex = 8;
            this.totalCashiersLabel.Text = "Total Cashiers";
            // 
            // totalCashiersCount
            // 
            this.totalCashiersCount.AutoSize = true;
            this.totalCashiersCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalCashiersCount.Location = new System.Drawing.Point(258, 46);
            this.totalCashiersCount.Name = "totalCashiersCount";
            this.totalCashiersCount.Size = new System.Drawing.Size(2, 20);
            this.totalCashiersCount.TabIndex = 9;
            // 
            // cinemaSalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 753);
            this.Controls.Add(this.cashierSummaryGroupBox);
            this.Controls.Add(this.buttonsControlPanel);
            this.Controls.Add(this.ticketCountGroupBox);
            this.Controls.Add(this.cashierNameTextBox);
            this.Controls.Add(this.cashierNameLabel);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.megaCinemaPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cinemaSalesForm";
            this.Text = "Welcome to Mega Cinema";
            ((System.ComponentModel.ISupportInitialize)(this.megaCinemaPictureBox)).EndInit();
            this.ticketCountGroupBox.ResumeLayout(false);
            this.ticketCountGroupBox.PerformLayout();
            this.buttonsControlPanel.ResumeLayout(false);
            this.buttonsControlPanel.PerformLayout();
            this.cashierSummaryGroupBox.ResumeLayout(false);
            this.cashierSummaryGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox megaCinemaPictureBox;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Label cashierNameLabel;
        private System.Windows.Forms.TextBox cashierNameTextBox;
        private System.Windows.Forms.Label adultLabel;
        private System.Windows.Forms.Label childLabel;
        private System.Windows.Forms.Label studentLabel;
        private System.Windows.Forms.TextBox adultCountTextBox;
        private System.Windows.Forms.TextBox studentCountTextBox;
        private System.Windows.Forms.TextBox childCountTextBox;
        private System.Windows.Forms.GroupBox ticketCountGroupBox;
        private System.Windows.Forms.Panel buttonsControlPanel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button summaryButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.GroupBox cashierSummaryGroupBox;
        private System.Windows.Forms.Label totalReceiptsSummaryAmount;
        private System.Windows.Forms.Label totalTicketsSoldSummaryCount;
        private System.Windows.Forms.Label cashierNameSummaryValue;
        private System.Windows.Forms.Label totalReceiptsSummaryLabel;
        private System.Windows.Forms.Label totalTicketsSoldSummaryLabel;
        private System.Windows.Forms.Label cashierNameSummaryLabel;
        private System.Windows.Forms.Label avgTransationsValueLabel;
        private System.Windows.Forms.Label avgTransationsSummaryAmount;
        private System.Windows.Forms.Label totalCashiersLabel;
        private System.Windows.Forms.Label totalCashiersCount;
    }
}

