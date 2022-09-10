using System;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class IndexObject
{
	private object[] m_objects;

	private byte[] m_compiledForm;

	public bool IsCompiled => null != m_compiledForm;

	public bool CanCompile => null != m_objects;

	public byte[] CompiledForm => m_compiledForm;

	public object[] ObjectList => m_objects;

	public IndexObject(object[] objects)
	{
		m_objects = objects;
	}

	public IndexObject(byte[] compiledForm)
	{
		m_compiledForm = compiledForm;
	}

	internal void Compile(SecondaryIndexDefinition indexDef)
	{
		if (!CanCompile)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new InvalidOperationException(SR.GetString("StoreIndexObjectCanNotBeCompiled")));
		}
		byte[] array = new byte[60];
		int num = 0;
		for (int i = 0; i < m_objects.Length; i++)
		{
			if (indexDef.Canonicalizer.CanCanonicalize(m_objects[i]))
			{
				byte[] array2 = indexDef.Canonicalizer.Canonicalize(m_objects[i]);
				if (array2.Length + num <= array.Length)
				{
					Array.Copy(array2, 0, array, num, array2.Length);
					num += array2.Length;
					continue;
				}
				throw InfoCardTrace.ThrowHelperError((Exception)new InvalidOperationException(SR.GetString("StoreIndexObjectBufferOverflow", new object[1] { indexDef.Name })));
			}
			throw InfoCardTrace.ThrowHelperError((Exception)new InvalidOperationException(SR.GetString("StoreIndexObjectCanNotBeCanonicalized", new object[1] { m_objects[i].GetType() })));
		}
		m_compiledForm = array;
	}
}
