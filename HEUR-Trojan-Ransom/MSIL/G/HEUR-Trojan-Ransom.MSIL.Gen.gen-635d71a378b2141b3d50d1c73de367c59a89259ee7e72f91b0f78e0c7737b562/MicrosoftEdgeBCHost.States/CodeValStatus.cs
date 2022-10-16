using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class CodeValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CodeValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatLiteralResolver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatLiteralResolver()
	{
	}
}
