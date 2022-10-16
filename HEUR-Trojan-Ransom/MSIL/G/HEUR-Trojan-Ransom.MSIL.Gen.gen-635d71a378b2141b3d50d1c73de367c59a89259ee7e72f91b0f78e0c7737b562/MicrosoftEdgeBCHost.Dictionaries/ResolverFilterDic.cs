using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ResolverFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ResolverFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		ReadLiteralTests();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadLiteralTests()
	{
	}
}
