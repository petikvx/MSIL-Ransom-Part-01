using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace NAudio.Dmo;

public sealed class DmoEnumerator
{
	public static IEnumerable<DmoDescriptor> GetAudioEffectNames()
	{
		return GetDmos(DmoGuids.DMOCATEGORY_AUDIO_EFFECT);
	}

	public static IEnumerable<DmoDescriptor> GetAudioEncoderNames()
	{
		return GetDmos(DmoGuids.DMOCATEGORY_AUDIO_ENCODER);
	}

	public static IEnumerable<DmoDescriptor> GetAudioDecoderNames()
	{
		return GetDmos(DmoGuids.DMOCATEGORY_AUDIO_DECODER);
	}

	private static IEnumerable<DmoDescriptor> GetDmos(Guid category)
	{
		Marshal.ThrowExceptionForHR(DmoInterop.DMOEnum(ref category, DmoEnumFlags.None, 0, null, 0, null, out var enumDmo));
		int itemsFetched;
		do
		{
			enumDmo.Next(1, out var clsid, out var name, out itemsFetched);
			if (itemsFetched == 1)
			{
				string name2 = Marshal.PtrToStringUni(name);
				Marshal.FreeCoTaskMem(name);
				yield return new DmoDescriptor(name2, clsid);
			}
		}
		while (itemsFetched > 0);
	}
}
