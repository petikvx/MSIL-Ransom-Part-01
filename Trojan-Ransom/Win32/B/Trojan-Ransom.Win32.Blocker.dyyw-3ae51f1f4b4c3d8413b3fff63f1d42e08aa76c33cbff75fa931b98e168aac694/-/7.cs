using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace _0020;

internal static class _7
{
	private static readonly object m__0020 = new object();

	private static Dictionary<int, string> m__0020;

	internal static string _0020(int _0020, int _0001, int _0002)
	{
		//Discarded unreachable code: IL_0005, IL_0021, IL_01ab, IL_01b0, IL_01b8, IL_01be, IL_01c3, IL_01c9, IL_01cf
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Incompatible stack heights: 1 vs 0
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Incompatible stack heights: 0 vs 1
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Incompatible stack heights: 0 vs 3
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected O, but got Unknown
		lock (_7.m__0020)
		{
			int num = _0020 ^ 0x60612222;
			if (_7.m__0020 != null && _7.m__0020.ContainsKey(num))
			{
				return _7.m__0020[num];
			}
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			byte[] array;
			using (Stream stream = executingAssembly.GetManifestResourceStream("0fa2cb5fb9c04c5bbc9539da483b00b0"))
			{
				array = new byte[stream.Length];
				stream.Read(array, 0, Convert.ToInt32(stream.Length));
			}
			int num2 = _0001;
			byte[] publicKeyToken = executingAssembly.GetName().GetPublicKeyToken();
			if (publicKeyToken != null && publicKeyToken.Length == 8)
			{
				int num3 = BitConverter.ToInt32(publicKeyToken, 0);
				int num4 = BitConverter.ToInt32(publicKeyToken, 4);
				num2 ^= num3 ^ num4;
			}
			else
			{
				num2 ^= 0x5C29B882;
			}
			int num5 = _0002 ^ 0x6463360E;
			byte[] array2 = new byte[num5];
			int num6 = 0;
			for (int i = num2; i < num2 + num5; i++)
			{
				array2[num6++] = array[i];
			}
			byte[] array3 = new byte[num5];
			Random random = new Random(num);
			random.NextBytes(array3);
			for (int j = 0; j < num5; j++)
			{
				array2[j] ^= array3[j];
			}
			string @string = Encoding.Unicode.GetString(array2);
			if (_7.m__0020 == null)
			{
				_7.m__0020 = new Dictionary<int, string>();
			}
			_7.m__0020.Add(num, @string);
			return @string;
		}
	}
}
