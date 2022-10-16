using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class MockValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MockValDic()
	{
		WriterPropertyProducer.ResolveStub();
		GetLiteralWriter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GetLiteralWriter()
	{
	}
}
