using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class DatabaseValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DatabaseValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeLiteralComposer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeLiteralComposer()
	{
	}
}
