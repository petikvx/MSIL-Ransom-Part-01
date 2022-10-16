using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ListFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		ResetLiteralMap();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetLiteralMap()
	{
	}
}
