
namespace PHARMACY
{
    partial class Machine
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
            this.BtnConnect = new System.Windows.Forms.Button();
            this.LblPort = new System.Windows.Forms.Label();
            this.TxtPort = new System.Windows.Forms.TextBox();
            this.TxtRate = new System.Windows.Forms.TextBox();
            this.TxtMessage = new System.Windows.Forms.TextBox();
            this.BtnSend = new System.Windows.Forms.Button();
            this.LblBaudrate = new System.Windows.Forms.Label();
            this.LblProduct = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnConnect
            // 
            this.BtnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConnect.Location = new System.Drawing.Point(211, 118);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(123, 30);
            this.BtnConnect.TabIndex = 0;
            this.BtnConnect.Text = "Connect";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // LblPort
            // 
            this.LblPort.AutoSize = true;
            this.LblPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPort.Location = new System.Drawing.Point(24, 30);
            this.LblPort.Name = "LblPort";
            this.LblPort.Size = new System.Drawing.Size(47, 25);
            this.LblPort.TabIndex = 1;
            this.LblPort.Text = "Port";
            // 
            // TxtPort
            // 
            this.TxtPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPort.Location = new System.Drawing.Point(95, 28);
            this.TxtPort.Name = "TxtPort";
            this.TxtPort.Size = new System.Drawing.Size(130, 27);
            this.TxtPort.TabIndex = 2;
            // 
            // TxtRate
            // 
            this.TxtRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRate.Location = new System.Drawing.Point(373, 30);
            this.TxtRate.Name = "TxtRate";
            this.TxtRate.Size = new System.Drawing.Size(145, 27);
            this.TxtRate.TabIndex = 3;
            // 
            // TxtMessage
            // 
            this.TxtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMessage.Location = new System.Drawing.Point(126, 183);
            this.TxtMessage.Multiline = true;
            this.TxtMessage.Name = "TxtMessage";
            this.TxtMessage.Size = new System.Drawing.Size(324, 110);
            this.TxtMessage.TabIndex = 4;
            // 
            // BtnSend
            // 
            this.BtnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSend.Location = new System.Drawing.Point(242, 320);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(75, 43);
            this.BtnSend.TabIndex = 5;
            this.BtnSend.Text = "Send";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // LblBaudrate
            // 
            this.LblBaudrate.AutoSize = true;
            this.LblBaudrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBaudrate.Location = new System.Drawing.Point(253, 30);
            this.LblBaudrate.Name = "LblBaudrate";
            this.LblBaudrate.Size = new System.Drawing.Size(103, 25);
            this.LblBaudrate.TabIndex = 6;
            this.LblBaudrate.Text = "Baud Rate";
            // 
            // LblProduct
            // 
            this.LblProduct.AutoSize = true;
            this.LblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProduct.Location = new System.Drawing.Point(24, 183);
            this.LblProduct.Name = "LblProduct";
            this.LblProduct.Size = new System.Drawing.Size(79, 25);
            this.LblProduct.TabIndex = 7;
            this.LblProduct.Text = "Product";
            // 
            // Machine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 386);
            this.Controls.Add(this.LblProduct);
            this.Controls.Add(this.LblBaudrate);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.TxtMessage);
            this.Controls.Add(this.TxtRate);
            this.Controls.Add(this.TxtPort);
            this.Controls.Add(this.LblPort);
            this.Controls.Add(this.BtnConnect);
            this.Name = "Machine";
            this.Text = "Machine";
            this.Load += new System.EventHandler(this.Machine_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.Label LblPort;
        private System.Windows.Forms.TextBox TxtPort;
        private System.Windows.Forms.TextBox TxtRate;
        private System.Windows.Forms.TextBox TxtMessage;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.Label LblBaudrate;
        private System.Windows.Forms.Label LblProduct;
    }
}