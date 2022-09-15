using System;
using System.Runtime.InteropServices;

namespace ResonateII;

public static class FlanMOD
{
	private const string BassModLib = "BASSMOD.dll";

	[DllImport("BASSMOD.dll")]
	public static extern IntPtr BASSMOD_Init(int device, int freq, BASSMOD_BASSInit flag);

	[DllImport("BASSMOD.dll")]
	public static extern IntPtr BASSMOD_MusicLoad(bool mem, byte[] tune, int offset, int len, BASSMOD_BassMusic flag);

	[DllImport("BASSMOD.dll")]
	public static extern IntPtr BASSMOD_Free();

	[DllImport("BASSMOD.dll")]
	public static extern bool BASSMOD_MusicPlay();
}
