using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ParserServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParserServer()
	{
		WriterPropertyProducer.ResolveStub();
		DefineLiteralInterpreter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineLiteralInterpreter()
	{
	}
}
