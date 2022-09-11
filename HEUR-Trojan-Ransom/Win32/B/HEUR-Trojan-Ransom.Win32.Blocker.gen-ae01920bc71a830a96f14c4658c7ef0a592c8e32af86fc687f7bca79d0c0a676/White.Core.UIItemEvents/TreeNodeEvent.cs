using System.Collections.Generic;
using System.Text;
using White.Core.UIItems.TreeItems;

namespace White.Core.UIItemEvents;

public abstract class TreeNodeEvent : UserEvent
{
	protected readonly Tree tree;

	protected TreeNodeEvent(Tree uiItem)
		: base(uiItem)
	{
		tree = uiItem;
	}

	protected virtual string PathTo(TreeNode givenNode)
	{
		StringBuilder stringBuilder = new StringBuilder();
		List<TreeNode> pathTo = tree.GetPathTo(givenNode);
		foreach (TreeNode item in pathTo)
		{
			stringBuilder.AppendFormat("\"{0}\"", item.Name);
			if (!pathTo[pathTo.Count - 1].Equals(item))
			{
				stringBuilder.Append(",");
			}
		}
		return stringBuilder.ToString();
	}
}
