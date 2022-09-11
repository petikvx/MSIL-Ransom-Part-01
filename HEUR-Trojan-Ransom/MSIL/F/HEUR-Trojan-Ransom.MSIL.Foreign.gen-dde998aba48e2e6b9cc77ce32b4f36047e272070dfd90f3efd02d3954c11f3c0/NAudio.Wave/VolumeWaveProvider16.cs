using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave;

public sealed class VolumeWaveProvider16 : IWaveProvider
{
	private readonly IWaveProvider sourceProvider;

	private float volume;

	[NonSerialized]
	internal static GetString _0005;

	public float Volume
	{
		get
		{
			return volume;
		}
		set
		{
			volume = value;
		}
	}

	public WaveFormat WaveFormat => sourceProvider.WaveFormat;

	public VolumeWaveProvider16(IWaveProvider sourceProvider)
	{
		Volume = 1f;
		this.sourceProvider = sourceProvider;
		if (sourceProvider.WaveFormat.Encoding != WaveFormatEncoding.Pcm)
		{
			throw new ArgumentException(_0005(107386794));
		}
		if (sourceProvider.WaveFormat.BitsPerSample != 16)
		{
			throw new ArgumentException(_0005(107386765));
		}
	}

	public int Read(byte[] buffer, int offset, int count)
	{
		int num = sourceProvider.Read(buffer, offset, count);
		if (volume == 0f)
		{
			for (int i = 0; i < num; i++)
			{
				buffer[offset++] = 0;
			}
		}
		else if (volume != 1f)
		{
			for (int j = 0; j < num; j += 2)
			{
				short num2 = (short)((buffer[offset + 1] << 8) | buffer[offset]);
				float num3 = (float)num2 * volume;
				num2 = (short)num3;
				if (Volume > 1f)
				{
					if (num3 > 32767f)
					{
						num2 = short.MaxValue;
					}
					else if (num3 < -32768f)
					{
						num2 = short.MinValue;
					}
				}
				buffer[offset++] = (byte)((uint)num2 & 0xFFu);
				buffer[offset++] = (byte)(num2 >> 8);
			}
		}
		return num;
	}

	static VolumeWaveProvider16()
	{
		Strings.CreateGetStringDelegate(typeof(VolumeWaveProvider16));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0005(107398362), _0005(107398325)), _0005(107398320), _0005(107398315)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0005(107398342)))
		{
			return;
		}
		throw new SecurityException(_0005(107398285));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
