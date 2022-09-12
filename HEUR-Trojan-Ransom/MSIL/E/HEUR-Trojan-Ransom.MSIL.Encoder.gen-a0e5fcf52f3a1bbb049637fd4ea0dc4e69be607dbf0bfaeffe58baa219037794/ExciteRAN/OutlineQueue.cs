using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace ExciteRAN;

internal class OutlineQueue
{
	[StructLayout(LayoutKind.Sequential)]
	internal class DialogDesigner
	{
		internal IntPtr windowPosition;

		internal IntPtr parentLog;

		internal IntPtr containerToken;

		internal IntPtr lineHandle;

		internal IntPtr currentContainer;

		internal IntPtr parentOptions;
	}

	internal delegate int ImageAttribute(IntPtr ProcessHandle, int ProcessInformationClass, DialogDesigner ProcessInformation, uint ProcessInformationLength, out uint ReturnLength);

	internal delegate int PaneTable(IntPtr ProcessHandle, int ProcessInformationClass, out uint debugPort, uint ProcessInformationLength, out uint ReturnLength);

	internal delegate int AssemblySite();

	internal delegate void OptionsQueue([MarshalAs(UnmanagedType.LPStr)] string lpOutputString);

	internal delegate int ConnectionDictionary(IntPtr hProcess, ref int pbDebuggerPresent);

	internal delegate int VectorList(IntPtr wnd, IntPtr lParam);

	internal delegate int PcitureSettings(VectorList lpEnumFunc, IntPtr lParam);

	internal const uint windowPosition = 1024u;

	internal const uint parentLog = 64u;

	internal const int containerToken = 0;

	private static bool lineHandle;

	[DllImport("kernel32.dll", EntryPoint = "SetLastError", ExactSpelling = true)]
	internal static extern void EnableForm(uint windowPosition);

	[DllImport("kernel32.dll", EntryPoint = "CloseHandle", ExactSpelling = true)]
	internal static extern int ProcessTemplate(IntPtr windowPosition);

	[DllImport("kernel32.dll", EntryPoint = "OpenProcess", ExactSpelling = true)]
	internal static extern IntPtr JoinServer(uint windowPosition, int parentLog, uint containerToken);

