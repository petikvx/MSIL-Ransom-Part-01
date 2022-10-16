using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ListWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		StopSchema();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopSchema()
	{
	}
}
