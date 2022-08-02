﻿namespace MyPhoneList
{
    partial class ImportedPhoneForm
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
            System.Windows.Forms.Label departmentLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            System.Windows.Forms.Label mailStopLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportedPhoneForm));
            System.Windows.Forms.Label officeLocationLabel;
            System.Windows.Forms.Label uvuPhoneDirectoryIdLabel;
            this.uVUPhoneNumsDataSet = new MyPhoneList.UVUPhoneNumsDataSet();
            this.uvuPhoneDirectoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uvuPhoneDirectoryTableAdapter = new MyPhoneList.UVUPhoneNumsDataSetTableAdapters.UvuPhoneDirectoryTableAdapter();
            this.tableAdapterManager = new MyPhoneList.UVUPhoneNumsDataSetTableAdapters.TableAdapterManager();
            this.uvuPhoneDirectoryBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.uvuPhoneDirectoryBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.departmentTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.mailStopTextBox = new System.Windows.Forms.TextBox();
            this.officeLocationTextBox = new System.Windows.Forms.TextBox();
            this.uvuPhoneDirectoryIdLabel1 = new System.Windows.Forms.Label();
            departmentLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            mailStopLabel = new System.Windows.Forms.Label();
            officeLocationLabel = new System.Windows.Forms.Label();
            uvuPhoneDirectoryIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uVUPhoneNumsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uvuPhoneDirectoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uvuPhoneDirectoryBindingNavigator)).BeginInit();
            this.uvuPhoneDirectoryBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // departmentLabel
            // 
            departmentLabel.AutoSize = true;
            departmentLabel.Location = new System.Drawing.Point(45, 116);
            departmentLabel.Name = "departmentLabel";
            departmentLabel.Size = new System.Drawing.Size(80, 16);
            departmentLabel.TabIndex = 3;
            departmentLabel.Text = "Department:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new System.Drawing.Point(25, 141);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(100, 16);
            phoneNumberLabel.TabIndex = 5;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // mailStopLabel
            // 
            mailStopLabel.AutoSize = true;
            mailStopLabel.Location = new System.Drawing.Point(59, 166);
            mailStopLabel.Name = "mailStopLabel";
            mailStopLabel.Size = new System.Drawing.Size(66, 16);
            mailStopLabel.TabIndex = 7;
            mailStopLabel.Text = "Mail Stop:";
            // 
            // uVUPhoneNumsDataSet
            // 
            this.uVUPhoneNumsDataSet.DataSetName = "UVUPhoneNumsDataSet";
            this.uVUPhoneNumsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uvuPhoneDirectoryBindingSource
            // 
            this.uvuPhoneDirectoryBindingSource.DataMember = "UvuPhoneDirectory";
            this.uvuPhoneDirectoryBindingSource.DataSource = this.uVUPhoneNumsDataSet;
            // 
            // uvuPhoneDirectoryTableAdapter
            // 
            this.uvuPhoneDirectoryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = MyPhoneList.UVUPhoneNumsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UvuPhoneDirectoryTableAdapter = this.uvuPhoneDirectoryTableAdapter;
            // 
            // uvuPhoneDirectoryBindingNavigator
            // 
            this.uvuPhoneDirectoryBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.uvuPhoneDirectoryBindingNavigator.BindingSource = this.uvuPhoneDirectoryBindingSource;
            this.uvuPhoneDirectoryBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.uvuPhoneDirectoryBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.uvuPhoneDirectoryBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.uvuPhoneDirectoryBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.uvuPhoneDirectoryBindingNavigatorSaveItem});
            this.uvuPhoneDirectoryBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.uvuPhoneDirectoryBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.uvuPhoneDirectoryBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.uvuPhoneDirectoryBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.uvuPhoneDirectoryBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.uvuPhoneDirectoryBindingNavigator.Name = "uvuPhoneDirectoryBindingNavigator";
            this.uvuPhoneDirectoryBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.uvuPhoneDirectoryBindingNavigator.Size = new System.Drawing.Size(685, 27);
            this.uvuPhoneDirectoryBindingNavigator.TabIndex = 0;
            this.uvuPhoneDirectoryBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // uvuPhoneDirectoryBindingNavigatorSaveItem
            // 
            this.uvuPhoneDirectoryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uvuPhoneDirectoryBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("uvuPhoneDirectoryBindingNavigatorSaveItem.Image")));
            this.uvuPhoneDirectoryBindingNavigatorSaveItem.Name = "uvuPhoneDirectoryBindingNavigatorSaveItem";
            this.uvuPhoneDirectoryBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.uvuPhoneDirectoryBindingNavigatorSaveItem.Text = "Save Data";
            this.uvuPhoneDirectoryBindingNavigatorSaveItem.Click += new System.EventHandler(this.uvuPhoneDirectoryBindingNavigatorSaveItem_Click_2);
            // 
            // departmentTextBox
            // 
            this.departmentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uvuPhoneDirectoryBindingSource, "Department", true));
            this.departmentTextBox.Location = new System.Drawing.Point(172, 113);
            this.departmentTextBox.Name = "departmentTextBox";
            this.departmentTextBox.Size = new System.Drawing.Size(144, 22);
            this.departmentTextBox.TabIndex = 4;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uvuPhoneDirectoryBindingSource, "PhoneNumber", true));
            this.phoneNumberTextBox.Location = new System.Drawing.Point(172, 138);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(144, 22);
            this.phoneNumberTextBox.TabIndex = 6;
            this.phoneNumberTextBox.TextChanged += new System.EventHandler(this.phoneNumberTextBox_TextChanged);
            // 
            // mailStopTextBox
            // 
            this.mailStopTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uvuPhoneDirectoryBindingSource, "MailStop", true));
            this.mailStopTextBox.Location = new System.Drawing.Point(172, 166);
            this.mailStopTextBox.Name = "mailStopTextBox";
            this.mailStopTextBox.Size = new System.Drawing.Size(144, 22);
            this.mailStopTextBox.TabIndex = 8;
            // 
            // officeLocationTextBox
            // 
            this.officeLocationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uvuPhoneDirectoryBindingSource, "OfficeLocation", true));
            this.officeLocationTextBox.Location = new System.Drawing.Point(172, 194);
            this.officeLocationTextBox.Name = "officeLocationTextBox";
            this.officeLocationTextBox.Size = new System.Drawing.Size(144, 22);
            this.officeLocationTextBox.TabIndex = 10;
            // 
            // officeLocationLabel
            // 
            officeLocationLabel.AutoSize = true;
            officeLocationLabel.Location = new System.Drawing.Point(43, 194);
            officeLocationLabel.Name = "officeLocationLabel";
            officeLocationLabel.Size = new System.Drawing.Size(98, 16);
            officeLocationLabel.TabIndex = 9;
            officeLocationLabel.Text = "Office Location:";
            // 
            // uvuPhoneDirectoryIdLabel
            // 
            uvuPhoneDirectoryIdLabel.AutoSize = true;
            uvuPhoneDirectoryIdLabel.Location = new System.Drawing.Point(25, 85);
            uvuPhoneDirectoryIdLabel.Name = "uvuPhoneDirectoryIdLabel";
            uvuPhoneDirectoryIdLabel.Size = new System.Drawing.Size(147, 16);
            uvuPhoneDirectoryIdLabel.TabIndex = 10;
            uvuPhoneDirectoryIdLabel.Text = "Uvu Phone Directory Id:";
            // 
            // uvuPhoneDirectoryIdLabel1
            // 
            this.uvuPhoneDirectoryIdLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uvuPhoneDirectoryBindingSource, "UvuPhoneDirectoryId", true));
            this.uvuPhoneDirectoryIdLabel1.Location = new System.Drawing.Point(178, 85);
            this.uvuPhoneDirectoryIdLabel1.Name = "uvuPhoneDirectoryIdLabel1";
            this.uvuPhoneDirectoryIdLabel1.Size = new System.Drawing.Size(100, 23);
            this.uvuPhoneDirectoryIdLabel1.TabIndex = 11;
            this.uvuPhoneDirectoryIdLabel1.Text = "label1";
            this.uvuPhoneDirectoryIdLabel1.Click += new System.EventHandler(this.uvuPhoneDirectoryIdLabel1_Click_2);
            // 
            // ImportedPhoneForm
            // 
            this.ClientSize = new System.Drawing.Size(685, 285);
            this.Controls.Add(uvuPhoneDirectoryIdLabel);
            this.Controls.Add(this.uvuPhoneDirectoryIdLabel1);
            this.Controls.Add(officeLocationLabel);
            this.Controls.Add(this.officeLocationTextBox);
            this.Controls.Add(mailStopLabel);
            this.Controls.Add(this.mailStopTextBox);
            this.Controls.Add(phoneNumberLabel);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(departmentLabel);
            this.Controls.Add(this.departmentTextBox);
            this.Controls.Add(this.uvuPhoneDirectoryBindingNavigator);
            this.Name = "ImportedPhoneForm";
            ((System.ComponentModel.ISupportInitialize)(this.uVUPhoneNumsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uvuPhoneDirectoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uvuPhoneDirectoryBindingNavigator)).EndInit();
            this.uvuPhoneDirectoryBindingNavigator.ResumeLayout(false);
            this.uvuPhoneDirectoryBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private UVUPhoneNumsDataSet uVUPhoneNumsDataSet;
        private System.Windows.Forms.BindingSource uvuPhoneDirectoryBindingSource;
        private UVUPhoneNumsDataSetTableAdapters.UvuPhoneDirectoryTableAdapter uvuPhoneDirectoryTableAdapter;
        private UVUPhoneNumsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator uvuPhoneDirectoryBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton uvuPhoneDirectoryBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox departmentTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox mailStopTextBox;
        private System.Windows.Forms.TextBox officeLocationTextBox;
        private System.Windows.Forms.Label uvuPhoneDirectoryIdLabel1;
    }
}