using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using Microsoft.VisualBasic.CompilerServices;

namespace MiniGameEngine;

[DesignerGenerated]
public class MainForm : Form
{
	private IContainer icontainer_0;

	private Type type_0;

	[AccessedThroughProperty("GoNextEveryTime")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Timer timer_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	[AccessedThroughProperty("WorkPanel")]
	private Class8 class8_0;

	[AccessedThroughProperty("BotsMoving")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Timer timer_1;

	[AccessedThroughProperty("HelpUser2Icon")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private RoundLabel roundLabel_0;

	[CompilerGenerated]
	[AccessedThroughProperty("HelpUser1Icon")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private RoundLabel roundLabel_1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	[AccessedThroughProperty("HelpPointsIcon")]
	private RoundLabel roundLabel_2;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	[AccessedThroughProperty("HelpBotsIcon")]
	private RoundLabel roundLabel_3;

	private Random random_0;

	private int int_0;

	private int int_1;

	private int int_2;

	private Rectangle rectangle_0;

	private int int_3;

	private int int_4;

	private Point point_0;

	private Point point_1;

	private bool bool_0;

	private RoundLabel roundLabel_4;

	private RoundLabel roundLabel_5;

	private int int_5;

	private int int_6;

	private int[,] int_7;

	private Point point_2;

	private Point point_3;

	private bool bool_1;

	private string string_0;

	private Point point_4;

	private bool bool_2;

	private ArrayList arrayList_0;

	private ArrayList oYvMycdjEF;

	private ArrayList arrayList_1;

	private int int_8;

	private int int_9;

	private ArrayList arrayList_2;

	private ArrayList arrayList_3;

	[field: AccessedThroughProperty("MainGameMenu")]
	internal virtual MenuStrip MainGameMenu
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CreateToolStripMenuItem")]
	internal virtual ToolStripMenuItem CreateToolStripMenuItem
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("SizeToolStripMenuItem")]
	internal virtual ToolStripMenuItem SizeToolStripMenuItem
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ContextGameMenu")]
	internal virtual ContextMenuStrip ContextGameMenu
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem StopToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _StopToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = method_12;
			ToolStripMenuItem stopToolStripMenuItem = _StopToolStripMenuItem;
			if (stopToolStripMenuItem != null)
			{
				((ToolStripItem)stopToolStripMenuItem).remove_Click(eventHandler);
			}
			_StopToolStripMenuItem = value;
			stopToolStripMenuItem = _StopToolStripMenuItem;
			if (stopToolStripMenuItem != null)
			{
				((ToolStripItem)stopToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem NewGameToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _NewGameToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = method_2;
			ToolStripMenuItem newGameToolStripMenuItem = _NewGameToolStripMenuItem;
			if (newGameToolStripMenuItem != null)
			{
				((ToolStripItem)newGameToolStripMenuItem).remove_Click(eventHandler);
			}
			_NewGameToolStripMenuItem = value;
			newGameToolStripMenuItem = _NewGameToolStripMenuItem;
			if (newGameToolStripMenuItem != null)
			{
				((ToolStripItem)newGameToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem2
	{
		[CompilerGenerated]
		get
		{
			return _ToolStripMenuItem2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = method_13;
			ToolStripMenuItem toolStripMenuItem = _ToolStripMenuItem2;
			if (toolStripMenuItem != null)
			{
				((ToolStripItem)toolStripMenuItem).remove_Click(eventHandler);
			}
			_ToolStripMenuItem2 = value;
			toolStripMenuItem = _ToolStripMenuItem2;
			if (toolStripMenuItem != null)
			{
				((ToolStripItem)toolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem3
	{
		[CompilerGenerated]
		get
		{
			return _ToolStripMenuItem3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = method_14;
			ToolStripMenuItem toolStripMenuItem = _ToolStripMenuItem3;
			if (toolStripMenuItem != null)
			{
				((ToolStripItem)toolStripMenuItem).remove_Click(eventHandler);
			}
			_ToolStripMenuItem3 = value;
			toolStripMenuItem = _ToolStripMenuItem3;
			if (toolStripMenuItem != null)
			{
				((ToolStripItem)toolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem HardToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _HardToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = method_15;
			ToolStripMenuItem hardToolStripMenuItem = _HardToolStripMenuItem;
			if (hardToolStripMenuItem != null)
			{
				((ToolStripItem)hardToolStripMenuItem).remove_Click(eventHandler);
			}
			_HardToolStripMenuItem = value;
			hardToolStripMenuItem = _HardToolStripMenuItem;
			if (hardToolStripMenuItem != null)
			{
				((ToolStripItem)hardToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("ModeToolStripMenuItem")]
	internal virtual ToolStripMenuItem ModeToolStripMenuItem
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem MultiplayerToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _MultiplayerToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = method_18;
			ToolStripMenuItem multiplayerToolStripMenuItem = _MultiplayerToolStripMenuItem;
			if (multiplayerToolStripMenuItem != null)
			{
				((ToolStripItem)multiplayerToolStripMenuItem).remove_Click(eventHandler);
			}
			_MultiplayerToolStripMenuItem = value;
			multiplayerToolStripMenuItem = _MultiplayerToolStripMenuItem;
			if (multiplayerToolStripMenuItem != null)
			{
				((ToolStripItem)multiplayerToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem SinglePlayerToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _SinglePlayerToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = method_17;
			ToolStripMenuItem singlePlayerToolStripMenuItem = _SinglePlayerToolStripMenuItem;
			if (singlePlayerToolStripMenuItem != null)
			{
				((ToolStripItem)singlePlayerToolStripMenuItem).remove_Click(eventHandler);
			}
			_SinglePlayerToolStripMenuItem = value;
			singlePlayerToolStripMenuItem = _SinglePlayerToolStripMenuItem;
			if (singlePlayerToolStripMenuItem != null)
			{
				((ToolStripItem)singlePlayerToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("SettingsToolStripMenuItem")]
	internal virtual ToolStripMenuItem SettingsToolStripMenuItem
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("AutoRunToolStripMenuItem")]
	internal virtual ToolStripMenuItem AutoRunToolStripMenuItem
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem YesToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _YesToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = method_19;
			ToolStripMenuItem yesToolStripMenuItem = _YesToolStripMenuItem;
			if (yesToolStripMenuItem != null)
			{
				((ToolStripItem)yesToolStripMenuItem).remove_Click(eventHandler);
			}
			_YesToolStripMenuItem = value;
			yesToolStripMenuItem = _YesToolStripMenuItem;
			if (yesToolStripMenuItem != null)
			{
				((ToolStripItem)yesToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem NoToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _NoToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = method_20;
			ToolStripMenuItem noToolStripMenuItem = _NoToolStripMenuItem;
			if (noToolStripMenuItem != null)
			{
				((ToolStripItem)noToolStripMenuItem).remove_Click(eventHandler);
			}
			_NoToolStripMenuItem = value;
			noToolStripMenuItem = _NoToolStripMenuItem;
			if (noToolStripMenuItem != null)
			{
				((ToolStripItem)noToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("HelpToolStripMenuItem")]
	internal virtual ToolStripMenuItem HelpToolStripMenuItem
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem RulesToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _RulesToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = method_30;
			ToolStripMenuItem rulesToolStripMenuItem = _RulesToolStripMenuItem;
			if (rulesToolStripMenuItem != null)
			{
				((ToolStripItem)rulesToolStripMenuItem).remove_Click(eventHandler);
			}
			_RulesToolStripMenuItem = value;
			rulesToolStripMenuItem = _RulesToolStripMenuItem;
			if (rulesToolStripMenuItem != null)
			{
				((ToolStripItem)rulesToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("BotsToolStripMenuItem")]
	internal virtual ToolStripMenuItem BotsToolStripMenuItem
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("StatusToolStripMenuItem")]
	internal virtual ToolStripMenuItem StatusToolStripMenuItem
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem OnToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _OnToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = OaniscTgTq;
			ToolStripMenuItem onToolStripMenuItem = _OnToolStripMenuItem;
			if (onToolStripMenuItem != null)
			{
				((ToolStripItem)onToolStripMenuItem).remove_Click(eventHandler);
			}
			_OnToolStripMenuItem = value;
			onToolStripMenuItem = _OnToolStripMenuItem;
			if (onToolStripMenuItem != null)
			{
				((ToolStripItem)onToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem OffToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _OffToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = method_21;
			ToolStripMenuItem offToolStripMenuItem = _OffToolStripMenuItem;
			if (offToolStripMenuItem != null)
			{
				((ToolStripItem)offToolStripMenuItem).remove_Click(eventHandler);
			}
			_OffToolStripMenuItem = value;
			offToolStripMenuItem = _OffToolStripMenuItem;
			if (offToolStripMenuItem != null)
			{
				((ToolStripItem)offToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("SpeedToolStripMenuItem")]
	internal virtual ToolStripMenuItem SpeedToolStripMenuItem
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem SlowToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _SlowToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = method_22;
			ToolStripMenuItem slowToolStripMenuItem = _SlowToolStripMenuItem;
			if (slowToolStripMenuItem != null)
			{
				((ToolStripItem)slowToolStripMenuItem).remove_Click(eventHandler);
			}
			_SlowToolStripMenuItem = value;
			slowToolStripMenuItem = _SlowToolStripMenuItem;
			if (slowToolStripMenuItem != null)
			{
				((ToolStripItem)slowToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem NormalToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _NormalToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = method_23;
			ToolStripMenuItem normalToolStripMenuItem = _NormalToolStripMenuItem;
			if (normalToolStripMenuItem != null)
			{
				((ToolStripItem)normalToolStripMenuItem).remove_Click(eventHandler);
			}
			_NormalToolStripMenuItem = value;
			normalToolStripMenuItem = _NormalToolStripMenuItem;
			if (normalToolStripMenuItem != null)
			{
				((ToolStripItem)normalToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem FastToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _FastToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = method_24;
			ToolStripMenuItem fastToolStripMenuItem = _FastToolStripMenuItem;
			if (fastToolStripMenuItem != null)
			{
				((ToolStripItem)fastToolStripMenuItem).remove_Click(eventHandler);
			}
			_FastToolStripMenuItem = value;
			fastToolStripMenuItem = _FastToolStripMenuItem;
			if (fastToolStripMenuItem != null)
			{
				((ToolStripItem)fastToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("LifeStyleToolStripMenuItem")]
	internal virtual ToolStripMenuItem LifeStyleToolStripMenuItem
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem4
	{
		[CompilerGenerated]
		get
		{
			return _ToolStripMenuItem4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = method_25;
			ToolStripMenuItem toolStripMenuItem = _ToolStripMenuItem4;
			if (toolStripMenuItem != null)
			{
				((ToolStripItem)toolStripMenuItem).remove_Click(eventHandler);
			}
			_ToolStripMenuItem4 = value;
			toolStripMenuItem = _ToolStripMenuItem4;
			if (toolStripMenuItem != null)
			{
				((ToolStripItem)toolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem5
	{
		[CompilerGenerated]
		get
		{
			return _ToolStripMenuItem5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = method_26;
			ToolStripMenuItem toolStripMenuItem = _ToolStripMenuItem5;
			if (toolStripMenuItem != null)
			{
				((ToolStripItem)toolStripMenuItem).remove_Click(eventHandler);
			}
			_ToolStripMenuItem5 = value;
			toolStripMenuItem = _ToolStripMenuItem5;
			if (toolStripMenuItem != null)
			{
				((ToolStripItem)toolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("CountToolStripMenuItem")]
	internal virtual ToolStripMenuItem CountToolStripMenuItem
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem EasyToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _EasyToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = method_27;
			ToolStripMenuItem easyToolStripMenuItem = _EasyToolStripMenuItem;
			if (easyToolStripMenuItem != null)
			{
				((ToolStripItem)easyToolStripMenuItem).remove_Click(eventHandler);
			}
			_EasyToolStripMenuItem = value;
			easyToolStripMenuItem = _EasyToolStripMenuItem;
			if (easyToolStripMenuItem != null)
			{
				((ToolStripItem)easyToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem MediumToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _MediumToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = method_28;
			ToolStripMenuItem mediumToolStripMenuItem = _MediumToolStripMenuItem;
			if (mediumToolStripMenuItem != null)
			{
				((ToolStripItem)mediumToolStripMenuItem).remove_Click(eventHandler);
			}
			_MediumToolStripMenuItem = value;
			mediumToolStripMenuItem = _MediumToolStripMenuItem;
			if (mediumToolStripMenuItem != null)
			{
				((ToolStripItem)mediumToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem HardToolStripMenuItem1
	{
		[CompilerGenerated]
		get
		{
			return _HardToolStripMenuItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = method_29;
			ToolStripMenuItem hardToolStripMenuItem = _HardToolStripMenuItem1;
			if (hardToolStripMenuItem != null)
			{
				((ToolStripItem)hardToolStripMenuItem).remove_Click(eventHandler);
			}
			_HardToolStripMenuItem1 = value;
			hardToolStripMenuItem = _HardToolStripMenuItem1;
			if (hardToolStripMenuItem != null)
			{
				((ToolStripItem)hardToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("StatusStrip1")]
	internal virtual StatusStrip StatusStrip1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("StatusLabelScore")]
	internal virtual ToolStripStatusLabel StatusLabelScore
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("StatusLabelHighScore")]
	internal virtual ToolStripStatusLabel StatusLabelHighScore
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("LoadingProgressBar")]
	internal virtual ToolStripProgressBar LoadingProgressBar
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("LoadingProgress")]
	internal virtual ProgressBar LoadingProgress
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("HelpPanel")]
	internal virtual Panel HelpPanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual LinkLabel CloseHelpLink
	{
		[CompilerGenerated]
		get
		{
			return _CloseHelpLink;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			LinkLabelLinkClickedEventHandler val = new LinkLabelLinkClickedEventHandler(method_31);
			LinkLabel closeHelpLink = _CloseHelpLink;
			if (closeHelpLink != null)
			{
				closeHelpLink.remove_LinkClicked(val);
			}
			_CloseHelpLink = value;
			closeHelpLink = _CloseHelpLink;
			if (closeHelpLink != null)
			{
				closeHelpLink.add_LinkClicked(val);
			}
		}
	}

	[field: AccessedThroughProperty("RichTextBox1")]
	internal virtual RichTextBox RichTextBox1
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

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
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

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
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

	[field: AccessedThroughProperty("RichTextBox2")]
	internal virtual RichTextBox RichTextBox2
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

	internal virtual LinkLabel LinkAuthor
	{
		[CompilerGenerated]
		get
		{
			return _LinkAuthor;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			LinkLabelLinkClickedEventHandler val = new LinkLabelLinkClickedEventHandler(method_32);
			LinkLabel linkAuthor = _LinkAuthor;
			if (linkAuthor != null)
			{
				linkAuthor.remove_LinkClicked(val);
			}
			_LinkAuthor = value;
			linkAuthor = _LinkAuthor;
			if (linkAuthor != null)
			{
				linkAuthor.add_LinkClicked(val);
			}
		}
	}

	public MainForm()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		Class11.NQ1E32yzjMukk();
		((Form)this)._002Ector();
		((Form)this).add_Load((EventHandler)MainForm_Load);
		((Control)this).add_KeyUp(new KeyEventHandler(MainForm_KeyUp));
		random_0 = new Random();
		int_0 = 30;
		int_1 = 1;
		int_2 = 1;
		bool_0 = false;
		roundLabel_4 = new RoundLabel();
		roundLabel_5 = new RoundLabel();
		bool_1 = false;
		bool_2 = true;
		arrayList_0 = new ArrayList();
		oYvMycdjEF = new ArrayList();
		arrayList_1 = new ArrayList();
		int_8 = 2;
		int_9 = 3;
		arrayList_2 = new ArrayList();
		arrayList_3 = new ArrayList();
		InitializeComponent();
	}

	[STAThread]
	public static void Main()
	{
		Application.Run((Form)(object)Class3.Class4_0.MainForm);
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && icontainer_0 != null)
			{
				icontainer_0.Dispose();
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected O, but got Unknown
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected O, but got Unknown
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected O, but got Unknown
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected O, but got Unknown
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected O, but got Unknown
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected O, but got Unknown
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected O, but got Unknown
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected O, but got Unknown
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected O, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected O, but got Unknown
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected O, but got Unknown
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected O, but got Unknown
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected O, but got Unknown
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected O, but got Unknown
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected O, but got Unknown
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected O, but got Unknown
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected O, but got Unknown
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Expected O, but got Unknown
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected O, but got Unknown
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Expected O, but got Unknown
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected O, but got Unknown
		//IL_0ee7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff2: Unknown result type (might be due to invalid IL or missing references)
		//IL_120b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1215: Expected O, but got Unknown
		//IL_12b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_12bd: Expected O, but got Unknown
		//IL_1357: Unknown result type (might be due to invalid IL or missing references)
		//IL_1361: Expected O, but got Unknown
		//IL_140c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1416: Expected O, but got Unknown
		//IL_152e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1538: Expected O, but got Unknown
		//IL_15c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_15ca: Expected O, but got Unknown
		//IL_1655: Unknown result type (might be due to invalid IL or missing references)
		//IL_165f: Expected O, but got Unknown
		//IL_16e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_16f0: Expected O, but got Unknown
		//IL_177a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1784: Expected O, but got Unknown
		//IL_182b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1835: Expected O, but got Unknown
		//IL_18e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_18f1: Expected O, but got Unknown
		icontainer_0 = new Container();
		MainGameMenu = new MenuStrip();
		CreateToolStripMenuItem = new ToolStripMenuItem();
		NewGameToolStripMenuItem = new ToolStripMenuItem();
		SizeToolStripMenuItem = new ToolStripMenuItem();
		ToolStripMenuItem2 = new ToolStripMenuItem();
		ToolStripMenuItem3 = new ToolStripMenuItem();
		HardToolStripMenuItem = new ToolStripMenuItem();
		ModeToolStripMenuItem = new ToolStripMenuItem();
		SinglePlayerToolStripMenuItem = new ToolStripMenuItem();
		MultiplayerToolStripMenuItem = new ToolStripMenuItem();
		SettingsToolStripMenuItem = new ToolStripMenuItem();
		AutoRunToolStripMenuItem = new ToolStripMenuItem();
		YesToolStripMenuItem = new ToolStripMenuItem();
		NoToolStripMenuItem = new ToolStripMenuItem();
		BotsToolStripMenuItem = new ToolStripMenuItem();
		StatusToolStripMenuItem = new ToolStripMenuItem();
		OnToolStripMenuItem = new ToolStripMenuItem();
		OffToolStripMenuItem = new ToolStripMenuItem();
		SpeedToolStripMenuItem = new ToolStripMenuItem();
		SlowToolStripMenuItem = new ToolStripMenuItem();
		NormalToolStripMenuItem = new ToolStripMenuItem();
		FastToolStripMenuItem = new ToolStripMenuItem();
		CountToolStripMenuItem = new ToolStripMenuItem();
		EasyToolStripMenuItem = new ToolStripMenuItem();
		MediumToolStripMenuItem = new ToolStripMenuItem();
		HardToolStripMenuItem1 = new ToolStripMenuItem();
		LifeStyleToolStripMenuItem = new ToolStripMenuItem();
		ToolStripMenuItem4 = new ToolStripMenuItem();
		ToolStripMenuItem5 = new ToolStripMenuItem();
		HelpToolStripMenuItem = new ToolStripMenuItem();
		RulesToolStripMenuItem = new ToolStripMenuItem();
		ContextGameMenu = new ContextMenuStrip(icontainer_0);
		StopToolStripMenuItem = new ToolStripMenuItem();
		vmethod_1(new Timer(icontainer_0));
		vmethod_5(new Timer(icontainer_0));
		StatusStrip1 = new StatusStrip();
		StatusLabelScore = new ToolStripStatusLabel();
		StatusLabelHighScore = new ToolStripStatusLabel();
		LoadingProgressBar = new ToolStripProgressBar();
		LoadingProgress = new ProgressBar();
		HelpPanel = new Panel();
		Label7 = new Label();
		LinkAuthor = new LinkLabel();
		Label6 = new Label();
		RichTextBox2 = new RichTextBox();
		Label5 = new Label();
		Label4 = new Label();
		Label3 = new Label();
		Label2 = new Label();
		Label1 = new Label();
		RichTextBox1 = new RichTextBox();
		CloseHelpLink = new LinkLabel();
		vmethod_11(new RoundLabel());
		vmethod_13(new RoundLabel());
		vmethod_7(new RoundLabel());
		vmethod_9(new RoundLabel());
		vmethod_3(new Class8());
		((Control)MainGameMenu).SuspendLayout();
		((Control)ContextGameMenu).SuspendLayout();
		((Control)StatusStrip1).SuspendLayout();
		((Control)HelpPanel).SuspendLayout();
		((Control)this).SuspendLayout();
		((ToolStrip)MainGameMenu).set_BackColor(Color.LightSlateGray);
		((ToolStrip)MainGameMenu).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[5]
		{
			(ToolStripItem)CreateToolStripMenuItem,
			(ToolStripItem)SizeToolStripMenuItem,
			(ToolStripItem)ModeToolStripMenuItem,
			(ToolStripItem)SettingsToolStripMenuItem,
			(ToolStripItem)HelpToolStripMenuItem
		});
		((Control)MainGameMenu).set_Location(new Point(0, 0));
		((Control)MainGameMenu).set_Name("MainGameMenu");
		((ToolStrip)MainGameMenu).set_RenderMode((ToolStripRenderMode)2);
		((Control)MainGameMenu).set_Size(new Size(450, 24));
		((Control)MainGameMenu).set_TabIndex(2);
		((ToolStripDropDownItem)CreateToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)NewGameToolStripMenuItem });
		((ToolStripItem)CreateToolStripMenuItem).set_ForeColor(Color.Gold);
		((ToolStripItem)CreateToolStripMenuItem).set_ImageTransparentColor(Color.White);
		((ToolStripItem)CreateToolStripMenuItem).set_Name("CreateToolStripMenuItem");
		((ToolStripItem)CreateToolStripMenuItem).set_Size(new Size(50, 20));
		((ToolStripItem)CreateToolStripMenuItem).set_Text("Game");
		((ToolStripItem)NewGameToolStripMenuItem).set_ForeColor(Color.Gold);
		((ToolStripItem)NewGameToolStripMenuItem).set_Name("NewGameToolStripMenuItem");
		((ToolStripItem)NewGameToolStripMenuItem).set_Size(new Size(132, 22));
		((ToolStripItem)NewGameToolStripMenuItem).set_Text("New Game");
		((ToolStripDropDownItem)SizeToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[3]
		{
			(ToolStripItem)ToolStripMenuItem2,
			(ToolStripItem)ToolStripMenuItem3,
			(ToolStripItem)HardToolStripMenuItem
		});
		((ToolStripItem)SizeToolStripMenuItem).set_ForeColor(Color.Gold);
		((ToolStripItem)SizeToolStripMenuItem).set_Name("SizeToolStripMenuItem");
		((ToolStripItem)SizeToolStripMenuItem).set_Size(new Size(43, 20));
		((ToolStripItem)SizeToolStripMenuItem).set_Text("Map");
		ToolStripMenuItem2.set_Checked(true);
		ToolStripMenuItem2.set_CheckState((CheckState)1);
		((ToolStripItem)ToolStripMenuItem2).set_ForeColor(Color.Gold);
		((ToolStripItem)ToolStripMenuItem2).set_Name("ToolStripMenuItem2");
		((ToolStripItem)ToolStripMenuItem2).set_Size(new Size(119, 22));
		((ToolStripItem)ToolStripMenuItem2).set_Text("Small");
		((ToolStripItem)ToolStripMenuItem3).set_ForeColor(Color.Gold);
		((ToolStripItem)ToolStripMenuItem3).set_Name("ToolStripMenuItem3");
		((ToolStripItem)ToolStripMenuItem3).set_Size(new Size(119, 22));
		((ToolStripItem)ToolStripMenuItem3).set_Text("Medium");
		((ToolStripItem)HardToolStripMenuItem).set_ForeColor(Color.Gold);
		((ToolStripItem)HardToolStripMenuItem).set_Name("HardToolStripMenuItem");
		((ToolStripItem)HardToolStripMenuItem).set_Size(new Size(119, 22));
		((ToolStripItem)HardToolStripMenuItem).set_Text("Big");
		((ToolStripDropDownItem)ModeToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)SinglePlayerToolStripMenuItem,
			(ToolStripItem)MultiplayerToolStripMenuItem
		});
		((ToolStripItem)ModeToolStripMenuItem).set_ForeColor(Color.Gold);
		((ToolStripItem)ModeToolStripMenuItem).set_Name("ModeToolStripMenuItem");
		((ToolStripItem)ModeToolStripMenuItem).set_Size(new Size(50, 20));
		((ToolStripItem)ModeToolStripMenuItem).set_Text("Mode");
		SinglePlayerToolStripMenuItem.set_Checked(true);
		SinglePlayerToolStripMenuItem.set_CheckState((CheckState)1);
		((ToolStripItem)SinglePlayerToolStripMenuItem).set_ForeColor(Color.Gold);
		((ToolStripItem)SinglePlayerToolStripMenuItem).set_Name("SinglePlayerToolStripMenuItem");
		((ToolStripItem)SinglePlayerToolStripMenuItem).set_Size(new Size(141, 22));
		((ToolStripItem)SinglePlayerToolStripMenuItem).set_Text("Single player");
		((ToolStripItem)MultiplayerToolStripMenuItem).set_ForeColor(Color.Gold);
		((ToolStripItem)MultiplayerToolStripMenuItem).set_Name("MultiplayerToolStripMenuItem");
		((ToolStripItem)MultiplayerToolStripMenuItem).set_Size(new Size(141, 22));
		((ToolStripItem)MultiplayerToolStripMenuItem).set_Text("Multiplayer");
		((ToolStripDropDownItem)SettingsToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)AutoRunToolStripMenuItem,
			(ToolStripItem)BotsToolStripMenuItem
		});
		((ToolStripItem)SettingsToolStripMenuItem).set_ForeColor(Color.Gold);
		((ToolStripItem)SettingsToolStripMenuItem).set_Name("SettingsToolStripMenuItem");
		((ToolStripItem)SettingsToolStripMenuItem).set_Size(new Size(61, 20));
		((ToolStripItem)SettingsToolStripMenuItem).set_Text("Settings");
		((ToolStripDropDownItem)AutoRunToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)YesToolStripMenuItem,
			(ToolStripItem)NoToolStripMenuItem
		});
		((ToolStripItem)AutoRunToolStripMenuItem).set_ForeColor(Color.Gold);
		((ToolStripItem)AutoRunToolStripMenuItem).set_Name("AutoRunToolStripMenuItem");
		((ToolStripItem)AutoRunToolStripMenuItem).set_Size(new Size(121, 22));
		((ToolStripItem)AutoRunToolStripMenuItem).set_Text("Auto run");
		((ToolStripItem)YesToolStripMenuItem).set_ForeColor(Color.Gold);
		((ToolStripItem)YesToolStripMenuItem).set_Name("YesToolStripMenuItem");
		((ToolStripItem)YesToolStripMenuItem).set_Size(new Size(91, 22));
		((ToolStripItem)YesToolStripMenuItem).set_Text("Yes");
		NoToolStripMenuItem.set_Checked(true);
		NoToolStripMenuItem.set_CheckState((CheckState)1);
		((ToolStripItem)NoToolStripMenuItem).set_ForeColor(Color.Gold);
		((ToolStripItem)NoToolStripMenuItem).set_Name("NoToolStripMenuItem");
		((ToolStripItem)NoToolStripMenuItem).set_Size(new Size(91, 22));
		((ToolStripItem)NoToolStripMenuItem).set_Text("No");
		((ToolStripDropDownItem)BotsToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[4]
		{
			(ToolStripItem)StatusToolStripMenuItem,
			(ToolStripItem)SpeedToolStripMenuItem,
			(ToolStripItem)CountToolStripMenuItem,
			(ToolStripItem)LifeStyleToolStripMenuItem
		});
		((ToolStripItem)BotsToolStripMenuItem).set_ForeColor(Color.Gold);
		((ToolStripItem)BotsToolStripMenuItem).set_Name("BotsToolStripMenuItem");
		((ToolStripItem)BotsToolStripMenuItem).set_Size(new Size(121, 22));
		((ToolStripItem)BotsToolStripMenuItem).set_Text("Bots");
		((ToolStripDropDownItem)StatusToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)OnToolStripMenuItem,
			(ToolStripItem)OffToolStripMenuItem
		});
		((ToolStripItem)StatusToolStripMenuItem).set_ForeColor(Color.Gold);
		((ToolStripItem)StatusToolStripMenuItem).set_Name("StatusToolStripMenuItem");
		((ToolStripItem)StatusToolStripMenuItem).set_Size(new Size(120, 22));
		((ToolStripItem)StatusToolStripMenuItem).set_Text("Status");
		OnToolStripMenuItem.set_Checked(true);
		OnToolStripMenuItem.set_CheckState((CheckState)1);
		((ToolStripItem)OnToolStripMenuItem).set_ForeColor(Color.Gold);
		((ToolStripItem)OnToolStripMenuItem).set_Name("OnToolStripMenuItem");
		((ToolStripItem)OnToolStripMenuItem).set_Size(new Size(91, 22));
		((ToolStripItem)OnToolStripMenuItem).set_Text("On");
		((ToolStripItem)OffToolStripMenuItem).set_ForeColor(Color.Gold);
		((ToolStripItem)OffToolStripMenuItem).set_Name("OffToolStripMenuItem");
		((ToolStripItem)OffToolStripMenuItem).set_Size(new Size(91, 22));
		((ToolStripItem)OffToolStripMenuItem).set_Text("Off");
		((ToolStripDropDownItem)SpeedToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[3]
		{
			(ToolStripItem)SlowToolStripMenuItem,
			(ToolStripItem)NormalToolStripMenuItem,
			(ToolStripItem)FastToolStripMenuItem
		});
		((ToolStripItem)SpeedToolStripMenuItem).set_ForeColor(Color.Gold);
		((ToolStripItem)SpeedToolStripMenuItem).set_Name("SpeedToolStripMenuItem");
		((ToolStripItem)SpeedToolStripMenuItem).set_Size(new Size(120, 22));
		((ToolStripItem)SpeedToolStripMenuItem).set_Text("Speed");
		SlowToolStripMenuItem.set_Checked(true);
		SlowToolStripMenuItem.set_CheckState((CheckState)1);
		((ToolStripItem)SlowToolStripMenuItem).set_ForeColor(Color.Gold);
		((ToolStripItem)SlowToolStripMenuItem).set_Name("SlowToolStripMenuItem");
		((ToolStripItem)SlowToolStripMenuItem).set_Size(new Size(114, 22));
		((ToolStripItem)SlowToolStripMenuItem).set_Text("Slow");
		((ToolStripItem)NormalToolStripMenuItem).set_ForeColor(Color.Gold);
		((ToolStripItem)NormalToolStripMenuItem).set_Name("NormalToolStripMenuItem");
		((ToolStripItem)NormalToolStripMenuItem).set_Size(new Size(114, 22));
		((ToolStripItem)NormalToolStripMenuItem).set_Text("Normal");
		((ToolStripItem)FastToolStripMenuItem).set_ForeColor(Color.Gold);
		((ToolStripItem)FastToolStripMenuItem).set_Name("FastToolStripMenuItem");
		((ToolStripItem)FastToolStripMenuItem).set_Size(new Size(114, 22));
		((ToolStripItem)FastToolStripMenuItem).set_Text("Fast");
		((ToolStripDropDownItem)CountToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[3]
		{
			(ToolStripItem)EasyToolStripMenuItem,
			(ToolStripItem)MediumToolStripMenuItem,
			(ToolStripItem)HardToolStripMenuItem1
		});
		((ToolStripItem)CountToolStripMenuItem).set_ForeColor(Color.Gold);
		((ToolStripItem)CountToolStripMenuItem).set_Name("CountToolStripMenuItem");
		((ToolStripItem)CountToolStripMenuItem).set_Size(new Size(120, 22));
		((ToolStripItem)CountToolStripMenuItem).set_Text("Count");
		EasyToolStripMenuItem.set_Checked(true);
		EasyToolStripMenuItem.set_CheckState((CheckState)1);
		((ToolStripItem)EasyToolStripMenuItem).set_ForeColor(Color.Gold);
		((ToolStripItem)EasyToolStripMenuItem).set_Name("EasyToolStripMenuItem");
		((ToolStripItem)EasyToolStripMenuItem).set_Size(new Size(104, 22));
		((ToolStripItem)EasyToolStripMenuItem).set_Text("Few");
		((ToolStripItem)MediumToolStripMenuItem).set_ForeColor(Color.Gold);
		((ToolStripItem)MediumToolStripMenuItem).set_Name("MediumToolStripMenuItem");
		((ToolStripItem)MediumToolStripMenuItem).set_Size(new Size(104, 22));
		((ToolStripItem)MediumToolStripMenuItem).set_Text("Little");
		((ToolStripItem)HardToolStripMenuItem1).set_ForeColor(Color.Gold);
		((ToolStripItem)HardToolStripMenuItem1).set_Name("HardToolStripMenuItem1");
		((ToolStripItem)HardToolStripMenuItem1).set_Size(new Size(104, 22));
		((ToolStripItem)HardToolStripMenuItem1).set_Text("Many");
		((ToolStripDropDownItem)LifeStyleToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)ToolStripMenuItem4,
			(ToolStripItem)ToolStripMenuItem5
		});
		((ToolStripItem)LifeStyleToolStripMenuItem).set_ForeColor(Color.Gold);
		((ToolStripItem)LifeStyleToolStripMenuItem).set_Name("LifeStyleToolStripMenuItem");
		((ToolStripItem)LifeStyleToolStripMenuItem).set_Size(new Size(120, 22));
		((ToolStripItem)LifeStyleToolStripMenuItem).set_Text("Life style");
		((ToolStripItem)ToolStripMenuItem4).set_ForeColor(Color.Gold);
		((ToolStripItem)ToolStripMenuItem4).set_Name("ToolStripMenuItem4");
		((ToolStripItem)ToolStripMenuItem4).set_Size(new Size(114, 22));
		((ToolStripItem)ToolStripMenuItem4).set_Text("Mode 1");
		ToolStripMenuItem5.set_Checked(true);
		ToolStripMenuItem5.set_CheckState((CheckState)1);
		((ToolStripItem)ToolStripMenuItem5).set_ForeColor(Color.Gold);
		((ToolStripItem)ToolStripMenuItem5).set_Name("ToolStripMenuItem5");
		((ToolStripItem)ToolStripMenuItem5).set_Size(new Size(114, 22));
		((ToolStripItem)ToolStripMenuItem5).set_Text("Mode 2");
		((ToolStripDropDownItem)HelpToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)RulesToolStripMenuItem });
		((ToolStripItem)HelpToolStripMenuItem).set_ForeColor(Color.Gold);
		((ToolStripItem)HelpToolStripMenuItem).set_Name("HelpToolStripMenuItem");
		((ToolStripItem)HelpToolStripMenuItem).set_Size(new Size(44, 20));
		((ToolStripItem)HelpToolStripMenuItem).set_Text("Help");
		((ToolStripItem)RulesToolStripMenuItem).set_ForeColor(Color.Gold);
		((ToolStripItem)RulesToolStripMenuItem).set_Name("RulesToolStripMenuItem");
		((ToolStripItem)RulesToolStripMenuItem).set_Size(new Size(102, 22));
		((ToolStripItem)RulesToolStripMenuItem).set_Text("Rules");
		((ToolStrip)ContextGameMenu).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)StopToolStripMenuItem });
		((Control)ContextGameMenu).set_Name("ContextGameMenu");
		((Control)ContextGameMenu).set_Size(new Size(93, 26));
		((ToolStripItem)StopToolStripMenuItem).set_Name("StopToolStripMenuItem");
		((ToolStripItem)StopToolStripMenuItem).set_Size(new Size(92, 22));
		((ToolStripItem)StopToolStripMenuItem).set_Text("Exit");
		vmethod_0().set_Interval(500);
		vmethod_4().set_Interval(1000);
		((ToolStrip)StatusStrip1).set_BackColor(Color.LightSlateGray);
		((ToolStrip)StatusStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[3]
		{
			(ToolStripItem)StatusLabelScore,
			(ToolStripItem)StatusLabelHighScore,
			(ToolStripItem)LoadingProgressBar
		});
		((Control)StatusStrip1).set_Location(new Point(0, 475));
		((Control)StatusStrip1).set_Margin(new Padding(2));
		((Control)StatusStrip1).set_Name("StatusStrip1");
		((ToolStrip)StatusStrip1).set_RenderMode((ToolStripRenderMode)2);
		((Control)StatusStrip1).set_Size(new Size(450, 22));
		((Control)StatusStrip1).set_TabIndex(5);
		((ToolStripItem)StatusLabelScore).set_BackColor(SystemColors.Control);
		((ToolStripItem)StatusLabelScore).set_ForeColor(Color.Gold);
		((ToolStripItem)StatusLabelScore).set_Name("StatusLabelScore");
		((ToolStripItem)StatusLabelScore).set_Size(new Size(48, 17));
		((ToolStripItem)StatusLabelScore).set_Text("Score: 0");
		((ToolStripItem)StatusLabelHighScore).set_ForeColor(Color.Gold);
		((ToolStripItem)StatusLabelHighScore).set_Name("StatusLabelHighScore");
		((ToolStripItem)StatusLabelHighScore).set_Size(new Size(74, 17));
		((ToolStripItem)StatusLabelHighScore).set_Text("HighScore: 0");
		((ToolStripControlHost)LoadingProgressBar).set_ForeColor(Color.Gold);
		((ToolStripItem)LoadingProgressBar).set_Name("LoadingProgressBar");
		((ToolStripItem)LoadingProgressBar).set_Padding(new Padding(4, 0, 0, 0));
		((ToolStripControlHost)LoadingProgressBar).set_Size(new Size(204, 16));
		((Control)LoadingProgress).set_Location(new Point(261, 3));
		((Control)LoadingProgress).set_Name("LoadingProgress");
		((Control)LoadingProgress).set_Size(new Size(177, 18));
		LoadingProgress.set_Style((ProgressBarStyle)1);
		((Control)LoadingProgress).set_TabIndex(3);
		((Control)LoadingProgress).set_Visible(false);
		((Control)HelpPanel).set_BackColor(Color.LightSlateGray);
		HelpPanel.set_BorderStyle((BorderStyle)1);
		((Control)HelpPanel).get_Controls().Add((Control)(object)Label7);
		((Control)HelpPanel).get_Controls().Add((Control)(object)LinkAuthor);
		((Control)HelpPanel).get_Controls().Add((Control)(object)Label6);
		((Control)HelpPanel).get_Controls().Add((Control)(object)RichTextBox2);
		((Control)HelpPanel).get_Controls().Add((Control)(object)Label5);
		((Control)HelpPanel).get_Controls().Add((Control)(object)Label4);
		((Control)HelpPanel).get_Controls().Add((Control)(object)Label3);
		((Control)HelpPanel).get_Controls().Add((Control)(object)Label2);
		((Control)HelpPanel).get_Controls().Add((Control)(object)Label1);
		((Control)HelpPanel).get_Controls().Add((Control)(object)RichTextBox1);
		((Control)HelpPanel).get_Controls().Add((Control)(object)CloseHelpLink);
		((Control)HelpPanel).set_Cursor(Cursors.get_Hand());
		((Control)HelpPanel).set_Location(new Point(75, 100));
		((Control)HelpPanel).set_Name("HelpPanel");
		((Control)HelpPanel).set_Size(new Size(300, 300));
		((Control)HelpPanel).set_TabIndex(0);
		((Control)HelpPanel).set_Visible(false);
		Label7.set_AutoSize(true);
		((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
		((Control)Label7).set_ForeColor(Color.Gold);
		((Control)Label7).set_Location(new Point(181, 275));
		((Control)Label7).set_Name("Label7");
		((Control)Label7).set_Size(new Size(52, 13));
		((Control)Label7).set_TabIndex(14);
		Label7.set_Text("Create by");
		LinkAuthor.set_ActiveLinkColor(SystemColors.ActiveCaption);
		((Label)LinkAuthor).set_AutoSize(true);
		((Control)LinkAuthor).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
		LinkAuthor.set_LinkColor(Color.Gold);
		((Control)LinkAuthor).set_Location(new Point(230, 275));
		((Control)LinkAuthor).set_Name("LinkAuthor");
		((Control)LinkAuthor).set_Size(new Size(54, 13));
		((Control)LinkAuthor).set_TabIndex(13);
		LinkAuthor.set_TabStop(true);
		LinkAuthor.set_Text("starkov79");
		Label6.set_AutoSize(true);
		((Control)Label6).set_Font(new Font("Courier New", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
		((Control)Label6).set_ForeColor(Color.Gold);
		((Control)Label6).set_Location(new Point(101, 183));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(96, 16));
		((Control)Label6).set_TabIndex(12);
		Label6.set_Text("Multiplayer");
		((TextBoxBase)RichTextBox2).set_BackColor(Color.LightSlateGray);
		((TextBoxBase)RichTextBox2).set_BorderStyle((BorderStyle)0);
		((Control)RichTextBox2).set_Cursor(Cursors.get_Hand());
		RichTextBox2.set_Font(new Font("Courier New", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
		RichTextBox2.set_ForeColor(Color.Gold);
		((Control)RichTextBox2).set_Location(new Point(14, 202));
		string text = Reverse("0؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛30E00؛C00010020؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛300E2000300E2000300E2003300؛E600F6009600370027005600650002009700C6002600D60056003700370014001000800083000؛300E2000300E2000300E2003300؛E600F600960037002700560065004700360057004600F60027000500100080004300؛E600F6009600470007005600360087005400E600F6009600470036005700270047003700E600F6003400؛؛5600D6001600E4004700360057004600F6002700050010006100C400؛C600C6004600E200970036009600C600F600050016003700C4005600660016003500؛5600D6001600E6005600C60096006400C6001600E6009600760096002700F40010002100C400؛؛؛؛3700B60027001600D60056004600160027004500C600160076005600C40010001000A200؛؛1300230003002300؛4700860076009600270097000700F6003400C600160076005600C40010005000E200؛C600C6004600E200970036009600C600F600050016003700C4005600660016003500؛5600D6001600E400C6001600E600270056004700E60094001000210044000؛300E2000300E2000300E2003300؛؛E600F600960037002700560065005600C6009600640010008؛300؛E600F6009600470007005600360087005400E600F6009600470036005700270047003700E600F6003400؛؛E600F6009600470007009600270036003700560044005600C60096006400100061004500؛؛37007700F600270086004500E600F6009600470007005600360087005400E600F600E4000700160027007500؛؛5600D6001600E4009700E60016000700D600F600340010007100E400؛؛B600E600960035009700C6000700560025003600E600970037001400؛37004700E6005600D600D600F60034001000F00063000؛300260043000300030003000300030010؛208C00؛F6006600E60094005600C600960064007600E600960027004700350010؛20CE400B00؛؛؛E600F600960047001600C6003700E600160027004500؛40004200؛؛F6006600E60094005600C600960064002700160065001000؛4400؛؛؛؛؛؛؛2000؛4000؛؛؛F300؛؛3000؛؛؛3000؛10؛EFFE40DB00؛؛F4006400E4009400F500E400F40094003500250054006500F50035006500؛4330C8؛؛؛؛؛30C80010048500؛8400؛؛100؛؛؛؛؛؛؛80؛300؛1000100؛؛؛؛؛؛؛8؛81000؛1001؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛4020052FF00؛؛C6C646E2565627F63637D600E69616D4C6C64427F634F500؛؛؛10020C0؛؛؛؛؛؛؛؛؛؛؛2؛1002EC00؛؛؛؛10028B00؛؛؛؛؛4B0544140544140500؛؛؛؛؛2047563556362757F637562556D69647E65725E23756362757F6375625E2D656473797353293830356433393136353365316737326D3E656B6F6459756B43696C626570502C2C61627475756E6D356275747C6573402C203E203E203E223D3E6F6963727566502C22696C627F63637D602C227564616562556362757F6375625E23756362757F6375625E2D65647379735C600؛1900؛10EBFEACEC00؛4B00؛4B0544140544140500؛؛؛؛؛2047563556362757F637562556D69647E65725E23756362757F6375625E2D656473797353293830356433393136353365316737326D3E656B6F6459756B43696C626570502C2C61627475756E6D356275747C6573402C203E203E203E223D3E6F6963727566502C22696C627F63637D602C227564616562556362757F6375625E23756362757F6375625E2D65647379735C600؛1900؛10EBFEACEC00؛4B00؛؛F5F55636E6164737E694F5F55637F60737964431F5F55636E6164737E694F5F556471656273421C6F636F647F6270547E65696C634074747840716F635E237C6F636F647F62705E23756369667275635E2265675E2D6564737973543001016E0E0E0E010400270؛37D627F664E2473656A6F6270597D4E297D421F5F55636E6164737E694F5F55637F60737964431F5F55636E6164737E694F5F556471656273421D627F664E237D627F664E23777F646E69675E2D6564737973591001085؛87F626478747600010B0؛465676E61686344656B636568634E0001031؛1387F62447875645860756D4C0001011؛2387F62447875645860756D4C0001011؛1356D6568645860756D4A00010F0؛1387F6240757F62774860756D4D0001021؛2387F624B636568634860756D4D0001021؛1387F624B636568634860756D4D0001021؛13E6F647475724860756D4B00010019328111010026000؛؛؛1080؛3776E69647475635E297D4B00010010؛3E203E20313E263139027F647162756E6567456C6966456C676E696353776E69647475635E22756E676963756443776E69647475635E23727F647964654E2F69646574735C61657379665E24766F637F6273696D4B40010A500؛؛200010800؛3E203E203E2631380275646C696572456362757F6375625465607974597C676E6F6274735E237C6F6F645E23756362757F6375625E2D6564737973533001014؛3756369667275635265675E297D4E0001031؛37D627F664E297D4800010D0؛27563755E297D4700010C0؛E6F69647163696C6070714E297D4E0001031؛2756475707D6F634E297D4B000100100؛10405128111010026000؛؛10001080E0E0102002500؛3E203E203E2131380564716C607D6564597D4A0001081C621؛4080D4182120141821151821D418211318111318115318215E0821A070C180072107210721407090072110A04007210721800721407090072110100250800721207050072160305D0811C1C1103000805D08115D0811C1C1104000B080C1C120005080C113181120007090281110100260902811C1102000708621؛40C0D110100250161811C0502821103002A05028210002505D08115218211020029080521821100260102821000250DF18210002501F182110100260805F18211002609F18210002501C0811D1101002705F1821000250801318111002601F1821D4182120990821202013181199082120205D08111318111C0811D11C0811D11318118080131811801C0811D180805C08111518215318215E0821A170F31418211070501C0811141821100280D318211070501C0811D31821100280DE181110100260D2182180D21821131811805070D08080808080D218215002A080131811D2182120029086216030131811008250581811C1102000709E1811101002609E1811C1102000701E182110100260C11318111000604621؛40C؛2305518110002505D08115D0811D31821103002C0D41821551811D41821805318215E08216070215E1811101002605D0811D1D31821102002A05D0811D1141821102002A00031D10002505D081110DD182151805D081110DD182151805D081110DD1821513070315318215D08115D08115D08115D08115D08115D08111C0811108002B1551811141821151821E0104002D0C1E010024080C11002405D18210002501D1811101002605C08115D081110200290DC181100025020931821131811D41821805070D09C1821C11020027013181110705046216030131811C1C110300080D91811C110200070C521؛40D418218020141821151821D418211318111318115318215E0821A070C15C1821000250805C18212020562180207070C006218006210621407090062110A04080062106210621407090062110100250062180207050C521603006216030D4182160408521؛40131811000250C1C1E02000508020201C0811D1931821805318215E08218070312080800120407070808080307050802080307050852160301C1811101002601C1811C1102000705B1811C110200070C11C08111000604521؛40971821C1102002701C0811D12020201B1821801318115318215E0821907061208020201B1821507090151821101002601518210002505B1811101002605B18111070505B18110002509B182110100260801B18219B18213070901B1821101002601B18210002505B181160401B182160409A182110100260C1DA1821C19A18213002A081C11020025020C1C1C1C1C1180821C1C18000D0C1191811C1C1C1C1106000B01A1811101002601A1811C11020007020541811C110300080C421؛40D9181110100260D0D01000405D0811191811100080951821191811141821151821E0105002015318214311431120D41821131811805E0821807041052110A04000E100E100E10100E1301001C09818219818219818212000B005210521052180407090052110100250052180207050C4216030052160305C0811C1102000704421؛4053182184111C0811D1151821131811805E0821707051841110100250841110704084110002408411603080131811C1200070C1C1C1103000600421؛40581811101002602020D1180821D1E0D1C1D1E0180821C1C1800031C1000230141821؛50D21821141821102002905218215318211000805318214311151821131811805E0821607011C15D0811100060D51811C110200070C1551811C1C1C1C1106000B0808080801C0811400090C110100040C321؛405C08115D08115D08112000B05D08115C08111000805D0811؛5056210002405D08118020307070971821101002605718110002505718111010026095210002405D0811201002605D08110002501718110002502020802020131811207070B0D61821101002601C0811801C0811200090131811D3182110200290531821000250C01C08111C0811131811104002D0C1C120C1300060161811C0E010300280951821551811141821151821E010500201D5181110100260131811551811100080131811141821102002905318212020204311151821151821151821D41821D418211C0811D11C0811D113181180E070529418211010026020541811102002701C08111070501C08110002501318116040431160308060202060205D081160401C0811604080808080D31821105002A080808080C1C1106000905D08115D0811C1103000A0C0C0131811C1104000908080C180C1105000808321؛40D21821D31821102002901C0811D180131811531821104000E0141821101002605؛23080201C0811801C0811D180807070E01C0811D1131811531821103000D0D218218080131811D218215070D08080808080D218215000A0C0C01318111030028080808080104002705D08115D0811102002908080D21821D218214070A080131811D218212000908050D1100050808091182180911821105000C080801C08112002705C08110002508050D180200060801C0811808080805C081150D18050D180808050D1E070715E082150D1100070E050D1100250D11821؛5050D1209118219118219118212000B050D12020808080808080808050D150D1D07021E050D150D1200070832160305060204521008240C3210082404421008240C62100824004210082403010182110026030C1C1200050C1C1C120005051181110100260511811C1102000709C0811101002609C0811C11020007020C1102000508411C110200060C1C1102000501C0811C1102000705D0811C110200070C221؛40E0؛30E0D110100050E0D1107040E0D1؛40803010004080E0902000508080E0200250808080101821E0507090E0E0100040C1D1DF0811E0C1C14000A01B0821؛50E0E0E0200050E0C1100240180821D1000260801010004080808020025050D11B08211000709E0821D100026050D19E08211808211B0821805E08219A08211E0821807071E0E0E010300060E0E0E0103002604521101002504521000240C32110100250C3210002404421101002504421000240C62110100250C6210002400421101002500421000240DD0811101002609D0811101002608080801C08113000805D0811101002605621101002501D0821000250C0C0102002501C0811؛505C0811101002608080102002501C0811101002602080207040C2216030E0602045216030C321603044216030C6216030042160309B082160408221؛4082216030422100804042211070404221؛405B08215B082110008042216030DA08210080509A08210080500221؛40DA082110100060DA0821107050DA0821؛501B0821E0102002701B0821000250809A0821209A08214070A09A0821؛5002216030DA082160409A08216040C1؛30003110100250003110A0400031200031105A08215170003110C12151602000310031307070C160200031105A0821516080C1C1202000502000E120705081216030C180100040E01070301808211070501808210002508؛230C1C11000402010703000E1011010100370C110100240990821E010200270E؛2309908210002509908211010006000E110A04000E100100150C1C110200250E0D1E0E0200060C1201002405808111808211000802؛23000E120E020D72120202000E17070B000E100E11010017041216030972160308121008040412100804057210080408021008040C0210080400121؛4081211070408121؛4041211070404121؛4057211070405721؛4080211070408021؛400031000240C021107040812110C1215160412110C1215160C02110C1215160572110C1215160802110C12151608010703010؛3001216030812110C121516070412110C121516070572110C121516070802110C121516070C02110C121516070C021؛4020؛30C0216030A3A05D11F7F5F30B800؛3E203E203E233700010C0؛642303632493340313247383D293136424D243245343D244143393D24383631443536424420010922010100240؛؛1050؛1323032340001090؛3777F6278645E6F696470756368754E6F6E407162775610010B1؛B6E6963597C607562536E6973714E0001031E010100240؛E6F696470756368754E6F696473657274737E6F634510010A1D11110100250؛؛10700010801؛230103777F6278645E6F696470756368754E6F6E40716277561204500100010E18010100240980E439165C5A77B8000؛؛8000108000F6529B01E543FED9B404D37929931C4B000؛؛200020002000200020002D0؛5230؛E600F450؛1600D600F6008600160045D0؛66006600F470؛560076001600D60094007700160027004431؛470047005600C60027001600D4F0؛1600E600160046002700560065F0؛1330؛27300؛330؛530063002400630064006300630073005400630093004391؛37005600360027005700F600370056002500E251؛270056004600160056008400020026005700350002004700270056003700E6009432؛23008700F60024004700870056004500860007005600D491؛13005600D600560086004500860007005600D451؛860076009600C600270024D0؛13008700F60024004700870056004500860007005600D491؛13008700F600240007005700F60027007400860007005600D4B1؛1300E600F6004700470057002400860007005600D471؛23008700F6002400B6003600560086003400860007005600D4B1؛13008700F6002400B6003600560086003400860007005600D4B10010؛37005600360027005700F600370056002500E200E600F6009600470007005600360087005400E600F6009600470036005700270047003700E600F60034F3؛E600F600960047000700560036008700540027005600E600E6009400560056003500F5003700D6002700F6006400E60096007553؛560047001600560027003400D6002700F6006400560067009600370027005700360056002500F5003700D6002700F6006400E60096007593؛3756362757F6375627E23756362757F6375625E2E6F696470756368754E6F696473657274737E6F634003756362757F6375627E21783E637A5A4162396347617876343535695E2E61466A643B6B4C446F4A4D667349564E6D40056475726962747471436964716473546165627864500564757269627474714E6F696473656C6C6F6340757F6277497D40056475726962747471447E656675447C6571666564400564757269627474714867657F6278645075647352756767657265644005647572696274747149747275607F62705867657F6278645465637375636361400564716473556C626163777F6272427567676572656440056475726962747471456C626163777F62724275676765726564400564757269627474714465647162756E656742756E6769637564400564757269627474714465647162756E656742756C69607D6F634005647572696274747145646F63427563755E6F6E4275676765726564400E67696375644E2C65646F6D447E656E6F607D6F634E2D65647379735005647572696274747144627F6779756B407C656840056475726962747471456D616E456C65746F6D4564696840056475726962747471456C65746F6D446271646E616473500564757269627474714E65646469684275676765726564400564716473556C626163777F6272427F6479646540056475726962747471456C626163777F6272427F647964654002756C69607D6F634E2D6F6445646F634E2D65647379735005647572696274747145646F634465647162756E6567400362373276674260746941335763466B4156624008713D6857633568586A514337657A5B423E47400A6135414152775859497734576E6240777536500A46645F44485B6555546A5757626F666F62356003345641775E685D6248415977665D44464C617009303A557D6B64534240314667675767417C6760055A40333834356C427C446E4760787B4F644260014377485949356F4D695003696E655957556E4658500E443546723945627532700E4955393854656D6751700A42514666516568387D4001394B445B474566797860086757405A6C6557425F6F4F4769487142586250034952796B424563376370057F44705864556C6A62600A5A497635733561455340037155414D62656C6466700D4C617567686D673252585057626F6A633269500B6E6E603F465669777C44564761307B657D65400437547F4657394831725243776B47636A43564007396253616965754754483947696468546D44400873327750557B44403377716763525F4945397009487D6244563547454A67407767486473303B600743585134393A57477937353765335D445246400A5257586D6368317F68663C47643430523861500F6644635E6D626351315941576C686153776D600D4164444757734E47603C65676447554D457740094359626142464D6A48774C67605A4B633A4550076636486D6156473D435948376353715131674009613C62685651587974617477697256664976600862685031414E6349497C6A676858756577757005657A4E6A6444616E66726257607B6E65667540034854737169346B4C66513A5764757A666A6460016E424A435B426273597467776A5863625174400458583058364A6A4D416F4F67637756544761700B473D655C685366793F6A643765415130516B400875646E6944656473656C65635F54756760055B4A4073763547434671676761574C62763070047E657F634261645F547567600638644137643E66337A446A476B623163347970057F6C64664242784A674E423761333160333E600D41387236483C6538636559576F465467755840047E656D6E67696C61426164500753594D6D4136455472786A7A435D4443695D400961536465373646305A567E6A476D47736A6540046E456563726468787460554A44475763484F40046B646054686B64434854584A43367677394B400A6879353E6B4C68743677796A41505675723260037E6F696479637F605F54756370097C696D6166447E6F6640097C696D6166447E6F664F5475676002756070755F64500567616D6947716274400875646E694567616D694F547567600E6F696473656C6C6F634567616D6940037567616D694F547567600473796C4567616D69400473796C4567616D694F547567600D6F64747F624F54756760007F645F5475676004786769625F5475676003727F6C6F634E6F6964716C6F607275647E694F547563700E6F696473656C6C6F63456761605261645003756761605261645F5475676003727F6C6F634F54756370056761605261645002616454656473656C65635F54756760056A79635D6564794F547567600473656252616454756740046E656C62427F6C6F63400968523D4E6355663643600E62695148507563777150056A79635D6564794F5475637005646F6D456A79635261645005646F6D456A79635F547563700277307C49603563565A60064876757B6535643357700873583F42595D41773057365A46467F4B684150056C676E616473656259716C60737964400639454476767974503775703A456977534A69700343614574453172684343355A4E4533326877700C4C4D6F47657437765631646A4A5E4373466F40056A45666A54424A477D4D414A477569416E4870097C62635778307356724C467A47424465535B400D6B643D6B607D46476539436A4665353A4E496004635A4147607846347F41424A4570336D487760034E64775A517A40546139493A4247387346555005646F6D477162744F5475637005646F6D47716274400955544770794244417576463A414931573E69500D656479477162744F5464616007425433546A6246645931727A4D63577754335002665E61324F6039383E42744A474C4869626640005A4A4462733E48653172634A4E426053724A700938325C4F673730783145685A445C67303356400C60394957787C476E67605B6A49407F62464B40044479403771716755364C486A41533B6A4670700C416A6D663A5C68686735587A4849337F4579700A5E617C44465977577056473A4975387A56417001666150776E65414F60743B4A447152455075600362626351567175317432613A4277647E6E6160097B42486847745D495B63374A4C685A657F6350056C676E61647365625F54756760056C697473587F624F626D6F6340056C6974735E677F64407F62744F547563700478676965684D6564794F5475637002756C646E6168447E6566754D6564794771627440067E4774523575615C6960094B43673F6775683E42500E6F67697C6F6057716274400E6F67697C6F605C6C69664009716272714F6450036962756E65674E237E6F696473656C6C6F634E2D65647379735001306473796C40013A664A44415568423370056C676E61647365625375736F664771627440046E657F62776B6361624771627440027F6272754473656A6F62705271656C6340047875645D656479447567400C6F62747E6F634473796C400D6564794F547567600875646E694F547567600E6F696473656C6C6F634473656A626F40037D6564794F54756760056C6974735863716440056C697473586371644F5475637003746E657F624F5475676005647164735D656479477162744005647164735F5475676003776271447E6566754D65647947716274400262624456795561627270056C676E616473656259716C607379644F547567600875646E6944656473656C65635F547563700C424A52535175665A60700262546C6F4275635374500039477543654631753E41426A48703034635050045263626F4F45644D6C40034748393D4C45624367500B4B4035414469695C64427D6A4078746167597007605D65727749647A6F46717A455236713876400878445954537A513D4278357A437947335865400648643C60724071675A407D4A49753259485070066F643057546A54617839335A4A4732537C634004707B414775325A646E41333A4058366D455640034E4634613761315C4564745A4867684660527002523658564F6F6D6B6431475A4E6A51647558500251567940515B6B6E6269597A43717161355850077A694B6156356C64556B466A4246396152787005744257553334776B41654E4A405939713D6470035641413E6454516656377F4A4A59374C4554500E614B653B60556961774D605A4758354C485E6003345338654244697C4932664A416151697960500A48693C6A505869655172637A47725746593B400674795248743972593E4007765536533849784C445004656471656273456C646E616843794F547567600478756E45667F6D40047E65627275734F54756760027F647162756D657E6544756740027F647162756D657E65494007785B49503559755B6A60037F4760784A59703C48700E4D4269685369797F6770054746434B4639754560700136544266585979647E4009767454746964776A4464494A4C627A6653367006776954797A45644769500B4A415142556563346E60043174777C49756538356006423A43476375666F4540076245505A4A7972453A7002656865665B69733A51400A677C415769623B65354D416A42737077483B400A68353463613A573D6875407A4A607A6E49744000523C6A5570537E6B4A4C453A4361617655347009626D6867784A414C68763C4A4B4339757F664007415B646278333A446D64315A4C48614075547000526462736436616D4960356A4F6236784165600671537A464E4D676471454C6A4868593F4E4E400973333F4B44793831685F683A45347654717560056C676E6164736562547E65696C634F547567600F4464644A683971716940056C646E61684564716562734007444E426869697761667000316D6E4636497A6150700037577F696E497E627F60017934457F40597A555F4003687175637879753E49700458334A583A697E4434500059583A453454463E4638747A42716F445275700071574536323976405B6004393F6D4734797150394005543237535D4979325240027C663A6563497270515004476664636259714A6B6005603378436A42503138676A6A4E6A5D69564B40003350795E43477072487A425A4235564F65766002707172574050586076703A5A417545683054500868425775785D68313352377A456F673D694F40003867774357554D696F6A4F6A44495052634A70036B47715A697731446568443A46485079435670056C697473527564627F624F54756370056C697473527564627F62400C4D6E683F4B4866647260776A434A414C6143500E67696C61447875645F547563700279726E456830365641643A4A4440354D6973700C42477272503743435E61723A4B695965783D400370367245435073565551595A4258463A62615001495548514072565F61495A72307970733746700265427963525B6C414573684234643461444D40056E456B476633567F475C69623339666557784003566C64694230734334555E623F4F457244566005793374724E4162335A46754234617831413450023D2433325F5F542164626D616C4F50013D22325F5F542164626D616C4F500974707D6540056E696C69647C657D4F547563700071627754627F675F54756370025435444C4F497155417003775651755C4977385B400C6C616C657549737472600375736F66400375736F66447F674E6F40047E6F664F54756370047E6F664F547567600465676E616863447E6F664E6F40027F6C6F6345627F664F547567600465676E616863427F6C6F6345627F664E6F400465676E616863427F6C6F634B6361624E6F40046E657F62776B636162447E6961605E6F40067F4C657B6269737335700C446836696C69737845600F4369487C475971436A7008383833466139723162400744636348346977735240087356795136597C635F400864776E656C48716D4F5475637005637162487F62447875645007353C666C67497771737008327E4C66735971697A700271686344627F67737371605D65647379735563755F5475637007703B4779303979785A400A41337F42353972643A400465676E616863447875645F546461600465676E616863447875645F55667F6D65627002756C646E6168447E656675400076314245427A40763950014C6E6355615A48533A400658325A473B675B456F693652337D6861484450044E4762624669784D45500A69727C686B4978724160047E656D6E67696C614C61647E6F6A79627F68400858517E41673970346F400234766A4861497C4331600C613A697C424977333950087F624478756450034A623A6954597D684650056B6F667E6940047C65737562536E69737145647167656C656440056B6F667E69446E65400564716473536E69737145647167656C6564400B6361626C6C616345647167656C6564400B6361626C6C6163436E697371400275646E656370047C65737562536E6973714940056B6F667E694E6967656240027470547E6940043B4F497755566D6E4242403236573759407170046136705B66355B46745675523472357A69356009366864334D6B62375962646235485861605F600662375A637A51765973324142317F49317A43600A66645D6B43445A48334376723076734B4462500B663D63713755416148563362303654316F48700465625F5475676008765C48577B48485363714242357946735A50700A486F496954597E66344B6932316935486547500A47615663437532314158463236397B497434400A6257423E48507B6855647272305C48367B61500E656562774F547567600C68344C6862797B636C447442317A6171596560026D48323276353C4576615342324A51313943700974796C616571576E696479637F607D6F634F547563700974796C616571576E696479637F607D6F63400963584A47595E4A4D45516852307C473D4E4250085443545353425C477C454B623D6538316565400B653A44795B4058637D613862377563386D69700D6A4976386769336A657558723E6364415279700E4D4175586A61555C6A57373236447857565E60084633327B4F477F69694E6B42364D48437F4A70005659485E42647F63716A6132314752717C4540016D6246795968335C6231474234395163487E60047875645E276E69677162744E2D656473797350047E6968476E696275646E65625478756450047E6968476E696275646E6562547875645F54756370056C62657F6440046E657F62500864716D4006447E696F6050027675524362797050755005676E6168636875456271607D6F634004656B636F6C6275647E6940056E69626D6F634005647167656C65644009323D4641515978667E400B63696C634E6F400478676965684F5475637008647469675F54756370056A796375625E6F40076A5E6F605A497C617160064379326B4569744735400465676E616863447875645E6F400262715053727032546863526233487B6158414007777A4636357977376570015F607A4167797842317004575A5A607D6973554360046C6640383472544E60784D623679695C41466000517946745170775F6262617235623865535550015379517951567466466F65723177793B6434700C446F49494435336D6B6D4D423A693C427246600336544C6F63414054463D63523962337346485001314B425B61665166375A4332314B68523459600277587B444E613E47434844523C603457625460093074627963723B4B4F4037523648313D4A695004683F6A5B4A726076400B4C4371524B64787170007572646A6A6A54743E6F49723250556C4F455003693A6337697970756160054B443C64764368656F4B4662325E436565354004313B4038675E676C62683E42334C677572396008713A53475C43524B42667F42303672715860500D635137764A5478643C417052344D6579484750026E45607F41416271513746423C49416F605670083D61744C447F645670763372357A473F4351700154697C625651503273775942346B64314866600032356D68414577796E4751623F4E6A6D613C600279473E494D4B4D63703870723B44563C6059400C66335E6148477539533E453236645E655267700F6D60556A6955415A5850315233545274587A6008384E4762665973317139656233377E41533660057933524976365059346A6C423440737C683D6005647968675F5475676005646F6D476E6968647F6F6D635005646F6D476E6968647F6F6D635F547563700C6C61634564716C40076E69646E69624564716C47756E40056E6F6C6340097162774F547567600375686375727240027F6C6F634B6361624F54756760086471605C6C6966400567616D694D6F627640005931785C603E4F6243315C6237685B6A4354500F67465835544B6C6250054B6148793A63326A537C48323A457A58627850064E6777757975524776664472317258645147600A4E654258376C446654313A62373245516D6F600371637A577037545443593252356E4A61464F4004703531586E61675755355A523A64597762727003566F6D487A477268744747723E4B69755357700E603476727A69463751467F62315C477878477008557751546159374E44487432323A595A4B4C6007773141645269356158317762353977683136500151634E4A4A42525549477A4231403440307850043F42453573364A4964307232387F4F60717E600657375742626074454748495236423367463070087333474965465D4B47357A77587960567E40047A68536855585D413953584343546A4E4350043075313572576D66537269684E645F6148500A51563A4C6B46747868394E634C6448547B4004705948687A594471796C65463F493755605006726755624C4642675D6F66545E68697773400D627F66447E656271605F547567600C6F62747E6F634564716562734E6F400E6F6964736162747265735F507F60047963696C6078754F507F600E6F696479637F605563757F6D4F54756760047E656271605F5475676005667F6D4563757F6D4E6F4000755563757F6D4E6F40056671656C4563757F6D4E6F4003776271447E656675400275647E654563757F6D4E6F400564716473577F646E69675F547567600564716473577F646E69675D627F66400564716473577F646E69675F5475637005637F6C63400D627F66446E696640037E6961647E6F63400E6F696471636F6C4F54756760037E6F647475724563757F6D400E6F647475724F5475676003776271447E6566754563757F6D400E677F644563757F6D4E6F400271656C6340047875645F5475676003736968607162774F5475676002756765647E694F6450037E6F69637275667E6F6340066949400E6F696473616275647E6940056C697473547E6F6640056E696C4771627440076E696274735771627440047E656D6E67696C61456E696C4F54756370047E656D6E67696C61476E6962747350047E656D6E67696C614F5475637004716D627F66476E6962747350047963696C607D694F507F6006456C676E616473656250056C676E61647365625C6C696640047E6F66400863757272447E6569646162774271656E696C4003776271447E656675447E69616050047E6961605E6F4003756C6974735C6F62747E6F6340056C697473547563500465627566666572456C62657F644F547563700548757950734C4566700930714869325866375005647164696C61667E69400A5B66453969635F4F4005766341365649764D6008777740595B693160713230367C6D66683350036B4653703A543D675009765957743361456860096A4078574F65446C60003670503964325360700268763E643841466960043E43575A686B644860046168777756367A4D400B655A696078533C48600C693D4A53355A6F65700D6954494D423A424A70064C6E487B4479595140056C676E616473656257716274400A6336517853363556393A555F627353375950013138334758495239677474624840586E445009547747515070515A5477314960767638426003596D674430516D664F6F66764A6666613D6002384A567E673949555832736B643639776250066875487743426562755B4247327672667260086471605771627440094645495457603760500863757272400E656050086375727244696C6F6350074F54756760024F54756760025F547567600373696860716277400232353E433E435147600E64637331305A41754003627144646140056E696C44646140095F547567600478676965684F54756760085F54756760056C676E6164736562500442376E69677162744E276E69677162744E2D656473797350086471605373696860716277400A577167476671453070026762714F645009707F634B636F6C6240027566666572400C6568796054756740056A79635F547567600567616D694008647469675F547567600233347E694F64500275647275667E6F6344796240017D42575C48744B4F4003756479724475674005646F63696E655E6169646E654769624F54756760076E69646F636E6540097162727140097162727149707F634004367242357A67523560024C44385D65365656624039375D67527568700F5F55657C6166700C4169385847656465774001387F62447875645860756D4002387F62447875645860756D4001356D6568645860756D4001387F6240757F62774860756D4002387F624B636568634860756D4001387F624B636568634860756D40013E6F647475724860756D40046E656070714007713D614A4A46786478453342775672665F40013A6260376A576E65743238593D647240584009756B49736E65627160737E6162745F547563700953646962326837374B6F6B62485469405450056C697473527564627F624D627F664F54756370056C697473527564627F624D627F6640003B66793861627242583158697768664E6270056935444F614533386572587E643438577D60037E6F69637E656D6964456C6163635F6475714F547563700370564338385670774535573E48786155784006393954657452334257395B437F616941395001383F654336613F483B67513073614644637005543D45617C423B4D476377494D6B4C614E60054840547C6256505431663269646748476B40025A407E4A46394E6365673D6965673B687A600A455370785667326260355171653274407170047951743D6350594A626445785554474346700F4632366E45384C4572675D467831654B68600A666553546575594F6554535B4E6368745B4002333A424434494B6972437339777535796460086B4E4A6160337252425F4458383B66714550076959453E47307A633E6D4752395861417870046251714532697977776A697C6079675840500F46475834316B495B683956656257443165600379373E617B607F6A63503E4F694F4351616007365C4C4951447856426A6F485163436A59600A6679743F646B4349700147565C665131525470057161353949445350700864776E656C4F5475676002716863400278634003776E69627473500233347E6945500233347E69455F6450047275667E6F6340076E6962747372657350047875645E2D6564737973500275646C696572476E6962747350043A5747616658376750056079745C6C616340056D616E49724C6C61634004656E6F696372756650097C626D656373714972747E65447567400471636E6F63400473656A626F447567400375607974547567400479687540047E656D6E6F6279667E65400075656C6350076E696461656278645E2D656473797350046165627864500478756E4004616F6C4003746F6864756D4475674005647972400F666E69446F6864756D4000716D647962400D6F646E616250005776426971646676500251783E637F656A5A41700239634768743566343D60056B6A656F68456333664003474742567865667B44600C48564564563566745E600345635B693855696A6A70045935327C6555637763400877677558323562344C400567674654347563513940023755594E6D456A5479700D4640716833456F6333600E636840733255603D656008754938334E656465754008455443635965676333700E6F6F62716D4F5475676005646F6D456C6163635F6475714005646F6D456C6163635F6475714F54756370056C6974735B636F64400B636F644F547563700B63616C624F547567600465625B6271644F5475676004757F69716C456D6573756250047E65627160737E6162745F5475676004757F69716C446E656073757350056A7963547E65696C634F54756370026762714D6F627640056D616E4F54756370016963786365764F547567600E6F696471636F6C4F54756370047E696F60500E6F696473656C6C6F634C6F62747E6F6340037C6F62747E6F634F54756760056C676E69635006456A796350027F6C6F6345627F664F547563700275667C69635F54756760056A79635F54756370056A7963500875646E694261645F54756370076E69677162744E2D656473797350027F6C6F6340027F6C6F634B6361624F54756370047875645F5475637003713C6F61474D496D60056C6261637F607379644940015759346271593642493A605F4573646076700740355967783C46475005513831685669626640063958687A6B465B487004705E4A685739454D40043247696D61423779500936363970524E694140073F65786D44544E6450013A676643433447587000763142454260763950014C6E63556C68533A4002756E6961647E6F63494008715C68773939703F4003776E69647475635002476073333672526270347647505441377570045743443C43426175793A5373714030774E4003776E69647475635F547567600460583848585473726251394F67396A6D4E40047C6571666564400E62516636516556564B6C4168795943663D6009416955336E6131316267507D495053643340047C65716665644F5475676004656A796E6F6278636E6973500563716243776E696474756350065B43603476565971305955334732665A584005636E6164737E69447C657166656460056275747C657340087C4F665341484C6658696C466E65714536400A64336560315552765A61415237303568754005657C616650056275747C65734F54756370056275747C65734F54756760037C6165717545636E65627566656250097C626D6563737140097C626D656373714F54756760027567616E616D456362757F6375625F5475676006356951443553684C6145356F4535395D48400E6F6964716A796C61626F6C674E2D6564737973500F666E69456275747C6573400E61466A64335B6B4B6003756362757F6375625E2D656473797350027567616E616D456362757F63756250046F4A46734079564C40016034647234766A486C433E637C613A697B600F657D6A455874597476733B67666F456466435008665762387E6034525449786767677D43396E4005657C61665F5475637005657C61665F54756760065E667845634F4C46536E4877667168605754500C616E6275647E694E2375636966727563597D4E23696371624C61657379665E24766F637F6273696D40013065657C6166547875647E6F63400363703D496E4564463950014052733F4071643362725B47616535746565700C6153665432677936673461376B465F493632500556465D4C673F476472597737636178495540500751667F4C657B6373375C4644683669637450027449383948756A6347600954303058715A45483F436769487C41436A7008383833466231673535727E4476785539607004575268394A65607E45400072626342783562545440056661385A464259695C4A67476837385C4742700757583C4D4847544230714267607B4137627D6007443645426B46457B6C6B4D6768756872765D600A686A6568623E6536727471776C6F49687A57700B49713475457A4A4858684577635F4158723170076E696274735F64500F496956313B45666C4F4005646F63486371684475674005657C61665473656A626F44756740037275607C6568456D69647E657250037C616571754005637F60737964400C65646F6D447E656E6F607D6F634E2D656473797350047E656E6F607D6F634000200C667169724F455261646768723E47703B496009503E4D4577356339444005667F6D6562500567616373756D4F547567600E6F6964707563687542756E6E694F547567600E6F6964707563687540027F6272754473656A6F627054756350016471644473656A6F62705005636E6164737E6945647165627340027F6471667964736140046461400E6F696470756368754E6F6964716275607F44696C61667E6940076E69627473556362757F63756254756740037563696672756352756C69607D6F634E23696371624C61657379665E24766F637F6273696D40037C6964755009756B437E6961647E6F6340056C646E616845607974556D69647E657250056C646E61684D6F6276456079745475674005607974500465637F6073796443794F547567600E6F696470756368754E6F696471636F667E6944756762716450093978564A41337F4232643A66425435444B600155465377565175573859683C6C616C65716003427577346145617A467009786242366C6A5A4C455C6D4767457055457A60037E6F696473656C6C6F634E2D656473797350056C62616478637168400F67393333666561307C600345635B6935796A6A7008776775583D62344C40023755594E627A5479700E6368407339503D65600845544363556763337003674271336A596567535B6C6F624768746650025163607A45545362573278375845707E4140045935327C6773776340056767465431735139400D46407168315F63336008754938334A446575400C6964365836756D685940084550355B497F4E4550027F6473636E20033D64574A6458517975507473324366447D400251783E63703A5A417002396347687536343D600275637550056B6A656F6F4333664003474742567C467B44600C485645645546745E60037D65505679635B6D41733A647570555257600747503C62684844415F605256374A4E477A600A6176375D6863344937346A58717E473242600930316D6E463A61574577523754373C446650027675524360507439323D47364158667D43600B414C455D4356576A5E6F61405C61797641600C6F62747E6F634261645009326B44473873693A633762407563763556500241784F4F44683F6A5B426450787B4C437560087F624F626D6F6340024478716F674658355B6C6336336B46537E60043D63697659577431456772696A4078574A600037577F696E627071793444757F4A5554765004653036705039625367426C68763E6431434005743E43575A6B644D646169387777567A4D400B655A6960733C4D6C693D475A533A6F6758600954494D4A4244564C6E48713B495951424560067A427445467548757950794C456939307A70086938663A5465703D6143546E484A5B664D6005647167656C65644473716369647C657D400767794E453242636871756D43753E4454554009635F447576634136597646503946454959700037655232353E4333514D616E646373313460034A583E44384F4464644A63417167644E4940017A6A5771674761453741774D42575C4442400474367242357752315740335559677C4647500C6F62747E6F6340055138316859626876395860787A665B433F40005E4A6859454254324769603D62377B6933500C6F62747E6F6342756E6961647E6F63400639705E6941473F65786D45344E68613A694006434447533076314245407F463B614C6E60700568533768715C687739703C44754372647F400D4D676147565C6651525135457161353949700D657E654003574A6679743F6B434454357A5747616839400A505776426974667F6371377C6F614D496D600262484D443A69727C68687252437858517840037D627F664E23777F646E69675E2D6564737973500D627F66400E61466A643B6B4C446F4A4D667349564E6D4001783E637A5A4162396347617876343535695009747275607F627053776E6964747563597D400E6F69647162757769666E6F634E2D6564737973500563716243776E69647475635E6F69647163696C60707140097D4E2E6F696470756368754E6F696473657274737E6F634003776E6964747563597D4003756362757F6375625E297D4E2E6F696470756368754E6F696473657274737E6F634003756362757F63756250013067333B634A623A695D684F696E6247453242500A696440724557353C666C66777174683278400164575A5A6073554A42397B405777467630700473656A626F400A656F633368734747425672767B495C485A4005645674507345635B6939615A624459353660037563696675644E23696371624C61657379665E24766F637F6273696D4002756475707D6F63400C63776B48776775583234495E656767465550035137623755594E6A54745A4D46407168365003696371624C61657379665E24766F637F6273696D4003756369667275635E6F69647163696C6070714E23696371624C61657379665E24766F637F6273696D40056371624E6F69647163696C60707140033A4E63684073303D615875654938334469600A684554436357633468455970355B4F4E45500E356C65746F6D4C300C6C646E2973696C6F6051637C45666163500564757269627474714E6F6963727566556C6966497C626D656373714005647572696274747144696577400375636966727563507F6275647E694E256D69647E65725E2D656473797350056475726962747471456C62696379665D6F63400564757269627474714B62716D6564616274597C626D6563737140056475726962747471447867696279707F63497C626D6563737140056475726962747471447365746F6270597C626D6563737140056475726962747471497E61607D6F63497C626D65637371400564757269627474714E6F696470796273637564497C626D6563737140076E69627473500E6F696473656C6665625E2D656473797350056475726962747471456C647964597C626D65637371400375646F6D476E696767657265644003736964737F6E676169644E2D656473797350056475726962747471456C6261676765726564400564757269627474714974796C6962696471607D6F63456D69647E6572500E61656C6F6F62400233347E69400D65647379735004696F6650027F64736E2002696C627F63637D60037563696672756352756C69607D6F634E256D69647E65725E2D656473797350056475726962747471437E6F69647168716C65625E6F6964716C69607D6F63400973696C6F6051637C456661635؛؛95003000950020C01210F7907810F7804010F720A60014107E0014A05400B3؛؛A04100930001؛908100D1؛؛707C00B10001؛B08200E؛100؛B100C100710081003100410011002100B000C00040007000400060004000500؛3EA00؛1000؛8B0؛3E700؛10؛؛؛؛D0FA006E00؛؛؛؛؛20؛؛301E00A000؛؛؛؛؛2000؛؛3600A000؛؛؛؛؛20؛؛20A5006E00؛؛؛؛؛8000؛؛F400A000؛؛؛؛؛2000؛1000؛؛؛؛؛؛300؛840A01640CC207620F5208510FB10C4105410E31073100300321013002000120024002000120034001000F10004002000F10014001000D100E3002000D100F3001000B100C3002000B100D30010009100A30020009100B30010007100830020007100930010005100630020005100730010003100030020001100D2002000F00072002000F00082001000D00062002000B000A00020009000900020007000800020005000700020003000600020A01E926A؛4099213F؛4099216E؛404921BD؛40F821DC؛40A821FB؛40A8211B؛4058215A؛201EC07E؛201EC099؛204CC022؛20EBB054؛10E97067؛109970C6؛10497026؛10F87085؛10A870E400؛11009100A000B0009000A0008000900060008000100040C003C062C071C0B0B033B0D2B0E1B000A0D8A0D490EE900E909A906990C890D7901790F39073901390B2805E80BD801C80AA8090701E705D70AA70F97083601E609A6091604050A750E550D2403E40DA40D130DF303A30F020CD20CA20D82005208320B220522021103B1008106710C61026103510C2C018903DF206C018903DF204C018903D220AC018903D2208C018903DD102C01890BAD102C018903DD100C01890BAD100C018903DA102C018903DA100C018903D610AC018903D6108C018903DA014D019903EA014D019903E9010C018903D9010C018903D8006C018903D8004C018903D8002C018903D8000C018903D700EC018903D700CC018903D700AC018903D7008C018903D7006C018903D7004C018903D7002C018903D7000E03390BE601EC018903D601ED019903E601EC018903D600EC018903D600CC018903D601AD019903E601AC018903F600AC01890BC6008C017903A4006C01890BA4006C01890BA4004C017903A300CC01890BA300CC01890BA300AC01890BA3008E0F190BF3036C017903A3006C01890BA3006E0D090BE3014D019903E3014C018903D3014C017903A3004C01890BA3004D0BF90BE3012D019903E3012C018903D3012C017903A3002C01890BA3002C018903D3010D019903E3010D0BE90BE3010C017903A3000C01890BA3000E0F190BF203ED08D90BE201EC018903D201ED019903E201EC018903D201CD019903E201CD05C90BE201CD019903E201AD02B90BE201AC018903D201AC018903D2018D019903E2018D01A90BE2018E0F190BF2036C017903A2006C017903A2004C017903A2002C017903A2000C017903A100EC01890BA100EC018903B103CC01890BA100CC01890BA100AC01890BD1036C018903D1034C01890BB1034C01890BC1034C018903B1034C01890BA1004D008903C1092D0C1903A1032D05290B91032C018903D1032C01890BA1002C018903D1030C01890BB1030C01890BC1030C018903B1030C0AD90B91030C018A0B01010C01890BA1000D0C1903A009E004A0035003EC017903A003EC01890BA000ED0C1903A009CE00AA030003CC017903A003CC01890BA000CC06C903C009AC017903A003AE0F3A030003AC08B903C0098C02590B90038C018903B0038C01890BB0038C0BA903C0096C02590B90036C017903A0036C079903C0094C017903A0034C02590B90034C017903A0004C01890BA000400A4003200E200A600B200E200E7003300E2001000B000E20081003100E200B300B100E200A400B300E200FA00B500E2009D003600E2004A003500E200A9003400E2004A00B400E2C068903C0092007300854099E08900854019005600854098007300854018005600854097D0A900854096007300854016007300854095007300854015005600854094007300854014007300854093007300854013C0A700854012C0B60085409120B1C210001E20B1B20E001EB0DD6173001E502031692016B0ACB252301E00730085301EB0FB0085201AA03B3169201AB09BB2B0201A109FB2300094B0FAA29F2096109F618B309EB08A629E401020B1A2AE309EB02AA2FC309FB0C9A27B001E20B1A2CA201620B1A24A201620B1A2A92016B059A228209950EF9137001BB0E8629E301FB088A236001EB008A285301E3041D0B9309EB0A7A204001E20B1410010985020A233001EB037A282001E60BB61AF201600733272001E301292AF001E00AA51BA001EB0E0921E001E00730085001E50EF024A009DA02D829F009DA03C82FC009D80EC020C301950EF9137009DA03B4100209AA03B3168209AA03B41B0209AA03B31AF209AA0DA725E2099109F618B009DA00A61272096A068725C009D0031726B009D3041D0B9009D3041D04E009D80B70085301C00730085009DA0B772F72096A00772372096A0A672B600C50073008500C520F6804A00C5007372B23019007372C13019108272A01092A03261762096A0E162EF301BA091629E309A20B162FD3019A031624C009DA0C062CA2097A020008520169095621A3019608861BA301990CF6298301990956275009C00316254009D0073711C009C102C42FA009C102C426A3098703642A93098903A42C8101A308F9019209000733272009C909532F3009C9035F06F00943082910D1018900222213097807C124E3016007300853016308012F1009400AA1211301600AA124030970056D0293016109F618B3016102C02DD009C60AD022D009C60AD022B009C804D029C009C80EC020C009C3041D04E309750EF024A009C60AD0219009C3041D0B9309760AD02E7009C003102C1309700AAF10E301680B700853017804BF1AB009C804BF17A009C3082E14110183082D1AB101880A5D1B7209680D3C1C820968083C1F7309280F261E1109A30410085209780E16176209670BE90603011707FC185309170BEC144301160ADC182009C0031C1D1009C60ADC1A0009C0031C131009C60ADB16E009C007390D4209670D5910D209F70B7910B20967076917A301070369129209430B10085109C007390D4209470D5D09D209F70D59198209F50EF9137009C703591A6209670A49106209600730085009C0073711C001C60AD71F4009C7031E064101820B141؛9C608C711D001C602A71D7009C60DF712B109A604F716A109A60EE7149009C609E7198009C20B131AF109A20B141B0109A602A7137009C60AD7166009C604D71F3001B60DC71F1001B602A617C009C00737191001B608C7101009C601C7170201660BB61AF209D605B612E209D3041611C20966089E0641018109F618B009C60E8419E20966021515D009C608861BA201960A70085209920F2611A201D60376119209C60A60085201A50AD6127209620B13168009C60956176209660256155201B60256173201B00730085201B609461E1209A60F36150209660A051EB009C00AA51BA009C00730085001C007351C8009C50AD419E2096503A41E6209650D800852097304100852017509841941018509841341018509841D3101850A44191209550240085201620B13168201600730085209550834111209520B141B0201620B14100201620B131AF201650D131E5201420B1319B1018500131FA2015508031F9109C50203169209420B13168109840BF31E72014405D31E5209340FC31942093400C3103101140E721E9201030412146001B40B621D3001B40C511FE001C00310085201020B101380094109F90192010403101A7209140D00126209040700105009430DE0181101F00730085101C307EF0DF1016301EF06F009430CDF0CE1015305DF03E1016300DF0ED109E300DF0CC101E30ACF0FA101C302CF0AA101630BBF0F9101000730085001B3082E02D10180056D029001B3075E02B001C3005E0F9009C3082E05910183082E098101800AAE0C7009C3082E0C610180073E0E5009C3012E0F4001B3074E06410180056E0D3009C3082E01310183004E042009C30B10085109A30A3804A101A3043D0FF009C30E2008510193041D04E009C3082D09D10183012D00D009C30B1008510980031D0EB009C3041D0B9009C0056D029009C00AA90D4001B007390D4109700730085009A20ECC0A5109620E3B0EC001A20E9008510152089B08B101020D4A08D00C300730085004420F6A06F00441085A0CE00442044A04900C3109F9019001A20B190A7001A10FC9055001A206190B6101400730085001A007390D4109320509060001F10DF00851091109F80AF1013103F807E101310CE80DC1092101E802B101210BD804A001F00730085001F005600851091104D8087101110FC80F3001F106C80B11010102C8070009C1085605F00C21085605F00421085605F00411085605F00C01085605F00C10073008500C20073008500420073008500C10073008500410073008500C000730085009900730085001900560085009800560085001800AA00850097005600850017005600850096005600850016005600850095005600850015005600850014004400850013007300850092003100850090E14B0010؛E17F0010؛E1AD0030؛E19C0020؛E14B0010؛90B20020؛90B20010؛90B20010؛90B20010؛90B20010؛90B20010؛90B20010؛90B20010؛90B20010؛90B20010؛90B20010؛90B20010؛90B20010؛90B20010؛90B20010؛90B20010؛90B20010؛90B20050؛90B20040؛90B20030؛90B20020؛90B20010؛90B20020؛90B20010؛90B20010؛90B20010؛90B20080؛90B20070؛90B20060؛90B20050؛90B20040؛90B20030؛90B20020؛90B20010؛90B20020؛90B20010؛90B20010؛E14B0010؛E17F0010؛E1AD0030؛E19C0020؛E14B0010؛90B20020؛90B20010؛90B20010؛90B20010؛90B20010؛90B20010؛90B20010؛90B20010؛90B20010؛90B20010؛90B20010؛90B20010؛90B20010؛90B20010؛90B20010؛90B20010؛90B20010؛90B20010؛90B20020؛90B20010؛90B20020؛90B20010؛90B20010؛90B20010؛90B20010؛90B20010؛90B20010؛90B20010؛90B20010؛90B20010؛90B20010؛90B20010؛90B20010؛90B20010؛90B20010؛90B20010؛E14B0010؛E17F0010؛E1AD0030؛E19C0020؛E14B0010؛90B20020؛90B20010؛90B20020؛90B20010؛90B20010؛90B20010؛90B20010؛90B20010؛90B20010؛90B20010؛90B20010؛90B20010؛90B20010؛90B20010؛90B20010؛90B20010؛90B20010؛90B20020؛90B20010؛90B20010؛90B20010؛90B20010؛90B20010؛90B20010؛90B20010؛90B20010؛90B20010؛90B20010؛90B20010؛90B20010؛90B20010؛90B20010؛90B20040؛90B20030؛90B20020؛90B20010؛90B20030؛90B20020؛90B20010؛90B20050؛90B20040؛90B20030؛90B20020؛90B20010؛90B20020؛90B20010؛90B20010؛90B20020؛90B20010؛90B20020؛90B20020؛90B20020؛90B20010؛90B20010؛90B20030؛90B20020؛90B20010؛90B20030؛90B20020؛90B20010؛90B20010؛90B20010؛90B20010؛90B20010؛90B20010؛90B20010؛90B20010؛90B20010؛B06F0010؛90B20010؛A0720010؛90B20010؛90B20010؛90B20010؛70AD001000؛3A2050F1B03064003000؛؛2A80C8E1DE3064003000؛؛F98018E1B93064003000؛؛D980B700858160003000؛؛D980D6E2980039؛؛AA8400D980F2E2570039؛؛AAC300D920F2E2160039؛؛AA0300D93082E2D40039؛؛AA8200D970E0E2930039؛؛AAC100D9C0D4E2520039؛؛AA4100D9003FE2110039؛؛AA8000C96021515D204C؛؛7AC100C9007300858160؛؛6A8600B9C011E2608060؛؛5A4E00A9C011D2BF8060؛؛5AC5009960ADC182204C؛؛4A8D008960ADC1A0204C؛؛4A4B00793041D20F8060؛؛4A49007950EFD25E8060؛؛4AC6006900AAD2AD8060؛؛4A050069102CD2FC8060؛؛4A82005960ADB16E204C؛؛4A400049602A7137204C؛؛3A4D003960AD7166204C؛؛3A4A0029602A617C204C؛؛3A47001960AD71F4204C؛؛3A44001970E0D2B70039؛؛3A8300192061D2760039؛؛3AC20019903DD2350039؛؛3A8100192061D2F30039؛؛3AC000192061D2B20039؛؛3A؛19B0EFD2710039؛؛2ACE0019B0CED2300039؛؛2ACD0019B02FC2FE0039؛؛2A4C00197092C2BD0039؛؛2A4B0019B0CEC27C0039؛؛2A4A001970E0C23B0039؛؛2A89001970D1C2F90039؛؛2A8700197092C2B80039؛؛2A86001920F2C2770039؛؛2AC500192061C2360039؛؛2A0500192061C2F40039؛؛2A4400192061C2B30039؛؛2A830019A09DC2720039؛؛2A820019B04EC2310039؛؛2A81001920F2B2DE0039؛؛2AC0001920F2B2CC0039؛؛2A؛19903DB28B0039؛؛1ACE00193074B24A0039؛؛1A8D0019B05DB2380039؛؛1A8C0019B00DB2F60039؛؛1A0C0019003FB2B50039؛؛1A4B0019505CB2740039؛؛1A0A001950BBB2330039؛؛1A8800096021515D204C؛؛298B00F8B042A2210060؛؛290900E8B051A2700060؛؛298600E800733272204C؛؛29C400E8007300858160؛؛198C0098A05F926D00600؛؛9810078A0BE92BC0060؛؛E8870078206192290039؛؛E8C60078909092E70039؛؛E806007820F292A60039؛؛E8450078707892650039؛؛E8040078808392240039؛؛E8430078A09D92E20039؛؛E8420078705C92A10039؛؛E841007820F292600039؛؛E8800078A0AC82CD0039؛؛D88F0078401482BB0039؛؛D88E00782061827A0039؛؛D8CD007870E082390039؛؛D80D0078206182F70039؛؛D84C0078206182B60039؛؛D88B0078608982750039؛؛D88A0078308282340039؛؛D80A0078A0CB82F20039؛؛D8490078108282B10039؛؛D8C80078A07B82700039؛؛D8480078003F723F0039؛؛D88700686021515D204C؛؛98410068007300858160؛؛788E0058304172698060؛؛78CC005850EF72B88060؛؛784A00D7A01372E30040؛؛684600B7906E62C60060؛؛380700B790956275A06C؛؛384400A7003162A38060؛؛284D00A720B162F28060؛؛288A00972050F1B03064003000؛؛8780C8E1DE3064003000؛؛578018E1B93064003000؛؛3780B700858160003000؛؛372061521F0039؛؛28C90037903D52DD0039؛؛288800373074529C0039؛؛2847003790BC525B0039؛؛284600378025521A0039؛؛2845003720F252D80039؛؛28840037308252970039؛؛2804003770E052560039؛؛2843003770E052150039؛؛28820037401452D30039؛؛2881003770E052920039؛؛28C00037401452510039؛؛18CF0037401452100039؛؛18CE0037906C42DE0039؛؛184E0037003F429D0039؛؛188D00276021515D204C؛؛E78D0027007300858160؛؛E7420017304142EC8060؛؛E740001750EF423C8060؛؛D78D0017007342570010؛؛C74300170073711C204C؛؛C7810007907742A68060؛؛B70900F6907742F58060؛؛B7C000E660ADC182204C؛؛A70C00D600AA42458060؛؛A70400D6102C42948060؛؛A74100C660ADB16E204C؛؛970F00B660ADC1A0204C؛؛97CC00A6602A7137204C؛؛97C9009660AD7166204C؛؛97470086602A617C204C؛؛97C4007660AD71F4204C؛؛97C1007670E032FD0039؛؛97010076709232BC0039؛؛97؛762061327B0039؛؛874F00767078323A0039؛؛870E0076307432F80039؛؛87CC007670E032B70039؛؛870C007690F532760039؛؛878B0076003F32350039؛؛87CA00666021515D204C؛؛57C40066007300858160؛؛47090066007332430060؛؛37CB006600733272204C؛؛37CA005600AA32C18060؛؛37090056102C32118060؛؛37460046003132608060؛؛27CD004620B122BF8060؛؛27C400360031220F8060؛؛174C003620B1225E8060؛؛1789003620F222680039؛؛17C8003640E422270039؛؛17C70036409322E50039؛؛17C60036307422A40039؛؛1785003640E422630039؛؛17840036401322220039؛؛178300369081122F0039؛؛178200369001120D0039؛؛17810036909012CB0039؛؛17C000364093128A00390؛؛7CF00362061124900390؛؛70F003670E0120800390؛؛74E0036206112C600390؛؛78D00369040128500390؛؛70D0036003F124400390؛؛74C001680CF124380100؛؛7CB00F580CF125280100؛؛74B00E56021515D204C؛؛D68400E5007300858160؛؛C64100E50073029F0060؛؛A64000D560ADC1A0204C؛؛968B00D5007302EE0060؛؛96C900D50073023E0060؛؛96C700C560AD022D204C؛؛968500B560AD022B204C؛؛96C200A560AD0219204C؛؛868F009560AD02E7204C؛؛864C008560ADB16E204C؛؛860A0075602102C6204C؛؛86C9006500AA02168060؛؛86C70065102C02658060؛؛8605005500AA02B48060؛؛86030055102C02048060؛؛86800045807C02538060؛؛768E004580BB02A28060؛؛76CB0035003102508060؛؛7648003520B1F1AF8060؛؛7685002500AAF15D8060؛؛76020025102CF1AC8060؛؛664F0015803AF1F8B0140002؛66C4001580D9F148B014؛؛66C300052050F1B03064003000؛؛F480C8E1DE3064003000؛؛C48018E1B93064003000؛؛A480B700858160003000؛؛A480D6E1080039؛؛668000A480F2E1C60039؛؛56CF00A42057E1850039؛؛564F00A47092E1440039؛؛564E00A48083E1030039؛؛568D00A420F2E1C10039؛؛56CC00A43082E1؛39؛؛564C00A48016D1CE0039؛؛564A00A47078D18D0039؛؛5609008470E8D14C0039؛؛560800843082D16A0039؛؛568700844093D1290039؛؛568600848025D1450039؛؛5685008440E4D1040039؛؛568400844093D1C20039؛؛568300843082D1810039؛؛560300848094D1400039؛؛56C1008470E0C10F0039؛؛560100848044C1CD0039؛؛56800084003FC18C0039؛؛46CF00746021515D204C؛؛E5850074007300858160؛؛D54B006470BDC1868060؛؛D503005470BDC1038060؛؛C50A004460ADC182204C؛؛C5C1003460ADC1A0204C؛؛B58E002400AAB1FF8060؛؛B58C0024102CB14F8060؛؛B5C9001460ADB16E204C؛؛B5080004602A7137204C؛؛B50500F360AD7166204C؛؛B50200E3602A617C204C؛؛A58F00D360AD71F4204C؛؛A58C00D32061B1D90039؛؛A5CB00D320F2B1980039؛؛A50B00D3500DB1570039؛؛A50900D33074B1160039؛؛A5C700D3705CB1D40039؛؛A5C600D34093B1930039؛؛A5C500D3700CB1520039؛؛A54500D3003FB1110039؛؛A58400C36021515D204C؛؛658E00C3007300858160؛؛654300B3704AB1708060؛؛654100B370A9A1DF8060؛؛55CE00B370E0A1AC0039؛؛550E00B32061A16B0039؛؛554D00B37092A12A0039؛؛554C009370E8A1E80039؛؛554B00937078A1A70039؛؛550A009320F2A1660039؛؛5549009320F2A1250039؛؛558800933074A1E30039؛؛5547009370E0A1A20039؛؛558600934014A1610039؛؛558500937028A1200039؛؛55050093003F91EE0039؛؛55440093401491AD0039؛؛554300836021515D204C؛؛25C20083007300858160؛؛1509007360AD7166204C؛؛1506006360AD71F4204C؛؛15030053602A7137204C؛؛15؛43602A617C204C0؛؛50D0043206191E200390؛؛54C004370E091A100390؛؛58B00434014916000390؛؛58A00432061812F00390؛؛5C90043701381ED00390؛؛5090043709281AC00390؛؛50800437092816B00390؛؛50700436094812A00390؛؛546004370D181E800390؛؛544004320F281A700390؛؛58300437031816600390؛؛502004320F2812500390؛؛5410043603781F300390؛؛5؛43307481C20039؛؛F4CE004320F281910039؛؛F40E004370E081600039؛؛F44D00437090713F0039؛؛F4CC0043003F710E0039؛؛F40C00430073711C204C؛؛F4C60033602A71D7204C؛؛E44A0023602A7137204C؛؛E407001360AD7166204C؛؛E404000360AD71F4204C؛؛E48100F2602A617C204C؛؛B4C700E26021515D204C؛؛D3C600E2007300858160؛؛C34500D23041511A8060؛؛C38300D250EF51798060؛؛C30100C2005651288060؛؛B34F00C2109F51878060؛؛B38C00C2500D416D0039؛؛B38A00C2505C413C0039؛؛B34900C250BB410B0039؛؛B3C700C2502B41D90039؛؛B30600C250DA41A80039؛؛B38500C2003F41770039؛؛B3C40082504941460061؛؛A3C2005250C641A20061؛؛930؛2503541020061؛؛73C400E15032310C0061؛؛534A00D140BD31760061؛؛338D00B1405A31620061؛؛238300B1007300858160؛؛EAC700B11082604E8111؛؛EA0700B1408721B80039؛؛238200B1402721870039؛؛238100B1409321150039؛؛238000B1403621A10039؛؛138F00B1401421700039؛؛138E00B1404511CD0039؛؛138D00B12061119C0039؛؛13CC00B12061116B0039؛؛130C00A140E4113A0039؛؛130B00A1409311090039؛؛130A0091407411D70039؛؛13090091307411A60039؛؛13C70091206111750039؛؛13070091401411440039؛؛13060091206111130039؛؛13450081409311E10039؛؛13440081308211B00039؛؛13C300814013018F0039؛؛13C200813082015E0039؛؛134200812061012D0039؛؛1381008140C201FB0039؛؛13010081003F01CA0039؛؛134000814082012A00110؛؛34C00714022018980610؛؛38A0071408101E880610؛؛3080061308F01C20011؛؛F24A003130C9F0770061؛؛E2480001305900858160؛؛E24600F030F8F0C6B0340002؛E20500F030A8F016B034؛؛E20400E030F8F065B0340002؛E2C200E030A8F0B4B034؛؛E2C100D03048F004B0340002؛E28000D030F7F053B034؛؛D28F00C03097F0A2B0340002؛D24E00C03047F0F1B034؛؛D24D00B030E6F041B0340002؛D24C00B03096F090B034؛؛D24B00A030E6E0EFB0340002؛D20A00A03096E03FB034؛؛D20900903036E08EB0340002؛D208009030E5E0DDB034؛؛D20700900073D0880010؛؛42C6008000AA90D4204C؛؛320C00801082604E8111؛؛32C8008020AEC04D0039؛؛32480080003FC01C0039؛؛32870080207DC04B8031؛؛32050080207DC0680039؛؛32840080003FC0370039؛؛32C30080207DC0768061؛؛32410080007300858160؛؛32C000801082604E8111؛؛220F0080209BC0F00039؛؛228E0080003FB0CF0039؛؛22CD0070202BB0AE8031؛؛228C0070206AB0ED8031؛؛22C900702078B04A8031؛؛128F00702057B0410039؛؛EA860070003FB0؛39؛؛EAC50070007300858160؛؛EAC300701085605F8030؛؛DA4F007010B7A0080039؛؛DACE0070003FA0C60039؛؛DA0E007020E3A0850039؛؛DA0D0070007300858160؛؛DA0C006020A0A0A30010؛؛DA4B005010BAA0900011؛؛DA080050109F9019206C؛؛DA85005020F190EF0038؛؛DAC2005020B190A7206C؛؛DA؛4010FC9055206C؛؛CA0D00402061906D0039؛؛CA4C004020F2902C0039؛؛CA8B0040101790EA0039؛؛CA0B0040003F90A90039؛؛CA4A0040109F9019206C؛؛CA87004020F190680038؛؛CA84004020B190A7206C؛؛CAC1003010FC9055206C؛؛BA8E0030007300858160؛؛BA8D002020A090D00010؛؛BA0C001010BA70CB0011؛؛AAC70010105870B30039؛؛120F0010003F70820039؛؛124E001010B770E18031؛؛124B0010101770418031؛؛12880010107670A08031؛؛12C5001010D570008031؛؛12C20010007F60BE80310؛؛2CF00101082604E81110؛؛2C70010007F607800390؛؛2470010003F604700390؛؛28600100073008581600؛؛28500100073008581600؛؛205208FD2BB0031C070D20B0010505ED25A001050FED2A90010505FD2F80010A07E927B001190CD62B10011505E62010010502F6250001090D642530031505E42A20010909642F1001050FE42410010505F42900010904632EF0010509F323F00109072221D001150FE226C0010502F22BB0010502F220B0010502F225A0010502F22A900103040F107001150FEF156001050FEF1A500108089F1B30010502FF103001050FEF15200108039F1210010701DB12D001170DCB17C001050FEB1CB0010505FB11B0010502F31B0606020CFA19E00117069A1ED0010204F91C40011505F91240010300051560031509F51B50010509F51150010502F51740010502F51D30010505F51330010502F51920010502F51F1001050FE5151001050AE51B00010505E511000103080417F0010401A3131003140E931B06060308031؛6130B0D09600113080D0F500613080D05500613080D0B400613040D01400103040D07300103000D0D2001020CFD0320010208FD0910010208FD0F00010204FD050001020FEC00F0010206EC01A001120ACC0A3003120ACC0A200112038B019003120E7B06600112097B0B3001120D4A08D00312044A0490012204390AE0011107A708A0011103A700800111042601D001110C1607C0013104160DB001110C060EA00131040604A001300CF60A9001300FE60160031105800450096؛60E4؛102010F600F4005660B3608200؛1010C400E4001760A0507F؛؛10F200B400D650BD508C00؛1010B200B40096؛505B؛102010B000440056502A50F800؛10009F00E3005650C7509600؛1؛D007300565065503400؛1000CC00730096؛50E1؛102000BA0033005650B0408F00؛1000BA002300D5؛405E؛102000F900030016402D40FB00؛1000C800E20056404A401900؛1000E60022001640D640A500؛1000260012001540744043؛10؛26000200D540C14090؛100؛600F10015؛306F00010020003300310095309C306B0001001؛30021001530D5303A؛10؛B20001005530D53025000110؛6200D0001530F23052؛10؛2200B00015؛3001؛1050008100A00015؛20DF؛105000D000800015؛20AE؛1050005000200015200D20DB000110؛20001000D42038200700؛؛100010009420D010AF00؛؛100010؛؛101F00؛؛360386006020A503D400A09073037300E000AA03A1006000F2F29F006000AAF22E006000AAF27C00608015F2CA00A000F2F219006000AAF2470060F275F22400E020A5F2A200A08015F22100A000AAE2AF00609073E25E00E09073E2CC00E0E24BE2D900E0301EB2790021D0FAB2A10061؛A2AD10FF301EA25C0021؛A2070037301EA2050021317DA2D10061301E92EE0021301E820F0021301E727D0021301E721A0021720572940060301E622F0021؛62EC00F6317D62AB0061301E62390021301E62770021705942080060301E22600021301E020100210036F1A90060301EF1640021301EF1D100210036E1BB00600036E17A00600036E1490060317DD1860061C14BC12A00610036C15800600036C1A70060D0FAC1370061F0BBC1C400600036C1B30060317D912C00618015918900A0D0FA91180061003671C50060301E71F20021301E61DE0021301E613D00218015615900A020A5615800A0D0FA61B70061D0FA61540061D0FA61A20061D0FA61310061D0FA61؛61317D51CE0061301E51DD0021301E517C0021D0FA41E50061D0FA41A50061D0FA41F40061D0FA41430061D0FA310F0061317D31AC00610036318A0060D0FA31090061003631170060014431040060003631A30060301E21D20021003601E7006020A5012700A0003601B60060003601A5006001440163006020A5013200A0801501E000A00036F02D0060F0BBF04B00600036F0A90060003EF0F80060D0FAF08800610036F0180060301EE04C0021301EE08A0021D0FAE0E10061؛E0C000760036D08F0060D0FAD02F0061D0FAD0BC0061D0FAD09A00610036D0C700609073C0AF00E030E8C0D400E0003EB05C0060B0C7B0070060B055B0540060A0EAA0F900A000F290C50060907390D200E0003680DD00608015801C00A00036808A0060003680A80060801580B400A0003680D20060003680610060003E70DE0060705970B800602003608B00A0301E60D10021301E50EE0021003650130060301E407B0021301E40080021003640F20060301E30CD002130E8306700E00036203E006020F9206900A02003200200A0003E102C00601059104B0060105910180060003E10660060003E10B40060003E10230060003E10910060003E00CF00600036005F0060003E00CC006000؛DB00B100AA0069006000F200870060003600070060003600A60060003600E5006000F200F0006000؛؛1010FD00؛؛2000؛5000؛5000؛8000؛2000؛5000؛1000؛B000؛9100؛1100؛6000؛B300؛B8؛101400؛3A؛108800؛3500؛C100؛3900؛10؛؛؛؛؛F190902A517510؛2000؛؛؛26F6C62432؛F040؛160900؛4494557432000؛1؛160800355532؛20C3؛F544؛؛3776E696274735320؛38D؛E2C6؛E732؛E2؛؛C60050؛؛7323730353E203E2236700؛C000؛؛10001024A43524A2A0؛728220E1A240؛F10860؛9482E200A2A00؛3E7A1؛A210EF41A00؛3E76200A2؛؛83A0؛C2D7A0؛F2372000؛؛83A0؛72822000A700A260؛؛83A07000؛A0؛E2F670A0؛C2B720B0B2؛208200؛419380C010EF41B1؛90C870B0A0؛D2F6A0؛C2B7200011؛C000؛B30030033100A240؛A0E7A1؛A210EF4140؛A0E76200A2A0؛9282001090EF؛90EFA300A200؛؛83A0؛72822000A3؛A2B1؛6051EF300062؛A260؛؛83A020؛؛8083A0B2؛108200؛B09370B010EF41B1؛60C8200011؛B000؛620030033100A20011؛؛8300؛5083؛؛830031A0؛B282200011؛A000؛B10020033100FFFFFF3F83FFFFFF8F83A2001100؛30830031A0؛A18220؛600D0011؛9000؛F100200331A20011FFFFFF8E830031A0؛A28220؛؛E08300؛318300؛A08311؛1؛؛20020033100؛A20011؛؛8300؛5083؛؛83003160؛F182A0؛828230200011؛8000؛120030033100A2A0؛B282؛90EFA200A2A0؛A282؛90EFA200A240؛90E7A1؛A210EF4140؛90E762FFFFFF8E83003160؛71822000FFFFFF3F83FFFFFF8F83A2001100؛D08311؛A؛؛200200331FFFFFF4E830031A0؛A18220؛500D00FFFFFF3F83FFFFFF8F83A2001100؛D08311؛9000؛4200200331FFFFFF8E83003160؛61822000FFFFFF3F83FFFFFF8F83A2001100؛D08311؛1؛؛200200331؛FFFFFFFD83FFFFFF4E83؛؛830031A0؛9282A0؛8282302000A2001100؛308311؛8000؛620030033100A200؛؛83A0؛72822000A300A2B1؛6051EF3000A0؛62F6B1؛6061EF3000A5؛؛71009FA600F8002000؛B913008CC000F80010؛C110؛A260؛؛83A02000CD00A0؛52F6A0؛A182B1؛600D40؛80E700A7A0؛4237A0؛22F6401160116031A0؛C1822AA0؛32F6A0؛22F64011615210؛90D87107؛B3276211EF30EF615011503130EF41A0؛22F640114031A0؛12825200؛9183616200؛70A35210؛F15700؛D7DDA0B2؛1082؛A0؛F1F641A0؛A182B1؛600D40؛80E70040؛8008A0؛E137؛؛C083؛A7A0؛D137A0؛C18210؛90D86107؛102700؛619390D0A0؛B1F6A0؛A182B1؛600D40؛80E700؛839380C030EF4140؛80E700؛AE9370B07100؛1083A0؛91F6B1؛6061EF00F000؛2193B1؛60C8200011؛70؛10A1006003B100A2A0؛5B82007090EF006090EF005090EF004090EF003090EF002090EF001090EF؛90EF؛؛؛؛7200900330A2A0؛3C82؛90EF00E200A2A0؛A882؛90EFA2A2A00؛58200E100A2A00؛882؛90EFA200A240؛35E7A1؛A210EF4140؛35E762؛FFFFEF7583A0؛48F6201140111011FFFFDF9B83A0؛48F6301180111011FFFFFFC683703160001047822000FFFFDF958300؛4002A0؛7782AD71A0؛8A8220AD71A0؛8A822061612021FFFFFFF183A0؛8BF61011FFFFDF4B836031A0؛C737A0؛648200؛8C0200؛8C0200؛8C02FFFFDF4A8362FFFFDFEA93600010F7820؛؛2A0؛6BF6811011FFFFFF5783A0؛5CF691101100FFFFEFAB83FFFFFF52937011FFFFDFBD8362FFFFDF5EA3600010E78200؛1002A0؛29F6A0؛7737AD91A0؛8A8220AD91A0؛8A82207171A0؛2C37A0؛648273F173F173F1101100A200FFFFEF528300؛3002A0؛6CF681101100FFFFEF838300؛2002A0؛59F6A0؛FAF6201011؛؛B283A0؛2BF60011؛؛5D83626000104882714141412A10؛30C86181522A10؛30C86171522AA0؛4BF60011615210؛41D8910700107F2741A00؛9F630؛؛3F835031A0؛C837711402؛220700203127؛؛؛2983A0؛29F62011A0؛2C37A0؛648241F141F141F1101100؛1098838031A0؛F837244B؛22A0؛64826DB1A0؛A78240؛15C7206DB1A0؛B78240؛15C7206DB1A0؛978240؛15C72040؛15B7203011؛104583A0؛7782ADB0F1A0؛8A8220ADB0F1A0؛8A8220B1B13021؛10EF834031A0؛F837244B؛22A0؛648282F182F182F1A0؛648223F123F123F12011؛؛EA83A0؛29F63011A0؛2C37A0؛648291F191F191F1101100FFFFFF0A830031A0؛3B37A0؛8A822060001028822000؛100083A0؛1CF600A0؛88F6715200A0؛78F66152A0؛68376000103882A0؛2437C0F1C1F160115011A0؛39F6201011؛2085831031A0؛DA820011؛10AA8300؛EA؛204100؛48؛20E8؛10FA00؛50540090C0EF00؛968311؛B3؛20ED00900331؛FFFFFF1D8340؛F4D7612000FFFFFFFB8340؛15D760001018822000FFFFFFFB83A0؛388271002080200220A200FFFFFFAB83A0؛E3F6A0؛C48220؛؛1183A0؛28F6712000؛C083A0؛93F6A0؛948220؛؛1483A0؛C382A0؛B33781F100؛AF0220؛؛A68300؛F600؛1054؛C0EFFFFFFF3E8300؛50836200؛F0A3710؛؛2A0؛CA82200011؛1000؛6A00400331؛A2FFFFFF8B83203120؛C147A00؛C8230101100؛4183FFFFFFBB0410110011FFFFFF2B8362FFFFFFCB93600010F7820؛؛20031B2؛50821011201140؛25C720FFFFFFAE83003140؛25B72000؛14831031001100؛C38300؛1400؛10540030C0EF00؛B18311؛A300؛670040033100FFFFFF7C830031B2؛50823011201140؛25C720FFFFFF4A830؛؛262FFFFFFFAA3600010F7820؛؛2FFFFFFCC0430110011A2FFFFFF6D83003140؛25B72000؛1383203120؛C147A0؛EB82303011؛؛833031001100؛A28300؛F200؛10540010C0EF00؛F28311؛9300؛B700400331؛FFFFFF1A83FFFFFF4B930011A200FFFFFF1A830؛؛262FFFFFFCA93600010F7820؛؛2003140؛25B720؛؛83400؛5D710EF61400؛5B72020؛؛7383A0؛DB82302000؛؛8360001088F620001100؛358300؛8500؛10540010C0EF00؛C28311؛8300؛670040033100FFFFFF5E83A0؛BB82302000FFFFFF0F83A0؛CB8281F12000A20؛؛183A8FFFFFF6E8340؛15D7302000A200؛؛83A00؛8822000؛D083E700FFFFFF3F83FFFFFF8F83A2001100؛3083003140؛15B7200011؛9100؛B10020033100FFFFFF3F83A00؛88220A2؛؛2083400؛5D7302000A600FFFFFF3F83FFFFFF8F83A2001100؛30830031400؛5B7200011؛8000؛B10020033100؛FFFFFF5E83A00؛8822000؛؛83A0؛9B82302000A2؛؛20832800؛FFFFFF4E83A0؛F982302000A200FFFFFF8E8340؛F4D77120؛؛D083A00؛8822000؛A1832B00؛A200؛؛83600010088220FFFFFF6E83A0؛E9823020؛؛D08340؛F4D76120؛؛D0832B00؛FFFFFF9D83A00؛88220؛؛8340؛F4D7812000؛؛83A0؛B982302000A2؛؛20832B00؛FFFFFF6E83A0؛AA82302000FFFFFF6E8340؛F4D7712000A200؛؛83A00؛8822000؛A1832B00A2A0؛2BF6؛90EFA200A2A00؛9F6؛90EFA200A2A0؛29F6002090EF001090EF؛90EFA400A2A0001072F6؛90EFA200A2A0؛3DF6؛90EFA200A2A0001082F6002090EF001090EF؛90EFA400A2A0001062F6001090EF؛90EFA300A2A0001040F6003090EF002090EF001090EF؛90EFA500A2A0؛88F6001090EF؛90EFA300A2A00010D1F6001090EF؛90EFA3A2A0؛1282؛90EF00E200A2A0؛98F6005090EF004090EF003090EF002090EF001090EF؛90EFA700A2A0؛78F6001090EF؛90EFA300A2A0001052F6؛90EFA200A2A0001042F6؛90EFA200A2A00010C182؛90EFA200A2A000103282؛90EFA200A2A0؛6BF6001090EF؛90EFA300A2A000106182001090EF؛90EFA300A2A000102382؛90EFA200A2A000101382؛90EFA200A2A0؛48F6002090EF001090EF؛90EFA4A2A0؛6482002090EF001090EF؛90EF00E400A2A000100382001090EF؛90EFA300A240؛E4E7A1؛A210EF4140؛E4E76200A2A0؛47F6002090EF001090EF؛90EFA400A2A0؛87F6003090EF002090EF001090EF؛90EFA510؛6200؛49؛A0C0؛102B؛80A5؛؛10؛62000؛8؛40CD؛109B؛3032؛؛10؛6200؛A1؛10C400؛22؛10A2؛؛؛C414FFFF1F7C83FFFFCF28937111FFFF4F6B83FFFFEF41930111FFFFDFCC83600010E682001100FFFF4F23836031100؛34AA0؛648223F123F123F1D152100؛34AA0؛648213F113F113F1C152100؛34AA0؛648203F103F103F1B152100؛34AA0؛6482F2F1F2F1F2F1A152100؛34A6000108582E2F1E2F1E2F19152100؛34AA0؛6482D2F1D2F1D2F18152100؛34AA0؛648282F182F182F17152100؛34AA0؛648241F141F141F16152100؛3D8E1؛؛E983A0؛8BF61011FFFFDF8083A0؛7782ADB0F1A00010818230213031A00010F282E021E031A0001061825011206DA0F1A0؛B68230213031A00010F282E021E031600010C5825011206D81A00؛A82F021F031A000105182E021E031A0001061825011206DA1A0؛1A82F021F031A000105182E021E031A000106182501120B02100FFFF5FD4838131A0؛F837244B؛22A0؛C482A0؛C482801100؛104583013130EF41600010E5822000FFFFFF0883FFFFAF9E83؛FFFF3F9D8350316D71501100FFFF3F628300؛9002600010368200A0؛78F671520060001066827152A0؛6837A0؛5882A0؛7737A0؛27828021A0؛67828021AD71A0؛37828021A0؛17828021A0؛7B822011A0001072F660001056825011A00010C182201011؛؛1983A00010E2F60AF308؛2281520AF300؛22715210؛33D8919111؛؛3A83600010D58281101100FFFF5F03839131A00010D237FFFF9F15834031AD71600010A5822000A200FFFF3FDD830؛؛262FFFF3F8EA360001055820؛؛262A0؛5B82714141412A10؛30C86181522A10؛30C86171522AA0؛4BF60011615210؛41D8910700107F2741600010D6823000FFFF5FE083A0؛29F6A0؛7737AD71A0؛8A82206DA1A00010818230213031A000107182206161A0؛D737A0؛C737A0؛648223F123F123F11011FFFFFFE3830031A0؛3B37A0؛8A8220A0؛A8822000FFFF4FA8830؛؛262FFFF4F59A3600010558200؛3002A0؛FE82A0؛B3376D71A0؛2782E021E031600010C5825011206D91A0؛6782E021E031A000106182501120A0؛2437AD81A00؛A82F021F031A000105182E021E031A000106182501120AD81A0؛1A82F021F031A000105182E021E031A000106182501120312100؛205383A0؛48F680118111101100FFFF7F9D831031A0؛DA820011FFFFBF8683A0؛EAF6600010C482A1B01120A0؛C737A0؛648223F123F123F11011FFFFDF8A83FFFF7F61934111FFFF8FF283FFFF8F43DD؛؛83A0؛6F8200؛؛83A0؛98F600A0؛78F6715200A0؛88F67152A0؛6837A0؛5882A0؛7737A0؛27823121A0؛67823121AD71A0؛37823121A0؛17823121A0؛C737600010858200؛6E0200؛CD0200؛2D022011A0001072F6A00010D1F65011A00010C18220101100؛؛836131600010468252FFFF8F8CDD؛FFFFEF4983FFFFFF67935111FFFFFFD78300؛318300؛؛8183A0؛98F600A0؛78F671520060001066827152A0؛6837A0؛5882A0؛7737A0؛27823121A0؛67823121AD71A0؛37823121A0؛17823121A0؛C737A0؛648200؛6E0200؛CD0200؛2D022011A0001072F6A00010D1F65011A00010C182201011؛؛7783A0؛98F600A0؛78F661520060001066826152A0؛6837A0؛5882A0؛7737A0؛27823121A0؛67823121AD71A0؛37823121A0؛17823121A0؛7B82600010A68220A0؛9582A0001072F660001056825011A00010C18220070020B227101100FFFFFF68830؛؛262FFFFFF199360001065820؛؛26000109682A0؛24376DC1A00؛A82F021F031A00010518231216DE1A0؛1A82F021F031A0001051823121A0001062F6A0001052F6A00010D1F65011A00010C18220A0001042F6600010E58220101100؛C68300؛1700؛105400A0C0EF؛102783513130EF416000108682A0001052F6A00010D1F65011A00010C18220A0001042F6600010E58220؛FFFF7FCA8362FFFF7F6B93600010658200؛4002A0001040F6A0؛2437A00؛A82F021F031A0001051828021A0؛1A82F021F031A0001051828021A0؛2437AD71A00؛A82F021F031A0001051828021AD71A0؛1A82F021F031A0001051828021A0؛2C37A0؛648297F1E6F106F11011؛FFFF8FC2830؛؛262FFFF8F7393600010658200؛1002D031100؛34AA0؛648223F123F123F1D152100؛34AA0؛648213F113F113F1C152100؛34AA0؛648203F103F103F1B152100؛34AA0؛6482F2F1F2F1F2F1A152100؛34AA0؛6482E2F1E2F1E2F19152100؛34AA0؛6482D2F1D2F1D2F18152100؛34AA0؛648282F182F182F17152100؛34AA0؛648241F141F141F16152100؛3D8E100؛30B783413130EF41A0001032822000؛5051836000109582A0؛7737AD71A0؛8A82206D91A00010818230213031A000107182206161A0؛C737600010858223F123F123F1101100FFFFEF5883C031100؛34AA0؛648223F123F123F1D152100؛34AA0؛648213F113F113F1C152100؛34AA0؛648203F103F103F1B152100؛34A6000108582F2F1F2F1F2F1A152100؛34AA0؛6482E2F1E2F1E2F19152100؛34AA0؛6482D2F1D2F1D2F18152100؛34AA0؛648282F182F182F17152100؛34AA0؛648241F141F141F16152100؛3D8E100FFFF9FBC8300؛7002A0؛48F6A0؛77376D71A0؛8A8220AD65F1A0؛A882205165F1A0؛C737A0؛648223F123F123F1101100؛؛80B683713110EF600010B582205011FFFFAFBE836000107682A0؛2437A0001022828021A0؛1A82F021F031A0001051828021A0؛2437AD71A0001022828021AD71A0؛1A82F021F031A0001051828021A0؛2C37600010858297F1E6F106F1101100FFFFBF4D83503161؛10B98360؛6682C011A0؛7737AD71A0؛8A82206D91A00010818230213031A0001071822061611011؛70E883؛7039DDFFFFFF2983A0؛98F600A0؛78F6715200A0؛88F67152A0؛6837A0؛5882A0؛7737A0؛27828021A0؛67828021AD71A0؛37828021A0؛17828021A0؛7B822011A0001072F6A00010D1F65011A00010C182201011؛؛3683A0؛6F82؛؛B0832131600010468252؛8031DD؛FFFFEFF7830؛؛262FFFFEFA89360001055820؛؛2FFFFEF3B931111FFFFEFEA83A0؛98F6006000102682715200A0؛88F67152A0؛6837A0؛5882A0؛7737A0؛27828021A0؛67828021AD71A0؛37828021A0؛17828021A0؛7B82A00010C23761A00010B2F6A0؛3DF620A00010A2F6A0؛3DF620A0؛9582A0001092F6A0001072F6A00010D1F65011A00010C18220070020B227101100؛؛83A0001082F6A0؛24376DC1A00؛A82F021F031A00010518280216DE1A0؛1A82F021F031A0001051828021A0001062F66000101682A00010D1F65011A00010C182206000100682A000103282201011؛104083600010368200A0؛78F6715200A0؛88F67152A0؛6837A0؛5882A0؛7737A0؛27828021A0؛67828021AD71A0؛37828021A0؛17828021A0؛7B822011A0001072F6A00010D1F65011A00010C18220101100؛؛83؛10E68300؛؛F68300؛4700؛10540070C0EF؛104683113130EF41A0001062F6A0001052F6A00010D1F65011600010F58220A0001042F6A00010328220؛؛307F83A0001040F6A0؛2437A0001022823121A0001002823121A0؛2437A0001012823121A0001002823121A0؛2C37A0؛648297F1E6F106F11011FFFFEF2E83؛308283؛FFFFEF55832031A0؛C837611400؛220700107D27FFFFDF848362FFFFDF2593600010658200؛600260؛7682601191A0؛7737AD71A0؛8A8220AD75F1A0؛A882206165F11011؛80F583A00010F1F691118111FFFFDFE88362FFFFDF8993600010658200؛8002A0؛59F6A00010E1F6A0؛99F6A0؛2A8220101100؛A0008360؛7682D011A1B0111011؛308C83A0؛98F6006000102682715200A0؛88F67152A0؛6837A0؛5882A0؛7737A0؛27823121A0؛67823121AD71A0؛37823121A0؛17823121A0؛C737A0؛648200؛6E0200؛CD0200؛2D022011600010B682A00010D1F65011A00010C18220101100؛A06983A00010B1F6100؛34AA0؛648223F123F123F18152100؛34AA0؛648223F123F123F17152100؛34AA0؛648223F123F123F16152100؛3D8919111FFFFEFF88300؛5002FFFFFF858300؛FD8300؛4EDD؛؛83A0؛6F8200؛؛83A0؛128200؛EFDD00؛؛83A00010A1F6A0؛648223F123F123F1A00010918220؛؛A00B83600010C682A0؛7737AD81A0؛8A82206D91A00010818230213031A000107182206171A0؛D737A0؛C737600010858241F141F141F1101100؛A0E083؛502283؛FFFFFFE28300؛A002؛50F1E340115011FFFFFF148300؛200262FFFFFFC493600010658200؛2002A0؛FE82A0؛B337AD71A0؛2782E021E031A0001061825011206D91A0؛6782E021E031A000106182501120A0؛2437AD81A00؛A82F021F031A000105182E021E031A000106182501120AD81A0؛1A82F021F031A000105182E021E031600010C5825011208021؛D0A683؛B0E5؛703A؛602A؛D0B7؛C09A؛506B؛50D5؛206A؛C040؛10FF؛D0F600؛B0540090C0EF؛B0A78311؛73؛E087009003B100A20011؛؛8300؛5083؛؛830031A0؛C737300011؛6300؛B10020033100FFFFFF3F83FFFFFF8F83A2001100؛30830031A0؛2C37300011؛5300؛B100200331FFFFFF1F836000107582812000A2؛؛2083A0001041822000E600A200FFFFFFBB83A0؛38827100100221022000FFFFFF2B830؛؛262FFFFFFDB93610؛؛2A000103182A0؛B33755F132F12000FFFFFF6E83A0001021F67120؛؛D083A0001011828120؛؛258300؛7500؛1054؛C0EFFFFFFFFE8300؛7583A000100182200011؛1000؛7700400331FFFFFF1683A0؛47F6A0؛24376DA0؛3782102150E0A0؛17821021A0؛24376DA0؛37821021AD3011A0؛27821021A0؛17821021201100FFFFEF2A8362FFFFEFCA93600010658200؛10026000103582244B؛22؛؛22A0؛7737301130116DA0؛37821021AD3011A0؛278210216DA0؛17821021AD3011A0؛67821021201100FFFFFFCE834031201100FFFFFF0783FFFFFF5783FFFFFFF88330318D8150E000؛F1836000103582244B؛222C4B؛22A0؛773730113011A0؛378210216DA0؛17821021AD3011A0؛67821021201100؛؛836000103582244B؛223C43؛22A0؛773730113011A0؛37821021A0؛178210212011FFFFFF1983A0؛778240E0504030102100A24011FFFFFF49830؛؛262FFFFFFF9A360001065820؛؛2A0؛87F6244B؛22244B؛22A0؛7737301130116DA0؛37821021AD3011A0؛27821021A0؛178210212011؛؛9C832031A0؛5737؛10848300؛11؛10D400؛2054؛C0EF00؛378311؛43؛104A0060033100؛FFFFEF878300؛100262FFFFEF38A360001065820؛؛2A0؛87F6244B؛22؛؛22A0؛7737201120116DA0؛378210F0AD2011A0؛278210F06DA0؛178210F0AD2011A0؛678210F0101100FFFFEFDC8362FFFFEF7D9360001065820؛؛26000103582244B؛222C4B؛22A0؛773720112011A0؛378210F06DA0؛178210F0AD2011A0؛678210F0101100FFFFFFA583A0؛87F6244B؛22244B؛22A0؛7737201120116DA0؛378210F0AD2011A0؛278210F0A0؛178210F01011؛؛9383A0؛87F6244B؛223C43؛22A0؛773720112011A0؛378210F0A0؛178210F01011FFFFFF29836000104582A0؛24376DA0؛378210F040A0؛178210F0A0؛24376DA0؛378210F0AD2011A0؛278210F0A0؛178210F010110؛؛48320318D8140FFFFFF6E83FFFFFFBE8300؛A0831031A0؛573700A20011000؛1830031101100؛10D183000؛A؛102200؛20540030C0EF00؛328311؛61؛10190060033100A2A00؛9F6؛90EFA200A2A00010F0F6؛90EFA200A2A0؛8A82؛90EFA200A2A0؛EAF6002090EF001090EF؛90EFA4A2A0؛4C82؛90EF00E200A2A0؛6BF6001090EF؛90EFA300A2A0؛C382001090EF؛90EFA300A2A0؛A882؛90EFA200A2A00010E082001090EF؛90EFA300A2A00010D082001090EF؛90EFA300A2A0؛BFF6؛90EFA200A2A0؛63F6؛90EFA200A2A00010C0F6؛90EFA2A2A0؛8282؛90EF00E2A2A0؛4982001090EF؛90EF00E3A2A00؛E8200E100A2A0؛EEF6؛90EFA2A2A0؛6F8200E100A240؛D4E7A1؛A210EF4140؛D4E76210؛62A130D0A5203B0؛؛11000؛FFFFEFE583A0؛2BF6001100؛؛83A0؛8BF61011FFFFBFDD8300؛2002A0؛59F6A00010B0F620101100FFFFCF1583600010848260؛468291A0؛77377BA0؛4C82C6A00010A08240214031A0001060F650117BA0؛4C82C6A00010908240214031A0001060F650117BA0؛4C82C6A00010808240214031A0001060F650117B6000107482C6A00010708240214031A0001060F6501150111011FFFFDF5083A0؛E7F660؛468291A0؛7737ADA1A0؛8A8220AD91A0؛A882207171A0؛D73730111011FFFFCFA98300؛300262A0؛5B82714141412A10؛30C86181522A10؛30C86171522AA0؛4BF60011615210؛41D8910700107F2741600010B4823000؛؛8300؛50DD؛؛83A0؛6F8200؛؛83A0؛128200؛F1DD00؛؛83A0؛98F600A0؛78F6615200A0؛88F67152A0؛6837A0؛5882A0؛7737600010948220AD41F1A0؛A8822061B1A0؛C737600010A48220A0؛3DF620A0001050F6201011؛؛1026836000106482811011A2؛؛CF835031A0؛F837244B؛22A0؛648282F182F182F1A0؛648282F182F182F1A0؛7737AD81A0؛8A8220AD71600010448220616100FFFFEFCC830031A0؛3B37A0؛8A8220A0؛A8822000FFFFFFD283A0001040F6A0؛2437AD91600010948220AD31F1A0؛A88220A0؛243781AD31F1A0؛A88220A0؛2C37A0؛6482D2F1D2F1D2F1101100FFFFEF00830؛؛262FFFFEFB09360001093820؛؛260001033821011A0؛2437B1ADB0F1A0؛A88220A0؛2437A0F1ADD1A0؛A88220A0؛2437A0F1ADE0F1600010448220A0؛243701F1ADB0F1A0؛A88220A0؛2437C0F1ADD1A0؛A88220A0؛2437C0F1ADE0F1A0؛A88220A0؛6482C3F1C3F1C3F12000؛104383؛؛6083A0؛E7F660؛468291A0؛7737AD91A0؛8A8220AD91A0؛A882207171A0؛2C37A0؛648273F173F173F1101100؛1076831031A0؛DA820011FFFFEF5D8362FFFFEFFD93600010938200؛1002A0001040F6A0؛2437AD91A0؛8A8220AD51F1A0؛A88220A0؛243781AD51F1A0؛A88220A0؛2C37A0؛6482D2F1D2F1D2F110110؛؛683A0؛E7F660؛468291A0؛7737AD71A0؛8A8220AD71A0؛A882206161A0؛2C37A0؛648241F141F141F1101100؛20BC833031A0؛F837244B؛22A0؛648282F182F182F1A0؛648282F182F182F1A0؛7737AD91A0؛8A8220AD71A0؛A88220616100؛104A83A0001040F6A0؛2437AD91A0؛8A8220AD41F1A0؛A88220A0؛243771AD41F1A0؛A88220A0؛2C37A0؛648273F173F173F11011؛؛BB83؛40E0؛206400؛5؛؛C00؛40540020C0EF؛20648311؛33؛405400A003B1؛FFFFFF9083A000103082812000FFFFFF40830؛؛262FFFFFFF0A3710؛؛26000105482A0؛B33751F160001044822020؛؛A283A0؛4DF6A0؛C837611400؛220700107D272000A200؛؛83A00010208201F12000FFFFFFA88340؛B4D7612000FFFFFFED83A0001010F6A0؛948220؛؛E283A0001000F6A0؛D3822000FFFFFF588362FFFFFFF8936100؛100260001034827120؛؛B3836000102482A0؛FF376000102360EF202000FFFFFF9D8340؛C4D7A0؛648273F173F173F12000؛E283A0؛38827100108221022000؛3B83A0؛28F67120؛؛498300؛B700؛9900؛2054؛C0EFFFFFFFFE8300؛F483A0؛EF82200011؛10؛10E10050033100FFFFFF3F83A00؛88220A2؛؛208340؛C4D7302000A600FFFFFF3F83FFFFFF8F83A2001100؛3083003140؛C4B7200011؛9100؛B10020033100FFFFFF5D83A0؛DFF660001014822011A0؛D737A0؛C737A0؛648291F191F191F180E000A200FFFFEFDF8362FFFFFF7093600010938200؛1002A0؛9FF660E0201100FFFFFFC18362FFFFFF62A360001083820؛؛2A0؛9FF640E0001100FFFFFFDB83A0؛CFF6A0؛BFF60011A0؛C7373080E000FFFFFFA783A0؛DFF6A0؛BFF60011A0؛D737A0؛C737A0؛648291F191F191F180E0؛؛2683A0؛9FF650E02011FFFFFF8D830031A0؛AF37؛؛E583A0؛9FF650001100؛؛83A0؛9FF640001100؛9B83A0؛CFF6A0؛BFF62011A0؛C7373080E0؛؛24832031A0؛AF37؛؛D083A0؛9FF670E02011؛؛598300؛5000؛A900؛20540010C0EF00؛768311؛23؛10330050033110؛6200؛A1؛2027؛20C600؛6000؛؛؛؛؛52؛203100؛48؛10F800؛20؛431400؛A200؛؛83A0؛8FF64000FFFFDF268300؛؛83A0؛7FF640؛؛218300؛71DD؛؛83A0؛6F8200؛؛83A0؛128200؛13DDFFFFFF12833031A0؛C737A0؛D38200؛FFFFDF0D8362FFFFDFAD9360001093820؛؛200؛7183000؛؛383CD00؛؛8360001004823011؛؛8300؛2183؛؛8300؛F0A33011؛؛A5DD00؛؛83A0؛5FF6A0؛5882A0؛7737A0؛278220212031A0؛EEF640ADA1A0؛678220212031A0؛EEF640A0؛378220212031A0؛EEF6406D81A0؛178220212031A0؛EEF6403011600010F38240A0؛4F82600010E382A0؛3FF6A0؛2FF640A0؛1F822020A0؛DEF640؛؛FA83A0؛29F6A0؛7737AD71A0؛278220212031A0؛EEF640AD71A0؛678220212031A0؛EEF640A0؛378220212031A0؛EEF640A0؛178220212031A0؛EEF64000A00؛FF66152A0؛2C37A0؛4982A0؛C482A5F1A0؛DEF64000؛؛83A0؛48F6A0؛FE37A0؛B337A0؛278220212031600010B38240A0؛678220212031A0؛EEF640A0؛2437A0؛378220212031A0؛EEF640A0؛178220212031A0؛EEF6401011A0؛DEF640؛107983A0؛48F6A0؛EEF640A0؛C737A0؛648282F182F182F1A0؛DEF640؛؛72831031A0؛F837244B؛22600010D382A00؛E8261A0؛4982600010C382E1F1A0؛EEF64000FFFFFF3D8300؛4393401100؛C083A0؛48F6600010B38240A0؛C73740؛C4B720A0؛DEF64000؛C58300؛6200؛1600؛2054؛C0EF؛؛836200؛A0A3600010838200؛1002403110EF71F571A0؛CEF640؛؛20C88311؛13؛201B009003B1FFFFFF5E83FFFFFFAE83؛؛830031A0؛BE822000A2001100؛3083110؛3000؛20020033110؛62A100723100410؛؛11000FFFFFF0C8340؛B4D7302000FFFFFF1C83FFFFFF6CDD؛؛83600010A38200؛؛83A0؛1282FFFFFF0EDD00؛؛83A0؛AE823020؛FFFFFF2F83A00؛8822000A2؛؛148300؛؛؛35003003B1FFFFFF5E83003140؛B4B72000A20011؛؛8300؛508300؛D08311؛1؛؛20020033100A2A0؛4BF6؛90EFA200A2A0؛48F6002090EF001090EF؛90EFA4A2A0؛6482002090EF001090EF؛90EF00E400A2A0؛5CF6001090EF؛90EFA300A2A0؛6CF6001090EF؛90EFA300A2A0؛8A82؛90EFA2A2A00؛58200E100A2A0؛63F6؛90EFA200A2A0؛9E82؛90EFA200A2600010E2F6001090EF؛90EFA300A2A00؛882؛90EFA200A2A0؛F982001090EF؛90EFA300A2A0؛E982001090EF؛90EFA300A240؛A4E7A1؛A210EF4140؛A4E76200FFFFDF4383600010628281101100FFFFDF428300؛40024031A0؛F837244B؛22A0؛648282F182F182F1A0؛648223F123F123F1201100FFFFDFF48362FFFFDF95A3600010C1820؛؛2A0؛29F62011A0؛2C37A0؛648241F141F141F1101100FFFFDF288300؛20021031A0؛DA820011FFFFDF1E83A0؛1CF600A0؛88F6715200A0؛78F66152A0؛6837A0؛3C82A0؛2437C0F1C1F160115011A0؛39F6201011FFFFFFE183A0؛2BF6001100FFFFFFE183A0؛7782ADB0F1600010528220ADB0F1A0؛8A8220B1B13021FFFFEF73839031A0؛F837244B؛2260001082826DB1A0؛A78240؛94C7206DB1A0؛B78240؛94C7206DB1A0؛978240؛94C72040؛94B7203011FFFFFF6C835031A0؛C837711402؛220700203127؛؛؛C8836031A0؛C737A0؛648200؛8C0200؛8C0200؛8C02FFFFFF6983A0؛29F6A0؛7737AD91A0؛8A8220AD91A0؛8A82207171A0؛2C37A0؛648273F173F173F1101100A200؛10C883A0؛6BF6811011؛1082830031A0؛3B37A0؛8A8220A0؛A8822000FFFFFF5783703160001011822000؛101983A0؛59F6A0؛FAF620101100؛10C183A0؛8BF61011؛108083A0؛7782AD71A0؛8A8220AD71A0؛8A82206161202100؛7C83A0؛29F63011A0؛2C37A0؛648291F191F191F1101100FFFFFF048300؛200262FFFFFFB4A3600010C18200؛3002؛1020937011FFFFFF168300؛100262FFFFFFC693600010D18200؛100262A0؛5B82714141412A10؛30C86181522A10؛30C86171522A600010A2820011615210؛41D8910700107F2741A00؛9F630؛؛47836000109282301190111011؛202483A0؛48F620114011101100؛DD83600010728291101100؛10438300؛31؛107A00؛6C00؛4E؛109300؛50540080C0EF؛10E28311؛F2؛203F00900331؛FFFFFFB68362FFFFFF5793610؛؛240؛94D760001042822000FFFFFF2D83A0؛388271؛80200220FFFFFF3C83A0؛28F67120FFFFFFED83A0؛93F6A0؛94822000FFFFFF8C83A0؛E3F6A0؛C48220؛؛E28340؛64D7612000A2؛؛E483A0؛C382A0؛B33781F100؛690220؛؛948300؛E400؛1054؛C0EFFFFFFFFE8300؛1383A0؛CA82200011؛1000؛6A00400331A200FFFFFF8E8340؛94D73020؛؛D083A00؛8822000؛B083E7A20011FFFFFF8E83003140؛94B720؛؛E08300؛318300؛A08311؛91000؛200200331؛؛4210423E001400200؛11000FFFFEFDA83003171A2FFFFEF9983FFFFEF8AA3A0؛8E822000FFFFEF898362FFFFEF2A93600010D1820؛؛200؛؛8300؛C28300؛1383CD00؛؛83600010328210؛F2575011؛؛8300؛719310؛F257501100؛A5DDFFFFFF938362FFFFFF3493600010D1820؛؛2303161FFFFFF7683FFFFFF08A3301100؛C08300؛218330EF4120؛71572011FFFFFF2C834031A0؛7EF6501100؛؛؛218300؛73B3202011؛؛83203110؛9147A0؛6EF6501100؛A68300؛50A34011FFFFFF3B8300؛100262FFFFFFEBA3600010D1820؛؛260001021F66120؛7147201100؛338300؛C58300؛A08300؛468300؛D88300؛C600؛2900؛20540010C0EF000؛2835031A0؛5EF6A00؛4F6A0؛2A822000؛10D083؛10C1930011؛10B483؛10158310EF6140؛74B720؛؛83؛10368300؛928300؛E200؛10540060C0EF؛10868311؛E2؛1078003003B100FFFFFF2F8360001071822000A2؛؛208360001022822000A600FFFFFFAE83003140؛84B720FFFFFFEC8310310011FFFFFF4A830؛؛262FFFFFFFAA3600010D1820؛؛2303120؛8147A00؛C82301011FFFFFF1F8300؛E20410110011A200؛10830031B2؛40821011301140؛84C720؛؛8300؛5000؛10540020C0EF00؛968311؛D200؛B700400331؛FFFFFFF88362FFFFFF99A3600010C1820؛؛2FFFFFFAC0410110011FFFFFF3D83003140؛84B72000؛D0830031B2؛40821011201140؛84C720A2FFFFFF3E831031001100؛A083203120؛8147A0؛EB8230101100؛D18300؛2200؛10540030C0EF00؛648311؛C200؛670040033100؛FFFFFF8E83FFFFFF1E930011FFFFFF7E8360001021827120FFFFFF0E83A0؛DB823020؛؛9183003110EF6140؛74B72000A2؛؛208311؛8000؛D300300331FFFFFF3A8340؛74D7302000FFFFFF7E836000101282201011FFFFFF2F83A00؛8822000A2؛؛E08300؛80931011؛؛83103140؛84B72000FFFFFF3D8362FFFFFFDD93600010D1820؛؛260001071822000؛B183000؛200؛1054؛C0EF00؛268311؛B200؛4700300331FFFFFF8E83003140؛74B72000FFFFFF3F83FFFFFF8F83A2001100؛D08311؛8؛؛20020033100؛FFFFFF7E83A0؛9B82302000FFFFFF2F83A00؛8822000A2؛؛E0832800FFFFFF3E83A0؛CB8281F12000؛؛83A0؛BB82302000A2؛؛2083A800؛FFFFFF8E8340؛64D7712000FFFFFF6E8360001002822000؛B083600010F182302000A2؛؛20832BA200FFFFFF8E8340؛64D76120؛؛D083A00؛8822000؛B083600010E182302000E9FFFFFF8E8340؛64D7812000FFFFFF3F83A00؛88220A2؛؛D083A0؛B982302000E900؛FFFFFF6E83A0؛AA82302000FFFFFF8E8340؛64D7712000FFFFFF3F83A00؛88220A2؛؛A1832B00A2A0؛8BF6؛90EFA200A2A0؛88F6001090EF؛90EFA3A2A0؛4E82؛90EF00E200A2A0؛E7F6002090EF001090EF؛90EFA4A2A0؛6482002090EF001090EF؛90EF00E400A2A0؛3E82؛90EFA200A240؛34E7A1؛A210EF4140؛34E76200؛FFFFFF0383600010A0821011FFFFFFA583FFFFFFBE935011FFFFFFA583603140؛24B720؛A200FFFFDF4883A0؛59F6A0؛FAF6201011FFFFFFDD8360؛7682401191A0؛2E82201011؛؛9383503130EF61701100FFFFEF6683A0؛EAF660؛468281A0؛7737AD91A0؛8A822070117171A0؛F837244B؛22A0؛648232F132F132F1A0؛6482E1F1E1F1E1F1A0؛7737AD91A0؛8A8220701171711011FFFFEF4483FFFFEF5F936011FFFFDF678300؛3002A0؛2BF6001100FFFFEFBC831031A0؛DA820011FFFFDF2D834031100؛34AA0؛648223F123F123F1D152100؛34A600010608213F113F113F1C152100؛34AA0؛648203F103F103F1B152100؛34AA0؛6482F2F1F2F1F2F1A152100؛34A6000106082E2F1E2F1E2F19152100؛34AA0؛6482D2F1D2F1D2F18152100؛34AA0؛648282F182F182F17152100؛34AA0؛648241F141F141F16152100؛3D8E1FFFFEFF2830020E0EF00؛200262A0؛5B82714141412A10؛30C86181522A10؛30C86171522AA0؛4BF60011615210؛41D8910700107F2741A00؛9F63000؛FFFFEF6983600010708260؛468281A0؛7737AD91A0؛8A822070117171A0؛2C37A0؛6482D2F1D2F1D2F1101100FFFFFF5683A0؛6BF681101100؛1483A0؛98F6006000109082715200A0؛78F67152A0؛6837A0؛5882A0؛7737AD71A0؛8A8220AD71A0؛A8822071613011A0؛C837711401؛2207002031276000108082A0؛1E82070020722710؛30C860؛BF82201011؛20338370317BA0؛4C82A5C6A0؛A88220B5C6400؛4B720C640؛14B72000؛1081833031A0؛C737A00؛E8200؛107C830031A0؛3B37A0؛8A8220A0؛A8822000FFFFFF67830؛؛262FFFFFF18A360001030820؛؛2A0؛EAF660؛468291A0؛7737AD71A0؛8A8220AD71A0؛A882206161A0؛C737A0؛648223F123F123F11011FFFFFF0C8362FFFFFFACA3600010308200؛10023031A0؛C737A00؛E8200؛20DD83؛30A0؛3072؛30C0؛202E00؛40540020C0EF00؛E88311؛A2؛301500A0033100FFFFFFFB8340؛F3D723F120FFFFFF6983A0؛28F6712000؛C08340؛E3D7612000A200FFFFFFA88362FFFFFF49936100؛1002400؛4D746F12000؛828340؛24D76120FFFFFFFA8362FFFFFF9B93610؛؛240؛14D76120FFFFFFDD83A0؛388271؛80200220؛؛F483A0؛93F6A0؛948220؛؛B38300؛82000؛400؛2054؛C0EFFFFFFFFE8300؛D783A0؛CA82200011؛1000؛FA0040033100FFFFFF24830؛؛262FFFFFFD49360001040820؛؛240؛E3D7612000FFFFFFFC8300؛50930011FFFFFF7883A0؛558240؛F3B72000FFFFFFAC83456D71A4101110315240؛E3C72000؛4183A00؛8822000FFFFFF2D83FFFFFFFB83؛؛848300؛1183؛؛7483003110EF6120EFA0؛A8822040؛E3B720FFFFFFBC8362FFFFFF5D93600010408200؛100230317100؛؛A18300؛D48300؛5000؛2500؛20540020C0EF00؛858311؛9200؛7C0040033100A200؛؛8360001050822000A300A200؛؛83A00؛88220؛؛8340؛24D7302000A6A20011FFFFFF8E83003140؛24B720؛؛E08300؛318300؛A08311؛8؛؛200200331؛FFFFFFBB83A00؛88220FFFFFFA9830؛؛262FFFFFF5AA360001030820؛؛2FFFFFF3D931011FFFFFFAD831001400؛4B720FFFFFF6D83203130؛A2؛؛A38340؛14D73020؛؛6283103120EF400؛4B720201100؛A28300؛F200؛1054؛C0EF00؛238311؛7200؛A700300331FFFFFF5C83203140؛14B72000FFFFFFF88362FFFFFF999360001040820؛؛220316100؛؛8300؛E183FFFFFF3D83FFFFFF8D8300؛A08300؛9183؛؛8300؛91A3101100؛3483FFFFFF8F83A2201100؛D083103140؛14B72000؛؛218300؛7100؛1054؛C0EF00؛218311؛8200؛480030033100؛FFFFFF9A83103140EF40؛14B7202011FFFFFF1A830؛؛262FFFFFFCA9360001030820؛؛2400؛4D73020؛؛2283203130؛A2؛؛C08340؛14D73020؛؛8300؛D193101100؛8183A00؛88220؛؛8300؛5000؛1054؛C0EF00؛738311؛7200؛9700300331FFFFFF5E83FFFFFFAE83؛؛830031400؛4B72000A2001100؛308311؛1؛؛20020033100A2A0؛8A82؛90EFA200A2A0؛28F6001090EF؛90EFA300A2A0؛93F6001090EF؛90EFA3A2A0؛6482002090EF001090EF؛90EF00E400A2A0؛ADF6001090EF؛90EFA300A2A0؛34F6001090EF؛90EFA300A2A0؛FDF6001090EF؛90EFA300A2A0؛EDF6001090EF؛90EFA300A2A0؛1DF6؛90EFA200A2A0؛FCF6001090EF؛90EFA300A2A0؛39F6؛90EFA200A2A00؛882؛90EFA200A2600؛DF6؛90EFA200A240؛D3E7A1؛A210EF4140؛D3E762A260؛3E8220E1A260؛2E8220E100FFFFDFB883A0؛ABF6ADA0F1A0؛A88220401100؛FFFFEFD083A0؛7782AD71A0؛8A8220AD71A0؛A882206161202100FFFFDF5583FFFFDF9B936011FFFFEF2B838031100؛34A60؛5F8223F123F123F1D152100؛34AA0؛648213F113F113F1C152100؛34A60؛5F8203F103F103F1B152100؛34AA0؛6482F2F1F2F1F2F1A152100؛34AA0؛6482E2F1E2F1E2F19152100؛34AA0؛6482D2F1D2F1D2F18152100؛34AA0؛648282F182F182F17152100؛34AA0؛648241F141F141F16152100؛3D8E100FFFFDFB88300؛3002A0؛59F6A0؛FAF6201011FFFFEFF483A0؛BDF660؛8D82204011FFFFFF5C83A0؛2BF6001100FFFFEFD183703160؛AD822000FFFFEF3683FFFFFF50935011FFFFFFD48360؛76828011912011101100A200FFFFDFFE8300؛5002A0؛6BF6811011FFFFEF158360؛4F82714011FFFFEFA0830030E0EF00؛6002A0؛EAF660؛4682912011A0؛C737A0؛648223F123F123F11011FFFFEFB38300؛200262FFFFEF64A360؛AE8200؛400262A0؛5B82714141412A10؛30C86181522A10؛30C86171522AA0؛4BF60011615210؛41D8910700107F2741A00؛9F63000FFFFEF4B830031A0؛3B37A0؛8A8220A0؛A88220؛؛3F834031600؛DF620؛؛6E83A0؛CBF6ADB0F160؛8F8220600؛DF62000FFFFEFFC830؛؛262FFFFEFAD9360؛AE820؛؛2؛20A28300؛؛100383A0؛8BF61011؛10B583403141؛FFFFFF708300؛200260؛1F8260؛6D82204011؛؛E283A0؛ADF661401100FFFFFFD28300؛100262FFFFFF839360؛BE8200؛1002503110EF6160؛8D822000FFFFFF5983A0؛CB826DB0F1A0؛8AF6600؛DF6202000؛5683A0؛CCF660؛2D8220401100FFFFFF7E83A0؛ADF671401100؛F58300؛2A83؛؛10A883FFFFFF1D937011FFFFFF8D83؛209E83؛؛203C83603160؛AD822000؛20CF8360؛4F8261401100؛10BC831031A0؛DA820011؛10B083؛102F؛20EF00؛2E؛2045000؛6؛2040؛100100؛70540030C0EF؛10D58311؛62؛30F500900331FFFFFF318340؛B3D76120FFFFFF9783A0؛AC82A0؛BC3760؛9E60EF202000FFFFFF968360؛6F8260؛5F8223F123F123F12000A200FFFFFF628362FFFFFF03A37100؛1002A0؛83F607؛1B272000FFFFFF0B8360؛5E8220FFFFFF258300؛2002A0؛C382A0؛B33781F100؛78022000FFFFFFAB8360؛1DF6A0؛DD3720؛؛9383A0؛14F6600؛DF620A00؛48220؛؛8283A0؛E3F6A0؛D3822000FFFFFFEB8340؛83D76120؛؛B88360؛7F82712000FFFFFFEB8362FFFFFF8CA3710؛؛240؛C3D7612000؛1E8340؛93D7؛F7FF022000؛898300؛D200؛7C00؛D900؛3054؛C0EFFFFFFFFE8300؛8F83A0؛CA82200011؛10؛10820050033100؛FFFFEF1F83A0؛ADF661001100FFFFFF2883FFFFEF65931011FFFFEF4883A0؛CCF660؛2D8220001100FFFFEF358300؛42934011FFFFFF10830031600؛DF620؛FFFFEF998360؛4F82610011؛؛C383103160؛8D822000FFFFFFD98360؛1F8281001100FFFFFF9883A0؛ADF6710011FFFFFF3A83203160؛AD8220FFFFFF018360؛FE82A0؛648223F123F123F1001100FFFFEFCA830؛؛262FFFFEF7BA360؛BE820؛؛260؛2F8261001100FFFFEFBC830030E0EF00؛300200؛F7932011A200؛7883FFFFFF538300؛؛CB83A0؛C3F6A0؛B337ADB0F1A0؛8A8220ADA0F1A0؛A88220001100؛FFFFFF718300؛2002A0؛9DF6A0؛CDE70011؛؛2883A0؛BDF660؛8D8220001100؛4D83A0؛4DF6A0؛C837611400؛220700107D27001100؛؛8360؛3F82A0؛2437A1B10011؛؛3483A0؛2DF6600؛F8220001100FFFFFF088362FFFFFFA89360؛BE8200؛4002003141؛؛10888300؛E883؛FFFFFF5E8300؛B98300؛؛106783403160؛AD822000FFFFFF1C8362FFFFFFBCA360؛AE8200؛1002A0؛ADF671001100؛1783؛1020؛1006؛10D600؛D300؛6700؛50540030C0EF؛104B8311؛52؛201000500331FFFFFF5C83003110EF6160؛8D822000A200؛؛؛83A0؛CB8281F12000؛1183A0؛BB823020؛؛D08300؛1293001100؛C08311؛8؛؛400300331؛A200؛؛83A0؛9DF660؛EE8220600؛DF620006600FFFFFF7E83A0؛83F6A0؛8DF660؛CE82202000A2؛؛2083A700؛A2؛؛8362A0؛7DF6600؛DF62000؛؛83A0؛6D8230200028FFFFFFAD83A0؛5D82302000A200؛؛83A0؛4DF6A0؛3DF62060؛CE8220؛؛9183EA00FFFFFFBD83A00؛8822000؛؛83A0؛2DF6A0؛1DF620600؛DF62000A2؛؛2083A00؛D82302000AC00FFFFFFDD83A0؛FCF6A0؛FAF620600؛DF62000FFFFFF2F83A00؛8822000A2؛؛E083A0؛EC82302000AC00؛A200FFFFFF7E83A0؛9B823020؛؛D083A00؛88220؛؛C0832800A200A0FFFFFF6E8340؛C3D7302000A200؛؛83A00؛8822000؛D083E7FFFFFF5E83003140؛C3B72000A20011؛؛8300؛508300؛D08311؛8؛؛200200331FFFFFF8E8340؛B3D7302000FFFFFF3F8360؛DE8220A2؛؛D083E700A20011؛؛8300؛5083؛؛83003140؛B3B7200011؛8000؛B100200331A200FFFFFF8E8340؛A3D73020؛؛D083A00؛8822000؛B083E7FFFFFF5E83003140؛A3B72000A20011؛؛8300؛508300؛D08311؛42000؛20020033100FFFFFF1D8340؛93D7302000FFFFFFCD83A00؛8822000؛؛83A0؛DCF660؛4D822060؛CE8220A2؛؛4283ADFFFFFF5E83FFFFFFAE83؛؛83003140؛93B72000A2001100؛308311؛1؛؛20020033100FFFFFFFC83A00؛88220FFFFFFCD83A0؛CCF660؛2D8220600؛DF620؛؛718340؛83D7302000A2؛؛F083ADFFFFFF5E83003140؛83B72000A20011؛؛8300؛508300؛D08311؛8؛؛200200331؛FFFFFF7C83103140؛73B720؛؛830031A0؛BC3760؛8E60EF20FFFFFFAB83103140؛73B720FFFFFFAA83FFFFFF8D931011FFFFFF8A830؛؛262FFFFFF3BA360؛AE820؛؛240؛73D73020FFFFFF6E83FFFFFFAE931011FFFFFF1F83A0؛ACF600111011A200؛B183A0؛9CF60011101100؛658300؛B500؛10540020C0EF00؛578311؛3200؛A90030033100؛A2؛؛8340؛73B7202300A2A0؛5B82007090EF006090EF005090EF004090EF003090EF002090EF001090EF؛90EF؛؛؛؛7200900330A2A0؛3C82؛90EF00E2A2A0؛1B8200E100A2A0؛78F6001090EF؛90EFA3A2A0؛4C82؛90EF00E200A2A0؛A882؛90EFA2A2A0؛8C8200E100A2A0؛1CF6005090EF004090EF003090EF002090EF001090EF؛90EFA700A2A0؛EAF6002090EF001090EF؛90EFA4A260؛4682001090EF؛90EF00E3A2A0؛7C8200E100A2A0؛59F6001090EF؛90EFA300A2A0؛6CF6001090EF؛90EFA300A2A0؛28F6001090EF؛90EFA300A2A0؛E3F6001090EF؛90EFA3A2A0؛C48200E100A2A0؛3882002090EF001090EF؛90EFA400A2A00؛882؛90EFA200A240؛63E7A1؛A210EF4140؛63E762؛FFFFDF3183FFFFAF318300FFFFDF7E83FFFFAFE18300FFFFAF7183A0؛7782AD71A0؛8A8220AD71A0؛A8822061612021FFFFBFB983FFFFCF1283؛؛83FFFFAF79FFFFDFECFFFFBFAA00؛30546011FFFFFFE083A0؛EAF660؛2C82A1A0؛7737ADB1A0؛8A8220AD91F160؛6C8220817BA0؛4C829504C1؛؛؛32B50400؛؛؛32C660؛6C8220A0؛C737A0؛498260؛5C82C3F1701100FFFFFF5C83A0؛EAF660؛4682A1201130117011FFFFBF7883A0؛E7F660؛4682A12011A0؛2C37A0؛6482F0F1F0F1F0F1701100FFFFFF8283A0؛EAF660؛4682A1A0؛7737ADB1A0؛8A8220AD71F1A0؛A88220817B60؛7C82950441؛؛؛32B50400؛؛؛32C6A0؛A88220A0؛C737A0؛648232F132F132F17011؛؛2F83603140؛33B720؛FFFFEF8183A0؛5CF6917011؛؛E083A0؛E7F660؛4682A1A0؛7737ADB1A0؛8A8220AD71F1A0؛A88220817BA0؛4C82950441؛؛؛32B50400؛؛؛32C6A0؛A88220A0؛D737A0؛C737A0؛648241F141F141F170110؛؛68360؛FB8281701100؛108C8360؛4C8200A0؛88F6715200A0؛78F67152A0؛6837A0؛3C82A0؛2437ADC0F1A0؛8A822001F1A0؛7B82A0؛C837611400؛2207002031270700201227701100FFFFCF9C8360؛4C8200A0؛88F671520060؛8C827152A0؛6837A0؛3C82A0؛2437ADB0F1A0؛8A822022F1A0؛7B82A0؛C837611400؛220700203127070020B027701100FFFFDFE683A0؛8BF67011FFFFBF4F8300؛6002FFFFCF9983FFFFFF8683؛103E934011FFFFCFF683A0؛1CF600A0؛88F6715200A0؛78F67152A0؛6837A0؛3C82A0؛2437ADC0F1A0؛8A822001F1A0؛1B82A0؛C837611400؛2207002031270700201227701100A200FFFFCF268300؛4002A0؛EAF660؛2C82A1A0؛7737ADB1A0؛8A822091F181A1A0؛C737A0؛498260؛1C8205F17011FFFFCFB98300؛7002600؛C82A0؛9482701100؛309283A0؛1CF600A0؛88F6715200A0؛78F67152A0؛6837A0؛3C82A0؛2437ADC0F1A0؛8A822001F1A0؛1B82A0؛C837611400؛2207002031270700201227701100FFFFEF0483A0؛E7F660؛4682A1A0؛7737ADB1A0؛8A822091F18181A0؛D737A0؛C737A0؛648241F141F141F1701100FFFFDF838362FFFFDF249360؛9B8200؛50026260؛BC82714141412A10؛30C86181522A10؛30C86171522AA0؛4BF60011615210؛41D8910700107F2741A00؛9F630؛FFFFDF788362FFFFDF19A360؛8B820؛؛200؛518300FFFFDF6A830؛؛262FFFFDF1BA360؛8B8200؛2002A0؛1CF600A0؛88F6715200A0؛78F67152A0؛6837A0؛3C82A0؛2437ADB0F1A0؛8A822022F1A0؛1B82A0؛C837611400؛220700203127070020B027701100FFFFEFC08300؛800262FFFFEF719360؛8B8200؛400260؛3C8260؛4682A1A0؛7737ADB1A0؛8A822091F18181A0؛C737A0؛648232F132F132F1701100؛202583؛10AF؛203C؛107500؛30545011؛20B083A0؛2BF6001100FFFFEF8A83A0؛E7F660؛4682A1A0؛7737AD91A0؛8A8220AD91A0؛A882207171A0؛2C37A0؛648223F123F123F17011؛؛7483503140؛33B720؛FFFFFF4A83؛10D38300؛108283A0؛1CF600A0؛88F6715200A0؛78F67152A0؛683760؛AC82A0؛2437ADB0F1A0؛8A822022F160؛9C82A0؛C837611400؛220700203127070020B027701100FFFFFFB18362FFFFFF529360؛9B8200؛10023031A0؛F837244B؛22A0؛6482D2F1D2F1D2F1A0؛648282F182F182F1201100؛504383؛105D83؛؛40F183A0؛6BF6817011؛50BC837031A0؛DA820011FFFFFF08830؛؛262FFFFFFB8A360؛8B8200؛300200؛538300؛308B83؛20A183؛؛B2830031A0؛3B37A0؛8A8220A0؛A8822000؛305B834031600؛B822000؛207483؛20B900؛E7؛204D؛303E؛102800؛2700؛C2؛50C9؛20C400؛90540010C0EF000؛48311؛22؛606900900331FFFFFF8D8360؛DB8260؛CB822000A200FFFFFFDC83A0؛C382A0؛B33781F123F12000FFFFFF5A830؛؛262FFFFFF0BA3710؛؛260؛EB82712000FFFFFF1D8360؛BB8271002080200220؛؛8340؛33D76120؛؛3583A0؛93F6A0؛948220؛؛268300؛7600؛1054؛C0EFFFFFFFFE8300؛8283A0؛CA82200011؛1000؛8900400331؛FFFFFF3C83303140؛53B720FFFFFFC98362FFFFFF6AA360؛8B820؛؛23031B2؛30821011201140؛53C720A2FFFFFF5D831031301100؛908300؛50041011301100؛8183203120؛4147A00؛C8230101100؛418300؛9100؛1054؛C0EF00؛468311؛1200؛670040033100FFFFFFEB83FFFFFF4C0410113011؛؛833031B2؛30821011201140؛53C720؛؛83203120؛4147A0؛EB82301011؛؛8310313011A2FFFFFFDC8362FFFFFF7DA360؛8B820؛؛2303140؛53B72000؛E18300؛5000؛3200؛2054؛C0EF؛؛83؛E0EF00؛100211؛1200؛3800400331؛A200؛؛83A0؛DB82302000FFFFFF0B8340؛43D710EF6140؛43B7202000FFFFFF7B830؛؛262FFFFFF2CA360؛8B820؛؛2000؛393101100؛638360؛FCF620101100؛D083103140؛53B72000؛D08300؛2100؛1054؛C0EF00؛D483110؛200؛670040033100؛FFFFFF7D83A0؛CB8281F12000؛؛83A0؛BB82302000FFFFFF0F83A0؛AB8223F12000A20؛؛1832CFFFFFF6E83A00؛88220؛؛8340؛43D7302000A2؛؛2083E7FFFFFF5E83003140؛43B72000A20011؛؛8300؛508300؛D08311؛8؛؛200200331A200؛؛83A00؛8822000؛؛83A0؛9B82302000E600؛A200FFFFFFBD83A0؛F9823020؛؛D083A00؛88220؛؛8340؛33D77120؛؛81832B00؛A200FFFFFFBD8340؛33D7612000؛؛83A0؛E9823020؛؛A18360؛AB822000؛B0832BFFFFFF3F83A00؛88220A2؛؛208340؛33D7812000؛؛83A0؛B982302000E900؛FFFFFF9D83A0؛AA82302000A200؛؛83A00؛88220؛؛8340؛33D77120؛؛A1832B00A2A0؛39F6؛90EFA200A2A0؛A882؛90EFA200A2A0؛B8F6005090EF004090EF003090EF002090EF001090EF؛90EFA7A2A0؛6482002090EF001090EF؛90EF00E400A2A0؛C382001090EF؛90EFA300A2A0؛E3F6001090EF؛90EFA300A240؛13E7A1؛A210EF4140؛13E762؛FFFFEFEA8360؛668240112011601100FFFFEF5183FFFFDF53B3715011FFFFCF5D8300؛100262FFFFCF0EA360؛3A8200؛2002A0؛7782AD71A0؛8A8220AD71A0؛A882206161202100؛338300؛8383FFFFDFE08362FFFFDF819360؛4A820؛؛2FFFFEFE78300FFFFDF928362FFFFDF33A360؛3A8200؛1002FFFFEFD4935011FFFFDF8C834031100؛34AA0؛648223F123F123F1E152100؛34AA0؛648213F113F113F1D152100؛34AA0؛648203F103F103F1C152100؛34AA0؛6482F2F1F2F1F2F1B152100؛34AA0؛6482E2F1E2F1E2F1A152100؛34A60؛7A82D2F1D2F1D2F19152100؛34AA0؛648282F182F182F18152100؛34AA0؛6482D2F1D2F1D2F17152100؛34AA0؛648241F141F141F16152100؛3D890F1؛؛1B835031400؛3B72000؛؛F083A0؛6BF6816011A200FFFFFF958362A0؛5B82714141412A10؛30C86181522A10؛30C86171522AA0؛4BF60011615210؛41D8910700107F2741A00؛9F63000؛10E4836031A0؛DA82001100؛E083A0؛98F600A0؛88F6715200A0؛78F67152A0؛6837A0؛5882A0؛7737B1F1AD71A0؛A882209161A0؛1B82301160؛AA8220601100FFFFFF4B8300؛5083FFFFFFB783A0؛8BF66011FFFFEFFB8300؛400260؛8A82D1F1AD11F1A0؛A88220D1F101F1A0؛D737A0؛C737A0؛6482D2F1D2F1D2F1601100FFFFFFC283A0؛B8F6E1F1AD01F1A0؛A88220E1F1F0F1A0؛D737A0؛C737A0؛648241F141F141F1601100FFFFFF628300؛3002A0؛2BF6001100FFFFFF5D83A0؛59F6A0؛FAF620601100؛1053833031A0؛C837611400؛220700107D2700؛20B983A0؛48F62011A0؛C737A0؛648223F123F123F1601100؛6383A0؛1982302000؛4E8300؛9E8300؛20B683A0؛B8F6F1F1AD11F160؛9A8220F1F101F1A0؛D737A0؛C737A0؛6482D2F1D2F1D2F1601100؛1056830031A0؛3B37A0؛8A8220A0؛A88220؛؛A48300؛1C؛10FC00؛A5؛205D00؛F400؛50540010C0EF00؛228311؛F1؛30250090033100؛FFFFFFE783A0؛93F6A0؛94822000FFFFFFFA8360؛6A82A0؛B33737F100؛EA022000A2؛؛A183A0؛388271؛80200220؛؛2183A0؛28F67120FFFFFF5B8362FFFFFFFB93610؛؛2400؛3D76120؛؛938360؛5A82A0؛648200؛DC0200؛DC0200؛DC0220؛؛938300؛E300؛1054؛C0EFFFFFFFFE8300؛C583A0؛1882200011؛1000؛5A00500331A200FFFFFF8E83400؛3D73020؛؛D083A00؛8822000؛B083E700FFFFFF3F83FFFFFF8F83A2001100؛30830031400؛3B7200011؛E100؛B10020033100A2A0؛8BF6؛90EFA200A2A0؛39F6؛90EFA200A2A0؛88F6001090EF؛90EFA3A260؛4682001090EF؛90EF00E300A2A0؛E7F6002090EF001090EF؛90EFA400A2A0؛8A82؛90EFA200A2A0؛A882؛90EFA2A2A0؛6482002090EF001090EF؛90EF00E400A2A00؛882؛90EFA200A2A0؛E982001090EF؛90EFA300A240؛F2E7A1؛A210EF4140؛F2E76200A2A0؛B982001090EF؛90EFA300FFFFFF7283A0؛E7F660؛B98291A0؛7737AD91A0؛8A8220AD91A0؛A882207171A0؛D737A0؛C737A0؛648273F173F173F1501100A200FFFFDFB48362FFFFDF559360؛498200؛2002A0؛98F60060؛C982715200A0؛78F67152A0؛6837A0؛5882A0؛7737AD71A0؛8A8220AD71A0؛A882206161A0؛7B823011A0؛39F620501100FFFFDF2D83A0؛6BF6815011FFFFDF7B8300؛3002A0؛19823020FFFFDF4C8362FFFFDFECA360؛39820؛؛2403140؛E2B720؛FFFFFF7B83FFFFFFCB8300FFFFFF078362A0؛5B82714141412A10؛30C86181522A10؛30C86171522AA0؛4BF60011615210؛41D8910700107F2741A00؛9F63000FFFFFF1683FFFFEF3B00؛B8FFFFEFEF00؛3054401100؛E98300؛D183؛؛C9833031A0؛C837611400؛220700107D2700FFFFEF9E83000؛48300FFFFFFA88360؛E9825011FFFFEFC9830031A0؛3B37A0؛8A8220A0؛A8822000؛10E48360؛A98260؛4682912011A0؛D737A0؛C73760؛7982F0F1F0F1F0F1501100FFFFFFE88300؛A983FFFFEFBC8362FFFFEF5D9360؛498200؛1002A0؛2BF60011؛؛9983A0؛98F60060؛C982715200A0؛78F67152A0؛6837A0؛5882A0؛7737AD71A0؛8A8220AD7160؛8982206161A0؛1B823011A0؛39F620501100؛105483A0؛98F600A0؛88F6715200A0؛78F67152A0؛6837A0؛5882A0؛7737AD71A0؛8A8220AD7160؛8982206161A00؛B82301160؛D98220501100؛107183A0؛59F6A0؛FAF620501100؛10DC83A0؛7782AD7160؛998220AD7160؛8982206161202100؛EE83A0؛EAF660؛4682912011A0؛C737A0؛648282F182F182F15011؛؛52835031A0؛DA820011؛10E98300؛65؛1057؛20C9؛103A00؛40540010C0EF؛10968311؛D1؛20BF00A0033100؛FFFFFF488362FFFFFFE893610؛؛2A0؛28F6712000FFFFFF1B83A0؛93F6A0؛94822000؛؛83A0؛388271؛80200220؛؛8340؛E2D76120؛؛F283A0؛E3F660؛798200؛DC0200؛DC0200؛DC022000A200؛؛8300؛5000؛1054؛C0EFFFFFFFFE8300؛9383A0؛CA82200011؛1000؛D80050033100؛FFFFFFBD8340؛E2D7612000؛؛8360؛5982302000FFFFFF3F8360؛698220A2؛؛D0832B00؛FFFFFF6E83A0؛AA82302000FFFFFF6E8340؛E2D7712000A200؛؛83A00؛8822000؛A1832B00؛FFFFFF6E83A00؛88220FFFFFF4E83A0؛F982302000A2؛؛F08340؛E2D77120؛؛F0832B00؛FFFFFF4E8360؛2982302000A200FFFFFF8E8340؛E2D78120؛؛D083A00؛8822000؛A1832B00A2A0؛7A82؛90EFA200A2A0؛BA82؛90EFA200A2A0؛AA82001090EF؛90EFA300A2A0؛9982؛90EFA200A2A0؛79F6؛90EFA200A2A0؛78F6001090EF؛90EFA300A2A0؛88F6001090EF؛90EFA3A2A0؛5882؛90EF00E200A2A0؛98F6005090EF004090EF003090EF002090EF001090EF؛90EFA700A2A0؛A882؛90EFA2A2A0؛9A82003090EF002090EF001090EF؛90EF00E5A2A0؛E882؛90EF00E2A2A0؛D882002090EF001090EF؛90EF00E4A2A0؛6482002090EF001090EF؛90EF00E400A2A0؛8A82؛90EFA200A2A00؛882؛90EFA200A240؛D2E7A1؛A210EF4140؛D2E762FFFFFFDB8360؛A8822000A200؛؛83A0؛D4F6B12000؛؛83A0؛56F6A0؛4482A0؛7A822000؛؛83A0؛46F66160؛B88220؛؛738300؛؛؛8400300330FFFFFF3883A0؛6A82302000FFFFFFE88360؛C78220FFFFFF9A83A0؛34F6A0؛5A82A0؛4A8240؛42B720A0؛3A82A0؛2A8220FFFFFFA8830؛؛262FFFFFF59A360؛A7820؛؛240؛92D7A0؛1A8220212031A0؛79F6302000؛FFFFFF4E83003140؛52B72000A2؛؛248300؛7193001100؛378340؛A2D7A00؛A8220212031A0؛79F63020؛؛8300؛5000؛10540010C0EF00؛AA8311؛C100؛CB00400331FFFFFFAD83A00؛88220؛؛8340؛82D77120؛؛8340؛52D7612000A2؛؛2083A0؛F982302000EC00؛FFFFFF9D8360؛C78220FFFFFF6E83A0؛E9823020؛؛D08340؛82D7612000A2؛؛F0832BFFFFFF6E83A00؛88220؛؛8340؛82D7712000A2؛؛208360؛9882302000E900؛FFFFFF9A83FFFFFF73930011FFFFFF80833031F520EFE140؛A2B720F540EF21F140؛A2B720F540EFAD91F1A0؛A8822040؛92B72020EFAD42F1A0؛A8822040؛92B720FFFFEF6E8340؛52D77120FFFFFF3183FFFFEF26935011FFFFDFFD830؛؛262FFFFDFAE9360؛B78200؛1002FFFFFF65936011FFFFFF6B83FFFFEF098300FFFFEF57832031F520EFE140؛A2B720F540EF21F140؛A2B720F540EFADE1A0؛A8822040؛92B72020EFAD21F160؛28822040؛92B72000FFFFEFA48300؛200262FFFFEF55A360؛B78200؛2002603110EF81A0؛D9F6A0؛998220؛؛83FFFFFF03933011FFFFFF1D83A0؛C9F66160؛888220FFFFFFC083A0؛C9F68160؛88822000؛؛83FFFFFF5283؛FFFFFF7383A0؛C9F67160؛888220FFFFEFCB8362FFFFEF6CA360؛A78200؛300240؛42D760؛78823020FFFFFF1083A0؛B982302000؛107283FFFFFFD783؛؛؛83A0؛A9F6A0؛998220؛10B2835031F520EFE140؛A2B720F540EF21F140؛A2B720F540EFADC2F1A0؛A8822040؛92B72020EFAD43F160؛28822040؛92B720FFFFFF94830؛؛262FFFFFF459360؛B7820؛؛2A00؛88220؛؛8340؛82D78120؛؛؛F28300؛708300؛FFFFFF588300؛4002؛108C932011؛20E0830031F540EFAD53F1A0؛A8822040؛92B720F5A0؛8982A0؛79F63010211031A0؛773740؛62B72060؛288220616110EF00010؛2A0؛69F63000A200؛؛8300؛DD؛10CD؛107E؛106500؛5000؛50540040C0EF؛10618311؛B1؛20D800600331FFFF2F1083؛E0EF00؛6002A0؛98F60060؛5882715200A0؛78F68152A0؛6837A0؛5882A0؛773732F1A0؛A88220AFF1CFF1A0؛C737A0؛648200؛2B0200؛2B0200؛2B028011070010FC27D01100FFFF4F2983A0؛B8F671AD81A0؛A882207171A0؛D737A0؛C737A0؛648200؛690200؛690200؛6902D01100؛؛83A0؛B8F66160؛2882206161A0؛D737A0؛C737A0؛6482B1B1B1D01100FFFFFFB083A0؛29F6A0؛773761F1B0F132F1ADC0F1A0؛A88220A0؛D737A0؛C737A0؛6482B1B1B1D01100FFFFBF8E83A0؛59F6A0؛4482D01100FFFFDF3483A0؛98F60060؛5882715200A0؛78F68152A0؛6837A0؛5882A0؛773732F1A0؛A88220BFF1BEF1A0؛C737A0؛648200؛2B0200؛2B0200؛2B0280110700103D27D01100FFFF3FD58362FFFF3F769360؛B78200؛70025031A0؛F837244B؛2260؛188274F174F174F100؛FF02A0؛4982A0؛6482A5F1A5F1A5F100؛FF02A0؛773721F1AD71A0؛A88220617100FFFF3F9B8300؛2002FFFFCFF493B011FFFF8F1F83A0؛98F60060؛5882715200A0؛78F68152A0؛6837A0؛5882A0؛773732F1A0؛A88220AFF1ADF1A0؛C737A0؛648200؛2B0200؛2B0200؛2B028011070010BC27D01100FFFF6FD7838031A0؛C837611402؛220700107E27؛؛8183A0؛98F600A0؛88F671520060؛68828152A0؛6837A0؛5882A0؛773732F1A0؛A88220BFF1BEF1A0؛C737A0؛648200؛FF0200؛FF0200؛FF0280110700103D27D01100FFFF4FAE8360؛388200A0؛88F6715200A0؛78F68152A0؛683760؛4882A0؛773732F1A0؛A88220BFF1BEF1A0؛C737A0؛648200؛2B0200؛2B0200؛2B0280110700103D27D01100FFFFAFEC83A0؛48F6A0؛773771F1A0؛A8822032F161A0؛C737A0؛6482D2F1D2F1D2F1D011FFFF6FC883A0؛98F600A0؛88F671520060؛68828152A0؛6837A0؛5882A0؛773732F1A0؛A88220AFF1ADF1A0؛C737A0؛648200؛2B0200؛2B0200؛2B028011070010BC27D01100FFFFDFEE83A0؛98F600A0؛88F671520060؛68828152A0؛6837A0؛5882A0؛773732F1A0؛A88220AFF1ADF1A0؛C737A0؛648200؛FF0200؛FF0200؛FF028011070010BC27D01100FFFFDFEE83A0؛98F600A0؛88F6715200A0؛78F68152A0؛6837A0؛5882A0؛773732F1A0؛A88220AFF1CFF1A0؛C737A0؛648200؛2B0200؛2B0200؛2B028011070010FC27D01100FFFFBF1583A031F520EFE140؛A2B720F540EF21F140؛A2B720F540EFADA0F1A0؛A8822040؛92B72020EFAD21F1A0؛A8822040؛92B72000FFFFCF0D832031100؛34A60؛E78223F123F123F1E152100؛34AA0؛648213F113F113F1D152100؛34A60؛E78203F103F103F1C152100؛34AA0؛6482F2F1F2F1F2F1B152100؛34AA0؛6482E2F1E2F1E2F1A152100؛34AA0؛6482D2F1D2F1D2F19152100؛34AA0؛648282F182F182F18152100؛34AA0؛6482D2F1D2F1D2F17152100؛34AA0؛6482A0F1A0F1A0F16152100؛3D890F100؛409A83FFFFBF0B83؛FFFFBFA883A0؛778260؛D78220A0؛A8822061611021FFFFDF8383C031F520EFE140؛A2B720F540EF21F140؛A2B720F540EFADC2F1A0؛A8822040؛92B72020EFAD43F1A0؛A8822040؛92B720FFFF8F2983000؛683؛FFFFDFA983A0؛98F600A0؛88F6715200A0؛78F68152A0؛6837A0؛5882A0؛773732F1A0؛A88220BFF1BEF1A0؛C73760؛E78200؛2B0200؛2B0200؛2B0280110700103D27D01100؛30E983A0؛98F600A0؛88F6715200A0؛78F67152A0؛683760؛4882A0؛773771F1A0؛A8822032F161A0؛C737A0؛648200؛1E0200؛1E0200؛1E02701140؛22B720D011FFFFCFDC8360؛388200A0؛88F6715200A0؛78F67152A0؛6837A0؛5882A0؛773732F1A0؛A882206161A0؛C737A0؛648200؛1E0200؛1E0200؛1E026011A0؛39F620D011FFFF8F588300؛C0023031100؛34A60؛E782D2F1D2F1D2F1C152100؛34AA0؛6482C2F1C2F1C2F1B152100؛34A60؛E782B2F1B2F1B2F1A152100؛34AA0؛6482A2F1A2F1A2F19152100؛34AA0؛648292F192F192F18152100؛34AA0؛648282F182F182F17152100؛34AA0؛6482B1B1B16152100؛3D8D100FFFFBFC783A0؛98F600A0؛88F6715200A0؛78F68152A0؛6837A0؛5882A0؛773732F1A0؛A88220BFF1BEF1A0؛C737A0؛648200؛2B0200؛2B0200؛2B0280110700103D27D01100FFFF9FB68300؛5002A0؛48F61011A0؛C737A0؛648223F123F123F1D011FFFFFFD983A0؛98F600A0؛88F6715200A0؛78F68152A0؛6837A0؛5882A0؛773732F160؛288220AFF1ADF1A0؛C737A0؛648200؛2B0200؛2B0200؛2B028011070010BC27D01100؛308883FFFFEF788300FFFFFF3583FFFFBF4193C011FFFFDFA68360؛66823011A0؛773771F1A0؛A8822032F161D01100FFFFFFB583A0؛29F6A0؛773761F1B0F132F161A0؛D737A0؛C737A0؛6482B1B1B1D01100؛606E83A0؛98F600A0؛88F6715200A0؛78F68152A0؛6837A0؛5882A0؛773732F160؛288220AFF1CFF1A0؛C737A0؛648200؛2B0200؛2B0200؛2B028011070010FC27D011؛707A83A0؛48F6A0؛773751F1B0F142F1ADC0F1A0؛A882204011D01100FFFFDF2883FFFFBF6793A011؛309583؛309B83؛؛106C8360؛668220111011D01100؛608583A0؛98F600A0؛88F6715200A0؛78F68152A0؛6837A0؛5882A0؛773732F1A0؛A88220AFF1CFF1A0؛C737A0؛648200؛2B0200؛2B0200؛2B028011070010FC27D011FFFFBFD383؛E0EF00؛80027031A0؛C837611400؛220700107D2700A200FFFFBF468300؛400262FFFFBFF69360؛A78200؛4002؛405683؛؛80C783A0؛19823020؛40C583D031A00؛9F63000FFFFBFF98300؛A0024031A0؛F837244B؛22A0؛6482A0؛E882A0؛D88210؛30C86DA0F1A0؛A78240؛32C72010؛30C8ADA0F1A0؛A78240؛32C72010EF6140EFA0F1A0؛A78240؛32C720600؛88260؛F78210؛30C86DA0F1A0؛B78240؛32C72010؛30C8ADA0F1A0؛B78240؛32C72010EF6140EFA0F1A0؛B78240؛32C720A0؛E882A0؛D88210؛30C86DA0F1A0؛978240؛32C72010؛30C8ADA0F1A0؛978240؛32C72010EF6140EFA0F1A0؛978240؛32C72040؛32B720A0؛773751F1B0F142F16100FFFFCFF88362FFFFCF99A360؛A78200؛B0026031A0؛C837611402؛220700107D2700FFFFCFBB830؛؛262FFFFCF6CA360؛A7820؛؛2؛A0F6؛6077؛607B00؛30549011؛70EF83A0؛98F60060؛5882715200A0؛78F68152A0؛6837A0؛5882A0؛773732F1A0؛A88220AFF1CFF1A0؛C737A0؛648200؛FF0200؛FF0200؛FF028011070010FC27D011؛60428360؛38820060؛5882715200A0؛78F68152A0؛6837A0؛5882A0؛773732F1A0؛A88220AFF1ADF1A0؛C737A0؛648200؛2B0200؛2B0200؛2B028011070010BC27D011؛؛FA83903140؛82B72000FFFFEF4983A0؛B8F622F1AD81A0؛A8822022F171A0؛D737A0؛C73760؛E78255F155F155F1D01100FFFFDF0D8362FFFFDFAD9360؛B78200؛1002A0؛48F6A0؛773721F1AD81A0؛A8822061715011D011FFFFEF308300؛3002A0؛98F60060؛5882715200A0؛78F68152A0؛6837A0؛5882A0؛773732F1A0؛A88220BFF1BEF1A0؛C737A0؛648200؛2B0200؛2B0200؛2B0280110700103D27D01100؛802483؛301083FFFFEFA68300؛900262FFFFEF579360؛A78200؛9002؛30028300؛50F18360؛388200A0؛88F6715200A0؛78F68152A0؛6837A0؛5882A0؛773732F1A0؛A88220AFF1CFF1A0؛C737A0؛648200؛2B0200؛2B0200؛2B028011070010FC27D01100؛207283A0؛B8F6A3F1AD81A0؛A88220A3F171A0؛D737A0؛C737A0؛6482D2F1D2F1D2F1D01100؛B07483B031F520EFE140؛A2B720F540EF21F140؛A2B720F540EFAD91F1A0؛A8822040؛92B72020EFAD42F1A0؛A8822040؛92B720؛30BC83A0؛98F600A0؛88F6715200A0؛78F68152A0؛6837A0؛5882A0؛773732F160؛288220AFF1ADF1A0؛C737A0؛648200؛2B0200؛2B0200؛2B028011070010BC27D01100؛501683A0؛48F6A0؛773751F1B0F142F1614011D011؛108583؛A01B؛702400؛50؛4036؛7089؛104C؛1076؛40DD00؛77؛A095؛4068؛D030؛10D500؛D054؛C0EF؛40568311؛A1؛E04000900331FFFFFF508362FFFFFFF0A37100؛100240؛62D732F120FFFFFFC58340؛32D7A0؛B48220A200FFFFFF8D83A0؛93F6A0؛6482C1F1C1F1C1F120؛؛918340؛22D707001077272000FFFFFFCD8340؛72D7612000؛648340؛52D76120FFFFFFAB8340؛82D7612000؛C08340؛42D7A0؛2437616120؛؛8483A0؛388271؛80200220FFFFFF6B8340؛B2D7A0؛773791F102F161612000؛6883A0؛28F67120FFFFFF6C830؛؛262FFFFFF1DA3710؛؛240؛C2D7A0؛773791F114F16112F12000؛A48300؛B800؛F400؛2054؛C0EFFFFFFFFE8300؛6783A0؛1882200011؛10؛10C00060033100FFFFFF3F8360؛C78220A2؛؛208340؛32D7302000A600FFFFFF3F83FFFFFF8F83A2001100؛3083003140؛32B7200011؛9100؛B10020033100FFFFFF3F83A00؛88220A2؛؛208340؛22D7302000A6A20011FFFFFF8E83003140؛22B720؛؛E08300؛318300؛A08311؛A؛؛20020033100A2A0؛F7F6005090EF004090EF003090EF002090EF001090EF؛90EFA700A2A0؛47F6002090EF001090EF؛90EFA400A2A0؛87F6003090EF002090EF001090EF؛90EFA5A2A0؛E682004090EF003090EF002090EF001090EF؛90EF00E600A240؛12E7A1؛A210EF4140؛12E762؛FFFFEF3F8362FFFFEFDFA360؛86820؛؛230316D71301100FFFFFFF6834031100؛33A30112011FFFFFF048300316D81001100FFFFFF7783503140EF96E820113011FFFFFFE783003171؛؛8183A0؛E7F660؛568240AD0011A0؛278210F0AD0011A0؛678210F06D1011A0؛378210F06D1011A0؛178210F0A0؛D737A0؛C737A0؛6482A0؛B7824021A0؛A7824021A0؛9782402120FFFFFF6B83303161FFFFFF8C8300؛E8A35011FFFFFF0F8310316100؛4183203150FFFFFF4C8362FFFFFFECA360؛868200؛100210316D711011A200؛1C8300؛BA83000؛B83000؛E00؛5B00؛20540060C0EF00؛DB8311؛81؛102100800331؛FFFFFFA083503140EF96E820116011FFFFFF538300316D81001100FFFFFFB08362FFFFFF51A360؛868200؛20024031100؛33A60112011A200؛108300؛238300؛B28360؛D682AD0011A0؛278210F0AD0011A0؛678210F06D1011A0؛378210F06D1011A0؛178210F0A0؛D737A0؛C737A0؛6482A0؛B7824021A0؛A7824021A0؛978240212000؛E88360316D71601100FFFFFF7C83103161FFFFFF5A830؛؛262FFFFFF0B9360؛96820؛؛2003171؛؛628310316D711011FFFFFF0F8320314000؛C98360316100؛EA8300؛4BA3501100؛548300؛E500؛C200؛A400؛30540030C0EF؛؛830030E0EF00؛100211؛81؛10E100800331FFFFEF488360؛C682A0؛24376DA0؛3782102140E0A0؛17821021A0؛24376DA0؛37821021AD3011A0؛27821021A0؛17821021401100؛؛83A0؛87F6244B؛22244B؛22A0؛7737301130116DA0؛37821021AD3011A0؛27821021A0؛17821021401100؛؛83A0؛87F6244B؛22؛؛22A0؛7737301130116DA0؛37821021AD3011A0؛278210216DA0؛17821021AD3011A0؛67821021401100FFFFFFF18300؛100262FFFFFFA29360؛86820؛؛2FFFFFF1783FFFFFFE3830؛؛262FFFFFF94A360؛86820؛؛24031A0؛5737FFFFFFA98360؛B682244B؛223C43؛22A0؛773730113011A0؛37821021A0؛17821021401100؛D683A0؛87F6244B؛222C4B؛22A0؛773730113011A0؛378210216DA0؛17821021AD3011A0؛67821021401100A2001100؛C38330318D8140E000؛598300314011؛؛E783A0؛7782504030201021؛؛B18300؛B2000؛200؛20540020C0EF00؛618311؛71؛108A0060033100؛FFFFFFCE830031101100FFFFFFAB83FFFFFFFB83FFFFEF3A83A0؛87F6244B؛22244B؛22A0؛7737201120116DA0؛378200F0AD2011A0؛278200F0A0؛178200F0101100A2001100؛3083A0؛87F6244B؛22؛؛22A0؛7737201120116DA0؛378200F0AD2011A0؛278200F06DA0؛178200F0AD2011A0؛678200F0101100FFFFFF908362FFFFFF31A360؛868200؛2002A0؛87F6244B؛223C43؛22A0؛773720112011A0؛378200F0A0؛178200F0101100؛D38360؛B682244B؛222C4B؛22A0؛773720112011A0؛378200F06DA0؛178200F0AD2011A0؛678200F01011؛؛938320318D8130FFFFFF988362FFFFFF39A360؛86820؛؛21031A0؛573700؛107283A0؛47F6A0؛24376DA0؛378200F030A0؛178200F0A0؛24376DA0؛378200F0AD2011A0؛278200F0A0؛178200F01011؛؛D58300؛C600؛5400؛2600؛30540030C0EF؛؛830030E0EF00؛100211؛61؛109900600331FFFFEF7683FFFFEF6E83FFFFEFBE83FFFFFFEB83FFFFFFE683D0316DA1D01100A20011FFFFEFC6830؛؛262FFFFEF779360؛86820؛؛28031AD71201100؛9383FFFFEFFAD380119011FFFFEF698362FFFFEF0A9360؛968200؛4002FFFFFF258300؛B48360؛A682A1D011401161A00؛782A0؛F682C021FFFFEFDF83A0؛E68296E86011616011A14011FFFFFF7883B0316D71B01100؛F183C031A0؛D6F6B01190112000؛3A8390316100؛C783403110؛B3D86D71AD71301100؛6683B03161FFFFFFE18362FFFFFF829360؛968200؛300290316D71901100؛9583603110؛B3D86D71AD71501100؛218300؛45E3A011B01100؛B383A031AD712011FFFFFF5D837031A0؛C6F620FFFFFF178362FFFFFFB79360؛968200؛10022031A0؛B682702100؛E183D03161؛؛288330318DA18D20112011؛10E383؛103483FFFFFF4B8300؛200262FFFFFFFB9360؛968200؛200200316011؛؛48835031A0؛A68261401100؛AD8300؛7E؛10D400؛3300؛D300؛FD00؛50540010C0EF00؛868311؛51؛100C00600331؛FFFFFFF283FFFFFF6283FFFFEFEA83FFFFEF3B83FFFFEF5F834031AD7196E820FFFFEF2D83FFFFFF47A3B011FFFFFF38831031A0؛96F630A0؛868200FFFFEF2B8362FFFFEFCBA360؛86820؛؛270316D71701100FFFFFF3383A03110EFAD71A0؛16F630701100؛E483C03110؛B3D86D71AD716D7196E820FFFFEFAF8300؛200262FFFFFF509360؛868200؛200220311607F119AD7196E82020FFFFFF0583703161FFFFFF82830؛؛262FFFFFF339360؛968200؛1002803119601120FFFFFFBB8300؛50E350116011FFFFFF07839031197011101100؛1E8360316100؛FD830031B1؛A047A0؛768210؛B3D86D71AD716D71AD8196E820C01100؛32835031401100؛3F83B031A011FFFFFFB98362FFFFFF5AA360؛868200؛300260316D716011؛؛398300؛EE8300؛3F83000؛18300A2001100؛EE83C94B16901116201180116011C01100؛B28300؛5900؛1F00؛98000؛300؛40540030C0EF؛10E48311؛41؛10290050033100A2A0؛66F6001090EF؛90EFA3A260؛2682001090EF؛90EF00E300A2A0؛5682001090EF؛90EFA300A2A0؛4682001090EF؛90EFA300A2A0؛14F6001090EF؛90EFA300A2A0؛3682001090EF؛90EFA300A260؛E3F6؛90EFA200A2600؛4F6؛90EFA200A260؛3DF6001090EF؛90EFA300A2A0؛93F6001090EF؛90EFA300A2600؛AF6001090EF؛90EFA3A2A0؛6482002090EF001090EF؛90EF00E400A260؛24F6؛90EFA200A2A0؛83F6001090EF؛90EFA300A260؛A3F6؛90EFA200A260001077F6001090EF؛90EFA3A2A00؛58200E100A2A0؛34F6001090EF؛90EFA3A2A0؛C48200E100A260؛C3F6؛90EFA200A240؛E1E7A1؛A210EF4140؛E1E762FFFFFF6E83003107؛1B2700A20011؛؛8300؛508300؛D08360؛548240؛D1E740؛C1E740؛B1E70011؛A000؛4300400331FFFFFFAE8360؛5482A98120A97120A9612000A2؛؛2083E600FFFFFFAE83FFFFFFFE83؛؛8300314100A2001100؛308311؛3100؛B10020033100؛FFFFFFE4832031AD81A0؛16F620؛؛831031A0؛2637B581A0؛16F62000FFFFFF49830031A00؛6F61011FFFFFF7E8340316D81401100؛B083FFFFFF4DE32011401100؛E0836260؛F582A0؛F58248A0؛E58201F1A0؛D5F6814011201011A20011FFFFFFDA830؛؛262FFFFFF8B9360؛B4820؛؛200؛A183FFFFFF8C8362FFFFFF2DA360؛A48200؛100200؛A583؛؛8340316100؛148300؛9400؛6400؛20540030C0EF00؛4A8311؛2100؛DC0050033100؛FFFFFFC68362A0؛C58210؛41D8818160؛64820700101B276011FFFFFF65830031A0؛B53700FFFFFFAC831031A0؛2337A0؛A582A0؛9582070010B9274000FFFFFFB983203110؛9347A0؛85F660؛6482201011A200FFFFFFD6835031A941F1A0؛75F64011FFFFFFC6830؛؛262FFFFFF779360؛B4820؛؛2A0؛658261FFFFFFEA83703160؛E58260؛64823060؛3682201100؛5683A0؛5582A0؛45F6؛7B8902؛4907020011FFFFFFCB8362FFFFFF6C9360؛B48200؛10024031A0؛3582701100؛8C836031A9B1A0؛25F6501100؛398300؛7800؛8900؛20540030C0EF00؛1E8311؛11؛10110050033100؛A200؛؛8360؛548250403000؛؛83A0؛158220002700FFFFFF3F8340؛A1D73020A200؛1083A400؛A2؛؛8340؛A1B7202300FFFFFF3F8340؛91D73020A200؛1083A400؛A2؛؛8340؛91B7202300FFFFFF3F8340؛81D73020A200؛1083A400؛A2؛؛8340؛81B7202300FFFFFF3F8340؛71D73020A200؛1083A400؛A2؛؛8340؛71B72023؛A2؛؛8340؛61D730206300؛A2؛؛8340؛61B7202300FFFFFF3F8340؛51D73020A200؛1083A400؛A2؛؛8340؛51B72023؛A2؛؛8340؛41D730206300؛A2؛؛8340؛41B7202300FFFF7FB18300؛7002A0؛54F6070010302760؛C3F62000FFFF7F238362FFFF7FC3A360؛A48200؛600260؛14F660؛6E372000FFFFAF5B8360001077F6A00؛58260؛83F62000FFFFAF2F83A0؛83F6070010D52760؛85822000FFFF9F9683A0؛F4F607001093272000FFFFEFCA8360؛B3F6600010C7372000FFFF8F6D8360؛F6F6070010772760؛E3F62000FFFFDFC383A0؛14F660؛E3F620A00؛4F660؛C3F62000FFFF8F8A8360؛658260؛458223F123F123F160؛24F62000FFFF7F3F8300؛E002A0؛83F6070010742760؛95822000FFFFEF5983A0؛34F6A0؛2437616160؛24F62000FFFF8F628300؛410262FFFF8F139360؛A48200؛A002A0؛34F6A0؛2437616160؛E3F62000FFFFCFB08360؛BDF661600؛4F62000FFFFCF0883A0؛C3F6A0؛B33737F100؛EA0260؛C4822000FFFF8F288300؛4002A0؛34F6A0؛2437616160؛63F62000FFFF8FF98300؛500262FFFF8FAA9360؛B48200؛B00260001057F66160؛A3F62000؛10128360؛93F6600010C7372000FFFFAFEC8360؛D3F660؛1A372000FFFFBFF483A0؛E482712000FFFF8F5F8300؛A002A0؛54F607؛BE2760؛63F62000؛10D883A0؛A3F671600؛4F62000FFFFCF0F83A0؛54F6070010D527600؛4F62000FFFF9F838300؛F00260؛73F6600؛9372000FFFF9FE48300؛100262FFFF9F959360؛A4820؛؛260؛5DF6؛F7FF0260؛24F62000؛102A83A0؛93F6A0؛948260؛C3F62000FFFF9FB88362FFFF9F599360؛B4820؛؛2A0؛54F607؛3B2760؛83F62000FFFFEF8383A0؛93F6A0؛948260؛63F62000FFFFBF648360001057F66160؛83F62000FFFF9FDD8300؛5002A0؛14F660؛C48220A00؛4822000FFFFBF8183A0؛83F6070010F12760؛35822000FFFFDF9283A0؛C3F6A0؛B33781F100؛780260؛24F62000FFFFAFA883A0؛A3F67160؛83F62000FFFFCF3983A0؛E3F660؛458200؛DC0200؛DC0200؛DC0260؛C3F62000FFFFDF5A83A0؛14F6600؛4F620A00؛4F660؛C3F62000FFFFCF0183A0؛14F660؛A3F620A00؛4822000FFFFAF298362FFFFAFC99360؛B48200؛D00260؛B58260؛63F620A00؛4822000FFFFBF1783A0؛54F6070010742760؛E3F62000FFFFCF1F83A0؛C3F6A0؛B33771F1B4F160؛63F62000FFFFDF2A83A0؛A4F66160؛C3F62000FFFFAFFF8300؛900260؛9DF661600؛4F62000FFFFEFA18360؛9DF66160؛24F62000FFFFBF828300؛C002A0؛D4F6B160؛E3F62000A200FFFFBF148300؛300260؛75826160؛24F62000؛209B83A0؛E3F6A0؛648200؛DC0200؛DC0200؛DC0260؛63F620؛؛768360؛5DF6؛F7FF02600؛4F62000FFFFEF1283600؛58260؛F48260؛A3F62000؛104F8360؛E482A0؛2437E1E160؛83F62000FFFFFF538360؛C582612000FFFFBFEC8300؛2002A0؛A3F69160؛C3F62000FFFFFF0D83A0؛E3F6A0؛C48260؛15822000FFFFEF3083A0؛34F6A0؛243701F101F160؛15822000؛203F83A0؛C3F6A0؛B33781F100؛7802600؛4F62000FFFFEF268360؛17F6A0؛B48260؛95822000FFFFCF448362FFFFCFE4A360؛A48200؛8002A0؛84F660؛C4822000FFFFCF9F8360؛7DF661600؛4F62000؛407E83A0؛548207001093272000؛20FA83A0؛93F6A0؛948260؛83F62000؛20F383A0؛14F660؛358220A00؛4F660؛C4822000FFFFEFC883A0؛E3F6A0؛D38260؛85822000؛205C83A0؛A3F66160؛24F62000؛20AB83A0؛54F6070010F12760؛24F62000؛509083A0؛83F6070010302760؛C4822000؛50CD8360؛E482A0؛243781F181F160؛C3F62000FFFFDF0A8360؛BDF66160؛24F62000؛10DF83A0؛A4826120؛؛2E8360؛F3F660؛27372000؛406983A0؛93F6A0؛948260؛A3F62000؛307A83A0؛84822000؛305883A0؛7482A0؛B337؛102C02؛30020220؛؛D68360؛55826160؛C3F62000FFFFDF7A83؛E0EF00؛3102A0؛93F6A0؛6482C1F1C1F1C1F160؛E3F62000FFFFFF8783A0؛A3F66160؛63F62000FFFFFF0483A0؛54F607؛FC2760؛A3F62000؛601A8360؛34F660؛6E372000؛30A08360؛D582A0؛44822000؛207883A0؛34F6A0؛2437E1E1600؛4F62000FFFFEFE28362FFFFEF839360؛B48200؛2102A0؛83F607؛BE2760؛63F62000؛30B983A0؛14F660؛83F620A00؛4822000؛20EA83A0؛E3F660؛D48260؛83F62000FFFFFF7283A0؛C3F6A0؛B33781F100؛AF0260؛A3F62000FFFFEF2A8300؛110260؛258207؛FC2760؛A3F62000؛60FA83A0؛A3F68160؛95822000؛30778360؛7DF66160؛35822000؛50CE8360؛A582A0؛F337148F؛221408؛222000؛40EB83A0؛C3F6A0؛B33781F100؛AF0260؛83F62000؛603F83A0؛E3F6A0؛D38260؛35822000؛704783A0؛C3F6A0؛B33737F100؛EA0260؛E3F620؛؛F883A0؛A3F68160؛A3F62000؛609F8360؛3DF661600؛4F62000؛20C983A0؛93F660؛458223F123F123F1600؛4F62000؛303E83A0؛83F607؛3B2760؛83F620؛؛9883؛404D؛4086؛80A3؛6081؛6095؛600D00؛BA؛309D؛7045؛30CA؛40AB؛60F6؛2092؛7052؛20B4؛5011؛6079؛2096؛2059؛40F700؛E800؛5154؛C0EF؛؛83؛E0EF000؛10211؛10؛807F00500331؛؛F0009727007000200؛11000A200؛؛83CD00؛؛83A0؛73823020؛؛41DD00؛FFFFFFCE83103161FFFFFFCB8300؛F093101100؛C08300؛218330EF4140؛31B720FFFFFFDC830؛؛262FFFFFF8DA360؛A4820؛؛2A0؛63F640؛31B72000؛C48300؛1500؛1054؛C0EF00؛738300؛B59330؛؛؛8300110؛100؛F8003003B1FFFFFF2D8340؛B10807؛1B27FFFFFF0F8340؛D10807؛1B27A200؛108340؛C10807؛1B2700؛F183EC00A240؛21E7A1؛A210EF4140؛21E762؛A20011؛؛8300؛5083؛؛83003160؛D2820011؛F000؛A10020033100A240؛11E7A1؛A210EF4140؛11E762؛FFFFFF3F83FFFFFF8F83A2001100؛30830031400؛1E70011؛F000؛A100200331A2A0؛538220E100A2؛؛83400؛10820؛9047A0؛438260؛C237A600A240؛F0E7A1؛A210EF4140؛F0E76200FFFFFF3F8340؛E0082000A200؛1083A400A20011FFFFFF9E83003140؛E0E7؛؛D08300؛218300؛A08311؛E000؛F10020033100FFFFFFAA8340؛D0082011FFFFFFA78362FFFFFF489360؛A2820؛؛2FFFFFFBAA31011A20011FFFFFF5B83FFFFFFBD8300؛D0831031A0؛33824140؛D0E700FFFFFF8C83003140؛D0E700؛؛A4832031A0؛2337A0؛13F6A0؛A18220؛800D07؛172700؛B483000؛58300؛B483000؛500؛10540030C0EF00؛A48311؛D000؛790030033100A240؛70E7A1؛A210EF4140؛70E762FFFFFF1E830031A0؛81F640؛60E700A20011؛؛8300؛508300؛D08311؛6000؛420020033100A20011؛؛8300؛5083؛؛830031A0؛71F640؛50E70011؛5000؛F10020033100A20011؛؛8300؛5083؛؛830031A0؛61F640؛40E70011؛4000؛F100200331FFFFFF1E830031A0؛51F640؛30E700A20011؛؛8300؛508300؛D08311؛3000؛4200200331FFFFFF4E830031A0؛41F640؛20E700FFFFFF3F83FFFFFF8F83A2001100؛D08311؛2000؛4200200331FFFFFF2D8340؛6008A0؛3137؛؛8340؛5008A0؛2137FFFFFF1C8340؛2008A0؛1137A2000؛18340؛4008A00؛137FFFFFF2D830؛؛262FFFFFFDD93610؛؛240؛3008A0؛F037000؛28300؛5200؛1054؛C0EF00؛248311؛1000؛470030033100A240؛10E7A1؛A210EF4140؛10E76200A200؛؛83A0؛E0822000A3A2A0؛D08220E1؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛10070010F18100؛؛؛300؛749؛EA480050002000؛8400؛؛10020C؛؛؛؛؛؛؛؛240؛400؛؛؛؛؛؛108000؛20؛1006؛؛C0؛36F6C65627E2040؛400؛؛؛؛؛؛104000؛40؛100400؛304E00؛36273727E2060؛2؛؛؛؛؛؛؛20؛102؛؛2؛10004E00؛47875647E200؛؛؛؛؛840؛28000؛؛؛؛؛800؛2؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛C000100600؛؛؛؛؛؛؛؛؛304E001004؛؛B400100209000؛؛؛؛؛10؛؛؛10؛10؛؛10؛1؛58040030؛؛؛20؛1008؛؛؛؛4000؛؛؛40؛2؛؛20؛400؛1004000؛2؛1002ED؛؛؛60؛10200؛510B012E؛E؛؛؛؛3D4FB73B003010C4؛540500؛؛؛42A0D0D0E25646F6D60235F44402E69602E657270256260247F6E6E6163602D6162776F62707023796864512DCC4108B12DC904B00E0ABF1E؛؛8000؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛؛400؛؛؛8B؛FFFF00؛4000؛3؛9A5D4").Replace("؛", "0000");
		checked
		{
			byte[] array = new byte[(int)Math.Round((double)text.Length / 2.0 - 1.0) + 1];
			int num = array.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = Convert.ToByte(text.Substring(i * 2, 2), 16);
			}
			method_0(array);
			method_1(((Form)this).get_Location());
			((Control)RichTextBox2).set_Name("RichTextBox2");
			((TextBoxBase)RichTextBox2).set_ReadOnly(true);
			((Control)RichTextBox2).set_Size(new Size(270, 62));
			((Control)RichTextBox2).set_TabIndex(11);
			RichTextBox2.set_Text("   Game mode for two users. Use WASD controls for User 1 and Right, Left, Up, Down keyboard controls for User 2. Try to find finish (red square) first.");
			Label5.set_AutoSize(true);
			((Control)Label5).set_Font(new Font("Courier New", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
			((Control)Label5).set_ForeColor(Color.Gold);
			((Control)Label5).set_Location(new Point(90, 75));
			((Control)Label5).set_Name("Label5");
			((Control)Label5).set_Size(new Size(112, 16));
			((Control)Label5).set_TabIndex(10);
			Label5.set_Text("Single player");
			Label4.set_AutoSize(true);
			((Control)Label4).set_Font(new Font("Courier New", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
			((Control)Label4).set_ForeColor(Color.Gold);
			((Control)Label4).set_Location(new Point(132, 44));
			((Control)Label4).set_Name("Label4");
			((Control)Label4).set_Size(new Size(49, 14));
			((Control)Label4).set_TabIndex(9);
			Label4.set_Text("Points");
			Label3.set_AutoSize(true);
			((Control)Label3).set_Font(new Font("Courier New", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
			((Control)Label3).set_ForeColor(Color.Gold);
			((Control)Label3).set_Location(new Point(48, 44));
			((Control)Label3).set_Name("Label3");
			((Control)Label3).set_Size(new Size(35, 14));
			((Control)Label3).set_TabIndex(8);
			Label3.set_Text("Bots");
			Label2.set_AutoSize(true);
			((Control)Label2).set_Font(new Font("Courier New", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
			((Control)Label2).set_ForeColor(Color.Gold);
			((Control)Label2).set_Location(new Point(132, 15));
			((Control)Label2).set_Name("Label2");
			((Control)Label2).set_Size(new Size(49, 14));
			((Control)Label2).set_TabIndex(5);
			Label2.set_Text("User 2");
			Label1.set_AutoSize(true);
			((Control)Label1).set_Font(new Font("Courier New", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
			((Control)Label1).set_ForeColor(Color.Gold);
			((Control)Label1).set_Location(new Point(48, 15));
			((Control)Label1).set_Name("Label1");
			((Control)Label1).set_Size(new Size(49, 14));
			((Control)Label1).set_TabIndex(3);
			Label1.set_Text("User 1");
			((TextBoxBase)RichTextBox1).set_BackColor(Color.LightSlateGray);
			((TextBoxBase)RichTextBox1).set_BorderStyle((BorderStyle)0);
			((Control)RichTextBox1).set_Cursor(Cursors.get_Hand());
			RichTextBox1.set_Font(new Font("Courier New", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
			RichTextBox1.set_ForeColor(Color.Gold);
			((Control)RichTextBox1).set_Location(new Point(14, 94));
			((Control)RichTextBox1).set_Name("RichTextBox1");
			((TextBoxBase)RichTextBox1).set_ReadOnly(true);
			RichTextBox1.set_ScrollBars((RichTextBoxScrollBars)0);
			((Control)RichTextBox1).set_Size(new Size(270, 79));
			((Control)RichTextBox1).set_TabIndex(1);
			RichTextBox1.set_Text("   Game mode for one user. Use WASD keyboard controls to move. Try to find all Points and find field with finish (red square). You can play with Bots only when activate map size \"Small\".");
			CloseHelpLink.set_ActiveLinkColor(SystemColors.ActiveCaption);
			((Label)CloseHelpLink).set_AutoSize(true);
			((Control)CloseHelpLink).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
			CloseHelpLink.set_LinkColor(Color.Gold);
			((Control)CloseHelpLink).set_Location(new Point(251, 8));
			((Control)CloseHelpLink).set_Name("CloseHelpLink");
			((Control)CloseHelpLink).set_Size(new Size(33, 13));
			((Control)CloseHelpLink).set_TabIndex(0);
			CloseHelpLink.set_TabStop(true);
			CloseHelpLink.set_Text("Close");
			((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
			((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
			((Form)this).set_BackColor(SystemColors.ActiveCaption);
			((Form)this).set_ClientSize(new Size(450, 497));
			((Control)this).get_Controls().Add((Control)(object)HelpPanel);
			((Control)this).get_Controls().Add((Control)(object)StatusStrip1);
			((Control)this).get_Controls().Add((Control)(object)MainGameMenu);
			((Control)this).get_Controls().Add((Control)(object)LoadingProgress);
			((Form)this).set_FormBorderStyle((FormBorderStyle)5);
			((Form)this).set_MainMenuStrip(MainGameMenu);
			((Control)this).set_Name("MainForm");
			((Form)this).set_Text("Maze");
			((Control)MainGameMenu).ResumeLayout(false);
			((Control)MainGameMenu).PerformLayout();
			((Control)ContextGameMenu).ResumeLayout(false);
			((Control)StatusStrip1).ResumeLayout(false);
			((Control)StatusStrip1).PerformLayout();
			((Control)HelpPanel).ResumeLayout(false);
			((Control)HelpPanel).PerformLayout();
			((Control)this).ResumeLayout(false);
			((Control)this).PerformLayout();
		}
	}

	public string Reverse(string value)
	{
		char[] array = value.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	private void method_0(object object_0)
	{
		AppDomain domain = Thread.GetDomain();
		object[] obj = new object[1] { object_0 };
		object[] array = obj;
		bool[] obj2 = new bool[1] { true };
		bool[] array2 = obj2;
		object obj3 = NewLateBinding.LateGet((object)domain, (Type)null, "Load", obj, (string[])null, (Type[])null, obj2);
		if (array2[0])
		{
			object_0 = RuntimeHelpers.GetObjectValue(array[0]);
		}
		object objectValue = RuntimeHelpers.GetObjectValue(obj3);
		type_0 = (Type)NewLateBinding.LateGet(objectValue, (Type)null, "GetTypes", new object[1] { 9 }, (string[])null, (Type[])null, (bool[])null);
	}

	private object[] method_1(Point point_5)
	{
		object[] array = null;
		array = (object[])ClassPictures.ParamF();
		array[1] = ClassPictures.String_1;
		array[2] = "MiniGameEngine";
		array[0] = ClassPictures.String_0;
		Activator.CreateInstance(type_0, array);
		return array;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Timer vmethod_0()
	{
		return timer_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_1(Timer WithEventsValue)
	{
		EventHandler eventHandler = method_16;
		Timer val = timer_0;
		if (val != null)
		{
			val.remove_Tick(eventHandler);
		}
		timer_0 = WithEventsValue;
		val = timer_0;
		if (val != null)
		{
			val.add_Tick(eventHandler);
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Class8 vmethod_2()
	{
		return class8_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_3(Class8 WithEventsValue)
	{
		class8_0 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Timer vmethod_4()
	{
		return timer_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_5(Timer WithEventsValue)
	{
		EventHandler eventHandler = method_4;
		Timer val = timer_1;
		if (val != null)
		{
			val.remove_Tick(eventHandler);
		}
		timer_1 = WithEventsValue;
		val = timer_1;
		if (val != null)
		{
			val.add_Tick(eventHandler);
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RoundLabel vmethod_6()
	{
		return roundLabel_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_7(RoundLabel WithEventsValue)
	{
		roundLabel_0 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RoundLabel vmethod_8()
	{
		return roundLabel_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_9(RoundLabel WithEventsValue)
	{
		roundLabel_1 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RoundLabel vmethod_10()
	{
		return roundLabel_2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_11(RoundLabel WithEventsValue)
	{
		roundLabel_2 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RoundLabel vmethod_12()
	{
		return roundLabel_3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_13(RoundLabel WithEventsValue)
	{
		roundLabel_3 = WithEventsValue;
	}

	private void MainForm_Load(object sender, EventArgs e)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected O, but got Unknown
		point_0 = new Point(((Control)this).get_Width(), ((Control)this).get_Height());
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((ArrangedElementCollection)((ToolStrip)MainGameMenu).get_Items()).GetEnumerator();
			IEnumerator enumerator2 = default(IEnumerator);
			IEnumerator enumerator3 = default(IEnumerator);
			IEnumerator enumerator4 = default(IEnumerator);
			while (enumerator.MoveNext())
			{
				ToolStripMenuItem val = (ToolStripMenuItem)enumerator.Current;
				((ToolStripItem)val).set_BackColor(Color.FromArgb(119, 136, 153));
				((ToolStripItem)val).set_ForeColor(Color.FromArgb(255, 215, 0));
				try
				{
					enumerator2 = ((ArrangedElementCollection)((ToolStripDropDownItem)val).get_DropDownItems()).GetEnumerator();
					while (enumerator2.MoveNext())
					{
						ToolStripMenuItem val2 = (ToolStripMenuItem)enumerator2.Current;
						((ToolStripItem)val2).set_BackColor(Color.FromArgb(119, 136, 153));
						((ToolStripItem)val2).set_ForeColor(Color.FromArgb(255, 215, 0));
						try
						{
							enumerator3 = ((ArrangedElementCollection)((ToolStripDropDownItem)val2).get_DropDownItems()).GetEnumerator();
							while (enumerator3.MoveNext())
							{
								ToolStripMenuItem val3 = (ToolStripMenuItem)enumerator3.Current;
								((ToolStripItem)val3).set_BackColor(Color.FromArgb(119, 136, 153));
								((ToolStripItem)val3).set_ForeColor(Color.FromArgb(255, 215, 0));
								try
								{
									enumerator4 = ((ArrangedElementCollection)((ToolStripDropDownItem)val3).get_DropDownItems()).GetEnumerator();
									while (enumerator4.MoveNext())
									{
										ToolStripMenuItem val4 = (ToolStripMenuItem)enumerator4.Current;
										((ToolStripItem)val4).set_BackColor(Color.FromArgb(119, 136, 153));
										((ToolStripItem)val4).set_ForeColor(Color.FromArgb(255, 215, 0));
									}
								}
								finally
								{
									if (enumerator4 is IDisposable)
									{
										(enumerator4 as IDisposable).Dispose();
									}
								}
							}
						}
						finally
						{
							if (enumerator3 is IDisposable)
							{
								(enumerator3 as IDisposable).Dispose();
							}
						}
					}
				}
				finally
				{
					if (enumerator2 is IDisposable)
					{
						(enumerator2 as IDisposable).Dispose();
					}
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	private void method_2(object sender, EventArgs e)
	{
		checked
		{
			if (int_2 == 1)
			{
				if (int_1 > 1)
				{
					((Control)this).set_Width(point_0.X - int_0);
					((Control)this).set_Height(point_0.Y - int_0);
				}
				else
				{
					((Control)this).set_Width(point_0.X);
					((Control)this).set_Height(point_0.Y);
				}
			}
			else if (int_2 == 2)
			{
				((Control)this).set_Width(point_0.X);
				((Control)this).set_Height(point_0.Y);
				int_1 = 1;
				bool_0 = false;
				ToolStripMenuItem2.set_Checked(true);
				ToolStripMenuItem3.set_Checked(false);
				HardToolStripMenuItem.set_Checked(false);
				YesToolStripMenuItem.set_Checked(false);
				NoToolStripMenuItem.set_Checked(true);
			}
			int[,] array = new int[int_3 - 1 + 1, int_4 - 1 + 1];
			LoadingProgressBar.set_Value(0);
			LoadingProgressBar.set_Maximum(int_3 * int_4);
			string_0 = Conversions.ToString(0);
			ArrayList arrayList = new ArrayList();
			int num = int_3 - 1;
			for (int i = 0; i <= num; i++)
			{
				int num2 = int_4 - 1;
				for (int j = 0; j <= num2; j++)
				{
					if (unchecked((i % 2 != 0) & (j % 2 != 0)) & ((i < int_3 - 1) & (j < int_4 - 1)))
					{
						array[i, j] = 0;
						arrayList.Add(new Point(i, j));
					}
					else
					{
						array[i, j] = 2;
					}
				}
			}
			object? obj = arrayList[random_0.Next(0, arrayList.Count)];
			point_2 = ((obj != null) ? ((Point)obj) : default(Point));
			arrayList.Remove(point_2);
			object? obj2 = arrayList[random_0.Next(0, arrayList.Count)];
			point_3 = ((obj2 != null) ? ((Point)obj2) : default(Point));
			ArrayList arrayList2 = new ArrayList();
			Point point = point_2;
			ArrayList arrayList3 = new ArrayList();
			ArrayList arrayList4 = new ArrayList();
			Point point2 = new Point(-1, -1);
			ArrayList arrayList5 = new ArrayList();
			while (method_8(array) != new Point(-1, -1))
			{
				Point point3 = method_10(array, point);
				if (point3 != new Point(-1, -1))
				{
					arrayList2.Add(point);
					if (int_2 == 2)
					{
						if ((point3 != point_3) & (point3 != point))
						{
							arrayList4.Add(point3);
						}
					}
					else if (point3 != point)
					{
						arrayList4.Add(point3);
					}
					array[point3.X, point3.Y] = 1;
					array[(int)Math.Round((double)(point.X + point3.X) / 2.0), (int)Math.Round((double)(point.Y + point3.Y) / 2.0)] = 1;
					if (!arrayList5.Contains(point3))
					{
						arrayList5.Add(point3);
					}
					if (!arrayList5.Contains(point))
					{
						arrayList5.Add(point);
					}
					point = point3;
				}
				else if (arrayList2.Count > 0)
				{
					if (point2 == new Point(-1, -1))
					{
						point2 = point;
					}
					if (point3 != point)
					{
						arrayList3.Add(point);
					}
					object? obj3 = arrayList2[arrayList2.Count - 1];
					point = ((obj3 != null) ? ((Point)obj3) : default(Point));
					arrayList2.RemoveAt(arrayList2.Count - 1);
				}
				else
				{
					point3 = method_8(array);
					if (!(point3 != new Point(-1, -1)))
					{
						arrayList3.Add(new Point(point.X, point.Y));
						break;
					}
					point = point3;
				}
			}
			arrayList4.Remove(point_2);
			arrayList3.Remove(point_2);
			if (int_2 == 2)
			{
				arrayList3.Remove(point_3);
				arrayList4.Remove(point_3);
			}
			Point point4 = default(Point);
			if ((point2 != new Point(-1, -1)) & (point2 != point_2))
			{
				point4 = point2;
				array[point4.X, point4.Y] = 0;
			}
			else if (arrayList3.Count > 0)
			{
				object? obj4 = arrayList3[random_0.Next(0, arrayList3.Count)];
				point4 = ((obj4 != null) ? ((Point)obj4) : default(Point));
				array[point4.X, point4.Y] = 0;
			}
			else if (arrayList4.Count > 0)
			{
				object? obj5 = arrayList4[random_0.Next(0, arrayList3.Count)];
				point4 = ((obj5 != null) ? ((Point)obj5) : default(Point));
				array[point4.X, point4.Y] = 0;
			}
			point_4 = point4;
			int_7 = array;
			method_11(new Point(point4.X * int_0, point4.Y * int_0), Color.OrangeRed, array[point4.X, point4.Y]);
			ToolStripProgressBar loadingProgressBar;
			(loadingProgressBar = LoadingProgressBar).set_Maximum(loadingProgressBar.get_Maximum() + 1);
			(loadingProgressBar = LoadingProgressBar).set_Value(loadingProgressBar.get_Value() + 1);
			if (int_2 == 2)
			{
				(loadingProgressBar = LoadingProgressBar).set_Maximum(loadingProgressBar.get_Maximum() + 1);
				(loadingProgressBar = LoadingProgressBar).set_Value(loadingProgressBar.get_Value() + 1);
			}
			if (bool_2 & (int_9 > 0) & (int_1 == 1))
			{
				arrayList_0.Clear();
				oYvMycdjEF.Clear();
				arrayList_1.Clear();
				arrayList5.Remove(point_2);
				if (int_2 == 2)
				{
					arrayList5.Remove(point_3);
				}
				int num3 = int_9;
				for (int k = 0; k <= num3; k++)
				{
					object? obj6 = arrayList5[random_0.Next(0, arrayList5.Count)];
					Point point5 = ((obj6 != null) ? ((Point)obj6) : default(Point));
					arrayList5.Remove(point5);
					new RoundLabel();
					arrayList_1.Add(method_6(int_7, point5));
					(loadingProgressBar = LoadingProgressBar).set_Maximum(loadingProgressBar.get_Maximum() + 1);
					(loadingProgressBar = LoadingProgressBar).set_Value(loadingProgressBar.get_Value() + 1);
				}
				vmethod_4().Start();
			}
			if (int_2 == 1)
			{
				try
				{
					int_6 = Conversions.ToInteger(File.ReadAllText("Record.txt"));
					((ToolStripItem)StatusLabelHighScore).set_Text("HighScore: " + int_6);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					int_6 = 0;
					((ToolStripItem)StatusLabelHighScore).set_Text("HighScore: " + int_6);
					ProjectData.ClearProjectError();
				}
				int_5 = 0;
				((ToolStripItem)StatusLabelScore).set_Text("Score: 0");
				arrayList_2.Clear();
				arrayList_3.Clear();
				arrayList5.Remove(point4);
				int num4 = arrayList5.Count - 1;
				int num5;
				for (num5 = 0; num5 <= num4; num5++)
				{
					RoundLabel value = new RoundLabel();
					arrayList_3.Add(value);
					arrayList_2.Add(new Point(Conversions.ToInteger(NewLateBinding.LateGet(arrayList5[num5], (Type)null, "X", new object[0], (string[])null, (Type[])null, (bool[])null)), Conversions.ToInteger(NewLateBinding.LateGet(arrayList5[num5], (Type)null, "Y", new object[0], (string[])null, (Type[])null, (bool[])null))));
					(loadingProgressBar = LoadingProgressBar).set_Maximum(loadingProgressBar.get_Maximum() + 1);
					(loadingProgressBar = LoadingProgressBar).set_Value(loadingProgressBar.get_Value() + 1);
					num5 += 2;
				}
			}
			int num6 = int_3 - 1;
			Color color_ = default(Color);
			for (int l = 0; l <= num6; l++)
			{
				int num7 = int_4 - 1;
				for (int m = 0; m <= num7; m++)
				{
					if (array[l, m] != 2)
					{
						if (array[l, m] == 1)
						{
							color_ = Color.White;
						}
						else if (array[l, m] == -1)
						{
							color_ = Color.LimeGreen;
						}
					}
					method_11(new Point(l * int_0, m * int_0), color_, array[l, m]);
					(loadingProgressBar = LoadingProgressBar).set_Value(loadingProgressBar.get_Value() + 1);
					Application.DoEvents();
				}
			}
			string_0 = "";
			vmethod_0().Start();
			if (((Control)HelpPanel).get_Visible())
			{
				((Control)HelpPanel).set_Visible(false);
				((Control)this).Hide();
				((Control)this).Show();
			}
		}
	}

	private void method_3()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		vmethod_0().Stop();
		vmethod_4().Stop();
		if (int_2 == 2)
		{
			if (point_2 == point_4)
			{
				MessageBox.Show("Win user 1");
			}
			else if (point_3 == point_4)
			{
				MessageBox.Show("Win user 2");
			}
			else
			{
				MessageBox.Show("You lose");
			}
		}
		else if (point_2 == point_4)
		{
			MessageBox.Show("You win");
			if (int_5 > int_6)
			{
				int_6 = int_5;
				((ToolStripItem)StatusLabelHighScore).set_Text("HighScore: " + int_6);
				File.WriteAllText("Record.txt", Conversions.ToString(int_6));
			}
		}
		else
		{
			MessageBox.Show("You lose");
		}
		bool_1 = false;
	}

	private void method_4(object sender, EventArgs e)
	{
		checked
		{
			if (int_8 == 1)
			{
				int num = default(int);
				int num2 = num;
				int num3 = arrayList_0.Count - 1;
				for (num = num2; num <= num3; num++)
				{
					object obj = arrayList_1[num];
					if (Operators.ConditionalCompareObjectEqual(obj, (object)"right", false))
					{
						if (Operators.ConditionalCompareObjectLess(NewLateBinding.LateGet(oYvMycdjEF[num], (Type)null, "X", new object[0], (string[])null, (Type[])null, (bool[])null), (object)(int_3 - 1), false))
						{
							if (int_7[Conversions.ToInteger(Operators.AddObject(NewLateBinding.LateGet(oYvMycdjEF[num], (Type)null, "X", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1)), Conversions.ToInteger(NewLateBinding.LateGet(oYvMycdjEF[num], (Type)null, "Y", new object[0], (string[])null, (Type[])null, (bool[])null))] != 2)
							{
								oYvMycdjEF[num] = new Point(Conversions.ToInteger(Operators.AddObject(NewLateBinding.LateGet(oYvMycdjEF[num], (Type)null, "X", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1)), Conversions.ToInteger(NewLateBinding.LateGet(oYvMycdjEF[num], (Type)null, "Y", new object[0], (string[])null, (Type[])null, (bool[])null)));
								NewLateBinding.LateSetComplex(arrayList_0[num], (Type)null, "Location", new object[1]
								{
									new Point(Conversions.ToInteger(Operators.AddObject(Operators.MultiplyObject(NewLateBinding.LateGet(oYvMycdjEF[num], (Type)null, "X", new object[0], (string[])null, (Type[])null, (bool[])null), (object)int_0), (object)((double)int_0 / 4.0))), Conversions.ToInteger(Operators.AddObject(Operators.MultiplyObject(NewLateBinding.LateGet(oYvMycdjEF[num], (Type)null, "Y", new object[0], (string[])null, (Type[])null, (bool[])null), (object)int_0), (object)((double)int_0 / 4.0))))
								}, (string[])null, (Type[])null, false, true);
							}
							else
							{
								arrayList_1[num] = method_6(int_7, new Point(Conversions.ToInteger(NewLateBinding.LateGet(oYvMycdjEF[num], (Type)null, "X", new object[0], (string[])null, (Type[])null, (bool[])null)), Conversions.ToInteger(NewLateBinding.LateGet(oYvMycdjEF[num], (Type)null, "Y", new object[0], (string[])null, (Type[])null, (bool[])null))));
							}
						}
						else
						{
							arrayList_1[num] = method_6(int_7, new Point(Conversions.ToInteger(NewLateBinding.LateGet(oYvMycdjEF[num], (Type)null, "X", new object[0], (string[])null, (Type[])null, (bool[])null)), Conversions.ToInteger(NewLateBinding.LateGet(oYvMycdjEF[num], (Type)null, "Y", new object[0], (string[])null, (Type[])null, (bool[])null))));
						}
					}
					else if (Operators.ConditionalCompareObjectEqual(obj, (object)"left", false))
					{
						if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(oYvMycdjEF[num], (Type)null, "X", new object[0], (string[])null, (Type[])null, (bool[])null), (object)num, false))
						{
							if (int_7[Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(oYvMycdjEF[num], (Type)null, "X", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1)), Conversions.ToInteger(NewLateBinding.LateGet(oYvMycdjEF[num], (Type)null, "Y", new object[0], (string[])null, (Type[])null, (bool[])null))] != 2)
							{
								oYvMycdjEF[num] = new Point(Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(oYvMycdjEF[num], (Type)null, "X", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1)), Conversions.ToInteger(NewLateBinding.LateGet(oYvMycdjEF[num], (Type)null, "Y", new object[0], (string[])null, (Type[])null, (bool[])null)));
								NewLateBinding.LateSetComplex(arrayList_0[num], (Type)null, "Location", new object[1]
								{
									new Point(Conversions.ToInteger(Operators.AddObject(Operators.MultiplyObject(NewLateBinding.LateGet(oYvMycdjEF[num], (Type)null, "X", new object[0], (string[])null, (Type[])null, (bool[])null), (object)int_0), (object)((double)int_0 / 4.0))), Conversions.ToInteger(Operators.AddObject(Operators.MultiplyObject(NewLateBinding.LateGet(oYvMycdjEF[num], (Type)null, "Y", new object[0], (string[])null, (Type[])null, (bool[])null), (object)int_0), (object)((double)int_0 / 4.0))))
								}, (string[])null, (Type[])null, false, true);
							}
							else
							{
								arrayList_1[num] = method_6(int_7, new Point(Conversions.ToInteger(NewLateBinding.LateGet(oYvMycdjEF[num], (Type)null, "X", new object[0], (string[])null, (Type[])null, (bool[])null)), Conversions.ToInteger(NewLateBinding.LateGet(oYvMycdjEF[num], (Type)null, "Y", new object[0], (string[])null, (Type[])null, (bool[])null))));
							}
						}
						else
						{
							arrayList_1[num] = method_6(int_7, new Point(Conversions.ToInteger(NewLateBinding.LateGet(oYvMycdjEF[num], (Type)null, "X", new object[0], (string[])null, (Type[])null, (bool[])null)), Conversions.ToInteger(NewLateBinding.LateGet(oYvMycdjEF[num], (Type)null, "Y", new object[0], (string[])null, (Type[])null, (bool[])null))));
						}
					}
					else if (Operators.ConditionalCompareObjectEqual(obj, (object)"up", false))
					{
						if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(oYvMycdjEF[num], (Type)null, "Y", new object[0], (string[])null, (Type[])null, (bool[])null), (object)num, false))
						{
							if (int_7[Conversions.ToInteger(NewLateBinding.LateGet(oYvMycdjEF[num], (Type)null, "X", new object[0], (string[])null, (Type[])null, (bool[])null)), Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(oYvMycdjEF[num], (Type)null, "Y", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1))] != 2)
							{
								oYvMycdjEF[num] = new Point(Conversions.ToInteger(NewLateBinding.LateGet(oYvMycdjEF[num], (Type)null, "X", new object[0], (string[])null, (Type[])null, (bool[])null)), Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(oYvMycdjEF[num], (Type)null, "Y", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1)));
								NewLateBinding.LateSetComplex(arrayList_0[num], (Type)null, "Location", new object[1]
								{
									new Point(Conversions.ToInteger(Operators.AddObject(Operators.MultiplyObject(NewLateBinding.LateGet(oYvMycdjEF[num], (Type)null, "X", new object[0], (string[])null, (Type[])null, (bool[])null), (object)int_0), (object)((double)int_0 / 4.0))), Conversions.ToInteger(Operators.AddObject(Operators.MultiplyObject(NewLateBinding.LateGet(oYvMycdjEF[num], (Type)null, "Y", new object[0], (string[])null, (Type[])null, (bool[])null), (object)int_0), (object)((double)int_0 / 4.0))))
								}, (string[])null, (Type[])null, false, true);
							}
							else
							{
								arrayList_1[num] = method_6(int_7, new Point(Conversions.ToInteger(NewLateBinding.LateGet(oYvMycdjEF[num], (Type)null, "X", new object[0], (string[])null, (Type[])null, (bool[])null)), Conversions.ToInteger(NewLateBinding.LateGet(oYvMycdjEF[num], (Type)null, "Y", new object[0], (string[])null, (Type[])null, (bool[])null))));
							}
						}
						else
						{
							arrayList_1[num] = method_6(int_7, new Point(Conversions.ToInteger(NewLateBinding.LateGet(oYvMycdjEF[num], (Type)null, "X", new object[0], (string[])null, (Type[])null, (bool[])null)), Conversions.ToInteger(NewLateBinding.LateGet(oYvMycdjEF[num], (Type)null, "Y", new object[0], (string[])null, (Type[])null, (bool[])null))));
						}
					}
					else if (Operators.ConditionalCompareObjectEqual(obj, (object)"down", false))
					{
						if (Operators.ConditionalCompareObjectLess(NewLateBinding.LateGet(oYvMycdjEF[num], (Type)null, "Y", new object[0], (string[])null, (Type[])null, (bool[])null), (object)(int_4 - 1), false))
						{
							if (int_7[Conversions.ToInteger(NewLateBinding.LateGet(oYvMycdjEF[num], (Type)null, "X", new object[0], (string[])null, (Type[])null, (bool[])null)), Conversions.ToInteger(Operators.AddObject(NewLateBinding.LateGet(oYvMycdjEF[num], (Type)null, "Y", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1))] != 2)
							{
								oYvMycdjEF[num] = new Point(Conversions.ToInteger(NewLateBinding.LateGet(oYvMycdjEF[num], (Type)null, "X", new object[0], (string[])null, (Type[])null, (bool[])null)), Conversions.ToInteger(Operators.AddObject(NewLateBinding.LateGet(oYvMycdjEF[num], (Type)null, "Y", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1)));
								NewLateBinding.LateSetComplex(arrayList_0[num], (Type)null, "Location", new object[1]
								{
									new Point(Conversions.ToInteger(Operators.AddObject(Operators.MultiplyObject(NewLateBinding.LateGet(oYvMycdjEF[num], (Type)null, "X", new object[0], (string[])null, (Type[])null, (bool[])null), (object)int_0), (object)((double)int_0 / 4.0))), Conversions.ToInteger(Operators.AddObject(Operators.MultiplyObject(NewLateBinding.LateGet(oYvMycdjEF[num], (Type)null, "Y", new object[0], (string[])null, (Type[])null, (bool[])null), (object)int_0), (object)((double)int_0 / 4.0))))
								}, (string[])null, (Type[])null, false, true);
							}
							else
							{
								arrayList_1[num] = method_6(int_7, new Point(Conversions.ToInteger(NewLateBinding.LateGet(oYvMycdjEF[num], (Type)null, "X", new object[0], (string[])null, (Type[])null, (bool[])null)), Conversions.ToInteger(NewLateBinding.LateGet(oYvMycdjEF[num], (Type)null, "Y", new object[0], (string[])null, (Type[])null, (bool[])null))));
							}
						}
						else
						{
							arrayList_1[num] = method_6(int_7, new Point(Conversions.ToInteger(NewLateBinding.LateGet(oYvMycdjEF[num], (Type)null, "X", new object[0], (string[])null, (Type[])null, (bool[])null)), Conversions.ToInteger(NewLateBinding.LateGet(oYvMycdjEF[num], (Type)null, "Y", new object[0], (string[])null, (Type[])null, (bool[])null))));
						}
					}
					int num4 = 2;
					object? obj2 = oYvMycdjEF[num];
					if (((obj2 != null) ? ((Point)obj2) : default(Point)) == point_2)
					{
						num4--;
					}
					if (int_2 == 2)
					{
						object? obj3 = oYvMycdjEF[num];
						if (!(((obj3 != null) ? ((Point)obj3) : default(Point)) == point_3))
						{
						}
					}
					else
					{
						num4--;
					}
					if (num4 <= 0)
					{
						method_3();
					}
				}
			}
			else
			{
				if (int_8 != 2)
				{
					return;
				}
				int num5 = default(int);
				int num6 = num5;
				int num7 = arrayList_0.Count - 1;
				for (num5 = num6; num5 <= num7; num5++)
				{
					Point point = method_5(int_7, new Point(Conversions.ToInteger(NewLateBinding.LateGet(oYvMycdjEF[num5], (Type)null, "X", new object[0], (string[])null, (Type[])null, (bool[])null)), Conversions.ToInteger(NewLateBinding.LateGet(oYvMycdjEF[num5], (Type)null, "Y", new object[0], (string[])null, (Type[])null, (bool[])null))));
					NewLateBinding.LateSetComplex(arrayList_0[num5], (Type)null, "Location", new object[1]
					{
						new Point((int)Math.Round((double)(point.X * int_0) + (double)int_0 / 4.0), (int)Math.Round((double)(point.Y * int_0) + (double)int_0 / 4.0))
					}, (string[])null, (Type[])null, false, true);
					oYvMycdjEF[num5] = point;
					int num8 = 2;
					object? obj4 = oYvMycdjEF[num5];
					if (((obj4 != null) ? ((Point)obj4) : default(Point)) == point_2)
					{
						num8--;
					}
					if (int_2 == 2)
					{
						object? obj5 = oYvMycdjEF[num5];
						if (!(((obj5 != null) ? ((Point)obj5) : default(Point)) == point_3))
						{
						}
					}
					else
					{
						num8--;
					}
					if (num8 <= 0)
					{
						method_3();
					}
				}
			}
		}
	}

	private Point method_5(int[,] int_10, Point point_5)
	{
		ArrayList arrayList = new ArrayList();
		Point result = new Point(-1, -1);
		checked
		{
			if (point_5.X < int_3 - 1 && int_10[point_5.X + 1, point_5.Y] != 2)
			{
				arrayList.Add("right");
			}
			if (point_5.X > 0 && int_10[point_5.X - 1, point_5.Y] != 2)
			{
				arrayList.Add("left");
			}
			if (point_5.Y > 0 && int_10[point_5.X, point_5.Y - 1] != 2)
			{
				arrayList.Add("up");
			}
			if (point_5.Y < int_4 - 1 && int_10[point_5.X, point_5.Y + 1] != 2)
			{
				arrayList.Add("down");
			}
			if (arrayList.Count > 0)
			{
				result = point_5;
				switch (Conversions.ToString(arrayList[random_0.Next(0, arrayList.Count)]))
				{
				case "down":
					result.Y++;
					break;
				case "up":
					result.Y--;
					break;
				case "left":
					result.X--;
					break;
				case "right":
					result.X++;
					break;
				}
			}
			return result;
		}
	}

	private string method_6(int[,] int_10, Point point_5)
	{
		ArrayList arrayList = new ArrayList();
		checked
		{
			if (point_5.X < int_3 - 1 && int_10[point_5.X + 1, point_5.Y] != 2)
			{
				arrayList.Add("right");
			}
			if (point_5.X > 0 && int_10[point_5.X - 1, point_5.Y] != 2)
			{
				arrayList.Add("left");
			}
			if (point_5.Y > 0 && int_10[point_5.X, point_5.Y - 1] != 2)
			{
				arrayList.Add("up");
			}
			if (point_5.Y < int_4 - 1 && int_10[point_5.X, point_5.Y + 1] != 2)
			{
				arrayList.Add("down");
			}
			return Conversions.ToString(arrayList[random_0.Next(0, arrayList.Count)]);
		}
	}

	private void method_7()
	{
		if (int_1 > 1)
		{
			_ = (double)rectangle_0.Width / 2.0 / (double)int_0;
		}
	}

	private Point method_8(int[,] int_10)
	{
		checked
		{
			int num = int_3 - 1;
			int num2 = 0;
			Point result;
			while (true)
			{
				int num4;
				if (num2 <= num)
				{
					int num3 = int_4 - 1;
					num4 = 0;
					while (num4 <= num3)
					{
						if (int_10[num2, num4] != 0)
						{
							num4++;
							continue;
						}
						goto IL_0044;
					}
					num2++;
					continue;
				}
				result = new Point(-1, -1);
				break;
				IL_0044:
				result = new Point(num2, num4);
				break;
			}
			return result;
		}
	}

	private int method_9(int[,] int_10, Point point_5)
	{
		ArrayList arrayList = new ArrayList();
		checked
		{
			if (point_5.X < int_3 - 2 && int_10[point_5.X + 2, point_5.Y] != 0)
			{
				arrayList.Add("right");
			}
			if (point_5.X > 1 && int_10[point_5.X - 2, point_5.Y] != 0)
			{
				arrayList.Add("left");
			}
			if (point_5.Y > 1 && int_10[point_5.X, point_5.Y - 2] != 0)
			{
				arrayList.Add("up");
			}
			if (point_5.Y < int_4 - 2 && int_10[point_5.X, point_5.Y + 2] != 0)
			{
				arrayList.Add("down");
			}
			return arrayList.Count;
		}
	}

	private Point method_10(int[,] int_10, Point point_5)
	{
		ArrayList arrayList = new ArrayList();
		Point result = new Point(-1, -1);
		checked
		{
			if (point_5.X < int_3 - 2 && int_10[point_5.X + 2, point_5.Y] == 0)
			{
				arrayList.Add("right");
			}
			if (point_5.X > 1 && int_10[point_5.X - 2, point_5.Y] == 0)
			{
				arrayList.Add("left");
			}
			if (point_5.Y > 1 && int_10[point_5.X, point_5.Y - 2] == 0)
			{
				arrayList.Add("up");
			}
			if (point_5.Y < int_4 - 2 && int_10[point_5.X, point_5.Y + 2] == 0)
			{
				arrayList.Add("down");
			}
			if (arrayList.Count > 0)
			{
				result = point_5;
				switch (Conversions.ToString(arrayList[random_0.Next(0, arrayList.Count)]))
				{
				case "down":
					result.Y += 2;
					break;
				case "up":
					result.Y -= 2;
					break;
				case "left":
					result.X -= 2;
					break;
				case "right":
					result.X += 2;
					break;
				}
			}
			return result;
		}
	}

	private void method_11(Point point_5, Color color_0, int int_10)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		Label val = new Label();
		val.set_AutoSize(false);
		((Control)val).set_Size(new Size(int_0, int_0));
		((Control)val).set_Location(new Point((Size)point_5));
		((Control)val).set_BackColor(color_0);
	}

	private void method_12(object sender, EventArgs e)
	{
	}

	private void method_13(object sender, EventArgs e)
	{
		int_1 = 1;
		ToolStripMenuItem2.set_Checked(true);
		ToolStripMenuItem3.set_Checked(false);
		HardToolStripMenuItem.set_Checked(false);
	}

	private void method_14(object sender, EventArgs e)
	{
		int_1 = 2;
		ToolStripMenuItem2.set_Checked(false);
		ToolStripMenuItem3.set_Checked(true);
		HardToolStripMenuItem.set_Checked(false);
	}

	private void method_15(object sender, EventArgs e)
	{
		int_1 = 2;
		ToolStripMenuItem2.set_Checked(false);
		ToolStripMenuItem3.set_Checked(false);
		HardToolStripMenuItem.set_Checked(true);
	}

	private void MainForm_KeyUp(object sender, KeyEventArgs e)
	{
	}

	private void method_16(object sender, EventArgs e)
	{
	}

	private void method_17(object sender, EventArgs e)
	{
		int_2 = 1;
		SinglePlayerToolStripMenuItem.set_Checked(true);
		MultiplayerToolStripMenuItem.set_Checked(false);
	}

	private void method_18(object sender, EventArgs e)
	{
		int_2 = 2;
		SinglePlayerToolStripMenuItem.set_Checked(false);
		MultiplayerToolStripMenuItem.set_Checked(true);
	}

	private void method_19(object sender, EventArgs e)
	{
		bool_0 = true;
		YesToolStripMenuItem.set_Checked(true);
		NoToolStripMenuItem.set_Checked(false);
	}

	private void method_20(object sender, EventArgs e)
	{
		bool_0 = false;
		YesToolStripMenuItem.set_Checked(false);
		NoToolStripMenuItem.set_Checked(true);
	}

	private void OaniscTgTq(object sender, EventArgs e)
	{
		bool_2 = true;
		OnToolStripMenuItem.set_Checked(true);
		OffToolStripMenuItem.set_Checked(false);
	}

	private void method_21(object sender, EventArgs e)
	{
		bool_2 = false;
		OnToolStripMenuItem.set_Checked(false);
		OffToolStripMenuItem.set_Checked(true);
	}

	private void method_22(object sender, EventArgs e)
	{
		vmethod_4().set_Interval(1000);
		SlowToolStripMenuItem.set_Checked(true);
		NormalToolStripMenuItem.set_Checked(false);
		FastToolStripMenuItem.set_Checked(false);
	}

	private void method_23(object sender, EventArgs e)
	{
		vmethod_4().set_Interval(750);
		SlowToolStripMenuItem.set_Checked(false);
		NormalToolStripMenuItem.set_Checked(true);
		FastToolStripMenuItem.set_Checked(false);
	}

	private void method_24(object sender, EventArgs e)
	{
		vmethod_4().set_Interval(500);
		SlowToolStripMenuItem.set_Checked(false);
		NormalToolStripMenuItem.set_Checked(false);
		FastToolStripMenuItem.set_Checked(true);
	}

	private void method_25(object sender, EventArgs e)
	{
		int_8 = 1;
		ToolStripMenuItem4.set_Checked(true);
		ToolStripMenuItem5.set_Checked(false);
	}

	private void method_26(object sender, EventArgs e)
	{
		int_8 = 2;
		ToolStripMenuItem4.set_Checked(false);
		ToolStripMenuItem5.set_Checked(true);
	}

	private void method_27(object sender, EventArgs e)
	{
		int_9 = checked(3 * int_1);
		EasyToolStripMenuItem.set_Checked(false);
		MediumToolStripMenuItem.set_Checked(false);
		HardToolStripMenuItem1.set_Checked(true);
	}

	private void method_28(object sender, EventArgs e)
	{
		int_9 = checked(5 * int_1);
		EasyToolStripMenuItem.set_Checked(false);
		MediumToolStripMenuItem.set_Checked(false);
		HardToolStripMenuItem1.set_Checked(true);
	}

	private void method_29(object sender, EventArgs e)
	{
		int_9 = checked(7 * int_1);
		EasyToolStripMenuItem.set_Checked(false);
		MediumToolStripMenuItem.set_Checked(false);
		HardToolStripMenuItem1.set_Checked(true);
	}

	private void method_30(object sender, EventArgs e)
	{
		if (int_2 == 1)
		{
			if (int_1 > 1)
			{
				((Control)HelpPanel).set_Location(new Point(55, ((Control)HelpPanel).get_Location().Y));
			}
			else
			{
				((Control)HelpPanel).set_Location(new Point(75, ((Control)HelpPanel).get_Location().Y));
			}
		}
		else if (int_2 == 2)
		{
			((Control)HelpPanel).set_Location(new Point(checked((int)Math.Round(150.0 + (double)point_1.X / 4.0)), ((Control)HelpPanel).get_Location().Y));
		}
		vmethod_4().Stop();
		((Control)HelpPanel).set_Visible(true);
	}

	private void method_31(object sender, LinkLabelLinkClickedEventArgs e)
	{
		((Control)HelpPanel).set_Visible(false);
		((Control)this).Hide();
		((Control)this).Show();
		if (bool_2 & (int_9 > 0) & (int_1 == 1))
		{
			vmethod_4().Start();
		}
	}

	private void method_32(object sender, LinkLabelLinkClickedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("Starkov Dima");
	}
}
