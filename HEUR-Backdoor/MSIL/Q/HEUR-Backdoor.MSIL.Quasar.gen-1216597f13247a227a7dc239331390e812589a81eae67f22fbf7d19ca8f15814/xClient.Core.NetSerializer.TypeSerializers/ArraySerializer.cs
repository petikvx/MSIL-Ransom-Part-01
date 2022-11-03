using System;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace xClient.Core.NetSerializer.TypeSerializers;

internal class ArraySerializer : ITypeSerializer, IDynamicTypeSerializer
{
	public bool Handles(Type type)
	{
		if (!type.IsArray)
		{
			return false;
		}
		if (type.GetArrayRank() != 1)
		{
			throw new NotSupportedException($"Multi-dim arrays not supported: {type.FullName}");
		}
		return true;
	}

	public IEnumerable<Type> GetSubtypes(Type type)
	{
		yield return type.GetElementType();
	}

	public void GenerateWriterMethod(Type type, CodeGenContext ctx, ILGenerator il)
	{
		Type elementType = type.GetElementType();
		Label label = il.DefineLabel();
		il.Emit(OpCodes.Ldarg_2);
		il.Emit(OpCodes.Brtrue_S, label);
		il.Emit(OpCodes.Ldarg_1);
		il.Emit(OpCodes.Ldc_I4_0);
		il.Emit(OpCodes.Tailcall);
		il.Emit(OpCodes.Call, ctx.GetWriterMethodInfo(typeof(uint)));
		il.Emit(OpCodes.Ret);
		il.MarkLabel(label);
		il.Emit(OpCodes.Ldarg_1);
		il.Emit(OpCodes.Ldarg_2);
		il.Emit(OpCodes.Ldlen);
		il.Emit(OpCodes.Ldc_I4_1);
		il.Emit(OpCodes.Add);
		il.Emit(OpCodes.Call, ctx.GetWriterMethodInfo(typeof(uint)));
		LocalBuilder local = il.DeclareLocal(typeof(int));
		il.Emit(OpCodes.Ldc_I4_0);
		il.Emit(OpCodes.Stloc_S, local);
		Label label2 = il.DefineLabel();
		Label label3 = il.DefineLabel();
		il.Emit(OpCodes.Br_S, label3);
		il.MarkLabel(label2);
		TypeData typeDataForCall = ctx.GetTypeDataForCall(elementType);
		if (typeDataForCall.NeedsInstanceParameter)
		{
			il.Emit(OpCodes.Ldarg_0);
		}
		il.Emit(OpCodes.Ldarg_1);
		il.Emit(OpCodes.Ldarg_2);
		il.Emit(OpCodes.Ldloc_S, local);
		il.Emit(OpCodes.Ldelem, elementType);
		il.Emit(OpCodes.Call, typeDataForCall.WriterMethodInfo);
		il.Emit(OpCodes.Ldloc_S, local);
		il.Emit(OpCodes.Ldc_I4_1);
		il.Emit(OpCodes.Add);
		il.Emit(OpCodes.Stloc_S, local);
		il.MarkLabel(label3);
		il.Emit(OpCodes.Ldloc_S, local);
		il.Emit(OpCodes.Ldarg_2);
		il.Emit(OpCodes.Ldlen);
		il.Emit(OpCodes.Conv_I4);
		il.Emit(OpCodes.Clt);
		il.Emit(OpCodes.Brtrue_S, label2);
		il.Emit(OpCodes.Ret);
	}

	public void GenerateReaderMethod(Type type, CodeGenContext ctx, ILGenerator il)
	{
		Type elementType = type.GetElementType();
		LocalBuilder local = il.DeclareLocal(typeof(uint));
		il.Emit(OpCodes.Ldarg_1);
		il.Emit(OpCodes.Ldloca_S, local);
		il.Emit(OpCodes.Call, ctx.GetReaderMethodInfo(typeof(uint)));
		Label label = il.DefineLabel();
		il.Emit(OpCodes.Ldloc_S, local);
		il.Emit(OpCodes.Brtrue_S, label);
		il.Emit(OpCodes.Ldarg_2);
		il.Emit(OpCodes.Ldnull);
		il.Emit(OpCodes.Stind_Ref);
		il.Emit(OpCodes.Ret);
		il.MarkLabel(label);
		LocalBuilder local2 = il.DeclareLocal(type);
		il.Emit(OpCodes.Ldloc_S, local);
		il.Emit(OpCodes.Ldc_I4_1);
		il.Emit(OpCodes.Sub);
		il.Emit(OpCodes.Newarr, elementType);
		il.Emit(OpCodes.Stloc_S, local2);
		LocalBuilder local3 = il.DeclareLocal(typeof(int));
		il.Emit(OpCodes.Ldc_I4_0);
		il.Emit(OpCodes.Stloc_S, local3);
		Label label2 = il.DefineLabel();
		Label label3 = il.DefineLabel();
		il.Emit(OpCodes.Br_S, label3);
		il.MarkLabel(label2);
		TypeData typeDataForCall = ctx.GetTypeDataForCall(elementType);
		if (typeDataForCall.NeedsInstanceParameter)
		{
			il.Emit(OpCodes.Ldarg_0);
		}
		il.Emit(OpCodes.Ldarg_1);
		il.Emit(OpCodes.Ldloc_S, local2);
		il.Emit(OpCodes.Ldloc_S, local3);
		il.Emit(OpCodes.Ldelema, elementType);
		il.Emit(OpCodes.Call, typeDataForCall.ReaderMethodInfo);
		il.Emit(OpCodes.Ldloc_S, local3);
		il.Emit(OpCodes.Ldc_I4_1);
		il.Emit(OpCodes.Add);
		il.Emit(OpCodes.Stloc_S, local3);
		il.MarkLabel(label3);
		il.Emit(OpCodes.Ldloc_S, local3);
		il.Emit(OpCodes.Ldloc_S, local2);
		il.Emit(OpCodes.Ldlen);
		il.Emit(OpCodes.Conv_I4);
		il.Emit(OpCodes.Clt);
		il.Emit(OpCodes.Brtrue_S, label2);
		il.Emit(OpCodes.Ldarg_2);
		il.Emit(OpCodes.Ldloc_S, local2);
		il.Emit(OpCodes.Stind_Ref);
		il.Emit(OpCodes.Ret);
	}
}
