using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class FieldHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FieldHelper()
	{
		WriterPropertyProducer.ResolveStub();
		VisitLiteralThread();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VisitLiteralThread()
	{
	}
}
