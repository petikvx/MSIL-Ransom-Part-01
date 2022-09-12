using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.VisualBasic.CompilerServices;
using Sn7x6Z;
using g8GLd9;

namespace t5C8Kg;

[DesignerGenerated]
public class f1P6Lz : Form
{
	internal sealed class Ki1
	{
		internal Button button_0;

		internal PrintPreviewDialog printPreviewDialog_0;

		internal PrintDialog printDialog_0;

		internal Chart chart_0;

		internal Ki1()
		{
		}
	}

	private IContainer components;

	[AccessedThroughProperty("btnLogout")]
	private object _btnLogout;

	[AccessedThroughProperty("Panel2")]
	private Panel _Panel2;

	[AccessedThroughProperty("BunifuCustomLabel1")]
	private object _BunifuCustomLabel1;

	[AccessedThroughProperty("btnSupplierDailyRecord")]
	private object _btnSupplierDailyRecord;

	[AccessedThroughProperty("tileMonthlyRecors")]
	private object _tileMonthlyRecors;

	[AccessedThroughProperty("btnSuppliedAllProduct")]
	private object _btnSuppliedAllProduct;

	[AccessedThroughProperty("btnSupplyProduct")]
	private object _btnSupplyProduct;

	[AccessedThroughProperty("Office2007BlackTheme1")]
	private object _Office2007BlackTheme1;

	private object _SupplierDailyRecord;

	private object _SuppliedRecord;

	private Se60Di.q0R9Kb q0R9Kb_0 = new Se60Di.q0R9Kb();

