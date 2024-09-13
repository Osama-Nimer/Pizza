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
            this.rdbSmall = new System.Windows.Forms.RadioButton();
            this.rdbLarg = new System.Windows.Forms.RadioButton();
            this.rdbMeduim = new System.Windows.Forms.RadioButton();
            this.bgSize = new System.Windows.Forms.GroupBox();
            this.rdbThin = new System.Windows.Forms.RadioButton();
            this.rdbCrust = new System.Windows.Forms.RadioButton();
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
            this.bgSize.SuspendLayout();
            this.bgCrust.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.lbPizza.Click += new System.EventHandler(this.lbPizza_Click);
            // 
            // rdbSmall
            // 
            this.rdbSmall.AutoSize = true;
            this.rdbSmall.Location = new System.Drawing.Point(47, 39);
            this.rdbSmall.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbSmall.Name = "rdbSmall";
            this.rdbSmall.Size = new System.Drawing.Size(79, 29);
            this.rdbSmall.TabIndex = 1;
            this.rdbSmall.TabStop = true;
            this.rdbSmall.Text = "Small";
            this.rdbSmall.UseVisualStyleBackColor = true;
            // 
            // rdbLarg
            // 
            this.rdbLarg.AutoSize = true;
            this.rdbLarg.Location = new System.Drawing.Point(47, 105);
            this.rdbLarg.Margin = new System.Windows.Forms.Padding(2);
            this.rdbLarg.Name = "rdbLarg";
            this.rdbLarg.Size = new System.Drawing.Size(70, 29);
            this.rdbLarg.TabIndex = 3;
            this.rdbLarg.TabStop = true;
            this.rdbLarg.Text = "Larg";
            this.rdbLarg.UseVisualStyleBackColor = true;
            // 
            // rdbMeduim
            // 
            this.rdbMeduim.AutoSize = true;
            this.rdbMeduim.Location = new System.Drawing.Point(47, 72);
            this.rdbMeduim.Margin = new System.Windows.Forms.Padding(2);
            this.rdbMeduim.Name = "rdbMeduim";
            this.rdbMeduim.Size = new System.Drawing.Size(103, 29);
            this.rdbMeduim.TabIndex = 4;
            this.rdbMeduim.TabStop = true;
            this.rdbMeduim.Text = "Meduim";
            this.rdbMeduim.UseVisualStyleBackColor = true;
            // 
            // bgSize
            // 
            this.bgSize.Controls.Add(this.rdbMeduim);
            this.bgSize.Controls.Add(this.rdbSmall);
            this.bgSize.Controls.Add(this.rdbLarg);
            this.bgSize.Location = new System.Drawing.Point(77, 135);
            this.bgSize.Name = "bgSize";
            this.bgSize.Size = new System.Drawing.Size(179, 156);
            this.bgSize.TabIndex = 5;
            this.bgSize.TabStop = false;
            this.bgSize.Text = "Size";
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
            this.rdbThin.Text = "Thin Crust";
            this.rdbThin.UseVisualStyleBackColor = true;
            // 
            // rdbCrust
            // 
            this.rdbCrust.AutoSize = true;
            this.rdbCrust.Location = new System.Drawing.Point(27, 93);
            this.rdbCrust.Margin = new System.Windows.Forms.Padding(2);
            this.rdbCrust.Name = "rdbCrust";
            this.rdbCrust.Size = new System.Drawing.Size(130, 29);
            this.rdbCrust.TabIndex = 7;
            this.rdbCrust.TabStop = true;
            this.rdbCrust.Text = "Think Crust";
            this.rdbCrust.UseVisualStyleBackColor = true;
            // 
            // bgCrust
            // 
            this.bgCrust.Controls.Add(this.rdbThin);
            this.bgCrust.Controls.Add(this.rdbCrust);
            this.bgCrust.Location = new System.Drawing.Point(77, 350);
            this.bgCrust.Name = "bgCrust";
            this.bgCrust.Size = new System.Drawing.Size(200, 154);
            this.bgCrust.TabIndex = 8;
            this.bgCrust.TabStop = false;
            this.bgCrust.Text = "Crust Type";
            // 
            // chkExtra
            // 
            this.chkExtra.AutoSize = true;
            this.chkExtra.Location = new System.Drawing.Point(441, 154);
            this.chkExtra.Name = "chkExtra";
            this.chkExtra.Size = new System.Drawing.Size(133, 29);
            this.chkExtra.TabIndex = 9;
            this.chkExtra.Text = "Extra Chees";
            this.chkExtra.UseVisualStyleBackColor = true;
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.Location = new System.Drawing.Point(441, 262);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(118, 29);
            this.chkTomatoes.TabIndex = 10;
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Location = new System.Drawing.Point(441, 207);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(134, 29);
            this.chkMushrooms.TabIndex = 11;
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            // 
            // chkGreen
            // 
            this.chkGreen.AutoSize = true;
            this.chkGreen.Location = new System.Drawing.Point(603, 262);
            this.chkGreen.Name = "chkGreen";
            this.chkGreen.Size = new System.Drawing.Size(158, 29);
            this.chkGreen.TabIndex = 12;
            this.chkGreen.Text = "Green Peppers";
            this.chkGreen.UseVisualStyleBackColor = true;
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Location = new System.Drawing.Point(603, 208);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(86, 29);
            this.chkOlives.TabIndex = 13;
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(603, 154);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(86, 29);
            this.chkOnion.TabIndex = 14;
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            // 
            // rdbIn
            // 
            this.rdbIn.AutoSize = true;
            this.rdbIn.Location = new System.Drawing.Point(432, 422);
            this.rdbIn.Name = "rdbIn";
            this.rdbIn.Size = new System.Drawing.Size(82, 29);
            this.rdbIn.TabIndex = 15;
            this.rdbIn.TabStop = true;
            this.rdbIn.Text = "Eat In";
            this.rdbIn.UseVisualStyleBackColor = true;
            // 
            // rdbOut
            // 
            this.rdbOut.AutoSize = true;
            this.rdbOut.Location = new System.Drawing.Point(585, 422);
            this.rdbOut.Name = "rdbOut";
            this.rdbOut.Size = new System.Drawing.Size(110, 29);
            this.rdbOut.TabIndex = 16;
            this.rdbOut.TabStop = true;
            this.rdbOut.Text = "Tack Out";
            this.rdbOut.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(399, 519);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(123, 36);
            this.btnOrder.TabIndex = 17;
            this.btnOrder.Text = "Order Pizza";
            this.btnOrder.UseVisualStyleBackColor = true;
            // 
            // btnRest
            // 
            this.btnRest.Location = new System.Drawing.Point(575, 519);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(154, 36);
            this.btnRest.TabIndex = 18;
            this.btnRest.Text = "Rest Form";
            this.btnRest.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 580);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRest);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.rdbOut);
            this.Controls.Add(this.rdbIn);
            this.Controls.Add(this.chkOnion);
            this.Controls.Add(this.chkOlives);
            this.Controls.Add(this.chkGreen);
            this.Controls.Add(this.chkMushrooms);
            this.Controls.Add(this.chkTomatoes);
            this.Controls.Add(this.chkExtra);
            this.Controls.Add(this.bgCrust);
            this.Controls.Add(this.bgSize);
            this.Controls.Add(this.lbPizza);
            this.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.bgSize.ResumeLayout(false);
            this.bgSize.PerformLayout();
            this.bgCrust.ResumeLayout(false);
            this.bgCrust.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPizza;
        private System.Windows.Forms.RadioButton rdbSmall;
        private System.Windows.Forms.RadioButton rdbLarg;
        private System.Windows.Forms.RadioButton rdbMeduim;
        private System.Windows.Forms.GroupBox bgSize;
        private System.Windows.Forms.RadioButton rdbThin;
        private System.Windows.Forms.RadioButton rdbCrust;
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
    }
}

