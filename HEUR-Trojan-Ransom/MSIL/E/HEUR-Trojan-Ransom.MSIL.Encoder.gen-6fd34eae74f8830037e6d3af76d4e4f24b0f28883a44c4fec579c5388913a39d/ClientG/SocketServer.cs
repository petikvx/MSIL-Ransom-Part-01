using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ClientG;

public class SocketServer
{
	public delegate void DataEventHandler(int sock, byte[] B);

	public delegate void DisConnectedEventHandler(int sock);

	public delegate void ConnectedEventHandler(int sock);

	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private DataEventHandler DataEvent;

	private DisConnectedEventHandler DisConnectedEvent;

	private ConnectedEventHandler ConnectedEvent;

	private TcpListener S;

	public static double Bytes;

	private string[] oIP;

	public List<int> Online;

	public Socket[] SK;

	private int SKT;

	private string SPL;

	private Thread T;

	public event DataEventHandler Data
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		add
		{
			DataEvent = (DataEventHandler)Delegate.Combine(DataEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		remove
		{
			DataEvent = (DataEventHandler)Delegate.Remove(DataEvent, value);
		}
	}

	public event DisConnectedEventHandler DisConnected
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		add
		{
			DisConnectedEvent = (DisConnectedEventHandler)Delegate.Combine(DisConnectedEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		remove
		{
			DisConnectedEvent = (DisConnectedEventHandler)Delegate.Remove(DisConnectedEvent, value);
		}
	}

	public event ConnectedEventHandler Connected
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		add
		{
			ConnectedEvent = (ConnectedEventHandler)Delegate.Combine(ConnectedEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		remove
		{
			ConnectedEvent = (ConnectedEventHandler)Delegate.Remove(ConnectedEvent, value);
		}
	}

	[DebuggerNonUserCode]
	public SocketServer()
	{
		__ENCAddToList(this);
	}

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
	{
		checked
		{
			lock (__ENCList)
			{
				if (__ENCList.Count == __ENCList.Capacity)
				{
					int num = 0;
					int num2 = __ENCList.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = __ENCList[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								__ENCList[num] = __ENCList[num3];
							}
							num++;
						}
						num3++;
					}
					__ENCList.RemoveRange(num, __ENCList.Count - num);
					__ENCList.Capacity = __ENCList.Count;
				}
				__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}
	}

	public static string CPS(int Input)
	{
		return Input switch
		{
			0 => "Unknown", 
			1 => "CPU Enabled", 
			2 => "CPU Disabled by User via BIOS Setup", 
			3 => "CPU Disabled By BIOS (POST Error)", 
			4 => "CPU is Idle", 
			5 => "Reserved", 
			6 => "Reserved", 
			7 => "Other", 
			_ => "Unknown", 
		};
	}

	public static string CTMGORHR(int Input)
	{
		if (Input >= 1024)
		{
			return Strings.FormatNumber((object)(Convert.ToDouble(new decimal(Input)) / 1024.0), 1, (TriState)(-2), (TriState)(-2), (TriState)(-2)) + " GHz";
		}
		if ((Input >= 0 && Input <= 1023) ? true : false)
		{
			return Strings.FormatNumber((object)Input, 1, (TriState)(-2), (TriState)(-2), (TriState)(-2)) + " MHz";
		}
		return "????";
	}

	public static string GCL(int Input)
	{
		return Input switch
		{
			0 => "Internal", 
			1 => "External", 
			2 => "Reserved", 
			3 => "Unknown", 
			_ => "Unknown", 
		};
	}

	public static string GCS(int Input)
	{
		string text = default(string);
		return Input switch
		{
			1 => "Other", 
			2 => "Unknown", 
			3 => "Instruction", 
			4 => "Data", 
			5 => "Unified", 
			_ => text, 
		};
	}

	public static string GCT(int Input)
	{
		return Input switch
		{
			0 => "Unknown", 
			1 => "Readable", 
			2 => "Writeable", 
			3 => "Read/Write", 
			4 => "Write Once", 
			_ => "Unknown", 
		};
	}

	public static string GETF(int Input)
	{
		return Input switch
		{
			0 => "Unknown", 
			1 => "Other", 
			2 => "SIP", 
			3 => "DIP", 
			4 => "ZIP", 
			5 => "SOJ", 
			6 => "Proprietary", 
			7 => "SIMM", 
			8 => "DIMM", 
			9 => "TSOP", 
			10 => "PGA", 
			11 => "RIMM", 
			12 => "SODIMM", 
			13 => "SRIMM", 
			14 => "SMD", 
			15 => "SSMP", 
			16 => "QFP", 
			17 => "TQFP", 
			18 => "SOIC", 
			19 => "LCC", 
			20 => "PLCC", 
			21 => "BGA", 
			22 => "FPBGA", 
			23 => "LGA", 
			_ => "Unknown", 
		};
	}

	public static int GetIndex(int N)
	{
		int num = default(int);
		return N switch
		{
			0 => 10, 
			1 => 20, 
			2 => 30, 
			3 => 40, 
			4 => 50, 
			5 => 60, 
			6 => 70, 
			7 => 80, 
			8 => 90, 
			9 => 100, 
			_ => num, 
		};
	}

	public static string GetSize(ulong C)
	{
		string result;
		try
		{
			if (C >= 1099511627776L)
			{
				Bytes = (double)C / 1099511627776.0;
				result = Strings.FormatNumber((object)Bytes, 2, (TriState)(-2), (TriState)(-2), (TriState)(-2)) + " TB";
			}
			else if ((C >= 1073741824L && C <= 1099511627775L) ? true : false)
			{
				Bytes = (double)C / 1073741824.0;
				result = Strings.FormatNumber((object)Bytes, 2, (TriState)(-2), (TriState)(-2), (TriState)(-2)) + " GB";
			}
			else if ((C >= 1048576L && C <= 1073741823L) ? true : false)
			{
				Bytes = (double)C / 1048576.0;
				result = Strings.FormatNumber((object)Bytes, 2, (TriState)(-2), (TriState)(-2), (TriState)(-2)) + " MB";
			}
			else if ((C >= 1024L && C <= 1048575L) ? true : false)
			{
				Bytes = (double)C / 1024.0;
				result = Strings.FormatNumber((object)Bytes, 2, (TriState)(-2), (TriState)(-2), (TriState)(-2)) + " KB";
			}
			else if (C <= 1023L)
			{
				Bytes = C;
				result = Strings.FormatNumber((object)Bytes, 2, (TriState)(-2), (TriState)(-2), (TriState)(-2)) + " bytes";
			}
			else
			{
				result = "";
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			result = "";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static string GRAMType(int Input)
	{
		return Input switch
		{
			0 => "Unknown", 
			1 => "Other", 
			2 => "DRAM", 
			3 => "Synchronous DRAM", 
			4 => "Cache DRAM", 
			5 => "EDO", 
			6 => "EDRAM", 
			7 => "VRAM", 
			8 => "SRAM", 
			9 => "RAM", 
			11 => "Flash", 
			12 => "EEPROM", 
			14 => "EPROM", 
			15 => "CDRAM", 
			16 => "3DRAM", 
			17 => "SDRAM", 
			18 => "SGRAM", 
			19 => "RDRAM", 
			20 => "DDR", 
			21 => "DDR2", 
			22 => "DDR2 FB-DIMM", 
			24 => "DDR3", 
			25 => "FBD2", 
			_ => "????", 
		};
	}

	public static int GWS(int Input)
	{
		if ((Input >= 0 && Input <= 10) ? true : false)
		{
			return 0;
		}
		if ((Input >= 10 && Input <= 30) ? true : false)
		{
			return 1;
		}
		if ((Input >= 30 && Input <= 50) ? true : false)
		{
			return 2;
		}
		if ((Input >= 50 && Input <= 80) ? true : false)
		{
			return 2;
		}
		if ((Input >= 80 && Input <= 100) ? true : false)
		{
			return 3;
		}
		int result = default(int);
		return result;
	}

	public static string RAM(string N)
	{
		string result = "";
		checked
		{
			long num = (long)Math.Round(Math.Round(Conversion.Val(N)));
			if (num > 1073741824L)
			{
				result = (Convert.ToDouble(new decimal(num)) / 1073741824.0).ToString();
				result = result.Remove(4, result.Length - 4) + " GB";
			}
			else if (num > 1048576L)
			{
				result = (Convert.ToDouble(new decimal(num)) / 1048576.0).ToString();
				result = result.Remove(4, result.Length - 4) + " MB";
			}
			return result;
		}
	}

	public string IP(ref int sock)
	{
		try
		{
			oIP[sock] = Strings.Split(SK[sock].RemoteEndPoint!.ToString(), ":", -1, (CompareMethod)0)[0];
			return oIP[sock];
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result;
			if (oIP[sock] == null)
			{
				result = "X.X.X.X";
				ProjectData.ClearProjectError();
				return result;
			}
			result = oIP[sock];
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public void Start(int P)
	{
		SKT = -1;
		SK = new Socket[10000];
		SPL = "^_*]M[*_^";
		Online = new List<int>();
		oIP = new string[10000];
		S = new TcpListener(P);
		S.Start();
		Thread thread = new Thread(PND, 10);
		thread.Start();
	}

	public static string Encode(string Input)
	{
		return Convert.ToBase64String(Encoding.UTF8.GetBytes(Input));
	}

	public static string Decode(string Input)
	{
		return Encoding.UTF8.GetString(Convert.FromBase64String(Input));
	}

	public void Disconnect(int Sock)
	{
		try
		{
			SK[Sock].Disconnect(reuseSocket: false);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			SK[Sock].Close();
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		SK[Sock] = null;
	}

	public static string MD5(byte[] BB)
	{
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		BB = mD5CryptoServiceProvider.ComputeHash(BB);
		string text = "";
		byte[] array = BB;
		foreach (byte b in array)
		{
			text += b.ToString("x2");
		}
		return text;
	}

	private int NEWSKT()
	{
		checked
		{
			while (true)
			{
				Thread.Sleep(1);
				SKT++;
				if (SKT != SK.Length)
				{
					if (!Online.Contains(SKT))
					{
						break;
					}
				}
				else
				{
					SKT = 0;
				}
			}
			Online.Add(SKT);
			return Conversions.ToInteger(SKT.ToString().Clone());
		}
	}

	private void PND()
	{
		SK = new Socket[10000];
		while (true)
		{
			Thread.Sleep(1);
			if (S.Pending())
			{
				int num = NEWSKT();
				SK[num] = S.AcceptSocket();
				SK[num].ReceiveBufferSize = 99999;
				SK[num].SendBufferSize = 99999;
				SK[num].ReceiveTimeout = 9000;
				SK[num].SendTimeout = 9000;
				Thread thread = new Thread(delegate(object a0)
				{
					RC(Conversions.ToInteger(a0));
				}, 10);
				thread.Start(num);
				ConnectedEvent?.Invoke(num);
			}
		}
	}

	public void RC(int sock)
	{
		MemoryStream memoryStream = new MemoryStream();
		int num = 0;
		checked
		{
			while (true)
			{
				num++;
				if (num == 500)
				{
					try
					{
						if (SK[sock].Poll(-1, SelectMode.SelectRead) & (SK[sock].Available <= 0))
						{
							break;
						}
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
						break;
					}
					num = 0;
				}
				try
				{
					if (SK[sock] == null || !SK[sock].Connected)
					{
						break;
					}
					if (SK[sock].Available > 0)
					{
						byte[] array = new byte[SK[sock].Available - 1 + 1];
						SK[sock].Receive(array, 0, array.Length, SocketFlags.None);
						memoryStream.Write(array, 0, array.Length);
						while (Functions.BS(memoryStream.ToArray()).Contains(SPL))
						{
							Array array2 = Functions.fx(memoryStream.ToArray(), SPL);
							DataEvent?.Invoke(sock, (byte[])NewLateBinding.LateIndexGet((object)array2, new object[1] { 0 }, (string[])null));
							memoryStream.Dispose();
							memoryStream = new MemoryStream();
							if (array2.Length == 2)
							{
								memoryStream.Write((byte[])NewLateBinding.LateIndexGet((object)array2, new object[1] { 1 }, (string[])null), 0, Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateIndexGet((object)array2, new object[1] { 1 }, (string[])null), (Type)null, "length", new object[0], (string[])null, (Type[])null, (bool[])null)));
								Thread.Sleep(1);
								continue;
							}
							break;
						}
					}
					goto IL_017b;
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
				break;
				IL_017b:
				Thread.Sleep(1);
			}
			Disconnect(sock);
			try
			{
				Online.Remove(sock);
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
			DisConnectedEvent?.Invoke(sock);
		}
	}

	public void Send(int sock, string s)
	{
		Send(sock, Functions.SB(s));
	}

	public void Send(int sock, byte[] b)
	{
		try
		{
			MemoryStream memoryStream = new MemoryStream();
			memoryStream.Write(b, 0, b.Length);
			memoryStream.Write(Functions.SB(SPL), 0, SPL.Length);
			SK[sock].Send(memoryStream.ToArray(), 0, checked((int)memoryStream.Length), SocketFlags.None);
			memoryStream.Dispose();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Disconnect(sock);
			ProjectData.ClearProjectError();
		}
	}
}
