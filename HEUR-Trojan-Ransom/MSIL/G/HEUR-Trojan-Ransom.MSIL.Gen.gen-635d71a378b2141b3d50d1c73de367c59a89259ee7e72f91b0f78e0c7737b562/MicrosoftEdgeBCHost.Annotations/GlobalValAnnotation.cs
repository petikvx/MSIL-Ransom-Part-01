using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class GlobalValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GlobalValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		NewInterfaceClient();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewInterfaceClient()
	{
	}
}
