using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using CNBC.DAL;
using CNBC_MONEY_2009.My;
using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Microsoft.VisualBasic.CompilerServices;

namespace CNBC_MONEY_2009;

[DesignerGenerated]
public class frmOptionsData : InheritedForm
{
	private static ArrayList __ENCList = new ArrayList();

	private IContainer components;

	[AccessedThroughProperty("ugOptionsData")]
	private UltraGrid _ugOptionsData;

	private string _ExchangeSymbol;

	internal virtual UltraGrid ugOptionsData
	{
		[DebuggerNonUserCode]
		get
		{
			return _ugOptionsData;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Expected O, but got Unknown
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Expected O, but got Unknown
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Expected O, but got Unknown
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Expected O, but got Unknown
			if (_ugOptionsData != null)
			{
				_ugOptionsData.remove_InitializeLayout(new InitializeLayoutEventHandler(ugOptionsData_InitializeLayout));
				_ugOptionsData.remove_InitializeRow(new InitializeRowEventHandler(ugOptionsData_InitializeRow));
			}
			_ugOptionsData = value;
			if (_ugOptionsData != null)
			{
				_ugOptionsData.add_InitializeLayout(new InitializeLayoutEventHandler(ugOptionsData_InitializeLayout));
				_ugOptionsData.add_InitializeRow(new InitializeRowEventHandler(ugOptionsData_InitializeRow));
			}
		}
	}

	public string ExchangeSymbol
	{
		get
		{
			return _ExchangeSymbol;
		}
		set
		{
			_ExchangeSymbol = value;
		}
	}

