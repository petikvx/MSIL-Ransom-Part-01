using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class UtilsContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static UtilsContext()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectInterfaceWatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectInterfaceWatcher()
	{
	}
}
