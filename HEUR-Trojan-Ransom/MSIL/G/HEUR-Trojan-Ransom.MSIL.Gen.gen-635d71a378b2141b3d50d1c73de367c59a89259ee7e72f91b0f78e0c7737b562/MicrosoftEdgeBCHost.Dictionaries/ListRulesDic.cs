using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ListRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		ForgotInterfaceToken();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ForgotInterfaceToken()
	{
	}
}
