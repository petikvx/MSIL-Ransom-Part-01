using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ParamAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		SetupLiteralException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupLiteralException()
	{
	}
}
