using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class SerializerClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SerializerClass()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveInterfaceSerializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveInterfaceSerializer()
	{
	}
}
