using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class PrototypeHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrototypeHelper()
	{
		WriterPropertyProducer.ResolveStub();
		NewLiteralWriter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewLiteralWriter()
	{
	}
}
