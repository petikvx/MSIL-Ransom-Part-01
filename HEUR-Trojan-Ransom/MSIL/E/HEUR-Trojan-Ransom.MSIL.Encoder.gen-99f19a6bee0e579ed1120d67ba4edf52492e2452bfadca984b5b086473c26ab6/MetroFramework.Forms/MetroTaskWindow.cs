using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Animation;
using MetroFramework.Components;
using MetroFramework.Controls;
using MetroFramework.Drawing;
using MetroFramework.Interfaces;
using MetroFramework.Native;

namespace MetroFramework.Forms;

public sealed class MetroTaskWindow : MetroForm
{
	private IContainer components;

	private MetroStyleManager metroStyleManager;

	private static MetroTaskWindow singletonWindow;

	private bool cancelTimer;

	private readonly int closeTime;

	private int elapsedTime;

	private int progressWidth;

	private DelayedCall timer;

	private readonly MetroPanel controlContainer;

	private bool isInitialized;

	public bool CancelTimer
	{
		get
		{
			return cancelTimer;
		}
		set
		{
			cancelTimer = value;
		}
	}

	private void InitializeComponent()
	{
		components = new Container();
		metroStyleManager = new MetroStyleManager(components);
		((ISupportInitialize)metroStyleManager).BeginInit();
		((Control)this).SuspendLayout();
		metroStyleManager.Owner = this;
		((Control)this).set_Name("MetroTaskWindow");
		((ISupportInitialize)metroStyleManager).EndInit();
		((Control)this).ResumeLayout(false);
	}

	public static void ShowTaskWindow(IWin32Window parent, string title, Control userControl, int secToClose)
	{
		if (singletonWindow != null)
		{
			((Form)singletonWindow).Close();
			((Component)(object)singletonWindow).Dispose();
			singletonWindow = null;
		}
		singletonWindow = new MetroTaskWindow(secToClose, userControl);
		((Control)singletonWindow).set_Text(title);
		singletonWindow.Resizable = false;
		((Form)singletonWindow).set_StartPosition((FormStartPosition)0);
		if (parent is IMetroForm metroForm && metroForm.StyleManager != null)
		{
			((IMetroStyledComponent)singletonWindow.metroStyleManager).InternalStyleManager = metroForm.StyleManager;
		}
		((Form)singletonWindow).Show(parent);
	}

	public static bool IsVisible()
	{
		if (singletonWindow != null)
		{
			return ((Control)singletonWindow).get_Visible();
		}
		return false;
	}

	public static void ShowTaskWindow(IWin32Window parent, string text, Control userControl)
	{
		ShowTaskWindow(parent, text, userControl, 0);
	}

	public static void ShowTaskWindow(string text, Control userControl, int secToClose)
	{
		ShowTaskWindow(null, text, userControl, secToClose);
	}

	public static void ShowTaskWindow(string text, Control userControl)
	{
		ShowTaskWindow(null, text, userControl);
	}

	public static void CancelAutoClose()
	{
		if (singletonWindow != null)
		{
			singletonWindow.CancelTimer = true;
		}
	}

	public static void ForceClose()
	{
		if (singletonWindow != null)
		{
			CancelAutoClose();
			((Form)singletonWindow).Close();
			((Component)(object)singletonWindow).Dispose();
			singletonWindow = null;
		}
	}

	public MetroTaskWindow()
	{
		controlContainer = new MetroPanel();
		((Control)this).get_Controls().Add((Control)(object)controlContainer);
	}

	public MetroTaskWindow(int duration, Control userControl)
		: this()
	{
		((Control)controlContainer).get_Controls().Add(userControl);
		userControl.set_Dock((DockStyle)5);
		closeTime = duration * 500;
		if (closeTime > 0)
		{
			timer = DelayedCall.Start(UpdateProgress, 5);
		}
	}

	protected override void OnActivated(EventArgs e)
	{
		if (!isInitialized)
		{
			((Form)this).set_MaximizeBox(false);
			((Form)this).set_MinimizeBox(false);
			base.Movable = false;
			((Form)this).set_TopMost(true);
			((Form)this).set_FormBorderStyle((FormBorderStyle)3);
			((Form)this).set_Size(new Size(400, 200));
			Taskbar taskbar = new Taskbar();
			switch (taskbar.Position)
			{
			default:
				((Form)this).set_Location(new Point(Screen.get_PrimaryScreen().get_Bounds().Width - ((Control)this).get_Width() - 5, Screen.get_PrimaryScreen().get_Bounds().Height - ((Control)this).get_Height() - 5));
				break;
			case TaskbarPosition.Left:
				((Form)this).set_Location(new Point(taskbar.Bounds.Width + 5, taskbar.Bounds.Height - ((Control)this).get_Height() - 5));
				break;
			case TaskbarPosition.Top:
				((Form)this).set_Location(new Point(taskbar.Bounds.Width - ((Control)this).get_Width() - 5, taskbar.Bounds.Height + 5));
				break;
			case TaskbarPosition.Right:
				((Form)this).set_Location(new Point(taskbar.Bounds.X - ((Control)this).get_Width() - 5, taskbar.Bounds.Height - ((Control)this).get_Height() - 5));
				break;
			case TaskbarPosition.Bottom:
				((Form)this).set_Location(new Point(taskbar.Bounds.Width - ((Control)this).get_Width() - 5, taskbar.Bounds.Y - ((Control)this).get_Height() - 5));
				break;
			}
			((Control)controlContainer).set_Location(new Point(0, 60));
			((Control)controlContainer).set_Size(new Size(((Control)this).get_Width() - 40, ((Control)this).get_Height() - 80));
			((Control)controlContainer).set_Anchor((AnchorStyles)15);
			isInitialized = true;
			MoveAnimation moveAnimation = new MoveAnimation();
			moveAnimation.Start((Control)(object)controlContainer, new Point(20, 60), TransitionType.EaseInOutCubic, 15);
		}
		base.OnActivated(e);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		base.OnPaint(e);
		SolidBrush val = new SolidBrush(MetroPaint.BackColor.Form(base.Theme));
		try
		{
			e.get_Graphics().FillRectangle((Brush)(object)val, new Rectangle(((Control)this).get_Width() - progressWidth, 0, progressWidth, 5));
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	private void UpdateProgress()
	{
		if (elapsedTime == closeTime)
		{
			timer.Dispose();
			timer = null;
			((Form)this).Close();
			return;
		}
		elapsedTime += 5;
		if (cancelTimer)
		{
			elapsedTime = 0;
		}
		double num = (double)elapsedTime / ((double)closeTime / 100.0);
		progressWidth = (int)((double)((Control)this).get_Width() * (num / 100.0));
		((Control)this).Invalidate(new Rectangle(0, 0, ((Control)this).get_Width(), 5));
		if (!cancelTimer)
		{
			timer.Reset();
		}
	}
}
