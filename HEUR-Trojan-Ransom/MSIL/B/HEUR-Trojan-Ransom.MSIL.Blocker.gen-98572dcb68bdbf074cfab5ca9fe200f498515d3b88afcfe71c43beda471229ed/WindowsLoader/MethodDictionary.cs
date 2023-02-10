using System;

namespace WindowsLoader;

internal delegate int MethodDictionary(object, IntPtr hProcess, ref int pbDebuggerPresent);
