using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class IssuerValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IssuerValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		VisitInterfaceRegistry();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VisitInterfaceRegistry()
	{
	}
}
