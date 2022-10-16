using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class SchemaFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SchemaFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CloneInterfaceDispatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CloneInterfaceDispatcher()
	{
	}
}
