namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        int totalCost = 0;
        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = null;
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

        private void grpOrder_Enter(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (!rdoHamBurger.Checked && !rdoBulgogiBurger.Checked && !rdoChickenBurger.Checked)
            {
                lblTotalCost.Text = "메뉴를 선택하세요.";
                return;
            }

            UpdateOrder();
        }

        private void btnIni_Click(object sender, EventArgs e)
        {
            rdoHamBurger.Checked = false;
            rdoBulgogiBurger.Checked = false;
            rdoChickenBurger.Checked = false;
            chkPotato.Checked = false;
            chkCola.Checked = false;
            chkCheese.Checked = false;
            chkSauce.Checked = false;
            lstOrder.Items.Clear();
            lblTotalCost.Text = "총 금액 : 0원";
            totalCost = 0;
            rdoHamBurger.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void UpdateOrder()
        {
            totalCost = 0;
            lstOrder.Items.Clear();

            if (rdoHamBurger.Checked)
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
    }
}
