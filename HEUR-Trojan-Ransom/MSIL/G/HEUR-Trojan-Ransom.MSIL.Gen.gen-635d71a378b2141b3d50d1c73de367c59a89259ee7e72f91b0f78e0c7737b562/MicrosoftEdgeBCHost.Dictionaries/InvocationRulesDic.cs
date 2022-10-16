using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class InvocationRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InvocationRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		PatchInterfaceUtils();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchInterfaceUtils()
	{
	}
}
