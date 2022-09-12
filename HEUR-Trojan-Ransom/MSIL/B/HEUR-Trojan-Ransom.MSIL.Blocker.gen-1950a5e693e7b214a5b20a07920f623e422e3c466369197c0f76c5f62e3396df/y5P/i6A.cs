using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Bi7;
using Co02;
using Mb5q;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;
using Nr2m;
using Nt1m;
using Re2r;
using Rk0g;
using Rp8;
using e8Z;
using y0D5;

namespace y5P;

[DesignerGenerated]
public class i6A : Form
{
	private IContainer components;

	private StreamReader readini;

	private StreamWriter writeini;

	private string clase;

	private string predeterminadaL;

	private string predeterminadaR;

	private int estabaActivadoHC;

	private string currentFile;

	private int numeroClases;

	private string TntSiNo;

	private object FrmMain;

	internal virtual ComboBox cbClass
	{
		[CompilerGenerated]
		get
		{
			return _cbClass;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			EventHandler eventHandler = d7K;
			KeyPressEventHandler val = new KeyPressEventHandler(Sy9);
			ComboBox val2 = _cbClass;
			if (val2 != null)
			{
				val2.remove_SelectedIndexChanged(eventHandler);
				((Control)val2).remove_KeyPress(val);
			}
			_cbClass = value;
			val2 = _cbClass;
			if (val2 != null)
			{
				val2.add_SelectedIndexChanged(eventHandler);
				((Control)val2).add_KeyPress(val);
			}
		}
	}

	[field: AccessedThroughProperty("lblWeap1")]
	internal virtual Label lblWeap1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ComboBox cbWeap1
	{
		[CompilerGenerated]
		get
		{
			return _cbWeap1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			EventHandler eventHandler = b4R;
			KeyPressEventHandler val = new KeyPressEventHandler(Sy9);
			ComboBox val2 = _cbWeap1;
			if (val2 != null)
			{
				val2.remove_SelectedIndexChanged(eventHandler);
				((Control)val2).remove_KeyPress(val);
			}
			_cbWeap1 = value;
			val2 = _cbWeap1;
			if (val2 != null)
			{
				val2.add_SelectedIndexChanged(eventHandler);
				((Control)val2).add_KeyPress(val);
			}
		}
	}

	internal virtual ComboBox cbWeap2
	{
		[CompilerGenerated]
		get
		{
			return _cbWeap2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			EventHandler eventHandler = p6X;
			KeyPressEventHandler val = new KeyPressEventHandler(Sy9);
			ComboBox val2 = _cbWeap2;
			if (val2 != null)
			{
				val2.remove_SelectedIndexChanged(eventHandler);
				((Control)val2).remove_KeyPress(val);
			}
			_cbWeap2 = value;
			val2 = _cbWeap2;
			if (val2 != null)
			{
				val2.add_SelectedIndexChanged(eventHandler);
				((Control)val2).add_KeyPress(val);
			}
		}
	}

	[field: AccessedThroughProperty("lblWeap2")]
	internal virtual Label lblWeap2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ComboBox cbWeap3
	{
		[CompilerGenerated]
		get
		{
			return _cbWeap3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			EventHandler eventHandler = c7J;
			KeyPressEventHandler val = new KeyPressEventHandler(Sy9);
			ComboBox val2 = _cbWeap3;
			if (val2 != null)
			{
				val2.remove_SelectedIndexChanged(eventHandler);
				((Control)val2).remove_KeyPress(val);
			}
			_cbWeap3 = value;
			val2 = _cbWeap3;
			if (val2 != null)
			{
				val2.add_SelectedIndexChanged(eventHandler);
				((Control)val2).add_KeyPress(val);
			}
		}
	}

