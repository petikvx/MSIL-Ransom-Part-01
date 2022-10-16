using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ServiceValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServiceValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		SelectInterfaceStruct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectInterfaceStruct()
	{
	}
}
