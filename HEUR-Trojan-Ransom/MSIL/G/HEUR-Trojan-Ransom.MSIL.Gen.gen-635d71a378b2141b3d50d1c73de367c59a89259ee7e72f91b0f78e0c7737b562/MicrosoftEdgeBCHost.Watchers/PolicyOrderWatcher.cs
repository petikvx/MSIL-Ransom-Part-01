using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class PolicyOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PolicyOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		EnableLiteralCollection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableLiteralCollection()
	{
	}
}
