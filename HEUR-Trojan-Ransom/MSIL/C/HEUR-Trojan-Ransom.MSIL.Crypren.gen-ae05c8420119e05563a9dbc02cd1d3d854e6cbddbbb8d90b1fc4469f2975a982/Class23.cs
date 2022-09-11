using System;
using System.Reflection.Emit;

internal sealed class Class23
{
	internal static Interface0 smethod_0(Class11 class11_0, Class16 class16_0)
	{
		Class13 @class = new Class13(class11_0.module_0);
		Type type = default(Type);
		DynamicMethod dynamicMethod = default(DynamicMethod);
		while (true)
		{
			int num = Class39.smethod_0(92);
			while (true)
			{
				switch (num)
				{
				case 2:
					type = class11_0.method_0(dynamicMethod.Name, @class.Type_0, @class.Type_1);
					num = 1;
					goto case 1;
				case 1:
					if (class16_0.Boolean_4)
					{
						goto IL_0032;
					}
					if (true)
					{
						object object_ = class11_0.method_1(dynamicMethod, type);
						return new Class25(dynamicMethod.Name, object_);
					}
					goto case 3;
				case 0:
					dynamicMethod = @class.method_0(class16_0);
					num = 2;
					goto case 2;
				case 3:
					return new Class24(dynamicMethod.CreateDelegate(type));
				}
				break;
				IL_0032:
				num = Class39.smethod_0(78);
			}
		}
	}
}
