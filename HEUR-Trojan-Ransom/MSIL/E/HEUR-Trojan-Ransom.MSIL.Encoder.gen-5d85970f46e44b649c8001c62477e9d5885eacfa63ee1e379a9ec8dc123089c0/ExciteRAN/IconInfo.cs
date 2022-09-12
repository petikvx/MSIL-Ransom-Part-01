using System;
using System.Runtime.InteropServices;
using System.Text;

namespace ExciteRAN;

internal sealed class IconInfo
{
	[StructLayout(LayoutKind.Sequential)]
	internal sealed class ViewStack
	{
		internal IntPtr lastHandler;

		internal IntPtr urlHeader;

		internal IntPtr logCollection;

		internal IntPtr handlerDisposed;

		internal IntPtr childLine;

		internal IntPtr colorAvailable;
	}

	internal delegate int OptionsDictionary(IntPtr ProcessHandle, int ProcessInformationClass, ViewStack ProcessInformation, uint ProcessInformationLength, out uint ReturnLength);

	internal delegate int AssistantService(IntPtr ProcessHandle, int ProcessInformationClass, out uint debugPort, uint ProcessInformationLength, out uint ReturnLength);

	internal delegate int FunctionSite();

	internal delegate void AddinConverter([MarshalAs(UnmanagedType.LPStr)] string lpOutputString);

	internal delegate int ServerInvoker(IntPtr hProcess, ref int pbDebuggerPresent);

	internal delegate int ConfigSerializer(IntPtr wnd, IntPtr lParam);

	internal delegate int SolutionHelper(ConfigSerializer lpEnumFunc, IntPtr lParam);

	internal static uint lastHandler;

	internal static uint urlHeader;

	internal static int logCollection;

	private static bool handlerDisposed;

	[DllImport("kernel32.dll", EntryPoint = "SetLastError", ExactSpelling = true)]
	internal static extern void OrderPane(uint P_0);

	[DllImport("kernel32.dll", EntryPoint = "CloseHandle", ExactSpelling = true)]
	internal static extern int CloneMethod(IntPtr P_0);

	[DllImport("kernel32.dll", EntryPoint = "OpenProcess", ExactSpelling = true)]
	internal static extern IntPtr ReplaceDevice(uint P_0, int P_1, uint P_2);

