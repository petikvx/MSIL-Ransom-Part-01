using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class RulesValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RulesValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		LoginLiteralValue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginLiteralValue()
	{
	}
}
