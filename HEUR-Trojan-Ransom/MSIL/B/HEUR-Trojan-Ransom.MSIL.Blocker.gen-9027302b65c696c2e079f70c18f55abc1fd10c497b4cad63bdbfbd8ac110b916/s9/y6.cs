using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.VisualBasic.CompilerServices;
using n2Z;
using t5C8Kg;

namespace s9;

[DesignerGenerated]
public class y6 : Form
{
	internal sealed class m2
	{
		internal object object_0;

		internal Label label_0;

		internal Label label_1;

		internal object object_1;

		internal object object_2;

		internal Label label_2;

		internal Label label_3;

		internal Label label_4;

		internal object object_3;

		internal Label label_5;

		internal object object_4;

		internal m2()
		{
		}
	}

	internal sealed class Jp
	{
		internal IContainer icontainer_0;

		internal object object_0;

		internal object object_1;

		internal object object_2;

		internal Jp()
		{
		}
	}

	private IContainer components;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("PrintDocument1")]
	private PrintDocument _PrintDocument1;

	[AccessedThroughProperty("gridviewUserName")]
	private object _gridviewUserName;

	[AccessedThroughProperty("RadPrintDocument1")]
	private object _RadPrintDocument1;

	private f1P6Lz.Ki1 ki1_0 = new f1P6Lz.Ki1();

	internal virtual Button Button1
	{
		get
		{
			return ki1_0.button_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			object obj = new EventHandler(Ed);
			IButtonControl button_ = (IButtonControl)(object)ki1_0.button_0;
			if ((int)(Button)button_ != 0)
			{
				((Control)(Button)button_).remove_Click((EventHandler)obj);
			}
			ki1_0.button_0 = ((value is Button) ? value : null);
			button_ = (IButtonControl)(object)ki1_0.button_0;
			if ((int)(Button)button_ != 0)
			{
				((Control)((button_ is Button) ? button_ : null)).add_Click(obj as EventHandler);
			}
		}
	}

	internal virtual Button Button2
	{
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			object obj = new EventHandler(Jr);
			object button = _Button2;
			if (button is Button)
			{
				((Control)((button is Button) ? button : null)).remove_Click(obj as EventHandler);
			}
			_Button2 = value;
			button = _Button2;
			if ((int)(Button)button != 0)
			{
				((Control)((button is Button) ? button : null)).add_Click(obj as EventHandler);
			}
		}
	}

	internal virtual PrintDocument PrintDocument1
	{
		get
		{
			return _PrintDocument1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_PrintDocument1 = value;
		}
	}

	internal virtual PrintPreviewDialog PrintPreviewDialog1
	{
		get
		{
			return ki1_0.printPreviewDialog_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected O, but got Unknown
			ki1_0.printPreviewDialog_0 = value;
		}
	}

	internal virtual PrintDialog PrintDialog1
	{
		get
		{
			return ki1_0.printDialog_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected O, but got Unknown
			ki1_0.printDialog_0 = value;
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

	internal virtual Chart Chart1
	{
		get
		{
			return ki1_0.chart_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			ki1_0.chart_0 = ((value is Chart) ? value : null);
		}
	}

	internal virtual object RadPrintDocument1
	{
		get
		{
			return _RadPrintDocument1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_RadPrintDocument1 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public y6()
	{
		((Form)this).add_Load((EventHandler)m5);
		i1();
	}

	protected override void z9(bool p5)
	{
		try
		{
			if (p5 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(p5);
		}
	}

	private void i1()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
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
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_0369: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Expected O, but got Unknown
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Expected O, but got Unknown
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_045e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Expected O, but got Unknown
		//IL_048e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0494: Expected O, but got Unknown
		//IL_04eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f5: Expected O, but got Unknown
		ResourceManager resourceManager = new ComponentResourceManager(typeof(y6));
		object obj = (object)new ChartArea();
		object obj2 = (object)new Legend();
		DataPointCustomProperties val = (DataPointCustomProperties)new Series();
		Button1 = new Button();
		Button2 = new Button();
		PrintDocument1 = new PrintDocument();
		PrintPreviewDialog1 = new PrintPreviewDialog();
		PrintDialog1 = new PrintDialog();
		Chart1 = new Chart();
		((ISupportInitialize)gridviewUserName).BeginInit();
		((ISupportInitialize)NewLateBinding.LateGet(gridviewUserName, (Type)null, "MasterTemplate", new object[0], (string[])null, (Type[])null, (bool[])null)).BeginInit();
		((ISupportInitialize)Chart1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Button1).set_Location(new Point(69, 361));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(142, 42));
		((Control)Button1).set_TabIndex(10);
		((ButtonBase)Button1).set_Text("Print");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		((Control)Button2).set_Location(new Point(217, 361));
		((Control)Button2).set_Name("Button2");
		((Control)Button2).set_Size(new Size(142, 42));
		((Control)Button2).set_TabIndex(10);
		((ButtonBase)Button2).set_Text("Print Preview");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		PrintPreviewDialog1.set_AutoScrollMargin(new Size(0, 0));
		PrintPreviewDialog1.set_AutoScrollMinSize(new Size(0, 0));
		((Form)PrintPreviewDialog1).set_ClientSize(new Size(400, 300));
		PrintPreviewDialog1.set_Enabled(true);
		PrintPreviewDialog1.set_Icon((Icon)((ComponentResourceManager)resourceManager).GetObject("PrintPreviewDialog1.Icon"));
		((Control)PrintPreviewDialog1).set_Name("PrintPreviewDialog1");
		PrintPreviewDialog1.set_Visible(false);
		PrintDialog1.set_UseEXDialog(true);
		NewLateBinding.LateSetComplex(gridviewUserName, (Type)null, "Location", new object[1]
		{
			new Point(12, 12)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(gridviewUserName, (Type)null, "MasterTemplate", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "AllowAddNewRow", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(gridviewUserName, (Type)null, "Name", new object[1] { "gridviewUserName" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(gridviewUserName, (Type)null, "ReadOnly", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(gridviewUserName, (Type)null, "Size", new object[1]
		{
			new Size(425, 343)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(gridviewUserName, (Type)null, "TabIndex", new object[1] { 12 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(gridviewUserName, (Type)null, "Text", new object[1] { "grdviewDailyRecord" }, (string[])null, (Type[])null, false, true);
		((Control)Chart1).set_BackgroundImageLayout((ImageLayout)0);
		Chart1.set_BackSecondaryColor(Color.Black);
		((ChartArea)((obj is ChartArea) ? obj : null)).set_Name("ChartArea1");
		((Collection<ChartArea>)(object)Chart1.get_ChartAreas()).Add((ChartArea)obj);
		((Legend)((obj2 is Legend) ? obj2 : null)).set_Name("Legend1");
		((Collection<Legend>)(object)Chart1.get_Legends()).Add((Legend)obj2);
		((Control)Chart1).set_Location(new Point(443, 12));
		((Control)Chart1).set_Name("Chart1");
		((Series)val).set_ChartArea("ChartArea1");
		((Series)val).set_Legend("Legend1");
		((Series)val).set_Name("User Record");
		((Collection<Series>)(object)Chart1.get_Series()).Add((Series)(object)((val is Series) ? val : null));
		Chart1.set_Size(new Size(638, 408));
		((Control)Chart1).set_TabIndex(13);
		((Control)Chart1).set_Text("Chart1");
		NewLateBinding.LateSetComplex(RadPrintDocument1, (Type)null, "FooterFont", new object[1] { (object)new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(RadPrintDocument1, (Type)null, "HeaderFont", new object[1] { (object)new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0) }, (string[])null, (Type[])null, false, true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(1288, 561));
		((Control)this).get_Controls().Add((Control)(object)Chart1);
		((Control)this).get_Controls().Add((Control)gridviewUserName);
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).set_Name("Print");
		((Form)this).set_Text("Print");
		((ISupportInitialize)NewLateBinding.LateGet(gridviewUserName, (Type)null, "MasterTemplate", new object[0], (string[])null, (Type[])null, (bool[])null)).EndInit();
		((ISupportInitialize)gridviewUserName).EndInit();
		((ISupportInitialize)Chart1).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void m5(object sender, EventArgs e)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		Rf7.Zj9();
		Rf7.cnn.Open();
		ICloneable cmd = (ICloneable)Rf7.cmd;
		((OleDbCommand)cmd).set_Connection(Rf7.cnn);
		((OleDbCommand)((cmd is OleDbCommand) ? cmd : null)).set_CommandText("select orderno,name,quantity,totalprice from dailyrecord");
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
		Chart1.set_DataSource((object)(DataTable)supportInitializeNotification);
		NewLateBinding.LateSetComplex(gridviewUserName, (Type)null, "DataSource", new object[1] { supportInitializeNotification as DataTable }, (string[])null, (Type[])null, false, true);
		((ChartNamedElementCollection<Series>)(object)Chart1.get_Series()).get_Item("User Record").set_YValueMembers("totalprice");
		((ChartNamedElementCollection<Series>)(object)Chart1.get_Series()).get_Item("User Record").set_XValueMember("orderno");
		Rf7.cnn.Close();
	}

	private void Jr(object sender, EventArgs e)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		object obj = NewLateBinding.LateGet(gridviewUserName, (Type)null, "PrintStyle", new object[0], (string[])null, (Type[])null, (bool[])null);
		NewLateBinding.LateSetComplex(obj, (Type)null, "PrintHeaderOnEachPage", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(obj, (Type)null, "BorderColor", new object[1] { Color.IndianRed }, (string[])null, (Type[])null, false, true);
		ICloneable cloneable = (ICloneable)new Font("Times New Roman", 14f);
		NewLateBinding.LateSetComplex(obj, (Type)null, "CellFont", new object[1] { (object)(Font)cloneable }, (string[])null, (Type[])null, false, true);
		obj = null;
		NewLateBinding.LateCall(gridviewUserName, (Type)null, "PrintPreview", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void Ed(object sender, EventArgs e)
	{
		NewLateBinding.LateCall(gridviewUserName, (Type)null, "PrintPreview", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		Chart1.get_Printing().PageSetup();
		Chart1.get_Printing().PrintPreview();
		Chart1.get_Printing().Print(true);
	}
}
