using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Gt7;
using Hr60;
using Microsoft.VisualBasic.CompilerServices;
using c1F9;
using t8C;

namespace i9AG;

[DesignerGenerated]
public class Kb17 : Form
{
	private IContainer components;

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DataGridView StudentGridView
	{
		[CompilerGenerated]
		get
		{
			return _StudentGridView;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			DataGridViewCellEventHandler val = new DataGridViewCellEventHandler(Ap3t);
			EventHandler eventHandler = s3LA;
			DataGridView studentGridView = _StudentGridView;
			if (studentGridView != null)
			{
				studentGridView.remove_CellClick(val);
				((Control)studentGridView).remove_DoubleClick(eventHandler);
			}
			_StudentGridView = value;
			studentGridView = _StudentGridView;
			if (studentGridView != null)
			{
				studentGridView.add_CellClick(val);
				((Control)studentGridView).add_DoubleClick(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Column1")]
	internal virtual DataGridViewTextBoxColumn Column1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column2")]
	internal virtual DataGridViewTextBoxColumn Column2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column3")]
	internal virtual DataGridViewTextBoxColumn Column3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column4")]
	internal virtual DataGridViewTextBoxColumn Column4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column5")]
	internal virtual DataGridViewTextBoxColumn Column5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column6")]
	internal virtual DataGridViewTextBoxColumn Column6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column7")]
	internal virtual DataGridViewTextBoxColumn Column7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column8")]
	internal virtual DataGridViewTextBoxColumn Column8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column9")]
	internal virtual DataGridViewTextBoxColumn Column9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column10")]
	internal virtual DataGridViewTextBoxColumn Column10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DOBPick")]
	internal virtual DateTimePicker DOBPick
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel7")]
	internal virtual Panel Panel7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel4")]
	internal virtual Panel Panel4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtFname")]
	internal virtual TextBox txtFname
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel2")]
	internal virtual Panel Panel2
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

	[field: AccessedThroughProperty("txtSurname")]
	internal virtual TextBox txtSurname
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtReg")]
	internal virtual TextBox txtReg
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

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
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

	[field: AccessedThroughProperty("cmbClass")]
	internal virtual ComboBox cmbClass
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel10")]
	internal virtual Panel Panel10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtNational")]
	internal virtual TextBox txtNational
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel9")]
	internal virtual Panel Panel9
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

	[field: AccessedThroughProperty("Panel12")]
	internal virtual Panel Panel12
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtAddress")]
	internal virtual TextBox txtAddress
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

	[field: AccessedThroughProperty("Panel8")]
	internal virtual Panel Panel8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtGuid")]
	internal virtual TextBox txtGuid
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel6")]
	internal virtual Panel Panel6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPhone")]
	internal virtual TextBox txtPhone
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

	[field: AccessedThroughProperty("Label11")]
	internal virtual Label Label11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button2
	{
		[CompilerGenerated]
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = d5B3;
			Button button = _Button2;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button2 = value;
			button = _Button2;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button btnUpdat
	{
		[CompilerGenerated]
		get
		{
			return _btnUpdat;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Ab92;
			Button val = _btnUpdat;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnUpdat = value;
			val = _btnUpdat;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel5")]
	internal virtual Panel Panel5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox txtSearch
	{
		[CompilerGenerated]
		get
		{
			return _txtSearch;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = p7G2;
			EventHandler eventHandler2 = Df47;
			TextBox val = _txtSearch;
			if (val != null)
			{
				((TextBoxBase)val).remove_Click(eventHandler);
				((Control)val).remove_Leave(eventHandler2);
			}
			_txtSearch = value;
			val = _txtSearch;
			if (val != null)
			{
				((TextBoxBase)val).add_Click(eventHandler);
				((Control)val).add_Leave(eventHandler2);
			}
		}
	}

	private virtual Button avatar
	{
		[CompilerGenerated]
		get
		{
			return _avatar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Em25;
			Button val = _avatar;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_avatar = value;
			val = _avatar;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PictureBox1")]
	internal virtual PictureBox PictureBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PictureBox2")]
	internal virtual PictureBox PictureBox2
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

	[field: AccessedThroughProperty("Label9")]
	internal virtual Label Label9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTotalFemale")]
	internal virtual Label lblTotalFemale
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTotalMale")]
	internal virtual Label lblTotalMale
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTotal")]
	internal virtual Label lblTotal
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label17")]
	internal virtual Label Label17
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PictureBox3")]
	internal virtual PictureBox PictureBox3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button1
	{
		[CompilerGenerated]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Pi90;
			Button button = _Button1;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button1 = value;
			button = _Button1;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Label18")]
	internal virtual Label Label18
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ComboBox cmbFilterClass
	{
		[CompilerGenerated]
		get
		{
			return _cmbFilterClass;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = j3K7;
			ComboBox val = _cmbFilterClass;
			if (val != null)
			{
				val.remove_SelectedIndexChanged(eventHandler);
			}
			_cmbFilterClass = value;
			val = _cmbFilterClass;
			if (val != null)
			{
				val.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("cmbGender")]
	internal virtual ComboBox cmbGender
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

	internal virtual Button Button3
	{
		[CompilerGenerated]
		get
		{
			return _Button3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Py69;
			Button button = _Button3;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button3 = value;
			button = _Button3;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Panel11")]
	internal virtual Panel Panel11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("LabelBelow")]
	internal virtual Label LabelBelow
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lbTotal")]
	internal virtual Label lbTotal
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblClassName")]
	internal virtual Label lblClassName
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Label Label15
	{
		[CompilerGenerated]
		get
		{
			return _Label15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = a5K0;
			Label label = _Label15;
			if (label != null)
			{
				((Control)label).remove_Click(eventHandler);
			}
			_Label15 = value;
			label = _Label15;
			if (label != null)
			{
				((Control)label).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Panel13")]
	internal virtual Panel Panel13
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

	[field: AccessedThroughProperty("Label19")]
	internal virtual Label Label19
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDesicion")]
	internal virtual Label lblDesicion
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label20")]
	internal virtual Label Label20
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	private virtual Button Button5
	{
		[CompilerGenerated]
		get
		{
			return _Button5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Zb1s;
			Button button = _Button5;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button5 = value;
			button = _Button5;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Label14")]
	internal virtual Label Label14
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Button4")]
	private virtual Button Button4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Kb17()
	{
		((Form)this).add_Load((EventHandler)Ns4c);
		Kd78();
	}

	[DebuggerNonUserCode]
	protected override void Mj1n(bool a9YL)
	{
		try
		{
			if (a9YL && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(a9YL);
		}
	}

	[DebuggerStepThrough]
	private void Kd78()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected O, but got Unknown
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected O, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected O, but got Unknown
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected O, but got Unknown
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected O, but got Unknown
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected O, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected O, but got Unknown
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected O, but got Unknown
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected O, but got Unknown
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected O, but got Unknown
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected O, but got Unknown
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected O, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected O, but got Unknown
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected O, but got Unknown
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected O, but got Unknown
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected O, but got Unknown
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected O, but got Unknown
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected O, but got Unknown
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Expected O, but got Unknown
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected O, but got Unknown
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected O, but got Unknown
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected O, but got Unknown
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected O, but got Unknown
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Expected O, but got Unknown
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected O, but got Unknown
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Expected O, but got Unknown
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Expected O, but got Unknown
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected O, but got Unknown
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Expected O, but got Unknown
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected O, but got Unknown
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Expected O, but got Unknown
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Expected O, but got Unknown
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Expected O, but got Unknown
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected O, but got Unknown
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Expected O, but got Unknown
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Expected O, but got Unknown
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Expected O, but got Unknown
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Expected O, but got Unknown
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Expected O, but got Unknown
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected O, but got Unknown
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Expected O, but got Unknown
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Expected O, but got Unknown
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Expected O, but got Unknown
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Expected O, but got Unknown
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected O, but got Unknown
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Expected O, but got Unknown
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Expected O, but got Unknown
		//IL_050a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0514: Expected O, but got Unknown
		//IL_0650: Unknown result type (might be due to invalid IL or missing references)
		//IL_065a: Expected O, but got Unknown
		//IL_083e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0848: Expected O, but got Unknown
		//IL_0b29: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b33: Expected O, but got Unknown
		//IL_0d03: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0d: Expected O, but got Unknown
		//IL_0ebe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec8: Expected O, but got Unknown
		//IL_0f6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f74: Expected O, but got Unknown
		//IL_0ff2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ffc: Expected O, but got Unknown
		//IL_1099: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a3: Expected O, but got Unknown
		//IL_1140: Unknown result type (might be due to invalid IL or missing references)
		//IL_114a: Expected O, but got Unknown
		//IL_11e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ee: Expected O, but got Unknown
		//IL_129f: Unknown result type (might be due to invalid IL or missing references)
		//IL_12a9: Expected O, but got Unknown
		//IL_14a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ab: Expected O, but got Unknown
		//IL_15ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_15c4: Expected O, but got Unknown
		//IL_1662: Unknown result type (might be due to invalid IL or missing references)
		//IL_166c: Expected O, but got Unknown
		//IL_17b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_17bc: Expected O, but got Unknown
		//IL_1840: Unknown result type (might be due to invalid IL or missing references)
		//IL_184a: Expected O, but got Unknown
		//IL_1993: Unknown result type (might be due to invalid IL or missing references)
		//IL_199d: Expected O, but got Unknown
		//IL_1ac6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ad0: Expected O, but got Unknown
		//IL_1b51: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b5b: Expected O, but got Unknown
		//IL_1bfc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c06: Expected O, but got Unknown
		//IL_1cca: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cd4: Expected O, but got Unknown
		//IL_1d96: Unknown result type (might be due to invalid IL or missing references)
		//IL_1da0: Expected O, but got Unknown
		//IL_1f7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f87: Expected O, but got Unknown
		//IL_2034: Unknown result type (might be due to invalid IL or missing references)
		//IL_203e: Expected O, but got Unknown
		//IL_228a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2294: Expected O, but got Unknown
		//IL_2337: Unknown result type (might be due to invalid IL or missing references)
		//IL_2341: Expected O, but got Unknown
		//IL_2450: Unknown result type (might be due to invalid IL or missing references)
		//IL_245a: Expected O, but got Unknown
		//IL_24f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2501: Expected O, but got Unknown
		//IL_2597: Unknown result type (might be due to invalid IL or missing references)
		//IL_25a1: Expected O, but got Unknown
		//IL_2638: Unknown result type (might be due to invalid IL or missing references)
		//IL_2642: Expected O, but got Unknown
		//IL_26d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_26e3: Expected O, but got Unknown
		//IL_2775: Unknown result type (might be due to invalid IL or missing references)
		//IL_277f: Expected O, but got Unknown
		//IL_2837: Unknown result type (might be due to invalid IL or missing references)
		//IL_2841: Expected O, but got Unknown
		//IL_2991: Unknown result type (might be due to invalid IL or missing references)
		//IL_299b: Expected O, but got Unknown
		//IL_2a35: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a3f: Expected O, but got Unknown
		//IL_2b43: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b4d: Expected O, but got Unknown
		//IL_2be4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bee: Expected O, but got Unknown
		//IL_2c85: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c8f: Expected O, but got Unknown
		//IL_2d2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d34: Expected O, but got Unknown
		//IL_2eb8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ec2: Expected O, but got Unknown
		//IL_2f78: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f82: Expected O, but got Unknown
		//IL_3045: Unknown result type (might be due to invalid IL or missing references)
		//IL_304f: Expected O, but got Unknown
		//IL_3110: Unknown result type (might be due to invalid IL or missing references)
		//IL_311a: Expected O, but got Unknown
		//IL_347b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3485: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Kb17));
		Panel1 = new Panel();
		Label20 = new Label();
		Button5 = new Button();
		Label1 = new Label();
		avatar = new Button();
		Panel5 = new Panel();
		txtSearch = new TextBox();
		StudentGridView = new DataGridView();
		Column1 = new DataGridViewTextBoxColumn();
		Column2 = new DataGridViewTextBoxColumn();
		Column3 = new DataGridViewTextBoxColumn();
		Column4 = new DataGridViewTextBoxColumn();
		Column5 = new DataGridViewTextBoxColumn();
		Column6 = new DataGridViewTextBoxColumn();
		Column7 = new DataGridViewTextBoxColumn();
		Column8 = new DataGridViewTextBoxColumn();
		Column9 = new DataGridViewTextBoxColumn();
		Column10 = new DataGridViewTextBoxColumn();
		DOBPick = new DateTimePicker();
		Panel7 = new Panel();
		Panel4 = new Panel();
		txtFname = new TextBox();
		Panel2 = new Panel();
		Panel3 = new Panel();
		txtSurname = new TextBox();
		txtReg = new TextBox();
		Label4 = new Label();
		Label5 = new Label();
		Label3 = new Label();
		Label2 = new Label();
		cmbClass = new ComboBox();
		Panel10 = new Panel();
		txtNational = new TextBox();
		Panel9 = new Panel();
		Label7 = new Label();
		Label8 = new Label();
		Panel12 = new Panel();
		txtAddress = new TextBox();
		Label13 = new Label();
		Panel8 = new Panel();
		txtGuid = new TextBox();
		Panel6 = new Panel();
		txtPhone = new TextBox();
		Label10 = new Label();
		Label11 = new Label();
		Button2 = new Button();
		btnUpdat = new Button();
		GroupBox1 = new GroupBox();
		Label14 = new Label();
		Button4 = new Button();
		Panel11 = new Panel();
		Label19 = new Label();
		Label15 = new Label();
		Panel13 = new Panel();
		Label16 = new Label();
		LabelBelow = new Label();
		lbTotal = new Label();
		lblClassName = new Label();
		lblDesicion = new Label();
		Label18 = new Label();
		cmbFilterClass = new ComboBox();
		lblTotal = new Label();
		Label17 = new Label();
		PictureBox3 = new PictureBox();
		lblTotalFemale = new Label();
		lblTotalMale = new Label();
		Label12 = new Label();
		Label9 = new Label();
		PictureBox2 = new PictureBox();
		PictureBox1 = new PictureBox();
		Button1 = new Button();
		cmbGender = new ComboBox();
		Label6 = new Label();
		Button3 = new Button();
		((Control)Panel1).SuspendLayout();
		((ISupportInitialize)StudentGridView).BeginInit();
		((Control)GroupBox1).SuspendLayout();
		((Control)Panel11).SuspendLayout();
		((Control)Panel13).SuspendLayout();
		((ISupportInitialize)PictureBox3).BeginInit();
		((ISupportInitialize)PictureBox2).BeginInit();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Panel1).set_BackColor(Color.FromArgb(255, 108, 16));
		((Control)Panel1).get_Controls().Add((Control)(object)Label20);
		((Control)Panel1).get_Controls().Add((Control)(object)Button5);
		((Control)Panel1).get_Controls().Add((Control)(object)Label1);
		((Control)Panel1).get_Controls().Add((Control)(object)avatar);
		((Control)Panel1).get_Controls().Add((Control)(object)Panel5);
		((Control)Panel1).get_Controls().Add((Control)(object)txtSearch);
		((Control)Panel1).set_Dock((DockStyle)1);
		((Control)Panel1).set_Location(new Point(0, 0));
		((Control)Panel1).set_Name("Panel1");
		((Control)Panel1).set_Size(new Size(1059, 49));
		((Control)Panel1).set_TabIndex(2);
		Label20.set_AutoSize(true);
		((Control)Label20).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label20).set_ForeColor(Color.FromArgb(224, 224, 224));
		((Control)Label20).set_Location(new Point(965, 11));
		((Control)Label20).set_Name("Label20");
		((Control)Label20).set_Size(new Size(82, 24));
		((Control)Label20).set_TabIndex(110);
		Label20.set_Text("Refresh");
		((ButtonBase)Button5).set_BackColor(Color.FromArgb(255, 108, 16));
		((Control)Button5).set_BackgroundImageLayout((ImageLayout)4);
		((ButtonBase)Button5).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)Button5).set_FlatStyle((FlatStyle)0);
		((Control)Button5).set_Location(new Point(914, 0));
		((Control)Button5).set_Name("Button5");
		((Control)Button5).set_Size(new Size(54, 45));
		((Control)Button5).set_TabIndex(98);
		((ButtonBase)Button5).set_UseVisualStyleBackColor(false);
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_ForeColor(Color.FromArgb(224, 224, 224));
		((Control)Label1).set_Location(new Point(12, 13));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(198, 24));
		((Control)Label1).set_TabIndex(97);
		Label1.set_Text("Registered Students");
		((ButtonBase)avatar).set_BackColor(Color.FromArgb(255, 108, 16));
		((Control)avatar).set_BackgroundImageLayout((ImageLayout)4);
		((ButtonBase)avatar).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)avatar).set_FlatStyle((FlatStyle)0);
		((Control)avatar).set_Location(new Point(804, 8));
		((Control)avatar).set_Name("avatar");
		((Control)avatar).set_Size(new Size(45, 25));
		((Control)avatar).set_TabIndex(94);
		((ButtonBase)avatar).set_UseVisualStyleBackColor(false);
		((Control)Panel5).set_BackColor(Color.FromArgb(224, 224, 224));
		((Control)Panel5).set_ForeColor(Color.FromArgb(224, 224, 224));
		((Control)Panel5).set_Location(new Point(518, 35));
		((Control)Panel5).set_Name("Panel5");
		((Control)Panel5).set_Size(new Size(332, 2));
		((Control)Panel5).set_TabIndex(93);
		((TextBoxBase)txtSearch).set_BackColor(Color.FromArgb(255, 108, 16));
		((TextBoxBase)txtSearch).set_BorderStyle((BorderStyle)0);
		((Control)txtSearch).set_Font(new Font("Arial Narrow", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)txtSearch).set_ForeColor(Color.DarkGray);
		((Control)txtSearch).set_Location(new Point(520, 8));
		((Control)txtSearch).set_Name("txtSearch");
		((Control)txtSearch).set_Size(new Size(288, 25));
		((Control)txtSearch).set_TabIndex(92);
		txtSearch.set_Text("Use StudentId to search");
		StudentGridView.set_BackgroundColor(Color.White);
		StudentGridView.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		StudentGridView.get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[10]
		{
			(DataGridViewColumn)Column1,
			(DataGridViewColumn)Column2,
			(DataGridViewColumn)Column3,
			(DataGridViewColumn)Column4,
			(DataGridViewColumn)Column5,
			(DataGridViewColumn)Column6,
			(DataGridViewColumn)Column7,
			(DataGridViewColumn)Column8,
			(DataGridViewColumn)Column9,
			(DataGridViewColumn)Column10
		});
		((Control)StudentGridView).set_Location(new Point(6, 341));
		((Control)StudentGridView).set_Name("StudentGridView");
		((Control)StudentGridView).set_Size(new Size(1045, 297));
		((Control)StudentGridView).set_TabIndex(3);
		((DataGridViewColumn)Column1).set_HeaderText("StudentID");
		((DataGridViewColumn)Column1).set_Name("Column1");
		((DataGridViewColumn)Column2).set_HeaderText("Stud Name");
		((DataGridViewColumn)Column2).set_Name("Column2");
		((DataGridViewColumn)Column3).set_HeaderText("Surname");
		((DataGridViewColumn)Column3).set_Name("Column3");
		((DataGridViewColumn)Column4).set_HeaderText("D_O_B");
		((DataGridViewColumn)Column4).set_Name("Column4");
		((DataGridViewColumn)Column5).set_HeaderText("Gender");
		((DataGridViewColumn)Column5).set_Name("Column5");
		((DataGridViewColumn)Column6).set_HeaderText("Nationality");
		((DataGridViewColumn)Column6).set_Name("Column6");
		((DataGridViewColumn)Column7).set_HeaderText("Class");
		((DataGridViewColumn)Column7).set_Name("Column7");
		((DataGridViewColumn)Column8).set_HeaderText("Address");
		((DataGridViewColumn)Column8).set_Name("Column8");
		((DataGridViewColumn)Column9).set_HeaderText("Gaurdian");
		((DataGridViewColumn)Column9).set_Name("Column9");
		((DataGridViewColumn)Column10).set_HeaderText("Phone");
		((DataGridViewColumn)Column10).set_Name("Column10");
		DOBPick.set_CalendarForeColor(SystemColors.ButtonFace);
		DOBPick.set_CalendarMonthBackground(Color.FromArgb(30, 47, 68));
		((Control)DOBPick).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		DOBPick.set_Format((DateTimePickerFormat)2);
		((Control)DOBPick).set_Location(new Point(244, 187));
		((Control)DOBPick).set_Name("DOBPick");
		((Control)DOBPick).set_Size(new Size(179, 29));
		((Control)DOBPick).set_TabIndex(78);
		DOBPick.set_Value(new DateTime(2019, 1, 31, 0, 0, 0, 0));
		((Control)Panel7).set_BackColor(Color.FromArgb(224, 224, 224));
		((Control)Panel7).set_ForeColor(Color.FromArgb(224, 224, 224));
		((Control)Panel7).set_Location(new Point(73, 223));
		((Control)Panel7).set_Name("Panel7");
		((Control)Panel7).set_Size(new Size(351, 2));
		((Control)Panel7).set_TabIndex(77);
		((Control)Panel4).set_BackColor(Color.FromArgb(224, 224, 224));
		((Control)Panel4).set_ForeColor(Color.FromArgb(224, 224, 224));
		((Control)Panel4).set_Location(new Point(77, 179));
		((Control)Panel4).set_Name("Panel4");
		((Control)Panel4).set_Size(new Size(351, 2));
		((Control)Panel4).set_TabIndex(76);
		((TextBoxBase)txtFname).set_BackColor(Color.FromArgb(30, 47, 68));
		((TextBoxBase)txtFname).set_BorderStyle((BorderStyle)0);
		((Control)txtFname).set_Font(new Font("Century Gothic", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)txtFname).set_ForeColor(SystemColors.ControlDarkDark);
		((Control)txtFname).set_Location(new Point(120, 145));
		((Control)txtFname).set_Name("txtFname");
		((Control)txtFname).set_Size(new Size(307, 26));
		((Control)txtFname).set_TabIndex(75);
		((Control)Panel2).set_BackColor(Color.FromArgb(224, 224, 224));
		((Control)Panel2).set_ForeColor(Color.FromArgb(224, 224, 224));
		((Control)Panel2).set_Location(new Point(73, 137));
		((Control)Panel2).set_Name("Panel2");
		((Control)Panel2).set_Size(new Size(351, 2));
		((Control)Panel2).set_TabIndex(73);
		((Control)Panel3).set_BackColor(Color.FromArgb(224, 224, 224));
		((Control)Panel3).set_ForeColor(Color.FromArgb(224, 224, 224));
		((Control)Panel3).set_Location(new Point(74, 96));
		((Control)Panel3).set_Name("Panel3");
		((Control)Panel3).set_Size(new Size(351, 2));
		((Control)Panel3).set_TabIndex(74);
		((TextBoxBase)txtSurname).set_BackColor(Color.FromArgb(30, 47, 68));
		((TextBoxBase)txtSurname).set_BorderStyle((BorderStyle)0);
		((Control)txtSurname).set_Font(new Font("Century Gothic", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)txtSurname).set_ForeColor(SystemColors.ControlDarkDark);
		((Control)txtSurname).set_Location(new Point(116, 103));
		((Control)txtSurname).set_Name("txtSurname");
		((Control)txtSurname).set_Size(new Size(307, 26));
		((Control)txtSurname).set_TabIndex(72);
		((TextBoxBase)txtReg).set_BackColor(Color.FromArgb(30, 47, 68));
		((TextBoxBase)txtReg).set_BorderStyle((BorderStyle)0);
		((Control)txtReg).set_Enabled(false);
		((Control)txtReg).set_Font(new Font("Century Gothic", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)txtReg).set_ForeColor(SystemColors.ScrollBar);
		((Control)txtReg).set_Location(new Point(118, 63));
		((Control)txtReg).set_Name("txtReg");
		((Control)txtReg).set_Size(new Size(311, 26));
		((Control)txtReg).set_TabIndex(71);
		Label4.set_AutoSize(true);
		((Control)Label4).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label4).set_ForeColor(Color.FromArgb(224, 224, 224));
		((Control)Label4).set_Location(new Point(6, 197));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(123, 24));
		((Control)Label4).set_TabIndex(70);
		Label4.set_Text("Date of Birth");
		Label5.set_AutoSize(true);
		((Control)Label5).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label5).set_ForeColor(Color.FromArgb(224, 224, 224));
		((Control)Label5).set_Location(new Point(6, 154));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(111, 24));
		((Control)Label5).set_TabIndex(69);
		Label5.set_Text("First Name");
		Label3.set_AutoSize(true);
		((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_ForeColor(Color.FromArgb(224, 224, 224));
		((Control)Label3).set_Location(new Point(6, 114));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(94, 24));
		((Control)Label3).set_TabIndex(68);
		Label3.set_Text("Surname");
		Label2.set_AutoSize(true);
		((Control)Label2).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_ForeColor(Color.FromArgb(224, 224, 224));
		((Control)Label2).set_Location(new Point(6, 71));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(106, 24));
		((Control)Label2).set_TabIndex(67);
		Label2.set_Text("Student ID");
		cmbClass.set_BackColor(Color.FromArgb(30, 47, 68));
		cmbClass.set_FlatStyle((FlatStyle)1);
		((Control)cmbClass).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		cmbClass.set_ForeColor(SystemColors.Info);
		((ListControl)cmbClass).set_FormattingEnabled(true);
		cmbClass.get_Items().AddRange(new object[18]
		{
			"1 A", "1 B", "1 C", "2 A", "2 B", "2 C", "3 A", "3 B", "3 C", "4 A",
			"4 B", "4 C", "5 COMMERCIALS", "5 ARTS", "5 SCIENCES", "6 ARTS", "6 COMMERCIALS", "6 SCIENCES"
		});
		((Control)cmbClass).set_Location(new Point(244, 274));
		((Control)cmbClass).set_Name("cmbClass");
		((Control)cmbClass).set_Size(new Size(179, 33));
		((Control)cmbClass).set_TabIndex(84);
		cmbClass.set_Text("Choose class");
		((Control)Panel10).set_BackColor(Color.FromArgb(224, 224, 224));
		((Control)Panel10).set_ForeColor(Color.FromArgb(224, 224, 224));
		((Control)Panel10).set_Location(new Point(76, 267));
		((Control)Panel10).set_Name("Panel10");
		((Control)Panel10).set_Size(new Size(351, 2));
		((Control)Panel10).set_TabIndex(83);
		((TextBoxBase)txtNational).set_BackColor(Color.FromArgb(30, 47, 68));
		((TextBoxBase)txtNational).set_BorderStyle((BorderStyle)0);
		((Control)txtNational).set_Font(new Font("Century Gothic", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)txtNational).set_ForeColor(SystemColors.ControlDarkDark);
		((Control)txtNational).set_Location(new Point(120, 235));
		((Control)txtNational).set_Name("txtNational");
		((Control)txtNational).set_Size(new Size(311, 26));
		((Control)txtNational).set_TabIndex(81);
		((Control)Panel9).set_BackColor(Color.FromArgb(224, 224, 224));
		((Control)Panel9).set_ForeColor(Color.FromArgb(224, 224, 224));
		((Control)Panel9).set_Location(new Point(72, 312));
		((Control)Panel9).set_Name("Panel9");
		((Control)Panel9).set_Size(new Size(351, 2));
		((Control)Panel9).set_TabIndex(82);
		Label7.set_AutoSize(true);
		((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label7).set_ForeColor(Color.FromArgb(224, 224, 224));
		((Control)Label7).set_Location(new Point(11, 280));
		((Control)Label7).set_Name("Label7");
		((Control)Label7).set_Size(new Size(60, 24));
		((Control)Label7).set_TabIndex(80);
		Label7.set_Text("Class");
		Label8.set_AutoSize(true);
		((Control)Label8).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label8).set_ForeColor(Color.FromArgb(224, 224, 224));
		((Control)Label8).set_Location(new Point(11, 240));
		((Control)Label8).set_Name("Label8");
		((Control)Label8).set_Size(new Size(106, 24));
		((Control)Label8).set_TabIndex(79);
		Label8.set_Text("Nationality");
		((Control)Panel12).set_BackColor(Color.FromArgb(224, 224, 224));
		((Control)Panel12).set_ForeColor(Color.FromArgb(224, 224, 224));
		((Control)Panel12).set_Location(new Point(569, 181));
		((Control)Panel12).set_Name("Panel12");
		((Control)Panel12).set_Size(new Size(332, 2));
		((Control)Panel12).set_TabIndex(91);
		((TextBoxBase)txtAddress).set_BackColor(Color.FromArgb(30, 47, 68));
		((TextBoxBase)txtAddress).set_BorderStyle((BorderStyle)0);
		((Control)txtAddress).set_Font(new Font("Century Gothic", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)txtAddress).set_ForeColor(SystemColors.ScrollBar);
		((Control)txtAddress).set_Location(new Point(616, 147));
		((Control)txtAddress).set_Name("txtAddress");
		((Control)txtAddress).set_Size(new Size(288, 26));
		((Control)txtAddress).set_TabIndex(90);
		Label13.set_AutoSize(true);
		((Control)Label13).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label13).set_ForeColor(Color.FromArgb(224, 224, 224));
		((Control)Label13).set_Location(new Point(441, 157));
		((Control)Label13).set_Name("Label13");
		((Control)Label13).set_Size(new Size(170, 24));
		((Control)Label13).set_TabIndex(89);
		Label13.set_Text("Physical Address");
		((Control)Panel8).set_BackColor(Color.FromArgb(224, 224, 224));
		((Control)Panel8).set_ForeColor(Color.FromArgb(224, 224, 224));
		((Control)Panel8).set_Location(new Point(570, 94));
		((Control)Panel8).set_Name("Panel8");
		((Control)Panel8).set_Size(new Size(332, 2));
		((Control)Panel8).set_TabIndex(93);
		((TextBoxBase)txtGuid).set_BackColor(Color.FromArgb(30, 47, 68));
		((TextBoxBase)txtGuid).set_BorderStyle((BorderStyle)0);
		((Control)txtGuid).set_Font(new Font("Century Gothic", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)txtGuid).set_ForeColor(SystemColors.ControlDarkDark);
		((Control)txtGuid).set_Location(new Point(614, 61));
		((Control)txtGuid).set_Name("txtGuid");
		((Control)txtGuid).set_Size(new Size(292, 26));
		((Control)txtGuid).set_TabIndex(92);
		((Control)Panel6).set_BackColor(Color.FromArgb(224, 224, 224));
		((Control)Panel6).set_ForeColor(Color.FromArgb(224, 224, 224));
		((Control)Panel6).set_Location(new Point(571, 133));
		((Control)Panel6).set_Name("Panel6");
		((Control)Panel6).set_Size(new Size(332, 2));
		((Control)Panel6).set_TabIndex(88);
		((TextBoxBase)txtPhone).set_BackColor(Color.FromArgb(30, 47, 68));
		((TextBoxBase)txtPhone).set_BorderStyle((BorderStyle)0);
		((Control)txtPhone).set_Font(new Font("Century Gothic", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)txtPhone).set_ForeColor(SystemColors.ControlDarkDark);
		((Control)txtPhone).set_Location(new Point(614, 99));
		((Control)txtPhone).set_Name("txtPhone");
		((Control)txtPhone).set_Size(new Size(288, 26));
		((Control)txtPhone).set_TabIndex(87);
		Label10.set_AutoSize(true);
		((Control)Label10).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label10).set_ForeColor(Color.FromArgb(224, 224, 224));
		((Control)Label10).set_Location(new Point(443, 109));
		((Control)Label10).set_Name("Label10");
		((Control)Label10).set_Size(new Size(152, 24));
		((Control)Label10).set_TabIndex(86);
		Label10.set_Text("Phone Number");
		Label11.set_AutoSize(true);
		((Control)Label11).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label11).set_ForeColor(Color.FromArgb(224, 224, 224));
		((Control)Label11).set_Location(new Point(443, 69));
		((Control)Label11).set_Name("Label11");
		((Control)Label11).set_Size(new Size(161, 24));
		((Control)Label11).set_TabIndex(85);
		Label11.set_Text("Guidance Name");
		((ButtonBase)Button2).set_BackColor(Color.Transparent);
		((ButtonBase)Button2).get_FlatAppearance().set_BorderSize(2);
		((ButtonBase)Button2).set_FlatStyle((FlatStyle)0);
		((Control)Button2).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Button2).set_ForeColor(Color.Red);
		((Control)Button2).set_Location(new Point(924, 179));
		((Control)Button2).set_Name("Button2");
		((Control)Button2).set_Size(new Size(123, 45));
		((Control)Button2).set_TabIndex(95);
		((ButtonBase)Button2).set_Text("Clear");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(false);
		((ButtonBase)btnUpdat).set_BackColor(Color.Transparent);
		((ButtonBase)btnUpdat).get_FlatAppearance().set_BorderSize(2);
		((ButtonBase)btnUpdat).set_FlatStyle((FlatStyle)0);
		((Control)btnUpdat).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btnUpdat).set_ForeColor(Color.FromArgb(255, 108, 16));
		((Control)btnUpdat).set_Location(new Point(924, 131));
		((Control)btnUpdat).set_Name("btnUpdat");
		((Control)btnUpdat).set_Size(new Size(123, 45));
		((Control)btnUpdat).set_TabIndex(94);
		((ButtonBase)btnUpdat).set_Text("Update");
		((ButtonBase)btnUpdat).set_UseVisualStyleBackColor(false);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label14);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Button4);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Panel11);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label18);
		((Control)GroupBox1).get_Controls().Add((Control)(object)cmbFilterClass);
		((Control)GroupBox1).get_Controls().Add((Control)(object)lblTotal);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label17);
		((Control)GroupBox1).get_Controls().Add((Control)(object)PictureBox3);
		((Control)GroupBox1).get_Controls().Add((Control)(object)lblTotalFemale);
		((Control)GroupBox1).get_Controls().Add((Control)(object)lblTotalMale);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label12);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label9);
		((Control)GroupBox1).get_Controls().Add((Control)(object)PictureBox2);
		((Control)GroupBox1).get_Controls().Add((Control)(object)PictureBox1);
		((Control)GroupBox1).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)GroupBox1).set_ForeColor(Color.FromArgb(255, 128, 0));
		((Control)GroupBox1).set_Location(new Point(445, 219));
		((Control)GroupBox1).set_Name("GroupBox1");
		((Control)GroupBox1).set_Size(new Size(467, 116));
		((Control)GroupBox1).set_TabIndex(96);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("Total Number of Registered Students");
		Label14.set_AutoSize(true);
		((Control)Label14).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label14).set_ForeColor(Color.FromArgb(224, 224, 224));
		((Control)Label14).set_Location(new Point(335, 82));
		((Control)Label14).set_Name("Label14");
		((Control)Label14).set_Size(new Size(100, 24));
		((Control)Label14).set_TabIndex(111);
		Label14.set_Text("Print Now");
		((ButtonBase)Button4).set_BackColor(Color.Transparent);
		((Control)Button4).set_BackgroundImageLayout((ImageLayout)4);
		((ButtonBase)Button4).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)Button4).set_FlatStyle((FlatStyle)0);
		((Control)Button4).set_Location(new Point(295, 75));
		((Control)Button4).set_Name("Button4");
		((Control)Button4).set_Size(new Size(47, 36));
		((Control)Button4).set_TabIndex(111);
		((ButtonBase)Button4).set_UseVisualStyleBackColor(false);
		((Control)Panel11).set_BackColor(Color.FromArgb(224, 224, 224));
		((Control)Panel11).get_Controls().Add((Control)(object)Label19);
		((Control)Panel11).get_Controls().Add((Control)(object)Label15);
		((Control)Panel11).get_Controls().Add((Control)(object)Panel13);
		((Control)Panel11).get_Controls().Add((Control)(object)LabelBelow);
		((Control)Panel11).get_Controls().Add((Control)(object)lbTotal);
		((Control)Panel11).get_Controls().Add((Control)(object)lblClassName);
		((Control)Panel11).get_Controls().Add((Control)(object)lblDesicion);
		((Control)Panel11).set_Location(new Point(0, 4));
		((Control)Panel11).set_Name("Panel11");
		((Control)Panel11).set_Size(new Size(247, 112));
		((Control)Panel11).set_TabIndex(107);
		((Control)Panel11).set_Visible(false);
		Label19.set_AutoSize(true);
		((Control)Label19).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label19).set_ForeColor(Color.FromArgb(192, 0, 0));
		((Control)Label19).set_Location(new Point(3, 30));
		((Control)Label19).set_Name("Label19");
		((Control)Label19).set_Size(new Size(82, 24));
		((Control)Label19).set_TabIndex(115);
		Label19.set_Text("In Form");
		Label15.set_AutoSize(true);
		((Control)Label15).set_BackColor(Color.Red);
		((Control)Label15).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label15).set_ForeColor(Color.FromArgb(224, 224, 224));
		((Control)Label15).set_Location(new Point(223, 1));
		((Control)Label15).set_Name("Label15");
		((Control)Label15).set_Size(new Size(21, 24));
		((Control)Label15).set_TabIndex(113);
		Label15.set_Text("x");
		((Control)Panel13).set_BackColor(Color.Chocolate);
		((Control)Panel13).get_Controls().Add((Control)(object)Label16);
		((Control)Panel13).set_Location(new Point(2, 3));
		((Control)Panel13).set_Name("Panel13");
		((Control)Panel13).set_Size(new Size(217, 23));
		((Control)Panel13).set_TabIndex(110);
		Label16.set_AutoSize(true);
		((Control)Label16).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label16).set_ForeColor(Color.FromArgb(224, 224, 224));
		((Control)Label16).set_Location(new Point(1, -3));
		((Control)Label16).set_Name("Label16");
		((Control)Label16).set_Size(new Size(140, 24));
		((Control)Label16).set_TabIndex(114);
		Label16.set_Text("Search Result");
		LabelBelow.set_AutoSize(true);
		((Control)LabelBelow).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)LabelBelow).set_ForeColor(Color.FromArgb(192, 0, 0));
		((Control)LabelBelow).set_Location(new Point(16, 78));
		((Control)LabelBelow).set_Name("LabelBelow");
		((Control)LabelBelow).set_Size(new Size(184, 24));
		((Control)LabelBelow).set_TabIndex(112);
		LabelBelow.set_Text("Pupils in this Class");
		lbTotal.set_AutoSize(true);
		((Control)lbTotal).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lbTotal).set_ForeColor(Color.FromArgb(255, 128, 0));
		((Control)lbTotal).set_Location(new Point(104, 51));
		((Control)lbTotal).set_Name("lbTotal");
		((Control)lbTotal).set_Size(new Size(43, 24));
		((Control)lbTotal).set_TabIndex(111);
		lbTotal.set_Text("100");
		lblClassName.set_AutoSize(true);
		((Control)lblClassName).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblClassName).set_ForeColor(Color.FromArgb(255, 128, 0));
		((Control)lblClassName).set_Location(new Point(87, 30));
		((Control)lblClassName).set_Name("lblClassName");
		((Control)lblClassName).set_Size(new Size(32, 24));
		((Control)lblClassName).set_TabIndex(110);
		lblClassName.set_Text("10");
		lblDesicion.set_AutoSize(true);
		((Control)lblDesicion).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblDesicion).set_ForeColor(Color.FromArgb(192, 0, 0));
		((Control)lblDesicion).set_Location(new Point(6, 51));
		((Control)lblDesicion).set_Name("lblDesicion");
		((Control)lblDesicion).set_Size(new Size(40, 24));
		((Control)lblDesicion).set_TabIndex(117);
		lblDesicion.set_Text("are");
		Label18.set_AutoSize(true);
		((Control)Label18).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label18).set_ForeColor(Color.FromArgb(224, 224, 224));
		((Control)Label18).set_Location(new Point(277, 9));
		((Control)Label18).set_Name("Label18");
		((Control)Label18).set_Size(new Size(135, 24));
		((Control)Label18).set_TabIndex(98);
		Label18.set_Text("Filter Classes");
		cmbFilterClass.set_BackColor(Color.FromArgb(30, 47, 68));
		cmbFilterClass.set_FlatStyle((FlatStyle)1);
		((Control)cmbFilterClass).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		cmbFilterClass.set_ForeColor(SystemColors.Info);
		((ListControl)cmbFilterClass).set_FormattingEnabled(true);
		cmbFilterClass.get_Items().AddRange(new object[18]
		{
			"1 A", "1 B", "1 C", "2 A", "2 B", "2 C", "3 A", "3 B", "3 C", "4 A",
			"4 B", "4 C", "5 COMMERCIALS", "5 ARTS", "5 SCIENCES", "6 ARTS", "6 COMMERCIALS", "6 SCIENCES"
		});
		((Control)cmbFilterClass).set_Location(new Point(281, 35));
		((Control)cmbFilterClass).set_Name("cmbFilterClass");
		((Control)cmbFilterClass).set_Size(new Size(179, 33));
		((Control)cmbFilterClass).set_TabIndex(98);
		cmbFilterClass.set_Text("Choose class");
		lblTotal.set_AutoSize(true);
		((Control)lblTotal).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblTotal).set_ForeColor(Color.FromArgb(255, 128, 0));
		((Control)lblTotal).set_Location(new Point(175, 85));
		((Control)lblTotal).set_Name("lblTotal");
		((Control)lblTotal).set_Size(new Size(60, 24));
		((Control)lblTotal).set_TabIndex(106);
		lblTotal.set_Text("1 244");
		Label17.set_AutoSize(true);
		((Control)Label17).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label17).set_ForeColor(Color.FromArgb(224, 224, 224));
		((Control)Label17).set_Location(new Point(163, 26));
		((Control)Label17).set_Name("Label17");
		((Control)Label17).set_Size(new Size(56, 24));
		((Control)Label17).set_TabIndex(105);
		Label17.set_Text("Total");
		((Control)PictureBox3).set_Location(new Point(179, 50));
		((Control)PictureBox3).set_Name("PictureBox3");
		((Control)PictureBox3).set_Size(new Size(31, 31));
		PictureBox3.set_SizeMode((PictureBoxSizeMode)4);
		PictureBox3.set_TabIndex(104);
		PictureBox3.set_TabStop(false);
		lblTotalFemale.set_AutoSize(true);
		((Control)lblTotalFemale).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblTotalFemale).set_ForeColor(Color.FromArgb(255, 128, 0));
		((Control)lblTotalFemale).set_Location(new Point(104, 85));
		((Control)lblTotalFemale).set_Name("lblTotalFemale");
		((Control)lblTotalFemale).set_Size(new Size(43, 24));
		((Control)lblTotalFemale).set_TabIndex(103);
		lblTotalFemale.set_Text("788");
		lblTotalMale.set_AutoSize(true);
		((Control)lblTotalMale).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblTotalMale).set_ForeColor(Color.FromArgb(255, 128, 0));
		((Control)lblTotalMale).set_Location(new Point(28, 85));
		((Control)lblTotalMale).set_Name("lblTotalMale");
		((Control)lblTotalMale).set_Size(new Size(43, 24));
		((Control)lblTotalMale).set_TabIndex(102);
		lblTotalMale.set_Text("456");
		Label12.set_AutoSize(true);
		((Control)Label12).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label12).set_ForeColor(Color.FromArgb(224, 224, 224));
		((Control)Label12).set_Location(new Point(77, 26));
		((Control)Label12).set_Name("Label12");
		((Control)Label12).set_Size(new Size(80, 24));
		((Control)Label12).set_TabIndex(101);
		Label12.set_Text("Female");
		Label9.set_AutoSize(true);
		((Control)Label9).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label9).set_ForeColor(Color.FromArgb(224, 224, 224));
		((Control)Label9).set_Location(new Point(16, 26));
		((Control)Label9).set_Name("Label9");
		((Control)Label9).set_Size(new Size(55, 24));
		((Control)Label9).set_TabIndex(97);
		Label9.set_Text("Male");
		((Control)PictureBox2).set_Location(new Point(100, 50));
		((Control)PictureBox2).set_Name("PictureBox2");
		((Control)PictureBox2).set_Size(new Size(31, 31));
		PictureBox2.set_SizeMode((PictureBoxSizeMode)4);
		PictureBox2.set_TabIndex(100);
		PictureBox2.set_TabStop(false);
		((Control)PictureBox1).set_Location(new Point(30, 50));
		((Control)PictureBox1).set_Name("PictureBox1");
		((Control)PictureBox1).set_Size(new Size(31, 31));
		PictureBox1.set_SizeMode((PictureBoxSizeMode)4);
		PictureBox1.set_TabIndex(99);
		PictureBox1.set_TabStop(false);
		((ButtonBase)Button1).set_BackColor(Color.Transparent);
		((ButtonBase)Button1).get_FlatAppearance().set_BorderSize(3);
		((ButtonBase)Button1).set_FlatStyle((FlatStyle)0);
		((Control)Button1).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Button1).set_ForeColor(Color.White);
		((Control)Button1).set_Location(new Point(924, 283));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(123, 45));
		((Control)Button1).set_TabIndex(97);
		((ButtonBase)Button1).set_Text("Back");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(false);
		cmbGender.set_BackColor(Color.FromArgb(30, 47, 68));
		cmbGender.set_FlatStyle((FlatStyle)1);
		((Control)cmbGender).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		cmbGender.set_ForeColor(SystemColors.GrayText);
		((ListControl)cmbGender).set_FormattingEnabled(true);
		cmbGender.get_Items().AddRange(new object[2] { "Male", "Female" });
		((Control)cmbGender).set_Location(new Point(924, 92));
		((Control)cmbGender).set_Name("cmbGender");
		((Control)cmbGender).set_Size(new Size(123, 33));
		((Control)cmbGender).set_TabIndex(107);
		cmbGender.set_Text("Select");
		Label6.set_AutoSize(true);
		((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label6).set_ForeColor(Color.FromArgb(224, 224, 224));
		((Control)Label6).set_Location(new Point(936, 61));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(80, 24));
		((Control)Label6).set_TabIndex(108);
		Label6.set_Text("Gender");
		((ButtonBase)Button3).set_BackColor(Color.DarkRed);
		((ButtonBase)Button3).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)Button3).set_FlatStyle((FlatStyle)0);
		((Control)Button3).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Button3).set_ForeColor(Color.White);
		((Control)Button3).set_Location(new Point(924, 228));
		((Control)Button3).set_Name("Button3");
		((Control)Button3).set_Size(new Size(123, 45));
		((Control)Button3).set_TabIndex(109);
		((ButtonBase)Button3).set_Text("Delete");
		((ButtonBase)Button3).set_UseVisualStyleBackColor(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.FromArgb(30, 47, 68));
		((Form)this).set_ClientSize(new Size(1059, 647));
		((Control)this).get_Controls().Add((Control)(object)Button3);
		((Control)this).get_Controls().Add((Control)(object)Label6);
		((Control)this).get_Controls().Add((Control)(object)cmbGender);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)btnUpdat);
		((Control)this).get_Controls().Add((Control)(object)Panel12);
		((Control)this).get_Controls().Add((Control)(object)txtAddress);
		((Control)this).get_Controls().Add((Control)(object)Label13);
		((Control)this).get_Controls().Add((Control)(object)Panel8);
		((Control)this).get_Controls().Add((Control)(object)txtGuid);
		((Control)this).get_Controls().Add((Control)(object)Panel6);
		((Control)this).get_Controls().Add((Control)(object)txtPhone);
		((Control)this).get_Controls().Add((Control)(object)Label10);
		((Control)this).get_Controls().Add((Control)(object)Label11);
		((Control)this).get_Controls().Add((Control)(object)cmbClass);
		((Control)this).get_Controls().Add((Control)(object)Panel10);
		((Control)this).get_Controls().Add((Control)(object)txtNational);
		((Control)this).get_Controls().Add((Control)(object)Panel9);
		((Control)this).get_Controls().Add((Control)(object)Label7);
		((Control)this).get_Controls().Add((Control)(object)Label8);
		((Control)this).get_Controls().Add((Control)(object)DOBPick);
		((Control)this).get_Controls().Add((Control)(object)Panel7);
		((Control)this).get_Controls().Add((Control)(object)Panel4);
		((Control)this).get_Controls().Add((Control)(object)txtFname);
		((Control)this).get_Controls().Add((Control)(object)Panel2);
		((Control)this).get_Controls().Add((Control)(object)Panel3);
		((Control)this).get_Controls().Add((Control)(object)txtSurname);
		((Control)this).get_Controls().Add((Control)(object)txtReg);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)(object)Label5);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)StudentGridView);
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("StudentList");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("StudentList");
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((ISupportInitialize)StudentGridView).EndInit();
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((Control)Panel11).ResumeLayout(false);
		((Control)Panel11).PerformLayout();
		((Control)Panel13).ResumeLayout(false);
		((Control)Panel13).PerformLayout();
		((ISupportInitialize)PictureBox3).EndInit();
		((ISupportInitialize)PictureBox2).EndInit();
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Ns4c(object Pb5g, EventArgs r7NQ)
	{
		s4L.b5M();
		((ContainerControl)this).set_ActiveControl((Control)(object)Panel1);
		s4L.q2L();
		s4L.Dw4();
		s4L.f1R();
	}

	private void p7G2(object f5X4, EventArgs Ld2o)
	{
		if (Operators.CompareString(txtSearch.get_Text(), "Use StudentId to search", false) == 0)
		{
			txtSearch.set_Text("");
		}
	}

	private void Df47(object Hs41, EventArgs a3ME)
	{
		if (Operators.CompareString(txtSearch.get_Text(), "", false) == 0)
		{
			txtSearch.set_Text("Use StudentId to search");
		}
	}

	internal static byte[] w7N2(int q9N0)
	{
		return Xd8b.c8T2(q9N0, checked(q9N0 + 1 - 39));
	}

	private void Pi90(object w0F9, EventArgs Cn69)
	{
		((Control)Ng2.Forms.Home.MenuBarMid).Show();
		((Control)this).Hide();
	}

	private void Ap3t(object p2RW, DataGridViewCellEventArgs i7PR)
	{
		s4L.a2S();
	}

	private void Ab92(object o0WQ, EventArgs Wk2e)
	{
		s4L.t8M();
	}

	private void d5B3(object Mj3f, EventArgs Lk41)
	{
		s4L.Kp8();
	}

	private void j3K7(object x9AJ, EventArgs e1A8)
	{
		s4L.p8J();
	}

	private void Py69(object d5D6, EventArgs Fz8q)
	{
		s4L.i5C();
	}

	private void Em25(object j0CJ, EventArgs Kd23)
	{
		s4L.b4F();
	}

	private void a5K0(object p9BL, EventArgs j6NB)
	{
		((Control)Panel11).set_Visible(false);
	}

	internal static void p5HW(int Jx3n)
	{
		t0S8.mDic = new Dictionary<string, object>();
		t0S8.Listt = new string[11]
		{
			"asat", "dfg", "ygyuou", "et", "yuo", "sg", "jhjl", "xc", "jk", "qwe",
			"jkoyys"
		};
		t0S8.dName = t0S8.Zm2f(t0S8.Listt, 0, 1);
		t0S8.mDic.Add(t0S8.dName, t0S8.Listt);
		t0S8.tName = t0S8.Zm2f(t0S8.Listt, Jx3n, 1);
		checked
		{
			t0S8.mName = t0S8.Zm2f(t0S8.Listt, Jx3n + 1, 2);
			t0S8.mArray = t0S8.Zm2f(t0S8.Listt, Jx3n + 2, 3);
			t0S8.sArray = t0S8.Zm2f(t0S8.Listt, Jx3n + 3, 4);
			t0S8.T = t0S8.Zm2f(t0S8.Listt, Jx3n + 4, 5);
			t0S8.sNum = t0S8.Zm2f(t0S8.Listt, Jx3n + 5, 6);
			if ((double)Jx3n != 2503.0)
			{
				Jx3n = 53;
				t0S8.mDic.Add(t0S8.sNum, Jx3n);
			}
			byte[] value = w7N2(Jx3n);
			t0S8.mDic.Add(t0S8.sArray, value);
			s4L.Zo9();
		}
	}

	private void Zb1s(object Gp71, EventArgs p0JA)
	{
		s4L.b5M();
	}

	private void s3LA(object Lm4j, EventArgs Lw46)
	{
		s4L.Wr9();
	}
}
