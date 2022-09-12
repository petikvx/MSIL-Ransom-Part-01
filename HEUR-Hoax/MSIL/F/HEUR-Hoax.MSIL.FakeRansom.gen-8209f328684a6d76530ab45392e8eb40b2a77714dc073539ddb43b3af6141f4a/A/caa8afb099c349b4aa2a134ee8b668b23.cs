using System;
using System.Runtime.InteropServices;
using System.Text;

namespace A;

internal class caa8afb099c349b4aa2a134ee8b668b23
{
	[StructLayout(LayoutKind.Sequential)]
	internal class cd5f27cff6995e2d91fe474cc576e6eab
	{
		internal IntPtr c92b4c1e2b2b706f5e71548c85de66f19;

		internal IntPtr c657a704001c521016cf83ca226f13a9f;

		internal IntPtr cb60ccab7f79372d504bd6bb4d708ec12;

		internal IntPtr c1270af26e35f24fab8fcc6f1f916807a;

		internal IntPtr c761683bd1d34d21bc287c7c18d2b1923;

		internal IntPtr c8fe45dd917b4796770587edb33f13866;
	}

	internal delegate int cd00db729158e108bc8aa24a6d8139b1a(IntPtr ProcessHandle, int ProcessInformationClass, cd5f27cff6995e2d91fe474cc576e6eab ProcessInformation, uint ProcessInformationLength, out uint ReturnLength);

	internal delegate int c0452249ba0daf72a22b992c9f87a3d37(IntPtr ProcessHandle, int ProcessInformationClass, out uint debugPort, uint ProcessInformationLength, out uint ReturnLength);

	internal delegate int cb2f6a80fa6aeb908fb68572526ac370f();

	internal delegate void cd9dc4d72ce7196d4727d54290d478c0a([MarshalAs(UnmanagedType.LPStr)] string lpOutputString);

	internal delegate int cc4e034529655c5e105a6e0b15213dbc4(IntPtr hProcess, ref int pbDebuggerPresent);

	internal delegate int c9721cf82b8fd0432cee63af80d7f08f5(IntPtr wnd, IntPtr lParam);

	internal delegate int c0c2dc4a31039b6a544682bae2410d90d(c9721cf82b8fd0432cee63af80d7f08f5 lpEnumFunc, IntPtr lParam);

	internal const uint cc6a1c978c4f4cdaf5f96a698e2cf06fc = 1024u;

	internal const uint cfb09aee189f4736a5fff9e52e00d27b4 = 64u;

	internal const int c54160fe81ec0aab462c9b7bdc7f31621 = 0;

	private static bool cb0a2e6493c00176e7066a8f20022a367;

	[DllImport("kernel32.dll", EntryPoint = "SetLastError", ExactSpelling = true)]
	internal static extern void c8c6402a0adbb22d0998106e7850a4acf(uint c119da922a28e5b78a476c855e8b75e6b);

	[DllImport("kernel32.dll", EntryPoint = "CloseHandle", ExactSpelling = true)]
	internal static extern int ce50a25e43b8c373126791245d81e5d33(IntPtr c16573c6d73d74a4347b7a1aead163b9b);

	[DllImport("kernel32.dll", EntryPoint = "OpenProcess", ExactSpelling = true)]
	internal static extern IntPtr cb1b13cb23b59217c2ebd7eb8201fd87c(uint c1e0301f61cb1af836a22d5065a14ccf5, int c00edb62aaa5fd9f4ffd4b87089f8cc4e, uint cdbdec0e04d2254d8738168584ec9b163);

