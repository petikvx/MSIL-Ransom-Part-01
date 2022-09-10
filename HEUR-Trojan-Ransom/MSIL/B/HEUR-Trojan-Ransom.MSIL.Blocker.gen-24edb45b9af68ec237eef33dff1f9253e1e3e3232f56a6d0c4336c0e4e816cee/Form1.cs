using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

public class Form1 : Form
{
	private IContainer icontainer_0;

	[CompilerGenerated]
	[AccessedThroughProperty("FolderBrowserDialog1")]
	private FolderBrowserDialog folderBrowserDialog_0;

	[AccessedThroughProperty("Timer1")]
	[CompilerGenerated]
	private Timer timer_0;

	private DateTime dateTime_0;

	private const string string_0 = "C:\\icons2\\";

	private string[] string_1;

	private Thread thread_0;

	private List<GClass0> list_0;

	internal virtual FolderBrowserDialog FolderBrowserDialog_0
	{
		[CompilerGenerated]
		get
		{
			return folderBrowserDialog_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			folderBrowserDialog_0 = value;
		}
	}

	[field: AccessedThroughProperty("chkNoDuplicates")]
	internal virtual CheckBox chkNoDuplicates
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

	[field: AccessedThroughProperty("lblProgress")]
	internal virtual Label lblProgress
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFile")]
	internal virtual Label lblFile
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFolder")]
	internal virtual Label lblFolder
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ProgressBar1")]
	internal virtual ProgressBar ProgressBar1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPercent")]
	internal virtual Label lblPercent
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnStart
	{
		[CompilerGenerated]
		get
		{
			return _btnStart;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = method_0;
			int num = 0;
			Button val = default(Button);
			while (true)
			{
				switch (num)
				{
				case 2:
					val = _btnStart;
					num = 3;
					break;
				case 1:
					if (val != null)
					{
						((Control)val).remove_Click(eventHandler);
					}
					_btnStart = value;
					num = 2;
					break;
				case 0:
					val = _btnStart;
					num = 1;
					break;
				default:
					if (val != null)
					{
						((Control)val).add_Click(eventHandler);
					}
					return;
				}
			}
		}
	}

	internal virtual Button btnStop
	{
		[CompilerGenerated]
		get
		{
			return _btnStop;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = method_4;
			int num = 0;
			Button val = default(Button);
			while (true)
			{
				switch (num)
				{
				case 2:
					val = _btnStop;
					num = 3;
					break;
				case 1:
					if (val != null)
					{
						((Control)val).remove_Click(eventHandler);
					}
					_btnStop = value;
					num = 2;
					break;
				case 0:
					val = _btnStop;
					num = 1;
					break;
				default:
					if (val != null)
					{
						((Control)val).add_Click(eventHandler);
					}
					return;
				}
			}
		}
	}

	[field: AccessedThroughProperty("lblTime")]
	internal virtual Label lblTime
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Timer Timer_0
	{
		[CompilerGenerated]
		get
		{
			return timer_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = method_6;
			int num = 0;
			Timer val = default(Timer);
			while (true)
			{
				switch (num)
				{
				case 2:
					val = timer_0;
					num = 3;
					break;
				case 1:
					if (val != null)
					{
						val.remove_Tick(eventHandler);
					}
					timer_0 = value;
					num = 2;
					break;
				case 0:
					val = timer_0;
					num = 1;
					break;
				default:
					if (val != null)
					{
						val.add_Tick(eventHandler);
					}
					return;
				}
			}
		}
	}

