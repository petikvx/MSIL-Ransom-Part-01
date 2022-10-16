using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class CodeHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CodeHelper()
	{
		WriterPropertyProducer.ResolveStub();
		ListLiteralWriter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ListLiteralWriter()
	{
	}
}
