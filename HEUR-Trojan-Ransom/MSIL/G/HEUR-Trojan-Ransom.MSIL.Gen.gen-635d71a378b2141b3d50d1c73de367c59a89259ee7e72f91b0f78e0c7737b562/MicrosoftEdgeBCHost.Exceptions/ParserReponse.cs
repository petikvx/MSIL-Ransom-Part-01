using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ParserReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParserReponse()
	{
		WriterPropertyProducer.ResolveStub();
		WriteLiteralFactory();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteLiteralFactory()
	{
	}
}
