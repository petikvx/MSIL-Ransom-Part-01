using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class Container
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Container()
	{
		WriterPropertyProducer.ResolveStub();
		VisitCode();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VisitCode()
	{
	}
}
