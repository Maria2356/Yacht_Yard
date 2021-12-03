﻿
namespace Yacht_Yard
{
    partial class Product
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bNazad = new System.Windows.Forms.Button();
            this.addProductBtn = new System.Windows.Forms.Button();
            this.changeProdBtn = new System.Windows.Forms.Button();
            this.deleteProdBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.accessoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionOfAccessoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBatchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partnerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partnerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accToBoatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accessoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accessoryIDDataGridViewTextBoxColumn,
            this.accNameDataGridViewTextBoxColumn,
            this.descriptionOfAccessoryDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.vATDataGridViewTextBoxColumn,
            this.inventoryDataGridViewTextBoxColumn,
            this.orderLevelDataGridViewTextBoxColumn,
            this.orderBatchDataGridViewTextBoxColumn,
            this.partnerIDDataGridViewTextBoxColumn,
            this.partnerDataGridViewTextBoxColumn,
            this.accToBoatsDataGridViewTextBoxColumn,
            this.orderDetailsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.accessoryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(844, 277);
            this.dataGridView1.TabIndex = 1;
            // 
            // bNazad
            // 
            this.bNazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bNazad.Location = new System.Drawing.Point(12, 435);
            this.bNazad.Name = "bNazad";
            this.bNazad.Size = new System.Drawing.Size(105, 48);
            this.bNazad.TabIndex = 3;
            this.bNazad.Text = "Назад";
            this.bNazad.UseVisualStyleBackColor = true;
            this.bNazad.Click += new System.EventHandler(this.bNazad_Click);
            // 
            // addProductBtn
            // 
            this.addProductBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addProductBtn.Location = new System.Drawing.Point(742, 346);
            this.addProductBtn.Name = "addProductBtn";
            this.addProductBtn.Size = new System.Drawing.Size(120, 41);
            this.addProductBtn.TabIndex = 19;
            this.addProductBtn.Text = "Добавить";
            this.addProductBtn.UseVisualStyleBackColor = true;
            this.addProductBtn.Click += new System.EventHandler(this.addProductBtn_Click);
            // 
            // changeProdBtn
            // 
            this.changeProdBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeProdBtn.Location = new System.Drawing.Point(742, 393);
            this.changeProdBtn.Name = "changeProdBtn";
            this.changeProdBtn.Size = new System.Drawing.Size(120, 41);
            this.changeProdBtn.TabIndex = 18;
            this.changeProdBtn.Text = "Изменить ";
            this.changeProdBtn.UseVisualStyleBackColor = true;
            this.changeProdBtn.Click += new System.EventHandler(this.changeProdBtn_Click);
            // 
            // deleteProdBtn
            // 
            this.deleteProdBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteProdBtn.Location = new System.Drawing.Point(742, 440);
            this.deleteProdBtn.Name = "deleteProdBtn";
            this.deleteProdBtn.Size = new System.Drawing.Size(120, 41);
            this.deleteProdBtn.TabIndex = 17;
            this.deleteProdBtn.Text = "Удалить ";
            this.deleteProdBtn.UseVisualStyleBackColor = true;
            this.deleteProdBtn.Click += new System.EventHandler(this.deleteProdBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(282, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 55);
            this.label1.TabIndex = 20;
            this.label1.Text = "Аксессуары";
            // 
            // accessoryIDDataGridViewTextBoxColumn
            // 
            this.accessoryIDDataGridViewTextBoxColumn.DataPropertyName = "Accessory_ID";
            this.accessoryIDDataGridViewTextBoxColumn.HeaderText = "Accessory_ID";
            this.accessoryIDDataGridViewTextBoxColumn.Name = "accessoryIDDataGridViewTextBoxColumn";
            // 
            // accNameDataGridViewTextBoxColumn
            // 
            this.accNameDataGridViewTextBoxColumn.DataPropertyName = "AccName";
            this.accNameDataGridViewTextBoxColumn.HeaderText = "AccName";
            this.accNameDataGridViewTextBoxColumn.Name = "accNameDataGridViewTextBoxColumn";
            // 
            // descriptionOfAccessoryDataGridViewTextBoxColumn
            // 
            this.descriptionOfAccessoryDataGridViewTextBoxColumn.DataPropertyName = "DescriptionOfAccessory";
            this.descriptionOfAccessoryDataGridViewTextBoxColumn.HeaderText = "DescriptionOfAccessory";
            this.descriptionOfAccessoryDataGridViewTextBoxColumn.Name = "descriptionOfAccessoryDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // vATDataGridViewTextBoxColumn
            // 
            this.vATDataGridViewTextBoxColumn.DataPropertyName = "VAT";
            this.vATDataGridViewTextBoxColumn.HeaderText = "VAT";
            this.vATDataGridViewTextBoxColumn.Name = "vATDataGridViewTextBoxColumn";
            // 
            // inventoryDataGridViewTextBoxColumn
            // 
            this.inventoryDataGridViewTextBoxColumn.DataPropertyName = "Inventory";
            this.inventoryDataGridViewTextBoxColumn.HeaderText = "Inventory";
            this.inventoryDataGridViewTextBoxColumn.Name = "inventoryDataGridViewTextBoxColumn";
            // 
            // orderLevelDataGridViewTextBoxColumn
            // 
            this.orderLevelDataGridViewTextBoxColumn.DataPropertyName = "OrderLevel";
            this.orderLevelDataGridViewTextBoxColumn.HeaderText = "OrderLevel";
            this.orderLevelDataGridViewTextBoxColumn.Name = "orderLevelDataGridViewTextBoxColumn";
            // 
            // orderBatchDataGridViewTextBoxColumn
            // 
            this.orderBatchDataGridViewTextBoxColumn.DataPropertyName = "OrderBatch";
            this.orderBatchDataGridViewTextBoxColumn.HeaderText = "OrderBatch";
            this.orderBatchDataGridViewTextBoxColumn.Name = "orderBatchDataGridViewTextBoxColumn";
            // 
            // partnerIDDataGridViewTextBoxColumn
            // 
            this.partnerIDDataGridViewTextBoxColumn.DataPropertyName = "Partner_ID";
            this.partnerIDDataGridViewTextBoxColumn.HeaderText = "Partner_ID";
            this.partnerIDDataGridViewTextBoxColumn.Name = "partnerIDDataGridViewTextBoxColumn";
            // 
            // partnerDataGridViewTextBoxColumn
            // 
            this.partnerDataGridViewTextBoxColumn.DataPropertyName = "Partner";
            this.partnerDataGridViewTextBoxColumn.HeaderText = "Partner";
            this.partnerDataGridViewTextBoxColumn.Name = "partnerDataGridViewTextBoxColumn";
            // 
            // accToBoatsDataGridViewTextBoxColumn
            // 
            this.accToBoatsDataGridViewTextBoxColumn.DataPropertyName = "AccToBoats";
            this.accToBoatsDataGridViewTextBoxColumn.HeaderText = "AccToBoats";
            this.accToBoatsDataGridViewTextBoxColumn.Name = "accToBoatsDataGridViewTextBoxColumn";
            // 
            // orderDetailsDataGridViewTextBoxColumn
            // 
            this.orderDetailsDataGridViewTextBoxColumn.DataPropertyName = "OrderDetails";
            this.orderDetailsDataGridViewTextBoxColumn.HeaderText = "OrderDetails";
            this.orderDetailsDataGridViewTextBoxColumn.Name = "orderDetailsDataGridViewTextBoxColumn";
            // 
            // accessoryBindingSource
            // 
            this.accessoryBindingSource.DataSource = typeof(Yacht_Yard.Accessory);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(880, 493);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addProductBtn);
            this.Controls.Add(this.changeProdBtn);
            this.Controls.Add(this.deleteProdBtn);
            this.Controls.Add(this.bNazad);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Product";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bNazad;
        private System.Windows.Forms.DataGridViewTextBoxColumn accessoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionOfAccessoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderBatchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partnerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partnerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accToBoatsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDetailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource accessoryBindingSource;
        private System.Windows.Forms.Button addProductBtn;
        private System.Windows.Forms.Button changeProdBtn;
        private System.Windows.Forms.Button deleteProdBtn;
        private System.Windows.Forms.Label label1;
    }
}