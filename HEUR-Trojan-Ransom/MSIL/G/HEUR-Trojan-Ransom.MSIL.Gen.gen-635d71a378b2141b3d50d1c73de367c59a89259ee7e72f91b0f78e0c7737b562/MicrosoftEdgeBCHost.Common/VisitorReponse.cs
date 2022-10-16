using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class VisitorReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static VisitorReponse()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateLiteralMethod();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateLiteralMethod()
	{
	}
}
