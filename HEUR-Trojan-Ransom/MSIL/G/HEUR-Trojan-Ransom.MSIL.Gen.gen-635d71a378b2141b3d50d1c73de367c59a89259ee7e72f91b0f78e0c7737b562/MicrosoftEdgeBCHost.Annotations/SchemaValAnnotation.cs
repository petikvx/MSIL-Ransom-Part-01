using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class SchemaValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SchemaValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeInterfaceReponse();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeInterfaceReponse()
	{
	}
}
