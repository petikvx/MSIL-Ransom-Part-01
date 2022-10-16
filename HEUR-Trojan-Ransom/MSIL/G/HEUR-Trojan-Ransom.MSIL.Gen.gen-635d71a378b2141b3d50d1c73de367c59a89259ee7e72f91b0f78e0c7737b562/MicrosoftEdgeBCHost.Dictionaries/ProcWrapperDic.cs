using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ProcWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		SearchWrapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchWrapper()
	{
	}
}
