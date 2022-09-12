using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Windows.Forms;
using Ed9;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using g8GLd9;
using n2Z;
using s9;
using w0XGc7;

namespace Dp4o9T;

[DesignerGenerated]
public class Sy50Xx : Form
{
	private IContainer components;

	[AccessedThroughProperty("Panel2")]
	private Panel _Panel2;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("btnorder")]
	private object _btnorder;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("txtTotalPrice")]
	private object _txtTotalPrice;

	[AccessedThroughProperty("txtperunitprice")]
	private object _txtperunitprice;

	[AccessedThroughProperty("txtOrderNo")]
	private object _txtOrderNo;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("tmrerr")]
	private Timer _tmrerr;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	private y6.m2 m2_0 = new y6.m2();

	internal virtual Panel Panel2
	{
		get
		{
			return _Panel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Panel2 = value;
		}
	}

	internal virtual Panel Panel1
	{
		get
		{
			return _Panel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Panel1 = value;
		}
	}

	internal virtual object btnexit
	{
		get
		{
			return m2_0.object_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			m2_0.object_0 = objectValue;
		}
	}

	internal virtual object btnorder
	{
		get
		{
			return _btnorder;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_btnorder = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual Label lblmess
	{
		get
		{
			return m2_0.label_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			m2_0.label_0 = ((value is Label) ? value : null);
		}
	}

	internal virtual Label Label3
	{
		get
		{
			return m2_0.label_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			m2_0.label_1 = ((value is Label) ? value : null);
		}
	}

	internal virtual Label Label1
	{
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label1 = value;
		}
	}

	internal virtual object txtTotalPrice
	{
		get
		{
			return _txtTotalPrice;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtTotalPrice = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual object txtperunitprice
	{
		get
		{
			return _txtperunitprice;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtperunitprice = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual object txtquantity
	{
		get
		{
			return m2_0.object_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			m2_0.object_1 = objectValue;
		}
	}

	internal virtual object drpSupplierList
	{
		get
		{
			return m2_0.object_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			m2_0.object_2 = objectValue;
		}
	}

	internal virtual object txtOrderNo
	{
		get
		{
			return _txtOrderNo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtOrderNo = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual Label Label11
	{
		get
		{
			return m2_0.label_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected O, but got Unknown
			m2_0.label_2 = value;
		}
	}

	internal virtual Label Label7
	{
		get
		{
			return m2_0.label_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			m2_0.label_3 = ((value is Label) ? value : null);
		}
	}

	internal virtual Label Label6
	{
		get
		{
			return _Label6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label6 = value;
		}
	}

	internal virtual Label Label5
	{
		get
		{
			return m2_0.label_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			m2_0.label_4 = ((value is Label) ? value : null);
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

	internal virtual Timer tmrerr
	{
		get
		{
			return _tmrerr;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			MulticastDelegate multicastDelegate = new EventHandler(y5T0Wp);
			object obj = _tmrerr;
			if ((int)(Timer)obj != 0)
			{
				((Timer)((obj is Timer) ? obj : null)).remove_Tick((EventHandler)multicastDelegate);
			}
			_tmrerr = value;
			obj = _tmrerr;
			if ((int)(Timer)obj != 0)
			{
				((Timer)((obj is Timer) ? obj : null)).add_Tick((EventHandler)multicastDelegate);
			}
		}
	}

	internal virtual object datepkrOrderDate
	{
		get
		{
			return m2_0.object_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			m2_0.object_3 = objectValue;
		}
	}

	internal virtual Label Label4
	{
		get
		{
			return m2_0.label_5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			m2_0.label_5 = ((value is Label) ? value : null);
		}
	}

	internal virtual object txtProductName
	{
		get
		{
			return m2_0.object_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			m2_0.object_4 = objectValue;
		}
	}

	internal virtual Timer Timer1
	{
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			object obj = new EventHandler(m1XLe9);
			Component timer = (Component)(object)_Timer1;
			if ((int)(Timer)timer != 0)
			{
				((Timer)timer).remove_Tick(obj as EventHandler);
			}
			_Timer1 = value;
			timer = (Component)(object)_Timer1;
			if ((int)(Timer)timer != 0)
			{
				((Timer)((timer is Timer) ? timer : null)).add_Tick((EventHandler)obj);
			}
		}
	}

	public Sy50Xx()
	{
		((Form)this).add_Load((EventHandler)a7TZe3);
		Ho3s2F();
	}

	protected override void j4FLp8(bool Xq04Jm)
	{
		try
		{
			if (Xq04Jm && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Xq04Jm);
		}
	}

	private void Ho3s2F()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected O, but got Unknown
		//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_067b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0681: Expected O, but got Unknown
		//IL_07dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e2: Expected O, but got Unknown
		//IL_0b1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b24: Expected O, but got Unknown
		//IL_0b49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b53: Expected O, but got Unknown
		//IL_0bda: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be4: Expected O, but got Unknown
		//IL_0c5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c65: Expected O, but got Unknown
		//IL_0da0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da6: Expected O, but got Unknown
		//IL_0e48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fdd: Expected O, but got Unknown
		//IL_107f: Unknown result type (might be due to invalid IL or missing references)
		//IL_120e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1214: Expected O, but got Unknown
		//IL_12b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_15d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_15db: Expected O, but got Unknown
		//IL_167d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1748: Unknown result type (might be due to invalid IL or missing references)
		//IL_1752: Expected O, but got Unknown
		//IL_17c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_17d3: Expected O, but got Unknown
		//IL_184a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1854: Expected O, but got Unknown
		//IL_18cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_18d5: Expected O, but got Unknown
		//IL_1952: Unknown result type (might be due to invalid IL or missing references)
		//IL_195c: Expected O, but got Unknown
		//IL_1bba: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bc4: Expected O, but got Unknown
		//IL_1d23: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d29: Expected O, but got Unknown
		//IL_1dcb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ed2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1edc: Expected O, but got Unknown
		//IL_1ee8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ef2: Expected O, but got Unknown
		//IL_1f31: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f3b: Expected O, but got Unknown
		//IL_1f47: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f51: Expected O, but got Unknown
		//IL_1f5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f67: Expected O, but got Unknown
		//IL_1f73: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f7d: Expected O, but got Unknown
		//IL_1f89: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f93: Expected O, but got Unknown
		//IL_1fb0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fba: Expected O, but got Unknown
		components = new Container();
		object obj = new ComponentResourceManager(typeof(Sy50Xx));
		Panel2 = new Panel();
		Panel1 = new Panel();
		lblmess = new Label();
		Label3 = new Label();
		Label1 = new Label();
		Label11 = new Label();
		Label7 = new Label();
		Label6 = new Label();
		Label5 = new Label();
		Label2 = new Label();
		tmrerr = new Timer(components);
		Label4 = new Label();
		Timer1 = new Timer(components);
		((Control)Panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)Panel2).set_BackColor(Color.FromArgb(174, 8, 40));
		((Control)Panel2).set_Dock((DockStyle)1);
		((Control)Panel2).set_Location(new Point(200, 0));
		((Control)Panel2).set_Name("Panel2");
		((Control)Panel2).set_Size(new Size(865, 25));
		((Control)Panel2).set_TabIndex(31);
		((Control)Panel1).set_BackColor(Color.Black);
		((Control)Panel1).get_Controls().Add((Control)btnexit);
		((Control)Panel1).set_Dock((DockStyle)3);
		((Control)Panel1).set_ForeColor(Color.Chocolate);
		((Control)Panel1).set_Location(new Point(0, 0));
		((Control)Panel1).set_Name("Panel1");
		((Control)Panel1).set_Size(new Size(200, 587));
		((Control)Panel1).set_TabIndex(30);
		NewLateBinding.LateSetComplex(btnexit, (Type)null, "Activecolor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnexit, (Type)null, "BackColor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnexit, (Type)null, "BackgroundImageLayout", new object[1] { (object)(ImageLayout)3 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnexit, (Type)null, "BorderRadius", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnexit, (Type)null, "ButtonText", new object[1] { "Close" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnexit, (Type)null, "Cursor", new object[1] { Cursors.get_Hand() }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnexit, (Type)null, "DisabledColor", new object[1] { Color.Gray }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnexit, (Type)null, "Iconcolor", new object[1] { Color.Transparent }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnexit, (Type)null, "Iconimage", new object[1] { (object)(Image)((ComponentResourceManager)obj).GetObject("btnexit.Iconimage") }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnexit, (Type)null, "Iconimage_right", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnexit, (Type)null, "Iconimage_right_Selected", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnexit, (Type)null, "Iconimage_Selected", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnexit, (Type)null, "IconMarginLeft", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnexit, (Type)null, "IconMarginRight", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnexit, (Type)null, "IconRightVisible", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnexit, (Type)null, "IconRightZoom", new object[1] { 0.0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnexit, (Type)null, "IconVisible", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnexit, (Type)null, "IconZoom", new object[1] { 90.0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnexit, (Type)null, "IsTab", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnexit, (Type)null, "Location", new object[1]
		{
			new Point(4, 232)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnexit, (Type)null, "Margin", new object[1] { (object)new Padding(4) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnexit, (Type)null, "Name", new object[1] { "btnexit" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnexit, (Type)null, "Normalcolor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnexit, (Type)null, "OnHovercolor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnexit, (Type)null, "OnHoverTextColor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnexit, (Type)null, "selected", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnexit, (Type)null, "Size", new object[1]
		{
			new Size(196, 48)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnexit, (Type)null, "TabIndex", new object[1] { 9 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnexit, (Type)null, "Text", new object[1] { "Close" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnexit, (Type)null, "TextAlign", new object[1] { (object)(ContentAlignment)16 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnexit, (Type)null, "Textcolor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnexit, (Type)null, "TextFont", new object[1] { (object)new Font("Century Gothic", 15.75f) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnorder, (Type)null, "Activecolor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnorder, (Type)null, "BackColor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnorder, (Type)null, "BackgroundImageLayout", new object[1] { (object)(ImageLayout)3 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnorder, (Type)null, "BorderRadius", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnorder, (Type)null, "ButtonText", new object[1] { "Buy Supply" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnorder, (Type)null, "Cursor", new object[1] { Cursors.get_Hand() }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnorder, (Type)null, "DisabledColor", new object[1] { Color.Gray }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnorder, (Type)null, "Iconcolor", new object[1] { Color.Transparent }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnorder, (Type)null, "Iconimage", new object[1] { (object)(Image)((ComponentResourceManager)obj).GetObject("btnorder.Iconimage") }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnorder, (Type)null, "Iconimage_right", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnorder, (Type)null, "Iconimage_right_Selected", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnorder, (Type)null, "Iconimage_Selected", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnorder, (Type)null, "IconMarginLeft", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnorder, (Type)null, "IconMarginRight", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnorder, (Type)null, "IconRightVisible", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnorder, (Type)null, "IconRightZoom", new object[1] { 0.0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnorder, (Type)null, "IconVisible", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnorder, (Type)null, "IconZoom", new object[1] { 90.0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnorder, (Type)null, "IsTab", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnorder, (Type)null, "Location", new object[1]
		{
			new Point(571, 467)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnorder, (Type)null, "Name", new object[1] { "btnorder" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnorder, (Type)null, "Normalcolor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnorder, (Type)null, "OnHovercolor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnorder, (Type)null, "OnHoverTextColor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnorder, (Type)null, "selected", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnorder, (Type)null, "Size", new object[1]
		{
			new Size(172, 41)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnorder, (Type)null, "TabIndex", new object[1] { 58 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnorder, (Type)null, "Text", new object[1] { "Buy Supply" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnorder, (Type)null, "TextAlign", new object[1] { (object)(ContentAlignment)16 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnorder, (Type)null, "Textcolor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnorder, (Type)null, "TextFont", new object[1] { (object)new Font("Century Gothic", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0) }, (string[])null, (Type[])null, false, true);
		lblmess.set_AutoSize(true);
		((Control)lblmess).set_Font(new Font("Century Gothic", 12f));
		((Control)lblmess).set_ForeColor(Color.Red);
		((Control)lblmess).set_Location(new Point(775, 344));
		((Control)lblmess).set_Name("lblmess");
		((Control)lblmess).set_Size(new Size(113, 21));
		((Control)lblmess).set_TabIndex(68);
		lblmess.set_Text("ErrorMessage");
		Label3.set_AutoSize(true);
		((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 12f));
		((Control)Label3).set_Location(new Point(542, 390));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(33, 20));
		((Control)Label3).set_TabIndex(66);
		Label3.set_Text("Rs.");
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Microsoft Sans Serif", 12f));
		((Control)Label1).set_Location(new Point(542, 314));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(33, 20));
		((Control)Label1).set_TabIndex(67);
		Label1.set_Text("Rs.");
		NewLateBinding.LateSetComplex(txtTotalPrice, (Type)null, "BorderColorFocused", new object[1] { Color.Red }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtTotalPrice, (Type)null, "BorderColorIdle", new object[1] { Color.SeaGreen }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtTotalPrice, (Type)null, "BorderColorMouseHover", new object[1] { Color.Blue }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtTotalPrice, (Type)null, "BorderThickness", new object[1] { 1 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtTotalPrice, (Type)null, "Cursor", new object[1] { Cursors.get_IBeam() }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtTotalPrice, (Type)null, "Font", new object[1] { (object)new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtTotalPrice, (Type)null, "ForeColor", new object[1] { Color.FromArgb(64, 64, 64) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtTotalPrice, (Type)null, "isPassword", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtTotalPrice, (Type)null, "Location", new object[1]
		{
			new Point(582, 380)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtTotalPrice, (Type)null, "Margin", new object[1] { (object)new Padding(4) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtTotalPrice, (Type)null, "Name", new object[1] { "txtTotalPrice" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtTotalPrice, (Type)null, "Size", new object[1]
		{
			new Size(219, 30)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtTotalPrice, (Type)null, "TabIndex", new object[1] { 57 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtTotalPrice, (Type)null, "TextAlign", new object[1] { (object)(HorizontalAlignment)2 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtperunitprice, (Type)null, "BorderColorFocused", new object[1] { Color.Red }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtperunitprice, (Type)null, "BorderColorIdle", new object[1] { Color.SeaGreen }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtperunitprice, (Type)null, "BorderColorMouseHover", new object[1] { Color.Blue }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtperunitprice, (Type)null, "BorderThickness", new object[1] { 1 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtperunitprice, (Type)null, "Cursor", new object[1] { Cursors.get_IBeam() }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtperunitprice, (Type)null, "Font", new object[1] { (object)new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtperunitprice, (Type)null, "ForeColor", new object[1] { Color.FromArgb(64, 64, 64) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtperunitprice, (Type)null, "isPassword", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtperunitprice, (Type)null, "Location", new object[1]
		{
			new Point(582, 304)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtperunitprice, (Type)null, "Margin", new object[1] { (object)new Padding(4) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtperunitprice, (Type)null, "Name", new object[1] { "txtperunitprice" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtperunitprice, (Type)null, "Size", new object[1]
		{
			new Size(186, 30)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtperunitprice, (Type)null, "TabIndex", new object[1] { 59 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtperunitprice, (Type)null, "TextAlign", new object[1] { (object)(HorizontalAlignment)2 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtquantity, (Type)null, "BorderColorFocused", new object[1] { Color.Red }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtquantity, (Type)null, "BorderColorIdle", new object[1] { Color.SeaGreen }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtquantity, (Type)null, "BorderColorMouseHover", new object[1] { Color.Blue }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtquantity, (Type)null, "BorderThickness", new object[1] { 1 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtquantity, (Type)null, "Cursor", new object[1] { Cursors.get_IBeam() }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtquantity, (Type)null, "Font", new object[1] { (object)new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtquantity, (Type)null, "ForeColor", new object[1] { Color.FromArgb(64, 64, 64) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtquantity, (Type)null, "isPassword", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtquantity, (Type)null, "Location", new object[1]
		{
			new Point(582, 342)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtquantity, (Type)null, "Margin", new object[1] { (object)new Padding(4) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtquantity, (Type)null, "Name", new object[1] { "txtquantity" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtquantity, (Type)null, "Size", new object[1]
		{
			new Size(186, 30)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtquantity, (Type)null, "TabIndex", new object[1] { 1 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtquantity, (Type)null, "TextAlign", new object[1] { (object)(HorizontalAlignment)2 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(drpSupplierList, (Type)null, "BackColor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(drpSupplierList, (Type)null, "BorderRadius", new object[1] { 3 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(drpSupplierList, (Type)null, "ForeColor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(drpSupplierList, (Type)null, "Location", new object[1]
		{
			new Point(582, 224)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(drpSupplierList, (Type)null, "Name", new object[1] { "drpSupplierList" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(drpSupplierList, (Type)null, "NomalColor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(drpSupplierList, (Type)null, "onHoverColor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(drpSupplierList, (Type)null, "selectedIndex", new object[1] { -1 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(drpSupplierList, (Type)null, "Size", new object[1]
		{
			new Size(217, 35)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(drpSupplierList, (Type)null, "TabIndex", new object[1] { 70 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtOrderNo, (Type)null, "BorderColorFocused", new object[1] { Color.Red }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtOrderNo, (Type)null, "BorderColorIdle", new object[1] { Color.SeaGreen }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtOrderNo, (Type)null, "BorderColorMouseHover", new object[1] { Color.Blue }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtOrderNo, (Type)null, "BorderThickness", new object[1] { 1 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtOrderNo, (Type)null, "Cursor", new object[1] { Cursors.get_IBeam() }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtOrderNo, (Type)null, "Font", new object[1] { (object)new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtOrderNo, (Type)null, "ForeColor", new object[1] { Color.FromArgb(64, 64, 64) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtOrderNo, (Type)null, "isPassword", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtOrderNo, (Type)null, "Location", new object[1]
		{
			new Point(582, 183)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtOrderNo, (Type)null, "Margin", new object[1] { (object)new Padding(4) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtOrderNo, (Type)null, "Name", new object[1] { "txtOrderNo" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtOrderNo, (Type)null, "Size", new object[1]
		{
			new Size(420, 30)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtOrderNo, (Type)null, "TabIndex", new object[1] { 53 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtOrderNo, (Type)null, "TextAlign", new object[1] { (object)(HorizontalAlignment)2 }, (string[])null, (Type[])null, false, true);
		Label11.set_AutoSize(true);
		((Control)Label11).set_Font(new Font("Century Gothic", 12f));
		((Control)Label11).set_Location(new Point(342, 314));
		((Control)Label11).set_Name("Label11");
		((Control)Label11).set_Size(new Size(38, 21));
		((Control)Label11).set_TabIndex(65);
		Label11.set_Text("PER");
		Label7.set_AutoSize(true);
		((Control)Label7).set_Font(new Font("Century Gothic", 12f));
		((Control)Label7).set_Location(new Point(341, 352));
		((Control)Label7).set_Name("Label7");
		((Control)Label7).set_Size(new Size(92, 21));
		((Control)Label7).set_TabIndex(63);
		Label7.set_Text("QUANTITY");
		Label6.set_AutoSize(true);
		((Control)Label6).set_Font(new Font("Century Gothic", 12f));
		((Control)Label6).set_Location(new Point(341, 390));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(110, 21));
		((Control)Label6).set_TabIndex(62);
		Label6.set_Text("TOTAL PRICE");
		Label5.set_AutoSize(true);
		((Control)Label5).set_Font(new Font("Century Gothic", 12f));
		((Control)Label5).set_Location(new Point(341, 238));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(131, 21));
		((Control)Label5).set_TabIndex(61);
		Label5.set_Text("SUPPLIER NAME");
		Label2.set_AutoSize(true);
		((Control)Label2).set_Font(new Font("Century Gothic", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_Location(new Point(342, 193));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(95, 21));
		((Control)Label2).set_TabIndex(60);
		Label2.set_Text("SUPPLY NO");
		tmrerr.set_Interval(2000);
		NewLateBinding.LateSetComplex(datepkrOrderDate, (Type)null, "BackColor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(datepkrOrderDate, (Type)null, "BorderRadius", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(datepkrOrderDate, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(datepkrOrderDate, (Type)null, "ForeColor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(datepkrOrderDate, (Type)null, "Format", new object[1] { (object)(DateTimePickerFormat)1 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(datepkrOrderDate, (Type)null, "FormatCustom", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(datepkrOrderDate, (Type)null, "Location", new object[1]
		{
			new Point(206, 31)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(datepkrOrderDate, (Type)null, "Name", new object[1] { "datepkrOrderDate" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(datepkrOrderDate, (Type)null, "Size", new object[1]
		{
			new Size(306, 53)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(datepkrOrderDate, (Type)null, "TabIndex", new object[1] { 69 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(datepkrOrderDate, (Type)null, "Value", new object[1]
		{
			new DateTime(2018, 1, 3, 15, 59, 45, 0)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(datepkrOrderDate, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null, false, true);
		Label4.set_AutoSize(true);
		((Control)Label4).set_Font(new Font("Century Gothic", 12f));
		((Control)Label4).set_Location(new Point(342, 276));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(124, 21));
		((Control)Label4).set_TabIndex(65);
		Label4.set_Text("Product Name");
		NewLateBinding.LateSetComplex(txtProductName, (Type)null, "BorderColorFocused", new object[1] { Color.Red }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtProductName, (Type)null, "BorderColorIdle", new object[1] { Color.SeaGreen }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtProductName, (Type)null, "BorderColorMouseHover", new object[1] { Color.Blue }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtProductName, (Type)null, "BorderThickness", new object[1] { 1 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtProductName, (Type)null, "Cursor", new object[1] { Cursors.get_IBeam() }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtProductName, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtProductName, (Type)null, "Font", new object[1] { (object)new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtProductName, (Type)null, "ForeColor", new object[1] { Color.FromArgb(64, 64, 64) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtProductName, (Type)null, "isPassword", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtProductName, (Type)null, "Location", new object[1]
		{
			new Point(582, 266)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtProductName, (Type)null, "Margin", new object[1] { (object)new Padding(4) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtProductName, (Type)null, "Name", new object[1] { "txtProductName" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtProductName, (Type)null, "Size", new object[1]
		{
			new Size(186, 30)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtProductName, (Type)null, "TabIndex", new object[1] { 59 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtProductName, (Type)null, "TextAlign", new object[1] { (object)(HorizontalAlignment)2 }, (string[])null, (Type[])null, false, true);
		Timer1.set_Interval(1000);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.White);
		((Form)this).set_ClientSize(new Size(1065, 587));
		((Control)this).get_Controls().Add((Control)datepkrOrderDate);
		((Control)this).get_Controls().Add((Control)btnorder);
		((Control)this).get_Controls().Add((Control)(object)lblmess);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)txtTotalPrice);
		((Control)this).get_Controls().Add((Control)txtProductName);
		((Control)this).get_Controls().Add((Control)txtperunitprice);
		((Control)this).get_Controls().Add((Control)txtquantity);
		((Control)this).get_Controls().Add((Control)drpSupplierList);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)txtOrderNo);
		((Control)this).get_Controls().Add((Control)(object)Label11);
		((Control)this).get_Controls().Add((Control)(object)Label7);
		((Control)this).get_Controls().Add((Control)(object)Label6);
		((Control)this).get_Controls().Add((Control)(object)Label5);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Panel2);
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("BuySupply");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("BuySupply");
		((Control)Panel1).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void a7TZe3(object sender, EventArgs e)
	{
		NewLateBinding.LateSetComplex(txtTotalPrice, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtperunitprice, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtOrderNo, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null, false, true);
		((Control)lblmess).Hide();
		try
		{
			NewLateBinding.LateSetComplex(datepkrOrderDate, (Type)null, "Value", new object[1] { ((ServerComputer)Wt9q7H.Computer).get_Clock().get_LocalTime() }, (string[])null, (Type[])null, false, true);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		Rf7.Zj9();
		Rf7.cnn.Open();
		ISerializable serializable = new DataTable();
		Rf7.cmd.set_Connection(Rf7.cnn);
		Rf7.cmd.set_CommandText("select name,productname from supplierdata");
		Rf7.da.set_SelectCommand(Rf7.cmd);
		try
		{
			((DbDataAdapter)(object)Rf7.da).Fill((DataTable)serializable);
			object enumerator = default(object);
			try
			{
				enumerator = ((DataTable)serializable).Rows.GetEnumerator();
				while ((enumerator as IEnumerator).MoveNext())
				{
					object obj = (DataRow)((IEnumerator)enumerator).Current;
					object obj3;
					object obj2;
					object obj4;
					NewLateBinding.LateCall(drpSupplierList, (Type)null, "AddItem", (object[])(obj3 = new object[1] { ((DataRow)(obj2 = obj as DataRow))["name"] }), (string[])null, (Type[])null, (bool[])(obj4 = new bool[1] { true }), true);
					if ((obj4 as bool[])[0])
					{
						(obj2 as DataRow)["name"] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(((object[])obj3)[0]));
					}
				}
			}
			finally
			{
				if (((IEnumerator)enumerator) is IDisposable)
				{
					((enumerator as IEnumerator) as IDisposable).Dispose();
				}
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		Rf7.cnn.Close();
		Rf7.Zj9();
		Rf7.cnn.Open();
		Rf7.cmd.set_Connection(Rf7.cnn);
		Rf7.cmd.set_CommandText("select * from itemsupplied");
		Rf7.da.set_SelectCommand(Rf7.cmd);
		try
		{
			((DbDataAdapter)(object)Rf7.da).Fill((DataTable)serializable);
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		int index = checked((serializable as DataTable).Rows.Count - 1);
		try
		{
			NewLateBinding.LateSetComplex(txtOrderNo, (Type)null, "Text", new object[1] { (serializable as DataTable).Rows[index]["orderno"].ToString() }, (string[])null, (Type[])null, false, true);
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			NewLateBinding.LateSetComplex(txtOrderNo, (Type)null, "Text", new object[1] { 1 }, (string[])null, (Type[])null, false, true);
			ProjectData.ClearProjectError();
		}
		Rf7.cnn.Close();
		try
		{
			NewLateBinding.LateSetComplex(drpSupplierList, (Type)null, "selectedIndex", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
	}

	private void g1HLk3(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(txtquantity, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			try
			{
				lblmess.set_Text(Conversions.ToString(Operators.ConcatenateObject((object)"Enter quantity of ", NewLateBinding.LateGet(txtProductName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null))));
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			tmrerr.Start();
			((Control)lblmess).Show();
			NewLateBinding.LateCall(txtquantity, (Type)null, "Focus", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			return;
		}
		try
		{
			Rf7.p7N();
			object rs = Rf7.rs;
			object[] obj = new object[2]
			{
				Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"INSERT INTO itemsupplied values('", NewLateBinding.LateGet(txtProductName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), (object)NewLateBinding.LateGet(drpSupplierList, (Type)null, "selectedValue", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (object)"','"), (object)Conversions.ToInteger(NewLateBinding.LateGet(txtquantity, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null))), (object)"','"), NewLateBinding.LateGet(txtperunitprice, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), (object)Conversions.ToInteger(NewLateBinding.LateGet(txtTotalPrice, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null))), (object)"','"), NewLateBinding.LateGet(datepkrOrderDate, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(NewLateBinding.LateGet(datepkrOrderDate, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ToShortDateString", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(NewLateBinding.LateGet(datepkrOrderDate, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ToShortTimeString", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), (object)Conversions.ToInteger(NewLateBinding.LateGet(txtOrderNo, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null))), (object)"')"),
				Rf7.cn
			};
			Array array = obj;
			bool[] obj2 = new bool[2] { false, true };
			Array array2 = obj2;
			NewLateBinding.LateCall(rs, (Type)null, "Open", obj, (string[])null, (Type[])null, obj2, true);
			if ((array2 as bool[])[1])
			{
				Rf7.cn = RuntimeHelpers.GetObjectValue((array as object[])[1]);
			}
			NewLateBinding.LateSetComplex(txtOrderNo, (Type)null, "Text", new object[1] { checked(Conversions.ToInteger(NewLateBinding.LateGet(txtOrderNo, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)) + 1) }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(txtquantity, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null, false, true);
			tmrerr.Start();
			lblmess.set_Text("Successful");
			((Control)lblmess).Show();
			NewLateBinding.LateCall(Rf7.cn, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			lblmess.set_Text("Fail to order");
			tmrerr.Start();
			((Control)lblmess).Show();
			ProjectData.ClearProjectError();
		}
	}

	private void y5T0Wp(object sender, EventArgs e)
	{
		((Control)lblmess).Hide();
	}

	private void Nr92Ta(object sender, EventArgs e)
	{
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		Rf7.Zj9();
		Rf7.cnn.Open();
		Rf7.cmd.set_Connection(Rf7.cnn);
		Rf7.cmd.set_CommandText(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"select productname,price from supplierdata where name='", NewLateBinding.LateGet(drpSupplierList, (Type)null, "selectedValue", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"'")));
		Rf7.da.set_SelectCommand(Rf7.cmd);
		ISupportInitialize supportInitialize = new DataTable();
		try
		{
			((DbDataAdapter)(object)Rf7.da).Fill((DataTable)supportInitialize);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			MessageBox.Show("No such Supplier found");
			ProjectData.ClearProjectError();
		}
		NewLateBinding.LateSetComplex(txtperunitprice, (Type)null, "Text", new object[1] { (supportInitialize as DataTable).Rows[0]["price"] }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtProductName, (Type)null, "Text", new object[1] { ((DataTable)supportInitialize).Rows[0]["productname"] }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtquantity, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateCall(txtquantity, (Type)null, "Focus", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		Rf7.cnn.Close();
	}

	private void g9AXm6(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(txtquantity, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			NewLateBinding.LateSetComplex(txtTotalPrice, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null, false, true);
		}
		else if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(txtperunitprice, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
		{
			try
			{
				int num = checked(Conversions.ToInteger(NewLateBinding.LateGet(txtperunitprice, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)) * Conversions.ToInteger(NewLateBinding.LateGet(txtquantity, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
				NewLateBinding.LateSetComplex(txtTotalPrice, (Type)null, "Text", new object[1] { num }, (string[])null, (Type[])null, false, true);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Fc6k4Z(object sender, KeyPressEventArgs e)
	{
		if (Strings.Asc(e.get_KeyChar()) != 8 && ((Strings.Asc(e.get_KeyChar()) < 48) | (Strings.Asc(e.get_KeyChar()) > 57)))
		{
			e.set_Handled(true);
		}
	}

	private void m1XLe9(object sender, EventArgs e)
	{
		NewLateBinding.LateSetComplex(datepkrOrderDate, (Type)null, "Value", new object[1] { ((ServerComputer)Wt9q7H.Computer).get_Clock().get_LocalTime() }, (string[])null, (Type[])null, false, true);
	}

	private void Ke8n7H(object sender, EventArgs e)
	{
		((Control)this).Hide();
		((Control)Wt9q7H.Forms.Dashboard).Show();
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

	internal static void Jt2p9R(Ez0.n4D k7X5Cg, int Dj2z0Y)
	{
		Array array = new byte[16];
		int num = 0;
		checked
		{
			while (num < 16)
			{
				if (num == 0)
				{
					((byte[])array)[num] = (byte)num;
					(array as byte[])[num + 1] = (byte)Math.Abs(Dj2z0Y);
				}
				else if (num > 1)
				{
					(array as byte[])[num] = (byte)Math.Abs(Dj2z0Y + 56);
				}
				int num2 = num + 1;
				if (num < num2)
				{
					num = num2;
				}
			}
			k7X5Cg.Salt = (byte[])array;
			Mr7n6D.t2A1Wm(k7X5Cg, k7X5Cg.Salt, 255);
		}
	}
}
