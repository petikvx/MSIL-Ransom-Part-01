using System;
using System.Runtime.InteropServices;
using System.Text;

namespace WindowsLoader;

internal class DiskSerializer
{
	[StructLayout(LayoutKind.Sequential)]
	internal class OptionsTree
	{
		internal IntPtr idEnabled;

		internal IntPtr nextUri;

		internal IntPtr messageSet;

		internal IntPtr parentFont;

		internal IntPtr filterCache;

		internal IntPtr logHeader;
	}

	internal delegate int BitmapList(IntPtr ProcessHandle, int ProcessInformationClass, OptionsTree ProcessInformation, uint ProcessInformationLength, out uint ReturnLength);

	internal delegate int MenuContext(IntPtr ProcessHandle, int ProcessInformationClass, out uint debugPort, uint ProcessInformationLength, out uint ReturnLength);

	internal delegate int ServerConverter();

	internal delegate void CommandToken([MarshalAs(UnmanagedType.LPStr)] string lpOutputString);

	internal delegate int BuilderService(IntPtr hProcess, ref int pbDebuggerPresent);

	internal delegate int Toolbar(IntPtr wnd, IntPtr lParam);

	internal delegate int DatabaseProvider(Toolbar lpEnumFunc, IntPtr lParam);

	internal const uint idEnabled = 1024u;

	internal const uint nextUri = 64u;

	internal const int idEnabled = 0;

	private static bool idEnabled;

	[DllImport("kernel32.dll", EntryPoint = "SetLastError", ExactSpelling = true)]
	internal static extern void RemovePane(uint idEnabled);

	[DllImport("kernel32.dll", EntryPoint = "CloseHandle", ExactSpelling = true)]
	internal static extern int RemovePane(IntPtr idEnabled);

	[DllImport("kernel32.dll", EntryPoint = "OpenProcess", ExactSpelling = true)]
	internal static extern IntPtr Open(uint idEnabled, int nextUri, uint messageSet);

	[DllImport("kernel32.dll", EntryPoint = "GetCurrentProcessId", ExactSpelling = true)]
	internal static extern uint RemovePane();

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "LoadLibrary", SetLastError = true)]
	internal static extern IntPtr RemovePane(string idEnabled);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
	internal static extern BitmapList RemovePane(IntPtr idEnabled, string nextUri);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
	internal static extern MenuContext RemovePane(IntPtr idEnabled, string nextUri);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
	internal static extern BuilderService RemovePane(IntPtr idEnabled, string nextUri);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
	internal static extern ServerConverter RemovePane(IntPtr idEnabled, string nextUri);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
	internal static extern CommandToken RemovePane(IntPtr idEnabled, string nextUri);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
	internal static extern DatabaseProvider RemovePane(IntPtr idEnabled, string nextUri);

	private static int RemovePane(IntPtr idEnabled, IntPtr nextUri)
	{
		string[] array = new string[1] { PackageQueue.RemovePane(304) };
		string text = Open(idEnabled);
		string[] array2 = array;
		foreach (string text2 in array2)
		{
			if (QueueConverter.RemovePane(text, text2, messageSet: true) != 0)
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
				DiskSerializer.idEnabled = true;
				return 0;
			}
		}
		while (true)
		{
			switch (2)
			{
			case 0:
				continue;
			}
			return 1;
		}
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "GetClassName")]
	internal static extern int RemovePane(IntPtr idEnabled, StringBuilder nextUri, int messageSet);

	internal static string Open(IntPtr idEnabled)
	{
		StringBuilder stringBuilder = ActivatorScope.RemovePane(260);
		RemovePane(idEnabled, stringBuilder, DatabaseFactory.RemovePane(stringBuilder));
		return ContextOptions.Open(stringBuilder);
	}

	internal static void RemovePane()
	{
		if (!DiskSerializer.RemovePane())
		{
			return;
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
			string text = PackageQueue.RemovePane(319);
			throw BuilderEventArgs.RemovePane(DomainTable.RemovePane(PackageQueue.RemovePane(336), text));
		}
	}

	internal static bool RemovePane()
	{
		try
		{
			if (Package.RemovePane())
			{
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
					return true;
				}
			}
			IntPtr intPtr = RemovePane(PackageQueue.RemovePane(435));
			ServerConverter serverConverter = DiskSerializer.RemovePane(intPtr, PackageQueue.RemovePane(460));
			if (serverConverter != null)
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
				if (PartitionContext.RemovePane(serverConverter) != 0)
				{
					while (true)
					{
						switch (4)
						{
						case 0:
							break;
						default:
							return true;
						}
					}
				}
			}
			uint messageSet = DiskSerializer.RemovePane();
			IntPtr intPtr2 = Open(1024u, 0, messageSet);
			if (ProjectTree.RemovePane(intPtr2, IntPtr.Zero))
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
				try
				{
					BuilderService builderService = DiskSerializer.RemovePane(intPtr, PackageQueue.RemovePane(495));
					if (builderService != null)
					{
						while (true)
						{
							switch (1)
							{
							case 0:
								continue;
							}
							int messageSet2 = 0;
							if (MethodDictionary.RemovePane(builderService, intPtr2, ref messageSet2) == 0)
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
								if (messageSet2 == 0)
								{
									break;
								}
								while (true)
								{
									switch (5)
									{
									case 0:
										continue;
									}
									return true;
								}
							}
							break;
						}
					}
				}
				finally
				{
					RemovePane(intPtr2);
				}
			}
			bool flag = false;
			try
			{
				RemovePane(new IntPtr(305419896));
			}
			catch
			{
				flag = true;
			}
			if (flag)
			{
				while (true)
				{
					switch (5)
					{
					case 0:
						continue;
					}
					return true;
				}
			}
			try
			{
				IntPtr intPtr3 = RemovePane(PackageQueue.RemovePane(548));
				DatabaseProvider databaseProvider = DiskSerializer.RemovePane(intPtr3, PackageQueue.RemovePane(569));
				if (databaseProvider != null)
				{
					while (true)
					{
						switch (3)
						{
						case 0:
							continue;
						}
						idEnabled = false;
						MethodManager.RemovePane(databaseProvider, RemovePane, IntPtr.Zero);
						if (!idEnabled)
						{
							break;
						}
						while (true)
						{
							switch (5)
							{
							case 0:
								continue;
							}
							return true;
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
		return false;
	}
}
