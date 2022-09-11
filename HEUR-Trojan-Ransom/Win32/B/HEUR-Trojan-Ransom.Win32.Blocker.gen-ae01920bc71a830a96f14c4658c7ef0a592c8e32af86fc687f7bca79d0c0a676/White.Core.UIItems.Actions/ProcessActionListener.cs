using System.Diagnostics;
using System.Windows.Automation;
using White.Core.Configuration;

namespace White.Core.UIItems.Actions;

public class ProcessActionListener : ActionListener
{
	private readonly Process process;

	public ProcessActionListener(AutomationElement automationElement)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AutomationElementInformation current = automationElement.get_Current();
		int processId = ((AutomationElementInformation)(ref current)).get_ProcessId();
		process = Process.GetProcessById(processId);
	}

	public virtual void ActionPerforming(UIItem uiItem)
	{
	}

	public virtual void ActionPerformed(Action action)
	{
		process.WaitForInputIdle(CoreAppXmlConfiguration.Instance.BusyTimeout);
	}
}
