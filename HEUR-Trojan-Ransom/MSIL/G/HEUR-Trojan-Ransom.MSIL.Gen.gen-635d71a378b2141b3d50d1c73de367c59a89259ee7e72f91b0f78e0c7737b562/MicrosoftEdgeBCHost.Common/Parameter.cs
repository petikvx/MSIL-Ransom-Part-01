using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class Parameter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Parameter()
	{
		WriterPropertyProducer.ResolveStub();
		MoveEvent();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoveEvent()
	{
	}
}
