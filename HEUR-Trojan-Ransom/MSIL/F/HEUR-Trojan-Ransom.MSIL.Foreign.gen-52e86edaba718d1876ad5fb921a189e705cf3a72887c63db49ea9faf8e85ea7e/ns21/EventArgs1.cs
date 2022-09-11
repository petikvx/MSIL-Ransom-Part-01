using System;
using System.Data;
using System.Data.Common;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using MySql.Data.MySqlClient;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace ns21;

internal sealed class EventArgs1 : RowUpdatingEventArgs
{
	[NonSerialized]
	internal static GetString getString_0;

	public new MySqlCommand Command
	{
		get
		{
			return (MySqlCommand)base.Command;
		}
		set
		{
			base.Command = value;
		}
	}

	public EventArgs1(DataRow dataRow_0, IDbCommand idbCommand_0, StatementType statementType_0, DataTableMapping dataTableMapping_0)
		: base(dataRow_0, idbCommand_0, statementType_0, dataTableMapping_0)
	{
	}

	static EventArgs1()
	{
		Strings.CreateGetStringDelegate(typeof(EventArgs1));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107398384), getString_0(107398379)).Replace(getString_0(107398342), getString_0(107398337)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107398332)))
		{
			throw new SecurityException(getString_0(107398307));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
