using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class PolicyValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PolicyValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		VisitInterfaceClient();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VisitInterfaceClient()
	{
	}
}
