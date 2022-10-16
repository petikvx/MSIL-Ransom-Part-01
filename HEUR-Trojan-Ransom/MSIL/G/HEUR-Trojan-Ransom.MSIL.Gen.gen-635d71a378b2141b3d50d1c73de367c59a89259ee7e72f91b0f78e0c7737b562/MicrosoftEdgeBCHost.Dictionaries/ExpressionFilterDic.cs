using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ExpressionFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExpressionFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		PushInterfaceRule();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushInterfaceRule()
	{
	}
}
