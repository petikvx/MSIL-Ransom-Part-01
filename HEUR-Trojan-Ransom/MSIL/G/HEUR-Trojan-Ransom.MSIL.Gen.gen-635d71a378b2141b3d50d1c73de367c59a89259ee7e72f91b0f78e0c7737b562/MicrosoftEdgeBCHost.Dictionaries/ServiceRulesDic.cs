using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ServiceRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServiceRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeInterfaceProcess();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeInterfaceProcess()
	{
	}
}
