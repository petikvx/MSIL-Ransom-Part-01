namespace System.Data.SQLite;

public interface ISQLiteNativeHandle
{
	IntPtr NativeHandle { get; }
}
