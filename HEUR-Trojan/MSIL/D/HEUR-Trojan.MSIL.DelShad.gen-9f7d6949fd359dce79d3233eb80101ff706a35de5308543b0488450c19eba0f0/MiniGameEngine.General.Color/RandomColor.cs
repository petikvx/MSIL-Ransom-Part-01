using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace MiniGameEngine.General.Color;

public class RandomColor
{
	private Random random_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private byte byte_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private byte byte_1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private byte byte_2;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private byte byte_3;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private byte byte_4;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private byte byte_5;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private byte byte_6;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private byte byte_7;

	public byte minR
	{
		[CompilerGenerated]
		get
		{
			return byte_0;
		}
		[CompilerGenerated]
		set
		{
			byte_0 = value;
		}
	}

	public byte maxR
	{
		[CompilerGenerated]
		get
		{
			return byte_1;
		}
		[CompilerGenerated]
		set
		{
			byte_1 = value;
		}
	}

	public byte minG
	{
		[CompilerGenerated]
		get
		{
			return byte_2;
		}
		[CompilerGenerated]
		set
		{
			byte_2 = value;
		}
	}

	public byte maxG
	{
		[CompilerGenerated]
		get
		{
			return byte_3;
		}
		[CompilerGenerated]
		set
		{
			byte_3 = value;
		}
	}

	public byte minB
	{
		[CompilerGenerated]
		get
		{
			return byte_4;
		}
		[CompilerGenerated]
		set
		{
			byte_4 = value;
		}
	}

	public byte maxB
	{
		[CompilerGenerated]
		get
		{
			return byte_5;
		}
		[CompilerGenerated]
		set
		{
			byte_5 = value;
		}
	}

	public byte minA
	{
		[CompilerGenerated]
		get
		{
			return byte_6;
		}
		[CompilerGenerated]
		set
		{
			byte_6 = value;
		}
	}

	public byte maxA
	{
		[CompilerGenerated]
		get
		{
			return byte_7;
		}
		[CompilerGenerated]
		set
		{
			byte_7 = value;
		}
	}

	public RandomColor(byte minR, byte maxR, byte minG, byte maxG, byte minB, byte maxB, byte minA, byte maxA)
	{
		Class11.NQ1E32yzjMukk();
		base._002Ector();
		random_0 = new Random();
		this.minR = minR;
		this.maxR = maxR;
		this.minG = minG;
		this.maxG = maxG;
		this.minB = minB;
		this.maxB = maxB;
		this.minA = minA;
		this.maxA = maxA;
	}

	public System.Drawing.Color Next()
	{
		return System.Drawing.Color.FromArgb(((uint)minA > (uint)maxA) ? random_0.Next(maxA, minA) : random_0.Next(minA, maxA), ((uint)minR > (uint)maxR) ? random_0.Next(maxR, minR) : random_0.Next(minR, maxR), ((uint)minG > (uint)maxG) ? random_0.Next(maxG, minG) : random_0.Next(minG, maxG), ((uint)minB > (uint)maxB) ? random_0.Next(maxB, minB) : random_0.Next(minB, maxB));
	}
}
