using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ExpressionWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExpressionWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectBridge();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectBridge()
	{
	}
}
