
namespace Yacht_Yard
{
    partial class Redacc
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
            System.Windows.Forms.Label accNameLabel;
            System.Windows.Forms.Label descriptionOfAccessoryLabel;
            System.Windows.Forms.Label inventoryLabel;
            System.Windows.Forms.Label orderBatchLabel;
            System.Windows.Forms.Label orderLevelLabel;
            System.Windows.Forms.Label partner_IDLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label vATLabel;
            this.accessoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accNameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionOfAccessoryTextBox = new System.Windows.Forms.TextBox();
            this.inventoryTextBox = new System.Windows.Forms.TextBox();
            this.orderBatchTextBox = new System.Windows.Forms.TextBox();
            this.orderLevelTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.vATTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            accNameLabel = new System.Windows.Forms.Label();
            descriptionOfAccessoryLabel = new System.Windows.Forms.Label();
            inventoryLabel = new System.Windows.Forms.Label();
            orderBatchLabel = new System.Windows.Forms.Label();
            orderLevelLabel = new System.Windows.Forms.Label();
            partner_IDLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            vATLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.accessoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // accessoryBindingSource
            // 
            this.accessoryBindingSource.DataSource = typeof(Yacht_Yard.Accessory);
            // 
            // accNameLabel
            // 
            accNameLabel.AutoSize = true;
            accNameLabel.Location = new System.Drawing.Point(94, 71);
            accNameLabel.Name = "accNameLabel";
            accNameLabel.Size = new System.Drawing.Size(60, 13);
            accNameLabel.TabIndex = 3;
            accNameLabel.Text = "Acc Name:";
            // 
            // accNameTextBox
            // 
            this.accNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accessoryBindingSource, "AccName", true));
            this.accNameTextBox.Location = new System.Drawing.Point(229, 68);
            this.accNameTextBox.Name = "accNameTextBox";
            this.accNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.accNameTextBox.TabIndex = 4;
            // 
            // descriptionOfAccessoryLabel
            // 
            descriptionOfAccessoryLabel.AutoSize = true;
            descriptionOfAccessoryLabel.Location = new System.Drawing.Point(94, 97);
            descriptionOfAccessoryLabel.Name = "descriptionOfAccessoryLabel";
            descriptionOfAccessoryLabel.Size = new System.Drawing.Size(129, 13);
            descriptionOfAccessoryLabel.TabIndex = 5;
            descriptionOfAccessoryLabel.Text = "Description Of Accessory:";
            // 
            // descriptionOfAccessoryTextBox
            // 
            this.descriptionOfAccessoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accessoryBindingSource, "DescriptionOfAccessory", true));
            this.descriptionOfAccessoryTextBox.Location = new System.Drawing.Point(229, 94);
            this.descriptionOfAccessoryTextBox.Name = "descriptionOfAccessoryTextBox";
            this.descriptionOfAccessoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.descriptionOfAccessoryTextBox.TabIndex = 6;
            // 
            // inventoryLabel
            // 
            inventoryLabel.AutoSize = true;
            inventoryLabel.Location = new System.Drawing.Point(94, 123);
            inventoryLabel.Name = "inventoryLabel";
            inventoryLabel.Size = new System.Drawing.Size(54, 13);
            inventoryLabel.TabIndex = 7;
            inventoryLabel.Text = "Inventory:";
            // 
            // inventoryTextBox
            // 
            this.inventoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accessoryBindingSource, "Inventory", true));
            this.inventoryTextBox.Location = new System.Drawing.Point(229, 120);
            this.inventoryTextBox.Name = "inventoryTextBox";
            this.inventoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.inventoryTextBox.TabIndex = 8;
            // 
            // orderBatchLabel
            // 
            orderBatchLabel.AutoSize = true;
            orderBatchLabel.Location = new System.Drawing.Point(94, 149);
            orderBatchLabel.Name = "orderBatchLabel";
            orderBatchLabel.Size = new System.Drawing.Size(67, 13);
            orderBatchLabel.TabIndex = 9;
            orderBatchLabel.Text = "Order Batch:";
            // 
            // orderBatchTextBox
            // 
            this.orderBatchTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accessoryBindingSource, "OrderBatch", true));
            this.orderBatchTextBox.Location = new System.Drawing.Point(229, 146);
            this.orderBatchTextBox.Name = "orderBatchTextBox";
            this.orderBatchTextBox.Size = new System.Drawing.Size(100, 20);
            this.orderBatchTextBox.TabIndex = 10;
            // 
            // orderLevelLabel
            // 
            orderLevelLabel.AutoSize = true;
            orderLevelLabel.Location = new System.Drawing.Point(94, 175);
            orderLevelLabel.Name = "orderLevelLabel";
            orderLevelLabel.Size = new System.Drawing.Size(65, 13);
            orderLevelLabel.TabIndex = 11;
            orderLevelLabel.Text = "Order Level:";
            // 
            // orderLevelTextBox
            // 
            this.orderLevelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accessoryBindingSource, "OrderLevel", true));
            this.orderLevelTextBox.Location = new System.Drawing.Point(229, 172);
            this.orderLevelTextBox.Name = "orderLevelTextBox";
            this.orderLevelTextBox.Size = new System.Drawing.Size(100, 20);
            this.orderLevelTextBox.TabIndex = 12;
            // 
            // partner_IDLabel
            // 
            partner_IDLabel.AutoSize = true;
            partner_IDLabel.Location = new System.Drawing.Point(94, 201);
            partner_IDLabel.Name = "partner_IDLabel";
            partner_IDLabel.Size = new System.Drawing.Size(58, 13);
            partner_IDLabel.TabIndex = 13;
            partner_IDLabel.Text = "Partner ID:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(94, 227);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(34, 13);
            priceLabel.TabIndex = 15;
            priceLabel.Text = "Price:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accessoryBindingSource, "Price", true));
            this.priceTextBox.Location = new System.Drawing.Point(229, 224);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 16;
            // 
            // vATLabel
            // 
            vATLabel.AutoSize = true;
            vATLabel.Location = new System.Drawing.Point(94, 253);
            vATLabel.Name = "vATLabel";
            vATLabel.Size = new System.Drawing.Size(31, 13);
            vATLabel.TabIndex = 17;
            vATLabel.Text = "VAT:";
            // 
            // vATTextBox
            // 
            this.vATTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accessoryBindingSource, "VAT", true));
            this.vATTextBox.Location = new System.Drawing.Point(229, 250);
            this.vATTextBox.Name = "vATTextBox";
            this.vATTextBox.Size = new System.Drawing.Size(100, 20);
            this.vATTextBox.TabIndex = 18;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(229, 198);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(166, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 30);
            this.button1.TabIndex = 56;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(12, 308);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 30);
            this.button2.TabIndex = 57;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Redacc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(453, 350);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(accNameLabel);
            this.Controls.Add(this.accNameTextBox);
            this.Controls.Add(descriptionOfAccessoryLabel);
            this.Controls.Add(this.descriptionOfAccessoryTextBox);
            this.Controls.Add(inventoryLabel);
            this.Controls.Add(this.inventoryTextBox);
            this.Controls.Add(orderBatchLabel);
            this.Controls.Add(this.orderBatchTextBox);
            this.Controls.Add(orderLevelLabel);
            this.Controls.Add(this.orderLevelTextBox);
            this.Controls.Add(partner_IDLabel);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(vATLabel);
            this.Controls.Add(this.vATTextBox);
            this.Name = "Redacc";
            this.Text = "Redacc";
            this.Load += new System.EventHandler(this.Redacc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accessoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource accessoryBindingSource;
        private System.Windows.Forms.TextBox accNameTextBox;
        private System.Windows.Forms.TextBox descriptionOfAccessoryTextBox;
        private System.Windows.Forms.TextBox inventoryTextBox;
        private System.Windows.Forms.TextBox orderBatchTextBox;
        private System.Windows.Forms.TextBox orderLevelTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox vATTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}