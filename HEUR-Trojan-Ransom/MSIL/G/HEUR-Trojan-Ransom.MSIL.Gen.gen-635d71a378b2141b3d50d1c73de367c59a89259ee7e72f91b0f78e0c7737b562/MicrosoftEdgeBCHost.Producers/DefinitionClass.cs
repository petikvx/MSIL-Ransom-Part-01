using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class DefinitionClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DefinitionClass()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeInterfaceObserver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeInterfaceObserver()
	{
	}
}
