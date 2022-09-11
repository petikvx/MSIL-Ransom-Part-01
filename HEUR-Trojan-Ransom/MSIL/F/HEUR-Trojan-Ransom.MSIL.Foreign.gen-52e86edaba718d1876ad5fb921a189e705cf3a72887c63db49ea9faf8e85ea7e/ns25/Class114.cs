using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using MySql.Data.MySqlClient;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns22;

namespace ns25;

internal sealed class Class114 : Class113
{
	private MySqlConnectionStringBuilder mySqlConnectionStringBuilder_0;

	[NonSerialized]
	internal static GetString getString_2;

	public override string PluginName => getString_2(107365539);

	public string AuthName => getString_2(107365462);

	public Class114(MySqlConnectionStringBuilder mySqlConnectionStringBuilder_1)
	{
		mySqlConnectionStringBuilder_0 = mySqlConnectionStringBuilder_1;
	}

	public byte[] method_6(byte[] byte_1)
	{
		Encoding encoding = Encoding.GetEncoding(getString_2(107365481));
		byte[] bytes = encoding.GetBytes(mySqlConnectionStringBuilder_0.UserID);
		byte[] bytes2 = encoding.GetBytes(mySqlConnectionStringBuilder_0.Database);
		byte[] array = new byte[0];
		byte[] array2 = new byte[0];
		if (!string.IsNullOrWhiteSpace(mySqlConnectionStringBuilder_0.Password))
		{
			array = method_5(mySqlConnectionStringBuilder_0.Password, byte_1);
			Array.Copy(array, 1, array, 0, array.Length - 1);
			Array.Resize(ref array, array.Length - 1);
			array2 = encoding.GetBytes(string.Format(getString_2(107365472), BitConverter.ToString(array).Replace(getString_2(107409283), string.Empty)));
		}
		byte[] array3 = new byte[bytes2.Length + bytes.Length + array2.Length + 2];
		bytes2.CopyTo(array3, 0);
		int num = bytes2.Length;
		array3[num++] = 0;
		bytes.CopyTo(array3, num);
		num += bytes.Length;
		array3[num++] = 0;
		array2.CopyTo(array3, num);
		return array3;
	}

	static Class114()
	{
		Strings.CreateGetStringDelegate(typeof(Class114));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_2(107398015), getString_2(107398010)).Replace(getString_2(107397973), getString_2(107397968)));
		if (!StrongNameSignatureVerificationEx_1(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_2(107397963)))
		{
			throw new SecurityException(getString_2(107397938));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode, EntryPoint = "StrongNameSignatureVerificationEx")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx_1([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
