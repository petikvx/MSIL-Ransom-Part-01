using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ProcessObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcessObject()
	{
		WriterPropertyProducer.ResolveStub();
		SetupLiteralConfig();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupLiteralConfig()
	{
	}
}
