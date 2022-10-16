using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class AdvisorServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdvisorServer()
	{
		WriterPropertyProducer.ResolveStub();
		NewLiteralUtils();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewLiteralUtils()
	{
	}
}
