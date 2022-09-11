using System;
using System.Runtime.CompilerServices;

namespace HP.SupportFramework.Common.HPSAIssues;

[Serializable]
public class ActionItemBase
{
	[Flags]
	public enum IssueResult
	{
		SuccessNoReboot = 1,
		SuccessReboot = 2,
		FailDownload = 3,
		Cancel = 5,
		Postpone1Week = 7,
		Postpone1Month = 8,
		Postpone3Months = 9,
		PostponeNever = 0xA,
		FailInvalidDetailFile = 0xB,
		FailTimeout = 0xC,
		FailInstall = 0xD,
		FailUnknownReturnCode = 0xE,
		FailInvalidSilentCommand = 0x10
	}

	[Flags]
	public enum ActionTypeEnum
	{
		Update = 0,
		Patch = 1,
		Alert = 2,
		Tip = 3,
		CustomAction = 4
	}

	[Flags]
	public enum ActionImportanceEnum
	{
		Critical = 0,
		Recommended = 1,
		Tip = 2
	}

	[Flags]
	public enum ActionSourceEnum
	{
		ActiveCheck = 0,
		HPUpdate = 1
	}

	public ActionSourceEnum ActionSource
	{
		[CompilerGenerated]
		get
		{
			return (ActionSourceEnum)Class28.smethod_0(4834856, this, null);
		}
		[CompilerGenerated]
		set
		{
			Class28.smethod_0(4834878, this, value);
		}
	}

	public ActionImportanceEnum ActionImportance
	{
		[CompilerGenerated]
		get
		{
			return (ActionImportanceEnum)Class28.smethod_0(4834887, this, null);
		}
		[CompilerGenerated]
		set
		{
			Class28.smethod_0(4834925, this, value);
		}
	}

	public ActionTypeEnum ActionType
	{
		[CompilerGenerated]
		get
		{
			return (ActionTypeEnum)Class28.smethod_0(4834934, this, null);
		}
		[CompilerGenerated]
		set
		{
			Class28.smethod_0(4835740, this, value);
		}
	}

	public IssueResult Result
	{
		[CompilerGenerated]
		get
		{
			return (IssueResult)Class28.smethod_0(4835749, this, null);
		}
		[CompilerGenerated]
		set
		{
			Class28.smethod_0(4835787, this, value);
		}
	}

	public string Guid
	{
		[CompilerGenerated]
		get
		{
			return (string)Class28.smethod_0(4835796, this, null);
		}
		[CompilerGenerated]
		set
		{
			Class28.smethod_0(4835833, this, value);
		}
	}

	public string Status
	{
		[CompilerGenerated]
		get
		{
			return (string)Class28.smethod_0(4835585, this, null);
		}
		[CompilerGenerated]
		set
		{
			Class28.smethod_0(4835606, this, value);
		}
	}

	public string QA
	{
		[CompilerGenerated]
		get
		{
			return (string)Class28.smethod_0(4835646, this, null);
		}
		[CompilerGenerated]
		set
		{
			Class28.smethod_0(4835651, this, value);
		}
	}

	public string UrlResult
	{
		[CompilerGenerated]
		get
		{
			return (string)Class28.smethod_0(4835691, this, null);
		}
		[CompilerGenerated]
		set
		{
			Class28.smethod_0(4835696, this, value);
		}
	}

	public string PersistantTime
	{
		[CompilerGenerated]
		get
		{
			return (string)Class28.smethod_0(4835480, this, null);
		}
		[CompilerGenerated]
		set
		{
			Class28.smethod_0(4835501, this, value);
		}
	}

	public bool ExceptionSP
	{
		[CompilerGenerated]
		get
		{
			return (bool)Class28.smethod_0(4835509, this, null);
		}
		[CompilerGenerated]
		set
		{
			Class28.smethod_0(4835546, this, value);
		}
	}

	public GClass3.SupportCategories Category
	{
		[CompilerGenerated]
		get
		{
			return (GClass3.SupportCategories)Class28.smethod_0(4835554, this, null);
		}
		[CompilerGenerated]
		set
		{
			Class28.smethod_0(4835336, this, value);
		}
	}

	public GClass3.SupportTopCategories TopCategory
	{
		[CompilerGenerated]
		get
		{
			return (GClass3.SupportTopCategories)Class28.smethod_0(4835345, this, null);
		}
		[CompilerGenerated]
		set
		{
			Class28.smethod_0(4835367, this, value);
		}
	}

