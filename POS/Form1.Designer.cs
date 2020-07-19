namespace POS
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
            this.cmb_items = new System.Windows.Forms.ComboBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_sub = new System.Windows.Forms.TextBox();
            this.txt_dis = new System.Windows.Forms.TextBox();
            this.txt_net = new System.Windows.Forms.TextBox();
            this.txt_paid = new System.Windows.Forms.TextBox();
            this.txt_bal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_items
            // 
            this.cmb_items.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_items.FormattingEnabled = true;
            this.cmb_items.Location = new System.Drawing.Point(318, 37);
            this.cmb_items.Name = "cmb_items";
            this.cmb_items.Size = new System.Drawing.Size(269, 28);
            this.cmb_items.TabIndex = 0;
            this.cmb_items.SelectedIndexChanged += new System.EventHandler(this.cmb_items_SelectedIndexChanged);
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(53, 201);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(114, 22);
            this.txt_price.TabIndex = 2;
            this.txt_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_qty
            // 
            this.txt_qty.Location = new System.Drawing.Point(241, 201);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(115, 22);
            this.txt_qty.TabIndex = 3;
            this.txt_qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_qty.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(444, 201);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(112, 22);
            this.txt_total.TabIndex = 4;
            this.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(249, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Qty";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(453, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(608, 191);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(105, 32);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(608, 241);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(105, 32);
            this.btn_remove.TabIndex = 9;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.button2_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(53, 299);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(660, 242);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 230;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Price";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Qty";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total";
            this.columnHeader4.Width = 100;
            // 
            // txt_sub
            // 
            this.txt_sub.Location = new System.Drawing.Point(97, 577);
            this.txt_sub.Name = "txt_sub";
            this.txt_sub.Size = new System.Drawing.Size(112, 22);
            this.txt_sub.TabIndex = 11;
            this.txt_sub.Text = "0";
            this.txt_sub.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_dis
            // 
            this.txt_dis.Location = new System.Drawing.Point(341, 577);
            this.txt_dis.Name = "txt_dis";
            this.txt_dis.Size = new System.Drawing.Size(112, 22);
            this.txt_dis.TabIndex = 12;
            this.txt_dis.Text = "0";
            this.txt_dis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_net
            // 
            this.txt_net.Location = new System.Drawing.Point(630, 575);
            this.txt_net.Name = "txt_net";
            this.txt_net.Size = new System.Drawing.Size(112, 22);
            this.txt_net.TabIndex = 13;
            this.txt_net.Text = "0";
            this.txt_net.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_paid
            // 
            this.txt_paid.Location = new System.Drawing.Point(630, 618);
            this.txt_paid.Name = "txt_paid";
            this.txt_paid.Size = new System.Drawing.Size(112, 22);
            this.txt_paid.TabIndex = 14;
            this.txt_paid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_bal
            // 
            this.txt_bal.Location = new System.Drawing.Point(630, 659);
            this.txt_bal.Name = "txt_bal";
            this.txt_bal.Size = new System.Drawing.Size(112, 22);
            this.txt_bal.TabIndex = 15;
            this.txt_bal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 582);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Sub Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(249, 582);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Discount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(511, 580);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Net Amount";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(511, 623);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Paid Amount";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(511, 664);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Balance";
            // 
            // btn_print
            // 
            this.btn_print.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.Location = new System.Drawing.Point(42, 640);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(105, 41);
            this.btn_print.TabIndex = 21;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = true;
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(192, 640);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(105, 41);
            this.btn_clear.TabIndex = 22;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(348, 640);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(105, 41);
            this.btn_save.TabIndex = 23;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 708);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_bal);
            this.Controls.Add(this.txt_paid);
            this.Controls.Add(this.txt_net);
            this.Controls.Add(this.txt_dis);
            this.Controls.Add(this.txt_sub);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.txt_qty);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_items);
            this.Name = "Form1";
            this.Text = "Point of Sales";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_items;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_qty;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txt_sub;
        private System.Windows.Forms.TextBox txt_dis;
        private System.Windows.Forms.TextBox txt_net;
        private System.Windows.Forms.TextBox txt_paid;
        private System.Windows.Forms.TextBox txt_bal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_save;
    }
}

