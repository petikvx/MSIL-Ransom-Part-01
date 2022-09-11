using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows.Forms;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Gui;

public sealed class WaveformPainter : Control
{
	private Pen foregroundPen;

	private List<float> samples = new List<float>(1000);

	private int maxSamples;

	private int insertPos;

	private IContainer components;

	[NonSerialized]
	internal static GetString _0081;

	public WaveformPainter()
	{
		((Control)this).SetStyle((ControlStyles)139266, true);
		InitializeComponent();
		((Control)this).OnForeColorChanged(EventArgs.Empty);
		((Control)this).OnResize(EventArgs.Empty);
	}

	protected override void OnResize(EventArgs e)
	{
		maxSamples = ((Control)this).get_Width();
		((Control)this).OnResize(e);
	}

	protected override void OnForeColorChanged(EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		foregroundPen = new Pen(((Control)this).get_ForeColor());
		((Control)this).OnForeColorChanged(e);
	}

	public void AddMax(float maxSample)
	{
		if (maxSamples != 0)
		{
			if (samples.Count <= maxSamples)
			{
				samples.Add(maxSample);
			}
			else if (insertPos < maxSamples)
			{
				samples[insertPos] = maxSample;
			}
			insertPos++;
			insertPos %= maxSamples;
			((Control)this).Invalidate();
		}
	}

	protected override void OnPaint(PaintEventArgs pe)
	{
		((Control)this).OnPaint(pe);
		for (int i = 0; i < ((Control)this).get_Width(); i++)
		{
			float num = (float)((Control)this).get_Height() * GetSample(i - ((Control)this).get_Width() + insertPos);
			float num2 = ((float)((Control)this).get_Height() - num) / 2f;
			pe.get_Graphics().DrawLine(foregroundPen, (float)i, num2, (float)i, num2 + num);
		}
	}

	private float GetSample(int index)
	{
		if (index < 0)
		{
			index += maxSamples;
		}
		if ((index >= 0) & (index < samples.Count))
		{
			return samples[index];
		}
		return 0f;
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

	static WaveformPainter()
	{
		Strings.CreateGetStringDelegate(typeof(WaveformPainter));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0081(107397280), _0081(107397243)), _0081(107397238), _0081(107397233)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0081(107397260)))
		{
			return;
		}
		throw new SecurityException(_0081(107397203));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
