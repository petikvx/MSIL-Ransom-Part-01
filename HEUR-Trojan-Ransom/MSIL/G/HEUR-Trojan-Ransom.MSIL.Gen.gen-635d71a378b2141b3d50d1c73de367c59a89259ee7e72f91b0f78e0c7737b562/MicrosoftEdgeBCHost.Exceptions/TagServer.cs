using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class TagServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TagServer()
	{
		WriterPropertyProducer.ResolveStub();
		RestartLiteralInterpreter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartLiteralInterpreter()
	{
	}
}
