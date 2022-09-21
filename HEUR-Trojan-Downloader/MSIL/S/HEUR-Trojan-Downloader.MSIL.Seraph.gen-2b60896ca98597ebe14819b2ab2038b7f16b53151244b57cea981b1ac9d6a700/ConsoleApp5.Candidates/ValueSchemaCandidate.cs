using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ConsoleApp5.Candidates;

public sealed class ValueSchemaCandidate : Form
{
	private IContainer schema;

	private CheckedListBox m_Mapping;

	public ValueSchemaCandidate()
	{
		FindInitializer();
	}

	private void PopInitializer(object sender, EventArgs e)
	{
	}

	protected override void Dispose(bool allowi)
	{
		if (allowi && schema != null)
		{
			schema.Dispose();
		}
		((Form)this).Dispose(allowi);
	}

	private void FindInitializer()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		m_Mapping = new CheckedListBox();
		((Control)this).SuspendLayout();
		((ListControl)m_Mapping).set_FormattingEnabled(true);
		((ObjectCollection)m_Mapping.get_Items()).AddRange(new object[4] { "1", "2", "3", "4" });
		((Control)m_Mapping).set_Location(new Point(172, 87));
		((Control)m_Mapping).set_Name("checkedListBox1");
		((Control)m_Mapping).set_Size(new Size(120, 94));
		((Control)m_Mapping).set_TabIndex(0);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).get_Controls().Add((Control)(object)m_Mapping);
		((Control)this).set_Name("Form3");
		((Control)this).set_Text("Form3");
		((Form)this).add_Load((EventHandler)PopInitializer);
		((Control)this).ResumeLayout(false);
	}
}
