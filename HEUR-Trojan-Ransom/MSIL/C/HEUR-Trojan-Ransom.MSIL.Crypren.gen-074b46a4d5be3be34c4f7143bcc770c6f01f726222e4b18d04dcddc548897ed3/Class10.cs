using System;
using System.Collections;
using System.IO;
using System.Net;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Xsl;
using Microsoft.Win32;

internal class Class10
{
	public delegate void Delegate3(HttpWebRequest httpWebRequest_0, HttpWebResponse httpWebResponse_0);

	public delegate void Delegate4(Class9 class9_0);

	public delegate bool Delegate5(HttpWebRequest httpWebRequest_0);

	private bool bool_0 = (byte)Class84.smethod_0(1) != 0;

	private bool bool_1;

	private string string_0;

	private bool bool_2;

	private int int_0;

	private Uri uri_0;

	private HttpStatusCode httpStatusCode_0 = (HttpStatusCode)Class84.smethod_0(30);

	private int int_1 = Class84.smethod_0(115);

	private bool bool_3;

	private bool bool_4;

	public Delegate3 delegate3_0;

	public Delegate4 delegate4_0;

	public Delegate5 delegate5_0;

	public bool Boolean_0
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool_0 = value;
		}
	}

	public bool Boolean_1
	{
		get
		{
			return bool_1;
		}
		set
		{
			if ((value || 1 == 0) && !Delegate297.smethod_0(this) && 0 == 0)
			{
				throw Delegate298.smethod_0(Class86.smethod_0("\uf5b5\uf597\uf595\uf59e\uf593\uf5d6\uf59f\uf585\uf5d6\uf598\uf599\uf582\uf5d6\uf593\uf598\uf597\uf594\uf59a\uf593\uf592\uf5d8\uf5d6\uf5a5\uf593\uf582\uf5d6\uf5a3\uf585\uf59f\uf598\uf591\uf5b5\uf597\uf595\uf59e\uf593\uf5d6\uf582\uf599\uf5d6\uf582\uf584\uf583\uf593\uf5d6\uf590\uf59f\uf584\uf585\uf582\uf5d8", 62944));
			}
			bool_1 = value;
		}
	}

	public string String_0
	{
		get
		{
			return string_0;
		}
		set
		{
			string_0 = value;
		}
	}

	public bool Boolean_2 => bool_2;

	public int Int32_0 => int_0;

	public Uri Uri_0 => uri_0;

	public HttpStatusCode HttpStatusCode_0 => httpStatusCode_0;

	public int Int32_1
	{
		get
		{
			return int_1;
		}
		set
		{
			if (int_1 <= Class84.smethod_0(0))
			{
				throw new ArgumentException(Class86.smethod_0("\uf2e8\uf2d2\uf2c1\uf2de\uf29b\uf2d6\uf2ce\uf2c8\uf2cf\uf29b\uf2d9\uf2de\uf29b\uf2dc\uf2c9\uf2de\uf2da\uf2cf\uf2de\uf2c9\uf29b\uf2cf\uf2d3\uf2da\uf2d5\uf29b\uf2c1\uf2de\uf2c9\uf2d4\uf295", 62122));
			}
			int_1 = value;
		}
	}

	public bool Boolean_3
	{
		get
		{
			return bool_3;
		}
		set
		{
			bool_3 = value;
		}
	}

	public bool Boolean_4
	{
		get
		{
			if (string_0 == null && 0 == 0)
			{
				return (byte)Class84.smethod_0(0) != 0;
			}
			return bool_4;
		}
		set
		{
			if ((value || 1 == 0) && string_0 == null && 0 == 0)
			{
				throw Delegate298.smethod_0(Class86.smethod_0("\ue385\ue3b3\ue3a9\ue3fc\ue3b2\ue3b9\ue3b9\ue3b8\ue3fc\ue3a8\ue3b3\ue3fc\ue3b8\ue3b9\ue3ba\ue3b5\ue3b2\ue3b9\ue3fc\ue3bd\ue3fc\ue39f\ue3bd\ue3bf\ue3b4\ue3b9\ue38c\ue3bd\ue3a8\ue3b4\ue3fc\ue3ba\ue3b5\ue3ae\ue3af\ue3a8\ue3f2", 58140));
			}
			bool_4 = value;
		}
	}

	public static string smethod_0(string string_1, string string_2)
	{
		if (string.IsNullOrEmpty(string_1) || 1 == 0)
		{
			return string_2;
		}
		string result = "";
		try
		{
			RegistryKey classesRoot = Registry.ClassesRoot;
			classesRoot = classesRoot.OpenSubKey(string_1, (byte)Class84.smethod_0(0) != 0);
			if (classesRoot != null || 1 == 0)
			{
				return (string)classesRoot.GetValue("", string_2);
			}
			return result;
		}
		catch (Exception)
		{
			return string_2;
		}
	}

	public static string smethod_1(string string_1, string string_2)
	{
		if (string.IsNullOrEmpty(string_1) || 1 == 0)
		{
			return string_2;
		}
		string result = "";
		try
		{
			RegistryKey classesRoot = Registry.ClassesRoot;
			classesRoot = classesRoot.OpenSubKey(Class86.smethod_0("\ue1f6\ue1f2\ue1f6\ue1fe\ue1e7\ue1ff\ue1da\ue1cf\ue1da\ue1d9\ue1da\ue1c8\ue1de\ue1e7\ue1f8\ue1d4\ue1d5\ue1cf\ue1de\ue1d5\ue1cf\ue19b\ue1ef\ue1c2\ue1cb\ue1de\ue1e7", 57624) + string_1, (byte)Class84.smethod_0(0) != 0);
			if (classesRoot != null || 1 == 0)
			{
				return (string)classesRoot.GetValue(Class86.smethod_0("\ue3bb\ue386\ue38a\ue39b\ue390\ue38d\ue397\ue391\ue390", 58262), string_2);
			}
			return result;
		}
		catch (Exception)
		{
			return string_2;
		}
	}

	public object method_0(string string_1, Type type_0)
	{
		return Delegate299.smethod_0(this, string_1, null, null, type_0);
	}

	public object method_1(string string_1, string string_2, XsltArgumentList xsltArgumentList_0, Type type_0)
	{
		return Delegate300.smethod_0(this, string_1, string_2, xsltArgumentList_0, type_0, null);
	}

	public object method_2(string string_1, string string_2, XsltArgumentList xsltArgumentList_0, Type type_0, string string_3)
	{
		StringWriter stringWriter = new StringWriter();
		XmlTextWriter xmlTextWriter = new XmlTextWriter(stringWriter);
		if (string_2 == null && 0 == 0)
		{
			Delegate301.smethod_0(this, string_1, xmlTextWriter);
		}
		else if (string_3 == null && 0 == 0)
		{
			Delegate302.smethod_0(this, string_1, string_2, xsltArgumentList_0, xmlTextWriter);
		}
		else
		{
			Delegate303.smethod_0(this, string_1, string_2, xsltArgumentList_0, xmlTextWriter, string_3);
		}
		xmlTextWriter.Flush();
		XmlTextReader xmlReader = default(XmlTextReader);
		StringReader input = default(StringReader);
		while (true)
		{
			int num = Class84.smethod_0(8);
			int num2 = 12;
			while (true)
			{
				num2 ^= Class84.smethod_0(414);
				while (true)
				{
					int num3 = Class84.smethod_0(34);
					while (true)
					{
						switch (num3 ^ Class84.smethod_0(408))
						{
						case 104:
							break;
						case 103:
							num3 = 23;
							continue;
						case 102:
							goto IL_0067;
						default:
							goto end_IL_00dc;
						case 105:
							goto end_IL_0105;
						}
						goto IL_004d;
						IL_0067:
						switch (num2)
						{
						case 102:
							goto IL_0087;
						case 103:
							goto IL_00c8;
						case 100:
							goto IL_0110;
						case 101:
							goto end_IL_0122;
						}
						num3 = 24;
						continue;
						IL_0110:
						num2 = 15;
						goto end_IL_0105;
						IL_0087:
						switch (num)
						{
						case 115:
							break;
						case 116:
							goto IL_00af;
						case 117:
							goto IL_00c5;
						default:
							goto IL_0116;
						case 118:
						{
							XmlSerializer xmlSerializer = new XmlSerializer(type_0);
							try
							{
								return xmlSerializer.Deserialize(xmlReader);
							}
							catch (InvalidOperationException ex)
							{
								throw new Exception(string.Concat(ex, Class86.smethod_0("\ue3f0\ue3fc\ue3f1\ue3f1\ue3f1\ue3fc\ue3a4\ue3b1\ue3b0\ue3e6", 58268), stringWriter));
							}
						}
						}
						xmlReader = new XmlTextReader(input);
						num = 6;
						goto IL_00c8;
						IL_0116:
						num2 = Class84.smethod_0(399);
						goto end_IL_0105;
						IL_00c5:
						num = 5;
						goto IL_00c8;
						IL_00af:
						input = new StringReader(stringWriter.ToString());
						num = Class84.smethod_0(7);
						goto IL_00c8;
						IL_004d:
						num2 = Class84.smethod_0(42);
						num3 = Class84.smethod_0(55);
						continue;
						IL_00c8:
						num ^= Class84.smethod_0(408);
						goto IL_004d;
						continue;
						end_IL_00dc:
						break;
					}
					continue;
					end_IL_0105:
					break;
				}
				continue;
				end_IL_0122:
				break;
			}
		}
	}

	public void method_3(string string_1, string string_2)
	{
		Delegate304.smethod_0(this, string_1, string_2, Class86.smethod_0("\uef38\uef3a\uef2b", 61281));
	}

	public void method_4(string string_1, string string_2, WebProxy webProxy_0, NetworkCredential networkCredential_0)
	{
		Delegate305.smethod_0(this, string_1, string_2, webProxy_0, networkCredential_0, Class86.smethod_0("\uef38\uef3a\uef2b", 61281));
	}

	public void method_5(string string_1, string string_2, string string_3)
	{
		Uri uri = new Uri(string_1);
		if (!(uri.Scheme == Uri.UriSchemeHttps) && 0 == 0 && ((!(uri.Scheme == Uri.UriSchemeHttp)) ? true : false))
		{
			throw Delegate298.smethod_0(Class86.smethod_0("\uf722\uf719\uf704\uf702\uf707\uf707\uf718\uf705\uf703\uf712\uf713\uf757\uf702\uf705\uf71e\uf757\uf704\uf714\uf71f\uf712\uf71a\uf712\uf74d\uf757\uf750", 63331) + uri.Scheme + Class86.smethod_0("\uf7d8\uf7d1", 63295));
		}
		Delegate306.smethod_0(this, uri, string_3, string_2, null, null, null);
	}

	public void method_6(string string_1, string string_2, WebProxy webProxy_0, NetworkCredential networkCredential_0, string string_3)
	{
		Uri uri = new Uri(string_1);
		if (!(uri.Scheme == Uri.UriSchemeHttps) && 0 == 0 && ((!(uri.Scheme == Uri.UriSchemeHttp)) ? true : false))
		{
			throw Delegate298.smethod_0(Class86.smethod_0("\uf722\uf719\uf704\uf702\uf707\uf707\uf718\uf705\uf703\uf712\uf713\uf757\uf702\uf705\uf71e\uf757\uf704\uf714\uf71f\uf712\uf71a\uf712\uf74d\uf757\uf750", 63331) + uri.Scheme + Class86.smethod_0("\uf7d8\uf7d1", 63295));
		}
		Delegate306.smethod_0(this, uri, string_3, string_2, null, webProxy_0, networkCredential_0);
	}

	public string method_7(Uri uri_1)
	{
		if (uri_1 == null || 1 == 0)
		{
			throw new ArgumentNullException(Class86.smethod_0("\ue783\ue784\ue79f", 59232));
		}
		if (!Delegate297.smethod_0(this) && 0 == 0)
		{
			throw Delegate298.smethod_0(Class86.smethod_0("\uf5b5\uf597\uf595\uf59e\uf593\uf5d6\uf59f\uf585\uf5d6\uf598\uf599\uf582\uf5d6\uf593\uf598\uf597\uf594\uf59a\uf593\uf592\uf5d8\uf5d6\uf5a5\uf593\uf582\uf5d6\uf5a3\uf585\uf59f\uf598\uf591\uf5b5\uf597\uf595\uf59e\uf593\uf5d6\uf582\uf599\uf5d6\uf582\uf584\uf583\uf593\uf5d6\uf590\uf59f\uf584\uf585\uf582\uf5d8", 62944));
		}
		if (uri_1.AbsolutePath == Class86.smethod_0("\ue398", 58295) || 1 == 0)
		{
			return Path.Combine(string_0, Class86.smethod_0("\uebf2\uebb4\ueba8\uebb1", 60236));
		}
		return Path.Combine(string_0, (uri_1.Host + uri_1.AbsolutePath).Replace((char)Class84.smethod_0(127), (char)Class84.smethod_0(133)));
	}

	public Class9 method_8(string string_1)
	{
		return Delegate307.smethod_0(this, string_1, Class86.smethod_0("\uef38\uef3a\uef2b", 61281));
	}

	public Class9 method_9(string string_1, string string_2, int int_2, string string_3, string string_4)
	{
		WebProxy webProxy = new WebProxy(string_2, int_2);
		webProxy.BypassProxyOnLocal = (byte)Class84.smethod_0(1) != 0;
		NetworkCredential networkCredential = null;
		if ((string_3 != null || 1 == 0) && (string_4 != null || 1 == 0))
		{
			networkCredential = new NetworkCredential(string_3, string_4);
			CredentialCache credentialCache = default(CredentialCache);
			while (true)
			{
				int num = Class84.smethod_0(69);
				int num2 = -6;
				while (true)
				{
					num2 ^= Class84.smethod_0(93);
					while (true)
					{
						int num3 = Class84.smethod_0(396);
						while (true)
						{
							switch (num3 ^ Class84.smethod_0(408))
							{
							case 109:
								num3 = Class84.smethod_0(43);
								continue;
							case 108:
								break;
							case 107:
								goto IL_00cf;
							default:
								goto end_IL_00dc;
							case 110:
								goto end_IL_0105;
							}
							switch (num2)
							{
							case -101:
								goto IL_006d;
							case -98:
								goto IL_00c2;
							case -99:
								goto IL_011e;
							case -100:
								goto end_IL_0122;
							}
							num3 = 27;
							continue;
							IL_00c2:
							num ^= Class84.smethod_0(411);
							goto IL_00cf;
							IL_011e:
							num2 = -7;
							goto end_IL_0105;
							IL_006d:
							switch (num)
							{
							case 113:
								break;
							case 114:
								goto IL_0096;
							case 115:
								goto IL_00b7;
							default:
								goto IL_0113;
							case 116:
								goto end_IL_0130;
							}
							credentialCache = new CredentialCache();
							num = 29;
							goto IL_00c2;
							IL_0113:
							num2 = Class89.smethod_1(55);
							goto end_IL_0105;
							IL_00b7:
							num = Class84.smethod_0(396);
							goto IL_00c2;
							IL_0096:
							credentialCache.Add(webProxy.Address, Class86.smethod_0("\uf81d\uf83e\uf82c\uf836\uf83c", 63505), networkCredential);
							num = 27;
							goto IL_00c2;
							IL_00cf:
							num2 = Class89.smethod_1(57);
							num3 = 30;
							continue;
							end_IL_00dc:
							break;
						}
						continue;
						end_IL_0105:
						break;
					}
					continue;
					end_IL_0122:
					break;
				}
				continue;
				end_IL_0130:
				break;
			}
			credentialCache.Add(webProxy.Address, Class86.smethod_0("\uedbb\ued96\ued98\ued9a\ued8c\ued8b", 60926), networkCredential);
		}
		return Delegate308.smethod_0(this, string_1, Class86.smethod_0("\uef38\uef3a\uef2b", 61281), webProxy, networkCredential);
	}

	public Class9 method_10(string string_1, string string_2)
	{
		Uri uri = new Uri(string_1);
		Class9 @class;
		if (!(uri.Scheme == Uri.UriSchemeHttps) && 0 == 0 && ((!(uri.Scheme == Uri.UriSchemeHttp)) ? true : false))
		{
			if ((!(uri.Scheme == Uri.UriSchemeFile)) ? true : false)
			{
				throw Delegate298.smethod_0(Class86.smethod_0("\uf722\uf719\uf704\uf702\uf707\uf707\uf718\uf705\uf703\uf712\uf713\uf757\uf702\uf705\uf71e\uf757\uf704\uf714\uf71f\uf712\uf71a\uf712\uf74d\uf757\uf750", 63331) + uri.Scheme + Class86.smethod_0("\uf7d8\uf7d1", 63295));
			}
			@class = Delegate185.smethod_0();
			while (true)
			{
				int num = Class84.smethod_0(33);
				int num2 = Class46.Class47.smethod_0(75);
				while (true)
				{
					num2 ^= Class84.smethod_0(405);
					while (true)
					{
						int num3 = Class49.smethod_0(78);
						while (true)
						{
							switch (num3 ^ Class84.smethod_0(60))
							{
							case -105:
								break;
							case -106:
								goto IL_00ef;
							case -107:
								num3 = -31;
								continue;
							default:
								goto end_IL_0101;
							case -104:
								goto end_IL_0127;
							}
							switch (num2)
							{
							case -99:
								goto IL_0087;
							case -98:
								goto IL_00e5;
							case -100:
								goto IL_0132;
							case -101:
								goto end_IL_0139;
							}
							num3 = Class49.smethod_0(88);
							continue;
							IL_00e5:
							num ^= Class84.smethod_0(50);
							goto IL_00ef;
							IL_0132:
							num2 = -1;
							goto end_IL_0127;
							IL_0087:
							switch (num)
							{
							case 103:
								break;
							case 104:
								goto IL_00ba;
							case 105:
								goto IL_00cb;
							case 106:
								goto IL_00e2;
							default:
								goto IL_0136;
							case 107:
								goto end_IL_0148;
							}
							@class.bool_3 = (byte)Class84.smethod_0(1) != 0;
							num = 27;
							goto IL_00e5;
							IL_0136:
							num2 = -8;
							goto end_IL_0127;
							IL_00e2:
							num = 24;
							goto IL_00e5;
							IL_00cb:
							Delegate310.smethod_0(@class, string_1, bool_0);
							num = Class84.smethod_0(55);
							goto IL_00e5;
							IL_00ba:
							@class.bool_3 = (byte)Class84.smethod_0(0) != 0;
							num = 21;
							goto IL_00e5;
							IL_00ef:
							num2 = Class49.smethod_0(83);
							num3 = -20;
							continue;
							end_IL_0101:
							break;
						}
						continue;
						end_IL_0127:
						break;
					}
					continue;
					end_IL_0139:
					break;
				}
				continue;
				end_IL_0148:
				break;
			}
		}
		else
		{
			@class = Delegate309.smethod_0(this, uri, string_2, null, null);
		}
		if (delegate4_0 != null || 1 == 0)
		{
			Delegate311.smethod_0(delegate4_0, @class);
		}
		return @class;
	}

	public Class9 method_11(string string_1, string string_2, WebProxy webProxy_0, NetworkCredential networkCredential_0)
	{
		Uri uri = new Uri(string_1);
		Class9 @class;
		if (!(uri.Scheme == Uri.UriSchemeHttps) && 0 == 0 && ((!(uri.Scheme == Uri.UriSchemeHttp)) ? true : false))
		{
			if ((!(uri.Scheme == Uri.UriSchemeFile)) ? true : false)
			{
				throw Delegate298.smethod_0(Class86.smethod_0("\uf722\uf719\uf704\uf702\uf707\uf707\uf718\uf705\uf703\uf712\uf713\uf757\uf702\uf705\uf71e\uf757\uf704\uf714\uf71f\uf712\uf71a\uf712\uf74d\uf757\uf750", 63331) + uri.Scheme + Class86.smethod_0("\uf7d8\uf7d1", 63295));
			}
			@class = Delegate185.smethod_0();
			while (true)
			{
				int num = Class89.smethod_1(52);
				int num2 = Class89.smethod_1(60);
				while (true)
				{
					num2 ^= Class84.smethod_0(412);
					while (true)
					{
						int num3 = Class84.smethod_0(7);
						while (true)
						{
							switch (num3 ^ Class84.smethod_0(67))
							{
							case 107:
								break;
							case 105:
								goto IL_00ec;
							case 106:
								num3 = 2;
								continue;
							default:
								goto end_IL_00fc;
							case 108:
								goto end_IL_0122;
							}
							switch (num2)
							{
							case -106:
								goto IL_0081;
							case -105:
								goto IL_00df;
							case -107:
								goto IL_012c;
							case -108:
								goto end_IL_0134;
							}
							num3 = 1;
							continue;
							IL_00df:
							num ^= Class84.smethod_0(409);
							goto IL_00ec;
							IL_012c:
							num2 = -7;
							goto end_IL_0122;
							IL_0081:
							switch (num)
							{
							case -105:
								break;
							case -104:
								goto IL_00b4;
							case -103:
								goto IL_00ca;
							case -102:
								goto IL_00cf;
							default:
								goto IL_0131;
							case -101:
								goto end_IL_0143;
							}
							@class.bool_3 = (byte)Class84.smethod_0(1) != 0;
							num = -16;
							goto IL_00df;
							IL_0131:
							num2 = -8;
							goto end_IL_0122;
							IL_00cf:
							Delegate310.smethod_0(@class, string_1, bool_0);
							num = -15;
							goto IL_00df;
							IL_00ca:
							num = -13;
							goto IL_00df;
							IL_00b4:
							@class.bool_3 = (byte)Class84.smethod_0(0) != 0;
							num = Class46.Class47.smethod_0(75);
							goto IL_00df;
							IL_00ec:
							num2 = Class89.smethod_1(61);
							num3 = 4;
							continue;
							end_IL_00fc:
							break;
						}
						continue;
						end_IL_0122:
						break;
					}
					continue;
					end_IL_0134:
					break;
				}
				continue;
				end_IL_0143:
				break;
			}
		}
		else
		{
			@class = Delegate309.smethod_0(this, uri, string_2, webProxy_0, networkCredential_0);
		}
		if (delegate4_0 != null || 1 == 0)
		{
			Delegate311.smethod_0(delegate4_0, @class);
		}
		return @class;
	}

	public void method_12(string string_1, XmlTextWriter xmlTextWriter_0)
	{
		Class9 object_ = Delegate312.smethod_0(this, string_1);
		Delegate313.smethod_0(object_, xmlTextWriter_0);
	}

	public void method_13(string string_1, string string_2, XsltArgumentList xsltArgumentList_0, XmlTextWriter xmlTextWriter_0)
	{
		Delegate303.smethod_0(this, string_1, string_2, xsltArgumentList_0, xmlTextWriter_0, null);
	}

	public void method_14(string string_1, string string_2, XsltArgumentList xsltArgumentList_0, XmlTextWriter xmlTextWriter_0, string string_3)
	{
		if (string_1 == null && 0 == 0)
		{
			throw new ArgumentNullException(Class86.smethod_0("\ue886\ue89a\ue883\ue882\ue8bb\ue89c\ue882", 59586));
		}
		Class9 @class = Delegate312.smethod_0(this, string_1);
		if (string_3 != null || 1 == 0)
		{
			XmlTextWriter xmlTextWriter = new XmlTextWriter(string_3, Delegate314.smethod_0(@class));
			Delegate313.smethod_0(@class, xmlTextWriter);
			xmlTextWriter.Close();
		}
		if (xsltArgumentList_0 == null && 0 == 0)
		{
			xsltArgumentList_0 = new XsltArgumentList();
		}
		xsltArgumentList_0.AddParam(Class86.smethod_0("\uec83\uec84\uec9a", 60464), "", string_1);
		XslCompiledTransform xslCompiledTransform = default(XslCompiledTransform);
		while (true)
		{
			int num = Class89.smethod_1(66);
			int num2 = Class84.smethod_0(7);
			while (true)
			{
				num2 ^= Class84.smethod_0(414);
				while (true)
				{
					int num3 = Class49.smethod_0(94);
					while (true)
					{
						switch (num3 ^ Class84.smethod_0(408))
						{
						case -104:
							num3 = -24;
							continue;
						case -105:
							break;
						case -106:
							goto IL_0098;
						default:
							goto end_IL_0179;
						case -103:
							goto end_IL_01a2;
						}
						goto IL_0086;
						IL_0098:
						switch (num2)
						{
						case 103:
							goto IL_00c0;
						case 104:
							goto IL_0167;
						case 101:
							goto IL_01ad;
						case 102:
							goto end_IL_01b7;
						}
						num3 = Class49.smethod_0(69);
						continue;
						IL_01ad:
						num2 = 14;
						goto end_IL_01a2;
						IL_00c0:
						switch (num)
						{
						case -103:
							break;
						case -102:
							goto IL_00f6;
						case -101:
							goto IL_0105;
						case -100:
							goto IL_0110;
						case -99:
							goto IL_0115;
						case -98:
							goto IL_013f;
						default:
							goto IL_01b3;
						case -97:
							return;
						}
						xslCompiledTransform.Load(string_2);
						num = -13;
						goto IL_0167;
						IL_01b3:
						num2 = 13;
						goto end_IL_01a2;
						IL_013f:
						xsltArgumentList_0.AddParam(Class86.smethod_0("\uf59d\uf589\uf594\uf596\uf5b8\uf59a\uf598\uf593\uf59e", 62970), "", Delegate316.smethod_0(this));
						num = -14;
						goto IL_0167;
						IL_0115:
						xsltArgumentList_0.AddParam(Class86.smethod_0("\uf28d\uf29a\uf28e\uf28a\uf29a\uf28c\uf28b\uf2bb\uf28a\uf28d\uf29e\uf28b\uf296\uf290\uf291", 62143), "", Delegate315.smethod_0(this));
						num = -9;
						goto IL_0167;
						IL_0110:
						num = -11;
						goto IL_0167;
						IL_0105:
						xslCompiledTransform = new XslCompiledTransform();
						num = -16;
						goto IL_0167;
						IL_00f6:
						xslCompiledTransform.Transform(@class, xsltArgumentList_0, xmlTextWriter_0);
						num = -10;
						goto IL_0167;
						IL_0086:
						num2 = Class84.smethod_0(31);
						num3 = -23;
						continue;
						IL_0167:
						num ^= Class84.smethod_0(410);
						goto IL_0086;
						continue;
						end_IL_0179:
						break;
					}
					continue;
					end_IL_01a2:
					break;
				}
				continue;
				end_IL_01b7:
				break;
			}
		}
	}

	private static void smethod_2(string string_1)
	{
		FileAttributes attributes = default(FileAttributes);
		if (File.Exists(string_1) || 1 == 0)
		{
			while (true)
			{
				int num = Class46.Class47.smethod_0(76);
				int num2 = -9;
				while (true)
				{
					switch (num2 ^ Class84.smethod_0(412))
					{
					case -101:
						num ^= Class84.smethod_0(48);
						goto default;
					default:
						num2 = Class89.smethod_1(66);
						continue;
					case -103:
						num2 = -11;
						continue;
					case -104:
						switch (num)
						{
						default:
							num2 = -10;
							continue;
						case -111:
							num = Class89.smethod_1(66);
							break;
						case -110:
							File.SetAttributes(string_1, (FileAttributes)((int)attributes & Class84.smethod_0(134)));
							num = -15;
							break;
						case -109:
							attributes = File.GetAttributes(string_1);
							num = -9;
							break;
						case -108:
							return;
						}
						goto case -101;
					case -102:
						break;
					}
					break;
				}
			}
		}
		string directoryName = Path.GetDirectoryName(string_1);
		if (!Directory.Exists(directoryName) && 0 == 0)
		{
			Directory.CreateDirectory(directoryName);
		}
	}

	private static DateTime smethod_3(DateTime dateTime_0)
	{
		return new DateTime(dateTime_0.Year, dateTime_0.Month, dateTime_0.Day, dateTime_0.Hour, dateTime_0.Minute, dateTime_0.Second, Class84.smethod_0(0));
	}

	private static long smethod_4(Stream stream_0, string string_1, DateTime dateTime_0, int int_2)
	{
		Delegate317.smethod_0(string_1);
		BinaryWriter binaryWriter = default(BinaryWriter);
		BinaryReader binaryReader = default(BinaryReader);
		FileStream fileStream = default(FileStream);
		while (true)
		{
			int num = Class84.smethod_0(1);
			while (true)
			{
				switch (num ^ Class84.smethod_0(410))
				{
				case 107:
					num = 2;
					continue;
				case 106:
					binaryWriter = null;
					num = Class84.smethod_0(9);
					continue;
				case 105:
					binaryReader = null;
					num = 3;
					continue;
				case 104:
					fileStream = new FileStream(string_1, (FileMode)Class84.smethod_0(6), (FileAccess)Class84.smethod_0(6));
					num = 0;
					continue;
				case 108:
				{
					long num2 = Class84.smethod_0(0);
					try
					{
						binaryReader = new BinaryReader(stream_0);
						binaryWriter = new BinaryWriter(fileStream);
						while (true)
						{
							IL_0138:
							byte[] array = binaryReader.ReadBytes(int_2);
							while (true)
							{
								int num3 = Class84.smethod_0(6);
								int num4 = Class49.smethod_0(83);
								while (true)
								{
									switch (num4 ^ Class84.smethod_0(48))
									{
									case -101:
										break;
									default:
										goto IL_0095;
									case -103:
										num4 = -4;
										continue;
									case -104:
										goto IL_00a6;
									case -102:
										goto end_IL_00e9;
									}
									goto IL_0089;
									IL_00a6:
									switch (num3)
									{
									case 109:
										goto IL_00c5;
									case 110:
										goto IL_00d7;
									case 111:
										goto IL_00dc;
									case 112:
										goto IL_0124;
									}
									num4 = -1;
									continue;
									IL_0124:
									binaryWriter.Write(array);
									goto IL_012c;
									IL_00dc:
									num2 += array.Length;
									num3 = 0;
									goto IL_0089;
									IL_00d7:
									num3 = 3;
									goto IL_0089;
									IL_00c5:
									if (array.Length > Class84.smethod_0(0))
									{
										num3 = 29;
										goto IL_0089;
									}
									goto IL_012c;
									IL_0095:
									num4 = Class46.Class47.smethod_0(75);
									continue;
									IL_012c:
									if (array.Length <= Class84.smethod_0(0))
									{
										goto end_IL_0111;
									}
									goto IL_0138;
									IL_0089:
									num3 ^= Class84.smethod_0(51);
									goto IL_0095;
									continue;
									end_IL_00e9:
									break;
								}
								continue;
								end_IL_0111:
								break;
							}
							break;
						}
					}
					finally
					{
						if (binaryReader != null || 1 == 0)
						{
							binaryReader.Close();
						}
						if (binaryWriter != null || 1 == 0)
						{
							binaryWriter.Flush();
							binaryWriter.Close();
						}
						if (fileStream != null || 1 == 0)
						{
							fileStream.Close();
						}
					}
					File.SetLastWriteTime(string_1, dateTime_0);
					return num2;
				}
				}
				break;
			}
		}
	}

	private HttpStatusCode method_15(Uri uri_1, string string_1, string string_2, Class9 class9_0, IWebProxy iwebProxy_0, ICredentials icredentials_0)
	{
		string text = null;
		bool flag = (byte)Class84.smethod_0(0) != 0;
		HttpWebRequest httpWebRequest = WebRequest.Create(uri_1) as HttpWebRequest;
		httpWebRequest.Method = string_1;
		if (iwebProxy_0 != null || 1 == 0)
		{
			if (icredentials_0 != null || 1 == 0)
			{
				iwebProxy_0.Credentials = icredentials_0;
				httpWebRequest.Credentials = icredentials_0;
			}
			else
			{
				iwebProxy_0.Credentials = CredentialCache.DefaultCredentials;
				httpWebRequest.Credentials = CredentialCache.DefaultCredentials;
			}
			httpWebRequest.Proxy = iwebProxy_0;
		}
		bool_2 = (byte)Class84.smethod_0(0) != 0;
		int tickCount = default(int);
		bool flag2 = default(bool);
		while (true)
		{
			int num = Class49.smethod_0(78);
			int num2 = Class46.Class47.smethod_0(75);
			while (true)
			{
				switch (num2 ^ Class84.smethod_0(67))
				{
				case -107:
					num ^= Class84.smethod_0(59);
					goto default;
				default:
					num2 = Class89.smethod_1(60);
					continue;
				case -109:
				{
					HttpWebResponse httpWebResponse;
					switch (num)
					{
					default:
						num2 = -4;
						continue;
					case -113:
						tickCount = Environment.TickCount;
						num = -32;
						break;
					case -112:
						num = Class89.smethod_2(93);
						break;
					case -111:
						if (Delegate297.smethod_0(this))
						{
							num = -30;
							break;
						}
						if (1 == 0)
						{
							goto case -109;
						}
						goto IL_015c;
					case -110:
						int_0 = Class84.smethod_0(0);
						num = -2;
						break;
					case -109:
						{
							text = Delegate318.smethod_0(this, httpWebRequest.RequestUri);
							if (File.Exists(text) || 1 == 0)
							{
								httpWebRequest.IfModifiedSince = File.GetLastAccessTime(text);
								flag = (byte)Class84.smethod_0(1) != 0;
							}
							goto IL_015c;
						}
						IL_015c:
						if (bool_1 || 1 == 0)
						{
							if (!File.Exists(text) && 0 == 0)
							{
								throw Delegate298.smethod_0(Class86.smethod_0("\uf4fd\uf4d2\uf4d7\uf4de\uf49b\uf4cc\uf4da\uf4c8\uf49b\uf4d5\uf4d4\uf4cf\uf49b\uf4dd\uf4d4\uf4ce\uf4d5\uf4df\uf49b\uf4da\uf4cf\uf49b\uf4d8\uf4da\uf4d8\uf4d3\uf4de\uf49b\uf4cb\uf4da\uf4cf\uf4d3\uf481\uf49b\uf49c", 62472) + text + Class86.smethod_0("\ue4da", 58484));
							}
							if (string_2 != null || 1 == 0)
							{
								Delegate319.smethod_0(text, string_2);
								File.SetLastWriteTime(string_2, File.GetLastWriteTime(text));
							}
							bool_2 = (byte)Class84.smethod_0(1) != 0;
							return (HttpStatusCode)Class84.smethod_0(135);
						}
						if (bool_3 || 1 == 0)
						{
							httpWebRequest.CookieContainer = new CookieContainer();
						}
						if ((delegate5_0 != null || 1 == 0) && !Delegate320.smethod_0(delegate5_0, httpWebRequest) && 0 == 0)
						{
							return (HttpStatusCode)Class84.smethod_0(73);
						}
						try
						{
							httpWebResponse = httpWebRequest.GetResponse() as HttpWebResponse;
						}
						catch (WebException ex)
						{
							int_0 = Environment.TickCount - tickCount;
							httpWebResponse = (HttpWebResponse)ex.Response;
							if (httpWebResponse == null && 0 == 0)
							{
								if (flag || 1 == 0)
								{
									if (string_2 != null || 1 == 0)
									{
										Delegate319.smethod_0(text, string_2);
										File.SetLastWriteTime(string_2, File.GetLastWriteTime(text));
									}
									return (HttpStatusCode)Class84.smethod_0(135);
								}
								throw;
							}
						}
						catch (Exception)
						{
							int_0 = Environment.TickCount - tickCount;
							throw;
						}
						if (delegate3_0 != null || 1 == 0)
						{
							Delegate321.smethod_0(delegate3_0, httpWebRequest, httpWebResponse);
						}
						int_0 = Environment.TickCount - tickCount;
						while (true)
						{
							int num3 = Class84.smethod_0(399);
							while (true)
							{
								Encoding encoding;
								Stream responseStream;
								switch (num3 ^ Class84.smethod_0(48))
								{
								case 108:
									if (httpWebResponse.ContentEncoding != null)
									{
										num3 = 8;
										continue;
									}
									if (1 == 0)
									{
										goto case 109;
									}
									goto IL_0364;
								case 107:
									uri_0 = httpWebResponse.ResponseUri;
									num3 = Class84.smethod_0(31);
									continue;
								case 106:
									num3 = 15;
									continue;
								case 105:
									flag2 = Delegate322.smethod_0(this, httpWebResponse.ContentType);
									num3 = 9;
									continue;
								case 109:
									{
										if (httpWebResponse.ContentEncoding.Length <= Class84.smethod_0(0))
										{
											goto IL_0364;
										}
										encoding = Encoding.GetEncoding(httpWebResponse.ContentEncoding);
										goto IL_0367;
									}
									IL_0367:
									if (httpWebResponse.StatusCode == (HttpStatusCode)Class84.smethod_0(135))
									{
										if (Delegate297.smethod_0(this) || 1 == 0)
										{
											bool_2 = (byte)Class84.smethod_0(1) != 0;
											if (string_2 != null || 1 == 0)
											{
												Delegate319.smethod_0(text, string_2);
												File.SetLastWriteTime(string_2, File.GetLastWriteTime(text));
											}
											return httpWebResponse.StatusCode;
										}
										throw Delegate298.smethod_0(Class86.smethod_0("\uf36c\uf35a\uf34d\uf349\uf35a\uf34d\uf31f\uf357\uf35e\uf34c\uf31f\uf34c\uf35a\uf351\uf35b\uf31f\uf35e\uf31f\uf371\uf350\uf34b\uf372\uf350\uf35b\uf356\uf359\uf35a\uf35b\uf31f\uf35c\uf350\uf35b\uf35a\uf313\uf31f\uf348\uf356\uf34b\uf357\uf350\uf34a\uf34b\uf31f\uf35c\uf35e\uf35c\uf357\uf35a\uf31f\uf35a\uf351\uf35e\uf35d\uf353\uf35a\uf35b\uf311", 62238));
									}
									responseStream = httpWebResponse.GetResponseStream();
									if (responseStream != null || 1 == 0)
									{
										if (Delegate297.smethod_0(this) || 1 == 0)
										{
											Delegate324.smethod_0(responseStream, text, Delegate323.smethod_0(httpWebResponse.LastModified), int_1);
											Delegate325.smethod_0(this, httpWebRequest.RequestUri, httpWebResponse);
											if (string_2 != null || 1 == 0)
											{
												Delegate319.smethod_0(text, string_2);
												File.SetLastWriteTime(string_2, File.GetLastWriteTime(text));
											}
										}
										else if ((class9_0 != null || 1 == 0) && (flag2 || 1 == 0))
										{
											if (encoding != null || 1 == 0)
											{
												Delegate191.smethod_0(class9_0, responseStream, encoding);
											}
											else
											{
												Delegate190.smethod_0(class9_0, responseStream, (byte)Class84.smethod_0(1) != 0);
											}
										}
										httpWebResponse.Close();
									}
									return httpWebResponse.StatusCode;
									IL_0364:
									encoding = null;
									goto IL_0367;
								}
								break;
							}
						}
					}
					goto case -107;
				}
				case -110:
					num2 = -6;
					continue;
				case -108:
					break;
				}
				break;
			}
		}
	}

	private string method_16(Uri uri_1, string string_1, string string_2)
	{
		XmlDocument xmlDocument = new XmlDocument();
		XmlNode xmlNode = default(XmlNode);
		while (true)
		{
			int num = Class84.smethod_0(58);
			while (true)
			{
				switch (num ^ Class84.smethod_0(412))
				{
				case 119:
					xmlNode = xmlDocument.SelectSingleNode(Class86.smethod_0("\uead1\uead1\uea96\ueaa5\uea8a\uea8c\uea9f\uea90\uea8d\uea92\uea9f\uea8a\uea9b\uead6\ueabe\uea90\uead2\ueade\uead9\uea9f\uea9c\uea9d\uea9a\uea9b\uea98\uea99\uea96\uea97\uea94\uea95\uea92\uea93\uea90\uea91\uea8e\uea8f\uea8c\uea8d\uea8a\uea8b\uea88\uea89\uea86\uea87\uea84\uead9\uead2\uead9\ueabf\ueabc\ueabd\ueaba\ueabb\ueab8\ueab9\ueab6\ueab7\ueab4\ueab5\ueab2\ueab3\ueab0\ueab1\ueaae\ueaaf\ueaac\ueaad\ueaaa\ueaab\ueaa8\ueaa9\ueaa6\ueaa7\ueaa4\uead9\uead7\ueac3\uead9", 60038) + string_1.ToUpper() + Class86.smethod_0("\uf1d0\uf1aa", 61815));
					num = 26;
					continue;
				case 118:
					if (xmlNode != null)
					{
						num = 20;
						continue;
					}
					if (0 == 0)
					{
						return string_2;
					}
					goto case 120;
				case 117:
					num = Class84.smethod_0(55);
					continue;
				case 116:
					xmlDocument.Load(Delegate326.smethod_0(this, uri_1));
					num = 27;
					continue;
				case 120:
					return xmlNode.Attributes![string_1]!.Value;
				}
				break;
			}
		}
	}

	private string method_17(Uri uri_1)
	{
		return Delegate318.smethod_0(this, uri_1) + Class86.smethod_0("\uebf9\uebbf\uebf9\uebaf\uebba\uebbb", 60231);
	}

	private bool method_18(string string_1)
	{
		string text = Delegate327.smethod_0(Path.GetExtension(string_1), null);
		return Delegate322.smethod_0(this, text);
	}

	private bool method_19(string string_1)
	{
		return string_1.ToLower().StartsWith(Class86.smethod_0("\uf389\uf398\uf385\uf389\uf3d2\uf395\uf389\uf390\uf391", 62317));
	}

	private Class9 method_20(Uri uri_1, string string_1, WebProxy webProxy_0, NetworkCredential networkCredential_0)
	{
		Class9 @class = Delegate185.smethod_0();
		while (true)
		{
			int num = Class84.smethod_0(69);
			while (true)
			{
				switch (num ^ Class84.smethod_0(50))
				{
				case 112:
					@class.bool_7 = (byte)Class84.smethod_0(1) != 0;
					num = 31;
					continue;
				case 111:
					if (httpStatusCode_0 == (HttpStatusCode)Class84.smethod_0(135))
					{
						num = 3;
						continue;
					}
					goto IL_00a4;
				case 110:
					num = 28;
					continue;
				case 109:
					httpStatusCode_0 = Delegate306.smethod_0(this, uri_1, string_1, null, @class, webProxy_0, networkCredential_0);
					num = Class84.smethod_0(43);
					continue;
				case 108:
					@class.bool_3 = (byte)Class84.smethod_0(0) != 0;
					num = 2;
					continue;
				case 113:
					{
						Delegate328.smethod_0(@class, Delegate318.smethod_0(this, uri_1));
						goto IL_00a4;
					}
					IL_00a4:
					return @class;
				}
				break;
			}
		}
	}

	private void method_21(Uri uri_1, HttpWebResponse httpWebResponse_0)
	{
		string filename = Delegate326.smethod_0(this, uri_1);
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(Class86.smethod_0("\uf2c2\uf29d\uf2c0\uf2c2\uf2d1\uf29d\uf2c0", 62034));
		XmlNode firstChild = xmlDocument.FirstChild;
		IEnumerator enumerator = httpWebResponse_0.Headers.GetEnumerator();
		try
		{
			XmlNode xmlNode = default(XmlNode);
			XmlAttribute xmlAttribute = default(XmlAttribute);
			while (enumerator.MoveNext() ? true : false)
			{
				string text = (string)enumerator.Current;
				while (true)
				{
					int num = Class46.Class47.smethod_0(82);
					int num2 = 11;
					while (true)
					{
						switch (num2 ^ Class84.smethod_0(412))
						{
						case 103:
							num ^= Class84.smethod_0(404);
							goto default;
						default:
							num2 = Class84.smethod_0(80);
							continue;
						case 102:
							switch (num)
							{
							default:
								num2 = 8;
								continue;
							case -116:
								xmlNode.Attributes!.Append(xmlAttribute);
								num = -13;
								break;
							case -115:
								xmlAttribute.Value = text;
								num = -9;
								break;
							case -114:
								num = Class49.smethod_0(81);
								break;
							case -113:
								xmlNode = xmlDocument.CreateElement(Class86.smethod_0("\uec94", 60652));
								num = -10;
								break;
							case -112:
								xmlNode.Attributes!.Append(xmlAttribute);
								num = -12;
								break;
							case -111:
								xmlAttribute = xmlDocument.CreateAttribute(Class86.smethod_0("\uf6d5", 63003));
								num = -22;
								break;
							case -110:
								xmlAttribute.Value = httpWebResponse_0.Headers[text];
								num = -21;
								break;
							case -109:
								xmlAttribute = xmlDocument.CreateAttribute(Class86.smethod_0("\uf58d", 62842));
								num = -11;
								break;
							case -108:
								goto end_IL_019f;
							}
							goto case 103;
						case 101:
							num2 = 9;
							continue;
						case 100:
							break;
						}
						break;
					}
					continue;
					end_IL_019f:
					break;
				}
				firstChild.AppendChild(xmlNode);
			}
		}
		finally
		{
			IDisposable disposable = enumerator as IDisposable;
			if (disposable != null || 1 == 0)
			{
				disposable.Dispose();
			}
		}
		xmlDocument.Save(filename);
	}
}
