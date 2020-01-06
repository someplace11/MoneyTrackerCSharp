using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace MoneyTracker
{
    public partial class MoneyTracker : Form
    {
        public MoneyTracker()
        {
            InitializeComponent();
        }

        int numOfTrans = 0;
        string transName;

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:/E-Documents/C#/MyMoney/Money.accdb");

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            //double amount;
            //bool tryAmount = double.TryParse(inputAmount.Text, out amount);
            //int card;
            //bool tryCard = int.TryParse(inputCard.SelectedItem.ToString(), out card);

            TransName(numOfTrans);
            Transaction transName = new Transaction(inputDate.Value, inputCard.SelectedItem.ToString(), inputAmount.Text, inputTransNote.Text);

            try
            {
                OleDbCommand cmd = con.CreateCommand();

                con.Open();

                //cmd.CommandText = "INSERT INTO T_Transaction( TransactionDate, Amount, Card, TransactionNote ) VALUES('" + inputDate.Value + "','" + amount + "','" + card + "','" + inputTransNote.Text + "')";
                cmd.CommandText = "INSERT INTO T_Transaction( TransactionDate, Amount, Card, TransactionNote ) VALUES('" + transName.Date + "','" + transName.Amount + "','" + transName.Card + "','" + transName.Note + "')";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();

                string tranNum = numOfTrans.ToString();
                MessageBox.Show("Successfully Submitted");

                con.Close();
            }
            catch (Exception newEx)
            {
                MessageBox.Show(newEx.Message);
            }

            inputCard.SelectedIndex = -1;
            inputAmount.Text = "";
            inputTransNote.Text = "";

            //Transaction One = new Transaction(inputDate, inputCard.SelectedItem.ToString(), inputAmount.Text, inputTransNote.Text);
            //MessageBox.Show(One.Card.ToString(), One.Amount.ToString());
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            lbDisplay.Items.Clear();

            OleDbCommand cmd = con.CreateCommand();
            string query = "SELECT TransactionDate, Amount, Card, TransactionNote FROM T_Transaction";
            cmd.CommandText = query;
            OleDbDataReader reader;

            try
            {
                con.Open();

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string amt = string.Format("{0:C}", reader.GetValue(1));
                    string date = string.Format("{0:dd/mm/yyyy}", reader.GetValue(0));
                    lbDisplay.Items.Add(date + "      " + amt + "      " + reader.GetValue(2) + "      " + reader.GetValue(3));
                }

                reader.Close();
                con.Close();
            }
            catch(Exception newEx)
            {
                MessageBox.Show(newEx.Message);
            }
        }

        private void TransName(int numTrans)
        {
            transName = numOfTrans.ToString();
            numOfTrans++;
        }
    }
}
