using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class DatabaseBridgeAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DatabaseBridgeAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		VisitMapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VisitMapper()
	{
	}
}
