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

public sealed class VolumeMeter : Control
{
	private Brush foregroundBrush;

	private float amplitude;

	private IContainer components;

	[NonSerialized]
	internal static GetString _0017;

	[DefaultValue(-3.0)]
	public float Amplitude
	{
		get
		{
			return amplitude;
		}
		set
		{
			amplitude = value;
			((Control)this).Invalidate();
		}
	}

	[DefaultValue(-60.0)]
	public float MinDb { get; set; }

	[DefaultValue(18.0)]
	public float MaxDb { get; set; }

	[DefaultValue(/*Could not decode attribute arguments.*/)]
	public Orientation Orientation { get; set; }

	public VolumeMeter()
	{
		((Control)this).SetStyle((ControlStyles)139266, true);
		MinDb = -60f;
		MaxDb = 18f;
		Amplitude = 0f;
		Orientation = (Orientation)1;
		InitializeComponent();
		((Control)this).OnForeColorChanged(EventArgs.Empty);
	}

	protected override void OnForeColorChanged(EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		foregroundBrush = (Brush)new SolidBrush(((Control)this).get_ForeColor());
		((Control)this).OnForeColorChanged(e);
	}

	protected override void OnPaint(PaintEventArgs pe)
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		pe.get_Graphics().DrawRectangle(Pens.get_Black(), 0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
		double num = 20.0 * Math.Log10(Amplitude);
		if (num < (double)MinDb)
		{
			num = MinDb;
		}
		if (num > (double)MaxDb)
		{
			num = MaxDb;
		}
		double num2 = (num - (double)MinDb) / (double)(MaxDb - MinDb);
		int num3 = ((Control)this).get_Width() - 2;
		int num4 = ((Control)this).get_Height() - 2;
		if ((int)Orientation == 0)
		{
			num3 = (int)((double)num3 * num2);
			pe.get_Graphics().FillRectangle(foregroundBrush, 1, 1, num3, num4);
		}
		else
		{
			num4 = (int)((double)num4 * num2);
			pe.get_Graphics().FillRectangle(foregroundBrush, 1, ((Control)this).get_Height() - 1 - num4, num3, num4);
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Control)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		this.components = new System.ComponentModel.Container();
	}

	static VolumeMeter()
	{
		Strings.CreateGetStringDelegate(typeof(VolumeMeter));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0017(107397269), _0017(107397232)), _0017(107397227), _0017(107397222)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0017(107397249)))
		{
			return;
		}
		throw new SecurityException(_0017(107397192));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
