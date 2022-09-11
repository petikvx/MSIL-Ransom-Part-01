using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace System.Data.SQLite;

internal sealed class SQLiteConnectionHandle : CriticalHandle
{
	private bool ownHandle;

	[NonSerialized]
	internal static GetString _0018;

	public bool OwnHandle => ownHandle;

	public override bool IsInvalid => handle == IntPtr.Zero;

	public static implicit operator IntPtr(SQLiteConnectionHandle db)
	{
		return db?.handle ?? IntPtr.Zero;
	}

	internal SQLiteConnectionHandle(IntPtr db, bool ownHandle)
		: this(ownHandle)
	{
		this.ownHandle = ownHandle;
		SetHandle(db);
	}

	private SQLiteConnectionHandle(bool ownHandle)
		: base(IntPtr.Zero)
	{
	}

	protected override bool ReleaseHandle()
	{
		if (!ownHandle)
		{
			return true;
		}
		try
		{
			IntPtr intPtr = Interlocked.Exchange(ref handle, IntPtr.Zero);
			if (intPtr != IntPtr.Zero)
			{
				SQLiteBase.CloseConnection(this, intPtr);
			}
		}
		catch (SQLiteException)
		{
		}
		finally
		{
			SetHandleAsInvalid();
		}
		return true;
	}

	static SQLiteConnectionHandle()
	{
		Strings.CreateGetStringDelegate(typeof(SQLiteConnectionHandle));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0018(107401319), _0018(107401282)), _0018(107401277), _0018(107401272)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0018(107401299)))
		{
			return;
		}
		throw new SecurityException(_0018(107401242));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
