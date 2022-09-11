using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave;

public sealed class RiffChunk
{
	[NonSerialized]
	internal static GetString _0083;

	public int Identifier { get; private set; }

	public string IdentifierAsString => Encoding.UTF8.GetString(BitConverter.GetBytes(Identifier));

	public int Length { get; private set; }

	public long StreamPosition { get; private set; }

	public RiffChunk(int identifier, int length, long streamPosition)
	{
		Identifier = identifier;
		Length = length;
		StreamPosition = streamPosition;
	}

	static RiffChunk()
	{
		Strings.CreateGetStringDelegate(typeof(RiffChunk));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0083(107398483), _0083(107398446)), _0083(107398441), _0083(107398436)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0083(107398463)))
		{
			return;
		}
		throw new SecurityException(_0083(107398406));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
