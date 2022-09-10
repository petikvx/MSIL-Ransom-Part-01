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
using Infragistics.Win.UltraWinGrid;
using Microsoft.VisualBasic.CompilerServices;

namespace CNBC_MONEY_2009;

[DesignerGenerated]
public class frmBlockDeals : Form
{
	private static ArrayList __ENCList = new ArrayList();

	private IContainer components;

	[AccessedThroughProperty("ugBlockDeals")]
	private UltraGrid _ugBlockDeals;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	internal virtual UltraGrid ugBlockDeals
	{
		[DebuggerNonUserCode]
		get
		{
			return _ugBlockDeals;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Expected O, but got Unknown
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Expected O, but got Unknown
			if (_ugBlockDeals != null)
			{
				_ugBlockDeals.remove_InitializeLayout(new InitializeLayoutEventHandler(ugBlockDeals_InitializeLayout));
			}
			_ugBlockDeals = value;
			if (_ugBlockDeals != null)
			{
				_ugBlockDeals.add_InitializeLayout(new InitializeLayoutEventHandler(ugBlockDeals_InitializeLayout));
			}
		}
	}

	internal virtual Timer Timer1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_Timer1 != null)
			{
				_Timer1.remove_Tick((EventHandler)Timer1_Tick);
			}
			_Timer1 = value;
			if (_Timer1 != null)
			{
				_Timer1.add_Tick((EventHandler)Timer1_Tick);
			}
		}
	}

	[DebuggerNonUserCode]
	public frmBlockDeals()
	{
		((Form)this).add_Load((EventHandler)frmBlockDeals_Load);
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
		((Form)this).Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Expected O, but got Unknown
		components = new Container();
		UltraGridBand val = new UltraGridBand("Band 0", -1);
		Appearance val2 = new Appearance();
		Appearance val3 = new Appearance();
		Appearance val4 = new Appearance();
		Appearance val5 = new Appearance();
		Appearance val6 = new Appearance();
		Appearance val7 = new Appearance();
		ugBlockDeals = new UltraGrid();
		Timer1 = new Timer(components);
		((ISupportInitialize)ugBlockDeals).BeginInit();
		((Control)this).SuspendLayout();
		((UltraGridBase)ugBlockDeals).get_DisplayLayout().set_AutoFitStyle((AutoFitStyle)1);
		val.get_Override().set_RowSelectorNumberStyle((RowSelectorNumberStyle)3);
		val2.set_BackColor(Color.Purple);
		val2.set_BackColor2(Color.Purple);
		val.get_Override().set_SelectedCellAppearance((AppearanceBase)(object)val2);
		((UltraGridBase)ugBlockDeals).get_DisplayLayout().get_BandsSerializer().Add((object)val);
		((UltraGridBase)ugBlockDeals).get_DisplayLayout().set_CaptionVisible((DefaultableBoolean)2);
		((UltraGridBase)ugBlockDeals).get_DisplayLayout().set_MaxColScrollRegions(1);
		((UltraGridBase)ugBlockDeals).get_DisplayLayout().set_MaxRowScrollRegions(1);
		((UltraGridBase)ugBlockDeals).get_DisplayLayout().get_Override().set_AllowRowFiltering((DefaultableBoolean)1);
		val3.set_BackColor(Color.Transparent);
		((UltraGridBase)ugBlockDeals).get_DisplayLayout().get_Override().set_CardAreaAppearance((AppearanceBase)(object)val3);
		((UltraGridBase)ugBlockDeals).get_DisplayLayout().get_Override().set_FilterOperatorDefaultValue((FilterOperatorDefaultValue)11);
		((UltraGridBase)ugBlockDeals).get_DisplayLayout().get_Override().set_FilterOperatorLocation((FilterOperatorLocation)3);
		((UltraGridBase)ugBlockDeals).get_DisplayLayout().get_Override().set_FilterUIType((FilterUIType)2);
		val4.set_BackColor(Color.FromArgb(89, 135, 214));
		val4.set_BackColor2(Color.FromArgb(7, 59, 150));
		val4.set_BackGradientStyle((GradientStyle)2);
		val4.get_FontData().set_BoldAsString("True");
		val4.get_FontData().set_Name("Arial");
		val4.get_FontData().set_SizeInPoints(10f);
		val4.set_ForeColor(Color.White);
		val4.set_ThemedElementAlpha((Alpha)3);
		((UltraGridBase)ugBlockDeals).get_DisplayLayout().get_Override().set_HeaderAppearance((AppearanceBase)(object)val4);
		((UltraGridBase)ugBlockDeals).get_DisplayLayout().get_Override().set_HeaderClickAction((HeaderClickAction)2);
		val5.set_BackGradientAlignment((GradientAlignment)3);
		val5.set_BackGradientStyle((GradientStyle)2);
		val5.set_BackHatchStyle((BackHatchStyle)2);
		((UltraGridBase)ugBlockDeals).get_DisplayLayout().get_Override().set_RowAppearance((AppearanceBase)(object)val5);
		val6.set_BackColor(Color.FromArgb(89, 135, 214));
		val6.set_BackColor2(Color.FromArgb(7, 59, 150));
		val6.set_BackGradientStyle((GradientStyle)2);
		((UltraGridBase)ugBlockDeals).get_DisplayLayout().get_Override().set_RowSelectorAppearance((AppearanceBase)(object)val6);
		val7.set_BackColor(Color.FromArgb(251, 230, 148));
		val7.set_BackColor2(Color.FromArgb(238, 149, 21));
		val7.set_BackGradientStyle((GradientStyle)2);
		((UltraGridBase)ugBlockDeals).get_DisplayLayout().get_Override().set_SelectedRowAppearance((AppearanceBase)(object)val7);
		((UltraGridBase)ugBlockDeals).get_DisplayLayout().get_Override().set_SelectTypeRow((SelectType)2);
		((UltraGridBase)ugBlockDeals).get_DisplayLayout().set_ScrollBounds((ScrollBounds)0);
		((Control)ugBlockDeals).set_Dock((DockStyle)5);
		((Control)ugBlockDeals).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		UltraGrid obj = ugBlockDeals;
		Point location = new Point(0, 0);
		((Control)obj).set_Location(location);
		((Control)ugBlockDeals).set_Name("ugBlockDeals");
		UltraGrid obj2 = ugBlockDeals;
		Size size = new Size(576, 511);
		((Control)obj2).set_Size(size);
		((Control)ugBlockDeals).set_TabIndex(16);
		Timer1.set_Enabled(true);
		Timer1.set_Interval(30000);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(576, 511);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)ugBlockDeals);
		((Control)this).set_Name("frmBlockDeals");
		((Form)this).set_Text("Block Deals");
		((ISupportInitialize)ugBlockDeals).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void frmBlockDeals_Load(object sender, EventArgs e)
	{
		BindGrid();
	}

	private void ugBlockDeals_InitializeLayout(object sender, InitializeLayoutEventArgs e)
	{
		UltraGridBand val = e.get_Layout().get_Bands().get_Item(0);
		int num = checked(((DisposableObjectCollectionBase)e.get_Layout().get_Bands().get_Item(0)
			.get_Columns()).get_Count() - 1);
		int num2 = 0;
		while (true)
		{
			int num3 = num2;
			int num4 = num;
			if (num3 > num4)
			{
				break;
			}
			val.get_Columns().get_Item(num2).set_CellActivation((Activation)3);
			val.get_Override().set_CellClickAction((CellClickAction)2);
			if (num2 == 0)
			{
				val.get_Columns().get_Item(num2).set_FilterOperatorDefaultValue((FilterOperatorDefaultValue)8);
			}
			else if (num2 > 2 && num2 < 7)
			{
				val.get_Columns().get_Item(num2).set_FilterOperatorDefaultValue((FilterOperatorDefaultValue)6);
				val.get_Columns().get_Item(num2).get_CellAppearance()
					.set_TextHAlign((HAlign)3);
			}
			else
			{
				val.get_Columns().get_Item(num2).set_FilterOperatorDefaultValue((FilterOperatorDefaultValue)11);
			}
			num2 = checked(num2 + 1);
		}
		val = null;
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		Timer1.set_Enabled(false);
		BindGrid();
		Timer1.set_Enabled(true);
	}

	private void BindGrid()
	{
		checked
		{
			try
			{
				string text = "Select CONVERT(VARCHAR,A.[TIME],103) + ' ' + CONVERT(VARCHAR,A.[TIME],108) AS [Time], a.BridgeSymbol as Symbol,d.shortname as Name, CONVERT(FLOAT,a.Lastprice) as [Last Price], 0.00 AS [% Equity], CONVERT(FLOAT,a.Volume) AS VOLUME, CONVERT(FLOAT,ISNULL(b.ShareOutstanding,0)) as ShareOutstanding,a.Series as Series,A.market_type as MktType from Vol_TRANSACTION_DATA a  join Equity_transaction_data B on a.bridgesymbol=b.bridgesymbol and a.Market_type=b.Market_type  and a.Series=b.Series  join Vehicle_exchange C on C.Symbol=b.BridgeSymbol  join VehicleType D on D.Code=C.Code  where(a.series Is Not NULL And b.[close] <> 0)  and C.Series='EQUITY'  and  c.exchange_ID in ('1732256','1732257')  and Month(a.Time) = Month(GETDATE()) And Day(a.Time) = Day(GETDATE()) And Year(a.Time) = Year(GETDATE()) order by a.time desc";
				((UltraGridBase)ugBlockDeals).set_DataSource((object)SqlHelper.ExecuteDataset(MySettingsProperty.Settings.strCON, CommandType.Text, text));
				int num = ((UltraGridBase)ugBlockDeals).get_Rows().get_Count() - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					((UltraGridBase)ugBlockDeals).get_Rows().get_Item(num2).get_Cells()
						.get_Item("% Equity")
						.set_Value(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object)null, typeof(Math), "Round", new object[2]
						{
							Operators.MultiplyObject(Operators.DivideObject(((UltraGridBase)ugBlockDeals).get_Rows().get_Item(num2).get_Cells()
								.get_Item("Volume")
								.get_Value(), ((UltraGridBase)ugBlockDeals).get_Rows().get_Item(num2).get_Cells()
								.get_Item("ShareOutstanding")
								.get_Value()), (object)100),
							2
						}, (string[])null, (Type[])null, (bool[])null)));
					num2++;
				}
				((UltraGridBase)ugBlockDeals).UpdateData();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}
}
