using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class CustomerRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CustomerRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		ForgotInterfaceAccount();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ForgotInterfaceAccount()
	{
	}
}
