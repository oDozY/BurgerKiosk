namespace BurgerKiosk
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblAppName = new Label();
            rdoHamBurger = new RadioButton();
            rdoBulgogiBurger = new RadioButton();
            rdoChickenBurger = new RadioButton();
            picHamBurger = new PictureBox();
            picBulgogiBurger = new PictureBox();
            picChickenBurger = new PictureBox();
            chkPotato = new CheckBox();
            chkCola = new CheckBox();
            chkCheese = new CheckBox();
            chkSauce = new CheckBox();
            lstOrder = new ListBox();
            lblTotalCost = new Label();
            btnOrder = new Button();
            btnIni = new Button();
            grpMenu = new GroupBox();
            grpOption = new GroupBox();
            grpOrder = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)picHamBurger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBulgogiBurger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picChickenBurger).BeginInit();
            grpMenu.SuspendLayout();
            grpOption.SuspendLayout();
            grpOrder.SuspendLayout();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("맑은 고딕", 60F);
            lblAppName.ForeColor = Color.RoyalBlue;
            lblAppName.Location = new Point(50, 43);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(1111, 159);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "버거 주문 키오스크";
            // 
            // rdoHamBurger
            // 
            rdoHamBurger.AutoSize = true;
            rdoHamBurger.ForeColor = Color.Black;
            rdoHamBurger.Location = new Point(30, 75);
            rdoHamBurger.Name = "rdoHamBurger";
            rdoHamBurger.Size = new Size(133, 45);
            rdoHamBurger.TabIndex = 1;
            rdoHamBurger.TabStop = true;
            rdoHamBurger.Text = "햄버거";
            rdoHamBurger.UseVisualStyleBackColor = true;
            rdoHamBurger.CheckedChanged += rdoHamburger_CheckedChanged;
            // 
            // rdoBulgogiBurger
            // 
            rdoBulgogiBurger.AutoSize = true;
            rdoBulgogiBurger.ForeColor = Color.Black;
            rdoBulgogiBurger.Location = new Point(30, 244);
            rdoBulgogiBurger.Name = "rdoBulgogiBurger";
            rdoBulgogiBurger.Size = new Size(193, 45);
            rdoBulgogiBurger.TabIndex = 2;
            rdoBulgogiBurger.TabStop = true;
            rdoBulgogiBurger.Text = "불고기버거";
            rdoBulgogiBurger.UseVisualStyleBackColor = true;
            rdoBulgogiBurger.CheckedChanged += rdoBulgogiBurger_CheckedChanged;
            // 
            // rdoChickenBurger
            // 
            rdoChickenBurger.AutoSize = true;
            rdoChickenBurger.ForeColor = Color.Black;
            rdoChickenBurger.Location = new Point(30, 425);
            rdoChickenBurger.Name = "rdoChickenBurger";
            rdoChickenBurger.Size = new Size(163, 45);
            rdoChickenBurger.TabIndex = 3;
            rdoChickenBurger.TabStop = true;
            rdoChickenBurger.Text = "치킨버거";
            rdoChickenBurger.UseVisualStyleBackColor = true;
            rdoChickenBurger.CheckedChanged += rdoChickenBurger_CheckedChanged;
            // 
            // picHamBurger
            // 
            picHamBurger.Image = (Image)resources.GetObject("picHamBurger.Image");
            picHamBurger.Location = new Point(229, 56);
            picHamBurger.Name = "picHamBurger";
            picHamBurger.Size = new Size(188, 94);
            picHamBurger.SizeMode = PictureBoxSizeMode.StretchImage;
            picHamBurger.TabIndex = 4;
            picHamBurger.TabStop = false;
            // 
            // picBulgogiBurger
            // 
            picBulgogiBurger.Image = (Image)resources.GetObject("picBulgogiBurger.Image");
            picBulgogiBurger.Location = new Point(229, 229);
            picBulgogiBurger.Name = "picBulgogiBurger";
            picBulgogiBurger.Size = new Size(188, 94);
            picBulgogiBurger.SizeMode = PictureBoxSizeMode.StretchImage;
            picBulgogiBurger.TabIndex = 5;
            picBulgogiBurger.TabStop = false;
            // 
            // picChickenBurger
            // 
            picChickenBurger.Image = (Image)resources.GetObject("picChickenBurger.Image");
            picChickenBurger.Location = new Point(229, 406);
            picChickenBurger.Name = "picChickenBurger";
            picChickenBurger.Size = new Size(188, 94);
            picChickenBurger.SizeMode = PictureBoxSizeMode.StretchImage;
            picChickenBurger.TabIndex = 6;
            picChickenBurger.TabStop = false;
            // 
            // chkPotato
            // 
            chkPotato.AutoSize = true;
            chkPotato.ForeColor = Color.Black;
            chkPotato.Location = new Point(45, 75);
            chkPotato.Name = "chkPotato";
            chkPotato.Size = new Size(164, 45);
            chkPotato.TabIndex = 7;
            chkPotato.Text = "감자튀김";
            chkPotato.UseVisualStyleBackColor = true;
            chkPotato.CheckedChanged += chkFrenchFries_CheckedChanged;
            // 
            // chkCola
            // 
            chkCola.AutoSize = true;
            chkCola.ForeColor = Color.Black;
            chkCola.Location = new Point(45, 162);
            chkCola.Name = "chkCola";
            chkCola.Size = new Size(104, 45);
            chkCola.TabIndex = 8;
            chkCola.Text = "콜라";
            chkCola.UseVisualStyleBackColor = true;
            chkCola.CheckedChanged += chkCoke_CheckedChanged;
            // 
            // chkCheese
            // 
            chkCheese.AutoSize = true;
            chkCheese.ForeColor = Color.Black;
            chkCheese.Location = new Point(45, 257);
            chkCheese.Name = "chkCheese";
            chkCheese.Size = new Size(175, 45);
            chkCheese.TabIndex = 9;
            chkCheese.Text = "치즈 추가";
            chkCheese.UseVisualStyleBackColor = true;
            chkCheese.CheckedChanged += chkAddCheese_CheckedChanged;
            // 
            // chkSauce
            // 
            chkSauce.AutoSize = true;
            chkSauce.ForeColor = Color.Black;
            chkSauce.Location = new Point(45, 347);
            chkSauce.Name = "chkSauce";
            chkSauce.Size = new Size(175, 45);
            chkSauce.TabIndex = 10;
            chkSauce.Text = "소스 추가";
            chkSauce.UseVisualStyleBackColor = true;
            chkSauce.CheckedChanged += chkAddSouce_CheckedChanged;
            // 
            // lstOrder
            // 
            lstOrder.FormattingEnabled = true;
            lstOrder.Location = new Point(48, 42);
            lstOrder.Name = "lstOrder";
            lstOrder.Size = new Size(415, 291);
            lstOrder.TabIndex = 11;
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.Font = new Font("맑은 고딕", 20F);
            lblTotalCost.ForeColor = Color.DodgerBlue;
            lblTotalCost.Location = new Point(48, 385);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(194, 54);
            lblTotalCost.TabIndex = 12;
            lblTotalCost.Text = "총 금액 : ";
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.GreenYellow;
            btnOrder.Font = new Font("맑은 고딕", 15F);
            btnOrder.ForeColor = Color.Transparent;
            btnOrder.Location = new Point(799, 730);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(200, 70);
            btnOrder.TabIndex = 13;
            btnOrder.Text = "주문하기";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnIni
            // 
            btnIni.BackColor = Color.IndianRed;
            btnIni.Font = new Font("맑은 고딕", 15F);
            btnIni.ForeColor = Color.Transparent;
            btnIni.Location = new Point(1122, 730);
            btnIni.Name = "btnIni";
            btnIni.Size = new Size(200, 70);
            btnIni.TabIndex = 14;
            btnIni.Text = "초기화";
            btnIni.UseVisualStyleBackColor = false;
            btnIni.Click += btnIni_Click;
            // 
            // grpMenu
            // 
            grpMenu.Controls.Add(picChickenBurger);
            grpMenu.Controls.Add(picBulgogiBurger);
            grpMenu.Controls.Add(picHamBurger);
            grpMenu.Controls.Add(rdoChickenBurger);
            grpMenu.Controls.Add(rdoBulgogiBurger);
            grpMenu.Controls.Add(rdoHamBurger);
            grpMenu.Font = new Font("맑은 고딕", 15F);
            grpMenu.ForeColor = Color.IndianRed;
            grpMenu.Location = new Point(32, 269);
            grpMenu.Name = "grpMenu";
            grpMenu.Size = new Size(436, 533);
            grpMenu.TabIndex = 15;
            grpMenu.TabStop = false;
            grpMenu.Text = "메뉴 선택";
            grpMenu.Enter += grpSelectMenu_Enter;
            // 
            // grpOption
            // 
            grpOption.Controls.Add(chkSauce);
            grpOption.Controls.Add(chkCheese);
            grpOption.Controls.Add(chkCola);
            grpOption.Controls.Add(chkPotato);
            grpOption.Font = new Font("맑은 고딕", 15F);
            grpOption.ForeColor = Color.IndianRed;
            grpOption.Location = new Point(508, 269);
            grpOption.Name = "grpOption";
            grpOption.Size = new Size(253, 423);
            grpOption.TabIndex = 16;
            grpOption.TabStop = false;
            grpOption.Text = "메뉴 추가";
            // 
            // grpOrder
            // 
            grpOrder.Controls.Add(lblTotalCost);
            grpOrder.Controls.Add(lstOrder);
            grpOrder.Font = new Font("맑은 고딕", 15F);
            grpOrder.ForeColor = Color.IndianRed;
            grpOrder.Location = new Point(799, 269);
            grpOrder.Name = "grpOrder";
            grpOrder.Size = new Size(523, 457);
            grpOrder.TabIndex = 17;
            grpOrder.TabStop = false;
            grpOrder.Text = "주문 내역";
            grpOrder.Enter += grpOrder_Enter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1347, 863);
            Controls.Add(grpOrder);
            Controls.Add(grpOption);
            Controls.Add(grpMenu);
            Controls.Add(btnIni);
            Controls.Add(btnOrder);
            Controls.Add(lblAppName);
            ForeColor = Color.IndianRed;
            Name = "Form1";
            Text = "Burger Kiosk v.10";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picHamBurger).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBulgogiBurger).EndInit();
            ((System.ComponentModel.ISupportInitialize)picChickenBurger).EndInit();
            grpMenu.ResumeLayout(false);
            grpMenu.PerformLayout();
            grpOption.ResumeLayout(false);
            grpOption.PerformLayout();
            grpOrder.ResumeLayout(false);
            grpOrder.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        private RadioButton rdoHamBurger;
        private RadioButton rdoBulgogiBurger;
        private RadioButton rdoChickenBurger;
        private PictureBox picHamBurger;
        private PictureBox picBulgogiBurger;
        private PictureBox picChickenBurger;
        private CheckBox chkPotato;
        private CheckBox chkCola;
        private CheckBox chkCheese;
        private CheckBox chkSauce;
        private ListBox lstOrder;
        private Label lblTotalCost;
        private Button btnOrder;
        private Button btnIni;
        private GroupBox grpMenu;
        private GroupBox grpOption;
        private GroupBox grpOrder;
    }
}
