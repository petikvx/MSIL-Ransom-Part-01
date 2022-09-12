using System;
using System.Runtime.InteropServices;
using System.Text;

namespace A;

internal class cedb3c59319949f7f2906a05302615734
{
	[StructLayout(LayoutKind.Sequential)]
	internal class c13a68da922b479ceb19537172228d729
	{
		internal IntPtr cae57c63f1873909354f6ac38553c60d5;

		internal IntPtr c5ea6eea6b3a838076cc421c086701063;

		internal IntPtr cd5370d238d328e16af30470d23bfc0dd;

		internal IntPtr c627d852fcf0d988e11b379cba7cfbc67;

		internal IntPtr cdd65f4cfeae361a92e41f2cc6846a4bb;

		internal IntPtr c80ed54bc43beefd5856c84187784ea25;
	}

	internal delegate int ca22d3b15f3f37af6e3c03850a0d5136e(IntPtr ProcessHandle, int ProcessInformationClass, c13a68da922b479ceb19537172228d729 ProcessInformation, uint ProcessInformationLength, out uint ReturnLength);

	internal delegate int c58d1800288cf5f9442579cfeba1c5964(IntPtr ProcessHandle, int ProcessInformationClass, out uint debugPort, uint ProcessInformationLength, out uint ReturnLength);

	internal delegate int cbed529dc4ca626ef9a46d2b479288ada();

	internal delegate void c315294a71964b9dfdf55eff827eede18([MarshalAs(UnmanagedType.LPStr)] string lpOutputString);

	internal delegate int c6fe87ee7cf48120d9a1a04c531ae21af(IntPtr hProcess, ref int pbDebuggerPresent);

	internal delegate int cefd080a185bef689160f1d8736eebe2e(IntPtr wnd, IntPtr lParam);

	internal delegate int c798132472af23bb201a9094a2f5a486d(cefd080a185bef689160f1d8736eebe2e lpEnumFunc, IntPtr lParam);

	internal const uint c8cb7a0ec42a5a33832ea401ff8c561e8 = 1024u;

	internal const uint ce78f8c650159c511720b4a4db94921f9 = 64u;

	internal const int c48c9d2a7c9af5b0cf2355d66ee27f9e8 = 0;

	private static bool c3ba702bbddac3505078e812e20eda191;

	[DllImport("kernel32.dll", EntryPoint = "SetLastError", ExactSpelling = true)]
	internal static extern void c41e017e0c969ecfcd4662507f784c3f2(uint c474948609a922e1b7e07bca80cd614c9);

	[DllImport("kernel32.dll", EntryPoint = "CloseHandle", ExactSpelling = true)]
	internal static extern int cff33bb4a2928659c687a2435a98b60f8(IntPtr cc49510296c3782833aa6af0caaec655a);

	[DllImport("kernel32.dll", EntryPoint = "OpenProcess", ExactSpelling = true)]
	internal static extern IntPtr cce96d2cef4182099721fa3928a45d259(uint ca5c737a60394f0e4a215f80ae7469cfb, int c4d09b4137eb5eb87ec92dce30583e06b, uint c034812cd496d1acfe5da017f259fd41e);

