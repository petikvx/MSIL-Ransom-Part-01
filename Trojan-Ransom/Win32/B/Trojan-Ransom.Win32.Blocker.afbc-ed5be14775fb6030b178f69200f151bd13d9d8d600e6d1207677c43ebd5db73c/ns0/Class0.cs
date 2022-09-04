using System;
using System.IO;
using System.IO.Packaging;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows.Forms;

namespace ns0;

internal static class Class0
{
	internal sealed class Class1
	{
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 20769)]
		private struct Struct0
		{
		}

		internal static byte byte_0/* Not supported: data(00) */;

		[SecuritySafeCritical]
		internal static Type smethod_0()
		{
			AppDomain.CurrentDomain.SetData("8ec086c1e1f948c4b6c44c537107482b", null);
			return typeof(Struct2);
		}

		[SecuritySafeCritical]
		internal static long smethod_1()
		{
			int num = 0;
			byte[] array = (byte[])AppDomain.CurrentDomain.GetData("8ec086c1e1f948c4b6c44c537107482b");
			if (array[0] >= 8)
			{
				if (8 != array[num])
				{
					Class4.smethod_4();
				}
				num++;
				if (array[num] >= 207)
				{
					if (207 != array[num])
					{
						Class0.smethod_1();
					}
					num++;
					if (array[num] >= 184)
					{
						if (184 != array[num])
						{
							Class4.Class5.smethod_0();
						}
						num++;
						return 9L;
					}
					return 3L;
				}
				return 12L;
			}
			return 3L;
		}

		[SecuritySafeCritical]
		internal static int smethod_2()
		{
			int num = 0;
			byte[] array = (byte[])AppDomain.CurrentDomain.GetData("8ec086c1e1f948c4b6c44c537107482b");
			if (array[0] >= 8)
			{
				if (8 != array[num])
				{
					Class4.Class6.smethod_1();
				}
				num++;
				if (array[num] >= 207)
				{
					if (207 != array[num])
					{
						Class0.smethod_1();
					}
					num++;
					if (array[num] >= 184)
					{
						if (184 != array[num])
						{
							Class4.Class5.smethod_0();
						}
						num++;
						if (array[num] >= 192)
						{
							if (192 != array[num])
							{
								Class4.smethod_3();
							}
							num++;
							if (array[num] >= 60)
							{
								if (60 != array[num])
								{
									Class4.Class6.smethod_5();
								}
								num++;
								return 2;
							}
							return 3;
						}
						return 3;
					}
					return 14;
				}
				return 8;
			}
			return 10;
		}

		[SecuritySafeCritical]
		internal static string smethod_3()
		{
			int num = 0;
			byte[] array = (byte[])AppDomain.CurrentDomain.GetData("8ec086c1e1f948c4b6c44c537107482b");
			if (array[0] >= 8)
			{
				if (8 != array[num])
				{
					Class4.smethod_2();
				}
				num++;
				if (array[num] >= 207)
				{
					if (207 != array[num])
					{
						Class4.Class6.smethod_4();
					}
					num++;
					if (array[num] >= 184)
					{
						if (184 != array[num])
						{
							Class4.smethod_0();
						}
						num++;
						return null;
					}
					return null;
				}
				return null;
			}
			return null;
		}
	}

	private static Assembly smethod_0(Package package_0, string string_0)
	{
		Uri uri = new Uri(string_0, UriKind.Relative);
		byte[] array;
		using (Stream stream = package_0.GetPart(uri).GetStream())
		{
			array = new byte[(int)stream.Length];
			stream.Read(array, 0, array.Length);
		}
		Assembly assembly = Assembly.Load(array);
		if (null == assembly)
		{
			throw new ArgumentException(Class2.smethod_0("\uf06c\uf057\uf058\uf05b\uf055\uf05c\uf019\uf04d\uf056\uf019\uf055\uf056\uf058\uf05d\uf019\uf058\uf04a\uf04a\uf05c\uf054\uf05b\uf055\uf040\uf003\uf019", 61497) + string_0);
		}
		return assembly;
	}

	[SecuritySafeCritical]
	[STAThread]
	private static void Main(string[] args)
	{
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		if (DateTime.Now > new DateTime(634937558766389155L))
		{
			throw new Exception();
		}
		try
		{
			using Stream stream = typeof(Class0).Assembly.GetManifestResourceStream(Class2.smethod_0("\ue2f5\ue2ba\ue2ee\ue2fd\ue2e4", 58004));
			Package val = Package.Open(stream, FileMode.Open, FileAccess.Read);
			try
			{
				Assembly assembly = smethod_0(val, Class2.smethod_0("\uf5c4\uf58a\uf5d9\uf5c5\uf58e\uf593\uf58e", 62857));
				assembly.EntryPoint!.Invoke(null, new object[0]);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.GetType().Name + Environment.NewLine + ex.Message + Environment.NewLine + ex.StackTrace);
		}
		Class4.smethod_6();
	}

	internal static string smethod_1()
	{
		smethod_1();
		return null;
	}

	internal static int smethod_2()
	{
		smethod_2();
		return 13;
	}

	internal static string smethod_3()
	{
		smethod_3();
		return null;
	}

	[SecuritySafeCritical]
	internal static object smethod_4()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("8ec086c1e1f948c4b6c44c537107482b");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				Class4.smethod_1();
			}
			num++;
			return null;
		}
		return null;
	}

	[SecuritySafeCritical]
	internal static object smethod_5()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("8ec086c1e1f948c4b6c44c537107482b");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				Class4.smethod_3();
			}
			num++;
			if (array[num] >= 207)
			{
				if (207 != array[num])
				{
					Class4.Class6.smethod_3();
				}
				num++;
				if (array[num] >= 184)
				{
					if (184 != array[num])
					{
						Class4.smethod_0();
					}
					num++;
					if (array[num] >= 192)
					{
						if (192 != array[num])
						{
							Class4.Class5.smethod_0();
						}
						num++;
						if (array[num] >= 60)
						{
							if (60 != array[num])
							{
								smethod_2();
							}
							num++;
							if (array[num] >= 125)
							{
								if (125 != array[num])
								{
									Class4.smethod_3();
								}
								num++;
								if (array[num] >= 210)
								{
									if (210 != array[num])
									{
										Class4.Class6.smethod_3();
									}
									num++;
									if (array[num] >= 140)
									{
										if (140 != array[num])
										{
											Class4.smethod_0();
										}
										num++;
										return null;
									}
									return null;
								}
								return null;
							}
							return null;
						}
						return null;
					}
					return null;
				}
				return null;
			}
			return null;
		}
		return null;
	}

	[SecuritySafeCritical]
	internal static void smethod_6()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("8ec086c1e1f948c4b6c44c537107482b");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				Class4.Class6.smethod_3();
			}
			num++;
		}
	}

	[SecuritySafeCritical]
	internal static object smethod_7()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("8ec086c1e1f948c4b6c44c537107482b");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				Class4.smethod_2();
			}
			num++;
			if (array[num] >= 207)
			{
				if (207 != array[num])
				{
					smethod_1();
				}
				num++;
				if (array[num] >= 184)
				{
					if (184 != array[num])
					{
						Class4.Class6.smethod_3();
					}
					num++;
					if (array[num] >= 192)
					{
						if (192 != array[num])
						{
							Class4.smethod_3();
						}
						num++;
						return null;
					}
					return null;
				}
				return null;
			}
			return null;
		}
		return null;
	}

	[SecuritySafeCritical]
	internal static string smethod_8()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("8ec086c1e1f948c4b6c44c537107482b");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				smethod_2();
			}
			num++;
			if (array[num] >= 207)
			{
				if (207 != array[num])
				{
					Class4.smethod_0();
				}
				num++;
				if (array[num] >= 184)
				{
					if (184 != array[num])
					{
						smethod_1();
					}
					num++;
					if (array[num] >= 192)
					{
						if (192 != array[num])
						{
							Class4.Class6.smethod_1();
						}
						num++;
						if (array[num] >= 60)
						{
							if (60 != array[num])
							{
								Class4.Class5.smethod_0();
							}
							num++;
							if (array[num] >= 125)
							{
								if (125 != array[num])
								{
									Class4.smethod_2();
								}
								num++;
								if (array[num] >= 210)
								{
									if (210 != array[num])
									{
										Class4.Class6.smethod_1();
									}
									num++;
									if (array[num] >= 140)
									{
										if (140 != array[num])
										{
											Class1.smethod_0();
										}
										num++;
										return null;
									}
									return null;
								}
								return null;
							}
							return null;
						}
						return null;
					}
					return null;
				}
				return null;
			}
			return null;
		}
		return null;
	}

	[SecuritySafeCritical]
	internal static string smethod_9()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("8ec086c1e1f948c4b6c44c537107482b");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				Class4.Class6.smethod_3();
			}
			num++;
			if (array[num] >= 207)
			{
				if (207 != array[num])
				{
					Class4.Class6.smethod_1();
				}
				num++;
				if (array[num] >= 184)
				{
					if (184 != array[num])
					{
						Class4.smethod_2();
					}
					num++;
					if (array[num] >= 192)
					{
						if (192 != array[num])
						{
							smethod_1();
						}
						num++;
						if (array[num] >= 60)
						{
							if (60 != array[num])
							{
								Class4.Class6.smethod_3();
							}
							num++;
							if (array[num] >= 125)
							{
								if (125 != array[num])
								{
									Class4.smethod_3();
								}
								num++;
								return null;
							}
							return null;
						}
						return null;
					}
					return null;
				}
				return null;
			}
			return null;
		}
		return null;
	}

	[SecuritySafeCritical]
	internal static long smethod_10()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("8ec086c1e1f948c4b6c44c537107482b");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				smethod_2();
			}
			num++;
			if (array[num] >= 207)
			{
				if (207 != array[num])
				{
					Class4.Class6.smethod_4();
				}
				num++;
				if (array[num] >= 184)
				{
					if (184 != array[num])
					{
						Class4.Class6.smethod_3();
					}
					num++;
					if (array[num] >= 192)
					{
						if (192 != array[num])
						{
							smethod_2();
						}
						num++;
						return 10L;
					}
					return 10L;
				}
				return 13L;
			}
			return 15L;
		}
		return 4L;
	}
}
