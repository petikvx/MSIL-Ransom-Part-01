using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ReaderValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReaderValDic()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateLiteralIterator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateLiteralIterator()
	{
	}
}
