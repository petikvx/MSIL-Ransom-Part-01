using System.Collections.Generic;
using System.Windows.Automation;
using White.Core.AutomationElementSearch;
using White.Core.Factory;
using White.Core.UIItems.Actions;

namespace White.Core.UIItems.TreeItems;

public class TreeNodes : UIItemList<TreeNode>
{
	public TreeNodes(AutomationElementFinder finder, ActionListener actionListener)
		: base(finder.Children(AutomationSearchCondition.ByControlType(ControlType.TreeItem)), actionListener)
	{
	}

	public virtual TreeNode GetItem(params string[] path)
	{
		List<string> list = new List<string>(path);
		if (list.Count == 0)
		{
			return null;
		}
		string text = list[0];
		TreeNode treeNode = MatchingNode(text);
		list.RemoveAt(0);
		if (list.Count == 0)
		{
			return treeNode;
		}
		if (treeNode == null)
		{
			throw new UIItemSearchException($"Could not find node {text}");
		}
		return treeNode.GetItem(list.ToArray());
	}

	private TreeNode MatchingNode(string nodeText)
	{
		return Find((TreeNode treeNode) => treeNode.Text.Equals(nodeText));
	}

	public virtual List<TreeNode> GetPathTo(TreeNode treeNode)
	{
		List<TreeNode> list = new List<TreeNode>();
		Path(treeNode, list);
		return list;
	}

	private bool Path(TreeNode treeNode, List<TreeNode> treeNodes)
	{
		using (Enumerator enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				TreeNode current = enumerator.Current;
				if (!current.Equals(treeNode))
				{
					treeNodes.Add(current);
					if (!current.Nodes.Path(treeNode, treeNodes))
					{
						treeNodes.Remove(current);
						continue;
					}
					return true;
				}
				treeNodes.Add(current);
				return true;
			}
		}
		return false;
	}

	public virtual void Visit(TreeNodeVisitor visitor)
	{
		using Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			TreeNode current = enumerator.Current;
			current.Visit(visitor);
		}
	}
}
