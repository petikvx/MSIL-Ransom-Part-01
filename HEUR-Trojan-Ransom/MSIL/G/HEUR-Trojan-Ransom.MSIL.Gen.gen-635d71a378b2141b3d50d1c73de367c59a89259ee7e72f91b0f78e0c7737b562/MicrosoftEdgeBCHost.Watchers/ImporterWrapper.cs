using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ImporterWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ImporterWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		MoveDic();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoveDic()
	{
	}
}