	[DllImport("kernel32.dll", EntryPoint = "GetCurrentProcessId", ExactSpelling = true)]
	internal static extern uint cb6db726bd87fbd79ae0600674683641d();

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "LoadLibrary", SetLastError = true)]
	internal static extern IntPtr cf492e4f39b4632a32bb17c2bd5329495(string c3d23c35314fcde9035fe3b5bbe17a841);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
	internal static extern ca22d3b15f3f37af6e3c03850a0d5136e c9399124d5ff6ec7a16ff0464ba2d9b3d(IntPtr c054d8ac64903768c1d0c04371c9a6b57, string cbe02bf9d94651308f0c9ee5b4fc6ba3e);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
	internal static extern c58d1800288cf5f9442579cfeba1c5964 c7df4f630fdbbab44ddc2bbf8879fede0(IntPtr c054d8ac64903768c1d0c04371c9a6b57, string cbe02bf9d94651308f0c9ee5b4fc6ba3e);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
	internal static extern c6fe87ee7cf48120d9a1a04c531ae21af c57b7f5f22fed5505ff2f786bbcead40a(IntPtr c054d8ac64903768c1d0c04371c9a6b57, string cbe02bf9d94651308f0c9ee5b4fc6ba3e);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
	internal static extern cbed529dc4ca626ef9a46d2b479288ada cec517c5d8f3346f852126985f8f51432(IntPtr c054d8ac64903768c1d0c04371c9a6b57, string cbe02bf9d94651308f0c9ee5b4fc6ba3e);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
	internal static extern c315294a71964b9dfdf55eff827eede18 c8361a10b76e99554921b285ae0abe3b8(IntPtr c054d8ac64903768c1d0c04371c9a6b57, string cbe02bf9d94651308f0c9ee5b4fc6ba3e);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
	internal static extern c798132472af23bb201a9094a2f5a486d ce032c1c92debe80c79383235f99a288c(IntPtr c054d8ac64903768c1d0c04371c9a6b57, string cbe02bf9d94651308f0c9ee5b4fc6ba3e);

	private static int c261dc5a52d02c3d2c69499da514814d1(IntPtr cb023cf03124390cf755c0ea57973e646, IntPtr c2887012f0be06cc913b6f8d6e3171c00)
	{
		string[] array = new string[c55ffa6db73375a0be5fddb47b9f55e41.c366fc34c2d0f681f276686895b372a83(2472)];
		array[c55ffa6db73375a0be5fddb47b9f55e41.c366fc34c2d0f681f276686895b372a83(2476)] = cae9133489c19cb9330e00a29929cf61f.c0a9b4096f8bd5ee628bdaf8f596f912d(6351);
		string[] array2 = array;
		string c2316c2504b2172363cc0e32e2b2dd4ba = ca550132a5fa6144500c67378d08f1bcc(cb023cf03124390cf755c0ea57973e646);
		string[] array3 = array2;
		for (int i = c55ffa6db73375a0be5fddb47b9f55e41.c366fc34c2d0f681f276686895b372a83(2480); i < array3.Length; i += c55ffa6db73375a0be5fddb47b9f55e41.c366fc34c2d0f681f276686895b372a83(2496))
		{
			string c2316c2504b2172363cc0e32e2b2dd4ba2 = array3[i];
			if (c3b21c14112b8855671b22d392a86020e.c47310f72a4c995643ae16cec4f007301(c2316c2504b2172363cc0e32e2b2dd4ba, c2316c2504b2172363cc0e32e2b2dd4ba2, (byte)c55ffa6db73375a0be5fddb47b9f55e41.c366fc34c2d0f681f276686895b372a83(2484) != 0) != 0)
			{
				continue;
			}
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
				c3ba702bbddac3505078e812e20eda191 = (byte)c55ffa6db73375a0be5fddb47b9f55e41.c366fc34c2d0f681f276686895b372a83(2488) != 0;
				return c55ffa6db73375a0be5fddb47b9f55e41.c366fc34c2d0f681f276686895b372a83(2492);
			}
		}
		return c55ffa6db73375a0be5fddb47b9f55e41.c366fc34c2d0f681f276686895b372a83(2500);
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "GetClassName")]
	internal static extern int c1628c11d04233a8f8a23f70ced52bde4(IntPtr c741d090b937d2641483ceac29a583e89, StringBuilder c0e06f7b62e5d79e971ae931260d4a741, int c79c895901a934bfdebe6be2ac658949f);

	internal static string ca550132a5fa6144500c67378d08f1bcc(IntPtr cea50f57c2bfa02a3d2e07109f3263067)
	{
		StringBuilder stringBuilder = c1f01307a96abc87f23617388fe8aa1e3.c47310f72a4c995643ae16cec4f007301(c55ffa6db73375a0be5fddb47b9f55e41.c366fc34c2d0f681f276686895b372a83(2504));
		c1628c11d04233a8f8a23f70ced52bde4(cea50f57c2bfa02a3d2e07109f3263067, stringBuilder, c112987777b2f3e29b5527c58cbf00374.cb8051d031a8f62d8a0274b9341e967c8(stringBuilder));
		return c5f0908e55aed45a9d7735f3a7bac412b.cb8051d031a8f62d8a0274b9341e967c8(stringBuilder);
	}

	internal static void cee2f5a52c82a098d25fd6a92dff82982()
	{
		if (!cee3da360e38cfc15c1fa33c34f168d27())
		{
			return;
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
			string c2316c2504b2172363cc0e32e2b2dd4ba = cae9133489c19cb9330e00a29929cf61f.c0a9b4096f8bd5ee628bdaf8f596f912d(6366);
			throw cd7eb7c30574f7a31ea39b223110cea7d.c47310f72a4c995643ae16cec4f007301(c76c6f220c5d52255252e45e9fb0703f3.c47310f72a4c995643ae16cec4f007301(cae9133489c19cb9330e00a29929cf61f.c0a9b4096f8bd5ee628bdaf8f596f912d(6383), c2316c2504b2172363cc0e32e2b2dd4ba));
		}
	}

	internal static bool cee3da360e38cfc15c1fa33c34f168d27()
	{
		try
		{
			if (ca7af2dffc543b89f328425647b393519.c47310f72a4c995643ae16cec4f007301())
			{
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
					return (byte)c55ffa6db73375a0be5fddb47b9f55e41.c366fc34c2d0f681f276686895b372a83(2508) != 0;
				}
			}
			IntPtr c054d8ac64903768c1d0c04371c9a6b = cf492e4f39b4632a32bb17c2bd5329495(cae9133489c19cb9330e00a29929cf61f.c0a9b4096f8bd5ee628bdaf8f596f912d(6510));
			cbed529dc4ca626ef9a46d2b479288ada cbed529dc4ca626ef9a46d2b479288ada = cec517c5d8f3346f852126985f8f51432(c054d8ac64903768c1d0c04371c9a6b, cae9133489c19cb9330e00a29929cf61f.c0a9b4096f8bd5ee628bdaf8f596f912d(6535));
			if (cbed529dc4ca626ef9a46d2b479288ada != null)
			{
				while (true)
				{
					switch (6)
					{
					case 0:
						continue;
					}
					break;
				}
				if (c667e93c7538ed4849d5dfc12d3ae5c69.cb8051d031a8f62d8a0274b9341e967c8(cbed529dc4ca626ef9a46d2b479288ada) != 0)
				{
					while (true)
					{
						switch (5)
						{
						case 0:
							break;
						default:
							return (byte)c55ffa6db73375a0be5fddb47b9f55e41.c366fc34c2d0f681f276686895b372a83(2512) != 0;
						}
					}
				}
			}
			uint c034812cd496d1acfe5da017f259fd41e = cb6db726bd87fbd79ae0600674683641d();
			IntPtr intPtr = cce96d2cef4182099721fa3928a45d259((uint)c55ffa6db73375a0be5fddb47b9f55e41.c366fc34c2d0f681f276686895b372a83(2516), c55ffa6db73375a0be5fddb47b9f55e41.c366fc34c2d0f681f276686895b372a83(2520), c034812cd496d1acfe5da017f259fd41e);
			if (cbd1bf7a19447de2cc365b23954c37e01.c47310f72a4c995643ae16cec4f007301(intPtr, IntPtr.Zero))
			{
				try
				{
					c6fe87ee7cf48120d9a1a04c531ae21af c6fe87ee7cf48120d9a1a04c531ae21af = c57b7f5f22fed5505ff2f786bbcead40a(c054d8ac64903768c1d0c04371c9a6b, cae9133489c19cb9330e00a29929cf61f.c0a9b4096f8bd5ee628bdaf8f596f912d(6570));
					if (c6fe87ee7cf48120d9a1a04c531ae21af != null)
					{
						int c873d61af6b759cbf4b33981fa21365ef = c55ffa6db73375a0be5fddb47b9f55e41.c366fc34c2d0f681f276686895b372a83(2524);
						if (c0efc04ebcb3a73efdbfca20638044bd6.cb8051d031a8f62d8a0274b9341e967c8(c6fe87ee7cf48120d9a1a04c531ae21af, intPtr, ref c873d61af6b759cbf4b33981fa21365ef) != 0)
						{
							while (true)
							{
								switch (5)
								{
								case 0:
									continue;
								}
								if (c873d61af6b759cbf4b33981fa21365ef == 0)
								{
									break;
								}
								while (true)
								{
									switch (5)
									{
									case 0:
										continue;
									}
									return (byte)c55ffa6db73375a0be5fddb47b9f55e41.c366fc34c2d0f681f276686895b372a83(2528) != 0;
								}
							}
						}
					}
				}
				finally
				{
					cff33bb4a2928659c687a2435a98b60f8(intPtr);
				}
			}
			bool flag = (byte)c55ffa6db73375a0be5fddb47b9f55e41.c366fc34c2d0f681f276686895b372a83(2532) != 0;
			try
			{
				cff33bb4a2928659c687a2435a98b60f8(new IntPtr(c55ffa6db73375a0be5fddb47b9f55e41.c366fc34c2d0f681f276686895b372a83(2536)));
			}
			catch
			{
				flag = (byte)c55ffa6db73375a0be5fddb47b9f55e41.c366fc34c2d0f681f276686895b372a83(2540) != 0;
			}
			if (flag)
			{
				while (true)
				{
					switch (5)
					{
					case 0:
						continue;
					}
					return (byte)c55ffa6db73375a0be5fddb47b9f55e41.c366fc34c2d0f681f276686895b372a83(2544) != 0;
				}
			}
			try
			{
				IntPtr c054d8ac64903768c1d0c04371c9a6b2 = cf492e4f39b4632a32bb17c2bd5329495(cae9133489c19cb9330e00a29929cf61f.c0a9b4096f8bd5ee628bdaf8f596f912d(6623));
				c798132472af23bb201a9094a2f5a486d c798132472af23bb201a9094a2f5a486d = ce032c1c92debe80c79383235f99a288c(c054d8ac64903768c1d0c04371c9a6b2, cae9133489c19cb9330e00a29929cf61f.c0a9b4096f8bd5ee628bdaf8f596f912d(6644));
				if (c798132472af23bb201a9094a2f5a486d != null)
				{
					c3ba702bbddac3505078e812e20eda191 = (byte)c55ffa6db73375a0be5fddb47b9f55e41.c366fc34c2d0f681f276686895b372a83(2548) != 0;
					ce2367cba373e535113bc0a4819443e5b.cb8051d031a8f62d8a0274b9341e967c8(c798132472af23bb201a9094a2f5a486d, c261dc5a52d02c3d2c69499da514814d1, IntPtr.Zero);
					if (c3ba702bbddac3505078e812e20eda191)
					{
						while (true)
						{
							switch (5)
							{
							case 0:
								break;
							default:
								return (byte)c55ffa6db73375a0be5fddb47b9f55e41.c366fc34c2d0f681f276686895b372a83(2552) != 0;
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
		return (byte)c55ffa6db73375a0be5fddb47b9f55e41.c366fc34c2d0f681f276686895b372a83(2556) != 0;
	}
}