	public string Symptom
	{
		[CompilerGenerated]
		get
		{
			return (string)Class28.smethod_0(4835392, this, null);
		}
		[CompilerGenerated]
		set
		{
			Class28.smethod_0(4835413, this, value);
		}
	}

	public string SymptomUS
	{
		[CompilerGenerated]
		get
		{
			return (string)Class28.smethod_0(4835453, this, null);
		}
		[CompilerGenerated]
		set
		{
			Class28.smethod_0(4836226, this, value);
		}
	}

	public string Date
	{
		[CompilerGenerated]
		get
		{
			return (string)Class28.smethod_0(4836266, this, null);
		}
		[CompilerGenerated]
		set
		{
			Class28.smethod_0(4836287, this, value);
		}
	}

	public bool CheckForFix
	{
		[CompilerGenerated]
		get
		{
			return (bool)Class28.smethod_0(4836295, this, null);
		}
		[CompilerGenerated]
		set
		{
			Class28.smethod_0(4836332, this, value);
		}
	}

	public string Progress
	{
		[CompilerGenerated]
		get
		{
			return (string)Class28.smethod_0(4836340, this, null);
		}
		[CompilerGenerated]
		set
		{
			Class28.smethod_0(4836121, this, value);
		}
	}

	public string Step
	{
		[CompilerGenerated]
		get
		{
			return (string)Class28.smethod_0(4836129, this, null);
		}
		[CompilerGenerated]
		set
		{
			Class28.smethod_0(4836150, this, value);
		}
	}

	public string AdditionalInfo
	{
		[CompilerGenerated]
		get
		{
			return (string)Class28.smethod_0(4836190, this, null);
		}
		[CompilerGenerated]
		set
		{
			Class28.smethod_0(4836195, this, value);
		}
	}

	public string AutoSolution
	{
		[CompilerGenerated]
		get
		{
			return (string)Class28.smethod_0(4835979, this, null);
		}
		[CompilerGenerated]
		set
		{
			Class28.smethod_0(4835984, this, value);
		}
	}

	public string SPName
	{
		[CompilerGenerated]
		get
		{
			return (string)Class28.smethod_0(4836024, this, null);
		}
		[CompilerGenerated]
		set
		{
			Class28.smethod_0(4836045, this, value);
		}
	}

	public string SPVersion
	{
		[CompilerGenerated]
		get
		{
			return (string)Class28.smethod_0(4836053, this, null);
		}
		[CompilerGenerated]
		set
		{
			Class28.smethod_0(4836090, this, value);
		}
	}

	public string SPType
	{
		[CompilerGenerated]
		get
		{
			return (string)Class28.smethod_0(4835842, this, null);
		}
		[CompilerGenerated]
		set
		{
			Class28.smethod_0(4835863, this, value);
		}
	}

	public string SPId
	{
		[CompilerGenerated]
		get
		{
			return (string)Class28.smethod_0(4835903, this, null);
		}
		[CompilerGenerated]
		set
		{
			Class28.smethod_0(4835908, this, value);
		}
	}

	public string SPSize
	{
		[CompilerGenerated]
		get
		{
			return (string)Class28.smethod_0(4835948, this, null);
		}
		[CompilerGenerated]
		set
		{
			Class28.smethod_0(4835953, this, value);
		}
	}

	public string SPSPName
	{
		[CompilerGenerated]
		get
		{
			return (string)Class28.smethod_0(4836761, this, null);
		}
		[CompilerGenerated]
		set
		{
			Class28.smethod_0(4836782, this, value);
		}
	}

	public string SPSSM
	{
		[CompilerGenerated]
		get
		{
			return (string)Class28.smethod_0(4836790, this, null);
		}
		[CompilerGenerated]
		set
		{
			Class28.smethod_0(4836827, this, value);
		}
	}

	public string SPSSMFtp
	{
		[CompilerGenerated]
		get
		{
			return (string)Class28.smethod_0(4836835, this, null);
		}
		[CompilerGenerated]
		set
		{
			Class28.smethod_0(4836616, this, value);
		}
	}

	public string SPWinFtp
	{
		[CompilerGenerated]
		get
		{
			return (string)Class28.smethod_0(4836624, this, null);
		}
		[CompilerGenerated]
		set
		{
			Class28.smethod_0(4836645, this, value);
		}
	}

	public string SPFloppyFtp
	{
		[CompilerGenerated]
		get
		{
			return (string)Class28.smethod_0(4836685, this, null);
		}
		[CompilerGenerated]
		set
		{
			Class28.smethod_0(4836690, this, value);
		}
	}

