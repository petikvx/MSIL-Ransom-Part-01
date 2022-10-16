using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class IdentifierGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IdentifierGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		NewInterfacePage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewInterfacePage()
	{
	}
}
