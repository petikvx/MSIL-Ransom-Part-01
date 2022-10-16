using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class AttributeProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttributeProperty()
	{
		WriterPropertyProducer.ResolveStub();
		PublishInterfaceRole();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishInterfaceRole()
	{
	}
}
