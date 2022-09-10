using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.Serialization;
using System.Windows.Forms;
using SmartAssembly.SmartExceptionsWithUI;
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
			((Control)this).Refresh();
		}
	}

	public void Init()
	{
		timer_0.set_Enabled(false);
		Image val = (image_0 = null);
		bool_0 = false;
		string text = (string_0 = string.Empty);
		((Control)this).Refresh();
		((Control)this).set_Height(16);
	}

	public void Start()
	{
		timer_0.set_Enabled(true);
		Image val = (image_0 = (Image)(object)Class19.smethod_0("current"));
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
		Image val = (image_0 = (Image)(object)Class19.smethod_0((PoweredBy.smethod_0(errorMessage, 487, 439) > 0) ? "error" : "ok"));
		bool_1 = true;
		bool_0 = true;
		if (PoweredBy.smethod_0(errorMessage, 128, 208) > 0)
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
			Image val = (image_0 = (Image)(object)Class19.smethod_0("current"));
			bool_0 = true;
		}
		if (image_0 != null && bool_1)
		{
			e.get_Graphics().DrawImage(image_0, new Rectangle(0, 0, Convert.ToInt32(16f * float_0), Convert.ToInt32(16f * float_1)), new Rectangle(0, 0, 16, 16), (GraphicsUnit)2);
		}
		if (bool_0)
		{
			((Control)label_0).set_Text((PoweredBy.smethod_0(string_0, 1016, 936) > 0) ? (((Control)this).get_Text() + " (" + string_0 + ")") : ((Control)this).get_Text());
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
		label_0.set_FlatStyle((FlatStyle)3);
		PoweredBy.smethod_2((Control)(object)this, 977, 942).Add((Control)(object)label_0);
		((Control)this).SetStyle((ControlStyles)75794, true);
		((Control)this).set_TabStop(false);
	}

	public FeedbackControl(string text)
		: this()
	{
		((Control)this).set_Text(ReportSender.smethod_0(" ", text, 995, 896));
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			if (image_0 != null)
			{
				UnhandledExceptionHandlerWithUI.smethod_1(image_0, 480, 496);
			}
			Class30.smethod_2((Component)(object)timer_0, 413, 384);
		}
		((Control)this).Dispose(disposing);
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		bool flag = (bool_1 = !bool_1);
		((Control)this).Refresh();
	}

	static FeedbackControl()
	{
		DESCryptoIndirector.smethod_0();
	}

	internal static Type smethod_0(object object_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 122:
				return object_0.GetType();
			}
		}
	}

	internal static void smethod_1(SerializationInfo serializationInfo_0, string string_1, object object_0, Type type_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 3:
				serializationInfo_0.AddValue(string_1, object_0, type_0);
				return;
			}
		}
	}

	internal static MethodBase smethod_2(StackFrame stackFrame_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 93:
				return stackFrame_0.GetMethod();
			}
		}
	}

	internal static string smethod_3(ref uint uint_0, string string_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 79:
				return uint_0.ToString(string_1);
			}
		}
	}
}
