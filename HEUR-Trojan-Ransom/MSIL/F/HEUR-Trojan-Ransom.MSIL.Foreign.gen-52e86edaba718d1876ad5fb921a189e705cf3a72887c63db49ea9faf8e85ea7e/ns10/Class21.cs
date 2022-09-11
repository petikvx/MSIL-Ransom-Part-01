using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using Google.Protobuf.Reflection;
using Mysqlx.Resultset;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns13;
using ns14;

namespace ns10;

internal static class Class21
{
	private static FileDescriptor fileDescriptor_0;

	[NonSerialized]
	internal static GetString getString_0;

	public static FileDescriptor Descriptor => fileDescriptor_0;

	static Class21()
	{
		Strings.CreateGetStringDelegate(typeof(Class21));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107397013), getString_0(107397008)).Replace(getString_0(107396971), getString_0(107396966)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107396961)))
		{
			throw new SecurityException(getString_0(107396936));
		}
		fileDescriptor_0 = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(getString_0(107390817) + getString_0(107390768) + getString_0(107391199) + getString_0(107391086) + getString_0(107391037) + getString_0(107390412) + getString_0(107390363) + getString_0(107390250) + getString_0(107390201) + getString_0(107390600) + getString_0(107390551) + getString_0(107390438) + getString_0(107389877) + getString_0(107389764) + getString_0(107389715) + getString_0(107390114)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[2]
		{
			typeof(Enum3),
			typeof(Enum4)
		}, new GeneratedClrTypeInfo[5]
		{
			new GeneratedClrTypeInfo(typeof(FetchDoneMoreOutParams), FetchDoneMoreOutParams.Parser, null, null, null, null),
			new GeneratedClrTypeInfo(typeof(FetchDoneMoreResultsets), FetchDoneMoreResultsets.Parser, null, null, null, null),
			new GeneratedClrTypeInfo(typeof(FetchDone), FetchDone.Parser, null, null, null, null),
			new GeneratedClrTypeInfo(typeof(ColumnMetaData), ColumnMetaData.Parser, new string[12]
			{
				getString_0(107390065),
				getString_0(107390024),
				getString_0(107390047),
				getString_0(107389998),
				getString_0(107389989),
				getString_0(107390000),
				getString_0(107389959),
				getString_0(107389978),
				getString_0(107389933),
				getString_0(107389940),
				getString_0(107389387),
				getString_0(107389378)
			}, null, new Type[1] { typeof(ColumnMetaData.Types.FieldType) }, null),
			new GeneratedClrTypeInfo(typeof(Row), Row.Parser, new string[1] { getString_0(107389393) }, null, null, null)
		}));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
