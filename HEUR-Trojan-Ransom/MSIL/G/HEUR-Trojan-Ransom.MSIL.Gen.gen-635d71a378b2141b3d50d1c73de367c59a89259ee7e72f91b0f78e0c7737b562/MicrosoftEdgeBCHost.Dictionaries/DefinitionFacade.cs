using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class DefinitionFacade
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DefinitionFacade()
	{
		WriterPropertyProducer.ResolveStub();
		CallLiteralInterceptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallLiteralInterceptor()
	{
	}
}
