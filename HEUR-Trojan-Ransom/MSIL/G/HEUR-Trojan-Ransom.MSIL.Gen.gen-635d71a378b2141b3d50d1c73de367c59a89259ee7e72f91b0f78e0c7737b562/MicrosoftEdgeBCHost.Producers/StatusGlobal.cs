using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class StatusGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StatusGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectInterfaceTemplate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectInterfaceTemplate()
	{
	}
}
