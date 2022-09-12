using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
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
using Kj87Xi;
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
using x6T;

namespace w0XGc7;

[DesignerGenerated]
public class Mr7n6D : Form
{
	private IContainer components;

	[AccessedThroughProperty("lblname")]
	private Label _lblname;

	[AccessedThroughProperty("lblmess")]
	private Label _lblmess;

	[AccessedThroughProperty("txtname")]
	private object _txtname;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("selectuserimage")]
	private OpenFileDialog _selectuserimage;

	[AccessedThroughProperty("txtusername")]
	private object _txtusername;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("lblmess2")]
	private Label _lblmess2;

	[AccessedThroughProperty("chkbxDetectFace")]
	private object _chkbxDetectFace;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	private PictureBox picAdmin;

	public bool isimageisgetfromcamera;

	public string str;

	public bool em;

	internal object camera;

	public PictureBox picfor;

	private object _ObjectDetectorSearchMode;

	private object _UserInfo;

	private x6LFp1.Ec5k7X ec5k7X_0 = new x6LFp1.Ec5k7X();

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
			return ec5k7X_0.timer_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Expected O, but got Unknown
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			object obj = new EventHandler(Gr0w3C);
			Component timer_ = (Component)(object)ec5k7X_0.timer_0;
			if (timer_ is Timer)
			{
				((Timer)timer_).remove_Tick((EventHandler)obj);
			}
			ec5k7X_0.timer_0 = value;
			timer_ = (Component)(object)ec5k7X_0.timer_0;
			if ((int)(Timer)timer_ != 0)
			{
				((Timer)((timer_ is Timer) ? timer_ : null)).add_Tick(obj as EventHandler);
			}
		}
	}

	internal virtual object txtname
	{
		get
		{
			return _txtname;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtname = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual object btnCreateuser
	{
		get
		{
			return ec5k7X_0.object_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			ec5k7X_0.object_0 = objectValue;
		}
	}

	internal virtual object btnexit
	{
		get
		{
			return ec5k7X_0.object_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			ec5k7X_0.object_1 = objectValue;
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

	internal virtual object txtmobno
	{
		get
		{
			return ec5k7X_0.object_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			ec5k7X_0.object_2 = objectValue;
		}
	}

	internal virtual object txtaddress
	{
		get
		{
			return ec5k7X_0.object_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			ec5k7X_0.object_3 = objectValue;
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

	internal virtual object txtemail
	{
		get
		{
			return ec5k7X_0.object_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			ec5k7X_0.object_4 = objectValue;
		}
	}

	internal virtual PictureBox UserImage
	{
		get
		{
			return ec5k7X_0.pictureBox_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			MulticastDelegate multicastDelegate = new EventHandler(Pg5q0M);
			Control pictureBox_ = (Control)(object)ec5k7X_0.pictureBox_0;
			if ((int)(PictureBox)pictureBox_ != 0)
			{
				((pictureBox_ is PictureBox) ? pictureBox_ : null).remove_Click((EventHandler)multicastDelegate);
			}
			ec5k7X_0.pictureBox_0 = ((value is PictureBox) ? value : null);
			pictureBox_ = (Control)(object)ec5k7X_0.pictureBox_0;
			if (pictureBox_ is PictureBox)
			{
				((pictureBox_ is PictureBox) ? pictureBox_ : null).add_Click(multicastDelegate as EventHandler);
			}
		}
	}

	internal virtual OpenFileDialog selectuserimage
	{
		get
		{
			return _selectuserimage;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_selectuserimage = value;
		}
	}

	internal virtual object txtpass
	{
		get
		{
			return ec5k7X_0.object_5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			ec5k7X_0.object_5 = objectValue;
		}
	}

	internal virtual object txtusername
	{
		get
		{
			return _txtusername;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtusername = RuntimeHelpers.GetObjectValue(value);
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
			return ec5k7X_0.label_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			ec5k7X_0.label_0 = ((value is Label) ? value : null);
		}
	}

	internal virtual MaskedTextBox txtadharno
	{
		get
		{
			return ec5k7X_0.maskedTextBox_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			ec5k7X_0.maskedTextBox_0 = ((value is MaskedTextBox) ? value : null);
		}
	}

	internal virtual Panel Panel2
	{
		get
		{
			return ec5k7X_0.panel_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			ec5k7X_0.panel_0 = ((value is Panel) ? value : null);
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

	internal virtual object txtSalary
	{
		get
		{
			return ec5k7X_0.object_6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			ec5k7X_0.object_6 = objectValue;
		}
	}

	internal virtual Label lblmess2
	{
		get
		{
			return _lblmess2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblmess2 = value;
		}
	}

	internal virtual Label Label8
	{
		get
		{
			return ec5k7X_0.label_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			ec5k7X_0.label_1 = ((value is Label) ? value : null);
		}
	}

	internal virtual object btnCapture
	{
		get
		{
			return ec5k7X_0.object_7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			ec5k7X_0.object_7 = objectValue;
		}
	}

	internal virtual Timer Timer1
	{
		get
		{
			return ec5k7X_0.timer_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Expected O, but got Unknown
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			MulticastDelegate multicastDelegate = new EventHandler(Yg2x7K);
			Component timer_ = (Component)(object)ec5k7X_0.timer_1;
			if ((int)(Timer)timer_ != 0)
			{
				((Timer)timer_).remove_Tick(multicastDelegate as EventHandler);
			}
			ec5k7X_0.timer_1 = value;
			timer_ = (Component)(object)ec5k7X_0.timer_1;
			if (timer_ is Timer)
			{
				((Timer)timer_).add_Tick(multicastDelegate as EventHandler);
			}
		}
	}

	internal virtual object chkbxDetectFace
	{
		get
		{
			return _chkbxDetectFace;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_chkbxDetectFace = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual PictureBox PictureBox1
	{
		get
		{
			return _PictureBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_PictureBox1 = value;
		}
	}

	internal virtual Label lblMes
	{
		get
		{
			return ec5k7X_0.label_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected O, but got Unknown
			ec5k7X_0.label_2 = value;
		}
	}

	internal virtual Button Button1
	{
		get
		{
			return ec5k7X_0.button_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Expected O, but got Unknown
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			MulticastDelegate multicastDelegate = new EventHandler(Co5z6Q);
			ButtonBase button_ = (ButtonBase)(object)ec5k7X_0.button_0;
			if (button_ is Button)
			{
				((Control)((button_ is Button) ? button_ : null)).remove_Click((EventHandler)multicastDelegate);
			}
			ec5k7X_0.button_0 = value;
			button_ = (ButtonBase)(object)ec5k7X_0.button_0;
			if (button_ is Button)
			{
				((Control)(Button)button_).add_Click(multicastDelegate as EventHandler);
			}
		}
	}

	public object ObjectDetectorSearchMode
	{
		get
		{
			return _ObjectDetectorSearchMode;
		}
		set
		{
			_ObjectDetectorSearchMode = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object ObjectDetectorScalingMode
	{
		get
		{
			return ec5k7X_0.object_8;
		}
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			ec5k7X_0.object_8 = objectValue;
		}
	}

	public object SelectImageGetFrom
	{
		get
		{
			return ec5k7X_0.object_9;
		}
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			ec5k7X_0.object_9 = objectValue;
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

	public Mr7n6D()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Gk7r8L);
		picAdmin = new PictureBox();
		ISupportInitialize supportInitialize = (ISupportInitialize)new PictureBox();
		ec5k7X_0.pictureBox_1 = (PictureBox)((supportInitialize is PictureBox) ? supportInitialize : null);
		isimageisgetfromcamera = false;
		IComparable comparable = "";
		ec5k7X_0.string_0 = comparable as string;
		str = "";
		em = false;
		picfor = new PictureBox();
		ISupportInitialize supportInitialize2 = (ISupportInitialize)new PictureBox();
		ec5k7X_0.pictureBox_2 = (PictureBox)((supportInitialize2 is PictureBox) ? supportInitialize2 : null);
		Gf13Tw();
	}

	protected override void f9WBp6(bool Fn5o7A)
	{
		try
		{
			if (Fn5o7A && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Fn5o7A);
		}
	}

	private void Gf13Tw()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
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
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected O, but got Unknown
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Expected O, but got Unknown
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c9: Expected O, but got Unknown
		//IL_0772: Unknown result type (might be due to invalid IL or missing references)
		//IL_0929: Unknown result type (might be due to invalid IL or missing references)
		//IL_092f: Expected O, but got Unknown
		//IL_0a8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a90: Expected O, but got Unknown
		//IL_0c39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df4: Expected O, but got Unknown
		//IL_0e1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e26: Expected O, but got Unknown
		//IL_0e9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea9: Expected O, but got Unknown
		//IL_0f25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f2f: Expected O, but got Unknown
		//IL_1069: Unknown result type (might be due to invalid IL or missing references)
		//IL_106f: Expected O, but got Unknown
		//IL_1111: Unknown result type (might be due to invalid IL or missing references)
		//IL_129f: Unknown result type (might be due to invalid IL or missing references)
		//IL_12a5: Expected O, but got Unknown
		//IL_134a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1417: Unknown result type (might be due to invalid IL or missing references)
		//IL_1421: Expected O, but got Unknown
		//IL_155b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1561: Expected O, but got Unknown
		//IL_1606: Unknown result type (might be due to invalid IL or missing references)
		//IL_1836: Unknown result type (might be due to invalid IL or missing references)
		//IL_183c: Expected O, but got Unknown
		//IL_18e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a75: Expected O, but got Unknown
		//IL_1b1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1be7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bf1: Expected O, but got Unknown
		//IL_1c6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c75: Expected O, but got Unknown
		//IL_1ce0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cea: Expected O, but got Unknown
		//IL_1e02: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e0c: Expected O, but got Unknown
		//IL_1e1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e27: Expected O, but got Unknown
		//IL_1f1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f25: Expected O, but got Unknown
		//IL_2060: Unknown result type (might be due to invalid IL or missing references)
		//IL_2066: Expected O, but got Unknown
		//IL_210b: Unknown result type (might be due to invalid IL or missing references)
		//IL_21d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_21df: Expected O, but got Unknown
		//IL_2266: Unknown result type (might be due to invalid IL or missing references)
		//IL_2270: Expected O, but got Unknown
		//IL_25b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_25c2: Expected O, but got Unknown
		//IL_25ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_25d8: Expected O, but got Unknown
		//IL_2639: Unknown result type (might be due to invalid IL or missing references)
		//IL_2643: Expected O, but got Unknown
		//IL_264f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2659: Expected O, but got Unknown
		//IL_2676: Unknown result type (might be due to invalid IL or missing references)
		//IL_2680: Expected O, but got Unknown
		//IL_26bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_26c9: Expected O, but got Unknown
		//IL_26d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_26df: Expected O, but got Unknown
		//IL_26eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_26f5: Expected O, but got Unknown
		//IL_2701: Unknown result type (might be due to invalid IL or missing references)
		//IL_270b: Expected O, but got Unknown
		components = new Container();
		ResourceManager resourceManager = new ComponentResourceManager(typeof(Mr7n6D));
		lblname = new Label();
		lblmess = new Label();
		tmrerr = new Timer(components);
		Label1 = new Label();
		Label2 = new Label();
		Label3 = new Label();
		UserImage = new PictureBox();
		selectuserimage = new OpenFileDialog();
		Label6 = new Label();
		Label5 = new Label();
		txtadharno = new MaskedTextBox();
		Panel2 = new Panel();
		Panel1 = new Panel();
		Button1 = new Button();
		Label7 = new Label();
		lblmess2 = new Label();
		Label8 = new Label();
		Timer1 = new Timer(components);
		PictureBox1 = new PictureBox();
		lblMes = new Label();
		((ISupportInitialize)UserImage).BeginInit();
		((Control)Panel1).SuspendLayout();
		((ISupportInitialize)btnCapture).BeginInit();
		((ISupportInitialize)chkbxDetectFace).BeginInit();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		lblname.set_AutoSize(true);
		((Control)lblname).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblname).set_Location(new Point(264, 191));
		((Control)lblname).set_Name("lblname");
		((Control)lblname).set_Size(new Size(86, 20));
		((Control)lblname).set_TabIndex(1);
		lblname.set_Text("Full Name*");
		lblmess.set_AutoSize(true);
		((Control)lblmess).set_Location(new Point(1, 0));
		((Control)lblmess).set_Name("lblmess");
		((Control)lblmess).set_Size(new Size(39, 13));
		((Control)lblmess).set_TabIndex(5);
		lblmess.set_Text("Label1");
		tmrerr.set_Interval(2000);
		NewLateBinding.LateSetComplex(txtname, (Type)null, "BorderColorFocused", new object[1] { Color.Red }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtname, (Type)null, "BorderColorIdle", new object[1] { Color.SeaGreen }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtname, (Type)null, "BorderColorMouseHover", new object[1] { Color.Blue }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtname, (Type)null, "BorderThickness", new object[1] { 1 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtname, (Type)null, "Cursor", new object[1] { Cursors.get_IBeam() }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtname, (Type)null, "Font", new object[1] { (object)new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtname, (Type)null, "ForeColor", new object[1] { Color.FromArgb(64, 64, 64) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtname, (Type)null, "isPassword", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtname, (Type)null, "Location", new object[1]
		{
			new Point(413, 181)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtname, (Type)null, "Margin", new object[1] { (object)new Padding(4) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtname, (Type)null, "Name", new object[1] { "txtname" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtname, (Type)null, "Size", new object[1]
		{
			new Size(319, 30)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtname, (Type)null, "TabIndex", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtname, (Type)null, "TextAlign", new object[1] { (object)(HorizontalAlignment)0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCreateuser, (Type)null, "Activecolor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCreateuser, (Type)null, "BackColor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCreateuser, (Type)null, "BackgroundImageLayout", new object[1] { (object)(ImageLayout)3 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCreateuser, (Type)null, "BorderRadius", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCreateuser, (Type)null, "ButtonText", new object[1] { "Create User" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCreateuser, (Type)null, "Cursor", new object[1] { Cursors.get_Hand() }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCreateuser, (Type)null, "DisabledColor", new object[1] { Color.Gray }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCreateuser, (Type)null, "Iconcolor", new object[1] { Color.Transparent }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCreateuser, (Type)null, "Iconimage", new object[1] { (object)(Image)((ComponentResourceManager)resourceManager).GetObject("btnCreateuser.Iconimage") }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCreateuser, (Type)null, "Iconimage_right", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCreateuser, (Type)null, "Iconimage_right_Selected", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCreateuser, (Type)null, "Iconimage_Selected", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCreateuser, (Type)null, "IconMarginLeft", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCreateuser, (Type)null, "IconMarginRight", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCreateuser, (Type)null, "IconRightVisible", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCreateuser, (Type)null, "IconRightZoom", new object[1] { 0.0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCreateuser, (Type)null, "IconVisible", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCreateuser, (Type)null, "IconZoom", new object[1] { 90.0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCreateuser, (Type)null, "IsTab", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCreateuser, (Type)null, "Location", new object[1]
		{
			new Point(4, 216)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCreateuser, (Type)null, "Margin", new object[1] { (object)new Padding(4) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCreateuser, (Type)null, "Name", new object[1] { "btnCreateuser" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCreateuser, (Type)null, "Normalcolor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCreateuser, (Type)null, "OnHovercolor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCreateuser, (Type)null, "OnHoverTextColor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCreateuser, (Type)null, "selected", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCreateuser, (Type)null, "Size", new object[1]
		{
			new Size(196, 48)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCreateuser, (Type)null, "TabIndex", new object[1] { 8 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCreateuser, (Type)null, "Text", new object[1] { "Create User" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCreateuser, (Type)null, "TextAlign", new object[1] { (object)(ContentAlignment)16 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCreateuser, (Type)null, "Textcolor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCreateuser, (Type)null, "TextFont", new object[1] { (object)new Font("Century Gothic", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnexit, (Type)null, "Activecolor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnexit, (Type)null, "BackColor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnexit, (Type)null, "BackgroundImageLayout", new object[1] { (object)(ImageLayout)3 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnexit, (Type)null, "BorderRadius", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnexit, (Type)null, "ButtonText", new object[1] { "Exit" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnexit, (Type)null, "Cursor", new object[1] { Cursors.get_Hand() }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnexit, (Type)null, "DisabledColor", new object[1] { Color.Gray }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnexit, (Type)null, "Iconcolor", new object[1] { Color.Transparent }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnexit, (Type)null, "Iconimage", new object[1] { (object)(Image)(resourceManager as ComponentResourceManager).GetObject("btnexit.Iconimage") }, (string[])null, (Type[])null, false, true);
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
			new Point(4, 273)
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
		NewLateBinding.LateSetComplex(btnexit, (Type)null, "Text", new object[1] { "Exit" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnexit, (Type)null, "TextAlign", new object[1] { (object)(ContentAlignment)16 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnexit, (Type)null, "Textcolor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnexit, (Type)null, "TextFont", new object[1] { (object)new Font("Century Gothic", 15.75f) }, (string[])null, (Type[])null, false, true);
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_Location(new Point(264, 244));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(85, 20));
		((Control)Label1).set_TabIndex(1);
		Label1.set_Text("Mobile No*");
		Label2.set_AutoSize(true);
		((Control)Label2).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_Location(new Point(264, 301));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(129, 20));
		((Control)Label2).set_TabIndex(1);
		Label2.set_Text("Aadhar Card No*");
		Label3.set_AutoSize(true);
		((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_Location(new Point(264, 358));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(74, 20));
		((Control)Label3).set_TabIndex(1);
		Label3.set_Text("Address*");
		NewLateBinding.LateSetComplex(txtmobno, (Type)null, "BorderColorFocused", new object[1] { Color.Red }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtmobno, (Type)null, "BorderColorIdle", new object[1] { Color.SeaGreen }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtmobno, (Type)null, "BorderColorMouseHover", new object[1] { Color.Blue }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtmobno, (Type)null, "BorderThickness", new object[1] { 1 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtmobno, (Type)null, "Cursor", new object[1] { Cursors.get_IBeam() }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtmobno, (Type)null, "Font", new object[1] { (object)new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtmobno, (Type)null, "ForeColor", new object[1] { Color.FromArgb(64, 64, 64) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtmobno, (Type)null, "isPassword", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtmobno, (Type)null, "Location", new object[1]
		{
			new Point(413, 234)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtmobno, (Type)null, "Margin", new object[1] { (object)new Padding(4) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtmobno, (Type)null, "Name", new object[1] { "txtmobno" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtmobno, (Type)null, "Size", new object[1]
		{
			new Size(319, 30)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtmobno, (Type)null, "TabIndex", new object[1] { 1 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtmobno, (Type)null, "TextAlign", new object[1] { (object)(HorizontalAlignment)0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtaddress, (Type)null, "BorderColorFocused", new object[1] { Color.Red }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtaddress, (Type)null, "BorderColorIdle", new object[1] { Color.SeaGreen }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtaddress, (Type)null, "BorderColorMouseHover", new object[1] { Color.Blue }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtaddress, (Type)null, "BorderThickness", new object[1] { 1 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtaddress, (Type)null, "Cursor", new object[1] { Cursors.get_IBeam() }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtaddress, (Type)null, "Font", new object[1] { (object)new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtaddress, (Type)null, "ForeColor", new object[1] { Color.FromArgb(64, 64, 64) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtaddress, (Type)null, "isPassword", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtaddress, (Type)null, "Location", new object[1]
		{
			new Point(413, 348)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtaddress, (Type)null, "Margin", new object[1] { (object)new Padding(4, 5, 4, 5) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtaddress, (Type)null, "Name", new object[1] { "txtaddress" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtaddress, (Type)null, "Size", new object[1]
		{
			new Size(601, 30)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtaddress, (Type)null, "TabIndex", new object[1] { 3 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtaddress, (Type)null, "TextAlign", new object[1] { (object)(HorizontalAlignment)0 }, (string[])null, (Type[])null, false, true);
		Label4.set_AutoSize(true);
		((Control)Label4).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label4).set_Location(new Point(264, 413));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(48, 20));
		((Control)Label4).set_TabIndex(1);
		Label4.set_Text("Email");
		NewLateBinding.LateSetComplex(txtemail, (Type)null, "BorderColorFocused", new object[1] { Color.Red }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtemail, (Type)null, "BorderColorIdle", new object[1] { Color.SeaGreen }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtemail, (Type)null, "BorderColorMouseHover", new object[1] { Color.Blue }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtemail, (Type)null, "BorderThickness", new object[1] { 1 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtemail, (Type)null, "Cursor", new object[1] { Cursors.get_IBeam() }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtemail, (Type)null, "Font", new object[1] { (object)new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtemail, (Type)null, "ForeColor", new object[1] { Color.FromArgb(64, 64, 64) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtemail, (Type)null, "isPassword", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtemail, (Type)null, "Location", new object[1]
		{
			new Point(413, 403)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtemail, (Type)null, "Margin", new object[1] { (object)new Padding(4, 5, 4, 5) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtemail, (Type)null, "Name", new object[1] { "txtemail" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtemail, (Type)null, "Size", new object[1]
		{
			new Size(319, 30)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtemail, (Type)null, "TabIndex", new object[1] { 4 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtemail, (Type)null, "TextAlign", new object[1] { (object)(HorizontalAlignment)0 }, (string[])null, (Type[])null, false, true);
		((Control)UserImage).set_BackColor(Color.Black);
		((Control)UserImage).set_BackgroundImageLayout((ImageLayout)3);
		((Control)UserImage).set_Location(new Point(739, 31));
		((Control)UserImage).set_Name("UserImage");
		((Control)UserImage).set_Size(new Size(330, 188));
		UserImage.set_SizeMode((PictureBoxSizeMode)4);
		UserImage.set_TabIndex(9);
		UserImage.set_TabStop(false);
		((FileDialog)selectuserimage).set_FileName("OpenFileDialog1");
		((FileDialog)selectuserimage).set_Filter("JPG|*.jpg|PNG|*.png|JPEG|*.jpeg");
		NewLateBinding.LateSetComplex(txtpass, (Type)null, "BorderColorFocused", new object[1] { Color.Red }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtpass, (Type)null, "BorderColorIdle", new object[1] { Color.SeaGreen }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtpass, (Type)null, "BorderColorMouseHover", new object[1] { Color.Blue }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtpass, (Type)null, "BorderThickness", new object[1] { 1 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtpass, (Type)null, "Cursor", new object[1] { Cursors.get_IBeam() }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtpass, (Type)null, "Font", new object[1] { (object)new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtpass, (Type)null, "ForeColor", new object[1] { Color.FromArgb(64, 64, 64) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtpass, (Type)null, "isPassword", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtpass, (Type)null, "Location", new object[1]
		{
			new Point(413, 510)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtpass, (Type)null, "Margin", new object[1] { (object)new Padding(4, 5, 4, 5) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtpass, (Type)null, "Name", new object[1] { "txtpass" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtpass, (Type)null, "Size", new object[1]
		{
			new Size(319, 30)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtpass, (Type)null, "TabIndex", new object[1] { 6 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtpass, (Type)null, "TextAlign", new object[1] { (object)(HorizontalAlignment)0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtusername, (Type)null, "BorderColorFocused", new object[1] { Color.Red }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtusername, (Type)null, "BorderColorIdle", new object[1] { Color.SeaGreen }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtusername, (Type)null, "BorderColorMouseHover", new object[1] { Color.Blue }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtusername, (Type)null, "BorderThickness", new object[1] { 1 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtusername, (Type)null, "Cursor", new object[1] { Cursors.get_IBeam() }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtusername, (Type)null, "Font", new object[1] { (object)new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtusername, (Type)null, "ForeColor", new object[1] { Color.FromArgb(64, 64, 64) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtusername, (Type)null, "isPassword", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtusername, (Type)null, "Location", new object[1]
		{
			new Point(413, 456)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtusername, (Type)null, "Margin", new object[1] { (object)new Padding(4, 5, 4, 5) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtusername, (Type)null, "Name", new object[1] { "txtusername" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtusername, (Type)null, "Size", new object[1]
		{
			new Size(319, 30)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtusername, (Type)null, "TabIndex", new object[1] { 5 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtusername, (Type)null, "TextAlign", new object[1] { (object)(HorizontalAlignment)0 }, (string[])null, (Type[])null, false, true);
		Label6.set_AutoSize(true);
		((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label6).set_Location(new Point(264, 520));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(84, 20));
		((Control)Label6).set_TabIndex(27);
		Label6.set_Text("Password*");
		Label5.set_AutoSize(true);
		((Control)Label5).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label5).set_Location(new Point(264, 466));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(89, 20));
		((Control)Label5).set_TabIndex(26);
		Label5.set_Text("Username*");
		((Control)txtadharno).set_Font(new Font("Microsoft Sans Serif", 12f));
		((TextBoxBase)txtadharno).set_ForeColor(Color.FromArgb(64, 64, 64));
		((Control)txtadharno).set_Location(new Point(413, 295));
		txtadharno.set_Mask("0000   0000   0000");
		((Control)txtadharno).set_Name("txtadharno");
		((Control)txtadharno).set_Size(new Size(139, 26));
		((Control)txtadharno).set_TabIndex(2);
		((Control)Panel2).set_BackColor(Color.FromArgb(174, 8, 40));
		((Control)Panel2).set_Dock((DockStyle)1);
		((Control)Panel2).set_Location(new Point(200, 0));
		((Control)Panel2).set_Name("Panel2");
		((Control)Panel2).set_Size(new Size(881, 25));
		((Control)Panel2).set_TabIndex(29);
		((Control)Panel1).set_BackColor(Color.Black);
		((Control)Panel1).get_Controls().Add((Control)(object)Button1);
		((Control)Panel1).get_Controls().Add((Control)btnexit);
		((Control)Panel1).get_Controls().Add((Control)btnCreateuser);
		((Control)Panel1).set_Dock((DockStyle)3);
		((Control)Panel1).set_ForeColor(Color.Chocolate);
		((Control)Panel1).set_Location(new Point(0, 0));
		((Control)Panel1).set_Name("Panel1");
		((Control)Panel1).set_Size(new Size(200, 625));
		((Control)Panel1).set_TabIndex(28);
		((Control)Button1).set_Location(new Point(36, 155));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(75, 23));
		((Control)Button1).set_TabIndex(10);
		((ButtonBase)Button1).set_Text("Button1");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		((Control)Button1).set_Visible(false);
		Label7.set_AutoSize(true);
		((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label7).set_Location(new Point(264, 573));
		((Control)Label7).set_Name("Label7");
		((Control)Label7).set_Size(new Size(59, 20));
		((Control)Label7).set_TabIndex(27);
		Label7.set_Text("Salary*");
		NewLateBinding.LateSetComplex(txtSalary, (Type)null, "BorderColorFocused", new object[1] { Color.Red }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtSalary, (Type)null, "BorderColorIdle", new object[1] { Color.SeaGreen }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtSalary, (Type)null, "BorderColorMouseHover", new object[1] { Color.Blue }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtSalary, (Type)null, "BorderThickness", new object[1] { 1 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtSalary, (Type)null, "Cursor", new object[1] { Cursors.get_IBeam() }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtSalary, (Type)null, "Font", new object[1] { (object)new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtSalary, (Type)null, "ForeColor", new object[1] { Color.FromArgb(64, 64, 64) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtSalary, (Type)null, "isPassword", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtSalary, (Type)null, "Location", new object[1]
		{
			new Point(413, 563)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtSalary, (Type)null, "Margin", new object[1] { (object)new Padding(4, 5, 4, 5) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtSalary, (Type)null, "Name", new object[1] { "txtSalary" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtSalary, (Type)null, "Size", new object[1]
		{
			new Size(139, 30)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtSalary, (Type)null, "TabIndex", new object[1] { 7 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtSalary, (Type)null, "TextAlign", new object[1] { (object)(HorizontalAlignment)0 }, (string[])null, (Type[])null, false, true);
		lblmess2.set_AutoSize(true);
		((Control)lblmess2).set_Font(new Font("Century Gothic", 12f));
		((Control)lblmess2).set_ForeColor(Color.Red);
		((Control)lblmess2).set_Location(new Point(206, 46));
		((Control)lblmess2).set_Name("lblmess2");
		((Control)lblmess2).set_Size(new Size(44, 21));
		((Control)lblmess2).set_TabIndex(30);
		lblmess2.set_Text("Error");
		Label8.set_AutoSize(true);
		((Control)Label8).set_Font(new Font("Century Gothic", 36f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label8).set_Location(new Point(361, 63));
		((Control)Label8).set_Name("Label8");
		((Control)Label8).set_Size(new Size(295, 58));
		((Control)Label8).set_TabIndex(31);
		Label8.set_Text("Create User");
		NewLateBinding.LateSetComplex(btnCapture, (Type)null, "Location", new object[1]
		{
			new Point(739, 226)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCapture, (Type)null, "Name", new object[1] { "btnCapture" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCapture, (Type)null, "Size", new object[1]
		{
			new Size(207, 24)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCapture, (Type)null, "TabIndex", new object[1] { 32 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCapture, (Type)null, "Text", new object[1] { "Capture Image" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCapture, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(chkbxDetectFace, (Type)null, "Location", new object[1]
		{
			new Point(991, 229)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(chkbxDetectFace, (Type)null, "Name", new object[1] { "chkbxDetectFace" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(chkbxDetectFace, (Type)null, "Size", new object[1]
		{
			new Size(78, 18)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(chkbxDetectFace, (Type)null, "TabIndex", new object[1] { 33 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(chkbxDetectFace, (Type)null, "Text", new object[1] { "Detect Face" }, (string[])null, (Type[])null, false, true);
		((Control)PictureBox1).set_Location(new Point(200, 88));
		((Control)PictureBox1).set_Name("PictureBox1");
		((Control)PictureBox1).set_Size(new Size(155, 90));
		PictureBox1.set_TabIndex(34);
		PictureBox1.set_TabStop(false);
		lblMes.set_AutoSize(true);
		((Control)lblMes).set_Location(new Point(736, 31));
		((Control)lblMes).set_Name("lblMes");
		((Control)lblMes).set_Size(new Size(197, 13));
		((Control)lblMes).set_TabIndex(35);
		lblMes.set_Text("Please Only stand one person in camera");
		((Control)lblMes).set_Visible(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.White);
		((Form)this).set_ClientSize(new Size(1081, 625));
		((Control)this).get_Controls().Add((Control)(object)lblMes);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).get_Controls().Add((Control)chkbxDetectFace);
		((Control)this).get_Controls().Add((Control)btnCapture);
		((Control)this).get_Controls().Add((Control)(object)Label8);
		((Control)this).get_Controls().Add((Control)(object)lblmess2);
		((Control)this).get_Controls().Add((Control)(object)Panel2);
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Control)this).get_Controls().Add((Control)(object)txtadharno);
		((Control)this).get_Controls().Add((Control)txtSalary);
		((Control)this).get_Controls().Add((Control)txtpass);
		((Control)this).get_Controls().Add((Control)(object)Label7);
		((Control)this).get_Controls().Add((Control)txtusername);
		((Control)this).get_Controls().Add((Control)(object)Label6);
		((Control)this).get_Controls().Add((Control)(object)Label5);
		((Control)this).get_Controls().Add((Control)(object)UserImage);
		((Control)this).get_Controls().Add((Control)txtemail);
		((Control)this).get_Controls().Add((Control)txtaddress);
		((Control)this).get_Controls().Add((Control)txtmobno);
		((Control)this).get_Controls().Add((Control)txtname);
		((Control)this).get_Controls().Add((Control)(object)lblmess);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)lblname);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("CreateUserForm");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Create User");
		((ISupportInitialize)UserImage).EndInit();
		((Control)Panel1).ResumeLayout(false);
		((ISupportInitialize)btnCapture).EndInit();
		((ISupportInitialize)chkbxDetectFace).EndInit();
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Gk7r8L(object sender, EventArgs e)
	{
		((Control)lblmess2).Hide();
	}

	internal void Mg40Gb()
	{
		UserImage.set_Image((Image)null);
		RuntimeHelpers.GetObjectValue(new object());
		NewLateBinding.LateCall(camera, (Type)null, "Start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void c9MKf4(object r1EYp5, object Wk02Fc)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		try
		{
			UserImage.set_Image((Image)(Bitmap)NewLateBinding.LateGet(NewLateBinding.LateGet(Wk02Fc, (Type)null, "Frame", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Clone", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Gr0w3C(object sender, EventArgs e)
	{
		((Control)lblmess2).Hide();
	}

	private void Kx5p8W(object sender, EventArgs e)
	{
		NewLateBinding.LateSetComplex(txtname, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtemail, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtpass, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtusername, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtaddress, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null, false, true);
		txtadharno.set_Text("");
		NewLateBinding.LateSetComplex(txtmobno, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtSalary, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null, false, true);
		((Control)UserImage).set_BackgroundImage((Image)null);
		((Control)Wt9q7H.Forms.DashboardAdmin).Show();
		((Control)this).Hide();
		try
		{
			NewLateBinding.LateCall(camera, (Type)null, "Stop", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Xj7w9C(object sender, EventArgs e)
	{
		//IL_07d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc9: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(txtname, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			NewLateBinding.LateCall(txtname, (Type)null, "Focus", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			((Control)lblmess2).Show();
			lblmess2.set_Text("Enter your name");
			tmrerr.Start();
			NewLateBinding.LateCall(txtname, (Type)null, "Focus", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		else if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(txtmobno, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), Operators.CompareObjectLess(NewLateBinding.LateGet(NewLateBinding.LateGet(txtmobno, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)10, false))))
		{
			NewLateBinding.LateCall(txtmobno, (Type)null, "Focus", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			((Control)lblmess2).Show();
			lblmess2.set_Text("Enter your Mobile Number");
			tmrerr.Start();
			NewLateBinding.LateCall(txtmobno, (Type)null, "Focus", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		else if (txtadharno.get_Text().Length < 1)
		{
			((Control)txtadharno).Focus();
			((Control)lblmess2).Show();
			lblmess2.set_Text("Enter your Adhar No Number");
			tmrerr.Start();
		}
		else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(txtaddress, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			NewLateBinding.LateCall(txtaddress, (Type)null, "Focus", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			((Control)lblmess2).Show();
			lblmess2.set_Text("Enter your Residential Address");
			tmrerr.Start();
			NewLateBinding.LateCall(txtaddress, (Type)null, "Focus", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		else if (Conversions.ToBoolean(Operators.AndObject((object)em, Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(txtemail, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Contains", new object[1] { "@" }, (string[])null, (Type[])null, (bool[])null), (object)false, false))))
		{
			NewLateBinding.LateCall(txtemail, (Type)null, "Focus", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			((Control)lblmess2).Show();
			lblmess2.set_Text("Enter your correct Email Id");
			tmrerr.Start();
			NewLateBinding.LateCall(txtemail, (Type)null, "Focus", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(txtusername, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			NewLateBinding.LateCall(txtusername, (Type)null, "Focus", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			((Control)lblmess2).Show();
			lblmess2.set_Text("Enter your Username For Login Into Software");
			tmrerr.Start();
		}
		else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(txtpass, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			NewLateBinding.LateCall(txtpass, (Type)null, "Focus", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			((Control)lblmess2).Show();
			lblmess2.set_Text("Enter your Password for Login into Software");
			tmrerr.Start();
		}
		else if ((Operators.CompareString(str.ToString(), "", false) == 0) & !isimageisgetfromcamera)
		{
			((Control)lblmess2).Show();
			lblmess2.set_Text("Please select your photo from directory");
			tmrerr.Start();
		}
		else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(txtSalary, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			((Control)lblmess2).Show();
			lblmess2.set_Text("Enter salary");
			tmrerr.Start();
			NewLateBinding.LateCall(txtSalary, (Type)null, "Focus", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		else
		{
			try
			{
				NewLateBinding.LateCall(Rf7.cn, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			Rf7.p7N();
			object obj;
			object obj2;
			NewLateBinding.LateCall(Rf7.rs, (Type)null, "Open", (object[])(obj = new object[2]
			{
				"select * from userinfo where name='" + NewLateBinding.LateGet(txtname, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null).ToString() + "'",
				Rf7.cn
			}), (string[])null, (Type[])null, (bool[])(obj2 = new bool[2] { false, true }), true);
			if (((bool[])obj2)[1])
			{
				Rf7.cn = RuntimeHelpers.GetObjectValue(((object[])obj)[1]);
			}
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(Rf7.rs, (Type)null, "EOF", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false))
			{
				NewLateBinding.LateCall(Rf7.cn, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				((Control)lblmess2).Show();
				lblmess2.set_Text("Please Enter Another Name for User ");
				tmrerr.Start();
			}
			else if (isimageisgetfromcamera)
			{
				str = ec5k7X_0.string_0;
				try
				{
					NewLateBinding.LateCall(Rf7.cn, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
				try
				{
					Rf7.p7N();
					object rs = Rf7.rs;
					object[] obj3 = new object[2]
					{
						Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"INSERT INTO userinfo values('", NewLateBinding.LateGet(txtusername, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(txtpass, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(txtname, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(txtmobno, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(txtaddress, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(txtemail, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), (object)str), (object)"','"), (object)txtadharno.get_Text()), (object)"','"), (object)Conversions.ToInteger(NewLateBinding.LateGet(txtSalary, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null))), (object)"','"), (object)((ServerComputer)Wt9q7H.Computer).get_Clock().get_LocalTime().ToShortDateString()), (object)"')"),
						Rf7.cn
					};
					obj = obj3;
					bool[] obj4 = new bool[2] { false, true };
					obj2 = obj4;
					NewLateBinding.LateCall(rs, (Type)null, "Open", obj3, (string[])null, (Type[])null, obj4, true);
					if (((bool[])obj2)[1])
					{
						Rf7.cn = RuntimeHelpers.GetObjectValue((obj as object[])[1]);
					}
					Button1.PerformClick();
					MessageBox.Show("User is created");
					NewLateBinding.LateSetComplex(txtname, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSetComplex(txtemail, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSetComplex(txtpass, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSetComplex(txtusername, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSetComplex(txtaddress, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null, false, true);
					txtadharno.set_Text("");
					NewLateBinding.LateSetComplex(txtmobno, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSetComplex(txtSalary, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null, false, true);
					UserImage.set_Image((Image)null);
					NewLateBinding.LateCall(txtname, (Type)null, "Focus", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					((Control)Wt9q7H.Forms.DashboardAdmin).Show();
					((Control)this).Hide();
					isimageisgetfromcamera = false;
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					((Control)lblmess2).Show();
					lblmess2.set_Text("The user is already present Please select another username");
					tmrerr.Start();
					ProjectData.ClearProjectError();
				}
				NewLateBinding.LateCall(UserInfo, (Type)null, "reload_user", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(Rf7.cn, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			else
			{
				NewLateBinding.LateCall(Rf7.cn, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				IEnumerable safeFileName = selectuserimage.get_SafeFileName();
				IEnumerable<char> fileName = ((FileDialog)selectuserimage).get_FileName();
				IConvertible convertible = Application.get_StartupPath() + "\\userimg\\";
				if (!((ServerComputer)Wt9q7H.Computer).get_FileSystem().DirectoryExists(convertible as string))
				{
					((ServerComputer)Wt9q7H.Computer).get_FileSystem().CreateDirectory(convertible as string);
				}
				str = (convertible as string).ToString() + (safeFileName as string).ToString();
				object obj5 = new FileInfo((string)fileName);
				try
				{
					((FileInfo)obj5).CopyTo((string)convertible + (safeFileName as string), overwrite: false);
				}
				catch (Exception projectError4)
				{
					ProjectData.SetProjectError(projectError4);
					object obj6 = new Random();
					int num = ((Random)obj6).Next(0, 10000);
					(obj5 as FileInfo).CopyTo((string)convertible + (string)safeFileName + Conversions.ToString(num) + ".jpg", overwrite: true);
					str = (string)convertible + (string)safeFileName + Conversions.ToString(num) + ".jpg";
					ProjectData.ClearProjectError();
				}
				Rf7.p7N();
				try
				{
					object rs2 = Rf7.rs;
					object[] obj7 = new object[2]
					{
						Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"INSERT INTO userinfo values('", NewLateBinding.LateGet(txtusername, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(txtpass, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(txtname, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(txtmobno, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(txtaddress, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), NewLateBinding.LateGet(txtemail, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"','"), (object)str), (object)"','"), (object)txtadharno.get_Text()), (object)"','"), (object)Conversions.ToInteger(NewLateBinding.LateGet(txtSalary, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null))), (object)"','"), (object)((ServerComputer)Wt9q7H.Computer).get_Clock().get_LocalTime().ToShortDateString()), (object)"')"),
						Rf7.cn
					};
					obj = obj7;
					bool[] obj8 = new bool[2] { false, true };
					obj2 = obj8;
					NewLateBinding.LateCall(rs2, (Type)null, "Open", obj7, (string[])null, (Type[])null, obj8, true);
					if (((bool[])obj2)[1])
					{
						Rf7.cn = RuntimeHelpers.GetObjectValue(((object[])obj)[1]);
					}
					Button1.PerformClick();
					MessageBox.Show("User is created");
					NewLateBinding.LateSetComplex(txtname, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSetComplex(txtemail, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSetComplex(txtpass, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSetComplex(txtusername, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSetComplex(txtaddress, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null, false, true);
					txtadharno.set_Text("");
					NewLateBinding.LateSetComplex(txtmobno, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSetComplex(txtSalary, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null, false, true);
					((Control)UserImage).set_BackgroundImage((Image)null);
					UserImage.set_Image((Image)null);
					NewLateBinding.LateCall(txtname, (Type)null, "Focus", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					((Control)Wt9q7H.Forms.DashboardAdmin).Show();
					((Control)this).Hide();
				}
				catch (Exception projectError5)
				{
					ProjectData.SetProjectError(projectError5);
					((Control)lblmess2).Show();
					lblmess2.set_Text("The user is already present Please select another username");
					tmrerr.Start();
					ProjectData.ClearProjectError();
				}
				NewLateBinding.LateCall(UserInfo, (Type)null, "reload_user", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(Rf7.cn, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
		}
		try
		{
			NewLateBinding.LateCall(camera, (Type)null, "Stop", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
		}
		try
		{
			NewLateBinding.LateCall(camera, (Type)null, "Stop", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		catch (Exception projectError7)
		{
			ProjectData.SetProjectError(projectError7);
			ProjectData.ClearProjectError();
		}
	}

	private void Pg5q0M(object sender, EventArgs e)
	{
		NewLateBinding.LateCall(SelectImageGetFrom, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void r1F2Cw(object sender, KeyPressEventArgs e)
	{
		if (Strings.Asc(e.get_KeyChar()) != 8 && Strings.Asc(e.get_KeyChar()) != 32 && ((Strings.Asc(e.get_KeyChar()) < 65) | (Strings.Asc(e.get_KeyChar()) > 90)) && ((Strings.Asc(e.get_KeyChar()) < 97) | (Strings.Asc(e.get_KeyChar()) > 122)))
		{
			e.set_Handled(true);
		}
	}

	private void Qt94Zy(object sender, KeyPressEventArgs e)
	{
		if (Strings.Asc(e.get_KeyChar()) != 8 && ((Strings.Asc(e.get_KeyChar()) < 48) | (Strings.Asc(e.get_KeyChar()) > 57)))
		{
			e.set_Handled(true);
		}
		if (Operators.ConditionalCompareObjectGreaterEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(txtmobno, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)10, false) && Strings.Asc(e.get_KeyChar()) != 8)
		{
			e.set_Handled(true);
		}
	}

	private void o0J7Rs(object sender, EventArgs e)
	{
	}

	private void o6NPp0(object sender, EventArgs e)
	{
	}

	private void Fw8a5B(object sender, KeyPressEventArgs e)
	{
		if (Strings.Asc(e.get_KeyChar()) != 8 && ((Strings.Asc(e.get_KeyChar()) < 48) | (Strings.Asc(e.get_KeyChar()) > 57)))
		{
			e.set_Handled(true);
		}
	}

	private void Ba24Aw(object sender, EventArgs e)
	{
	}

	private void Kk5w3S(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(NewLateBinding.LateGet(txtemail, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))
		{
			em = true;
		}
		else
		{
			em = false;
		}
	}

	private void Pz5y3L(object b7M8Go, object c0TSg3)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		ec5k7X_0.pictureBox_1.set_Image((Image)(Bitmap)NewLateBinding.LateGet(NewLateBinding.LateGet(c0TSg3, (Type)null, "Frame", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Clone", new object[0], (string[])null, (Type[])null, (bool[])null));
	}

	private void Kw92Lz(object g2ZQn7, object f5A4Kz)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		picAdmin.set_Image((Image)(Bitmap)NewLateBinding.LateGet(NewLateBinding.LateGet(f5A4Kz, (Type)null, "Frame", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Clone", new object[0], (string[])null, (Type[])null, (bool[])null));
	}

	private void Lm1n4H(object sender, EventArgs e)
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
		UserImage.set_Image(UserImage.get_Image());
		IEquatable<string> equatable = Application.get_StartupPath() + "\\userimg\\";
		if (!((ServerComputer)Wt9q7H.Computer).get_FileSystem().DirectoryExists((string)equatable))
		{
			((ServerComputer)Wt9q7H.Computer).get_FileSystem().CreateDirectory((string)equatable);
		}
		object obj = new Random();
		int num = (obj as Random).Next(0, 100000);
		IConvertible convertible = Application.get_StartupPath() + "\\userimg\\" + NewLateBinding.LateGet(txtname, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null).ToString() + Conversions.ToString(num) + ".jpeg";
		UserImage.get_Image().Save(convertible as string, ImageFormat.get_Jpeg());
		isimageisgetfromcamera = true;
		ICloneable cloneable = convertible as string;
		ec5k7X_0.string_0 = cloneable as string;
		Timer1.Stop();
	}

	private void Yg2x7K(object sender, EventArgs e)
	{
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected O, but got Unknown
		RuntimeHelpers.GetObjectValue(new object());
		object obj = default(object);
		NewLateBinding.LateSet(obj, (Type)null, "SearchMode", new object[1] { NewLateBinding.LateGet(ObjectDetectorSearchMode, (Type)null, "Average", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(obj, (Type)null, "ScalingFactor", new object[1] { 1.5 }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(obj, (Type)null, "ScalingMode", new object[1] { NewLateBinding.LateGet(ObjectDetectorScalingMode, (Type)null, "GreaterToSmaller", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(obj, (Type)null, "UseParallelProcessing", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(obj, (Type)null, "Suppression", new object[1] { 2 }, (string[])null, (Type[])null);
		new PictureBox();
		try
		{
			Control userImage;
			object[] obj2 = new object[1] { ((PictureBox)(userImage = (Control)(object)UserImage)).get_Image() };
			object obj3 = obj2;
			bool[] obj4 = new bool[1] { true };
			Array array = obj4;
			object obj5 = NewLateBinding.LateGet(obj, (Type)null, "ProcessFrame", obj2, (string[])null, (Type[])null, obj4);
			if ((array as bool[])[0])
			{
				((PictureBox)userImage).set_Image((Image)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(((object[])obj3)[0]), typeof(Image)));
			}
			Array array2 = (Rectangle[])obj5;
			IDeviceContext val = (IDeviceContext)(object)Graphics.FromImage(UserImage.get_Image());
			object obj6 = (Rectangle[])array2;
			for (int i = 0; i < (obj6 as Rectangle[]).Length; i = checked(i + 1))
			{
				Rectangle rectangle = (obj6 as Rectangle[])[i];
				((Graphics)((val is Graphics) ? val : null)).DrawRectangle(Pens.get_White(), rectangle);
				if ((array2 as Rectangle[]).Count() > 0)
				{
					UserImage.set_Image(UserImage.get_Image());
					Timer1.Stop();
					NewLateBinding.LateCall(camera, (Type)null, "Stop", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					NewLateBinding.LateCall(btnCapture, (Type)null, "PerformClick", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				}
			}
			((Graphics)((val is Graphics) ? val : null)).Dispose();
			((Control)UserImage).Invalidate();
		}
		catch (AccessViolationException projectError)
		{
			ProjectData.SetProjectError((Exception)projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void a1KYn3(object r4MJs5, object y5G7Ri)
	{
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(chkbxDetectFace, (Type)null, "Checked", new object[0], (string[])null, (Type[])null, (bool[])null), (object)true, false))
		{
			Timer1.Start();
			NewLateBinding.LateSetComplex(btnCapture, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null, false, true);
		}
		else
		{
			Timer1.Stop();
			((Component)(object)Timer1).Dispose();
			NewLateBinding.LateSetComplex(btnCapture, (Type)null, "Visible", new object[1] { true }, (string[])null, (Type[])null, false, true);
		}
	}

	private void Co5z6Q(object sender, EventArgs e)
	{
		IConvertible convertible = Application.get_StartupPath() + "\\AdminUserCreateImages\\";
		if (!((ServerComputer)Wt9q7H.Computer).get_FileSystem().DirectoryExists(convertible as string))
		{
			((ServerComputer)Wt9q7H.Computer).get_FileSystem().CreateDirectory(convertible as string);
		}
		object obj = default(object);
		NewLateBinding.LateCall(obj, (Type)null, "Start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		object obj2 = new Random();
		int num = (obj2 as Random).Next(0, 100000);
		IConvertible convertible2 = Application.get_StartupPath() + "\\AdminUserCreateImages\\" + NewLateBinding.LateGet(txtusername, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null).ToString() + Conversions.ToString(num) + ".jpeg";
		int num2 = 0;
		while (num2 < 10)
		{
			try
			{
				picAdmin.get_Image().Save(convertible2 as string, ImageFormat.get_Jpeg());
				num2 = 10;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		NewLateBinding.LateCall(obj, (Type)null, "Stop", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	internal static void t2A1Wm(Ez0.n4D Lb03Sn, byte[] Lr0f6Y, int Nr6p1Y)
	{
		checked
		{
			object obj = new byte[Lb03Sn.Data.Length - 1 + 1];
			int num = Lb03Sn.Data.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				int num2 = i + s7K2Ek.Kz93Nk(Nr6p1Y, Lr0f6Y.Length, null, null, 1);
				int num3 = num2 & Nr6p1Y;
				int num4 = s7K2Ek.Kz93Nk(i, Lr0f6Y.Length, null, null, 1);
				int num5 = Lr0f6Y[num4];
				int num6 = Convert.ToInt32(s7K2Ek.Kz93Nk(0, 0, num5, num3, 2));
				int num7 = Lb03Sn.Data[i];
				((byte[])obj)[i] = (byte)s7K2Ek.Kz93Nk(0, 0, num7, num6, 2);
			}
			Array array = new object[6];
			((object[])array)[0] = "$$NoBodyCanGetIt$$";
			((object[])array)[1] = "$$MLKjclkdsjfklsdfkghfdkhgfhmjlyil$$";
			((object[])array)[2] = "ASAMethod0ASA";
			try
			{
				Lb03Sn.Ass = (Assembly)f3L6Rd.Mw0x9R(obj as byte[]);
				a8C.Rb5(Lb03Sn);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	static void Qi8c7H()
	{
		//IL_010f: Expected O, but got I4
		//IL_022e: Expected O, but got I4
		//IL_0289: Expected O, but got I4
		//IL_0298: Expected O, but got I4
		//IL_03cb: Expected O, but got I4
		//IL_0507: Expected O, but got I4
		//IL_0529: Expected O, but got I4
		//IL_0549: Expected O, but got I4
		//IL_058a: Expected O, but got I4
		//IL_05e0: Expected O, but got I4
		//IL_077f: Expected O, but got I4
		//IL_08e4: Expected O, but got I4
		//IL_08ee: Expected O, but got I4
		//IL_092c: Expected O, but got I4
		//IL_095d: Expected O, but got I4
		z3T z3T = z3T;
		z3T = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		f1P6Lz f1P6Lz;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s7K2Ek s7K2Ek);
		try
		{
			obj = null;
		}
		finally
		{
			while (true)
			{
				if (obj != null)
				{
					s7K2Ek = s7K2Ek;
					_ = (Rf7)s7K2Ek.ObjectDetectorSearchMode;
					continue;
				}
				f1P6Lz = null;
				if (((Mr7n6D)f1P6Lz.SupplierDailyRecord).UserInfo == null)
				{
					break;
				}
			}
			goto IL_0064;
		}
		IL_0064:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ag9 ag);
		while (true)
		{
			ag = ag;
			if (ag.UserInfo != null)
			{
				_ = (Rf7)(object)Yg89Py.Default;
				continue;
			}
			break;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sy0 sy);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Yg89Py yg89Py);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f3L6Rd f3L6Rd);
		while (true)
		{
			sy = sy;
			if (sy.UserInfo == null)
			{
				break;
			}
			yg89Py = null;
			f3L6Rd = (f3L6Rd)(object)yg89Py.Fast_food_managementConnectionString;
			f3L6Rd = f3L6Rd;
		}
		_003CModule_003E _003CModule_003E = _003CModule_003E;
		_003CModule_003E = _003CModule_003E;
		i1D i1D = i1D;
		_ = (x6LFp1)i1D.PrintMonthlyRecords;
		Mt2 mt = mt;
		mt = mt;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y0D y0D);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Mr7n6D mr7n6D);
		while (true)
		{
			y0D = y0D;
			if (((Sy0)(y0D.Width as Xn05Ce).ObjectDetectorSearchMode).SupplierDailyRecord == null)
			{
				break;
			}
			_ = (Hf08Tc)mr7n6D.ObjectDetectorScalingMode;
		}
		ag = ag;
		a8C a8C = (a8C)mr7n6D.SelectImageGetFrom;
		nuint uIntPtr = (UIntPtr)a8C.PayTMPay;
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			if ((UIntPtr)ag.UserInfo == (UIntPtr)(nuint)0u)
			{
				if (uIntPtr == 0)
				{
					_ = (Ag9)f3L6Rd.PrintDailyRecords;
				}
			}
			else
			{
				while (obj != null)
				{
					_003CModule_003E = _003CModule_003E;
				}
			}
		}
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				_ = (y0D)(object)Yg89Py.Default;
				_ = (Se60Di)(object)Yg89Py.Default;
			}
		}
		finally
		{
			if ((UIntPtr)((f3L6Rd)null).PrintDailyRecords == (UIntPtr)(nuint)0u)
			{
				try
				{
					Se60Di se60Di = se60Di;
					se60Di = se60Di;
				}
				catch
				{
					z3T = z3T;
				}
			}
			goto IL_01ef;
		}
		IL_029f:
		try
		{
			_ = (Hf08Tc)(object)yg89Py.Fast_food_managementConnectionString;
			_ = (m8K)((Sy0)((a8C)((f3L6Rd)i1D.PrintMonthlyRecords).PrintDailyRecords).PayTMPay).SuppliedRecord;
		}
		finally
		{
			try
			{
				yg89Py = (Yg89Py)f1P6Lz.SupplierDailyRecord;
			}
			catch
			{
				while (((i1D)null).PrintMonthlyRecords != null)
				{
					_ = (_003CModule_003E)((f1P6Lz)((a8C)null).PayTMPay).SupplierDailyRecord;
				}
			}
			goto IL_031d;
		}
		IL_01ef:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Xn05Ce xn05Ce);
		if (uIntPtr == 0)
		{
			try
			{
				if ((UIntPtr)((Sy0)mr7n6D.ObjectDetectorSearchMode).SuppliedRecord == (UIntPtr)(nuint)0u)
				{
					ag = (Ag9)sy.UserInfo;
				}
			}
			finally
			{
				do
				{
					xn05Ce = y0D.Width as Xn05Ce;
					Wt9q7H wt9q7H = (Wt9q7H)((Mr7n6D)xn05Ce.ObjectDetectorScalingMode).UserInfo;
					wt9q7H = wt9q7H;
				}
				while (obj != null);
				goto IL_0262;
			}
		}
		goto IL_0262;
		IL_0473:
		_ = (Hf08Tc)f1P6Lz.Send_sms_to_customer;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s4C8Py s4C8Py);
		try
		{
			y0D = (y0D)ag.UserInfo;
		}
		finally
		{
			if ((UIntPtr)((Yg89Py)null).Fast_food_managementConnectionString == (UIntPtr)(nuint)0u)
			{
				if (checked(uIntPtr * uIntPtr) == 0)
				{
					_ = (Rf7)(object)yg89Py.Fast_food_managementConnectionString;
				}
				else
				{
					s4C8Py obj4 = (s4C8Py)((a8C)null).PayTMPay;
					s4C8Py = s4C8Py;
					s4C8Py = obj4;
				}
			}
			else
			{
				do
				{
					_ = (Bs)((i1D)null).PrintMonthlyRecords;
					_ = (z3T)((f1P6Lz)xn05Ce.UserInfo).SuppliedRecord;
					_ = ((y0D)null).Width is z3T;
				}
				while (sy.UserInfo != null);
			}
			goto IL_0521;
		}
		IL_0262:
		try
		{
			while (y0D.Width is object)
			{
				_ = (z3T)((f1P6Lz)i1D.PrintMonthlyRecords).SupplierDailyRecord;
			}
		}
		finally
		{
			_ = ((y0D)null).Width is Ty5k0C;
			goto IL_029f;
		}
		IL_031d:
		if (uIntPtr == 0)
		{
			while (obj != null)
			{
				do
				{
					_ = (i1D)((f1P6Lz)a8C.PayTMPay).SupplierDailyRecord;
				}
				while (sy.SupplierInfo != null);
			}
		}
		do
		{
			s7K2Ek = s7K2Ek;
		}
		while (((a8C)f3L6Rd.PrintDailyRecords).PayTMPay != null);
		while (obj != null)
		{
			if (uIntPtr == 0)
			{
				Se60Di se60Di = null;
			}
		}
		if (uIntPtr == 0)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				if (uIntPtr == 0)
				{
					_ = (Ez0)((Xn05Ce)null).ObjectDetectorScalingMode;
				}
				else
				{
					_ = (Bs)((f1P6Lz)null).Send_sms_to_customer;
				}
			}
			else
			{
				_ = (y0D)(y0D.Width as i1D).PrintMonthlyRecords;
			}
		}
		x6LFp1 obj5 = (x6LFp1)((f1P6Lz)null).SuppliedRecord;
		x6LFp1 x6LFp = x6LFp;
		x6LFp = obj5;
		try
		{
			do
			{
				_ = (s9.y6)sy.SupplierDailyRecord;
			}
			while (obj != null);
		}
		finally
		{
			try
			{
				_ = (i1D)((Sy0)f3L6Rd.PrintDailyRecords).SupplierDailyRecord;
			}
			catch
			{
			}
			goto IL_042a;
		}
		IL_042a:
		if ((UIntPtr)sy.SupplierDailyRecord == (UIntPtr)(nuint)0u)
		{
			xn05Ce = (Xn05Ce)ag.UserInfo;
		}
		else if (uIntPtr == 0)
		{
			try
			{
				b4 b = b;
				b = b;
			}
			finally
			{
				_ = (f3L6Rd)(object)Yg89Py.Default;
				goto IL_0473;
			}
		}
		goto IL_0473;
		IL_0521:
		do
		{
			try
			{
				try
				{
					_ = ((y0D)null).Width is m8K;
					_ = (y0D)f1P6Lz.SupplierDailyRecord;
				}
				finally
				{
					_ = y0D.Width is i7Z8Et;
					x6LFp = (x6LFp1)((Xn05Ce)null).ObjectDetectorScalingMode;
					_ = (s7K2Ek)((Sy0)((Xn05Ce)(object)Yg89Py.Default).ObjectDetectorScalingMode).SupplierInfo;
					goto end_IL_0521;
				}
				end_IL_0521:;
			}
			finally
			{
				if (!(y0D.Width is UIntPtr))
				{
					_ = (s4C8Py)mr7n6D.SelectImageGetFrom;
				}
				continue;
			}
		}
		while (obj != null);
		_ = (Bs)f1P6Lz.SupplierDailyRecord;
		_ = (i7Z8Et)((i1D)ag.UserInfo).PrintMonthlyRecords;
		do
		{
			try
			{
			}
			catch
			{
				do
				{
					_ = ((y0D)null).Width is Hf08Tc;
				}
				while (obj != null);
			}
		}
		while (obj != null);
		_ = (z3T)mr7n6D.SelectImageGetFrom;
		_ = (y0D)((Mr7n6D)ag.UserInfo).ObjectDetectorScalingMode;
		s7K2Ek = s7K2Ek;
		_ = (x6LFp1)s7K2Ek.ObjectDetectorScalingMode;
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			try
			{
				if ((UIntPtr)ag.UserInfo == (UIntPtr)(nuint)0u)
				{
					_ = (m8K)(object)((Yg89Py)((s7K2Ek)null).ObjectDetectorScalingMode).Fast_food_managementConnectionString;
					mr7n6D = mr7n6D;
					xn05Ce = xn05Ce;
				}
			}
			finally
			{
				f3L6Rd = f3L6Rd;
				goto IL_06f9;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sy50Xx sy50Xx);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s9.y6 y);
		try
		{
			if ((UIntPtr)xn05Ce.UserInfo == (UIntPtr)(nuint)0u)
			{
				s9.y6 obj8 = (s9.y6)((i1D)((i1D)null).PrintMonthlyRecords).PrintMonthlyRecords;
				y = null;
				y = obj8;
			}
		}
		finally
		{
			try
			{
				_ = (Xn05Ce)((f3L6Rd)null).PrintDailyRecords;
			}
			finally
			{
				_ = (Rf7)sy.SupplierInfo;
				Sy50Xx obj9 = (Sy50Xx)i1D.PrintMonthlyRecords;
				sy50Xx = sy50Xx;
				sy50Xx = obj9;
				x6LFp = x6LFp;
				goto IL_06f9;
			}
		}
		IL_08d9:
		do
		{
			try
			{
				try
				{
					_ = (y0D.Width as y0D).Width is Bs;
				}
				finally
				{
					s4C8Py = s4C8Py;
					goto end_IL_08d9;
				}
				end_IL_08d9:;
			}
			catch
			{
				try
				{
					_ = (e2.y6)((Sy0)((Ag9)null).UserInfo).SuppliedRecord;
					_ = ((y0D)(object)yg89Py.DBForFoodManagementConnectionString).Width is Ag9;
					z3T = z3T;
					ag = ag;
				}
				finally
				{
					_ = (Sy50Xx)((Xn05Ce)null).UserInfo;
					goto end_IL_0901;
				}
				end_IL_0901:;
			}
		}
		while (y0D.Width is object);
		if (checked(unchecked((nuint)default(UIntPtr)) + unchecked((nuint)(UIntPtr)((f3L6Rd)(object)yg89Py.DBForFoodManagementConnectionString).PrintDailyRecords)) == 0)
		{
			if ((UIntPtr)mr7n6D.SelectImageGetFrom != (UIntPtr)(nuint)0u)
			{
			}
		}
		else
		{
			while (obj != null)
			{
				do
				{
					_ = (Se60Di)((Xn05Ce)null).ObjectDetectorSearchMode;
				}
				while (obj != null);
			}
		}
		_ = (e2.y6)((Yg89Py)((Ag9)((Mr7n6D)null).SelectImageGetFrom).UserInfo).DBForFoodManagementConnectionString;
		return;
		IL_06f9:
		try
		{
			if ((UIntPtr)((Sy0)sy.SupplierInfo).UserInfo == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (z3T)i1D.PrintMonthlyRecords;
				}
				finally
				{
					Mm0 obj11 = (Mm0)(object)Yg89Py.Default;
					Mm0 mm = mm;
					mm = obj11;
					Rf7 rf = (Rf7)((f3L6Rd)null).PrintDailyRecords;
					rf = rf;
					goto end_IL_06fa;
				}
			}
			end_IL_06fa:;
		}
		catch
		{
			f3L6Rd = f3L6Rd;
			_ = (_003CModule_003E)xn05Ce.ObjectDetectorSearchMode;
		}
		sy50Xx = sy50Xx;
		_ = ((y0D)null).Width is m8K;
		sy50Xx = (Sy50Xx)a8C.PayTMPay;
		while (obj != null)
		{
			try
			{
				try
				{
					_ = (Ty5k0C)xn05Ce.ObjectDetectorSearchMode;
				}
				finally
				{
					_ = (Ag9)((Sy0)s7K2Ek.ObjectDetectorScalingMode).UserInfo;
					sy = sy;
					_ = (e2.y6)((Ag9)null).UserInfo;
					_ = (Mm0)(object)((Yg89Py)((f1P6Lz)null).SuppliedRecord).DBForFoodManagementConnectionString;
					goto end_IL_0799;
				}
				end_IL_0799:;
			}
			catch
			{
				mr7n6D = null;
			}
		}
		checked
		{
			if (uIntPtr + uIntPtr == 0)
			{
				while (obj != null)
				{
					while (obj != null)
					{
						f3L6Rd = (f3L6Rd)((s7K2Ek)a8C.PayTMPay).ObjectDetectorSearchMode;
					}
				}
			}
			else
			{
				try
				{
					if (unchecked((nuint)(UIntPtr)s7K2Ek.ObjectDetectorSearchMode) * uIntPtr == 0)
					{
					}
				}
				catch
				{
					do
					{
						_003CModule_003E = (_003CModule_003E)sy.SupplierDailyRecord;
					}
					while (s7K2Ek.ObjectDetectorScalingMode != null);
				}
			}
			try
			{
			}
			finally
			{
				_ = (_003CModule_003E)xn05Ce.UserInfo;
				a8C = (a8C)((f3L6Rd)((f1P6Lz)((a8C)((a8C)null).PayTMPay).PayTMPay).SupplierDailyRecord).PrintDailyRecords;
				y = y;
				_ = (Ez0)((Ag9)((f1P6Lz)null).SupplierDailyRecord).UserInfo;
				goto IL_08d9;
			}
		}
	}
}
