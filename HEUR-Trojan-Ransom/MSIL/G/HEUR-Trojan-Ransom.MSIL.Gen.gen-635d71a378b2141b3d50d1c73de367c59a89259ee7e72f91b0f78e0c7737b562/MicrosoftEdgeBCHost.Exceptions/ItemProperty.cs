using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ItemProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ItemProperty()
	{
		WriterPropertyProducer.ResolveStub();
		EnableInterfaceRole();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableInterfaceRole()
	{
	}
}
