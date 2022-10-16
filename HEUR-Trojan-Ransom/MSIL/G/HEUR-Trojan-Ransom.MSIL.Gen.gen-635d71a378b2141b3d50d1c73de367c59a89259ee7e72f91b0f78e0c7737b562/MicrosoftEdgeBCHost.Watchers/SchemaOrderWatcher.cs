using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class SchemaOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SchemaOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyLiteralUtils();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyLiteralUtils()
	{
	}
}
