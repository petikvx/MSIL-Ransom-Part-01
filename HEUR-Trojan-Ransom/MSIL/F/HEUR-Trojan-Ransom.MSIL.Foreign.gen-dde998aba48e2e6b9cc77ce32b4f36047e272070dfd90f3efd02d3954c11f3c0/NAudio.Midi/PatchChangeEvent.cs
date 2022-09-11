using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Midi;

public sealed class PatchChangeEvent : MidiEvent
{
	private byte patch;

	private static readonly string[] patchNames;

	[NonSerialized]
	internal static GetString _0018;

	public int Patch
	{
		get
		{
			return patch;
		}
		set
		{
			if (value < 0 || value > 127)
			{
				throw new ArgumentOutOfRangeException(_0018(107392497), _0018(107411577));
			}
			patch = (byte)value;
		}
	}

	public static string GetPatchName(int patchNumber)
	{
		return patchNames[patchNumber];
	}

	public PatchChangeEvent(BinaryReader br)
	{
		patch = br.ReadByte();
		if ((patch & 0x80u) != 0)
		{
			throw new FormatException(_0018(107411630));
		}
	}

	public PatchChangeEvent(long absoluteTime, int channel, int patchNumber)
		: base(absoluteTime, channel, MidiCommandCode.PatchChange)
	{
		Patch = patchNumber;
	}

	public override string ToString()
	{
		return string.Format(_0018(107397678), base.ToString(), GetPatchName(patch));
	}

	public override int GetAsShortMessage()
	{
		return base.GetAsShortMessage() + (patch << 8);
	}

	public override void Export(ref long absoluteTime, BinaryWriter writer)
	{
		base.Export(ref absoluteTime, writer);
		writer.Write(patch);
	}

	static PatchChangeEvent()
	{
		Strings.CreateGetStringDelegate(typeof(PatchChangeEvent));
		bool flag = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(_0018(107399268), _0018(107399231)).Replace(_0018(107399226), _0018(107399221)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, true, out flag) || !flag || !executingAssembly.FullName!.EndsWith(_0018(107399248)))
		{
			throw new SecurityException(_0018(107399191));
		}
		patchNames = new string[128]
		{
			_0018(107411556),
			_0018(107411535),
			_0018(107411482),
			_0018(107411493),
			_0018(107411444),
			_0018(107411931),
			_0018(107411906),
			_0018(107411921),
			_0018(107411912),
			_0018(107411867),
			_0018(107411882),
			_0018(107411837),
			_0018(107411852),
			_0018(107411807),
			_0018(107411826),
			_0018(107411773),
			_0018(107411792),
			_0018(107411739),
			_0018(107411714),
			_0018(107411729),
			_0018(107411168),
			_0018(107411183),
			_0018(107411138),
			_0018(107411125),
			_0018(107411104),
			_0018(107411071),
			_0018(107411038),
			_0018(107411009),
			_0018(107410976),
			_0018(107410943),
			_0018(107410950),
			_0018(107411437),
			_0018(107411380),
			_0018(107411359),
			_0018(107411330),
			_0018(107411333),
			_0018(107411312),
			_0018(107411263),
			_0018(107411278),
			_0018(107411229),
			_0018(107411244),
			_0018(107411235),
			_0018(107411194),
			_0018(107411217),
			_0018(107410656),
			_0018(107410667),
			_0018(107410642),
			_0018(107410585),
			_0018(107410604),
			_0018(107410547),
			_0018(107410522),
			_0018(107410533),
			_0018(107410512),
			_0018(107410463),
			_0018(107410478),
			_0018(107410429),
			_0018(107410440),
			_0018(107410907),
			_0018(107410926),
			_0018(107410917),
			_0018(107410896),
			_0018(107410847),
			_0018(107410858),
			_0018(107410809),
			_0018(107410824),
			_0018(107410775),
			_0018(107410794),
			_0018(107410749),
			_0018(107410764),
			_0018(107410755),
			_0018(107410738),
			_0018(107410725),
			_0018(107410680),
			_0018(107410699),
			_0018(107410146),
			_0018(107410133),
			_0018(107410152),
			_0018(107410103),
			_0018(107410118),
			_0018(107410073),
			_0018(107410092),
			_0018(107410039),
			_0018(107410014),
			_0018(107410021),
			_0018(107410000),
			_0018(107409943),
			_0018(107409922),
			_0018(107409933),
			_0018(107410388),
			_0018(107410367),
			_0018(107410382),
			_0018(107410325),
			_0018(107410304),
			_0018(107410315),
			_0018(107410290),
			_0018(107410241),
			_0018(107410252),
			_0018(107410203),
			_0018(107410178),
			_0018(107410189),
			_0018(107409620),
			_0018(107409595),
			_0018(107409606),
			_0018(107409585),
			_0018(107409532),
			_0018(107409523),
			_0018(107409546),
			_0018(107409501),
			_0018(107409492),
			_0018(107409511),
			_0018(107409466),
			_0018(107409489),
			_0018(107409480),
			_0018(107409431),
			_0018(107409454),
			_0018(107409405),
			_0018(107409424),
			_0018(107409887),
			_0018(107409902),
			_0018(107409853),
			_0018(107409864),
			_0018(107409839),
			_0018(107409790),
			_0018(107409809),
			_0018(107409760),
			_0018(107409771),
			_0018(107409722),
			_0018(107409741)
		};
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
