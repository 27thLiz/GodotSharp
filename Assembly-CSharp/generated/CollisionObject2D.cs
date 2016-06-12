/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace GodotEngine {

public class CollisionObject2D : Node2D {

  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
  internal CollisionObject2D(global::System.IntPtr cPtr, bool cMemoryOwn) : base(GodotEnginePINVOKE.CollisionObject2D_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }  
  
  protected CollisionObject2D(bool cMemoryOwn) : base(cMemoryOwn) {}
  
  new internal void internal_init(global::System.IntPtr cPtr) {
    base.internal_init(GodotEnginePINVOKE.CollisionObject2D_SWIGUpcast(cPtr));
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }
  
  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CollisionObject2D obj) {
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

  internal CollisionObject2D() {}


  public void _input_event(Object viewport, SWIGTYPE_p_InputEvent arg1, int shape_idx) {
    GodotEnginePINVOKE.CollisionObject2D__input_event(swigCPtr, Object.getCPtr(viewport), SWIGTYPE_p_InputEvent.getCPtr(arg1), shape_idx);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void add_shape(SWIGTYPE_p_RefT_Shape2D_t shape, Matrix32 transform) {
    GodotEnginePINVOKE.CollisionObject2D_add_shape__SWIG_0(swigCPtr, SWIGTYPE_p_RefT_Shape2D_t.getCPtr(shape), ref transform.elements);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void add_shape(SWIGTYPE_p_RefT_Shape2D_t shape) {
    GodotEnginePINVOKE.CollisionObject2D_add_shape__SWIG_1(swigCPtr, SWIGTYPE_p_RefT_Shape2D_t.getCPtr(shape));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public int get_shape_count() {
    int ret = GodotEnginePINVOKE.CollisionObject2D_get_shape_count(swigCPtr);
    return ret;
  }

  public void set_shape(int shape_idx, SWIGTYPE_p_RefT_Shape_t shape) {
    GodotEnginePINVOKE.CollisionObject2D_set_shape(swigCPtr, shape_idx, SWIGTYPE_p_RefT_Shape_t.getCPtr(shape));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_shape_transform(int shape_idx, Matrix32 transform) {
    GodotEnginePINVOKE.CollisionObject2D_set_shape_transform(swigCPtr, shape_idx, ref transform.elements);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_shape_as_trigger(int shape_idx, bool enable) {
    GodotEnginePINVOKE.CollisionObject2D_set_shape_as_trigger(swigCPtr, shape_idx, enable);
  }

  public SWIGTYPE_p_RefT_Shape2D_t get_shape(int shape_idx) {
    SWIGTYPE_p_RefT_Shape2D_t ret = new SWIGTYPE_p_RefT_Shape2D_t(GodotEnginePINVOKE.CollisionObject2D_get_shape(swigCPtr, shape_idx), true);
    return ret;
  }

  public Matrix32 get_shape_transform(int shape_idx) {
    Matrix32 ret = new Matrix32(GodotEnginePINVOKE.CollisionObject2D_get_shape_transform(swigCPtr, shape_idx));
    return ret;
}

  public bool is_shape_set_as_trigger(int shape_idx) {
    bool ret = GodotEnginePINVOKE.CollisionObject2D_is_shape_set_as_trigger(swigCPtr, shape_idx);
    return ret;
  }

  public void remove_shape(int shape_idx) {
    GodotEnginePINVOKE.CollisionObject2D_remove_shape(swigCPtr, shape_idx);
  }

  public void clear_shapes() {
    GodotEnginePINVOKE.CollisionObject2D_clear_shapes(swigCPtr);
  }

  public SWIGTYPE_p_RID get_rid() {
    SWIGTYPE_p_RID ret = new SWIGTYPE_p_RID(GodotEnginePINVOKE.CollisionObject2D_get_rid(swigCPtr), true);
    return ret;
  }

  public void set_pickable(bool enabled) {
    GodotEnginePINVOKE.CollisionObject2D_set_pickable(swigCPtr, enabled);
  }

  public bool is_pickable() {
    bool ret = GodotEnginePINVOKE.CollisionObject2D_is_pickable(swigCPtr);
    return ret;
  }

}

}
