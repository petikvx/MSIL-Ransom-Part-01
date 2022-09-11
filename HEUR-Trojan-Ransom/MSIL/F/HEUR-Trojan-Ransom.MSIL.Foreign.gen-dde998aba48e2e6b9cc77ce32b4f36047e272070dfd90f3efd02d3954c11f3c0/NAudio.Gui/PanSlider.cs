using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows.Forms;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Gui;

public sealed class PanSlider : UserControl
{
	private Container components;

	private float pan;

	[NonSerialized]
	internal static GetString _0095;

	public float Pan
	{
		get
		{
			return pan;
		}
		set
		{
			if (value < -1f)
			{
				value = -1f;
			}
			if (value > 1f)
			{
				value = 1f;
			}
			if (value != pan)
			{
				pan = value;
				if (this.PanChanged != null)
				{
					this.PanChanged(this, EventArgs.Empty);
				}
				((Control)this).Invalidate();
			}
		}
	}

	public event EventHandler PanChanged;

	public PanSlider()
	{
		InitializeComponent();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((ContainerControl)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		((Control)this).set_Name(_0095(107395464));
		((Control)this).set_Size(new Size(104, 16));
	}

	protected override void OnPaint(PaintEventArgs pe)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringFormat val = new StringFormat();
		val.set_LineAlignment((StringAlignment)1);
		val.set_Alignment((StringAlignment)1);
		string text;
		if ((double)pan == 0.0)
		{
			pe.get_Graphics().FillRectangle(Brushes.get_Orange(), ((Control)this).get_Width() / 2 - 1, 1, 3, ((Control)this).get_Height() - 2);
			text = _0095(107395419);
		}
		else if (pan > 0f)
		{
			pe.get_Graphics().FillRectangle(Brushes.get_Orange(), ((Control)this).get_Width() / 2, 1, (int)((float)(((Control)this).get_Width() / 2) * pan), ((Control)this).get_Height() - 2);
			text = string.Format(_0095(107395414), pan * 100f);
		}
		else
		{
			pe.get_Graphics().FillRectangle(Brushes.get_Orange(), (int)((float)(((Control)this).get_Width() / 2) * (pan + 1f)), 1, (int)((float)(((Control)this).get_Width() / 2) * (0f - pan)), ((Control)this).get_Height() - 2);
			text = string.Format(_0095(107395433), pan * -100f);
		}
		pe.get_Graphics().DrawRectangle(Pens.get_Black(), 0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
		pe.get_Graphics().DrawString(text, ((Control)this).get_Font(), Brushes.get_Black(), (RectangleF)((Control)this).get_ClientRectangle(), val);
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)e.get_Button() == 1048576)
		{
			SetPanFromMouse(e.get_X());
		}
		((Control)this).OnMouseMove(e);
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		SetPanFromMouse(e.get_X());
		((UserControl)this).OnMouseDown(e);
	}

	private void SetPanFromMouse(int x)
	{
		Pan = (float)x / (float)((Control)this).get_Width() * 2f - 1f;
	}

	static PanSlider()
	{
		Strings.CreateGetStringDelegate(typeof(PanSlider));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0095(107397253), _0095(107397216)), _0095(107397211), _0095(107397206)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0095(107397233)))
		{
			return;
		}
		throw new SecurityException(_0095(107397176));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
