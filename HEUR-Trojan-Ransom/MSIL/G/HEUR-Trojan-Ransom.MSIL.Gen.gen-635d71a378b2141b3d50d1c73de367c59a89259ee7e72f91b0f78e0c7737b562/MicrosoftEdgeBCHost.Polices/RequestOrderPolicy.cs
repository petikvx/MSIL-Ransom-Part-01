using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class RequestOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RequestOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		MoveLiteralFactory();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoveLiteralFactory()
	{
	}
}
