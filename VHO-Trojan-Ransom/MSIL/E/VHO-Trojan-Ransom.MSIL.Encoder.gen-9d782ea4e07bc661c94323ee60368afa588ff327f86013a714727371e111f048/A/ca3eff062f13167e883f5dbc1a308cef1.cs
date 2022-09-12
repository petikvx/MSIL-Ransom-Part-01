using System;
using System.Runtime.InteropServices;
using System.Text;

namespace A;

internal class ca3eff062f13167e883f5dbc1a308cef1
{
	[StructLayout(LayoutKind.Sequential)]
	internal class cba9c5f3e41117243c67549bdcaf2846c
	{
		internal IntPtr ce10d43ef14118a982e63db6855428f29;

		internal IntPtr c8182a15eafcc19b766593399e6f6ffdc;

		internal IntPtr c16f8893136d26e279201a7e7b899a21b;

		internal IntPtr c47586b3ee4ce3d5b88ece1ab36ebdba8;

		internal IntPtr cbfbda39fe627623b8efc8d1200e05a44;

		internal IntPtr c5fbd7aae9cf791e9555404f1cd330116;
	}

	internal delegate int c28024ce834523681988f34eeea17c3ea(IntPtr ProcessHandle, int ProcessInformationClass, cba9c5f3e41117243c67549bdcaf2846c ProcessInformation, uint ProcessInformationLength, out uint ReturnLength);

	internal delegate int c939e59bcc84420aadc444ce978e6ac51(IntPtr ProcessHandle, int ProcessInformationClass, out uint debugPort, uint ProcessInformationLength, out uint ReturnLength);

	internal delegate int c2d5c4ad352c57c82ea9f107f81fa000e();

	internal delegate void c2a2c9f3622323f2f8a9a3a194c901325([MarshalAs(UnmanagedType.LPStr)] string lpOutputString);

	internal delegate int c809419ce364ba96a885967d96edd0ae9(IntPtr hProcess, ref int pbDebuggerPresent);

	internal delegate int cc89f2165c1c19ddf1b27c9264e6ad405(IntPtr wnd, IntPtr lParam);

	internal delegate int cf042880ba45f1f7f78b1086a51e8a183(cc89f2165c1c19ddf1b27c9264e6ad405 lpEnumFunc, IntPtr lParam);

	internal const uint c91112284bc1c7461f785de62ba939746 = 1024u;

	internal const uint c1e84b9f7aef9a1761cbf7405aacf52f6 = 64u;

	internal const int c886547b14dc58fdcaedc7195db4a73aa = 0;

	private static bool c3e041864c35c05e2695fc9409c4f132e;

	[DllImport("kernel32.dll", EntryPoint = "SetLastError", ExactSpelling = true)]
	internal static extern void c82710495b32c6009e5399428f2df8ecb(uint cded6ff8e2384c86e33d68b8307a70720);

	[DllImport("kernel32.dll", EntryPoint = "CloseHandle", ExactSpelling = true)]
	internal static extern int c61e6e5911f0df4f681ab7b77c7fe2526(IntPtr c12a233285125082ddf0b90ec3f72aa55);

	[DllImport("kernel32.dll", EntryPoint = "OpenProcess", ExactSpelling = true)]
	internal static extern IntPtr cd2200b560401580c9ec8cdcd89c1dfd6(uint caed541d1cc1b079f038cdcd89576528c, int c9c2cb3a43e446a5f7354a09f9a6b870f, uint cda954fc06157aff5c6a29c8123d6c71e);

