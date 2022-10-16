using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class SchemaUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SchemaUtils()
	{
		WriterPropertyProducer.ResolveStub();
		PatchInterfaceCollection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchInterfaceCollection()
	{
	}
}
