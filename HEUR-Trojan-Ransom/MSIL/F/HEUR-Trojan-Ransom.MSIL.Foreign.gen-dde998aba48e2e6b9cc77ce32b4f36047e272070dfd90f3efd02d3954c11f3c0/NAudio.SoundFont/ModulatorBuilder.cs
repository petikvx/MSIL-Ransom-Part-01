using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.SoundFont;

internal sealed class ModulatorBuilder : StructureBuilder<Modulator>
{
	[NonSerialized]
	internal static GetString _000F;

	public override int Length => 10;

	public Modulator[] Modulators => data.ToArray();

	public override Modulator Read(BinaryReader br)
	{
		Modulator modulator = new Modulator();
		modulator.SourceModulationData = new ModulatorType(br.ReadUInt16());
		modulator.DestinationGenerator = (GeneratorEnum)br.ReadUInt16();
		modulator.Amount = br.ReadInt16();
		modulator.SourceModulationAmount = new ModulatorType(br.ReadUInt16());
		modulator.SourceTransform = (TransformEnum)br.ReadUInt16();
		data.Add(modulator);
		return modulator;
	}

	public override void Write(BinaryWriter bw, Modulator o)
	{
	}

	static ModulatorBuilder()
	{
		Strings.CreateGetStringDelegate(typeof(ModulatorBuilder));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _000F(107397380), _000F(107397343)), _000F(107397338), _000F(107397333)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _000F(107397360)))
		{
			return;
		}
		throw new SecurityException(_000F(107397303));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
