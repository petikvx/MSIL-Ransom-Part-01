using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using MySql.Data.MySqlClient;
using Mysqlx.Resultset;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns10;
using ns13;
using ns16;
using ns19;
using ns22;
using ns25;
using ns26;
using ns8;

namespace ns27;

internal sealed class Class104
{
	[NonSerialized]
	internal static GetString getString_0;

	public static Class87 smethod_0(Class47 class47_0, ColumnMetaData.Types.FieldType fieldType_0)
	{
		return fieldType_0 switch
		{
			ColumnMetaData.Types.FieldType.Sint => new Class92(bool_1: true), 
			ColumnMetaData.Types.FieldType.Uint => new Class92(bool_1: false), 
			ColumnMetaData.Types.FieldType.Double => new Class91(bool_1: false), 
			ColumnMetaData.Types.FieldType.Float => new Class91(bool_1: true), 
			ColumnMetaData.Types.FieldType.Bytes => new Class89(bool_1: false), 
			ColumnMetaData.Types.FieldType.Time => new Class95(), 
			ColumnMetaData.Types.FieldType.Datetime => new Class94(), 
			ColumnMetaData.Types.FieldType.Set => new Class93(), 
			ColumnMetaData.Types.FieldType.Enum => new Class89(bool_1: true), 
			ColumnMetaData.Types.FieldType.Bit => new Class88(), 
			ColumnMetaData.Types.FieldType.Decimal => new Class90(), 
			_ => throw new MySqlException(getString_0(107404741) + fieldType_0), 
		};
	}

	static Class104()
	{
		Strings.CreateGetStringDelegate(typeof(Class104));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107397946), getString_0(107397941)).Replace(getString_0(107397904), getString_0(107397899)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107397894)))
		{
			throw new SecurityException(getString_0(107397869));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
