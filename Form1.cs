namespace CS311_Project3_ZTS
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            Summarize();
        }

        public void Summarize()
        {

            rtfSummary.Clear();
            float subTotal = 0;
            String PSize = cboSize.GetItemText(cboSize.SelectedItem);
            if (PSize == cboSize.GetItemText("Small"))
            {
                subTotal = subTotal + 2;
            }
            else if (PSize == cboSize.GetItemText("Medium"))
            {
                subTotal = subTotal + 5;
            }
            else if (PSize == cboSize.GetItemText("Large"))
            {
                subTotal = subTotal + 10;
            }
            else if (PSize == cboSize.GetItemText("X-Large"))
            {
                subTotal = subTotal + 15;
            }
            else if (PSize == cboSize.GetItemText("Ginormous"))
            {
                subTotal = subTotal + 20;
            }

            String PCrustStyle = " ";

            if (rdoThin.Checked)
            {
                PCrustStyle = "Thin";

            }
            else if (rdoThick.Checked)
            {
                PCrustStyle = "Thick";
            }
            else if (rdoRegular.Checked)
            {
                PCrustStyle = "Regular";
            }
            rtfSummary.SelectedText = $"You Ordered a " + PSize + " pizza with " + PCrustStyle + " crust and the following toppings:" + "\n";
            rtfSummary.SelectionBullet = true;
            if (ckbPep.Checked)
            {
                rtfSummary.SelectedText = "Pepperoni\n";
                subTotal = subTotal + 2;
            }
            if (ckbSIS.Checked)
            { 
                rtfSummary.SelectedText = "Spicy Italian Sausage\n";
                subTotal = subTotal + 2;
            }
            if (ckbJalepeno.Checked)
            {
                rtfSummary.SelectedText = "Jalepeno\n";
                subTotal = subTotal + 1;
            }
            if (ckbSausage.Checked)
            {
                rtfSummary.SelectedText = "Sausage\n";
                subTotal = subTotal + 2;
            }
            if (ckbGreenP.Checked)
            {
                rtfSummary.SelectedText = "Green Pepper\n";
                subTotal = subTotal + 1;
            }
            if (ckbBananaP.Checked)
            {
                rtfSummary.SelectedText = "Banana Pepper\n";
                subTotal = subTotal + 1;
            }
            if (ckbOnion.Checked)
            {
                rtfSummary.SelectedText = "Onion\n";
                subTotal = subTotal + 1;
            }
            if (ckbGreenO.Checked)
            {
                rtfSummary.SelectedText = "Green Olives\n";
                subTotal = subTotal + 1;
            }
            if (ckbExCheese.Checked)
            {
                rtfSummary.SelectedText = "Extra Cheese\n";
                subTotal = subTotal + 1;
            }
            if (ckbCanBacon.Checked)
            {
                rtfSummary.SelectedText = "Canadian Bacon\n";
                subTotal = subTotal + 2;
            }
            if (ckbBlackO.Checked)
            {
                rtfSummary.SelectedText = "Black Olives\n";
                subTotal = subTotal + 1;
            }
            if (ckbMushroom.Checked)
            {
                rtfSummary.SelectedText = "Mushroom\n";
                subTotal = subTotal + 1;
            }
                rtfSummary.SelectionBullet = false;

            txtSubT.Text = subTotal.ToString("C");
            float tax = (float)(subTotal * .06);
            txtTax.Text = tax.ToString("C");
            float total = subTotal + tax;
            txtTotal.Text = total.ToString("C");
            
        }
    }
}