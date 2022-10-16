using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class StateFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StateFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteInterfaceIssuer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteInterfaceIssuer()
	{
	}
}
