using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ax1667.Filter;

namespace Llfwvpucq.Tasks;

public class ObjectValueTask : Form
{
	private IContainer m_Configuration;

	private ListBox wrapper;

	public ObjectValueTask()
	{
		CloneConfiguration();
	}

	private void RemoveConfiguration(object sender, EventArgs e)
	{
		Consumer consumer = new Consumer();
		wrapper.get_Items().Add((object)consumer.VisitConfiguration());
	}

	protected override void Dispose(bool isinit)
	{
		if (isinit && m_Configuration != null)
		{
			m_Configuration.Dispose();
		}
		((Form)this).Dispose(isinit);
	}

	private void CloneConfiguration()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		wrapper = new ListBox();
		((Control)this).SuspendLayout();
		((ListControl)wrapper).set_FormattingEnabled(true);
		((Control)wrapper).set_Location(new Point(12, 12));
		((Control)wrapper).set_Name("listBox1");
		((Control)wrapper).set_Size(new Size(120, 95));
		((Control)wrapper).set_TabIndex(0);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(648, 352));
		((Control)this).get_Controls().Add((Control)(object)wrapper);
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Form1");
		((Form)this).add_Load((EventHandler)RemoveConfiguration);
		((Control)this).ResumeLayout(false);
	}
}
