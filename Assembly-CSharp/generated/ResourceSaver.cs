/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace GodotEngine {

public class ResourceSaver : Object {
  private static ResourceSaver instance;
  public static readonly int FLAG_RELATIVE_PATHS = 1;
  public static readonly int FLAG_BUNDLE_RESOURCES = 2;
  public static readonly int FLAG_CHANGE_PATH = 4;
  public static readonly int FLAG_OMIT_EDITOR_PROPERTIES = 8;
  public static readonly int FLAG_SAVE_BIG_ENDIAN = 16;
  public static readonly int FLAG_COMPRESS = 32;

  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
  internal ResourceSaver(global::System.IntPtr cPtr, bool cMemoryOwn) : base(GodotEnginePINVOKE.ResourceSaver_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }  
  
  protected ResourceSaver(bool cMemoryOwn) : base(cMemoryOwn) {}
  
  new internal void internal_init(global::System.IntPtr cPtr) {
    base.internal_init(GodotEnginePINVOKE.ResourceSaver_SWIGUpcast(cPtr));
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }
  
  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ResourceSaver obj) {
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

  public static ResourceSaver Instance {
    get {
      if (instance == null) {
        instance = SingletonGetInstance();
      }
      return instance;
    }
  }

  internal ResourceSaver() {}


  public int save(string path, SWIGTYPE_p_RefT_Resource_t resource, int flags) {
    int ret = GodotEnginePINVOKE.ResourceSaver_save__SWIG_0(swigCPtr, path, SWIGTYPE_p_RefT_Resource_t.getCPtr(resource), flags);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int save(string path, SWIGTYPE_p_RefT_Resource_t resource) {
    int ret = GodotEnginePINVOKE.ResourceSaver_save__SWIG_1(swigCPtr, path, SWIGTYPE_p_RefT_Resource_t.getCPtr(resource));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_StringArray get_recognized_extensions(Object type) {
    SWIGTYPE_p_StringArray ret = new SWIGTYPE_p_StringArray(GodotEnginePINVOKE.ResourceSaver_get_recognized_extensions(swigCPtr, Object.getCPtr(type)), true);
    return ret;
  }

  private static ResourceSaver SingletonGetInstance() {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.ResourceSaver_SingletonGetInstance();
    ResourceSaver ret = (cPtr == global::System.IntPtr.Zero) ? null : new ResourceSaver(cPtr, false);
    return ret;
  }

}

}
