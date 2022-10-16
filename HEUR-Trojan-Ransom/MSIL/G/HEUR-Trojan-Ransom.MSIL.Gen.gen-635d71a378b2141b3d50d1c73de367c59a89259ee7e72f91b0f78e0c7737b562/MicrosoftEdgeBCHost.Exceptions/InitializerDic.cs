using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class InitializerDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InitializerDic()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptLiteralReader();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptLiteralReader()
	{
	}
}
