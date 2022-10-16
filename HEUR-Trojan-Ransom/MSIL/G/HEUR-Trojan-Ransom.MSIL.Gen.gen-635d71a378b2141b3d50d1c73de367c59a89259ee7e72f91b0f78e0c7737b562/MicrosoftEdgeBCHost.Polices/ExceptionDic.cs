using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ExceptionDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExceptionDic()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteLiteralTask();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteLiteralTask()
	{
	}
}
