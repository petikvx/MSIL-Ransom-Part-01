using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class DecoratorFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DecoratorFilter()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeWatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeWatcher()
	{
	}
}
