using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ServiceFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServiceFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		ForgotLiteralParser();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ForgotLiteralParser()
	{
	}
}
