using System;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Security.Policy;
using System.Text;
using RegCode;

namespace RegAsm;

public class RegAsm
{
	private const string strDocStringPrefix = "";

	private const string strManagedTypeThreadingModel = "Both";

	private const string strClassesRootRegKey = "HKEY_CLASSES_ROOT";

	private const int SuccessReturnCode = 0;

	private const int ErrorReturnCode = 100;

	private const int MAX_PATH = 260;

	internal static RegAsmOptions s_Options = null;

	public static int Main(string[] args)
	{
		int ReturnCode = 0;
		if (!ParseArguments(args, ref s_Options, ref ReturnCode))
		{
			return ReturnCode;
		}
		if (!s_Options.m_bSilentMode)
		{
			PrintLogo();
		}
		return Run();
	}

	public static int Run()
	{
		//IL_0464: Unknown result type (might be due to invalid IL or missing references)
		//IL_046b: Expected O, but got Unknown
		string text = null;
		int result = 0;
		try
		{
			string fullPath = Path.GetFullPath(s_Options.m_strAssemblyName);
			if (!File.Exists(fullPath))
			{
				StringBuilder stringBuilder = new StringBuilder(261);
				if (SearchPath(null, s_Options.m_strAssemblyName, null, stringBuilder.Capacity + 1, stringBuilder, null) == 0)
				{
					throw new ApplicationException(Resource.FormatString("Err_InputFileNotFound", s_Options.m_strAssemblyName));
				}
				s_Options.m_strAssemblyName = stringBuilder.ToString();
			}
			else
			{
				s_Options.m_strAssemblyName = fullPath;
			}
			s_Options.m_strAssemblyName = new FileInfo(s_Options.m_strAssemblyName).FullName;
			if (s_Options.m_strRegFileName != null)
			{
				s_Options.m_strRegFileName = new FileInfo(s_Options.m_strRegFileName).FullName;
			}
			text = Path.GetDirectoryName(s_Options.m_strAssemblyName);
			if (s_Options.m_strTypeLibName != null)
			{
				if (Path.GetDirectoryName(s_Options.m_strTypeLibName) == "")
				{
					s_Options.m_strTypeLibName = Path.Combine(text, s_Options.m_strTypeLibName);
				}
				else
				{
					s_Options.m_strTypeLibName = new FileInfo(s_Options.m_strTypeLibName).FullName;
				}
			}
			if (s_Options.m_bTypeLibSpecified)
			{
				if (s_Options.m_strTypeLibName == null)
				{
					if (ContainsEmbeddedTlb(s_Options.m_strAssemblyName))
					{
						s_Options.m_strTypeLibName = s_Options.m_strAssemblyName;
					}
					else if (s_Options.m_strAssemblyName.Length >= 4 && (string.Compare(s_Options.m_strAssemblyName.Substring(s_Options.m_strAssemblyName.Length - 4), ".dll", ignoreCase: true, CultureInfo.InvariantCulture) == 0 || string.Compare(s_Options.m_strAssemblyName.Substring(s_Options.m_strAssemblyName.Length - 4), ".exe", ignoreCase: true, CultureInfo.InvariantCulture) == 0))
					{
						s_Options.m_strTypeLibName = s_Options.m_strAssemblyName.Substring(0, s_Options.m_strAssemblyName.Length - 4) + ".tlb";
					}
					else
					{
						s_Options.m_strTypeLibName = s_Options.m_strAssemblyName + ".tlb";
					}
					if (!Directory.Exists(Path.GetDirectoryName(s_Options.m_strTypeLibName)))
					{
						Directory.CreateDirectory(Path.GetDirectoryName(s_Options.m_strTypeLibName));
					}
				}
				else
				{
					if (!Directory.Exists(Path.GetDirectoryName(s_Options.m_strTypeLibName)))
					{
						Directory.CreateDirectory(Path.GetDirectoryName(s_Options.m_strTypeLibName));
					}
					if (ContainsEmbeddedTlb(s_Options.m_strAssemblyName))
					{
						throw new ApplicationException(Resource.FormatString("Err_TlbNameNotAllowedWithEmbedded"));
					}
				}
			}
			if (s_Options.m_bRegFileSpecified && s_Options.m_strRegFileName == null)
			{
				if (s_Options.m_strAssemblyName.Length >= 4 && (string.Compare(s_Options.m_strAssemblyName.Substring(s_Options.m_strAssemblyName.Length - 4), ".dll", ignoreCase: true, CultureInfo.InvariantCulture) == 0 || string.Compare(s_Options.m_strAssemblyName.Substring(s_Options.m_strAssemblyName.Length - 4), ".exe", ignoreCase: true, CultureInfo.InvariantCulture) == 0))
				{
					s_Options.m_strRegFileName = s_Options.m_strAssemblyName.Substring(0, s_Options.m_strAssemblyName.Length - 4) + ".reg";
				}
				else
				{
					s_Options.m_strRegFileName = s_Options.m_strAssemblyName + ".reg";
				}
			}
			if (s_Options.m_bRegFileSpecified && !Directory.Exists(Path.GetDirectoryName(s_Options.m_strRegFileName)))
			{
				Directory.CreateDirectory(Path.GetDirectoryName(s_Options.m_strRegFileName));
			}
			_ = Environment.CurrentDirectory;
			AppDomainSetup appDomainSetup = new AppDomainSetup();
			appDomainSetup.set_ApplicationBase(text);
			AppDomain appDomain = AppDomain.CreateDomain("RegAsm", (Evidence)null, appDomainSetup);
			if (appDomain == null)
			{
				throw new ApplicationException(Resource.FormatString("Err_CannotCreateAppDomain"));
			}
			string fullName = typeof(RemoteRegAsm).Assembly.GetName().FullName;
			ObjectHandle objectHandle = appDomain.CreateInstance(fullName, "RegCode.RemoteRegAsm");
			if (objectHandle == null)
			{
				throw new ApplicationException(Resource.FormatString("Err_CannotCreateRemoteRegAsm"));
			}
			RemoteRegAsm val = (RemoteRegAsm)objectHandle.Unwrap();
			if (val != null)
			{
				return val.Run(s_Options);
			}
			return result;
		}
		catch (Exception e)
		{
			WriteErrorMsg(null, e);
			return 100;
		}
	}

