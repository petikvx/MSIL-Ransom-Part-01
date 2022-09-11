using System;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.FileFormats.Map;

public sealed class CakewalkDrumMapping
{
	[NonSerialized]
	internal static GetString _0080;

	public string NoteName { get; set; }

	public int InNote { get; set; }

	public int OutNote { get; set; }

	public int OutPort { get; set; }

	public int Channel { get; set; }

	public int VelocityAdjust { get; set; }

	public float VelocityScale { get; set; }

	public override string ToString()
	{
		return string.Format(_0080(107405318), NoteName, InNote, OutNote, Channel, OutPort, VelocityAdjust, VelocityScale * 100f);
	}

	static CakewalkDrumMapping()
	{
		Strings.CreateGetStringDelegate(typeof(CakewalkDrumMapping));
	}
}
