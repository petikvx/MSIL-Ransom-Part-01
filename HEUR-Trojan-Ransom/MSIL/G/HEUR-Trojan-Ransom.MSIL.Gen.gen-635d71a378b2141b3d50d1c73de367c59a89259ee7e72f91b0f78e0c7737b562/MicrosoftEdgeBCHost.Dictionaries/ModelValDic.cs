using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ModelValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ModelValDic()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyLiteralCallback();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyLiteralCallback()
	{
	}
}
