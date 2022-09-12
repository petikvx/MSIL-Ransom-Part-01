using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using g8GLd9;
using x6T;

namespace p6MRy9;

[DesignerGenerated]
public class s7K2Ek : Form
{
	internal sealed class Dw5b7Z
	{
		internal IContainer icontainer_0;

		internal Label label_0;

		internal object object_0;

		internal object object_1;

		internal Dw5b7Z()
		{
		}
	}

	private IContainer components;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("btnCaptureImage")]
	private object _btnCaptureImage;

	[AccessedThroughProperty("btnChangeCamera")]
	private object _btnChangeCamera;

	[AccessedThroughProperty("RadLabel1")]
	private object _RadLabel1;

	[AccessedThroughProperty("lblFaceCount")]
	private Label _lblFaceCount;

	public bool isImageCapture;

	private object camera;

	public string imagepath;

	private z3T.Rt1 rt1_0;

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

	internal virtual object btnCaptureImage
	{
		get
		{
			return _btnCaptureImage;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_btnCaptureImage = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual object btnClose
	{
		get
		{
			return rt1_0.object_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			rt1_0.object_0 = objectValue;
		}
	}

	internal virtual object btnChangeCamera
	{
		get
		{
			return _btnChangeCamera;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_btnChangeCamera = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual SaveFileDialog SaveFileDialog1
	{
		get
		{
			return rt1_0.saveFileDialog_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			rt1_0.saveFileDialog_0 = ((value is SaveFileDialog) ? value : null);
		}
	}

	internal virtual Timer drawRect
	{
		get
		{
			return rt1_0.timer_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Expected O, but got Unknown
			MulticastDelegate multicastDelegate = new EventHandler(Eb2y6T);
			object timer_ = rt1_0.timer_0;
			if ((int)(Timer)timer_ != 0)
			{
				((Timer)timer_).remove_Tick(multicastDelegate as EventHandler);
			}
			rt1_0.timer_0 = value;
			timer_ = rt1_0.timer_0;
			if (timer_ is Timer)
			{
				((Timer)((timer_ is Timer) ? timer_ : null)).add_Tick(multicastDelegate as EventHandler);
			}
		}
	}

	internal virtual object RadLabel1
	{
		get
		{
			return _RadLabel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_RadLabel1 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual Label lblFaceCount
	{
		get
		{
			return _lblFaceCount;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblFaceCount = value;
		}
	}

	public object ObjectDetectorSearchMode
	{
		get
		{
			return rt1_0.object_1;
		}
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			rt1_0.object_1 = objectValue;
		}
	}

	public object ObjectDetectorScalingMode
	{
		get
		{
			return rt1_0.object_2;
		}
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			rt1_0.object_2 = objectValue;
		}
	}

	public s7K2Ek()
	{
		((Form)this).add_Load((EventHandler)y9TEo1);
		isImageCapture = false;
		q1FSm0();
	}

	protected override void d6BJq3(bool f2YQb1)
	{
		try
		{
			if (f2YQb1 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(f2YQb1);
		}
	}

	private void q1FSm0()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected O, but got Unknown
		//IL_0412: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d0: Expected O, but got Unknown
		//IL_072b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0731: Expected O, but got Unknown
		//IL_08de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a96: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9c: Expected O, but got Unknown
		//IL_0bf7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfd: Expected O, but got Unknown
		//IL_0daa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f62: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f68: Expected O, but got Unknown
		//IL_0f92: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f98: Expected O, but got Unknown
		//IL_10d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_10df: Expected O, but got Unknown
		//IL_118d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1197: Expected O, but got Unknown
		//IL_11a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ad: Expected O, but got Unknown
		//IL_11b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_11c3: Expected O, but got Unknown
		//IL_11e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ea: Expected O, but got Unknown
		components = new Container();
		object obj = new ComponentResourceManager(typeof(s7K2Ek));
		PictureBox1 = new PictureBox();
		btnCaptureImage = RuntimeHelpers.GetObjectValue(new object());
		btnClose = RuntimeHelpers.GetObjectValue(new object());
		btnChangeCamera = RuntimeHelpers.GetObjectValue(new object());
		SaveFileDialog1 = new SaveFileDialog();
		drawRect = new Timer(components);
		RadLabel1 = RuntimeHelpers.GetObjectValue(new object());
		lblFaceCount = new Label();
		((ISupportInitialize)PictureBox1).BeginInit();
		((ISupportInitialize)RadLabel1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)PictureBox1).set_Location(new Point(13, 12));
		((Control)PictureBox1).set_Name("PictureBox1");
		((Control)PictureBox1).set_Size(new Size(1007, 501));
		PictureBox1.set_SizeMode((PictureBoxSizeMode)4);
		PictureBox1.set_TabIndex(0);
		PictureBox1.set_TabStop(false);
		NewLateBinding.LateSetComplex(btnCaptureImage, (Type)null, "Activecolor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCaptureImage, (Type)null, "BackColor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCaptureImage, (Type)null, "BackgroundImageLayout", new object[1] { (object)(ImageLayout)3 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCaptureImage, (Type)null, "BorderRadius", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCaptureImage, (Type)null, "ButtonText", new object[1] { "Capture Image" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCaptureImage, (Type)null, "Cursor", new object[1] { Cursors.get_Hand() }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCaptureImage, (Type)null, "DisabledColor", new object[1] { Color.Gray }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCaptureImage, (Type)null, "Iconcolor", new object[1] { Color.Transparent }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCaptureImage, (Type)null, "Iconimage", new object[1] { (object)(Image)((ComponentResourceManager)obj).GetObject("btnCaptureImage.Iconimage") }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCaptureImage, (Type)null, "Iconimage_right", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCaptureImage, (Type)null, "Iconimage_right_Selected", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCaptureImage, (Type)null, "Iconimage_Selected", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCaptureImage, (Type)null, "IconMarginLeft", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCaptureImage, (Type)null, "IconMarginRight", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCaptureImage, (Type)null, "IconRightVisible", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCaptureImage, (Type)null, "IconRightZoom", new object[1] { 0.0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCaptureImage, (Type)null, "IconVisible", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCaptureImage, (Type)null, "IconZoom", new object[1] { 90.0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCaptureImage, (Type)null, "IsTab", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCaptureImage, (Type)null, "Location", new object[1]
		{
			new Point(13, 520)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCaptureImage, (Type)null, "Margin", new object[1] { (object)new Padding(4) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCaptureImage, (Type)null, "Name", new object[1] { "btnCaptureImage" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCaptureImage, (Type)null, "Normalcolor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCaptureImage, (Type)null, "OnHovercolor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCaptureImage, (Type)null, "OnHoverTextColor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCaptureImage, (Type)null, "selected", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCaptureImage, (Type)null, "Size", new object[1]
		{
			new Size(222, 48)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCaptureImage, (Type)null, "TabIndex", new object[1] { 9 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCaptureImage, (Type)null, "Text", new object[1] { "Capture Image" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCaptureImage, (Type)null, "TextAlign", new object[1] { (object)(ContentAlignment)16 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCaptureImage, (Type)null, "Textcolor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnCaptureImage, (Type)null, "TextFont", new object[1] { (object)new Font("Century Gothic", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "Activecolor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "BackColor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "BackgroundImageLayout", new object[1] { (object)(ImageLayout)3 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "BorderRadius", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "ButtonText", new object[1] { "Close" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "Cursor", new object[1] { Cursors.get_Hand() }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "DisabledColor", new object[1] { Color.Gray }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "Iconcolor", new object[1] { Color.Transparent }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "Iconimage", new object[1] { (object)(Image)(obj as ComponentResourceManager).GetObject("btnClose.Iconimage") }, (string[])null, (Type[])null, false, true);
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
			new Point(776, 520)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "Margin", new object[1] { (object)new Padding(4) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "Name", new object[1] { "btnClose" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "Normalcolor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "OnHovercolor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "OnHoverTextColor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "selected", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "Size", new object[1]
		{
			new Size(188, 48)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "TabIndex", new object[1] { 9 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "Text", new object[1] { "Close" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "TextAlign", new object[1] { (object)(ContentAlignment)16 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "Textcolor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "TextFont", new object[1] { (object)new Font("Century Gothic", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnChangeCamera, (Type)null, "Activecolor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnChangeCamera, (Type)null, "BackColor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnChangeCamera, (Type)null, "BackgroundImageLayout", new object[1] { (object)(ImageLayout)3 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnChangeCamera, (Type)null, "BorderRadius", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnChangeCamera, (Type)null, "ButtonText", new object[1] { "Detect Face" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnChangeCamera, (Type)null, "Cursor", new object[1] { Cursors.get_Hand() }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnChangeCamera, (Type)null, "DisabledColor", new object[1] { Color.Gray }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnChangeCamera, (Type)null, "Iconcolor", new object[1] { Color.Transparent }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnChangeCamera, (Type)null, "Iconimage", new object[1] { (object)(Image)((ComponentResourceManager)obj).GetObject("btnChangeCamera.Iconimage") }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnChangeCamera, (Type)null, "Iconimage_right", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnChangeCamera, (Type)null, "Iconimage_right_Selected", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnChangeCamera, (Type)null, "Iconimage_Selected", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnChangeCamera, (Type)null, "IconMarginLeft", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnChangeCamera, (Type)null, "IconMarginRight", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnChangeCamera, (Type)null, "IconRightVisible", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnChangeCamera, (Type)null, "IconRightZoom", new object[1] { 0.0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnChangeCamera, (Type)null, "IconVisible", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnChangeCamera, (Type)null, "IconZoom", new object[1] { 90.0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnChangeCamera, (Type)null, "IsTab", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnChangeCamera, (Type)null, "Location", new object[1]
		{
			new Point(384, 520)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnChangeCamera, (Type)null, "Margin", new object[1] { (object)new Padding(4) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnChangeCamera, (Type)null, "Name", new object[1] { "btnChangeCamera" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnChangeCamera, (Type)null, "Normalcolor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnChangeCamera, (Type)null, "OnHovercolor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnChangeCamera, (Type)null, "OnHoverTextColor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnChangeCamera, (Type)null, "selected", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnChangeCamera, (Type)null, "Size", new object[1]
		{
			new Size(236, 48)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnChangeCamera, (Type)null, "TabIndex", new object[1] { 9 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnChangeCamera, (Type)null, "Text", new object[1] { "Detect Face" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnChangeCamera, (Type)null, "TextAlign", new object[1] { (object)(ContentAlignment)16 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnChangeCamera, (Type)null, "Textcolor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnChangeCamera, (Type)null, "TextFont", new object[1] { (object)new Font("Century Gothic", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(RadLabel1, (Type)null, "Font", new object[1] { (object)new Font("Segoe UI", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(RadLabel1, (Type)null, "ForeColor", new object[1] { Color.Red }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(RadLabel1, (Type)null, "Location", new object[1]
		{
			new Point(373, 12)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(RadLabel1, (Type)null, "Name", new object[1] { "RadLabel1" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(RadLabel1, (Type)null, "Size", new object[1]
		{
			new Size(221, 18)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(RadLabel1, (Type)null, "TabIndex", new object[1] { 10 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(RadLabel1, (Type)null, "Text", new object[1] { "Please Stand Only one Person In Camera" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(RadLabel1, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null, false, true);
		lblFaceCount.set_AutoSize(true);
		((Control)lblFaceCount).set_Font(new Font("Microsoft Sans Serif", 36f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblFaceCount).set_Location(new Point(13, 13));
		((Control)lblFaceCount).set_Name("lblFaceCount");
		((Control)lblFaceCount).set_Size(new Size(51, 55));
		((Control)lblFaceCount).set_TabIndex(11);
		lblFaceCount.set_Text("0");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.White);
		((Form)this).set_ClientSize(new Size(1039, 581));
		((Control)this).get_Controls().Add((Control)(object)lblFaceCount);
		((Control)this).get_Controls().Add((Control)RadLabel1);
		((Control)this).get_Controls().Add((Control)btnChangeCamera);
		((Control)this).get_Controls().Add((Control)btnClose);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).get_Controls().Add((Control)btnCaptureImage);
		((Control)this).set_Name("CaptureByCamera");
		((Form)this).set_Text("CaptureByCamera");
		((ISupportInitialize)PictureBox1).EndInit();
		((ISupportInitialize)RadLabel1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void y9TEo1(object sender, EventArgs e)
	{
		RuntimeHelpers.GetObjectValue(new object());
		NewLateBinding.LateCall(camera, (Type)null, "Start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void Fg2d6M(object o8Y6Tt, object w4F3Dn)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		try
		{
			PictureBox1.set_Image((Image)(Bitmap)NewLateBinding.LateGet(NewLateBinding.LateGet(w4F3Dn, (Type)null, "Frame", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Clone", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void p1ZMg4(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		Control val = (Control)new PictureBox();
		((PictureBox)val).set_Image(PictureBox1.get_Image());
		IEquatable<string> equatable = Application.get_StartupPath() + "\\Temp\\";
		if (!((ServerComputer)Wt9q7H.Computer).get_FileSystem().DirectoryExists(equatable as string))
		{
			((ServerComputer)Wt9q7H.Computer).get_FileSystem().CreateDirectory((string)equatable);
		}
		object obj = new Random();
		int num = ((Random)obj).Next(0, 100000);
		imagepath = Application.get_StartupPath() + "\\Temp\\" + Conversions.ToString(num) + ".jpeg";
		((PictureBox)((val is PictureBox) ? val : null)).get_Image().Save(imagepath, ImageFormat.get_Jpeg());
		isImageCapture = true;
		((Control)Wt9q7H.Forms.CreateUserForm.UserImage).set_BackgroundImage(PictureBox1.get_Image());
	}

	private void Ao1j7S(object sender, EventArgs e)
	{
		((Control)this).Hide();
		((Control)Wt9q7H.Forms.CreateUserForm).Show();
		NewLateBinding.LateCall(camera, (Type)null, "Stop", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void Ht2x9Y(object sender, EventArgs e)
	{
		drawRect.Start();
	}

	private void Eb2y6T(object sender, EventArgs e)
	{
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.GetObjectValue(new object());
		object obj = default(object);
		NewLateBinding.LateSet(obj, (Type)null, "SearchMode", new object[1] { NewLateBinding.LateGet(ObjectDetectorSearchMode, (Type)null, "Average", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(obj, (Type)null, "ScalingFactor", new object[1] { 1.5 }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(obj, (Type)null, "ScalingMode", new object[1] { NewLateBinding.LateGet(ObjectDetectorScalingMode, (Type)null, "GreaterToSmaller", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(obj, (Type)null, "UseParallelProcessing", new object[1] { true }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(obj, (Type)null, "Suppression", new object[1] { 1.5 }, (string[])null, (Type[])null);
		Control pictureBox;
		object[] obj2 = new object[1] { ((PictureBox)(pictureBox = (Control)(object)PictureBox1)).get_Image() };
		Array array = obj2;
		bool[] obj3 = new bool[1] { true };
		object obj4 = obj3;
		object obj5 = NewLateBinding.LateGet(obj, (Type)null, "ProcessFrame", obj2, (string[])null, (Type[])null, obj3);
		if ((obj4 as bool[])[0])
		{
			((PictureBox)((pictureBox is PictureBox) ? pictureBox : null)).set_Image((Image)Conversions.ChangeType(RuntimeHelpers.GetObjectValue((array as object[])[0]), typeof(Image)));
		}
		Array array2 = (Rectangle[])obj5;
		IDeviceContext val = (IDeviceContext)(object)Graphics.FromImage(PictureBox1.get_Image());
		if ((array2 as Rectangle[]).Count() > 1)
		{
			NewLateBinding.LateCall(RadLabel1, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		else
		{
			NewLateBinding.LateCall(RadLabel1, (Type)null, "Hide", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		int num = 0;
		object obj6 = array2 as Rectangle[];
		checked
		{
			for (int i = 0; i < (obj6 as Rectangle[]).Length; i++)
			{
				Rectangle rectangle = ((Rectangle[])obj6)[i];
				((Graphics)val).DrawRectangle(Pens.get_White(), rectangle);
				num++;
			}
			lblFaceCount.set_Text(Conversions.ToString(num));
			((Graphics)val).Dispose();
			((Control)PictureBox1).Invalidate();
		}
	}

	internal static int Kz93Nk(int Zo09Fi, int Ex8c0B, object c9K5Nf, object Qq18Jx, int Xr49En)
	{
		return Xr49En switch
		{
			2 => Conversions.ToInteger(Operators.OrObject(Operators.AndObject(c9K5Nf, Operators.NotObject(Qq18Jx)), Operators.AndObject(Operators.NotObject(c9K5Nf), Qq18Jx))), 
			1 => Zo09Fi % Ex8c0B, 
			_ => 0, 
		};
	}
}
