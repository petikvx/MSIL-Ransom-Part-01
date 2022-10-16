using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class IdentifierWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IdentifierWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		MapTest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapTest()
	{
	}
}
