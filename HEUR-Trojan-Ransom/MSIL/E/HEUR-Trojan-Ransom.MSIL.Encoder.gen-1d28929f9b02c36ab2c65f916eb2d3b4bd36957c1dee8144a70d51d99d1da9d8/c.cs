using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class c : h
{
	[Serializable]
	public sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<DriveInfo, string> _003C_003E9__0_0;

		internal string a(DriveInfo driveInfo_0)
		{
			return (string)/*calli with instance method signature not supportd*/;
		}
	}

	public static object a;

	public unsafe List<string> a()
	{
		List<string> list = ((delegate*<DriveInfo[]>)r.a[2])().Select(_003C_003Ec._003C_003E9.a).ToList();
		list.AddRange(_003CModule_003E.a((object)this));
		return list;
	}
}
