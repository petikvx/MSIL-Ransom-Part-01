using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ParserHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParserHelper()
	{
		WriterPropertyProducer.ResolveStub();
		LoginLiteralFilter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginLiteralFilter()
	{
	}
}
