using System;
using System.Collections.Generic;
using System.Linq;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave.SampleProviders;

public sealed class ConcatenatingSampleProvider : ISampleProvider
{
	private readonly ISampleProvider[] providers;

	private int currentProviderIndex;

	[NonSerialized]
	internal static GetString _001C;

	public WaveFormat WaveFormat => providers[0].WaveFormat;

	public ConcatenatingSampleProvider(IEnumerable<ISampleProvider> providers)
	{
		if (providers == null)
		{
			throw new ArgumentNullException(_001C(107384163));
		}
		this.providers = providers.ToArray();
		if (this.providers.Length == 0)
		{
			throw new ArgumentException(_001C(107384630), _001C(107384163));
		}
		if (this.providers.Any((ISampleProvider p) => p.WaveFormat.Channels != WaveFormat.Channels))
		{
			throw new ArgumentException(_001C(107384585), _001C(107384163));
		}
		if (this.providers.Any((ISampleProvider p) => p.WaveFormat.SampleRate != WaveFormat.SampleRate))
		{
			throw new ArgumentException(_001C(107386735), _001C(107384163));
		}
	}

	public int Read(float[] buffer, int offset, int count)
	{
		int num = 0;
		while (num < count && currentProviderIndex < providers.Length)
		{
			int count2 = count - num;
			int num2 = providers[currentProviderIndex].Read(buffer, num, count2);
			num += num2;
			if (num2 == 0)
			{
				currentProviderIndex++;
			}
		}
		return num;
	}

	static ConcatenatingSampleProvider()
	{
		Strings.CreateGetStringDelegate(typeof(ConcatenatingSampleProvider));
	}
}
