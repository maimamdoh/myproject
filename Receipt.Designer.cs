
namespace PHARMACY
{
    partial class Receipt
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
            this.components = new System.ComponentModel.Container();
            this.DGView = new System.Windows.Forms.DataGridView();
            this.receiptClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.TxtProduct = new System.Windows.Forms.TextBox();
            this.TxtCash = new System.Windows.Forms.TextBox();
            this.Cash = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtQuantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.BtnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptClassBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DGView
            // 
            this.DGView.AutoGenerateColumns = false;
            this.DGView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGView.DataSource = this.receiptClassBindingSource;
            this.DGView.Location = new System.Drawing.Point(12, 12);
            this.DGView.Name = "DGView";
            this.DGView.RowHeadersWidth = 51;
            this.DGView.RowTemplate.Height = 24;
            this.DGView.Size = new System.Drawing.Size(729, 261);
            this.DGView.TabIndex = 0;
            this.DGView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Name";
            // 
            // TxtProduct
            // 
            this.TxtProduct.Location = new System.Drawing.Point(153, 325);
            this.TxtProduct.Name = "TxtProduct";
            this.TxtProduct.Size = new System.Drawing.Size(261, 22);
            this.TxtProduct.TabIndex = 2;
            // 
            // TxtCash
            // 
            this.TxtCash.Location = new System.Drawing.Point(314, 384);
            this.TxtCash.Name = "TxtCash";
            this.TxtCash.Size = new System.Drawing.Size(100, 22);
            this.TxtCash.TabIndex = 4;
            // 
            // Cash
            // 
            this.Cash.AutoSize = true;
            this.Cash.Location = new System.Drawing.Point(268, 384);
            this.Cash.Name = "Cash";
            this.Cash.Size = new System.Drawing.Size(40, 17);
            this.Cash.TabIndex = 3;
            this.Cash.Text = "Cash";
            // 
            // TxtTotal
            // 
            this.TxtTotal.Location = new System.Drawing.Point(153, 384);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(100, 22);
            this.TxtTotal.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total";
            // 
            // TxtPrice
            // 
            this.TxtPrice.Location = new System.Drawing.Point(641, 325);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(100, 22);
            this.TxtPrice.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(587, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Price";
            // 
            // TxtQuantity
            // 
            this.TxtQuantity.Location = new System.Drawing.Point(496, 325);
            this.TxtQuantity.Name = "TxtQuantity";
            this.TxtQuantity.Size = new System.Drawing.Size(85, 22);
            this.TxtQuantity.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(429, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Quantity";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(448, 384);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 39);
            this.BtnAdd.TabIndex = 11;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.Location = new System.Drawing.Point(549, 384);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(75, 39);
            this.BtnRemove.TabIndex = 12;
            this.BtnRemove.Text = "Remove";
            this.BtnRemove.UseVisualStyleBackColor = true;
            // 
            // BtnPrint
            // 
            this.BtnPrint.Location = new System.Drawing.Point(666, 384);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(75, 39);
            this.BtnPrint.TabIndex = 13;
            this.BtnPrint.Text = "Print";
            this.BtnPrint.UseVisualStyleBackColor = true;
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TxtQuantity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtCash);
            this.Controls.Add(this.Cash);
            this.Controls.Add(this.TxtProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGView);
            this.Name = "Receipt";
            this.Text = "Receipt";
            this.Load += new System.EventHandler(this.Receipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptClassBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtProduct;
        private System.Windows.Forms.TextBox TxtCash;
        private System.Windows.Forms.Label Cash;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource receiptClassBindingSource;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button BtnPrint;
    }
}