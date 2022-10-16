using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class TestValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestValDic()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateLiteralWatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateLiteralWatcher()
	{
	}
}
