using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class SerializerUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SerializerUtils()
	{
		WriterPropertyProducer.ResolveStub();
		FindInterfaceRef();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindInterfaceRef()
	{
	}
}
