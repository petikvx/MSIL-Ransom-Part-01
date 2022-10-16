using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ExceptionWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExceptionWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		ResetService();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetService()
	{
	}
}
