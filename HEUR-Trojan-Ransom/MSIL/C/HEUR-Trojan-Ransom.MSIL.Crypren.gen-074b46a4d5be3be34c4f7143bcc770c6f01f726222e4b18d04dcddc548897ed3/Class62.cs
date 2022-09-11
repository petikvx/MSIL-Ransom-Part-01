using System;
using System.Reflection.Emit;

internal sealed class Class62
{
	internal static Interface0 smethod_0(Class50 class50_0, Class55 class55_0)
	{
		Class52 @class = new Class52(class50_0.module_0);
		DynamicMethod dynamicMethod = default(DynamicMethod);
		Type type = default(Type);
		while (true)
		{
			int num = Class52.smethod_4(37);
			while (true)
			{
				switch (num)
				{
				case 2:
					if (class55_0.Boolean_4)
					{
						goto IL_0016;
					}
					if (true)
					{
						object object_ = class50_0.method_1(dynamicMethod, type);
						return new Class64(dynamicMethod.Name, object_);
					}
					goto case 3;
				case 1:
					type = class50_0.method_0(dynamicMethod.Name, @class.Type_0, @class.Type_1);
					num = 2;
					goto case 2;
				case 0:
					dynamicMethod = @class.method_0(class55_0);
					num = 1;
					goto case 1;
				case 3:
					return new Class63(dynamicMethod.CreateDelegate(type));
				}
				break;
				IL_0016:
				num = Class52.smethod_4(40);
			}
		}
	}
}
