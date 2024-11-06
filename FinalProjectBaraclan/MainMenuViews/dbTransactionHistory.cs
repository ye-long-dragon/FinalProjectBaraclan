using FinalProjectBaraclan.Models;
using FinalProjectBaraclan.Repository;
using FinalProjectBaraclan.Ucrls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectBaraclan
{
    public partial class dbTransactionHistory : Form
    {
        public UserAccount Account = new UserAccount();

        public dbTransactionHistory( UserAccount user)
        {
            InitializeComponent();
            Account = user;
            lblInputName.Text = Account.username;
            lblInputUserId.Text = Account.finalId;
            LoadUCRLS();
        }


        //load all ucrls

        public void LoadUCRLS()
        {
            var repo = new ReceiptRepository();
            List<Receipt> list = repo.RetrieveReceipts(Account);

            foreach (Receipt receipt in list)
            {
                ucrlTransaction ucrlTransaction = new ucrlTransaction(receipt);
                flpReceiptList.Controls.Add(ucrlTransaction);

            }
        }


        

    }
}
