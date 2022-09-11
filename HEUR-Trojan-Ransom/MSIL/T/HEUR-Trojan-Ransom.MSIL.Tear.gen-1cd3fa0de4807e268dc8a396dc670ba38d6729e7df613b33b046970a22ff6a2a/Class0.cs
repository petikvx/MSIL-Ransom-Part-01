using System;
using System.Collections.Generic;
using System.Management;
using System.Runtime.InteropServices;

internal static class Class0
{
	internal static ICollection<ManagementBaseObject> smethod_0(this string string_0, [Optional] string string_1)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected O, but got Unknown
		switch (0)
		{
		default:
		{
			ICollection<ManagementBaseObject> collection = new List<ManagementBaseObject>();
			try
			{
				int num = 7237;
				int num2 = num;
				num = 7237;
				switch (num2 == num)
				{
				default:
				{
					if (false)
					{
					}
					ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
					while (true)
					{
						ManagementObjectSearcher val = new ManagementObjectSearcher(string_0);
						num = 3;
						int num3 = num;
						while (true)
						{
							switch (num3)
							{
							case 4:
								val = new ManagementObjectSearcher(string_1, string_0);
								num = 1;
								num3 = num;
								continue;
							case 3:
								if (string_1 != null)
								{
									num = 4;
									num3 = num;
									continue;
								}
								goto case 1;
							case 1:
								enumerator = val.Get().GetEnumerator();
								num = 2;
								num3 = num;
								continue;
							case 2:
								try
								{
									num = 3;
									num3 = num;
									while (true)
									{
										switch (num3)
										{
										case 4:
										{
											if (!enumerator.MoveNext())
											{
												num = 1;
												num3 = num;
												continue;
											}
											ManagementBaseObject current = enumerator.get_Current();
											collection.Add(current);
											num = 2;
											num3 = num;
											continue;
										}
										default:
											num = 4;
											num3 = num;
											continue;
										case 1:
											num = 0;
											num3 = num;
											continue;
										case 0:
											break;
										}
										break;
									}
								}
								finally
								{
									num = 2;
									num3 = num;
									while (true)
									{
										switch (num3)
										{
										default:
											if (enumerator != null)
											{
												num = 0;
												num3 = num;
												continue;
											}
											break;
										case 0:
											((IDisposable)enumerator).Dispose();
											num = 1;
											num3 = num;
											continue;
										case 1:
											break;
										}
										break;
									}
								}
								num = 0;
								num3 = num;
								continue;
							case 0:
								goto end_IL_003b;
							}
							break;
						}
					}
				}
				case false:
				case true:
					break;
					end_IL_003b:
					break;
				}
				if (true)
				{
					return collection;
				}
				return collection;
			}
			catch
			{
				return collection;
			}
		}
		}
	}

	internal static string smethod_1(this ManagementBaseObject managementBaseObject_0, string string_0)
	{
		int num = 5327;
		int num2 = num;
		num = 5327;
		switch (num2 == num)
		{
		default:
			if (0 == 0)
			{
			}
			if (1 == 0)
			{
			}
			return managementBaseObject_0.smethod_2<string>(string_0);
		}
	}

	internal static T smethod_2<T>(this ManagementBaseObject managementBaseObject_0, string string_0)
	{
		while (managementBaseObject_0.get_Item(string_0) != null)
		{
			int num = 30447;
			int num2 = num;
			num = 30447;
			switch (num2 == num)
			{
			case false:
			case true:
				continue;
			}
			if (0 == 0)
			{
			}
			return (T)managementBaseObject_0.get_Item(string_0);
		}
		if (1 == 0)
		{
		}
		return default(T);
	}
}
