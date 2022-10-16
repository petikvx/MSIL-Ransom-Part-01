using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ClientFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClientFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		PatchInterfaceParams();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchInterfaceParams()
	{
	}
}
