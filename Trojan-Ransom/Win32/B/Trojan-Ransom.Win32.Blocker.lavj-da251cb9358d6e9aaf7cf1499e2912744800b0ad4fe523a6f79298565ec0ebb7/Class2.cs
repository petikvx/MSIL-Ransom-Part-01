using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

internal sealed class Class2 : TreeView
{
	public List<string> list_0 = new List<string>();

	public Class2()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		((TreeView)this).set_CheckBoxes(true);
		((TreeView)this).add_AfterCheck(new TreeViewEventHandler(Class2_AfterCheck));
	}

	private void Class2_AfterCheck(object sender, TreeViewEventArgs e)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		try
		{
			Class14 @class = (Class14)e.get_Node().get_Tag();
			method_0(new TreeViewCancelEventArgs(e.get_Node(), false, e.get_Action()));
			int num = 0;
			TreeNode val = e.get_Node();
			while (true)
			{
				num++;
				if (val.get_Parent() == null)
				{
					break;
				}
				val = val.get_Parent();
			}
			if (@class == null)
			{
				return;
			}
			if (e.get_Node().get_Checked() && !string.IsNullOrEmpty(@class.method_13()))
			{
				list_0.Add(@class.method_13());
			}
			else if (list_0.Contains(@class.method_13()))
			{
				list_0.Remove(@class.method_13());
			}
			if (num >= 4 || e.get_Node().get_Nodes() == null)
			{
				return;
			}
			foreach (TreeNode node in e.get_Node().get_Nodes())
			{
				TreeNode val2 = node;
				val2.set_Checked(e.get_Node().get_Checked());
			}
		}
		catch
		{
		}
	}

	private void method_0(TreeViewCancelEventArgs treeViewCancelEventArgs_0)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		treeViewCancelEventArgs_0.get_Node().get_Nodes().Clear();
		Class14 @class = (Class14)treeViewCancelEventArgs_0.get_Node().get_Tag();
		ArrayList arrayList = @class.method_1();
		foreach (Class14 item in arrayList)
		{
			TreeNode val = new TreeNode();
			val.set_Text(item.method_2());
			val.set_ImageIndex(item.method_4());
			val.set_SelectedImageIndex(item.method_4());
			val.set_Tag((object)item);
			foreach (string item2 in list_0)
			{
				if (item.method_13().StartsWith(item2))
				{
					val.set_Checked(true);
				}
			}
			if (item.method_9() && item.method_11())
			{
				val.get_Nodes().Add("PH");
			}
			treeViewCancelEventArgs_0.get_Node().get_Nodes().Add(val);
		}
	}

	protected override void OnBeforeExpand(TreeViewCancelEventArgs treeViewCancelEventArgs_0)
	{
		method_0(treeViewCancelEventArgs_0);
		((TreeView)this).OnBeforeExpand(treeViewCancelEventArgs_0);
		((Control)this).Refresh();
	}
}
