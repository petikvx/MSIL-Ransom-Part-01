using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ProccesorWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProccesorWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateComparator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateComparator()
	{
	}
}
