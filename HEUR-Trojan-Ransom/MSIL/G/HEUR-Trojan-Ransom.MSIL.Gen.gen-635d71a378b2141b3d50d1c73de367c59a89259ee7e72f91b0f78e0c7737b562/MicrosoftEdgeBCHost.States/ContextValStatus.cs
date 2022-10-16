using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ContextValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContextValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		NewLiteralProccesor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewLiteralProccesor()
	{
	}
}
