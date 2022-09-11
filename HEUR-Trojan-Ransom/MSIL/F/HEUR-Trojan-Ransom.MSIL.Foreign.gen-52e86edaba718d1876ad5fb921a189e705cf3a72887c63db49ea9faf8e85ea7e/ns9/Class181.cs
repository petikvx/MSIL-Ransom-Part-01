using System;
using System.Data;
using System.Data.Common;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using MySql.Data.MySqlClient;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns11;

namespace ns9;

internal sealed class Class181 : DbTransaction
{
	private bool bool_0;

	private bool bool_1;

	[CompilerGenerated]
	private readonly Class139 class139_0;

	[CompilerGenerated]
	private readonly IsolationLevel isolationLevel_0;

	[NonSerialized]
	internal static GetString getString_0;

	public new Class139 Connection
	{
		[CompilerGenerated]
		get
		{
			return class139_0;
		}
	}

	IsolationLevel DbTransaction.IsolationLevel
	{
		[CompilerGenerated]
		get
		{
			return isolationLevel_0;
		}
	}

	DbConnection DbTransaction.DbConnection => Connection;

	internal Class181(Class139 class139_1, IsolationLevel isolationLevel_1)
	{
		class139_0 = class139_1;
		isolationLevel_0 = isolationLevel_1;
		bool_0 = true;
	}

	void object.Finalize()
	{
		try
		{
			Dispose(disposing: false);
		}
		finally
		{
			base.Finalize();
		}
	}

	void DbTransaction.Dispose(bool disposing)
	{
		if (!bool_1)
		{
			base.Dispose(disposing);
			if (disposing && ((Connection != null && Connection.State == ConnectionState.Open) || Connection.SoftClosed) && bool_0)
			{
				Rollback();
			}
			bool_1 = true;
		}
	}

	void DbTransaction.Commit()
	{
		if (Connection != null && (Connection.State == ConnectionState.Open || Connection.SoftClosed))
		{
			if (!bool_0)
			{
				throw new InvalidOperationException(getString_0(107371252));
			}
			new MySqlCommand(getString_0(107410742), Connection).ExecuteNonQuery();
			bool_0 = false;
			return;
		}
		throw new InvalidOperationException(getString_0(107371329));
	}

	void DbTransaction.Rollback()
	{
		if (Connection != null && (Connection.State == ConnectionState.Open || Connection.SoftClosed))
		{
			if (!bool_0)
			{
				throw new InvalidOperationException(getString_0(107371610));
			}
			new MySqlCommand(getString_0(107410765), Connection).ExecuteNonQuery();
			bool_0 = false;
			return;
		}
		throw new InvalidOperationException(getString_0(107371207));
	}

	static Class181()
	{
		Strings.CreateGetStringDelegate(typeof(Class181));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107399463), getString_0(107399458)).Replace(getString_0(107399421), getString_0(107399416)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_2: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107399411)))
		{
			throw new SecurityException(getString_0(107399386));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_2, [MarshalAs(UnmanagedType.Bool)] out bool bool_3);
}
