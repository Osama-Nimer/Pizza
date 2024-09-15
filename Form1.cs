using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void UpdateSize()
        {

            UpdateTotalPrice();

            if (rdbSmall.Checked)
            {
                lbSize.Text = "Small";
                return;
            }

            if (rdbMeduim.Checked)
            {
                lbSize.Text = "Medium";
                return;
            }

            if (rdbLarg.Checked)
            {
                lbSize.Text = "Large";
                return;
            }

        }

        void UpdateToppings()
        {

            UpdateTotalPrice();

            string sToppings = "";

            if (chkExtra.Checked)
            {
                sToppings = "Extra Chees";
            }


            if (chkOnion.Checked)
            {
                sToppings += ", Onion";
            }

            if (chkMushrooms.Checked)
            {
                sToppings += ", Mushrooms";
            }

            if (chkOlives.Checked)
            {
                sToppings += ", Olives";
            }

            if (chkTomatoes.Checked)
            {
                sToppings += ", Tomatos";
            }

            if (chkGreen.Checked)
            {
                sToppings += ", Green Peppars";
            }

            if (sToppings.StartsWith(","))
            {
                sToppings = sToppings.Substring(1, sToppings.Length - 1).Trim();
            }

            if (sToppings == "")
                sToppings = "No Toppings";

            lbToppings.Text = sToppings;


        }

        void UpdateCrust()
        {
            UpdateTotalPrice();
            if (rdbThin.Checked)
            {
                lbCrust.Text = "Think Crust";
                return;
            }

            if (rdbThink.Checked)
            {
                lbCrust.Text = "Thick Crust";
                return;
            }


        }

        void UpdateWhereToEat()
        {
            UpdateTotalPrice();

            if (rdbIn.Checked)
            {
                lbEat.Text = "Eat In.";
                return;
            }

            if (rdbOut.Checked)
            {
                lbEat.Text = "Take Out.";
                return;
            }

        }

        float GetSelectedSizePrice()
        {
            if (rdbSmall.Checked)

                return Convert.ToSingle(rdbSmall.Tag);

            else if (rdbMeduim.Checked)
                return Convert.ToSingle(rdbMeduim.Tag);

            else
                return Convert.ToSingle(rdbLarg.Tag);

        }

        float CalculateToppingsPrice()
        {


            float ToppingsTotalPrice = 0;

            if (chkExtra.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkExtra.Tag);
            }


            if (chkOnion.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkOnion.Tag);
            }

            if (chkMushrooms.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkMushrooms.Tag);
            }

            if (chkOlives.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkOlives.Tag);
            }

            if (chkTomatoes.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkTomatoes .Tag);
            }

            if (chkGreen.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkTomatoes.Tag);
            }



            return ToppingsTotalPrice;



        }

        float GetSelectedCrutPrice()
        {
            if (rdbThin.Checked)

                return Convert.ToSingle(rdbThin.Tag);

            else
                return Convert.ToSingle(rdbThink.Tag);

        }

        float CalculateTotalPrice()
        {
            return GetSelectedSizePrice() + CalculateToppingsPrice() + GetSelectedCrutPrice();
        }

        void UpdateTotalPrice()
        {

            lbPrice.Text = "$" + CalculateTotalPrice().ToString();

        }

        void UpdateOrderSummary()
        {
            UpdateSize();
            UpdateToppings();
            UpdateCrust();
            UpdateWhereToEat();
            UpdateTotalPrice();

        }

        void ResetForm()
        {

            //reset Groups
            bgSize.Enabled = true;
            bgToppings.Enabled = true;
            bgCrust.Enabled = true;
            bgEat.Enabled = true;

            //reset Size
            rdbMeduim.Checked = true;

            //reset Toppings.
            chkExtra.Checked = false;
            chkOnion.Checked = false;
            chkMushrooms.Checked = false;
            chkOlives.Checked = false;
            chkTomatoes.Checked = false;
            chkGreen.Checked = false;

            //reset CrustType
            rdbThin.Checked = true;

            //reset Where to Eat
            rdbIn.Checked = true;

            //Reset Order Button
            btnOrder.Enabled = true;

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Confirm Order", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                btnOrder.Enabled = false;
                bgCrust.Enabled = false;
                bgEat.Enabled = false;
                bgSize.Enabled = false;
                bgToppings.Enabled = false;
            }
            else

                MessageBox.Show("Update your order", "Update",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void btnRest_Click(object sender, EventArgs e)
        {
           ResetForm(); 
        }

        private void rdbSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rdbMeduim_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rdbLarg_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void chkExtra_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkGreen_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void rdbThin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rdbThink_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rdbIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rdbOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateOrderSummary();
        }
    }
    }

