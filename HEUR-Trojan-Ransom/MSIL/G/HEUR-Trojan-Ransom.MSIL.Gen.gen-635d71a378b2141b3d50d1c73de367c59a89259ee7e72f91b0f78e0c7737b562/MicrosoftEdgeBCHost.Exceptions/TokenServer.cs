using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class TokenServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenServer()
	{
		WriterPropertyProducer.ResolveStub();
		CalcLiteralWatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcLiteralWatcher()
	{
	}
}
