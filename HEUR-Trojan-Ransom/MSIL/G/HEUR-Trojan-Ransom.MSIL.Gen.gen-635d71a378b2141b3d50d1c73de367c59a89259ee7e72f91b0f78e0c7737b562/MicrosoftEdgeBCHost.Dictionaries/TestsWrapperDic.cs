using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class TestsWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestsWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		InitPublisher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitPublisher()
	{
	}
}
