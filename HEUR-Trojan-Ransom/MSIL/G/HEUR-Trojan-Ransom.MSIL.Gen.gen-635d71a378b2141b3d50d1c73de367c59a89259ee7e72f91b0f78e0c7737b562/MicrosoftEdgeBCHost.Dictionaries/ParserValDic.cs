using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ParserValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParserValDic()
	{
		WriterPropertyProducer.ResolveStub();
		PushLiteralAdvisor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushLiteralAdvisor()
	{
	}
}
