using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Security;
using System.Windows.Forms;
using SmartAssembly.SmartUsageCore;
using SmartAssembly.Zip;
using ns0;

namespace SmartAssembly.SmartExceptionsCore.UI;

[DesignerCategory("Code")]
public class FeedbackControl : Control
{
	internal Label label_0;

	internal Image image_0;

	internal bool bool_0;

	internal Timer timer_0;

	internal bool bool_1;

	internal string string_0;

	internal float float_0;

	internal float float_1;

	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	public override string Text
	{
		get
		{
			return ((Control)this).get_Text();
		}
		set
		{
			((Control)this).set_Text(value);
			SmartAssembly.SmartUsageCore.DoNotObfuscateAttribute.smethod_2((Control)(object)this, 204, 133);
		}
	}

	public void Init()
	{
		timer_0.set_Enabled(false);
		Image val = (image_0 = null);
		bool_0 = false;
		string text = (string_0 = string.Empty);
		SmartAssembly.SmartUsageCore.DoNotObfuscateAttribute.smethod_2((Control)(object)this, 2, 75);
		((Control)this).set_Height(16);
	}

	public void Start()
	{
		timer_0.set_Enabled(true);
		Image val = (image_0 = (Image)(object)Class21.smethod_0("current"));
		bool_0 = true;
		((Control)this).Refresh();
	}

	public void Stop()
	{
		Stop(string.Empty);
	}

	public void Stop(string errorMessage)
	{
		string text = (string_0 = errorMessage);
		timer_0.set_Enabled(false);
		Image val = (image_0 = (Image)(object)Class21.smethod_0((Class3.smethod_1(errorMessage, 851, 827) > 0) ? "error" : "ok"));
		bool_1 = true;
		bool_0 = true;
		if (Class3.smethod_1(errorMessage, 387, 491) > 0)
		{
			((Control)this).set_Height(100);
		}
		((Control)this).Refresh();
	}

	protected override void OnResize(EventArgs e)
	{
		((Control)label_0).SetBounds(Convert.ToInt32(22f * float_0), Convert.ToInt32(float_1), ((Control)this).get_Width() - Convert.ToInt32(22f * float_0), ((Control)this).get_Height() - Convert.ToInt32(float_1));
		((Control)this).OnResize(e);
	}

	protected override void ScaleCore(float dx, float dy)
	{
		float num = (float_0 = dx);
		float num2 = (float_1 = dy);
		((Control)this).ScaleCore(dx, dy);
		((Control)this).OnResize(EventArgs.Empty);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		((Control)this).OnPaint(e);
		if (((Component)this).DesignMode)
		{
			Image val = (image_0 = (Image)(object)Class21.smethod_0("current"));
			bool_0 = true;
		}
		if (image_0 != null && bool_1)
		{
			Class34.smethod_2(e, 45, 29).DrawImage(image_0, new Rectangle(0, 0, Convert.ToInt32(16f * float_0), Convert.ToInt32(16f * float_1)), new Rectangle(0, 0, 16, 16), (GraphicsUnit)2);
		}
		if (bool_0)
		{
			((Control)label_0).set_Text((Class3.smethod_1(string_0, 197, 173) > 0) ? (((Control)this).get_Text() + " (" + string_0 + ")") : ((Control)this).get_Text());
		}
		else
		{
			((Control)label_0).set_Text(string.Empty);
		}
	}

	public FeedbackControl()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		Label val = (label_0 = new Label());
		Timer val2 = (timer_0 = new Timer());
		bool_1 = true;
		string text = (string_0 = string.Empty);
		float num = (float_0 = 1f);
		float num2 = (float_1 = 1f);
		((Control)this)._002Ector();
		timer_0.set_Interval(250);
		timer_0.add_Tick((EventHandler)timer_0_Tick);
		Class23.smethod_4(label_0, (FlatStyle)3, 563, 593);
		SimpleZip.Class9.smethod_0((Control)(object)this, 147, 196).Add((Control)(object)label_0);
		((Control)this).SetStyle((ControlStyles)75794, true);
		((Control)this).set_TabStop(false);
	}

	public FeedbackControl(string text)
		: this()
	{
		((Control)this).set_Text(Class35.smethod_8(" ", text, 924, 1010));
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			if (image_0 != null)
			{
				image_0.Dispose();
			}
			WaitSendingReportControl.smethod_2((Component)(object)timer_0, 508, 406);
		}
		((Control)this).Dispose(disposing);
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		bool flag = (bool_1 = !bool_1);
		SmartAssembly.SmartUsageCore.DoNotObfuscateAttribute.smethod_2((Control)(object)this, 348, 277);
	}

	[SecuritySafeCritical]
	static FeedbackControl()
	{
		Class32.smethod_1();
	}

	[SecuritySafeCritical]
	internal static void smethod_0(Control control_0, Point point_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 120:
				control_0.set_Location(point_0);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string smethod_1(string string_1, object object_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 18:
				return string.Format(string_1, object_0);
			}
		}
	}

	[SecuritySafeCritical]
	internal static long smethod_2(Stream stream_0, long long_0, SeekOrigin seekOrigin_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 106:
				return stream_0.Seek(long_0, seekOrigin_0);
			}
		}
	}
}
