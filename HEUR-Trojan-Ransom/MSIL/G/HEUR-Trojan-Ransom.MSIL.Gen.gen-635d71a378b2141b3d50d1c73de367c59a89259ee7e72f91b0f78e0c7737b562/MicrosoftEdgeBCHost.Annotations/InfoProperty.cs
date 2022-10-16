using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class InfoProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InfoProperty()
	{
		WriterPropertyProducer.ResolveStub();
		AddInterfaceImporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AddInterfaceImporter()
	{
	}
}
