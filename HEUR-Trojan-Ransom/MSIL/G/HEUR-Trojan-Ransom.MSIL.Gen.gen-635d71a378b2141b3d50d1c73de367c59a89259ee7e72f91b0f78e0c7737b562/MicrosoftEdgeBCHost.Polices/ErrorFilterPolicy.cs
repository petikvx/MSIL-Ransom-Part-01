using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ErrorFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ErrorFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptDic();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptDic()
	{
	}
}
