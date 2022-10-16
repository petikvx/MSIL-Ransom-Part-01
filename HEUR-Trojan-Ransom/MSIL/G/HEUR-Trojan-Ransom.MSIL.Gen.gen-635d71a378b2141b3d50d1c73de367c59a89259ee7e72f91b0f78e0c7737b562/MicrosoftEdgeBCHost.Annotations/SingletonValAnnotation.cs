using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class SingletonValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SingletonValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectInterfaceTokenizer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectInterfaceTokenizer()
	{
	}
}
