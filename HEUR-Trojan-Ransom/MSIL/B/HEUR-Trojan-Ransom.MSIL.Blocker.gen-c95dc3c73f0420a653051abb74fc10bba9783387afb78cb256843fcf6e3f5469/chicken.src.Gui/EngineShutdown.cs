using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace chicken.src.Gui;

public class EngineShutdown : Form
{
	private IContainer kIRxdvplOwoJsmagcKCtTAqXYlCQ;

	private Timer kxeYXQeMsmqcZftZFgjuUgWShLTR;

	[DllImport("user32.dll")]
	public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

	[DllImport("user32.dll")]
	public static extern int SendMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);

	public EngineShutdown()
	{
		tSSxvWKRPTkncrJVVkMRgnrXomxK();
		kxeYXQeMsmqcZftZFgjuUgWShLTR.set_Enabled(true);
		kxeYXQeMsmqcZftZFgjuUgWShLTR.set_Interval(50);
	}

	private void rEhRUzfJDTRjsVzZkRyNUlhxWsz(object sender, EventArgs e)
	{
		Thread.Sleep(500);
		IntPtr hWnd = FindWindow(null, "엔진차단");
		if (hWnd.ToString() != "0")
		{
			Thread.Sleep(2000);
			SendMessage(hWnd, 16u, 0, 0);
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && kIRxdvplOwoJsmagcKCtTAqXYlCQ != null)
		{
			kIRxdvplOwoJsmagcKCtTAqXYlCQ.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void tSSxvWKRPTkncrJVVkMRgnrXomxK()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		kIRxdvplOwoJsmagcKCtTAqXYlCQ = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(EngineShutdown));
		kxeYXQeMsmqcZftZFgjuUgWShLTR = new Timer(kIRxdvplOwoJsmagcKCtTAqXYlCQ);
		((Control)this).SuspendLayout();
		kxeYXQeMsmqcZftZFgjuUgWShLTR.set_Enabled(true);
		kxeYXQeMsmqcZftZFgjuUgWShLTR.add_Tick((EventHandler)rEhRUzfJDTRjsVzZkRyNUlhxWsz);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Control)this).set_BackColor(Color.DimGray);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Control)this).set_BackgroundImageLayout((ImageLayout)0);
		((Form)this).set_ClientSize(new Size(238, 147));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("EngineShutdown");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("엔진차단");
		((Form)this).set_TransparencyKey(Color.DimGray);
		((Control)this).ResumeLayout(false);
	}
}
