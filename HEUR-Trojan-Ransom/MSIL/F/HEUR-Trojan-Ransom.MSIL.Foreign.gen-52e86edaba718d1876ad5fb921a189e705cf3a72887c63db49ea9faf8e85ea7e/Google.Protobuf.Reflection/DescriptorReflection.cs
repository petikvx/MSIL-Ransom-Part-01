using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace Google.Protobuf.Reflection;

internal static class DescriptorReflection
{
	private static FileDescriptor descriptor;

	[NonSerialized]
	internal static GetString getString_0;

	public static FileDescriptor Descriptor => descriptor;

	static DescriptorReflection()
	{
		Strings.CreateGetStringDelegate(typeof(DescriptorReflection));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107400176), getString_0(107400171)).Replace(getString_0(107400134), getString_0(107400129)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107400124)))
		{
			throw new SecurityException(getString_0(107400099));
		}
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(getString_0(107452820) + getString_0(107453219) + getString_0(107453170) + getString_0(107453057) + getString_0(107453008) + getString_0(107452383) + getString_0(107452334) + getString_0(107452221) + getString_0(107452684) + getString_0(107452571) + getString_0(107452490) + getString_0(107451929) + getString_0(107451816) + getString_0(107451767) + getString_0(107452166) + getString_0(107452117) + getString_0(107452004) + getString_0(107451443) + getString_0(107451330) + getString_0(107451281) + getString_0(107451680) + getString_0(107451631) + getString_0(107451518) + getString_0(107451469) + getString_0(107450844) + getString_0(107450795) + getString_0(107450714) + getString_0(107451113) + getString_0(107451064) + getString_0(107450951) + getString_0(107450390) + getString_0(107450277) + getString_0(107450228) + getString_0(107450627) + getString_0(107450578) + getString_0(107450465) + getString_0(107449904) + getString_0(107449791) + getString_0(107449742) + getString_0(107450141) + getString_0(107450092) + getString_0(107449979) + getString_0(107482154) + getString_0(107482105) + getString_0(107481992) + getString_0(107481943) + getString_0(107482342) + getString_0(107482293) + getString_0(107482180) + getString_0(107481619) + getString_0(107481506) + getString_0(107481457) + getString_0(107481856) + getString_0(107481807) + getString_0(107481694) + getString_0(107481133) + getString_0(107481020) + getString_0(107480971) + getString_0(107481402) + getString_0(107481289) + getString_0(107481240) + getString_0(107480615) + getString_0(107480566) + getString_0(107480453) + getString_0(107480404) + getString_0(107480803) + getString_0(107480754) + getString_0(107480641) + getString_0(107480080) + getString_0(107479967) + getString_0(107479918) + getString_0(107480317) + getString_0(107480268) + getString_0(107480155) + getString_0(107479562) + getString_0(107479513) + getString_0(107479400) + getString_0(107479863) + getString_0(107479750) + getString_0(107479701) + getString_0(107479076) + getString_0(107479027) + getString_0(107478914) + getString_0(107478865) + getString_0(107479264) + getString_0(107479215) + getString_0(107479102) + getString_0(107478541) + getString_0(107478428) + getString_0(107478379) + getString_0(107478810) + getString_0(107478697) + getString_0(107478648) + getString_0(107478023) + getString_0(107477974) + getString_0(107477861) + getString_0(107478324) + getString_0(107478211) + getString_0(107478162) + getString_0(107477537) + getString_0(107477488) + getString_0(107477375) + getString_0(107477326) + getString_0(107477725) + getString_0(107477676) + getString_0(107477563) + getString_0(107476970) + getString_0(107476921) + getString_0(107476808) + getString_0(107477271) + getString_0(107477158) + getString_0(107477109) + getString_0(107476484) + getString_0(107476435) + getString_0(107476322) + getString_0(107476785) + getString_0(107476672) + getString_0(107476623) + getString_0(107475998) + getString_0(107475949) + getString_0(107475836) + getString_0(107475787) + getString_0(107476218) + getString_0(107476105) + getString_0(107476056) + getString_0(107475431) + getString_0(107475382) + getString_0(107475269) + getString_0(107475732) + getString_0(107475619) + getString_0(107475570) + getString_0(107474945) + getString_0(107474896)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[21]
		{
			new GeneratedClrTypeInfo(typeof(FileDescriptorSet), FileDescriptorSet.Parser, new string[1] { getString_0(107474839) }, null, null, null),
			new GeneratedClrTypeInfo(typeof(FileDescriptorProto), FileDescriptorProto.Parser, new string[12]
			{
				getString_0(107393187),
				getString_0(107474830),
				getString_0(107474785),
				getString_0(107474800),
				getString_0(107474775),
				getString_0(107475234),
				getString_0(107475249),
				getString_0(107475204),
				getString_0(107475223),
				getString_0(107461258),
				getString_0(107475178),
				getString_0(107461234)
			}, null, null, null),
			new GeneratedClrTypeInfo(typeof(DescriptorProto), DescriptorProto.Parser, new string[10]
			{
				getString_0(107393187),
				getString_0(107392556),
				getString_0(107475223),
				getString_0(107475189),
				getString_0(107475249),
				getString_0(107475140),
				getString_0(107475151),
				getString_0(107461258),
				getString_0(107475106),
				getString_0(107475117)
			}, null, null, new GeneratedClrTypeInfo[2]
			{
				new GeneratedClrTypeInfo(typeof(DescriptorProto.Types.ExtensionRange), DescriptorProto.Types.ExtensionRange.Parser, new string[3]
				{
					getString_0(107475068),
					getString_0(107475091),
					getString_0(107461258)
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(DescriptorProto.Types.ReservedRange), DescriptorProto.Types.ReservedRange.Parser, new string[2]
				{
					getString_0(107475068),
					getString_0(107475091)
				}, null, null, null)
			}),
			new GeneratedClrTypeInfo(typeof(ExtensionRangeOptions), ExtensionRangeOptions.Parser, new string[1] { getString_0(107475086) }, null, null, null),
			new GeneratedClrTypeInfo(typeof(FieldDescriptorProto), FieldDescriptorProto.Parser, new string[10]
			{
				getString_0(107393187),
				getString_0(107454184),
				getString_0(107475057),
				getString_0(107393228),
				getString_0(107361446),
				getString_0(107475016),
				getString_0(107454168),
				getString_0(107454175),
				getString_0(107454149),
				getString_0(107461258)
			}, null, new Type[2]
			{
				typeof(FieldDescriptorProto.Types.Type),
				typeof(FieldDescriptorProto.Types.Label)
			}, null),
			new GeneratedClrTypeInfo(typeof(OneofDescriptorProto), OneofDescriptorProto.Parser, new string[2]
			{
				getString_0(107393187),
				getString_0(107461258)
			}, null, null, null),
			new GeneratedClrTypeInfo(typeof(EnumDescriptorProto), EnumDescriptorProto.Parser, new string[5]
			{
				getString_0(107393187),
				getString_0(107390826),
				getString_0(107461258),
				getString_0(107475106),
				getString_0(107475117)
			}, null, null, new GeneratedClrTypeInfo[1]
			{
				new GeneratedClrTypeInfo(typeof(EnumDescriptorProto.Types.EnumReservedRange), EnumDescriptorProto.Types.EnumReservedRange.Parser, new string[2]
				{
					getString_0(107475068),
					getString_0(107475091)
				}, null, null, null)
			}),
			new GeneratedClrTypeInfo(typeof(EnumValueDescriptorProto), EnumValueDescriptorProto.Parser, new string[3]
			{
				getString_0(107393187),
				getString_0(107454184),
				getString_0(107461258)
			}, null, null, null),
			new GeneratedClrTypeInfo(typeof(ServiceDescriptorProto), ServiceDescriptorProto.Parser, new string[3]
			{
				getString_0(107393187),
				getString_0(107475003),
				getString_0(107461258)
			}, null, null, null),
			new GeneratedClrTypeInfo(typeof(MethodDescriptorProto), MethodDescriptorProto.Parser, new string[6]
			{
				getString_0(107393187),
				getString_0(107475026),
				getString_0(107474469),
				getString_0(107461258),
				getString_0(107474484),
				getString_0(107474431)
			}, null, null, null),
			new GeneratedClrTypeInfo(typeof(FileOptions), FileOptions.Parser, new string[19]
			{
				getString_0(107474410),
				getString_0(107474425),
				getString_0(107474368),
				getString_0(107474343),
				getString_0(107474306),
				getString_0(107474277),
				getString_0(107474292),
				getString_0(107474247),
				getString_0(107474254),
				getString_0(107474737),
				getString_0(107474712),
				getString_0(107474655),
				getString_0(107474670),
				getString_0(107474649),
				getString_0(107474596),
				getString_0(107474607),
				getString_0(107474558),
				getString_0(107474537),
				getString_0(107475086)
			}, null, new Type[1] { typeof(FileOptions.Types.OptimizeMode) }, null),
			new GeneratedClrTypeInfo(typeof(MessageOptions), MessageOptions.Parser, new string[5]
			{
				getString_0(107474552),
				getString_0(107474491),
				getString_0(107474655),
				getString_0(107473970),
				getString_0(107475086)
			}, null, null, null),
			new GeneratedClrTypeInfo(typeof(FieldOptions), FieldOptions.Parser, new string[7]
			{
				getString_0(107473925),
				getString_0(107454190),
				getString_0(107473916),
				getString_0(107473939),
				getString_0(107474655),
				getString_0(107473898),
				getString_0(107475086)
			}, null, new Type[2]
			{
				typeof(FieldOptions.Types.CType),
				typeof(FieldOptions.Types.JSType)
			}, null),
			new GeneratedClrTypeInfo(typeof(OneofOptions), OneofOptions.Parser, new string[1] { getString_0(107475086) }, null, null, null),
			new GeneratedClrTypeInfo(typeof(EnumOptions), EnumOptions.Parser, new string[3]
			{
				getString_0(107473889),
				getString_0(107474655),
				getString_0(107475086)
			}, null, null, null),
			new GeneratedClrTypeInfo(typeof(EnumValueOptions), EnumValueOptions.Parser, new string[2]
			{
				getString_0(107474655),
				getString_0(107475086)
			}, null, null, null),
			new GeneratedClrTypeInfo(typeof(ServiceOptions), ServiceOptions.Parser, new string[2]
			{
				getString_0(107474655),
				getString_0(107475086)
			}, null, null, null),
			new GeneratedClrTypeInfo(typeof(MethodOptions), MethodOptions.Parser, new string[3]
			{
				getString_0(107474655),
				getString_0(107473904),
				getString_0(107475086)
			}, null, new Type[1] { typeof(MethodOptions.Types.IdempotencyLevel) }, null),
			new GeneratedClrTypeInfo(typeof(UninterpretedOption), UninterpretedOption.Parser, new string[7]
			{
				getString_0(107393187),
				getString_0(107473879),
				getString_0(107473826),
				getString_0(107473801),
				getString_0(107473808),
				getString_0(107457494),
				getString_0(107473759)
			}, null, null, new GeneratedClrTypeInfo[1]
			{
				new GeneratedClrTypeInfo(typeof(UninterpretedOption.Types.NamePart), UninterpretedOption.Types.NamePart.Parser, new string[2]
				{
					getString_0(107473738),
					getString_0(107473725)
				}, null, null, null)
			}),
			new GeneratedClrTypeInfo(typeof(SourceCodeInfo), SourceCodeInfo.Parser, new string[1] { getString_0(107473740) }, null, null, new GeneratedClrTypeInfo[1]
			{
				new GeneratedClrTypeInfo(typeof(SourceCodeInfo.Types.Location), SourceCodeInfo.Types.Location.Parser, new string[5]
				{
					getString_0(107474207),
					getString_0(107474230),
					getString_0(107474221),
					getString_0(107474200),
					getString_0(107474143)
				}, null, null, null)
			}),
			new GeneratedClrTypeInfo(typeof(GeneratedCodeInfo), GeneratedCodeInfo.Parser, new string[1] { getString_0(107474110) }, null, null, new GeneratedClrTypeInfo[1]
			{
				new GeneratedClrTypeInfo(typeof(GeneratedCodeInfo.Types.Annotation), GeneratedCodeInfo.Types.Annotation.Parser, new string[4]
				{
					getString_0(107474207),
					getString_0(107474125),
					getString_0(107474076),
					getString_0(107475091)
				}, null, null, null)
			})
		}));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
