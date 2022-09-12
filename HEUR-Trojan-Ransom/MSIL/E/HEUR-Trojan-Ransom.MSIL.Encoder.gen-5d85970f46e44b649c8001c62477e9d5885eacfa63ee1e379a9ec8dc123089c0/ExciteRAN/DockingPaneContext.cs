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

public sealed class DockingPaneContext : Form
{
	public sealed class StubService
	{
		public static void ResolveFile(string P_0)
		{
			IEnumerable<string> source = SolutionInvoker.SaveNetwork(ServerEventArgs.SaveNetwork(P_0, SymbolStream.SaveNetwork(1235)));
			Func<string, bool> func = _003C_003Ec.urlHeader;
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
				func = (_003C_003Ec.urlHeader = (string P_0) => ((uint)ToolbarType.SaveNetwork(ImageResolver.SaveNetwork(P_0)) & (uint)ControlQueue.ResolveMenuItem(1324)) == (uint)ControlQueue.ResolveMenuItem(1328));
			}
			string[] array = source.Where(func).ToArray();
			string[] array2 = array;
			for (int i = ControlQueue.ResolveMenuItem(1208); i < (int)(nuint)ComponentService.ResolveFile(array2); i += ControlQueue.ResolveMenuItem(1212))
			{
				string text = array2[i];
				ConnectionTable.SaveNetwork(text);
			}
			while (true)
			{
				switch (4)
				{
				case 0:
					break;
				default:
					return;
				}
			}
		}

