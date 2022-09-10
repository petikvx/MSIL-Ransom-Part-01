using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using System.Security.Policy;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Xml;
using Microsoft.Win32;

namespace Microsoft.Tools.Caspol;

internal class caspol
{
	private const string m_indent = "   ";

	private const string m_labelSeparators = ".";

	private const string CLR_CASOFF_MUTEX = "Global\\CLR_CASOFF_MUTEX";

	private const string CLR_CASOFF_MUTEX_NO_GLOBAL = "CLR_CASOFF_MUTEX";

	private static LevelType m_levelType = LevelType.None;

	private static PolicyLevel m_currentCustomLevel;

	private static string m_levelPath;

	private static ArrayList m_levelAssemblyList;

	private static ArrayList m_machineAssemblies = new ArrayList();

	private static ArrayList m_userAssemblies = new ArrayList();

	private static ArrayList m_enterpriseAssemblies = new ArrayList();

	private static ArrayList m_customUserAssemblies = new ArrayList();

	private static bool m_force = false;

	private static bool m_success = true;

	private static string m_danglingLevelIndicator = null;

	internal static ResourceManager manager = new ResourceManager("caspol", Assembly.GetExecutingAssembly());

	private static OptionTableEntry[] optionTable = null;

	private static MembershipConditionTableEntry[] mshipTable = null;

	private static CodeGroupAttributeTableEntry[] cgAttrTable = null;

	private static string[] s_names = new string[5] { "MyComputer", "Intranet", "Trusted", "Internet", "Untrusted" };

	private static bool screenPauseEnabled = false;

	private static readonly int ScreenHeight = 23;

	private static int linesSeen = 0;

	private static bool Quiet = false;

	private static string s_policyRegKey = null;

	private static string s_trustManagerConfigurationFile = null;

	private static OptionTableEntry[] OptionTable
	{
		get
		{
			if (optionTable == null)
			{
				optionTable = new OptionTableEntry[66]
				{
					new OptionTableEntry(manager.GetString("OptionTable_Machine"), MachineHandler, null, list: true),
					new OptionTableEntry(manager.GetString("OptionTable_MachineAbbr"), MachineHandler, manager.GetString("OptionTable_Machine"), list: false),
					new OptionTableEntry(manager.GetString("OptionTable_User"), UserHandler, null, list: true),
					new OptionTableEntry(manager.GetString("OptionTable_UserAbbr"), UserHandler, manager.GetString("OptionTable_User"), list: false),
					new OptionTableEntry(manager.GetString("OptionTable_Enterprise"), EnterpriseHandler, null, list: true),
					new OptionTableEntry(manager.GetString("OptionTable_EnterpriseAbbr"), EnterpriseHandler, manager.GetString("OptionTable_Enterprise"), list: false),
					new OptionTableEntry(manager.GetString("OptionTable_CustomUser"), CustomUserHandler, null, list: true),
					new OptionTableEntry(manager.GetString("OptionTable_CustomUserAbbr"), CustomUserHandler, manager.GetString("OptionTable_CustomUser"), list: true),
					new OptionTableEntry(manager.GetString("OptionTable_All"), AllHandler, null, list: true),
					new OptionTableEntry(manager.GetString("OptionTable_AllAbbr"), AllHandler, manager.GetString("OptionTable_All"), list: false),
					new OptionTableEntry(manager.GetString("OptionTable_CustomAll"), CustomAllHandler, null, list: true),
					new OptionTableEntry(manager.GetString("OptionTable_CustomAllAbbr"), CustomAllHandler, manager.GetString("OptionTable_CustomAll"), list: true),
					new OptionTableEntry(manager.GetString("OptionTable_List"), ListHandler, null, list: true),
					new OptionTableEntry(manager.GetString("OptionTable_ListAbbr"), ListHandler, manager.GetString("OptionTable_List"), list: false),
					new OptionTableEntry(manager.GetString("OptionTable_ListGroups"), ListGroupHandler, null, list: true),
					new OptionTableEntry(manager.GetString("OptionTable_ListGroupsAbbr"), ListGroupHandler, manager.GetString("OptionTable_ListGroups"), list: true),
					new OptionTableEntry(manager.GetString("OptionTable_ListPSet"), ListPermHandler, null, list: true),
					new OptionTableEntry(manager.GetString("OptionTable_ListPSetAbbr"), ListPermHandler, manager.GetString("OptionTable_ListPSet"), list: true),
					new OptionTableEntry(manager.GetString("OptionTable_ListFullTrust"), ListFullTrustHandler, null, list: true),
					new OptionTableEntry(manager.GetString("OptionTable_ListFullTrustAbbr"), ListFullTrustHandler, manager.GetString("OptionTable_ListFullTrust"), list: true),
					new OptionTableEntry(manager.GetString("OptionTable_ListDescription"), ListDescriptionHandler, null, list: true),
					new OptionTableEntry(manager.GetString("OptionTable_ListDescriptionAbbr"), ListDescriptionHandler, manager.GetString("OptionTable_ListDescription"), list: true),
					new OptionTableEntry(manager.GetString("OptionTable_CheckFullTrust"), CheckFullTrustHandler, null, list: true),
					new OptionTableEntry(manager.GetString("OptionTable_CheckFullTrustAbbr"), CheckFullTrustHandler, manager.GetString("OptionTable_CheckFullTrust"), list: true),
					new OptionTableEntry(manager.GetString("OptionTable_AddPSet"), AddPermHandler, null, list: true),
					new OptionTableEntry(manager.GetString("OptionTable_AddPSetAbbr"), AddPermHandler, manager.GetString("OptionTable_AddPSet"), list: true),
					new OptionTableEntry(manager.GetString("OptionTable_ChgPSet"), ChgPermHandler, null, list: true),
					new OptionTableEntry(manager.GetString("OptionTable_ChgPSetAbbr"), ChgPermHandler, manager.GetString("OptionTable_ChgPSet"), list: true),
					new OptionTableEntry(manager.GetString("OptionTable_RemPSet"), RemPermHandler, null, list: true),
					new OptionTableEntry(manager.GetString("OptionTable_RemPSetAbbr"), RemPermHandler, manager.GetString("OptionTable_RemPSet"), list: true),
					new OptionTableEntry(manager.GetString("OptionTable_AddFullTrust"), AddFullTrustHandler, null, list: true),
					new OptionTableEntry(manager.GetString("OptionTable_AddFullTrustAbbr"), AddFullTrustHandler, manager.GetString("OptionTable_AddFullTrust"), list: true),
					new OptionTableEntry(manager.GetString("OptionTable_RemFullTrust"), RemFullTrustHandler, null, list: true),
					new OptionTableEntry(manager.GetString("OptionTable_RemFullTrustAbbr"), RemFullTrustHandler, manager.GetString("OptionTable_RemFullTrust"), list: true),
					new OptionTableEntry(manager.GetString("OptionTable_RemGroup"), RemGroupHandler, null, list: true, displayMShip: true),
					new OptionTableEntry(manager.GetString("OptionTable_RemGroupAbbr"), RemGroupHandler, manager.GetString("OptionTable_RemGroup"), list: true, displayMShip: true),
					new OptionTableEntry(manager.GetString("OptionTable_ChgGroup"), ChgGroupHandler, null, list: true, displayMShip: true),
					new OptionTableEntry(manager.GetString("OptionTable_ChgGroupAbbr"), ChgGroupHandler, manager.GetString("OptionTable_ChgGroup"), list: true, displayMShip: true),
					new OptionTableEntry(manager.GetString("OptionTable_AddGroup"), AddGroupHandler, null, list: true, displayMShip: true),
					new OptionTableEntry(manager.GetString("OptionTable_AddGroupAbbr"), AddGroupHandler, manager.GetString("OptionTable_AddGroup"), list: true, displayMShip: true),
					new OptionTableEntry(manager.GetString("OptionTable_ResolveGroup"), ResolveGroupHandler, null, list: true),
					new OptionTableEntry(manager.GetString("OptionTable_ResolveGroupAbbr"), ResolveGroupHandler, manager.GetString("OptionTable_ResolveGroup"), list: true),
					new OptionTableEntry(manager.GetString("OptionTable_ResolvePerm"), ResolvePermHandler, null, list: true),
					new OptionTableEntry(manager.GetString("OptionTable_ResolvePermAbbr"), ResolvePermHandler, manager.GetString("OptionTable_ResolvePerm"), list: true),
					new OptionTableEntry(manager.GetString("OptionTable_Security"), SecurityHandler, null, list: true),
					new OptionTableEntry(manager.GetString("OptionTable_SecurityAbbr"), SecurityHandler, manager.GetString("OptionTable_Security"), list: false),
					new OptionTableEntry(manager.GetString("OptionTable_Execution"), ExecutionHandler, null, list: true),
					new OptionTableEntry(manager.GetString("OptionTable_ExecutionAbbr"), ExecutionHandler, manager.GetString("OptionTable_Execution"), list: false),
					new OptionTableEntry(manager.GetString("OptionTable_PolChgPrompt"), PolicyChangeHandler, null, list: true),
					new OptionTableEntry(manager.GetString("OptionTable_PolChgPromptAbbr"), PolicyChangeHandler, manager.GetString("OptionTable_PolChgPrompt"), list: true),
					new OptionTableEntry(manager.GetString("OptionTable_Quiet"), QuietHandler, null, list: true),
					new OptionTableEntry(manager.GetString("OptionTable_QuietAbbr"), QuietHandler, manager.GetString("OptionTable_Quiet"), list: false),
					new OptionTableEntry(manager.GetString("OptionTable_Recover"), RecoverHandler, null, list: true),
					new OptionTableEntry(manager.GetString("OptionTable_RecoverAbbr"), RecoverHandler, manager.GetString("OptionTable_Recover"), list: false),
					new OptionTableEntry(manager.GetString("OptionTable_Reset"), ResetHandler, null, list: true),
					new OptionTableEntry(manager.GetString("OptionTable_ResetLockDown"), ResetLockDownHandler, null, list: true),
					new OptionTableEntry(manager.GetString("OptionTable_ResetAbbr"), ResetHandler, manager.GetString("OptionTable_Reset"), list: true),
					new OptionTableEntry(manager.GetString("OptionTable_ResetLockDownAbbr"), ResetLockDownHandler, manager.GetString("OptionTable_ResetLockDown"), list: true),
					new OptionTableEntry(manager.GetString("OptionTable_Force"), ForceHandler, null, list: true),
					new OptionTableEntry(manager.GetString("OptionTable_ForceAbbr"), ForceHandler, manager.GetString("OptionTable_Force"), list: false),
					new OptionTableEntry(manager.GetString("OptionTable_BuildCache"), BuildCacheHandler, null, list: true),
					new OptionTableEntry(manager.GetString("OptionTable_BuildCacheAbbr"), BuildCacheHandler, manager.GetString("OptionTable_BuildCache"), list: false),
					new OptionTableEntry(manager.GetString("OptionTable_Help"), HelpHandler, null, list: true),
					new OptionTableEntry(manager.GetString("OptionTable_HelpAbbr1"), HelpHandler, manager.GetString("OptionTable_Help"), list: false),
					new OptionTableEntry(manager.GetString("OptionTable_HelpAbbr2"), HelpHandler, manager.GetString("OptionTable_Help"), list: true),
					new OptionTableEntry(manager.GetString("OptionTable_HelpAbbr3"), HelpHandler, manager.GetString("OptionTable_Help"), list: true)
				};
			}
			return optionTable;
		}
	}

	private static MembershipConditionTableEntry[] MembershipTable
	{
		get
		{
			if (mshipTable == null)
			{
				mshipTable = new MembershipConditionTableEntry[10]
				{
					new MembershipConditionTableEntry(manager.GetString("MembershipConditionTable_All"), AllMembershipConditionHandler),
					new MembershipConditionTableEntry(manager.GetString("MembershipConditionTable_AppDir"), ApplicationDirectoryMembershipConditionHandler),
					new MembershipConditionTableEntry(manager.GetString("MembershipConditionTable_Custom"), CustomMembershipConditionHandler),
					new MembershipConditionTableEntry(manager.GetString("MembershipConditionTable_Hash"), HashMembershipConditionHandler),
					new MembershipConditionTableEntry(manager.GetString("MembershipConditionTable_Pub"), PublisherMembershipConditionHandler),
					new MembershipConditionTableEntry(manager.GetString("MembershipConditionTable_Gac"), GacMembershipConditionHandler),
					new MembershipConditionTableEntry(manager.GetString("MembershipConditionTable_Site"), SiteMembershipConditionHandler),
					new MembershipConditionTableEntry(manager.GetString("MembershipConditionTable_Strong"), StrongNameMembershipConditionHandler),
					new MembershipConditionTableEntry(manager.GetString("MembershipConditionTable_Url"), URLMembershipConditionHandler),
					new MembershipConditionTableEntry(manager.GetString("MembershipConditionTable_Zone"), ZoneMembershipConditionHandler)
				};
			}
			return mshipTable;
		}
	}

	private static CodeGroupAttributeTableEntry[] CodeGroupAttrTable
	{
		get
		{
			if (cgAttrTable == null)
			{
				cgAttrTable = new CodeGroupAttributeTableEntry[6]
				{
					new CodeGroupAttributeTableEntry(manager.GetString("CodeGroupAttributeTable_Exclusive"), (PolicyStatementAttribute)1, manager.GetString("Help_Option_ExclusiveFlag")),
					new CodeGroupAttributeTableEntry(manager.GetString("CodeGroupAttributeTable_LevelFinal"), (PolicyStatementAttribute)2, manager.GetString("Help_Option_LevelFinalFlag")),
					new CodeGroupAttributeTableEntry(manager.GetString("CodeGroupAttributeTable_Name"), CodeGroupNameHandler, display: true),
					new CodeGroupAttributeTableEntry(manager.GetString("CodeGroupAttributeTable_NameAbbr"), CodeGroupNameHandler, display: false),
					new CodeGroupAttributeTableEntry(manager.GetString("CodeGroupAttributeTable_Description"), CodeGroupDescriptionHandler, display: true),
					new CodeGroupAttributeTableEntry(manager.GetString("CodeGroupAttributeTable_DescriptionAbbr"), CodeGroupDescriptionHandler, display: false)
				};
			}
			return cgAttrTable;
		}
	}

	private static string PolicyRegKey
	{
		get
		{
			if (s_policyRegKey == null)
			{
				StringBuilder stringBuilder = new StringBuilder(256);
				if (GetCORVersion(stringBuilder, 256, out var _) == 0)
				{
					s_policyRegKey = "Software\\Microsoft\\.NETFramework\\" + stringBuilder.ToString() + "\\Security\\Policy";
				}
			}
			return s_policyRegKey;
		}
	}

