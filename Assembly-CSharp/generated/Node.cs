/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace GodotEngine {

public class Node : Object {
  public static readonly int NOTIFICATION_ENTER_TREE = 10;
  public static readonly int NOTIFICATION_EXIT_TREE = 11;
  public static readonly int NOTIFICATION_MOVED_IN_PARENT = 12;
  public static readonly int NOTIFICATION_READY = 13;
  public static readonly int NOTIFICATION_FIXED_PROCESS = 16;
  public static readonly int NOTIFICATION_PROCESS = 17;
  public static readonly int NOTIFICATION_PARENTED = 18;
  public static readonly int NOTIFICATION_UNPARENTED = 19;
  public static readonly int NOTIFICATION_PAUSED = 14;
  public static readonly int NOTIFICATION_UNPAUSED = 15;
  public static readonly int NOTIFICATION_INSTANCED = 20;
  public static readonly int NOTIFICATION_DRAG_BEGIN = 21;
  public static readonly int NOTIFICATION_DRAG_END = 22;
  public static readonly int PAUSE_MODE_INHERIT = 0;
  public static readonly int PAUSE_MODE_STOP = 1;
  public static readonly int PAUSE_MODE_PROCESS = 2;

  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
  internal Node(global::System.IntPtr cPtr, bool cMemoryOwn) : base(GodotEnginePINVOKE.Node_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }  
  
  protected Node(bool cMemoryOwn) : base(cMemoryOwn) {}
  
  new internal void internal_init(global::System.IntPtr cPtr) {
    base.internal_init(GodotEnginePINVOKE.Node_SWIGUpcast(cPtr));
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }
  
  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Node obj) {
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



  public void _enter_tree() {
    GodotEnginePINVOKE.Node__enter_tree(swigCPtr);
  }

  public void _exit_tree() {
    GodotEnginePINVOKE.Node__exit_tree(swigCPtr);
  }

  public void _fixed_process(float delta) {
    GodotEnginePINVOKE.Node__fixed_process(swigCPtr, delta);
  }

  public void _input(SWIGTYPE_p_InputEvent arg0) {
    GodotEnginePINVOKE.Node__input(swigCPtr, SWIGTYPE_p_InputEvent.getCPtr(arg0));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void _process(float delta) {
    GodotEnginePINVOKE.Node__process(swigCPtr, delta);
  }

  public void _ready() {
    GodotEnginePINVOKE.Node__ready(swigCPtr);
  }

  public void _unhandled_input(SWIGTYPE_p_InputEvent arg0) {
    GodotEnginePINVOKE.Node__unhandled_input(swigCPtr, SWIGTYPE_p_InputEvent.getCPtr(arg0));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void _unhandled_key_input(SWIGTYPE_p_InputEvent key_event) {
    GodotEnginePINVOKE.Node__unhandled_key_input(swigCPtr, SWIGTYPE_p_InputEvent.getCPtr(key_event));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_name(string name) {
    GodotEnginePINVOKE.Node_set_name(swigCPtr, name);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public string get_name() {
    string ret = GodotEnginePINVOKE.Node_get_name(swigCPtr);
    return ret;
  }

  public void add_child(Node node, bool legible_unique_name) {
    GodotEnginePINVOKE.Node_add_child__SWIG_0(swigCPtr, Node.getCPtr(node), legible_unique_name);
  }

  public void add_child(Node node) {
    GodotEnginePINVOKE.Node_add_child__SWIG_1(swigCPtr, Node.getCPtr(node));
  }

  public void remove_child(Node node) {
    GodotEnginePINVOKE.Node_remove_child(swigCPtr, Node.getCPtr(node));
  }

  public int get_child_count() {
    int ret = GodotEnginePINVOKE.Node_get_child_count(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_Array get_children() {
    SWIGTYPE_p_Array ret = new SWIGTYPE_p_Array(GodotEnginePINVOKE.Node_get_children(swigCPtr), true);
    return ret;
  }

  public Node get_child(int idx) {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.Node_get_child(swigCPtr, idx);
    if (cPtr == global::System.IntPtr.Zero)
    	return null;
    Node ret = InternalHelpers.UnmanagedGetManaged(cPtr) as Node;
    return ret;
  }

  public bool has_node(NodePath path) {
    bool ret = GodotEnginePINVOKE.Node_has_node(swigCPtr, NodePath.getCPtr(path));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Node get_node(NodePath path) {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.Node_get_node(swigCPtr, NodePath.getCPtr(path));
    if (cPtr == global::System.IntPtr.Zero)
    	return null;
    Node ret = InternalHelpers.UnmanagedGetManaged(cPtr) as Node;
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Node get_parent() {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.Node_get_parent(swigCPtr);
    if (cPtr == global::System.IntPtr.Zero)
    	return null;
    Node ret = InternalHelpers.UnmanagedGetManaged(cPtr) as Node;
    return ret;
  }

  public Node find_node(string mask, bool recursive, bool owned) {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.Node_find_node__SWIG_0(swigCPtr, mask, recursive, owned);
    if (cPtr == global::System.IntPtr.Zero)
    	return null;
    Node ret = InternalHelpers.UnmanagedGetManaged(cPtr) as Node;
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Node find_node(string mask, bool recursive) {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.Node_find_node__SWIG_1(swigCPtr, mask, recursive);
    if (cPtr == global::System.IntPtr.Zero)
    	return null;
    Node ret = InternalHelpers.UnmanagedGetManaged(cPtr) as Node;
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Node find_node(string mask) {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.Node_find_node__SWIG_2(swigCPtr, mask);
    if (cPtr == global::System.IntPtr.Zero)
    	return null;
    Node ret = InternalHelpers.UnmanagedGetManaged(cPtr) as Node;
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool has_node_and_resource(NodePath path) {
    bool ret = GodotEnginePINVOKE.Node_has_node_and_resource(swigCPtr, NodePath.getCPtr(path));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_Array get_node_and_resource(NodePath path) {
    SWIGTYPE_p_Array ret = new SWIGTYPE_p_Array(GodotEnginePINVOKE.Node_get_node_and_resource(swigCPtr, NodePath.getCPtr(path)), true);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool is_inside_tree() {
    bool ret = GodotEnginePINVOKE.Node_is_inside_tree(swigCPtr);
    return ret;
  }

  public bool is_a_parent_of(Node node) {
    bool ret = GodotEnginePINVOKE.Node_is_a_parent_of(swigCPtr, Node.getCPtr(node));
    return ret;
  }

  public bool is_greater_than(Node node) {
    bool ret = GodotEnginePINVOKE.Node_is_greater_than(swigCPtr, Node.getCPtr(node));
    return ret;
  }

  public NodePath get_path() {
    NodePath ret = new NodePath(GodotEnginePINVOKE.Node_get_path(swigCPtr), true);
    return ret;
  }

  public NodePath get_path_to(Node node) {
    NodePath ret = new NodePath(GodotEnginePINVOKE.Node_get_path_to(swigCPtr, Node.getCPtr(node)), true);
    return ret;
  }

  public void add_to_group(string group, bool persistent) {
    GodotEnginePINVOKE.Node_add_to_group__SWIG_0(swigCPtr, group, persistent);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void add_to_group(string group) {
    GodotEnginePINVOKE.Node_add_to_group__SWIG_1(swigCPtr, group);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void remove_from_group(string group) {
    GodotEnginePINVOKE.Node_remove_from_group(swigCPtr, group);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool is_in_group(string group) {
    bool ret = GodotEnginePINVOKE.Node_is_in_group(swigCPtr, group);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void move_child(Node child_node, int to_pos) {
    GodotEnginePINVOKE.Node_move_child(swigCPtr, Node.getCPtr(child_node), to_pos);
  }

  public SWIGTYPE_p_Array get_groups() {
    SWIGTYPE_p_Array ret = new SWIGTYPE_p_Array(GodotEnginePINVOKE.Node_get_groups(swigCPtr), true);
    return ret;
  }

  public void raise() {
    GodotEnginePINVOKE.Node_raise(swigCPtr);
  }

  public void set_owner(Node owner) {
    GodotEnginePINVOKE.Node_set_owner(swigCPtr, Node.getCPtr(owner));
  }

  public Node get_owner() {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.Node_get_owner(swigCPtr);
    if (cPtr == global::System.IntPtr.Zero)
    	return null;
    Node ret = InternalHelpers.UnmanagedGetManaged(cPtr) as Node;
    return ret;
  }

  public void remove_and_skip() {
    GodotEnginePINVOKE.Node_remove_and_skip(swigCPtr);
  }

  public int get_index() {
    int ret = GodotEnginePINVOKE.Node_get_index(swigCPtr);
    return ret;
  }

  public void print_tree() {
    GodotEnginePINVOKE.Node_print_tree(swigCPtr);
  }

  public void set_filename(string filename) {
    GodotEnginePINVOKE.Node_set_filename(swigCPtr, filename);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public string get_filename() {
    string ret = GodotEnginePINVOKE.Node_get_filename(swigCPtr);
    return ret;
  }

  public void propagate_notification(int what) {
    GodotEnginePINVOKE.Node_propagate_notification(swigCPtr, what);
  }

  public void set_fixed_process(bool enable) {
    GodotEnginePINVOKE.Node_set_fixed_process(swigCPtr, enable);
  }

  public float get_fixed_process_delta_time() {
    float ret = GodotEnginePINVOKE.Node_get_fixed_process_delta_time(swigCPtr);
    return ret;
  }

  public bool is_fixed_processing() {
    bool ret = GodotEnginePINVOKE.Node_is_fixed_processing(swigCPtr);
    return ret;
  }

  public void set_process(bool enable) {
    GodotEnginePINVOKE.Node_set_process(swigCPtr, enable);
  }

  public float get_process_delta_time() {
    float ret = GodotEnginePINVOKE.Node_get_process_delta_time(swigCPtr);
    return ret;
  }

  public bool is_processing() {
    bool ret = GodotEnginePINVOKE.Node_is_processing(swigCPtr);
    return ret;
  }

  public void set_process_input(bool enable) {
    GodotEnginePINVOKE.Node_set_process_input(swigCPtr, enable);
  }

  public bool is_processing_input() {
    bool ret = GodotEnginePINVOKE.Node_is_processing_input(swigCPtr);
    return ret;
  }

  public void set_process_unhandled_input(bool enable) {
    GodotEnginePINVOKE.Node_set_process_unhandled_input(swigCPtr, enable);
  }

  public bool is_processing_unhandled_input() {
    bool ret = GodotEnginePINVOKE.Node_is_processing_unhandled_input(swigCPtr);
    return ret;
  }

  public void set_process_unhandled_key_input(bool enable) {
    GodotEnginePINVOKE.Node_set_process_unhandled_key_input(swigCPtr, enable);
  }

  public bool is_processing_unhandled_key_input() {
    bool ret = GodotEnginePINVOKE.Node_is_processing_unhandled_key_input(swigCPtr);
    return ret;
  }

  public void set_pause_mode(int mode) {
    GodotEnginePINVOKE.Node_set_pause_mode(swigCPtr, mode);
  }

  public int get_pause_mode() {
    int ret = GodotEnginePINVOKE.Node_get_pause_mode(swigCPtr);
    return ret;
  }

  public bool can_process() {
    bool ret = GodotEnginePINVOKE.Node_can_process(swigCPtr);
    return ret;
  }

  public void print_stray_nodes() {
    GodotEnginePINVOKE.Node_print_stray_nodes(swigCPtr);
  }

  public int get_position_in_parent() {
    int ret = GodotEnginePINVOKE.Node_get_position_in_parent(swigCPtr);
    return ret;
  }

  public SceneTree get_tree() {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.Node_get_tree(swigCPtr);
    SceneTree ret = (cPtr == global::System.IntPtr.Zero) ? null : new SceneTree(cPtr, false);
    return ret;
  }

  public Node duplicate(bool use_instancing) {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.Node_duplicate__SWIG_0(swigCPtr, use_instancing);
    if (cPtr == global::System.IntPtr.Zero)
    	return null;
    Node ret = InternalHelpers.UnmanagedGetManaged(cPtr) as Node;
    return ret;
  }

  public Node duplicate() {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.Node_duplicate__SWIG_1(swigCPtr);
    if (cPtr == global::System.IntPtr.Zero)
    	return null;
    Node ret = InternalHelpers.UnmanagedGetManaged(cPtr) as Node;
    return ret;
  }

  public void replace_by(Node node, bool keep_data) {
    GodotEnginePINVOKE.Node_replace_by__SWIG_0(swigCPtr, Node.getCPtr(node), keep_data);
  }

  public void replace_by(Node node) {
    GodotEnginePINVOKE.Node_replace_by__SWIG_1(swigCPtr, Node.getCPtr(node));
  }

  public void set_scene_instance_load_placeholder(bool load_placeholder) {
    GodotEnginePINVOKE.Node_set_scene_instance_load_placeholder(swigCPtr, load_placeholder);
  }

  public bool get_scene_instance_load_placeholder() {
    bool ret = GodotEnginePINVOKE.Node_get_scene_instance_load_placeholder(swigCPtr);
    return ret;
  }

  public Object get_viewport() {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.Node_get_viewport(swigCPtr);
    if (cPtr == global::System.IntPtr.Zero)
    	return null;
    Object ret = InternalHelpers.UnmanagedGetManaged(cPtr) as Object;
    return ret;
  }

  public void queue_free() {
    GodotEnginePINVOKE.Node_queue_free(swigCPtr);
  }

  public Node() : this(false) {
    if (swigCPtr.Handle == global::System.IntPtr.Zero) {
      internal_init(GodotEnginePINVOKE.new_Node());
      InternalHelpers.TieManagedToUnmanaged(this, swigCPtr.Handle);
    }
  }

}

}
