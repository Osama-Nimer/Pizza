namespace Pizza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbPizza = new System.Windows.Forms.Label();
            this.rdbThin = new System.Windows.Forms.RadioButton();
            this.rdbThink = new System.Windows.Forms.RadioButton();
            this.bgCrust = new System.Windows.Forms.GroupBox();
            this.chkExtra = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkGreen = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.rdbIn = new System.Windows.Forms.RadioButton();
            this.rdbOut = new System.Windows.Forms.RadioButton();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnRest = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bgEat = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bgSamary = new System.Windows.Forms.GroupBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbEat = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbCrust = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.lbToppings = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bgToppings = new System.Windows.Forms.GroupBox();
            this.bgSize = new System.Windows.Forms.GroupBox();
            this.rdbLarg = new System.Windows.Forms.RadioButton();
            this.rdbMeduim = new System.Windows.Forms.RadioButton();
            this.rdbSmall = new System.Windows.Forms.RadioButton();
            this.bgCrust.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bgEat.SuspendLayout();
            this.bgSamary.SuspendLayout();
            this.bgToppings.SuspendLayout();
            this.bgSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbPizza
            // 
            this.lbPizza.AutoSize = true;
            this.lbPizza.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPizza.ForeColor = System.Drawing.Color.Red;
            this.lbPizza.Location = new System.Drawing.Point(296, 35);
            this.lbPizza.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbPizza.Name = "lbPizza";
            this.lbPizza.Size = new System.Drawing.Size(585, 74);
            this.lbPizza.TabIndex = 0;
            this.lbPizza.Text = "MAKE YOUR PIZZA ";
            this.lbPizza.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rdbThin
            // 
            this.rdbThin.AutoSize = true;
            this.rdbThin.Location = new System.Drawing.Point(27, 47);
            this.rdbThin.Margin = new System.Windows.Forms.Padding(2);
            this.rdbThin.Name = "rdbThin";
            this.rdbThin.Size = new System.Drawing.Size(120, 29);
            this.rdbThin.TabIndex = 6;
            this.rdbThin.TabStop = true;
            this.rdbThin.Tag = "0";
            this.rdbThin.Text = "Thin Crust";
            this.rdbThin.UseVisualStyleBackColor = true;
            this.rdbThin.CheckedChanged += new System.EventHandler(this.rdbThin_CheckedChanged);
            // 
            // rdbThink
            // 
            this.rdbThink.AutoSize = true;
            this.rdbThink.Location = new System.Drawing.Point(27, 93);
            this.rdbThink.Margin = new System.Windows.Forms.Padding(2);
            this.rdbThink.Name = "rdbThink";
            this.rdbThink.Size = new System.Drawing.Size(130, 29);
            this.rdbThink.TabIndex = 7;
            this.rdbThink.TabStop = true;
            this.rdbThink.Tag = "10";
            this.rdbThink.Text = "Think Crust";
            this.rdbThink.UseVisualStyleBackColor = true;
            this.rdbThink.CheckedChanged += new System.EventHandler(this.rdbThink_CheckedChanged);
            // 
            // bgCrust
            // 
            this.bgCrust.Controls.Add(this.rdbThin);
            this.bgCrust.Controls.Add(this.rdbThink);
            this.bgCrust.Location = new System.Drawing.Point(77, 307);
            this.bgCrust.Name = "bgCrust";
            this.bgCrust.Size = new System.Drawing.Size(200, 154);
            this.bgCrust.TabIndex = 8;
            this.bgCrust.TabStop = false;
            this.bgCrust.Text = "Crust Type";
            // 
            // chkExtra
            // 
            this.chkExtra.AutoSize = true;
            this.chkExtra.Location = new System.Drawing.Point(27, 42);
            this.chkExtra.Name = "chkExtra";
            this.chkExtra.Size = new System.Drawing.Size(133, 29);
            this.chkExtra.TabIndex = 9;
            this.chkExtra.Tag = "5";
            this.chkExtra.Text = "Extra Chees";
            this.chkExtra.UseVisualStyleBackColor = true;
            this.chkExtra.CheckedChanged += new System.EventHandler(this.chkExtra_CheckedChanged);
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.Location = new System.Drawing.Point(27, 150);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(118, 29);
            this.chkTomatoes.TabIndex = 10;
            this.chkTomatoes.Tag = "5";
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            this.chkTomatoes.CheckedChanged += new System.EventHandler(this.chkTomatoes_CheckedChanged);
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Location = new System.Drawing.Point(27, 95);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(134, 29);
            this.chkMushrooms.TabIndex = 11;
            this.chkMushrooms.Tag = "5";
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.chkMushrooms_CheckedChanged);
            // 
            // chkGreen
            // 
            this.chkGreen.AutoSize = true;
            this.chkGreen.Location = new System.Drawing.Point(189, 150);
            this.chkGreen.Name = "chkGreen";
            this.chkGreen.Size = new System.Drawing.Size(158, 29);
            this.chkGreen.TabIndex = 12;
            this.chkGreen.Tag = "5";
            this.chkGreen.Text = "Green Peppers";
            this.chkGreen.UseVisualStyleBackColor = true;
            this.chkGreen.CheckedChanged += new System.EventHandler(this.chkGreen_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Location = new System.Drawing.Point(189, 96);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(86, 29);
            this.chkOlives.TabIndex = 13;
            this.chkOlives.Tag = "5";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(189, 42);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(86, 29);
            this.chkOnion.TabIndex = 14;
            this.chkOnion.Tag = "5";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // rdbIn
            // 
            this.rdbIn.AutoSize = true;
            this.rdbIn.Location = new System.Drawing.Point(51, 26);
            this.rdbIn.Name = "rdbIn";
            this.rdbIn.Size = new System.Drawing.Size(82, 29);
            this.rdbIn.TabIndex = 15;
            this.rdbIn.TabStop = true;
            this.rdbIn.Text = "Eat In";
            this.rdbIn.UseVisualStyleBackColor = true;
            this.rdbIn.CheckedChanged += new System.EventHandler(this.rdbIn_CheckedChanged);
            // 
            // rdbOut
            // 
            this.rdbOut.AutoSize = true;
            this.rdbOut.Location = new System.Drawing.Point(204, 26);
            this.rdbOut.Name = "rdbOut";
            this.rdbOut.Size = new System.Drawing.Size(110, 29);
            this.rdbOut.TabIndex = 16;
            this.rdbOut.TabStop = true;
            this.rdbOut.Text = "Tack Out";
            this.rdbOut.UseVisualStyleBackColor = true;
            this.rdbOut.CheckedChanged += new System.EventHandler(this.rdbOut_CheckedChanged);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(399, 476);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(123, 36);
            this.btnOrder.TabIndex = 17;
            this.btnOrder.Text = "Order Pizza";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnRest
            // 
            this.btnRest.Location = new System.Drawing.Point(575, 476);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(154, 36);
            this.btnRest.TabIndex = 18;
            this.btnRest.Text = "Rest Form";
            this.btnRest.UseVisualStyleBackColor = true;
            this.btnRest.Click += new System.EventHandler(this.btnRest_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(257, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 50);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // bgEat
            // 
            this.bgEat.Controls.Add(this.rdbOut);
            this.bgEat.Controls.Add(this.rdbIn);
            this.bgEat.Location = new System.Drawing.Point(389, 368);
            this.bgEat.Name = "bgEat";
            this.bgEat.Size = new System.Drawing.Size(308, 61);
            this.bgEat.TabIndex = 20;
            this.bgEat.TabStop = false;
            this.bgEat.Text = "Where To Eat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Size :";
            // 
            // bgSamary
            // 
            this.bgSamary.Controls.Add(this.lbPrice);
            this.bgSamary.Controls.Add(this.label5);
            this.bgSamary.Controls.Add(this.lbEat);
            this.bgSamary.Controls.Add(this.label4);
            this.bgSamary.Controls.Add(this.lbCrust);
            this.bgSamary.Controls.Add(this.lbSize);
            this.bgSamary.Controls.Add(this.lbToppings);
            this.bgSamary.Controls.Add(this.label3);
            this.bgSamary.Controls.Add(this.label2);
            this.bgSamary.Controls.Add(this.label1);
            this.bgSamary.Location = new System.Drawing.Point(783, 125);
            this.bgSamary.Name = "bgSamary";
            this.bgSamary.Size = new System.Drawing.Size(249, 397);
            this.bgSamary.TabIndex = 22;
            this.bgSamary.TabStop = false;
            this.bgSamary.Text = "Order Summary";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.Green;
            this.lbPrice.Location = new System.Drawing.Point(81, 315);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(87, 72);
            this.lbPrice.TabIndex = 31;
            this.lbPrice.Text = "$0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 25);
            this.label5.TabIndex = 30;
            this.label5.Text = "Price";
            // 
            // lbEat
            // 
            this.lbEat.AutoSize = true;
            this.lbEat.Font = new System.Drawing.Font("Leelawadee UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEat.Location = new System.Drawing.Point(102, 252);
            this.lbEat.Name = "lbEat";
            this.lbEat.Size = new System.Drawing.Size(51, 23);
            this.lbEat.TabIndex = 29;
            this.lbEat.Text = "Eat In";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 25);
            this.label4.TabIndex = 28;
            this.label4.Text = "Where To Eat :";
            // 
            // lbCrust
            // 
            this.lbCrust.AutoSize = true;
            this.lbCrust.Font = new System.Drawing.Font("Leelawadee UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCrust.Location = new System.Drawing.Point(124, 184);
            this.lbCrust.Name = "lbCrust";
            this.lbCrust.Size = new System.Drawing.Size(84, 23);
            this.lbCrust.TabIndex = 27;
            this.lbCrust.Text = "Thin Crust";
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Font = new System.Drawing.Font("Leelawadee UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSize.Location = new System.Drawing.Point(68, 48);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(71, 23);
            this.lbSize.TabIndex = 26;
            this.lbSize.Text = "Meduim";
            // 
            // lbToppings
            // 
            this.lbToppings.AutoSize = true;
            this.lbToppings.Font = new System.Drawing.Font("Leelawadee UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbToppings.Location = new System.Drawing.Point(40, 131);
            this.lbToppings.MinimumSize = new System.Drawing.Size(200, 0);
            this.lbToppings.Name = "lbToppings";
            this.lbToppings.Size = new System.Drawing.Size(200, 23);
            this.lbToppings.TabIndex = 25;
            this.lbToppings.Text = "No Toppings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "Crust Type :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Toppings :";
            // 
            // bgToppings
            // 
            this.bgToppings.Controls.Add(this.chkOnion);
            this.bgToppings.Controls.Add(this.chkOlives);
            this.bgToppings.Controls.Add(this.chkGreen);
            this.bgToppings.Controls.Add(this.chkMushrooms);
            this.bgToppings.Controls.Add(this.chkTomatoes);
            this.bgToppings.Controls.Add(this.chkExtra);
            this.bgToppings.Location = new System.Drawing.Point(362, 125);
            this.bgToppings.Name = "bgToppings";
            this.bgToppings.Size = new System.Drawing.Size(373, 198);
            this.bgToppings.TabIndex = 23;
            this.bgToppings.TabStop = false;
            this.bgToppings.Text = "Toppings";
            // 
            // bgSize
            // 
            this.bgSize.Controls.Add(this.rdbLarg);
            this.bgSize.Controls.Add(this.rdbMeduim);
            this.bgSize.Controls.Add(this.rdbSmall);
            this.bgSize.Location = new System.Drawing.Point(77, 125);
            this.bgSize.Name = "bgSize";
            this.bgSize.Size = new System.Drawing.Size(222, 161);
            this.bgSize.TabIndex = 24;
            this.bgSize.TabStop = false;
            this.bgSize.Text = "Size";
            // 
            // rdbLarg
            // 
            this.rdbLarg.AutoSize = true;
            this.rdbLarg.Location = new System.Drawing.Point(28, 110);
            this.rdbLarg.Name = "rdbLarg";
            this.rdbLarg.Size = new System.Drawing.Size(70, 29);
            this.rdbLarg.TabIndex = 2;
            this.rdbLarg.TabStop = true;
            this.rdbLarg.Tag = "40";
            this.rdbLarg.Text = "Larg";
            this.rdbLarg.UseVisualStyleBackColor = true;
            this.rdbLarg.CheckedChanged += new System.EventHandler(this.rdbLarg_CheckedChanged);
            // 
            // rdbMeduim
            // 
            this.rdbMeduim.AutoSize = true;
            this.rdbMeduim.Location = new System.Drawing.Point(28, 75);
            this.rdbMeduim.Name = "rdbMeduim";
            this.rdbMeduim.Size = new System.Drawing.Size(103, 29);
            this.rdbMeduim.TabIndex = 1;
            this.rdbMeduim.TabStop = true;
            this.rdbMeduim.Tag = "30";
            this.rdbMeduim.Text = "Meduim";
            this.rdbMeduim.UseVisualStyleBackColor = true;
            this.rdbMeduim.CheckedChanged += new System.EventHandler(this.rdbMeduim_CheckedChanged);
            // 
            // rdbSmall
            // 
            this.rdbSmall.AutoSize = true;
            this.rdbSmall.Location = new System.Drawing.Point(28, 40);
            this.rdbSmall.Name = "rdbSmall";
            this.rdbSmall.Size = new System.Drawing.Size(79, 29);
            this.rdbSmall.TabIndex = 0;
            this.rdbSmall.TabStop = true;
            this.rdbSmall.Tag = "20";
            this.rdbSmall.Text = "Small";
            this.rdbSmall.UseVisualStyleBackColor = true;
            this.rdbSmall.CheckedChanged += new System.EventHandler(this.rdbSmall_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 534);
            this.Controls.Add(this.bgSize);
            this.Controls.Add(this.bgToppings);
            this.Controls.Add(this.bgSamary);
            this.Controls.Add(this.bgEat);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRest);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.bgCrust);
            this.Controls.Add(this.lbPizza);
            this.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.bgCrust.ResumeLayout(false);
            this.bgCrust.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bgEat.ResumeLayout(false);
            this.bgEat.PerformLayout();
            this.bgSamary.ResumeLayout(false);
            this.bgSamary.PerformLayout();
            this.bgToppings.ResumeLayout(false);
            this.bgToppings.PerformLayout();
            this.bgSize.ResumeLayout(false);
            this.bgSize.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPizza;
        private System.Windows.Forms.RadioButton rdbThin;
        private System.Windows.Forms.RadioButton rdbThink;
        private System.Windows.Forms.GroupBox bgCrust;
        private System.Windows.Forms.CheckBox chkExtra;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkGreen;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.RadioButton rdbIn;
        private System.Windows.Forms.RadioButton rdbOut;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnRest;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox bgEat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox bgSamary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox bgToppings;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Label lbToppings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox bgSize;
        private System.Windows.Forms.RadioButton rdbLarg;
        private System.Windows.Forms.RadioButton rdbMeduim;
        private System.Windows.Forms.RadioButton rdbSmall;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbEat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbCrust;
    }
}

