/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace GodotEngine {

public class CanvasItem : Node {
  public static readonly int BLEND_MODE_MIX = 0;
  public static readonly int BLEND_MODE_ADD = 1;
  public static readonly int BLEND_MODE_SUB = 2;
  public static readonly int BLEND_MODE_MUL = 3;
  public static readonly int BLEND_MODE_PREMULT_ALPHA = 4;
  public static readonly int NOTIFICATION_DRAW = 30;
  public static readonly int NOTIFICATION_VISIBILITY_CHANGED = 31;
  public static readonly int NOTIFICATION_ENTER_CANVAS = 32;
  public static readonly int NOTIFICATION_EXIT_CANVAS = 33;
  public static readonly int NOTIFICATION_TRANSFORM_CHANGED = 29;

  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
  internal CanvasItem(global::System.IntPtr cPtr, bool cMemoryOwn) : base(GodotEnginePINVOKE.CanvasItem_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }  
  
  protected CanvasItem(bool cMemoryOwn) : base(cMemoryOwn) {}
  
  new internal void internal_init(global::System.IntPtr cPtr) {
    base.internal_init(GodotEnginePINVOKE.CanvasItem_SWIGUpcast(cPtr));
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }
  
  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CanvasItem obj) {
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

  internal CanvasItem() {}


  public void _draw() {
    GodotEnginePINVOKE.CanvasItem__draw(swigCPtr);
  }

  public void edit_set_state(Variant state) {
    GodotEnginePINVOKE.CanvasItem_edit_set_state(swigCPtr, Variant.getCPtr(state));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void edit_get() {
    GodotEnginePINVOKE.CanvasItem_edit_get(swigCPtr);
  }

  public void edit_set_rect(SWIGTYPE_p_Rect2 rect) {
    GodotEnginePINVOKE.CanvasItem_edit_set_rect(swigCPtr, SWIGTYPE_p_Rect2.getCPtr(rect));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void edit_rotate(float degrees) {
    GodotEnginePINVOKE.CanvasItem_edit_rotate(swigCPtr, degrees);
  }

  public SWIGTYPE_p_Rect2 get_item_rect() {
    SWIGTYPE_p_Rect2 ret = new SWIGTYPE_p_Rect2(GodotEnginePINVOKE.CanvasItem_get_item_rect(swigCPtr), true);
    return ret;
  }

  public SWIGTYPE_p_RID get_canvas_item() {
    SWIGTYPE_p_RID ret = new SWIGTYPE_p_RID(GodotEnginePINVOKE.CanvasItem_get_canvas_item(swigCPtr), true);
    return ret;
  }

  public bool is_visible() {
    bool ret = GodotEnginePINVOKE.CanvasItem_is_visible(swigCPtr);
    return ret;
  }

  public bool is_hidden() {
    bool ret = GodotEnginePINVOKE.CanvasItem_is_hidden(swigCPtr);
    return ret;
  }

  public void show() {
    GodotEnginePINVOKE.CanvasItem_show(swigCPtr);
  }

  public void hide() {
    GodotEnginePINVOKE.CanvasItem_hide(swigCPtr);
  }

  public void set_hidden(bool hidden) {
    GodotEnginePINVOKE.CanvasItem_set_hidden(swigCPtr, hidden);
  }

  public void update() {
    GodotEnginePINVOKE.CanvasItem_update(swigCPtr);
  }

  public void set_as_toplevel(bool enable) {
    GodotEnginePINVOKE.CanvasItem_set_as_toplevel(swigCPtr, enable);
  }

  public bool is_set_as_toplevel() {
    bool ret = GodotEnginePINVOKE.CanvasItem_is_set_as_toplevel(swigCPtr);
    return ret;
  }

  public void set_blend_mode(int blend_mode) {
    GodotEnginePINVOKE.CanvasItem_set_blend_mode(swigCPtr, blend_mode);
  }

  public int get_blend_mode() {
    int ret = GodotEnginePINVOKE.CanvasItem_get_blend_mode(swigCPtr);
    return ret;
  }

  public void set_light_mask(int light_mask) {
    GodotEnginePINVOKE.CanvasItem_set_light_mask(swigCPtr, light_mask);
  }

  public int get_light_mask() {
    int ret = GodotEnginePINVOKE.CanvasItem_get_light_mask(swigCPtr);
    return ret;
  }

  public void set_opacity(float opacity) {
    GodotEnginePINVOKE.CanvasItem_set_opacity(swigCPtr, opacity);
  }

  public float get_opacity() {
    float ret = GodotEnginePINVOKE.CanvasItem_get_opacity(swigCPtr);
    return ret;
  }

  public void set_self_opacity(float self_opacity) {
    GodotEnginePINVOKE.CanvasItem_set_self_opacity(swigCPtr, self_opacity);
  }

  public float get_self_opacity() {
    float ret = GodotEnginePINVOKE.CanvasItem_get_self_opacity(swigCPtr);
    return ret;
  }

  public void set_draw_behind_parent(bool enable) {
    GodotEnginePINVOKE.CanvasItem_set_draw_behind_parent(swigCPtr, enable);
  }

  public bool is_draw_behind_parent_enabled() {
    bool ret = GodotEnginePINVOKE.CanvasItem_is_draw_behind_parent_enabled(swigCPtr);
    return ret;
  }

  public void draw_line(Vector2 from, Vector2 to, SWIGTYPE_p_Color color, float width) {
    GodotEnginePINVOKE.CanvasItem_draw_line__SWIG_0(swigCPtr, ref from, ref to, SWIGTYPE_p_Color.getCPtr(color), width);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void draw_line(Vector2 from, Vector2 to, SWIGTYPE_p_Color color) {
    GodotEnginePINVOKE.CanvasItem_draw_line__SWIG_1(swigCPtr, ref from, ref to, SWIGTYPE_p_Color.getCPtr(color));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void draw_rect(SWIGTYPE_p_Rect2 rect, SWIGTYPE_p_Color color) {
    GodotEnginePINVOKE.CanvasItem_draw_rect(swigCPtr, SWIGTYPE_p_Rect2.getCPtr(rect), SWIGTYPE_p_Color.getCPtr(color));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void draw_circle(Vector2 pos, float radius, SWIGTYPE_p_Color color) {
    GodotEnginePINVOKE.CanvasItem_draw_circle(swigCPtr, ref pos, radius, SWIGTYPE_p_Color.getCPtr(color));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void draw_texture(SWIGTYPE_p_RefT_Texture_t texture, Vector2 pos, SWIGTYPE_p_Color modulate) {
    GodotEnginePINVOKE.CanvasItem_draw_texture__SWIG_0(swigCPtr, SWIGTYPE_p_RefT_Texture_t.getCPtr(texture), ref pos, SWIGTYPE_p_Color.getCPtr(modulate));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void draw_texture(SWIGTYPE_p_RefT_Texture_t texture, Vector2 pos) {
    GodotEnginePINVOKE.CanvasItem_draw_texture__SWIG_1(swigCPtr, SWIGTYPE_p_RefT_Texture_t.getCPtr(texture), ref pos);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void draw_texture_rect(SWIGTYPE_p_RefT_Texture_t texture, SWIGTYPE_p_Rect2 rect, bool tile, SWIGTYPE_p_Color modulate, bool transpose) {
    GodotEnginePINVOKE.CanvasItem_draw_texture_rect__SWIG_0(swigCPtr, SWIGTYPE_p_RefT_Texture_t.getCPtr(texture), SWIGTYPE_p_Rect2.getCPtr(rect), tile, SWIGTYPE_p_Color.getCPtr(modulate), transpose);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void draw_texture_rect(SWIGTYPE_p_RefT_Texture_t texture, SWIGTYPE_p_Rect2 rect, bool tile, SWIGTYPE_p_Color modulate) {
    GodotEnginePINVOKE.CanvasItem_draw_texture_rect__SWIG_1(swigCPtr, SWIGTYPE_p_RefT_Texture_t.getCPtr(texture), SWIGTYPE_p_Rect2.getCPtr(rect), tile, SWIGTYPE_p_Color.getCPtr(modulate));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void draw_texture_rect(SWIGTYPE_p_RefT_Texture_t texture, SWIGTYPE_p_Rect2 rect, bool tile) {
    GodotEnginePINVOKE.CanvasItem_draw_texture_rect__SWIG_2(swigCPtr, SWIGTYPE_p_RefT_Texture_t.getCPtr(texture), SWIGTYPE_p_Rect2.getCPtr(rect), tile);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void draw_texture_rect_region(SWIGTYPE_p_RefT_Texture_t texture, SWIGTYPE_p_Rect2 rect, SWIGTYPE_p_Rect2 src_rect, SWIGTYPE_p_Color modulate, bool transpose) {
    GodotEnginePINVOKE.CanvasItem_draw_texture_rect_region__SWIG_0(swigCPtr, SWIGTYPE_p_RefT_Texture_t.getCPtr(texture), SWIGTYPE_p_Rect2.getCPtr(rect), SWIGTYPE_p_Rect2.getCPtr(src_rect), SWIGTYPE_p_Color.getCPtr(modulate), transpose);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void draw_texture_rect_region(SWIGTYPE_p_RefT_Texture_t texture, SWIGTYPE_p_Rect2 rect, SWIGTYPE_p_Rect2 src_rect, SWIGTYPE_p_Color modulate) {
    GodotEnginePINVOKE.CanvasItem_draw_texture_rect_region__SWIG_1(swigCPtr, SWIGTYPE_p_RefT_Texture_t.getCPtr(texture), SWIGTYPE_p_Rect2.getCPtr(rect), SWIGTYPE_p_Rect2.getCPtr(src_rect), SWIGTYPE_p_Color.getCPtr(modulate));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void draw_texture_rect_region(SWIGTYPE_p_RefT_Texture_t texture, SWIGTYPE_p_Rect2 rect, SWIGTYPE_p_Rect2 src_rect) {
    GodotEnginePINVOKE.CanvasItem_draw_texture_rect_region__SWIG_2(swigCPtr, SWIGTYPE_p_RefT_Texture_t.getCPtr(texture), SWIGTYPE_p_Rect2.getCPtr(rect), SWIGTYPE_p_Rect2.getCPtr(src_rect));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void draw_style_box(SWIGTYPE_p_RefT_StyleBox_t style_box, SWIGTYPE_p_Rect2 rect) {
    GodotEnginePINVOKE.CanvasItem_draw_style_box(swigCPtr, SWIGTYPE_p_RefT_StyleBox_t.getCPtr(style_box), SWIGTYPE_p_Rect2.getCPtr(rect));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void draw_primitive(SWIGTYPE_p_Vector2Array points, SWIGTYPE_p_ColorArray colors, SWIGTYPE_p_Vector2Array uvs, SWIGTYPE_p_RefT_Texture_t texture, float width) {
    GodotEnginePINVOKE.CanvasItem_draw_primitive__SWIG_0(swigCPtr, SWIGTYPE_p_Vector2Array.getCPtr(points), SWIGTYPE_p_ColorArray.getCPtr(colors), SWIGTYPE_p_Vector2Array.getCPtr(uvs), SWIGTYPE_p_RefT_Texture_t.getCPtr(texture), width);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void draw_primitive(SWIGTYPE_p_Vector2Array points, SWIGTYPE_p_ColorArray colors, SWIGTYPE_p_Vector2Array uvs, SWIGTYPE_p_RefT_Texture_t texture) {
    GodotEnginePINVOKE.CanvasItem_draw_primitive__SWIG_1(swigCPtr, SWIGTYPE_p_Vector2Array.getCPtr(points), SWIGTYPE_p_ColorArray.getCPtr(colors), SWIGTYPE_p_Vector2Array.getCPtr(uvs), SWIGTYPE_p_RefT_Texture_t.getCPtr(texture));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void draw_primitive(SWIGTYPE_p_Vector2Array points, SWIGTYPE_p_ColorArray colors, SWIGTYPE_p_Vector2Array uvs) {
    GodotEnginePINVOKE.CanvasItem_draw_primitive__SWIG_2(swigCPtr, SWIGTYPE_p_Vector2Array.getCPtr(points), SWIGTYPE_p_ColorArray.getCPtr(colors), SWIGTYPE_p_Vector2Array.getCPtr(uvs));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void draw_polygon(SWIGTYPE_p_Vector2Array points, SWIGTYPE_p_ColorArray colors, SWIGTYPE_p_Vector2Array uvs, SWIGTYPE_p_RefT_Texture_t texture) {
    GodotEnginePINVOKE.CanvasItem_draw_polygon__SWIG_0(swigCPtr, SWIGTYPE_p_Vector2Array.getCPtr(points), SWIGTYPE_p_ColorArray.getCPtr(colors), SWIGTYPE_p_Vector2Array.getCPtr(uvs), SWIGTYPE_p_RefT_Texture_t.getCPtr(texture));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void draw_polygon(SWIGTYPE_p_Vector2Array points, SWIGTYPE_p_ColorArray colors, SWIGTYPE_p_Vector2Array uvs) {
    GodotEnginePINVOKE.CanvasItem_draw_polygon__SWIG_1(swigCPtr, SWIGTYPE_p_Vector2Array.getCPtr(points), SWIGTYPE_p_ColorArray.getCPtr(colors), SWIGTYPE_p_Vector2Array.getCPtr(uvs));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void draw_polygon(SWIGTYPE_p_Vector2Array points, SWIGTYPE_p_ColorArray colors) {
    GodotEnginePINVOKE.CanvasItem_draw_polygon__SWIG_2(swigCPtr, SWIGTYPE_p_Vector2Array.getCPtr(points), SWIGTYPE_p_ColorArray.getCPtr(colors));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void draw_colored_polygon(SWIGTYPE_p_Vector2Array points, SWIGTYPE_p_Color color, SWIGTYPE_p_Vector2Array uvs, SWIGTYPE_p_RefT_Texture_t texture) {
    GodotEnginePINVOKE.CanvasItem_draw_colored_polygon__SWIG_0(swigCPtr, SWIGTYPE_p_Vector2Array.getCPtr(points), SWIGTYPE_p_Color.getCPtr(color), SWIGTYPE_p_Vector2Array.getCPtr(uvs), SWIGTYPE_p_RefT_Texture_t.getCPtr(texture));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void draw_colored_polygon(SWIGTYPE_p_Vector2Array points, SWIGTYPE_p_Color color, SWIGTYPE_p_Vector2Array uvs) {
    GodotEnginePINVOKE.CanvasItem_draw_colored_polygon__SWIG_1(swigCPtr, SWIGTYPE_p_Vector2Array.getCPtr(points), SWIGTYPE_p_Color.getCPtr(color), SWIGTYPE_p_Vector2Array.getCPtr(uvs));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void draw_colored_polygon(SWIGTYPE_p_Vector2Array points, SWIGTYPE_p_Color color) {
    GodotEnginePINVOKE.CanvasItem_draw_colored_polygon__SWIG_2(swigCPtr, SWIGTYPE_p_Vector2Array.getCPtr(points), SWIGTYPE_p_Color.getCPtr(color));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void draw_string(SWIGTYPE_p_RefT_Font_t font, Vector2 pos, string text, SWIGTYPE_p_Color modulate, int clip_w) {
    GodotEnginePINVOKE.CanvasItem_draw_string__SWIG_0(swigCPtr, SWIGTYPE_p_RefT_Font_t.getCPtr(font), ref pos, text, SWIGTYPE_p_Color.getCPtr(modulate), clip_w);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void draw_string(SWIGTYPE_p_RefT_Font_t font, Vector2 pos, string text, SWIGTYPE_p_Color modulate) {
    GodotEnginePINVOKE.CanvasItem_draw_string__SWIG_1(swigCPtr, SWIGTYPE_p_RefT_Font_t.getCPtr(font), ref pos, text, SWIGTYPE_p_Color.getCPtr(modulate));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void draw_string(SWIGTYPE_p_RefT_Font_t font, Vector2 pos, string text) {
    GodotEnginePINVOKE.CanvasItem_draw_string__SWIG_2(swigCPtr, SWIGTYPE_p_RefT_Font_t.getCPtr(font), ref pos, text);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public float draw_char(SWIGTYPE_p_RefT_Font_t font, Vector2 pos, string char_, string next, SWIGTYPE_p_Color modulate) {
    float ret = GodotEnginePINVOKE.CanvasItem_draw_char__SWIG_0(swigCPtr, SWIGTYPE_p_RefT_Font_t.getCPtr(font), ref pos, char_, next, SWIGTYPE_p_Color.getCPtr(modulate));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float draw_char(SWIGTYPE_p_RefT_Font_t font, Vector2 pos, string char_, string next) {
    float ret = GodotEnginePINVOKE.CanvasItem_draw_char__SWIG_1(swigCPtr, SWIGTYPE_p_RefT_Font_t.getCPtr(font), ref pos, char_, next);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void draw_set_transform(Vector2 pos, float rot, Vector2 scale) {
    GodotEnginePINVOKE.CanvasItem_draw_set_transform(swigCPtr, ref pos, rot, ref scale);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public Matrix32 get_transform() {
    Matrix32 ret = new Matrix32(GodotEnginePINVOKE.CanvasItem_get_transform(swigCPtr));
    return ret;
}

  public Matrix32 get_global_transform() {
    Matrix32 ret = new Matrix32(GodotEnginePINVOKE.CanvasItem_get_global_transform(swigCPtr));
    return ret;
}

  public Matrix32 get_global_transform_with_canvas() {
    Matrix32 ret = new Matrix32(GodotEnginePINVOKE.CanvasItem_get_global_transform_with_canvas(swigCPtr));
    return ret;
}

  public Matrix32 get_viewport_transform() {
    Matrix32 ret = new Matrix32(GodotEnginePINVOKE.CanvasItem_get_viewport_transform(swigCPtr));
    return ret;
}

  public SWIGTYPE_p_Rect2 get_viewport_rect() {
    SWIGTYPE_p_Rect2 ret = new SWIGTYPE_p_Rect2(GodotEnginePINVOKE.CanvasItem_get_viewport_rect(swigCPtr), true);
    return ret;
  }

  public Matrix32 get_canvas_transform() {
    Matrix32 ret = new Matrix32(GodotEnginePINVOKE.CanvasItem_get_canvas_transform(swigCPtr));
    return ret;
}

  public Vector2 get_local_mouse_pos() {
    Vector2 ret = GodotEnginePINVOKE.CanvasItem_get_local_mouse_pos(swigCPtr);
    return ret;
}

  public Vector2 get_global_mouse_pos() {
    Vector2 ret = GodotEnginePINVOKE.CanvasItem_get_global_mouse_pos(swigCPtr);
    return ret;
}

  public SWIGTYPE_p_RID get_canvas() {
    SWIGTYPE_p_RID ret = new SWIGTYPE_p_RID(GodotEnginePINVOKE.CanvasItem_get_canvas(swigCPtr), true);
    return ret;
  }

  public Object get_world_2d() {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.CanvasItem_get_world_2d(swigCPtr);
    if (cPtr == global::System.IntPtr.Zero)
    	return null;
    Object ret = InternalHelpers.UnmanagedGetManaged(cPtr) as Object;
    return ret;
  }

  public void set_material(SWIGTYPE_p_RefT_CanvasItemMaterial_t material) {
    GodotEnginePINVOKE.CanvasItem_set_material(swigCPtr, SWIGTYPE_p_RefT_CanvasItemMaterial_t.getCPtr(material));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_RefT_CanvasItemMaterial_t get_material() {
    SWIGTYPE_p_RefT_CanvasItemMaterial_t ret = new SWIGTYPE_p_RefT_CanvasItemMaterial_t(GodotEnginePINVOKE.CanvasItem_get_material(swigCPtr), true);
    return ret;
  }

  public void set_use_parent_material(bool enable) {
    GodotEnginePINVOKE.CanvasItem_set_use_parent_material(swigCPtr, enable);
  }

  public bool get_use_parent_material() {
    bool ret = GodotEnginePINVOKE.CanvasItem_get_use_parent_material(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_InputEvent make_input_local(SWIGTYPE_p_InputEvent arg0) {
    SWIGTYPE_p_InputEvent ret = new SWIGTYPE_p_InputEvent(GodotEnginePINVOKE.CanvasItem_make_input_local(swigCPtr, SWIGTYPE_p_InputEvent.getCPtr(arg0)), true);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
