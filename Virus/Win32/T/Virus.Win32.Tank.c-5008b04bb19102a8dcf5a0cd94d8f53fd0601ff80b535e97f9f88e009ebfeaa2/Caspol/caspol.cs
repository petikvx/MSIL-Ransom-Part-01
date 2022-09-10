using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Security;
using System.Security.Permissions;
using System.Security.Policy;
using System.Text;
using System.Threading;

namespace Caspol;

public class caspol
{
	private const string m_indent = "   ";

	private const string m_labelSeparators = ".";

	private const string m_policyKey = "Software\\Microsoft\\.NETFramework\\v1.0.3705\\Security\\Policy";

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

	private static OptionTableEntry[] optionTable = new OptionTableEntry[60]
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
		new OptionTableEntry(manager.GetString("OptionTable_Recover"), RecoverHandler, null, list: true),
		new OptionTableEntry(manager.GetString("OptionTable_RecoverAbbr"), RecoverHandler, manager.GetString("OptionTable_Recover"), list: false),
		new OptionTableEntry(manager.GetString("OptionTable_Reset"), ResetHandler, null, list: true),
		new OptionTableEntry(manager.GetString("OptionTable_ResetAbbr"), ResetHandler, manager.GetString("OptionTable_Reset"), list: true),
		new OptionTableEntry(manager.GetString("OptionTable_Force"), ForceHandler, null, list: true),
		new OptionTableEntry(manager.GetString("OptionTable_ForceAbbr"), ForceHandler, manager.GetString("OptionTable_Force"), list: false),
		new OptionTableEntry(manager.GetString("OptionTable_BuildCache"), BuildCacheHandler, null, list: true),
		new OptionTableEntry(manager.GetString("OptionTable_BuildCacheAbbr"), BuildCacheHandler, manager.GetString("OptionTable_BuildCache"), list: false),
		new OptionTableEntry(manager.GetString("OptionTable_Help"), HelpHandler, null, list: true),
		new OptionTableEntry(manager.GetString("OptionTable_HelpAbbr1"), HelpHandler, manager.GetString("OptionTable_Help"), list: false),
		new OptionTableEntry(manager.GetString("OptionTable_HelpAbbr2"), HelpHandler, manager.GetString("OptionTable_Help"), list: true),
		new OptionTableEntry(manager.GetString("OptionTable_HelpAbbr3"), HelpHandler, manager.GetString("OptionTable_Help"), list: true)
	};

	private static MembershipConditionTableEntry[] mshipTable = new MembershipConditionTableEntry[9]
	{
		new MembershipConditionTableEntry(manager.GetString("MembershipConditionTable_All"), AllMembershipConditionHandler),
		new MembershipConditionTableEntry(manager.GetString("MembershipConditionTable_AppDir"), ApplicationDirectoryMembershipConditionHandler),
		new MembershipConditionTableEntry(manager.GetString("MembershipConditionTable_Custom"), CustomMembershipConditionHandler),
		new MembershipConditionTableEntry(manager.GetString("MembershipConditionTable_Hash"), HashMembershipConditionHandler),
		new MembershipConditionTableEntry(manager.GetString("MembershipConditionTable_Pub"), PublisherMembershipConditionHandler),
		new MembershipConditionTableEntry(manager.GetString("MembershipConditionTable_Site"), SiteMembershipConditionHandler),
		new MembershipConditionTableEntry(manager.GetString("MembershipConditionTable_Strong"), StrongNameMembershipConditionHandler),
		new MembershipConditionTableEntry(manager.GetString("MembershipConditionTable_Url"), URLMembershipConditionHandler),
		new MembershipConditionTableEntry(manager.GetString("MembershipConditionTable_Zone"), ZoneMembershipConditionHandler)
	};

	private static CodeGroupAttributeTableEntry[] cgAttrTable = new CodeGroupAttributeTableEntry[6]
	{
		new CodeGroupAttributeTableEntry(manager.GetString("CodeGroupAttributeTable_Exclusive"), (PolicyStatementAttribute)1, "Set the policy statement Exclusive flag"),
		new CodeGroupAttributeTableEntry(manager.GetString("CodeGroupAttributeTable_LevelFinal"), (PolicyStatementAttribute)2, "Set the policy statement LevelFinal flag"),
		new CodeGroupAttributeTableEntry(manager.GetString("CodeGroupAttributeTable_Name"), CodeGroupNameHandler, display: true),
		new CodeGroupAttributeTableEntry(manager.GetString("CodeGroupAttributeTable_NameAbbr"), CodeGroupNameHandler, display: false),
		new CodeGroupAttributeTableEntry(manager.GetString("CodeGroupAttributeTable_Description"), CodeGroupDescriptionHandler, display: true),
		new CodeGroupAttributeTableEntry(manager.GetString("CodeGroupAttributeTable_DescriptionAbbr"), CodeGroupDescriptionHandler, display: false)
	};

	private static string[] s_names = new string[5] { "MyComputer", "Intranet", "Trusted", "Internet", "Untrusted" };

	private static bool screenPauseEnabled = false;

	private static readonly int ScreenHeight = 23;

	private static int linesSeen = 0;

	private static extern bool PolicyPrompt { get; set; }

	private static extern void PauseCapableWriteLine(string msg);

	private unsafe static string GenerateHeader()
	{
		//IL_000f: Expected O, but got I8
		double num = (double)/*Error near IL_0002: Stack underflow*/;
		*(short*)7 = 7;
		_ = (long)num;
		/*OpCode not supported: DebugBreak*/;
		_ = 7;
		/*Error near IL_000c: stloc 1 (out-of-bounds)*/;
		/*Error near IL_000e: Invalid metadata token*/;
	}

	public static extern void Main(string[] args);

	private static extern string[] NormalizeArguments(string[] args);

	private static extern bool TestArgument(string arg);

	private static extern string[] NormalizeArgument(string arg);

	private static extern void Run(string[] args);

	private static extern PermissionSet GeneratecaspolRequiredPermSet();

	private static extern int ConvertHexDigit(char val);

	public unsafe static byte[] DecodeHexString(string hexString)
	{
		//Discarded unreachable code: IL_0002, IL_0007, IL_0009, IL_000e, IL_0012
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xFF*/;
	}

	private static extern void CodeGroupNameHandler(CodeGroup group, string[] args, int index, out int offset);

	private static extern void CodeGroupDescriptionHandler(CodeGroup group, string[] args, int index, out int offset);

	private static extern PolicyStatementAttribute IsExclusive(CodeGroup group, string[] args, int index, out int argsUsed);

	private static extern IMembershipCondition CreateMembershipCondition(PolicyLevel level, string[] args, int index, out int offset);

	private static extern IMembershipCondition CreateMembershipConditionNoThrow(PolicyLevel level, string[] args, int index, out int offset);

	private static extern IMembershipCondition AllMembershipConditionHandler(PolicyLevel level, string[] args, int index, out int offset);

	private static extern IMembershipCondition ApplicationDirectoryMembershipConditionHandler(PolicyLevel level, string[] args, int index, out int offset);

	private static extern IMembershipCondition CustomMembershipConditionHandler(PolicyLevel level, string[] args, int index, out int offset);

	private static IMembershipCondition HashMembershipConditionHandler(PolicyLevel level, string[] args, int index, out int offset)
	{
		//Discarded unreachable code: IL_0006, IL_0012, IL_001d, IL_0023
		//IL_000d: Invalid comparison between Unknown and I4
		//IL_0019: Expected O, but got Unknown
		//IL_0027: Expected native int or pointer, but got O
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Invalid comparison between Unknown and I
		/*Error: stloc 3 (out-of-bounds)*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	private static extern IMembershipCondition PublisherMembershipConditionHandler(PolicyLevel level, string[] args, int index, out int offset);

	private static IMembershipCondition SiteMembershipConditionHandler(PolicyLevel level, string[] args, int index, out int offset)
	{
		//Discarded unreachable code: IL_000e, IL_0017, IL_001c, IL_0022
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		/*Error: stloc 2 (out-of-bounds)*/;
		_003F val = /*Error near IL_0001: ldloc 2 (out-of-bounds)*/;
		_003F val2 = /*Error near IL_0007: Stack underflow*/* (val + (ushort)(ref level));
		_003F val3 = /*Error near IL_0008: Stack underflow*/- val2;
		_ = /*Error near IL_0009: Stack underflow*/% val3;
		/*Error near IL_0009: Invalid metadata token*/;
	}

	private static extern IMembershipCondition StrongNameMembershipConditionHandler(PolicyLevel level, string[] args, int index, out int offset);

	private static extern IMembershipCondition URLMembershipConditionHandler(PolicyLevel level, string[] args, int index, out int offset);

	private static extern IMembershipCondition ZoneMembershipConditionHandler(PolicyLevel level, string[] args, int index, out int offset);

	private static extern PolicyLevel GetLevel(string label);

	private static extern PolicyLevel GetLevel();

	private static extern PolicyLevel GetLevel(LevelType type);

	private static extern string ParentLabel(string label);

	private static extern void ReplaceLabel(string label, CodeGroup obj);

	private static extern object GetLabel(string label);

	private static extern object GetLabelByName(string label, CodeGroup group, ref string numericLabel);

	private static extern object GetLabelByNameHelper(string label, CodeGroup group, ref string numericLabel);

	private static extern bool DisplayMShipInfo(string which);

	private static extern void Error(string which, string message, int errorCode);

	private static extern void ErrorMShip(string whichOption, string whichMShip, string message, int errorCode);

	private static extern void ErrorMShip(string whichOption, string whichMShip, string message, int errorCode, bool displayMshipInfo);

	private static extern void Help(string which, string message);

	private static extern void Help(string which, string message, bool displayMshipInfo);

	private static extern void HelpMShip(string whichOption, string whichMShip, string message);

	private static extern void HelpMShip(string whichOption, string whichMShip, string message, bool displayMShipInfo);

	private static extern StrongName FindStrongName(Evidence evidence);

	private static extern bool GetAnswer();

	private static extern void CheckAddedAssemblies(PolicyLevel level, ref ArrayList assemblies);

	private static extern void SafeSavePolicy();

	private static extern void MachineHandler(string[] args, int index, out int numArgsUsed);

	private static extern void UserHandler(string[] args, int index, out int numArgsUsed);

	private unsafe static void EnterpriseHandler(string[] args, int index, out int numArgsUsed)
	{
		//Discarded unreachable code: IL_000e
		while (/*Error near IL_0005: Stack underflow*/ <= /*Error near IL_0005: Stack underflow*/)
		{
		}
		*(_003F*)(nint)/*Error near IL_0006: Stack underflow*/ = /*Error near IL_0006: Stack underflow*/;
		_ = *(IntPtr*)6;
		/*Error near IL_0009: Invalid metadata token*/;
	}

	private static extern void CustomUserHandler(string[] args, int index, out int numArgsUsed);

	private static extern void AllHandler(string[] args, int index, out int numArgsUsed);

	private static void CustomAllHandler(string[] args, int index, out int numArgsUsed)
	{
	}

	private static extern void SecurityHandler(string[] args, int index, out int numArgsUsed);

	private static extern void ExecutionHandler(string[] args, int index, out int numArgsUsed);

	private static extern void BuildCacheHandler(string[] args, int index, out int numArgsUsed);

	private static extern void PolicyChangeHandler(string[] args, int index, out int numArgsUsed);

	private unsafe static void RecoverHandler(string[] args, int index, out int numArgsUsed)
	{
		//Discarded unreachable code: IL_000f, IL_0014, IL_0019
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_003F val;
		do
		{
			val = checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		}
		while (/*Error near IL_0006: Stack underflow*/ >= val);
		*(_003F*)(nint)/*Error near IL_0007: Stack underflow*/ = /*Error near IL_0007: Stack underflow*/;
		/*Error near IL_000a: Invalid metadata token*/;
	}

	private static extern void ResetHandler(string[] args, int index, out int numArgsUsed);

	private static extern void ForceHandler(string[] args, int index, out int numArgsUsed);

	private static extern void HelpHandler(string[] args, int index, out int numArgsUsed);

	private unsafe static void DisplayLevelCodeGroups(PolicyLevel level)
	{
		//Discarded unreachable code: IL_000f, IL_0010, IL_0011, IL_0013, IL_0014, IL_0025, IL_0027, IL_0028
		//IL_0002: Invalid comparison between Unknown and I4
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected F4, but got Unknown
		int num;
		do
		{
			num = *(int*)(nint)/*Error near IL_0002: Stack underflow*/;
		}
		while ((int)/*Error near IL_0007: Stack underflow*/ == num);
		_003F val = /*Error near IL_000c: Stack underflow*/| -29;
		((float[])/*Error near IL_000d: Stack underflow*/)[/*Error near IL_000d: Stack underflow*/] = (float)val;
		/*Error near IL_000e: Unknown opcode: 0xF8*/;
	}

	private static void DisplayCodeGroups(CodeGroup group)
	{
		//Discarded unreachable code: IL_0004, IL_000d, IL_000f, IL_0010
		//IL_0000: Unsupported input type for neg.
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unsupported input type for neg.
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		_ = -(~(0 - /*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0003: Unknown opcode: 0xFF*/;
	}

	private static extern void DisplayLevelCodeGroupNameDescriptions(PolicyLevel level);

	private static extern void DisplayCodeGroupNameDescriptions(CodeGroup group);

	private static extern void DisplayLevelPermissionSets(PolicyLevel level);

	private static extern void DisplayLevelFullTrustAssemblies(PolicyLevel level);

	private static extern void DisplaySecurityOnOff();

	private static void ListHandler(string[] args, int index, out int numArgsUsed)
	{
		//Discarded unreachable code: IL_0006, IL_0008, IL_000b
		while (true)
		{
		}
	}

	private static extern void ListGroupHandler(string[] args, int index, out int numArgsUsed);

	private static extern void ListPermHandler(string[] args, int index, out int numArgsUsed);

	private static void ListFullTrustHandler(string[] args, int index, out int numArgsUsed)
	{
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
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
			arrayList.Add(GetLevel("Enterprise"));
			arrayList.Add(GetLevel("Machine"));
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
				PauseCapableWriteLine(Environment.NewLine + string.Format(manager.GetString("Dialog_Level"), val.get_Label()));
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
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
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
			arrayList.Add(GetLevel("Enterprise"));
			arrayList.Add(GetLevel("Machine"));
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
				PauseCapableWriteLine(Environment.NewLine + string.Format(manager.GetString("Dialog_Level"), val.get_Label()));
				PauseCapableWriteLine(Environment.NewLine + manager.GetString("Dialog_FullTrustAssemblies") + Environment.NewLine);
				DisplayLevelCodeGroupNameDescriptions(val);
			}
		}
		catch (Exception ex)
		{
			Error(manager.GetString("OptionTable_ListDescription"), ex.Message, -1);
		}
	}

	private static void ListCodeGroup(string prefix, string indent, IEnumerator enumerator)
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
				PauseCapableWriteLine(indent + text + ".  " + (val.get_MergeLogic().Equals(manager.GetString("Misc_MergeUnion")) ? "" : ("(" + val.get_MergeLogic() + ") ")) + ((val.get_MembershipCondition() == null) ? ((object)val).GetType().FullName : val.get_MembershipCondition().ToString()) + ": " + ((val.get_PermissionSetName() == null) ? manager.GetString("Dialog_Unknown") : val.get_PermissionSetName()) + ((val.get_AttributeString() == null || val.get_AttributeString().Equals("")) ? "" : (" (" + val.get_AttributeString() + ")")));
				ListCodeGroup(text, indent + "   ", val.get_Children().GetEnumerator());
				num++;
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
				PauseCapableWriteLine(indent + text + ". " + ((val.get_Name() == null || val.get_Name().Equals("")) ? "@@No label@@" : val.get_Name()) + ": " + ((val.get_Description() == null || val.get_Description().Equals("")) ? "@@No description@@" : val.get_Description()));
				ListCodeGroupNameDescription(text, indent + "   ", val.get_Children().GetEnumerator());
				num++;
			}
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
				Error(manager.GetString("OptionTable_AddPset"), string.Format(manager.GetString("Dialog_NotValidWithAll"), manager.GetString("OptionTable_All")), -1);
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
				text = ((object)ex).GetType().AssemblyQualifiedName;
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
			for (int i = 0; i < optionTable.Length; i++)
			{
				if (string.Compare(optionTable[i].option, args[index + 2], ignoreCase: true, CultureInfo.InvariantCulture) == 0)
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
				Error(manager.GetString("OptionTable_AddFullTrust"), string.Format(manager.GetString("Dialog_NotValidWithAll"), manager.GetString("OptionTable_All")), -1);
			}
		}
		Assembly assembly = LoadAssembly(args[index + 1], manager.GetString("OptionTable_AddFullTrust"));
		if ((object)assembly == null)
		{
			Error(manager.GetString("OptionTable_AddFullTrust"), manager.GetString("Error_UnableToLoadAssembly"), -1);
		}
		StrongName val = FindStrongName(assembly.get_Evidence());
		if (val == null)
		{
			Error(manager.GetString("OptionTable_AddFullTrust"), manager.GetString("Error_NotStrongNamed"), -1);
		}
		try
		{
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
				Error(manager.GetString("OptionTable_ChgPSet"), string.Format(manager.GetString("Dialog_NotValidWithAll"), manager.GetString("OptionTable_All")), -1);
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
				text = ((object)ex).GetType().AssemblyQualifiedName;
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
				text2 = ((object)ex2).GetType().AssemblyQualifiedName;
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
				Error(manager.GetString("OptionTable_RemPSet"), string.Format(manager.GetString("Dialog_NotValidWithAll"), manager.GetString("OptionTable_All")), -1);
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
				text = ((object)ex).GetType().AssemblyQualifiedName;
			}
			Error(manager.GetString("OptionTable_RemPSet"), text, -1);
		}
		if (permissionSet != null)
		{
			SafeSavePolicy();
		}
		else
		{
			Error(manager.GetString("OptionTable_RemPSet"), string.Format(manager.GetString("Error_PermSet_DoesNotExist"), args[index + 1]), -1);
		}
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
				Error(manager.GetString("OptionTable_RemFullTrust"), string.Format(manager.GetString("Dialog_NotValidWithAll"), manager.GetString("OptionTable_All")), -1);
			}
		}
		Assembly assembly = LoadAssembly(args[index + 1], manager.GetString("OptionTable_RemFullTrust"));
		if ((object)assembly == null)
		{
			Error(manager.GetString("OptionTable_RemFullTrust"), manager.GetString("Error_UnableToLoadAssembly"), -1);
		}
		StrongName val = FindStrongName(assembly.get_Evidence());
		if (val == null)
		{
			Error(manager.GetString("OptionTable_RemFullTrust"), manager.GetString("Error_NotStrongNamed"), -1);
		}
		try
		{
			level.RemoveFullTrustAssembly(val);
		}
		catch (Exception ex)
		{
			string text = ex.Message;
			if (text == null || text.Equals(""))
			{
				text = ((object)ex).GetType().AssemblyQualifiedName;
			}
			Error(manager.GetString("OptionTable_RemFullTrust"), text, -1);
		}
		SafeSavePolicy();
	}

	private static void RemGroupHandler(string[] args, int index, out int numArgsUsed)
	{
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Expected O, but got Unknown
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Expected O, but got Unknown
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
			}
			else
			{
				Error(manager.GetString("OptionTable_RemGroup"), string.Format(manager.GetString("Dialog_NotValidWithAll"), manager.GetString("OptionTable_All")), -1);
			}
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
		int num = ((array[^1] == null || array[^1].Length == 0) ? int.Parse(array[^2]) : int.Parse(array[^1]));
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
		PauseCapableWriteLine(string.Format(manager.GetString("Dialog_RemovedCodeGroup"), GetLevel().get_Label()));
	}

	private static void AddGroupHandler(string[] args, int index, out int numArgsUsed)
	{
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected O, but got Unknown
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Expected O, but got Unknown
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected O, but got Unknown
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
				Error(manager.GetString("OptionTable_AddGroup"), string.Format(manager.GetString("Dialog_NotValidWithAll"), manager.GetString("OptionTable_All")), -1);
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
			}
			else
			{
				Error(manager.GetString("OptionTable_AddGroup"), string.Format(manager.GetString("Dialog_NotValidWithAll"), manager.GetString("OptionTable_All")), -1);
			}
			return;
		}
		if (!(obj is CodeGroup))
		{
			Error(manager.GetString("OptionTable_AddGroup"), manager.GetString("Error_CodeGroup_MustBeCodeGroup"), -1);
			return;
		}
		int offset = 0;
		int argsUsed = 0;
		IMembershipCondition val = CreateMembershipCondition(level, args, index + 2, out offset);
		if (args.Length <= index + 2 + offset)
		{
			Error(manager.GetString("OptionTable_AddGroup"), manager.GetString("Error_CodeGroup_NoPermissionSet"), -1);
			return;
		}
		CodeGroup val2 = null;
		try
		{
			val2 = (CodeGroup)new UnionCodeGroup(val, new PolicyStatement((PermissionSet)(object)GetPermissionSet(level, args[index + 2 + offset]), (PolicyStatementAttribute)0));
			PolicyStatement policyStatement = val2.get_PolicyStatement();
			policyStatement.set_Attributes(IsExclusive(val2, args, index + 3 + offset, out argsUsed));
			val2.set_PolicyStatement(policyStatement);
		}
		catch (Exception ex2)
		{
			string text = ex2.Message;
			if (text == null || text.Equals(""))
			{
				text = ((object)ex2).GetType().AssemblyQualifiedName;
			}
			Error(manager.GetString("OptionTable_AddGroup"), text, -1);
		}
		((CodeGroup)obj).AddChild(val2);
		ReplaceLabel(args[index + 1], (CodeGroup)obj);
		SafeSavePolicy();
		PauseCapableWriteLine(string.Format(manager.GetString("Dialog_AddedCodeGroup"), args[index + 2], level.get_Label()));
		numArgsUsed = offset + argsUsed + 3;
	}

	private static void ChgGroupHandler(string[] args, int index, out int numArgsUsed)
	{
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected O, but got Unknown
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Expected O, but got Unknown
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0405: Unknown result type (might be due to invalid IL or missing references)
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
				Error(manager.GetString("OptionTable_ChgGroup"), string.Format(manager.GetString("Dialog_NotValidWithAll"), manager.GetString("OptionTable_All")), -1);
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
			}
			else
			{
				Error(manager.GetString("OptionTable_ChgGroup"), string.Format(manager.GetString("Dialog_NotValidWithAll"), manager.GetString("OptionTable_All")), -1);
			}
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
			for (i = 0; i < optionTable.Length && string.Compare(args[index + numArgsUsed], optionTable[i].option, ignoreCase: true, CultureInfo.InvariantCulture) != 0; i++)
			{
			}
			if (i != optionTable.Length)
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
				stringBuilder.Append(string.Format(manager.GetString("Dialog_ChangedCodeGroupMembershipCondition"), args[index + numArgsUsed], level.get_Label()));
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
					stringBuilder.Append(string.Format(manager.GetString("Dialog_ChangedCodeGroupAttributes2"), val.get_AttributeString(), level.get_Label()));
				}
				else
				{
					stringBuilder.Append(string.Format(manager.GetString("Dialog_ChangedCodeGroupAttributes1"), level.get_Label()));
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
					text = ((object)ex2).GetType().AssemblyQualifiedName;
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
				else
				{
					Error(manager.GetString("OptionTable_ChgGroup"), manager.GetString("Dialog_BuiltInOnly"), -1);
				}
				if (flag)
				{
					stringBuilder.Append(Environment.NewLine);
				}
				stringBuilder.Append(string.Format(manager.GetString("Dialog_ChangedCodeGroupPermissionSet"), args[index + numArgsUsed], level.get_Label()));
				numArgsUsed++;
				flag = true;
			}
			else
			{
				if (flag)
				{
					break;
				}
				Error(manager.GetString("OptionTable_ChgGroup"), string.Format(manager.GetString("Error_CodeGroup_UnrecognizedOption"), args[index + 2]), -1);
			}
		}
		ReplaceLabel(args[index + 1], val);
		SafeSavePolicy();
		PauseCapableWriteLine(stringBuilder.ToString());
	}

	private static Assembly LoadAssembly(string fileName, string option)
	{
		return LoadAssembly(fileName, option, errorOnFail: true);
	}

	private static Assembly LoadAssembly(string fileName, string option, bool errorOnFail)
	{
		AppDomain appDomain = AppDomain.CreateDomain("Caspol Domain", (Evidence)null, Environment.CurrentDirectory, Thread.GetDomain().BaseDirectory, false);
		if (appDomain == null)
		{
			Error(option, manager.GetString("Error_UnableToLoadAssembly"), -1);
		}
		Assembly assembly = null;
		try
		{
			assembly = appDomain.Load(fileName);
		}
		catch (Exception)
		{
		}
		if ((object)assembly != null)
		{
			return assembly;
		}
		try
		{
			assembly = Assembly.LoadFrom(fileName);
		}
		catch (Exception)
		{
		}
		try
		{
			assembly = Assembly.LoadFrom(Environment.CurrentDirectory + "\\" + fileName);
		}
		catch (Exception)
		{
		}
		if ((object)assembly != null)
		{
			return assembly;
		}
		if (errorOnFail)
		{
			Error(option, manager.GetString("Error_UnableToLoadAssembly"), -1);
		}
		return null;
	}

	private static Evidence GenerateShellEvidence(string fileName, string option)
	{
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		Assembly assembly = LoadAssembly(fileName, option, errorOnFail: false);
		if ((object)assembly == null)
		{
			string fullPath = Path.GetFullPath(fileName);
			if (fullPath == null || !File.Exists(fullPath))
			{
				Error(option, manager.GetString("Error_UnableToLoadAssembly"), -1);
			}
			if (PolicyPrompt)
			{
				PauseCapableWriteLine(string.Format(manager.GetString("Dialog_UseFakeEvidenceQuestion"), fileName));
				if (!GetAnswer())
				{
					PauseCapableWriteLine(manager.GetString("Dialog_OperationAborted"));
					throw new ExitException();
				}
			}
			else
			{
				PauseCapableWriteLine(string.Format(manager.GetString("Dialog_UseFakeEvidence"), fileName));
			}
			string text = "file:///" + fullPath;
			Evidence evidence = new Evidence();
			evidence.AddHost(Zone.CreateFromUrl(text));
			evidence.AddHost((object)new Url(text));
			return evidence;
		}
		return assembly.get_Evidence();
	}

	private static void ResolveGroupHandler(string[] args, int index, out int numArgsUsed)
	{
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
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
			arrayList.Add(GetLevel("Enterprise"));
			arrayList.Add(GetLevel("Machine"));
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
			PauseCapableWriteLine(Environment.NewLine + string.Format(manager.GetString("Dialog_Level"), ((PolicyLevel)enumerator.Current).get_Label()));
			PauseCapableWriteLine(Environment.NewLine + manager.GetString("Dialog_CodeGroups") + Environment.NewLine);
			DisplayCodeGroups(((PolicyLevel)enumerator.Current).ResolveMatchingCodeGroups(evidence));
			PauseCapableWriteLine("");
		}
	}

	private static void ResolvePermHandler(string[] args, int index, out int numArgsUsed)
	{
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Invalid comparison between Unknown and I4
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
			arrayList.Add(GetLevel("Enterprise"));
			arrayList.Add(GetLevel("Machine"));
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
		Parser parser = null;
		int num = 0;
		while (!flag && num < array.Length)
		{
			try
			{
				fileStream.Position = 0L;
				StreamReader input = new StreamReader(fileStream, array[num], detectEncodingFromByteOrderMarks: true);
				parser = new Parser(input);
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
		return parser.GetTopElement();
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
			throw new ArgumentException(string.Format(manager.GetString("Error_UnknownPermissionSet"), name));
		}
		return namedPermissionSet;
	}
}
