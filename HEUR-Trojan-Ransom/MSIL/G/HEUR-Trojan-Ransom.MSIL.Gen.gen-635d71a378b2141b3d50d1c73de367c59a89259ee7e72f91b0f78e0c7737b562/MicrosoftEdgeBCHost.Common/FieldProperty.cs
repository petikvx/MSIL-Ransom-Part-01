using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class FieldProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FieldProperty()
	{
		WriterPropertyProducer.ResolveStub();
		LoginInterfaceBroadcaster();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginInterfaceBroadcaster()
	{
	}
}
