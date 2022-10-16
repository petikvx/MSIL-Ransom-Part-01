using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class IdentifierValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IdentifierValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterLiteralState();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterLiteralState()
	{
	}
}
