using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class DecoratorRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DecoratorRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ForgotItem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ForgotItem()
	{
	}
}
