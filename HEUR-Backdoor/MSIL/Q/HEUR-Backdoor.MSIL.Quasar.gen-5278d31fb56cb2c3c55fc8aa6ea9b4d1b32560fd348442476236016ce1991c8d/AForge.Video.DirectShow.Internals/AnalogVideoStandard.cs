using System;
using System.Runtime.InteropServices;

namespace AForge.Video.DirectShow.Internals;

[Flags]
[ComVisible(false)]
internal enum AnalogVideoStandard
{
	None = 0,
	NTSC_M = 1,
	NTSC_M_J = 2,
	NTSC_433 = 4,
	PAL_B = 0x10,
	PAL_D = 0x20,
	PAL_G = 0x40,
	PAL_H = 0x80,
	PAL_I = 0x100,
	PAL_M = 0x200,
	PAL_N = 0x400,
	PAL_60 = 0x800,
	SECAM_B = 0x1000,
	SECAM_D = 0x2000,
	SECAM_G = 0x4000,
	SECAM_H = 0x8000,
	SECAM_K = 0x10000,
	SECAM_K1 = 0x20000,
	SECAM_L = 0x40000,
	SECAM_L1 = 0x80000,
	PAL_N_COMBO = 0x100000
}
