using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace The_Book;

[DesignerGenerated]
public class Edit : Form
{
	private IContainer components;

	private int intUniqueID;

	[field: AccessedThroughProperty("lblUnique")]
	internal virtual Label lblUnique
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblName")]
	internal virtual Label lblName
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtFirstName")]
	internal virtual TextBox txtFirstName
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtBirthday")]
	internal virtual TextBox txtBirthday
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtFlagDate")]
	internal virtual TextBox txtFlagDate
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtLastName")]
	internal virtual TextBox txtLastName
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

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
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

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label6")]
	internal virtual Label Label6
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

	[field: AccessedThroughProperty("Label8")]
	internal virtual Label Label8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox2")]
	internal virtual GroupBox GroupBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtStartDate")]
	internal virtual TextBox txtStartDate
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtEndDate")]
	internal virtual TextBox txtEndDate
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

	[field: AccessedThroughProperty("Label10")]
	internal virtual Label Label10
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

	[field: AccessedThroughProperty("grpFriday")]
	internal virtual GroupBox grpFriday
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("rbAbsent_Friday")]
	internal virtual RadioButton rbAbsent_Friday
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("rbHalf_PM_Friday")]
	internal virtual RadioButton rbHalf_PM_Friday
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("rbHalf_AM_Friday")]
	internal virtual RadioButton rbHalf_AM_Friday
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("rbFull_Day_Friday")]
	internal virtual RadioButton rbFull_Day_Friday
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("grpThursday")]
	internal virtual GroupBox grpThursday
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("rbAbsent_Thursday")]
	internal virtual RadioButton rbAbsent_Thursday
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("rbHalf_PM_Thursday")]
	internal virtual RadioButton rbHalf_PM_Thursday
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("rbHalf_AM_Thursday")]
	internal virtual RadioButton rbHalf_AM_Thursday
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("rbFull_Day_Thursday")]
	internal virtual RadioButton rbFull_Day_Thursday
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("grpWednesday")]
	internal virtual GroupBox grpWednesday
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("rbAbsent_Wednesday")]
	internal virtual RadioButton rbAbsent_Wednesday
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("rbHalf_PM_Wednesday")]
	internal virtual RadioButton rbHalf_PM_Wednesday
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("rbHalf_AM_Wednesday")]
	internal virtual RadioButton rbHalf_AM_Wednesday
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("rbFull_Day_Wednesday")]
	internal virtual RadioButton rbFull_Day_Wednesday
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Tuesday")]
	internal virtual GroupBox Tuesday
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("rbAbsent_Tuesday")]
	internal virtual RadioButton rbAbsent_Tuesday
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("rbHalf_PM_Tuesday")]
	internal virtual RadioButton rbHalf_PM_Tuesday
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("rbHalf_AM_Tuesday")]
	internal virtual RadioButton rbHalf_AM_Tuesday
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("rbFull_Day_Tuesday")]
	internal virtual RadioButton rbFull_Day_Tuesday
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("grpMonday")]
	internal virtual GroupBox grpMonday
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("rbAbsent_Monday")]
	internal virtual RadioButton rbAbsent_Monday
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("rbHalf_PM_Monday")]
	internal virtual RadioButton rbHalf_PM_Monday
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("rbHalf_AM_Monday")]
	internal virtual RadioButton rbHalf_AM_Monday
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("rbFull_Day_Monday")]
	internal virtual RadioButton rbFull_Day_Monday
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual PictureBox clpCancel
	{
		[CompilerGenerated]
		get
		{
			return _clpCancel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = clpCancel_Click;
			PictureBox val = _clpCancel;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_clpCancel = value;
			val = _clpCancel;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual PictureBox clpAccept
	{
		[CompilerGenerated]
		get
		{
			return _clpAccept;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = clpAccept_Click;
			PictureBox val = _clpAccept;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_clpAccept = value;
			val = _clpAccept;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual ComboBox cboNextSpecificClassroom
	{
		[CompilerGenerated]
		get
		{
			return _cboNextSpecificClassroom;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = cboNextSpecificClassroom_DropDown;
			ComboBox val = _cboNextSpecificClassroom;
			if (val != null)
			{
				val.remove_DropDown(eventHandler);
			}
			_cboNextSpecificClassroom = value;
			val = _cboNextSpecificClassroom;
			if (val != null)
			{
				val.add_DropDown(eventHandler);
			}
		}
	}

	internal virtual ComboBox cboCurrentSpecificClassroom
	{
		[CompilerGenerated]
		get
		{
			return _cboCurrentSpecificClassroom;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = cboCurrentSpecificClassroom_DropDown;
			ComboBox val = _cboCurrentSpecificClassroom;
			if (val != null)
			{
				val.remove_DropDown(eventHandler);
			}
			_cboCurrentSpecificClassroom = value;
			val = _cboCurrentSpecificClassroom;
			if (val != null)
			{
				val.add_DropDown(eventHandler);
			}
		}
	}

	internal virtual ComboBox cboNextClassroom
	{
		[CompilerGenerated]
		get
		{
			return _cboNextClassroom;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = cboNextClassroom_DropDown;
			ComboBox val = _cboNextClassroom;
			if (val != null)
			{
				val.remove_DropDown(eventHandler);
			}
			_cboNextClassroom = value;
			val = _cboNextClassroom;
			if (val != null)
			{
				val.add_DropDown(eventHandler);
			}
		}
	}

	internal virtual ComboBox cboCurrentClassroom
	{
		[CompilerGenerated]
		get
		{
			return _cboCurrentClassroom;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = cboCurrentClassroom_DropDown;
			ComboBox val = _cboCurrentClassroom;
			if (val != null)
			{
				val.remove_DropDown(eventHandler);
			}
			_cboCurrentClassroom = value;
			val = _cboCurrentClassroom;
			if (val != null)
			{
				val.add_DropDown(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("GroupBox4")]
	internal virtual GroupBox GroupBox4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtUniqueIdentifier")]
	internal virtual TextBox txtUniqueIdentifier
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

	[field: AccessedThroughProperty("Label12")]
	internal virtual Label Label12
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

	[field: AccessedThroughProperty("Label14")]
	internal virtual Label Label14
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label15")]
	internal virtual Label Label15
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Edit()
	{
		((Form)this).add_Load((EventHandler)Edit_Load);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
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
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected O, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected O, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected O, but got Unknown
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected O, but got Unknown
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected O, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected O, but got Unknown
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected O, but got Unknown
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected O, but got Unknown
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected O, but got Unknown
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected O, but got Unknown
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected O, but got Unknown
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected O, but got Unknown
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected O, but got Unknown
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected O, but got Unknown
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected O, but got Unknown
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected O, but got Unknown
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected O, but got Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected O, but got Unknown
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected O, but got Unknown
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected O, but got Unknown
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Expected O, but got Unknown
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected O, but got Unknown
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected O, but got Unknown
		//IL_0390: Unknown result type (might be due to invalid IL or missing references)
		//IL_039a: Expected O, but got Unknown
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_0531: Expected O, but got Unknown
		//IL_05a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05af: Expected O, but got Unknown
		//IL_0623: Unknown result type (might be due to invalid IL or missing references)
		//IL_062d: Expected O, but got Unknown
		//IL_06a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ab: Expected O, but got Unknown
		//IL_071f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0729: Expected O, but got Unknown
		//IL_07a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07aa: Expected O, but got Unknown
		//IL_0821: Unknown result type (might be due to invalid IL or missing references)
		//IL_082b: Expected O, but got Unknown
		//IL_08a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ac: Expected O, but got Unknown
		//IL_0972: Unknown result type (might be due to invalid IL or missing references)
		//IL_097c: Expected O, but got Unknown
		//IL_0aa3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aad: Expected O, but got Unknown
		//IL_0b39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b43: Expected O, but got Unknown
		//IL_0bba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc4: Expected O, but got Unknown
		//IL_0d69: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d73: Expected O, but got Unknown
		//IL_10ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f9: Expected O, but got Unknown
		//IL_117f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1189: Expected O, but got Unknown
		//IL_1215: Unknown result type (might be due to invalid IL or missing references)
		//IL_121f: Expected O, but got Unknown
		//IL_12ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_12b5: Expected O, but got Unknown
		//IL_1341: Unknown result type (might be due to invalid IL or missing references)
		//IL_134b: Expected O, but got Unknown
		//IL_1433: Unknown result type (might be due to invalid IL or missing references)
		//IL_143d: Expected O, but got Unknown
		//IL_14c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_14cd: Expected O, but got Unknown
		//IL_1559: Unknown result type (might be due to invalid IL or missing references)
		//IL_1563: Expected O, but got Unknown
		//IL_15ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_15f9: Expected O, but got Unknown
		//IL_1685: Unknown result type (might be due to invalid IL or missing references)
		//IL_168f: Expected O, but got Unknown
		//IL_1777: Unknown result type (might be due to invalid IL or missing references)
		//IL_1781: Expected O, but got Unknown
		//IL_1807: Unknown result type (might be due to invalid IL or missing references)
		//IL_1811: Expected O, but got Unknown
		//IL_189d: Unknown result type (might be due to invalid IL or missing references)
		//IL_18a7: Expected O, but got Unknown
		//IL_1933: Unknown result type (might be due to invalid IL or missing references)
		//IL_193d: Expected O, but got Unknown
		//IL_19c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_19d3: Expected O, but got Unknown
		//IL_1abb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ac5: Expected O, but got Unknown
		//IL_1b4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b55: Expected O, but got Unknown
		//IL_1be1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1beb: Expected O, but got Unknown
		//IL_1c77: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c81: Expected O, but got Unknown
		//IL_1d0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d17: Expected O, but got Unknown
		//IL_1dff: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e09: Expected O, but got Unknown
		//IL_1e8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e96: Expected O, but got Unknown
		//IL_1f22: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f2c: Expected O, but got Unknown
		//IL_1fb8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fc2: Expected O, but got Unknown
		//IL_204e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2058: Expected O, but got Unknown
		//IL_2104: Unknown result type (might be due to invalid IL or missing references)
		//IL_210e: Expected O, but got Unknown
		//IL_2194: Unknown result type (might be due to invalid IL or missing references)
		//IL_219e: Expected O, but got Unknown
		//IL_23d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_23da: Expected O, but got Unknown
		//IL_2443: Unknown result type (might be due to invalid IL or missing references)
		//IL_244d: Expected O, but got Unknown
		//IL_24c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_24cb: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Edit));
		lblUnique = new Label();
		lblName = new Label();
		txtFirstName = new TextBox();
		txtBirthday = new TextBox();
		txtFlagDate = new TextBox();
		txtLastName = new TextBox();
		Label1 = new Label();
		Label2 = new Label();
		Label3 = new Label();
		Label4 = new Label();
		Label5 = new Label();
		Label6 = new Label();
		Label7 = new Label();
		Label8 = new Label();
		GroupBox1 = new GroupBox();
		GroupBox2 = new GroupBox();
		Label10 = new Label();
		Label9 = new Label();
		txtStartDate = new TextBox();
		txtEndDate = new TextBox();
		GroupBox3 = new GroupBox();
		cboNextSpecificClassroom = new ComboBox();
		cboCurrentSpecificClassroom = new ComboBox();
		cboNextClassroom = new ComboBox();
		cboCurrentClassroom = new ComboBox();
		grpFriday = new GroupBox();
		rbAbsent_Friday = new RadioButton();
		rbHalf_PM_Friday = new RadioButton();
		rbHalf_AM_Friday = new RadioButton();
		rbFull_Day_Friday = new RadioButton();
		grpThursday = new GroupBox();
		rbAbsent_Thursday = new RadioButton();
		rbHalf_PM_Thursday = new RadioButton();
		rbHalf_AM_Thursday = new RadioButton();
		rbFull_Day_Thursday = new RadioButton();
		grpWednesday = new GroupBox();
		rbAbsent_Wednesday = new RadioButton();
		rbHalf_PM_Wednesday = new RadioButton();
		rbHalf_AM_Wednesday = new RadioButton();
		rbFull_Day_Wednesday = new RadioButton();
		Tuesday = new GroupBox();
		rbAbsent_Tuesday = new RadioButton();
		rbHalf_PM_Tuesday = new RadioButton();
		rbHalf_AM_Tuesday = new RadioButton();
		rbFull_Day_Tuesday = new RadioButton();
		grpMonday = new GroupBox();
		rbAbsent_Monday = new RadioButton();
		rbHalf_PM_Monday = new RadioButton();
		rbHalf_AM_Monday = new RadioButton();
		rbFull_Day_Monday = new RadioButton();
		GroupBox4 = new GroupBox();
		Label11 = new Label();
		txtUniqueIdentifier = new TextBox();
		Label12 = new Label();
		Label13 = new Label();
		Label14 = new Label();
		Label15 = new Label();
		clpCancel = new PictureBox();
		clpAccept = new PictureBox();
		((Control)GroupBox1).SuspendLayout();
		((Control)GroupBox2).SuspendLayout();
		((Control)GroupBox3).SuspendLayout();
		((Control)grpFriday).SuspendLayout();
		((Control)grpThursday).SuspendLayout();
		((Control)grpWednesday).SuspendLayout();
		((Control)Tuesday).SuspendLayout();
		((Control)grpMonday).SuspendLayout();
		((Control)GroupBox4).SuspendLayout();
		((ISupportInitialize)clpCancel).BeginInit();
		((ISupportInitialize)clpAccept).BeginInit();
		((Control)this).SuspendLayout();
		lblUnique.set_AutoSize(true);
		((Control)lblUnique).set_Location(new Point(0, 0));
		((Control)lblUnique).set_Name("lblUnique");
		((Control)lblUnique).set_Size(new Size(0, 13));
		((Control)lblUnique).set_TabIndex(0);
		((Control)lblUnique).set_Visible(false);
		lblName.set_AutoSize(true);
		((Control)lblName).set_Font(new Font("Comic Sans MS", 18f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblName).set_Location(new Point(290, 9));
		((Control)lblName).set_Name("lblName");
		((Control)lblName).set_Size(new Size(91, 35));
		((Control)lblName).set_TabIndex(1);
		lblName.set_Text("CHILD");
		((Control)txtFirstName).set_Location(new Point(123, 67));
		((Control)txtFirstName).set_Name("txtFirstName");
		((Control)txtFirstName).set_Size(new Size(180, 22));
		((Control)txtFirstName).set_TabIndex(2);
		((Control)txtBirthday).set_Location(new Point(123, 24));
		((Control)txtBirthday).set_Name("txtBirthday");
		((Control)txtBirthday).set_Size(new Size(100, 22));
		((Control)txtBirthday).set_TabIndex(3);
		((Control)txtFlagDate).set_Location(new Point(123, 62));
		((Control)txtFlagDate).set_Name("txtFlagDate");
		((Control)txtFlagDate).set_Size(new Size(100, 22));
		((Control)txtFlagDate).set_TabIndex(4);
		((Control)txtLastName).set_Location(new Point(123, 30));
		((Control)txtLastName).set_Name("txtLastName");
		((Control)txtLastName).set_Size(new Size(180, 22));
		((Control)txtLastName).set_TabIndex(9);
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_Location(new Point(17, 30));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(104, 20));
		((Control)Label1).set_TabIndex(17);
		Label1.set_Text("* Last Name: ");
		Label2.set_AutoSize(true);
		((Control)Label2).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_Location(new Point(18, 67));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(100, 20));
		((Control)Label2).set_TabIndex(18);
		Label2.set_Text("* First Name:");
		Label3.set_AutoSize(true);
		((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_Location(new Point(36, 24));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(81, 20));
		((Control)Label3).set_TabIndex(19);
		Label3.set_Text("* Birthday:");
		Label4.set_AutoSize(true);
		((Control)Label4).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label4).set_Location(new Point(34, 62));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(83, 20));
		((Control)Label4).set_TabIndex(20);
		Label4.set_Text("Flag Date:");
		Label5.set_AutoSize(true);
		((Control)Label5).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label5).set_Location(new Point(60, 26));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(155, 20));
		((Control)Label5).set_TabIndex(21);
		Label5.set_Text("* Current Classroom:");
		Label6.set_AutoSize(true);
		((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label6).set_Location(new Point(79, 62));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(134, 20));
		((Control)Label6).set_TabIndex(22);
		Label6.set_Text("* Next Classroom:");
		Label7.set_AutoSize(true);
		((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label7).set_Location(new Point(10, 102));
		((Control)Label7).set_Name("Label7");
		((Control)Label7).set_Size(new Size(205, 20));
		((Control)Label7).set_TabIndex(23);
		Label7.set_Text("Current Specific Classroom:");
		Label8.set_AutoSize(true);
		((Control)Label8).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label8).set_Location(new Point(31, 140));
		((Control)Label8).set_Name("Label8");
		((Control)Label8).set_Size(new Size(184, 20));
		((Control)Label8).set_TabIndex(24);
		Label8.set_Text("Next Specific Classroom:");
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)txtLastName);
		((Control)GroupBox1).get_Controls().Add((Control)(object)txtFirstName);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label2);
		((Control)GroupBox1).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)GroupBox1).set_Location(new Point(30, 62));
		((Control)GroupBox1).set_Name("GroupBox1");
		((Control)GroupBox1).set_Size(new Size(318, 104));
		((Control)GroupBox1).set_TabIndex(25);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("Names");
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label10);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label3);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label9);
		((Control)GroupBox2).get_Controls().Add((Control)(object)txtBirthday);
		((Control)GroupBox2).get_Controls().Add((Control)(object)txtStartDate);
		((Control)GroupBox2).get_Controls().Add((Control)(object)txtFlagDate);
		((Control)GroupBox2).get_Controls().Add((Control)(object)txtEndDate);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label4);
		((Control)GroupBox2).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)GroupBox2).set_Location(new Point(416, 185));
		((Control)GroupBox2).set_Name("GroupBox2");
		((Control)GroupBox2).set_Size(new Size(242, 173));
		((Control)GroupBox2).set_TabIndex(26);
		GroupBox2.set_TabStop(false);
		GroupBox2.set_Text("Dates (mm/dd/yyyy)");
		Label10.set_AutoSize(true);
		((Control)Label10).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label10).set_Location(new Point(40, 141));
		((Control)Label10).set_Name("Label10");
		((Control)Label10).set_Size(new Size(77, 20));
		((Control)Label10).set_TabIndex(28);
		Label10.set_Text("End Date");
		Label9.set_AutoSize(true);
		((Control)Label9).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label9).set_Location(new Point(34, 101));
		((Control)Label9).set_Name("Label9");
		((Control)Label9).set_Size(new Size(83, 20));
		((Control)Label9).set_TabIndex(27);
		Label9.set_Text("Start Date");
		((Control)txtStartDate).set_Location(new Point(123, 99));
		((Control)txtStartDate).set_Name("txtStartDate");
		((Control)txtStartDate).set_Size(new Size(100, 22));
		((Control)txtStartDate).set_TabIndex(21);
		((Control)txtEndDate).set_Location(new Point(123, 140));
		((Control)txtEndDate).set_Name("txtEndDate");
		((Control)txtEndDate).set_Size(new Size(100, 22));
		((Control)txtEndDate).set_TabIndex(22);
		((Control)GroupBox3).get_Controls().Add((Control)(object)cboNextSpecificClassroom);
		((Control)GroupBox3).get_Controls().Add((Control)(object)cboCurrentSpecificClassroom);
		((Control)GroupBox3).get_Controls().Add((Control)(object)cboNextClassroom);
		((Control)GroupBox3).get_Controls().Add((Control)(object)cboCurrentClassroom);
		((Control)GroupBox3).get_Controls().Add((Control)(object)Label5);
		((Control)GroupBox3).get_Controls().Add((Control)(object)Label6);
		((Control)GroupBox3).get_Controls().Add((Control)(object)Label8);
		((Control)GroupBox3).get_Controls().Add((Control)(object)Label7);
		((Control)GroupBox3).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)GroupBox3).set_Location(new Point(15, 185));
		((Control)GroupBox3).set_Name("GroupBox3");
		((Control)GroupBox3).set_Size(new Size(395, 175));
		((Control)GroupBox3).set_TabIndex(29);
		GroupBox3.set_TabStop(false);
		GroupBox3.set_Text("Classrooms");
		((ListControl)cboNextSpecificClassroom).set_FormattingEnabled(true);
		cboNextSpecificClassroom.get_Items().AddRange(new object[7] { "Select a classroom...", "Turtles", "Butterflies", "Fireflies", "Ladybugs", "Dragonflies", "Lions" });
		((Control)cboNextSpecificClassroom).set_Location(new Point(219, 141));
		((Control)cboNextSpecificClassroom).set_Name("cboNextSpecificClassroom");
		((Control)cboNextSpecificClassroom).set_Size(new Size(166, 24));
		((Control)cboNextSpecificClassroom).set_TabIndex(28);
		((ListControl)cboCurrentSpecificClassroom).set_FormattingEnabled(true);
		cboCurrentSpecificClassroom.get_Items().AddRange(new object[7] { "Select a classroom...", "Turtles", "Butterflies", "Fireflies", "Ladybugs", "Dragonflies", "Lions" });
		((Control)cboCurrentSpecificClassroom).set_Location(new Point(219, 101));
		((Control)cboCurrentSpecificClassroom).set_Name("cboCurrentSpecificClassroom");
		((Control)cboCurrentSpecificClassroom).set_Size(new Size(166, 24));
		((Control)cboCurrentSpecificClassroom).set_TabIndex(27);
		((ListControl)cboNextClassroom).set_FormattingEnabled(true);
		cboNextClassroom.get_Items().AddRange(new object[7] { "Select a classroom...", "Caterpillars", "Turtles/Butterflies", "Fireflies/Ladybugs", "Dragonflies/Lions", "Tree Frogs", "Kindergarten" });
		((Control)cboNextClassroom).set_Location(new Point(219, 62));
		((Control)cboNextClassroom).set_Name("cboNextClassroom");
		((Control)cboNextClassroom).set_Size(new Size(166, 24));
		((Control)cboNextClassroom).set_TabIndex(26);
		((ListControl)cboCurrentClassroom).set_FormattingEnabled(true);
		cboCurrentClassroom.get_Items().AddRange(new object[7] { "Select a classroom...", "Caterpillars", "Turtles/Butterflies", "Fireflies/Ladybugs", "Dragonflies/Lions", "Tree Frogs", "Kindergarten" });
		((Control)cboCurrentClassroom).set_Location(new Point(219, 26));
		((Control)cboCurrentClassroom).set_Name("cboCurrentClassroom");
		((Control)cboCurrentClassroom).set_Size(new Size(166, 24));
		((Control)cboCurrentClassroom).set_TabIndex(25);
		((Control)grpFriday).set_BackColor(Color.ForestGreen);
		((Control)grpFriday).get_Controls().Add((Control)(object)rbAbsent_Friday);
		((Control)grpFriday).get_Controls().Add((Control)(object)rbHalf_PM_Friday);
		((Control)grpFriday).get_Controls().Add((Control)(object)rbHalf_AM_Friday);
		((Control)grpFriday).get_Controls().Add((Control)(object)rbFull_Day_Friday);
		((Control)grpFriday).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)grpFriday).set_Location(new Point(520, 378));
		((Control)grpFriday).set_Name("grpFriday");
		((Control)grpFriday).set_Size(new Size(115, 115));
		((Control)grpFriday).set_TabIndex(34);
		grpFriday.set_TabStop(false);
		grpFriday.set_Text("* Friday");
		((ButtonBase)rbAbsent_Friday).set_AutoSize(true);
		((Control)rbAbsent_Friday).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)rbAbsent_Friday).set_Location(new Point(16, 88));
		((Control)rbAbsent_Friday).set_Name("rbAbsent_Friday");
		((Control)rbAbsent_Friday).set_Size(new Size(78, 24));
		((Control)rbAbsent_Friday).set_TabIndex(15);
		rbAbsent_Friday.set_TabStop(true);
		((ButtonBase)rbAbsent_Friday).set_Text("Absent");
		((ButtonBase)rbAbsent_Friday).set_UseVisualStyleBackColor(true);
		((ButtonBase)rbHalf_PM_Friday).set_AutoSize(true);
		((Control)rbHalf_PM_Friday).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)rbHalf_PM_Friday).set_Location(new Point(16, 65));
		((Control)rbHalf_PM_Friday).set_Name("rbHalf_PM_Friday");
		((Control)rbHalf_PM_Friday).set_Size(new Size(83, 24));
		((Control)rbHalf_PM_Friday).set_TabIndex(15);
		rbHalf_PM_Friday.set_TabStop(true);
		((ButtonBase)rbHalf_PM_Friday).set_Text("Half PM");
		((ButtonBase)rbHalf_PM_Friday).set_UseVisualStyleBackColor(true);
		((ButtonBase)rbHalf_AM_Friday).set_AutoSize(true);
		((Control)rbHalf_AM_Friday).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)rbHalf_AM_Friday).set_Location(new Point(16, 42));
		((Control)rbHalf_AM_Friday).set_Name("rbHalf_AM_Friday");
		((Control)rbHalf_AM_Friday).set_Size(new Size(84, 24));
		((Control)rbHalf_AM_Friday).set_TabIndex(14);
		rbHalf_AM_Friday.set_TabStop(true);
		((ButtonBase)rbHalf_AM_Friday).set_Text("Half AM");
		((ButtonBase)rbHalf_AM_Friday).set_UseVisualStyleBackColor(true);
		((ButtonBase)rbFull_Day_Friday).set_AutoSize(true);
		((Control)rbFull_Day_Friday).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)rbFull_Day_Friday).set_Location(new Point(16, 19));
		((Control)rbFull_Day_Friday).set_Name("rbFull_Day_Friday");
		((Control)rbFull_Day_Friday).set_Size(new Size(84, 24));
		((Control)rbFull_Day_Friday).set_TabIndex(13);
		rbFull_Day_Friday.set_TabStop(true);
		((ButtonBase)rbFull_Day_Friday).set_Text("Full Day");
		((ButtonBase)rbFull_Day_Friday).set_UseVisualStyleBackColor(true);
		((Control)grpThursday).set_BackColor(Color.ForestGreen);
		((Control)grpThursday).get_Controls().Add((Control)(object)rbAbsent_Thursday);
		((Control)grpThursday).get_Controls().Add((Control)(object)rbHalf_PM_Thursday);
		((Control)grpThursday).get_Controls().Add((Control)(object)rbHalf_AM_Thursday);
		((Control)grpThursday).get_Controls().Add((Control)(object)rbFull_Day_Thursday);
		((Control)grpThursday).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)grpThursday).set_Location(new Point(399, 378));
		((Control)grpThursday).set_Name("grpThursday");
		((Control)grpThursday).set_Size(new Size(115, 115));
		((Control)grpThursday).set_TabIndex(33);
		grpThursday.set_TabStop(false);
		grpThursday.set_Text("* Thursday");
		((ButtonBase)rbAbsent_Thursday).set_AutoSize(true);
		((Control)rbAbsent_Thursday).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)rbAbsent_Thursday).set_Location(new Point(16, 88));
		((Control)rbAbsent_Thursday).set_Name("rbAbsent_Thursday");
		((Control)rbAbsent_Thursday).set_Size(new Size(78, 24));
		((Control)rbAbsent_Thursday).set_TabIndex(14);
		rbAbsent_Thursday.set_TabStop(true);
		((ButtonBase)rbAbsent_Thursday).set_Text("Absent");
		((ButtonBase)rbAbsent_Thursday).set_UseVisualStyleBackColor(true);
		((ButtonBase)rbHalf_PM_Thursday).set_AutoSize(true);
		((Control)rbHalf_PM_Thursday).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)rbHalf_PM_Thursday).set_Location(new Point(16, 65));
		((Control)rbHalf_PM_Thursday).set_Name("rbHalf_PM_Thursday");
		((Control)rbHalf_PM_Thursday).set_Size(new Size(83, 24));
		((Control)rbHalf_PM_Thursday).set_TabIndex(14);
		rbHalf_PM_Thursday.set_TabStop(true);
		((ButtonBase)rbHalf_PM_Thursday).set_Text("Half PM");
		((ButtonBase)rbHalf_PM_Thursday).set_UseVisualStyleBackColor(true);
		((ButtonBase)rbHalf_AM_Thursday).set_AutoSize(true);
		((Control)rbHalf_AM_Thursday).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)rbHalf_AM_Thursday).set_Location(new Point(16, 42));
		((Control)rbHalf_AM_Thursday).set_Name("rbHalf_AM_Thursday");
		((Control)rbHalf_AM_Thursday).set_Size(new Size(84, 24));
		((Control)rbHalf_AM_Thursday).set_TabIndex(13);
		rbHalf_AM_Thursday.set_TabStop(true);
		((ButtonBase)rbHalf_AM_Thursday).set_Text("Half AM");
		((ButtonBase)rbHalf_AM_Thursday).set_UseVisualStyleBackColor(true);
		((ButtonBase)rbFull_Day_Thursday).set_AutoSize(true);
		((Control)rbFull_Day_Thursday).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)rbFull_Day_Thursday).set_Location(new Point(16, 19));
		((Control)rbFull_Day_Thursday).set_Name("rbFull_Day_Thursday");
		((Control)rbFull_Day_Thursday).set_Size(new Size(84, 24));
		((Control)rbFull_Day_Thursday).set_TabIndex(12);
		rbFull_Day_Thursday.set_TabStop(true);
		((ButtonBase)rbFull_Day_Thursday).set_Text("Full Day");
		((ButtonBase)rbFull_Day_Thursday).set_UseVisualStyleBackColor(true);
		((Control)grpWednesday).set_BackColor(Color.ForestGreen);
		((Control)grpWednesday).get_Controls().Add((Control)(object)rbAbsent_Wednesday);
		((Control)grpWednesday).get_Controls().Add((Control)(object)rbHalf_PM_Wednesday);
		((Control)grpWednesday).get_Controls().Add((Control)(object)rbHalf_AM_Wednesday);
		((Control)grpWednesday).get_Controls().Add((Control)(object)rbFull_Day_Wednesday);
		((Control)grpWednesday).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)grpWednesday).set_Location(new Point(278, 378));
		((Control)grpWednesday).set_Name("grpWednesday");
		((Control)grpWednesday).set_Size(new Size(115, 115));
		((Control)grpWednesday).set_TabIndex(32);
		grpWednesday.set_TabStop(false);
		grpWednesday.set_Text("* Wednesday");
		((ButtonBase)rbAbsent_Wednesday).set_AutoSize(true);
		((Control)rbAbsent_Wednesday).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)rbAbsent_Wednesday).set_Location(new Point(16, 88));
		((Control)rbAbsent_Wednesday).set_Name("rbAbsent_Wednesday");
		((Control)rbAbsent_Wednesday).set_Size(new Size(78, 24));
		((Control)rbAbsent_Wednesday).set_TabIndex(14);
		rbAbsent_Wednesday.set_TabStop(true);
		((ButtonBase)rbAbsent_Wednesday).set_Text("Absent");
		((ButtonBase)rbAbsent_Wednesday).set_UseVisualStyleBackColor(true);
		((ButtonBase)rbHalf_PM_Wednesday).set_AutoSize(true);
		((Control)rbHalf_PM_Wednesday).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)rbHalf_PM_Wednesday).set_Location(new Point(16, 65));
		((Control)rbHalf_PM_Wednesday).set_Name("rbHalf_PM_Wednesday");
		((Control)rbHalf_PM_Wednesday).set_Size(new Size(83, 24));
		((Control)rbHalf_PM_Wednesday).set_TabIndex(13);
		rbHalf_PM_Wednesday.set_TabStop(true);
		((ButtonBase)rbHalf_PM_Wednesday).set_Text("Half PM");
		((ButtonBase)rbHalf_PM_Wednesday).set_UseVisualStyleBackColor(true);
		((ButtonBase)rbHalf_AM_Wednesday).set_AutoSize(true);
		((Control)rbHalf_AM_Wednesday).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)rbHalf_AM_Wednesday).set_Location(new Point(16, 42));
		((Control)rbHalf_AM_Wednesday).set_Name("rbHalf_AM_Wednesday");
		((Control)rbHalf_AM_Wednesday).set_Size(new Size(84, 24));
		((Control)rbHalf_AM_Wednesday).set_TabIndex(12);
		rbHalf_AM_Wednesday.set_TabStop(true);
		((ButtonBase)rbHalf_AM_Wednesday).set_Text("Half AM");
		((ButtonBase)rbHalf_AM_Wednesday).set_UseVisualStyleBackColor(true);
		((ButtonBase)rbFull_Day_Wednesday).set_AutoSize(true);
		((Control)rbFull_Day_Wednesday).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)rbFull_Day_Wednesday).set_Location(new Point(16, 19));
		((Control)rbFull_Day_Wednesday).set_Name("rbFull_Day_Wednesday");
		((Control)rbFull_Day_Wednesday).set_Size(new Size(84, 24));
		((Control)rbFull_Day_Wednesday).set_TabIndex(11);
		rbFull_Day_Wednesday.set_TabStop(true);
		((ButtonBase)rbFull_Day_Wednesday).set_Text("Full Day");
		((ButtonBase)rbFull_Day_Wednesday).set_UseVisualStyleBackColor(true);
		((Control)Tuesday).set_BackColor(Color.ForestGreen);
		((Control)Tuesday).get_Controls().Add((Control)(object)rbAbsent_Tuesday);
		((Control)Tuesday).get_Controls().Add((Control)(object)rbHalf_PM_Tuesday);
		((Control)Tuesday).get_Controls().Add((Control)(object)rbHalf_AM_Tuesday);
		((Control)Tuesday).get_Controls().Add((Control)(object)rbFull_Day_Tuesday);
		((Control)Tuesday).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Tuesday).set_Location(new Point(157, 378));
		((Control)Tuesday).set_Name("Tuesday");
		((Control)Tuesday).set_Size(new Size(115, 115));
		((Control)Tuesday).set_TabIndex(31);
		Tuesday.set_TabStop(false);
		Tuesday.set_Text("* Tuesday");
		((ButtonBase)rbAbsent_Tuesday).set_AutoSize(true);
		((Control)rbAbsent_Tuesday).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)rbAbsent_Tuesday).set_Location(new Point(16, 88));
		((Control)rbAbsent_Tuesday).set_Name("rbAbsent_Tuesday");
		((Control)rbAbsent_Tuesday).set_Size(new Size(78, 24));
		((Control)rbAbsent_Tuesday).set_TabIndex(13);
		rbAbsent_Tuesday.set_TabStop(true);
		((ButtonBase)rbAbsent_Tuesday).set_Text("Absent");
		((ButtonBase)rbAbsent_Tuesday).set_UseVisualStyleBackColor(true);
		((ButtonBase)rbHalf_PM_Tuesday).set_AutoSize(true);
		((Control)rbHalf_PM_Tuesday).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)rbHalf_PM_Tuesday).set_Location(new Point(16, 65));
		((Control)rbHalf_PM_Tuesday).set_Name("rbHalf_PM_Tuesday");
		((Control)rbHalf_PM_Tuesday).set_Size(new Size(83, 24));
		((Control)rbHalf_PM_Tuesday).set_TabIndex(12);
		rbHalf_PM_Tuesday.set_TabStop(true);
		((ButtonBase)rbHalf_PM_Tuesday).set_Text("Half PM");
		((ButtonBase)rbHalf_PM_Tuesday).set_UseVisualStyleBackColor(true);
		((ButtonBase)rbHalf_AM_Tuesday).set_AutoSize(true);
		((Control)rbHalf_AM_Tuesday).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)rbHalf_AM_Tuesday).set_Location(new Point(16, 42));
		((Control)rbHalf_AM_Tuesday).set_Name("rbHalf_AM_Tuesday");
		((Control)rbHalf_AM_Tuesday).set_Size(new Size(84, 24));
		((Control)rbHalf_AM_Tuesday).set_TabIndex(11);
		rbHalf_AM_Tuesday.set_TabStop(true);
		((ButtonBase)rbHalf_AM_Tuesday).set_Text("Half AM");
		((ButtonBase)rbHalf_AM_Tuesday).set_UseVisualStyleBackColor(true);
		((ButtonBase)rbFull_Day_Tuesday).set_AutoSize(true);
		((Control)rbFull_Day_Tuesday).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)rbFull_Day_Tuesday).set_Location(new Point(16, 19));
		((Control)rbFull_Day_Tuesday).set_Name("rbFull_Day_Tuesday");
		((Control)rbFull_Day_Tuesday).set_Size(new Size(84, 24));
		((Control)rbFull_Day_Tuesday).set_TabIndex(10);
		rbFull_Day_Tuesday.set_TabStop(true);
		((ButtonBase)rbFull_Day_Tuesday).set_Text("Full Day");
		((ButtonBase)rbFull_Day_Tuesday).set_UseVisualStyleBackColor(true);
		((Control)grpMonday).set_BackColor(Color.ForestGreen);
		((Control)grpMonday).get_Controls().Add((Control)(object)rbAbsent_Monday);
		((Control)grpMonday).get_Controls().Add((Control)(object)rbHalf_PM_Monday);
		((Control)grpMonday).get_Controls().Add((Control)(object)rbHalf_AM_Monday);
		((Control)grpMonday).get_Controls().Add((Control)(object)rbFull_Day_Monday);
		((Control)grpMonday).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)grpMonday).set_Location(new Point(36, 378));
		((Control)grpMonday).set_Name("grpMonday");
		((Control)grpMonday).set_Size(new Size(115, 115));
		((Control)grpMonday).set_TabIndex(30);
		grpMonday.set_TabStop(false);
		grpMonday.set_Text("* Monday ");
		((ButtonBase)rbAbsent_Monday).set_AutoSize(true);
		((Control)rbAbsent_Monday).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)rbAbsent_Monday).set_Location(new Point(16, 88));
		((Control)rbAbsent_Monday).set_Name("rbAbsent_Monday");
		((Control)rbAbsent_Monday).set_Size(new Size(78, 24));
		((Control)rbAbsent_Monday).set_TabIndex(12);
		rbAbsent_Monday.set_TabStop(true);
		((ButtonBase)rbAbsent_Monday).set_Text("Absent");
		((ButtonBase)rbAbsent_Monday).set_UseVisualStyleBackColor(true);
		((ButtonBase)rbHalf_PM_Monday).set_AutoSize(true);
		((Control)rbHalf_PM_Monday).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)rbHalf_PM_Monday).set_Location(new Point(16, 65));
		((Control)rbHalf_PM_Monday).set_Name("rbHalf_PM_Monday");
		((Control)rbHalf_PM_Monday).set_Size(new Size(83, 24));
		((Control)rbHalf_PM_Monday).set_TabIndex(11);
		rbHalf_PM_Monday.set_TabStop(true);
		((ButtonBase)rbHalf_PM_Monday).set_Text("Half PM");
		((ButtonBase)rbHalf_PM_Monday).set_UseVisualStyleBackColor(true);
		((ButtonBase)rbHalf_AM_Monday).set_AutoSize(true);
		((Control)rbHalf_AM_Monday).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)rbHalf_AM_Monday).set_Location(new Point(16, 42));
		((Control)rbHalf_AM_Monday).set_Name("rbHalf_AM_Monday");
		((Control)rbHalf_AM_Monday).set_Size(new Size(84, 24));
		((Control)rbHalf_AM_Monday).set_TabIndex(10);
		rbHalf_AM_Monday.set_TabStop(true);
		((ButtonBase)rbHalf_AM_Monday).set_Text("Half AM");
		((ButtonBase)rbHalf_AM_Monday).set_UseVisualStyleBackColor(true);
		((ButtonBase)rbFull_Day_Monday).set_AutoSize(true);
		((Control)rbFull_Day_Monday).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)rbFull_Day_Monday).set_Location(new Point(16, 19));
		((Control)rbFull_Day_Monday).set_Name("rbFull_Day_Monday");
		((Control)rbFull_Day_Monday).set_Size(new Size(84, 24));
		((Control)rbFull_Day_Monday).set_TabIndex(9);
		rbFull_Day_Monday.set_TabStop(true);
		((ButtonBase)rbFull_Day_Monday).set_Text("Full Day");
		((ButtonBase)rbFull_Day_Monday).set_UseVisualStyleBackColor(true);
		((Control)GroupBox4).get_Controls().Add((Control)(object)Label11);
		((Control)GroupBox4).get_Controls().Add((Control)(object)txtUniqueIdentifier);
		((Control)GroupBox4).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)GroupBox4).set_Location(new Point(354, 89));
		((Control)GroupBox4).set_Name("GroupBox4");
		((Control)GroupBox4).set_Size(new Size(304, 60));
		((Control)GroupBox4).set_TabIndex(38);
		GroupBox4.set_TabStop(false);
		GroupBox4.set_Text("Unique Identifier");
		Label11.set_AutoSize(true);
		((Control)Label11).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label11).set_Location(new Point(19, 23));
		((Control)Label11).set_Name("Label11");
		((Control)Label11).set_Size(new Size(140, 20));
		((Control)Label11).set_TabIndex(1);
		Label11.set_Text("* Unique Identifier:");
		((Control)txtUniqueIdentifier).set_Enabled(false);
		((Control)txtUniqueIdentifier).set_Location(new Point(159, 23));
		((Control)txtUniqueIdentifier).set_Name("txtUniqueIdentifier");
		((Control)txtUniqueIdentifier).set_Size(new Size(130, 22));
		((Control)txtUniqueIdentifier).set_TabIndex(0);
		Label12.set_AutoSize(true);
		((Control)Label12).set_BackColor(Color.ForestGreen);
		((Control)Label12).set_Location(new Point(377, 587));
		((Control)Label12).set_Name("Label12");
		((Control)Label12).set_Size(new Size(40, 13));
		((Control)Label12).set_TabIndex(40);
		Label12.set_Text("Cancel");
		Label13.set_AutoSize(true);
		((Control)Label13).set_BackColor(Color.ForestGreen);
		((Control)Label13).set_Location(new Point(258, 587));
		((Control)Label13).set_Name("Label13");
		((Control)Label13).set_Size(new Size(41, 13));
		((Control)Label13).set_TabIndex(39);
		Label13.set_Text("Accept");
		Label14.set_AutoSize(true);
		((Control)Label14).set_BackColor(Color.ForestGreen);
		((Control)Label14).set_Location(new Point(27, 584));
		((Control)Label14).set_Name("Label14");
		((Control)Label14).set_Size(new Size(75, 13));
		((Control)Label14).set_TabIndex(29);
		Label14.set_Text("Required Field");
		((Control)Label15).set_BackColor(Color.ForestGreen);
		((Control)Label15).set_Font(new Font("Microsoft Sans Serif", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label15).set_Location(new Point(10, 580));
		((Control)Label15).set_Name("Label15");
		((Control)Label15).set_Size(new Size(21, 20));
		((Control)Label15).set_TabIndex(30);
		Label15.set_Text("*");
		clpCancel.set_Image((Image)componentResourceManager.GetObject("clpCancel.Image"));
		((Control)clpCancel).set_Location(new Point(354, 510));
		((Control)clpCancel).set_Name("clpCancel");
		((Control)clpCancel).set_Size(new Size(76, 76));
		clpCancel.set_SizeMode((PictureBoxSizeMode)2);
		clpCancel.set_TabIndex(36);
		clpCancel.set_TabStop(false);
		clpAccept.set_Image((Image)componentResourceManager.GetObject("clpAccept.Image"));
		((Control)clpAccept).set_Location(new Point(241, 510));
		((Control)clpAccept).set_Name("clpAccept");
		((Control)clpAccept).set_Size(new Size(76, 76));
		clpAccept.set_SizeMode((PictureBoxSizeMode)2);
		clpAccept.set_TabIndex(35);
		clpAccept.set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.ForestGreen);
		((Form)this).set_ClientSize(new Size(670, 612));
		((Control)this).get_Controls().Add((Control)(object)Label14);
		((Control)this).get_Controls().Add((Control)(object)Label15);
		((Control)this).get_Controls().Add((Control)(object)Label12);
		((Control)this).get_Controls().Add((Control)(object)Label13);
		((Control)this).get_Controls().Add((Control)(object)GroupBox4);
		((Control)this).get_Controls().Add((Control)(object)clpCancel);
		((Control)this).get_Controls().Add((Control)(object)clpAccept);
		((Control)this).get_Controls().Add((Control)(object)grpFriday);
		((Control)this).get_Controls().Add((Control)(object)grpThursday);
		((Control)this).get_Controls().Add((Control)(object)grpWednesday);
		((Control)this).get_Controls().Add((Control)(object)Tuesday);
		((Control)this).get_Controls().Add((Control)(object)grpMonday);
		((Control)this).get_Controls().Add((Control)(object)GroupBox3);
		((Control)this).get_Controls().Add((Control)(object)GroupBox2);
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).get_Controls().Add((Control)(object)lblName);
		((Control)this).get_Controls().Add((Control)(object)lblUnique);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("Edit");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Edit Child");
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((Control)GroupBox2).ResumeLayout(false);
		((Control)GroupBox2).PerformLayout();
		((Control)GroupBox3).ResumeLayout(false);
		((Control)GroupBox3).PerformLayout();
		((Control)grpFriday).ResumeLayout(false);
		((Control)grpFriday).PerformLayout();
		((Control)grpThursday).ResumeLayout(false);
		((Control)grpThursday).PerformLayout();
		((Control)grpWednesday).ResumeLayout(false);
		((Control)grpWednesday).PerformLayout();
		((Control)Tuesday).ResumeLayout(false);
		((Control)Tuesday).PerformLayout();
		((Control)grpMonday).ResumeLayout(false);
		((Control)grpMonday).PerformLayout();
		((Control)GroupBox4).ResumeLayout(false);
		((Control)GroupBox4).PerformLayout();
		((ISupportInitialize)clpCancel).EndInit();
		((ISupportInitialize)clpAccept).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Edit_Load(object sender, EventArgs e)
	{
		intUniqueID = Conversions.ToInteger(lblUnique.get_Text());
		foreach (Child item in Child.lstChild)
		{
			if (intUniqueID == item.intUnique)
			{
				lblName.set_Text(item.strLastName + ", " + item.strFirstName);
				((Control)lblName).set_Left(checked((int)Math.Round((double)((Control)this).get_Width() / 2.0 - (double)((Control)lblName).get_Width() / 2.0)));
			}
		}
		FillTextBoxes(intUniqueID);
	}

	private void FillTextBoxes(int intUnique)
	{
		foreach (Child item in Child.lstChild)
		{
			if (item.intUnique == intUniqueID)
			{
				txtLastName.set_Text(item.strLastName);
				txtFirstName.set_Text(item.strFirstName);
				txtBirthday.set_Text(item.strBirthday);
				txtFlagDate.set_Text(item.strFlagDate);
				txtStartDate.set_Text(item.strStartDate);
				txtEndDate.set_Text(item.strEndDate);
				txtUniqueIdentifier.set_Text(Conversions.ToString(item.intUnique));
				cboCurrentClassroom.set_Text(item.strCurrentClassroom);
				cboNextClassroom.set_Text(item.strNextClassroom);
				cboCurrentSpecificClassroom.set_Text(item.strCurrentSpecificClassroom);
				cboNextSpecificClassroom.set_Text(item.strNextSpecificClassroom);
				if (Operators.CompareString(cboCurrentSpecificClassroom.get_Text(), "", false) == 0)
				{
					cboCurrentSpecificClassroom.set_Text(Conversions.ToString(cboCurrentSpecificClassroom.get_Items().get_Item(0)));
				}
				if (Operators.CompareString(cboNextSpecificClassroom.get_Text(), "", false) == 0)
				{
					cboNextSpecificClassroom.set_Text(Conversions.ToString(cboCurrentSpecificClassroom.get_Items().get_Item(0)));
				}
				switch (item.strMonday)
				{
				case "Absent":
					rbAbsent_Monday.set_Checked(true);
					break;
				case "Half PM":
					rbHalf_PM_Monday.set_Checked(true);
					break;
				case "Half AM":
					rbHalf_AM_Monday.set_Checked(true);
					break;
				case "Full Day":
					rbFull_Day_Monday.set_Checked(true);
					break;
				}
				switch (item.strTuesday)
				{
				case "Absent":
					rbAbsent_Tuesday.set_Checked(true);
					break;
				case "Half PM":
					rbHalf_PM_Tuesday.set_Checked(true);
					break;
				case "Half AM":
					rbHalf_AM_Tuesday.set_Checked(true);
					break;
				case "Full Day":
					rbFull_Day_Tuesday.set_Checked(true);
					break;
				}
				switch (item.strWednesday)
				{
				case "Absent":
					rbAbsent_Wednesday.set_Checked(true);
					break;
				case "Half PM":
					rbHalf_PM_Wednesday.set_Checked(true);
					break;
				case "Half AM":
					rbHalf_AM_Wednesday.set_Checked(true);
					break;
				case "Full Day":
					rbFull_Day_Wednesday.set_Checked(true);
					break;
				}
				switch (item.strThursday)
				{
				case "Absent":
					rbAbsent_Thursday.set_Checked(true);
					break;
				case "Half PM":
					rbHalf_PM_Thursday.set_Checked(true);
					break;
				case "Half AM":
					rbHalf_AM_Thursday.set_Checked(true);
					break;
				case "Full Day":
					rbFull_Day_Thursday.set_Checked(true);
					break;
				}
				switch (item.strFriday)
				{
				case "Absent":
					rbAbsent_Friday.set_Checked(true);
					break;
				case "Half PM":
					rbHalf_PM_Friday.set_Checked(true);
					break;
				case "Half AM":
					rbHalf_AM_Friday.set_Checked(true);
					break;
				case "Full Day":
					rbFull_Day_Friday.set_Checked(true);
					break;
				}
			}
		}
	}

	private void cboCurrentClassroom_DropDown(object sender, EventArgs e)
	{
		if (cboCurrentClassroom.get_Items().get_Count() == 7)
		{
			cboCurrentClassroom.get_Items().RemoveAt(0);
		}
	}

	private void cboNextClassroom_DropDown(object sender, EventArgs e)
	{
		if (cboNextClassroom.get_Items().get_Count() == 7)
		{
			cboNextClassroom.get_Items().RemoveAt(0);
		}
	}

	private void cboCurrentSpecificClassroom_DropDown(object sender, EventArgs e)
	{
		if (cboCurrentSpecificClassroom.get_Items().get_Count() == 7)
		{
			cboCurrentSpecificClassroom.get_Items().RemoveAt(0);
		}
	}

	private void cboNextSpecificClassroom_DropDown(object sender, EventArgs e)
	{
		if (cboNextSpecificClassroom.get_Items().get_Count() == 7)
		{
			cboNextSpecificClassroom.get_Items().RemoveAt(0);
		}
	}

	private void clpAccept_Click(object sender, EventArgs e)
	{
		InputValidation();
	}

	private void InputValidation()
	{
		//IL_0872: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		if (Operators.CompareString(txtLastName.get_Text(), "", false) == 0)
		{
			flag = true;
		}
		else if (Operators.CompareString(txtFirstName.get_Text(), "", false) == 0)
		{
			flag = true;
		}
		else if ((Operators.CompareString(cboCurrentClassroom.get_Text(), "Caterpillars", false) != 0) & (Operators.CompareString(cboCurrentClassroom.get_Text(), "Turtles/Butterflies", false) != 0) & (Operators.CompareString(cboCurrentClassroom.get_Text(), "Fireflies/Ladybugs", false) != 0) & (Operators.CompareString(cboCurrentClassroom.get_Text(), "Dragonflies/Lions", false) != 0) & (Operators.CompareString(cboCurrentClassroom.get_Text(), "Tree Frogs", false) != 0) & (Operators.CompareString(cboCurrentClassroom.get_Text(), "Kindergarten", false) != 0))
		{
			flag = true;
		}
		else if ((Operators.CompareString(cboNextClassroom.get_Text(), "Caterpillars", false) != 0) & (Operators.CompareString(cboNextClassroom.get_Text(), "Turtles/Butterflies", false) != 0) & (Operators.CompareString(cboNextClassroom.get_Text(), "Fireflies/Ladybugs", false) != 0) & (Operators.CompareString(cboNextClassroom.get_Text(), "Dragonflies/Lions", false) != 0) & (Operators.CompareString(cboNextClassroom.get_Text(), "Tree Frogs", false) != 0) & (Operators.CompareString(cboNextClassroom.get_Text(), "Kindergarten", false) != 0) & (Operators.CompareString(cboNextClassroom.get_Text(), "TBA", false) != 0))
		{
			flag = true;
		}
		else if ((Operators.CompareString(cboCurrentSpecificClassroom.get_Text(), "Turtles", false) != 0) & (Operators.CompareString(cboCurrentSpecificClassroom.get_Text(), "Butterflies", false) != 0) & (Operators.CompareString(cboCurrentSpecificClassroom.get_Text(), "Fireflies", false) != 0) & (Operators.CompareString(cboCurrentSpecificClassroom.get_Text(), "Ladybugs", false) != 0) & (Operators.CompareString(cboCurrentSpecificClassroom.get_Text(), "Dragonflies", false) != 0) & (Operators.CompareString(cboCurrentSpecificClassroom.get_Text(), "Lions", false) != 0) & (Operators.CompareString(cboCurrentSpecificClassroom.get_Text(), "", false) != 0) & (Operators.CompareString(cboCurrentSpecificClassroom.get_Text(), "Select a classroom...", false) != 0))
		{
			flag = true;
		}
		else if ((Operators.CompareString(cboCurrentSpecificClassroom.get_Text(), "Turtles", false) == 0) | (Operators.CompareString(cboCurrentSpecificClassroom.get_Text(), "Butterflies", false) == 0))
		{
			if (Operators.CompareString(cboCurrentClassroom.get_Text(), "Turtles/Butterflies", false) != 0)
			{
				flag = true;
			}
		}
		else if ((Operators.CompareString(cboCurrentSpecificClassroom.get_Text(), "Fireflies", false) == 0) | (Operators.CompareString(cboCurrentSpecificClassroom.get_Text(), "Ladybugs", false) == 0))
		{
			if (Operators.CompareString(cboCurrentClassroom.get_Text(), "Fireflies/Ladybugs", false) != 0)
			{
				flag = true;
			}
		}
		else if ((Operators.CompareString(cboCurrentSpecificClassroom.get_Text(), "Dragonflies", false) == 0) | (Operators.CompareString(cboCurrentSpecificClassroom.get_Text(), "Lions", false) == 0))
		{
			if (Operators.CompareString(cboCurrentClassroom.get_Text(), "Dragonflies/Lions", false) != 0)
			{
				flag = true;
			}
		}
		else if ((Operators.CompareString(cboNextSpecificClassroom.get_Text(), "Turtles", false) != 0) & (Operators.CompareString(cboNextSpecificClassroom.get_Text(), "Butterflies", false) != 0) & (Operators.CompareString(cboNextSpecificClassroom.get_Text(), "Fireflies", false) != 0) & (Operators.CompareString(cboNextSpecificClassroom.get_Text(), "Ladybugs", false) != 0) & (Operators.CompareString(cboNextSpecificClassroom.get_Text(), "Dragonflies", false) != 0) & (Operators.CompareString(cboNextSpecificClassroom.get_Text(), "Lions", false) != 0) & (Operators.CompareString(cboNextSpecificClassroom.get_Text(), "", false) != 0) & (Operators.CompareString(cboNextSpecificClassroom.get_Text(), "Select a classroom...", false) != 0))
		{
			flag = true;
		}
		else if ((Operators.CompareString(cboNextSpecificClassroom.get_Text(), "Turtles", false) == 0) | (Operators.CompareString(cboNextSpecificClassroom.get_Text(), "Butterflies", false) == 0))
		{
			if (Operators.CompareString(cboNextClassroom.get_Text(), "Turtles/Butterflies", false) != 0)
			{
				flag = true;
			}
		}
		else if ((Operators.CompareString(cboNextSpecificClassroom.get_Text(), "Fireflies", false) == 0) | (Operators.CompareString(cboNextSpecificClassroom.get_Text(), "Ladybugs", false) == 0))
		{
			if (Operators.CompareString(cboNextClassroom.get_Text(), "Fireflies/Ladybugs", false) != 0)
			{
				flag = true;
			}
		}
		else if ((Operators.CompareString(cboNextSpecificClassroom.get_Text(), "Dragonflies", false) == 0) | (Operators.CompareString(cboNextSpecificClassroom.get_Text(), "Lions", false) == 0))
		{
			if (Operators.CompareString(cboNextClassroom.get_Text(), "Dragonflies/Lions", false) != 0)
			{
				flag = true;
			}
		}
		else if (!Information.IsDate((object)txtBirthday.get_Text()) | (txtBirthday.get_Text().Length != 10))
		{
			flag = true;
		}
		else if ((Operators.CompareString(txtFlagDate.get_Text(), "", false) != 0) & (Operators.CompareString(txtFlagDate.get_Text(), "None", false) != 0))
		{
			if (!Information.IsDate((object)txtFlagDate.get_Text()) | (txtFlagDate.get_Text().Length != 10))
			{
				flag = true;
			}
		}
		else if (Operators.CompareString(txtStartDate.get_Text(), "", false) != 0)
		{
			if (!Information.IsDate((object)txtStartDate.get_Text()) | (txtStartDate.get_Text().Length != 10))
			{
				flag = true;
			}
		}
		else if (Operators.CompareString(txtEndDate.get_Text(), "", false) != 0)
		{
			if (!Information.IsDate((object)txtEndDate.get_Text()) | (txtEndDate.get_Text().Length != 10))
			{
				flag = true;
			}
		}
		else if (!rbFull_Day_Monday.get_Checked() & !rbHalf_AM_Monday.get_Checked() & !rbHalf_PM_Monday.get_Checked() & !rbAbsent_Monday.get_Checked())
		{
			flag = true;
		}
		else if (!rbFull_Day_Tuesday.get_Checked() & !rbHalf_AM_Tuesday.get_Checked() & !rbHalf_PM_Tuesday.get_Checked() & !rbAbsent_Tuesday.get_Checked())
		{
			flag = true;
		}
		else if (!rbFull_Day_Wednesday.get_Checked() & !rbHalf_AM_Wednesday.get_Checked() & !rbHalf_PM_Wednesday.get_Checked() & !rbAbsent_Wednesday.get_Checked())
		{
			flag = true;
		}
		else if (!rbFull_Day_Thursday.get_Checked() & !rbHalf_AM_Thursday.get_Checked() & !rbHalf_PM_Thursday.get_Checked() & !rbAbsent_Thursday.get_Checked())
		{
			flag = true;
		}
		else if (!rbFull_Day_Friday.get_Checked() & !rbHalf_AM_Friday.get_Checked() & !rbHalf_PM_Friday.get_Checked() & !rbAbsent_Friday.get_Checked())
		{
			flag = true;
		}
		if (Operators.CompareString(cboCurrentSpecificClassroom.get_Text(), "Select a classroom...", false) == 0)
		{
			cboCurrentSpecificClassroom.set_Text("");
		}
		if (Operators.CompareString(cboNextSpecificClassroom.get_Text(), "Select a classroom...", false) == 0)
		{
			cboNextSpecificClassroom.set_Text("");
		}
		if (!flag)
		{
			UpdateChild();
		}
		else
		{
			MessageBox.Show("Error - Please check the following:\r\n\r\n - Required fields are not left blank.\r\n - Date format is correct (mm/dd/yyyy).\r\n - Classrooms are one of the given options.\r\n - One time slot is selected for each day of the week.\r\n - Current Specific Classroom and Next Specific Classroom logically correspond\r\n     with what is selected in Current Classroom and Next Classroom, respectively.", " Error");
		}
	}

	private void UpdateChild()
	{
		int num = Conversions.ToInteger(txtUniqueIdentifier.get_Text());
		foreach (Child item in Child.lstChild)
		{
			if (item.intUnique == num)
			{
				item.strLastName = txtLastName.get_Text();
				item.strFirstName = txtFirstName.get_Text();
				item.strBirthday = txtBirthday.get_Text();
				item.strFlagDate = txtFlagDate.get_Text();
				if (Operators.CompareString(item.strFlagDate, "", false) == 0)
				{
					item.strFlagDate = "None";
				}
				item.strCurrentClassroom = cboCurrentClassroom.get_Text();
				item.strNextClassroom = cboNextClassroom.get_Text();
				item.strCurrentSpecificClassroom = cboCurrentSpecificClassroom.get_Text();
				item.strNextSpecificClassroom = cboNextSpecificClassroom.get_Text();
				item.strMonday = DaysOfTheWeek("Monday");
				item.strTuesday = DaysOfTheWeek("Tuesday");
				item.strWednesday = DaysOfTheWeek("Wednesday");
				item.strThursday = DaysOfTheWeek("Thursday");
				item.strFriday = DaysOfTheWeek("Friday");
				item.strStartDate = txtStartDate.get_Text();
				item.strEndDate = txtEndDate.get_Text();
				Add_New_Screen add_New_Screen = new Add_New_Screen();
				item.intAge = add_New_Screen.GetAge(txtBirthday.get_Text());
				item.intMonths = add_New_Screen.GetMonths(txtBirthday.get_Text());
				Database_Handling database_Handling = new Database_Handling();
				database_Handling.EditChild(item.strLastName, item.strFirstName, item.strBirthday, item.strFlagDate, item.strCurrentClassroom, item.strNextClassroom, item.strCurrentSpecificClassroom, item.strNextSpecificClassroom, item.strMonday, item.strTuesday, item.strWednesday, item.strThursday, item.strFriday, item.strStartDate, item.strEndDate, item.intAge, item.intMonths, item.intUnique);
				((Form)this).Close();
			}
		}
	}

	private string DaysOfTheWeek(string strDayTime)
	{
		string result = "";
		switch (strDayTime)
		{
		case "Friday":
			result = ((!rbFull_Day_Friday.get_Checked()) ? ((!rbHalf_AM_Friday.get_Checked()) ? ((!rbHalf_PM_Friday.get_Checked()) ? "Absent" : "Half PM") : "Half AM") : "Full Day");
			break;
		case "Thursday":
			result = ((!rbFull_Day_Thursday.get_Checked()) ? ((!rbHalf_AM_Thursday.get_Checked()) ? ((!rbHalf_PM_Thursday.get_Checked()) ? "Absent" : "Half PM") : "Half AM") : "Full Day");
			break;
		case "Wednesday":
			result = ((!rbFull_Day_Wednesday.get_Checked()) ? ((!rbHalf_AM_Wednesday.get_Checked()) ? ((!rbHalf_PM_Wednesday.get_Checked()) ? "Absent" : "Half PM") : "Half AM") : "Full Day");
			break;
		case "Tuesday":
			result = ((!rbFull_Day_Tuesday.get_Checked()) ? ((!rbHalf_AM_Tuesday.get_Checked()) ? ((!rbHalf_PM_Tuesday.get_Checked()) ? "Absent" : "Half PM") : "Half AM") : "Full Day");
			break;
		case "Monday":
			result = ((!rbFull_Day_Monday.get_Checked()) ? ((!rbHalf_AM_Monday.get_Checked()) ? ((!rbHalf_PM_Monday.get_Checked()) ? "Absent" : "Half PM") : "Half AM") : "Full Day");
			break;
		}
		return result;
	}

	private void clpCancel_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}
}
