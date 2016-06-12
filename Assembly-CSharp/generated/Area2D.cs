/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace GodotEngine {

public class Area2D : CollisionObject2D {

  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
  internal Area2D(global::System.IntPtr cPtr, bool cMemoryOwn) : base(GodotEnginePINVOKE.Area2D_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }  
  
  protected Area2D(bool cMemoryOwn) : base(cMemoryOwn) {}
  
  new internal void internal_init(global::System.IntPtr cPtr) {
    base.internal_init(GodotEnginePINVOKE.Area2D_SWIGUpcast(cPtr));
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }
  
  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Area2D obj) {
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



  public void set_space_override_mode(int enable) {
    GodotEnginePINVOKE.Area2D_set_space_override_mode(swigCPtr, enable);
  }

  public int get_space_override_mode() {
    int ret = GodotEnginePINVOKE.Area2D_get_space_override_mode(swigCPtr);
    return ret;
  }

  public void set_gravity_is_point(bool enable) {
    GodotEnginePINVOKE.Area2D_set_gravity_is_point(swigCPtr, enable);
  }

  public bool is_gravity_a_point() {
    bool ret = GodotEnginePINVOKE.Area2D_is_gravity_a_point(swigCPtr);
    return ret;
  }

  public void set_gravity_distance_scale(float distance_scale) {
    GodotEnginePINVOKE.Area2D_set_gravity_distance_scale(swigCPtr, distance_scale);
  }

  public float get_gravity_distance_scale() {
    float ret = GodotEnginePINVOKE.Area2D_get_gravity_distance_scale(swigCPtr);
    return ret;
  }

  public void set_gravity_vector(Vector2 vector) {
    GodotEnginePINVOKE.Area2D_set_gravity_vector(swigCPtr, ref vector);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public Vector2 get_gravity_vector() {
    Vector2 ret = GodotEnginePINVOKE.Area2D_get_gravity_vector(swigCPtr);
    return ret;
}

  public void set_gravity(float gravity) {
    GodotEnginePINVOKE.Area2D_set_gravity(swigCPtr, gravity);
  }

  public float get_gravity() {
    float ret = GodotEnginePINVOKE.Area2D_get_gravity(swigCPtr);
    return ret;
  }

  public void set_linear_damp(float linear_damp) {
    GodotEnginePINVOKE.Area2D_set_linear_damp(swigCPtr, linear_damp);
  }

  public float get_linear_damp() {
    float ret = GodotEnginePINVOKE.Area2D_get_linear_damp(swigCPtr);
    return ret;
  }

  public void set_angular_damp(float angular_damp) {
    GodotEnginePINVOKE.Area2D_set_angular_damp(swigCPtr, angular_damp);
  }

  public float get_angular_damp() {
    float ret = GodotEnginePINVOKE.Area2D_get_angular_damp(swigCPtr);
    return ret;
  }

  public void set_priority(float priority) {
    GodotEnginePINVOKE.Area2D_set_priority(swigCPtr, priority);
  }

  public float get_priority() {
    float ret = GodotEnginePINVOKE.Area2D_get_priority(swigCPtr);
    return ret;
  }

  public void set_collision_mask(int collision_mask) {
    GodotEnginePINVOKE.Area2D_set_collision_mask(swigCPtr, collision_mask);
  }

  public int get_collision_mask() {
    int ret = GodotEnginePINVOKE.Area2D_get_collision_mask(swigCPtr);
    return ret;
  }

  public void set_layer_mask(int layer_mask) {
    GodotEnginePINVOKE.Area2D_set_layer_mask(swigCPtr, layer_mask);
  }

  public int get_layer_mask() {
    int ret = GodotEnginePINVOKE.Area2D_get_layer_mask(swigCPtr);
    return ret;
  }

  public void set_collision_mask_bit(int bit, bool value) {
    GodotEnginePINVOKE.Area2D_set_collision_mask_bit(swigCPtr, bit, value);
  }

  public bool get_collision_mask_bit(int bit) {
    bool ret = GodotEnginePINVOKE.Area2D_get_collision_mask_bit(swigCPtr, bit);
    return ret;
  }

  public void set_layer_mask_bit(int bit, bool value) {
    GodotEnginePINVOKE.Area2D_set_layer_mask_bit(swigCPtr, bit, value);
  }

  public bool get_layer_mask_bit(int bit) {
    bool ret = GodotEnginePINVOKE.Area2D_get_layer_mask_bit(swigCPtr, bit);
    return ret;
  }

  public void set_enable_monitoring(bool enable) {
    GodotEnginePINVOKE.Area2D_set_enable_monitoring(swigCPtr, enable);
  }

  public bool is_monitoring_enabled() {
    bool ret = GodotEnginePINVOKE.Area2D_is_monitoring_enabled(swigCPtr);
    return ret;
  }

  public void set_monitorable(bool enable) {
    GodotEnginePINVOKE.Area2D_set_monitorable(swigCPtr, enable);
  }

  public bool is_monitorable() {
    bool ret = GodotEnginePINVOKE.Area2D_is_monitorable(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_Array get_overlapping_bodies() {
    SWIGTYPE_p_Array ret = new SWIGTYPE_p_Array(GodotEnginePINVOKE.Area2D_get_overlapping_bodies(swigCPtr), true);
    return ret;
  }

  public SWIGTYPE_p_Array get_overlapping_areas() {
    SWIGTYPE_p_Array ret = new SWIGTYPE_p_Array(GodotEnginePINVOKE.Area2D_get_overlapping_areas(swigCPtr), true);
    return ret;
  }

  public bool overlaps_body(Object body) {
    bool ret = GodotEnginePINVOKE.Area2D_overlaps_body(swigCPtr, Object.getCPtr(body));
    return ret;
  }

  public bool overlaps_area(Object area) {
    bool ret = GodotEnginePINVOKE.Area2D_overlaps_area(swigCPtr, Object.getCPtr(area));
    return ret;
  }

  public Area2D() : this(false) {
    if (swigCPtr.Handle == global::System.IntPtr.Zero) {
      internal_init(GodotEnginePINVOKE.new_Area2D());
      InternalHelpers.TieManagedToUnmanaged(this, swigCPtr.Handle);
    }
  }

}

}