		public static string SaveNetwork()
		{
			string text = PackageTable.SaveNetwork(ServerEventArgs.SaveNetwork(VectorAttribute.SaveNetwork((Environment.SpecialFolder)ControlQueue.ResolveMenuItem(1216)), SymbolStream.SaveNetwork(419)));
			char c = Method.ChangeEditor(text, ControlQueue.ResolveMenuItem(1220));
			MD5 mD = VectorFactory.SaveNetwork();
			try
			{
				byte[] array = FormToken.SaveNetwork(mD, EmulatorContext.SaveNetwork(StoreQueue.SaveNetwork(), text));
				StringBuilder stringBuilder = PartitionDesigner.SaveNetwork();
				for (int i = ControlQueue.ResolveMenuItem(1224); i < (int)(nuint)ReferenceSerializer.ResolveFile(array); i += ControlQueue.ResolveMenuItem(1228))
				{
					EditorFactory.SaveNetwork(stringBuilder, FileDesigner.SaveNetwork(ref array[i], SymbolStream.SaveNetwork(2055)));
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
					ContextStack.SaveNetwork(stringBuilder, (char)ControlQueue.ResolveMenuItem(1232), c);
					MD5 mD2 = VectorFactory.SaveNetwork();
					try
					{
						byte[] array2 = FormToken.SaveNetwork(mD2, EmulatorContext.SaveNetwork(StoreQueue.SaveNetwork(), ViewStream.SaveNetwork(stringBuilder)));
						StringBuilder stringBuilder2 = PartitionDesigner.SaveNetwork();
						for (int j = ControlQueue.ResolveMenuItem(1236); j < (int)(nuint)ReferenceSerializer.ResolveFile(array2); j += ControlQueue.ResolveMenuItem(1240))
						{
							EditorFactory.SaveNetwork(stringBuilder2, FileDesigner.SaveNetwork(ref array2[j], SymbolStream.SaveNetwork(2055)));
						}
						while (true)
						{
							switch (7)
							{
							case 0:
								continue;
							}
							return ViewStream.SaveNetwork(stringBuilder2);
						}
					}
					finally
					{
						if (mD2 != null)
						{
							while (true)
							{
								switch (4)
								{
								case 0:
									continue;
								}
								ImageInfo.SaveNetwork(mD2);
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
						switch (5)
						{
						case 0:
							continue;
						}
						ImageInfo.SaveNetwork(mD);
						break;
					}
				}
			}
		}
	}

	public sealed class AspectScope
	{
		public static byte[] ResolveFile(byte[] P_0, byte[] P_1)
		{
			byte[] result = WindowEventArgs.lastHandler;
			byte[] array = MemoryHelper.ResolveFile(ControlQueue.ResolveMenuItem(1244));
			ConnectionStack.SaveNetwork(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			byte[] array2 = array;
			MemoryStream memoryStream = MenuItemType.SaveNetwork();
			try
			{
				RijndaelManaged rijndaelManaged = ContextCollection.SaveNetwork();
				try
				{
					AspectFactory.SaveNetwork(rijndaelManaged, ControlQueue.ResolveMenuItem(1248));
					OptionsLoader.SaveNetwork(rijndaelManaged, ControlQueue.ResolveMenuItem(1252));
					Rfc2898DeriveBytes rfc2898DeriveBytes = MethodDictionary.SaveNetwork(P_1, array2, ControlQueue.ResolveMenuItem(1256));
					ViewLoader.SaveNetwork(rijndaelManaged, DatabaseFactory.SaveNetwork(rfc2898DeriveBytes, DeploymentEventArgs.SaveNetwork(rijndaelManaged) / ControlQueue.ResolveMenuItem(1260)));
					ContextToken.SaveNetwork(rijndaelManaged, DatabaseFactory.SaveNetwork(rfc2898DeriveBytes, StubContext.SaveNetwork(rijndaelManaged) / ControlQueue.ResolveMenuItem(1264)));
					DiskAttribute.SaveNetwork(rijndaelManaged, (CipherMode)ControlQueue.ResolveMenuItem(1268));
					CryptoStream cryptoStream = OutlineProvider.SaveNetwork(memoryStream, VectorHelper.SaveNetwork(rijndaelManaged), (CryptoStreamMode)ControlQueue.ResolveMenuItem(1272));
					try
					{
						QueueScope.SaveNetwork(cryptoStream, P_0, ControlQueue.ResolveMenuItem(1276), (int)(nuint)ReferenceSerializer.ResolveFile(P_0));
						QueueDictionary.SaveNetwork(cryptoStream);
					}
					finally
					{
						if (cryptoStream != null)
						{
							while (true)
							{
								switch (7)
								{
								case 0:
									continue;
								}
								if (1 == 0)
								{
									/*OpCode not supported: LdMemberToken*/;
								}
								ImageInfo.SaveNetwork(cryptoStream);
								break;
							}
						}
					}
					result = QueueConverter.SaveNetwork(memoryStream);
				}
				finally
				{
					if (rijndaelManaged != null)
					{
						while (true)
						{
							switch (1)
							{
							case 0:
								continue;
							}
							ImageInfo.SaveNetwork(rijndaelManaged);
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
						switch (6)
						{
						case 0:
							continue;
						}
						ImageInfo.SaveNetwork(memoryStream);
						break;
					}
				}
			}
			return result;
		}
	}

	public sealed class BitmapResolver
	{
		public static byte[] ResolveFile(byte[] P_0, byte[] P_1)
		{
			byte[] result = WindowEventArgs.lastHandler;
			byte[] array = MemoryHelper.ResolveFile(ControlQueue.ResolveMenuItem(1280));
			ConnectionStack.SaveNetwork(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			byte[] array2 = array;
			MemoryStream memoryStream = MenuItemType.SaveNetwork();
			try
			{
				RijndaelManaged rijndaelManaged = ContextCollection.SaveNetwork();
				try
				{
					AspectFactory.SaveNetwork(rijndaelManaged, ControlQueue.ResolveMenuItem(1284));
					OptionsLoader.SaveNetwork(rijndaelManaged, ControlQueue.ResolveMenuItem(1288));
					Rfc2898DeriveBytes rfc2898DeriveBytes = MethodDictionary.SaveNetwork(P_1, array2, ControlQueue.ResolveMenuItem(1292));
					ViewLoader.SaveNetwork(rijndaelManaged, DatabaseFactory.SaveNetwork(rfc2898DeriveBytes, DeploymentEventArgs.SaveNetwork(rijndaelManaged) / ControlQueue.ResolveMenuItem(1296)));
					ContextToken.SaveNetwork(rijndaelManaged, DatabaseFactory.SaveNetwork(rfc2898DeriveBytes, StubContext.SaveNetwork(rijndaelManaged) / ControlQueue.ResolveMenuItem(1300)));
					DiskAttribute.SaveNetwork(rijndaelManaged, (CipherMode)ControlQueue.ResolveMenuItem(1304));
					CryptoStream cryptoStream = OutlineProvider.SaveNetwork(memoryStream, ProjectTable.SaveNetwork(rijndaelManaged), (CryptoStreamMode)ControlQueue.ResolveMenuItem(1308));
					try
					{
						QueueScope.SaveNetwork(cryptoStream, P_0, ControlQueue.ResolveMenuItem(1312), (int)(nuint)ReferenceSerializer.ResolveFile(P_0));
						QueueDictionary.SaveNetwork(cryptoStream);
					}
					finally
					{
						if (cryptoStream != null)
						{
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
								ImageInfo.SaveNetwork(cryptoStream);
								break;
							}
						}
					}
					result = QueueConverter.SaveNetwork(memoryStream);
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
							ImageInfo.SaveNetwork(rijndaelManaged);
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
						switch (3)
						{
						case 0:
							continue;
						}
						ImageInfo.SaveNetwork(memoryStream);
						break;
					}
				}
			}
			return result;
		}
	}

	public sealed class ReferenceStream
	{
		public void ResolveFile(string P_0, string P_1)
		{
			try
			{
				byte[] array = ToolbarTree.SaveNetwork(P_0);
				byte[] array2 = EmulatorContext.SaveNetwork(StoreQueue.SaveNetwork(), P_1);
				array2 = FormToken.SaveNetwork(PcitureLayout.SaveNetwork(), array2);
				byte[] array3 = AspectScope.ResolveFile(array, array2);
				ControlOptions.SaveNetwork(P_0, array3);
			}
			catch (Exception)
			{
			}
		}
	}

	public sealed class MenuList
	{
		public void ResolveFile(string P_0, string P_1)
		{
			try
			{
				byte[] array = ToolbarTree.SaveNetwork(P_0);
				byte[] array2 = EmulatorContext.SaveNetwork(StoreQueue.SaveNetwork(), P_1);
				array2 = FormToken.SaveNetwork(PcitureLayout.SaveNetwork(), array2);
				byte[] array3 = BitmapResolver.ResolveFile(array, array2);
				ControlOptions.SaveNetwork(P_0, array3);
			}
			catch (Exception)
			{
			}
		}
	}

	[CompilerGenerated]
	private sealed class QueueList
	{
		public DockingPaneContext lastHandler;

		public DateTime urlHeader;

		internal void ResolveMenuItem(object P_0, EventArgs P_1)
		{
			Label rootVersion = lastHandler.rootVersion;
			TimeSpan timeSpan = ProcessInfo.SaveNetwork(ActionType.SaveNetwork(ControlQueue.CloneMethod(1316)), TemplateQueue.SaveNetwork(Addin.SaveNetwork(), urlHeader));
			PartitionService.SaveNetwork(rootVersion, PageManager.SaveNetwork(ref timeSpan, SymbolStream.SaveNetwork(2060)));
		}
	}

	private static string lastHandler = ContextResolver.SaveNetwork();

	private static string urlHeader = MenuItemOptions.SaveNetwork(SymbolStream.SaveNetwork(1958), lastHandler, SymbolStream.SaveNetwork(1977));

	private static string logCollection = MenuItemOptions.SaveNetwork(SymbolStream.SaveNetwork(1958), lastHandler, SymbolStream.SaveNetwork(1994));

	private static string handlerDisposed = MenuItemOptions.SaveNetwork(SymbolStream.SaveNetwork(1958), lastHandler, SymbolStream.SaveNetwork(2015));

	private static string childLine = MenuItemOptions.SaveNetwork(SymbolStream.SaveNetwork(1958), lastHandler, SymbolStream.SaveNetwork(2034));

	private ReferenceList colorAvailable = new ReferenceList();

	private static int managerHeader;

	private static int activeSyncObject;

	private IContainer propStoreToken = LineStream.lastHandler;

	private Label nodeHeader;

	private Label lastReason;

	private Timer currentFilter;

	private Timer wrapperInstance;

	private Timer parentLine;

	private Timer timerDisposed;

	private Timer propStoreList;

	private PictureBox queryInitialized;

	private Label rootVersion;

	private Label urlInstance;

	private Label lineInstance;

	private Label managerCache;

	private Label wrapperEnabled;

	private Label dataMap;

	private Label namesSet;

	private Button valuesList;

	private TextBox childOutput;

	private Button containerCollection;

	private LinkLabel nameAvailable;

	private LinkLabel dataLength;

	public DockingPaneContext()
	{
		ReduceStore();
		PartitionService.SaveNetwork(rootVersion, ActionType.SaveNetwork(ControlQueue.CloneMethod(1196)).ToString());
	}

	[DllImport("User32", EntryPoint = "ShowWindow")]
	private static extern int UpdateGroup(int P_0, int P_1);

	[DllImport("user32.dll", EntryPoint = "BlockInput")]
	private static extern bool DeployEditor(bool P_0);

	private void ViewOutline(int P_0)
	{
		Random random = TreeNodeQueue.SaveNetwork();
		char[] array = StreamConverter.ResolveFile(P_0);
		for (int i = ControlQueue.ResolveMenuItem(168); i < P_0; i += ControlQueue.ResolveMenuItem(172))
		{
			array[i] = Method.ResolveMenuItem(SymbolStream.SaveNetwork(348), FunctionSettings.SaveNetwork(random, SolutionAttribute.SaveNetwork(SymbolStream.SaveNetwork(348))));
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
			StreamWriter streamWriter = SolutionContext.SaveNetwork(ServerEventArgs.SaveNetwork(VectorAttribute.SaveNetwork((Environment.SpecialFolder)ControlQueue.ResolveMenuItem(176)), SymbolStream.SaveNetwork(419)), (byte)ControlQueue.ResolveMenuItem(180) != 0);
			try
			{
				TextFileDictionary.SaveNetwork(streamWriter, array);
				return;
			}
			finally
			{
				if (streamWriter != null)
				{
					while (true)
					{
						switch (1)
						{
						case 0:
							continue;
						}
						ImageInfo.SaveNetwork(streamWriter);
						break;
					}
				}
			}
		}
	}

	private void InsertDirectory(object P_0, FormClosingEventArgs P_1)
	{
		BuilderLoader.SaveNetwork(P_1, (byte)ControlQueue.ResolveMenuItem(184) != 0);
	}

	private void ListPane(object P_0, EventArgs P_1)
	{
		IconStream.SaveNetwork(this, ControlQueue.CloneMethod(188));
		QueueInvoker.SaveNetwork(this, (byte)ControlQueue.ResolveMenuItem(196) != 0);
		FileLayout.SaveNetwork(this, (byte)ControlQueue.ResolveMenuItem(200) != 0);
		ViewOutline(ControlQueue.ResolveMenuItem(204));
		SortMenu();
		LineTree.SaveNetwork(colorAvailable);
		RegistryKey registryKey = ToolboxStream.SaveNetwork(Registry.CurrentUser, SymbolStream.SaveNetwork(462));
		MenuItemManager.SaveNetwork(registryKey, SymbolStream.SaveNetwork(577), ControlQueue.ResolveMenuItem(208), (RegistryValueKind)ControlQueue.ResolveMenuItem(212));
		RegistryKey registryKey2 = ToolboxStream.SaveNetwork(Registry.CurrentUser, SymbolStream.SaveNetwork(606));
		MenuItemManager.SaveNetwork(registryKey2, SymbolStream.SaveNetwork(649), "", (RegistryValueKind)ControlQueue.ResolveMenuItem(216));
		RegistryKey registryKey3 = ToolboxStream.SaveNetwork(Registry.LocalMachine, SymbolStream.SaveNetwork(668));
		MenuItemManager.SaveNetwork(registryKey3, SymbolStream.SaveNetwork(775), SymbolStream.SaveNetwork(786), (RegistryValueKind)ControlQueue.ResolveMenuItem(220));
		StubService.ResolveFile(DockingPaneContext.urlHeader);
		StubService.ResolveFile(childLine);
		StubService.ResolveFile(logCollection);
		DateTime urlHeader = Addin.SaveNetwork();
		Timer obj = DiskOptions.SaveNetwork();
		DeviceSite.SaveNetwork(obj, ControlQueue.ResolveMenuItem(224));
		Timer val = obj;
		FileInfo.SaveNetwork(val, delegate
		{
			Label obj2 = rootVersion;
			TimeSpan timeSpan = ProcessInfo.SaveNetwork(ActionType.SaveNetwork(ControlQueue.CloneMethod(1316)), TemplateQueue.SaveNetwork(Addin.SaveNetwork(), urlHeader));
			PartitionService.SaveNetwork(obj2, PageManager.SaveNetwork(ref timeSpan, SymbolStream.SaveNetwork(2060)));
		});
		ToolboxCollection.SaveNetwork(val, (byte)ControlQueue.ResolveMenuItem(228) != 0);
		SymbolToken.SaveNetwork(currentFilter);
		SymbolToken.SaveNetwork(wrapperInstance);
		SymbolToken.SaveNetwork(parentLine);
		SymbolToken.SaveNetwork(timerDisposed);
		SymbolToken.SaveNetwork(propStoreList);
	}

	private void SortTemplate(object P_0, EventArgs P_1)
	{
		ResourceQueue.SaveNetwork(colorAvailable);
		DialogTree.ResolveMenuItem(colorAvailable);
		DockingPaneLoader.SaveNetwork(currentFilter);
		IconStream.SaveNetwork(this, ControlQueue.CloneMethod(232));
		QueueInvoker.SaveNetwork(this, (byte)ControlQueue.ResolveMenuItem(240) != 0);
		ContextInfo.SaveNetwork(this, new Size(ControlQueue.ResolveMenuItem(244), ControlQueue.ResolveMenuItem(248)));
		AssistantFactory.SaveNetwork(this, (FormStartPosition)ControlQueue.ResolveMenuItem(252));
		IncreaseStore();
	}

	private void DisableAddin(object P_0, EventArgs P_1)
	{
		DockingPaneLoader.SaveNetwork(wrapperInstance);
		string text = VectorAttribute.SaveNetwork((Environment.SpecialFolder)ControlQueue.ResolveMenuItem(256));
		string text2 = ServerEventArgs.SaveNetwork(text, SymbolStream.SaveNetwork(797));
		ConnectionTable.SaveNetwork(text2);
		string text3 = PcitureDictionary.SaveNetwork(SymbolStream.SaveNetwork(822));
		string text4 = MethodLoader.SaveNetwork(text3, SymbolStream.SaveNetwork(845));
		string text5 = ServerEventArgs.SaveNetwork(text4, SymbolStream.SaveNetwork(797));
		ConnectionTable.SaveNetwork(text5);
	}

	private void ExtractReference(object P_0, EventArgs P_1)
	{
		DockingPaneLoader.SaveNetwork(parentLine);
		Process[] array = ConditionEventArgs.SaveNetwork();
		Process[] array2 = array;
		for (int i = ControlQueue.ResolveMenuItem(260); i < (int)(nuint)ComponentOptions.ResolveFile(array2); i += ControlQueue.ResolveMenuItem(280))
		{
			Process process = array2[i];
			IntPtr intPtr;
			int num;
			if (XmlFileInvoker.SaveNetwork(ProcessFactory.SaveNetwork(process), SymbolStream.SaveNetwork(864)))
			{
				while (true)
				{
					switch (3)
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
				intPtr = ResourceLayout.SaveNetwork(process);
				num = FormDesigner.SaveNetwork(ref intPtr);
				UpdateGroup(num, ControlQueue.ResolveMenuItem(264));
			}
			if (XmlFileInvoker.SaveNetwork(ProcessFactory.SaveNetwork(process), SymbolStream.SaveNetwork(871)))
			{
				while (true)
				{
					switch (2)
					{
					case 0:
						continue;
					}
					break;
				}
				intPtr = ResourceLayout.SaveNetwork(process);
				num = FormDesigner.SaveNetwork(ref intPtr);
				UpdateGroup(num, ControlQueue.ResolveMenuItem(268));
			}
			if (XmlFileInvoker.SaveNetwork(ProcessFactory.SaveNetwork(process), SymbolStream.SaveNetwork(886)))
			{
				while (true)
				{
					switch (4)
					{
					case 0:
						continue;
					}
					break;
				}
				intPtr = ResourceLayout.SaveNetwork(process);
				num = FormDesigner.SaveNetwork(ref intPtr);
				UpdateGroup(num, ControlQueue.ResolveMenuItem(272));
			}
			if (!XmlFileInvoker.SaveNetwork(ProcessFactory.SaveNetwork(process), SymbolStream.SaveNetwork(913)))
			{
				continue;
			}
			while (true)
			{
				switch (2)
				{
				case 0:
					continue;
				}
				break;
			}
			intPtr = ResourceLayout.SaveNetwork(process);
			num = FormDesigner.SaveNetwork(ref intPtr);
			UpdateGroup(num, ControlQueue.ResolveMenuItem(276));
		}
		while (true)
		{
			switch (3)
			{
			case 0:
				continue;
			}
			SymbolToken.SaveNetwork(parentLine);
			return;
		}
	}

	private void HideStub(object P_0, EventArgs P_1)
	{
		DockingPaneLoader.SaveNetwork(timerDisposed);
		DisposePciture();
	}

	private void SelectTextFile(object P_0, EventArgs P_1)
	{
		DockingPaneLoader.SaveNetwork(propStoreList);
		Process[] array = DatabaseToken.lastHandler;
		array = VectorProvider.SaveNetwork(SymbolStream.SaveNetwork(924));
		Process[] array2 = array;
		for (int i = ControlQueue.ResolveMenuItem(284); i < (int)(nuint)ComponentOptions.ResolveFile(array2); i += ControlQueue.ResolveMenuItem(288))
		{
			Process process = array2[i];
			ControlProvider.SaveNetwork(SymbolStream.SaveNetwork(943), SymbolStream.SaveNetwork(960));
			MethodList.SaveNetwork(process);
		}
		while (true)
		{
			switch (5)
			{
			case 0:
				continue;
			}
			if (1 == 0)
			{
				/*OpCode not supported: LdMemberToken*/;
			}
			DialogTree.ChangeEditor(this);
			return;
		}
	}

	private void ShowConfig(object P_0, EventArgs P_1)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		if (XmlFileInvoker.SaveNetwork(DeploymentSettings.SaveNetwork(childOutput), ""))
		{
			while (true)
			{
				switch (3)
				{
				case 0:
					break;
				default:
					if (1 == 0)
					{
						/*OpCode not supported: LdMemberToken*/;
					}
					AddinTable.SaveNetwork(SymbolStream.SaveNetwork(975), SymbolStream.SaveNetwork(1002), (MessageBoxButtons)ControlQueue.ResolveMenuItem(292), (MessageBoxIcon)ControlQueue.ResolveMenuItem(296));
					return;
				}
			}
		}
		if (XmlFileInvoker.SaveNetwork(DeploymentSettings.SaveNetwork(childOutput), StubService.SaveNetwork()))
		{
			while (true)
			{
				switch (5)
				{
				case 0:
					break;
				default:
				{
					AddinTable.SaveNetwork(SymbolStream.SaveNetwork(1021), SymbolStream.SaveNetwork(1058), (MessageBoxButtons)ControlQueue.ResolveMenuItem(300), (MessageBoxIcon)ControlQueue.ResolveMenuItem(304));
					RegistryKey registryKey = ToolboxStream.SaveNetwork(Registry.CurrentUser, SymbolStream.SaveNetwork(462));
					MenuItemManager.SaveNetwork(registryKey, SymbolStream.SaveNetwork(577), "", (RegistryValueKind)ControlQueue.ResolveMenuItem(308));
					RegistryKey registryKey2 = ToolboxStream.SaveNetwork(Registry.LocalMachine, SymbolStream.SaveNetwork(668));
					MenuItemManager.SaveNetwork(registryKey2, SymbolStream.SaveNetwork(775), SymbolStream.SaveNetwork(1075), (RegistryValueKind)ControlQueue.ResolveMenuItem(312));
					FormatQueue();
					Process[] array = DatabaseToken.lastHandler;
					array = VectorProvider.SaveNetwork(SymbolStream.SaveNetwork(924));
					Process[] array2 = array;
					for (int i = ControlQueue.ResolveMenuItem(316); i < (int)(nuint)ComponentOptions.ResolveFile(array2); i += ControlQueue.ResolveMenuItem(320))
					{
						Process process = array2[i];
						MethodList.SaveNetwork(process);
					}
					while (true)
					{
						switch (7)
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
		AddinTable.SaveNetwork(SymbolStream.SaveNetwork(975), SymbolStream.SaveNetwork(1002), (MessageBoxButtons)ControlQueue.ResolveMenuItem(324), (MessageBoxIcon)ControlQueue.ResolveMenuItem(328));
	}

	public static void SortMenu()
	{
		DeployEditor((byte)ControlQueue.ResolveMenuItem(332) != 0);
	}

	public static void IncreaseStore()
	{
		DeployEditor((byte)ControlQueue.ResolveMenuItem(336) != 0);
	}

	private void AttachToolbar(object P_0, EventArgs P_1)
	{
		ServerStack.SaveNetwork(DeploymentSettings.SaveNetwork(urlInstance));
	}

	private void CloseSymbol(object P_0, LinkLabelLinkClickedEventArgs P_1)
	{
		ResourceSerializer.SaveNetwork(SymbolStream.SaveNetwork(1100));
	}

	private void ProcessDevice(object P_0, LinkLabelLinkClickedEventArgs P_1)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		AddinTable.SaveNetwork(SymbolStream.SaveNetwork(1183), SymbolStream.SaveNetwork(1220), (MessageBoxButtons)ControlQueue.ResolveMenuItem(340), (MessageBoxIcon)ControlQueue.ResolveMenuItem(344));
		ServerStack.SaveNetwork(PackageTable.SaveNetwork(ServerEventArgs.SaveNetwork(VectorAttribute.SaveNetwork((Environment.SpecialFolder)ControlQueue.ResolveMenuItem(348)), SymbolStream.SaveNetwork(419))));
	}

	private static void DisposePciture()
	{
		string text = urlHeader;
		string text2 = childLine;
		string text3 = logCollection;
		string[] array = ConnectionFactory.SaveNetwork(ServerEventArgs.SaveNetwork(text, SymbolStream.SaveNetwork(1235)), SymbolStream.SaveNetwork(1238), (SearchOption)ControlQueue.ResolveMenuItem(352));
		string[] array2 = ConnectionFactory.SaveNetwork(ServerEventArgs.SaveNetwork(text2, SymbolStream.SaveNetwork(1235)), SymbolStream.SaveNetwork(1238), (SearchOption)ControlQueue.ResolveMenuItem(356));
		ReferenceStream referenceStream = new ReferenceStream();
		string text4 = StubService.SaveNetwork();
		for (int i = ControlQueue.ResolveMenuItem(360); i < (int)(nuint)ComponentService.ResolveFile(array); i += ControlQueue.ResolveMenuItem(364))
		{
			string text5 = ServerEventArgs.SaveNetwork(array[i], SymbolStream.SaveNetwork(1241));
			ReferenceEditor.SaveNetwork(array[i], text5);
			referenceStream.ResolveFile(text5, text4);
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
			for (int j = ControlQueue.ResolveMenuItem(368); j < (int)(nuint)ComponentService.ResolveFile(array2); j += ControlQueue.ResolveMenuItem(372))
			{
				string text6 = ServerEventArgs.SaveNetwork(array2[j], SymbolStream.SaveNetwork(1241));
				ReferenceEditor.SaveNetwork(array2[j], text6);
				referenceStream.ResolveFile(text6, text4);
			}
			while (true)
			{
				switch (3)
				{
				case 0:
					continue;
				}
				DriveInfo[] array3 = ComponentContext.SaveNetwork();
				for (int k = ControlQueue.ResolveMenuItem(376); k < (int)(nuint)GroupOptions.ResolveFile(array3); k += ControlQueue.ResolveMenuItem(404))
				{
					DriveInfo driveInfo = array3[k];
					int num;
					if (PluginHelper.SaveNetwork(driveInfo) != (DriveType)ControlQueue.ResolveMenuItem(380))
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
						num = ((PluginHelper.SaveNetwork(driveInfo) == (DriveType)ControlQueue.ResolveMenuItem(384)) ? 1 : 0);
					}
					else
					{
						num = ControlQueue.ResolveMenuItem(388);
					}
					if (num == 0)
					{
						continue;
					}
					while (true)
					{
						switch (5)
						{
						case 0:
							continue;
						}
						break;
					}
					if (!ImageStream.SaveNetwork(AssemblySite.SaveNetwork(driveInfo), SymbolStream.SaveNetwork(1256)))
					{
						continue;
					}
					while (true)
					{
						switch (3)
						{
						case 0:
							continue;
						}
						break;
					}
					string[] array4 = ConnectionFactory.SaveNetwork(AssemblySite.SaveNetwork(driveInfo), SymbolStream.SaveNetwork(1238), (SearchOption)ControlQueue.ResolveMenuItem(392));
					for (int l = ControlQueue.ResolveMenuItem(396); l < (int)(nuint)ComponentService.ResolveFile(array4); l += ControlQueue.ResolveMenuItem(400))
					{
						referenceStream.ResolveFile(array4[l], text4);
					}
					while (true)
					{
						switch (4)
						{
						case 0:
							continue;
						}
						break;
					}
				}
				while (true)
				{
					switch (1)
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

	private static void FormatQueue()
	{
		string text = urlHeader;
		string text2 = childLine;
		string[] array = ConnectionFactory.SaveNetwork(ServerEventArgs.SaveNetwork(text, SymbolStream.SaveNetwork(1235)), SymbolStream.SaveNetwork(1238), (SearchOption)ControlQueue.ResolveMenuItem(408));
		string[] array2 = ConnectionFactory.SaveNetwork(ServerEventArgs.SaveNetwork(text2, SymbolStream.SaveNetwork(1235)), SymbolStream.SaveNetwork(1238), (SearchOption)ControlQueue.ResolveMenuItem(412));
		MenuList menuList = new MenuList();
		string text3 = StubService.SaveNetwork();
		for (int i = ControlQueue.ResolveMenuItem(416); i < (int)(nuint)ComponentService.ResolveFile(array); i += ControlQueue.ResolveMenuItem(420))
		{
			menuList.ResolveFile(array[i], text3);
			ReferenceEditor.SaveNetwork(array[i], DiskTable.SaveNetwork(array[i], SymbolStream.SaveNetwork(1241), ""));
		}
		while (true)
		{
			switch (7)
			{
			case 0:
				continue;
			}
			if (1 == 0)
			{
				/*OpCode not supported: LdMemberToken*/;
			}
			for (int j = ControlQueue.ResolveMenuItem(424); j < (int)(nuint)ComponentService.ResolveFile(array2); j += ControlQueue.ResolveMenuItem(428))
			{
				menuList.ResolveFile(array2[j], text3);
				ReferenceEditor.SaveNetwork(array2[j], DiskTable.SaveNetwork(array2[j], SymbolStream.SaveNetwork(1241), ""));
			}
			while (true)
			{
				switch (3)
				{
				case 0:
					continue;
				}
				DriveInfo[] array3 = ComponentContext.SaveNetwork();
				for (int k = ControlQueue.ResolveMenuItem(432); k < (int)(nuint)GroupOptions.ResolveFile(array3); k += ControlQueue.ResolveMenuItem(460))
				{
					DriveInfo driveInfo = array3[k];
					int num;
					if (PluginHelper.SaveNetwork(driveInfo) != (DriveType)ControlQueue.ResolveMenuItem(436))
					{
						while (true)
						{
							switch (3)
							{
							case 0:
								continue;
							}
							break;
						}
						num = ((PluginHelper.SaveNetwork(driveInfo) == (DriveType)ControlQueue.ResolveMenuItem(440)) ? 1 : 0);
					}
					else
					{
						num = ControlQueue.ResolveMenuItem(444);
					}
					if (num == 0)
					{
						continue;
					}
					while (true)
					{
						switch (7)
						{
						case 0:
							continue;
						}
						break;
					}
					if (!ImageStream.SaveNetwork(AssemblySite.SaveNetwork(driveInfo), SymbolStream.SaveNetwork(1256)))
					{
						continue;
					}
					while (true)
					{
						switch (2)
						{
						case 0:
							continue;
						}
						break;
					}
					string[] array4 = ConnectionFactory.SaveNetwork(AssemblySite.SaveNetwork(driveInfo), SymbolStream.SaveNetwork(1238), (SearchOption)ControlQueue.ResolveMenuItem(448));
					for (int l = ControlQueue.ResolveMenuItem(452); l < (int)(nuint)ComponentService.ResolveFile(array4); l += ControlQueue.ResolveMenuItem(456))
					{
						menuList.ResolveFile(array4[l], text3);
					}
					while (true)
					{
						switch (3)
						{
						case 0:
							continue;
						}
						break;
					}
				}
				while (true)
				{
					switch (5)
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

	private void ProcessGroup(object P_0, EventArgs P_1)
	{
	}

	protected override void Dispose(bool disposing)
	{
		int num;
		if (disposing)
		{
			while (true)
			{
				switch (2)
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
			num = ((propStoreToken > LineStream.lastHandler) ? 1 : 0);
		}
		else
		{
			num = ControlQueue.ResolveMenuItem(464);
		}
		if (num != 0)
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
			ImageInfo.SaveNetwork(propStoreToken);
		}
		ProjectDesigner.SaveNetwork(this, disposing);
	}

	private void ReduceStore()
	{
		//IL_1155: Unknown result type (might be due to invalid IL or missing references)
		//IL_115f: Expected O, but got Unknown
		//IL_1284: Unknown result type (might be due to invalid IL or missing references)
		//IL_128e: Expected O, but got Unknown
		//IL_153d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1547: Expected O, but got Unknown
		propStoreToken = PluginSite.SaveNetwork();
		ComponentResourceManager componentResourceManager = DirectoryStream.SaveNetwork(DialogCollection.SaveNetwork(TemplateSet.ResolveFile()));
		nodeHeader = RegistryInvoker.SaveNetwork();
		lastReason = RegistryInvoker.SaveNetwork();
		currentFilter = AssistantSite.SaveNetwork(propStoreToken);
		wrapperInstance = AssistantSite.SaveNetwork(propStoreToken);
		parentLine = AssistantSite.SaveNetwork(propStoreToken);
		timerDisposed = AssistantSite.SaveNetwork(propStoreToken);
		propStoreList = AssistantSite.SaveNetwork(propStoreToken);
		queryInitialized = ClientOptions.SaveNetwork();
		rootVersion = RegistryInvoker.SaveNetwork();
		urlInstance = RegistryInvoker.SaveNetwork();
		lineInstance = RegistryInvoker.SaveNetwork();
		managerCache = RegistryInvoker.SaveNetwork();
		wrapperEnabled = RegistryInvoker.SaveNetwork();
		dataMap = RegistryInvoker.SaveNetwork();
		namesSet = RegistryInvoker.SaveNetwork();
		valuesList = ReferenceConverter.SaveNetwork();
		childOutput = TemplateTable.SaveNetwork();
		containerCollection = ReferenceConverter.SaveNetwork();
		nameAvailable = SelectionToken.SaveNetwork();
		dataLength = SelectionToken.SaveNetwork();
		DialogToken.SaveNetwork(queryInitialized);
		DeviceSettings.SaveNetwork(this);
		DiskResolver.SaveNetwork(nodeHeader, (byte)ControlQueue.ResolveMenuItem(468) != 0);
		ContextProvider.SaveNetwork(nodeHeader, DeploymentManager.SaveNetwork(SymbolStream.SaveNetwork(1263), ControlQueue.OrderPane(472), (FontStyle)ControlQueue.ResolveMenuItem(476), (GraphicsUnit)ControlQueue.ResolveMenuItem(480), (byte)ControlQueue.ResolveMenuItem(484)));
		StubDesigner.SaveNetwork(nodeHeader, ToolbarList.SaveNetwork());
		IconLoader.SaveNetwork(nodeHeader, new Point(ControlQueue.ResolveMenuItem(488), ControlQueue.ResolveMenuItem(492)));
		MenuItemConverter.ChangeEditor(nodeHeader, SymbolStream.SaveNetwork(1288));
		ReferenceInfo.SaveNetwork(nodeHeader, new Size(ControlQueue.ResolveMenuItem(496), ControlQueue.ResolveMenuItem(500)));
		TextFileEditor.SaveNetwork(nodeHeader, ControlQueue.ResolveMenuItem(504));
		DiskResolver.SaveNetwork(lastReason, (byte)ControlQueue.ResolveMenuItem(508) != 0);
		AddinLayout.SaveNetwork(lastReason, ConfigType.SaveNetwork());
		ContextProvider.SaveNetwork(lastReason, DeploymentManager.SaveNetwork(SymbolStream.SaveNetwork(1297), ControlQueue.OrderPane(512), (FontStyle)ControlQueue.ResolveMenuItem(516), (GraphicsUnit)ControlQueue.ResolveMenuItem(520), (byte)ControlQueue.ResolveMenuItem(524)));
		StubDesigner.SaveNetwork(lastReason, ToolbarList.SaveNetwork());
		IconLoader.SaveNetwork(lastReason, new Point(ControlQueue.ResolveMenuItem(528), ControlQueue.ResolveMenuItem(532)));
		MenuItemConverter.ChangeEditor(lastReason, SymbolStream.SaveNetwork(32));
		ReferenceInfo.SaveNetwork(lastReason, new Size(ControlQueue.ResolveMenuItem(536), ControlQueue.ResolveMenuItem(540)));
		TextFileEditor.SaveNetwork(lastReason, ControlQueue.ResolveMenuItem(544));
		SelectionContext.SaveNetwork(lastReason, (ContentAlignment)ControlQueue.ResolveMenuItem(548));
		ToolboxCollection.SaveNetwork(currentFilter, (byte)ControlQueue.ResolveMenuItem(552) != 0);
		DeviceSite.SaveNetwork(currentFilter, ControlQueue.ResolveMenuItem(556));
		FileInfo.SaveNetwork(currentFilter, SortTemplate);
		ToolboxCollection.SaveNetwork(wrapperInstance, (byte)ControlQueue.ResolveMenuItem(560) != 0);
		DeviceSite.SaveNetwork(wrapperInstance, ControlQueue.ResolveMenuItem(564));
		FileInfo.SaveNetwork(wrapperInstance, DisableAddin);
		ToolboxCollection.SaveNetwork(parentLine, (byte)ControlQueue.ResolveMenuItem(568) != 0);
		DeviceSite.SaveNetwork(parentLine, ControlQueue.ResolveMenuItem(572));
		FileInfo.SaveNetwork(parentLine, ExtractReference);
		ToolboxCollection.SaveNetwork(timerDisposed, (byte)ControlQueue.ResolveMenuItem(576) != 0);
		DeviceSite.SaveNetwork(timerDisposed, ControlQueue.ResolveMenuItem(580));
		FileInfo.SaveNetwork(timerDisposed, HideStub);
		ToolboxCollection.SaveNetwork(propStoreList, (byte)ControlQueue.ResolveMenuItem(584) != 0);
		DeviceSite.SaveNetwork(propStoreList, ControlQueue.ResolveMenuItem(588));
		FileInfo.SaveNetwork(propStoreList, SelectTextFile);
		ResourceStack.SaveNetwork(queryInitialized, BuilderResolver.SaveNetwork(ControlQueue.ResolveMenuItem(592), ControlQueue.ResolveMenuItem(596), ControlQueue.ResolveMenuItem(600)));
		AddinLayout.SaveNetwork(queryInitialized, ComponentProvider.SaveNetwork());
		PartitionType.SaveNetwork(queryInitialized, (Image)(object)MemoryInfo.SaveNetwork());
		IconLoader.SaveNetwork(queryInitialized, new Point(ControlQueue.ResolveMenuItem(604), ControlQueue.ResolveMenuItem(608)));
		MenuItemConverter.ChangeEditor(queryInitialized, SymbolStream.SaveNetwork(1338));
		ReferenceInfo.SaveNetwork(queryInitialized, new Size(ControlQueue.ResolveMenuItem(612), ControlQueue.ResolveMenuItem(616)));
		OptionsToken.SaveNetwork(queryInitialized, (PictureBoxSizeMode)ControlQueue.ResolveMenuItem(620));
		RegistryHelper.SaveNetwork(queryInitialized, ControlQueue.ResolveMenuItem(624));
		DeploymentConverter.SaveNetwork(queryInitialized, (byte)ControlQueue.ResolveMenuItem(628) != 0);
		DiskResolver.SaveNetwork(rootVersion, (byte)ControlQueue.ResolveMenuItem(632) != 0);
		ContextProvider.SaveNetwork(rootVersion, AssemblyProvider.SaveNetwork(SymbolStream.SaveNetwork(1361), ControlQueue.OrderPane(636), (FontStyle)ControlQueue.ResolveMenuItem(640)));
		TextFileSite.SaveNetwork(rootVersion, (ContentAlignment)ControlQueue.ResolveMenuItem(644));
		IconLoader.SaveNetwork(rootVersion, new Point(ControlQueue.ResolveMenuItem(648), ControlQueue.ResolveMenuItem(652)));
		MenuItemConverter.ChangeEditor(rootVersion, SymbolStream.SaveNetwork(1404));
		LineDesigner.SaveNetwork(rootVersion, (RightToLeft)ControlQueue.ResolveMenuItem(656));
		ReferenceInfo.SaveNetwork(rootVersion, new Size(ControlQueue.ResolveMenuItem(660), ControlQueue.ResolveMenuItem(664)));
		TextFileEditor.SaveNetwork(rootVersion, ControlQueue.ResolveMenuItem(668));
		PartitionService.SaveNetwork(rootVersion, SymbolStream.SaveNetwork(1415));
		SelectionContext.SaveNetwork(rootVersion, (ContentAlignment)ControlQueue.ResolveMenuItem(672));
		DiskResolver.SaveNetwork(urlInstance, (byte)ControlQueue.ResolveMenuItem(676) != 0);
		ContextProvider.SaveNetwork(urlInstance, DeploymentManager.SaveNetwork(SymbolStream.SaveNetwork(1361), ControlQueue.OrderPane(680), (FontStyle)ControlQueue.ResolveMenuItem(684), (GraphicsUnit)ControlQueue.ResolveMenuItem(688), (byte)ControlQueue.ResolveMenuItem(692)));
		IconLoader.SaveNetwork(urlInstance, new Point(ControlQueue.ResolveMenuItem(696), ControlQueue.ResolveMenuItem(700)));
		MenuItemConverter.ChangeEditor(urlInstance, SymbolStream.SaveNetwork(1426));
		ReferenceInfo.SaveNetwork(urlInstance, new Size(ControlQueue.ResolveMenuItem(704), ControlQueue.ResolveMenuItem(708)));
		TextFileEditor.SaveNetwork(urlInstance, ControlQueue.ResolveMenuItem(712));
		PartitionService.SaveNetwork(urlInstance, SymbolStream.SaveNetwork(1439));
		DiskResolver.SaveNetwork(lineInstance, (byte)ControlQueue.ResolveMenuItem(716) != 0);
		ContextProvider.SaveNetwork(lineInstance, AssemblyProvider.SaveNetwork(SymbolStream.SaveNetwork(1361), ControlQueue.OrderPane(720), (FontStyle)ControlQueue.ResolveMenuItem(724)));
		IconLoader.SaveNetwork(lineInstance, new Point(ControlQueue.ResolveMenuItem(728), ControlQueue.ResolveMenuItem(732)));
		MenuItemConverter.ChangeEditor(lineInstance, SymbolStream.SaveNetwork(1528));
		ReferenceInfo.SaveNetwork(lineInstance, new Size(ControlQueue.ResolveMenuItem(736), ControlQueue.ResolveMenuItem(740)));
		TextFileEditor.SaveNetwork(lineInstance, ControlQueue.ResolveMenuItem(744));
		PartitionService.SaveNetwork(lineInstance, SymbolStream.SaveNetwork(1541));
		DiskResolver.SaveNetwork(managerCache, (byte)ControlQueue.ResolveMenuItem(748) != 0);
		ContextProvider.SaveNetwork(managerCache, AssemblyProvider.SaveNetwork(SymbolStream.SaveNetwork(1361), ControlQueue.OrderPane(752), (FontStyle)ControlQueue.ResolveMenuItem(756)));
		IconLoader.SaveNetwork(managerCache, new Point(ControlQueue.ResolveMenuItem(760), ControlQueue.ResolveMenuItem(764)));
		MenuItemConverter.ChangeEditor(managerCache, SymbolStream.SaveNetwork(1616));
		ReferenceInfo.SaveNetwork(managerCache, new Size(ControlQueue.ResolveMenuItem(768), ControlQueue.ResolveMenuItem(772)));
		TextFileEditor.SaveNetwork(managerCache, ControlQueue.ResolveMenuItem(776));
		PartitionService.SaveNetwork(managerCache, DatabaseLayout.SaveNetwork(componentResourceManager, SymbolStream.SaveNetwork(1629)));
		DiskResolver.SaveNetwork(wrapperEnabled, (byte)ControlQueue.ResolveMenuItem(780) != 0);
		ContextProvider.SaveNetwork(wrapperEnabled, AssemblyProvider.SaveNetwork(SymbolStream.SaveNetwork(1361), ControlQueue.OrderPane(784), (FontStyle)ControlQueue.ResolveMenuItem(788)));
		IconLoader.SaveNetwork(wrapperEnabled, new Point(ControlQueue.ResolveMenuItem(792), ControlQueue.ResolveMenuItem(796)));
		MenuItemConverter.ChangeEditor(wrapperEnabled, SymbolStream.SaveNetwork(1652));
		ReferenceInfo.SaveNetwork(wrapperEnabled, new Size(ControlQueue.ResolveMenuItem(800), ControlQueue.ResolveMenuItem(804)));
		TextFileEditor.SaveNetwork(wrapperEnabled, ControlQueue.ResolveMenuItem(808));
		PartitionService.SaveNetwork(wrapperEnabled, SymbolStream.SaveNetwork(1665));
		DiskResolver.SaveNetwork(dataMap, (byte)ControlQueue.ResolveMenuItem(812) != 0);
		ContextProvider.SaveNetwork(dataMap, DeploymentManager.SaveNetwork(SymbolStream.SaveNetwork(1361), ControlQueue.OrderPane(816), (FontStyle)ControlQueue.ResolveMenuItem(820), (GraphicsUnit)ControlQueue.ResolveMenuItem(824), (byte)ControlQueue.ResolveMenuItem(828)));
		IconLoader.SaveNetwork(dataMap, new Point(ControlQueue.ResolveMenuItem(832), ControlQueue.ResolveMenuItem(836)));
		MenuItemConverter.ChangeEditor(dataMap, SymbolStream.SaveNetwork(90));
		ReferenceInfo.SaveNetwork(dataMap, new Size(ControlQueue.ResolveMenuItem(840), ControlQueue.ResolveMenuItem(844)));
		TextFileEditor.SaveNetwork(dataMap, ControlQueue.ResolveMenuItem(848));
		PartitionService.SaveNetwork(dataMap, DatabaseLayout.SaveNetwork(componentResourceManager, SymbolStream.SaveNetwork(1676)));
		DiskResolver.SaveNetwork(namesSet, (byte)ControlQueue.ResolveMenuItem(852) != 0);
		ContextProvider.SaveNetwork(namesSet, DeploymentManager.SaveNetwork(SymbolStream.SaveNetwork(1361), ControlQueue.OrderPane(856), (FontStyle)ControlQueue.ResolveMenuItem(860), (GraphicsUnit)ControlQueue.ResolveMenuItem(864), (byte)ControlQueue.ResolveMenuItem(868)));
		IconLoader.SaveNetwork(namesSet, new Point(ControlQueue.ResolveMenuItem(872), ControlQueue.ResolveMenuItem(876)));
		MenuItemConverter.ChangeEditor(namesSet, SymbolStream.SaveNetwork(1699));
		ReferenceInfo.SaveNetwork(namesSet, new Size(ControlQueue.ResolveMenuItem(880), ControlQueue.ResolveMenuItem(884)));
		TextFileEditor.SaveNetwork(namesSet, ControlQueue.ResolveMenuItem(888));
		PartitionService.SaveNetwork(namesSet, SymbolStream.SaveNetwork(1712));
		ResourceStack.SaveNetwork(valuesList, BuilderResolver.SaveNetwork(ControlQueue.ResolveMenuItem(892), ControlQueue.ResolveMenuItem(896), ControlQueue.ResolveMenuItem(900)));
		AddinLayout.SaveNetwork(valuesList, VectorService.SaveNetwork());
		ActivityInvoker.SaveNetwork(StubQueue.SaveNetwork(valuesList), ControlQueue.ResolveMenuItem(904));
		ConditionToken.SaveNetwork(valuesList, (FlatStyle)ControlQueue.ResolveMenuItem(908));
		ContextProvider.SaveNetwork(valuesList, AssemblyProvider.SaveNetwork(SymbolStream.SaveNetwork(1361), ControlQueue.OrderPane(912), (FontStyle)ControlQueue.ResolveMenuItem(916)));
		IconLoader.SaveNetwork(valuesList, new Point(ControlQueue.ResolveMenuItem(920), ControlQueue.ResolveMenuItem(924)));
		MenuItemConverter.ChangeEditor(valuesList, SymbolStream.SaveNetwork(1737));
		ReferenceInfo.SaveNetwork(valuesList, new Size(ControlQueue.ResolveMenuItem(928), ControlQueue.ResolveMenuItem(932)));
		TextFileEditor.SaveNetwork(valuesList, ControlQueue.ResolveMenuItem(936));
		PartitionService.SaveNetwork(valuesList, SymbolStream.SaveNetwork(1752));
		PageConverter.SaveNetwork(valuesList, (byte)ControlQueue.ResolveMenuItem(940) != 0);
		MemoryDesigner.SaveNetwork(valuesList, ShowConfig);
		ResourceStack.SaveNetwork(childOutput, BuilderResolver.SaveNetwork(ControlQueue.ResolveMenuItem(944), ControlQueue.ResolveMenuItem(948), ControlQueue.ResolveMenuItem(952)));
		OutlineStream.SaveNetwork(childOutput, (BorderStyle)ControlQueue.ResolveMenuItem(956));
		ContextProvider.SaveNetwork(childOutput, DeploymentManager.SaveNetwork(SymbolStream.SaveNetwork(1771), ControlQueue.OrderPane(960), (FontStyle)ControlQueue.ResolveMenuItem(964), (GraphicsUnit)ControlQueue.ResolveMenuItem(968), (byte)ControlQueue.ResolveMenuItem(972)));
		StubDesigner.SaveNetwork(childOutput, SolutionProvider.SaveNetwork());
		IconLoader.SaveNetwork(childOutput, new Point(ControlQueue.ResolveMenuItem(976), ControlQueue.ResolveMenuItem(980)));
		MenuItemConverter.ChangeEditor(childOutput, SymbolStream.SaveNetwork(1796));
		ReferenceInfo.SaveNetwork(childOutput, new Size(ControlQueue.ResolveMenuItem(984), ControlQueue.ResolveMenuItem(988)));
		TextFileEditor.SaveNetwork(childOutput, ControlQueue.ResolveMenuItem(992));
		ConnectionSerializer.SaveNetwork(childOutput, ProcessGroup);
		ResourceStack.SaveNetwork(containerCollection, BuilderResolver.SaveNetwork(ControlQueue.ResolveMenuItem(996), ControlQueue.ResolveMenuItem(1000), ControlQueue.ResolveMenuItem(1004)));
		AddinLayout.SaveNetwork(containerCollection, VectorService.SaveNetwork());
		ActivityInvoker.SaveNetwork(StubQueue.SaveNetwork(containerCollection), ControlQueue.ResolveMenuItem(1008));
		ConditionToken.SaveNetwork(containerCollection, (FlatStyle)ControlQueue.ResolveMenuItem(1012));
		ContextProvider.SaveNetwork(containerCollection, AssemblyProvider.SaveNetwork(SymbolStream.SaveNetwork(1361), ControlQueue.OrderPane(1016), (FontStyle)ControlQueue.ResolveMenuItem(1020)));
		IconLoader.SaveNetwork(containerCollection, new Point(ControlQueue.ResolveMenuItem(1024), ControlQueue.ResolveMenuItem(1028)));
		MenuItemConverter.ChangeEditor(containerCollection, SymbolStream.SaveNetwork(1819));
		ReferenceInfo.SaveNetwork(containerCollection, new Size(ControlQueue.ResolveMenuItem(1032), ControlQueue.ResolveMenuItem(1036)));
		TextFileEditor.SaveNetwork(containerCollection, ControlQueue.ResolveMenuItem(1040));
		PartitionService.SaveNetwork(containerCollection, SymbolStream.SaveNetwork(1840));
		PageConverter.SaveNetwork(containerCollection, (byte)ControlQueue.ResolveMenuItem(1044) != 0);
		MemoryDesigner.SaveNetwork(containerCollection, AttachToolbar);
		DiskResolver.SaveNetwork(nameAvailable, (byte)ControlQueue.ResolveMenuItem(1048) != 0);
		AddinLayout.SaveNetwork(nameAvailable, GroupContext.SaveNetwork());
		ContextProvider.SaveNetwork(nameAvailable, AssemblyProvider.SaveNetwork(SymbolStream.SaveNetwork(1361), ControlQueue.OrderPane(1052), (FontStyle)ControlQueue.ResolveMenuItem(1056)));
		DatabaseContext.SaveNetwork(nameAvailable, SolutionProvider.SaveNetwork());
		IconLoader.SaveNetwork(nameAvailable, new Point(ControlQueue.ResolveMenuItem(1060), ControlQueue.ResolveMenuItem(1064)));
		MenuItemConverter.ChangeEditor(nameAvailable, SymbolStream.SaveNetwork(1849));
		ReferenceInfo.SaveNetwork(nameAvailable, new Size(ControlQueue.ResolveMenuItem(1068), ControlQueue.ResolveMenuItem(1072)));
		TextFileEditor.SaveNetwork(nameAvailable, ControlQueue.ResolveMenuItem(1076));
		FileStack.SaveNetwork(nameAvailable, (byte)ControlQueue.ResolveMenuItem(1080) != 0);
		PartitionService.SaveNetwork(nameAvailable, SymbolStream.SaveNetwork(1868));
		AspectToken.SaveNetwork(nameAvailable, new LinkLabelLinkClickedEventHandler(CloseSymbol));
		DiskResolver.SaveNetwork(dataLength, (byte)ControlQueue.ResolveMenuItem(1084) != 0);
		AddinLayout.SaveNetwork(dataLength, GroupContext.SaveNetwork());
		ContextProvider.SaveNetwork(dataLength, AssemblyProvider.SaveNetwork(SymbolStream.SaveNetwork(1361), ControlQueue.OrderPane(1088), (FontStyle)ControlQueue.ResolveMenuItem(1092)));
		DatabaseContext.SaveNetwork(dataLength, SolutionProvider.SaveNetwork());
		IconLoader.SaveNetwork(dataLength, new Point(ControlQueue.ResolveMenuItem(1096), ControlQueue.ResolveMenuItem(1100)));
		MenuItemConverter.ChangeEditor(dataLength, SymbolStream.SaveNetwork(1911));
		ReferenceInfo.SaveNetwork(dataLength, new Size(ControlQueue.ResolveMenuItem(1104), ControlQueue.ResolveMenuItem(1108)));
		TextFileEditor.SaveNetwork(dataLength, ControlQueue.ResolveMenuItem(1112));
		FileStack.SaveNetwork(dataLength, (byte)ControlQueue.ResolveMenuItem(1116) != 0);
		PartitionService.SaveNetwork(dataLength, SymbolStream.SaveNetwork(1924));
		AspectToken.SaveNetwork(dataLength, new LinkLabelLinkClickedEventHandler(ProcessDevice));
		FunctionLoader.SaveNetwork(this, new SizeF(ControlQueue.OrderPane(1120), ControlQueue.OrderPane(1124)));
		ProcessTable.SaveNetwork(this, (AutoScaleMode)ControlQueue.ResolveMenuItem(1128));
		ResourceStack.SaveNetwork(this, BuilderResolver.SaveNetwork(ControlQueue.ResolveMenuItem(1132), ControlQueue.ResolveMenuItem(1136), ControlQueue.ResolveMenuItem(1140)));
		ProcessSite.SaveNetwork(this, new Size(ControlQueue.ResolveMenuItem(1144), ControlQueue.ResolveMenuItem(1148)));
		ConnectionDesigner.SaveNetwork(this, (byte)ControlQueue.ResolveMenuItem(1152) != 0);
		SymbolProvider.SaveNetwork(StreamSerializer.SaveNetwork(this), (Control)(object)dataLength);
		SymbolProvider.SaveNetwork(StreamSerializer.SaveNetwork(this), (Control)(object)namesSet);
		SymbolProvider.SaveNetwork(StreamSerializer.SaveNetwork(this), (Control)(object)nameAvailable);
		SymbolProvider.SaveNetwork(StreamSerializer.SaveNetwork(this), (Control)(object)containerCollection);
		SymbolProvider.SaveNetwork(StreamSerializer.SaveNetwork(this), (Control)(object)childOutput);
		SymbolProvider.SaveNetwork(StreamSerializer.SaveNetwork(this), (Control)(object)valuesList);
		SymbolProvider.SaveNetwork(StreamSerializer.SaveNetwork(this), (Control)(object)rootVersion);
		SymbolProvider.SaveNetwork(StreamSerializer.SaveNetwork(this), (Control)(object)urlInstance);
		SymbolProvider.SaveNetwork(StreamSerializer.SaveNetwork(this), (Control)(object)lineInstance);
		SymbolProvider.SaveNetwork(StreamSerializer.SaveNetwork(this), (Control)(object)managerCache);
		SymbolProvider.SaveNetwork(StreamSerializer.SaveNetwork(this), (Control)(object)wrapperEnabled);
		SymbolProvider.SaveNetwork(StreamSerializer.SaveNetwork(this), (Control)(object)dataMap);
		SymbolProvider.SaveNetwork(StreamSerializer.SaveNetwork(this), (Control)(object)queryInitialized);
		SymbolProvider.SaveNetwork(StreamSerializer.SaveNetwork(this), (Control)(object)lastReason);
		SymbolProvider.SaveNetwork(StreamSerializer.SaveNetwork(this), (Control)(object)nodeHeader);
		AddinLayout.SaveNetwork(this, ComponentProvider.SaveNetwork());
		StubDesigner.SaveNetwork(this, BuilderResolver.SaveNetwork(ControlQueue.ResolveMenuItem(1156), ControlQueue.ResolveMenuItem(1160), ControlQueue.ResolveMenuItem(1164)));
		ProjectLoader.SaveNetwork(this, (FormBorderStyle)ControlQueue.ResolveMenuItem(1168));
		TemplateScope.SaveNetwork(this, SolutionTable.ResolveFile(MenuSerializer.SaveNetwork(componentResourceManager, SymbolStream.SaveNetwork(1937))));
		PartitionManager.SaveNetwork(this, (byte)ControlQueue.ResolveMenuItem(1172) != 0);
		ConditionStack.SaveNetwork(this, (byte)ControlQueue.ResolveMenuItem(1176) != 0);
		MenuItemConverter.ResolveMenuItem(this, SymbolStream.SaveNetwork(924));
		FileLayout.SaveNetwork(this, (byte)ControlQueue.ResolveMenuItem(1180) != 0);
		AssistantFactory.SaveNetwork(this, (FormStartPosition)ControlQueue.ResolveMenuItem(1184));
		PartitionService.SaveNetwork(this, SymbolStream.SaveNetwork(924));
		StoreService.SaveNetwork(this, (byte)ControlQueue.ResolveMenuItem(1188) != 0);
		PluginInfo.SaveNetwork(this, new FormClosingEventHandler(InsertDirectory));
		PcitureSettings.SaveNetwork(this, ListPane);
		NetworkConverter.SaveNetwork(queryInitialized);
		DeploymentTree.SaveNetwork(this, (byte)ControlQueue.ResolveMenuItem(1192) != 0);
		ContextScope.SaveNetwork(this);
	}
}
