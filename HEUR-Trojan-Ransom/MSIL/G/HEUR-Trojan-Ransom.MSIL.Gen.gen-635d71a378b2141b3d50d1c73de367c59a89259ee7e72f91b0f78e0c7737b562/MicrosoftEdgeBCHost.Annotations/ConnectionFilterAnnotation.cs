using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ConnectionFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConnectionFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		SetupInterfaceMapping();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupInterfaceMapping()
	{
	}
}
