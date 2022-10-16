using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class DecoratorOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DecoratorOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		EnableLiteralRecord();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableLiteralRecord()
	{
	}
}
