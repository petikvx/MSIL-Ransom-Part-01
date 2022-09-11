using System;
using System.Reflection.Emit;

internal sealed class Class26
{
	internal static Interface0 smethod_0(Class14 class14_0, Class19 class19_0)
	{
		Class16 @class = new Class16(class14_0.module_0);
		Type type = default(Type);
		DynamicMethod dynamicMethod = default(DynamicMethod);
		while (true)
		{
			int num = Class42.smethod_0(92);
			while (true)
			{
				switch (num)
				{
				case 2:
					type = class14_0.method_0(dynamicMethod.Name, @class.Type_0, @class.Type_1);
					num = 1;
					goto case 1;
				case 1:
					if (class19_0.Boolean_4)
					{
						goto IL_0032;
					}
					if (true)
					{
						object object_ = class14_0.method_1(dynamicMethod, type);
						return new Class28(dynamicMethod.Name, object_);
					}
					goto case 3;
				case 0:
					dynamicMethod = @class.method_0(class19_0);
					num = 2;
					goto case 2;
				case 3:
					return new Class27(dynamicMethod.CreateDelegate(type));
				}
				break;
				IL_0032:
				num = Class42.smethod_0(78);
			}
		}
	}
}
