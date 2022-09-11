using System;
using System.Runtime.InteropServices;

namespace NAudio.CoreAudioApi.Interfaces;

internal sealed class PropVariantNative
{
	[DllImport("ole32.dll")]
	internal static extern int PropVariantClear(ref PropVariant pvar);

	[DllImport("ole32.dll")]
	internal static extern int PropVariantClear(IntPtr pvar);
}
