using System.Windows;
using System.Windows.Automation;
using White.Core.AutomationElementSearch;
using White.Core.UIItems.Actions;

namespace White.Core.UIItems.TreeItems;

public abstract class TreeNode : UIItem
{
	private readonly AutomationElementFinder finder;

	public virtual TreeNodes Nodes => new TreeNodes(finder, actionListener);

	public virtual bool IsSelected => (bool)Property(SelectionItemPattern.IsSelectedProperty);

	public virtual ExpandCollapseState DisplayState => (ExpandCollapseState)Property(ExpandCollapsePattern.ExpandCollapseStateProperty);

	protected abstract Point SelectPoint { get; }

	public virtual string Text
	{
		get
		{
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			string name = Name;
			if (!string.IsNullOrEmpty(name) && !name.Contains("System.Windows.Controls.TreeViewItem"))
			{
				return name;
			}
			AutomationElement val = finder.Child(AutomationSearchCondition.ByControlType(ControlType.Text));
			if (!(val == (AutomationElement)null))
			{
				AutomationElementInformation current = val.get_Current();
				return ((AutomationElementInformation)(ref current)).get_Name();
			}
			return string.Empty;
		}
	}

	protected TreeNode()
	{
	}

	protected TreeNode(AutomationElement automationElement, ActionListener actionListener)
		: base(automationElement, actionListener)
	{
		finder = new AutomationElementFinder(automationElement);
	}

	public virtual bool IsExpanded()
	{
		return ValueOfEquals(ExpandCollapsePattern.ExpandCollapseStateProperty, (object)(ExpandCollapseState)1);
	}

	public virtual TreeNode GetItem(params string[] path)
	{
		actionListener.ActionPerforming(this);
		Expand();
		return Nodes.GetItem(path);
	}

	public virtual void Select()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		actionListener.ActionPerforming(this);
		UIItem.mouse.Click(SelectPoint, actionListener);
	}

	public virtual bool UnSelect()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		SelectionItemPattern val = (SelectionItemPattern)Pattern(SelectionItemPattern.Pattern);
		if (val != null)
		{
			val.RemoveFromSelection();
			return true;
		}
		return false;
	}

	public virtual void Expand()
	{
		if (!IsExpanded())
		{
			actionListener.ActionPerforming(this);
			DoExpand();
		}
	}

	public virtual void Collapse()
	{
		if (IsExpanded())
		{
			actionListener.ActionPerforming(this);
			DoCollapse();
		}
	}

	protected abstract void DoExpand();

	protected abstract void DoCollapse();

	public virtual void Visit(TreeNodeVisitor treeNodeVisitor)
	{
		treeNodeVisitor.Accept(this);
		Nodes.Visit(treeNodeVisitor);
	}

	public override void Click()
	{
		Select();
	}

	public override void DoubleClick()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		actionListener.ActionPerforming(this);
		UIItem.mouse.DoubleClick(SelectPoint, actionListener);
	}

	public override void RightClick()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		actionListener.ActionPerforming(this);
		UIItem.mouse.RightClick(SelectPoint, actionListener);
	}
}
