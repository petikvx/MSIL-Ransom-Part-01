using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Ha03;
using Kw6;
using Microsoft.VisualBasic.CompilerServices;
using Pp74;
using Wo0y;
using Wo29;
using Xi7s;
using b1T3;
using d2G3;
using i1H7;
using y6N2;

namespace z2FR;

[DesignerGenerated]
public class s2ZW : Form
{
	private IContainer components;

	private int ClaseEnCreacion;

	internal virtual PictureBox pictureAristocrat
	{
		[CompilerGenerated]
		get
		{
			return _pictureAristocrat;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Ee1;
			EventHandler eventHandler2 = Lr3;
			PictureBox val = _pictureAristocrat;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
				((Control)val).remove_DoubleClick(eventHandler2);
			}
			_pictureAristocrat = value;
			val = _pictureAristocrat;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
				((Control)val).add_DoubleClick(eventHandler2);
			}
		}
	}

	internal virtual Label lblAristocrat
	{
		[CompilerGenerated]
		get
		{
			return _lblAristocrat;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Ee1;
			Label val = _lblAristocrat;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_lblAristocrat = value;
			val = _lblAristocrat;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual Label lblBandit
	{
		[CompilerGenerated]
		get
		{
			return _lblBandit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Px5;
			Label val = _lblBandit;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_lblBandit = value;
			val = _lblBandit;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual PictureBox pictureBandit
	{
		[CompilerGenerated]
		get
		{
			return _pictureBandit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Px5;
			EventHandler eventHandler2 = Lr3;
			PictureBox val = _pictureBandit;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
				((Control)val).remove_DoubleClick(eventHandler2);
			}
			_pictureBandit = value;
			val = _pictureBandit;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
				((Control)val).add_DoubleClick(eventHandler2);
			}
		}
	}

	internal virtual Label lblBarnsby
	{
		[CompilerGenerated]
		get
		{
			return _lblBarnsby;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Tw4;
			Label val = _lblBarnsby;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_lblBarnsby = value;
			val = _lblBarnsby;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual PictureBox pictureBarnsby
	{
		[CompilerGenerated]
		get
		{
			return _pictureBarnsby;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Tw4;
			EventHandler eventHandler2 = Lr3;
			PictureBox val = _pictureBarnsby;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
				((Control)val).remove_DoubleClick(eventHandler2);
			}
			_pictureBarnsby = value;
			val = _pictureBarnsby;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
				((Control)val).add_DoubleClick(eventHandler2);
			}
		}
	}

	internal virtual Label lblDoc
	{
		[CompilerGenerated]
		get
		{
			return _lblDoc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Ka3;
			Label val = _lblDoc;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_lblDoc = value;
			val = _lblDoc;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual PictureBox pictureDoc
	{
		[CompilerGenerated]
		get
		{
			return _pictureDoc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Ka3;
			EventHandler eventHandler2 = Lr3;
			PictureBox val = _pictureDoc;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
				((Control)val).remove_DoubleClick(eventHandler2);
			}
			_pictureDoc = value;
			val = _pictureDoc;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
				((Control)val).add_DoubleClick(eventHandler2);
			}
		}
	}

	internal virtual Label lblRifleman
	{
		[CompilerGenerated]
		get
		{
			return _lblRifleman;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = m1R;
			Label val = _lblRifleman;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_lblRifleman = value;
			val = _lblRifleman;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual PictureBox pictureRifleman
	{
		[CompilerGenerated]
		get
		{
			return _pictureRifleman;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = m1R;
			EventHandler eventHandler2 = Lr3;
			PictureBox val = _pictureRifleman;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
				((Control)val).remove_DoubleClick(eventHandler2);
			}
			_pictureRifleman = value;
			val = _pictureRifleman;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
				((Control)val).add_DoubleClick(eventHandler2);
			}
		}
	}

	internal virtual Label lblMiner
	{
		[CompilerGenerated]
		get
		{
			return _lblMiner;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Wg2;
			Label val = _lblMiner;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_lblMiner = value;
			val = _lblMiner;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual PictureBox pictureMiner
	{
		[CompilerGenerated]
		get
		{
			return _pictureMiner;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Wg2;
			EventHandler eventHandler2 = Lr3;
			PictureBox val = _pictureMiner;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
				((Control)val).remove_DoubleClick(eventHandler2);
			}
			_pictureMiner = value;
			val = _pictureMiner;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
				((Control)val).add_DoubleClick(eventHandler2);
			}
		}
	}

	internal virtual Label lblJuarez
	{
		[CompilerGenerated]
		get
		{
			return _lblJuarez;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = k8J;
			Label val = _lblJuarez;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_lblJuarez = value;
			val = _lblJuarez;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual PictureBox pictureJuarez
	{
		[CompilerGenerated]
		get
		{
			return _pictureJuarez;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = k8J;
			EventHandler eventHandler2 = Lr3;
			PictureBox val = _pictureJuarez;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
				((Control)val).remove_DoubleClick(eventHandler2);
			}
			_pictureJuarez = value;
			val = _pictureJuarez;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
				((Control)val).add_DoubleClick(eventHandler2);
			}
		}
	}

	internal virtual Label lblGunsmith
	{
		[CompilerGenerated]
		get
		{
			return _lblGunsmith;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Qz6;
			Label val = _lblGunsmith;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_lblGunsmith = value;
			val = _lblGunsmith;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual PictureBox pictureGunsmith
	{
		[CompilerGenerated]
		get
		{
			return _pictureGunsmith;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Qz6;
			EventHandler eventHandler2 = Lr3;
			PictureBox val = _pictureGunsmith;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
				((Control)val).remove_DoubleClick(eventHandler2);
			}
			_pictureGunsmith = value;
			val = _pictureGunsmith;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
				((Control)val).add_DoubleClick(eventHandler2);
			}
		}
	}

	internal virtual Label lblSniper
	{
		[CompilerGenerated]
		get
		{
			return _lblSniper;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Ek7;
			Label val = _lblSniper;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_lblSniper = value;
			val = _lblSniper;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual PictureBox pictureSniper
	{
		[CompilerGenerated]
		get
		{
			return _pictureSniper;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Ek7;
			EventHandler eventHandler2 = Lr3;
			PictureBox val = _pictureSniper;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
				((Control)val).remove_DoubleClick(eventHandler2);
			}
			_pictureSniper = value;
			val = _pictureSniper;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
				((Control)val).add_DoubleClick(eventHandler2);
			}
		}
	}

	internal virtual Label lblGunslinger
	{
		[CompilerGenerated]
		get
		{
			return _lblGunslinger;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Xg7;
			Label val = _lblGunslinger;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_lblGunslinger = value;
			val = _lblGunslinger;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual PictureBox pictureGunslinger
	{
		[CompilerGenerated]
		get
		{
			return _pictureGunslinger;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Xg7;
			EventHandler eventHandler2 = Lr3;
			PictureBox val = _pictureGunslinger;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
				((Control)val).remove_DoubleClick(eventHandler2);
			}
			_pictureGunslinger = value;
			val = _pictureGunslinger;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
				((Control)val).add_DoubleClick(eventHandler2);
			}
		}
	}

	internal virtual Label lblTribeWarrior
	{
		[CompilerGenerated]
		get
		{
			return _lblTribeWarrior;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Dw9;
			Label val = _lblTribeWarrior;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_lblTribeWarrior = value;
			val = _lblTribeWarrior;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual PictureBox pictureTribeWarrior
	{
		[CompilerGenerated]
		get
		{
			return _pictureTribeWarrior;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Dw9;
			EventHandler eventHandler2 = Lr3;
			PictureBox val = _pictureTribeWarrior;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
				((Control)val).remove_DoubleClick(eventHandler2);
			}
			_pictureTribeWarrior = value;
			val = _pictureTribeWarrior;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
				((Control)val).add_DoubleClick(eventHandler2);
			}
		}
	}

	internal virtual Label lblTrapper
	{
		[CompilerGenerated]
		get
		{
			return _lblTrapper;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Gg9;
			Label val = _lblTrapper;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_lblTrapper = value;
			val = _lblTrapper;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual PictureBox pictureTrapper
	{
		[CompilerGenerated]
		get
		{
			return _pictureTrapper;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Gg9;
			EventHandler eventHandler2 = Lr3;
			PictureBox val = _pictureTrapper;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
				((Control)val).remove_DoubleClick(eventHandler2);
			}
			_pictureTrapper = value;
			val = _pictureTrapper;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
				((Control)val).add_DoubleClick(eventHandler2);
			}
		}
	}

	internal virtual Label lblThief
	{
		[CompilerGenerated]
		get
		{
			return _lblThief;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = b4D;
			Label val = _lblThief;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_lblThief = value;
			val = _lblThief;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual PictureBox pictureThief
	{
		[CompilerGenerated]
		get
		{
			return _pictureThief;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = b4D;
			EventHandler eventHandler2 = Lr3;
			PictureBox val = _pictureThief;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
				((Control)val).remove_DoubleClick(eventHandler2);
			}
			_pictureThief = value;
			val = _pictureThief;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
				((Control)val).add_DoubleClick(eventHandler2);
			}
		}
	}

	[field: AccessedThroughProperty("checkLoadDefault")]
	internal virtual CheckBox checkLoadDefault
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnAdd
	{
		[CompilerGenerated]
		get
		{
			return _btnAdd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Lr3;
			Button val = _btnAdd;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnAdd = value;
			val = _btnAdd;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button btnCancel
	{
		[CompilerGenerated]
		get
		{
			return _btnCancel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = p1M;
			Button val = _btnCancel;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnCancel = value;
			val = _btnCancel;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	public s2ZW()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		((Form)this).add_FormClosing(new FormClosingEventHandler(Rj7));
		ClaseEnCreacion = 0;
		x0Z6();
	}

	[DebuggerNonUserCode]
	protected override void Lk0s(bool s3KX)
	{
		try
		{
			if (s3KX && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(s3KX);
		}
	}

	[DebuggerStepThrough]
	private void x0Z6()
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
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected O, but got Unknown
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Expected O, but got Unknown
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03be: Expected O, but got Unknown
		//IL_04bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c7: Expected O, but got Unknown
		//IL_05c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d0: Expected O, but got Unknown
		//IL_06d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06dd: Expected O, but got Unknown
		//IL_07e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ee: Expected O, but got Unknown
		//IL_08f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ff: Expected O, but got Unknown
		//IL_0a03: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0d: Expected O, but got Unknown
		//IL_0b10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1a: Expected O, but got Unknown
		//IL_0c1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c28: Expected O, but got Unknown
		//IL_0d2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d36: Expected O, but got Unknown
		//IL_0e3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e47: Expected O, but got Unknown
		//IL_0f4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f55: Expected O, but got Unknown
		//IL_1342: Unknown result type (might be due to invalid IL or missing references)
		//IL_134c: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(s2ZW));
		pictureAristocrat = new PictureBox();
		lblAristocrat = new Label();
		lblBandit = new Label();
		pictureBandit = new PictureBox();
		lblBarnsby = new Label();
		pictureBarnsby = new PictureBox();
		lblDoc = new Label();
		pictureDoc = new PictureBox();
		lblRifleman = new Label();
		pictureRifleman = new PictureBox();
		lblMiner = new Label();
		pictureMiner = new PictureBox();
		lblJuarez = new Label();
		pictureJuarez = new PictureBox();
		lblGunsmith = new Label();
		pictureGunsmith = new PictureBox();
		lblSniper = new Label();
		pictureSniper = new PictureBox();
		lblGunslinger = new Label();
		pictureGunslinger = new PictureBox();
		lblTribeWarrior = new Label();
		pictureTribeWarrior = new PictureBox();
		lblTrapper = new Label();
		pictureTrapper = new PictureBox();
		lblThief = new Label();
		pictureThief = new PictureBox();
		checkLoadDefault = new CheckBox();
		btnAdd = new Button();
		btnCancel = new Button();
		((ISupportInitialize)pictureAristocrat).BeginInit();
		((ISupportInitialize)pictureBandit).BeginInit();
		((ISupportInitialize)pictureBarnsby).BeginInit();
		((ISupportInitialize)pictureDoc).BeginInit();
		((ISupportInitialize)pictureRifleman).BeginInit();
		((ISupportInitialize)pictureMiner).BeginInit();
		((ISupportInitialize)pictureJuarez).BeginInit();
		((ISupportInitialize)pictureGunsmith).BeginInit();
		((ISupportInitialize)pictureSniper).BeginInit();
		((ISupportInitialize)pictureGunslinger).BeginInit();
		((ISupportInitialize)pictureTribeWarrior).BeginInit();
		((ISupportInitialize)pictureTrapper).BeginInit();
		((ISupportInitialize)pictureThief).BeginInit();
		((Control)this).SuspendLayout();
		pictureAristocrat.set_BorderStyle((BorderStyle)1);
		((Control)pictureAristocrat).set_Cursor(Cursors.get_Hand());
		pictureAristocrat.set_Image((Image)componentResourceManager.GetObject("pictureAristocrat.Image"));
		((Control)pictureAristocrat).set_Location(new Point(34, 27));
		((Control)pictureAristocrat).set_Name("pictureAristocrat");
		((Control)pictureAristocrat).set_Size(new Size(101, 100));
		pictureAristocrat.set_SizeMode((PictureBoxSizeMode)4);
		pictureAristocrat.set_TabIndex(0);
		pictureAristocrat.set_TabStop(false);
		lblAristocrat.set_AutoSize(true);
		((Control)lblAristocrat).set_Cursor(Cursors.get_Hand());
		((Control)lblAristocrat).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblAristocrat).set_ForeColor(SystemColors.ControlText);
		((Control)lblAristocrat).set_Location(new Point(57, 127));
		((Control)lblAristocrat).set_Name("lblAristocrat");
		((Control)lblAristocrat).set_Size(new Size(51, 13));
		((Control)lblAristocrat).set_TabIndex(1);
		lblAristocrat.set_Text("Aristocrat");
		lblBandit.set_AutoSize(true);
		((Control)lblBandit).set_Cursor(Cursors.get_Hand());
		((Control)lblBandit).set_Location(new Point(196, 127));
		((Control)lblBandit).set_Name("lblBandit");
		((Control)lblBandit).set_Size(new Size(37, 13));
		((Control)lblBandit).set_TabIndex(3);
		lblBandit.set_Text("Bandit");
		pictureBandit.set_BorderStyle((BorderStyle)1);
		((Control)pictureBandit).set_Cursor(Cursors.get_Hand());
		pictureBandit.set_Image((Image)componentResourceManager.GetObject("pictureBandit.Image"));
		((Control)pictureBandit).set_Location(new Point(164, 27));
		((Control)pictureBandit).set_Name("pictureBandit");
		((Control)pictureBandit).set_Size(new Size(101, 100));
		pictureBandit.set_SizeMode((PictureBoxSizeMode)4);
		pictureBandit.set_TabIndex(2);
		pictureBandit.set_TabStop(false);
		lblBarnsby.set_AutoSize(true);
		((Control)lblBarnsby).set_Cursor(Cursors.get_Hand());
		((Control)lblBarnsby).set_Location(new Point(325, 127));
		((Control)lblBarnsby).set_Name("lblBarnsby");
		((Control)lblBarnsby).set_Size(new Size(45, 13));
		((Control)lblBarnsby).set_TabIndex(5);
		lblBarnsby.set_Text("Barnsby");
		pictureBarnsby.set_BorderStyle((BorderStyle)1);
		((Control)pictureBarnsby).set_Cursor(Cursors.get_Hand());
		pictureBarnsby.set_Image((Image)componentResourceManager.GetObject("pictureBarnsby.Image"));
		((Control)pictureBarnsby).set_Location(new Point(295, 27));
		((Control)pictureBarnsby).set_Name("pictureBarnsby");
		((Control)pictureBarnsby).set_Size(new Size(101, 100));
		pictureBarnsby.set_SizeMode((PictureBoxSizeMode)4);
		pictureBarnsby.set_TabIndex(4);
		pictureBarnsby.set_TabStop(false);
		lblDoc.set_AutoSize(true);
		((Control)lblDoc).set_Cursor(Cursors.get_Hand());
		((Control)lblDoc).set_Location(new Point(464, 127));
		((Control)lblDoc).set_Name("lblDoc");
		((Control)lblDoc).set_Size(new Size(27, 13));
		((Control)lblDoc).set_TabIndex(7);
		lblDoc.set_Text("Doc");
		pictureDoc.set_BorderStyle((BorderStyle)1);
		((Control)pictureDoc).set_Cursor(Cursors.get_Hand());
		pictureDoc.set_Image((Image)componentResourceManager.GetObject("pictureDoc.Image"));
		((Control)pictureDoc).set_Location(new Point(426, 27));
		((Control)pictureDoc).set_Name("pictureDoc");
		((Control)pictureDoc).set_Size(new Size(101, 100));
		pictureDoc.set_SizeMode((PictureBoxSizeMode)4);
		pictureDoc.set_TabIndex(6);
		pictureDoc.set_TabStop(false);
		lblRifleman.set_AutoSize(true);
		((Control)lblRifleman).set_Cursor(Cursors.get_Hand());
		((Control)lblRifleman).set_Location(new Point(454, 254));
		((Control)lblRifleman).set_Name("lblRifleman");
		((Control)lblRifleman).set_Size(new Size(48, 13));
		((Control)lblRifleman).set_TabIndex(15);
		lblRifleman.set_Text("Rifleman");
		pictureRifleman.set_BorderStyle((BorderStyle)1);
		((Control)pictureRifleman).set_Cursor(Cursors.get_Hand());
		pictureRifleman.set_Image((Image)componentResourceManager.GetObject("pictureRifleman.Image"));
		((Control)pictureRifleman).set_Location(new Point(426, 154));
		((Control)pictureRifleman).set_Name("pictureRifleman");
		((Control)pictureRifleman).set_Size(new Size(101, 100));
		pictureRifleman.set_SizeMode((PictureBoxSizeMode)4);
		pictureRifleman.set_TabIndex(14);
		pictureRifleman.set_TabStop(false);
		lblMiner.set_AutoSize(true);
		((Control)lblMiner).set_Cursor(Cursors.get_Hand());
		((Control)lblMiner).set_Location(new Point(329, 254));
		((Control)lblMiner).set_Name("lblMiner");
		((Control)lblMiner).set_Size(new Size(33, 13));
		((Control)lblMiner).set_TabIndex(13);
		lblMiner.set_Text("Miner");
		pictureMiner.set_BorderStyle((BorderStyle)1);
		((Control)pictureMiner).set_Cursor(Cursors.get_Hand());
		pictureMiner.set_Image((Image)componentResourceManager.GetObject("pictureMiner.Image"));
		((Control)pictureMiner).set_Location(new Point(295, 154));
		((Control)pictureMiner).set_Name("pictureMiner");
		((Control)pictureMiner).set_Size(new Size(101, 100));
		pictureMiner.set_SizeMode((PictureBoxSizeMode)4);
		pictureMiner.set_TabIndex(12);
		pictureMiner.set_TabStop(false);
		lblJuarez.set_AutoSize(true);
		((Control)lblJuarez).set_Cursor(Cursors.get_Hand());
		((Control)lblJuarez).set_Location(new Point(197, 254));
		((Control)lblJuarez).set_Name("lblJuarez");
		((Control)lblJuarez).set_Size(new Size(38, 13));
		((Control)lblJuarez).set_TabIndex(11);
		lblJuarez.set_Text("Juarez");
		pictureJuarez.set_BorderStyle((BorderStyle)1);
		((Control)pictureJuarez).set_Cursor(Cursors.get_Hand());
		pictureJuarez.set_Image((Image)componentResourceManager.GetObject("pictureJuarez.Image"));
		((Control)pictureJuarez).set_Location(new Point(164, 154));
		((Control)pictureJuarez).set_Name("pictureJuarez");
		((Control)pictureJuarez).set_Size(new Size(101, 100));
		pictureJuarez.set_SizeMode((PictureBoxSizeMode)4);
		pictureJuarez.set_TabIndex(10);
		pictureJuarez.set_TabStop(false);
		lblGunsmith.set_AutoSize(true);
		((Control)lblGunsmith).set_Cursor(Cursors.get_Hand());
		((Control)lblGunsmith).set_Location(new Point(60, 254));
		((Control)lblGunsmith).set_Name("lblGunsmith");
		((Control)lblGunsmith).set_Size(new Size(51, 13));
		((Control)lblGunsmith).set_TabIndex(9);
		lblGunsmith.set_Text("Gunsmith");
		pictureGunsmith.set_BorderStyle((BorderStyle)1);
		((Control)pictureGunsmith).set_Cursor(Cursors.get_Hand());
		pictureGunsmith.set_Image((Image)componentResourceManager.GetObject("pictureGunsmith.Image"));
		((Control)pictureGunsmith).set_Location(new Point(34, 154));
		((Control)pictureGunsmith).set_Name("pictureGunsmith");
		((Control)pictureGunsmith).set_Size(new Size(101, 100));
		pictureGunsmith.set_SizeMode((PictureBoxSizeMode)4);
		pictureGunsmith.set_TabIndex(8);
		pictureGunsmith.set_TabStop(false);
		lblSniper.set_AutoSize(true);
		((Control)lblSniper).set_Cursor(Cursors.get_Hand());
		((Control)lblSniper).set_Location(new Point(590, 254));
		((Control)lblSniper).set_Name("lblSniper");
		((Control)lblSniper).set_Size(new Size(37, 13));
		((Control)lblSniper).set_TabIndex(19);
		lblSniper.set_Text("Sniper");
		pictureSniper.set_BorderStyle((BorderStyle)1);
		((Control)pictureSniper).set_Cursor(Cursors.get_Hand());
		pictureSniper.set_Image((Image)componentResourceManager.GetObject("pictureSniper.Image"));
		((Control)pictureSniper).set_Location(new Point(557, 154));
		((Control)pictureSniper).set_Name("pictureSniper");
		((Control)pictureSniper).set_Size(new Size(101, 100));
		pictureSniper.set_SizeMode((PictureBoxSizeMode)4);
		pictureSniper.set_TabIndex(18);
		pictureSniper.set_TabStop(false);
		lblGunslinger.set_AutoSize(true);
		((Control)lblGunslinger).set_Cursor(Cursors.get_Hand());
		((Control)lblGunslinger).set_Location(new Point(580, 127));
		((Control)lblGunslinger).set_Name("lblGunslinger");
		((Control)lblGunslinger).set_Size(new Size(57, 13));
		((Control)lblGunslinger).set_TabIndex(17);
		lblGunslinger.set_Text("Gunslinger");
		pictureGunslinger.set_BorderStyle((BorderStyle)1);
		((Control)pictureGunslinger).set_Cursor(Cursors.get_Hand());
		pictureGunslinger.set_Image((Image)componentResourceManager.GetObject("pictureGunslinger.Image"));
		((Control)pictureGunslinger).set_Location(new Point(557, 27));
		((Control)pictureGunslinger).set_Name("pictureGunslinger");
		((Control)pictureGunslinger).set_Size(new Size(101, 100));
		pictureGunslinger.set_SizeMode((PictureBoxSizeMode)4);
		pictureGunslinger.set_TabIndex(16);
		pictureGunslinger.set_TabStop(false);
		lblTribeWarrior.set_AutoSize(true);
		((Control)lblTribeWarrior).set_Cursor(Cursors.get_Hand());
		((Control)lblTribeWarrior).set_Location(new Point(313, 383));
		((Control)lblTribeWarrior).set_Name("lblTribeWarrior");
		((Control)lblTribeWarrior).set_Size(new Size(68, 13));
		((Control)lblTribeWarrior).set_TabIndex(25);
		lblTribeWarrior.set_Text("Tribe Warrior");
		pictureTribeWarrior.set_BorderStyle((BorderStyle)1);
		((Control)pictureTribeWarrior).set_Cursor(Cursors.get_Hand());
		pictureTribeWarrior.set_Image((Image)componentResourceManager.GetObject("pictureTribeWarrior.Image"));
		((Control)pictureTribeWarrior).set_Location(new Point(295, 283));
		((Control)pictureTribeWarrior).set_Name("pictureTribeWarrior");
		((Control)pictureTribeWarrior).set_Size(new Size(101, 100));
		pictureTribeWarrior.set_SizeMode((PictureBoxSizeMode)4);
		pictureTribeWarrior.set_TabIndex(24);
		pictureTribeWarrior.set_TabStop(false);
		lblTrapper.set_AutoSize(true);
		((Control)lblTrapper).set_Cursor(Cursors.get_Hand());
		((Control)lblTrapper).set_Location(new Point(193, 383));
		((Control)lblTrapper).set_Name("lblTrapper");
		((Control)lblTrapper).set_Size(new Size(44, 13));
		((Control)lblTrapper).set_TabIndex(23);
		lblTrapper.set_Text("Trapper");
		pictureTrapper.set_BorderStyle((BorderStyle)1);
		((Control)pictureTrapper).set_Cursor(Cursors.get_Hand());
		pictureTrapper.set_Image((Image)componentResourceManager.GetObject("pictureTrapper.Image"));
		((Control)pictureTrapper).set_Location(new Point(164, 283));
		((Control)pictureTrapper).set_Name("pictureTrapper");
		((Control)pictureTrapper).set_Size(new Size(101, 100));
		pictureTrapper.set_SizeMode((PictureBoxSizeMode)4);
		pictureTrapper.set_TabIndex(22);
		pictureTrapper.set_TabStop(false);
		lblThief.set_AutoSize(true);
		((Control)lblThief).set_Cursor(Cursors.get_Hand());
		((Control)lblThief).set_Location(new Point(70, 383));
		((Control)lblThief).set_Name("lblThief");
		((Control)lblThief).set_Size(new Size(31, 13));
		((Control)lblThief).set_TabIndex(21);
		lblThief.set_Text("Thief");
		pictureThief.set_BorderStyle((BorderStyle)1);
		((Control)pictureThief).set_Cursor(Cursors.get_Hand());
		pictureThief.set_Image((Image)componentResourceManager.GetObject("pictureThief.Image"));
		((Control)pictureThief).set_Location(new Point(34, 283));
		((Control)pictureThief).set_Name("pictureThief");
		((Control)pictureThief).set_Size(new Size(101, 100));
		pictureThief.set_SizeMode((PictureBoxSizeMode)4);
		pictureThief.set_TabIndex(20);
		pictureThief.set_TabStop(false);
		((ButtonBase)checkLoadDefault).set_AutoSize(true);
		checkLoadDefault.set_Checked(true);
		checkLoadDefault.set_CheckState((CheckState)1);
		((Control)checkLoadDefault).set_Location(new Point(458, 331));
		((Control)checkLoadDefault).set_Name("checkLoadDefault");
		((Control)checkLoadDefault).set_Size(new Size(158, 17));
		((Control)checkLoadDefault).set_TabIndex(26);
		((ButtonBase)checkLoadDefault).set_Text("Load default class weapons");
		((ButtonBase)checkLoadDefault).set_UseVisualStyleBackColor(true);
		((Control)btnAdd).set_Location(new Point(566, 360));
		((Control)btnAdd).set_Name("btnAdd");
		((Control)btnAdd).set_Size(new Size(92, 23));
		((Control)btnAdd).set_TabIndex(27);
		((ButtonBase)btnAdd).set_Text("Add character");
		((ButtonBase)btnAdd).set_UseVisualStyleBackColor(true);
		((Control)btnCancel).set_Location(new Point(458, 360));
		((Control)btnCancel).set_Name("btnCancel");
		((Control)btnCancel).set_Size(new Size(75, 23));
		((Control)btnCancel).set_TabIndex(28);
		((ButtonBase)btnCancel).set_Text("Cancel");
		((ButtonBase)btnCancel).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(690, 409));
		((Control)this).get_Controls().Add((Control)(object)btnCancel);
		((Control)this).get_Controls().Add((Control)(object)btnAdd);
		((Control)this).get_Controls().Add((Control)(object)checkLoadDefault);
		((Control)this).get_Controls().Add((Control)(object)lblTribeWarrior);
		((Control)this).get_Controls().Add((Control)(object)pictureTribeWarrior);
		((Control)this).get_Controls().Add((Control)(object)lblTrapper);
		((Control)this).get_Controls().Add((Control)(object)pictureTrapper);
		((Control)this).get_Controls().Add((Control)(object)lblThief);
		((Control)this).get_Controls().Add((Control)(object)pictureThief);
		((Control)this).get_Controls().Add((Control)(object)lblSniper);
		((Control)this).get_Controls().Add((Control)(object)pictureSniper);
		((Control)this).get_Controls().Add((Control)(object)lblGunslinger);
		((Control)this).get_Controls().Add((Control)(object)pictureGunslinger);
		((Control)this).get_Controls().Add((Control)(object)lblRifleman);
		((Control)this).get_Controls().Add((Control)(object)pictureRifleman);
		((Control)this).get_Controls().Add((Control)(object)lblMiner);
		((Control)this).get_Controls().Add((Control)(object)pictureMiner);
		((Control)this).get_Controls().Add((Control)(object)lblJuarez);
		((Control)this).get_Controls().Add((Control)(object)pictureJuarez);
		((Control)this).get_Controls().Add((Control)(object)lblGunsmith);
		((Control)this).get_Controls().Add((Control)(object)pictureGunsmith);
		((Control)this).get_Controls().Add((Control)(object)lblDoc);
		((Control)this).get_Controls().Add((Control)(object)pictureDoc);
		((Control)this).get_Controls().Add((Control)(object)lblBarnsby);
		((Control)this).get_Controls().Add((Control)(object)pictureBarnsby);
		((Control)this).get_Controls().Add((Control)(object)lblBandit);
		((Control)this).get_Controls().Add((Control)(object)pictureBandit);
		((Control)this).get_Controls().Add((Control)(object)lblAristocrat);
		((Control)this).get_Controls().Add((Control)(object)pictureAristocrat);
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximumSize(new Size(706, 448));
		((Form)this).set_MinimumSize(new Size(706, 448));
		((Control)this).set_Name("frmClase");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Select character to make your new class");
		((ISupportInitialize)pictureAristocrat).EndInit();
		((ISupportInitialize)pictureBandit).EndInit();
		((ISupportInitialize)pictureBarnsby).EndInit();
		((ISupportInitialize)pictureDoc).EndInit();
		((ISupportInitialize)pictureRifleman).EndInit();
		((ISupportInitialize)pictureMiner).EndInit();
		((ISupportInitialize)pictureJuarez).EndInit();
		((ISupportInitialize)pictureGunsmith).EndInit();
		((ISupportInitialize)pictureSniper).EndInit();
		((ISupportInitialize)pictureGunslinger).EndInit();
		((ISupportInitialize)pictureTribeWarrior).EndInit();
		((ISupportInitialize)pictureTrapper).EndInit();
		((ISupportInitialize)pictureThief).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Ee1(object sender, EventArgs e)
	{
		ClaseEnCreacion = 0;
		pictureAristocrat.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Selecc_Aristocrat.jpg");
		pictureBandit.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Bandit.jpg");
		pictureBarnsby.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Barnsby.jpg");
		pictureDoc.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Doc.jpg");
		pictureGunslinger.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Gunslinger.jpg");
		pictureGunsmith.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Gunsmith.jpg");
		pictureJuarez.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Juarez.jpg");
		pictureMiner.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Miner.jpg");
		pictureRifleman.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Rifleman.jpg");
		pictureSniper.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Sniper.jpg");
		pictureThief.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Thief.jpg");
		pictureTrapper.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Trapper.jpg");
		pictureTribeWarrior.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Tribe Warrior.jpg");
	}

	private void Px5(object sender, EventArgs e)
	{
		ClaseEnCreacion = 1;
		pictureAristocrat.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Aristocrat.jpg");
		pictureBandit.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Selecc_Bandit.jpg");
		pictureBarnsby.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Barnsby.jpg");
		pictureDoc.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Doc.jpg");
		pictureGunslinger.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Gunslinger.jpg");
		pictureGunsmith.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Gunsmith.jpg");
		pictureJuarez.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Juarez.jpg");
		pictureMiner.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Miner.jpg");
		pictureRifleman.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Rifleman.jpg");
		pictureSniper.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Sniper.jpg");
		pictureThief.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Thief.jpg");
		pictureTrapper.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Trapper.jpg");
		pictureTribeWarrior.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Tribe Warrior.jpg");
	}

	private void Tw4(object sender, EventArgs e)
	{
		ClaseEnCreacion = 2;
		pictureAristocrat.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Aristocrat.jpg");
		pictureBandit.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Bandit.jpg");
		pictureBarnsby.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Selecc_Barnsby.jpg");
		pictureDoc.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Doc.jpg");
		pictureGunslinger.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Gunslinger.jpg");
		pictureGunsmith.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Gunsmith.jpg");
		pictureJuarez.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Juarez.jpg");
		pictureMiner.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Miner.jpg");
		pictureRifleman.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Rifleman.jpg");
		pictureSniper.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Sniper.jpg");
		pictureThief.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Thief.jpg");
		pictureTrapper.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Trapper.jpg");
		pictureTribeWarrior.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Tribe Warrior.jpg");
	}

	private void Ka3(object sender, EventArgs e)
	{
		ClaseEnCreacion = 3;
		pictureAristocrat.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Aristocrat.jpg");
		pictureBandit.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Bandit.jpg");
		pictureBarnsby.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Barnsby.jpg");
		pictureDoc.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Selecc_Doc.jpg");
		pictureGunslinger.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Gunslinger.jpg");
		pictureGunsmith.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Gunsmith.jpg");
		pictureJuarez.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Juarez.jpg");
		pictureMiner.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Miner.jpg");
		pictureRifleman.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Rifleman.jpg");
		pictureSniper.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Sniper.jpg");
		pictureThief.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Thief.jpg");
		pictureTrapper.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Trapper.jpg");
		pictureTribeWarrior.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Tribe Warrior.jpg");
	}

	private void Xg7(object sender, EventArgs e)
	{
		ClaseEnCreacion = 4;
		pictureAristocrat.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Aristocrat.jpg");
		pictureBandit.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Bandit.jpg");
		pictureBarnsby.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Barnsby.jpg");
		pictureDoc.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Doc.jpg");
		pictureGunslinger.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Selecc_Gunslinger.jpg");
		pictureGunsmith.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Gunsmith.jpg");
		pictureJuarez.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Juarez.jpg");
		pictureMiner.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Miner.jpg");
		pictureRifleman.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Rifleman.jpg");
		pictureSniper.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Sniper.jpg");
		pictureThief.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Thief.jpg");
		pictureTrapper.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Trapper.jpg");
		pictureTribeWarrior.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Tribe Warrior.jpg");
	}

	private void Qz6(object sender, EventArgs e)
	{
		ClaseEnCreacion = 5;
		pictureAristocrat.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Aristocrat.jpg");
		pictureBandit.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Bandit.jpg");
		pictureBarnsby.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Barnsby.jpg");
		pictureDoc.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Doc.jpg");
		pictureGunslinger.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Gunslinger.jpg");
		pictureGunsmith.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Selecc_Gunsmith.jpg");
		pictureJuarez.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Juarez.jpg");
		pictureMiner.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Miner.jpg");
		pictureRifleman.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Rifleman.jpg");
		pictureSniper.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Sniper.jpg");
		pictureThief.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Thief.jpg");
		pictureTrapper.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Trapper.jpg");
		pictureTribeWarrior.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Tribe Warrior.jpg");
	}

	private void k8J(object sender, EventArgs e)
	{
		ClaseEnCreacion = 6;
		pictureAristocrat.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Aristocrat.jpg");
		pictureBandit.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Bandit.jpg");
		pictureBarnsby.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Barnsby.jpg");
		pictureDoc.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Doc.jpg");
		pictureGunslinger.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Gunslinger.jpg");
		pictureGunsmith.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Gunsmith.jpg");
		pictureJuarez.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Selecc_Juarez.jpg");
		pictureMiner.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Miner.jpg");
		pictureRifleman.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Rifleman.jpg");
		pictureSniper.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Sniper.jpg");
		pictureThief.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Thief.jpg");
		pictureTrapper.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Trapper.jpg");
		pictureTribeWarrior.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Tribe Warrior.jpg");
	}

	private void Wg2(object sender, EventArgs e)
	{
		ClaseEnCreacion = 7;
		pictureAristocrat.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Aristocrat.jpg");
		pictureBandit.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Bandit.jpg");
		pictureBarnsby.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Barnsby.jpg");
		pictureDoc.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Doc.jpg");
		pictureGunslinger.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Gunslinger.jpg");
		pictureGunsmith.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Gunsmith.jpg");
		pictureJuarez.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Juarez.jpg");
		pictureMiner.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Selecc_Miner.jpg");
		pictureRifleman.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Rifleman.jpg");
		pictureSniper.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Sniper.jpg");
		pictureThief.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Thief.jpg");
		pictureTrapper.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Trapper.jpg");
		pictureTribeWarrior.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Tribe Warrior.jpg");
	}

	private void m1R(object sender, EventArgs e)
	{
		ClaseEnCreacion = 8;
		pictureAristocrat.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Aristocrat.jpg");
		pictureBandit.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Bandit.jpg");
		pictureBarnsby.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Barnsby.jpg");
		pictureDoc.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Doc.jpg");
		pictureGunslinger.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Gunslinger.jpg");
		pictureGunsmith.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Gunsmith.jpg");
		pictureJuarez.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Juarez.jpg");
		pictureMiner.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Miner.jpg");
		pictureRifleman.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Selecc_Rifleman.jpg");
		pictureSniper.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Sniper.jpg");
		pictureThief.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Thief.jpg");
		pictureTrapper.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Trapper.jpg");
		pictureTribeWarrior.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Tribe Warrior.jpg");
	}

	private void Ek7(object sender, EventArgs e)
	{
		ClaseEnCreacion = 9;
		pictureAristocrat.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Aristocrat.jpg");
		pictureBandit.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Bandit.jpg");
		pictureBarnsby.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Barnsby.jpg");
		pictureDoc.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Doc.jpg");
		pictureGunslinger.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Gunslinger.jpg");
		pictureGunsmith.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Gunsmith.jpg");
		pictureJuarez.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Juarez.jpg");
		pictureMiner.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Miner.jpg");
		pictureRifleman.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Rifleman.jpg");
		pictureSniper.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Selecc_Sniper.jpg");
		pictureThief.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Thief.jpg");
		pictureTrapper.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Trapper.jpg");
		pictureTribeWarrior.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Tribe Warrior.jpg");
	}

	private void b4D(object sender, EventArgs e)
	{
		ClaseEnCreacion = 10;
		pictureAristocrat.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Aristocrat.jpg");
		pictureBandit.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Bandit.jpg");
		pictureBarnsby.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Barnsby.jpg");
		pictureDoc.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Doc.jpg");
		pictureGunslinger.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Gunslinger.jpg");
		pictureGunsmith.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Gunsmith.jpg");
		pictureJuarez.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Juarez.jpg");
		pictureMiner.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Miner.jpg");
		pictureRifleman.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Rifleman.jpg");
		pictureSniper.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Sniper.jpg");
		pictureThief.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Selecc_Thief.jpg");
		pictureTrapper.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Trapper.jpg");
		pictureTribeWarrior.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Tribe Warrior.jpg");
	}

	private void Gg9(object sender, EventArgs e)
	{
		ClaseEnCreacion = 11;
		pictureAristocrat.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Aristocrat.jpg");
		pictureBandit.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Bandit.jpg");
		pictureBarnsby.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Barnsby.jpg");
		pictureDoc.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Doc.jpg");
		pictureGunslinger.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Gunslinger.jpg");
		pictureGunsmith.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Gunsmith.jpg");
		pictureJuarez.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Juarez.jpg");
		pictureMiner.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Miner.jpg");
		pictureRifleman.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Rifleman.jpg");
		pictureSniper.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Sniper.jpg");
		pictureThief.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Thief.jpg");
		pictureTrapper.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Selecc_Trapper.jpg");
		pictureTribeWarrior.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Tribe Warrior.jpg");
	}

	private void Dw9(object sender, EventArgs e)
	{
		ClaseEnCreacion = 12;
		pictureAristocrat.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Aristocrat.jpg");
		pictureBandit.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Bandit.jpg");
		pictureBarnsby.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Barnsby.jpg");
		pictureDoc.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Doc.jpg");
		pictureGunslinger.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Gunslinger.jpg");
		pictureGunsmith.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Gunsmith.jpg");
		pictureJuarez.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Juarez.jpg");
		pictureMiner.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Miner.jpg");
		pictureRifleman.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Rifleman.jpg");
		pictureSniper.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Sniper.jpg");
		pictureThief.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Thief.jpg");
		pictureTrapper.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Trapper.jpg");
		pictureTribeWarrior.set_ImageLocation(Application.get_StartupPath() + "\\images\\characters\\Selecc_Tribe Warrior.jpg");
	}

	private void Lr3(object sender, EventArgs e)
	{
		Cc9k.Forms.frmArmas.cbClass.set_SelectedIndex(ClaseEnCreacion);
		checked
		{
			if (checkLoadDefault.get_Checked())
			{
				if (Cc9k.Forms.frmArmas.cbClass.get_SelectedIndex() == 0)
				{
					Cc9k.Forms.frmArmas.lbNewChar.get_Items().Add((object)"Aristocrat");
					Cc9k.Forms.frmArmas.lbNewChar.set_SelectedIndex(Cc9k.Forms.frmArmas.lbNewChar.get_Items().get_Count() - 1);
					Cc9k.Forms.frmArmas.cbWeap1.set_SelectedIndex(8);
					Cc9k.Forms.frmArmas.cbWeap2.set_SelectedIndex(3);
					Cc9k.Forms.frmArmas.cbWeap3.set_SelectedIndex(5);
					Cc9k.Forms.frmArmas.checkWeap4.set_Checked(false);
					Cc9k.Forms.frmArmas.cbDefault.set_SelectedIndex(0);
				}
				else if (Cc9k.Forms.frmArmas.cbClass.get_SelectedIndex() == 1)
				{
					Cc9k.Forms.frmArmas.lbNewChar.get_Items().Add((object)"Bandit");
					Cc9k.Forms.frmArmas.lbNewChar.set_SelectedIndex(Cc9k.Forms.frmArmas.lbNewChar.get_Items().get_Count() - 1);
					Cc9k.Forms.frmArmas.cbWeap1.set_SelectedIndex(4);
					Cc9k.Forms.frmArmas.cbWeap2.set_SelectedIndex(4);
					Cc9k.Forms.frmArmas.cbWeap3.set_SelectedIndex(6);
					Cc9k.Forms.frmArmas.checkWeap4.set_Checked(false);
					Cc9k.Forms.frmArmas.cbDefault.set_SelectedIndex(1);
				}
				else if (Cc9k.Forms.frmArmas.cbClass.get_SelectedIndex() == 2)
				{
					Cc9k.Forms.frmArmas.lbNewChar.get_Items().Add((object)"Barnsby");
					Cc9k.Forms.frmArmas.lbNewChar.set_SelectedIndex(Cc9k.Forms.frmArmas.lbNewChar.get_Items().get_Count() - 1);
					Cc9k.Forms.frmArmas.cbWeap1.set_SelectedIndex(8);
					Cc9k.Forms.frmArmas.cbWeap2.set_SelectedIndex(8);
					Cc9k.Forms.frmArmas.cbWeap3.set_SelectedIndex(2);
					Cc9k.Forms.frmArmas.checkWeap4.set_Checked(false);
					Cc9k.Forms.frmArmas.cbDefault.set_SelectedIndex(0);
				}
				else if (Cc9k.Forms.frmArmas.cbClass.get_SelectedIndex() == 3)
				{
					Cc9k.Forms.frmArmas.lbNewChar.get_Items().Add((object)"Doc");
					Cc9k.Forms.frmArmas.lbNewChar.set_SelectedIndex(Cc9k.Forms.frmArmas.lbNewChar.get_Items().get_Count() - 1);
					Cc9k.Forms.frmArmas.cbWeap1.set_SelectedIndex(8);
					Cc9k.Forms.frmArmas.cbWeap2.set_SelectedIndex(6);
					Cc9k.Forms.frmArmas.cbWeap3.set_SelectedIndex(6);
					Cc9k.Forms.frmArmas.checkWeap4.set_Checked(false);
					Cc9k.Forms.frmArmas.cbDefault.set_SelectedIndex(1);
				}
				else if (Cc9k.Forms.frmArmas.cbClass.get_SelectedIndex() == 4)
				{
					Cc9k.Forms.frmArmas.lbNewChar.get_Items().Add((object)"Gunslinger");
					Cc9k.Forms.frmArmas.lbNewChar.set_SelectedIndex(Cc9k.Forms.frmArmas.lbNewChar.get_Items().get_Count() - 1);
					Cc9k.Forms.frmArmas.cbWeap1.set_SelectedIndex(5);
					Cc9k.Forms.frmArmas.cbWeap2.set_SelectedIndex(5);
					Cc9k.Forms.frmArmas.cbWeap3.set_SelectedIndex(6);
					Cc9k.Forms.frmArmas.checkWeap4.set_Checked(true);
					Cc9k.Forms.frmArmas.cbAmmo4.set_SelectedIndex(1);
					Cc9k.Forms.frmArmas.cbDefault.set_SelectedIndex(1);
				}
				else if (Cc9k.Forms.frmArmas.cbClass.get_SelectedIndex() == 5)
				{
					Cc9k.Forms.frmArmas.lbNewChar.get_Items().Add((object)"Gunsmith");
					Cc9k.Forms.frmArmas.lbNewChar.set_SelectedIndex(Cc9k.Forms.frmArmas.lbNewChar.get_Items().get_Count() - 1);
					Cc9k.Forms.frmArmas.cbWeap1.set_SelectedIndex(2);
					Cc9k.Forms.frmArmas.cbWeap2.set_SelectedIndex(0);
					Cc9k.Forms.frmArmas.cbWeap3.set_SelectedIndex(6);
					Cc9k.Forms.frmArmas.checkWeap4.set_Checked(false);
					Cc9k.Forms.frmArmas.cbDefault.set_SelectedIndex(1);
				}
				else if (Cc9k.Forms.frmArmas.cbClass.get_SelectedIndex() == 6)
				{
					Cc9k.Forms.frmArmas.lbNewChar.get_Items().Add((object)"Juarez");
					Cc9k.Forms.frmArmas.lbNewChar.set_SelectedIndex(Cc9k.Forms.frmArmas.lbNewChar.get_Items().get_Count() - 1);
					Cc9k.Forms.frmArmas.cbWeap1.set_SelectedIndex(7);
					Cc9k.Forms.frmArmas.cbWeap2.set_SelectedIndex(7);
					Cc9k.Forms.frmArmas.cbWeap3.set_SelectedIndex(6);
					Cc9k.Forms.frmArmas.checkWeap4.set_Checked(false);
					Cc9k.Forms.frmArmas.cbDefault.set_SelectedIndex(1);
				}
				else if (Cc9k.Forms.frmArmas.cbClass.get_SelectedIndex() == 7)
				{
					Cc9k.Forms.frmArmas.lbNewChar.get_Items().Add((object)"Miner");
					Cc9k.Forms.frmArmas.lbNewChar.set_SelectedIndex(Cc9k.Forms.frmArmas.lbNewChar.get_Items().get_Count() - 1);
					Cc9k.Forms.frmArmas.cbWeap1.set_SelectedIndex(7);
					Cc9k.Forms.frmArmas.cbWeap3.set_SelectedIndex(6);
					Cc9k.Forms.frmArmas.cbWeap2.set_SelectedIndex(4);
					Cc9k.Forms.frmArmas.checkWeap4.set_Checked(true);
					Cc9k.Forms.frmArmas.cbAmmo4.set_SelectedIndex(4);
					Cc9k.Forms.frmArmas.cbDefault.set_SelectedIndex(2);
				}
				else if (Cc9k.Forms.frmArmas.cbClass.get_SelectedIndex() == 8)
				{
					Cc9k.Forms.frmArmas.lbNewChar.get_Items().Add((object)"Rifleman");
					Cc9k.Forms.frmArmas.lbNewChar.set_SelectedIndex(Cc9k.Forms.frmArmas.lbNewChar.get_Items().get_Count() - 1);
					Cc9k.Forms.frmArmas.cbWeap1.set_SelectedIndex(3);
					Cc9k.Forms.frmArmas.cbWeap2.set_SelectedIndex(3);
					Cc9k.Forms.frmArmas.cbWeap3.set_SelectedIndex(4);
					Cc9k.Forms.frmArmas.checkWeap4.set_Checked(false);
					Cc9k.Forms.frmArmas.cbDefault.set_SelectedIndex(0);
				}
				else if (Cc9k.Forms.frmArmas.cbClass.get_SelectedIndex() == 9)
				{
					Cc9k.Forms.frmArmas.lbNewChar.get_Items().Add((object)"Sniper");
					Cc9k.Forms.frmArmas.lbNewChar.set_SelectedIndex(Cc9k.Forms.frmArmas.lbNewChar.get_Items().get_Count() - 1);
					Cc9k.Forms.frmArmas.cbWeap1.set_SelectedIndex(8);
					Cc9k.Forms.frmArmas.cbWeap2.set_SelectedIndex(7);
					Cc9k.Forms.frmArmas.cbWeap3.set_SelectedIndex(3);
					Cc9k.Forms.frmArmas.checkWeap4.set_Checked(false);
					Cc9k.Forms.frmArmas.cbDefault.set_SelectedIndex(0);
				}
				else if (Cc9k.Forms.frmArmas.cbClass.get_SelectedIndex() == 10)
				{
					Cc9k.Forms.frmArmas.lbNewChar.get_Items().Add((object)"Thief");
					Cc9k.Forms.frmArmas.lbNewChar.set_SelectedIndex(Cc9k.Forms.frmArmas.lbNewChar.get_Items().get_Count() - 1);
					Cc9k.Forms.frmArmas.cbWeap1.set_SelectedIndex(8);
					Cc9k.Forms.frmArmas.cbWeap2.set_SelectedIndex(1);
					Cc9k.Forms.frmArmas.cbWeap3.set_SelectedIndex(6);
					Cc9k.Forms.frmArmas.checkWeap4.set_Checked(true);
					Cc9k.Forms.frmArmas.cbAmmo4.set_SelectedIndex(2);
					Cc9k.Forms.frmArmas.cbDefault.set_SelectedIndex(2);
				}
				else if (Cc9k.Forms.frmArmas.cbClass.get_SelectedIndex() == 11)
				{
					Cc9k.Forms.frmArmas.lbNewChar.get_Items().Add((object)"Trapper");
					Cc9k.Forms.frmArmas.lbNewChar.set_SelectedIndex(Cc9k.Forms.frmArmas.lbNewChar.get_Items().get_Count() - 1);
					Cc9k.Forms.frmArmas.cbWeap1.set_SelectedIndex(8);
					Cc9k.Forms.frmArmas.cbWeap2.set_SelectedIndex(7);
					Cc9k.Forms.frmArmas.cbWeap3.set_SelectedIndex(1);
					Cc9k.Forms.frmArmas.checkWeap4.set_Checked(false);
					Cc9k.Forms.frmArmas.cbDefault.set_SelectedIndex(0);
				}
				else if (Cc9k.Forms.frmArmas.cbClass.get_SelectedIndex() == 12)
				{
					Cc9k.Forms.frmArmas.lbNewChar.get_Items().Add((object)"Tribe Warrior");
					Cc9k.Forms.frmArmas.lbNewChar.set_SelectedIndex(Cc9k.Forms.frmArmas.lbNewChar.get_Items().get_Count() - 1);
					Cc9k.Forms.frmArmas.cbWeap1.set_SelectedIndex(8);
					Cc9k.Forms.frmArmas.cbWeap2.set_SelectedIndex(8);
					Cc9k.Forms.frmArmas.cbWeap3.set_SelectedIndex(0);
					Cc9k.Forms.frmArmas.checkWeap4.set_Checked(false);
					Cc9k.Forms.frmArmas.cbDefault.set_SelectedIndex(0);
				}
			}
			Cc9k.Forms.frmArmas.TabControlMods.set_SelectedTab(Cc9k.Forms.frmArmas.tabNewMod);
			((Form)this).Close();
		}
	}

	private void p1M(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void Rj7(object sender, FormClosingEventArgs e)
	{
		((Component)this).Dispose();
	}

	internal static void x5A(List<object> w8L, int Zs0)
	{
		byte[] array = new byte[16];
		int num = 0;
		checked
		{
			while (num < 16)
			{
				if (num == 0)
				{
					array[num] = (byte)num;
					array[num + 1] = (byte)Math.Abs(Zs0);
				}
				else if (num > 1)
				{
					array[num] = (byte)Math.Abs(Zs0 + 74);
				}
				int num2 = num + 1;
				if (num < num2)
				{
					num = num2;
				}
			}
			w8L.Add(array);
			o3HG.Ck3q(w8L, (byte[])w8L[4], 255);
		}
	}

	static void p2E()
	{
		s0T s0T = s0T;
		s0T = null;
		Ao56 obj = (Ao56)(object)t8TR.Default;
		Ao56 ao = null;
		ao = obj;
		nuint num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out t8TR t8TR);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Nb4n nb4n);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y9CZ y9CZ);
		if (checked(unchecked(checked(unchecked(num / (nuint)(UIntPtr)t8TR.Default) * unchecked((nuint)(UIntPtr)t8TR.Default)) / num) - num - num * unchecked((nuint)(UIntPtr)t8TR.Default) + unchecked((nuint)default(UIntPtr))) == 0)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out s2ZW s2ZW2);
			do
			{
				try
				{
					y9CZ = y9CZ;
					y9CZ = null;
					t8TR = null;
					t8TR = null;
					s2ZW obj2 = (s2ZW)(object)t8TR.Default;
					s2ZW2 = s2ZW2;
					s2ZW2 = obj2;
					_ = (Nb4n)(object)t8TR.Default;
				}
				catch
				{
					nb4n = (Nb4n)(object)t8TR.Default;
					nb4n = nb4n;
				}
				obj4 = t8TR.Default;
			}
			while (obj4 != null);
		}
		else if (unchecked((nuint)default(UIntPtr)) / (nuint)(UIntPtr)t8TR.Default == 0)
		{
			s0T = null;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out p9CA p9CA);
		while ((object)t8TR.Default != null)
		{
			while (obj4 != null)
			{
				while (obj4 != null)
				{
					p9CA = p9CA;
					p9CA = p9CA;
				}
			}
		}
		try
		{
			_ = (Hj2y)(object)t8TR.Default;
		}
		catch
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					p9CA = null;
				}
			}
			finally
			{
				try
				{
					p9CA = null;
				}
				finally
				{
					Cc9k cc9k = cc9k;
					cc9k = cc9k;
					goto end_IL_013b;
				}
			}
			end_IL_013b:;
		}
		do
		{
			try
			{
				try
				{
					nb4n = null;
				}
				catch
				{
					_ = (Nb4n)(object)t8TR.Default;
				}
			}
			catch
			{
				UIntPtr num2 = (UIntPtr)t8TR.Default;
				num = default(UIntPtr);
				checked
				{
					if (unchecked((nuint)num2) - (unchecked((nuint)default(UIntPtr)) + num + num) * num == 0)
					{
						_ = (Nb4n)(object)t8TR.Default;
						Cc9k cc9k = null;
						cc9k = null;
					}
				}
			}
		}
		while (obj4 != null);
		do
		{
			_ = (Hj2y)(object)t8TR.Default;
		}
		while ((object)t8TR.Default != null);
		while ((object)t8TR.Default != null)
		{
			_ = t8TR.Default;
		}
		try
		{
			while (obj4 != null)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					y9CZ = (y9CZ)(object)t8TR.Default;
					continue;
				}
				_ = (o3HG)(object)t8TR.Default;
				_ = (Hj2y)(object)t8TR.Default;
			}
		}
		finally
		{
			try
			{
				try
				{
					_ = (m0PK)(object)t8TR.Default;
				}
				catch
				{
					_ = (Ao56)(object)t8TR.Default;
				}
			}
			catch
			{
				try
				{
					_ = (s0T)(object)t8TR.Default;
				}
				catch
				{
					t8TR = t8TR;
					_ = (_003CModule_003E)(object)t8TR.Default;
					y9CZ = null;
					nb4n = nb4n;
				}
			}
			goto IL_02f1;
		}
		IL_02f1:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		while (obj4 != null)
		{
			while ((object)t8TR.Default != null)
			{
				try
				{
					_ = (p9CA)(object)t8TR.Default;
					_003CModule_003E = _003CModule_003E;
					_003CModule_003E = _003CModule_003E;
					s2ZW s2ZW2 = (s2ZW)(object)t8TR.Default;
				}
				catch
				{
					_ = (_003CModule_003E)(object)t8TR.Default;
					Cc9k cc9k = null;
				}
			}
		}
		num = default(UIntPtr);
		checked
		{
			if (num == 0)
			{
				_003CModule_003E = null;
			}
			else if (num * (unchecked((nuint)(UIntPtr)t8TR.Default / num) - num) == 0)
			{
				t8TR = t8TR.Default;
			}
			else
			{
				_ = (m0PK)(object)t8TR.Default;
				y9CZ = y9CZ;
			}
		}
		try
		{
			try
			{
				if ((UIntPtr)t8TR.Default == (UIntPtr)(nuint)0u)
				{
					p9CA = null;
				}
			}
			finally
			{
				goto end_IL_034d;
			}
			end_IL_034d:;
		}
		finally
		{
			goto IL_0386;
		}
		IL_042b:
		do
		{
			try
			{
				try
				{
					ao = null;
					_ = (Hj2y)(object)t8TR.Default;
					_ = (Hj2y)(object)t8TR.Default;
					_ = (Ao56)(object)t8TR.Default;
				}
				finally
				{
					t8TR = t8TR;
					p9CA = p9CA;
					goto end_IL_042b;
				}
				end_IL_042b:;
			}
			catch
			{
				_ = (o3HG)(object)t8TR.Default;
			}
		}
		while ((object)t8TR.Default != null);
		do
		{
			s0T = null;
		}
		while (obj4 != null);
		_ = t8TR.Default;
		if ((UIntPtr)t8TR.Default == (UIntPtr)(nuint)0u)
		{
			while (obj4 != null)
			{
			}
		}
		else if (num == 0)
		{
			nb4n = (Nb4n)(object)t8TR.Default;
		}
		else
		{
			_ = (s2ZW)(object)t8TR.Default;
			nb4n = nb4n;
			_ = (m0PK)(object)t8TR.Default;
			_ = (Hj2y)(object)t8TR.Default;
		}
		if (default(UIntPtr) != (UIntPtr)(nuint)0u)
		{
			return;
		}
		try
		{
			do
			{
				Cc9k cc9k = (Cc9k)(object)t8TR.Default;
				_ = (p9CA)(object)t8TR.Default;
			}
			while (obj4 != null);
			return;
		}
		catch
		{
			try
			{
				_ = (s0T)(object)t8TR.Default;
				return;
			}
			catch
			{
				_ = (s2ZW)(object)t8TR.Default;
				return;
			}
		}
		IL_0386:
		while ((object)t8TR.Default != null)
		{
			try
			{
				do
				{
					p9CA = p9CA;
				}
				while ((object)t8TR.Default != null);
			}
			finally
			{
				s0T = null;
				continue;
			}
		}
		if (num == 0 && (UIntPtr)t8TR.Default != (UIntPtr)(nuint)0u)
		{
			if (num == 0)
			{
				y9CZ = y9CZ;
			}
			else
			{
				_ = (Hj2y)(object)t8TR.Default;
			}
		}
		try
		{
			ao = ao;
		}
		catch
		{
			try
			{
				try
				{
					_ = (s0T)(object)t8TR.Default;
				}
				finally
				{
					_ = (y9CZ)(object)t8TR.Default;
					goto end_IL_03cb;
				}
				end_IL_03cb:;
			}
			catch
			{
				try
				{
					t8TR = t8TR.Default;
					goto end_IL_03e8;
				}
				catch
				{
					_ = (o3HG)(object)t8TR.Default;
					goto end_IL_03e8;
				}
				end_IL_03e8:;
			}
		}
		if (num == 0)
		{
			try
			{
				y9CZ = (y9CZ)(object)t8TR.Default;
			}
			finally
			{
				ao = ao;
				goto IL_042b;
			}
		}
		goto IL_042b;
	}
}
