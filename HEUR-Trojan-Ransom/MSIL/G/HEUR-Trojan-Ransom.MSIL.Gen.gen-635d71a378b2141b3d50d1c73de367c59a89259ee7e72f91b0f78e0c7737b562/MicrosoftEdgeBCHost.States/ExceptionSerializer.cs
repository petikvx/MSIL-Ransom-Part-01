using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ExceptionSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExceptionSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateLiteralEvent();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateLiteralEvent()
	{
	}
}
