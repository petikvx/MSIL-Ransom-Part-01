using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ItemOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ItemOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ViewLiteralException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ViewLiteralException()
	{
	}
}
