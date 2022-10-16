using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ThreadReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ThreadReponse()
	{
		WriterPropertyProducer.ResolveStub();
		MapLiteralServer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapLiteralServer()
	{
	}
}
