using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ObjectOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObjectOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateLiteralVal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateLiteralVal()
	{
	}
}
