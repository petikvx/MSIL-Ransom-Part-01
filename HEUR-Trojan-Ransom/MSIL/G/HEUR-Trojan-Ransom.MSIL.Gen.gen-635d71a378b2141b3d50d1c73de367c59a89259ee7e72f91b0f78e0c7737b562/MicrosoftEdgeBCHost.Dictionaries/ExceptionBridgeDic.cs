using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ExceptionBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExceptionBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		ForgotField();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ForgotField()
	{
	}
}
