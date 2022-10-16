using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class AdvisorVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdvisorVal()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatToken();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatToken()
	{
	}
}
