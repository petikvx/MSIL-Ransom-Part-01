using System;
using System.Threading;

namespace ns0;

internal sealed class Class0
{
	private static bool bool_0;

	static Class0()
	{
		DwByg39bmV2cgym1M78();
	}

	internal static Type smethod_0(RuntimeTypeHandle runtimeTypeHandle_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			default:
				while (true)
				{
					IL_007c:
					int num = 1;
					while (true)
					{
						num = 4;
						while (true)
						{
							switch (num)
							{
							case 3:
								num = 4;
								continue;
							case 2:
								num = 4;
								continue;
							default:
								mZM6Ak9Kj7LKu6JxJDg();
								if (!kbbNwT9F1UlBZ3Sh80f())
								{
									goto IL_007c;
								}
								if (mZM6Ak9Kj7LKu6JxJDg())
								{
								}
								switch (7)
								{
								case 1:
								case 6:
								case 7:
									break;
								case 0:
								case 5:
								case 8:
									continue;
								default:
									goto IL_007c;
								case 2:
									goto end_IL_0077;
								}
								goto case 3;
							case 0:
							case 1:
								break;
							case 4:
							case 5:
								goto end_IL_0077;
							case 6:
							case 7:
								goto end_IL_0086;
							}
							break;
						}
						continue;
						end_IL_0077:
						break;
					}
					break;
				}
				continue;
			case 80:
				{
					int num = 6;
					break;
				}
				end_IL_0086:
				break;
			}
			break;
		}
		return FvJua495mHfVyPiTYEI(runtimeTypeHandle_0);
	}

	internal static void smethod_1()
	{
		while (true)
		{
			int num = 3;
			while (true)
			{
				if (bool_0)
				{
					return;
				}
				while (true)
				{
					IL_00f7:
					num = 1;
					while (true)
					{
						switch (num)
						{
						case 1:
						case 4:
							break;
						default:
							goto end_IL_00db;
						}
						Type object_;
						uJLhWU9jYBtdXNb8WXq(object_ = FvJua495mHfVyPiTYEI(typeof(Class0).TypeHandle));
						while (true)
						{
							IL_0017:
							try
							{
								if (!bool_0)
								{
									bool_0 = true;
									oNDMbk93NCFvmSIocuy(Sy8O3s9yDdVw8G2s64J(), new ResolveEventHandler(Class1.smethod_1));
								}
							}
							finally
							{
								ReN2w690wdV4W9WBiYm(object_);
							}
							int num2 = 2;
							while (true)
							{
								num2 = 3;
								while (true)
								{
									IL_00b1:
									switch (num2)
									{
									case 4:
									case 5:
										break;
									default:
										mZM6Ak9Kj7LKu6JxJDg();
										if (!kbbNwT9F1UlBZ3Sh80f())
										{
											continue;
										}
										goto end_IL_00b1;
									case 0:
									case 1:
									case 2:
										goto end_IL_00b1;
									case 3:
										return;
									}
									int num3 = 3;
									if (!kbbNwT9F1UlBZ3Sh80f())
									{
										goto end_IL_00d2;
									}
									while (true)
									{
										switch (num3)
										{
										case 12:
											break;
										case 3:
											num2 = 3;
											num3 = 4;
											if (!mZM6Ak9Kj7LKu6JxJDg())
											{
											}
											continue;
										default:
											goto IL_00b1;
										case 5:
										case 7:
											goto end_IL_00b1;
										case 6:
										case 11:
											goto end_IL_00d2;
										case 0:
											goto IL_00f7;
										case 9:
											goto end_IL_00db;
										case 10:
											goto end_IL_00fb;
										case 13:
											return;
										}
										break;
									}
									goto IL_0017;
									continue;
									end_IL_00b1:
									break;
								}
								continue;
								end_IL_00d2:
								break;
							}
							break;
						}
						continue;
						end_IL_00db:
						break;
					}
					break;
				}
				continue;
				end_IL_00fb:
				break;
			}
		}
	}

	internal static string smethod_2(object object_0, object object_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 22:
				return (string)jDRFVG9aK9ylJusO5lH(object_0, object_1);
			}
		}
	}

	internal static void DwByg39bmV2cgym1M78()
	{
		smethod_1();
	}

	internal static bool kbbNwT9F1UlBZ3Sh80f()
	{
		return true;
	}

	internal static bool mZM6Ak9Kj7LKu6JxJDg()
	{
		return false;
	}

	internal static Type FvJua495mHfVyPiTYEI(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static void uJLhWU9jYBtdXNb8WXq(object object_0)
	{
		Monitor.Enter(object_0);
	}

	internal static object Sy8O3s9yDdVw8G2s64J()
	{
		return AppDomain.CurrentDomain;
	}

	internal static void oNDMbk93NCFvmSIocuy(object object_0, object object_1)
	{
		((AppDomain)object_0).ResourceResolve += (ResolveEventHandler?)object_1;
	}

	internal static void ReN2w690wdV4W9WBiYm(object object_0)
	{
		Monitor.Exit(object_0);
	}

	internal static object jDRFVG9aK9ylJusO5lH(object object_0, object object_1)
	{
		return (string?)object_0 + (string?)object_1;
	}
}