	private static bool ContainsEmbeddedTlb(string strFileName)
	{
		UCOMITypeLib TypeLib = null;
		try
		{
			LoadTypeLibEx(s_Options.m_strAssemblyName, REGKIND.REGKIND_NONE, out TypeLib);
		}
		catch (Exception)
		{
		}
		if (TypeLib == null)
		{
			return false;
		}
		return true;
	}

	private static void WriteErrorMsg(string strPrefix, Exception e)
	{
		string text = "";
		if (strPrefix != null)
		{
			text = strPrefix;
		}
		text = ((e.Message == null) ? (text + ((object)e).GetType().ToString()) : (text + e.Message));
		Console.Error.WriteLine(Resource.FormatString("Msg_RegAsmErrorPrefix", text));
	}

	private static void WriteErrorMsg(string strErrorMsg)
	{
		Console.Error.WriteLine(Resource.FormatString("Msg_RegAsmErrorPrefix", strErrorMsg));
	}

	private static void WriteWarningMsg(string strErrorMsg)
	{
		Console.Error.WriteLine(Resource.FormatString("Msg_RegAsmWarningPrefix", strErrorMsg));
	}

	private static bool ParseArguments(string[] aArgs, ref RegAsmOptions Options, ref int ReturnCode)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		Options = new RegAsmOptions();
		CommandLine commandLine;
		try
		{
			commandLine = new CommandLine(aArgs, new string[10] { "+regfile", "+tlb", "unregister", "registered", "codebase", "nologo", "silent", "verbose", "?", "help" });
		}
		catch (ApplicationException e)
		{
			PrintLogo();
			WriteErrorMsg(null, e);
			ReturnCode = 100;
			return false;
		}
		if (commandLine.NumArgs + commandLine.NumOpts < 1)
		{
			PrintUsage();
			ReturnCode = 0;
			return false;
		}
		Options.m_strAssemblyName = commandLine.GetNextArg();
		Option nextOption;
		while (true)
		{
			if ((nextOption = commandLine.GetNextOption()) != null)
			{
				if (nextOption.Name.Equals("regfile"))
				{
					Options.m_strRegFileName = nextOption.Value;
					Options.m_bRegFileSpecified = true;
					continue;
				}
				if (nextOption.Name.Equals("tlb"))
				{
					Options.m_strTypeLibName = nextOption.Value;
					Options.m_bTypeLibSpecified = true;
					continue;
				}
				if (nextOption.Name.Equals("codebase"))
				{
					Options.m_bSetCodeBase = true;
					continue;
				}
				if (nextOption.Name.Equals("unregister"))
				{
					Options.m_bRegister = false;
					continue;
				}
				if (nextOption.Name.Equals("registered"))
				{
					RegAsmOptions obj = Options;
					obj.m_Flags = (TypeLibExporterFlags)(obj.m_Flags | 1);
					continue;
				}
				if (nextOption.Name.Equals("nologo"))
				{
					Options.m_bNoLogo = true;
					continue;
				}
				if (nextOption.Name.Equals("silent"))
				{
					Options.m_bSilentMode = true;
					continue;
				}
				if (!nextOption.Name.Equals("verbose"))
				{
					break;
				}
				Options.m_bVerboseMode = true;
				continue;
			}
			if (!Options.m_bRegister && Options.m_bRegFileSpecified)
			{
				PrintLogo();
				WriteErrorMsg(Resource.FormatString("Err_CannotGenRegFileForUnregister"));
				ReturnCode = 100;
				return false;
			}
			if (Options.m_bTypeLibSpecified && Options.m_bRegFileSpecified)
			{
				PrintLogo();
				WriteErrorMsg(Resource.FormatString("Err_CannotGenRegFileAndExpTlb"));
				ReturnCode = 100;
				return false;
			}
			if (Options.m_strAssemblyName == null)
			{
				PrintLogo();
				WriteErrorMsg(Resource.FormatString("Err_NoInputFile"));
				ReturnCode = 100;
				return false;
			}
			return true;
		}
		if (!nextOption.Name.Equals("?") && !nextOption.Name.Equals("help"))
		{
			PrintLogo();
			WriteErrorMsg(Resource.FormatString("Err_InvalidOption"));
			ReturnCode = 100;
			return false;
		}
		PrintUsage();
		ReturnCode = 0;
		return false;
	}

	private static void PrintLogo()
	{
		if (!s_Options.m_bNoLogo)
		{
			Console.WriteLine(Resource.FormatString("Msg_Copyright", "1.1.4322.573"));
		}
	}

	private static void PrintUsage()
	{
		PrintLogo();
		Console.WriteLine(Resource.FormatString("Msg_Usage"));
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern int SearchPath(string path, string fileName, string extension, int numBufferChars, StringBuilder buffer, int[] filePart);

	[DllImport("oleaut32.dll", CharSet = CharSet.Unicode, PreserveSig = false)]
	private static extern void LoadTypeLibEx(string strTypeLibName, REGKIND regKind, out UCOMITypeLib TypeLib);
}
