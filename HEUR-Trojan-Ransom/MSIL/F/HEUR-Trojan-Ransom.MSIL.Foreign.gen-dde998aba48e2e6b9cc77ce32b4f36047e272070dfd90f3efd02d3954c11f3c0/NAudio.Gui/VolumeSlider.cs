using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Gui;

public sealed class VolumeSlider : UserControl
{
	private Container components;

	private float volume = 1f;

	private float MinDb = -48f;

	[NonSerialized]
	internal static GetString _000F;

	[DefaultValue(1f)]
	public float Volume
	{
		get
		{
			return volume;
		}
		set
		{
			if (value < 0f)
			{
				value = 0f;
			}
			if (value > 1f)
			{
				value = 1f;
			}
			if (volume != value)
			{
				volume = value;
				if (this.VolumeChanged != null)
				{
					this.VolumeChanged(this, EventArgs.Empty);
				}
				((Control)this).Invalidate();
			}
		}
	}

	public event EventHandler VolumeChanged;

	public VolumeSlider()
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
		((Control)this).set_Name(_000F(107394798));
		((Control)this).set_Size(new Size(96, 16));
	}

	protected override void OnPaint(PaintEventArgs pe)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringFormat val = new StringFormat();
		val.set_LineAlignment((StringAlignment)1);
		val.set_Alignment((StringAlignment)1);
		pe.get_Graphics().DrawRectangle(Pens.get_Black(), 0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
		float num = 20f * (float)Math.Log10(Volume);
		float num2 = 1f - num / MinDb;
		pe.get_Graphics().FillRectangle(Brushes.get_LightGreen(), 1, 1, (int)((float)(((Control)this).get_Width() - 2) * num2), ((Control)this).get_Height() - 2);
		string text = string.Format(_000F(107394813), num);
		pe.get_Graphics().DrawString(text, ((Control)this).get_Font(), Brushes.get_Black(), (RectangleF)((Control)this).get_ClientRectangle(), val);
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)e.get_Button() == 1048576)
		{
			SetVolumeFromMouse(e.get_X());
		}
		((Control)this).OnMouseMove(e);
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		SetVolumeFromMouse(e.get_X());
		((UserControl)this).OnMouseDown(e);
	}

	private void SetVolumeFromMouse(int x)
	{
		float num = (1f - (float)x / (float)((Control)this).get_Width()) * MinDb;
		if (x <= 0)
		{
			Volume = 0f;
		}
		else
		{
			Volume = (float)Math.Pow(10.0, num / 20f);
		}
	}

	static VolumeSlider()
	{
		Strings.CreateGetStringDelegate(typeof(VolumeSlider));
	}
}