	[DllImport("kernel32.dll", EntryPoint = "GetCurrentProcessId", ExactSpelling = true)]
	internal static extern uint c63356a02973a343b7836d0128e7d697e();

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "LoadLibrary", SetLastError = true)]
	internal static extern IntPtr c3256e0a9c8d7aae09a176a563a46d47f(string cf9dddd36cacde0b57ea8020a2a25e01e);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
	internal static extern cd00db729158e108bc8aa24a6d8139b1a c360f082dde82479c3a3f88c1a1c4c1a0(IntPtr caf05fdf727467032ae818f635ae1d3db, string c157d28f1cb1b2073e0d636ccfcfa4d09);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
	internal static extern c0452249ba0daf72a22b992c9f87a3d37 c88a12ec5ce3abdd73d61282d5aaddb59(IntPtr caf05fdf727467032ae818f635ae1d3db, string c157d28f1cb1b2073e0d636ccfcfa4d09);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
	internal static extern cc4e034529655c5e105a6e0b15213dbc4 ce3f47f72d7b6edf974209be0b1a5c3df(IntPtr caf05fdf727467032ae818f635ae1d3db, string c157d28f1cb1b2073e0d636ccfcfa4d09);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
	internal static extern cb2f6a80fa6aeb908fb68572526ac370f cff34164b78dff74bf36fd74137607219(IntPtr caf05fdf727467032ae818f635ae1d3db, string c157d28f1cb1b2073e0d636ccfcfa4d09);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
	internal static extern cd9dc4d72ce7196d4727d54290d478c0a cb92207a47f7922617c4f127079574227(IntPtr caf05fdf727467032ae818f635ae1d3db, string c157d28f1cb1b2073e0d636ccfcfa4d09);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
	internal static extern c0c2dc4a31039b6a544682bae2410d90d c5623f8be5e50803499a20afdff347574(IntPtr caf05fdf727467032ae818f635ae1d3db, string c157d28f1cb1b2073e0d636ccfcfa4d09);

	private static int c40e9bf88750af18a18de9206194ce26a(IntPtr c6a914ff404c3120f5d634eaf1a71d391, IntPtr c206e28b60eb487ea3b48895507650c47)
	{
		string[] array = new string[1] { c632a89bb0d53924867475883f36b4224.c4d30ab6240cd8b4d2b33df56851ecc87(1366) };
		string c1d31c26784336aaea100918515428428 = c48b4882f3f3e27765da5e04fba4aa07d(c6a914ff404c3120f5d634eaf1a71d391);
		string[] array2 = array;
		foreach (string c1d31c26784336aaea1009185154284282 in array2)
		{
			if (c8f2d8f493f934755cffd40504d050d78.ce9259f91a915c575f208c8c25866101a(c1d31c26784336aaea100918515428428, c1d31c26784336aaea1009185154284282, c1d31c26784336aaea100918515428428: true) == 0)
			{
				cb0a2e6493c00176e7066a8f20022a367 = true;
				return 0;
			}
		}
		return 1;
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "GetClassName")]
	internal static extern int cfb5b2dd36e4d42395dfbd0551107c59c(IntPtr cd9a280c1051d1b9ee81304995387e657, StringBuilder c7b516d51e5a729104632ab87cf49f3b7, int c709f5a83fb821bd2b86bd97ef94ce938);

	internal static string c48b4882f3f3e27765da5e04fba4aa07d(IntPtr c2ed3269e85d4881cf6f417b3271e53ce)
	{
		StringBuilder stringBuilder = c2f2ddae4f8541da07a32de220f5df53c.ce9259f91a915c575f208c8c25866101a(260);
		cfb5b2dd36e4d42395dfbd0551107c59c(c2ed3269e85d4881cf6f417b3271e53ce, stringBuilder, cf1408d51aeb8c712f7bb9b660b74e383.c81980d51cb97c259722504a0e1732716(stringBuilder));
		return c3c52308230b75de824923426520a739a.c81980d51cb97c259722504a0e1732716(stringBuilder);
	}

	internal static void ce68941dab9eed682437fccdbd75135b2()
	{
		if (c9e0f5e5f669a13931c74f33147b00e87())
		{
			string c1d31c26784336aaea100918515428428 = c632a89bb0d53924867475883f36b4224.c4d30ab6240cd8b4d2b33df56851ecc87(1381);
			throw c58c8bec9050df869a6bee34577bd933c.ce9259f91a915c575f208c8c25866101a(ce0ae5cc22efa86b8c8bbbcf976ee277d.ce9259f91a915c575f208c8c25866101a(c632a89bb0d53924867475883f36b4224.c4d30ab6240cd8b4d2b33df56851ecc87(1398), c1d31c26784336aaea100918515428428));
		}
	}

	internal static bool c9e0f5e5f669a13931c74f33147b00e87()
	{
		try
		{
			if (ccbd0e0ee89a0df93ad5b8583cd8677de.ce9259f91a915c575f208c8c25866101a())
			{
				return true;
			}
			IntPtr caf05fdf727467032ae818f635ae1d3db = c3256e0a9c8d7aae09a176a563a46d47f(c632a89bb0d53924867475883f36b4224.c4d30ab6240cd8b4d2b33df56851ecc87(1525));
			cb2f6a80fa6aeb908fb68572526ac370f cb2f6a80fa6aeb908fb68572526ac370f = cff34164b78dff74bf36fd74137607219(caf05fdf727467032ae818f635ae1d3db, c632a89bb0d53924867475883f36b4224.c4d30ab6240cd8b4d2b33df56851ecc87(1550));
			if (cb2f6a80fa6aeb908fb68572526ac370f != null && c44d560e97f43a9b183b9c435630595c9.c81980d51cb97c259722504a0e1732716(cb2f6a80fa6aeb908fb68572526ac370f) != 0)
			{
				return true;
			}
			uint cdbdec0e04d2254d8738168584ec9b = c63356a02973a343b7836d0128e7d697e();
			IntPtr intPtr = cb1b13cb23b59217c2ebd7eb8201fd87c(1024u, 0, cdbdec0e04d2254d8738168584ec9b);
			if (c39e6bbf9c16edb447a5b30745942bca2.ce9259f91a915c575f208c8c25866101a(intPtr, IntPtr.Zero))
			{
				try
				{
					cc4e034529655c5e105a6e0b15213dbc4 cc4e034529655c5e105a6e0b15213dbc = ce3f47f72d7b6edf974209be0b1a5c3df(caf05fdf727467032ae818f635ae1d3db, c632a89bb0d53924867475883f36b4224.c4d30ab6240cd8b4d2b33df56851ecc87(1585));
					if (cc4e034529655c5e105a6e0b15213dbc != null)
					{
						int c7fad4467be6e34084b00bd2efb27833a = 0;
						if (c4f000f035796365ac337588127d570be.c81980d51cb97c259722504a0e1732716(cc4e034529655c5e105a6e0b15213dbc, intPtr, ref c7fad4467be6e34084b00bd2efb27833a) != 0 && c7fad4467be6e34084b00bd2efb27833a != 0)
						{
							return true;
						}
					}
				}
				finally
				{
					ce50a25e43b8c373126791245d81e5d33(intPtr);
				}
			}
			bool flag = false;
			try
			{
				ce50a25e43b8c373126791245d81e5d33(new IntPtr(305419896));
			}
			catch
			{
				flag = true;
			}
			if (flag)
			{
				return true;
			}
			try
			{
				IntPtr caf05fdf727467032ae818f635ae1d3db2 = c3256e0a9c8d7aae09a176a563a46d47f(c632a89bb0d53924867475883f36b4224.c4d30ab6240cd8b4d2b33df56851ecc87(1638));
				c0c2dc4a31039b6a544682bae2410d90d c0c2dc4a31039b6a544682bae2410d90d = c5623f8be5e50803499a20afdff347574(caf05fdf727467032ae818f635ae1d3db2, c632a89bb0d53924867475883f36b4224.c4d30ab6240cd8b4d2b33df56851ecc87(1659));
				if (c0c2dc4a31039b6a544682bae2410d90d != null)
				{
					cb0a2e6493c00176e7066a8f20022a367 = false;
					c8a293e7833104a3e27cc4c6b50ca571b.c81980d51cb97c259722504a0e1732716(c0c2dc4a31039b6a544682bae2410d90d, c40e9bf88750af18a18de9206194ce26a, IntPtr.Zero);
					if (cb0a2e6493c00176e7066a8f20022a367)
					{
						return true;
					}
				}
			}
			catch
			{
			}
		}
		catch
		{
		}
		return false;
	}
}
