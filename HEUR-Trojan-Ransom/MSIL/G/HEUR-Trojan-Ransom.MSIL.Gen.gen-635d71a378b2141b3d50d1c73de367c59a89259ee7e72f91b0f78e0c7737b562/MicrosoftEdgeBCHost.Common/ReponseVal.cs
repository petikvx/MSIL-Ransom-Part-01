using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ReponseVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReponseVal()
	{
		WriterPropertyProducer.ResolveStub();
		ReadVisitor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadVisitor()
	{
	}
}
