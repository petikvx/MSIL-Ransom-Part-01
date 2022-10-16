using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using MicrosoftEdgeBCHost.Polices;
using MicrosoftEdgeBCHost.States;

namespace MicrosoftEdgeBCHost.Producers;

internal class WriterPropertyProducer
{
	private delegate void ConnectionAdapterWatcher(object o);

	internal class TestsFacade : System.Attribute
	{
		internal class GetterFacade<T>
		{
			private static object LoginLiteralMerchant;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public GetterFacade()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static GetterFacade()
			{
				ResolveStub();
				QueryStub();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool PublishLiteralMerchant()
			{
				return true;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static object DestroyLiteralMerchant()
			{
				return null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[TestsFacade(typeof(GetterFacade<object>[]))]
		public TestsFacade(object param)
		{
		}

		static TestsFacade()
		{
			ResolveStub();
		}
	}

	internal class ItemFacade
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[TestsFacade(typeof(TestsFacade.GetterFacade<object>[]))]
		internal static string StartStub(object param, object map)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ItemFacade()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CancelLiteralMerchant()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object MoveLiteralMerchant(object P_0, object P_1)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void UpdateLiteralMerchant(object P_0, RuntimeFieldHandle P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DeleteLiteralMerchant(object P_0)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GetLiteralMerchant()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void AssetLiteralMerchant(object P_0, object P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void FillLiteralMerchant(object P_0, object P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ValidateLiteralMerchant(object P_0)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void ListLiteralMerchant(object P_0, object P_1, int P_2, int P_3)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void RunLiteralMerchant(object P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SortLiteralMerchant(object P_0)
		{
			return null;
		}

		static ItemFacade()
		{
			ResolveStub();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint StatePropertyPolicy(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr CreatorAdapterWatcher();

	internal struct ExporterFacade
	{
		internal bool m_AttributeFacade;

		internal byte[] m_ProcFacade;
	}

	internal class StubAuthentication
	{
		private object _WrapperAuthentication;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public StubAuthentication(Stream key)
		{
			//Discarded unreachable code: IL_0002
			_WrapperAuthentication = new BinaryReader(key);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		internal Stream KDikMXewCI()
		{
			//Discarded unreachable code: IL_0002
			return ((BinaryReader)_WrapperAuthentication).BaseStream;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal byte[] AssetStub(int def_amount)
		{
			//Discarded unreachable code: IL_0002
			return (byte[])PrepareLiteralMerchant(_WrapperAuthentication, def_amount);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int ReflectStub(byte[] def, int rowconnection, int ID_third)
		{
			//Discarded unreachable code: IL_0002
			return CallLiteralMerchant(_WrapperAuthentication, def, rowconnection, ID_third);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int RevertStub()
		{
			//Discarded unreachable code: IL_0002
			return ((BinaryReader)_WrapperAuthentication).ReadInt32();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void CreateWrapper()
		{
			//Discarded unreachable code: IL_0002
			CheckLiteralMerchant(_WrapperAuthentication);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object PrepareLiteralMerchant(object P_0, int P_1)
		{
			//Discarded unreachable code: IL_0002
			return ((BinaryReader)P_0).ReadBytes(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int CallLiteralMerchant(object P_0, object P_1, int P_2, int P_3)
		{
			//Discarded unreachable code: IL_0002
			return ((BinaryReader)P_0).Read((byte[])P_1, P_2, P_3);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void CheckLiteralMerchant(object P_0)
		{
			//Discarded unreachable code: IL_0002
			((BinaryReader)P_0).Close();
		}

		static StubAuthentication()
		{
			ResolveStub();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	private delegate IntPtr BridgeAuthentication(IntPtr hModule, string lpName, uint lpType);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr RulesAuthentication(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int TagWorkerStatus(IntPtr hProcess, IntPtr lpBaseAddress, [In][Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int FilterAuthentication(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr ValWorkerDic(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int BroadcasterOrderAnnotation(IntPtr ptr);

	[Flags]
	private enum MemberModifier
	{

	}

	private static int m_ParameterFacade;

	private static object _InterpreterFacade;

	private static object m_ModelFacade;

	private static bool resolverFacade;

	private static Dictionary<int, int> parserFacade;

	private static long roleFacade;

	private static IntPtr _MethodFacade;

	private static IntPtr _PredicateFacade;

	private static bool schemaFacade;

	[TestsFacade(typeof(TestsFacade.GetterFacade<object>[]))]
	private static bool managerFacade;

	private static object m_ServiceFacade;

	private static IntPtr m_DescriptorFacade;

	private static object mockFacade;

	internal static object m_ProducerFacade;

	private static int _CandidateFacade;

	internal static object m_DatabaseFacade;

	private static object composerFacade;

	internal static object _CustomerFacade;

	internal static object _StrategyFacade;

	private static object m_PoolFacade;

	private static bool _PrinterFacade;

	private static object m_ProccesorFacade;

	private static object m_RepositoryFacade;

	private static bool _TagFacade;

	private static IntPtr m_AdvisorFacade;

	private static object mapperFacade;

	private static int m_PageFacade;

	private static object _TemplateFacade;

	internal static object _ConfigurationFacade;

	private static object m_ContainerFacade;

	private static long _ProcessFacade;

	private static object m_RefFacade;

	private static int _MappingFacade;

	private static bool listFacade;

	private static object _DecoratorFacade;

	private static bool m_ClientFacade;

	private static object m_IssuerFacade;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static WriterPropertyProducer()
	{
		schemaFacade = false;
		m_ProducerFacade = Type.GetTypeFromHandle(ComposerWorkerStatus.DisableLiteralProc(33562134)).Assembly;
		m_ModelFacade = new uint[64]
		{
			3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
			4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
			3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
			1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
			681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
			2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
			4149444226u, 3174756917u, 718787259u, 3951481745u
		};
		listFacade = false;
		_TagFacade = false;
		composerFacade = new byte[0];
		_ConfigurationFacade = null;
		parserFacade = null;
		m_ServiceFacade = new object();
		m_RepositoryFacade = new byte[0];
		m_IssuerFacade = new byte[0];
		m_DescriptorFacade = IntPtr.Zero;
		m_AdvisorFacade = IntPtr.Zero;
		m_ContainerFacade = new string[0];
		mockFacade = new int[0];
		_CandidateFacade = 1;
		_PrinterFacade = false;
		m_ProccesorFacade = new SortedList();
		_MappingFacade = 0;
		roleFacade = 0L;
		_StrategyFacade = null;
		_CustomerFacade = null;
		_ProcessFacade = 0L;
		m_PageFacade = 0;
		resolverFacade = false;
		m_ClientFacade = false;
		m_ParameterFacade = 0;
		_MethodFacade = IntPtr.Zero;
		managerFacade = false;
		m_DatabaseFacade = new Hashtable();
		_InterpreterFacade = null;
		_TemplateFacade = null;
		_DecoratorFacade = null;
		m_RefFacade = null;
		mapperFacade = null;
		m_PoolFacade = null;
		_PredicateFacade = IntPtr.Zero;
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PrintLiteralProc()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte[] SelectStub(object ident)
	{
		uint[] array = new uint[16];
		int num = 448 - ((Array)ident).Length * 8 % 512;
		uint num2 = (uint)((num + 512) % 512);
		if (num2 == 0)
		{
			num2 = 512u;
		}
		uint num3 = (uint)(((Array)ident).Length + num2 / 8u + 8);
		ulong num4 = (ulong)((Array)ident).Length * 8uL;
		byte[] array2 = new byte[num3];
		for (int i = 0; i < ((Array)ident).Length; i++)
		{
			array2[i] = ((byte[])ident)[i];
		}
		array2[((Array)ident).Length] |= 128;
		for (int num5 = 8; num5 > 0; num5--)
		{
			array2[num3 - num5] = (byte)((num4 >> (8 - num5) * 8) & 0xFF);
		}
		uint num6 = (uint)(array2.Length * 8) / 32u;
		uint item = 1732584193u;
		uint item2 = 4023233417u;
		uint item3 = 2562383102u;
		uint item4 = 271733878u;
		for (uint num7 = 0u; num7 < num6 / 16u; num7++)
		{
			uint num8 = num7 << 6;
			for (uint num9 = 0u; num9 < 61; num9 += 4)
			{
				array[num9 >> 2] = (uint)((array2[num8 + (num9 + 3)] << 24) | (array2[num8 + (num9 + 2)] << 16) | (array2[num8 + (num9 + 1)] << 8) | array2[num8 + num9]);
			}
			uint num10 = item;
			uint num11 = item2;
			uint num12 = item3;
			uint num13 = item4;
			InterruptStub(ref item, item2, item3, item4, 0u, 7, 1u, array);
			InterruptStub(ref item4, item, item2, item3, 1u, 12, 2u, array);
			InterruptStub(ref item3, item4, item, item2, 2u, 17, 3u, array);
			InterruptStub(ref item2, item3, item4, item, 3u, 22, 4u, array);
			InterruptStub(ref item, item2, item3, item4, 4u, 7, 5u, array);
			InterruptStub(ref item4, item, item2, item3, 5u, 12, 6u, array);
			InterruptStub(ref item3, item4, item, item2, 6u, 17, 7u, array);
			InterruptStub(ref item2, item3, item4, item, 7u, 22, 8u, array);
			InterruptStub(ref item, item2, item3, item4, 8u, 7, 9u, array);
			InterruptStub(ref item4, item, item2, item3, 9u, 12, 10u, array);
			InterruptStub(ref item3, item4, item, item2, 10u, 17, 11u, array);
			InterruptStub(ref item2, item3, item4, item, 11u, 22, 12u, array);
			InterruptStub(ref item, item2, item3, item4, 12u, 7, 13u, array);
			InterruptStub(ref item4, item, item2, item3, 13u, 12, 14u, array);
			InterruptStub(ref item3, item4, item, item2, 14u, 17, 15u, array);
			InterruptStub(ref item2, item3, item4, item, 15u, 22, 16u, array);
			DefineStub(ref item, item2, item3, item4, 1u, 5, 17u, array);
			DefineStub(ref item4, item, item2, item3, 6u, 9, 18u, array);
			DefineStub(ref item3, item4, item, item2, 11u, 14, 19u, array);
			DefineStub(ref item2, item3, item4, item, 0u, 20, 20u, array);
			DefineStub(ref item, item2, item3, item4, 5u, 5, 21u, array);
			DefineStub(ref item4, item, item2, item3, 10u, 9, 22u, array);
			DefineStub(ref item3, item4, item, item2, 15u, 14, 23u, array);
			DefineStub(ref item2, item3, item4, item, 4u, 20, 24u, array);
			DefineStub(ref item, item2, item3, item4, 9u, 5, 25u, array);
			DefineStub(ref item4, item, item2, item3, 14u, 9, 26u, array);
			DefineStub(ref item3, item4, item, item2, 3u, 14, 27u, array);
			DefineStub(ref item2, item3, item4, item, 8u, 20, 28u, array);
			DefineStub(ref item, item2, item3, item4, 13u, 5, 29u, array);
			DefineStub(ref item4, item, item2, item3, 2u, 9, 30u, array);
			DefineStub(ref item3, item4, item, item2, 7u, 14, 31u, array);
			DefineStub(ref item2, item3, item4, item, 12u, 20, 32u, array);
			DestroyStub(ref item, item2, item3, item4, 5u, 4, 33u, array);
			DestroyStub(ref item4, item, item2, item3, 8u, 11, 34u, array);
			DestroyStub(ref item3, item4, item, item2, 11u, 16, 35u, array);
			DestroyStub(ref item2, item3, item4, item, 14u, 23, 36u, array);
			DestroyStub(ref item, item2, item3, item4, 1u, 4, 37u, array);
			DestroyStub(ref item4, item, item2, item3, 4u, 11, 38u, array);
			DestroyStub(ref item3, item4, item, item2, 7u, 16, 39u, array);
			DestroyStub(ref item2, item3, item4, item, 10u, 23, 40u, array);
			DestroyStub(ref item, item2, item3, item4, 13u, 4, 41u, array);
			DestroyStub(ref item4, item, item2, item3, 0u, 11, 42u, array);
			DestroyStub(ref item3, item4, item, item2, 3u, 16, 43u, array);
			DestroyStub(ref item2, item3, item4, item, 6u, 23, 44u, array);
			DestroyStub(ref item, item2, item3, item4, 9u, 4, 45u, array);
			DestroyStub(ref item4, item, item2, item3, 12u, 11, 46u, array);
			DestroyStub(ref item3, item4, item, item2, 15u, 16, 47u, array);
			DestroyStub(ref item2, item3, item4, item, 2u, 23, 48u, array);
			RestartStub(ref item, item2, item3, item4, 0u, 6, 49u, array);
			RestartStub(ref item4, item, item2, item3, 7u, 10, 50u, array);
			RestartStub(ref item3, item4, item, item2, 14u, 15, 51u, array);
			RestartStub(ref item2, item3, item4, item, 5u, 21, 52u, array);
			RestartStub(ref item, item2, item3, item4, 12u, 6, 53u, array);
			RestartStub(ref item4, item, item2, item3, 3u, 10, 54u, array);
			RestartStub(ref item3, item4, item, item2, 10u, 15, 55u, array);
			RestartStub(ref item2, item3, item4, item, 1u, 21, 56u, array);
			RestartStub(ref item, item2, item3, item4, 8u, 6, 57u, array);
			RestartStub(ref item4, item, item2, item3, 15u, 10, 58u, array);
			RestartStub(ref item3, item4, item, item2, 6u, 15, 59u, array);
			RestartStub(ref item2, item3, item4, item, 13u, 21, 60u, array);
			RestartStub(ref item, item2, item3, item4, 4u, 6, 61u, array);
			RestartStub(ref item4, item, item2, item3, 11u, 10, 62u, array);
			RestartStub(ref item3, item4, item, item2, 2u, 15, 63u, array);
			RestartStub(ref item2, item3, item4, item, 9u, 21, 64u, array);
			item += num10;
			item2 += num11;
			item3 += num12;
			item4 += num13;
		}
		byte[] array3 = new byte[16];
		Array.Copy(BitConverter.GetBytes(item), 0, array3, 0, 4);
		Array.Copy(BitConverter.GetBytes(item2), 0, array3, 4, 4);
		Array.Copy(BitConverter.GetBytes(item3), 0, array3, 8, 4);
		Array.Copy(BitConverter.GetBytes(item4), 0, array3, 12, 4);
		return array3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void InterruptStub(ref uint item, uint ID_b, uint dic_Z, uint numcfg2, uint pred3high, ushort x4_Low, uint indexOf_asset5, object setup6)
	{
		item = ID_b + ExcludeStub(item + ((ID_b & dic_Z) | (~ID_b & numcfg2)) + ((uint[])setup6)[pred3high] + ((uint[])m_ModelFacade)[indexOf_asset5 - 1], x4_Low);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void DefineStub(ref uint res, uint versionvis, uint ID_helper, uint maxv2, uint selection3_min, ushort max_connection4, uint var15low, object setup6)
	{
		res = versionvis + ExcludeStub(res + ((versionvis & maxv2) | (ID_helper & ~maxv2)) + ((uint[])setup6)[selection3_min] + ((uint[])m_ModelFacade)[var15low - 1], max_connection4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void DestroyStub(ref uint key, uint indexOf_pol, uint tag_counter, uint index_pol2, uint map3_counter, ushort ident4_Low, uint sizecont5, object instance6)
	{
		key = indexOf_pol + ExcludeStub(key + (indexOf_pol ^ tag_counter ^ index_pol2) + ((uint[])instance6)[map3_counter] + ((uint[])m_ModelFacade)[sizecont5 - 1], ident4_Low);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void RestartStub(ref uint def, uint ivk, uint ID_c, uint visitor2, uint pol3, ushort flags_def4, uint t5, object info6)
	{
		def = ivk + ExcludeStub(def + (ID_c ^ (ivk | ~visitor2)) + ((uint[])info6)[pol3] + ((uint[])m_ModelFacade)[t5 - 1], flags_def4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static uint ExcludeStub(uint positionparam, ushort cust_size)
	{
		return (positionparam >> 32 - cust_size) | (positionparam << (int)cust_size);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool LoginStub()
	{
		if (!listFacade)
		{
			TestStub();
			listFacade = true;
		}
		return _TagFacade;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static SymmetricAlgorithm PostStub()
	{
		SymmetricAlgorithm symmetricAlgorithm = null;
		if (LoginStub())
		{
			return new AesCryptoServiceProvider();
		}
		try
		{
			return new RijndaelManaged();
		}
		catch
		{
			return (SymmetricAlgorithm)Activator.CreateInstance("System.Core, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Security.Cryptography.AesCryptoServiceProvider")!.Unwrap();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestStub()
	{
		try
		{
			_TagFacade = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte[] RegisterStub(object key)
	{
		if (!LoginStub())
		{
			return new MD5CryptoServiceProvider().ComputeHash((byte[])key);
		}
		return SelectStub(key);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderStub(object info, object result, uint offset_comp, object visitor2)
	{
		while (offset_comp != 0)
		{
			int num = ((offset_comp > (uint)((Array)visitor2).Length) ? ((Array)visitor2).Length : ((int)offset_comp));
			((Stream)result).Read((byte[])visitor2, 0, num);
			IncludeStub(info, visitor2, 0, num);
			offset_comp -= (uint)num;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeStub(object setup, object cfg, int offsetproc, int nextselection2)
	{
		((HashAlgorithm)setup).TransformBlock((byte[])cfg, offsetproc, nextselection2, (byte[]?)cfg, offsetproc);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static uint EnableStub(uint max_reference, int indexOf_counter, long role_counter, object caller2)
	{
		for (int i = 0; i < indexOf_counter; i++)
		{
			((BinaryReader)caller2).BaseStream.Position = role_counter + (i * 40 + 8);
			uint num = ((BinaryReader)caller2).ReadUInt32();
			uint num2 = ((BinaryReader)caller2).ReadUInt32();
			((BinaryReader)caller2).ReadUInt32();
			uint num3 = ((BinaryReader)caller2).ReadUInt32();
			if (num2 <= max_reference && max_reference < num2 + num)
			{
				return num3 + max_reference - num2;
			}
		}
		return 0u;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[TestsFacade(typeof(TestsFacade.GetterFacade<object>[]))]
	internal static void QueryStub()
	{
		//Discarded unreachable code: IL_2fce, IL_3006, IL_3032, IL_309e, IL_30ad, IL_310d, IL_3348, IL_33c1, IL_33d0, IL_3563, IL_362d, IL_368f, IL_36b9, IL_37d1, IL_3823, IL_3832, IL_38d8, IL_39bc, IL_39cb, IL_39ec, IL_39fb, IL_3a75, IL_3ade, IL_3aed, IL_3b4b, IL_3b5a
		int num = 11;
		string text2 = default(string);
		bool flag2 = default(bool);
		byte[] array3 = default(byte[]);
		byte[] array4 = default(byte[]);
		int num31 = default(int);
		int num28 = default(int);
		int num30 = default(int);
		int num27 = default(int);
		Stream stream = default(Stream);
		int num29 = default(int);
		SymmetricAlgorithm symmetricAlgorithm = default(SymmetricAlgorithm);
		ICryptoTransform transform = default(ICryptoTransform);
		byte[] array5 = default(byte[]);
		byte[] array7 = default(byte[]);
		CryptoStream cryptoStream = default(CryptoStream);
		byte[] array6 = default(byte[]);
		HashAlgorithm hashAlgorithm = default(HashAlgorithm);
		string text = default(string);
		byte[] array2 = default(byte[]);
		byte[] array = default(byte[]);
		int num13 = default(int);
		BinaryReader binaryReader = default(BinaryReader);
		uint num17 = default(uint);
		uint num20 = default(uint);
		uint num18 = default(uint);
		int num14 = default(int);
		int num23 = default(int);
		uint num16 = default(uint);
		long num9 = default(long);
		long num19 = default(long);
		uint max_reference2 = default(uint);
		long num12 = default(long);
		uint max_reference = default(uint);
		int num11 = default(int);
		uint num8 = default(uint);
		long num22 = default(long);
		uint num21 = default(uint);
		bool flag = default(bool);
		long num10 = default(long);
		int num25 = default(int);
		int num6 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 9:
					if (text2 == null)
					{
						num2 = 5;
						continue;
					}
					goto case 1;
				case 13:
					if (flag2)
					{
						num2 = 1;
						if (PushManager())
						{
							num2 = 6;
						}
						continue;
					}
					flag2 = false;
					num2 = 18;
					if (ReflectManager() == null)
					{
						continue;
					}
					break;
				case 1:
					if (GetManager(text2) != 0)
					{
						num2 = 14;
						continue;
					}
					return;
				case 17:
					try
					{
						StubAuthentication stubAuthentication = new StubAuthentication((Stream)ListManager(m_ProducerFacade, "Server.Issuer"));
						int num26 = 134;
						while (true)
						{
							switch (num26)
							{
							case 33:
								array3 = new byte[32];
								num26 = 41;
								if (ReflectManager() != null)
								{
									num26 = 24;
								}
								continue;
							case 117:
								array3[1] = 70;
								num26 = 316;
								if (PushManager())
								{
									continue;
								}
								goto IL_00d5;
							case 66:
								array4[4] = (byte)num31;
								num26 = 102;
								continue;
							case 97:
								num28 = 89 + 93;
								num26 = 50;
								continue;
							case 20:
								array4[5] = 154;
								num26 = 131;
								if (PushManager())
								{
									num26 = 274;
								}
								continue;
							case 40:
								array4[15] = (byte)num30;
								num26 = 68;
								if (PushManager())
								{
									num26 = 318;
								}
								continue;
							case 192:
								array3[19] = 86;
								num26 = 239;
								continue;
							case 325:
								num31 = 40 + 68;
								num26 = 282;
								if (ReflectManager() != null)
								{
									num26 = 44;
								}
								continue;
							case 311:
								array3[16] = 150;
								num27 = 329;
								goto IL_00d5;
							case 13:
								VisitManager(_ConfigurationFacade, CompareManager(CheckManager(), ForgotManager(stream)));
								num26 = 88;
								continue;
							case 198:
								array3[14] = 100;
								num26 = 104;
								continue;
							case 61:
								array3[24] = (byte)num29;
								num26 = 324;
								continue;
							case 218:
								array4[1] = (byte)num30;
								num26 = 253;
								continue;
							case 271:
								num29 = 196 - 65;
								num26 = 305;
								continue;
							case 128:
								array4[13] = (byte)num31;
								num26 = 243;
								if (PushManager())
								{
									num26 = 319;
								}
								continue;
							case 69:
								num28 = 103 + 76;
								num26 = 291;
								continue;
							case 120:
								array4[10] = (byte)num31;
								num26 = 176;
								continue;
							case 248:
								num28 = 190 - 63;
								num26 = 94;
								continue;
							case 256:
								num28 = 180 - 60;
								num26 = 7;
								continue;
							case 14:
								num29 = 19 + 10;
								num26 = 130;
								continue;
							case 303:
								array3[7] = 98;
								num26 = 309;
								continue;
							case 203:
								num29 = 127 + 59;
								num26 = 205;
								if (PushManager())
								{
									continue;
								}
								goto IL_00d5;
							case 157:
								num28 = 229 - 76;
								num26 = 23;
								continue;
							case 155:
								array3[29] = (byte)num29;
								num26 = 131;
								if (PushManager())
								{
									continue;
								}
								goto IL_00d5;
							case 236:
								num29 = 242 - 80;
								num26 = 77;
								if (ReflectManager() == null)
								{
									num26 = 281;
								}
								continue;
							case 131:
								array3[29] = 138;
								num26 = 116;
								continue;
							case 179:
								num28 = 209 - 69;
								num26 = 278;
								if (PushManager())
								{
									continue;
								}
								goto IL_00d5;
							case 51:
								array4[8] = 102;
								num26 = 38;
								if (ReflectManager() != null)
								{
									num26 = 38;
								}
								continue;
							case 145:
								num29 = 92 - 19;
								num26 = 197;
								continue;
							case 204:
								array4[14] = (byte)num31;
								num26 = 326;
								if (ReflectManager() != null)
								{
									num26 = 105;
								}
								continue;
							case 228:
								num30 = 129 - 43;
								num26 = 57;
								continue;
							case 272:
								array4[0] = (byte)num30;
								num26 = 89;
								continue;
							case 274:
								array4[5] = 138;
								num26 = 52;
								continue;
							case 300:
								array3[18] = (byte)num28;
								num27 = 154;
								goto IL_00d5;
							case 225:
								array4[1] = (byte)num31;
								num27 = 216;
								goto IL_00d5;
							case 242:
								array3[1] = (byte)num29;
								num26 = 179;
								continue;
							case 77:
								array3[25] = (byte)num29;
								num26 = 260;
								if (ReflectManager() == null)
								{
									continue;
								}
								goto IL_00d5;
							case 18:
								num29 = 42 + 2;
								num26 = 155;
								continue;
							case 81:
								array3[20] = 153;
								num26 = 296;
								continue;
							case 73:
								array3[10] = 95;
								num26 = 78;
								if (ReflectManager() == null)
								{
									continue;
								}
								goto IL_00d5;
							case 46:
								num29 = 166 - 55;
								num26 = 79;
								if (ReflectManager() == null)
								{
									continue;
								}
								goto IL_00d5;
							case 317:
								num29 = 11 + 11;
								num26 = 159;
								if (ReflectManager() == null)
								{
									continue;
								}
								goto IL_00d5;
							case 180:
								array3[5] = 145;
								num26 = 47;
								continue;
							case 238:
								num31 = 128 + 42;
								num26 = 92;
								continue;
							case 75:
								num30 = 75 + 14;
								num26 = 284;
								continue;
							case 171:
								array4[6] = (byte)num30;
								num26 = 181;
								if (PushManager())
								{
									num26 = 235;
								}
								continue;
							case 107:
								array4[14] = (byte)num30;
								num26 = 191;
								if (ReflectManager() != null)
								{
									num26 = 126;
								}
								continue;
							case 288:
								num29 = 105 + 18;
								num26 = 264;
								if (ReflectManager() == null)
								{
									continue;
								}
								goto IL_00d5;
							case 148:
								array4[2] = 146;
								num26 = 238;
								if (ReflectManager() == null)
								{
									continue;
								}
								goto IL_00d5;
							case 163:
								array4[11] = (byte)num31;
								num26 = 75;
								if (PushManager())
								{
									continue;
								}
								goto IL_00d5;
							case 106:
								num31 = 102 + 66;
								num26 = 0;
								if (PushManager())
								{
									continue;
								}
								goto IL_00d5;
							case 239:
								num28 = 98 - 22;
								num26 = 206;
								if (ReflectManager() == null)
								{
									continue;
								}
								goto IL_00d5;
							case 16:
								array3[6] = 24;
								num26 = 320;
								continue;
							case 31:
								num29 = 161 - 53;
								num26 = 156;
								if (PushManager())
								{
									continue;
								}
								goto IL_00d5;
							case 266:
								array3[15] = 154;
								num26 = 113;
								continue;
							case 21:
								array3[29] = 142;
								num26 = 18;
								if (PushManager())
								{
									continue;
								}
								goto IL_00d5;
							case 166:
								array3[9] = (byte)num29;
								num26 = 74;
								if (ReflectManager() != null)
								{
									num26 = 70;
								}
								continue;
							case 178:
								num28 = 234 - 78;
								num26 = 283;
								continue;
							case 217:
								num28 = 157 - 52;
								num26 = 193;
								if (ReflectManager() == null)
								{
									continue;
								}
								goto IL_00d5;
							case 53:
								num31 = 36 + 91;
								num26 = 55;
								continue;
							case 296:
								num28 = 46 + 111;
								num26 = 285;
								if (ReflectManager() == null)
								{
									continue;
								}
								goto IL_00d5;
							case 82:
								num29 = 86 + 66;
								num26 = 170;
								continue;
							case 202:
								num31 = 97 - 73;
								num26 = 163;
								continue;
							case 252:
								array3[28] = (byte)num29;
								num27 = 236;
								goto IL_00d5;
							case 50:
								array3[15] = (byte)num28;
								num26 = 67;
								continue;
							case 305:
								array3[25] = (byte)num29;
								num26 = 27;
								if (PushManager())
								{
									continue;
								}
								goto IL_00d5;
							case 253:
								num31 = 206 - 68;
								num26 = 224;
								if (ReflectManager() == null)
								{
									continue;
								}
								goto IL_00d5;
							case 38:
								num30 = 48 + 87;
								num26 = 114;
								if (!PushManager())
								{
									num26 = 67;
								}
								continue;
							case 332:
								array3[8] = (byte)num29;
								num26 = 306;
								continue;
							case 15:
								array3[21] = 117;
								num26 = 1;
								if (PushManager())
								{
									continue;
								}
								goto IL_00d5;
							case 103:
								num28 = 230 - 76;
								num26 = 83;
								if (PushManager())
								{
									continue;
								}
								goto IL_00d5;
							case 2:
								num29 = 85 + 32;
								num26 = 245;
								continue;
							case 234:
								array4[9] = 100;
								num26 = 185;
								continue;
							case 129:
								num28 = 20 + 108;
								num26 = 314;
								if (ReflectManager() == null)
								{
									num26 = 314;
								}
								continue;
							case 121:
								array3[6] = 102;
								num26 = 16;
								continue;
							case 102:
								array4[4] = 90;
								num26 = 56;
								continue;
							case 24:
								array3[12] = 146;
								num26 = 139;
								if (ReflectManager() != null)
								{
									num26 = 95;
								}
								continue;
							case 110:
								array3[31] = 159;
								num26 = 269;
								continue;
							case 294:
								num31 = 32 + 121;
								num26 = 66;
								continue;
							case 224:
								array4[2] = (byte)num31;
								num26 = 97;
								if (PushManager())
								{
									num26 = 257;
								}
								continue;
							case 324:
								array3[24] = 90;
								num26 = 11;
								if (ReflectManager() == null)
								{
									continue;
								}
								goto IL_00d5;
							case 96:
								num29 = 169 - 56;
								num26 = 175;
								continue;
							case 320:
								array3[6] = 142;
								num26 = 167;
								continue;
							case 72:
								array3[1] = 135;
								num26 = 217;
								continue;
							case 335:
								num28 = 133 - 44;
								num26 = 140;
								if (PushManager())
								{
									continue;
								}
								goto IL_00d5;
							case 27:
								num28 = 4 + 45;
								num26 = 29;
								continue;
							case 28:
								num31 = 115 + 122;
								num26 = 204;
								if (PushManager())
								{
									continue;
								}
								goto IL_00d5;
							case 264:
								array3[27] = (byte)num29;
								num26 = 240;
								continue;
							case 318:
								array4[15] = 158;
								num26 = 10;
								if (PushManager())
								{
									num26 = 45;
								}
								continue;
							case 277:
								num28 = 55 + 56;
								num26 = 149;
								if (ReflectManager() != null)
								{
									num26 = 59;
								}
								continue;
							case 331:
								num29 = 101 + 51;
								num26 = 184;
								continue;
							case 49:
								array3[16] = (byte)num29;
								num27 = 220;
								goto IL_00d5;
							case 152:
								num29 = 125 + 68;
								num27 = 227;
								goto IL_00d5;
							case 93:
								array4[1] = (byte)num31;
								num26 = 325;
								continue;
							case 99:
								array3[13] = 111;
								num26 = 194;
								if (!PushManager())
								{
									num26 = 117;
								}
								continue;
							case 149:
								array3[12] = (byte)num28;
								num26 = 24;
								if (ReflectManager() != null)
								{
									num26 = 2;
								}
								continue;
							case 111:
								array3[8] = (byte)num28;
								num26 = 199;
								continue;
							case 223:
								num28 = 89 - 82;
								num26 = 111;
								if (!PushManager())
								{
									num26 = 63;
								}
								continue;
							case 41:
								num28 = 197 - 65;
								num27 = 126;
								goto IL_00d5;
							case 124:
								num29 = 127 + 43;
								num26 = 71;
								if (ReflectManager() == null)
								{
									continue;
								}
								goto IL_00d5;
							case 17:
								array3[1] = (byte)num28;
								num26 = 44;
								continue;
							case 327:
								array3[15] = (byte)num28;
								num26 = 6;
								if (ReflectManager() == null)
								{
									num26 = 14;
								}
								continue;
							case 247:
								symmetricAlgorithm = (SymmetricAlgorithm)ResetManager();
								num26 = 237;
								continue;
							case 299:
								num29 = 135 - 45;
								num26 = 153;
								continue;
							case 94:
								array3[0] = (byte)num28;
								num26 = 262;
								continue;
							case 62:
								array4[2] = (byte)num31;
								num26 = 148;
								if (!PushManager())
								{
									num26 = 106;
								}
								continue;
							case 95:
								array3[22] = 168;
								num26 = 143;
								continue;
							case 22:
								num30 = 105 + 53;
								num26 = 272;
								if (PushManager())
								{
									continue;
								}
								goto IL_00d5;
							case 291:
								array3[13] = (byte)num28;
								num27 = 36;
								goto IL_00d5;
							case 84:
								array4[5] = 92;
								num26 = 258;
								continue;
							case 188:
								transform = (ICryptoTransform)SetManager(symmetricAlgorithm, array5, array7);
								num26 = 70;
								continue;
							case 175:
								array3[5] = (byte)num29;
								num26 = 180;
								continue;
							case 139:
								num28 = 153 - 69;
								num26 = 56;
								if (PushManager())
								{
									num26 = 133;
								}
								continue;
							case 233:
								num29 = 174 - 58;
								num26 = 295;
								if (ReflectManager() == null)
								{
									continue;
								}
								goto IL_00d5;
							case 42:
								array3[23] = 90;
								num26 = 85;
								continue;
							case 135:
								num31 = 88 + 63;
								num26 = 312;
								continue;
							case 169:
								num30 = 44 - 0;
								num27 = 218;
								goto IL_00d5;
							case 309:
								array3[7] = 138;
								num26 = 331;
								if (ReflectManager() == null)
								{
									continue;
								}
								goto IL_00d5;
							case 334:
								array3[30] = (byte)num28;
								num26 = 4;
								continue;
							case 315:
								array3[31] = 104;
								num26 = 136;
								if (PushManager())
								{
									continue;
								}
								goto IL_00d5;
							case 174:
								array3[29] = (byte)num28;
								num26 = 10;
								if (PushManager())
								{
									continue;
								}
								goto IL_00d5;
							case 162:
								array4[7] = 46;
								num26 = 214;
								continue;
							case 87:
								num30 = 178 - 59;
								num26 = 65;
								if (!PushManager())
								{
									num26 = 61;
								}
								continue;
							case 189:
								num29 = 116 + 69;
								num26 = 6;
								continue;
							case 301:
								num31 = 120 + 12;
								num26 = 168;
								continue;
							case 235:
								num31 = 163 - 54;
								num26 = 323;
								if (ReflectManager() == null)
								{
									continue;
								}
								goto IL_00d5;
							case 113:
								array3[15] = 119;
								num26 = 97;
								continue;
							case 140:
								array3[21] = (byte)num28;
								num26 = 145;
								continue;
							case 101:
								array3[17] = 140;
								num27 = 241;
								goto IL_00d5;
							case 74:
								num28 = 144 - 20;
								num26 = 151;
								continue;
							case 68:
								array3[23] = (byte)num28;
								num26 = 244;
								continue;
							case 205:
								array3[4] = (byte)num29;
								num26 = 96;
								if (ReflectManager() == null)
								{
									continue;
								}
								goto IL_00d5;
							case 37:
								num30 = 10 + 67;
								num26 = 127;
								if (PushManager())
								{
									continue;
								}
								goto IL_00d5;
							case 214:
								array4[8] = 202;
								num26 = 289;
								continue;
							case 60:
								num29 = 97 + 98;
								num26 = 61;
								continue;
							case 88:
								ViewManager(stream);
								num26 = 137;
								if (PushManager())
								{
									continue;
								}
								goto IL_00d5;
							case 261:
								array4[13] = (byte)num31;
								num26 = 301;
								if (PushManager())
								{
									continue;
								}
								goto IL_00d5;
							case 83:
								array3[6] = (byte)num28;
								num26 = 2;
								if (ReflectManager() == null)
								{
									continue;
								}
								goto IL_00d5;
							case 270:
								array4[9] = (byte)num30;
								num26 = 268;
								continue;
							case 314:
								array3[20] = (byte)num28;
								num26 = 3;
								if (ReflectManager() == null)
								{
									num26 = 81;
								}
								continue;
							case 278:
								array3[1] = (byte)num28;
								num26 = 292;
								continue;
							case 71:
								array3[2] = (byte)num29;
								num26 = 189;
								continue;
							case 118:
								array3[16] = (byte)num29;
								num26 = 311;
								continue;
							case 313:
								num30 = 64 - 42;
								num26 = 171;
								if (PushManager())
								{
									continue;
								}
								goto IL_00d5;
							case 307:
								array3[14] = (byte)num28;
								num26 = 198;
								continue;
							case 80:
								num29 = 209 - 69;
								num26 = 118;
								if (!PushManager())
								{
									num26 = 79;
								}
								continue;
							case 161:
								array4[3] = 108;
								num26 = 62;
								if (PushManager())
								{
									num26 = 112;
								}
								continue;
							case 78:
								array3[11] = 106;
								num26 = 43;
								if (ReflectManager() == null)
								{
									continue;
								}
								goto IL_00d5;
							case 292:
								num29 = 3 + 58;
								num26 = 25;
								continue;
							case 196:
								cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write);
								num26 = 243;
								if (PushManager())
								{
									continue;
								}
								goto IL_00d5;
							case 43:
								array3[11] = 163;
								num26 = 195;
								if (ReflectManager() == null)
								{
									continue;
								}
								goto IL_00d5;
							case 240:
								num28 = 13 + 28;
								num26 = 310;
								continue;
							case 65:
								array4[8] = (byte)num30;
								num26 = 106;
								if (PushManager())
								{
									num26 = 304;
								}
								continue;
							case 221:
								num28 = 131 - 43;
								num26 = 165;
								continue;
							case 8:
								num29 = 90 - 74;
								num26 = 147;
								continue;
							case 159:
								array3[26] = (byte)num29;
								num26 = 333;
								continue;
							case 164:
								array3[3] = 144;
								num26 = 27;
								if (ReflectManager() == null)
								{
									num26 = 201;
								}
								continue;
							case 279:
								array4 = new byte[16];
								num26 = 161;
								if (ReflectManager() == null)
								{
									num26 = 213;
								}
								continue;
							case 56:
								array4[4] = 205;
								num26 = 26;
								continue;
							case 154:
								array3[19] = 97;
								num26 = 75;
								if (PushManager())
								{
									num26 = 192;
								}
								continue;
							case 230:
								array3[0] = 164;
								num26 = 233;
								continue;
							case 319:
								num31 = 40 + 89;
								num26 = 261;
								continue;
							case 286:
								num30 = 173 - 57;
								num26 = 173;
								if (PushManager())
								{
									continue;
								}
								goto IL_00d5;
							case 329:
								array3[16] = 82;
								num26 = 126;
								if (ReflectManager() == null)
								{
									num26 = 275;
								}
								continue;
							case 244:
								array3[23] = 228;
								num26 = 60;
								continue;
							case 170:
								array3[10] = (byte)num29;
								num26 = 73;
								if (ReflectManager() == null)
								{
									continue;
								}
								goto IL_00d5;
							case 112:
								array4[3] = 108;
								num26 = 106;
								continue;
							case 282:
								array4[1] = (byte)num31;
								num26 = 59;
								continue;
							case 153:
								array3[15] = (byte)num29;
								num26 = 266;
								continue;
							case 287:
								array3[25] = 166;
								num26 = 317;
								continue;
							case 123:
								array3[4] = (byte)num29;
								num26 = 122;
								continue;
							case 281:
								array3[29] = (byte)num29;
								num26 = 46;
								continue;
							case 54:
								array3[10] = (byte)num29;
								num26 = 82;
								continue;
							case 333:
								array3[26] = 189;
								num27 = 177;
								goto IL_00d5;
							case 306:
								array3[8] = 144;
								num26 = 223;
								if (ReflectManager() != null)
								{
									num26 = 46;
								}
								continue;
							case 90:
								array4[12] = 41;
								num26 = 98;
								continue;
							case 133:
								array3[12] = (byte)num28;
								num26 = 293;
								continue;
							case 295:
								array3[0] = (byte)num29;
								num26 = 248;
								continue;
							case 268:
								array4[9] = 2;
								num26 = 286;
								continue;
							case 310:
								array3[27] = (byte)num28;
								num26 = 207;
								continue;
							case 220:
								array3[16] = 111;
								num26 = 80;
								if (ReflectManager() == null)
								{
									continue;
								}
								goto IL_00d5;
							case 215:
								num29 = 163 - 54;
								num26 = 77;
								if (PushManager())
								{
									continue;
								}
								goto IL_00d5;
							case 141:
								num29 = 101 + 117;
								num26 = 64;
								if (PushManager())
								{
									continue;
								}
								goto IL_00d5;
							case 63:
								array4[14] = 107;
								num26 = 228;
								continue;
							case 208:
								array3[8] = (byte)num28;
								num26 = 91;
								if (ReflectManager() != null)
								{
									num26 = 60;
								}
								continue;
							case 23:
								array3[3] = (byte)num28;
								num26 = 221;
								if (PushManager())
								{
									continue;
								}
								goto IL_00d5;
							case 258:
								array4[6] = 140;
								num26 = 43;
								if (ReflectManager() == null)
								{
									num26 = 182;
								}
								continue;
							case 125:
								num29 = 88 + 80;
								num26 = 54;
								if (PushManager())
								{
									continue;
								}
								goto IL_00d5;
							case 193:
								array3[2] = (byte)num28;
								num26 = 190;
								continue;
							case 130:
								array3[15] = (byte)num29;
								num26 = 299;
								if (ReflectManager() == null)
								{
									continue;
								}
								goto IL_00d5;
							case 26:
								num30 = 53 + 24;
								num27 = 105;
								goto IL_00d5;
							case 119:
								array7 = array4;
								num26 = 247;
								continue;
							case 76:
								array4[6] = (byte)num30;
								num27 = 12;
								goto IL_00d5;
							case 47:
								array3[5] = 141;
								num26 = 103;
								if (ReflectManager() == null)
								{
									continue;
								}
								goto IL_00d5;
							case 284:
								array4[12] = (byte)num30;
								num26 = 183;
								continue;
							case 10:
								num28 = 254 - 84;
								num26 = 160;
								if (PushManager())
								{
									continue;
								}
								goto IL_00d5;
							case 35:
								num28 = 106 + 24;
								num26 = 45;
								if (ReflectManager() == null)
								{
									num26 = 208;
								}
								continue;
							case 109:
								array3[9] = (byte)num29;
								num26 = 158;
								continue;
							case 263:
								num30 = 69 + 50;
								num26 = 67;
								if (ReflectManager() == null)
								{
									num26 = 107;
								}
								continue;
							case 289:
								array4[8] = 123;
								num26 = 87;
								continue;
							case 265:
								array3[4] = 193;
								num26 = 203;
								continue;
							case 57:
								array4[14] = (byte)num30;
								num26 = 53;
								if (!PushManager())
								{
									num26 = 1;
								}
								continue;
							case 250:
								num28 = 72 + 94;
								num26 = 327;
								continue;
							case 182:
								num30 = 247 - 82;
								num26 = 76;
								continue;
							case 19:
								array4[12] = (byte)num30;
								num26 = 146;
								continue;
							case 98:
								num31 = 115 + 72;
								num27 = 128;
								goto IL_00d5;
							case 213:
								array4[0] = 129;
								num26 = 22;
								continue;
							case 116:
								num28 = 74 - 10;
								num26 = 174;
								continue;
							case 206:
								array3[19] = (byte)num28;
								num26 = 210;
								continue;
							case 273:
								array3[31] = 178;
								num26 = 321;
								continue;
							case 229:
								num29 = 122 + 121;
								num26 = 322;
								continue;
							case 297:
								num28 = 157 - 52;
								num26 = 55;
								if (ReflectManager() == null)
								{
									num26 = 334;
								}
								continue;
							case 246:
								array3[31] = (byte)num29;
								num26 = 273;
								continue;
							case 79:
								array3[29] = (byte)num29;
								num27 = 21;
								goto IL_00d5;
							case 190:
								num29 = 101 + 51;
								num26 = 226;
								continue;
							case 158:
								array3[9] = 93;
								num26 = 212;
								continue;
							case 326:
								num30 = 0 + 61;
								num26 = 40;
								continue;
							case 55:
								array4[14] = (byte)num31;
								num26 = 28;
								continue;
							case 251:
								array3[3] = 137;
								num26 = 157;
								continue;
							case 137:
								ViewManager(cryptoStream);
								num26 = 150;
								continue;
							case 1:
								array3[21] = 200;
								num26 = 335;
								if (PushManager())
								{
									continue;
								}
								goto IL_00d5;
							case 115:
								array3[14] = 219;
								num26 = 250;
								if (PushManager())
								{
									continue;
								}
								goto IL_00d5;
							case 316:
								num28 = 56 + 18;
								num26 = 17;
								if (PushManager())
								{
									continue;
								}
								goto IL_00d5;
							case 108:
								array4[7] = 173;
								num26 = 162;
								continue;
							case 122:
								num28 = 51 + 113;
								num27 = 32;
								goto IL_00d5;
							case 183:
								num30 = 21 + 73;
								num26 = 19;
								if (ReflectManager() != null)
								{
									num26 = 5;
								}
								continue;
							case 283:
								array3[7] = (byte)num28;
								num26 = 303;
								if (!PushManager())
								{
									num26 = 213;
								}
								continue;
							case 257:
								num31 = 205 - 68;
								num26 = 5;
								if (PushManager())
								{
									num26 = 62;
								}
								continue;
							case 293:
								array3[13] = 228;
								num26 = 69;
								if (PushManager())
								{
									continue;
								}
								goto IL_00d5;
							case 25:
								array3[1] = (byte)num29;
								num26 = 3;
								if (PushManager())
								{
									num26 = 72;
								}
								continue;
							case 275:
								num29 = 36 + 57;
								num27 = 186;
								goto IL_00d5;
							case 201:
								num29 = 155 - 51;
								num26 = 123;
								continue;
							case 219:
								array6 = (byte[])FlushManager(stubAuthentication, (int)VerifyManager(RunManager(stubAuthentication)));
								num26 = 33;
								if (ReflectManager() == null)
								{
									continue;
								}
								goto IL_00d5;
							case 132:
								array3[17] = (byte)num29;
								num26 = 7;
								if (ReflectManager() == null)
								{
									num26 = 138;
								}
								continue;
							case 91:
								num29 = 96 + 32;
								num26 = 332;
								if (ReflectManager() == null)
								{
									continue;
								}
								goto IL_00d5;
							case 237:
								CalculateManager(symmetricAlgorithm, CipherMode.CBC);
								num26 = 188;
								continue;
							case 328:
								array3[8] = (byte)num28;
								num26 = 35;
								if (ReflectManager() == null)
								{
									continue;
								}
								goto IL_00d5;
							case 48:
								num28 = 130 - 43;
								num26 = 187;
								if (ReflectManager() == null)
								{
									continue;
								}
								goto IL_00d5;
							case 312:
								array4[4] = (byte)num31;
								num26 = 294;
								continue;
							case 186:
								array3[17] = (byte)num29;
								num27 = 276;
								goto IL_00d5;
							case 290:
								num29 = 210 - 70;
								num26 = 49;
								continue;
							case 138:
								array3[17] = 153;
								num26 = 229;
								continue;
							default:
								array4[3] = (byte)num31;
								num26 = 135;
								if (ReflectManager() == null)
								{
									continue;
								}
								goto IL_00d5;
							case 176:
								array4[11] = 199;
								num26 = 100;
								continue;
							case 45:
								array4[15] = 121;
								num26 = 211;
								continue;
							case 100:
								array4[11] = 120;
								num26 = 28;
								if (ReflectManager() == null)
								{
									num26 = 202;
								}
								continue;
							case 70:
								stream = (Stream)PopManager();
								num26 = 196;
								continue;
							case 59:
								num31 = 133 - 44;
								num26 = 225;
								continue;
							case 181:
								array4[9] = (byte)num31;
								num26 = 232;
								continue;
							case 64:
								array3[28] = (byte)num29;
								num26 = 256;
								continue;
							case 259:
								array3[22] = (byte)num29;
								num26 = 8;
								if (PushManager())
								{
									continue;
								}
								goto IL_00d5;
							case 30:
								num30 = 165 - 55;
								num26 = 222;
								continue;
							case 210:
								array3[20] = 108;
								num26 = 129;
								if (PushManager())
								{
									continue;
								}
								goto IL_00d5;
							case 151:
								array3[9] = (byte)num28;
								num26 = 125;
								continue;
							case 177:
								num29 = 233 - 124;
								num26 = 142;
								continue;
							case 150:
								SearchManager(stubAuthentication);
								num26 = 28;
								if (PushManager())
								{
									num26 = 34;
								}
								continue;
							case 142:
								array3[26] = (byte)num29;
								num26 = 288;
								continue;
							case 269:
								array3[31] = 132;
								num26 = 298;
								continue;
							case 85:
								num28 = 226 - 75;
								num26 = 68;
								if (ReflectManager() == null)
								{
									continue;
								}
								goto IL_00d5;
							case 323:
								array4[7] = (byte)num31;
								num26 = 108;
								continue;
							case 241:
								num29 = 2 + 89;
								num26 = 132;
								continue;
							case 11:
								array3[24] = 185;
								num27 = 215;
								goto IL_00d5;
							case 322:
								array3[18] = (byte)num29;
								num26 = 302;
								continue;
							case 267:
								array3[22] = 151;
								num27 = 95;
								goto IL_00d5;
							case 285:
								array3[20] = (byte)num28;
								num26 = 48;
								if (ReflectManager() == null)
								{
									continue;
								}
								goto IL_00d5;
							case 194:
								num28 = 163 - 54;
								num26 = 98;
								if (ReflectManager() == null)
								{
									num26 = 307;
								}
								continue;
							case 216:
								array4[1] = 109;
								num27 = 169;
								goto IL_00d5;
							case 32:
								array3[4] = (byte)num28;
								num26 = 144;
								if (ReflectManager() == null)
								{
									continue;
								}
								goto IL_00d5;
							case 308:
								num31 = 84 + 25;
								num26 = 93;
								if (ReflectManager() == null)
								{
									continue;
								}
								goto IL_00d5;
							case 134:
								SortManager(RunManager(stubAuthentication), 0L);
								num26 = 219;
								continue;
							case 168:
								array4[13] = (byte)num31;
								num26 = 98;
								if (PushManager())
								{
									num26 = 263;
								}
								continue;
							case 36:
								array3[13] = 116;
								num26 = 99;
								continue;
							case 232:
								num30 = 77 + 73;
								num26 = 270;
								if (ReflectManager() == null)
								{
									continue;
								}
								goto IL_00d5;
							case 173:
								array4[10] = (byte)num30;
								num26 = 37;
								if (ReflectManager() != null)
								{
									num26 = 20;
								}
								continue;
							case 29:
								array3[25] = (byte)num28;
								num26 = 287;
								if (!PushManager())
								{
									num26 = 35;
								}
								continue;
							case 104:
								array3[14] = 94;
								num26 = 115;
								if (PushManager())
								{
									continue;
								}
								goto IL_00d5;
							case 58:
								array4[12] = (byte)num30;
								num26 = 1;
								if (PushManager())
								{
									num26 = 30;
								}
								continue;
							case 298:
								num29 = 17 + 69;
								num26 = 172;
								continue;
							case 243:
								PrepareManager(cryptoStream, array6, 0, array6.Length);
								num26 = 5;
								continue;
							case 39:
								num31 = 198 + 38;
								num26 = 209;
								continue;
							case 44:
								num29 = 45 + 104;
								num26 = 242;
								if (!PushManager())
								{
									num26 = 223;
								}
								continue;
							case 136:
								num29 = 0 + 87;
								num26 = 246;
								if (PushManager())
								{
									continue;
								}
								goto IL_00d5;
							case 211:
								array4[15] = 53;
								num26 = 119;
								continue;
							case 280:
								array4[6] = (byte)num30;
								num26 = 313;
								if (ReflectManager() == null)
								{
									continue;
								}
								goto IL_00d5;
							case 249:
								num29 = 89 - 58;
								num26 = 252;
								continue;
							case 226:
								array3[2] = (byte)num29;
								num26 = 124;
								if (PushManager())
								{
									continue;
								}
								goto IL_00d5;
							case 143:
								num29 = 242 - 80;
								num26 = 259;
								continue;
							case 105:
								array4[5] = (byte)num30;
								num26 = 20;
								if (PushManager())
								{
									continue;
								}
								goto IL_00d5;
							case 160:
								array3[30] = (byte)num28;
								num27 = 297;
								goto IL_00d5;
							case 86:
								array3[4] = (byte)num29;
								num26 = 265;
								continue;
							case 209:
								array4[0] = (byte)num31;
								num26 = 200;
								continue;
							case 67:
								array3[16] = 125;
								num26 = 290;
								continue;
							case 9:
								num31 = 89 - 49;
								num27 = 120;
								goto IL_00d5;
							case 126:
								array3[0] = (byte)num28;
								num26 = 230;
								continue;
							case 231:
								array3[7] = 4;
								num26 = 152;
								if (!PushManager())
								{
									num26 = 18;
								}
								continue;
							case 165:
								array3[3] = (byte)num28;
								num26 = 164;
								continue;
							case 146:
								num30 = 146 - 48;
								num26 = 58;
								continue;
							case 304:
								array4[8] = 119;
								num26 = 51;
								continue;
							case 185:
								num31 = 134 - 44;
								num26 = 181;
								continue;
							case 200:
								num30 = 6 + 98;
								num26 = 255;
								continue;
							case 172:
								array3[31] = (byte)num29;
								num26 = 315;
								continue;
							case 6:
								array3[3] = (byte)num29;
								num26 = 31;
								if (ReflectManager() != null)
								{
									num26 = 14;
								}
								continue;
							case 191:
								array4[14] = 112;
								num27 = 63;
								goto IL_00d5;
							case 245:
								array3[6] = (byte)num29;
								num26 = 121;
								if (PushManager())
								{
									continue;
								}
								goto IL_00d5;
							case 4:
								array3[30] = 114;
								num27 = 3;
								goto IL_00d5;
							case 195:
								array3[11] = 142;
								num26 = 277;
								continue;
							case 222:
								array4[12] = (byte)num30;
								num26 = 90;
								if (PushManager())
								{
									continue;
								}
								goto IL_00d5;
							case 156:
								array3[3] = (byte)num29;
								num26 = 251;
								continue;
							case 184:
								array3[7] = (byte)num29;
								num27 = 231;
								goto IL_00d5;
							case 276:
								array3[17] = 138;
								num26 = 101;
								continue;
							case 3:
								array3[30] = 99;
								num26 = 110;
								continue;
							case 187:
								array3[21] = (byte)num28;
								num27 = 15;
								goto IL_00d5;
							case 227:
								array3[7] = (byte)num29;
								num26 = 254;
								continue;
							case 7:
								array3[28] = (byte)num28;
								num26 = 249;
								continue;
							case 127:
								array4[10] = (byte)num30;
								num26 = 9;
								if (!PushManager())
								{
									num26 = 1;
								}
								continue;
							case 255:
								array4[1] = (byte)num30;
								num26 = 308;
								continue;
							case 92:
								array4[2] = (byte)num31;
								num27 = 161;
								goto IL_00d5;
							case 330:
								num28 = 215 + 0;
								num26 = 300;
								if (PushManager())
								{
									continue;
								}
								goto IL_00d5;
							case 147:
								array3[22] = (byte)num29;
								num26 = 28;
								if (PushManager())
								{
									num26 = 42;
								}
								continue;
							case 197:
								array3[21] = (byte)num29;
								num26 = 267;
								continue;
							case 144:
								num29 = 68 + 28;
								num27 = 86;
								goto IL_00d5;
							case 207:
								array3[27] = 60;
								num26 = 141;
								continue;
							case 212:
								num29 = 99 + 23;
								num26 = 166;
								if (!PushManager())
								{
									num26 = 20;
								}
								continue;
							case 260:
								array3[25] = 140;
								num26 = 271;
								continue;
							case 167:
								array3[6] = 54;
								num26 = 178;
								continue;
							case 52:
								array4[5] = 165;
								num26 = 84;
								continue;
							case 321:
								array5 = array3;
								num26 = 279;
								continue;
							case 262:
								array3[0] = 132;
								num26 = 117;
								continue;
							case 5:
								CallManager(cryptoStream);
								num26 = 13;
								continue;
							case 114:
								array4[8] = (byte)num30;
								num26 = 211;
								if (ReflectManager() == null)
								{
									num26 = 234;
								}
								continue;
							case 12:
								num30 = 22 + 52;
								num26 = 280;
								continue;
							case 89:
								array4[0] = 110;
								num26 = 39;
								if (PushManager())
								{
									continue;
								}
								goto IL_00d5;
							case 199:
								num29 = 8 + 85;
								num26 = 109;
								if (PushManager())
								{
									continue;
								}
								goto IL_00d5;
							case 254:
								num28 = 189 - 63;
								num26 = 328;
								continue;
							case 302:
								array3[18] = 158;
								num27 = 330;
								goto IL_00d5;
							case 34:
								break;
								IL_00d5:
								num26 = num27;
								continue;
							}
							break;
						}
					}
					catch
					{
						int num32 = 0;
						if (!PushManager())
						{
							num32 = 0;
						}
						while (true)
						{
							switch (num32)
							{
							default:
								flag2 = true;
								num32 = 1;
								if (!PushManager())
								{
									num32 = 0;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
					goto case 16;
				case 2:
					return;
				case 5:
					return;
				case 14:
					hashAlgorithm = null;
					num2 = 0;
					if (PushManager())
					{
						continue;
					}
					break;
				case 10:
					return;
				case 18:
					return;
				case 3:
					text2 = (string)DeleteManager(UpdateManager(typeof(WriterPropertyProducer).TypeHandle).Assembly);
					num2 = 9;
					if (PushManager())
					{
						continue;
					}
					break;
				case 4:
					_ConfigurationFacade = new RSACryptoServiceProvider();
					num2 = 3;
					continue;
				case 19:
					flag2 = false;
					num2 = 17;
					if (ReflectManager() != null)
					{
						num2 = 5;
					}
					continue;
				case 6:
					throw new Exception((string?)AwakeWorker(RestartWorker(PatchWorker(UpdateManager(typeof(WriterPropertyProducer).TypeHandle).Assembly)), " is tampered."));
				case 7:
					CancelManager();
					num2 = 15;
					continue;
				case 16:
					if (!flag2)
					{
						num2 = 12;
						continue;
					}
					goto case 13;
				case 11:
					if (_ConfigurationFacade != null)
					{
						num = 10;
						break;
					}
					goto case 7;
				case 12:
					try
					{
						FileStream fileStream = new FileStream(text2, FileMode.Open, FileAccess.Read, FileShare.Read);
						int num7 = 48;
						while (true)
						{
							int num15;
							switch (num7)
							{
							case 44:
								flag2 = !NewWorker(_ConfigurationFacade, StopWorker(hashAlgorithm), text, array2);
								num7 = 29;
								continue;
							case 40:
								array[32] = 0;
								num7 = 50;
								if (ReflectManager() != null)
								{
									num7 = 32;
								}
								continue;
							case 30:
								ConnectManager(hashAlgorithm, fileStream, (uint)(num13 * 40), array);
								num7 = 34;
								continue;
							case 48:
								binaryReader = new BinaryReader(fileStream);
								num7 = 13;
								continue;
							case 55:
								SortManager(fileStream, 152L);
								num7 = 73;
								continue;
							case 64:
								SortManager(fileStream, 376L);
								num7 = 19;
								if (ReflectManager() == null)
								{
									continue;
								}
								goto IL_3157;
							case 76:
								ConnectManager(hashAlgorithm, fileStream, 152u, array);
								num7 = 54;
								if (ReflectManager() == null)
								{
									continue;
								}
								goto IL_3157;
							case 14:
								num17 = FindManager(binaryReader);
								num7 = 70;
								continue;
							case 56:
								SortManager(fileStream, num20 + 32);
								num7 = 61;
								continue;
							case 39:
								array[38] = 0;
								num7 = 31;
								if (ReflectManager() == null)
								{
									continue;
								}
								goto IL_3157;
							case 47:
								AddManager(fileStream, array, 0, 128);
								num7 = 40;
								continue;
							case 15:
								CloneWorker(array2);
								num7 = 44;
								if (ReflectManager() != null)
								{
									num7 = 39;
								}
								continue;
							case 1:
							case 7:
							case 60:
								if (num17 != 0)
								{
									num7 = 25;
									if (PushManager())
									{
										continue;
									}
									goto IL_3157;
								}
								goto case 26;
							case 20:
								num17 -= num18;
								num7 = 7;
								continue;
							case 42:
								SortManager(fileStream, 360L);
								num7 = 21;
								continue;
							case 17:
								num14 = 0;
								num7 = 6;
								if (PushManager())
								{
									continue;
								}
								goto IL_3157;
							case 6:
							case 67:
								if (num14 < num13)
								{
									num7 = 65;
									continue;
								}
								goto case 69;
							case 9:
								CustomizeManager(hashAlgorithm, array, 0, num23);
								num7 = 47;
								if (ReflectManager() == null)
								{
									continue;
								}
								goto IL_3157;
							case 73:
								AddManager(fileStream, array, 0, num23);
								num7 = 10;
								if (ReflectManager() == null)
								{
									continue;
								}
								goto IL_3157;
							case 53:
								SortManager(fileStream, num16);
								num7 = 60;
								continue;
							case 8:
							case 68:
								num18 = (uint)ConcatWorker(num9 - num19, num17);
								num7 = 37;
								if (ReflectManager() == null)
								{
									continue;
								}
								goto IL_3157;
							case 72:
								SortManager(fileStream, 134L);
								num7 = 59;
								if (PushManager())
								{
									continue;
								}
								goto IL_3157;
							case 18:
								if (num9 > num19)
								{
									num7 = 71;
									continue;
								}
								goto case 38;
							case 43:
								num20 = RevertManager(max_reference2, num13, num12, binaryReader);
								num7 = 56;
								continue;
							case 61:
								max_reference = FindManager(binaryReader);
								num7 = 33;
								continue;
							case 19:
							case 21:
								max_reference2 = FindManager(binaryReader);
								num7 = 43;
								if (ReflectManager() != null)
								{
									num7 = 2;
								}
								continue;
							case 58:
								array[36] = 0;
								num7 = 52;
								if (ReflectManager() == null)
								{
									continue;
								}
								goto IL_3157;
							case 2:
							case 65:
								SortManager(fileStream, num12 + num14 * 40 + 16);
								num11 = 14;
								goto IL_3157;
							case 62:
								array[65] = 0;
								num7 = 5;
								continue;
							case 45:
								array2 = (byte[])IncludeWorker(binaryReader, (int)num8);
								num11 = 15;
								goto IL_3157;
							case 5:
								array[66] = 0;
								num7 = 11;
								if (ReflectManager() == null)
								{
									continue;
								}
								goto IL_3157;
							case 34:
								num22 = PostManager(fileStream);
								num11 = 4;
								goto IL_3157;
							case 24:
								num9 = RevertManager(max_reference, num13, num12, binaryReader);
								num7 = 16;
								continue;
							case 63:
								SortManager(fileStream, PostManager(fileStream) + num21);
								num7 = 1;
								if (PushManager())
								{
									continue;
								}
								goto IL_3157;
							case 23:
								SortManager(fileStream, num22);
								num7 = 17;
								continue;
							case 11:
								array[67] = 0;
								num7 = 9;
								if (PushManager())
								{
									continue;
								}
								goto IL_3157;
							case 4:
								if (flag)
								{
									num7 = 42;
									continue;
								}
								goto case 64;
							case 22:
								if (num21 >= num17)
								{
									num7 = 32;
									if (ReflectManager() != null)
									{
										num7 = 24;
									}
									continue;
								}
								goto case 46;
							case 46:
								num17 -= num21;
								num7 = 63;
								if (PushManager())
								{
									continue;
								}
								goto IL_3157;
							case 49:
								ConnectManager(hashAlgorithm, fileStream, num17, array);
								num7 = 26;
								continue;
							case 31:
								array[39] = 0;
								num7 = 3;
								if (!PushManager())
								{
									num7 = 2;
								}
								continue;
							case 3:
								CustomizeManager(hashAlgorithm, array, 0, 128);
								num7 = 1;
								if (PushManager())
								{
									num7 = 12;
								}
								continue;
							case 36:
								if (!flag)
								{
									num7 = 66;
									continue;
								}
								num15 = 96;
								break;
							case 69:
								CollectWorker(hashAlgorithm, new byte[0], 0, 0);
								num7 = 0;
								if (ReflectManager() == null)
								{
									continue;
								}
								goto IL_3157;
							case 51:
							case 71:
							case 74:
								if (num19 < num10)
								{
									num7 = 68;
									if (!PushManager())
									{
										num7 = 2;
									}
									continue;
								}
								goto case 49;
							case 25:
							case 41:
								num19 = PostManager(fileStream);
								num7 = 7;
								if (ReflectManager() == null)
								{
									num7 = 18;
								}
								continue;
							case 26:
							case 32:
							case 35:
								num14++;
								num7 = 67;
								continue;
							case 10:
								array[64] = 0;
								num7 = 62;
								continue;
							default:
								SortManager(fileStream, num9);
								num7 = 45;
								if (ReflectManager() != null)
								{
									num7 = 22;
								}
								continue;
							case 37:
								ConnectManager(hashAlgorithm, fileStream, num18, array);
								num7 = 20;
								if (ReflectManager() == null)
								{
									continue;
								}
								goto IL_3157;
							case 70:
								num16 = FindManager(binaryReader);
								num7 = 42;
								if (PushManager())
								{
									num7 = 53;
								}
								continue;
							case 54:
								flag = QueryManager(binaryReader) != 523;
								num7 = 17;
								if (PushManager())
								{
									num7 = 36;
								}
								continue;
							case 66:
								num15 = 112;
								break;
							case 13:
								array = new byte[65536];
								num7 = 76;
								continue;
							case 75:
								array[34] = 0;
								num7 = 57;
								continue;
							case 52:
								array[37] = 0;
								num7 = 39;
								continue;
							case 38:
								if (num19 >= num10)
								{
									num7 = 51;
									continue;
								}
								goto case 28;
							case 50:
								array[33] = 0;
								num7 = 75;
								if (!PushManager())
								{
									num7 = 72;
								}
								continue;
							case 59:
								num13 = QueryManager(binaryReader);
								num7 = 27;
								if (ReflectManager() == null)
								{
									continue;
								}
								goto IL_3157;
							case 57:
								array[35] = 0;
								num7 = 58;
								continue;
							case 12:
								num12 = PostManager(fileStream);
								num7 = 72;
								if (PushManager())
								{
									continue;
								}
								goto IL_3157;
							case 28:
								num21 = (uint)(num10 - num19);
								num7 = 22;
								continue;
							case 27:
								SortManager(fileStream, num12);
								num7 = 30;
								continue;
							case 16:
								num10 = num9 + num8;
								num11 = 23;
								goto IL_3157;
							case 33:
								num8 = FindManager(binaryReader);
								num7 = 24;
								continue;
							case 29:
								goto end_IL_315b;
								IL_3157:
								num7 = num11;
								continue;
							}
							num23 = num15;
							num7 = 55;
							continue;
							end_IL_315b:
							break;
						}
					}
					catch
					{
						int num24 = 0;
						if (!PushManager())
						{
							num24 = 0;
						}
						while (true)
						{
							switch (num24)
							{
							default:
								flag2 = true;
								num24 = 1;
								if (!PushManager())
								{
									num24 = num25;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
					goto case 13;
				case 8:
					try
					{
						hashAlgorithm = (HashAlgorithm)AssetManager();
						int num3 = 2;
						while (true)
						{
							IL_3a95:
							int num4 = num3;
							while (true)
							{
								switch (num4)
								{
								case 1:
									return;
								case 2:
									text = (string)FillManager("SHA1");
									num4 = 2;
									if (ReflectManager() == null)
									{
										num4 = 3;
									}
									continue;
								case 3:
									if (!ValidateManager(text2))
									{
										num4 = 1;
										if (ReflectManager() != null)
										{
											goto IL_3a95;
										}
										continue;
									}
									break;
								case 0:
									break;
								}
								break;
							}
							break;
						}
					}
					catch
					{
						int num5 = 0;
						if (!PushManager())
						{
							num5 = num6;
						}
						switch (num5)
						{
						case 0:
							break;
						}
						return;
					}
					goto case 19;
				default:
					text = null;
					num2 = 8;
					continue;
				case 15:
					MoveManager(true);
					num2 = 4;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void CalculateStub(RuntimeTypeHandle ident)
	{
		try
		{
			Type typeFromHandle = Type.GetTypeFromHandle(ident);
			if (parserFacade == null)
			{
				lock (m_ServiceFacade)
				{
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					BinaryReader binaryReader = new BinaryReader(Type.GetTypeFromHandle(ComposerWorkerStatus.DisableLiteralProc(33562134)).Assembly.GetManifestResourceStream("Value.Identifier"));
					binaryReader.BaseStream.Position = 0L;
					byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
					binaryReader.Close();
					if (array.Length > 0)
					{
						int num = array.Length % 4;
						int num2 = array.Length / 4;
						byte[] array2 = new byte[array.Length];
						uint num3 = 0u;
						uint num4 = 0u;
						if (num > 0)
						{
							num2++;
						}
						uint num5 = 0u;
						for (int i = 0; i < num2; i++)
						{
							int num6 = i * 4;
							uint num7 = 255u;
							int num8 = 0;
							if (i == num2 - 1 && num > 0)
							{
								num4 = 0u;
								for (int j = 0; j < num; j++)
								{
									if (j > 0)
									{
										num4 <<= 8;
									}
									num4 |= array[^(1 + j)];
								}
							}
							else
							{
								num5 = (uint)num6;
								num4 = (uint)((array[num5 + 3] << 24) | (array[num5 + 2] << 16) | (array[num5 + 1] << 8) | array[num5]);
							}
							num3 = num3;
							uint num9 = num3;
							uint num10 = num3;
							uint num11 = 500632071u;
							uint num12 = 85240303u;
							uint num13 = 253651623u;
							uint num14 = 482614650u;
							uint num15 = 269076556u;
							if ((double)num13 == 0.0)
							{
								num13--;
							}
							uint num16 = (uint)((double)num14 / (double)num13 + (double)num13);
							num13 = (uint)((int)(num14 + (short)num11) - (int)num16) + num14;
							if ((double)num12 == 0.0)
							{
								num12--;
							}
							uint num17 = (uint)(779224848.0 / (double)num12 + (double)num12);
							if ((ushort)num11 == 0)
							{
								num11--;
							}
							num12 = (uint)((double)((uint)((double)num14 / (double)(int)(ushort)num11) + num17) + (double)num14);
							if ((double)num11 == 0.0)
							{
								num11--;
							}
							uint num18 = (uint)(1244390521.0 / (double)num11 + (double)num11);
							num11 = (uint)(1174515042 + num18 + -15564);
							if ((double)num14 == 0.0)
							{
								num14--;
							}
							uint num19 = (uint)(1067555206.0 / (double)num14 + (double)num14);
							if (num13 == 0)
							{
								num13--;
							}
							num14 = (uint)((double)((uint)((double)num13 / (double)num13) + num19) + (double)num13);
							num15 = num13 ^ (num13 + num13);
							num10 ^= num10 >> 6;
							num10 += num11;
							num10 ^= num10 << 13;
							num10 += num14;
							num10 ^= num10 >> 5;
							num10 += num15;
							num10 = (((num12 << 13) + num14) ^ num11) - num10;
							num3 = num9 + (uint)(double)num10;
							if (i == num2 - 1 && num > 0)
							{
								uint num20 = num3 ^ num4;
								for (int k = 0; k < num; k++)
								{
									if (k > 0)
									{
										num7 <<= 8;
										num8 += 8;
									}
									array2[num6 + k] = (byte)((num20 & num7) >> num8);
								}
							}
							else
							{
								uint num21 = num3 ^ num4;
								array2[num6] = (byte)(num21 & 0xFFu);
								array2[num6 + 1] = (byte)((num21 & 0xFF00) >> 8);
								array2[num6 + 2] = (byte)((num21 & 0xFF0000) >> 16);
								array2[num6 + 3] = (byte)((num21 & 0xFF000000u) >> 24);
							}
						}
						array = array2;
						array2 = null;
						int num22 = array.Length / 8;
						StubAuthentication stubAuthentication = new StubAuthentication(new MemoryStream(array));
						for (int l = 0; l < num22; l++)
						{
							int key = stubAuthentication.RevertStub();
							int value = stubAuthentication.RevertStub();
							dictionary.Add(key, value);
						}
						stubAuthentication.CreateWrapper();
					}
					parserFacade = dictionary;
				}
			}
			FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
			foreach (FieldInfo fieldInfo in fields)
			{
				int metadataToken = fieldInfo.MetadataToken;
				int num23 = parserFacade[metadataToken];
				bool flag = (num23 & 0x40000000) > 0;
				num23 &= 0x3FFFFFFF;
				MethodInfo methodInfo = (MethodInfo)Type.GetTypeFromHandle(ComposerWorkerStatus.DisableLiteralProc(33562134)).Module.ResolveMethod(num23, typeFromHandle.GetGenericArguments(), new Type[0]);
				if (methodInfo.IsStatic)
				{
					fieldInfo.SetValue(null, Delegate.CreateDelegate(fieldInfo.FieldType, methodInfo));
					continue;
				}
				ParameterInfo[] parameters = methodInfo.GetParameters();
				int num24 = parameters.Length + 1;
				Type[] array3 = new Type[num24];
				if (methodInfo.DeclaringType!.IsValueType)
				{
					array3[0] = methodInfo.DeclaringType!.MakeByRefType();
				}
				else
				{
					array3[0] = Type.GetTypeFromHandle(ComposerWorkerStatus.DisableLiteralProc(16777233));
				}
				for (int n = 0; n < parameters.Length; n++)
				{
					array3[n + 1] = parameters[n].ParameterType;
				}
				DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, methodInfo.ReturnType, array3, typeFromHandle, skipVisibility: true);
				ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
				for (int num25 = 0; num25 < num24; num25++)
				{
					switch (num25)
					{
					case 0:
						iLGenerator.Emit(OpCodes.Ldarg_0);
						break;
					case 1:
						iLGenerator.Emit(OpCodes.Ldarg_1);
						break;
					case 2:
						iLGenerator.Emit(OpCodes.Ldarg_2);
						break;
					case 3:
						iLGenerator.Emit(OpCodes.Ldarg_3);
						break;
					default:
						iLGenerator.Emit(OpCodes.Ldarg_S, num25);
						break;
					}
				}
				iLGenerator.Emit(OpCodes.Tailcall);
				iLGenerator.Emit(flag ? OpCodes.Callvirt : OpCodes.Call, methodInfo);
				iLGenerator.Emit(OpCodes.Ret);
				fieldInfo.SetValue(null, dynamicMethod.CreateDelegate(typeFromHandle));
			}
		}
		catch (Exception)
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindStub()
	{
		if (Debugger.IsAttached)
		{
			throw new Exception("Debugger Detected");
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[TestsFacade(typeof(TestsFacade.GetterFacade<object>[]))]
	internal static string CustomizeStub(int ihigh)
	{
		//Discarded unreachable code: IL_0e3d, IL_152e, IL_1555, IL_19c0, IL_19cf, IL_1aa3, IL_1ab2, IL_24f6, IL_2505, IL_2578, IL_2eab, IL_3488
		int num = 6;
		int num16 = default(int);
		byte[] array3 = default(byte[]);
		byte[] array5 = default(byte[]);
		int num17 = default(int);
		uint num22 = default(uint);
		uint num3 = default(uint);
		int num18 = default(int);
		byte[] array = default(byte[]);
		byte[] array7 = default(byte[]);
		int num24 = default(int);
		uint num25 = default(uint);
		int num21 = default(int);
		uint num23 = default(uint);
		int num27 = default(int);
		uint num20 = default(uint);
		byte[] array6 = default(byte[]);
		int num30 = default(int);
		SymmetricAlgorithm symmetricAlgorithm = default(SymmetricAlgorithm);
		StubAuthentication stubAuthentication = default(StubAuthentication);
		uint num19 = default(uint);
		int num15 = default(int);
		byte[] array2 = default(byte[]);
		int num29 = default(int);
		Stream stream = default(Stream);
		int num38 = default(int);
		byte[] array4 = default(byte[]);
		uint num31 = default(uint);
		uint num32 = default(uint);
		int num26 = default(int);
		int num37 = default(int);
		string result = default(string);
		int num28 = default(int);
		int num34 = default(int);
		int num36 = default(int);
		CryptoStream cryptoStream = default(CryptoStream);
		ICryptoTransform transform = default(ICryptoTransform);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 81:
					num16 = 170 + 71;
					num = 323;
					break;
				case 19:
					array3[23] = 161;
					num2 = 152;
					continue;
				case 34:
					array3[10] = (byte)num16;
					num = 70;
					break;
				case 37:
					array5[13] = (byte)num17;
					num = 192;
					break;
				case 115:
					array5[2] = (byte)num17;
					num2 = 284;
					continue;
				case 228:
					array5[11] = 73;
					num2 = 104;
					continue;
				case 137:
					array3[28] = (byte)num16;
					num2 = 10;
					if (CollectMethod() == null)
					{
						num2 = 167;
					}
					continue;
				case 152:
					array3[23] = 205;
					num2 = 397;
					if (CollectMethod() == null)
					{
						continue;
					}
					break;
				case 388:
					num22 = num3;
					num2 = 42;
					continue;
				case 324:
					array3[17] = 102;
					num2 = 240;
					continue;
				case 166:
					num18 = 0;
					num2 = 379;
					if (CollectMethod() == null)
					{
						continue;
					}
					break;
				case 258:
					array = (byte[])ResolveMethod(WriteMethod(m_ProducerFacade));
					num2 = 135;
					continue;
				case 168:
					array3[8] = 126;
					num2 = 419;
					if (ConcatMethod())
					{
						continue;
					}
					break;
				case 139:
					array3[11] = 132;
					num2 = 100;
					continue;
				case 398:
					num17 = 9 + 79;
					num2 = 73;
					continue;
				case 395:
					num16 = 108 + 118;
					num2 = 276;
					if (ConcatMethod())
					{
						continue;
					}
					break;
				case 173:
					array7[num24] = (byte)(num25 & 0xFFu);
					num2 = 281;
					continue;
				case 65:
					array3[9] = 68;
					num2 = 130;
					if (CollectMethod() == null)
					{
						continue;
					}
					break;
				case 239:
					array3[25] = (byte)num16;
					num2 = 230;
					continue;
				case 268:
					num16 = 51 + 109;
					num2 = 223;
					if (CollectMethod() == null)
					{
						continue;
					}
					break;
				case 331:
					array3 = new byte[32];
					num2 = 96;
					continue;
				case 323:
					array3[18] = (byte)num16;
					num2 = 365;
					continue;
				case 272:
					array3[29] = (byte)num16;
					num2 = 410;
					if (ConcatMethod())
					{
						continue;
					}
					break;
				case 129:
				case 275:
					num21++;
					num2 = 377;
					continue;
				case 112:
					num16 = 147 - 49;
					num2 = 62;
					continue;
				case 229:
					array5[2] = 115;
					num = 185;
					break;
				case 26:
					num22 += num23;
					num2 = 166;
					continue;
				case 172:
					num17 = 5 + 69;
					num2 = 94;
					if (CollectMethod() == null)
					{
						continue;
					}
					break;
				case 336:
					num16 = 76 + 51;
					num2 = 22;
					continue;
				case 116:
					array3[27] = 80;
					num2 = 179;
					continue;
				case 307:
					array5[7] = 146;
					num2 = 310;
					continue;
				case 14:
				case 379:
					if (num18 >= num27)
					{
						num2 = 158;
						if (CollectMethod() != null)
						{
							num2 = 94;
						}
						continue;
					}
					goto case 353;
				case 111:
					num20 |= array6[^(1 + num18)];
					num2 = 396;
					if (CollectMethod() == null)
					{
						continue;
					}
					break;
				case 291:
					if (num27 > 0)
					{
						num2 = 201;
						continue;
					}
					goto case 238;
				case 280:
					num16 = 232 - 77;
					num2 = 320;
					continue;
				case 169:
					num16 = 22 + 10;
					num = 250;
					break;
				case 93:
					num30 += 8;
					num2 = 286;
					if (!ConcatMethod())
					{
						num2 = 58;
					}
					continue;
				case 62:
					array3[19] = (byte)num16;
					num2 = 370;
					continue;
				case 267:
					array3[3] = (byte)num16;
					num2 = 342;
					continue;
				case 225:
					symmetricAlgorithm = (SymmetricAlgorithm)SetupMethod();
					num2 = 163;
					continue;
				case 305:
					array3[11] = (byte)num16;
					num2 = 77;
					if (ConcatMethod())
					{
						continue;
					}
					break;
				case 123:
					array3[0] = (byte)num16;
					num2 = 90;
					if (CollectMethod() == null)
					{
						num2 = 171;
					}
					continue;
				case 326:
					array5[4] = 204;
					num = 242;
					break;
				case 332:
					num16 = 44 + 80;
					num2 = 210;
					if (ConcatMethod())
					{
						continue;
					}
					break;
				case 281:
					array7[num24 + 1] = (byte)((num25 & 0xFF00) >> 8);
					num2 = 325;
					continue;
				case 76:
					array3[28] = (byte)num16;
					num2 = 53;
					continue;
				case 105:
					array3[30] = (byte)num16;
					num2 = 222;
					continue;
				case 232:
					num30 = 0;
					num2 = 292;
					if (ConcatMethod())
					{
						continue;
					}
					break;
				case 353:
					if (num18 > 0)
					{
						num2 = 394;
						if (CollectMethod() == null)
						{
							continue;
						}
						break;
					}
					goto case 111;
				case 253:
					num22 = 0u;
					num2 = 184;
					continue;
				case 40:
					array6 = (byte[])PatchMethod(stubAuthentication, (int)NewMethod(CloneMethod(stubAuthentication)));
					num2 = 121;
					continue;
				case 121:
					RestartMethod(stubAuthentication);
					num2 = 331;
					if (!ConcatMethod())
					{
						num2 = 41;
					}
					continue;
				case 238:
					num19 = 0u;
					num2 = 147;
					if (CollectMethod() == null)
					{
						continue;
					}
					break;
				case 401:
					num16 = 68 + 85;
					num2 = 315;
					continue;
				case 11:
					num17 = 40 + 47;
					num2 = 246;
					continue;
				case 370:
					array3[19] = 171;
					num2 = 317;
					if (CollectMethod() == null)
					{
						continue;
					}
					break;
				case 189:
					array3[18] = (byte)num16;
					num2 = 270;
					if (ConcatMethod())
					{
						continue;
					}
					break;
				case 273:
					array3[13] = (byte)num16;
					num2 = 7;
					continue;
				case 195:
					array3[15] = (byte)num16;
					num2 = 15;
					if (ConcatMethod())
					{
						continue;
					}
					break;
				case 127:
					array3[16] = 150;
					num2 = 212;
					if (!ConcatMethod())
					{
						num2 = 132;
					}
					continue;
				case 298:
					array3[15] = 87;
					num2 = 8;
					continue;
				case 79:
					array3[10] = (byte)num16;
					num2 = 149;
					if (CollectMethod() != null)
					{
						num2 = 47;
					}
					continue;
				case 78:
					array5[11] = (byte)num17;
					num2 = 59;
					continue;
				case 352:
					array3[21] = (byte)num16;
					num2 = 385;
					continue;
				case 340:
					num17 = 68 + 115;
					num2 = 18;
					if (CollectMethod() == null)
					{
						num2 = 54;
					}
					continue;
				case 409:
					return "";
				case 236:
					array5[6] = (byte)num17;
					num2 = 283;
					if (!ConcatMethod())
					{
						num2 = 88;
					}
					continue;
				case 145:
					num17 = 183 - 61;
					num2 = 120;
					continue;
				case 159:
					array5[10] = 166;
					num2 = 297;
					continue;
				case 251:
					array5[8] = (byte)num17;
					num2 = 340;
					if (CollectMethod() == null)
					{
						continue;
					}
					break;
				case 210:
					array3[7] = (byte)num16;
					num2 = 117;
					if (ConcatMethod())
					{
						continue;
					}
					break;
				case 87:
					array3[17] = (byte)num16;
					num2 = 308;
					continue;
				case 397:
					array3[24] = 112;
					num2 = 33;
					if (ConcatMethod())
					{
						continue;
					}
					break;
				case 118:
					array3[4] = (byte)num16;
					num = 293;
					break;
				case 30:
				case 68:
					if (num15 >= array2.Length)
					{
						num2 = 290;
						continue;
					}
					goto case 244;
				case 94:
					array5[10] = (byte)num17;
					num = 31;
					break;
				case 13:
					array3[23] = 147;
					num2 = 336;
					continue;
				case 10:
					array3[6] = (byte)num16;
					num2 = 321;
					if (CollectMethod() == null)
					{
						continue;
					}
					break;
				case 144:
					array2[11] = array[5];
					num2 = 66;
					if (ConcatMethod())
					{
						continue;
					}
					break;
				case 4:
					num16 = 2 + 99;
					num = 341;
					break;
				case 113:
					array5[0] = 103;
					num2 = 101;
					continue;
				case 88:
					array5[10] = 117;
					num2 = 159;
					continue;
				case 314:
					array3[0] = (byte)num16;
					num2 = 386;
					if (CollectMethod() != null)
					{
						num2 = 69;
					}
					continue;
				case 75:
					array5[13] = (byte)num17;
					num2 = 348;
					if (!ConcatMethod())
					{
						num2 = 292;
					}
					continue;
				case 42:
					if (num21 == num29 - 1)
					{
						num2 = 32;
						continue;
					}
					goto case 351;
				case 155:
					m_RepositoryFacade = RateMethod(stream);
					num2 = 109;
					if (CollectMethod() == null)
					{
						continue;
					}
					break;
				case 183:
					array5 = new byte[16];
					num2 = 131;
					if (ConcatMethod())
					{
						num2 = 145;
					}
					continue;
				case 417:
					array3[14] = (byte)num16;
					num2 = 160;
					if (CollectMethod() == null)
					{
						continue;
					}
					break;
				case 85:
					num17 = 225 - 75;
					num2 = 204;
					if (CollectMethod() == null)
					{
						continue;
					}
					break;
				case 420:
					array5[3] = 86;
					num2 = 295;
					continue;
				case 101:
					num17 = 89 + 27;
					num2 = 288;
					continue;
				case 390:
					array3[20] = (byte)num16;
					num2 = 373;
					continue;
				case 348:
					num17 = 98 + 124;
					num2 = 29;
					if (ConcatMethod())
					{
						num2 = 37;
					}
					continue;
				case 21:
					num38 = array4.Length / 4;
					num2 = 53;
					if (CollectMethod() == null)
					{
						num2 = 178;
					}
					continue;
				case 205:
					array3[31] = (byte)num16;
					num2 = 231;
					if (ConcatMethod())
					{
						continue;
					}
					break;
				case 208:
					array2[3] = array[1];
					num2 = 227;
					continue;
				case 300:
					array3[27] = (byte)num16;
					num2 = 122;
					continue;
				case 386:
					array3[0] = 136;
					num2 = 322;
					if (CollectMethod() == null)
					{
						continue;
					}
					break;
				case 50:
					array3[6] = (byte)num16;
					num2 = 93;
					if (CollectMethod() == null)
					{
						num2 = 206;
					}
					continue;
				case 57:
				case 177:
					num15 = 0;
					num2 = 30;
					continue;
				case 367:
					num31 = num22 ^ num20;
					num2 = 36;
					continue;
				case 295:
					array5[3] = 164;
					num2 = 83;
					continue;
				case 412:
					num16 = 218 - 72;
					num2 = 28;
					if (ConcatMethod())
					{
						num2 = 34;
					}
					continue;
				case 421:
					StopMethod(CloneMethod(stubAuthentication), 0L);
					num2 = 40;
					if (ConcatMethod())
					{
						continue;
					}
					break;
				case 170:
					array3[21] = 98;
					num2 = 110;
					if (!ConcatMethod())
					{
						num2 = 19;
					}
					continue;
				case 167:
					array3[29] = 236;
					num2 = 58;
					continue;
				case 399:
					num32 = 255u;
					num2 = 232;
					continue;
				case 255:
					array3[25] = (byte)num16;
					num2 = 254;
					continue;
				case 32:
					if (num27 > 0)
					{
						num2 = 367;
						if (CollectMethod() == null)
						{
							continue;
						}
						break;
					}
					goto case 351;
				case 308:
					num16 = 111 + 28;
					num2 = 404;
					continue;
				case 133:
					num29 = array6.Length / 4;
					num2 = 63;
					continue;
				case 20:
					array3[22] = (byte)num16;
					num2 = 215;
					continue;
				case 86:
					num17 = 165 + 46;
					num = 236;
					break;
				case 247:
					array3[12] = (byte)num16;
					num2 = 89;
					continue;
				case 373:
					num16 = 95 + 14;
					num2 = 140;
					continue;
				case 140:
					array3[20] = (byte)num16;
					num2 = 148;
					continue;
				case 213:
					array5[11] = (byte)num17;
					num = 299;
					break;
				case 69:
					num16 = 239 - 79;
					num = 333;
					break;
				case 39:
					array5[3] = (byte)num17;
					num2 = 11;
					if (CollectMethod() == null)
					{
						continue;
					}
					break;
				case 186:
					array3[4] = (byte)num16;
					num2 = 401;
					continue;
				case 143:
					array5[14] = 156;
					num2 = 23;
					if (ConcatMethod())
					{
						num2 = 45;
					}
					continue;
				case 67:
					array3[9] = 194;
					num2 = 359;
					continue;
				case 96:
					num16 = 55 + 121;
					num2 = 314;
					continue;
				case 43:
					num17 = 110 + 17;
					num2 = 115;
					continue;
				case 199:
					array3[3] = (byte)num16;
					num2 = 363;
					continue;
				case 73:
					array5[6] = (byte)num17;
					num2 = 348;
					if (CollectMethod() == null)
					{
						num2 = 364;
					}
					continue;
				case 297:
					array5[10] = 34;
					num2 = 80;
					continue;
				case 266:
					array3[28] = 105;
					num2 = 238;
					if (CollectMethod() == null)
					{
						num2 = 391;
					}
					continue;
				case 224:
					array3[8] = (byte)num16;
					num2 = 168;
					continue;
				case 212:
					array3[16] = 66;
					num2 = 264;
					continue;
				case 120:
					array5[0] = (byte)num17;
					num2 = 113;
					continue;
				case 277:
					array5[12] = (byte)num17;
					num2 = 92;
					continue;
				case 134:
					array5[12] = (byte)num17;
					num2 = 294;
					if (ConcatMethod())
					{
						continue;
					}
					break;
				case 110:
					num16 = 165 - 55;
					num2 = 352;
					if (!ConcatMethod())
					{
						num2 = 164;
					}
					continue;
				case 301:
					num17 = 153 - 51;
					num2 = 41;
					if (ConcatMethod())
					{
						num2 = 75;
					}
					continue;
				case 279:
					array3[0] = (byte)num16;
					num = 156;
					break;
				case 27:
					array3[19] = (byte)num16;
					num2 = 169;
					if (CollectMethod() != null)
					{
						num2 = 158;
					}
					continue;
				case 70:
					num16 = 181 - 60;
					num2 = 338;
					continue;
				case 196:
					num26++;
					num2 = 241;
					if (CollectMethod() == null)
					{
						continue;
					}
					break;
				case 358:
					array3[22] = 109;
					num = 175;
					break;
				case 217:
					num32 <<= 8;
					num2 = 93;
					continue;
				case 293:
					array3[5] = 68;
					num2 = 132;
					continue;
				case 197:
					num16 = 65 + 3;
					num2 = 220;
					continue;
				case 131:
					array3[30] = (byte)num16;
					num2 = 162;
					if (CollectMethod() == null)
					{
						continue;
					}
					break;
				case 335:
					array5[1] = 113;
					num2 = 411;
					continue;
				case 80:
					num17 = 186 - 62;
					num2 = 312;
					continue;
				case 58:
					num16 = 43 + 68;
					num2 = 272;
					if (ConcatMethod())
					{
						continue;
					}
					break;
				case 415:
					num37 = num21 % num38;
					num2 = 392;
					if (CollectMethod() == null)
					{
						continue;
					}
					break;
				case 242:
					array5[5] = 140;
					num = 389;
					break;
				case 405:
					array5[9] = 121;
					num2 = 200;
					if (ConcatMethod())
					{
						continue;
					}
					break;
				case 362:
					array3[29] = 232;
					num2 = 418;
					if (ConcatMethod())
					{
						continue;
					}
					break;
				case 142:
					array3[13] = (byte)num16;
					num2 = 245;
					continue;
				case 56:
					num16 = 140 - 46;
					num2 = 23;
					continue;
				case 102:
					num19 = (uint)(num37 * 4);
					num = 328;
					break;
				case 114:
					array5[13] = (byte)num17;
					num2 = 21;
					if (CollectMethod() == null)
					{
						num2 = 72;
					}
					continue;
				case 164:
					array5[1] = 174;
					num2 = 3;
					continue;
				case 285:
					try
					{
						InstantiateMethod();
						int num33 = 0;
						if (!ConcatMethod())
						{
							goto IL_194d;
						}
						goto IL_1951;
						IL_1951:
						do
						{
							switch (num33)
							{
							case 1:
								return result;
							}
							result = (string)OrderMethod(InterruptMethod(), m_RepositoryFacade, ihigh + 4, num28);
							num33 = 1;
						}
						while (CollectMethod() == null);
						goto IL_194d;
						IL_194d:
						num33 = num34;
						goto IL_1951;
					}
					catch
					{
						int num35 = 0;
						if (!ConcatMethod())
						{
							num35 = num36;
						}
						switch (num35)
						{
						case 0:
							break;
						}
					}
					goto case 409;
				case 419:
					array3[8] = 107;
					num2 = 271;
					continue;
				case 317:
					array3[20] = 148;
					num2 = 280;
					if (CollectMethod() == null)
					{
						continue;
					}
					break;
				case 174:
					array3[3] = 192;
					num2 = 46;
					continue;
				case 289:
					num16 = 90 + 68;
					num2 = 329;
					continue;
				case 264:
					array3[17] = 135;
					num2 = 324;
					if (CollectMethod() == null)
					{
						continue;
					}
					break;
				case 410:
					num16 = 15 + 6;
					num2 = 414;
					continue;
				case 160:
					array3[15] = 168;
					num2 = 165;
					continue;
				case 201:
					num29++;
					num2 = 238;
					if (CollectMethod() == null)
					{
						continue;
					}
					break;
				case 66:
					array2[13] = array[6];
					num2 = 99;
					if (CollectMethod() == null)
					{
						continue;
					}
					break;
				case 49:
					array3[20] = (byte)num16;
					num2 = 170;
					continue;
				case 240:
					num16 = 227 - 75;
					num2 = 87;
					continue;
				case 176:
					array3[1] = (byte)num16;
					num2 = 190;
					if (CollectMethod() == null)
					{
						continue;
					}
					break;
				case 403:
					array5[5] = 114;
					num = 249;
					break;
				case 214:
					array3[8] = (byte)num16;
					num2 = 181;
					continue;
				case 22:
					array3[23] = (byte)num16;
					num2 = 19;
					if (CollectMethod() == null)
					{
						continue;
					}
					break;
				case 406:
					stream = (Stream)ChangeMethod();
					num2 = 256;
					if (ConcatMethod())
					{
						continue;
					}
					break;
				case 270:
					num16 = 154 - 51;
					num2 = 124;
					continue;
				case 83:
					array5[4] = 52;
					num = 198;
					break;
				case 294:
					num17 = 36 + 50;
					num2 = 28;
					continue;
				case 385:
					array3[21] = 185;
					num2 = 416;
					if (CollectMethod() == null)
					{
						continue;
					}
					break;
				case 376:
					array5[9] = 15;
					num2 = 172;
					continue;
				case 18:
					array3[13] = (byte)num16;
					num2 = 380;
					continue;
				case 322:
					num16 = 153 - 51;
					num2 = 123;
					if (CollectMethod() != null)
					{
						num2 = 105;
					}
					continue;
				case 259:
					array3[12] = (byte)num16;
					num2 = 203;
					continue;
				case 271:
					array3[9] = 162;
					num2 = 4;
					if (ConcatMethod())
					{
						continue;
					}
					break;
				case 345:
					array5[15] = 129;
					num2 = 260;
					continue;
				case 382:
					array3[26] = (byte)num16;
					num2 = 116;
					continue;
				case 215:
					array3[22] = 129;
					num2 = 358;
					if (CollectMethod() == null)
					{
						continue;
					}
					break;
				case 1:
					array6 = (byte[])m_RepositoryFacade;
					num2 = 233;
					continue;
				case 187:
					num17 = 85 + 65;
					num2 = 78;
					if (!ConcatMethod())
					{
						num2 = 26;
					}
					continue;
				case 222:
					array3[30] = 120;
					num = 265;
					break;
				case 418:
					num16 = 94 + 6;
					num = 188;
					break;
				case 209:
					num16 = 124 + 29;
					num2 = 157;
					continue;
				case 235:
					array5[7] = (byte)num17;
					num2 = 307;
					continue;
				case 288:
					array5[0] = (byte)num17;
					num2 = 296;
					continue;
				case 31:
					array5[10] = 100;
					num = 88;
					break;
				case 91:
					num16 = 134 - 44;
					num2 = 214;
					continue;
				case 161:
					array2 = array5;
					num2 = 219;
					if (ConcatMethod())
					{
						continue;
					}
					break;
				case 192:
					num17 = 37 - 28;
					num2 = 114;
					if (!ConcatMethod())
					{
						num2 = 36;
					}
					continue;
				case 320:
					array3[20] = (byte)num16;
					num2 = 319;
					continue;
				case 150:
					m_RepositoryFacade = array7;
					num2 = 313;
					if (ConcatMethod())
					{
						continue;
					}
					break;
				case 103:
					array5[1] = (byte)num17;
					num2 = 408;
					if (ConcatMethod())
					{
						continue;
					}
					break;
				case 182:
					num19 = (uint)num24;
					num2 = 368;
					continue;
				case 257:
					num16 = 177 + 66;
					num2 = 221;
					continue;
				case 61:
					stubAuthentication = new StubAuthentication((Stream)IncludeMethod(m_ProducerFacade, "Method.Manager"));
					num2 = 421;
					if (!ConcatMethod())
					{
						num2 = 404;
					}
					continue;
				case 243:
					if (num27 > 0)
					{
						num2 = 107;
						if (CollectMethod() == null)
						{
							continue;
						}
						break;
					}
					goto case 191;
				case 347:
					num16 = 162 - 54;
					num2 = 387;
					continue;
				case 179:
					array3[27] = 99;
					num2 = 64;
					continue;
				case 203:
					num16 = 249 - 83;
					num2 = 90;
					continue;
				case 245:
					array3[14] = 208;
					num2 = 0;
					if (ConcatMethod())
					{
						continue;
					}
					break;
				case 237:
					array3[11] = 150;
					num2 = 139;
					continue;
				case 153:
					array5[6] = (byte)num17;
					num2 = 262;
					if (ConcatMethod())
					{
						num2 = 343;
					}
					continue;
				case 321:
					num16 = 64 + 82;
					num2 = 50;
					continue;
				case 413:
					num16 = 195 - 65;
					num2 = 79;
					if (CollectMethod() == null)
					{
						continue;
					}
					break;
				case 41:
					array3[7] = (byte)num16;
					num2 = 56;
					continue;
				case 354:
					array3[22] = (byte)num16;
					num = 13;
					break;
				case 226:
					num17 = 152 - 50;
					num2 = 251;
					if (ConcatMethod())
					{
						continue;
					}
					break;
				case 223:
					array3[31] = (byte)num16;
					num2 = 52;
					continue;
				case 404:
					array3[17] = (byte)num16;
					num2 = 374;
					if (ConcatMethod())
					{
						continue;
					}
					break;
				case 104:
					num17 = 122 + 121;
					num2 = 134;
					continue;
				case 193:
					array5[14] = (byte)num17;
					num2 = 71;
					continue;
				case 44:
					num17 = 123 + 43;
					num2 = 213;
					continue;
				case 350:
					num16 = 79 + 26;
					num2 = 9;
					continue;
				case 48:
					array3[2] = (byte)num16;
					num2 = 174;
					continue;
				case 244:
					array4[num15] = (byte)(array4[num15] ^ array2[num15]);
					num2 = 216;
					continue;
				case 45:
					num17 = 82 + 28;
					num2 = 193;
					if (CollectMethod() == null)
					{
						continue;
					}
					break;
				case 365:
					num16 = 168 - 56;
					num2 = 27;
					continue;
				case 333:
					array3[30] = (byte)num16;
					num2 = 309;
					continue;
				case 135:
					if (array == null)
					{
						num2 = 57;
						continue;
					}
					goto case 302;
				case 130:
					num16 = 152 - 50;
					num2 = 371;
					if (CollectMethod() != null)
					{
						num2 = 175;
					}
					continue;
				case 89:
					num16 = 139 - 46;
					num2 = 273;
					continue;
				case 156:
					array3[1] = 151;
					num2 = 357;
					if (CollectMethod() != null)
					{
						num2 = 330;
					}
					continue;
				case 319:
					num16 = 24 + 55;
					num2 = 390;
					continue;
				case 2:
					array5[2] = (byte)num17;
					num2 = 229;
					if (CollectMethod() != null)
					{
						num2 = 92;
					}
					continue;
				case 422:
					ManageMethod(cryptoStream);
					num = 155;
					break;
				case 378:
					array5[15] = 30;
					num2 = 161;
					if (ConcatMethod())
					{
						continue;
					}
					break;
				case 204:
					array5[13] = (byte)num17;
					num2 = 355;
					continue;
				case 233:
					num27 = array6.Length % 4;
					num2 = 133;
					if (CollectMethod() == null)
					{
						continue;
					}
					break;
				case 8:
					num16 = 123 + 31;
					num2 = 95;
					if (ConcatMethod())
					{
						num2 = 195;
					}
					continue;
				case 355:
					array5[13] = 103;
					num = 301;
					break;
				case 311:
					array5[6] = (byte)num17;
					num2 = 372;
					if (CollectMethod() == null)
					{
						continue;
					}
					break;
				case 287:
					num16 = 212 + 5;
					num2 = 382;
					continue;
				case 375:
					num16 = 151 - 50;
					num2 = 41;
					continue;
				case 328:
					num23 = (uint)((array4[num19 + 3] << 24) | (array4[num19 + 2] << 16) | (array4[num19 + 1] << 8) | array4[num19]);
					num2 = 399;
					continue;
				case 90:
					array3[12] = (byte)num16;
					num2 = 407;
					continue;
				case 16:
					array5[15] = (byte)num17;
					num2 = 378;
					continue;
				case 283:
					array5[7] = 123;
					num2 = 234;
					continue;
				case 344:
					num17 = 242 - 80;
					num2 = 277;
					continue;
				case 303:
					num16 = 193 - 64;
					num2 = 300;
					continue;
				case 108:
					num16 = 154 + 46;
					num2 = 176;
					if (CollectMethod() == null)
					{
						continue;
					}
					break;
				case 356:
					InsertMethod(cryptoStream, array6, 0, array6.Length);
					num2 = 422;
					continue;
				case 107:
					num20 = 0u;
					num2 = 26;
					if (ConcatMethod())
					{
						continue;
					}
					break;
				case 408:
					array5[2] = 164;
					num2 = 25;
					continue;
				case 149:
					num16 = 190 - 63;
					num2 = 12;
					continue;
				case 343:
					array5[6] = 148;
					num2 = 86;
					continue;
				case 71:
					num17 = 35 + 120;
					num2 = 366;
					continue;
				case 17:
					transform = (ICryptoTransform)ComputeMethod(symmetricAlgorithm, array4, array2);
					num2 = 406;
					continue;
				case 151:
					array3[17] = 8;
					num2 = 316;
					if (ConcatMethod())
					{
						continue;
					}
					break;
				case 221:
					array3[10] = (byte)num16;
					num2 = 237;
					continue;
				case 263:
					array5[14] = (byte)num17;
					num2 = 345;
					if (CollectMethod() == null)
					{
						continue;
					}
					break;
				case 360:
					num16 = 37 - 11;
					num2 = 354;
					continue;
				case 74:
					array3[25] = 170;
					num = 97;
					break;
				case 185:
					array5[3] = 117;
					num2 = 282;
					if (CollectMethod() == null)
					{
						continue;
					}
					break;
				case 188:
					array3[30] = (byte)num16;
					num2 = 69;
					if (!ConcatMethod())
					{
						num2 = 6;
					}
					continue;
				case 6:
					if (((Array)m_RepositoryFacade).Length != 0)
					{
						num2 = 5;
						continue;
					}
					goto case 61;
				case 125:
					array5[12] = (byte)num17;
					num2 = 141;
					continue;
				case 46:
					array3[3] = 135;
					num2 = 330;
					continue;
				case 55:
					array5[6] = 166;
					num2 = 398;
					continue;
				case 256:
					cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write);
					num2 = 356;
					if (CollectMethod() == null)
					{
						continue;
					}
					break;
				case 180:
					if (num26 > 0)
					{
						num2 = 217;
						continue;
					}
					goto case 286;
				case 278:
					array2[1] = array[0];
					num2 = 208;
					if (ConcatMethod())
					{
						continue;
					}
					break;
				case 124:
					array3[18] = (byte)num16;
					num2 = 318;
					continue;
				case 52:
					num16 = 199 - 79;
					num2 = 205;
					continue;
				case 47:
					array3[2] = 106;
					num2 = 128;
					if (ConcatMethod())
					{
						continue;
					}
					break;
				case 7:
					num16 = 193 - 64;
					num2 = 18;
					if (CollectMethod() == null)
					{
						continue;
					}
					break;
				case 36:
					num26 = 0;
					num2 = 402;
					continue;
				case 292:
					if (num21 == num29 - 1)
					{
						num2 = 243;
						continue;
					}
					goto case 191;
				case 341:
					array3[9] = (byte)num16;
					num2 = 350;
					if (CollectMethod() != null)
					{
						num2 = 212;
					}
					continue;
				case 315:
					array3[4] = (byte)num16;
					num2 = 334;
					continue;
				case 246:
					array5[3] = (byte)num17;
					num2 = 420;
					continue;
				case 148:
					array3[20] = 161;
					num2 = 304;
					continue;
				case 231:
					array4 = array3;
					num2 = 183;
					continue;
				case 59:
					num17 = 10 + 114;
					num2 = 346;
					continue;
				case 77:
					num16 = 175 - 58;
					num2 = 259;
					continue;
				case 25:
					array5[2] = 203;
					num2 = 43;
					if (ConcatMethod())
					{
						continue;
					}
					break;
				case 136:
				case 158:
					num3 = num22;
					num2 = 253;
					if (CollectMethod() == null)
					{
						continue;
					}
					break;
				case 286:
					array7[num24 + num26] = (byte)((num31 & num32) >> num30);
					num2 = 196;
					continue;
				case 325:
					array7[num24 + 2] = (byte)((num25 & 0xFF0000) >> 16);
					num2 = 218;
					continue;
				case 3:
					num17 = 144 - 48;
					num = 269;
					break;
				case 312:
					array5[11] = (byte)num17;
					num2 = 187;
					if (CollectMethod() == null)
					{
						continue;
					}
					break;
				case 364:
					num17 = 191 - 63;
					num2 = 311;
					continue;
				case 363:
					num16 = 160 - 110;
					num2 = 267;
					continue;
				case 407:
					num16 = 159 - 36;
					num2 = 247;
					continue;
				case 250:
					array3[19] = (byte)num16;
					num2 = 112;
					if (ConcatMethod())
					{
						continue;
					}
					break;
				case 284:
					num17 = 47 + 68;
					num2 = 2;
					continue;
				case 33:
					num16 = 73 + 40;
					num = 381;
					break;
				case 391:
					num16 = 179 - 59;
					num2 = 76;
					if (CollectMethod() != null)
					{
						num2 = 21;
					}
					continue;
				case 342:
					num16 = 171 - 57;
					num2 = 186;
					continue;
				case 304:
					num16 = 45 + 94;
					num2 = 49;
					if (CollectMethod() == null)
					{
						continue;
					}
					break;
				case 249:
					num17 = 187 - 62;
					num2 = 252;
					continue;
				case 53:
					num16 = 24 - 13;
					num2 = 137;
					continue;
				case 9:
					array3[9] = (byte)num16;
					num = 67;
					break;
				case 248:
					ExcludeMethod(cryptoStream);
					num2 = 0;
					if (CollectMethod() == null)
					{
						num2 = 1;
					}
					continue;
				case 349:
					num16 = 111 + 90;
					num2 = 262;
					if (CollectMethod() != null)
					{
						num2 = 83;
					}
					continue;
				case 28:
					array5[12] = (byte)num17;
					num2 = 207;
					continue;
				case 98:
					array5[1] = 142;
					num2 = 274;
					if (ConcatMethod())
					{
						continue;
					}
					break;
				case 63:
					array7 = new byte[array6.Length];
					num2 = 21;
					if (!ConcatMethod())
					{
						num2 = 18;
					}
					continue;
				case 372:
					num17 = 189 - 63;
					num = 153;
					break;
				case 117:
					array3[7] = 132;
					num2 = 395;
					if (!ConcatMethod())
					{
						num2 = 219;
					}
					continue;
				case 339:
					num16 = 83 - 12;
					num2 = 131;
					continue;
				case 387:
					array3[29] = (byte)num16;
					num2 = 362;
					continue;
				case 219:
					AwakeMethod(array2);
					num = 258;
					break;
				case 329:
					array3[26] = (byte)num16;
					num2 = 400;
					if (ConcatMethod())
					{
						continue;
					}
					break;
				case 262:
					array3[29] = (byte)num16;
					num2 = 347;
					continue;
				case 171:
					num16 = 239 + 1;
					num2 = 279;
					continue;
				case 392:
					num24 = num21 * 4;
					num2 = 102;
					continue;
				case 206:
					array3[6] = 116;
					num2 = 375;
					continue;
				case 230:
					num16 = 50 + 15;
					num2 = 255;
					continue;
				case 138:
					array5[8] = 151;
					num = 226;
					break;
				case 290:
					if (ihigh == -1)
					{
						num2 = 204;
						if (ConcatMethod())
						{
							num2 = 225;
						}
						continue;
					}
					goto case 233;
				case 194:
					array5[5] = (byte)num17;
					num2 = 384;
					continue;
				case 154:
					array5[1] = (byte)num17;
					num2 = 335;
					continue;
				case 276:
					array3[8] = (byte)num16;
					num2 = 91;
					continue;
				case 414:
					array3[29] = (byte)num16;
					num2 = 349;
					continue;
				case 24:
					array5[11] = (byte)num17;
					num2 = 228;
					continue;
				case 119:
					array3[31] = (byte)num16;
					num2 = 268;
					continue;
				case 181:
					num16 = 108 + 63;
					num2 = 224;
					continue;
				case 260:
					num17 = 135 - 45;
					num2 = 6;
					if (CollectMethod() == null)
					{
						num2 = 16;
					}
					continue;
				case 141:
					array5[12] = 105;
					num2 = 4;
					if (CollectMethod() == null)
					{
						num2 = 344;
					}
					continue;
				case 35:
					array3[25] = (byte)num16;
					num2 = 289;
					if (ConcatMethod())
					{
						continue;
					}
					break;
				case 126:
					array2[7] = array[3];
					num = 51;
					break;
				case 318:
					array3[18] = 108;
					num2 = 81;
					if (ConcatMethod())
					{
						continue;
					}
					break;
				case 337:
					array3[6] = 93;
					num = 327;
					break;
				case 178:
					num22 = 0u;
					num2 = 95;
					if (ConcatMethod())
					{
						continue;
					}
					break;
				case 82:
					array3[24] = 117;
					num2 = 74;
					continue;
				case 64:
					num16 = 177 - 59;
					num2 = 29;
					if (ConcatMethod())
					{
						continue;
					}
					break;
				case 128:
					num16 = 46 + 88;
					num2 = 48;
					continue;
				case 200:
					array5[9] = 138;
					num2 = 376;
					if (!ConcatMethod())
					{
						num2 = 110;
					}
					continue;
				case 274:
					num17 = 247 - 82;
					num2 = 154;
					if (CollectMethod() != null)
					{
						num2 = 121;
					}
					continue;
				case 163:
					LogoutMethod(symmetricAlgorithm, CipherMode.CBC);
					num2 = 17;
					continue;
				case 374:
					array3[17] = 98;
					num2 = 151;
					if (ConcatMethod())
					{
						continue;
					}
					break;
				case 366:
					array5[14] = (byte)num17;
					num = 261;
					break;
				case 261:
					num17 = 53 + 75;
					num2 = 72;
					if (ConcatMethod())
					{
						num2 = 263;
					}
					continue;
				case 309:
					num16 = 6 + 50;
					num2 = 105;
					continue;
				case 106:
					array5[8] = 238;
					num2 = 146;
					if (CollectMethod() == null)
					{
						continue;
					}
					break;
				case 38:
				case 377:
					if (num21 >= num29)
					{
						num2 = 88;
						if (CollectMethod() == null)
						{
							num2 = 150;
						}
						continue;
					}
					goto case 415;
				case 254:
					num16 = 225 - 118;
					num2 = 35;
					if (ConcatMethod())
					{
						continue;
					}
					break;
				case 5:
				case 313:
					num28 = CreateMethod(m_RepositoryFacade, ihigh);
					num2 = 285;
					continue;
				case 384:
					array5[5] = 94;
					num2 = 403;
					continue;
				case 357:
					array3[1] = 103;
					num2 = 108;
					continue;
				case 306:
					array3[25] = (byte)num16;
					num2 = 211;
					if (CollectMethod() != null)
					{
						num2 = 204;
					}
					continue;
				case 351:
					num25 = num22 ^ num20;
					num2 = 173;
					continue;
				case 162:
					num16 = 88 + 10;
					num2 = 119;
					continue;
				case 29:
					array3[27] = (byte)num16;
					num2 = 303;
					continue;
				case 241:
				case 402:
					if (num26 >= num27)
					{
						num2 = 129;
						continue;
					}
					goto case 180;
				case 234:
					num17 = 153 - 51;
					num = 235;
					break;
				case 51:
					array2[9] = array[4];
					num2 = 144;
					if (!ConcatMethod())
					{
						num2 = 33;
					}
					continue;
				case 389:
					num17 = 8 + 25;
					num = 194;
					break;
				case 346:
					array5[11] = (byte)num17;
					num = 44;
					break;
				case 416:
					num16 = 202 - 67;
					num2 = 20;
					continue;
				case 380:
					num16 = 14 - 10;
					num2 = 142;
					continue;
				case 218:
					array7[num24 + 3] = (byte)((num25 & 0xFF000000u) >> 24);
					num2 = 275;
					if (CollectMethod() == null)
					{
						continue;
					}
					break;
				case 157:
					array3[5] = (byte)num16;
					num2 = 337;
					continue;
				case 296:
					num17 = 34 - 1;
					num2 = 84;
					continue;
				case 338:
					array3[10] = (byte)num16;
					num2 = 257;
					if (ConcatMethod())
					{
						continue;
					}
					break;
				case 252:
					array5[5] = (byte)num17;
					num2 = 361;
					continue;
				case 165:
					array3[15] = 36;
					num = 298;
					break;
				case 132:
					array3[5] = 112;
					num2 = 197;
					continue;
				case 394:
					num20 <<= 8;
					num2 = 111;
					continue;
				case 334:
					num16 = 105 + 48;
					num2 = 118;
					if (CollectMethod() == null)
					{
						continue;
					}
					break;
				case 371:
					array3[10] = (byte)num16;
					num2 = 413;
					continue;
				case 383:
					num20 = 0u;
					num2 = 291;
					continue;
				case 316:
					num16 = 64 + 16;
					num2 = 189;
					continue;
				case 393:
					array3[2] = (byte)num16;
					num2 = 47;
					continue;
				case 15:
					array3[16] = 169;
					num = 127;
					break;
				case 207:
					num17 = 139 - 46;
					num2 = 125;
					continue;
				case 216:
					num15++;
					num2 = 68;
					if (CollectMethod() != null)
					{
						num2 = 64;
					}
					continue;
				case 265:
					array3[30] = 52;
					num2 = 339;
					if (ConcatMethod())
					{
						continue;
					}
					break;
				case 411:
					num17 = 178 + 23;
					num2 = 103;
					if (CollectMethod() != null)
					{
						num2 = 20;
					}
					continue;
				case 400:
					array3[26] = 111;
					num2 = 60;
					continue;
				case 84:
					array5[0] = (byte)num17;
					num2 = 164;
					continue;
				default:
					array3[14] = 163;
					num2 = 202;
					continue;
				case 327:
					num16 = 39 + 59;
					num2 = 10;
					if (ConcatMethod())
					{
						continue;
					}
					break;
				case 282:
					num17 = 44 + 24;
					num2 = 37;
					if (ConcatMethod())
					{
						num2 = 39;
					}
					continue;
				case 60:
					array3[26] = 160;
					num2 = 287;
					continue;
				case 72:
					num17 = 147 - 49;
					num2 = 369;
					continue;
				case 95:
					num23 = 0u;
					num2 = 383;
					continue;
				case 269:
					array5[1] = (byte)num17;
					num2 = 98;
					if (ConcatMethod())
					{
						continue;
					}
					break;
				case 191:
					num22 += num23;
					num2 = 182;
					continue;
				case 100:
					num16 = 101 - 24;
					num2 = 305;
					continue;
				case 202:
					num16 = 27 + 118;
					num2 = 417;
					if (ConcatMethod())
					{
						continue;
					}
					break;
				case 369:
					array5[14] = (byte)num17;
					num2 = 143;
					if (ConcatMethod())
					{
						continue;
					}
					break;
				case 396:
					num18++;
					num2 = 8;
					if (CollectMethod() == null)
					{
						num2 = 14;
					}
					continue;
				case 220:
					array3[5] = (byte)num16;
					num2 = 209;
					continue;
				case 198:
					array5[4] = 98;
					num2 = 326;
					if (ConcatMethod())
					{
						continue;
					}
					break;
				case 299:
					num17 = 194 - 64;
					num2 = 24;
					continue;
				case 99:
					array2[15] = array[7];
					num2 = 52;
					if (ConcatMethod())
					{
						num2 = 177;
					}
					continue;
				case 23:
					array3[7] = (byte)num16;
					num2 = 332;
					continue;
				case 97:
					num16 = 196 - 65;
					num = 306;
					break;
				case 12:
					array3[10] = (byte)num16;
					num2 = 412;
					continue;
				case 330:
					num16 = 223 - 74;
					num2 = 199;
					if (CollectMethod() != null)
					{
						num2 = 167;
					}
					continue;
				case 146:
					array5[9] = 146;
					num2 = 405;
					if (ConcatMethod())
					{
						continue;
					}
					break;
				case 302:
					if (array.Length > 0)
					{
						num2 = 278;
						if (CollectMethod() != null)
						{
							num2 = 194;
						}
						continue;
					}
					goto case 57;
				case 310:
					array5[7] = 134;
					num2 = 138;
					continue;
				case 147:
					num21 = 0;
					num2 = 31;
					if (ConcatMethod())
					{
						num2 = 38;
					}
					continue;
				case 190:
					num16 = 219 - 73;
					num2 = 393;
					if (!ConcatMethod())
					{
						num2 = 198;
					}
					continue;
				case 211:
					num16 = 173 - 57;
					num2 = 239;
					if (!ConcatMethod())
					{
						num2 = 231;
					}
					continue;
				case 122:
					array3[27] = 103;
					num2 = 266;
					continue;
				case 54:
					array5[8] = (byte)num17;
					num2 = 106;
					continue;
				case 92:
					array5[12] = 129;
					num2 = 85;
					continue;
				case 359:
					array3[9] = 122;
					num2 = 65;
					continue;
				case 368:
					num20 = (uint)((array6[num19 + 3] << 24) | (array6[num19 + 2] << 16) | (array6[num19 + 1] << 8) | array6[num19]);
					num2 = 136;
					if (!ConcatMethod())
					{
						num2 = 122;
					}
					continue;
				case 361:
					array5[5] = 55;
					num2 = 55;
					continue;
				case 381:
					array3[24] = (byte)num16;
					num = 82;
					break;
				case 175:
					array3[22] = 152;
					num2 = 360;
					continue;
				case 227:
					array2[5] = array[2];
					num2 = 126;
					if (!ConcatMethod())
					{
						num2 = 9;
					}
					continue;
				case 109:
					ExcludeMethod(stream);
					num2 = 85;
					if (CollectMethod() == null)
					{
						num2 = 248;
					}
					continue;
				case 184:
				{
					uint num4 = num3;
					uint num5 = num3;
					uint num6 = 500632071u;
					uint num7 = 85240303u;
					uint num8 = 253651623u;
					uint num9 = 482614650u;
					uint num10 = 269076556u;
					if ((double)num8 == 0.0)
					{
						num8--;
					}
					uint num11 = (uint)((double)num9 / (double)num8 + (double)num8);
					num8 = (uint)((int)(num9 + (short)num6) - (int)num11) + num9;
					if ((double)num7 == 0.0)
					{
						num7--;
					}
					uint num12 = (uint)(779224848.0 / (double)num7 + (double)num7);
					if ((ushort)num6 == 0)
					{
						num6--;
					}
					num7 = (uint)((double)((uint)((double)num9 / (double)(int)(ushort)num6) + num12) + (double)num9);
					if ((double)num6 == 0.0)
					{
						num6--;
					}
					uint num13 = (uint)(1244390521.0 / (double)num6 + (double)num6);
					num6 = (uint)(1174515042 + num13 + -15564);
					if ((double)num9 == 0.0)
					{
						num9--;
					}
					uint num14 = (uint)(1067555206.0 / (double)num9 + (double)num9);
					if (num8 == 0)
					{
						num8--;
					}
					num9 = (uint)((double)((uint)((double)num8 / (double)num8) + num14) + (double)num8);
					num10 = num8 ^ (num8 + num8);
					num5 ^= num5 >> 6;
					num5 += num6;
					num5 ^= num5 << 13;
					num5 += num9;
					num5 ^= num5 >> 5;
					num5 += num10;
					num5 = (((num7 << 13) + num9) ^ num6) - num5;
					num3 = num4 + (uint)(double)num5;
					num2 = 388;
					continue;
				}
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[TestsFacade(typeof(TestsFacade.GetterFacade<object>[]))]
	internal static string ResetStub(object value)
	{
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String((string)value);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static uint ConnectStub(IntPtr config, IntPtr pred, IntPtr helper, [MarshalAs(UnmanagedType.U4)] uint selection2, IntPtr ident3, ref uint spec4)
	{
		IntPtr ptr = helper;
		if (schemaFacade)
		{
			ptr = pred;
		}
		long num = 0L;
		num = ((IntPtr.Size != 4) ? Marshal.ReadInt64(ptr, IntPtr.Size * 2) : Marshal.ReadInt32(ptr, IntPtr.Size * 2));
		object obj = ((Hashtable)m_DatabaseFacade)[(object)num];
		if (obj != null)
		{
			ExporterFacade exporterFacade = (ExporterFacade)obj;
			IntPtr intPtr = Marshal.AllocCoTaskMem(exporterFacade.m_ProcFacade.Length);
			Marshal.Copy(exporterFacade.m_ProcFacade, 0, intPtr, exporterFacade.m_ProcFacade.Length);
			if (exporterFacade.m_AttributeFacade)
			{
				ident3 = intPtr;
				spec4 = (uint)exporterFacade.m_ProcFacade.Length;
				ListStub(ident3, exporterFacade.m_ProcFacade.Length, 64, ref m_ParameterFacade);
				return 0u;
			}
			Marshal.WriteIntPtr(ptr, IntPtr.Size * 2, intPtr);
			Marshal.WriteInt32(ptr, IntPtr.Size * 3, exporterFacade.m_ProcFacade.Length);
			uint result = 0u;
			if (selection2 != 216669565 || managerFacade)
			{
				result = _StrategyFacade(config, pred, helper, selection2, ident3, ref spec4);
			}
			else
			{
				managerFacade = true;
			}
			return result;
		}
		return _StrategyFacade(config, pred, helper, selection2, ident3, ref spec4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static int UpdateStub()
	{
		return 5;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void MoveStub()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Delegate InitStub(IntPtr config, Type counter)
	{
		return (Delegate)Type.GetTypeFromHandle(ComposerWorkerStatus.DisableLiteralProc(16777302)).GetMethod("GetDelegateForFunctionPointer", new Type[2]
		{
			Type.GetTypeFromHandle(ComposerWorkerStatus.DisableLiteralProc(16777250)),
			Type.GetTypeFromHandle(ComposerWorkerStatus.DisableLiteralProc(16777260))
		})!.Invoke(null, new object[2] { config, counter });
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void ResolveStub()
	{
		//Discarded unreachable code: IL_0c79, IL_0f31, IL_1107, IL_1127, IL_1136, IL_1141, IL_117d, IL_118c, IL_1279, IL_1288, IL_12e8, IL_12f7, IL_1420, IL_142f, IL_185d, IL_1a52, IL_1af7, IL_1b06, IL_1b42, IL_1b51, IL_1b9c, IL_1bab, IL_1c92, IL_1ce8, IL_1cf7, IL_21bb, IL_23af, IL_23be, IL_251e, IL_252d, IL_25dc, IL_2608, IL_273e, IL_28ce, IL_2a57, IL_2a66, IL_2e33, IL_2e4f, IL_31ca, IL_3426, IL_3435, IL_3440, IL_3669, IL_3678, IL_38f4, IL_3903, IL_3bff, IL_4043, IL_4052, IL_42d0, IL_44a6, IL_44c6, IL_4602, IL_4611, IL_463e, IL_464d, IL_467b, IL_46c8, IL_46d7, IL_4727, IL_47ad, IL_4a4a, IL_4baa, IL_4bb9, IL_4ced, IL_4eef, IL_4efe, IL_52f2, IL_5301, IL_590e, IL_5a66, IL_5ae5, IL_5c00, IL_5c53, IL_5c62, IL_5cad
		//The blocks IL_1a7c, IL_1a80, IL_1aa6, IL_1ae7, IL_1b11, IL_1b1a are reachable both inside and outside the pinned region starting at IL_1b5f. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_000e, IL_0012, IL_0ab8, IL_0ad0, IL_0aea, IL_0afd, IL_0b1c, IL_0b2e, IL_0b47, IL_0b61, IL_0b6c, IL_0b7e, IL_0b93, IL_0b9e, IL_0bae, IL_0bca, IL_0be8, IL_0c01, IL_0c18, IL_0c23, IL_0c46, IL_0c5c, IL_0c87, IL_0caa, IL_0cb5, IL_0cca, IL_0ced, IL_0d0c, IL_0d30, IL_0d50, IL_0d69, IL_0d81, IL_0da4, IL_0dc2, IL_0dd7, IL_0de2, IL_0dfd, IL_0e0d, IL_0e22, IL_0e2d, IL_0e46, IL_0e5c, IL_0e67, IL_0e80, IL_0ea3, IL_0eb9, IL_0ee0, IL_0f03, IL_0f1b, IL_0f3f, IL_0f51, IL_0f5c, IL_0f79, IL_0f84, IL_0fa9, IL_0fb4, IL_0fd1, IL_0fdc, IL_1000, IL_1011, IL_1034, IL_104c, IL_1074, IL_1092, IL_10b2, IL_10d0, IL_10e4, IL_12fd, IL_1311, IL_1329, IL_1350, IL_1360, IL_1375, IL_138e, IL_13ab, IL_13c0, IL_13d9, IL_13f7, IL_1402, IL_140d, IL_1435, IL_1452, IL_1478, IL_1491, IL_14b5, IL_14c5, IL_14e8, IL_1500, IL_1524, IL_153d, IL_154f, IL_1567, IL_1588, IL_15a7, IL_15ca, IL_15e9, IL_15f6, IL_1604, IL_161e, IL_1637, IL_1654, IL_165f, IL_1678, IL_1691, IL_16b4, IL_16cc, IL_16f0, IL_16fb, IL_1710, IL_1723, IL_1743, IL_175c, IL_176d, IL_1790, IL_17b0, IL_17ba, IL_17d8, IL_17e3, IL_17ec, IL_17f6, IL_1819, IL_1837, IL_186b, IL_188f, IL_189b, IL_1cfd, IL_1d15, IL_1d32, IL_1d3d, IL_1d54, IL_1d5f, IL_1d80, IL_1d8f, IL_1d9a, IL_1db2, IL_1dca, IL_1de2, IL_1dfa, IL_1e19, IL_1e33, IL_1e3e, IL_1e59, IL_1e71, IL_1e79, IL_1e8e, IL_1ea9, IL_1ec7, IL_1ee7, IL_1efa, IL_1f05, IL_1f1d, IL_1f36, IL_1f4c, IL_1f57, IL_1f68, IL_1f72, IL_1f80, IL_1f9f, IL_1fb7, IL_1fbe, IL_1fcc, IL_1ff0, IL_200f, IL_2018, IL_2022, IL_2033, IL_204b, IL_2056, IL_2079, IL_2098, IL_20b0, IL_20c0, IL_20df, IL_20f7, IL_2110, IL_2118, IL_2126, IL_2149, IL_2173, IL_218c, IL_21a7, IL_21c5, IL_21e1, IL_21fe, IL_2216, IL_223a, IL_2264, IL_227a, IL_2297, IL_22b6, IL_22cf, IL_22e7, IL_2300, IL_2310, IL_2334, IL_234f, IL_2373, IL_238b, IL_23c9, IL_23f3, IL_240b, IL_242e, IL_2452, IL_2463, IL_2473, IL_249d, IL_24b5, IL_24d8, IL_24fb, IL_2518, IL_2748, IL_275a, IL_2765, IL_277a, IL_278a, IL_27a2, IL_27c0, IL_27cb, IL_27e0, IL_27eb, IL_280e, IL_2831, IL_2850, IL_2858, IL_2862, IL_2886, IL_28b0, IL_28bb, IL_28d8, IL_28f5, IL_2909, IL_2915, IL_292a, IL_293a, IL_295d, IL_296e, IL_298b, IL_2996, IL_29b3, IL_29cb, IL_29e2, IL_29f3, IL_2a0b, IL_2a2f, IL_2a3a, IL_2a71, IL_2a87, IL_2a91, IL_2aa9, IL_2ac7, IL_2adf, IL_2aea, IL_2af4, IL_2b13, IL_2b2c, IL_2b44, IL_2b5d, IL_2b73, IL_2b7e, IL_2b93, IL_2b9e, IL_2bb6, IL_2bc1, IL_2bcb, IL_2be4, IL_2bfd, IL_2c12, IL_2c38, IL_2c4d, IL_2c58, IL_2c7b, IL_2c9f, IL_2caa, IL_2cc3, IL_2cdb, IL_2cf0, IL_2cfb, IL_2d13, IL_2d30, IL_2d40, IL_2d63, IL_2d82, IL_2d9d, IL_2da4, IL_2dae, IL_2dc3, IL_2dd9, IL_2de4, IL_2e03, IL_2e27, IL_2e3d, IL_2e59, IL_2e78, IL_2ea2, IL_2ead, IL_2ebb, IL_2edf, IL_2eec, IL_2efd, IL_2f18, IL_2f37, IL_2f56, IL_2f63, IL_2f6e, IL_2f7d, IL_2f88, IL_2fa7, IL_2fbc, IL_2fd3, IL_2feb, IL_2ffb, IL_300d, IL_3018, IL_3030, IL_304f, IL_305c, IL_3080, IL_30aa, IL_30c2, IL_30cf, IL_30e8, IL_3100, IL_3123, IL_3163, IL_3179, IL_318d, IL_31a6, IL_31d4, IL_31ec, IL_3204, IL_321f, IL_322a, IL_323d, IL_3256, IL_326f, IL_328d, IL_3298, IL_32b1, IL_32d0, IL_32e9, IL_3302, IL_344a, IL_345b, IL_347b, IL_3485, IL_34af, IL_34d2, IL_34f1, IL_351b, IL_353e, IL_3561, IL_3579, IL_359d, IL_35b6, IL_35da, IL_35ef, IL_35fc, IL_360c, IL_3628, IL_3641, IL_364b, IL_367e, IL_369f, IL_36aa, IL_36b9, IL_36d6, IL_36e1, IL_3705, IL_372f, IL_3748, IL_3756, IL_377a, IL_3795, IL_379e, IL_37b3, IL_37bc, IL_37cb, IL_37d6, IL_37ef, IL_3812, IL_3821, IL_3845, IL_3850, IL_3868, IL_3873, IL_388d, IL_3898, IL_38b6, IL_38ce, IL_390a, IL_3915, IL_391f, IL_3940, IL_396a, IL_3987, IL_3992, IL_39ad, IL_39c8, IL_39ec, IL_3a01, IL_3a0c, IL_3a22, IL_3a2d, IL_3a5a, IL_3a73, IL_3a92, IL_3ab6, IL_3ad2, IL_3ae7, IL_3b03, IL_3b1d, IL_3b36, IL_3b59, IL_3b69, IL_3b85, IL_3bb6, IL_3be1, IL_3c0d, IL_3c15, IL_3c2a, IL_3c3a, IL_3c42, IL_3c4c, IL_3c6b, IL_3c8e, IL_3ca6, IL_3cc5, IL_3cde, IL_3ce6, IL_3cfb, IL_3d04, IL_3d19, IL_3d26, IL_3d36, IL_3d46, IL_3d69, IL_3d85, IL_3d8f, IL_3d99, IL_3db0, IL_3dcc, IL_3dd7, IL_3def, IL_3dfb, IL_3e05, IL_3e24, IL_3e47, IL_3e66, IL_3e86, IL_3ea4, IL_3ebd, IL_3eca, IL_3ee3, IL_3f02, IL_3f22, IL_3f41, IL_3f4e, IL_3f6d, IL_3f7b, IL_3f96, IL_3fb5, IL_3fca, IL_3fd7, IL_3ff6, IL_4005, IL_4010, IL_4033, IL_405c, IL_406f, IL_408e, IL_40ad, IL_40d1, IL_40dc, IL_40f2, IL_40fd, IL_4116, IL_4126, IL_4150, IL_416f, IL_4180, IL_41a6, IL_41c4, IL_41dc, IL_41e7, IL_420b, IL_4216, IL_4233, IL_4251, IL_425c, IL_4274, IL_4293, IL_42b2, IL_42da, IL_42f3, IL_4317, IL_4322, IL_433b, IL_435f, IL_436a, IL_437d, IL_4395, IL_43a6, IL_43ba, IL_43cf, IL_43ef, IL_4408, IL_442b, IL_4447, IL_4465, IL_4475, IL_4482, IL_4735, IL_474e, IL_4763, IL_4778, IL_4783, IL_47bb, IL_47c8, IL_47d9, IL_47e3, IL_47ed, IL_4811, IL_481c, IL_4835, IL_4847, IL_485f, IL_4889, IL_4894, IL_48a3, IL_48ae, IL_48d1, IL_48ee, IL_48fb, IL_491b, IL_493a, IL_495d, IL_4975, IL_498d, IL_49aa, IL_49c2, IL_49cd, IL_49e8, IL_4a0c, IL_4a17, IL_4a2c, IL_4a54, IL_4a66, IL_4a84, IL_4a9c, IL_4abe, IL_4ad7, IL_4aec, IL_4b0b, IL_4b21, IL_4b36, IL_4b4e, IL_4b5c, IL_4b86, IL_4bbf, IL_4bd8, IL_4bf7, IL_4c15, IL_4c20, IL_4c38, IL_4c4e, IL_4c60, IL_4c73, IL_4c8c, IL_4cb0, IL_4cc9, IL_4cf7, IL_4d09, IL_4d26, IL_4d31, IL_4d3a, IL_4d49, IL_4d54, IL_4d69, IL_4d7c, IL_4d87, IL_4da0, IL_4dc4, IL_4dcf, IL_4de8, IL_4e01, IL_4e19, IL_4e38, IL_4e50, IL_4e6d, IL_4e78, IL_4e88, IL_4ea7, IL_4eca, IL_4edf, IL_4f09, IL_4f1c, IL_4f31, IL_4f55, IL_4f78, IL_4fa4, IL_4fbc, IL_4fcf, IL_4ff2, IL_5015, IL_503f, IL_5055, IL_506e, IL_5087, IL_509c, IL_50ba, IL_50d7, IL_50e2, IL_50fe, IL_511d, IL_5136, IL_5147, IL_5152, IL_515c, IL_5174, IL_518b, IL_5196, IL_51af, IL_51d9, IL_51f3, IL_51fe, IL_521a, IL_524f, IL_526e, IL_5298, IL_52b0, IL_52d0, IL_5307, IL_532b, IL_5336, IL_5349, IL_536c, IL_5387, IL_539f, IL_53b7, IL_53e1, IL_53f4, IL_540c, IL_5429, IL_5434, IL_5452, IL_545d, IL_546d, IL_5476, IL_5480, IL_54a4, IL_54ce, IL_54eb, IL_5500, IL_551d, IL_553a, IL_5545, IL_555a, IL_5573, IL_5592, IL_55b6, IL_55ce, IL_55f1, IL_5609, IL_5611, IL_561b, IL_5624, IL_5639, IL_564c, IL_566f, IL_5692, IL_56b6, IL_56c1, IL_56d9, IL_56f8, IL_5702, IL_571b, IL_5738, IL_5743, IL_5761, IL_577d, IL_579a, IL_57b2, IL_57ca, IL_57e3, IL_57fc, IL_5815, IL_5834, IL_5858, IL_5876, IL_5881, IL_5890, IL_58b3, IL_58cb, IL_58ea, IL_5918, IL_5942, IL_595a, IL_5985, IL_59a4, IL_59bc, IL_59d1, IL_59e0, IL_59ea, IL_5a09, IL_5a16, IL_5a2b, IL_5a39, IL_5a49, IL_5a70, IL_5a95, IL_5aa0, IL_5ab8, IL_5ac3, IL_5aef, IL_5b12, IL_5b22, IL_5b3b, IL_5b54, IL_5b6d, IL_5b8c, IL_5b9e, IL_5bbb, IL_5bdf, IL_5bea, IL_5c0a, IL_5c23, IL_5c34, IL_5c6d, IL_5c85, IL_5cb7, IL_5cd3, IL_5ce6, IL_5d0c, IL_5d29, IL_5d3e, IL_5d48, IL_5d52, IL_5d76, IL_5d8f, IL_5da4, IL_5db2, IL_5dda, IL_5df3, IL_5e12, IL_5e3e, IL_5e5c, IL_5e77, IL_5e90, IL_5ead, IL_5ed1, IL_5eea, IL_5f09, IL_5f27, IL_5f32, IL_5f45, IL_5f5d, IL_5f6e, IL_5f8c, IL_5f97, IL_5fc1, IL_5fd9, IL_5ff4, IL_6009, IL_6027, IL_6046, IL_6069, IL_6081, IL_609e, IL_60bd, IL_60d5, IL_60f4, IL_6115, IL_6138, IL_6151, IL_619a, IL_61a4, IL_61ec, IL_61f6, IL_621c, IL_6226, IL_625b, IL_6265, IL_62ac, IL_62b6, IL_62e0, IL_62ea are reachable both inside and outside the pinned region starting at IL_4f8d. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		int num = 10;
		byte[] array = default(byte[]);
		int num15 = default(int);
		int num47 = default(int);
		StubAuthentication stubAuthentication = default(StubAuthentication);
		byte[] array11 = default(byte[]);
		byte[] array12 = default(byte[]);
		int num36 = default(int);
		byte[] array20 = default(byte[]);
		int num79 = default(int);
		byte[] array17 = default(byte[]);
		byte[] array18 = default(byte[]);
		byte[] array8 = default(byte[]);
		int num25 = default(int);
		IntPtr ident = default(IntPtr);
		int num62 = default(int);
		int num51 = default(int);
		ExporterFacade exporterFacade2 = default(ExporterFacade);
		ProcessModuleCollection processModuleCollection = default(ProcessModuleCollection);
		uint num34 = default(uint);
		long value2 = default(long);
		int task2 = default(int);
		int num26 = default(int);
		string text = default(string);
		int num33 = default(int);
		int num61 = default(int);
		byte[] array10 = default(byte[]);
		IntPtr intPtr = default(IntPtr);
		uint num38 = default(uint);
		uint num3 = default(uint);
		uint num37 = default(uint);
		int num41 = default(int);
		int num80 = default(int);
		byte[] array9 = default(byte[]);
		int num27 = default(int);
		uint num28 = default(uint);
		ExporterFacade exporterFacade = default(ExporterFacade);
		byte[] procFacade = default(byte[]);
		byte[] array13 = default(byte[]);
		byte[] array3 = default(byte[]);
		Process literalProc = default(Process);
		IEnumerator enumerator = default(IEnumerator);
		ProcessModule processModule2 = default(ProcessModule);
		IntPtr intPtr6 = default(IntPtr);
		int num66 = default(int);
		int num68 = default(int);
		int num35 = default(int);
		byte[] array7 = default(byte[]);
		ref byte reference3 = default(ref byte);
		int num31 = default(int);
		byte[] array19 = default(byte[]);
		byte[] array5 = default(byte[]);
		int num40 = default(int);
		MemberModifier item_count = default(MemberModifier);
		int num43 = default(int);
		int task = default(int);
		IntPtr intPtr3 = default(IntPtr);
		int num30 = default(int);
		uint num39 = default(uint);
		MemoryStream memoryStream = default(MemoryStream);
		byte[] array4 = default(byte[]);
		uint nativeSizeOfCode = default(uint);
		ref byte reference = default(ref byte);
		int num18 = default(int);
		int num20 = default(int);
		int num21 = default(int);
		int num23 = default(int);
		long num24 = default(long);
		SymmetricAlgorithm symmetricAlgorithm = default(SymmetricAlgorithm);
		byte[] array16 = default(byte[]);
		byte[] array14 = default(byte[]);
		bool flag = default(bool);
		int num78 = default(int);
		int num44 = default(int);
		int num81 = default(int);
		IntPtr intPtr7 = default(IntPtr);
		int num49 = default(int);
		int num60 = default(int);
		int num84 = default(int);
		ProcessModule processModule3 = default(ProcessModule);
		Version version = default(Version);
		Version version3 = default(Version);
		Version version2 = default(Version);
		int num86 = default(int);
		MemoryStream memoryStream2 = default(MemoryStream);
		IntPtr intPtr5 = default(IntPtr);
		uint num69 = default(uint);
		int num48 = default(int);
		CryptoStream cryptoStream = default(CryptoStream);
		long num50 = default(long);
		uint num45 = default(uint);
		byte[] array21 = default(byte[]);
		IntPtr intPtr4 = default(IntPtr);
		IntPtr spec = default(IntPtr);
		bool attributeFacade = default(bool);
		long num42 = default(long);
		int num71 = default(int);
		int num73 = default(int);
		int num75 = default(int);
		int num77 = default(int);
		string b = default(string);
		int num32 = default(int);
		ICryptoTransform transform = default(ICryptoTransform);
		IntPtr intPtr2 = default(IntPtr);
		int num46 = default(int);
		int num29 = default(int);
		ProcessModule processModule = default(ProcessModule);
		int num56 = default(int);
		int num59 = default(int);
		CreatorAdapterWatcher creatorAdapterWatcher = default(CreatorAdapterWatcher);
		IntPtr config = default(IntPtr);
		int def_amount = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				byte[] array22;
				int num63;
				int num64;
				int num65;
				int num67;
				ref ExporterFacade reference2;
				IntPtr second;
				int num16;
				byte[] array6;
				int num17;
				int num19;
				int num22;
				byte[] array2;
				int num83;
				int num85;
				nint num82;
				int num70;
				int num72;
				int num74;
				int num76;
				int num52;
				int num53;
				long num55;
				long num54;
				int num57;
				int num58;
				byte[] array15;
				uint num4;
				switch (num2)
				{
				case 220:
					array[14] = (byte)num15;
					num2 = 155;
					continue;
				case 249:
					VerifyLiteralProc();
					num2 = 379;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 76:
				case 133:
					num47 = ResolveNotificationMethod(stubAuthentication);
					num2 = 537;
					continue;
				case 442:
					array[14] = 122;
					num2 = 208;
					continue;
				case 179:
				case 516:
					array11 = new byte[6];
					num2 = 195;
					continue;
				case 528:
					num15 = 79 + 66;
					num2 = 377;
					continue;
				case 366:
					array12[num36 + 4] = array20[4];
					num2 = 276;
					if (DestroyLiteralProc() != null)
					{
						num2 = 132;
					}
					continue;
				case 360:
					num79 = array17.Length / 4;
					num2 = 388;
					continue;
				case 57:
					array18[0] = 99;
					num2 = 364;
					if (DestroyLiteralProc() != null)
					{
						num2 = 354;
					}
					continue;
				case 148:
					array18[7] = 116;
					num2 = 331;
					continue;
				case 571:
					array8[11] = (byte)num25;
					num = 136;
					break;
				case 459:
					ident = new IntPtr(roleFacade + num62 - num51);
					num2 = 361;
					continue;
				case 383:
					num25 = 169 - 56;
					num2 = 485;
					continue;
				case 455:
					exporterFacade2.m_AttributeFacade = false;
					num2 = 283;
					if (!PublishLiteralProc())
					{
						num2 = 256;
					}
					continue;
				case 20:
					array[20] = 102;
					num = 21;
					break;
				case 261:
					processModuleCollection = (ProcessModuleCollection)SetLiteralProc(FillLiteralProc());
					num2 = 37;
					continue;
				case 90:
					num34 = 0u;
					num2 = 575;
					if (DestroyLiteralProc() == null)
					{
						continue;
					}
					break;
				case 113:
					array[20] = (byte)num15;
					num2 = 256;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 452:
					if (FlushLiteralProc() != 4)
					{
						num2 = 336;
						if (PublishLiteralProc())
						{
							continue;
						}
						break;
					}
					goto case 393;
				case 655:
					array[16] = 143;
					num = 423;
					break;
				case 512:
					array8[14] = 115;
					num2 = 206;
					continue;
				case 325:
					num25 = 146 + 101;
					num2 = 317;
					if (DestroyLiteralProc() == null)
					{
						continue;
					}
					break;
				case 87:
					ListStub(new IntPtr(value2), FlushLiteralProc(), task2, ref task2);
					num2 = 569;
					continue;
				case 225:
					num15 = 11 + 58;
					num2 = 586;
					continue;
				case 278:
					array[4] = (byte)num26;
					num2 = 503;
					continue;
				case 633:
					text = (string)StartNotificationMethod(DefineNotificationMethod(), array18);
					num2 = 4;
					if (DestroyLiteralProc() == null)
					{
						continue;
					}
					break;
				case 540:
					array12[num33] = array20[0];
					num2 = 406;
					if (DestroyLiteralProc() == null)
					{
						continue;
					}
					break;
				case 232:
				case 466:
					num61++;
					num2 = 474;
					if (DestroyLiteralProc() != null)
					{
						num2 = 159;
					}
					continue;
				case 50:
					array18[1] = 115;
					num2 = 472;
					if (DestroyLiteralProc() == null)
					{
						continue;
					}
					break;
				case 144:
					array18[4] = 105;
					num2 = 558;
					continue;
				case 394:
					array18[3] = 111;
					num2 = 420;
					if (DestroyLiteralProc() != null)
					{
						num2 = 200;
					}
					continue;
				case 491:
					num25 = 67 + 54;
					num2 = 385;
					continue;
				case 616:
					array18[9] = 108;
					num2 = 213;
					if (!PublishLiteralProc())
					{
						num2 = 101;
					}
					continue;
				case 288:
					num26 = 138 - 46;
					num2 = 108;
					continue;
				case 678:
					array[8] = (byte)num26;
					num2 = 403;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 39:
					NewNotificationMethod(array10, 0, array10.Length);
					num2 = 430;
					continue;
				case 300:
					intPtr = new IntPtr(roleFacade + ResolveNotificationMethod(stubAuthentication) - num51);
					num = 265;
					break;
				case 51:
					array[1] = 138;
					num = 202;
					break;
				case 190:
					array8[5] = (byte)num25;
					num2 = 541;
					continue;
				case 178:
					num38 = num3 ^ num37;
					num2 = 382;
					continue;
				case 307:
					num41 = 0;
					num2 = 489;
					if (!PublishLiteralProc())
					{
						num2 = 488;
					}
					continue;
				case 182:
					array[29] = (byte)num15;
					num2 = 121;
					if (PublishLiteralProc())
					{
						num2 = 198;
					}
					continue;
				case 461:
					ListStub(new IntPtr(value2), FlushLiteralProc(), 64, ref task2);
					num2 = 40;
					if (DestroyLiteralProc() == null)
					{
						num2 = 45;
					}
					continue;
				case 359:
					array[7] = (byte)num15;
					num2 = 638;
					if (!PublishLiteralProc())
					{
						num2 = 187;
					}
					continue;
				case 3:
					num26 = 40 - 13;
					num2 = 411;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 574:
					num80 = num61 % num79;
					num2 = 445;
					continue;
				case 486:
					array8[11] = (byte)num25;
					num2 = 0;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 417:
					array[4] = (byte)num15;
					num2 = 33;
					continue;
				case 237:
					array9[num27 + 3] = (byte)((num28 & 0xFF000000u) >> 24);
					num2 = 232;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 134:
					exporterFacade.m_ProcFacade = procFacade;
					num2 = 158;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 279:
					array12[num33 + 3] = array13[3];
					num2 = 555;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 336:
					array22 = new byte[40];
					ListNotificationMethod(array22, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					array3 = array22;
					num2 = 329;
					continue;
				case 520:
					num62 = ResolveNotificationMethod(stubAuthentication);
					num2 = 459;
					continue;
				case 103:
					try
					{
						ProcessModuleCollection processModuleCollection3 = (ProcessModuleCollection)SetLiteralProc(literalProc);
						num63 = 2;
						if (DestroyLiteralProc() != null)
						{
							num63 = 0;
						}
						while (true)
						{
							switch (num63)
							{
							case 1:
								try
								{
									while (true)
									{
										IL_11cd:
										if (!AddLiteralProc(enumerator))
										{
											num64 = 6;
											if (DestroyLiteralProc() != null)
											{
												num64 = 0;
											}
											goto IL_1145;
										}
										goto IL_11b5;
										IL_11b5:
										processModule2 = (ProcessModule)PrepareLiteralProc(enumerator);
										num64 = 3;
										goto IL_1145;
										IL_1145:
										while (true)
										{
											switch (num64)
											{
											case 4:
												num51 = 0;
												num64 = 2;
												continue;
											case 2:
												break;
											case 3:
												intPtr6 = ListLiteralProc(processModule2);
												num64 = 4;
												if (PublishLiteralProc())
												{
													num64 = 5;
												}
												continue;
											default:
												goto IL_11b5;
											case 1:
												goto IL_11cd;
											case 5:
												if (intPtr6.ToInt64() == _ProcessFacade)
												{
													num64 = 4;
													continue;
												}
												goto IL_11cd;
											case 6:
												break;
											}
											break;
										}
										break;
									}
								}
								finally
								{
									IDisposable disposable = enumerator as IDisposable;
									num65 = 0;
									if (DestroyLiteralProc() != null)
									{
										goto IL_1231;
									}
									goto IL_1235;
									IL_1235:
									while (true)
									{
										switch (num65)
										{
										case 1:
											CustomizeLiteralProc(disposable);
											num65 = 2;
											continue;
										default:
											if (disposable != null)
											{
												num65 = 1;
												if (DestroyLiteralProc() == null)
												{
													continue;
												}
												break;
											}
											goto end_IL_1235;
										case 2:
											goto end_IL_1235;
										}
										goto IL_1231;
										continue;
										end_IL_1235:
										break;
									}
									goto end_IL_1213;
									IL_1231:
									num65 = num66;
									goto IL_1235;
									end_IL_1213:;
								}
								break;
							case 2:
								enumerator = (IEnumerator)PopLiteralProc(processModuleCollection3);
								num63 = 1;
								if (DestroyLiteralProc() == null)
								{
									num63 = 1;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
					catch (object obj4)
					{
						num67 = 0;
						if (DestroyLiteralProc() != null)
						{
							num67 = num68;
						}
						switch (num67)
						{
						case 0:
							break;
						}
					}
					goto case 435;
				case 558:
					array18[5] = 116;
					num = 92;
					break;
				case 25:
					array[20] = (byte)num15;
					num2 = 32;
					continue;
				case 648:
					intPtr6 = RestartNotificationMethod(((object[])PatchNotificationMethod(CalcNotificationMethod(typeof(WriterPropertyProducer).TypeHandle).Assembly))[0]);
					num2 = 77;
					continue;
				case 480:
					array18[2] = 114;
					num2 = 304;
					continue;
				case 303:
					array12[num36 + 1] = array13[1];
					num2 = 226;
					continue;
				case 545:
					num15 = 105 + 100;
					num2 = 596;
					continue;
				case 271:
					num25 = 217 - 72;
					num = 297;
					break;
				case 523:
					array12[num36 + 7] = array20[7];
					num2 = 238;
					continue;
				case 583:
					num26 = 19 + 31;
					num2 = 248;
					continue;
				case 423:
					num15 = 183 - 61;
					num2 = 501;
					if (DestroyLiteralProc() != null)
					{
						num2 = 316;
					}
					continue;
				case 320:
					if (num61 == num35 - 1)
					{
						num = 86;
						break;
					}
					goto case 595;
				case 624:
					array10[3] = array7[1];
					num2 = 660;
					if (DestroyLiteralProc() == null)
					{
						continue;
					}
					break;
				case 311:
					array8[4] = (byte)num25;
					num2 = 268;
					continue;
				case 197:
					reference3 = ref *(byte*)null;
					num2 = 169;
					continue;
				case 579:
					num36 = 18;
					num2 = 98;
					if (DestroyLiteralProc() == null)
					{
						continue;
					}
					break;
				case 448:
					num26 = 15 + 32;
					num2 = 631;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 402:
					array18[6] = 105;
					num2 = 148;
					continue;
				case 475:
					array8[12] = (byte)num25;
					num2 = 83;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 264:
					array[26] = (byte)num26;
					num2 = 627;
					continue;
				case 35:
					num25 = 15 + 1;
					num2 = 79;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 316:
					num15 = 2 + 100;
					num2 = 606;
					continue;
				case 69:
					num31 = array19.Length % 4;
					num2 = 269;
					continue;
				case 154:
					array8[6] = (byte)num25;
					num2 = 125;
					continue;
				case 405:
					reference2 = ref exporterFacade2;
					array5 = new byte[1] { 42 };
					reference2.m_ProcFacade = array5;
					num2 = 455;
					continue;
				case 608:
					array8[1] = 97;
					num2 = 78;
					continue;
				case 337:
					array[30] = (byte)num15;
					num2 = 3;
					if (DestroyLiteralProc() == null)
					{
						continue;
					}
					break;
				case 27:
					array8[13] = 52;
					num2 = 188;
					continue;
				case 29:
					num40 = 0;
					num2 = 320;
					continue;
				case 380:
					item_count = (MemberModifier)56;
					num2 = 352;
					continue;
				case 186:
					ListStub(ident, num43 * 4, task, ref task);
					num2 = 28;
					continue;
				case 427:
					ListStub(ident, num43 * 4, 4, ref task);
					num2 = 258;
					continue;
				case 536:
					array[23] = (byte)num15;
					num2 = 128;
					if (PublishLiteralProc())
					{
						num2 = 255;
					}
					continue;
				case 530:
					num15 = 71 + 26;
					num2 = 204;
					continue;
				case 274:
					num26 = 80 + 76;
					num2 = 162;
					continue;
				case 156:
					array[2] = (byte)num15;
					num2 = 570;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 53:
					array[8] = (byte)num26;
					num2 = 532;
					continue;
				case 243:
					array8[9] = 140;
					num2 = 260;
					if (!PublishLiteralProc())
					{
						num2 = 130;
					}
					continue;
				case 273:
					second = IntPtr.Zero;
					num = 196;
					break;
				case 4:
					intPtr3 = CollectStub(text);
					num2 = 326;
					continue;
				case 619:
					array9 = new byte[array19.Length];
					num2 = 360;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 373:
					num15 = 94 + 70;
					num2 = 284;
					continue;
				case 122:
					array18[10] = 108;
					num2 = 621;
					continue;
				case 205:
					array8[14] = (byte)num25;
					num2 = 138;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 28:
				case 127:
					if (OrderNotificationMethod(FindLiteralProc(stubAuthentication)) < ConcatNotificationMethod(FindLiteralProc(stubAuthentication)) - 1)
					{
						num2 = 520;
						continue;
					}
					goto case 407;
				case 315:
					num26 = 219 - 73;
					num2 = 585;
					if (PublishLiteralProc())
					{
						num2 = 645;
					}
					continue;
				case 89:
				case 389:
					if (num30 >= num31)
					{
						num2 = 466;
						continue;
					}
					goto case 431;
				case 398:
					array[13] = 169;
					num = 168;
					break;
				case 294:
					array9[num27 + num30] = (byte)((num38 & num39) >> num40);
					num2 = 322;
					continue;
				case 219:
					NewNotificationMethod(array7, 0, array7.Length);
					num2 = 324;
					if (DestroyLiteralProc() == null)
					{
						continue;
					}
					break;
				case 602:
					array[15] = 55;
					num2 = 436;
					if (!PublishLiteralProc())
					{
						num2 = 403;
					}
					continue;
				case 101:
				case 139:
				case 440:
					try
					{
						object obj = DeleteNotificationMethod(UpdateNotificationMethod(MoveNotificationMethod(CancelNotificationMethod(CalcNotificationMethod(typeof(WriterPropertyProducer).TypeHandle).Assembly))).GetField("m_ptr", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic), MoveNotificationMethod(CancelNotificationMethod(CalcNotificationMethod(typeof(WriterPropertyProducer).TypeHandle).Assembly)));
						num16 = 17;
						if (!PublishLiteralProc())
						{
							goto IL_1904;
						}
						goto IL_1908;
						IL_1908:
						while (true)
						{
							switch (num16)
							{
							case 12:
							case 15:
								ChangeNotificationMethod(memoryStream, new byte[FlushLiteralProc()], 0, FlushLiteralProc());
								num16 = 13;
								continue;
							case 5:
								_MethodFacade = (IntPtr)DeleteNotificationMethod(obj.GetType().GetField("m_pData", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic), obj);
								num16 = 8;
								continue;
							default:
								ChangeNotificationMethod(memoryStream, new byte[FlushLiteralProc()], 0, FlushLiteralProc());
								num16 = 16;
								continue;
							case 13:
								ChangeNotificationMethod(memoryStream, new byte[FlushLiteralProc()], 0, FlushLiteralProc());
								num16 = 2;
								continue;
							case 9:
								array4 = (byte[])ManageNotificationMethod(memoryStream);
								num16 = 18;
								if (DestroyLiteralProc() == null)
								{
									continue;
								}
								break;
							case 16:
								if (FlushLiteralProc() == 4)
								{
									num16 = 4;
									if (DestroyLiteralProc() == null)
									{
										continue;
									}
									break;
								}
								goto case 3;
							case 2:
								RevertLiteralProc(memoryStream, 0L);
								num16 = 9;
								continue;
							case 1:
								nativeSizeOfCode = 0u;
								num16 = 10;
								continue;
							case 10:
								try
								{
									array6 = (array5 = array4);
									if (array6 == null)
									{
										num17 = 2;
										if (DestroyLiteralProc() != null)
										{
											goto IL_1a7c;
										}
										goto IL_1a80;
									}
									goto IL_1b11;
									IL_1a80:
									while (true)
									{
										switch (num17)
										{
										case 3:
										case 4:
											_CustomerFacade(new IntPtr(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference)), new IntPtr(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference)), new IntPtr(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference)), 216669565u, new IntPtr(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference)), ref nativeSizeOfCode);
											num17 = 0;
											if (DestroyLiteralProc() != null)
											{
												num17 = 0;
											}
											continue;
										case 6:
											goto IL_1b11;
										case 1:
										case 2:
											goto IL_1b2f;
										case 5:
											goto IL_1b57;
										case 0:
											break;
										}
										break;
									}
									goto end_IL_1a5d;
									IL_1b11:
									if (array5.Length == 0)
									{
										num17 = 1;
										if (!PublishLiteralProc())
										{
											goto IL_1a7c;
										}
										goto IL_1a80;
									}
									goto IL_1b57;
									IL_1b2f:
									reference = ref *(byte*)null;
									num17 = 3;
									goto IL_1a80;
									IL_1a7c:
									num17 = num18;
									goto IL_1a80;
									IL_1b57:
									while (true)
									{
										fixed (byte* value = &array5[0])
										{
											num17 = 4;
											while (true)
											{
												switch (num17)
												{
												case 5:
													break;
												default:
													goto end_IL_1b57;
												case 3:
												case 4:
													_CustomerFacade(new IntPtr(value), new IntPtr(value), new IntPtr(value), 216669565u, new IntPtr(value), ref nativeSizeOfCode);
													num17 = 0;
													if (DestroyLiteralProc() != null)
													{
														num17 = 0;
													}
													continue;
												case 6:
													if (array5.Length == 0)
													{
														num17 = 1;
														if (!PublishLiteralProc())
														{
															num17 = num18;
														}
														continue;
													}
													break;
												case 1:
												case 2:
													goto IL_1b2f;
												case 0:
													goto end_IL_1b57;
												}
												break;
											}
										}
										continue;
										end_IL_1b57:
										break;
									}
									end_IL_1a5d:;
								}
								finally
								{
									reference = ref *(byte*)null;
									num19 = 0;
									if (DestroyLiteralProc() != null)
									{
										num19 = num20;
									}
									switch (num19)
									{
									case 0:
										break;
									}
								}
								goto end_IL_1908;
							case 3:
								ChangeNotificationMethod(memoryStream, GetNotificationMethod(_MethodFacade.ToInt64()), 0, 8);
								num16 = 15;
								continue;
							case 7:
							case 8:
								memoryStream = new MemoryStream();
								num16 = 0;
								if (DestroyLiteralProc() == null)
								{
									num16 = 0;
								}
								continue;
							case 18:
								RateNotificationMethod(memoryStream);
								num16 = 1;
								if (!PublishLiteralProc())
								{
									num16 = 0;
								}
								continue;
							case 11:
								if (!ForgotLiteralProc(obj.GetType().ToString(), "System.Reflection.RuntimeModule"))
								{
									num16 = 7;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								}
								goto case 5;
							case 4:
								ChangeNotificationMethod(memoryStream, InterruptNotificationMethod(_MethodFacade.ToInt32()), 0, 4);
								num16 = 12;
								if (DestroyLiteralProc() != null)
								{
									num16 = 2;
								}
								continue;
							case 17:
								if (obj is IntPtr)
								{
									num16 = 14;
									continue;
								}
								goto case 11;
							case 14:
								_MethodFacade = (IntPtr)obj;
								num16 = 11;
								continue;
							case 6:
								goto end_IL_1908;
							}
							goto IL_1904;
							continue;
							end_IL_1908:
							break;
						}
						goto end_IL_189b;
						IL_1904:
						num16 = num21;
						goto IL_1908;
						end_IL_189b:;
					}
					catch (object obj2)
					{
						num22 = 0;
						if (DestroyLiteralProc() != null)
						{
							num22 = num23;
						}
						switch (num22)
						{
						case 0:
							break;
						}
					}
					goto case 71;
				case 55:
					num24 = InvokeNotificationMethod(new IntPtr(value2));
					num2 = 241;
					continue;
				case 91:
					array[23] = (byte)num15;
					num2 = 549;
					if (DestroyLiteralProc() != null)
					{
						num2 = 292;
					}
					continue;
				case 65:
					LogoutNotificationMethod(symmetricAlgorithm, CipherMode.CBC);
					num2 = 253;
					if (DestroyLiteralProc() != null)
					{
						num2 = 236;
					}
					continue;
				case 81:
					if (((Array)ReflectNotificationMethod(PublishNotificationMethod(CalcNotificationMethod(typeof(WriterPropertyProducer).TypeHandle).Assembly))).Length == 2)
					{
						num2 = 70;
						if (DestroyLiteralProc() == null)
						{
							num2 = 668;
						}
						continue;
					}
					goto case 101;
				case 319:
					array[4] = (byte)num26;
					num2 = 124;
					continue;
				case 221:
					array[29] = (byte)num15;
					num2 = 266;
					continue;
				case 93:
					array[25] = (byte)num26;
					num2 = 244;
					continue;
				case 388:
					num3 = 0u;
					num2 = 90;
					if (DestroyLiteralProc() == null)
					{
						continue;
					}
					break;
				case 627:
					array[26] = 231;
					num2 = 19;
					continue;
				case 456:
					array12[num36 + 1] = array20[1];
					num2 = 533;
					if (!PublishLiteralProc())
					{
						num2 = 329;
					}
					continue;
				case 331:
					array18[8] = 46;
					num2 = 181;
					if (DestroyLiteralProc() == null)
					{
						continue;
					}
					break;
				case 115:
					array8[7] = (byte)num25;
					num2 = 413;
					continue;
				case 431:
					if (num30 > 0)
					{
						num2 = 166;
						if (DestroyLiteralProc() == null)
						{
							continue;
						}
						break;
					}
					goto case 294;
				case 301:
					array10 = array8;
					num2 = 52;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 393:
					array2 = new byte[30];
					ListNotificationMethod(array2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					array3 = array2;
					num2 = 267;
					continue;
				case 165:
					array12[num36 + 6] = array16[6];
					num2 = 552;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 121:
					array14 = array9;
					num2 = 202;
					if (DestroyLiteralProc() == null)
					{
						num2 = 565;
					}
					continue;
				case 510:
					array[23] = (byte)num15;
					num2 = 231;
					continue;
				case 542:
					num15 = 140 - 46;
					num2 = 657;
					continue;
				case 52:
					IncludeNotificationMethod(array10);
					num2 = 434;
					if (DestroyLiteralProc() != null)
					{
						num2 = 34;
					}
					continue;
				case 326:
					if (!EnableNotificationMethod(intPtr3, IntPtr.Zero))
					{
						num2 = 516;
						continue;
					}
					goto case 184;
				case 41:
				case 346:
					num3 = num3;
					num2 = 494;
					continue;
				case 321:
					AssetNotificationMethod(_CustomerFacade);
					num2 = 615;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 284:
					array[28] = (byte)num15;
					num2 = 448;
					continue;
				case 192:
					if (flag)
					{
						num = 504;
						break;
					}
					goto case 249;
				case 549:
					num15 = 190 + 54;
					num2 = 510;
					if (DestroyLiteralProc() == null)
					{
						continue;
					}
					break;
				case 551:
					array[1] = 146;
					num2 = 315;
					continue;
				case 34:
				case 262:
					if (num78 >= num47)
					{
						num2 = 127;
						continue;
					}
					goto case 300;
				case 196:
					num78 = 0;
					num = 34;
					break;
				case 242:
					array10[15] = array7[7];
					num2 = 219;
					if (DestroyLiteralProc() != null)
					{
						num2 = 217;
					}
					continue;
				case 568:
					array[0] = (byte)num26;
					num2 = 51;
					if (DestroyLiteralProc() == null)
					{
						continue;
					}
					break;
				case 546:
					array[30] = 127;
					num2 = 210;
					continue;
				case 586:
					array[15] = (byte)num15;
					num2 = 354;
					continue;
				case 59:
					array18[7] = 100;
					num2 = 207;
					continue;
				case 467:
					array[3] = 192;
					num2 = 547;
					continue;
				case 585:
					array[19] = (byte)num26;
					num2 = 623;
					continue;
				case 354:
					num26 = 69 + 103;
					num2 = 128;
					continue;
				case 13:
					if (num44 == 4)
					{
						num = 30;
						break;
					}
					goto case 531;
				case 629:
					array8[4] = (byte)num25;
					num2 = 150;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 640:
					array8[15] = 105;
					num2 = 46;
					if (DestroyLiteralProc() == null)
					{
						continue;
					}
					break;
				case 185:
					num15 = 95 + 115;
					num2 = 417;
					continue;
				case 172:
					array18[5] = 106;
					num2 = 402;
					if (DestroyLiteralProc() == null)
					{
						continue;
					}
					break;
				case 569:
					VerifyLiteralProc();
					num2 = 292;
					continue;
				case 572:
					array[18] = (byte)num26;
					num = 479;
					break;
				case 599:
					num15 = 168 - 56;
					num = 305;
					break;
				case 247:
					array8[1] = (byte)num25;
					num2 = 35;
					continue;
				case 78:
					num25 = 38 + 39;
					num2 = 61;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 496:
					array[9] = 17;
					num2 = 94;
					if (DestroyLiteralProc() == null)
					{
						continue;
					}
					break;
				case 38:
					num81 = ResolveNotificationMethod(stubAuthentication) - num51;
					num2 = 628;
					continue;
				case 151:
					num25 = 52 + 0;
					num = 290;
					break;
				case 256:
					array[20] = 147;
					num2 = 622;
					continue;
				case 64:
					num26 = 60 + 68;
					num2 = 647;
					continue;
				case 22:
					RevertLiteralProc(FindLiteralProc(stubAuthentication), 0L);
					num2 = 607;
					continue;
				case 117:
					num25 = 162 - 54;
					num2 = 672;
					continue;
				case 472:
					array18[2] = 99;
					num2 = 394;
					continue;
				case 233:
					num25 = 230 - 76;
					num2 = 349;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 409:
					ListStub(intPtr7, 4, task, ref task);
					num = 153;
					break;
				case 661:
					num26 = 221 - 73;
					num2 = 157;
					if (DestroyLiteralProc() == null)
					{
						continue;
					}
					break;
				case 79:
					array8[2] = (byte)num25;
					num2 = 399;
					continue;
				case 492:
					array[0] = 123;
					num2 = 487;
					continue;
				case 80:
					array8[8] = 152;
					num2 = 212;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 415:
					CountNotificationMethod(intPtr7, ResolveNotificationMethod(stubAuthentication));
					num2 = 409;
					continue;
				case 67:
					array[11] = 118;
					num = 535;
					break;
				case 413:
					num25 = 6 + 89;
					num2 = 272;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 335:
					num39 = 255u;
					num2 = 29;
					continue;
				case 153:
					num49++;
					num2 = 281;
					continue;
				case 437:
					array[31] = 148;
					num2 = 119;
					if (DestroyLiteralProc() == null)
					{
						continue;
					}
					break;
				case 483:
					array[10] = (byte)num15;
					num2 = 513;
					continue;
				case 84:
					array[19] = (byte)num26;
					num2 = 143;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 157:
					array[13] = (byte)num26;
					num2 = 398;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 565:
					num60 = array14.Length / 8;
					num2 = 387;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 263:
					try
					{
						while (true)
						{
							if (!AddLiteralProc(enumerator))
							{
								num83 = 9;
								goto IL_2537;
							}
							goto IL_2653;
							IL_2533:
							num83 = num84;
							goto IL_2537;
							IL_2653:
							processModule3 = (ProcessModule)PrepareLiteralProc(enumerator);
							num83 = 7;
							if (DestroyLiteralProc() != null)
							{
								goto IL_2533;
							}
							goto IL_2537;
							IL_2537:
							while (true)
							{
								switch (num83)
								{
								case 11:
									break;
								case 3:
									if (ConnectLiteralProc(version, version3))
									{
										num83 = 4;
										continue;
									}
									goto end_IL_2537;
								case 6:
								case 10:
									goto end_IL_2537;
								case 2:
									version3 = new Version(4, 0, 30319, 17020);
									num83 = 8;
									continue;
								case 5:
									goto end_IL_25a4;
								case 8:
									version2 = new Version(4, 0, 30319, 17921);
									num83 = 3;
									continue;
								case 1:
									version = new Version(CompareLiteralProc(TestLiteralProc(processModule3)), VisitLiteralProc(TestLiteralProc(processModule3)), ViewLiteralProc(TestLiteralProc(processModule3)), SearchLiteralProc(TestLiteralProc(processModule3)));
									num83 = 2;
									continue;
								default:
									goto IL_2653;
								case 7:
									goto IL_2676;
								case 4:
									if (!QueryLiteralProc(version, version2))
									{
										num83 = 10;
										if (DestroyLiteralProc() != null)
										{
											num83 = 1;
										}
										continue;
									}
									break;
								case 9:
									goto end_IL_25a4;
								}
								schemaFacade = true;
								num83 = 5;
								if (DestroyLiteralProc() == null)
								{
									continue;
								}
								goto IL_2533;
								IL_2676:
								if (!ForgotLiteralProc(CheckLiteralProc(CallLiteralProc(processModule3)), "clrjit.dll"))
								{
									break;
								}
								num83 = 1;
								if (PublishLiteralProc())
								{
									continue;
								}
								goto IL_2533;
								continue;
								end_IL_2537:
								break;
							}
							continue;
							end_IL_25a4:
							break;
						}
					}
					finally
					{
						IDisposable disposable = enumerator as IDisposable;
						num85 = 2;
						while (true)
						{
							switch (num85)
							{
							default:
								CustomizeLiteralProc(disposable);
								num85 = 1;
								if (DestroyLiteralProc() != null)
								{
									num85 = 0;
								}
								continue;
							case 2:
								if (disposable != null)
								{
									num85 = 0;
									if (!PublishLiteralProc())
									{
										num85 = num86;
									}
									continue;
								}
								break;
							case 1:
								break;
							}
							break;
						}
					}
					goto case 215;
				case 120:
					task2 = 0;
					num2 = 2;
					if (DestroyLiteralProc() == null)
					{
						num2 = 2;
					}
					continue;
				case 174:
					memoryStream2 = new MemoryStream();
					num = 416;
					break;
				case 171:
					array11[4] = 105;
					num2 = 287;
					continue;
				case 162:
					array[11] = (byte)num26;
					num2 = 227;
					continue;
				case 505:
					num26 = 195 - 65;
					num2 = 193;
					if (PublishLiteralProc())
					{
						num2 = 264;
					}
					continue;
				case 195:
					array11[0] = 103;
					num2 = 4;
					if (DestroyLiteralProc() == null)
					{
						num2 = 118;
					}
					continue;
				case 132:
					array[25] = (byte)num26;
					num2 = 200;
					if (DestroyLiteralProc() == null)
					{
						continue;
					}
					break;
				case 449:
					array[8] = (byte)num15;
					num2 = 654;
					if (DestroyLiteralProc() == null)
					{
						continue;
					}
					break;
				case 513:
					array[10] = 98;
					num2 = 163;
					continue;
				case 372:
					if (num41 > 0)
					{
						num2 = 314;
						continue;
					}
					goto case 60;
				case 447:
					num15 = 154 - 51;
					num2 = 522;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 244:
					array[26] = 51;
					num2 = 505;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 514:
					if (FlushLiteralProc() == 4)
					{
						num = 312;
						break;
					}
					goto case 70;
				case 443:
					num25 = 104 + 35;
					num = 286;
					break;
				case 257:
					value2 = PrintNotificationMethod(intPtr5);
					num2 = 40;
					continue;
				case 330:
					if (num69 == 4109628145u)
					{
						num2 = 175;
						if (PublishLiteralProc())
						{
							continue;
						}
						break;
					}
					goto case 504;
				case 118:
					array11[1] = 101;
					num2 = 419;
					continue;
				case 176:
					array[5] = (byte)num26;
					num2 = 497;
					if (DestroyLiteralProc() == null)
					{
						continue;
					}
					break;
				case 161:
					num28 = num3 ^ num37;
					num2 = 612;
					continue;
				case 468:
					array8[15] = (byte)num25;
					num2 = 192;
					if (PublishLiteralProc())
					{
						num2 = 240;
					}
					continue;
				case 234:
					intPtr6 = RestartNotificationMethod(((object[])PatchNotificationMethod(m_ProducerFacade))[0]);
					num2 = 340;
					continue;
				case 478:
					array16 = null;
					num2 = 408;
					if (DestroyLiteralProc() == null)
					{
						continue;
					}
					break;
				case 441:
					array12[num33] = array16[0];
					num = 228;
					break;
				case 152:
					num3 += num34;
					num2 = 209;
					continue;
				case 250:
					array8[0] = (byte)num25;
					num2 = 581;
					continue;
				case 334:
					array8[13] = 165;
					num2 = 27;
					if (!PublishLiteralProc())
					{
						num2 = 11;
					}
					continue;
				case 672:
					array8[6] = (byte)num25;
					num2 = 422;
					continue;
				case 646:
					if (!CalculateLiteralProc(ResetLiteralProc("System.Reflection.ReflectionContext", false), null))
					{
						num2 = 215;
						continue;
					}
					goto case 261;
				case 369:
					array[22] = (byte)num26;
					num2 = 500;
					continue;
				case 62:
					num82 = (nint)((byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference3) + (nint)num48 * (nint)8);
					*(long*)num82 ^= 258470544L;
					num2 = 73;
					continue;
				case 657:
					array[12] = (byte)num15;
					num2 = 590;
					continue;
				case 137:
					if (FlushLiteralProc() == 4)
					{
						num2 = 257;
						continue;
					}
					goto case 634;
				case 603:
					array[11] = 214;
					num2 = 446;
					continue;
				case 210:
					num15 = 133 - 44;
					num2 = 337;
					continue;
				case 108:
					array[6] = (byte)num26;
					num2 = 438;
					continue;
				case 481:
					num26 = 90 + 106;
					num2 = 369;
					continue;
				case 473:
					InsertNotificationMethod(cryptoStream);
					num2 = 211;
					if (DestroyLiteralProc() != null)
					{
						num2 = 186;
					}
					continue;
				case 445:
					num27 = num61 * 4;
					num2 = 425;
					if (!PublishLiteralProc())
					{
						num2 = 268;
					}
					continue;
				case 501:
					array[16] = (byte)num15;
					num2 = 447;
					continue;
				case 58:
					if (num61 == num35 - 1)
					{
						num2 = 507;
						continue;
					}
					goto case 161;
				case 235:
					num25 = 188 - 62;
					num2 = 222;
					continue;
				case 188:
					num25 = 225 - 75;
					num2 = 205;
					continue;
				case 406:
					array12[num33 + 1] = array20[1];
					num2 = 610;
					continue;
				case 116:
					RemoveNotificationMethod(m_DatabaseFacade, num50 + num81, exporterFacade);
					num2 = 582;
					continue;
				case 425:
					num45 = (uint)(num80 * 4);
					num2 = 88;
					if (PublishLiteralProc())
					{
						num2 = 191;
					}
					continue;
				case 44:
					array8[8] = 23;
					num = 443;
					break;
				case 198:
					array[29] = 169;
					num2 = 136;
					if (PublishLiteralProc())
					{
						num2 = 141;
					}
					continue;
				case 625:
					num25 = 25 + 35;
					num2 = 48;
					continue;
				case 550:
					ChangeNotificationMethod(cryptoStream, array21, 0, array21.Length);
					num2 = 473;
					continue;
				case 643:
					array11[3] = 74;
					num2 = 146;
					if (PublishLiteralProc())
					{
						num2 = 171;
					}
					continue;
				case 129:
					array[24] = (byte)num26;
					num2 = 285;
					continue;
				case 465:
					num26 = 121 + 82;
					num = 110;
					break;
				case 207:
					array18[8] = 108;
					num2 = 616;
					continue;
				case 554:
					array16 = (byte[])GetNotificationMethod(intPtr4.ToInt64());
					num2 = 365;
					if (DestroyLiteralProc() == null)
					{
						continue;
					}
					break;
				case 526:
					array[31] = 120;
					num2 = 437;
					continue;
				case 126:
					num41++;
					num2 = 626;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 254:
					if (array7 == null)
					{
						num2 = 594;
						continue;
					}
					goto case 194;
				case 228:
					array12[num33 + 1] = array16[1];
					num2 = 123;
					continue;
				case 414:
					spec = IntPtr.Zero;
					num2 = 47;
					if (PublishLiteralProc())
					{
						num2 = 380;
					}
					continue;
				case 68:
					array[27] = 107;
					num2 = 363;
					continue;
				case 72:
					array[24] = 225;
					num2 = 567;
					if (DestroyLiteralProc() != null)
					{
						num2 = 6;
					}
					continue;
				case 650:
					return;
				case 160:
					attributeFacade = false;
					num2 = 368;
					continue;
				case 617:
					array8[10] = 230;
					num2 = 428;
					continue;
				case 578:
					array8[12] = 132;
					num2 = 233;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 498:
					if (FlushLiteralProc() == 4)
					{
						num = 31;
						break;
					}
					goto case 55;
				case 547:
					num15 = 120 + 55;
					num2 = 556;
					if (DestroyLiteralProc() == null)
					{
						continue;
					}
					break;
				case 666:
					array3 = null;
					num2 = 452;
					continue;
				case 299:
					RateNotificationMethod(cryptoStream);
					num2 = 7;
					continue;
				case 314:
					num37 <<= 8;
					num2 = 60;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 677:
					array[1] = 214;
					num2 = 82;
					continue;
				case 227:
					array[11] = 137;
					num2 = 339;
					continue;
				case 639:
					num61 = 0;
					num2 = 410;
					continue;
				case 676:
					if (FlushLiteralProc() == 4)
					{
						num2 = 180;
						if (PublishLiteralProc())
						{
							num2 = 234;
						}
						continue;
					}
					goto case 529;
				case 141:
					array[29] = 88;
					num2 = 355;
					continue;
				case 298:
					array12[num36 + 5] = array13[5];
					num2 = 173;
					continue;
				case 184:
					array18 = new byte[10];
					num = 57;
					break;
				case 47:
					array[15] = (byte)num15;
					num2 = 583;
					continue;
				case 391:
					num78++;
					num2 = 262;
					continue;
				case 408:
					array20 = null;
					num2 = 313;
					if (PublishLiteralProc())
					{
						num2 = 476;
					}
					continue;
				case 74:
					array8[0] = (byte)num25;
					num2 = 293;
					continue;
				case 167:
					array8[13] = 200;
					num2 = 362;
					continue;
				case 476:
					array13 = null;
					num2 = 664;
					continue;
				case 23:
					num26 = 77 + 103;
					num2 = 313;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 589:
					array8[15] = 157;
					num2 = 640;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 620:
					array8[9] = (byte)num25;
					num2 = 243;
					continue;
				case 460:
					attributeFacade = false;
					num2 = 367;
					continue;
				case 266:
					num15 = 112 + 90;
					num2 = 182;
					continue;
				case 63:
					array[24] = (byte)num15;
					num2 = 296;
					continue;
				case 54:
					array[17] = (byte)num15;
					num2 = 599;
					if (DestroyLiteralProc() == null)
					{
						continue;
					}
					break;
				case 191:
					num34 = (uint)((array17[num45 + 3] << 24) | (array17[num45 + 2] << 16) | (array17[num45 + 1] << 8) | array17[num45]);
					num2 = 335;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 24:
					intPtr4 = DisableNotificationMethod(_CustomerFacade);
					num2 = 223;
					continue;
				case 71:
					AssetNotificationMethod(_StrategyFacade);
					num2 = 493;
					continue;
				case 240:
					num25 = 248 - 82;
					num2 = 102;
					continue;
				case 426:
					array[22] = 94;
					num2 = 481;
					continue;
				case 675:
					array8[14] = (byte)num25;
					num2 = 512;
					continue;
				case 248:
					array[16] = (byte)num26;
					num2 = 655;
					continue;
				case 99:
					ListStub(intPtr7, 4, 4, ref task);
					num2 = 288;
					if (PublishLiteralProc())
					{
						num2 = 415;
					}
					continue;
				case 158:
					exporterFacade.m_AttributeFacade = attributeFacade;
					num2 = 116;
					continue;
				case 251:
					GetLiteralProc(array5, 0, DeleteLiteralProc(8), 1);
					num2 = 15;
					continue;
				case 75:
					num15 = 145 - 48;
					num2 = 54;
					continue;
				case 654:
					num26 = 140 + 46;
					num2 = 678;
					if (!PublishLiteralProc())
					{
						num2 = 512;
					}
					continue;
				case 500:
					num26 = 166 - 55;
					num2 = 674;
					continue;
				case 202:
					array[1] = 55;
					num2 = 551;
					continue;
				case 458:
					num15 = 186 - 62;
					num2 = 536;
					continue;
				case 390:
					InitLiteralProc(new IntPtr(&num42), 0);
					num2 = 203;
					continue;
				case 36:
					try
					{
						_StrategyFacade = (StatePropertyPolicy)ReadNotificationMethod(new IntPtr(num24), CalcNotificationMethod(typeof(StatePropertyPolicy).TypeHandle));
						num70 = 0;
						if (DestroyLiteralProc() != null)
						{
							num70 = num71;
						}
						switch (num70)
						{
						case 0:
							break;
						}
					}
					catch (object obj6)
					{
						num72 = 0;
						if (DestroyLiteralProc() != null)
						{
							num72 = num73;
						}
						switch (num72)
						{
						default:
							try
							{
								Delegate @delegate = (Delegate)ReadNotificationMethod(new IntPtr(num24), CalcNotificationMethod(typeof(StatePropertyPolicy).TypeHandle));
								num74 = 1;
								if (DestroyLiteralProc() != null)
								{
									goto IL_33a9;
								}
								goto IL_33ad;
								IL_33ad:
								while (true)
								{
									switch (num74)
									{
									case 1:
										goto IL_33bf;
									case 0:
										break;
									}
									break;
									IL_33bf:
									_StrategyFacade = (StatePropertyPolicy)PushNotificationMethod(CalcNotificationMethod(typeof(StatePropertyPolicy).TypeHandle), InitNotificationMethod(@delegate));
									num74 = 0;
									if (PublishLiteralProc())
									{
										continue;
									}
									goto IL_33a9;
								}
								goto end_IL_337c;
								IL_33a9:
								num74 = num75;
								goto IL_33ad;
								end_IL_337c:;
							}
							catch (object obj5)
							{
								num76 = 0;
								if (DestroyLiteralProc() != null)
								{
									num76 = num77;
								}
								switch (num76)
								{
								default:
									goto end_IL_33f9;
								case 0:
									goto end_IL_33f9;
								}
								end_IL_33f9:;
							}
							break;
						case 1:
							break;
						}
					}
					goto case 378;
				case 100:
					intPtr4 = IntPtr.Zero;
					num2 = 24;
					continue;
				case 368:
				case 582:
					if (OrderNotificationMethod(FindLiteralProc(stubAuthentication)) < ConcatNotificationMethod(FindLiteralProc(stubAuthentication)) - 1)
					{
						num2 = 38;
						continue;
					}
					goto case 648;
				case 469:
					array8[7] = 17;
					num2 = 80;
					if (DestroyLiteralProc() == null)
					{
						continue;
					}
					break;
				case 385:
					array8[8] = (byte)num25;
					num2 = 44;
					if (DestroyLiteralProc() == null)
					{
						continue;
					}
					break;
				case 557:
					array8[9] = 86;
					num2 = 270;
					continue;
				case 260:
					array8[9] = 247;
					num2 = 609;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 333:
					array8[7] = (byte)num25;
					num2 = 566;
					if (DestroyLiteralProc() == null)
					{
						continue;
					}
					break;
				case 493:
					ValidateNotificationMethod(FillNotificationMethod(InitNotificationMethod(_StrategyFacade)));
					num = 321;
					break;
				case 252:
					return;
				case 488:
					num15 = 217 - 72;
					num2 = 401;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 611:
					num26 = 135 - 45;
					num2 = 176;
					continue;
				case 347:
					num25 = 72 + 48;
					num2 = 74;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 49:
					array12[num33 + 3] = array20[3];
					num2 = 499;
					continue;
				case 201:
					task = 0;
					num2 = 495;
					continue;
				case 364:
					array18[1] = 108;
					num2 = 480;
					continue;
				case 348:
					num69 = 4059231220u;
					num2 = 412;
					if (DestroyLiteralProc() == null)
					{
						continue;
					}
					break;
				case 668:
					if (AwakeNotificationMethod(CalcNotificationMethod(typeof(WriterPropertyProducer).TypeHandle).Assembly) == null)
					{
						num2 = 101;
						continue;
					}
					goto case 246;
				case 418:
					array12[num36 + 3] = array13[3];
					num = 142;
					break;
				case 193:
					array9[num27 + 1] = (byte)((num28 & 0xFF00) >> 8);
					num2 = 36;
					if (PublishLiteralProc())
					{
						num2 = 146;
					}
					continue;
				case 1:
					VerifyLiteralProc();
					num2 = 650;
					continue;
				case 159:
					b = (string)StartNotificationMethod(DefineNotificationMethod(), array11);
					num2 = 263;
					if (DestroyLiteralProc() == null)
					{
						num2 = 462;
					}
					continue;
				case 642:
					num25 = 168 - 56;
					num2 = 190;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 32:
					array[20] = 11;
					num2 = 605;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 567:
					num15 = 169 - 56;
					num2 = 63;
					continue;
				case 177:
					array12 = array3;
					num2 = 478;
					continue;
				case 598:
					num25 = 183 + 42;
					num2 = 656;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 667:
					array13 = (byte[])InterruptNotificationMethod(_MethodFacade.ToInt32());
					num2 = 484;
					continue;
				case 376:
				case 490:
					if (num32 >= num43)
					{
						num2 = 186;
						if (PublishLiteralProc())
						{
							continue;
						}
						break;
					}
					goto case 357;
				case 410:
				case 474:
					if (num61 >= num35)
					{
						num2 = 121;
						if (DestroyLiteralProc() != null)
						{
							num2 = 100;
						}
						continue;
					}
					goto case 574;
				case 370:
					num15 = 191 - 63;
					num2 = 450;
					continue;
				case 305:
					array[17] = (byte)num15;
					num2 = 341;
					if (DestroyLiteralProc() == null)
					{
						continue;
					}
					break;
				case 591:
					VerifyLiteralProc();
					num2 = 252;
					continue;
				case 399:
					array8[2] = 87;
					num2 = 644;
					if (DestroyLiteralProc() != null)
					{
						num2 = 208;
					}
					continue;
				case 37:
					enumerator = (IEnumerator)PopLiteralProc(processModuleCollection);
					num2 = 263;
					if (DestroyLiteralProc() != null)
					{
						num2 = 110;
					}
					continue;
				case 142:
					array12[num36 + 4] = array13[4];
					num2 = 178;
					if (PublishLiteralProc())
					{
						num2 = 298;
					}
					continue;
				case 309:
					array12[num36] = array13[0];
					num2 = 303;
					if (DestroyLiteralProc() == null)
					{
						continue;
					}
					break;
				case 318:
					array[25] = (byte)num26;
					num2 = 130;
					continue;
				case 607:
					intPtr6 = RestartNotificationMethod(((object[])PatchNotificationMethod(m_ProducerFacade))[0]);
					num = 97;
					break;
				case 379:
					return;
				case 504:
					if (FlushLiteralProc() == 4)
					{
						num2 = 646;
						continue;
					}
					goto case 215;
				case 416:
					cryptoStream = new CryptoStream(memoryStream2, transform, CryptoStreamMode.Write);
					num2 = 550;
					if (DestroyLiteralProc() == null)
					{
						continue;
					}
					break;
				case 109:
					array[28] = 126;
					num2 = 561;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 147:
				case 658:
					GetLiteralProc(array12, 0, intPtr2, array12.Length);
					num2 = 521;
					if (DestroyLiteralProc() != null)
					{
						num2 = 85;
					}
					continue;
				case 280:
					array17[num46] = (byte)(array17[num46] ^ array10[num46]);
					num2 = 439;
					continue;
				case 671:
					_CustomerFacade = new StatePropertyPolicy(ConnectStub);
					num2 = 100;
					continue;
				case 543:
					num26 = 209 - 69;
					num2 = 277;
					if (DestroyLiteralProc() == null)
					{
						continue;
					}
					break;
				case 9:
					_PrinterFacade = true;
					num2 = 40;
					if (DestroyLiteralProc() == null)
					{
						num2 = 348;
					}
					continue;
				case 395:
				case 548:
					num51 = 7680;
					num2 = 76;
					if (!PublishLiteralProc())
					{
						num2 = 65;
					}
					continue;
				case 283:
					RemoveNotificationMethod(m_DatabaseFacade, 0L, exporterFacade2);
					num2 = 160;
					if (DestroyLiteralProc() == null)
					{
						continue;
					}
					break;
				case 21:
					num15 = 95 + 48;
					num2 = 113;
					continue;
				case 544:
					array[21] = 124;
					num2 = 351;
					continue;
				case 345:
					num26 = 125 + 24;
					num2 = 568;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 606:
					array[3] = (byte)num15;
					num = 673;
					break;
				case 552:
					array12[num36 + 7] = array16[7];
					num2 = 658;
					continue;
				case 66:
					array8[9] = (byte)num25;
					num = 557;
					break;
				case 77:
					_ProcessFacade = intPtr6.ToInt64();
					num = 514;
					break;
				case 502:
					num26 = 37 + 121;
					num2 = 585;
					continue;
				case 538:
					array8[1] = 166;
					num = 400;
					break;
				case 304:
					array18[3] = 106;
					num2 = 144;
					continue;
				case 656:
					array8[15] = (byte)num25;
					num = 301;
					break;
				case 175:
					flag = SortLiteralProc(RunLiteralProc(ListLiteralProc(ValidateLiteralProc(FillLiteralProc())), "__", 10u), IntPtr.Zero);
					num2 = 192;
					continue;
				case 529:
					intPtr6 = RestartNotificationMethod(((object[])PatchNotificationMethod(m_ProducerFacade))[0]);
					num2 = 534;
					continue;
				case 506:
					reference3 = ref *(byte*)null;
					num2 = 371;
					continue;
				case 203:
					PushLiteralProc(new IntPtr(&num42), 0);
					num2 = 5;
					continue;
				case 16:
					if (num31 > 0)
					{
						num2 = 353;
						if (PublishLiteralProc())
						{
							continue;
						}
						break;
					}
					goto case 604;
				case 378:
					_ = IntPtr.Zero;
					num2 = 120;
					continue;
				case 86:
					if (num31 > 0)
					{
						num2 = 152;
						continue;
					}
					goto case 595;
				case 665:
					array[12] = 9;
					num2 = 661;
					continue;
				case 328:
					array[6] = 166;
					num = 636;
					break;
				case 61:
					array8[1] = (byte)num25;
					num2 = 509;
					continue;
				case 566:
					array8[7] = 124;
					num2 = 469;
					continue;
				case 114:
					num26 = 61 + 31;
					num2 = 319;
					continue;
				case 507:
					if (num31 > 0)
					{
						num2 = 178;
						if (DestroyLiteralProc() == null)
						{
							continue;
						}
						break;
					}
					goto case 161;
				case 183:
				case 653:
					if (num48 >= num60)
					{
						num2 = 506;
						if (DestroyLiteralProc() == null)
						{
							continue;
						}
						break;
					}
					goto case 62;
				case 604:
					num45 = 0u;
					num2 = 639;
					continue;
				case 464:
					num40 += 8;
					num2 = 294;
					continue;
				case 439:
					num46++;
					num2 = 356;
					continue;
				case 450:
					array[15] = (byte)num15;
					num2 = 602;
					if (DestroyLiteralProc() == null)
					{
						continue;
					}
					break;
				case 111:
					array[0] = (byte)num15;
					num = 488;
					break;
				case 194:
					if (array7.Length > 0)
					{
						num2 = 669;
						continue;
					}
					goto case 324;
				case 253:
					transform = (ICryptoTransform)ComputeNotificationMethod(symmetricAlgorithm, array17, array10);
					num2 = 600;
					continue;
				case 170:
				case 562:
					ListStub(intPtr, 4, task, ref task);
					num2 = 391;
					if (!PublishLiteralProc())
					{
						num2 = 208;
					}
					continue;
				case 641:
					array[22] = (byte)num26;
					num2 = 426;
					continue;
				case 367:
					if (num29 >= 1879048192)
					{
						num2 = 358;
						continue;
					}
					goto case 519;
				case 580:
					array8[2] = 103;
					num2 = 271;
					continue;
				case 433:
					array[27] = (byte)num26;
					num2 = 68;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 95:
					array8[10] = 95;
					num2 = 617;
					continue;
				case 533:
					array12[num36 + 2] = array20[2];
					num2 = 332;
					if (DestroyLiteralProc() == null)
					{
						continue;
					}
					break;
				case 396:
					array10[11] = array7[5];
					num2 = 588;
					if (DestroyLiteralProc() == null)
					{
						continue;
					}
					break;
				case 527:
					num25 = 61 + 52;
					num2 = 154;
					continue;
				case 85:
					num36 = 2;
					num2 = 309;
					continue;
				case 590:
					num15 = 160 - 53;
					num2 = 96;
					continue;
				case 180:
					array[9] = 154;
					num2 = 496;
					continue;
				case 226:
					array12[num36 + 2] = array13[2];
					num2 = 418;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 584:
					array[10] = 67;
					num2 = 274;
					continue;
				case 382:
					num30 = 0;
					num2 = 89;
					continue;
				case 327:
					array8[1] = 155;
					num2 = 538;
					continue;
				case 412:
					num42 = 0L;
					num2 = 390;
					continue;
				case 353:
					num35++;
					num2 = 604;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 363:
					array[27] = 141;
					num2 = 373;
					continue;
				case 173:
					array12[num36 + 6] = array13[6];
					num2 = 145;
					continue;
				case 164:
				case 169:
					num48 = 0;
					num2 = 653;
					continue;
				case 246:
					if (WriteNotificationMethod(AwakeNotificationMethod(CalcNotificationMethod(typeof(WriterPropertyProducer).TypeHandle).Assembly)) > 0)
					{
						num2 = 1;
						if (DestroyLiteralProc() == null)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 101;
				case 352:
					spec = InstantiateNotificationMethod((uint)item_count, 1, (uint)CreateNotificationMethod(FillLiteralProc()));
					num2 = 676;
					if (DestroyLiteralProc() != null)
					{
						num2 = 28;
					}
					continue;
				case 98:
					array12[num36] = array20[0];
					num2 = 456;
					continue;
				case 275:
					array[5] = 122;
					num2 = 545;
					continue;
				case 638:
					array[7] = 90;
					num2 = 511;
					continue;
				case 136:
					array8[11] = 157;
					num2 = 308;
					if (DestroyLiteralProc() != null)
					{
						num2 = 163;
					}
					continue;
				case 7:
					ExcludeNotificationMethod(stubAuthentication);
					num2 = 218;
					if (DestroyLiteralProc() == null)
					{
						num2 = 651;
					}
					continue;
				case 5:
					ReflectLiteralProc(new IntPtr(&num42), 0);
					num2 = 632;
					continue;
				case 435:
					_StrategyFacade = null;
					num2 = 36;
					continue;
				case 403:
					array[9] = 227;
					num2 = 180;
					if (DestroyLiteralProc() == null)
					{
						continue;
					}
					break;
				case 570:
					array[2] = 95;
					num2 = 618;
					continue;
				case 30:
					symmetricAlgorithm = (SymmetricAlgorithm)SetupNotificationMethod();
					num2 = 65;
					continue;
				case 434:
					array7 = (byte[])StopNotificationMethod(CloneNotificationMethod(m_ProducerFacade));
					num2 = 254;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 634:
					value2 = InvokeNotificationMethod(intPtr5);
					num2 = 587;
					if (DestroyLiteralProc() == null)
					{
						continue;
					}
					break;
				case 211:
					array14 = (byte[])ManageNotificationMethod(memoryStream2);
					num2 = 39;
					if (!PublishLiteralProc())
					{
						num2 = 19;
					}
					continue;
				case 623:
					array[19] = 162;
					num2 = 12;
					if (DestroyLiteralProc() != null)
					{
						num2 = 4;
					}
					continue;
				case 407:
					MapNotificationMethod(spec);
					num2 = 591;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 444:
					num26 = 28 + 8;
					num2 = 53;
					if (!PublishLiteralProc())
					{
						num2 = 14;
					}
					continue;
				case 48:
					array8[6] = (byte)num25;
					num2 = 527;
					continue;
				case 168:
					array[13] = 46;
					num2 = 229;
					continue;
				case 26:
					array8[4] = 87;
					num2 = 635;
					continue;
				case 659:
					num25 = 76 + 30;
					num2 = 66;
					continue;
				case 270:
					num25 = 234 - 78;
					num2 = 620;
					continue;
				case 150:
					array8[4] = 158;
					num2 = 227;
					if (DestroyLiteralProc() == null)
					{
						num2 = 344;
					}
					continue;
				case 83:
					num25 = 156 + 87;
					num2 = 310;
					continue;
				case 561:
					array[28] = 124;
					num2 = 279;
					if (DestroyLiteralProc() == null)
					{
						num2 = 663;
					}
					continue;
				case 651:
					num47 = ResolveNotificationMethod(stubAuthentication);
					num2 = 649;
					continue;
				case 508:
					array[18] = (byte)num26;
					num2 = 593;
					continue;
				case 430:
					RateNotificationMethod(memoryStream2);
					num2 = 299;
					continue;
				case 217:
					if (WriteNotificationMethod(AwakeNotificationMethod(m_ProducerFacade)) != 0)
					{
						num2 = 133;
						if (DestroyLiteralProc() == null)
						{
							continue;
						}
						break;
					}
					goto case 395;
				case 432:
					array21 = (byte[])CollectNotificationMethod(stubAuthentication, (int)ConcatNotificationMethod(FindLiteralProc(stubAuthentication)));
					num2 = 454;
					continue;
				case 497:
					num26 = 191 - 63;
					num2 = 291;
					continue;
				case 204:
					array[17] = (byte)num15;
					num2 = 75;
					if (DestroyLiteralProc() == null)
					{
						continue;
					}
					break;
				case 306:
					RevertLiteralProc(FindLiteralProc(stubAuthentication), 0L);
					num = 432;
					break;
				case 649:
					num44 = ResolveNotificationMethod(stubAuthentication);
					num2 = 531;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 166:
					num39 <<= 8;
					num2 = 464;
					continue;
				case 358:
					attributeFacade = true;
					num2 = 519;
					continue;
				case 106:
					try
					{
						ProcessModuleCollection processModuleCollection2 = (ProcessModuleCollection)SetLiteralProc(literalProc);
						num52 = 0;
						if (DestroyLiteralProc() != null)
						{
							num52 = 0;
						}
						while (true)
						{
							switch (num52)
							{
							case 2:
								try
								{
									while (true)
									{
										IL_45dc:
										if (!AddLiteralProc(enumerator))
										{
											num53 = 1;
											if (DestroyLiteralProc() != null)
											{
												goto IL_44d0;
											}
											goto IL_44d4;
										}
										goto IL_458f;
										IL_44d4:
										while (true)
										{
											switch (num53)
											{
											case 5:
												return;
											case 8:
												VerifyLiteralProc();
												num53 = 2;
												if (DestroyLiteralProc() == null)
												{
													num53 = 5;
												}
												continue;
											case 4:
												num55 = num24;
												intPtr6 = ListLiteralProc(processModule);
												if (num55 >= intPtr6.ToInt64())
												{
													num53 = 0;
													if (PublishLiteralProc())
													{
														num53 = 6;
													}
													continue;
												}
												goto case 7;
											case 7:
												if (!DestroyNotificationMethod(PublishNotificationMethod(CalcNotificationMethod(typeof(WriterPropertyProducer).TypeHandle).Assembly), null))
												{
													num53 = 0;
													if (DestroyLiteralProc() != null)
													{
														num53 = 0;
													}
													continue;
												}
												goto case 8;
											case 9:
												break;
											case 6:
												num54 = num24;
												intPtr6 = ListLiteralProc(processModule);
												if (num54 > intPtr6.ToInt64() + LoginNotificationMethod(processModule))
												{
													num53 = 7;
													continue;
												}
												goto IL_45dc;
											default:
												goto IL_45dc;
											case 3:
												if (ForgotLiteralProc(CallLiteralProc(processModule), text))
												{
													num53 = 4;
													continue;
												}
												goto IL_45dc;
											case 1:
												goto end_IL_45dc;
											}
											break;
										}
										goto IL_458f;
										IL_458f:
										processModule = (ProcessModule)PrepareLiteralProc(enumerator);
										num53 = 3;
										if (!PublishLiteralProc())
										{
											goto IL_44d0;
										}
										goto IL_44d4;
										IL_44d0:
										num53 = num56;
										goto IL_44d4;
										continue;
										end_IL_45dc:
										break;
									}
								}
								finally
								{
									IDisposable disposable = enumerator as IDisposable;
									num57 = 1;
									if (DestroyLiteralProc() != null)
									{
										num57 = 1;
									}
									while (true)
									{
										switch (num57)
										{
										default:
											CustomizeLiteralProc(disposable);
											num57 = 2;
											continue;
										case 1:
											if (disposable != null)
											{
												num57 = 0;
												if (DestroyLiteralProc() == null)
												{
													num57 = 0;
												}
												continue;
											}
											break;
										case 2:
											break;
										}
										break;
									}
								}
								goto end_IL_44aa;
							case 1:
								goto end_IL_44aa;
							}
							enumerator = (IEnumerator)PopLiteralProc(processModuleCollection2);
							num52 = 2;
							continue;
							end_IL_44aa:
							break;
						}
					}
					catch (object obj3)
					{
						num58 = 0;
						if (!PublishLiteralProc())
						{
							num58 = num59;
						}
						switch (num58)
						{
						case 0:
							break;
						}
					}
					goto case 103;
				case 635:
					num25 = 242 - 80;
					num2 = 629;
					continue;
				case 384:
					array12[num33 + 1] = array13[1];
					num2 = 614;
					continue;
				case 92:
					array18[6] = 46;
					num2 = 59;
					if (!PublishLiteralProc())
					{
						num2 = 51;
					}
					continue;
				case 107:
					UpdateLiteralProc(new IntPtr(&num42), 0, 0L);
					num2 = 140;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 258:
					num32 = 0;
					num2 = 490;
					continue;
				case 525:
					num3 += num34;
					num2 = 282;
					continue;
				case 10:
					if (!_PrinterFacade)
					{
						num2 = 9;
						continue;
					}
					goto case 569;
				case 438:
					array[6] = 130;
					num2 = 328;
					if (!PublishLiteralProc())
					{
						num2 = 40;
					}
					continue;
				case 518:
					num15 = 244 - 81;
					num2 = 449;
					continue;
				case 223:
					num24 = 0L;
					num = 498;
					break;
				case 674:
					array[22] = (byte)num26;
					num2 = 42;
					continue;
				case 673:
					array[3] = 111;
					num2 = 114;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 577:
					if (FlushLiteralProc() == 4)
					{
						num2 = 205;
						if (PublishLiteralProc())
						{
							num2 = 560;
						}
						continue;
					}
					goto case 553;
				case 535:
					array[11] = 210;
					num = 603;
					break;
				case 451:
					num15 = 96 - 89;
					num = 47;
					break;
				case 495:
					num51 = 0;
					num2 = 245;
					continue;
				case 539:
					array12[num36 + 6] = array20[6];
					num2 = 523;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 212:
					array8[8] = 147;
					num2 = 491;
					continue;
				case 297:
					array8[3] = (byte)num25;
					num2 = 383;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 349:
					array8[12] = (byte)num25;
					num2 = 323;
					continue;
				case 342:
					array[22] = (byte)num26;
					num2 = 458;
					continue;
				case 163:
					num26 = 86 + 69;
					num = 187;
					break;
				case 97:
					num50 = intPtr6.ToInt64();
					num2 = 153;
					if (DestroyLiteralProc() == null)
					{
						num2 = 201;
					}
					continue;
				case 597:
					array13 = (byte[])GetNotificationMethod(_MethodFacade.ToInt64());
					num2 = 554;
					continue;
				case 351:
					num26 = 163 - 54;
					num2 = 641;
					if (DestroyLiteralProc() == null)
					{
						continue;
					}
					break;
				case 8:
				case 338:
					if (FlushLiteralProc() == 4)
					{
						num2 = 397;
						if (DestroyLiteralProc() == null)
						{
							continue;
						}
						break;
					}
					goto case 85;
				case 470:
					num15 = 131 - 43;
					num2 = 359;
					continue;
				case 555:
					num33 = 16;
					num = 540;
					break;
				case 236:
					array12[num33] = array13[0];
					num2 = 384;
					if (DestroyLiteralProc() == null)
					{
						continue;
					}
					break;
				case 310:
					array8[12] = (byte)num25;
					num2 = 167;
					continue;
				case 224:
					creatorAdapterWatcher = (CreatorAdapterWatcher)ReadNotificationMethod(config, CalcNotificationMethod(typeof(CreatorAdapterWatcher).TypeHandle));
					num2 = 6;
					continue;
				case 564:
					num26 = 140 - 46;
					num2 = 508;
					continue;
				case 239:
					array12[num36 + 5] = array16[5];
					num2 = 165;
					continue;
				case 216:
					array8[0] = 147;
					num2 = 608;
					continue;
				case 265:
					ListStub(intPtr, 4, 4, ref task);
					num2 = 577;
					continue;
				case 332:
					array12[num36 + 3] = array20[3];
					num2 = 366;
					continue;
				case 286:
					array8[9] = (byte)num25;
					num2 = 659;
					continue;
				case 397:
					num33 = 9;
					num2 = 236;
					continue;
				case 339:
					array[11] = 19;
					num2 = 67;
					if (DestroyLiteralProc() == null)
					{
						continue;
					}
					break;
				case 355:
					array[29] = 162;
					num2 = 546;
					continue;
				case 18:
					num15 = 191 - 63;
					num2 = 91;
					continue;
				case 341:
					array[17] = 204;
					num2 = 564;
					continue;
				case 323:
					num25 = 217 - 72;
					num2 = 475;
					if (!PublishLiteralProc())
					{
						num2 = 330;
					}
					continue;
				case 317:
					array8[3] = (byte)num25;
					num2 = 151;
					continue;
				case 534:
					roleFacade = intPtr6.ToInt64();
					num2 = 273;
					continue;
				case 104:
					exporterFacade2 = default(ExporterFacade);
					num2 = 405;
					continue;
				case 302:
					intPtr3 = CollectStub(text);
					num2 = 179;
					continue;
				case 610:
					array12[num33 + 2] = array20[2];
					num = 49;
					break;
				case 605:
					num15 = 63 + 60;
					num2 = 424;
					if (DestroyLiteralProc() == null)
					{
						continue;
					}
					break;
				case 428:
					num25 = 209 - 69;
					num2 = 571;
					continue;
				case 231:
					array[24] = 165;
					num2 = 72;
					continue;
				case 669:
					array10[1] = array7[0];
					num2 = 624;
					continue;
				case 290:
					array8[4] = (byte)num25;
					num2 = 26;
					if (DestroyLiteralProc() != null)
					{
						num2 = 9;
					}
					continue;
				case 281:
				case 374:
					if (num49 >= num47)
					{
						num2 = 248;
						if (DestroyLiteralProc() == null)
						{
							num2 = 637;
						}
						continue;
					}
					goto case 343;
				case 43:
					array12[num36 + 4] = array16[4];
					num2 = 239;
					continue;
				case 595:
					num45 = (uint)num27;
					num2 = 525;
					if (!PublishLiteralProc())
					{
						num2 = 154;
					}
					continue;
				case 238:
					num36 = 30;
					num2 = 381;
					if (DestroyLiteralProc() == null)
					{
						continue;
					}
					break;
				case 503:
					array[4] = 171;
					num2 = 436;
					if (PublishLiteralProc())
					{
						num2 = 611;
					}
					continue;
				case 453:
					num25 = 148 - 49;
					num2 = 250;
					continue;
				case 82:
					num15 = 115 + 41;
					num2 = 156;
					continue;
				case 272:
					array8[7] = (byte)num25;
					num2 = 429;
					continue;
				case 609:
					array8[10] = 106;
					num2 = 95;
					continue;
				case 647:
					array[1] = (byte)num26;
					num2 = 677;
					continue;
				case 421:
					array8[14] = (byte)num25;
					num2 = 31;
					if (PublishLiteralProc())
					{
						num2 = 218;
					}
					continue;
				case 287:
					array11[5] = 116;
					num2 = 159;
					continue;
				case 541:
					array8[5] = 222;
					num2 = 625;
					continue;
				case 293:
					array8[0] = 147;
					num = 216;
					break;
				case 73:
					num48++;
					num2 = 91;
					if (DestroyLiteralProc() == null)
					{
						num2 = 183;
					}
					continue;
				case 365:
					array20 = (byte[])GetNotificationMethod(num24);
					num2 = 8;
					continue;
				case 145:
					array12[num36 + 7] = array13[7];
					num2 = 579;
					continue;
				case 268:
					num25 = 43 + 94;
					num2 = 230;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 291:
					array[5] = (byte)num26;
					num2 = 275;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 209:
					num37 = 0u;
					num2 = 307;
					continue;
				case 105:
				case 386:
					while (true)
					{
						IL_4f85:
						fixed (byte* ptr = &array5[0])
						{
							num2 = 164;
							if (DestroyLiteralProc() != null)
							{
								goto IL_000e_2;
							}
							goto IL_0012_2;
							IL_000e_2:
							num2 = num;
							goto IL_0012_2;
							IL_0012_2:
							while (true)
							{
								switch (num2)
								{
								case 197:
									goto end_IL_0012;
								case 220:
									array[14] = (byte)num15;
									num2 = 155;
									continue;
								case 249:
									VerifyLiteralProc();
									num2 = 379;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 76:
								case 133:
									num47 = ResolveNotificationMethod(stubAuthentication);
									num2 = 537;
									continue;
								case 442:
									array[14] = 122;
									num2 = 208;
									continue;
								case 179:
								case 516:
									array11 = new byte[6];
									num2 = 195;
									continue;
								case 528:
									num15 = 79 + 66;
									num2 = 377;
									continue;
								case 366:
									array12[num36 + 4] = array20[4];
									num2 = 276;
									if (DestroyLiteralProc() != null)
									{
										num2 = 132;
									}
									continue;
								case 360:
									num79 = array17.Length / 4;
									num2 = 388;
									continue;
								case 57:
									array18[0] = 99;
									num2 = 364;
									if (DestroyLiteralProc() != null)
									{
										num2 = 354;
									}
									continue;
								case 148:
									array18[7] = 116;
									num2 = 331;
									continue;
								case 571:
									array8[11] = (byte)num25;
									num = 136;
									break;
								case 459:
									ident = new IntPtr(roleFacade + num62 - num51);
									num2 = 361;
									continue;
								case 383:
									num25 = 169 - 56;
									num2 = 485;
									continue;
								case 455:
									exporterFacade2.m_AttributeFacade = false;
									num2 = 283;
									if (!PublishLiteralProc())
									{
										num2 = 256;
									}
									continue;
								case 20:
									array[20] = 102;
									num = 21;
									break;
								case 261:
									processModuleCollection = (ProcessModuleCollection)SetLiteralProc(FillLiteralProc());
									num2 = 37;
									continue;
								case 90:
									num34 = 0u;
									num2 = 575;
									if (DestroyLiteralProc() == null)
									{
										continue;
									}
									break;
								case 113:
									array[20] = (byte)num15;
									num2 = 256;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 452:
									if (FlushLiteralProc() != 4)
									{
										num2 = 336;
										if (PublishLiteralProc())
										{
											continue;
										}
										break;
									}
									goto case 393;
								case 655:
									array[16] = 143;
									num = 423;
									break;
								case 512:
									array8[14] = 115;
									num2 = 206;
									continue;
								case 325:
									num25 = 146 + 101;
									num2 = 317;
									if (DestroyLiteralProc() == null)
									{
										continue;
									}
									break;
								case 87:
									ListStub(new IntPtr(value2), FlushLiteralProc(), task2, ref task2);
									num2 = 569;
									continue;
								case 225:
									num15 = 11 + 58;
									num2 = 586;
									continue;
								case 278:
									array[4] = (byte)num26;
									num2 = 503;
									continue;
								case 633:
									text = (string)StartNotificationMethod(DefineNotificationMethod(), array18);
									num2 = 4;
									if (DestroyLiteralProc() == null)
									{
										continue;
									}
									break;
								case 540:
									array12[num33] = array20[0];
									num2 = 406;
									if (DestroyLiteralProc() == null)
									{
										continue;
									}
									break;
								case 232:
								case 466:
									num61++;
									num2 = 474;
									if (DestroyLiteralProc() != null)
									{
										num2 = 159;
									}
									continue;
								case 50:
									array18[1] = 115;
									num2 = 472;
									if (DestroyLiteralProc() == null)
									{
										continue;
									}
									break;
								case 144:
									array18[4] = 105;
									num2 = 558;
									continue;
								case 394:
									array18[3] = 111;
									num2 = 420;
									if (DestroyLiteralProc() != null)
									{
										num2 = 200;
									}
									continue;
								case 491:
									num25 = 67 + 54;
									num2 = 385;
									continue;
								case 616:
									array18[9] = 108;
									num2 = 213;
									if (!PublishLiteralProc())
									{
										num2 = 101;
									}
									continue;
								case 288:
									num26 = 138 - 46;
									num2 = 108;
									continue;
								case 678:
									array[8] = (byte)num26;
									num2 = 403;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 39:
									NewNotificationMethod(array10, 0, array10.Length);
									num2 = 430;
									continue;
								case 300:
									intPtr = new IntPtr(roleFacade + ResolveNotificationMethod(stubAuthentication) - num51);
									num = 265;
									break;
								case 51:
									array[1] = 138;
									num = 202;
									break;
								case 190:
									array8[5] = (byte)num25;
									num2 = 541;
									continue;
								case 178:
									num38 = num3 ^ num37;
									num2 = 382;
									continue;
								case 307:
									num41 = 0;
									num2 = 489;
									if (!PublishLiteralProc())
									{
										num2 = 488;
									}
									continue;
								case 182:
									array[29] = (byte)num15;
									num2 = 121;
									if (PublishLiteralProc())
									{
										num2 = 198;
									}
									continue;
								case 461:
									ListStub(new IntPtr(value2), FlushLiteralProc(), 64, ref task2);
									num2 = 40;
									if (DestroyLiteralProc() == null)
									{
										num2 = 45;
									}
									continue;
								case 359:
									array[7] = (byte)num15;
									num2 = 638;
									if (!PublishLiteralProc())
									{
										num2 = 187;
									}
									continue;
								case 3:
									num26 = 40 - 13;
									num2 = 411;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 574:
									num80 = num61 % num79;
									num2 = 445;
									continue;
								case 486:
									array8[11] = (byte)num25;
									num2 = 0;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 417:
									array[4] = (byte)num15;
									num2 = 33;
									continue;
								case 237:
									array9[num27 + 3] = (byte)((num28 & 0xFF000000u) >> 24);
									num2 = 232;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 134:
									exporterFacade.m_ProcFacade = procFacade;
									num2 = 158;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 279:
									array12[num33 + 3] = array13[3];
									num2 = 555;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 336:
									array22 = new byte[40];
									ListNotificationMethod(array22, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
									array3 = array22;
									num2 = 329;
									continue;
								case 520:
									num62 = ResolveNotificationMethod(stubAuthentication);
									num2 = 459;
									continue;
								case 103:
									try
									{
										ProcessModuleCollection processModuleCollection3 = (ProcessModuleCollection)SetLiteralProc(literalProc);
										num63 = 2;
										if (DestroyLiteralProc() != null)
										{
											num63 = 0;
										}
										while (true)
										{
											switch (num63)
											{
											case 1:
												try
												{
													while (true)
													{
														IL_11cd_2:
														if (!AddLiteralProc(enumerator))
														{
															num64 = 6;
															if (DestroyLiteralProc() != null)
															{
																num64 = 0;
															}
															goto IL_1145_3;
														}
														goto IL_11b5_2;
														IL_11b5_2:
														processModule2 = (ProcessModule)PrepareLiteralProc(enumerator);
														num64 = 3;
														goto IL_1145_3;
														IL_1145_3:
														while (true)
														{
															switch (num64)
															{
															case 4:
																num51 = 0;
																num64 = 2;
																continue;
															case 2:
																break;
															case 3:
																intPtr6 = ListLiteralProc(processModule2);
																num64 = 4;
																if (PublishLiteralProc())
																{
																	num64 = 5;
																}
																continue;
															default:
																goto IL_11b5_2;
															case 1:
																goto IL_11cd_2;
															case 5:
																if (intPtr6.ToInt64() == _ProcessFacade)
																{
																	num64 = 4;
																	continue;
																}
																goto IL_11cd_2;
															case 6:
																break;
															}
															break;
														}
														break;
													}
												}
												finally
												{
													IDisposable disposable = enumerator as IDisposable;
													num65 = 0;
													if (DestroyLiteralProc() != null)
													{
														goto IL_1231_2;
													}
													goto IL_1235_3;
													IL_1235_3:
													while (true)
													{
														switch (num65)
														{
														case 1:
															CustomizeLiteralProc(disposable);
															num65 = 2;
															continue;
														default:
															if (disposable != null)
															{
																num65 = 1;
																if (DestroyLiteralProc() == null)
																{
																	continue;
																}
																break;
															}
															goto end_IL_1235_2;
														case 2:
															goto end_IL_1235_2;
														}
														goto IL_1231_2;
														continue;
														end_IL_1235_2:
														break;
													}
													goto end_IL_1213_2;
													IL_1231_2:
													num65 = num66;
													goto IL_1235_3;
													end_IL_1213_2:;
												}
												break;
											case 2:
												enumerator = (IEnumerator)PopLiteralProc(processModuleCollection3);
												num63 = 1;
												if (DestroyLiteralProc() == null)
												{
													num63 = 1;
												}
												continue;
											case 0:
												break;
											}
											break;
										}
									}
									catch (object obj4)
									{
										num67 = 0;
										if (DestroyLiteralProc() != null)
										{
											num67 = num68;
										}
										switch (num67)
										{
										case 0:
											break;
										}
									}
									goto case 435;
								case 558:
									array18[5] = 116;
									num = 92;
									break;
								case 25:
									array[20] = (byte)num15;
									num2 = 32;
									continue;
								case 648:
									intPtr6 = RestartNotificationMethod(((object[])PatchNotificationMethod(CalcNotificationMethod(typeof(WriterPropertyProducer).TypeHandle).Assembly))[0]);
									num2 = 77;
									continue;
								case 480:
									array18[2] = 114;
									num2 = 304;
									continue;
								case 303:
									array12[num36 + 1] = array13[1];
									num2 = 226;
									continue;
								case 545:
									num15 = 105 + 100;
									num2 = 596;
									continue;
								case 271:
									num25 = 217 - 72;
									num = 297;
									break;
								case 523:
									array12[num36 + 7] = array20[7];
									num2 = 238;
									continue;
								case 583:
									num26 = 19 + 31;
									num2 = 248;
									continue;
								case 423:
									num15 = 183 - 61;
									num2 = 501;
									if (DestroyLiteralProc() != null)
									{
										num2 = 316;
									}
									continue;
								case 320:
									if (num61 == num35 - 1)
									{
										num = 86;
										break;
									}
									goto case 595;
								case 624:
									array10[3] = array7[1];
									num2 = 660;
									if (DestroyLiteralProc() == null)
									{
										continue;
									}
									break;
								case 311:
									array8[4] = (byte)num25;
									num2 = 268;
									continue;
								case 579:
									num36 = 18;
									num2 = 98;
									if (DestroyLiteralProc() == null)
									{
										continue;
									}
									break;
								case 448:
									num26 = 15 + 32;
									num2 = 631;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 402:
									array18[6] = 105;
									num2 = 148;
									continue;
								case 475:
									array8[12] = (byte)num25;
									num2 = 83;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 264:
									array[26] = (byte)num26;
									num2 = 627;
									continue;
								case 35:
									num25 = 15 + 1;
									num2 = 79;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 316:
									num15 = 2 + 100;
									num2 = 606;
									continue;
								case 69:
									num31 = array19.Length % 4;
									num2 = 269;
									continue;
								case 154:
									array8[6] = (byte)num25;
									num2 = 125;
									continue;
								case 405:
									reference2 = ref exporterFacade2;
									array5 = new byte[1] { 42 };
									reference2.m_ProcFacade = array5;
									num2 = 455;
									continue;
								case 608:
									array8[1] = 97;
									num2 = 78;
									continue;
								case 337:
									array[30] = (byte)num15;
									num2 = 3;
									if (DestroyLiteralProc() == null)
									{
										continue;
									}
									break;
								case 27:
									array8[13] = 52;
									num2 = 188;
									continue;
								case 29:
									num40 = 0;
									num2 = 320;
									continue;
								case 380:
									item_count = (MemberModifier)56;
									num2 = 352;
									continue;
								case 186:
									ListStub(ident, num43 * 4, task, ref task);
									num2 = 28;
									continue;
								case 427:
									ListStub(ident, num43 * 4, 4, ref task);
									num2 = 258;
									continue;
								case 536:
									array[23] = (byte)num15;
									num2 = 128;
									if (PublishLiteralProc())
									{
										num2 = 255;
									}
									continue;
								case 530:
									num15 = 71 + 26;
									num2 = 204;
									continue;
								case 274:
									num26 = 80 + 76;
									num2 = 162;
									continue;
								case 156:
									array[2] = (byte)num15;
									num2 = 570;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 53:
									array[8] = (byte)num26;
									num2 = 532;
									continue;
								case 243:
									array8[9] = 140;
									num2 = 260;
									if (!PublishLiteralProc())
									{
										num2 = 130;
									}
									continue;
								case 273:
									second = IntPtr.Zero;
									num = 196;
									break;
								case 4:
									intPtr3 = CollectStub(text);
									num2 = 326;
									continue;
								case 619:
									array9 = new byte[array19.Length];
									num2 = 360;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 373:
									num15 = 94 + 70;
									num2 = 284;
									continue;
								case 122:
									array18[10] = 108;
									num2 = 621;
									continue;
								case 205:
									array8[14] = (byte)num25;
									num2 = 138;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 28:
								case 127:
									if (OrderNotificationMethod(FindLiteralProc(stubAuthentication)) < ConcatNotificationMethod(FindLiteralProc(stubAuthentication)) - 1)
									{
										num2 = 520;
										continue;
									}
									goto case 407;
								case 315:
									num26 = 219 - 73;
									num2 = 585;
									if (PublishLiteralProc())
									{
										num2 = 645;
									}
									continue;
								case 89:
								case 389:
									if (num30 >= num31)
									{
										num2 = 466;
										continue;
									}
									goto case 431;
								case 398:
									array[13] = 169;
									num = 168;
									break;
								case 294:
									array9[num27 + num30] = (byte)((num38 & num39) >> num40);
									num2 = 322;
									continue;
								case 219:
									NewNotificationMethod(array7, 0, array7.Length);
									num2 = 324;
									if (DestroyLiteralProc() == null)
									{
										continue;
									}
									break;
								case 602:
									array[15] = 55;
									num2 = 436;
									if (!PublishLiteralProc())
									{
										num2 = 403;
									}
									continue;
								case 101:
								case 139:
								case 440:
									try
									{
										object obj = DeleteNotificationMethod(UpdateNotificationMethod(MoveNotificationMethod(CancelNotificationMethod(CalcNotificationMethod(typeof(WriterPropertyProducer).TypeHandle).Assembly))).GetField("m_ptr", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic), MoveNotificationMethod(CancelNotificationMethod(CalcNotificationMethod(typeof(WriterPropertyProducer).TypeHandle).Assembly)));
										num16 = 17;
										if (!PublishLiteralProc())
										{
											goto IL_1904_2;
										}
										goto IL_1908_3;
										IL_1908_3:
										while (true)
										{
											switch (num16)
											{
											case 12:
											case 15:
												ChangeNotificationMethod(memoryStream, new byte[FlushLiteralProc()], 0, FlushLiteralProc());
												num16 = 13;
												continue;
											case 5:
												_MethodFacade = (IntPtr)DeleteNotificationMethod(obj.GetType().GetField("m_pData", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic), obj);
												num16 = 8;
												continue;
											default:
												ChangeNotificationMethod(memoryStream, new byte[FlushLiteralProc()], 0, FlushLiteralProc());
												num16 = 16;
												continue;
											case 13:
												ChangeNotificationMethod(memoryStream, new byte[FlushLiteralProc()], 0, FlushLiteralProc());
												num16 = 2;
												continue;
											case 9:
												array4 = (byte[])ManageNotificationMethod(memoryStream);
												num16 = 18;
												if (DestroyLiteralProc() == null)
												{
													continue;
												}
												break;
											case 16:
												if (FlushLiteralProc() == 4)
												{
													num16 = 4;
													if (DestroyLiteralProc() == null)
													{
														continue;
													}
													break;
												}
												goto case 3;
											case 2:
												RevertLiteralProc(memoryStream, 0L);
												num16 = 9;
												continue;
											case 1:
												nativeSizeOfCode = 0u;
												num16 = 10;
												continue;
											case 10:
												try
												{
													array6 = (array5 = array4);
													if (array6 == null)
													{
														num17 = 2;
														if (DestroyLiteralProc() != null)
														{
															goto IL_1a7c_2;
														}
														goto IL_1a80_4;
													}
													goto IL_1b11_2;
													IL_1a80_4:
													while (true)
													{
														switch (num17)
														{
														case 3:
														case 4:
															_CustomerFacade(new IntPtr(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference)), new IntPtr(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference)), new IntPtr(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference)), 216669565u, new IntPtr(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference)), ref nativeSizeOfCode);
															num17 = 0;
															if (DestroyLiteralProc() != null)
															{
																num17 = 0;
															}
															continue;
														case 6:
															goto IL_1b11_2;
														case 1:
														case 2:
															goto IL_1b2f_2;
														case 5:
															goto IL_1b57_3;
														case 0:
															break;
														}
														break;
													}
													goto end_IL_1a5d_2;
													IL_1b11_2:
													if (array5.Length == 0)
													{
														num17 = 1;
														if (!PublishLiteralProc())
														{
															goto IL_1a7c_2;
														}
														goto IL_1a80_4;
													}
													goto IL_1b57_3;
													IL_1b2f_2:
													reference = ref *(byte*)null;
													num17 = 3;
													goto IL_1a80_4;
													IL_1a7c_2:
													num17 = num18;
													goto IL_1a80_4;
													IL_1b57_3:
													while (true)
													{
														fixed (byte* value = &array5[0])
														{
															num17 = 4;
															while (true)
															{
																switch (num17)
																{
																case 5:
																	break;
																default:
																	goto end_IL_1b57_2;
																case 3:
																case 4:
																	_CustomerFacade(new IntPtr(value), new IntPtr(value), new IntPtr(value), 216669565u, new IntPtr(value), ref nativeSizeOfCode);
																	num17 = 0;
																	if (DestroyLiteralProc() != null)
																	{
																		num17 = 0;
																	}
																	continue;
																case 6:
																	if (array5.Length == 0)
																	{
																		num17 = 1;
																		if (!PublishLiteralProc())
																		{
																			num17 = num18;
																		}
																		continue;
																	}
																	break;
																case 1:
																case 2:
																	goto IL_1b2f_2;
																case 0:
																	goto end_IL_1b57_2;
																}
																break;
															}
														}
														continue;
														end_IL_1b57_2:
														break;
													}
													end_IL_1a5d_2:;
												}
												finally
												{
													reference = ref *(byte*)null;
													num19 = 0;
													if (DestroyLiteralProc() != null)
													{
														num19 = num20;
													}
													switch (num19)
													{
													case 0:
														break;
													}
												}
												goto end_IL_1908_2;
											case 3:
												ChangeNotificationMethod(memoryStream, GetNotificationMethod(_MethodFacade.ToInt64()), 0, 8);
												num16 = 15;
												continue;
											case 7:
											case 8:
												memoryStream = new MemoryStream();
												num16 = 0;
												if (DestroyLiteralProc() == null)
												{
													num16 = 0;
												}
												continue;
											case 18:
												RateNotificationMethod(memoryStream);
												num16 = 1;
												if (!PublishLiteralProc())
												{
													num16 = 0;
												}
												continue;
											case 11:
												if (!ForgotLiteralProc(obj.GetType().ToString(), "System.Reflection.RuntimeModule"))
												{
													num16 = 7;
													if (PublishLiteralProc())
													{
														continue;
													}
													break;
												}
												goto case 5;
											case 4:
												ChangeNotificationMethod(memoryStream, InterruptNotificationMethod(_MethodFacade.ToInt32()), 0, 4);
												num16 = 12;
												if (DestroyLiteralProc() != null)
												{
													num16 = 2;
												}
												continue;
											case 17:
												if (obj is IntPtr)
												{
													num16 = 14;
													continue;
												}
												goto case 11;
											case 14:
												_MethodFacade = (IntPtr)obj;
												num16 = 11;
												continue;
											case 6:
												goto end_IL_1908_2;
											}
											goto IL_1904_2;
											continue;
											end_IL_1908_2:
											break;
										}
										goto end_IL_189b_2;
										IL_1904_2:
										num16 = num21;
										goto IL_1908_3;
										end_IL_189b_2:;
									}
									catch (object obj2)
									{
										num22 = 0;
										if (DestroyLiteralProc() != null)
										{
											num22 = num23;
										}
										switch (num22)
										{
										case 0:
											break;
										}
									}
									goto case 71;
								case 55:
									num24 = InvokeNotificationMethod(new IntPtr(value2));
									num2 = 241;
									continue;
								case 91:
									array[23] = (byte)num15;
									num2 = 549;
									if (DestroyLiteralProc() != null)
									{
										num2 = 292;
									}
									continue;
								case 65:
									LogoutNotificationMethod(symmetricAlgorithm, CipherMode.CBC);
									num2 = 253;
									if (DestroyLiteralProc() != null)
									{
										num2 = 236;
									}
									continue;
								case 81:
									if (((Array)ReflectNotificationMethod(PublishNotificationMethod(CalcNotificationMethod(typeof(WriterPropertyProducer).TypeHandle).Assembly))).Length == 2)
									{
										num2 = 70;
										if (DestroyLiteralProc() == null)
										{
											num2 = 668;
										}
										continue;
									}
									goto case 101;
								case 319:
									array[4] = (byte)num26;
									num2 = 124;
									continue;
								case 221:
									array[29] = (byte)num15;
									num2 = 266;
									continue;
								case 93:
									array[25] = (byte)num26;
									num2 = 244;
									continue;
								case 388:
									num3 = 0u;
									num2 = 90;
									if (DestroyLiteralProc() == null)
									{
										continue;
									}
									break;
								case 627:
									array[26] = 231;
									num2 = 19;
									continue;
								case 456:
									array12[num36 + 1] = array20[1];
									num2 = 533;
									if (!PublishLiteralProc())
									{
										num2 = 329;
									}
									continue;
								case 331:
									array18[8] = 46;
									num2 = 181;
									if (DestroyLiteralProc() == null)
									{
										continue;
									}
									break;
								case 115:
									array8[7] = (byte)num25;
									num2 = 413;
									continue;
								case 431:
									if (num30 > 0)
									{
										num2 = 166;
										if (DestroyLiteralProc() == null)
										{
											continue;
										}
										break;
									}
									goto case 294;
								case 301:
									array10 = array8;
									num2 = 52;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 393:
									array2 = new byte[30];
									ListNotificationMethod(array2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
									array3 = array2;
									num2 = 267;
									continue;
								case 165:
									array12[num36 + 6] = array16[6];
									num2 = 552;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 121:
									array14 = array9;
									num2 = 202;
									if (DestroyLiteralProc() == null)
									{
										num2 = 565;
									}
									continue;
								case 510:
									array[23] = (byte)num15;
									num2 = 231;
									continue;
								case 542:
									num15 = 140 - 46;
									num2 = 657;
									continue;
								case 52:
									IncludeNotificationMethod(array10);
									num2 = 434;
									if (DestroyLiteralProc() != null)
									{
										num2 = 34;
									}
									continue;
								case 326:
									if (!EnableNotificationMethod(intPtr3, IntPtr.Zero))
									{
										num2 = 516;
										continue;
									}
									goto case 184;
								case 41:
								case 346:
									num3 = num3;
									num2 = 494;
									continue;
								case 321:
									AssetNotificationMethod(_CustomerFacade);
									num2 = 615;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 284:
									array[28] = (byte)num15;
									num2 = 448;
									continue;
								case 192:
									if (flag)
									{
										num = 504;
										break;
									}
									goto case 249;
								case 549:
									num15 = 190 + 54;
									num2 = 510;
									if (DestroyLiteralProc() == null)
									{
										continue;
									}
									break;
								case 551:
									array[1] = 146;
									num2 = 315;
									continue;
								case 34:
								case 262:
									if (num78 >= num47)
									{
										num2 = 127;
										continue;
									}
									goto case 300;
								case 196:
									num78 = 0;
									num = 34;
									break;
								case 242:
									array10[15] = array7[7];
									num2 = 219;
									if (DestroyLiteralProc() != null)
									{
										num2 = 217;
									}
									continue;
								case 568:
									array[0] = (byte)num26;
									num2 = 51;
									if (DestroyLiteralProc() == null)
									{
										continue;
									}
									break;
								case 546:
									array[30] = 127;
									num2 = 210;
									continue;
								case 586:
									array[15] = (byte)num15;
									num2 = 354;
									continue;
								case 59:
									array18[7] = 100;
									num2 = 207;
									continue;
								case 467:
									array[3] = 192;
									num2 = 547;
									continue;
								case 585:
									array[19] = (byte)num26;
									num2 = 623;
									continue;
								case 354:
									num26 = 69 + 103;
									num2 = 128;
									continue;
								case 13:
									if (num44 == 4)
									{
										num = 30;
										break;
									}
									goto case 531;
								case 629:
									array8[4] = (byte)num25;
									num2 = 150;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 640:
									array8[15] = 105;
									num2 = 46;
									if (DestroyLiteralProc() == null)
									{
										continue;
									}
									break;
								case 185:
									num15 = 95 + 115;
									num2 = 417;
									continue;
								case 172:
									array18[5] = 106;
									num2 = 402;
									if (DestroyLiteralProc() == null)
									{
										continue;
									}
									break;
								case 569:
									VerifyLiteralProc();
									num2 = 292;
									continue;
								case 572:
									array[18] = (byte)num26;
									num = 479;
									break;
								case 599:
									num15 = 168 - 56;
									num = 305;
									break;
								case 247:
									array8[1] = (byte)num25;
									num2 = 35;
									continue;
								case 78:
									num25 = 38 + 39;
									num2 = 61;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 496:
									array[9] = 17;
									num2 = 94;
									if (DestroyLiteralProc() == null)
									{
										continue;
									}
									break;
								case 38:
									num81 = ResolveNotificationMethod(stubAuthentication) - num51;
									num2 = 628;
									continue;
								case 151:
									num25 = 52 + 0;
									num = 290;
									break;
								case 256:
									array[20] = 147;
									num2 = 622;
									continue;
								case 64:
									num26 = 60 + 68;
									num2 = 647;
									continue;
								case 22:
									RevertLiteralProc(FindLiteralProc(stubAuthentication), 0L);
									num2 = 607;
									continue;
								case 117:
									num25 = 162 - 54;
									num2 = 672;
									continue;
								case 472:
									array18[2] = 99;
									num2 = 394;
									continue;
								case 233:
									num25 = 230 - 76;
									num2 = 349;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 409:
									ListStub(intPtr7, 4, task, ref task);
									num = 153;
									break;
								case 661:
									num26 = 221 - 73;
									num2 = 157;
									if (DestroyLiteralProc() == null)
									{
										continue;
									}
									break;
								case 79:
									array8[2] = (byte)num25;
									num2 = 399;
									continue;
								case 492:
									array[0] = 123;
									num2 = 487;
									continue;
								case 80:
									array8[8] = 152;
									num2 = 212;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 415:
									CountNotificationMethod(intPtr7, ResolveNotificationMethod(stubAuthentication));
									num2 = 409;
									continue;
								case 67:
									array[11] = 118;
									num = 535;
									break;
								case 413:
									num25 = 6 + 89;
									num2 = 272;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 335:
									num39 = 255u;
									num2 = 29;
									continue;
								case 153:
									num49++;
									num2 = 281;
									continue;
								case 437:
									array[31] = 148;
									num2 = 119;
									if (DestroyLiteralProc() == null)
									{
										continue;
									}
									break;
								case 483:
									array[10] = (byte)num15;
									num2 = 513;
									continue;
								case 84:
									array[19] = (byte)num26;
									num2 = 143;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 157:
									array[13] = (byte)num26;
									num2 = 398;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 565:
									num60 = array14.Length / 8;
									num2 = 387;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 263:
									try
									{
										while (true)
										{
											if (!AddLiteralProc(enumerator))
											{
												num83 = 9;
												goto IL_2537_3;
											}
											goto IL_2653_2;
											IL_2533_2:
											num83 = num84;
											goto IL_2537_3;
											IL_2653_2:
											processModule3 = (ProcessModule)PrepareLiteralProc(enumerator);
											num83 = 7;
											if (DestroyLiteralProc() != null)
											{
												goto IL_2533_2;
											}
											goto IL_2537_3;
											IL_2537_3:
											while (true)
											{
												switch (num83)
												{
												case 11:
													break;
												case 3:
													if (ConnectLiteralProc(version, version3))
													{
														num83 = 4;
														continue;
													}
													goto end_IL_2537_2;
												case 6:
												case 10:
													goto end_IL_2537_2;
												case 2:
													version3 = new Version(4, 0, 30319, 17020);
													num83 = 8;
													continue;
												case 5:
													goto end_IL_25a4_2;
												case 8:
													version2 = new Version(4, 0, 30319, 17921);
													num83 = 3;
													continue;
												case 1:
													version = new Version(CompareLiteralProc(TestLiteralProc(processModule3)), VisitLiteralProc(TestLiteralProc(processModule3)), ViewLiteralProc(TestLiteralProc(processModule3)), SearchLiteralProc(TestLiteralProc(processModule3)));
													num83 = 2;
													continue;
												default:
													goto IL_2653_2;
												case 7:
													goto IL_2676_2;
												case 4:
													if (!QueryLiteralProc(version, version2))
													{
														num83 = 10;
														if (DestroyLiteralProc() != null)
														{
															num83 = 1;
														}
														continue;
													}
													break;
												case 9:
													goto end_IL_25a4_2;
												}
												schemaFacade = true;
												num83 = 5;
												if (DestroyLiteralProc() == null)
												{
													continue;
												}
												goto IL_2533_2;
												IL_2676_2:
												if (!ForgotLiteralProc(CheckLiteralProc(CallLiteralProc(processModule3)), "clrjit.dll"))
												{
													break;
												}
												num83 = 1;
												if (PublishLiteralProc())
												{
													continue;
												}
												goto IL_2533_2;
												continue;
												end_IL_2537_2:
												break;
											}
											continue;
											end_IL_25a4_2:
											break;
										}
									}
									finally
									{
										IDisposable disposable = enumerator as IDisposable;
										num85 = 2;
										while (true)
										{
											switch (num85)
											{
											default:
												CustomizeLiteralProc(disposable);
												num85 = 1;
												if (DestroyLiteralProc() != null)
												{
													num85 = 0;
												}
												continue;
											case 2:
												if (disposable != null)
												{
													num85 = 0;
													if (!PublishLiteralProc())
													{
														num85 = num86;
													}
													continue;
												}
												break;
											case 1:
												break;
											}
											break;
										}
									}
									goto case 215;
								case 120:
									task2 = 0;
									num2 = 2;
									if (DestroyLiteralProc() == null)
									{
										num2 = 2;
									}
									continue;
								case 174:
									memoryStream2 = new MemoryStream();
									num = 416;
									break;
								case 171:
									array11[4] = 105;
									num2 = 287;
									continue;
								case 162:
									array[11] = (byte)num26;
									num2 = 227;
									continue;
								case 505:
									num26 = 195 - 65;
									num2 = 193;
									if (PublishLiteralProc())
									{
										num2 = 264;
									}
									continue;
								case 195:
									array11[0] = 103;
									num2 = 4;
									if (DestroyLiteralProc() == null)
									{
										num2 = 118;
									}
									continue;
								case 132:
									array[25] = (byte)num26;
									num2 = 200;
									if (DestroyLiteralProc() == null)
									{
										continue;
									}
									break;
								case 449:
									array[8] = (byte)num15;
									num2 = 654;
									if (DestroyLiteralProc() == null)
									{
										continue;
									}
									break;
								case 513:
									array[10] = 98;
									num2 = 163;
									continue;
								case 372:
									if (num41 > 0)
									{
										num2 = 314;
										continue;
									}
									goto case 60;
								case 447:
									num15 = 154 - 51;
									num2 = 522;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 244:
									array[26] = 51;
									num2 = 505;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 514:
									if (FlushLiteralProc() == 4)
									{
										num = 312;
										break;
									}
									goto case 70;
								case 443:
									num25 = 104 + 35;
									num = 286;
									break;
								case 257:
									value2 = PrintNotificationMethod(intPtr5);
									num2 = 40;
									continue;
								case 330:
									if (num69 == 4109628145u)
									{
										num2 = 175;
										if (PublishLiteralProc())
										{
											continue;
										}
										break;
									}
									goto case 504;
								case 118:
									array11[1] = 101;
									num2 = 419;
									continue;
								case 176:
									array[5] = (byte)num26;
									num2 = 497;
									if (DestroyLiteralProc() == null)
									{
										continue;
									}
									break;
								case 161:
									num28 = num3 ^ num37;
									num2 = 612;
									continue;
								case 468:
									array8[15] = (byte)num25;
									num2 = 192;
									if (PublishLiteralProc())
									{
										num2 = 240;
									}
									continue;
								case 234:
									intPtr6 = RestartNotificationMethod(((object[])PatchNotificationMethod(m_ProducerFacade))[0]);
									num2 = 340;
									continue;
								case 478:
									array16 = null;
									num2 = 408;
									if (DestroyLiteralProc() == null)
									{
										continue;
									}
									break;
								case 441:
									array12[num33] = array16[0];
									num = 228;
									break;
								case 152:
									num3 += num34;
									num2 = 209;
									continue;
								case 250:
									array8[0] = (byte)num25;
									num2 = 581;
									continue;
								case 334:
									array8[13] = 165;
									num2 = 27;
									if (!PublishLiteralProc())
									{
										num2 = 11;
									}
									continue;
								case 672:
									array8[6] = (byte)num25;
									num2 = 422;
									continue;
								case 646:
									if (!CalculateLiteralProc(ResetLiteralProc("System.Reflection.ReflectionContext", false), null))
									{
										num2 = 215;
										continue;
									}
									goto case 261;
								case 369:
									array[22] = (byte)num26;
									num2 = 500;
									continue;
								case 62:
									num82 = (nint)(ptr + (nint)num48 * (nint)8);
									*(long*)num82 ^= 258470544L;
									num2 = 73;
									continue;
								case 657:
									array[12] = (byte)num15;
									num2 = 590;
									continue;
								case 137:
									if (FlushLiteralProc() == 4)
									{
										num2 = 257;
										continue;
									}
									goto case 634;
								case 603:
									array[11] = 214;
									num2 = 446;
									continue;
								case 210:
									num15 = 133 - 44;
									num2 = 337;
									continue;
								case 108:
									array[6] = (byte)num26;
									num2 = 438;
									continue;
								case 481:
									num26 = 90 + 106;
									num2 = 369;
									continue;
								case 473:
									InsertNotificationMethod(cryptoStream);
									num2 = 211;
									if (DestroyLiteralProc() != null)
									{
										num2 = 186;
									}
									continue;
								case 445:
									num27 = num61 * 4;
									num2 = 425;
									if (!PublishLiteralProc())
									{
										num2 = 268;
									}
									continue;
								case 501:
									array[16] = (byte)num15;
									num2 = 447;
									continue;
								case 58:
									if (num61 == num35 - 1)
									{
										num2 = 507;
										continue;
									}
									goto case 161;
								case 235:
									num25 = 188 - 62;
									num2 = 222;
									continue;
								case 188:
									num25 = 225 - 75;
									num2 = 205;
									continue;
								case 406:
									array12[num33 + 1] = array20[1];
									num2 = 610;
									continue;
								case 116:
									RemoveNotificationMethod(m_DatabaseFacade, num50 + num81, exporterFacade);
									num2 = 582;
									continue;
								case 425:
									num45 = (uint)(num80 * 4);
									num2 = 88;
									if (PublishLiteralProc())
									{
										num2 = 191;
									}
									continue;
								case 44:
									array8[8] = 23;
									num = 443;
									break;
								case 198:
									array[29] = 169;
									num2 = 136;
									if (PublishLiteralProc())
									{
										num2 = 141;
									}
									continue;
								case 625:
									num25 = 25 + 35;
									num2 = 48;
									continue;
								case 550:
									ChangeNotificationMethod(cryptoStream, array21, 0, array21.Length);
									num2 = 473;
									continue;
								case 643:
									array11[3] = 74;
									num2 = 146;
									if (PublishLiteralProc())
									{
										num2 = 171;
									}
									continue;
								case 129:
									array[24] = (byte)num26;
									num2 = 285;
									continue;
								case 465:
									num26 = 121 + 82;
									num = 110;
									break;
								case 207:
									array18[8] = 108;
									num2 = 616;
									continue;
								case 554:
									array16 = (byte[])GetNotificationMethod(intPtr4.ToInt64());
									num2 = 365;
									if (DestroyLiteralProc() == null)
									{
										continue;
									}
									break;
								case 526:
									array[31] = 120;
									num2 = 437;
									continue;
								case 126:
									num41++;
									num2 = 626;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 254:
									if (array7 == null)
									{
										num2 = 594;
										continue;
									}
									goto case 194;
								case 228:
									array12[num33 + 1] = array16[1];
									num2 = 123;
									continue;
								case 414:
									spec = IntPtr.Zero;
									num2 = 47;
									if (PublishLiteralProc())
									{
										num2 = 380;
									}
									continue;
								case 68:
									array[27] = 107;
									num2 = 363;
									continue;
								case 72:
									array[24] = 225;
									num2 = 567;
									if (DestroyLiteralProc() != null)
									{
										num2 = 6;
									}
									continue;
								case 650:
									return;
								case 160:
									attributeFacade = false;
									num2 = 368;
									continue;
								case 617:
									array8[10] = 230;
									num2 = 428;
									continue;
								case 578:
									array8[12] = 132;
									num2 = 233;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 498:
									if (FlushLiteralProc() == 4)
									{
										num = 31;
										break;
									}
									goto case 55;
								case 547:
									num15 = 120 + 55;
									num2 = 556;
									if (DestroyLiteralProc() == null)
									{
										continue;
									}
									break;
								case 666:
									array3 = null;
									num2 = 452;
									continue;
								case 299:
									RateNotificationMethod(cryptoStream);
									num2 = 7;
									continue;
								case 314:
									num37 <<= 8;
									num2 = 60;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 677:
									array[1] = 214;
									num2 = 82;
									continue;
								case 227:
									array[11] = 137;
									num2 = 339;
									continue;
								case 639:
									num61 = 0;
									num2 = 410;
									continue;
								case 676:
									if (FlushLiteralProc() == 4)
									{
										num2 = 180;
										if (PublishLiteralProc())
										{
											num2 = 234;
										}
										continue;
									}
									goto case 529;
								case 141:
									array[29] = 88;
									num2 = 355;
									continue;
								case 298:
									array12[num36 + 5] = array13[5];
									num2 = 173;
									continue;
								case 184:
									array18 = new byte[10];
									num = 57;
									break;
								case 47:
									array[15] = (byte)num15;
									num2 = 583;
									continue;
								case 391:
									num78++;
									num2 = 262;
									continue;
								case 408:
									array20 = null;
									num2 = 313;
									if (PublishLiteralProc())
									{
										num2 = 476;
									}
									continue;
								case 74:
									array8[0] = (byte)num25;
									num2 = 293;
									continue;
								case 167:
									array8[13] = 200;
									num2 = 362;
									continue;
								case 476:
									array13 = null;
									num2 = 664;
									continue;
								case 23:
									num26 = 77 + 103;
									num2 = 313;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 589:
									array8[15] = 157;
									num2 = 640;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 620:
									array8[9] = (byte)num25;
									num2 = 243;
									continue;
								case 460:
									attributeFacade = false;
									num2 = 367;
									continue;
								case 266:
									num15 = 112 + 90;
									num2 = 182;
									continue;
								case 63:
									array[24] = (byte)num15;
									num2 = 296;
									continue;
								case 54:
									array[17] = (byte)num15;
									num2 = 599;
									if (DestroyLiteralProc() == null)
									{
										continue;
									}
									break;
								case 191:
									num34 = (uint)((array17[num45 + 3] << 24) | (array17[num45 + 2] << 16) | (array17[num45 + 1] << 8) | array17[num45]);
									num2 = 335;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 24:
									intPtr4 = DisableNotificationMethod(_CustomerFacade);
									num2 = 223;
									continue;
								case 71:
									AssetNotificationMethod(_StrategyFacade);
									num2 = 493;
									continue;
								case 240:
									num25 = 248 - 82;
									num2 = 102;
									continue;
								case 426:
									array[22] = 94;
									num2 = 481;
									continue;
								case 675:
									array8[14] = (byte)num25;
									num2 = 512;
									continue;
								case 248:
									array[16] = (byte)num26;
									num2 = 655;
									continue;
								case 99:
									ListStub(intPtr7, 4, 4, ref task);
									num2 = 288;
									if (PublishLiteralProc())
									{
										num2 = 415;
									}
									continue;
								case 158:
									exporterFacade.m_AttributeFacade = attributeFacade;
									num2 = 116;
									continue;
								case 251:
									GetLiteralProc(array5, 0, DeleteLiteralProc(8), 1);
									num2 = 15;
									continue;
								case 75:
									num15 = 145 - 48;
									num2 = 54;
									continue;
								case 654:
									num26 = 140 + 46;
									num2 = 678;
									if (!PublishLiteralProc())
									{
										num2 = 512;
									}
									continue;
								case 500:
									num26 = 166 - 55;
									num2 = 674;
									continue;
								case 202:
									array[1] = 55;
									num2 = 551;
									continue;
								case 458:
									num15 = 186 - 62;
									num2 = 536;
									continue;
								case 390:
									InitLiteralProc(new IntPtr(&num42), 0);
									num2 = 203;
									continue;
								case 36:
									try
									{
										_StrategyFacade = (StatePropertyPolicy)ReadNotificationMethod(new IntPtr(num24), CalcNotificationMethod(typeof(StatePropertyPolicy).TypeHandle));
										num70 = 0;
										if (DestroyLiteralProc() != null)
										{
											num70 = num71;
										}
										switch (num70)
										{
										case 0:
											break;
										}
									}
									catch (object obj6)
									{
										num72 = 0;
										if (DestroyLiteralProc() != null)
										{
											num72 = num73;
										}
										switch (num72)
										{
										default:
											try
											{
												Delegate @delegate = (Delegate)ReadNotificationMethod(new IntPtr(num24), CalcNotificationMethod(typeof(StatePropertyPolicy).TypeHandle));
												num74 = 1;
												if (DestroyLiteralProc() != null)
												{
													goto IL_33a9_2;
												}
												goto IL_33ad_3;
												IL_33ad_3:
												while (true)
												{
													switch (num74)
													{
													case 1:
														goto IL_33bf_2;
													case 0:
														break;
													}
													break;
													IL_33bf_2:
													_StrategyFacade = (StatePropertyPolicy)PushNotificationMethod(CalcNotificationMethod(typeof(StatePropertyPolicy).TypeHandle), InitNotificationMethod(@delegate));
													num74 = 0;
													if (PublishLiteralProc())
													{
														continue;
													}
													goto IL_33a9_2;
												}
												goto end_IL_337c_2;
												IL_33a9_2:
												num74 = num75;
												goto IL_33ad_3;
												end_IL_337c_2:;
											}
											catch (object obj5)
											{
												num76 = 0;
												if (DestroyLiteralProc() != null)
												{
													num76 = num77;
												}
												switch (num76)
												{
												default:
													goto end_IL_33f9_2;
												case 0:
													goto end_IL_33f9_2;
												}
												end_IL_33f9_2:;
											}
											break;
										case 1:
											break;
										}
									}
									goto case 378;
								case 100:
									intPtr4 = IntPtr.Zero;
									num2 = 24;
									continue;
								case 368:
								case 582:
									if (OrderNotificationMethod(FindLiteralProc(stubAuthentication)) < ConcatNotificationMethod(FindLiteralProc(stubAuthentication)) - 1)
									{
										num2 = 38;
										continue;
									}
									goto case 648;
								case 469:
									array8[7] = 17;
									num2 = 80;
									if (DestroyLiteralProc() == null)
									{
										continue;
									}
									break;
								case 385:
									array8[8] = (byte)num25;
									num2 = 44;
									if (DestroyLiteralProc() == null)
									{
										continue;
									}
									break;
								case 557:
									array8[9] = 86;
									num2 = 270;
									continue;
								case 260:
									array8[9] = 247;
									num2 = 609;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 333:
									array8[7] = (byte)num25;
									num2 = 566;
									if (DestroyLiteralProc() == null)
									{
										continue;
									}
									break;
								case 493:
									ValidateNotificationMethod(FillNotificationMethod(InitNotificationMethod(_StrategyFacade)));
									num = 321;
									break;
								case 252:
									return;
								case 488:
									num15 = 217 - 72;
									num2 = 401;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 611:
									num26 = 135 - 45;
									num2 = 176;
									continue;
								case 347:
									num25 = 72 + 48;
									num2 = 74;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 49:
									array12[num33 + 3] = array20[3];
									num2 = 499;
									continue;
								case 201:
									task = 0;
									num2 = 495;
									continue;
								case 364:
									array18[1] = 108;
									num2 = 480;
									continue;
								case 348:
									num69 = 4059231220u;
									num2 = 412;
									if (DestroyLiteralProc() == null)
									{
										continue;
									}
									break;
								case 668:
									if (AwakeNotificationMethod(CalcNotificationMethod(typeof(WriterPropertyProducer).TypeHandle).Assembly) == null)
									{
										num2 = 101;
										continue;
									}
									goto case 246;
								case 418:
									array12[num36 + 3] = array13[3];
									num = 142;
									break;
								case 193:
									array9[num27 + 1] = (byte)((num28 & 0xFF00) >> 8);
									num2 = 36;
									if (PublishLiteralProc())
									{
										num2 = 146;
									}
									continue;
								case 1:
									VerifyLiteralProc();
									num2 = 650;
									continue;
								case 159:
									b = (string)StartNotificationMethod(DefineNotificationMethod(), array11);
									num2 = 263;
									if (DestroyLiteralProc() == null)
									{
										num2 = 462;
									}
									continue;
								case 642:
									num25 = 168 - 56;
									num2 = 190;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 32:
									array[20] = 11;
									num2 = 605;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 567:
									num15 = 169 - 56;
									num2 = 63;
									continue;
								case 177:
									array12 = array3;
									num2 = 478;
									continue;
								case 598:
									num25 = 183 + 42;
									num2 = 656;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 667:
									array13 = (byte[])InterruptNotificationMethod(_MethodFacade.ToInt32());
									num2 = 484;
									continue;
								case 376:
								case 490:
									if (num32 >= num43)
									{
										num2 = 186;
										if (PublishLiteralProc())
										{
											continue;
										}
										break;
									}
									goto case 357;
								case 410:
								case 474:
									if (num61 >= num35)
									{
										num2 = 121;
										if (DestroyLiteralProc() != null)
										{
											num2 = 100;
										}
										continue;
									}
									goto case 574;
								case 370:
									num15 = 191 - 63;
									num2 = 450;
									continue;
								case 305:
									array[17] = (byte)num15;
									num2 = 341;
									if (DestroyLiteralProc() == null)
									{
										continue;
									}
									break;
								case 591:
									VerifyLiteralProc();
									num2 = 252;
									continue;
								case 399:
									array8[2] = 87;
									num2 = 644;
									if (DestroyLiteralProc() != null)
									{
										num2 = 208;
									}
									continue;
								case 37:
									enumerator = (IEnumerator)PopLiteralProc(processModuleCollection);
									num2 = 263;
									if (DestroyLiteralProc() != null)
									{
										num2 = 110;
									}
									continue;
								case 142:
									array12[num36 + 4] = array13[4];
									num2 = 178;
									if (PublishLiteralProc())
									{
										num2 = 298;
									}
									continue;
								case 309:
									array12[num36] = array13[0];
									num2 = 303;
									if (DestroyLiteralProc() == null)
									{
										continue;
									}
									break;
								case 318:
									array[25] = (byte)num26;
									num2 = 130;
									continue;
								case 607:
									intPtr6 = RestartNotificationMethod(((object[])PatchNotificationMethod(m_ProducerFacade))[0]);
									num = 97;
									break;
								case 379:
									return;
								case 504:
									if (FlushLiteralProc() == 4)
									{
										num2 = 646;
										continue;
									}
									goto case 215;
								case 416:
									cryptoStream = new CryptoStream(memoryStream2, transform, CryptoStreamMode.Write);
									num2 = 550;
									if (DestroyLiteralProc() == null)
									{
										continue;
									}
									break;
								case 109:
									array[28] = 126;
									num2 = 561;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 147:
								case 658:
									GetLiteralProc(array12, 0, intPtr2, array12.Length);
									num2 = 521;
									if (DestroyLiteralProc() != null)
									{
										num2 = 85;
									}
									continue;
								case 280:
									array17[num46] = (byte)(array17[num46] ^ array10[num46]);
									num2 = 439;
									continue;
								case 671:
									_CustomerFacade = new StatePropertyPolicy(ConnectStub);
									num2 = 100;
									continue;
								case 543:
									num26 = 209 - 69;
									num2 = 277;
									if (DestroyLiteralProc() == null)
									{
										continue;
									}
									break;
								case 9:
									_PrinterFacade = true;
									num2 = 40;
									if (DestroyLiteralProc() == null)
									{
										num2 = 348;
									}
									continue;
								case 395:
								case 548:
									num51 = 7680;
									num2 = 76;
									if (!PublishLiteralProc())
									{
										num2 = 65;
									}
									continue;
								case 283:
									RemoveNotificationMethod(m_DatabaseFacade, 0L, exporterFacade2);
									num2 = 160;
									if (DestroyLiteralProc() == null)
									{
										continue;
									}
									break;
								case 21:
									num15 = 95 + 48;
									num2 = 113;
									continue;
								case 544:
									array[21] = 124;
									num2 = 351;
									continue;
								case 345:
									num26 = 125 + 24;
									num2 = 568;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 606:
									array[3] = (byte)num15;
									num = 673;
									break;
								case 552:
									array12[num36 + 7] = array16[7];
									num2 = 658;
									continue;
								case 66:
									array8[9] = (byte)num25;
									num = 557;
									break;
								case 77:
									_ProcessFacade = intPtr6.ToInt64();
									num = 514;
									break;
								case 502:
									num26 = 37 + 121;
									num2 = 585;
									continue;
								case 538:
									array8[1] = 166;
									num = 400;
									break;
								case 304:
									array18[3] = 106;
									num2 = 144;
									continue;
								case 656:
									array8[15] = (byte)num25;
									num = 301;
									break;
								case 175:
									flag = SortLiteralProc(RunLiteralProc(ListLiteralProc(ValidateLiteralProc(FillLiteralProc())), "__", 10u), IntPtr.Zero);
									num2 = 192;
									continue;
								case 529:
									intPtr6 = RestartNotificationMethod(((object[])PatchNotificationMethod(m_ProducerFacade))[0]);
									num2 = 534;
									continue;
								case 506:
									goto end_IL_4f85;
								case 203:
									PushLiteralProc(new IntPtr(&num42), 0);
									num2 = 5;
									continue;
								case 16:
									if (num31 > 0)
									{
										num2 = 353;
										if (PublishLiteralProc())
										{
											continue;
										}
										break;
									}
									goto case 604;
								case 378:
									_ = IntPtr.Zero;
									num2 = 120;
									continue;
								case 86:
									if (num31 > 0)
									{
										num2 = 152;
										continue;
									}
									goto case 595;
								case 665:
									array[12] = 9;
									num2 = 661;
									continue;
								case 328:
									array[6] = 166;
									num = 636;
									break;
								case 61:
									array8[1] = (byte)num25;
									num2 = 509;
									continue;
								case 566:
									array8[7] = 124;
									num2 = 469;
									continue;
								case 114:
									num26 = 61 + 31;
									num2 = 319;
									continue;
								case 507:
									if (num31 > 0)
									{
										num2 = 178;
										if (DestroyLiteralProc() == null)
										{
											continue;
										}
										break;
									}
									goto case 161;
								case 183:
								case 653:
									if (num48 >= num60)
									{
										num2 = 506;
										if (DestroyLiteralProc() == null)
										{
											continue;
										}
										break;
									}
									goto case 62;
								case 604:
									num45 = 0u;
									num2 = 639;
									continue;
								case 464:
									num40 += 8;
									num2 = 294;
									continue;
								case 439:
									num46++;
									num2 = 356;
									continue;
								case 450:
									array[15] = (byte)num15;
									num2 = 602;
									if (DestroyLiteralProc() == null)
									{
										continue;
									}
									break;
								case 111:
									array[0] = (byte)num15;
									num = 488;
									break;
								case 194:
									if (array7.Length > 0)
									{
										num2 = 669;
										continue;
									}
									goto case 324;
								case 253:
									transform = (ICryptoTransform)ComputeNotificationMethod(symmetricAlgorithm, array17, array10);
									num2 = 600;
									continue;
								case 170:
								case 562:
									ListStub(intPtr, 4, task, ref task);
									num2 = 391;
									if (!PublishLiteralProc())
									{
										num2 = 208;
									}
									continue;
								case 641:
									array[22] = (byte)num26;
									num2 = 426;
									continue;
								case 367:
									if (num29 >= 1879048192)
									{
										num2 = 358;
										continue;
									}
									goto case 519;
								case 580:
									array8[2] = 103;
									num2 = 271;
									continue;
								case 433:
									array[27] = (byte)num26;
									num2 = 68;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 95:
									array8[10] = 95;
									num2 = 617;
									continue;
								case 533:
									array12[num36 + 2] = array20[2];
									num2 = 332;
									if (DestroyLiteralProc() == null)
									{
										continue;
									}
									break;
								case 396:
									array10[11] = array7[5];
									num2 = 588;
									if (DestroyLiteralProc() == null)
									{
										continue;
									}
									break;
								case 527:
									num25 = 61 + 52;
									num2 = 154;
									continue;
								case 85:
									num36 = 2;
									num2 = 309;
									continue;
								case 590:
									num15 = 160 - 53;
									num2 = 96;
									continue;
								case 180:
									array[9] = 154;
									num2 = 496;
									continue;
								case 226:
									array12[num36 + 2] = array13[2];
									num2 = 418;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 584:
									array[10] = 67;
									num2 = 274;
									continue;
								case 382:
									num30 = 0;
									num2 = 89;
									continue;
								case 327:
									array8[1] = 155;
									num2 = 538;
									continue;
								case 412:
									num42 = 0L;
									num2 = 390;
									continue;
								case 353:
									num35++;
									num2 = 604;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 363:
									array[27] = 141;
									num2 = 373;
									continue;
								case 173:
									array12[num36 + 6] = array13[6];
									num2 = 145;
									continue;
								case 164:
								case 169:
									num48 = 0;
									num2 = 653;
									continue;
								case 246:
									if (WriteNotificationMethod(AwakeNotificationMethod(CalcNotificationMethod(typeof(WriterPropertyProducer).TypeHandle).Assembly)) > 0)
									{
										num2 = 1;
										if (DestroyLiteralProc() == null)
										{
											num2 = 1;
										}
										continue;
									}
									goto case 101;
								case 352:
									spec = InstantiateNotificationMethod((uint)item_count, 1, (uint)CreateNotificationMethod(FillLiteralProc()));
									num2 = 676;
									if (DestroyLiteralProc() != null)
									{
										num2 = 28;
									}
									continue;
								case 98:
									array12[num36] = array20[0];
									num2 = 456;
									continue;
								case 275:
									array[5] = 122;
									num2 = 545;
									continue;
								case 638:
									array[7] = 90;
									num2 = 511;
									continue;
								case 136:
									array8[11] = 157;
									num2 = 308;
									if (DestroyLiteralProc() != null)
									{
										num2 = 163;
									}
									continue;
								case 7:
									ExcludeNotificationMethod(stubAuthentication);
									num2 = 218;
									if (DestroyLiteralProc() == null)
									{
										num2 = 651;
									}
									continue;
								case 5:
									ReflectLiteralProc(new IntPtr(&num42), 0);
									num2 = 632;
									continue;
								case 435:
									_StrategyFacade = null;
									num2 = 36;
									continue;
								case 403:
									array[9] = 227;
									num2 = 180;
									if (DestroyLiteralProc() == null)
									{
										continue;
									}
									break;
								case 570:
									array[2] = 95;
									num2 = 618;
									continue;
								case 30:
									symmetricAlgorithm = (SymmetricAlgorithm)SetupNotificationMethod();
									num2 = 65;
									continue;
								case 434:
									array7 = (byte[])StopNotificationMethod(CloneNotificationMethod(m_ProducerFacade));
									num2 = 254;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 634:
									value2 = InvokeNotificationMethod(intPtr5);
									num2 = 587;
									if (DestroyLiteralProc() == null)
									{
										continue;
									}
									break;
								case 211:
									array14 = (byte[])ManageNotificationMethod(memoryStream2);
									num2 = 39;
									if (!PublishLiteralProc())
									{
										num2 = 19;
									}
									continue;
								case 623:
									array[19] = 162;
									num2 = 12;
									if (DestroyLiteralProc() != null)
									{
										num2 = 4;
									}
									continue;
								case 407:
									MapNotificationMethod(spec);
									num2 = 591;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 444:
									num26 = 28 + 8;
									num2 = 53;
									if (!PublishLiteralProc())
									{
										num2 = 14;
									}
									continue;
								case 48:
									array8[6] = (byte)num25;
									num2 = 527;
									continue;
								case 168:
									array[13] = 46;
									num2 = 229;
									continue;
								case 26:
									array8[4] = 87;
									num2 = 635;
									continue;
								case 659:
									num25 = 76 + 30;
									num2 = 66;
									continue;
								case 270:
									num25 = 234 - 78;
									num2 = 620;
									continue;
								case 150:
									array8[4] = 158;
									num2 = 227;
									if (DestroyLiteralProc() == null)
									{
										num2 = 344;
									}
									continue;
								case 83:
									num25 = 156 + 87;
									num2 = 310;
									continue;
								case 561:
									array[28] = 124;
									num2 = 279;
									if (DestroyLiteralProc() == null)
									{
										num2 = 663;
									}
									continue;
								case 651:
									num47 = ResolveNotificationMethod(stubAuthentication);
									num2 = 649;
									continue;
								case 508:
									array[18] = (byte)num26;
									num2 = 593;
									continue;
								case 430:
									RateNotificationMethod(memoryStream2);
									num2 = 299;
									continue;
								case 217:
									if (WriteNotificationMethod(AwakeNotificationMethod(m_ProducerFacade)) != 0)
									{
										num2 = 133;
										if (DestroyLiteralProc() == null)
										{
											continue;
										}
										break;
									}
									goto case 395;
								case 432:
									array21 = (byte[])CollectNotificationMethod(stubAuthentication, (int)ConcatNotificationMethod(FindLiteralProc(stubAuthentication)));
									num2 = 454;
									continue;
								case 497:
									num26 = 191 - 63;
									num2 = 291;
									continue;
								case 204:
									array[17] = (byte)num15;
									num2 = 75;
									if (DestroyLiteralProc() == null)
									{
										continue;
									}
									break;
								case 306:
									RevertLiteralProc(FindLiteralProc(stubAuthentication), 0L);
									num = 432;
									break;
								case 649:
									num44 = ResolveNotificationMethod(stubAuthentication);
									num2 = 531;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 166:
									num39 <<= 8;
									num2 = 464;
									continue;
								case 358:
									attributeFacade = true;
									num2 = 519;
									continue;
								case 106:
									try
									{
										ProcessModuleCollection processModuleCollection2 = (ProcessModuleCollection)SetLiteralProc(literalProc);
										num52 = 0;
										if (DestroyLiteralProc() != null)
										{
											num52 = 0;
										}
										while (true)
										{
											switch (num52)
											{
											case 2:
												try
												{
													while (true)
													{
														IL_45dc_2:
														if (!AddLiteralProc(enumerator))
														{
															num53 = 1;
															if (DestroyLiteralProc() != null)
															{
																goto IL_44d0_2;
															}
															goto IL_44d4_3;
														}
														goto IL_458f_2;
														IL_44d4_3:
														while (true)
														{
															switch (num53)
															{
															case 5:
																return;
															case 8:
																VerifyLiteralProc();
																num53 = 2;
																if (DestroyLiteralProc() == null)
																{
																	num53 = 5;
																}
																continue;
															case 4:
																num55 = num24;
																intPtr6 = ListLiteralProc(processModule);
																if (num55 >= intPtr6.ToInt64())
																{
																	num53 = 0;
																	if (PublishLiteralProc())
																	{
																		num53 = 6;
																	}
																	continue;
																}
																goto case 7;
															case 7:
																if (!DestroyNotificationMethod(PublishNotificationMethod(CalcNotificationMethod(typeof(WriterPropertyProducer).TypeHandle).Assembly), null))
																{
																	num53 = 0;
																	if (DestroyLiteralProc() != null)
																	{
																		num53 = 0;
																	}
																	continue;
																}
																goto case 8;
															case 9:
																break;
															case 6:
																num54 = num24;
																intPtr6 = ListLiteralProc(processModule);
																if (num54 > intPtr6.ToInt64() + LoginNotificationMethod(processModule))
																{
																	num53 = 7;
																	continue;
																}
																goto IL_45dc_2;
															default:
																goto IL_45dc_2;
															case 3:
																if (ForgotLiteralProc(CallLiteralProc(processModule), text))
																{
																	num53 = 4;
																	continue;
																}
																goto IL_45dc_2;
															case 1:
																goto end_IL_45dc_2;
															}
															break;
														}
														goto IL_458f_2;
														IL_458f_2:
														processModule = (ProcessModule)PrepareLiteralProc(enumerator);
														num53 = 3;
														if (!PublishLiteralProc())
														{
															goto IL_44d0_2;
														}
														goto IL_44d4_3;
														IL_44d0_2:
														num53 = num56;
														goto IL_44d4_3;
														continue;
														end_IL_45dc_2:
														break;
													}
												}
												finally
												{
													IDisposable disposable = enumerator as IDisposable;
													num57 = 1;
													if (DestroyLiteralProc() != null)
													{
														num57 = 1;
													}
													while (true)
													{
														switch (num57)
														{
														default:
															CustomizeLiteralProc(disposable);
															num57 = 2;
															continue;
														case 1:
															if (disposable != null)
															{
																num57 = 0;
																if (DestroyLiteralProc() == null)
																{
																	num57 = 0;
																}
																continue;
															}
															break;
														case 2:
															break;
														}
														break;
													}
												}
												goto end_IL_44aa_2;
											case 1:
												goto end_IL_44aa_2;
											}
											enumerator = (IEnumerator)PopLiteralProc(processModuleCollection2);
											num52 = 2;
											continue;
											end_IL_44aa_2:
											break;
										}
									}
									catch (object obj3)
									{
										num58 = 0;
										if (!PublishLiteralProc())
										{
											num58 = num59;
										}
										switch (num58)
										{
										case 0:
											break;
										}
									}
									goto case 103;
								case 635:
									num25 = 242 - 80;
									num2 = 629;
									continue;
								case 384:
									array12[num33 + 1] = array13[1];
									num2 = 614;
									continue;
								case 92:
									array18[6] = 46;
									num2 = 59;
									if (!PublishLiteralProc())
									{
										num2 = 51;
									}
									continue;
								case 107:
									UpdateLiteralProc(new IntPtr(&num42), 0, 0L);
									num2 = 140;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 258:
									num32 = 0;
									num2 = 490;
									continue;
								case 525:
									num3 += num34;
									num2 = 282;
									continue;
								case 10:
									if (!_PrinterFacade)
									{
										num2 = 9;
										continue;
									}
									goto case 569;
								case 438:
									array[6] = 130;
									num2 = 328;
									if (!PublishLiteralProc())
									{
										num2 = 40;
									}
									continue;
								case 518:
									num15 = 244 - 81;
									num2 = 449;
									continue;
								case 223:
									num24 = 0L;
									num = 498;
									break;
								case 674:
									array[22] = (byte)num26;
									num2 = 42;
									continue;
								case 673:
									array[3] = 111;
									num2 = 114;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 577:
									if (FlushLiteralProc() == 4)
									{
										num2 = 205;
										if (PublishLiteralProc())
										{
											num2 = 560;
										}
										continue;
									}
									goto case 553;
								case 535:
									array[11] = 210;
									num = 603;
									break;
								case 451:
									num15 = 96 - 89;
									num = 47;
									break;
								case 495:
									num51 = 0;
									num2 = 245;
									continue;
								case 539:
									array12[num36 + 6] = array20[6];
									num2 = 523;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 212:
									array8[8] = 147;
									num2 = 491;
									continue;
								case 297:
									array8[3] = (byte)num25;
									num2 = 383;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 349:
									array8[12] = (byte)num25;
									num2 = 323;
									continue;
								case 342:
									array[22] = (byte)num26;
									num2 = 458;
									continue;
								case 163:
									num26 = 86 + 69;
									num = 187;
									break;
								case 97:
									num50 = intPtr6.ToInt64();
									num2 = 153;
									if (DestroyLiteralProc() == null)
									{
										num2 = 201;
									}
									continue;
								case 597:
									array13 = (byte[])GetNotificationMethod(_MethodFacade.ToInt64());
									num2 = 554;
									continue;
								case 351:
									num26 = 163 - 54;
									num2 = 641;
									if (DestroyLiteralProc() == null)
									{
										continue;
									}
									break;
								case 8:
								case 338:
									if (FlushLiteralProc() == 4)
									{
										num2 = 397;
										if (DestroyLiteralProc() == null)
										{
											continue;
										}
										break;
									}
									goto case 85;
								case 470:
									num15 = 131 - 43;
									num2 = 359;
									continue;
								case 555:
									num33 = 16;
									num = 540;
									break;
								case 236:
									array12[num33] = array13[0];
									num2 = 384;
									if (DestroyLiteralProc() == null)
									{
										continue;
									}
									break;
								case 310:
									array8[12] = (byte)num25;
									num2 = 167;
									continue;
								case 224:
									creatorAdapterWatcher = (CreatorAdapterWatcher)ReadNotificationMethod(config, CalcNotificationMethod(typeof(CreatorAdapterWatcher).TypeHandle));
									num2 = 6;
									continue;
								case 564:
									num26 = 140 - 46;
									num2 = 508;
									continue;
								case 239:
									array12[num36 + 5] = array16[5];
									num2 = 165;
									continue;
								case 216:
									array8[0] = 147;
									num2 = 608;
									continue;
								case 265:
									ListStub(intPtr, 4, 4, ref task);
									num2 = 577;
									continue;
								case 332:
									array12[num36 + 3] = array20[3];
									num2 = 366;
									continue;
								case 286:
									array8[9] = (byte)num25;
									num2 = 659;
									continue;
								case 397:
									num33 = 9;
									num2 = 236;
									continue;
								case 339:
									array[11] = 19;
									num2 = 67;
									if (DestroyLiteralProc() == null)
									{
										continue;
									}
									break;
								case 355:
									array[29] = 162;
									num2 = 546;
									continue;
								case 18:
									num15 = 191 - 63;
									num2 = 91;
									continue;
								case 341:
									array[17] = 204;
									num2 = 564;
									continue;
								case 323:
									num25 = 217 - 72;
									num2 = 475;
									if (!PublishLiteralProc())
									{
										num2 = 330;
									}
									continue;
								case 317:
									array8[3] = (byte)num25;
									num2 = 151;
									continue;
								case 534:
									roleFacade = intPtr6.ToInt64();
									num2 = 273;
									continue;
								case 104:
									exporterFacade2 = default(ExporterFacade);
									num2 = 405;
									continue;
								case 302:
									intPtr3 = CollectStub(text);
									num2 = 179;
									continue;
								case 610:
									array12[num33 + 2] = array20[2];
									num = 49;
									break;
								case 605:
									num15 = 63 + 60;
									num2 = 424;
									if (DestroyLiteralProc() == null)
									{
										continue;
									}
									break;
								case 428:
									num25 = 209 - 69;
									num2 = 571;
									continue;
								case 231:
									array[24] = 165;
									num2 = 72;
									continue;
								case 669:
									array10[1] = array7[0];
									num2 = 624;
									continue;
								case 290:
									array8[4] = (byte)num25;
									num2 = 26;
									if (DestroyLiteralProc() != null)
									{
										num2 = 9;
									}
									continue;
								case 281:
								case 374:
									if (num49 >= num47)
									{
										num2 = 248;
										if (DestroyLiteralProc() == null)
										{
											num2 = 637;
										}
										continue;
									}
									goto case 343;
								case 43:
									array12[num36 + 4] = array16[4];
									num2 = 239;
									continue;
								case 595:
									num45 = (uint)num27;
									num2 = 525;
									if (!PublishLiteralProc())
									{
										num2 = 154;
									}
									continue;
								case 238:
									num36 = 30;
									num2 = 381;
									if (DestroyLiteralProc() == null)
									{
										continue;
									}
									break;
								case 503:
									array[4] = 171;
									num2 = 436;
									if (PublishLiteralProc())
									{
										num2 = 611;
									}
									continue;
								case 453:
									num25 = 148 - 49;
									num2 = 250;
									continue;
								case 82:
									num15 = 115 + 41;
									num2 = 156;
									continue;
								case 272:
									array8[7] = (byte)num25;
									num2 = 429;
									continue;
								case 609:
									array8[10] = 106;
									num2 = 95;
									continue;
								case 647:
									array[1] = (byte)num26;
									num2 = 677;
									continue;
								case 421:
									array8[14] = (byte)num25;
									num2 = 31;
									if (PublishLiteralProc())
									{
										num2 = 218;
									}
									continue;
								case 287:
									array11[5] = 116;
									num2 = 159;
									continue;
								case 541:
									array8[5] = 222;
									num2 = 625;
									continue;
								case 293:
									array8[0] = 147;
									num = 216;
									break;
								case 73:
									num48++;
									num2 = 91;
									if (DestroyLiteralProc() == null)
									{
										num2 = 183;
									}
									continue;
								case 365:
									array20 = (byte[])GetNotificationMethod(num24);
									num2 = 8;
									continue;
								case 145:
									array12[num36 + 7] = array13[7];
									num2 = 579;
									continue;
								case 268:
									num25 = 43 + 94;
									num2 = 230;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 291:
									array[5] = (byte)num26;
									num2 = 275;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 209:
									num37 = 0u;
									num2 = 307;
									continue;
								case 105:
								case 386:
									goto IL_4f85;
								case 213:
									text = (string)StartNotificationMethod(DefineNotificationMethod(), array18);
									num2 = 302;
									continue;
								case 70:
									array18 = new byte[12];
									num2 = 88;
									continue;
								case 124:
									array[4] = 61;
									num = 185;
									break;
								case 593:
									array[18] = 159;
									num = 563;
									break;
								case 601:
									array[21] = 92;
									num2 = 544;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 340:
									_MappingFacade = intPtr6.ToInt32();
									num2 = 529;
									continue;
								case 189:
									MoveLiteralProc(new IntPtr(&num42), 0, 0);
									num2 = 107;
									continue;
								case 622:
									num15 = 189 - 63;
									num2 = 25;
									continue;
								case 621:
									array18[11] = 108;
									num = 633;
									break;
								case 519:
									def_amount = ResolveNotificationMethod(stubAuthentication);
									num2 = 515;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 222:
									array8[3] = (byte)num25;
									num2 = 325;
									if (!PublishLiteralProc())
									{
										num2 = 224;
									}
									continue;
								case 645:
									array[1] = (byte)num26;
									num = 64;
									break;
								case 214:
									array[29] = 128;
									num2 = 524;
									continue;
								case 429:
									num25 = 140 - 46;
									num2 = 333;
									continue;
								case 241:
								case 630:
									literalProc = (Process)FillLiteralProc();
									num2 = 106;
									continue;
								case 356:
								case 482:
									if (num46 >= array10.Length)
									{
										num2 = 112;
										continue;
									}
									goto case 280;
								case 187:
									array[10] = (byte)num26;
									num2 = 584;
									continue;
								case 140:
									array5 = new byte[1];
									num2 = 189;
									if (DestroyLiteralProc() == null)
									{
										num2 = 251;
									}
									continue;
								case 487:
									num15 = 105 + 16;
									num2 = 111;
									continue;
								case 532:
									array[8] = 136;
									num2 = 518;
									if (DestroyLiteralProc() == null)
									{
										continue;
									}
									break;
								case 463:
									array12[num36 + 3] = array16[3];
									num2 = 43;
									if (!PublishLiteralProc())
									{
										num2 = 2;
									}
									continue;
								case 457:
									array[12] = (byte)num15;
									num = 542;
									break;
								case 282:
									num37 = (uint)((array19[num45 + 3] << 24) | (array19[num45 + 2] << 16) | (array19[num45 + 1] << 8) | array19[num45]);
									num2 = 346;
									continue;
								case 618:
									array[2] = 128;
									num2 = 295;
									continue;
								case 362:
									array8[13] = 90;
									num2 = 334;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 289:
									array8[6] = (byte)num25;
									num2 = 117;
									continue;
								case 123:
									array12[num33 + 2] = array16[2];
									num2 = 375;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 296:
									num26 = 120 - 41;
									num = 129;
									break;
								case 644:
									array8[2] = 55;
									num2 = 464;
									if (DestroyLiteralProc() == null)
									{
										num2 = 580;
									}
									continue;
								case 537:
									num44 = ResolveNotificationMethod(stubAuthentication);
									num2 = 13;
									continue;
								case 208:
									array[14] = 139;
									num = 370;
									break;
								case 521:
									resolverFacade = false;
									num2 = 461;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 14:
									array[19] = (byte)num26;
									num2 = 20;
									continue;
								case 277:
									array[19] = (byte)num26;
									num2 = 502;
									continue;
								case 559:
									array8[5] = 95;
									num2 = 642;
									if (DestroyLiteralProc() == null)
									{
										continue;
									}
									break;
								case 361:
									num43 = ResolveNotificationMethod(stubAuthentication);
									num2 = 427;
									continue;
								case 424:
									array[21] = (byte)num15;
									num2 = 652;
									continue;
								case 230:
									array8[4] = (byte)num25;
									num2 = 559;
									if (DestroyLiteralProc() != null)
									{
										num2 = 298;
									}
									continue;
								case 511:
									num15 = 112 - 44;
									num2 = 350;
									if (DestroyLiteralProc() != null)
									{
										num2 = 324;
									}
									continue;
								case 322:
									num30++;
									num2 = 389;
									continue;
								case 392:
									if (array5.Length != 0)
									{
										num2 = 386;
										continue;
									}
									goto end_IL_0012;
								case 12:
									num26 = 66 + 35;
									num2 = 84;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 259:
									array[31] = 108;
									num2 = 526;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 344:
									num25 = 0 + 57;
									num = 311;
									break;
								case 17:
									array12[num36 + 1] = array16[1];
									num2 = 613;
									continue;
								case 632:
									CancelLiteralProc(new IntPtr(&num42), 0, IntPtr.Zero);
									num2 = 189;
									continue;
								case 517:
									array10[7] = array7[3];
									num2 = 131;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 664:
									if (FlushLiteralProc() == 4)
									{
										num2 = 667;
										if (DestroyLiteralProc() == null)
										{
											continue;
										}
										break;
									}
									goto case 597;
								case 563:
									num26 = 208 + 21;
									num2 = 572;
									continue;
								case 509:
									array8[1] = 143;
									num2 = 327;
									continue;
								case 576:
									num26 = 153 - 111;
									num2 = 93;
									if (DestroyLiteralProc() == null)
									{
										continue;
									}
									break;
								case 573:
									array20 = (byte[])InterruptNotificationMethod(SelectNotificationMethod(num24));
									num2 = 338;
									continue;
								case 631:
									array[28] = (byte)num26;
									num2 = 109;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 313:
									array[7] = (byte)num26;
									num2 = 470;
									continue;
								case 531:
									if (num44 != 1)
									{
										num49 = 0;
										num2 = 374;
										if (PublishLiteralProc())
										{
											continue;
										}
										break;
									}
									num2 = 414;
									continue;
								case 489:
								case 626:
									if (num41 >= num31)
									{
										num2 = 41;
										if (PublishLiteralProc())
										{
											continue;
										}
										break;
									}
									goto case 372;
								case 6:
									intPtr5 = RegisterNotificationMethod(creatorAdapterWatcher);
									num2 = 404;
									continue;
								case 102:
									array8[15] = (byte)num25;
									num2 = 598;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 553:
									PopStub(spec, intPtr, (byte[])InterruptNotificationMethod(ResolveNotificationMethod(stubAuthentication)), 4u, out second);
									num2 = 562;
									continue;
								case 592:
									array[0] = 87;
									num2 = 181;
									if (PublishLiteralProc())
									{
										num2 = 492;
									}
									continue;
								case 371:
									stubAuthentication = new StubAuthentication(new MemoryStream(array14));
									num2 = 22;
									continue;
								case 2:
									if (!DestroyNotificationMethod(PublishNotificationMethod(CalcNotificationMethod(typeof(WriterPropertyProducer).TypeHandle).Assembly), null))
									{
										num2 = 139;
										continue;
									}
									goto case 81;
								case 19:
									num26 = 175 - 58;
									num2 = 433;
									continue;
								case 149:
									array8 = new byte[16];
									num2 = 43;
									if (PublishLiteralProc())
									{
										num2 = 453;
									}
									continue;
								case 40:
								case 587:
									InitLiteralProc(intPtr5, 0);
									num2 = 671;
									if (DestroyLiteralProc() == null)
									{
										continue;
									}
									break;
								case 522:
									array[16] = (byte)num15;
									num = 670;
									break;
								case 400:
									num25 = 165 - 43;
									num = 247;
									break;
								case 96:
									array[12] = (byte)num15;
									num2 = 665;
									continue;
								case 596:
									array[6] = (byte)num15;
									num2 = 288;
									continue;
								case 613:
									array12[num36 + 2] = array16[2];
									num = 463;
									break;
								case 112:
									array19 = array21;
									num2 = 69;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 524:
									num15 = 143 - 47;
									num2 = 221;
									continue;
								case 581:
									array8[0] = 92;
									num2 = 347;
									continue;
								case 308:
									num25 = 11 + 92;
									num2 = 486;
									if (DestroyLiteralProc() == null)
									{
										continue;
									}
									break;
								case 143:
									num26 = 196 + 35;
									num2 = 14;
									if (DestroyLiteralProc() == null)
									{
										num2 = 14;
									}
									continue;
								case 15:
									AssetLiteralProc();
									num2 = 330;
									continue;
								case 485:
									array8[3] = (byte)num25;
									num2 = 235;
									if (DestroyLiteralProc() == null)
									{
										continue;
									}
									break;
								case 556:
									array[3] = (byte)num15;
									num2 = 316;
									continue;
								case 436:
									array[15] = 160;
									num2 = 225;
									continue;
								case 663:
									array[28] = 75;
									num2 = 214;
									continue;
								case 636:
									array[7] = 94;
									num2 = 23;
									if (DestroyLiteralProc() == null)
									{
										continue;
									}
									break;
								case 401:
									array[0] = (byte)num15;
									num2 = 345;
									continue;
								case 343:
									intPtr7 = new IntPtr(num50 + ResolveNotificationMethod(stubAuthentication) - num51);
									num2 = 99;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 670:
									array[16] = 11;
									num2 = 530;
									continue;
								case 128:
									array[15] = (byte)num26;
									num2 = 451;
									continue;
								case 515:
									procFacade = (byte[])CollectNotificationMethod(stubAuthentication, def_amount);
									num2 = 471;
									continue;
								case 245:
									if (AwakeNotificationMethod(m_ProducerFacade) == null)
									{
										num2 = 395;
										continue;
									}
									goto case 217;
								case 422:
									array8[6] = 127;
									num2 = 56;
									continue;
								case 575:
									num37 = 0u;
									num2 = 16;
									continue;
								case 276:
									array12[num36 + 5] = array20[5];
									num2 = 539;
									continue;
								case 404:
									value2 = 0L;
									num2 = 137;
									continue;
								case 420:
									array18[4] = 114;
									num2 = 172;
									continue;
								case 484:
									array16 = (byte[])InterruptNotificationMethod(intPtr4.ToInt32());
									num2 = 573;
									continue;
								case 215:
								case 477:
									stubAuthentication = new StubAuthentication((Stream)PostLiteralProc(m_ProducerFacade, "Object.Factory"));
									num2 = 306;
									if (!PublishLiteralProc())
									{
										num2 = 238;
									}
									continue;
								case 381:
									array12[num36] = array16[0];
									num2 = 17;
									if (!PublishLiteralProc())
									{
										num2 = 15;
									}
									continue;
								case 312:
									m_PageFacade = SelectNotificationMethod(_ProcessFacade);
									num = 70;
									break;
								case 411:
									array[30] = (byte)num26;
									num2 = 259;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 119:
									array17 = array;
									num2 = 149;
									continue;
								case 56:
									num25 = 140 - 46;
									num2 = 115;
									continue;
								case 206:
									num25 = 67 - 58;
									num2 = 421;
									continue;
								case 130:
									num26 = 85 + 39;
									num2 = 132;
									continue;
								case 652:
									array[21] = 85;
									num2 = 528;
									continue;
								case 269:
									num35 = array19.Length / 4;
									num2 = 619;
									continue;
								case 660:
									array10[5] = array7[2];
									num2 = 517;
									if (DestroyLiteralProc() == null)
									{
										continue;
									}
									break;
								case 479:
									array[19] = 118;
									num2 = 543;
									if (!PublishLiteralProc())
									{
										num2 = 250;
									}
									continue;
								case 181:
									array18[9] = 100;
									num2 = 122;
									continue;
								case 285:
									num26 = 202 - 67;
									num2 = 318;
									continue;
								case 88:
									array18[0] = 109;
									num2 = 50;
									continue;
								case 292:
									return;
								case 600:
									NewNotificationMethod(array17, 0, array17.Length);
									num = 174;
									break;
								case 454:
									array = new byte[32];
									num2 = 592;
									continue;
								case 350:
									array[7] = (byte)num15;
									num2 = 444;
									if (DestroyLiteralProc() == null)
									{
										continue;
									}
									break;
								case 377:
									array[21] = (byte)num15;
									num = 601;
									break;
								case 588:
									array10[13] = array7[6];
									num2 = 242;
									continue;
								case 60:
									num37 |= array19[^(1 + num41)];
									num2 = 126;
									if (DestroyLiteralProc() == null)
									{
										continue;
									}
									break;
								case 471:
									exporterFacade = default(ExporterFacade);
									num2 = 134;
									if (DestroyLiteralProc() == null)
									{
										continue;
									}
									break;
								case 375:
									array12[num33 + 3] = array16[3];
									num2 = 147;
									continue;
								case 387:
									array15 = (array5 = array14);
									if (array15 != null)
									{
										num2 = 392;
										continue;
									}
									goto end_IL_0012;
								case 42:
									num26 = 136 - 121;
									num2 = 342;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 31:
									num24 = PrintNotificationMethod(new IntPtr(value2));
									num2 = 630;
									continue;
								case 614:
									array12[num33 + 2] = array13[2];
									num2 = 279;
									continue;
								case 499:
									num33 = 23;
									num2 = 441;
									continue;
								case 637:
									m_DatabaseFacade = new Hashtable(ResolveNotificationMethod(stubAuthentication) + 1);
									num2 = 104;
									if (DestroyLiteralProc() == null)
									{
										continue;
									}
									break;
								case 94:
									num26 = 160 - 53;
									num2 = 135;
									continue;
								case 200:
									array[25] = 104;
									num2 = 576;
									continue;
								case 357:
									CountNotificationMethod(new IntPtr(ident.ToInt64() + num32 * 4), ResolveNotificationMethod(stubAuthentication));
									num = 11;
									break;
								case 615:
									ValidateNotificationMethod(FillNotificationMethod(InitNotificationMethod(_CustomerFacade)));
									num2 = 666;
									continue;
								case 11:
									num32++;
									num2 = 376;
									if (DestroyLiteralProc() == null)
									{
										continue;
									}
									break;
								case 33:
									num26 = 16 + 28;
									num2 = 278;
									continue;
								case 125:
									num25 = 213 - 71;
									num = 289;
									break;
								case 446:
									num15 = 242 - 80;
									num2 = 457;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 229:
									num15 = 160 - 53;
									num2 = 220;
									continue;
								case 138:
									array8[14] = 214;
									num2 = 662;
									continue;
								case 662:
									num25 = 106 + 9;
									num2 = 245;
									if (DestroyLiteralProc() == null)
									{
										num2 = 675;
									}
									continue;
								case 628:
									num29 = ResolveNotificationMethod(stubAuthentication);
									num2 = 460;
									continue;
								case 45:
									SortNotificationMethod(new IntPtr(value2), intPtr2);
									num2 = 87;
									continue;
								case 324:
								case 594:
									num46 = 0;
									num = 482;
									break;
								case 199:
									num15 = 100 + 0;
									num2 = 18;
									if (DestroyLiteralProc() == null)
									{
										num2 = 483;
									}
									continue;
								case 255:
									array[23] = 144;
									num2 = 18;
									if (PublishLiteralProc())
									{
										continue;
									}
									break;
								case 135:
									array[10] = (byte)num26;
									num2 = 465;
									continue;
								case 419:
									array11[2] = 116;
									num2 = 643;
									if (DestroyLiteralProc() == null)
									{
										continue;
									}
									break;
								case 462:
									config = PublishStub(intPtr3, b);
									num2 = 224;
									continue;
								case 131:
									array10[9] = array7[4];
									num2 = 396;
									if (DestroyLiteralProc() == null)
									{
										continue;
									}
									break;
								case 295:
									array[3] = 149;
									num2 = 467;
									continue;
								case 155:
									array[14] = 128;
									num = 442;
									break;
								case 612:
									array9[num27] = (byte)(num28 & 0xFFu);
									num2 = 193;
									continue;
								case 146:
									array9[num27 + 2] = (byte)((num28 & 0xFF0000) >> 16);
									num2 = 237;
									continue;
								case 218:
									array8[15] = 107;
									num2 = 589;
									continue;
								case 110:
									array[10] = (byte)num26;
									num2 = 199;
									continue;
								default:
									array8[11] = 137;
									num2 = 578;
									continue;
								case 267:
								case 329:
									intPtr2 = RunNotificationMethod(IntPtr.Zero, (uint)array3.Length, 4096u, 64u);
									num2 = 177;
									continue;
								case 560:
									PopStub(spec, intPtr, (byte[])InterruptNotificationMethod(ResolveNotificationMethod(stubAuthentication)), 4u, out second);
									num2 = 170;
									continue;
								case 46:
									num25 = 220 - 73;
									num2 = 468;
									continue;
								case 494:
								{
									num4 = num3;
									uint num5 = num3;
									uint num6 = 500632071u;
									uint num7 = 85240303u;
									uint num8 = 253651623u;
									uint num9 = 482614650u;
									uint num10 = 269076556u;
									if ((double)num8 == 0.0)
									{
										num8--;
									}
									uint num11 = (uint)((double)num9 / (double)num8 + (double)num8);
									num8 = (uint)((int)(num9 + (short)num6) - (int)num11) + num9;
									if ((double)num7 == 0.0)
									{
										num7--;
									}
									uint num12 = (uint)(779224848.0 / (double)num7 + (double)num7);
									if ((ushort)num6 == 0)
									{
										num6--;
									}
									num7 = (uint)((double)((uint)((double)num9 / (double)(int)(ushort)num6) + num12) + (double)num9);
									if ((double)num6 == 0.0)
									{
										num6--;
									}
									uint num13 = (uint)(1244390521.0 / (double)num6 + (double)num6);
									num6 = (uint)(1174515042 + num13 + -15564);
									if ((double)num9 == 0.0)
									{
										num9--;
									}
									uint num14 = (uint)(1067555206.0 / (double)num9 + (double)num9);
									if (num8 == 0)
									{
										num8--;
									}
									num9 = (uint)((double)((uint)((double)num8 / (double)num8) + num14) + (double)num8);
									num10 = num8 ^ (num8 + num8);
									num5 ^= num5 >> 6;
									num5 += num6;
									num5 ^= num5 << 13;
									num5 += num9;
									num5 ^= num5 >> 5;
									num5 += num10;
									num5 = (((num7 << 13) + num9) ^ num6) - num5;
									num3 = num4 + (uint)(double)num5;
									num2 = 58;
									if (DestroyLiteralProc() == null)
									{
										continue;
									}
									break;
								}
								}
								goto IL_000e_2;
								continue;
								end_IL_0012:
								break;
							}
						}
						goto case 197;
						continue;
						end_IL_4f85:
						break;
					}
					goto case 506;
				case 213:
					text = (string)StartNotificationMethod(DefineNotificationMethod(), array18);
					num2 = 302;
					continue;
				case 70:
					array18 = new byte[12];
					num2 = 88;
					continue;
				case 124:
					array[4] = 61;
					num = 185;
					break;
				case 593:
					array[18] = 159;
					num = 563;
					break;
				case 601:
					array[21] = 92;
					num2 = 544;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 340:
					_MappingFacade = intPtr6.ToInt32();
					num2 = 529;
					continue;
				case 189:
					MoveLiteralProc(new IntPtr(&num42), 0, 0);
					num2 = 107;
					continue;
				case 622:
					num15 = 189 - 63;
					num2 = 25;
					continue;
				case 621:
					array18[11] = 108;
					num = 633;
					break;
				case 519:
					def_amount = ResolveNotificationMethod(stubAuthentication);
					num2 = 515;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 222:
					array8[3] = (byte)num25;
					num2 = 325;
					if (!PublishLiteralProc())
					{
						num2 = 224;
					}
					continue;
				case 645:
					array[1] = (byte)num26;
					num = 64;
					break;
				case 214:
					array[29] = 128;
					num2 = 524;
					continue;
				case 429:
					num25 = 140 - 46;
					num2 = 333;
					continue;
				case 241:
				case 630:
					literalProc = (Process)FillLiteralProc();
					num2 = 106;
					continue;
				case 356:
				case 482:
					if (num46 >= array10.Length)
					{
						num2 = 112;
						continue;
					}
					goto case 280;
				case 187:
					array[10] = (byte)num26;
					num2 = 584;
					continue;
				case 140:
					array5 = new byte[1];
					num2 = 189;
					if (DestroyLiteralProc() == null)
					{
						num2 = 251;
					}
					continue;
				case 487:
					num15 = 105 + 16;
					num2 = 111;
					continue;
				case 532:
					array[8] = 136;
					num2 = 518;
					if (DestroyLiteralProc() == null)
					{
						continue;
					}
					break;
				case 463:
					array12[num36 + 3] = array16[3];
					num2 = 43;
					if (!PublishLiteralProc())
					{
						num2 = 2;
					}
					continue;
				case 457:
					array[12] = (byte)num15;
					num = 542;
					break;
				case 282:
					num37 = (uint)((array19[num45 + 3] << 24) | (array19[num45 + 2] << 16) | (array19[num45 + 1] << 8) | array19[num45]);
					num2 = 346;
					continue;
				case 618:
					array[2] = 128;
					num2 = 295;
					continue;
				case 362:
					array8[13] = 90;
					num2 = 334;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 289:
					array8[6] = (byte)num25;
					num2 = 117;
					continue;
				case 123:
					array12[num33 + 2] = array16[2];
					num2 = 375;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 296:
					num26 = 120 - 41;
					num = 129;
					break;
				case 644:
					array8[2] = 55;
					num2 = 464;
					if (DestroyLiteralProc() == null)
					{
						num2 = 580;
					}
					continue;
				case 537:
					num44 = ResolveNotificationMethod(stubAuthentication);
					num2 = 13;
					continue;
				case 208:
					array[14] = 139;
					num = 370;
					break;
				case 521:
					resolverFacade = false;
					num2 = 461;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 14:
					array[19] = (byte)num26;
					num2 = 20;
					continue;
				case 277:
					array[19] = (byte)num26;
					num2 = 502;
					continue;
				case 559:
					array8[5] = 95;
					num2 = 642;
					if (DestroyLiteralProc() == null)
					{
						continue;
					}
					break;
				case 361:
					num43 = ResolveNotificationMethod(stubAuthentication);
					num2 = 427;
					continue;
				case 424:
					array[21] = (byte)num15;
					num2 = 652;
					continue;
				case 230:
					array8[4] = (byte)num25;
					num2 = 559;
					if (DestroyLiteralProc() != null)
					{
						num2 = 298;
					}
					continue;
				case 511:
					num15 = 112 - 44;
					num2 = 350;
					if (DestroyLiteralProc() != null)
					{
						num2 = 324;
					}
					continue;
				case 322:
					num30++;
					num2 = 389;
					continue;
				case 392:
					if (array5.Length != 0)
					{
						num2 = 386;
						continue;
					}
					goto case 197;
				case 12:
					num26 = 66 + 35;
					num2 = 84;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 259:
					array[31] = 108;
					num2 = 526;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 344:
					num25 = 0 + 57;
					num = 311;
					break;
				case 17:
					array12[num36 + 1] = array16[1];
					num2 = 613;
					continue;
				case 632:
					CancelLiteralProc(new IntPtr(&num42), 0, IntPtr.Zero);
					num2 = 189;
					continue;
				case 517:
					array10[7] = array7[3];
					num2 = 131;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 664:
					if (FlushLiteralProc() == 4)
					{
						num2 = 667;
						if (DestroyLiteralProc() == null)
						{
							continue;
						}
						break;
					}
					goto case 597;
				case 563:
					num26 = 208 + 21;
					num2 = 572;
					continue;
				case 509:
					array8[1] = 143;
					num2 = 327;
					continue;
				case 576:
					num26 = 153 - 111;
					num2 = 93;
					if (DestroyLiteralProc() == null)
					{
						continue;
					}
					break;
				case 573:
					array20 = (byte[])InterruptNotificationMethod(SelectNotificationMethod(num24));
					num2 = 338;
					continue;
				case 631:
					array[28] = (byte)num26;
					num2 = 109;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 313:
					array[7] = (byte)num26;
					num2 = 470;
					continue;
				case 531:
					if (num44 != 1)
					{
						num49 = 0;
						num2 = 374;
						if (PublishLiteralProc())
						{
							continue;
						}
						break;
					}
					num2 = 414;
					continue;
				case 489:
				case 626:
					if (num41 >= num31)
					{
						num2 = 41;
						if (PublishLiteralProc())
						{
							continue;
						}
						break;
					}
					goto case 372;
				case 6:
					intPtr5 = RegisterNotificationMethod(creatorAdapterWatcher);
					num2 = 404;
					continue;
				case 102:
					array8[15] = (byte)num25;
					num2 = 598;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 553:
					PopStub(spec, intPtr, (byte[])InterruptNotificationMethod(ResolveNotificationMethod(stubAuthentication)), 4u, out second);
					num2 = 562;
					continue;
				case 592:
					array[0] = 87;
					num2 = 181;
					if (PublishLiteralProc())
					{
						num2 = 492;
					}
					continue;
				case 371:
					stubAuthentication = new StubAuthentication(new MemoryStream(array14));
					num2 = 22;
					continue;
				case 2:
					if (!DestroyNotificationMethod(PublishNotificationMethod(CalcNotificationMethod(typeof(WriterPropertyProducer).TypeHandle).Assembly), null))
					{
						num2 = 139;
						continue;
					}
					goto case 81;
				case 19:
					num26 = 175 - 58;
					num2 = 433;
					continue;
				case 149:
					array8 = new byte[16];
					num2 = 43;
					if (PublishLiteralProc())
					{
						num2 = 453;
					}
					continue;
				case 40:
				case 587:
					InitLiteralProc(intPtr5, 0);
					num2 = 671;
					if (DestroyLiteralProc() == null)
					{
						continue;
					}
					break;
				case 522:
					array[16] = (byte)num15;
					num = 670;
					break;
				case 400:
					num25 = 165 - 43;
					num = 247;
					break;
				case 96:
					array[12] = (byte)num15;
					num2 = 665;
					continue;
				case 596:
					array[6] = (byte)num15;
					num2 = 288;
					continue;
				case 613:
					array12[num36 + 2] = array16[2];
					num = 463;
					break;
				case 112:
					array19 = array21;
					num2 = 69;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 524:
					num15 = 143 - 47;
					num2 = 221;
					continue;
				case 581:
					array8[0] = 92;
					num2 = 347;
					continue;
				case 308:
					num25 = 11 + 92;
					num2 = 486;
					if (DestroyLiteralProc() == null)
					{
						continue;
					}
					break;
				case 143:
					num26 = 196 + 35;
					num2 = 14;
					if (DestroyLiteralProc() == null)
					{
						num2 = 14;
					}
					continue;
				case 15:
					AssetLiteralProc();
					num2 = 330;
					continue;
				case 485:
					array8[3] = (byte)num25;
					num2 = 235;
					if (DestroyLiteralProc() == null)
					{
						continue;
					}
					break;
				case 556:
					array[3] = (byte)num15;
					num2 = 316;
					continue;
				case 436:
					array[15] = 160;
					num2 = 225;
					continue;
				case 663:
					array[28] = 75;
					num2 = 214;
					continue;
				case 636:
					array[7] = 94;
					num2 = 23;
					if (DestroyLiteralProc() == null)
					{
						continue;
					}
					break;
				case 401:
					array[0] = (byte)num15;
					num2 = 345;
					continue;
				case 343:
					intPtr7 = new IntPtr(num50 + ResolveNotificationMethod(stubAuthentication) - num51);
					num2 = 99;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 670:
					array[16] = 11;
					num2 = 530;
					continue;
				case 128:
					array[15] = (byte)num26;
					num2 = 451;
					continue;
				case 515:
					procFacade = (byte[])CollectNotificationMethod(stubAuthentication, def_amount);
					num2 = 471;
					continue;
				case 245:
					if (AwakeNotificationMethod(m_ProducerFacade) == null)
					{
						num2 = 395;
						continue;
					}
					goto case 217;
				case 422:
					array8[6] = 127;
					num2 = 56;
					continue;
				case 575:
					num37 = 0u;
					num2 = 16;
					continue;
				case 276:
					array12[num36 + 5] = array20[5];
					num2 = 539;
					continue;
				case 404:
					value2 = 0L;
					num2 = 137;
					continue;
				case 420:
					array18[4] = 114;
					num2 = 172;
					continue;
				case 484:
					array16 = (byte[])InterruptNotificationMethod(intPtr4.ToInt32());
					num2 = 573;
					continue;
				case 215:
				case 477:
					stubAuthentication = new StubAuthentication((Stream)PostLiteralProc(m_ProducerFacade, "Object.Factory"));
					num2 = 306;
					if (!PublishLiteralProc())
					{
						num2 = 238;
					}
					continue;
				case 381:
					array12[num36] = array16[0];
					num2 = 17;
					if (!PublishLiteralProc())
					{
						num2 = 15;
					}
					continue;
				case 312:
					m_PageFacade = SelectNotificationMethod(_ProcessFacade);
					num = 70;
					break;
				case 411:
					array[30] = (byte)num26;
					num2 = 259;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 119:
					array17 = array;
					num2 = 149;
					continue;
				case 56:
					num25 = 140 - 46;
					num2 = 115;
					continue;
				case 206:
					num25 = 67 - 58;
					num2 = 421;
					continue;
				case 130:
					num26 = 85 + 39;
					num2 = 132;
					continue;
				case 652:
					array[21] = 85;
					num2 = 528;
					continue;
				case 269:
					num35 = array19.Length / 4;
					num2 = 619;
					continue;
				case 660:
					array10[5] = array7[2];
					num2 = 517;
					if (DestroyLiteralProc() == null)
					{
						continue;
					}
					break;
				case 479:
					array[19] = 118;
					num2 = 543;
					if (!PublishLiteralProc())
					{
						num2 = 250;
					}
					continue;
				case 181:
					array18[9] = 100;
					num2 = 122;
					continue;
				case 285:
					num26 = 202 - 67;
					num2 = 318;
					continue;
				case 88:
					array18[0] = 109;
					num2 = 50;
					continue;
				case 292:
					return;
				case 600:
					NewNotificationMethod(array17, 0, array17.Length);
					num = 174;
					break;
				case 454:
					array = new byte[32];
					num2 = 592;
					continue;
				case 350:
					array[7] = (byte)num15;
					num2 = 444;
					if (DestroyLiteralProc() == null)
					{
						continue;
					}
					break;
				case 377:
					array[21] = (byte)num15;
					num = 601;
					break;
				case 588:
					array10[13] = array7[6];
					num2 = 242;
					continue;
				case 60:
					num37 |= array19[^(1 + num41)];
					num2 = 126;
					if (DestroyLiteralProc() == null)
					{
						continue;
					}
					break;
				case 471:
					exporterFacade = default(ExporterFacade);
					num2 = 134;
					if (DestroyLiteralProc() == null)
					{
						continue;
					}
					break;
				case 375:
					array12[num33 + 3] = array16[3];
					num2 = 147;
					continue;
				case 387:
					array15 = (array5 = array14);
					if (array15 != null)
					{
						num2 = 392;
						continue;
					}
					goto case 197;
				case 42:
					num26 = 136 - 121;
					num2 = 342;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 31:
					num24 = PrintNotificationMethod(new IntPtr(value2));
					num2 = 630;
					continue;
				case 614:
					array12[num33 + 2] = array13[2];
					num2 = 279;
					continue;
				case 499:
					num33 = 23;
					num2 = 441;
					continue;
				case 637:
					m_DatabaseFacade = new Hashtable(ResolveNotificationMethod(stubAuthentication) + 1);
					num2 = 104;
					if (DestroyLiteralProc() == null)
					{
						continue;
					}
					break;
				case 94:
					num26 = 160 - 53;
					num2 = 135;
					continue;
				case 200:
					array[25] = 104;
					num2 = 576;
					continue;
				case 357:
					CountNotificationMethod(new IntPtr(ident.ToInt64() + num32 * 4), ResolveNotificationMethod(stubAuthentication));
					num = 11;
					break;
				case 615:
					ValidateNotificationMethod(FillNotificationMethod(InitNotificationMethod(_CustomerFacade)));
					num2 = 666;
					continue;
				case 11:
					num32++;
					num2 = 376;
					if (DestroyLiteralProc() == null)
					{
						continue;
					}
					break;
				case 33:
					num26 = 16 + 28;
					num2 = 278;
					continue;
				case 125:
					num25 = 213 - 71;
					num = 289;
					break;
				case 446:
					num15 = 242 - 80;
					num2 = 457;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 229:
					num15 = 160 - 53;
					num2 = 220;
					continue;
				case 138:
					array8[14] = 214;
					num2 = 662;
					continue;
				case 662:
					num25 = 106 + 9;
					num2 = 245;
					if (DestroyLiteralProc() == null)
					{
						num2 = 675;
					}
					continue;
				case 628:
					num29 = ResolveNotificationMethod(stubAuthentication);
					num2 = 460;
					continue;
				case 45:
					SortNotificationMethod(new IntPtr(value2), intPtr2);
					num2 = 87;
					continue;
				case 324:
				case 594:
					num46 = 0;
					num = 482;
					break;
				case 199:
					num15 = 100 + 0;
					num2 = 18;
					if (DestroyLiteralProc() == null)
					{
						num2 = 483;
					}
					continue;
				case 255:
					array[23] = 144;
					num2 = 18;
					if (PublishLiteralProc())
					{
						continue;
					}
					break;
				case 135:
					array[10] = (byte)num26;
					num2 = 465;
					continue;
				case 419:
					array11[2] = 116;
					num2 = 643;
					if (DestroyLiteralProc() == null)
					{
						continue;
					}
					break;
				case 462:
					config = PublishStub(intPtr3, b);
					num2 = 224;
					continue;
				case 131:
					array10[9] = array7[4];
					num2 = 396;
					if (DestroyLiteralProc() == null)
					{
						continue;
					}
					break;
				case 295:
					array[3] = 149;
					num2 = 467;
					continue;
				case 155:
					array[14] = 128;
					num = 442;
					break;
				case 612:
					array9[num27] = (byte)(num28 & 0xFFu);
					num2 = 193;
					continue;
				case 146:
					array9[num27 + 2] = (byte)((num28 & 0xFF0000) >> 16);
					num2 = 237;
					continue;
				case 218:
					array8[15] = 107;
					num2 = 589;
					continue;
				case 110:
					array[10] = (byte)num26;
					num2 = 199;
					continue;
				default:
					array8[11] = 137;
					num2 = 578;
					continue;
				case 267:
				case 329:
					intPtr2 = RunNotificationMethod(IntPtr.Zero, (uint)array3.Length, 4096u, 64u);
					num2 = 177;
					continue;
				case 560:
					PopStub(spec, intPtr, (byte[])InterruptNotificationMethod(ResolveNotificationMethod(stubAuthentication)), 4u, out second);
					num2 = 170;
					continue;
				case 46:
					num25 = 220 - 73;
					num2 = 468;
					continue;
				case 494:
				{
					num4 = num3;
					uint num5 = num3;
					uint num6 = 500632071u;
					uint num7 = 85240303u;
					uint num8 = 253651623u;
					uint num9 = 482614650u;
					uint num10 = 269076556u;
					if ((double)num8 == 0.0)
					{
						num8--;
					}
					uint num11 = (uint)((double)num9 / (double)num8 + (double)num8);
					num8 = (uint)((int)(num9 + (short)num6) - (int)num11) + num9;
					if ((double)num7 == 0.0)
					{
						num7--;
					}
					uint num12 = (uint)(779224848.0 / (double)num7 + (double)num7);
					if ((ushort)num6 == 0)
					{
						num6--;
					}
					num7 = (uint)((double)((uint)((double)num9 / (double)(int)(ushort)num6) + num12) + (double)num9);
					if ((double)num6 == 0.0)
					{
						num6--;
					}
					uint num13 = (uint)(1244390521.0 / (double)num6 + (double)num6);
					num6 = (uint)(1174515042 + num13 + -15564);
					if ((double)num9 == 0.0)
					{
						num9--;
					}
					uint num14 = (uint)(1067555206.0 / (double)num9 + (double)num9);
					if (num8 == 0)
					{
						num8--;
					}
					num9 = (uint)((double)((uint)((double)num8 / (double)num8) + num14) + (double)num8);
					num10 = num8 ^ (num8 + num8);
					num5 ^= num5 >> 6;
					num5 += num6;
					num5 ^= num5 << 13;
					num5 += num9;
					num5 ^= num5 >> 5;
					num5 += num10;
					num5 = (((num7 << 13) + num9) ^ num6) - num5;
					num3 = num4 + (uint)(double)num5;
					num2 = 58;
					if (DestroyLiteralProc() == null)
					{
						continue;
					}
					break;
				}
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ChangeStub(object instance)
	{
		try
		{
			if (File.Exists(((Assembly)instance).Location))
			{
				return ((Assembly)instance).Location;
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(((Assembly)instance).GetName().CodeBase!.ToString().Replace("file:///", "")))
			{
				return ((Assembly)instance).GetName().CodeBase!.ToString().Replace("file:///", "");
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(instance.GetType().GetProperty("Location")!.GetValue(instance, new object[0])!.ToString()))
			{
				return instance.GetType().GetProperty("Location")!.GetValue(instance, new object[0])!.ToString();
			}
		}
		catch
		{
		}
		return "";
	}

	[DllImport("kernel32", EntryPoint = "LoadLibrary")]
	public static extern IntPtr CollectStub(string key);

	[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress")]
	public static extern IntPtr PublishStub(IntPtr task, string b);

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static IntPtr NewStub(IntPtr item, object map, uint third)
	{
		if (_InterpreterFacade == null)
		{
			IntPtr ptr = PublishStub(umLocehuEC(), "Find ".Trim() + "ResourceA");
			_InterpreterFacade = (BridgeAuthentication)Marshal.GetDelegateForFunctionPointer(ptr, Type.GetTypeFromHandle(ComposerWorkerStatus.DisableLiteralProc(33562143)));
		}
		return _InterpreterFacade(item, (string)map, third);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static IntPtr SortStub(IntPtr res, uint cfg_max, uint dir_Y, uint connection2)
	{
		if (_TemplateFacade == null)
		{
			IntPtr ptr = PublishStub(umLocehuEC(), "Virtual ".Trim() + "Alloc");
			_TemplateFacade = (RulesAuthentication)Marshal.GetDelegateForFunctionPointer(ptr, Type.GetTypeFromHandle(ComposerWorkerStatus.DisableLiteralProc(33562144)));
		}
		return _TemplateFacade(res, cfg_max, dir_Y, connection2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static int PopStub(IntPtr spec, IntPtr second, [In][Out] byte[] rule, uint IDlast2, out IntPtr second3)
	{
		if (_DecoratorFacade == null)
		{
			IntPtr ptr = PublishStub(umLocehuEC(), "Write ".Trim() + "Process ".Trim() + "Memory");
			_DecoratorFacade = (TagWorkerStatus)Marshal.GetDelegateForFunctionPointer(ptr, Type.GetTypeFromHandle(ComposerWorkerStatus.DisableLiteralProc(33562145)));
		}
		return _DecoratorFacade(spec, second, rule, IDlast2, out second3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static int ListStub(IntPtr ident, int pred_low, int thirdLow, ref int task2)
	{
		if (m_RefFacade == null)
		{
			IntPtr ptr = PublishStub(umLocehuEC(), "Virtual ".Trim() + "Protect");
			m_RefFacade = (FilterAuthentication)Marshal.GetDelegateForFunctionPointer(ptr, Type.GetTypeFromHandle(ComposerWorkerStatus.DisableLiteralProc(33562146)));
		}
		return m_RefFacade(ident, pred_low, thirdLow, ref task2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static IntPtr CompareStub(uint item_count, int b, uint tag)
	{
		if (mapperFacade == null)
		{
			IntPtr ptr = PublishStub(umLocehuEC(), "Open ".Trim() + "Process");
			mapperFacade = (ValWorkerDic)Marshal.GetDelegateForFunctionPointer(ptr, Type.GetTypeFromHandle(ComposerWorkerStatus.DisableLiteralProc(33562147)));
		}
		return mapperFacade(item_count, b, tag);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static int ForgotStub(IntPtr spec)
	{
		if (m_PoolFacade == null)
		{
			IntPtr ptr = PublishStub(umLocehuEC(), "Close ".Trim() + "Handle");
			m_PoolFacade = (BroadcasterOrderAnnotation)Marshal.GetDelegateForFunctionPointer(ptr, Type.GetTypeFromHandle(ComposerWorkerStatus.DisableLiteralProc(33562148)));
		}
		return m_PoolFacade(spec);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	private static IntPtr umLocehuEC()
	{
		if (_PredicateFacade == IntPtr.Zero)
		{
			_PredicateFacade = CollectStub("kernel ".Trim() + "32.dll");
		}
		return _PredicateFacade;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[TestsFacade(typeof(TestsFacade.GetterFacade<object>[]))]
	private static byte[] CountStub(object res)
	{
		using FileStream fileStream = new FileStream((string)res, FileMode.Open, FileAccess.Read, FileShare.Read);
		int num = 0;
		long length = fileStream.Length;
		int num2 = (int)length;
		byte[] array = new byte[num2];
		while (num2 > 0)
		{
			int num3 = fileStream.Read(array, num, num2);
			num += num3;
			num2 -= num3;
		}
		return array;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Stream SearchStub()
	{
		return new MemoryStream();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte[] FillStub(object item)
	{
		return ((MemoryStream)item).ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[TestsFacade(typeof(TestsFacade.GetterFacade<object>[]))]
	private static byte[] LogoutStub(object item)
	{
		Stream stream = SearchStub();
		SymmetricAlgorithm symmetricAlgorithm = PostStub();
		symmetricAlgorithm.Key = new byte[32]
		{
			34, 102, 146, 110, 94, 100, 46, 125, 205, 213,
			137, 156, 78, 250, 94, 0, 184, 220, 167, 203,
			11, 219, 211, 188, 244, 127, 90, 179, 211, 157,
			103, 6
		};
		symmetricAlgorithm.IV = new byte[16]
		{
			32, 204, 254, 234, 8, 76, 167, 51, 111, 129,
			22, 160, 145, 26, 59, 30
		};
		CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write((byte[])item, 0, ((Array)item).Length);
		cryptoStream.Close();
		byte[] result = FillStub(stream);
		GlobalPropertyPolicy.InvokeLiteralProc();
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private byte[] CheckStub()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private byte[] CloneStub()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private byte[] PrintStub()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private byte[] CalcStub()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private byte[] CancelStub()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private byte[] InvokeStub()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte[] PrepareStub()
	{
		string text = "{11111-22222-40001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte[] RateStub()
	{
		string text = "{11111-22222-40001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte[] WriteStub()
	{
		string text = "{11111-22222-50001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte[] FlushStub()
	{
		string text = "{11111-22222-50001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public WriterPropertyProducer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IncludeMethod(object P_0, object P_1)
	{
		return ((Assembly)P_0).GetManifestResourceStream((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CloneMethod(object P_0)
	{
		return ((StubAuthentication)P_0).KDikMXewCI();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopMethod(object P_0, long P_1)
	{
		((Stream)P_0).Position = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long NewMethod(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PatchMethod(object P_0, int def_amount)
	{
		return ((StubAuthentication)P_0).AssetStub(def_amount);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartMethod(object P_0)
	{
		((StubAuthentication)P_0).CreateWrapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeMethod(object P_0)
	{
		Array.Reverse((Array)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WriteMethod(object P_0)
	{
		return ((Assembly)P_0).GetName();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ResolveMethod(object P_0)
	{
		return ((AssemblyName)P_0).GetPublicKeyToken();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SetupMethod()
	{
		return PostStub();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutMethod(object P_0, CipherMode P_1)
	{
		((SymmetricAlgorithm)P_0).Mode = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ComputeMethod(object P_0, object P_1, object P_2)
	{
		return ((SymmetricAlgorithm)P_0).CreateDecryptor((byte[])P_1, (byte[]?)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ChangeMethod()
	{
		return SearchStub();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertMethod(object P_0, object P_1, int P_2, int P_3)
	{
		((Stream)P_0).Write((byte[])P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageMethod(object P_0)
	{
		((CryptoStream)P_0).FlushFinalBlock();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object RateMethod(object P_0)
	{
		return FillStub(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeMethod(object P_0)
	{
		((Stream)P_0).Close();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int CreateMethod(object P_0, int P_1)
	{
		return BitConverter.ToInt32((byte[])P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateMethod()
	{
		GlobalPropertyPolicy.InvokeLiteralProc();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object InterruptMethod()
	{
		return Encoding.Unicode;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OrderMethod(object P_0, object P_1, int P_2, int P_3)
	{
		return ((Encoding)P_0).GetString((byte[])P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ConcatMethod()
	{
		return (object)null == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CollectMethod()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CancelManager()
	{
		GlobalPropertyPolicy.InvokeLiteralProc();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoveManager(bool P_0)
	{
		RSACryptoServiceProvider.UseMachineKeyStore = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type UpdateManager(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DeleteManager(object P_0)
	{
		return ((Assembly)P_0).Location;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int GetManager(object P_0)
	{
		return ((string)P_0).Length;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object AssetManager()
	{
		return SHA1.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FillManager(object P_0)
	{
		return CryptoConfig.MapNameToOID((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ValidateManager(object P_0)
	{
		return File.Exists((string?)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ListManager(object P_0, object P_1)
	{
		return ((Assembly)P_0).GetManifestResourceStream((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object RunManager(object P_0)
	{
		return ((StubAuthentication)P_0).KDikMXewCI();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortManager(object P_0, long P_1)
	{
		((Stream)P_0).Position = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long VerifyManager(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FlushManager(object P_0, int def_amount)
	{
		return ((StubAuthentication)P_0).AssetStub(def_amount);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ResetManager()
	{
		return PostStub();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateManager(object P_0, CipherMode P_1)
	{
		((SymmetricAlgorithm)P_0).Mode = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SetManager(object P_0, object P_1, object P_2)
	{
		return ((SymmetricAlgorithm)P_0).CreateDecryptor((byte[])P_1, (byte[]?)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PopManager()
	{
		return SearchStub();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareManager(object P_0, object P_1, int P_2, int P_3)
	{
		((Stream)P_0).Write((byte[])P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallManager(object P_0)
	{
		((CryptoStream)P_0).FlushFinalBlock();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CheckManager()
	{
		return Encoding.UTF8;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ForgotManager(object P_0)
	{
		return FillStub(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CompareManager(object P_0, object P_1)
	{
		return ((Encoding)P_0).GetString((byte[])P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VisitManager(object P_0, object P_1)
	{
		((AsymmetricAlgorithm)P_0).FromXmlString((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ViewManager(object P_0)
	{
		((Stream)P_0).Close();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchManager(object P_0)
	{
		((StubAuthentication)P_0).CreateWrapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectManager(object P_0, object P_1, uint offset_comp, object P_3)
	{
		OrderStub(P_0, P_1, offset_comp, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ushort QueryManager(object P_0)
	{
		return ((BinaryReader)P_0).ReadUInt16();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int AddManager(object P_0, object P_1, int P_2, int P_3)
	{
		return ((Stream)P_0).Read((byte[])P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeManager(object P_0, object P_1, int offsetproc, int nextselection2)
	{
		IncludeStub(P_0, P_1, offsetproc, nextselection2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long PostManager(object P_0)
	{
		return ((Stream)P_0).Position;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static uint FindManager(object P_0)
	{
		return ((BinaryReader)P_0).ReadUInt32();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static uint RevertManager(uint max_reference, int indexOf_counter, long role_counter, object P_3)
	{
		return EnableStub(max_reference, indexOf_counter, role_counter, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long ConcatWorker(long P_0, long P_1)
	{
		return Math.Min(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CollectWorker(object P_0, object P_1, int P_2, int P_3)
	{
		return ((HashAlgorithm)P_0).TransformFinalBlock((byte[])P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IncludeWorker(object P_0, int P_1)
	{
		return ((BinaryReader)P_0).ReadBytes(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CloneWorker(object P_0)
	{
		Array.Reverse((Array)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object StopWorker(object P_0)
	{
		return ((HashAlgorithm)P_0).Hash;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool NewWorker(object P_0, object P_1, object P_2, object P_3)
	{
		return ((RSACryptoServiceProvider)P_0).VerifyHash((byte[])P_1, (string)P_2, (byte[])P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PatchWorker(object P_0)
	{
		return ((Assembly)P_0).GetName();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object RestartWorker(object P_0)
	{
		return ((AssemblyName)P_0).Name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object AwakeWorker(object P_0, object P_1)
	{
		return (string?)P_0 + (string?)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool PushManager()
	{
		return (object)null == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ReflectManager()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr InitLiteralProc(IntPtr P_0, int P_1)
	{
		return Marshal.ReadIntPtr(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int PushLiteralProc(IntPtr P_0, int P_1)
	{
		return Marshal.ReadInt32(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long ReflectLiteralProc(IntPtr P_0, int P_1)
	{
		return Marshal.ReadInt64(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CancelLiteralProc(IntPtr P_0, int P_1, IntPtr P_2)
	{
		Marshal.WriteIntPtr(P_0, P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoveLiteralProc(IntPtr P_0, int P_1, int P_2)
	{
		Marshal.WriteInt32(P_0, P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateLiteralProc(IntPtr P_0, int P_1, long P_2)
	{
		Marshal.WriteInt64(P_0, P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr DeleteLiteralProc(int P_0)
	{
		return Marshal.AllocCoTaskMem(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GetLiteralProc(object P_0, int P_1, IntPtr P_2, int P_3)
	{
		Marshal.Copy((byte[])P_0, P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetLiteralProc()
	{
		MoveStub();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FillLiteralProc()
	{
		return Process.GetCurrentProcess();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ValidateLiteralProc(object P_0)
	{
		return ((Process)P_0).MainModule;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr ListLiteralProc(object P_0)
	{
		return ((ProcessModule)P_0).BaseAddress;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr RunLiteralProc(IntPtr item, object P_1, uint third)
	{
		return NewStub(item, P_1, third);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SortLiteralProc(IntPtr P_0, IntPtr P_1)
	{
		return P_0 != P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyLiteralProc()
	{
		GlobalPropertyPolicy.InvokeLiteralProc();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int FlushLiteralProc()
	{
		return IntPtr.Size;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type ResetLiteralProc(object P_0, bool P_1)
	{
		return Type.GetType((string)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CalculateLiteralProc(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SetLiteralProc(object P_0)
	{
		return ((Process)P_0).Modules;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PopLiteralProc(object P_0)
	{
		return ((ReadOnlyCollectionBase)P_0).GetEnumerator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PrepareLiteralProc(object P_0)
	{
		return ((IEnumerator)P_0).Current;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CallLiteralProc(object P_0)
	{
		return ((ProcessModule)P_0).ModuleName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CheckLiteralProc(object P_0)
	{
		return ((string)P_0).ToLower();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ForgotLiteralProc(object P_0, object P_1)
	{
		return (string?)P_0 == (string?)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object TestLiteralProc(object P_0)
	{
		return ((ProcessModule)P_0).FileVersionInfo;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int CompareLiteralProc(object P_0)
	{
		return ((FileVersionInfo)P_0).ProductMajorPart;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int VisitLiteralProc(object P_0)
	{
		return ((FileVersionInfo)P_0).ProductMinorPart;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int ViewLiteralProc(object P_0)
	{
		return ((FileVersionInfo)P_0).ProductBuildPart;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int SearchLiteralProc(object P_0)
	{
		return ((FileVersionInfo)P_0).ProductPrivatePart;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ConnectLiteralProc(object P_0, object P_1)
	{
		return (Version?)P_0 >= (Version?)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool QueryLiteralProc(object P_0, object P_1)
	{
		return (Version?)P_0 < (Version?)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AddLiteralProc(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeLiteralProc(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PostLiteralProc(object P_0, object P_1)
	{
		return ((Assembly)P_0).GetManifestResourceStream((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FindLiteralProc(object P_0)
	{
		return ((StubAuthentication)P_0).KDikMXewCI();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RevertLiteralProc(object P_0, long P_1)
	{
		((Stream)P_0).Position = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long ConcatNotificationMethod(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CollectNotificationMethod(object P_0, int def_amount)
	{
		return ((StubAuthentication)P_0).AssetStub(def_amount);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeNotificationMethod(object P_0)
	{
		Array.Reverse((Array)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CloneNotificationMethod(object P_0)
	{
		return ((Assembly)P_0).GetName();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object StopNotificationMethod(object P_0)
	{
		return ((AssemblyName)P_0).GetPublicKeyToken();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewNotificationMethod(object P_0, int P_1, int P_2)
	{
		Array.Clear((Array)P_0, P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PatchNotificationMethod(object P_0)
	{
		return ((Assembly)P_0).GetModules();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr RestartNotificationMethod(object P_0)
	{
		return Marshal.GetHINSTANCE((Module)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object AwakeNotificationMethod(object P_0)
	{
		return ((Assembly)P_0).Location;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int WriteNotificationMethod(object P_0)
	{
		return ((string)P_0).Length;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int ResolveNotificationMethod(object P_0)
	{
		return ((StubAuthentication)P_0).RevertStub();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SetupNotificationMethod()
	{
		return PostStub();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutNotificationMethod(object P_0, CipherMode P_1)
	{
		((SymmetricAlgorithm)P_0).Mode = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ComputeNotificationMethod(object P_0, object P_1, object P_2)
	{
		return ((SymmetricAlgorithm)P_0).CreateDecryptor((byte[])P_1, (byte[]?)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeNotificationMethod(object P_0, object P_1, int P_2, int P_3)
	{
		((Stream)P_0).Write((byte[])P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertNotificationMethod(object P_0)
	{
		((CryptoStream)P_0).FlushFinalBlock();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ManageNotificationMethod(object P_0)
	{
		return ((MemoryStream)P_0).ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateNotificationMethod(object P_0)
	{
		((Stream)P_0).Close();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeNotificationMethod(object P_0)
	{
		((StubAuthentication)P_0).CreateWrapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int CreateNotificationMethod(object P_0)
	{
		return ((Process)P_0).Id;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr InstantiateNotificationMethod(uint item_count, int b, uint tag)
	{
		return CompareStub(item_count, b, tag);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object InterruptNotificationMethod(int P_0)
	{
		return BitConverter.GetBytes(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long OrderNotificationMethod(object P_0)
	{
		return ((Stream)P_0).Position;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountNotificationMethod(IntPtr P_0, int P_1)
	{
		Marshal.WriteInt32(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int MapNotificationMethod(IntPtr spec)
	{
		return ForgotStub(spec);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveNotificationMethod(object P_0, object P_1, object P_2)
	{
		((Hashtable)P_0).Add(P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type CalcNotificationMethod(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int SelectNotificationMethod(long P_0)
	{
		return Convert.ToInt32(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DefineNotificationMethod()
	{
		return Encoding.UTF8;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object StartNotificationMethod(object P_0, object P_1)
	{
		return ((Encoding)P_0).GetString((byte[])P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool EnableNotificationMethod(IntPtr P_0, IntPtr P_1)
	{
		return P_0 == P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ReadNotificationMethod(IntPtr config, Type counter)
	{
		return InitStub(config, counter);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr RegisterNotificationMethod(object P_0)
	{
		return P_0();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int PrintNotificationMethod(IntPtr P_0)
	{
		return Marshal.ReadInt32(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long InvokeNotificationMethod(IntPtr P_0)
	{
		return Marshal.ReadInt64(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr DisableNotificationMethod(object P_0)
	{
		return Marshal.GetFunctionPointerForDelegate((Delegate)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int LoginNotificationMethod(object P_0)
	{
		return ((ProcessModule)P_0).ModuleMemorySize;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PublishNotificationMethod(object P_0)
	{
		return ((Assembly)P_0).EntryPoint;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DestroyNotificationMethod(object P_0, object P_1)
	{
		return (MethodInfo?)P_0 != (MethodInfo?)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object InitNotificationMethod(object P_0)
	{
		return ((Delegate)P_0).Method;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PushNotificationMethod(Type P_0, object P_1)
	{
		return Delegate.CreateDelegate(P_0, (MethodInfo)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ReflectNotificationMethod(object P_0)
	{
		return ((MethodBase)P_0).GetParameters();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CancelNotificationMethod(object P_0)
	{
		return ((Assembly)P_0).ManifestModule;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ModuleHandle MoveNotificationMethod(object P_0)
	{
		return ((Module)P_0).ModuleHandle;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type UpdateNotificationMethod(object P_0)
	{
		return P_0.GetType();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DeleteNotificationMethod(object P_0, object P_1)
	{
		return ((FieldInfo)P_0).GetValue(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GetNotificationMethod(long P_0)
	{
		return BitConverter.GetBytes(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetNotificationMethod(object P_0)
	{
		RuntimeHelpers.PrepareDelegate((Delegate)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RuntimeMethodHandle FillNotificationMethod(object P_0)
	{
		return ((MethodBase)P_0).MethodHandle;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateNotificationMethod(RuntimeMethodHandle P_0)
	{
		RuntimeHelpers.PrepareMethod(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ListNotificationMethod(object P_0, RuntimeFieldHandle P_1)
	{
		RuntimeHelpers.InitializeArray((Array)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr RunNotificationMethod(IntPtr res, uint cfg_max, uint dir_Y, uint connection2)
	{
		return SortStub(res, cfg_max, dir_Y, connection2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortNotificationMethod(IntPtr P_0, IntPtr P_1)
	{
		Marshal.WriteIntPtr(P_0, P_1);
	}

	internal static bool PublishLiteralProc()
	{
		return (object)null == null;
	}

	internal static object DestroyLiteralProc()
	{
		return null;
	}
}
