using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class SetterSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SetterSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatLiteralDecorator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatLiteralDecorator()
	{
	}
}
