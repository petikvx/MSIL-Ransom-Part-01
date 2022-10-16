using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class InfoSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InfoSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		SetupLiteralDecorator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupLiteralDecorator()
	{
	}
}
