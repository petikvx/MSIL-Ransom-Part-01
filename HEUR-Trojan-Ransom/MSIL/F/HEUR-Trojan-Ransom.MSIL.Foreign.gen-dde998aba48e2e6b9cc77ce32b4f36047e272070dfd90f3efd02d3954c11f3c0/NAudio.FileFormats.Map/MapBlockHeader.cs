using System;
using System.IO;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.FileFormats.Map;

internal sealed class MapBlockHeader
{
	private int length;

	private int value2;

	private short value3;

	private short value4;

	[NonSerialized]
	internal static GetString _0005;

	public int Length => length;

	public static MapBlockHeader Read(BinaryReader reader)
	{
		return new MapBlockHeader
		{
			length = reader.ReadInt32(),
			value2 = reader.ReadInt32(),
			value3 = reader.ReadInt16(),
			value4 = reader.ReadInt16()
		};
	}

	public override string ToString()
	{
		return string.Format(_0005(107404466), length, value2, value3, value4);
	}

	static MapBlockHeader()
	{
		Strings.CreateGetStringDelegate(typeof(MapBlockHeader));
	}
}
