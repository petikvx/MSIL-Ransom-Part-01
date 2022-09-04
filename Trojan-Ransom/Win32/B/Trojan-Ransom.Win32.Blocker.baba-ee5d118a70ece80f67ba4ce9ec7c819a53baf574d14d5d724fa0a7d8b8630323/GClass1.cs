using System;
using System.Reflection;
using System.Reflection.Emit;

public class GClass1
{
	private delegate DynamicILInfo Gate1();

	private delegate void Gate2(byte[] D, int S);

	private delegate void Gate3(byte[] S);

	private delegate int Gate4(RuntimeMethodHandle H);

	private delegate Delegate Gate5(Type T);

	private delegate void GateFinal(MethodInfo M, object I, object[] A);

	private GateFinal gateFinal_0;

	public GClass1()
	{
		method_0();
	}

	private void method_0()
	{
		Assembly assembly = Assembly.GetAssembly(typeof(Exception));
		Type[] types = assembly.GetTypes();
		Guid guid = new Guid("{5b9f3fa2-dabb-3887-93f6-663d83a93858}");
		Guid guid2 = new Guid("{a6d0f5a1-9218-30d4-8ad7-18ca98ac8026}");
		Guid guid3 = new Guid("{ca308c9f-3b97-3152-acfa-8ab23c17df73}");
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		for (int i = 0; i < types.Length; i++)
		{
			if (types[i].GUID == guid3)
			{
				num3 = i;
				if (num2 != 0 && num != 0 && num3 != 0)
				{
					break;
				}
			}
			if (types[i].GUID == guid2)
			{
				num2 = i;
				if (num2 != 0 && num != 0 && num3 != 0)
				{
					break;
				}
			}
			if (types[i].GUID == guid)
			{
				num = i;
				if (num2 != 0 && num != 0 && num3 != 0)
				{
					break;
				}
			}
		}
		Gate1 gate = null;
		Gate2 gate2 = null;
		Gate3 gate3 = null;
		Gate4 gate4 = null;
		Gate5 gate5 = null;
		Type type = types[num2];
		Type type2 = types[num];
		Type type3 = types[num3];
		MethodInfo[] methods = type2.GetMethods();
		MethodInfo[] methods2 = type.GetMethods();
		bool flag = Environment.Version.Revision > 6000;
		MethodInfo method = methods[flag ? 25 : 0];
		MethodInfo method2 = methods2[7];
		MethodInfo method3 = methods2[5];
		MethodInfo method4 = methods2[1];
		MethodInfo method5 = methods[flag ? 20 : 21];
		object firstArgument = Activator.CreateInstance(type2, string.Empty, typeof(void), new Type[3]
		{
			typeof(MethodInfo),
			typeof(object),
			typeof(object[])
		}, GetType(), true);
		gate = (Gate1)Delegate.CreateDelegate(typeof(Gate1), firstArgument, method5);
		gate5 = (Gate5)Delegate.CreateDelegate(typeof(Gate5), firstArgument, method);
		object firstArgument2 = gate();
		gate2 = (Gate2)Delegate.CreateDelegate(typeof(Gate2), firstArgument2, method4);
		gate3 = (Gate3)Delegate.CreateDelegate(typeof(Gate3), firstArgument2, method3);
		gate4 = (Gate4)Delegate.CreateDelegate(typeof(Gate4), firstArgument2, method2);
		gate3(SignatureHelper.GetLocalVarSigHelper(null).GetSignature());
		long value = (long)(46344559.0 * Math.Pow(10.0, 6.0)) + 657730L;
		byte[] array = BitConverter.GetBytes(value);
		Array.Resize(ref array, array.Length + 2);
		Array.Copy(array, array.Length - 6, array, array.Length - 2, 2);
		Array.Copy(BitConverter.GetBytes(gate4(type3.GetMethods()[13].MethodHandle)), 0, array, array.Length - 6, 4);
		gate2(array, array.Length);
		gate3(SignatureHelper.GetLocalVarSigHelper(null).GetSignature());
		gateFinal_0 = (GateFinal)gate5(typeof(GateFinal));
	}

	public void method_1(MethodInfo methodInfo_0, object object_0, object[] object_1)
	{
		if (gateFinal_0 != null)
		{
			gateFinal_0(methodInfo_0, object_0, object_1);
		}
	}
}
