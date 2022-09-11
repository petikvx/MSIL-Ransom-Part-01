using System.Collections.Generic;
using System.Linq;
using System.Windows.Automation;

namespace White.Core.UIA;

public class AutomationPatterns : List<AutomationPattern>
{
	public AutomationPatterns(params AutomationPattern[] collection)
		: base((IEnumerable<AutomationPattern>)collection)
	{
	}

	public AutomationPatterns(AutomationElement automationElement)
	{
		AddRange(automationElement.GetSupportedPatterns());
	}

	public virtual bool HasPattern(AutomationPattern automationPattern)
	{
		return this.Any((AutomationPattern pattern) => ((AutomationIdentifier)pattern).get_Id().Equals(((AutomationIdentifier)automationPattern).get_Id()));
	}
}
