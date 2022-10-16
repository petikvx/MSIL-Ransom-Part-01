using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class IdentifierContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IdentifierContext()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeInterfaceVisitor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeInterfaceVisitor()
	{
	}
}
