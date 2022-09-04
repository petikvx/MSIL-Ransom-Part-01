using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SmartAssembly.SmartExceptionsCore.UI;

public class FeedbackControl : Control
{
	private readonly Label m_Label = new Label();

	private Image m_Image;

	private bool m_ShowText;

	private readonly Timer m_Timer = new Timer();

	private bool m_ShowImage = true;

	private string m_ErrorMessage = string.Empty;

	private float m_Dx = 1f;

	private float m_Dy = 1f;

	public override string Text
	{
		get
		{
			return ((Control)this).get_Text();
		}
		set
		{
			((Control)this).set_Text(value);
			((Control)this).Refresh();
		}
	}

	public void Init()
	{
		m_Timer.set_Enabled(false);
		m_Image = null;
		m_ShowText = false;
		m_ErrorMessage = string.Empty;
		((Control)this).Refresh();
		((Control)this).set_Height(16);
	}

	public void Start()
	{
		m_Timer.set_Enabled(true);
		m_Image = (Image)(object)Resources.GetBitmap("current");
		m_ShowText = true;
		((Control)this).Refresh();
	}

	public void Stop()
	{
		Stop(string.Empty);
	}

	public void Stop(string string_0)
	{
		m_ErrorMessage = string_0;
		m_Timer.set_Enabled(false);
		m_Image = (Image)(object)Resources.GetBitmap((string_0.Length > 0) ? "error" : "ok");
		m_ShowImage = true;
		m_ShowText = true;
		if (string_0.Length > 0)
		{
			((Control)this).set_Height(100);
		}
		((Control)this).Refresh();
	}

	protected override void OnResize(EventArgs e)
	{
		((Control)m_Label).SetBounds(Convert.ToInt32(22f * m_Dx), Convert.ToInt32(m_Dy), ((Control)this).get_Width() - Convert.ToInt32(22f * m_Dx), ((Control)this).get_Height() - Convert.ToInt32(m_Dy));
		((Control)this).OnResize(e);
	}

	protected override void ScaleCore(float x, float y)
	{
		m_Dx = x;
		m_Dy = y;
		((Control)this).ScaleCore(x, y);
		((Control)this).OnResize(EventArgs.Empty);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		((Control)this).OnPaint(e);
		if (((Component)this).DesignMode)
		{
			m_Image = (Image)(object)Resources.GetBitmap("current");
			m_ShowText = true;
		}
		if (m_Image != null && m_ShowImage)
		{
			e.get_Graphics().DrawImage(m_Image, new Rectangle(0, 0, Convert.ToInt32(16f * m_Dx), Convert.ToInt32(16f * m_Dy)), new Rectangle(0, 0, 16, 16), (GraphicsUnit)2);
		}
		if (m_ShowText)
		{
			((Control)m_Label).set_Text((m_ErrorMessage.Length > 0) ? (((Control)this).get_Text() + " (" + m_ErrorMessage + ")") : ((Control)this).get_Text());
		}
		else
		{
			((Control)m_Label).set_Text(string.Empty);
		}
	}

	public FeedbackControl()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		m_Timer.set_Interval(250);
		m_Timer.add_Tick((EventHandler)OnTimerTick);
		m_Label.set_FlatStyle((FlatStyle)3);
		((Control)this).get_Controls().Add((Control)(object)m_Label);
		((Control)this).SetStyle((ControlStyles)75794, true);
		((Control)this).set_TabStop(false);
	}

	public FeedbackControl(string string_0)
		: this()
	{
		((Control)this).set_Text(" " + string_0);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			if (m_Image != null)
			{
				m_Image.Dispose();
			}
			((Component)(object)m_Timer).Dispose();
		}
		((Control)this).Dispose(disposing);
	}

	private void OnTimerTick(object sender, EventArgs e)
	{
		m_ShowImage = !m_ShowImage;
		((Control)this).Refresh();
	}
}
