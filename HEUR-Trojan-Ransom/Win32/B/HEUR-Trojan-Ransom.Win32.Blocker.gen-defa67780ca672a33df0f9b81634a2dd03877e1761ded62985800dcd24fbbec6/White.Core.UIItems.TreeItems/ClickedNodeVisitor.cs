using System.Windows;
using White.Core.InputDevices;

namespace White.Core.UIItems.TreeItems;

internal class ClickedNodeVisitor : TreeNodeVisitor
{
	private TreeNode clickedNode;

	public virtual TreeNode ClickedNode => clickedNode;

	public virtual void Accept(TreeNode treeNode)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		Rect bounds = treeNode.Bounds;
		double top = ((Rect)(ref bounds)).get_Top();
		Point location = Mouse.instance.Location;
		if (top <= ((Point)(ref location)).get_Y())
		{
			Rect bounds2 = treeNode.Bounds;
			double bottom = ((Rect)(ref bounds2)).get_Bottom();
			Point location2 = Mouse.instance.Location;
			if (bottom >= ((Point)(ref location2)).get_Y())
			{
				clickedNode = treeNode;
			}
		}
	}
}
