using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ns0;

public class @_ : Form
{
	private IContainer icontainer_0;

	private ListView listView_0;

	private ColumnHeader columnHeader_0;

	public _()
	{
		InitializeComponent();
	}

	private void __Load(object sender, EventArgs e)
	{
		string text = Environment.GetCommandLineArgs()[0];
		foreach (char c2 in text)
		{
			listView_0.get_Items().get_Item(1).get_SubItems()
				.Add(c2.ToString());
		}
	}

	protected override void vmethod_0(bool bool_0)
	{
		if (bool_0 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(bool_0);
	}

	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		listView_0 = new ListView();
		columnHeader_0 = new ColumnHeader();
		((Control)this).SuspendLayout();
		listView_0.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[1] { columnHeader_0 });
		((Control)listView_0).set_Dock((DockStyle)5);
		listView_0.set_GridLines(true);
		((Control)listView_0).set_Location(new Point(0, 0));
		((Control)listView_0).set_Name("Ⴗ");
		((Control)listView_0).set_Size(new Size(349, 352));
		((Control)listView_0).set_TabIndex(0);
		listView_0.set_UseCompatibleStateImageBehavior(false);
		listView_0.set_View((View)1);
		columnHeader_0.set_Width(337);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(349, 352));
		((Control)this).get_Controls().Add((Control)(object)listView_0);
		((Form)this).set_FormBorderStyle((FormBorderStyle)2);
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("_");
		((Control)this).set_Text(" ");
		((Form)this).add_Load((EventHandler)__Load);
		((Control)this).ResumeLayout(false);
	}
}
