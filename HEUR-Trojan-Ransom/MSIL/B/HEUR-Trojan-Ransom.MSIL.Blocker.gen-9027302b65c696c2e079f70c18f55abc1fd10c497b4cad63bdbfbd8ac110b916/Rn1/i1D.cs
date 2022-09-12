using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
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
using Sn7x6Z;
using c1CLx2;
using d0P;
using e2;
using g8GLd9;
using j1H5Ld;
using m2Q;
using n2Z;
using o1KZx9;
using p6MRy9;
using s9;
using t5C8Kg;
using t7S;
using w0XGc7;
using x6T;

namespace Rn1;

[DesignerGenerated]
public class i1D : Form
{
	[StructLayout(LayoutKind.Auto)]
	internal struct b4D
	{
		internal Label label_0;

		internal Chart chart_0;

		internal object object_0;

		internal object object_1;

		internal Panel panel_0;

		internal Label label_1;

		internal object object_2;
	}

	internal sealed class a8J
	{
		internal IContainer icontainer_0;

		internal object object_0;

		internal object object_1;

		internal object object_2;

		internal object object_3;

		internal Label label_0;

		internal object object_4;

		internal Label label_1;

		internal Timer timer_0;

		internal Timer timer_1;

		internal Label label_2;

		internal object object_5;

		internal Panel panel_0;

		internal object object_6;

		internal object object_7;

		internal a8J()
		{
		}
	}

	private IContainer components;

	[AccessedThroughProperty("Chart1")]
	private Chart _Chart1;

	[AccessedThroughProperty("grdviewDailyRecord")]
	private object _grdviewDailyRecord;

	[AccessedThroughProperty("lblProgress")]
	private object _lblProgress;

	[AccessedThroughProperty("lblTotal")]
	private Label _lblTotal;

	private object _PrintMonthlyRecords;

	private Ag9.o6 o6_0 = new Ag9.o6();

	internal virtual object btnrefresh
	{
		get
		{
			return o6_0.object_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			o6_0.object_0 = objectValue;
		}
	}

	internal virtual object btnclose
	{
		get
		{
			return o6_0.object_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			o6_0.object_1 = objectValue;
		}
	}

	internal virtual Chart Chart1
	{
		get
		{
			return _Chart1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Chart1 = value;
		}
	}

	internal virtual Label Label2
	{
		get
		{
			return o6_0.label_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected O, but got Unknown
			o6_0.label_0 = value;
		}
	}

	internal virtual Label Label1
	{
		get
		{
			return o6_0.label_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			o6_0.label_1 = ((value is Label) ? value : null);
		}
	}

	internal virtual object datepkrDailyRecord
	{
		get
		{
			return o6_0.object_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			o6_0.object_2 = objectValue;
		}
	}

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

	internal virtual Timer tmrLoad
	{
		get
		{
			return o6_0.timer_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Expected O, but got Unknown
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			object obj = new EventHandler(s0M);
			Component timer_ = (Component)(object)o6_0.timer_0;
			if ((int)(Timer)timer_ != 0)
			{
				((Timer)((timer_ is Timer) ? timer_ : null)).remove_Tick(obj as EventHandler);
			}
			o6_0.timer_0 = value;
			timer_ = (Component)(object)o6_0.timer_0;
			if ((int)(Timer)timer_ != 0)
			{
				((Timer)((timer_ is Timer) ? timer_ : null)).add_Tick(obj as EventHandler);
			}
		}
	}

	internal virtual Panel Panel2
	{
		get
		{
			return o6_0.panel_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			o6_0.panel_0 = ((value is Panel) ? value : null);
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
			return o6_0.object_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			o6_0.object_3 = objectValue;
		}
	}

	internal virtual object WindowsUIButtonPanel3
	{
		get
		{
			return o6_0.object_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			o6_0.object_4 = objectValue;
		}
	}

	internal virtual Label lblTotal
	{
		get
		{
			return _lblTotal;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblTotal = value;
		}
	}

