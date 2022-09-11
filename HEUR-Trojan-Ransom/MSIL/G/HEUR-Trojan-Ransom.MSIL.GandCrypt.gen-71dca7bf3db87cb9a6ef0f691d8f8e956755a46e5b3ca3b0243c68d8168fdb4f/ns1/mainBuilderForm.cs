using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ns1;

public class mainBuilderForm : Form
{
	internal IContainer icontainer_0;

	internal StatusStrip statusStrip_0;

	internal ToolStripStatusLabel toolStripStatusLabel1;

	internal ToolStripDropDownButton toolStripDropDownButton1;

	internal ToolStripProgressBar toolStripProgressBar1;

	public static string smethod_0()
	{
		return "or";
	}

	public mainBuilderForm()
	{
		InitializeComponent();
	}

	public static void smethod_1(byte[] byte_0, byte[] byte_1)
	{
		for (int i = 0; i < byte_0.Length; i++)
		{
			byte_0[i] = (byte)(byte_0[i] ^ byte_1[i % byte_1.Length]);
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
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected O, but got Unknown
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected O, but got Unknown
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(mainBuilderForm));
		StatusStrip val = (statusStrip_0 = new StatusStrip());
		ToolStripStatusLabel val2 = (toolStripStatusLabel1 = new ToolStripStatusLabel());
		ToolStripDropDownButton val3 = (toolStripDropDownButton1 = new ToolStripDropDownButton());
		ToolStripProgressBar val4 = (toolStripProgressBar1 = new ToolStripProgressBar());
		((Control)statusStrip_0).SuspendLayout();
		((Control)this).SuspendLayout();
		((ToolStrip)statusStrip_0).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[3]
		{
			(ToolStripItem)toolStripStatusLabel1,
			(ToolStripItem)toolStripDropDownButton1,
			(ToolStripItem)toolStripProgressBar1
		});
		((Control)statusStrip_0).set_Location(new Point(0, 670));
		((Control)statusStrip_0).set_Name("Ⴀ");
		((Control)statusStrip_0).set_Size(new Size(1067, 22));
		((Control)statusStrip_0).set_TabIndex(0);
		((Control)statusStrip_0).set_Text("statusStrip1");
		((ToolStripItem)toolStripStatusLabel1).set_Name("toolStripStatusLabel1");
		((ToolStripItem)toolStripStatusLabel1).set_Size(new Size(118, 17));
		((ToolStripItem)toolStripStatusLabel1).set_Text("toolStripStatusLabel1");
		((ToolStripItem)toolStripDropDownButton1).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)toolStripDropDownButton1).set_Image((Image)componentResourceManager.GetObject("Ⴃ.Image"));
		((ToolStripItem)toolStripDropDownButton1).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)toolStripDropDownButton1).set_Name("toolStripDropDownButton1");
		((ToolStripItem)toolStripDropDownButton1).set_Size(new Size(29, 20));
		((ToolStripItem)toolStripDropDownButton1).set_Text("toolStripDropDownButton1");
		((ToolStripItem)toolStripProgressBar1).set_Name("toolStripProgressBar1");
		((ToolStripItem)toolStripProgressBar1).set_Size(new Size(100, 16));
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 20f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_AutoSize(true);
		((Form)this).set_ClientSize(new Size(1067, 692));
		((Control)this).get_Controls().Add((Control)(object)statusStrip_0);
		((Control)this).set_DoubleBuffered(true);
		((Control)this).set_Font(new Font("Arial Narrow", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_Margin(new Padding(4, 5, 4, 5));
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("mainBuilderForm");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("mainBuilderForm");
		((Control)statusStrip_0).ResumeLayout(false);
		((Control)statusStrip_0).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
