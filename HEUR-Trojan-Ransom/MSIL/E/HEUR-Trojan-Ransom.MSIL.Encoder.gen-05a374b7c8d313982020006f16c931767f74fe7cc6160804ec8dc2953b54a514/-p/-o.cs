using System;
using _0023ab;

namespace _0023p
{
	internal class _0023o
	{
		internal static bool _0001()
		{
			DateTime dateTime = default(DateTime);
			try
			{
				dateTime = DateTime.Parse(_00239._00237(107396418));
				if (DateTime.Now > dateTime || DateTime.Now < dateTime.AddDays(-21.0))
				{
					throw new Exception(string.Format(_00239._00237(107396389), _00239._00237(107395780)));
				}
				if (_0023_0023._0023fh() == null)
				{
					try
					{
						_0023o._0001();
					}
					catch
					{
					}
				}
				return true;
			}
			catch (Exception _0023hd)
			{
				_0023_0023._00232f(_0023hd, (object)dateTime);
				throw;
			}
		}

		private static void _0001()
		{
			try
			{
				Console.WriteLine(_00239._00237(107395755), _00239._00237(107395780));
			}
			catch (Exception _0023hd)
			{
				_0023_0023._00238g(_0023hd);
				throw;
			}
		}
	}
}
namespace _0023P
{
	internal static class _0023O
	{
		public static readonly UIntPtr _0023a = new UIntPtr(2147483648u);

		public static readonly UIntPtr _0023b = new UIntPtr(2147483649u);

		public static readonly UIntPtr _0023c = new UIntPtr(2147483650u);

		public static readonly UIntPtr _0023d = new UIntPtr(2147483651u);

		public static readonly UIntPtr _0023e = new UIntPtr(2147483652u);

		public static readonly UIntPtr _0023f = new UIntPtr(2147483653u);

		public static readonly UIntPtr _0023g = new UIntPtr(2147483654u);
	}
}
