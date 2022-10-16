using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class RegistryValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegistryValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveInterfaceField();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveInterfaceField()
	{
	}
}
