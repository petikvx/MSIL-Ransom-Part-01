using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class MapValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		WriteLiteralSetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteLiteralSetter()
	{
	}
}
