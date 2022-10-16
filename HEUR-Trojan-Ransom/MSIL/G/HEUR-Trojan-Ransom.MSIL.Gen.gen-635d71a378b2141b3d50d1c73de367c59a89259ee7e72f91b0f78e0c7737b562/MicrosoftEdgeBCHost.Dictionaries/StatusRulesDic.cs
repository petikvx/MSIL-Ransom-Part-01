using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class StatusRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StatusRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		InitInterfaceAuthentication();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitInterfaceAuthentication()
	{
	}
}
