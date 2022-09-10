using System;
using System.EnterpriseServices;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Security.Policy;
using System.Text;
using System.Threading;

[ComVisible(false)]
public class RegSvcs
{
	private const int MAX_PATH = 260;

	private static RegistrationConfig regConfig;

	private static bool logoOutput;

	private static bool successOutput;

	private static bool uninstallApplication;

	private static bool bootstrapInstall;

	private static bool bootstrapUninstall;

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int SearchPath(string path, string fileName, string extension, int numBufferChars, StringBuilder buffer, int[] filePart);

	static RegSvcs()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Expected O, but got Unknown
		regConfig = new RegistrationConfig();
	}

	private static RegistrationHelper GetRegistrationHelper(bool bCreateAppDomain, out AppDomain domain)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		RegistrationHelper result = null;
		domain = null;
		if (!bCreateAppDomain)
		{
			result = new RegistrationHelper();
		}
		else
		{
			string directoryName = Path.GetDirectoryName(regConfig.get_AssemblyFile());
			AppDomainSetup appDomainSetup = new AppDomainSetup();
			appDomainSetup.set_ApplicationBase(directoryName);
			domain = AppDomain.CreateDomain("RegSvcs", (Evidence)null, appDomainSetup);
			if (domain != null)
			{
				ObjectHandle objectHandle = domain.CreateInstance(typeof(RegistrationHelper).Assembly.FullName, typeof(RegistrationHelper).FullName);
				if (objectHandle != null)
				{
					result = (RegistrationHelper)objectHandle.Unwrap();
				}
			}
		}
		return result;
	}

	private static void Bootstrap()
	{
		Type typeFromHandle = typeof(RegistrationHelperTx);
		if (bootstrapInstall)
		{
			MethodInfo method = typeFromHandle.GetMethod("InstallUtilityApplication", BindingFlags.DeclaredOnly | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			object[] parameters = new object[1];
			method.Invoke(null, parameters);
		}
		else if (bootstrapUninstall)
		{
			MethodInfo method2 = typeFromHandle.GetMethod("UninstallUtilityApplication", BindingFlags.DeclaredOnly | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			object[] parameters2 = new object[1];
			method2.Invoke(null, parameters2);
		}
	}

	private static string FindAssembly(string name)
	{
		StringBuilder stringBuilder = new StringBuilder(261);
		if (SearchPath(null, name, null, stringBuilder.Capacity + 1, stringBuilder, null) == 0)
		{
			return null;
		}
		return stringBuilder.ToString();
	}

	private static bool IsAssemblyInGAC(string name)
	{
		try
		{
			Assembly.Load(name);
		}
		catch
		{
			return false;
		}
		return true;
	}

	[MTAThread]
	public static int Main(string[] args)
	{
		try
		{
			return UnsafeMain(args);
		}
		catch
		{
			return 1;
		}
	}

	public static int UnsafeMain(string[] args)
	{
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Expected O, but got Unknown
		AppDomain domain = null;
		DoConsoleInitialization();
		try
		{
			ParseArguments(args);
			if (!bootstrapInstall && !bootstrapUninstall)
			{
				if (logoOutput)
				{
					PrintLogo();
				}
				if (regConfig.get_AssemblyFile() != null)
				{
					string text = FindAssembly(regConfig.get_AssemblyFile());
					RegistrationHelper registrationHelper;
					if (text != null)
					{
						regConfig.set_AssemblyFile(text);
						registrationHelper = GetRegistrationHelper(bCreateAppDomain: true, out domain);
					}
					else
					{
						if (!IsAssemblyInGAC(regConfig.get_AssemblyFile()))
						{
							throw new RegistrationException(Resource.FormatString("RegSvcs_AssemblyNotFound", regConfig.get_AssemblyFile()));
						}
						registrationHelper = GetRegistrationHelper(bCreateAppDomain: false, out domain);
					}
					if (uninstallApplication)
					{
						registrationHelper.UninstallAssemblyFromConfig(ref regConfig);
						if (successOutput)
						{
							Console.WriteLine(Resource.FormatString("RegSvcs_UninstallSuccess", regConfig.get_AssemblyFile()));
						}
					}
					else
					{
						registrationHelper.InstallAssemblyFromConfig(ref regConfig);
						if (successOutput)
						{
							if (regConfig.get_Partition() != null && regConfig.get_Application() != null)
							{
								Console.WriteLine(Resource.FormatString("RegSvcs_InstallSuccess2", new string[4]
								{
									regConfig.get_AssemblyFile(),
									regConfig.get_Application(),
									regConfig.get_Partition(),
									regConfig.get_TypeLibrary()
								}));
							}
							else if (regConfig.get_Application() != null)
							{
								Console.WriteLine(Resource.FormatString("RegSvcs_InstallSuccess", regConfig.get_AssemblyFile(), regConfig.get_Application(), regConfig.get_TypeLibrary()));
							}
							else
							{
								Console.WriteLine(Resource.FormatString("RegSvcs_NoServicedComponents"));
							}
						}
					}
				}
			}
			else
			{
				Bootstrap();
			}
		}
		catch (UsageException ex)
		{
			if (logoOutput)
			{
				PrintLogo();
			}
			Console.WriteLine(ex.Message);
			return ex.ReturnCode;
		}
		catch (RegistrationException val)
		{
			RegistrationException val2 = val;
			string text2 = null;
			text2 = ((!uninstallApplication) ? Resource.FormatString("RegSvcs_InstallError") : Resource.FormatString("RegSvcs_UninstallError"));
			DumpExceptions(text2, (Exception)(object)val2, ename: false);
			if (((Exception)(object)val2).InnerException != null)
			{
				if (((Exception)(object)val2).InnerException is COMException)
				{
					COMException ex2 = (COMException)((Exception)(object)val2).InnerException;
					if (ex2.ErrorCode != 0)
					{
						return ex2.ErrorCode;
					}
					return 1;
				}
			}
			else if (val2.get_ErrorInfo() != null)
			{
				RegistrationErrorInfo[] errorInfo = val2.get_ErrorInfo();
				foreach (RegistrationErrorInfo val3 in errorInfo)
				{
					if (val3.get_ErrorCode() != 0)
					{
						return val3.get_ErrorCode();
					}
				}
			}
			return 1;
		}
		catch (COMException ex3)
		{
			DumpExceptions(Resource.FormatString("RegSvcs_CatalogError"), ex3, ename: false);
			if (ex3.ErrorCode != 0)
			{
				return ex3.ErrorCode;
			}
			return 1;
		}
		catch (Exception e)
		{
			DumpExceptions(Resource.FormatString("RegSvcs_UnknownError"), e, ename: true);
			return 1;
		}
		catch
		{
			DumpExceptions(Resource.FormatString("Err_NonClsException", "Main"), null, ename: false);
			return 1;
		}
		finally
		{
			if (domain != null)
			{
				AppDomain.Unload(domain);
			}
		}
		return 0;
	}

	private static void DoConsoleInitialization()
	{
		Thread.CurrentThread.CurrentUICulture = CultureInfo.CurrentUICulture.GetConsoleFallbackUICulture();
		if (Console.OutputEncoding.CodePage != 65001 && Console.OutputEncoding.CodePage != Thread.CurrentThread.CurrentUICulture.TextInfo.OEMCodePage && Console.OutputEncoding.CodePage != Thread.CurrentThread.CurrentUICulture.TextInfo.ANSICodePage)
		{
			Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
		}
	}

	private static void DumpExceptions(string msg, Exception e, bool ename)
	{
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		Console.WriteLine("\n" + msg);
		int num = 1;
		while (e != null)
		{
			if (!ename && e.Message != null && e.Message.Length != 0)
			{
				Console.WriteLine("" + num + ": " + e.Message);
			}
			else
			{
				Console.WriteLine("" + num + ": " + e.GetType().FullName + " - " + e.Message);
			}
			if (e is RegistrationException)
			{
				RegistrationErrorInfo[] errorInfo = ((RegistrationException)e).get_ErrorInfo();
				if (errorInfo != null)
				{
					RegistrationErrorInfo[] array = errorInfo;
					foreach (RegistrationErrorInfo val in array)
					{
						if (val.get_MinorRef().ToLower(CultureInfo.InvariantCulture) != "<invalid>")
						{
							Console.WriteLine("    " + val.get_Name() + "." + val.get_MinorRef() + ": " + val.get_ErrorString());
						}
						else
						{
							Console.WriteLine("    " + val.get_Name() + ": " + val.get_ErrorString());
						}
					}
				}
			}
			num++;
			e = e.InnerException;
		}
	}

	private static void PrintLogo()
	{
		Console.WriteLine(Resource.FormatString("RegSvcs_CopyrightMsg", "2.0.50727.1433", CommonResStrings.CopyrightForCmdLine));
	}

	private static bool IsArgument(string arg, string check)
	{
		string text = arg.ToLower(CultureInfo.InvariantCulture);
		if (!("/" + check == text))
		{
			return "-" + check == text;
		}
		return true;
	}

	private static bool IsPrefixArgument(string arg, string check, ref string prefix)
	{
		arg.ToLower(CultureInfo.InvariantCulture);
		prefix = null;
		if (!arg.StartsWith("/" + check + ":", StringComparison.Ordinal) && !arg.StartsWith("-" + check + ":", StringComparison.Ordinal))
		{
			return IsArgument(arg, check);
		}
		if (arg.Length > check.Length + 2)
		{
			prefix = arg.Substring(check.Length + 2);
		}
		return true;
	}

	private static void ParseArguments(string[] args)
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		regConfig.set_InstallationFlags((InstallationFlags)44);
		logoOutput = true;
		successOutput = true;
		uninstallApplication = false;
		if (args.Length < 1)
		{
			throw new UsageException(0);
		}
		int num = 0;
		num = 0;
		while (true)
		{
			if (num < args.Length)
			{
				string prefix = null;
				if (IsArgument(args[num], "?") || IsArgument(args[num], "help"))
				{
					break;
				}
				if (IsArgument(args[num], "c"))
				{
					RegistrationConfig obj = regConfig;
					obj.set_InstallationFlags((InstallationFlags)(obj.get_InstallationFlags() | 2));
					RegistrationConfig obj2 = regConfig;
					obj2.set_InstallationFlags((InstallationFlags)(obj2.get_InstallationFlags() & -5));
					goto IL_0288;
				}
				if (IsArgument(args[num], "fc"))
				{
					RegistrationConfig obj3 = regConfig;
					obj3.set_InstallationFlags((InstallationFlags)(obj3.get_InstallationFlags() | 4));
					goto IL_0288;
				}
				if (IsArgument(args[num], "exapp"))
				{
					RegistrationConfig obj4 = regConfig;
					obj4.set_InstallationFlags((InstallationFlags)(obj4.get_InstallationFlags() & -7));
					goto IL_0288;
				}
				if (IsArgument(args[num], "extlb"))
				{
					RegistrationConfig obj5 = regConfig;
					obj5.set_InstallationFlags((InstallationFlags)(obj5.get_InstallationFlags() | 1));
					goto IL_0288;
				}
				if (IsPrefixArgument(args[num], "tlb", ref prefix))
				{
					regConfig.set_TypeLibrary(prefix);
					goto IL_0288;
				}
				if (IsArgument(args[num], "reconfig"))
				{
					RegistrationConfig obj6 = regConfig;
					obj6.set_InstallationFlags((InstallationFlags)(obj6.get_InstallationFlags() | 8));
					goto IL_0288;
				}
				if (IsArgument(args[num], "noreconfig"))
				{
					RegistrationConfig obj7 = regConfig;
					obj7.set_InstallationFlags((InstallationFlags)(obj7.get_InstallationFlags() & -9));
					goto IL_0288;
				}
				if (IsArgument(args[num], "nologo"))
				{
					logoOutput = false;
					goto IL_0288;
				}
				if (IsArgument(args[num], "quiet"))
				{
					RegistrationConfig obj8 = regConfig;
					obj8.set_InstallationFlags((InstallationFlags)(obj8.get_InstallationFlags() & -33));
					logoOutput = false;
					successOutput = false;
					goto IL_0288;
				}
				if (IsArgument(args[num], "u"))
				{
					uninstallApplication = true;
					goto IL_0288;
				}
				if (IsArgument(args[num], "componly"))
				{
					RegistrationConfig obj9 = regConfig;
					obj9.set_InstallationFlags((InstallationFlags)(obj9.get_InstallationFlags() | 0x10));
					goto IL_0288;
				}
				if (IsArgument(args[num], "bootstrapi"))
				{
					bootstrapInstall = true;
					goto IL_0288;
				}
				if (IsArgument(args[num], "bootstrapu"))
				{
					bootstrapUninstall = true;
					goto IL_0288;
				}
				if (IsPrefixArgument(args[num], "appname", ref prefix))
				{
					regConfig.set_Application(prefix);
					goto IL_0288;
				}
				if (IsPrefixArgument(args[num], "parname", ref prefix))
				{
					regConfig.set_Partition(prefix);
					goto IL_0288;
				}
				if (IsPrefixArgument(args[num], "appdir", ref prefix))
				{
					regConfig.set_ApplicationRootDirectory(prefix);
					goto IL_0288;
				}
				if (args[num].StartsWith("/", StringComparison.Ordinal) || args[num].StartsWith("-", StringComparison.Ordinal))
				{
					throw new UsageException(1, Resource.FormatString("RegSvcs_InvalidOption", args[num]));
				}
			}
			if (num > args.Length)
			{
				throw new UsageException(1);
			}
			int num2 = args.Length - num;
			if (!bootstrapInstall && !bootstrapUninstall)
			{
				switch (num2)
				{
				case 0:
					throw new UsageException(1, Resource.FormatString("RegSvcs_NotEnoughArgs"));
				case 1:
					regConfig.set_AssemblyFile(args[num]);
					break;
				case 2:
					regConfig.set_AssemblyFile(args[num]);
					regConfig.set_Application(args[num + 1]);
					regConfig.set_TypeLibrary((string)null);
					break;
				case 3:
					regConfig.set_AssemblyFile(args[num]);
					regConfig.set_Application(args[num + 1]);
					regConfig.set_TypeLibrary(args[num + 2]);
					break;
				default:
					throw new UsageException(1, Resource.FormatString("RegSvcs_ToManyArgs"));
				}
			}
			return;
			IL_0288:
			num++;
		}
		throw new UsageException(0);
	}
}