	[DllImport("kernel32.dll", EntryPoint = "GetCurrentProcessId", ExactSpelling = true)]
	internal static extern uint cd05c59dd74af07c4701919c2a082099f();

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "LoadLibrary", SetLastError = true)]
	internal static extern IntPtr c8917cfcb7e525b7f940d0118b3258b62(string c2d02342fbf5cc36ae7ac2525f1863001);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
	internal static extern c28024ce834523681988f34eeea17c3ea c96cd965b1baee927a3fa33f3e80f58be(IntPtr c528fe824ca7d0cc3dd7e56bc5c3192fb, string c16e91d400d723ac5bff65cd9299a91f7);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
	internal static extern c939e59bcc84420aadc444ce978e6ac51 c0bc5ad28ed1645770a7eb4178ca97663(IntPtr c528fe824ca7d0cc3dd7e56bc5c3192fb, string c16e91d400d723ac5bff65cd9299a91f7);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
	internal static extern c809419ce364ba96a885967d96edd0ae9 caf6ee4150d4170e05c46a4a4ac5d4ac4(IntPtr c528fe824ca7d0cc3dd7e56bc5c3192fb, string c16e91d400d723ac5bff65cd9299a91f7);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
	internal static extern c2d5c4ad352c57c82ea9f107f81fa000e cbb3f0350767fa48f98fea5b789ce1566(IntPtr c528fe824ca7d0cc3dd7e56bc5c3192fb, string c16e91d400d723ac5bff65cd9299a91f7);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
	internal static extern c2a2c9f3622323f2f8a9a3a194c901325 c5319eae992e447aeb05d58b38f5a4a66(IntPtr c528fe824ca7d0cc3dd7e56bc5c3192fb, string c16e91d400d723ac5bff65cd9299a91f7);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
	internal static extern cf042880ba45f1f7f78b1086a51e8a183 c054b9c61d5df3f54879d595f04101fc3(IntPtr c528fe824ca7d0cc3dd7e56bc5c3192fb, string c16e91d400d723ac5bff65cd9299a91f7);

	private static int ce47d6eb9b720eed2d1bd64b79f2f57f1(IntPtr cf137927018f0aabdc8265771457ebb84, IntPtr cb3657517f500b6eb1aba85761cf806f8)
	{
		string[] array = new string[1] { c31945d2aaa18ec5ca5cb764224af74b2.cb3d61e6ddbc94a218c98dc11d6c8ee40(2597) };
		string cbf979afd484fde812cf185a3a = cc14c001ca5d6010b521d8990a334a102(cf137927018f0aabdc8265771457ebb84);
		string[] array2 = array;
		foreach (string cbf979afd484fde812cf185a3a2 in array2)
		{
			if (c277a655bbed8dc9b9e10a56f77a73985.c0a0a027f52dbb53b7a992b50e32f26b6(cbf979afd484fde812cf185a3a, cbf979afd484fde812cf185a3a2, cbf979afd484fde812cf185a3a5906959: true) != 0)
			{
				continue;
			}
			while (true)
			{
				switch (2)
				{
				case 0:
					continue;
				}
				if (1 == 0)
				{
					/*OpCode not supported: LdMemberToken*/;
				}
				c3e041864c35c05e2695fc9409c4f132e = true;
				return 0;
			}
		}
		while (true)
		{
			switch (3)
			{
			case 0:
				continue;
			}
			return 1;
		}
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "GetClassName")]
	internal static extern int c600337b87569e3cdcc570708aa82d86e(IntPtr c4f8ec23deee0daa1abb4553a4b2a021d, StringBuilder c246e56078550c8bb09ecc8ea94b86b48, int c003e07d025a7afdeed1fc84fdf57d454);

	internal static string cc14c001ca5d6010b521d8990a334a102(IntPtr c2ba959b5c4d1a99128209fa330043eda)
	{
		StringBuilder stringBuilder = cfb8c35440a07dcb8605447d013811465.c0a0a027f52dbb53b7a992b50e32f26b6(260);
		c600337b87569e3cdcc570708aa82d86e(c2ba959b5c4d1a99128209fa330043eda, stringBuilder, c6d0c71cad6bb34640ccee1b9fd1e4082.cb820d091707fb0ff42c9a92b27592d9f(stringBuilder));
		return c3856465001ccaa8d621ca369a878fbd8.cb820d091707fb0ff42c9a92b27592d9f(stringBuilder);
	}

	internal static void ce194d0533b5afb16ffa97fc2a71d9924()
	{
		if (c7ddcf726243dda7b25eed8eed72809bf())
		{
			string cbf979afd484fde812cf185a3a = c31945d2aaa18ec5ca5cb764224af74b2.cb3d61e6ddbc94a218c98dc11d6c8ee40(2612);
			throw c1686a4da61d51842c722231116cc7677.c0a0a027f52dbb53b7a992b50e32f26b6(c9f58634ed009b1f92c1d1034983bfa92.c0a0a027f52dbb53b7a992b50e32f26b6(c31945d2aaa18ec5ca5cb764224af74b2.cb3d61e6ddbc94a218c98dc11d6c8ee40(2629), cbf979afd484fde812cf185a3a));
		}
	}

	internal static bool c7ddcf726243dda7b25eed8eed72809bf()
	{
		try
		{
			if (c688448f5946dd9b5fe4147667ad708bf.c0a0a027f52dbb53b7a992b50e32f26b6())
			{
				while (true)
				{
					switch (6)
					{
					case 0:
						continue;
					}
					if (1 == 0)
					{
						/*OpCode not supported: LdMemberToken*/;
					}
					return true;
				}
			}
			IntPtr c528fe824ca7d0cc3dd7e56bc5c3192fb = c8917cfcb7e525b7f940d0118b3258b62(c31945d2aaa18ec5ca5cb764224af74b2.cb3d61e6ddbc94a218c98dc11d6c8ee40(2756));
			c2d5c4ad352c57c82ea9f107f81fa000e c2d5c4ad352c57c82ea9f107f81fa000e = cbb3f0350767fa48f98fea5b789ce1566(c528fe824ca7d0cc3dd7e56bc5c3192fb, c31945d2aaa18ec5ca5cb764224af74b2.cb3d61e6ddbc94a218c98dc11d6c8ee40(2781));
			if (c2d5c4ad352c57c82ea9f107f81fa000e != null)
			{
				while (true)
				{
					switch (3)
					{
					case 0:
						continue;
					}
					break;
				}
				if (ccde6ce3dd66d980f7ee501a0dcfab7c6.cb820d091707fb0ff42c9a92b27592d9f(c2d5c4ad352c57c82ea9f107f81fa000e) != 0)
				{
					while (true)
					{
						switch (1)
						{
						case 0:
							break;
						default:
							return true;
						}
					}
				}
			}
			uint cda954fc06157aff5c6a29c8123d6c71e = cd05c59dd74af07c4701919c2a082099f();
			IntPtr intPtr = cd2200b560401580c9ec8cdcd89c1dfd6(1024u, 0, cda954fc06157aff5c6a29c8123d6c71e);
			if (c7ea79d8e69336e6d7b8ee2200a1dacf8.c0a0a027f52dbb53b7a992b50e32f26b6(intPtr, IntPtr.Zero))
			{
				while (true)
				{
					switch (5)
					{
					case 0:
						continue;
					}
					break;
				}
				try
				{
					c809419ce364ba96a885967d96edd0ae9 c809419ce364ba96a885967d96edd0ae = caf6ee4150d4170e05c46a4a4ac5d4ac4(c528fe824ca7d0cc3dd7e56bc5c3192fb, c31945d2aaa18ec5ca5cb764224af74b2.cb3d61e6ddbc94a218c98dc11d6c8ee40(2816));
					if (c809419ce364ba96a885967d96edd0ae != null)
					{
						while (true)
						{
							switch (3)
							{
							case 0:
								continue;
							}
							int ca01513645c081167ab8f91e75432e36e = 0;
							if (cba5b90ea4906e7e2879fbc7bcf8c9d0d.cb820d091707fb0ff42c9a92b27592d9f(c809419ce364ba96a885967d96edd0ae, intPtr, ref ca01513645c081167ab8f91e75432e36e) == 0)
							{
								break;
							}
							while (true)
							{
								switch (2)
								{
								case 0:
									continue;
								}
								if (ca01513645c081167ab8f91e75432e36e == 0)
								{
									break;
								}
								while (true)
								{
									switch (2)
									{
									case 0:
										continue;
									}
									return true;
								}
							}
							break;
						}
					}
				}
				finally
				{
					c61e6e5911f0df4f681ab7b77c7fe2526(intPtr);
				}
			}
			bool flag = false;
			try
			{
				c61e6e5911f0df4f681ab7b77c7fe2526(new IntPtr(305419896));
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
				IntPtr c528fe824ca7d0cc3dd7e56bc5c3192fb2 = c8917cfcb7e525b7f940d0118b3258b62(c31945d2aaa18ec5ca5cb764224af74b2.cb3d61e6ddbc94a218c98dc11d6c8ee40(2869));
				cf042880ba45f1f7f78b1086a51e8a183 cf042880ba45f1f7f78b1086a51e8a = c054b9c61d5df3f54879d595f04101fc3(c528fe824ca7d0cc3dd7e56bc5c3192fb2, c31945d2aaa18ec5ca5cb764224af74b2.cb3d61e6ddbc94a218c98dc11d6c8ee40(2890));
				if (cf042880ba45f1f7f78b1086a51e8a != null)
				{
					c3e041864c35c05e2695fc9409c4f132e = false;
					ca6bc81148a1bb2d7b6c671262ec5f13c.cb820d091707fb0ff42c9a92b27592d9f(cf042880ba45f1f7f78b1086a51e8a, ce47d6eb9b720eed2d1bd64b79f2f57f1, IntPtr.Zero);
					if (c3e041864c35c05e2695fc9409c4f132e)
					{
						while (true)
						{
							switch (1)
							{
							case 0:
								break;
							default:
								return true;
							}
						}
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
