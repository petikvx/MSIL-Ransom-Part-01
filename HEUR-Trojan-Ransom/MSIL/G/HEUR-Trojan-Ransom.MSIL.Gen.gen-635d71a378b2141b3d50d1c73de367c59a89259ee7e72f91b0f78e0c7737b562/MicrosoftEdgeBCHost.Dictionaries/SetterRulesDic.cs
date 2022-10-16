using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class SetterRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SetterRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeInterfaceClient();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeInterfaceClient()
	{
	}
}
