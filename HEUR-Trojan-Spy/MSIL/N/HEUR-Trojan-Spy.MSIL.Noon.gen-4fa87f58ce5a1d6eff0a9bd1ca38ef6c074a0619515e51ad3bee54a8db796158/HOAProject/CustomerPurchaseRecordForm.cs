using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using HOAProject.My;
using Microsoft.VisualBasic.CompilerServices;

namespace HOAProject;

[DesignerGenerated]
public class CustomerPurchaseRecordForm : Form
{
	private IContainer components;

	internal virtual DataGridView CustomerPurchases
	{
		[CompilerGenerated]
		get
		{
			return _CustomerPurchases;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			DataGridViewCellEventHandler val = new DataGridViewCellEventHandler(Customerpruchaserecordgrid_CellContentClick);
			DataGridView customerPurchases = _CustomerPurchases;
			if (customerPurchases != null)
			{
				customerPurchases.remove_CellContentClick(val);
			}
			_CustomerPurchases = value;
			customerPurchases = _CustomerPurchases;
			if (customerPurchases != null)
			{
				customerPurchases.add_CellContentClick(val);
			}
		}
	}

	[field: AccessedThroughProperty("CustomerPurchaseRecordBindingSource")]
	internal virtual BindingSource CustomerPurchaseRecordBindingSource
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CustomernameDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn CustomernameDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CUSADDRESSDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn CUSADDRESSDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CusContactDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn CusContactDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CusEmailDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn CusEmailDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("SalesPersonnameDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn SalesPersonnameDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PurchasedateDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn PurchasedateDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("SellPriceDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn SellPriceDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button BackButton
	{
		[CompilerGenerated]
		get
		{
			return _BackButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = BackButton_Click;
			Button backButton = _BackButton;
			if (backButton != null)
			{
				((Control)backButton).remove_Click(eventHandler);
			}
			_BackButton = value;
			backButton = _BackButton;
			if (backButton != null)
			{
				((Control)backButton).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("TotalSalesCountToolStrip")]
	internal virtual ToolStrip TotalSalesCountToolStrip
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CustomerPurchaseRecordBindingSource1")]
	internal virtual BindingSource CustomerPurchaseRecordBindingSource1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public CustomerPurchaseRecordForm()
	{
		((Form)this).add_Load((EventHandler)CustomerPurchaseRecordForm_Load);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0444: Unknown result type (might be due to invalid IL or missing references)
		//IL_057c: Unknown result type (might be due to invalid IL or missing references)
		components = new Container();
		CustomerPurchases = new DataGridView();
		CustomernameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		CUSADDRESSDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		CusContactDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		CusEmailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		SalesPersonnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		PurchasedateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		SellPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		CustomerPurchaseRecordBindingSource1 = new BindingSource(components);
		BackButton = new Button();
		TotalSalesCountToolStrip = new ToolStrip();
		CustomerPurchaseRecordBindingSource = new BindingSource(components);
		((ISupportInitialize)CustomerPurchases).BeginInit();
		((ISupportInitialize)CustomerPurchaseRecordBindingSource1).BeginInit();
		((ISupportInitialize)CustomerPurchaseRecordBindingSource).BeginInit();
		((Control)this).SuspendLayout();
		CustomerPurchases.set_AutoGenerateColumns(false);
		CustomerPurchases.set_AutoSizeColumnsMode((DataGridViewAutoSizeColumnsMode)6);
		CustomerPurchases.set_AutoSizeRowsMode((DataGridViewAutoSizeRowsMode)7);
		CustomerPurchases.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		CustomerPurchases.get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[7]
		{
			(DataGridViewColumn)CustomernameDataGridViewTextBoxColumn,
			(DataGridViewColumn)CUSADDRESSDataGridViewTextBoxColumn,
			(DataGridViewColumn)CusContactDataGridViewTextBoxColumn,
			(DataGridViewColumn)CusEmailDataGridViewTextBoxColumn,
			(DataGridViewColumn)SalesPersonnameDataGridViewTextBoxColumn,
			(DataGridViewColumn)PurchasedateDataGridViewTextBoxColumn,
			(DataGridViewColumn)SellPriceDataGridViewTextBoxColumn
		});
		CustomerPurchases.set_DataSource((object)CustomerPurchaseRecordBindingSource1);
		((Control)CustomerPurchases).set_Location(new Point(28, 47));
		((Control)CustomerPurchases).set_Margin(new Padding(2, 2, 2, 2));
		((Control)CustomerPurchases).set_Name("CustomerPurchases");
		CustomerPurchases.set_RowHeadersVisible(false);
		CustomerPurchases.set_RowHeadersWidth(51);
		CustomerPurchases.get_RowTemplate().set_Height(24);
		((Control)CustomerPurchases).set_Size(new Size(707, 153));
		((Control)CustomerPurchases).set_TabIndex(0);
		((DataGridViewColumn)CustomernameDataGridViewTextBoxColumn).set_DataPropertyName("Customer_name");
		((DataGridViewColumn)CustomernameDataGridViewTextBoxColumn).set_HeaderText("Customer_name");
		((DataGridViewColumn)CustomernameDataGridViewTextBoxColumn).set_MinimumWidth(6);
		((DataGridViewColumn)CustomernameDataGridViewTextBoxColumn).set_Name("CustomernameDataGridViewTextBoxColumn");
		((DataGridViewColumn)CustomernameDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)CustomernameDataGridViewTextBoxColumn).set_Width(108);
		((DataGridViewColumn)CUSADDRESSDataGridViewTextBoxColumn).set_DataPropertyName("CUS_ADDRESS");
		((DataGridViewColumn)CUSADDRESSDataGridViewTextBoxColumn).set_HeaderText("CUS_ADDRESS");
		((DataGridViewColumn)CUSADDRESSDataGridViewTextBoxColumn).set_MinimumWidth(6);
		((DataGridViewColumn)CUSADDRESSDataGridViewTextBoxColumn).set_Name("CUSADDRESSDataGridViewTextBoxColumn");
		((DataGridViewColumn)CUSADDRESSDataGridViewTextBoxColumn).set_Width(112);
		((DataGridViewColumn)CusContactDataGridViewTextBoxColumn).set_DataPropertyName("Cus_Contact");
		((DataGridViewColumn)CusContactDataGridViewTextBoxColumn).set_HeaderText("Cus_Contact");
		((DataGridViewColumn)CusContactDataGridViewTextBoxColumn).set_MinimumWidth(6);
		((DataGridViewColumn)CusContactDataGridViewTextBoxColumn).set_Name("CusContactDataGridViewTextBoxColumn");
		((DataGridViewColumn)CusContactDataGridViewTextBoxColumn).set_Width(93);
		((DataGridViewColumn)CusEmailDataGridViewTextBoxColumn).set_DataPropertyName("Cus_Email");
		((DataGridViewColumn)CusEmailDataGridViewTextBoxColumn).set_HeaderText("Cus_Email");
		((DataGridViewColumn)CusEmailDataGridViewTextBoxColumn).set_MinimumWidth(6);
		((DataGridViewColumn)CusEmailDataGridViewTextBoxColumn).set_Name("CusEmailDataGridViewTextBoxColumn");
		((DataGridViewColumn)CusEmailDataGridViewTextBoxColumn).set_Width(81);
		((DataGridViewColumn)SalesPersonnameDataGridViewTextBoxColumn).set_DataPropertyName("SalesPerson_name");
		((DataGridViewColumn)SalesPersonnameDataGridViewTextBoxColumn).set_HeaderText("SalesPerson_name");
		((DataGridViewColumn)SalesPersonnameDataGridViewTextBoxColumn).set_MinimumWidth(6);
		((DataGridViewColumn)SalesPersonnameDataGridViewTextBoxColumn).set_Name("SalesPersonnameDataGridViewTextBoxColumn");
		((DataGridViewColumn)SalesPersonnameDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)SalesPersonnameDataGridViewTextBoxColumn).set_Width(123);
		((DataGridViewColumn)PurchasedateDataGridViewTextBoxColumn).set_DataPropertyName("Purchase_date");
		((DataGridViewColumn)PurchasedateDataGridViewTextBoxColumn).set_HeaderText("Purchase_date");
		((DataGridViewColumn)PurchasedateDataGridViewTextBoxColumn).set_MinimumWidth(6);
		((DataGridViewColumn)PurchasedateDataGridViewTextBoxColumn).set_Name("PurchasedateDataGridViewTextBoxColumn");
		((DataGridViewColumn)PurchasedateDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)PurchasedateDataGridViewTextBoxColumn).set_Width(104);
		((DataGridViewColumn)SellPriceDataGridViewTextBoxColumn).set_DataPropertyName("Sell_Price");
		((DataGridViewColumn)SellPriceDataGridViewTextBoxColumn).set_HeaderText("Sell_Price");
		((DataGridViewColumn)SellPriceDataGridViewTextBoxColumn).set_MinimumWidth(6);
		((DataGridViewColumn)SellPriceDataGridViewTextBoxColumn).set_Name("SellPriceDataGridViewTextBoxColumn");
		((DataGridViewColumn)SellPriceDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)SellPriceDataGridViewTextBoxColumn).set_Width(79);
		CustomerPurchaseRecordBindingSource1.set_DataMember("Customer_Purchase_Record");
		((Control)BackButton).set_Location(new Point(258, 306));
		((Control)BackButton).set_Margin(new Padding(2, 2, 2, 2));
		((Control)BackButton).set_Name("BackButton");
		((Control)BackButton).set_Size(new Size(68, 19));
		((Control)BackButton).set_TabIndex(1);
		((ButtonBase)BackButton).set_Text("&Back");
		((ButtonBase)BackButton).set_UseVisualStyleBackColor(true);
		TotalSalesCountToolStrip.set_ImageScalingSize(new Size(20, 20));
		((Control)TotalSalesCountToolStrip).set_Location(new Point(0, 0));
		((Control)TotalSalesCountToolStrip).set_Name("TotalSalesCountToolStrip");
		((Control)TotalSalesCountToolStrip).set_Size(new Size(746, 25));
		((Control)TotalSalesCountToolStrip).set_TabIndex(5);
		((Control)TotalSalesCountToolStrip).set_Text("TotalSalesCountToolStrip");
		CustomerPurchaseRecordBindingSource.set_DataMember("Customer_Purchase_Record");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(746, 366));
		((Control)this).get_Controls().Add((Control)(object)TotalSalesCountToolStrip);
		((Control)this).get_Controls().Add((Control)(object)BackButton);
		((Control)this).get_Controls().Add((Control)(object)CustomerPurchases);
		((Form)this).set_Margin(new Padding(2, 2, 2, 2));
		((Control)this).set_Name("CustomerPurchaseRecordForm");
		((Form)this).set_Text("Customer Purchase Records");
		((ISupportInitialize)CustomerPurchases).EndInit();
		((ISupportInitialize)CustomerPurchaseRecordBindingSource1).EndInit();
		((ISupportInitialize)CustomerPurchaseRecordBindingSource).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void CustomerPurchaseRecordForm_Load(object sender, EventArgs e)
	{
	}

	private void BackButton_Click(object sender, EventArgs e)
	{
		((Control)this).Hide();
		((Control)MyProject.Forms.WelcomePage).Show();
	}

	private void Customerpruchaserecordgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}
}
