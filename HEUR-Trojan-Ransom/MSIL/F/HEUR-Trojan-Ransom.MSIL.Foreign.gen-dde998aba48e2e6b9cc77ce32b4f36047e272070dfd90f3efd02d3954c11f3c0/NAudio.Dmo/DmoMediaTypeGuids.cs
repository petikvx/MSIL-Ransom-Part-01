using System;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Dmo;

internal static class DmoMediaTypeGuids
{
	public static readonly Guid FORMAT_None;

	public static readonly Guid FORMAT_VideoInfo;

	public static readonly Guid FORMAT_VideoInfo2;

	public static readonly Guid FORMAT_WaveFormatEx;

	public static readonly Guid FORMAT_MPEGVideo;

	public static readonly Guid FORMAT_MPEGStreams;

	public static readonly Guid FORMAT_DvInfo;

	public static readonly Guid FORMAT_525WSS;

	[NonSerialized]
	internal static GetString _0011;

	static DmoMediaTypeGuids()
	{
		Strings.CreateGetStringDelegate(typeof(DmoMediaTypeGuids));
		FORMAT_None = new Guid(_0011(107391901));
		FORMAT_VideoInfo = new Guid(_0011(107391820));
		FORMAT_VideoInfo2 = new Guid(_0011(107391803));
		FORMAT_WaveFormatEx = new Guid(_0011(107392234));
		FORMAT_MPEGVideo = new Guid(_0011(107392217));
		FORMAT_MPEGStreams = new Guid(_0011(107392136));
		FORMAT_DvInfo = new Guid(_0011(107392119));
		FORMAT_525WSS = new Guid(_0011(107392038));
	}
}
