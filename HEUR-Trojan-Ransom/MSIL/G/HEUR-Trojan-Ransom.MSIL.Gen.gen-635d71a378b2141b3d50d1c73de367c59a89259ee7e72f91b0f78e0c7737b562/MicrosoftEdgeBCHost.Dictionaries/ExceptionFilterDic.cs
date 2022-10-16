using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ExceptionFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExceptionFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		CallLiteralManager();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallLiteralManager()
	{
	}
}