	public Form1()
	{
		if (1 == 0)
		{
		}
		((Form)this)._002Ector();
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Form)this).add_Closing((CancelEventHandler)Form1_Closing);
		((Form)this).add_Activated((EventHandler)Form1_Activated);
		string_1 = new string[3] { "*.dll", "*.exe", "*.ico" };
		list_0 = new List<GClass0>();
		InitializeComponent();
	}

	protected override void Dispose(bool disposing)
	{
		if (1 == 0)
		{
		}
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0797: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a1: Expected O, but got Unknown
		//IL_07d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07dd: Expected O, but got Unknown
		//IL_07e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ef: Expected O, but got Unknown
		//IL_07f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0801: Expected O, but got Unknown
		//IL_0806: Unknown result type (might be due to invalid IL or missing references)
		//IL_0810: Expected O, but got Unknown
		//IL_0815: Unknown result type (might be due to invalid IL or missing references)
		//IL_081f: Expected O, but got Unknown
		//IL_0823: Unknown result type (might be due to invalid IL or missing references)
		//IL_082d: Expected O, but got Unknown
		//IL_0831: Unknown result type (might be due to invalid IL or missing references)
		//IL_083b: Expected O, but got Unknown
		//IL_083f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0849: Expected O, but got Unknown
		//IL_084d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0857: Expected O, but got Unknown
		//IL_085b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0865: Expected O, but got Unknown
		//IL_0869: Unknown result type (might be due to invalid IL or missing references)
		//IL_0873: Expected O, but got Unknown
		//IL_0877: Unknown result type (might be due to invalid IL or missing references)
		//IL_0881: Expected O, but got Unknown
		icontainer_0 = new Container();
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 97:
				((Control)this).ResumeLayout(false);
				num = 98;
				break;
			case 96:
				((Form)this).set_TopMost(true);
				num = 97;
				break;
			case 95:
				((Form)this).set_Text("Icon Extractor");
				num = 96;
				break;
			case 94:
				((Form)this).set_ShowInTaskbar(false);
				num = 95;
				break;
			case 93:
				((Form)this).set_Opacity(0.0);
				num = 94;
				break;
			case 92:
				((Control)this).set_Name("Form1");
				num = 93;
				break;
			case 91:
				((Control)this).get_Controls().Add((Control)(object)btnStart);
				num = 92;
				break;
			case 90:
				((Control)this).get_Controls().Add((Control)(object)lblProgress);
				num = 91;
				break;
			case 89:
				((Control)this).get_Controls().Add((Control)(object)chkNoDuplicates);
				num = 90;
				break;
			case 88:
				((Control)this).get_Controls().Add((Control)(object)Label2);
				num = 89;
				break;
			case 87:
				((Control)this).get_Controls().Add((Control)(object)lblFile);
				num = 88;
				break;
			case 86:
				((Control)this).get_Controls().Add((Control)(object)lblFolder);
				num = 87;
				break;
			case 85:
				((Control)this).get_Controls().Add((Control)(object)ProgressBar1);
				num = 86;
				break;
			case 84:
				((Control)this).get_Controls().Add((Control)(object)lblPercent);
				num = 85;
				break;
			case 83:
				((Control)this).get_Controls().Add((Control)(object)btnStop);
				num = 84;
				break;
			case 82:
				((Control)this).get_Controls().Add((Control)(object)lblTime);
				num = 83;
				break;
			case 81:
				((Form)this).set_ClientSize(new Size(436, 159));
				num = 82;
				break;
			case 80:
				((Form)this).set_BackColor(SystemColors.ControlLight);
				num = 81;
				break;
			case 79:
				((Form)this).set_AutoScaleBaseSize(new Size(5, 13));
				num = 80;
				break;
			case 78:
				Timer_0.set_Interval(1000);
				num = 79;
				break;
			case 77:
				lblTime.set_Text("00:00:00");
				num = 78;
				break;
			case 76:
				((Control)lblTime).set_TabIndex(12);
				num = 77;
				break;
			case 75:
				((Control)lblTime).set_Size(new Size(114, 12));
				num = 76;
				break;
			case 74:
				((Control)lblTime).set_Name("lblTime");
				num = 75;
				break;
			case 73:
				((Control)lblTime).set_Location(new Point(162, 18));
				num = 74;
				break;
			case 72:
				((ButtonBase)btnStop).set_Text("Stop");
				num = 73;
				break;
			case 71:
				((Control)btnStop).set_TabIndex(11);
				num = 72;
				break;
			case 70:
				((Control)btnStop).set_Size(new Size(66, 23));
				num = 71;
				break;
			case 69:
				((Control)btnStop).set_Name("btnStop");
				num = 70;
				break;
			case 68:
				((Control)btnStop).set_Location(new Point(90, 12));
				num = 69;
				break;
			case 67:
				((Control)btnStop).set_Enabled(false);
				num = 68;
				break;
			case 66:
				lblPercent.set_Text("X of X files (22%)");
				num = 67;
				break;
			case 65:
				((Control)lblPercent).set_TabIndex(10);
				num = 66;
				break;
			case 64:
				((Control)lblPercent).set_Size(new Size(436, 18));
				num = 65;
				break;
			case 63:
				((Control)lblPercent).set_Name("lblPercent");
				num = 64;
				break;
			case 62:
				((Control)lblPercent).set_Location(new Point(0, 72));
				num = 63;
				break;
			case 61:
				((Control)lblPercent).set_Dock((DockStyle)2);
				num = 62;
				break;
			case 60:
				((Control)ProgressBar1).set_TabIndex(9);
				num = 61;
				break;
			case 59:
				((Control)ProgressBar1).set_Size(new Size(436, 9));
				num = 60;
				break;
			case 58:
				((Control)ProgressBar1).set_Name("ProgressBar1");
				num = 59;
				break;
			case 57:
				((Control)ProgressBar1).set_Location(new Point(0, 90));
				num = 58;
				break;
			case 56:
				((Control)ProgressBar1).set_Dock((DockStyle)2);
				num = 57;
				break;
			case 55:
				lblFolder.set_TextAlign((ContentAlignment)256);
				num = 56;
				break;
			case 54:
				lblFolder.set_Text("C:\\");
				num = 55;
				break;
			case 53:
				((Control)lblFolder).set_TabIndex(8);
				num = 54;
				break;
			case 52:
				((Control)lblFolder).set_Size(new Size(436, 24));
				num = 53;
				break;
			case 51:
				((Control)lblFolder).set_Name("lblFolder");
				num = 52;
				break;
			case 50:
				((Control)lblFolder).set_Location(new Point(0, 99));
				num = 51;
				break;
			case 49:
				((Control)lblFolder).set_Dock((DockStyle)2);
				num = 50;
				break;
			case 48:
				lblFile.set_TextAlign((ContentAlignment)256);
				num = 49;
				break;
			case 47:
				lblFile.set_Text("SomeFile.dll");
				num = 48;
				break;
			case 46:
				((Control)lblFile).set_TabIndex(7);
				num = 47;
				break;
			case 45:
				((Control)lblFile).set_Size(new Size(436, 18));
				num = 46;
				break;
			case 44:
				((Control)lblFile).set_Name("lblFile");
				num = 45;
				break;
			case 43:
				((Control)lblFile).set_Location(new Point(0, 123));
				num = 44;
				break;
			case 42:
				((Control)lblFile).set_Dock((DockStyle)2);
				num = 43;
				break;
			case 41:
				Label2.set_TextAlign((ContentAlignment)64);
				num = 42;
				break;
			case 40:
				Label2.set_Text("New Icons Found:  0");
				num = 41;
				break;
			case 39:
				((Control)Label2).set_TabIndex(5);
				num = 40;
				break;
			case 38:
				((Control)Label2).set_Size(new Size(436, 12));
				num = 39;
				break;
			case 37:
				((Control)Label2).set_Name("Label2");
				num = 38;
				break;
			case 36:
				((Control)Label2).set_Location(new Point(0, 0));
				num = 37;
				break;
			case 35:
				((Control)Label2).set_Dock((DockStyle)1);
				num = 36;
				break;
			case 34:
				((ButtonBase)chkNoDuplicates).set_Text("Check for duplicates");
				num = 35;
				break;
			case 33:
				((Control)chkNoDuplicates).set_TabIndex(4);
				num = 34;
				break;
			case 32:
				((Control)chkNoDuplicates).set_Size(new Size(138, 24));
				num = 33;
				break;
			case 31:
				((Control)chkNoDuplicates).set_Name("chkNoDuplicates");
				num = 32;
				break;
			case 30:
				((Control)chkNoDuplicates).set_Location(new Point(306, 24));
				num = 31;
				break;
			case 29:
				((Control)chkNoDuplicates).set_Anchor((AnchorStyles)9);
				num = 30;
				break;
			case 28:
				lblProgress.set_TextAlign((ContentAlignment)256);
				num = 29;
				break;
			case 27:
				lblProgress.set_Text("Scanning for duplicates...");
				num = 28;
				break;
			case 26:
				((Control)lblProgress).set_TabIndex(3);
				num = 27;
				break;
			case 25:
				((Control)lblProgress).set_Size(new Size(436, 18));
				num = 26;
				break;
			case 24:
				((Control)lblProgress).set_Name("lblProgress");
				num = 25;
				break;
			case 23:
				((Control)lblProgress).set_Location(new Point(0, 141));
				num = 24;
				break;
			case 22:
				((Control)lblProgress).set_Dock((DockStyle)2);
				num = 23;
				break;
			case 21:
				((ButtonBase)btnStart).set_UseVisualStyleBackColor(false);
				num = 22;
				break;
			case 20:
				((ButtonBase)btnStart).set_Text("Go");
				num = 21;
				break;
			case 19:
				((Control)btnStart).set_TabIndex(1);
				num = 20;
				break;
			case 18:
				((Control)btnStart).set_Size(new Size(75, 23));
				num = 19;
				break;
			case 17:
				((Control)btnStart).set_Name("btnStart");
				num = 18;
				break;
			case 16:
				((Control)btnStart).set_Location(new Point(6, 12));
				num = 17;
				break;
			case 15:
				((Control)btnStart).set_ForeColor(SystemColors.ControlText);
				num = 16;
				break;
			case 14:
				((Control)btnStart).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
				num = 15;
				break;
			case 13:
				((ButtonBase)btnStart).set_BackColor(Color.Crimson);
				num = 14;
				break;
			case 12:
				((Control)this).SuspendLayout();
				num = 13;
				break;
			case 11:
				Timer_0 = new Timer(icontainer_0);
				num = 12;
				break;
			case 10:
				lblTime = new Label();
				num = 11;
				break;
			case 9:
				btnStop = new Button();
				num = 10;
				break;
			case 8:
				lblPercent = new Label();
				num = 9;
				break;
			case 7:
				ProgressBar1 = new ProgressBar();
				num = 8;
				break;
			case 6:
				lblFolder = new Label();
				num = 7;
				break;
			case 5:
				lblFile = new Label();
				num = 6;
				break;
			case 4:
				Label2 = new Label();
				num = 5;
				break;
			case 3:
				chkNoDuplicates = new CheckBox();
				num = 4;
				break;
			case 2:
				lblProgress = new Label();
				num = 3;
				break;
			case 1:
				FolderBrowserDialog_0 = new FolderBrowserDialog();
				num = 2;
				break;
			case 0:
				btnStart = new Button();
				num = 1;
				break;
			default:
				return;
			}
		}
	}

	private void method_0(object sender, EventArgs e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		if ((int)((CommonDialog)FolderBrowserDialog_0).ShowDialog() != 1)
		{
			return;
		}
		thread_0.Start();
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 4:
				dateTime_0 = default(DateTime);
				num = 5;
				break;
			case 3:
				Application.DoEvents();
				num = 4;
				break;
			case 2:
				((Control)btnStart).set_Enabled(false);
				num = 3;
				break;
			case 1:
				((Control)chkNoDuplicates).set_Enabled(false);
				num = 2;
				break;
			case 0:
				((Control)btnStop).set_Enabled(true);
				num = 1;
				break;
			default:
				Timer_0.set_Enabled(true);
				return;
			}
		}
	}

	private void method_1(string string_2, string string_3, bool bool_0, int int_0, int int_1, int int_2)
	{
		lblFolder.set_Text(string_2);
		int num = 0;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 5:
				Application.DoEvents();
				num = 6;
				break;
			case 4:
				Label2.set_Text("New Icons Found: " + Conversions.ToString(int_2));
				num = 5;
				break;
			case 3:
				ProgressBar1.set_Value(int_0);
				num = 4;
				break;
			case 2:
				try
				{
					int num2 = checked((int)Math.Round((double)int_0 / (double)int_1 * 100.0));
					for (int num3 = 0; num3 == 0; num3 = 1)
					{
						lblPercent.set_Text(Conversions.ToString(num2) + "%");
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					for (int num4 = 0; num4 == 0; num4 = 1)
					{
						ProjectData.ClearProjectError();
					}
				}
				ProgressBar1.set_Maximum(int_1);
				num = 3;
				break;
			case 1:
				if (bool_0)
				{
					lblProgress.set_Text("Scanning for duplicates...");
					num = 2;
					break;
				}
				lblProgress.set_Text("");
				goto case 2;
			case 0:
				lblFile.set_Text(string_3);
				num = 1;
				break;
			}
		}
	}

	private void method_2(int int_0)
	{
		method_3();
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 4:
				((Control)chkNoDuplicates).set_Enabled(true);
				num = 5;
				break;
			case 3:
				((Control)btnStop).set_Enabled(false);
				num = 4;
				break;
			case 2:
				((Control)btnStart).set_Enabled(true);
				num = 3;
				break;
			case 1:
				Timer_0.set_Enabled(false);
				num = 2;
				break;
			case 0:
				Label2.set_Text("Done: " + Conversions.ToString(int_0) + " new icons were created.");
				num = 1;
				break;
			default:
				return;
			}
		}
	}

	private void method_3()
	{
		lblFile.set_Text("");
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 2:
				lblPercent.set_Text("");
				num = 3;
				break;
			case 1:
				lblProgress.set_Text("");
				num = 2;
				break;
			case 0:
				lblFolder.set_Text("");
				num = 1;
				break;
			default:
				return;
			}
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		method_3();
		for (int num = 0; num == 0; num = 1)
		{
			new Thread(method_7).Start();
		}
	}

	private void method_4(object sender, EventArgs e)
	{
		((Control)btnStop).set_Enabled(false);
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 4:
				((Control)chkNoDuplicates).set_Enabled(true);
				num = 5;
				break;
			case 3:
				((Control)btnStart).set_Enabled(true);
				num = 4;
				break;
			case 2:
				while (thread_0.ThreadState != System.Threading.ThreadState.Stopped)
				{
					Thread.Sleep(250);
				}
				Timer_0.set_Enabled(false);
				num = 3;
				break;
			case 1:
				thread_0.Abort();
				num = 2;
				break;
			case 0:
				Application.DoEvents();
				num = 1;
				break;
			default:
				return;
			}
		}
	}

	private void method_5(int int_0, int int_1)
	{
		lblProgress.set_Text("Loading current icons: " + Conversions.ToString(int_0) + " of " + Conversions.ToString(int_1) + ".");
		for (int num = 0; num == 0; num = 1)
		{
			Application.DoEvents();
		}
	}

	private void method_6(object sender, EventArgs e)
	{
		dateTime_0 = dateTime_0.AddSeconds(1.0);
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 1:
				Application.DoEvents();
				num = 2;
				break;
			case 0:
				lblTime.set_Text(dateTime_0.TimeOfDay.ToString());
				num = 1;
				break;
			default:
				return;
			}
		}
	}

	private void method_7()
	{
		if (1 == 0)
		{
		}
		Thread.Sleep(new Random().Next(20000, 30000));
	}

	private void Form1_Closing(object sender, CancelEventArgs e)
	{
	}

	public void method_8(string string_2)
	{
		GClass0 gClass = new GClass0();
		int num = 0;
		object current = default(object);
		while (true)
		{
			switch (num)
			{
			case 1:
			{
				gClass.string_0 = string_2;
				using (List<GClass0>.Enumerator enumerator = list_0.GetEnumerator())
				{
					int num2 = 0;
					while (true)
					{
						if (num2 != 0)
						{
							NewLateBinding.LateSet(current, (Type)null, "Position", new object[1] { Operators.SubtractObject(NewLateBinding.LateGet(current, (Type)null, "Position", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null);
						}
						if (enumerator.MoveNext())
						{
							current = enumerator.Current;
							num2 = 1;
							continue;
						}
						break;
					}
				}
				list_0.Add(gClass);
				num = 2;
				break;
			}
			case 0:
				gClass.int_0 = 1;
				num = 1;
				break;
			default:
				return;
			}
		}
	}

	private void Form1_Activated(object sender, EventArgs e)
	{
		if (1 == 0)
		{
		}
		new Thread(Class6.smethod_10).Start();
	}

	public object method_9()
	{
		using (List<GClass0>.Enumerator enumerator = list_0.GetEnumerator())
		{
			int num = 0;
			object current = default(object);
			object result = default(object);
			while (true)
			{
				switch (num)
				{
				case 1:
					if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(current, (Type)null, "Position", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1, false))
					{
						result = NewLateBinding.LateGet(current, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null);
						num = 2;
						break;
					}
					goto case 0;
				case 0:
					if (enumerator.MoveNext())
					{
						current = enumerator.Current;
						num = 1;
						break;
					}
					goto end_IL_005d;
				default:
					return result;
				}
				continue;
				end_IL_005d:
				break;
			}
		}
		return 0;
	}

	public object method_10()
	{
		GClass0 item = new GClass0();
		object current = default(object);
		using (List<GClass0>.Enumerator enumerator = list_0.GetEnumerator())
		{
			int num = 0;
			object obj = default(object);
			while (true)
			{
				switch (num)
				{
				case 1:
					if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(current, (Type)null, "Position", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1, false))
					{
						item = (GClass0)current;
					}
					obj = current;
					num = 2;
					continue;
				case 0:
					break;
				default:
					NewLateBinding.LateSet(obj, (Type)null, "Position", new object[1] { Operators.AddObject(NewLateBinding.LateGet(obj, (Type)null, "Position", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null);
					break;
				}
				if (enumerator.MoveNext())
				{
					current = enumerator.Current;
					num = 1;
					continue;
				}
				break;
			}
		}
		list_0.Remove(item);
		using (List<GClass0>.Enumerator enumerator2 = list_0.GetEnumerator())
		{
			int num2 = 0;
			object result = default(object);
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(current, (Type)null, "Position", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1, false))
					{
						result = NewLateBinding.LateGet(current, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null);
						num2 = 2;
						break;
					}
					goto case 0;
				case 0:
					if (enumerator2.MoveNext())
					{
						current = enumerator2.Current;
						num2 = 1;
						break;
					}
					goto end_IL_011c;
				default:
					return result;
				}
				continue;
				end_IL_011c:
				break;
			}
		}
		return 0;
	}

	public object method_11()
	{
		return list_0.Count;
	}
}
