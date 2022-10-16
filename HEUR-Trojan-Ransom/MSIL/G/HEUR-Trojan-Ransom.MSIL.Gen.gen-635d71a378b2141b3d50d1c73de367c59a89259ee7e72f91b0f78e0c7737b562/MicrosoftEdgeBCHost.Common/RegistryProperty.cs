using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class RegistryProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegistryProperty()
	{
		WriterPropertyProducer.ResolveStub();
		RevertInterfaceDescriptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RevertInterfaceDescriptor()
	{
	}
}
