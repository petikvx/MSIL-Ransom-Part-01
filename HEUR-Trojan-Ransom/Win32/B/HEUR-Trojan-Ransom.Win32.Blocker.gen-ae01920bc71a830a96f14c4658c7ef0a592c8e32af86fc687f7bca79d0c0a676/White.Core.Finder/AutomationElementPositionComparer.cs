using System.Collections.Generic;
using System.Windows;
using System.Windows.Automation;

namespace White.Core.Finder;

public class AutomationElementPositionComparer : PositionBasedComparer, IComparer<AutomationElement>
{
	public virtual int Compare(AutomationElement x, AutomationElement y)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		AutomationElementInformation current = x.get_Current();
		Rect boundingRectangle = ((AutomationElementInformation)(ref current)).get_BoundingRectangle();
		AutomationElementInformation current2 = y.get_Current();
		Rect boundingRectangle2 = ((AutomationElementInformation)(ref current2)).get_BoundingRectangle();
		return PositionBasedComparer.Compare(boundingRectangle, boundingRectangle2);
	}
}
