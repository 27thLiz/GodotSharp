/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace GodotEngine {

public class Physics2DServer : Object {
  private static Physics2DServer instance;
  public static readonly int SHAPE_LINE = 0;
  public static readonly int SHAPE_SEGMENT = 2;
  public static readonly int SHAPE_CIRCLE = 3;
  public static readonly int SHAPE_RECTANGLE = 4;
  public static readonly int SHAPE_CAPSULE = 5;
  public static readonly int SHAPE_CONVEX_POLYGON = 6;
  public static readonly int SHAPE_CONCAVE_POLYGON = 7;
  public static readonly int SHAPE_CUSTOM = 8;
  public static readonly int AREA_PARAM_GRAVITY = 0;
  public static readonly int AREA_PARAM_GRAVITY_VECTOR = 1;
  public static readonly int AREA_PARAM_GRAVITY_IS_POINT = 2;
  public static readonly int AREA_PARAM_GRAVITY_DISTANCE_SCALE = 3;
  public static readonly int AREA_PARAM_GRAVITY_POINT_ATTENUATION = 4;
  public static readonly int AREA_PARAM_LINEAR_DAMP = 5;
  public static readonly int AREA_PARAM_ANGULAR_DAMP = 6;
  public static readonly int AREA_PARAM_PRIORITY = 7;
  public static readonly int AREA_SPACE_OVERRIDE_DISABLED = 0;
  public static readonly int AREA_SPACE_OVERRIDE_COMBINE = 1;
  public static readonly int AREA_SPACE_OVERRIDE_COMBINE_REPLACE = 2;
  public static readonly int AREA_SPACE_OVERRIDE_REPLACE = 3;
  public static readonly int AREA_SPACE_OVERRIDE_REPLACE_COMBINE = 4;
  public static readonly int BODY_MODE_STATIC = 0;
  public static readonly int BODY_MODE_KINEMATIC = 1;
  public static readonly int BODY_MODE_RIGID = 2;
  public static readonly int BODY_MODE_CHARACTER = 3;
  public static readonly int BODY_PARAM_BOUNCE = 0;
  public static readonly int BODY_PARAM_FRICTION = 1;
  public static readonly int BODY_PARAM_MASS = 2;
  public static readonly int BODY_PARAM_INERTIA = 3;
  public static readonly int BODY_PARAM_GRAVITY_SCALE = 4;
  public static readonly int BODY_PARAM_LINEAR_DAMP = 5;
  public static readonly int BODY_PARAM_ANGULAR_DAMP = 6;
  public static readonly int BODY_PARAM_MAX = 7;
  public static readonly int BODY_STATE_TRANSFORM = 0;
  public static readonly int BODY_STATE_LINEAR_VELOCITY = 1;
  public static readonly int BODY_STATE_ANGULAR_VELOCITY = 2;
  public static readonly int BODY_STATE_SLEEPING = 3;
  public static readonly int BODY_STATE_CAN_SLEEP = 4;
  public static readonly int JOINT_PIN = 0;
  public static readonly int JOINT_GROOVE = 1;
  public static readonly int JOINT_DAMPED_SPRING = 2;
  public static readonly int DAMPED_STRING_REST_LENGTH = 0;
  public static readonly int DAMPED_STRING_STIFFNESS = 1;
  public static readonly int DAMPED_STRING_DAMPING = 2;
  public static readonly int CCD_MODE_DISABLED = 0;
  public static readonly int CCD_MODE_CAST_RAY = 1;
  public static readonly int CCD_MODE_CAST_SHAPE = 2;
  public static readonly int AREA_BODY_ADDED = 0;
  public static readonly int AREA_BODY_REMOVED = 1;
  public static readonly int INFO_ACTIVE_OBJECTS = 0;
  public static readonly int INFO_COLLISION_PAIRS = 1;
  public static readonly int INFO_ISLAND_COUNT = 2;

  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
  internal Physics2DServer(global::System.IntPtr cPtr, bool cMemoryOwn) : base(GodotEnginePINVOKE.Physics2DServer_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }  
  
  protected Physics2DServer(bool cMemoryOwn) : base(cMemoryOwn) {}
  
  new internal void internal_init(global::System.IntPtr cPtr) {
    base.internal_init(GodotEnginePINVOKE.Physics2DServer_SWIGUpcast(cPtr));
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }
  
  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Physics2DServer obj) {
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

  public static Physics2DServer Instance {
    get {
      if (instance == null) {
        instance = SingletonGetInstance();
      }
      return instance;
    }
  }

  internal Physics2DServer() {}


  public SWIGTYPE_p_RID shape_create(int type) {
    SWIGTYPE_p_RID ret = new SWIGTYPE_p_RID(GodotEnginePINVOKE.Physics2DServer_shape_create(swigCPtr, type), true);
    return ret;
  }

  public void shape_set_data(SWIGTYPE_p_RID shape, Variant data) {
    GodotEnginePINVOKE.Physics2DServer_shape_set_data(swigCPtr, SWIGTYPE_p_RID.getCPtr(shape), Variant.getCPtr(data));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public int shape_get_type(SWIGTYPE_p_RID shape) {
    int ret = GodotEnginePINVOKE.Physics2DServer_shape_get_type(swigCPtr, SWIGTYPE_p_RID.getCPtr(shape));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void shape_get_data(SWIGTYPE_p_RID shape) {
    GodotEnginePINVOKE.Physics2DServer_shape_get_data(swigCPtr, SWIGTYPE_p_RID.getCPtr(shape));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_RID space_create() {
    SWIGTYPE_p_RID ret = new SWIGTYPE_p_RID(GodotEnginePINVOKE.Physics2DServer_space_create(swigCPtr), true);
    return ret;
  }

  public void space_set_active(SWIGTYPE_p_RID space, bool active) {
    GodotEnginePINVOKE.Physics2DServer_space_set_active(swigCPtr, SWIGTYPE_p_RID.getCPtr(space), active);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool space_is_active(SWIGTYPE_p_RID space) {
    bool ret = GodotEnginePINVOKE.Physics2DServer_space_is_active(swigCPtr, SWIGTYPE_p_RID.getCPtr(space));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void space_set_param(SWIGTYPE_p_RID space, int param, float value) {
    GodotEnginePINVOKE.Physics2DServer_space_set_param(swigCPtr, SWIGTYPE_p_RID.getCPtr(space), param, value);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public float space_get_param(SWIGTYPE_p_RID space, int param) {
    float ret = GodotEnginePINVOKE.Physics2DServer_space_get_param(swigCPtr, SWIGTYPE_p_RID.getCPtr(space), param);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Physics2DDirectSpaceState space_get_direct_state(SWIGTYPE_p_RID space) {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.Physics2DServer_space_get_direct_state(swigCPtr, SWIGTYPE_p_RID.getCPtr(space));
    Physics2DDirectSpaceState ret = (cPtr == global::System.IntPtr.Zero) ? null : new Physics2DDirectSpaceState(cPtr, false);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_RID area_create() {
    SWIGTYPE_p_RID ret = new SWIGTYPE_p_RID(GodotEnginePINVOKE.Physics2DServer_area_create(swigCPtr), true);
    return ret;
  }

  public void area_set_space(SWIGTYPE_p_RID area, SWIGTYPE_p_RID space) {
    GodotEnginePINVOKE.Physics2DServer_area_set_space(swigCPtr, SWIGTYPE_p_RID.getCPtr(area), SWIGTYPE_p_RID.getCPtr(space));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_RID area_get_space(SWIGTYPE_p_RID area) {
    SWIGTYPE_p_RID ret = new SWIGTYPE_p_RID(GodotEnginePINVOKE.Physics2DServer_area_get_space(swigCPtr, SWIGTYPE_p_RID.getCPtr(area)), true);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void area_set_space_override_mode(SWIGTYPE_p_RID area, int mode) {
    GodotEnginePINVOKE.Physics2DServer_area_set_space_override_mode(swigCPtr, SWIGTYPE_p_RID.getCPtr(area), mode);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public int area_get_space_override_mode(SWIGTYPE_p_RID area) {
    int ret = GodotEnginePINVOKE.Physics2DServer_area_get_space_override_mode(swigCPtr, SWIGTYPE_p_RID.getCPtr(area));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void area_add_shape(SWIGTYPE_p_RID area, SWIGTYPE_p_RID shape, Matrix32 transform) {
    GodotEnginePINVOKE.Physics2DServer_area_add_shape__SWIG_0(swigCPtr, SWIGTYPE_p_RID.getCPtr(area), SWIGTYPE_p_RID.getCPtr(shape), ref transform.elements);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void area_add_shape(SWIGTYPE_p_RID area, SWIGTYPE_p_RID shape) {
    GodotEnginePINVOKE.Physics2DServer_area_add_shape__SWIG_1(swigCPtr, SWIGTYPE_p_RID.getCPtr(area), SWIGTYPE_p_RID.getCPtr(shape));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void area_set_shape(SWIGTYPE_p_RID area, int shape_idx, SWIGTYPE_p_RID shape) {
    GodotEnginePINVOKE.Physics2DServer_area_set_shape(swigCPtr, SWIGTYPE_p_RID.getCPtr(area), shape_idx, SWIGTYPE_p_RID.getCPtr(shape));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void area_set_shape_transform(SWIGTYPE_p_RID area, int shape_idx, Matrix32 transform) {
    GodotEnginePINVOKE.Physics2DServer_area_set_shape_transform(swigCPtr, SWIGTYPE_p_RID.getCPtr(area), shape_idx, ref transform.elements);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public int area_get_shape_count(SWIGTYPE_p_RID area) {
    int ret = GodotEnginePINVOKE.Physics2DServer_area_get_shape_count(swigCPtr, SWIGTYPE_p_RID.getCPtr(area));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_RID area_get_shape(SWIGTYPE_p_RID area, int shape_idx) {
    SWIGTYPE_p_RID ret = new SWIGTYPE_p_RID(GodotEnginePINVOKE.Physics2DServer_area_get_shape(swigCPtr, SWIGTYPE_p_RID.getCPtr(area), shape_idx), true);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Matrix32 area_get_shape_transform(SWIGTYPE_p_RID area, int shape_idx) {
    Matrix32 ret = new Matrix32(GodotEnginePINVOKE.Physics2DServer_area_get_shape_transform(swigCPtr, SWIGTYPE_p_RID.getCPtr(area), shape_idx));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
}

  public void area_remove_shape(SWIGTYPE_p_RID area, int shape_idx) {
    GodotEnginePINVOKE.Physics2DServer_area_remove_shape(swigCPtr, SWIGTYPE_p_RID.getCPtr(area), shape_idx);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void area_clear_shapes(SWIGTYPE_p_RID area) {
    GodotEnginePINVOKE.Physics2DServer_area_clear_shapes(swigCPtr, SWIGTYPE_p_RID.getCPtr(area));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void area_set_layer_mask(SWIGTYPE_p_RID area, int mask) {
    GodotEnginePINVOKE.Physics2DServer_area_set_layer_mask(swigCPtr, SWIGTYPE_p_RID.getCPtr(area), mask);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void area_set_collision_mask(SWIGTYPE_p_RID area, int mask) {
    GodotEnginePINVOKE.Physics2DServer_area_set_collision_mask(swigCPtr, SWIGTYPE_p_RID.getCPtr(area), mask);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void area_set_param(SWIGTYPE_p_RID area, int param, Variant value) {
    GodotEnginePINVOKE.Physics2DServer_area_set_param(swigCPtr, SWIGTYPE_p_RID.getCPtr(area), param, Variant.getCPtr(value));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void area_set_transform(SWIGTYPE_p_RID area, Matrix32 transform) {
    GodotEnginePINVOKE.Physics2DServer_area_set_transform(swigCPtr, SWIGTYPE_p_RID.getCPtr(area), ref transform.elements);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void area_get_param(SWIGTYPE_p_RID area, int param) {
    GodotEnginePINVOKE.Physics2DServer_area_get_param(swigCPtr, SWIGTYPE_p_RID.getCPtr(area), param);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public Matrix32 area_get_transform(SWIGTYPE_p_RID area) {
    Matrix32 ret = new Matrix32(GodotEnginePINVOKE.Physics2DServer_area_get_transform(swigCPtr, SWIGTYPE_p_RID.getCPtr(area)));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
}

  public void area_attach_object_instance_ID(SWIGTYPE_p_RID area, int id) {
    GodotEnginePINVOKE.Physics2DServer_area_attach_object_instance_ID(swigCPtr, SWIGTYPE_p_RID.getCPtr(area), id);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public int area_get_object_instance_ID(SWIGTYPE_p_RID area) {
    int ret = GodotEnginePINVOKE.Physics2DServer_area_get_object_instance_ID(swigCPtr, SWIGTYPE_p_RID.getCPtr(area));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void area_set_monitor_callback(SWIGTYPE_p_RID area, Object receiver, string method) {
    GodotEnginePINVOKE.Physics2DServer_area_set_monitor_callback(swigCPtr, SWIGTYPE_p_RID.getCPtr(area), Object.getCPtr(receiver), method);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_RID body_create(int mode, bool init_sleeping) {
    SWIGTYPE_p_RID ret = new SWIGTYPE_p_RID(GodotEnginePINVOKE.Physics2DServer_body_create__SWIG_0(swigCPtr, mode, init_sleeping), true);
    return ret;
  }

  public SWIGTYPE_p_RID body_create(int mode) {
    SWIGTYPE_p_RID ret = new SWIGTYPE_p_RID(GodotEnginePINVOKE.Physics2DServer_body_create__SWIG_1(swigCPtr, mode), true);
    return ret;
  }

  public SWIGTYPE_p_RID body_create() {
    SWIGTYPE_p_RID ret = new SWIGTYPE_p_RID(GodotEnginePINVOKE.Physics2DServer_body_create__SWIG_2(swigCPtr), true);
    return ret;
  }

  public void body_set_space(SWIGTYPE_p_RID body, SWIGTYPE_p_RID space) {
    GodotEnginePINVOKE.Physics2DServer_body_set_space(swigCPtr, SWIGTYPE_p_RID.getCPtr(body), SWIGTYPE_p_RID.getCPtr(space));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_RID body_get_space(SWIGTYPE_p_RID body) {
    SWIGTYPE_p_RID ret = new SWIGTYPE_p_RID(GodotEnginePINVOKE.Physics2DServer_body_get_space(swigCPtr, SWIGTYPE_p_RID.getCPtr(body)), true);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void body_set_mode(SWIGTYPE_p_RID body, int mode) {
    GodotEnginePINVOKE.Physics2DServer_body_set_mode(swigCPtr, SWIGTYPE_p_RID.getCPtr(body), mode);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public int body_get_mode(SWIGTYPE_p_RID body) {
    int ret = GodotEnginePINVOKE.Physics2DServer_body_get_mode(swigCPtr, SWIGTYPE_p_RID.getCPtr(body));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void body_add_shape(SWIGTYPE_p_RID body, SWIGTYPE_p_RID shape, Matrix32 transform) {
    GodotEnginePINVOKE.Physics2DServer_body_add_shape__SWIG_0(swigCPtr, SWIGTYPE_p_RID.getCPtr(body), SWIGTYPE_p_RID.getCPtr(shape), ref transform.elements);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void body_add_shape(SWIGTYPE_p_RID body, SWIGTYPE_p_RID shape) {
    GodotEnginePINVOKE.Physics2DServer_body_add_shape__SWIG_1(swigCPtr, SWIGTYPE_p_RID.getCPtr(body), SWIGTYPE_p_RID.getCPtr(shape));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void body_set_shape(SWIGTYPE_p_RID body, int shape_idx, SWIGTYPE_p_RID shape) {
    GodotEnginePINVOKE.Physics2DServer_body_set_shape(swigCPtr, SWIGTYPE_p_RID.getCPtr(body), shape_idx, SWIGTYPE_p_RID.getCPtr(shape));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void body_set_shape_transform(SWIGTYPE_p_RID body, int shape_idx, Matrix32 transform) {
    GodotEnginePINVOKE.Physics2DServer_body_set_shape_transform(swigCPtr, SWIGTYPE_p_RID.getCPtr(body), shape_idx, ref transform.elements);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void body_set_shape_metadata(SWIGTYPE_p_RID body, int shape_idx, Variant metadata) {
    GodotEnginePINVOKE.Physics2DServer_body_set_shape_metadata(swigCPtr, SWIGTYPE_p_RID.getCPtr(body), shape_idx, Variant.getCPtr(metadata));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public int body_get_shape_count(SWIGTYPE_p_RID body) {
    int ret = GodotEnginePINVOKE.Physics2DServer_body_get_shape_count(swigCPtr, SWIGTYPE_p_RID.getCPtr(body));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_RID body_get_shape(SWIGTYPE_p_RID body, int shape_idx) {
    SWIGTYPE_p_RID ret = new SWIGTYPE_p_RID(GodotEnginePINVOKE.Physics2DServer_body_get_shape(swigCPtr, SWIGTYPE_p_RID.getCPtr(body), shape_idx), true);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Matrix32 body_get_shape_transform(SWIGTYPE_p_RID body, int shape_idx) {
    Matrix32 ret = new Matrix32(GodotEnginePINVOKE.Physics2DServer_body_get_shape_transform(swigCPtr, SWIGTYPE_p_RID.getCPtr(body), shape_idx));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
}

  public void body_get_shape_metadata(SWIGTYPE_p_RID body, int shape_idx) {
    GodotEnginePINVOKE.Physics2DServer_body_get_shape_metadata(swigCPtr, SWIGTYPE_p_RID.getCPtr(body), shape_idx);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void body_remove_shape(SWIGTYPE_p_RID body, int shape_idx) {
    GodotEnginePINVOKE.Physics2DServer_body_remove_shape(swigCPtr, SWIGTYPE_p_RID.getCPtr(body), shape_idx);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void body_clear_shapes(SWIGTYPE_p_RID body) {
    GodotEnginePINVOKE.Physics2DServer_body_clear_shapes(swigCPtr, SWIGTYPE_p_RID.getCPtr(body));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void body_set_shape_as_trigger(SWIGTYPE_p_RID body, int shape_idx, bool enable) {
    GodotEnginePINVOKE.Physics2DServer_body_set_shape_as_trigger(swigCPtr, SWIGTYPE_p_RID.getCPtr(body), shape_idx, enable);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool body_is_shape_set_as_trigger(SWIGTYPE_p_RID body, int shape_idx) {
    bool ret = GodotEnginePINVOKE.Physics2DServer_body_is_shape_set_as_trigger(swigCPtr, SWIGTYPE_p_RID.getCPtr(body), shape_idx);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void body_attach_object_instance_ID(SWIGTYPE_p_RID body, int id) {
    GodotEnginePINVOKE.Physics2DServer_body_attach_object_instance_ID(swigCPtr, SWIGTYPE_p_RID.getCPtr(body), id);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public int body_get_object_instance_ID(SWIGTYPE_p_RID body) {
    int ret = GodotEnginePINVOKE.Physics2DServer_body_get_object_instance_ID(swigCPtr, SWIGTYPE_p_RID.getCPtr(body));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void body_set_continuous_collision_detection_mode(SWIGTYPE_p_RID body, int mode) {
    GodotEnginePINVOKE.Physics2DServer_body_set_continuous_collision_detection_mode(swigCPtr, SWIGTYPE_p_RID.getCPtr(body), mode);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public int body_get_continuous_collision_detection_mode(SWIGTYPE_p_RID body) {
    int ret = GodotEnginePINVOKE.Physics2DServer_body_get_continuous_collision_detection_mode(swigCPtr, SWIGTYPE_p_RID.getCPtr(body));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void body_set_layer_mask(SWIGTYPE_p_RID body, int mask) {
    GodotEnginePINVOKE.Physics2DServer_body_set_layer_mask(swigCPtr, SWIGTYPE_p_RID.getCPtr(body), mask);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public int body_get_layer_mask(SWIGTYPE_p_RID body) {
    int ret = GodotEnginePINVOKE.Physics2DServer_body_get_layer_mask(swigCPtr, SWIGTYPE_p_RID.getCPtr(body));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void body_set_collision_mask(SWIGTYPE_p_RID body, int mask) {
    GodotEnginePINVOKE.Physics2DServer_body_set_collision_mask(swigCPtr, SWIGTYPE_p_RID.getCPtr(body), mask);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public int body_get_collision_mask(SWIGTYPE_p_RID body) {
    int ret = GodotEnginePINVOKE.Physics2DServer_body_get_collision_mask(swigCPtr, SWIGTYPE_p_RID.getCPtr(body));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void body_set_param(SWIGTYPE_p_RID body, int param, float value) {
    GodotEnginePINVOKE.Physics2DServer_body_set_param(swigCPtr, SWIGTYPE_p_RID.getCPtr(body), param, value);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public float body_get_param(SWIGTYPE_p_RID body, int param) {
    float ret = GodotEnginePINVOKE.Physics2DServer_body_get_param(swigCPtr, SWIGTYPE_p_RID.getCPtr(body), param);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void body_set_state(SWIGTYPE_p_RID body, int state, Variant value) {
    GodotEnginePINVOKE.Physics2DServer_body_set_state(swigCPtr, SWIGTYPE_p_RID.getCPtr(body), state, Variant.getCPtr(value));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void body_get_state(SWIGTYPE_p_RID body, int state) {
    GodotEnginePINVOKE.Physics2DServer_body_get_state(swigCPtr, SWIGTYPE_p_RID.getCPtr(body), state);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void body_apply_impulse(SWIGTYPE_p_RID body, Vector2 pos, Vector2 impulse) {
    GodotEnginePINVOKE.Physics2DServer_body_apply_impulse(swigCPtr, SWIGTYPE_p_RID.getCPtr(body), ref pos, ref impulse);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void body_add_force(SWIGTYPE_p_RID body, Vector2 offset, Vector2 force) {
    GodotEnginePINVOKE.Physics2DServer_body_add_force(swigCPtr, SWIGTYPE_p_RID.getCPtr(body), ref offset, ref force);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void body_set_axis_velocity(SWIGTYPE_p_RID body, Vector2 axis_velocity) {
    GodotEnginePINVOKE.Physics2DServer_body_set_axis_velocity(swigCPtr, SWIGTYPE_p_RID.getCPtr(body), ref axis_velocity);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void body_add_collision_exception(SWIGTYPE_p_RID body, SWIGTYPE_p_RID excepted_body) {
    GodotEnginePINVOKE.Physics2DServer_body_add_collision_exception(swigCPtr, SWIGTYPE_p_RID.getCPtr(body), SWIGTYPE_p_RID.getCPtr(excepted_body));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void body_remove_collision_exception(SWIGTYPE_p_RID body, SWIGTYPE_p_RID excepted_body) {
    GodotEnginePINVOKE.Physics2DServer_body_remove_collision_exception(swigCPtr, SWIGTYPE_p_RID.getCPtr(body), SWIGTYPE_p_RID.getCPtr(excepted_body));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void body_set_max_contacts_reported(SWIGTYPE_p_RID body, int amount) {
    GodotEnginePINVOKE.Physics2DServer_body_set_max_contacts_reported(swigCPtr, SWIGTYPE_p_RID.getCPtr(body), amount);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public int body_get_max_contacts_reported(SWIGTYPE_p_RID body) {
    int ret = GodotEnginePINVOKE.Physics2DServer_body_get_max_contacts_reported(swigCPtr, SWIGTYPE_p_RID.getCPtr(body));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void body_set_one_way_collision_direction(SWIGTYPE_p_RID body, Vector2 normal) {
    GodotEnginePINVOKE.Physics2DServer_body_set_one_way_collision_direction(swigCPtr, SWIGTYPE_p_RID.getCPtr(body), ref normal);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public Vector2 body_get_one_way_collision_direction(SWIGTYPE_p_RID body) {
    Vector2 ret = GodotEnginePINVOKE.Physics2DServer_body_get_one_way_collision_direction(swigCPtr, SWIGTYPE_p_RID.getCPtr(body));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
}

  public void body_set_one_way_collision_max_depth(SWIGTYPE_p_RID body, float depth) {
    GodotEnginePINVOKE.Physics2DServer_body_set_one_way_collision_max_depth(swigCPtr, SWIGTYPE_p_RID.getCPtr(body), depth);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public float body_get_one_way_collision_max_depth(SWIGTYPE_p_RID body) {
    float ret = GodotEnginePINVOKE.Physics2DServer_body_get_one_way_collision_max_depth(swigCPtr, SWIGTYPE_p_RID.getCPtr(body));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void body_set_omit_force_integration(SWIGTYPE_p_RID body, bool enable) {
    GodotEnginePINVOKE.Physics2DServer_body_set_omit_force_integration(swigCPtr, SWIGTYPE_p_RID.getCPtr(body), enable);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool body_is_omitting_force_integration(SWIGTYPE_p_RID body) {
    bool ret = GodotEnginePINVOKE.Physics2DServer_body_is_omitting_force_integration(swigCPtr, SWIGTYPE_p_RID.getCPtr(body));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void body_set_force_integration_callback(SWIGTYPE_p_RID body, Object receiver, string method, Variant userdata) {
    GodotEnginePINVOKE.Physics2DServer_body_set_force_integration_callback__SWIG_0(swigCPtr, SWIGTYPE_p_RID.getCPtr(body), Object.getCPtr(receiver), method, Variant.getCPtr(userdata));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void body_set_force_integration_callback(SWIGTYPE_p_RID body, Object receiver, string method) {
    GodotEnginePINVOKE.Physics2DServer_body_set_force_integration_callback__SWIG_1(swigCPtr, SWIGTYPE_p_RID.getCPtr(body), Object.getCPtr(receiver), method);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool body_test_motion(SWIGTYPE_p_RID body, Vector2 motion, float margin, SWIGTYPE_p_RefT_Physics2DTestMotionResult_t result) {
    bool ret = GodotEnginePINVOKE.Physics2DServer_body_test_motion__SWIG_0(swigCPtr, SWIGTYPE_p_RID.getCPtr(body), ref motion, margin, SWIGTYPE_p_RefT_Physics2DTestMotionResult_t.getCPtr(result));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool body_test_motion(SWIGTYPE_p_RID body, Vector2 motion, float margin) {
    bool ret = GodotEnginePINVOKE.Physics2DServer_body_test_motion__SWIG_1(swigCPtr, SWIGTYPE_p_RID.getCPtr(body), ref motion, margin);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool body_test_motion(SWIGTYPE_p_RID body, Vector2 motion) {
    bool ret = GodotEnginePINVOKE.Physics2DServer_body_test_motion__SWIG_2(swigCPtr, SWIGTYPE_p_RID.getCPtr(body), ref motion);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void joint_set_param(SWIGTYPE_p_RID joint, int param, float value) {
    GodotEnginePINVOKE.Physics2DServer_joint_set_param(swigCPtr, SWIGTYPE_p_RID.getCPtr(joint), param, value);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public float joint_get_param(SWIGTYPE_p_RID joint, int param) {
    float ret = GodotEnginePINVOKE.Physics2DServer_joint_get_param(swigCPtr, SWIGTYPE_p_RID.getCPtr(joint), param);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_RID pin_joint_create(Vector2 anchor, SWIGTYPE_p_RID body_a, SWIGTYPE_p_RID body_b) {
    SWIGTYPE_p_RID ret = new SWIGTYPE_p_RID(GodotEnginePINVOKE.Physics2DServer_pin_joint_create__SWIG_0(swigCPtr, ref anchor, SWIGTYPE_p_RID.getCPtr(body_a), SWIGTYPE_p_RID.getCPtr(body_b)), true);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_RID pin_joint_create(Vector2 anchor, SWIGTYPE_p_RID body_a) {
    SWIGTYPE_p_RID ret = new SWIGTYPE_p_RID(GodotEnginePINVOKE.Physics2DServer_pin_joint_create__SWIG_1(swigCPtr, ref anchor, SWIGTYPE_p_RID.getCPtr(body_a)), true);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_RID groove_joint_create(Vector2 groove1_a, Vector2 groove2_a, Vector2 anchor_b, SWIGTYPE_p_RID body_a, SWIGTYPE_p_RID body_b) {
    SWIGTYPE_p_RID ret = new SWIGTYPE_p_RID(GodotEnginePINVOKE.Physics2DServer_groove_joint_create__SWIG_0(swigCPtr, ref groove1_a, ref groove2_a, ref anchor_b, SWIGTYPE_p_RID.getCPtr(body_a), SWIGTYPE_p_RID.getCPtr(body_b)), true);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_RID groove_joint_create(Vector2 groove1_a, Vector2 groove2_a, Vector2 anchor_b, SWIGTYPE_p_RID body_a) {
    SWIGTYPE_p_RID ret = new SWIGTYPE_p_RID(GodotEnginePINVOKE.Physics2DServer_groove_joint_create__SWIG_1(swigCPtr, ref groove1_a, ref groove2_a, ref anchor_b, SWIGTYPE_p_RID.getCPtr(body_a)), true);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_RID groove_joint_create(Vector2 groove1_a, Vector2 groove2_a, Vector2 anchor_b) {
    SWIGTYPE_p_RID ret = new SWIGTYPE_p_RID(GodotEnginePINVOKE.Physics2DServer_groove_joint_create__SWIG_2(swigCPtr, ref groove1_a, ref groove2_a, ref anchor_b), true);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_RID damped_spring_joint_create(Vector2 anchor_a, Vector2 anchor_b, SWIGTYPE_p_RID body_a, SWIGTYPE_p_RID body_b) {
    SWIGTYPE_p_RID ret = new SWIGTYPE_p_RID(GodotEnginePINVOKE.Physics2DServer_damped_spring_joint_create__SWIG_0(swigCPtr, ref anchor_a, ref anchor_b, SWIGTYPE_p_RID.getCPtr(body_a), SWIGTYPE_p_RID.getCPtr(body_b)), true);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_RID damped_spring_joint_create(Vector2 anchor_a, Vector2 anchor_b, SWIGTYPE_p_RID body_a) {
    SWIGTYPE_p_RID ret = new SWIGTYPE_p_RID(GodotEnginePINVOKE.Physics2DServer_damped_spring_joint_create__SWIG_1(swigCPtr, ref anchor_a, ref anchor_b, SWIGTYPE_p_RID.getCPtr(body_a)), true);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void damped_string_joint_set_param(SWIGTYPE_p_RID joint, int param, float value) {
    GodotEnginePINVOKE.Physics2DServer_damped_string_joint_set_param(swigCPtr, SWIGTYPE_p_RID.getCPtr(joint), param, value);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public float damped_string_joint_get_param(SWIGTYPE_p_RID joint, int param) {
    float ret = GodotEnginePINVOKE.Physics2DServer_damped_string_joint_get_param(swigCPtr, SWIGTYPE_p_RID.getCPtr(joint), param);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int joint_get_type(SWIGTYPE_p_RID joint) {
    int ret = GodotEnginePINVOKE.Physics2DServer_joint_get_type(swigCPtr, SWIGTYPE_p_RID.getCPtr(joint));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void free_rid(SWIGTYPE_p_RID rid) {
    GodotEnginePINVOKE.Physics2DServer_free_rid(swigCPtr, SWIGTYPE_p_RID.getCPtr(rid));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_active(bool active) {
    GodotEnginePINVOKE.Physics2DServer_set_active(swigCPtr, active);
  }

  public int get_process_info(int process_info) {
    int ret = GodotEnginePINVOKE.Physics2DServer_get_process_info(swigCPtr, process_info);
    return ret;
  }

  private static Physics2DServer SingletonGetInstance() {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.Physics2DServer_SingletonGetInstance();
    Physics2DServer ret = (cPtr == global::System.IntPtr.Zero) ? null : new Physics2DServer(cPtr, false);
    return ret;
  }

}

}
