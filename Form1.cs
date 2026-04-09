namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        int totalCost = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void grpSelectMenu_Enter(object sender, EventArgs e)
        {

        }

        private void rdoHamburger_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrder();
        }

        private void rdoBulgogiBurger_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrder();
        }

        private void rdoChickenBurger_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrder();
        }

        private void UpdateOrder()
        {
            totalCost = 0;
            lstOrder.Items.Clear();

            if (rdoHamburger.Checked)
            {
                totalCost += 5000;
                lstOrder.Items.Add("햄버거 5,000원");
            }
            else if (rdoBulgogiBurger.Checked)
            {
                totalCost += 4000;
                lstOrder.Items.Add("불고기버거 4,000원");
            }
            else if (rdoChickenBurger.Checked)
            {
                totalCost += 3000;
                lstOrder.Items.Add("치킨버거 3,000원");
            }

            if (chkPotato.Checked)
            {
                totalCost += 3500;
                lstOrder.Items.Add("감자튀김 3,500원");
            }
            if (chkCola.Checked)
            {
                totalCost += 2500;
                lstOrder.Items.Add("콜라 2,500원");
            }
            if (chkCheese.Checked)
            {
                totalCost += 1500;
                lstOrder.Items.Add("치즈 추가 1,500원");
            }
            if (chkSauce.Checked)
            {
                totalCost += 500;
                lstOrder.Items.Add("소스 추가 500원");
            }

            lblTotalCost.Text = "총 금액 : " + totalCost.ToString("#,##0") + "원";
        }

        private void chkFrenchFries_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrder();
        }

        private void chkCoke_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrder();
        }

        private void chkAddCheese_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrder();
        }

        private void chkAddSouce_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrder();
        }
    }
}
