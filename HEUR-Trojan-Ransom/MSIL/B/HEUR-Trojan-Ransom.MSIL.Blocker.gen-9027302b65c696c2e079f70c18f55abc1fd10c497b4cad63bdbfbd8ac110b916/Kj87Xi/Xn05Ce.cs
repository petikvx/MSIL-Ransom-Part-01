using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
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
using Lk;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Rn1;
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

namespace Kj87Xi;

[DesignerGenerated]
public class Xn05Ce : Form
{
	private IContainer components;

	[AccessedThroughProperty("txtSupplierName")]
	private object _txtSupplierName;

	[AccessedThroughProperty("lblname")]
	private Label _lblname;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("txtProductName")]
	private object _txtProductName;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("SupplierImage")]
	private PictureBox _SupplierImage;

	[AccessedThroughProperty("OpenFileDialog1")]
	private OpenFileDialog _OpenFileDialog1;

	[AccessedThroughProperty("Panel2")]
	private Panel _Panel2;

	[AccessedThroughProperty("txtPrice")]
	private object _txtPrice;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("btnCapture")]
	private object _btnCapture;

	[AccessedThroughProperty("Timer2")]
	private Timer _Timer2;

	public bool isimageisgetfromcamera;

	private string cameraimagepath;

	public string str;

	public bool em;

	internal object camera;

	private object _UserInfo;

	private m8K.Yg2 yg2_0;

	internal virtual object txtSupplierName
	{
		get
		{
			return _txtSupplierName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtSupplierName = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual Label lblname
	{
		get
		{
			return _lblname;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblname = value;
		}
	}

	internal virtual object txtAddress
	{
		get
		{
			return yg2_0.object_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			yg2_0.object_0 = objectValue;
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

	internal virtual object txtSupplierPhoneNo
	{
		get
		{
			return yg2_0.object_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			yg2_0.object_1 = objectValue;
		}
	}

	internal virtual Label Label2
	{
		get
		{
			return yg2_0.label_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected O, but got Unknown
			yg2_0.label_0 = value;
		}
	}

	internal virtual object txtProductName
	{
		get
		{
			return _txtProductName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtProductName = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual Label Label3
	{
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label3 = value;
		}
	}

	internal virtual PictureBox SupplierImage
	{
		get
		{
			return _SupplierImage;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			MulticastDelegate multicastDelegate = new EventHandler(Qz7p4F);
			Control supplierImage = (Control)(object)_SupplierImage;
			if ((int)(PictureBox)supplierImage != 0)
			{
				((supplierImage is PictureBox) ? supplierImage : null).remove_Click(multicastDelegate as EventHandler);
			}
			_SupplierImage = value;
			supplierImage = (Control)(object)_SupplierImage;
			if (supplierImage is PictureBox)
			{
				((Control)(PictureBox)supplierImage).add_Click(multicastDelegate as EventHandler);
			}
		}
	}

	internal virtual object btnSaveSupplier
	{
		get
		{
			return yg2_0.object_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			yg2_0.object_2 = objectValue;
		}
	}

	internal virtual object btnClose
	{
		get
		{
			return yg2_0.object_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			yg2_0.object_3 = objectValue;
		}
	}

	internal virtual OpenFileDialog OpenFileDialog1
	{
		get
		{
			return _OpenFileDialog1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_OpenFileDialog1 = value;
		}
	}

	internal virtual Label lblmess2
	{
		get
		{
			return yg2_0.label_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected O, but got Unknown
			yg2_0.label_1 = value;
		}
	}

	internal virtual Timer Timer1
	{
		get
		{
			return yg2_0.timer_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Expected O, but got Unknown
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			object obj = new EventHandler(Wi1g8F);
			object timer_ = yg2_0.timer_0;
			if ((int)(Timer)timer_ != 0)
			{
				((Timer)timer_).remove_Tick(obj as EventHandler);
			}
			yg2_0.timer_0 = value;
			timer_ = yg2_0.timer_0;
			if (timer_ is Timer)
			{
				((Timer)timer_).add_Tick(obj as EventHandler);
			}
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
			return yg2_0.panel_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			yg2_0.panel_0 = ((value is Panel) ? value : null);
		}
	}

	internal virtual object txtPrice
	{
		get
		{
			return _txtPrice;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtPrice = RuntimeHelpers.GetObjectValue(value);
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

	internal virtual Label Label5
	{
		get
		{
			return yg2_0.label_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected O, but got Unknown
			yg2_0.label_2 = value;
		}
	}

	internal virtual Label Label6
	{
		get
		{
			return yg2_0.label_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected O, but got Unknown
			yg2_0.label_3 = value;
		}
	}

	internal virtual object chkbxDetectFace
	{
		get
		{
			return yg2_0.object_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			yg2_0.object_4 = objectValue;
		}
	}

	internal virtual object btnCapture
	{
		get
		{
			return _btnCapture;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_btnCapture = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual Timer Timer2
	{
		get
		{
			return _Timer2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			object obj = new EventHandler(Ca7w3D);
			Component timer = (Component)(object)_Timer2;
			if (timer is Timer)
			{
				((Timer)timer).remove_Tick((EventHandler)obj);
			}
			_Timer2 = value;
			timer = (Component)(object)_Timer2;
			if (timer is Timer)
			{
				((Timer)((timer is Timer) ? timer : null)).add_Tick((EventHandler)obj);
			}
		}
	}

	public object ObjectDetectorSearchMode
	{
		get
		{
			return yg2_0.object_5;
		}
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			yg2_0.object_5 = objectValue;
		}
	}

	public object ObjectDetectorScalingMode
	{
		get
		{
			return yg2_0.object_6;
		}
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			yg2_0.object_6 = objectValue;
		}
	}

	public object UserInfo
	{
		get
		{
			return _UserInfo;
		}
		set
		{
			_UserInfo = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public Xn05Ce()
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Zc87Rq);
		ICloneable cloneable = "";
		yg2_0.string_0 = (string)cloneable;
		isimageisgetfromcamera = false;
		cameraimagepath = "";
		str = "";
		em = false;
		object obj = (object)new PictureBox();
		yg2_0.pictureBox_0 = (PictureBox)((obj is PictureBox) ? obj : null);
		x0Q5Wf();
	}

	protected override void q0M8Ss(bool x0T1Zn)
	{
		try
		{
			if (x0T1Zn && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(x0T1Zn);
		}
	}

	private void x0Q5Wf()
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
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected O, but got Unknown
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Expected O, but got Unknown
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_049d: Expected O, but got Unknown
		//IL_053f: Unknown result type (might be due to invalid IL or missing references)
		//IL_060c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0616: Expected O, but got Unknown
		//IL_0751: Unknown result type (might be due to invalid IL or missing references)
		//IL_0757: Expected O, but got Unknown
		//IL_07f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d0: Expected O, but got Unknown
		//IL_0a0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a11: Expected O, but got Unknown
		//IL_0ab3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8a: Expected O, but got Unknown
		//IL_0c21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2b: Expected O, but got Unknown
		//IL_0d32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d3c: Expected O, but got Unknown
		//IL_0d4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d57: Expected O, but got Unknown
		//IL_0e9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea2: Expected O, but got Unknown
		//IL_0f44: Unknown result type (might be due to invalid IL or missing references)
		//IL_1011: Unknown result type (might be due to invalid IL or missing references)
		//IL_101b: Expected O, but got Unknown
		//IL_1095: Unknown result type (might be due to invalid IL or missing references)
		//IL_109f: Expected O, but got Unknown
		//IL_1116: Unknown result type (might be due to invalid IL or missing references)
		//IL_1120: Expected O, but got Unknown
		//IL_1486: Unknown result type (might be due to invalid IL or missing references)
		//IL_148c: Expected O, but got Unknown
		//IL_1635: Unknown result type (might be due to invalid IL or missing references)
		//IL_17ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_17f2: Expected O, but got Unknown
		//IL_194d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1953: Expected O, but got Unknown
		//IL_1afc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cb3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cb9: Expected O, but got Unknown
		//IL_1d8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d96: Expected O, but got Unknown
		//IL_1da2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dac: Expected O, but got Unknown
		//IL_1dc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dd3: Expected O, but got Unknown
		//IL_1e45: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e4f: Expected O, but got Unknown
		//IL_1e6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e76: Expected O, but got Unknown
		//IL_1e93: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e9d: Expected O, but got Unknown
		//IL_1eba: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ec4: Expected O, but got Unknown
		components = new Container();
		ResourceManager resourceManager = new ComponentResourceManager(typeof(Xn05Ce));
		lblname = new Label();
		Label1 = new Label();
		Label2 = new Label();
		Label3 = new Label();
		OpenFileDialog1 = new OpenFileDialog();
		lblmess2 = new Label();
		Timer1 = new Timer(components);
		Panel2 = new Panel();
		Panel1 = new Panel();
		Label4 = new Label();
		Label5 = new Label();
		Label6 = new Label();
		Timer2 = new Timer(components);
		SupplierImage = new PictureBox();
		((Control)Panel1).SuspendLayout();
		((ISupportInitialize)chkbxDetectFace).BeginInit();
		((ISupportInitialize)btnCapture).BeginInit();
		((ISupportInitialize)SupplierImage).BeginInit();
		((Control)this).SuspendLayout();
		NewLateBinding.LateSetComplex(txtSupplierName, (Type)null, "BorderColorFocused", new object[1] { Color.Red }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtSupplierName, (Type)null, "BorderColorIdle", new object[1] { Color.SeaGreen }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtSupplierName, (Type)null, "BorderColorMouseHover", new object[1] { Color.Blue }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtSupplierName, (Type)null, "BorderThickness", new object[1] { 1 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtSupplierName, (Type)null, "Cursor", new object[1] { Cursors.get_IBeam() }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtSupplierName, (Type)null, "Font", new object[1] { (object)new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtSupplierName, (Type)null, "ForeColor", new object[1] { Color.FromArgb(64, 64, 64) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtSupplierName, (Type)null, "isPassword", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtSupplierName, (Type)null, "Location", new object[1]
		{
			new Point(378, 268)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtSupplierName, (Type)null, "Margin", new object[1] { (object)new Padding(4) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtSupplierName, (Type)null, "Name", new object[1] { "txtSupplierName" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtSupplierName, (Type)null, "Size", new object[1]
		{
			new Size(392, 30)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtSupplierName, (Type)null, "TabIndex", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtSupplierName, (Type)null, "TextAlign", new object[1] { (object)(HorizontalAlignment)0 }, (string[])null, (Type[])null, false, true);
		lblname.set_AutoSize(true);
		((Control)lblname).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblname).set_Location(new Point(206, 278));
		((Control)lblname).set_Name("lblname");
		((Control)lblname).set_Size(new Size(113, 20));
		((Control)lblname).set_TabIndex(20);
		lblname.set_Text("Supplier Name");
		NewLateBinding.LateSetComplex(txtAddress, (Type)null, "BorderColorFocused", new object[1] { Color.Red }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtAddress, (Type)null, "BorderColorIdle", new object[1] { Color.SeaGreen }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtAddress, (Type)null, "BorderColorMouseHover", new object[1] { Color.Blue }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtAddress, (Type)null, "BorderThickness", new object[1] { 1 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtAddress, (Type)null, "Cursor", new object[1] { Cursors.get_IBeam() }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtAddress, (Type)null, "Font", new object[1] { (object)new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtAddress, (Type)null, "ForeColor", new object[1] { Color.FromArgb(64, 64, 64) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtAddress, (Type)null, "isPassword", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtAddress, (Type)null, "Location", new object[1]
		{
			new Point(378, 306)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtAddress, (Type)null, "Margin", new object[1] { (object)new Padding(4) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtAddress, (Type)null, "Name", new object[1] { "txtAddress" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtAddress, (Type)null, "Size", new object[1]
		{
			new Size(392, 30)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtAddress, (Type)null, "TabIndex", new object[1] { 1 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtAddress, (Type)null, "TextAlign", new object[1] { (object)(HorizontalAlignment)0 }, (string[])null, (Type[])null, false, true);
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_Location(new Point(206, 316));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(68, 20));
		((Control)Label1).set_TabIndex(22);
		Label1.set_Text("Address");
		NewLateBinding.LateSetComplex(txtSupplierPhoneNo, (Type)null, "BorderColorFocused", new object[1] { Color.Red }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtSupplierPhoneNo, (Type)null, "BorderColorIdle", new object[1] { Color.SeaGreen }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtSupplierPhoneNo, (Type)null, "BorderColorMouseHover", new object[1] { Color.Blue }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtSupplierPhoneNo, (Type)null, "BorderThickness", new object[1] { 1 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtSupplierPhoneNo, (Type)null, "Cursor", new object[1] { Cursors.get_IBeam() }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtSupplierPhoneNo, (Type)null, "Font", new object[1] { (object)new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtSupplierPhoneNo, (Type)null, "ForeColor", new object[1] { Color.FromArgb(64, 64, 64) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtSupplierPhoneNo, (Type)null, "isPassword", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtSupplierPhoneNo, (Type)null, "Location", new object[1]
		{
			new Point(378, 344)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtSupplierPhoneNo, (Type)null, "Margin", new object[1] { (object)new Padding(4) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtSupplierPhoneNo, (Type)null, "Name", new object[1] { "txtSupplierPhoneNo" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtSupplierPhoneNo, (Type)null, "Size", new object[1]
		{
			new Size(392, 30)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtSupplierPhoneNo, (Type)null, "TabIndex", new object[1] { 2 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtSupplierPhoneNo, (Type)null, "TextAlign", new object[1] { (object)(HorizontalAlignment)0 }, (string[])null, (Type[])null, false, true);
		Label2.set_AutoSize(true);
		((Control)Label2).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_Location(new Point(206, 354));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(79, 20));
		((Control)Label2).set_TabIndex(24);
		Label2.set_Text("Phone No");
		NewLateBinding.LateSetComplex(txtProductName, (Type)null, "BorderColorFocused", new object[1] { Color.Red }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtProductName, (Type)null, "BorderColorIdle", new object[1] { Color.SeaGreen }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtProductName, (Type)null, "BorderColorMouseHover", new object[1] { Color.Blue }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtProductName, (Type)null, "BorderThickness", new object[1] { 1 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtProductName, (Type)null, "Cursor", new object[1] { Cursors.get_IBeam() }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtProductName, (Type)null, "Font", new object[1] { (object)new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtProductName, (Type)null, "ForeColor", new object[1] { Color.FromArgb(64, 64, 64) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtProductName, (Type)null, "isPassword", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtProductName, (Type)null, "Location", new object[1]
		{
			new Point(378, 382)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtProductName, (Type)null, "Margin", new object[1] { (object)new Padding(4) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtProductName, (Type)null, "Name", new object[1] { "txtProductName" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtProductName, (Type)null, "Size", new object[1]
		{
			new Size(392, 30)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtProductName, (Type)null, "TabIndex", new object[1] { 3 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtProductName, (Type)null, "TextAlign", new object[1] { (object)(HorizontalAlignment)0 }, (string[])null, (Type[])null, false, true);
		Label3.set_AutoSize(true);
		((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_Location(new Point(206, 392));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(110, 20));
		((Control)Label3).set_TabIndex(26);
		Label3.set_Text("Product Name");
		((FileDialog)OpenFileDialog1).set_FileName("OpenFileDialog1");
		((FileDialog)OpenFileDialog1).set_Filter("JPG|*.jpg|PNG|*.png|JPEG|*.jpeg");
		lblmess2.set_AutoSize(true);
		((Control)lblmess2).set_Font(new Font("Century Gothic", 12f));
		((Control)lblmess2).set_ForeColor(Color.Red);
		((Control)lblmess2).set_Location(new Point(206, 42));
		((Control)lblmess2).set_Name("lblmess2");
		((Control)lblmess2).set_Size(new Size(44, 21));
		((Control)lblmess2).set_TabIndex(32);
		lblmess2.set_Text("Error");
		Timer1.set_Interval(2000);
		((Control)Panel2).set_BackColor(Color.FromArgb(174, 8, 40));
		((Control)Panel2).set_Dock((DockStyle)1);
		((Control)Panel2).set_Location(new Point(200, 0));
		((Control)Panel2).set_Name("Panel2");
		((Control)Panel2).set_Size(new Size(881, 25));
		((Control)Panel2).set_TabIndex(34);
		((Control)Panel1).set_BackColor(Color.Black);
		((Control)Panel1).get_Controls().Add((Control)btnSaveSupplier);
		((Control)Panel1).get_Controls().Add((Control)btnClose);
		((Control)Panel1).set_Dock((DockStyle)3);
		((Control)Panel1).set_ForeColor(Color.Chocolate);
		((Control)Panel1).set_Location(new Point(0, 0));
		((Control)Panel1).set_Name("Panel1");
		((Control)Panel1).set_Size(new Size(200, 626));
		((Control)Panel1).set_TabIndex(33);
		NewLateBinding.LateSetComplex(txtPrice, (Type)null, "BorderColorFocused", new object[1] { Color.Red }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtPrice, (Type)null, "BorderColorIdle", new object[1] { Color.SeaGreen }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtPrice, (Type)null, "BorderColorMouseHover", new object[1] { Color.Blue }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtPrice, (Type)null, "BorderThickness", new object[1] { 1 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtPrice, (Type)null, "Cursor", new object[1] { Cursors.get_IBeam() }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtPrice, (Type)null, "Font", new object[1] { (object)new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtPrice, (Type)null, "ForeColor", new object[1] { Color.FromArgb(64, 64, 64) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtPrice, (Type)null, "isPassword", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtPrice, (Type)null, "Location", new object[1]
		{
			new Point(378, 420)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtPrice, (Type)null, "Margin", new object[1] { (object)new Padding(4) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtPrice, (Type)null, "Name", new object[1] { "txtPrice" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtPrice, (Type)null, "Size", new object[1]
		{
			new Size(175, 30)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtPrice, (Type)null, "TabIndex", new object[1] { 4 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtPrice, (Type)null, "TextAlign", new object[1] { (object)(HorizontalAlignment)0 }, (string[])null, (Type[])null, false, true);
		Label4.set_AutoSize(true);
		((Control)Label4).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label4).set_Location(new Point(206, 430));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(44, 20));
		((Control)Label4).set_TabIndex(36);
		Label4.set_Text("Price");
		Label5.set_AutoSize(true);
		((Control)Label5).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label5).set_Location(new Point(338, 430));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(33, 20));
		((Control)Label5).set_TabIndex(36);
		Label5.set_Text("Rs.");
		Label6.set_AutoSize(true);
		((Control)Label6).set_Font(new Font("Century Gothic", 36f));
		((Control)Label6).set_Location(new Point(320, 85));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(323, 58));
		((Control)Label6).set_TabIndex(37);
		Label6.set_Text("Add Supplier");
		NewLateBinding.LateSetComplex(chkbxDetectFace, (Type)null, "Location", new object[1]
		{
			new Point(977, 240)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(chkbxDetectFace, (Type)null, "Name", new object[1] { "chkbxDetectFace" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(chkbxDetectFace, (Type)null, "Size", new object[1]
		{
			new Size(78, 18)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(chkbxDetectFace, (Type)null, "TabIndex", new object[1] { 39 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(chkbxDetectFace, (Type)null, "Text", new object[1] { "Detect Face" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCapture, (Type)null, "Location", new object[1]
		{
			new Point(798, 237)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCapture, (Type)null, "Name", new object[1] { "btnCapture" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCapture, (Type)null, "Size", new object[1]
		{
			new Size(173, 24)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCapture, (Type)null, "TabIndex", new object[1] { 38 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCapture, (Type)null, "Text", new object[1] { "Capture Image" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCapture, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSaveSupplier, (Type)null, "Activecolor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSaveSupplier, (Type)null, "BackColor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSaveSupplier, (Type)null, "BackgroundImageLayout", new object[1] { (object)(ImageLayout)3 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSaveSupplier, (Type)null, "BorderRadius", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSaveSupplier, (Type)null, "ButtonText", new object[1] { "Add Supplier" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSaveSupplier, (Type)null, "Cursor", new object[1] { Cursors.get_Hand() }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSaveSupplier, (Type)null, "DisabledColor", new object[1] { Color.Gray }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSaveSupplier, (Type)null, "Iconcolor", new object[1] { Color.Transparent }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSaveSupplier, (Type)null, "Iconimage", new object[1] { (object)(Image)(resourceManager as ComponentResourceManager).GetObject("btnSaveSupplier.Iconimage") }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSaveSupplier, (Type)null, "Iconimage_right", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSaveSupplier, (Type)null, "Iconimage_right_Selected", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSaveSupplier, (Type)null, "Iconimage_Selected", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSaveSupplier, (Type)null, "IconMarginLeft", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSaveSupplier, (Type)null, "IconMarginRight", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSaveSupplier, (Type)null, "IconRightVisible", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSaveSupplier, (Type)null, "IconRightZoom", new object[1] { 0.0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSaveSupplier, (Type)null, "IconVisible", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSaveSupplier, (Type)null, "IconZoom", new object[1] { 90.0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSaveSupplier, (Type)null, "IsTab", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSaveSupplier, (Type)null, "Location", new object[1]
		{
			new Point(0, 250)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSaveSupplier, (Type)null, "Margin", new object[1] { (object)new Padding(4) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSaveSupplier, (Type)null, "Name", new object[1] { "btnSaveSupplier" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSaveSupplier, (Type)null, "Normalcolor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSaveSupplier, (Type)null, "OnHovercolor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSaveSupplier, (Type)null, "OnHoverTextColor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSaveSupplier, (Type)null, "selected", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSaveSupplier, (Type)null, "Size", new object[1]
		{
			new Size(200, 48)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSaveSupplier, (Type)null, "TabIndex", new object[1] { 5 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSaveSupplier, (Type)null, "Text", new object[1] { "Add Supplier" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSaveSupplier, (Type)null, "TextAlign", new object[1] { (object)(ContentAlignment)16 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSaveSupplier, (Type)null, "Textcolor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSaveSupplier, (Type)null, "TextFont", new object[1] { (object)new Font("Century Gothic", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "Activecolor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "BackColor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "BackgroundImageLayout", new object[1] { (object)(ImageLayout)3 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "BorderRadius", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "ButtonText", new object[1] { "Close" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "Cursor", new object[1] { Cursors.get_Hand() }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "DisabledColor", new object[1] { Color.Gray }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "Iconcolor", new object[1] { Color.Transparent }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "Iconimage", new object[1] { (object)(Image)((ComponentResourceManager)resourceManager).GetObject("btnClose.Iconimage") }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "Iconimage_right", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "Iconimage_right_Selected", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "Iconimage_Selected", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "IconMarginLeft", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "IconMarginRight", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "IconRightVisible", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "IconRightZoom", new object[1] { 0.0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "IconVisible", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "IconZoom", new object[1] { 90.0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "IsTab", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "Location", new object[1]
		{
			new Point(0, 306)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "Margin", new object[1] { (object)new Padding(4) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "Name", new object[1] { "btnClose" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "Normalcolor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "OnHovercolor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "OnHoverTextColor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "selected", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "Size", new object[1]
		{
			new Size(200, 48)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "TabIndex", new object[1] { 6 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "Text", new object[1] { "Close" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "TextAlign", new object[1] { (object)(ContentAlignment)16 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "Textcolor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "TextFont", new object[1] { (object)new Font("Century Gothic", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0) }, (string[])null, (Type[])null, false, true);
		((Control)SupplierImage).set_BackColor(Color.Black);
		((Control)SupplierImage).set_BackgroundImageLayout((ImageLayout)3);
		((Control)SupplierImage).set_Location(new Point(798, 31));
		((Control)SupplierImage).set_Name("SupplierImage");
		((Control)SupplierImage).set_Size(new Size(271, 196));
		SupplierImage.set_SizeMode((PictureBoxSizeMode)4);
		SupplierImage.set_TabIndex(29);
		SupplierImage.set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.White);
		((Form)this).set_ClientSize(new Size(1081, 626));
		((Control)this).get_Controls().Add((Control)chkbxDetectFace);
		((Control)this).get_Controls().Add((Control)btnCapture);
		((Control)this).get_Controls().Add((Control)(object)Label6);
		((Control)this).get_Controls().Add((Control)txtPrice);
		((Control)this).get_Controls().Add((Control)(object)Label5);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)(object)Panel2);
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Control)this).get_Controls().Add((Control)(object)lblmess2);
		((Control)this).get_Controls().Add((Control)(object)SupplierImage);
		((Control)this).get_Controls().Add((Control)txtProductName);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)txtSupplierPhoneNo);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)txtAddress);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)txtSupplierName);
		((Control)this).get_Controls().Add((Control)(object)lblname);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("AddSupplier");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("AddSupplier");
		((Control)Panel1).ResumeLayout(false);
		((ISupportInitialize)chkbxDetectFace).EndInit();
		((ISupportInitialize)btnCapture).EndInit();
		((ISupportInitialize)SupplierImage).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Zt90Hy(object sender, EventArgs e)
	{
		//IL_0a8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a91: Invalid comparison between Unknown and I4
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(txtSupplierName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			((Control)lblmess2).Show();
			lblmess2.set_Text("Please Enter Supplier Name");
			Timer1.Start();
			return;
		}
		if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(txtSupplierPhoneNo, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectLess(NewLateBinding.LateGet(NewLateBinding.LateGet(txtSupplierPhoneNo, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)10, false))))
		{
			((Control)lblmess2).Show();
			lblmess2.set_Text("Please Enter Supplier Phone No");
			Timer1.Start();
			return;
		}
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(txtAddress, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			((Control)lblmess2).Show();
			lblmess2.set_Text("Please Enter Supplier Personal Address");
			Timer1.Start();
			return;
		}
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(txtProductName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			((Control)lblmess2).Show();
			lblmess2.set_Text("Please Enter Product Name");
			Timer1.Start();
			return;
		}
		if (isimageisgetfromcamera)
		{
			str = cameraimagepath;
			try
			{
				NewLateBinding.LateCall(Rf7.cn, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			try
			{
				Rf7.p7N();
				object rs = Rf7.rs;
				object[] obj = new object[2]
				{
					Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"INSERT INTO supplierdata values('", NewLateBinding.LateGet(txtSupplierName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(txtAddress, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(txtSupplierPhoneNo, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(txtProductName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), (object)str.ToString()), (object)"','"), NewLateBinding.LateGet(txtPrice, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"')"),
					Rf7.cn
				};
				object obj2 = obj;
				bool[] obj3 = new bool[2] { false, true };
				object obj4 = obj3;
				NewLateBinding.LateCall(rs, (Type)null, "Open", obj, (string[])null, (Type[])null, obj3, true);
				if (((bool[])obj4)[1])
				{
					Rf7.cn = RuntimeHelpers.GetObjectValue(((object[])obj2)[1]);
				}
				IConvertible convertible = Application.get_StartupPath() + "\\AdminUserCreateImages\\";
				if (!((ServerComputer)Wt9q7H.Computer).get_FileSystem().DirectoryExists((string)convertible))
				{
					((ServerComputer)Wt9q7H.Computer).get_FileSystem().CreateDirectory((string)convertible);
				}
				object obj5 = default(object);
				NewLateBinding.LateCall(obj5, (Type)null, "Start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				object obj6 = new Random();
				int num = (obj6 as Random).Next(0, 100000);
				IComparable comparable = Application.get_StartupPath() + "\\AdminUserCreateImages\\" + NewLateBinding.LateGet(txtSupplierName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null).ToString() + Conversions.ToString(num) + ".jpeg";
				int num2 = 0;
				while (num2 < 10)
				{
					try
					{
						yg2_0.pictureBox_0.get_Image().Save((string)comparable, ImageFormat.get_Jpeg());
						num2 = 10;
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
				}
				NewLateBinding.LateCall(obj5, (Type)null, "Stop", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateSetComplex(txtProductName, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(txtAddress, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(txtSupplierName, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(txtSupplierPhoneNo, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null, false, true);
				SupplierImage.set_Image((Image)null);
				NewLateBinding.LateSetComplex(txtPrice, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null, false, true);
				((Control)Wt9q7H.Forms.DashboardAdmin).Show();
				((Control)this).Hide();
				isimageisgetfromcamera = false;
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				((Control)lblmess2).Show();
				lblmess2.set_Text("The Supplier is already present Please select another username");
				Timer1.Start();
				ProjectData.ClearProjectError();
			}
			NewLateBinding.LateCall(UserInfo, (Type)null, "reload_user", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateCall(Rf7.cn, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			return;
		}
		IComparable safeFileName = OpenFileDialog1.get_SafeFileName();
		IComparable<string> fileName = ((FileDialog)OpenFileDialog1).get_FileName();
		IEquatable<string> equatable = Application.get_StartupPath() + "\\supplier\\";
		if (!((ServerComputer)Wt9q7H.Computer).get_FileSystem().DirectoryExists(equatable as string))
		{
			((ServerComputer)Wt9q7H.Computer).get_FileSystem().CreateDirectory((string)equatable);
		}
		IEnumerable enumerable = ((string)equatable).ToString() + ((string)safeFileName).ToString();
		yg2_0.string_0 = enumerable as string;
		FileSystemInfo fileSystemInfo = new FileInfo(fileName as string);
		try
		{
			((FileInfo)fileSystemInfo).CopyTo((equatable as string) + (safeFileName as string), overwrite: false);
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			object obj7 = new Random();
			int num3 = (obj7 as Random).Next(0, 10000);
			((FileInfo)fileSystemInfo).CopyTo((equatable as string) + (safeFileName as string) + Conversions.ToString(num3) + ".jpg", overwrite: true);
			IConvertible convertible2 = (string)equatable + (string)safeFileName + Conversions.ToString(num3) + ".jpg";
			yg2_0.string_0 = convertible2 as string;
			ProjectData.ClearProjectError();
		}
		try
		{
			Rf7.cnn.Close();
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
		try
		{
			NewLateBinding.LateCall(Rf7.cn, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
		}
		try
		{
			Rf7.p7N();
			object rs2 = Rf7.rs;
			object[] obj8 = new object[2]
			{
				Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"INSERT INTO supplierdata values('", NewLateBinding.LateGet(txtSupplierName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(txtAddress, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(txtSupplierPhoneNo, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(txtProductName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), (object)yg2_0.string_0.ToString()), (object)"','"), NewLateBinding.LateGet(txtPrice, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"')"),
				Rf7.cn
			};
			object obj2 = obj8;
			bool[] obj9 = new bool[2] { false, true };
			object obj4 = obj9;
			NewLateBinding.LateCall(rs2, (Type)null, "Open", obj8, (string[])null, (Type[])null, obj9, true);
			if ((obj4 as bool[])[1])
			{
				Rf7.cn = RuntimeHelpers.GetObjectValue((obj2 as object[])[1]);
			}
			object obj10 = Application.get_StartupPath() + "\\AdminUserCreateImages\\";
			if (!((ServerComputer)Wt9q7H.Computer).get_FileSystem().DirectoryExists(obj10 as string))
			{
				((ServerComputer)Wt9q7H.Computer).get_FileSystem().CreateDirectory((string)obj10);
			}
			object obj11 = default(object);
			NewLateBinding.LateCall(obj11, (Type)null, "Start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			object obj12 = new Random();
			int num4 = ((Random)obj12).Next(0, 100000);
			object obj13 = Application.get_StartupPath() + "\\AdminUserCreateImages\\" + NewLateBinding.LateGet(txtSupplierName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null).ToString() + Conversions.ToString(num4) + ".jpeg";
			int num5 = 0;
			while (num5 < 10)
			{
				try
				{
					yg2_0.pictureBox_0.get_Image().Save((string)obj13, ImageFormat.get_Jpeg());
					num5 = 10;
				}
				catch (Exception projectError7)
				{
					ProjectData.SetProjectError(projectError7);
					ProjectData.ClearProjectError();
				}
			}
			NewLateBinding.LateCall(obj11, (Type)null, "Stop", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateSetComplex(txtProductName, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(txtAddress, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(txtSupplierName, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(txtSupplierPhoneNo, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null, false, true);
			((Control)SupplierImage).set_BackgroundImage((Image)null);
			NewLateBinding.LateSetComplex(txtPrice, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateCall(Rf7.cn, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		catch (Exception projectError8)
		{
			ProjectData.SetProjectError(projectError8);
			((Control)lblmess2).Show();
			lblmess2.set_Text("The Supplier is already present Please select another username");
			Timer1.Start();
			ProjectData.ClearProjectError();
		}
		if ((int)MessageBox.Show("Would you like to add anather supplier?", "Add Supplier", (MessageBoxButtons)4) == 6)
		{
			NewLateBinding.LateCall(txtSupplierName, (Type)null, "Focus", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			return;
		}
		((Control)Wt9q7H.Forms.DashboardAdmin).Show();
		((Control)this).Hide();
	}

	private void j6CYg9(object i2PNd4, object Wc6r8B)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		yg2_0.pictureBox_0.set_Image((Image)(Bitmap)NewLateBinding.LateGet(NewLateBinding.LateGet(Wc6r8B, (Type)null, "Frame", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Clone", new object[0], (string[])null, (Type[])null, (bool[])null));
	}

	private void Qz7p4F(object sender, EventArgs e)
	{
		((Control)Wt9q7H.Forms.getSupplierImages).Show();
	}

	private void d4N7Eq(object sender, KeyPressEventArgs e)
	{
		if (Strings.Asc(e.get_KeyChar()) != 8 && Strings.Asc(e.get_KeyChar()) != 32 && ((Strings.Asc(e.get_KeyChar()) < 65) | (Strings.Asc(e.get_KeyChar()) > 90)) && ((Strings.Asc(e.get_KeyChar()) < 97) | (Strings.Asc(e.get_KeyChar()) > 122)))
		{
			e.set_Handled(true);
		}
	}

	private void x6DBj0(object sender, KeyPressEventArgs e)
	{
		if (Strings.Asc(e.get_KeyChar()) != 8 && ((Strings.Asc(e.get_KeyChar()) < 48) | (Strings.Asc(e.get_KeyChar()) > 57)))
		{
			e.set_Handled(true);
		}
		if (Operators.ConditionalCompareObjectGreaterEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(txtSupplierPhoneNo, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)10, false) && Strings.Asc(e.get_KeyChar()) != 8)
		{
			e.set_Handled(true);
		}
	}

	private void Xd4m5D(object sender, KeyPressEventArgs e)
	{
		if (Strings.Asc(e.get_KeyChar()) != 8 && Strings.Asc(e.get_KeyChar()) != 32 && ((Strings.Asc(e.get_KeyChar()) < 65) | (Strings.Asc(e.get_KeyChar()) > 90)) && ((Strings.Asc(e.get_KeyChar()) < 97) | (Strings.Asc(e.get_KeyChar()) > 122)))
		{
			e.set_Handled(true);
		}
	}

	private void Zc87Rq(object sender, EventArgs e)
	{
		((Control)lblmess2).Hide();
	}

	private void Fk72Zq(object sender, EventArgs e)
	{
		NewLateBinding.LateSetComplex(txtProductName, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtAddress, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtSupplierName, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtSupplierPhoneNo, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null, false, true);
		((Control)SupplierImage).set_BackgroundImage((Image)null);
		NewLateBinding.LateSetComplex(txtPrice, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null, false, true);
		((Control)this).Hide();
		((Control)Wt9q7H.Forms.DashboardAdmin).Show();
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

	private void Wi1g8F(object sender, EventArgs e)
	{
		((Control)lblmess2).Hide();
	}

	private void Hi70Qg(object sender, KeyPressEventArgs e)
	{
		if (Strings.Asc(e.get_KeyChar()) != 8 && ((Strings.Asc(e.get_KeyChar()) < 48) | (Strings.Asc(e.get_KeyChar()) > 57)))
		{
			e.set_Handled(true);
		}
	}

	private void Sj2r6Y(object sender, EventArgs e)
	{
		try
		{
			NewLateBinding.LateCall(camera, (Type)null, "Stop", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		SupplierImage.set_Image(SupplierImage.get_Image());
		IEnumerable enumerable = Application.get_StartupPath() + "\\supplier\\";
		if (!((ServerComputer)Wt9q7H.Computer).get_FileSystem().DirectoryExists((string)enumerable))
		{
			((ServerComputer)Wt9q7H.Computer).get_FileSystem().CreateDirectory((string)enumerable);
		}
		object obj = new Random();
		int num = ((Random)obj).Next(0, 100000);
		ICloneable cloneable = Application.get_StartupPath() + "\\supplier\\" + NewLateBinding.LateGet(txtSupplierName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null).ToString() + Conversions.ToString(num) + ".jpeg";
		SupplierImage.get_Image().Save((string)cloneable, ImageFormat.get_Jpeg());
		isimageisgetfromcamera = true;
		cameraimagepath = (string)cloneable;
		Timer2.Stop();
	}

	private void Tk0y4X(object z7SWe1, object Cj41Kt)
	{
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(chkbxDetectFace, (Type)null, "Checked", new object[0], (string[])null, (Type[])null, (bool[])null), (object)true, false))
		{
			Timer2.Start();
			NewLateBinding.LateSetComplex(btnCapture, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null, false, true);
		}
		else
		{
			Timer2.Stop();
			((Component)(object)Timer2).Dispose();
			NewLateBinding.LateSetComplex(btnCapture, (Type)null, "Visible", new object[1] { true }, (string[])null, (Type[])null, false, true);
		}
	}

	private void Ca7w3D(object sender, EventArgs e)
	{
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected O, but got Unknown
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			RuntimeHelpers.GetObjectValue(new object());
			object obj = default(object);
			NewLateBinding.LateSet(obj, (Type)null, "SearchMode", new object[1] { NewLateBinding.LateGet(ObjectDetectorSearchMode, (Type)null, "Average", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(obj, (Type)null, "ScalingFactor", new object[1] { 1.5 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(obj, (Type)null, "ScalingMode", new object[1] { NewLateBinding.LateGet(ObjectDetectorScalingMode, (Type)null, "GreaterToSmaller", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(obj, (Type)null, "UseParallelProcessing", new object[1] { true }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(obj, (Type)null, "Suppression", new object[1] { 3 }, (string[])null, (Type[])null);
			new PictureBox();
			try
			{
				Control supplierImage;
				object[] obj2 = new object[1] { ((PictureBox)(supplierImage = (Control)(object)SupplierImage)).get_Image() };
				object obj3 = obj2;
				bool[] obj4 = new bool[1] { true };
				object obj5 = obj4;
				object obj6 = NewLateBinding.LateGet(obj, (Type)null, "ProcessFrame", obj2, (string[])null, (Type[])null, obj4);
				if (((bool[])obj5)[0])
				{
					((PictureBox)((supplierImage is PictureBox) ? supplierImage : null)).set_Image((Image)Conversions.ChangeType(RuntimeHelpers.GetObjectValue((obj3 as object[])[0]), typeof(Image)));
				}
				Array array = (Rectangle[])obj6;
				IDeviceContext val = (IDeviceContext)(object)Graphics.FromImage(SupplierImage.get_Image());
				object obj7 = array as Rectangle[];
				for (int i = 0; i < (obj7 as Rectangle[]).Length; i = checked(i + 1))
				{
					Rectangle rectangle = (obj7 as Rectangle[])[i];
					((Graphics)val).DrawRectangle(Pens.get_White(), rectangle);
					if ((array as Rectangle[]).Count() > 0)
					{
						SupplierImage.set_Image(SupplierImage.get_Image());
						NewLateBinding.LateCall(btnCapture, (Type)null, "PerformClick", new object[0], (string[])null, (Type[])null, (bool[])null, true);
						Timer2.Stop();
						NewLateBinding.LateCall(camera, (Type)null, "Stop", new object[0], (string[])null, (Type[])null, (bool[])null, true);
						NewLateBinding.LateCall(btnCapture, (Type)null, "PerformClick", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					}
				}
				((Graphics)val).Dispose();
				((Control)SupplierImage).Invalidate();
			}
			catch (AccessViolationException projectError)
			{
				ProjectData.SetProjectError((Exception)projectError);
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	internal void Yr6o0H()
	{
		SupplierImage.set_Image((Image)null);
		RuntimeHelpers.GetObjectValue(new object());
		NewLateBinding.LateCall(camera, (Type)null, "Start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void Ed9w2X(object Sz29Kr, object y3THd5)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		SupplierImage.set_Image((Image)(Bitmap)NewLateBinding.LateGet(NewLateBinding.LateGet(y3THd5, (Type)null, "Frame", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Clone", new object[0], (string[])null, (Type[])null, (bool[])null));
	}

	internal static void Lm2s0X(Ez0.n4D w5Q3Jf, int n1NPr5, string Nc75Jg, bool Nd7a5S)
	{
		if (n1NPr5 <= 0)
		{
			return;
		}
		checked
		{
			n1NPr5 *= 5;
			if (Nc75Jg == null)
			{
				return;
			}
			Nc75Jg = Nc75Jg.Remove(0, 3);
			if (Nd7a5S)
			{
				return;
			}
			Nd7a5S = true;
			Array names = w5Q3Jf.Names;
			object obj = (object[])names;
			object enumerator = default(object);
			for (int i = 0; i < ((object[])obj).Length; i++)
			{
				object objectValue = RuntimeHelpers.GetObjectValue((obj as object[])[i]);
				try
				{
					Math.Abs(170496);
					object obj2 = objectValue;
					object obj3;
					object[] obj4 = new object[2]
					{
						((Ez0.n4D)(obj3 = w5Q3Jf)).Res,
						""
					};
					Array array = obj4;
					bool[] obj5 = new bool[2] { true, false };
					Array array2 = obj5;
					object obj6 = NewLateBinding.LateGet(obj2, (Type)null, "Replace", obj4, (string[])null, (Type[])null, obj5);
					if ((array2 as bool[])[0])
					{
						(obj3 as Ez0.n4D).Res = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(((object[])array)[0]), typeof(string));
					}
					objectValue = RuntimeHelpers.GetObjectValue(obj6);
					object obj7 = new ResourceManager(Conversions.ToString(objectValue), w5Q3Jf.Ass);
					object resourceSet = ((ResourceManager)obj7).GetResourceSet(CultureInfo.CurrentCulture, createIfNotExists: true, tryParents: true);
					object obj8 = ((ResourceSet)resourceSet).OfType<object>();
					try
					{
						enumerator = ((IEnumerable<object>)obj8).GetEnumerator();
						while ((enumerator as IEnumerator<object>).MoveNext())
						{
							object objectValue2 = RuntimeHelpers.GetObjectValue((enumerator as IEnumerator<object>).Current);
							if (Operators.CompareString(NewLateBinding.LateGet(objectValue2, (Type)null, "Key", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), w5Q3Jf.ResName, false) == 0)
							{
								w5Q3Jf.Data = (byte[])NewLateBinding.LateGet(objectValue2, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null);
							}
						}
					}
					finally
					{
						if ((IEnumerator<object>)enumerator != null)
						{
							(enumerator as IEnumerator<object>).Dispose();
						}
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			Sy50Xx.Jt2p9R(w5Q3Jf, 199);
		}
	}

	internal static object a2PLk6(object Kx78Aq)
	{
		return new byte[checked(Conversions.ToInteger(Kx78Aq) + 1)];
	}

	static void Ra52Zc()
	{
		//IL_00ad: Expected O, but got I4
		//IL_0117: Expected O, but got I4
		//IL_0147: Expected O, but got I4
		//IL_03e1: Expected O, but got I4
		//IL_0414: Expected O, but got I4
		//IL_0435: Expected O, but got I4
		//IL_050d: Expected O, but got I4
		//IL_0655: Expected O, but got I4
		//IL_06a7: Expected O, but got I4
		//IL_06ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0765: Expected O, but got I4
		//IL_080c: Expected O, but got I4
		//IL_0a15: Expected O, but got I4
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a8C a8C);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y0D y0D);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sy0 sy);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out i1D i1D);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Xn05Ce xn05Ce);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Se60Di se60Di);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		checked
		{
			try
			{
				try
				{
					xn05Ce = (Xn05Ce)xn05Ce.ObjectDetectorScalingMode;
					_ = (s7K2Ek)xn05Ce.ObjectDetectorScalingMode;
				}
				catch
				{
					_ = (s7K2Ek)xn05Ce.ObjectDetectorSearchMode;
					se60Di = se60Di;
					se60Di = se60Di;
					Rf7 obj = (Rf7)((s7K2Ek)null).ObjectDetectorSearchMode;
					Rf7 rf = rf;
					rf = obj;
				}
				finally
				{
					num = default(UIntPtr);
					nuint num2 = num;
					a8C = a8C;
					nuint num3 = num2 + unchecked((nuint)(UIntPtr)a8C.PayTMPay);
					num = default(UIntPtr);
					num = num3 + num;
					if (num == 0)
					{
						y0D = null;
						_ = y0D.Width is x6LFp1;
					}
					goto end_IL_0000;
				}
				end_IL_0000:;
			}
			catch
			{
				_ = (Ag9)((a8C)((Xn05Ce)null).ObjectDetectorSearchMode).PayTMPay;
			}
			do
			{
				IL_0127:
				obj4 = obj4;
				if (obj4 != null)
				{
					try
					{
						sy = (Sy0)((a8C)null).PayTMPay;
						_ = (Mt2)sy.SupplierDailyRecord;
					}
					finally
					{
						i1D = null;
						_ = (e2.y6)i1D.PrintMonthlyRecords;
						goto IL_0127;
					}
				}
			}
			while ((((y0D)((i1D)null).PrintMonthlyRecords).Width as Mr7n6D).UserInfo != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Yg89Py yg89Py);
		if (num == 0 && (UIntPtr)(y0D.Width as Mr7n6D).UserInfo == (UIntPtr)(nuint)0u)
		{
			Yg89Py obj5 = (Yg89Py)((s7K2Ek)null).ObjectDetectorSearchMode;
			yg89Py = null;
			yg89Py = obj5;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s7K2Ek s7K2Ek);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out b4 b);
		try
		{
			UIntPtr num4 = (UIntPtr)((Mr7n6D)null).UserInfo;
			num = default(UIntPtr);
			checked
			{
				if (unchecked((nuint)num4) - num == 0)
				{
					Wt9q7H obj6 = (Wt9q7H)i1D.PrintMonthlyRecords;
					Wt9q7H wt9q7H = wt9q7H;
					wt9q7H = obj6;
				}
			}
		}
		finally
		{
			try
			{
				while (true)
				{
					s7K2Ek = s7K2Ek;
					if (s7K2Ek.ObjectDetectorSearchMode != null)
					{
						_ = (Ez0)(object)((Yg89Py)((s7K2Ek)((i1D)i1D.PrintMonthlyRecords).PrintMonthlyRecords).ObjectDetectorSearchMode).DBForFoodManagementConnectionString;
						continue;
					}
					break;
				}
			}
			catch
			{
				xn05Ce = xn05Ce;
				b = b;
				b = b;
			}
			goto IL_020c;
		}
		IL_020c:
		try
		{
			_ = (e2.y6)((Ag9)((s7K2Ek)null).ObjectDetectorSearchMode).UserInfo;
		}
		finally
		{
			do
			{
				if ((UIntPtr)xn05Ce.ObjectDetectorScalingMode == (UIntPtr)(nuint)0u)
				{
					a8C = a8C;
				}
			}
			while (obj4 != null);
			goto IL_024e;
		}
		IL_08c9:
		while (obj4 != null)
		{
			sy = (Sy0)(object)((Yg89Py)null).Fast_food_managementConnectionString;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f1P6Lz f1P6Lz);
		_ = (Ez0)f1P6Lz.SuppliedRecord;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f3L6Rd f3L6Rd);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ez0 ez);
		Ag9 ag;
		try
		{
			if ((UIntPtr)f3L6Rd.PrintDailyRecords == (UIntPtr)(nuint)0u)
			{
				while (obj4 != null)
				{
					ez = ez;
				}
			}
			else
			{
				_ = (f1P6Lz)((Ag9)null).UserInfo;
			}
		}
		catch
		{
			checked
			{
				if (unchecked((nuint)(UIntPtr)((f1P6Lz)null).SuppliedRecord) - (unchecked((nuint)(UIntPtr)xn05Ce.UserInfo) - num) == 0)
				{
					while (((a8C)null).PayTMPay != null)
					{
						_ = (_003CModule_003E)ag.UserInfo;
					}
				}
				else if (num * unchecked((nuint)(UIntPtr)((f1P6Lz)f1P6Lz.SuppliedRecord).SupplierDailyRecord) == 0)
				{
					sy = (Sy0)(object)((Yg89Py)null).Fast_food_managementConnectionString;
				}
				else
				{
					f1P6Lz = f1P6Lz;
				}
			}
		}
		Mr7n6D mr7n6D;
		if ((UIntPtr)s7K2Ek.ObjectDetectorSearchMode == (UIntPtr)(nuint)0u)
		{
			_ = (i7Z8Et)mr7n6D.ObjectDetectorSearchMode;
			goto IL_09f9;
		}
		try
		{
			if ((UIntPtr)((Mr7n6D)null).ObjectDetectorSearchMode == (UIntPtr)(nuint)0u)
			{
				_ = (Mr7n6D)a8C.PayTMPay;
			}
			else
			{
				_ = (Ty5k0C)s7K2Ek.ObjectDetectorSearchMode;
				f1P6Lz = null;
			}
		}
		finally
		{
			_ = (Ag9)((f3L6Rd)xn05Ce.ObjectDetectorSearchMode).PrintDailyRecords;
			goto IL_09f9;
		}
		IL_024e:
		nuint num5 = num;
		ag = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out m8K m8K);
		checked
		{
			if (num5 * unchecked((nuint)(UIntPtr)ag.UserInfo) == 0)
			{
				num = default(UIntPtr);
				if (num != 0)
				{
					try
					{
						y0D = y0D;
					}
					catch
					{
						_ = (Sy50Xx)((s7K2Ek)xn05Ce.UserInfo).ObjectDetectorScalingMode;
					}
				}
			}
			try
			{
				se60Di = se60Di;
			}
			catch
			{
			}
			while (obj4 != null)
			{
				while (i1D.PrintMonthlyRecords != null)
				{
					m8K = null;
					m8K = null;
				}
			}
			do
			{
				if (num * unchecked((nuint)(UIntPtr)((a8C)ag.UserInfo).PayTMPay) != 0)
				{
					while (obj4 != null)
					{
						f1P6Lz = (f1P6Lz)((Sy0)((Mr7n6D)s7K2Ek.ObjectDetectorScalingMode).ObjectDetectorScalingMode).SupplierInfo;
						ez = (Ez0)f1P6Lz.Send_sms_to_customer;
						ez = ez;
					}
				}
				else
				{
					_ = (Yg89Py)i1D.PrintMonthlyRecords;
					_ = (e2.y6)a8C.PayTMPay;
				}
			}
			while (sy.SuppliedRecord != null);
			try
			{
				_ = (f1P6Lz)s7K2Ek.ObjectDetectorSearchMode;
			}
			catch
			{
				_ = (s4C8Py)xn05Ce.ObjectDetectorScalingMode;
			}
			finally
			{
				_ = (Mm0)a8C.PayTMPay;
				_ = (Mm0)i1D.PrintMonthlyRecords;
				mr7n6D = (Mr7n6D)((Sy0)((s7K2Ek)null).ObjectDetectorScalingMode).UserInfo;
				_ = (Rf7)mr7n6D.ObjectDetectorSearchMode;
				goto IL_03d6;
			}
		}
		IL_0815:
		try
		{
			while (s7K2Ek.ObjectDetectorSearchMode != null)
			{
			}
		}
		catch
		{
			while (obj4 != null)
			{
				_ = (s9.y6)mr7n6D.SelectImageGetFrom;
			}
		}
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ty5k0C ty5k0C);
		if (num == 0)
		{
			try
			{
				_ = (Yg89Py)f3L6Rd.PrintDailyRecords;
			}
			catch
			{
				ty5k0C = (Ty5k0C)xn05Ce.ObjectDetectorSearchMode;
			}
			finally
			{
				_ = (Xn05Ce)xn05Ce.ObjectDetectorScalingMode;
				goto IL_08c9;
			}
		}
		try
		{
		}
		finally
		{
			_ = (Hf08Tc)((f1P6Lz)((Sy0)null).SupplierInfo).Send_sms_to_customer;
			_ = (Wt9q7H)a8C.PayTMPay;
			goto IL_08c9;
		}
		IL_09f9:
		if (num == 0)
		{
			do
			{
				_ = (Ty5k0C)sy.SupplierInfo;
				Wt9q7H wt9q7H = ((y0D)null).Width as Wt9q7H;
			}
			while (((s7K2Ek)null).ObjectDetectorSearchMode != null);
		}
		_ = (s4C8Py)((Ag9)null).UserInfo;
		Mm0 mm = (Mm0)((a8C)null).PayTMPay;
		_ = (i1D)(object)yg89Py.DBForFoodManagementConnectionString;
		return;
		IL_03d6:
		try
		{
			_ = y0D.Width is i7Z8Et;
		}
		catch
		{
			mm = mm;
			mm = null;
		}
		while (obj4 != null)
		{
			try
			{
				_ = ((y0D)((f3L6Rd)((s7K2Ek)null).ObjectDetectorScalingMode).PrintDailyRecords).Width is i1D;
			}
			finally
			{
				try
				{
					_ = (a8C)f1P6Lz.SupplierDailyRecord;
				}
				catch
				{
					_ = ((y0D)null).Width is f1P6Lz;
				}
				continue;
			}
		}
		try
		{
		}
		catch
		{
			try
			{
				_ = (z3T)f1P6Lz.SupplierDailyRecord;
			}
			catch
			{
				e2.y6 y = y;
				y = default(e2.y6);
			}
		}
		xn05Ce = (Xn05Ce)xn05Ce.ObjectDetectorSearchMode;
		try
		{
			_ = (x6LFp1)((a8C)f1P6Lz.SuppliedRecord).PayTMPay;
			f3L6Rd = null;
			f3L6Rd = f3L6Rd;
			_ = (Ag9)((Mr7n6D)((f1P6Lz)(object)Yg89Py.Default).SupplierDailyRecord).UserInfo;
		}
		catch
		{
			if ((UIntPtr)yg89Py.Fast_food_managementConnectionString == (UIntPtr)(nuint)0u)
			{
				m8K = m8K;
				_ = (Yg89Py)((Mr7n6D)sy.SupplierInfo).SelectImageGetFrom;
				_ = y0D.Width is s7K2Ek;
			}
			else
			{
				while (obj4 != null)
				{
					_ = (Sy50Xx)((f1P6Lz)null).Send_sms_to_customer;
				}
			}
		}
		f1P6Lz = (f1P6Lz)((Mr7n6D)null).ObjectDetectorScalingMode;
		if ((UIntPtr)a8C.PayTMPay == (UIntPtr)(nuint)0u)
		{
			while (mr7n6D.UserInfo != null)
			{
				ty5k0C = ty5k0C;
				ty5k0C = null;
			}
		}
		ez = ez;
		if ((UIntPtr)((f1P6Lz)(object)yg89Py.DBForFoodManagementConnectionString).Send_sms_to_customer == (UIntPtr)(nuint)0u)
		{
			Mt2 mt = (Mt2)s7K2Ek.ObjectDetectorSearchMode;
			mt = mt;
			s7K2Ek = null;
		}
		else
		{
			try
			{
				_ = (b4)sy.SupplierDailyRecord;
			}
			catch
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					b = b;
				}
				else
				{
					_ = (x6LFp1)((Ag9)(object)yg89Py.Fast_food_managementConnectionString).UserInfo;
				}
			}
		}
		if ((UIntPtr)((Ag9)i1D.PrintMonthlyRecords).UserInfo == (UIntPtr)(nuint)0u)
		{
			while ((object)Yg89Py.Default != null)
			{
				try
				{
					_ = (f1P6Lz)((Xn05Ce)null).ObjectDetectorScalingMode;
				}
				catch
				{
					y0D = null;
				}
			}
		}
		else
		{
			do
			{
				if ((UIntPtr)ag.UserInfo != (UIntPtr)(nuint)0u)
				{
					_ = (Ez0)f3L6Rd.PrintDailyRecords;
					continue;
				}
				_ = y0D.Width is s7K2Ek;
				_ = (Sy50Xx)sy.SupplierInfo;
				se60Di = null;
			}
			while (obj4 != null);
		}
		if ((UIntPtr)xn05Ce.ObjectDetectorScalingMode == (UIntPtr)(nuint)0u)
		{
			try
			{
				num = default(UIntPtr);
				nuint num6 = num;
				object obj21 = ((y0D)null).Width;
				if ((int)(num6 / ((obj21 is UIntPtr) ? obj21 : null)) == 0)
				{
					_ = (z3T)((Xn05Ce)null).ObjectDetectorSearchMode;
				}
				else
				{
					_ = (Hf08Tc)((a8C)((Xn05Ce)sy.SuppliedRecord).UserInfo).PayTMPay;
				}
			}
			catch
			{
				do
				{
					ty5k0C = ty5k0C;
				}
				while (obj4 != null);
			}
		}
		Bs bs = bs;
		bs = null;
		nuint num7 = num;
		num = default(UIntPtr);
		if (num7 / num == 0)
		{
			nuint num8 = num;
			nuint num9 = num;
			num = default(UIntPtr);
			if (checked(num8 * (num9 - num)) == 0)
			{
				if ((UIntPtr)s7K2Ek.ObjectDetectorScalingMode == (UIntPtr)(nuint)0u)
				{
					_ = (x6LFp1)((a8C)null).PayTMPay;
				}
				else
				{
					_ = (f1P6Lz)((Mr7n6D)null).ObjectDetectorSearchMode;
				}
			}
		}
		else
		{
			try
			{
				a8C = y0D.Width as a8C;
			}
			catch
			{
				mm = mm;
				b = b;
				ag = ag;
			}
		}
		do
		{
			ag = (Ag9)((f3L6Rd)null).PrintDailyRecords;
		}
		while (obj4 != null);
		_ = (m8K)((i1D)null).PrintMonthlyRecords;
		while (obj4 != null)
		{
			try
			{
				if (checked(num * num) == 0)
				{
					_ = (s4C8Py)((a8C)null).PayTMPay;
				}
			}
			catch
			{
				while (obj4 != null)
				{
					_ = (Mr7n6D)((Ag9)null).UserInfo;
				}
			}
		}
		try
		{
			_ = ((y0D)((Xn05Ce)((Sy0)sy.SuppliedRecord).SupplierInfo).ObjectDetectorScalingMode).Width is y0D;
		}
		finally
		{
			goto IL_0815;
		}
	}
}
