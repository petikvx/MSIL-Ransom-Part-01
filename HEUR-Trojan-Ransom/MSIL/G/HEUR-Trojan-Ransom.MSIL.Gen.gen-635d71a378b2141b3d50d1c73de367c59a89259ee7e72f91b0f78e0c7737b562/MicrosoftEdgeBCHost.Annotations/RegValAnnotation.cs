using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class RegValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateInterfaceFilter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateInterfaceFilter()
	{
	}
}
