using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class WriterValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WriterValDic()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateLiteralContainer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateLiteralContainer()
	{
	}
}
