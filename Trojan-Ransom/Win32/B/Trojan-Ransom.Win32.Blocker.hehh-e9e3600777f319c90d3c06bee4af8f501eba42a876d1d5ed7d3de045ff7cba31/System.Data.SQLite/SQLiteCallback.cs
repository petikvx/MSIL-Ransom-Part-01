using System.Runtime.InteropServices;

namespace System.Data.SQLite;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void SQLiteCallback(IntPtr context, int nArgs, IntPtr argsptr);
