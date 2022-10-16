using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ErrorDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ErrorDic()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyLiteralTask();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyLiteralTask()
	{
	}
}
