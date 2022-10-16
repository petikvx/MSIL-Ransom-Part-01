using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class InitializerValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InitializerValDic()
	{
		WriterPropertyProducer.ResolveStub();
		OrderLiteralAnnotation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderLiteralAnnotation()
	{
	}
}
