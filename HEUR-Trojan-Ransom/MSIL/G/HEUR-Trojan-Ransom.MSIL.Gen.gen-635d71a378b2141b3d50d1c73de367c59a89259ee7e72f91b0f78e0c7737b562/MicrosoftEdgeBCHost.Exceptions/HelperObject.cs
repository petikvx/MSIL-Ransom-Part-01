using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class HelperObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static HelperObject()
	{
		WriterPropertyProducer.ResolveStub();
		CountLiteralListener();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountLiteralListener()
	{
	}
}
