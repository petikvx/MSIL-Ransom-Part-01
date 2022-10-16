using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ReponseDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReponseDic()
	{
		WriterPropertyProducer.ResolveStub();
		DefineLiteralRequest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineLiteralRequest()
	{
	}
}
