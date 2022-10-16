using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ProcHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcHelper()
	{
		WriterPropertyProducer.ResolveStub();
		DefineLiteralReg();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineLiteralReg()
	{
	}
}
