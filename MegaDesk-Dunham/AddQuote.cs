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
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
            assignMaterials(comboBox1);
        }

        public void assignMaterials(ComboBox comboBox)
        {
            comboBox.Items.AddRange(Enum.GetNames(typeof(DesktopMaterialType)));
            comboBox.SelectedIndex = 0;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MainMenu mainMenuForm = (MainMenu)Tag;
            mainMenuForm.Show();
            this.Close();
        }

        private void widthInput_Validating(object sender, CancelEventArgs e)
        {
            TextBox widthInput = (TextBox)sender;
            try
            {
                decimal value = Convert.ToUInt16(widthInput.Text);
                if (value < Desk.MINWIDTH)
                {
                    e.Cancel = true;
                    MessageBox.Show("Desk width cannot have a value less than 24.");
                }
                else if (value > Desk.MAXWIDTH)
                {
                    e.Cancel = true;
                    MessageBox.Show("Desk width cannot have a value greater than 96.");
                }
                else
                {
                    e.Cancel = false;
                }
            }
            catch
            {
                e.Cancel = true;
                MessageBox.Show("Desk width must be a valid non-negative integer.");
            }

        }

        private void depthInput_Validating(object sender, CancelEventArgs e)
        {
            TextBox depthInput = (TextBox)sender;
            try
            {
                decimal value = Convert.ToUInt16(depthInput.Text);
                if (value < Desk.MINDEPTH)
                {
                    e.Cancel = true;
                    MessageBox.Show("Desk depth cannot have a value less than 12.");
                }
                else if (value > Desk.MAXDEPTH)
                {
                    e.Cancel = true;
                    MessageBox.Show("Desk depth cannot have a value greater than 48.");
                }
                else
                {
                    e.Cancel = false;
                }
            }
            catch
            {
                e.Cancel = true;
                MessageBox.Show("Desk depth must be a valid non-negative integer.");
            }

        }

        private void drawersInput_Validating(object sender, CancelEventArgs e)
        {
            NumericUpDown drawersInput = (NumericUpDown)sender;
            decimal value = drawersInput.Value;
            if (value < 0)
            {
                e.Cancel = true;
                MessageBox.Show("Desk drawers cannot have a value less than 0.");
            }
            else if (value > 7)
            {
                e.Cancel = true;
                MessageBox.Show("Desk drawers cannot have a value greater than 7.");
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void getQuoteBtn_Click(object sender, EventArgs e)
        {
            DeskQuote quote = new DeskQuote(0, 0, "laminate");

            DisplayQuote displayQuoteForm = new DisplayQuote(quote);
            displayQuoteForm.Tag = this;
            displayQuoteForm.Show(this);

            this.Hide();
        }

        private void customerNameInput_Validating(object sender, CancelEventArgs e)
        {
            TextBox nameInput = (TextBox)sender;
            string value = nameInput.Text.Trim();
            if (value.Length < 2)
            {
                e.Cancel = true;
                MessageBox.Show("Name field must be populated.");
            }
        }
    }
}
