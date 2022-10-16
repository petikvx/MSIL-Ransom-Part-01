using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ErrorValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ErrorValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		SetupSystem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupSystem()
	{
	}
}
