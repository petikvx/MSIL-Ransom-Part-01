using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class DicWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DicWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateDecorator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateDecorator()
	{
	}
}
