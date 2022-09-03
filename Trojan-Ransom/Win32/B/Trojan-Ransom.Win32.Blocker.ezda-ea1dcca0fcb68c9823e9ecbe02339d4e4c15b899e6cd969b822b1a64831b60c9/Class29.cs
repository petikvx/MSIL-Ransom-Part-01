using System.Xml;

internal class Class29
{
	public static void smethod_0()
	{
		try
		{
			XmlDocument object_ = Delegate358.smethod_0();
			string string_ = Delegate71.smethod_0(Delegate59.smethod_0((string)_003CModule_003E.smethod_0(3387163733u)), (string)_003CModule_003E.smethod_0(3387168766u));
			if (Delegate175.smethod_1(string_))
			{
				Delegate359.smethod_0(object_, string_);
				XmlNodeList object_2 = Delegate360.smethod_0(object_, (string)_003CModule_003E.smethod_0(3387168673u));
				XmlNodeList object_3 = Delegate360.smethod_0(object_, (string)_003CModule_003E.smethod_0(3387168680u));
				XmlNodeList object_4 = Delegate360.smethod_0(object_, (string)_003CModule_003E.smethod_0(3387168691u));
				for (int i = 0; i < Delegate363.smethod_0(object_2); i++)
				{
					Delegate64.smethod_3(Delegate80.smethod_0(new string[6]
					{
						(string)_003CModule_003E.smethod_0(3387168698u),
						Delegate59.smethod_1(Delegate71.smethod_0((string)_003CModule_003E.smethod_0(3387163806u), Delegate362.smethod_0(Delegate361.smethod_0(object_2, i)))),
						(string)_003CModule_003E.smethod_0(3387166797u),
						Delegate59.smethod_1(Delegate71.smethod_0((string)_003CModule_003E.smethod_0(3387163806u), Delegate362.smethod_0(Delegate361.smethod_0(object_3, i)))),
						(string)_003CModule_003E.smethod_0(3387165017u),
						Delegate59.smethod_1(Delegate71.smethod_0((string)_003CModule_003E.smethod_0(3387163806u), Delegate362.smethod_0(Delegate361.smethod_0(object_4, i))))
					}), Delegate70.smethod_4());
					Delegate82.smethod_2(100);
				}
			}
		}
		catch
		{
		}
	}
}
