using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class CodeWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CodeWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		QueryResolver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryResolver()
	{
	}
}
