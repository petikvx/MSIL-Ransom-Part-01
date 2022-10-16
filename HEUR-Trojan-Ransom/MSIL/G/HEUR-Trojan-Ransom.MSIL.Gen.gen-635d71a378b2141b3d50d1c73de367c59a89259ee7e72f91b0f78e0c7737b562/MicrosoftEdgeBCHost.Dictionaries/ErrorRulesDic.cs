using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ErrorRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ErrorRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveInterfaceContext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveInterfaceContext()
	{
	}
}
