namespace CS311_Project3_ALB
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboPizzaSize = new System.Windows.Forms.ComboBox();
            this.lblPizzaSize = new System.Windows.Forms.Label();
            this.grpPizzaCrusts = new System.Windows.Forms.GroupBox();
            this.rbRegular = new System.Windows.Forms.RadioButton();
            this.rbThick = new System.Windows.Forms.RadioButton();
            this.rbThin = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.grpToppings = new System.Windows.Forms.GroupBox();
            this.cbSpicyItalian = new System.Windows.Forms.CheckBox();
            this.cbCanadianBacon = new System.Windows.Forms.CheckBox();
            this.cbSausage = new System.Windows.Forms.CheckBox();
            this.cbPepperoni = new System.Windows.Forms.CheckBox();
            this.cbOnion = new System.Windows.Forms.CheckBox();
            this.cbGreenPepper = new System.Windows.Forms.CheckBox();
            this.cbBlackOlives = new System.Windows.Forms.CheckBox();
            this.cbGreenOlives = new System.Windows.Forms.CheckBox();
            this.cbBananaPeppers = new System.Windows.Forms.CheckBox();
            this.cbJalapenos = new System.Windows.Forms.CheckBox();
            this.cbMushrooms = new System.Windows.Forms.CheckBox();
            this.cbExtraCheese = new System.Windows.Forms.CheckBox();
            this.rtfOutput = new System.Windows.Forms.RichTextBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.txtbSubtotal = new System.Windows.Forms.TextBox();
            this.txtbTax = new System.Windows.Forms.TextBox();
            this.txtbTotal = new System.Windows.Forms.TextBox();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblOrderSummary = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpPizzaCrusts.SuspendLayout();
            this.grpToppings.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleName = "logoPic";
            this.pictureBox1.Image = global::CS311_Project3_ALB.Properties.Resources.tony_soprano_1523370005;
            this.pictureBox1.Location = new System.Drawing.Point(-30, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(481, 395);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AccessibleName = "titleLbl";
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(591, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(542, 73);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tony Soprano Pizza";
            // 
            // cboPizzaSize
            // 
            this.cboPizzaSize.AccessibleName = "cboPizzaSize";
            this.cboPizzaSize.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPizzaSize.FormattingEnabled = true;
            this.cboPizzaSize.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large",
            "X-Large",
            "Ginormous"});
            this.cboPizzaSize.Location = new System.Drawing.Point(482, 115);
            this.cboPizzaSize.Name = "cboPizzaSize";
            this.cboPizzaSize.Size = new System.Drawing.Size(217, 31);
            this.cboPizzaSize.TabIndex = 2;
            this.cboPizzaSize.SelectedIndexChanged += new System.EventHandler(this.cboPizzaSize_SelectedIndexChanged);
            // 
            // lblPizzaSize
            // 
            this.lblPizzaSize.AutoSize = true;
            this.lblPizzaSize.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPizzaSize.Location = new System.Drawing.Point(482, 96);
            this.lblPizzaSize.Name = "lblPizzaSize";
            this.lblPizzaSize.Size = new System.Drawing.Size(69, 19);
            this.lblPizzaSize.TabIndex = 4;
            this.lblPizzaSize.Text = "Pizza Size";
            // 
            // grpPizzaCrusts
            // 
            this.grpPizzaCrusts.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grpPizzaCrusts.Controls.Add(this.rbRegular);
            this.grpPizzaCrusts.Controls.Add(this.rbThick);
            this.grpPizzaCrusts.Controls.Add(this.rbThin);
            this.grpPizzaCrusts.Location = new System.Drawing.Point(720, 148);
            this.grpPizzaCrusts.Name = "grpPizzaCrusts";
            this.grpPizzaCrusts.Size = new System.Drawing.Size(200, 100);
            this.grpPizzaCrusts.TabIndex = 5;
            this.grpPizzaCrusts.TabStop = false;
            this.grpPizzaCrusts.Text = "Pizza Crusts";
            // 
            // rbRegular
            // 
            this.rbRegular.AutoSize = true;
            this.rbRegular.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRegular.Location = new System.Drawing.Point(6, 45);
            this.rbRegular.Name = "rbRegular";
            this.rbRegular.Size = new System.Drawing.Size(66, 19);
            this.rbRegular.TabIndex = 2;
            this.rbRegular.TabStop = true;
            this.rbRegular.Text = "Regular";
            this.rbRegular.UseVisualStyleBackColor = true;
            this.rbRegular.CheckedChanged += new System.EventHandler(this.rboThick_CheckedChanged);
            // 
            // rbThick
            // 
            this.rbThick.AutoSize = true;
            this.rbThick.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThick.Location = new System.Drawing.Point(7, 75);
            this.rbThick.Name = "rbThick";
            this.rbThick.Size = new System.Drawing.Size(55, 19);
            this.rbThick.TabIndex = 1;
            this.rbThick.TabStop = true;
            this.rbThick.Text = "Thick";
            this.rbThick.UseVisualStyleBackColor = true;
            this.rbThick.CheckedChanged += new System.EventHandler(this.rbThick_CheckedChanged);
            // 
            // rbThin
            // 
            this.rbThin.AutoSize = true;
            this.rbThin.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThin.Location = new System.Drawing.Point(7, 20);
            this.rbThin.Name = "rbThin";
            this.rbThin.Size = new System.Drawing.Size(50, 19);
            this.rbThin.TabIndex = 0;
            this.rbThin.TabStop = true;
            this.rbThin.Text = "Thin";
            this.rbThin.UseVisualStyleBackColor = true;
            this.rbThin.CheckedChanged += new System.EventHandler(this.rbThin_CheckedChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnCalculate.Location = new System.Drawing.Point(954, 96);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(288, 64);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpToppings
            // 
            this.grpToppings.Controls.Add(this.cbExtraCheese);
            this.grpToppings.Controls.Add(this.cbMushrooms);
            this.grpToppings.Controls.Add(this.cbJalapenos);
            this.grpToppings.Controls.Add(this.cbBananaPeppers);
            this.grpToppings.Controls.Add(this.cbGreenOlives);
            this.grpToppings.Controls.Add(this.cbBlackOlives);
            this.grpToppings.Controls.Add(this.cbGreenPepper);
            this.grpToppings.Controls.Add(this.cbOnion);
            this.grpToppings.Controls.Add(this.cbSpicyItalian);
            this.grpToppings.Controls.Add(this.cbCanadianBacon);
            this.grpToppings.Controls.Add(this.cbSausage);
            this.grpToppings.Controls.Add(this.cbPepperoni);
            this.grpToppings.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpToppings.Location = new System.Drawing.Point(482, 288);
            this.grpToppings.Name = "grpToppings";
            this.grpToppings.Size = new System.Drawing.Size(438, 198);
            this.grpToppings.TabIndex = 7;
            this.grpToppings.TabStop = false;
            this.grpToppings.Text = "Toppings";
            // 
            // cbSpicyItalian
            // 
            this.cbSpicyItalian.AutoSize = true;
            this.cbSpicyItalian.Location = new System.Drawing.Point(7, 91);
            this.cbSpicyItalian.Name = "cbSpicyItalian";
            this.cbSpicyItalian.Size = new System.Drawing.Size(140, 19);
            this.cbSpicyItalian.TabIndex = 3;
            this.cbSpicyItalian.Text = "Spicy Italian Sausage";
            this.cbSpicyItalian.UseVisualStyleBackColor = true;
            this.cbSpicyItalian.CheckedChanged += new System.EventHandler(this.cbSpicyItalian_CheckedChanged);
            // 
            // cbCanadianBacon
            // 
            this.cbCanadianBacon.AutoSize = true;
            this.cbCanadianBacon.Location = new System.Drawing.Point(7, 67);
            this.cbCanadianBacon.Name = "cbCanadianBacon";
            this.cbCanadianBacon.Size = new System.Drawing.Size(113, 19);
            this.cbCanadianBacon.TabIndex = 2;
            this.cbCanadianBacon.Text = "Canadian Bacon";
            this.cbCanadianBacon.UseVisualStyleBackColor = true;
            // 
            // cbSausage
            // 
            this.cbSausage.AutoSize = true;
            this.cbSausage.Location = new System.Drawing.Point(7, 44);
            this.cbSausage.Name = "cbSausage";
            this.cbSausage.Size = new System.Drawing.Size(71, 19);
            this.cbSausage.TabIndex = 1;
            this.cbSausage.Text = "Sausage";
            this.cbSausage.UseVisualStyleBackColor = true;
            this.cbSausage.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // cbPepperoni
            // 
            this.cbPepperoni.AutoSize = true;
            this.cbPepperoni.Location = new System.Drawing.Point(7, 20);
            this.cbPepperoni.Name = "cbPepperoni";
            this.cbPepperoni.Size = new System.Drawing.Size(80, 19);
            this.cbPepperoni.TabIndex = 0;
            this.cbPepperoni.Text = "Pepperoni";
            this.cbPepperoni.UseVisualStyleBackColor = true;
            // 
            // cbOnion
            // 
            this.cbOnion.AutoSize = true;
            this.cbOnion.Location = new System.Drawing.Point(158, 20);
            this.cbOnion.Name = "cbOnion";
            this.cbOnion.Size = new System.Drawing.Size(65, 19);
            this.cbOnion.TabIndex = 4;
            this.cbOnion.Text = "Onions";
            this.cbOnion.UseVisualStyleBackColor = true;
            // 
            // cbGreenPepper
            // 
            this.cbGreenPepper.AutoSize = true;
            this.cbGreenPepper.Location = new System.Drawing.Point(158, 44);
            this.cbGreenPepper.Name = "cbGreenPepper";
            this.cbGreenPepper.Size = new System.Drawing.Size(103, 19);
            this.cbGreenPepper.TabIndex = 5;
            this.cbGreenPepper.Text = "Green Peppers";
            this.cbGreenPepper.UseVisualStyleBackColor = true;
            // 
            // cbBlackOlives
            // 
            this.cbBlackOlives.AutoSize = true;
            this.cbBlackOlives.Location = new System.Drawing.Point(158, 67);
            this.cbBlackOlives.Name = "cbBlackOlives";
            this.cbBlackOlives.Size = new System.Drawing.Size(92, 19);
            this.cbBlackOlives.TabIndex = 6;
            this.cbBlackOlives.Text = "Black Olives";
            this.cbBlackOlives.UseVisualStyleBackColor = true;
            // 
            // cbGreenOlives
            // 
            this.cbGreenOlives.AutoSize = true;
            this.cbGreenOlives.Location = new System.Drawing.Point(158, 91);
            this.cbGreenOlives.Name = "cbGreenOlives";
            this.cbGreenOlives.Size = new System.Drawing.Size(94, 19);
            this.cbGreenOlives.TabIndex = 7;
            this.cbGreenOlives.Text = "Green Olives";
            this.cbGreenOlives.UseVisualStyleBackColor = true;
            // 
            // cbBananaPeppers
            // 
            this.cbBananaPeppers.AutoSize = true;
            this.cbBananaPeppers.Location = new System.Drawing.Point(158, 116);
            this.cbBananaPeppers.Name = "cbBananaPeppers";
            this.cbBananaPeppers.Size = new System.Drawing.Size(112, 19);
            this.cbBananaPeppers.TabIndex = 8;
            this.cbBananaPeppers.Text = "Banana Peppers";
            this.cbBananaPeppers.UseVisualStyleBackColor = true;
            // 
            // cbJalapenos
            // 
            this.cbJalapenos.AutoSize = true;
            this.cbJalapenos.Location = new System.Drawing.Point(158, 142);
            this.cbJalapenos.Name = "cbJalapenos";
            this.cbJalapenos.Size = new System.Drawing.Size(79, 19);
            this.cbJalapenos.TabIndex = 9;
            this.cbJalapenos.Text = "Jalapenos";
            this.cbJalapenos.UseVisualStyleBackColor = true;
            // 
            // cbMushrooms
            // 
            this.cbMushrooms.AutoSize = true;
            this.cbMushrooms.Location = new System.Drawing.Point(158, 168);
            this.cbMushrooms.Name = "cbMushrooms";
            this.cbMushrooms.Size = new System.Drawing.Size(91, 19);
            this.cbMushrooms.TabIndex = 10;
            this.cbMushrooms.Text = "Mushrooms";
            this.cbMushrooms.UseVisualStyleBackColor = true;
            // 
            // cbExtraCheese
            // 
            this.cbExtraCheese.AutoSize = true;
            this.cbExtraCheese.Location = new System.Drawing.Point(305, 20);
            this.cbExtraCheese.Name = "cbExtraCheese";
            this.cbExtraCheese.Size = new System.Drawing.Size(94, 19);
            this.cbExtraCheese.TabIndex = 11;
            this.cbExtraCheese.Text = "Extra Cheese";
            this.cbExtraCheese.UseVisualStyleBackColor = true;
            // 
            // rtfOutput
            // 
            this.rtfOutput.Location = new System.Drawing.Point(954, 193);
            this.rtfOutput.Name = "rtfOutput";
            this.rtfOutput.Size = new System.Drawing.Size(288, 269);
            this.rtfOutput.TabIndex = 8;
            this.rtfOutput.Text = "";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(976, 481);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(88, 22);
            this.lblSubtotal.TabIndex = 9;
            this.lblSubtotal.Text = "SubTotal:";
            // 
            // txtbSubtotal
            // 
            this.txtbSubtotal.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbSubtotal.Location = new System.Drawing.Point(1070, 481);
            this.txtbSubtotal.Name = "txtbSubtotal";
            this.txtbSubtotal.Size = new System.Drawing.Size(136, 22);
            this.txtbSubtotal.TabIndex = 10;
            // 
            // txtbTax
            // 
            this.txtbTax.Location = new System.Drawing.Point(1071, 522);
            this.txtbTax.Name = "txtbTax";
            this.txtbTax.Size = new System.Drawing.Size(136, 20);
            this.txtbTax.TabIndex = 11;
            // 
            // txtbTotal
            // 
            this.txtbTotal.Location = new System.Drawing.Point(1071, 562);
            this.txtbTotal.Name = "txtbTotal";
            this.txtbTotal.Size = new System.Drawing.Size(136, 20);
            this.txtbTotal.TabIndex = 12;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(1019, 518);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(45, 22);
            this.lblTax.TabIndex = 13;
            this.lblTax.Text = "Tax:";
            this.lblTax.Click += new System.EventHandler(this.lblTax_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(1007, 561);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(57, 22);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.Text = "Total:";
            // 
            // lblOrderSummary
            // 
            this.lblOrderSummary.AutoSize = true;
            this.lblOrderSummary.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderSummary.Location = new System.Drawing.Point(954, 174);
            this.lblOrderSummary.Name = "lblOrderSummary";
            this.lblOrderSummary.Size = new System.Drawing.Size(125, 19);
            this.lblOrderSummary.TabIndex = 15;
            this.lblOrderSummary.Text = "Order Summary: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 649);
            this.Controls.Add(this.lblOrderSummary);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.txtbTotal);
            this.Controls.Add(this.txtbTax);
            this.Controls.Add(this.txtbSubtotal);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.rtfOutput);
            this.Controls.Add(this.grpToppings);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.grpPizzaCrusts);
            this.Controls.Add(this.lblPizzaSize);
            this.Controls.Add(this.cboPizzaSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpPizzaCrusts.ResumeLayout(false);
            this.grpPizzaCrusts.PerformLayout();
            this.grpToppings.ResumeLayout(false);
            this.grpToppings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboPizzaSize;
        private System.Windows.Forms.Label lblPizzaSize;
        private System.Windows.Forms.GroupBox grpPizzaCrusts;
        private System.Windows.Forms.RadioButton rbRegular;
        private System.Windows.Forms.RadioButton rbThick;
        private System.Windows.Forms.RadioButton rbThin;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox grpToppings;
        private System.Windows.Forms.CheckBox cbSpicyItalian;
        private System.Windows.Forms.CheckBox cbCanadianBacon;
        private System.Windows.Forms.CheckBox cbSausage;
        private System.Windows.Forms.CheckBox cbPepperoni;
        private System.Windows.Forms.CheckBox cbBananaPeppers;
        private System.Windows.Forms.CheckBox cbGreenOlives;
        private System.Windows.Forms.CheckBox cbBlackOlives;
        private System.Windows.Forms.CheckBox cbGreenPepper;
        private System.Windows.Forms.CheckBox cbOnion;
        private System.Windows.Forms.CheckBox cbExtraCheese;
        private System.Windows.Forms.CheckBox cbMushrooms;
        private System.Windows.Forms.CheckBox cbJalapenos;
        private System.Windows.Forms.RichTextBox rtfOutput;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.TextBox txtbSubtotal;
        private System.Windows.Forms.TextBox txtbTax;
        private System.Windows.Forms.TextBox txtbTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblOrderSummary;
    }
}

