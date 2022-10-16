using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ResolverRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ResolverRules()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutSchema();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutSchema()
	{
	}
}
