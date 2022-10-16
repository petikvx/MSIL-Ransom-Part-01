using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class CodeReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CodeReponse()
	{
		WriterPropertyProducer.ResolveStub();
		CalcLiteralConnection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcLiteralConnection()
	{
	}
}