	public string APInfoUrl
	{
		[CompilerGenerated]
		get
		{
			return (string)Class28.smethod_0(4836730, this, null);
		}
		[CompilerGenerated]
		set
		{
			Class28.smethod_0(4836495, this, value);
		}
	}

	public bool IsBiosException
	{
		[CompilerGenerated]
		get
		{
			return (bool)Class28.smethod_0(4836503, this, null);
		}
		[CompilerGenerated]
		set
		{
			Class28.smethod_0(4836540, this, value);
		}
	}

	public bool IsReebootRequired
	{
		[CompilerGenerated]
		get
		{
			return (bool)Class28.smethod_0(4836548, this, null);
		}
		[CompilerGenerated]
		set
		{
			Class28.smethod_0(4836585, this, value);
		}
	}

	public string SilentInstallString
	{
		[CompilerGenerated]
		get
		{
			return (string)Class28.smethod_0(4836593, this, null);
		}
		[CompilerGenerated]
		set
		{
			Class28.smethod_0(4836358, this, value);
		}
	}

	public string ExecutableName
	{
		[CompilerGenerated]
		get
		{
			return (string)Class28.smethod_0(4836398, this, null);
		}
		[CompilerGenerated]
		set
		{
			Class28.smethod_0(4836403, this, value);
		}
	}

	public string TempDirectory
	{
		[CompilerGenerated]
		get
		{
			return (string)Class28.smethod_0(4836443, this, null);
		}
		[CompilerGenerated]
		set
		{
			Class28.smethod_0(4836448, this, value);
		}
	}

	public string NoRebootSuccessReturnCode
	{
		[CompilerGenerated]
		get
		{
			return (string)Class28.smethod_0(4837256, this, null);
		}
		[CompilerGenerated]
		set
		{
			Class28.smethod_0(4837277, this, value);
		}
	}

	public string NoRebootFailureReturnCode
	{
		[CompilerGenerated]
		get
		{
			return (string)Class28.smethod_0(4837285, this, null);
		}
		[CompilerGenerated]
		set
		{
			Class28.smethod_0(4837322, this, value);
		}
	}

	public string RebootSuccessReturnCode
	{
		[CompilerGenerated]
		get
		{
			return (string)Class28.smethod_0(4837330, this, null);
		}
		[CompilerGenerated]
		set
		{
			Class28.smethod_0(4837351, this, value);
		}
	}

	public string NoRebootCancelReturnCode
	{
		[CompilerGenerated]
		get
		{
			return (string)Class28.smethod_0(4837135, this, null);
		}
		[CompilerGenerated]
		set
		{
			Class28.smethod_0(4837140, this, value);
		}
	}

	public string CustomActionType
	{
		[CompilerGenerated]
		get
		{
			return (string)Class28.smethod_0(4837180, this, null);
		}
		[CompilerGenerated]
		set
		{
			Class28.smethod_0(4837185, this, value);
		}
	}

	public string CustomActionIcon
	{
		[CompilerGenerated]
		get
		{
			return (string)Class28.smethod_0(4837225, this, null);
		}
		[CompilerGenerated]
		set
		{
			Class28.smethod_0(4837246, this, value);
		}
	}

	public string CustomActionResource
	{
		[CompilerGenerated]
		get
		{
			return (string)Class28.smethod_0(4836998, this, null);
		}
		[CompilerGenerated]
		set
		{
			Class28.smethod_0(4837035, this, value);
		}
	}

	public string Activity
	{
		[CompilerGenerated]
		get
		{
			return (string)Class28.smethod_0(4837043, this, null);
		}
		[CompilerGenerated]
		set
		{
			Class28.smethod_0(4837080, this, value);
		}
	}

	public string SPExitCode
	{
		[CompilerGenerated]
		get
		{
			return (string)Class28.smethod_0(4837088, this, null);
		}
		[CompilerGenerated]
		set
		{
			Class28.smethod_0(4837109, this, value);
		}
	}

	internal static int smethod_0(int int_0)
	{
		return int_0 switch
		{
			21 => -10, 
			22 => -1, 
			23 => -7, 
			24 => -6, 
			25 => -2, 
			26 => -9, 
			27 => -28, 
			28 => -5, 
			29 => -15, 
			30 => -13, 
			_ => -1, 
		};
	}

	internal static int smethod_1(int int_0)
	{
		return int_0 switch
		{
			54 => -24, 
			55 => -20, 
			58 => -18, 
			60 => -32, 
			45 => -3, 
			47 => -12, 
			48 => -29, 
			_ => -1, 
		};
	}
}
