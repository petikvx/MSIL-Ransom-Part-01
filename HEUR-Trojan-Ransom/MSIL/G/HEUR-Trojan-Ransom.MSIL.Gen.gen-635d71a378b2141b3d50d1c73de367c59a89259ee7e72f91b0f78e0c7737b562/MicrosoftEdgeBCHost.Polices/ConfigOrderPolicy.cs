using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ConfigOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateLiteralError();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateLiteralError()
	{
	}
}
