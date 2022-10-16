using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ModelFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ModelFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		ForgotLiteralRole();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ForgotLiteralRole()
	{
	}
}
