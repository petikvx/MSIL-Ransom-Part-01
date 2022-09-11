using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave;

public sealed class CueWaveFileWriter : WaveFileWriter
{
	private CueList cues;

	[NonSerialized]
	internal static GetString _0015;

	public CueWaveFileWriter(string fileName, WaveFormat waveFormat)
		: base(fileName, waveFormat)
	{
	}

	public void AddCue(int position, string label)
	{
		if (cues == null)
		{
			cues = new CueList();
		}
		cues.Add(new Cue(position, label));
	}

	private void WriteCues(BinaryWriter w)
	{
		if (cues != null)
		{
			int count = cues.GetRIFFChunks().Length;
			w.Seek(0, SeekOrigin.End);
			if (w.BaseStream.Length % 2 == 1)
			{
				w.Write((byte)0);
			}
			w.Write(cues.GetRIFFChunks(), 0, count);
			w.Seek(4, SeekOrigin.Begin);
			w.Write((int)(w.BaseStream.Length - 8));
		}
	}

	protected override void UpdateHeader(BinaryWriter writer)
	{
		base.UpdateHeader(writer);
		WriteCues(writer);
	}

	static CueWaveFileWriter()
	{
		Strings.CreateGetStringDelegate(typeof(CueWaveFileWriter));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0015(107398128), _0015(107398091)), _0015(107398086), _0015(107398081)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0015(107398108)))
		{
			return;
		}
		throw new SecurityException(_0015(107398051));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
