using System;
using System.Reflection.Emit;

internal sealed class Class48
{
	internal static Interface0 smethod_0(Class36 class36_0, Class41 class41_0)
	{
		Class38 @class = new Class38(class36_0.module_0);
		Type type = default(Type);
		DynamicMethod dynamicMethod = default(DynamicMethod);
		while (true)
		{
			int num = Class64.smethod_0(92);
			while (true)
			{
				switch (num)
				{
				case 2:
					type = class36_0.method_0(dynamicMethod.Name, @class.Type_0, @class.Type_1);
					num = 1;
					goto case 1;
				case 1:
					if (class41_0.Boolean_4)
					{
						goto IL_0032;
					}
					if (true)
					{
						object object_ = class36_0.method_1(dynamicMethod, type);
						return new Class50(dynamicMethod.Name, object_);
					}
					goto case 3;
				case 0:
					dynamicMethod = @class.method_0(class41_0);
					num = 2;
					goto case 2;
				case 3:
					return new Class49(dynamicMethod.CreateDelegate(type));
				}
				break;
				IL_0032:
				num = Class64.smethod_0(78);
			}
		}
	}
}
