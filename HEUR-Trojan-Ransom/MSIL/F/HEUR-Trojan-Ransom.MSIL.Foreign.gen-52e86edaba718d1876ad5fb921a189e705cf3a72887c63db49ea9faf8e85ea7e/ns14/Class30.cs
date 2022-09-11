using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using Google.Protobuf.Reflection;
using Mysqlx.Datatypes;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace ns14;

internal static class Class30
{
	private static FileDescriptor fileDescriptor_0;

	[NonSerialized]
	internal static GetString getString_0;

	public static FileDescriptor Descriptor => fileDescriptor_0;

	static Class30()
	{
		Strings.CreateGetStringDelegate(typeof(Class30));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107397282), getString_0(107397277)).Replace(getString_0(107397240), getString_0(107397235)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107397230)))
		{
			throw new SecurityException(getString_0(107397205));
		}
		fileDescriptor_0 = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(getString_0(107384493) + getString_0(107384412) + getString_0(107384363) + getString_0(107384762) + getString_0(107384713) + getString_0(107384600) + getString_0(107384039) + getString_0(107383926) + getString_0(107383877) + getString_0(107384276) + getString_0(107384227) + getString_0(107384114) + getString_0(107384065) + getString_0(107383440) + getString_0(107383391) + getString_0(107383278) + getString_0(107383741) + getString_0(107383660) + getString_0(107383547) + getString_0(107382986) + getString_0(107382873) + getString_0(107382824)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[4]
		{
			new GeneratedClrTypeInfo(typeof(Scalar), Scalar.Parser, new string[8]
			{
				getString_0(107390334),
				getString_0(107383247),
				getString_0(107383262),
				getString_0(107383213),
				getString_0(107383232),
				getString_0(107383187),
				getString_0(107383210),
				getString_0(107383201)
			}, new string[1] { getString_0(107383156) }, new Type[1] { typeof(Scalar.Types.Type) }, new GeneratedClrTypeInfo[2]
			{
				new GeneratedClrTypeInfo(typeof(Scalar.Types.String), Scalar.Types.String.Parser, new string[2]
				{
					getString_0(107387932),
					getString_0(107390247)
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(Scalar.Types.Octets), Scalar.Types.Octets.Parser, new string[2]
				{
					getString_0(107387932),
					getString_0(107389647)
				}, null, null, null)
			}),
			new GeneratedClrTypeInfo(typeof(Mysqlx.Datatypes.Object), Mysqlx.Datatypes.Object.Parser, new string[1] { getString_0(107385495) }, null, null, new GeneratedClrTypeInfo[1]
			{
				new GeneratedClrTypeInfo(typeof(Mysqlx.Datatypes.Object.Types.ObjectField), Mysqlx.Datatypes.Object.Types.ObjectField.Parser, new string[2]
				{
					getString_0(107385490),
					getString_0(107387932)
				}, null, null, null)
			}),
			new GeneratedClrTypeInfo(typeof(Mysqlx.Datatypes.Array), Mysqlx.Datatypes.Array.Parser, new string[1] { getString_0(107387932) }, null, null, null),
			new GeneratedClrTypeInfo(typeof(Any), Any.Parser, new string[4]
			{
				getString_0(107390334),
				getString_0(107383171),
				getString_0(107383130),
				getString_0(107385560)
			}, null, new Type[1] { typeof(Any.Class31.Enum14) }, null)
		}));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
