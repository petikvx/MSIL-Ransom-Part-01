using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ItemFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ItemFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		PatchInterfaceCandidate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchInterfaceCandidate()
	{
	}
}
