using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class AdvisorHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdvisorHelper()
	{
		WriterPropertyProducer.ResolveStub();
		NewLiteralTokenizer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewLiteralTokenizer()
	{
	}
}
