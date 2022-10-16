using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class AttrContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttrContext()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectInterfaceVisitor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectInterfaceVisitor()
	{
	}
}
