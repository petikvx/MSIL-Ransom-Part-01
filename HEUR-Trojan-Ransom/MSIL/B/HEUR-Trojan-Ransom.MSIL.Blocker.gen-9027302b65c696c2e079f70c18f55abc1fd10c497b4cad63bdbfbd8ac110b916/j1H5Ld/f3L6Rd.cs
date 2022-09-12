using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Serialization;
using Bo6;
using Dp4o9T;
using Dt7;
using Ed65Hf;
using Ed9;
using Ei07De;
using Gp;
using Jg8;
using Jm0r4W;
using Jr39Qo;
using Js9;
using Kj87Xi;
using Lk;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Rn1;
using Sn7x6Z;
using c1CLx2;
using d0P;
using e2;
using g8GLd9;
using m2Q;
using n2Z;
using o1KZx9;
using p6MRy9;
using s9;
using t5C8Kg;
using t7S;
using w0XGc7;
using x6T;

namespace j1H5Ld;

[DesignerGenerated]
public class f3L6Rd : Form
{
	private IContainer components;

	[AccessedThroughProperty("grdviewDailyRecord")]
	private object _grdviewDailyRecord;

	[AccessedThroughProperty("datepkrDailyRecord")]
	private object _datepkrDailyRecord;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("btnrefresh")]
	private object _btnrefresh;

	[AccessedThroughProperty("tmrLoad")]
	private Timer _tmrLoad;

	[AccessedThroughProperty("lblProgress")]
	private object _lblProgress;

	[AccessedThroughProperty("WindowsUIButtonPanel3")]
	private object _WindowsUIButtonPanel3;

	public DataTable exData;

	private i1D.b4D b4D_0;

	internal virtual object grdviewDailyRecord
	{
		get
		{
			return _grdviewDailyRecord;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_grdviewDailyRecord = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual object datepkrDailyRecord
	{
		get
		{
			return _datepkrDailyRecord;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_datepkrDailyRecord = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual Label Label1
	{
		get
		{
			return b4D_0.label_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			b4D_0.label_0 = ((value is Label) ? value : null);
		}
	}

	internal virtual Label Label2
	{
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label2 = value;
		}
	}

	internal virtual Chart Chart1
	{
		get
		{
			return b4D_0.chart_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			b4D_0.chart_0 = ((value is Chart) ? value : null);
		}
	}

	internal virtual object btnclose
	{
		get
		{
			return b4D_0.object_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			b4D_0.object_0 = objectValue;
		}
	}

	internal virtual object btnrefresh
	{
		get
		{
			return _btnrefresh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_btnrefresh = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual Timer tmrLoad
	{
		get
		{
			return _tmrLoad;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			object obj = new EventHandler(As1b8C);
			Component component = (Component)(object)_tmrLoad;
			if (component is Timer)
			{
				((Timer)((component is Timer) ? component : null)).remove_Tick((EventHandler)obj);
			}
			_tmrLoad = value;
			component = (Component)(object)_tmrLoad;
			if ((int)(Timer)component != 0)
			{
				((Timer)((component is Timer) ? component : null)).add_Tick((EventHandler)obj);
			}
		}
	}

	internal virtual object lblProgress
	{
		get
		{
			return _lblProgress;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblProgress = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual object pbarcircle
	{
		get
		{
			return b4D_0.object_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			b4D_0.object_1 = objectValue;
		}
	}

	internal virtual Panel Panel2
	{
		get
		{
			return b4D_0.panel_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			b4D_0.panel_0 = ((value is Panel) ? value : null);
		}
	}

	internal virtual object WindowsUIButtonPanel3
	{
		get
		{
			return _WindowsUIButtonPanel3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_WindowsUIButtonPanel3 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual Label lblTotal
	{
		get
		{
			return b4D_0.label_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected O, but got Unknown
			b4D_0.label_1 = value;
		}
	}

	public object PrintDailyRecords
	{
		get
		{
			return b4D_0.object_2;
		}
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			b4D_0.object_2 = objectValue;
		}
	}

	public f3L6Rd()
	{
		((Form)this).add_Load((EventHandler)Gy2i9D);
		exData = new DataTable();
		Yf9d2Q();
	}

	protected override void Qy37Gw(bool Ly6x9W)
	{
		try
		{
			if (Ly6x9W && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Ly6x9W);
		}
	}

	private void Yf9d2Q()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Expected O, but got Unknown
		//IL_0461: Unknown result type (might be due to invalid IL or missing references)
		//IL_046b: Expected O, but got Unknown
		//IL_0509: Unknown result type (might be due to invalid IL or missing references)
		//IL_0513: Expected O, but got Unknown
		//IL_052f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0539: Expected O, but got Unknown
		//IL_0574: Unknown result type (might be due to invalid IL or missing references)
		//IL_073d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0743: Expected O, but got Unknown
		//IL_0a7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a81: Expected O, but got Unknown
		//IL_0c00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c06: Expected O, but got Unknown
		//IL_0f3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f41: Expected O, but got Unknown
		//IL_0fed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff3: Expected O, but got Unknown
		//IL_11b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_11b7: Expected O, but got Unknown
		//IL_11de: Unknown result type (might be due to invalid IL or missing references)
		//IL_11e4: Expected O, but got Unknown
		//IL_12cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_156c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1576: Expected O, but got Unknown
		//IL_1633: Unknown result type (might be due to invalid IL or missing references)
		//IL_163d: Expected O, but got Unknown
		//IL_165a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1664: Expected O, but got Unknown
		//IL_1670: Unknown result type (might be due to invalid IL or missing references)
		//IL_167a: Expected O, but got Unknown
		//IL_1686: Unknown result type (might be due to invalid IL or missing references)
		//IL_1690: Expected O, but got Unknown
		//IL_169c: Unknown result type (might be due to invalid IL or missing references)
		//IL_16a6: Expected O, but got Unknown
		//IL_16e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ef: Expected O, but got Unknown
		//IL_16fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1705: Expected O, but got Unknown
		components = new Container();
		ChartNamedElement val = (ChartNamedElement)new ChartArea();
		object obj = (object)new Legend();
		object obj2 = (object)new Series();
		ResourceManager resourceManager = new ComponentResourceManager(typeof(f3L6Rd));
		Label1 = new Label();
		Label2 = new Label();
		Chart1 = new Chart();
		Panel2 = new Panel();
		lblTotal = new Label();
		((ISupportInitialize)grdviewDailyRecord).BeginInit();
		((ISupportInitialize)NewLateBinding.LateGet(grdviewDailyRecord, (Type)null, "MasterTemplate", new object[0], (string[])null, (Type[])null, (bool[])null)).BeginInit();
		((ISupportInitialize)Chart1).BeginInit();
		((Control)this).SuspendLayout();
		NewLateBinding.LateSetComplex(grdviewDailyRecord, (Type)null, "Location", new object[1]
		{
			new Point(12, 31)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(grdviewDailyRecord, (Type)null, "MasterTemplate", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "AllowAddNewRow", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(grdviewDailyRecord, (Type)null, "Name", new object[1] { "grdviewDailyRecord" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(grdviewDailyRecord, (Type)null, "ReadOnly", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(grdviewDailyRecord, (Type)null, "Size", new object[1]
		{
			new Size(397, 578)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(grdviewDailyRecord, (Type)null, "TabIndex", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(grdviewDailyRecord, (Type)null, "Text", new object[1] { "grdviewDailyRecord" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(grdviewDailyRecord, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(datepkrDailyRecord, (Type)null, "BackColor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(datepkrDailyRecord, (Type)null, "BorderRadius", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(datepkrDailyRecord, (Type)null, "ForeColor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(datepkrDailyRecord, (Type)null, "Format", new object[1] { (object)(DateTimePickerFormat)2 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(datepkrDailyRecord, (Type)null, "FormatCustom", new object[1] { "dd-MMM-yy" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(datepkrDailyRecord, (Type)null, "Location", new object[1]
		{
			new Point(591, 136)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(datepkrDailyRecord, (Type)null, "Name", new object[1] { "datepkrDailyRecord" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(datepkrDailyRecord, (Type)null, "Size", new object[1]
		{
			new Size(246, 36)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(datepkrDailyRecord, (Type)null, "TabIndex", new object[1] { 2 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(datepkrDailyRecord, (Type)null, "Value", new object[1]
		{
			new DateTime(2018, 1, 14, 11, 37, 24, 933)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(datepkrDailyRecord, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null, false, true);
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Century Gothic", 36f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_Location(new Point(473, 43));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(340, 58));
		((Control)Label1).set_TabIndex(3);
		Label1.set_Text("Daily Records");
		((Control)Label1).set_Visible(false);
		Label2.set_AutoSize(true);
		((Control)Label2).set_Font(new Font("Century Gothic", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_Location(new Point(491, 145));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(94, 20));
		((Control)Label2).set_TabIndex(4);
		Label2.set_Text("Select Date");
		((Control)Label2).set_Visible(false);
		((Control)Chart1).set_BackgroundImageLayout((ImageLayout)0);
		Chart1.set_BackSecondaryColor(Color.Black);
		((ChartArea)((val is ChartArea) ? val : null)).set_Name("ChartArea1");
		((Collection<ChartArea>)(object)Chart1.get_ChartAreas()).Add((ChartArea)val);
		((Legend)((obj is Legend) ? obj : null)).set_Name("Legend1");
		((Collection<Legend>)(object)Chart1.get_Legends()).Add((Legend)obj);
		((Control)Chart1).set_Location(new Point(415, 224));
		((Control)Chart1).set_Name("Chart1");
		((Series)((obj2 is Series) ? obj2 : null)).set_ChartArea("ChartArea1");
		((Series)obj2).set_Legend("Legend1");
		((Series)((obj2 is Series) ? obj2 : null)).set_Name("Daily Record");
		((Collection<Series>)(object)Chart1.get_Series()).Add((Series)((obj2 is Series) ? obj2 : null));
		Chart1.set_Size(new Size(654, 385));
		((Control)Chart1).set_TabIndex(6);
		((Control)Chart1).set_Text("Chart1");
		((Control)Chart1).set_Visible(false);
		NewLateBinding.LateSetComplex(btnclose, (Type)null, "Activecolor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnclose, (Type)null, "BackColor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnclose, (Type)null, "BackgroundImageLayout", new object[1] { (object)(ImageLayout)3 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnclose, (Type)null, "BorderRadius", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnclose, (Type)null, "ButtonText", new object[1] { "Close" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnclose, (Type)null, "Cursor", new object[1] { Cursors.get_Hand() }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnclose, (Type)null, "DisabledColor", new object[1] { Color.Gray }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnclose, (Type)null, "Iconcolor", new object[1] { Color.Transparent }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnclose, (Type)null, "Iconimage", new object[1] { (object)(Image)(resourceManager as ComponentResourceManager).GetObject("btnclose.Iconimage") }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnclose, (Type)null, "Iconimage_right", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnclose, (Type)null, "Iconimage_right_Selected", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnclose, (Type)null, "Iconimage_Selected", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnclose, (Type)null, "IconMarginLeft", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnclose, (Type)null, "IconMarginRight", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnclose, (Type)null, "IconRightVisible", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnclose, (Type)null, "IconRightZoom", new object[1] { 0.0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnclose, (Type)null, "IconVisible", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnclose, (Type)null, "IconZoom", new object[1] { 90.0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnclose, (Type)null, "IsTab", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnclose, (Type)null, "Location", new object[1]
		{
			new Point(934, 178)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnclose, (Type)null, "Name", new object[1] { "btnclose" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnclose, (Type)null, "Normalcolor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnclose, (Type)null, "OnHovercolor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnclose, (Type)null, "OnHoverTextColor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnclose, (Type)null, "selected", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnclose, (Type)null, "Size", new object[1]
		{
			new Size(135, 40)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnclose, (Type)null, "TabIndex", new object[1] { 7 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnclose, (Type)null, "Text", new object[1] { "Close" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnclose, (Type)null, "TextAlign", new object[1] { (object)(ContentAlignment)16 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnclose, (Type)null, "Textcolor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnclose, (Type)null, "TextFont", new object[1] { (object)new Font("Century Gothic", 15.75f) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnclose, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnrefresh, (Type)null, "Activecolor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnrefresh, (Type)null, "BackColor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnrefresh, (Type)null, "BackgroundImageLayout", new object[1] { (object)(ImageLayout)3 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnrefresh, (Type)null, "BorderRadius", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnrefresh, (Type)null, "ButtonText", new object[1] { "Refresh" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnrefresh, (Type)null, "Cursor", new object[1] { Cursors.get_Hand() }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnrefresh, (Type)null, "DisabledColor", new object[1] { Color.Gray }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnrefresh, (Type)null, "Iconcolor", new object[1] { Color.Transparent }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnrefresh, (Type)null, "Iconimage", new object[1] { (object)(Image)(resourceManager as ComponentResourceManager).GetObject("btnrefresh.Iconimage") }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnrefresh, (Type)null, "Iconimage_right", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnrefresh, (Type)null, "Iconimage_right_Selected", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnrefresh, (Type)null, "Iconimage_Selected", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnrefresh, (Type)null, "IconMarginLeft", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnrefresh, (Type)null, "IconMarginRight", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnrefresh, (Type)null, "IconRightVisible", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnrefresh, (Type)null, "IconRightZoom", new object[1] { 0.0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnrefresh, (Type)null, "IconVisible", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnrefresh, (Type)null, "IconZoom", new object[1] { 90.0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnrefresh, (Type)null, "IsTab", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnrefresh, (Type)null, "Location", new object[1]
		{
			new Point(934, 117)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnrefresh, (Type)null, "Name", new object[1] { "btnrefresh" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnrefresh, (Type)null, "Normalcolor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnrefresh, (Type)null, "OnHovercolor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnrefresh, (Type)null, "OnHoverTextColor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnrefresh, (Type)null, "selected", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnrefresh, (Type)null, "Size", new object[1]
		{
			new Size(135, 40)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnrefresh, (Type)null, "TabIndex", new object[1] { 7 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnrefresh, (Type)null, "Text", new object[1] { "Refresh" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnrefresh, (Type)null, "TextAlign", new object[1] { (object)(ContentAlignment)16 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnrefresh, (Type)null, "Textcolor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnrefresh, (Type)null, "TextFont", new object[1] { (object)new Font("Century Gothic", 15.75f) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnrefresh, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null, false, true);
		tmrLoad.set_Enabled(true);
		tmrLoad.set_Interval(30);
		NewLateBinding.LateSetComplex(lblProgress, (Type)null, "AutoSize", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(lblProgress, (Type)null, "Depth", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(lblProgress, (Type)null, "Font", new object[1] { (object)new Font("Roboto", 11f) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(lblProgress, (Type)null, "ForeColor", new object[1] { Color.FromArgb(222, 0, 0, 0) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(lblProgress, (Type)null, "Location", new object[1]
		{
			new Point(504, 236)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(lblProgress, (Type)null, "Name", new object[1] { "lblProgress" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(lblProgress, (Type)null, "Size", new object[1]
		{
			new Size(121, 19)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(lblProgress, (Type)null, "TabIndex", new object[1] { 11 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(lblProgress, (Type)null, "Text", new object[1] { "Loading Records" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(pbarcircle, (Type)null, "animated", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(pbarcircle, (Type)null, "animationIterval", new object[1] { 5 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(pbarcircle, (Type)null, "animationSpeed", new object[1] { 300 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(pbarcircle, (Type)null, "BackColor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(pbarcircle, (Type)null, "BackgroundImage", new object[1] { (object)(Image)((ComponentResourceManager)resourceManager).GetObject("pbarcircle.BackgroundImage") }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(pbarcircle, (Type)null, "Font", new object[1] { (object)new Font("Microsoft Sans Serif", 26.25f) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(pbarcircle, (Type)null, "ForeColor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(pbarcircle, (Type)null, "LabelVisible", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(pbarcircle, (Type)null, "LineProgressThickness", new object[1] { 8 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(pbarcircle, (Type)null, "LineThickness", new object[1] { 5 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(pbarcircle, (Type)null, "Location", new object[1]
		{
			new Point(454, 264)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(pbarcircle, (Type)null, "Margin", new object[1] { (object)new Padding(10, 9, 10, 9) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(pbarcircle, (Type)null, "MaxValue", new object[1] { 100 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(pbarcircle, (Type)null, "Name", new object[1] { "pbarcircle" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(pbarcircle, (Type)null, "ProgressBackColor", new object[1] { Color.Gainsboro }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(pbarcircle, (Type)null, "ProgressColor", new object[1] { Color.SeaGreen }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(pbarcircle, (Type)null, "Size", new object[1]
		{
			new Size(201, 201)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(pbarcircle, (Type)null, "TabIndex", new object[1] { 12 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(pbarcircle, (Type)null, "Value", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		((Control)Panel2).set_BackColor(Color.FromArgb(174, 8, 40));
		((Control)Panel2).set_Dock((DockStyle)1);
		((Control)Panel2).set_Location(new Point(0, 0));
		((Control)Panel2).set_Name("Panel2");
		((Control)Panel2).set_Size(new Size(1081, 25));
		((Control)Panel2).set_TabIndex(13);
		NewLateBinding.LateSetComplex(WindowsUIButtonPanel3, (Type)null, "Location", new object[1]
		{
			new Point(1010, 371)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(WindowsUIButtonPanel3, (Type)null, "Name", new object[1] { "WindowsUIButtonPanel3" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(WindowsUIButtonPanel3, (Type)null, "Size", new object[1]
		{
			new Size(59, 64)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(WindowsUIButtonPanel3, (Type)null, "TabIndex", new object[1] { 14 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(WindowsUIButtonPanel3, (Type)null, "Text", new object[1] { "WindowsUIButtonPanel1" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(WindowsUIButtonPanel3, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null, false, true);
		lblTotal.set_AutoSize(true);
		((Control)lblTotal).set_Font(new Font("Century Gothic", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblTotal).set_Location(new Point(888, 43));
		((Control)lblTotal).set_Name("lblTotal");
		((Control)lblTotal).set_Size(new Size(42, 20));
		((Control)lblTotal).set_TabIndex(15);
		lblTotal.set_Text("Total");
		((Control)lblTotal).set_Visible(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.White);
		((Form)this).set_ClientSize(new Size(1081, 626));
		((Control)this).get_Controls().Add((Control)(object)lblTotal);
		((Control)this).get_Controls().Add((Control)WindowsUIButtonPanel3);
		((Control)this).get_Controls().Add((Control)(object)Panel2);
		((Control)this).get_Controls().Add((Control)lblProgress);
		((Control)this).get_Controls().Add((Control)pbarcircle);
		((Control)this).get_Controls().Add((Control)btnrefresh);
		((Control)this).get_Controls().Add((Control)btnclose);
		((Control)this).get_Controls().Add((Control)(object)Chart1);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)datepkrDailyRecord);
		((Control)this).get_Controls().Add((Control)grdviewDailyRecord);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("DailyRecords");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Daily Records");
		((ISupportInitialize)NewLateBinding.LateGet(grdviewDailyRecord, (Type)null, "MasterTemplate", new object[0], (string[])null, (Type[])null, (bool[])null)).EndInit();
		((ISupportInitialize)grdviewDailyRecord).EndInit();
		((ISupportInitialize)Chart1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Gy2i9D(object sender, EventArgs e)
	{
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		tmrLoad.Start();
		NewLateBinding.LateSetComplex(pbarcircle, (Type)null, "Visible", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateCall(grdviewDailyRecord, (Type)null, "BestFitColumns", new object[1] { true }, (string[])null, (Type[])null, (bool[])null, true);
		try
		{
			NewLateBinding.LateSetComplex(datepkrDailyRecord, (Type)null, "Value", new object[1] { ((ServerComputer)Wt9q7H.Computer).get_Clock().get_LocalTime() }, (string[])null, (Type[])null, false, true);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		Rf7.Zj9();
		Rf7.cnn.Open();
		IDbCommand cmd = (IDbCommand)Rf7.cmd;
		((OleDbCommand)cmd).set_Connection(Rf7.cnn);
		((OleDbCommand)cmd).set_CommandText(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"SELECT totalprice,timeshow from dailyrecord  where date=#", NewLateBinding.LateGet(NewLateBinding.LateGet(datepkrDailyRecord, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ToShortDateString", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"#")));
		cmd = null;
		MarshalByValueComponent marshalByValueComponent = new DataTable();
		Rf7.da.set_SelectCommand(Rf7.cmd);
		try
		{
			((DbDataAdapter)(object)Rf7.da).Fill(marshalByValueComponent as DataTable);
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		checked
		{
			try
			{
				int count = (marshalByValueComponent as DataTable).Rows.Count;
				int i = 0;
				int num = 0;
				for (; i < count; i++)
				{
					num += Conversions.ToInteger(((DataTable)marshalByValueComponent).Rows[i]["totalprice"]);
				}
				lblTotal.set_Text("Rs." + Conversions.ToString(num));
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				lblTotal.set_Text("Rs. 00");
				ProjectData.ClearProjectError();
			}
			Chart1.set_DataSource((object)(DataTable)marshalByValueComponent);
			((ChartNamedElementCollection<Series>)(object)Chart1.get_Series()).get_Item("Daily Record").set_YValueMembers("totalprice");
			((ChartNamedElementCollection<Series>)(object)Chart1.get_Series()).get_Item("Daily Record").set_XValueMember("timeshow");
			IDbCommand cmd2 = (IDbCommand)Rf7.cmd;
			((OleDbCommand)((cmd2 is OleDbCommand) ? cmd2 : null)).set_Connection(Rf7.cnn);
			((OleDbCommand)cmd2).set_CommandText(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Select orderno As [Order No], Name As [Item Name], quantity As [Quantity], totalprice As [Total Price], dateshow As [Date And Time],payment As [Paid By] from dailyrecord  where Date=#", NewLateBinding.LateGet(NewLateBinding.LateGet(datepkrDailyRecord, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ToShortDateString", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"#")));
			cmd2 = null;
			IXmlSerializable xmlSerializable = new DataTable();
			Rf7.da.set_SelectCommand(Rf7.cmd);
			try
			{
				((DbDataAdapter)(object)Rf7.da).Fill(xmlSerializable as DataTable);
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				ProjectData.ClearProjectError();
			}
			NewLateBinding.LateSetComplex(grdviewDailyRecord, (Type)null, "DataSource", new object[1] { (DataTable)xmlSerializable }, (string[])null, (Type[])null, false, true);
			Rf7.cnn.Close();
		}
	}

	private void Cd24At(object sender, EventArgs e)
	{
	}

	private void o8FJc0(object sender, EventArgs e)
	{
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		Rf7.Zj9();
		Rf7.cnn.Open();
		IDbCommand cmd = (IDbCommand)Rf7.cmd;
		((OleDbCommand)((cmd is OleDbCommand) ? cmd : null)).set_Connection(Rf7.cnn);
		((OleDbCommand)((cmd is OleDbCommand) ? cmd : null)).set_CommandText(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Select orderno As [Order No], Name As [Item Name], quantity As [Quantity], totalprice As [Total Price], dateshow As [Date And Time],payment As [Paid By] from dailyrecord  where Date=#", NewLateBinding.LateGet(NewLateBinding.LateGet(datepkrDailyRecord, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ToShortDateString", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"#")));
		cmd = null;
		ISupportInitialize supportInitialize = new DataTable();
		Rf7.da.set_SelectCommand(Rf7.cmd);
		try
		{
			((DbDataAdapter)(object)Rf7.da).Fill(supportInitialize as DataTable);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		NewLateBinding.LateSetComplex(grdviewDailyRecord, (Type)null, "DataSource", new object[1] { supportInitialize as DataTable }, (string[])null, (Type[])null, false, true);
		IDbCommand cmd2 = (IDbCommand)Rf7.cmd;
		((OleDbCommand)cmd2).set_Connection(Rf7.cnn);
		((OleDbCommand)cmd2).set_CommandText(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"SELECT orderno,totalprice,timeshow from dailyrecord  where date=#", NewLateBinding.LateGet(NewLateBinding.LateGet(datepkrDailyRecord, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ToShortDateString", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"#")));
		cmd2 = null;
		IXmlSerializable xmlSerializable = new DataTable();
		Rf7.da.set_SelectCommand(Rf7.cmd);
		try
		{
			((DbDataAdapter)(object)Rf7.da).Fill((DataTable)xmlSerializable);
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		Array array = new string[14];
		(array as string[])[0] = Conversions.ToString(1);
		((string[])array)[1] = Conversions.ToString(8);
		(array as string[])[2] = Conversions.ToString(9);
		((string[])array)[3] = Conversions.ToString(6);
		((string[])array)[4] = Conversions.ToString(3);
		((string[])array)[5] = Conversions.ToString(11);
		((string[])array)[6] = Conversions.ToString(10);
		((string[])array)[7] = Conversions.ToString(12);
		((string[])array)[8] = Conversions.ToString(2);
		((string[])array)[9] = Conversions.ToString(4);
		(array as string[])[10] = Conversions.ToString(5);
		object obj = new Random();
		try
		{
			int num = (obj as Random).Next(0, 12);
			Chart1.set_Palette((ChartColorPalette)Conversions.ToInteger(((string[])array)[num]));
			Chart1.set_DataSource((object)(xmlSerializable as DataTable));
			((Collection<Series>)(object)Chart1.get_Series())[0].set_YValueMembers("totalprice");
			((Collection<Series>)(object)Chart1.get_Series())[0].set_XValueMember("timeshow");
			Chart1.ResetAutoValues();
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		NewLateBinding.LateCall(grdviewDailyRecord, (Type)null, "BestFitColumns", new object[1] { true }, (string[])null, (Type[])null, (bool[])null, true);
		Rf7.cnn.Close();
	}

	private void t5EXr8(object sender, EventArgs e)
	{
		try
		{
			Rf7.cnn.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			NewLateBinding.LateCall(Rf7.cn, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private void z8Q5Wc(object sender, EventArgs e)
	{
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		Rf7.Zj9();
		Rf7.cnn.Open();
		ICloneable cmd = (ICloneable)Rf7.cmd;
		((OleDbCommand)((cmd is OleDbCommand) ? cmd : null)).set_Connection(Rf7.cnn);
		((OleDbCommand)((cmd is OleDbCommand) ? cmd : null)).set_CommandText(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Select orderno As [Order No], Name As [Item Name], quantity As [Quantity], totalprice As [Total Price], dateshow As [Date And Time],payment As [Paid By] from dailyrecord  where Date=#", NewLateBinding.LateGet(NewLateBinding.LateGet(datepkrDailyRecord, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ToShortDateString", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"#")));
		cmd = null;
		ISupportInitializeNotification supportInitializeNotification = new DataTable();
		Rf7.da.set_SelectCommand(Rf7.cmd);
		try
		{
			((DbDataAdapter)(object)Rf7.da).Fill(supportInitializeNotification as DataTable);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		NewLateBinding.LateSetComplex(grdviewDailyRecord, (Type)null, "DataSource", new object[1] { supportInitializeNotification as DataTable }, (string[])null, (Type[])null, false, true);
		IDisposable cmd2 = (IDisposable)Rf7.cmd;
		((OleDbCommand)((cmd2 is OleDbCommand) ? cmd2 : null)).set_Connection(Rf7.cnn);
		((OleDbCommand)cmd2).set_CommandText(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"SELECT orderno,totalprice,timeshow from dailyrecord  where date=#", NewLateBinding.LateGet(NewLateBinding.LateGet(datepkrDailyRecord, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ToShortDateString", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"#")));
		cmd2 = null;
		IXmlSerializable xmlSerializable = new DataTable();
		Rf7.da.set_SelectCommand(Rf7.cmd);
		try
		{
			((DbDataAdapter)(object)Rf7.da).Fill((DataTable)xmlSerializable);
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		Array array = new string[14];
		(array as string[])[0] = Conversions.ToString(1);
		((string[])array)[1] = Conversions.ToString(8);
		(array as string[])[2] = Conversions.ToString(9);
		((string[])array)[3] = Conversions.ToString(6);
		((string[])array)[4] = Conversions.ToString(3);
		((string[])array)[5] = Conversions.ToString(11);
		(array as string[])[6] = Conversions.ToString(10);
		(array as string[])[7] = Conversions.ToString(12);
		(array as string[])[8] = Conversions.ToString(2);
		(array as string[])[9] = Conversions.ToString(4);
		(array as string[])[10] = Conversions.ToString(5);
		object obj = new Random();
		try
		{
			int num = ((Random)obj).Next(0, 12);
			Chart1.set_Palette((ChartColorPalette)Conversions.ToInteger(((string[])array)[num]));
			Chart1.set_DataSource((object)(xmlSerializable as DataTable));
			((Collection<Series>)(object)Chart1.get_Series())[0].set_YValueMembers("totalprice");
			((Collection<Series>)(object)Chart1.get_Series())[0].set_XValueMember("timeshow");
			Chart1.ResetAutoValues();
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		NewLateBinding.LateCall(grdviewDailyRecord, (Type)null, "BestFitColumns", new object[1] { true }, (string[])null, (Type[])null, (bool[])null, true);
		Rf7.cnn.Close();
	}

	private void As1b8C(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectLess(NewLateBinding.LateGet(pbarcircle, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null), (object)100, false))
		{
			NewLateBinding.LateSetComplex(pbarcircle, (Type)null, "Value", new object[1] { Operators.AddObject(NewLateBinding.LateGet(pbarcircle, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null, false, true);
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(lblProgress, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"Loading Records", false))
			{
				NewLateBinding.LateSetComplex(lblProgress, (Type)null, "Text", new object[1] { "Loading Records." }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(lblProgress, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"Loading Records.", false))
			{
				NewLateBinding.LateSetComplex(lblProgress, (Type)null, "Text", new object[1] { "Loading Records.." }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(lblProgress, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"Loading Records..", false))
			{
				NewLateBinding.LateSetComplex(lblProgress, (Type)null, "Text", new object[1] { "Loading Records..." }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(lblProgress, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"Loading Records...", false))
			{
				NewLateBinding.LateSetComplex(lblProgress, (Type)null, "Text", new object[1] { "Loading Records...." }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(lblProgress, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"Loading Records....", false))
			{
				NewLateBinding.LateSetComplex(lblProgress, (Type)null, "Text", new object[1] { "Loading Records" }, (string[])null, (Type[])null, false, true);
			}
		}
		else
		{
			NewLateBinding.LateCall(pbarcircle, (Type)null, "Hide", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateCall(lblProgress, (Type)null, "Hide", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			((Control)Chart1).set_Visible(true);
			NewLateBinding.LateSetComplex(grdviewDailyRecord, (Type)null, "Visible", new object[1] { true }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(datepkrDailyRecord, (Type)null, "Visible", new object[1] { true }, (string[])null, (Type[])null, false, true);
			((Control)Label2).set_Visible(true);
			((Control)Label1).set_Visible(true);
			NewLateBinding.LateSetComplex(btnclose, (Type)null, "Visible", new object[1] { true }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(btnrefresh, (Type)null, "Visible", new object[1] { true }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(WindowsUIButtonPanel3, (Type)null, "Visible", new object[1] { true }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(WindowsUIButtonPanel3, (Type)null, "Visible", new object[1] { true }, (string[])null, (Type[])null, false, true);
			((Control)lblTotal).set_Visible(true);
		}
	}

	private void p5SCe3(object sender, EventArgs e)
	{
		NewLateBinding.LateCall(PrintDailyRecords, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateSetComplex(PrintDailyRecords, (Type)null, "TopMost", new object[1] { true }, (string[])null, (Type[])null, false, true);
	}

	internal static object Mw0x9R(object y4Y1Rp)
	{
		AppDomain currentDomain = AppDomain.CurrentDomain;
		object[] obj = new object[1] { y4Y1Rp };
		Array array = obj;
		bool[] obj2 = new bool[1] { true };
		object obj3 = obj2;
		object obj4 = NewLateBinding.LateGet((object)currentDomain, (Type)null, "Load", obj, (string[])null, (Type[])null, obj2);
		if (((bool[])obj3)[0])
		{
			y4Y1Rp = RuntimeHelpers.GetObjectValue((array as object[])[0]);
		}
		return RuntimeHelpers.GetObjectValue(obj4);
	}

	static void f1NJq4()
	{
		//IL_0012: Expected O, but got I4
		//IL_00b3: Expected O, but got I4
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected O, but got I4
		//IL_0338: Expected O, but got I4
		//IL_03c5: Expected O, but got I4
		//IL_0628: Expected O, but got I4
		//IL_0630: Unknown result type (might be due to invalid IL or missing references)
		//IL_0631: Unknown result type (might be due to invalid IL or missing references)
		//IL_0640: Unknown result type (might be due to invalid IL or missing references)
		//IL_0641: Unknown result type (might be due to invalid IL or missing references)
		//IL_0760: Expected O, but got I4
		y0D y0D = y0D;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sy0 sy);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Xn05Ce xn05Ce);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out i1D i1D);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		if ((UIntPtr)(y0D.Width as f1P6Lz).SuppliedRecord == (UIntPtr)(nuint)0u)
		{
			do
			{
				if ((UIntPtr)((Xn05Ce)((Ag9)null).UserInfo).ObjectDetectorScalingMode != (UIntPtr)(nuint)0u)
				{
					_ = (e2.y6)((s7K2Ek)null).ObjectDetectorScalingMode;
				}
				else
				{
					xn05Ce = xn05Ce;
					i1D = (i1D)xn05Ce.ObjectDetectorSearchMode;
					_ = (Mr7n6D)i1D.PrintMonthlyRecords;
				}
				obj = obj;
			}
			while (obj != null);
		}
		else
		{
			object obj2;
			checked
			{
				num = unchecked((nuint)(UIntPtr)xn05Ce.UserInfo) + num;
				obj2 = ((y0D)null).Width;
			}
			_003F val = unchecked((nuint)default(UIntPtr)) / ((obj2 is UIntPtr) ? obj2 : null);
			sy = null;
			if ((int)checked(val - unchecked((nuint)(UIntPtr)sy.UserInfo)) == 0)
			{
				try
				{
					_ = (m8K)i1D.PrintMonthlyRecords;
				}
				finally
				{
					_ = (Ag9)((i1D)null).PrintMonthlyRecords;
					goto IL_00ed;
				}
			}
		}
		goto IL_00ed;
		IL_051c:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f3L6Rd f3L6Rd2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ag9 ag);
		Mt2 mt;
		try
		{
			f3L6Rd2 = (f3L6Rd)ag.UserInfo;
		}
		catch
		{
		}
		finally
		{
			mt = null;
			mt = null;
			goto IL_0543;
		}
		IL_0821:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a8C a8C);
		if ((UIntPtr)((Yg89Py)null).DBForFoodManagementConnectionString == (UIntPtr)(nuint)0u)
		{
			_ = (y0D)a8C.PayTMPay;
		}
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out b4 b);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out z3T z3T);
		if (num == (UIntPtr)(nuint)0u)
		{
			if (num == (UIntPtr)(nuint)0u)
			{
				b = b;
			}
			else
			{
				z3T = z3T;
				_ = (s7K2Ek)(object)((Yg89Py)null).DBForFoodManagementConnectionString;
			}
		}
		else
		{
			while (obj != null)
			{
				if ((UIntPtr)((f1P6Lz)xn05Ce.ObjectDetectorSearchMode).SuppliedRecord == (UIntPtr)(nuint)0u)
				{
					a8C = a8C;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sy50Xx sy50Xx);
		if (num == (UIntPtr)(nuint)0u)
		{
			try
			{
				y0D = y0D;
			}
			catch
			{
				sy50Xx = sy50Xx;
			}
			finally
			{
				sy50Xx = sy50Xx;
				mt = mt;
				_ = (Ag9)((Xn05Ce)a8C.PayTMPay).UserInfo;
				i1D = null;
				goto IL_08f1;
			}
		}
		goto IL_08f1;
		IL_08f1:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s7K2Ek s7K2Ek);
		while (f3L6Rd2.PrintDailyRecords != null)
		{
			s7K2Ek = s7K2Ek;
		}
		return;
		IL_0580:
		_ = (Sy0)(object)Yg89Py.Default;
		Wt9q7H wt9q7H = wt9q7H;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f1P6Lz f1P6Lz);
		_ = (Mr7n6D)f1P6Lz.Send_sms_to_customer;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Mr7n6D mr7n6D);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Se60Di se60Di);
		if ((UIntPtr)((Xn05Ce)null).ObjectDetectorScalingMode == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (Ag9)xn05Ce.ObjectDetectorScalingMode;
			}
			catch
			{
				try
				{
					z3T = z3T;
				}
				finally
				{
					s9.y6 y = null;
					goto end_IL_05c3;
				}
				end_IL_05c3:;
			}
		}
		else if ((UIntPtr)((Xn05Ce)null).UserInfo == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
				se60Di = null;
			}
		}
		else
		{
			UIntPtr intPtr = (UIntPtr)((Mr7n6D)null).ObjectDetectorScalingMode;
			num = default(UIntPtr);
			nuint num2;
			object obj6;
			checked
			{
				num2 = unchecked((nuint)default(UIntPtr)) - num;
				obj6 = y0D.Width;
			}
			if ((int)checked(unchecked((nuint)intPtr) + (num2 * (((obj6 is UIntPtr) ? obj6 : null) + num) - unchecked((nuint)default(UIntPtr)))) == 0)
			{
				z3T = (z3T)mr7n6D.ObjectDetectorScalingMode;
			}
			else
			{
				_ = (Ag9)(object)Yg89Py.Default;
			}
		}
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			z3T = null;
		}
		try
		{
			while (obj != null)
			{
				sy50Xx = (Sy50Xx)i1D.PrintMonthlyRecords;
			}
		}
		finally
		{
			_ = (b4)f1P6Lz.Send_sms_to_customer;
			_ = (f1P6Lz)((f3L6Rd)sy.SupplierDailyRecord).PrintDailyRecords;
			s7K2Ek = (s7K2Ek)((i1D)null).PrintMonthlyRecords;
			goto IL_06cf;
		}
		IL_01e5:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Bs bs);
		checked
		{
			try
			{
				try
				{
					_ = (Bs)(object)Yg89Py.Default;
				}
				catch
				{
					bs = bs;
				}
			}
			catch
			{
				if (unchecked((nuint)(UIntPtr)((a8C)((f3L6Rd)((i1D)null).PrintMonthlyRecords).PrintDailyRecords).PayTMPay) * unchecked(num / checked(unchecked((nuint)(UIntPtr)i1D.PrintMonthlyRecords) + unchecked((nuint)(UIntPtr)((s7K2Ek)((s7K2Ek)f1P6Lz.SupplierDailyRecord).ObjectDetectorScalingMode).ObjectDetectorSearchMode))) == 0)
				{
					ag = null;
					ag = ag;
				}
				else
				{
					mr7n6D = mr7n6D;
					_ = (m8K)((Ag9)mr7n6D.SelectImageGetFrom).UserInfo;
				}
			}
			finally
			{
				_ = (Sy50Xx)(object)Yg89Py.Default;
				_ = (x6LFp1)((s7K2Ek)((Xn05Ce)null).ObjectDetectorSearchMode).ObjectDetectorScalingMode;
				xn05Ce = xn05Ce;
				goto IL_02bd;
			}
		}
		IL_02bd:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Hf08Tc hf08Tc);
		try
		{
			if ((UIntPtr)sy.UserInfo == (UIntPtr)(nuint)0u)
			{
				do
				{
					se60Di = se60Di;
					se60Di = se60Di;
					f3L6Rd2 = f3L6Rd2;
					Hf08Tc obj9 = (Hf08Tc)f3L6Rd2.PrintDailyRecords;
					hf08Tc = hf08Tc;
					hf08Tc = obj9;
				}
				while (((Sy0)a8C.PayTMPay).SuppliedRecord != null);
			}
			else
			{
				_ = (Bs)mr7n6D.SelectImageGetFrom;
			}
		}
		catch
		{
			do
			{
				UIntPtr num3 = (UIntPtr)(y0D.Width as Mr7n6D).ObjectDetectorScalingMode;
				num = default(UIntPtr);
				checked
				{
					if (unchecked((nuint)num3) + num == 0)
					{
						_ = (f3L6Rd)(object)Yg89Py.Default;
					}
				}
			}
			while (mr7n6D.ObjectDetectorScalingMode != null);
		}
		do
		{
			_ = (Bs)f1P6Lz.SupplierDailyRecord;
			_ = (Yg89Py)f1P6Lz.SupplierDailyRecord;
		}
		while (obj != null);
		if (num == 0)
		{
			try
			{
				_ = (Ez0)f1P6Lz.SupplierDailyRecord;
			}
			catch
			{
				f1P6Lz = null;
			}
		}
		else
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out s4C8Py s4C8Py);
			do
			{
				s4C8Py obj12 = y0D.Width as s4C8Py;
				s4C8Py = s4C8Py;
				s4C8Py = obj12;
			}
			while (obj != null);
		}
		_ = (y0D)f1P6Lz.SuppliedRecord;
		num = default(UIntPtr);
		if (checked(num * num) == 0)
		{
			Sy50Xx obj13 = (Sy50Xx)((Ag9)f3L6Rd2.PrintDailyRecords).UserInfo;
			sy50Xx = null;
			sy50Xx = obj13;
		}
		else if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
				y0D = y0D;
			}
		}
		_ = (Ag9)((Sy0)null).UserInfo;
		try
		{
			num = default(UIntPtr);
			if (num != 0)
			{
				try
				{
					_ = (Sy0)((Ag9)((Sy0)null).UserInfo).UserInfo;
				}
				finally
				{
					_ = (y0D)((Sy0)((f1P6Lz)null).SupplierDailyRecord).SupplierInfo;
					goto end_IL_044e;
				}
			}
			checked
			{
				if (unchecked((nuint)(UIntPtr)f3L6Rd2.PrintDailyRecords) + (num + unchecked((nuint)(UIntPtr)((i1D)null).PrintMonthlyRecords)) == 0)
				{
					_ = (f3L6Rd)((s7K2Ek)ag.UserInfo).ObjectDetectorSearchMode;
				}
			}
			end_IL_044e:;
		}
		finally
		{
			if ((UIntPtr)((Sy0)i1D.PrintMonthlyRecords).SuppliedRecord == (UIntPtr)(nuint)0u)
			{
				while (obj != null)
				{
					wt9q7H = wt9q7H;
					wt9q7H = null;
					i1D = (i1D)((Ag9)null).UserInfo;
					ag = (Ag9)((s7K2Ek)null).ObjectDetectorScalingMode;
				}
			}
			goto IL_051c;
		}
		IL_00ed:
		Yg89Py yg89Py = (Yg89Py)xn05Ce.ObjectDetectorSearchMode;
		_ = (z3T)(object)yg89Py.Fast_food_managementConnectionString;
		num = default(UIntPtr);
		if (num == 0)
		{
			try
			{
				s9.y6 y = (s9.y6)((f1P6Lz)null).SuppliedRecord;
				y = y;
				f1P6Lz = f1P6Lz;
				_ = (Sy0)f1P6Lz.SupplierDailyRecord;
				_ = (s4C8Py)((f3L6Rd)(y0D.Width as Mr7n6D).ObjectDetectorSearchMode).PrintDailyRecords;
			}
			finally
			{
				goto IL_0173;
			}
		}
		goto IL_0173;
		IL_0543:
		try
		{
			y0D = y0D;
		}
		finally
		{
			do
			{
				try
				{
					_ = (Sy0)((i1D)null).PrintMonthlyRecords;
					hf08Tc = hf08Tc;
					b = b;
				}
				finally
				{
					mr7n6D = mr7n6D;
					continue;
				}
			}
			while (obj != null);
			goto IL_0580;
		}
		IL_0173:
		if (num == 0)
		{
			try
			{
				_ = (i1D)f1P6Lz.Send_sms_to_customer;
			}
			finally
			{
				if (num == 0)
				{
					m8K m8K = m8K;
					m8K = null;
				}
				else
				{
					z3T = null;
					z3T = z3T;
				}
				goto IL_01e5;
			}
		}
		sy = null;
		s7K2Ek obj14 = (s7K2Ek)sy.SuppliedRecord;
		s7K2Ek = s7K2Ek;
		s7K2Ek = obj14;
		yg89Py = yg89Py;
		Ez0 ez = ez;
		ez = ez;
		goto IL_01e5;
		IL_06cf:
		do
		{
			try
			{
				_ = (z3T)((Xn05Ce)null).ObjectDetectorSearchMode;
			}
			catch
			{
				yg89Py = yg89Py;
			}
			finally
			{
				do
				{
					_ = (b4)((a8C)null).PayTMPay;
				}
				while (obj != null);
				continue;
			}
		}
		while (obj != null);
		if (num == (UIntPtr)(nuint)0u)
		{
			try
			{
				bs = bs;
			}
			catch
			{
				if ((UIntPtr)((a8C)null).PayTMPay == (UIntPtr)(nuint)0u)
				{
					_ = (y0D)(object)Yg89Py.Default;
				}
				else
				{
					_ = (Ty5k0C)((f3L6Rd)null).PrintDailyRecords;
					_ = (Mm0)f3L6Rd2.PrintDailyRecords;
					y0D = y0D;
				}
			}
		}
		_ = ((y0D)null).Width is y0D;
		try
		{
			if (num != (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (y0D)f1P6Lz.SuppliedRecord;
					f3L6Rd2 = null;
					_ = (m8K)mr7n6D.ObjectDetectorScalingMode;
					se60Di = se60Di;
				}
				finally
				{
					mt = mt;
					goto end_IL_0765;
				}
			}
			x6LFp1 x6LFp = x6LFp;
			x6LFp = x6LFp;
			end_IL_0765:;
		}
		finally
		{
			try
			{
				m8K m8K = null;
			}
			catch
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (i7Z8Et)(object)((Yg89Py)((Sy0)i1D.PrintMonthlyRecords).SupplierDailyRecord).Fast_food_managementConnectionString;
					_ = (m8K)((a8C)null).PayTMPay;
					m8K m8K = null;
					_ = (Ty5k0C)sy.SuppliedRecord;
				}
				else
				{
					bs = bs;
				}
			}
			goto IL_0821;
		}
	}
}