	private static bool PolicyPrompt
	{
		get
		{
			if (PolicyRegKey == null)
			{
				return true;
			}
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(PolicyRegKey, writable: false);
			if (registryKey == null)
			{
				return true;
			}
			byte[] array = (byte[])registryKey.GetValue("CaspolSettings", null);
			registryKey.Close();
			if (array != null)
			{
				return (array[0] & 1) != 1;
			}
			return true;
		}
		set
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(PolicyRegKey, writable: false);
			if (registryKey == null)
			{
				registryKey = Registry.LocalMachine.CreateSubKey(PolicyRegKey);
			}
			byte[] array = (byte[])registryKey.GetValue("CaspolSettings", null);
			registryKey.Close();
			if (array == null)
			{
				array = new byte[4];
			}
			array[0] = (byte)((!value) ? 1 : 0);
			registryKey = Registry.LocalMachine.OpenSubKey(PolicyRegKey, writable: true);
			registryKey.SetValue("CaspolSettings", array);
			registryKey.Close();
		}
	}

	private static string TrustManagerConfigurationFile
	{
		get
		{
			if (s_trustManagerConfigurationFile == null)
			{
				StringBuilder stringBuilder = new StringBuilder(256);
				if (GetCORSystemDirectory(stringBuilder, 256, out var _) != 0)
				{
					throw new Exception(manager.GetString("Error_TrustManager_UnableToGetFrameworkDir"));
				}
				s_trustManagerConfigurationFile = stringBuilder.ToString() + "\\config\\applicationtrust.config";
			}
			return s_trustManagerConfigurationFile;
		}
	}

	[DllImport("mscoree.dll", CharSet = CharSet.Unicode)]
	private static extern int GetCORVersion(StringBuilder sb, int sbSize, out int sbCount);

	[DllImport("mscoree.dll", CharSet = CharSet.Unicode)]
	private static extern int GetCORSystemDirectory(StringBuilder sb, int sbSize, out int sbCount);

	private static void PauseCapableWriteLine(string msg)
	{
		string[] array = msg.Split(new char[1] { '\n' });
		for (int i = 0; i < array.Length; i++)
		{
			Console.WriteLine(array[i].Trim(Environment.NewLine.ToCharArray()));
			if (++linesSeen == ScreenHeight && screenPauseEnabled)
			{
				Console.WriteLine(manager.GetString("Dialog_PressEnterToContinue"));
				Console.ReadLine();
				linesSeen = 0;
			}
		}
	}

	private static string GenerateHeader()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(manager.GetString("Copyright_Line1") + " 2.0.50727.1433");
		stringBuilder.Append(Environment.NewLine + CommonResStrings.CopyrightForCmdLine + Environment.NewLine);
		return stringBuilder.ToString();
	}

	public static void Main(string[] args)
	{
		SetConsoleUI();
		PauseCapableWriteLine(GenerateHeader());
		try
		{
			if (args.Length == 0)
			{
				Error(null, manager.GetString("Error_NotEnoughArgs"), -1);
			}
			else
			{
				Run(args);
			}
		}
		catch (ExitException)
		{
		}
	}

	private static void SetConsoleUI()
	{
		Thread currentThread = Thread.CurrentThread;
		currentThread.CurrentUICulture = CultureInfo.CurrentUICulture.GetConsoleFallbackUICulture();
		if (Environment.OSVersion.Platform != PlatformID.Win32Windows && Console.OutputEncoding.CodePage != currentThread.CurrentUICulture.TextInfo.OEMCodePage && Console.OutputEncoding.CodePage != currentThread.CurrentUICulture.TextInfo.ANSICodePage)
		{
			currentThread.CurrentUICulture = new CultureInfo("en-US");
		}
	}

	private static void Run(string[] args)
	{
		int num = args.Length;
		int num2 = 0;
		int numArgsUsed = 0;
		while (num2 < num)
		{
			bool flag = false;
			for (int i = 0; i < OptionTable.Length; i++)
			{
				if (args[num2].Length > 0 && args[num2][0] == '/')
				{
					args[num2] = '-' + args[num2].Substring(1, args[num2].Length - 1);
				}
				if (string.Compare(OptionTable[i].option, args[num2], StringComparison.OrdinalIgnoreCase) != 0)
				{
					continue;
				}
				try
				{
					OptionTable[i].handler(args, num2, out numArgsUsed);
				}
				catch (Exception ex)
				{
					if (!(ex is ExitException))
					{
						string text = ex.Message;
						if (text == null || text.Equals(""))
						{
							text = ex.GetType().AssemblyQualifiedName;
						}
						Error(null, string.Format(CultureInfo.CurrentCulture, manager.GetString("Error_RuntimeError"), new object[1] { text }), -1);
					}
					return;
				}
				flag = true;
				num2 += numArgsUsed;
				break;
			}
			if (flag)
			{
				continue;
			}
			try
			{
				Error(null, string.Format(CultureInfo.CurrentCulture, manager.GetString("Error_InvalidOption"), new object[1] { args[num2] }), -1);
			}
			catch (Exception ex2)
			{
				if (!(ex2 is ExitException))
				{
					string text2 = ex2.Message;
					if (text2 == null || text2.Equals(""))
					{
						text2 = ex2.GetType().AssemblyQualifiedName;
					}
					Help(null, manager.GetString("Error_UnhandledError") + text2);
				}
				return;
			}
		}
		if (m_danglingLevelIndicator != null)
		{
			PauseCapableWriteLine(string.Format(CultureInfo.CurrentCulture, manager.GetString("Error_DanglingLevelIndicator"), new object[1] { m_danglingLevelIndicator }));
		}
		if (m_success)
		{
			PauseCapableWriteLine(manager.GetString("Dialog_Success"));
		}
	}

	private static PermissionSet GeneratecaspolRequiredPermSet()
	{
		return new PermissionSet(PermissionState.Unrestricted);
	}

	private static int ConvertHexDigit(char val)
	{
		if (val <= '9')
		{
			return val - 48;
		}
		if (val >= 'a' && val <= 'f')
		{
			return val - 97 + 10;
		}
		if (val >= 'A' && val <= 'F')
		{
			return val - 65 + 10;
		}
		throw new ArgumentException(manager.GetString("Argument_ImproperlyFormattedHexString"));
	}

	public static byte[] DecodeHexString(string hexString)
	{
		if (hexString == null)
		{
			throw new ArgumentNullException("hexString");
		}
		bool flag = false;
		int num = 0;
		int num2 = hexString.Length;
		if (hexString.StartsWith("0x", StringComparison.Ordinal))
		{
			num2 = hexString.Length - 2;
			num = 2;
		}
		if (num2 % 2 != 0 && num2 % 3 != 2)
		{
			throw new ArgumentException(manager.GetString("Argument_ImproperlyFormattedHexString"));
		}
		byte[] array;
		if (num2 >= 3 && hexString[num + 2] == ' ')
		{
			flag = true;
			array = new byte[num2 / 3 + 1];
		}
		else
		{
			array = new byte[num2 / 2];
		}
		int num3 = 0;
		while (num < hexString.Length)
		{
			int num4 = ConvertHexDigit(hexString[num]);
			int num5 = ConvertHexDigit(hexString[num + 1]);
			array[num3] = (byte)(num5 | (num4 << 4));
			if (flag)
			{
				num++;
			}
			num += 2;
			num3++;
		}
		return array;
	}

	private static void CodeGroupNameHandler(CodeGroup group, string[] args, int index, out int offset)
	{
		offset = 2;
		if (args[index].Equals("__internal_usage__"))
		{
			PauseCapableWriteLine(manager.GetString("Help_Option_Name"));
			return;
		}
		if (args.Length - index < 1)
		{
			ErrorMShip(args[0], manager.GetString("CodeGroupAttributeTable_Name"), manager.GetString("Error_NotEnoughArgs"), -1);
		}
		if (args[index + 1][0] >= '0' && args[index + 1][0] <= '9')
		{
			ErrorMShip(args[0], manager.GetString("CodeGroupAttributeTable_Name"), manager.GetString("Error_CodeGroup_ImproperName"), -1);
		}
		group.set_Name(args[index + 1]);
	}

	private static void CodeGroupDescriptionHandler(CodeGroup group, string[] args, int index, out int offset)
	{
		offset = 2;
		if (args[index].Equals("__internal_usage__"))
		{
			PauseCapableWriteLine(manager.GetString("Help_Option_Description"));
			return;
		}
		if (args.Length - index < 1)
		{
			ErrorMShip(args[0], manager.GetString("CodeGroupAttributeTable_Description"), manager.GetString("Error_NotEnoughArgs"), -1);
		}
		group.set_Description(args[index + 1]);
	}

	private static PolicyStatementAttribute IsExclusive(CodeGroup group, string[] args, int index, out int argsUsed)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		PolicyStatementAttribute val = (PolicyStatementAttribute)0;
		argsUsed = 0;
		int num = CodeGroupAttrTable.Length;
		while (true)
		{
			int offset = 0;
			if (args.Length - (index + argsUsed) == 0)
			{
				break;
			}
			for (int i = 0; i < num; i++)
			{
				if (string.Compare(args[index + argsUsed], CodeGroupAttrTable[i].label, StringComparison.OrdinalIgnoreCase) != 0)
				{
					continue;
				}
				if (CodeGroupAttrTable[i].handler == null)
				{
					if (args.Length - (index + argsUsed + 1) > 0)
					{
						if (string.Compare(args[index + argsUsed + 1], manager.GetString("Misc_On"), StringComparison.OrdinalIgnoreCase) == 0)
						{
							val = (PolicyStatementAttribute)(val | CodeGroupAttrTable[i].value);
						}
						else
						{
							if (string.Compare(args[index + argsUsed + 1], manager.GetString("Misc_Off"), StringComparison.OrdinalIgnoreCase) != 0)
							{
								throw new Exception(string.Format(CultureInfo.CurrentCulture, manager.GetString("Error_InvalidOptionTo"), new object[2]
								{
									CodeGroupAttrTable[i].label,
									args[index + argsUsed + 1]
								}));
							}
							val = (PolicyStatementAttribute)(val & ~CodeGroupAttrTable[i].value);
						}
						offset = 2;
						break;
					}
					throw new Exception(string.Format(CultureInfo.CurrentCulture, manager.GetString("Error_NotEnoughArgs")));
				}
				CodeGroupAttrTable[i].handler(group, args, index + argsUsed, out offset);
				break;
			}
			if (offset == 0)
			{
				break;
			}
			argsUsed += offset;
		}
		return val;
	}

	private static IMembershipCondition CreateMembershipCondition(PolicyLevel level, string[] args, int index, out int offset)
	{
		IMembershipCondition val = CreateMembershipConditionNoThrow(level, args, index, out offset);
		if (val == null)
		{
			int num = ((index >= 2) ? 2 : 0);
			ErrorMShip(args[num], null, string.Format(CultureInfo.CurrentCulture, manager.GetString("Error_UnknownMembershipCondition"), new object[1] { args[index] }), -1);
		}
		return val;
	}

	private static IMembershipCondition CreateMembershipConditionNoThrow(PolicyLevel level, string[] args, int index, out int offset)
	{
		int num = 0;
		while (true)
		{
			if (num < MembershipTable.Length)
			{
				if (string.Compare(MembershipTable[num].option, args[index], StringComparison.OrdinalIgnoreCase) == 0)
				{
					break;
				}
				num++;
				continue;
			}
			offset = 0;
			return null;
		}
		return MembershipTable[num].handler(level, args, index, out offset);
	}

	private static IMembershipCondition AllMembershipConditionHandler(PolicyLevel level, string[] args, int index, out int offset)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		offset = 1;
		if (args[index].Equals("__internal_usage__"))
		{
			PauseCapableWriteLine(manager.GetString("Help_MembershipCondition_All"));
			return null;
		}
		return (IMembershipCondition)new AllMembershipCondition();
	}

	private static IMembershipCondition ApplicationDirectoryMembershipConditionHandler(PolicyLevel level, string[] args, int index, out int offset)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		offset = 1;
		if (args[index].Equals("__internal_usage__"))
		{
			PauseCapableWriteLine(manager.GetString("Help_MembershipCondition_AppDir"));
			return null;
		}
		return (IMembershipCondition)new ApplicationDirectoryMembershipCondition();
	}

	private static IMembershipCondition CustomMembershipConditionHandler(PolicyLevel level, string[] args, int index, out int offset)
	{
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		if (args[index].Equals("__internal_usage__"))
		{
			PauseCapableWriteLine(manager.GetString("Help_MembershipCondition_Custom"));
			offset = 1;
			return null;
		}
		if (args.Length - index < 2)
		{
			ErrorMShip(args[0], manager.GetString("MembershipConditionTable_Custom"), manager.GetString("Error_NotEnoughArgs"), -1);
		}
		offset = 2;
		SecurityElement securityElement = ReadXmlFile(args, index + 1);
		if (securityElement == null)
		{
			ErrorMShip(args[0], manager.GetString("MembershipConditionTable_Custom"), manager.GetString("Error_Custom_ErrorDecodingArg"), -1);
		}
		IMembershipCondition val = null;
		string text = securityElement.Attribute("class");
		if (text == null)
		{
			ErrorMShip(args[0], manager.GetString("MembershipConditionTable_Custom"), manager.GetString("Error_Custom_InvalidXml"), -1);
		}
		Type type = Type.GetType(text);
		try
		{
			val = (IMembershipCondition)Activator.CreateInstance(type);
		}
		catch (Exception)
		{
			ErrorMShip(args[0], manager.GetString("MembershipConditionTable_Custom"), manager.GetString("Error_Custom_UnableToCreate"), -1);
		}
		if (val == null)
		{
			ErrorMShip(args[0], manager.GetString("MembershipConditionTable_Custom"), manager.GetString("Error_Custom_InvalidXml"), -1);
		}
		try
		{
			((ISecurityEncodable)val).FromXml(securityElement);
		}
		catch (Exception ex2)
		{
			ErrorMShip(args[0], manager.GetString("MembershipConditionTable_Custom"), string.Format(CultureInfo.CurrentCulture, manager.GetString("Error_Custom_InvalidXml"), new object[1] { ex2 }), -1);
		}
		m_levelAssemblyList.Add(((object)val).GetType().Module.Assembly);
		return val;
	}

	private static IMembershipCondition HashMembershipConditionHandler(PolicyLevel level, string[] args, int index, out int offset)
	{
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		if (args[index].Equals("__internal_usage__"))
		{
			PauseCapableWriteLine(manager.GetString("Help_MembershipCondition_Hash"));
			offset = 0;
			return null;
		}
		if (args.Length - index < 4)
		{
			ErrorMShip(args[0], manager.GetString("MembershipConditionTable_Hash"), manager.GetString("Error_NotEnoughArgs"), -1);
		}
		HashAlgorithm hashAlgorithm = HashAlgorithm.Create(args[index + 1]);
		if (hashAlgorithm == null)
		{
			ErrorMShip(args[0], manager.GetString("MembershipConditionTable_Hash"), string.Format(CultureInfo.CurrentCulture, manager.GetString("Error_UnknownHashAlgorithm"), new object[1] { args[index + 1] }), -1);
		}
		byte[] array = null;
		if (string.Compare(args[index + 2], manager.GetString("Misc_File"), StringComparison.OrdinalIgnoreCase) == 0)
		{
			array = LoadAssembly(args[index + 3], manager.GetString("MembershipConditionTable_Hash")).GenerateHash(args[index + 1]);
			offset = 4;
		}
		else if (string.Compare(args[index + 2], manager.GetString("Misc_Hex"), StringComparison.OrdinalIgnoreCase) == 0)
		{
			array = DecodeHexString(args[index + 3]);
			offset = 4;
		}
		else
		{
			ErrorMShip(args[0], manager.GetString("MembershipConditionTable_Hash"), string.Format(CultureInfo.CurrentCulture, manager.GetString("Error_Hash_InvalidOption"), new object[1] { args[index + 2] }), -1);
			offset = 0;
		}
		return (IMembershipCondition)new HashMembershipCondition(hashAlgorithm, array);
	}

	private static IMembershipCondition PublisherMembershipConditionHandler(PolicyLevel level, string[] args, int index, out int offset)
	{
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		offset = 3;
		if (args[index].Equals("__internal_usage__"))
		{
			PauseCapableWriteLine(manager.GetString("Help_MembershipCondition_Pub"));
			return null;
		}
		if (args.Length - index < 2)
		{
			ErrorMShip(args[0], manager.GetString("MembershipConditionTable_Pub"), manager.GetString("Error_NotEnoughArgs"), -1);
		}
		X509Certificate x509Certificate = null;
		try
		{
			if (string.Compare(args[index + 1], manager.GetString("Misc_File"), StringComparison.OrdinalIgnoreCase) == 0)
			{
				x509Certificate = X509Certificate.CreateFromSignedFile(args[index + 2]);
			}
			else if (string.Compare(args[index + 1], manager.GetString("Misc_Cert"), StringComparison.OrdinalIgnoreCase) == 0)
			{
				x509Certificate = X509Certificate.CreateFromCertFile(args[index + 2]);
			}
			else if (string.Compare(args[index + 1], manager.GetString("Misc_Hex"), StringComparison.OrdinalIgnoreCase) == 0)
			{
				x509Certificate = new X509Certificate(DecodeHexString(args[index + 2]));
			}
			else
			{
				ErrorMShip(args[0], manager.GetString("MembershipConditionTable_Pub"), string.Format(CultureInfo.CurrentCulture, manager.GetString("Error_InvalidOption"), new object[1] { args[index + 1] }), -1);
			}
		}
		catch
		{
			ErrorMShip(args[0], manager.GetString("MembershipConditionTable_Pub"), manager.GetString("Error_Publisher_InvalidSignedFile"), -1);
		}
		return (IMembershipCondition)new PublisherMembershipCondition(x509Certificate);
	}

	private static IMembershipCondition SiteMembershipConditionHandler(PolicyLevel level, string[] args, int index, out int offset)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		offset = 2;
		if (args[index].Equals("__internal_usage__"))
		{
			PauseCapableWriteLine(manager.GetString("Help_MembershipCondition_Site"));
			return null;
		}
		if (args.Length - index < 1)
		{
			ErrorMShip(args[0], manager.GetString("MembershipConditionTable_Site"), manager.GetString("Error_NotEnoughArgs"), -1);
		}
		return (IMembershipCondition)new SiteMembershipCondition(args[index + 1]);
	}

	private static IMembershipCondition GacMembershipConditionHandler(PolicyLevel level, string[] args, int index, out int offset)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		offset = 1;
		if (args[index].Equals("__internal_usage__"))
		{
			PauseCapableWriteLine(manager.GetString("Help_MembershipCondition_Gac"));
			return null;
		}
		return (IMembershipCondition)new GacMembershipCondition();
	}

	private static IMembershipCondition StrongNameMembershipConditionHandler(PolicyLevel level, string[] args, int index, out int offset)
	{
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		if (args[index].Equals("__internal_usage__"))
		{
			PauseCapableWriteLine(manager.GetString("Help_MembershipCondition_Strong"));
			offset = 0;
			return null;
		}
		if (args.Length - index < 5)
		{
			ErrorMShip(args[0], manager.GetString("MembershipConditionTable_Strong"), manager.GetString("Error_NotEnoughArgs"), -1);
		}
		StrongNamePublicKeyBlob val = null;
		string text = null;
		string text2 = null;
		if (string.Compare(args[index + 1], manager.GetString("Misc_File"), StringComparison.OrdinalIgnoreCase) == 0)
		{
			AssemblyName assemblyName = AssemblyName.GetAssemblyName(args[index + 2]);
			byte[] publicKey = assemblyName.GetPublicKey();
			if (publicKey == null || publicKey.Length < 1)
			{
				Error(manager.GetString("MembershipConditionTable_Strong"), manager.GetString("Error_NotStrongNamed"), -1);
			}
			val = new StrongNamePublicKeyBlob(publicKey);
			text = args[index + 3];
			text2 = args[index + 4];
			offset = 5;
		}
		else if (string.Compare(args[index + 1], manager.GetString("Misc_Hex"), StringComparison.OrdinalIgnoreCase) == 0)
		{
			val = new StrongNamePublicKeyBlob(DecodeHexString(args[index + 2]));
			text = args[index + 3];
			text2 = args[index + 4];
			offset = 5;
		}
		else
		{
			ErrorMShip(args[0], manager.GetString("MembershipConditionTable_Strong"), string.Format(CultureInfo.CurrentCulture, manager.GetString("Error_StrongName_InvalidOption"), new object[1] { args[index + 1] }), -1);
			offset = 0;
		}
		if (string.Compare(text, manager.GetString("Misc_NoName"), StringComparison.OrdinalIgnoreCase) == 0)
		{
			text = null;
		}
		if (string.Compare(text2, manager.GetString("Misc_NoVersion"), StringComparison.OrdinalIgnoreCase) == 0)
		{
			text2 = null;
		}
		Version version = null;
		if (text2 != null)
		{
			try
			{
				version = new Version(text2);
			}
			catch (Exception)
			{
				ErrorMShip(args[0], manager.GetString("MembershipConditionTable_Strong"), manager.GetString("Error_StrongName_ImproperlyFormattedVersion"), -1);
			}
		}
		return (IMembershipCondition)new StrongNameMembershipCondition(val, text, version);
	}

	private static IMembershipCondition URLMembershipConditionHandler(PolicyLevel level, string[] args, int index, out int offset)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		offset = 2;
		if (args[index].Equals("__internal_usage__"))
		{
			PauseCapableWriteLine(manager.GetString("Help_MembershipCondition_Url"));
			return null;
		}
		if (args.Length - index < 1)
		{
			ErrorMShip(args[0], manager.GetString("MembershipConditionTable_Url"), manager.GetString("Error_NotEnoughArgs"), -1);
		}
		return (IMembershipCondition)new UrlMembershipCondition(args[index + 1]);
	}

	private static IMembershipCondition ZoneMembershipConditionHandler(PolicyLevel level, string[] args, int index, out int offset)
	{
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Invalid comparison between Unknown and I4
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Invalid comparison between Unknown and I4
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		offset = 2;
		if (args[index].Equals("__internal_usage__"))
		{
			PauseCapableWriteLine(manager.GetString("Help_MembershipCondition_Zone"));
			for (int i = 0; i < s_names.Length; i++)
			{
				PauseCapableWriteLine("                                 " + s_names[i]);
			}
			return null;
		}
		if (args.Length - index < 2)
		{
			ErrorMShip(args[0], manager.GetString("MembershipConditionTable_Zone"), manager.GetString("Error_NotEnoughArgs"), -1);
		}
		SecurityZone val = (SecurityZone)(-1);
		try
		{
			val = (SecurityZone)int.Parse(args[index + 1], CultureInfo.InvariantCulture);
		}
		catch (Exception)
		{
			for (int j = 0; j < s_names.Length; j++)
			{
				if (string.Compare(args[index + 1], s_names[j], StringComparison.OrdinalIgnoreCase) == 0)
				{
					val = (SecurityZone)j;
					break;
				}
			}
		}
		if ((int)val < 0 || (int)val > 4)
		{
			ErrorMShip(args[0], manager.GetString("MembershipConditionTable_Zone"), string.Format(CultureInfo.CurrentCulture, manager.GetString("Error_Zone_InvalidZone"), new object[1] { args[index + 1] }), -1);
		}
		return (IMembershipCondition)new ZoneMembershipCondition(val);
	}

	private static PolicyLevel GetLevel(PolicyLevelType type)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		IEnumerator enumerator;
		try
		{
			enumerator = SecurityManager.PolicyHierarchy();
		}
		catch (SecurityException)
		{
			Error(null, string.Format(CultureInfo.CurrentCulture, manager.GetString("Error_InsufficientRightsToRetrieveLevel")), -1);
			return null;
		}
		PolicyLevel val;
		do
		{
			if (enumerator.MoveNext())
			{
				val = (PolicyLevel)enumerator.Current;
				continue;
			}
			return null;
		}
		while (!((object)val.get_Type()).Equals((object?)type));
		return val;
	}

	private static PolicyLevel GetLevel()
	{
		return GetLevel(LevelType.None);
	}

	private static PolicyLevel GetLevel(LevelType type)
	{
		m_danglingLevelIndicator = null;
		if (m_levelType == LevelType.None)
		{
			switch (type)
			{
			case LevelType.None:
			{
				WindowsPrincipal windowsPrincipal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
				if (windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator))
				{
					m_levelAssemblyList = m_machineAssemblies;
					return GetLevel((PolicyLevelType)1);
				}
				m_levelAssemblyList = m_userAssemblies;
				return GetLevel((PolicyLevelType)0);
			}
			case LevelType.All:
				return null;
			default:
				Error(null, string.Format(CultureInfo.CurrentCulture, manager.GetString("Error_UnknownLevelType")), -1);
				return null;
			}
		}
		if (m_levelType == LevelType.Machine)
		{
			m_levelAssemblyList = m_machineAssemblies;
			return GetLevel((PolicyLevelType)1);
		}
		if (m_levelType == LevelType.UserDefault)
		{
			m_levelAssemblyList = m_userAssemblies;
			return GetLevel((PolicyLevelType)0);
		}
		if (m_levelType == LevelType.UserCustom)
		{
			if (m_currentCustomLevel == null)
			{
				m_levelAssemblyList = m_customUserAssemblies;
				try
				{
					m_currentCustomLevel = SecurityManager.LoadPolicyLevelFromFile(m_levelPath, (PolicyLevelType)0);
				}
				catch (Exception ex)
				{
					Error(null, ex.Message, -1);
				}
			}
			return m_currentCustomLevel;
		}
		if (m_levelType == LevelType.All)
		{
			return null;
		}
		if (m_levelType == LevelType.Enterprise)
		{
			m_levelAssemblyList = m_enterpriseAssemblies;
			return GetLevel((PolicyLevelType)2);
		}
		if (m_levelType == LevelType.AllCustom)
		{
			if (m_currentCustomLevel == null)
			{
				try
				{
					m_currentCustomLevel = SecurityManager.LoadPolicyLevelFromFile(m_levelPath, (PolicyLevelType)0);
				}
				catch (Exception ex2)
				{
					Error(null, ex2.Message, -1);
				}
			}
			return null;
		}
		Error(null, string.Format(CultureInfo.CurrentCulture, manager.GetString("Error_UnknownLevelType")), -1);
		return null;
	}

	private static string ParentLabel(string label)
	{
		if (label[0] < '0' || label[0] > '9')
		{
			PolicyLevel level = GetLevel();
			string numericLabel = "1";
			if (level.get_RootCodeGroup().get_Name().Equals(label))
			{
				level.get_RootCodeGroup();
			}
			else
			{
				GetLabelByName(label, level.get_RootCodeGroup(), ref numericLabel);
			}
			label = numericLabel;
		}
		string[] array = label.Split(".".ToCharArray());
		int num = ((array[^1] == null || array[^1].Equals("")) ? (array.Length - 1) : array.Length);
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < num - 1; i++)
		{
			stringBuilder.Append(array[i]);
			stringBuilder.Append('.');
		}
		return stringBuilder.ToString();
	}

	private static void ReplaceLabel(string label, CodeGroup obj)
	{
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected O, but got Unknown
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected O, but got Unknown
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Expected O, but got Unknown
		PolicyLevel level = GetLevel();
		if (level == null || label == null)
		{
			return;
		}
		if (label[0] < '0' || label[0] > '9')
		{
			string numericLabel = "1";
			GetLabelByName(label, level.get_RootCodeGroup(), ref numericLabel);
			label = numericLabel;
		}
		string[] array = label.Split(".".ToCharArray());
		int num = ((array[^1] == null || array[^1].Equals("")) ? (array.Length - 1) : array.Length);
		if (num >= 1 && !array[0].Equals("1"))
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, manager.GetString("Error_InvalidLabelArg"), new object[1] { label }));
		}
		CodeGroup val = level.get_RootCodeGroup();
		if (num == 1 && array[0].Equals("1"))
		{
			level.set_RootCodeGroup(obj);
			return;
		}
		ArrayList arrayList = new ArrayList();
		CodeGroup val2 = val;
		arrayList.Insert(0, val);
		int num2 = 1;
		while (true)
		{
			if (num2 < num - 1)
			{
				IEnumerator enumerator = val.get_Children().GetEnumerator();
				int num3 = 1;
				while (enumerator.MoveNext())
				{
					if (num3 != int.Parse(array[num2], CultureInfo.InvariantCulture))
					{
						num3++;
						continue;
					}
					val2 = (CodeGroup)enumerator.Current;
					break;
				}
				if (val2 != null)
				{
					val = val2;
					arrayList.Insert(0, val);
					num2++;
					continue;
				}
				throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, manager.GetString("Error_InvalidLabelArg"), new object[1] { label }));
			}
			arrayList.Insert(0, obj);
			for (int i = 1; i < arrayList.Count; i++)
			{
				val2 = (CodeGroup)arrayList[i];
				IEnumerator enumerator2 = val2.get_Children().GetEnumerator();
				val2.set_Children((IList)new ArrayList());
				int num4 = 1;
				while (enumerator2.MoveNext())
				{
					if (num4 == int.Parse(array[num - i], CultureInfo.InvariantCulture))
					{
						val2.AddChild((CodeGroup)arrayList[i - 1]);
					}
					else
					{
						val2.AddChild((CodeGroup)enumerator2.Current);
					}
					num4++;
				}
			}
			break;
		}
		level.set_RootCodeGroup((CodeGroup)arrayList[arrayList.Count - 1]);
	}

	private static object GetLabel(string label)
	{
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected O, but got Unknown
		PolicyLevel level = GetLevel();
		if (level == null)
		{
			return null;
		}
		if (label == null)
		{
			return null;
		}
		if (label[0] >= '0' && label[0] <= '9')
		{
			string[] array = label.Split(".".ToCharArray());
			int num = ((array[^1] == null || array[^1].Equals("")) ? (array.Length - 1) : array.Length);
			if (num >= 1 && !array[0].Equals("1"))
			{
				throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, manager.GetString("Error_InvalidLabelArg"), new object[1] { label }));
			}
			CodeGroup val = level.get_RootCodeGroup();
			if (num == 1 && array[0].Equals("1"))
			{
				return val;
			}
			int num2 = 1;
			while (true)
			{
				if (num2 < num)
				{
					CodeGroup val2 = null;
					IEnumerator enumerator = val.get_Children().GetEnumerator();
					int num3 = 1;
					while (enumerator.MoveNext())
					{
						if (num3 != int.Parse(array[num2], CultureInfo.InvariantCulture))
						{
							num3++;
							continue;
						}
						val2 = (CodeGroup)enumerator.Current;
						break;
					}
					if (val2 == null)
					{
						break;
					}
					val = val2;
					num2++;
					continue;
				}
				return val;
			}
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, manager.GetString("Error_InvalidLabelArg"), new object[1] { label }));
		}
		string numericLabel = "1";
		if (level.get_RootCodeGroup().get_Name().Equals(label))
		{
			return level.get_RootCodeGroup();
		}
		return GetLabelByName(label, level.get_RootCodeGroup(), ref numericLabel);
	}

	private static object GetLabelByName(string label, CodeGroup group, ref string numericLabel)
	{
		if (group.get_Name() != null && group.get_Name().Equals(label))
		{
			numericLabel = "1";
			return group;
		}
		return GetLabelByNameHelper(label, group, ref numericLabel);
	}

	private static object GetLabelByNameHelper(string label, CodeGroup group, ref string numericLabel)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		IEnumerator enumerator = group.get_Children().GetEnumerator();
		int num = 1;
		string numericLabel2;
		object labelByNameHelper;
		while (true)
		{
			if (enumerator.MoveNext())
			{
				numericLabel2 = numericLabel + "." + num;
				CodeGroup val = (CodeGroup)enumerator.Current;
				if (val.get_Name() == null || !val.get_Name().Equals(label))
				{
					labelByNameHelper = GetLabelByNameHelper(label, val, ref numericLabel2);
					if (labelByNameHelper != null)
					{
						break;
					}
					num++;
					continue;
				}
				numericLabel = numericLabel2;
				return enumerator.Current;
			}
			numericLabel = null;
			return null;
		}
		numericLabel = numericLabel2;
		return labelByNameHelper;
	}

	private static bool DisplayMShipInfo(string which)
	{
		if (which == null)
		{
			return true;
		}
		int num = 0;
		while (true)
		{
			if (num < OptionTable.Length)
			{
				if (string.Compare(which, OptionTable[num].option, StringComparison.OrdinalIgnoreCase) == 0)
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return OptionTable[num].displayMShip;
	}

	private static void Error(string which, string message, int errorCode)
	{
		ErrorMShip(which, null, message, errorCode, DisplayMShipInfo(which));
	}

	private static void ErrorMShip(string whichOption, string whichMShip, string message, int errorCode)
	{
		ErrorMShip(whichOption, whichMShip, message, errorCode, displayMshipInfo: true);
	}

	private static void ErrorMShip(string whichOption, string whichMShip, string message, int errorCode, bool displayMshipInfo)
	{
		HelpMShip(whichOption, whichMShip, string.Format(CultureInfo.CurrentCulture, manager.GetString("Error_Arg"), new object[1] { message }), displayMshipInfo);
		Environment.ExitCode = errorCode;
		throw new ExitException();
	}

	private static void Help(string which, string message)
	{
		HelpMShip(which, null, message, DisplayMShipInfo(which));
	}

	private static void HelpMShip(string whichOption, string whichMShip, string message, bool displayMShipInfo)
	{
		PauseCapableWriteLine(message + Environment.NewLine);
		if (whichOption == null)
		{
			PauseCapableWriteLine(manager.GetString("SeeHelp"));
			return;
		}
		PauseCapableWriteLine(manager.GetString("Usage") + Environment.NewLine);
		string[] args = new string[1] { "__internal_usage__" };
		int numArgsUsed;
		for (int i = 0; i < OptionTable.Length; i++)
		{
			if (!OptionTable[i].list || OptionTable[i].sameAs != null || (!whichOption.Equals("*") && string.Compare(whichOption, OptionTable[i].option, StringComparison.OrdinalIgnoreCase) != 0))
			{
				continue;
			}
			for (int j = 0; j < OptionTable.Length; j++)
			{
				if (OptionTable[j].list && OptionTable[j].sameAs != null && string.Compare(OptionTable[i].option, OptionTable[j].sameAs, StringComparison.OrdinalIgnoreCase) == 0)
				{
					StringBuilder stringBuilder = new StringBuilder();
					stringBuilder.Append(manager.GetString("Usage_Name"));
					stringBuilder.Append(" ");
					stringBuilder.Append(OptionTable[j].option);
					PauseCapableWriteLine(stringBuilder.ToString());
				}
			}
			OptionTable[i].handler(args, 0, out numArgsUsed);
			PauseCapableWriteLine("");
		}
		if (!displayMShipInfo)
		{
			return;
		}
		PauseCapableWriteLine(Environment.NewLine + manager.GetString("Usage_MembershipCondition"));
		for (int k = 0; k < MembershipTable.Length; k++)
		{
			if (whichMShip == null || string.Compare(whichMShip, MembershipTable[k].option, StringComparison.OrdinalIgnoreCase) == 0)
			{
				int offset = 0;
				MembershipTable[k].handler(null, args, 0, out offset);
			}
		}
		PauseCapableWriteLine(Environment.NewLine + manager.GetString("Usage_CodeGroupAttribute"));
		for (int l = 0; l < CodeGroupAttrTable.Length; l++)
		{
			if (CodeGroupAttrTable[l].display)
			{
				if (CodeGroupAttrTable[l].handler == null)
				{
					PauseCapableWriteLine("  " + CodeGroupAttrTable[l].label + manager.GetString("Dialog_OnOff"));
					PauseCapableWriteLine("                           " + CodeGroupAttrTable[l].description);
				}
				else
				{
					CodeGroupAttrTable[l].handler(null, args, 0, out numArgsUsed);
				}
			}
		}
	}

	private static StrongName FindStrongName(Evidence evidence)
	{
		if (evidence == null)
		{
			return null;
		}
		IEnumerator hostEnumerator = evidence.GetHostEnumerator();
		StrongName val;
		do
		{
			if (!hostEnumerator.MoveNext())
			{
				return null;
			}
			object current = hostEnumerator.Current;
			val = (StrongName)((current is StrongName) ? current : null);
		}
		while (val == null);
		return val;
	}

	private static bool GetAnswer()
	{
		string text = Console.ReadLine();
		if (text != null)
		{
			if (string.Compare(text, manager.GetString("Misc_Yes"), StringComparison.OrdinalIgnoreCase) != 0)
			{
				return string.Compare(text, manager.GetString("Misc_YesAbbr"), StringComparison.OrdinalIgnoreCase) == 0;
			}
			return true;
		}
		return false;
	}

	public static bool CompareAssemblyNames(AssemblyName left, AssemblyName right)
	{
		if (left == null && right == null)
		{
			return true;
		}
		if (left != null && right != null)
		{
			return string.Compare(left.FullName, right.FullName, StringComparison.Ordinal) == 0;
		}
		return false;
	}

	public static bool AlreadyLoaded(ArrayList loadedAssemblies, AssemblyName assemblyName)
	{
		if (loadedAssemblies == null)
		{
			return false;
		}
		int num = 0;
		while (true)
		{
			if (num < loadedAssemblies.Count)
			{
				if (string.Compare("mscorlib", assemblyName.Name, StringComparison.OrdinalIgnoreCase) != 0)
				{
					if (CompareAssemblyNames(((Assembly)loadedAssemblies[num]).GetName(), assemblyName))
					{
						break;
					}
					num++;
					continue;
				}
				return true;
			}
			return false;
		}
		return true;
	}

	public static void DetermineAllReferencedAssemblies(ArrayList loadedAssemblies)
	{
		bool flag = false;
		while (!flag)
		{
			flag = true;
			for (int i = 0; i < loadedAssemblies.Count; i++)
			{
				AssemblyName[] referencedAssemblies = ((Assembly)loadedAssemblies[i]).GetReferencedAssemblies();
				for (int j = 0; j < referencedAssemblies.Length; j++)
				{
					if (!AlreadyLoaded(loadedAssemblies, referencedAssemblies[j]))
					{
						flag = false;
						loadedAssemblies.Add(Assembly.Load(referencedAssemblies[j]));
					}
				}
			}
		}
	}

	private static void CheckAddedAssemblies(PolicyLevel level, ref ArrayList assemblies)
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (assemblies == null || level == null)
			{
				return;
			}
			IEnumerator enumerator = assemblies.GetEnumerator();
			while (true)
			{
				if (!enumerator.MoveNext())
				{
					return;
				}
				Assembly assembly = (Assembly)enumerator.Current;
				StrongName val = FindStrongName(assembly.get_Evidence());
				if (val == null)
				{
					PauseCapableWriteLine(manager.GetString("Dialog_AssemblyNotStrongNamed"));
					if (!GetAnswer())
					{
						break;
					}
				}
				else
				{
					if (val.get_Name().Equals("mscorlib"))
					{
						continue;
					}
					IEnumerator enumerator2 = level.get_FullTrustAssemblies().GetEnumerator();
					bool flag = false;
					Evidence evidence = new Evidence();
					evidence.AddHost(val);
					while (enumerator2.MoveNext())
					{
						if (((StrongNameMembershipCondition)enumerator2.Current).Check(evidence))
						{
							flag = true;
							break;
						}
					}
					if (!flag)
					{
						PauseCapableWriteLine(manager.GetString("Dialog_StrongNameAssemblyAdded1"));
						PauseCapableWriteLine(val.get_Name() + " " + val.get_Version());
						PauseCapableWriteLine(manager.GetString("Dialog_StrongNameAssemblyAdded2"));
						if (GetAnswer())
						{
							level.AddFullTrustAssembly(val);
						}
					}
				}
			}
			throw new ExitException();
		}
		finally
		{
			assemblies = new ArrayList();
		}
	}

	private static bool IsWin9X()
	{
		return Environment.OSVersion.Platform == PlatformID.Win32Windows;
	}

	private static void DisableCodeAccessSecurity()
	{
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		if (!IsWin9X())
		{
			WindowsPrincipal windowsPrincipal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
			if (!windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator))
			{
				throw new Exception(manager.GetString("Error_AccessDeniedNonAdmin"));
			}
		}
		try
		{
			bool createdNew;
			Mutex mutex = new Mutex(initiallyOwned: true, (!IsWin9X()) ? "Global\\CLR_CASOFF_MUTEX" : "CLR_CASOFF_MUTEX", out createdNew);
			if (!IsWin9X())
			{
				MutexSecurity accessControl = mutex.GetAccessControl();
				((ObjectSecurity)(object)accessControl).SetOwner((IdentityReference)new SecurityIdentifier(WellKnownSidType.BuiltinAdministratorsSid, null));
				accessControl.AddAccessRule(new MutexAccessRule((IdentityReference)new SecurityIdentifier(WellKnownSidType.BuiltinUsersSid, null), (MutexRights)1048576, AccessControlType.Allow));
				mutex.SetAccessControl(accessControl);
			}
		}
		catch (ApplicationException)
		{
			throw new Exception(manager.GetString("Dialog_SecurityOff_Error"));
		}
	}

	private static void SafeSavePolicy()
	{
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected O, but got Unknown
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Invalid comparison between Unknown and I4
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Invalid comparison between Unknown and I4
		CheckAddedAssemblies(GetLevel((PolicyLevelType)2), ref m_enterpriseAssemblies);
		CheckAddedAssemblies(GetLevel((PolicyLevelType)1), ref m_machineAssemblies);
		CheckAddedAssemblies(GetLevel((PolicyLevelType)0), ref m_userAssemblies);
		CheckAddedAssemblies(m_currentCustomLevel, ref m_customUserAssemblies);
		if (!m_force)
		{
			PermissionSet permissionSet = null;
			PermissionSet permissionSet2 = null;
			try
			{
				permissionSet2 = SecurityManager.ResolvePolicy(Assembly.GetExecutingAssembly().get_Evidence(), (PermissionSet)null, (PermissionSet)null, (PermissionSet)null, ref permissionSet);
			}
			catch (PolicyException)
			{
			}
			PermissionSet permissionSet3 = GeneratecaspolRequiredPermSet();
			if (permissionSet2 == null || !permissionSet3.IsSubsetOf(permissionSet2) || (permissionSet != null && permissionSet3.Intersect(permissionSet) != null))
			{
				PauseCapableWriteLine(manager.GetString("Dialog_CaspolOperationRestricted"));
				m_success = false;
				throw new ExitException();
			}
		}
		IEnumerator enumerator = null;
		PolicyLevel level = GetLevel();
		if (level == null && m_levelType == LevelType.All)
		{
			enumerator = SecurityManager.PolicyHierarchy();
		}
		else if (level == null && m_levelType == LevelType.AllCustom)
		{
			ArrayList arrayList = new ArrayList();
			arrayList.Add(GetLevel((PolicyLevelType)2));
			arrayList.Add(GetLevel((PolicyLevelType)1));
			arrayList.Add(m_currentCustomLevel);
			enumerator = arrayList.GetEnumerator();
		}
		else if (level != null)
		{
			ArrayList arrayList2 = new ArrayList();
			arrayList2.Add(level);
			enumerator = arrayList2.GetEnumerator();
		}
		if (enumerator == null)
		{
			return;
		}
		if (PolicyPrompt && !Quiet)
		{
			PauseCapableWriteLine(manager.GetString("Dialog_AlterPolicy"));
			if (!GetAnswer())
			{
				PauseCapableWriteLine(manager.GetString("Dialog_PolicySaveAborted"));
				m_success = false;
				throw new ExitException();
			}
		}
		while (enumerator.MoveNext())
		{
			PolicyLevel val2 = (PolicyLevel)enumerator.Current;
			if (((int)val2.get_Type() == 1 || (int)val2.get_Type() == 2) && !IsWin9X())
			{
				WindowsPrincipal windowsPrincipal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
				if (!windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator))
				{
					throw new Exception(manager.GetString("Error_AccessDeniedNonAdmin"));
				}
			}
			SecurityManager.SavePolicyLevel(val2);
		}
		Quiet = false;
	}

	private static void MachineHandler(string[] args, int index, out int numArgsUsed)
	{
		numArgsUsed = 1;
		if (args[index].Equals("__internal_usage__"))
		{
			PauseCapableWriteLine(manager.GetString("Help_Option_Machine"));
			return;
		}
		m_danglingLevelIndicator = manager.GetString("OptionTable_Machine");
		m_levelPath = null;
		m_levelType = LevelType.Machine;
	}

	private static void UserHandler(string[] args, int index, out int numArgsUsed)
	{
		numArgsUsed = 1;
		if (args[index].Equals("__internal_usage__"))
		{
			PauseCapableWriteLine(manager.GetString("Help_Option_User"));
			return;
		}
		m_danglingLevelIndicator = manager.GetString("OptionTable_User");
		m_levelPath = null;
		m_levelType = LevelType.UserDefault;
	}

	private static void EnterpriseHandler(string[] args, int index, out int numArgsUsed)
	{
		numArgsUsed = 1;
		if (args[index].Equals("__internal_usage__"))
		{
			PauseCapableWriteLine(manager.GetString("Help_Option_Enterprise"));
			return;
		}
		m_danglingLevelIndicator = manager.GetString("OptionTable_Enterprise");
		m_levelPath = null;
		m_levelType = LevelType.Enterprise;
	}

	private static void CustomUserHandler(string[] args, int index, out int numArgsUsed)
	{
		numArgsUsed = 1;
		if (args[index].Equals("__internal_usage__"))
		{
			PauseCapableWriteLine(manager.GetString("Help_Option_CustomUser"));
			return;
		}
		numArgsUsed = 2;
		if (args.Length - index < 2)
		{
			Error(manager.GetString("OptionTable_CustomUser"), manager.GetString("Error_NotEnoughArgs"), -1);
		}
		m_danglingLevelIndicator = manager.GetString("OptionTable_CustomUser");
		m_levelPath = args[index + 1];
		m_levelType = LevelType.UserCustom;
		m_currentCustomLevel = null;
	}

	private static void AllHandler(string[] args, int index, out int numArgsUsed)
	{
		numArgsUsed = 1;
		if (args[index].Equals("__internal_usage__"))
		{
			PauseCapableWriteLine(manager.GetString("Help_Option_All"));
			return;
		}
		m_danglingLevelIndicator = manager.GetString("OptionTable_All");
		m_levelPath = null;
		m_levelType = LevelType.All;
	}

	private static void CustomAllHandler(string[] args, int index, out int numArgsUsed)
	{
		numArgsUsed = 1;
		if (args[index].Equals("__internal_usage__"))
		{
			PauseCapableWriteLine(manager.GetString("Help_Option_CustomAll"));
			return;
		}
		numArgsUsed = 2;
		if (args.Length - index < 2)
		{
			Error(manager.GetString("OptionTable_CustomAll"), manager.GetString("Error_NotEnoughArgs"), -1);
		}
		m_danglingLevelIndicator = manager.GetString("OptionTable_CustomAll");
		m_levelPath = args[index + 1];
		m_levelType = LevelType.AllCustom;
		m_currentCustomLevel = null;
	}

	private static void SecurityHandler(string[] args, int index, out int numArgsUsed)
	{
		if (args[index].Equals("__internal_usage__"))
		{
			numArgsUsed = 1;
			PauseCapableWriteLine(manager.GetString("Help_Option_Security"));
			return;
		}
		numArgsUsed = 2;
		if (args.Length - index < 2)
		{
			Error(manager.GetString("OptionTable_Security"), manager.GetString("Error_NotEnoughArgs"), -1);
		}
		if (string.Compare(args[index + 1], manager.GetString("Misc_On"), StringComparison.OrdinalIgnoreCase) == 0)
		{
			PauseCapableWriteLine(manager.GetString("Dialog_SecurityOn_Warning"));
		}
		else if (string.Compare(args[index + 1], manager.GetString("Misc_Off"), StringComparison.OrdinalIgnoreCase) == 0)
		{
			DisableCodeAccessSecurity();
			PauseCapableWriteLine(manager.GetString("Dialog_SecurityOff_Warning"));
			Console.ReadLine();
		}
		else
		{
			Error(manager.GetString("OptionTable_Security"), string.Format(CultureInfo.CurrentCulture, manager.GetString("Error_InvalidOption"), new object[1] { args[index + 1] }), -1);
		}
	}

	private static void ExecutionHandler(string[] args, int index, out int numArgsUsed)
	{
		if (args[index].Equals("__internal_usage__"))
		{
			numArgsUsed = 1;
			PauseCapableWriteLine(manager.GetString("Help_Option_Execution"));
			return;
		}
		numArgsUsed = 2;
		if (args.Length - index < 2)
		{
			Error(manager.GetString("OptionTable_Execution"), manager.GetString("Error_NotEnoughArgs"), -1);
		}
		if (string.Compare(args[index + 1], manager.GetString("Misc_On"), StringComparison.OrdinalIgnoreCase) == 0)
		{
			SecurityManager.set_CheckExecutionRights(true);
		}
		else if (string.Compare(args[index + 1], manager.GetString("Misc_Off"), StringComparison.OrdinalIgnoreCase) == 0)
		{
			SecurityManager.set_CheckExecutionRights(false);
		}
		else
		{
			Error(manager.GetString("OptionTable_Execution"), string.Format(CultureInfo.CurrentCulture, manager.GetString("Error_InvalidOption"), new object[1] { args[index + 1] }), -1);
		}
		SecurityManager.SavePolicy();
	}

	private static void BuildCacheHandler(string[] args, int index, out int numArgsUsed)
	{
		numArgsUsed = 1;
		if (args[index].Equals("__internal_usage__"))
		{
			PauseCapableWriteLine(manager.GetString("Help_Option_BuildCache"));
		}
		else
		{
			SecurityManager.SavePolicy();
		}
	}

	private static void PolicyChangeHandler(string[] args, int index, out int numArgsUsed)
	{
		if (args[index].Equals("__internal_usage__"))
		{
			numArgsUsed = 1;
			PauseCapableWriteLine(manager.GetString("Help_Option_PolChgPrompt"));
			return;
		}
		numArgsUsed = 2;
		if (args.Length - index < 2)
		{
			Error(manager.GetString("OptionTable_PolChgPrompt"), manager.GetString("Error_NotEnoughArgs"), -1);
		}
		if (string.Compare(args[index + 1], manager.GetString("Misc_On"), StringComparison.OrdinalIgnoreCase) == 0)
		{
			PolicyPrompt = true;
			return;
		}
		if (string.Compare(args[index + 1], manager.GetString("Misc_Off"), StringComparison.OrdinalIgnoreCase) == 0)
		{
			PolicyPrompt = false;
			return;
		}
		Error(manager.GetString("OptionTable_PolChgPrompt"), string.Format(CultureInfo.CurrentCulture, manager.GetString("Error_InvalidOption"), new object[1] { args[index + 1] }), -1);
	}

	private static void QuietHandler(string[] args, int index, out int numArgsUsed)
	{
		numArgsUsed = 1;
		if (args[index].Equals("__internal_usage__"))
		{
			PauseCapableWriteLine(manager.GetString("Help_Option_Quiet"));
		}
		else
		{
			Quiet = true;
		}
	}

	private static void RecoverHandler(string[] args, int index, out int numArgsUsed)
	{
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		numArgsUsed = 1;
		if (args[index].Equals("__internal_usage__"))
		{
			PauseCapableWriteLine(manager.GetString("Help_Option_Recover"));
			return;
		}
		IEnumerator enumerator = null;
		PolicyLevel level = GetLevel();
		if (level == null && m_levelType == LevelType.All)
		{
			enumerator = SecurityManager.PolicyHierarchy();
		}
		else if (level == null && m_levelType == LevelType.AllCustom)
		{
			ArrayList arrayList = new ArrayList();
			arrayList.Add(GetLevel((PolicyLevelType)2));
			arrayList.Add(GetLevel((PolicyLevelType)1));
			arrayList.Add(m_currentCustomLevel);
			enumerator = arrayList.GetEnumerator();
		}
		else if (level != null)
		{
			ArrayList arrayList2 = new ArrayList();
			arrayList2.Add(level);
			enumerator = arrayList2.GetEnumerator();
		}
		if (enumerator == null)
		{
			Error(manager.GetString("OptionTable_Recover"), manager.GetString("Error_UnableToRetrieveLevel"), -1);
		}
		try
		{
			while (enumerator.MoveNext())
			{
				((PolicyLevel)enumerator.Current).Recover();
			}
		}
		catch (Exception ex)
		{
			string text = ex.Message;
			if (text == null || text.Equals(""))
			{
				text = ex.GetType().AssemblyQualifiedName;
			}
			Error(manager.GetString("OptionTable_Recover"), text, -1);
		}
	}

	private static void ResetHandler(string[] args, int index, out int numArgsUsed)
	{
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		numArgsUsed = 1;
		if (args[index].Equals("__internal_usage__"))
		{
			PauseCapableWriteLine(manager.GetString("Help_Option_Reset"));
			return;
		}
		IEnumerator enumerator = null;
		PolicyLevel level = GetLevel();
		if (level == null && m_levelType == LevelType.All)
		{
			enumerator = SecurityManager.PolicyHierarchy();
		}
		else if (level == null && m_levelType == LevelType.AllCustom)
		{
			ArrayList arrayList = new ArrayList();
			arrayList.Add(GetLevel((PolicyLevelType)2));
			arrayList.Add(GetLevel((PolicyLevelType)1));
			arrayList.Add(m_currentCustomLevel);
			enumerator = arrayList.GetEnumerator();
		}
		else if (level != null)
		{
			ArrayList arrayList2 = new ArrayList();
			arrayList2.Add(level);
			enumerator = arrayList2.GetEnumerator();
		}
		if (enumerator == null)
		{
			Error(manager.GetString("OptionTable_Reset"), manager.GetString("Error_UnableToRetrieveLevel"), -1);
		}
		try
		{
			while (enumerator.MoveNext())
			{
				PolicyLevel val = (PolicyLevel)enumerator.Current;
				PauseCapableWriteLine(string.Format(CultureInfo.CurrentCulture, manager.GetString("Dialog_ResettingPolicy"), new object[1] { val.get_Label() }));
				val.Reset();
			}
		}
		catch (Exception ex)
		{
			string text = ex.Message;
			if (string.IsNullOrEmpty(text))
			{
				text = ex.GetType().AssemblyQualifiedName;
			}
			Error(manager.GetString("OptionTable_Reset"), text, -1);
		}
		SafeSavePolicy();
		try
		{
			ResetClickOnceSettings();
		}
		catch
		{
		}
	}

	private static void ResetLockDownHandler(string[] args, int index, out int numArgsUsed)
	{
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Invalid comparison between Unknown and I4
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected O, but got Unknown
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected O, but got Unknown
		numArgsUsed = 1;
		if (args[index].Equals("__internal_usage__"))
		{
			PauseCapableWriteLine(manager.GetString("Help_Option_ResetLockDown"));
			return;
		}
		IEnumerator enumerator = null;
		PolicyLevel level = GetLevel();
		if (level == null && m_levelType == LevelType.All)
		{
			enumerator = SecurityManager.PolicyHierarchy();
		}
		else if (level == null && m_levelType == LevelType.AllCustom)
		{
			ArrayList arrayList = new ArrayList();
			arrayList.Add(GetLevel((PolicyLevelType)2));
			arrayList.Add(GetLevel((PolicyLevelType)1));
			arrayList.Add(m_currentCustomLevel);
			enumerator = arrayList.GetEnumerator();
		}
		else if (level != null)
		{
			ArrayList arrayList2 = new ArrayList();
			arrayList2.Add(level);
			enumerator = arrayList2.GetEnumerator();
		}
		if (enumerator == null)
		{
			Error(manager.GetString("OptionTable_ResetLockDown"), manager.GetString("Error_UnableToRetrieveLevel"), -1);
		}
		try
		{
			while (enumerator.MoveNext())
			{
				PolicyLevel val = (PolicyLevel)enumerator.Current;
				PauseCapableWriteLine(string.Format(CultureInfo.CurrentCulture, manager.GetString("Dialog_ResettingPolicy"), new object[1] { val.get_Label() }));
				val.Reset();
				if ((int)val.get_Type() != 1)
				{
					continue;
				}
				CodeGroup rootCodeGroup = val.get_RootCodeGroup();
				int num = 0;
				ArrayList arrayList3 = new ArrayList();
				foreach (CodeGroup child in rootCodeGroup.get_Children())
				{
					CodeGroup val2 = child;
					num++;
					switch (num)
					{
					default:
						arrayList3.Add(val2);
						break;
					case 2:
					case 3:
					case 5:
						val2.set_PolicyStatement(new PolicyStatement((PermissionSet)(object)val.GetNamedPermissionSet("Nothing")));
						val2.set_Children((IList)new ArrayList());
						arrayList3.Add(val2);
						break;
					}
				}
				rootCodeGroup.set_Children((IList)arrayList3);
				val.set_RootCodeGroup(rootCodeGroup);
			}
		}
		catch (Exception ex)
		{
			string text = ex.Message;
			if (string.IsNullOrEmpty(text))
			{
				text = ex.GetType().AssemblyQualifiedName;
			}
			Error(manager.GetString("OptionTable_ResetLockDown"), text, -1);
		}
		SafeSavePolicy();
		try
		{
			ResetClickOnceSettings();
		}
		catch
		{
		}
	}

	private static void ResetClickOnceSettings()
	{
		ApplicationSecurityManager.get_UserApplicationTrusts().Clear();
		if (File.Exists(TrustManagerConfigurationFile))
		{
			File.Delete(TrustManagerConfigurationFile);
		}
		if (File.Exists(TrustManagerConfigurationFile + ".default"))
		{
			File.Copy(TrustManagerConfigurationFile + ".default", TrustManagerConfigurationFile);
		}
	}

	private static void ForceHandler(string[] args, int index, out int numArgsUsed)
	{
		numArgsUsed = 1;
		if (args[index].Equals("__internal_usage__"))
		{
			PauseCapableWriteLine(manager.GetString("Help_Option_Force"));
		}
		else
		{
			m_force = true;
		}
	}

	private static void HelpHandler(string[] args, int index, out int numArgsUsed)
	{
		numArgsUsed = 1;
		if (args[index].Equals("__internal_usage__"))
		{
			PauseCapableWriteLine(manager.GetString("Help_Option_Help"));
			return;
		}
		try
		{
			screenPauseEnabled = true;
			m_success = false;
			Help("*", manager.GetString("Dialog_HelpScreen"));
		}
		finally
		{
			screenPauseEnabled = false;
		}
	}

	private static void DisplayLevelCodeGroups(PolicyLevel level)
	{
		DisplayCodeGroups(level.get_RootCodeGroup(), level.get_RootCodeGroup());
	}

	private static void DisplayCodeGroups(CodeGroup displayGroup, CodeGroup rootGroup)
	{
		string text = "1";
		PauseCapableWriteLine(text + ".  " + (displayGroup.get_MergeLogic().Equals(manager.GetString("Misc_MergeUnion")) ? "" : ("(" + displayGroup.get_MergeLogic() + ") ")) + displayGroup.get_MembershipCondition().ToString() + ": " + ((displayGroup.get_PermissionSetName() == null) ? manager.GetString("Dialog_Unknown") : displayGroup.get_PermissionSetName()) + ((displayGroup.get_AttributeString() == null || displayGroup.get_AttributeString().Equals("")) ? "" : (" (" + displayGroup.get_AttributeString() + ")")));
		if (displayGroup == rootGroup)
		{
			ListCodeGroup(text, "   ", displayGroup.get_Children().GetEnumerator(), null);
		}
		else
		{
			ListCodeGroup(text, "   ", displayGroup.get_Children().GetEnumerator(), rootGroup.get_Children().GetEnumerator());
		}
	}

	private static void DisplayLevelCodeGroupNameDescriptions(PolicyLevel level)
	{
		DisplayCodeGroupNameDescriptions(level.get_RootCodeGroup());
	}

	private static void DisplayCodeGroupNameDescriptions(CodeGroup group)
	{
		string text = "1";
		PauseCapableWriteLine(text + ". " + ((group.get_Name() == null || group.get_Name().Equals("")) ? manager.GetString("Dialog_NoLabel") : group.get_Name()) + ": " + ((group.get_Description() == null || group.get_Description().Equals("")) ? manager.GetString("Dialog_NoDescription") : group.get_Description()));
		ListCodeGroupNameDescription(text, "   ", group.get_Children().GetEnumerator());
	}

	private static void DisplayLevelPermissionSets(PolicyLevel level)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		IEnumerator enumerator = level.get_NamedPermissionSets().GetEnumerator();
		int num = 1;
		while (enumerator.MoveNext())
		{
			NamedPermissionSet val = (NamedPermissionSet)enumerator.Current;
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(num + ". " + val.get_Name());
			if (val.get_Description() != null && !val.get_Description().Equals(""))
			{
				stringBuilder.Append(" (" + val.get_Description() + ")");
			}
			stringBuilder.Append(" =" + Environment.NewLine + FormatXmlString(((PermissionSet)(object)val).ToXml()!.ToString()) + Environment.NewLine);
			PauseCapableWriteLine(stringBuilder.ToString());
			num++;
		}
	}

	private static void DisplayLevelFullTrustAssemblies(PolicyLevel level)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		IEnumerator enumerator = level.get_FullTrustAssemblies().GetEnumerator();
		int num = 1;
		while (enumerator.MoveNext())
		{
			StrongNameMembershipCondition val = (StrongNameMembershipCondition)enumerator.Current;
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(num + ". ");
			if (val.get_Name() != null)
			{
				stringBuilder.Append(" " + val.get_Name());
			}
			if ((object)val.get_Version() != null)
			{
				stringBuilder.Append(" " + val.get_Version());
			}
			stringBuilder.Append(" =" + Environment.NewLine + ((object)val).ToString());
			PauseCapableWriteLine(stringBuilder.ToString());
			num++;
		}
	}

	private static void DisplaySecurityOnOff()
	{
		PauseCapableWriteLine(string.Format(CultureInfo.CurrentCulture, manager.GetString("Dialog_SecurityIs"), new object[1] { manager.GetString(SecurityManager.get_SecurityEnabled() ? "Misc_OnCap" : "Misc_OffCap") }));
		PauseCapableWriteLine(string.Format(CultureInfo.CurrentCulture, manager.GetString("Dialog_ExecutionCheckingIs"), new object[1] { manager.GetString(SecurityManager.get_CheckExecutionRights() ? "Misc_OnCap" : "Misc_OffCap") }));
		try
		{
			PauseCapableWriteLine(string.Format(CultureInfo.CurrentCulture, manager.GetString("Dialog_PolicyChangePromptIs"), new object[1] { manager.GetString(PolicyPrompt ? "Misc_OnCap" : "Misc_OffCap") }));
		}
		catch (Exception)
		{
			PauseCapableWriteLine(manager.GetString("Dialog_UnableToDisplayChangePrompt"));
		}
	}

	private static void ListHandler(string[] args, int index, out int numArgsUsed)
	{
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		numArgsUsed = 1;
		if (args[index].Equals("__internal_usage__"))
		{
			PauseCapableWriteLine(manager.GetString("Help_Option_List"));
			return;
		}
		IEnumerator enumerator = null;
		PolicyLevel level = GetLevel();
		if (level == null && m_levelType == LevelType.All)
		{
			enumerator = SecurityManager.PolicyHierarchy();
		}
		else if (level == null && m_levelType == LevelType.AllCustom)
		{
			ArrayList arrayList = new ArrayList();
			arrayList.Add(GetLevel((PolicyLevelType)2));
			arrayList.Add(GetLevel((PolicyLevelType)1));
			arrayList.Add(m_currentCustomLevel);
			enumerator = arrayList.GetEnumerator();
		}
		else if (level != null)
		{
			ArrayList arrayList2 = new ArrayList();
			arrayList2.Add(level);
			enumerator = arrayList2.GetEnumerator();
		}
		if (enumerator == null)
		{
			Error(manager.GetString("OptionTable_List"), manager.GetString("Error_UnableToRetrieveLevel"), -1);
		}
		DisplaySecurityOnOff();
		try
		{
			while (enumerator.MoveNext())
			{
				PolicyLevel val = (PolicyLevel)enumerator.Current;
				PauseCapableWriteLine(Environment.NewLine + string.Format(CultureInfo.CurrentCulture, manager.GetString("Dialog_Level"), new object[1] { val.get_Label() }));
				PauseCapableWriteLine(Environment.NewLine + manager.GetString("Dialog_CodeGroups") + Environment.NewLine);
				DisplayLevelCodeGroups(val);
				PauseCapableWriteLine(Environment.NewLine + manager.GetString("Dialog_NamedPermissionSets") + Environment.NewLine);
				DisplayLevelPermissionSets(val);
				PauseCapableWriteLine(Environment.NewLine + manager.GetString("Dialog_FullTrustAssemblies") + Environment.NewLine);
				DisplayLevelFullTrustAssemblies(val);
			}
		}
		catch (Exception ex)
		{
			Error(manager.GetString("OptionTable_List"), ex.Message, -1);
		}
	}

	private static void ListGroupHandler(string[] args, int index, out int numArgsUsed)
	{
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		numArgsUsed = 1;
		if (args[index].Equals("__internal_usage__"))
		{
			PauseCapableWriteLine(manager.GetString("Help_Option_ListGroups"));
			return;
		}
		IEnumerator enumerator = null;
		PolicyLevel level = GetLevel();
		if (level == null && m_levelType == LevelType.All)
		{
			enumerator = SecurityManager.PolicyHierarchy();
		}
		else if (level == null && m_levelType == LevelType.AllCustom)
		{
			ArrayList arrayList = new ArrayList();
			arrayList.Add(GetLevel((PolicyLevelType)2));
			arrayList.Add(GetLevel((PolicyLevelType)1));
			arrayList.Add(m_currentCustomLevel);
			enumerator = arrayList.GetEnumerator();
		}
		else if (level != null)
		{
			ArrayList arrayList2 = new ArrayList();
			arrayList2.Add(level);
			enumerator = arrayList2.GetEnumerator();
		}
		if (enumerator == null)
		{
			Error(manager.GetString("OptionTable_ListGroups"), manager.GetString("Error_UnableToRetrieveLevel"), -1);
		}
		DisplaySecurityOnOff();
		try
		{
			while (enumerator.MoveNext())
			{
				PolicyLevel val = (PolicyLevel)enumerator.Current;
				PauseCapableWriteLine(Environment.NewLine + string.Format(CultureInfo.CurrentCulture, manager.GetString("Dialog_Level"), new object[1] { val.get_Label() }));
				PauseCapableWriteLine(Environment.NewLine + manager.GetString("Dialog_CodeGroups") + Environment.NewLine);
				DisplayLevelCodeGroups(val);
			}
		}
		catch (Exception ex)
		{
			Error(manager.GetString("OptionTable_ListGroups"), ex.Message, -1);
		}
	}

	private static void ListPermHandler(string[] args, int index, out int numArgsUsed)
	{
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		numArgsUsed = 1;
		if (args[index].Equals("__internal_usage__"))
		{
			PauseCapableWriteLine(manager.GetString("Help_Option_ListPSet"));
			return;
		}
		IEnumerator enumerator = null;
		PolicyLevel level = GetLevel();
		if (level == null && m_levelType == LevelType.All)
		{
			enumerator = SecurityManager.PolicyHierarchy();
		}
		else if (level == null && m_levelType == LevelType.AllCustom)
		{
			ArrayList arrayList = new ArrayList();
			arrayList.Add(GetLevel((PolicyLevelType)2));
			arrayList.Add(GetLevel((PolicyLevelType)1));
			arrayList.Add(m_currentCustomLevel);
			enumerator = arrayList.GetEnumerator();
		}
		else if (level != null)
		{
			ArrayList arrayList2 = new ArrayList();
			arrayList2.Add(level);
			enumerator = arrayList2.GetEnumerator();
		}
		if (enumerator == null)
		{
			Error(manager.GetString("OptionTable_ListPset"), manager.GetString("Error_UnableToRetrieveLevel"), -1);
		}
		DisplaySecurityOnOff();
		try
		{
			while (enumerator.MoveNext())
			{
				PolicyLevel val = (PolicyLevel)enumerator.Current;
				PauseCapableWriteLine(Environment.NewLine + string.Format(CultureInfo.CurrentCulture, manager.GetString("Dialog_Level"), new object[1] { val.get_Label() }));
				PauseCapableWriteLine(Environment.NewLine + manager.GetString("Dialog_NamedPermissionSets") + Environment.NewLine);
				DisplayLevelPermissionSets(val);
			}
		}
		catch (Exception ex)
		{
			Error(manager.GetString("OptionTable_ListPset"), ex.Message, -1);
		}
	}

	private static void ListFullTrustHandler(string[] args, int index, out int numArgsUsed)
	{
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		numArgsUsed = 1;
		if (args[index].Equals("__internal_usage__"))
		{
			PauseCapableWriteLine(manager.GetString("Help_Option_ListFullTrust"));
			return;
		}
		IEnumerator enumerator = null;
		PolicyLevel level = GetLevel();
		if (level == null && m_levelType == LevelType.All)
		{
			enumerator = SecurityManager.PolicyHierarchy();
		}
		else if (level == null && m_levelType == LevelType.AllCustom)
		{
			ArrayList arrayList = new ArrayList();
			arrayList.Add(GetLevel((PolicyLevelType)2));
			arrayList.Add(GetLevel((PolicyLevelType)1));
			arrayList.Add(m_currentCustomLevel);
			enumerator = arrayList.GetEnumerator();
		}
		else if (level != null)
		{
			ArrayList arrayList2 = new ArrayList();
			arrayList2.Add(level);
			enumerator = arrayList2.GetEnumerator();
		}
		if (enumerator == null)
		{
			Error(manager.GetString("OptionTable_ListFullTrust"), manager.GetString("Error_UnableToRetrieveLevel"), -1);
		}
		DisplaySecurityOnOff();
		try
		{
			while (enumerator.MoveNext())
			{
				PolicyLevel val = (PolicyLevel)enumerator.Current;
				PauseCapableWriteLine(Environment.NewLine + string.Format(CultureInfo.CurrentCulture, manager.GetString("Dialog_Level"), new object[1] { val.get_Label() }));
				PauseCapableWriteLine(Environment.NewLine + manager.GetString("Dialog_FullTrustAssemblies") + Environment.NewLine);
				DisplayLevelFullTrustAssemblies(val);
			}
		}
		catch (Exception ex)
		{
			Error(manager.GetString("OptionTable_ListFullTrust"), ex.Message, -1);
		}
	}

	private static void ListDescriptionHandler(string[] args, int index, out int numArgsUsed)
	{
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		numArgsUsed = 1;
		if (args[index].Equals("__internal_usage__"))
		{
			PauseCapableWriteLine(manager.GetString("Help_Option_ListDescription"));
			return;
		}
		IEnumerator enumerator = null;
		PolicyLevel level = GetLevel();
		if (level == null && m_levelType == LevelType.All)
		{
			enumerator = SecurityManager.PolicyHierarchy();
		}
		else if (level == null && m_levelType == LevelType.AllCustom)
		{
			ArrayList arrayList = new ArrayList();
			arrayList.Add(GetLevel((PolicyLevelType)2));
			arrayList.Add(GetLevel((PolicyLevelType)1));
			arrayList.Add(m_currentCustomLevel);
			enumerator = arrayList.GetEnumerator();
		}
		else if (level != null)
		{
			ArrayList arrayList2 = new ArrayList();
			arrayList2.Add(level);
			enumerator = arrayList2.GetEnumerator();
		}
		if (enumerator == null)
		{
			Error(manager.GetString("OptionTable_ListDescription"), manager.GetString("Error_UnableToRetrieveLevel"), -1);
		}
		DisplaySecurityOnOff();
		try
		{
			while (enumerator.MoveNext())
			{
				PolicyLevel val = (PolicyLevel)enumerator.Current;
				PauseCapableWriteLine(Environment.NewLine + string.Format(CultureInfo.CurrentCulture, manager.GetString("Dialog_Level"), new object[1] { val.get_Label() }));
				PauseCapableWriteLine(Environment.NewLine + manager.GetString("Dialog_CodeGroups") + Environment.NewLine);
				DisplayLevelCodeGroupNameDescriptions(val);
			}
		}
		catch (Exception ex)
		{
			Error(manager.GetString("OptionTable_ListDescription"), ex.Message, -1);
		}
	}

	private static void ListCodeGroup(string prefix, string indent, IEnumerator dispEnumerator, IEnumerator rootEnumerator)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		if (dispEnumerator == null)
		{
			return;
		}
		int num = 0;
		CodeGroup val = null;
		while (dispEnumerator.MoveNext())
		{
			CodeGroup val2 = (CodeGroup)dispEnumerator.Current;
			if (rootEnumerator == null)
			{
				num++;
			}
			else
			{
				do
				{
					if (!rootEnumerator.MoveNext())
					{
						Error(manager.GetString("OptionTable_ResolveGroup"), manager.GetString("Error_CodeGroup_NoMatch"), -1);
					}
					val = (CodeGroup)rootEnumerator.Current;
					num++;
				}
				while (!((object)val).Equals((object?)val2));
			}
			string text = prefix + "." + num;
			PauseCapableWriteLine(indent + text + ".  " + (val2.get_MergeLogic().Equals(manager.GetString("Misc_MergeUnion")) ? "" : ("(" + val2.get_MergeLogic() + ") ")) + ((val2.get_MembershipCondition() == null) ? ((object)val2).GetType().FullName : val2.get_MembershipCondition().ToString()) + ": " + ((val2.get_PermissionSetName() == null) ? manager.GetString("Dialog_Unknown") : val2.get_PermissionSetName()) + ((val2.get_AttributeString() == null || val2.get_AttributeString().Equals("")) ? "" : (" (" + val2.get_AttributeString() + ")")));
			if (rootEnumerator == null)
			{
				ListCodeGroup(text, indent + "   ", val2.get_Children().GetEnumerator(), null);
			}
			else
			{
				ListCodeGroup(text, indent + "   ", val2.get_Children().GetEnumerator(), val.get_Children().GetEnumerator());
			}
		}
	}

	private static void ListCodeGroupNameDescription(string prefix, string indent, IEnumerator enumerator)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		if (enumerator != null)
		{
			int num = 1;
			while (enumerator.MoveNext())
			{
				string text = prefix + "." + num;
				CodeGroup val = (CodeGroup)enumerator.Current;
				PauseCapableWriteLine(indent + text + ". " + ((val.get_Name() == null || val.get_Name().Equals("")) ? manager.GetString("Dialog_NoLabel") : val.get_Name()) + ": " + ((val.get_Description() == null || val.get_Description().Equals("")) ? manager.GetString("Dialog_NoDescription") : val.get_Description()));
				ListCodeGroupNameDescription(text, indent + "   ", val.get_Children().GetEnumerator());
				num++;
			}
		}
	}

	private static void CheckFullTrustHandler(string[] args, int index, out int numArgsUsed)
	{
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		numArgsUsed = 1;
		if (args[index].Equals("__internal_usage__"))
		{
			PauseCapableWriteLine(manager.GetString("Help_Option_CheckFullTrust"));
			return;
		}
		IEnumerator enumerator = null;
		PolicyLevel level = GetLevel();
		if (level == null && m_levelType == LevelType.All)
		{
			enumerator = SecurityManager.PolicyHierarchy();
		}
		else if (level == null && m_levelType == LevelType.AllCustom)
		{
			ArrayList arrayList = new ArrayList();
			arrayList.Add(GetLevel((PolicyLevelType)2));
			arrayList.Add(GetLevel((PolicyLevelType)1));
			arrayList.Add(m_currentCustomLevel);
			enumerator = arrayList.GetEnumerator();
		}
		else if (level != null)
		{
			ArrayList arrayList2 = new ArrayList();
			arrayList2.Add(level);
			enumerator = arrayList2.GetEnumerator();
		}
		if (enumerator == null)
		{
			Error(manager.GetString("OptionTable_CheckFullTrust"), manager.GetString("Error_UnableToRetrieveLevel"), -1);
		}
		try
		{
			while (enumerator.MoveNext())
			{
				bool flag = false;
				PolicyLevel val = (PolicyLevel)enumerator.Current;
				SecurityManager.SavePolicyLevel(val);
				Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
				for (int i = 0; i < assemblies.Length; i++)
				{
					AssemblyName name = assemblies[i].GetName();
					if (string.Compare(name.Name, "caspol", StringComparison.OrdinalIgnoreCase) == 0)
					{
						continue;
					}
					if (string.Compare(name.Name, "mscorlib", StringComparison.OrdinalIgnoreCase) != 0 && !IsFullTrustAssembly(val.get_FullTrustAssemblies(), assemblies[i].get_Evidence()))
					{
						IEnumerator hostEnumerator = assemblies[i].get_Evidence().GetHostEnumerator();
						StrongName val2 = null;
						while (hostEnumerator.MoveNext())
						{
							object current = hostEnumerator.Current;
							val2 = (StrongName)((current is StrongName) ? current : null);
							if (val2 != null)
							{
								break;
							}
						}
						if (val2 == null)
						{
							Error(manager.GetString("OptionTable_CheckFullTrust"), manager.GetString("Dialog_AssemblyNotStrongNamed"), -1);
						}
						else
						{
							val.AddFullTrustAssembly(val2);
							flag = true;
						}
					}
					MakeResourceAssemblyEvidence(assemblies[i].get_Evidence(), out var output, out var outputSn);
					if (!IsFullTrustAssembly(val.get_FullTrustAssemblies(), output))
					{
						if (outputSn == null)
						{
							Error(manager.GetString("OptionTable_CheckFullTrust"), manager.GetString("Dialog_AssemblyNotStrongNamed"), -1);
							continue;
						}
						val.AddFullTrustAssembly(outputSn);
						flag = true;
					}
				}
				if (flag)
				{
					SecurityManager.SavePolicyLevel(val);
				}
			}
		}
		catch (Exception ex)
		{
			Error(manager.GetString("OptionTable_CheckFullTrust"), ex.Message, -1);
		}
	}

	internal static bool IsFullTrustAssembly(IList fullTrustAssemblies, Evidence evidence)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		if (fullTrustAssemblies.Count == 0)
		{
			return false;
		}
		GacMembershipCondition val = new GacMembershipCondition();
		if (evidence != null)
		{
			lock (fullTrustAssemblies)
			{
				IEnumerator enumerator = fullTrustAssemblies.GetEnumerator();
				while (enumerator.MoveNext())
				{
					StrongNameMembershipCondition val2 = (StrongNameMembershipCondition)enumerator.Current;
					if (val2.Check(evidence) && val.Check(evidence))
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	internal static void MakeResourceAssemblyEvidence(Evidence input, out Evidence output, out StrongName outputSn)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		IEnumerator hostEnumerator = input.GetHostEnumerator();
		output = new Evidence();
		outputSn = null;
		while (hostEnumerator.MoveNext())
		{
			if (hostEnumerator.Current is StrongName)
			{
				StrongName val = (StrongName)hostEnumerator.Current;
				outputSn = new StrongName(val.get_PublicKey(), val.get_Name() + ".resource", val.get_Version());
				output.AddHost(outputSn);
			}
			else
			{
				output.AddHost(hostEnumerator.Current);
			}
		}
		hostEnumerator = input.GetAssemblyEnumerator();
		while (hostEnumerator.MoveNext())
		{
			output.AddAssembly(hostEnumerator.Current);
		}
	}

	private static void AddPermHandler(string[] args, int index, out int numArgsUsed)
	{
		if (args[index].Equals("__internal_usage__"))
		{
			numArgsUsed = 1;
			PauseCapableWriteLine(manager.GetString("Help_Option_AddPSet"));
			return;
		}
		numArgsUsed = 2;
		if (args.Length - index < 2)
		{
			Error(manager.GetString("OptionTable_AddPset"), manager.GetString("Error_NotEnoughArgs"), -1);
			return;
		}
		PolicyLevel level = GetLevel();
		if (level == null)
		{
			if (m_levelType != LevelType.All && m_levelType != LevelType.AllCustom)
			{
				Error(manager.GetString("OptionTable_AddPset"), manager.GetString("Error_UnableToRetrieveLevel"), -1);
			}
			else
			{
				Error(manager.GetString("OptionTable_AddPset"), string.Format(CultureInfo.CurrentCulture, manager.GetString("Dialog_NotValidWithAll"), new object[1] { manager.GetString("OptionTable_All") }), -1);
			}
		}
		NamedPermissionSet val = null;
		try
		{
			val = GetPermissionSet(args, index + 1);
		}
		catch (Exception innerException)
		{
			if (innerException is TargetInvocationException)
			{
				innerException = innerException.InnerException;
			}
			string text = innerException.Message;
			if (text == null || text.Equals(""))
			{
				text = innerException.GetType().AssemblyQualifiedName;
			}
			Error(manager.GetString("OptionTable_AddPset"), text, -1);
		}
		IEnumerator enumerator = ((PermissionSet)(object)val).GetEnumerator();
		while (enumerator.MoveNext())
		{
			m_levelAssemblyList.Add(enumerator.Current.GetType().Module.Assembly);
		}
		if (args.Length - index > 2)
		{
			bool flag = false;
			for (int i = 0; i < OptionTable.Length; i++)
			{
				if (string.Compare(OptionTable[i].option, args[index + 2], StringComparison.OrdinalIgnoreCase) == 0)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				val.set_Name(args[index + 2]);
				numArgsUsed = 3;
			}
		}
		if (val.get_Name() == null || val.get_Name().Equals(""))
		{
			Error(manager.GetString("OptionTable_AddPset"), manager.GetString("Error_PermSet_NoName"), -1);
		}
		try
		{
			level.AddNamedPermissionSet(val);
		}
		catch (Exception)
		{
			Error(manager.GetString("OptionTable_AddPset"), manager.GetString("Error_PermSet_AlreadyExist"), -1);
			return;
		}
		SafeSavePolicy();
	}

	private static void AddFullTrustHandler(string[] args, int index, out int numArgsUsed)
	{
		if (args[index].Equals("__internal_usage__"))
		{
			numArgsUsed = 1;
			PauseCapableWriteLine(manager.GetString("Help_Option_AddFullTrust"));
			return;
		}
		numArgsUsed = 2;
		if (args.Length - index < 2)
		{
			Error(manager.GetString("OptionTable_AddFullTrust"), manager.GetString("Error_NotEnoughArgs"), -1);
			return;
		}
		PolicyLevel level = GetLevel();
		if (level == null)
		{
			if (m_levelType != LevelType.All && m_levelType != LevelType.AllCustom)
			{
				Error(manager.GetString("OptionTable_AddFullTrust"), manager.GetString("Error_UnableToRetrieveLevel"), -1);
			}
			else
			{
				Error(manager.GetString("OptionTable_AddFullTrust"), string.Format(CultureInfo.CurrentCulture, manager.GetString("Dialog_NotValidWithAll"), new object[1] { manager.GetString("OptionTable_All") }), -1);
			}
		}
		CaspolAssembly caspolAssembly = LoadAssembly(args[index + 1], manager.GetString("OptionTable_AddFullTrust"));
		if (caspolAssembly == null)
		{
			Error(manager.GetString("OptionTable_AddFullTrust"), manager.GetString("Error_UnableToLoadAssembly"), -1);
		}
		StrongName val = FindStrongName(caspolAssembly.Evidence);
		if (val == null)
		{
			Error(manager.GetString("OptionTable_AddFullTrust"), manager.GetString("Error_NotStrongNamed"), -1);
		}
		try
		{
			PauseCapableWriteLine(manager.GetString("Warning_DeprecatedFullTrustList"));
			level.AddFullTrustAssembly(val);
		}
		catch (Exception)
		{
			Error(manager.GetString("OptionTable_AddFullTrust"), manager.GetString("Error_FullTrust_AlreadyFullTrust"), -1);
		}
		SafeSavePolicy();
	}

	private static void ChgPermHandler(string[] args, int index, out int numArgsUsed)
	{
		if (args[index].Equals("__internal_usage__"))
		{
			numArgsUsed = 1;
			PauseCapableWriteLine(manager.GetString("Help_Option_ChgPSet"));
			return;
		}
		numArgsUsed = 3;
		if (args.Length - index < 3)
		{
			Error(manager.GetString("OptionTable_ChgPSet"), manager.GetString("Error_NotEnoughArgs"), -1);
			return;
		}
		PolicyLevel level = GetLevel();
		if (level == null)
		{
			if (m_levelType != LevelType.All && m_levelType != LevelType.AllCustom)
			{
				Error(manager.GetString("OptionTable_ChgPSet"), manager.GetString("Error_UnableToRetrieveLevel"), -1);
			}
			else
			{
				Error(manager.GetString("OptionTable_ChgPSet"), string.Format(CultureInfo.CurrentCulture, manager.GetString("Dialog_NotValidWithAll"), new object[1] { manager.GetString("OptionTable_All") }), -1);
			}
		}
		NamedPermissionSet val = null;
		try
		{
			val = GetPermissionSet(args, index + 1);
		}
		catch (Exception ex)
		{
			string text = ex.Message;
			if (text == null || text.Equals(""))
			{
				text = ex.GetType().AssemblyQualifiedName;
			}
			Error(manager.GetString("OptionTable_ChgPSet"), text, -1);
		}
		try
		{
			level.ChangeNamedPermissionSet(args[index + 2], (PermissionSet)(object)val);
		}
		catch (Exception ex2)
		{
			string text2 = ex2.Message;
			if (text2 == null || text2.Equals(""))
			{
				text2 = ex2.GetType().AssemblyQualifiedName;
			}
			Error(manager.GetString("OptionTable_ChgPSet"), text2, -1);
		}
		SafeSavePolicy();
	}

	private static void RemPermHandler(string[] args, int index, out int numArgsUsed)
	{
		if (args[index].Equals("__internal_usage__"))
		{
			numArgsUsed = 1;
			PauseCapableWriteLine(manager.GetString("Help_Option_RemPSet"));
			return;
		}
		numArgsUsed = 2;
		if (args.Length - index < 2)
		{
			Error(manager.GetString("OptionTable_RemPSet"), manager.GetString("Error_NotEnoughArgs"), -1);
			return;
		}
		PolicyLevel level = GetLevel();
		if (level == null)
		{
			if (m_levelType != LevelType.All && m_levelType != LevelType.AllCustom)
			{
				Error(manager.GetString("OptionTable_RemPSet"), manager.GetString("Error_UnableToRetrieveLevel"), -1);
			}
			else
			{
				Error(manager.GetString("OptionTable_RemPSet"), string.Format(CultureInfo.CurrentCulture, manager.GetString("Dialog_NotValidWithAll"), new object[1] { manager.GetString("OptionTable_All") }), -1);
			}
		}
		PermissionSet permissionSet = null;
		try
		{
			permissionSet = (PermissionSet)(object)level.RemoveNamedPermissionSet(args[index + 1]);
		}
		catch (Exception ex)
		{
			string text = ex.Message;
			if (text == null || text.Equals(""))
			{
				text = ex.GetType().AssemblyQualifiedName;
			}
			Error(manager.GetString("OptionTable_RemPSet"), text, -1);
		}
		if (permissionSet != null)
		{
			SafeSavePolicy();
			return;
		}
		Error(manager.GetString("OptionTable_RemPSet"), string.Format(CultureInfo.CurrentCulture, manager.GetString("Error_PermSet_DoesNotExist"), new object[1] { args[index + 1] }), -1);
	}

	private static void RemFullTrustHandler(string[] args, int index, out int numArgsUsed)
	{
		if (args[index].Equals("__internal_usage__"))
		{
			numArgsUsed = 1;
			PauseCapableWriteLine(manager.GetString("Help_Option_RemFullTrust"));
			return;
		}
		numArgsUsed = 2;
		if (args.Length - index < 2)
		{
			Error(manager.GetString("OptionTable_RemFullTrust"), manager.GetString("Error_NotEnoughArgs"), -1);
			return;
		}
		PolicyLevel level = GetLevel();
		if (level == null)
		{
			if (m_levelType != LevelType.All && m_levelType != LevelType.AllCustom)
			{
				Error(manager.GetString("OptionTable_RemFullTrust"), manager.GetString("Error_UnableToRetrieveLevel"), -1);
			}
			else
			{
				Error(manager.GetString("OptionTable_RemFullTrust"), string.Format(CultureInfo.CurrentCulture, manager.GetString("Dialog_NotValidWithAll"), new object[1] { manager.GetString("OptionTable_All") }), -1);
			}
		}
		CaspolAssembly caspolAssembly = LoadAssembly(args[index + 1], manager.GetString("OptionTable_RemFullTrust"));
		if (caspolAssembly == null)
		{
			Error(manager.GetString("OptionTable_RemFullTrust"), manager.GetString("Error_UnableToLoadAssembly"), -1);
		}
		StrongName val = FindStrongName(caspolAssembly.Evidence);
		if (val == null)
		{
			Error(manager.GetString("OptionTable_RemFullTrust"), manager.GetString("Error_NotStrongNamed"), -1);
		}
		try
		{
			PauseCapableWriteLine(manager.GetString("Warning_DeprecatedFullTrustList"));
			level.RemoveFullTrustAssembly(val);
		}
		catch (Exception ex)
		{
			string text = ex.Message;
			if (text == null || text.Equals(""))
			{
				text = ex.GetType().AssemblyQualifiedName;
			}
			Error(manager.GetString("OptionTable_RemFullTrust"), text, -1);
		}
		SafeSavePolicy();
	}

	private static void RemGroupHandler(string[] args, int index, out int numArgsUsed)
	{
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Expected O, but got Unknown
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Expected O, but got Unknown
		if (args[index].Equals("__internal_usage__"))
		{
			numArgsUsed = 1;
			PauseCapableWriteLine(manager.GetString("Help_Option_RemGroup"));
			return;
		}
		numArgsUsed = 2;
		if (args.Length - index < 2)
		{
			Error(manager.GetString("OptionTable_RemGroup"), manager.GetString("Error_NotEnoughArgs"), -1);
			return;
		}
		object obj = null;
		object obj2 = null;
		try
		{
			obj = GetLabel(args[index + 1]);
		}
		catch (Exception ex)
		{
			if (ex is SecurityException)
			{
				Error(manager.GetString("OptionTable_RemGroup"), manager.GetString("Error_PolicyPermissionDenied"), -1);
			}
			else
			{
				Error(manager.GetString("OptionTable_RemGroup"), manager.GetString("Error_InvalidLabel"), -1);
			}
			return;
		}
		if (obj == null)
		{
			if (m_levelType != LevelType.All && m_levelType != LevelType.AllCustom)
			{
				Error(manager.GetString("OptionTable_RemGroup"), manager.GetString("Error_InvalidLabel"), -1);
				return;
			}
			Error(manager.GetString("OptionTable_RemGroup"), string.Format(CultureInfo.CurrentCulture, manager.GetString("Dialog_NotValidWithAll"), new object[1] { manager.GetString("OptionTable_All") }), -1);
			return;
		}
		if (!(obj is CodeGroup))
		{
			Error(manager.GetString("OptionTable_RemGroup"), manager.GetString("Error_CodeGroup_MustBeCodeGroup"), -1);
			return;
		}
		string label = ParentLabel(args[index + 1]);
		try
		{
			obj2 = GetLabel(label);
		}
		catch (Exception)
		{
			Error(manager.GetString("OptionTable_RemGroup"), manager.GetString("Error_InvalidLabel"), -1);
			return;
		}
		if (obj2 == null)
		{
			Error(manager.GetString("OptionTable_RemGroup"), manager.GetString("Error_InvalidLabel"), -1);
			return;
		}
		if (!(obj2 is CodeGroup))
		{
			Error(manager.GetString("OptionTable_RemGroup"), manager.GetString("Error_CodeGroup_MustBeCodeGroup"), -1);
			return;
		}
		PolicyLevel level = GetLevel();
		string numericLabel = null;
		object labelByName = GetLabelByName(args[index + 1], level.get_RootCodeGroup(), ref numericLabel);
		if (labelByName == null || numericLabel == null)
		{
			numericLabel = args[index + 1];
		}
		string[] array = numericLabel.Split(new char[1] { '.' });
		int num = ((array[^1] == null || array[^1].Length == 0) ? int.Parse(array[^2], CultureInfo.InvariantCulture) : int.Parse(array[^1], CultureInfo.InvariantCulture));
		IEnumerator enumerator = ((CodeGroup)obj2).get_Children().GetEnumerator();
		((CodeGroup)obj2).set_Children((IList)new ArrayList());
		int num2 = 1;
		while (enumerator.MoveNext())
		{
			if (num2 != num)
			{
				((CodeGroup)obj2).AddChild((CodeGroup)enumerator.Current);
			}
			num2++;
		}
		ReplaceLabel(label, (CodeGroup)obj2);
		SafeSavePolicy();
		PauseCapableWriteLine(string.Format(CultureInfo.CurrentCulture, manager.GetString("Dialog_RemovedCodeGroup"), new object[1] { GetLevel().get_Label() }));
	}

	private static void AddGroupHandler(string[] args, int index, out int numArgsUsed)
	{
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected O, but got Unknown
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected O, but got Unknown
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected O, but got Unknown
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Expected O, but got Unknown
		if (args[index].Equals("__internal_usage__"))
		{
			numArgsUsed = 1;
			PauseCapableWriteLine(manager.GetString("Help_Option_AddGroup"));
			return;
		}
		numArgsUsed = 2;
		if (args.Length - index < 4)
		{
			Error(manager.GetString("OptionTable_AddGroup"), manager.GetString("Error_NotEnoughArgs"), -1);
			return;
		}
		object obj = null;
		PolicyLevel level = GetLevel();
		if (level == null)
		{
			if (m_levelType != LevelType.All && m_levelType != LevelType.AllCustom)
			{
				Error(manager.GetString("OptionTable_AddGroup"), manager.GetString("Error_UnableToRetrieveLevel"), -1);
			}
			else
			{
				Error(manager.GetString("OptionTable_AddGroup"), string.Format(CultureInfo.CurrentCulture, manager.GetString("Dialog_NotValidWithAll"), new object[1] { manager.GetString("OptionTable_All") }), -1);
			}
		}
		try
		{
			obj = GetLabel(args[index + 1]);
		}
		catch (Exception ex)
		{
			if (ex is SecurityException)
			{
				Error(manager.GetString("OptionTable_AddGroup"), manager.GetString("Error_PolicyPermissionDenied"), -1);
			}
			else
			{
				Error(manager.GetString("OptionTable_AddGroup"), manager.GetString("Error_InvalidLabel"), -1);
			}
			return;
		}
		if (obj == null)
		{
			if (m_levelType != LevelType.All && m_levelType != LevelType.AllCustom)
			{
				Error(manager.GetString("OptionTable_AddGroup"), manager.GetString("Error_InvalidLabel"), -1);
				return;
			}
			Error(manager.GetString("OptionTable_AddGroup"), string.Format(CultureInfo.CurrentCulture, manager.GetString("Dialog_NotValidWithAll"), new object[1] { manager.GetString("OptionTable_All") }), -1);
			return;
		}
		if (!(obj is CodeGroup))
		{
			Error(manager.GetString("OptionTable_AddGroup"), manager.GetString("Error_CodeGroup_MustBeCodeGroup"), -1);
			return;
		}
		int offset = 0;
		int argsUsed = 0;
		IMembershipCondition membershipCondition = CreateMembershipCondition(level, args, index + 2, out offset);
		if (args.Length <= index + 2 + offset)
		{
			Error(manager.GetString("OptionTable_AddGroup"), manager.GetString("Error_CodeGroup_NoPermissionSet"), -1);
			return;
		}
		CodeGroup val = null;
		try
		{
			val = (CodeGroup)new UnionCodeGroup((IMembershipCondition)new AllMembershipCondition(), (PolicyStatement)null);
			val.set_MembershipCondition(membershipCondition);
			PolicyStatement val2 = new PolicyStatement((PermissionSet)(object)GetPermissionSet(level, args[index + 2 + offset]), (PolicyStatementAttribute)0);
			val2.set_Attributes(IsExclusive(val, args, index + 3 + offset, out argsUsed));
			val.set_PolicyStatement(val2);
		}
		catch (Exception ex2)
		{
			string text = ex2.Message;
			if (text == null || text.Equals(""))
			{
				text = ex2.GetType().AssemblyQualifiedName;
			}
			Error(manager.GetString("OptionTable_AddGroup"), text, -1);
		}
		((CodeGroup)obj).AddChild(val);
		ReplaceLabel(args[index + 1], (CodeGroup)obj);
		SafeSavePolicy();
		PauseCapableWriteLine(string.Format(CultureInfo.CurrentCulture, manager.GetString("Dialog_AddedCodeGroup"), new object[2]
		{
			args[index + 2],
			level.get_Label()
		}));
		numArgsUsed = offset + argsUsed + 3;
	}

	private static void ChgGroupHandler(string[] args, int index, out int numArgsUsed)
	{
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected O, but got Unknown
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Expected O, but got Unknown
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_042a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0440: Unknown result type (might be due to invalid IL or missing references)
		//IL_045a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0470: Unknown result type (might be due to invalid IL or missing references)
		if (args[index].Equals("__internal_usage__"))
		{
			numArgsUsed = 1;
			PauseCapableWriteLine(manager.GetString("Help_Option_ChgGroup"));
			return;
		}
		numArgsUsed = 2;
		if (args.Length - index < 3)
		{
			Error(manager.GetString("OptionTable_ChgGroup"), manager.GetString("Error_NotEnoughArgs"), -1);
			return;
		}
		object obj = null;
		PolicyLevel level = GetLevel();
		if (level == null)
		{
			if (m_levelType != LevelType.All && m_levelType != LevelType.AllCustom)
			{
				Error(manager.GetString("OptionTable_ChgGroup"), manager.GetString("Error_UnableToRetrieveLevel"), -1);
			}
			else
			{
				Error(manager.GetString("OptionTable_ChgGroup"), string.Format(CultureInfo.CurrentCulture, manager.GetString("Dialog_NotValidWithAll"), new object[1] { manager.GetString("OptionTable_All") }), -1);
			}
		}
		try
		{
			obj = GetLabel(args[index + 1]);
		}
		catch (Exception ex)
		{
			if (ex is SecurityException)
			{
				Error(manager.GetString("OptionTable_ChgGroup"), manager.GetString("Error_PolicyPermissionDenied"), -1);
			}
			else
			{
				Error(manager.GetString("OptionTable_ChgGroup"), manager.GetString("Error_InvalidLabel"), -1);
			}
			return;
		}
		if (obj == null)
		{
			if (m_levelType != LevelType.All && m_levelType != LevelType.AllCustom)
			{
				Error(manager.GetString("OptionTable_ChgGroup"), manager.GetString("Error_InvalidLabel"), -1);
				return;
			}
			Error(manager.GetString("OptionTable_ChgGroup"), string.Format(CultureInfo.CurrentCulture, manager.GetString("Dialog_NotValidWithAll"), new object[1] { manager.GetString("OptionTable_All") }), -1);
			return;
		}
		if (!(obj is CodeGroup))
		{
			Error(manager.GetString("OptionTable_ChgGroup"), manager.GetString("Error_CodeGroup_MustBeCodeGroup"), -1);
			return;
		}
		CodeGroup val = (CodeGroup)obj;
		bool flag = false;
		StringBuilder stringBuilder = new StringBuilder();
		while (true)
		{
			int offset = 0;
			if (args.Length - index <= numArgsUsed)
			{
				break;
			}
			int i;
			for (i = 0; i < OptionTable.Length && string.Compare(args[index + numArgsUsed], OptionTable[i].option, StringComparison.OrdinalIgnoreCase) != 0; i++)
			{
			}
			if (i != OptionTable.Length)
			{
				break;
			}
			IMembershipCondition val2 = CreateMembershipConditionNoThrow(level, args, index + numArgsUsed, out offset);
			if (val2 != null && offset != 0)
			{
				val.set_MembershipCondition(val2);
				if (flag)
				{
					stringBuilder.Append(Environment.NewLine);
				}
				stringBuilder.Append(string.Format(CultureInfo.CurrentCulture, manager.GetString("Dialog_ChangedCodeGroupMembershipCondition"), new object[2]
				{
					args[index + numArgsUsed],
					level.get_Label()
				}));
				numArgsUsed += offset;
				flag = true;
				continue;
			}
			PolicyStatementAttribute val3 = (PolicyStatementAttribute)0;
			val3 = IsExclusive((CodeGroup)obj, args, index + numArgsUsed, out offset);
			if (offset != 0)
			{
				PolicyStatement policyStatement = val.get_PolicyStatement();
				policyStatement.set_Attributes(val3);
				val.set_PolicyStatement(policyStatement);
				if (flag)
				{
					stringBuilder.Append(Environment.NewLine);
				}
				if (val.get_AttributeString() != null && !val.get_AttributeString().Equals(""))
				{
					stringBuilder.Append(string.Format(CultureInfo.CurrentCulture, manager.GetString("Dialog_ChangedCodeGroupAttributes2"), new object[2]
					{
						val.get_AttributeString(),
						level.get_Label()
					}));
				}
				else
				{
					stringBuilder.Append(string.Format(CultureInfo.CurrentCulture, manager.GetString("Dialog_ChangedCodeGroupAttributes1"), new object[1] { level.get_Label() }));
				}
				numArgsUsed += offset;
				flag = true;
				continue;
			}
			PermissionSet permissionSet = null;
			try
			{
				permissionSet = (PermissionSet)(object)GetPermissionSet(level, args[index + numArgsUsed]);
			}
			catch (Exception ex2)
			{
				string text = ex2.Message;
				if (text == null || text.Equals(""))
				{
					text = ex2.GetType().AssemblyQualifiedName;
				}
				Error(manager.GetString("OptionTable_ChgGroup"), text, -1);
			}
			if (permissionSet != null)
			{
				if (val is UnionCodeGroup)
				{
					PolicyStatement policyStatement2 = ((CodeGroup)(UnionCodeGroup)val).get_PolicyStatement();
					policyStatement2.set_PermissionSet(permissionSet);
					((CodeGroup)(UnionCodeGroup)val).set_PolicyStatement(policyStatement2);
				}
				else if (val is FirstMatchCodeGroup)
				{
					PolicyStatement policyStatement3 = ((CodeGroup)(FirstMatchCodeGroup)val).get_PolicyStatement();
					policyStatement3.set_PermissionSet(permissionSet);
					((CodeGroup)(FirstMatchCodeGroup)val).set_PolicyStatement(policyStatement3);
				}
				else if (val is FileCodeGroup)
				{
					Error(manager.GetString("OptionTable_ChgGroup"), manager.GetString("Error_CodeGroup_FileNoEffect"), -1);
				}
				else if (val is NetCodeGroup)
				{
					Error(manager.GetString("OptionTable_ChgGroup"), manager.GetString("Error_CodeGroup_NetNoEffect"), -1);
				}
				else
				{
					Error(manager.GetString("OptionTable_ChgGroup"), manager.GetString("Dialog_BuiltInOnly"), -1);
				}
				if (flag)
				{
					stringBuilder.Append(Environment.NewLine);
				}
				stringBuilder.Append(string.Format(CultureInfo.CurrentCulture, manager.GetString("Dialog_ChangedCodeGroupPermissionSet"), new object[2]
				{
					args[index + numArgsUsed],
					level.get_Label()
				}));
				numArgsUsed++;
				flag = true;
			}
			else
			{
				if (flag)
				{
					break;
				}
				Error(manager.GetString("OptionTable_ChgGroup"), string.Format(CultureInfo.CurrentCulture, manager.GetString("Error_CodeGroup_UnrecognizedOption"), new object[1] { args[index + 2] }), -1);
			}
		}
		ReplaceLabel(args[index + 1], val);
		SafeSavePolicy();
		PauseCapableWriteLine(stringBuilder.ToString());
	}

	private static CaspolAssembly LoadAssembly(string fileName, string option)
	{
		return LoadAssembly(fileName, option, errorOnFail: true);
	}

	private static CaspolAssembly LoadAssembly(string fileName, string option, bool errorOnFail)
	{
		AppDomain appDomain = AppDomain.CreateDomain("Caspol Domain", (Evidence)null, Environment.CurrentDirectory, Thread.GetDomain().BaseDirectory, false);
		if (appDomain == null)
		{
			Error(option, manager.GetString("Error_UnableToLoadAssembly"), -1);
		}
		CaspolAssembly caspolAssembly = (CaspolAssembly)appDomain.CreateInstanceFromAndUnwrap(Assembly.GetExecutingAssembly().CodeBase, "Microsoft.Tools.Caspol.CaspolAssembly", false, BindingFlags.Instance | BindingFlags.Public | BindingFlags.CreateInstance, (Binder)null, new object[1] { fileName }, (CultureInfo)null, (object[])null, (Evidence)null);
		if (caspolAssembly.Error && errorOnFail)
		{
			Error(option, manager.GetString("Error_UnableToLoadAssembly"), -1);
		}
		return caspolAssembly;
	}

	private static Evidence GenerateShellEvidence(string fileName, string option)
	{
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected O, but got Unknown
		Evidence evidence = LoadAssembly(fileName, option, errorOnFail: false)?.Evidence;
		if (evidence != null)
		{
			return evidence;
		}
		string text = null;
		try
		{
			text = Path.GetFullPath(fileName);
		}
		catch (Exception)
		{
			Error(option, manager.GetString("Error_UnableToLoadAssembly"), -1);
		}
		if (text == null || !File.Exists(text))
		{
			Error(option, manager.GetString("Error_UnableToLoadAssembly"), -1);
		}
		if (PolicyPrompt)
		{
			PauseCapableWriteLine(string.Format(CultureInfo.CurrentCulture, manager.GetString("Dialog_UseFakeEvidenceQuestion"), new object[1] { fileName }));
			if (!GetAnswer())
			{
				PauseCapableWriteLine(manager.GetString("Dialog_OperationAborted"));
				throw new ExitException();
			}
		}
		else
		{
			PauseCapableWriteLine(string.Format(CultureInfo.CurrentCulture, manager.GetString("Dialog_UseFakeEvidence"), new object[1] { fileName }));
		}
		string text2 = "file:///" + text;
		Evidence evidence2 = new Evidence();
		evidence2.AddHost(Zone.CreateFromUrl(text2));
		evidence2.AddHost((object)new Url(text2));
		return evidence2;
	}

	private static void ResolveGroupHandler(string[] args, int index, out int numArgsUsed)
	{
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		if (args[index].Equals("__internal_usage__"))
		{
			numArgsUsed = 1;
			PauseCapableWriteLine(manager.GetString("Help_Option_ResolveGroup"));
			return;
		}
		numArgsUsed = 2;
		if (args.Length - index < 2)
		{
			Error(manager.GetString("OptionTable_ResolveGroup"), manager.GetString("Error_NotEnoughArgs"), -1);
		}
		IEnumerator enumerator = null;
		PolicyLevel val = ((m_levelType == LevelType.None) ? null : GetLevel(m_levelType));
		if (val == null && (m_levelType == LevelType.All || m_levelType == LevelType.None))
		{
			enumerator = SecurityManager.PolicyHierarchy();
		}
		else if (val == null && m_levelType == LevelType.AllCustom)
		{
			ArrayList arrayList = new ArrayList();
			arrayList.Add(GetLevel((PolicyLevelType)2));
			arrayList.Add(GetLevel((PolicyLevelType)1));
			arrayList.Add(m_currentCustomLevel);
			enumerator = arrayList.GetEnumerator();
		}
		else if (val != null)
		{
			ArrayList arrayList2 = new ArrayList();
			arrayList2.Add(val);
			enumerator = arrayList2.GetEnumerator();
		}
		if (enumerator == null)
		{
			Error(manager.GetString("OptionTable_ResolveGroup"), manager.GetString("Error_UnableToRetrieveLevel"), -1);
		}
		Evidence evidence = GenerateShellEvidence(args[index + 1], manager.GetString("OptionTable_ResolveGroup"));
		while (enumerator.MoveNext())
		{
			PauseCapableWriteLine(Environment.NewLine + string.Format(CultureInfo.CurrentCulture, manager.GetString("Dialog_Level"), new object[1] { ((PolicyLevel)enumerator.Current).get_Label() }));
			PauseCapableWriteLine(Environment.NewLine + manager.GetString("Dialog_CodeGroups") + Environment.NewLine);
			CodeGroup displayGroup = ((PolicyLevel)enumerator.Current).ResolveMatchingCodeGroups(evidence);
			CodeGroup rootCodeGroup = ((PolicyLevel)enumerator.Current).get_RootCodeGroup();
			DisplayCodeGroups(displayGroup, rootCodeGroup);
			PauseCapableWriteLine("");
		}
	}

	private static void ResolvePermHandler(string[] args, int index, out int numArgsUsed)
	{
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Invalid comparison between Unknown and I4
		if (args[index].Equals("__internal_usage__"))
		{
			numArgsUsed = 1;
			PauseCapableWriteLine(manager.GetString("Help_Option_ResolvePerm"));
			return;
		}
		numArgsUsed = 2;
		if (args.Length - index < 2)
		{
			Error(manager.GetString("OptionTable_ResolvePerm"), manager.GetString("Error_NotEnoughArgs"), -1);
		}
		IEnumerator enumerator = null;
		PolicyLevel val = ((m_levelType == LevelType.None) ? null : GetLevel(m_levelType));
		if (val == null && (m_levelType == LevelType.All || m_levelType == LevelType.None))
		{
			enumerator = SecurityManager.PolicyHierarchy();
		}
		else if (val == null && m_levelType == LevelType.AllCustom)
		{
			ArrayList arrayList = new ArrayList();
			arrayList.Add(GetLevel((PolicyLevelType)2));
			arrayList.Add(GetLevel((PolicyLevelType)1));
			arrayList.Add(m_currentCustomLevel);
			enumerator = arrayList.GetEnumerator();
		}
		else if (val != null)
		{
			ArrayList arrayList2 = new ArrayList();
			arrayList2.Add(val);
			enumerator = arrayList2.GetEnumerator();
		}
		if (enumerator == null)
		{
			Error(manager.GetString("OptionTable_ResolvePerm"), manager.GetString("Error_UnableToRetrieveLevel"), -1);
		}
		Evidence evidence = GenerateShellEvidence(args[index + 1], manager.GetString("OptionTable_ResolvePerm"));
		PermissionSet permissionSet = null;
		while (enumerator.MoveNext())
		{
			PauseCapableWriteLine("Resolving permissions for level = " + ((PolicyLevel)enumerator.Current).get_Label());
			PolicyStatement val2 = ((PolicyLevel)enumerator.Current).Resolve(evidence);
			if (val2 != null)
			{
				permissionSet = ((permissionSet != null) ? permissionSet.Intersect(val2.get_PermissionSet()) : val2.get_PermissionSet());
				if (permissionSet == null)
				{
					permissionSet = new PermissionSet(PermissionState.None);
				}
				if ((int)val2.get_Attributes() == 2)
				{
					break;
				}
			}
			else
			{
				permissionSet = new PermissionSet(PermissionState.None);
			}
		}
		IEnumerator enumerator2 = evidence.GetEnumerator();
		while (enumerator2.MoveNext())
		{
			try
			{
				object current = enumerator2.Current;
				IIdentityPermissionFactory val3 = (IIdentityPermissionFactory)((current is IIdentityPermissionFactory) ? current : null);
				if (val3 != null)
				{
					IPermission permission = val3.CreateIdentityPermission(evidence);
					if (permission != null)
					{
						permissionSet.AddPermission(permission);
					}
				}
			}
			catch (Exception)
			{
			}
		}
		PauseCapableWriteLine(Environment.NewLine + manager.GetString("Dialog_Grant") + Environment.NewLine + permissionSet.ToString());
	}

	private static SecurityElement ReadXmlFile(string[] args, int index)
	{
		FileStream fileStream;
		try
		{
			fileStream = new FileStream(args[index], FileMode.Open, FileAccess.Read);
		}
		catch (Exception)
		{
			throw new Exception(manager.GetString("Error_File_UnableToOpenFile"));
		}
		Encoding[] array = new Encoding[3]
		{
			Encoding.UTF8,
			Encoding.ASCII,
			Encoding.Unicode
		};
		bool flag = false;
		Exception ex2 = null;
		SecurityElement result = null;
		int num = 0;
		while (!flag && num < array.Length)
		{
			try
			{
				fileStream.Position = 0L;
				StreamReader streamReader = new StreamReader(fileStream, array[num], detectEncodingFromByteOrderMarks: true);
				result = SecurityElement.FromString(streamReader.ReadToEnd());
				flag = true;
			}
			catch (Exception ex3)
			{
				if (ex2 == null)
				{
					ex2 = ex3;
				}
			}
			num++;
		}
		fileStream.Close();
		if (!flag)
		{
			throw ex2;
		}
		return result;
	}

	private static NamedPermissionSet GetPermissionSet(string[] args, int index)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		NamedPermissionSet val = new NamedPermissionSet("@@no name@@");
		((PermissionSet)(object)val).FromXml(ReadXmlFile(args, index));
		return val;
	}

	private static NamedPermissionSet GetPermissionSet(PolicyLevel level, string name)
	{
		NamedPermissionSet namedPermissionSet = level.GetNamedPermissionSet(name);
		if (namedPermissionSet == null)
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, manager.GetString("Error_UnknownPermissionSet"), new object[1] { name }));
		}
		return namedPermissionSet;
	}

	private static string FormatXmlString(string inputXml)
	{
		StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture);
		XmlTextReader xmlTextReader = new XmlTextReader(new StringReader(inputXml));
		xmlTextReader.WhitespaceHandling = WhitespaceHandling.None;
		xmlTextReader.Normalization = true;
		XmlTextWriter xmlTextWriter = new XmlTextWriter(stringWriter);
		xmlTextWriter.Formatting = Formatting.Indented;
		xmlTextWriter.Indentation = 4;
		xmlTextWriter.WriteNode(xmlTextReader, defattr: true);
		xmlTextWriter.Close();
		return stringWriter.ToString();
	}
}
