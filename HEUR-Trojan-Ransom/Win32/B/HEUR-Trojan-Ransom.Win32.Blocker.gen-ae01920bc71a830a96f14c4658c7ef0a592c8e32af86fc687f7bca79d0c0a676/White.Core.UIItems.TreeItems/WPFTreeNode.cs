using System.Windows;
using System.Windows.Automation;
using White.Core.UIA;
using White.Core.UIItems.Actions;
using White.Core.UIItems.Finders;

namespace White.Core.UIItems.TreeItems;

[PlatformSpecificItem]
public class WPFTreeNode : TreeNode
{
	protected override Point SelectPoint => GetExpandCollapseButton().Bounds.East(10);

	protected WPFTreeNode()
	{
	}

	public WPFTreeNode(AutomationElement automationElement, ActionListener actionListener)
		: base(automationElement, actionListener)
	{
	}

	protected override void DoExpand()
	{
		Button expandCollapseButton = GetExpandCollapseButton();
		if (expandCollapseButton.IsOffScreen)
		{
			throw new AutomationException($"Cannot expand TreeNode {this}, expand button not visible", Debug.Details(AutomationElement));
		}
		expandCollapseButton.Click();
	}

	protected override void DoCollapse()
	{
		GetExpandCollapseButton().Click();
	}

	private Button GetExpandCollapseButton()
	{
		return (Button)factory.Create(SearchCriteria.ByControlType(ControlType.Button), actionListener);
	}
}
