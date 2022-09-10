using System;
using System.Reflection.Emit;

internal sealed class Class19
{
	internal static Interface0 smethod_0(Class7 class7_0, Class12 class12_0)
	{
		Class9 @class = new Class9(class7_0.module_0);
		DynamicMethod dynamicMethod = default(DynamicMethod);
		Type type = default(Type);
		while (true)
		{
			int num = Class9.smethod_4(37);
			while (true)
			{
				switch (num)
				{
				case 2:
					if (class12_0.Boolean_4)
					{
						goto IL_0016;
					}
					if (true)
					{
						object object_ = class7_0.method_1(dynamicMethod, type);
						return new Class21(dynamicMethod.Name, object_);
					}
					goto case 3;
				case 1:
					type = class7_0.method_0(dynamicMethod.Name, @class.Type_0, @class.Type_1);
					num = 2;
					goto case 2;
				case 0:
					dynamicMethod = @class.method_0(class12_0);
					num = 1;
					goto case 1;
				case 3:
					return new Class20(dynamicMethod.CreateDelegate(type));
				}
				break;
				IL_0016:
				num = Class9.smethod_4(40);
			}
		}
	}
}
