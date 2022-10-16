using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ClassValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClassValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateInterfaceRules();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateInterfaceRules()
	{
	}
}