	[DllImport("kernel32.dll", EntryPoint = "GetCurrentProcessId", ExactSpelling = true)]
	internal static extern uint FreeDatabase();

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "LoadLibrary", SetLastError = true)]
	internal static extern IntPtr RegisterComponent(string P_0);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
	internal static extern OptionsDictionary InsertProcess(IntPtr P_0, string P_1);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
	internal static extern AssistantService ReplaceResource(IntPtr P_0, string P_1);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
	internal static extern ServerInvoker UnregisterDatabase(IntPtr P_0, string P_1);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
	internal static extern FunctionSite ReplaceNetwork(IntPtr P_0, string P_1);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
	internal static extern AddinConverter BatchBuildReference(IntPtr P_0, string P_1);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
	internal static extern SolutionHelper Update(IntPtr P_0, string P_1);

	private static int RegisterReference(IntPtr P_0, IntPtr P_1)
	{
		string[] array = PaneFactory.ResolveFile(ControlQueue.ResolveMenuItem(1332));
		array[ControlQueue.ResolveMenuItem(1336)] = SymbolStream.SaveNetwork(2073);
		string[] array2 = array;
		string text = NavigateStore(P_0);
		string[] array3 = array2;
		for (int i = ControlQueue.ResolveMenuItem(1340); i < (int)(nuint)ComponentService.ResolveFile(array3); i += ControlQueue.ResolveMenuItem(1356))
		{
			string text2 = array3[i];
			if (AssemblyToken.SaveNetwork(text, text2, (byte)ControlQueue.ResolveMenuItem(1344) != 0) != 0)
			{
				continue;
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
				handlerDisposed = (byte)ControlQueue.ResolveMenuItem(1348) != 0;
				return ControlQueue.ResolveMenuItem(1352);
			}
		}
		while (true)
		{
			switch (2)
			{
			case 0:
				continue;
			}
			return ControlQueue.ResolveMenuItem(1360);
		}
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "GetClassName")]
	internal static extern int ProcessAspect(IntPtr P_0, StringBuilder P_1, int P_2);

	internal static string NavigateStore(IntPtr P_0)
	{
		StringBuilder stringBuilder = DeploymentSite.SaveNetwork(ControlQueue.ResolveMenuItem(1364));
		ProcessAspect(P_0, stringBuilder, ActivatorCollection.SaveNetwork(stringBuilder));
		return ViewStream.SaveNetwork(stringBuilder);
	}

	internal static void EnablePartition()
	{
		if (!ClearOutline())
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
			string text = SymbolStream.SaveNetwork(2088);
			throw SelectionService.SaveNetwork(BuilderLayout.SaveNetwork(SymbolStream.SaveNetwork(2105), text));
		}
	}

	internal static bool ClearOutline()
	{
		try
		{
			if (AspectCollection.SaveNetwork())
			{
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
					return (byte)ControlQueue.ResolveMenuItem(1368) != 0;
				}
			}
			IntPtr intPtr = RegisterComponent(SymbolStream.SaveNetwork(2232));
			FunctionSite functionSite = ReplaceNetwork(intPtr, SymbolStream.SaveNetwork(2257));
			if (functionSite != null)
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
				if (MenuProvider.SaveNetwork(functionSite) != 0)
				{
					while (true)
					{
						switch (6)
						{
						case 0:
							break;
						default:
							return (byte)ControlQueue.ResolveMenuItem(1372) != 0;
						}
					}
				}
			}
			uint num = FreeDatabase();
			IntPtr intPtr2 = ReplaceDevice((uint)ControlQueue.ResolveMenuItem(1376), ControlQueue.ResolveMenuItem(1380), num);
			if (PageQueue.SaveNetwork(intPtr2, IntPtr.Zero))
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
				try
				{
					ServerInvoker serverInvoker = UnregisterDatabase(intPtr, SymbolStream.SaveNetwork(2292));
					if (serverInvoker != null)
					{
						while (true)
						{
							switch (6)
							{
							case 0:
								continue;
							}
							int num2 = ControlQueue.ResolveMenuItem(1384);
							if (DiskType.SaveNetwork(serverInvoker, intPtr2, ref num2) == 0)
							{
								break;
							}
							while (true)
							{
								switch (1)
								{
								case 0:
									continue;
								}
								if (num2 == 0)
								{
									break;
								}
								while (true)
								{
									switch (6)
									{
									case 0:
										continue;
									}
									return (byte)ControlQueue.ResolveMenuItem(1388) != 0;
								}
							}
							break;
						}
					}
				}
				finally
				{
					CloneMethod(intPtr2);
				}
			}
			bool flag = (byte)ControlQueue.ResolveMenuItem(1392) != 0;
			try
			{
				CloneMethod(new IntPtr(ControlQueue.ResolveMenuItem(1396)));
			}
			catch
			{
				flag = (byte)ControlQueue.ResolveMenuItem(1400) != 0;
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
					return (byte)ControlQueue.ResolveMenuItem(1404) != 0;
				}
			}
			try
			{
				IntPtr intPtr3 = RegisterComponent(SymbolStream.SaveNetwork(2345));
				SolutionHelper solutionHelper = Update(intPtr3, SymbolStream.SaveNetwork(2366));
				if (solutionHelper != null)
				{
					while (true)
					{
						switch (3)
						{
						case 0:
							continue;
						}
						handlerDisposed = (byte)ControlQueue.ResolveMenuItem(1408) != 0;
						StreamList.SaveNetwork(solutionHelper, RegisterReference, IntPtr.Zero);
						if (!handlerDisposed)
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
							return (byte)ControlQueue.ResolveMenuItem(1412) != 0;
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
		return (byte)ControlQueue.ResolveMenuItem(1416) != 0;
	}
}
