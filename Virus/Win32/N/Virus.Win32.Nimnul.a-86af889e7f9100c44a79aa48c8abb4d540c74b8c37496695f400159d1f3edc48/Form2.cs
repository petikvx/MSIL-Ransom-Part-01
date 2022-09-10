using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

[DesignerGenerated]
public class Form2 : Form
{
	private IContainer icontainer_0;

	private TextBox _TextBox1;

	private Timer timer_0;

	private Timer timer_1;

	private object object_0;

	private int int_0;

	private int int_1;

	private string string_0;

	private int int_2;

	public const int int_3 = 16;

	public const int int_4 = 2;

	public const int int_5 = 4096;

	public const int int_6 = 4;

	public const int int_7 = 2;

	public const int int_8 = 8;

	public const int int_9 = 32;

	private string string_1;

	private string string_2;

	internal virtual TextBox TextBox1
	{
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox1 = value;
		}
	}

	internal virtual Timer Timer_0
	{
		get
		{
			return timer_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Timer_0_Tick;
			if (timer_0 != null)
			{
				timer_0.remove_Tick(eventHandler);
			}
			timer_0 = value;
			if (timer_0 != null)
			{
				timer_0.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer_1
	{
		get
		{
			return timer_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Timer_1_Tick;
			if (timer_1 != null)
			{
				timer_1.remove_Tick(eventHandler);
			}
			timer_1 = value;
			if (timer_1 != null)
			{
				timer_1.add_Tick(eventHandler);
			}
		}
	}

	public Form2()
	{
		((Form)this).add_Load((EventHandler)Form2_Load);
		object_0 = Application.get_StartupPath() + "ultradll.dll";
		string_2 = Path.GetFileNameWithoutExtension(Application.get_ExecutablePath());
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
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		icontainer_0 = new Container();
		TextBox1 = new TextBox();
		Timer_0 = new Timer(icontainer_0);
		Timer_1 = new Timer(icontainer_0);
		((Control)this).SuspendLayout();
		TextBox textBox = TextBox1;
		Point location = new Point(12, 12);
		((Control)textBox).set_Location(location);
		((Control)TextBox1).set_Name("TextBox1");
		((TextBoxBase)TextBox1).set_ReadOnly(true);
		TextBox textBox2 = TextBox1;
		Size size = new Size(167, 20);
		((Control)textBox2).set_Size(size);
		((Control)TextBox1).set_TabIndex(0);
		TextBox1.set_Text("Waiting for WarRock.exe");
		TextBox1.set_TextAlign((HorizontalAlignment)2);
		Timer_0.set_Enabled(true);
		Timer_0.set_Interval(50);
		Timer_1.set_Interval(300);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(191, 43);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Control)this).set_Name("Form2");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("GzN - WarRock Loader");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int ReadProcessMemory(int hProcess, int lpBaseAddress, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpBuffer, int nSize, ref int lpNumberOfBytesWritten);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int LoadLibraryA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpLibFileName);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int VirtualAllocEx(int hProcess, int lpAddress, int dwSize, int flAllocationType, int flProtect);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int WriteProcessMemory(int hProcess, int lpBaseAddress, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpBuffer, int nSize, ref int lpNumberOfBytesWritten);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetProcAddress(int hModule, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpProcName);

	[DllImport("Kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetModuleHandleA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpModuleName);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int CreateRemoteThread(int hProcess, int lpThreadAttributes, int dwStackSize, int lpStartAddress, int lpParameter, int dwCreationFlags, ref int lpThreadId);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int OpenProcess(int dwDesiredAccess, int bInheritHandle, int dwProcessId);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int FindWindowA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpClassName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpWindowName);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int CloseHandleA(int hObject);

	private void method_0()
	{
		int try0000_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		int num4 = default(int);
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
					Timer_0.Stop();
					Timer_1.Stop();
					Process[] processesByName = Process.GetProcessesByName("WarRock");
					int_0 = OpenProcess(42, 0, processesByName[0].Id);
					string_0 = Conversions.ToString(object_0);
					string lpModuleName = "Kernel32";
					int moduleHandleA = GetModuleHandleA(ref lpModuleName);
					string lpProcName = "LoadLibraryA";
					int_1 = GetProcAddress(moduleHandleA, ref lpProcName);
					int_2 = checked(1 + Strings.Len(string_0));
					int num3 = VirtualAllocEx(int_0, 0, int_2, 4096, 4);
					int hProcess = int_0;
					ref string lpBuffer = ref string_0;
					int nSize = int_2;
					int lpNumberOfBytesWritten = 0;
					WriteProcessMemory(hProcess, num3, ref lpBuffer, nSize, ref lpNumberOfBytesWritten);
					int hProcess2 = int_0;
					int lpStartAddress = int_1;
					lpNumberOfBytesWritten = 0;
					CreateRemoteThread(hProcess2, 0, 0, lpStartAddress, num3, 0, ref lpNumberOfBytesWritten);
					CloseHandleA(int_0);
					break;
				}
				case 238:
					num = -1;
					switch (num2)
					{
					case 2:
						break;
					default:
						goto end_IL_0000;
					}
					break;
				}
				num4 = 1;
				((Control)this).Show();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj, num4);
				try0000_dispatch = 238;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void Form2_Load(object sender, EventArgs e)
	{
		if (File.Exists(Conversions.ToString(object_0)))
		{
			File.Delete(Conversions.ToString(object_0));
		}
		((ServerComputer)Class0.Computer).get_FileSystem().WriteAllBytes(Conversions.ToString(object_0), Class4.Byte_0, true);
		FileSystem.SetAttr(Conversions.ToString(object_0), (FileAttribute)2);
		Timer_0.Start();
	}

	private void Timer_0_Tick(object sender, EventArgs e)
	{
		if (File.Exists(Conversions.ToString(object_0)))
		{
			Process[] processesByName = Process.GetProcessesByName("WarRock");
			if (processesByName.Length == 0)
			{
				((TextBoxBase)TextBox1).set_ForeColor(Color.YellowGreen);
				TextBox1.set_Text("Waiting for WarRock.exe");
				return;
			}
			method_0();
			TextBox1.set_Text("WarRock Injected!");
			Timer_1.Start();
			Timer_0.Stop();
		}
	}

	private void Timer_1_Tick(object sender, EventArgs e)
	{
		Application.Exit();
	}
}
