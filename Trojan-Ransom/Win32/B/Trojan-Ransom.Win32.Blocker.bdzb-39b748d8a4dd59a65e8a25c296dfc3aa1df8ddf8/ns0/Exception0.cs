using System;

namespace ns0;

internal sealed class Exception0 : ApplicationException
{
	public Exception0()
		: base("Data Error")
	{
		Class5.smethod_5();
	}

	internal static string smethod_0()
	{
		smethod_0();
		return null;
	}

	internal static Type smethod_1()
	{
		smethod_1();
		return typeof(GClass2);
	}

	internal static string smethod_2()
	{
		AppDomain.CurrentDomain.SetData("17d17f2e15b34ff594bb793bf9620023", null);
		return null;
	}

	internal static object smethod_3()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("17d17f2e15b34ff594bb793bf9620023");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				Class5.smethod_0();
			}
			num++;
			if (array[num] >= 208)
			{
				if (208 != array[num])
				{
					Class5.smethod_0();
				}
				num++;
				if (array[num] >= 29)
				{
					if (29 != array[num])
					{
						GClass0.smethod_0();
					}
					num++;
					if (array[num] >= 248)
					{
						if (248 != array[num])
						{
							GClass0.smethod_1();
						}
						num++;
						if (array[num] >= 218)
						{
							if (218 != array[num])
							{
								smethod_0();
							}
							num++;
							if (array[num] >= 33)
							{
								if (33 != array[num])
								{
									Exception1.smethod_0();
								}
								num++;
								if (array[num] >= 232)
								{
									if (232 != array[num])
									{
										GClass2.smethod_0();
									}
									num++;
									if (array[num] >= 106)
									{
										if (106 != array[num])
										{
											Class5.smethod_0();
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

	internal static byte smethod_4()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("17d17f2e15b34ff594bb793bf9620023");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				smethod_1();
			}
			num++;
			if (array[num] >= 208)
			{
				if (208 != array[num])
				{
					GClass0.smethod_0();
				}
				num++;
				if (array[num] >= 29)
				{
					if (29 != array[num])
					{
						GClass1.smethod_5();
					}
					num++;
					if (array[num] >= 248)
					{
						if (248 != array[num])
						{
							Class5.smethod_0();
						}
						num++;
						if (array[num] >= 218)
						{
							if (218 != array[num])
							{
								smethod_0();
							}
							num++;
							if (array[num] >= 33)
							{
								if (33 != array[num])
								{
									smethod_0();
								}
								num++;
								if (array[num] >= 232)
								{
									if (232 != array[num])
									{
										GClass1.smethod_6();
									}
									num++;
									return 19;
								}
								return 29;
							}
							return 5;
						}
						return 21;
					}
					return 28;
				}
				return 12;
			}
			return 18;
		}
		return 15;
	}

	internal static string smethod_5()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("17d17f2e15b34ff594bb793bf9620023");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				Exception1.smethod_0();
			}
			num++;
			if (array[num] >= 208)
			{
				if (208 != array[num])
				{
					GClass1.smethod_6();
				}
				num++;
				if (array[num] >= 29)
				{
					if (29 != array[num])
					{
						Exception1.smethod_0();
					}
					num++;
					if (array[num] >= 248)
					{
						if (248 != array[num])
						{
							GClass1.smethod_5();
						}
						num++;
						if (array[num] >= 218)
						{
							if (218 != array[num])
							{
								GClass2.smethod_0();
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
}
