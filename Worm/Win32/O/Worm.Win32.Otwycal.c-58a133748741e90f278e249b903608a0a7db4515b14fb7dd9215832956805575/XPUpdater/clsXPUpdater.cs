using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace XPUpdater;

public class clsXPUpdater
{
	public struct GStruct0
	{
		public string DownloadURL1;

		public string DownloadURL2;

		public string DownloadURL3;

		public string DownloadURL4;

		public string DownloadURL5;

		public string Content;

		public DateTime UpdateTime;
	}

	public delegate void ChangeMessageEventHandler(string Message);

	public delegate void ErrorMessageEventHandler(string uMessage, ErrObject Err);

	public delegate void DonloadProgressEventHandler(string FileURL, string localFile, long fileLength, long byteComplete);

	public delegate void DownloadCompleteEventHandler(string sFile);

	public delegate void DoneEventHandler();

	public delegate void StartProgramEventHandler(string sFile);

	public delegate void EndProgramEventHandler(string sFile);

	private static ArrayList __ENCList = new ArrayList();

	private ChangeMessageEventHandler ChangeMessageEvent;

	private ErrorMessageEventHandler ErrorMessageEvent;

	private DonloadProgressEventHandler DonloadProgressEvent;

	private DownloadCompleteEventHandler DownloadCompleteEvent;

	private DoneEventHandler DoneEvent;

	private StartProgramEventHandler StartProgramEvent;

	private EndProgramEventHandler EndProgramEvent;

	public string _ConfigFile;

	public cls_IniFileAccess ConfigFile;

	public bool state;

