namespace CS311_Project3_ZTS
{
    partial class FrmMain
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.cboSize = new System.Windows.Forms.ComboBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblCrust = new System.Windows.Forms.Label();
            this.rdoThin = new System.Windows.Forms.RadioButton();
            this.rdoThick = new System.Windows.Forms.RadioButton();
            this.rdoRegular = new System.Windows.Forms.RadioButton();
            this.lblToppings = new System.Windows.Forms.Label();
            this.ckbPep = new System.Windows.Forms.CheckBox();
            this.ckbOnion = new System.Windows.Forms.CheckBox();
            this.ckbBananaP = new System.Windows.Forms.CheckBox();
            this.ckbSausage = new System.Windows.Forms.CheckBox();
            this.ckbGreenP = new System.Windows.Forms.CheckBox();
            this.ckbJalepeno = new System.Windows.Forms.CheckBox();
            this.ckbCanBacon = new System.Windows.Forms.CheckBox();
            this.ckbBlackO = new System.Windows.Forms.CheckBox();
            this.ckbExCheese = new System.Windows.Forms.CheckBox();
            this.ckbSIS = new System.Windows.Forms.CheckBox();
            this.ckbGreenO = new System.Windows.Forms.CheckBox();
            this.ckbMushroom = new System.Windows.Forms.CheckBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtSubT = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblSubT = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.rtfSummary = new System.Windows.Forms.RichTextBox();
            this.lblSummary = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CS311_Project3_ZTS.Properties.Resources.small;
            this.pictureBox1.Location = new System.Drawing.Point(571, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Snap ITC", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.Color.DarkRed;
            this.lblName.Location = new System.Drawing.Point(38, 15);
            this.lblName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(462, 123);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "ZT\'s Za";
            // 
            // cboSize
            // 
            this.cboSize.FormattingEnabled = true;
            this.cboSize.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large",
            "X-Large",
            "Ginormous"});
            this.cboSize.Location = new System.Drawing.Point(82, 180);
            this.cboSize.Margin = new System.Windows.Forms.Padding(5);
            this.cboSize.Name = "cboSize";
            this.cboSize.Size = new System.Drawing.Size(221, 33);
            this.cboSize.TabIndex = 3;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSize.Location = new System.Drawing.Point(38, 127);
            this.lblSize.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(75, 37);
            this.lblSize.TabIndex = 4;
            this.lblSize.Text = "Size:";
            // 
            // lblCrust
            // 
            this.lblCrust.AutoSize = true;
            this.lblCrust.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCrust.Location = new System.Drawing.Point(38, 218);
            this.lblCrust.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCrust.Name = "lblCrust";
            this.lblCrust.Size = new System.Drawing.Size(161, 37);
            this.lblCrust.TabIndex = 5;
            this.lblCrust.Text = "Crust Style:";
            // 
            // rdoThin
            // 
            this.rdoThin.AutoSize = true;
            this.rdoThin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoThin.Location = new System.Drawing.Point(82, 260);
            this.rdoThin.Margin = new System.Windows.Forms.Padding(5);
            this.rdoThin.Name = "rdoThin";
            this.rdoThin.Size = new System.Drawing.Size(67, 29);
            this.rdoThin.TabIndex = 6;
            this.rdoThin.TabStop = true;
            this.rdoThin.Text = "Thin";
            this.rdoThin.UseVisualStyleBackColor = true;
            // 
            // rdoThick
            // 
            this.rdoThick.AutoSize = true;
            this.rdoThick.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoThick.Location = new System.Drawing.Point(247, 260);
            this.rdoThick.Margin = new System.Windows.Forms.Padding(5);
            this.rdoThick.Name = "rdoThick";
            this.rdoThick.Size = new System.Drawing.Size(74, 29);
            this.rdoThick.TabIndex = 9;
            this.rdoThick.TabStop = true;
            this.rdoThick.Text = "Thick";
            this.rdoThick.UseVisualStyleBackColor = true;
            // 
            // rdoRegular
            // 
            this.rdoRegular.AutoSize = true;
            this.rdoRegular.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoRegular.Location = new System.Drawing.Point(406, 260);
            this.rdoRegular.Margin = new System.Windows.Forms.Padding(5);
            this.rdoRegular.Name = "rdoRegular";
            this.rdoRegular.Size = new System.Drawing.Size(94, 29);
            this.rdoRegular.TabIndex = 10;
            this.rdoRegular.TabStop = true;
            this.rdoRegular.Text = "Regular";
            this.rdoRegular.UseVisualStyleBackColor = true;
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToppings.Location = new System.Drawing.Point(38, 294);
            this.lblToppings.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(142, 37);
            this.lblToppings.TabIndex = 11;
            this.lblToppings.Text = "Toppings:";
            // 
            // ckbPep
            // 
            this.ckbPep.AutoSize = true;
            this.ckbPep.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ckbPep.Location = new System.Drawing.Point(82, 336);
            this.ckbPep.Margin = new System.Windows.Forms.Padding(5);
            this.ckbPep.Name = "ckbPep";
            this.ckbPep.Size = new System.Drawing.Size(117, 29);
            this.ckbPep.TabIndex = 12;
            this.ckbPep.Text = "Pepperoni";
            this.ckbPep.UseVisualStyleBackColor = true;
            // 
            // ckbOnion
            // 
            this.ckbOnion.AutoSize = true;
            this.ckbOnion.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ckbOnion.Location = new System.Drawing.Point(464, 375);
            this.ckbOnion.Margin = new System.Windows.Forms.Padding(5);
            this.ckbOnion.Name = "ckbOnion";
            this.ckbOnion.Size = new System.Drawing.Size(83, 29);
            this.ckbOnion.TabIndex = 13;
            this.ckbOnion.Text = "Onion";
            this.ckbOnion.UseVisualStyleBackColor = true;
            // 
            // ckbBananaP
            // 
            this.ckbBananaP.AutoSize = true;
            this.ckbBananaP.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ckbBananaP.Location = new System.Drawing.Point(247, 375);
            this.ckbBananaP.Margin = new System.Windows.Forms.Padding(5);
            this.ckbBananaP.Name = "ckbBananaP";
            this.ckbBananaP.Size = new System.Drawing.Size(158, 29);
            this.ckbBananaP.TabIndex = 14;
            this.ckbBananaP.Text = "Banana Pepper";
            this.ckbBananaP.UseVisualStyleBackColor = true;
            // 
            // ckbSausage
            // 
            this.ckbSausage.AutoSize = true;
            this.ckbSausage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ckbSausage.Location = new System.Drawing.Point(633, 336);
            this.ckbSausage.Margin = new System.Windows.Forms.Padding(5);
            this.ckbSausage.Name = "ckbSausage";
            this.ckbSausage.Size = new System.Drawing.Size(101, 29);
            this.ckbSausage.TabIndex = 15;
            this.ckbSausage.Text = "Sausage";
            this.ckbSausage.UseVisualStyleBackColor = true;
            // 
            // ckbGreenP
            // 
            this.ckbGreenP.AutoSize = true;
            this.ckbGreenP.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ckbGreenP.Location = new System.Drawing.Point(82, 375);
            this.ckbGreenP.Margin = new System.Windows.Forms.Padding(5);
            this.ckbGreenP.Name = "ckbGreenP";
            this.ckbGreenP.Size = new System.Drawing.Size(146, 29);
            this.ckbGreenP.TabIndex = 16;
            this.ckbGreenP.Text = "Green Pepper";
            this.ckbGreenP.UseVisualStyleBackColor = true;
            // 
            // ckbJalepeno
            // 
            this.ckbJalepeno.AutoSize = true;
            this.ckbJalepeno.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ckbJalepeno.Location = new System.Drawing.Point(464, 336);
            this.ckbJalepeno.Margin = new System.Windows.Forms.Padding(5);
            this.ckbJalepeno.Name = "ckbJalepeno";
            this.ckbJalepeno.Size = new System.Drawing.Size(106, 29);
            this.ckbJalepeno.TabIndex = 17;
            this.ckbJalepeno.Text = "Jalepeno";
            this.ckbJalepeno.UseVisualStyleBackColor = true;
            // 
            // ckbCanBacon
            // 
            this.ckbCanBacon.AutoSize = true;
            this.ckbCanBacon.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ckbCanBacon.Location = new System.Drawing.Point(247, 414);
            this.ckbCanBacon.Margin = new System.Windows.Forms.Padding(5);
            this.ckbCanBacon.Name = "ckbCanBacon";
            this.ckbCanBacon.Size = new System.Drawing.Size(168, 29);
            this.ckbCanBacon.TabIndex = 18;
            this.ckbCanBacon.Text = "Canadian Bacon";
            this.ckbCanBacon.UseVisualStyleBackColor = true;
            // 
            // ckbBlackO
            // 
            this.ckbBlackO.AutoSize = true;
            this.ckbBlackO.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ckbBlackO.Location = new System.Drawing.Point(464, 414);
            this.ckbBlackO.Margin = new System.Windows.Forms.Padding(5);
            this.ckbBlackO.Name = "ckbBlackO";
            this.ckbBlackO.Size = new System.Drawing.Size(131, 29);
            this.ckbBlackO.TabIndex = 19;
            this.ckbBlackO.Text = "Black Olives";
            this.ckbBlackO.UseVisualStyleBackColor = true;
            // 
            // ckbExCheese
            // 
            this.ckbExCheese.AutoSize = true;
            this.ckbExCheese.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ckbExCheese.Location = new System.Drawing.Point(82, 414);
            this.ckbExCheese.Margin = new System.Windows.Forms.Padding(5);
            this.ckbExCheese.Name = "ckbExCheese";
            this.ckbExCheese.Size = new System.Drawing.Size(139, 29);
            this.ckbExCheese.TabIndex = 20;
            this.ckbExCheese.Text = "Extra Cheese";
            this.ckbExCheese.UseVisualStyleBackColor = true;
            // 
            // ckbSIS
            // 
            this.ckbSIS.AutoSize = true;
            this.ckbSIS.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ckbSIS.Location = new System.Drawing.Point(247, 336);
            this.ckbSIS.Margin = new System.Windows.Forms.Padding(5);
            this.ckbSIS.Name = "ckbSIS";
            this.ckbSIS.Size = new System.Drawing.Size(207, 29);
            this.ckbSIS.TabIndex = 21;
            this.ckbSIS.Text = "Spicy Italian Sausage";
            this.ckbSIS.UseVisualStyleBackColor = true;
            // 
            // ckbGreenO
            // 
            this.ckbGreenO.AutoSize = true;
            this.ckbGreenO.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ckbGreenO.Location = new System.Drawing.Point(633, 375);
            this.ckbGreenO.Margin = new System.Windows.Forms.Padding(5);
            this.ckbGreenO.Name = "ckbGreenO";
            this.ckbGreenO.Size = new System.Drawing.Size(138, 29);
            this.ckbGreenO.TabIndex = 22;
            this.ckbGreenO.Text = "Green Olives";
            this.ckbGreenO.UseVisualStyleBackColor = true;
            // 
            // ckbMushroom
            // 
            this.ckbMushroom.AutoSize = true;
            this.ckbMushroom.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ckbMushroom.Location = new System.Drawing.Point(633, 414);
            this.ckbMushroom.Margin = new System.Windows.Forms.Padding(5);
            this.ckbMushroom.Name = "ckbMushroom";
            this.ckbMushroom.Size = new System.Drawing.Size(123, 29);
            this.ckbMushroom.TabIndex = 23;
            this.ckbMushroom.Text = "Mushroom";
            this.ckbMushroom.UseVisualStyleBackColor = true;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(521, 578);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(250, 59);
            this.btnCalc.TabIndex = 24;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtSubT
            // 
            this.txtSubT.Location = new System.Drawing.Point(671, 461);
            this.txtSubT.Name = "txtSubT";
            this.txtSubT.Size = new System.Drawing.Size(100, 33);
            this.txtSubT.TabIndex = 25;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(671, 500);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(100, 33);
            this.txtTax.TabIndex = 26;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(671, 539);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 33);
            this.txtTotal.TabIndex = 27;
            // 
            // lblSubT
            // 
            this.lblSubT.AutoSize = true;
            this.lblSubT.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSubT.Location = new System.Drawing.Point(521, 457);
            this.lblSubT.Name = "lblSubT";
            this.lblSubT.Size = new System.Drawing.Size(144, 37);
            this.lblSubT.TabIndex = 28;
            this.lblSubT.Text = "Sub Total:";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTax.Location = new System.Drawing.Point(597, 496);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(68, 37);
            this.lblTax.TabIndex = 29;
            this.lblTax.Text = "Tax:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(576, 535);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(89, 37);
            this.lblTotal.TabIndex = 30;
            this.lblTotal.Text = "Total:";
            // 
            // rtfSummary
            // 
            this.rtfSummary.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtfSummary.Location = new System.Drawing.Point(48, 500);
            this.rtfSummary.Name = "rtfSummary";
            this.rtfSummary.Size = new System.Drawing.Size(467, 137);
            this.rtfSummary.TabIndex = 31;
            this.rtfSummary.Text = "";
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSummary.Location = new System.Drawing.Point(38, 454);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(228, 37);
            this.lblSummary.TabIndex = 32;
            this.lblSummary.Text = "Order Summary:";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 652);
            this.Controls.Add(this.lblSummary);
            this.Controls.Add(this.rtfSummary);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblSubT);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.txtSubT);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.ckbMushroom);
            this.Controls.Add(this.ckbGreenO);
            this.Controls.Add(this.ckbSIS);
            this.Controls.Add(this.ckbExCheese);
            this.Controls.Add(this.ckbBlackO);
            this.Controls.Add(this.ckbCanBacon);
            this.Controls.Add(this.ckbJalepeno);
            this.Controls.Add(this.ckbGreenP);
            this.Controls.Add(this.ckbSausage);
            this.Controls.Add(this.ckbBananaP);
            this.Controls.Add(this.ckbOnion);
            this.Controls.Add(this.ckbPep);
            this.Controls.Add(this.lblToppings);
            this.Controls.Add(this.rdoRegular);
            this.Controls.Add(this.rdoThick);
            this.Controls.Add(this.rdoThin);
            this.Controls.Add(this.lblCrust);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.cboSize);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmMain";
            this.Text = "ZT\'s Za";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox pictureBox1;
        private Label lblName;
        private ComboBox cboSize;
        private Label lblSize;
        private Label lblCrust;
        private RadioButton rdoThin;
        private RadioButton rdoThick;
        private RadioButton rdoRegular;
        private Label lblToppings;
        private CheckBox ckbPep;
        private CheckBox ckbOnion;
        private CheckBox ckbBananaP;
        private CheckBox ckbSausage;
        private CheckBox ckbGreenP;
        private CheckBox ckbJalepeno;
        private CheckBox ckbCanBacon;
        private CheckBox ckbBlackO;
        private CheckBox ckbExCheese;
        private CheckBox ckbSIS;
        private CheckBox ckbGreenO;
        private CheckBox ckbMushroom;
        private Button btnCalc;
        private TextBox txtSubT;
        private TextBox txtTax;
        private TextBox txtTotal;
        private Label lblSubT;
        private Label lblTax;
        private Label lblTotal;
        private RichTextBox rtfSummary;
        private Label lblSummary;
    }
}