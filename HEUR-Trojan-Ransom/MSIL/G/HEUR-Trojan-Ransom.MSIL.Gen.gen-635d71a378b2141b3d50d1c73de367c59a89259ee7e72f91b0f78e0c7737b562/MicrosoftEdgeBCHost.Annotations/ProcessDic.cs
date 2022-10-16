using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ProcessDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcessDic()
	{
		WriterPropertyProducer.ResolveStub();
		StopLiteralAccount();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopLiteralAccount()
	{
	}
}
