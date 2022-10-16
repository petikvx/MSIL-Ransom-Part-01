using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ComposerOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComposerOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterInterfaceFilter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterInterfaceFilter()
	{
	}
}
