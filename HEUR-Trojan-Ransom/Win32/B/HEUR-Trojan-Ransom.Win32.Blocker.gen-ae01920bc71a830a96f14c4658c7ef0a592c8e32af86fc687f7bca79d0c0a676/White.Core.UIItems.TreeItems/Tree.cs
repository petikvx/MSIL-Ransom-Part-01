using System.Collections.Generic;
using System.Windows.Automation;
using White.Core.AutomationElementSearch;
using White.Core.Recording;
using White.Core.UIItemEvents;
using White.Core.UIItems.Actions;
using White.Core.UIItems.Scrolling;

namespace White.Core.UIItems.TreeItems;

public class Tree : UIItem, VerticalSpanProvider
{
	private readonly AutomationElementFinder finder;

	private AutomationPropertyChangedEventHandler clickedTreeNodeHandler;

	private AutomationPropertyChangedEventHandler selectedTreeNodeHandler;

	public virtual TreeNode SelectedNode
	{
		get
		{
			SelectedNodeVisitor selectedNodeVisitor = new SelectedNodeVisitor();
			Nodes.Visit(selectedNodeVisitor);
			return selectedNodeVisitor.SelectedNode;
		}
	}

	public virtual string EditableNodeText
	{
		set
		{
			AutomationElement val = finder.Child(AutomationSearchCondition.ByControlType(ControlType.Edit));
			new TextBox(val, actionListener).Text = value;
		}
	}

	public virtual TreeNodes Nodes => new TreeNodes(finder, this);

	private TreeNode ClickedNode
	{
		get
		{
			ClickedNodeVisitor clickedNodeVisitor = new ClickedNodeVisitor();
			Nodes.Visit(clickedNodeVisitor);
			return clickedNodeVisitor.ClickedNode;
		}
	}

	public virtual VerticalSpan VerticalSpan => new VerticalSpan(Bounds).Minus(ScrollBars.Horizontal.Bounds);

	protected Tree()
	{
	}

	public Tree(AutomationElement automationElement, ActionListener actionListener)
		: base(automationElement, actionListener)
	{
		finder = new AutomationElementFinder(automationElement);
	}

	public virtual bool HasNode(params string[] nodePath)
	{
		return Node(nodePath) != null;
	}

	public virtual TreeNode Node(params string[] nodePath)
	{
		return Nodes.GetItem(nodePath);
	}

	public override void HookEvents(UIItemEventListener eventListener)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		clickedTreeNodeHandler = (AutomationPropertyChangedEventHandler)delegate
		{
			TreeNode clickedNode = ClickedNode;
			eventListener.EventOccured(new TreeNodeClickedEvent(this, clickedNode, clickedNode.IsExpanded()));
		};
		selectedTreeNodeHandler = (AutomationPropertyChangedEventHandler)delegate
		{
			TreeNode selectedNode = SelectedNode;
			eventListener.EventOccured(new TreeNodeSelectEvent(this, selectedNode));
		};
		Automation.AddAutomationPropertyChangedEventHandler(automationElement, (TreeScope)7, clickedTreeNodeHandler, (AutomationProperty[])(object)new AutomationProperty[1] { ExpandCollapsePatternIdentifiers.ExpandCollapseStateProperty });
		Automation.AddAutomationPropertyChangedEventHandler(automationElement, (TreeScope)7, selectedTreeNodeHandler, (AutomationProperty[])(object)new AutomationProperty[1] { SelectionItemPatternIdentifiers.IsSelectedProperty });
	}

	public override void UnHookEvents()
	{
		Automation.RemoveAutomationPropertyChangedEventHandler(automationElement, clickedTreeNodeHandler);
		Automation.RemoveAutomationPropertyChangedEventHandler(automationElement, selectedTreeNodeHandler);
	}

	public virtual List<TreeNode> GetPathTo(TreeNode node)
	{
		return Nodes.GetPathTo(node);
	}

	public override void ActionPerforming(UIItem uiItem)
	{
		new ScreenItem(uiItem, ScrollBars).MakeVisible(this);
	}

	public override void ActionPerformed(Action action)
	{
		actionListener.ActionPerformed(action);
	}
}
