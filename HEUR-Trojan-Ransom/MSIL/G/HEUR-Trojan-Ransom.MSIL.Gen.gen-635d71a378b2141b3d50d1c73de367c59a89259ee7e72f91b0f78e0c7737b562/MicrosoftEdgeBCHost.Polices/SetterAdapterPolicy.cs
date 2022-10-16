using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class SetterAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SetterAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		PublishLiteralRules();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishLiteralRules()
	{
	}
}
