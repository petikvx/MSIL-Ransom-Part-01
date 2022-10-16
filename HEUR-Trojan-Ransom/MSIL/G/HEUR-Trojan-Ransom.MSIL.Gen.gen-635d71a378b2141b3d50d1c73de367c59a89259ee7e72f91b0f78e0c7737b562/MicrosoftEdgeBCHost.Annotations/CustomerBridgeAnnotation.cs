using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class CustomerBridgeAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CustomerBridgeAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		MapRole();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapRole()
	{
	}
}
