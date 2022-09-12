using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Bo6;
using Dp4o9T;
using Dt7;
using Ed65Hf;
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

namespace Ed9;

[DesignerGenerated]
public class Ez0
{
	public class n4D
	{
		private int _num;

		private Assembly _Ass;

		private byte[] _Salt;

		private string _Res;

		private int _Mnum;

		private Ty5k0C.Dk01Rc dk01Rc_0;

		public int num
		{
			get
			{
				return _num;
			}
			set
			{
				_num = value;
			}
		}

		public Assembly Ass
		{
			get
			{
				return _Ass;
			}
			set
			{
				_Ass = value;
			}
		}

		public string[] Names
		{
			get
			{
				return dk01Rc_0.string_0;
			}
			set
			{
				dk01Rc_0.string_0 = value;
			}
		}

		public byte[] Data
		{
			get
			{
				return dk01Rc_0.byte_0;
			}
			set
			{
				dk01Rc_0.byte_0 = value;
			}
		}

		public byte[] Salt
		{
			get
			{
				return _Salt;
			}
			set
			{
				_Salt = value;
			}
		}

		public string ResName
		{
			get
			{
				return dk01Rc_0.string_1;
			}
			set
			{
				dk01Rc_0.string_1 = value as string;
			}
		}

		public string Res
		{
			get
			{
				return _Res;
			}
			set
			{
				_Res = value;
			}
		}

		public int TNum
		{
			get
			{
				return dk01Rc_0.int_0;
			}
			set
			{
				dk01Rc_0.int_0 = value;
			}
		}

		public int Mnum
		{
			get
			{
				return _Mnum;
			}
			set
			{
				_Mnum = value;
			}
		}

		public string MName
		{
			get
			{
				return dk01Rc_0.string_2;
			}
			set
			{
				dk01Rc_0.string_2 = value;
			}
		}
	}

	[AccessedThroughProperty("tmrerr")]
	private Timer _tmrerr;

	[AccessedThroughProperty("BunifuCustomLabel1")]
	private object _BunifuCustomLabel1;

	[AccessedThroughProperty("txtboxppass")]
	private object _txtboxppass;

	[AccessedThroughProperty("txtboxusername")]
	private object _txtboxusername;

	[AccessedThroughProperty("RadDesktopAlert1")]
	private object _RadDesktopAlert1;

	[AccessedThroughProperty("btnExit")]
	private object _btnExit;

	[AccessedThroughProperty("Office2010BlackTheme1")]
	private object _Office2010BlackTheme1;

	[AccessedThroughProperty("LabelControl1")]
	private object _LabelControl1;

	public bool iscameraon;

	public object camera;

	public string loginname;

	public bool isadmin;

	private s7K2Ek.Dw5b7Z dw5b7Z_0 = new s7K2Ek.Dw5b7Z();

	internal virtual Label lblerror
	{
		get
		{
			return dw5b7Z_0.label_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			dw5b7Z_0.label_0 = ((value is Label) ? value : null);
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
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			object obj = new EventHandler(g6H);
			Component component = (Component)(object)_tmrerr;
			if (component is Timer)
			{
				((Timer)component).remove_Tick(obj as EventHandler);
			}
			_tmrerr = value;
			component = (Component)(object)_tmrerr;
			if ((int)(Timer)component != 0)
			{
				((Timer)component).add_Tick((EventHandler)obj);
			}
		}
	}

	internal virtual object BunifuCustomLabel2
	{
		get
		{
			return dw5b7Z_0.object_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			dw5b7Z_0.object_0 = objectValue;
		}
	}

