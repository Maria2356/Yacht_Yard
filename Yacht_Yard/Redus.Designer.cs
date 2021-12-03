
namespace Yacht_Yard
{
    partial class Redus
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
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label dateOfBirthLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label familyNameLabel;
            System.Windows.Forms.Label fistNameLabel;
            System.Windows.Forms.Label iDDocumentNameLabel;
            System.Windows.Forms.Label iDNumberLabel;
            System.Windows.Forms.Label organisationNameLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label customer_IDLabel;
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.dateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.familyNameTextBox = new System.Windows.Forms.TextBox();
            this.fistNameTextBox = new System.Windows.Forms.TextBox();
            this.iDDocumentNameTextBox = new System.Windows.Forms.TextBox();
            this.iDNumberTextBox = new System.Windows.Forms.TextBox();
            this.organisationNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.customer_IDTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            addressLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            dateOfBirthLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            familyNameLabel = new System.Windows.Forms.Label();
            fistNameLabel = new System.Windows.Forms.Label();
            iDDocumentNameLabel = new System.Windows.Forms.Label();
            iDNumberLabel = new System.Windows.Forms.Label();
            organisationNameLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            customer_IDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(Yacht_Yard.Customer);
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(84, 132);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 1;
            addressLabel.Text = "Address:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(191, 129);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(200, 20);
            this.addressTextBox.TabIndex = 2;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(84, 158);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(27, 13);
            cityLabel.TabIndex = 3;
            cityLabel.Text = "City:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(191, 155);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(200, 20);
            this.cityTextBox.TabIndex = 4;
            // 
            // dateOfBirthLabel
            // 
            dateOfBirthLabel.AutoSize = true;
            dateOfBirthLabel.Location = new System.Drawing.Point(84, 185);
            dateOfBirthLabel.Name = "dateOfBirthLabel";
            dateOfBirthLabel.Size = new System.Drawing.Size(71, 13);
            dateOfBirthLabel.TabIndex = 7;
            dateOfBirthLabel.Text = "Date Of Birth:";
            // 
            // dateOfBirthDateTimePicker
            // 
            this.dateOfBirthDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.customerBindingSource, "DateOfBirth", true));
            this.dateOfBirthDateTimePicker.Location = new System.Drawing.Point(191, 181);
            this.dateOfBirthDateTimePicker.Name = "dateOfBirthDateTimePicker";
            this.dateOfBirthDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateOfBirthDateTimePicker.TabIndex = 8;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(84, 210);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(34, 13);
            emailLabel.TabIndex = 9;
            emailLabel.Text = "email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(191, 207);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 20);
            this.emailTextBox.TabIndex = 10;
            // 
            // familyNameLabel
            // 
            familyNameLabel.AutoSize = true;
            familyNameLabel.Location = new System.Drawing.Point(84, 236);
            familyNameLabel.Name = "familyNameLabel";
            familyNameLabel.Size = new System.Drawing.Size(70, 13);
            familyNameLabel.TabIndex = 11;
            familyNameLabel.Text = "Family Name:";
            // 
            // familyNameTextBox
            // 
            this.familyNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "FamilyName", true));
            this.familyNameTextBox.Location = new System.Drawing.Point(191, 233);
            this.familyNameTextBox.Name = "familyNameTextBox";
            this.familyNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.familyNameTextBox.TabIndex = 12;
            // 
            // fistNameLabel
            // 
            fistNameLabel.AutoSize = true;
            fistNameLabel.Location = new System.Drawing.Point(84, 262);
            fistNameLabel.Name = "fistNameLabel";
            fistNameLabel.Size = new System.Drawing.Size(57, 13);
            fistNameLabel.TabIndex = 13;
            fistNameLabel.Text = "Fist Name:";
            // 
            // fistNameTextBox
            // 
            this.fistNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "FistName", true));
            this.fistNameTextBox.Location = new System.Drawing.Point(191, 259);
            this.fistNameTextBox.Name = "fistNameTextBox";
            this.fistNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.fistNameTextBox.TabIndex = 14;
            // 
            // iDDocumentNameLabel
            // 
            iDDocumentNameLabel.AutoSize = true;
            iDDocumentNameLabel.Location = new System.Drawing.Point(84, 288);
            iDDocumentNameLabel.Name = "iDDocumentNameLabel";
            iDDocumentNameLabel.Size = new System.Drawing.Size(101, 13);
            iDDocumentNameLabel.TabIndex = 15;
            iDDocumentNameLabel.Text = "IDDocument Name:";
            // 
            // iDDocumentNameTextBox
            // 
            this.iDDocumentNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "IDDocumentName", true));
            this.iDDocumentNameTextBox.Location = new System.Drawing.Point(191, 285);
            this.iDDocumentNameTextBox.Name = "iDDocumentNameTextBox";
            this.iDDocumentNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.iDDocumentNameTextBox.TabIndex = 16;
            // 
            // iDNumberLabel
            // 
            iDNumberLabel.AutoSize = true;
            iDNumberLabel.Location = new System.Drawing.Point(84, 314);
            iDNumberLabel.Name = "iDNumberLabel";
            iDNumberLabel.Size = new System.Drawing.Size(58, 13);
            iDNumberLabel.TabIndex = 17;
            iDNumberLabel.Text = "IDNumber:";
            // 
            // iDNumberTextBox
            // 
            this.iDNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "IDNumber", true));
            this.iDNumberTextBox.Location = new System.Drawing.Point(191, 311);
            this.iDNumberTextBox.Name = "iDNumberTextBox";
            this.iDNumberTextBox.Size = new System.Drawing.Size(200, 20);
            this.iDNumberTextBox.TabIndex = 18;
            // 
            // organisationNameLabel
            // 
            organisationNameLabel.AutoSize = true;
            organisationNameLabel.Location = new System.Drawing.Point(84, 340);
            organisationNameLabel.Name = "organisationNameLabel";
            organisationNameLabel.Size = new System.Drawing.Size(100, 13);
            organisationNameLabel.TabIndex = 19;
            organisationNameLabel.Text = "Organisation Name:";
            // 
            // organisationNameTextBox
            // 
            this.organisationNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "OrganisationName", true));
            this.organisationNameTextBox.Location = new System.Drawing.Point(191, 337);
            this.organisationNameTextBox.Name = "organisationNameTextBox";
            this.organisationNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.organisationNameTextBox.TabIndex = 20;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(84, 366);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(41, 13);
            phoneLabel.TabIndex = 21;
            phoneLabel.Text = "Phone:";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(191, 363);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(200, 20);
            this.phoneTextBox.TabIndex = 22;
            // 
            // customer_IDTextBox
            // 
            this.customer_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Customer_ID", true));
            this.customer_IDTextBox.Location = new System.Drawing.Point(191, 103);
            this.customer_IDTextBox.Name = "customer_IDTextBox";
            this.customer_IDTextBox.Size = new System.Drawing.Size(200, 20);
            this.customer_IDTextBox.TabIndex = 6;
            // 
            // customer_IDLabel
            // 
            customer_IDLabel.AutoSize = true;
            customer_IDLabel.Location = new System.Drawing.Point(84, 106);
            customer_IDLabel.Name = "customer_IDLabel";
            customer_IDLabel.Size = new System.Drawing.Size(68, 13);
            customer_IDLabel.TabIndex = 5;
            customer_IDLabel.Text = "Customer ID:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(12, 416);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 30);
            this.button2.TabIndex = 59;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(182, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 30);
            this.button1.TabIndex = 58;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Redus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(471, 458);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(customer_IDLabel);
            this.Controls.Add(this.customer_IDTextBox);
            this.Controls.Add(dateOfBirthLabel);
            this.Controls.Add(this.dateOfBirthDateTimePicker);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(familyNameLabel);
            this.Controls.Add(this.familyNameTextBox);
            this.Controls.Add(fistNameLabel);
            this.Controls.Add(this.fistNameTextBox);
            this.Controls.Add(iDDocumentNameLabel);
            this.Controls.Add(this.iDDocumentNameTextBox);
            this.Controls.Add(iDNumberLabel);
            this.Controls.Add(this.iDNumberTextBox);
            this.Controls.Add(organisationNameLabel);
            this.Controls.Add(this.organisationNameTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Name = "Redus";
            this.Text = "Redus";
            this.Load += new System.EventHandler(this.Redus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.DateTimePicker dateOfBirthDateTimePicker;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox familyNameTextBox;
        private System.Windows.Forms.TextBox fistNameTextBox;
        private System.Windows.Forms.TextBox iDDocumentNameTextBox;
        private System.Windows.Forms.TextBox iDNumberTextBox;
        private System.Windows.Forms.TextBox organisationNameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox customer_IDTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}