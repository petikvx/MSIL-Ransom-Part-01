using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ProccesorServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProccesorServer()
	{
		WriterPropertyProducer.ResolveStub();
		MapLiteralUtils();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapLiteralUtils()
	{
	}
}