	public object PrintMonthlyRecords
	{
		get
		{
			return _PrintMonthlyRecords;
		}
		set
		{
			_PrintMonthlyRecords = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public i1D()
	{
		((Form)this).add_Load((EventHandler)y9F);
		Aa0();
	}

	protected override void So1(bool f5Z)
	{
		try
		{
			if (f5Z && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(f5Z);
		}
	}

	private void Aa0()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected O, but got Unknown
		//IL_054b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0551: Expected O, but got Unknown
		//IL_06d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d6: Expected O, but got Unknown
		//IL_0a0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a15: Expected O, but got Unknown
		//IL_0a5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a84: Expected O, but got Unknown
		//IL_0a85: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1a: Expected O, but got Unknown
		//IL_0b7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b86: Expected O, but got Unknown
		//IL_0c09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c13: Expected O, but got Unknown
		//IL_106f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1075: Expected O, but got Unknown
		//IL_1233: Unknown result type (might be due to invalid IL or missing references)
		//IL_1239: Expected O, but got Unknown
		//IL_1260: Unknown result type (might be due to invalid IL or missing references)
		//IL_1266: Expected O, but got Unknown
		//IL_1351: Unknown result type (might be due to invalid IL or missing references)
		//IL_1584: Unknown result type (might be due to invalid IL or missing references)
		//IL_158e: Expected O, but got Unknown
		//IL_164b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1655: Expected O, but got Unknown
		//IL_1661: Unknown result type (might be due to invalid IL or missing references)
		//IL_166b: Expected O, but got Unknown
		//IL_1677: Unknown result type (might be due to invalid IL or missing references)
		//IL_1681: Expected O, but got Unknown
		//IL_16af: Unknown result type (might be due to invalid IL or missing references)
		//IL_16b9: Expected O, but got Unknown
		//IL_16c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_16cf: Expected O, but got Unknown
		//IL_16ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_16f6: Expected O, but got Unknown
		//IL_1702: Unknown result type (might be due to invalid IL or missing references)
		//IL_170c: Expected O, but got Unknown
		components = new Container();
		object obj = new ComponentResourceManager(typeof(i1D));
		object obj2 = (object)new ChartArea();
		object obj3 = (object)new Legend();
		DataPointCustomProperties val = (DataPointCustomProperties)new Series();
		Chart1 = new Chart();
		Label2 = new Label();
		Label1 = new Label();
		tmrLoad = new Timer(components);
		Panel2 = new Panel();
		lblTotal = new Label();
		((ISupportInitialize)Chart1).BeginInit();
		((ISupportInitialize)grdviewDailyRecord).BeginInit();
		((ISupportInitialize)NewLateBinding.LateGet(grdviewDailyRecord, (Type)null, "MasterTemplate", new object[0], (string[])null, (Type[])null, (bool[])null)).BeginInit();
		((Control)this).SuspendLayout();
		NewLateBinding.LateSetComplex(btnrefresh, (Type)null, "Activecolor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnrefresh, (Type)null, "BackColor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnrefresh, (Type)null, "BackgroundImageLayout", new object[1] { (object)(ImageLayout)3 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnrefresh, (Type)null, "BorderRadius", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnrefresh, (Type)null, "ButtonText", new object[1] { "Refresh" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnrefresh, (Type)null, "Cursor", new object[1] { Cursors.get_Hand() }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnrefresh, (Type)null, "DisabledColor", new object[1] { Color.Gray }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnrefresh, (Type)null, "Iconcolor", new object[1] { Color.Transparent }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnrefresh, (Type)null, "Iconimage", new object[1] { (object)(Image)((ComponentResourceManager)obj).GetObject("btnrefresh.Iconimage") }, (string[])null, (Type[])null, false, true);
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
			new Point(934, 132)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnrefresh, (Type)null, "Name", new object[1] { "btnrefresh" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnrefresh, (Type)null, "Normalcolor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnrefresh, (Type)null, "OnHovercolor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnrefresh, (Type)null, "OnHoverTextColor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnrefresh, (Type)null, "selected", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnrefresh, (Type)null, "Size", new object[1]
		{
			new Size(135, 46)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnrefresh, (Type)null, "TabIndex", new object[1] { 19 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnrefresh, (Type)null, "Text", new object[1] { "Refresh" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnrefresh, (Type)null, "TextAlign", new object[1] { (object)(ContentAlignment)16 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnrefresh, (Type)null, "Textcolor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnrefresh, (Type)null, "TextFont", new object[1] { (object)new Font("Century Gothic", 15.75f) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnrefresh, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnclose, (Type)null, "Activecolor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnclose, (Type)null, "BackColor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnclose, (Type)null, "BackgroundImageLayout", new object[1] { (object)(ImageLayout)3 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnclose, (Type)null, "BorderRadius", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnclose, (Type)null, "ButtonText", new object[1] { "Close" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnclose, (Type)null, "Cursor", new object[1] { Cursors.get_Hand() }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnclose, (Type)null, "DisabledColor", new object[1] { Color.Gray }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnclose, (Type)null, "Iconcolor", new object[1] { Color.Transparent }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnclose, (Type)null, "Iconimage", new object[1] { (object)(Image)(obj as ComponentResourceManager).GetObject("btnclose.Iconimage") }, (string[])null, (Type[])null, false, true);
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
			new Point(934, 193)
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
		NewLateBinding.LateSetComplex(btnclose, (Type)null, "TabIndex", new object[1] { 20 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnclose, (Type)null, "Text", new object[1] { "Close" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnclose, (Type)null, "TextAlign", new object[1] { (object)(ContentAlignment)16 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnclose, (Type)null, "Textcolor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnclose, (Type)null, "TextFont", new object[1] { (object)new Font("Century Gothic", 15.75f) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnclose, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null, false, true);
		((Control)Chart1).set_BackgroundImageLayout((ImageLayout)0);
		Chart1.set_BackSecondaryColor(Color.Black);
		((ChartArea)obj2).set_Name("ChartArea1");
		((Collection<ChartArea>)(object)Chart1.get_ChartAreas()).Add((ChartArea)obj2);
		((Legend)obj3).set_Name("Legend1");
		((Collection<Legend>)(object)Chart1.get_Legends()).Add((Legend)((obj3 is Legend) ? obj3 : null));
		((Control)Chart1).set_Location(new Point(415, 239));
		((Control)Chart1).set_Name("Chart1");
		((Series)val).set_ChartArea("ChartArea1");
		((Series)val).set_Legend("Legend1");
		((Series)((val is Series) ? val : null)).set_Name("Daily Record");
		((Collection<Series>)(object)Chart1.get_Series()).Add((Series)val);
		Chart1.set_Size(new Size(654, 385));
		((Control)Chart1).set_TabIndex(18);
		((Control)Chart1).set_Text("Chart1");
		((Control)Chart1).set_Visible(false);
		Label2.set_AutoSize(true);
		((Control)Label2).set_Font(new Font("Century Gothic", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_Location(new Point(474, 159));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(106, 20));
		((Control)Label2).set_TabIndex(17);
		Label2.set_Text("Select Month");
		((Control)Label2).set_Visible(false);
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Century Gothic", 36f));
		((Control)Label1).set_Location(new Point(443, 46));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(411, 58));
		((Control)Label1).set_TabIndex(16);
		Label1.set_Text("Monthly Records");
		((Control)Label1).set_Visible(false);
		NewLateBinding.LateSetComplex(datepkrDailyRecord, (Type)null, "BackColor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(datepkrDailyRecord, (Type)null, "BorderRadius", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(datepkrDailyRecord, (Type)null, "ForeColor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(datepkrDailyRecord, (Type)null, "Format", new object[1] { (object)(DateTimePickerFormat)2 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(datepkrDailyRecord, (Type)null, "FormatCustom", new object[1] { "dd-MMM-yy" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(datepkrDailyRecord, (Type)null, "Location", new object[1]
		{
			new Point(591, 151)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(datepkrDailyRecord, (Type)null, "Name", new object[1] { "datepkrDailyRecord" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(datepkrDailyRecord, (Type)null, "Size", new object[1]
		{
			new Size(246, 36)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(datepkrDailyRecord, (Type)null, "TabIndex", new object[1] { 15 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(datepkrDailyRecord, (Type)null, "Value", new object[1]
		{
			new DateTime(2018, 1, 14, 11, 37, 24, 933)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(datepkrDailyRecord, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(grdviewDailyRecord, (Type)null, "Location", new object[1]
		{
			new Point(12, 46)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(grdviewDailyRecord, (Type)null, "MasterTemplate", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "AllowAddNewRow", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(grdviewDailyRecord, (Type)null, "Name", new object[1] { "grdviewDailyRecord" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(grdviewDailyRecord, (Type)null, "ReadOnly", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(grdviewDailyRecord, (Type)null, "Size", new object[1]
		{
			new Size(397, 578)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(grdviewDailyRecord, (Type)null, "TabIndex", new object[1] { 14 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(grdviewDailyRecord, (Type)null, "Text", new object[1] { "grdviewDailyRecord" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(grdviewDailyRecord, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null, false, true);
		tmrLoad.set_Enabled(true);
		tmrLoad.set_Interval(30);
		((Control)Panel2).set_BackColor(Color.FromArgb(174, 8, 40));
		((Control)Panel2).set_Dock((DockStyle)1);
		((Control)Panel2).set_Location(new Point(0, 0));
		((Control)Panel2).set_Name("Panel2");
		((Control)Panel2).set_Size(new Size(1095, 25));
		((Control)Panel2).set_TabIndex(23);
		NewLateBinding.LateSetComplex(lblProgress, (Type)null, "AutoSize", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(lblProgress, (Type)null, "Depth", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(lblProgress, (Type)null, "Font", new object[1] { (object)new Font("Roboto", 11f) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(lblProgress, (Type)null, "ForeColor", new object[1] { Color.FromArgb(222, 0, 0, 0) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(lblProgress, (Type)null, "Location", new object[1]
		{
			new Point(504, 251)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(lblProgress, (Type)null, "Name", new object[1] { "lblProgress" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(lblProgress, (Type)null, "Size", new object[1]
		{
			new Size(121, 19)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(lblProgress, (Type)null, "TabIndex", new object[1] { 21 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(lblProgress, (Type)null, "Text", new object[1] { "Loading Records" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(pbarcircle, (Type)null, "animated", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(pbarcircle, (Type)null, "animationIterval", new object[1] { 5 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(pbarcircle, (Type)null, "animationSpeed", new object[1] { 300 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(pbarcircle, (Type)null, "BackColor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(pbarcircle, (Type)null, "BackgroundImage", new object[1] { (object)(Image)((ComponentResourceManager)obj).GetObject("pbarcircle.BackgroundImage") }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(pbarcircle, (Type)null, "Font", new object[1] { (object)new Font("Microsoft Sans Serif", 26.25f) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(pbarcircle, (Type)null, "ForeColor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(pbarcircle, (Type)null, "LabelVisible", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(pbarcircle, (Type)null, "LineProgressThickness", new object[1] { 8 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(pbarcircle, (Type)null, "LineThickness", new object[1] { 5 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(pbarcircle, (Type)null, "Location", new object[1]
		{
			new Point(454, 279)
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
		NewLateBinding.LateSetComplex(pbarcircle, (Type)null, "TabIndex", new object[1] { 22 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(pbarcircle, (Type)null, "Value", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(WindowsUIButtonPanel3, (Type)null, "Location", new object[1]
		{
			new Point(1022, 397)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(WindowsUIButtonPanel3, (Type)null, "Name", new object[1] { "WindowsUIButtonPanel3" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(WindowsUIButtonPanel3, (Type)null, "Size", new object[1]
		{
			new Size(47, 64)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(WindowsUIButtonPanel3, (Type)null, "TabIndex", new object[1] { 24 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(WindowsUIButtonPanel3, (Type)null, "Text", new object[1] { "WindowsUIButtonPanel1" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(WindowsUIButtonPanel3, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null, false, true);
		lblTotal.set_AutoSize(true);
		((Control)lblTotal).set_Font(new Font("Century Gothic", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblTotal).set_Location(new Point(878, 46));
		((Control)lblTotal).set_Name("lblTotal");
		((Control)lblTotal).set_Size(new Size(42, 20));
		((Control)lblTotal).set_TabIndex(25);
		lblTotal.set_Text("Total");
		((Control)lblTotal).set_Visible(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.White);
		((Form)this).set_ClientSize(new Size(1095, 639));
		((Control)this).get_Controls().Add((Control)(object)lblTotal);
		((Control)this).get_Controls().Add((Control)WindowsUIButtonPanel3);
		((Control)this).get_Controls().Add((Control)btnrefresh);
		((Control)this).get_Controls().Add((Control)btnclose);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)datepkrDailyRecord);
		((Control)this).get_Controls().Add((Control)grdviewDailyRecord);
		((Control)this).get_Controls().Add((Control)(object)Panel2);
		((Control)this).get_Controls().Add((Control)lblProgress);
		((Control)this).get_Controls().Add((Control)pbarcircle);
		((Control)this).get_Controls().Add((Control)(object)Chart1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("MonthlyData");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Monthly Data");
		((ISupportInitialize)Chart1).EndInit();
		((ISupportInitialize)NewLateBinding.LateGet(grdviewDailyRecord, (Type)null, "MasterTemplate", new object[0], (string[])null, (Type[])null, (bool[])null)).EndInit();
		((ISupportInitialize)grdviewDailyRecord).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void s0M(object sender, EventArgs e)
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
			((Control)lblTotal).set_Visible(true);
			((Control)lblTotal).set_Visible(true);
		}
	}

	private void y9F(object sender, EventArgs e)
	{
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
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
		IEnumerable<char> enumerable = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(datepkrDailyRecord, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Month", new object[0], (string[])null, (Type[])null, (bool[])null));
		IEnumerable<char> enumerable2 = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(datepkrDailyRecord, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Year", new object[0], (string[])null, (Type[])null, (bool[])null));
		object obj = (string)enumerable + "-" + (enumerable2 as string);
		IDisposable cmd = (IDisposable)Rf7.cmd;
		((OleDbCommand)cmd).set_Connection(Rf7.cnn);
		((OleDbCommand)cmd).set_CommandText("SELECT totalprice,orderdate from productdata  where mondate='" + (obj as string).ToString() + "'");
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
				lblTotal.set_Text("Rs. " + Conversions.ToString(num));
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				lblTotal.set_Text("Rs. 00");
				ProjectData.ClearProjectError();
			}
			Chart1.set_DataSource((object)(DataTable)marshalByValueComponent);
			((ChartNamedElementCollection<Series>)(object)Chart1.get_Series()).get_Item("Daily Record").set_YValueMembers("totalprice");
			((ChartNamedElementCollection<Series>)(object)Chart1.get_Series()).get_Item("Daily Record").set_XValueMember("orderdate");
			IDbCommand cmd2 = (IDbCommand)Rf7.cmd;
			((OleDbCommand)((cmd2 is OleDbCommand) ? cmd2 : null)).set_Connection(Rf7.cnn);
			((OleDbCommand)cmd2).set_CommandText("Select orderno As [Order No], itemname As [Item Name], quantity As [Quantity], totalprice As [Total Price], orderdate As [Date And Time],payment As [Paid By] from productdata where mondate='" + (obj as string) + "'");
			cmd2 = null;
			IListSource listSource = new DataTable();
			Rf7.da.set_SelectCommand(Rf7.cmd);
			try
			{
				((DbDataAdapter)(object)Rf7.da).Fill((DataTable)listSource);
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				ProjectData.ClearProjectError();
			}
			NewLateBinding.LateSetComplex(grdviewDailyRecord, (Type)null, "DataSource", new object[1] { listSource as DataTable }, (string[])null, (Type[])null, false, true);
			Rf7.cnn.Close();
			object obj2 = new string[14];
			((string[])obj2)[0] = Conversions.ToString(1);
			((string[])obj2)[1] = Conversions.ToString(8);
			((string[])obj2)[2] = Conversions.ToString(9);
			((string[])obj2)[3] = Conversions.ToString(6);
			(obj2 as string[])[4] = Conversions.ToString(3);
			(obj2 as string[])[5] = Conversions.ToString(11);
			(obj2 as string[])[6] = Conversions.ToString(10);
			((string[])obj2)[7] = Conversions.ToString(12);
			(obj2 as string[])[8] = Conversions.ToString(2);
			((string[])obj2)[9] = Conversions.ToString(4);
			(obj2 as string[])[10] = Conversions.ToString(5);
			object obj3 = new Random();
			int num2 = ((Random)obj3).Next(0, 12);
			Chart1.set_Palette((ChartColorPalette)Conversions.ToInteger((obj2 as string[])[num2]));
		}
	}

	private void p5N(object sender, EventArgs e)
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		Rf7.Zj9();
		Rf7.cnn.Open();
		IComparable comparable = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(datepkrDailyRecord, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Month", new object[0], (string[])null, (Type[])null, (bool[])null));
		IConvertible convertible = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(datepkrDailyRecord, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Year", new object[0], (string[])null, (Type[])null, (bool[])null));
		IConvertible convertible2 = (comparable as string) + "-" + (string)convertible;
		IDisposable cmd = (IDisposable)Rf7.cmd;
		((OleDbCommand)cmd).set_Connection(Rf7.cnn);
		((OleDbCommand)((cmd is OleDbCommand) ? cmd : null)).set_CommandText("SELECT totalprice,orderdate from productdata  where mondate='" + ((string)convertible2).ToString() + "'");
		cmd = null;
		IXmlSerializable xmlSerializable = new DataTable();
		Rf7.da.set_SelectCommand(Rf7.cmd);
		try
		{
			((DbDataAdapter)(object)Rf7.da).Fill(xmlSerializable as DataTable);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		Chart1.set_DataSource((object)(DataTable)xmlSerializable);
		((ChartNamedElementCollection<Series>)(object)Chart1.get_Series()).get_Item("Daily Record").set_YValueMembers("totalprice");
		((ChartNamedElementCollection<Series>)(object)Chart1.get_Series()).get_Item("Daily Record").set_XValueMember("orderdate");
		ICloneable cmd2 = (ICloneable)Rf7.cmd;
		((OleDbCommand)((cmd2 is OleDbCommand) ? cmd2 : null)).set_Connection(Rf7.cnn);
		((OleDbCommand)cmd2).set_CommandText("Select orderno As [Order No], itemname As [Item Name], quantity As [Quantity], totalprice As [Total Price], orderdate As [Date And Time],payment As [Paid By] from productdata where mondate='" + (string)convertible2 + "'");
		cmd2 = null;
		ISupportInitialize supportInitialize = new DataTable();
		Rf7.da.set_SelectCommand(Rf7.cmd);
		try
		{
			((DbDataAdapter)(object)Rf7.da).Fill(supportInitialize as DataTable);
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		NewLateBinding.LateSetComplex(grdviewDailyRecord, (Type)null, "DataSource", new object[1] { (DataTable)supportInitialize }, (string[])null, (Type[])null, false, true);
		Rf7.cnn.Close();
		object obj = new string[14];
		((string[])obj)[0] = Conversions.ToString(1);
		(obj as string[])[1] = Conversions.ToString(8);
		(obj as string[])[2] = Conversions.ToString(9);
		((string[])obj)[3] = Conversions.ToString(6);
		((string[])obj)[4] = Conversions.ToString(3);
		(obj as string[])[5] = Conversions.ToString(11);
		((string[])obj)[6] = Conversions.ToString(10);
		(obj as string[])[7] = Conversions.ToString(12);
		((string[])obj)[8] = Conversions.ToString(2);
		((string[])obj)[9] = Conversions.ToString(4);
		(obj as string[])[10] = Conversions.ToString(5);
		object obj2 = new Random();
		int num = ((Random)obj2).Next(0, 12);
		Chart1.set_Palette((ChartColorPalette)Conversions.ToInteger(((string[])obj)[num]));
	}

	private void Td1(object sender, EventArgs e)
	{
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		Rf7.Zj9();
		Rf7.cnn.Open();
		IEquatable<string> equatable = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(datepkrDailyRecord, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Month", new object[0], (string[])null, (Type[])null, (bool[])null));
		IEquatable<string> equatable2 = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(datepkrDailyRecord, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Year", new object[0], (string[])null, (Type[])null, (bool[])null));
		object obj = (equatable as string) + "-" + (string)equatable2;
		IDisposable cmd = (IDisposable)Rf7.cmd;
		((OleDbCommand)((cmd is OleDbCommand) ? cmd : null)).set_Connection(Rf7.cnn);
		((OleDbCommand)cmd).set_CommandText("SELECT totalprice,orderdate from productdata  where mondate='" + ((string)obj).ToString() + "'");
		cmd = null;
		object obj2 = new DataTable();
		Rf7.da.set_SelectCommand(Rf7.cmd);
		try
		{
			((DbDataAdapter)(object)Rf7.da).Fill((DataTable)obj2);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		Chart1.set_DataSource((object)(DataTable)obj2);
		((ChartNamedElementCollection<Series>)(object)Chart1.get_Series()).get_Item("Daily Record").set_YValueMembers("totalprice");
		((ChartNamedElementCollection<Series>)(object)Chart1.get_Series()).get_Item("Daily Record").set_XValueMember("orderdate");
		IDisposable cmd2 = (IDisposable)Rf7.cmd;
		((OleDbCommand)cmd2).set_Connection(Rf7.cnn);
		((OleDbCommand)cmd2).set_CommandText("Select orderno As [Order No], itemname As [Item Name], quantity As [Quantity], totalprice As [Total Price], orderdate As [Date And Time],payment As [Paid By] from productdata where mondate='" + (string)obj + "'");
		cmd2 = null;
		object obj3 = new DataTable();
		Rf7.da.set_SelectCommand(Rf7.cmd);
		try
		{
			((DbDataAdapter)(object)Rf7.da).Fill(obj3 as DataTable);
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		NewLateBinding.LateSetComplex(grdviewDailyRecord, (Type)null, "DataSource", new object[1] { obj3 as DataTable }, (string[])null, (Type[])null, false, true);
		Rf7.cnn.Close();
		Array array = new string[14];
		((string[])array)[0] = Conversions.ToString(1);
		(array as string[])[1] = Conversions.ToString(8);
		((string[])array)[2] = Conversions.ToString(9);
		(array as string[])[3] = Conversions.ToString(6);
		((string[])array)[4] = Conversions.ToString(3);
		(array as string[])[5] = Conversions.ToString(11);
		((string[])array)[6] = Conversions.ToString(10);
		(array as string[])[7] = Conversions.ToString(12);
		(array as string[])[8] = Conversions.ToString(2);
		((string[])array)[9] = Conversions.ToString(4);
		((string[])array)[10] = Conversions.ToString(5);
		object obj4 = new Random();
		int num = ((Random)obj4).Next(0, 12);
		Chart1.set_Palette((ChartColorPalette)Conversions.ToInteger(((string[])array)[num]));
	}

	private void c2T(object sender, EventArgs e)
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

	private void Bf5(object sender, EventArgs e)
	{
	}

	private void x3S(object sender, EventArgs e)
	{
		NewLateBinding.LateCall(PrintMonthlyRecords, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	static void Aj8()
	{
		//IL_0267: Expected O, but got I4
		//IL_037f: Expected O, but got I4
		//IL_04d0: Expected O, but got I4
		//IL_04e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_052b: Expected O, but got I4
		//IL_054d: Expected O, but got I4
		//IL_0582: Expected O, but got I4
		//IL_0599: Expected O, but got I4
		//IL_0698: Expected O, but got I4
		//IL_0737: Expected O, but got I4
		//IL_0823: Expected O, but got I4
		//IL_08bb: Expected O, but got I4
		//IL_095f: Expected O, but got I4
		//IL_0ad9: Expected O, but got I4
		//IL_0af6: Expected O, but got I4
		//IL_0d05: Expected O, but got I4
		//IL_0d55: Expected O, but got I4
		//IL_0da7: Expected O, but got I4
		//IL_0db7: Expected O, but got I4
		//IL_0e54: Expected O, but got I4
		Mr7n6D mr7n6D;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		do
		{
			mr7n6D = null;
			mr7n6D = mr7n6D;
			obj = obj;
		}
		while (obj != null);
		nuint uIntPtr = default(UIntPtr);
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a8C a8C);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f1P6Lz f1P6Lz);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out m8K m8K);
		if (checked(uIntPtr + uIntPtr) == 0)
		{
			a8C = null;
			_ = (Mr7n6D)a8C.PayTMPay;
		}
		else
		{
			try
			{
				m8K = null;
				m8K = m8K;
			}
			catch
			{
				do
				{
					f1P6Lz = null;
					f1P6Lz = f1P6Lz;
				}
				while (obj != null);
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Yg89Py yg89Py);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Rf7 rf);
		try
		{
			_ = (e2.y6)((Ag9)null).UserInfo;
		}
		catch
		{
			if (uIntPtr / unchecked((nuint)default(UIntPtr)) == 0)
			{
				yg89Py = null;
				yg89Py = yg89Py;
			}
			else
			{
				_ = (Se60Di)((Sy0)null).SupplierInfo;
				Rf7 obj3 = (Rf7)(object)yg89Py.DBForFoodManagementConnectionString;
				rf = null;
				rf = obj3;
			}
		}
		finally
		{
			_003CModule_003E = _003CModule_003E;
			_003CModule_003E = null;
			goto IL_00e9;
		}
		IL_085b:
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Xn05Ce xn05Ce);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f3L6Rd f3L6Rd);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out b4 b);
		checked
		{
			if (uIntPtr == 0)
			{
				while (obj != null)
				{
					if (uIntPtr + uIntPtr + uIntPtr == 0)
					{
						_ = (Mt2)((f1P6Lz)null).SupplierDailyRecord;
					}
				}
			}
			try
			{
				if (uIntPtr * uIntPtr == 0)
				{
					do
					{
						_ = (Hf08Tc)f1P6Lz.Send_sms_to_customer;
						z3T z3T = ((y0D)((f3L6Rd)null).PrintDailyRecords).Width as z3T;
						z3T = z3T;
						f3L6Rd = f3L6Rd;
						_ = (a8C)((f1P6Lz)((f3L6Rd)null).PrintDailyRecords).SuppliedRecord;
					}
					while (xn05Ce.UserInfo != null);
				}
			}
			finally
			{
				try
				{
					do
					{
						_ = (Ez0)((Mr7n6D)((f1P6Lz)null).SupplierDailyRecord).ObjectDetectorScalingMode;
					}
					while (((a8C)null).PayTMPay != null);
				}
				catch
				{
					try
					{
						f1P6Lz = f1P6Lz;
					}
					finally
					{
						_ = (Ag9)((f1P6Lz)null).Send_sms_to_customer;
						m8K = m8K;
						b = b;
						goto end_IL_0925;
					}
					end_IL_0925:;
				}
				goto IL_0a13;
			}
		}
		IL_0468:
		if ((UIntPtr)((s7K2Ek)((Mr7n6D)(object)((Yg89Py)null).Fast_food_managementConnectionString).SelectImageGetFrom).ObjectDetectorSearchMode == (UIntPtr)(nuint)0u)
		{
			while (f3L6Rd.PrintDailyRecords != null)
			{
				while (obj != null)
				{
					_ = (x6LFp1)(object)yg89Py.DBForFoodManagementConnectionString;
				}
			}
		}
		try
		{
			_ = (Bs)((Xn05Ce)null).ObjectDetectorScalingMode;
		}
		finally
		{
			object obj6 = ((y0D)((Sy0)null).SupplierInfo).Width;
			object obj7 = ((obj6 is UIntPtr) ? obj6 : null);
			uIntPtr = default(UIntPtr);
			if ((int)(obj7 / (nuint)uIntPtr) == 0)
			{
				while (((Xn05Ce)a8C.PayTMPay).UserInfo != null)
				{
					m8K = null;
				}
			}
			goto IL_0508;
		}
		IL_0caf:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y0D y0D);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Mt2 mt);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out i1D i1D2);
		try
		{
			while (i1D2.PrintMonthlyRecords != null)
			{
				try
				{
					i1D2 = null;
				}
				finally
				{
					mt = mt;
					continue;
				}
			}
		}
		finally
		{
			do
			{
				if (uIntPtr != 0)
				{
					_ = (s7K2Ek)a8C.PayTMPay;
				}
				else
				{
					_ = y0D.Width is Ag9;
				}
			}
			while (mr7n6D.ObjectDetectorSearchMode != null);
			goto IL_0d16;
		}
		IL_0508:
		m8K = null;
		_ = ((y0D)((a8C)xn05Ce.ObjectDetectorScalingMode).PayTMPay).Width is Ag9;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Hf08Tc hf08Tc);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s7K2Ek s7K2Ek);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			while (y0D.Width is object)
			{
				y0D = y0D;
				if (!(y0D.Width is UIntPtr))
				{
					_003CModule_003E = _003CModule_003E;
					_ = (Wt9q7H)((a8C)((Mr7n6D)null).ObjectDetectorScalingMode).PayTMPay;
					_ = ((y0D)((i1D)null).PrintMonthlyRecords).Width is z3T;
					f3L6Rd = f3L6Rd;
				}
			}
		}
		else
		{
			while (obj != null)
			{
				try
				{
					_ = (Rf7)mr7n6D.SelectImageGetFrom;
				}
				finally
				{
					s7K2Ek = s7K2Ek;
					Hf08Tc obj8 = (Hf08Tc)s7K2Ek.ObjectDetectorScalingMode;
					hf08Tc = null;
					hf08Tc = obj8;
					continue;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ag9 ag);
		while (obj != null)
		{
			ag = ag;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ez0 ez);
		do
		{
			_ = (Se60Di)(object)((Yg89Py)((Xn05Ce)((Xn05Ce)((Ag9)null).UserInfo).ObjectDetectorScalingMode).ObjectDetectorScalingMode).DBForFoodManagementConnectionString;
			ez = ez;
			_ = (Xn05Ce)i1D2.PrintMonthlyRecords;
		}
		while (obj != null);
		try
		{
			try
			{
				i1D2 = (i1D)(object)((Yg89Py)((Ag9)null).UserInfo).DBForFoodManagementConnectionString;
				_ = (s7K2Ek)((f3L6Rd)((Mr7n6D)null).ObjectDetectorSearchMode).PrintDailyRecords;
			}
			catch
			{
				try
				{
					_ = (Wt9q7H)((i1D)null).PrintMonthlyRecords;
					_ = (a8C)i1D2.PrintMonthlyRecords;
				}
				catch
				{
					ez = ez;
				}
			}
		}
		catch
		{
			_ = ((y0D)null).Width is Mr7n6D;
		}
		UIntPtr num = (UIntPtr)f3L6Rd.PrintDailyRecords;
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out e2.y6 y);
		checked
		{
			if (unchecked((nuint)num) * uIntPtr == 0)
			{
				try
				{
					f3L6Rd = null;
				}
				finally
				{
					do
					{
						hf08Tc = null;
					}
					while (i1D2.PrintMonthlyRecords != null);
					goto IL_077c;
				}
			}
			if (uIntPtr - unchecked((nuint)default(UIntPtr)) == 0)
			{
				uIntPtr = default(UIntPtr);
				nuint num2 = (uIntPtr + uIntPtr) * unchecked((nuint)default(UIntPtr));
				uIntPtr = default(UIntPtr);
				unchecked
				{
					if (num2 / checked(uIntPtr * uIntPtr) == 0)
					{
						_ = ((y0D)null).Width is Rf7;
					}
				}
			}
			else if (default(UIntPtr) == unchecked((UIntPtr)(nuint)0u))
			{
				m8K = m8K;
				_ = (Bs)xn05Ce.UserInfo;
				e2.y6 obj12 = (e2.y6)((a8C)null).PayTMPay;
				y = y;
				y = obj12;
			}
			goto IL_077c;
		}
		IL_00e9:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Se60Di se60Di);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Mm0 mm);
		checked
		{
			try
			{
				if (unchecked((nuint)default(UIntPtr)) - unchecked((nuint)default(UIntPtr)) == 0)
				{
					ez = (Ez0)((s7K2Ek)((i1D)(object)Yg89Py.Default).PrintMonthlyRecords).ObjectDetectorSearchMode;
					ez = ez;
					_ = (_003CModule_003E)((f1P6Lz)mr7n6D.ObjectDetectorScalingMode).SupplierDailyRecord;
				}
				else
				{
					Ag9 obj13 = (Ag9)((i1D)((a8C)null).PayTMPay).PrintMonthlyRecords;
					ag = null;
					ag = obj13;
				}
			}
			catch
			{
				try
				{
					_ = (x6LFp1)((a8C)((Ag9)null).UserInfo).PayTMPay;
				}
				finally
				{
					_ = (_003CModule_003E)mr7n6D.UserInfo;
					goto end_IL_016e;
				}
				end_IL_016e:;
			}
			do
			{
				UIntPtr num3 = unchecked((UIntPtr)((s7K2Ek)ag.UserInfo).ObjectDetectorSearchMode);
				uIntPtr = default(UIntPtr);
				if (unchecked((nuint)num3) + uIntPtr == 0)
				{
					do
					{
						_ = (f1P6Lz)mr7n6D.SelectImageGetFrom;
						_ = (Se60Di)ag.UserInfo;
					}
					while (obj != null);
				}
			}
			while (obj != null);
			try
			{
				_ = (Ty5k0C)a8C.PayTMPay;
			}
			catch
			{
				do
				{
					_ = (Sy50Xx)((s7K2Ek)a8C.PayTMPay).ObjectDetectorScalingMode;
				}
				while (obj != null);
			}
			try
			{
				if (uIntPtr == 0)
				{
					if (uIntPtr == 0)
					{
						_ = (Ez0)((Ag9)mr7n6D.SelectImageGetFrom).UserInfo;
					}
				}
				else
				{
					xn05Ce = null;
					_ = ((y0D)xn05Ce.ObjectDetectorScalingMode).Width is Ez0;
					_ = (Xn05Ce)((Xn05Ce)null).ObjectDetectorScalingMode;
					yg89Py = null;
				}
			}
			catch
			{
				nuint num4 = uIntPtr;
				uIntPtr = default(UIntPtr);
				if (num4 - uIntPtr == 0)
				{
					try
					{
						_ = (s4C8Py)((Mr7n6D)((Mr7n6D)null).ObjectDetectorScalingMode).ObjectDetectorSearchMode;
						b = (b4)((Sy0)null).SupplierDailyRecord;
						b = default(b4);
						b = b;
						i1D2 = null;
						Se60Di obj16 = (Se60Di)i1D2.PrintMonthlyRecords;
						se60Di = (Se60Di)((Ag9)null).UserInfo;
						se60Di = obj16;
						_ = (Ez0)(object)Yg89Py.Default;
					}
					finally
					{
						m8K = m8K;
						xn05Ce = (Xn05Ce)(object)Yg89Py.Default;
						_ = (f1P6Lz)xn05Ce.ObjectDetectorScalingMode;
						f3L6Rd = f3L6Rd;
						a8C = (a8C)f3L6Rd.PrintDailyRecords;
						goto end_IL_0282;
					}
				}
				_ = (x6LFp1)((a8C)null).PayTMPay;
				_ = (Hf08Tc)((f3L6Rd)f1P6Lz.SuppliedRecord).PrintDailyRecords;
				Mm0 obj17 = ((y0D)((f3L6Rd)null).PrintDailyRecords).Width as Mm0;
				mm = mm;
				mm = obj17;
				end_IL_0282:;
			}
			try
			{
				do
				{
					nuint num5 = uIntPtr;
					nuint num6 = unchecked((nuint)default(UIntPtr)) - unchecked((nuint)default(UIntPtr)) * unchecked((nuint)(UIntPtr)((Sy0)((Sy0)((Xn05Ce)((f3L6Rd)null).PrintDailyRecords).ObjectDetectorSearchMode).SupplierInfo).SupplierInfo / (nuint)(UIntPtr)((Xn05Ce)null).ObjectDetectorSearchMode);
					uIntPtr = default(UIntPtr);
					if (num5 + (num6 + uIntPtr) == 0)
					{
						_ = (z3T)(object)yg89Py.Fast_food_managementConnectionString;
					}
				}
				while (obj != null);
			}
			finally
			{
				do
				{
					if (default(UIntPtr) != unchecked((UIntPtr)(nuint)0u))
					{
						mt = mt;
						mt = mt;
					}
					else
					{
						_ = (_003CModule_003E)((Sy0)ag.UserInfo).SupplierDailyRecord;
					}
				}
				while (obj != null);
				goto IL_0468;
			}
		}
		IL_077c:
		try
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					f1P6Lz = null;
					_ = (Sy0)((Xn05Ce)((f1P6Lz)null).Send_sms_to_customer).ObjectDetectorSearchMode;
				}
				else
				{
					_ = (Bs)(object)Yg89Py.Default;
				}
			}
			finally
			{
				do
				{
					se60Di = se60Di;
				}
				while (obj != null);
				goto end_IL_077d;
			}
			end_IL_077d:;
		}
		finally
		{
			checked
			{
				try
				{
					uIntPtr = default(UIntPtr);
					if (unchecked((nuint)default(UIntPtr)) - unchecked(unchecked((nuint)default(UIntPtr)) / (uIntPtr / (nuint)(UIntPtr)Yg89Py.Default)) - uIntPtr * unchecked((nuint)(UIntPtr)((Sy0)null).UserInfo) == 0)
					{
						_ = y0D.Width is b4;
					}
					else
					{
						_ = (Mm0)(object)((Yg89Py)null).DBForFoodManagementConnectionString;
						hf08Tc = hf08Tc;
						_ = (i1D)ag.UserInfo;
					}
				}
				finally
				{
					mm = mm;
					goto IL_085b;
				}
			}
		}
		IL_0d16:
		f3L6Rd = f3L6Rd;
		_ = (Xn05Ce)ag.UserInfo;
		s9.y6 y2 = y2;
		y2 = null;
		hf08Tc = hf08Tc;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sy0 sy);
		if (uIntPtr == 0)
		{
			while (y0D.Width is object)
			{
				try
				{
					_ = y0D.Width is a8C;
				}
				finally
				{
					_ = (Se60Di)sy.UserInfo;
					f1P6Lz = (f1P6Lz)mr7n6D.SelectImageGetFrom;
					_ = (b4)mr7n6D.UserInfo;
					_ = (s7K2Ek)f1P6Lz.SuppliedRecord;
					continue;
				}
			}
		}
		while (y0D.Width is object)
		{
		}
		_ = (Ez0)f3L6Rd.PrintDailyRecords;
		if ((UIntPtr)mr7n6D.ObjectDetectorScalingMode != (UIntPtr)(nuint)0u)
		{
			return;
		}
		try
		{
			Sy50Xx sy50Xx = (Sy50Xx)f1P6Lz.SupplierDailyRecord;
			sy50Xx = sy50Xx;
			_ = (Bs)((Mr7n6D)((i1D)sy.UserInfo).PrintMonthlyRecords).UserInfo;
			s7K2Ek = null;
			i1D2 = (i1D)f3L6Rd.PrintDailyRecords;
			return;
		}
		catch
		{
			try
			{
				_ = ((y0D)((Ag9)mr7n6D.SelectImageGetFrom).UserInfo).Width is Sy0;
				return;
			}
			finally
			{
				_ = (y0D)xn05Ce.ObjectDetectorSearchMode;
				return;
			}
		}
		IL_0b86:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out i7Z8Et i7Z8Et);
		checked
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Ty5k0C ty5k0C);
			do
			{
				nuint num7 = unchecked(uIntPtr / uIntPtr);
				uIntPtr = default(UIntPtr);
				if (num7 + uIntPtr + unchecked((nuint)(UIntPtr)s7K2Ek.ObjectDetectorScalingMode) == 0)
				{
					uIntPtr = default(UIntPtr);
					if (uIntPtr == 0)
					{
						ty5k0C = ty5k0C;
						ty5k0C = ty5k0C;
					}
					else
					{
						i7Z8Et = i7Z8Et;
					}
				}
			}
			while (obj != null);
			while (obj != null)
			{
				yg89Py = (Yg89Py)s7K2Ek.ObjectDetectorSearchMode;
			}
			try
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr + unchecked((nuint)(UIntPtr)mr7n6D.UserInfo) == 0)
				{
					uIntPtr = default(UIntPtr);
					if (uIntPtr == 0)
					{
						_ = (Ez0)ag.UserInfo;
					}
				}
			}
			catch
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					try
					{
						_ = (f1P6Lz)((f3L6Rd)null).PrintDailyRecords;
					}
					finally
					{
						_ = (s7K2Ek)i1D2.PrintMonthlyRecords;
						goto end_IL_0c09;
					}
				}
				end_IL_0c09:;
			}
			_ = (Mm0)((Mr7n6D)null).ObjectDetectorSearchMode;
			while (true)
			{
				if (obj != null)
				{
					sy = sy;
					_ = (m8K)(object)yg89Py.DBForFoodManagementConnectionString;
				}
				else if (obj == null)
				{
					break;
				}
			}
			_ = (Sy0)ag.UserInfo;
			b = b;
			s7K2Ek = s7K2Ek;
			m8K = m8K;
			try
			{
				_ = (Mt2)a8C.PayTMPay;
			}
			finally
			{
				i1D2 = null;
				goto IL_0caf;
			}
		}
		IL_0a13:
		while (obj != null)
		{
			if (!(y0D.Width is UIntPtr))
			{
				nuint num8;
				checked
				{
					num8 = unchecked((nuint)(UIntPtr)s7K2Ek.ObjectDetectorSearchMode) + unchecked((nuint)default(UIntPtr)) + unchecked((nuint)(UIntPtr)i1D2.PrintMonthlyRecords);
					uIntPtr = default(UIntPtr);
				}
				if (num8 / uIntPtr == 0)
				{
					y0D = y0D;
					sy = null;
					_ = (y0D)sy.UserInfo;
				}
				else
				{
					_ = (Hf08Tc)((Sy0)((a8C)null).PayTMPay).SuppliedRecord;
					rf = rf;
					_ = (f1P6Lz)mr7n6D.UserInfo;
				}
			}
			else
			{
				try
				{
					_ = (Wt9q7H)(object)((Yg89Py)null).DBForFoodManagementConnectionString;
				}
				catch
				{
					_ = (Bs)sy.SupplierDailyRecord;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s4C8Py s4C8Py);
		while ((((y0D)s7K2Ek.ObjectDetectorSearchMode).Width as f3L6Rd).PrintDailyRecords != null)
		{
			if ((UIntPtr)f1P6Lz.SupplierDailyRecord == (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)mr7n6D.UserInfo == (UIntPtr)(nuint)0u)
				{
					rf = (Rf7)ag.UserInfo;
					continue;
				}
				_ = (Rf7)((f1P6Lz)null).Send_sms_to_customer;
				_ = (f3L6Rd)((f1P6Lz)((Xn05Ce)null).ObjectDetectorSearchMode).SuppliedRecord;
				continue;
			}
			while (((a8C)null).PayTMPay != null)
			{
				s4C8Py obj22 = (s4C8Py)ag.UserInfo;
				s4C8Py = s4C8Py;
				s4C8Py = obj22;
				_ = (a8C)(object)((Yg89Py)null).Fast_food_managementConnectionString;
				i7Z8Et = null;
				i7Z8Et = null;
				_ = (y0D)(object)((Yg89Py)null).DBForFoodManagementConnectionString;
			}
		}
		y0D = y0D.Width as y0D;
		try
		{
			if (uIntPtr == 0)
			{
				y = y;
				ez = null;
				_ = (Mt2)((s7K2Ek)xn05Ce.ObjectDetectorScalingMode).ObjectDetectorScalingMode;
			}
			else if (uIntPtr == 0)
			{
				_ = (f3L6Rd)(object)yg89Py.DBForFoodManagementConnectionString;
			}
		}
		finally
		{
			try
			{
			}
			finally
			{
				f3L6Rd = f3L6Rd;
				goto IL_0b86;
			}
		}
	}

	static void a7H()
	{
		//IL_010c: Expected O, but got I4
		//IL_01bf: Expected O, but got I4
		//IL_02a0: Expected O, but got I4
		//IL_0455: Expected O, but got I4
		//IL_04e7: Expected O, but got I4
		//IL_05c7: Expected O, but got I4
		//IL_05fd: Expected O, but got I4
		//IL_0658: Expected O, but got I4
		//IL_07d5: Expected O, but got I4
		//IL_07e4: Expected O, but got I4
		//IL_07f6: Expected O, but got I4
		s7K2Ek s7K2Ek;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f3L6Rd f3L6Rd);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sy50Xx sy50Xx);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint uIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ty5k0C ty5k0C);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out x6LFp1 x6LFp);
		try
		{
			_ = (Mm0)((i1D)((Mr7n6D)((Xn05Ce)null).ObjectDetectorScalingMode).SelectImageGetFrom).PrintMonthlyRecords;
		}
		finally
		{
			s7K2Ek = null;
			if ((UIntPtr)s7K2Ek.ObjectDetectorSearchMode == (UIntPtr)(nuint)0u)
			{
				uIntPtr = default(UIntPtr);
				uIntPtr = default(UIntPtr);
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					f3L6Rd = null;
					_ = (Wt9q7H)((s7K2Ek)f3L6Rd.PrintDailyRecords).ObjectDetectorSearchMode;
					x6LFp = x6LFp;
					x6LFp = x6LFp;
					_ = (f1P6Lz)(object)((Yg89Py)((Ag9)((a8C)null).PayTMPay).UserInfo).DBForFoodManagementConnectionString;
					ty5k0C = ty5k0C;
					ty5k0C = ty5k0C;
				}
				else
				{
					sy50Xx = sy50Xx;
					sy50Xx = sy50Xx;
				}
			}
			goto IL_00d1;
		}
		IL_00d1:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Xn05Ce xn05Ce);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f1P6Lz f1P6Lz);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sy0 sy);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Mr7n6D mr7n6D);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ag9 ag);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a8C a8C);
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out s9.y6 y);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Se60Di se60Di);
			while (((Xn05Ce)null).ObjectDetectorScalingMode != null)
			{
				try
				{
					y = y;
					y = y;
				}
				finally
				{
					se60Di = se60Di;
					se60Di = se60Di;
					_ = ((y0D)f3L6Rd.PrintDailyRecords).Width is s7K2Ek;
					xn05Ce = xn05Ce;
					f1P6Lz = (f1P6Lz)xn05Ce.UserInfo;
					f1P6Lz = null;
					continue;
				}
			}
		}
		catch
		{
			try
			{
				a8C = a8C;
				mr7n6D = (Mr7n6D)((Ag9)a8C.PayTMPay).UserInfo;
				mr7n6D = mr7n6D;
			}
			catch
			{
				try
				{
					ag = null;
					_ = (Ez0)((a8C)ag.UserInfo).PayTMPay;
					goto end_IL_0170;
				}
				catch
				{
					sy = null;
					_ = (Sy50Xx)((f3L6Rd)sy.SuppliedRecord).PrintDailyRecords;
					goto end_IL_0170;
				}
				end_IL_0170:;
			}
		}
		Hf08Tc hf08Tc;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out i1D i1D2);
		try
		{
			_ = ((y0D)null).Width is s7K2Ek;
		}
		catch
		{
			try
			{
				i1D2 = i1D2;
				i1D2 = i1D2;
			}
			catch
			{
				b4 b = b;
				b = b;
			}
		}
		finally
		{
			hf08Tc = null;
			hf08Tc = null;
			goto IL_01fc;
		}
		IL_04c1:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj6);
		do
		{
			if ((UIntPtr)((s7K2Ek)sy.UserInfo).ObjectDetectorSearchMode != (UIntPtr)(nuint)0u)
			{
				sy50Xx = sy50Xx;
			}
			else
			{
				_ = (s7K2Ek)i1D2.PrintMonthlyRecords;
			}
			obj6 = obj6;
		}
		while (obj6 != null);
		y0D y0D;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out z3T z3T);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Yg89Py yg89Py);
		do
		{
			_ = y0D.Width is i1D;
			z3T obj7 = (z3T)(object)yg89Py.DBForFoodManagementConnectionString;
			z3T = z3T;
			z3T = obj7;
			_ = (f3L6Rd)mr7n6D.ObjectDetectorSearchMode;
		}
		while (obj6 != null);
		if (uIntPtr == 0)
		{
			try
			{
				_ = (Ez0)ag.UserInfo;
				_ = (Ag9)((Mr7n6D)(object)Yg89Py.Default).ObjectDetectorSearchMode;
			}
			catch
			{
				a8C = a8C;
			}
		}
		else
		{
			while (obj6 != null)
			{
				_ = (Xn05Ce)ag.UserInfo;
			}
		}
		try
		{
			try
			{
				try
				{
					hf08Tc = hf08Tc;
				}
				finally
				{
					i7Z8Et i7Z8Et = null;
					i7Z8Et = i7Z8Et;
					goto end_IL_0569;
				}
				end_IL_0569:;
			}
			finally
			{
				try
				{
					_ = (Ag9)(object)((Yg89Py)null).DBForFoodManagementConnectionString;
				}
				catch
				{
					_ = (e2.y6)((f1P6Lz)null).SuppliedRecord;
				}
				goto end_IL_0568;
			}
			end_IL_0568:;
		}
		catch
		{
			while (true)
			{
				if (obj6 != null)
				{
					_ = (m8K)(object)yg89Py.Fast_food_managementConnectionString;
					mr7n6D = y0D.Width as Mr7n6D;
					_ = (Sy0)((f1P6Lz)null).SupplierDailyRecord;
				}
				else if (obj6 == null)
				{
					break;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out e2.y6 y2);
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				_ = ((y0D)null).Width is s4C8Py;
				ty5k0C = ty5k0C;
				a8C = a8C;
				mr7n6D = mr7n6D;
			}
			else
			{
				try
				{
					_ = (Hf08Tc)((s7K2Ek)null).ObjectDetectorScalingMode;
				}
				catch
				{
					y2 = y2;
				}
			}
		}
		finally
		{
			do
			{
				if ((UIntPtr)i1D2.PrintMonthlyRecords != (UIntPtr)(nuint)0u)
				{
					_ = (b4)((i1D)null).PrintMonthlyRecords;
				}
				else
				{
					_ = (y0D)((i1D)null).PrintMonthlyRecords;
				}
			}
			while (((y0D)((Xn05Ce)null).ObjectDetectorScalingMode).Width is object);
			goto IL_0682;
		}
		IL_01fc:
		_ = (Mt2)s7K2Ek.ObjectDetectorSearchMode;
		yg89Py = yg89Py;
		_ = (Mt2)(object)yg89Py.DBForFoodManagementConnectionString;
		try
		{
			try
			{
				_ = (Sy0)i1D2.PrintMonthlyRecords;
			}
			finally
			{
				Wt9q7H wt9q7H = (Wt9q7H)sy.SupplierDailyRecord;
				wt9q7H = wt9q7H;
				goto end_IL_0222;
			}
			end_IL_0222:;
		}
		catch
		{
			try
			{
				_ = (Mr7n6D)(object)yg89Py.Fast_food_managementConnectionString;
			}
			catch
			{
				yg89Py = yg89Py;
			}
		}
		_ = (_003CModule_003E)((Ag9)null).UserInfo;
		while (true)
		{
			y0D = null;
			if ((y0D.Width as Ag9).UserInfo == null)
			{
				break;
			}
			try
			{
				f1P6Lz = null;
			}
			finally
			{
				i1D2 = i1D2;
				continue;
			}
		}
		_ = (_003CModule_003E)f3L6Rd.PrintDailyRecords;
		try
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				_ = (Ag9)((i1D)null).PrintMonthlyRecords;
				b4 b = default(b4);
			}
		}
		catch
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				UIntPtr num = uIntPtr;
				nuint num2 = checked(unchecked((nuint)(UIntPtr)s7K2Ek.ObjectDetectorScalingMode) + unchecked((nuint)(UIntPtr)((i1D)((Mr7n6D)null).ObjectDetectorSearchMode).PrintMonthlyRecords)) / unchecked((nuint)default(UIntPtr));
				uIntPtr = default(UIntPtr);
				checked
				{
					if (unchecked((nuint)num) - num2 * (uIntPtr - unchecked((nuint)(UIntPtr)xn05Ce.UserInfo)) - uIntPtr == 0)
					{
						_ = (Mm0)ag.UserInfo;
					}
					else
					{
						ty5k0C = ty5k0C;
					}
				}
			}
		}
		try
		{
			_ = (Ez0)((i1D)null).PrintMonthlyRecords;
		}
		finally
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				try
				{
					ty5k0C = (Ty5k0C)a8C.PayTMPay;
				}
				finally
				{
					_ = (f3L6Rd)f3L6Rd.PrintDailyRecords;
					goto IL_03f0;
				}
			}
			try
			{
				y2 = default(e2.y6);
				y2 = y2;
				y2 = y2;
			}
			catch
			{
				_ = (z3T)((Sy0)i1D2.PrintMonthlyRecords).SupplierDailyRecord;
			}
			goto IL_03f0;
		}
		IL_03f0:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Rf7 rf);
		if ((UIntPtr)sy.SupplierInfo == (UIntPtr)(nuint)0u)
		{
			try
			{
				Se60Di se60Di = null;
				y0D = y0D;
				sy = sy;
			}
			finally
			{
				ty5k0C = null;
				Rf7 obj16 = (Rf7)((Mr7n6D)xn05Ce.UserInfo).ObjectDetectorScalingMode;
				rf = ((y0D)((f3L6Rd)ag.UserInfo).PrintDailyRecords).Width as Rf7;
				rf = obj16;
				goto IL_04c1;
			}
		}
		try
		{
			_ = (Xn05Ce)f1P6Lz.Send_sms_to_customer;
		}
		finally
		{
			m8K m8K = m8K;
			m8K = m8K;
			_ = (Mm0)((f1P6Lz)null).SupplierDailyRecord;
			sy50Xx = null;
			goto IL_04c1;
		}
		IL_0784:
		_ = (Se60Di)xn05Ce.ObjectDetectorScalingMode;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s4C8Py s4C8Py);
		while (obj6 != null)
		{
			ty5k0C = null;
			rf = rf;
			s4C8Py = s4C8Py;
			s4C8Py = s4C8Py;
			ty5k0C = ty5k0C;
		}
		x6LFp = (x6LFp1)(object)Yg89Py.Default;
		_ = ((y0D)null).Width is Mm0;
		x6LFp = y0D.Width as x6LFp1;
		i1D2 = y0D.Width as i1D;
		return;
		IL_0682:
		checked
		{
			if (uIntPtr * (uIntPtr * (unchecked((nuint)(UIntPtr)((Yg89Py)null).DBForFoodManagementConnectionString) * (unchecked((nuint)(UIntPtr)xn05Ce.ObjectDetectorScalingMode) * unchecked((nuint)(UIntPtr)((Xn05Ce)((Xn05Ce)null).ObjectDetectorScalingMode).ObjectDetectorScalingMode)) + uIntPtr)) == 0)
			{
				_ = (Ez0)((s7K2Ek)null).ObjectDetectorSearchMode;
			}
		}
		try
		{
			if ((UIntPtr)ag.UserInfo == (UIntPtr)(nuint)0u)
			{
				ag = ag;
				_ = (Se60Di)((Xn05Ce)(object)yg89Py.DBForFoodManagementConnectionString).ObjectDetectorScalingMode;
				a8C = a8C;
			}
		}
		catch
		{
			_ = (Mm0)i1D2.PrintMonthlyRecords;
		}
		try
		{
			while (obj6 != null)
			{
				if ((nuint)(UIntPtr)s7K2Ek.ObjectDetectorSearchMode / uIntPtr == 0)
				{
					i1D2 = i1D2;
					_ = (Mm0)f3L6Rd.PrintDailyRecords;
				}
			}
		}
		finally
		{
			while (obj6 != null)
			{
				try
				{
					_ = (Mr7n6D)((Xn05Ce)((Ag9)null).UserInfo).ObjectDetectorSearchMode;
				}
				catch
				{
					f1P6Lz = f1P6Lz;
				}
			}
			goto IL_0784;
		}
	}
}
