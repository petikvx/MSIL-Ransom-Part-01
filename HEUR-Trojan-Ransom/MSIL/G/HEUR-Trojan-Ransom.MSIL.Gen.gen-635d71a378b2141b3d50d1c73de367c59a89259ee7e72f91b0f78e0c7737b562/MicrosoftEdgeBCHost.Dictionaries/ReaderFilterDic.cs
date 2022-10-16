using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ReaderFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReaderFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateLiteralConnection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateLiteralConnection()
	{
	}
}
