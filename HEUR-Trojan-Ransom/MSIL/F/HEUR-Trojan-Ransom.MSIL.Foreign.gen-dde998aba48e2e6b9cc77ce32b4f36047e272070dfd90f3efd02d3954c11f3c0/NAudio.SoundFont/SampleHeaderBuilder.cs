using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using NAudio.Utils;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.SoundFont;

internal sealed class SampleHeaderBuilder : StructureBuilder<SampleHeader>
{
	[NonSerialized]
	internal static GetString _0002;

	public override int Length => 46;

	public SampleHeader[] SampleHeaders => data.ToArray();

	public override SampleHeader Read(BinaryReader br)
	{
		SampleHeader sampleHeader = new SampleHeader();
		byte[] array = br.ReadBytes(20);
		sampleHeader.SampleName = ByteEncoding.Instance.GetString(array, 0, array.Length);
		sampleHeader.Start = br.ReadUInt32();
		sampleHeader.End = br.ReadUInt32();
		sampleHeader.StartLoop = br.ReadUInt32();
		sampleHeader.EndLoop = br.ReadUInt32();
		sampleHeader.SampleRate = br.ReadUInt32();
		sampleHeader.OriginalPitch = br.ReadByte();
		sampleHeader.PitchCorrection = br.ReadSByte();
		sampleHeader.SampleLink = br.ReadUInt16();
		sampleHeader.SFSampleLink = (SFSampleLink)br.ReadUInt16();
		data.Add(sampleHeader);
		return sampleHeader;
	}

	public override void Write(BinaryWriter bw, SampleHeader sampleHeader)
	{
	}

	internal void RemoveEOS()
	{
		data.RemoveAt(data.Count - 1);
	}

	static SampleHeaderBuilder()
	{
		Strings.CreateGetStringDelegate(typeof(SampleHeaderBuilder));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0002(107397439), _0002(107397402)), _0002(107397397), _0002(107397392)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0002(107397419)))
		{
			return;
		}
		throw new SecurityException(_0002(107397362));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
