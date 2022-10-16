using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class EventHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static EventHelper()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatLiteralThread();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatLiteralThread()
	{
	}
}
