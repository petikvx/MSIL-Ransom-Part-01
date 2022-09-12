using System;
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
using Bo6;
using Dp4o9T;
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

namespace Dt7;

[DesignerGenerated]
public class Ag9 : Form
{
	[StructLayout(LayoutKind.Auto)]
	internal struct s8
	{
		internal IContainer icontainer_0;

		internal Chart chart_0;

		internal Panel panel_0;

		internal object object_0;
	}

	internal sealed class o6
	{
		internal object object_0;

		internal object object_1;

		internal Label label_0;

		internal Label label_1;

		internal object object_2;

		internal Timer timer_0;

		internal Panel panel_0;

		internal object object_3;

		internal object object_4;

		internal o6()
		{
		}
	}

	[AccessedThroughProperty("gridviewUserName")]
	private object _gridviewUserName;

	[AccessedThroughProperty("btnRefresh")]
	private object _btnRefresh;

	[AccessedThroughProperty("btnClose")]
	private object _btnClose;

	[AccessedThroughProperty("lblname")]
	private Label _lblname;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("lblTotal")]
	private Label _lblTotal;

	public string name;

	private object _UserInfo;

	private s8 s8_0;

	internal virtual Chart Chart1
	{
		get
		{
			return s8_0.chart_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected O, but got Unknown
			s8_0.chart_0 = value;
		}
	}

	internal virtual object gridviewUserName
	{
		get
		{
			return _gridviewUserName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_gridviewUserName = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual object btnRefresh
	{
		get
		{
			return _btnRefresh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_btnRefresh = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual object btnClose
	{
		get
		{
			return _btnClose;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_btnClose = RuntimeHelpers.GetObjectValue(value);
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

	internal virtual Panel Panel2
	{
		get
		{
			return s8_0.panel_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			s8_0.panel_0 = ((value is Panel) ? value : null);
		}
	}

	internal virtual object WindowsUIButtonPanel3
	{
		get
		{
			return s8_0.object_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			s8_0.object_0 = objectValue;
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

	public Ag9()
	{
		((Form)this).add_Load((EventHandler)Yk);
		name = "";
		e1();
	}

	protected override void q0K(bool r4K)
	{
		try
		{
			if (r4K && s8_0.icontainer_0 != null)
			{
				s8_0.icontainer_0.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(r4K);
		}
	}

	private void e1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected O, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0422: Unknown result type (might be due to invalid IL or missing references)
		//IL_0428: Expected O, but got Unknown
		//IL_075e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0764: Expected O, but got Unknown
		//IL_08bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c5: Expected O, but got Unknown
		//IL_0bfb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c01: Expected O, but got Unknown
		//IL_0c26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c30: Expected O, but got Unknown
		//IL_0caa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb4: Expected O, but got Unknown
		//IL_0e61: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e6b: Expected O, but got Unknown
		//IL_0f1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f29: Expected O, but got Unknown
		//IL_0f68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f72: Expected O, but got Unknown
		//IL_0f7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f88: Expected O, but got Unknown
		//IL_0f94: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f9e: Expected O, but got Unknown
		object obj = (object)new ChartArea();
		ChartNamedElement val = (ChartNamedElement)new Legend();
		DataPointCustomProperties val2 = (DataPointCustomProperties)new Series();
		object obj2 = new ComponentResourceManager(typeof(Ag9));
		Chart1 = new Chart();
		lblname = new Label();
		Label1 = new Label();
		Panel2 = new Panel();
		lblTotal = new Label();
		((ISupportInitialize)Chart1).BeginInit();
		((ISupportInitialize)gridviewUserName).BeginInit();
		((ISupportInitialize)NewLateBinding.LateGet(gridviewUserName, (Type)null, "MasterTemplate", new object[0], (string[])null, (Type[])null, (bool[])null)).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Chart1).set_BackgroundImageLayout((ImageLayout)0);
		Chart1.set_BackSecondaryColor(Color.Black);
		((ChartArea)((obj is ChartArea) ? obj : null)).set_Name("ChartArea1");
		((Collection<ChartArea>)(object)Chart1.get_ChartAreas()).Add((ChartArea)obj);
		((Legend)val).set_Name("Legend1");
		((Collection<Legend>)(object)Chart1.get_Legends()).Add((Legend)val);
		((Control)Chart1).set_Location(new Point(464, 170));
		((Control)Chart1).set_Name("Chart1");
		((Series)((val2 is Series) ? val2 : null)).set_ChartArea("ChartArea1");
		((Series)val2).set_Legend("Legend1");
		((Series)((val2 is Series) ? val2 : null)).set_Name("User Record");
		((Collection<Series>)(object)Chart1.get_Series()).Add((Series)(object)((val2 is Series) ? val2 : null));
		Chart1.set_Size(new Size(638, 408));
		((Control)Chart1).set_TabIndex(8);
		((Control)Chart1).set_Text("Chart1");
		NewLateBinding.LateSetComplex(gridviewUserName, (Type)null, "Location", new object[1]
		{
			new Point(12, 31)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(gridviewUserName, (Type)null, "MasterTemplate", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "AllowAddNewRow", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(gridviewUserName, (Type)null, "Name", new object[1] { "gridviewUserName" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(gridviewUserName, (Type)null, "ReadOnly", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(gridviewUserName, (Type)null, "Size", new object[1]
		{
			new Size(442, 566)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(gridviewUserName, (Type)null, "TabIndex", new object[1] { 7 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(gridviewUserName, (Type)null, "Text", new object[1] { "grdviewDailyRecord" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnRefresh, (Type)null, "Activecolor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnRefresh, (Type)null, "BackColor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnRefresh, (Type)null, "BackgroundImageLayout", new object[1] { (object)(ImageLayout)3 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnRefresh, (Type)null, "BorderRadius", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnRefresh, (Type)null, "ButtonText", new object[1] { "Refresh" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnRefresh, (Type)null, "Cursor", new object[1] { Cursors.get_Hand() }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnRefresh, (Type)null, "DisabledColor", new object[1] { Color.Gray }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnRefresh, (Type)null, "Iconcolor", new object[1] { Color.Transparent }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnRefresh, (Type)null, "Iconimage", new object[1] { (object)(Image)(obj2 as ComponentResourceManager).GetObject("btnRefresh.Iconimage") }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnRefresh, (Type)null, "Iconimage_right", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnRefresh, (Type)null, "Iconimage_right_Selected", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnRefresh, (Type)null, "Iconimage_Selected", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnRefresh, (Type)null, "IconMarginLeft", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnRefresh, (Type)null, "IconMarginRight", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnRefresh, (Type)null, "IconRightVisible", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnRefresh, (Type)null, "IconRightZoom", new object[1] { 0.0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnRefresh, (Type)null, "IconVisible", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnRefresh, (Type)null, "IconZoom", new object[1] { 90.0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnRefresh, (Type)null, "IsTab", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnRefresh, (Type)null, "Location", new object[1]
		{
			new Point(894, 46)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnRefresh, (Type)null, "Name", new object[1] { "btnRefresh" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnRefresh, (Type)null, "Normalcolor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnRefresh, (Type)null, "OnHovercolor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnRefresh, (Type)null, "OnHoverTextColor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnRefresh, (Type)null, "selected", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnRefresh, (Type)null, "Size", new object[1]
		{
			new Size(208, 40)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnRefresh, (Type)null, "TabIndex", new object[1] { 10 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnRefresh, (Type)null, "Text", new object[1] { "Refresh" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnRefresh, (Type)null, "TextAlign", new object[1] { (object)(ContentAlignment)16 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnRefresh, (Type)null, "Textcolor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnRefresh, (Type)null, "TextFont", new object[1] { (object)new Font("Century Gothic", 15.75f) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "Activecolor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "BackColor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "BackgroundImageLayout", new object[1] { (object)(ImageLayout)3 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "BorderRadius", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "ButtonText", new object[1] { "Close" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "Cursor", new object[1] { Cursors.get_Hand() }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "DisabledColor", new object[1] { Color.Gray }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "Iconcolor", new object[1] { Color.Transparent }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "Iconimage", new object[1] { (object)(Image)((ComponentResourceManager)obj2).GetObject("btnClose.Iconimage") }, (string[])null, (Type[])null, false, true);
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
			new Point(894, 92)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "Name", new object[1] { "btnClose" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "Normalcolor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "OnHovercolor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "OnHoverTextColor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "selected", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "Size", new object[1]
		{
			new Size(208, 40)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "TabIndex", new object[1] { 10 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "Text", new object[1] { "Close" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "TextAlign", new object[1] { (object)(ContentAlignment)16 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "Textcolor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "TextFont", new object[1] { (object)new Font("Century Gothic", 15.75f) }, (string[])null, (Type[])null, false, true);
		lblname.set_AutoSize(true);
		((Control)lblname).set_Font(new Font("Century Gothic", 15.75f));
		((Control)lblname).set_Location(new Point(466, 143));
		((Control)lblname).set_Name("lblname");
		((Control)lblname).set_Size(new Size(116, 24));
		((Control)lblname).set_TabIndex(11);
		lblname.set_Text("UserName");
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Century Gothic", 36f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_Location(new Point(460, 46));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(413, 58));
		((Control)Label1).set_TabIndex(12);
		Label1.set_Text("User Sale Record");
		((Control)Panel2).set_BackColor(Color.FromArgb(174, 8, 40));
		((Control)Panel2).set_Dock((DockStyle)1);
		((Control)Panel2).set_Location(new Point(0, 0));
		((Control)Panel2).set_Name("Panel2");
		((Control)Panel2).set_Size(new Size(1173, 25));
		((Control)Panel2).set_TabIndex(57);
		NewLateBinding.LateSetComplex(WindowsUIButtonPanel3, (Type)null, "Location", new object[1]
		{
			new Point(1108, 323)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(WindowsUIButtonPanel3, (Type)null, "Name", new object[1] { "WindowsUIButtonPanel3" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(WindowsUIButtonPanel3, (Type)null, "Size", new object[1]
		{
			new Size(53, 64)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(WindowsUIButtonPanel3, (Type)null, "TabIndex", new object[1] { 58 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(WindowsUIButtonPanel3, (Type)null, "Text", new object[1] { "WindowsUIButtonPanel1" }, (string[])null, (Type[])null, false, true);
		lblTotal.set_AutoSize(true);
		((Control)lblTotal).set_Font(new Font("Century Gothic", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblTotal).set_Location(new Point(890, 135));
		((Control)lblTotal).set_Name("lblTotal");
		((Control)lblTotal).set_Size(new Size(42, 20));
		((Control)lblTotal).set_TabIndex(59);
		lblTotal.set_Text("Total");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.White);
		((Form)this).set_ClientSize(new Size(1173, 621));
		((Control)this).get_Controls().Add((Control)(object)lblTotal);
		((Control)this).get_Controls().Add((Control)WindowsUIButtonPanel3);
		((Control)this).get_Controls().Add((Control)(object)Panel2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)lblname);
		((Control)this).get_Controls().Add((Control)btnClose);
		((Control)this).get_Controls().Add((Control)btnRefresh);
		((Control)this).get_Controls().Add((Control)gridviewUserName);
		((Control)this).get_Controls().Add((Control)(object)Chart1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		name = "OnlyUserRecord";
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Only User Record");
		((ISupportInitialize)Chart1).EndInit();
		((ISupportInitialize)NewLateBinding.LateGet(gridviewUserName, (Type)null, "MasterTemplate", new object[0], (string[])null, (Type[])null, (bool[])null)).EndInit();
		((ISupportInitialize)gridviewUserName).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Yk(object sender, EventArgs e)
	{
		c3();
	}

	private void z4(object sender, EventArgs e)
	{
		c3();
	}

	public void c3()
	{
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		Rf7.Zj9();
		Rf7.cnn.Open();
		ISupportInitialize supportInitialize = new DataTable();
		Rf7.cmd.set_Connection(Rf7.cnn);
		Rf7.cmd.set_CommandText("select orderno as [Order NO],itemname as [Item Name],quantity as [Quantity],totalprice as [Total Price],orderdate as [Order Date] from productdata where username ='" + NewLateBinding.LateGet(NewLateBinding.LateGet(UserInfo, (Type)null, "cmb", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectedValue", new object[0], (string[])null, (Type[])null, (bool[])null).ToString() + "'");
		Rf7.da.set_SelectCommand(Rf7.cmd);
		((DbDataAdapter)(object)Rf7.da).Fill(supportInitialize as DataTable);
		NewLateBinding.LateSetComplex(gridviewUserName, (Type)null, "DataSource", new object[1] { supportInitialize as DataTable }, (string[])null, (Type[])null, false, true);
		object cmd = Rf7.cmd;
		((OleDbCommand)cmd).set_Connection(Rf7.cnn);
		((OleDbCommand)cmd).set_CommandText("select totalprice,orderdate from productdata where username='" + lblname.get_Text() + "'");
		cmd = null;
		IListSource listSource = new DataTable();
		Rf7.da.set_SelectCommand(Rf7.cmd);
		try
		{
			((DbDataAdapter)(object)Rf7.da).Fill(listSource as DataTable);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		checked
		{
			try
			{
				int count = ((DataTable)supportInitialize).Rows.Count;
				int i = 0;
				int num = 0;
				for (; i < count; i++)
				{
					num += Conversions.ToInteger(((DataTable)supportInitialize).Rows[i]["totalprice"]);
				}
				lblTotal.set_Text("Rs." + Conversions.ToString(num));
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				lblTotal.set_Text("Rs. 00");
				ProjectData.ClearProjectError();
			}
			NewLateBinding.LateCall(gridviewUserName, (Type)null, "BestFitColumns", new object[1] { true }, (string[])null, (Type[])null, (bool[])null, true);
			Chart1.set_DataSource((object)(DataTable)listSource);
			object obj = new string[14];
			((string[])obj)[0] = Conversions.ToString(1);
			(obj as string[])[1] = Conversions.ToString(8);
			((string[])obj)[2] = Conversions.ToString(9);
			((string[])obj)[3] = Conversions.ToString(6);
			(obj as string[])[4] = Conversions.ToString(3);
			(obj as string[])[5] = Conversions.ToString(11);
			((string[])obj)[6] = Conversions.ToString(10);
			((string[])obj)[7] = Conversions.ToString(12);
			((string[])obj)[8] = Conversions.ToString(2);
			(obj as string[])[9] = Conversions.ToString(4);
			((string[])obj)[10] = Conversions.ToString(5);
			object obj2 = new Random();
			int num2 = ((Random)obj2).Next(0, 12);
			Chart1.set_Palette((ChartColorPalette)Conversions.ToInteger((obj as string[])[num2]));
			((ChartNamedElementCollection<Series>)(object)Chart1.get_Series()).get_Item("User Record").set_YValueMembers("totalprice");
			((ChartNamedElementCollection<Series>)(object)Chart1.get_Series()).get_Item("User Record").set_XValueMember("orderdate");
			Rf7.cnn.Close();
		}
	}

	private void r7(object sender, EventArgs e)
	{
		((Control)this).Hide();
		NewLateBinding.LateCall(UserInfo, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
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

	private void t1(object sender, EventArgs e)
	{
	}

	static void Hf()
	{
		//IL_004f: Expected O, but got I4
		//IL_00de: Expected O, but got I4
		//IL_01e1: Expected O, but got I4
		//IL_0257: Expected O, but got I4
		//IL_0265: Expected O, but got I4
		//IL_0322: Expected O, but got I4
		//IL_04fc: Expected O, but got I4
		//IL_0586: Expected O, but got I4
		//IL_05eb: Expected O, but got I4
		Bs bs = null;
		bs = bs;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out i1D i1D);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Mr7n6D mr7n6D);
		while (((y0D)null).Width is object)
		{
			do
			{
				i1D = (i1D)((i1D)null).PrintMonthlyRecords;
				i1D = i1D;
				mr7n6D = mr7n6D;
			}
			while (((Ag9)mr7n6D.ObjectDetectorSearchMode).UserInfo != null);
		}
		f3L6Rd f3L6Rd = null;
		a8C a8C = (a8C)f3L6Rd.PrintDailyRecords;
		_ = (s4C8Py)a8C.PayTMPay;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Yg89Py yg89Py);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f1P6Lz f1P6Lz);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Xn05Ce xn05Ce);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ag9 ag);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		try
		{
			yg89Py = yg89Py;
			num = (UIntPtr)yg89Py.Fast_food_managementConnectionString;
			if (num == 0)
			{
				_ = (i7Z8Et)((a8C)null).PayTMPay;
				f1P6Lz = f1P6Lz;
				_ = (i7Z8Et)f1P6Lz.SuppliedRecord;
				xn05Ce = xn05Ce;
				_ = (Wt9q7H)xn05Ce.ObjectDetectorSearchMode;
			}
			else
			{
				_ = ((y0D)null).Width is m8K;
			}
		}
		catch
		{
			while (true)
			{
				obj = ((f3L6Rd)f3L6Rd.PrintDailyRecords).PrintDailyRecords;
				if (obj != null)
				{
					while (((f3L6Rd)null).PrintDailyRecords != null)
					{
						ag = ag;
						_ = (m8K)ag.UserInfo;
					}
					continue;
				}
				break;
			}
		}
		x6LFp1 x6LFp;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ez0 ez);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out b4 b);
		try
		{
			try
			{
				b4 obj3 = (b4)((a8C)null).PayTMPay;
				b = b;
				b = obj3;
			}
			finally
			{
				e2.y6 obj4 = (e2.y6)((i1D)null).PrintMonthlyRecords;
				e2.y6 y = y;
				y = obj4;
				goto end_IL_0132;
			}
			end_IL_0132:;
		}
		catch
		{
			while (i1D.PrintMonthlyRecords != null)
			{
				_ = (Hf08Tc)((s7K2Ek)null).ObjectDetectorScalingMode;
			}
		}
		finally
		{
			try
			{
				ez = null;
				ez = ez;
				_ = (Se60Di)a8C.PayTMPay;
				_ = (Ag9)(object)yg89Py.DBForFoodManagementConnectionString;
				_ = (Ty5k0C)ag.UserInfo;
			}
			finally
			{
				try
				{
					_ = (b4)f3L6Rd.PrintDailyRecords;
				}
				finally
				{
					x6LFp = ((y0D)null).Width as x6LFp1;
					x6LFp = null;
					goto IL_01f3;
				}
			}
		}
		IL_01f3:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sy0 sy);
		y0D y0D;
		try
		{
			do
			{
				i1D = (i1D)((a8C)null).PayTMPay;
				_ = (x6LFp1)(object)((Yg89Py)null).Fast_food_managementConnectionString;
				sy = sy;
				_ = (Sy50Xx)sy.SupplierDailyRecord;
				_ = (Mt2)f1P6Lz.SupplierDailyRecord;
			}
			while (xn05Ce.ObjectDetectorSearchMode != null);
		}
		finally
		{
			y0D = null;
			_ = y0D.Width is Hf08Tc;
			goto IL_025e;
		}
		IL_025e:
		_ = ((y0D)null).Width is _003CModule_003E;
		_ = (Mt2)((Xn05Ce)null).ObjectDetectorSearchMode;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s7K2Ek s7K2Ek);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s9.y6 y2);
		try
		{
			try
			{
				if (num == 0)
				{
					y2 = (s9.y6)((Xn05Ce)null).ObjectDetectorScalingMode;
					y2 = y2;
				}
			}
			finally
			{
				s7K2Ek = s7K2Ek;
				s7K2Ek = s7K2Ek;
				goto end_IL_0276;
			}
			end_IL_0276:;
		}
		catch
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Sy50Xx sy50Xx);
			while (obj != null)
			{
				if ((UIntPtr)((f3L6Rd)null).PrintDailyRecords == (UIntPtr)(nuint)0u)
				{
					sy50Xx = sy50Xx;
					sy50Xx = sy50Xx;
				}
				else
				{
					_ = (Mm0)mr7n6D.ObjectDetectorScalingMode;
					_ = (e2.y6)xn05Ce.ObjectDetectorSearchMode;
					y2 = y2;
				}
			}
		}
		checked
		{
			try
			{
				ez = ez;
			}
			finally
			{
				try
				{
					if (unchecked((nuint)(UIntPtr)((f1P6Lz)null).SuppliedRecord) + num == 0)
					{
						_ = y0D.Width is Rf7;
					}
					else
					{
						s7K2Ek = s7K2Ek;
					}
				}
				catch
				{
					try
					{
						_ = (Se60Di)((f3L6Rd)null).PrintDailyRecords;
					}
					finally
					{
						_ = (Ez0)(object)yg89Py.DBForFoodManagementConnectionString;
						goto end_IL_0333;
					}
					end_IL_0333:;
				}
				goto IL_0357;
			}
		}
		IL_0357:
		if (checked(unchecked((nuint)(UIntPtr)xn05Ce.ObjectDetectorSearchMode) - num) / checked(unchecked((nuint)(UIntPtr)((Mr7n6D)((s7K2Ek)null).ObjectDetectorSearchMode).ObjectDetectorScalingMode) * num) == 0)
		{
			try
			{
				xn05Ce = xn05Ce;
			}
			catch
			{
				try
				{
					x6LFp = x6LFp;
					_ = (Xn05Ce)mr7n6D.UserInfo;
					_ = (i7Z8Et)(object)yg89Py.Fast_food_managementConnectionString;
					_ = (_003CModule_003E)((Mr7n6D)null).ObjectDetectorSearchMode;
				}
				finally
				{
					Hf08Tc hf08Tc = null;
					hf08Tc = hf08Tc;
					goto end_IL_0391;
				}
				end_IL_0391:;
			}
		}
		_ = (i1D)((Mr7n6D)((Mr7n6D)null).ObjectDetectorScalingMode).UserInfo;
		do
		{
			num = default(UIntPtr);
			if (num != 0)
			{
				try
				{
					_ = (_003CModule_003E)((a8C)null).PayTMPay;
				}
				finally
				{
					_ = (x6LFp1)((Xn05Ce)f1P6Lz.SupplierDailyRecord).ObjectDetectorSearchMode;
					continue;
				}
			}
			while (((Xn05Ce)null).ObjectDetectorSearchMode != null)
			{
				_ = (Ez0)(object)yg89Py.DBForFoodManagementConnectionString;
				_ = (y0D)mr7n6D.UserInfo;
				_ = (e2.y6)s7K2Ek.ObjectDetectorSearchMode;
			}
		}
		while (obj != null);
		_ = (Ag9)((Mr7n6D)null).UserInfo;
		Ty5k0C ty5k0C = ty5k0C;
		ty5k0C = ty5k0C;
		_ = (i1D)((i1D)null).PrintMonthlyRecords;
		_ = (s9.y6)sy.SupplierDailyRecord;
		_ = (Yg89Py)((Xn05Ce)null).ObjectDetectorScalingMode;
		if ((UIntPtr)sy.UserInfo == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
				_ = (Sy0)mr7n6D.UserInfo;
			}
		}
		else
		{
			f1P6Lz = f1P6Lz;
		}
		if ((UIntPtr)((f3L6Rd)f3L6Rd.PrintDailyRecords).PrintDailyRecords == (UIntPtr)(nuint)0u && !(((y0D)null).Width is UIntPtr))
		{
			try
			{
				_ = (Ag9)s7K2Ek.ObjectDetectorScalingMode;
			}
			catch
			{
				y0D = null;
			}
		}
		y2 = y2;
		_ = (Sy0)((Ag9)null).UserInfo;
		ez = (Ez0)f1P6Lz.Send_sms_to_customer;
		i1D = i1D;
		b = b;
		sy = sy;
		do
		{
			try
			{
				do
				{
					f3L6Rd = f3L6Rd;
				}
				while (obj != null);
			}
			catch
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = y0D.Width is Xn05Ce;
					ag = (Ag9)f3L6Rd.PrintDailyRecords;
					_ = (Wt9q7H)ag.UserInfo;
					_ = (Yg89Py)a8C.PayTMPay;
				}
			}
		}
		while (obj != null);
		if ((UIntPtr)((a8C)a8C.PayTMPay).PayTMPay != (UIntPtr)(nuint)0u)
		{
			return;
		}
		try
		{
			while (y0D.Width is object)
			{
			}
		}
		finally
		{
			if (checked(unchecked((nuint)(UIntPtr)ag.UserInfo) - unchecked((nuint)(UIntPtr)((s7K2Ek)i1D.PrintMonthlyRecords).ObjectDetectorScalingMode)) / num / (nuint)(UIntPtr)((Yg89Py)null).DBForFoodManagementConnectionString == 0)
			{
				_ = (Mr7n6D)f1P6Lz.SupplierDailyRecord;
				return;
			}
			mr7n6D = mr7n6D;
			y0D = y0D;
			_ = (Mr7n6D)((i1D)xn05Ce.UserInfo).PrintMonthlyRecords;
			return;
		}
	}
}
