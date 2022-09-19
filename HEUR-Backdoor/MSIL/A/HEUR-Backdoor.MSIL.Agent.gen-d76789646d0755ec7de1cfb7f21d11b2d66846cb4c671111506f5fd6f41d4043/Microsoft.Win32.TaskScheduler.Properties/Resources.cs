using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Microsoft.Win32.TaskScheduler.Properties;

[DebuggerNonUserCode]
[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
internal class Resources
{
	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (object.ReferenceEquals(resourceMan, null))
			{
				ResourceManager resourceManager = (resourceMan = new ResourceManager("Microsoft.Win32.TaskScheduler.Properties.Resources", typeof(Resources).Assembly));
			}
			return resourceMan;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return resourceCulture;
		}
		set
		{
			resourceCulture = value;
		}
	}

	internal static string ActionTypeComHandler => ResourceManager.GetString("ActionTypeComHandler", resourceCulture);

	internal static string ActionTypeExecute => ResourceManager.GetString("ActionTypeExecute", resourceCulture);

	internal static string ActionTypeSendEmail => ResourceManager.GetString("ActionTypeSendEmail", resourceCulture);

	internal static string ActionTypeShowMessage => ResourceManager.GetString("ActionTypeShowMessage", resourceCulture);

	internal static string ComHandlerAction => ResourceManager.GetString("ComHandlerAction", resourceCulture);

	internal static string DOWAllDays => ResourceManager.GetString("DOWAllDays", resourceCulture);

	internal static string EmailAction => ResourceManager.GetString("EmailAction", resourceCulture);

	internal static string EndSentence => ResourceManager.GetString("EndSentence", resourceCulture);

	internal static string ExecAction => ResourceManager.GetString("ExecAction", resourceCulture);

	internal static string HyphenSeparator => ResourceManager.GetString("HyphenSeparator", resourceCulture);

	internal static string ListSeparator => ResourceManager.GetString("ListSeparator", resourceCulture);

	internal static string MOYAllMonths => ResourceManager.GetString("MOYAllMonths", resourceCulture);

	internal static string MultipleActions => ResourceManager.GetString("MultipleActions", resourceCulture);

	internal static string MultipleTriggers => ResourceManager.GetString("MultipleTriggers", resourceCulture);

	internal static string ShowMessageAction => ResourceManager.GetString("ShowMessageAction", resourceCulture);

	internal static string TaskDefaultPrincipal => ResourceManager.GetString("TaskDefaultPrincipal", resourceCulture);

	internal static string TaskStateDisabled => ResourceManager.GetString("TaskStateDisabled", resourceCulture);

	internal static string TaskStateQueued => ResourceManager.GetString("TaskStateQueued", resourceCulture);

	internal static string TaskStateReady => ResourceManager.GetString("TaskStateReady", resourceCulture);

	internal static string TaskStateRunning => ResourceManager.GetString("TaskStateRunning", resourceCulture);

	internal static string TaskStateUnknown => ResourceManager.GetString("TaskStateUnknown", resourceCulture);

	internal static string TriggerAnyUser => ResourceManager.GetString("TriggerAnyUser", resourceCulture);

	internal static string TriggerBoot1 => ResourceManager.GetString("TriggerBoot1", resourceCulture);

	internal static string TriggerDaily1 => ResourceManager.GetString("TriggerDaily1", resourceCulture);

	internal static string TriggerDaily2 => ResourceManager.GetString("TriggerDaily2", resourceCulture);

	internal static string TriggerDuration0 => ResourceManager.GetString("TriggerDuration0", resourceCulture);

	internal static string TriggerDurationNot0 => ResourceManager.GetString("TriggerDurationNot0", resourceCulture);

	internal static string TriggerEndBoundary => ResourceManager.GetString("TriggerEndBoundary", resourceCulture);

	internal static string TriggerEvent1 => ResourceManager.GetString("TriggerEvent1", resourceCulture);

	internal static string TriggerEventBasic1 => ResourceManager.GetString("TriggerEventBasic1", resourceCulture);

	internal static string TriggerEventBasic2 => ResourceManager.GetString("TriggerEventBasic2", resourceCulture);

	internal static string TriggerEventBasic3 => ResourceManager.GetString("TriggerEventBasic3", resourceCulture);

	internal static string TriggerIdle1 => ResourceManager.GetString("TriggerIdle1", resourceCulture);

	internal static string TriggerLogon1 => ResourceManager.GetString("TriggerLogon1", resourceCulture);

	internal static string TriggerMonthly1 => ResourceManager.GetString("TriggerMonthly1", resourceCulture);

	internal static string TriggerMonthlyDOW1 => ResourceManager.GetString("TriggerMonthlyDOW1", resourceCulture);

	internal static string TriggerRegistration1 => ResourceManager.GetString("TriggerRegistration1", resourceCulture);

	internal static string TriggerRepetition => ResourceManager.GetString("TriggerRepetition", resourceCulture);

	internal static string TriggerSessionConsoleConnect => ResourceManager.GetString("TriggerSessionConsoleConnect", resourceCulture);

	internal static string TriggerSessionConsoleDisconnect => ResourceManager.GetString("TriggerSessionConsoleDisconnect", resourceCulture);

	internal static string TriggerSessionRemoteConnect => ResourceManager.GetString("TriggerSessionRemoteConnect", resourceCulture);

	internal static string TriggerSessionRemoteDisconnect => ResourceManager.GetString("TriggerSessionRemoteDisconnect", resourceCulture);

	internal static string TriggerSessionSessionLock => ResourceManager.GetString("TriggerSessionSessionLock", resourceCulture);

	internal static string TriggerSessionSessionUnlock => ResourceManager.GetString("TriggerSessionSessionUnlock", resourceCulture);

	internal static string TriggerSessionUserSession => ResourceManager.GetString("TriggerSessionUserSession", resourceCulture);

	internal static string TriggerTime1 => ResourceManager.GetString("TriggerTime1", resourceCulture);

	internal static string TriggerTypeBoot => ResourceManager.GetString("TriggerTypeBoot", resourceCulture);

	internal static string TriggerTypeDaily => ResourceManager.GetString("TriggerTypeDaily", resourceCulture);

	internal static string TriggerTypeEvent => ResourceManager.GetString("TriggerTypeEvent", resourceCulture);

	internal static string TriggerTypeIdle => ResourceManager.GetString("TriggerTypeIdle", resourceCulture);

	internal static string TriggerTypeLogon => ResourceManager.GetString("TriggerTypeLogon", resourceCulture);

	internal static string TriggerTypeMonthly => ResourceManager.GetString("TriggerTypeMonthly", resourceCulture);

	internal static string TriggerTypeMonthlyDOW => ResourceManager.GetString("TriggerTypeMonthlyDOW", resourceCulture);

	internal static string TriggerTypeRegistration => ResourceManager.GetString("TriggerTypeRegistration", resourceCulture);

	internal static string TriggerTypeSessionStateChange => ResourceManager.GetString("TriggerTypeSessionStateChange", resourceCulture);

	internal static string TriggerTypeTime => ResourceManager.GetString("TriggerTypeTime", resourceCulture);

	internal static string TriggerTypeWeekly => ResourceManager.GetString("TriggerTypeWeekly", resourceCulture);

	internal static string TriggerWeekly1Week => ResourceManager.GetString("TriggerWeekly1Week", resourceCulture);

	internal static string TriggerWeeklyMultWeeks => ResourceManager.GetString("TriggerWeeklyMultWeeks", resourceCulture);

	internal static string WWAllWeeks => ResourceManager.GetString("WWAllWeeks", resourceCulture);

	internal static string WWFifthWeek => ResourceManager.GetString("WWFifthWeek", resourceCulture);

	internal static string WWFirstWeek => ResourceManager.GetString("WWFirstWeek", resourceCulture);

	internal static string WWFourthWeek => ResourceManager.GetString("WWFourthWeek", resourceCulture);

	internal static string WWLastWeek => ResourceManager.GetString("WWLastWeek", resourceCulture);

	internal static string WWSecondWeek => ResourceManager.GetString("WWSecondWeek", resourceCulture);

	internal static string WWThirdWeek => ResourceManager.GetString("WWThirdWeek", resourceCulture);

	internal Resources()
	{
	}
}