	public event ChangeMessageEventHandler ChangeMessage
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		add
		{
			ChangeMessageEvent = (ChangeMessageEventHandler)Delegate.Combine(ChangeMessageEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		remove
		{
			ChangeMessageEvent = (ChangeMessageEventHandler)Delegate.Remove(ChangeMessageEvent, value);
		}
	}

	public event ErrorMessageEventHandler ErrorMessage
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		add
		{
			ErrorMessageEvent = (ErrorMessageEventHandler)Delegate.Combine(ErrorMessageEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		remove
		{
			ErrorMessageEvent = (ErrorMessageEventHandler)Delegate.Remove(ErrorMessageEvent, value);
		}
	}

	public event DonloadProgressEventHandler DonloadProgress
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		add
		{
			DonloadProgressEvent = (DonloadProgressEventHandler)Delegate.Combine(DonloadProgressEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		remove
		{
			DonloadProgressEvent = (DonloadProgressEventHandler)Delegate.Remove(DonloadProgressEvent, value);
		}
	}

	public event DownloadCompleteEventHandler DownloadComplete
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		add
		{
			DownloadCompleteEvent = (DownloadCompleteEventHandler)Delegate.Combine(DownloadCompleteEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		remove
		{
			DownloadCompleteEvent = (DownloadCompleteEventHandler)Delegate.Remove(DownloadCompleteEvent, value);
		}
	}

	public event DoneEventHandler Done
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		add
		{
			DoneEvent = (DoneEventHandler)Delegate.Combine(DoneEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		remove
		{
			DoneEvent = (DoneEventHandler)Delegate.Remove(DoneEvent, value);
		}
	}

	public event StartProgramEventHandler StartProgram
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		add
		{
			StartProgramEvent = (StartProgramEventHandler)Delegate.Combine(StartProgramEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		remove
		{
			StartProgramEvent = (StartProgramEventHandler)Delegate.Remove(StartProgramEvent, value);
		}
	}

	public event EndProgramEventHandler EndProgram
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		add
		{
			EndProgramEvent = (EndProgramEventHandler)Delegate.Combine(EndProgramEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		remove
		{
			EndProgramEvent = (EndProgramEventHandler)Delegate.Remove(EndProgramEvent, value);
		}
	}

	public bool RunSetup(string sFile, string Arg, bool wait)
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		bool flag = default(bool);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
				{
					ProjectData.ClearProjectError();
					num2 = 2;
					StartProgramEvent?.Invoke(sFile);
					Process process = Process.Start(sFile, Arg);
					if (wait)
					{
						process.WaitForExit();
					}
					EndProgramEvent?.Invoke(sFile);
					flag = true;
					goto end_IL_0001;
				}
				case 123:
					num = -1;
					switch (num2)
					{
					case 2:
						ErrorMessageEvent?.Invoke("پروگرامما قاچىلاشتا مەسىلە كۆرۈلدى.", Information.Err());
						Information.Err().Clear();
						goto end_IL_0001;
					}
					break;
				}
				goto IL_00b5;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 123;
				continue;
			}
			break;
			IL_00b5:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		bool result = flag;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public clsXPUpdater()
	{
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
		ConfigFile = new cls_IniFileAccess();
		if (Operators.CompareString(FileSystem.Dir(Application.get_StartupPath() + "\\XPUpdate.ini", (FileAttribute)0), "", false) == 0)
		{
			CreateINI(Application.get_StartupPath() + "\\XPUpdate.ini");
		}
		_ConfigFile = Application.get_StartupPath() + "\\XPUpdate.ini";
	}

	public bool GetServerUpdateTime(ref DateTime value)
	{
		short num = 1;
		bool result = default(bool);
		while (true)
		{
			try
			{
				string text = UpdateInfoURL(num);
				if (Operators.CompareString(text, "", false) != 0)
				{
					text += "?param=updatetime";
					ChangeMessageEvent?.Invoke("ھازىر توردىن يېڭىلانغان نۇسخىلارنى ئىزدەۋاتىدۇ...");
					WebClient webClient = new WebClient();
					string value2 = webClient.DownloadString(text);
					webClient = null;
					value = Convert.ToDateTime(value2);
					ChangeMessageEvent?.Invoke("ئىزدەش ئاخىرلاشتى.");
					result = true;
					return result;
				}
				ErrorMessageEvent?.Invoke("سەپلىمە ھۆججەتتە خاتالىق بار.", Information.Err());
				result = false;
				return result;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				WebClient webClient = null;
				int number = Information.Err().get_Number();
				if (number == 5)
				{
					if (num < 3)
					{
						ErrorMessageEvent?.Invoke(num + " - ئادېرىىستا تىن ئۇچۇر كەلمىدى...", Information.Err());
						num = checked((short)(num + 1));
						Information.Err().Clear();
						ProjectData.ClearProjectError();
						continue;
					}
					ErrorMessageEvent?.Invoke("يېڭى نۇسخا تەكشۈرۈش مەغلۇب بولدى", Information.Err());
					goto IL_0169;
				}
				ErrorMessageEvent?.Invoke("سەپلىمە ھۆججەتتە خاتالىق بار.", Information.Err());
				goto IL_0169;
				IL_0169:
				Information.Err().Clear();
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	public bool GetLocalUpdateTime(ref DateTime value)
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		bool flag = default(bool);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
				{
					ProjectData.ClearProjectError();
					num2 = 2;
					string key = ConfigFile.GetKey("UpdateInfo", "LocalUpdateTime", _ConfigFile);
					if (Operators.CompareString(key, "", false) != 0)
					{
						value = Convert.ToDateTime(key);
						flag = true;
					}
					else
					{
						ErrorMessageEvent?.Invoke("مەشغۇلات مەغلۇب بولدى، سەپلىمە ھۆججەت  " + _ConfigFile + " دە خاتالىق بار.", Information.Err());
					}
					goto end_IL_0001;
				}
				case 169:
					num = -1;
					switch (num2)
					{
					case 2:
						ErrorMessageEvent?.Invoke("سەپلىمە ھۆججەتنى ئوقۇشتا خاتالىق كۆرۈلدى.", Information.Err());
						Information.Err().Clear();
						goto end_IL_0001;
					}
					break;
				}
				goto IL_00e1;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 169;
				continue;
			}
			break;
			IL_00e1:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		bool result = flag;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public bool GetServerUpdateCount(ref short value)
	{
		short num = 1;
		bool result = default(bool);
		while (true)
		{
			try
			{
				ChangeMessageEvent?.Invoke("ھازىر يېڭىلانغان نۇسخىنى ئىزدەۋاتىدۇ...");
				string text = UpdateInfoURL(num);
				if (Operators.CompareString(text, "", false) != 0)
				{
					text += "?Param=updatecount";
					string text2 = new WebClient().DownloadString(text);
					if (Operators.CompareString(text2, "", false) != 0)
					{
						value = Convert.ToInt16(text2);
						ChangeMessageEvent?.Invoke("يېڭى نۇسخا تەكشۈرۈش ئاياغلاشتى.");
						result = true;
						return result;
					}
					ErrorMessageEvent?.Invoke("مۇلازىمېتىر ئەۋەتكەن ئۇچۇردا خاتالىق بار.", Information.Err());
					result = false;
					return result;
				}
				ErrorMessageEventHandler errorMessageEvent = ErrorMessageEvent;
				if (errorMessageEvent != null)
				{
					errorMessageEvent("سەپلىمە ھۆججەت خاتالىقى: " + _ConfigFile, Information.Err());
					return result;
				}
				return result;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				int number = Information.Err().get_Number();
				if (number == 5)
				{
					if (num < 3)
					{
						num = checked((short)(num + 1));
						Information.Err().Clear();
						ProjectData.ClearProjectError();
						continue;
					}
					ErrorMessageEvent?.Invoke("يېڭى نۇسخا تەكشۈرۈشتە خاتالىق كۆرۈلدى.", Information.Err());
					Information.Err().Clear();
					result = false;
					ProjectData.ClearProjectError();
					return result;
				}
				ErrorMessageEvent?.Invoke("يېڭى نۇسخا تەكشۈرۈشتە خاتالىق كۆرۈلدى.", Information.Err());
				Information.Err().Clear();
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	public short isUpdated()
	{
		try
		{
			DateTime value = default(DateTime);
			GetLocalUpdateTime(ref value);
			DateTime value2 = default(DateTime);
			if (GetServerUpdateTime(ref value2))
			{
				if (DateTime.Compare(value, value2) < 0)
				{
					ChangeMessageEvent?.Invoke("يېڭىلانغان نۇسخا بايقالدى.");
					return 1;
				}
				ChangeMessageEvent?.Invoke("يېڭىلانغان نۇسخا تېپىلمىدى، سىز ئىشلىتىۋاتقان سىستېما نۆۋەتتىكى ئەڭ يېڭى نۇسخا.");
				return 0;
			}
			Information.Err().Raise(5, (object)null, (object)null, (object)null, (object)null);
			short result = default(short);
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Information.Err().Clear();
			short result = 2;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public bool UpdateRun()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		short num = 1;
		checked
		{
			switch (isUpdated())
			{
			case 0:
				Interaction.MsgBox((object)"مۇبارەتك بولسۇن! سىز ئىشلىتىۋاتقان سىستېما نۆۋەتتىكى ئەڭ يېڭى نۇسخا ئىكەن.", (MsgBoxStyle)64, (object)null);
				return true;
			case 2:
				ErrorMessageEvent?.Invoke("توردىن تەكشۈرۈش مەغلۇب بولدى", Information.Err());
				return false;
			default:
			{
				short value = default(short);
				if (!GetServerUpdateCount(ref value))
				{
					return false;
				}
				GStruct0[] array = (GStruct0[])Utils.CopyArray((Array)array, (Array)new GStruct0[value + 1]);
				short num2 = value;
				short num3 = 1;
				while (true)
				{
					short num4 = num3;
					short num5 = num2;
					if (num4 > num5)
					{
						break;
					}
					bool flag = false;
					if (ReadUpdateFileInfo(num3, ref array[num3]))
					{
						ChangeMessageEvent?.Invoke("ھازىر ھۆججەت چۈشۈرۈۋاتىدۇ...");
						while (true)
						{
							string text;
							string text2;
							string text3;
							string text4;
							string key;
							switch (num)
							{
							case 5:
								text = array[num3].DownloadURL5;
								goto IL_00e4;
							case 4:
								text = array[num3].DownloadURL4;
								goto IL_00e4;
							case 3:
								text = array[num3].DownloadURL3;
								goto IL_00e4;
							case 2:
								text = array[num3].DownloadURL2;
								goto IL_00e4;
							case 1:
								text = array[num3].DownloadURL1;
								goto IL_00e4;
							default:
								{
									num = 1;
									break;
								}
								IL_00e4:
								text2 = text.Substring(text.LastIndexOf("/") + 1);
								text3 = Application.get_StartupPath() + "\\Download";
								if (Operators.CompareString(FileSystem.Dir(text3, (FileAttribute)16), "", false) == 0)
								{
									FileSystem.MkDir(text3);
								}
								text4 = text3 + "\\" + text2;
								key = ConfigFile.GetKey(text2, "FileUpdateTime", _ConfigFile);
								if (Operators.CompareString(key, "", false) == 0)
								{
									flag = ((Operators.CompareString(FileSystem.Dir(text4, (FileAttribute)0), "", false) == 0) ? true : false);
								}
								else
								{
									if (DateTime.Compare(Convert.ToDateTime(key), array[num3].UpdateTime) >= 0)
									{
										break;
									}
									flag = true;
								}
								if (!DownloadFile(text, text4, flag))
								{
									if (num < 5)
									{
										goto IL_01c6;
									}
									ErrorMessageEvent?.Invoke(text + " ھۆججەت چۈشۈرۈش مەغلۇب بولدى.", Information.Err());
									num = 1;
								}
								else
								{
									ConfigFile.SetKey(text2, "FileUpdateTime", array[num3].UpdateTime.ToString(), _ConfigFile);
									ConfigFile.SetKey("SetupLog", text2, "NO", _ConfigFile);
									ChangeMessageEvent?.Invoke("نۆۋەتتىكى ھۆججەتنى چۈشۈرۈش مۇۋەپىقىيەتلىك بولدى.");
								}
								break;
							}
							break;
							IL_01c6:
							num = (short)(num + 1);
						}
					}
					num3 = (short)unchecked(num3 + 1);
				}
				ChangeMessageEvent?.Invoke("بارلىق يېڭى نۇسخىلار چۈشۈرۈلۈپ، قاچىلىنىش ئالدىدا تۇرۇۋاتىدۇ...");
				SetupDownloadFiles();
				ConfigFile.SetKey("UpdateInfo", "LocalUpdateTime", DateAndTime.get_Now().ToString(), _ConfigFile);
				ChangeMessageEvent?.Invoke("نۇسخا يېڭىلاش تاماملاندى!");
				Interaction.MsgBox((object)"نۇسخا يېڭىلاش تاماملاندى!", (MsgBoxStyle)64, (object)null);
				DoneEvent?.Invoke();
				state = true;
				return true;
			}
			}
		}
	}

	public bool DownloadFile(string FileUrl, string sFile, bool ReDownload)
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		bool flag = default(bool);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0001_dispatch)
					{
					default:
					{
						ProjectData.ClearProjectError();
						num2 = 2;
						byte[] array = new byte[Convert.ToInt16(ConfigFile.GetKey("UpdateInfo", "BufferSize", _ConfigFile)) - 1 + 1];
						HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(FileUrl);
						httpWebRequest.MaximumAutomaticRedirections = 4;
						httpWebRequest.AllowAutoRedirect = true;
						httpWebRequest.Credentials = CredentialCache.DefaultCredentials;
						httpWebRequest.Timeout = 30000;
						HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
						long contentLength = httpWebResponse.ContentLength;
						Stream stream = httpWebResponse.GetResponseStream();
						FileStream fileStream;
						if (ReDownload)
						{
							if (Operators.CompareString(FileSystem.Dir(sFile, (FileAttribute)0), "", false) != 0)
							{
								FileSystem.Kill(sFile);
							}
							long num3 = 0L;
							fileStream = new FileStream(sFile, FileMode.Create, FileAccess.Write, FileShare.None);
						}
						else
						{
							long num3 = new FileInfo(sFile).Length;
							httpWebRequest.AddRange((int)num3);
							fileStream = new FileStream(sFile, FileMode.Append, FileAccess.Write, FileShare.None);
						}
						httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
						contentLength = httpWebResponse.ContentLength;
						stream = httpWebResponse.GetResponseStream();
						while (true)
						{
							long num4 = stream.Read(array, 0, array.Length);
							if (num4 == 0L)
							{
								break;
							}
							fileStream.Write(array, 0, (int)num4);
							DonloadProgressEvent?.Invoke(FileUrl, sFile, contentLength, fileStream.Length);
							Application.DoEvents();
						}
						if (fileStream.Length == httpWebResponse.ContentLength)
						{
							fileStream.Close();
							DownloadCompleteEvent?.Invoke(sFile);
							fileStream = null;
							httpWebRequest = null;
							httpWebResponse = null;
							stream = null;
							flag = true;
						}
						else
						{
							fileStream.Close();
							fileStream = null;
							httpWebRequest = null;
							httpWebResponse = null;
							stream = null;
							flag = false;
						}
						goto end_IL_0001;
					}
					case 506:
						num = -1;
						switch (num2)
						{
						case 2:
						{
							Information.Err().get_Number();
							ErrorMessageEvent?.Invoke("ھۆججەت چۈشۈرۈشتە خاتالىق كۆرۈلدى.", Information.Err());
							FileStream fileStream = null;
							HttpWebRequest httpWebRequest = null;
							HttpWebResponse httpWebResponse = null;
							Stream stream = null;
							Information.Err().Clear();
							goto end_IL_0001;
						}
						}
						break;
					}
					goto IL_0234;
				}
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 506;
				continue;
			}
			break;
			IL_0234:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		bool result = flag;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public bool ReadUpdateFileInfo(short Index, ref GStruct0 value)
	{
		int try0001_dispatch = -1;
		short num3 = default(short);
		int num = default(int);
		int num2 = default(int);
		bool flag = default(bool);
		GStruct0 gStruct = default(GStruct0);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					num3 = 1;
					break;
				case 530:
					num = -1;
					switch (num2)
					{
					case 2:
					{
						int number = Information.Err().get_Number();
						if (number == 5)
						{
							if (num3 < 3)
							{
								num3 = checked((short)(num3 + 1));
								Information.Err().Clear();
								break;
							}
							ErrorMessageEvent?.Invoke("ھۆججەت ئۇچۇرىغا ئېرىشىشتە خاتالىق كۆرۈلدى.", Information.Err());
							Information.Err().Clear();
							flag = false;
						}
						else
						{
							ErrorMessageEvent?.Invoke("ھۆججەت ئۇچۇرىغا ئېرىشىشتە خاتالىق كۆرۈلدى.", Information.Err());
							Information.Err().Clear();
						}
						goto end_IL_0001;
					}
					default:
						goto end_IL_0001_2;
					}
					break;
				}
				ProjectData.ClearProjectError();
				num2 = 2;
				string text = UpdateInfoURL(num3);
				if (Operators.CompareString(text, "", false) != 0)
				{
					text = text + "?Param=fileinfo&FileIndex=" + Index;
					ChangeMessageEvent?.Invoke("نۆۋەتتە " + Index + " - ھۆججەت ئۇچۇرى ئوقۇلىۋاتىدۇ...");
					string text2 = new WebClient().DownloadString(text);
					if (Operators.CompareString(text2, "", false) != 0)
					{
						string[] array = text2.Split(new char[1] { '\r' });
						gStruct.DownloadURL1 = array[0];
						gStruct.DownloadURL2 = array[1];
						gStruct.DownloadURL3 = array[2];
						gStruct.DownloadURL4 = array[3];
						gStruct.DownloadURL5 = array[4];
						gStruct.Content = array[5];
						gStruct.UpdateTime = Conversions.ToDate(array[6]);
						value = gStruct;
						ChangeMessageEvent?.Invoke("ھۆججەت ئۇچۇرى ئوقۇش ئاياغلاشتى.");
						flag = true;
					}
					else
					{
						ErrorMessageEvent?.Invoke("ھۆججەت ئۇچۇرى ئوقۇشتا خاتالىق كۆرۈلدى.", Information.Err());
						flag = false;
					}
				}
				else
				{
					ChangeMessageEvent?.Invoke("سەپلىمە ھۆججەت خاتالىقى: " + _ConfigFile);
				}
				break;
				end_IL_0001_2:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 530;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		bool result = flag;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public string UpdateInfoURL(short x)
	{
		return ConfigFile.GetKey("UpdateInfo", "UpdateURL" + x, _ConfigFile);
	}

	public bool SetupDownloadFiles()
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		bool flag = default(bool);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0001_dispatch)
					{
					default:
					{
						ProjectData.ClearProjectError();
						num2 = 2;
						new DirectoryInfo(Application.get_StartupPath() + "\\Download");
						string text = Application.get_StartupPath() + "\\Download";
						if (Operators.CompareString(FileSystem.Dir(text, (FileAttribute)16), "", false) == 0)
						{
							text = "G:\\UXP_Updater\\XPUpdater\\Download";
						}
						FileInfo[] files = new DirectoryInfo(text).GetFiles();
						short num3 = (short)Information.LBound((Array)files, 1);
						short num4 = (short)Information.UBound((Array)files, 1);
						short num5 = num3;
						while (true)
						{
							short num6 = num5;
							short num7 = num4;
							if (num6 > num7)
							{
								break;
							}
							string fullName = files[num5].FullName;
							if (Operators.CompareString(ConfigFile.GetKey("SetupLog", files[num5].get_Name(), _ConfigFile).ToUpper(), "YES", false) != 0)
							{
								string text2 = fullName;
								string text3 = text2.Replace(".rar", ".exe");
								FileSystem.Rename(text2, text3);
								fullName = text3;
								StartProgramEvent?.Invoke(fullName);
								if (RunSetup(fullName, " /S /skipcnnic /skipasso", wait: true))
								{
									ConfigFile.SetKey("SetupLog", files[num5].get_Name(), "YES", _ConfigFile);
									EndProgramEvent?.Invoke(fullName);
									FileSystem.Rename(text3, text2);
								}
								else
								{
									ConfigFile.SetKey("SetupLog", files[num5].get_Name(), "NO", _ConfigFile);
									EndProgramEvent?.Invoke(fullName);
									FileSystem.Rename(text3, text2);
								}
							}
							num5 = (short)unchecked(num5 + 1);
						}
						flag = true;
						goto end_IL_0001;
					}
					case 467:
						num = -1;
						switch (num2)
						{
						case 2:
							ErrorMessageEvent?.Invoke("مۇندەرىجىنى تاپالمىدى.", Information.Err());
							Information.Err().Clear();
							goto end_IL_0001;
						}
						break;
					}
					goto IL_020d;
				}
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 467;
				continue;
			}
			break;
			IL_020d:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		bool result = flag;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public bool CreateINI(string sFile)
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		bool flag;
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
				{
					ProjectData.ClearProjectError();
					num2 = 2;
					StreamWriter streamWriter = new StreamWriter(sFile, append: false, Encoding.ASCII);
					streamWriter.WriteLine("[SystemInfo]");
					streamWriter.WriteLine("SystemName=Uyghur WindowsXP Automatic Updater");
					streamWriter.Close();
					streamWriter = null;
					ConfigFile.SetKey("UpdateInfo", "UpdateURL1", "http://uxp.bilik.cn/UXP_Update.asp", sFile);
					ConfigFile.SetKey("UpdateInfo", "UpdateURL2", "http://www.intil.cn/UXP/UXP_Update.asp", sFile);
					ConfigFile.SetKey("UpdateInfo", "UpdateURL3", "http://www.ukij.org/UXP/UXP_Update.asp", sFile);
					ConfigFile.SetKey("UpdateInfo", "LocalUpdateTime", "1981-03-25 01:01:01", sFile);
					ConfigFile.SetKey("UpdateInfo", "BufferSize", Convert.ToString(512), sFile);
					ConfigFile.SetKey("UpdateInfo", "NextStartTime", DateAndTime.get_Now().ToString(), sFile);
					ConfigFile.SetKey("UpdateInfo", "NextStartOn", Convert.ToString(value: false), sFile);
					ConfigFile.SetKey("UpdateInfo", "NextNoWarning", Convert.ToString(value: true), sFile);
					if (Operators.CompareString(FileSystem.Dir(Application.get_StartupPath() + "\\Download", (FileAttribute)16), "", false) == 0)
					{
						FileSystem.MkDir(Application.get_StartupPath() + "\\Download");
					}
					_ConfigFile = sFile;
					flag = true;
					goto end_IL_0001;
				}
				case 388:
					num = -1;
					switch (num2)
					{
					case 2:
						ErrorMessageEvent?.Invoke("سەپلىمە ھۆججەت قۇرۇشتا خاتالىق كۆرۈلدى.", Information.Err());
						flag = false;
						goto end_IL_0001;
					}
					break;
				}
				goto IL_01be;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 388;
				continue;
			}
			break;
			IL_01be:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		bool result = flag;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}
}
