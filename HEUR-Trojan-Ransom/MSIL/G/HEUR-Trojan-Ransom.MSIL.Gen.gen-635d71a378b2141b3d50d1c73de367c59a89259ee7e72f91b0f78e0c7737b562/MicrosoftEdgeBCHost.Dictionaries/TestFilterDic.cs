using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class TestFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		DisableLiteralObject();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableLiteralObject()
	{
	}
}
