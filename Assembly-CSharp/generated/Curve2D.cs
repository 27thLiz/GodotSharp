/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace GodotEngine {

public class Curve2D : Resource {

  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
  internal Curve2D(global::System.IntPtr cPtr, bool cMemoryOwn) : base(GodotEnginePINVOKE.Curve2D_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }  
  
  protected Curve2D(bool cMemoryOwn) : base(cMemoryOwn) {}
  
  new internal void internal_init(global::System.IntPtr cPtr) {
    base.internal_init(GodotEnginePINVOKE.Curve2D_SWIGUpcast(cPtr));
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }
  
  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Curve2D obj) {
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



  public int get_point_count() {
    int ret = GodotEnginePINVOKE.Curve2D_get_point_count(swigCPtr);
    return ret;
  }

  public void add_point(Vector2 pos, Vector2 arg1, Vector2 arg2, int atpos) {
    GodotEnginePINVOKE.Curve2D_add_point__SWIG_0(swigCPtr, ref pos, ref arg1, ref arg2, atpos);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void add_point(Vector2 pos, Vector2 arg1, Vector2 arg2) {
    GodotEnginePINVOKE.Curve2D_add_point__SWIG_1(swigCPtr, ref pos, ref arg1, ref arg2);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void add_point(Vector2 pos, Vector2 arg1) {
    GodotEnginePINVOKE.Curve2D_add_point__SWIG_2(swigCPtr, ref pos, ref arg1);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void add_point(Vector2 pos) {
    GodotEnginePINVOKE.Curve2D_add_point__SWIG_3(swigCPtr, ref pos);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_point_pos(int idx, Vector2 pos) {
    GodotEnginePINVOKE.Curve2D_set_point_pos(swigCPtr, idx, ref pos);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public Vector2 get_point_pos(int idx) {
    Vector2 ret = GodotEnginePINVOKE.Curve2D_get_point_pos(swigCPtr, idx);
    return ret;
}

  public void set_point_in(int idx, Vector2 pos) {
    GodotEnginePINVOKE.Curve2D_set_point_in(swigCPtr, idx, ref pos);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public Vector2 get_point_in(int idx) {
    Vector2 ret = GodotEnginePINVOKE.Curve2D_get_point_in(swigCPtr, idx);
    return ret;
}

  public void set_point_out(int idx, Vector2 pos) {
    GodotEnginePINVOKE.Curve2D_set_point_out(swigCPtr, idx, ref pos);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public Vector2 get_point_out(int idx) {
    Vector2 ret = GodotEnginePINVOKE.Curve2D_get_point_out(swigCPtr, idx);
    return ret;
}

  public void remove_point(int idx) {
    GodotEnginePINVOKE.Curve2D_remove_point(swigCPtr, idx);
  }

  public Vector2 interpolate(int idx, float t) {
    Vector2 ret = GodotEnginePINVOKE.Curve2D_interpolate(swigCPtr, idx, t);
    return ret;
}

  public Vector2 interpolatef(float fofs) {
    Vector2 ret = GodotEnginePINVOKE.Curve2D_interpolatef(swigCPtr, fofs);
    return ret;
}

  public void set_bake_interval(float distance) {
    GodotEnginePINVOKE.Curve2D_set_bake_interval(swigCPtr, distance);
  }

  public float get_bake_interval() {
    float ret = GodotEnginePINVOKE.Curve2D_get_bake_interval(swigCPtr);
    return ret;
  }

  public float get_baked_length() {
    float ret = GodotEnginePINVOKE.Curve2D_get_baked_length(swigCPtr);
    return ret;
  }

  public Vector2 interpolate_baked(float offset, bool cubic) {
    Vector2 ret = GodotEnginePINVOKE.Curve2D_interpolate_baked__SWIG_0(swigCPtr, offset, cubic);
    return ret;
}

  public Vector2 interpolate_baked(float offset) {
    Vector2 ret = GodotEnginePINVOKE.Curve2D_interpolate_baked__SWIG_1(swigCPtr, offset);
    return ret;
}

  public SWIGTYPE_p_Vector2Array get_baked_points() {
    SWIGTYPE_p_Vector2Array ret = new SWIGTYPE_p_Vector2Array(GodotEnginePINVOKE.Curve2D_get_baked_points(swigCPtr), true);
    return ret;
  }

  public SWIGTYPE_p_Vector2Array tesselate(int max_stages, float tolerance_degrees) {
    SWIGTYPE_p_Vector2Array ret = new SWIGTYPE_p_Vector2Array(GodotEnginePINVOKE.Curve2D_tesselate__SWIG_0(swigCPtr, max_stages, tolerance_degrees), true);
    return ret;
  }

  public SWIGTYPE_p_Vector2Array tesselate(int max_stages) {
    SWIGTYPE_p_Vector2Array ret = new SWIGTYPE_p_Vector2Array(GodotEnginePINVOKE.Curve2D_tesselate__SWIG_1(swigCPtr, max_stages), true);
    return ret;
  }

  public SWIGTYPE_p_Vector2Array tesselate() {
    SWIGTYPE_p_Vector2Array ret = new SWIGTYPE_p_Vector2Array(GodotEnginePINVOKE.Curve2D_tesselate__SWIG_2(swigCPtr), true);
    return ret;
  }

  public Curve2D() : this(true) {
    if (swigCPtr.Handle == global::System.IntPtr.Zero) {
      internal_init(GodotEnginePINVOKE.new_Curve2D());
      InternalHelpers.TieManagedToUnmanaged(this, swigCPtr.Handle);
    }
  }

}

}
