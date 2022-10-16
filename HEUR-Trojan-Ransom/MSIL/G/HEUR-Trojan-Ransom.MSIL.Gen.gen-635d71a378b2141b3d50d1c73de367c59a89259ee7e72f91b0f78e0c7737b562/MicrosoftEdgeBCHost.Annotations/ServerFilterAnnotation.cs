using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ServerFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServerFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ReadInterfaceIdentifier();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadInterfaceIdentifier()
	{
	}
}
