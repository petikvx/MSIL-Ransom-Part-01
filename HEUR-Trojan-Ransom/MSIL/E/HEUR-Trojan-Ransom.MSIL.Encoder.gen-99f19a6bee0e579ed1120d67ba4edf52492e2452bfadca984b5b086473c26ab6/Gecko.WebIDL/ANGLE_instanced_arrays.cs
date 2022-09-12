namespace Gecko.WebIDL;

public class ANGLE_instanced_arrays : WebIDLBase
{
	public ANGLE_instanced_arrays(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void DrawArraysInstancedANGLE(uint mode, int first, int count, int primcount)
	{
		CallVoidMethod("drawArraysInstancedANGLE", mode, first, count, primcount);
	}

	public void DrawElementsInstancedANGLE(uint mode, int count, uint type, long offset, int primcount)
	{
		CallVoidMethod("drawElementsInstancedANGLE", mode, count, type, offset, primcount);
	}

	public void VertexAttribDivisorANGLE(uint index, uint divisor)
	{
		CallVoidMethod("vertexAttribDivisorANGLE", index, divisor);
	}
}
