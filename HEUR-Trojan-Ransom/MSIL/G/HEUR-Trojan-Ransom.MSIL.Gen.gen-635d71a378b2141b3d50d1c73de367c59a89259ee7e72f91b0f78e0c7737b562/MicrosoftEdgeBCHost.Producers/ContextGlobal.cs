using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ContextGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContextGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		RestartInterfaceSchema();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartInterfaceSchema()
	{
	}
}
