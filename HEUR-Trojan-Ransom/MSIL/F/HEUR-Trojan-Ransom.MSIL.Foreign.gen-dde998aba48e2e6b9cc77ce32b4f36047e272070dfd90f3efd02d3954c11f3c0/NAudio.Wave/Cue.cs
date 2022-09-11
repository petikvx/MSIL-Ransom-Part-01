using System;
using System.Text.RegularExpressions;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave;

public sealed class Cue
{
	[NonSerialized]
	internal static GetString _0088;

	public int Position { get; private set; }

	public string Label { get; private set; }

	public Cue(int position, string label)
	{
		Position = position;
		if (label == null)
		{
			label = _0088(107398771);
		}
		Label = Regex.Replace(label, _0088(107385926), _0088(107398771));
	}

	static Cue()
	{
		Strings.CreateGetStringDelegate(typeof(Cue));
	}
}
