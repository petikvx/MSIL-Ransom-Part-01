using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ns13;
using ns18;
using ns19;
using ns20;

namespace ns24;

internal abstract class Class67<T> : Class58<Class39, T> where T : Class54
{
	internal Class67(Class39 class39_0)
		: base(class39_0)
	{
	}

	[IteratorStateMachine(typeof(Class67<>.Class70))]
	protected IEnumerable<Class43> method_2(object[] object_0)
	{
		//yield-return decompiler failed: Method not found
		return new Class70(-2)
		{
			object_1 = object_0
		};
	}
}
