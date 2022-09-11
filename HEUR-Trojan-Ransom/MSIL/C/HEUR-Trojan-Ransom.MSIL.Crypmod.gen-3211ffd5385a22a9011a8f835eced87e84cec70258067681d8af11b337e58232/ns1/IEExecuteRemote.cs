using System;
using System.Configuration.Assemblies;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security;
using System.Security.Permissions;
using System.Security.Policy;
using System.Threading;

namespace ns1;

public class IEExecuteRemote : MarshalByRefObject
{
	internal sealed class Class8
	{
		public ApartmentState apartmentState_0;

		public string string_0;

		public byte[] byte_0;

		public AssemblyHashAlgorithm assemblyHashAlgorithm_0;
	}

	private Class8 class8_0;

	private MemoryStream memoryStream_0;

	internal int int_0;

	public Stream Exception
	{
		[StrongNameIdentityPermission(SecurityAction.LinkDemand, PublicKey = "0x002400000480000094000000060200000024000052534131000400000100010007D1FA57C4AED9F0A32E84AA0FAEFD0DE9E8FD6AEC8F87FB03766C834C99921EB23BE79AD9D5DCC1DD9AD236132102900B723CF980957FC4E177108FC607774F29E8320E92EA05ECE4E821C0A5EFE8F1645C4C0C93C1AB99285D622CAA652C1DFAD63D745D6F2DE5F17E5EAF0FC4963D261C8A12436518206DC093344D5AD293")]
		get
		{
			return memoryStream_0;
		}
	}

	internal void method_0()
	{
		int num = (int_0 = method_2(bool_0: false));
	}

	internal int method_1()
	{
		try
		{
			Thread thread = new Thread(method_0);
			thread.SetApartmentState(class8_0.apartmentState_0);
			thread.Start();
			thread.Join();
			return int_0;
		}
		catch (Exception graph)
		{
			memoryStream_0 = new MemoryStream();
			new BinaryFormatter().Serialize(memoryStream_0, graph);
			memoryStream_0.Position = 0L;
			return -1;
		}
	}

	internal int method_2(bool bool_0)
	{
		new PermissionSet(PermissionState.Unrestricted).Assert();
		if (bool_0 && !Thread.CurrentThread.TrySetApartmentState(class8_0.apartmentState_0))
		{
			return method_1();
		}
		return AppDomain.CurrentDomain.ExecuteAssembly(class8_0.string_0, (Evidence)null, (string[])null, class8_0.byte_0, class8_0.assemblyHashAlgorithm_0);
	}

	[StrongNameIdentityPermission(SecurityAction.LinkDemand, PublicKey = "0x002400000480000094000000060200000024000052534131000400000100010007D1FA57C4AED9F0A32E84AA0FAEFD0DE9E8FD6AEC8F87FB03766C834C99921EB23BE79AD9D5DCC1DD9AD236132102900B723CF980957FC4E177108FC607774F29E8320E92EA05ECE4E821C0A5EFE8F1645C4C0C93C1AB99285D622CAA652C1DFAD63D745D6F2DE5F17E5EAF0FC4963D261C8A12436518206DC093344D5AD293")]
	public int method_3(string string_0, Evidence evidence_0, byte[] byte_0, AssemblyHashAlgorithm assemblyHashAlgorithm_0)
	{
		try
		{
			Assembly assembly = Assembly.LoadFrom(string_0, (Evidence)null, byte_0, assemblyHashAlgorithm_0);
			class8_0 = new Class8();
			class8_0.string_0 = string_0;
			class8_0.byte_0 = byte_0;
			class8_0.assemblyHashAlgorithm_0 = assemblyHashAlgorithm_0;
			class8_0.apartmentState_0 = ApartmentState.Unknown;
			if (assembly.EntryPoint!.GetCustomAttributes(typeof(STAThreadAttribute), inherit: false).Length != 0)
			{
				class8_0.apartmentState_0 = ApartmentState.STA;
			}
			if (assembly.EntryPoint!.GetCustomAttributes(typeof(MTAThreadAttribute), inherit: false).Length != 0)
			{
				if (class8_0.apartmentState_0 == ApartmentState.Unknown)
				{
					class8_0.apartmentState_0 = ApartmentState.MTA;
				}
				else
				{
					class8_0.apartmentState_0 = ApartmentState.Unknown;
				}
			}
			return method_2(bool_0: true);
		}
		catch (Exception graph)
		{
			new PermissionSet(PermissionState.Unrestricted).Assert();
			memoryStream_0 = new MemoryStream();
			new BinaryFormatter().Serialize(memoryStream_0, graph);
			memoryStream_0.Position = 0L;
			return -1;
		}
	}

	[StrongNameIdentityPermission(SecurityAction.LinkDemand, PublicKey = "0x002400000480000094000000060200000024000052534131000400000100010007D1FA57C4AED9F0A32E84AA0FAEFD0DE9E8FD6AEC8F87FB03766C834C99921EB23BE79AD9D5DCC1DD9AD236132102900B723CF980957FC4E177108FC607774F29E8320E92EA05ECE4E821C0A5EFE8F1645C4C0C93C1AB99285D622CAA652C1DFAD63D745D6F2DE5F17E5EAF0FC4963D261C8A12436518206DC093344D5AD293")]
	public int method_4(string string_0, Evidence evidence_0, object object_0)
	{
		return -2147467263;
	}

	[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.Infrastructure)]
	public override object vmethod_0()
	{
		return null;
	}
}
