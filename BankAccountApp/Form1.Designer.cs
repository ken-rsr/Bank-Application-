namespace BankAccountApp
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
            label1 = new Label();
            label2 = new Label();
            OwnerTxt = new TextBox();
            AmountNum = new NumericUpDown();
            BankAccountsGrid = new DataGridView();
            DepositBtn = new Button();
            WithdrawBtn = new Button();
            CreateAccountBtn = new Button();
            AmountTxt = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)AmountNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BankAccountsGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AmountTxt).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 54);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(101, 37);
            label1.TabIndex = 0;
            label1.Text = "Owner:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 410);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(118, 37);
            label2.TabIndex = 1;
            label2.Text = "Amount:";
            // 
            // OwnerTxt
            // 
            OwnerTxt.Location = new Point(195, 54);
            OwnerTxt.Name = "OwnerTxt";
            OwnerTxt.Size = new Size(231, 43);
            OwnerTxt.TabIndex = 2;
            OwnerTxt.TextChanged += OwnerTxt_TextChanged;
            // 
            // AmountNum
            // 
            AmountNum.Location = new Point(363, 683);
            AmountNum.Margin = new Padding(5);
            AmountNum.Name = "AmountNum";
            AmountNum.Size = new Size(430, 43);
            AmountNum.TabIndex = 4;
            // 
            // BankAccountsGrid
            // 
            BankAccountsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BankAccountsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BankAccountsGrid.Location = new Point(481, 54);
            BankAccountsGrid.Name = "BankAccountsGrid";
            BankAccountsGrid.RowHeadersWidth = 51;
            BankAccountsGrid.Size = new Size(555, 341);
            BankAccountsGrid.TabIndex = 5;
            BankAccountsGrid.CellContentClick += dataGridView1_CellContentClick;
            // 
            // DepositBtn
            // 
            DepositBtn.Location = new Point(481, 419);
            DepositBtn.Name = "DepositBtn";
            DepositBtn.Size = new Size(266, 51);
            DepositBtn.TabIndex = 6;
            DepositBtn.Text = "Deposit";
            DepositBtn.UseVisualStyleBackColor = true;
            // 
            // WithdrawBtn
            // 
            WithdrawBtn.Location = new Point(770, 419);
            WithdrawBtn.Name = "WithdrawBtn";
            WithdrawBtn.Size = new Size(266, 51);
            WithdrawBtn.TabIndex = 7;
            WithdrawBtn.Text = "Withdraw";
            WithdrawBtn.UseVisualStyleBackColor = true;
            // 
            // CreateAccountBtn
            // 
            CreateAccountBtn.Location = new Point(195, 120);
            CreateAccountBtn.Name = "CreateAccountBtn";
            CreateAccountBtn.Size = new Size(231, 51);
            CreateAccountBtn.TabIndex = 8;
            CreateAccountBtn.Text = "Create Account";
            CreateAccountBtn.UseVisualStyleBackColor = true;
            CreateAccountBtn.Click += CreateAccountBtn_Click;
            // 
            // AmountTxt
            // 
            AmountTxt.Location = new Point(195, 404);
            AmountTxt.Name = "AmountTxt";
            AmountTxt.Size = new Size(231, 43);
            AmountTxt.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1157, 509);
            Controls.Add(AmountTxt);
            Controls.Add(CreateAccountBtn);
            Controls.Add(WithdrawBtn);
            Controls.Add(DepositBtn);
            Controls.Add(BankAccountsGrid);
            Controls.Add(AmountNum);
            Controls.Add(OwnerTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 16F);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)AmountNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)BankAccountsGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)AmountTxt).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox OwnerTxt;
        private NumericUpDown AmountNum;
        private DataGridView BankAccountsGrid;
        private Button DepositBtn;
        private Button WithdrawBtn;
        private Button CreateAccountBtn;
        private NumericUpDown AmountTxt;
    }
}
