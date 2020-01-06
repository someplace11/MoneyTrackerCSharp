using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyTracker
{
    public class Transaction
    {
        private object date;
        private int card;
        private double amount;
        private string note;

        public Transaction(object date, string card, string amount, string note)
        {
            Date = date;
            Card = ConvertCard(card);
            Amount = ConvertAmount(amount);
            Note = note;
        }

        public object Date
        {
            get { return date; }
            set
            {
                date = value;
            }
        }

        public int Card
        {
            get { return card; }
            set
            {
                card = ConvertCard(value.ToString());
            }
        }

        public double Amount
        {
            get { return amount; }
            set
            {
                amount = ConvertAmount(value.ToString());
            }
        }

        public string Note
        {
            get { return note; }
            set
            {
                note = value;
            }
        }

        public static int ConvertCard(string cardInput)
        {
            int convertedCard;
            bool tryCard = int.TryParse(cardInput, out convertedCard);

            if (!tryCard)
            {
                MessageBox.Show("Invalid card");
            }

            return convertedCard;
        }

        public static double ConvertAmount(string amountInput)
        {
            double convertedAmount;
            bool tryConvertedAmount = double.TryParse(amountInput, out convertedAmount);

            if (!tryConvertedAmount)
            {
                MessageBox.Show("Invalid amount");
            }

            return convertedAmount;

        }
    }
}
