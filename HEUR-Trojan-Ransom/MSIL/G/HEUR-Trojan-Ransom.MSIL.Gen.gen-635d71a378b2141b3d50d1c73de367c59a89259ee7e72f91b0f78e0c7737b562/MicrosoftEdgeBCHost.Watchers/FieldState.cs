using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class FieldState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FieldState()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeInterfacePrinter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeInterfacePrinter()
	{
	}
}
