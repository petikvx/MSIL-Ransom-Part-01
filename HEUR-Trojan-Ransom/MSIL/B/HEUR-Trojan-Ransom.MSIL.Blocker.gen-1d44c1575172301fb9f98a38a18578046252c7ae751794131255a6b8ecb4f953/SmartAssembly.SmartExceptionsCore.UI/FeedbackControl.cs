using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ns0;

namespace SmartAssembly.SmartExceptionsCore.UI;

[DesignerCategory("Code")]
public class FeedbackControl : Control
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 71948)]
	private struct Struct10
	{
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1938)]
	private struct Struct11
	{
	}

	private readonly Label label_0 = new Label();

	private bool bool_0;

	private readonly Timer timer_0 = new Timer();

	private string string_0 = string.Empty;

	internal static byte byte_0/* Not supported: data(00) */;

	private static readonly Array array_0;

	private static readonly Array array_1 = new char[969];

	private static readonly object object_0;

	internal static byte byte_1/* Not supported: data(00) */;

	internal Image image_0;

	internal bool bool_1 = true;

	internal float float_0;

	internal float float_1;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	[Browsable(true)]
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
		string_0 = string.Empty;
		((Control)this).Refresh();
		((Control)this).set_Height(16);
	}

	public void Start()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		timer_0.set_Enabled(true);
		Image val = (image_0 = (Image)Class18.smethod_0("current"));
		bool_0 = true;
		((Control)this).Refresh();
	}

	public void Stop()
	{
		Stop(string.Empty);
	}

	public void Stop(string errorMessage)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		string_0 = errorMessage;
		timer_0.set_Enabled(false);
		Image val = (image_0 = (Image)Class18.smethod_0((errorMessage.Length > 0) ? "error" : "ok"));
		bool_1 = true;
		bool_0 = true;
		if (errorMessage.Length > 0)
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
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		((Control)this).OnPaint(e);
		if (((Component)this).DesignMode)
		{
			Image val = (image_0 = (Image)Class18.smethod_0("current"));
			bool_0 = true;
		}
		if (image_0 != null && bool_1)
		{
			e.get_Graphics().DrawImage(image_0, new Rectangle(0, 0, Convert.ToInt32(16f * float_0), Convert.ToInt32(16f * float_1)), new Rectangle(0, 0, 16, 16), (GraphicsUnit)2);
		}
		if (bool_0)
		{
			((Control)label_0).set_Text((string_0.Length > 0) ? (((Control)this).get_Text() + " (" + string_0 + ")") : ((Control)this).get_Text());
		}
		else
		{
			((Control)label_0).set_Text(string.Empty);
		}
	}

	public FeedbackControl()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		float num = (float_0 = 1f);
		float num2 = (float_1 = 1f);
		((Control)this)._002Ector();
		timer_0.set_Interval(250);
		timer_0.add_Tick((EventHandler)timer_0_Tick);
		label_0.set_FlatStyle((FlatStyle)3);
		((Control)this).get_Controls().Add((Control)(object)label_0);
		((Control)this).SetStyle((ControlStyles)75794, true);
		((Control)this).set_TabStop(false);
	}

	public FeedbackControl(string text)
		: this()
	{
		((Control)this).set_Text(" " + text);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			if (image_0 != null)
			{
				image_0.Dispose();
			}
			((Component)(object)timer_0).Dispose();
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
		char[] array = new char[8];
		array[4] = '⽞';
		array[1] = 'ဌ';
		array[7] = '፼';
		array[5] = '㔘';
		array[6] = '⥰';
		array[2] = '㫟';
		array[0] = 'Ტ';
		array[3] = 'ᦤ';
		object_0 = new string[44];
		array_0 = array;
	}
}
