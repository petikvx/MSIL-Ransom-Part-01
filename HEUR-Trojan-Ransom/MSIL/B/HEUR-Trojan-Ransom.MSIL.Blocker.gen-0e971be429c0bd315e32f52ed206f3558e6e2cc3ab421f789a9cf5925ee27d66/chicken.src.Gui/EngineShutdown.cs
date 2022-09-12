using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace chicken.src.Gui;

public class EngineShutdown : Form
{
	private IContainer hUHlHIVtIZNMyNATlFHUIjnUgWJBb = null;

	private Timer pjctolIhaJEcTMLwElqNyCLTyPSk;

	[DllImport("user32.dll")]
	public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

	[DllImport("user32.dll")]
	public static extern int SendMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);

	public EngineShutdown()
	{
		elGrDrgnJeFUoSEuIevkfWkCRVaIA();
		pjctolIhaJEcTMLwElqNyCLTyPSk.set_Enabled(true);
		pjctolIhaJEcTMLwElqNyCLTyPSk.set_Interval(50);
	}

	private void eMQerzbRFixfnloYSMMXamaqLbjz(object sender, EventArgs e)
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
		if (disposing && hUHlHIVtIZNMyNATlFHUIjnUgWJBb != null)
		{
			hUHlHIVtIZNMyNATlFHUIjnUgWJBb.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void elGrDrgnJeFUoSEuIevkfWkCRVaIA()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		hUHlHIVtIZNMyNATlFHUIjnUgWJBb = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(EngineShutdown));
		pjctolIhaJEcTMLwElqNyCLTyPSk = new Timer(hUHlHIVtIZNMyNATlFHUIjnUgWJBb);
		((Control)this).SuspendLayout();
		pjctolIhaJEcTMLwElqNyCLTyPSk.set_Enabled(true);
		pjctolIhaJEcTMLwElqNyCLTyPSk.add_Tick((EventHandler)eMQerzbRFixfnloYSMMXamaqLbjz);
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
