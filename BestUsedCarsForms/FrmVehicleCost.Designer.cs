namespace BestUsedCarsForms
{
    partial class FrmVehicleCost
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
            this.lblVIN = new System.Windows.Forms.Label();
            this.lblPurchaseCost = new System.Windows.Forms.Label();
            this.lblRepairCost = new System.Windows.Forms.Label();
            this.lblPrepFees = new System.Windows.Forms.Label();
            this.tbVIN = new System.Windows.Forms.TextBox();
            this.tbPurchaseCost = new System.Windows.Forms.TextBox();
            this.tbRepairCost = new System.Windows.Forms.TextBox();
            this.tbPrepFees = new System.Windows.Forms.TextBox();
            this.lblOtherFees = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.tbOtherFees = new System.Windows.Forms.TextBox();
            this.tbTotalCost = new System.Windows.Forms.TextBox();
            this.btnUpdateCost = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblVIN
            // 
            this.lblVIN.AutoSize = true;
            this.lblVIN.Location = new System.Drawing.Point(41, 74);
            this.lblVIN.Name = "lblVIN";
            this.lblVIN.Size = new System.Drawing.Size(28, 13);
            this.lblVIN.TabIndex = 0;
            this.lblVIN.Text = "VIN:";
            // 
            // lblPurchaseCost
            // 
            this.lblPurchaseCost.AutoSize = true;
            this.lblPurchaseCost.Location = new System.Drawing.Point(79, 113);
            this.lblPurchaseCost.Name = "lblPurchaseCost";
            this.lblPurchaseCost.Size = new System.Drawing.Size(76, 13);
            this.lblPurchaseCost.TabIndex = 1;
            this.lblPurchaseCost.Text = "Purchase Cost";
            // 
            // lblRepairCost
            // 
            this.lblRepairCost.AutoSize = true;
            this.lblRepairCost.Location = new System.Drawing.Point(79, 148);
            this.lblRepairCost.Name = "lblRepairCost";
            this.lblRepairCost.Size = new System.Drawing.Size(62, 13);
            this.lblRepairCost.TabIndex = 2;
            this.lblRepairCost.Text = "Repair Cost";
            // 
            // lblPrepFees
            // 
            this.lblPrepFees.AutoSize = true;
            this.lblPrepFees.Location = new System.Drawing.Point(79, 187);
            this.lblPrepFees.Name = "lblPrepFees";
            this.lblPrepFees.Size = new System.Drawing.Size(55, 13);
            this.lblPrepFees.TabIndex = 3;
            this.lblPrepFees.Text = "Prep Fees";
            // 
            // tbVIN
            // 
            this.tbVIN.Location = new System.Drawing.Point(82, 67);
            this.tbVIN.Name = "tbVIN";
            this.tbVIN.Size = new System.Drawing.Size(171, 20);
            this.tbVIN.TabIndex = 4;
            // 
            // tbPurchaseCost
            // 
            this.tbPurchaseCost.Location = new System.Drawing.Point(153, 106);
            this.tbPurchaseCost.Name = "tbPurchaseCost";
            this.tbPurchaseCost.Size = new System.Drawing.Size(100, 20);
            this.tbPurchaseCost.TabIndex = 5;
            // 
            // tbRepairCost
            // 
            this.tbRepairCost.Location = new System.Drawing.Point(152, 140);
            this.tbRepairCost.Name = "tbRepairCost";
            this.tbRepairCost.Size = new System.Drawing.Size(100, 20);
            this.tbRepairCost.TabIndex = 6;
            // 
            // tbPrepFees
            // 
            this.tbPrepFees.Location = new System.Drawing.Point(151, 179);
            this.tbPrepFees.Name = "tbPrepFees";
            this.tbPrepFees.Size = new System.Drawing.Size(100, 20);
            this.tbPrepFees.TabIndex = 7;
            // 
            // lblOtherFees
            // 
            this.lblOtherFees.AutoSize = true;
            this.lblOtherFees.Location = new System.Drawing.Point(82, 219);
            this.lblOtherFees.Name = "lblOtherFees";
            this.lblOtherFees.Size = new System.Drawing.Size(59, 13);
            this.lblOtherFees.TabIndex = 8;
            this.lblOtherFees.Text = "Other Fees";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(82, 260);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(55, 13);
            this.lblTotalCost.TabIndex = 9;
            this.lblTotalCost.Text = "Total Cost";
            // 
            // tbOtherFees
            // 
            this.tbOtherFees.Location = new System.Drawing.Point(152, 219);
            this.tbOtherFees.Name = "tbOtherFees";
            this.tbOtherFees.Size = new System.Drawing.Size(100, 20);
            this.tbOtherFees.TabIndex = 10;
            // 
            // tbTotalCost
            // 
            this.tbTotalCost.Location = new System.Drawing.Point(150, 260);
            this.tbTotalCost.Name = "tbTotalCost";
            this.tbTotalCost.Size = new System.Drawing.Size(100, 20);
            this.tbTotalCost.TabIndex = 11;
            // 
            // btnUpdateCost
            // 
            this.btnUpdateCost.Location = new System.Drawing.Point(153, 320);
            this.btnUpdateCost.Name = "btnUpdateCost";
            this.btnUpdateCost.Size = new System.Drawing.Size(100, 35);
            this.btnUpdateCost.TabIndex = 12;
            this.btnUpdateCost.Text = "Update Cost";
            this.btnUpdateCost.UseVisualStyleBackColor = true;
            this.btnUpdateCost.Click += new System.EventHandler(this.btnUpdateCost_Click);
            // 
            // FrmVehicleCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 450);
            this.Controls.Add(this.btnUpdateCost);
            this.Controls.Add(this.tbTotalCost);
            this.Controls.Add(this.tbOtherFees);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblOtherFees);
            this.Controls.Add(this.tbPrepFees);
            this.Controls.Add(this.tbRepairCost);
            this.Controls.Add(this.tbPurchaseCost);
            this.Controls.Add(this.tbVIN);
            this.Controls.Add(this.lblPrepFees);
            this.Controls.Add(this.lblRepairCost);
            this.Controls.Add(this.lblPurchaseCost);
            this.Controls.Add(this.lblVIN);
            this.Name = "FrmVehicleCost";
            this.Text = "Vehicle Cost Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVIN;
        private System.Windows.Forms.Label lblPurchaseCost;
        private System.Windows.Forms.Label lblRepairCost;
        private System.Windows.Forms.Label lblPrepFees;
        private System.Windows.Forms.TextBox tbVIN;
        private System.Windows.Forms.TextBox tbPurchaseCost;
        private System.Windows.Forms.TextBox tbRepairCost;
        private System.Windows.Forms.TextBox tbPrepFees;
        private System.Windows.Forms.Label lblOtherFees;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.TextBox tbOtherFees;
        private System.Windows.Forms.TextBox tbTotalCost;
        private System.Windows.Forms.Button btnUpdateCost;
    }
}