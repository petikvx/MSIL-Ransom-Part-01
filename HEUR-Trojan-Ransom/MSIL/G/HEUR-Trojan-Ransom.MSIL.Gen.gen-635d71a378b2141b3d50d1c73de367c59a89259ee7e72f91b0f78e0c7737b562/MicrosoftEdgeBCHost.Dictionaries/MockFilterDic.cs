using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class MockFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MockFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		CheckLiteralMapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckLiteralMapper()
	{
	}
}
