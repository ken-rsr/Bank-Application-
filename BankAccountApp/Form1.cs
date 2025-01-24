namespace BankAccountApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            BankAccount bankAccount = new BankAccount();
            bankAccount.Owner = "Saldina Nurak";
            bankAccount.AccountNumber = Guid.NewGuid();
            bankAccount.Balance = 250;

            BankAccount bankAccount2 = new BankAccount();
            bankAccount2.Owner = "Elon Musk";
            bankAccount2.AccountNumber = Guid.NewGuid();
            bankAccount2.Balance = 500;

            BankAccount bankAccount3 = new BankAccount();
            bankAccount3.Owner = "Bill Gates";
            bankAccount3.AccountNumber = Guid.NewGuid();
            bankAccount3.Balance = 800;

            List<BankAccount> bankAccounts = new List<BankAccount>();
            bankAccounts.Add(bankAccount);
            bankAccounts.Add(bankAccount2);
            bankAccounts.Add(bankAccount3);

            BankAccountsGrid.DataSource = bankAccounts;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OwnerTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