	[DebuggerNonUserCode]
	public frmOptionsData()
	{
		((Form)this).add_Load((EventHandler)frmOptionsData_Load);
		__ENCList.Add(new WeakReference(this));
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		if ((disposing && components != null) ? true : false)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_039c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a6: Expected O, but got Unknown
		UltraGridBand val = new UltraGridBand("Band 0", -1);
		Appearance val2 = new Appearance();
		Appearance val3 = new Appearance();
		Appearance val4 = new Appearance();
		Appearance val5 = new Appearance();
		Appearance val6 = new Appearance();
		Appearance val7 = new Appearance();
		ugOptionsData = new UltraGrid();
		((ISupportInitialize)grForm).BeginInit();
		((Control)grForm).SuspendLayout();
		((ISupportInitialize)ugOptionsData).BeginInit();
		((Control)this).SuspendLayout();
		((Control)grForm).get_Controls().Add((Control)(object)ugOptionsData);
		UltraGroupBox obj = grForm;
		Size size = new Size(988, 655);
		((Control)obj).set_Size(size);
		grForm.set_Text("OPTIONS DATA");
		((Control)grForm).get_Controls().SetChildIndex((Control)(object)CloseButton, 0);
		((Control)grForm).get_Controls().SetChildIndex((Control)(object)ugOptionsData, 0);
		UltraButton closeButton = CloseButton;
		Point location = new Point(948, 2);
		((Control)closeButton).set_Location(location);
		val2.set_BackColor(Color.Purple);
		val2.set_BackColor2(Color.Purple);
		val.get_Override().set_SelectedCellAppearance((AppearanceBase)(object)val2);
		((UltraGridBase)ugOptionsData).get_DisplayLayout().get_BandsSerializer().Add((object)val);
		((UltraGridBase)ugOptionsData).get_DisplayLayout().set_CaptionVisible((DefaultableBoolean)2);
		((UltraGridBase)ugOptionsData).get_DisplayLayout().set_MaxColScrollRegions(1);
		((UltraGridBase)ugOptionsData).get_DisplayLayout().set_MaxRowScrollRegions(1);
		((UltraGridBase)ugOptionsData).get_DisplayLayout().get_Override().set_AllowAddNew((AllowAddNew)6);
		((UltraGridBase)ugOptionsData).get_DisplayLayout().get_Override().set_AllowRowFiltering((DefaultableBoolean)2);
		val3.set_BackColor(Color.Transparent);
		((UltraGridBase)ugOptionsData).get_DisplayLayout().get_Override().set_CardAreaAppearance((AppearanceBase)(object)val3);
		((UltraGridBase)ugOptionsData).get_DisplayLayout().get_Override().set_FilterOperatorDefaultValue((FilterOperatorDefaultValue)11);
		((UltraGridBase)ugOptionsData).get_DisplayLayout().get_Override().set_FilterOperatorLocation((FilterOperatorLocation)3);
		((UltraGridBase)ugOptionsData).get_DisplayLayout().get_Override().set_FilterUIType((FilterUIType)2);
		val4.set_BackColor(Color.FromArgb(89, 135, 214));
		val4.set_BackColor2(Color.FromArgb(7, 59, 150));
		val4.set_BackGradientStyle((GradientStyle)2);
		val4.get_FontData().set_BoldAsString("True");
		val4.get_FontData().set_Name("Arial");
		val4.get_FontData().set_SizeInPoints(10f);
		val4.set_ForeColor(Color.White);
		val4.set_ThemedElementAlpha((Alpha)3);
		((UltraGridBase)ugOptionsData).get_DisplayLayout().get_Override().set_HeaderAppearance((AppearanceBase)(object)val4);
		((UltraGridBase)ugOptionsData).get_DisplayLayout().get_Override().set_HeaderClickAction((HeaderClickAction)2);
		val5.set_BackGradientAlignment((GradientAlignment)3);
		val5.set_BackGradientStyle((GradientStyle)2);
		val5.set_BackHatchStyle((BackHatchStyle)2);
		((UltraGridBase)ugOptionsData).get_DisplayLayout().get_Override().set_RowAppearance((AppearanceBase)(object)val5);
		val6.set_BackColor(Color.FromArgb(89, 135, 214));
		val6.set_BackColor2(Color.FromArgb(7, 59, 150));
		val6.set_BackGradientStyle((GradientStyle)2);
		((UltraGridBase)ugOptionsData).get_DisplayLayout().get_Override().set_RowSelectorAppearance((AppearanceBase)(object)val6);
		val7.set_BackColor(Color.FromArgb(251, 230, 148));
		val7.set_BackColor2(Color.FromArgb(238, 149, 21));
		val7.set_BackGradientStyle((GradientStyle)2);
		((UltraGridBase)ugOptionsData).get_DisplayLayout().get_Override().set_SelectedRowAppearance((AppearanceBase)(object)val7);
		((UltraGridBase)ugOptionsData).get_DisplayLayout().get_Override().set_SelectTypeRow((SelectType)2);
		((UltraGridBase)ugOptionsData).get_DisplayLayout().set_ScrollBounds((ScrollBounds)0);
		((Control)ugOptionsData).set_Dock((DockStyle)5);
		((Control)ugOptionsData).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		UltraGrid obj2 = ugOptionsData;
		location = new Point(3, 29);
		((Control)obj2).set_Location(location);
		((Control)ugOptionsData).set_Name("ugOptionsData");
		UltraGrid obj3 = ugOptionsData;
		size = new Size(982, 623);
		((Control)obj3).set_Size(size);
		((Control)ugOptionsData).set_TabIndex(6);
		SizeF autoScaleDimensions = new SizeF(7f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		size = new Size(988, 655);
		((Form)this).set_ClientSize(size);
		((Form)this).set_MaximizeBox(true);
		((Control)this).set_Name("frmOptionsData");
		((Form)this).set_Text("Options Single");
		((ISupportInitialize)grForm).EndInit();
		((Control)grForm).ResumeLayout(false);
		((ISupportInitialize)ugOptionsData).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void frmOptionsData_Load(object sender, EventArgs e)
	{
		BindControls();
	}

	private void btnClose_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void ugOptionsData_InitializeRow(object sender, InitializeRowEventArgs e)
	{
		checked
		{
			try
			{
				Color foreColor = Color.Black;
				int num = Conversions.ToInteger(e.get_Row().get_Cells().get_Item(4)
					.get_Value());
				if (num < 0)
				{
					foreColor = Color.Red;
				}
				else if (num > 0)
				{
					foreColor = Color.Green;
				}
				int num2 = 0;
				do
				{
					e.get_Row().get_Cells().get_Item(num2)
						.get_Appearance()
						.set_ForeColor(foreColor);
					num2++;
				}
				while (num2 <= 5);
				int num3 = Conversions.ToInteger(e.get_Row().get_Cells().get_Item(10)
					.get_Value());
				if (num3 < 0)
				{
					foreColor = Color.Red;
				}
				else if (num3 > 0)
				{
					foreColor = Color.Green;
				}
				num2 = 9;
				do
				{
					e.get_Row().get_Cells().get_Item(num2)
						.get_Appearance()
						.set_ForeColor(foreColor);
					num2++;
				}
				while (num2 <= 14);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ugOptionsData_InitializeLayout(object sender, InitializeLayoutEventArgs e)
	{
		checked
		{
			int num = ((DisposableObjectCollectionBase)e.get_Layout().get_Bands().get_Item(0)
				.get_Columns()).get_Count() - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				e.get_Layout().get_Bands().get_Item(0)
					.get_Columns()
					.get_Item(num2)
					.set_CellActivation((Activation)3);
				e.get_Layout().get_Bands().get_Item(0)
					.get_Override()
					.set_CellClickAction((CellClickAction)2);
				num2++;
			}
			((HeaderBase)e.get_Layout().get_Bands().get_Item(0)
				.get_Columns()
				.get_Item("CA_LASTPRICE")
				.get_Header()).set_Caption("LASTPRICE");
			((HeaderBase)e.get_Layout().get_Bands().get_Item(0)
				.get_Columns()
				.get_Item("CA_CHANGE")
				.get_Header()).set_Caption("NetChg");
			((HeaderBase)e.get_Layout().get_Bands().get_Item(0)
				.get_Columns()
				.get_Item("CA_VOLUME")
				.get_Header()).set_Caption("Vol");
			((HeaderBase)e.get_Layout().get_Bands().get_Item(0)
				.get_Columns()
				.get_Item("CA_OI")
				.get_Header()).set_Caption("OI");
			((HeaderBase)e.get_Layout().get_Bands().get_Item(0)
				.get_Columns()
				.get_Item("CA_CHANGE_OI")
				.get_Header()).set_Caption("OI_Netchg");
			((HeaderBase)e.get_Layout().get_Bands().get_Item(0)
				.get_Columns()
				.get_Item("CA_OPTIONTYPE")
				.get_Header()).set_Caption("CA");
			e.get_Layout().get_Bands().get_Item(0)
				.get_Columns()
				.get_Item("CA_OPTIONTYPE")
				.set_Width(30);
			e.get_Layout().get_Bands().get_Item(0)
				.get_Columns()
				.get_Item("PA_OPTIONTYPE")
				.set_Width(30);
			e.get_Layout().get_Bands().get_Item(0)
				.get_Columns()
				.get_Item("CA_CHANGE")
				.set_Width(60);
			e.get_Layout().get_Bands().get_Item(0)
				.get_Columns()
				.get_Item("PA_CHANGE")
				.set_Width(60);
			e.get_Layout().get_Bands().get_Item(0)
				.get_Columns()
				.get_Item("CA_OI")
				.set_Width(65);
			e.get_Layout().get_Bands().get_Item(0)
				.get_Columns()
				.get_Item("PA_OI")
				.set_Width(65);
			e.get_Layout().get_Bands().get_Item(0)
				.get_Columns()
				.get_Item("ExchangeSymbol")
				.set_Hidden(true);
			((HeaderBase)e.get_Layout().get_Bands().get_Item(0)
				.get_Columns()
				.get_Item("PA_LASTPRICE")
				.get_Header()).set_Caption("LASTPRICE");
			((HeaderBase)e.get_Layout().get_Bands().get_Item(0)
				.get_Columns()
				.get_Item("PA_CHANGE")
				.get_Header()).set_Caption("NetChg");
			((HeaderBase)e.get_Layout().get_Bands().get_Item(0)
				.get_Columns()
				.get_Item("PA_VOLUME")
				.get_Header()).set_Caption("Vol");
			((HeaderBase)e.get_Layout().get_Bands().get_Item(0)
				.get_Columns()
				.get_Item("PA_OI")
				.get_Header()).set_Caption("OI");
			((HeaderBase)e.get_Layout().get_Bands().get_Item(0)
				.get_Columns()
				.get_Item("PA_CHANGE_OI")
				.get_Header()).set_Caption("OI_Netchg");
			((HeaderBase)e.get_Layout().get_Bands().get_Item(0)
				.get_Columns()
				.get_Item("PA_OPTIONTYPE")
				.get_Header()).set_Caption("PA");
		}
	}

	private void BindControls()
	{
		Money_Splash money_Splash = new Money_Splash();
		try
		{
			((Control)money_Splash).Show();
			((Control)money_Splash).Refresh();
			grForm.set_Text(ExchangeSymbol);
			string text = "";
			text = " SELECT DISTINCT  CA_LASTPRICE=ISNULL((SELECT lastprice FROM [options_transaction_data] WHERE [exchangesymbol]=A.[exchangesymbol] AND [expiry_date]=a.[expiry_date] AND [strike_price]=a.[strike_price] AND [option_type] in ('CA','CE')),'0') ,CA_Change=ISNULL((SELECT lastprice-[CLOSE] FROM [options_transaction_data] WHERE [exchangesymbol]=A.[exchangesymbol] AND [expiry_date]=a.[expiry_date] AND [strike_price]=a.[strike_price] AND [option_type] in ('CA','CE')),'0') ,CA_Volume=ISNULL((SELECT [volume] FROM [options_transaction_data] WHERE [exchangesymbol]=A.[exchangesymbol] AND [expiry_date]=a.[expiry_date] AND [strike_price]=a.[strike_price] AND [option_type] in ('CA','CE')),'0') ,CA_OI=ISNULL((SELECT [open_interest] FROM [options_transaction_data] WHERE [exchangesymbol]=A.[exchangesymbol] AND [expiry_date]=a.[expiry_date] AND [strike_price]=a.[strike_price] AND [option_type] in ('CA','CE')),'0') ,CA_Change_OI=ISNULL((SELECT [open_interest]-[prevday_open_interest] FROM [options_transaction_data] WHERE [exchangesymbol]=A.[exchangesymbol] AND [expiry_date]=a.[expiry_date] AND [strike_price]=a.[strike_price] AND [option_type] in ('CA','CE')),'0') ,'CA' AS CA_OPTIONTYPE , ExchangeSymbol  , Strike_Price  , Expiry_Date  ,'PA' AS PA_OPTIONTYPE ,PA_Change_OI=ISNULL((SELECT [open_interest]-[prevday_open_interest] FROM [options_transaction_data] WHERE [exchangesymbol]=A.[exchangesymbol] AND [expiry_date]=a.[expiry_date] AND [strike_price]=a.[strike_price] AND [option_type] in ('PA','PE')),'0') ,PA_LASTPRICE=ISNULL((SELECT lastprice FROM [options_transaction_data] WHERE [exchangesymbol]=A.[exchangesymbol] AND [expiry_date]=a.[expiry_date] AND [strike_price]=a.[strike_price] AND [option_type] in ('PA','PE')),'0') ,PA_Change=ISNULL((SELECT lastprice-[CLOSE] FROM [options_transaction_data] WHERE [exchangesymbol]=A.[exchangesymbol] AND [expiry_date]=a.[expiry_date] AND [strike_price]=a.[strike_price] AND [option_type] in ('PA','PE')),'0') ,PA_Volume=ISNULL((SELECT [volume] FROM [options_transaction_data] WHERE [exchangesymbol]=A.[exchangesymbol] AND [expiry_date]=a.[expiry_date] AND [strike_price]=a.[strike_price] AND [option_type] in ('PA','PE')),'0') ,PA_OI=ISNULL((SELECT [open_interest] FROM [options_transaction_data] WHERE [exchangesymbol]=A.[exchangesymbol] AND [expiry_date]=a.[expiry_date] AND [strike_price]=a.[strike_price] AND [option_type] in ('PA','PE')),'0') FROM [options_transaction_data] A WHERE [exchangesymbol]='" + ExchangeSymbol + "'  ORDER BY [expiry_date]";
			DataTable dataTable = new DataTable();
			dataTable = SqlHelper.ExecuteDataset(MySettingsProperty.Settings.strCON, CommandType.Text, text).Tables[0];
			((UltraGridBase)ugOptionsData).set_DataSource((object)dataTable);
			((Form)money_Splash).Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			((Form)money_Splash).Close();
			ProjectData.ClearProjectError();
		}
	}
}
