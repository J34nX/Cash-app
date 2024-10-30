namespace CashApp
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
            this.ComputeBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ItemsTB = new System.Windows.Forms.TextBox();
            this.PriceTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DiscuntTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.QuantityTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AmountLB = new System.Windows.Forms.Label();
            this.PaymentTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ChangeLB = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SumbitBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ComputeBT
            // 
            this.ComputeBT.Location = new System.Drawing.Point(172, 115);
            this.ComputeBT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComputeBT.Name = "ComputeBT";
            this.ComputeBT.Size = new System.Drawing.Size(74, 28);
            this.ComputeBT.TabIndex = 0;
            this.ComputeBT.Text = "Compute";
            this.ComputeBT.UseVisualStyleBackColor = true;
            this.ComputeBT.Click += new System.EventHandler(this.ComputeBT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Item :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ItemsTB
            // 
            this.ItemsTB.Location = new System.Drawing.Point(14, 42);
            this.ItemsTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ItemsTB.Name = "ItemsTB";
            this.ItemsTB.Size = new System.Drawing.Size(217, 26);
            this.ItemsTB.TabIndex = 3;
            // 
            // PriceTB
            // 
            this.PriceTB.Location = new System.Drawing.Point(94, 79);
            this.PriceTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PriceTB.Name = "PriceTB";
            this.PriceTB.Size = new System.Drawing.Size(137, 26);
            this.PriceTB.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Price :";
            // 
            // DiscuntTB
            // 
            this.DiscuntTB.Location = new System.Drawing.Point(241, 42);
            this.DiscuntTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DiscuntTB.Name = "DiscuntTB";
            this.DiscuntTB.Size = new System.Drawing.Size(176, 26);
            this.DiscuntTB.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(241, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Discount (%)";
            // 
            // QuantityTB
            // 
            this.QuantityTB.Location = new System.Drawing.Point(357, 81);
            this.QuantityTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.QuantityTB.Name = "QuantityTB";
            this.QuantityTB.Size = new System.Drawing.Size(60, 26);
            this.QuantityTB.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(241, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Quantitiy :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 148);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Total amount :";
            // 
            // AmountLB
            // 
            this.AmountLB.AutoSize = true;
            this.AmountLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountLB.Location = new System.Drawing.Point(186, 148);
            this.AmountLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AmountLB.Name = "AmountLB";
            this.AmountLB.Size = new System.Drawing.Size(98, 24);
            this.AmountLB.TabIndex = 11;
            this.AmountLB.Text = "<Amount>";
            // 
            // PaymentTB
            // 
            this.PaymentTB.Location = new System.Drawing.Point(217, 187);
            this.PaymentTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PaymentTB.Name = "PaymentTB";
            this.PaymentTB.Size = new System.Drawing.Size(118, 26);
            this.PaymentTB.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 188);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(204, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Payment Received :";
            // 
            // ChangeLB
            // 
            this.ChangeLB.AutoSize = true;
            this.ChangeLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeLB.Location = new System.Drawing.Point(185, 231);
            this.ChangeLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ChangeLB.Name = "ChangeLB";
            this.ChangeLB.Size = new System.Drawing.Size(99, 24);
            this.ChangeLB.TabIndex = 15;
            this.ChangeLB.Text = "<Change>";
            this.ChangeLB.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(90, 231);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 24);
            this.label9.TabIndex = 14;
            this.label9.Text = "Change :";
            // 
            // SumbitBT
            // 
            this.SumbitBT.Location = new System.Drawing.Point(343, 184);
            this.SumbitBT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SumbitBT.Name = "SumbitBT";
            this.SumbitBT.Size = new System.Drawing.Size(74, 28);
            this.SumbitBT.TabIndex = 16;
            this.SumbitBT.Text = "Submit";
            this.SumbitBT.UseVisualStyleBackColor = true;
            this.SumbitBT.Click += new System.EventHandler(this.SumbitBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 267);
            this.Controls.Add(this.SumbitBT);
            this.Controls.Add(this.ChangeLB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PaymentTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AmountLB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.QuantityTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DiscuntTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PriceTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ItemsTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComputeBT);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ComputeBT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ItemsTB;
        private System.Windows.Forms.TextBox PriceTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DiscuntTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox QuantityTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label AmountLB;
        private System.Windows.Forms.TextBox PaymentTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ChangeLB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button SumbitBT;
    }
}

