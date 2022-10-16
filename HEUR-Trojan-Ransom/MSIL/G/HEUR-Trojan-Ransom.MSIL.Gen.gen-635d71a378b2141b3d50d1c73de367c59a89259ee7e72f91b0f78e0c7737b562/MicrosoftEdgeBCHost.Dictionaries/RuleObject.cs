using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class RuleObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RuleObject()
	{
		WriterPropertyProducer.ResolveStub();
		StopLiteralAuthentication();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopLiteralAuthentication()
	{
	}
}
