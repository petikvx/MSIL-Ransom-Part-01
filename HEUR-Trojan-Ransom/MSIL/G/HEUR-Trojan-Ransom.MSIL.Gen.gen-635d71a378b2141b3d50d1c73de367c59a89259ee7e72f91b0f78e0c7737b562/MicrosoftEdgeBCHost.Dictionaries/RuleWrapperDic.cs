using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class RuleWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RuleWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		ReadParam();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadParam()
	{
	}
}
