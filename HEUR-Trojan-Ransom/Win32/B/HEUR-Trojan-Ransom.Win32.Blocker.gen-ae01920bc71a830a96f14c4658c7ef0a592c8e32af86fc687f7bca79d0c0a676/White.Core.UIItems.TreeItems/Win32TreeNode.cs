using System.Windows;
using System.Windows.Automation;
using White.Core.UIA;
using White.Core.UIItems.Actions;

namespace White.Core.UIItems.TreeItems;

[PlatformSpecificItem]
public class Win32TreeNode : TreeNode
{
	protected override Point SelectPoint
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			AutomationElementInformation current = automationElement.get_Current();
			return ((AutomationElementInformation)(ref current)).get_BoundingRectangle().Center();
		}
	}

	protected Win32TreeNode()
	{
	}

	public Win32TreeNode(AutomationElement automationElement, ActionListener actionListener)
		: base(automationElement, actionListener)
	{
	}

	protected override void DoExpand()
	{
		DoubleClick();
		if (Nodes.Count == 0)
		{
			throw new AutomationException($"Cannot expand TreeNode {this}, expand button not visible", Debug.Details(AutomationElement));
		}
	}

	protected override void DoCollapse()
	{
		DoubleClick();
	}
}
