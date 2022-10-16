using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class AccountRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AccountRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		SetSystem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetSystem()
	{
	}
}
