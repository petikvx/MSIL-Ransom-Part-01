using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class WriterFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WriterFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		ResetLiteralCode();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetLiteralCode()
	{
	}
}
