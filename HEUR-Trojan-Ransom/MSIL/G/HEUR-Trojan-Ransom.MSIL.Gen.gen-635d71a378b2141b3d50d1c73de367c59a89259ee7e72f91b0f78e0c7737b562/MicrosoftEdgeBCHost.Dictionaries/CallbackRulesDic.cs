using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class CallbackRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CallbackRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutInterfaceContainer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutInterfaceContainer()
	{
	}
}
