using System;

internal class Unrestricted : Attribute
{
	internal readonly int AddAssemblyRef;

	internal Unrestricted(int P_0)
	{
		while (true)
		{
			int num = 294994810;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)_003CModule_003E.Replace(num)) % 3u)
				{
				case 2u:
					break;
				default:
					return;
				case 1u:
					goto IL_0027;
				case 0u:
					return;
				}
				break;
				IL_0027:
				AddAssemblyRef = -(-((P_0 - -(-1239413021 * -1093450481)) * 1429077313) * -1354297555);
				num = ((int)num2 * -700488630) ^ 0x563D521F;
			}
		}
	}

	public override int GetIndexes()
	{
		return AddAssemblyRef;
	}
}
