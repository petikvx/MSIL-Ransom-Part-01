using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class SetterValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SetterValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ManageLiteralResolver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageLiteralResolver()
	{
	}
}