	internal virtual object btnLogout
	{
		get
		{
			return _btnLogout;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_btnLogout = RuntimeHelpers.GetObjectValue(value);
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

	internal virtual PictureBox PictureBox1
	{
		get
		{
			return q0R9Kb_0.pictureBox_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected O, but got Unknown
			q0R9Kb_0.pictureBox_0 = value;
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

	internal virtual ImageList ImageList1
	{
		get
		{
			return q0R9Kb_0.imageList_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			q0R9Kb_0.imageList_0 = ((value is ImageList) ? value : null);
		}
	}

	internal virtual PictureBox imgBox
	{
		get
		{
			return q0R9Kb_0.pictureBox_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected O, but got Unknown
			q0R9Kb_0.pictureBox_1 = value;
		}
	}

	internal virtual object btnSupplierDailyRecord
	{
		get
		{
			return _btnSupplierDailyRecord;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_btnSupplierDailyRecord = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual object tileMonthlyRecors
	{
		get
		{
			return _tileMonthlyRecors;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_tileMonthlyRecors = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual object btnSuppliedAllProduct
	{
		get
		{
			return _btnSuppliedAllProduct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_btnSuppliedAllProduct = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual object tileDailyRecors
	{
		get
		{
			return q0R9Kb_0.object_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			q0R9Kb_0.object_0 = objectValue;
		}
	}

	internal virtual object tileOrder
	{
		get
		{
			return q0R9Kb_0.object_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			q0R9Kb_0.object_1 = objectValue;
		}
	}

	internal virtual object btnSupplyProduct
	{
		get
		{
			return _btnSupplyProduct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_btnSupplyProduct = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual Panel Panel1
	{
		get
		{
			return q0R9Kb_0.panel_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			q0R9Kb_0.panel_0 = ((value is Panel) ? value : null);
		}
	}

	internal virtual object RadSeparator2
	{
		get
		{
			return q0R9Kb_0.object_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			q0R9Kb_0.object_2 = objectValue;
		}
	}

	internal virtual object Office2007BlackTheme1
	{
		get
		{
			return _Office2007BlackTheme1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Office2007BlackTheme1 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual object BunifuTileButton1
	{
		get
		{
			return q0R9Kb_0.object_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			q0R9Kb_0.object_3 = objectValue;
		}
	}

	public object SupplierDailyRecord
	{
		get
		{
			return _SupplierDailyRecord;
		}
		set
		{
			_SupplierDailyRecord = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object SuppliedRecord
	{
		get
		{
			return _SuppliedRecord;
		}
		set
		{
			_SuppliedRecord = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object Send_sms_to_customer
	{
		get
		{
			return q0R9Kb_0.object_4;
		}
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			q0R9Kb_0.object_4 = objectValue;
		}
	}

	public f1P6Lz()
	{
		((Form)this).add_Load((EventHandler)Zd0);
		St9r6N();
	}

	protected override void t2GFn9(bool m6W8Rc)
	{
		try
		{
			if (m6W8Rc && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(m6W8Rc);
		}
	}

	private void St9r6N()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected O, but got Unknown
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Expected O, but got Unknown
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0493: Expected O, but got Unknown
		//IL_04e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ee: Expected O, but got Unknown
		//IL_069b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0852: Unknown result type (might be due to invalid IL or missing references)
		//IL_0858: Expected O, but got Unknown
		//IL_091a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0920: Expected O, but got Unknown
		//IL_0975: Unknown result type (might be due to invalid IL or missing references)
		//IL_097b: Expected O, but got Unknown
		//IL_0a59: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba2: Expected O, but got Unknown
		//IL_0bf7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfd: Expected O, but got Unknown
		//IL_0cdb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e24: Expected O, but got Unknown
		//IL_0e79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e7f: Expected O, but got Unknown
		//IL_0f5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a6: Expected O, but got Unknown
		//IL_10fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1101: Expected O, but got Unknown
		//IL_11df: Unknown result type (might be due to invalid IL or missing references)
		//IL_1322: Unknown result type (might be due to invalid IL or missing references)
		//IL_1328: Expected O, but got Unknown
		//IL_137d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1383: Expected O, but got Unknown
		//IL_145e: Unknown result type (might be due to invalid IL or missing references)
		//IL_15a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_15a7: Expected O, but got Unknown
		//IL_15fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1602: Expected O, but got Unknown
		//IL_16de: Unknown result type (might be due to invalid IL or missing references)
		//IL_1789: Unknown result type (might be due to invalid IL or missing references)
		//IL_1793: Expected O, but got Unknown
		//IL_17a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_17ae: Expected O, but got Unknown
		//IL_17bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_17c9: Expected O, but got Unknown
		//IL_17da: Unknown result type (might be due to invalid IL or missing references)
		//IL_17e4: Expected O, but got Unknown
		//IL_17f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_17ff: Expected O, but got Unknown
		//IL_1810: Unknown result type (might be due to invalid IL or missing references)
		//IL_181a: Expected O, but got Unknown
		//IL_182b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1835: Expected O, but got Unknown
		//IL_1846: Unknown result type (might be due to invalid IL or missing references)
		//IL_1850: Expected O, but got Unknown
		//IL_1a58: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a5e: Expected O, but got Unknown
		//IL_1ab3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ab9: Expected O, but got Unknown
		//IL_1b97: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c96: Expected O, but got Unknown
		//IL_1cc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cce: Expected O, but got Unknown
		components = new Container();
		object obj = new ComponentResourceManager(typeof(f1P6Lz));
		Panel2 = new Panel();
		ImageList1 = new ImageList(components);
		imgBox = new PictureBox();
		PictureBox1 = new PictureBox();
		((ISupportInitialize)imgBox).BeginInit();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)Panel1).SuspendLayout();
		((ISupportInitialize)RadSeparator2).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Panel2).set_BackColor(Color.FromArgb(174, 8, 40));
		((Control)Panel2).set_Dock((DockStyle)1);
		((Control)Panel2).set_Location(new Point(213, 0));
		((Control)Panel2).set_Name("Panel2");
		((Control)Panel2).set_Size(new Size(868, 25));
		((Control)Panel2).set_TabIndex(5);
		NewLateBinding.LateSetComplex(BunifuCustomLabel1, (Type)null, "AutoSize", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(BunifuCustomLabel1, (Type)null, "BackColor", new object[1] { Color.FromArgb(174, 8, 40) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(BunifuCustomLabel1, (Type)null, "Font", new object[1] { (object)new Font("Century Gothic", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(BunifuCustomLabel1, (Type)null, "Location", new object[1]
		{
			new Point(343, 113)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(BunifuCustomLabel1, (Type)null, "Name", new object[1] { "BunifuCustomLabel1" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(BunifuCustomLabel1, (Type)null, "Size", new object[1]
		{
			new Size(231, 19)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(BunifuCustomLabel1, (Type)null, "TabIndex", new object[1] { 3 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(BunifuCustomLabel1, (Type)null, "Text", new object[1] { "PATIL MAMA VADAPAV WALE" }, (string[])null, (Type[])null, false, true);
		ImageList1.set_ColorDepth((ColorDepth)8);
		ImageList1.set_ImageSize(new Size(16, 16));
		ImageList1.set_TransparentColor(Color.Transparent);
		imgBox.set_Image((Image)((ComponentResourceManager)obj).GetObject("imgBox.Image"));
		((Control)imgBox).set_Location(new Point(223, 176));
		((Control)imgBox).set_Name("imgBox");
		((Control)imgBox).set_Size(new Size(846, 431));
		imgBox.set_SizeMode((PictureBoxSizeMode)1);
		imgBox.set_TabIndex(7);
		imgBox.set_TabStop(false);
		((Control)PictureBox1).set_BackColor(Color.FromArgb(174, 8, 40));
		((Control)PictureBox1).set_Location(new Point(326, 25));
		((Control)PictureBox1).set_Name("PictureBox1");
		((Control)PictureBox1).set_Size(new Size(158, 145));
		PictureBox1.set_TabIndex(6);
		PictureBox1.set_TabStop(false);
		NewLateBinding.LateSetComplex(btnLogout, (Type)null, "Activecolor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnLogout, (Type)null, "BackColor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnLogout, (Type)null, "BackgroundImageLayout", new object[1] { (object)(ImageLayout)3 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnLogout, (Type)null, "BorderRadius", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnLogout, (Type)null, "ButtonText", new object[1] { "Logout" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnLogout, (Type)null, "Cursor", new object[1] { Cursors.get_Hand() }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnLogout, (Type)null, "DisabledColor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnLogout, (Type)null, "Font", new object[1] { (object)new Font("Century Gothic", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnLogout, (Type)null, "Iconcolor", new object[1] { Color.Transparent }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnLogout, (Type)null, "Iconimage", new object[1] { (object)(Image)((ComponentResourceManager)obj).GetObject("btnLogout.Iconimage") }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnLogout, (Type)null, "Iconimage_right", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnLogout, (Type)null, "Iconimage_right_Selected", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnLogout, (Type)null, "Iconimage_Selected", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnLogout, (Type)null, "IconMarginLeft", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnLogout, (Type)null, "IconMarginRight", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnLogout, (Type)null, "IconRightVisible", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnLogout, (Type)null, "IconRightZoom", new object[1] { 0.0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnLogout, (Type)null, "IconVisible", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnLogout, (Type)null, "IconZoom", new object[1] { 90.0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnLogout, (Type)null, "IsTab", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnLogout, (Type)null, "Location", new object[1]
		{
			new Point(915, 113)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnLogout, (Type)null, "Margin", new object[1] { (object)new Padding(3, 4, 3, 4) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnLogout, (Type)null, "Name", new object[1] { "btnLogout" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnLogout, (Type)null, "Normalcolor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnLogout, (Type)null, "OnHovercolor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnLogout, (Type)null, "OnHoverTextColor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnLogout, (Type)null, "selected", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnLogout, (Type)null, "Size", new object[1]
		{
			new Size(154, 41)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnLogout, (Type)null, "TabIndex", new object[1] { 2 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnLogout, (Type)null, "Text", new object[1] { "Logout" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnLogout, (Type)null, "TextAlign", new object[1] { (object)(ContentAlignment)16 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnLogout, (Type)null, "Textcolor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnLogout, (Type)null, "TextFont", new object[1] { (object)new Font("Century Gothic", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSupplierDailyRecord, (Type)null, "BackColor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSupplierDailyRecord, (Type)null, "color", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSupplierDailyRecord, (Type)null, "colorActive", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSupplierDailyRecord, (Type)null, "Cursor", new object[1] { Cursors.get_Hand() }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSupplierDailyRecord, (Type)null, "Font", new object[1] { (object)new Font("Century Gothic", 15.75f) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSupplierDailyRecord, (Type)null, "ForeColor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSupplierDailyRecord, (Type)null, "Image", new object[1] { (object)(Image)((ComponentResourceManager)obj).GetObject("btnSupplierDailyRecord.Image") }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSupplierDailyRecord, (Type)null, "ImagePosition", new object[1] { 20 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSupplierDailyRecord, (Type)null, "ImageZoom", new object[1] { 50 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSupplierDailyRecord, (Type)null, "LabelPosition", new object[1] { 41 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSupplierDailyRecord, (Type)null, "LabelText", new object[1] { "Supplier Daily Details" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSupplierDailyRecord, (Type)null, "Location", new object[1]
		{
			new Point(0, 423)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSupplierDailyRecord, (Type)null, "Margin", new object[1] { (object)new Padding(6) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSupplierDailyRecord, (Type)null, "Name", new object[1] { "btnSupplierDailyRecord" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSupplierDailyRecord, (Type)null, "Size", new object[1]
		{
			new Size(213, 37)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSupplierDailyRecord, (Type)null, "TabIndex", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(tileMonthlyRecors, (Type)null, "BackColor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(tileMonthlyRecors, (Type)null, "color", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(tileMonthlyRecors, (Type)null, "colorActive", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(tileMonthlyRecors, (Type)null, "Cursor", new object[1] { Cursors.get_Hand() }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(tileMonthlyRecors, (Type)null, "Font", new object[1] { (object)new Font("Century Gothic", 15.75f) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(tileMonthlyRecors, (Type)null, "ForeColor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(tileMonthlyRecors, (Type)null, "Image", new object[1] { (object)(Image)((ComponentResourceManager)obj).GetObject("tileMonthlyRecors.Image") }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(tileMonthlyRecors, (Type)null, "ImagePosition", new object[1] { 20 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(tileMonthlyRecors, (Type)null, "ImageZoom", new object[1] { 50 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(tileMonthlyRecors, (Type)null, "LabelPosition", new object[1] { 41 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(tileMonthlyRecors, (Type)null, "LabelText", new object[1] { "Monthly Record" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(tileMonthlyRecors, (Type)null, "Location", new object[1]
		{
			new Point(2, 374)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(tileMonthlyRecors, (Type)null, "Margin", new object[1] { (object)new Padding(6) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(tileMonthlyRecors, (Type)null, "Name", new object[1] { "tileMonthlyRecors" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(tileMonthlyRecors, (Type)null, "Size", new object[1]
		{
			new Size(212, 37)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(tileMonthlyRecors, (Type)null, "TabIndex", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSuppliedAllProduct, (Type)null, "BackColor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSuppliedAllProduct, (Type)null, "color", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSuppliedAllProduct, (Type)null, "colorActive", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSuppliedAllProduct, (Type)null, "Cursor", new object[1] { Cursors.get_Hand() }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSuppliedAllProduct, (Type)null, "Font", new object[1] { (object)new Font("Century Gothic", 15.75f) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSuppliedAllProduct, (Type)null, "ForeColor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSuppliedAllProduct, (Type)null, "Image", new object[1] { (object)(Image)(obj as ComponentResourceManager).GetObject("btnSuppliedAllProduct.Image") }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSuppliedAllProduct, (Type)null, "ImagePosition", new object[1] { 20 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSuppliedAllProduct, (Type)null, "ImageZoom", new object[1] { 50 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSuppliedAllProduct, (Type)null, "LabelPosition", new object[1] { 41 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSuppliedAllProduct, (Type)null, "LabelText", new object[1] { "All Supplied" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSuppliedAllProduct, (Type)null, "Location", new object[1]
		{
			new Point(2, 472)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSuppliedAllProduct, (Type)null, "Margin", new object[1] { (object)new Padding(6) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSuppliedAllProduct, (Type)null, "Name", new object[1] { "btnSuppliedAllProduct" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSuppliedAllProduct, (Type)null, "Size", new object[1]
		{
			new Size(212, 38)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSuppliedAllProduct, (Type)null, "TabIndex", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(tileDailyRecors, (Type)null, "BackColor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(tileDailyRecors, (Type)null, "color", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(tileDailyRecors, (Type)null, "colorActive", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(tileDailyRecors, (Type)null, "Cursor", new object[1] { Cursors.get_Hand() }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(tileDailyRecors, (Type)null, "Font", new object[1] { (object)new Font("Century Gothic", 15.75f) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(tileDailyRecors, (Type)null, "ForeColor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(tileDailyRecors, (Type)null, "Image", new object[1] { (object)(Image)((ComponentResourceManager)obj).GetObject("tileDailyRecors.Image") }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(tileDailyRecors, (Type)null, "ImagePosition", new object[1] { 20 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(tileDailyRecors, (Type)null, "ImageZoom", new object[1] { 50 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(tileDailyRecors, (Type)null, "LabelPosition", new object[1] { 41 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(tileDailyRecors, (Type)null, "LabelText", new object[1] { "Daily Records" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(tileDailyRecors, (Type)null, "Location", new object[1]
		{
			new Point(0, 325)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(tileDailyRecors, (Type)null, "Margin", new object[1] { (object)new Padding(6) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(tileDailyRecors, (Type)null, "Name", new object[1] { "tileDailyRecors" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(tileDailyRecors, (Type)null, "Size", new object[1]
		{
			new Size(213, 37)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(tileDailyRecors, (Type)null, "TabIndex", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(tileOrder, (Type)null, "BackColor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(tileOrder, (Type)null, "color", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(tileOrder, (Type)null, "colorActive", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(tileOrder, (Type)null, "Cursor", new object[1] { Cursors.get_Hand() }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(tileOrder, (Type)null, "Font", new object[1] { (object)new Font("Century Gothic", 15.75f) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(tileOrder, (Type)null, "ForeColor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(tileOrder, (Type)null, "Image", new object[1] { (object)(Image)(obj as ComponentResourceManager).GetObject("tileOrder.Image") }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(tileOrder, (Type)null, "ImagePosition", new object[1] { 20 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(tileOrder, (Type)null, "ImageZoom", new object[1] { 50 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(tileOrder, (Type)null, "LabelPosition", new object[1] { 41 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(tileOrder, (Type)null, "LabelText", new object[1] { "Order" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(tileOrder, (Type)null, "Location", new object[1]
		{
			new Point(0, 64)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(tileOrder, (Type)null, "Margin", new object[1] { (object)new Padding(6) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(tileOrder, (Type)null, "Name", new object[1] { "tileOrder" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(tileOrder, (Type)null, "Size", new object[1]
		{
			new Size(211, 37)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(tileOrder, (Type)null, "TabIndex", new object[1] { 1 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSupplyProduct, (Type)null, "BackColor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSupplyProduct, (Type)null, "color", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSupplyProduct, (Type)null, "colorActive", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSupplyProduct, (Type)null, "Cursor", new object[1] { Cursors.get_Hand() }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSupplyProduct, (Type)null, "Font", new object[1] { (object)new Font("Century Gothic", 15.75f) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSupplyProduct, (Type)null, "ForeColor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSupplyProduct, (Type)null, "Image", new object[1] { (object)(Image)(obj as ComponentResourceManager).GetObject("btnSupplyProduct.Image") }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSupplyProduct, (Type)null, "ImagePosition", new object[1] { 20 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSupplyProduct, (Type)null, "ImageZoom", new object[1] { 50 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSupplyProduct, (Type)null, "LabelPosition", new object[1] { 41 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSupplyProduct, (Type)null, "LabelText", new object[1] { "Supply" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSupplyProduct, (Type)null, "Location", new object[1]
		{
			new Point(-6, 113)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSupplyProduct, (Type)null, "Margin", new object[1] { (object)new Padding(6) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSupplyProduct, (Type)null, "Name", new object[1] { "btnSupplyProduct" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSupplyProduct, (Type)null, "Size", new object[1]
		{
			new Size(220, 37)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnSupplyProduct, (Type)null, "TabIndex", new object[1] { 8 }, (string[])null, (Type[])null, false, true);
		((Control)Panel1).set_BackColor(Color.Black);
		((Control)Panel1).get_Controls().Add((Control)BunifuTileButton1);
		((Control)Panel1).get_Controls().Add((Control)btnSupplyProduct);
		((Control)Panel1).get_Controls().Add((Control)RadSeparator2);
		((Control)Panel1).get_Controls().Add((Control)tileOrder);
		((Control)Panel1).get_Controls().Add((Control)tileDailyRecors);
		((Control)Panel1).get_Controls().Add((Control)btnSuppliedAllProduct);
		((Control)Panel1).get_Controls().Add((Control)tileMonthlyRecors);
		((Control)Panel1).get_Controls().Add((Control)btnSupplierDailyRecord);
		((Control)Panel1).set_Dock((DockStyle)3);
		((Control)Panel1).set_ForeColor(Color.Chocolate);
		((Control)Panel1).set_Location(new Point(0, 0));
		((Control)Panel1).set_Name("Panel1");
		((Control)Panel1).set_Size(new Size(213, 616));
		((Control)Panel1).set_TabIndex(4);
		NewLateBinding.LateSetComplex(RadSeparator2, (Type)null, "Location", new object[1]
		{
			new Point(0, 244)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(RadSeparator2, (Type)null, "Name", new object[1] { "RadSeparator2" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(RadSeparator2, (Type)null, "Size", new object[1]
		{
			new Size(217, 10)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(RadSeparator2, (Type)null, "TabIndex", new object[1] { 9 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(RadSeparator2, (Type)null, "Text", new object[1] { "RadSeparator2" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(RadSeparator2, (Type)null, "ThemeName", new object[1] { "Office2010Black" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(BunifuTileButton1, (Type)null, "BackColor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(BunifuTileButton1, (Type)null, "color", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(BunifuTileButton1, (Type)null, "colorActive", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(BunifuTileButton1, (Type)null, "Cursor", new object[1] { Cursors.get_Hand() }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(BunifuTileButton1, (Type)null, "Font", new object[1] { (object)new Font("Century Gothic", 15.75f) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(BunifuTileButton1, (Type)null, "ForeColor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(BunifuTileButton1, (Type)null, "Image", new object[1] { (object)(Image)(obj as ComponentResourceManager).GetObject("BunifuTileButton1.Image") }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(BunifuTileButton1, (Type)null, "ImagePosition", new object[1] { 20 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(BunifuTileButton1, (Type)null, "ImageZoom", new object[1] { 50 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(BunifuTileButton1, (Type)null, "LabelPosition", new object[1] { 41 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(BunifuTileButton1, (Type)null, "LabelText", new object[1] { "Send SMS" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(BunifuTileButton1, (Type)null, "Location", new object[1]
		{
			new Point(0, 167)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(BunifuTileButton1, (Type)null, "Margin", new object[1] { (object)new Padding(6) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(BunifuTileButton1, (Type)null, "Name", new object[1] { "BunifuTileButton1" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(BunifuTileButton1, (Type)null, "Size", new object[1]
		{
			new Size(211, 37)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(BunifuTileButton1, (Type)null, "TabIndex", new object[1] { 10 }, (string[])null, (Type[])null, false, true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.White);
		((Form)this).set_ClientSize(new Size(1081, 616));
		((Control)this).get_Controls().Add((Control)(object)Panel2);
		((Control)this).get_Controls().Add((Control)(object)imgBox);
		((Control)this).get_Controls().Add((Control)BunifuCustomLabel1);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Control)this).get_Controls().Add((Control)btnLogout);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Dashboard");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Dashboard");
		((ISupportInitialize)imgBox).EndInit();
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)Panel1).ResumeLayout(false);
		((ISupportInitialize)RadSeparator2).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Fw3(object sender, EventArgs e)
	{
		((Control)Wt9q7H.Forms.MainForm).Show();
		((Control)this).Hide();
	}

	private void Zd0(object sender, EventArgs e)
	{
		NewLateBinding.LateSetComplex(BunifuCustomLabel1, (Type)null, "Text", new object[1] { "PATIL MAMA " + Environment.NewLine + "VADAPAV WALE" }, (string[])null, (Type[])null, false, true);
		object obj = new Random();
		(obj as Random).Next(0, 3);
	}

	private void s0H(object sender, EventArgs e)
	{
		((Control)Wt9q7H.Forms.BuySupply).Show();
		((Control)this).Hide();
	}

	private void j9M(object sender, EventArgs e)
	{
		((Control)Wt9q7H.Forms.DailyRecords).Show();
		((Control)this).Hide();
	}

	private void Tr2(object sender, EventArgs e)
	{
		((Control)Wt9q7H.Forms.MonthlyData).Show();
		((Control)this).Hide();
	}

	private void g7N(object sender, EventArgs e)
	{
		NewLateBinding.LateCall(SupplierDailyRecord, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		((Control)this).Hide();
	}

	private void o2F(object sender, EventArgs e)
	{
		NewLateBinding.LateCall(SuppliedRecord, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		((Control)this).Hide();
	}

	private void Sr9(object sender, EventArgs e)
	{
		Application.Restart();
	}

	private void e0N(object sender, EventArgs e)
	{
		NewLateBinding.LateCall(Send_sms_to_customer, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		((Control)this).Hide();
	}
}
