using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ContextValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContextValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		GetInterfaceClient();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GetInterfaceClient()
	{
	}
}
