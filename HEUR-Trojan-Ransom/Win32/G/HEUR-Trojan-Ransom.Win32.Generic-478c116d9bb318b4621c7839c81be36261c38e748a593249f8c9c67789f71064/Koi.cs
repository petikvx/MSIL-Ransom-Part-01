using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.ServiceProcess;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Loki.IO.Algorithms.Zip.FileInfo;
using Loki.IO.Disks.Cleanup;
using Loki.IO.Monitors.Implementation;
using Loki.IO.Printers.Implementations;
using Loki.Messaging.Messages;
using Loki.Networking.Ethernet;
using Loki.Packaging.Managers;
using Loki.Packaging.Packages;
using Loki.Utilities.Implementation;
using ZZZZZZZZZZZZB;
using ZZZZZZZZZZZZH;
using ZZZZZZZZZZZZO;
using ZZZZZZZZZZZZV;
using ZZZZZZZZZZZZZA;
using ZZZZZZZZZZZZZD;
using ZZZZZZZZZZZZZK;
using ZZZZZZZZZZZZZQ;
using ZZZZZZZZZZZZZW;
using ZZZZZZZZZZZZZZB;
using ZZZZZZZZZZZZZZD;
using ZZZZZZZZZZZZZZJ;
using ZZZZZZZZZZZZZZL;
using ZZZZZZZZZZZZZZN;
using ZZZZZZZZZZZZZZP;
using ZZZZZZZZZZZZZZU;
using ZZZZZZZZZZZZZZW;
using ZZZZZZZZZZZZZZY;
using ZZZZZZZZZZZZZZZB;
using ZZZZZZZZZZZZZZZD;
using ZZZZZZZZZZZZZZZF;
using ZZZZZZZZZZZZZZZH;
using ZZZZZZZZZZZZZZZJ;
using ZZZZZZZZZZZZZZZL;
using ZZZZZZZZZZZZZZZN;
using ZZZZZZZZZZZZZZZP;
using ZZZZZZZZZZZZZZZR;
using ZZZZZZZZZZZZZZZV;
using ZZZZZZZZZZZZZZZX;
using ZZZZZZZZZZZZZZZZ;
using ZZZZZZZZZZZZZZZZC;
using ZZZZZZZZZZZZZZZZE;
using ZZZZZZZZZZZZZZZZG;
using ZZZZZZZZZZZZZZZZI;
using ZZZZZZZZZZZZZZZZK;
using ZZZZZZZZZZZZZZZZN;
using ZZZZZZZZZZZZZZZZP;
using ZZZZZZZZZZZZZZZZR;
using ZZZZZZZZZZZZZZZZT;
using ZZZZZZZZZZZZZZZZV;
using ZZZZZZZZZZZZZZZZX;
using ZZZZZZZZZZZZZZZZZ;
using ZZZZZZZZZZZZZZZZZC;
using ZZZZZZZZZZZZZZZZZE;
using ZZZZZZZZZZZZZZZZZG;
using ZZZZZZZZZZZZZZZZZI;
using ZZZZZZZZZZZZZZZZZL;
using ZZZZZZZZZZZZZZZZZN;
using ZZZZZZZZZZZZZZZZZQ;
using ZZZZZZZZZZZZZZZZZS;
using ZZZZZZZZZZZZZZZZZU;
using ZZZZZZZZZZZZZZZZZW;
using ZZZZZZZZZZZZZZZZZZ;
using ZZZZZZZZZZZZZZZZZZE;
using ZZZZZZZZZZZZZZZZZZG;
using ZZZZZZZZZZZZZZZZZZN;
using ZZZZZZZZZZZZZZZZZZP;
using ZZZZZZZZZZZZZZZZZZR;
using ZZZZZZZZZZZZZZZZZZT;
using ZZZZZZZZZZZZZZZZZZV;
using ZZZZZZZZZZZZZZZZZZX;
using ZZZZZZZZZZZZZZZZZZZ;
using ZZZZZZZZZZZZZZZZZZZA;
using ZZZZZZZZZZZZZZZZZZZC;
using ZZZZZZZZZZZZZZZZZZZE;
using ZZZZZZZZZZZZZZZZZZZG;
using ZZZZZZZZZZZZZZZZZZZI;
using ZZZZZZZZZZZZZZZZZZZK;
using ZZZZZZZZZZZZZZZZZZZM;
using ZZZZZZZZZZZZZZZZZZZO;
using ZZZZZZZZZZZZZZZZZZZQ;
using ZZZZZZZZZZZZZZZZZZZS;
using ZZZZZZZZZZZZZZZZZZZU;
using ZZZZZZZZZZZZZZZZZZZW;
using ZZZZZZZZZZZZZZZZZZZY;
using ZZZZZZZZZZZZZZZZZZZZB;
using ZZZZZZZZZZZZZZZZZZZZD;
using ZZZZZZZZZZZZZZZZZZZZI;
using ZZZZZZZZZZZZZZZZZZZZK;
using ZZZZZZZZZZZZZZZZZZZZO;
using ZZZZZZZZZZZZZZZZZZZZQ;
using ZZZZZZZZZZZZZZZZZZZZS;
using ZZZZZZZZZZZZZZZZZZZZU;
using ZZZZZZZZZZZZZZZZZZZZW;
using ZZZZZZZZZZZZZZZZZZZZY;
using ZZZZZZZZZZZZZZZZZZZZZC;
using ZZZZZZZZZZZZZZZZZZZZZE;
using ZZZZZZZZZZZZZZZZZZZZZG;
using ZZZZZZZZZZZZZZZZZZZZZN;
using ZZZZZZZZZZZZZZZZZZZZZP;
using ZZZZZZZZZZZZZZZZZZZZZU;
using ZZZZZZZZZZZZZZZZZZZZZW;
using ZZZZZZZZZZZZZZZZZZZZZY;
using ZZZZZZZZZZZZZZZZZZZZZZa;
using ZZZZZZZZZZZZZZZZZZZZZZc;
using ZZZZZZZZZZZZZZZZZZZZZZe;
using ZZZZZZZZZZZZZZZZZZZZZZg;
using ZZZZZZZZZZZZZZZZZZZZZa;
using ZZZZZZZZZZZZZZZZZZZZZc;
using ZZZZZZZZZZZZZZZZZZZZZe;
using ZZZZZZZZZZZZZZZZZZZZZg;
using ZZZZZZZZZZZZZZZZZZZZZi;
using ZZZZZZZZZZZZZZZZZZZZZk;
using ZZZZZZZZZZZZZZZZZZZZZm;
using ZZZZZZZZZZZZZZZZZZZZZo;
using ZZZZZZZZZZZZZZZZZZZZZq;
using ZZZZZZZZZZZZZZZZZZZZZs;
using ZZZZZZZZZZZZZZZZZZZZZu;
using ZZZZZZZZZZZZZZZZZZZZZw;
using ZZZZZZZZZZZZZZZZZZZZZy;
using ZZZZZZZZZZZZZZZZZZZZa;
using ZZZZZZZZZZZZZZZZZZZZd;
using ZZZZZZZZZZZZZZZZZZZZg;
using ZZZZZZZZZZZZZZZZZZZZi;
using ZZZZZZZZZZZZZZZZZZZZk;
using ZZZZZZZZZZZZZZZZZZZZm;
using ZZZZZZZZZZZZZZZZZZZZo;
using ZZZZZZZZZZZZZZZZZZZZq;
using ZZZZZZZZZZZZZZZZZZZZs;
using ZZZZZZZZZZZZZZZZZZZZu;
using ZZZZZZZZZZZZZZZZZZZZx;
using ZZZZZZZZZZZZZZZZZZZb;
using ZZZZZZZZZZZZZZZZZZZd;
using ZZZZZZZZZZZZZZZZZZZg;
using ZZZZZZZZZZZZZZZZZZZj;
using ZZZZZZZZZZZZZZZZZZZm;
using ZZZZZZZZZZZZZZZZZZZo;
using ZZZZZZZZZZZZZZZZZZZq;
using ZZZZZZZZZZZZZZZZZZZs;
using ZZZZZZZZZZZZZZZZZZZu;
using ZZZZZZZZZZZZZZZZZZZw;
using ZZZZZZZZZZZZZZZZZZZy;
using ZZZZZZZZZZZZZZZZZZb;
using ZZZZZZZZZZZZZZZZZZd;
using ZZZZZZZZZZZZZZZZZZf;
using ZZZZZZZZZZZZZZZZZZi;
using ZZZZZZZZZZZZZZZZZZk;
using ZZZZZZZZZZZZZZZZZZm;
using ZZZZZZZZZZZZZZZZZZq;
using ZZZZZZZZZZZZZZZZZZs;
using ZZZZZZZZZZZZZZZZZZu;
using ZZZZZZZZZZZZZZZZZZw;
using ZZZZZZZZZZZZZZZZZZz;
using ZZZZZZZZZZZZZZZZZb;
using ZZZZZZZZZZZZZZZZZe;
using ZZZZZZZZZZZZZZZZZg;
using ZZZZZZZZZZZZZZZZZi;
using ZZZZZZZZZZZZZZZZZk;
using ZZZZZZZZZZZZZZZZZm;
using ZZZZZZZZZZZZZZZZZq;
using ZZZZZZZZZZZZZZZZZs;
using ZZZZZZZZZZZZZZZZZv;
using ZZZZZZZZZZZZZZZZZx;
using ZZZZZZZZZZZZZZZZZz;
using ZZZZZZZZZZZZZZZZb;
using ZZZZZZZZZZZZZZZZd;
using ZZZZZZZZZZZZZZZZf;
using ZZZZZZZZZZZZZZZZi;
using ZZZZZZZZZZZZZZZZk;
using ZZZZZZZZZZZZZZZZm;
using ZZZZZZZZZZZZZZZZo;
using ZZZZZZZZZZZZZZZZq;
using ZZZZZZZZZZZZZZZZt;
using ZZZZZZZZZZZZZZZZv;
using ZZZZZZZZZZZZZZZZx;
using ZZZZZZZZZZZZZZZZz;
using ZZZZZZZZZZZZZZZc;
using ZZZZZZZZZZZZZZZf;
using ZZZZZZZZZZZZZZZh;
using ZZZZZZZZZZZZZZZj;
using ZZZZZZZZZZZZZZZl;
using ZZZZZZZZZZZZZZZn;
using ZZZZZZZZZZZZZZZp;
using ZZZZZZZZZZZZZZZr;
using ZZZZZZZZZZZZZZZt;
using ZZZZZZZZZZZZZZZv;
using ZZZZZZZZZZZZZZZx;
using ZZZZZZZZZZZZZZZz;
using ZZZZZZZZZZZZZZc;
using ZZZZZZZZZZZZZZe;
using ZZZZZZZZZZZZZZg;
using ZZZZZZZZZZZZZZq;
using ZZZZZZZZZZZZZZt;
using ZZZZZZZZZZZZZZv;
using ZZZZZZZZZZZZZZx;
using ZZZZZZZZZZZZZZz;
using ZZZZZZZZZZZZZb;
using ZZZZZZZZZZZZZp;
using ZZZZZZZZZZZZZw;
using ZZZZZZZZZZZZZy;
using ZZZZZZZZZZZZv;

internal class Koi
{
	internal struct ZZZZZZZZZZZZZZZZZZZZZZi
	{
		internal uint ZZZZZZZZZZZZZZZZZZZZZZl;

		internal extern void ZZZZZZZZZZZZZZZZZZZZZZj();

		internal extern uint ZZZZZZZZZZZZZZZZZZZZZZk(ZZZZZZZZZZZZZZZZZZZZZZt zzzzzzzzzzzzzzzzzzzzzzt_0);
	}

	internal struct ZZZZZZZZZZZZZZZZZZZZZZm
	{
		internal readonly ZZZZZZZZZZZZZZZZZZZZZZi[] ZZZZZZZZZZZZZZZZZZZZZZr;

		internal readonly int ZZZZZZZZZZZZZZZZZZZZZZs;

		internal extern ZZZZZZZZZZZZZZZZZZZZZZm(int int_0);

		internal extern void ZZZZZZZZZZZZZZZZZZZZZZn();

		internal extern uint ZZZZZZZZZZZZZZZZZZZZZZo(ZZZZZZZZZZZZZZZZZZZZZZt zzzzzzzzzzzzzzzzzzzzzzt_0);

		internal extern uint ZZZZZZZZZZZZZZZZZZZZZZp(ZZZZZZZZZZZZZZZZZZZZZZt zzzzzzzzzzzzzzzzzzzzzzt_0);

		internal static extern uint ZZZZZZZZZZZZZZZZZZZZZZq(ZZZZZZZZZZZZZZZZZZZZZZi[] zzzzzzzzzzzzzzzzzzzzzzi_0, uint uint_0, ZZZZZZZZZZZZZZZZZZZZZZt zzzzzzzzzzzzzzzzzzzzzzt_0, int int_0);
	}

	internal class ZZZZZZZZZZZZZZZZZZZZZZt
	{
		internal uint ZZZZZZZZZZZZZZZZZZZZZZy;

		internal uint ZZZZZZZZZZZZZZZZZZZZZZz;

		internal Stream ZZZZZZZZZZZZZZZZZZZZZZA;

		internal extern void ZZZZZZZZZZZZZZZZZZZZZZu(Stream stream_0);

		internal extern void ZZZZZZZZZZZZZZZZZZZZZZv();

		internal extern void ZZZZZZZZZZZZZZZZZZZZZZw();

		internal extern uint ZZZZZZZZZZZZZZZZZZZZZZx(int int_0);

		internal extern ZZZZZZZZZZZZZZZZZZZZZZt();
	}

	internal class ZZZZZZZZZZZZZZZZZZZZZZB
	{
		internal class ZZZZZZZZZZZZZZZZZZZZZZC
		{
			internal readonly ZZZZZZZZZZZZZZZZZZZZZZm[] ZZZZZZZZZZZZZZZZZZZZZZG;

			internal readonly ZZZZZZZZZZZZZZZZZZZZZZm[] ZZZZZZZZZZZZZZZZZZZZZZH;

			internal ZZZZZZZZZZZZZZZZZZZZZZi ZZZZZZZZZZZZZZZZZZZZZZI;

			internal ZZZZZZZZZZZZZZZZZZZZZZi ZZZZZZZZZZZZZZZZZZZZZZJ;

			internal ZZZZZZZZZZZZZZZZZZZZZZm ZZZZZZZZZZZZZZZZZZZZZZK;

			internal uint ZZZZZZZZZZZZZZZZZZZZZZL;

			internal extern void ZZZZZZZZZZZZZZZZZZZZZZD(uint uint_0);

			internal extern void ZZZZZZZZZZZZZZZZZZZZZZE();

			internal extern uint ZZZZZZZZZZZZZZZZZZZZZZF(ZZZZZZZZZZZZZZZZZZZZZZt zzzzzzzzzzzzzzzzzzzzzzt_0, uint uint_0);

			internal extern ZZZZZZZZZZZZZZZZZZZZZZC();
		}

		internal class ZZZZZZZZZZZZZZZZZZZZZZM
		{
			internal struct ZZZZZZZZZZZZZZZZZZZZZZN
			{
				internal ZZZZZZZZZZZZZZZZZZZZZZi[] ZZZZZZZZZZZZZZZZZZZZZZS;

				internal unsafe void ZZZZZZZZZZZZZZZZZZZZZZO()
				{
					//Discarded unreachable code: IL_000e, IL_0013, IL_0017
					//IL_0003: Invalid comparison between Unknown and Ref
					while (System.Runtime.CompilerServices.Unsafe.IsAddressLessThan(ref *(byte*)/*Error near IL_0008: Stack underflow*/, ref System.Runtime.CompilerServices.Unsafe.As<ZZZZZZZZZZZZZZZZZZZZZZN, byte>(ref this)))
					{
					}
					/*Error near IL_0008: Invalid metadata token*/;
				}

				internal extern void ZZZZZZZZZZZZZZZZZZZZZZP();

				internal extern byte ZZZZZZZZZZZZZZZZZZZZZZQ(ZZZZZZZZZZZZZZZZZZZZZZt zzzzzzzzzzzzzzzzzzzzzzt_0);

				internal extern byte ZZZZZZZZZZZZZZZZZZZZZZR(ZZZZZZZZZZZZZZZZZZZZZZt zzzzzzzzzzzzzzzzzzzzzzt_0, byte byte_0);
			}

			internal ZZZZZZZZZZZZZZZZZZZZZZN[] ZZZZZZZZZZZZZZZZZZZZZZY;

			internal int ZZZZZZZZZZZZZZZZZZZZZZZ;

			internal int ZZZZZZZZZZZZZZZZZZZZZZZa;

			internal uint ZZZZZZZZZZZZZZZZZZZZZZZb;

			internal extern void ZZZZZZZZZZZZZZZZZZZZZZT(int int_0, int int_1);

			internal extern void ZZZZZZZZZZZZZZZZZZZZZZU();

			internal extern uint ZZZZZZZZZZZZZZZZZZZZZZV(uint uint_0, byte byte_0);

			internal extern byte ZZZZZZZZZZZZZZZZZZZZZZW(ZZZZZZZZZZZZZZZZZZZZZZt zzzzzzzzzzzzzzzzzzzzzzt_0, uint uint_0, byte byte_0);

			internal byte ZZZZZZZZZZZZZZZZZZZZZZX(ZZZZZZZZZZZZZZZZZZZZZZt zzzzzzzzzzzzzzzzzzzzzzt_0, uint uint_0, byte byte_0, byte byte_1)
			{
				//IL_0002: Invalid comparison between Unknown and I4
				while ((int)/*Error near IL_0007: Stack underflow*/ == -31)
				{
				}
				/*Error near IL_0007: stloc 0 (out-of-bounds)*/;
				return (byte)(int)/*OpCode not supported: Nop*/;
			}

			internal extern ZZZZZZZZZZZZZZZZZZZZZZM();
		}

		internal readonly ZZZZZZZZZZZZZZZZZZZZZZi[] ZZZZZZZZZZZZZZZZZZZZZZZj;

		internal readonly ZZZZZZZZZZZZZZZZZZZZZZi[] ZZZZZZZZZZZZZZZZZZZZZZZk;

		internal readonly ZZZZZZZZZZZZZZZZZZZZZZi[] ZZZZZZZZZZZZZZZZZZZZZZZl;

		internal readonly ZZZZZZZZZZZZZZZZZZZZZZi[] ZZZZZZZZZZZZZZZZZZZZZZZm;

		internal readonly ZZZZZZZZZZZZZZZZZZZZZZi[] ZZZZZZZZZZZZZZZZZZZZZZZn;

		internal readonly ZZZZZZZZZZZZZZZZZZZZZZi[] ZZZZZZZZZZZZZZZZZZZZZZZo;

		internal readonly ZZZZZZZZZZZZZZZZZZZZZZC ZZZZZZZZZZZZZZZZZZZZZZZp;

		internal readonly ZZZZZZZZZZZZZZZZZZZZZZM ZZZZZZZZZZZZZZZZZZZZZZZq;

		internal readonly ZZZZZZZZZZZZZZZZZZZZZZZB ZZZZZZZZZZZZZZZZZZZZZZZr;

		internal readonly ZZZZZZZZZZZZZZZZZZZZZZi[] ZZZZZZZZZZZZZZZZZZZZZZZs;

		internal readonly ZZZZZZZZZZZZZZZZZZZZZZm[] ZZZZZZZZZZZZZZZZZZZZZZZt;

		internal readonly ZZZZZZZZZZZZZZZZZZZZZZt ZZZZZZZZZZZZZZZZZZZZZZZu;

		internal readonly ZZZZZZZZZZZZZZZZZZZZZZC ZZZZZZZZZZZZZZZZZZZZZZZv;

		internal bool ZZZZZZZZZZZZZZZZZZZZZZZw;

		internal uint ZZZZZZZZZZZZZZZZZZZZZZZx;

		internal uint ZZZZZZZZZZZZZZZZZZZZZZZy;

		internal ZZZZZZZZZZZZZZZZZZZZZZm ZZZZZZZZZZZZZZZZZZZZZZZz;

		internal uint ZZZZZZZZZZZZZZZZZZZZZZZA;

		internal extern ZZZZZZZZZZZZZZZZZZZZZZB();

		internal void ZZZZZZZZZZZZZZZZZZZZZZZc(uint uint_0)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			long num = (long)/*Error near IL_0001: Stack underflow*/;
			_ = /*Error near IL_0002: Stack underflow*/<< (int)num;
			/*Error: Unexpected end of block*/;
		}

		internal extern void ZZZZZZZZZZZZZZZZZZZZZZZd(int int_0, int int_1);

		internal extern void ZZZZZZZZZZZZZZZZZZZZZZZe(int int_0);

		internal void ZZZZZZZZZZZZZZZZZZZZZZZf(Stream stream_0, Stream stream_1)
		{
			//Discarded unreachable code: IL_000e, IL_001a
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected native int or pointer, but got F8
			//IL_0015: Expected O, but got I8
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			byte num;
			do
			{
				num = (byte)/*Error near IL_0001: Stack underflow*/;
			}
			while (checked((byte)(/*Error near IL_0002: Stack underflow*/ >> unchecked((int)num))) == 0);
			/*Error near IL_0009: Invalid metadata token*/;
		}

		internal void ZZZZZZZZZZZZZZZZZZZZZZZg(Stream stream_0, Stream stream_1, long long_0, long long_1)
		{
			//Discarded unreachable code: IL_0007, IL_000c, IL_0012, IL_0018, IL_001d
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Invalid comparison between Unknown and I4
			checked
			{
				short num = (short)/*Error near IL_0001: Stack underflow*/;
				_ = /*Error near IL_0002: Stack underflow*/+ num;
				/*Error near IL_0002: Invalid metadata token*/;
			}
		}

		internal extern void ZZZZZZZZZZZZZZZZZZZZZZZh(byte[] byte_0);

