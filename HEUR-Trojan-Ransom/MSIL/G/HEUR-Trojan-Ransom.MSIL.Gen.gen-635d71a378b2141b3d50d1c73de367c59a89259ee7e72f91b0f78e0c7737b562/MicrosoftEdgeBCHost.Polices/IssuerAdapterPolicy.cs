using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class IssuerAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IssuerAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ViewLiteralProcess();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ViewLiteralProcess()
	{
	}
}
