using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class TaskAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TaskAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		NewLiteralRules();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewLiteralRules()
	{
	}
}
