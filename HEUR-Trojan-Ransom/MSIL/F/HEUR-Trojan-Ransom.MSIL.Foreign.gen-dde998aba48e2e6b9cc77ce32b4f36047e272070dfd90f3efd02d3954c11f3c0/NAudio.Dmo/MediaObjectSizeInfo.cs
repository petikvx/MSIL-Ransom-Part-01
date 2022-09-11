using System;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Dmo;

public sealed class MediaObjectSizeInfo
{
	[NonSerialized]
	internal static GetString _009F;

	public int Size { get; private set; }

	public int MaxLookahead { get; private set; }

	public int Alignment { get; private set; }

	public MediaObjectSizeInfo(int size, int maxLookahead, int alignment)
	{
		Size = size;
		MaxLookahead = maxLookahead;
		Alignment = alignment;
	}

	public override string ToString()
	{
		return string.Format(_009F(107391405), Size, Alignment, MaxLookahead);
	}

	static MediaObjectSizeInfo()
	{
		Strings.CreateGetStringDelegate(typeof(MediaObjectSizeInfo));
	}
}
