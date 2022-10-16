using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ConsumerSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConsumerSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		FillLiteralDecorator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillLiteralDecorator()
	{
	}
}
