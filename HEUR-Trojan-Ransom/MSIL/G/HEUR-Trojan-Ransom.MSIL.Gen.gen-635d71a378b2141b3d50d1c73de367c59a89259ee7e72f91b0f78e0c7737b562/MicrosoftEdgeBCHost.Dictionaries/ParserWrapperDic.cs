using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ParserWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParserWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		FlushParams();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FlushParams()
	{
	}
}
