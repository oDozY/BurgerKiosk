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
            lblTitle = new Label();
            rdoHamburger = new RadioButton();
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
            btnReset = new Button();
            grpSelect = new GroupBox();
            grpAdd = new GroupBox();
            grpOrderList = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)picHamBurger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBulgogiBurger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picChickenBurger).BeginInit();
            grpSelect.SuspendLayout();
            grpAdd.SuspendLayout();
            grpOrderList.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("맑은 고딕", 40F);
            lblTitle.Location = new Point(50, 43);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(741, 106);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "버거 키오스크 주문";
            // 
            // rdoHamburger
            // 
            rdoHamburger.AutoSize = true;
            rdoHamburger.Location = new Point(30, 75);
            rdoHamburger.Name = "rdoHamburger";
            rdoHamburger.Size = new Size(91, 29);
            rdoHamburger.TabIndex = 1;
            rdoHamburger.TabStop = true;
            rdoHamburger.Text = "햄버거";
            rdoHamburger.UseVisualStyleBackColor = true;
            rdoHamburger.CheckedChanged += rdoHamburger_CheckedChanged;
            // 
            // rdoBulgogiBurger
            // 
            rdoBulgogiBurger.AutoSize = true;
            rdoBulgogiBurger.Location = new Point(30, 244);
            rdoBulgogiBurger.Name = "rdoBulgogiBurger";
            rdoBulgogiBurger.Size = new Size(127, 29);
            rdoBulgogiBurger.TabIndex = 2;
            rdoBulgogiBurger.TabStop = true;
            rdoBulgogiBurger.Text = "불고기버거";
            rdoBulgogiBurger.UseVisualStyleBackColor = true;
            rdoBulgogiBurger.CheckedChanged += rdoBulgogiBurger_CheckedChanged;
            // 
            // rdoChickenBurger
            // 
            rdoChickenBurger.AutoSize = true;
            rdoChickenBurger.Location = new Point(30, 425);
            rdoChickenBurger.Name = "rdoChickenBurger";
            rdoChickenBurger.Size = new Size(109, 29);
            rdoChickenBurger.TabIndex = 3;
            rdoChickenBurger.TabStop = true;
            rdoChickenBurger.Text = "치킨버거";
            rdoChickenBurger.UseVisualStyleBackColor = true;
            rdoChickenBurger.CheckedChanged += rdoChickenBurger_CheckedChanged;
            // 
            // picHamBurger
            // 
            picHamBurger.Location = new Point(210, 36);
            picHamBurger.Name = "picHamBurger";
            picHamBurger.Size = new Size(188, 94);
            picHamBurger.TabIndex = 4;
            picHamBurger.TabStop = false;
            // 
            // picBulgogiBurger
            // 
            picBulgogiBurger.Location = new Point(210, 215);
            picBulgogiBurger.Name = "picBulgogiBurger";
            picBulgogiBurger.Size = new Size(188, 94);
            picBulgogiBurger.TabIndex = 5;
            picBulgogiBurger.TabStop = false;
            // 
            // picChickenBurger
            // 
            picChickenBurger.Location = new Point(210, 400);
            picChickenBurger.Name = "picChickenBurger";
            picChickenBurger.Size = new Size(188, 94);
            picChickenBurger.TabIndex = 6;
            picChickenBurger.TabStop = false;
            // 
            // chkPotato
            // 
            chkPotato.AutoSize = true;
            chkPotato.Location = new Point(45, 42);
            chkPotato.Name = "chkPotato";
            chkPotato.Size = new Size(110, 29);
            chkPotato.TabIndex = 7;
            chkPotato.Text = "감자튀김";
            chkPotato.UseVisualStyleBackColor = true;
            chkPotato.CheckedChanged += chkFrenchFries_CheckedChanged;
            // 
            // chkCola
            // 
            chkCola.AutoSize = true;
            chkCola.Location = new Point(45, 136);
            chkCola.Name = "chkCola";
            chkCola.Size = new Size(74, 29);
            chkCola.TabIndex = 8;
            chkCola.Text = "콜라";
            chkCola.UseVisualStyleBackColor = true;
            chkCola.CheckedChanged += chkCoke_CheckedChanged;
            // 
            // chkCheese
            // 
            chkCheese.AutoSize = true;
            chkCheese.Location = new Point(45, 240);
            chkCheese.Name = "chkCheese";
            chkCheese.Size = new Size(116, 29);
            chkCheese.TabIndex = 9;
            chkCheese.Text = "치즈 추가";
            chkCheese.UseVisualStyleBackColor = true;
            chkCheese.CheckedChanged += chkAddCheese_CheckedChanged;
            // 
            // chkSauce
            // 
            chkSauce.AutoSize = true;
            chkSauce.Location = new Point(45, 330);
            chkSauce.Name = "chkSauce";
            chkSauce.Size = new Size(116, 29);
            chkSauce.TabIndex = 10;
            chkSauce.Text = "소스 추가";
            chkSauce.UseVisualStyleBackColor = true;
            chkSauce.CheckedChanged += chkAddSouce_CheckedChanged;
            // 
            // lstOrder
            // 
            lstOrder.FormattingEnabled = true;
            lstOrder.Location = new Point(48, 30);
            lstOrder.Name = "lstOrder";
            lstOrder.Size = new Size(415, 329);
            lstOrder.TabIndex = 11;
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.Font = new Font("맑은 고딕", 20F);
            lblTotalCost.Location = new Point(48, 385);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(0, 54);
            lblTotalCost.TabIndex = 12;
            // 
            // btnOrder
            // 
            btnOrder.Font = new Font("맑은 고딕", 15F);
            btnOrder.Location = new Point(847, 730);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(200, 70);
            btnOrder.TabIndex = 13;
            btnOrder.Text = "주문하기";
            btnOrder.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("맑은 고딕", 15F);
            btnReset.Location = new Point(1062, 730);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(200, 70);
            btnReset.TabIndex = 14;
            btnReset.Text = "초기화";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // grpSelect
            // 
            grpSelect.Controls.Add(picChickenBurger);
            grpSelect.Controls.Add(picBulgogiBurger);
            grpSelect.Controls.Add(picHamBurger);
            grpSelect.Controls.Add(rdoChickenBurger);
            grpSelect.Controls.Add(rdoBulgogiBurger);
            grpSelect.Controls.Add(rdoHamburger);
            grpSelect.Location = new Point(32, 269);
            grpSelect.Name = "grpSelect";
            grpSelect.Size = new Size(436, 533);
            grpSelect.TabIndex = 15;
            grpSelect.TabStop = false;
            grpSelect.Text = "메뉴 선택";
            grpSelect.Enter += grpSelectMenu_Enter;
            // 
            // grpAdd
            // 
            grpAdd.Controls.Add(chkSauce);
            grpAdd.Controls.Add(chkCheese);
            grpAdd.Controls.Add(chkCola);
            grpAdd.Controls.Add(chkPotato);
            grpAdd.Location = new Point(508, 269);
            grpAdd.Name = "grpAdd";
            grpAdd.Size = new Size(253, 423);
            grpAdd.TabIndex = 16;
            grpAdd.TabStop = false;
            grpAdd.Text = "메뉴 추가";
            // 
            // grpOrderList
            // 
            grpOrderList.Controls.Add(lblTotalCost);
            grpOrderList.Controls.Add(lstOrder);
            grpOrderList.Location = new Point(799, 269);
            grpOrderList.Name = "grpOrderList";
            grpOrderList.Size = new Size(523, 457);
            grpOrderList.TabIndex = 17;
            grpOrderList.TabStop = false;
            grpOrderList.Text = "주문 내역";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1347, 863);
            Controls.Add(grpOrderList);
            Controls.Add(grpAdd);
            Controls.Add(grpSelect);
            Controls.Add(btnReset);
            Controls.Add(btnOrder);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Burger Kiosk v.10";
            ((System.ComponentModel.ISupportInitialize)picHamBurger).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBulgogiBurger).EndInit();
            ((System.ComponentModel.ISupportInitialize)picChickenBurger).EndInit();
            grpSelect.ResumeLayout(false);
            grpSelect.PerformLayout();
            grpAdd.ResumeLayout(false);
            grpAdd.PerformLayout();
            grpOrderList.ResumeLayout(false);
            grpOrderList.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private RadioButton rdoHamburger;
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
        private Button btnReset;
        private GroupBox grpSelect;
        private GroupBox grpAdd;
        private GroupBox grpOrderList;
    }
}
