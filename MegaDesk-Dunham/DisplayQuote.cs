using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Dunham
{
    public partial class DisplayQuote : Form
    {
        public DisplayQuote(DeskQuote quoteInfo)
        {
            InitializeComponent();
            deskQuoteBox.Text = quoteInfo.produceQuote();
        }
        private void backBtn_Click(object sender, EventArgs e)
        {

            AddQuote addQuoteForm = (AddQuote)Tag;
            addQuoteForm.Show();
            this.Close();
        }
    }
}
