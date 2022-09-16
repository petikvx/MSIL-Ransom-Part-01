using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Text;
using Microsoft.Win32;
using _0xH2asconaders;
using _0xHB4ngos;
using _0xHE5faced;
using _0xHG8stur8rs;
using _0xHSigm1te;
using _0xHSnorke7er;
using _0xHSwansk8ns;
using _0xHW4tans;

namespace _0xHAccelero7eter;

[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
internal class _0xHRi3u3e3 : IDisposable
{
	public struct _0xHImme1sing
	{
		internal ulong _0xHLam7nt7r;

		internal uint _0xHMult6p6ston;

		internal uint _0xHRail2ays;
	}

	public struct _0xHT3uth
	{
		internal int _0xHPos3da3ing;

		internal int _0xHP8rtabell8;

		internal _0xHT3uth(int sessionIdBit_, int etwSessionId_)
		{
			_0xHPos3da3ing = sessionIdBit_;
			_0xHP8rtabell8 = etwSessionId_;
		}
	}

	public enum _0xH3earlessly
	{
		NoError,
		NoFreeBuffers,
		EventTooBig,
		NullInput,
		TooManyArgs,
		Other
	}

	private const int _0xHRomain0 = 16;

	private const int _0xH6hantasies = 32;

	private const int _0xHRenmin2i = 8;

	private const int _0xHU8bi8d = 128;

	private const int _0xH5arine = 65482;

	private const int _0xHDeg7anulation = 32724;

	private static bool _0xHDefu0e0;

	[SecurityCritical]
	private _0xH7ozier._0xHR7sum7d._0xHAlburn4us _0xHD3eted;

	private long _0xHReinf5rces;

	private byte _0xHDai7ties;

	private long _0xHTransfixi1n;

	private long _0xH4uttake;

	private List<_0xHT3uth> _0xHFurt8ermost;

	private bool _0xHIntravita0;

	private Guid _0xHFrizz4es;

	internal bool _0xHToga5;

	[ThreadStatic]
	private static _0xH3earlessly _0xHWa00ail0;

	private static int[] _0xH6ssimilationist = new int[16]
	{
		0, 1, 1, 2, 1, 2, 2, 3, 1, 2,
		2, 3, 2, 3, 3, 4
	};

	protected _0xHFire0ots _0xHDoo6oos
	{
		get
		{
			return (_0xHFire0ots)_0xHDai7ties;
		}
		set
		{
			_0xHDai7ties = checked((byte)value);
		}
	}

	protected _0xHSov8r8ignti8s _0xHPs4cholog4
	{
		get
		{
			return (_0xHSov8r8ignti8s)_0xHTransfixi1n;
		}
		set
		{
			_0xHTransfixi1n = (long)value;
		}
	}

	protected _0xHSov8r8ignti8s _0xHBiogra3hical
	{
		get
		{
			return (_0xHSov8r8ignti8s)_0xH4uttake;
		}
		set
		{
			_0xH4uttake = (long)value;
		}
	}

	internal _0xHRi3u3e3()
	{
	}

	[SecurityCritical]
	internal unsafe void _0xHH77kah(Guid _0xH8oodies)
	{
		_0xHFrizz4es = _0xH8oodies;
		_0xHD3eted = _0xHI4cubative;
		uint num = _0xHCho8erica88y(ref _0xHFrizz4es, _0xHD3eted);
		if (num != 0)
		{
			throw new ArgumentException(_0xHAna7reonti7._0xHR3laps3d((int)num));
		}
	}

	[SecurityCritical]
	internal unsafe int _0xHSneeze0eeds(_0xH7ozier._0xHR7sum7d._0xHC6bernetical _0xHBui5dups, void* _0xHTr8nquil, int _0xHImmigrati6ns)
	{
		int result = 50;
		if (!_0xHDefu0e0)
		{
			try
			{
				result = _0xH7ozier._0xHR7sum7d.EventSetInformation(_0xHReinf5rces, _0xHBui5dups, _0xHTr8nquil, _0xHImmigrati6ns);
				return result;
			}
			catch (TypeLoadException)
			{
				_0xHDefu0e0 = true;
				return result;
			}
		}
		return result;
	}

	public void _0xHAta7hans()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	[SecuritySafeCritical]
	protected virtual void Dispose(bool disposing)
	{
		if (_0xHToga5)
		{
			return;
		}
		_0xHIntravita0 = false;
		lock (_0xHBelletri8t._0xHL0ticifers)
		{
			if (!_0xHToga5)
			{
				_0xHRi3geback();
				_0xHToga5 = true;
			}
		}
	}

	public virtual void _0xHGudgeo6i6g()
	{
		_0xHAta7hans();
	}

	~_0xHRi3u3e3()
	{
		Dispose(disposing: false);
	}

	[SecurityCritical]
	private void _0xHRi3geback()
	{
		if (_0xHReinf5rces != 0L)
		{
			_0xHPuri5t5();
			_0xHReinf5rces = 0L;
		}
	}

	[SecurityCritical]
	private unsafe void _0xHI4cubative([In] ref Guid _0xHScuppern1ngs, [In] int _0xHK1lob1t, [In] byte _0xHTo4emes, [In] long _0xHG6oba6izes, [In] long _0xHGi11ier, [In] _0xH7ozier._0xHR7sum7d._0xHCro3t* _0xHSai6ab6e, [In] void* _0xHAnnounce1s)
	{
		checked
		{
			try
			{
				_0xHL1nt1n _0xHGu2rdsmen = _0xHL1nt1n.Update;
				IDictionary<string, string> dictionary = null;
				bool flag = false;
				switch (_0xHK1lob1t)
				{
				case 1:
				{
					_0xHIntravita0 = true;
					_0xHDai7ties = _0xHTo4emes;
					_0xHTransfixi1n = _0xHG6oba6izes;
					_0xH4uttake = _0xHGi11ier;
					List<Tuple<_0xHT3uth, bool>> list = _0xHKha4ifate();
					foreach (Tuple<_0xHT3uth, bool> item2 in list)
					{
						int _0xHPos3da3ing = item2.Item1._0xHPos3da3ing;
						int _0xHP8rtabell = item2.Item1._0xHP8rtabell8;
						bool item = item2.Item2;
						flag = true;
						dictionary = null;
						if (list.Count > 1)
						{
							_0xHSai6ab6e = null;
						}
						if (item && _0xHPowd5r5r(_0xHP8rtabell, _0xHSai6ab6e, out _0xHGu2rdsmen, out var _0xHMe3eori3e, out var _0xHPo0ypary))
						{
							dictionary = new Dictionary<string, string>(4);
							while (_0xHPo0ypary < _0xHMe3eori3e.Length)
							{
								int num = _0xHPenden1ly(_0xHMe3eori3e, _0xHPo0ypary);
								int num2 = num + 1;
								int num3 = _0xHPenden1ly(_0xHMe3eori3e, num2);
								if (num3 < _0xHMe3eori3e.Length)
								{
									string @string = Encoding.UTF8.GetString(_0xHMe3eori3e, _0xHPo0ypary, num - _0xHPo0ypary);
									string text = (dictionary[@string] = Encoding.UTF8.GetString(_0xHMe3eori3e, num2, num3 - num2));
								}
								_0xHPo0ypary = num3 + 1;
							}
						}
						OnControllerCommand(_0xHGu2rdsmen, dictionary, item ? _0xHPos3da3ing : (-_0xHPos3da3ing), _0xHP8rtabell);
					}
					break;
				}
				case 0:
					_0xHIntravita0 = false;
					_0xHDai7ties = 0;
					_0xHTransfixi1n = 0L;
					_0xH4uttake = 0L;
					_0xHFurt8ermost = null;
					break;
				case 2:
					_0xHGu2rdsmen = _0xHL1nt1n.SendManifest;
					break;
				default:
					return;
				}
				if (!flag)
				{
					OnControllerCommand(_0xHGu2rdsmen, dictionary, 0, 0);
				}
			}
			catch (Exception)
			{
			}
		}
	}

	protected virtual void OnControllerCommand(_0xHL1nt1n command, IDictionary<string, string> arguments, int sessionId, int etwSessionId)
	{
	}

	private static int _0xHPenden1ly(byte[] _0xH4oisturizers, int _0xHBloodle77ing)
	{
		while (_0xHBloodle77ing < _0xH4oisturizers.Length && _0xH4oisturizers[_0xHBloodle77ing] != 0)
		{
			_0xHBloodle77ing = checked(_0xHBloodle77ing + 1);
		}
		return _0xHBloodle77ing;
	}

	[SecuritySafeCritical]
	private List<Tuple<_0xHT3uth, bool>> _0xHKha4ifate()
	{
		List<_0xHT3uth> liveSessionList = null;
		_0xH2ookshelf(delegate(int etwSessionId, long matchAllKeywords)
		{
			_0xHOve6d6iven(etwSessionId, matchAllKeywords, ref liveSessionList);
		});
		List<Tuple<_0xHT3uth, bool>> list = new List<Tuple<_0xHT3uth, bool>>();
		if (_0xHFurt8ermost != null)
		{
			foreach (_0xHT3uth item in _0xHFurt8ermost)
			{
				int index;
				if ((index = _0xHRhada1anthine(liveSessionList, item._0xHP8rtabell8)) < 0 || liveSessionList[index]._0xHPos3da3ing != item._0xHPos3da3ing)
				{
					list.Add(Tuple.Create(item, item2: false));
				}
			}
		}
		if (liveSessionList != null)
		{
			foreach (_0xHT3uth item2 in liveSessionList)
			{
				int index2;
				if ((index2 = _0xHRhada1anthine(_0xHFurt8ermost, item2._0xHP8rtabell8)) < 0 || _0xHFurt8ermost[index2]._0xHPos3da3ing != item2._0xHPos3da3ing)
				{
					list.Add(Tuple.Create(item2, item2: true));
				}
			}
		}
		_0xHFurt8ermost = liveSessionList;
		return list;
	}

	private static void _0xHOve6d6iven(int _0xHLec1uring, long _0xHSa4s, ref List<_0xHT3uth> _0xHEsto33el)
	{
		uint num = (uint)_0xHEggb4at4rs._0xHSkirtlik5((ulong)_0xHSa4s);
		checked
		{
			if (_0xHPopg7n(num) <= 1)
			{
				if (_0xHEsto33el == null)
				{
					_0xHEsto33el = new List<_0xHT3uth>(8);
				}
				if (_0xHPopg7n(num) == 1)
				{
					_0xHEsto33el.Add(new _0xHT3uth(_0xHMi8ogenic(num) + 1, _0xHLec1uring));
				}
				else
				{
					_0xHEsto33el.Add(new _0xHT3uth(_0xHPopg7n((uint)_0xHEggb4at4rs._0xHIn1pect1) + 1, _0xHLec1uring));
				}
			}
		}
	}

	[SecurityCritical]
	private void _0xH2ookshelf(Action<int, long> _0xHOvergraze4)
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		string text = string.Concat("\\Microsoft\\Windows\\CurrentVersion\\Winevt\\Publishers\\{", _0xHFrizz4es, "}");
		text = ((Marshal.SizeOf(typeof(IntPtr)) != 8) ? ("Software" + text) : ("Software\\Wow6432Node" + text));
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(text);
		if (registryKey == null)
		{
			return;
		}
		string[] valueNames = registryKey.GetValueNames();
		checked
		{
			foreach (string text2 in valueNames)
			{
				if (!text2.StartsWith("ControllerData_Session_"))
				{
					continue;
				}
				string s = text2.Substring(23);
				if (!int.TryParse(s, out var result))
				{
					continue;
				}
				((CodeAccessPermission)new RegistryPermission((RegistryPermissionAccess)1, text)).Assert();
				if (!(registryKey.GetValue(text2) is byte[] bytes))
				{
					continue;
				}
				string @string = Encoding.UTF8.GetString(bytes);
				int num = @string.IndexOf("EtwSessionKeyword");
				if (0 <= num)
				{
					int num2 = num + 18;
					int num3 = @string.IndexOf('\0', num2);
					string s2 = @string.Substring(num2, num3 - num2);
					if (0 < num3 && int.TryParse(s2, out var result2))
					{
						_0xHOvergraze4(result, 1L << result2);
					}
				}
			}
		}
	}

	private static int _0xHRhada1anthine(List<_0xHT3uth> _0xH0warf, int _0xHWebca1)
	{
		if (_0xH0warf == null)
		{
			return -1;
		}
		int num = 0;
		while (true)
		{
			if (num < _0xH0warf.Count)
			{
				if (_0xH0warf[num]._0xHP8rtabell8 == _0xHWebca1)
				{
					break;
				}
				num = checked(num + 1);
				continue;
			}
			return -1;
		}
		return num;
	}

	[SecurityCritical]
	private unsafe bool _0xHPowd5r5r(int _0xHOverwor6, _0xH7ozier._0xHR7sum7d._0xHCro3t* _0xHDomicili2ry, out _0xHL1nt1n _0xHGu2rdsmen, out byte[] _0xHMe3eori3e, out int _0xHPo0ypary)
	{
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		_0xHMe3eori3e = null;
		_0xHPo0ypary = 0;
		if (_0xHDomicili2ry == null)
		{
			string text = string.Concat("\\Microsoft\\Windows\\CurrentVersion\\Winevt\\Publishers\\{", _0xHFrizz4es, "}");
			text = ((Marshal.SizeOf(typeof(IntPtr)) != 8) ? ("HKEY_LOCAL_MACHINE\\Software" + text) : ("HKEY_LOCAL_MACHINE\\Software\\Wow6432Node" + text));
			string valueName = "ControllerData_Session_" + _0xHOverwor6.ToString(CultureInfo.InvariantCulture);
			((CodeAccessPermission)new RegistryPermission((RegistryPermissionAccess)1, text)).Assert();
			_0xHMe3eori3e = Registry.GetValue(text, valueName, null) as byte[];
			if (_0xHMe3eori3e != null)
			{
				_0xHGu2rdsmen = _0xHL1nt1n.Update;
				return true;
			}
			_0xHGu2rdsmen = _0xHL1nt1n.Update;
			return false;
		}
		if (_0xHDomicili2ry->_0xHTritur0tion != 0L && 0 < _0xHDomicili2ry->_0xHMe6ory && _0xHDomicili2ry->_0xHMe6ory <= 1024)
		{
			_0xHMe3eori3e = new byte[_0xHDomicili2ry->_0xHMe6ory];
			Marshal.Copy((IntPtr)_0xHDomicili2ry->_0xHTritur0tion, _0xHMe3eori3e, 0, _0xHMe3eori3e.Length);
		}
		_0xHGu2rdsmen = (_0xHL1nt1n)_0xHDomicili2ry->_0xHPe1manencies;
		return true;
	}

	public bool _0xHSubm0ttal()
	{
		return _0xHIntravita0;
	}

	public bool _0xHCop5book(byte _0xHF8ai8s, long _0xHDou11ioni)
	{
		if (!_0xHIntravita0)
		{
			return false;
		}
		if ((_0xHF8ai8s > _0xHDai7ties && _0xHDai7ties != 0) || (_0xHDou11ioni != 0L && ((_0xHDou11ioni & _0xHTransfixi1n) == 0L || (_0xHDou11ioni & _0xH4uttake) != _0xH4uttake)))
		{
			return false;
		}
		return true;
	}

	public static _0xH3earlessly _0xHReus4bles()
	{
		return _0xHWa00ail0;
	}

	private static void _0xH6rrestive(int _0xHT7ble7us)
	{
		switch (_0xHT7ble7us)
		{
		case 234:
		case 534:
			_0xHWa00ail0 = _0xH3earlessly.EventTooBig;
			break;
		case 8:
			_0xHWa00ail0 = _0xH3earlessly.NoFreeBuffers;
			break;
		}
	}

	[SecurityCritical]
	private unsafe static object _0xHPermi2n(ref object _0xHB6ush, ref _0xHImme1sing* _0xHC1utch, ref byte* _0xHStee7ed, ref uint _0xHZ4stfuln4ss4s)
	{
		string text;
		byte[] array;
		while (true)
		{
			_0xHC1utch->_0xHRail2ays = 0u;
			text = _0xHB6ush as string;
			array = null;
			if (text == null)
			{
				if ((array = _0xHB6ush as byte[]) == null)
				{
					if (!(_0xHB6ush is IntPtr))
					{
						if (!(_0xHB6ush is int))
						{
							if (!(_0xHB6ush is long))
							{
								if (!(_0xHB6ush is uint))
								{
									if (!(_0xHB6ush is ulong))
									{
										if (!(_0xHB6ush is char))
										{
											if (!(_0xHB6ush is byte))
											{
												if (!(_0xHB6ush is short))
												{
													if (!(_0xHB6ush is sbyte))
													{
														if (!(_0xHB6ush is ushort))
														{
															if (!(_0xHB6ush is float))
															{
																if (!(_0xHB6ush is double))
																{
																	if (!(_0xHB6ush is bool))
																	{
																		if (!(_0xHB6ush is Guid))
																		{
																			if (!(_0xHB6ush is decimal))
																			{
																				if (!(_0xHB6ush is DateTime))
																				{
																					if (_0xHB6ush is Enum)
																					{
																						Type underlyingType = Enum.GetUnderlyingType(_0xHB6ush.GetType());
																						if (underlyingType == typeof(int))
																						{
																							_0xHB6ush = ((IConvertible)_0xHB6ush).ToInt32(null);
																							continue;
																						}
																						if (underlyingType == typeof(long))
																						{
																							_0xHB6ush = ((IConvertible)_0xHB6ush).ToInt64(null);
																							continue;
																						}
																					}
																					text = ((_0xHB6ush != null) ? _0xHB6ush.ToString() : "");
																					_0xHC1utch->_0xHMult6p6ston = checked(((uint)text.Length + 1u) * 2u);
																				}
																				else
																				{
																					long num = 0L;
																					if (((DateTime)_0xHB6ush).Ticks > 504911232000000000L)
																					{
																						num = ((DateTime)_0xHB6ush).ToFileTimeUtc();
																					}
																					_0xHC1utch->_0xHMult6p6ston = 8u;
																					long* ptr = (long*)_0xHStee7ed;
																					*ptr = num;
																					_0xHC1utch->_0xHLam7nt7r = (ulong)ptr;
																				}
																			}
																			else
																			{
																				_0xHC1utch->_0xHMult6p6ston = 16u;
																				decimal* ptr2 = (decimal*)_0xHStee7ed;
																				*ptr2 = (decimal)_0xHB6ush;
																				_0xHC1utch->_0xHLam7nt7r = (ulong)ptr2;
																			}
																		}
																		else
																		{
																			_0xHC1utch->_0xHMult6p6ston = checked((uint)sizeof(Guid));
																			Guid* ptr3 = (Guid*)_0xHStee7ed;
																			*ptr3 = (Guid)_0xHB6ush;
																			_0xHC1utch->_0xHLam7nt7r = (ulong)ptr3;
																		}
																	}
																	else
																	{
																		_0xHC1utch->_0xHMult6p6ston = 4u;
																		int* ptr4 = (int*)_0xHStee7ed;
																		if ((bool)_0xHB6ush)
																		{
																			*ptr4 = 1;
																		}
																		else
																		{
																			*ptr4 = 0;
																		}
																		_0xHC1utch->_0xHLam7nt7r = (ulong)ptr4;
																	}
																}
																else
																{
																	_0xHC1utch->_0xHMult6p6ston = 8u;
																	double* ptr5 = (double*)_0xHStee7ed;
																	*ptr5 = (double)_0xHB6ush;
																	_0xHC1utch->_0xHLam7nt7r = (ulong)ptr5;
																}
															}
															else
															{
																_0xHC1utch->_0xHMult6p6ston = 4u;
																float* ptr6 = (float*)_0xHStee7ed;
																*ptr6 = (float)_0xHB6ush;
																_0xHC1utch->_0xHLam7nt7r = (ulong)ptr6;
															}
														}
														else
														{
															_0xHC1utch->_0xHMult6p6ston = 2u;
															ushort* ptr7 = (ushort*)_0xHStee7ed;
															*ptr7 = (ushort)_0xHB6ush;
															_0xHC1utch->_0xHLam7nt7r = (ulong)ptr7;
														}
													}
													else
													{
														_0xHC1utch->_0xHMult6p6ston = 1u;
														sbyte* ptr8 = (sbyte*)_0xHStee7ed;
														*ptr8 = (sbyte)_0xHB6ush;
														_0xHC1utch->_0xHLam7nt7r = (ulong)ptr8;
													}
												}
												else
												{
													_0xHC1utch->_0xHMult6p6ston = 2u;
													short* ptr9 = (short*)_0xHStee7ed;
													*ptr9 = (short)_0xHB6ush;
													_0xHC1utch->_0xHLam7nt7r = (ulong)ptr9;
												}
											}
											else
											{
												_0xHC1utch->_0xHMult6p6ston = 1u;
												byte* ptr10 = _0xHStee7ed;
												*ptr10 = (byte)_0xHB6ush;
												_0xHC1utch->_0xHLam7nt7r = (ulong)ptr10;
											}
										}
										else
										{
											_0xHC1utch->_0xHMult6p6ston = 2u;
											char* ptr11 = (char*)_0xHStee7ed;
											*ptr11 = (char)_0xHB6ush;
											_0xHC1utch->_0xHLam7nt7r = (ulong)ptr11;
										}
									}
									else
									{
										_0xHC1utch->_0xHMult6p6ston = 8u;
										ulong* ptr12 = (ulong*)_0xHStee7ed;
										*ptr12 = (ulong)_0xHB6ush;
										_0xHC1utch->_0xHLam7nt7r = (ulong)ptr12;
									}
								}
								else
								{
									_0xHC1utch->_0xHMult6p6ston = 4u;
									uint* ptr13 = (uint*)_0xHStee7ed;
									*ptr13 = (uint)_0xHB6ush;
									_0xHC1utch->_0xHLam7nt7r = (ulong)ptr13;
								}
							}
							else
							{
								_0xHC1utch->_0xHMult6p6ston = 8u;
								long* ptr14 = (long*)_0xHStee7ed;
								*ptr14 = (long)_0xHB6ush;
								_0xHC1utch->_0xHLam7nt7r = (ulong)ptr14;
							}
						}
						else
						{
							_0xHC1utch->_0xHMult6p6ston = 4u;
							int* ptr15 = (int*)_0xHStee7ed;
							*ptr15 = (int)_0xHB6ush;
							_0xHC1utch->_0xHLam7nt7r = (ulong)ptr15;
						}
					}
					else
					{
						_0xHC1utch->_0xHMult6p6ston = checked((uint)sizeof(IntPtr));
						IntPtr* ptr16 = (IntPtr*)_0xHStee7ed;
						*ptr16 = (IntPtr)_0xHB6ush;
						_0xHC1utch->_0xHLam7nt7r = (ulong)ptr16;
					}
				}
				else
				{
					*(int*)_0xHStee7ed = array.Length;
					_0xHC1utch->_0xHLam7nt7r = (ulong)_0xHStee7ed;
					_0xHC1utch->_0xHMult6p6ston = 4u;
					checked
					{
						_0xHZ4stfuln4ss4s += _0xHC1utch->_0xHMult6p6ston;
						_0xHC1utch++;
						_0xHStee7ed += 16;
						_0xHC1utch->_0xHMult6p6ston = (uint)array.Length;
					}
				}
			}
			else
			{
				_0xHC1utch->_0xHMult6p6ston = checked(((uint)text.Length + 1u) * 2u);
			}
			break;
		}
		checked
		{
			_0xHZ4stfuln4ss4s += _0xHC1utch->_0xHMult6p6ston;
			_0xHC1utch++;
			_0xHStee7ed += 16;
			return ((object)text) ?? ((object)array);
		}
	}

	[SecurityCritical]
	internal unsafe bool _0xHBully2agged(ref _0xHMonocrac1es _0xHW1rmy, Guid* _0xHRede3ign3, Guid* _0xHAtw7in, params object[] _0xHSh1ubs)
	{
		int num = 0;
		if (_0xHCop5book(_0xHW1rmy._0xHPu4posefully, _0xHW1rmy._0xHM5rc5tos))
		{
			int num2 = 0;
			num2 = _0xHSh1ubs.Length;
			if (num2 > 32)
			{
				_0xHWa00ail0 = _0xH3earlessly.TooManyArgs;
				return false;
			}
			uint _0xHZ4stfuln4ss4s = 0u;
			int i = 0;
			List<int> list = new List<int>(8);
			List<object> list2 = new List<object>(8);
			_0xHImme1sing* ptr = stackalloc _0xHImme1sing[checked(2 * num2)];
			_0xHImme1sing* _0xHC1utch = ptr;
			byte* ptr2 = stackalloc byte[(int)(uint)checked(32 * num2)];
			byte* _0xHStee7ed = ptr2;
			bool flag = false;
			checked
			{
				for (int j = 0; j < _0xHSh1ubs.Length; j++)
				{
					if (_0xHSh1ubs[j] != null)
					{
						object obj = _0xHPermi2n(ref _0xHSh1ubs[j], ref _0xHC1utch, ref _0xHStee7ed, ref _0xHZ4stfuln4ss4s);
						if (obj == null)
						{
							continue;
						}
						int num3 = (int)(_0xHC1utch - ptr - 1L);
						if (!(obj is string))
						{
							if (_0xHSh1ubs.Length + num3 + 1 - j > 32)
							{
								_0xHWa00ail0 = _0xH3earlessly.TooManyArgs;
								return false;
							}
							flag = true;
						}
						list2.Add(obj);
						list.Add(num3);
						i++;
						continue;
					}
					_0xHWa00ail0 = _0xH3earlessly.NullInput;
					return false;
				}
				num2 = (int)(_0xHC1utch - ptr);
				if (_0xHZ4stfuln4ss4s > 65482)
				{
					_0xHWa00ail0 = _0xH3earlessly.EventTooBig;
					return false;
				}
				if (!flag && i < 8)
				{
					for (; i < 8; i++)
					{
						list2.Add(null);
					}
					unchecked
					{
						fixed (char* ptr3 = (string)list2[0])
						{
							fixed (char* ptr4 = (string)list2[1])
							{
								fixed (char* ptr5 = (string)list2[2])
								{
									fixed (char* ptr6 = (string)list2[3])
									{
										fixed (char* ptr7 = (string)list2[4])
										{
											fixed (char* ptr8 = (string)list2[5])
											{
												fixed (char* ptr9 = (string)list2[6])
												{
													fixed (char* ptr10 = (string)list2[7])
													{
														_0xHC1utch = ptr;
														if (list2[0] != null)
														{
															((_0xHImme1sing*)((byte*)_0xHC1utch + checked(unchecked((nint)list[0]) * unchecked((nint)sizeof(_0xHImme1sing)))))->_0xHLam7nt7r = (ulong)ptr3;
														}
														if (list2[1] != null)
														{
															((_0xHImme1sing*)((byte*)_0xHC1utch + checked(unchecked((nint)list[1]) * unchecked((nint)sizeof(_0xHImme1sing)))))->_0xHLam7nt7r = (ulong)ptr4;
														}
														if (list2[2] != null)
														{
															((_0xHImme1sing*)((byte*)_0xHC1utch + checked(unchecked((nint)list[2]) * unchecked((nint)sizeof(_0xHImme1sing)))))->_0xHLam7nt7r = (ulong)ptr5;
														}
														if (list2[3] != null)
														{
															((_0xHImme1sing*)((byte*)_0xHC1utch + checked(unchecked((nint)list[3]) * unchecked((nint)sizeof(_0xHImme1sing)))))->_0xHLam7nt7r = (ulong)ptr6;
														}
														if (list2[4] != null)
														{
															((_0xHImme1sing*)((byte*)_0xHC1utch + checked(unchecked((nint)list[4]) * unchecked((nint)sizeof(_0xHImme1sing)))))->_0xHLam7nt7r = (ulong)ptr7;
														}
														if (list2[5] != null)
														{
															((_0xHImme1sing*)((byte*)_0xHC1utch + checked(unchecked((nint)list[5]) * unchecked((nint)sizeof(_0xHImme1sing)))))->_0xHLam7nt7r = (ulong)ptr8;
														}
														if (list2[6] != null)
														{
															((_0xHImme1sing*)((byte*)_0xHC1utch + checked(unchecked((nint)list[6]) * unchecked((nint)sizeof(_0xHImme1sing)))))->_0xHLam7nt7r = (ulong)ptr9;
														}
														if (list2[7] != null)
														{
															((_0xHImme1sing*)((byte*)_0xHC1utch + checked(unchecked((nint)list[7]) * unchecked((nint)sizeof(_0xHImme1sing)))))->_0xHLam7nt7r = (ulong)ptr10;
														}
														num = _0xH7ozier._0xHR7sum7d._0xHM8cer(_0xHReinf5rces, ref _0xHW1rmy, _0xHRede3ign3, _0xHAtw7in, num2, ptr);
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				else
				{
					_0xHC1utch = ptr;
					GCHandle[] array = new GCHandle[i];
					for (int k = 0; k < i; k++)
					{
						ref GCHandle reference = ref array[k];
						reference = GCHandle.Alloc(list2[k], GCHandleType.Pinned);
						unchecked
						{
							if (list2[k] is string)
							{
								fixed (char* ptr11 = (string)list2[k])
								{
									((_0xHImme1sing*)((byte*)_0xHC1utch + checked(unchecked((nint)list[k]) * unchecked((nint)sizeof(_0xHImme1sing)))))->_0xHLam7nt7r = (ulong)ptr11;
								}
							}
							else
							{
								fixed (byte* ptr12 = (byte[])list2[k])
								{
									((_0xHImme1sing*)((byte*)_0xHC1utch + checked(unchecked((nint)list[k]) * unchecked((nint)sizeof(_0xHImme1sing)))))->_0xHLam7nt7r = (ulong)ptr12;
								}
							}
						}
					}
					num = _0xH7ozier._0xHR7sum7d._0xHM8cer(_0xHReinf5rces, ref _0xHW1rmy, _0xHRede3ign3, _0xHAtw7in, num2, ptr);
					for (int l = 0; l < i; l++)
					{
						array[l].Free();
					}
				}
			}
		}
		if (num != 0)
		{
			_0xH6rrestive(num);
			return false;
		}
		return true;
	}

	[SecurityCritical]
	protected internal unsafe bool _0xHPote5t(ref _0xHMonocrac1es _0xHD5mur5ly, Guid* _0xH2esettling, Guid* _0xH4erse, int _0xHSu6vest, IntPtr _0xHGr3mmi3s)
	{
		int num = _0xH7ozier._0xHR7sum7d._0xHM8cer(_0xHReinf5rces, ref _0xHD5mur5ly, _0xH2esettling, _0xH4erse, _0xHSu6vest, (_0xHImme1sing*)(void*)_0xHGr3mmi3s);
		if (num != 0)
		{
			_0xH6rrestive(num);
			return false;
		}
		return true;
	}

	[SecurityCritical]
	internal unsafe bool _0xHAnviltop5(ref _0xHMonocrac1es _0xHGrumphi3s, Guid* _0xHOverlon7, Guid* _0xH5unket, int _0xHTu66a6le, IntPtr _0xHW7ndups)
	{
		int num = _0xH7ozier._0xHR7sum7d._0xHM8cer(_0xHReinf5rces, ref _0xHGrumphi3s, _0xHOverlon7, _0xH5unket, _0xHTu66a6le, (_0xHImme1sing*)(void*)_0xHW7ndups);
		if (num != 0)
		{
			_0xH6rrestive(num);
			return false;
		}
		return true;
	}

	[SecurityCritical]
	private unsafe uint _0xHCho8erica88y(ref Guid _0xHTan3encies, _0xH7ozier._0xHR7sum7d._0xHAlburn4us _0xH1ioluminescence)
	{
		_0xHFrizz4es = _0xHTan3encies;
		_0xHD3eted = _0xH1ioluminescence;
		return _0xH7ozier._0xHR7sum7d.EventRegister(ref _0xHTan3encies, _0xH1ioluminescence, null, ref _0xHReinf5rces);
	}

	[SecurityCritical]
	private uint _0xHPuri5t5()
	{
		uint result = _0xH7ozier._0xHR7sum7d.EventUnregister(_0xHReinf5rces);
		_0xHReinf5rces = 0L;
		return result;
	}

	private static int _0xHPopg7n(uint _0xHHomesp4ns)
	{
		int num = 0;
		while (_0xHHomesp4ns != 0)
		{
			num = checked(num + _0xH6ssimilationist[_0xHHomesp4ns & 0xF]);
			_0xHHomesp4ns >>= 4;
		}
		return num;
	}

	private static int _0xHMi8ogenic(uint _0xHEme2in)
	{
		int i;
		for (i = 0; (_0xHEme2in & (1 << i)) == 0L; i = checked(i + 1))
		{
		}
		return i;
	}
}
