/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace GodotEngine {

public class ResourceInteractiveLoader : Reference {

  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
  internal ResourceInteractiveLoader(global::System.IntPtr cPtr, bool cMemoryOwn) : base(GodotEnginePINVOKE.ResourceInteractiveLoader_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }  
  
  protected ResourceInteractiveLoader(bool cMemoryOwn) : base(cMemoryOwn) {}
  
  new internal void internal_init(global::System.IntPtr cPtr) {
    base.internal_init(GodotEnginePINVOKE.ResourceInteractiveLoader_SWIGUpcast(cPtr));
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }
  
  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ResourceInteractiveLoader obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          throw new global::System.MethodAccessException("C++ destructor does not have public access");
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  internal ResourceInteractiveLoader() {}


  public Object get_resource() {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.ResourceInteractiveLoader_get_resource(swigCPtr);
    if (cPtr == global::System.IntPtr.Zero)
    	return null;
    Object ret = InternalHelpers.UnmanagedGetManaged(cPtr) as Object;
    return ret;
  }

  public int poll() {
    int ret = GodotEnginePINVOKE.ResourceInteractiveLoader_poll(swigCPtr);
    return ret;
  }

  public int wait() {
    int ret = GodotEnginePINVOKE.ResourceInteractiveLoader_wait(swigCPtr);
    return ret;
  }

  public int get_stage() {
    int ret = GodotEnginePINVOKE.ResourceInteractiveLoader_get_stage(swigCPtr);
    return ret;
  }

  public int get_stage_count() {
    int ret = GodotEnginePINVOKE.ResourceInteractiveLoader_get_stage_count(swigCPtr);
    return ret;
  }

}

}