	internal virtual object BunifuCustomLabel1
	{
		get
		{
			return _BunifuCustomLabel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_BunifuCustomLabel1 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual object txtboxppass
	{
		get
		{
			return _txtboxppass;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtboxppass = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual object txtboxusername
	{
		get
		{
			return _txtboxusername;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtboxusername = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual object RadDesktopAlert1
	{
		get
		{
			return _RadDesktopAlert1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_RadDesktopAlert1 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual object btnLogin
	{
		get
		{
			return dw5b7Z_0.object_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			dw5b7Z_0.object_1 = objectValue;
		}
	}

	internal virtual object btnExit
	{
		get
		{
			return _btnExit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_btnExit = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual object Office2010BlackTheme1
	{
		get
		{
			return _Office2010BlackTheme1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Office2010BlackTheme1 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual object LabelControl1
	{
		get
		{
			return _LabelControl1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_LabelControl1 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public Ez0()
	{
		iscameraon = false;
		loginname = "";
		isadmin = false;
		Rc9();
	}

	private void Rc9()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Expected O, but got Unknown
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c6: Expected O, but got Unknown
		//IL_0568: Unknown result type (might be due to invalid IL or missing references)
		//IL_071e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0724: Expected O, but got Unknown
		//IL_07c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad0: Expected O, but got Unknown
		IDisposable disposable = new Container();
		dw5b7Z_0.icontainer_0 = disposable as IContainer;
		lblerror = new Label();
		tmrerr = new Timer(dw5b7Z_0.icontainer_0);
		((ISupportInitialize)btnLogin).BeginInit();
		((ISupportInitialize)btnExit).BeginInit();
		lblerror.set_AutoSize(true);
		((Control)lblerror).set_BackColor(SystemColors.WindowText);
		((Control)lblerror).set_ForeColor(Color.Transparent);
		((Control)lblerror).set_Location(new Point(2, 2));
		((Control)lblerror).set_Name("lblerror");
		((Control)lblerror).set_Size(new Size(39, 13));
		((Control)lblerror).set_TabIndex(13);
		lblerror.set_Text("Label3");
		tmrerr.set_Interval(2000);
		NewLateBinding.LateSetComplex(BunifuCustomLabel2, (Type)null, "AutoSize", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(BunifuCustomLabel2, (Type)null, "BackColor", new object[1] { Color.Transparent }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(BunifuCustomLabel2, (Type)null, "Font", new object[1] { (object)new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(BunifuCustomLabel2, (Type)null, "ForeColor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(BunifuCustomLabel2, (Type)null, "Location", new object[1]
		{
			new Point(84, 168)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(BunifuCustomLabel2, (Type)null, "Name", new object[1] { "BunifuCustomLabel2" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(BunifuCustomLabel2, (Type)null, "Size", new object[1]
		{
			new Size(78, 20)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(BunifuCustomLabel2, (Type)null, "TabIndex", new object[1] { 14 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(BunifuCustomLabel2, (Type)null, "Text", new object[1] { "Password" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(BunifuCustomLabel1, (Type)null, "AutoSize", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(BunifuCustomLabel1, (Type)null, "BackColor", new object[1] { Color.Transparent }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(BunifuCustomLabel1, (Type)null, "Font", new object[1] { (object)new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(BunifuCustomLabel1, (Type)null, "ForeColor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(BunifuCustomLabel1, (Type)null, "Location", new object[1]
		{
			new Point(84, 106)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(BunifuCustomLabel1, (Type)null, "Name", new object[1] { "BunifuCustomLabel1" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(BunifuCustomLabel1, (Type)null, "Size", new object[1]
		{
			new Size(83, 20)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(BunifuCustomLabel1, (Type)null, "TabIndex", new object[1] { 15 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(BunifuCustomLabel1, (Type)null, "Text", new object[1] { "Username" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtboxppass, (Type)null, "BackColor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtboxppass, (Type)null, "BorderColorFocused", new object[1] { Color.Red }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtboxppass, (Type)null, "BorderColorIdle", new object[1] { Color.SeaGreen }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtboxppass, (Type)null, "BorderColorMouseHover", new object[1] { Color.Blue }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtboxppass, (Type)null, "BorderThickness", new object[1] { 1 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtboxppass, (Type)null, "Cursor", new object[1] { Cursors.get_IBeam() }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtboxppass, (Type)null, "Font", new object[1] { (object)new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtboxppass, (Type)null, "ForeColor", new object[1] { Color.FromArgb(64, 64, 64) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtboxppass, (Type)null, "isPassword", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtboxppass, (Type)null, "Location", new object[1]
		{
			new Point(221, 158)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtboxppass, (Type)null, "Margin", new object[1] { (object)new Padding(4) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtboxppass, (Type)null, "Name", new object[1] { "txtboxppass" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtboxppass, (Type)null, "Size", new object[1]
		{
			new Size(368, 30)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtboxppass, (Type)null, "TabIndex", new object[1] { 1 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtboxppass, (Type)null, "TextAlign", new object[1] { (object)(HorizontalAlignment)0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtboxusername, (Type)null, "BackColor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtboxusername, (Type)null, "BorderColorFocused", new object[1] { Color.Red }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtboxusername, (Type)null, "BorderColorIdle", new object[1] { Color.SeaGreen }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtboxusername, (Type)null, "BorderColorMouseHover", new object[1] { Color.Blue }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtboxusername, (Type)null, "BorderThickness", new object[1] { 1 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtboxusername, (Type)null, "Cursor", new object[1] { Cursors.get_IBeam() }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtboxusername, (Type)null, "Font", new object[1] { (object)new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtboxusername, (Type)null, "ForeColor", new object[1] { Color.FromArgb(64, 64, 64) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtboxusername, (Type)null, "isPassword", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtboxusername, (Type)null, "Location", new object[1]
		{
			new Point(221, 96)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtboxusername, (Type)null, "Margin", new object[1] { (object)new Padding(4) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtboxusername, (Type)null, "Name", new object[1] { "txtboxusername" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtboxusername, (Type)null, "Size", new object[1]
		{
			new Size(368, 30)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtboxusername, (Type)null, "TabIndex", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtboxusername, (Type)null, "TextAlign", new object[1] { (object)(HorizontalAlignment)0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(RadDesktopAlert1, (Type)null, "ShowOptionsButton", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(RadDesktopAlert1, (Type)null, "ShowPinButton", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnLogin, (Type)null, "Location", new object[1]
		{
			new Point(221, 243)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnLogin, (Type)null, "Name", new object[1] { "btnLogin" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnLogin, (Type)null, "Size", new object[1]
		{
			new Size(164, 36)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnLogin, (Type)null, "TabIndex", new object[1] { 2 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnLogin, (Type)null, "Text", new object[1] { "Login" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnLogin, (Type)null, "ThemeName", new object[1] { "Office2010Black" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnExit, (Type)null, "Location", new object[1]
		{
			new Point(425, 243)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnExit, (Type)null, "Name", new object[1] { "btnExit" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnExit, (Type)null, "Size", new object[1]
		{
			new Size(164, 36)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnExit, (Type)null, "TabIndex", new object[1] { 3 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnExit, (Type)null, "Text", new object[1] { "Exit" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnExit, (Type)null, "ThemeName", new object[1] { "Office2010Black" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(LabelControl1, (Type)null, "Appearance", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Font", new object[1] { (object)new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(LabelControl1, (Type)null, "Appearance", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Options", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "UseFont", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(LabelControl1, (Type)null, "Location", new object[1]
		{
			new Point(560, 340)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(LabelControl1, (Type)null, "Name", new object[1] { "LabelControl1" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(LabelControl1, (Type)null, "Size", new object[1]
		{
			new Size(96, 16)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(LabelControl1, (Type)null, "TabIndex", new object[1] { 16 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(LabelControl1, (Type)null, "Text", new object[1] { "Forget Password" }, (string[])null, (Type[])null, false, true);
	}

	private void g6H(object sender, EventArgs e)
	{
		((Control)lblerror).Hide();
	}

	private void Jb4(object sender, EventArgs e)
	{
		((Control)lblerror).Hide();
	}

	private void Co9(object sender, EventArgs e)
	{
		//IL_045b: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
		object objectValue = RuntimeHelpers.GetObjectValue(new object());
		if (!iscameraon)
		{
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(objectValue, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null), (object)(DialogResult)1, false))
			{
				camera = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "VideoDevice", new object[0], (string[])null, (Type[])null, (bool[])null));
				iscameraon = true;
			}
			return;
		}
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(txtboxusername, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			NewLateBinding.LateCall(txtboxusername, (Type)null, "Focus", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			((Control)lblerror).Show();
			lblerror.set_Text("Enter Username");
			tmrerr.Start();
			return;
		}
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(txtboxppass, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
		{
			NewLateBinding.LateCall(txtboxppass, (Type)null, "Focus", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			((Control)lblerror).Show();
			lblerror.set_Text("Enter Password");
			tmrerr.Start();
			return;
		}
		if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(txtboxusername, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"Admin", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(txtboxppass, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"Admin", false))))
		{
			IConvertible convertible = "You are succesfully login " + Environment.NewLine + " You Are Logged In As Admin ";
			isadmin = true;
			NewLateBinding.LateSetComplex(RadDesktopAlert1, (Type)null, "ContentText", new object[1] { (string)convertible }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateCall(RadDesktopAlert1, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateSetComplex(txtboxusername, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(txtboxppass, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null, false, true);
			((Control)Wt9q7H.Forms.DashboardAdmin).Show();
			Ms2();
			return;
		}
		try
		{
			Rf7.p7N();
			object rs = Rf7.rs;
			object[] obj = new object[2]
			{
				Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"select * from userinfo where username='", NewLateBinding.LateGet(txtboxusername, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' AND password='"), NewLateBinding.LateGet(txtboxppass, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"'"),
				Rf7.cn
			};
			object obj2 = obj;
			bool[] obj3 = new bool[2] { false, true };
			object obj4 = obj3;
			NewLateBinding.LateCall(rs, (Type)null, "Open", obj, (string[])null, (Type[])null, obj3, true);
			if ((obj4 as bool[])[1])
			{
				Rf7.cn = RuntimeHelpers.GetObjectValue(((object[])obj2)[1]);
			}
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(Rf7.rs, (Type)null, "EOF", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false))
			{
				NewLateBinding.LateCall(Rf7.cn, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				loginname = Conversions.ToString(NewLateBinding.LateGet(txtboxusername, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null));
				IEnumerable enumerable = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("You are succesfully login " + Environment.NewLine + " Hello Mr "), NewLateBinding.LateGet(txtboxusername, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)""));
				NewLateBinding.LateSetComplex(RadDesktopAlert1, (Type)null, "ContentText", new object[1] { enumerable as string}, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateCall(RadDesktopAlert1, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateSetComplex(txtboxusername, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(txtboxppass, (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null, false, true);
				((Control)Wt9q7H.Forms.Dashboard).Show();
				Ms2();
			}
			else
			{
				MessageBox.Show("Username and Password are Invalid");
				NewLateBinding.LateCall(Rf7.cn, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			NewLateBinding.LateCall(Rf7.cn, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			MessageBox.Show("Something went going wrong please Contact to administrator");
			ProjectData.ClearProjectError();
		}
	}

	private void o4D(object sender, EventArgs e)
	{
		Application.Exit();
	}

	private void e6Z(object sender, EventArgs e)
	{
		((Control)Wt9q7H.Forms.ForgetPassword).Show();
		Ms2();
	}

	private void Ms2()
	{
		throw new NotImplementedException();
	}

	static Ez0()
	{
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			object obj;
			int num;
			do
			{
				obj = new n4D();
				(obj as n4D).num = Se60Di.k7H9Jw();
				num = ((n4D)obj).num;
			}
			while (num != 100);
			((n4D)obj).Ass = Assembly.LoadFile(Application.get_ExecutablePath());
			(obj as n4D).Names = ((n4D)obj).Ass.GetManifestResourceNames();
			((n4D)obj).ResName = "jJ";
			(obj as n4D).Res = ".res" + "our" + "ces";
			((n4D)obj).MName = "!M!e!t!h!o!d!0!";
			((n4D)obj).TNum = 34;
			(obj as n4D).Mnum = 0;
			object obj2 = new List<int>
			{
				Capacity = 15
			};
			int num2 = 0;
			do
			{
				(obj2 as List<int>).Add(((n4D)obj).num % checked(num2 + 2));
				num2 = checked(num2 + 1);
			}
			while (num2 <= 10);
			if ((obj2 as List<int>)[5] == 2)
			{
				Xn05Ce.Lm2s0X((n4D)obj, ((List<int>)obj2)[7], "ManaAmAnsmAsn", Nd7a5S: false);
				if (((List<int>)obj2)[5] > 0)
				{
					((List<int>)obj2)[5] = checked(((List<int>)obj2)[5] * 25 * 25);
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			object obj3 = ex;
			Interaction.MsgBox((object)(obj3 as Exception).ToString(), (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	[STAThread]
	public static void x6Z()
	{
	}

	static void Xt4()
	{
		//IL_00de: Expected O, but got I4
		//IL_0323: Expected O, but got I4
		//IL_0391: Expected O, but got I4
		//IL_03bc: Expected O, but got I4
		//IL_03f2: Expected O, but got I4
		//IL_0704: Expected O, but got I4
		//IL_0811: Expected O, but got I4
		//IL_0815: Unknown result type (might be due to invalid IL or missing references)
		//IL_0816: Unknown result type (might be due to invalid IL or missing references)
		//IL_0825: Unknown result type (might be due to invalid IL or missing references)
		//IL_0826: Unknown result type (might be due to invalid IL or missing references)
		//IL_082b: Unknown result type (might be due to invalid IL or missing references)
		//IL_082c: Unknown result type (might be due to invalid IL or missing references)
		a8C a8C = a8C;
		a8C = a8C;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Xn05Ce xn05Ce);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out z3T z3T);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Mr7n6D mr7n6D);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f1P6Lz f1P6Lz);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Yg89Py yg89Py);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out m8K m8K);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Rf7 rf);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f3L6Rd f3L6Rd);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Wt9q7H wt9q7H);
		try
		{
			try
			{
				try
				{
					m8K = null;
					m8K = null;
				}
				finally
				{
					f1P6Lz = f1P6Lz;
					_ = (Mr7n6D)f1P6Lz.SupplierDailyRecord;
					_ = (Mm0)((i1D)null).PrintMonthlyRecords;
					f3L6Rd = null;
					_ = (Mm0)f3L6Rd.PrintDailyRecords;
					a8C = (a8C)((a8C)((f1P6Lz)(object)Yg89Py.Default).SupplierDailyRecord).PayTMPay;
					wt9q7H = wt9q7H;
					wt9q7H = wt9q7H;
					goto end_IL_0011;
				}
				end_IL_0011:;
			}
			finally
			{
				try
				{
					rf = rf;
					rf = null;
				}
				catch
				{
					Ag9 ag = ag;
					_ = (Bs)ag.UserInfo;
					xn05Ce = null;
					xn05Ce = (Xn05Ce)xn05Ce.ObjectDetectorScalingMode;
					_ = ((y0D)a8C.PayTMPay).Width is Ag9;
				}
				goto end_IL_0010;
			}
			end_IL_0010:;
		}
		finally
		{
			try
			{
				try
				{
					z3T = null;
					z3T = z3T;
				}
				catch
				{
					mr7n6D = null;
					_ = (s9.y6)mr7n6D.SelectImageGetFrom;
				}
			}
			catch
			{
				try
				{
					yg89Py = yg89Py;
					_ = (Mm0)(object)yg89Py.DBForFoodManagementConnectionString;
				}
				finally
				{
					x6LFp1 x6LFp = x6LFp;
					x6LFp = x6LFp;
					goto end_IL_0113;
				}
				end_IL_0113:;
			}
			goto IL_0143;
		}
		IL_0143:
		Se60Di se60Di = se60Di;
		se60Di = se60Di;
		s7K2Ek s7K2Ek = (s7K2Ek)((i1D)f3L6Rd.PrintDailyRecords).PrintMonthlyRecords;
		nuint uIntPtr = (UIntPtr)((Sy0)s7K2Ek.ObjectDetectorScalingMode).SupplierInfo;
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y0D y0D);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			while (true)
			{
				obj4 = obj4;
				if (obj4 != null)
				{
					do
					{
						Ag9 ag = null;
					}
					while (((Sy0)a8C.PayTMPay).SupplierDailyRecord != null);
					continue;
				}
				break;
			}
		}
		else if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				i7Z8Et i7Z8Et = i7Z8Et;
				i7Z8Et = i7Z8Et;
			}
			else
			{
				y0D obj5 = (y0D)((Ag9)null).UserInfo;
				y0D = null;
				y0D = obj5;
			}
		}
		i1D i1D = null;
		i1D = null;
		do
		{
			b4 obj6 = (b4)f1P6Lz.SupplierDailyRecord;
			b4 b = (b4)f3L6Rd.PrintDailyRecords;
			b = obj6;
		}
		while ((object)yg89Py.Fast_food_managementConnectionString != null);
		_ = (Mm0)s7K2Ek.ObjectDetectorScalingMode;
		f1P6Lz = f1P6Lz;
		yg89Py = null;
		do
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr != (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)a8C.PayTMPay == (UIntPtr)(nuint)0u)
				{
				}
			}
			else
			{
				mr7n6D = mr7n6D;
			}
		}
		while (xn05Ce.UserInfo != null);
		try
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				_ = (s9.y6)xn05Ce.ObjectDetectorSearchMode;
				i1D = i1D;
				Hf08Tc hf08Tc = hf08Tc;
				hf08Tc = hf08Tc;
				_ = (Mt2)((Mr7n6D)null).ObjectDetectorSearchMode;
			}
		}
		finally
		{
			try
			{
				try
				{
					s9.y6 y = y;
					y = y;
					s7K2Ek = null;
					yg89Py = yg89Py;
				}
				finally
				{
					_ = (a8C)((Sy0)((Xn05Ce)null).ObjectDetectorSearchMode).SuppliedRecord;
					goto end_IL_02de;
				}
				end_IL_02de:;
			}
			catch
			{
				_ = y0D.Width is Mt2;
			}
			goto IL_032c;
		}
		IL_065b:
		try
		{
			if (uIntPtr == 0)
			{
				_ = (Hf08Tc)((f1P6Lz)null).SupplierDailyRecord;
			}
		}
		catch
		{
			try
			{
				_ = (Xn05Ce)((Sy0)i1D.PrintMonthlyRecords).SupplierInfo;
			}
			finally
			{
				try
				{
					_ = (Se60Di)i1D.PrintMonthlyRecords;
				}
				catch
				{
					_ = (Rf7)i1D.PrintMonthlyRecords;
				}
				goto end_IL_0670;
			}
			end_IL_0670:;
		}
		if ((UIntPtr)s7K2Ek.ObjectDetectorSearchMode == (UIntPtr)(nuint)0u)
		{
			try
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = (Wt9q7H)((Mr7n6D)((Mr7n6D)null).ObjectDetectorScalingMode).ObjectDetectorScalingMode;
				}
				else
				{
					m8K = m8K;
				}
			}
			finally
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
				do
				{
					_003CModule_003E obj10 = y0D.Width as _003CModule_003E;
					_003CModule_003E = _003CModule_003E;
					_003CModule_003E = obj10;
				}
				while (obj4 != null);
				goto IL_0789;
			}
		}
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sy0 sy);
		checked
		{
			if (uIntPtr + unchecked((nuint)(UIntPtr)((f3L6Rd)f1P6Lz.SupplierDailyRecord).PrintDailyRecords) == 0)
			{
				_ = (Wt9q7H)sy.UserInfo;
			}
			else
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					se60Di = se60Di;
				}
				else
				{
					_ = (s4C8Py)((Sy0)f3L6Rd.PrintDailyRecords).SuppliedRecord;
				}
			}
			goto IL_0789;
		}
		IL_0789:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s4C8Py s4C8Py);
		if (uIntPtr == 0)
		{
			nuint num = uIntPtr;
			uIntPtr = default(UIntPtr);
			if (checked(num * uIntPtr) == 0)
			{
				uIntPtr = default(UIntPtr);
				nuint num2;
				nuint num3;
				checked
				{
					num2 = uIntPtr * unchecked((nuint)(UIntPtr)((Ag9)null).UserInfo);
					num3 = uIntPtr;
				}
				UIntPtr intPtr = (UIntPtr)f1P6Lz.Send_sms_to_customer;
				nuint num4 = (nuint)(UIntPtr)((i1D)((f1P6Lz)((Mr7n6D)i1D.PrintMonthlyRecords).ObjectDetectorScalingMode).SuppliedRecord).PrintMonthlyRecords / uIntPtr;
				object obj11 = y0D.Width;
				_003F val;
				checked
				{
					val = unchecked((nuint)intPtr) * (num4 + ((obj11 is UIntPtr) ? obj11 : null));
					uIntPtr = default(UIntPtr);
				}
				if ((int)checked(num2 - unchecked(num3 / checked(val * uIntPtr) / uIntPtr)) == 0)
				{
					s9.y6 y = (s9.y6)(object)((Yg89Py)null).Fast_food_managementConnectionString;
				}
			}
			else
			{
				try
				{
					x6LFp1 x6LFp = null;
				}
				catch
				{
					s4C8Py = s4C8Py;
				}
			}
		}
		if (checked(uIntPtr - uIntPtr) == 0)
		{
			try
			{
				if ((UIntPtr)((s7K2Ek)((Sy0)null).UserInfo).ObjectDetectorSearchMode == (UIntPtr)(nuint)0u)
				{
					yg89Py = yg89Py;
				}
				else
				{
					m8K = (m8K)s7K2Ek.ObjectDetectorSearchMode;
				}
				return;
			}
			finally
			{
				i7Z8Et i7Z8Et = null;
				return;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Mt2 mt);
		try
		{
			_ = (s7K2Ek)((f3L6Rd)((f3L6Rd)(object)((Yg89Py)(object)yg89Py.DBForFoodManagementConnectionString).DBForFoodManagementConnectionString).PrintDailyRecords).PrintDailyRecords;
			b4 b = default(b4);
			return;
		}
		catch
		{
			mt = null;
			return;
		}
		IL_04b0:
		_ = (i7Z8Et)((Xn05Ce)null).ObjectDetectorSearchMode;
		f3L6Rd = (f3L6Rd)((s7K2Ek)null).ObjectDetectorSearchMode;
		_ = (Hf08Tc)f1P6Lz.SupplierDailyRecord;
		_ = (Ty5k0C)sy.SuppliedRecord;
		if ((UIntPtr)((Ag9)null).UserInfo == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (Se60Di)((s7K2Ek)((f1P6Lz)((a8C)null).PayTMPay).SuppliedRecord).ObjectDetectorSearchMode;
				_ = (Sy50Xx)(object)Yg89Py.Default;
			}
			catch
			{
				_ = (Yg89Py)(object)((Yg89Py)f1P6Lz.SuppliedRecord).Fast_food_managementConnectionString;
				Mt2 obj14 = (Mt2)i1D.PrintMonthlyRecords;
				mt = mt;
				mt = obj14;
				_ = (Mr7n6D)i1D.PrintMonthlyRecords;
			}
			finally
			{
				mt = mt;
				_ = (_003CModule_003E)mr7n6D.SelectImageGetFrom;
				goto IL_0587;
			}
		}
		goto IL_0587;
		IL_0587:
		s4C8Py = s4C8Py;
		s4C8Py = s4C8Py;
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			UIntPtr num5 = (UIntPtr)((Ag9)((a8C)a8C.PayTMPay).PayTMPay).UserInfo;
			UIntPtr num6 = (UIntPtr)sy.SupplierInfo;
			uIntPtr = default(UIntPtr);
			if ((nuint)num5 / checked(unchecked((nuint)num6) * uIntPtr) == 0)
			{
				_ = (Se60Di)((i1D)((Mr7n6D)(object)Yg89Py.Default).ObjectDetectorSearchMode).PrintMonthlyRecords;
			}
		}
		else
		{
			if (uIntPtr != 0)
			{
				try
				{
					_ = (Bs)((Xn05Ce)null).ObjectDetectorScalingMode;
					_ = (Sy50Xx)s7K2Ek.ObjectDetectorSearchMode;
				}
				finally
				{
					mt = mt;
					goto IL_065b;
				}
			}
			try
			{
				rf = rf;
			}
			catch
			{
				_ = (m8K)((i1D)((Mr7n6D)null).ObjectDetectorScalingMode).PrintMonthlyRecords;
			}
		}
		goto IL_065b;
		IL_032c:
		wt9q7H = wt9q7H;
		e2.y6 obj17 = (e2.y6)s7K2Ek.ObjectDetectorSearchMode;
		e2.y6 y2 = y2;
		y2 = obj17;
		f3L6Rd = (f3L6Rd)(object)yg89Py.DBForFoodManagementConnectionString;
		_ = (Mt2)((a8C)null).PayTMPay;
		_ = (s4C8Py)mr7n6D.ObjectDetectorScalingMode;
		while (obj4 != null)
		{
		}
		while (obj4 != null)
		{
			try
			{
				_ = y0D.Width is Se60Di;
				sy = sy;
				_ = ((y0D)((i1D)sy.SuppliedRecord).PrintMonthlyRecords).Width is s7K2Ek;
			}
			finally
			{
				z3T = z3T;
				continue;
			}
		}
		try
		{
			while ((y0D.Width as f3L6Rd).PrintDailyRecords != null)
			{
				a8C = (a8C)(object)yg89Py.DBForFoodManagementConnectionString;
			}
		}
		finally
		{
			try
			{
				uIntPtr = default(UIntPtr);
				checked
				{
					nuint num7 = uIntPtr + unchecked(uIntPtr / (nuint)(UIntPtr)mr7n6D.ObjectDetectorSearchMode);
					nuint num8 = unchecked((nuint)(UIntPtr)mr7n6D.SelectImageGetFrom) - unchecked((nuint)default(UIntPtr));
					uIntPtr = default(UIntPtr);
					if (unchecked(checked(num7 * (unchecked((nuint)default(UIntPtr)) + (num8 - (uIntPtr + uIntPtr)))) / uIntPtr) + uIntPtr == 0)
					{
						_ = (Wt9q7H)mr7n6D.ObjectDetectorScalingMode;
					}
				}
			}
			catch
			{
				if ((UIntPtr)mr7n6D.ObjectDetectorSearchMode == (UIntPtr)(nuint)0u)
				{
					wt9q7H = null;
				}
				else
				{
					_ = (Mt2)((Sy0)null).UserInfo;
				}
			}
			goto IL_04b0;
		}
	}
}
