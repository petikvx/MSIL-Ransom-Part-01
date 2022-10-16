using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class TokenizerDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenizerDic()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptLiteralProcess();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptLiteralProcess()
	{
	}
}
