using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SmartAssembly.SmartExceptionsCore.UI;

[DesignerCategory("Code")]
public sealed class WaitSendingReportControl : Control
{
	private int m_Step = 99;

	private readonly Bitmap m_DataImage = Resources.GetBitmap("data");

	private readonly Bitmap m_NetworkImage = Resources.GetBitmap("network");

	private readonly Timer m_Timer = new Timer();

	private float m_Dx = 1f;

	private float m_Dy = 1f;

	protected override void OnVisibleChanged(EventArgs e)
	{
		((Control)this).OnVisibleChanged(e);
		if (!((Component)this).DesignMode)
		{
			Init(((Control)this).get_Visible());
		}
	}

	private void Init(bool run)
	{
		m_Timer.set_Enabled(run);
		m_Step = 0;
		((Control)this).Refresh();
	}

	protected override void OnResize(EventArgs e)
	{
		((Control)this).set_Size(new Size(Convert.ToInt32(250f * m_Dx), Convert.ToInt32(42f * m_Dy)));
		((Control)this).OnResize(e);
	}

	protected override void ScaleCore(float dx, float dy)
	{
		m_Dx = dx;
		m_Dy = dy;
		((Control)this).ScaleCore(dx, dy);
		((Control)this).OnResize(EventArgs.Empty);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			if (m_DataImage != null)
			{
				((Image)m_DataImage).Dispose();
			}
			((Component)(object)m_Timer).Dispose();
		}
		((Control)this).Dispose(disposing);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		((Control)this).OnPaint(e);
		if (m_NetworkImage != null)
		{
			e.get_Graphics().DrawImage((Image)(object)m_NetworkImage, new Rectangle(0, 0, Convert.ToInt32(250f * m_Dx), Convert.ToInt32(42f * m_Dy)), new Rectangle(0, 0, 250, 42), (GraphicsUnit)2);
		}
		if (m_DataImage != null && m_Step > 0)
		{
			e.get_Graphics().SetClip(new Rectangle(Convert.ToInt32(46f * m_Dx), 0, Convert.ToInt32(165f * m_Dx), Convert.ToInt32(34f * m_Dy)));
			e.get_Graphics().DrawImage((Image)(object)m_DataImage, new Rectangle(Convert.ToInt32((float)(m_Step - 6) * m_Dx), Convert.ToInt32(16f * m_Dy), Convert.ToInt32(40f * m_Dx), Convert.ToInt32(12f * m_Dy)), 0, 0, 40, 12, (GraphicsUnit)2);
		}
	}

	private void OnTimerTick(object sender, EventArgs e)
	{
		m_Step += 11;
		if (m_Step > 198)
		{
			m_Step = 0;
		}
		((Control)this).Refresh();
	}

	public WaitSendingReportControl()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		m_Timer.set_Interval(85);
		m_Timer.add_Tick((EventHandler)OnTimerTick);
		((Control)this).set_Size(new Size(250, 42));
		((Control)this).set_TabStop(false);
		((Control)this).SetStyle((ControlStyles)75794, true);
	}
}
