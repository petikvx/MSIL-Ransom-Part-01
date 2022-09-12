using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Ed9;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Rn1;
using g8GLd9;
using n2Z;

namespace Bo6;

[DesignerGenerated]
public class a8C : Form
{
	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("txtTotalPrice")]
	private object _txtTotalPrice;

	[AccessedThroughProperty("txtperunitprice")]
	private object _txtperunitprice;

	[AccessedThroughProperty("txtquantity")]
	private object _txtquantity;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("picUser")]
	private PictureBox _picUser;

	[AccessedThroughProperty("btnAddProduct")]
	private object _btnAddProduct;

	[AccessedThroughProperty("lblmess")]
	private Label _lblmess;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("RadCalculatorDropDown1")]
	private object _RadCalculatorDropDown1;

	[AccessedThroughProperty("Panel2")]
	private Panel _Panel2;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _GroupBox1;

	[AccessedThroughProperty("rdPaytm")]
	private object _rdPaytm;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	public string nm;

	private i1D.a8J a8J_0 = new i1D.a8J();

	internal virtual object btnclose
	{
		get
		{
			return a8J_0.object_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			a8J_0.object_0 = objectValue;
		}
	}

	internal virtual object datepkrOrderDate
	{
		get
		{
			return a8J_0.object_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			a8J_0.object_1 = objectValue;
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
			return _txtquantity;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtquantity = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual object drpdwnProductList
	{
		get
		{
			return a8J_0.object_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			a8J_0.object_2 = objectValue;
		}
	}

	internal virtual object txtOrderNo
	{
		get
		{
			return a8J_0.object_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			a8J_0.object_3 = objectValue;
		}
	}

	internal virtual Label Label11
	{
		get
		{
			return _Label11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label11 = value;
		}
	}

	internal virtual Label Label8
	{
		get
		{
			return _Label8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label8 = value;
		}
	}

	internal virtual Label Label7
	{
		get
		{
			return _Label7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label7 = value;
		}
	}

	internal virtual Label Label6
	{
		get
		{
			return a8J_0.label_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected O, but got Unknown
			a8J_0.label_0 = value;
		}
	}

	internal virtual Label Label5
	{
		get
		{
			return _Label5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label5 = value;
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

	internal virtual PictureBox picUser
	{
		get
		{
			return _picUser;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			object obj = new EventHandler(x5R);
			Control val = (Control)(object)_picUser;
			if (val is PictureBox)
			{
				((val is PictureBox) ? val : null).remove_Click((EventHandler)obj);
			}
			_picUser = value;
			val = (Control)(object)_picUser;
			if ((int)(PictureBox)val != 0)
			{
				((val is PictureBox) ? val : null).add_Click((EventHandler)obj);
			}
		}
	}

	internal virtual object btnAddProduct
	{
		get
		{
			return _btnAddProduct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_btnAddProduct = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual object btnorder
	{
		get
		{
			return a8J_0.object_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			a8J_0.object_4 = objectValue;
		}
	}

	internal virtual Label Label3
	{
		get
		{
			return a8J_0.label_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			a8J_0.label_1 = ((value is Label) ? value : null);
		}
	}

	internal virtual Label lblmess
	{
		get
		{
			return _lblmess;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblmess = value;
		}
	}

	internal virtual Timer tmrerr
	{
		get
		{
			return a8J_0.timer_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			object obj = new EventHandler(k7Y);
			Component timer_ = (Component)(object)a8J_0.timer_0;
			if ((int)(Timer)timer_ != 0)
			{
				((Timer)timer_).remove_Tick((EventHandler)obj);
			}
			a8J_0.timer_0 = ((value is Timer) ? value : null);
			timer_ = (Component)(object)a8J_0.timer_0;
			if (timer_ is Timer)
			{
				((Timer)((timer_ is Timer) ? timer_ : null)).add_Tick((EventHandler)obj);
			}
		}
	}

	internal virtual Timer Timer1
	{
		get
		{
			return a8J_0.timer_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			object obj = new EventHandler(y4N);
			object timer_ = a8J_0.timer_1;
			if ((int)(Timer)timer_ != 0)
			{
				((Timer)((timer_ is Timer) ? timer_ : null)).remove_Tick(obj as EventHandler);
			}
			a8J_0.timer_1 = ((value is Timer) ? value : null);
			timer_ = a8J_0.timer_1;
			if (timer_ is Timer)
			{
				((Timer)timer_).add_Tick((EventHandler)obj);
			}
		}
	}

	internal virtual Label lblUserName
	{
		get
		{
			return a8J_0.label_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			a8J_0.label_2 = ((value is Label) ? value : null);
		}
	}

	internal virtual Label Label9
	{
		get
		{
			return _Label9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label9 = value;
		}
	}

	internal virtual object RadCalculatorDropDown1
	{
		get
		{
			return _RadCalculatorDropDown1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_RadCalculatorDropDown1 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual object TelerikMetroTheme1
	{
		get
		{
			return a8J_0.object_5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			a8J_0.object_5 = objectValue;
		}
	}

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
			return a8J_0.panel_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			a8J_0.panel_0 = ((value is Panel) ? value : null);
		}
	}

	internal virtual Label Label4
	{
		get
		{
			return _Label4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label4 = value;
		}
	}

	internal virtual GroupBox GroupBox1
	{
		get
		{
			return _GroupBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_GroupBox1 = value;
		}
	}

	internal virtual object rdPaytm
	{
		get
		{
			return _rdPaytm;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_rdPaytm = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual object rdCash
	{
		get
		{
			return a8J_0.object_6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			a8J_0.object_6 = objectValue;
		}
	}

	internal virtual Label Label10
	{
		get
		{
			return _Label10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label10 = value;
		}
	}

	public object PayTMPay
	{
		get
		{
			return a8J_0.object_7;
		}
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			a8J_0.object_7 = objectValue;
		}
	}

	public a8C()
	{
		((Form)this).add_Load((EventHandler)d6F);
		p4J();
	}

	protected override void Ki3(bool Gz3)
	{
		try
		{
			if (Gz3 && a8J_0.icontainer_0 != null)
			{
				a8J_0.icontainer_0.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Gz3);
		}
	}

	private void p4J()
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Expected O, but got Unknown
		//IL_0457: Unknown result type (might be due to invalid IL or missing references)
		//IL_045d: Expected O, but got Unknown
		//IL_04ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_068d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0693: Expected O, but got Unknown
		//IL_0735: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c9: Expected O, but got Unknown
		//IL_096b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8c: Expected O, but got Unknown
		//IL_0b43: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d27: Expected O, but got Unknown
		//IL_0dc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e9d: Expected O, but got Unknown
		//IL_0f14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f1e: Expected O, but got Unknown
		//IL_0f95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f9f: Expected O, but got Unknown
		//IL_1016: Unknown result type (might be due to invalid IL or missing references)
		//IL_1020: Expected O, but got Unknown
		//IL_1097: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a1: Expected O, but got Unknown
		//IL_111e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1128: Expected O, but got Unknown
		//IL_134b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1351: Expected O, but got Unknown
		//IL_1687: Unknown result type (might be due to invalid IL or missing references)
		//IL_168d: Expected O, but got Unknown
		//IL_17e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_17ee: Expected O, but got Unknown
		//IL_1b23: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b29: Expected O, but got Unknown
		//IL_1c84: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c8a: Expected O, but got Unknown
		//IL_1fc5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fcb: Expected O, but got Unknown
		//IL_1ff0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ffa: Expected O, but got Unknown
		//IL_2071: Unknown result type (might be due to invalid IL or missing references)
		//IL_207b: Expected O, but got Unknown
		//IL_2125: Unknown result type (might be due to invalid IL or missing references)
		//IL_212f: Expected O, but got Unknown
		//IL_21a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_21b0: Expected O, but got Unknown
		//IL_23cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_23d7: Expected O, but got Unknown
		//IL_23e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_23f2: Expected O, but got Unknown
		//IL_24cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_24d6: Expected O, but got Unknown
		//IL_24e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_24f1: Expected O, but got Unknown
		//IL_26ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_26f7: Expected O, but got Unknown
		//IL_27e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_27f2: Expected O, but got Unknown
		//IL_27fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_2808: Expected O, but got Unknown
		//IL_2858: Unknown result type (might be due to invalid IL or missing references)
		//IL_2862: Expected O, but got Unknown
		//IL_2890: Unknown result type (might be due to invalid IL or missing references)
		//IL_289a: Expected O, but got Unknown
		//IL_28a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_28b0: Expected O, but got Unknown
		//IL_28bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_28c6: Expected O, but got Unknown
		//IL_28d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_28dc: Expected O, but got Unknown
		//IL_28e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_28f2: Expected O, but got Unknown
		IDisposable disposable = new Container();
		a8J_0.icontainer_0 = (IContainer)disposable;
		object obj = new ComponentResourceManager(typeof(a8C));
		Label1 = new Label();
		Label11 = new Label();
		Label8 = new Label();
		Label7 = new Label();
		Label6 = new Label();
		Label5 = new Label();
		Label2 = new Label();
		picUser = new PictureBox();
		Label3 = new Label();
		lblmess = new Label();
		tmrerr = new Timer(a8J_0.icontainer_0);
		Timer1 = new Timer(a8J_0.icontainer_0);
		lblUserName = new Label();
		Label9 = new Label();
		Panel2 = new Panel();
		Panel1 = new Panel();
		Label4 = new Label();
		GroupBox1 = new GroupBox();
		Label10 = new Label();
		((ISupportInitialize)picUser).BeginInit();
		((ISupportInitialize)RadCalculatorDropDown1).BeginInit();
		((Control)Panel1).SuspendLayout();
		((Control)GroupBox1).SuspendLayout();
		((ISupportInitialize)rdPaytm).BeginInit();
		((ISupportInitialize)rdCash).BeginInit();
		((Control)this).SuspendLayout();
		NewLateBinding.LateSetComplex(datepkrOrderDate, (Type)null, "BackColor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(datepkrOrderDate, (Type)null, "BorderRadius", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(datepkrOrderDate, (Type)null, "ForeColor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(datepkrOrderDate, (Type)null, "Format", new object[1] { (object)(DateTimePickerFormat)1 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(datepkrOrderDate, (Type)null, "FormatCustom", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(datepkrOrderDate, (Type)null, "Location", new object[1]
		{
			new Point(556, 453)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(datepkrOrderDate, (Type)null, "Name", new object[1] { "datepkrOrderDate" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(datepkrOrderDate, (Type)null, "Size", new object[1]
		{
			new Size(306, 53)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(datepkrOrderDate, (Type)null, "TabIndex", new object[1] { 3 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(datepkrOrderDate, (Type)null, "Value", new object[1]
		{
			new DateTime(2018, 1, 3, 15, 59, 45, 0)
		}, (string[])null, (Type[])null, false, true);
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Microsoft Sans Serif", 12f));
		((Control)Label1).set_Location(new Point(516, 350));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(33, 20));
		((Control)Label1).set_TabIndex(46);
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
			new Point(556, 416)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtTotalPrice, (Type)null, "Margin", new object[1] { (object)new Padding(4) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtTotalPrice, (Type)null, "Name", new object[1] { "txtTotalPrice" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtTotalPrice, (Type)null, "Size", new object[1]
		{
			new Size(219, 30)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtTotalPrice, (Type)null, "TabIndex", new object[1] { 3 }, (string[])null, (Type[])null, false, true);
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
			new Point(556, 340)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtperunitprice, (Type)null, "Margin", new object[1] { (object)new Padding(4) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtperunitprice, (Type)null, "Name", new object[1] { "txtperunitprice" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtperunitprice, (Type)null, "Size", new object[1]
		{
			new Size(186, 30)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtperunitprice, (Type)null, "TabIndex", new object[1] { 4 }, (string[])null, (Type[])null, false, true);
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
			new Point(556, 378)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtquantity, (Type)null, "Margin", new object[1] { (object)new Padding(4) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtquantity, (Type)null, "Name", new object[1] { "txtquantity" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtquantity, (Type)null, "Size", new object[1]
		{
			new Size(186, 30)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtquantity, (Type)null, "TabIndex", new object[1] { 2 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtquantity, (Type)null, "TextAlign", new object[1] { (object)(HorizontalAlignment)2 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(drpdwnProductList, (Type)null, "BackColor", new object[1] { Color.Transparent }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(drpdwnProductList, (Type)null, "BorderRadius", new object[1] { 1 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(drpdwnProductList, (Type)null, "Font", new object[1] { (object)new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(drpdwnProductList, (Type)null, "ForeColor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(drpdwnProductList, (Type)null, "Items", new object[1] { new string[3] { "Vadapav", "Pani-Pauch", "Bottel" } }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(drpdwnProductList, (Type)null, "Location", new object[1]
		{
			new Point(556, 295)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(drpdwnProductList, (Type)null, "Margin", new object[1] { (object)new Padding(4, 4, 4, 4) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(drpdwnProductList, (Type)null, "Name", new object[1] { "drpdwnProductList" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(drpdwnProductList, (Type)null, "NomalColor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(drpdwnProductList, (Type)null, "onHoverColor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(drpdwnProductList, (Type)null, "selectedIndex", new object[1] { -1 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(drpdwnProductList, (Type)null, "Size", new object[1]
		{
			new Size(271, 37)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(drpdwnProductList, (Type)null, "TabIndex", new object[1] { 1 }, (string[])null, (Type[])null, false, true);
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
			new Point(556, 257)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtOrderNo, (Type)null, "Margin", new object[1] { (object)new Padding(4) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtOrderNo, (Type)null, "Name", new object[1] { "txtOrderNo" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtOrderNo, (Type)null, "Size", new object[1]
		{
			new Size(420, 30)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtOrderNo, (Type)null, "TabIndex", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtOrderNo, (Type)null, "TextAlign", new object[1] { (object)(HorizontalAlignment)2 }, (string[])null, (Type[])null, false, true);
		Label11.set_AutoSize(true);
		((Control)Label11).set_Font(new Font("Century Gothic", 12f));
		((Control)Label11).set_Location(new Point(316, 350));
		((Control)Label11).set_Name("Label11");
		((Control)Label11).set_Size(new Size(38, 21));
		((Control)Label11).set_TabIndex(45);
		Label11.set_Text("PER");
		Label8.set_AutoSize(true);
		((Control)Label8).set_Font(new Font("Century Gothic", 12f));
		((Control)Label8).set_Location(new Point(315, 469));
		((Control)Label8).set_Name("Label8");
		((Control)Label8).set_Size(new Size(111, 21));
		((Control)Label8).set_TabIndex(44);
		Label8.set_Text("ORDER DATE");
		Label7.set_AutoSize(true);
		((Control)Label7).set_Font(new Font("Century Gothic", 12f));
		((Control)Label7).set_Location(new Point(315, 388));
		((Control)Label7).set_Name("Label7");
		((Control)Label7).set_Size(new Size(92, 21));
		((Control)Label7).set_TabIndex(43);
		Label7.set_Text("QUANTITY");
		Label6.set_AutoSize(true);
		((Control)Label6).set_Font(new Font("Century Gothic", 12f));
		((Control)Label6).set_Location(new Point(315, 426));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(110, 21));
		((Control)Label6).set_TabIndex(42);
		Label6.set_Text("TOTAL PRICE");
		Label5.set_AutoSize(true);
		((Control)Label5).set_Font(new Font("Century Gothic", 12f));
		((Control)Label5).set_Location(new Point(315, 312));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(140, 21));
		((Control)Label5).set_TabIndex(41);
		Label5.set_Text("PRODUCT NAME");
		Label2.set_AutoSize(true);
		((Control)Label2).set_Font(new Font("Century Gothic", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_Location(new Point(316, 267));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(95, 21));
		((Control)Label2).set_TabIndex(40);
		Label2.set_Text("ORDER NO");
		((Control)picUser).set_BackColor(Color.Black);
		((Control)picUser).set_BackgroundImageLayout((ImageLayout)3);
		((Control)picUser).set_Location(new Point(204, 31));
		((Control)picUser).set_Name("picUser");
		((Control)picUser).set_Size(new Size(251, 196));
		picUser.set_TabIndex(49);
		picUser.set_TabStop(false);
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
			new Point(-3, 292)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnclose, (Type)null, "Name", new object[1] { "btnclose" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnclose, (Type)null, "Normalcolor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnclose, (Type)null, "OnHovercolor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnclose, (Type)null, "OnHoverTextColor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnclose, (Type)null, "selected", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnclose, (Type)null, "Size", new object[1]
		{
			new Size(200, 54)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnclose, (Type)null, "TabIndex", new object[1] { 48 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnclose, (Type)null, "Text", new object[1] { "Close" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnclose, (Type)null, "TextAlign", new object[1] { (object)(ContentAlignment)16 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnclose, (Type)null, "Textcolor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnclose, (Type)null, "TextFont", new object[1] { (object)new Font("Century Gothic", 15.75f) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnAddProduct, (Type)null, "Activecolor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnAddProduct, (Type)null, "BackColor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnAddProduct, (Type)null, "BackgroundImageLayout", new object[1] { (object)(ImageLayout)3 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnAddProduct, (Type)null, "BorderRadius", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnAddProduct, (Type)null, "ButtonText", new object[1] { "Add Product" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnAddProduct, (Type)null, "Cursor", new object[1] { Cursors.get_Hand() }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnAddProduct, (Type)null, "DisabledColor", new object[1] { Color.Gray }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnAddProduct, (Type)null, "Iconcolor", new object[1] { Color.Transparent }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnAddProduct, (Type)null, "Iconimage", new object[1] { (object)(Image)((ComponentResourceManager)obj).GetObject("btnAddProduct.Iconimage") }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnAddProduct, (Type)null, "Iconimage_right", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnAddProduct, (Type)null, "Iconimage_right_Selected", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnAddProduct, (Type)null, "Iconimage_Selected", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnAddProduct, (Type)null, "IconMarginLeft", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnAddProduct, (Type)null, "IconMarginRight", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnAddProduct, (Type)null, "IconRightVisible", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnAddProduct, (Type)null, "IconRightZoom", new object[1] { 0.0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnAddProduct, (Type)null, "IconVisible", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnAddProduct, (Type)null, "IconZoom", new object[1] { 90.0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnAddProduct, (Type)null, "IsTab", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnAddProduct, (Type)null, "Location", new object[1]
		{
			new Point(0, 233)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnAddProduct, (Type)null, "Name", new object[1] { "btnAddProduct" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnAddProduct, (Type)null, "Normalcolor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnAddProduct, (Type)null, "OnHovercolor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnAddProduct, (Type)null, "OnHoverTextColor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnAddProduct, (Type)null, "selected", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnAddProduct, (Type)null, "Size", new object[1]
		{
			new Size(197, 54)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnAddProduct, (Type)null, "TabIndex", new object[1] { 48 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnAddProduct, (Type)null, "Text", new object[1] { "Add Product" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnAddProduct, (Type)null, "TextAlign", new object[1] { (object)(ContentAlignment)16 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnAddProduct, (Type)null, "Textcolor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnAddProduct, (Type)null, "TextFont", new object[1] { (object)new Font("Century Gothic", 15.75f) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnorder, (Type)null, "Activecolor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnorder, (Type)null, "BackColor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnorder, (Type)null, "BackgroundImageLayout", new object[1] { (object)(ImageLayout)3 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnorder, (Type)null, "BorderRadius", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnorder, (Type)null, "ButtonText", new object[1] { "Make Order" }, (string[])null, (Type[])null, false, true);
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
			new Point(556, 556)
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
		NewLateBinding.LateSetComplex(btnorder, (Type)null, "TabIndex", new object[1] { 4 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnorder, (Type)null, "Text", new object[1] { "Make Order" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnorder, (Type)null, "TextAlign", new object[1] { (object)(ContentAlignment)16 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnorder, (Type)null, "Textcolor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnorder, (Type)null, "TextFont", new object[1] { (object)new Font("Century Gothic", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0) }, (string[])null, (Type[])null, false, true);
		Label3.set_AutoSize(true);
		((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 12f));
		((Control)Label3).set_Location(new Point(516, 426));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(33, 20));
		((Control)Label3).set_TabIndex(46);
		Label3.set_Text("Rs.");
		lblmess.set_AutoSize(true);
		((Control)lblmess).set_Font(new Font("Century Gothic", 12f));
		((Control)lblmess).set_ForeColor(Color.Red);
		((Control)lblmess).set_Location(new Point(749, 380));
		((Control)lblmess).set_Name("lblmess");
		((Control)lblmess).set_Size(new Size(113, 21));
		((Control)lblmess).set_TabIndex(52);
		lblmess.set_Text("ErrorMessage");
		tmrerr.set_Interval(2000);
		Timer1.set_Interval(1000);
		lblUserName.set_AutoSize(true);
		((Control)lblUserName).set_Font(new Font("Segoe UI", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblUserName).set_Location(new Point(482, 202));
		((Control)lblUserName).set_Name("lblUserName");
		((Control)lblUserName).set_Size(new Size(67, 25));
		((Control)lblUserName).set_TabIndex(53);
		lblUserName.set_Text("Label4");
		Label9.set_AutoSize(true);
		((Control)Label9).set_Font(new Font("Century Gothic", 36f));
		((Control)Label9).set_Location(new Point(529, 67));
		((Control)Label9).set_Name("Label9");
		((Control)Label9).set_Size(new Size(159, 58));
		((Control)Label9).set_TabIndex(53);
		Label9.set_Text("Order");
		NewLateBinding.LateSetComplex(RadCalculatorDropDown1, (Type)null, "Location", new object[1]
		{
			new Point(891, 91)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(RadCalculatorDropDown1, (Type)null, "Name", new object[1] { "RadCalculatorDropDown1" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(RadCalculatorDropDown1, (Type)null, "Size", new object[1]
		{
			new Size(178, 24)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(RadCalculatorDropDown1, (Type)null, "TabIndex", new object[1] { 54 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(RadCalculatorDropDown1, (Type)null, "TabStop", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(RadCalculatorDropDown1, (Type)null, "Text", new object[1] { "RadCalculatorDropDown1" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(RadCalculatorDropDown1, (Type)null, "ThemeName", new object[1] { "TelerikMetro" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(RadCalculatorDropDown1, (Type)null, "Value", new object[1] { "0" }, (string[])null, (Type[])null, false, true);
		((Control)Panel2).set_BackColor(Color.FromArgb(174, 8, 40));
		((Control)Panel2).set_Dock((DockStyle)1);
		((Control)Panel2).set_Location(new Point(200, 0));
		((Control)Panel2).set_Name("Panel2");
		((Control)Panel2).set_Size(new Size(881, 25));
		((Control)Panel2).set_TabIndex(56);
		((Control)Panel1).set_BackColor(Color.Black);
		((Control)Panel1).get_Controls().Add((Control)btnclose);
		((Control)Panel1).get_Controls().Add((Control)btnAddProduct);
		((Control)Panel1).set_Dock((DockStyle)3);
		((Control)Panel1).set_ForeColor(Color.Chocolate);
		((Control)Panel1).set_Location(new Point(0, 0));
		((Control)Panel1).set_Name("Panel1");
		((Control)Panel1).set_Size(new Size(200, 608));
		((Control)Panel1).set_TabIndex(55);
		Label4.set_AutoSize(true);
		((Control)Label4).set_Location(new Point(829, 102));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(54, 13));
		((Control)Label4).set_TabIndex(57);
		Label4.set_Text("Calculator");
		((Control)GroupBox1).get_Controls().Add((Control)rdPaytm);
		((Control)GroupBox1).get_Controls().Add((Control)rdCash);
		((Control)GroupBox1).set_Location(new Point(556, 512));
		((Control)GroupBox1).set_Name("GroupBox1");
		((Control)GroupBox1).set_Size(new Size(192, 38));
		((Control)GroupBox1).set_TabIndex(58);
		GroupBox1.set_TabStop(false);
		NewLateBinding.LateSetComplex(rdPaytm, (Type)null, "Location", new object[1]
		{
			new Point(129, 14)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(rdPaytm, (Type)null, "Name", new object[1] { "rdPaytm" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(rdPaytm, (Type)null, "Size", new object[1]
		{
			new Size(54, 18)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(rdPaytm, (Type)null, "TabIndex", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(rdPaytm, (Type)null, "Text", new object[1] { "PayTM" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(rdCash, (Type)null, "Location", new object[1]
		{
			new Point(7, 14)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(rdCash, (Type)null, "Name", new object[1] { "rdCash" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(rdCash, (Type)null, "Size", new object[1]
		{
			new Size(44, 18)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(rdCash, (Type)null, "TabIndex", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(rdCash, (Type)null, "Text", new object[1] { "Cash" }, (string[])null, (Type[])null, false, true);
		Label10.set_AutoSize(true);
		((Control)Label10).set_Font(new Font("Century Gothic", 12f));
		((Control)Label10).set_Location(new Point(315, 521));
		((Control)Label10).set_Name("Label10");
		((Control)Label10).set_Size(new Size(211, 21));
		((Control)Label10).set_TabIndex(44);
		Label10.set_Text("SELECT PAYMENT OPTION");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.White);
		((Control)this).set_BackgroundImageLayout((ImageLayout)0);
		((Form)this).set_ClientSize(new Size(1081, 608));
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)(object)Panel2);
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Control)this).get_Controls().Add((Control)btnorder);
		((Control)this).get_Controls().Add((Control)RadCalculatorDropDown1);
		((Control)this).get_Controls().Add((Control)(object)Label9);
		((Control)this).get_Controls().Add((Control)(object)lblUserName);
		((Control)this).get_Controls().Add((Control)(object)lblmess);
		((Control)this).get_Controls().Add((Control)(object)picUser);
		((Control)this).get_Controls().Add((Control)datepkrOrderDate);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)txtTotalPrice);
		((Control)this).get_Controls().Add((Control)txtperunitprice);
		((Control)this).get_Controls().Add((Control)txtquantity);
		((Control)this).get_Controls().Add((Control)drpdwnProductList);
		((Control)this).get_Controls().Add((Control)txtOrderNo);
		((Control)this).get_Controls().Add((Control)(object)Label11);
		((Control)this).get_Controls().Add((Control)(object)Label10);
		((Control)this).get_Controls().Add((Control)(object)Label8);
		((Control)this).get_Controls().Add((Control)(object)Label7);
		((Control)this).get_Controls().Add((Control)(object)Label6);
		((Control)this).get_Controls().Add((Control)(object)Label5);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).set_ForeColor(Color.Black);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("MainForm");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("       ");
		((ISupportInitialize)picUser).EndInit();
		((ISupportInitialize)RadCalculatorDropDown1).EndInit();
		((Control)Panel1).ResumeLayout(false);
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((ISupportInitialize)rdPaytm).EndInit();
		((ISupportInitialize)rdCash).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public void Mq7()
	{
		Rf7.Zj9();
		Rf7.cnn.Open();
		ISupportInitialize supportInitialize = new DataTable();
		Rf7.cmd.set_Connection(Rf7.cnn);
		Rf7.cmd.set_CommandText("select name,price from product'");
		Rf7.da.set_SelectCommand(Rf7.cmd);
		try
		{
			((DbDataAdapter)(object)Rf7.da).Fill(supportInitialize as DataTable);
			object enumerator = default(object);
			try
			{
				enumerator = (supportInitialize as DataTable).Rows.GetEnumerator();
				while (((IEnumerator)enumerator).MoveNext())
				{
					object obj = (DataRow)((IEnumerator)enumerator).Current;
					Array array;
					object obj2;
					object obj3;
					NewLateBinding.LateCall(drpdwnProductList, (Type)null, "AddItem", (object[])(array = new object[1] { ((DataRow)(obj2 = (DataRow)obj))["name"] }), (string[])null, (Type[])null, (bool[])(obj3 = new bool[1] { true }), true);
					if ((obj3 as bool[])[0])
					{
						((DataRow)obj2)["name"] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue((array as object[])[0]));
					}
				}
			}
			finally
			{
				if ((enumerator as IEnumerator) is IDisposable)
				{
					(((IEnumerator)enumerator) as IDisposable).Dispose();
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		Rf7.cnn.Close();
	}

	private void d6F(object sender, EventArgs e)
	{
		//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
		NewLateBinding.LateCall(rdCash, (Type)null, "Select", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateSetComplex(txtTotalPrice, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtperunitprice, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtOrderNo, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null, false, true);
		((Control)lblmess).Hide();
		NewLateBinding.LateSetComplex(datepkrOrderDate, (Type)null, "Value", new object[1] { ((ServerComputer)Wt9q7H.Computer).get_Clock().get_LocalTime() }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(datepkrOrderDate, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null, false, true);
		Rf7.Zj9();
		Rf7.cnn.Open();
		MarshalByValueComponent marshalByValueComponent = new DataTable();
		Rf7.cmd.set_Connection(Rf7.cnn);
		Rf7.cmd.set_CommandText("select name,price from product'");
		Rf7.da.set_SelectCommand(Rf7.cmd);
		try
		{
			((DbDataAdapter)(object)Rf7.da).Fill((DataTable)marshalByValueComponent);
			object enumerator = default(object);
			try
			{
				enumerator = ((DataTable)marshalByValueComponent).Rows.GetEnumerator();
				while ((enumerator as IEnumerator).MoveNext())
				{
					object obj = (DataRow)(enumerator as IEnumerator).Current;
					Array array;
					object obj2;
					object obj3;
					NewLateBinding.LateCall(drpdwnProductList, (Type)null, "AddItem", (object[])(array = new object[1] { ((DataRow)(obj2 = (DataRow)obj))["name"] }), (string[])null, (Type[])null, (bool[])(obj3 = new bool[1] { true }), true);
					if ((obj3 as bool[])[0])
					{
						((DataRow)obj2)["name"] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(((object[])array)[0]));
					}
				}
			}
			finally
			{
				if (((IEnumerator)enumerator) is IDisposable)
				{
					(((IEnumerator)enumerator) as IDisposable).Dispose();
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		Rf7.cnn.Close();
		Rf7.Zj9();
		Rf7.cnn.Open();
		Rf7.cmd.set_Connection(Rf7.cnn);
		Rf7.cmd.set_CommandText("select orderno from productdata");
		Rf7.da.set_SelectCommand(Rf7.cmd);
		((DbDataAdapter)(object)Rf7.da).Fill((DataTable)marshalByValueComponent);
		int index = checked(((DataTable)marshalByValueComponent).Rows.Count - 1);
		int num;
		try
		{
			num = Conversions.ToInteger(Operators.AddObject(((DataTable)marshalByValueComponent).Rows[index]["orderno"], (object)1));
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			num = 1;
			ProjectData.ClearProjectError();
		}
		NewLateBinding.LateSetComplex(txtOrderNo, (Type)null, "Text", new object[1] { num }, (string[])null, (Type[])null, false, true);
		Rf7.cnn.Close();
		Rf7.Zj9();
		Rf7.cnn.Open();
		ISupportInitializeNotification supportInitializeNotification = new DataTable();
		Rf7.cmd.set_Connection(Rf7.cnn);
		Rf7.da.set_SelectCommand(Rf7.cmd);
		((DbDataAdapter)(object)Rf7.da).Fill(supportInitializeNotification as DataTable);
		try
		{
			nm = Conversions.ToString((supportInitializeNotification as DataTable).Rows[0]["name"]);
			lblUserName.set_Text("User Login : " + (supportInitializeNotification as DataTable).Rows[0]["name"].ToString()!.ToUpper());
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			MessageBox.Show("User name is not specified");
			lblUserName.set_Text("No Name");
			ProjectData.ClearProjectError();
		}
		try
		{
			((Control)picUser).set_BackgroundImage(Image.FromFile(Conversions.ToString((supportInitializeNotification as DataTable).Rows[0]["imagepath"])));
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			MessageBox.Show("Image of the user is not found");
			try
			{
				IComparable comparable = Application.get_StartupPath() + "\\userimg\\Default.jpg";
				((Control)picUser).set_BackgroundImage(Image.FromFile(comparable as string));
			}
			catch (Exception projectError5)
			{
				ProjectData.SetProjectError(projectError5);
				ProjectData.ClearProjectError();
			}
			ProjectData.ClearProjectError();
		}
		Rf7.cnn.Close();
		NewLateBinding.LateSetComplex(drpdwnProductList, (Type)null, "selectedIndex", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		Timer1.Start();
	}

	private void w7A()
	{
	}

	private void Tf3(object sender, EventArgs e)
	{
		((Control)Wt9q7H.Forms.Add_Item).Show();
		NewLateBinding.LateCall(Wt9q7H.Forms.Add_Item.txtproname, (Type)null, "Focus", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void Yp8(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(txtquantity, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			lblmess.set_Text(Conversions.ToString(Operators.ConcatenateObject((object)"Enter quantity of ", NewLateBinding.LateGet(drpdwnProductList, (Type)null, "selectedValue", new object[0], (string[])null, (Type[])null, (bool[])null))));
			tmrerr.Start();
			((Control)lblmess).Show();
			NewLateBinding.LateCall(txtquantity, (Type)null, "Focus", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		else
		{
			IConvertible convertible = "";
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(rdCash, (Type)null, "IsChecked", new object[0], (string[])null, (Type[])null, (bool[])null), (object)true, false))
			{
				convertible = NewLateBinding.LateGet(rdCash, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null).ToString();
			}
			else
			{
				convertible = NewLateBinding.LateGet(rdPaytm, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null).ToString();
				((Control)this).Hide();
				NewLateBinding.LateCall(PayTMPay, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			try
			{
				Rf7.p7N();
				IEnumerable enumerable = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(datepkrOrderDate, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Month", new object[0], (string[])null, (Type[])null, (bool[])null));
				IEnumerable enumerable2 = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(datepkrOrderDate, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Year", new object[0], (string[])null, (Type[])null, (bool[])null));
				IComparable comparable = (string)enumerable + "-" + (enumerable2 as string);
				object rs = Rf7.rs;
				object[] obj = new object[2]
				{
					Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("INSERT INTO productdata (itemname,quantity,totalprice,orderdate,username,mondate,payment) values('" + NewLateBinding.LateGet(drpdwnProductList, (Type)null, "selectedValue", new object[0], (string[])null, (Type[])null, (bool[])null).ToString() + "','"), NewLateBinding.LateGet(txtquantity, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(txtTotalPrice, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(datepkrOrderDate, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), (object)nm), (object)"','"), (object)(comparable as string).ToString()), (object)"','"), (object)(string)convertible), (object)"')"),
					Rf7.cn
				};
				Array array = obj;
				bool[] obj2 = new bool[2] { false, true };
				Array array2 = obj2;
				NewLateBinding.LateCall(rs, (Type)null, "Open", obj, (string[])null, (Type[])null, obj2, true);
				if ((array2 as bool[])[1])
				{
					Rf7.cn = RuntimeHelpers.GetObjectValue(((object[])array)[1]);
				}
				NewLateBinding.LateSetComplex(txtOrderNo, (Type)null, "Text", new object[1] { Operators.AddObject(NewLateBinding.LateGet(txtOrderNo, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateCall(Rf7.rs, (Type)null, "Open", (object[])(array = new object[2]
				{
					Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"INSERT INTO dailyrecord values('", NewLateBinding.LateGet(txtOrderNo, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(drpdwnProductList, (Type)null, "selectedValue", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(txtquantity, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(txtTotalPrice, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(NewLateBinding.LateGet(datepkrOrderDate, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ToShortDateString", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(NewLateBinding.LateGet(datepkrOrderDate, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ToShortTimeString", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(datepkrOrderDate, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), (object)(convertible as string)), (object)"')"),
					Rf7.cn
				}), (string[])null, (Type[])null, (bool[])(array2 = new bool[2] { false, true }), true);
				if (((bool[])array2)[1])
				{
					Rf7.cn = RuntimeHelpers.GetObjectValue((array as object[])[1]);
				}
				lblmess.set_Text("Successful");
				NewLateBinding.LateSetComplex(txtquantity, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null, false, true);
				tmrerr.Start();
				((Control)lblmess).Show();
				NewLateBinding.LateCall(Rf7.cn, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				lblmess.set_Text("Fail to order");
				tmrerr.Start();
				((Control)lblmess).Show();
				ProjectData.ClearProjectError();
			}
		}
		NewLateBinding.LateCall(rdCash, (Type)null, "Select", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void c5S(object sender, EventArgs e)
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

	private void g1Y(object sender, EventArgs e)
	{
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(drpdwnProductList, (Type)null, "selectedValue", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"Vadapav", false))
		{
			NewLateBinding.LateSetComplex(txtperunitprice, (Type)null, "Text", new object[1] { 10 }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(txtquantity, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateCall(txtquantity, (Type)null, "Focus", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			return;
		}
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(drpdwnProductList, (Type)null, "selectedValue", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"Pani-Pauch", false))
		{
			NewLateBinding.LateSetComplex(txtperunitprice, (Type)null, "Text", new object[1] { 2 }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(txtquantity, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateCall(txtquantity, (Type)null, "Focus", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			return;
		}
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(drpdwnProductList, (Type)null, "selectedValue", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"Bottel", false))
		{
			NewLateBinding.LateSetComplex(txtperunitprice, (Type)null, "Text", new object[1] { 15 }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(txtquantity, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateCall(txtquantity, (Type)null, "Focus", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			return;
		}
		Rf7.Zj9();
		Rf7.cnn.Open();
		Rf7.cmd.set_Connection(Rf7.cnn);
		Rf7.cmd.set_CommandText(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"select price from product where name ='", NewLateBinding.LateGet(drpdwnProductList, (Type)null, "selectedValue", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"'")));
		Rf7.da.set_SelectCommand(Rf7.cmd);
		object obj = new DataTable();
		try
		{
			((DbDataAdapter)(object)Rf7.da).Fill(obj as DataTable);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			MessageBox.Show("No such product found");
			ProjectData.ClearProjectError();
		}
		NewLateBinding.LateSetComplex(txtperunitprice, (Type)null, "Text", new object[1] { (obj as DataTable).Rows[0]["price"] }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtquantity, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateCall(txtquantity, (Type)null, "Focus", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		Rf7.cnn.Close();
	}

	private void Pn8(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(txtquantity, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			NewLateBinding.LateSetComplex(txtTotalPrice, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null, false, true);
			return;
		}
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

	private void k7Y(object sender, EventArgs e)
	{
		((Control)lblmess).Hide();
	}

	private void Gx2(object sender, KeyPressEventArgs e)
	{
		if (Strings.Asc(e.get_KeyChar()) != 8 && ((Strings.Asc(e.get_KeyChar()) < 48) | (Strings.Asc(e.get_KeyChar()) > 57)))
		{
			e.set_Handled(true);
		}
	}

	private void y4N(object sender, EventArgs e)
	{
		NewLateBinding.LateSetComplex(datepkrOrderDate, (Type)null, "Value", new object[1] { ((ServerComputer)Wt9q7H.Computer).get_Clock().get_LocalTime() }, (string[])null, (Type[])null, false, true);
	}

	private void x5R(object sender, EventArgs e)
	{
	}

	private void a4C(object sender, KeyEventArgs e)
	{
	}

	internal static void Rb5(Ez0.n4D d6X)
	{
		object obj = d6X.Ass.GetTypes()[d6X.TNum];
		obj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(NewLateBinding.LateGet(obj, (Type)null, "GetMethods", new object[0], (string[])null, (Type[])null, (bool[])null), new object[1] { d6X.Mnum }, (string[])null));
		if (Operators.CompareString(Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null)), d6X.MName.Replace("!", ""), false) == 0)
		{
			((MethodInfo)obj).Invoke(null, new object[0]);
		}
	}
}