	[DllImport("kernel32.dll", EntryPoint = "GetCurrentProcessId", ExactSpelling = true)]
	internal static extern uint OpenOutline();

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "LoadLibrary", SetLastError = true)]
	internal static extern IntPtr ConnectNetwork(string windowPosition);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
	internal static extern ImageAttribute SaveFile(IntPtr windowPosition, string parentLog);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
	internal static extern PaneTable EditDialog(IntPtr windowPosition, string parentLog);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
	internal static extern ConnectionDictionary RebuildWindow(IntPtr windowPosition, string parentLog);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
	internal static extern AssemblySite TestOptions(IntPtr windowPosition, string parentLog);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
	internal static extern OptionsQueue DisconnectDeployment(IntPtr windowPosition, string parentLog);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
	internal static extern PcitureSettings ExitResource(IntPtr windowPosition, string parentLog);

	private static int EditCommand(IntPtr windowPosition, IntPtr parentLog)
	{
		string[] array = VectorSet.CleanAssistant(StoreType.RegisterNode(1108));
		array[StoreType.RegisterNode(1112)] = PluginDictionary.CheckContext(1931);
		string[] array2 = array;
		string strA = UncheckForm(windowPosition);
		string[] array3 = array2;
		for (int i = StoreType.RegisterNode(1116); i < (int)(nuint)GroupSet.CleanAssistant(array3); i += StoreType.RegisterNode(1132))
		{
			string strB = array3[i];
			if (string.Compare(strA, strB, (byte)StoreType.RegisterNode(1120) != 0) != 0)
			{
				continue;
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
				lineHandle = (byte)StoreType.RegisterNode(1124) != 0;
				return StoreType.RegisterNode(1128);
			}
		}
		while (true)
		{
			switch (2)
			{
			case 0:
				continue;
			}
			return StoreType.RegisterNode(1136);
		}
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "GetClassName")]
	internal static extern int SelectEmulator(IntPtr windowPosition, StringBuilder parentLog, int containerToken);

	internal static string UncheckForm(IntPtr windowPosition)
	{
		StringBuilder stringBuilder = new StringBuilder(StoreType.RegisterNode(1140));
		SelectEmulator(windowPosition, stringBuilder, stringBuilder.Capacity);
		return stringBuilder.ToString();
	}

	internal static void ListBuilder()
	{
		if (!AttachOptions())
		{
			return;
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
			string arg = PluginDictionary.CheckContext(1946);
			throw new Exception(string.Format(PluginDictionary.CheckContext(1963), arg));
		}
	}

	internal static bool AttachOptions()
	{
		try
		{
			if (Debugger.IsAttached)
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
					return (byte)StoreType.RegisterNode(1144) != 0;
				}
			}
			IntPtr intPtr = ConnectNetwork(PluginDictionary.CheckContext(2090));
			AssemblySite assemblySite = TestOptions(intPtr, PluginDictionary.CheckContext(2115));
			if (assemblySite != null)
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
				if (assemblySite() != 0)
				{
					while (true)
					{
						switch (5)
						{
						case 0:
							break;
						default:
							return (byte)StoreType.RegisterNode(1148) != 0;
						}
					}
				}
			}
			uint num = OpenOutline();
			IntPtr hProcess = JoinServer((uint)StoreType.RegisterNode(1152), StoreType.RegisterNode(1156), num);
			if (MenuItemSet.CleanAssistant(hProcess, IntPtr.Zero))
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
				try
				{
					ConnectionDictionary connectionDictionary = RebuildWindow(intPtr, PluginDictionary.CheckContext(2150));
					if (connectionDictionary != null)
					{
						while (true)
						{
							switch (1)
							{
							case 0:
								continue;
							}
							int pbDebuggerPresent = StoreType.RegisterNode(1160);
							if (connectionDictionary(hProcess, ref pbDebuggerPresent) == 0)
							{
								break;
							}
							while (true)
							{
								switch (7)
								{
								case 0:
									continue;
								}
								if (pbDebuggerPresent == 0)
								{
									break;
								}
								while (true)
								{
									switch (3)
									{
									case 0:
										continue;
									}
									return (byte)StoreType.RegisterNode(1164) != 0;
								}
							}
							break;
						}
					}
				}
				finally
				{
					ProcessTemplate(hProcess);
				}
			}
			bool flag = (byte)StoreType.RegisterNode(1168) != 0;
			try
			{
				ProcessTemplate(new IntPtr(StoreType.RegisterNode(1172)));
			}
			catch
			{
				flag = (byte)StoreType.RegisterNode(1176) != 0;
			}
			if (flag)
			{
				while (true)
				{
					switch (6)
					{
					case 0:
						continue;
					}
					return (byte)StoreType.RegisterNode(1180) != 0;
				}
			}
			try
			{
				IntPtr intPtr2 = ConnectNetwork(PluginDictionary.CheckContext(2203));
				PcitureSettings pcitureSettings = ExitResource(intPtr2, PluginDictionary.CheckContext(2224));
				if (pcitureSettings != null)
				{
					while (true)
					{
						switch (4)
						{
						case 0:
							continue;
						}
						lineHandle = (byte)StoreType.RegisterNode(1184) != 0;
						pcitureSettings(EditCommand, IntPtr.Zero);
						if (!lineHandle)
						{
							break;
						}
						while (true)
						{
							switch (2)
							{
							case 0:
								continue;
							}
							return (byte)StoreType.RegisterNode(1188) != 0;
						}
					}
				}
			}
			catch
			{
			}
		}
		catch
		{
		}
		return (byte)StoreType.RegisterNode(1192) != 0;
	}
}