		internal static extern uint ZZZZZZZZZZZZZZZZZZZZZZZi(uint uint_0);
	}

	internal class ZZZZZZZZZZZZZZZZZZZZZZZB
	{
		internal byte[] ZZZZZZZZZZZZZZZZZZZZZZZJ;

		internal uint ZZZZZZZZZZZZZZZZZZZZZZZK;

		internal Stream ZZZZZZZZZZZZZZZZZZZZZZZL;

		internal uint ZZZZZZZZZZZZZZZZZZZZZZZM;

		internal uint ZZZZZZZZZZZZZZZZZZZZZZZN;

		internal extern void ZZZZZZZZZZZZZZZZZZZZZZZC(uint uint_0);

		internal void ZZZZZZZZZZZZZZZZZZZZZZZD(Stream stream_0, bool bool_0)
		{
			//Discarded unreachable code: IL_000a, IL_0011
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Invalid comparison between Unknown and O
			_003F val = /*Error: Stack underflow*/;
			checked
			{
				_ = /*Error near IL_0003: Stack underflow*/* val;
				_ = 8;
				/*Error near IL_0005: Invalid metadata token*/;
			}
		}

		internal extern void ZZZZZZZZZZZZZZZZZZZZZZZE();

		internal extern void ZZZZZZZZZZZZZZZZZZZZZZZF();

		internal void ZZZZZZZZZZZZZZZZZZZZZZZG(uint uint_0, uint uint_1)
		{
			//Discarded unreachable code: IL_0006, IL_000d, IL_0014, IL_0020, IL_0025, IL_002b, IL_0030
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Incompatible stack heights: 1 vs 0
			_ = ((double[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
			/*Error near IL_0001: Invalid metadata token*/;
		}

		internal unsafe void ZZZZZZZZZZZZZZZZZZZZZZZH(byte byte_0)
		{
			//IL_0003: Expected I8, but got I4
			ushort num = checked((ushort)/*Error near IL_0002: Stack underflow*/);
			*(long*)(nint)/*Error near IL_0003: Stack underflow*/ = (int)num;
			throw *(object*)(nint)/*Error near IL_0004: Stack underflow*/;
		}

		internal unsafe byte ZZZZZZZZZZZZZZZZZZZZZZZI(uint uint_0)
		{
			//Discarded unreachable code: IL_0017
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Invalid comparison between Unknown and I
			while (true)
			{
				double num = *(double*)(nint)/*Error near IL_0001: Stack underflow*/;
				((double[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/] = num;
				if ((int)/*Error near IL_0007: Stack underflow*/ == 0)
				{
					_003F val = /*Error near IL_0009: Stack underflow*/% 4;
					/*OpCode not supported: Ckfinite*/;
					nuint num2 = checked((nuint)val);
					if ((nint)/*Error near IL_0010: Stack underflow*/ >= (nint)num2)
					{
						break;
					}
				}
			}
			/*Error near IL_0010: stloc 1 (out-of-bounds)*/;
			/*Error near IL_0012: Invalid metadata token*/;
		}

		internal extern ZZZZZZZZZZZZZZZZZZZZZZZB();
	}

	internal struct ZZZZZZZZZZZZZZZZZZZZZZZO
	{
		internal uint ZZZZZZZZZZZZZZZZZZZZZZZV;

		internal extern void ZZZZZZZZZZZZZZZZZZZZZZZP();

		internal extern void ZZZZZZZZZZZZZZZZZZZZZZZQ();

		internal unsafe void ZZZZZZZZZZZZZZZZZZZZZZZR()
		{
			//Discarded unreachable code: IL_0004
			_ = *(byte*)(nint)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0003: Unknown opcode: 0xF8*/;
		}

		internal extern void ZZZZZZZZZZZZZZZZZZZZZZZS();

		internal extern void ZZZZZZZZZZZZZZZZZZZZZZZT();

		internal extern bool ZZZZZZZZZZZZZZZZZZZZZZZU();
	}

	public class ZZZZZZZZZZZZZZZZZZZZZZZZZa
	{
		public const uint ZZZZZZZZZZZZZZZZZZZZZZZZZn = default(uint);

		public const uint ZZZZZZZZZZZZZZZZZZZZZZZZZo = default(uint);

		private static uint[] ZZZZZZZZZZZZZZZZZZZZZZZZZp;

		private readonly uint ZZZZZZZZZZZZZZZZZZZZZZZZZq;

		private readonly uint[] ZZZZZZZZZZZZZZZZZZZZZZZZZr;

		private uint ZZZZZZZZZZZZZZZZZZZZZZZZZs;

		public extern ZZZZZZZZZZZZZZZZZZZZZZZZZa();

		public extern ZZZZZZZZZZZZZZZZZZZZZZZZZa(uint uint_0, uint uint_1);

		public unsafe void ZZZZZZZZZZZZZZZZZZZZZZZZZc()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0003: Expected I, but got Unknown
			//IL_0009: Expected F4, but got O
			_003F val;
			checked
			{
				ushort num = (ushort)/*Error near IL_0001: Stack underflow*/;
				val = /*Error near IL_0002: Stack underflow*/* num;
			}
			((IntPtr[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = (IntPtr)val;
			*(float*)(nint)/*Error near IL_0009: Stack underflow*/ = (float)this;
		}

		protected void ZZZZZZZZZZZZZZZZZZZZZZZZZd(byte[] byte_0, int int_0, int int_1)
		{
		}

		protected unsafe byte[] ZZZZZZZZZZZZZZZZZZZZZZZZZe()
		{
			//Discarded unreachable code: IL_0008, IL_0016
			//IL_000b: Expected I4, but got F4
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				_ = (ushort)(*unchecked((nint*)(nint)/*Error near IL_0001: Stack underflow*/));
				/*Error near IL_0003: Invalid metadata token*/;
			}
		}

		[SpecialName]
		public extern int ZZZZZZZZZZZZZZZZZZZZZZZZZf();

		public static extern uint ZZZZZZZZZZZZZZZZZZZZZZZZZg(string string_0);

		public static extern uint ZZZZZZZZZZZZZZZZZZZZZZZZZh(byte[] byte_0);

		public static extern uint ZZZZZZZZZZZZZZZZZZZZZZZZZi(uint uint_0, byte[] byte_0);

		public static extern uint ZZZZZZZZZZZZZZZZZZZZZZZZZj(uint uint_0, uint uint_1, byte[] byte_0);

		private static uint[] ZZZZZZZZZZZZZZZZZZZZZZZZZk(uint uint_0)
		{
			//Discarded unreachable code: IL_0005, IL_0010
			//IL_0008: Expected I, but got I8
			//IL_000b: Invalid comparison between Unknown and I
			/*Error: Invalid metadata token*/;
		}

		private static extern uint ZZZZZZZZZZZZZZZZZZZZZZZZZl(uint[] uint_0, uint uint_1, IList<byte> ilist_0, int int_0, int int_1);

		private static byte[] ZZZZZZZZZZZZZZZZZZZZZZZZZm(uint uint_0)
		{
			//Discarded unreachable code: IL_0009, IL_000d, IL_0012, IL_0013, IL_0019, IL_0021
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected I4, but got Unknown
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			/*Error near IL_0004: Invalid metadata token*/;
		}
	}

	[ZZZZZZZZZZZZy(351757579)]
	internal static ZZZZZZZZZZZZw zzzzzzzzzzzzw_0;

	[ZZZZZZZZZZZZE(1651140936)]
	internal static ZZZZZZZZZZZZC zzzzzzzzzzzzc_0;

	[ZZZZZZZZZZZZK(-363699382)]
	internal static ZZZZZZZZZZZZI zzzzzzzzzzzzi_0;

	[ZZZZZZZZZZZZR(169396924)]
	internal static ZZZZZZZZZZZZP zzzzzzzzzzzzp_0;

	[ZZZZZZZZZZZZY(2021569539)]
	internal static ZZZZZZZZZZZZW zzzzzzzzzzzzw_1;

	[ZZZZZZZZZZZZZe(1867200705)]
	internal static ZZZZZZZZZZZZZc zzzzzzzzzzzzzc_0;

	[ZZZZZZZZZZZZZi(-561568948)]
	internal static ZZZZZZZZZZZZZc zzzzzzzzzzzzzc_1;

	[ZZZZZZZZZZZZZm(918778825)]
	internal static ZZZZZZZZZZZZZc zzzzzzzzzzzzzc_2;

	[ZZZZZZZZZZZZY(1895277529)]
	internal static ZZZZZZZZZZZZZc zzzzzzzzzzzzzc_3;

	[ZZZZZZZZZZZZZs(1548595577)]
	internal static ZZZZZZZZZZZZZq zzzzzzzzzzzzzq_0;

	[ZZZZZZZZZZZZZe(326761071)]
	internal static ZZZZZZZZZZZZZc zzzzzzzzzzzzzc_4;

	[ZZZZZZZZZZZZZm(1738068433)]
	internal static ZZZZZZZZZZZZZc zzzzzzzzzzzzzc_5;

	[ZZZZZZZZZZZZy(-1650089477)]
	internal static ZZZZZZZZZZZZZx zzzzzzzzzzzzzx_0;

	[ZZZZZZZZZZZZE(2142873630)]
	internal static ZZZZZZZZZZZZZz zzzzzzzzzzzzzz_0;

	[ZZZZZZZZZZZZR(209854512)]
	internal static ZZZZZZZZZZZZZB zzzzzzzzzzzzzb_0;

	[ZZZZZZZZZZZZZG(862467632)]
	internal static ZZZZZZZZZZZZZE zzzzzzzzzzzzze_0;

	[ZZZZZZZZZZZZZN(-643617549)]
	internal static ZZZZZZZZZZZZZL zzzzzzzzzzzzzl_0;

	[ZZZZZZZZZZZZZT(2085433586)]
	internal static ZZZZZZZZZZZZZR zzzzzzzzzzzzzr_0;

	[ZZZZZZZZZZZZZZ(-1037993742)]
	internal static ZZZZZZZZZZZZZX zzzzzzzzzzzzzx_1;

	[ZZZZZZZZZZZZE(610890894)]
	internal static ZZZZZZZZZZZZZZd zzzzzzzzzzzzzzd_0;

	[ZZZZZZZZZZZZZm(1016497385)]
	internal static ZZZZZZZZZZZZZZf zzzzzzzzzzzzzzf_0;

	[ZZZZZZZZZZZZK(-1452787434)]
	internal static ZZZZZZZZZZZZZq zzzzzzzzzzzzzq_1;

	[ZZZZZZZZZZZZZZj(-308843552)]
	internal static ZZZZZZZZZZZZZZh zzzzzzzzzzzzzzh_0;

	[ZZZZZZZZZZZZZZn(-2078659226)]
	internal static ZZZZZZZZZZZZZZh zzzzzzzzzzzzzzh_1;

	[ZZZZZZZZZZZZZm(-152227605)]
	internal static ZZZZZZZZZZZZZZr zzzzzzzzzzzzzzr_0;

	[ZZZZZZZZZZZZK(-481076906)]
	internal static ZZZZZZZZZZZZZZu zzzzzzzzzzzzzzu_0;

	[ZZZZZZZZZZZZZN(-406302999)]
	internal static ZZZZZZZZZZZZZZw zzzzzzzzzzzzzzw_0;

	[ZZZZZZZZZZZZZG(1174163880)]
	internal static ZZZZZZZZZZZZZZy zzzzzzzzzzzzzzy_0;

	[ZZZZZZZZZZZZY(-869922593)]
	internal static ZZZZZZZZZZZZZZA zzzzzzzzzzzzzza_0;

	[ZZZZZZZZZZZZy(-625176199)]
	internal static ZZZZZZZZZZZZZZC zzzzzzzzzzzzzzc_0;

	[ZZZZZZZZZZZZZm(1507672613)]
	internal static ZZZZZZZZZZZZZZy zzzzzzzzzzzzzzy_1;

	[ZZZZZZZZZZZZK(-1541028460)]
	internal static ZZZZZZZZZZZZZZE zzzzzzzzzzzzzze_0;

	[ZZZZZZZZZZZZZZG(-1145364267)]
	internal static ZZZZZZZZZZZZZZy zzzzzzzzzzzzzzy_2;

	[ZZZZZZZZZZZZZZj(1431933314)]
	internal static ZZZZZZZZZZZZZZK zzzzzzzzzzzzzzk_0;

	[ZZZZZZZZZZZZZG(1748509284)]
	internal static ZZZZZZZZZZZZZZM zzzzzzzzzzzzzzm_0;

	[ZZZZZZZZZZZZZs(-2029846865)]
	internal static ZZZZZZZZZZZZZZO zzzzzzzzzzzzzzo_0;

	[ZZZZZZZZZZZZZi(-1799921916)]
	internal static ZZZZZZZZZZZZZZQ zzzzzzzzzzzzzzq_0;

	[ZZZZZZZZZZZZE(-245513606)]
	internal static ZZZZZZZZZZZZZZO zzzzzzzzzzzzzzo_1;

	[ZZZZZZZZZZZZZZj(573200840)]
	internal static ZZZZZZZZZZZZZZO zzzzzzzzzzzzzzo_2;

	[ZZZZZZZZZZZZY(-1957381809)]
	internal static ZZZZZZZZZZZZZZO zzzzzzzzzzzzzzo_3;

	[ZZZZZZZZZZZZK(-1107867914)]
	internal static ZZZZZZZZZZZZZZO zzzzzzzzzzzzzzo_4;

	[ZZZZZZZZZZZZZe(1890506369)]
	internal static ZZZZZZZZZZZZZZO zzzzzzzzzzzzzzo_5;

	[ZZZZZZZZZZZZZm(-320163703)]
	internal static ZZZZZZZZZZZZZZV zzzzzzzzzzzzzzv_0;

	[ZZZZZZZZZZZZR(1319879782)]
	internal static ZZZZZZZZZZZZZZX zzzzzzzzzzzzzzx_0;

	[ZZZZZZZZZZZZZG(1651584056)]
	internal static ZZZZZZZZZZZZZZZ zzzzzzzzzzzzzzz_0;

	[ZZZZZZZZZZZZR(942274766)]
	internal static ZZZZZZZZZZZZZZZd zzzzzzzzzzzzzzzd_0;

	[ZZZZZZZZZZZZK(192171760)]
	internal static ZZZZZZZZZZZZZZZg zzzzzzzzzzzzzzzg_0;

	[ZZZZZZZZZZZZZZn(-1127375644)]
	internal static ZZZZZZZZZZZZZZZi zzzzzzzzzzzzzzzi_0;

	[ZZZZZZZZZZZZZG(496529442)]
	internal static ZZZZZZZZZZZZZZZk zzzzzzzzzzzzzzzk_0;

	[ZZZZZZZZZZZZZZG(607309241)]
	internal static ZZZZZZZZZZZZZZZm zzzzzzzzzzzzzzzm_0;

	[ZZZZZZZZZZZZE(813342770)]
	internal static ZZZZZZZZZZZZZZZo zzzzzzzzzzzzzzzo_0;

	[ZZZZZZZZZZZZZs(915067575)]
	internal static ZZZZZZZZZZZZZZZk zzzzzzzzzzzzzzzk_1;

	[ZZZZZZZZZZZZZi(991826660)]
	internal static ZZZZZZZZZZZZZZZq zzzzzzzzzzzzzzzq_0;

	[ZZZZZZZZZZZZZs(752980465)]
	internal static ZZZZZZZZZZZZZZZs zzzzzzzzzzzzzzzs_0;

	[ZZZZZZZZZZZZZZG(-541149641)]
	internal static ZZZZZZZZZZZZZZZu zzzzzzzzzzzzzzzu_0;

	[ZZZZZZZZZZZZZN(-472806643)]
	internal static ZZZZZZZZZZZZZZZw zzzzzzzzzzzzzzzw_0;

	[ZZZZZZZZZZZZZZn(-657362324)]
	internal static ZZZZZZZZZZZZZZZy zzzzzzzzzzzzzzzy_0;

	[ZZZZZZZZZZZZZm(1123114157)]
	internal static ZZZZZZZZZZZZZZy zzzzzzzzzzzzzzy_3;

	[ZZZZZZZZZZZZZZ(-2069122678)]
	internal static ZZZZZZZZZZZZZZy zzzzzzzzzzzzzzy_4;

	[ZZZZZZZZZZZZE(-1974075346)]
	internal static ZZZZZZZZZZZZZZZA zzzzzzzzzzzzzzza_0;

	[ZZZZZZZZZZZZZZG(-369399401)]
	internal static ZZZZZZZZZZZZZZZC zzzzzzzzzzzzzzzc_0;

	[ZZZZZZZZZZZZZZn(155841058)]
	internal static ZZZZZZZZZZZZZZZE zzzzzzzzzzzzzzze_0;

	[ZZZZZZZZZZZZZs(-926183063)]
	internal static ZZZZZZZZZZZZZZZG zzzzzzzzzzzzzzzg_1;

	[ZZZZZZZZZZZZZZG(-1812261337)]
	internal static ZZZZZZZZZZZZZZZI zzzzzzzzzzzzzzzi_1;

	[ZZZZZZZZZZZZR(209270216)]
	internal static ZZZZZZZZZZZZZZZK zzzzzzzzzzzzzzzk_2;

	[ZZZZZZZZZZZZZZ(2074077044)]
	internal static ZZZZZZZZZZZZZZZM zzzzzzzzzzzzzzzm_1;

	[ZZZZZZZZZZZZZG(-896250634)]
	internal static ZZZZZZZZZZZZZZZO zzzzzzzzzzzzzzzo_1;

	[ZZZZZZZZZZZZE(1758389586)]
	internal static ZZZZZZZZZZZZZZZQ zzzzzzzzzzzzzzzq_1;

	[ZZZZZZZZZZZZy(-1354628629)]
	internal static ZZZZZZZZZZZZZZZS zzzzzzzzzzzzzzzs_1;

	[ZZZZZZZZZZZZZN(-1935471325)]
	internal static ZZZZZZZZZZZZZZZW zzzzzzzzzzzzzzzw_1;

	[ZZZZZZZZZZZZZT(-438470260)]
	internal static ZZZZZZZZZZZZZL zzzzzzzzzzzzzl_1;

	[ZZZZZZZZZZZZZZj(1511461410)]
	internal static ZZZZZZZZZZZZZZZY zzzzzzzzzzzzzzzy_1;

	[ZZZZZZZZZZZZZT(826257508)]
	internal static ZZZZZZZZZZZZZZZZa zzzzzzzzzzzzzzzza_0;

	[ZZZZZZZZZZZZY(1077672677)]
	internal static ZZZZZZZZZZZZZZy zzzzzzzzzzzzzzy_5;

	[ZZZZZZZZZZZZR(1173719370)]
	internal static ZZZZZZZZZZZZZZy zzzzzzzzzzzzzzy_6;

	[ZZZZZZZZZZZZZZ(-607024416)]
	internal static ZZZZZZZZZZZZZZZZc zzzzzzzzzzzzzzzzc_0;

	[ZZZZZZZZZZZZZi(656563240)]
	internal static ZZZZZZZZZZZZZZZQ zzzzzzzzzzzzzzzq_2;

	[ZZZZZZZZZZZZE(-891606638)]
	internal static ZZZZZZZZZZZZZZZZe zzzzzzzzzzzzzzzze_0;

	[ZZZZZZZZZZZZZT(1474380896)]
	internal static ZZZZZZZZZZZZZZZZg zzzzzzzzzzzzzzzzg_0;

	[ZZZZZZZZZZZZZG(-1252939552)]
	internal static ZZZZZZZZZZZZZZy zzzzzzzzzzzzzzy_7;

	[ZZZZZZZZZZZZZZn(190613152)]
	internal static ZZZZZZZZZZZZZZZZg zzzzzzzzzzzzzzzzg_1;

	[ZZZZZZZZZZZZR(1270454980)]
	internal static ZZZZZZZZZZZZZZy zzzzzzzzzzzzzzy_8;

	[ZZZZZZZZZZZZZZn(1293525062)]
	internal static ZZZZZZZZZZZZZZy zzzzzzzzzzzzzzy_9;

	[ZZZZZZZZZZZZZi(224197130)]
	internal static ZZZZZZZZZZZZC zzzzzzzzzzzzc_1;

	[ZZZZZZZZZZZZY(241398565)]
	internal static ZZZZZZZZZZZZZZZZh zzzzzzzzzzzzzzzzh_0;

	[ZZZZZZZZZZZZZi(367044718)]
	internal static ZZZZZZZZZZZZC zzzzzzzzzzzzc_2;

	[ZZZZZZZZZZZZZm(2023191309)]
	internal static ZZZZZZZZZZZZZZZZj zzzzzzzzzzzzzzzzj_0;

	[ZZZZZZZZZZZZZs(1281931841)]
	internal static ZZZZZZZZZZZZZZZZl zzzzzzzzzzzzzzzzl_0;

	[ZZZZZZZZZZZZR(-1686128868)]
	internal static ZZZZZZZZZZZZZL zzzzzzzzzzzzzl_2;

	[ZZZZZZZZZZZZy(-1448037329)]
	internal static ZZZZZZZZZZZZZZZZn zzzzzzzzzzzzzzzzn_0;

	[ZZZZZZZZZZZZE(190634158)]
	internal static ZZZZZZZZZZZZZZZZp zzzzzzzzzzzzzzzzp_0;

	[ZZZZZZZZZZZZy(-934573887)]
	internal static ZZZZZZZZZZZZC zzzzzzzzzzzzc_3;

	[ZZZZZZZZZZZZZT(97457372)]
	internal static ZZZZZZZZZZZZC zzzzzzzzzzzzc_4;

	[ZZZZZZZZZZZZZs(890426165)]
	internal static ZZZZZZZZZZZZZZZZr zzzzzzzzzzzzzzzzr_0;

	[ZZZZZZZZZZZZZi(-496161834)]
	internal static ZZZZZZZZZZZZZZf zzzzzzzzzzzzzzf_1;

	[ZZZZZZZZZZZZY(1798371979)]
	internal static ZZZZZZZZZZZZZZO zzzzzzzzzzzzzzo_6;

	[ZZZZZZZZZZZZZG(-1359496834)]
	internal static ZZZZZZZZZZZZZZZZj zzzzzzzzzzzzzzzzj_1;

	[ZZZZZZZZZZZZZi(206446248)]
	internal static ZZZZZZZZZZZZZZf zzzzzzzzzzzzzzf_2;

	[ZZZZZZZZZZZZZm(923087963)]
	internal static ZZZZZZZZZZZZZZZZu zzzzzzzzzzzzzzzzu_0;

	[ZZZZZZZZZZZZZN(-1663638403)]
	internal static ZZZZZZZZZZZZZZZZw zzzzzzzzzzzzzzzzw_0;

	[ZZZZZZZZZZZZZZ(-557525780)]
	internal static ZZZZZZZZZZZZZZZZy zzzzzzzzzzzzzzzzy_0;

	[ZZZZZZZZZZZZE(2041451930)]
	internal static ZZZZZZZZZZZZZZZZA zzzzzzzzzzzzzzzza_1;

	[ZZZZZZZZZZZZZZn(186206962)]
	internal static ZZZZZZZZZZZZZZZZe zzzzzzzzzzzzzzzze_1;

	[ZZZZZZZZZZZZZT(172781152)]
	internal static ZZZZZZZZZZZZZZZZp zzzzzzzzzzzzzzzzp_1;

	[ZZZZZZZZZZZZY(1735994469)]
	internal static ZZZZZZZZZZZZZZZZD zzzzzzzzzzzzzzzzd_0;

	[ZZZZZZZZZZZZy(1844681219)]
	internal static ZZZZZZZZZZZZZZf zzzzzzzzzzzzzzf_3;

	[ZZZZZZZZZZZZE(1189147748)]
	internal static ZZZZZZZZZZZZZZZZF zzzzzzzzzzzzzzzzf_0;

	[ZZZZZZZZZZZZZG(-1143145494)]
	internal static ZZZZZZZZZZZZC zzzzzzzzzzzzc_5;

	[ZZZZZZZZZZZZZZn(-917843446)]
	internal static ZZZZZZZZZZZZZZZZH zzzzzzzzzzzzzzzzh_1;

	[ZZZZZZZZZZZZZm(2083562367)]
	internal static ZZZZZZZZZZZZZZZZJ zzzzzzzzzzzzzzzzj_2;

	[ZZZZZZZZZZZZZs(1812087777)]
	internal static ZZZZZZZZZZZZZZZZL zzzzzzzzzzzzzzzzl_1;

	[ZZZZZZZZZZZZy(-1137311887)]
	internal static ZZZZZZZZZZZZZZf zzzzzzzzzzzzzzf_4;

	[ZZZZZZZZZZZZZT(-1386994578)]
	internal static ZZZZZZZZZZZZZZZZu zzzzzzzzzzzzzzzzu_1;

	[ZZZZZZZZZZZZZZj(161897010)]
	internal static ZZZZZZZZZZZZZZZZO zzzzzzzzzzzzzzzzo_0;

	[ZZZZZZZZZZZZZm(-90693561)]
	internal static ZZZZZZZZZZZZZZZZQ zzzzzzzzzzzzzzzzq_0;

	[ZZZZZZZZZZZZZT(-1696498842)]
	internal static ZZZZZZZZZZZZZZZZS zzzzzzzzzzzzzzzzs_0;

	[ZZZZZZZZZZZZZs(-80124407)]
	internal static ZZZZZZZZZZZZZZZZU zzzzzzzzzzzzzzzzu_2;

	[ZZZZZZZZZZZZY(591449959)]
	internal static ZZZZZZZZZZZZZZy zzzzzzzzzzzzzzy_10;

	[ZZZZZZZZZZZZY(-1358519521)]
	internal static ZZZZZZZZZZZZC zzzzzzzzzzzzc_6;

	[ZZZZZZZZZZZZZZG(972879081)]
	internal static ZZZZZZZZZZZZZZZZW zzzzzzzzzzzzzzzzw_1;

	[ZZZZZZZZZZZZK(1806886616)]
	internal static ZZZZZZZZZZZZZZZZj zzzzzzzzzzzzzzzzj_3;

	[ZZZZZZZZZZZZZG(1813959478)]
	internal static ZZZZZZZZZZZZZZZZY zzzzzzzzzzzzzzzzy_1;

	[ZZZZZZZZZZZZZe(931132773)]
	internal static ZZZZZZZZZZZZZZZZr zzzzzzzzzzzzzzzzr_1;

	[ZZZZZZZZZZZZE(-1900742002)]
	internal static ZZZZZZZZZZZZZZZZZa zzzzzzzzzzzzzzzzza_0;

	[ZZZZZZZZZZZZZN(1167408925)]
	internal static ZZZZZZZZZZZZZZZW zzzzzzzzzzzzzzzw_2;

	[ZZZZZZZZZZZZZm(-408576983)]
	internal static ZZZZZZZZZZZZZZZZZc zzzzzzzzzzzzzzzzzc_0;

	[ZZZZZZZZZZZZE(226406452)]
	internal static ZZZZZZZZZZZZZZZZZf zzzzzzzzzzzzzzzzzf_0;

	[ZZZZZZZZZZZZE(8754180)]
	internal static ZZZZZZZZZZZZZZZZZh zzzzzzzzzzzzzzzzzh_0;

	[ZZZZZZZZZZZZZN(651323045)]
	internal static ZZZZZZZZZZZZZZZZZj zzzzzzzzzzzzzzzzzj_0;

	[ZZZZZZZZZZZZZs(-970341609)]
	internal static ZZZZZZZZZZZZZZZZZl zzzzzzzzzzzzzzzzzl_0;

	[ZZZZZZZZZZZZZZG(1270386065)]
	internal static ZZZZZZZZZZZZZZZZZn zzzzzzzzzzzzzzzzzn_0;

	[ZZZZZZZZZZZZK(-1273793132)]
	internal static ZZZZZZZZZZZZC zzzzzzzzzzzzc_7;

	[ZZZZZZZZZZZZZG(-600381336)]
	internal static ZZZZZZZZZZZZZZZZZr zzzzzzzzzzzzzzzzzr_0;

	[ZZZZZZZZZZZZZs(-1588214849)]
	internal static ZZZZZZZZZZZZZZZZZr zzzzzzzzzzzzzzzzzr_1;

	[ZZZZZZZZZZZZZZ(-90524668)]
	internal static ZZZZZZZZZZZZZZZZZt zzzzzzzzzzzzzzzzzt_0;

	[ZZZZZZZZZZZZZZn(-1184642508)]
	internal static ZZZZZZZZZZZZZZZZZw zzzzzzzzzzzzzzzzzw_0;

	[ZZZZZZZZZZZZY(1171752729)]
	internal static ZZZZZZZZZZZZZZZZZy zzzzzzzzzzzzzzzzzy_0;

	[ZZZZZZZZZZZZR(-53054482)]
	internal static ZZZZZZZZZZZZZZy zzzzzzzzzzzzzzy_11;

	[ZZZZZZZZZZZZZG(-1273773824)]
	internal static ZZZZZZZZZZZZZZZZZA zzzzzzzzzzzzzzzzza_1;

	[ZZZZZZZZZZZZZe(1709386393)]
	internal static ZZZZZZZZZZZZZZZZr zzzzzzzzzzzzzzzzr_2;

	[ZZZZZZZZZZZZZi(-1207155446)]
	internal static ZZZZZZZZZZZZZZO zzzzzzzzzzzzzzo_7;

	[ZZZZZZZZZZZZZi(-2046395784)]
	internal static ZZZZZZZZZZZZZZO zzzzzzzzzzzzzzo_8;

	[ZZZZZZZZZZZZZe(1854448277)]
	internal static ZZZZZZZZZZZZZZZZZD zzzzzzzzzzzzzzzzzd_0;

	[ZZZZZZZZZZZZZZn(1638873194)]
	internal static ZZZZZZZZZZZZZZO zzzzzzzzzzzzzzo_9;

	[ZZZZZZZZZZZZR(957121942)]
	internal static ZZZZZZZZZZZZZZZZZF zzzzzzzzzzzzzzzzzf_1;

	[ZZZZZZZZZZZZZi(-1404359340)]
	internal static ZZZZZZZZZZZZZc zzzzzzzzzzzzzc_6;

	[ZZZZZZZZZZZZZs(1354048333)]
	internal static ZZZZZZZZZZZZZZZZe zzzzzzzzzzzzzzzze_2;

	[ZZZZZZZZZZZZZZG(-395980023)]
	internal static ZZZZZZZZZZZZZZV zzzzzzzzzzzzzzv_1;

	[ZZZZZZZZZZZZZi(1989129240)]
	internal static ZZZZZZZZZZZZZZZZZH zzzzzzzzzzzzzzzzzh_1;

	[ZZZZZZZZZZZZZZn(1690625858)]
	internal static ZZZZZZZZZZZZZZZZZy zzzzzzzzzzzzzzzzzy_1;

	[ZZZZZZZZZZZZK(-947506650)]
	internal static ZZZZZZZZZZZZZZZZZJ zzzzzzzzzzzzzzzzzj_1;

	[ZZZZZZZZZZZZY(-299981587)]
	internal static ZZZZZZZZZZZZZZf zzzzzzzzzzzzzzf_5;

	[ZZZZZZZZZZZZZT(56483398)]
	internal static ZZZZZZZZZZZZZZO zzzzzzzzzzzzzzo_10;

	[ZZZZZZZZZZZZE(-116431864)]
	internal static ZZZZZZZZZZZZZZO zzzzzzzzzzzzzzo_11;

	[ZZZZZZZZZZZZZT(2099147526)]
	internal static ZZZZZZZZZZZZZZA zzzzzzzzzzzzzza_1;

	[ZZZZZZZZZZZZE(87006618)]
	internal static ZZZZZZZZZZZZZZO zzzzzzzzzzzzzzo_12;

	[ZZZZZZZZZZZZE(-1957512268)]
	internal static ZZZZZZZZZZZZZZZZZM zzzzzzzzzzzzzzzzzm_0;

	[ZZZZZZZZZZZZK(1758337570)]
	internal static ZZZZZZZZZZZZZZZZZy zzzzzzzzzzzzzzzzzy_2;

	[ZZZZZZZZZZZZZG(1025920194)]
	internal static ZZZZZZZZZZZZZZZZZO zzzzzzzzzzzzzzzzzo_0;

	[ZZZZZZZZZZZZE(-1944428278)]
	internal static ZZZZZZZZZZZZC zzzzzzzzzzzzc_8;

	[ZZZZZZZZZZZZZe(40549093)]
	internal static ZZZZZZZZZZZZZZZZZR zzzzzzzzzzzzzzzzzr_2;

	[ZZZZZZZZZZZZE(-590421502)]
	internal static ZZZZZZZZZZZZZZZZZT zzzzzzzzzzzzzzzzzt_1;

	[ZZZZZZZZZZZZZm(1408224715)]
	internal static ZZZZZZZZZZZZC zzzzzzzzzzzzc_9;

	[ZZZZZZZZZZZZy(1343827657)]
	internal static ZZZZZZZZZZZZZZZZZV zzzzzzzzzzzzzzzzzv_0;

	[ZZZZZZZZZZZZZG(-888376954)]
	internal static ZZZZZZZZZZZZZZZZZX zzzzzzzzzzzzzzzzzx_0;

	[ZZZZZZZZZZZZR(2140422780)]
	internal static ZZZZZZZZZZZZZZZZZZa zzzzzzzzzzzzzzzzzza_0;

	[ZZZZZZZZZZZZZN(-597099639)]
	internal static ZZZZZZZZZZZZZZZZZZc zzzzzzzzzzzzzzzzzzc_0;

	[ZZZZZZZZZZZZZN(-2123051951)]
	internal static ZZZZZZZZZZZZZZf zzzzzzzzzzzzzzf_6;

	[ZZZZZZZZZZZZY(2117961829)]
	internal static ZZZZZZZZZZZZZZZZZy zzzzzzzzzzzzzzzzzy_3;

	[ZZZZZZZZZZZZZT(-772493630)]
	internal static ZZZZZZZZZZZZC zzzzzzzzzzzzc_10;

	[ZZZZZZZZZZZZZT(2081894754)]
	internal static ZZZZZZZZZZZZZZZZZZe zzzzzzzzzzzzzzzzzze_0;

	[ZZZZZZZZZZZZZZn(880343404)]
	internal static ZZZZZZZZZZZZZZZZZZg zzzzzzzzzzzzzzzzzzg_0;

	[ZZZZZZZZZZZZy(1337366835)]
	internal static ZZZZZZZZZZZZZZZZZR zzzzzzzzzzzzzzzzzr_3;

	[ZZZZZZZZZZZZy(-242404401)]
	internal static ZZZZZZZZZZZZZZZZZZj zzzzzzzzzzzzzzzzzzj_0;

	[ZZZZZZZZZZZZZZ(-1101692220)]
	internal static ZZZZZZZZZZZZZZZZZV zzzzzzzzzzzzzzzzzv_1;

	[ZZZZZZZZZZZZK(-911374528)]
	internal static ZZZZZZZZZZZZZZZZZV zzzzzzzzzzzzzzzzzv_2;

	[ZZZZZZZZZZZZK(2028535058)]
	internal static ZZZZZZZZZZZZZZZZZZl zzzzzzzzzzzzzzzzzzl_0;

	[ZZZZZZZZZZZZZZ(501129596)]
	internal static ZZZZZZZZZZZZZZZZZD zzzzzzzzzzzzzzzzzd_1;

	[ZZZZZZZZZZZZZs(1022045881)]
	internal static ZZZZZZZZZZZZZZA zzzzzzzzzzzzzza_2;

	[ZZZZZZZZZZZZZZn(29817612)]
	internal static ZZZZZZZZZZZZZZZZg zzzzzzzzzzzzzzzzg_2;

	[ZZZZZZZZZZZZy(-841182001)]
	internal static ZZZZZZZZZZZZZZZZe zzzzzzzzzzzzzzzze_3;

	[ZZZZZZZZZZZZZZG(-595528957)]
	internal static ZZZZZZZZZZZZZZZZZZn zzzzzzzzzzzzzzzzzzn_0;

	[ZZZZZZZZZZZZZs(953451517)]
	internal static ZZZZZZZZZZZZC zzzzzzzzzzzzc_11;

	[ZZZZZZZZZZZZZT(-901693190)]
	internal static ZZZZZZZZZZZZC zzzzzzzzzzzzc_12;

	[ZZZZZZZZZZZZZi(-199679842)]
	internal static ZZZZZZZZZZZZZZO zzzzzzzzzzzzzzo_13;

	[ZZZZZZZZZZZZy(-136163151)]
	internal static ZZZZZZZZZZZZZZO zzzzzzzzzzzzzzo_14;

	[ZZZZZZZZZZZZY(1870413889)]
	internal static ZZZZZZZZZZZZZZf zzzzzzzzzzzzzzf_7;

	[ZZZZZZZZZZZZE(-755823158)]
	internal static ZZZZZZZZZZZZZZO zzzzzzzzzzzzzzo_15;

	[ZZZZZZZZZZZZZi(-84158164)]
	internal static ZZZZZZZZZZZZZZO zzzzzzzzzzzzzzo_16;

	[ZZZZZZZZZZZZZT(-81640272)]
	internal static ZZZZZZZZZZZZZZO zzzzzzzzzzzzzzo_17;

	[ZZZZZZZZZZZZZm(-1043679771)]
	internal static ZZZZZZZZZZZZZZO zzzzzzzzzzzzzzo_18;

	[ZZZZZZZZZZZZZZn(1412905990)]
	internal static ZZZZZZZZZZZZZZZZZZr zzzzzzzzzzzzzzzzzzr_0;

	[ZZZZZZZZZZZZZe(-1712757671)]
	internal static ZZZZZZZZZZZZI zzzzzzzzzzzzi_1;

	[ZZZZZZZZZZZZE(-1347094476)]
	internal static ZZZZZZZZZZZZZZZZZZt zzzzzzzzzzzzzzzzzzt_0;

	[ZZZZZZZZZZZZZm(-2138764395)]
	internal static ZZZZZZZZZZZZZZZZZZv zzzzzzzzzzzzzzzzzzv_0;

	[ZZZZZZZZZZZZZZG(-1774100881)]
	internal static ZZZZZZZZZZZZZZZs zzzzzzzzzzzzzzzs_2;

	[ZZZZZZZZZZZZZG(-1824100890)]
	internal static ZZZZZZZZZZZZZc zzzzzzzzzzzzzc_7;

	[ZZZZZZZZZZZZZs(1614747897)]
	internal static ZZZZZZZZZZZZZZZW zzzzzzzzzzzzzzzw_3;

	[ZZZZZZZZZZZZZZG(-912731029)]
	internal static ZZZZZZZZZZZZZZZZZZx zzzzzzzzzzzzzzzzzzx_0;

	[ZZZZZZZZZZZZR(-535962814)]
	internal static ZZZZZZZZZZZZZZZQ zzzzzzzzzzzzzzzq_3;

	[ZZZZZZZZZZZZZZG(1620609311)]
	internal static ZZZZZZZZZZZZC zzzzzzzzzzzzc_13;

	[ZZZZZZZZZZZZZe(1280015839)]
	internal static ZZZZZZZZZZZZC zzzzzzzzzzzzc_14;

	[ZZZZZZZZZZZZZZ(-1807943278)]
	internal static ZZZZZZZZZZZZZZZZj zzzzzzzzzzzzzzzzj_4;

	[ZZZZZZZZZZZZZZ(1421817800)]
	internal static ZZZZZZZZZZZZZZZZj zzzzzzzzzzzzzzzzj_5;

	[ZZZZZZZZZZZZZZG(-1854133521)]
	internal static ZZZZZZZZZZZZZZZZp zzzzzzzzzzzzzzzzp_2;

	[ZZZZZZZZZZZZZN(-2037910685)]
	internal static ZZZZZZZZZZZZZZy zzzzzzzzzzzzzzy_12;

	[ZZZZZZZZZZZZK(-663828084)]
	internal static ZZZZZZZZZZZZZZO zzzzzzzzzzzzzzo_19;

	[ZZZZZZZZZZZZY(12301117)]
	internal static ZZZZZZZZZZZZZZZZZy zzzzzzzzzzzzzzzzzy_4;

	[ZZZZZZZZZZZZZs(42356545)]
	internal static ZZZZZZZZZZZZZZZZZZA zzzzzzzzzzzzzzzzzza_1;

	[ZZZZZZZZZZZZE(1849150530)]
	internal static ZZZZZZZZZZZZC zzzzzzzzzzzzc_15;

	[ZZZZZZZZZZZZZN(-754293803)]
	internal static ZZZZZZZZZZZZZZZZZD zzzzzzzzzzzzzzzzzd_2;

	[ZZZZZZZZZZZZY(151675407)]
	internal static ZZZZZZZZZZZZZZZZZZB zzzzzzzzzzzzzzzzzzb_0;

	[ZZZZZZZZZZZZZT(2003218702)]
	internal static ZZZZZZZZZZZZZZZZZZc zzzzzzzzzzzzzzzzzzc_1;

	[ZZZZZZZZZZZZZZG(1312863239)]
	internal static ZZZZZZZZZZZZZZZZZR zzzzzzzzzzzzzzzzzr_4;

	[ZZZZZZZZZZZZY(1844918535)]
	internal static ZZZZZZZZZZZZZZZZZZC zzzzzzzzzzzzzzzzzzc_2;

	[ZZZZZZZZZZZZZZn(-633228420)]
	internal static ZZZZZZZZZZZZZZZZZZD zzzzzzzzzzzzzzzzzzd_0;

	[ZZZZZZZZZZZZZZj(-273376530)]
	internal static ZZZZZZZZZZZZC zzzzzzzzzzzzc_16;

	[ZZZZZZZZZZZZZZG(1275070403)]
	internal static ZZZZZZZZZZZZZZZZr zzzzzzzzzzzzzzzzr_3;

	[ZZZZZZZZZZZZZG(-1757415036)]
	internal static ZZZZZZZZZZZZZZZZZZa zzzzzzzzzzzzzzzzzza_2;

	[ZZZZZZZZZZZZZN(-788217839)]
	internal static ZZZZZZZZZZZZC zzzzzzzzzzzzc_17;

	[ZZZZZZZZZZZZZZG(-851146841)]
	internal static ZZZZZZZZZZZZZZf zzzzzzzzzzzzzzf_8;

	[ZZZZZZZZZZZZZm(-1170705839)]
	internal static ZZZZZZZZZZZZZZf zzzzzzzzzzzzzzf_9;

	[ZZZZZZZZZZZZZZG(1867394541)]
	internal static ZZZZZZZZZZZZZZZZj zzzzzzzzzzzzzzzzj_6;

	[ZZZZZZZZZZZZy(-1156740613)]
	internal static ZZZZZZZZZZZZZZZZZZF zzzzzzzzzzzzzzzzzzf_0;

	[ZZZZZZZZZZZZZs(-1294444427)]
	internal static ZZZZZZZZZZZZZZh zzzzzzzzzzzzzzh_2;

	[ZZZZZZZZZZZZZZn(556593636)]
	internal static ZZZZZZZZZZZZZZZZZZH zzzzzzzzzzzzzzzzzzh_0;

	[ZZZZZZZZZZZZR(-1765768660)]
	internal static ZZZZZZZZZZZZZZO zzzzzzzzzzzzzzo_20;

	[ZZZZZZZZZZZZZZG(1762144167)]
	internal static ZZZZZZZZZZZZZZO zzzzzzzzzzzzzzo_21;

	[ZZZZZZZZZZZZZZG(990795277)]
	internal static ZZZZZZZZZZZZZZO zzzzzzzzzzzzzzo_22;

	[ZZZZZZZZZZZZZT(415115656)]
	internal static ZZZZZZZZZZZZZZO zzzzzzzzzzzzzzo_23;

	[ZZZZZZZZZZZZZG(-137339872)]
	internal static ZZZZZZZZZZZZZZO zzzzzzzzzzzzzzo_24;

	[ZZZZZZZZZZZZZN(-1854830069)]
	internal static ZZZZZZZZZZZZZZO zzzzzzzzzzzzzzo_25;

	[ZZZZZZZZZZZZK(357348318)]
	internal static ZZZZZZZZZZZZZZO zzzzzzzzzzzzzzo_26;

	[ZZZZZZZZZZZZY(1500213845)]
	internal static ZZZZZZZZZZZZZZO zzzzzzzzzzzzzzo_27;

	[ZZZZZZZZZZZZy(-1327590021)]
	internal static ZZZZZZZZZZZZC zzzzzzzzzzzzc_18;

	[ZZZZZZZZZZZZZZn(424259152)]
	internal static ZZZZZZZZZZZZZZO zzzzzzzzzzzzzzo_28;

	[ZZZZZZZZZZZZZT(2117127158)]
	internal static ZZZZZZZZZZZZZZO zzzzzzzzzzzzzzo_29;

	[ZZZZZZZZZZZZZi(1539186254)]
	internal static ZZZZZZZZZZZZZZO zzzzzzzzzzzzzzo_30;

	[ZZZZZZZZZZZZE(1004917568)]
	internal static ZZZZZZZZZZZZZZO zzzzzzzzzzzzzzo_31;

	[ZZZZZZZZZZZZZT(629255342)]
	internal static ZZZZZZZZZZZZZZO zzzzzzzzzzzzzzo_32;

	[ZZZZZZZZZZZZZT(1265582608)]
	internal static ZZZZZZZZZZZZZZO zzzzzzzzzzzzzzo_33;

	[ZZZZZZZZZZZZZZn(-1863141534)]
	internal static ZZZZZZZZZZZZZZO zzzzzzzzzzzzzzo_34;

	[ZZZZZZZZZZZZY(-869077583)]
	internal static ZZZZZZZZZZZZZZO zzzzzzzzzzzzzzo_35;

	[ZZZZZZZZZZZZZZn(1848673472)]
	internal static ZZZZZZZZZZZZZZO zzzzzzzzzzzzzzo_36;

	[ZZZZZZZZZZZZZG(-1919279858)]
	internal static ZZZZZZZZZZZZZZO zzzzzzzzzzzzzzo_37;

	[ZZZZZZZZZZZZR(1827315230)]
	internal static ZZZZZZZZZZZZZZO zzzzzzzzzzzzzzo_38;

	[ZZZZZZZZZZZZZZG(1309280253)]
	internal static ZZZZZZZZZZZZZZO zzzzzzzzzzzzzzo_39;

	[ZZZZZZZZZZZZZT(1394107524)]
	internal static ZZZZZZZZZZZZZZy zzzzzzzzzzzzzzy_13;

	[ZZZZZZZZZZZZZN(-1364110329)]
	internal static ZZZZZZZZZZZZZZO zzzzzzzzzzzzzzo_40;

	[ZZZZZZZZZZZZR(570063570)]
	internal static ZZZZZZZZZZZZZZZZZZC zzzzzzzzzzzzzzzzzzc_3;

	[ZZZZZZZZZZZZZs(1334684631)]
	internal static ZZZZZZZZZZZZC zzzzzzzzzzzzc_19;

	[ZZZZZZZZZZZZZN(-976880349)]
	internal static ZZZZZZZZZZZZZZO zzzzzzzzzzzzzzo_41;

	[ZZZZZZZZZZZZZZn(-367327234)]
	internal static ZZZZZZZZZZZZZc zzzzzzzzzzzzzc_8;

	[ZZZZZZZZZZZZR(1682317676)]
	internal static ZZZZZZZZZZZZZZV zzzzzzzzzzzzzzv_2;

	[ZZZZZZZZZZZZY(-357830843)]
	internal static ZZZZZZZZZZZZZZZZZZO zzzzzzzzzzzzzzzzzzo_0;

	[ZZZZZZZZZZZZR(-82565574)]
	internal static ZZZZZZZZZZZZZZZZZZQ zzzzzzzzzzzzzzzzzzq_0;

	[ZZZZZZZZZZZZZs(1847596615)]
	internal static ZZZZZZZZZZZZC zzzzzzzzzzzzc_20;

	[ZZZZZZZZZZZZZZ(953600862)]
	internal static ZZZZZZZZZZZZZZZZZZS zzzzzzzzzzzzzzzzzzs_0;

	[ZZZZZZZZZZZZZe(-259624327)]
	internal static ZZZZZZZZZZZZZZZZj zzzzzzzzzzzzzzzzj_7;

	[ZZZZZZZZZZZZZs(498044785)]
	internal static ZZZZZZZZZZZZZZZZZZU zzzzzzzzzzzzzzzzzzu_0;

	[ZZZZZZZZZZZZZZ(-1299762622)]
	internal static ZZZZZZZZZZZZZZZZZZW zzzzzzzzzzzzzzzzzzw_0;

	[ZZZZZZZZZZZZy(1229465701)]
	internal static ZZZZZZZZZZZZZZZZZZY zzzzzzzzzzzzzzzzzzy_0;

	[ZZZZZZZZZZZZZN(-1645470505)]
	internal static ZZZZZZZZZZZZC zzzzzzzzzzzzc_21;

	[ZZZZZZZZZZZZZT(1274973662)]
	internal static ZZZZZZZZZZZZZZZZZZZa zzzzzzzzzzzzzzzzzzza_0;

	[ZZZZZZZZZZZZE(-1949311974)]
	internal static ZZZZZZZZZZZZZZZZZZZc zzzzzzzzzzzzzzzzzzzc_0;

	[ZZZZZZZZZZZZZi(-377726946)]
	internal static ZZZZZZZZZZZZZZZZZZZe zzzzzzzzzzzzzzzzzzze_0;

	[ZZZZZZZZZZZZR(-1795989302)]
	internal static ZZZZZZZZZZZZZZZZZZZh zzzzzzzzzzzzzzzzzzzh_0;

	[ZZZZZZZZZZZZZm(-96086483)]
	internal static ZZZZZZZZZZZZZZZZZZZk zzzzzzzzzzzzzzzzzzzk_0;

	[ZZZZZZZZZZZZR(-103169684)]
	internal static ZZZZZZZZZZZZZZZZZV zzzzzzzzzzzzzzzzzv_3;

	[ZZZZZZZZZZZZZZn(844878282)]
	internal static ZZZZZZZZZZZZZZZZZZZn zzzzzzzzzzzzzzzzzzzn_0;

	[ZZZZZZZZZZZZE(1244418182)]
	internal static ZZZZZZZZZZZZZZZZZZZp zzzzzzzzzzzzzzzzzzzp_0;

	[ZZZZZZZZZZZZZT(-1036031970)]
	internal static ZZZZZZZZZZZZZZZZZZZr zzzzzzzzzzzzzzzzzzzr_0;

	[ZZZZZZZZZZZZZZG(1794956061)]
	internal static ZZZZZZZZZZZZZZZZZV zzzzzzzzzzzzzzzzzv_4;

	[ZZZZZZZZZZZZZG(-1428373560)]
	internal static ZZZZZZZZZZZZZZZZZZZt zzzzzzzzzzzzzzzzzzzt_0;

	[ZZZZZZZZZZZZZN(404736793)]
	internal static ZZZZZZZZZZZZZZZZZZZv zzzzzzzzzzzzzzzzzzzv_0;

	[ZZZZZZZZZZZZZZ(-1553123288)]
	internal static ZZZZZZZZZZZZZZZZe zzzzzzzzzzzzzzzze_4;

	[ZZZZZZZZZZZZZi(1589205566)]
	internal static ZZZZZZZZZZZZZZZZe zzzzzzzzzzzzzzzze_5;

	[ZZZZZZZZZZZZZT(-2097232712)]
	internal static ZZZZZZZZZZZZZZZZZZZx zzzzzzzzzzzzzzzzzzzx_0;

	[ZZZZZZZZZZZZZN(-1354531433)]
	internal static ZZZZZZZZZZZZZZZZZZZz zzzzzzzzzzzzzzzzzzzz_0;

	[ZZZZZZZZZZZZZN(443586001)]
	internal static ZZZZZZZZZZZZZZZZZZZB zzzzzzzzzzzzzzzzzzzb_0;

	[ZZZZZZZZZZZZZs(-811942979)]
	internal static ZZZZZZZZZZZZZZZZZV zzzzzzzzzzzzzzzzzv_5;

	[ZZZZZZZZZZZZY(345259051)]
	internal static ZZZZZZZZZZZZZZZZZZZD zzzzzzzzzzzzzzzzzzzd_0;

	[ZZZZZZZZZZZZZZj(-1102935890)]
	internal static ZZZZZZZZZZZZZZZZZZZF zzzzzzzzzzzzzzzzzzzf_0;

	[ZZZZZZZZZZZZZe(-1234373133)]
	internal static ZZZZZZZZZZZZZZZZZy zzzzzzzzzzzzzzzzzy_5;

	[ZZZZZZZZZZZZE(-1618541514)]
	internal static ZZZZZZZZZZZZZZZZZZZH zzzzzzzzzzzzzzzzzzzh_1;

	[ZZZZZZZZZZZZE(-873854662)]
	internal static ZZZZZZZZZZZZZZZZZZZJ zzzzzzzzzzzzzzzzzzzj_0;

	[ZZZZZZZZZZZZZT(736633760)]
	internal static ZZZZZZZZZZZZZZZZZZZL zzzzzzzzzzzzzzzzzzzl_0;

	[ZZZZZZZZZZZZy(1240537983)]
	internal static ZZZZZZZZZZZZZZZZZy zzzzzzzzzzzzzzzzzy_6;

	[ZZZZZZZZZZZZY(1166440207)]
	internal static ZZZZZZZZZZZZZZZZj zzzzzzzzzzzzzzzzj_8;

	[ZZZZZZZZZZZZR(-1481350082)]
	internal static ZZZZZZZZZZZZZZZZg zzzzzzzzzzzzzzzzg_3;

	[ZZZZZZZZZZZZE(1966651946)]
	internal static ZZZZZZZZZZZZC zzzzzzzzzzzzc_22;

	[ZZZZZZZZZZZZZi(1886111458)]
	internal static ZZZZZZZZZZZZZZZZZZZN zzzzzzzzzzzzzzzzzzzn_1;

	[ZZZZZZZZZZZZZZj(2102583902)]
	internal static ZZZZZZZZZZZZZZZZZZZP zzzzzzzzzzzzzzzzzzzp_1;

	[ZZZZZZZZZZZZZT(1634921928)]
	internal static ZZZZZZZZZZZZZZZZZZZR zzzzzzzzzzzzzzzzzzzr_1;

	[ZZZZZZZZZZZZK(-1534330804)]
	internal static ZZZZZZZZZZZZZZZZZZZT zzzzzzzzzzzzzzzzzzzt_1;

	[ZZZZZZZZZZZZZT(1617677170)]
	internal static ZZZZZZZZZZZZZZZZZZZV zzzzzzzzzzzzzzzzzzzv_1;

	[ZZZZZZZZZZZZy(1316641491)]
	internal static ZZZZZZZZZZZZZZZZZy zzzzzzzzzzzzzzzzzy_7;

	[ZZZZZZZZZZZZZe(-692431091)]
	internal static ZZZZZZZZZZZZZZZZZZZX zzzzzzzzzzzzzzzzzzzx_1;

	[ZZZZZZZZZZZZZT(-1726368636)]
	internal static ZZZZZZZZZZZZZZZZZZZZ zzzzzzzzzzzzzzzzzzzz_1;

	[ZZZZZZZZZZZZZZ(-1708149324)]
	internal static ZZZZZZZZZZZZZZZZZZZZb zzzzzzzzzzzzzzzzzzzzb_0;

	[ZZZZZZZZZZZZZZn(350478778)]
	internal static ZZZZZZZZZZZZC zzzzzzzzzzzzc_23;

	[ZZZZZZZZZZZZZT(-679936832)]
	internal static ZZZZZZZZZZZZZZZZZZZZe zzzzzzzzzzzzzzzzzzzze_0;

	[ZZZZZZZZZZZZZe(290598233)]
	internal static ZZZZZZZZZZZZZZZZZZZZh zzzzzzzzzzzzzzzzzzzzh_0;

	[ZZZZZZZZZZZZE(1349752020)]
	internal static ZZZZZZZZZZZZZZZZZZZZj zzzzzzzzzzzzzzzzzzzzj_0;

	[ZZZZZZZZZZZZE(1180593182)]
	internal static ZZZZZZZZZZZZZZZZZZn zzzzzzzzzzzzzzzzzzn_1;

	[ZZZZZZZZZZZZZN(-1149426271)]
	internal static ZZZZZZZZZZZZZZy zzzzzzzzzzzzzzy_14;

	[ZZZZZZZZZZZZy(1059604309)]
	internal static ZZZZZZZZZZZZZL zzzzzzzzzzzzzl_3;

	[ZZZZZZZZZZZZZm(1580273643)]
	internal static ZZZZZZZZZZZZC zzzzzzzzzzzzc_24;

	[ZZZZZZZZZZZZZT(607647956)]
	internal static ZZZZZZZZZZZZZZZZZZZZl zzzzzzzzzzzzzzzzzzzzl_0;

	[ZZZZZZZZZZZZZT(-1434278072)]
	internal static ZZZZZZZZZZZZZZZZZZZZn zzzzzzzzzzzzzzzzzzzzn_0;

	[ZZZZZZZZZZZZZi(-174614426)]
	internal static ZZZZZZZZZZZZZZZZZZZZp zzzzzzzzzzzzzzzzzzzzp_0;

	[ZZZZZZZZZZZZZi(-209979412)]
	internal static ZZZZZZZZZZZZZZZZZZZZr zzzzzzzzzzzzzzzzzzzzr_0;

	[ZZZZZZZZZZZZE(1657732200)]
	internal static ZZZZZZZZZZZZZZZZZZZZr zzzzzzzzzzzzzzzzzzzzr_1;

	[ZZZZZZZZZZZZE(1548105810)]
	internal static ZZZZZZZZZZZZZZZZZZZZt zzzzzzzzzzzzzzzzzzzzt_0;

	[ZZZZZZZZZZZZy(-2039661819)]
	internal static ZZZZZZZZZZZZZZZZZZZZv zzzzzzzzzzzzzzzzzzzzv_0;

	[ZZZZZZZZZZZZZZG(1772336247)]
	internal static ZZZZZZZZZZZZZZZZZZZZy zzzzzzzzzzzzzzzzzzzzy_0;

	[ZZZZZZZZZZZZR(-1027075526)]
	internal static ZZZZZZZZZZZZZZZQ zzzzzzzzzzzzzzzq_4;

	[ZZZZZZZZZZZZZs(-588243463)]
	internal static ZZZZZZZZZZZZZZZZZZZZv zzzzzzzzzzzzzzzzzzzzv_1;

	[ZZZZZZZZZZZZK(-797425340)]
	internal static ZZZZZZZZZZZZZZZZZZZZp zzzzzzzzzzzzzzzzzzzzp_1;

	[ZZZZZZZZZZZZZi(770804156)]
	internal static ZZZZZZZZZZZZZZZQ zzzzzzzzzzzzzzzq_5;

	[ZZZZZZZZZZZZZm(-1077346831)]
	internal static ZZZZZZZZZZZZZZZZZZZZC zzzzzzzzzzzzzzzzzzzzc_0;

	[ZZZZZZZZZZZZZe(-360614059)]
	internal static ZZZZZZZZZZZZZZZZZZZZt zzzzzzzzzzzzzzzzzzzzt_1;

	[ZZZZZZZZZZZZZN(-1621127319)]
	internal static ZZZZZZZZZZZZC zzzzzzzzzzzzc_25;

	[ZZZZZZZZZZZZy(1185233663)]
	internal static ZZZZZZZZZZZZZZZZZZZZE zzzzzzzzzzzzzzzzzzzze_1;

	[ZZZZZZZZZZZZZZj(1640296820)]
	internal static ZZZZZZZZZZZZZZZZZZZZn zzzzzzzzzzzzzzzzzzzzn_1;

	[ZZZZZZZZZZZZy(1768754065)]
	internal static ZZZZZZZZZZZZZZZZe zzzzzzzzzzzzzzzze_6;

	[ZZZZZZZZZZZZZi(-232117616)]
	internal static ZZZZZZZZZZZZC zzzzzzzzzzzzc_26;

	[ZZZZZZZZZZZZZm(1335951997)]
	internal static ZZZZZZZZZZZZZZZZZZZZr zzzzzzzzzzzzzzzzzzzzr_2;

	[ZZZZZZZZZZZZZe(-1927111913)]
	internal static ZZZZZZZZZZZZZZZZZZZZF zzzzzzzzzzzzzzzzzzzzf_0;

	[ZZZZZZZZZZZZZN(1776460523)]
	internal static ZZZZZZZZZZZZZZZZZZZZv zzzzzzzzzzzzzzzzzzzzv_2;

	[ZZZZZZZZZZZZE(1358608038)]
	internal static ZZZZZZZZZZZZZZZZZZZZG zzzzzzzzzzzzzzzzzzzzg_0;

	[ZZZZZZZZZZZZZZn(1619803088)]
	internal static ZZZZZZZZZZZZC zzzzzzzzzzzzc_27;

	[ZZZZZZZZZZZZZG(-1315435738)]
	internal static ZZZZZZZZZZZZC zzzzzzzzzzzzc_28;

	[ZZZZZZZZZZZZZZ(1302296386)]
	internal static ZZZZZZZZZZZZZZZZZZZZH zzzzzzzzzzzzzzzzzzzzh_1;

	[ZZZZZZZZZZZZZZ(234704972)]
	internal static ZZZZZZZZZZZZC zzzzzzzzzzzzc_29;

	[ZZZZZZZZZZZZZe(-1193370655)]
	internal static ZZZZZZZZZZZZZc zzzzzzzzzzzzzc_9;

	[ZZZZZZZZZZZZZZG(-228845063)]
	internal static ZZZZZZZZZZZZZZZZZZZZJ zzzzzzzzzzzzzzzzzzzzj_1;

	[ZZZZZZZZZZZZZe(2134246019)]
	internal static ZZZZZZZZZZZZZZZZZZc zzzzzzzzzzzzzzzzzzc_4;

	[ZZZZZZZZZZZZR(-1885640570)]
	internal static ZZZZZZZZZZZZZZZZZy zzzzzzzzzzzzzzzzzy_8;

	[ZZZZZZZZZZZZZZG(1909196785)]
	internal static ZZZZZZZZZZZZZZZZZZZZL zzzzzzzzzzzzzzzzzzzzl_1;

	[ZZZZZZZZZZZZZe(434059723)]
	internal static ZZZZZZZZZZZZZZf zzzzzzzzzzzzzzf_10;

	[ZZZZZZZZZZZZZT(2070891296)]
	internal static ZZZZZZZZZZZZZZf zzzzzzzzzzzzzzf_11;

	[ZZZZZZZZZZZZZZj(515943140)]
	internal static ZZZZZZZZZZZZZZf zzzzzzzzzzzzzzf_12;

	[ZZZZZZZZZZZZZZj(-701951618)]
	internal static ZZZZZZZZZZZZZZf zzzzzzzzzzzzzzf_13;

	[ZZZZZZZZZZZZZG(453508424)]
	internal static ZZZZZZZZZZZZC zzzzzzzzzzzzc_30;

	[ZZZZZZZZZZZZK(1675563430)]
	internal static ZZZZZZZZZZZZC zzzzzzzzzzzzc_31;

	[ZZZZZZZZZZZZZe(-138699781)]
	internal static ZZZZZZZZZZZZZZZZZZZZP zzzzzzzzzzzzzzzzzzzzp_2;

	[ZZZZZZZZZZZZZT(-1651471328)]
	internal static ZZZZZZZZZZZZZZZZZZc zzzzzzzzzzzzzzzzzzc_5;

	[ZZZZZZZZZZZZR(1368878532)]
	internal static ZZZZZZZZZZZZC zzzzzzzzzzzzc_32;

	[ZZZZZZZZZZZZZZ(431354468)]
	internal static ZZZZZZZZZZZZC zzzzzzzzzzzzc_33;

	[ZZZZZZZZZZZZZZn(-558664084)]
	internal static ZZZZZZZZZZZZC zzzzzzzzzzzzc_34;

	[ZZZZZZZZZZZZK(865138694)]
	internal static ZZZZZZZZZZZZZZZZj zzzzzzzzzzzzzzzzj_9;

	[ZZZZZZZZZZZZZZn(-1935241586)]
	internal static ZZZZZZZZZZZZZZZZj zzzzzzzzzzzzzzzzj_10;

	[ZZZZZZZZZZZZK(-625675622)]
	internal static ZZZZZZZZZZZZZZZZZZZZR zzzzzzzzzzzzzzzzzzzzr_3;

	[ZZZZZZZZZZZZZZj(1521538486)]
	internal static ZZZZZZZZZZZZZZZZZZZZT zzzzzzzzzzzzzzzzzzzzt_2;

	[ZZZZZZZZZZZZK(-667401324)]
	internal static ZZZZZZZZZZZZZZZZZZZZV zzzzzzzzzzzzzzzzzzzzv_3;

	[ZZZZZZZZZZZZZN(-560782503)]
	internal static ZZZZZZZZZZZZC zzzzzzzzzzzzc_35;

	[ZZZZZZZZZZZZy(-1993115111)]
	internal static ZZZZZZZZZZZZC zzzzzzzzzzzzc_36;

	[ZZZZZZZZZZZZE(51955848)]
	internal static ZZZZZZZZZZZZZZZZp zzzzzzzzzzzzzzzzp_3;

	[ZZZZZZZZZZZZZT(-2087438920)]
	internal static ZZZZZZZZZZZZZZZZZZc zzzzzzzzzzzzzzzzzzc_6;

	[ZZZZZZZZZZZZZN(-985294579)]
	internal static ZZZZZZZZZZZZC zzzzzzzzzzzzc_37;

	[ZZZZZZZZZZZZZe(53279173)]
	internal static ZZZZZZZZZZZZC zzzzzzzzzzzzc_38;

	[ZZZZZZZZZZZZZZj(-1622717608)]
	internal static ZZZZZZZZZZZZZZZZZZZZX zzzzzzzzzzzzzzzzzzzzx_0;

	[ZZZZZZZZZZZZZN(127844375)]
	internal static ZZZZZZZZZZZZZZZY zzzzzzzzzzzzzzzy_2;

	[ZZZZZZZZZZZZY(1947308419)]
	internal static ZZZZZZZZZZZZZZZZZy zzzzzzzzzzzzzzzzzy_9;

	[ZZZZZZZZZZZZK(1447845608)]
	internal static ZZZZZZZZZZZZZZZZj zzzzzzzzzzzzzzzzj_11;

	[ZZZZZZZZZZZZK(-1199096060)]
	internal static ZZZZZZZZZZZZZZZZZO zzzzzzzzzzzzzzzzzo_1;

	[ZZZZZZZZZZZZE(1190218048)]
	internal static ZZZZZZZZZZZZZZZZZZZZZ zzzzzzzzzzzzzzzzzzzzz_0;

	[ZZZZZZZZZZZZZT(-1315919228)]
	internal static ZZZZZZZZZZZZZZZZZZZZZb zzzzzzzzzzzzzzzzzzzzzb_0;

	[ZZZZZZZZZZZZZi(898660012)]
	internal static ZZZZZZZZZZZZZZZZZZZZZd zzzzzzzzzzzzzzzzzzzzzd_0;

	[ZZZZZZZZZZZZE(810682046)]
	internal static ZZZZZZZZZZZZZZZZZZZZZf zzzzzzzzzzzzzzzzzzzzzf_0;

	[ZZZZZZZZZZZZZZG(386908985)]
	internal static ZZZZZZZZZZZZZZZZZZZZL zzzzzzzzzzzzzzzzzzzzl_2;

	[ZZZZZZZZZZZZE(-1313383862)]
	internal static ZZZZZZZZZZZZZZy zzzzzzzzzzzzzzy_15;

	[ZZZZZZZZZZZZK(1532689714)]
	internal static ZZZZZZZZZZZZC zzzzzzzzzzzzc_39;

	[ZZZZZZZZZZZZE(-1910852410)]
	internal static ZZZZZZZZZZZZZZZZZZZB zzzzzzzzzzzzzzzzzzzb_1;

	[ZZZZZZZZZZZZR(-189062550)]
	internal static ZZZZZZZZZZZZZZZZZZZZZh zzzzzzzzzzzzzzzzzzzzzh_0;

	[ZZZZZZZZZZZZZZn(-78760238)]
	internal static ZZZZZZZZZZZZZZQ zzzzzzzzzzzzzzq_1;

	[ZZZZZZZZZZZZZZj(-392317364)]
	internal static ZZZZZZZZZZZZZZZZZZZZL zzzzzzzzzzzzzzzzzzzzl_3;

	[ZZZZZZZZZZZZZe(768584475)]
	internal static ZZZZZZZZZZZZC zzzzzzzzzzzzc_40;

	[ZZZZZZZZZZZZy(-1049164587)]
	internal static ZZZZZZZZZZZZC zzzzzzzzzzzzc_41;

	[ZZZZZZZZZZZZZZn(-1620993030)]
	internal static ZZZZZZZZZZZZZZZZZZZB zzzzzzzzzzzzzzzzzzzb_2;

	[ZZZZZZZZZZZZZm(2018175997)]
	internal static ZZZZZZZZZZZZZZZZZZZZZj zzzzzzzzzzzzzzzzzzzzzj_0;

	[ZZZZZZZZZZZZZi(784854620)]
	internal static ZZZZZZZZZZZZZZh zzzzzzzzzzzzzzh_3;

	[ZZZZZZZZZZZZZZn(-1355451548)]
	internal static ZZZZZZZZZZZZZZZZZZZZZl zzzzzzzzzzzzzzzzzzzzzl_0;

	[ZZZZZZZZZZZZZZ(1700244828)]
	internal static ZZZZZZZZZZZZC zzzzzzzzzzzzc_42;

	[ZZZZZZZZZZZZZZG(361345861)]
	internal static ZZZZZZZZZZZZZZZZj zzzzzzzzzzzzzzzzj_12;

	[ZZZZZZZZZZZZZT(-2065936332)]
	internal static ZZZZZZZZZZZZZZZZZZZZZn zzzzzzzzzzzzzzzzzzzzzn_0;

	[ZZZZZZZZZZZZZG(1836201984)]
	internal static ZZZZZZZZZZZZZZZZZZZZZp zzzzzzzzzzzzzzzzzzzzzp_0;

	[ZZZZZZZZZZZZZZ(-1102129612)]
	internal static ZZZZZZZZZZZZZZZZZZZZZr zzzzzzzzzzzzzzzzzzzzzr_0;

	[ZZZZZZZZZZZZZZ(-120826424)]
	internal static ZZZZZZZZZZZZC zzzzzzzzzzzzc_43;

	[ZZZZZZZZZZZZZN(1637250001)]
	internal static ZZZZZZZZZZZZZZZZj zzzzzzzzzzzzzzzzj_13;

	[ZZZZZZZZZZZZZs(411737285)]
	internal static ZZZZZZZZZZZZZZZZZZZZZt zzzzzzzzzzzzzzzzzzzzzt_0;

	[ZZZZZZZZZZZZZi(462610276)]
	internal static ZZZZZZZZZZZZZZZZZZZZZv zzzzzzzzzzzzzzzzzzzzzv_0;

	[ZZZZZZZZZZZZy(-99996837)]
	internal static ZZZZZZZZZZZZZZZZZO zzzzzzzzzzzzzzzzzo_2;

	[ZZZZZZZZZZZZZZj(-476121286)]
	internal static ZZZZZZZZZZZZZZZZZZZZZx zzzzzzzzzzzzzzzzzzzzzx_0;

	[ZZZZZZZZZZZZE(-1387363418)]
	internal static ZZZZZZZZZZZZZZZZj zzzzzzzzzzzzzzzzj_14;

	[ZZZZZZZZZZZZZi(-1872024384)]
	internal static ZZZZZZZZZZZZZZZZZZZZZz zzzzzzzzzzzzzzzzzzzzzz_0;

	[ZZZZZZZZZZZZZZj(-705679256)]
	internal static ZZZZZZZZZZZZZZZZj zzzzzzzzzzzzzzzzj_15;

	[ZZZZZZZZZZZZE(-115560410)]
	internal static ZZZZZZZZZZZZC zzzzzzzzzzzzc_44;

	[ZZZZZZZZZZZZZe(-1309740679)]
	internal static ZZZZZZZZZZZZC zzzzzzzzzzzzc_45;

	[ZZZZZZZZZZZZY(1733975083)]
	internal static ZZZZZZZZZZZZC zzzzzzzzzzzzc_46;

	[ZZZZZZZZZZZZZe(1916248147)]
	internal static ZZZZZZZZZZZZZZf zzzzzzzzzzzzzzf_14;

	[ZZZZZZZZZZZZZi(-2071808768)]
	internal static ZZZZZZZZZZZZZL zzzzzzzzzzzzzl_4;

	[ZZZZZZZZZZZZZi(2123891410)]
	internal static ZZZZZZZZZZZZC zzzzzzzzzzzzc_47;

	[ZZZZZZZZZZZZZZn(988707840)]
	internal static ZZZZZZZZZZZZI zzzzzzzzzzzzi_2;

	[ZZZZZZZZZZZZK(-1128750180)]
	internal static ZZZZZZZZZZZZZZZZZZZZZD zzzzzzzzzzzzzzzzzzzzzd_1;

	[ZZZZZZZZZZZZZT(1052627404)]
	internal static ZZZZZZZZZZZZZZZZZZZN zzzzzzzzzzzzzzzzzzzn_2;

	[ZZZZZZZZZZZZZm(285567635)]
	internal static ZZZZZZZZZZZZZZZZZZZZZF zzzzzzzzzzzzzzzzzzzzzf_1;

	[ZZZZZZZZZZZZZe(731126861)]
	internal static ZZZZZZZZZZZZZZQ zzzzzzzzzzzzzzq_2;

	[ZZZZZZZZZZZZZe(-1226896841)]
	internal static ZZZZZZZZZZZZZZZZZZZZZH zzzzzzzzzzzzzzzzzzzzzh_1;

	[ZZZZZZZZZZZZZe(-1944208679)]
	internal static ZZZZZZZZZZZZC zzzzzzzzzzzzc_48;

	[ZZZZZZZZZZZZZZ(526196846)]
	internal static ZZZZZZZZZZZZZZf zzzzzzzzzzzzzzf_15;

	[ZZZZZZZZZZZZZe(-151185317)]
	internal static ZZZZZZZZZZZZZZf zzzzzzzzzzzzzzf_16;

	[ZZZZZZZZZZZZZe(876656723)]
	internal static ZZZZZZZZZZZZC zzzzzzzzzzzzc_49;

	[ZZZZZZZZZZZZZZG(1969843997)]
	internal static ZZZZZZZZZZZZZZZZZZZZZI zzzzzzzzzzzzzzzzzzzzzi_0;

	[ZZZZZZZZZZZZZZG(-141076299)]
	internal static ZZZZZZZZZZZZZZZZZZZZZK zzzzzzzzzzzzzzzzzzzzzk_0;

	[ZZZZZZZZZZZZK(1488668706)]
	internal static ZZZZZZZZZZZZZZZZZZZZZL zzzzzzzzzzzzzzzzzzzzzl_1;

	[ZZZZZZZZZZZZZZG(817044235)]
	internal static ZZZZZZZZZZZZZZf zzzzzzzzzzzzzzf_17;

	[ZZZZZZZZZZZZZZn(-343712238)]
	internal static ZZZZZZZZZZZZZZZZZZZZZM zzzzzzzzzzzzzzzzzzzzzm_0;

	[ZZZZZZZZZZZZy(874734117)]
	internal static ZZZZZZZZZZZZZZZZZZZZZO zzzzzzzzzzzzzzzzzzzzzo_0;

	[ZZZZZZZZZZZZK(-2084082964)]
	internal static ZZZZZZZZZZZZC zzzzzzzzzzzzc_50;

	[ZZZZZZZZZZZZZi(-176951282)]
	internal static ZZZZZZZZZZZZC zzzzzzzzzzzzc_51;

	[ZZZZZZZZZZZZZN(1443323593)]
	internal static ZZZZZZZZZZZZC zzzzzzzzzzzzc_52;

	[ZZZZZZZZZZZZZZn(-1877087560)]
	internal static ZZZZZZZZZZZZC zzzzzzzzzzzzc_53;

	[ZZZZZZZZZZZZZZj(-73131580)]
	internal static ZZZZZZZZZZZZC zzzzzzzzzzzzc_54;

	[ZZZZZZZZZZZZZN(31213983)]
	internal static ZZZZZZZZZZZZC zzzzzzzzzzzzc_55;

	[ZZZZZZZZZZZZZs(-1140460657)]
	internal static ZZZZZZZZZZZZZZZZj zzzzzzzzzzzzzzzzj_16;

	[ZZZZZZZZZZZZZe(-1574319809)]
	internal static ZZZZZZZZZZZZZZZZZZZZZQ zzzzzzzzzzzzzzzzzzzzzq_0;

	[ZZZZZZZZZZZZE(2080226994)]
	internal static ZZZZZZZZZZZZZZr zzzzzzzzzzzzzzr_1;

	[ZZZZZZZZZZZZZZG(-1806853085)]
	internal static ZZZZZZZZZZZZZZZZZV zzzzzzzzzzzzzzzzzv_6;

	[ZZZZZZZZZZZZZG(-16987078)]
	internal static ZZZZZZZZZZZZZZZZZZZZZQ zzzzzzzzzzzzzzzzzzzzzq_1;

	[ZZZZZZZZZZZZE(1650371686)]
	internal static ZZZZZZZZZZZZC zzzzzzzzzzzzc_56;

	[ZZZZZZZZZZZZZm(-821199319)]
	internal static ZZZZZZZZZZZZZL zzzzzzzzzzzzzl_5;

	[ZZZZZZZZZZZZZT(119694988)]
	internal static ZZZZZZZZZZZZZZZZZZZZZb zzzzzzzzzzzzzzzzzzzzzb_1;

	[ZZZZZZZZZZZZE(6126414)]
	internal static ZZZZZZZZZZZZZZf zzzzzzzzzzzzzzf_18;

	[ZZZZZZZZZZZZZs(1804950695)]
	internal static ZZZZZZZZZZZZC zzzzzzzzzzzzc_57;

	[ZZZZZZZZZZZZZe(240939293)]
	internal static ZZZZZZZZZZZZZZZZj zzzzzzzzzzzzzzzzj_17;

	[ZZZZZZZZZZZZR(-1468615342)]
	internal static ZZZZZZZZZZZZZZZZj zzzzzzzzzzzzzzzzj_18;

	[ZZZZZZZZZZZZZZn(1287399590)]
	internal static ZZZZZZZZZZZZZZf zzzzzzzzzzzzzzf_19;

	[ZZZZZZZZZZZZZi(-765256310)]
	internal static ZZZZZZZZZZZZZZZZj zzzzzzzzzzzzzzzzj_19;

	[ZZZZZZZZZZZZZZ(-63385204)]
	internal static ZZZZZZZZZZZZZZZZZy zzzzzzzzzzzzzzzzzy_10;

	[ZZZZZZZZZZZZZs(202213941)]
	internal static ZZZZZZZZZZZZZZZZg zzzzzzzzzzzzzzzzg_4;

	[ZZZZZZZZZZZZK(-877962384)]
	internal static ZZZZZZZZZZZZZZZZZZZZZ zzzzzzzzzzzzzzzzzzzzz_1;

	[ZZZZZZZZZZZZZZn(-2100102554)]
	internal static ZZZZZZZZZZZZZZZZZZZZZV zzzzzzzzzzzzzzzzzzzzzv_1;

	[ZZZZZZZZZZZZZZG(503872987)]
	internal static ZZZZZZZZZZZZZZZZZZZZZX zzzzzzzzzzzzzzzzzzzzzx_1;

	[ZZZZZZZZZZZZZi(167227030)]
	internal static ZZZZZZZZZZZZZZZZZZZZZZ zzzzzzzzzzzzzzzzzzzzzz_1;

	[ZZZZZZZZZZZZY(-1217030339)]
	internal static ZZZZZZZZZZZZZZZZZZZZZZb zzzzzzzzzzzzzzzzzzzzzzb_0;

	[ZZZZZZZZZZZZZZ(-149145004)]
	internal static ZZZZZZZZZZZZZZZZZZZZZZd zzzzzzzzzzzzzzzzzzzzzzd_0;

	[ZZZZZZZZZZZZZe(1261659903)]
	internal static ZZZZZZZZZZZZZZZZZZZZZZf zzzzzzzzzzzzzzzzzzzzzzf_0;

	[ZZZZZZZZZZZZZZn(-459097152)]
	internal static ZZZZZZZZZZZZZZZZZZZZZZh zzzzzzzzzzzzzzzzzzzzzzh_0;

	[ZZZZZZZZZZZZR(-984025304)]
	internal static ZZZZZZZZZZZZZZZZZZZZb zzzzzzzzzzzzzzzzzzzzb_1;

	public static Type ZZZZZZZZZZZZZZZZZZZZZZZX;

	public static Marshal ZZZZZZZZZZZZZZZZZZZZZZZY;

	public static IntPtr ZZZZZZZZZZZZZZZZZZZZZZZZ;

	public static string ZZZZZZZZZZZZZZZZZZZZZZZZa;

	public static Math ZZZZZZZZZZZZZZZZZZZZZZZZb;

	public static Buffer ZZZZZZZZZZZZZZZZZZZZZZZZc;

	public static Encoding ZZZZZZZZZZZZZZZZZZZZZZZZd;

	public static DateTime ZZZZZZZZZZZZZZZZZZZZZZZZe;

	public static Thread ZZZZZZZZZZZZZZZZZZZZZZZZf;

	public static StringBuilder ZZZZZZZZZZZZZZZZZZZZZZZZg;

	public static ProcessStartInfo ZZZZZZZZZZZZZZZZZZZZZZZZh;

	public static Process ZZZZZZZZZZZZZZZZZZZZZZZZi;

	public static Win32Exception ZZZZZZZZZZZZZZZZZZZZZZZZj;

	public static ServiceController ZZZZZZZZZZZZZZZZZZZZZZZZk;

	public static AppDomain ZZZZZZZZZZZZZZZZZZZZZZZZl;

	public static ManagementObjectEnumerator ZZZZZZZZZZZZZZZZZZZZZZZZm;

	public static ManagementBaseObject ZZZZZZZZZZZZZZZZZZZZZZZZn;

	public static DriveInfo ZZZZZZZZZZZZZZZZZZZZZZZZo;

	public static Environment ZZZZZZZZZZZZZZZZZZZZZZZZp;

	public static CompilerParameters ZZZZZZZZZZZZZZZZZZZZZZZZq;

	public static CompilerResults ZZZZZZZZZZZZZZZZZZZZZZZZr;

	public static CompilerErrorCollection ZZZZZZZZZZZZZZZZZZZZZZZZs;

	public static StreamReader ZZZZZZZZZZZZZZZZZZZZZZZZt;

	public static Delegate ZZZZZZZZZZZZZZZZZZZZZZZZu;

	public static UnhandledExceptionEventArgs ZZZZZZZZZZZZZZZZZZZZZZZZv;

	public static TimeSpan ZZZZZZZZZZZZZZZZZZZZZZZZw;

	public static StringFormat ZZZZZZZZZZZZZZZZZZZZZZZZx;

	public static Brushes ZZZZZZZZZZZZZZZZZZZZZZZZy;

	public static RectangleF ZZZZZZZZZZZZZZZZZZZZZZZZz;

	public static Image ZZZZZZZZZZZZZZZZZZZZZZZZA;

	public static ImageFormat ZZZZZZZZZZZZZZZZZZZZZZZZB;

	public static decimal ZZZZZZZZZZZZZZZZZZZZZZZZC;

	public static uint ZZZZZZZZZZZZZZZZZZZZZZZZD;

	public static TimeZone ZZZZZZZZZZZZZZZZZZZZZZZZE;

	public static RegionInfo ZZZZZZZZZZZZZZZZZZZZZZZZF;

	public static GCHandle ZZZZZZZZZZZZZZZZZZZZZZZZG;

	public static ServicePointManager ZZZZZZZZZZZZZZZZZZZZZZZZH;

	public static GroupCollection ZZZZZZZZZZZZZZZZZZZZZZZZI;

	public static Capture ZZZZZZZZZZZZZZZZZZZZZZZZJ;

	public static InputLanguage ZZZZZZZZZZZZZZZZZZZZZZZZK;

	public static UdpClient ZZZZZZZZZZZZZZZZZZZZZZZZL;

	public static Socket ZZZZZZZZZZZZZZZZZZZZZZZZM;

	public static IPAddress ZZZZZZZZZZZZZZZZZZZZZZZZN;

	public static PrintDocument ZZZZZZZZZZZZZZZZZZZZZZZZO;

	public static PrinterSettings ZZZZZZZZZZZZZZZZZZZZZZZZP;

	public static PageSettings ZZZZZZZZZZZZZZZZZZZZZZZZQ;

	public static Margins ZZZZZZZZZZZZZZZZZZZZZZZZR;

	public static PrintPageEventArgs ZZZZZZZZZZZZZZZZZZZZZZZZS;

	public static Rectangle ZZZZZZZZZZZZZZZZZZZZZZZZT;

	public static Graphics ZZZZZZZZZZZZZZZZZZZZZZZZU;

	public static SizeF ZZZZZZZZZZZZZZZZZZZZZZZZV;

	public static PaperSize ZZZZZZZZZZZZZZZZZZZZZZZZW;

	public static UIntPtr ZZZZZZZZZZZZZZZZZZZZZZZZX;

	public static ZZZZZZZZZZZZZZZZZZZZZZZZY ZZZZZZZZZZZZZZZZZZZZZZZZZ/* Not supported: data(61 C0 1B 1B 06 32 41 ED E6 00 8A 61 F9 76 8D F5 3B 9A 81 91 DE 3A 67 85 55 D0 0C F6 E1 8D 4C 10 CF 08 13 58 C0 08 CE 08 99 42 6F E7 33 9A 8B DE 66 CC A0 DA 9B AB C2 93 57 83 B1 73 8E 6F 3C F3 0A 54 5B 1D 82 A6 85 68 57 02 AD 10 97 7B E4 CE 8C BA B0 48 C0 A3 98 F0 55 16 07 B9 12 7E E9 D0 19 E1 AF E6 3A 83 D1 F1 41 BE F9 62 FB 2C 1E 2F 9C 4E AF 20 A5 02 C5 46 11 ED 2C 6C 7C 78 BD 6E 69 B2 85 83 07 E0 01 09 1C FD A2 7E A4 13 87 34 F2 C8 28 A8 EA 40 B4 CE 27 C0 D1 EF CA 38 F1 B6 77 9A 12 D6 85 3E B4 F2 E6 E4 B7 93 59 3B 80 EF 1F DF 72 4B 76 2A 44 3D E5 1D B6 4D 5D 3B C1 37 A0 0A 26 72 5C EF 02 A8 D6 D9 2E 33 1D C3 41 C0 20 B3 D1 EC A6 98 E6 1C B3 30 13 12 58 AA 5C 66 DE 7A 22 6F BE 16 02 94 72 C1 49 AC FC C4 C0 02 BE 30 30 90 03 EE 7D 82 2B 0B 7C 93 F7 12 A3 52 CB 18 67 96 BA 56 BD 9E B7 EE 7C 49 B5 24 98 8C E0 6C 02 1D 62 A1 58 CE 37 3E 68 5F CE 57 14 73 6D FE 22 60 C6 68 16 00 DB 08 2E AA 0C 71 C8 9D F3 5C 04 6F BA 21 82 1A 85 73 23 68 D8 95 93 D0 B3 44 C9 CB DD 46 ED 54 CB 1D A0 07 69 C2 10 21 FB 42 4A 96 7D 35 2B 6F 44 17 06 34 76 B5 62 46 9C 3A 7F AF 6B 91 85 60 DF CE A1 02 23 7A 99 69 FB 23 5F 75 FA D6 44 4F 9E 44 95 D9 F1 FE F7 F8 68 1B 8A 4A C0 0A 8C 60 B9 7F EB C6 2B A1 C9 A4 77 0A E0 63 58 F7 B8 14 B9 57 26 12 9F 99 F6 81 40 43 FE 3A 8F 59 7B 6A 70 17 6A 24 F2 B9 B3 F3 8D 34 E4 10 A5 D9 E4 A0 54 3F E7 BE 4C D8 40 DF 2B F4 29 EF C6 AB CA BE 3F 2B A5 78 A2 C7 14 BD 45 6E 1C E8 72 E6 A6 2B AC 70 AE 42 A7 95 23 B5 1A 74 A8 4B 43 35 3A 5B 46 1E 07 32 91 A4 C1 07 4D EE ED 82 29 9F 74 E1 0B BE AD 64 C3 C7 D2 DD E2 98 0D 16 C7 06 35 23 10 FA 1F B8 42 DF 00 24 55 6E 15 7E FA E3 A0 73 DB 3E AF DC 65 E6 8A 27 38 8B 53 96 C2 7E 0F FE A0 62 2F 2F C3 FC E8 8F D6 11 0B E3 3F 4D 76 5A CF 3D AC 3E BE 3B 75 37 99 06 AD 88 54 D1 66 A8 47 D6 63 C3 0C 37 DF 10 06 E3 5B C0 00 23 DD 42 C2 2D E4 6B 1D D5 F1 C7 76 9A 1E 77 A6 17 E5 95 96 96 6E 68 75 06 76 1D 4B B0 86 F0 E2 97 AB A8 37 68 8E D9 B0 71 07 F3 C1 DE DB 3C 5F D8 F8 09 AD 23 F0 9C 6D 81 3E DE 33 4E 05 C4 DA B2 79 A9 02 99 A6 9A 93 9E 15 6D B2 91 B0 C2 73 42 81 D8 BA F2 E8 79 BD 27 68 D2 B5 01 F7 A7 7B F0 A3 D6 A9 75 C2 D1 BA 9A 8F F9 6A BA 5B 9F 56 40 2A FB 23 0A 45 E7 02 B0 29 E6 F1 CC BC 9E 41 44 CE E7 E4 A9 62 22 EB D5 4F 77 CB F1 78 46 66 CA 3E C0 98 DB C3 F0 D7 D2 0C 41 44 A8 19 78 9E FE B4 DE 1F B1 DA 4B 86 D2 1F E5 D4 9F 95 8E EA E9 F8 E2 A0 39 17 F6 DB 5D 8C B8 25 FF 46 F2 DE 50 59 95 C5 62 C8 CA 5B AD AB 63 7D 29 D9 00 7A 5C 01 B1 54 AD DC BC FD 47 43 B9 46 5F 29 C9 8A 58 B5 A5 03 70 5F 4D D5 E9 F2 D0 01 EF 1C DA 3F 94 12 35 F6 13 49 7F D2 4E 63 39 85 3F 9E C9 1F 12 43 C5 1D D6 77 A8 00 9D 80 8C 84 D1 2A 32 DD D7 A4 84 56 4D 33 3C 02 DF AE 83 5F 76 A0 E1 B6 83 45 0F 13 44 D8 7C 9B 67 26 CE 0F 45 45 69 8B 1F 2F EC 8A 3C 52 6E 19 2C D2 EE 3D 18 A1 FA 75 CF 65 44 96 BB E3 FA DC A9 C5 11 76 D0 DE 5C 48 67 CE 23 B4 73 E4 C9 EF 99 FF 4C 6E 4B 0B 33 C6 3F 18 3C 81 01 EE 4B 46 89 AF DC 07 5E 55 A7 EB 44 1C 9A D7 D6 C0 BA 51 34 F4 A2 53 0F E9 6C 24 4E 65 C1 FC 9E 34 71 A2 16 E6 C1 79 30 47 83 12 64 31 12 0A 17 6E 04 AE 9E 0F 85 8F 91 B5 1B 17 68 23 A7 5A C9 3E 00 D2 EB C8 44 24 FA 36 B7 9C 34 8A AC 19 4E D8 6D F1 3E CC E0 E7 41 E8 94 36 76 7D 49 7A B1 83 3C 76 B8 39 4F 4D 12 9D FC B4 57 AD 8D EE D3 1E EE A7 92 3F 14 BF 63 EB 48 12 A0 E9 DC 64 4A 97 D6 03 1B F8 9D F5 8E AF E7 9C A8 D0 8A 38 9D 4B C1 B8 41 CF AB 03 64 C2 3F 60 44 57 40 2C AB 83 38 91 32 DF EB 51 D0 C5 28 2E EE 58 55 49 E1 8A 5D 6A 3E 0E 65 95 15 B6 A8 C0 36 CF 56 40 CC 5A 8F FE 26 49 CD D9 62 6D D7 3B 0C 9F 2B 07 E0 BA D7 36 57 2C 5F 46 56 75 07 33 96 E1 50 0F 53 83 F6 D8 2D DA B1 F4 89 F0 A9 58 3B BB 3D CD 4B 2E 28 7C D5 FB 7D 5B 97 A5 B8 E7 E7 97 04 BB AD 46 D4 06 C6 AD 01 2C 13 EC 0A 9B CB 31 11 2E D4 12 C7 12 70 7F E7 F1 DF C8 79 C2 87 E8 AC E5 53 FD F5 34 19 23 A4 39 1D 86 51 4A 1D 86 31 37 C4 2E 77 E8 52 FC FF 2D 22 E5 80 14 E6 33 E6 2B 40 C7 54 65 40 84 7F C2 87 D3 5F AC EA 98 7A 8B 02 1A 97 E9 9C DC F3 E6 73 F1 AC 33 4D 67 0D D0 05 2C 43 A2 C4 C1 24 8D 7B 57 6D 90 28 FC 2F 7B E9 D6 02 31 D4 4F 67 86 24 3E 94 2B 49 1E 40 5D 5D C0 46 5C 07 16 5A 77 3F 78 63 75 F7 71 04 62 F4 A0 30 75 70 3F 6C CA C4 68 8C 19 F4 C5 D6 2B 23 B7 D6 47 15 AB 60 B1 2C B2 10 53 D3 B7 56 E9 AA D0 B6 EE AD 47 46 F9 A6 B8 14 D1 04 E5 E9 56 07 48 A4 4D 1E 27 E8 AE 3F 4C B7 F8 16 5F C4 70 F2 08 24 5F DF 99 B5 E9 B1 3E E7 FD 4B 74 9A 49 CB 9F 5B 33 DC 99 8C E0 1C E5 BA BA D1 BF 25 DF 01 37 24 3C CD B4 2E FC 4C 5C B7 80 53 C2 80 7D 53 DA A5 89 43 72 D9 6C DE 6D A8 32 E3 56 27 1F 60 B7 1F D6 D3 07 87 B9 B3 7E 9A 02 C1 CC 9E BB EC 1E 76 87 00 D6 0B A1 78 E8 68 DC DF FA A9 46 5A 43 A4 A8 06 54 29 82 3F 33 D7 19 DA A3 60 15 E7 6F 87 E7 13 B2 B1 77 99 B5 4F BD 9E 99 DF 27 67 CB 9B 5A 6C 6C B1 8F 32 4C 6E 95 25 F0 4C 0B 93 F9 26 C6 EA 0E 57 F4 23 7E F6 B7 14 90 68 B7 4C 10 3F AB 65 3A C5 21 A6 7A 2A FE 33 E9 9F 6A 1D AC 1A 64 67 B8 17 C7 E6 01 A0 8E 4F EB B5 71 B9 5D 21 6B D5 58 A1 73 07 A5 70 11 6C 52 D5 F3 BE 1F 19 3A D6 EA A9 25 9F 12 8A 7F 23 6B D7 85 42 5D FB 45 97 E5 5C 22 1D 13 82 6C 1A 54 8C 1E 68 CF 8D 1A DD 77 27 73 F9 8A B6 05 AF 61 0B 6D 39 48 E6 51 79 21 0D BF C0 70 7B 21 A7 67 1B 48 D8 90 0B 08 B9 91 A9 A1 BE 96 05 EC 4A 3F D5 0D 0A 2A 12 F1 C2 F6 5D 52 46 F1 AF 7D 07 C3 E4 5A 02 53 C7 E0 BA 77 0A 55 23 8A 18 D7 09 5C 73 A9 08 1B 2E 5F 90 C5 19 67 EC 57 B6 C3 80 5B CE 00 4B 34 FC 6C EB E0 C1 34 93 8E 2F B8 CB 55 C2 34 15 9B 1E 4C DD 69 4E 83 A3 FC 77 E5 6B 8F EE AD 07 10 D8 39 1E 02 CB D0 9E E6 57 4A BA 06 C2 5E 89 68 83 3A BE 5C 09 D3 D3 02 19 65 0F 5A B8 CE B9 08 BE B6 5F 09 01 96 42 10 B5 EA 5A 12 B4 93 35 6E 5A 97 36 F4 48 12 35 D3 EF 97 2C 27 10 57 D1 61 BD BE 75 96 BF 1B 5A 5A 81 ED 0C 9A 33 5D A8 E1 97 6C E3 A8 30 F1 49 ED 6C 37 96 EF B1 E8 C4 A4 D8 4D 5C 32 EF 31 8A D5 37 F2 9D 11 42 AF DC F3 A0 89 1A B4 D9 70 89 AF 55 6D 90 FC F9 85 0A 9C B1 36 FF 6F 10 97 BF C9 45 CC 7E 31 8F B9 FA B6 F1 D0 0F 57 70 03 38 AF 0C FA 2B 64 A9 A5 64 68 95 8B 86 F7 C3 A8 09 4D 02 D5 F2 B0 D0 28 B6 10 95 55 29 6B B1 4C C0 1C 14 58 5F 3E 8A 08 B6 26) */;

	public static byte[] ZZZZZZZZZZZZZZZZZZZZZZZZZw;

	public static IntPtr[] ZZZZZZZZZZZZZZZZZZZZZZZZZx;

	static void Koi()
	{
		ZZZZZZZZZZZZZZZZZZZZZZZZZT();
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZG((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)110);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZL((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)201);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZG((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)172);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZB((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)33);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZJ((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)156);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZE((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)124);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZE((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)141);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZB((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)157);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZy((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)222);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZM((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)27);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZI((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)139);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZD((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)50);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZF((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)217);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZF((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)81);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZL((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)73);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZy((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)139);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZM((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)225);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZK((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)92);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZC((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)106);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZH((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)175);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZM((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)66);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZA((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)3);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZH((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)113);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZI((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)155);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZB((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)149);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZK((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)247);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZI((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)223);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZF((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)176);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZI((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)100);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZB((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)58);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZL((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)146);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZL((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)175);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZK((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)165);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZz((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)107);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZF((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)111);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZB((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)213);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZD((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)138);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZL((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)134);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZN((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)130);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZz((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)155);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZB((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)81);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZB((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)7);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZJ((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)235);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZz((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)189);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZD((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)46);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZM((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)14);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZH((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)108);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZA((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)179);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZA((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)27);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZy((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)99);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZy((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)195);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZE((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)135);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZI((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)66);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZA((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)71);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZN((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)214);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZE((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)21);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZF((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)45);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZL((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)96);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZM((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)155);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZF((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)228);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZM((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)47);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZL((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)45);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZG((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)173);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZD((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)173);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZE((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)14);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZC((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)51);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZM((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)69);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZG((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)178);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZG((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)179);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZM((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)127);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZG((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)186);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZy((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)121);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZL((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)202);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZy((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)238);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZF((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)117);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZK((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)33);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZD((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)98);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZD((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)4);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZF((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)181);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZN((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)64);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZK((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)190);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZK((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)133);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZL((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)66);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZD((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)7);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZN((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)57);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZC((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)184);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZL((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)65);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZI((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)227);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZA((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)121);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZG((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)90);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZD((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)247);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZy((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)3);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZK((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)126);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZA((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)60);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZI((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)223);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZz((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)2);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZz((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)59);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZD((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)6);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZC((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)124);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZC((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)161);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZK((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)136);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZF((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)190);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZN((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)147);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZI((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)193);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZB((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)212);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZH((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)241);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZA((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)33);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZF((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)0);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZI((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)42);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZG((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)137);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZK((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)137);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZE((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)63);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZD((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)83);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZL((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)210);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZJ((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)165);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZN((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)71);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZF((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)81);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZK((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)228);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZB((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)9);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZy((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)149);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZL((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)34);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZD((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)177);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZN((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)163);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZz((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)101);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZB((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)39);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZN((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)118);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZL((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)174);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZN((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)200);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZJ((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)146);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZH((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)98);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZN((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)26);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZK((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)178);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZM((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)51);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZJ((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)116);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZF((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)229);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZJ((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)94);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZG((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)89);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZD((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)161);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZy((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)192);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZI((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)76);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZL((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)244);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZA((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)70);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZN((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)231);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZH((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)49);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZz((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)82);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZB((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)42);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZy((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)173);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZI((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)176);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZB((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)59);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZG((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)34);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZy((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)128);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZL((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)171);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZL((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)184);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZL((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)22);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZC((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)176);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZy((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)238);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZA((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)17);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZz((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)177);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZK((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)92);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZA((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)118);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZJ((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)2);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZM((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)54);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZE((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)214);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZN((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)22);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZM((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)42);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZB((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)38);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZz((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)194);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZG((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)212);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZM((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)116);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZI((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)214);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZG((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)204);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZE((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)82);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZy((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)69);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZG((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)160);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZL((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)103);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZB((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)75);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZL((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)16);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZN((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)195);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZD((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)67);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZC((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)215);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZM((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)21);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZC((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)252);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZN((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)82);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZH((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)59);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZF((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)38);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZN((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)177);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZN((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)201);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZM((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)74);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZN((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)53);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZK((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)43);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZM((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)66);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZI((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)46);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZA((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)64);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZz((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)175);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZN((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)2);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZA((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)248);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZy((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)11);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZH((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)195);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZJ((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)197);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZJ((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)31);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZE((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)26);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZD((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)124);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZG((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)35);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZH((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)53);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZE((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)20);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZz((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)158);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZC((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)115);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZM((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)185);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZJ((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)198);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZy((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)0);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZH((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)43);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZF((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)167);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZJ((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)145);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZA((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)247);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZG((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)176);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZH((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)205);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZM((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)97);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZE((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)243);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZB((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)59);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZH((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)63);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZD((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)119);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZA((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)235);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZB((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)242);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZC((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)86);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZG((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)172);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZH((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)244);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZE((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)127);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZB((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)11);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZJ((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)169);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZD((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)49);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZH((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)66);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZN((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)109);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZG((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)21);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZK((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)62);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZF((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)13);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZy((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)24);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZI((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)162);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZz((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)1);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZE((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)154);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZy((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)154);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZz((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)185);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZH((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)65);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZE((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)239);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZG((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)72);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZM((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)172);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZC((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)226);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZG((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)129);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZM((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)29);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZK((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)139);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZE((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)243);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZG((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)38);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZK((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)59);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZF((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)235);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZJ((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)95);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZE((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)161);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZJ((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)32);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZD((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)109);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZC((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)79);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZN((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)157);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZE((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)73);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZF((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)90);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZz((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)101);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZJ((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)21);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZy((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)117);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZG((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)5);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZF((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)35);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZC((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)141);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZz((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)2);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZN((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)1);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZF((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)88);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZy((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)141);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZy((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)5);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZM((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)79);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZD((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)11);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZB((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)244);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZD((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)105);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZN((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)168);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZK((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)50);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZC((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)101);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZN((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)183);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZy((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)73);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZL((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)230);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZG((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)65);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZA((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)236);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZz((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)215);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZA((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)145);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZA((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)169);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZB((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)162);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZH((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)202);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZC((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)220);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZB((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)235);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZD((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)250);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZD((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)231);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZM((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)88);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZH((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)84);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZy((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)14);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZM((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)58);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZy((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)252);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZD((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)80);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZB((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)133);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZL((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)67);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZC((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)90);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZC((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)82);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZB((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)215);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZy((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)25);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZA((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)107);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZL((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)227);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZM((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)178);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZM((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)218);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZB((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)38);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZB((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)154);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZK((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)164);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZH((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)9);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZB((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)68);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZK((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)137);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZK((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)121);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZC((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)213);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZK((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)100);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZM((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)117);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZz((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)135);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZA((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)11);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZF((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)172);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZA((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)140);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZC((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)47);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZG((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)98);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZC((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)41);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZy((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)175);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZF((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)60);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZH((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)238);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZy((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)149);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZy((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)226);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZI((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)200);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZE((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)154);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZL((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)80);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZC((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)95);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZG((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)213);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZz((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)0);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZM((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)200);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZD((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)181);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZJ((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)221);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZB((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)159);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZB((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)49);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZC((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)57);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZy((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)25);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZA((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)46);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZA((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)175);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZE((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)92);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZB((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)38);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZB((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)47);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZL((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)116);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZH((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)171);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZD((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)105);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZE((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)26);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZG((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)6);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZK((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)241);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZL((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)224);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZy((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)156);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZF((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)106);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZM((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)254);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZM((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)165);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZB((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)118);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZC((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)179);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZy((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)232);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZL((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)173);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZI((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)213);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZL((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)230);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZD((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)194);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZA((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)67);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZG((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)57);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZK((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)242);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZB((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)107);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZM((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)39);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZM((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)183);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZI((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)103);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZD((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)165);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZI((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)128);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZA((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)86);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZL((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)4);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZH((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)207);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZE((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)219);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZM((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)206);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZJ((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)161);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZF((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)132);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZK((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)195);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZG((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)7);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZB((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)75);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZN((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)86);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZH((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)148);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZI((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)103);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZM((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)92);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZH((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)196);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZE((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)12);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZL((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)158);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZN((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)192);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZG((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)195);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZN((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)85);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZJ((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)149);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZE((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, byte.MaxValue);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZL((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)236);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZz((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)159);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZB((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)175);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZB((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)253);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZK((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)29);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZH((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)251);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZy((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)192);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZH((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)50);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZN((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)196);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZE((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)29);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZN((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)164);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZE((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)101);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZz((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)22);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZA((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)22);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZM((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)224);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZz((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)120);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZG((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)169);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZE((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)55);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZL((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)175);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZH((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)195);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZy((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)237);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZK((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)106);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZD((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)104);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZC((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)28);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZI((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)243);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZI((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)51);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZJ((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)36);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZF((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)114);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZF((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)152);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZD((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)224);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZJ((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)48);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZz((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)222);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZH((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)33);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZy((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)193);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZy((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)109);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZI((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)85);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZH((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)24);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZG((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)136);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZA((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)63);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZy((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)138);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZy((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)253);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZz((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)108);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZF((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)67);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZF((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)97);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZF((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)81);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZE((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)92);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZD((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)198);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZC((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)228);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZB((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)206);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZA((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)226);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZA((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)31);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZz((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)156);
		Koi.ZZZZZZZZZZZZZZZZZZZZZZZZZy((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, (byte)245);
		ZZZZZZZZZZZZZZZZZZZZZZZZZv();
		ZZZZZZZZZZZZu();
	}

	[DllImport("kernel32.dll")]
	internal unsafe static extern bool VirtualProtect(byte* pByte_0, int int_0, uint uint_0, ref uint uint_1);

	internal unsafe static void ZZZZZZZZZZZZu()
	{
		Module module = typeof(Koi).Module;
		byte* ptr = (byte*)(void*)Marshal.GetHINSTANCE(module);
		byte* ptr2 = ptr + 60;
		ptr2 = ptr + (uint)(*(int*)ptr2);
		ptr2 += 6;
		ushort num = *(ushort*)ptr2;
		ptr2 += 10;
		uint num2 = *(uint*)ptr2;
		ptr2 += 4;
		ushort num3 = *(ushort*)ptr2;
		ptr2 = ptr2 + 4 + (int)num3;
		byte* ptr3 = stackalloc byte[11];
		uint uint_ = default(uint);
		if (module.FullyQualifiedName[0] != '<')
		{
			uint num4 = *(uint*)(ptr2 - 16);
			if (num4 == 0)
			{
				num4 ^= num2 ^ 0xF5562875u;
			}
			byte* ptr4 = ptr + num4;
			if (*(uint*)(ptr2 - 120) != 0)
			{
				byte* ptr5 = ptr + (uint)(*(int*)(ptr2 - 120));
				byte* ptr6 = ptr + (uint)(*(int*)ptr5);
				byte* ptr7 = ptr + (uint)(*(int*)(ptr5 + 12));
				byte* ptr8 = ptr + (uint)(*(int*)ptr6) + 2;
				VirtualProtect(ptr7, 11, 64u, ref uint_);
				*(int*)ptr3 = 1818522734;
				*(int*)(ptr3 + 4) = 1818504812;
				*(short*)(ptr3 + (nint)4 * (nint)2) = 108;
				ptr3[10] = 0;
				for (int i = 0; i < 11; i++)
				{
					ptr7[i] = ptr3[i];
				}
				VirtualProtect(ptr8, 11, 64u, ref uint_);
				*(int*)ptr3 = 1866691662;
				*(int*)(ptr3 + 4) = 1852404846;
				*(short*)(ptr3 + (nint)4 * (nint)2) = 25973;
				ptr3[10] = 0;
				for (int j = 0; j < 11; j++)
				{
					ptr8[j] = ptr3[j];
				}
			}
			for (int k = 0; k < num; k++)
			{
				VirtualProtect(ptr2, 8, 64u, ref uint_);
				Marshal.Copy(new byte[8], 0, (IntPtr)ptr2, 8);
				ptr2 += 40;
			}
			VirtualProtect(ptr4, 72, 64u, ref uint_);
			byte* ptr9 = ptr + (uint)(*(int*)(ptr4 + 8));
			*(int*)ptr4 = 0;
			*(int*)(ptr4 + 4) = 0;
			*(int*)(ptr4 + (nint)2 * (nint)4) = 0;
			*(int*)(ptr4 + (nint)3 * (nint)4) = 0;
			VirtualProtect(ptr9, 4, 64u, ref uint_);
			*(int*)ptr9 = 0;
			ptr9 += 12;
			ptr9 += (uint)(*(int*)ptr9);
			ptr9 = (byte*)(((ulong)ptr9 + 7uL) & 0xFFFFFFFFFFFFFFFCuL);
			ptr9 += 2;
			ushort num5 = *ptr9;
			ptr9 += 2;
			for (int l = 0; l < num5; l++)
			{
				VirtualProtect(ptr9, 8, 64u, ref uint_);
				ptr9 += 4;
				ptr9 += 4;
				for (int m = 0; m < 8; m++)
				{
					VirtualProtect(ptr9, 4, 64u, ref uint_);
					*ptr9 = 0;
					ptr9++;
					if (*ptr9 != 0)
					{
						*ptr9 = 0;
						ptr9++;
						if (*ptr9 != 0)
						{
							*ptr9 = 0;
							ptr9++;
							if (*ptr9 != 0)
							{
								*ptr9 = 0;
								ptr9++;
								continue;
							}
							ptr9++;
							break;
						}
						ptr9 += 2;
						break;
					}
					ptr9 += 3;
					break;
				}
			}
			return;
		}
		uint num6 = *(uint*)(ptr2 - 16);
		uint num7 = *(uint*)(ptr2 - 120);
		uint[] array = new uint[num];
		uint[] array2 = new uint[num];
		uint[] array3 = new uint[num];
		for (int n = 0; n < num; n++)
		{
			VirtualProtect(ptr2, 8, 64u, ref uint_);
			Marshal.Copy(new byte[8], 0, (IntPtr)ptr2, 8);
			array[n] = *(uint*)(ptr2 + 12);
			array2[n] = *(uint*)(ptr2 + 8);
			array3[n] = *(uint*)(ptr2 + 20);
			ptr2 += 40;
		}
		if (num7 != 0)
		{
			for (int num8 = 0; num8 < num; num8++)
			{
				if (array[num8] <= num7 && num7 < array[num8] + array2[num8])
				{
					num7 = num7 - array[num8] + array3[num8];
					break;
				}
			}
			byte* ptr10 = ptr + num7;
			uint num9 = *(uint*)ptr10;
			for (int num10 = 0; num10 < num; num10++)
			{
				if (array[num10] <= num9 && num9 < array[num10] + array2[num10])
				{
					num9 = num9 - array[num10] + array3[num10];
					break;
				}
			}
			byte* ptr11 = ptr + num9;
			uint num11 = *(uint*)(ptr10 + 12);
			for (int num12 = 0; num12 < num; num12++)
			{
				if (array[num12] <= num11 && num11 < array[num12] + array2[num12])
				{
					num11 = num11 - array[num12] + array3[num12];
					break;
				}
			}
			uint num13 = *(uint*)ptr11 + 2;
			for (int num14 = 0; num14 < num; num14++)
			{
				if (array[num14] <= num13 && num13 < array[num14] + array2[num14])
				{
					num13 = num13 - array[num14] + array3[num14];
					break;
				}
			}
			VirtualProtect(ptr + num11, 11, 64u, ref uint_);
			*(int*)ptr3 = 1818522734;
			*(int*)(ptr3 + 4) = 1818504812;
			*(short*)(ptr3 + (nint)4 * (nint)2) = 108;
			ptr3[10] = 0;
			for (int num15 = 0; num15 < 11; num15++)
			{
				(ptr + num11)[num15] = ptr3[num15];
			}
			VirtualProtect(ptr + num13, 11, 64u, ref uint_);
			*(int*)ptr3 = 1866691662;
			*(int*)(ptr3 + 4) = 1852404846;
			*(short*)(ptr3 + (nint)4 * (nint)2) = 25973;
			ptr3[10] = 0;
			for (int num16 = 0; num16 < 11; num16++)
			{
				(ptr + num13)[num16] = ptr3[num16];
			}
		}
		for (int num17 = 0; num17 < num; num17++)
		{
			if (array[num17] <= num6 && num6 < array[num17] + array2[num17])
			{
				num6 = num6 - array[num17] + array3[num17];
				break;
			}
		}
		byte* ptr12 = ptr + num6;
		VirtualProtect(ptr12, 72, 64u, ref uint_);
		uint num18 = *(uint*)(ptr12 + 8);
		for (int num19 = 0; num19 < num; num19++)
		{
			if (array[num19] <= num18 && num18 < array[num19] + array2[num19])
			{
				num18 = num18 - array[num19] + array3[num19];
				break;
			}
		}
		*(int*)ptr12 = 0;
		*(int*)(ptr12 + 4) = 0;
		*(int*)(ptr12 + (nint)2 * (nint)4) = 0;
		*(int*)(ptr12 + (nint)3 * (nint)4) = 0;
		byte* ptr13 = ptr + num18;
		VirtualProtect(ptr13, 4, 64u, ref uint_);
		*(int*)ptr13 = 0;
		ptr13 += 12;
		ptr13 += (uint)(*(int*)ptr13);
		ptr13 = (byte*)(((ulong)ptr13 + 7uL) & 0xFFFFFFFFFFFFFFFCuL);
		ptr13 += 2;
		ushort num20 = *ptr13;
		ptr13 += 2;
		for (int num21 = 0; num21 < num20; num21++)
		{
			VirtualProtect(ptr13, 8, 64u, ref uint_);
			ptr13 += 4;
			ptr13 += 4;
			for (int num22 = 0; num22 < 8; num22++)
			{
				VirtualProtect(ptr13, 4, 64u, ref uint_);
				*ptr13 = 0;
				ptr13++;
				if (*ptr13 != 0)
				{
					*ptr13 = 0;
					ptr13++;
					if (*ptr13 != 0)
					{
						*ptr13 = 0;
						ptr13++;
						if (*ptr13 != 0)
						{
							*ptr13 = 0;
							ptr13++;
							continue;
						}
						ptr13++;
						break;
					}
					ptr13 += 2;
					break;
				}
				ptr13 += 3;
				break;
			}
		}
	}

	internal static byte[] ZZZZZZZZZZZZZZZZZZZZZZZW(byte[] byte_0)
	{
		MemoryStream memoryStream = new MemoryStream(byte_0);
		ZZZZZZZZZZZZZZZZZZZZZZB zZZZZZZZZZZZZZZZZZZZZZB = new ZZZZZZZZZZZZZZZZZZZZZZB();
		byte[] array = new byte[5];
		memoryStream.Read(array, 0, 5);
		zZZZZZZZZZZZZZZZZZZZZZB.ZZZZZZZZZZZZZZZZZZZZZZZh(array);
		long num = 0L;
		for (int i = 0; i < 8; i++)
		{
			int num2 = memoryStream.ReadByte();
			num |= (long)((ulong)(byte)num2 << 8 * i);
		}
		byte[] array2 = new byte[(int)num];
		MemoryStream stream_ = new MemoryStream(array2, writable: true);
		long long_ = memoryStream.Length - 13L;
		zZZZZZZZZZZZZZZZZZZZZZB.ZZZZZZZZZZZZZZZZZZZZZZZg(memoryStream, stream_, long_, num);
		return array2;
	}

	private static byte[] ZZZZZZZZZZZZZZZZZZZZZZZZZt(byte[] byte_0)
	{
		using GZipStream gZipStream = new GZipStream(new MemoryStream(byte_0), CompressionMode.Decompress);
		byte[] buffer = new byte[4096];
		using MemoryStream memoryStream = new MemoryStream();
		int num = 0;
		do
		{
			num = gZipStream.Read(buffer, 0, 4096);
			if (num > 0)
			{
				memoryStream.Write(buffer, 0, num);
			}
		}
		while (num > 0);
		return memoryStream.ToArray();
	}

	public static string ZZZZZZZZZZZZZZZZZZZZZZZZZu(string string_0)
	{
		int num = string_0.IndexOf("mscorlib");
		if (num == -1)
		{
			return string_0;
		}
		int num2 = string_0.IndexOf("]", num);
		if (num2 == -1)
		{
			return string_0;
		}
		if (num > num2)
		{
			return string_0;
		}
		return string_0.Remove(num, num2 - num);
	}

	public unsafe static void ZZZZZZZZZZZZZZZZZZZZZZZZZv()
	{
		ZZZZZZZZZZZZZZZZZZZZZZZZZb();
		List<IntPtr> list = new List<IntPtr>();
		list.Add((nint)__ldftn(ZZZZZZO.get_ZZZZZZV));
		list.Add((nint)__ldftn(ZZZZZZH.get_ZZZZZZA));
		list.Add((nint)__ldftn(ZZZZZZO.set_ZZZZZZV));
		list.Add((nint)__ldftn(ZZZZZZH.set_ZZZZZZL));
		list.Add((nint)__ldftn(ZZZZZZH.set_ZZZZZZA));
		list.Add((nint)__ldftn(ZZZZZZh.get_ZZZZZZm));
		list.Add((nint)__ldftn(ZZZZZZh.set_ZZZZZZm));
		list.Add((nint)__ldftn(ZZZZZZZA.ZZZZZZZD));
		list.Add((nint)__ldftn(ZZZZZZZA.get_ZZZZZZZF));
		list.Add((nint)__ldftn(ZZZZZA.set_ZZZZZZa));
		list.Add((nint)__ldftn(ZZZZZA.set_ZZZZZZ));
		list.Add((nint)__ldftn(ZZZZZA.set_ZZZZZY));
		list.Add((nint)__ldftn(ZZZZZA.set_ZZZZZX));
		list.Add((nint)__ldftn(ZZZZZA.set_ZZZZZW));
		list.Add((nint)__ldftn(ZZZZZp.set_ZZZZZZa));
		list.Add((nint)__ldftn(ZZZZZp.set_ZZZZZZ));
		list.Add((nint)__ldftn(ZZZZZp.set_ZZZZZY));
		list.Add((nint)__ldftn(ZZZZZp.set_ZZZZZX));
		list.Add((nint)__ldftn(ZZZZZp.set_ZZZZZW));
		list.Add((nint)__ldftn(ZZZZZZr.set_ZZZZZZx));
		list.Add((nint)__ldftn(ZZZZZZr.set_ZZZZZZy));
		list.Add((nint)(delegate*<ZZZZZZZn>)(&ZZZZZZZn.get_ZZZZZZZq));
		list.Add((nint)(delegate*<ZZZZZL>)(&ZZZZZL.get_ZZZZZU));
		list.Add((nint)(delegate*<ZZZZZZZw>)(&ZZZZZZZw.get_ZZZZZZZz));
		list.Add((nint)(delegate*<ZZZX>)(&ZZZX.get_ZZZZd));
		list.Add((nint)(delegate*<ZZZZg>)(&ZZZZg.get_ZZZZn));
		list.Add((nint)(delegate*<ZZZT>)(&ZZZT.get_ZZZW));
		list.Add((nint)(delegate*<ZZZZv>)(&ZZZZv.get_ZZZZB));
		IntPtr intPtr = (IntPtr)(void*)null;
		int num = 129;
		byte[] zZZZZZZZZZZZZZZZZZZZZZZZZw = ZZZZZZZZZZZZZZZZZZZZZZZZZw;
		for (int i = 0; i < zZZZZZZZZZZZZZZZZZZZZZZZZw.Length; i++)
		{
			zZZZZZZZZZZZZZZZZZZZZZZZZw[i] ^= (byte)i;
		}
		zZZZZZZZZZZZZZZZZZZZZZZZZw = ZZZZZZZZZZZZZZZZZZZZZZZZZt(zZZZZZZZZZZZZZZZZZZZZZZZZw);
		BinaryReader binaryReader = new BinaryReader(new MemoryStream(zZZZZZZZZZZZZZZZZZZZZZZZZw));
		for (int j = 0; j < num; j++)
		{
			int num2 = j * 20;
			binaryReader.BaseStream.Position = num2;
			int num3 = binaryReader.ReadInt32();
			int num4 = binaryReader.ReadInt32();
			int startIndex = binaryReader.ReadInt32();
			uint num5 = binaryReader.ReadUInt32();
			int num6 = binaryReader.ReadInt32();
			uint num7 = 0u;
			if (num3 > 0)
			{
				num7 = BitConverter.ToUInt32(zZZZZZZZZZZZZZZZZZZZZZZZZw, startIndex);
			}
			binaryReader.BaseStream.Position = num6;
			uint num8 = binaryReader.ReadUInt32();
			binaryReader.BaseStream.Position = num4;
			uint num9 = binaryReader.ReadUInt32();
			Type type = null;
			FieldInfo[] fields = typeof(Koi).GetFields();
			foreach (FieldInfo fieldInfo in fields)
			{
				if (ZZZZZZZZZZZZZZZZZZZZZZZZZa.ZZZZZZZZZZZZZZZZZZZZZZZZZg(fieldInfo.Name) == num5)
				{
					type = fieldInfo.FieldType;
					break;
				}
			}
			MethodInfo methodInfo = null;
			MethodInfo[] methods = type.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			foreach (MethodInfo methodInfo2 in methods)
			{
				ParameterInfo[] parameters = methodInfo2.GetParameters();
				if (parameters.Length != num3 || ZZZZZZZZZZZZZZZZZZZZZZZZZa.ZZZZZZZZZZZZZZZZZZZZZZZZZg(methodInfo2.Name) != num9 || ZZZZZZZZZZZZZZZZZZZZZZZZZa.ZZZZZZZZZZZZZZZZZZZZZZZZZg(methodInfo2.ReturnType.FullName) != num8)
				{
					continue;
				}
				uint num10 = 0u;
				List<string> list2 = new List<string>();
				for (int m = 0; m < parameters.Length; m++)
				{
					string text = parameters[m].ParameterType.FullName;
					try
					{
						if (text.Contains("mscorlib"))
						{
							text = ZZZZZZZZZZZZZZZZZZZZZZZZZu(text);
						}
						list2.Add(text);
					}
					catch
					{
					}
				}
				num10 = ZZZZZZZZZZZZZZZZZZZZZZZZZa.ZZZZZZZZZZZZZZZZZZZZZZZZZg(string.Join(new string(new char[0]), list2.ToArray()));
				if (num10 == num7)
				{
					methodInfo = methodInfo2;
					break;
				}
			}
			intPtr = methodInfo.MethodHandle.GetFunctionPointer();
			list.Add(intPtr);
		}
		ZZZZZZZZZZZZZZZZZZZZZZZZZx = list.ToArray();
		Array.Clear(zZZZZZZZZZZZZZZZZZZZZZZZZw, 0, zZZZZZZZZZZZZZZZZZZZZZZZZw.Length);
	}

	private static void ZZZZZZZZZZZZZZZZZZZZZZZZZb()
	{
		ZZZZZZZZZZZZZZZZZZZZZZZZZw = new byte[1979]
		{
			97, 192, 27, 27, 6, 50, 65, 237, 230, 0,
			138, 97, 249, 118, 141, 245, 59, 154, 129, 145,
			222, 58, 103, 133, 85, 208, 12, 246, 225, 141,
			76, 16, 207, 8, 19, 88, 192, 8, 206, 8,
			153, 66, 111, 231, 51, 154, 139, 222, 102, 204,
			160, 218, 155, 171, 194, 147, 87, 131, 177, 115,
			142, 111, 60, 243, 10, 84, 91, 29, 130, 166,
			133, 104, 87, 2, 173, 16, 151, 123, 228, 206,
			140, 186, 176, 72, 192, 163, 152, 240, 85, 22,
			7, 185, 18, 126, 233, 208, 25, 225, 175, 230,
			58, 131, 209, 241, 65, 190, 249, 98, 251, 44,
			30, 47, 156, 78, 175, 32, 165, 2, 197, 70,
			17, 237, 44, 108, 124, 120, 189, 110, 105, 178,
			133, 131, 7, 224, 1, 9, 28, 253, 162, 126,
			164, 19, 135, 52, 242, 200, 40, 168, 234, 64,
			180, 206, 39, 192, 209, 239, 202, 56, 241, 182,
			119, 154, 18, 214, 133, 62, 180, 242, 230, 228,
			183, 147, 89, 59, 128, 239, 31, 223, 114, 75,
			118, 42, 68, 61, 229, 29, 182, 77, 93, 59,
			193, 55, 160, 10, 38, 114, 92, 239, 2, 168,
			214, 217, 46, 51, 29, 195, 65, 192, 32, 179,
			209, 236, 166, 152, 230, 28, 179, 48, 19, 18,
			88, 170, 92, 102, 222, 122, 34, 111, 190, 22,
			2, 148, 114, 193, 73, 172, 252, 196, 192, 2,
			190, 48, 48, 144, 3, 238, 125, 130, 43, 11,
			124, 147, 247, 18, 163, 82, 203, 24, 103, 150,
			186, 86, 189, 158, 183, 238, 124, 73, 181, 36,
			152, 140, 224, 108, 2, 29, 98, 161, 88, 206,
			55, 62, 104, 95, 206, 87, 20, 115, 109, 254,
			34, 96, 198, 104, 22, 0, 219, 8, 46, 170,
			12, 113, 200, 157, 243, 92, 4, 111, 186, 33,
			130, 26, 133, 115, 35, 104, 216, 149, 147, 208,
			179, 68, 201, 203, 221, 70, 237, 84, 203, 29,
			160, 7, 105, 194, 16, 33, 251, 66, 74, 150,
			125, 53, 43, 111, 68, 23, 6, 52, 118, 181,
			98, 70, 156, 58, 127, 175, 107, 145, 133, 96,
			223, 206, 161, 2, 35, 122, 153, 105, 251, 35,
			95, 117, 250, 214, 68, 79, 158, 68, 149, 217,
			241, 254, 247, 248, 104, 27, 138, 74, 192, 10,
			140, 96, 185, 127, 235, 198, 43, 161, 201, 164,
			119, 10, 224, 99, 88, 247, 184, 20, 185, 87,
			38, 18, 159, 153, 246, 129, 64, 67, 254, 58,
			143, 89, 123, 106, 112, 23, 106, 36, 242, 185,
			179, 243, 141, 52, 228, 16, 165, 217, 228, 160,
			84, 63, 231, 190, 76, 216, 64, 223, 43, 244,
			41, 239, 198, 171, 202, 190, 63, 43, 165, 120,
			162, 199, 20, 189, 69, 110, 28, 232, 114, 230,
			166, 43, 172, 112, 174, 66, 167, 149, 35, 181,
			26, 116, 168, 75, 67, 53, 58, 91, 70, 30,
			7, 50, 145, 164, 193, 7, 77, 238, 237, 130,
			41, 159, 116, 225, 11, 190, 173, 100, 195, 199,
			210, 221, 226, 152, 13, 22, 199, 6, 53, 35,
			16, 250, 31, 184, 66, 223, 0, 36, 85, 110,
			21, 126, 250, 227, 160, 115, 219, 62, 175, 220,
			101, 230, 138, 39, 56, 139, 83, 150, 194, 126,
			15, 254, 160, 98, 47, 47, 195, 252, 232, 143,
			214, 17, 11, 227, 63, 77, 118, 90, 207, 61,
			172, 62, 190, 59, 117, 55, 153, 6, 173, 136,
			84, 209, 102, 168, 71, 214, 99, 195, 12, 55,
			223, 16, 6, 227, 91, 192, 0, 35, 221, 66,
			194, 45, 228, 107, 29, 213, 241, 199, 118, 154,
			30, 119, 166, 23, 229, 149, 150, 150, 110, 104,
			117, 6, 118, 29, 75, 176, 134, 240, 226, 151,
			171, 168, 55, 104, 142, 217, 176, 113, 7, 243,
			193, 222, 219, 60, 95, 216, 248, 9, 173, 35,
			240, 156, 109, 129, 62, 222, 51, 78, 5, 196,
			218, 178, 121, 169, 2, 153, 166, 154, 147, 158,
			21, 109, 178, 145, 176, 194, 115, 66, 129, 216,
			186, 242, 232, 121, 189, 39, 104, 210, 181, 1,
			247, 167, 123, 240, 163, 214, 169, 117, 194, 209,
			186, 154, 143, 249, 106, 186, 91, 159, 86, 64,
			42, 251, 35, 10, 69, 231, 2, 176, 41, 230,
			241, 204, 188, 158, 65, 68, 206, 231, 228, 169,
			98, 34, 235, 213, 79, 119, 203, 241, 120, 70,
			102, 202, 62, 192, 152, 219, 195, 240, 215, 210,
			12, 65, 68, 168, 25, 120, 158, 254, 180, 222,
			31, 177, 218, 75, 134, 210, 31, 229, 212, 159,
			149, 142, 234, 233, 248, 226, 160, 57, 23, 246,
			219, 93, 140, 184, 37, 255, 70, 242, 222, 80,
			89, 149, 197, 98, 200, 202, 91, 173, 171, 99,
			125, 41, 217, 0, 122, 92, 1, 177, 84, 173,
			220, 188, 253, 71, 67, 185, 70, 95, 41, 201,
			138, 88, 181, 165, 3, 112, 95, 77, 213, 233,
			242, 208, 1, 239, 28, 218, 63, 148, 18, 53,
			246, 19, 73, 127, 210, 78, 99, 57, 133, 63,
			158, 201, 31, 18, 67, 197, 29, 214, 119, 168,
			0, 157, 128, 140, 132, 209, 42, 50, 221, 215,
			164, 132, 86, 77, 51, 60, 2, 223, 174, 131,
			95, 118, 160, 225, 182, 131, 69, 15, 19, 68,
			216, 124, 155, 103, 38, 206, 15, 69, 69, 105,
			139, 31, 47, 236, 138, 60, 82, 110, 25, 44,
			210, 238, 61, 24, 161, 250, 117, 207, 101, 68,
			150, 187, 227, 250, 220, 169, 197, 17, 118, 208,
			222, 92, 72, 103, 206, 35, 180, 115, 228, 201,
			239, 153, 255, 76, 110, 75, 11, 51, 198, 63,
			24, 60, 129, 1, 238, 75, 70, 137, 175, 220,
			7, 94, 85, 167, 235, 68, 28, 154, 215, 214,
			192, 186, 81, 52, 244, 162, 83, 15, 233, 108,
			36, 78, 101, 193, 252, 158, 52, 113, 162, 22,
			230, 193, 121, 48, 71, 131, 18, 100, 49, 18,
			10, 23, 110, 4, 174, 158, 15, 133, 143, 145,
			181, 27, 23, 104, 35, 167, 90, 201, 62, 0,
			210, 235, 200, 68, 36, 250, 54, 183, 156, 52,
			138, 172, 25, 78, 216, 109, 241, 62, 204, 224,
			231, 65, 232, 148, 54, 118, 125, 73, 122, 177,
			131, 60, 118, 184, 57, 79, 77, 18, 157, 252,
			180, 87, 173, 141, 238, 211, 30, 238, 167, 146,
			63, 20, 191, 99, 235, 72, 18, 160, 233, 220,
			100, 74, 151, 214, 3, 27, 248, 157, 245, 142,
			175, 231, 156, 168, 208, 138, 56, 157, 75, 193,
			184, 65, 207, 171, 3, 100, 194, 63, 96, 68,
			87, 64, 44, 171, 131, 56, 145, 50, 223, 235,
			81, 208, 197, 40, 46, 238, 88, 85, 73, 225,
			138, 93, 106, 62, 14, 101, 149, 21, 182, 168,
			192, 54, 207, 86, 64, 204, 90, 143, 254, 38,
			73, 205, 217, 98, 109, 215, 59, 12, 159, 43,
			7, 224, 186, 215, 54, 87, 44, 95, 70, 86,
			117, 7, 51, 150, 225, 80, 15, 83, 131, 246,
			216, 45, 218, 177, 244, 137, 240, 169, 88, 59,
			187, 61, 205, 75, 46, 40, 124, 213, 251, 125,
			91, 151, 165, 184, 231, 231, 151, 4, 187, 173,
			70, 212, 6, 198, 173, 1, 44, 19, 236, 10,
			155, 203, 49, 17, 46, 212, 18, 199, 18, 112,
			127, 231, 241, 223, 200, 121, 194, 135, 232, 172,
			229, 83, 253, 245, 52, 25, 35, 164, 57, 29,
			134, 81, 74, 29, 134, 49, 55, 196, 46, 119,
			232, 82, 252, 255, 45, 34, 229, 128, 20, 230,
			51, 230, 43, 64, 199, 84, 101, 64, 132, 127,
			194, 135, 211, 95, 172, 234, 152, 122, 139, 2,
			26, 151, 233, 156, 220, 243, 230, 115, 241, 172,
			51, 77, 103, 13, 208, 5, 44, 67, 162, 196,
			193, 36, 141, 123, 87, 109, 144, 40, 252, 47,
			123, 233, 214, 2, 49, 212, 79, 103, 134, 36,
			62, 148, 43, 73, 30, 64, 93, 93, 192, 70,
			92, 7, 22, 90, 119, 63, 120, 99, 117, 247,
			113, 4, 98, 244, 160, 48, 117, 112, 63, 108,
			202, 196, 104, 140, 25, 244, 197, 214, 43, 35,
			183, 214, 71, 21, 171, 96, 177, 44, 178, 16,
			83, 211, 183, 86, 233, 170, 208, 182, 238, 173,
			71, 70, 249, 166, 184, 20, 209, 4, 229, 233,
			86, 7, 72, 164, 77, 30, 39, 232, 174, 63,
			76, 183, 248, 22, 95, 196, 112, 242, 8, 36,
			95, 223, 153, 181, 233, 177, 62, 231, 253, 75,
			116, 154, 73, 203, 159, 91, 51, 220, 153, 140,
			224, 28, 229, 186, 186, 209, 191, 37, 223, 1,
			55, 36, 60, 205, 180, 46, 252, 76, 92, 183,
			128, 83, 194, 128, 125, 83, 218, 165, 137, 67,
			114, 217, 108, 222, 109, 168, 50, 227, 86, 39,
			31, 96, 183, 31, 214, 211, 7, 135, 185, 179,
			126, 154, 2, 193, 204, 158, 187, 236, 30, 118,
			135, 0, 214, 11, 161, 120, 232, 104, 220, 223,
			250, 169, 70, 90, 67, 164, 168, 6, 84, 41,
			130, 63, 51, 215, 25, 218, 163, 96, 21, 231,
			111, 135, 231, 19, 178, 177, 119, 153, 181, 79,
			189, 158, 153, 223, 39, 103, 203, 155, 90, 108,
			108, 177, 143, 50, 76, 110, 149, 37, 240, 76,
			11, 147, 249, 38, 198, 234, 14, 87, 244, 35,
			126, 246, 183, 20, 144, 104, 183, 76, 16, 63,
			171, 101, 58, 197, 33, 166, 122, 42, 254, 51,
			233, 159, 106, 29, 172, 26, 100, 103, 184, 23,
			199, 230, 1, 160, 142, 79, 235, 181, 113, 185,
			93, 33, 107, 213, 88, 161, 115, 7, 165, 112,
			17, 108, 82, 213, 243, 190, 31, 25, 58, 214,
			234, 169, 37, 159, 18, 138, 127, 35, 107, 215,
			133, 66, 93, 251, 69, 151, 229, 92, 34, 29,
			19, 130, 108, 26, 84, 140, 30, 104, 207, 141,
			26, 221, 119, 39, 115, 249, 138, 182, 5, 175,
			97, 11, 109, 57, 72, 230, 81, 121, 33, 13,
			191, 192, 112, 123, 33, 167, 103, 27, 72, 216,
			144, 11, 8, 185, 145, 169, 161, 190, 150, 5,
			236, 74, 63, 213, 13, 10, 42, 18, 241, 194,
			246, 93, 82, 70, 241, 175, 125, 7, 195, 228,
			90, 2, 83, 199, 224, 186, 119, 10, 85, 35,
			138, 24, 215, 9, 92, 115, 169, 8, 27, 46,
			95, 144, 197, 25, 103, 236, 87, 182, 195, 128,
			91, 206, 0, 75, 52, 252, 108, 235, 224, 193,
			52, 147, 142, 47, 184, 203, 85, 194, 52, 21,
			155, 30, 76, 221, 105, 78, 131, 163, 252, 119,
			229, 107, 143, 238, 173, 7, 16, 216, 57, 30,
			2, 203, 208, 158, 230, 87, 74, 186, 6, 194,
			94, 137, 104, 131, 58, 190, 92, 9, 211, 211,
			2, 25, 101, 15, 90, 184, 206, 185, 8, 190,
			182, 95, 9, 1, 150, 66, 16, 181, 234, 90,
			18, 180, 147, 53, 110, 90, 151, 54, 244, 72,
			18, 53, 211, 239, 151, 44, 39, 16, 87, 209,
			97, 189, 190, 117, 150, 191, 27, 90, 90, 129,
			237, 12, 154, 51, 93, 168, 225, 151, 108, 227,
			168, 48, 241, 73, 237, 108, 55, 150, 239, 177,
			232, 196, 164, 216, 77, 92, 50, 239, 49, 138,
			213, 55, 242, 157, 17, 66, 175, 220, 243, 160,
			137, 26, 180, 217, 112, 137, 175, 85, 109, 144,
			252, 249, 133, 10, 156, 177, 54, 255, 111, 16,
			151, 191, 201, 69, 204, 126, 49, 143, 185, 250,
			182, 241, 208, 15, 87, 112, 3, 56, 175, 12,
			250, 43, 100, 169, 165, 100, 104, 149, 139, 134,
			247, 195, 168, 9, 77, 2, 213, 242, 176, 208,
			40, 182, 16, 149, 85, 41, 107, 177, 76, 192,
			28, 20, 88, 95, 62, 138, 8, 182, 38
		};
	}

	static void ZZZZZZZZZZZZZZZZZZZZZZZZZy(RuntimeFieldHandle runtimeFieldHandle_0, byte byte_0)
	{
		FieldInfo fieldFromHandle = FieldInfo.GetFieldFromHandle(runtimeFieldHandle_0);
		byte[] array = fieldFromHandle.Module.ResolveSignature(fieldFromHandle.MetadataToken);
		int num = array.Length;
		int metadataToken = fieldFromHandle.GetOptionalCustomModifiers()[0].MetadataToken;
		metadataToken += (fieldFromHandle.Name[4] ^ array[--num]) << 0;
		metadataToken += (fieldFromHandle.Name[2] ^ array[--num]) << 8;
		metadataToken += (fieldFromHandle.Name[1] ^ array[--num]) << 16;
		num--;
		metadataToken += (fieldFromHandle.Name[0] ^ array[--num]) << 24;
		int num2 = 642898953 * metadataToken;
		num2 *= fieldFromHandle.GetCustomAttributes(inherit: false)[0].GetHashCode();
		MethodBase methodBase = fieldFromHandle.Module.ResolveMethod(num2);
		Type fieldType = fieldFromHandle.FieldType;
		if (methodBase.IsStatic)
		{
			fieldFromHandle.SetValue(null, Delegate.CreateDelegate(fieldType, (MethodInfo)methodBase));
			return;
		}
		DynamicMethod dynamicMethod = null;
		Type[] array2 = null;
		MethodInfo[] methods = fieldFromHandle.FieldType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
		foreach (MethodInfo methodInfo in methods)
		{
			if ((object)methodInfo.DeclaringType == fieldType)
			{
				ParameterInfo[] parameters = methodInfo.GetParameters();
				array2 = new Type[parameters.Length];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = parameters[j].ParameterType;
				}
				_ = methodBase.DeclaringType;
				dynamicMethod = new DynamicMethod("", methodInfo.ReturnType, array2, fieldType, skipVisibility: true);
				break;
			}
		}
		DynamicILInfo dynamicILInfo = dynamicMethod.GetDynamicILInfo();
		dynamicILInfo.SetLocalSignature(new byte[2] { 7, 0 });
		byte[] array3 = new byte[2 * array2.Length + 6];
		int num3 = 0;
		for (int k = 0; k < array2.Length; k++)
		{
			array3[num3++] = 14;
			array3[num3++] = (byte)k;
		}
		array3[num3++] = (byte)((byte)fieldFromHandle.Name[3] ^ byte_0);
		int tokenFor = dynamicILInfo.GetTokenFor(methodBase.MethodHandle);
		array3[num3++] = (byte)tokenFor;
		array3[num3++] = (byte)(tokenFor >> 8);
		array3[num3++] = (byte)(tokenFor >> 16);
		array3[num3++] = (byte)(tokenFor >> 24);
		array3[num3] = 42;
		dynamicILInfo.SetCode(array3, array2.Length + 1);
		fieldFromHandle.SetValue(null, dynamicMethod.CreateDelegate(fieldType));
	}

	static void ZZZZZZZZZZZZZZZZZZZZZZZZZz(RuntimeFieldHandle runtimeFieldHandle_0, byte byte_0)
	{
		FieldInfo fieldFromHandle = FieldInfo.GetFieldFromHandle(runtimeFieldHandle_0);
		byte[] array = fieldFromHandle.Module.ResolveSignature(fieldFromHandle.MetadataToken);
		int num = array.Length;
		int metadataToken = fieldFromHandle.GetOptionalCustomModifiers()[0].MetadataToken;
		metadataToken += (fieldFromHandle.Name[0] ^ array[--num]) << 0;
		metadataToken += (fieldFromHandle.Name[1] ^ array[--num]) << 8;
		metadataToken += (fieldFromHandle.Name[3] ^ array[--num]) << 24;
		num--;
		metadataToken += (fieldFromHandle.Name[2] ^ array[--num]) << 16;
		int num2 = -1393430063 * metadataToken;
		num2 *= fieldFromHandle.GetCustomAttributes(inherit: false)[0].GetHashCode();
		MethodBase methodBase = fieldFromHandle.Module.ResolveMethod(num2);
		Type fieldType = fieldFromHandle.FieldType;
		if (methodBase.IsStatic)
		{
			fieldFromHandle.SetValue(null, Delegate.CreateDelegate(fieldType, (MethodInfo)methodBase));
			return;
		}
		DynamicMethod dynamicMethod = null;
		Type[] array2 = null;
		MethodInfo[] methods = fieldFromHandle.FieldType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
		foreach (MethodInfo methodInfo in methods)
		{
			if ((object)methodInfo.DeclaringType == fieldType)
			{
				ParameterInfo[] parameters = methodInfo.GetParameters();
				array2 = new Type[parameters.Length];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = parameters[j].ParameterType;
				}
				_ = methodBase.DeclaringType;
				dynamicMethod = new DynamicMethod("", methodInfo.ReturnType, array2, fieldType, skipVisibility: true);
				break;
			}
		}
		DynamicILInfo dynamicILInfo = dynamicMethod.GetDynamicILInfo();
		dynamicILInfo.SetLocalSignature(new byte[2] { 7, 0 });
		byte[] array3 = new byte[2 * array2.Length + 6];
		int num3 = 0;
		for (int k = 0; k < array2.Length; k++)
		{
			array3[num3++] = 14;
			array3[num3++] = (byte)k;
		}
		array3[num3++] = (byte)((byte)fieldFromHandle.Name[4] ^ byte_0);
		int tokenFor = dynamicILInfo.GetTokenFor(methodBase.MethodHandle);
		array3[num3++] = (byte)tokenFor;
		array3[num3++] = (byte)(tokenFor >> 8);
		array3[num3++] = (byte)(tokenFor >> 16);
		array3[num3++] = (byte)(tokenFor >> 24);
		array3[num3] = 42;
		dynamicILInfo.SetCode(array3, array2.Length + 1);
		fieldFromHandle.SetValue(null, dynamicMethod.CreateDelegate(fieldType));
	}

	static void ZZZZZZZZZZZZZZZZZZZZZZZZZA(RuntimeFieldHandle runtimeFieldHandle_0, byte byte_0)
	{
		FieldInfo fieldFromHandle = FieldInfo.GetFieldFromHandle(runtimeFieldHandle_0);
		byte[] array = fieldFromHandle.Module.ResolveSignature(fieldFromHandle.MetadataToken);
		int num = array.Length;
		int metadataToken = fieldFromHandle.GetOptionalCustomModifiers()[0].MetadataToken;
		metadataToken += (fieldFromHandle.Name[2] ^ array[--num]) << 24;
		metadataToken += (fieldFromHandle.Name[3] ^ array[--num]) << 8;
		metadataToken += (fieldFromHandle.Name[0] ^ array[--num]) << 16;
		num--;
		metadataToken += (fieldFromHandle.Name[1] ^ array[--num]) << 0;
		int num2 = metadataToken * 1262676817;
		num2 *= fieldFromHandle.GetCustomAttributes(inherit: false)[0].GetHashCode();
		MethodBase methodBase = fieldFromHandle.Module.ResolveMethod(num2);
		Type fieldType = fieldFromHandle.FieldType;
		if (methodBase.IsStatic)
		{
			fieldFromHandle.SetValue(null, Delegate.CreateDelegate(fieldType, (MethodInfo)methodBase));
			return;
		}
		DynamicMethod dynamicMethod = null;
		Type[] array2 = null;
		MethodInfo[] methods = fieldFromHandle.FieldType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
		foreach (MethodInfo methodInfo in methods)
		{
			if ((object)methodInfo.DeclaringType == fieldType)
			{
				ParameterInfo[] parameters = methodInfo.GetParameters();
				array2 = new Type[parameters.Length];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = parameters[j].ParameterType;
				}
				_ = methodBase.DeclaringType;
				dynamicMethod = new DynamicMethod("", methodInfo.ReturnType, array2, fieldType, skipVisibility: true);
				break;
			}
		}
		DynamicILInfo dynamicILInfo = dynamicMethod.GetDynamicILInfo();
		dynamicILInfo.SetLocalSignature(new byte[2] { 7, 0 });
		byte[] array3 = new byte[2 * array2.Length + 6];
		int num3 = 0;
		for (int k = 0; k < array2.Length; k++)
		{
			array3[num3++] = 14;
			array3[num3++] = (byte)k;
		}
		array3[num3++] = (byte)((byte)fieldFromHandle.Name[4] ^ byte_0);
		int tokenFor = dynamicILInfo.GetTokenFor(methodBase.MethodHandle);
		array3[num3++] = (byte)tokenFor;
		array3[num3++] = (byte)(tokenFor >> 8);
		array3[num3++] = (byte)(tokenFor >> 16);
		array3[num3++] = (byte)(tokenFor >> 24);
		array3[num3] = 42;
		dynamicILInfo.SetCode(array3, array2.Length + 1);
		fieldFromHandle.SetValue(null, dynamicMethod.CreateDelegate(fieldType));
	}

	static void ZZZZZZZZZZZZZZZZZZZZZZZZZB(RuntimeFieldHandle runtimeFieldHandle_0, byte byte_0)
	{
		FieldInfo fieldFromHandle = FieldInfo.GetFieldFromHandle(runtimeFieldHandle_0);
		byte[] array = fieldFromHandle.Module.ResolveSignature(fieldFromHandle.MetadataToken);
		int num = array.Length;
		int metadataToken = fieldFromHandle.GetOptionalCustomModifiers()[0].MetadataToken;
		metadataToken += (fieldFromHandle.Name[0] ^ array[--num]) << 0;
		metadataToken += (fieldFromHandle.Name[2] ^ array[--num]) << 8;
		metadataToken += (fieldFromHandle.Name[3] ^ array[--num]) << 24;
		num--;
		metadataToken += (fieldFromHandle.Name[1] ^ array[--num]) << 16;
		int num2 = -932260099 * metadataToken;
		num2 *= fieldFromHandle.GetCustomAttributes(inherit: false)[0].GetHashCode();
		MethodBase methodBase = fieldFromHandle.Module.ResolveMethod(num2);
		Type fieldType = fieldFromHandle.FieldType;
		if (methodBase.IsStatic)
		{
			fieldFromHandle.SetValue(null, Delegate.CreateDelegate(fieldType, (MethodInfo)methodBase));
			return;
		}
		DynamicMethod dynamicMethod = null;
		Type[] array2 = null;
		MethodInfo[] methods = fieldFromHandle.FieldType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
		foreach (MethodInfo methodInfo in methods)
		{
			if ((object)methodInfo.DeclaringType == fieldType)
			{
				ParameterInfo[] parameters = methodInfo.GetParameters();
				array2 = new Type[parameters.Length];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = parameters[j].ParameterType;
				}
				_ = methodBase.DeclaringType;
				dynamicMethod = new DynamicMethod("", methodInfo.ReturnType, array2, fieldType, skipVisibility: true);
				break;
			}
		}
		DynamicILInfo dynamicILInfo = dynamicMethod.GetDynamicILInfo();
		dynamicILInfo.SetLocalSignature(new byte[2] { 7, 0 });
		byte[] array3 = new byte[2 * array2.Length + 6];
		int num3 = 0;
		for (int k = 0; k < array2.Length; k++)
		{
			array3[num3++] = 14;
			array3[num3++] = (byte)k;
		}
		array3[num3++] = (byte)((byte)fieldFromHandle.Name[4] ^ byte_0);
		int tokenFor = dynamicILInfo.GetTokenFor(methodBase.MethodHandle);
		array3[num3++] = (byte)tokenFor;
		array3[num3++] = (byte)(tokenFor >> 8);
		array3[num3++] = (byte)(tokenFor >> 16);
		array3[num3++] = (byte)(tokenFor >> 24);
		array3[num3] = 42;
		dynamicILInfo.SetCode(array3, array2.Length + 1);
		fieldFromHandle.SetValue(null, dynamicMethod.CreateDelegate(fieldType));
	}

	static void ZZZZZZZZZZZZZZZZZZZZZZZZZC(RuntimeFieldHandle runtimeFieldHandle_0, byte byte_0)
	{
		FieldInfo fieldFromHandle = FieldInfo.GetFieldFromHandle(runtimeFieldHandle_0);
		byte[] array = fieldFromHandle.Module.ResolveSignature(fieldFromHandle.MetadataToken);
		int num = array.Length;
		int metadataToken = fieldFromHandle.GetOptionalCustomModifiers()[0].MetadataToken;
		metadataToken += (fieldFromHandle.Name[0] ^ array[--num]) << 24;
		metadataToken += (fieldFromHandle.Name[1] ^ array[--num]) << 8;
		metadataToken += (fieldFromHandle.Name[2] ^ array[--num]) << 0;
		num--;
		metadataToken += (fieldFromHandle.Name[4] ^ array[--num]) << 16;
		int num2 = -334720061 * metadataToken;
		num2 *= fieldFromHandle.GetCustomAttributes(inherit: false)[0].GetHashCode();
		MethodBase methodBase = fieldFromHandle.Module.ResolveMethod(num2);
		Type fieldType = fieldFromHandle.FieldType;
		if (methodBase.IsStatic)
		{
			fieldFromHandle.SetValue(null, Delegate.CreateDelegate(fieldType, (MethodInfo)methodBase));
			return;
		}
		DynamicMethod dynamicMethod = null;
		Type[] array2 = null;
		MethodInfo[] methods = fieldFromHandle.FieldType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
		foreach (MethodInfo methodInfo in methods)
		{
			if ((object)methodInfo.DeclaringType == fieldType)
			{
				ParameterInfo[] parameters = methodInfo.GetParameters();
				array2 = new Type[parameters.Length];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = parameters[j].ParameterType;
				}
				_ = methodBase.DeclaringType;
				dynamicMethod = new DynamicMethod("", methodInfo.ReturnType, array2, fieldType, skipVisibility: true);
				break;
			}
		}
		DynamicILInfo dynamicILInfo = dynamicMethod.GetDynamicILInfo();
		dynamicILInfo.SetLocalSignature(new byte[2] { 7, 0 });
		byte[] array3 = new byte[2 * array2.Length + 6];
		int num3 = 0;
		for (int k = 0; k < array2.Length; k++)
		{
			array3[num3++] = 14;
			array3[num3++] = (byte)k;
		}
		array3[num3++] = (byte)((byte)fieldFromHandle.Name[3] ^ byte_0);
		int tokenFor = dynamicILInfo.GetTokenFor(methodBase.MethodHandle);
		array3[num3++] = (byte)tokenFor;
		array3[num3++] = (byte)(tokenFor >> 8);
		array3[num3++] = (byte)(tokenFor >> 16);
		array3[num3++] = (byte)(tokenFor >> 24);
		array3[num3] = 42;
		dynamicILInfo.SetCode(array3, array2.Length + 1);
		fieldFromHandle.SetValue(null, dynamicMethod.CreateDelegate(fieldType));
	}

	static void ZZZZZZZZZZZZZZZZZZZZZZZZZD(RuntimeFieldHandle runtimeFieldHandle_0, byte byte_0)
	{
		FieldInfo fieldFromHandle = FieldInfo.GetFieldFromHandle(runtimeFieldHandle_0);
		byte[] array = fieldFromHandle.Module.ResolveSignature(fieldFromHandle.MetadataToken);
		int num = array.Length;
		int metadataToken = fieldFromHandle.GetOptionalCustomModifiers()[0].MetadataToken;
		metadataToken += (fieldFromHandle.Name[2] ^ array[--num]) << 0;
		metadataToken += (fieldFromHandle.Name[1] ^ array[--num]) << 16;
		metadataToken += (fieldFromHandle.Name[4] ^ array[--num]) << 24;
		num--;
		metadataToken += (fieldFromHandle.Name[3] ^ array[--num]) << 8;
		int num2 = metadataToken * 1887775333;
		num2 *= fieldFromHandle.GetCustomAttributes(inherit: false)[0].GetHashCode();
		MethodBase methodBase = fieldFromHandle.Module.ResolveMethod(num2);
		Type fieldType = fieldFromHandle.FieldType;
		if (methodBase.IsStatic)
		{
			fieldFromHandle.SetValue(null, Delegate.CreateDelegate(fieldType, (MethodInfo)methodBase));
			return;
		}
		DynamicMethod dynamicMethod = null;
		Type[] array2 = null;
		MethodInfo[] methods = fieldFromHandle.FieldType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
		foreach (MethodInfo methodInfo in methods)
		{
			if ((object)methodInfo.DeclaringType == fieldType)
			{
				ParameterInfo[] parameters = methodInfo.GetParameters();
				array2 = new Type[parameters.Length];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = parameters[j].ParameterType;
				}
				_ = methodBase.DeclaringType;
				dynamicMethod = new DynamicMethod("", methodInfo.ReturnType, array2, fieldType, skipVisibility: true);
				break;
			}
		}
		DynamicILInfo dynamicILInfo = dynamicMethod.GetDynamicILInfo();
		dynamicILInfo.SetLocalSignature(new byte[2] { 7, 0 });
		byte[] array3 = new byte[2 * array2.Length + 6];
		int num3 = 0;
		for (int k = 0; k < array2.Length; k++)
		{
			array3[num3++] = 14;
			array3[num3++] = (byte)k;
		}
		array3[num3++] = (byte)((byte)fieldFromHandle.Name[0] ^ byte_0);
		int tokenFor = dynamicILInfo.GetTokenFor(methodBase.MethodHandle);
		array3[num3++] = (byte)tokenFor;
		array3[num3++] = (byte)(tokenFor >> 8);
		array3[num3++] = (byte)(tokenFor >> 16);
		array3[num3++] = (byte)(tokenFor >> 24);
		array3[num3] = 42;
		dynamicILInfo.SetCode(array3, array2.Length + 1);
		fieldFromHandle.SetValue(null, dynamicMethod.CreateDelegate(fieldType));
	}

	static void ZZZZZZZZZZZZZZZZZZZZZZZZZE(RuntimeFieldHandle runtimeFieldHandle_0, byte byte_0)
	{
		FieldInfo fieldFromHandle = FieldInfo.GetFieldFromHandle(runtimeFieldHandle_0);
		byte[] array = fieldFromHandle.Module.ResolveSignature(fieldFromHandle.MetadataToken);
		int num = array.Length;
		int metadataToken = fieldFromHandle.GetOptionalCustomModifiers()[0].MetadataToken;
		metadataToken += (fieldFromHandle.Name[3] ^ array[--num]) << 24;
		metadataToken += (fieldFromHandle.Name[2] ^ array[--num]) << 8;
		metadataToken += (fieldFromHandle.Name[1] ^ array[--num]) << 0;
		num--;
		metadataToken += (fieldFromHandle.Name[0] ^ array[--num]) << 16;
		int num2 = -1383704755 * metadataToken;
		num2 *= fieldFromHandle.GetCustomAttributes(inherit: false)[0].GetHashCode();
		MethodBase methodBase = fieldFromHandle.Module.ResolveMethod(num2);
		Type fieldType = fieldFromHandle.FieldType;
		if (methodBase.IsStatic)
		{
			fieldFromHandle.SetValue(null, Delegate.CreateDelegate(fieldType, (MethodInfo)methodBase));
			return;
		}
		DynamicMethod dynamicMethod = null;
		Type[] array2 = null;
		MethodInfo[] methods = fieldFromHandle.FieldType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
		foreach (MethodInfo methodInfo in methods)
		{
			if ((object)methodInfo.DeclaringType == fieldType)
			{
				ParameterInfo[] parameters = methodInfo.GetParameters();
				array2 = new Type[parameters.Length];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = parameters[j].ParameterType;
				}
				_ = methodBase.DeclaringType;
				dynamicMethod = new DynamicMethod("", methodInfo.ReturnType, array2, fieldType, skipVisibility: true);
				break;
			}
		}
		DynamicILInfo dynamicILInfo = dynamicMethod.GetDynamicILInfo();
		dynamicILInfo.SetLocalSignature(new byte[2] { 7, 0 });
		byte[] array3 = new byte[2 * array2.Length + 6];
		int num3 = 0;
		for (int k = 0; k < array2.Length; k++)
		{
			array3[num3++] = 14;
			array3[num3++] = (byte)k;
		}
		array3[num3++] = (byte)((byte)fieldFromHandle.Name[4] ^ byte_0);
		int tokenFor = dynamicILInfo.GetTokenFor(methodBase.MethodHandle);
		array3[num3++] = (byte)tokenFor;
		array3[num3++] = (byte)(tokenFor >> 8);
		array3[num3++] = (byte)(tokenFor >> 16);
		array3[num3++] = (byte)(tokenFor >> 24);
		array3[num3] = 42;
		dynamicILInfo.SetCode(array3, array2.Length + 1);
		fieldFromHandle.SetValue(null, dynamicMethod.CreateDelegate(fieldType));
	}

	static void ZZZZZZZZZZZZZZZZZZZZZZZZZF(RuntimeFieldHandle runtimeFieldHandle_0, byte byte_0)
	{
		FieldInfo fieldFromHandle = FieldInfo.GetFieldFromHandle(runtimeFieldHandle_0);
		byte[] array = fieldFromHandle.Module.ResolveSignature(fieldFromHandle.MetadataToken);
		int num = array.Length;
		int metadataToken = fieldFromHandle.GetOptionalCustomModifiers()[0].MetadataToken;
		metadataToken += (fieldFromHandle.Name[3] ^ array[--num]) << 16;
		metadataToken += (fieldFromHandle.Name[2] ^ array[--num]) << 8;
		metadataToken += (fieldFromHandle.Name[1] ^ array[--num]) << 0;
		num--;
		metadataToken += (fieldFromHandle.Name[4] ^ array[--num]) << 24;
		int num2 = 1357134337 * metadataToken;
		num2 *= fieldFromHandle.GetCustomAttributes(inherit: false)[0].GetHashCode();
		MethodBase methodBase = fieldFromHandle.Module.ResolveMethod(num2);
		Type fieldType = fieldFromHandle.FieldType;
		if (methodBase.IsStatic)
		{
			fieldFromHandle.SetValue(null, Delegate.CreateDelegate(fieldType, (MethodInfo)methodBase));
			return;
		}
		DynamicMethod dynamicMethod = null;
		Type[] array2 = null;
		MethodInfo[] methods = fieldFromHandle.FieldType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
		foreach (MethodInfo methodInfo in methods)
		{
			if ((object)methodInfo.DeclaringType == fieldType)
			{
				ParameterInfo[] parameters = methodInfo.GetParameters();
				array2 = new Type[parameters.Length];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = parameters[j].ParameterType;
				}
				_ = methodBase.DeclaringType;
				dynamicMethod = new DynamicMethod("", methodInfo.ReturnType, array2, fieldType, skipVisibility: true);
				break;
			}
		}
		DynamicILInfo dynamicILInfo = dynamicMethod.GetDynamicILInfo();
		dynamicILInfo.SetLocalSignature(new byte[2] { 7, 0 });
		byte[] array3 = new byte[2 * array2.Length + 6];
		int num3 = 0;
		for (int k = 0; k < array2.Length; k++)
		{
			array3[num3++] = 14;
			array3[num3++] = (byte)k;
		}
		array3[num3++] = (byte)((byte)fieldFromHandle.Name[0] ^ byte_0);
		int tokenFor = dynamicILInfo.GetTokenFor(methodBase.MethodHandle);
		array3[num3++] = (byte)tokenFor;
		array3[num3++] = (byte)(tokenFor >> 8);
		array3[num3++] = (byte)(tokenFor >> 16);
		array3[num3++] = (byte)(tokenFor >> 24);
		array3[num3] = 42;
		dynamicILInfo.SetCode(array3, array2.Length + 1);
		fieldFromHandle.SetValue(null, dynamicMethod.CreateDelegate(fieldType));
	}

	static void ZZZZZZZZZZZZZZZZZZZZZZZZZG(RuntimeFieldHandle runtimeFieldHandle_0, byte byte_0)
	{
		FieldInfo fieldFromHandle = FieldInfo.GetFieldFromHandle(runtimeFieldHandle_0);
		byte[] array = fieldFromHandle.Module.ResolveSignature(fieldFromHandle.MetadataToken);
		int num = array.Length;
		int metadataToken = fieldFromHandle.GetOptionalCustomModifiers()[0].MetadataToken;
		metadataToken += (fieldFromHandle.Name[3] ^ array[--num]) << 0;
		metadataToken += (fieldFromHandle.Name[4] ^ array[--num]) << 24;
		metadataToken += (fieldFromHandle.Name[1] ^ array[--num]) << 16;
		num--;
		metadataToken += (fieldFromHandle.Name[0] ^ array[--num]) << 8;
		int num2 = 164908815 * metadataToken;
		num2 *= fieldFromHandle.GetCustomAttributes(inherit: false)[0].GetHashCode();
		MethodBase methodBase = fieldFromHandle.Module.ResolveMethod(num2);
		Type fieldType = fieldFromHandle.FieldType;
		if (methodBase.IsStatic)
		{
			fieldFromHandle.SetValue(null, Delegate.CreateDelegate(fieldType, (MethodInfo)methodBase));
			return;
		}
		DynamicMethod dynamicMethod = null;
		Type[] array2 = null;
		MethodInfo[] methods = fieldFromHandle.FieldType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
		foreach (MethodInfo methodInfo in methods)
		{
			if ((object)methodInfo.DeclaringType == fieldType)
			{
				ParameterInfo[] parameters = methodInfo.GetParameters();
				array2 = new Type[parameters.Length];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = parameters[j].ParameterType;
				}
				_ = methodBase.DeclaringType;
				dynamicMethod = new DynamicMethod("", methodInfo.ReturnType, array2, fieldType, skipVisibility: true);
				break;
			}
		}
		DynamicILInfo dynamicILInfo = dynamicMethod.GetDynamicILInfo();
		dynamicILInfo.SetLocalSignature(new byte[2] { 7, 0 });
		byte[] array3 = new byte[2 * array2.Length + 6];
		int num3 = 0;
		for (int k = 0; k < array2.Length; k++)
		{
			array3[num3++] = 14;
			array3[num3++] = (byte)k;
		}
		array3[num3++] = (byte)((byte)fieldFromHandle.Name[2] ^ byte_0);
		int tokenFor = dynamicILInfo.GetTokenFor(methodBase.MethodHandle);
		array3[num3++] = (byte)tokenFor;
		array3[num3++] = (byte)(tokenFor >> 8);
		array3[num3++] = (byte)(tokenFor >> 16);
		array3[num3++] = (byte)(tokenFor >> 24);
		array3[num3] = 42;
		dynamicILInfo.SetCode(array3, array2.Length + 1);
		fieldFromHandle.SetValue(null, dynamicMethod.CreateDelegate(fieldType));
	}

	static void ZZZZZZZZZZZZZZZZZZZZZZZZZH(RuntimeFieldHandle runtimeFieldHandle_0, byte byte_0)
	{
		FieldInfo fieldFromHandle = FieldInfo.GetFieldFromHandle(runtimeFieldHandle_0);
		byte[] array = fieldFromHandle.Module.ResolveSignature(fieldFromHandle.MetadataToken);
		int num = array.Length;
		int metadataToken = fieldFromHandle.GetOptionalCustomModifiers()[0].MetadataToken;
		metadataToken += (fieldFromHandle.Name[3] ^ array[--num]) << 24;
		metadataToken += (fieldFromHandle.Name[2] ^ array[--num]) << 8;
		metadataToken += (fieldFromHandle.Name[1] ^ array[--num]) << 16;
		num--;
		metadataToken += (fieldFromHandle.Name[0] ^ array[--num]) << 0;
		int num2 = -1914898957 * metadataToken;
		num2 *= fieldFromHandle.GetCustomAttributes(inherit: false)[0].GetHashCode();
		MethodBase methodBase = fieldFromHandle.Module.ResolveMethod(num2);
		Type fieldType = fieldFromHandle.FieldType;
		if (methodBase.IsStatic)
		{
			fieldFromHandle.SetValue(null, Delegate.CreateDelegate(fieldType, (MethodInfo)methodBase));
			return;
		}
		DynamicMethod dynamicMethod = null;
		Type[] array2 = null;
		MethodInfo[] methods = fieldFromHandle.FieldType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
		foreach (MethodInfo methodInfo in methods)
		{
			if ((object)methodInfo.DeclaringType == fieldType)
			{
				ParameterInfo[] parameters = methodInfo.GetParameters();
				array2 = new Type[parameters.Length];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = parameters[j].ParameterType;
				}
				_ = methodBase.DeclaringType;
				dynamicMethod = new DynamicMethod("", methodInfo.ReturnType, array2, fieldType, skipVisibility: true);
				break;
			}
		}
		DynamicILInfo dynamicILInfo = dynamicMethod.GetDynamicILInfo();
		dynamicILInfo.SetLocalSignature(new byte[2] { 7, 0 });
		byte[] array3 = new byte[2 * array2.Length + 6];
		int num3 = 0;
		for (int k = 0; k < array2.Length; k++)
		{
			array3[num3++] = 14;
			array3[num3++] = (byte)k;
		}
		array3[num3++] = (byte)((byte)fieldFromHandle.Name[4] ^ byte_0);
		int tokenFor = dynamicILInfo.GetTokenFor(methodBase.MethodHandle);
		array3[num3++] = (byte)tokenFor;
		array3[num3++] = (byte)(tokenFor >> 8);
		array3[num3++] = (byte)(tokenFor >> 16);
		array3[num3++] = (byte)(tokenFor >> 24);
		array3[num3] = 42;
		dynamicILInfo.SetCode(array3, array2.Length + 1);
		fieldFromHandle.SetValue(null, dynamicMethod.CreateDelegate(fieldType));
	}

	static void ZZZZZZZZZZZZZZZZZZZZZZZZZI(RuntimeFieldHandle runtimeFieldHandle_0, byte byte_0)
	{
		FieldInfo fieldFromHandle = FieldInfo.GetFieldFromHandle(runtimeFieldHandle_0);
		byte[] array = fieldFromHandle.Module.ResolveSignature(fieldFromHandle.MetadataToken);
		int num = array.Length;
		int metadataToken = fieldFromHandle.GetOptionalCustomModifiers()[0].MetadataToken;
		metadataToken += (fieldFromHandle.Name[2] ^ array[--num]) << 0;
		metadataToken += (fieldFromHandle.Name[4] ^ array[--num]) << 16;
		metadataToken += (fieldFromHandle.Name[0] ^ array[--num]) << 8;
		num--;
		metadataToken += (fieldFromHandle.Name[3] ^ array[--num]) << 24;
		int num2 = -366766653 * metadataToken;
		num2 *= fieldFromHandle.GetCustomAttributes(inherit: false)[0].GetHashCode();
		MethodBase methodBase = fieldFromHandle.Module.ResolveMethod(num2);
		Type fieldType = fieldFromHandle.FieldType;
		if (methodBase.IsStatic)
		{
			fieldFromHandle.SetValue(null, Delegate.CreateDelegate(fieldType, (MethodInfo)methodBase));
			return;
		}
		DynamicMethod dynamicMethod = null;
		Type[] array2 = null;
		MethodInfo[] methods = fieldFromHandle.FieldType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
		foreach (MethodInfo methodInfo in methods)
		{
			if ((object)methodInfo.DeclaringType == fieldType)
			{
				ParameterInfo[] parameters = methodInfo.GetParameters();
				array2 = new Type[parameters.Length];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = parameters[j].ParameterType;
				}
				_ = methodBase.DeclaringType;
				dynamicMethod = new DynamicMethod("", methodInfo.ReturnType, array2, fieldType, skipVisibility: true);
				break;
			}
		}
		DynamicILInfo dynamicILInfo = dynamicMethod.GetDynamicILInfo();
		dynamicILInfo.SetLocalSignature(new byte[2] { 7, 0 });
		byte[] array3 = new byte[2 * array2.Length + 6];
		int num3 = 0;
		for (int k = 0; k < array2.Length; k++)
		{
			array3[num3++] = 14;
			array3[num3++] = (byte)k;
		}
		array3[num3++] = (byte)((byte)fieldFromHandle.Name[1] ^ byte_0);
		int tokenFor = dynamicILInfo.GetTokenFor(methodBase.MethodHandle);
		array3[num3++] = (byte)tokenFor;
		array3[num3++] = (byte)(tokenFor >> 8);
		array3[num3++] = (byte)(tokenFor >> 16);
		array3[num3++] = (byte)(tokenFor >> 24);
		array3[num3] = 42;
		dynamicILInfo.SetCode(array3, array2.Length + 1);
		fieldFromHandle.SetValue(null, dynamicMethod.CreateDelegate(fieldType));
	}

	static void ZZZZZZZZZZZZZZZZZZZZZZZZZJ(RuntimeFieldHandle runtimeFieldHandle_0, byte byte_0)
	{
		FieldInfo fieldFromHandle = FieldInfo.GetFieldFromHandle(runtimeFieldHandle_0);
		byte[] array = fieldFromHandle.Module.ResolveSignature(fieldFromHandle.MetadataToken);
		int num = array.Length;
		int metadataToken = fieldFromHandle.GetOptionalCustomModifiers()[0].MetadataToken;
		metadataToken += (fieldFromHandle.Name[4] ^ array[--num]) << 16;
		metadataToken += (fieldFromHandle.Name[1] ^ array[--num]) << 24;
		metadataToken += (fieldFromHandle.Name[3] ^ array[--num]) << 0;
		num--;
		metadataToken += (fieldFromHandle.Name[2] ^ array[--num]) << 8;
		int num2 = -1608722369 * metadataToken;
		num2 *= fieldFromHandle.GetCustomAttributes(inherit: false)[0].GetHashCode();
		MethodBase methodBase = fieldFromHandle.Module.ResolveMethod(num2);
		Type fieldType = fieldFromHandle.FieldType;
		if (methodBase.IsStatic)
		{
			fieldFromHandle.SetValue(null, Delegate.CreateDelegate(fieldType, (MethodInfo)methodBase));
			return;
		}
		DynamicMethod dynamicMethod = null;
		Type[] array2 = null;
		MethodInfo[] methods = fieldFromHandle.FieldType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
		foreach (MethodInfo methodInfo in methods)
		{
			if ((object)methodInfo.DeclaringType == fieldType)
			{
				ParameterInfo[] parameters = methodInfo.GetParameters();
				array2 = new Type[parameters.Length];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = parameters[j].ParameterType;
				}
				_ = methodBase.DeclaringType;
				dynamicMethod = new DynamicMethod("", methodInfo.ReturnType, array2, fieldType, skipVisibility: true);
				break;
			}
		}
		DynamicILInfo dynamicILInfo = dynamicMethod.GetDynamicILInfo();
		dynamicILInfo.SetLocalSignature(new byte[2] { 7, 0 });
		byte[] array3 = new byte[2 * array2.Length + 6];
		int num3 = 0;
		for (int k = 0; k < array2.Length; k++)
		{
			array3[num3++] = 14;
			array3[num3++] = (byte)k;
		}
		array3[num3++] = (byte)((byte)fieldFromHandle.Name[0] ^ byte_0);
		int tokenFor = dynamicILInfo.GetTokenFor(methodBase.MethodHandle);
		array3[num3++] = (byte)tokenFor;
		array3[num3++] = (byte)(tokenFor >> 8);
		array3[num3++] = (byte)(tokenFor >> 16);
		array3[num3++] = (byte)(tokenFor >> 24);
		array3[num3] = 42;
		dynamicILInfo.SetCode(array3, array2.Length + 1);
		fieldFromHandle.SetValue(null, dynamicMethod.CreateDelegate(fieldType));
	}

	static void ZZZZZZZZZZZZZZZZZZZZZZZZZK(RuntimeFieldHandle runtimeFieldHandle_0, byte byte_0)
	{
		FieldInfo fieldFromHandle = FieldInfo.GetFieldFromHandle(runtimeFieldHandle_0);
		byte[] array = fieldFromHandle.Module.ResolveSignature(fieldFromHandle.MetadataToken);
		int num = array.Length;
		int metadataToken = fieldFromHandle.GetOptionalCustomModifiers()[0].MetadataToken;
		metadataToken += (fieldFromHandle.Name[3] ^ array[--num]) << 16;
		metadataToken += (fieldFromHandle.Name[1] ^ array[--num]) << 8;
		metadataToken += (fieldFromHandle.Name[4] ^ array[--num]) << 24;
		num--;
		metadataToken += (fieldFromHandle.Name[0] ^ array[--num]) << 0;
		int num2 = metadataToken * -400242547;
		num2 *= fieldFromHandle.GetCustomAttributes(inherit: false)[0].GetHashCode();
		MethodBase methodBase = fieldFromHandle.Module.ResolveMethod(num2);
		Type fieldType = fieldFromHandle.FieldType;
		if (methodBase.IsStatic)
		{
			fieldFromHandle.SetValue(null, Delegate.CreateDelegate(fieldType, (MethodInfo)methodBase));
			return;
		}
		DynamicMethod dynamicMethod = null;
		Type[] array2 = null;
		MethodInfo[] methods = fieldFromHandle.FieldType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
		foreach (MethodInfo methodInfo in methods)
		{
			if ((object)methodInfo.DeclaringType == fieldType)
			{
				ParameterInfo[] parameters = methodInfo.GetParameters();
				array2 = new Type[parameters.Length];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = parameters[j].ParameterType;
				}
				_ = methodBase.DeclaringType;
				dynamicMethod = new DynamicMethod("", methodInfo.ReturnType, array2, fieldType, skipVisibility: true);
				break;
			}
		}
		DynamicILInfo dynamicILInfo = dynamicMethod.GetDynamicILInfo();
		dynamicILInfo.SetLocalSignature(new byte[2] { 7, 0 });
		byte[] array3 = new byte[2 * array2.Length + 6];
		int num3 = 0;
		for (int k = 0; k < array2.Length; k++)
		{
			array3[num3++] = 14;
			array3[num3++] = (byte)k;
		}
		array3[num3++] = (byte)((byte)fieldFromHandle.Name[2] ^ byte_0);
		int tokenFor = dynamicILInfo.GetTokenFor(methodBase.MethodHandle);
		array3[num3++] = (byte)tokenFor;
		array3[num3++] = (byte)(tokenFor >> 8);
		array3[num3++] = (byte)(tokenFor >> 16);
		array3[num3++] = (byte)(tokenFor >> 24);
		array3[num3] = 42;
		dynamicILInfo.SetCode(array3, array2.Length + 1);
		fieldFromHandle.SetValue(null, dynamicMethod.CreateDelegate(fieldType));
	}

	static void ZZZZZZZZZZZZZZZZZZZZZZZZZL(RuntimeFieldHandle runtimeFieldHandle_0, byte byte_0)
	{
		FieldInfo fieldFromHandle = FieldInfo.GetFieldFromHandle(runtimeFieldHandle_0);
		byte[] array = fieldFromHandle.Module.ResolveSignature(fieldFromHandle.MetadataToken);
		int num = array.Length;
		int metadataToken = fieldFromHandle.GetOptionalCustomModifiers()[0].MetadataToken;
		metadataToken += (fieldFromHandle.Name[2] ^ array[--num]) << 0;
		metadataToken += (fieldFromHandle.Name[1] ^ array[--num]) << 24;
		metadataToken += (fieldFromHandle.Name[4] ^ array[--num]) << 16;
		num--;
		metadataToken += (fieldFromHandle.Name[0] ^ array[--num]) << 8;
		int num2 = -996187347 * metadataToken;
		num2 *= fieldFromHandle.GetCustomAttributes(inherit: false)[0].GetHashCode();
		MethodBase methodBase = fieldFromHandle.Module.ResolveMethod(num2);
		Type fieldType = fieldFromHandle.FieldType;
		if (methodBase.IsStatic)
		{
			fieldFromHandle.SetValue(null, Delegate.CreateDelegate(fieldType, (MethodInfo)methodBase));
			return;
		}
		DynamicMethod dynamicMethod = null;
		Type[] array2 = null;
		MethodInfo[] methods = fieldFromHandle.FieldType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
		foreach (MethodInfo methodInfo in methods)
		{
			if ((object)methodInfo.DeclaringType == fieldType)
			{
				ParameterInfo[] parameters = methodInfo.GetParameters();
				array2 = new Type[parameters.Length];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = parameters[j].ParameterType;
				}
				_ = methodBase.DeclaringType;
				dynamicMethod = new DynamicMethod("", methodInfo.ReturnType, array2, fieldType, skipVisibility: true);
				break;
			}
		}
		DynamicILInfo dynamicILInfo = dynamicMethod.GetDynamicILInfo();
		dynamicILInfo.SetLocalSignature(new byte[2] { 7, 0 });
		byte[] array3 = new byte[2 * array2.Length + 6];
		int num3 = 0;
		for (int k = 0; k < array2.Length; k++)
		{
			array3[num3++] = 14;
			array3[num3++] = (byte)k;
		}
		array3[num3++] = (byte)((byte)fieldFromHandle.Name[3] ^ byte_0);
		int tokenFor = dynamicILInfo.GetTokenFor(methodBase.MethodHandle);
		array3[num3++] = (byte)tokenFor;
		array3[num3++] = (byte)(tokenFor >> 8);
		array3[num3++] = (byte)(tokenFor >> 16);
		array3[num3++] = (byte)(tokenFor >> 24);
		array3[num3] = 42;
		dynamicILInfo.SetCode(array3, array2.Length + 1);
		fieldFromHandle.SetValue(null, dynamicMethod.CreateDelegate(fieldType));
	}

	static void ZZZZZZZZZZZZZZZZZZZZZZZZZM(RuntimeFieldHandle runtimeFieldHandle_0, byte byte_0)
	{
		FieldInfo fieldFromHandle = FieldInfo.GetFieldFromHandle(runtimeFieldHandle_0);
		byte[] array = fieldFromHandle.Module.ResolveSignature(fieldFromHandle.MetadataToken);
		int num = array.Length;
		int metadataToken = fieldFromHandle.GetOptionalCustomModifiers()[0].MetadataToken;
		metadataToken += (fieldFromHandle.Name[4] ^ array[--num]) << 0;
		metadataToken += (fieldFromHandle.Name[2] ^ array[--num]) << 24;
		metadataToken += (fieldFromHandle.Name[3] ^ array[--num]) << 16;
		num--;
		metadataToken += (fieldFromHandle.Name[1] ^ array[--num]) << 8;
		int num2 = 1685076207 * metadataToken;
		num2 *= fieldFromHandle.GetCustomAttributes(inherit: false)[0].GetHashCode();
		MethodBase methodBase = fieldFromHandle.Module.ResolveMethod(num2);
		Type fieldType = fieldFromHandle.FieldType;
		if (methodBase.IsStatic)
		{
			fieldFromHandle.SetValue(null, Delegate.CreateDelegate(fieldType, (MethodInfo)methodBase));
			return;
		}
		DynamicMethod dynamicMethod = null;
		Type[] array2 = null;
		MethodInfo[] methods = fieldFromHandle.FieldType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
		foreach (MethodInfo methodInfo in methods)
		{
			if ((object)methodInfo.DeclaringType == fieldType)
			{
				ParameterInfo[] parameters = methodInfo.GetParameters();
				array2 = new Type[parameters.Length];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = parameters[j].ParameterType;
				}
				_ = methodBase.DeclaringType;
				dynamicMethod = new DynamicMethod("", methodInfo.ReturnType, array2, fieldType, skipVisibility: true);
				break;
			}
		}
		DynamicILInfo dynamicILInfo = dynamicMethod.GetDynamicILInfo();
		dynamicILInfo.SetLocalSignature(new byte[2] { 7, 0 });
		byte[] array3 = new byte[2 * array2.Length + 6];
		int num3 = 0;
		for (int k = 0; k < array2.Length; k++)
		{
			array3[num3++] = 14;
			array3[num3++] = (byte)k;
		}
		array3[num3++] = (byte)((byte)fieldFromHandle.Name[0] ^ byte_0);
		int tokenFor = dynamicILInfo.GetTokenFor(methodBase.MethodHandle);
		array3[num3++] = (byte)tokenFor;
		array3[num3++] = (byte)(tokenFor >> 8);
		array3[num3++] = (byte)(tokenFor >> 16);
		array3[num3++] = (byte)(tokenFor >> 24);
		array3[num3] = 42;
		dynamicILInfo.SetCode(array3, array2.Length + 1);
		fieldFromHandle.SetValue(null, dynamicMethod.CreateDelegate(fieldType));
	}

	static void ZZZZZZZZZZZZZZZZZZZZZZZZZN(RuntimeFieldHandle runtimeFieldHandle_0, byte byte_0)
	{
		FieldInfo fieldFromHandle = FieldInfo.GetFieldFromHandle(runtimeFieldHandle_0);
		byte[] array = fieldFromHandle.Module.ResolveSignature(fieldFromHandle.MetadataToken);
		int num = array.Length;
		int metadataToken = fieldFromHandle.GetOptionalCustomModifiers()[0].MetadataToken;
		metadataToken += (fieldFromHandle.Name[0] ^ array[--num]) << 0;
		metadataToken += (fieldFromHandle.Name[4] ^ array[--num]) << 24;
		metadataToken += (fieldFromHandle.Name[1] ^ array[--num]) << 16;
		num--;
		metadataToken += (fieldFromHandle.Name[2] ^ array[--num]) << 8;
		int num2 = metadataToken * -1592908859;
		num2 *= fieldFromHandle.GetCustomAttributes(inherit: false)[0].GetHashCode();
		MethodBase methodBase = fieldFromHandle.Module.ResolveMethod(num2);
		Type fieldType = fieldFromHandle.FieldType;
		if (methodBase.IsStatic)
		{
			fieldFromHandle.SetValue(null, Delegate.CreateDelegate(fieldType, (MethodInfo)methodBase));
			return;
		}
		DynamicMethod dynamicMethod = null;
		Type[] array2 = null;
		MethodInfo[] methods = fieldFromHandle.FieldType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
		foreach (MethodInfo methodInfo in methods)
		{
			if ((object)methodInfo.DeclaringType == fieldType)
			{
				ParameterInfo[] parameters = methodInfo.GetParameters();
				array2 = new Type[parameters.Length];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = parameters[j].ParameterType;
				}
				_ = methodBase.DeclaringType;
				dynamicMethod = new DynamicMethod("", methodInfo.ReturnType, array2, fieldType, skipVisibility: true);
				break;
			}
		}
		DynamicILInfo dynamicILInfo = dynamicMethod.GetDynamicILInfo();
		dynamicILInfo.SetLocalSignature(new byte[2] { 7, 0 });
		byte[] array3 = new byte[2 * array2.Length + 6];
		int num3 = 0;
		for (int k = 0; k < array2.Length; k++)
		{
			array3[num3++] = 14;
			array3[num3++] = (byte)k;
		}
		array3[num3++] = (byte)((byte)fieldFromHandle.Name[3] ^ byte_0);
		int tokenFor = dynamicILInfo.GetTokenFor(methodBase.MethodHandle);
		array3[num3++] = (byte)tokenFor;
		array3[num3++] = (byte)(tokenFor >> 8);
		array3[num3++] = (byte)(tokenFor >> 16);
		array3[num3++] = (byte)(tokenFor >> 24);
		array3[num3] = 42;
		dynamicILInfo.SetCode(array3, array2.Length + 1);
		fieldFromHandle.SetValue(null, dynamicMethod.CreateDelegate(fieldType));
	}

	[DllImport("kernel32.dll", EntryPoint = "VirtualProtect")]
	internal static extern bool VirtualProtect_1(IntPtr intptr_0, uint uint_0, uint uint_1, ref uint uint_2);

	[DllImport("kernel32.dll")]
	internal static extern bool SwitchToThread();

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
	internal static extern bool IsDebuggerPresent();

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	internal static extern bool CheckRemoteDebuggerPresent(IntPtr intptr_0, ref bool bool_0);

	internal static Module ZZZZZZZZZZZZZZZZZZZZZZZZZS(uint uint_0)
	{
		return typeof(Koi).Module;
	}

	internal unsafe static void ZZZZZZZZZZZZZZZZZZZZZZZZZT()
	{
		SwitchToThread();
		string variable = "P0";
		Process.GetProcesses();
		new Process();
		uint num = 1337u;
		Module module = ZZZZZZZZZZZZZZZZZZZZZZZZZS(2690096831u);
		if (module.Assembly.Location.Length == 0)
		{
			num = Convert.ToUInt32(Environment.GetEnvironmentVariable(variable));
			Environment.SetEnvironmentVariable(variable, "");
		}
		string fullyQualifiedName = module.FullyQualifiedName;
		bool flag = fullyQualifiedName.Length > 0 && fullyQualifiedName[0] == '<';
		byte* ptr = (byte*)(void*)Marshal.GetHINSTANCE(module);
		byte* ptr2 = ptr + (uint)(*(int*)(ptr + 60));
		ushort num2 = *(ushort*)(ptr2 + 6);
		ushort num3 = *(ushort*)(ptr2 + 20);
		uint* ptr3 = null;
		uint num4 = 0u;
		uint* ptr4 = (uint*)(ptr2 + 24 + (int)num3);
		uint num5 = 2864005812u;
		uint num6 = 2690096831u;
		uint num7 = 2796620587u;
		uint num8 = 1743720147u;
		for (int i = 0; i < num2; i++)
		{
			uint* num9 = ptr4;
			ptr4 = num9 + 1;
			uint num10 = *num9;
			uint* num11 = ptr4;
			ptr4 = num11 + 1;
			switch (num10 * *num11)
			{
			case 2460624814u:
				ptr3 = (uint*)(ptr + (flag ? ptr4[3] : ptr4[1]));
				num4 = (flag ? ptr4[2] : (*ptr4)) >> 2;
				break;
			default:
			{
				uint* ptr5 = (uint*)(ptr + (flag ? ptr4[3] : ptr4[1]));
				uint num12 = ptr4[2] >> 2;
				for (uint num13 = 0u; num13 < num12; num13++)
				{
					uint num14 = num5;
					uint* num15 = ptr5;
					ptr5 = num15 + 1;
					uint num16 = (num14 ^ *num15) + num6 + num7 * num8;
					num5 = num6;
					num6 = num7;
					num6 = num8;
					num8 = num16;
				}
				break;
			}
			case 0u:
				break;
			}
			ptr4 += 8;
		}
		uint[] array = new uint[16];
		uint[] array2 = new uint[16];
		for (int j = 0; j < 16; j++)
		{
			array[j] = num8;
			array2[j] = num6;
			num5 = (num6 >> 6) | (num6 << 26);
			num6 = (num7 >> 4) | (num7 << 28);
			num7 = (num8 >> 8) | (num8 << 24);
			num8 = (num5 >> 12) | (num5 << 22);
		}
		array[0] = array[0] ^ array2[0];
		array[1] = array[1] * array2[1];
		array[2] = array[2] + array2[2];
		array[3] = array[3] ^ array2[3];
		array[4] = array[4] * array2[4];
		array[5] = array[5] + array2[5];
		array[6] = array[6] ^ array2[6];
		array[7] = array[7] * array2[7];
		array[8] = array[8] + array2[8];
		array[9] = array[9] ^ array2[9];
		array[10] = array[10] * array2[10];
		array[11] = array[11] + array2[11];
		array[12] = array[12] ^ array2[12];
		array[13] = array[13] * array2[13];
		array[14] = array[14] + array2[14];
		array[15] = array[15] ^ array2[15];
		uint uint_ = 64u;
		VirtualProtect_1((IntPtr)ptr3, num4 << 2, 64u, ref uint_);
		uint num17 = 0u;
		for (uint num18 = 0u; num18 < num4; num18++)
		{
			*ptr3 ^= array[num17 & 0xF];
			uint num19 = num17 & 0xF;
			uint num20 = array[num17 & 0xF];
			uint* num21 = ptr3;
			ptr3 = num21 + 1;
			array[num19] = (num20 ^ *num21) + num;
			num17++;
		}
	}
}
