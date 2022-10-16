using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class MapperServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapperServer()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyLiteralContainer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyLiteralContainer()
	{
	}
}
