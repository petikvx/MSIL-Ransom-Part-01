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
public class frmStats : Form
{
	private static ArrayList __ENCList = new ArrayList();

	private IContainer components;

	[AccessedThroughProperty("ugStats")]
	private UltraGrid _ugStats;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	internal virtual UltraGrid ugStats
	{
		[DebuggerNonUserCode]
		get
		{
			return _ugStats;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Expected O, but got Unknown
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Expected O, but got Unknown
			if (_ugStats != null)
			{
				_ugStats.remove_InitializeLayout(new InitializeLayoutEventHandler(ugStats_InitializeLayout));
			}
			_ugStats = value;
			if (_ugStats != null)
			{
				_ugStats.add_InitializeLayout(new InitializeLayoutEventHandler(ugStats_InitializeLayout));
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
	public frmStats()
	{
		((Form)this).add_Load((EventHandler)frmStats_Load);
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
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Expected O, but got Unknown
		components = new Container();
		UltraGridBand val = new UltraGridBand("Band 0", -1);
		Appearance val2 = new Appearance();
		Appearance val3 = new Appearance();
		Appearance val4 = new Appearance();
		Appearance val5 = new Appearance();
		Appearance val6 = new Appearance();
		Appearance val7 = new Appearance();
		ugStats = new UltraGrid();
		Timer1 = new Timer(components);
		((ISupportInitialize)ugStats).BeginInit();
		((Control)this).SuspendLayout();
		val2.set_BackColor(Color.Purple);
		val2.set_BackColor2(Color.Purple);
		val.get_Override().set_SelectedCellAppearance((AppearanceBase)(object)val2);
		((UltraGridBase)ugStats).get_DisplayLayout().get_BandsSerializer().Add((object)val);
		((UltraGridBase)ugStats).get_DisplayLayout().set_CaptionVisible((DefaultableBoolean)2);
		((UltraGridBase)ugStats).get_DisplayLayout().set_MaxColScrollRegions(1);
		((UltraGridBase)ugStats).get_DisplayLayout().set_MaxRowScrollRegions(1);
		((UltraGridBase)ugStats).get_DisplayLayout().get_Override().set_AllowRowFiltering((DefaultableBoolean)1);
		val3.set_BackColor(Color.Transparent);
		((UltraGridBase)ugStats).get_DisplayLayout().get_Override().set_CardAreaAppearance((AppearanceBase)(object)val3);
		((UltraGridBase)ugStats).get_DisplayLayout().get_Override().set_FilterOperatorDefaultValue((FilterOperatorDefaultValue)11);
		((UltraGridBase)ugStats).get_DisplayLayout().get_Override().set_FilterOperatorLocation((FilterOperatorLocation)3);
		((UltraGridBase)ugStats).get_DisplayLayout().get_Override().set_FilterUIType((FilterUIType)2);
		val4.set_BackColor(Color.FromArgb(89, 135, 214));
		val4.set_BackColor2(Color.FromArgb(7, 59, 150));
		val4.set_BackGradientStyle((GradientStyle)2);
		val4.get_FontData().set_BoldAsString("True");
		val4.get_FontData().set_Name("Arial");
		val4.get_FontData().set_SizeInPoints(10f);
		val4.set_ForeColor(Color.White);
		val4.set_ThemedElementAlpha((Alpha)3);
		((UltraGridBase)ugStats).get_DisplayLayout().get_Override().set_HeaderAppearance((AppearanceBase)(object)val4);
		((UltraGridBase)ugStats).get_DisplayLayout().get_Override().set_HeaderClickAction((HeaderClickAction)2);
		val5.set_BackGradientAlignment((GradientAlignment)3);
		val5.set_BackGradientStyle((GradientStyle)2);
		val5.set_BackHatchStyle((BackHatchStyle)2);
		((UltraGridBase)ugStats).get_DisplayLayout().get_Override().set_RowAppearance((AppearanceBase)(object)val5);
		val6.set_BackColor(Color.FromArgb(89, 135, 214));
		val6.set_BackColor2(Color.FromArgb(7, 59, 150));
		val6.set_BackGradientStyle((GradientStyle)2);
		((UltraGridBase)ugStats).get_DisplayLayout().get_Override().set_RowSelectorAppearance((AppearanceBase)(object)val6);
		val7.set_BackColor(Color.FromArgb(251, 230, 148));
		val7.set_BackColor2(Color.FromArgb(238, 149, 21));
		val7.set_BackGradientStyle((GradientStyle)2);
		((UltraGridBase)ugStats).get_DisplayLayout().get_Override().set_SelectedRowAppearance((AppearanceBase)(object)val7);
		((UltraGridBase)ugStats).get_DisplayLayout().get_Override().set_SelectTypeRow((SelectType)2);
		((UltraGridBase)ugStats).get_DisplayLayout().set_ScrollBounds((ScrollBounds)0);
		((Control)ugStats).set_Dock((DockStyle)5);
		((Control)ugStats).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		UltraGrid obj = ugStats;
		Point location = new Point(0, 0);
		((Control)obj).set_Location(location);
		((Control)ugStats).set_Name("ugStats");
		UltraGrid obj2 = ugStats;
		Size size = new Size(501, 404);
		((Control)obj2).set_Size(size);
		((Control)ugStats).set_TabIndex(15);
		Timer1.set_Enabled(true);
		Timer1.set_Interval(60000);
		size = new Size(501, 404);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)ugStats);
		((Control)this).set_Name("frmStats");
		((Form)this).set_Text("Stats");
		((ISupportInitialize)ugStats).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void frmStats_Load(object sender, EventArgs e)
	{
		Money_Splash money_Splash = new Money_Splash();
		((Control)money_Splash).Show();
		((Control)money_Splash).Refresh();
		BindControls();
		((Form)money_Splash).Close();
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		Timer1.set_Enabled(false);
		BindControls();
		Timer1.set_Enabled(true);
	}

	private void ugStats_InitializeLayout(object sender, InitializeLayoutEventArgs e)
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
				if (num3 <= num4)
				{
					e.get_Layout().get_Bands().get_Item(0)
						.get_Columns()
						.get_Item(num2)
						.set_CellActivation((Activation)3);
					e.get_Layout().get_Bands().get_Item(0)
						.get_Override()
						.set_CellClickAction((CellClickAction)2);
					if (num2 == 1)
					{
						e.get_Layout().get_Bands().get_Item(0)
							.get_Columns()
							.get_Item(num2)
							.set_FilterOperatorDefaultValue((FilterOperatorDefaultValue)6);
						e.get_Layout().get_Bands().get_Item(0)
							.get_Columns()
							.get_Item(num2)
							.get_CellAppearance()
							.set_TextHAlign((HAlign)3);
						e.get_Layout().get_Bands().get_Item(0)
							.get_Columns()
							.get_Item(num2)
							.set_Width(200);
					}
					else
					{
						e.get_Layout().get_Bands().get_Item(0)
							.get_Columns()
							.get_Item(num2)
							.set_FilterOperatorDefaultValue((FilterOperatorDefaultValue)11);
						e.get_Layout().get_Bands().get_Item(0)
							.get_Columns()
							.get_Item(num2)
							.set_Width(400);
					}
					num2++;
					continue;
				}
				break;
			}
		}
	}

	private void BindControls()
	{
		try
		{
			DataTable dataTable = new DataTable();
			string text = "Select SHORTNAME,LASTPRICE,BRIDGESYMBOL from Equity_Transaction_data where BridgeSymbol in ('in;BSEUVOL','in;NSEUVOL','in;BSEUNC','in;NSEUNC','in;BSEAVOL','in;NSEAVOL','in;BSEDVOL','in;NSEDVOL','in;BSEDEC','in;NSEDEC','in;BSEADV','in;NSEADV','in;TOTCM','in;FNOCM','in;BSECM','in;NSECM','in;BSETOT','in;NSETOT','in;BSETVOL','in;NSETVOL')";
			dataTable = SqlHelper.ExecuteDataset(MySettingsProperty.Settings.strCON, CommandType.Text, text).Tables[0];
			((UltraGridBase)ugStats).set_DataSource((object)dataTable);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
