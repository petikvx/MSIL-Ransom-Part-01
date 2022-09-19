using System.Runtime.InteropServices;
using Microsoft.Win32.TaskScheduler.Properties;
using Microsoft.Win32.TaskScheduler.V1Interop;
using Microsoft.Win32.TaskScheduler.V2Interop;

namespace Microsoft.Win32.TaskScheduler;

[ComVisible(false)]
public sealed class IdleTrigger : Trigger
{
	public IdleTrigger()
		: base(TaskTriggerType.Idle)
	{
	}

	internal IdleTrigger(ITaskTrigger iTrigger)
		: base(iTrigger, Microsoft.Win32.TaskScheduler.V1Interop.TaskTriggerType.OnIdle)
	{
	}

	internal IdleTrigger(ITrigger iTrigger)
		: base(iTrigger)
	{
	}

	protected override string V2GetTriggerString()
	{
		return Resources.TriggerIdle1;
	}
}
