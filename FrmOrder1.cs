using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pizza_Project
{
    public partial class FrmOrder1 : Form
    {
        public FrmOrder1()
        {
            InitializeComponent();
        }
        void UpdateOrderSummary()
        {
            UpdateSize();
            UpdateToppings();
            UpdateCrust();
            UpdateWhereToEat();
            UpdateTotalPrice();

        }
        float GetSelectedSizePrice()
        {

            if (rbSmall.Checked)
                return Convert.ToSingle(rbSmall.Tag);
            if (rbLarge.Checked)
                return Convert.ToSingle(rbLarge.Tag);

            return Convert.ToSingle( rbMedium.Tag ) ;
        }
        float CalculateToppingsPrice()
        {
            float price = 0;
            if (chkExtraChees.Checked)
                price += Convert.ToSingle(chkExtraChees.Tag  ) ;
            if (chkGreenPeppers.Checked)
                price += Convert.ToSingle(chkGreenPeppers.Tag);
            if (chkOnion.Checked)
                price += Convert.ToSingle(chkOnion.Tag);
            if (chkOlives.Checked)
                price += Convert.ToSingle(chkOlives.Tag);
            if (chkMashrooms.Checked)
                price += Convert.ToSingle(chkMashrooms.Tag);
            if (chkTomatoes.Checked)
                price += Convert.ToSingle(chkTomatoes.Tag);
            return price;
        }
        float GetSelectedCrustTypePrice()
        {

            if (rbThin.Checked)
                return Convert.ToSingle(rbThin.Tag);
            else 
                return Convert.ToSingle(rbThick.Tag);
        }
        float CalculateTotalPrice()
        {
            return GetSelectedSizePrice() + CalculateToppingsPrice() + GetSelectedCrustTypePrice();
        }
        void UpdateTotalPrice()
        {

            lblTotalPrice.Text = "$ " + CalculateTotalPrice();



        }
        void UpdateSize()
        {
            UpdateTotalPrice();
            if (rbSmall.Checked)
                lblSize.Text = "Small";
            if (rbLarge.Checked)
                lblSize.Text = "Large";
            if (rbMedium.Checked)
                lblSize.Text = "Medium";
        }
        void UpdateCrust()
        {
            UpdateTotalPrice();
            if (rbThin.Checked)
                lblCrust.Text = "Thin";
            
            else
                lblCrust.Text = "Thick";
        }

        void UpdateToppings()
        {
            UpdateTotalPrice();

            string sToppings = "";
            if (chkExtraChees.Checked)
                sToppings = "Extra Chees";
            if (chkGreenPeppers.Checked)
                sToppings += ", Green Peppars";
            if (chkMashrooms.Checked)
                sToppings += ", Mushrooms";
            if (chkOlives.Checked)
                sToppings += ", Olives";
            if (chkTomatoes.Checked)
                sToppings += ", Tomatoes";
            if (chkOnion.Checked)
                sToppings += ", Onion";

            if (sToppings.StartsWith(","))
            {
                sToppings = sToppings.Substring(1, sToppings.Length - 1).Trim();
            }

            if (sToppings == "")
                sToppings = "No Toppings";

            lblToppings.Text = sToppings;


        }
        void UpdateWhereToEat()
        {
            UpdateTotalPrice();

            if (rbEatIn.Checked)
            {
                lblWhereToEat.Text = "Eat In.";
                return;
            }

            if (rbTakeOut.Checked)
            {
                lblWhereToEat.Text = "Take Out.";
                return;
            }

        }

        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            rbSmall.Checked = true;
        }

       

        

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
            if (rbTakeOut.Checked)
            {
                pictureBox7.BorderStyle = BorderStyle.Fixed3D;
                pictureBox7.BackColor = Color.CornflowerBlue;

            }
            else pictureBox7.BackColor = Color.Transparent;
        }

        

        private void pictureMediumPizza_Click(object sender, EventArgs e)
        {
            rbMedium.Checked= true;
            
        }

        private void pictureLargePizza_Click(object sender, EventArgs e)
        {
            rbLarge.Checked= true;
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
           UpdateSize();
            if (rbSmall.Checked)
            {
                pictureSmallPizza.BorderStyle = BorderStyle.Fixed3D;
                pictureSmallPizza.BackColor = Color.CornflowerBlue;

            }
            else pictureSmallPizza.BackColor = Color.Transparent;
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
            if (rbMedium.Checked)
            {
                pictureMediumPizza.BorderStyle = BorderStyle.Fixed3D;
                pictureMediumPizza.BackColor = Color.CornflowerBlue;

            }
            else pictureMediumPizza.BackColor = Color.Transparent;

        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
            if (rbLarge.Checked)
            {
                pictureLargePizza.BorderStyle = BorderStyle.Fixed3D;
                pictureLargePizza.BackColor = Color.CornflowerBlue;

            }
            else pictureLargePizza.BackColor = Color.Transparent;

        }

        private void pictureThinPizza_Click(object sender, EventArgs e)
        {
            rbThin.Checked= true;
        }

        private void pictureThickPizza_Click(object sender, EventArgs e)
        {
            rbThick.Checked= true;  
        }

        private void rbThin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
            if (rbThin.Checked)
            {
                pictureThinPizza.BorderStyle = BorderStyle.Fixed3D;
                pictureThinPizza.BackColor = Color.CornflowerBlue;

            }
            else pictureThinPizza.BackColor = Color.Transparent;
        }

        private void rbThick_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
            if (rbThick.Checked)
            {
                pictureThickPizza.BorderStyle = BorderStyle.Fixed3D;
                pictureThickPizza.BackColor = Color.CornflowerBlue;

            }
            else pictureThickPizza.BackColor = Color.Transparent;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            chkExtraChees.Checked = !chkExtraChees.Checked;
           
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            chkMashrooms.Checked=!chkMashrooms.Checked;
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            chkTomatoes.Checked= !chkTomatoes.Checked;
           
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            chkGreenPeppers.Checked=!chkGreenPeppers.Checked;
           
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            chkOnion.Checked= !chkOnion.Checked;
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            chkOlives.Checked = !chkOlives.Checked;
            
        }

        private void chkExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
            if (chkExtraChees.Checked)
            {
                pictureBox2.BorderStyle = BorderStyle.Fixed3D;
                pictureBox2.BackColor = Color.CornflowerBlue;

            }
            else pictureBox2.BackColor = Color.Transparent;
        }

        private void chkMashrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
            if (chkMashrooms.Checked)
            {
                pictureBox1.BorderStyle = BorderStyle.Fixed3D;
                pictureBox1.BackColor = Color.CornflowerBlue;

            }
            else pictureBox1.BackColor = Color.Transparent;

        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
            if (chkTomatoes.Checked)
            {
                pictureBox3.BorderStyle = BorderStyle.Fixed3D;
                pictureBox3.BackColor = Color.CornflowerBlue;

            }
            else pictureBox3.BackColor = Color.Transparent;

        }

        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
            if (chkGreenPeppers.Checked)
            {
                pictureBox6.BorderStyle = BorderStyle.Fixed3D;
                pictureBox6.BackColor = Color.CornflowerBlue;

            }
            else pictureBox6.BackColor = Color.Transparent;

        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
            if (chkOnion.Checked)
            {
                pictureBox5.BorderStyle = BorderStyle.Fixed3D;
                pictureBox5.BackColor = Color.CornflowerBlue;

            }
            else pictureBox5.BackColor = Color.Transparent;

        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
            if (chkOlives.Checked)
            {
                pictureBox4.BorderStyle = BorderStyle.Fixed3D;
                pictureBox4.BackColor = Color.CornflowerBlue;

            }
            else pictureBox4.BackColor = Color.Transparent;

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            rbEatIn.Checked= true;
            
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            rbTakeOut.Checked= true;
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
            if (rbEatIn.Checked)
            {
                pictureBox8.BorderStyle = BorderStyle.Fixed3D;
                pictureBox8.BackColor = Color.CornflowerBlue;

            }
            else pictureBox8.BackColor = Color.Transparent;
        }

        private void FrmOrder1_Load(object sender, EventArgs e)
        {
            UpdateOrderSummary();

        }

        private void gbWhereToEat_Enter(object sender, EventArgs e)
        {

        }

        private void gbToppings_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure ? ", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {


                MessageBox.Show("Thanks for Visting !❤️👌", "Order Done Succefully "
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);

                gbCrust.Enabled = false;
                gbSize.Enabled = false;
                gbToppings.Enabled = false;
                gbWhereToEat.Enabled = false;
                btnOrder.Enabled = false;


            }
            else

                MessageBox.Show("Update your order", "Update",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        

        private void btnRest_Click_1(object sender, EventArgs e)
        {
            //reset Groups
            gbSize.Enabled = true;
            gbToppings.Enabled = true;
            gbCrust.Enabled = true;
            gbWhereToEat.Enabled = true;

            //reset Size
            rbMedium.Checked = true;

            //reset Toppings.
            chkExtraChees.Checked = false;
            chkOnion.Checked = false;
            chkMashrooms.Checked = false;
            chkOlives.Checked = false;
            chkTomatoes.Checked = false;
            chkGreenPeppers.Checked = false;

            //reset CrustType
            rbThin.Checked = true;

            //reset Where to Eat
            rbEatIn.Checked = true;

            //Reset Order Button
            btnOrder.Enabled = true;
        }
    }
}
