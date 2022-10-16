using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class DecoratorServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DecoratorServer()
	{
		WriterPropertyProducer.ResolveStub();
		SelectLiteralContainer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectLiteralContainer()
	{
	}
}
