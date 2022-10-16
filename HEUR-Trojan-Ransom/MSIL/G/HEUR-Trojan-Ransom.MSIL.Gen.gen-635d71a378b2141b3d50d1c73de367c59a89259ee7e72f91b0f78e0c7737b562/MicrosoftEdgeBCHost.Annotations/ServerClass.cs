using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ServerClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServerClass()
	{
		WriterPropertyProducer.ResolveStub();
		FillInterfaceSerializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillInterfaceSerializer()
	{
	}
}
