/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace GodotEngine {

public class BaseButton : Control {
  public static readonly int DRAW_NORMAL = 0;
  public static readonly int DRAW_PRESSED = 1;
  public static readonly int DRAW_HOVER = 2;
  public static readonly int DRAW_DISABLED = 3;

  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
  internal BaseButton(global::System.IntPtr cPtr, bool cMemoryOwn) : base(GodotEnginePINVOKE.BaseButton_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }  
  
  protected BaseButton(bool cMemoryOwn) : base(cMemoryOwn) {}
  
  new internal void internal_init(global::System.IntPtr cPtr) {
    base.internal_init(GodotEnginePINVOKE.BaseButton_SWIGUpcast(cPtr));
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }
  
  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(BaseButton obj) {
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

  internal BaseButton() {}


  public void _pressed() {
    GodotEnginePINVOKE.BaseButton__pressed(swigCPtr);
  }

  public void _toggled(bool pressed) {
    GodotEnginePINVOKE.BaseButton__toggled(swigCPtr, pressed);
  }

  public void set_pressed(bool pressed) {
    GodotEnginePINVOKE.BaseButton_set_pressed(swigCPtr, pressed);
  }

  public bool is_pressed() {
    bool ret = GodotEnginePINVOKE.BaseButton_is_pressed(swigCPtr);
    return ret;
  }

  public bool is_hovered() {
    bool ret = GodotEnginePINVOKE.BaseButton_is_hovered(swigCPtr);
    return ret;
  }

  public void set_toggle_mode(bool enabled) {
    GodotEnginePINVOKE.BaseButton_set_toggle_mode(swigCPtr, enabled);
  }

  public bool is_toggle_mode() {
    bool ret = GodotEnginePINVOKE.BaseButton_is_toggle_mode(swigCPtr);
    return ret;
  }

  public void set_disabled(bool disabled) {
    GodotEnginePINVOKE.BaseButton_set_disabled(swigCPtr, disabled);
  }

  public bool is_disabled() {
    bool ret = GodotEnginePINVOKE.BaseButton_is_disabled(swigCPtr);
    return ret;
  }

  public void set_click_on_press(bool enable) {
    GodotEnginePINVOKE.BaseButton_set_click_on_press(swigCPtr, enable);
  }

  public bool get_click_on_press() {
    bool ret = GodotEnginePINVOKE.BaseButton_get_click_on_press(swigCPtr);
    return ret;
  }

  public int get_draw_mode() {
    int ret = GodotEnginePINVOKE.BaseButton_get_draw_mode(swigCPtr);
    return ret;
  }

  public void set_enabled_focus_mode(int mode) {
    GodotEnginePINVOKE.BaseButton_set_enabled_focus_mode(swigCPtr, mode);
  }

  public int get_enabled_focus_mode() {
    int ret = GodotEnginePINVOKE.BaseButton_get_enabled_focus_mode(swigCPtr);
    return ret;
  }

  public void set_shortcut(Object shortcut) {
    GodotEnginePINVOKE.BaseButton_set_shortcut(swigCPtr, Object.getCPtr(shortcut));
  }

  public Object get_shortcut() {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.BaseButton_get_shortcut(swigCPtr);
    if (cPtr == global::System.IntPtr.Zero)
    	return null;
    Object ret = InternalHelpers.UnmanagedGetManaged(cPtr) as Object;
    return ret;
  }

}

}
