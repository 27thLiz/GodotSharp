/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace GodotEngine {

public class ResourceLoader : Object {
  private static ResourceLoader instance;

  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
  internal ResourceLoader(global::System.IntPtr cPtr, bool cMemoryOwn) : base(GodotEnginePINVOKE.ResourceLoader_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }  
  
  protected ResourceLoader(bool cMemoryOwn) : base(cMemoryOwn) {}
  
  new internal void internal_init(global::System.IntPtr cPtr) {
    base.internal_init(GodotEnginePINVOKE.ResourceLoader_SWIGUpcast(cPtr));
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }
  
  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ResourceLoader obj) {
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

  public static ResourceLoader Instance {
    get {
      if (instance == null) {
        instance = SingletonGetInstance();
      }
      return instance;
    }
  }

  internal ResourceLoader() {}


  public SWIGTYPE_p_RefT_ResourceInteractiveLoader_t load_interactive(string path, string type_hint) {
    SWIGTYPE_p_RefT_ResourceInteractiveLoader_t ret = new SWIGTYPE_p_RefT_ResourceInteractiveLoader_t(GodotEnginePINVOKE.ResourceLoader_load_interactive__SWIG_0(swigCPtr, path, type_hint), true);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_RefT_ResourceInteractiveLoader_t load_interactive(string path) {
    SWIGTYPE_p_RefT_ResourceInteractiveLoader_t ret = new SWIGTYPE_p_RefT_ResourceInteractiveLoader_t(GodotEnginePINVOKE.ResourceLoader_load_interactive__SWIG_1(swigCPtr, path), true);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_RefT_Resource_t load(string path, string type_hint, bool p_no_cache) {
    SWIGTYPE_p_RefT_Resource_t ret = new SWIGTYPE_p_RefT_Resource_t(GodotEnginePINVOKE.ResourceLoader_load__SWIG_0(swigCPtr, path, type_hint, p_no_cache), true);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_RefT_Resource_t load(string path, string type_hint) {
    SWIGTYPE_p_RefT_Resource_t ret = new SWIGTYPE_p_RefT_Resource_t(GodotEnginePINVOKE.ResourceLoader_load__SWIG_1(swigCPtr, path, type_hint), true);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_RefT_Resource_t load(string path) {
    SWIGTYPE_p_RefT_Resource_t ret = new SWIGTYPE_p_RefT_Resource_t(GodotEnginePINVOKE.ResourceLoader_load__SWIG_2(swigCPtr, path), true);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_RefT_ResourceImportMetadata_t load_import_metadata(string path) {
    SWIGTYPE_p_RefT_ResourceImportMetadata_t ret = new SWIGTYPE_p_RefT_ResourceImportMetadata_t(GodotEnginePINVOKE.ResourceLoader_load_import_metadata(swigCPtr, path), true);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_StringArray get_recognized_extensions_for_type(string type) {
    SWIGTYPE_p_StringArray ret = new SWIGTYPE_p_StringArray(GodotEnginePINVOKE.ResourceLoader_get_recognized_extensions_for_type(swigCPtr, type), true);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void set_abort_on_missing_resources(bool abort) {
    GodotEnginePINVOKE.ResourceLoader_set_abort_on_missing_resources(swigCPtr, abort);
  }

  public SWIGTYPE_p_StringArray get_dependencies(string path) {
    SWIGTYPE_p_StringArray ret = new SWIGTYPE_p_StringArray(GodotEnginePINVOKE.ResourceLoader_get_dependencies(swigCPtr, path), true);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool has(string path) {
    bool ret = GodotEnginePINVOKE.ResourceLoader_has(swigCPtr, path);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private static ResourceLoader SingletonGetInstance() {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.ResourceLoader_SingletonGetInstance();
    ResourceLoader ret = (cPtr == global::System.IntPtr.Zero) ? null : new ResourceLoader(cPtr, false);
    return ret;
  }

}

}
