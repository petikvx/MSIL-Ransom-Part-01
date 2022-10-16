using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ParserAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParserAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyLiteralDispatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyLiteralDispatcher()
	{
	}
}
