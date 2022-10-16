using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class FieldServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FieldServer()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyLiteralVisitor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyLiteralVisitor()
	{
	}
}
