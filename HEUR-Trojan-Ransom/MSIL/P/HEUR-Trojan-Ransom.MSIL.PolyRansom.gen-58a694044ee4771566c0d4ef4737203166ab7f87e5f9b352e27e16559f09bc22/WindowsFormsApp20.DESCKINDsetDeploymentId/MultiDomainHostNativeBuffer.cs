using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace WindowsFormsApp20.DESCKINDsetDeploymentId;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
internal sealed class MultiDomainHostNativeBuffer : ApplicationSettingsBase
{
	private static MultiDomainHostNativeBuffer getCerEnumSByteTypeInfo;

	private static IntPtr[] IIdentityAuthorityWantsToListen;

	public unsafe static MultiDomainHostNativeBuffer Default
	{
		get
		{
			int num = 0;
			MultiDomainHostNativeBuffer result = default(MultiDomainHostNativeBuffer);
			int num2 = default(int);
			int[] array = default(int[]);
			MultiDomainHostNativeBuffer multiDomainHostNativeBuffer = default(MultiDomainHostNativeBuffer);
			while (num != 2)
			{
				result = ((delegate*<ref int, ref int, ref int[], ref MultiDomainHostNativeBuffer, MultiDomainHostNativeBuffer>)IIdentityAuthorityWantsToListen[num])(ref num, ref num2, ref array, ref multiDomainHostNativeBuffer);
			}
			return result;
		}
	}

	unsafe static MultiDomainHostNativeBuffer()
	{
		CachePathMissingSatelliteAssemblyException();
		int num = 3;
		int num2 = default(int);
		int[] array = default(int[]);
		while (num != 0)
		{
			((delegate*<ref int, ref int, ref int[], void>)IIdentityAuthorityWantsToListen[num])(ref num, ref num2, ref array);
		}
	}

	private static void StartDynamicPartitionerForIList(ref int int_0, ref int int_1, ref int[] int_2, MultiDomainHostNativeBuffer multiDomainHostNativeBuffer_0)
	{
		((ApplicationSettingsBase)multiDomainHostNativeBuffer_0)._002Ector();
		int_0 = 0;
	}

	public unsafe MultiDomainHostNativeBuffer()
	{
		int num = 2;
		int num2 = default(int);
		int[] array = default(int[]);
		while (num != 0)
		{
			((delegate*<ref int, ref int, ref int[], MultiDomainHostNativeBuffer, void>)IIdentityAuthorityWantsToListen[num])(ref num, ref num2, ref array, this);
		}
	}

	private static void IsNestedFamORAssemGetIndexParameters(ref int int_0, ref int int_1, ref int[] int_2)
	{
		getCerEnumSByteTypeInfo = (MultiDomainHostNativeBuffer)(object)SettingsBase.Synchronized((SettingsBase)(object)new MultiDomainHostNativeBuffer());
		int_0 = 0;
	}

	private static MultiDomainHostNativeBuffer TemplatesCOMServerEntry(ref int int_0, ref int int_1, ref int[] int_2, ref MultiDomainHostNativeBuffer multiDomainHostNativeBuffer_0)
	{
		MultiDomainHostNativeBuffer multiDomainHostNativeBuffer = (multiDomainHostNativeBuffer_0 = getCerEnumSByteTypeInfo);
		int_0 = 1;
		MultiDomainHostNativeBuffer result = default(MultiDomainHostNativeBuffer);
		return result;
	}

	private static MultiDomainHostNativeBuffer DeclaredFieldsComEventsHelper(ref int int_0, ref int int_1, ref int[] int_2, ref MultiDomainHostNativeBuffer multiDomainHostNativeBuffer_0)
	{
		MultiDomainHostNativeBuffer result = multiDomainHostNativeBuffer_0;
		int_0 = 2;
		return result;
	}

	private unsafe static void CachePathMissingSatelliteAssemblyException()
	{
		IIdentityAuthorityWantsToListen = new IntPtr[4];
		IIdentityAuthorityWantsToListen[0] = (nint)(delegate*<ref int, ref int, ref int[], ref MultiDomainHostNativeBuffer, MultiDomainHostNativeBuffer>)(&TemplatesCOMServerEntry);
		IIdentityAuthorityWantsToListen[1] = (nint)(delegate*<ref int, ref int, ref int[], ref MultiDomainHostNativeBuffer, MultiDomainHostNativeBuffer>)(&DeclaredFieldsComEventsHelper);
		IIdentityAuthorityWantsToListen[2] = (nint)(delegate*<ref int, ref int, ref int[], MultiDomainHostNativeBuffer, void>)(&StartDynamicPartitionerForIList);
		IIdentityAuthorityWantsToListen[3] = (nint)(delegate*<ref int, ref int, ref int[], void>)(&IsNestedFamORAssemGetIndexParameters);
	}
}
