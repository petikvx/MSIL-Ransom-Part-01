using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace System.Data.SQLite;

internal sealed class SQLiteBackupHandle : CriticalHandle
{
	private SQLiteConnectionHandle cnn;

	[NonSerialized]
	internal static GetString _0084;

	public override bool IsInvalid => handle == IntPtr.Zero;

	public static implicit operator IntPtr(SQLiteBackupHandle backup)
	{
		return backup?.handle ?? IntPtr.Zero;
	}

	internal SQLiteBackupHandle(SQLiteConnectionHandle cnn, IntPtr backup)
		: this()
	{
		this.cnn = cnn;
		SetHandle(backup);
	}

	private SQLiteBackupHandle()
		: base(IntPtr.Zero)
	{
	}

	protected override bool ReleaseHandle()
	{
		try
		{
			IntPtr intPtr = Interlocked.Exchange(ref handle, IntPtr.Zero);
			if (intPtr != IntPtr.Zero)
			{
				SQLiteBase.FinishBackup(cnn, intPtr);
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

	static SQLiteBackupHandle()
	{
		Strings.CreateGetStringDelegate(typeof(SQLiteBackupHandle));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0084(107401322), _0084(107401285)), _0084(107401280), _0084(107401275)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0084(107401302)))
		{
			return;
		}
		throw new SecurityException(_0084(107401245));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
