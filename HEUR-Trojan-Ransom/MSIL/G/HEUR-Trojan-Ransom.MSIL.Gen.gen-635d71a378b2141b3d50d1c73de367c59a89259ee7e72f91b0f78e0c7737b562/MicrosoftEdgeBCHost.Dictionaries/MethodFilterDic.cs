using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class MethodFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MethodFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		StopLiteralResolver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopLiteralResolver()
	{
	}
}
