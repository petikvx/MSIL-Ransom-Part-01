using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class IssuerOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IssuerOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		OrderLiteralExporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderLiteralExporter()
	{
	}
}
