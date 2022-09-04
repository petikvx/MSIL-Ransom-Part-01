using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace _0020;

internal static class _0
{
	private static readonly object m__0020 = new object();

	private static Dictionary<int, string> m__0020;

	internal static string _0020(int _0020, int _0001, int _0002)
	{
		//Discarded unreachable code: IL_0017, IL_001f, IL_01aa, IL_01af, IL_01b5, IL_01b7, IL_01bd, IL_01c3, IL_01c8, IL_01ce
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Incompatible stack heights: 0 vs 1
		//IL_002b: Incompatible stack heights: 1 vs 0
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Incompatible stack heights: 0 vs 1
		//IL_01c3: Incompatible stack heights: 1 vs 0
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		lock (_0.m__0020)
		{
			int num = _0020 ^ 0x36E92E4F;
			if (_0.m__0020 != null && _0.m__0020.ContainsKey(num))
			{
				return _0.m__0020[num];
			}
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			byte[] array;
			using (Stream stream = executingAssembly.GetManifestResourceStream("ca63660065d5436192f6b93f5675c783"))
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
				num2 ^= 0x5A5F302F;
			}
			int num5 = _0002 ^ 0x48B46EF6;
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
			if (_0.m__0020 == null)
			{
				_0.m__0020 = new Dictionary<int, string>();
			}
			_0.m__0020.Add(num, @string);
			return @string;
		}
	}
}
