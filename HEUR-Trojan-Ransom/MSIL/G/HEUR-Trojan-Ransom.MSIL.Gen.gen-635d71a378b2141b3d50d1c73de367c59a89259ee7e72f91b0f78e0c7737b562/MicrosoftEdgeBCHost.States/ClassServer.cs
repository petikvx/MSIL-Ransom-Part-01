using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ClassServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClassServer()
	{
		WriterPropertyProducer.ResolveStub();
		CloneLiteralStrategy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CloneLiteralStrategy()
	{
	}
}
