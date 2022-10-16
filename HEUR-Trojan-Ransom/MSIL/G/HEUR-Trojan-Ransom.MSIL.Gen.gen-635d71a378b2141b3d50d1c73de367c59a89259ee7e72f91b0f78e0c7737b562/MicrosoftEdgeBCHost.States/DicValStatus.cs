using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class DicValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DicValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		FindLiteralDecorator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindLiteralDecorator()
	{
	}
}