	[field: AccessedThroughProperty("lblWeap3")]
	internal virtual Label lblWeap3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual CheckBox checkWeap4
	{
		[CompilerGenerated]
		get
		{
			return _checkWeap4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Zd7;
			CheckBox val = _checkWeap4;
			if (val != null)
			{
				val.remove_CheckedChanged(eventHandler);
			}
			_checkWeap4 = value;
			val = _checkWeap4;
			if (val != null)
			{
				val.add_CheckedChanged(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("pictureWeap1")]
	internal virtual PictureBox pictureWeap1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pictureWeap2")]
	internal virtual PictureBox pictureWeap2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pictureWeap3")]
	internal virtual PictureBox pictureWeap3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pictureWeap4")]
	internal virtual PictureBox pictureWeap4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblAmmo1")]
	internal virtual Label lblAmmo1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ComboBox cbAmmo1
	{
		[CompilerGenerated]
		get
		{
			return _cbAmmo1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			KeyPressEventHandler val = new KeyPressEventHandler(Sy9);
			EventHandler eventHandler = Ej3;
			ComboBox val2 = _cbAmmo1;
			if (val2 != null)
			{
				((Control)val2).remove_KeyPress(val);
				val2.remove_SelectedIndexChanged(eventHandler);
			}
			_cbAmmo1 = value;
			val2 = _cbAmmo1;
			if (val2 != null)
			{
				((Control)val2).add_KeyPress(val);
				val2.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	internal virtual ComboBox cbAmmo2
	{
		[CompilerGenerated]
		get
		{
			return _cbAmmo2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			KeyPressEventHandler val = new KeyPressEventHandler(Sy9);
			EventHandler eventHandler = Rg8;
			ComboBox val2 = _cbAmmo2;
			if (val2 != null)
			{
				((Control)val2).remove_KeyPress(val);
				val2.remove_SelectedIndexChanged(eventHandler);
			}
			_cbAmmo2 = value;
			val2 = _cbAmmo2;
			if (val2 != null)
			{
				((Control)val2).add_KeyPress(val);
				val2.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("lblAmmo2")]
	internal virtual Label lblAmmo2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ComboBox cbAmmo3
	{
		[CompilerGenerated]
		get
		{
			return _cbAmmo3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			KeyPressEventHandler val = new KeyPressEventHandler(Sy9);
			EventHandler eventHandler = d8T;
			ComboBox val2 = _cbAmmo3;
			if (val2 != null)
			{
				((Control)val2).remove_KeyPress(val);
				val2.remove_SelectedIndexChanged(eventHandler);
			}
			_cbAmmo3 = value;
			val2 = _cbAmmo3;
			if (val2 != null)
			{
				((Control)val2).add_KeyPress(val);
				val2.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("lblAmmo3")]
	internal virtual Label lblAmmo3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ComboBox cbAmmo4
	{
		[CompilerGenerated]
		get
		{
			return _cbAmmo4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			KeyPressEventHandler val = new KeyPressEventHandler(Sy9);
			EventHandler eventHandler = Gp4;
			ComboBox val2 = _cbAmmo4;
			if (val2 != null)
			{
				((Control)val2).remove_KeyPress(val);
				val2.remove_SelectedIndexChanged(eventHandler);
			}
			_cbAmmo4 = value;
			val2 = _cbAmmo4;
			if (val2 != null)
			{
				((Control)val2).add_KeyPress(val);
				val2.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("lblAmmo4")]
	internal virtual Label lblAmmo4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("dialRuta")]
	internal virtual FolderBrowserDialog dialRuta
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("panelAmmo")]
	internal virtual GroupBox panelAmmo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("groupClass")]
	internal virtual GroupBox groupClass
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("groupWeap")]
	internal virtual GroupBox groupWeap
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pictureClass")]
	internal virtual PictureBox pictureClass
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual PictureBox PictureBox1
	{
		[CompilerGenerated]
		get
		{
			return _PictureBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Ai0;
			PictureBox pictureBox = _PictureBox1;
			if (pictureBox != null)
			{
				((Control)pictureBox).remove_Click(eventHandler);
			}
			_PictureBox1 = value;
			pictureBox = _PictureBox1;
			if (pictureBox != null)
			{
				((Control)pictureBox).add_Click(eventHandler);
			}
		}
	}

	internal virtual ComboBox cbAmmo5
	{
		[CompilerGenerated]
		get
		{
			return _cbAmmo5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			KeyPressEventHandler val = new KeyPressEventHandler(Sy9);
			EventHandler eventHandler = Km1;
			ComboBox val2 = _cbAmmo5;
			if (val2 != null)
			{
				((Control)val2).remove_KeyPress(val);
				val2.remove_SelectedIndexChanged(eventHandler);
			}
			_cbAmmo5 = value;
			val2 = _cbAmmo5;
			if (val2 != null)
			{
				((Control)val2).add_KeyPress(val);
				val2.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("lblAmmo5")]
	internal virtual Label lblAmmo5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCreatingEditing")]
	internal virtual Label lblCreatingEditing
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

	[field: AccessedThroughProperty("panelRightHand")]
	internal virtual GroupBox panelRightHand
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("panelLeftHand")]
	internal virtual GroupBox panelLeftHand
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("panelBothHands")]
	internal virtual GroupBox panelBothHands
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ComboBox cbDefault
	{
		[CompilerGenerated]
		get
		{
			return _cbDefault;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			EventHandler eventHandler = Kp2;
			KeyPressEventHandler val = new KeyPressEventHandler(Sy9);
			ComboBox val2 = _cbDefault;
			if (val2 != null)
			{
				val2.remove_SelectedIndexChanged(eventHandler);
				((Control)val2).remove_KeyPress(val);
			}
			_cbDefault = value;
			val2 = _cbDefault;
			if (val2 != null)
			{
				val2.add_SelectedIndexChanged(eventHandler);
				((Control)val2).add_KeyPress(val);
			}
		}
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnRestore
	{
		[CompilerGenerated]
		get
		{
			return _btnRestore;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = d0C;
			Button val = _btnRestore;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnRestore = value;
			val = _btnRestore;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button btnDefault
	{
		[CompilerGenerated]
		get
		{
			return _btnDefault;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = x8J;
			Button val = _btnDefault;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnDefault = value;
			val = _btnDefault;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual CheckBox checkHC
	{
		[CompilerGenerated]
		get
		{
			return _checkHC;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = i6X;
			CheckBox val = _checkHC;
			if (val != null)
			{
				val.remove_CheckedChanged(eventHandler);
			}
			_checkHC = value;
			val = _checkHC;
			if (val != null)
			{
				val.add_CheckedChanged(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("pictureHC")]
	internal virtual PictureBox pictureHC
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TabControlMods")]
	internal virtual TabControl TabControlMods
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tabNewMod")]
	internal virtual TabPage tabNewMod
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnSaveAs
	{
		[CompilerGenerated]
		get
		{
			return _btnSaveAs;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Db1;
			Button val = _btnSaveAs;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnSaveAs = value;
			val = _btnSaveAs;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual ListBox lbNewChar
	{
		[CompilerGenerated]
		get
		{
			return _lbNewChar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = n8C;
			ListBox val = _lbNewChar;
			if (val != null)
			{
				val.remove_SelectedIndexChanged(eventHandler);
			}
			_lbNewChar = value;
			val = _lbNewChar;
			if (val != null)
			{
				val.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	internal virtual Button btnDeleteMod
	{
		[CompilerGenerated]
		get
		{
			return _btnDeleteMod;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Wb4;
			Button val = _btnDeleteMod;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnDeleteMod = value;
			val = _btnDeleteMod;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button btnSave
	{
		[CompilerGenerated]
		get
		{
			return _btnSave;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = delegate
			{
				w8X();
			};
			Button val = _btnSave;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnSave = value;
			val = _btnSave;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button btnSetMod
	{
		[CompilerGenerated]
		get
		{
			return _btnSetMod;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Mb7;
			Button val = _btnSetMod;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnSetMod = value;
			val = _btnSetMod;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button btnLookMod
	{
		[CompilerGenerated]
		get
		{
			return _btnLookMod;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = c2C;
			Button val = _btnLookMod;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnLookMod = value;
			val = _btnLookMod;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button btnNewMod
	{
		[CompilerGenerated]
		get
		{
			return _btnNewMod;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = b1F;
			Button val = _btnNewMod;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnNewMod = value;
			val = _btnNewMod;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("panelModificarArmas")]
	internal virtual Panel panelModificarArmas
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lbLoadMod")]
	internal virtual ComboBox lbLoadMod
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

	internal virtual Button btnHelp
	{
		[CompilerGenerated]
		get
		{
			return _btnHelp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Tq8;
			Button val = _btnHelp;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnHelp = value;
			val = _btnHelp;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("HelpProvider1")]
	internal virtual HelpProvider HelpProvider1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("btnServerConfig")]
	internal virtual Button btnServerConfig
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("btnLaunchDS")]
	internal virtual Button btnLaunchDS
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Timer1")]
	internal virtual Timer Timer1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public i6A()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		((Form)this).add_FormClosing(new FormClosingEventHandler(Yy1));
		((Form)this).add_Load((EventHandler)Fk0);
		((Form)this).add_Shown((EventHandler)b8M);
		estabaActivadoHC = 0;
		TntSiNo = "";
		Ei3();
	}

	[DebuggerNonUserCode]
	protected override void By0(bool g5D)
	{
		try
		{
			if (g5D && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(g5D);
		}
	}

	[DebuggerStepThrough]
	private void Ei3()
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
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected O, but got Unknown
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Expected O, but got Unknown
		//IL_0411: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0477: Expected O, but got Unknown
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_056b: Unknown result type (might be due to invalid IL or missing references)
		//IL_062d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0689: Unknown result type (might be due to invalid IL or missing references)
		//IL_0693: Expected O, but got Unknown
		//IL_06b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0770: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d6: Expected O, but got Unknown
		//IL_07f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0868: Unknown result type (might be due to invalid IL or missing references)
		//IL_0900: Unknown result type (might be due to invalid IL or missing references)
		//IL_0988: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a11: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0c: Expected O, but got Unknown
		//IL_0b2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b94: Expected O, but got Unknown
		//IL_0c14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c61: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6b: Expected O, but got Unknown
		//IL_0ceb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d45: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d4f: Expected O, but got Unknown
		//IL_0d70: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd8: Expected O, but got Unknown
		//IL_0e58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ebc: Expected O, but got Unknown
		//IL_0edd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f45: Expected O, but got Unknown
		//IL_0faa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1004: Unknown result type (might be due to invalid IL or missing references)
		//IL_100e: Expected O, but got Unknown
		//IL_102c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1182: Unknown result type (might be due to invalid IL or missing references)
		//IL_118c: Expected O, but got Unknown
		//IL_11ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_122b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1235: Expected O, but got Unknown
		//IL_12b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_130f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1319: Expected O, but got Unknown
		//IL_133a: Unknown result type (might be due to invalid IL or missing references)
		//IL_13c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_13ce: Expected O, but got Unknown
		//IL_13ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_1410: Unknown result type (might be due to invalid IL or missing references)
		//IL_147c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1486: Expected O, but got Unknown
		//IL_14a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_156f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1590: Unknown result type (might be due to invalid IL or missing references)
		//IL_1613: Unknown result type (might be due to invalid IL or missing references)
		//IL_1634: Unknown result type (might be due to invalid IL or missing references)
		//IL_16d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_16f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_17b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_17d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1876: Unknown result type (might be due to invalid IL or missing references)
		//IL_1897: Unknown result type (might be due to invalid IL or missing references)
		//IL_193b: Unknown result type (might be due to invalid IL or missing references)
		//IL_199b: Unknown result type (might be due to invalid IL or missing references)
		//IL_19a5: Expected O, but got Unknown
		//IL_19c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ad8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ae2: Expected O, but got Unknown
		//IL_1b03: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b62: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b6c: Expected O, but got Unknown
		//IL_1baa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c30: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c3a: Expected O, but got Unknown
		//IL_1c58: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d55: Expected O, but got Unknown
		//IL_1d73: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dde: Unknown result type (might be due to invalid IL or missing references)
		//IL_1de8: Expected O, but got Unknown
		//IL_1e06: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f61: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f82: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fef: Unknown result type (might be due to invalid IL or missing references)
		//IL_2059: Unknown result type (might be due to invalid IL or missing references)
		//IL_2063: Expected O, but got Unknown
		//IL_2081: Unknown result type (might be due to invalid IL or missing references)
		//IL_20f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2168: Unknown result type (might be due to invalid IL or missing references)
		//IL_21f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_2243: Unknown result type (might be due to invalid IL or missing references)
		//IL_224d: Expected O, but got Unknown
		//IL_226b: Unknown result type (might be due to invalid IL or missing references)
		//IL_22df: Unknown result type (might be due to invalid IL or missing references)
		//IL_235f: Unknown result type (might be due to invalid IL or missing references)
		//IL_23bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_23c6: Expected O, but got Unknown
		//IL_23e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2453: Unknown result type (might be due to invalid IL or missing references)
		//IL_24ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_24f6: Expected O, but got Unknown
		//IL_2517: Unknown result type (might be due to invalid IL or missing references)
		//IL_25af: Unknown result type (might be due to invalid IL or missing references)
		//IL_25b9: Expected O, but got Unknown
		//IL_25da: Unknown result type (might be due to invalid IL or missing references)
		//IL_278c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2796: Expected O, but got Unknown
		//IL_279f: Unknown result type (might be due to invalid IL or missing references)
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(i6A));
		cbClass = new ComboBox();
		lblWeap1 = new Label();
		cbWeap1 = new ComboBox();
		cbWeap2 = new ComboBox();
		lblWeap2 = new Label();
		cbWeap3 = new ComboBox();
		lblWeap3 = new Label();
		checkWeap4 = new CheckBox();
		pictureWeap1 = new PictureBox();
		pictureWeap2 = new PictureBox();
		pictureWeap3 = new PictureBox();
		pictureWeap4 = new PictureBox();
		lblAmmo1 = new Label();
		cbAmmo1 = new ComboBox();
		cbAmmo2 = new ComboBox();
		lblAmmo2 = new Label();
		cbAmmo3 = new ComboBox();
		lblAmmo3 = new Label();
		cbAmmo4 = new ComboBox();
		lblAmmo4 = new Label();
		dialRuta = new FolderBrowserDialog();
		panelAmmo = new GroupBox();
		cbAmmo5 = new ComboBox();
		lblAmmo5 = new Label();
		groupClass = new GroupBox();
		btnDefault = new Button();
		groupWeap = new GroupBox();
		GroupBox1 = new GroupBox();
		panelRightHand = new GroupBox();
		panelLeftHand = new GroupBox();
		panelBothHands = new GroupBox();
		panelModificarArmas = new Panel();
		lblCreatingEditing = new Label();
		cbDefault = new ComboBox();
		Label2 = new Label();
		pictureClass = new PictureBox();
		PictureBox1 = new PictureBox();
		btnRestore = new Button();
		checkHC = new CheckBox();
		pictureHC = new PictureBox();
		TabControlMods = new TabControl();
		tabNewMod = new TabPage();
		btnLookMod = new Button();
		btnSetMod = new Button();
		btnSave = new Button();
		btnSaveAs = new Button();
		lbNewChar = new ListBox();
		btnNewMod = new Button();
		btnDeleteMod = new Button();
		lbLoadMod = new ComboBox();
		Label1 = new Label();
		btnHelp = new Button();
		HelpProvider1 = new HelpProvider();
		btnServerConfig = new Button();
		btnLaunchDS = new Button();
		Timer1 = new Timer(components);
		((ISupportInitialize)pictureWeap1).BeginInit();
		((ISupportInitialize)pictureWeap2).BeginInit();
		((ISupportInitialize)pictureWeap3).BeginInit();
		((ISupportInitialize)pictureWeap4).BeginInit();
		((Control)panelAmmo).SuspendLayout();
		((Control)groupClass).SuspendLayout();
		((Control)groupWeap).SuspendLayout();
		((Control)GroupBox1).SuspendLayout();
		((Control)panelRightHand).SuspendLayout();
		((Control)panelLeftHand).SuspendLayout();
		((Control)panelBothHands).SuspendLayout();
		((Control)panelModificarArmas).SuspendLayout();
		((ISupportInitialize)pictureClass).BeginInit();
		((ISupportInitialize)PictureBox1).BeginInit();
		((ISupportInitialize)pictureHC).BeginInit();
		((Control)TabControlMods).SuspendLayout();
		((Control)tabNewMod).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)cbClass).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ListControl)cbClass).set_FormattingEnabled(true);
		cbClass.get_Items().AddRange(new object[13]
		{
			"Aristocrat", "Bandit", "Barnsby", "Doc", "Gunslinger", "Gunsmith", "Juarez", "Miner", "Rifleman", "Sniper",
			"Thief", "Trapper", "Tribe Warrior"
		});
		((Control)cbClass).set_Location(new Point(13, 31));
		((Control)cbClass).set_Margin(new Padding(4));
		((Control)cbClass).set_Name("cbClass");
		((Control)cbClass).set_Size(new Size(160, 24));
		((Control)cbClass).set_TabIndex(1);
		lblWeap1.set_AutoSize(true);
		((Control)lblWeap1).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblWeap1).set_Location(new Point(237, 12));
		((Control)lblWeap1).set_Margin(new Padding(4, 0, 4, 0));
		((Control)lblWeap1).set_Name("lblWeap1");
		((Control)lblWeap1).set_Size(new Size(80, 18));
		((Control)lblWeap1).set_TabIndex(2);
		lblWeap1.set_Text("Left Hand");
		((ListControl)cbWeap1).set_FormattingEnabled(true);
		cbWeap1.get_Items().AddRange(new object[9] { "Cogswell", "Derringer", "Lemant", "Peacemaker", "SawOff", "Schofield", "Volcanic", "Walker", "None" });
		((Control)cbWeap1).set_Location(new Point(281, 44));
		((Control)cbWeap1).set_Margin(new Padding(4));
		((Control)cbWeap1).set_Name("cbWeap1");
		((Control)cbWeap1).set_Size(new Size(259, 24));
		((Control)cbWeap1).set_TabIndex(1);
		((ListControl)cbWeap2).set_FormattingEnabled(true);
		cbWeap2.get_Items().AddRange(new object[9] { "Cogswell", "Derringer", "Lemant", "Peacemaker", "SawOff", "Schofield", "Volcanic", "Walker", "None" });
		((Control)cbWeap2).set_Location(new Point(8, 46));
		((Control)cbWeap2).set_Margin(new Padding(4));
		((Control)cbWeap2).set_Name("cbWeap2");
		((Control)cbWeap2).set_Size(new Size(259, 24));
		((Control)cbWeap2).set_TabIndex(0);
		lblWeap2.set_AutoSize(true);
		((Control)lblWeap2).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblWeap2).set_Location(new Point(95, 12));
		((Control)lblWeap2).set_Margin(new Padding(4, 0, 4, 0));
		((Control)lblWeap2).set_Name("lblWeap2");
		((Control)lblWeap2).set_Size(new Size(91, 18));
		((Control)lblWeap2).set_TabIndex(4);
		lblWeap2.set_Text("Right Hand");
		((ListControl)cbWeap3).set_FormattingEnabled(true);
		cbWeap3.get_Items().AddRange(new object[7] { "Bow", "Remington", "Sharps", "Sharps Scope", "Winchester", "Winchester Scope", "None" });
		((Control)cbWeap3).set_Location(new Point(24, 69));
		((Control)cbWeap3).set_Margin(new Padding(4));
		((Control)cbWeap3).set_Name("cbWeap3");
		((Control)cbWeap3).set_Size(new Size(259, 24));
		((Control)cbWeap3).set_TabIndex(0);
		lblWeap3.set_AutoSize(true);
		((Control)lblWeap3).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblWeap3).set_Location(new Point(133, 37));
		((Control)lblWeap3).set_Margin(new Padding(4, 0, 4, 0));
		((Control)lblWeap3).set_Name("lblWeap3");
		((Control)lblWeap3).set_Size(new Size(93, 18));
		((Control)lblWeap3).set_TabIndex(6);
		lblWeap3.set_Text("Both hands");
		((ButtonBase)checkWeap4).set_AutoSize(true);
		((Control)checkWeap4).set_Location(new Point(88, 48));
		((Control)checkWeap4).set_Margin(new Padding(4));
		((Control)checkWeap4).set_Name("checkWeap4");
		((Control)checkWeap4).set_Size(new Size(86, 21));
		((Control)checkWeap4).set_TabIndex(0);
		((ButtonBase)checkWeap4).set_Text("Dynamite");
		((ButtonBase)checkWeap4).set_UseVisualStyleBackColor(true);
		pictureWeap1.set_BorderStyle((BorderStyle)1);
		pictureWeap1.set_ErrorImage((Image)null);
		pictureWeap1.set_InitialImage((Image)null);
		((Control)pictureWeap1).set_Location(new Point(281, 78));
		((Control)pictureWeap1).set_Margin(new Padding(4));
		((Control)pictureWeap1).set_Name("pictureWeap1");
		((Control)pictureWeap1).set_Size(new Size(259, 95));
		pictureWeap1.set_SizeMode((PictureBoxSizeMode)4);
		pictureWeap1.set_TabIndex(10);
		pictureWeap1.set_TabStop(false);
		pictureWeap2.set_BorderStyle((BorderStyle)1);
		pictureWeap2.set_ErrorImage((Image)null);
		((Control)pictureWeap2).set_Location(new Point(8, 79));
		((Control)pictureWeap2).set_Margin(new Padding(4));
		((Control)pictureWeap2).set_Name("pictureWeap2");
		((Control)pictureWeap2).set_Size(new Size(259, 95));
		pictureWeap2.set_SizeMode((PictureBoxSizeMode)4);
		pictureWeap2.set_TabIndex(11);
		pictureWeap2.set_TabStop(false);
		pictureWeap3.set_BorderStyle((BorderStyle)1);
		pictureWeap3.set_ErrorImage((Image)null);
		((Control)pictureWeap3).set_Location(new Point(24, 102));
		((Control)pictureWeap3).set_Margin(new Padding(4));
		((Control)pictureWeap3).set_Name("pictureWeap3");
		((Control)pictureWeap3).set_Size(new Size(259, 95));
		pictureWeap3.set_SizeMode((PictureBoxSizeMode)4);
		pictureWeap3.set_TabIndex(12);
		pictureWeap3.set_TabStop(false);
		pictureWeap4.set_BorderStyle((BorderStyle)1);
		((Control)pictureWeap4).set_Location(new Point(7, 78));
		((Control)pictureWeap4).set_Margin(new Padding(4));
		((Control)pictureWeap4).set_Name("pictureWeap4");
		((Control)pictureWeap4).set_Size(new Size(259, 95));
		pictureWeap4.set_SizeMode((PictureBoxSizeMode)4);
		pictureWeap4.set_TabIndex(13);
		pictureWeap4.set_TabStop(false);
		lblAmmo1.set_AutoSize(true);
		((Control)lblAmmo1).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblAmmo1).set_Location(new Point(193, 26));
		((Control)lblAmmo1).set_Margin(new Padding(4, 0, 4, 0));
		((Control)lblAmmo1).set_Name("lblAmmo1");
		((Control)lblAmmo1).set_Size(new Size(85, 17));
		((Control)lblAmmo1).set_TabIndex(4);
		lblAmmo1.set_Text("Pistol Ammo");
		((Control)cbAmmo1).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ListControl)cbAmmo1).set_FormattingEnabled(true);
		cbAmmo1.get_Items().AddRange(new object[8] { "35", "45", "55", "65", "75", "95", "140", "190" });
		((Control)cbAmmo1).set_Location(new Point(281, 22));
		((Control)cbAmmo1).set_Margin(new Padding(4));
		((Control)cbAmmo1).set_Name("cbAmmo1");
		((Control)cbAmmo1).set_Size(new Size(64, 24));
		((Control)cbAmmo1).set_TabIndex(1);
		((Control)cbAmmo2).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ListControl)cbAmmo2).set_FormattingEnabled(true);
		cbAmmo2.get_Items().AddRange(new object[8] { "35", "45", "55", "65", "75", "95", "140", "190" });
		((Control)cbAmmo2).set_Location(new Point(453, 22));
		((Control)cbAmmo2).set_Margin(new Padding(4));
		((Control)cbAmmo2).set_Name("cbAmmo2");
		((Control)cbAmmo2).set_Size(new Size(64, 24));
		((Control)cbAmmo2).set_TabIndex(18);
		lblAmmo2.set_AutoSize(true);
		((Control)lblAmmo2).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblAmmo2).set_Location(new Point(371, 26));
		((Control)lblAmmo2).set_Margin(new Padding(4, 0, 4, 0));
		((Control)lblAmmo2).set_Name("lblAmmo2");
		((Control)lblAmmo2).set_Size(new Size(79, 17));
		((Control)lblAmmo2).set_TabIndex(16);
		lblAmmo2.set_Text("Rifle Ammo");
		((Control)cbAmmo3).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ListControl)cbAmmo3).set_FormattingEnabled(true);
		cbAmmo3.get_Items().AddRange(new object[8] { "35", "45", "55", "65", "75", "95", "140", "190" });
		((Control)cbAmmo3).set_Location(new Point(796, 22));
		((Control)cbAmmo3).set_Margin(new Padding(4));
		((Control)cbAmmo3).set_Name("cbAmmo3");
		((Control)cbAmmo3).set_Size(new Size(64, 24));
		((Control)cbAmmo3).set_TabIndex(20);
		lblAmmo3.set_AutoSize(true);
		((Control)lblAmmo3).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblAmmo3).set_Location(new Point(741, 26));
		((Control)lblAmmo3).set_Margin(new Padding(4, 0, 4, 0));
		((Control)lblAmmo3).set_Name("lblAmmo3");
		((Control)lblAmmo3).set_Size(new Size(51, 17));
		((Control)lblAmmo3).set_TabIndex(18);
		lblAmmo3.set_Text("Arrows");
		((Control)cbAmmo4).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ListControl)cbAmmo4).set_FormattingEnabled(true);
		cbAmmo4.get_Items().AddRange(new object[5] { "1", "2", "3", "4", "5" });
		((Control)cbAmmo4).set_Location(new Point(101, 22));
		((Control)cbAmmo4).set_Margin(new Padding(4));
		((Control)cbAmmo4).set_Name("cbAmmo4");
		((Control)cbAmmo4).set_Size(new Size(64, 24));
		((Control)cbAmmo4).set_TabIndex(21);
		lblAmmo4.set_AutoSize(true);
		((Control)lblAmmo4).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblAmmo4).set_Location(new Point(24, 26));
		((Control)lblAmmo4).set_Margin(new Padding(4, 0, 4, 0));
		((Control)lblAmmo4).set_Name("lblAmmo4");
		((Control)lblAmmo4).set_Size(new Size(74, 17));
		((Control)lblAmmo4).set_TabIndex(20);
		lblAmmo4.set_Text("Dynamites");
		dialRuta.set_Description("Select your CoJ Bound in Blood dedicated server folder.");
		dialRuta.set_ShowNewFolderButton(false);
		((Control)panelAmmo).get_Controls().Add((Control)(object)cbAmmo5);
		((Control)panelAmmo).get_Controls().Add((Control)(object)lblAmmo5);
		((Control)panelAmmo).get_Controls().Add((Control)(object)cbAmmo4);
		((Control)panelAmmo).get_Controls().Add((Control)(object)cbAmmo3);
		((Control)panelAmmo).get_Controls().Add((Control)(object)lblAmmo4);
		((Control)panelAmmo).get_Controls().Add((Control)(object)lblAmmo3);
		((Control)panelAmmo).get_Controls().Add((Control)(object)cbAmmo2);
		((Control)panelAmmo).get_Controls().Add((Control)(object)lblAmmo2);
		((Control)panelAmmo).get_Controls().Add((Control)(object)cbAmmo1);
		((Control)panelAmmo).get_Controls().Add((Control)(object)lblAmmo1);
		((Control)panelAmmo).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)panelAmmo).set_Location(new Point(135, 286));
		((Control)panelAmmo).set_Margin(new Padding(4));
		((Control)panelAmmo).set_Name("panelAmmo");
		((Control)panelAmmo).set_Padding(new Padding(4));
		((Control)panelAmmo).set_Size(new Size(887, 54));
		((Control)panelAmmo).set_TabIndex(24);
		panelAmmo.set_TabStop(false);
		panelAmmo.set_Text("Ammunition");
		((Control)cbAmmo5).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ListControl)cbAmmo5).set_FormattingEnabled(true);
		cbAmmo5.get_Items().AddRange(new object[8] { "35", "45", "55", "65", "75", "95", "140", "190" });
		((Control)cbAmmo5).set_Location(new Point(652, 22));
		((Control)cbAmmo5).set_Margin(new Padding(4));
		((Control)cbAmmo5).set_Name("cbAmmo5");
		((Control)cbAmmo5).set_Size(new Size(64, 24));
		((Control)cbAmmo5).set_TabIndex(19);
		lblAmmo5.set_AutoSize(true);
		((Control)lblAmmo5).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblAmmo5).set_Location(new Point(544, 26));
		((Control)lblAmmo5).set_Margin(new Padding(4, 0, 4, 0));
		((Control)lblAmmo5).set_Name("lblAmmo5");
		((Control)lblAmmo5).set_Size(new Size(104, 17));
		((Control)lblAmmo5).set_TabIndex(22);
		lblAmmo5.set_Text("Shotgun Ammo");
		((Control)groupClass).get_Controls().Add((Control)(object)btnDefault);
		((Control)groupClass).get_Controls().Add((Control)(object)cbClass);
		((Control)groupClass).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)groupClass).set_Location(new Point(585, 595));
		((Control)groupClass).set_Margin(new Padding(4));
		((Control)groupClass).set_Name("groupClass");
		((Control)groupClass).set_Padding(new Padding(4));
		((Control)groupClass).set_Size(new Size(192, 132));
		((Control)groupClass).set_TabIndex(25);
		groupClass.set_TabStop(false);
		groupClass.set_Text("Class");
		((Control)groupClass).set_Visible(false);
		((Control)btnDefault).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)btnDefault).set_Location(new Point(13, 71));
		((Control)btnDefault).set_Margin(new Padding(4));
		((Control)btnDefault).set_Name("btnDefault");
		((Control)btnDefault).set_Size(new Size(161, 53));
		((Control)btnDefault).set_TabIndex(2);
		((ButtonBase)btnDefault).set_Text("Set default weapons");
		((ButtonBase)btnDefault).set_UseVisualStyleBackColor(true);
		((Control)groupWeap).get_Controls().Add((Control)(object)GroupBox1);
		((Control)groupWeap).get_Controls().Add((Control)(object)panelBothHands);
		((Control)groupWeap).get_Controls().Add((Control)(object)panelAmmo);
		((Control)groupWeap).get_Controls().Add((Control)(object)panelModificarArmas);
		((Control)groupWeap).set_Location(new Point(8, 248));
		((Control)groupWeap).set_Margin(new Padding(4));
		((Control)groupWeap).set_Name("groupWeap");
		((Control)groupWeap).set_Padding(new Padding(4));
		((Control)groupWeap).set_Size(new Size(1176, 352));
		((Control)groupWeap).set_TabIndex(26);
		groupWeap.set_TabStop(false);
		((Control)GroupBox1).get_Controls().Add((Control)(object)panelRightHand);
		((Control)GroupBox1).get_Controls().Add((Control)(object)panelLeftHand);
		((Control)GroupBox1).set_Location(new Point(8, 44));
		((Control)GroupBox1).set_Margin(new Padding(4));
		((Control)GroupBox1).set_Name("GroupBox1");
		((Control)GroupBox1).set_Padding(new Padding(4));
		((Control)GroupBox1).set_Size(new Size(861, 229));
		((Control)GroupBox1).set_TabIndex(15);
		GroupBox1.set_TabStop(false);
		((Control)panelRightHand).get_Controls().Add((Control)(object)pictureWeap2);
		((Control)panelRightHand).get_Controls().Add((Control)(object)cbWeap2);
		((Control)panelRightHand).get_Controls().Add((Control)(object)lblWeap2);
		((Control)panelRightHand).set_Location(new Point(569, 25));
		((Control)panelRightHand).set_Margin(new Padding(4));
		((Control)panelRightHand).set_Name("panelRightHand");
		((Control)panelRightHand).set_Padding(new Padding(4));
		((Control)panelRightHand).set_Size(new Size(279, 186));
		((Control)panelRightHand).set_TabIndex(15);
		panelRightHand.set_TabStop(false);
		((Control)panelLeftHand).get_Controls().Add((Control)(object)pictureWeap4);
		((Control)panelLeftHand).get_Controls().Add((Control)(object)pictureWeap1);
		((Control)panelLeftHand).get_Controls().Add((Control)(object)checkWeap4);
		((Control)panelLeftHand).get_Controls().Add((Control)(object)cbWeap1);
		((Control)panelLeftHand).get_Controls().Add((Control)(object)lblWeap1);
		((Control)panelLeftHand).set_Location(new Point(11, 25));
		((Control)panelLeftHand).set_Margin(new Padding(4));
		((Control)panelLeftHand).set_Name("panelLeftHand");
		((Control)panelLeftHand).set_Padding(new Padding(4));
		((Control)panelLeftHand).set_Size(new Size(549, 186));
		((Control)panelLeftHand).set_TabIndex(14);
		panelLeftHand.set_TabStop(false);
		((Control)panelBothHands).get_Controls().Add((Control)(object)pictureWeap3);
		((Control)panelBothHands).get_Controls().Add((Control)(object)cbWeap3);
		((Control)panelBothHands).get_Controls().Add((Control)(object)lblWeap3);
		((Control)panelBothHands).set_Location(new Point(880, 44));
		((Control)panelBothHands).set_Margin(new Padding(4));
		((Control)panelBothHands).set_Name("panelBothHands");
		((Control)panelBothHands).set_Padding(new Padding(4));
		((Control)panelBothHands).set_Size(new Size(296, 229));
		((Control)panelBothHands).set_TabIndex(14);
		panelBothHands.set_TabStop(false);
		panelModificarArmas.set_BorderStyle((BorderStyle)2);
		((Control)panelModificarArmas).get_Controls().Add((Control)(object)lblCreatingEditing);
		((Control)panelModificarArmas).get_Controls().Add((Control)(object)cbDefault);
		((Control)panelModificarArmas).get_Controls().Add((Control)(object)Label2);
		((Control)panelModificarArmas).set_Location(new Point(0, 5));
		((Control)panelModificarArmas).set_Margin(new Padding(4));
		((Control)panelModificarArmas).set_Name("panelModificarArmas");
		((Control)panelModificarArmas).set_Size(new Size(1176, 346));
		((Control)panelModificarArmas).set_TabIndex(31);
		lblCreatingEditing.set_AutoSize(true);
		((Control)lblCreatingEditing).set_Font(new Font("Microsoft Sans Serif", 11.89565f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblCreatingEditing).set_Location(new Point(198, 10));
		((Control)lblCreatingEditing).set_Margin(new Padding(4, 0, 4, 0));
		((Control)lblCreatingEditing).set_Name("lblCreatingEditing");
		((Control)lblCreatingEditing).set_Size(new Size(447, 24));
		((Control)lblCreatingEditing).set_TabIndex(29);
		lblCreatingEditing.set_Text("Weapon Configuration Class: TRIBE WARRIOR");
		cbDefault.set_ForeColor(Color.White);
		((ListControl)cbDefault).set_FormattingEnabled(true);
		cbDefault.get_Items().AddRange(new object[3] { "Both hands Weapon", "Right Weapon + Left Weapon", "Right Weapon + TNT" });
		((Control)cbDefault).set_Location(new Point(907, 9));
		((Control)cbDefault).set_Margin(new Padding(4));
		((Control)cbDefault).set_Name("cbDefault");
		((Control)cbDefault).set_Size(new Size(249, 24));
		((Control)cbDefault).set_TabIndex(0);
		Label2.set_AutoSize(true);
		((Control)Label2).set_Font(new Font("Microsoft Sans Serif", 8.139131f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_Location(new Point(761, 13));
		((Control)Label2).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(145, 17));
		((Control)Label2).set_TabIndex(30);
		Label2.set_Text("Respawn Weapons");
		((Control)pictureClass).set_BackgroundImage((Image)componentResourceManager.GetObject("pictureClass.BackgroundImage"));
		((Control)pictureClass).set_BackgroundImageLayout((ImageLayout)3);
		pictureClass.set_BorderStyle((BorderStyle)1);
		pictureClass.set_ErrorImage((Image)null);
		((Control)pictureClass).set_Location(new Point(8, 9));
		((Control)pictureClass).set_Margin(new Padding(4));
		((Control)pictureClass).set_Name("pictureClass");
		((Control)pictureClass).set_Size(new Size(233, 229));
		pictureClass.set_SizeMode((PictureBoxSizeMode)1);
		pictureClass.set_TabIndex(27);
		pictureClass.set_TabStop(false);
		PictureBox1.set_BorderStyle((BorderStyle)1);
		((Control)PictureBox1).set_Cursor(Cursors.get_Hand());
		PictureBox1.set_Image((Image)componentResourceManager.GetObject("PictureBox1.Image"));
		((Control)PictureBox1).set_Location(new Point(855, 9));
		((Control)PictureBox1).set_Margin(new Padding(4));
		((Control)PictureBox1).set_Name("PictureBox1");
		((Control)PictureBox1).set_Size(new Size(329, 229));
		PictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox1.set_TabIndex(28);
		PictureBox1.set_TabStop(false);
		((Control)btnRestore).set_Location(new Point(948, 625));
		((Control)btnRestore).set_Margin(new Padding(4));
		((Control)btnRestore).set_Name("btnRestore");
		((Control)btnRestore).set_Size(new Size(223, 43));
		((Control)btnRestore).set_TabIndex(23);
		((ButtonBase)btnRestore).set_Text("Restore original classes in game");
		((ButtonBase)btnRestore).set_UseVisualStyleBackColor(true);
		((ButtonBase)checkHC).set_AutoSize(true);
		((Control)checkHC).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)checkHC).set_Location(new Point(68, 638));
		((Control)checkHC).set_Margin(new Padding(4));
		((Control)checkHC).set_Name("checkHC");
		((Control)checkHC).set_Size(new Size(144, 22));
		((Control)checkHC).set_TabIndex(22);
		((ButtonBase)checkHC).set_Text("Hardcore mode");
		((ButtonBase)checkHC).set_UseVisualStyleBackColor(true);
		pictureHC.set_Image((Image)componentResourceManager.GetObject("pictureHC.Image"));
		((Control)pictureHC).set_Location(new Point(9, 613));
		((Control)pictureHC).set_Margin(new Padding(4));
		((Control)pictureHC).set_Name("pictureHC");
		((Control)pictureHC).set_Size(new Size(55, 62));
		pictureHC.set_SizeMode((PictureBoxSizeMode)4);
		pictureHC.set_TabIndex(35);
		pictureHC.set_TabStop(false);
		((Control)TabControlMods).get_Controls().Add((Control)(object)tabNewMod);
		((Control)TabControlMods).set_Location(new Point(500, 11));
		((Control)TabControlMods).set_Margin(new Padding(4));
		((Control)TabControlMods).set_Name("TabControlMods");
		TabControlMods.set_SelectedIndex(0);
		((Control)TabControlMods).set_Size(new Size(347, 227));
		((Control)TabControlMods).set_TabIndex(1);
		((Control)tabNewMod).get_Controls().Add((Control)(object)btnLookMod);
		((Control)tabNewMod).get_Controls().Add((Control)(object)btnSetMod);
		((Control)tabNewMod).get_Controls().Add((Control)(object)btnSave);
		((Control)tabNewMod).get_Controls().Add((Control)(object)btnSaveAs);
		((Control)tabNewMod).get_Controls().Add((Control)(object)lbNewChar);
		tabNewMod.set_Location(new Point(4, 25));
		((Control)tabNewMod).set_Margin(new Padding(4));
		((Control)tabNewMod).set_Name("tabNewMod");
		((Control)tabNewMod).set_Padding(new Padding(4));
		((Control)tabNewMod).set_Size(new Size(339, 198));
		tabNewMod.set_TabIndex(0);
		tabNewMod.set_Text("New Mod");
		tabNewMod.set_UseVisualStyleBackColor(true);
		((Control)btnLookMod).set_Location(new Point(216, 139));
		((Control)btnLookMod).set_Margin(new Padding(4));
		((Control)btnLookMod).set_Name("btnLookMod");
		((Control)btnLookMod).set_Size(new Size(115, 47));
		((Control)btnLookMod).set_TabIndex(37);
		((ButtonBase)btnLookMod).set_Text("Look Mod ...");
		((ButtonBase)btnLookMod).set_UseVisualStyleBackColor(true);
		((Control)btnSetMod).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btnSetMod).set_Location(new Point(216, 80));
		((Control)btnSetMod).set_Margin(new Padding(4));
		((Control)btnSetMod).set_Name("btnSetMod");
		((Control)btnSetMod).set_Size(new Size(115, 50));
		((Control)btnSetMod).set_TabIndex(6);
		((ButtonBase)btnSetMod).set_Text("Set this mod ingame");
		((ButtonBase)btnSetMod).set_UseVisualStyleBackColor(true);
		((Control)btnSave).set_Location(new Point(216, 7));
		((Control)btnSave).set_Margin(new Padding(4));
		((Control)btnSave).set_Name("btnSave");
		((Control)btnSave).set_Size(new Size(115, 28));
		((Control)btnSave).set_TabIndex(4);
		((ButtonBase)btnSave).set_Text("Save");
		((ButtonBase)btnSave).set_UseVisualStyleBackColor(true);
		((Control)btnSaveAs).set_Location(new Point(216, 44));
		((Control)btnSaveAs).set_Margin(new Padding(4));
		((Control)btnSaveAs).set_Name("btnSaveAs");
		((Control)btnSaveAs).set_Size(new Size(115, 28));
		((Control)btnSaveAs).set_TabIndex(5);
		((ButtonBase)btnSaveAs).set_Text("Save Mod as");
		((ButtonBase)btnSaveAs).set_UseVisualStyleBackColor(true);
		((ListControl)lbNewChar).set_FormattingEnabled(true);
		lbNewChar.set_ItemHeight(16);
		((Control)lbNewChar).set_Location(new Point(8, 7));
		((Control)lbNewChar).set_Margin(new Padding(4));
		((Control)lbNewChar).set_Name("lbNewChar");
		((Control)lbNewChar).set_Size(new Size(196, 180));
		((Control)lbNewChar).set_TabIndex(0);
		((Control)btnNewMod).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btnNewMod).set_Location(new Point(250, 106));
		((Control)btnNewMod).set_Margin(new Padding(4));
		((Control)btnNewMod).set_Name("btnNewMod");
		((Control)btnNewMod).set_Size(new Size(100, 28));
		((Control)btnNewMod).set_TabIndex(2);
		((ButtonBase)btnNewMod).set_Text("New Mod");
		((ButtonBase)btnNewMod).set_UseVisualStyleBackColor(true);
		((Control)btnDeleteMod).set_Location(new Point(374, 106));
		((Control)btnDeleteMod).set_Margin(new Padding(4));
		((Control)btnDeleteMod).set_Name("btnDeleteMod");
		((Control)btnDeleteMod).set_Size(new Size(116, 28));
		((Control)btnDeleteMod).set_TabIndex(3);
		((ButtonBase)btnDeleteMod).set_Text("Delete Mod(s)");
		((ButtonBase)btnDeleteMod).set_UseVisualStyleBackColor(true);
		((ListControl)lbLoadMod).set_FormattingEnabled(true);
		((Control)lbLoadMod).set_Location(new Point(250, 52));
		((Control)lbLoadMod).set_Margin(new Padding(4));
		((Control)lbLoadMod).set_Name("lbLoadMod");
		((Control)lbLoadMod).set_Size(new Size(240, 24));
		((Control)lbLoadMod).set_TabIndex(36);
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_Location(new Point(330, 25));
		((Control)Label1).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(79, 20));
		((Control)Label1).set_TabIndex(37);
		Label1.set_Text("My Mods");
		((Control)btnHelp).set_Location(new Point(323, 145));
		((Control)btnHelp).set_Margin(new Padding(4));
		((Control)btnHelp).set_Name("btnHelp");
		((Control)btnHelp).set_Size(new Size(100, 28));
		((Control)btnHelp).set_TabIndex(31);
		((ButtonBase)btnHelp).set_Text("(F1) Help");
		((ButtonBase)btnHelp).set_UseVisualStyleBackColor(true);
		HelpProvider1.set_HelpNamespace("CoJ Mods.chm");
		((ButtonBase)btnServerConfig).set_BackColor(Color.FromArgb(230, 235, 240));
		((Control)btnServerConfig).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)btnServerConfig).set_Location(new Point(377, 644));
		((Control)btnServerConfig).set_Margin(new Padding(4));
		((Control)btnServerConfig).set_Name("btnServerConfig");
		((Control)btnServerConfig).set_Size(new Size(185, 55));
		((Control)btnServerConfig).set_TabIndex(38);
		((ButtonBase)btnServerConfig).set_Text("SERVER CONFIG");
		((ButtonBase)btnServerConfig).set_UseVisualStyleBackColor(false);
		((Control)btnServerConfig).set_Visible(false);
		((ButtonBase)btnLaunchDS).set_BackColor(Color.FromArgb(230, 235, 240));
		((Control)btnLaunchDS).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)btnLaunchDS).set_Location(new Point(377, 613));
		((Control)btnLaunchDS).set_Margin(new Padding(4));
		((Control)btnLaunchDS).set_Name("btnLaunchDS");
		((Control)btnLaunchDS).set_Size(new Size(185, 55));
		((Control)btnLaunchDS).set_TabIndex(39);
		((ButtonBase)btnLaunchDS).set_Text("Launch Dedicated Server");
		((ButtonBase)btnLaunchDS).set_UseVisualStyleBackColor(false);
		((Control)btnLaunchDS).set_Visible(false);
		Timer1.set_Interval(15000);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(1193, 687));
		((Control)this).get_Controls().Add((Control)(object)btnLaunchDS);
		((Control)this).get_Controls().Add((Control)(object)btnServerConfig);
		((Control)this).get_Controls().Add((Control)(object)btnHelp);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)btnNewMod);
		((Control)this).get_Controls().Add((Control)(object)btnDeleteMod);
		((Control)this).get_Controls().Add((Control)(object)lbLoadMod);
		((Control)this).get_Controls().Add((Control)(object)TabControlMods);
		((Control)this).get_Controls().Add((Control)(object)pictureHC);
		((Control)this).get_Controls().Add((Control)(object)checkHC);
		((Control)this).get_Controls().Add((Control)(object)btnRestore);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).get_Controls().Add((Control)(object)pictureClass);
		((Control)this).get_Controls().Add((Control)(object)groupWeap);
		((Control)this).get_Controls().Add((Control)(object)groupClass);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_KeyPreview(true);
		((Form)this).set_Margin(new Padding(4));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MaximumSize(new Size(1557, 940));
		((Form)this).set_MinimumSize(new Size(1211, 733));
		((Control)this).set_Name("frmArmas");
		HelpProvider1.SetShowHelp((Control)(object)this, true);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Modding CoJ2 for Dedicated Servers");
		((ISupportInitialize)pictureWeap1).EndInit();
		((ISupportInitialize)pictureWeap2).EndInit();
		((ISupportInitialize)pictureWeap3).EndInit();
		((ISupportInitialize)pictureWeap4).EndInit();
		((Control)panelAmmo).ResumeLayout(false);
		((Control)panelAmmo).PerformLayout();
		((Control)groupClass).ResumeLayout(false);
		((Control)groupWeap).ResumeLayout(false);
		((Control)GroupBox1).ResumeLayout(false);
		((Control)panelRightHand).ResumeLayout(false);
		((Control)panelRightHand).PerformLayout();
		((Control)panelLeftHand).ResumeLayout(false);
		((Control)panelLeftHand).PerformLayout();
		((Control)panelBothHands).ResumeLayout(false);
		((Control)panelBothHands).PerformLayout();
		((Control)panelModificarArmas).ResumeLayout(false);
		((Control)panelModificarArmas).PerformLayout();
		((ISupportInitialize)pictureClass).EndInit();
		((ISupportInitialize)PictureBox1).EndInit();
		((ISupportInitialize)pictureHC).EndInit();
		((Control)TabControlMods).ResumeLayout(false);
		((Control)tabNewMod).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Yy1(object sender, FormClosingEventArgs e)
	{
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Invalid comparison between Unknown and I4
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Invalid comparison between Unknown and I4
		string text = "";
		if (Operators.CompareString(c2J.ModIniCabecera, "", false) == 0)
		{
			c2J.ModIniCabecera = "0";
		}
		if (Operators.CompareString(c2J.ModIniCabecera, "", false) != 0)
		{
			text += c2J.ModIniCabecera;
		}
		if (Operators.CompareString(Strings.Trim(c2J.ModIniAristocrat), "", false) != 0)
		{
			text = text + "Aristocrat" + c2J.ModIniAristocrat;
		}
		if (Operators.CompareString(Strings.Trim(c2J.ModIniBandit), "", false) != 0)
		{
			text = text + "Bandit" + c2J.ModIniBandit;
		}
		if (Operators.CompareString(Strings.Trim(c2J.ModIniBarnsby), "", false) != 0)
		{
			text = text + "Barnsby" + c2J.ModIniBarnsby;
		}
		if (Operators.CompareString(Strings.Trim(c2J.ModIniDoc), "", false) != 0)
		{
			text = text + "Doc" + c2J.ModIniDoc;
		}
		if (Operators.CompareString(Strings.Trim(c2J.ModIniGunslinger), "", false) != 0)
		{
			text = text + "Gunslinger" + c2J.ModIniGunslinger;
		}
		if (Operators.CompareString(Strings.Trim(c2J.ModIniGunsmith), "", false) != 0)
		{
			text = text + "Gunsmith" + c2J.ModIniGunsmith;
		}
		if (Operators.CompareString(Strings.Trim(c2J.ModIniJuarez), "", false) != 0)
		{
			text = text + "Juarez" + c2J.ModIniJuarez;
		}
		if (Operators.CompareString(Strings.Trim(c2J.ModIniMiner), "", false) != 0)
		{
			text = text + "Miner" + c2J.ModIniMiner;
		}
		if (Operators.CompareString(Strings.Trim(c2J.ModIniRifleman), "", false) != 0)
		{
			text = text + "Rifleman" + c2J.ModIniRifleman;
		}
		if (Operators.CompareString(Strings.Trim(c2J.ModIniSniper), "", false) != 0)
		{
			text = text + "Sniper" + c2J.ModIniSniper;
		}
		if (Operators.CompareString(Strings.Trim(c2J.ModIniThief), "", false) != 0)
		{
			text = text + "Thief" + c2J.ModIniThief;
		}
		if (Operators.CompareString(Strings.Trim(c2J.ModIniTrapper), "", false) != 0)
		{
			text = text + "Trapper" + c2J.ModIniTrapper;
		}
		if (Operators.CompareString(Strings.Trim(c2J.ModIniTribeWarrior), "", false) != 0)
		{
			text = text + "TribeWarrior" + c2J.ModIniTribeWarrior;
		}
		if ((Operators.CompareString(Strings.Trim(c2J.ConfiguracionModInicial), Strings.Trim(text), false) != 0) & (Operators.CompareString(Strings.Trim(text), "0", false) != 0))
		{
			DialogResult val = MessageBox.Show("The current changes to this mod haven't been saved. Do you want to save now?", "", (MessageBoxButtons)3, (MessageBoxIcon)32, (MessageBoxDefaultButton)512);
			if ((int)val == 6)
			{
				w8X();
			}
			else if ((int)val == 2)
			{
				((CancelEventArgs)(object)e).Cancel = true;
				return;
			}
		}
		if (Directory.Exists(c2J.ruta + c2J.rutaTemp))
		{
			((ServerComputer)k8D5.Computer).get_FileSystem().DeleteDirectory(c2J.ruta + c2J.rutaTemp, (DeleteDirectoryOption)5);
		}
		NewLateBinding.LateCall(FrmMain, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		((Component)this).Dispose();
	}

	private void Fk0(object sender, EventArgs e)
	{
		((ServerComputer)k8D5.Computer).get_FileSystem().CreateDirectory(c2J.rutaAppData + "\\Mods\\");
		if (lbNewChar.get_Items().get_Count() == 0)
		{
			((Control)btnSetMod).set_Enabled(false);
		}
		else
		{
			((Control)btnSetMod).set_Enabled(true);
		}
		cbDefault.set_BackColor(Color.SeaGreen);
		((Control)lblAmmo4).set_Enabled(false);
		((Control)cbAmmo4).set_Enabled(false);
		cbAmmo4.set_Text(Conversions.ToString(0));
		pictureWeap4.set_ImageLocation(Application.get_StartupPath() + "\\images\\weaps\\nodynamite.png");
		cbClass.set_SelectedIndex(0);
		cbWeap1.set_SelectedIndex(8);
		cbWeap2.set_SelectedIndex(3);
		cbWeap3.set_SelectedIndex(5);
		cbAmmo1.set_SelectedIndex(1);
		cbAmmo2.set_SelectedIndex(3);
		cbAmmo3.set_SelectedIndex(3);
		cbAmmo5.set_SelectedIndex(0);
		cbDefault.set_SelectedIndex(0);
		pictureWeap1.set_ImageLocation(Application.get_StartupPath() + "\\images\\weaps\\pistol" + cbWeap1.get_SelectedIndex() + ".png");
		pictureWeap2.set_ImageLocation(Application.get_StartupPath() + "\\images\\weaps\\pistol" + cbWeap2.get_SelectedIndex() + ".png");
		pictureWeap3.set_ImageLocation(Application.get_StartupPath() + "\\images\\weaps\\rifle" + cbWeap3.get_SelectedIndex() + ".png");
		pictureClass.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\" + cbClass.get_Text() + ".jpg");
		((Control)TabControlMods).set_Enabled(false);
		((Control)panelModificarArmas).set_Enabled(false);
		((Control)checkHC).set_Enabled(false);
		((Control)panelAmmo).set_Enabled(false);
		((Control)panelLeftHand).set_Enabled(false);
		((Control)panelRightHand).set_Enabled(false);
		((Control)panelBothHands).set_Enabled(false);
	}

	private void b4R(object sender, EventArgs e)
	{
		pictureWeap1.set_ImageLocation(Application.get_StartupPath() + "\\images\\weaps\\pistol" + cbWeap1.get_SelectedIndex() + ".png");
		if (cbWeap1.get_SelectedIndex() == 8)
		{
			((Control)pictureWeap1).set_BackColor(Color.Transparent);
		}
		else if (cbDefault.get_SelectedIndex() == 1)
		{
			((Control)pictureWeap1).set_BackColor(Color.SeaGreen);
		}
	}

	private void p6X(object sender, EventArgs e)
	{
		pictureWeap2.set_ImageLocation(Application.get_StartupPath() + "\\images\\weaps\\pistol" + cbWeap2.get_SelectedIndex() + ".png");
		if (cbWeap2.get_SelectedIndex() == 8)
		{
			((Control)pictureWeap2).set_BackColor(Color.Transparent);
		}
		else if ((cbDefault.get_SelectedIndex() == 1) | (cbDefault.get_SelectedIndex() == 2))
		{
			((Control)pictureWeap2).set_BackColor(Color.SeaGreen);
		}
	}

	private void c7J(object sender, EventArgs e)
	{
		pictureWeap3.set_ImageLocation(Application.get_StartupPath() + "\\images\\weaps\\rifle" + cbWeap3.get_SelectedIndex() + ".png");
	}

	private void Zd7(object sender, EventArgs e)
	{
		if (checkWeap4.get_Checked())
		{
			((Control)lblAmmo4).set_Enabled(true);
			((Control)cbAmmo4).set_Enabled(true);
			cbAmmo4.set_SelectedIndex(1);
			pictureWeap4.set_ImageLocation(Application.get_StartupPath() + "\\images\\weaps\\dynamite.png");
		}
		else
		{
			((Control)lblAmmo4).set_Enabled(false);
			((Control)cbAmmo4).set_Enabled(false);
			cbAmmo4.set_Text(Conversions.ToString(0));
			pictureWeap4.set_ImageLocation(Application.get_StartupPath() + "\\images\\weaps\\nodynamite.png");
		}
	}

	private void d7K(object sender, EventArgs e)
	{
		((ButtonBase)btnDefault).set_Text("Load default " + cbClass.get_Text() + " weapons");
		if (cbClass.get_SelectedIndex() == 0)
		{
			clase = "_NetWeapon_Aristocrat_Properties.scr";
		}
		else if (cbClass.get_SelectedIndex() == 1)
		{
			clase = "_NetWeapon_Bandit_Properties.scr";
		}
		else if (cbClass.get_SelectedIndex() == 2)
		{
			clase = "_NetWeapon_Barnsby_Properties.scr";
		}
		else if (cbClass.get_SelectedIndex() == 3)
		{
			clase = "_NetWeapon_Doc_Properties.scr";
		}
		else if (cbClass.get_SelectedIndex() == 4)
		{
			clase = "_NetWeapon_Gunslinger_Properties.scr";
		}
		else if (cbClass.get_SelectedIndex() == 5)
		{
			clase = "_NetWeapon_Gunsmith_Properties.scr";
		}
		else if (cbClass.get_SelectedIndex() == 6)
		{
			clase = "_NetWeapon_Juarez_Properties.scr";
		}
		else if (cbClass.get_SelectedIndex() == 7)
		{
			clase = "_NetWeapon_Miner_Properties.scr";
		}
		else if (cbClass.get_SelectedIndex() == 8)
		{
			clase = "_NetWeapon_Rifleman_Properties.scr";
		}
		else if (cbClass.get_SelectedIndex() == 9)
		{
			clase = "_NetWeapon_Sniper_Properties.scr";
		}
		else if (cbClass.get_SelectedIndex() == 10)
		{
			clase = "_NetWeapon_Thief_Properties.scr";
		}
		else if (cbClass.get_SelectedIndex() == 11)
		{
			clase = "_NetWeapon_Trapper_Properties.scr";
		}
		else if (cbClass.get_SelectedIndex() == 12)
		{
			clase = "_NetWeapon_TribeWarrior_Properties.scr";
		}
		pictureClass.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\" + cbClass.get_Text() + ".jpg");
		lblCreatingEditing.set_Text(Conversions.ToString(Operators.ConcatenateObject((object)"Creating class: ", cbClass.get_SelectedItem())));
	}

	private void Kp2(object sender, EventArgs e)
	{
		if (cbDefault.get_SelectedIndex() == 0)
		{
			((Control)pictureWeap1).set_BackColor(Color.Transparent);
			((Control)pictureWeap2).set_BackColor(Color.Transparent);
			((Control)pictureWeap3).set_BackColor(Color.SeaGreen);
			((Control)pictureWeap4).set_BackColor(Color.Transparent);
		}
		else if (cbDefault.get_SelectedIndex() == 1)
		{
			if (cbWeap1.get_SelectedIndex() == 8)
			{
				((Control)pictureWeap1).set_BackColor(Color.Transparent);
			}
			else
			{
				((Control)pictureWeap1).set_BackColor(Color.SeaGreen);
			}
			if (cbWeap2.get_SelectedIndex() == 8)
			{
				((Control)pictureWeap2).set_BackColor(Color.Transparent);
			}
			else
			{
				((Control)pictureWeap2).set_BackColor(Color.SeaGreen);
			}
			((Control)pictureWeap3).set_BackColor(Color.Transparent);
			((Control)pictureWeap4).set_BackColor(Color.Transparent);
		}
		else if (cbDefault.get_SelectedIndex() == 2)
		{
			((Control)pictureWeap1).set_BackColor(Color.Transparent);
			((Control)pictureWeap2).set_BackColor(Color.SeaGreen);
			((Control)pictureWeap3).set_BackColor(Color.Transparent);
			((Control)pictureWeap4).set_BackColor(Color.SeaGreen);
			checkWeap4.set_Checked(true);
		}
	}

	private void d0C(object sender, EventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected I4, but got Unknown
		int num = (int)MessageBox.Show("WARNING! All classes in dedicated server are going to be restored like original game's classes. Do you want to continue?", "", (MessageBoxButtons)4, (MessageBoxIcon)48);
		if (num == 6)
		{
			checkHC.set_Checked(false);
			if (Directory.Exists(c2J.ruta + c2J.rutaPlayer))
			{
				((ServerComputer)k8D5.Computer).get_FileSystem().DeleteDirectory(c2J.ruta + c2J.rutaPlayer, (DeleteDirectoryOption)5);
			}
		}
	}

	private void Sy9(object sender, KeyPressEventArgs e)
	{
		e.set_KeyChar('\0');
	}

	private void x8J(object sender, EventArgs e)
	{
		if (cbClass.get_SelectedIndex() == 0)
		{
			cbWeap1.set_SelectedIndex(8);
			cbWeap2.set_SelectedIndex(3);
			cbWeap3.set_SelectedIndex(5);
			checkWeap4.set_Checked(false);
			cbDefault.set_SelectedIndex(0);
		}
		else if (cbClass.get_SelectedIndex() == 1)
		{
			cbWeap1.set_SelectedIndex(4);
			cbWeap2.set_SelectedIndex(4);
			cbWeap3.set_SelectedIndex(6);
			checkWeap4.set_Checked(false);
			cbDefault.set_SelectedIndex(1);
		}
		else if (cbClass.get_SelectedIndex() == 2)
		{
			cbWeap1.set_SelectedIndex(8);
			cbWeap2.set_SelectedIndex(8);
			cbWeap3.set_SelectedIndex(2);
			checkWeap4.set_Checked(false);
			cbDefault.set_SelectedIndex(0);
		}
		else if (cbClass.get_SelectedIndex() == 3)
		{
			cbWeap1.set_SelectedIndex(8);
			cbWeap2.set_SelectedIndex(6);
			cbWeap3.set_SelectedIndex(6);
			checkWeap4.set_Checked(false);
			cbDefault.set_SelectedIndex(1);
		}
		else if (cbClass.get_SelectedIndex() == 4)
		{
			cbWeap1.set_SelectedIndex(5);
			cbWeap2.set_SelectedIndex(5);
			cbWeap3.set_SelectedIndex(6);
			checkWeap4.set_Checked(true);
			cbAmmo4.set_SelectedIndex(1);
			cbDefault.set_SelectedIndex(1);
		}
		else if (cbClass.get_SelectedIndex() == 5)
		{
			cbWeap1.set_SelectedIndex(2);
			cbWeap2.set_SelectedIndex(0);
			cbWeap3.set_SelectedIndex(6);
			checkWeap4.set_Checked(false);
			cbDefault.set_SelectedIndex(1);
		}
		else if (cbClass.get_SelectedIndex() == 6)
		{
			cbWeap1.set_SelectedIndex(7);
			cbWeap2.set_SelectedIndex(7);
			cbWeap3.set_SelectedIndex(6);
			checkWeap4.set_Checked(false);
			cbDefault.set_SelectedIndex(1);
		}
		else if (cbClass.get_SelectedIndex() == 7)
		{
			cbWeap1.set_SelectedIndex(7);
			cbWeap2.set_SelectedIndex(4);
			cbWeap3.set_SelectedIndex(6);
			checkWeap4.set_Checked(true);
			cbAmmo4.set_SelectedIndex(4);
			cbDefault.set_SelectedIndex(2);
		}
		else if (cbClass.get_SelectedIndex() == 8)
		{
			cbWeap1.set_SelectedIndex(3);
			cbWeap2.set_SelectedIndex(3);
			cbWeap3.set_SelectedIndex(4);
			checkWeap4.set_Checked(false);
			cbDefault.set_SelectedIndex(0);
		}
		else if (cbClass.get_SelectedIndex() == 9)
		{
			cbWeap1.set_SelectedIndex(8);
			cbWeap2.set_SelectedIndex(7);
			cbWeap3.set_SelectedIndex(3);
			checkWeap4.set_Checked(false);
			cbDefault.set_SelectedIndex(0);
		}
		else if (cbClass.get_SelectedIndex() == 10)
		{
			cbWeap1.set_SelectedIndex(8);
			cbWeap2.set_SelectedIndex(1);
			cbWeap3.set_SelectedIndex(6);
			checkWeap4.set_Checked(true);
			cbAmmo4.set_SelectedIndex(2);
			cbDefault.set_SelectedIndex(2);
		}
		else if (cbClass.get_SelectedIndex() == 11)
		{
			cbWeap1.set_SelectedIndex(8);
			cbWeap2.set_SelectedIndex(7);
			cbWeap3.set_SelectedIndex(1);
			checkWeap4.set_Checked(false);
			cbDefault.set_SelectedIndex(0);
		}
		else if (cbClass.get_SelectedIndex() == 12)
		{
			cbWeap1.set_SelectedIndex(8);
			cbWeap2.set_SelectedIndex(8);
			cbWeap3.set_SelectedIndex(0);
			checkWeap4.set_Checked(false);
			cbDefault.set_SelectedIndex(0);
		}
	}

	private void i6X(object sender, EventArgs e)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected I4, but got Unknown
		if (checkHC.get_Checked() & (estabaActivadoHC == 0))
		{
			int num = (int)MessageBox.Show("All classes could die with only one shot in this gamemode. Do you want to continue?", "Hardcore Mode", (MessageBoxButtons)4, (MessageBoxIcon)32);
			if (num == 6)
			{
				c2J.ModIniCabecera = "1";
			}
			else
			{
				checkHC.set_Checked(false);
			}
		}
		else
		{
			c2J.ModIniCabecera = "0";
		}
	}

	private void b8M(object sender, EventArgs e)
	{
		if (File.Exists(c2J.ruta + c2J.rutaTemp + "WeaponsParams.scr"))
		{
			estabaActivadoHC = 1;
			checkHC.set_Checked(true);
			estabaActivadoHC = 0;
		}
		lblCreatingEditing.set_Text("Weapon Configuration Class: ...");
		pictureClass.set_ImageLocation(Application.get_StartupPath() + "\\images\\fondo.jpg");
	}

	private void Ai0(object sender, EventArgs e)
	{
		((Control)k8D5.Forms.frmAcercade).Show();
	}

	private void n8C(object sender, EventArgs e)
	{
		string text = "";
		if (Operators.ConditionalCompareObjectEqual(lbNewChar.get_SelectedItem(), (object)"Aristocrat", false))
		{
			currentFile = "_NetWeapon_Aristocrat_Properties.scr";
			text = c2J.ModIniAristocrat;
		}
		else if (Operators.ConditionalCompareObjectEqual(lbNewChar.get_SelectedItem(), (object)"Bandit", false))
		{
			currentFile = "_NetWeapon_Bandit_Properties.scr";
			text = c2J.ModIniBandit;
		}
		else if (Operators.ConditionalCompareObjectEqual(lbNewChar.get_SelectedItem(), (object)"Barnsby", false))
		{
			currentFile = "_NetWeapon_Barnsby_Properties.scr";
			text = c2J.ModIniBarnsby;
		}
		else if (Operators.ConditionalCompareObjectEqual(lbNewChar.get_SelectedItem(), (object)"Doc", false))
		{
			currentFile = "_NetWeapon_Doc_Properties.scr";
			text = c2J.ModIniDoc;
		}
		else if (Operators.ConditionalCompareObjectEqual(lbNewChar.get_SelectedItem(), (object)"Gunslinger", false))
		{
			currentFile = "_NetWeapon_Gunslinger_Properties.scr";
			text = c2J.ModIniGunslinger;
		}
		else if (Operators.ConditionalCompareObjectEqual(lbNewChar.get_SelectedItem(), (object)"Gunsmith", false))
		{
			currentFile = "_NetWeapon_Gunsmith_Properties.scr";
			text = c2J.ModIniGunsmith;
		}
		else if (Operators.ConditionalCompareObjectEqual(lbNewChar.get_SelectedItem(), (object)"Juarez", false))
		{
			currentFile = "_NetWeapon_Juarez_Properties.scr";
			text = c2J.ModIniJuarez;
		}
		else if (Operators.ConditionalCompareObjectEqual(lbNewChar.get_SelectedItem(), (object)"Miner", false))
		{
			currentFile = "_NetWeapon_Miner_Properties.scr";
			text = c2J.ModIniMiner;
		}
		else if (Operators.ConditionalCompareObjectEqual(lbNewChar.get_SelectedItem(), (object)"Rifleman", false))
		{
			currentFile = "_NetWeapon_Rifleman_Properties.scr";
			text = c2J.ModIniRifleman;
		}
		else if (Operators.ConditionalCompareObjectEqual(lbNewChar.get_SelectedItem(), (object)"Sniper", false))
		{
			currentFile = "_NetWeapon_Sniper_Properties.scr";
			text = c2J.ModIniSniper;
		}
		else if (Operators.ConditionalCompareObjectEqual(lbNewChar.get_SelectedItem(), (object)"Thief", false))
		{
			currentFile = "_NetWeapon_Thief_Properties.scr";
			text = c2J.ModIniThief;
		}
		else if (Operators.ConditionalCompareObjectEqual(lbNewChar.get_SelectedItem(), (object)"Trapper", false))
		{
			currentFile = "_NetWeapon_Trapper_Properties.scr";
			text = c2J.ModIniTrapper;
		}
		else if (Operators.ConditionalCompareObjectEqual(lbNewChar.get_SelectedItem(), (object)"Tribe Warrior", false))
		{
			currentFile = "_NetWeapon_TribeWarrior_Properties.scr";
			text = c2J.ModIniTribeWarrior;
		}
		if (Strings.Len(text) > 0)
		{
			cbDefault.set_SelectedIndex(Conversions.ToInteger(text.Substring(0, 1)));
			checkWeap4.set_Checked(Conversions.ToBoolean(text.Substring(1, 1)));
			cbWeap1.set_SelectedIndex(Conversions.ToInteger(text.Substring(2, 1)));
			cbWeap2.set_SelectedIndex(Conversions.ToInteger(text.Substring(3, 1)));
			cbWeap3.set_SelectedIndex(Conversions.ToInteger(text.Substring(4, 1)));
			cbAmmo1.set_SelectedIndex(Conversions.ToInteger(text.Substring(5, 1)));
			cbAmmo2.set_SelectedIndex(Conversions.ToInteger(text.Substring(6, 1)));
			cbAmmo5.set_SelectedIndex(Conversions.ToInteger(text.Substring(7, 1)));
			cbAmmo3.set_SelectedIndex(Conversions.ToInteger(text.Substring(8, 1)));
			cbAmmo4.set_SelectedIndex(Conversions.ToInteger(text.Substring(9, 1)));
		}
		pictureClass.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\" + lbNewChar.get_Text() + ".jpg");
		Label obj = lblCreatingEditing;
		object[] array;
		ListBox val;
		bool[] array2;
		object obj2 = NewLateBinding.LateGet((object)null, typeof(Strings), "UCase", array = new object[1] { (val = lbNewChar).get_SelectedItem() }, (string[])null, (Type[])null, array2 = new bool[1] { true });
		if (array2[0])
		{
			val.set_SelectedItem(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0])));
		}
		obj.set_Text(Conversions.ToString(Operators.ConcatenateObject((object)"Weapon Configuration Class: ", obj2)));
	}

	private void w8X()
	{
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected I4, but got Unknown
		if (Operators.CompareString(c2J.modName, "", false) == 0)
		{
			c2J.cancelModName = false;
		}
		if ((Operators.CompareString(c2J.modName, "", false) == 0) | c2J.cancelModName)
		{
			c2J.cancelModName = false;
			return;
		}
		if (Directory.Exists(c2J.rutaAppData + "\\Mods\\" + c2J.modName) & (Operators.CompareString(c2J.ModNameComprobacionGuardar, c2J.modName, false) != 0))
		{
			int num = (int)MessageBox.Show("Existing Mod. Do you want to overwrite the gamemode " + c2J.modName.ToUpper() + " ?", "", (MessageBoxButtons)4, (MessageBoxIcon)48);
			if (num != 6)
			{
				if (Operators.CompareString(tabNewMod.get_Text(), "New Mod", false) != 0)
				{
					c2J.modName = tabNewMod.get_Text();
				}
				else
				{
					c2J.modName = "";
				}
				return;
			}
			if (Directory.Exists(c2J.rutaAppData + "\\Mods\\" + c2J.modName))
			{
				((ServerComputer)k8D5.Computer).get_FileSystem().DeleteDirectory(c2J.rutaAppData + "\\Mods\\" + c2J.modName, (DeleteDirectoryOption)5);
			}
		}
		((ServerComputer)k8D5.Computer).get_FileSystem().CreateDirectory(c2J.rutaAppData + "\\Mods");
		((ServerComputer)k8D5.Computer).get_FileSystem().CreateDirectory(c2J.rutaAppData + "\\Mods\\" + c2J.modName);
		tabNewMod.set_Text(c2J.modName);
		c2J.Ng1();
		lbLoadMod.set_Text(c2J.modName);
		c2J.ModNameComprobacionGuardar = c2J.modName;
	}

	private void Db1(object sender, EventArgs e)
	{
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected I4, but got Unknown
		c2J.cancelModName = false;
		if ((Operators.CompareString(c2J.modName, "", false) == 0) | c2J.cancelModName)
		{
			c2J.cancelModName = false;
			return;
		}
		if (Directory.Exists(c2J.rutaAppData + "\\Mods\\" + c2J.modName))
		{
			int num = (int)MessageBox.Show("Existing Mod. Do you want to overwrite the gamemode " + c2J.modName.ToUpper() + " ?", "", (MessageBoxButtons)4, (MessageBoxIcon)48);
			if (num != 6)
			{
				if (Operators.CompareString(tabNewMod.get_Text(), "New Mod", false) != 0)
				{
					c2J.modName = tabNewMod.get_Text();
				}
				else
				{
					c2J.modName = "";
				}
				return;
			}
			if (Directory.Exists(c2J.rutaAppData + "\\Mods\\" + c2J.modName))
			{
				((ServerComputer)k8D5.Computer).get_FileSystem().DeleteDirectory(c2J.rutaAppData + "\\Mods\\" + c2J.modName, (DeleteDirectoryOption)5);
			}
		}
		tabNewMod.set_Text(c2J.modName);
		((ServerComputer)k8D5.Computer).get_FileSystem().CreateDirectory(c2J.rutaAppData + "\\Mods");
		((ServerComputer)k8D5.Computer).get_FileSystem().CreateDirectory(c2J.rutaAppData + "\\Mods\\" + c2J.modName);
		c2J.Ng1();
		lbLoadMod.set_Text(c2J.modName);
	}

	private void Wb4(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(lbLoadMod.get_SelectedItem(), (object)"", false))
		{
			((Control)TabControlMods).set_Enabled(false);
			((Control)panelModificarArmas).set_Enabled(false);
			((Control)checkHC).set_Enabled(false);
			((ButtonBase)btnLookMod).set_Text("Look Mod ...");
			((Control)panelAmmo).set_Enabled(false);
			((Control)panelLeftHand).set_Enabled(false);
			((Control)panelRightHand).set_Enabled(false);
			((Control)panelBothHands).set_Enabled(false);
		}
		else
		{
			((Control)TabControlMods).set_Enabled(true);
			((Control)panelModificarArmas).set_Enabled(true);
			((Control)checkHC).set_Enabled(true);
			((Control)panelAmmo).set_Enabled(true);
			((Control)panelLeftHand).set_Enabled(true);
			((Control)panelRightHand).set_Enabled(true);
			((Control)panelBothHands).set_Enabled(true);
		}
	}

	private void Mb7(object sender, EventArgs e)
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected I4, but got Unknown
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		if (File.Exists(c2J.ruta + "\\CoJ2Game_x86_ds.exe") & File.Exists(c2J.ruta + "\\CoJ2_x86_ds.dll"))
		{
			Process[] processes = Process.GetProcesses();
			Process[] array = processes;
			int num = 0;
			while (true)
			{
				if (num < array.Length)
				{
					Process process = array[num];
					if (Operators.CompareString(process.ProcessName, "CoJ2Game_x86_ds", false) != 0)
					{
						num = checked(num + 1);
						continue;
					}
					MessageBox.Show("You must close CoJ2 Dedicated Server before you make some changes. Close the server and try again. The mod has not been set.", "", (MessageBoxButtons)0, (MessageBoxIcon)48);
					break;
				}
				int num2 = (int)MessageBox.Show("Your current server game mod will be changed for this one. Do you want to continue?", "", (MessageBoxButtons)4, (MessageBoxIcon)32);
				if (num2 == 6)
				{
					if (Directory.Exists(c2J.ruta + c2J.rutaPlayer))
					{
						((ServerComputer)k8D5.Computer).get_FileSystem().DeleteDirectory(c2J.ruta + c2J.rutaPlayer, (DeleteDirectoryOption)5);
					}
					if (Directory.Exists(c2J.ruta + c2J.rutaTemp))
					{
						((ServerComputer)k8D5.Computer).get_FileSystem().CopyDirectory(c2J.ruta + c2J.rutaTemp, c2J.ruta + c2J.rutaPlayer);
					}
				}
				if (File.Exists(c2J.ruta + c2J.rutaPlayer + "WeaponsParams.scr") & (estabaActivadoHC == 0))
				{
					((ServerComputer)k8D5.Computer).get_FileSystem().DeleteFile(c2J.ruta + c2J.rutaPlayer + "WeaponsParams.scr");
				}
				if (checkHC.get_Checked())
				{
					c2J.Yq7(Application.get_StartupPath() + "\\bin\\modscoj.dll", c2J.ruta + c2J.rutaPlayer + "WeaponsParams.scr", "%c0jm0ds");
				}
				else if (((ServerComputer)k8D5.Computer).get_FileSystem().FileExists(c2J.ruta + c2J.rutaPlayer + "WeaponsParams.scr"))
				{
					((ServerComputer)k8D5.Computer).get_FileSystem().DeleteFile(c2J.ruta + c2J.rutaPlayer + "WeaponsParams.scr");
				}
				break;
			}
		}
		else
		{
			MessageBox.Show("You have to choose the same path where CoJ Dedicated Server was installed.", "", (MessageBoxButtons)0, (MessageBoxIcon)48);
			((CommonDialog)dialRuta).ShowDialog();
			c2J.ruta = dialRuta.get_SelectedPath();
			if (File.Exists(c2J.ruta + "\\CoJ2Game_x86_ds.exe") & File.Exists(c2J.ruta + "\\CoJ2_x86_ds.dll"))
			{
				writeini = File.AppendText(Application.get_StartupPath() + "\\cojmods.ini");
				writeini.WriteLine(c2J.ruta);
				writeini.Close();
			}
		}
	}

	private void To4()
	{
		string text = "";
		if (checkWeap4.get_Checked())
		{
			text = cbAmmo4.get_SelectedIndex().ToString();
			TntSiNo = Conversions.ToString(1);
		}
		else
		{
			text = Conversions.ToString(0);
			TntSiNo = Conversions.ToString(0);
		}
		if (Operators.CompareString(lbNewChar.get_Text(), "Aristocrat", false) == 0)
		{
			c2J.ModIniAristocrat = cbDefault.get_SelectedIndex() + TntSiNo + cbWeap1.get_SelectedIndex() + cbWeap2.get_SelectedIndex() + cbWeap3.get_SelectedIndex() + cbAmmo1.get_SelectedIndex() + cbAmmo2.get_SelectedIndex() + cbAmmo5.get_SelectedIndex() + cbAmmo3.get_SelectedIndex() + text;
		}
		else if (Operators.CompareString(lbNewChar.get_Text(), "Bandit", false) == 0)
		{
			c2J.ModIniBandit = cbDefault.get_SelectedIndex() + TntSiNo + cbWeap1.get_SelectedIndex() + cbWeap2.get_SelectedIndex() + cbWeap3.get_SelectedIndex() + cbAmmo1.get_SelectedIndex() + cbAmmo2.get_SelectedIndex() + cbAmmo5.get_SelectedIndex() + cbAmmo3.get_SelectedIndex() + text;
		}
		else if (Operators.CompareString(lbNewChar.get_Text(), "Barnsby", false) == 0)
		{
			c2J.ModIniBarnsby = cbDefault.get_SelectedIndex() + TntSiNo + cbWeap1.get_SelectedIndex() + cbWeap2.get_SelectedIndex() + cbWeap3.get_SelectedIndex() + cbAmmo1.get_SelectedIndex() + cbAmmo2.get_SelectedIndex() + cbAmmo5.get_SelectedIndex() + cbAmmo3.get_SelectedIndex() + text;
		}
		else if (Operators.CompareString(lbNewChar.get_Text(), "Doc", false) == 0)
		{
			c2J.ModIniDoc = cbDefault.get_SelectedIndex() + TntSiNo + cbWeap1.get_SelectedIndex() + cbWeap2.get_SelectedIndex() + cbWeap3.get_SelectedIndex() + cbAmmo1.get_SelectedIndex() + cbAmmo2.get_SelectedIndex() + cbAmmo5.get_SelectedIndex() + cbAmmo3.get_SelectedIndex() + text;
		}
		else if (Operators.CompareString(lbNewChar.get_Text(), "Gunslinger", false) == 0)
		{
			c2J.ModIniGunslinger = cbDefault.get_SelectedIndex() + TntSiNo + cbWeap1.get_SelectedIndex() + cbWeap2.get_SelectedIndex() + cbWeap3.get_SelectedIndex() + cbAmmo1.get_SelectedIndex() + cbAmmo2.get_SelectedIndex() + cbAmmo5.get_SelectedIndex() + cbAmmo3.get_SelectedIndex() + text;
		}
		else if (Operators.CompareString(lbNewChar.get_Text(), "Gunsmith", false) == 0)
		{
			c2J.ModIniGunsmith = cbDefault.get_SelectedIndex() + TntSiNo + cbWeap1.get_SelectedIndex() + cbWeap2.get_SelectedIndex() + cbWeap3.get_SelectedIndex() + cbAmmo1.get_SelectedIndex() + cbAmmo2.get_SelectedIndex() + cbAmmo5.get_SelectedIndex() + cbAmmo3.get_SelectedIndex() + text;
		}
		else if (Operators.CompareString(lbNewChar.get_Text(), "Juarez", false) == 0)
		{
			c2J.ModIniJuarez = cbDefault.get_SelectedIndex() + TntSiNo + cbWeap1.get_SelectedIndex() + cbWeap2.get_SelectedIndex() + cbWeap3.get_SelectedIndex() + cbAmmo1.get_SelectedIndex() + cbAmmo2.get_SelectedIndex() + cbAmmo5.get_SelectedIndex() + cbAmmo3.get_SelectedIndex() + text;
		}
		else if (Operators.CompareString(lbNewChar.get_Text(), "Miner", false) == 0)
		{
			c2J.ModIniMiner = cbDefault.get_SelectedIndex() + TntSiNo + cbWeap1.get_SelectedIndex() + cbWeap2.get_SelectedIndex() + cbWeap3.get_SelectedIndex() + cbAmmo1.get_SelectedIndex() + cbAmmo2.get_SelectedIndex() + cbAmmo5.get_SelectedIndex() + cbAmmo3.get_SelectedIndex() + text;
		}
		else if (Operators.CompareString(lbNewChar.get_Text(), "Rifleman", false) == 0)
		{
			c2J.ModIniRifleman = cbDefault.get_SelectedIndex() + TntSiNo + cbWeap1.get_SelectedIndex() + cbWeap2.get_SelectedIndex() + cbWeap3.get_SelectedIndex() + cbAmmo1.get_SelectedIndex() + cbAmmo2.get_SelectedIndex() + cbAmmo5.get_SelectedIndex() + cbAmmo3.get_SelectedIndex() + text;
		}
		else if (Operators.CompareString(lbNewChar.get_Text(), "Sniper", false) == 0)
		{
			c2J.ModIniSniper = cbDefault.get_SelectedIndex() + TntSiNo + cbWeap1.get_SelectedIndex() + cbWeap2.get_SelectedIndex() + cbWeap3.get_SelectedIndex() + cbAmmo1.get_SelectedIndex() + cbAmmo2.get_SelectedIndex() + cbAmmo5.get_SelectedIndex() + cbAmmo3.get_SelectedIndex() + text;
		}
		else if (Operators.CompareString(lbNewChar.get_Text(), "Thief", false) == 0)
		{
			c2J.ModIniThief = cbDefault.get_SelectedIndex() + TntSiNo + cbWeap1.get_SelectedIndex() + cbWeap2.get_SelectedIndex() + cbWeap3.get_SelectedIndex() + cbAmmo1.get_SelectedIndex() + cbAmmo2.get_SelectedIndex() + cbAmmo5.get_SelectedIndex() + cbAmmo3.get_SelectedIndex() + text;
		}
		else if (Operators.CompareString(lbNewChar.get_Text(), "Trapper", false) == 0)
		{
			c2J.ModIniTrapper = cbDefault.get_SelectedIndex() + TntSiNo + cbWeap1.get_SelectedIndex() + cbWeap2.get_SelectedIndex() + cbWeap3.get_SelectedIndex() + cbAmmo1.get_SelectedIndex() + cbAmmo2.get_SelectedIndex() + cbAmmo5.get_SelectedIndex() + cbAmmo3.get_SelectedIndex() + text;
		}
		else if (Operators.CompareString(lbNewChar.get_Text(), "Tribe Warrior", false) == 0)
		{
			c2J.ModIniTribeWarrior = cbDefault.get_SelectedIndex() + TntSiNo + cbWeap1.get_SelectedIndex() + cbWeap2.get_SelectedIndex() + cbWeap3.get_SelectedIndex() + cbAmmo1.get_SelectedIndex() + cbAmmo2.get_SelectedIndex() + cbAmmo5.get_SelectedIndex() + cbAmmo3.get_SelectedIndex() + text;
		}
	}

	private void Ej3(object sender, EventArgs e)
	{
		To4();
	}

	private void Rg8(object sender, EventArgs e)
	{
		To4();
	}

	private void Km1(object sender, EventArgs e)
	{
		To4();
	}

	private void d8T(object sender, EventArgs e)
	{
		To4();
	}

	private void Gp4(object sender, EventArgs e)
	{
		To4();
	}

	private void c2C(object sender, EventArgs e)
	{
	}

	private void b1F(object sender, EventArgs e)
	{
		lbNewChar.get_Items().Clear();
		TabControlMods.set_SelectedTab(tabNewMod);
		((Control)btnSetMod).set_Enabled(false);
		c2J.modName = "";
		tabNewMod.set_Text("New Mod");
		checkHC.set_Checked(false);
		c2J.ModIniAristocrat = "0083513030";
		c2J.ModIniBandit = "1044613030";
		c2J.ModIniBarnsby = "0088213030";
		c2J.ModIniCabecera = "0";
		c2J.ModIniDoc = "1086613030";
		c2J.ModIniGunslinger = "1155613031";
		c2J.ModIniGunsmith = "1020613030";
		c2J.ModIniJuarez = "1077613030";
		c2J.ModIniMiner = "2174613034";
		c2J.ModIniRifleman = "0033413030";
		c2J.ModIniSniper = "0087313030";
		c2J.ModIniThief = "2181613032";
		c2J.ModIniTrapper = "0087113030";
		c2J.ModIniTribeWarrior = "0088013030";
		lbNewChar.get_Items().Add((object)"Aristocrat");
		lbNewChar.get_Items().Add((object)"Bandit");
		lbNewChar.get_Items().Add((object)"Barnsby");
		lbNewChar.get_Items().Add((object)"Doc");
		lbNewChar.get_Items().Add((object)"Gunslinger");
		lbNewChar.get_Items().Add((object)"Gunsmith");
		lbNewChar.get_Items().Add((object)"Juarez");
		lbNewChar.get_Items().Add((object)"Miner");
		lbNewChar.get_Items().Add((object)"Rifleman");
		lbNewChar.get_Items().Add((object)"Sniper");
		lbNewChar.get_Items().Add((object)"Thief");
		lbNewChar.get_Items().Add((object)"Trapper");
		lbNewChar.get_Items().Add((object)"Tribe Warrior");
		((Control)TabControlMods).set_Enabled(true);
		((Control)panelModificarArmas).set_Enabled(true);
		((Control)checkHC).set_Enabled(true);
		((Control)panelAmmo).set_Enabled(true);
		((Control)panelLeftHand).set_Enabled(true);
		((Control)panelRightHand).set_Enabled(true);
		((Control)panelBothHands).set_Enabled(true);
		lbLoadMod.set_Text("");
		((ButtonBase)btnLookMod).set_Text("Look Mod ...");
		lbNewChar.set_SelectedIndex(0);
		c2J.ModNameComprobacionGuardar = "";
	}

	public void w8D()
	{
		if (!(File.Exists(c2J.ruta + "\\CoJ2Game_x86_ds.exe") & File.Exists(c2J.ruta + "\\CoJ2_x86_ds.dll")))
		{
			return;
		}
		string text = "";
		string text2 = "";
		string text3 = "";
		string text4 = "";
		string text5 = "";
		string text6 = "";
		string text7 = "";
		int num = 0;
		string text8 = "";
		string text9 = "";
		string text10 = "";
		int num2 = 1;
		checked
		{
			do
			{
				string text11 = "";
				if ((num2 == 1) & lbNewChar.get_Items().Contains((object)"Aristocrat"))
				{
					clase = "Aristocrat";
					text11 = c2J.ModIniAristocrat;
				}
				if ((num2 == 2) & lbNewChar.get_Items().Contains((object)"Bandit"))
				{
					clase = "Bandit";
					text11 = c2J.ModIniBandit;
				}
				if ((num2 == 3) & lbNewChar.get_Items().Contains((object)"Barnsby"))
				{
					clase = "Barnsby";
					text11 = c2J.ModIniBarnsby;
				}
				if ((num2 == 4) & lbNewChar.get_Items().Contains((object)"Doc"))
				{
					clase = "Doc";
					text11 = c2J.ModIniDoc;
				}
				if ((num2 == 5) & lbNewChar.get_Items().Contains((object)"Gunslinger"))
				{
					clase = "Gunslinger";
					text11 = c2J.ModIniGunslinger;
				}
				if ((num2 == 6) & lbNewChar.get_Items().Contains((object)"Gunsmith"))
				{
					clase = "Gunsmith";
					text11 = c2J.ModIniGunsmith;
				}
				if ((num2 == 7) & lbNewChar.get_Items().Contains((object)"Juarez"))
				{
					clase = "Juarez";
					text11 = c2J.ModIniJuarez;
				}
				if ((num2 == 8) & lbNewChar.get_Items().Contains((object)"Miner"))
				{
					clase = "Miner";
					text11 = c2J.ModIniMiner;
				}
				if ((num2 == 9) & lbNewChar.get_Items().Contains((object)"Rifleman"))
				{
					clase = "Rifleman";
					text11 = c2J.ModIniRifleman;
				}
				if ((num2 == 10) & lbNewChar.get_Items().Contains((object)"Sniper"))
				{
					clase = "Sniper";
					text11 = c2J.ModIniSniper;
				}
				if ((num2 == 11) & lbNewChar.get_Items().Contains((object)"Thief"))
				{
					clase = "Thief";
					text11 = c2J.ModIniThief;
				}
				if ((num2 == 12) & lbNewChar.get_Items().Contains((object)"Trapper"))
				{
					clase = "Trapper";
					text11 = c2J.ModIniTrapper;
				}
				if ((num2 == 13) & lbNewChar.get_Items().Contains((object)"Tribe Warrior"))
				{
					clase = "TribeWarrior";
					text11 = c2J.ModIniTribeWarrior;
				}
				if (Operators.CompareString(text11, "", false) != 0)
				{
					if (File.Exists(c2J.rutaAppData + "\\Mods\\" + c2J.modName + "\\_NetWeapon_" + clase + "_Properties.scr"))
					{
						((ServerComputer)k8D5.Computer).get_FileSystem().DeleteFile(c2J.rutaAppData + "\\Mods\\" + c2J.modName + "\\_NetWeapon_" + clase + "_Properties.scr");
					}
					c2J.write = File.AppendText(c2J.rutaAppData + "\\Mods\\" + c2J.modName + "\\_NetWeapon_" + clase + "_Properties.scr");
					c2J.write.WriteLine("!NetAmmo(s, i)");
					c2J.write.WriteLine("!NetWeapon(s)");
					c2J.write.WriteLine("!NetDefaultWeaponL(s)");
					c2J.write.WriteLine("!NetDefaultWeaponR(s)");
					if (Conversions.ToDouble(text11.Substring(2, 1)) == 0.0)
					{
						text = "\"WeaponPistolCogswellNet\"";
					}
					else if (Conversions.ToDouble(text11.Substring(2, 1)) == 1.0)
					{
						text = "\"WeaponPistolDerringerNet\"";
					}
					else if (Conversions.ToDouble(text11.Substring(2, 1)) == 2.0)
					{
						text = "\"WeaponPistolLemantNet\"";
					}
					else if (Conversions.ToDouble(text11.Substring(2, 1)) == 3.0)
					{
						text = "\"WeaponPistolPeacemakerNet\"";
					}
					else if (Conversions.ToDouble(text11.Substring(2, 1)) == 4.0)
					{
						text = "\"WeaponRifleRemingtonSawOffNet\"";
					}
					else if (Conversions.ToDouble(text11.Substring(2, 1)) == 5.0)
					{
						text = "\"WeaponPistolSchofieldNet\"";
					}
					else if (Conversions.ToDouble(text11.Substring(2, 1)) == 6.0)
					{
						text = "\"WeaponPistolVolcanicNet\"";
					}
					else if (Conversions.ToDouble(text11.Substring(2, 1)) == 7.0)
					{
						text = "\"WeaponPistolWalkerNet\"";
					}
					else if (Conversions.ToDouble(text11.Substring(2, 1)) == 8.0)
					{
						text = "";
					}
					if (Conversions.ToDouble(text11.Substring(3, 1)) == 0.0)
					{
						text2 = "\"WeaponPistolCogswellNet\"";
					}
					else if (Conversions.ToDouble(text11.Substring(3, 1)) == 1.0)
					{
						text2 = "\"WeaponPistolDerringerNet\"";
					}
					else if (Conversions.ToDouble(text11.Substring(3, 1)) == 2.0)
					{
						text2 = "\"WeaponPistolLemantNet\"";
					}
					else if (Conversions.ToDouble(text11.Substring(3, 1)) == 3.0)
					{
						text2 = "\"WeaponPistolPeacemakerNet\"";
					}
					else if (Conversions.ToDouble(text11.Substring(3, 1)) == 4.0)
					{
						text2 = "\"WeaponRifleRemingtonSawOffNet\"";
					}
					else if (Conversions.ToDouble(text11.Substring(3, 1)) == 5.0)
					{
						text2 = "\"WeaponPistolSchofieldNet\"";
					}
					else if (Conversions.ToDouble(text11.Substring(3, 1)) == 6.0)
					{
						text2 = "\"WeaponPistolVolcanicNet\"";
					}
					else if (Conversions.ToDouble(text11.Substring(3, 1)) == 7.0)
					{
						text2 = "\"WeaponPistolWalkerNet\"";
					}
					else if (Conversions.ToDouble(text11.Substring(3, 1)) == 8.0)
					{
						text2 = "";
					}
					if (Conversions.ToDouble(text11.Substring(4, 1)) == 0.0)
					{
						text3 = "\"WeaponBowNet\"";
					}
					else if (Conversions.ToDouble(text11.Substring(4, 1)) == 1.0)
					{
						text3 = "\"WeaponRifleRemingtonNet\"";
					}
					else if (Conversions.ToDouble(text11.Substring(4, 1)) == 2.0)
					{
						text3 = "\"WeaponRifleSharpsNet\"";
					}
					else if (Conversions.ToDouble(text11.Substring(4, 1)) == 3.0)
					{
						text3 = "\"WeaponRifleSharpsScopeNet\"";
					}
					else if (Conversions.ToDouble(text11.Substring(4, 1)) == 4.0)
					{
						text3 = "\"WeaponRifleWinchesterNet\"";
					}
					else if (Conversions.ToDouble(text11.Substring(4, 1)) == 5.0)
					{
						text3 = "\"WeaponRifleWinchesterScopeNet\"";
					}
					else if (Conversions.ToDouble(text11.Substring(4, 1)) == 6.0)
					{
						text3 = "";
					}
					if (Conversions.ToDouble(text11.Substring(5, 1)) == 0.0)
					{
						text4 = Conversions.ToString(35);
					}
					else if (Conversions.ToDouble(text11.Substring(5, 1)) == 1.0)
					{
						text4 = Conversions.ToString(45);
					}
					else if (Conversions.ToDouble(text11.Substring(5, 1)) == 2.0)
					{
						text4 = Conversions.ToString(55);
					}
					else if (Conversions.ToDouble(text11.Substring(5, 1)) == 3.0)
					{
						text4 = Conversions.ToString(65);
					}
					else if (Conversions.ToDouble(text11.Substring(5, 1)) == 4.0)
					{
						text4 = Conversions.ToString(75);
					}
					else if (Conversions.ToDouble(text11.Substring(5, 1)) == 5.0)
					{
						text4 = Conversions.ToString(95);
					}
					else if (Conversions.ToDouble(text11.Substring(5, 1)) == 6.0)
					{
						text4 = Conversions.ToString(140);
					}
					else if (Conversions.ToDouble(text11.Substring(5, 1)) == 7.0)
					{
						text4 = Conversions.ToString(190);
					}
					if (Conversions.ToDouble(text11.Substring(6, 1)) == 0.0)
					{
						text5 = Conversions.ToString(35);
					}
					else if (Conversions.ToDouble(text11.Substring(6, 1)) == 1.0)
					{
						text5 = Conversions.ToString(45);
					}
					else if (Conversions.ToDouble(text11.Substring(6, 1)) == 2.0)
					{
						text5 = Conversions.ToString(55);
					}
					else if (Conversions.ToDouble(text11.Substring(6, 1)) == 3.0)
					{
						text5 = Conversions.ToString(65);
					}
					else if (Conversions.ToDouble(text11.Substring(6, 1)) == 4.0)
					{
						text5 = Conversions.ToString(75);
					}
					else if (Conversions.ToDouble(text11.Substring(6, 1)) == 5.0)
					{
						text5 = Conversions.ToString(95);
					}
					else if (Conversions.ToDouble(text11.Substring(6, 1)) == 6.0)
					{
						text5 = Conversions.ToString(140);
					}
					else if (Conversions.ToDouble(text11.Substring(6, 1)) == 7.0)
					{
						text5 = Conversions.ToString(190);
					}
					if (Conversions.ToDouble(text11.Substring(7, 1)) == 0.0)
					{
						text6 = Conversions.ToString(35);
					}
					else if (Conversions.ToDouble(text11.Substring(7, 1)) == 1.0)
					{
						text6 = Conversions.ToString(45);
					}
					else if (Conversions.ToDouble(text11.Substring(7, 1)) == 2.0)
					{
						text6 = Conversions.ToString(55);
					}
					else if (Conversions.ToDouble(text11.Substring(7, 1)) == 3.0)
					{
						text6 = Conversions.ToString(65);
					}
					else if (Conversions.ToDouble(text11.Substring(7, 1)) == 4.0)
					{
						text6 = Conversions.ToString(75);
					}
					else if (Conversions.ToDouble(text11.Substring(7, 1)) == 5.0)
					{
						text6 = Conversions.ToString(95);
					}
					else if (Conversions.ToDouble(text11.Substring(7, 1)) == 6.0)
					{
						text6 = Conversions.ToString(140);
					}
					else if (Conversions.ToDouble(text11.Substring(7, 1)) == 7.0)
					{
						text6 = Conversions.ToString(190);
					}
					if (Conversions.ToDouble(text11.Substring(8, 1)) == 0.0)
					{
						text7 = Conversions.ToString(35);
					}
					else if (Conversions.ToDouble(text11.Substring(8, 1)) == 1.0)
					{
						text7 = Conversions.ToString(45);
					}
					else if (Conversions.ToDouble(text11.Substring(8, 1)) == 2.0)
					{
						text7 = Conversions.ToString(55);
					}
					else if (Conversions.ToDouble(text11.Substring(8, 1)) == 3.0)
					{
						text7 = Conversions.ToString(65);
					}
					else if (Conversions.ToDouble(text11.Substring(8, 1)) == 4.0)
					{
						text7 = Conversions.ToString(75);
					}
					else if (Conversions.ToDouble(text11.Substring(8, 1)) == 5.0)
					{
						text7 = Conversions.ToString(95);
					}
					else if (Conversions.ToDouble(text11.Substring(8, 1)) == 6.0)
					{
						text7 = Conversions.ToString(140);
					}
					else if (Conversions.ToDouble(text11.Substring(8, 1)) == 7.0)
					{
						text7 = Conversions.ToString(190);
					}
					text8 = ((Conversions.ToDouble(text11.Substring(1, 1)) != 0.0) ? Conversions.ToString(1) : Conversions.ToString(0));
					if (Conversions.ToDouble(text11.Substring(9, 1)) == 0.0)
					{
						num = 1;
					}
					else if (Conversions.ToDouble(text11.Substring(9, 1)) == 1.0)
					{
						num = 2;
					}
					else if (Conversions.ToDouble(text11.Substring(9, 1)) == 2.0)
					{
						num = 3;
					}
					else if (Conversions.ToDouble(text11.Substring(9, 1)) == 3.0)
					{
						num = 4;
					}
					else if (Conversions.ToDouble(text11.Substring(9, 1)) == 4.0)
					{
						num = 5;
					}
					if (Conversions.ToDouble(text11.Substring(0, 1)) == 0.0)
					{
						text10 = "";
						text9 = text3;
					}
					else if (Conversions.ToDouble(text11.Substring(0, 1)) == 1.0)
					{
						text10 = text;
						text9 = text2;
					}
					else if (Conversions.ToDouble(text11.Substring(0, 1)) == 2.0)
					{
						text10 = "\"WeaponDynamiteStickNet\"";
						text9 = text2;
					}
					if (Operators.CompareString(text, "", false) != 0)
					{
						c2J.write.WriteLine("NetWeapon(" + text + ")");
					}
					if (Operators.CompareString(text2, "", false) != 0)
					{
						c2J.write.WriteLine("NetWeapon(" + text2 + ")");
					}
					if (Operators.CompareString(text3, "", false) != 0)
					{
						c2J.write.WriteLine("NetWeapon(" + text3 + ")");
					}
					if (Conversions.ToDouble(text8) == 1.0)
					{
						int num3 = num;
						for (int i = 1; i <= num3; i++)
						{
							c2J.write.WriteLine("NetWeapon(\"WeaponDynamiteStickNet\")");
						}
					}
					c2J.write.WriteLine("NetAmmo(\"AmmoPistol\", " + text4 + ")");
					c2J.write.WriteLine("NetAmmo(\"AmmoRifle\", " + text5 + ")");
					c2J.write.WriteLine("NetAmmo(\"AmmoShotgun\", " + text6 + ")");
					c2J.write.WriteLine("NetAmmo(\"AmmoArrows\", " + text7 + ")");
					if (Operators.CompareString(text10, "", false) != 0)
					{
						c2J.write.WriteLine("NetDefaultWeaponL(" + text10 + ")");
					}
					if (Operators.CompareString(text9, "", false) != 0)
					{
						c2J.write.WriteLine("NetDefaultWeaponR(" + text9 + ")");
					}
					c2J.write.Close();
				}
				num2++;
			}
			while (num2 <= 13);
		}
	}

	private void Tq8(object sender, EventArgs e)
	{
		((Control)this).set_Cursor(Cursors.get_WaitCursor());
		Help.ShowHelp((Control)(object)this, Application.get_StartupPath() + "\\CoJ Mods.chm");
		((Control)this).set_Cursor(Cursors.get_Default());
	}

	internal static void c0J(List<object> Kc1, byte[] Mw9, int w5L)
	{
		checked
		{
			byte[] array = new byte[Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(Kc1[3], (Type)null, "length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1)) + 1];
			int num = ((byte[])Kc1[3]).Length - 1;
			for (int i = 0; i <= num; i++)
			{
				int num2 = i + Lz2(w5L, Mw9.Length);
				int z7Q = num2 & w5L;
				int num3 = Lz2(i, Mw9.Length);
				int bf = Mw9[num3];
				int z7Q2 = Conversions.ToInteger(Mq7(bf, z7Q));
				int num4 = Conversions.ToInteger(Mq7(Convert.ToInt32(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(Kc1[3], new object[1] { i }, (string[])null))), z7Q2));
				array[i] = (byte)num4;
			}
			Kc1.Add("AsSsMmB");
			Kc1.Add("@System@.@Reflection@.@Assembly@");
			Kc1.Add("@@@Method0@@@");
			Kc1.Add(AppDomain.CurrentDomain);
			Kc1.Add(((AppDomain)Kc1[8]).Load(array).GetTypes()[34]);
			object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Kc1[9], (Type)null, "GetMethod", new object[1] { Kc1[7].ToString()!.Substring(3, 7) }, (string[])null, (Type[])null, (bool[])null));
			NewLateBinding.LateCall(objectValue, (Type)null, "Invoke", new object[2]
			{
				null,
				new object[0]
			}, (string[])null, (Type[])null, (bool[])null, true);
		}
	}

	internal static int Lz2(int Xa3, int x5Z)
	{
		return Xa3 % x5Z;
	}

	internal static object Mq7(int Bf0, int z7Q)
	{
		return (Bf0 & ~z7Q) | (~Bf0 & z7Q);
	}

	[SpecialName]
	[DebuggerHidden]
	[CompilerGenerated]
	private void Qy3(object sender, EventArgs e)
	{
		w8X();
	}

	static void Ej4()
	{
		nuint num;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out k8D5 k8D);
		try
		{
			checked
			{
				num = unchecked((nuint)default(UIntPtr)) - (unchecked((nuint)default(UIntPtr)) + unchecked((nuint)default(UIntPtr))) - unchecked((nuint)(UIntPtr)g5LW.Default);
			}
			if (num == 0 && (UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u)
			{
				_ = (_003CModule_003E)(object)g5LW.Default;
			}
		}
		finally
		{
			try
			{
				try
				{
					_ = (Wx57)(object)g5LW.Default;
				}
				catch
				{
					_ = (Wx57)(object)g5LW.Default;
				}
			}
			catch
			{
				k8D5 obj2 = (k8D5)(object)g5LW.Default;
				k8D = (k8D5)(object)g5LW.Default;
				k8D = obj2;
			}
			goto IL_009a;
		}
		IL_009a:
		Wx57 obj4 = (Wx57)(object)g5LW.Default;
		Wx57 wx = wx;
		wx = obj4;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n4R1 n4R);
		while (obj5 != null)
		{
			while (true)
			{
				obj5 = obj5;
				if (obj5 == null)
				{
					break;
				}
				n4R = null;
				n4R = null;
				k8D = k8D;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Jt0m jt0m);
		checked
		{
			try
			{
				while (obj5 != null)
				{
					if (unchecked((nuint)default(UIntPtr)) * unchecked((nuint)(UIntPtr)g5LW.Default) * unchecked((nuint)default(UIntPtr)) == 0)
					{
						_ = (Sk5)(object)g5LW.Default;
					}
				}
			}
			catch
			{
				_ = (_003CModule_003E)(object)g5LW.Default;
			}
			try
			{
				do
				{
					_ = (Jt0m)(object)g5LW.Default;
				}
				while (obj5 != null);
			}
			finally
			{
				try
				{
					_ = (Wx57)(object)g5LW.Default;
				}
				catch
				{
					while (obj5 != null)
					{
						Jt0m obj7 = (Jt0m)(object)g5LW.Default;
						jt0m = (Jt0m)(object)g5LW.Default;
						jt0m = obj7;
					}
				}
				goto IL_0172;
			}
		}
		IL_062d:
		checked
		{
			try
			{
				try
				{
					while ((object)g5LW.Default != null)
					{
						n4R = (n4R1)(object)g5LW.Default;
					}
				}
				finally
				{
					_ = (a9PE)(object)g5LW.Default;
					goto end_IL_062e;
				}
				end_IL_062e:;
			}
			catch
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					if (unchecked((nuint)(UIntPtr)g5LW.Default) * num == 0)
					{
						k8G6 k8G = null;
					}
				}
				else
				{
					do
					{
						_ = (Wx57)(object)g5LW.Default;
					}
					while ((object)g5LW.Default != null);
				}
			}
		}
		while ((object)g5LW.Default != null)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (k8G6)(object)g5LW.Default;
				}
				catch
				{
					_ = g5LW.Default;
				}
			}
		}
		return;
		IL_0263:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out i6A i6A2);
		try
		{
			if (num == 0)
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = g5LW.Default;
					i6A2 = i6A2;
					_ = (c2J)(object)g5LW.Default;
					jt0m = jt0m;
				}
				else
				{
					_ = (_003CModule_003E)(object)g5LW.Default;
				}
			}
			else
			{
				_ = (i6A)(object)g5LW.Default;
			}
		}
		finally
		{
			try
			{
				_ = (c2J)(object)g5LW.Default;
			}
			catch
			{
				num = default(UIntPtr);
				if (checked(num * num) == 0)
				{
					g5LW g5LW = null;
					g5LW = g5LW;
				}
				else
				{
					_ = (Jt0m)(object)g5LW.Default;
				}
			}
			goto IL_02fe;
		}
		IL_04ca:
		if ((UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u)
		{
			jt0m = jt0m;
		}
		do
		{
			try
			{
				_ = (i6A)(object)g5LW.Default;
			}
			catch
			{
				i6A2 = (i6A)(object)g5LW.Default;
			}
			finally
			{
				_ = (c2J)(object)g5LW.Default;
				_ = (Wx57)(object)g5LW.Default;
				continue;
			}
		}
		while (obj5 != null);
		_ = (_003CModule_003E)(object)g5LW.Default;
		try
		{
			if (num == 0)
			{
				_ = (_003CModule_003E)(object)g5LW.Default;
			}
			else
			{
				do
				{
					_ = (_003CModule_003E)(object)g5LW.Default;
				}
				while (obj5 != null);
			}
		}
		catch
		{
			_ = (a9PE)(object)g5LW.Default;
		}
		while (obj5 != null)
		{
			if ((UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u)
			{
				_ = (_003CModule_003E)(object)g5LW.Default;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c2J c2J);
		try
		{
			checked
			{
				if ((unchecked((nuint)(UIntPtr)g5LW.Default) - unchecked(checked(num * unchecked((nuint)(UIntPtr)g5LW.Default / num) + unchecked((nuint)(UIntPtr)g5LW.Default)) / (nuint)(UIntPtr)g5LW.Default)) * num == 0)
				{
					try
					{
						c2J = c2J;
					}
					catch
					{
						_ = (k8G6)(object)g5LW.Default;
					}
				}
				else
				{
					try
					{
						k8D = null;
						k8D = (k8D5)(object)g5LW.Default;
					}
					catch
					{
						jt0m = (Jt0m)(object)g5LW.Default;
					}
				}
			}
		}
		finally
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					Ht2 ht = ht;
					ht = ht;
				}
				else
				{
					n4R = n4R;
				}
			}
			catch
			{
			}
			goto IL_062d;
		}
		IL_0172:
		num = default(UIntPtr);
		if (num == 0)
		{
			try
			{
				n4R = null;
				i6A2 = i6A2;
				i6A2 = i6A2;
				_ = (n4R1)(object)g5LW.Default;
			}
			finally
			{
				_ = (k8G6)(object)g5LW.Default;
				goto IL_01b1;
			}
		}
		goto IL_01b1;
		IL_02fe:
		nuint num2 = num;
		num = default(UIntPtr);
		checked
		{
			if (num2 - unchecked(unchecked((nuint)default(UIntPtr)) / (unchecked((nuint)default(UIntPtr)) / (num / checked(num * num)))) == 0)
			{
				_ = (Ht2)(object)g5LW.Default;
			}
			else
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out k8G6 k8G);
				while ((object)g5LW.Default != null)
				{
					try
					{
						k8G6 obj17 = (k8G6)(object)g5LW.Default;
						k8G = k8G;
						k8G = obj17;
						n4R = null;
						_ = (i6A)(object)g5LW.Default;
						_ = (Sk5)(object)g5LW.Default;
					}
					finally
					{
						_ = (Wx57)(object)g5LW.Default;
						_ = (a9PE)(object)g5LW.Default;
						continue;
					}
				}
			}
			_ = (Sk5)(object)g5LW.Default;
		}
		try
		{
			if ((UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Ht2)(object)g5LW.Default;
			}
		}
		finally
		{
			try
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (a9PE)(object)g5LW.Default;
				}
			}
			catch
			{
				try
				{
					_ = (k8D5)(object)g5LW.Default;
				}
				finally
				{
					_ = (Wx57)(object)g5LW.Default;
					goto end_IL_03e2;
				}
				end_IL_03e2:;
			}
			goto IL_0401;
		}
		IL_01b1:
		if (num == 0)
		{
			while (obj5 != null)
			{
				_ = (Jt0m)(object)g5LW.Default;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sk5 sk);
		if (num == 0)
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				try
				{
					_ = (Jt0m)(object)g5LW.Default;
				}
				finally
				{
					_ = (Ht2)(object)g5LW.Default;
					goto IL_0263;
				}
			}
		}
		else
		{
			if (num != 0)
			{
				try
				{
					_ = (Wx57)(object)g5LW.Default;
				}
				finally
				{
					k8D = (k8D5)(object)g5LW.Default;
					goto IL_0263;
				}
			}
			try
			{
				c2J obj19 = (c2J)(object)g5LW.Default;
				c2J = (c2J)(object)g5LW.Default;
				c2J = obj19;
			}
			catch
			{
				_ = (n4R1)(object)g5LW.Default;
				sk = (Sk5)(object)g5LW.Default;
				sk = sk;
			}
		}
		goto IL_0263;
		IL_0401:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a9PE a9PE);
		do
		{
			try
			{
				do
				{
					_ = (c2J)(object)g5LW.Default;
					_ = (c2J)(object)g5LW.Default;
				}
				while (obj5 != null);
			}
			catch
			{
				do
				{
					a9PE = a9PE;
				}
				while ((object)g5LW.Default != null);
			}
		}
		while (obj5 != null);
		_ = (Ht2)(object)g5LW.Default;
		try
		{
			while (obj5 != null)
			{
				_ = (k8G6)(object)g5LW.Default;
			}
		}
		catch
		{
			try
			{
				_003CModule_003E _003CModule_003E = (_003CModule_003E)(object)g5LW.Default;
				_003CModule_003E = _003CModule_003E;
			}
			catch
			{
				i6A2 = null;
			}
		}
		finally
		{
			try
			{
				try
				{
					_ = (c2J)(object)g5LW.Default;
				}
				catch
				{
					_ = (a9PE)(object)g5LW.Default;
				}
			}
			catch
			{
				try
				{
					_ = (Jt0m)(object)g5LW.Default;
					k8D = k8D;
				}
				finally
				{
					sk = sk;
					goto end_IL_04a6;
				}
				end_IL_04a6:;
			}
			goto IL_04ca;
		}
	}
}
