/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace GodotEngine {

public class Tree : Control {
  public static readonly int SELECT_SINGLE = 0;
  public static readonly int SELECT_ROW = 1;
  public static readonly int SELECT_MULTI = 2;
  public static readonly int DROP_MODE_DISABLED = 0;
  public static readonly int DROP_MODE_ON_ITEM = 1;
  public static readonly int DROP_MODE_INBETWEEN = 2;

  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
  internal Tree(global::System.IntPtr cPtr, bool cMemoryOwn) : base(GodotEnginePINVOKE.Tree_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }  
  
  protected Tree(bool cMemoryOwn) : base(cMemoryOwn) {}
  
  new internal void internal_init(global::System.IntPtr cPtr) {
    base.internal_init(GodotEnginePINVOKE.Tree_SWIGUpcast(cPtr));
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }
  
  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Tree obj) {
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



  public void clear() {
    GodotEnginePINVOKE.Tree_clear(swigCPtr);
  }

  public TreeItem create_item(TreeItem parent) {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.Tree_create_item__SWIG_0(swigCPtr, TreeItem.getCPtr(parent));
    TreeItem ret = (cPtr == global::System.IntPtr.Zero) ? null : new TreeItem(cPtr, false);
    return ret;
  }

  public TreeItem create_item() {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.Tree_create_item__SWIG_1(swigCPtr);
    TreeItem ret = (cPtr == global::System.IntPtr.Zero) ? null : new TreeItem(cPtr, false);
    return ret;
  }

  public TreeItem get_root() {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.Tree_get_root(swigCPtr);
    TreeItem ret = (cPtr == global::System.IntPtr.Zero) ? null : new TreeItem(cPtr, false);
    return ret;
  }

  public void set_column_min_width(int column, int min_width) {
    GodotEnginePINVOKE.Tree_set_column_min_width(swigCPtr, column, min_width);
  }

  public void set_column_expand(int column, bool expand) {
    GodotEnginePINVOKE.Tree_set_column_expand(swigCPtr, column, expand);
  }

  public int get_column_width(int column) {
    int ret = GodotEnginePINVOKE.Tree_get_column_width(swigCPtr, column);
    return ret;
  }

  public void set_hide_root(bool enable) {
    GodotEnginePINVOKE.Tree_set_hide_root(swigCPtr, enable);
  }

  public TreeItem get_next_selected(TreeItem from) {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.Tree_get_next_selected(swigCPtr, TreeItem.getCPtr(from));
    TreeItem ret = (cPtr == global::System.IntPtr.Zero) ? null : new TreeItem(cPtr, false);
    return ret;
  }

  public TreeItem get_selected() {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.Tree_get_selected(swigCPtr);
    TreeItem ret = (cPtr == global::System.IntPtr.Zero) ? null : new TreeItem(cPtr, false);
    return ret;
  }

  public int get_selected_column() {
    int ret = GodotEnginePINVOKE.Tree_get_selected_column(swigCPtr);
    return ret;
  }

  public int get_pressed_button() {
    int ret = GodotEnginePINVOKE.Tree_get_pressed_button(swigCPtr);
    return ret;
  }

  public void set_select_mode(int mode) {
    GodotEnginePINVOKE.Tree_set_select_mode(swigCPtr, mode);
  }

  public void set_columns(int amount) {
    GodotEnginePINVOKE.Tree_set_columns(swigCPtr, amount);
  }

  public int get_columns() {
    int ret = GodotEnginePINVOKE.Tree_get_columns(swigCPtr);
    return ret;
  }

  public TreeItem get_edited() {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.Tree_get_edited(swigCPtr);
    TreeItem ret = (cPtr == global::System.IntPtr.Zero) ? null : new TreeItem(cPtr, false);
    return ret;
  }

  public int get_edited_column() {
    int ret = GodotEnginePINVOKE.Tree_get_edited_column(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_Rect2 get_custom_popup_rect() {
    SWIGTYPE_p_Rect2 ret = new SWIGTYPE_p_Rect2(GodotEnginePINVOKE.Tree_get_custom_popup_rect(swigCPtr), true);
    return ret;
  }

  public SWIGTYPE_p_Rect2 get_item_area_rect(TreeItem item, int column) {
    SWIGTYPE_p_Rect2 ret = new SWIGTYPE_p_Rect2(GodotEnginePINVOKE.Tree_get_item_area_rect__SWIG_0(swigCPtr, TreeItem.getCPtr(item), column), true);
    return ret;
  }

  public SWIGTYPE_p_Rect2 get_item_area_rect(TreeItem item) {
    SWIGTYPE_p_Rect2 ret = new SWIGTYPE_p_Rect2(GodotEnginePINVOKE.Tree_get_item_area_rect__SWIG_1(swigCPtr, TreeItem.getCPtr(item)), true);
    return ret;
  }

  public TreeItem get_item_at_pos(Vector2 pos) {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.Tree_get_item_at_pos(swigCPtr, ref pos);
    TreeItem ret = (cPtr == global::System.IntPtr.Zero) ? null : new TreeItem(cPtr, false);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int get_column_at_pos(Vector2 pos) {
    int ret = GodotEnginePINVOKE.Tree_get_column_at_pos(swigCPtr, ref pos);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void ensure_cursor_is_visible() {
    GodotEnginePINVOKE.Tree_ensure_cursor_is_visible(swigCPtr);
  }

  public void set_column_titles_visible(bool visible) {
    GodotEnginePINVOKE.Tree_set_column_titles_visible(swigCPtr, visible);
  }

  public bool are_column_titles_visible() {
    bool ret = GodotEnginePINVOKE.Tree_are_column_titles_visible(swigCPtr);
    return ret;
  }

  public void set_column_title(int column, string title) {
    GodotEnginePINVOKE.Tree_set_column_title(swigCPtr, column, title);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public string get_column_title(int column) {
    string ret = GodotEnginePINVOKE.Tree_get_column_title(swigCPtr, column);
    return ret;
  }

  public Vector2 get_scroll() {
    Vector2 ret = GodotEnginePINVOKE.Tree_get_scroll(swigCPtr);
    return ret;
}

  public void set_hide_folding(bool hide) {
    GodotEnginePINVOKE.Tree_set_hide_folding(swigCPtr, hide);
  }

  public bool is_folding_hidden() {
    bool ret = GodotEnginePINVOKE.Tree_is_folding_hidden(swigCPtr);
    return ret;
  }

  public void set_drop_mode_flags(int flags) {
    GodotEnginePINVOKE.Tree_set_drop_mode_flags(swigCPtr, flags);
  }

  public int get_drop_mode_flags() {
    int ret = GodotEnginePINVOKE.Tree_get_drop_mode_flags(swigCPtr);
    return ret;
  }

  public void set_allow_rmb_select(bool allow) {
    GodotEnginePINVOKE.Tree_set_allow_rmb_select(swigCPtr, allow);
  }

  public bool get_allow_rmb_select() {
    bool ret = GodotEnginePINVOKE.Tree_get_allow_rmb_select(swigCPtr);
    return ret;
  }

  public void set_single_select_cell_editing_only_when_already_selected(bool enable) {
    GodotEnginePINVOKE.Tree_set_single_select_cell_editing_only_when_already_selected(swigCPtr, enable);
  }

  public bool get_single_select_cell_editing_only_when_already_selected() {
    bool ret = GodotEnginePINVOKE.Tree_get_single_select_cell_editing_only_when_already_selected(swigCPtr);
    return ret;
  }

  public Tree() : this(false) {
    if (swigCPtr.Handle == global::System.IntPtr.Zero) {
      internal_init(GodotEnginePINVOKE.new_Tree());
      InternalHelpers.TieManagedToUnmanaged(this, swigCPtr.Handle);
    }
  }

}

}
