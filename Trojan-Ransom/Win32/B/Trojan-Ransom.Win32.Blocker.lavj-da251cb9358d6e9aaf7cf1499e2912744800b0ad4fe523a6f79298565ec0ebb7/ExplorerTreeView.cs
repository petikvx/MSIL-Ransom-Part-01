using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public sealed class ExplorerTreeView : UserControl
{
	private IContainer icontainer_0;

	private Class2 treeWnd;

	public List<string> list_0;

	public ExplorerTreeView()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		InitializeComponent();
		list_0 = treeWnd.list_0;
		Class0.smethod_1(((Control)treeWnd).get_Handle());
		method_1();
		((TreeView)treeWnd).add_AfterCheck(new TreeViewEventHandler(treeWnd_AfterCheck));
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((ContainerControl)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		treeWnd = new Class2();
		((Control)this).SuspendLayout();
		((TreeView)treeWnd).set_CheckBoxes(true);
		((Control)treeWnd).set_Dock((DockStyle)5);
		((Control)treeWnd).set_Location(new Point(0, 0));
		((Control)treeWnd).set_Name("treeWnd");
		((Control)treeWnd).set_Size(new Size(289, 454));
		((Control)treeWnd).set_TabIndex(0);
		((TreeView)treeWnd).add_AfterSelect(new TreeViewEventHandler(treeWnd_AfterSelect));
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).get_Controls().Add((Control)(object)treeWnd);
		((Control)this).set_Name("ExplorerTreeView");
		((Control)this).set_Size(new Size(289, 454));
		((Control)this).ResumeLayout(false);
	}

	private void treeWnd_AfterCheck(object sender, TreeViewEventArgs e)
	{
		e.get_Node().Collapse();
		e.get_Node().Expand();
	}

	public void method_0()
	{
		((TreeView)treeWnd).get_Nodes().get_Item(0).Collapse();
		((TreeView)treeWnd).get_Nodes().get_Item(0).Expand();
	}

	private void method_1()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		Class14 @class = new Class14();
		TreeNode val = new TreeNode();
		val.set_Text(@class.method_2());
		val.set_ImageIndex(@class.method_4());
		val.set_SelectedImageIndex(@class.method_4());
		val.set_Tag((object)@class);
		ArrayList arrayList = @class.method_1();
		foreach (Class14 item in arrayList)
		{
			TreeNode val2 = new TreeNode();
			val2.set_Text(item.method_2());
			val2.set_ImageIndex(item.method_4());
			val2.set_SelectedImageIndex(item.method_4());
			val2.set_Tag((object)item);
			if (item.method_9() && item.method_11())
			{
				val2.get_Nodes().Add("PH");
			}
			val.get_Nodes().Add(val2);
		}
		((TreeView)treeWnd).get_Nodes().Clear();
		((TreeView)treeWnd).get_Nodes().Add(val);
		val.Expand();
	}

	private void treeWnd_AfterSelect(object sender, TreeViewEventArgs e)
	{
	}
}
