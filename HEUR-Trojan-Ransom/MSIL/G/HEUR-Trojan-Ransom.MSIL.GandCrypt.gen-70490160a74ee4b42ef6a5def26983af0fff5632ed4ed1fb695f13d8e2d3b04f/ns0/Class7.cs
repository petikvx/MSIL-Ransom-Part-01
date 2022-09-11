using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using ns1;

namespace ns0;

internal sealed class Class7
{
	internal sealed class HashSetDebugView<T>
	{
		private HashSet<T> set;

		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		public T[] Items => set.ToArray();

		public HashSetDebugView(HashSet<T> set)
		{
			this.set = set;
		}
	}

	internal static byte[] smethod_0()
	{
		byte[] c = Resources.c;
		byte[] array = new byte[24];
		Class7.OmIXUvCcRPiVvoGwhnFYZAJZiOtJ((Array)array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		return Class8.smethod_0(c, array);
	}

	static void OmIXUvCcRPiVvoGwhnFYZAJZiOtJ(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0)
	{
		RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
	}
}
