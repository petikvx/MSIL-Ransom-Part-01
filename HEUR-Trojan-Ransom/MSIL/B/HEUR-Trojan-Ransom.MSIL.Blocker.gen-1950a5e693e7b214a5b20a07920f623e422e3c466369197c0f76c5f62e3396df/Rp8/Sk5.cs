using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Bi7;
using Co02;
using Mb5q;
using Microsoft.VisualBasic.CompilerServices;
using Nr2m;
using Nt1m;
using Re2r;
using Rk0g;
using e8Z;
using y0D5;
using y5P;

namespace Rp8;

[DesignerGenerated]
public class Sk5 : Form
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
			EventHandler eventHandler = Ad3;
			EventHandler eventHandler2 = Tx0;
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
			EventHandler eventHandler = Ad3;
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
			EventHandler eventHandler = Rr5;
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
			EventHandler eventHandler = Rr5;
			EventHandler eventHandler2 = Tx0;
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
			EventHandler eventHandler = o3Z;
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
			EventHandler eventHandler = o3Z;
			EventHandler eventHandler2 = Tx0;
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
			EventHandler eventHandler = k4E;
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
			EventHandler eventHandler = k4E;
			EventHandler eventHandler2 = Tx0;
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
			EventHandler eventHandler = g6J;
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
			EventHandler eventHandler = g6J;
			EventHandler eventHandler2 = Tx0;
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
			EventHandler eventHandler = Xj8;
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
			EventHandler eventHandler = Xj8;
			EventHandler eventHandler2 = Tx0;
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
			EventHandler eventHandler = Cj4;
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
			EventHandler eventHandler = Cj4;
			EventHandler eventHandler2 = Tx0;
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
			EventHandler eventHandler = g7J;
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
			EventHandler eventHandler = g7J;
			EventHandler eventHandler2 = Tx0;
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
			EventHandler eventHandler = Ww8;
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
			EventHandler eventHandler = Ww8;
			EventHandler eventHandler2 = Tx0;
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
			EventHandler eventHandler = a9M;
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
			EventHandler eventHandler = a9M;
			EventHandler eventHandler2 = Tx0;
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
			EventHandler eventHandler = Dg9;
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
			EventHandler eventHandler = Dg9;
			EventHandler eventHandler2 = Tx0;
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
			EventHandler eventHandler = f2S;
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
			EventHandler eventHandler = f2S;
			EventHandler eventHandler2 = Tx0;
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
			EventHandler eventHandler = i1B;
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
			EventHandler eventHandler = i1B;
			EventHandler eventHandler2 = Tx0;
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
			EventHandler eventHandler = Tx0;
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
			EventHandler eventHandler = s7N;
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

	public Sk5()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		((Form)this).add_FormClosing(new FormClosingEventHandler(i9E));
		ClaseEnCreacion = 0;
		Bx1();
	}

	[DebuggerNonUserCode]
	protected override void d3W(bool Kc9)
	{
		try
		{
			if (Kc9 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Kc9);
		}
	}

	[DebuggerStepThrough]
	private void Bx1()
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Sk5));
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

	private void Ad3(object sender, EventArgs e)
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

	private void Rr5(object sender, EventArgs e)
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

	private void o3Z(object sender, EventArgs e)
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

	private void k4E(object sender, EventArgs e)
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

	private void a9M(object sender, EventArgs e)
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

	private void g7J(object sender, EventArgs e)
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

	private void Cj4(object sender, EventArgs e)
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

	private void Xj8(object sender, EventArgs e)
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

	private void g6J(object sender, EventArgs e)
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

	private void Ww8(object sender, EventArgs e)
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

	private void i1B(object sender, EventArgs e)
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

	private void f2S(object sender, EventArgs e)
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

	private void Dg9(object sender, EventArgs e)
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

	private void Tx0(object sender, EventArgs e)
	{
		k8D5.Forms.frmArmas.cbClass.set_SelectedIndex(ClaseEnCreacion);
		checked
		{
			if (checkLoadDefault.get_Checked())
			{
				if (k8D5.Forms.frmArmas.cbClass.get_SelectedIndex() == 0)
				{
					k8D5.Forms.frmArmas.lbNewChar.get_Items().Add((object)"Aristocrat");
					k8D5.Forms.frmArmas.lbNewChar.set_SelectedIndex(k8D5.Forms.frmArmas.lbNewChar.get_Items().get_Count() - 1);
					k8D5.Forms.frmArmas.cbWeap1.set_SelectedIndex(8);
					k8D5.Forms.frmArmas.cbWeap2.set_SelectedIndex(3);
					k8D5.Forms.frmArmas.cbWeap3.set_SelectedIndex(5);
					k8D5.Forms.frmArmas.checkWeap4.set_Checked(false);
					k8D5.Forms.frmArmas.cbDefault.set_SelectedIndex(0);
				}
				else if (k8D5.Forms.frmArmas.cbClass.get_SelectedIndex() == 1)
				{
					k8D5.Forms.frmArmas.lbNewChar.get_Items().Add((object)"Bandit");
					k8D5.Forms.frmArmas.lbNewChar.set_SelectedIndex(k8D5.Forms.frmArmas.lbNewChar.get_Items().get_Count() - 1);
					k8D5.Forms.frmArmas.cbWeap1.set_SelectedIndex(4);
					k8D5.Forms.frmArmas.cbWeap2.set_SelectedIndex(4);
					k8D5.Forms.frmArmas.cbWeap3.set_SelectedIndex(6);
					k8D5.Forms.frmArmas.checkWeap4.set_Checked(false);
					k8D5.Forms.frmArmas.cbDefault.set_SelectedIndex(1);
				}
				else if (k8D5.Forms.frmArmas.cbClass.get_SelectedIndex() == 2)
				{
					k8D5.Forms.frmArmas.lbNewChar.get_Items().Add((object)"Barnsby");
					k8D5.Forms.frmArmas.lbNewChar.set_SelectedIndex(k8D5.Forms.frmArmas.lbNewChar.get_Items().get_Count() - 1);
					k8D5.Forms.frmArmas.cbWeap1.set_SelectedIndex(8);
					k8D5.Forms.frmArmas.cbWeap2.set_SelectedIndex(8);
					k8D5.Forms.frmArmas.cbWeap3.set_SelectedIndex(2);
					k8D5.Forms.frmArmas.checkWeap4.set_Checked(false);
					k8D5.Forms.frmArmas.cbDefault.set_SelectedIndex(0);
				}
				else if (k8D5.Forms.frmArmas.cbClass.get_SelectedIndex() == 3)
				{
					k8D5.Forms.frmArmas.lbNewChar.get_Items().Add((object)"Doc");
					k8D5.Forms.frmArmas.lbNewChar.set_SelectedIndex(k8D5.Forms.frmArmas.lbNewChar.get_Items().get_Count() - 1);
					k8D5.Forms.frmArmas.cbWeap1.set_SelectedIndex(8);
					k8D5.Forms.frmArmas.cbWeap2.set_SelectedIndex(6);
					k8D5.Forms.frmArmas.cbWeap3.set_SelectedIndex(6);
					k8D5.Forms.frmArmas.checkWeap4.set_Checked(false);
					k8D5.Forms.frmArmas.cbDefault.set_SelectedIndex(1);
				}
				else if (k8D5.Forms.frmArmas.cbClass.get_SelectedIndex() == 4)
				{
					k8D5.Forms.frmArmas.lbNewChar.get_Items().Add((object)"Gunslinger");
					k8D5.Forms.frmArmas.lbNewChar.set_SelectedIndex(k8D5.Forms.frmArmas.lbNewChar.get_Items().get_Count() - 1);
					k8D5.Forms.frmArmas.cbWeap1.set_SelectedIndex(5);
					k8D5.Forms.frmArmas.cbWeap2.set_SelectedIndex(5);
					k8D5.Forms.frmArmas.cbWeap3.set_SelectedIndex(6);
					k8D5.Forms.frmArmas.checkWeap4.set_Checked(true);
					k8D5.Forms.frmArmas.cbAmmo4.set_SelectedIndex(1);
					k8D5.Forms.frmArmas.cbDefault.set_SelectedIndex(1);
				}
				else if (k8D5.Forms.frmArmas.cbClass.get_SelectedIndex() == 5)
				{
					k8D5.Forms.frmArmas.lbNewChar.get_Items().Add((object)"Gunsmith");
					k8D5.Forms.frmArmas.lbNewChar.set_SelectedIndex(k8D5.Forms.frmArmas.lbNewChar.get_Items().get_Count() - 1);
					k8D5.Forms.frmArmas.cbWeap1.set_SelectedIndex(2);
					k8D5.Forms.frmArmas.cbWeap2.set_SelectedIndex(0);
					k8D5.Forms.frmArmas.cbWeap3.set_SelectedIndex(6);
					k8D5.Forms.frmArmas.checkWeap4.set_Checked(false);
					k8D5.Forms.frmArmas.cbDefault.set_SelectedIndex(1);
				}
				else if (k8D5.Forms.frmArmas.cbClass.get_SelectedIndex() == 6)
				{
					k8D5.Forms.frmArmas.lbNewChar.get_Items().Add((object)"Juarez");
					k8D5.Forms.frmArmas.lbNewChar.set_SelectedIndex(k8D5.Forms.frmArmas.lbNewChar.get_Items().get_Count() - 1);
					k8D5.Forms.frmArmas.cbWeap1.set_SelectedIndex(7);
					k8D5.Forms.frmArmas.cbWeap2.set_SelectedIndex(7);
					k8D5.Forms.frmArmas.cbWeap3.set_SelectedIndex(6);
					k8D5.Forms.frmArmas.checkWeap4.set_Checked(false);
					k8D5.Forms.frmArmas.cbDefault.set_SelectedIndex(1);
				}
				else if (k8D5.Forms.frmArmas.cbClass.get_SelectedIndex() == 7)
				{
					k8D5.Forms.frmArmas.lbNewChar.get_Items().Add((object)"Miner");
					k8D5.Forms.frmArmas.lbNewChar.set_SelectedIndex(k8D5.Forms.frmArmas.lbNewChar.get_Items().get_Count() - 1);
					k8D5.Forms.frmArmas.cbWeap1.set_SelectedIndex(7);
					k8D5.Forms.frmArmas.cbWeap3.set_SelectedIndex(6);
					k8D5.Forms.frmArmas.cbWeap2.set_SelectedIndex(4);
					k8D5.Forms.frmArmas.checkWeap4.set_Checked(true);
					k8D5.Forms.frmArmas.cbAmmo4.set_SelectedIndex(4);
					k8D5.Forms.frmArmas.cbDefault.set_SelectedIndex(2);
				}
				else if (k8D5.Forms.frmArmas.cbClass.get_SelectedIndex() == 8)
				{
					k8D5.Forms.frmArmas.lbNewChar.get_Items().Add((object)"Rifleman");
					k8D5.Forms.frmArmas.lbNewChar.set_SelectedIndex(k8D5.Forms.frmArmas.lbNewChar.get_Items().get_Count() - 1);
					k8D5.Forms.frmArmas.cbWeap1.set_SelectedIndex(3);
					k8D5.Forms.frmArmas.cbWeap2.set_SelectedIndex(3);
					k8D5.Forms.frmArmas.cbWeap3.set_SelectedIndex(4);
					k8D5.Forms.frmArmas.checkWeap4.set_Checked(false);
					k8D5.Forms.frmArmas.cbDefault.set_SelectedIndex(0);
				}
				else if (k8D5.Forms.frmArmas.cbClass.get_SelectedIndex() == 9)
				{
					k8D5.Forms.frmArmas.lbNewChar.get_Items().Add((object)"Sniper");
					k8D5.Forms.frmArmas.lbNewChar.set_SelectedIndex(k8D5.Forms.frmArmas.lbNewChar.get_Items().get_Count() - 1);
					k8D5.Forms.frmArmas.cbWeap1.set_SelectedIndex(8);
					k8D5.Forms.frmArmas.cbWeap2.set_SelectedIndex(7);
					k8D5.Forms.frmArmas.cbWeap3.set_SelectedIndex(3);
					k8D5.Forms.frmArmas.checkWeap4.set_Checked(false);
					k8D5.Forms.frmArmas.cbDefault.set_SelectedIndex(0);
				}
				else if (k8D5.Forms.frmArmas.cbClass.get_SelectedIndex() == 10)
				{
					k8D5.Forms.frmArmas.lbNewChar.get_Items().Add((object)"Thief");
					k8D5.Forms.frmArmas.lbNewChar.set_SelectedIndex(k8D5.Forms.frmArmas.lbNewChar.get_Items().get_Count() - 1);
					k8D5.Forms.frmArmas.cbWeap1.set_SelectedIndex(8);
					k8D5.Forms.frmArmas.cbWeap2.set_SelectedIndex(1);
					k8D5.Forms.frmArmas.cbWeap3.set_SelectedIndex(6);
					k8D5.Forms.frmArmas.checkWeap4.set_Checked(true);
					k8D5.Forms.frmArmas.cbAmmo4.set_SelectedIndex(2);
					k8D5.Forms.frmArmas.cbDefault.set_SelectedIndex(2);
				}
				else if (k8D5.Forms.frmArmas.cbClass.get_SelectedIndex() == 11)
				{
					k8D5.Forms.frmArmas.lbNewChar.get_Items().Add((object)"Trapper");
					k8D5.Forms.frmArmas.lbNewChar.set_SelectedIndex(k8D5.Forms.frmArmas.lbNewChar.get_Items().get_Count() - 1);
					k8D5.Forms.frmArmas.cbWeap1.set_SelectedIndex(8);
					k8D5.Forms.frmArmas.cbWeap2.set_SelectedIndex(7);
					k8D5.Forms.frmArmas.cbWeap3.set_SelectedIndex(1);
					k8D5.Forms.frmArmas.checkWeap4.set_Checked(false);
					k8D5.Forms.frmArmas.cbDefault.set_SelectedIndex(0);
				}
				else if (k8D5.Forms.frmArmas.cbClass.get_SelectedIndex() == 12)
				{
					k8D5.Forms.frmArmas.lbNewChar.get_Items().Add((object)"Tribe Warrior");
					k8D5.Forms.frmArmas.lbNewChar.set_SelectedIndex(k8D5.Forms.frmArmas.lbNewChar.get_Items().get_Count() - 1);
					k8D5.Forms.frmArmas.cbWeap1.set_SelectedIndex(8);
					k8D5.Forms.frmArmas.cbWeap2.set_SelectedIndex(8);
					k8D5.Forms.frmArmas.cbWeap3.set_SelectedIndex(0);
					k8D5.Forms.frmArmas.checkWeap4.set_Checked(false);
					k8D5.Forms.frmArmas.cbDefault.set_SelectedIndex(0);
				}
			}
			k8D5.Forms.frmArmas.TabControlMods.set_SelectedTab(k8D5.Forms.frmArmas.tabNewMod);
			((Form)this).Close();
		}
	}

	private void s7N(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void i9E(object sender, FormClosingEventArgs e)
	{
		((Component)this).Dispose();
	}

	internal static void Xp7(List<object> Fq7, int Qs3)
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
					array[num + 1] = (byte)Math.Abs(Qs3);
				}
				else if (num > 1)
				{
					array[num] = (byte)Math.Abs(Qs3 + 74);
				}
				int num2 = num + 1;
				if (num < num2)
				{
					num = num2;
				}
			}
			Fq7.Add(array);
			i6A.c0J(Fq7, (byte[])Fq7[4], 255);
		}
	}

	static void q8M()
	{
		Wx57 obj = (Wx57)(object)g5LW.Default;
		Wx57 wx = null;
		wx = obj;
		nuint num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Jt0m jt0m);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c2J c2J);
		checked
		{
			if (num + num == 0)
			{
				try
				{
					c2J = c2J;
					c2J = c2J;
				}
				finally
				{
					try
					{
						jt0m = jt0m;
						jt0m = jt0m;
					}
					catch
					{
						jt0m = jt0m;
					}
					goto IL_007e;
				}
			}
			if (num * unchecked((nuint)(UIntPtr)g5LW.Default) == 0)
			{
				_ = (Ht2)(object)g5LW.Default;
			}
			goto IL_007e;
		}
		IL_01f6:
		jt0m = jt0m;
		k8G6 k8G = k8G;
		_ = (Jt0m)(object)g5LW.Default;
		try
		{
			_ = (_003CModule_003E)(object)g5LW.Default;
		}
		catch
		{
			_ = (Sk5)(object)g5LW.Default;
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					_ = (Sk5)(object)g5LW.Default;
				}
				finally
				{
					_ = (Jt0m)(object)g5LW.Default;
					goto end_IL_023c;
				}
				end_IL_023c:;
			}
			finally
			{
				_ = (Ht2)(object)g5LW.Default;
				goto IL_0271;
			}
		}
		goto IL_0271;
		IL_0271:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj4);
		while (obj4 != null)
		{
			_ = (Wx57)(object)g5LW.Default;
		}
		_ = (Ht2)(object)g5LW.Default;
		num = default(UIntPtr);
		if (num == 0)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out k8D5 k8D);
			do
			{
				if (checked(num * (num * num)) != 0)
				{
					k8D = k8D;
					k8D = k8D;
					_ = (a9PE)(object)g5LW.Default;
				}
				else
				{
					_ = (Jt0m)(object)g5LW.Default;
				}
			}
			while (obj4 != null);
			goto IL_02fb;
		}
		try
		{
			wx = (Wx57)(object)g5LW.Default;
		}
		finally
		{
			do
			{
				_ = (Jt0m)(object)g5LW.Default;
			}
			while (obj4 != null);
			goto IL_02fb;
		}
		IL_02fb:
		_ = (Ht2)(object)g5LW.Default;
		_ = (Jt0m)(object)g5LW.Default;
		g5LW obj5 = g5LW.Default;
		g5LW g5LW = null;
		g5LW = obj5;
		_ = (k8D5)(object)g5LW.Default;
		jt0m = null;
		g5LW = g5LW;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n4R1 n4R);
		try
		{
			Sk5 sk = sk;
			sk = sk;
		}
		finally
		{
			if (checked(unchecked((nuint)default(UIntPtr)) - unchecked((nuint)(UIntPtr)g5LW.Default)) == 0)
			{
				if ((UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u)
				{
					k8D5 k8D = null;
					_ = (i6A)(object)g5LW.Default;
					n4R = n4R;
					n4R = n4R;
					_ = g5LW.Default;
				}
			}
			else
			{
				_003CModule_003E = _003CModule_003E;
				_003CModule_003E = _003CModule_003E;
			}
			goto IL_03b4;
		}
		IL_007e:
		checked
		{
			if (num + unchecked((nuint)(UIntPtr)g5LW.Default) == 0 && num == 0)
			{
				_ = (k8D5)(object)g5LW.Default;
			}
			do
			{
				if (default(UIntPtr) == unchecked((UIntPtr)(nuint)0u))
				{
					_ = (n4R1)(object)g5LW.Default;
					_ = (a9PE)(object)g5LW.Default;
					c2J = (c2J)(object)g5LW.Default;
				}
				obj4 = obj4;
			}
			while (obj4 != null || obj4 != null);
			num = default(UIntPtr);
			if (unchecked((nuint)default(UIntPtr)) - unchecked((nuint)default(UIntPtr)) * (num + num) == 0)
			{
				try
				{
					if (unchecked((nuint)(UIntPtr)g5LW.Default) - num == 0)
					{
						a9PE a9PE = (a9PE)(object)g5LW.Default;
						a9PE = a9PE;
					}
					else
					{
						wx = (Wx57)(object)g5LW.Default;
					}
				}
				catch
				{
					do
					{
						_ = (k8G6)(object)g5LW.Default;
					}
					while ((object)g5LW.Default != null);
				}
			}
			else if (unchecked((UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u))
			{
				c2J = c2J;
			}
			else
			{
				while ((object)g5LW.Default != null)
				{
					c2J = c2J;
				}
			}
			try
			{
			}
			finally
			{
				while (obj4 != null)
				{
					try
					{
						i6A i6A = (i6A)(object)g5LW.Default;
						i6A = i6A;
						_ = (k8G6)(object)g5LW.Default;
						_ = (Jt0m)(object)g5LW.Default;
						_ = (k8D5)(object)g5LW.Default;
					}
					catch
					{
						_ = (i6A)(object)g5LW.Default;
					}
				}
				goto IL_01f6;
			}
		}
		IL_03b4:
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			wx = wx;
			_ = (Ht2)(object)g5LW.Default;
			wx = (Wx57)(object)g5LW.Default;
		}
		else
		{
			n4R = n4R;
		}
		_ = (n4R1)(object)g5LW.Default;
		_ = (Ht2)(object)g5LW.Default;
		while (obj4 != null)
		{
			do
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_003CModule_003E = _003CModule_003E;
				}
			}
			while ((object)g5LW.Default != null);
		}
		try
		{
			do
			{
				_ = (Ht2)(object)g5LW.Default;
			}
			while (obj4 != null);
		}
		catch
		{
			_ = (Wx57)(object)g5LW.Default;
		}
	}

	static void Px7()
	{
		Wx57 wx;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ht2 ht);
		try
		{
			Wx57 obj = (Wx57)(object)g5LW.Default;
			wx = (Wx57)(object)g5LW.Default;
			wx = obj;
		}
		finally
		{
			try
			{
				try
				{
					_ = (c2J)(object)g5LW.Default;
					_ = (a9PE)(object)g5LW.Default;
				}
				catch
				{
					_ = (n4R1)(object)g5LW.Default;
				}
			}
			catch
			{
				do
				{
					ht = null;
					ht = ht;
				}
				while ((object)g5LW.Default != null);
			}
			goto IL_0092;
		}
		IL_0092:
		while ((object)g5LW.Default != null)
		{
			try
			{
				_ = g5LW.Default;
			}
			finally
			{
				try
				{
					_ = (k8G6)(object)g5LW.Default;
				}
				catch
				{
					_ = (n4R1)(object)g5LW.Default;
				}
				continue;
			}
		}
		_ = (i6A)(object)g5LW.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj5);
		try
		{
			_ = (Sk5)(object)g5LW.Default;
		}
		finally
		{
			try
			{
				_ = (Sk5)(object)g5LW.Default;
			}
			catch
			{
				do
				{
					_ = (c2J)(object)g5LW.Default;
					_ = (c2J)(object)g5LW.Default;
					obj5 = obj5;
				}
				while (obj5 != null);
			}
			goto IL_00ed;
		}
		IL_057f:
		_ = (a9PE)(object)g5LW.Default;
		_ = (a9PE)(object)g5LW.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c2J c2J);
		while (obj5 != null)
		{
			c2J = (c2J)(object)g5LW.Default;
		}
		return;
		IL_00ed:
		_ = (k8G6)(object)g5LW.Default;
		_ = (Sk5)(object)g5LW.Default;
		UIntPtr num = (UIntPtr)g5LW.Default;
		UIntPtr num2 = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out i6A i6A);
		checked
		{
			if (unchecked((nuint)num) + num2 == 0)
			{
				i6A = (i6A)(object)g5LW.Default;
				i6A = i6A;
			}
		}
		k8G6 k8G;
		if ((UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u)
		{
			if (num2 == 0)
			{
				while (obj5 != null)
				{
					_ = (Ht2)(object)g5LW.Default;
				}
			}
			else
			{
				do
				{
					k8G = null;
					k8G = k8G;
				}
				while (obj5 != null);
			}
		}
		_ = (Jt0m)(object)g5LW.Default;
		k8G = (k8G6)(object)g5LW.Default;
		do
		{
			try
			{
				do
				{
					c2J = null;
					c2J = null;
				}
				while (obj5 != null);
			}
			finally
			{
				_ = (Ht2)(object)g5LW.Default;
				continue;
			}
		}
		while (obj5 != null);
		if ((UIntPtr)g5LW.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					k8G = null;
				}
				finally
				{
					k8G = k8G;
					goto end_IL_01c2;
				}
				end_IL_01c2:;
			}
			finally
			{
				goto IL_01d8;
			}
		}
		goto IL_01d8;
		IL_01d8:
		_ = (Ht2)(object)g5LW.Default;
		k8G = null;
		_ = (Sk5)(object)g5LW.Default;
		_ = (i6A)(object)g5LW.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out k8D5 k8D);
		try
		{
			_ = (n4R1)(object)g5LW.Default;
		}
		finally
		{
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out Sk5 sk);
				while ((object)g5LW.Default != null)
				{
					_ = g5LW.Default;
					sk = sk;
					sk = null;
					k8D5 obj7 = (k8D5)(object)g5LW.Default;
					k8D = k8D;
					k8D = obj7;
				}
			}
			finally
			{
				wx = null;
				goto IL_027b;
			}
		}
		IL_0542:
		try
		{
		}
		finally
		{
			do
			{
				if (default(UIntPtr) != (UIntPtr)(nuint)0u)
				{
					g5LW g5LW = g5LW.Default;
				}
				else
				{
					_ = (Ht2)(object)g5LW.Default;
				}
			}
			while (obj5 != null);
			goto IL_057f;
		}
		IL_04ad:
		checked
		{
			try
			{
				_ = (Ht2)(object)g5LW.Default;
			}
			finally
			{
				num2 = default(UIntPtr);
				if (num2 + num2 * ((num2 + (unchecked((nuint)(UIntPtr)g5LW.Default) - unchecked(num2 / (nuint)(UIntPtr)g5LW.Default))) * unchecked((nuint)default(UIntPtr)) + unchecked((nuint)(UIntPtr)g5LW.Default)) == 0)
				{
					try
					{
						ht = (Ht2)(object)g5LW.Default;
						_ = (i6A)(object)g5LW.Default;
						_ = (Sk5)(object)g5LW.Default;
					}
					finally
					{
						_ = (c2J)(object)g5LW.Default;
						goto IL_0542;
					}
				}
				goto IL_0542;
			}
		}
		IL_027b:
		while (obj5 != null)
		{
			do
			{
				try
				{
					_ = (Sk5)(object)g5LW.Default;
				}
				finally
				{
					_ = (i6A)(object)g5LW.Default;
					continue;
				}
			}
			while ((object)g5LW.Default != null);
		}
		i6A = i6A;
		_ = (a9PE)(object)g5LW.Default;
		_ = (k8D5)(object)g5LW.Default;
		if (checked(unchecked((nuint)(UIntPtr)g5LW.Default) - unchecked((nuint)default(UIntPtr))) == 0)
		{
			_ = (Wx57)(object)g5LW.Default;
		}
		else if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			while (obj5 != null)
			{
				ht = ht;
			}
		}
		else
		{
			try
			{
				_ = (c2J)(object)g5LW.Default;
				c2J = (c2J)(object)g5LW.Default;
				wx = wx;
				_ = (k8D5)(object)g5LW.Default;
			}
			catch
			{
				g5LW g5LW = g5LW.Default;
				g5LW = g5LW;
			}
		}
		try
		{
			try
			{
				c2J = null;
			}
			catch
			{
				k8D = (k8D5)(object)g5LW.Default;
				_ = (Sk5)(object)g5LW.Default;
				k8G = null;
				_ = (Sk5)(object)g5LW.Default;
			}
			finally
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					k8D = k8D;
				}
				else
				{
					c2J = (c2J)(object)g5LW.Default;
				}
				goto end_IL_0332;
			}
			end_IL_0332:;
		}
		catch
		{
			ht = ht;
			_ = (a9PE)(object)g5LW.Default;
			wx = wx;
			_ = (i6A)(object)g5LW.Default;
		}
		_ = (Jt0m)(object)g5LW.Default;
		_ = (k8D5)(object)g5LW.Default;
		_ = (_003CModule_003E)(object)g5LW.Default;
		Jt0m jt0m = null;
		jt0m = null;
		num2 = default(UIntPtr);
		if (num2 == (UIntPtr)(nuint)0u)
		{
			try
			{
				if (num2 == (UIntPtr)(nuint)0u)
				{
					c2J = c2J;
				}
			}
			catch
			{
				i6A = i6A;
			}
		}
		else
		{
			try
			{
				do
				{
					_ = (k8D5)(object)g5LW.Default;
				}
				while ((object)g5LW.Default != null);
			}
			catch
			{
				ht = ht;
				Sk5 sk = (Sk5)(object)g5LW.Default;
				_ = (Jt0m)(object)g5LW.Default;
			}
		}
		if (num2 == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (Ht2)(object)g5LW.Default;
			}
			catch
			{
				_ = (_003CModule_003E)(object)g5LW.Default;
			}
			finally
			{
				try
				{
					_ = (i6A)(object)g5LW.Default;
				}
				finally
				{
					_ = (k8G6)(object)g5LW.Default;
					_ = (Jt0m)(object)g5LW.Default;
					goto IL_04ad;
				}
			}
		}
		do
		{
			jt0m = jt0m;
		}
		while (obj5 != null);
		goto IL_04ad;
	}
}
