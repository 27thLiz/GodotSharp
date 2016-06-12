/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace GodotEngine {

public class RayCast : Spatial {

  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
  internal RayCast(global::System.IntPtr cPtr, bool cMemoryOwn) : base(GodotEnginePINVOKE.RayCast_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }  
  
  protected RayCast(bool cMemoryOwn) : base(cMemoryOwn) {}
  
  new internal void internal_init(global::System.IntPtr cPtr) {
    base.internal_init(GodotEnginePINVOKE.RayCast_SWIGUpcast(cPtr));
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }
  
  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(RayCast obj) {
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



  public void set_enabled(bool enabled) {
    GodotEnginePINVOKE.RayCast_set_enabled(swigCPtr, enabled);
  }

  public bool is_enabled() {
    bool ret = GodotEnginePINVOKE.RayCast_is_enabled(swigCPtr);
    return ret;
  }

  public void set_cast_to(SWIGTYPE_p_Vector3 local_point) {
    GodotEnginePINVOKE.RayCast_set_cast_to(swigCPtr, SWIGTYPE_p_Vector3.getCPtr(local_point));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_Vector3 get_cast_to() {
    SWIGTYPE_p_Vector3 ret = new SWIGTYPE_p_Vector3(GodotEnginePINVOKE.RayCast_get_cast_to(swigCPtr), true);
    return ret;
  }

  public bool is_colliding() {
    bool ret = GodotEnginePINVOKE.RayCast_is_colliding(swigCPtr);
    return ret;
  }

  public Object get_collider() {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.RayCast_get_collider(swigCPtr);
    if (cPtr == global::System.IntPtr.Zero)
    	return null;
    Object ret = InternalHelpers.UnmanagedGetManaged(cPtr) as Object;
    return ret;
  }

  public int get_collider_shape() {
    int ret = GodotEnginePINVOKE.RayCast_get_collider_shape(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_Vector3 get_collision_point() {
    SWIGTYPE_p_Vector3 ret = new SWIGTYPE_p_Vector3(GodotEnginePINVOKE.RayCast_get_collision_point(swigCPtr), true);
    return ret;
  }

  public SWIGTYPE_p_Vector3 get_collision_normal() {
    SWIGTYPE_p_Vector3 ret = new SWIGTYPE_p_Vector3(GodotEnginePINVOKE.RayCast_get_collision_normal(swigCPtr), true);
    return ret;
  }

  public void add_exception_rid(SWIGTYPE_p_RID rid) {
    GodotEnginePINVOKE.RayCast_add_exception_rid(swigCPtr, SWIGTYPE_p_RID.getCPtr(rid));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void add_exception(Object node) {
    GodotEnginePINVOKE.RayCast_add_exception(swigCPtr, Object.getCPtr(node));
  }

  public void remove_exception_rid(SWIGTYPE_p_RID rid) {
    GodotEnginePINVOKE.RayCast_remove_exception_rid(swigCPtr, SWIGTYPE_p_RID.getCPtr(rid));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void remove_exception(Object node) {
    GodotEnginePINVOKE.RayCast_remove_exception(swigCPtr, Object.getCPtr(node));
  }

  public void clear_exceptions() {
    GodotEnginePINVOKE.RayCast_clear_exceptions(swigCPtr);
  }

  public void set_layer_mask(int mask) {
    GodotEnginePINVOKE.RayCast_set_layer_mask(swigCPtr, mask);
  }

  public int get_layer_mask() {
    int ret = GodotEnginePINVOKE.RayCast_get_layer_mask(swigCPtr);
    return ret;
  }

  public void set_type_mask(int mask) {
    GodotEnginePINVOKE.RayCast_set_type_mask(swigCPtr, mask);
  }

  public int get_type_mask() {
    int ret = GodotEnginePINVOKE.RayCast_get_type_mask(swigCPtr);
    return ret;
  }

  public RayCast() : this(false) {
    if (swigCPtr.Handle == global::System.IntPtr.Zero) {
      internal_init(GodotEnginePINVOKE.new_RayCast());
      InternalHelpers.TieManagedToUnmanaged(this, swigCPtr.Handle);
    }
  }

}

}
