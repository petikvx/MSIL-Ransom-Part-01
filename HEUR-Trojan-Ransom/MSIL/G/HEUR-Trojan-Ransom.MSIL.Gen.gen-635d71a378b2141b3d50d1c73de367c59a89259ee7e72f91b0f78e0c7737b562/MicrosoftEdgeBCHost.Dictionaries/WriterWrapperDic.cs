using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class WriterWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WriterWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		PushPrototype();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushPrototype()
	{
	}
}
