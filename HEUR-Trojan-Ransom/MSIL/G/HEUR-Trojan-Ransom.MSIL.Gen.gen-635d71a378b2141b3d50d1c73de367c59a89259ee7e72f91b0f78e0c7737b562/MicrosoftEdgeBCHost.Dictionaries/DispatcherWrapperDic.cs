using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class DispatcherWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DispatcherWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		InsertTests();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertTests()
	{
	}
}
