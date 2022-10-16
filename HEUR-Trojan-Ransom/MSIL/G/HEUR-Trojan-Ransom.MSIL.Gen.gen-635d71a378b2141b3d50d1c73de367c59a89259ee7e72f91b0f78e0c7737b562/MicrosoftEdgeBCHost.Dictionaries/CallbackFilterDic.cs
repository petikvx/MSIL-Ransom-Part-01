using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class CallbackFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CallbackFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		ForgotLiteralState();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ForgotLiteralState()
	{
	}
}
