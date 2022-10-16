using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ErrorFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ErrorFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		PostLiteralManager();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostLiteralManager()
	{
	}
}
