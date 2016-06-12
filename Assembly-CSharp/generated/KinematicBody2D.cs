/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace GodotEngine {

public class KinematicBody2D : PhysicsBody2D {

  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
  internal KinematicBody2D(global::System.IntPtr cPtr, bool cMemoryOwn) : base(GodotEnginePINVOKE.KinematicBody2D_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }  
  
  protected KinematicBody2D(bool cMemoryOwn) : base(cMemoryOwn) {}
  
  new internal void internal_init(global::System.IntPtr cPtr) {
    base.internal_init(GodotEnginePINVOKE.KinematicBody2D_SWIGUpcast(cPtr));
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }
  
  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(KinematicBody2D obj) {
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



  public Vector2 move(Vector2 rel_vec) {
    Vector2 ret = GodotEnginePINVOKE.KinematicBody2D_move(swigCPtr, ref rel_vec);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
}

  public Vector2 move_to(Vector2 position) {
    Vector2 ret = GodotEnginePINVOKE.KinematicBody2D_move_to(swigCPtr, ref position);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
}

  public bool test_move(Vector2 rel_vec) {
    bool ret = GodotEnginePINVOKE.KinematicBody2D_test_move(swigCPtr, ref rel_vec);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Vector2 get_travel() {
    Vector2 ret = GodotEnginePINVOKE.KinematicBody2D_get_travel(swigCPtr);
    return ret;
}

  public void revert_motion() {
    GodotEnginePINVOKE.KinematicBody2D_revert_motion(swigCPtr);
  }

  public bool is_colliding() {
    bool ret = GodotEnginePINVOKE.KinematicBody2D_is_colliding(swigCPtr);
    return ret;
  }

  public Vector2 get_collision_pos() {
    Vector2 ret = GodotEnginePINVOKE.KinematicBody2D_get_collision_pos(swigCPtr);
    return ret;
}

  public Vector2 get_collision_normal() {
    Vector2 ret = GodotEnginePINVOKE.KinematicBody2D_get_collision_normal(swigCPtr);
    return ret;
}

  public Vector2 get_collider_velocity() {
    Vector2 ret = GodotEnginePINVOKE.KinematicBody2D_get_collider_velocity(swigCPtr);
    return ret;
}

  public Object get_collider() {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.KinematicBody2D_get_collider(swigCPtr);
    if (cPtr == global::System.IntPtr.Zero)
    	return null;
    Object ret = InternalHelpers.UnmanagedGetManaged(cPtr) as Object;
    return ret;
  }

  public int get_collider_shape() {
    int ret = GodotEnginePINVOKE.KinematicBody2D_get_collider_shape(swigCPtr);
    return ret;
  }

  public Variant get_collider_metadata() {
    Variant ret = new Variant(GodotEnginePINVOKE.KinematicBody2D_get_collider_metadata(swigCPtr), true);
    return ret;
  }

  public void set_collision_margin(float pixels) {
    GodotEnginePINVOKE.KinematicBody2D_set_collision_margin(swigCPtr, pixels);
  }

  public float get_collision_margin() {
    float ret = GodotEnginePINVOKE.KinematicBody2D_get_collision_margin(swigCPtr);
    return ret;
  }

  public KinematicBody2D() : this(false) {
    if (swigCPtr.Handle == global::System.IntPtr.Zero) {
      internal_init(GodotEnginePINVOKE.new_KinematicBody2D());
      InternalHelpers.TieManagedToUnmanaged(this, swigCPtr.Handle);
    }
  }

}

}
