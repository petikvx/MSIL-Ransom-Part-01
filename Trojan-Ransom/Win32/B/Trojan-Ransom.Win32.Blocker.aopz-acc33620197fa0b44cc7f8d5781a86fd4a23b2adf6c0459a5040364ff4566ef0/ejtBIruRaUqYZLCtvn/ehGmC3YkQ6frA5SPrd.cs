using System;
using System.Reflection;
using eJnHnFFEpEmlCQmkVB;

namespace ejtBIruRaUqYZLCtvn;

internal class ehGmC3YkQ6frA5SPrd
{
	internal delegate void SFU4mbT3GMret7THonf(object o);

	internal static object e2bNFjie4;

	internal static void EeRDxNaaacGZr(int typemdt)
	{
		Teqaq93nbqE0DkATXvh();
		Type type = default(Type);
		FieldInfo[] fields = default(FieldInfo[]);
		int num2 = default(int);
		if (NOJv8i3WvnOvZVAVUEH())
		{
			while (true)
			{
				IL_0069:
				type = HT4jlt344SO1IOZPNKA(e2bNFjie4, 33554432 + typemdt);
				int num = 7;
				if (!NOJv8i3WvnOvZVAVUEH())
				{
					goto IL_0012;
				}
				goto IL_0036;
				IL_0036:
				while (true)
				{
					switch (num)
					{
					case 8:
						break;
					case 7:
						fields = type.GetFields();
						num = 8;
						if (NOJv8i3WvnOvZVAVUEH())
						{
							continue;
						}
						return;
					case 0:
					case 2:
						goto IL_0069;
					case 6:
						goto end_IL_0069;
					case 1:
					case 3:
						goto IL_0099;
					case 4:
						goto IL_00a5;
					default:
						goto IL_00c1;
					case 10:
						return;
					}
					break;
				}
				goto IL_0012;
				IL_0012:
				num2 = 0;
				num = 3;
				if (!Teqaq93nbqE0DkATXvh())
				{
					goto IL_0036;
				}
				goto IL_00c1;
				continue;
				end_IL_0069:
				break;
			}
			goto IL_0093;
		}
		goto IL_00c1;
		IL_00c1:
		FieldInfo object_ = default(FieldInfo);
		MethodInfo object_2 = default(MethodInfo);
		BJ4Q253Uw6uewbxVmmm(object_, null, (MulticastDelegate)NbDsiw3mmRDM2eEwsoc(type, object_2));
		goto IL_0093;
		IL_0093:
		num2++;
		goto IL_0099;
		IL_0099:
		if (num2 < fields.Length)
		{
			object_ = fields[num2];
			goto IL_00a5;
		}
		return;
		IL_00a5:
		object_2 = (MethodInfo)WqbdWI38mJ2spTfEFxT(e2bNFjie4, o0egRq3j8xXyrvGNMRg(object_) + 100663296);
		goto IL_00c1;
	}

	public ehGmC3YkQ6frA5SPrd()
	{
		fJIlTF3M1qgSLP63PTv();
		XTLGfj3g4IkfiXxUTCl(this);
	}

	static ehGmC3YkQ6frA5SPrd()
	{
		fJIlTF3M1qgSLP63PTv();
		e2bNFjie4 = isAntr3inHUqHJioR6l(Wnl6SR36JPqmw3Tp8rR(typeof(ehGmC3YkQ6frA5SPrd).TypeHandle).Assembly);
	}

	internal static Type HT4jlt344SO1IOZPNKA(object object_0, int int_0)
	{
		return ((Module)object_0).ResolveType(int_0);
	}

	internal static int o0egRq3j8xXyrvGNMRg(object object_0)
	{
		return ((MemberInfo)object_0).MetadataToken;
	}

	internal static object WqbdWI38mJ2spTfEFxT(object object_0, int int_0)
	{
		return ((Module)object_0).ResolveMethod(int_0);
	}

	internal static object NbDsiw3mmRDM2eEwsoc(Type type_0, object object_0)
	{
		return Delegate.CreateDelegate(type_0, (MethodInfo)object_0);
	}

	internal static void BJ4Q253Uw6uewbxVmmm(object object_0, object object_1, object object_2)
	{
		((FieldInfo)object_0).SetValue(object_1, object_2);
	}

	internal static bool NOJv8i3WvnOvZVAVUEH()
	{
		return true;
	}

	internal static bool Teqaq93nbqE0DkATXvh()
	{
		return false;
	}

	internal static void fJIlTF3M1qgSLP63PTv()
	{
		eWK97ZHZd8El3E8K9m.FwXDxNafX7Lru();
	}

	internal static void XTLGfj3g4IkfiXxUTCl(object object_0)
	{
		object_0._002Ector();
	}

	internal static Type Wnl6SR36JPqmw3Tp8rR(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static object isAntr3inHUqHJioR6l(object object_0)
	{
		return ((Assembly)object_0).ManifestModule;
	}
}
