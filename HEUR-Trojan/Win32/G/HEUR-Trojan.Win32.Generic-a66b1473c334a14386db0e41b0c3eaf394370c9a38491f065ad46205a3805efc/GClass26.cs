public static class GClass26
{
	public static object[] object_0;

	internal static bool smethod_0(byte[] byte_0)
	{
		int num = 0;
		while (true)
		{
			if (num < byte_0.Length)
			{
				if (num + 3 >= byte_0.Length || byte_0[num] != 81 || byte_0[num + 1] != 69 || byte_0[num + 2] != 77 || byte_0[num + 3] != 85)
				{
					if (num + 8 >= byte_0.Length || byte_0[num] != 77 || byte_0[num + 1] != 105 || byte_0[num + 2] != 99 || byte_0[num + 3] != 114 || byte_0[num + 4] != 111 || byte_0[num + 5] != 115 || byte_0[num + 6] != 111 || byte_0[num + 7] != 102 || byte_0[num + 8] != 116)
					{
						if (num + 6 >= byte_0.Length || byte_0[num] != 105 || byte_0[num + 1] != 110 || byte_0[num + 2] != 110 || byte_0[num + 3] != 111 || byte_0[num + 4] != 116 || byte_0[num + 5] != 101 || byte_0[num + 6] != 107)
						{
							if (num + 9 >= byte_0.Length || byte_0[num] != 86 || byte_0[num + 1] != 105 || byte_0[num + 2] != 114 || byte_0[num + 3] != 116 || byte_0[num + 4] != 117 || byte_0[num + 5] != 97 || byte_0[num + 6] != 108 || byte_0[num + 7] != 66 || byte_0[num + 8] != 111 || byte_0[num + 9] != 120)
							{
								if (num + 5 >= byte_0.Length || byte_0[num] != 86 || byte_0[num + 1] != 77 || byte_0[num + 2] != 119 || byte_0[num + 3] != 97 || byte_0[num + 4] != 114 || byte_0[num + 5] != 101)
								{
									if (num + 8 < byte_0.Length && byte_0[num] == 80 && byte_0[num + 1] == 97 && byte_0[num + 2] == 114 && byte_0[num + 3] == 97 && byte_0[num + 4] == 108 && byte_0[num + 5] == 108 && byte_0[num + 6] == 101 && byte_0[num + 7] == 108 && byte_0[num + 8] == 115)
									{
										break;
									}
									num++;
									continue;
								}
								return true;
							}
							return true;
						}
						return true;
					}
					return true;
				}
				return true;
			}
			return false;
		}
		return true;
	}
}
