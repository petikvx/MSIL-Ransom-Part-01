using System.Runtime.CompilerServices;
using 俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮CPgzlWUEazHcoa7JCd4i.Consumers;

namespace qopsPSPSDDFPPAFSDPFASDPSFADIPFASDOPFASDPOAFSDOPFASDOP.Models;

internal class ListenerSingleton
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListenerSingleton()
	{
		DicWriterConsumer.ListIndexer();
		ExcludeClass();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeClass()
	{
	}
}
